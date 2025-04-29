using System;
using System.Linq;

namespace JEM
{
    public partial class StudentEditForm : BaseForm
    {
        private Student loggedInStudent;

        public StudentEditForm(Student student)
        {
            InitializeComponent();
            loggedInStudent = student;
            lblStEdWelcome.Text = $"Welcome, {loggedInStudent.Name}!";

            int[] gradeArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cmbGrade.DataSource = gradeArray;

            IntializeStudentInfo();
        }

        private void btnStEdDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new studentdashboardform(loggedInStudent);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStEdMyTeacher_Click(object sender, EventArgs e)
        {
            var teacherForm = new StudentTeacherForm(loggedInStudent);
            teacherForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStEdNotifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new StudentNotifications(loggedInStudent);
            notificationsForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStEdPayment_Click(object sender, EventArgs e)
        {
            var paymentForm = new StudentExtraForm(loggedInStudent);
            paymentForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            // This method is needed to prevent Designer errors
        }

        private void IntializeStudentInfo()
        {
            // Check for a student object to display their information, the log in form should always add one to the list
            if (students.Count > 0)
            {
                txbName.Text = loggedInStudent.Name;
                txbPhone.Text = loggedInStudent.Phone;
                txbAddress.Text = loggedInStudent.Address;
                txbEmail.Text = loggedInStudent.Email;
                txbMyBio.Text = loggedInStudent.Bio;

                
            }

        }

    }
}
