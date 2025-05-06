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
            var form = new StudentExtraForm(loggedInStudent);
            form.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }

        private void btnStTePayment_Click(object sender, EventArgs e)
        {
            var form = new StudentExtraForm(loggedInStudent);
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
                    FROM teacher t
                    JOIN session s ON s.TeacherId = t.Id
                    WHERE s.StudentId = @StudentId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", loggedInStudent.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Teacher teacherRow = new Teacher
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        };

                        teachers.Add(teacherRow);

                        //string name = reader["Name"].ToString();
                        //cmbSubject.Items.Add(name);

                        // may need to add the teacherRow instead and set displaymember to name
                        cmbSubject.Items.Add(teacherRow);
                        cmbSubject.DisplayMember = "Name";

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

            cmbSubject.SelectedIndexChanged += cmbSubject_SelectedIndexChanged;
        }
        #endregion

        #region ComboBox_SelectedTe
        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacher = cmbSubject.SelectedItem?.ToString();

            //show image
            if (!string.IsNullOrEmpty(selectedTeacher) && teacherImages.ContainsKey(selectedTeacher))
            {
                using (var ms = new MemoryStream(teacherImages[selectedTeacher]))
                {
                    picStTeTeacherPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picStTeTeacherPicture.Image = null;
            }

            //show bio
            if (!string.IsNullOrEmpty(selectedTeacher) && teacherBios.ContainsKey(selectedTeacher))
            {
                txbStTeInfoandBio.Text = teacherBios[selectedTeacher];
            }
            else
            {
                txbStTeInfoandBio.Text = "No bio available.";
            }
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
                if (cmbSubject.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a teacher");
                } else
                {
                    Teacher selectedTeacher = cmbSubject.SelectedItem as Teacher;
                    CreateNotifications(1, selectedTeacher.Id, loggedInStudent.Id, txbMessageHeader.Text, txbMessageBody.Text + "\r\n Message sent from " + loggedInStudent.Name);

                    MessageBox.Show("Message has been Sent");

                    txbMessageHeader.Text = "";
                    txbMessageBody.Text = "";
                }
            }

        }

        #endregion


    }
}
