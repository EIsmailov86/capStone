using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JEM
{
    public partial class TeacherSchedule : BaseForm
    {
        public Teacher loggedInTeacher;

        public TeacherSchedule(Teacher teacher)
        {
            InitializeComponent();
            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher), "Teacher cannot be null.");
            }
            loggedInTeacher = teacher;
            lblWelcome.Text = $"Welcome, {loggedInTeacher.Name}!";
            LoadAllStudents(); 
            LoadSchedule();
            LoadAvailableTimeSlots();
            LoadAllSubjects();
            LoadTeacherPicture();
            ValidateTimeSlot();
        }

        #region LoadSchedule
        private void LoadSchedule()
        {
            dgvTeShSchedule.Columns.Clear();
            dgvTeShSchedule.Columns.Add("SessionId", "SessionId");
            dgvTeShSchedule.Columns["SessionId"].Visible = false;
            dgvTeShSchedule.Columns.Add("SessionDate", "Date");
            dgvTeShSchedule.Columns.Add("SubjectName", "Subject");
            dgvTeShSchedule.Columns.Add("TimeSlot", "Time");
            dgvTeShSchedule.Columns.Add("TeacherName", "Teacher");
            dgvTeShSchedule.Columns.Add("Cost", "Cost");

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"
            SELECT se.SessionId, se.SessionDate, su.SubjectName, se.Timeslot, te.Name AS TeacherName, se.Cost
            FROM session se
            LEFT JOIN subject su ON se.SubjectId = su.SubjectId
            LEFT JOIN teacher te ON se.TeacherId = te.Id
            WHERE se.StudentId = @StudentId
            ORDER BY se.SessionDate";


                if (lbsTeShStudents.SelectedIndex < 0)
                {
                    lbsTeShStudents.SelectedIndex = 0;

                }

                ListItem listboxStudent = lbsTeShStudents.SelectedItem as ListItem;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", listboxStudent.Value);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvTeShSchedule.Rows.Add(
                            reader["SessionId"],
                            Convert.ToDateTime(reader["SessionDate"]).ToShortDateString(),
                            reader["SubjectName"].ToString(),
                            reader["Timeslot"].ToString(),
                            reader["TeacherName"].ToString(),
                            reader["Cost"].ToString()
                        );
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
                    picTeScTeacherPicture.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picTeScTeacherPicture.Image = null;
            }
        }
        #endregion

        #region LoadAllStudents
        private void LoadAllStudents()
        {
            lbsTeShStudents.Items.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = "SELECT Id, Name FROM student ORDER BY Name";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentId = Convert.ToInt32(reader["Id"]);
                        string studentName = reader["Name"].ToString();
                        lbsTeShStudents.Items.Add(new ListItem(studentName, studentId));
                    }
                }
            }
        }
        #endregion

        #region LoadAvalTimeSlots
        private void LoadAvailableTimeSlots()
        {
            cmbTeShTime.Items.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT DISTINCT Timeslot FROM session 
                         WHERE TeacherId = @TeacherId AND SessionDate = @SessionDate";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);
                cmd.Parameters.AddWithValue("@SessionDate", dtpTeShDateTime.Value.Date);

                List<string> takenSlots = new List<string>();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        takenSlots.Add(reader["Timeslot"].ToString());
                    }
                }

                //slots EXCEPT the taken ones
                List<string> allSlots = new List<string>
        {
            "08:00 - 09:00",
            "09:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "13:00 - 14:00",
            "14:00 - 15:00",
            "15:00 - 16:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00"
        };

                foreach (string slot in allSlots)
                {
                    if (!takenSlots.Contains(slot))
                    {
                        cmbTeShTime.Items.Add(slot);
                    }
                }

                if (cmbTeShTime.Items.Count > 0)
                {
                    cmbTeShTime.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No available time slots for the selected date.");
                }
            }
        }
        #endregion
        private void dtpTeShDateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }

        #region LoadAllSubjects
        private void LoadAllSubjects()
        {
            cmbTeShTScheduleSubject.Items.Clear();

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = @"SELECT SubjectName FROM subject ORDER BY SubjectName";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbTeShTScheduleSubject.Items.Add(reader["SubjectName"].ToString());
                    }
                }
            }
        }
        #endregion

        #region btnScheduleSession
        private void btnTeShScheduleSession_Click(object sender, EventArgs e)
        {
            if (cmbTeShTScheduleSubject.SelectedItem == null ||
                cmbTeShTime.SelectedItem == null ||
                lbsTeShStudents.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txbTeShSessionCost.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            DateTime sessionDate = dtpTeShDateTime.Value.Date;
            string timeslot = cmbTeShTime.SelectedItem.ToString();
            string subjectName = cmbTeShTScheduleSubject.SelectedItem.ToString();
            ListItem selectedStudent = (ListItem)lbsTeShStudents.SelectedItem;
            int studentId = selectedStudent.Value;
            decimal cost;

            if (!decimal.TryParse(txbTeShSessionCost.Text, out cost))
            {
                MessageBox.Show("Please enter a valid cost.");
                return;
            }

            using (MySqlConnection conn = ConnectToDb())
            {
                string subjectQuery = "SELECT SubjectId FROM subject WHERE SubjectName = @SubjectName";
                MySqlCommand subjectCmd = new MySqlCommand(subjectQuery, conn);
                subjectCmd.Parameters.AddWithValue("@SubjectName", subjectName);
                int subjectId = Convert.ToInt32(subjectCmd.ExecuteScalar());

                string insertQuery = @"INSERT INTO session (StudentId, TeacherId, SessionDate, SubjectId, TimeSlot, Cost) 
                               VALUES (@StudentId, @TeacherId, @SessionDate, @SubjectId, @TimeSlot, @Cost);
                               SELECT LAST_INSERT_ID();";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                
                decimal.TryParse(txbTeShSessionCost.Text.Trim(), out cost);

                insertCmd.Parameters.AddWithValue("@studentId", studentId);
                insertCmd.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);
                insertCmd.Parameters.AddWithValue("@SessionDate", sessionDate);
                insertCmd.Parameters.AddWithValue("@SubjectId", subjectId);
                insertCmd.Parameters.AddWithValue("@TimeSlot", timeslot);
                insertCmd.Parameters.AddWithValue("@Cost", cost);


                int newSessionId = Convert.ToInt32(insertCmd.ExecuteScalar());

                if (newSessionId > 0)
                {
                    MessageBox.Show("Session scheduled successfully!");
                    dgvTeShSchedule.Rows.Clear();
                    LoadSchedule();
                    CreateNotifications(2, loggedInTeacher.Id, studentId,
                        "Tutoring Session on " + sessionDate.ToString("M/d/yyyy"),
                        "You have been scheduled for a tutoring session\r\n" +
                        "Subject:" + subjectName + "\r\n" +
                        "Teacher: " + loggedInTeacher.Name + "\r\n" +
                        "Date: " + sessionDate.ToString("M/d/yyyy") + "\r\n" +
                        "Time: " + timeslot + "\r\n" +
                        "Cost: " + cost);
                }
                else
                {
                    MessageBox.Show("Failed to schedule session.");
                }

                // Issue: teachers cannot see if a student is already scheduled with another teacher
                string newSessionQuery = "SELECT se.SessionId, su.subjectName, se.SessionDate, se.Timeslot, te.Name AS teacherName, st.Name AS StudentName, gr.GradeYear, se.Cost " +
                    "FROM session AS se " +
                    "LEFT JOIN subject AS su ON se.SubjectId=su.subjectId " +
                    "LEFT JOIN teacher AS te ON se.TeacherId=te.Id " +
                    "LEFT JOIN gradeyear AS gr ON su.SubjectId=gr.GradeId " +
                    "LEFT JOIN student AS st ON se.StudentId=st.Id " +
                    "WHERE @TeacherId = se.TeacherId";

                MySqlCommand sessiondata = new MySqlCommand(newSessionQuery, conn);
                sessiondata.Parameters.AddWithValue("@TeacherId", loggedInTeacher.Id);

                using (MySqlDataReader reader = sessiondata.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Session sessionRow = new Session
                        {
                            SessionId = Convert.ToInt32(reader["SessionId"]),
                            SubjectName = reader["SubjectName"].ToString(),
                            StudentName = reader["StudentName"].ToString(),
                            TeacherName = reader["TeacherName"].ToString(),
                            SessionDate = (DateTime)reader["SessionDate"],
                            TimeSlot = reader["Timeslot"].ToString(),
                            GradeYear = reader["GradeYear"].ToString(),
                            Cost = Convert.ToInt32(reader["Cost"]),
                        };
                        sessions.Add(sessionRow);
                    }
                }
            }
            cmbTeShTime.Text = "";
            ValidateTimeSlot();
        }
        #endregion

        #region btnUpdateCost
        private void btnTeShUpdateCost_Click(object sender, EventArgs e)
        {
            if (dgvTeShSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to update.");
                return;
            }

            if (!decimal.TryParse(txbTeShSessionCost.Text, out decimal newCost))
            {
                MessageBox.Show("Please enter a valid numeric cost.");
                return;
            }

            DataGridViewRow selectedRow = dgvTeShSchedule.SelectedRows[0];
            int sessionId = Convert.ToInt32(selectedRow.Cells[0].Value);

            using (MySqlConnection conn = ConnectToDb())
            {
                string query = "UPDATE session SET Cost = @Cost WHERE SessionId = @SessionId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cost", newCost);
                cmd.Parameters.AddWithValue("@SessionId", sessionId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    selectedRow.Cells["Cost"].Value = newCost;
                    MessageBox.Show("Session cost updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update cost. Please try again.");
                }
            }
        }
        #endregion

        #region btnDelete Session
        private void btnTeShDeleteSession_Click(object sender, EventArgs e)
        {
            if (dgvTeShSchedule.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTeShSchedule.SelectedRows[0];
                int sessionId = Convert.ToInt32(selectedRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this session?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = ConnectToDb())
                    {

                        string selectQuery = "SELECT se.StudentId, se.SessionId, su.subjectName, se.SessionDate, se.Timeslot, te.Name AS teacherName, st.Name AS StudentName, gr.GradeYear, se.Cost " +
                            "FROM session AS se " +
                            "LEFT JOIN subject AS su ON se.SubjectId=su.subjectId " +
                            "LEFT JOIN teacher AS te ON se.TeacherId=te.Id " +
                            "LEFT JOIN gradeyear AS gr ON su.SubjectId=gr.GradeId " +
                            "LEFT JOIN student AS st ON se.StudentId=st.Id " +
                            "WHERE @SessionId = se.SessionId";

                        MySqlCommand selectcmd = new MySqlCommand(selectQuery, conn);
                        selectcmd.Parameters.AddWithValue("@SessionId", sessionId);

                        using (MySqlDataReader reader = selectcmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Session sessionRow = new Session
                                {
                                    SessionId = Convert.ToInt32(reader["SessionId"]),
                                    SubjectName = reader["SubjectName"].ToString(),
                                    StudentName = reader["StudentName"].ToString(),
                                    TeacherName = reader["TeacherName"].ToString(),
                                    SessionDate = (DateTime)reader["SessionDate"],
                                    TimeSlot = reader["Timeslot"].ToString(),
                                    GradeYear = reader["GradeYear"].ToString(),
                                    Cost = Convert.ToInt32(reader["Cost"]),
                                };

                                int studentId = Convert.ToInt32(reader["StudentId"]);

                                CreateNotifications(2, loggedInTeacher.Id, studentId,
                                    "Tutoring Session Cancelled on " + sessionRow.SessionDate.ToString("M/d/yyyy"),
                                    "The following Session has been cancelled\r\n" +
                                    "Subject:" + sessionRow.SubjectName + "\r\n" +
                                    "Teacher: " + loggedInTeacher.Name + "\r\n" +
                                    "Date: " + sessionRow.SessionDate.ToString("M/d/yyyy") + "\r\n" +
                                    "Time: " + sessionRow.TimeSlot + "\r\n" +
                                    "Cost: " + sessionRow.Cost);

                            }
                        }

                        string query = "DELETE FROM session WHERE SessionId = @SessionId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SessionId", sessionId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            dgvTeShSchedule.Rows.Remove(selectedRow);
                            MessageBox.Show("Session deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the session. Please try again.");
                        }
                    }
                }

                // finds the removed session, there may be an easier way to search for session with a specific id
                for (int i = 0; i < sessions.Count; i++)
                {
                    if (sessions[i].SessionId == sessionId)
                    {
                        sessions.RemoveAt(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a session to delete.");
            }
            ValidateTimeSlot();
        }

        #endregion

        #region Navigation Buttons
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

        private void btnTeScMyInfo_Click(object sender, EventArgs e)
        {
            var editForm = new TeacherEditForm(loggedInTeacher);
            editForm.Show();
            this.SuppressCloseConfirmation = true;
            this.Close();
        }
        #endregion

        #region ValidateTime/SelectedDate
        private void ValidateTimeSlot()
        {

            LoadAvailableTimeSlots();

            //Check if timselot is taken
            for (int i = 0; i < sessions.Count; i++)
            {

                if (dtpTeShDateTime.Value.ToString("M/d/yyyy").Equals(sessions[i].SessionDate.ToString("M/d/yyyy")))
                {
                    for (int j = 0; j < cmbTeShTime.Items.Count; j++)
                    {
                        if (cmbTeShTime.Items[j].ToString().Equals(sessions[i].TimeSlot))
                        {
                            cmbTeShTime.Items.RemoveAt(j);
                        }
                    }
                }
            }
        }

        private void SelectedDateChange(object sender, EventArgs e)
        {
            ValidateTimeSlot();
        }

        private void StudentSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSchedule();
        }
    }

    #endregion

    #region ListItem
    public class ListItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ListItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
    #endregion
}
