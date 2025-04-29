using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEM
{
    public class BaseForm : Form
    {
        // Flag to suppress confirmation when closing programmatically
        protected bool SuppressCloseConfirmation = false;

        // Global Variables
        public static List<Student> students = new List<Student>();
        public static List<Session> sessions = new List<Session>();
        public static List<Teacher> teachers = new List<Teacher>();
        
        public BaseForm()
        {
            this.FormClosing += ConfirmClose;
        }

        private void ConfirmClose(object sender, FormClosingEventArgs e)
        {
            if (SuppressCloseConfirmation)
            {
                return; // Skip confirmation if navigating
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

        public MySqlConnection ConnectToDb()
        {
            string connectionString = $"Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }
    }
}