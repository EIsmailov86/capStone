using MySql.Data.MySqlClient;
using System;
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
            loggedInStudent = student;
            lblStDaWelcome.Text = $"Welcome, {loggedInStudent.Name}!";
            RefreshStudentBudget();
            InitializeStudentSchedule();
            UpdateBalanceProgressBar();
        }

        #region RefreshStBudget
        private void RefreshStudentBudget()
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string query = "SELECT TotalBudget FROM student WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", loggedInStudent.Id);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    loggedInStudent.Budget = new BudgetManager(Convert.ToDecimal(result));
                }
            }
        }
        #endregion

        #region InitStSchedule
        private void InitializeStudentSchedule()
        {
            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string sessionDataQuery = @"
                SELECT 
                    se.SessionId, 
                    su.SubjectName, 
                    se.SessionDate, 
                    se.TimeSlot, 
                    te.Name AS TeacherName, 
                    st.Name AS StudentName, 
                    gr.GradeYear, 
                    se.Cost 
                FROM session AS se
                LEFT JOIN subject AS su ON se.SubjectId = su.SubjectId
                LEFT JOIN teacher AS te ON se.TeacherId = te.Id
                LEFT JOIN student AS st ON se.StudentId = st.Id
                LEFT JOIN gradeyear AS gr ON st.GradeId = gr.GradeId
                WHERE se.StudentId = @StudentId";

                MySqlCommand cmd = new MySqlCommand(sessionDataQuery, dbConnection);
                cmd.Parameters.AddWithValue("@StudentId", loggedInStudent.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dgvSchedule.Rows.Clear();

                    decimal totalCost = 0;

                    while (reader.Read())
                    {
                        var subject = reader["SubjectName"].ToString();
                        var sessionDate = Convert.ToDateTime(reader["SessionDate"]);
                        var timeSlot = reader["TimeSlot"].ToString();
                        var teacherName = reader["TeacherName"].ToString();
                        var gradeYear = reader["GradeYear"].ToString();
                        var cost = Convert.ToDecimal(reader["Cost"]);

                        totalCost += cost;

                        dgvSchedule.Rows.Add(
                            subject,
                            sessionDate.ToShortDateString(),
                            timeSlot,
                            teacherName,
                            gradeYear,
                            cost
                        );
                    }

                    loggedInStudent.Budget.RemainingBudget = loggedInStudent.Budget.TotalBudget - totalCost;
                }
            }

            UpdateBalanceProgressBar();

            if (loggedInStudent.Budget.RemainingBudget < 0)
            {
                MessageBox.Show("Warning: Your account balance is overdue. Please make a payment soon.",
                "Balance Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region UpdateBalanceBar
        private void UpdateBalanceProgressBar()
        {
            if (loggedInStudent.Budget != null)
            {
                pgbStDaBalance.Value = Math.Max(0, Math.Min(100, loggedInStudent.Budget.CalculateProgress()));

                lblStDaRemainingBalance.Text = $"Remaining Balance: ${loggedInStudent.Budget.RemainingBudget:0.00}";

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
        }
        #endregion

        #region NavButtons
        private void btnStDaMyTeacher_Click(object sender, EventArgs e)
        {
            var myTeacher = new StudentTeacherForm(loggedInStudent);
            myTeacher.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStDaNotifications_Click(object sender, EventArgs e)
        {
            var notifications = new StudentNotifications(loggedInStudent);
            notifications.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStDaPayment_Click(object sender, EventArgs e)
        {
            var payment = new StudentExtraForm(loggedInStudent);
            payment.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStDaMyInfo_Click(object sender, EventArgs e)
        {
            var myInfo = new StudentEditForm(loggedInStudent);
            myInfo.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
        #endregion
    }
}
