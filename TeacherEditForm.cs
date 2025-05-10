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
        #region btnUpdate
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1) Pull & trim inputs
            string name = txbName.Text.Trim();
            string phone = txbPhone.Text.Trim();
            string address = txbAddress.Text.Trim();
            string email = txbEmail.Text.Trim();
            string bio = txbMyBio.Text.Trim();

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
                MessageBox.Show("Please enter a valid address (max 200 chars).");
                return;
            }
            if (!InputValidator.IsValidBio(bio))
            {
                MessageBox.Show("Please keep your bio to 500 characters and avoid angle brackets.");
                return;
            }

            // 3) Everything’s valid—now proceed with the UPDATE
            using (MySqlConnection dbConnection = ConnectToDb())
            {
                string updateQuery = @"
            UPDATE teacher
               SET Name    = @Name,
                   Phone   = @Phone,
                   Address = @Address,
                   Email   = @Email,
                   Bio     = @Bio
             WHERE Id = @Id";  // fixed: removed invalid GradeId line

                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, dbConnection))
                {
                    updateCommand.Parameters.AddWithValue("@Name", name);
                    updateCommand.Parameters.AddWithValue("@Phone", phone);
                    updateCommand.Parameters.AddWithValue("@Address", address);
                    updateCommand.Parameters.AddWithValue("@Email", email);
                    updateCommand.Parameters.AddWithValue("@Bio", bio);
                    updateCommand.Parameters.AddWithValue("@Id", loggedInTeacher.Id);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // reflect changes in-memory
                        loggedInTeacher.Name = name;
                        loggedInTeacher.Phone = phone;
                        loggedInTeacher.Address = address;
                        loggedInTeacher.Email = email;
                        loggedInTeacher.Bio = bio;

                        MessageBox.Show("Information updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
        }
        #endregion

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
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string path = openFileDialog.FileName;

                //max 2 MB
                const long MAX_BYTES = 2L * 1024 * 1024;
                var info = new System.IO.FileInfo(path);
                if (info.Length > MAX_BYTES)
                {
                    MessageBox.Show(
                        "Please select an image under 2 MB.",
                        "File Too Large",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                //Validate image
                Image img;
                try
                {
                    img = Image.FromFile(path);
                }
                catch
                {
                    MessageBox.Show(
                        "The selected file is not a valid image.",
                        "Invalid Image",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                //dimension check
                // if (img.Width > 2000 || img.Height > 2000)
                // {
                //     MessageBox.Show("Please select an image smaller than 2000×2000.", "Image Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //     return;
                // }

                byte[] imageBytes = System.IO.File.ReadAllBytes(path);
                using (var conn = ConnectToDb())
                using (var cmd = new MySqlCommand(
                       "UPDATE teacher SET ImageTeacher = @Image WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Image", imageBytes);
                    cmd.Parameters.AddWithValue("@Id", loggedInTeacher.Id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Picture uploaded successfully!");
                picTeEdTeacherPicture.Image = img;
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