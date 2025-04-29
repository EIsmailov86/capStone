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
    public partial class StudentTeacherForm : BaseForm
    {
        private Student loggedInStudent;

        public StudentTeacherForm(Student student)
        {
            InitializeComponent();
            loggedInStudent = student;
            lblStTeWelcome.Text = $"Welcome, {loggedInStudent.Name}!";
        }

        private void btnStTeDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new studentdashboardform(loggedInStudent);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStTeNotifications_Click(object sender, EventArgs e)
        {
            var form = new StudentExtraForm(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStTePayment_Click(object sender, EventArgs e)
        {
            var form = new StudentExtraForm(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStTeMyInfo_Click(object sender, EventArgs e)
        {
            var form = new StudentEditForm(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
    }
}
