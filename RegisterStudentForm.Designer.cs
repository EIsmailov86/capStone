namespace JEM
{
    partial class RegisterStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pibReStPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReTeWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReStRegister = new System.Windows.Forms.Button();
            this.txtReStConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblReStConfirmPassword = new System.Windows.Forms.Label();
            this.lblReStPassword = new System.Windows.Forms.Label();
            this.lblReStUserName = new System.Windows.Forms.Label();
            this.lblReStAddress = new System.Windows.Forms.Label();
            this.lblReStPhone = new System.Windows.Forms.Label();
            this.lblReStEmail = new System.Windows.Forms.Label();
            this.lblReStName = new System.Windows.Forms.Label();
            this.txtReStPassword = new System.Windows.Forms.TextBox();
            this.txtReStUsername = new System.Windows.Forms.TextBox();
            this.txtReStAddress = new System.Windows.Forms.TextBox();
            this.txtReStPhone = new System.Windows.Forms.TextBox();
            this.txtReStEmail = new System.Windows.Forms.TextBox();
            this.txtReStName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReStPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 450);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pibReStPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 128);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(43, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "JEM";
            // 
            // pibReStPicture
            // 
            this.pibReStPicture.Image = ((System.Drawing.Image)(resources.GetObject("pibReStPicture.Image")));
            this.pibReStPicture.Location = new System.Drawing.Point(35, 26);
            this.pibReStPicture.Name = "pibReStPicture";
            this.pibReStPicture.Size = new System.Drawing.Size(63, 63);
            this.pibReStPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibReStPicture.TabIndex = 0;
            this.pibReStPicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblReTeWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 31);
            this.panel2.TabIndex = 11;
            // 
            // lblReTeWelcome
            // 
            this.lblReTeWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTeWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblReTeWelcome.Location = new System.Drawing.Point(243, 8);
            this.lblReTeWelcome.Name = "lblReTeWelcome";
            this.lblReTeWelcome.Size = new System.Drawing.Size(345, 23);
            this.lblReTeWelcome.TabIndex = 23;
            this.lblReTeWelcome.Text = "Welcome Dear Student.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnReStRegister);
            this.groupBox1.Controls.Add(this.txtReStConfirmPassword);
            this.groupBox1.Controls.Add(this.lblReStConfirmPassword);
            this.groupBox1.Controls.Add(this.lblReStPassword);
            this.groupBox1.Controls.Add(this.lblReStUserName);
            this.groupBox1.Controls.Add(this.lblReStAddress);
            this.groupBox1.Controls.Add(this.lblReStPhone);
            this.groupBox1.Controls.Add(this.lblReStEmail);
            this.groupBox1.Controls.Add(this.lblReStName);
            this.groupBox1.Controls.Add(this.txtReStPassword);
            this.groupBox1.Controls.Add(this.txtReStUsername);
            this.groupBox1.Controls.Add(this.txtReStAddress);
            this.groupBox1.Controls.Add(this.txtReStPhone);
            this.groupBox1.Controls.Add(this.txtReStEmail);
            this.groupBox1.Controls.Add(this.txtReStName);
            this.groupBox1.Location = new System.Drawing.Point(184, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 336);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // btnReStRegister
            // 
            this.btnReStRegister.BackColor = System.Drawing.Color.MintCream;
            this.btnReStRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReStRegister.Location = new System.Drawing.Point(165, 254);
            this.btnReStRegister.Name = "btnReStRegister";
            this.btnReStRegister.Size = new System.Drawing.Size(156, 41);
            this.btnReStRegister.TabIndex = 58;
            this.btnReStRegister.Text = "Register";
            this.btnReStRegister.UseVisualStyleBackColor = false;
            this.btnReStRegister.Click += new System.EventHandler(this.btnReStRegister_Click);
            // 
            // txtReStConfirmPassword
            // 
            this.txtReStConfirmPassword.Location = new System.Drawing.Point(303, 207);
            this.txtReStConfirmPassword.Name = "txtReStConfirmPassword";
            this.txtReStConfirmPassword.Size = new System.Drawing.Size(140, 22);
            this.txtReStConfirmPassword.TabIndex = 57;
            // 
            // lblReStConfirmPassword
            // 
            this.lblReStConfirmPassword.AutoSize = true;
            this.lblReStConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReStConfirmPassword.Location = new System.Drawing.Point(96, 205);
            this.lblReStConfirmPassword.Name = "lblReStConfirmPassword";
            this.lblReStConfirmPassword.Size = new System.Drawing.Size(158, 22);
            this.lblReStConfirmPassword.TabIndex = 56;
            this.lblReStConfirmPassword.Text = "Confirm Password";
            // 
            // lblReStPassword
            // 
            this.lblReStPassword.AutoSize = true;
            this.lblReStPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReStPassword.Location = new System.Drawing.Point(96, 178);
            this.lblReStPassword.Name = "lblReStPassword";
            this.lblReStPassword.Size = new System.Drawing.Size(88, 22);
            this.lblReStPassword.TabIndex = 55;
            this.lblReStPassword.Text = "Password";
            // 
            // lblReStUserName
            // 
            this.lblReStUserName.AutoSize = true;
            this.lblReStUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReStUserName.Location = new System.Drawing.Point(96, 151);
            this.lblReStUserName.Name = "lblReStUserName";
            this.lblReStUserName.Size = new System.Drawing.Size(98, 22);
            this.lblReStUserName.TabIndex = 54;
            this.lblReStUserName.Text = "User Name";
            // 
            // lblReStAddress
            // 
            this.lblReStAddress.AutoSize = true;
            this.lblReStAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReStAddress.Location = new System.Drawing.Point(96, 124);
            this.lblReStAddress.Name = "lblReStAddress";
            this.lblReStAddress.Size = new System.Drawing.Size(76, 22);
            this.lblReStAddress.TabIndex = 53;
            this.lblReStAddress.Text = "Address";
            // 
            // lblReStPhone
            // 
            this.lblReStPhone.AutoSize = true;
            this.lblReStPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReStPhone.Location = new System.Drawing.Point(96, 96);
            this.lblReStPhone.Name = "lblReStPhone";
            this.lblReStPhone.Size = new System.Drawing.Size(58, 22);
            this.lblReStPhone.TabIndex = 52;
            this.lblReStPhone.Text = "Phone";
            // 
            // lblReStEmail
            // 
            this.lblReStEmail.AutoSize = true;
            this.lblReStEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReStEmail.Location = new System.Drawing.Point(96, 69);
            this.lblReStEmail.Name = "lblReStEmail";
            this.lblReStEmail.Size = new System.Drawing.Size(57, 22);
            this.lblReStEmail.TabIndex = 51;
            this.lblReStEmail.Text = "Email";
            // 
            // lblReStName
            // 
            this.lblReStName.AutoSize = true;
            this.lblReStName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReStName.Location = new System.Drawing.Point(96, 42);
            this.lblReStName.Name = "lblReStName";
            this.lblReStName.Size = new System.Drawing.Size(56, 22);
            this.lblReStName.TabIndex = 50;
            this.lblReStName.Text = "Name";
            // 
            // txtReStPassword
            // 
            this.txtReStPassword.Location = new System.Drawing.Point(303, 180);
            this.txtReStPassword.Name = "txtReStPassword";
            this.txtReStPassword.Size = new System.Drawing.Size(140, 22);
            this.txtReStPassword.TabIndex = 49;
            // 
            // txtReStUsername
            // 
            this.txtReStUsername.Location = new System.Drawing.Point(303, 152);
            this.txtReStUsername.Name = "txtReStUsername";
            this.txtReStUsername.Size = new System.Drawing.Size(140, 22);
            this.txtReStUsername.TabIndex = 48;
            // 
            // txtReStAddress
            // 
            this.txtReStAddress.Location = new System.Drawing.Point(303, 125);
            this.txtReStAddress.Name = "txtReStAddress";
            this.txtReStAddress.Size = new System.Drawing.Size(140, 22);
            this.txtReStAddress.TabIndex = 47;
            // 
            // txtReStPhone
            // 
            this.txtReStPhone.Location = new System.Drawing.Point(303, 98);
            this.txtReStPhone.Name = "txtReStPhone";
            this.txtReStPhone.Size = new System.Drawing.Size(140, 22);
            this.txtReStPhone.TabIndex = 46;
            // 
            // txtReStEmail
            // 
            this.txtReStEmail.Location = new System.Drawing.Point(303, 71);
            this.txtReStEmail.Name = "txtReStEmail";
            this.txtReStEmail.Size = new System.Drawing.Size(140, 22);
            this.txtReStEmail.TabIndex = 45;
            // 
            // txtReStName
            // 
            this.txtReStName.Location = new System.Drawing.Point(303, 44);
            this.txtReStName.Name = "txtReStName";
            this.txtReStName.Size = new System.Drawing.Size(140, 22);
            this.txtReStName.TabIndex = 44;
            // 
            // RegisterStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterStudentForm";
            this.Text = "RegisterStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReStPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pibReStPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReTeWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReStRegister;
        private System.Windows.Forms.TextBox txtReStConfirmPassword;
        private System.Windows.Forms.Label lblReStConfirmPassword;
        private System.Windows.Forms.Label lblReStPassword;
        private System.Windows.Forms.Label lblReStUserName;
        private System.Windows.Forms.Label lblReStAddress;
        private System.Windows.Forms.Label lblReStPhone;
        private System.Windows.Forms.Label lblReStEmail;
        private System.Windows.Forms.Label lblReStName;
        private System.Windows.Forms.TextBox txtReStPassword;
        private System.Windows.Forms.TextBox txtReStUsername;
        private System.Windows.Forms.TextBox txtReStAddress;
        private System.Windows.Forms.TextBox txtReStPhone;
        private System.Windows.Forms.TextBox txtReStEmail;
        private System.Windows.Forms.TextBox txtReStName;
    }
}