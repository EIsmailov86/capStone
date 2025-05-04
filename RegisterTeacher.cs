using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEM
{
    public partial class RegisterTeacher : Form
    {
        public RegisterTeacher()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string hashedPassword = SecurityHelper.HashPassword(txtPassword.Text);

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                try
                {
                    string insertQuery = @"
                        INSERT INTO teacher (Name, Email, Phone, Address, UserName, Password, TeClassId, AdminId, Bio)
                        VALUES (@Name, @Email, @Phone, @Address, @UserName, @Password, 1, 1, '')";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, dbConnection);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public MySqlConnection ConnectToDb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
