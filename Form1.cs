using System;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace JEM
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loggedIn = false;
            string enteredUser = txtUserName.Text;
            string enteredPass = txtPassword.Text;

            using (var dbConnection = ConnectToDb())
            {
                // ── STUDENT LOGIN ──────────────────────────────────────────────
                using (var cmd = new MySqlCommand(
                    "SELECT * FROM student WHERE UserName = @UserName LIMIT 1",
                    dbConnection))
                {
                    cmd.Parameters.AddWithValue("@UserName", enteredUser);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader.GetString(reader.GetOrdinal("Password"));
                            if (SecurityHelper.VerifyPassword(enteredPass, storedHash))
                            {
                                // successful login
                                var loggedInStudent = new Student
                                {
                                    Id = reader.GetInt32("Id"),
                                    GradeId = reader.GetInt32("GradeId"),
                                    Name = reader.GetString("Name"),
                                    Email = reader.GetString("Email"),
                                    Phone = reader.GetString("Phone"),
                                    Address = reader.GetString("Address"),
                                    Bio = reader.GetString("Bio"),
                                    Budget = new BudgetManager(reader.GetDecimal("TotalBudget")),
                                    SubjectName = reader.GetString("SubjectName"),
                                    UserName = reader.GetString("UserName"),
                                    Password = storedHash,
                                    ClassId = reader.GetInt32("ClassId"),
                                    ImageStudent = reader["ImageStudent"] != DBNull.Value
                                                    ? (byte[])reader["ImageStudent"]
                                                    : null
                                };

                                students.Add(loggedInStudent);
                                var dashboard = new studentdashboardform(loggedInStudent);
                                dashboard.Show();
                                loggedIn = true;
                            }
                        }
                    }
                }

                // ── TEACHER LOGIN ─────────────────────────────────────────────
                if (!loggedIn)
                {
                    using (var cmd = new MySqlCommand(
                        "SELECT * FROM teacher WHERE UserName = @UserName LIMIT 1",
                        dbConnection))
                    {
                        cmd.Parameters.AddWithValue("@UserName", enteredUser);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader.GetString(reader.GetOrdinal("Password"));
                                if (SecurityHelper.VerifyPassword(enteredPass, storedHash))
                                {
                                    var loggedInTeacher = new Teacher
                                    {
                                        Id = reader.GetInt32("Id"),
                                        AdminId = reader.GetInt32("AdminId"),
                                        Name = reader.GetString("Name"),
                                        Email = reader.GetString("Email"),
                                        Phone = reader.GetString("Phone"),
                                        Address = reader.GetString("Address"),
                                        UserName = reader.GetString("UserName"),
                                        Password = storedHash,
                                        TeClassId = reader.GetInt32("TeClassId"),
                                        Bio = reader.GetString("Bio"),
                                        ImageTeacher = reader["ImageTeacher"] != DBNull.Value
                                                       ? (byte[])reader["ImageTeacher"]
                                                       : null
                                    };

                                    teachers.Add(loggedInTeacher);
                                    var dashboard = new TeacherDashboard(loggedInTeacher);
                                    dashboard.Show();
                                    loggedIn = true;
                                }
                            }
                        }
                    }
                }
            }

            txtUserName.Clear();
            txtPassword.Clear();

            if (!loggedIn)
                MessageBox.Show("Invalid Login Credentials");
        }


        #region Password_KeyDown
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            RegisterStudentForm register = new RegisterStudentForm();
            register.ShowDialog();
        }

        private void btnRegisterTeacher_Click(object sender, EventArgs e)
        {
            RegisterTeacherForm register = new RegisterTeacherForm();
            register.ShowDialog();
        }
    }
}
