using System;
using System.Windows.Forms;
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
            var loggedIn = false;

            using (MySqlConnection dbConnection = ConnectToDb())
            {
                #region Student
                string studentQuery = "SELECT * FROM student WHERE UserName = @UserName";
                MySqlCommand studentCmd = new MySqlCommand(studentQuery, dbConnection);
                studentCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                studentCmd.Parameters.AddWithValue("@Password", txtPassword.Text);

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
                                ImageStudent = reader["ImageStudent"] != DBNull.Value ? (byte[])reader["ImageStudent"] : null
                            };

                            students.Add(loggedInStudent);

                            var myForm = new studentdashboardform(loggedInStudent);
                            myForm.Show();
                            loggedIn = true;
                        }
                    }
                }
                #endregion

                #region Teacher
                if (!loggedIn)
                {
                    string teacherQuery = "SELECT * FROM teacher WHERE UserName = @UserName";
                    MySqlCommand teacherCmd = new MySqlCommand(teacherQuery, dbConnection);
                    teacherCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    //teacherCmd.Parameters.AddWithValue("@Password", txtPassword.Text);

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
                                    Bio = reader["Bio"].ToString(),
                                    ImageTeacher = reader["ImageTeacher"] != DBNull.Value ? (byte[])reader["ImageTeacher"] : null 
                                };

                                teachers.Add(loggedInTeacher);

                                var myForm = new TeacherDashboard(loggedInTeacher);
                                myForm.Show();
                                loggedIn = true;
                            }
                        }
                        #endregion
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

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnTeacherRegister_Click(object sender, EventArgs e)
        {
            RegisterTeacher registerTeacher = new RegisterTeacher();
            registerTeacher.ShowDialog();

        }
    }
}
