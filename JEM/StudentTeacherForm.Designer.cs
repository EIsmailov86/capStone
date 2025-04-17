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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txbInfoandBio = new System.Windows.Forms.TextBox();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.txbMessageTeacher = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnMyTeacher = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 653);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMyTeacher);
            this.panel3.Controls.Add(this.btnPayment);
            this.panel3.Controls.Add(this.btnDashboard);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 385);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendMessage);
            this.groupBox2.Controls.Add(this.txbMessageTeacher);
            this.groupBox2.Controls.Add(this.picTeacher);
            this.groupBox2.Controls.Add(this.txbInfoandBio);
            this.groupBox2.Controls.Add(this.cmbSubject);
            this.groupBox2.Location = new System.Drawing.Point(232, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 500);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            // txbInfoandBio
            // 
            this.txbInfoandBio.Location = new System.Drawing.Point(38, 103);
            this.txbInfoandBio.Multiline = true;
            this.txbInfoandBio.Name = "txbInfoandBio";
            this.txbInfoandBio.Size = new System.Drawing.Size(201, 338);
            this.txbInfoandBio.TabIndex = 5;
            this.txbInfoandBio.Text = "Teacher\'s Info and Bio";
            // 
            // picTeacher
            // 
            this.picTeacher.Location = new System.Drawing.Point(352, 47);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(173, 157);
            this.picTeacher.TabIndex = 6;
            this.picTeacher.TabStop = false;
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
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(301, 418);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(274, 23);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // btnMyTeacher
            // 
            this.btnMyTeacher.Location = new System.Drawing.Point(9, 237);
            this.btnMyTeacher.Name = "btnMyTeacher";
            this.btnMyTeacher.Size = new System.Drawing.Size(114, 42);
            this.btnMyTeacher.TabIndex = 23;
            this.btnMyTeacher.Text = "My Teacher";
            this.btnMyTeacher.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(9, 296);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(114, 69);
            this.btnPayment.TabIndex = 22;
            this.btnPayment.Text = "Payment/\r\nNotifications";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(9, 161);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(114, 42);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // StudentTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentTeacherForm";
            this.Text = "StudentTeacherForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txbInfoandBio;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txbMessageTeacher;
        private System.Windows.Forms.Button btnMyTeacher;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnDashboard;
    }
}