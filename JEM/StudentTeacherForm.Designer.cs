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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbTeacherInfo = new System.Windows.Forms.GroupBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txbMessageTeacher = new System.Windows.Forms.TextBox();
            this.txbInfoandBio = new System.Windows.Forms.TextBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.grbTeacherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.btnPayment);
            this.pnlMenu.Controls.Add(this.btnNotifications);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 653);
            this.pnlMenu.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 2;
            // 
            // grbTeacherInfo
            // 
            this.grbTeacherInfo.Controls.Add(this.btnSendMessage);
            this.grbTeacherInfo.Controls.Add(this.txbMessageTeacher);
            this.grbTeacherInfo.Controls.Add(this.picTeacher);
            this.grbTeacherInfo.Controls.Add(this.txbInfoandBio);
            this.grbTeacherInfo.Controls.Add(this.cmbSubject);
            this.grbTeacherInfo.Location = new System.Drawing.Point(232, 88);
            this.grbTeacherInfo.Name = "grbTeacherInfo";
            this.grbTeacherInfo.Size = new System.Drawing.Size(626, 500);
            this.grbTeacherInfo.TabIndex = 13;
            this.grbTeacherInfo.TabStop = false;
            this.grbTeacherInfo.Text = "Teacher Info";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(301, 418);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(274, 23);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // txbMessageTeacher
            // 
            this.txbMessageTeacher.Location = new System.Drawing.Point(301, 238);
            this.txbMessageTeacher.Multiline = true;
            this.txbMessageTeacher.Name = "txbMessageTeacher";
            this.txbMessageTeacher.Size = new System.Drawing.Size(274, 150);
            this.txbMessageTeacher.TabIndex = 7;
            this.txbMessageTeacher.Text = "Message Teacher";
            // 
            // txbInfoandBio
            // 
            this.txbInfoandBio.Location = new System.Drawing.Point(38, 103);
            this.txbInfoandBio.Multiline = true;
            this.txbInfoandBio.Name = "txbInfoandBio";
            this.txbInfoandBio.Size = new System.Drawing.Size(201, 338);
            this.txbInfoandBio.TabIndex = 5;
            this.txbInfoandBio.Text = "Teacher\'s Info and Bio";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(38, 47);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(201, 24);
            this.cmbSubject.TabIndex = 4;
            this.cmbSubject.Text = "Subject";
            // 
            // picTeacher
            // 
            this.picTeacher.Location = new System.Drawing.Point(352, 47);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(173, 157);
            this.picTeacher.TabIndex = 6;
            this.picTeacher.TabStop = false;
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayment.Image = global::JEM.Properties.Resources.xxsmallpayment;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(0, 212);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(135, 42);
            this.btnPayment.TabIndex = 22;
            this.btnPayment.Text = "   Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
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
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.Image = global::JEM.Properties.Resources.xxsmall_home_black_square;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 128);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(135, 42);
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 42);
            this.button2.TabIndex = 22;
            this.button2.Text = "   My Info";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
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
            this.Text = "StudentTeacherForm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.grbTeacherInfo.ResumeLayout(false);
            this.grbTeacherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbTeacherInfo;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txbInfoandBio;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txbMessageTeacher;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button button2;
    }
}