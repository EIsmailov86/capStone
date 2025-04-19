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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnFilterbySubject = new System.Windows.Forms.Button();
            this.btnFilterbyDate = new System.Windows.Forms.Button();
            this.cbmSubject = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.pgbBalance = new System.Windows.Forms.ProgressBar();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMyTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grbScheduleApp.SuspendLayout();
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
            // btnScheduleSession
            // 
            this.btnScheduleSession.Location = new System.Drawing.Point(80, 262);
            this.btnScheduleSession.Name = "btnScheduleSession";
            this.btnScheduleSession.Size = new System.Drawing.Size(200, 23);
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
            this.grbScheduleApp.Location = new System.Drawing.Point(180, 342);
            this.grbScheduleApp.Name = "grbScheduleApp";
            this.grbScheduleApp.Size = new System.Drawing.Size(359, 290);
            this.grbScheduleApp.TabIndex = 10;
            this.grbScheduleApp.TabStop = false;
            this.grbScheduleApp.Text = "Schedule Appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(135, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 31);
            this.panel1.TabIndex = 0;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnFilterbySubject);
            this.grbSearch.Controls.Add(this.btnFilterbyDate);
            this.grbSearch.Controls.Add(this.cbmSubject);
            this.grbSearch.Controls.Add(this.cmbDate);
            this.grbSearch.Location = new System.Drawing.Point(648, 362);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(279, 270);
            this.grbSearch.TabIndex = 15;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnFilterbySubject
            // 
            this.btnFilterbySubject.Location = new System.Drawing.Point(47, 241);
            this.btnFilterbySubject.Name = "btnFilterbySubject";
            this.btnFilterbySubject.Size = new System.Drawing.Size(200, 23);
            this.btnFilterbySubject.TabIndex = 12;
            this.btnFilterbySubject.Text = "Filter by Subject";
            this.btnFilterbySubject.UseVisualStyleBackColor = true;
            // 
            // btnFilterbyDate
            // 
            this.btnFilterbyDate.Location = new System.Drawing.Point(47, 118);
            this.btnFilterbyDate.Name = "btnFilterbyDate";
            this.btnFilterbyDate.Size = new System.Drawing.Size(200, 23);
            this.btnFilterbyDate.TabIndex = 11;
            this.btnFilterbyDate.Text = "Filter by Date";
            this.btnFilterbyDate.UseVisualStyleBackColor = true;
            // 
            // cbmSubject
            // 
            this.cbmSubject.FormattingEnabled = true;
            this.cbmSubject.Location = new System.Drawing.Point(47, 187);
            this.cbmSubject.Name = "cbmSubject";
            this.cbmSubject.Size = new System.Drawing.Size(200, 24);
            this.cbmSubject.TabIndex = 10;
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(47, 53);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(200, 24);
            this.cmbDate.TabIndex = 9;
            // 
            // pgbBalance
            // 
            this.pgbBalance.Location = new System.Drawing.Point(648, 314);
            this.pgbBalance.Name = "pgbBalance";
            this.pgbBalance.Size = new System.Drawing.Size(279, 23);
            this.pgbBalance.TabIndex = 16;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(546, 314);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(57, 16);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 653);
            this.panel2.TabIndex = 18;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.btnMyInfo);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnNotifications);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 653);
            this.pnlMenu.TabIndex = 21;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMyInfo.FlatAppearance.BorderSize = 0;
            this.btnMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnMyInfo.TabIndex = 22;
            this.btnMyInfo.Text = "   My Info";
            this.btnMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = global::JEM.Properties.Resources.xxsmallpayment;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "   Payment";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(0, 170);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnNotifications.TabIndex = 22;
            this.btnNotifications.Text = "   Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Image = global::JEM.Properties.Resources.xxsmallteacher;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 42);
            this.button2.TabIndex = 22;
            this.button2.Text = "   My Teacher";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Controls.Add(this.pictureBox2);
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
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.pgbBalance);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbScheduleApp);
            this.Controls.Add(this.dgvSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "studentdashboardform";
            this.Text = "studentdashboardform";
            this.Load += new System.EventHandler(this.studentdashboardform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grbScheduleApp.ResumeLayout(false);
            this.grbScheduleApp.PerformLayout();
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
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnMyTeacher;
    }
}