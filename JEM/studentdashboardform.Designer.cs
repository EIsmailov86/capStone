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
            this.btnScheduleSession = new System.Windows.Forms.Button();
            this.grbScheduleApp = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStDaWelcome = new System.Windows.Forms.Label();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnFilterbySubject = new System.Windows.Forms.Button();
            this.btnFilterbyDate = new System.Windows.Forms.Button();
            this.cbmSubject = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.pgbBalance = new System.Windows.Forms.ProgressBar();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnStDaMyInfo = new System.Windows.Forms.Button();
            this.btnStDaPayment = new System.Windows.Forms.Button();
            this.btnStDaNotifications = new System.Windows.Forms.Button();
            this.btnStDaMyTeacher = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.dgvSchedule.Location = new System.Drawing.Point(202, 90);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(885, 282);
            this.dgvSchedule.TabIndex = 0;
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(39, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(39, 171);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(39, 258);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 20);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 82);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(148, 161);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(224, 28);
            this.cmbTime.TabIndex = 6;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(148, 248);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(224, 28);
            this.cmbSubject.TabIndex = 7;
            // 
            // btnScheduleSession
            // 
            this.btnScheduleSession.Location = new System.Drawing.Point(90, 328);
            this.btnScheduleSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScheduleSession.Name = "btnScheduleSession";
            this.btnScheduleSession.Size = new System.Drawing.Size(225, 29);
            this.btnScheduleSession.TabIndex = 8;
            this.btnScheduleSession.Text = "Schedule Session";
            this.btnScheduleSession.UseVisualStyleBackColor = true;
            // 
            // grbScheduleApp
            // 
            this.grbScheduleApp.Controls.Add(this.dateTimePicker1);
            this.grbScheduleApp.Controls.Add(this.lblSubject);
            this.grbScheduleApp.Controls.Add(this.btnScheduleSession);
            this.grbScheduleApp.Controls.Add(this.lblTime);
            this.grbScheduleApp.Controls.Add(this.cmbTime);
            this.grbScheduleApp.Controls.Add(this.lblDate);
            this.grbScheduleApp.Controls.Add(this.cmbSubject);
            this.grbScheduleApp.Location = new System.Drawing.Point(202, 428);
            this.grbScheduleApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbScheduleApp.Name = "grbScheduleApp";
            this.grbScheduleApp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbScheduleApp.Size = new System.Drawing.Size(404, 362);
            this.grbScheduleApp.TabIndex = 10;
            this.grbScheduleApp.TabStop = false;
            this.grbScheduleApp.Text = "Schedule Appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblStDaWelcome);
            this.panel1.Location = new System.Drawing.Point(152, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblStDaWelcome
            // 
            this.lblStDaWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStDaWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStDaWelcome.Location = new System.Drawing.Point(305, 10);
            this.lblStDaWelcome.Name = "lblStDaWelcome";
            this.lblStDaWelcome.Size = new System.Drawing.Size(316, 29);
            this.lblStDaWelcome.TabIndex = 19;
            this.lblStDaWelcome.Text = "label1";
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnFilterbySubject);
            this.grbSearch.Controls.Add(this.btnFilterbyDate);
            this.grbSearch.Controls.Add(this.cbmSubject);
            this.grbSearch.Controls.Add(this.cmbDate);
            this.grbSearch.Location = new System.Drawing.Point(729, 452);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSearch.Size = new System.Drawing.Size(314, 338);
            this.grbSearch.TabIndex = 15;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnFilterbySubject
            // 
            this.btnFilterbySubject.Location = new System.Drawing.Point(53, 301);
            this.btnFilterbySubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilterbySubject.Name = "btnFilterbySubject";
            this.btnFilterbySubject.Size = new System.Drawing.Size(225, 29);
            this.btnFilterbySubject.TabIndex = 12;
            this.btnFilterbySubject.Text = "Filter by Subject";
            this.btnFilterbySubject.UseVisualStyleBackColor = true;
            // 
            // btnFilterbyDate
            // 
            this.btnFilterbyDate.Location = new System.Drawing.Point(53, 148);
            this.btnFilterbyDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilterbyDate.Name = "btnFilterbyDate";
            this.btnFilterbyDate.Size = new System.Drawing.Size(225, 29);
            this.btnFilterbyDate.TabIndex = 11;
            this.btnFilterbyDate.Text = "Filter by Date";
            this.btnFilterbyDate.UseVisualStyleBackColor = true;
            // 
            // cbmSubject
            // 
            this.cbmSubject.FormattingEnabled = true;
            this.cbmSubject.Location = new System.Drawing.Point(53, 234);
            this.cbmSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbmSubject.Name = "cbmSubject";
            this.cbmSubject.Size = new System.Drawing.Size(224, 28);
            this.cbmSubject.TabIndex = 10;
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(53, 66);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(224, 28);
            this.cmbDate.TabIndex = 9;
            // 
            // pgbBalance
            // 
            this.pgbBalance.Location = new System.Drawing.Point(729, 392);
            this.pgbBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pgbBalance.Name = "pgbBalance";
            this.pgbBalance.Size = new System.Drawing.Size(314, 29);
            this.pgbBalance.TabIndex = 16;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(614, 392);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(67, 20);
            this.lblBalance.TabIndex = 17;
            this.lblBalance.Text = "Balance";
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 816);
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
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(152, 816);
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
            this.btnStDaMyInfo.Location = new System.Drawing.Point(0, 764);
            this.btnStDaMyInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStDaMyInfo.Name = "btnStDaMyInfo";
            this.btnStDaMyInfo.Size = new System.Drawing.Size(152, 52);
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
            this.btnStDaPayment.Location = new System.Drawing.Point(0, 264);
            this.btnStDaPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStDaPayment.Name = "btnStDaPayment";
            this.btnStDaPayment.Size = new System.Drawing.Size(152, 52);
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
            this.btnStDaNotifications.Location = new System.Drawing.Point(0, 212);
            this.btnStDaNotifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStDaNotifications.Name = "btnStDaNotifications";
            this.btnStDaNotifications.Size = new System.Drawing.Size(152, 52);
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
            this.btnStDaMyTeacher.Location = new System.Drawing.Point(0, 160);
            this.btnStDaMyTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStDaMyTeacher.Name = "btnStDaMyTeacher";
            this.btnStDaMyTeacher.Size = new System.Drawing.Size(152, 52);
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
            this.pnlLogo.Controls.Add(this.pictureBox2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(152, 160);
            this.pnlLogo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "JEM";
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
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(20, 562);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(128, 52);
            this.btnDashboard.TabIndex = 18;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(24, 682);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(128, 86);
            this.btnPayment.TabIndex = 19;
            this.btnPayment.Text = "Payment/\r\nNotifications";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnMyTeacher
            // 
            this.btnMyTeacher.Location = new System.Drawing.Point(0, 622);
            this.btnMyTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMyTeacher.Name = "btnMyTeacher";
            this.btnMyTeacher.Size = new System.Drawing.Size(128, 52);
            this.btnMyTeacher.TabIndex = 20;
            this.btnMyTeacher.Text = "My Teacher";
            this.btnMyTeacher.UseVisualStyleBackColor = true;
            // 
            // studentdashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 816);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.pgbBalance);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbScheduleApp);
            this.Controls.Add(this.dgvSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "studentdashboardform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentdashboardform";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grbScheduleApp.ResumeLayout(false);
            this.grbScheduleApp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ProgressBar pgbBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnStDaMyInfo;
        private System.Windows.Forms.Button btnStDaPayment;
        private System.Windows.Forms.Button btnStDaNotifications;
        private System.Windows.Forms.Button btnStDaMyTeacher;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnMyTeacher;
        private System.Windows.Forms.Label lblStDaWelcome;
    }
}