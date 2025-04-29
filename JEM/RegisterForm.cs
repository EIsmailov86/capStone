using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace JEM
{
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm()
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
                        INSERT INTO student (Name, Email, Phone, Address, UserName, Password, GradeId, ClassId, Bio, TotalBudget, SubjectName)
                        VALUES (@Name, @Email, @Phone, @Address, @UserName, @Password, 1, 1, '', 0, '')";

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

        private new MySqlConnection ConnectToDb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
