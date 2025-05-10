using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace JEM
{
    public partial class RegisterTeacherForm : Form
    {
        public RegisterTeacherForm()
        {
            InitializeComponent();

        }

        private void btnReTeRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Handler hit!");
            // ensure passwords match
            if (txtReTePassword.Text != txtReTeConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // hash the password once
            string hashedPassword = SecurityHelper.HashPassword(txtReTePassword.Text);

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                try
                {
                    // 1) check duplicate username
                    using (var checkUser = new MySqlCommand(
                        "SELECT COUNT(*) FROM teacher WHERE UserName = @UserName", dbConnection))
                    {
                        checkUser.Parameters.AddWithValue("@UserName", txtReTeUsername.Text.Trim());
                        if (Convert.ToInt64(checkUser.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show(
                                "This user name is already taken. Please choose another.",
                                "Duplicate UserName",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 2) check duplicate email
                    using (var checkEmail = new MySqlCommand(
                        "SELECT COUNT(*) FROM teacher WHERE Email = @Email", dbConnection))
                    {
                        checkEmail.Parameters.AddWithValue("@Email", txtReTeEmail.Text.Trim());
                        if (Convert.ToInt64(checkEmail.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show(
                                "An account with that email already exists.",
                                "Duplicate Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 3) insert new teacher record
                    string insertQuery = @"
                        INSERT INTO teacher
                          (AdminId, Name, Email, Phone, Address, UserName, Password, TeClassId, Bio)
                        VALUES
                          (1, @Name, @Email, @Phone, @Address, @UserName, @Password, 1, '')";

                    using (var cmd = new MySqlCommand(insertQuery, dbConnection))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtReTeName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtReTeEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtReTePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtReTeAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtReTeUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        cmd.ExecuteNonQuery();
                    }

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
            string connectionString =
                "Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";

            var dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }

        private void txtReTePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReTeUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

