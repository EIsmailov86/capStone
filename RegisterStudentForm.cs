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
using System.Xml.Linq;

namespace JEM
{
    public partial class RegisterStudentForm : Form
    {
        public RegisterStudentForm()
        {
            InitializeComponent();
        }

        private void btnReStRegister_Click(object sender, EventArgs e)
        {
            if (txtReStPassword.Text != txtReStConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string hashedPassword = SecurityHelper.HashPassword(txtReStPassword.Text);

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                try
                {
                    // 1) check duplicate username
                    using (var check = new MySqlCommand(
                           "SELECT COUNT(*) FROM student WHERE UserName = @UserName", dbConnection))
                    {
                        check.Parameters.AddWithValue("@UserName", txtReStUsername.Text.Trim());
                        if (Convert.ToInt64(check.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("This user name is already taken. Please choose another.",
                                            "Duplicate UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 2) (optional) check duplicate email
                    using (var checkEmail = new MySqlCommand(
                           "SELECT COUNT(*) FROM student WHERE Email = @Email", dbConnection))
                    {
                        checkEmail.Parameters.AddWithValue("@Email", txtReStEmail.Text.Trim());
                        if (Convert.ToInt64(checkEmail.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("An account with that email already exists.",
                                            "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 3) now do the insert
                    string insertQuery = @"
                INSERT INTO student 
                  (Name, Email, Phone, Address, UserName, Password, GradeId, ClassId, Bio, TotalBudget, SubjectName)
                VALUES 
                  (@Name, @Email, @Phone, @Address, @UserName, @Password, 1, 1, '', 0, '')";

                    using (var cmd = new MySqlCommand(insertQuery, dbConnection))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtReStName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtReStEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtReStPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtReStAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtReStUsername.Text.Trim());
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
            // testing connections to the remote server

            // this is the original connection string to the mysql workbench version, no touchy
            //LOCAL
            string connectionString = $"Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";


            // New logic for connecting remotely
            // We will need to whitelist the ip for each groupmember and especially for eric
            //string server = "82.163.176.124";
            //string database = "jem_capstonedb";
            //string uid = "jem_admin";
            //string password = "U=)IZKf-aWzj";
            //REMOTE
            //string connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "Uid=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }

        private void txtReStPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReStUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
