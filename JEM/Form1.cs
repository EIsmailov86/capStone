using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JEM
{
    public partial class LoginForm : BaseForm
    {
        private string loggedInRole = ""; // Track who logged in

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loggedIn = false;

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                // ----------- Student Login Check -----------
                string studentQuery = "SELECT * FROM student WHERE UserName = @UserName";
                using (MySqlCommand studentCmd = new MySqlCommand(studentQuery, dbConnection))
                {
                    studentCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);

                    using (MySqlDataReader reader = studentCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPasswordHash = reader["Password"].ToString();
                            if (SecurityHelper.VerifyPassword(txtPassword.Text, storedPasswordHash))
                            {
                                Student loggedInStudent = new Student
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    GradeId = Convert.ToInt32(reader["GradeId"]),
                                    Name = reader["Name"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Bio = reader["Bio"].ToString(),
                                    Budget = new BudgetManager(Convert.ToDecimal(reader["TotalBudget"])),
                                    SubjectName = reader["SubjectName"].ToString(),
                                    UserName = reader["UserName"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    ClassId = Convert.ToInt32(reader["ClassId"]),
                                    ImageStudent = reader["ImageStudent"] != DBNull.Value ? reader["ImageStudent"].ToString() : null
                                };

                                students.Add(loggedInStudent);
                                loggedInRole = "Student"; // Track role
                                var myForm = new studentdashboardform(loggedInStudent);
                                myForm.Show();
                                loggedIn = true;
                            }
                        }
                    }
                }

                if (!loggedIn)
                {
                    // ----------- Teacher Login Check -----------
                    string teacherQuery = "SELECT * FROM teacher WHERE UserName = @UserName";
                    using (MySqlCommand teacherCmd = new MySqlCommand(teacherQuery, dbConnection))
                    {
                        teacherCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);

                        using (MySqlDataReader reader = teacherCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPasswordHash = reader["Password"].ToString();
                                if (SecurityHelper.VerifyPassword(txtPassword.Text, storedPasswordHash))
                                {
                                    Teacher loggedInTeacher = new Teacher
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        AdminId = Convert.ToInt32(reader["AdminId"]),
                                        Name = reader["Name"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        Phone = reader["Phone"].ToString(),
                                        Address = reader["Address"].ToString(),
                                        UserName = reader["UserName"].ToString(),
                                        Password = reader["Password"].ToString(),
                                        TeClassId = Convert.ToInt32(reader["TeClassId"]),
                                        ImageTeacher = reader["ImageTeacher"] != DBNull.Value ? reader["ImageTeacher"].ToString() : null,
                                        Bio = reader["Bio"] != DBNull.Value ? reader["Bio"].ToString() : null
                                    };

                                    teachers.Add(loggedInTeacher);
                                    loggedInRole = "Teacher"; // Track role
                                    var myForm = new TeacherDashboard(loggedInTeacher);
                                    myForm.Show();
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
            {
                MessageBox.Show("Invalid Login Credentials");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        private MySqlConnection ConnectToDb()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
