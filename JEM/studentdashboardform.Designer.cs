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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblJEM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnMyTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grbScheduleApp.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
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
            this.grbScheduleApp.Location = new System.Drawing.Point(180, 331);
            this.grbScheduleApp.Name = "grbScheduleApp";
            this.grbScheduleApp.Size = new System.Drawing.Size(359, 301);
            this.grbScheduleApp.TabIndex = 10;
            this.grbScheduleApp.TabStop = false;
            this.grbScheduleApp.Text = "Schedule Appointment";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(135, 653);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMyTeacher);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.picUser);
            this.panel2.Controls.Add(this.btnMyInfo);
            this.panel2.Controls.Add(this.lblJEM);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 390);
            this.panel2.TabIndex = 0;
            // 
            // lblJEM
            // 
            this.lblJEM.AutoSize = true;
            this.lblJEM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblJEM.Location = new System.Drawing.Point(40, 87);
            this.lblJEM.Name = "lblJEM";
            this.lblJEM.Size = new System.Drawing.Size(45, 19);
            this.lblJEM.TabIndex = 2;
            this.lblJEM.Text = "JEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(135, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Location = new System.Drawing.Point(9, 161);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(114, 42);
            this.btnMyInfo.TabIndex = 15;
            this.btnMyInfo.Text = "My Info";
            this.btnMyInfo.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(9, 231);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(114, 69);
            this.btnPayment.TabIndex = 16;
            this.btnPayment.Text = "Payment/\r\nNotifications";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // picUser
            // 
            this.picUser.Image = global::JEM.Properties.Resources.user;
            this.picUser.Location = new System.Drawing.Point(33, 21);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(63, 63);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 15;
            this.picUser.TabStop = false;
            // 
            // btnMyTeacher
            // 
            this.btnMyTeacher.Location = new System.Drawing.Point(9, 328);
            this.btnMyTeacher.Name = "btnMyTeacher";
            this.btnMyTeacher.Size = new System.Drawing.Size(114, 42);
            this.btnMyTeacher.TabIndex = 17;
            this.btnMyTeacher.Text = "My Teacher";
            this.btnMyTeacher.UseVisualStyleBackColor = true;
            // 
            // studentdashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grbScheduleApp);
            this.Controls.Add(this.dgvSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "studentdashboardform";
            this.Text = "studentdashboardform";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grbScheduleApp.ResumeLayout(false);
            this.grbScheduleApp.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblJEM;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnMyTeacher;
    }
}