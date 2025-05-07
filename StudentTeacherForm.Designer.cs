namespace JEM
{
    partial class StudentTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTeacherForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSTMyInfo = new System.Windows.Forms.Button();
            this.btnSTPayment = new System.Windows.Forms.Button();
            this.btnSTNotifications = new System.Windows.Forms.Button();
            this.btnSTDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStTeWelcome = new System.Windows.Forms.Label();
            this.grbTeacherInfo = new System.Windows.Forms.GroupBox();
            this.txbMessageHeader = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txbMessageBody = new System.Windows.Forms.TextBox();
            this.picStTeTeacherPicture = new System.Windows.Forms.PictureBox();
            this.txbStTeInfoandBio = new System.Windows.Forms.TextBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbTeacherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStTeTeacherPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.btnSTMyInfo);
            this.pnlMenu.Controls.Add(this.btnSTPayment);
            this.pnlMenu.Controls.Add(this.btnSTNotifications);
            this.pnlMenu.Controls.Add(this.btnSTDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 653);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnSTMyInfo
            // 
            this.btnSTMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSTMyInfo.FlatAppearance.BorderSize = 0;
            this.btnSTMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSTMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnSTMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnSTMyInfo.Name = "btnSTMyInfo";
            this.btnSTMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnSTMyInfo.TabIndex = 22;
            this.btnSTMyInfo.Text = "   My Info";
            this.btnSTMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSTMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSTMyInfo.UseVisualStyleBackColor = true;
            this.btnSTMyInfo.Click += new System.EventHandler(this.btnStTeMyInfo_Click);
            // 
            // btnSTPayment
            // 
            this.btnSTPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSTPayment.FlatAppearance.BorderSize = 0;
            this.btnSTPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTPayment.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSTPayment.Image = global::JEM.Properties.Resources.xxsmallpayment;
            this.btnSTPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTPayment.Location = new System.Drawing.Point(0, 212);
            this.btnSTPayment.Name = "btnSTPayment";
            this.btnSTPayment.Size = new System.Drawing.Size(135, 42);
            this.btnSTPayment.TabIndex = 22;
            this.btnSTPayment.Text = "   Payment";
            this.btnSTPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSTPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSTPayment.UseVisualStyleBackColor = true;
            this.btnSTPayment.Click += new System.EventHandler(this.btnStTePayment_Click);
            // 
            // btnSTNotifications
            // 
            this.btnSTNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSTNotifications.FlatAppearance.BorderSize = 0;
            this.btnSTNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSTNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnSTNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTNotifications.Location = new System.Drawing.Point(0, 170);
            this.btnSTNotifications.Name = "btnSTNotifications";
            this.btnSTNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnSTNotifications.TabIndex = 22;
            this.btnSTNotifications.Text = "   Notifications";
            this.btnSTNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSTNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSTNotifications.UseVisualStyleBackColor = true;
            this.btnSTNotifications.Click += new System.EventHandler(this.btnStTeNotifications_Click);
            // 
            // btnSTDashboard
            // 
            this.btnSTDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSTDashboard.FlatAppearance.BorderSize = 0;
            this.btnSTDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSTDashboard.Image = global::JEM.Properties.Resources.xxsmall_home_black_square;
            this.btnSTDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTDashboard.Location = new System.Drawing.Point(0, 128);
            this.btnSTDashboard.Name = "btnSTDashboard";
            this.btnSTDashboard.Size = new System.Drawing.Size(135, 42);
            this.btnSTDashboard.TabIndex = 22;
            this.btnSTDashboard.Text = "   Dashboard";
            this.btnSTDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSTDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSTDashboard.UseVisualStyleBackColor = true;
            this.btnSTDashboard.Click += new System.EventHandler(this.btnStTeDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(135, 128);
            this.pnlLogo.TabIndex = 2;
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
            this.panel2.Controls.Add(this.lblStTeWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 2;
            // 
            // lblStTeWelcome
            // 
            this.lblStTeWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStTeWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStTeWelcome.Location = new System.Drawing.Point(231, 9);
            this.lblStTeWelcome.Name = "lblStTeWelcome";
            this.lblStTeWelcome.Size = new System.Drawing.Size(281, 23);
            this.lblStTeWelcome.TabIndex = 20;
            this.lblStTeWelcome.Text = "label1";
            // 
            // grbTeacherInfo
            // 
            this.grbTeacherInfo.Controls.Add(this.txbMessageHeader);
            this.grbTeacherInfo.Controls.Add(this.btnSendMessage);
            this.grbTeacherInfo.Controls.Add(this.txbMessageBody);
            this.grbTeacherInfo.Controls.Add(this.picStTeTeacherPicture);
            this.grbTeacherInfo.Controls.Add(this.txbStTeInfoandBio);
            this.grbTeacherInfo.Controls.Add(this.cmbTeacher);
            this.grbTeacherInfo.Location = new System.Drawing.Point(232, 88);
            this.grbTeacherInfo.Name = "grbTeacherInfo";
            this.grbTeacherInfo.Size = new System.Drawing.Size(626, 500);
            this.grbTeacherInfo.TabIndex = 13;
            this.grbTeacherInfo.TabStop = false;
            this.grbTeacherInfo.Text = "Teacher Info";
            // 
            // txbMessageHeader
            // 
            this.txbMessageHeader.Location = new System.Drawing.Point(301, 210);
            this.txbMessageHeader.Multiline = true;
            this.txbMessageHeader.Name = "txbMessageHeader";
            this.txbMessageHeader.Size = new System.Drawing.Size(274, 33);
            this.txbMessageHeader.TabIndex = 9;
            this.txbMessageHeader.Text = "Message Teacher Header";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(301, 418);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(274, 23);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txbMessageBody
            // 
            this.txbMessageBody.Location = new System.Drawing.Point(301, 249);
            this.txbMessageBody.Multiline = true;
            this.txbMessageBody.Name = "txbMessageBody";
            this.txbMessageBody.Size = new System.Drawing.Size(274, 139);
            this.txbMessageBody.TabIndex = 7;
            this.txbMessageBody.Text = "Message Teacher Body";
            // 
            // picStTeTeacherPicture
            // 
            this.picStTeTeacherPicture.Location = new System.Drawing.Point(358, 21);
            this.picStTeTeacherPicture.Name = "picStTeTeacherPicture";
            this.picStTeTeacherPicture.Size = new System.Drawing.Size(173, 157);
            this.picStTeTeacherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStTeTeacherPicture.TabIndex = 6;
            this.picStTeTeacherPicture.TabStop = false;
            // 
            // txbStTeInfoandBio
            // 
            this.txbStTeInfoandBio.Location = new System.Drawing.Point(38, 103);
            this.txbStTeInfoandBio.Multiline = true;
            this.txbStTeInfoandBio.Name = "txbStTeInfoandBio";
            this.txbStTeInfoandBio.Size = new System.Drawing.Size(201, 338);
            this.txbStTeInfoandBio.TabIndex = 5;
            this.txbStTeInfoandBio.Text = "Teacher\'s Info and Bio";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(38, 47);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(201, 24);
            this.cmbTeacher.TabIndex = 4;
            this.cmbTeacher.Text = "Teachers";
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // StudentTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.grbTeacherInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Name = "StudentTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentTeacherForm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbTeacherInfo.ResumeLayout(false);
            this.grbTeacherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStTeTeacherPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbTeacherInfo;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.TextBox txbStTeInfoandBio;
        private System.Windows.Forms.PictureBox picStTeTeacherPicture;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txbMessageBody;
        private System.Windows.Forms.Button btnSTDashboard;
        private System.Windows.Forms.Button btnSTNotifications;
        private System.Windows.Forms.Button btnSTPayment;
        private System.Windows.Forms.Button btnSTMyInfo;
        private System.Windows.Forms.Label lblStTeWelcome;
        private System.Windows.Forms.TextBox txbMessageHeader;
    }
}