namespace JEM
{
    partial class StudentEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEditForm));
            this.grbStudentEdit = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbMyBio = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSEDMyInfo = new System.Windows.Forms.Button();
            this.btnSEDPayment = new System.Windows.Forms.Button();
            this.btnSEDNotifications = new System.Windows.Forms.Button();
            this.btnSEDMyTeacher = new System.Windows.Forms.Button();
            this.btnSEDDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMyTeacher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStEdWelcome = new System.Windows.Forms.Label();
            this.picStEdStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnStEdUploadPicture = new System.Windows.Forms.Button();
            this.grbStudentEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStEdStudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStudentEdit
            // 
            this.grbStudentEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbStudentEdit.Controls.Add(this.btnClear);
            this.grbStudentEdit.Controls.Add(this.btnUpdate);
            this.grbStudentEdit.Controls.Add(this.txbMyBio);
            this.grbStudentEdit.Controls.Add(this.lblEmail);
            this.grbStudentEdit.Controls.Add(this.lblAddress);
            this.grbStudentEdit.Controls.Add(this.lblPhone);
            this.grbStudentEdit.Controls.Add(this.lblGrade);
            this.grbStudentEdit.Controls.Add(this.lblName);
            this.grbStudentEdit.Controls.Add(this.txbPhone);
            this.grbStudentEdit.Controls.Add(this.cmbGrade);
            this.grbStudentEdit.Controls.Add(this.txbAddress);
            this.grbStudentEdit.Controls.Add(this.txbEmail);
            this.grbStudentEdit.Controls.Add(this.txbName);
            this.grbStudentEdit.Location = new System.Drawing.Point(209, 128);
            this.grbStudentEdit.Name = "grbStudentEdit";
            this.grbStudentEdit.Size = new System.Drawing.Size(511, 400);
            this.grbStudentEdit.TabIndex = 0;
            this.grbStudentEdit.TabStop = false;
            this.grbStudentEdit.Text = "Edit My Info";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::JEM.Properties.Resources.smallClearPic;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(309, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 53);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbMyBio
            // 
            this.txbMyBio.Location = new System.Drawing.Point(309, 32);
            this.txbMyBio.Multiline = true;
            this.txbMyBio.Name = "txbMyBio";
            this.txbMyBio.Size = new System.Drawing.Size(179, 241);
            this.txbMyBio.TabIndex = 15;
            this.txbMyBio.Text = "My Bio...";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 221);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 176);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 127);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(30, 77);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(45, 16);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "Grade";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(131, 124);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(121, 22);
            this.txbPhone.TabIndex = 5;
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(131, 69);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 24);
            this.cmbGrade.TabIndex = 3;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(131, 170);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(121, 22);
            this.txbAddress.TabIndex = 2;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(131, 215);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(121, 22);
            this.txbEmail.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(131, 32);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(121, 22);
            this.txbName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlMenu);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnMyTeacher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 653);
            this.panel1.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.btnSEDMyInfo);
            this.pnlMenu.Controls.Add(this.btnSEDPayment);
            this.pnlMenu.Controls.Add(this.btnSEDNotifications);
            this.pnlMenu.Controls.Add(this.btnSEDMyTeacher);
            this.pnlMenu.Controls.Add(this.btnSEDDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 653);
            this.pnlMenu.TabIndex = 21;
            // 
            // btnSEDMyInfo
            // 
            this.btnSEDMyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSEDMyInfo.FlatAppearance.BorderSize = 0;
            this.btnSEDMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEDMyInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSEDMyInfo.Image = global::JEM.Properties.Resources.xxsmallsettings_black;
            this.btnSEDMyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEDMyInfo.Location = new System.Drawing.Point(0, 611);
            this.btnSEDMyInfo.Name = "btnSEDMyInfo";
            this.btnSEDMyInfo.Size = new System.Drawing.Size(135, 42);
            this.btnSEDMyInfo.TabIndex = 22;
            this.btnSEDMyInfo.Text = "   My Info";
            this.btnSEDMyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEDMyInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSEDMyInfo.UseVisualStyleBackColor = true;
            this.btnSEDMyInfo.Click += new System.EventHandler(this.btnMyInfo_Click);
            // 
            // btnSEDPayment
            // 
            this.btnSEDPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSEDPayment.FlatAppearance.BorderSize = 0;
            this.btnSEDPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEDPayment.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSEDPayment.Image = global::JEM.Properties.Resources.xxsmallpayment;
            this.btnSEDPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEDPayment.Location = new System.Drawing.Point(0, 254);
            this.btnSEDPayment.Name = "btnSEDPayment";
            this.btnSEDPayment.Size = new System.Drawing.Size(135, 42);
            this.btnSEDPayment.TabIndex = 22;
            this.btnSEDPayment.Text = "   Payment";
            this.btnSEDPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEDPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSEDPayment.UseVisualStyleBackColor = true;
            this.btnSEDPayment.Click += new System.EventHandler(this.btnStEdPayment_Click);
            // 
            // btnSEDNotifications
            // 
            this.btnSEDNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSEDNotifications.FlatAppearance.BorderSize = 0;
            this.btnSEDNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEDNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSEDNotifications.Image = global::JEM.Properties.Resources.xxsmallnotification;
            this.btnSEDNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEDNotifications.Location = new System.Drawing.Point(0, 212);
            this.btnSEDNotifications.Name = "btnSEDNotifications";
            this.btnSEDNotifications.Size = new System.Drawing.Size(135, 42);
            this.btnSEDNotifications.TabIndex = 22;
            this.btnSEDNotifications.Text = "   Notifications";
            this.btnSEDNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEDNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSEDNotifications.UseVisualStyleBackColor = true;
            this.btnSEDNotifications.Click += new System.EventHandler(this.btnStEdNotifications_Click);
            // 
            // btnSEDMyTeacher
            // 
            this.btnSEDMyTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSEDMyTeacher.FlatAppearance.BorderSize = 0;
            this.btnSEDMyTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEDMyTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSEDMyTeacher.Image = global::JEM.Properties.Resources.xxsmallteacher;
            this.btnSEDMyTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEDMyTeacher.Location = new System.Drawing.Point(0, 170);
            this.btnSEDMyTeacher.Name = "btnSEDMyTeacher";
            this.btnSEDMyTeacher.Size = new System.Drawing.Size(135, 42);
            this.btnSEDMyTeacher.TabIndex = 22;
            this.btnSEDMyTeacher.Text = "   My Teacher";
            this.btnSEDMyTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEDMyTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSEDMyTeacher.UseVisualStyleBackColor = true;
            this.btnSEDMyTeacher.Click += new System.EventHandler(this.btnStEdMyTeacher_Click);
            // 
            // btnSEDDashboard
            // 
            this.btnSEDDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSEDDashboard.FlatAppearance.BorderSize = 0;
            this.btnSEDDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEDDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSEDDashboard.Image = global::JEM.Properties.Resources.xxsmall_home_black_square;
            this.btnSEDDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEDDashboard.Location = new System.Drawing.Point(0, 128);
            this.btnSEDDashboard.Name = "btnSEDDashboard";
            this.btnSEDDashboard.Size = new System.Drawing.Size(135, 42);
            this.btnSEDDashboard.TabIndex = 22;
            this.btnSEDDashboard.Text = "   Dashboard";
            this.btnSEDDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEDDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSEDDashboard.UseVisualStyleBackColor = true;
            this.btnSEDDashboard.Click += new System.EventHandler(this.btnStEdDashboard_Click);
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
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
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
            this.btnDashboard.Click += new System.EventHandler(this.btnMyInfo_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblStEdWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 0;
            // 
            // lblStEdWelcome
            // 
            this.lblStEdWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStEdWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStEdWelcome.Location = new System.Drawing.Point(268, 8);
            this.lblStEdWelcome.Name = "lblStEdWelcome";
            this.lblStEdWelcome.Size = new System.Drawing.Size(281, 23);
            this.lblStEdWelcome.TabIndex = 20;
            this.lblStEdWelcome.Text = "label1";
            // 
            // picStEdStudentPicture
            // 
            this.picStEdStudentPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStEdStudentPicture.Location = new System.Drawing.Point(763, 85);
            this.picStEdStudentPicture.Name = "picStEdStudentPicture";
            this.picStEdStudentPicture.Size = new System.Drawing.Size(180, 136);
            this.picStEdStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStEdStudentPicture.TabIndex = 2;
            this.picStEdStudentPicture.TabStop = false;
            // 
            // btnStEdUploadPicture
            // 
            this.btnStEdUploadPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStEdUploadPicture.Location = new System.Drawing.Point(783, 251);
            this.btnStEdUploadPicture.Name = "btnStEdUploadPicture";
            this.btnStEdUploadPicture.Size = new System.Drawing.Size(130, 23);
            this.btnStEdUploadPicture.TabIndex = 3;
            this.btnStEdUploadPicture.Text = "Upload PIcture";
            this.btnStEdUploadPicture.UseVisualStyleBackColor = true;
            this.btnStEdUploadPicture.Click += new System.EventHandler(this.btnStEdUploadPicture_Click);
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnStEdUploadPicture);
            this.Controls.Add(this.picStEdStudentPicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbStudentEdit);
            this.Name = "StudentEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentEditform";
            this.grbStudentEdit.ResumeLayout(false);
            this.grbStudentEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStEdStudentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudentEdit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbMyBio;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMyTeacher;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSEDPayment;
        private System.Windows.Forms.Button btnSEDNotifications;
        private System.Windows.Forms.Button btnSEDMyTeacher;
        private System.Windows.Forms.Button btnSEDDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSEDMyInfo;
        private System.Windows.Forms.Label lblStEdWelcome;
        private System.Windows.Forms.PictureBox picStEdStudentPicture;
        private System.Windows.Forms.Button btnStEdUploadPicture;
    }
}