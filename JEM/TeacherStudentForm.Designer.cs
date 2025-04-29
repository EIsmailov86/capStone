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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTeStWelcome = new System.Windows.Forms.Label();
            this.lbsStudents = new System.Windows.Forms.ListBox();
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.pibStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnUpdateBalance = new System.Windows.Forms.Button();
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.pgbBalance = new System.Windows.Forms.ProgressBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.txbBio = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStudentPicture)).BeginInit();
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
            this.panel3.Controls.Add(this.pictureBox1);
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
            // lbsStudents
            // 
            this.lbsStudents.FormattingEnabled = true;
            this.lbsStudents.ItemHeight = 16;
            this.lbsStudents.Location = new System.Drawing.Point(509, 21);
            this.lbsStudents.Name = "lbsStudents";
            this.lbsStudents.Size = new System.Drawing.Size(236, 324);
            this.lbsStudents.TabIndex = 5;
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.pibStudentPicture);
            this.grbStudentInfo.Controls.Add(this.btnDeleteStudent);
            this.grbStudentInfo.Controls.Add(this.btnCreateStudent);
            this.grbStudentInfo.Controls.Add(this.btnUpdateBalance);
            this.grbStudentInfo.Controls.Add(this.lblRemainingBalance);
            this.grbStudentInfo.Controls.Add(this.pgbBalance);
            this.grbStudentInfo.Controls.Add(this.btnClear);
            this.grbStudentInfo.Controls.Add(this.btnUpdateStudent);
            this.grbStudentInfo.Controls.Add(this.txbBio);
            this.grbStudentInfo.Controls.Add(this.lblEmail);
            this.grbStudentInfo.Controls.Add(this.lblAddress);
            this.grbStudentInfo.Controls.Add(this.lblPhone);
            this.grbStudentInfo.Controls.Add(this.lblSubject);
            this.grbStudentInfo.Controls.Add(this.lblGrade);
            this.grbStudentInfo.Controls.Add(this.lblName);
            this.grbStudentInfo.Controls.Add(this.txbPhone);
            this.grbStudentInfo.Controls.Add(this.cmbSubject);
            this.grbStudentInfo.Controls.Add(this.cmbGrade);
            this.grbStudentInfo.Controls.Add(this.txbAddress);
            this.grbStudentInfo.Controls.Add(this.txbEmail);
            this.grbStudentInfo.Controls.Add(this.txbName);
            this.grbStudentInfo.Controls.Add(this.lbsStudents);
            this.grbStudentInfo.Location = new System.Drawing.Point(171, 71);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(751, 559);
            this.grbStudentInfo.TabIndex = 6;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Info";
            // 
            // pibStudentPicture
            // 
            this.pibStudentPicture.Location = new System.Drawing.Point(298, 46);
            this.pibStudentPicture.Name = "pibStudentPicture";
            this.pibStudentPicture.Size = new System.Drawing.Size(139, 124);
            this.pibStudentPicture.TabIndex = 38;
            this.pibStudentPicture.TabStop = false;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(28, 513);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteStudent.TabIndex = 37;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(28, 348);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(144, 23);
            this.btnCreateStudent.TabIndex = 36;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBalance
            // 
            this.btnUpdateBalance.Location = new System.Drawing.Point(579, 513);
            this.btnUpdateBalance.Name = "btnUpdateBalance";
            this.btnUpdateBalance.Size = new System.Drawing.Size(131, 24);
            this.btnUpdateBalance.TabIndex = 35;
            this.btnUpdateBalance.Text = "Update Balance";
            this.btnUpdateBalance.UseVisualStyleBackColor = true;
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.AutoSize = true;
            this.lblRemainingBalance.Location = new System.Drawing.Point(605, 406);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(57, 16);
            this.lblRemainingBalance.TabIndex = 34;
            this.lblRemainingBalance.Text = "Balance";
            // 
            // pgbBalance
            // 
            this.pgbBalance.Location = new System.Drawing.Point(555, 459);
            this.pgbBalance.Name = "pgbBalance";
            this.pgbBalance.Size = new System.Drawing.Size(174, 36);
            this.pgbBalance.TabIndex = 33;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(28, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(28, 406);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateStudent.TabIndex = 31;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // txbBio
            // 
            this.txbBio.Location = new System.Drawing.Point(289, 212);
            this.txbBio.Multiline = true;
            this.txbBio.Name = "txbBio";
            this.txbBio.Size = new System.Drawing.Size(179, 324);
            this.txbBio.TabIndex = 30;
            this.txbBio.Text = "Bio";
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
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(126, 174);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(121, 22);
            this.txbPhone.TabIndex = 23;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(126, 123);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 24);
            this.cmbSubject.TabIndex = 22;
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(126, 83);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 24);
            this.cmbGrade.TabIndex = 21;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(126, 220);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(121, 22);
            this.txbAddress.TabIndex = 20;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(126, 265);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(121, 22);
            this.txbEmail.TabIndex = 19;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(126, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(121, 22);
            this.txbName.TabIndex = 18;
            // 
            // TeacherStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibStudentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTeStDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbsStudents;
        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox txbBio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnUpdateBalance;
        private System.Windows.Forms.Label lblRemainingBalance;
        private System.Windows.Forms.ProgressBar pgbBalance;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.PictureBox pibStudentPicture;
        private System.Windows.Forms.Button btnTeStSchedule;
        private System.Windows.Forms.Button btnTeStMyInfo;
        private System.Windows.Forms.Button btnTeStNotifications;
        private System.Windows.Forms.Label lblTeStWelcome;
    }
}