using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JEM
{
    public partial class StudentTeacherForm : BaseForm
    {
        private Student loggedInStudent;
        private Dictionary<string, byte[]> teacherImages = new Dictionary<string, byte[]>();
        private Dictionary<string, string> teacherBios = new Dictionary<string, string>();

        public StudentTeacherForm(Student student)
        {
            InitializeComponent();
            loggedInStudent = student;
            lblStTeWelcome.Text = $"Welcome, {loggedInStudent.Name}!";
            LoadTeachersForStudent();
            LoadBio();
            LoadStudentPicture();
        }

        #region Nav Buttons
        private void btnStTeDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new studentdashboardform(loggedInStudent);
            dashboard.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
        private void btnStTeNotifications_Click(object sender, EventArgs e)
        {
            var form = new StudentNotifications(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStTeMyInfo_Click(object sender, EventArgs e)
        {
            var form = new StudentEditForm(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
        #endregion

        #region LoadTeachers
        private void LoadTeachersForStudent()
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"
                    SELECT DISTINCT t.Name, t.ImageTeacher, t.Bio, t.Id
                    FROM teacher t";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", loggedInStudent.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Teacher teacherRow = new Teacher
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Bio = reader["Bio"].ToString()
                        };

                        teachers.Add(teacherRow);
                        cmbTeacher.Items.Add(teacherRow);
                        cmbTeacher.DisplayMember = "Name";

                        //save picture
                        if (reader["ImageTeacher"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["ImageTeacher"];
                            //teacherImages[name] = imageData;
                            teacherImages[teacherRow.Name] = imageData;
                        }
                        //save bio
                        if (reader["Bio"] != DBNull.Value)
                        {
                            teacherBios[teacherRow.Name] = reader["Bio"].ToString();
                        }
                        else
                        {
                            teacherBios[teacherRow.Name] = "No bio available.";
                        }
                    }
                }
            }
            cmbTeacher.SelectedIndexChanged += cmbTeacher_SelectedIndexChanged;
        }
        #endregion
        #region ComboBox_SelectedTe
        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cast to Teacher
            if (!(cmbTeacher.SelectedItem is Teacher selectedTeacher))
            {
                picStTeTeacherPicture.Image = null;
                txbStTeInfoandBio.Text = "No bio available.";
                return;
            }

            //by Name in image dictionary
            if (teacherImages.TryGetValue(selectedTeacher.Name, out var imageBytes))
            {
                using (var ms = new MemoryStream(imageBytes))
                    picStTeTeacherPicture.Image = Image.FromStream(ms);
            }
            else
            {
                picStTeTeacherPicture.Image = null;
            }
            txbStTeInfoandBio.Text =
                !string.IsNullOrEmpty(selectedTeacher.Bio)
                ? selectedTeacher.Bio
                : (teacherBios.TryGetValue(selectedTeacher.Name, out var bioDict)
                   ? bioDict
                   : "No bio available.");
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
            } else
            {
                if (cmbTeacher.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a teacher");
                } else
                {
                    Teacher selectedTeacher = cmbTeacher.SelectedItem as Teacher;
                    CreateNotifications(1, selectedTeacher.Id, loggedInStudent.Id, txbMessageHeader.Text, txbMessageBody.Text + "\r\n Message sent from " + loggedInStudent.Name);
                    MessageBox.Show("Message has been Sent");
                    txbMessageHeader.Text = "";
                    txbMessageBody.Text = "";
                }
            }
        }
        #endregion
        private void LoadBio()
        {
            if (cmbTeacher.SelectedIndex >= 0)
            {
                Teacher selectedTeacher = cmbTeacher.SelectedItem as Teacher;
                txbStTeInfoandBio.Text = selectedTeacher.Bio;
            }
        }
        private void LoadStudentPicture()
        {
            if (loggedInStudent.ImageStudent != null)
            {
                using (MemoryStream ms = new MemoryStream(loggedInStudent.ImageStudent))
                {
                    pibStTeStudentPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pibStTeStudentPicture.Image = null;
            }
        }
    }
}
