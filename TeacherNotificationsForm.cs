using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

            InitializeNotifications();
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

        #region Notifications

        private void PopulateNofications()
        {
            notifications.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string newSessionQuery = "SELECT NotificationId, MessageHeading, MessageBody, StudentId, SenderRoleId " +
                "FROM notifications " +
                "WHERE TeacherId = @TeacherId AND SenderRoleId = @SenderId";

                MySqlCommand notificationData = new MySqlCommand(newSessionQuery, conn);
                notificationData.Parameters.AddWithValue("@TeacherId", teachers.First().Id);
                notificationData.Parameters.AddWithValue("@SenderId", 1);

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

        #endregion

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

    }
    }
