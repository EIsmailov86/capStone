using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JEM
{
    public partial class TeacherStudentForm : BaseForm
    {
        private Teacher loggedInTeacher;

        public TeacherStudentForm(Teacher teacher)
        {
            InitializeComponent();
            loggedInTeacher = teacher;
            this.Load += TeacherStudentForm_Load;
            lblTeStWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";

            LoadTeacherPicture();
            LoadStudentList();
        }

        private void LoadStudentList()
        {
            lbsTeStStudents.Items.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT Id, Name FROM student ORDER BY Name";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListBoxItem item = new ListBoxItem
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Display = reader["Name"].ToString()
                        };
                        lbsTeStStudents.Items.Add(item);
                    }
                }
            }
        }

        private void TeacherStudentForm_Load(object sender, EventArgs e)
        {
            // ✅ Load Grades 1-12
            cmbTeStGrade.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cmbTeStGrade.Items.Add(i.ToString());
            }

            // ✅ Load Subjects from your actual database
            cmbTeStSubject.Items.Clear();
            cmbTeStSubject.Items.AddRange(new string[]
            {
        "Mathematics",
        "Algebra",
        "Geometry",
        "Economy",
        "Science",
        "Social",
        "Calculus",
        "Trigonometry"
            });
        }


        private class ListBoxItem
        {
            public int Id { get; set; }
            public string Display { get; set; }

            public override string ToString()
            {
                return Display; // What shows in the ListBox
            }
        }

        private void lbsTeStStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbsTeStStudents.SelectedItem is ListBoxItem selectedItem)
            {
                int studentId = selectedItem.Id;

                using (MySqlConnection conn = ConnectToDb())
                {
                    string query = "SELECT * FROM student WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", studentId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txbTeStName.Text = reader["Name"].ToString();
                            cmbTeStGrade.SelectedItem = reader["GradeId"].ToString(); // adjust if dropdown values are strings or ints
                            cmbTeStSubject.SelectedItem = reader["SubjectName"].ToString();
                            txbTeStPhone.Text = reader["Phone"].ToString();
                            txbTeStAddress.Text = reader["Address"].ToString();
                            txbTeStEmail.Text = reader["Email"].ToString();
                            txbTeStTeStBio.Text = reader["Bio"].ToString();

                            // Load image (if any)
                            if (reader["ImageStudent"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["ImageStudent"];
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    pibTeStStudentPicture.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pibTeStStudentPicture.Image = null;
                            }

                            // Load balance if needed (optional)
                            lblTeStRemainingBalance.Text = $"${reader["TotalBudget"]:0.00}";
                            pgbTeStBalance.Value = Math.Min(100, Convert.ToInt32(Convert.ToDecimal(reader["TotalBudget"])));
                        }
                    }
                }
            }
        }



        private void LoadTeacherPicture()
        {
            if (loggedInTeacher.ImageTeacher != null)
            {
                using (MemoryStream ms = new MemoryStream(loggedInTeacher.ImageTeacher))
                {
                    pibTeStTeacherPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pibTeStTeacherPicture.Image = null;
            }
        }

        private void btnTeStDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new TeacherDashboard(loggedInTeacher);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTeStMyInfo_Click(object sender, EventArgs e)
        {
            var editForm = new TeacherEditForm(loggedInTeacher);
            editForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTeStNotifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new TeacherNotificationsForm(loggedInTeacher);
            notificationsForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTeStSchedule_Click(object sender, EventArgs e)
        {
            var scheduleForm = new TeacherSchedule(loggedInTeacher);
            scheduleForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void CreateStudent()
        {
            if (string.IsNullOrWhiteSpace(txbTeStName.Text) ||
                cmbTeStGrade.SelectedIndex == -1 ||
                cmbTeStSubject.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txbTeStPhone.Text) ||
                string.IsNullOrWhiteSpace(txbTeStAddress.Text) ||
                string.IsNullOrWhiteSpace(txbTeStEmail.Text))
            {
                MessageBox.Show("Please fill out all required fields: Name, Grade, Subject, Phone, Address, and Email.");
                return;
            }

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"INSERT INTO student 
                        (Name, GradeId, SubjectName, Phone, Address, Email, Bio, TotalBudget, UserName, Password, ClassId)
                         VALUES 
                        (@Name, @GradeId, @SubjectName, @Phone, @Address, @Email, @Bio, @TotalBudget, @UserName, @Password, @ClassId)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txbTeStName.Text.Trim());
                cmd.Parameters.AddWithValue("@GradeId", cmbTeStGrade.SelectedIndex + 1); // index + 1 matches GradeId
                cmd.Parameters.AddWithValue("@SubjectName", cmbTeStSubject.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", txbTeStPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txbTeStAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txbTeStEmail.Text.Trim());

                cmd.Parameters.AddWithValue("@Bio", string.IsNullOrWhiteSpace(txbTeStTeStBio.Text) ? "" : txbTeStTeStBio.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalBudget", 0.00m);
                cmd.Parameters.AddWithValue("@UserName", txbTeStEmail.Text.Trim()); // Use email for username
                cmd.Parameters.AddWithValue("@Password", "12345"); // Default password
                cmd.Parameters.AddWithValue("@ClassId", 1); // Default class (required field)

                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Student created successfully!");
                        ClearStudentFields();
                        lbsTeStStudents.Items.Clear();
                        LoadStudentList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create student. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void btnTeStCreateStudent_Click(object sender, EventArgs e)
        {
           CreateStudent();
        }


        private void ClearStudentFields()
        {
            txbTeStName.Clear();
            cmbTeStGrade.SelectedIndex = -1;
            cmbTeStSubject.SelectedIndex = -1;
            txbTeStPhone.Clear();
            txbTeStAddress.Clear();
            txbTeStEmail.Clear();
            txbTeStTeStBio.Clear();
        }

        private void btnTeStUpdateStudent_Click(object sender, EventArgs e)
{
    if (lbsTeStStudents.SelectedItem == null)
    {
        MessageBox.Show("Please select a student to update.");
        return;
    }

    if (string.IsNullOrWhiteSpace(txbTeStName.Text) ||
        cmbTeStGrade.SelectedItem == null ||
        cmbTeStSubject.SelectedItem == null ||
        string.IsNullOrWhiteSpace(txbTeStPhone.Text) ||
        string.IsNullOrWhiteSpace(txbTeStAddress.Text) ||
        string.IsNullOrWhiteSpace(txbTeStEmail.Text))
    {
        MessageBox.Show("Please fill in all fields.");
        return;
    }

    // Extract student name from the list item (before the comma)
    string selectedListText = lbsTeStStudents.SelectedItem.ToString();
    string selectedStudentName = selectedListText.Split(',')[0].Trim();

    using (MySqlConnection conn = ConnectToDb())
    {
        string query = @"UPDATE student SET 
                            Name = @Name, 
                            GradeId = @GradeId, 
                            SubjectName = @SubjectName,
                            Phone = @Phone, 
                            Address = @Address, 
                            Email = @Email, 
                            Bio = @Bio 
                         WHERE Name = @OriginalName";

        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", txbTeStName.Text.Trim());
        cmd.Parameters.AddWithValue("@GradeId", cmbTeStGrade.SelectedIndex + 1);
        cmd.Parameters.AddWithValue("@SubjectName", cmbTeStSubject.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@Phone", txbTeStPhone.Text.Trim());
        cmd.Parameters.AddWithValue("@Address", txbTeStAddress.Text.Trim());
        cmd.Parameters.AddWithValue("@Email", txbTeStEmail.Text.Trim());
        cmd.Parameters.AddWithValue("@Bio", txbTeStTeStBio.Text.Trim());
        cmd.Parameters.AddWithValue("@OriginalName", selectedStudentName);

        int rows = cmd.ExecuteNonQuery();

        if (rows > 0)
        {
            MessageBox.Show("Student updated successfully.");
            ClearStudentFields();
            lbsTeStStudents.Items.Clear();
            LoadStudentList(); // refresh
        }
        else
        {
            MessageBox.Show("Failed to update student.");
        }
    }
}

        private void btnTeStClear_Click(object sender, EventArgs e)
        {
            ClearStudentFields();
        }

        private void btnTeStDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lbsTeStStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            string selectedStudentLine = lbsTeStStudents.SelectedItem.ToString();
            string studentName = selectedStudentLine.Split(',')[0].Trim(); // name is before first comma

            DialogResult result = MessageBox.Show(
                $"Student {studentName} is linked to sessions. Do you want to delete the student and all their sessions?",
                "Confirm Cascade Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = ConnectToDb())
                {
                    // Get student Id
                    string getIdQuery = "SELECT Id FROM student WHERE Name = @Name LIMIT 1";
                    MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);
                    getIdCmd.Parameters.AddWithValue("@Name", studentName);
                    int studentId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    // Delete sessions first
                    string deleteSessionsQuery = "DELETE FROM session WHERE StudentId = @StudentId";
                    MySqlCommand deleteSessionsCmd = new MySqlCommand(deleteSessionsQuery, conn);
                    deleteSessionsCmd.Parameters.AddWithValue("@StudentId", studentId);
                    deleteSessionsCmd.ExecuteNonQuery();

                    // Now delete the student
                    string deleteStudentQuery = "DELETE FROM student WHERE Id = @StudentId";
                    MySqlCommand deleteStudentCmd = new MySqlCommand(deleteStudentQuery, conn);
                    deleteStudentCmd.Parameters.AddWithValue("@StudentId", studentId);

                    int rows = deleteStudentCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Student and sessions deleted successfully.");
                        ClearStudentFields();
                        lbsTeStStudents.Items.Clear();
                        LoadStudentList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student. Please try again.");
                    }
                }
            }
        }


    }
}
