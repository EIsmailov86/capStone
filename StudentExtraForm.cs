using System;

namespace JEM
{
    public partial class StudentExtraForm : BaseForm
    {
        private Student loggedInStudent;

        public StudentExtraForm(Student student)
        {
            InitializeComponent();
            loggedInStudent = student;
            lblStExWelcome.Text = $"Welcome, {loggedInStudent.Name}!";
        }

        #region Nav Buttons
        private void btnStExDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new studentdashboardform(loggedInStudent);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStExMyTeacher_Click(object sender, EventArgs e)
        {
            var form = new StudentTeacherForm(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStExNotification_Click(object sender, EventArgs e)
        {
            var form = new StudentNotifications(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStExMyInfo_Click(object sender, EventArgs e)
        {
            var form = new StudentEditForm(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
        #endregion
    }
}
