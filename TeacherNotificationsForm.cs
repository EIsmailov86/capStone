using System;
using System.Drawing;
using System.IO;

namespace JEM
{
    public partial class TeacherNotificationsForm : BaseForm
    {
        private Teacher loggedInTeacher;

        public TeacherNotificationsForm(Teacher teacher)
        {
            InitializeComponent();
            loggedInTeacher = teacher;
            lblTeNoWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";
            LoadTeacherPicture();
        }

        #region LoadTePic
        private void LoadTeacherPicture()
        {
            if (loggedInTeacher.ImageTeacher != null)
            {
                using (MemoryStream ms = new MemoryStream(loggedInTeacher.ImageTeacher))
                {
                    pibTeNoTeacherPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pibTeNoTeacherPicture.Image = null;
            }
        }
        #endregion

        #region Nav Buttons
        private void btnTNSchedule_Click(object sender, EventArgs e)
        {
            var scheduleForm = new TeacherSchedule(loggedInTeacher);
            scheduleForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTNMyStudent_Click(object sender, EventArgs e)
        {
            var studentForm = new TeacherStudentForm(loggedInTeacher);
            studentForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTNMyInfo_Click(object sender, EventArgs e)
        {
            var editForm = new TeacherEditForm(loggedInTeacher);
            editForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTNDashboard_Click(object sender, EventArgs e)
        {
            var dashboardForm = new TeacherDashboard(loggedInTeacher);
            dashboardForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
        #endregion
    }
}
