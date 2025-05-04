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

        #region LoadStList
        private void LoadStudentList()
        {
            lbsTeStStudents.Items.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT Id, Name, GradeId, TotalBudget FROM student ORDER BY Name";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string name = reader["Name"].ToString();
                        int gradeId = Convert.ToInt32(reader["GradeId"]);
                        decimal totalBudget = Convert.ToDecimal(reader["TotalBudget"]);

                        ListBoxItem item = new ListBoxItem
                        {
                            Id = id,
                            Display = $"{name} (Grade {gradeId})"
                        };

                        int index = lbsTeStStudents.Items.Add(item);

                        //balance is negative
                        if (totalBudget < 0)
                        {
                            lbsTeStStudents.Items[index] = item;
                            lbsTeStStudents.SelectedIndex = -1; //color change
                            lbsTeStStudents.DrawMode = DrawMode.OwnerDrawFixed;
                            lbsTeStStudents.DrawItem += (s, e) =>
                            {
                                e.DrawBackground();

                                if (e.Index >= 0)
                                {
                                    var studentItem = lbsTeStStudents.Items[e.Index] as ListBoxItem;
                                    if (studentItem != null)
                                    {
                                        if (totalBudget < 0)
                                        {
                                            e.Graphics.FillRectangle(new SolidBrush(Color.LightCoral), e.Bounds);
                                        }

                                        TextRenderer.DrawText(e.Graphics, studentItem.ToString(), e.Font, e.Bounds, Color.Black, TextFormatFlags.Left);
                                    }
                                }

                                e.DrawFocusRectangle();
                            };
                        }
                    }
                }
            }
        }
        #endregion

        #region LoadTeStForm
        private void TeacherStudentForm_Load(object sender, EventArgs e)
        {
            cmbTeStGrade.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cmbTeStGrade.Items.Add(i.ToString());
            }

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
        #endregion

        #region ListBoxItem
        private class ListBoxItem
        {
            public int Id { get; set; }
            public string Display { get; set; }

            public override string ToString()
            {
                return Display;
            }
        }
        #endregion

        #region ListBox_SelectedInx
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
                            cmbTeStGrade.SelectedItem = reader["GradeId"].ToString();
                            cmbTeStSubject.SelectedItem = reader["SubjectName"].ToString();
                            txbTeStPhone.Text = reader["Phone"].ToString();
                            txbTeStAddress.Text = reader["Address"].ToString();
                            txbTeStEmail.Text = reader["Email"].ToString();
                            txbTeStTeStBio.Text = reader["Bio"].ToString();

                            // Load student picture
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

                            //totalBudget
                            decimal totalBudget = reader["TotalBudget"] != DBNull.Value ? Convert.ToDecimal(reader["TotalBudget"]) : 0m;
                            decimal remainingBudget = totalBudget;

                            lblTeStRemainingBalance.Text = $"${remainingBudget:0.00}";

                            if (totalBudget > 0)
                            {
                                int percentage = (int)((remainingBudget / totalBudget) * 100);
                                pgbTeStBalance.Value = Math.Max(0, Math.Min(100, percentage));
                            }
                            else
                            {
                                pgbTeStBalance.Value = 0;
                            }

                            //red
                            if (remainingBudget < 0)
                            {
                                lblTeStRemainingBalance.ForeColor = Color.Red;
                                pgbTeStBalance.ForeColor = Color.Red;
                                pgbTeStBalance.BackColor = Color.Red;
                            }
                            else
                            {
                                lblTeStRemainingBalance.ForeColor = Color.Black;
                                pgbTeStBalance.ForeColor = Color.Green;
                                pgbTeStBalance.BackColor = SystemColors.Control;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region LoadTePic
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
        #endregion

        #region Nav Buttons
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
        #endregion

        #region CreateStudent
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

            //Starting Balance
            decimal startingBalance = 0.00m;
            if (!decimal.TryParse(txbTeStStartingBalance.Text.Trim(), out startingBalance))
            {
                MessageBox.Show("Please enter a valid numeric Starting Balance (or leave blank for $0.00).");
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
                cmd.Parameters.AddWithValue("@GradeId", cmbTeStGrade.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@SubjectName", cmbTeStSubject.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", txbTeStPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txbTeStAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txbTeStEmail.Text.Trim());

                cmd.Parameters.AddWithValue("@Bio", string.IsNullOrWhiteSpace(txbTeStTeStBio.Text) ? "" : txbTeStTeStBio.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalBudget", startingBalance);
                cmd.Parameters.AddWithValue("@UserName", txbTeStEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", "12345");
                cmd.Parameters.AddWithValue("@ClassId", 1);

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
        #endregion

        #region btnCreateStudent
        private void btnTeStCreateStudent_Click(object sender, EventArgs e)
        {
            CreateStudent();
        }
        #endregion

        #region ClearStFields
        private void ClearStudentFields()
        {
            txbTeStName.Clear();
            cmbTeStGrade.SelectedIndex = -1;
            cmbTeStSubject.SelectedIndex = -1;
            txbTeStPhone.Clear();
            txbTeStAddress.Clear();
            txbTeStEmail.Clear();
            txbTeStTeStBio.Clear();
            txbTeStStartingBalance.Clear();
        }
        #endregion

        #region btnUpdateStudent
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
                         WHERE Id = @StudentId";

                ListBoxItem listboxStudent = lbsTeStStudents.SelectedItem as ListBoxItem;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txbTeStName.Text.Trim());
                cmd.Parameters.AddWithValue("@GradeId", cmbTeStGrade.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@SubjectName", cmbTeStSubject.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", txbTeStPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txbTeStAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txbTeStEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Bio", txbTeStTeStBio.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentId", listboxStudent.Id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Student updated successfully.");
                    ClearStudentFields();
                    lbsTeStStudents.Items.Clear();
                    LoadStudentList();
                }
                else
                {
                    MessageBox.Show("Failed to update student.");
                }
            }
        }
        #endregion

        #region btnClear
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
            string studentName = selectedStudentLine.Split(',')[0].Trim();

            DialogResult result = MessageBox.Show(
                $"Student {studentName} is linked to sessions. Do you want to delete the student and all their sessions?",
                "Confirm Cascade Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = ConnectToDb())
                {

                    ListBoxItem listboxStudent = lbsTeStStudents.SelectedItem as ListBoxItem;

                    // Got a reference to the id from the listBoxItem internal class instead of through this query
                    //string getIdQuery = "SELECT Id FROM student WHERE Name = @Name LIMIT 1";
                    //MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);
                    //getIdCmd.Parameters.AddWithValue("@Name", studentName);
                    //int studentId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    string deleteSessionsQuery = "DELETE FROM session WHERE StudentId = @StudentId";
                    MySqlCommand deleteSessionsCmd = new MySqlCommand(deleteSessionsQuery, conn);
                    deleteSessionsCmd.Parameters.AddWithValue("@StudentId", listboxStudent.Id);
                    deleteSessionsCmd.ExecuteNonQuery();

                    string deleteStudentQuery = "DELETE FROM student WHERE Id = @StudentId";
                    MySqlCommand deleteStudentCmd = new MySqlCommand(deleteStudentQuery, conn);
                    deleteStudentCmd.Parameters.AddWithValue("@StudentId", listboxStudent.Id);

                    string deleteNotifications = "DELETE FROM notifications WHERE StudentId = @StudentId";
                    MySqlCommand deleteNotificationCmd = new MySqlCommand(deleteNotifications, conn);
                    deleteNotificationCmd.Parameters.AddWithValue("@StudentId", listboxStudent.Id);

                    int rows = deleteNotificationCmd.ExecuteNonQuery();
                    rows = deleteStudentCmd.ExecuteNonQuery();
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
        #endregion
        private void txbTeStStartingBalance_TextChanged(object sender, EventArgs e)
        {

        }

        #region btnUpdateBalance
        private void btnTeStUpdateBalance_Click(object sender, EventArgs e)
        {
            if (lbsTeStStudents.SelectedItem is ListBoxItem selectedItem)
            {
                int studentId = selectedItem.Id;
                decimal newBudget;

                if (decimal.TryParse(txbTeStStartingBalance.Text.Trim(), out newBudget))
                {
                    using (MySqlConnection conn = ConnectToDb())
                    {
                        string updateQuery = "UPDATE student SET TotalBudget = @TotalBudget WHERE Id = @StudentId";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@TotalBudget", newBudget);
                        cmd.Parameters.AddWithValue("@StudentId", studentId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Balance updated successfully!");

                            // refresh TeacherDashboard if open
                            if (Application.OpenForms["TeacherDashboard"] is TeacherDashboard dashboardForm)
                                dashboardForm.InitializeTeacherSchedule();

                            lblTeStRemainingBalance.Text = $"${newBudget:0.00}";
                            pgbTeStBalance.Value = Math.Min(100, (int)((newBudget / newBudget) * 100));
                        }
                        else
                        {
                            MessageBox.Show("Failed to update balance. Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for the new balance.");
                }
            }
        }
        #endregion

        #region LoadStudentDetails
        private void LoadStudentDetails(int studentId)
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string query = "SELECT * FROM student WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", studentId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // populate your textboxes, picture box, progress bar, etc.
                        txbTeStName.Text = reader["Name"].ToString();
                        cmbTeStGrade.SelectedItem = reader["GradeId"].ToString();
                        cmbTeStSubject.SelectedItem = reader["SubjectName"].ToString();
                        txbTeStPhone.Text = reader["Phone"].ToString();
                        txbTeStAddress.Text = reader["Address"].ToString();
                        txbTeStEmail.Text = reader["Email"].ToString();
                        txbTeStTeStBio.Text = reader["Bio"].ToString();

                        if (reader["ImageStudent"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["ImageStudent"];
                            using (var ms = new MemoryStream(imageBytes))
                                pibTeStStudentPicture.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            pibTeStStudentPicture.Image = null;
                        }

                        decimal totalBudget = reader["TotalBudget"] != DBNull.Value
                                            ? Convert.ToDecimal(reader["TotalBudget"])
                                            : 0m;
                        lblTeStRemainingBalance.Text = $"${totalBudget:0.00}";

                        int progressValue = Math.Max(0, Math.Min(100, (int)totalBudget));
                        pgbTeStBalance.Value = progressValue;
                    }
                }
            }
        }
        #endregion
    }
}
