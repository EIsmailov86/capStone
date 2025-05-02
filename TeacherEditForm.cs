using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JEM
{
    public partial class TeacherEditForm : BaseForm
    {
        private Teacher loggedInTeacher;

        public TeacherEditForm(Teacher teacher)
        {
            InitializeComponent();
            loggedInTeacher = teacher;
            lblTeEdWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";
            IntializeTeacherInfo();
            LoadTeacherPicture();
            LoadTeacherPhoto();
        }

        #region Nav Buttons
        private void btnTeScDashboards_Click(object sender, EventArgs e)
        {
            var dashboard = new TeacherDashboard(loggedInTeacher);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTeScMyStudent_Click(object sender, EventArgs e)
        {
            var studentForm = new TeacherStudentForm(loggedInTeacher);
            studentForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnTeScNotifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new TeacherNotificationsForm(loggedInTeacher);
            notificationsForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
        #endregion

        #region InitTeInfo
        private void IntializeTeacherInfo()
        {
            if (loggedInTeacher != null)
            {
                txbName.Text = loggedInTeacher.Name;
                txbPhone.Text = loggedInTeacher.Phone;
                txbAddress.Text = loggedInTeacher.Address;
                txbEmail.Text = loggedInTeacher.Email;
                txbMyBio.Text = loggedInTeacher.Bio;
            }
        }
        #endregion

        #region btnUpdate
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string updateQuery = @"
            UPDATE teacher
            SET Name = @Name,
                Phone = @Phone,
                Address = @Address,
                Email = @Email,
                Bio = @Bio
                GradeId = @GradeId
            WHERE Id = @Id";

                MySqlCommand updateCommand = new MySqlCommand(updateQuery, dbConnection);

                updateCommand.Parameters.AddWithValue("@Name", txbName.Text);
                updateCommand.Parameters.AddWithValue("@Phone", txbPhone.Text);
                updateCommand.Parameters.AddWithValue("@Address", txbAddress.Text);
                updateCommand.Parameters.AddWithValue("@Email", txbEmail.Text);
                updateCommand.Parameters.AddWithValue("@Bio", txbMyBio.Text);
                updateCommand.Parameters.AddWithValue("@Id", loggedInTeacher.Id);
                updateCommand.Parameters.AddWithValue("@GradeId", loggedInTeacher.Id);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    loggedInTeacher.Name = txbName.Text;
                    loggedInTeacher.Phone = txbPhone.Text;
                    loggedInTeacher.Address = txbAddress.Text;
                    loggedInTeacher.Email = txbEmail.Text;
                    loggedInTeacher.Bio = txbMyBio.Text;

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
        }
        #endregion

        #region btnUploadPic
        private void btnTeEdUploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    byte[] imageBytes = File.ReadAllBytes(selectedImagePath);

                    using (MySqlConnection conn = ConnectToDb())
                    {
                        string query = "UPDATE teacher SET ImageTeacher = @Image WHERE Id = @Id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Image", imageBytes);
                        cmd.Parameters.AddWithValue("@Id", loggedInTeacher.Id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Picture uploaded successfully!");

                    if (picTeEdTeacherPicture != null)
                    {
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            picTeEdTeacherPicture.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }
        #endregion

        #region LoadTePicAndPhoto
        private void LoadTeacherPicture()
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string query = "SELECT ImageTeacher FROM teacher WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", loggedInTeacher.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && reader["ImageTeacher"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["ImageTeacher"];
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            picTeEdTeacherPicture.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picTeEdTeacherPicture.Image = null;
                    }
                }
            }
        }
        private void LoadTeacherPhoto()
        {
            if (loggedInTeacher.ImageTeacher != null)
            {
                using (MemoryStream ms = new MemoryStream(loggedInTeacher.ImageTeacher))
                {
                    pibTeEdTeacherPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pibTeEdTeacherPicture.Image = null;
            }
        }
        #endregion
    }
}