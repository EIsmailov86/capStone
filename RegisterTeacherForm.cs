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
            // 1) Pull & trim inputs
            string name = txtReTeName.Text.Trim();
            string email = txtReTeEmail.Text.Trim();
            string phone = txtReTePhone.Text.Trim();
            string address = txtReTeAddress.Text.Trim();
            string userName = txtReTeUsername.Text.Trim();
            string password = txtReTePassword.Text;
            string confirmPass = txtReTeConfirmPassword.Text;

            // 2) Validate each field
            if (!InputValidator.IsValidName(name))
            {
                MessageBox.Show("Please enter a valid name (letters, spaces, hyphens).");
                return;
            }
            if (!InputValidator.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (!InputValidator.IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            if (!InputValidator.IsValidAddress(address))
            {
                MessageBox.Show("Please enter a valid address (max 200 chars).");
                return;
            }
            if (!InputValidator.IsValidUserName(userName))
            {
                MessageBox.Show("Usernames must be 3–50 chars, letters/numbers/underscore only.");
                return;
            }
            if (!InputValidator.IsValidPassword(password))
            {
                MessageBox.Show("Passwords must be at least 6 characters long.");
                return;
            }
            if (password != confirmPass)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // 3) Everything’s valid—now proceed with hashing, duplicate‐checks, INSERT…
            string hashedPassword = SecurityHelper.HashPassword(password);

            using (var dbConnection = ConnectToDb())
            {
                try
                {
                    // Duplicate‐username check in teacher table
                    using (var checkTeacher = new MySqlCommand(
                        "SELECT COUNT(*) FROM teacher WHERE UserName = @UserName", dbConnection))
                    {
                        checkTeacher.Parameters.AddWithValue("@UserName", userName);
                        if (Convert.ToInt64(checkTeacher.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show(
                                "This user name is already taken by a teacher.",
                                "Duplicate UserName",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Duplicate‐username check in student table
                    using (var checkStudent = new MySqlCommand(
                        "SELECT COUNT(*) FROM student WHERE UserName = @UserName", dbConnection))
                    {
                        checkStudent.Parameters.AddWithValue("@UserName", userName);
                        if (Convert.ToInt64(checkStudent.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show(
                                "That user name is already taken by a student.",
                                "Duplicate UserName",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Duplicate‐email check in teacher table
                    using (var checkEmail = new MySqlCommand(
                        "SELECT COUNT(*) FROM teacher WHERE Email = @Email", dbConnection))
                    {
                        checkEmail.Parameters.AddWithValue("@Email", email);
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

                    // INSERT new teacher
                    string insertQuery = @"
                        INSERT INTO teacher
                          (AdminId, Name, Email, Phone, Address, UserName, Password, TeClassId, Bio)
                        VALUES
                          (1, @Name, @Email, @Phone, @Address, @UserName, @Password, 1, '')";

                    using (var cmd = new MySqlCommand(insertQuery, dbConnection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@UserName", userName);
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
            string connectionString = "Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";
            var dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }

        private void txtReTePassword_TextChanged(object sender, EventArgs e)
        {
            // no-op
        }

        private void txtReTeUsername_TextChanged(object sender, EventArgs e)
        {
            // no-op
        }
    }
}
