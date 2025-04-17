namespace JEM
{
    partial class StudentExtraForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.rbtCreditCard = new System.Windows.Forms.RadioButton();
            this.rbtCheckingAccount = new System.Windows.Forms.RadioButton();
            this.rbtPaypal = new System.Windows.Forms.RadioButton();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lblAgreewithTerms = new System.Windows.Forms.Label();
            this.rbtAgree = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 31);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 127);
            this.panel3.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(164, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 389);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notifications";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Heading";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 199);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtAgree);
            this.groupBox2.Controls.Add(this.lblAgreewithTerms);
            this.groupBox2.Controls.Add(this.txbAmount);
            this.groupBox2.Controls.Add(this.rbtPaypal);
            this.groupBox2.Controls.Add(this.rbtCheckingAccount);
            this.groupBox2.Controls.Add(this.rbtCreditCard);
            this.groupBox2.Controls.Add(this.cmbPay);
            this.groupBox2.Location = new System.Drawing.Point(601, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 389);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cmbPay
            // 
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Location = new System.Drawing.Point(62, 68);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(198, 24);
            this.cmbPay.TabIndex = 4;
            this.cmbPay.Text = "Pay for Class OR Semester";
            // 
            // rbtCreditCard
            // 
            this.rbtCreditCard.AutoSize = true;
            this.rbtCreditCard.Location = new System.Drawing.Point(23, 129);
            this.rbtCreditCard.Name = "rbtCreditCard";
            this.rbtCreditCard.Size = new System.Drawing.Size(95, 20);
            this.rbtCreditCard.TabIndex = 5;
            this.rbtCreditCard.TabStop = true;
            this.rbtCreditCard.Text = "Credit Card";
            this.rbtCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtCheckingAccount
            // 
            this.rbtCheckingAccount.AutoSize = true;
            this.rbtCheckingAccount.Location = new System.Drawing.Point(23, 175);
            this.rbtCheckingAccount.Name = "rbtCheckingAccount";
            this.rbtCheckingAccount.Size = new System.Drawing.Size(135, 20);
            this.rbtCheckingAccount.TabIndex = 6;
            this.rbtCheckingAccount.TabStop = true;
            this.rbtCheckingAccount.Text = "Checking Account";
            this.rbtCheckingAccount.UseVisualStyleBackColor = true;
            // 
            // rbtPaypal
            // 
            this.rbtPaypal.AutoSize = true;
            this.rbtPaypal.Location = new System.Drawing.Point(23, 223);
            this.rbtPaypal.Name = "rbtPaypal";
            this.rbtPaypal.Size = new System.Drawing.Size(71, 20);
            this.rbtPaypal.TabIndex = 7;
            this.rbtPaypal.TabStop = true;
            this.rbtPaypal.Text = "Paypal";
            this.rbtPaypal.UseVisualStyleBackColor = true;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(23, 265);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(100, 22);
            this.txbAmount.TabIndex = 8;
            this.txbAmount.Text = "Amount";
            // 
            // lblAgreewithTerms
            // 
            this.lblAgreewithTerms.AutoSize = true;
            this.lblAgreewithTerms.Location = new System.Drawing.Point(23, 312);
            this.lblAgreewithTerms.Name = "lblAgreewithTerms";
            this.lblAgreewithTerms.Size = new System.Drawing.Size(132, 16);
            this.lblAgreewithTerms.TabIndex = 9;
            this.lblAgreewithTerms.Text = "Agree with the Terms";
            // 
            // rbtAgree
            // 
            this.rbtAgree.AutoSize = true;
            this.rbtAgree.Location = new System.Drawing.Point(189, 308);
            this.rbtAgree.Name = "rbtAgree";
            this.rbtAgree.Size = new System.Drawing.Size(65, 20);
            this.rbtAgree.TabIndex = 10;
            this.rbtAgree.TabStop = true;
            this.rbtAgree.Text = "Agree";
            this.rbtAgree.UseVisualStyleBackColor = true;
            // 
            // StudentExtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentExtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentExtraForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.Label lblAgreewithTerms;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.RadioButton rbtPaypal;
        private System.Windows.Forms.RadioButton rbtCheckingAccount;
        private System.Windows.Forms.RadioButton rbtCreditCard;
        private System.Windows.Forms.RadioButton rbtAgree;
    }
}