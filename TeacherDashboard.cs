using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JEM
{
    public partial class TeacherDashboard : BaseForm
    {
        private Teacher loggedInTeacher;

        public TeacherDashboard(Teacher teacher)
        {
            InitializeComponent();
            loggedInTeacher = teacher;
            lblTeDaWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";
            InitializeTeacherSchedule();
            PopulateSearchFilters();
            LoadStudentPicture();
            LoadTeacherPicture();
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
        }
        #region NavButtons
        private void btnTDSchedule_Click(object sender, EventArgs e)
        {
            TeacherSchedule scheduleForm = new TeacherSchedule(loggedInTeacher);
            scheduleForm.Show();
            this.Hide();
        }

        private void btnTDMyStudent_Click(object sender, EventArgs e)
        {
            TeacherStudentForm studentForm = new TeacherStudentForm(loggedInTeacher);
            studentForm.Show();
            this.Hide();
        }

        private void btnTDNotifications_Click(object sender, EventArgs e)
        {
            TeacherNotificationsForm notificationsForm = new TeacherNotificationsForm(loggedInTeacher);
            notificationsForm.Show();
            this.Hide();
        }

        private void btnTDMyInfo_Click(object sender, EventArgs e)
        {
            TeacherEditForm editForm = new TeacherEditForm(loggedInTeacher);
            editForm.Show();
            this.Hide();
        }
        #endregion

        #region Init TeSchedule
        public void InitializeTeacherSchedule()
        {
            InitializeTeacherScheduleColumns();

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string sessionDataQuery = @"
            SELECT 
                se.SessionId, 
                su.SubjectName, 
                se.SessionDate, 
                se.Timeslot, 
                te.Name AS TeacherName, 
                st.Name AS StudentName, 
                gr.GradeYear, 
                se.Cost,
                st.TotalBudget
            FROM session AS se
            LEFT JOIN subject AS su ON se.SubjectId = su.SubjectId
            LEFT JOIN teacher AS te ON se.TeacherId = te.Id
            LEFT JOIN student AS st ON se.StudentId = st.Id
            LEFT JOIN gradeyear AS gr ON st.GradeId = gr.GradeId
            WHERE se.TeacherId = @TeacherId";

                MySqlCommand sessionDataCmd = new MySqlCommand(sessionDataQuery, dbConnection);
                sessionDataCmd.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);

                using (MySqlDataReader reader = sessionDataCmd.ExecuteReader())
                {
                    dgvSchedule.Rows.Clear();

                    while (reader.Read())
                    {
                        int sessionId = Convert.ToInt32(reader["SessionId"]);
                        string subjectName = reader["SubjectName"].ToString();
                        DateTime sessionDate = Convert.ToDateTime(reader["SessionDate"]);
                        string timeSlot = reader["Timeslot"].ToString();
                        string studentName = reader["StudentName"].ToString();
                        string gradeYear = reader["GradeYear"].ToString();
                        decimal cost = Convert.ToDecimal(reader["Cost"]);
                        decimal totalBudget = Convert.ToDecimal(reader["TotalBudget"]);

                        //remaining balance
                        decimal remainingBalance = totalBudget - cost;

                        int rowIndex = dgvSchedule.Rows.Add(
                            sessionId,
                            subjectName,
                            sessionDate.ToShortDateString(),
                            timeSlot,
                            studentName,
                            gradeYear,
                            cost,
                            remainingBalance
                        );

                        //negative balance
                        if (remainingBalance < 0)
                        {
                            dgvSchedule.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                    }
                }
            }
        }
        #endregion

        #region InitTeScColumns
        private void InitializeTeacherScheduleColumns()
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.Columns.Add("SessionId", "SessionId");
            dgvSchedule.Columns["SessionId"].Visible = false; // hide
            dgvSchedule.Columns.Add("SubjectName", "Subject");
            dgvSchedule.Columns.Add("SessionDate", "Date");
            dgvSchedule.Columns.Add("TimeSlot", "Time");
            dgvSchedule.Columns.Add("StudentName", "Student");
            dgvSchedule.Columns.Add("GradeYear", "Grade");
            dgvSchedule.Columns.Add("Cost", "Session Cost");
            dgvSchedule.Columns.Add("RemainingBudget", "Remaining Balance");
        }
        #endregion

        #region dgvScCellClick
        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedStudentName = dgvSchedule.Rows[e.RowIndex].Cells[4].Value.ToString();

                using (MySqlConnection conn = ConnectToDb())
                {
                    string query = "SELECT ImageStudent, Bio FROM student WHERE Name = @Name LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", selectedStudentName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["ImageStudent"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["ImageStudent"];
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    picTeDaStudentPicture.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                picTeDaStudentPicture.Image = null;
                            }

                            if (reader["Bio"] != DBNull.Value)
                            {
                                txbTeDaBio.Text = reader["Bio"].ToString();
                            }
                            else
                            {
                                txbTeDaBio.Text = "No bio available.";
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region LoadPictures
        private void LoadTeacherPicture()
        {
            if (loggedInTeacher.ImageTeacher != null)
            {
                using (MemoryStream ms = new MemoryStream(loggedInTeacher.ImageTeacher))
                {
                    pibTeDaTeacherPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pibTeDaTeacherPicture.Image = null;
            }
        }
        private void LoadStudentPicture()
        {
            picTeDaStudentPicture.Image = null;
        }
        #endregion

        #region PopulateSearch
        private void PopulateSearchFilters()
        {
            cmbTeDaDate.Items.Clear();
            cmbTeDaSubject.Items.Clear();
            cmbTeDaStudent.Items.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT DISTINCT se.SessionDate, su.SubjectName, st.Name AS StudentName
                         FROM session se
                         LEFT JOIN subject su ON se.SubjectId = su.SubjectId
                         LEFT JOIN student st ON se.StudentId = st.Id
                         WHERE se.TeacherId = @TeacherId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!cmbTeDaDate.Items.Contains(reader["SessionDate"]))
                            cmbTeDaDate.Items.Add(Convert.ToDateTime(reader["SessionDate"]).ToShortDateString());

                        if (!cmbTeDaSubject.Items.Contains(reader["SubjectName"].ToString()))
                            cmbTeDaSubject.Items.Add(reader["SubjectName"].ToString());

                        if (!cmbTeDaStudent.Items.Contains(reader["StudentName"].ToString()))
                            cmbTeDaStudent.Items.Add(reader["StudentName"].ToString());
                    }
                }
            }
        }
        #endregion

        #region Filter Buttons
        private void btnTeDaFilterbyDate_Click(object sender, EventArgs e)
        {
            if (cmbTeDaDate.SelectedItem == null)
            {
                MessageBox.Show("Please select a date to filter by.");
                return;
            }

            string selectedDate = cmbTeDaDate.SelectedItem.ToString();

            dgvSchedule.Rows.Clear();
            InitializeTeacherScheduleColumns();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT se.SessionId, su.SubjectName, se.SessionDate, se.Timeslot,
                                st.Name AS StudentName, gr.GradeYear, se.Cost
                         FROM session se
                         LEFT JOIN subject su ON se.SubjectId = su.SubjectId
                         LEFT JOIN student st ON se.StudentId = st.Id
                         LEFT JOIN gradeyear gr ON su.SubjectId = gr.GradeId
                         WHERE se.TeacherId = @TeacherId AND DATE(se.SessionDate) = @SelectedDate";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);
                cmd.Parameters.AddWithValue("@SelectedDate", Convert.ToDateTime(selectedDate).ToString("yyyy-MM-dd"));

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvSchedule.Rows.Add(
                            reader["SessionId"],
                            reader["SubjectName"].ToString(),
                            Convert.ToDateTime(reader["SessionDate"]).ToShortDateString(),
                            reader["Timeslot"].ToString(),
                            reader["StudentName"].ToString(),
                            reader["GradeYear"].ToString(),
                            reader["Cost"].ToString()
                        );
                    }
                }
            }
        }
        private void btnTeDaFilterbySubject_Click(object sender, EventArgs e)
        {
            if (cmbTeDaSubject.SelectedItem == null)
            {
                MessageBox.Show("Please select a subject to filter by.");
                return;
            }

            string selectedSubject = cmbTeDaSubject.SelectedItem.ToString();

            dgvSchedule.Rows.Clear();
            InitializeTeacherScheduleColumns();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT se.SessionId, su.SubjectName, se.SessionDate, se.Timeslot,
                                st.Name AS StudentName, gr.GradeYear, se.Cost
                         FROM session se
                         LEFT JOIN subject su ON se.SubjectId = su.SubjectId
                         LEFT JOIN student st ON se.StudentId = st.Id
                         LEFT JOIN gradeyear gr ON su.SubjectId = gr.GradeId
                         WHERE se.TeacherId = @TeacherId AND su.SubjectName = @SubjectName";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);
                cmd.Parameters.AddWithValue("@SubjectName", selectedSubject);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvSchedule.Rows.Add(
                            reader["SessionId"],
                            reader["SubjectName"].ToString(),
                            Convert.ToDateTime(reader["SessionDate"]).ToShortDateString(),
                            reader["Timeslot"].ToString(),
                            reader["StudentName"].ToString(),
                            reader["GradeYear"].ToString(),
                            reader["Cost"].ToString()
                        );
                    }
                }
            }
        }

        private void btnTeDaFilterbyStudent_Click(object sender, EventArgs e)
        {
            if (cmbTeDaStudent.SelectedItem == null)
            {
                MessageBox.Show("Please select a student to filter by.");
                return;
            }

            string selectedStudent = cmbTeDaStudent.SelectedItem.ToString();

            dgvSchedule.Rows.Clear();
            InitializeTeacherScheduleColumns();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT se.SessionId, su.SubjectName, se.SessionDate, se.Timeslot,
                                st.Name AS StudentName, gr.GradeYear, se.Cost
                         FROM session se
                         LEFT JOIN subject su ON se.SubjectId = su.SubjectId
                         LEFT JOIN student st ON se.StudentId = st.Id
                         LEFT JOIN gradeyear gr ON su.SubjectId = gr.GradeId
                         WHERE se.TeacherId = @TeacherId AND st.Name = @StudentName";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);
                cmd.Parameters.AddWithValue("@StudentName", selectedStudent);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvSchedule.Rows.Add(
                            reader["SessionId"],
                            reader["SubjectName"].ToString(),
                            Convert.ToDateTime(reader["SessionDate"]).ToShortDateString(),
                            reader["Timeslot"].ToString(),
                            reader["StudentName"].ToString(),
                            reader["GradeYear"].ToString(),
                            reader["Cost"].ToString()
                        );
                    }
                }
            }
        }
        #endregion
    }
}
