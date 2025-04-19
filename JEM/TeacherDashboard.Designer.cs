namespace JEM
{
    partial class TeacherDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMyStudent = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnFilterbyStudent = new System.Windows.Forms.Button();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.btnFilterbySubject = new System.Windows.Forms.Button();
            this.btnFilterbyDate = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txbBio = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pibStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.grbStudentInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStudentPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnMyInfo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 653);
            this.panel1.TabIndex = 1;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyInfo.Location = new System.Drawing.Point(12, 259);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(114, 47);
            this.btnMyInfo.TabIndex = 22;
            this.btnMyInfo.Text = "My Info";
            this.btnMyInfo.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnMyStudent);
            this.panel3.Controls.Add(this.btnSchedule);
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 423);
            this.panel3.TabIndex = 2;
            // 
            // btnMyStudent
            // 
            this.btnMyStudent.Location = new System.Drawing.Point(9, 340);
            this.btnMyStudent.Name = "btnMyStudent";
            this.btnMyStudent.Size = new System.Drawing.Size(114, 42);
            this.btnMyStudent.TabIndex = 23;
            this.btnMyStudent.Text = "My Student";
            this.btnMyStudent.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblUserName.Location = new System.Drawing.Point(18, 85);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 19);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 3;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToOrderColumns = true;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Column2,
            this.Time,
            this.Column1,
            this.Grade,
            this.Column3,
            this.Column4});
            this.dgvSchedule.Location = new System.Drawing.Point(144, 54);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(826, 226);
            this.dgvSchedule.TabIndex = 4;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 55;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Session Cost";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Balance";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnFilterbyStudent);
            this.grbSearch.Controls.Add(this.cmbStudent);
            this.grbSearch.Controls.Add(this.btnFilterbySubject);
            this.grbSearch.Controls.Add(this.btnFilterbyDate);
            this.grbSearch.Controls.Add(this.cmbSubject);
            this.grbSearch.Controls.Add(this.cmbDate);
            this.grbSearch.Location = new System.Drawing.Point(171, 343);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(270, 285);
            this.grbSearch.TabIndex = 16;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnFilterbyStudent
            // 
            this.btnFilterbyStudent.Location = new System.Drawing.Point(18, 249);
            this.btnFilterbyStudent.Name = "btnFilterbyStudent";
            this.btnFilterbyStudent.Size = new System.Drawing.Size(200, 23);
            this.btnFilterbyStudent.TabIndex = 14;
            this.btnFilterbyStudent.Text = "Filter by Student";
            this.btnFilterbyStudent.UseVisualStyleBackColor = true;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(18, 206);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(200, 24);
            this.cmbStudent.TabIndex = 13;
            // 
            // btnFilterbySubject
            // 
            this.btnFilterbySubject.Location = new System.Drawing.Point(18, 164);
            this.btnFilterbySubject.Name = "btnFilterbySubject";
            this.btnFilterbySubject.Size = new System.Drawing.Size(200, 23);
            this.btnFilterbySubject.TabIndex = 12;
            this.btnFilterbySubject.Text = "Filter by Subject";
            this.btnFilterbySubject.UseVisualStyleBackColor = true;
            // 
            // btnFilterbyDate
            // 
            this.btnFilterbyDate.Location = new System.Drawing.Point(18, 79);
            this.btnFilterbyDate.Name = "btnFilterbyDate";
            this.btnFilterbyDate.Size = new System.Drawing.Size(200, 23);
            this.btnFilterbyDate.TabIndex = 11;
            this.btnFilterbyDate.Text = "Filter by Date";
            this.btnFilterbyDate.UseVisualStyleBackColor = true;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(18, 121);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(200, 24);
            this.cmbSubject.TabIndex = 10;
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(18, 36);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(200, 24);
            this.cmbDate.TabIndex = 9;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSession.Location = new System.Drawing.Point(144, 285);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(154, 42);
            this.btnDeleteSession.TabIndex = 17;
            this.btnDeleteSession.Text = "Delete Session";
            this.btnDeleteSession.UseVisualStyleBackColor = false;
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.txbBio);
            this.grbStudentInfo.Controls.Add(this.pibStudentPicture);
            this.grbStudentInfo.Location = new System.Drawing.Point(615, 302);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(299, 334);
            this.grbStudentInfo.TabIndex = 22;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Info";
            // 
            // txbBio
            // 
            this.txbBio.Location = new System.Drawing.Point(20, 151);
            this.txbBio.Multiline = true;
            this.txbBio.Name = "txbBio";
            this.txbBio.Size = new System.Drawing.Size(256, 175);
            this.txbBio.TabIndex = 31;
            this.txbBio.Text = "Bio";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(135, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 31);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel5.Controls.Add(this.btnNotifications);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 653);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 128);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "JEM";
            // 
            // pibStudentPicture
            // 
            this.pibStudentPicture.Location = new System.Drawing.Point(75, 21);
            this.pibStudentPicture.Name = "pibStudentPicture";
            this.pibStudentPicture.Size = new System.Drawing.Size(139, 124);
            this.pibStudentPicture.TabIndex = 0;
            this.pibStudentPicture.TabStop = false;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(0, 212);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnNotifications.TabIndex = 23;
            this.btnNotifications.Text = "   Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = global::JEM.Properties.Resources.xxsmalluserONE;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "   My Student";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 42);
            this.button3.TabIndex = 21;
            this.button3.Text = "   My Info";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Image = global::JEM.Properties.Resources.xxsmallcalendar_checkmark_schedule;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 42);
            this.button4.TabIndex = 21;
            this.button4.Text = "   Schedule";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JEM.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(32, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSchedule.Image = global::JEM.Properties.Resources.home_black_square;
            this.btnSchedule.Location = new System.Drawing.Point(9, 182);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(114, 42);
            this.btnSchedule.TabIndex = 21;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JEM.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(32, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.grbStudentInfo);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherDashboard";
            this.Text = "TeacherDashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStudentPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMyStudent;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnFilterbyStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnFilterbySubject;
        private System.Windows.Forms.Button btnFilterbyDate;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.PictureBox pibStudentPicture;
        private System.Windows.Forms.TextBox txbBio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNotifications;
    }
}