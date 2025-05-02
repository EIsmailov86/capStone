namespace JEM
{
    partial class studentdashboardform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentdashboardform));
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.grbScheduleApp = new System.Windows.Forms.GroupBox();
            this.btnScheduleSession = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStDaWelcome = new System.Windows.Forms.Label();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnFilterbySubject = new System.Windows.Forms.Button();
            this.btnFilterbyDate = new System.Windows.Forms.Button();
            this.cbmSubject = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.pgbStDaBalance = new System.Windows.Forms.ProgressBar();
            this.lblStDaRemainingBalance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnStDaMyInfo = new System.Windows.Forms.Button();
            this.btnStDaPayment = new System.Windows.Forms.Button();
            this.btnStDaNotifications = new System.Windows.Forms.Button();
            this.btnStDaMyTeacher = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pibStDaStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMyTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grbScheduleApp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStDaStudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToOrderColumns = true;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Column2,
            this.Time,
            this.Column1,
            this.Grade,
            this.Column3,
            this.Column4});
            this.dgvSchedule.Location = new System.Drawing.Point(180, 72);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(787, 226);
            this.dgvSchedule.TabIndex = 0;
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
            this.Column1.HeaderText = "Teacher Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 117;
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
            this.Column3.Width = 106;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Balance";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 86;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 72);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(35, 137);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 16);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(35, 206);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 16);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(132, 129);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(200, 24);
            this.cmbTime.TabIndex = 6;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(132, 198);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(200, 24);
            this.cmbSubject.TabIndex = 7;
            // 
            // grbScheduleApp
            // 
            this.grbScheduleApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbScheduleApp.AutoSize = true;
            this.grbScheduleApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbScheduleApp.Controls.Add(this.dateTimePicker1);
            this.grbScheduleApp.Controls.Add(this.lblSubject);
            this.grbScheduleApp.Controls.Add(this.btnScheduleSession);
            this.grbScheduleApp.Controls.Add(this.lblTime);
            this.grbScheduleApp.Controls.Add(this.cmbTime);
            this.grbScheduleApp.Controls.Add(this.lblDate);
            this.grbScheduleApp.Controls.Add(this.cmbSubject);
            this.grbScheduleApp.Location = new System.Drawing.Point(180, 342);
            this.grbScheduleApp.Name = "grbScheduleApp";
            this.grbScheduleApp.Size = new System.Drawing.Size(338, 305);
            this.grbScheduleApp.TabIndex = 10;
            this.grbScheduleApp.TabStop = false;
            this.grbScheduleApp.Text = "Schedule Appointment";
            // 
            // btnScheduleSession
            // 
            this.btnScheduleSession.AutoSize = true;
            this.btnScheduleSession.Image = global::JEM.Properties.Resources.xxx40px_person_clock_calendar;
            this.btnScheduleSession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleSession.Location = new System.Drawing.Point(147, 234);
            this.btnScheduleSession.Name = "btnScheduleSession";
            this.btnScheduleSession.Size = new System.Drawing.Size(173, 50);
            this.btnScheduleSession.TabIndex = 8;
            this.btnScheduleSession.Text = "Schedule Session";
            this.btnScheduleSession.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScheduleSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScheduleSession.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblStDaWelcome);
            this.panel1.Location = new System.Drawing.Point(135, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 31);
            this.panel1.TabIndex = 0;
            // 
            // lblStDaWelcome
            // 
            this.lblStDaWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStDaWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStDaWelcome.Location = new System.Drawing.Point(271, 8);
            this.lblStDaWelcome.Name = "lblStDaWelcome";
            this.lblStDaWelcome.Size = new System.Drawing.Size(281, 23);
            this.lblStDaWelcome.TabIndex = 19;
            this.lblStDaWelcome.Text = "label1";
            // 
            // grbSearch
            // 
            this.grbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbSearch.AutoSize = true;
            this.grbSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbSearch.Controls.Add(this.btnFilterbySubject);
            this.grbSearch.Controls.Add(this.btnFilterbyDate);
            this.grbSearch.Controls.Add(this.cbmSubject);
            this.grbSearch.Controls.Add(this.cmbDate);
            this.grbSearch.Location = new System.Drawing.Point(648, 455);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(264, 192);
            this.grbSearch.TabIndex = 15;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnFilterbySubject
            // 
            this.btnFilterbySubject.AutoSize = true;
            this.btnFilterbySubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilterbySubject.Image = global::JEM.Properties.Resources._34px_searchsubject;
            this.btnFilterbySubject.Location = new System.Drawing.Point(212, 125);
            this.btnFilterbySubject.Name = "btnFilterbySubject";
            this.btnFilterbySubject.Size = new System.Drawing.Size(40, 46);
            this.btnFilterbySubject.TabIndex = 12;
            this.btnFilterbySubject.UseVisualStyleBackColor = true;
            // 
            // btnFilterbyDate
            // 
            this.btnFilterbyDate.AutoSize = true;
            this.btnFilterbyDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilterbyDate.Image = global::JEM.Properties.Resources.xxx40px_search_by_Date;
            this.btnFilterbyDate.Location = new System.Drawing.Point(212, 41);
            this.btnFilterbyDate.Name = "btnFilterbyDate";
            this.btnFilterbyDate.Size = new System.Drawing.Size(46, 46);
            this.btnFilterbyDate.TabIndex = 11;
            this.btnFilterbyDate.UseVisualStyleBackColor = true;
            // 
            // cbmSubject
            // 
            this.cbmSubject.FormattingEnabled = true;
            this.cbmSubject.Location = new System.Drawing.Point(6, 136);
            this.cbmSubject.Name = "cbmSubject";
            this.cbmSubject.Size = new System.Drawing.Size(200, 24);
            this.cbmSubject.TabIndex = 10;
            this.cbmSubject.Text = "Filter by Subject";
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(6, 52);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(200, 24);
            this.cmbDate.TabIndex = 9;
            this.cmbDate.Text = "Filter by Date";
            // 
            // pgbStDaBalance
            // 
            this.pgbStDaBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pgbStDaBalance.Location = new System.Drawing.Point(612, 377);
            this.pgbStDaBalance.Name = "pgbStDaBalance";
            this.pgbStDaBalance.Size = new System.Drawing.Size(322, 36);
            this.pgbStDaBalance.TabIndex = 16;
            // 
            // lblStDaRemainingBalance
            // 
            this.lblStDaRemainingBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStDaRemainingBalance.AutoSize = true;
            this.lblStDaRemainingBalance.Location = new System.Drawing.Point(692, 358);
            this.lblStDaRemainingBalance.Name = "lblStDaRemainingBalance";
            this.lblStDaRemainingBalance.Size = new System.Drawing.Size(125, 16);
            this.lblStDaRemainingBalance.TabIndex = 17;
            this.lblStDaRemainingBalance.Text = "Remaining Balance";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pnlMenu);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.btnMyTeacher);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 653);
            this.panel2.TabIndex = 18;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.btnStDaMyInfo);
            this.pnlMenu.Controls.Add(this.btnStDaPayment);
            this.pnlMenu.Controls.Add(this.btnStDaNotifications);
            this.pnlMenu.Controls.Add(this.btnStDaMyTeacher);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 653);
            this.pnlMenu.TabIndex = 21;
            // 
            // btnStDaMyInfo
            // 
            this.btnStDaMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStDaMyInfo.FlatAppearance.BorderSize = 0;
            this.btnStDaMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStDaMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStDaMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnStDaMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStDaMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnStDaMyInfo.Name = "btnStDaMyInfo";
            this.btnStDaMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnStDaMyInfo.TabIndex = 22;
            this.btnStDaMyInfo.Text = "   My Info";
            this.btnStDaMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStDaMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStDaMyInfo.UseVisualStyleBackColor = true;
            this.btnStDaMyInfo.Click += new System.EventHandler(this.btnStDaMyInfo_Click);
            // 
            // btnStDaPayment
            // 
            this.btnStDaPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStDaPayment.FlatAppearance.BorderSize = 0;
            this.btnStDaPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStDaPayment.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStDaPayment.Image = global::JEM.Properties.Resources.xxsmallpayment;
            this.btnStDaPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStDaPayment.Location = new System.Drawing.Point(0, 212);
            this.btnStDaPayment.Name = "btnStDaPayment";
            this.btnStDaPayment.Size = new System.Drawing.Size(135, 42);
            this.btnStDaPayment.TabIndex = 22;
            this.btnStDaPayment.Text = "   Payment";
            this.btnStDaPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStDaPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStDaPayment.UseVisualStyleBackColor = true;
            this.btnStDaPayment.Click += new System.EventHandler(this.btnStDaPayment_Click);
            // 
            // btnStDaNotifications
            // 
            this.btnStDaNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStDaNotifications.FlatAppearance.BorderSize = 0;
            this.btnStDaNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStDaNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStDaNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnStDaNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStDaNotifications.Location = new System.Drawing.Point(0, 170);
            this.btnStDaNotifications.Name = "btnStDaNotifications";
            this.btnStDaNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnStDaNotifications.TabIndex = 22;
            this.btnStDaNotifications.Text = "   Notifications";
            this.btnStDaNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStDaNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStDaNotifications.UseVisualStyleBackColor = true;
            this.btnStDaNotifications.Click += new System.EventHandler(this.btnStDaNotifications_Click);
            // 
            // btnStDaMyTeacher
            // 
            this.btnStDaMyTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStDaMyTeacher.FlatAppearance.BorderSize = 0;
            this.btnStDaMyTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStDaMyTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStDaMyTeacher.Image = global::JEM.Properties.Resources.xxsmallteacher;
            this.btnStDaMyTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStDaMyTeacher.Location = new System.Drawing.Point(0, 128);
            this.btnStDaMyTeacher.Name = "btnStDaMyTeacher";
            this.btnStDaMyTeacher.Size = new System.Drawing.Size(135, 42);
            this.btnStDaMyTeacher.TabIndex = 22;
            this.btnStDaMyTeacher.Text = "   My Teacher";
            this.btnStDaMyTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStDaMyTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStDaMyTeacher.UseVisualStyleBackColor = true;
            this.btnStDaMyTeacher.Click += new System.EventHandler(this.btnStDaMyTeacher_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Controls.Add(this.pibStDaStudentPicture);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(135, 128);
            this.pnlLogo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "JEM";
            // 
            // pibStDaStudentPicture
            // 
            this.pibStDaStudentPicture.Image = ((System.Drawing.Image)(resources.GetObject("pibStDaStudentPicture.Image")));
            this.pibStDaStudentPicture.Location = new System.Drawing.Point(32, 19);
            this.pibStDaStudentPicture.Name = "pibStDaStudentPicture";
            this.pibStDaStudentPicture.Size = new System.Drawing.Size(63, 63);
            this.pibStDaStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibStDaStudentPicture.TabIndex = 2;
            this.pibStDaStudentPicture.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(18, 450);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(114, 42);
            this.btnDashboard.TabIndex = 18;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(21, 546);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(114, 69);
            this.btnPayment.TabIndex = 19;
            this.btnPayment.Text = "Payment/\r\nNotifications";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnMyTeacher
            // 
            this.btnMyTeacher.Location = new System.Drawing.Point(0, 498);
            this.btnMyTeacher.Name = "btnMyTeacher";
            this.btnMyTeacher.Size = new System.Drawing.Size(114, 42);
            this.btnMyTeacher.TabIndex = 20;
            this.btnMyTeacher.Text = "My Teacher";
            this.btnMyTeacher.UseVisualStyleBackColor = true;
            // 
            // studentdashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblStDaRemainingBalance);
            this.Controls.Add(this.pgbStDaBalance);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbScheduleApp);
            this.Controls.Add(this.dgvSchedule);
            this.Name = "studentdashboardform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentdashboardform";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grbScheduleApp.ResumeLayout(false);
            this.grbScheduleApp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStDaStudentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Button btnScheduleSession;
        private System.Windows.Forms.GroupBox grbScheduleApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnFilterbySubject;
        private System.Windows.Forms.Button btnFilterbyDate;
        private System.Windows.Forms.ComboBox cbmSubject;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.ProgressBar pgbStDaBalance;
        private System.Windows.Forms.Label lblStDaRemainingBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnStDaMyInfo;
        private System.Windows.Forms.Button btnStDaPayment;
        private System.Windows.Forms.Button btnStDaNotifications;
        private System.Windows.Forms.Button btnStDaMyTeacher;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pibStDaStudentPicture;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnMyTeacher;
        private System.Windows.Forms.Label lblStDaWelcome;
    }
}