using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JEM
{
    public partial class studentdashboardform : BaseForm
    {
        private Student loggedInStudent;

        public studentdashboardform(Student student)
        {
            InitializeComponent();

            if (student == null) throw new ArgumentNullException(nameof(student));
            loggedInStudent = student;
            lblStDaWelcome.Text = $"Welcome, {loggedInStudent.Name}!";

            RefreshStudentBudget();
            InitializeStudentSchedule();
            UpdateBalanceProgressBar();
            LoadAllSubjects();
            LoadAllTimeSlots();
            LoadFilterDates();
            LoadFilterSubjects();
            LoadTeacher();
            LoadStudentPicture();
        }

        #region RefreshStudentBudget
        private void RefreshStudentBudget()
        {
            using (var conn = ConnectToDb())
            {
                var cmd = new MySqlCommand(
                    "SELECT TotalBudget FROM student WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", loggedInStudent.Id);
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    loggedInStudent.Budget = new BudgetManager(Convert.ToDecimal(result));
            }
        }
        #endregion

        #region InitializeStudentScheduleColumns
        private void InitializeStudentScheduleColumns()
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.Columns.Add("SessionId", "SessionId");
            dgvSchedule.Columns["SessionId"].Visible = false;
            dgvSchedule.Columns.Add("SubjectName", "Subject");
            dgvSchedule.Columns.Add("SessionDate", "Date");
            dgvSchedule.Columns.Add("TimeSlot", "Time");
            dgvSchedule.Columns.Add("TeacherName", "Teacher");
            dgvSchedule.Columns.Add("GradeYear", "Grade");
            dgvSchedule.Columns.Add("Cost", "Cost");
        }
        #endregion

        #region InitializeStudentSchedule
        private void InitializeStudentSchedule()
        {
            InitializeStudentScheduleColumns();
            dgvSchedule.Rows.Clear();

            int sqlCount = 0, gridCount = 0;
            decimal totalCost = 0m;

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string sessionDataQuery = @"
            SELECT 
                se.SessionId,
                su.SubjectName,
                se.SessionDate,
                se.TimeSlot,
                te.Name       AS TeacherName,
                gr.GradeYear,
                se.Cost
              FROM session   AS se
         LEFT JOIN subject   AS su ON se.SubjectId  = su.SubjectId
         LEFT JOIN teacher   AS te ON se.TeacherId  = te.Id
         LEFT JOIN student   AS st ON se.StudentId  = st.Id
         LEFT JOIN gradeyear AS gr ON st.GradeId    = gr.GradeId
             WHERE se.StudentId = @StudentId
          ORDER BY se.SessionDate, su.SubjectName";

                MySqlCommand cmd = new MySqlCommand(sessionDataQuery, dbConnection);
                cmd.Parameters.AddWithValue("@StudentId", loggedInStudent.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sqlCount++;

                        int sessionId = Convert.ToInt32(reader["SessionId"]);
                        string subject = reader["SubjectName"].ToString();
                        DateTime date = Convert.ToDateTime(reader["SessionDate"]);
                        string timeslot = reader["TimeSlot"].ToString();
                        string teacherName = reader["TeacherName"].ToString();
                        string gradeYear = reader["GradeYear"].ToString();
                        decimal cost = Convert.ToDecimal(reader["Cost"]);
                        totalCost += cost;

                        dgvSchedule.Rows.Add(
                            sessionId,
                            subject,
                            date.ToShortDateString(),
                            timeslot,
                            teacherName,
                            gradeYear,
                            cost
                        );
                    }
                }
            }

            // update budget
            loggedInStudent.Budget.RemainingBudget =
                loggedInStudent.Budget.TotalBudget - totalCost;

            UpdateBalanceProgressBar();

            if (loggedInStudent.Budget.RemainingBudget < 0)
            {
                MessageBox.Show(
                    "Warning: Your account balance is overdue. Please make a payment soon.",
                    "Balance Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        #endregion

        #region UpdateBalanceProgressBar
        private void UpdateBalanceProgressBar()
        {
            if (loggedInStudent.Budget == null) return;

            int progress = Math.Max(0, Math.Min(
                100,
                loggedInStudent.Budget.CalculateProgress()
            ));
            pgbStDaBalance.Value = progress;
            lblStDaRemainingBalance.Text =
                $"Remaining Balance: ${loggedInStudent.Budget.RemainingBudget:0.00}";

            if (loggedInStudent.Budget.RemainingBudget < 0)
            {
                pgbStDaBalance.ForeColor = Color.Red;
                pgbStDaBalance.BackColor = Color.LightPink;
                lblStDaRemainingBalance.ForeColor = Color.Red;
            }
            else
            {
                pgbStDaBalance.ForeColor = SystemColors.HighlightText;
                pgbStDaBalance.BackColor = SystemColors.Highlight;
                lblStDaRemainingBalance.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Navigation Buttons
        private void btnStDaMyTeacher_Click(object sender, EventArgs e)
        {
            var f = new StudentTeacherForm(loggedInStudent);
            f.Show();
            SuppressCloseConfirmation = true;
            Close();
        }
        private void btnStDaNotifications_Click(object sender, EventArgs e)
        {
            var f = new StudentNotifications(loggedInStudent);
            f.Show();
            SuppressCloseConfirmation = true;
            Close();
        }

        private void btnStDaMyInfo_Click(object sender, EventArgs e)
        {
            var f = new StudentEditForm(loggedInStudent);
            f.Show();
            SuppressCloseConfirmation = true;
            Close();
        }
        #endregion

        #region LoadAllSubjects
        private void LoadAllSubjects()
        {
            cmbStDaSubject.Items.Clear();
            using (var conn = ConnectToDb())
            {
                var cmd = new MySqlCommand(
                    "SELECT SubjectName FROM subject ORDER BY SubjectName", conn);
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        cmbStDaSubject.Items.Add(rdr.GetString("SubjectName"));
            }
            if (cmbStDaSubject.Items.Count > 0)
                cmbStDaSubject.SelectedIndex = 0;
        }
        #endregion

        #region LoadTeachers
        private void LoadTeacher()
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"
                    SELECT DISTINCT t.Name, t.ImageTeacher, t.Bio, t.Id
                    FROM teacher t";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Teacher teacherRow = new Teacher
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        };
                        cmbStDaTeacher.Items.Add(teacherRow);
                        cmbStDaTeacher.DisplayMember = "Name";
                    }
                }
            }
        }
        #endregion

        #region LoadAllTimeSlots 
        private void LoadAllTimeSlots()
        {
            cmbStDaTime.Items.Clear();
            // master list
            var allSlots = new[]
            {
                "08:00 - 09:00","09:00 - 10:00","10:00 - 11:00",
                "11:00 - 12:00","12:00 - 13:00","13:00 - 14:00",
                "14:00 - 15:00","15:00 - 16:00","16:00 - 17:00",
                "17:00 - 18:00","18:00 - 19:00","19:00 - 20:00"
            };

            cmbStDaTime.Items.AddRange(allSlots);
        }
        #endregion

        #region dtpStDaSessionDate_ValueChanged
        private void dtpStDaSessionDate_ValueChanged(object sender, EventArgs e)
        {
            FilterTakenTimeSlots();
        }
        #endregion

        #region btnStDaRequestSession_Click
        private void btnStDaRequestSession_Click(object sender, EventArgs e)
        {
            if (cmbStDaSubject.SelectedItem == null ||
                cmbStDaTime.SelectedItem == null || 
                cmbStDaTeacher.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please pick a subject, date, time and teacher.",
                    "Missing Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            var date = dtpStDaSessionDate.Value.Date;
            var timeslot = cmbStDaTime.Text;
            var subject = cmbStDaSubject.Text;

            using (MySqlConnection conn = ConnectToDb())
            {
                Teacher selectedTeacher = cmbStDaTeacher.SelectedItem as Teacher;

                CreateNotifications(1, selectedTeacher.Id, loggedInStudent.Id,

                    loggedInStudent.Name + " Has requested a tutoring Session on " + dtpStDaSessionDate.Value.ToString("M/d/yyyy"),

                    "Requested session details: \r\n" +
                    "Subject: " + cmbStDaSubject.SelectedItem.ToString() + "\r\n" +
                    "Student: " + loggedInStudent.Name + "\r\n" +
                    "Date: " + dtpStDaSessionDate.Value.ToString("M/d/yyyy") + "\r\n" +
                    "Time: " + cmbStDaTime.SelectedItem.ToString() + "\r\n");
                MessageBox.Show("Message has been created");
            }
        }
        #endregion

        #region LoadFilterDates
        private void LoadFilterDates()
        {
            cmbStDaFilterDate.Items.Clear();
            using (var conn = ConnectToDb())
            {
                var cmd = new MySqlCommand(@"
                    SELECT DISTINCT DATE(SessionDate) AS SessDate
                      FROM session
                     WHERE StudentId = @sid
                     ORDER BY SessDate", conn);
                cmd.Parameters.AddWithValue("@sid", loggedInStudent.Id);
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        cmbStDaFilterDate.Items.Add(
                            rdr.GetDateTime("SessDate").ToString("yyyy-MM-dd")
                        );
            }
            if (cmbStDaFilterDate.Items.Count > 0)
                cmbStDaFilterDate.SelectedIndex = 0;
        }
        #endregion

        #region LoadFilterSubjects
        private void LoadFilterSubjects()
        {
            cmbStDaFilterSubject.Items.Clear();
            using (var conn = ConnectToDb())
            {
                var cmd = new MySqlCommand(@"
                    SELECT DISTINCT su.SubjectName
                      FROM session se
                      JOIN subject su ON se.SubjectId = su.SubjectId
                     WHERE se.StudentId = @sid
                     ORDER BY su.SubjectName", conn);
                cmd.Parameters.AddWithValue("@sid", loggedInStudent.Id);
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        cmbStDaFilterSubject.Items.Add(rdr.GetString("SubjectName"));
            }
            if (cmbStDaFilterSubject.Items.Count > 0)
                cmbStDaFilterSubject.SelectedIndex = 0;
        }
        #endregion

        #region btnStDaFilterByDate_Click
        private void btnStDaFilterByDate_Click(object sender, EventArgs e)
        {
            if (cmbStDaFilterDate.SelectedItem == null)
            {
                MessageBox.Show("Please select a date to filter by.");
                return;
            }
            string sel = cmbStDaFilterDate.SelectedItem.ToString();

            dgvSchedule.Rows.Clear();
            InitializeStudentScheduleColumns();

            using (var conn = ConnectToDb())
            {
                var query = @"
                    SELECT se.SessionId, su.SubjectName, se.SessionDate, se.TimeSlot,
                           te.Name AS TeacherName, gr.GradeYear, se.Cost
                      FROM session se
                      LEFT JOIN subject   su ON se.SubjectId = su.SubjectId
                      LEFT JOIN teacher   te ON se.TeacherId  = te.Id
                      LEFT JOIN gradeyear gr ON se.StudentId  = gr.GradeId
                     WHERE se.StudentId = @sid
                       AND DATE(se.SessionDate) = @dt
                     ORDER BY se.SessionDate";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", loggedInStudent.Id);
                cmd.Parameters.AddWithValue("@dt", sel);

                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        dgvSchedule.Rows.Add(
                            rdr["SessionId"],
                            rdr["SubjectName"].ToString(),
                            Convert.ToDateTime(rdr["SessionDate"]).ToShortDateString(),
                            rdr["TimeSlot"].ToString(),
                            rdr["TeacherName"].ToString(),
                            rdr["GradeYear"].ToString(),
                            rdr["Cost"].ToString()
                        );
            }
        }
        #endregion

        #region btnStDaFilterBySubject_Click
        private void btnStDaFilterBySubject_Click(object sender, EventArgs e)
        {
            if (cmbStDaFilterSubject.SelectedItem == null)
            {
                MessageBox.Show("Please select a subject to filter by.");
                return;
            }
            string sub = cmbStDaFilterSubject.SelectedItem.ToString();

            dgvSchedule.Rows.Clear();
            InitializeStudentScheduleColumns();

            using (var conn = ConnectToDb())
            {
                var query = @"
                    SELECT se.SessionId, su.SubjectName, se.SessionDate, se.TimeSlot,
                           te.Name AS TeacherName, gr.GradeYear, se.Cost
                      FROM session se
                      LEFT JOIN subject   su ON se.SubjectId = su.SubjectId
                      LEFT JOIN teacher   te ON se.TeacherId  = te.Id
                      LEFT JOIN gradeyear gr ON se.StudentId  = gr.GradeId
                     WHERE se.StudentId   = @sid
                       AND su.SubjectName = @sub
                     ORDER BY se.SessionDate";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", loggedInStudent.Id);
                cmd.Parameters.AddWithValue("@sub", sub);

                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        dgvSchedule.Rows.Add(
                            rdr["SessionId"],
                            rdr["SubjectName"].ToString(),
                            Convert.ToDateTime(rdr["SessionDate"]).ToShortDateString(),
                            rdr["TimeSlot"].ToString(),
                            rdr["TeacherName"].ToString(),
                            rdr["GradeYear"].ToString(),
                            rdr["Cost"].ToString()
                        );
            }
        }
        #endregion

        private void SelectedRequestDateChanged(object sender, EventArgs e)
        {
            if (cmbStDaTeacher.SelectedIndex < 0)
            {
                cmbStDaTeacher.SelectedIndex = 0;
            }
            FilterTakenTimeSlots();
        }


        private void FilterTakenTimeSlots()
        {
            LoadAllTimeSlots();
            GetTakenTimeSlots();

            // filter taken time slots
            for (int i = 0; i < sessions.Count; i++)
            {
                if (dtpStDaSessionDate.Value.ToString("M/d/yyyy").Equals(sessions[i].SessionDate.ToString("M/d/yyyy")))
                {
                    for (int j = 0; j < cmbStDaTime.Items.Count; j++)
                    {
                        if (cmbStDaTime.Items[j].ToString().Equals(sessions[i].TimeSlot))
                        {
                            cmbStDaTime.Items.RemoveAt(j);
                        }
                    }
                }
            }
            sessions.Clear();
        }

        private void GetTakenTimeSlots()
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string takenSlotsQuery = "SELECT se.SessionId, se.SessionDate, se.Timeslot, te.Id, st.Id, se.StudentId, se.TeacherId " +
                    "FROM session AS se " +
                    "LEFT JOIN subject AS su ON se.SubjectId=su.subjectId " +
                    "LEFT JOIN teacher AS te ON se.TeacherId=te.Id " +
                    "LEFT JOIN gradeyear AS gr ON su.SubjectId=gr.GradeId " +
                    "LEFT JOIN student AS st ON se.StudentId=st.Id " +
                    "WHERE @TeacherId = se.TeacherId OR @StudentId = se.StudentId";



                var cmd = new MySqlCommand(takenSlotsQuery, conn);
                cmd.Parameters.AddWithValue("@StudentId", loggedInStudent.Id);

                Teacher selectedTeacher = cmbStDaTeacher.SelectedItem as Teacher;
                cmd.Parameters.AddWithValue("@TeacherId", selectedTeacher.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Session newSession = new Session
                        {
                            SessionId = Convert.ToInt32(reader["SessionId"]),
                            SessionDate = Convert.ToDateTime(reader["SessionDate"]),
                            TimeSlot = reader["Timeslot"].ToString(),
                        };
                        // populate sessions array by taken time slot
                        sessions.Add(newSession);
                    }
                }
            }
        }

        private void SelectedTeacherChanged(object sender, EventArgs e)
        {

            cmbStDaTime.Text = "";

            if (cmbStDaTeacher.SelectedIndex > -1)
            {
                FilterTakenTimeSlots();
            }
        }

        private void LoadStudentPicture()
        {
            if (loggedInStudent.ImageStudent != null)
            {
                using (MemoryStream ms = new MemoryStream(loggedInStudent.ImageStudent))
                {
                    pibStDaStudentPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pibStDaStudentPicture.Image = null;
            }
        }
    }
}
