using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEM
{
    public partial class TeacherSchedule : BaseForm
    {
        public Teacher loggedInTeacher;
        public TeacherSchedule(Teacher teacher)
        {
            InitializeComponent();
            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher), "Teacher cannot be null.");
            }
            loggedInTeacher = teacher;
            lblWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";
        }

        //public TeacherSchedule()
        //{
        //    InitializeComponent();
        //}

        private void btnTeScDashboards_Click(object sender, EventArgs e)
        {
            var dashboard = new TeacherDashboard(loggedInTeacher);
            dashboard.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close(); // closes the current TeacherSchedule form
        }

        private void btnTeScMyStudent_Click(object sender, EventArgs e)
        {
            var studentForm = new TeacherStudentForm(loggedInTeacher);
            studentForm.Show();

            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close();
        }

        private void btnTeScNotifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new TeacherNotificationsForm(loggedInTeacher);
            notificationsForm.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close(); // closes the current TeacherSchedule form
        }

        private void btnTeScMyInfo_Click(object sender, EventArgs e)
        {
            var editForm = new TeacherEditForm(loggedInTeacher);
            editForm.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close(); // closes the current TeacherSchedule form
        }
    }
}
