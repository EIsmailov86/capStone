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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.pibStudentPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.grbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStudentPicture)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 816);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(152, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 39);
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
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 816);
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
            this.btnTDNotifications.Location = new System.Drawing.Point(0, 264);
            this.btnTDNotifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTDNotifications.Name = "btnTDNotifications";
            this.btnTDNotifications.Size = new System.Drawing.Size(152, 52);
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
            this.btnTDMyStudent.Location = new System.Drawing.Point(0, 212);
            this.btnTDMyStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTDMyStudent.Name = "btnTDMyStudent";
            this.btnTDMyStudent.Size = new System.Drawing.Size(152, 52);
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
            this.btnTDMyInfo.Location = new System.Drawing.Point(0, 764);
            this.btnTDMyInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTDMyInfo.Name = "btnTDMyInfo";
            this.btnTDMyInfo.Size = new System.Drawing.Size(152, 52);
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
            this.btnTDSchedule.Location = new System.Drawing.Point(0, 160);
            this.btnTDSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTDSchedule.Name = "btnTDSchedule";
            this.btnTDSchedule.Size = new System.Drawing.Size(152, 52);
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
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 160);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(45, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "JEM";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyInfo.Location = new System.Drawing.Point(14, 324);
            this.btnMyInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(128, 59);
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
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 529);
            this.panel3.TabIndex = 2;
            // 
            // btnMyStudent
            // 
            this.btnMyStudent.Location = new System.Drawing.Point(10, 425);
            this.btnMyStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMyStudent.Name = "btnMyStudent";
            this.btnMyStudent.Size = new System.Drawing.Size(128, 52);
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
            this.btnSchedule.Location = new System.Drawing.Point(10, 228);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(128, 52);
            this.btnSchedule.TabIndex = 21;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblUserName.Location = new System.Drawing.Point(20, 106);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(109, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblTeDaWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 39);
            this.panel2.TabIndex = 3;
            // 
            // lblTeDaWelcome
            // 
            this.lblTeDaWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeDaWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTeDaWelcome.Location = new System.Drawing.Point(273, 10);
            this.lblTeDaWelcome.Name = "lblTeDaWelcome";
            this.lblTeDaWelcome.Size = new System.Drawing.Size(273, 29);
            this.lblTeDaWelcome.TabIndex = 23;
            this.lblTeDaWelcome.Text = "label2";
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
            this.dgvSchedule.Location = new System.Drawing.Point(162, 68);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(929, 282);
            this.dgvSchedule.TabIndex = 4;
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
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
            this.grbSearch.Location = new System.Drawing.Point(192, 429);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSearch.Size = new System.Drawing.Size(304, 356);
            this.grbSearch.TabIndex = 16;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnFilterbyStudent
            // 
            this.btnFilterbyStudent.Location = new System.Drawing.Point(20, 311);
            this.btnFilterbyStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilterbyStudent.Name = "btnFilterbyStudent";
            this.btnFilterbyStudent.Size = new System.Drawing.Size(225, 29);
            this.btnFilterbyStudent.TabIndex = 14;
            this.btnFilterbyStudent.Text = "Filter by Student";
            this.btnFilterbyStudent.UseVisualStyleBackColor = true;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(20, 258);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(224, 28);
            this.cmbStudent.TabIndex = 13;
            // 
            // btnFilterbySubject
            // 
            this.btnFilterbySubject.Location = new System.Drawing.Point(20, 205);
            this.btnFilterbySubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilterbySubject.Name = "btnFilterbySubject";
            this.btnFilterbySubject.Size = new System.Drawing.Size(225, 29);
            this.btnFilterbySubject.TabIndex = 12;
            this.btnFilterbySubject.Text = "Filter by Subject";
            this.btnFilterbySubject.UseVisualStyleBackColor = true;
            // 
            // btnFilterbyDate
            // 
            this.btnFilterbyDate.Location = new System.Drawing.Point(20, 99);
            this.btnFilterbyDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilterbyDate.Name = "btnFilterbyDate";
            this.btnFilterbyDate.Size = new System.Drawing.Size(225, 29);
            this.btnFilterbyDate.TabIndex = 11;
            this.btnFilterbyDate.Text = "Filter by Date";
            this.btnFilterbyDate.UseVisualStyleBackColor = true;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(20, 151);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(224, 28);
            this.cmbSubject.TabIndex = 10;
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(20, 45);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(224, 28);
            this.cmbDate.TabIndex = 9;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSession.Location = new System.Drawing.Point(162, 356);
            this.btnDeleteSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(173, 52);
            this.btnDeleteSession.TabIndex = 17;
            this.btnDeleteSession.Text = "Delete Session";
            this.btnDeleteSession.UseVisualStyleBackColor = false;
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.txbBio);
            this.grbStudentInfo.Controls.Add(this.pibStudentPicture);
            this.grbStudentInfo.Location = new System.Drawing.Point(692, 378);
            this.grbStudentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbStudentInfo.Size = new System.Drawing.Size(336, 418);
            this.grbStudentInfo.TabIndex = 22;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Info";
            // 
            // txbBio
            // 
            this.txbBio.Location = new System.Drawing.Point(22, 189);
            this.txbBio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBio.Multiline = true;
            this.txbBio.Name = "txbBio";
            this.txbBio.Size = new System.Drawing.Size(288, 218);
            this.txbBio.TabIndex = 31;
            this.txbBio.Text = "Bio";
            // 
            // pibStudentPicture
            // 
            this.pibStudentPicture.Location = new System.Drawing.Point(84, 26);
            this.pibStudentPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pibStudentPicture.Name = "pibStudentPicture";
            this.pibStudentPicture.Size = new System.Drawing.Size(156, 155);
            this.pibStudentPicture.TabIndex = 0;
            this.pibStudentPicture.TabStop = false;
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 816);
            this.Controls.Add(this.grbStudentInfo);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherDashboard";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStudentPicture)).EndInit();
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
        private System.Windows.Forms.Button btnTDMyStudent;
        private System.Windows.Forms.Button btnTDMyInfo;
        private System.Windows.Forms.Button btnTDSchedule;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTDNotifications;
        private System.Windows.Forms.Label lblTeDaWelcome;
    }
}