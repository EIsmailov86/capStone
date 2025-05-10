using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JEM
{
    public partial class StudentEditForm : BaseForm
    {
        private Student loggedInStudent;

        public StudentEditForm(Student student)
        {
            InitializeComponent();
            loggedInStudent = student;
            lblStEdWelcome.Text = $"Welcome, {loggedInStudent.Name}!";
            int[] gradeArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cmbGrade.DataSource = gradeArray;
            IntializeStudentInfo();
            LoadStudentPicture();

        }
        #region Nav Buttons

        private void btnStEdDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new studentdashboardform(loggedInStudent);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStEdMyTeacher_Click(object sender, EventArgs e)
        {
            var teacherForm = new StudentTeacherForm(loggedInStudent);
            teacherForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStEdNotifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new StudentNotifications(loggedInStudent);
            notificationsForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStEdPayment_Click(object sender, EventArgs e)
        {
            var paymentForm = new StudentExtraForm(loggedInStudent);
            paymentForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            //fix Designer errors
        }
        #endregion

        #region InitStInfo
        private void IntializeStudentInfo()
        {
            if (students.Count > 0)
            {
                txbName.Text = loggedInStudent.Name;
                txbPhone.Text = loggedInStudent.Phone;
                txbAddress.Text = loggedInStudent.Address;
                txbEmail.Text = loggedInStudent.Email;
                txbMyBio.Text = loggedInStudent.Bio;
                cmbGrade.SelectedItem = loggedInStudent.GradeId;
            }
        }
        #endregion

        #region btnUpdate
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string name = txbName.Text.Trim();
                string phone = txbPhone.Text.Trim();
                string address = txbAddress.Text.Trim();
                string email = txbEmail.Text.Trim();
                string bio = txbMyBio.Text.Trim();
                int gradeId = Convert.ToInt32(cmbGrade.SelectedItem);

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
                    MessageBox.Show("Please enter a valid address (max 100 chars).");
                    return;
                }
                if (!InputValidator.IsValidBio(bio))
                {
                    MessageBox.Show("Please keep your bio to 500 characters and avoid angle brackets.");
                    return;
                }
                if (gradeId < 1 || gradeId > 12)
                {
                    MessageBox.Show("Please select a valid grade between 1 and 12.");
                    return;
                }


                string updateQuery = @"
            UPDATE student
            SET Name = @Name,
                Phone = @Phone,
                Address = @Address,
                Email = @Email,
                Bio = @Bio,
                GradeId = @GradeId
            WHERE Id = @Id";

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, dbConnection);

                updateCommand.Parameters.AddWithValue("@Name", txbName.Text);
                updateCommand.Parameters.AddWithValue("@Phone", txbPhone.Text);
                updateCommand.Parameters.AddWithValue("@Address", txbAddress.Text);
                updateCommand.Parameters.AddWithValue("@Email", txbEmail.Text);
                updateCommand.Parameters.AddWithValue("@Bio", txbMyBio.Text);
                updateCommand.Parameters.AddWithValue("@GradeId", cmbGrade.SelectedItem);
                updateCommand.Parameters.AddWithValue("@Id", loggedInStudent.Id);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    loggedInStudent.Name = txbName.Text;
                    loggedInStudent.Phone = txbPhone.Text;
                    loggedInStudent.Address = txbAddress.Text;
                    loggedInStudent.Email = txbEmail.Text;
                    loggedInStudent.Bio = txbMyBio.Text;
                    loggedInStudent.GradeId = Convert.ToInt32(cmbGrade.SelectedItem);

                    MessageBox.Show("Information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.");
                }
            }
        }
        #endregion

        #region btnClear
        private void btnClear_Click(object sender, EventArgs e)
        {
            //txbName.Clear();
            //txbPhone.Clear();
            //txbAddress.Clear();
            //txbEmail.Clear();
            txbMyBio.Clear();
            //cmbGrade.SelectedIndex = -1; 
        }
        #endregion

        #region btnUploadPic
        private void btnStEdUploadPicture_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string path = openFileDialog.FileName;

                //(max 2 MB
                const long MAX_BYTES = 2L * 1024 * 1024;
                var info = new System.IO.FileInfo(path);
                if (info.Length > MAX_BYTES)
                {
                    MessageBox.Show("Please select an image under 2 MB.", "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //real image
                Image img;
                try
                {
                    img = Image.FromFile(path);
                }
                catch
                {
                    MessageBox.Show("The selected file is not a valid image.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // dimension check
                // if (img.Width > 2000 || img.Height > 2000) { /* warn/return */ }

                // 4) Read bytes & update database
                byte[] imageBytes = System.IO.File.ReadAllBytes(path);
                using (var conn = ConnectToDb())
                using (var cmd = new MySqlCommand(
                       "UPDATE student SET ImageStudent = @Image WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Image", imageBytes);
                    cmd.Parameters.AddWithValue("@Id", loggedInStudent.Id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Picture uploaded successfully!");
                picStEdStudentPicture.Image = img;
            }
        }


        #endregion

        #region LoadStPic
        private void LoadStudentPicture()
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string query = "SELECT ImageStudent FROM student WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", loggedInStudent.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && reader["ImageStudent"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["ImageStudent"];
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            picStEdStudentPicture.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picStEdStudentPicture.Image = null;
                    }
                }
            }
        }
        #endregion
    }
}
