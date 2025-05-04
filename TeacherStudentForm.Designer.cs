namespace JEM
{
    partial class TeacherStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherStudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTeStNotifications = new System.Windows.Forms.Button();
            this.btnTeStMyInfo = new System.Windows.Forms.Button();
            this.btnTeStSchedule = new System.Windows.Forms.Button();
            this.btnTeStDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pibTeStTeacherPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTeStWelcome = new System.Windows.Forms.Label();
            this.lbsTeStStudents = new System.Windows.Forms.ListBox();
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txbTeStStartingBalance = new System.Windows.Forms.TextBox();
            this.lblTeStStartingBalance = new System.Windows.Forms.Label();
            this.pibTeStStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnTeStDeleteStudent = new System.Windows.Forms.Button();
            this.btnTeStCreateStudent = new System.Windows.Forms.Button();
            this.btnTeStUpdateBalance = new System.Windows.Forms.Button();
            this.lblTeStRemainingBalance = new System.Windows.Forms.Label();
            this.pgbTeStBalance = new System.Windows.Forms.ProgressBar();
            this.btnTeStClear = new System.Windows.Forms.Button();
            this.btnTeStUpdateStudent = new System.Windows.Forms.Button();
            this.txbTeStTeStBio = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbTeStPhone = new System.Windows.Forms.TextBox();
            this.cmbTeStSubject = new System.Windows.Forms.ComboBox();
            this.cmbTeStGrade = new System.Windows.Forms.ComboBox();
            this.txbTeStAddress = new System.Windows.Forms.TextBox();
            this.txbTeStEmail = new System.Windows.Forms.TextBox();
            this.txbTeStName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeStTeacherPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeStStudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnTeStNotifications);
            this.panel1.Controls.Add(this.btnTeStMyInfo);
            this.panel1.Controls.Add(this.btnTeStSchedule);
            this.panel1.Controls.Add(this.btnTeStDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 653);
            this.panel1.TabIndex = 2;
            // 
            // btnTeStNotifications
            // 
            this.btnTeStNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeStNotifications.FlatAppearance.BorderSize = 0;
            this.btnTeStNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeStNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeStNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnTeStNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeStNotifications.Location = new System.Drawing.Point(0, 212);
            this.btnTeStNotifications.Name = "btnTeStNotifications";
            this.btnTeStNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnTeStNotifications.TabIndex = 23;
            this.btnTeStNotifications.Text = "   Notifications";
            this.btnTeStNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeStNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeStNotifications.UseVisualStyleBackColor = true;
            this.btnTeStNotifications.Click += new System.EventHandler(this.btnTeStNotifications_Click);
            // 
            // btnTeStMyInfo
            // 
            this.btnTeStMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTeStMyInfo.FlatAppearance.BorderSize = 0;
            this.btnTeStMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeStMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeStMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnTeStMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeStMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnTeStMyInfo.Name = "btnTeStMyInfo";
            this.btnTeStMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnTeStMyInfo.TabIndex = 21;
            this.btnTeStMyInfo.Text = "   My Info";
            this.btnTeStMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeStMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeStMyInfo.UseVisualStyleBackColor = true;
            this.btnTeStMyInfo.Click += new System.EventHandler(this.btnTeStMyInfo_Click);
            // 
            // btnTeStSchedule
            // 
            this.btnTeStSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeStSchedule.FlatAppearance.BorderSize = 0;
            this.btnTeStSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeStSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeStSchedule.Image = global::JEM.Properties.Resources.xxsmallcalendar_checkmark_schedule;
            this.btnTeStSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeStSchedule.Location = new System.Drawing.Point(0, 170);
            this.btnTeStSchedule.Name = "btnTeStSchedule";
            this.btnTeStSchedule.Size = new System.Drawing.Size(135, 42);
            this.btnTeStSchedule.TabIndex = 21;
            this.btnTeStSchedule.Text = "   Schedule";
            this.btnTeStSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeStSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeStSchedule.UseVisualStyleBackColor = true;
            this.btnTeStSchedule.Click += new System.EventHandler(this.btnTeStSchedule_Click);
            // 
            // btnTeStDashboard
            // 
            this.btnTeStDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeStDashboard.FlatAppearance.BorderSize = 0;
            this.btnTeStDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeStDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeStDashboard.Image = global::JEM.Properties.Resources.xxsmall_home_black_square;
            this.btnTeStDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeStDashboard.Location = new System.Drawing.Point(0, 128);
            this.btnTeStDashboard.Name = "btnTeStDashboard";
            this.btnTeStDashboard.Size = new System.Drawing.Size(135, 42);
            this.btnTeStDashboard.TabIndex = 21;
            this.btnTeStDashboard.Text = "   Dashboard";
            this.btnTeStDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeStDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeStDashboard.UseVisualStyleBackColor = true;
            this.btnTeStDashboard.Click += new System.EventHandler(this.btnTeStDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pibTeStTeacherPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 128);
            this.panel3.TabIndex = 2;
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
            // pibTeStTeacherPicture
            // 
            this.pibTeStTeacherPicture.Image = ((System.Drawing.Image)(resources.GetObject("pibTeStTeacherPicture.Image")));
            this.pibTeStTeacherPicture.Location = new System.Drawing.Point(32, 19);
            this.pibTeStTeacherPicture.Name = "pibTeStTeacherPicture";
            this.pibTeStTeacherPicture.Size = new System.Drawing.Size(63, 63);
            this.pibTeStTeacherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTeStTeacherPicture.TabIndex = 2;
            this.pibTeStTeacherPicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblTeStWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 4;
            // 
            // lblTeStWelcome
            // 
            this.lblTeStWelcome.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeStWelcome.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTeStWelcome.Location = new System.Drawing.Point(281, 8);
            this.lblTeStWelcome.Name = "lblTeStWelcome";
            this.lblTeStWelcome.Size = new System.Drawing.Size(282, 23);
            this.lblTeStWelcome.TabIndex = 7;
            this.lblTeStWelcome.Text = "label2";
            // 
            // lbsTeStStudents
            // 
            this.lbsTeStStudents.FormattingEnabled = true;
            this.lbsTeStStudents.ItemHeight = 16;
            this.lbsTeStStudents.Location = new System.Drawing.Point(509, 21);
            this.lbsTeStStudents.Name = "lbsTeStStudents";
            this.lbsTeStStudents.Size = new System.Drawing.Size(236, 324);
            this.lbsTeStStudents.TabIndex = 14;
            this.lbsTeStStudents.Click += new System.EventHandler(this.lbsTeStStudents_SelectedIndexChanged);
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbStudentInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbStudentInfo.Controls.Add(this.txbTeStStartingBalance);
            this.grbStudentInfo.Controls.Add(this.lblTeStStartingBalance);
            this.grbStudentInfo.Controls.Add(this.pibTeStStudentPicture);
            this.grbStudentInfo.Controls.Add(this.btnTeStDeleteStudent);
            this.grbStudentInfo.Controls.Add(this.btnTeStCreateStudent);
            this.grbStudentInfo.Controls.Add(this.btnTeStUpdateBalance);
            this.grbStudentInfo.Controls.Add(this.lblTeStRemainingBalance);
            this.grbStudentInfo.Controls.Add(this.pgbTeStBalance);
            this.grbStudentInfo.Controls.Add(this.btnTeStClear);
            this.grbStudentInfo.Controls.Add(this.btnTeStUpdateStudent);
            this.grbStudentInfo.Controls.Add(this.txbTeStTeStBio);
            this.grbStudentInfo.Controls.Add(this.lblEmail);
            this.grbStudentInfo.Controls.Add(this.lblAddress);
            this.grbStudentInfo.Controls.Add(this.lblPhone);
            this.grbStudentInfo.Controls.Add(this.lblSubject);
            this.grbStudentInfo.Controls.Add(this.lblGrade);
            this.grbStudentInfo.Controls.Add(this.lblName);
            this.grbStudentInfo.Controls.Add(this.txbTeStPhone);
            this.grbStudentInfo.Controls.Add(this.cmbTeStSubject);
            this.grbStudentInfo.Controls.Add(this.cmbTeStGrade);
            this.grbStudentInfo.Controls.Add(this.txbTeStAddress);
            this.grbStudentInfo.Controls.Add(this.txbTeStEmail);
            this.grbStudentInfo.Controls.Add(this.txbTeStName);
            this.grbStudentInfo.Controls.Add(this.lbsTeStStudents);
            this.grbStudentInfo.Location = new System.Drawing.Point(171, 71);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(751, 559);
            this.grbStudentInfo.TabIndex = 6;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Info";
            // 
            // txbTeStStartingBalance
            // 
            this.txbTeStStartingBalance.Location = new System.Drawing.Point(136, 305);
            this.txbTeStStartingBalance.Name = "txbTeStStartingBalance";
            this.txbTeStStartingBalance.Size = new System.Drawing.Size(111, 22);
            this.txbTeStStartingBalance.TabIndex = 7;
            this.txbTeStStartingBalance.TextChanged += new System.EventHandler(this.txbTeStStartingBalance_TextChanged);
            // 
            // lblTeStStartingBalance
            // 
            this.lblTeStStartingBalance.AutoSize = true;
            this.lblTeStStartingBalance.Location = new System.Drawing.Point(25, 311);
            this.lblTeStStartingBalance.Name = "lblTeStStartingBalance";
            this.lblTeStStartingBalance.Size = new System.Drawing.Size(105, 16);
            this.lblTeStStartingBalance.TabIndex = 39;
            this.lblTeStStartingBalance.Text = "Starting Balance";
            // 
            // pibTeStStudentPicture
            // 
            this.pibTeStStudentPicture.Location = new System.Drawing.Point(298, 46);
            this.pibTeStStudentPicture.Name = "pibTeStStudentPicture";
            this.pibTeStStudentPicture.Size = new System.Drawing.Size(139, 124);
            this.pibTeStStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTeStStudentPicture.TabIndex = 38;
            this.pibTeStStudentPicture.TabStop = false;
            // 
            // btnTeStDeleteStudent
            // 
            this.btnTeStDeleteStudent.Image = global::JEM.Properties.Resources.smallDelete_trash;
            this.btnTeStDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeStDeleteStudent.Location = new System.Drawing.Point(174, 459);
            this.btnTeStDeleteStudent.Name = "btnTeStDeleteStudent";
            this.btnTeStDeleteStudent.Size = new System.Drawing.Size(73, 67);
            this.btnTeStDeleteStudent.TabIndex = 12;
            this.btnTeStDeleteStudent.Text = "Delete";
            this.btnTeStDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeStDeleteStudent.UseCompatibleTextRendering = true;
            this.btnTeStDeleteStudent.UseVisualStyleBackColor = true;
            this.btnTeStDeleteStudent.Click += new System.EventHandler(this.btnTeStDeleteStudent_Click);
            // 
            // btnTeStCreateStudent
            // 
            this.btnTeStCreateStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTeStCreateStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTeStCreateStudent.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTeStCreateStudent.FlatAppearance.BorderSize = 0;
            this.btnTeStCreateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeStCreateStudent.Image = global::JEM.Properties.Resources.smallcreateUser;
            this.btnTeStCreateStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeStCreateStudent.Location = new System.Drawing.Point(37, 349);
            this.btnTeStCreateStudent.Name = "btnTeStCreateStudent";
            this.btnTeStCreateStudent.Size = new System.Drawing.Size(73, 67);
            this.btnTeStCreateStudent.TabIndex = 9;
            this.btnTeStCreateStudent.Text = "Create";
            this.btnTeStCreateStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeStCreateStudent.UseCompatibleTextRendering = true;
            this.btnTeStCreateStudent.UseVisualStyleBackColor = true;
            this.btnTeStCreateStudent.Click += new System.EventHandler(this.btnTeStCreateStudent_Click);
            // 
            // btnTeStUpdateBalance
            // 
            this.btnTeStUpdateBalance.Image = global::JEM.Properties.Resources._34px_updateBalance;
            this.btnTeStUpdateBalance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeStUpdateBalance.Location = new System.Drawing.Point(604, 476);
            this.btnTeStUpdateBalance.Name = "btnTeStUpdateBalance";
            this.btnTeStUpdateBalance.Size = new System.Drawing.Size(85, 77);
            this.btnTeStUpdateBalance.TabIndex = 13;
            this.btnTeStUpdateBalance.Text = "Update Balance";
            this.btnTeStUpdateBalance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeStUpdateBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeStUpdateBalance.UseVisualStyleBackColor = true;
            this.btnTeStUpdateBalance.Click += new System.EventHandler(this.btnTeStUpdateBalance_Click);
            // 
            // lblTeStRemainingBalance
            // 
            this.lblTeStRemainingBalance.AutoSize = true;
            this.lblTeStRemainingBalance.Location = new System.Drawing.Point(614, 396);
            this.lblTeStRemainingBalance.Name = "lblTeStRemainingBalance";
            this.lblTeStRemainingBalance.Size = new System.Drawing.Size(53, 20);
            this.lblTeStRemainingBalance.TabIndex = 34;
            this.lblTeStRemainingBalance.Text = "Balance";
            this.lblTeStRemainingBalance.UseCompatibleTextRendering = true;
            // 
            // pgbTeStBalance
            // 
            this.pgbTeStBalance.Location = new System.Drawing.Point(551, 434);
            this.pgbTeStBalance.Name = "pgbTeStBalance";
            this.pgbTeStBalance.Size = new System.Drawing.Size(174, 36);
            this.pgbTeStBalance.TabIndex = 33;
            // 
            // btnTeStClear
            // 
            this.btnTeStClear.Image = global::JEM.Properties.Resources.smallClearPic;
            this.btnTeStClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeStClear.Location = new System.Drawing.Point(37, 459);
            this.btnTeStClear.Name = "btnTeStClear";
            this.btnTeStClear.Size = new System.Drawing.Size(73, 67);
            this.btnTeStClear.TabIndex = 11;
            this.btnTeStClear.Text = "Clear";
            this.btnTeStClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeStClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeStClear.UseCompatibleTextRendering = true;
            this.btnTeStClear.UseVisualStyleBackColor = true;
            this.btnTeStClear.Click += new System.EventHandler(this.btnTeStClear_Click);
            // 
            // btnTeStUpdateStudent
            // 
            this.btnTeStUpdateStudent.Image = global::JEM.Properties.Resources.xxx38pxUpdate;
            this.btnTeStUpdateStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeStUpdateStudent.Location = new System.Drawing.Point(174, 349);
            this.btnTeStUpdateStudent.Name = "btnTeStUpdateStudent";
            this.btnTeStUpdateStudent.Size = new System.Drawing.Size(73, 67);
            this.btnTeStUpdateStudent.TabIndex = 10;
            this.btnTeStUpdateStudent.Text = "Update";
            this.btnTeStUpdateStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeStUpdateStudent.UseCompatibleTextRendering = true;
            this.btnTeStUpdateStudent.UseVisualStyleBackColor = true;
            this.btnTeStUpdateStudent.Click += new System.EventHandler(this.btnTeStUpdateStudent_Click);
            // 
            // txbTeStTeStBio
            // 
            this.txbTeStTeStBio.Location = new System.Drawing.Point(289, 212);
            this.txbTeStTeStBio.Multiline = true;
            this.txbTeStTeStBio.Name = "txbTeStTeStBio";
            this.txbTeStTeStBio.Size = new System.Drawing.Size(179, 324);
            this.txbTeStTeStBio.TabIndex = 8;
            this.txbTeStTeStBio.Text = "Bio";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 271);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 226);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "Phone";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(25, 131);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 16);
            this.lblSubject.TabIndex = 26;
            this.lblSubject.Text = "Subject";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(25, 91);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(45, 16);
            this.lblGrade.TabIndex = 25;
            this.lblGrade.Text = "Grade";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name";
            // 
            // txbTeStPhone
            // 
            this.txbTeStPhone.Location = new System.Drawing.Point(126, 174);
            this.txbTeStPhone.Name = "txbTeStPhone";
            this.txbTeStPhone.Size = new System.Drawing.Size(121, 22);
            this.txbTeStPhone.TabIndex = 4;
            // 
            // cmbTeStSubject
            // 
            this.cmbTeStSubject.FormattingEnabled = true;
            this.cmbTeStSubject.Location = new System.Drawing.Point(126, 123);
            this.cmbTeStSubject.Name = "cmbTeStSubject";
            this.cmbTeStSubject.Size = new System.Drawing.Size(121, 24);
            this.cmbTeStSubject.TabIndex = 3;
            // 
            // cmbTeStGrade
            // 
            this.cmbTeStGrade.FormattingEnabled = true;
            this.cmbTeStGrade.Location = new System.Drawing.Point(126, 83);
            this.cmbTeStGrade.Name = "cmbTeStGrade";
            this.cmbTeStGrade.Size = new System.Drawing.Size(121, 24);
            this.cmbTeStGrade.TabIndex = 2;
            // 
            // txbTeStAddress
            // 
            this.txbTeStAddress.Location = new System.Drawing.Point(126, 220);
            this.txbTeStAddress.Name = "txbTeStAddress";
            this.txbTeStAddress.Size = new System.Drawing.Size(121, 22);
            this.txbTeStAddress.TabIndex = 5;
            // 
            // txbTeStEmail
            // 
            this.txbTeStEmail.Location = new System.Drawing.Point(126, 265);
            this.txbTeStEmail.Name = "txbTeStEmail";
            this.txbTeStEmail.Size = new System.Drawing.Size(121, 22);
            this.txbTeStEmail.TabIndex = 6;
            // 
            // txbTeStName
            // 
            this.txbTeStName.Location = new System.Drawing.Point(126, 46);
            this.txbTeStName.Name = "txbTeStName";
            this.txbTeStName.Size = new System.Drawing.Size(121, 22);
            this.txbTeStName.TabIndex = 1;
            // 
            // TeacherStudentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.grbStudentInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeStTeacherPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeStStudentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTeStDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pibTeStTeacherPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbsTeStStudents;
        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.Button btnTeStClear;
        private System.Windows.Forms.Button btnTeStUpdateStudent;
        private System.Windows.Forms.TextBox txbTeStTeStBio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbTeStPhone;
        private System.Windows.Forms.ComboBox cmbTeStSubject;
        private System.Windows.Forms.ComboBox cmbTeStGrade;
        private System.Windows.Forms.TextBox txbTeStAddress;
        private System.Windows.Forms.TextBox txbTeStEmail;
        private System.Windows.Forms.TextBox txbTeStName;
        private System.Windows.Forms.Button btnTeStUpdateBalance;
        private System.Windows.Forms.Label lblTeStRemainingBalance;
        private System.Windows.Forms.ProgressBar pgbTeStBalance;
        private System.Windows.Forms.Button btnTeStDeleteStudent;
        private System.Windows.Forms.Button btnTeStCreateStudent;
        private System.Windows.Forms.PictureBox pibTeStStudentPicture;
        private System.Windows.Forms.Button btnTeStSchedule;
        private System.Windows.Forms.Button btnTeStMyInfo;
        private System.Windows.Forms.Button btnTeStNotifications;
        private System.Windows.Forms.Label lblTeStWelcome;
        private System.Windows.Forms.TextBox txbTeStStartingBalance;
        private System.Windows.Forms.Label lblTeStStartingBalance;
    }
}