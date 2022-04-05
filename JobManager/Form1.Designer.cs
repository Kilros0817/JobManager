using JobManager.utility;
namespace JobManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.jobcheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.src = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new JobManager.utility.DataGridViewDisableButtonColumn();
            this.start = new JobManager.utility.DataGridViewDisableButtonColumn();
            this.stop = new JobManager.utility.DataGridViewDisableButtonColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addJob = new System.Windows.Forms.Button();
            this.delJob = new System.Windows.Forms.Button();
            this.dataGridViewDisableButtonColumn1 = new JobManager.utility.DataGridViewDisableButtonColumn();
            this.dataGridViewDisableButtonColumn2 = new JobManager.utility.DataGridViewDisableButtonColumn();
            this.dataGridViewDisableButtonColumn3 = new JobManager.utility.DataGridViewDisableButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobcheck,
            this.number,
            this.name,
            this.src,
            this.extension,
            this.dest,
            this.sch,
            this.func,
            this.status,
            this.edit,
            this.start,
            this.stop});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView.Size = new System.Drawing.Size(1032, 511);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // jobcheck
            // 
            this.jobcheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jobcheck.FillWeight = 102.9295F;
            this.jobcheck.HeaderText = "";
            this.jobcheck.MinimumWidth = 20;
            this.jobcheck.Name = "jobcheck";
            this.jobcheck.Width = 25;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.number.FillWeight = 99.27771F;
            this.number.HeaderText = "No";
            this.number.MinimumWidth = 25;
            this.number.Name = "number";
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number.Width = 30;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 177.1058F;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 40;
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // src
            // 
            this.src.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.src.FillWeight = 95.5068F;
            this.src.HeaderText = "Source";
            this.src.MinimumWidth = 200;
            this.src.Name = "src";
            // 
            // extension
            // 
            this.extension.HeaderText = "Extension";
            this.extension.MinimumWidth = 40;
            this.extension.Name = "extension";
            // 
            // dest
            // 
            this.dest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dest.FillWeight = 283.5897F;
            this.dest.HeaderText = "Destination";
            this.dest.MinimumWidth = 190;
            this.dest.Name = "dest";
            // 
            // sch
            // 
            this.sch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sch.FillWeight = 10.53533F;
            this.sch.HeaderText = "Schedule";
            this.sch.MinimumWidth = 70;
            this.sch.Name = "sch";
            // 
            // func
            // 
            this.func.HeaderText = "Function";
            this.func.MinimumWidth = 60;
            this.func.Name = "func";
            this.func.Width = 60;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.FillWeight = 9.203326F;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 60;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.edit.FillWeight = 8.508348F;
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 60;
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            // 
            // start
            // 
            this.start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start.HeaderText = "Start";
            this.start.MinimumWidth = 60;
            this.start.Name = "start";
            // 
            // stop
            // 
            this.stop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stop.HeaderText = "Stop";
            this.stop.MinimumWidth = 60;
            this.stop.Name = "stop";
            this.stop.ReadOnly = true;
            this.stop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 567);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.624549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.37545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 720F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.addJob, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.delJob, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addJob
            // 
            this.addJob.Location = new System.Drawing.Point(5, 14);
            this.addJob.Margin = new System.Windows.Forms.Padding(4);
            this.addJob.Name = "addJob";
            this.addJob.Size = new System.Drawing.Size(85, 33);
            this.addJob.TabIndex = 0;
            this.addJob.Text = "New";
            this.addJob.UseVisualStyleBackColor = true;
            this.addJob.Click += new System.EventHandler(this.addJob_Click);
            // 
            // delJob
            // 
            this.delJob.Location = new System.Drawing.Point(103, 14);
            this.delJob.Margin = new System.Windows.Forms.Padding(4);
            this.delJob.Name = "delJob";
            this.delJob.Size = new System.Drawing.Size(85, 33);
            this.delJob.TabIndex = 1;
            this.delJob.Text = "Delete";
            this.delJob.UseVisualStyleBackColor = true;
            this.delJob.Click += new System.EventHandler(this.delJob_Click);
            // 
            // dataGridViewDisableButtonColumn1
            // 
            this.dataGridViewDisableButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewDisableButtonColumn1.FillWeight = 8.508348F;
            this.dataGridViewDisableButtonColumn1.HeaderText = "Edit";
            this.dataGridViewDisableButtonColumn1.MinimumWidth = 60;
            this.dataGridViewDisableButtonColumn1.Name = "dataGridViewDisableButtonColumn1";
            this.dataGridViewDisableButtonColumn1.Text = "Edit";
            // 
            // dataGridViewDisableButtonColumn2
            // 
            this.dataGridViewDisableButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewDisableButtonColumn2.HeaderText = "Start";
            this.dataGridViewDisableButtonColumn2.MinimumWidth = 60;
            this.dataGridViewDisableButtonColumn2.Name = "dataGridViewDisableButtonColumn2";
            // 
            // dataGridViewDisableButtonColumn3
            // 
            this.dataGridViewDisableButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewDisableButtonColumn3.HeaderText = "Stop";
            this.dataGridViewDisableButtonColumn3.MinimumWidth = 60;
            this.dataGridViewDisableButtonColumn3.Name = "dataGridViewDisableButtonColumn3";
            this.dataGridViewDisableButtonColumn3.ReadOnly = true;
            this.dataGridViewDisableButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDisableButtonColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 567);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1048, 606);
            this.Name = "Form1";
            this.Text = "JobManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addJob;
        private System.Windows.Forms.Button delJob;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jobcheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn src;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn sch;
        private System.Windows.Forms.DataGridViewTextBoxColumn func;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private DataGridViewDisableButtonColumn edit;
        private DataGridViewDisableButtonColumn start;
        private DataGridViewDisableButtonColumn stop;
        private DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn1;
        private DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn2;
        private DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn3;
    }
}

