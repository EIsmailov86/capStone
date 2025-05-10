namespace JEM
{
    partial class RegisterTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterTeacherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pibReStPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReTeWelcome = new System.Windows.Forms.Label();
            this.btnReTeRegister = new System.Windows.Forms.Button();
            this.txtReTeConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblReTeConfirmPassword = new System.Windows.Forms.Label();
            this.lblReTePassword = new System.Windows.Forms.Label();
            this.lblReTeUserName = new System.Windows.Forms.Label();
            this.lblReTeAddress = new System.Windows.Forms.Label();
            this.lblReTePhone = new System.Windows.Forms.Label();
            this.lblReTeEmail = new System.Windows.Forms.Label();
            this.lblReTeName = new System.Windows.Forms.Label();
            this.txtReTePassword = new System.Windows.Forms.TextBox();
            this.txtReTeUsername = new System.Windows.Forms.TextBox();
            this.txtReTeAddress = new System.Windows.Forms.TextBox();
            this.txtReTePhone = new System.Windows.Forms.TextBox();
            this.txtReTeEmail = new System.Windows.Forms.TextBox();
            this.txtReTeName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReStPicture)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 11;
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
            this.panel2.TabIndex = 12;
            // 
            // lblReTeWelcome
            // 
            this.lblReTeWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTeWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblReTeWelcome.Location = new System.Drawing.Point(243, 8);
            this.lblReTeWelcome.Name = "lblReTeWelcome";
            this.lblReTeWelcome.Size = new System.Drawing.Size(243, 23);
            this.lblReTeWelcome.TabIndex = 23;
            this.lblReTeWelcome.Text = "Welcome To The Team.";
            // 
            // btnReTeRegister
            // 
            this.btnReTeRegister.BackColor = System.Drawing.Color.MintCream;
            this.btnReTeRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReTeRegister.Location = new System.Drawing.Point(296, 311);
            this.btnReTeRegister.Name = "btnReTeRegister";
            this.btnReTeRegister.Size = new System.Drawing.Size(219, 41);
            this.btnReTeRegister.TabIndex = 58;
            this.btnReTeRegister.Text = "Register Teacher";
            this.btnReTeRegister.UseVisualStyleBackColor = false;
            this.btnReTeRegister.Click += new System.EventHandler(this.btnReTeRegister_Click);
            // 
            // txtReTeConfirmPassword
            // 
            this.txtReTeConfirmPassword.Location = new System.Drawing.Point(434, 264);
            this.txtReTeConfirmPassword.Name = "txtReTeConfirmPassword";
            this.txtReTeConfirmPassword.Size = new System.Drawing.Size(140, 22);
            this.txtReTeConfirmPassword.TabIndex = 57;
            // 
            // lblReTeConfirmPassword
            // 
            this.lblReTeConfirmPassword.AutoSize = true;
            this.lblReTeConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTeConfirmPassword.Location = new System.Drawing.Point(227, 262);
            this.lblReTeConfirmPassword.Name = "lblReTeConfirmPassword";
            this.lblReTeConfirmPassword.Size = new System.Drawing.Size(158, 22);
            this.lblReTeConfirmPassword.TabIndex = 56;
            this.lblReTeConfirmPassword.Text = "Confirm Password";
            // 
            // lblReTePassword
            // 
            this.lblReTePassword.AutoSize = true;
            this.lblReTePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTePassword.Location = new System.Drawing.Point(227, 235);
            this.lblReTePassword.Name = "lblReTePassword";
            this.lblReTePassword.Size = new System.Drawing.Size(88, 22);
            this.lblReTePassword.TabIndex = 55;
            this.lblReTePassword.Text = "Password";
            // 
            // lblReTeUserName
            // 
            this.lblReTeUserName.AutoSize = true;
            this.lblReTeUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTeUserName.Location = new System.Drawing.Point(227, 208);
            this.lblReTeUserName.Name = "lblReTeUserName";
            this.lblReTeUserName.Size = new System.Drawing.Size(98, 22);
            this.lblReTeUserName.TabIndex = 54;
            this.lblReTeUserName.Text = "User Name";
            // 
            // lblReTeAddress
            // 
            this.lblReTeAddress.AutoSize = true;
            this.lblReTeAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTeAddress.Location = new System.Drawing.Point(227, 181);
            this.lblReTeAddress.Name = "lblReTeAddress";
            this.lblReTeAddress.Size = new System.Drawing.Size(76, 22);
            this.lblReTeAddress.TabIndex = 53;
            this.lblReTeAddress.Text = "Address";
            // 
            // lblReTePhone
            // 
            this.lblReTePhone.AutoSize = true;
            this.lblReTePhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTePhone.Location = new System.Drawing.Point(227, 153);
            this.lblReTePhone.Name = "lblReTePhone";
            this.lblReTePhone.Size = new System.Drawing.Size(58, 22);
            this.lblReTePhone.TabIndex = 52;
            this.lblReTePhone.Text = "Phone";
            // 
            // lblReTeEmail
            // 
            this.lblReTeEmail.AutoSize = true;
            this.lblReTeEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTeEmail.Location = new System.Drawing.Point(227, 126);
            this.lblReTeEmail.Name = "lblReTeEmail";
            this.lblReTeEmail.Size = new System.Drawing.Size(57, 22);
            this.lblReTeEmail.TabIndex = 51;
            this.lblReTeEmail.Text = "Email";
            // 
            // lblReTeName
            // 
            this.lblReTeName.AutoSize = true;
            this.lblReTeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTeName.Location = new System.Drawing.Point(227, 99);
            this.lblReTeName.Name = "lblReTeName";
            this.lblReTeName.Size = new System.Drawing.Size(56, 22);
            this.lblReTeName.TabIndex = 50;
            this.lblReTeName.Text = "Name";
            // 
            // txtReTePassword
            // 
            this.txtReTePassword.Location = new System.Drawing.Point(434, 237);
            this.txtReTePassword.Name = "txtReTePassword";
            this.txtReTePassword.Size = new System.Drawing.Size(140, 22);
            this.txtReTePassword.TabIndex = 49;
            this.txtReTePassword.TextChanged += new System.EventHandler(this.txtReTePassword_TextChanged);
            // 
            // txtReTeUsername
            // 
            this.txtReTeUsername.Location = new System.Drawing.Point(434, 209);
            this.txtReTeUsername.Name = "txtReTeUsername";
            this.txtReTeUsername.Size = new System.Drawing.Size(140, 22);
            this.txtReTeUsername.TabIndex = 48;
            this.txtReTeUsername.TextChanged += new System.EventHandler(this.txtReTeUsername_TextChanged);
            // 
            // txtReTeAddress
            // 
            this.txtReTeAddress.Location = new System.Drawing.Point(434, 182);
            this.txtReTeAddress.Name = "txtReTeAddress";
            this.txtReTeAddress.Size = new System.Drawing.Size(140, 22);
            this.txtReTeAddress.TabIndex = 47;
            // 
            // txtReTePhone
            // 
            this.txtReTePhone.Location = new System.Drawing.Point(434, 155);
            this.txtReTePhone.Name = "txtReTePhone";
            this.txtReTePhone.Size = new System.Drawing.Size(140, 22);
            this.txtReTePhone.TabIndex = 46;
            // 
            // txtReTeEmail
            // 
            this.txtReTeEmail.Location = new System.Drawing.Point(434, 128);
            this.txtReTeEmail.Name = "txtReTeEmail";
            this.txtReTeEmail.Size = new System.Drawing.Size(140, 22);
            this.txtReTeEmail.TabIndex = 45;
            // 
            // txtReTeName
            // 
            this.txtReTeName.Location = new System.Drawing.Point(434, 101);
            this.txtReTeName.Name = "txtReTeName";
            this.txtReTeName.Size = new System.Drawing.Size(140, 22);
            this.txtReTeName.TabIndex = 44;
            // 
            // RegisterTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReTeRegister);
            this.Controls.Add(this.txtReTeConfirmPassword);
            this.Controls.Add(this.lblReTeConfirmPassword);
            this.Controls.Add(this.lblReTePassword);
            this.Controls.Add(this.lblReTeUserName);
            this.Controls.Add(this.lblReTeAddress);
            this.Controls.Add(this.lblReTePhone);
            this.Controls.Add(this.lblReTeEmail);
            this.Controls.Add(this.lblReTeName);
            this.Controls.Add(this.txtReTePassword);
            this.Controls.Add(this.txtReTeUsername);
            this.Controls.Add(this.txtReTeAddress);
            this.Controls.Add(this.txtReTePhone);
            this.Controls.Add(this.txtReTeEmail);
            this.Controls.Add(this.txtReTeName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterTeacherForm";
            this.Text = "RegisterTeacherForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReStPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pibReStPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReTeWelcome;
        private System.Windows.Forms.Button btnReTeRegister;
        private System.Windows.Forms.TextBox txtReTeConfirmPassword;
        private System.Windows.Forms.Label lblReTeConfirmPassword;
        private System.Windows.Forms.Label lblReTePassword;
        private System.Windows.Forms.Label lblReTeUserName;
        private System.Windows.Forms.Label lblReTeAddress;
        private System.Windows.Forms.Label lblReTePhone;
        private System.Windows.Forms.Label lblReTeEmail;
        private System.Windows.Forms.Label lblReTeName;
        private System.Windows.Forms.TextBox txtReTePassword;
        private System.Windows.Forms.TextBox txtReTeUsername;
        private System.Windows.Forms.TextBox txtReTeAddress;
        private System.Windows.Forms.TextBox txtReTePhone;
        private System.Windows.Forms.TextBox txtReTeEmail;
        private System.Windows.Forms.TextBox txtReTeName;
    }
}