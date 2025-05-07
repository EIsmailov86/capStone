using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            // ————— Core setup —————
            RefreshStudentBudget();
            InitializeStudentSchedule();
            UpdateBalanceProgressBar();

            // ————— Scheduling UI setup —————
            LoadAllSubjects();
            LoadAvailableTimeSlots();
            //dtpStDaSessionDate.ValueChanged += dtpStDaSessionDate_ValueChanged;
            //btnStDaScheduleSession.Click += btnStDaScheduleSession_Click;

            // ————— Filter UI setup —————
            LoadFilterDates();
            LoadFilterSubjects();
            //btnStDaFilterByDate.Click += btnStDaFilterByDate_Click;
            //btnStDaFilterBySubject.Click += btnStDaFilterBySubject_Click;

            LoadTeacher();
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
            // 1) define columns
            InitializeStudentScheduleColumns();
            // 2) clear any existing rows
            dgvSchedule.Rows.Clear();

            decimal totalCost = 0m;
            using (var conn = ConnectToDb())
            {
                var cmd = new MySqlCommand(@"
                    SELECT 
                        se.SessionId,
                        su.SubjectName,
                        se.SessionDate,
                        se.TimeSlot,
                        te.Name       AS TeacherName,
                        gr.GradeYear,
                        se.Cost
                      FROM session se
                      JOIN subject   su ON se.SubjectId = su.SubjectId
                      JOIN teacher   te ON se.TeacherId = te.Id
                      JOIN student   st ON se.StudentId = st.Id
                      JOIN gradeyear gr ON st.GradeId   = gr.GradeId
                     WHERE se.StudentId = @StuId
                     ORDER BY se.SessionDate", conn);

                cmd.Parameters.AddWithValue("@StuId", loggedInStudent.Id);
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int sessId = rdr.GetInt32("SessionId");
                        string subj = rdr.GetString("SubjectName");
                        string date = rdr.GetDateTime("SessionDate").ToShortDateString();
                        string slot = rdr.GetString("TimeSlot");
                        string teacher = rdr.GetString("TeacherName");
                        string gradeYear = rdr.GetString("GradeYear");
                        decimal cost = rdr.GetDecimal("Cost");

                        totalCost += cost;

                        dgvSchedule.Rows.Add(
                            sessId,
                            subj,
                            date,
                            slot,
                            teacher,
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
        private void btnStDaPayment_Click(object sender, EventArgs e)
        {
            var f = new StudentExtraForm(loggedInStudent);
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
                // loads all teachers for now, grouping specific teachers and students by a 'region' or districtId is out of scope for our project
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

                        teachers.Add(teacherRow);

                        // may need to add the teacherRow instead and set displaymember to name
                        cmbStDaTeacher.Items.Add(teacherRow);
                        cmbStDaTeacher.DisplayMember = "Name";
                    }
                }
            }


        }

        #endregion

        #region LoadAvailableTimeSlots
        private void LoadAvailableTimeSlots()
        {
            cmbStDaTime.Items.Clear();

            // gather slots already taken on selected date
            var taken = new List<string>();
            using (var conn = ConnectToDb())
            {
                var chk = new MySqlCommand(@"
                    SELECT TimeSlot
                      FROM session
                     WHERE StudentId   = @sid
                       AND SessionDate = @dt", conn);
                chk.Parameters.AddWithValue("@sid", loggedInStudent.Id);
                chk.Parameters.AddWithValue("@dt", dtpStDaSessionDate.Value.Date);

                using (var rdr = chk.ExecuteReader())
                    while (rdr.Read())
                        taken.Add(rdr.GetString("TimeSlot"));
            }

            // master list
            var allSlots = new[]
            {
                "08:00 - 09:00","09:00 - 10:00","10:00 - 11:00",
                "11:00 - 12:00","12:00 - 13:00","13:00 - 14:00",
                "14:00 - 15:00","15:00 - 16:00","16:00 - 17:00"
            };

            foreach (var s in allSlots)
                if (!taken.Contains(s))
                    cmbStDaTime.Items.Add(s);

            if (cmbStDaTime.Items.Count > 0)
                cmbStDaTime.SelectedIndex = 0;
            else
                MessageBox.Show(
                    "No available time slots on that date.",
                    "Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
        }
        #endregion

        #region dtpStDaSessionDate_ValueChanged
        private void dtpStDaSessionDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }
        #endregion

        #region btnStDaRequestSession_Click
        // private void btnStDaScheduleSession_Click(object sender, EventArgs e)
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
                // prevent double-booking
                var chkStu = new MySqlCommand(@"
                    SELECT COUNT(*) FROM session
                     WHERE StudentId   = @sid
                       AND SessionDate = @dt
                       AND TimeSlot    = @ts", conn);
                chkStu.Parameters.AddWithValue("@sid", loggedInStudent.Id);
                chkStu.Parameters.AddWithValue("@dt", date);
                chkStu.Parameters.AddWithValue("@ts", timeslot);

                if (Convert.ToInt32(chkStu.ExecuteScalar()) > 0)
                {
                    MessageBox.Show(
                        "You already have a session at that time.",
                        "Conflict",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // get a reference to the currently selected teacher in the cmbTeachersBox

                Teacher selectedTeacher = cmbStDaTeacher.SelectedItem as Teacher;

                CreateNotifications(1, selectedTeacher.Id, loggedInStudent.Id,
                    loggedInStudent.Name + " Has requested a tutoring Session on " + date.ToString("M/d/yyyy"),
                    "Requested session detials: \r\n" +
                    "Subject: " + subject + "\r\n" +
                    "Student: " + loggedInStudent.Name + "\r\n" +
                    "Date: " + date.ToString("M/d/yyyy") + "\r\n" +
                    "Time: " + timeslot + "\r\n" );

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
    }
}
