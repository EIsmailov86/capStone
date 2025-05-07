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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTDNotifications = new System.Windows.Forms.Button();
            this.btnTDMyStudent = new System.Windows.Forms.Button();
            this.btnTDMyInfo = new System.Windows.Forms.Button();
            this.btnTDSchedule = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pibTeDaTeacherPicture = new System.Windows.Forms.PictureBox();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMyStudent = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTeDaWelcome = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTeDaSearchBox = new System.Windows.Forms.GroupBox();
            this.btnTeDaFilterbySubject = new System.Windows.Forms.Button();
            this.btnTeDaFilterbyStudent = new System.Windows.Forms.Button();
            this.cmbTeDaStudent = new System.Windows.Forms.ComboBox();
            this.btnTeDaFilterbyDate = new System.Windows.Forms.Button();
            this.cmbTeDaSubject = new System.Windows.Forms.ComboBox();
            this.cmbTeDaDate = new System.Windows.Forms.ComboBox();
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txbTeDaBio = new System.Windows.Forms.TextBox();
            this.picTeDaStudentPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeDaTeacherPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grbTeDaSearchBox.SuspendLayout();
            this.grbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeDaStudentPicture)).BeginInit();
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
            this.panel5.Controls.Add(this.btnTDNotifications);
            this.panel5.Controls.Add(this.btnTDMyStudent);
            this.panel5.Controls.Add(this.btnTDMyInfo);
            this.panel5.Controls.Add(this.btnTDSchedule);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 653);
            this.panel5.TabIndex = 23;
            // 
            // btnTDNotifications
            // 
            this.btnTDNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTDNotifications.FlatAppearance.BorderSize = 0;
            this.btnTDNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTDNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTDNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnTDNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTDNotifications.Location = new System.Drawing.Point(0, 212);
            this.btnTDNotifications.Name = "btnTDNotifications";
            this.btnTDNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnTDNotifications.TabIndex = 23;
            this.btnTDNotifications.Text = "   Notifications";
            this.btnTDNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTDNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTDNotifications.UseVisualStyleBackColor = true;
            this.btnTDNotifications.Click += new System.EventHandler(this.btnTDNotifications_Click);
            // 
            // btnTDMyStudent
            // 
            this.btnTDMyStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTDMyStudent.FlatAppearance.BorderSize = 0;
            this.btnTDMyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTDMyStudent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTDMyStudent.Image = global::JEM.Properties.Resources.xxsmalluserONE;
            this.btnTDMyStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTDMyStudent.Location = new System.Drawing.Point(0, 170);
            this.btnTDMyStudent.Name = "btnTDMyStudent";
            this.btnTDMyStudent.Size = new System.Drawing.Size(135, 42);
            this.btnTDMyStudent.TabIndex = 21;
            this.btnTDMyStudent.Text = "   My Student";
            this.btnTDMyStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTDMyStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTDMyStudent.UseVisualStyleBackColor = true;
            this.btnTDMyStudent.Click += new System.EventHandler(this.btnTDMyStudent_Click);
            // 
            // btnTDMyInfo
            // 
            this.btnTDMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTDMyInfo.FlatAppearance.BorderSize = 0;
            this.btnTDMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTDMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTDMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnTDMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTDMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnTDMyInfo.Name = "btnTDMyInfo";
            this.btnTDMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnTDMyInfo.TabIndex = 21;
            this.btnTDMyInfo.Text = "   My Info";
            this.btnTDMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTDMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTDMyInfo.UseVisualStyleBackColor = true;
            this.btnTDMyInfo.Click += new System.EventHandler(this.btnTDMyInfo_Click);
            // 
            // btnTDSchedule
            // 
            this.btnTDSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTDSchedule.FlatAppearance.BorderSize = 0;
            this.btnTDSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTDSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTDSchedule.Image = global::JEM.Properties.Resources.xxsmallcalendar_checkmark_schedule;
            this.btnTDSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTDSchedule.Location = new System.Drawing.Point(0, 128);
            this.btnTDSchedule.Name = "btnTDSchedule";
            this.btnTDSchedule.Size = new System.Drawing.Size(135, 42);
            this.btnTDSchedule.TabIndex = 21;
            this.btnTDSchedule.Text = "   Schedule";
            this.btnTDSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTDSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTDSchedule.UseVisualStyleBackColor = true;
            this.btnTDSchedule.Click += new System.EventHandler(this.btnTDSchedule_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pibTeDaTeacherPicture);
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
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "JEM";
            // 
            // pibTeDaTeacherPicture
            // 
            this.pibTeDaTeacherPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pibTeDaTeacherPicture.ErrorImage = null;
            this.pibTeDaTeacherPicture.InitialImage = null;
            this.pibTeDaTeacherPicture.Location = new System.Drawing.Point(20, 8);
            this.pibTeDaTeacherPicture.Name = "pibTeDaTeacherPicture";
            this.pibTeDaTeacherPicture.Size = new System.Drawing.Size(91, 91);
            this.pibTeDaTeacherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTeDaTeacherPicture.TabIndex = 2;
            this.pibTeDaTeacherPicture.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblTeDaWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 3;
            // 
            // lblTeDaWelcome
            // 
            this.lblTeDaWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeDaWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTeDaWelcome.Location = new System.Drawing.Point(243, 8);
            this.lblTeDaWelcome.Name = "lblTeDaWelcome";
            this.lblTeDaWelcome.Size = new System.Drawing.Size(243, 23);
            this.lblTeDaWelcome.TabIndex = 23;
            this.lblTeDaWelcome.Text = "label2";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToOrderColumns = true;
            this.dgvSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.ColumnHeadersHeight = 29;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Column2,
            this.Time,
            this.Column1,
            this.Grade,
            this.Column3,
            this.Column4});
            this.dgvSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSchedule.Location = new System.Drawing.Point(144, 54);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(826, 226);
            this.dgvSchedule.TabIndex = 4;
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 81;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 65;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 67;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 121;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 74;
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
            this.Column4.Width = 86;
            // 
            // grbTeDaSearchBox
            // 
            this.grbTeDaSearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbTeDaSearchBox.AutoSize = true;
            this.grbTeDaSearchBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbTeDaSearchBox.Controls.Add(this.btnTeDaFilterbySubject);
            this.grbTeDaSearchBox.Controls.Add(this.btnTeDaFilterbyStudent);
            this.grbTeDaSearchBox.Controls.Add(this.cmbTeDaStudent);
            this.grbTeDaSearchBox.Controls.Add(this.btnTeDaFilterbyDate);
            this.grbTeDaSearchBox.Controls.Add(this.cmbTeDaSubject);
            this.grbTeDaSearchBox.Controls.Add(this.cmbTeDaDate);
            this.grbTeDaSearchBox.Location = new System.Drawing.Point(171, 343);
            this.grbTeDaSearchBox.Name = "grbTeDaSearchBox";
            this.grbTeDaSearchBox.Size = new System.Drawing.Size(326, 276);
            this.grbTeDaSearchBox.TabIndex = 16;
            this.grbTeDaSearchBox.TabStop = false;
            this.grbTeDaSearchBox.Text = "Search";
            // 
            // btnTeDaFilterbySubject
            // 
            this.btnTeDaFilterbySubject.AutoSize = true;
            this.btnTeDaFilterbySubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTeDaFilterbySubject.Image = global::JEM.Properties.Resources._34px_searchsubject;
            this.btnTeDaFilterbySubject.Location = new System.Drawing.Point(209, 93);
            this.btnTeDaFilterbySubject.Name = "btnTeDaFilterbySubject";
            this.btnTeDaFilterbySubject.Size = new System.Drawing.Size(40, 46);
            this.btnTeDaFilterbySubject.TabIndex = 12;
            this.btnTeDaFilterbySubject.UseCompatibleTextRendering = true;
            this.btnTeDaFilterbySubject.UseVisualStyleBackColor = true;
            this.btnTeDaFilterbySubject.Click += new System.EventHandler(this.btnTeDaFilterbySubject_Click);
            // 
            // btnTeDaFilterbyStudent
            // 
            this.btnTeDaFilterbyStudent.AutoSize = true;
            this.btnTeDaFilterbyStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTeDaFilterbyStudent.Image = global::JEM.Properties.Resources._34px_studentsearch;
            this.btnTeDaFilterbyStudent.Location = new System.Drawing.Point(209, 160);
            this.btnTeDaFilterbyStudent.Name = "btnTeDaFilterbyStudent";
            this.btnTeDaFilterbyStudent.Size = new System.Drawing.Size(40, 40);
            this.btnTeDaFilterbyStudent.TabIndex = 14;
            this.btnTeDaFilterbyStudent.UseCompatibleTextRendering = true;
            this.btnTeDaFilterbyStudent.UseVisualStyleBackColor = true;
            this.btnTeDaFilterbyStudent.Click += new System.EventHandler(this.btnTeDaFilterbyStudent_Click);
            // 
            // cmbTeDaStudent
            // 
            this.cmbTeDaStudent.FormattingEnabled = true;
            this.cmbTeDaStudent.Location = new System.Drawing.Point(6, 174);
            this.cmbTeDaStudent.Name = "cmbTeDaStudent";
            this.cmbTeDaStudent.Size = new System.Drawing.Size(200, 24);
            this.cmbTeDaStudent.TabIndex = 13;
            this.cmbTeDaStudent.Text = "Filter by Student";
            this.cmbTeDaStudent.SelectedIndexChanged += new System.EventHandler(this.btnTeDaFilterbyStudent_Click);
            // 
            // btnTeDaFilterbyDate
            // 
            this.btnTeDaFilterbyDate.AutoSize = true;
            this.btnTeDaFilterbyDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTeDaFilterbyDate.Image = global::JEM.Properties.Resources.xxx40px_search_by_Date;
            this.btnTeDaFilterbyDate.Location = new System.Drawing.Point(209, 25);
            this.btnTeDaFilterbyDate.Name = "btnTeDaFilterbyDate";
            this.btnTeDaFilterbyDate.Size = new System.Drawing.Size(46, 46);
            this.btnTeDaFilterbyDate.TabIndex = 11;
            this.btnTeDaFilterbyDate.UseCompatibleTextRendering = true;
            this.btnTeDaFilterbyDate.UseVisualStyleBackColor = true;
            this.btnTeDaFilterbyDate.Click += new System.EventHandler(this.btnTeDaFilterbyDate_Click);
            // 
            // cmbTeDaSubject
            // 
            this.cmbTeDaSubject.FormattingEnabled = true;
            this.cmbTeDaSubject.Location = new System.Drawing.Point(6, 107);
            this.cmbTeDaSubject.Name = "cmbTeDaSubject";
            this.cmbTeDaSubject.Size = new System.Drawing.Size(200, 24);
            this.cmbTeDaSubject.TabIndex = 10;
            this.cmbTeDaSubject.Text = "Search by Subject";
            this.cmbTeDaSubject.SelectedIndexChanged += new System.EventHandler(this.btnTeDaFilterbySubject_Click);
            // 
            // cmbTeDaDate
            // 
            this.cmbTeDaDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTeDaDate.FormattingEnabled = true;
            this.cmbTeDaDate.Location = new System.Drawing.Point(34, 34);
            this.cmbTeDaDate.Name = "cmbTeDaDate";
            this.cmbTeDaDate.Size = new System.Drawing.Size(200, 24);
            this.cmbTeDaDate.TabIndex = 9;
            this.cmbTeDaDate.Text = "Search by Date";
            this.cmbTeDaDate.SelectedIndexChanged += new System.EventHandler(this.btnTeDaFilterbyDate_Click);
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbStudentInfo.AutoSize = true;
            this.grbStudentInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbStudentInfo.Controls.Add(this.txbTeDaBio);
            this.grbStudentInfo.Controls.Add(this.picTeDaStudentPicture);
            this.grbStudentInfo.Location = new System.Drawing.Point(615, 302);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(353, 414);
            this.grbStudentInfo.TabIndex = 22;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Info";
            // 
            // txbTeDaBio
            // 
            this.txbTeDaBio.Location = new System.Drawing.Point(20, 151);
            this.txbTeDaBio.Multiline = true;
            this.txbTeDaBio.Name = "txbTeDaBio";
            this.txbTeDaBio.Size = new System.Drawing.Size(256, 175);
            this.txbTeDaBio.TabIndex = 31;
            this.txbTeDaBio.Text = "Bio";
            // 
            // picTeDaStudentPicture
            // 
            this.picTeDaStudentPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picTeDaStudentPicture.Location = new System.Drawing.Point(20, 21);
            this.picTeDaStudentPicture.Name = "picTeDaStudentPicture";
            this.picTeDaStudentPicture.Size = new System.Drawing.Size(256, 124);
            this.picTeDaStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeDaStudentPicture.TabIndex = 0;
            this.picTeDaStudentPicture.TabStop = false;
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.grbStudentInfo);
            this.Controls.Add(this.grbTeDaSearchBox);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherDashboard";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeDaTeacherPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grbTeDaSearchBox.ResumeLayout(false);
            this.grbTeDaSearchBox.PerformLayout();
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeDaStudentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox grbTeDaSearchBox;
        private System.Windows.Forms.Button btnTeDaFilterbyStudent;
        private System.Windows.Forms.ComboBox cmbTeDaStudent;
        private System.Windows.Forms.Button btnTeDaFilterbySubject;
        private System.Windows.Forms.Button btnTeDaFilterbyDate;
        private System.Windows.Forms.ComboBox cmbTeDaSubject;
        private System.Windows.Forms.ComboBox cmbTeDaDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.PictureBox picTeDaStudentPicture;
        private System.Windows.Forms.TextBox txbTeDaBio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTDMyStudent;
        private System.Windows.Forms.Button btnTDMyInfo;
        private System.Windows.Forms.Button btnTDSchedule;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pibTeDaTeacherPicture;
        private System.Windows.Forms.Button btnTDNotifications;
        private System.Windows.Forms.Label lblTeDaWelcome;
    }
}