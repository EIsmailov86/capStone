using System;
using System.Windows.Forms;

namespace JEM
{
    public partial class TeacherDashboard : BaseForm
    {
        private Teacher loggedInTeacher;
        private string userRole;

        public TeacherDashboard(Teacher teacher)
        {
            InitializeComponent();
            loggedInTeacher = teacher;
            userRole = "Teacher"; // Lock role here

            lblTeDaWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";

            this.Load += TeacherDashboard_Load; // Attach load event
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            if (userRole != "Teacher")
            {
                MessageBox.Show("Access denied.");
                this.Close();
            }
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
        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
