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
    public partial class TeacherEditForm : BaseForm
    {
        private Teacher loggedInTeacher;

        public TeacherEditForm(Teacher teacher)
        {
            InitializeComponent();
            loggedInTeacher = teacher;
            lblTeEdWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";

            IntializeTeacherInfo();
        }

        // Event handler for Dashboard button
        private void btnTeScDashboards_Click(object sender, EventArgs e)
        {
            var dashboard = new TeacherDashboard(loggedInTeacher);
            dashboard.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close();
        }

        // Event handler for MyStudent button
        private void btnTeScMyStudent_Click(object sender, EventArgs e)
        {
            var studentForm = new TeacherStudentForm(loggedInTeacher);
            studentForm.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close();
        }

        // Event handler for Notifications button
        private void btnTeScNotifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new TeacherNotificationsForm(loggedInTeacher);
            notificationsForm.Show();
            this.SuppressCloseConfirmation = true; // ✅ prevent confirmation on Close
            this.Close();
        }

        private void IntializeTeacherInfo()
        {
            // Check for a teacher object to display their information, the log in form should always add one to the list
            if (loggedInTeacher != null)
            {
                txbName.Text = loggedInTeacher.Name;
                txbPhone.Text = loggedInTeacher.Phone;
                txbAddress.Text = loggedInTeacher.Address;
                txbEmail.Text = loggedInTeacher.Email;
                txbMyBio.Text = loggedInTeacher.Bio;
            }

        }
    }
}