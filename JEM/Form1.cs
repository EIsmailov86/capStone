using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JEM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            Student testStudent = new Student();
            testStudent.Name = "John";
            testStudent.Email = "Example@gmail.com";
            testStudent.Phone = "715-773-1111";
            testStudent.Bio = "John is named John";
            testStudent.GradeId = 1;
            testStudent.Budget = new BudgetManager(1000);
            testStudent.SubjectName = "Math";
            testStudent.UserName = "john";
            testStudent.Password = "password";
            testStudent.ClassId = 1;

            Teacher testTeacher = new Teacher();

            testTeacher.AdminId = 1;
            testTeacher.Name = "Adam";
            testTeacher.Email = "Example@gmail.com";
            testTeacher.Phone = "715-773-1111";
            testTeacher.UserName = "adam";
            testTeacher.Password = "password";
            testTeacher.TeClassId = 1;



            InitializeComponent();
            //InitializeTestUsers(testStudent, testTeacher);
        }



        #region Database Operations

        private MySqlConnection ConnectToDb()
        {

            // will have to change this string to YOUR local database connection in Mysql Workbench
            string connectionString = $"Server=127.0.0.1;Database=jem_jed;Uid=root;Pwd=mysql;";

            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();

            return dbConnection;

        }

        // Do not forget to populate the foriegn key tables on your end
        private void InitializeTestUsers(Student student, Teacher teachers)
        {
            // Test student information
            using (MySqlConnection dbConnection = ConnectToDb())
            {

                string insertQuery = "INSERT INTO student (Name, GradeId, Email, Phone, Bio, TotalBudget, SubjectName, UserName, Password, ClassId) " +
                                     "VALUES (@Name, @GradeId, @Email, @Phone, @Bio, @TotalBudget, @SubjectName, @UserName, @Password, @ClassId)";
                MySqlCommand insertStudentCommand = new MySqlCommand(insertQuery, dbConnection);

                insertStudentCommand.Parameters.AddWithValue("@Name", student.Name);
                insertStudentCommand.Parameters.AddWithValue("@GradeId", student.GradeId);
                insertStudentCommand.Parameters.AddWithValue("@Email", student.Email);
                insertStudentCommand.Parameters.AddWithValue("@Phone", student.Phone);
                insertStudentCommand.Parameters.AddWithValue("@Bio", student.Bio ?? string.Empty);
                insertStudentCommand.Parameters.AddWithValue("@TotalBudget", student.Budget.TotalBudget);
                insertStudentCommand.Parameters.AddWithValue("@SubjectName", student.SubjectName);
                insertStudentCommand.Parameters.AddWithValue("@UserName", student.UserName);
                insertStudentCommand.Parameters.AddWithValue("@Password", student.Password);
                insertStudentCommand.Parameters.AddWithValue("@ClassId", student.ClassId);

                insertStudentCommand.ExecuteScalar();

            }

            // Test teacher information
            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string insertQuery = "INSERT INTO teacher (AdminId, Name, Email, Phone, UserName, Password, TeClassId) " +
                                     "VALUES (@AdminId, @Name, @Email, @Phone, @UserName, @Password, @TeClassId)";
                MySqlCommand insertTeacherCommand = new MySqlCommand(insertQuery, dbConnection);

                insertTeacherCommand.Parameters.AddWithValue("@AdminId", teachers.AdminId);
                insertTeacherCommand.Parameters.AddWithValue("@Name", teachers.Name);
                insertTeacherCommand.Parameters.AddWithValue("@Email", teachers.Email);
                insertTeacherCommand.Parameters.AddWithValue("@Phone", teachers.Phone);
                insertTeacherCommand.Parameters.AddWithValue("@UserName", teachers.UserName);
                insertTeacherCommand.Parameters.AddWithValue("@Password", teachers.Password);
                insertTeacherCommand.Parameters.AddWithValue("@TeClassId", teachers.TeClassId);


                insertTeacherCommand.ExecuteScalar();

            }
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var loggedIn = false;

            using (MySqlConnection dbConnection = ConnectToDb())
            {

                string StudentSelectQuery = "SELECT UserName, Password FROM student";
                MySqlCommand searchStudentCommand = new MySqlCommand(StudentSelectQuery, dbConnection);
                MySqlDataReader reader = searchStudentCommand.ExecuteReader();


                while (reader.Read() && loggedIn == false)
                {
                    string userName = reader["UserName"].ToString();
                    string password = reader["Password"].ToString();

                    if (txtUserName.Text.Equals(userName) && txtPassword.Text.Equals(password))
                    {
                        //Open Student Page
                        var myForm = new studentdashboardform();
                        myForm.Show();

                        loggedIn = true;
                    }
                }

                reader.Close();
                

                string TeacherSelectQuery = "SELECT UserName, Password FROM teacher";
                MySqlCommand searchTeacherCommand = new MySqlCommand(TeacherSelectQuery, dbConnection);
                reader = searchTeacherCommand.ExecuteReader();

                while (reader.Read() && loggedIn == false)
                {
                    string userName = reader["UserName"].ToString();
                    string password = reader["Password"].ToString();

                    if (txtUserName.Text.Equals(userName) && txtPassword.Text.Equals(password))
                    {
                        //Open Teacher Page
                        var myForm = new TeacherDashboard();
                        myForm.Show();

                        loggedIn = true;
                    }
                }
            }

            
            txtUserName.Clear();
            txtPassword.Clear();
            if (loggedIn == false)
            {
                MessageBox.Show("Invalid Login Credentials");
            }

        }
    }
}
