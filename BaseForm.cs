using MySql.Data.MySqlClient;
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
            string connectionString = $"Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }
        #endregion
    }
}