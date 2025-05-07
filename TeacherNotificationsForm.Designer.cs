namespace JEM
{
    partial class TeacherNotificationsForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTNSchedule = new System.Windows.Forms.Button();
            this.btnTNMyStudent = new System.Windows.Forms.Button();
            this.btnTNMyInfo = new System.Windows.Forms.Button();
            this.btnTNDashboard = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pibTeNoTeacherPicture = new System.Windows.Forms.PictureBox();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMyStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTeNoWelcome = new System.Windows.Forms.Label();
            this.grbNotifications = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbNotifications = new System.Windows.Forms.TextBox();
            this.cmbHeading = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeNoTeacherPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbNotifications.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 4;
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
            this.panel5.Controls.Add(this.btnTNSchedule);
            this.panel5.Controls.Add(this.btnTNMyStudent);
            this.panel5.Controls.Add(this.btnTNMyInfo);
            this.panel5.Controls.Add(this.btnTNDashboard);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 653);
            this.panel5.TabIndex = 23;
            // 
            // btnTNSchedule
            // 
            this.btnTNSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTNSchedule.FlatAppearance.BorderSize = 0;
            this.btnTNSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTNSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTNSchedule.Image = global::JEM.Properties.Resources.xxsmallcalendar_checkmark_schedule;
            this.btnTNSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTNSchedule.Location = new System.Drawing.Point(0, 212);
            this.btnTNSchedule.Name = "btnTNSchedule";
            this.btnTNSchedule.Size = new System.Drawing.Size(135, 42);
            this.btnTNSchedule.TabIndex = 22;
            this.btnTNSchedule.Text = "   Schedule";
            this.btnTNSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTNSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTNSchedule.UseVisualStyleBackColor = true;
            this.btnTNSchedule.Click += new System.EventHandler(this.btnTNSchedule_Click);
            // 
            // btnTNMyStudent
            // 
            this.btnTNMyStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTNMyStudent.FlatAppearance.BorderSize = 0;
            this.btnTNMyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTNMyStudent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTNMyStudent.Image = global::JEM.Properties.Resources.xxsmalluserONE;
            this.btnTNMyStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTNMyStudent.Location = new System.Drawing.Point(0, 170);
            this.btnTNMyStudent.Name = "btnTNMyStudent";
            this.btnTNMyStudent.Size = new System.Drawing.Size(135, 42);
            this.btnTNMyStudent.TabIndex = 21;
            this.btnTNMyStudent.Text = "   My Student";
            this.btnTNMyStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTNMyStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTNMyStudent.UseVisualStyleBackColor = true;
            this.btnTNMyStudent.Click += new System.EventHandler(this.btnTNMyStudent_Click);
            // 
            // btnTNMyInfo
            // 
            this.btnTNMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTNMyInfo.FlatAppearance.BorderSize = 0;
            this.btnTNMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTNMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTNMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnTNMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTNMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnTNMyInfo.Name = "btnTNMyInfo";
            this.btnTNMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnTNMyInfo.TabIndex = 21;
            this.btnTNMyInfo.Text = "   My Info";
            this.btnTNMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTNMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTNMyInfo.UseVisualStyleBackColor = true;
            this.btnTNMyInfo.Click += new System.EventHandler(this.btnTNMyInfo_Click);
            // 
            // btnTNDashboard
            // 
            this.btnTNDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTNDashboard.FlatAppearance.BorderSize = 0;
            this.btnTNDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTNDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTNDashboard.Image = global::JEM.Properties.Resources.xxsmall_home_black_square;
            this.btnTNDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTNDashboard.Location = new System.Drawing.Point(0, 128);
            this.btnTNDashboard.Name = "btnTNDashboard";
            this.btnTNDashboard.Size = new System.Drawing.Size(135, 42);
            this.btnTNDashboard.TabIndex = 21;
            this.btnTNDashboard.Text = "   Dashboard";
            this.btnTNDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTNDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTNDashboard.UseVisualStyleBackColor = true;
            this.btnTNDashboard.Click += new System.EventHandler(this.btnTNDashboard_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pibTeNoTeacherPicture);
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
            // pibTeNoTeacherPicture
            // 
            this.pibTeNoTeacherPicture.Image = global::JEM.Properties.Resources.user;
            this.pibTeNoTeacherPicture.Location = new System.Drawing.Point(32, 19);
            this.pibTeNoTeacherPicture.Name = "pibTeNoTeacherPicture";
            this.pibTeNoTeacherPicture.Size = new System.Drawing.Size(63, 63);
            this.pibTeNoTeacherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTeNoTeacherPicture.TabIndex = 2;
            this.pibTeNoTeacherPicture.TabStop = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblTeNoWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 6;
            // 
            // lblTeNoWelcome
            // 
            this.lblTeNoWelcome.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeNoWelcome.ForeColor = System.Drawing.Color.Orange;
            this.lblTeNoWelcome.Location = new System.Drawing.Point(284, 3);
            this.lblTeNoWelcome.Name = "lblTeNoWelcome";
            this.lblTeNoWelcome.Size = new System.Drawing.Size(259, 28);
            this.lblTeNoWelcome.TabIndex = 9;
            this.lblTeNoWelcome.Text = "label4";
            // 
            // grbNotifications
            // 
            this.grbNotifications.Controls.Add(this.btnDelete);
            this.grbNotifications.Controls.Add(this.txbNotifications);
            this.grbNotifications.Controls.Add(this.cmbHeading);
            this.grbNotifications.Location = new System.Drawing.Point(310, 111);
            this.grbNotifications.Name = "grbNotifications";
            this.grbNotifications.Size = new System.Drawing.Size(433, 410);
            this.grbNotifications.TabIndex = 7;
            this.grbNotifications.TabStop = false;
            this.grbNotifications.Text = "Notifications";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::JEM.Properties.Resources.smallDelete_trash;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(162, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 62);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbNotifications
            // 
            this.txbNotifications.Location = new System.Drawing.Point(123, 106);
            this.txbNotifications.Multiline = true;
            this.txbNotifications.Name = "txbNotifications";
            this.txbNotifications.Size = new System.Drawing.Size(198, 199);
            this.txbNotifications.TabIndex = 2;
            // 
            // cmbHeading
            // 
            this.cmbHeading.FormattingEnabled = true;
            this.cmbHeading.Location = new System.Drawing.Point(123, 64);
            this.cmbHeading.Name = "cmbHeading";
            this.cmbHeading.Size = new System.Drawing.Size(198, 24);
            this.cmbHeading.TabIndex = 1;
            this.cmbHeading.Text = "Heading";
            this.cmbHeading.SelectedIndexChanged += new System.EventHandler(this.LoadMessageBody);
            // 
            // TeacherNotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.grbNotifications);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherNotificationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherNotificationsForm";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTeNoTeacherPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbNotifications.ResumeLayout(false);
            this.grbNotifications.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTNMyStudent;
        private System.Windows.Forms.Button btnTNMyInfo;
        private System.Windows.Forms.Button btnTNDashboard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pibTeNoTeacherPicture;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMyStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTNSchedule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbNotifications;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbNotifications;
        private System.Windows.Forms.ComboBox cmbHeading;
        private System.Windows.Forms.Label lblTeNoWelcome;
    }
}