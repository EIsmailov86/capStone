using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void LoadTeachersForStudent()
        {
            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"
                    SELECT DISTINCT t.Name, t.ImageTeacher, t.Bio
                    FROM teacher t
                    JOIN session s ON s.TeacherId = t.Id
                    WHERE s.StudentId = @StudentId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", loggedInStudent.Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        cmbSubject.Items.Add(name);

                        // Save picture
                        if (reader["ImageTeacher"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["ImageTeacher"];
                            teacherImages[name] = imageData;
                        }

                        // Save bio
                        if (reader["Bio"] != DBNull.Value)
                        {
                            teacherBios[name] = reader["Bio"].ToString();
                        }
                        else
                        {
                            teacherBios[name] = "No bio available.";
                        }
                    }
                }
            }

            cmbSubject.SelectedIndexChanged += cmbSubject_SelectedIndexChanged;
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacher = cmbSubject.SelectedItem?.ToString();

            // Display image
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

            // Display bio
            if (!string.IsNullOrEmpty(selectedTeacher) && teacherBios.ContainsKey(selectedTeacher))
            {
                txbStTeInfoandBio.Text = teacherBios[selectedTeacher];
            }
            else
            {
                txbStTeInfoandBio.Text = "No bio available.";
            }
        }
    }
}
