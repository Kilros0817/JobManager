namespace JobManager
{
    partial class JobForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.jobName = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.srcBro = new System.Windows.Forms.Button();
            this.desBro = new System.Windows.Forms.Button();
            this.destPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCopy = new System.Windows.Forms.RadioButton();
            this.radioMove = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.extension = new System.Windows.Forms.TextBox();
            this.isSFTP = new System.Windows.Forms.CheckBox();
            this.sftpGB = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sftpUsername = new System.Windows.Forms.TextBox();
            this.sftpPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.sftpGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "JobName";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(217, 26);
            this.jobName.Margin = new System.Windows.Forms.Padding(4);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(132, 22);
            this.jobName.TabIndex = 1;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(51, 66);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(51, 16);
            this.la.TabIndex = 2;
            this.la.Text = "Source";
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(54, 86);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(272, 22);
            this.sourcePath.TabIndex = 3;
            // 
            // srcBro
            // 
            this.srcBro.Location = new System.Drawing.Point(404, 86);
            this.srcBro.Name = "srcBro";
            this.srcBro.Size = new System.Drawing.Size(51, 23);
            this.srcBro.TabIndex = 5;
            this.srcBro.Text = "open";
            this.srcBro.UseVisualStyleBackColor = true;
            this.srcBro.Click += new System.EventHandler(this.srcBro_Click);
            // 
            // desBro
            // 
            this.desBro.Location = new System.Drawing.Point(404, 140);
            this.desBro.Name = "desBro";
            this.desBro.Size = new System.Drawing.Size(51, 23);
            this.desBro.TabIndex = 7;
            this.desBro.Text = "open";
            this.desBro.UseVisualStyleBackColor = true;
            this.desBro.Click += new System.EventHandler(this.desBro_Click);
            // 
            // destPath
            // 
            this.destPath.Location = new System.Drawing.Point(54, 140);
            this.destPath.Name = "destPath";
            this.destPath.Size = new System.Drawing.Size(337, 22);
            this.destPath.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Schedule";
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(90, 317);
            this.schedule.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(120, 22);
            this.schedule.TabIndex = 9;
            this.schedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.schedule.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "s";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCopy);
            this.groupBox1.Controls.Add(this.radioMove);
            this.groupBox1.Location = new System.Drawing.Point(270, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // radioCopy
            // 
            this.radioCopy.AutoSize = true;
            this.radioCopy.Checked = true;
            this.radioCopy.Location = new System.Drawing.Point(104, 27);
            this.radioCopy.Name = "radioCopy";
            this.radioCopy.Size = new System.Drawing.Size(58, 20);
            this.radioCopy.TabIndex = 1;
            this.radioCopy.TabStop = true;
            this.radioCopy.Text = "Copy";
            this.radioCopy.UseVisualStyleBackColor = true;
            // 
            // radioMove
            // 
            this.radioMove.AutoSize = true;
            this.radioMove.Location = new System.Drawing.Point(20, 27);
            this.radioMove.Name = "radioMove";
            this.radioMove.Size = new System.Drawing.Size(60, 20);
            this.radioMove.TabIndex = 0;
            this.radioMove.Text = "Move";
            this.radioMove.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(290, 380);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // extension
            // 
            this.extension.Location = new System.Drawing.Point(333, 86);
            this.extension.Margin = new System.Windows.Forms.Padding(4);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(58, 22);
            this.extension.TabIndex = 4;
            this.extension.Text = "*.*";
            this.extension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // isSFTP
            // 
            this.isSFTP.AutoSize = true;
            this.isSFTP.Location = new System.Drawing.Point(54, 216);
            this.isSFTP.Name = "isSFTP";
            this.isSFTP.Size = new System.Drawing.Size(62, 20);
            this.isSFTP.TabIndex = 16;
            this.isSFTP.Text = "SFTP";
            this.isSFTP.UseVisualStyleBackColor = true;
            this.isSFTP.CheckedChanged += new System.EventHandler(this.isSFTP_CheckedChanged);
            // 
            // sftpGB
            // 
            this.sftpGB.Controls.Add(this.sftpPwd);
            this.sftpGB.Controls.Add(this.label6);
            this.sftpGB.Controls.Add(this.sftpUsername);
            this.sftpGB.Controls.Add(this.label5);
            this.sftpGB.Enabled = false;
            this.sftpGB.Location = new System.Drawing.Point(122, 180);
            this.sftpGB.Name = "sftpGB";
            this.sftpGB.Size = new System.Drawing.Size(333, 87);
            this.sftpGB.TabIndex = 17;
            this.sftpGB.TabStop = false;
            this.sftpGB.Text = "SFTP Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "UserName";
            // 
            // sftpUsername
            // 
            this.sftpUsername.Location = new System.Drawing.Point(20, 52);
            this.sftpUsername.Name = "sftpUsername";
            this.sftpUsername.Size = new System.Drawing.Size(126, 22);
            this.sftpUsername.TabIndex = 19;
            // 
            // sftpPwd
            // 
            this.sftpPwd.Location = new System.Drawing.Point(184, 52);
            this.sftpPwd.Name = "sftpPwd";
            this.sftpPwd.Size = new System.Drawing.Size(126, 22);
            this.sftpPwd.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password";
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 429);
            this.Controls.Add(this.sftpGB);
            this.Controls.Add(this.isSFTP);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desBro);
            this.Controls.Add(this.destPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.srcBro);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.la);
            this.Controls.Add(this.jobName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 299);
            this.Name = "JobForm";
            this.Text = "JobForm";
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sftpGB.ResumeLayout(false);
            this.sftpGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jobName;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.Button srcBro;
        private System.Windows.Forms.Button desBro;
        private System.Windows.Forms.TextBox destPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown schedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCopy;
        private System.Windows.Forms.RadioButton radioMove;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox extension;
        private System.Windows.Forms.CheckBox isSFTP;
        private System.Windows.Forms.GroupBox sftpGB;
        private System.Windows.Forms.TextBox sftpPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sftpUsername;
        private System.Windows.Forms.Label label5;
    }
}