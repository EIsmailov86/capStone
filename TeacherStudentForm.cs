using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
                decimal totalBudget = 0m;

                using (MySqlConnection conn = ConnectToDb())
                {
                    // 1) load basic student info
                    string studentQuery = @"
                SELECT Name, GradeId, Phone, Address, Email, Bio, TotalBudget, ImageStudent
                  FROM student
                 WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(studentQuery, conn);
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txbTeStName.Text = reader["Name"].ToString();
                            cmbTeStGrade.SelectedItem = reader["GradeId"].ToString();
                            txbTeStPhone.Text = reader["Phone"].ToString();
                            txbTeStAddress.Text = reader["Address"].ToString();
                            txbTeStEmail.Text = reader["Email"].ToString();
                            txbTeStTeStBio.Text = reader["Bio"].ToString();

                            totalBudget = reader["TotalBudget"] != DBNull.Value
                                ? Convert.ToDecimal(reader["TotalBudget"])
                                : 0m;

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
                        }
                    }

                    //sum up session costs
                    string sumQuery = "SELECT IFNULL(SUM(Cost),0) FROM session WHERE StudentId = @Id";
                    MySqlCommand sumCmd = new MySqlCommand(sumQuery, conn);
                    sumCmd.Parameters.AddWithValue("@Id", studentId);
                    decimal spent = Convert.ToDecimal(sumCmd.ExecuteScalar());

                    //compute remaining and update UI
                    decimal remaining = totalBudget - spent;
                    lblTeStRemainingBalance.Text = $"${remaining:0.00}";

                    if (totalBudget > 0)
                    {
                        int pct = (int)((remaining / totalBudget) * 100);
                        pgbTeStBalance.Value = Math.Max(0, Math.Min(100, pct));
                    }
                    else
                    {
                        pgbTeStBalance.Value = 0;
                    }

                    if (remaining < 0)
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
            else
            {
                // no selection
                pibTeStStudentPicture.Image = null;
                lblTeStRemainingBalance.Text = "$0.00";
                pgbTeStBalance.Value = 0;
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
                (Name, GradeId, Phone, Address, Email, Bio, TotalBudget, UserName, Password, ClassId)
                 VALUES 
                (@Name, @GradeId, @Phone, @Address, @Email, @Bio, @TotalBudget, @UserName, @Password, @ClassId)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txbTeStName.Text.Trim());
                cmd.Parameters.AddWithValue("@GradeId", cmbTeStGrade.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Phone", txbTeStPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txbTeStAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txbTeStEmail.Text.Trim());

                cmd.Parameters.AddWithValue("@Bio", string.IsNullOrWhiteSpace(txbTeStTeStBio.Text) ? "" : txbTeStTeStBio.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalBudget", startingBalance);
                cmd.Parameters.AddWithValue("@UserName", txbTeStEmail.Text.Trim());
                // hash the default password before inserting
                string initialPlain = "12345";
                string initialHash = SecurityHelper.HashPassword(initialPlain);
                cmd.Parameters.AddWithValue("@Password", initialHash);
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
                            Phone = @Phone, 
                            Address = @Address, 
                            Email = @Email, 
                            Bio = @Bio 
                         WHERE Id = @StudentId";

                ListBoxItem listboxStudent = lbsTeStStudents.SelectedItem as ListBoxItem;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txbTeStName.Text.Trim());
                cmd.Parameters.AddWithValue("@GradeId", cmbTeStGrade.SelectedIndex + 1);
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
            if (!(lbsTeStStudents.SelectedItem is ListBoxItem selectedItem))
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            int studentId = selectedItem.Id;

            if (!decimal.TryParse(txbTeStStartingBalance.Text.Trim(), out decimal deposit))
            {
                MessageBox.Show("Please enter a valid number for the amount to add.");
                return;
            }

            using (var conn = ConnectToDb())
            {
                //add the deposit to their TotalBudget
                using (var cmd = new MySqlCommand(
                    @"UPDATE student 
                 SET TotalBudget = TotalBudget + @Deposit 
               WHERE Id = @StudentId", conn))
                {
                    cmd.Parameters.AddWithValue("@Deposit", deposit);
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        MessageBox.Show("Failed to update balance. Please try again.");
                        return;
                    }
                }

                //fetch the new TotalBudget and total spent
                decimal newTotalBudget, totalSpent;
                using (var cmd2 = new MySqlCommand(
                    @"
            SELECT 
              TotalBudget,
              IFNULL((SELECT SUM(Cost) FROM session WHERE StudentId = @Id), 0) AS TotalSpent
            FROM student
            WHERE Id = @Id", conn))
                {
                    cmd2.Parameters.AddWithValue("@Id", studentId);
                    using (var reader = cmd2.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Failed to refresh balance data.");
                            return;
                        }
                        newTotalBudget = Convert.ToDecimal(reader["TotalBudget"]);
                        totalSpent = Convert.ToDecimal(reader["TotalSpent"]);
                    }
                }

                //compute remaining
                decimal remaining = newTotalBudget - totalSpent;

                //update the UI
                lblTeStRemainingBalance.Text = $"${remaining:0.00}";
                int pct = newTotalBudget > 0
                    ? (int)((remaining / newTotalBudget) * 100)
                    : 0;
                pgbTeStBalance.Value = Math.Max(0, Math.Min(100, pct));

                MessageBox.Show("Balance updated successfully!");

                //refresh TeacherDashboard if it’s open
                if (Application.OpenForms["TeacherDashboard"] is TeacherDashboard dash)
                    dash.InitializeTeacherSchedule();
            }
            // clear the deposit box
            txbTeStStartingBalance.Clear();
        }
        #endregion

        #region Notifications
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (txbMessageHeader.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please fill in the message header field");
            }
            else if (txbMessageBody.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please fill in the message body field");
            }
            else
            {
                if (lbsTeStStudents.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a student");
                }
                else
                {
                    ListBoxItem selectedStudent = lbsTeStStudents.SelectedItem as ListBoxItem;
                    CreateNotifications(2, loggedInTeacher.Id, selectedStudent.Id, txbMessageHeader.Text, txbMessageBody.Text + "\r\n Message sent from " + loggedInTeacher.Name);

                    MessageBox.Show("Message has been Sent");

                    txbMessageHeader.Text = "";
                    txbMessageBody.Text = "";
                }
            }
        }
        #endregion

        #region btnResetPassword
        private void btnTeStResetPassword_Click(object sender, EventArgs e)
        {
            if (!(lbsTeStStudents.SelectedItem is ListBoxItem selectedStudent))
            {
                MessageBox.Show(
                    "Please select a student to reset the password for.",
                    "No Student Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            const string defaultPwd = "123456";
            string tempPwd = Prompt.ShowDialog(
                $"Enter a new temporary password for {selectedStudent.Display}:",
                "Reset Student Password",
                defaultPwd
            ).Trim();

            // 2) allow cancel
            if (string.IsNullOrEmpty(tempPwd))
                return;

            //validate InputValidator
            if (!InputValidator.IsValidPasswordRequirement(tempPwd))
            {
                MessageBox.Show(
                    "Passwords must be at least 6 characters long AND no symbols.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //hash & update
            string hashed = SecurityHelper.HashPassword(tempPwd);
            using (var conn = ConnectToDb())
            using (var cmd = new MySqlCommand(
                "UPDATE student SET Password = @Password WHERE Id = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Password", hashed);
                cmd.Parameters.AddWithValue("@Id", selectedStudent.Id);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show(
                        "Failed to reset password. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }

            MessageBox.Show(
                $"Password for {selectedStudent.Display} has been reset to:\n\n    {tempPwd}\n\n" +
                "Make sure the student changes it on their first login.",
                "Password Reset",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        #endregion


    }
}
