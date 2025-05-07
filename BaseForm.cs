using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JEM
{
    public class BaseForm : Form
    {
        //confirmation for closing
        protected bool SuppressCloseConfirmation = false;

        public static List<Student> students = new List<Student>();
        public static List<Session> sessions = new List<Session>();
        public static List<Teacher> teachers = new List<Teacher>();
        public static List<Notifications> notifications = new List<Notifications>();


        public BaseForm()
        {
            this.FormClosing += ConfirmClose;
        }

        #region Confirm Close
        private void ConfirmClose(object sender, FormClosingEventArgs e)
        {
            if (SuppressCloseConfirmation)
            {
                return; //no confirmation navigating
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit this screen?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region ConnectToDb
        public MySqlConnection ConnectToDb()
        {

            //string connectionString = $"Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";

            string connectionString = $"Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }
        #endregion

        #region Notifications
        public void CreateNotifications(int LoggedInUserRole, int TeacherId, int StudentId, string MessageHeader, string MessageBody)
        {
            // Parameter should only be 1 for a student or 2 for a teacher
            // This determines whether the notification is going from a student to a teacher or vice versa

            using (MySqlConnection conn = ConnectToDb())
            {

                string insertQuery = "INSERT INTO notifications (SenderRoleId, TeacherId, StudentId, Date, MessageHeading, MessageBody) " +
                    "VALUES (@SenderRoleId, @TeacherId, @StudentId, @Date, @MessageHeading, @MessageBody);";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue("@SenderRoleId", LoggedInUserRole);
                insertCmd.Parameters.AddWithValue("@TeacherId", TeacherId);
                insertCmd.Parameters.AddWithValue("@StudentId", StudentId);
                insertCmd.Parameters.AddWithValue("@Date", DateTime.Today.ToString("yyyy-M-d"));
                insertCmd.Parameters.AddWithValue("@MessageHeading", MessageHeader);
                insertCmd.Parameters.AddWithValue("@MessageBody", MessageBody);

                insertCmd.ExecuteNonQuery();

            }
        }

        public void DeleteNotification(int NotificationId)
        {

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = "DELETE FROM notifications WHERE NotificationId = @NotificationId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NotificationId", NotificationId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Notification deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete the Notification. Please try again.");
                }
            }

        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}