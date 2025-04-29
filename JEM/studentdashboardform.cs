using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace JEM
{
    public partial class studentdashboardform : BaseForm
    {
        private Student loggedInStudent;
        private string userRole;

        public studentdashboardform(Student student)
        {
            InitializeComponent();
            loggedInStudent = student;
            userRole = "Student"; // Add role here

            lblStDaWelcome.Text = $"Welcome, {loggedInStudent.Name}!";

            InitializeStudentSchedule();
        }

        private void studentdashboardform_Load(object sender, EventArgs e)
        {
            if (userRole != "Student")
            {
                MessageBox.Show("Access denied.");
                this.Close();
            }
        }

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

                    while (reader.Read())
                    {
                        var subject = reader["SubjectName"].ToString();
                        var sessionDate = Convert.ToDateTime(reader["SessionDate"]);
                        var timeSlot = reader["TimeSlot"].ToString();
                        var teacherName = reader["TeacherName"].ToString();
                        var gradeYear = reader["GradeYear"].ToString();
                        var cost = Convert.ToDecimal(reader["Cost"]);

                        loggedInStudent.Budget.DeductFromBudget(cost);

                        dgvSchedule.Rows.Add(
                            subject,
                            sessionDate.ToShortDateString(),
                            timeSlot,
                            teacherName,
                            gradeYear,
                            cost,
                            loggedInStudent.Budget.RemainingBudget
                        );
                    }
                }
            }
        }
        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
