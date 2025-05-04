using MySql.Data.MySqlClient;
using System;
using System.Linq;
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

            InitializeNotifications();
        }

        #region Nav Buttons
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
        #endregion

        #region Notifications

        private void PopulateNofications()
        {
            notifications.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string newSessionQuery = "SELECT NotificationId, MessageHeading, MessageBody, StudentId, SenderRoleId " +
                "FROM notifications " +
                "WHERE StudentId = @StudentId AND SenderRoleId = @SenderId";

                MySqlCommand notificationData = new MySqlCommand(newSessionQuery, conn);
                notificationData.Parameters.AddWithValue("@StudentId", students.First().Id);
                notificationData.Parameters.AddWithValue("@SenderId", 2);

                using (MySqlDataReader reader = notificationData.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Notifications notificationRow = new Notifications()
                        {
                            NotificationId = Convert.ToInt32(reader["NotificationId"]),
                            MessageHeader = reader["MessageHeading"].ToString(),
                            MessageBody = reader["MessageBody"].ToString(),
                        };

                        notifications.Add(notificationRow);
                    }
                }
            }



        }
        private void InitializeNotifications()
        {
            notifications.Clear();

            PopulateNofications();

            var bindingList = new BindingSource();
            bindingList.DataSource = notifications;

            cmbHeading.DataSource = bindingList;

            cmbHeading.ValueMember = "NotificationId";
            cmbHeading.DisplayMember = "MessageHeader";


            if (notifications.Count == 0)
            {
                cmbHeading.Text = "No New Notifications";
                txbNotifications.Text = "";
            }
        }


        private void LoadMessageBody(object sender, EventArgs e)
        {
            txbNotifications.Clear();
            PopulateNofications();

            Notifications selectedNotification = cmbHeading.SelectedItem as Notifications;
            txbNotifications.Text = selectedNotification.MessageBody;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbHeading.SelectedItem != null)
            {
                Notifications selectedNotification = cmbHeading.SelectedItem as Notifications;
                DeleteNotification(selectedNotification.NotificationId);
                if (notifications.Remove(selectedNotification))
                {
                    MessageBox.Show("Notification Successfully deleted");
                }
                InitializeNotifications();
            }
            else
            {
                MessageBox.Show("Please select a Notification");
            }


        }

        #endregion
    }
}
