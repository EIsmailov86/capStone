using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            LoadStudentPicture(); // keep this for student pictures
            LoadTeacherPicture(); // ✅ add this line
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
        }

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

        private void InitializeTeacherScheduleColumns()
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.Columns.Add("SessionId", "SessionId");
            dgvSchedule.Columns["SessionId"].Visible = false;
            dgvSchedule.Columns.Add("SubjectName", "Subject");
            dgvSchedule.Columns.Add("SessionDate", "Date");
            dgvSchedule.Columns.Add("TimeSlot", "Time");
            dgvSchedule.Columns.Add("StudentName", "Student");
            dgvSchedule.Columns.Add("GradeYear", "Grade");
            dgvSchedule.Columns.Add("Cost", "Cost");
        }

        private void InitializeTeacherSchedule()
        {
            InitializeTeacherScheduleColumns();

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string sessionDataQuery = "SELECT se.SessionId, su.subjectName, se.SessionDate, se.Timeslot, te.Name AS teacherName, st.Name AS StudentName, gr.GradeYear, se.Cost " +
                    "FROM session AS se " +
                    "LEFT JOIN subject AS su ON se.SubjectId=su.subjectId " +
                    "LEFT JOIN teacher AS te ON se.TeacherId=te.Id " +
                    "LEFT JOIN gradeyear AS gr ON su.SubjectId=gr.GradeId " +
                    "LEFT JOIN student AS st ON se.StudentId=st.Id " +
                    "WHERE @TeacherId = se.TeacherId";

                MySqlCommand sessiondata = new MySqlCommand(sessionDataQuery, dbConnection);
                sessiondata.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);

                using (MySqlDataReader reader = sessiondata.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Session sessionRow = new Session
                        {
                            SessionId = Convert.ToInt32(reader["SessionId"]),
                            SubjectName = reader["SubjectName"].ToString(),
                            StudentName = reader["StudentName"].ToString(),
                            TeacherName = reader["TeacherName"].ToString(),
                            SessionDate = (DateTime)reader["SessionDate"],
                            TimeSlot = reader["Timeslot"].ToString(),
                            GradeYear = reader["GradeYear"].ToString(),
                            Cost = Convert.ToInt32(reader["Cost"]),
                        };

                        sessions.Add(sessionRow);

                        dgvSchedule.Rows.Add(
                            sessionRow.SessionId,
                            sessionRow.SubjectName,
                            sessionRow.SessionDate.ToShortDateString(),
                            sessionRow.TimeSlot,
                            sessionRow.StudentName,
                            sessionRow.GradeYear,
                            sessionRow.Cost
                        );
                    }
                }
            }
        }

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

        private void LoadStudentPicture()
        {
            picTeDaStudentPicture.Image = null;
        }

        private void btnTeDaDeleteSession_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSchedule.SelectedRows[0];
                int sessionId = Convert.ToInt32(selectedRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this session?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = ConnectToDb())
                    {
                        string query = "DELETE FROM session WHERE SessionId = @SessionId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SessionId", sessionId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            dgvSchedule.Rows.Remove(selectedRow);
                            MessageBox.Show("Session deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the session. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a session to delete.");
            }
        }

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
        //private void LoadTeacherProfilePicture()
        //{
        //    if (loggedInTeacher.ImageTeacher != null)
        //    {
        //        using (var ms = new MemoryStream(loggedInTeacher.ImageTeacher))
        //        {
        //            pibTeDaTeacherPicture.Image = Image.FromStream(ms); // or any target PictureBox
        //        }
        //    }
        //    else
        //    {
        //        pibTeDaTeacherPicture.Image = null; // or load a placeholder
        //    }
        //}

        private void LoadTeacherPicture()
        {
            if (loggedInTeacher.ImageTeacher != null)
            {
                using (MemoryStream ms = new MemoryStream(loggedInTeacher.ImageTeacher))
                {
                    pibTeDaTeacherPicture.Image = Image.FromStream(ms); // ✅ make sure picTeDaTeacherPicture exists
                }
            }
            else
            {
                pibTeDaTeacherPicture.Image = null;
            }
        }


    }
}
