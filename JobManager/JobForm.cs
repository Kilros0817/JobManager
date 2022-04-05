using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManager.utility;

namespace JobManager
{
    public partial class JobForm : Form
    {

        private int g_index = 0;
        private string g_srcPath = string.Empty;
        private string g_destPath = string.Empty;
        private string g_ext = string.Empty;
        private bool isNew = true;

        public JobForm()
        {
            InitializeComponent();
        }

        public JobForm (int index)
        {
            g_index = index;
            InitializeComponent();
            isNew = false;
            initUI();
        }

        private void initUI()
        {
            jobName.Text = util.g_jobList[g_index].Name;
            sourcePath.Text = util.g_jobList[g_index].Source;
            isSFTP.Checked = util.g_jobInfoList[g_index].IsSFTP;
            sftpUsername.Text = util.g_jobInfoList[g_index].SFTPUserName;
            sftpPwd.Text = util.g_jobInfoList[g_index].SFTPPwd;
            extension.Text = util.g_jobList[g_index].Extension;
            destPath.Text = util.g_jobList[g_index].Destination;
            schedule.Value = util.g_jobList[g_index].Sche;
            radioCopy.Checked = util.g_jobList[g_index].IsCopy;
            radioMove.Checked = !util.g_jobList[g_index].IsCopy;
            isSFTP.Checked = util.g_jobList[g_index].IsSFTP;
        }
        private void srcBro_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = sourcePath.Text;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void desBro_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = destPath.Text;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                destPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(jobName.Text))
            {
                MessageBox.Show("Enter Job Name!");
                return;
            }
            if (string.IsNullOrEmpty(sourcePath.Text))
            {
                MessageBox.Show("Enter Source Path!");
                return;
            }
            if (string.IsNullOrEmpty(destPath.Text))
            {
                MessageBox.Show("Enter Destination Path!");
                return;
            }

            Job w_job = new Job();
            w_job.Name = jobName.Text;
            w_job.Source = sourcePath.Text;
            w_job.SFTPUserName = sftpUsername.Text;
            w_job.SFTPPwd = sftpPwd.Text;
            w_job.Extension = extension.Text;
            w_job.Destination = destPath.Text;
            w_job.Sche = (int)schedule.Value;
            w_job.IsCopy = radioCopy.Checked;
            w_job.IsSFTP = isSFTP.Checked;
            w_job.Sts = 0;

            if (isNew)
                util.g_jobList.Add(w_job);
            else
                util.g_jobList[g_index] = w_job;

            util.Save_ENV();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void isSFTP_CheckedChanged(object sender, EventArgs e)
        {
            if (isSFTP.Checked)
                sftpGB.Enabled = true;
            else
            {
                sftpGB.Enabled = false;
                sftpPwd.Text = string.Empty;
                sftpUsername.Text = string.Empty;
            }
        }
    }
}
