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
    public partial class TeacherStudentForm : BaseForm
    {
        private Teacher loggedInTeacher;
        public TeacherStudentForm(Teacher teacher)
        {
            InitializeComponent();
            loggedInTeacher = teacher;
            lblTeStWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";
        }
        //public TeacherStudentForm()
        //{
        //    InitializeComponent();
        //}

        private void btnTeStDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new TeacherDashboard(loggedInTeacher);
            dashboard.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close(); // closes the current TeacherSchedule form
        }

        private void btnTeStSchedule_Click(object sender, EventArgs e)
        {
            var scheduleForm = new TeacherSchedule(loggedInTeacher);
            scheduleForm.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close(); // closes the current TeacherSchedule form
        }

        private void btnTeStNotifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new TeacherNotificationsForm(loggedInTeacher);
            notificationsForm.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close(); // closes the current TeacherSchedule form
        }

        private void btnTeStMyInfo_Click(object sender, EventArgs e)
        {
            var editForm = new TeacherEditForm(loggedInTeacher);
            editForm.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close(); // closes the current TeacherSchedule form
        }
    }
}
