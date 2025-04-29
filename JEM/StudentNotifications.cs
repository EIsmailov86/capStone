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
    public partial class StudentNotifications : BaseForm
    {
        private Student loggedInStudent;

        public StudentNotifications(Student student)
        {
            InitializeComponent();
            loggedInStudent = student;
            lblStNoWelcome.Text = $"Welcome, {loggedInStudent.Name}!";
        }

        private void btnStNoMyTeacher_Click(object sender, EventArgs e)
        {
            var myTeacher = new StudentTeacherForm(loggedInStudent);
            myTeacher.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStNoPayment_Click(object sender, EventArgs e)
        {
            var payment = new StudentExtraForm(loggedInStudent);
            payment.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStNoDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new studentdashboardform(loggedInStudent);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStNoMyInfo_Click(object sender, EventArgs e)
        {
            var myInfo = new StudentEditForm(loggedInStudent);
            myInfo.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
    }
}
