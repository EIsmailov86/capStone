namespace JEM
{
    partial class TeacherSchedule
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
            this.grbScheduleApp = new System.Windows.Forms.GroupBox();
            this.btnTeShDeleteSession = new System.Windows.Forms.Button();
            this.dgvTeShSchedule = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsTeShStudents = new System.Windows.Forms.ListBox();
            this.btnTeShUpdateCost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTeShSessionCost = new System.Windows.Forms.TextBox();
            this.dtpTeShDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnTeShScheduleSession = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbTeShTime = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbTeShTScheduleSubject = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTeScNotifications = new System.Windows.Forms.Button();
            this.btnTeScMyStudent = new System.Windows.Forms.Button();
            this.btnTeScMyInfo = new System.Windows.Forms.Button();
            this.btnTeScDashboards = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picTeScTeacherPicture = new System.Windows.Forms.PictureBox();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMyStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbScheduleApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeShSchedule)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeScTeacherPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbScheduleApp
            // 
            this.grbScheduleApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbScheduleApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbScheduleApp.Controls.Add(this.btnTeShDeleteSession);
            this.grbScheduleApp.Controls.Add(this.dgvTeShSchedule);
            this.grbScheduleApp.Controls.Add(this.lbsTeShStudents);
            this.grbScheduleApp.Controls.Add(this.btnTeShUpdateCost);
            this.grbScheduleApp.Controls.Add(this.label2);
            this.grbScheduleApp.Controls.Add(this.txbTeShSessionCost);
            this.grbScheduleApp.Controls.Add(this.dtpTeShDateTime);
            this.grbScheduleApp.Controls.Add(this.lblSubject);
            this.grbScheduleApp.Controls.Add(this.btnTeShScheduleSession);
            this.grbScheduleApp.Controls.Add(this.lblTime);
            this.grbScheduleApp.Controls.Add(this.cmbTeShTime);
            this.grbScheduleApp.Controls.Add(this.lblDate);
            this.grbScheduleApp.Controls.Add(this.cmbTeShTScheduleSubject);
            this.grbScheduleApp.Location = new System.Drawing.Point(168, 65);
            this.grbScheduleApp.MaximumSize = new System.Drawing.Size(800, 600);
            this.grbScheduleApp.Name = "grbScheduleApp";
            this.grbScheduleApp.Size = new System.Drawing.Size(793, 560);
            this.grbScheduleApp.TabIndex = 19;
            this.grbScheduleApp.TabStop = false;
            this.grbScheduleApp.Text = "Schedule Appointment";
            // 
            // btnTeShDeleteSession
            // 
            this.btnTeShDeleteSession.BackColor = System.Drawing.Color.Red;
            this.btnTeShDeleteSession.Image = global::JEM.Properties.Resources.smallDelete_trash;
            this.btnTeShDeleteSession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeShDeleteSession.Location = new System.Drawing.Point(627, 257);
            this.btnTeShDeleteSession.Name = "btnTeShDeleteSession";
            this.btnTeShDeleteSession.Size = new System.Drawing.Size(154, 42);
            this.btnTeShDeleteSession.TabIndex = 21;
            this.btnTeShDeleteSession.Text = "Delete Session";
            this.btnTeShDeleteSession.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeShDeleteSession.UseVisualStyleBackColor = false;
            this.btnTeShDeleteSession.Click += new System.EventHandler(this.btnTeShDeleteSession_Click);
            // 
            // dgvTeShSchedule
            // 
            this.dgvTeShSchedule.AllowUserToOrderColumns = true;
            this.dgvTeShSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeShSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Column2,
            this.Time,
            this.Column1,
            this.Grade,
            this.Column3,
            this.Column4});
            this.dgvTeShSchedule.Location = new System.Drawing.Point(6, 328);
            this.dgvTeShSchedule.Name = "dgvTeShSchedule";
            this.dgvTeShSchedule.RowHeadersWidth = 51;
            this.dgvTeShSchedule.RowTemplate.Height = 24;
            this.dgvTeShSchedule.Size = new System.Drawing.Size(775, 226);
            this.dgvTeShSchedule.TabIndex = 20;
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
            this.Column1.HeaderText = "Teacher Name";
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
            // lbsTeShStudents
            // 
            this.lbsTeShStudents.FormattingEnabled = true;
            this.lbsTeShStudents.ItemHeight = 16;
            this.lbsTeShStudents.Location = new System.Drawing.Point(370, 23);
            this.lbsTeShStudents.Name = "lbsTeShStudents";
            this.lbsTeShStudents.Size = new System.Drawing.Size(236, 276);
            this.lbsTeShStudents.TabIndex = 20;
            this.lbsTeShStudents.SelectedIndexChanged += new System.EventHandler(this.StudentSelectedIndexChanged);
            // 
            // btnTeShUpdateCost
            // 
            this.btnTeShUpdateCost.Image = global::JEM.Properties.Resources._34px_updateCost;
            this.btnTeShUpdateCost.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeShUpdateCost.Location = new System.Drawing.Point(239, 233);
            this.btnTeShUpdateCost.Name = "btnTeShUpdateCost";
            this.btnTeShUpdateCost.Size = new System.Drawing.Size(80, 69);
            this.btnTeShUpdateCost.TabIndex = 11;
            this.btnTeShUpdateCost.Text = "Update Cost";
            this.btnTeShUpdateCost.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeShUpdateCost.UseVisualStyleBackColor = true;
            this.btnTeShUpdateCost.Click += new System.EventHandler(this.btnTeShUpdateCost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Session Cost";
            // 
            // txbTeShSessionCost
            // 
            this.txbTeShSessionCost.Location = new System.Drawing.Point(132, 189);
            this.txbTeShSessionCost.Name = "txbTeShSessionCost";
            this.txbTeShSessionCost.Size = new System.Drawing.Size(200, 22);
            this.txbTeShSessionCost.TabIndex = 9;
            // 
            // dtpTeShDateTime
            // 
            this.dtpTeShDateTime.Location = new System.Drawing.Point(132, 37);
            this.dtpTeShDateTime.Name = "dtpTeShDateTime";
            this.dtpTeShDateTime.Size = new System.Drawing.Size(200, 22);
            this.dtpTeShDateTime.TabIndex = 5;
            this.dtpTeShDateTime.ValueChanged += new System.EventHandler(this.SelectedDateChange);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(35, 145);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 16);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject";
            // 
            // btnTeShScheduleSession
            // 
            this.btnTeShScheduleSession.Image = global::JEM.Properties.Resources._34px_person_clock_calendar;
            this.btnTeShScheduleSession.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeShScheduleSession.Location = new System.Drawing.Point(144, 233);
            this.btnTeShScheduleSession.Name = "btnTeShScheduleSession";
            this.btnTeShScheduleSession.Size = new System.Drawing.Size(80, 69);
            this.btnTeShScheduleSession.TabIndex = 8;
            this.btnTeShScheduleSession.Text = "Schedule Session";
            this.btnTeShScheduleSession.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeShScheduleSession.UseVisualStyleBackColor = true;
            this.btnTeShScheduleSession.Click += new System.EventHandler(this.btnTeShScheduleSession_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(35, 93);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 16);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // cmbTeShTime
            // 
            this.cmbTeShTime.FormattingEnabled = true;
            this.cmbTeShTime.Location = new System.Drawing.Point(132, 85);
            this.cmbTeShTime.Name = "cmbTeShTime";
            this.cmbTeShTime.Size = new System.Drawing.Size(200, 24);
            this.cmbTeShTime.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // cmbTeShTScheduleSubject
            // 
            this.cmbTeShTScheduleSubject.FormattingEnabled = true;
            this.cmbTeShTScheduleSubject.Location = new System.Drawing.Point(132, 137);
            this.cmbTeShTScheduleSubject.Name = "cmbTeShTScheduleSubject";
            this.cmbTeShTScheduleSubject.Size = new System.Drawing.Size(200, 24);
            this.cmbTeShTScheduleSubject.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 5;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(287, 3);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(161, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnMyInfo);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 653);
            this.panel1.TabIndex = 3;
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
            this.panel5.Controls.Add(this.btnTeScNotifications);
            this.panel5.Controls.Add(this.btnTeScMyStudent);
            this.panel5.Controls.Add(this.btnTeScMyInfo);
            this.panel5.Controls.Add(this.btnTeScDashboards);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 653);
            this.panel5.TabIndex = 23;
            // 
            // btnTeScNotifications
            // 
            this.btnTeScNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeScNotifications.FlatAppearance.BorderSize = 0;
            this.btnTeScNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeScNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeScNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnTeScNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeScNotifications.Location = new System.Drawing.Point(0, 212);
            this.btnTeScNotifications.Name = "btnTeScNotifications";
            this.btnTeScNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnTeScNotifications.TabIndex = 23;
            this.btnTeScNotifications.Text = "   Notifications";
            this.btnTeScNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeScNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeScNotifications.UseVisualStyleBackColor = true;
            this.btnTeScNotifications.Click += new System.EventHandler(this.btnTeScNotifications_Click);
            // 
            // btnTeScMyStudent
            // 
            this.btnTeScMyStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeScMyStudent.FlatAppearance.BorderSize = 0;
            this.btnTeScMyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeScMyStudent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeScMyStudent.Image = global::JEM.Properties.Resources.xxsmalluserONE;
            this.btnTeScMyStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeScMyStudent.Location = new System.Drawing.Point(0, 170);
            this.btnTeScMyStudent.Name = "btnTeScMyStudent";
            this.btnTeScMyStudent.Size = new System.Drawing.Size(135, 42);
            this.btnTeScMyStudent.TabIndex = 21;
            this.btnTeScMyStudent.Text = "   My Student";
            this.btnTeScMyStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeScMyStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeScMyStudent.UseVisualStyleBackColor = true;
            this.btnTeScMyStudent.Click += new System.EventHandler(this.btnTeScMyStudent_Click);
            // 
            // btnTeScMyInfo
            // 
            this.btnTeScMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTeScMyInfo.FlatAppearance.BorderSize = 0;
            this.btnTeScMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeScMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeScMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnTeScMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeScMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnTeScMyInfo.Name = "btnTeScMyInfo";
            this.btnTeScMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnTeScMyInfo.TabIndex = 21;
            this.btnTeScMyInfo.Text = "   My Info";
            this.btnTeScMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeScMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeScMyInfo.UseVisualStyleBackColor = true;
            this.btnTeScMyInfo.Click += new System.EventHandler(this.btnTeScMyInfo_Click);
            // 
            // btnTeScDashboards
            // 
            this.btnTeScDashboards.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeScDashboards.FlatAppearance.BorderSize = 0;
            this.btnTeScDashboards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeScDashboards.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeScDashboards.Image = global::JEM.Properties.Resources.xxsmall_home_black_square;
            this.btnTeScDashboards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeScDashboards.Location = new System.Drawing.Point(0, 128);
            this.btnTeScDashboards.Name = "btnTeScDashboards";
            this.btnTeScDashboards.Size = new System.Drawing.Size(135, 42);
            this.btnTeScDashboards.TabIndex = 21;
            this.btnTeScDashboards.Text = "   Dashboard";
            this.btnTeScDashboards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeScDashboards.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeScDashboards.UseVisualStyleBackColor = true;
            this.btnTeScDashboards.Click += new System.EventHandler(this.btnTeScDashboards_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.picTeScTeacherPicture);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 128);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(40, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "JEM";
            // 
            // picTeScTeacherPicture
            // 
            this.picTeScTeacherPicture.Image = global::JEM.Properties.Resources.user;
            this.picTeScTeacherPicture.Location = new System.Drawing.Point(32, 19);
            this.picTeScTeacherPicture.Name = "picTeScTeacherPicture";
            this.picTeScTeacherPicture.Size = new System.Drawing.Size(63, 63);
            this.picTeScTeacherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeScTeacherPicture.TabIndex = 2;
            this.picTeScTeacherPicture.TabStop = false;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyInfo.Location = new System.Drawing.Point(12, 259);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(114, 43);
            this.btnMyInfo.TabIndex = 22;
            this.btnMyInfo.Text = "My Info";
            this.btnMyInfo.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 189);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(114, 42);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnMyStudent);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 473);
            this.panel3.TabIndex = 2;
            // 
            // btnMyStudent
            // 
            this.btnMyStudent.Location = new System.Drawing.Point(9, 337);
            this.btnMyStudent.Name = "btnMyStudent";
            this.btnMyStudent.Size = new System.Drawing.Size(114, 42);
            this.btnMyStudent.TabIndex = 23;
            this.btnMyStudent.Text = "My Student";
            this.btnMyStudent.UseVisualStyleBackColor = true;
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
            // TeacherSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.grbScheduleApp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherSchedule";
            this.grbScheduleApp.ResumeLayout(false);
            this.grbScheduleApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeShSchedule)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeScTeacherPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMyStudent;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbScheduleApp;
        private System.Windows.Forms.Button btnTeShUpdateCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTeShSessionCost;
        private System.Windows.Forms.DateTimePicker dtpTeShDateTime;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnTeShScheduleSession;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbTeShTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbTeShTScheduleSubject;
        private System.Windows.Forms.ListBox lbsTeShStudents;
        private System.Windows.Forms.DataGridView dgvTeShSchedule;
        private System.Windows.Forms.Button btnTeShDeleteSession;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTeScMyStudent;
        private System.Windows.Forms.Button btnTeScMyInfo;
        private System.Windows.Forms.Button btnTeScDashboards;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picTeScTeacherPicture;
        private System.Windows.Forms.Button btnTeScNotifications;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}