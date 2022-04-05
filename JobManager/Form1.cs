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
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace JobManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addJob_Click(object sender, EventArgs e)
        {
            Form addForm = new JobForm();
            DialogResult dialogResult = addForm.ShowDialog();
            if (!(dialogResult == DialogResult.Cancel))
                addRow2GridView(util.g_jobList[util.g_jobList.Count - 1]);
        }

        private void refreshGridView()
        {
            //dataGridView.DataSource = null;
            //dataGridView.Update();
            //dataGridView.Refresh();
            dataGridView.Invoke(new Action(() => { dataGridView.Rows.Clear(); }));
            dataGridView.Rows.Clear();

            foreach (Job job in util.g_jobList)
                addRow2GridView(job);
        }

        private void editSpeRowInGridView(int index, Job job)
        {
            dataGridView.Rows[index].Cells[2].Value = job.Name;
            dataGridView.Rows[index].Cells[3].Value = job.Source;
            dataGridView.Rows[index].Cells[4].Value = job.Extension;
            dataGridView.Rows[index].Cells[5].Value = job.Destination;
            dataGridView.Rows[index].Cells[6].Value = job.Sche;
            dataGridView.Rows[index].Cells[7].Value = job.IsCopy ? "Copy" : "Move";
        }

        private void addRow2GridView(Job job)
        {
            var index = dataGridView.Rows.Add();
            dataGridView.Rows[index].Cells[0].Value = false;
            dataGridView.Rows[index].Cells[1].Value = index + 1;

            editSpeRowInGridView(index, job);

            updateStatus(index, job.Sts);

            dataGridView.Rows[index].Cells[9].Value = "Edit";
            dataGridView.Rows[index].Cells[10].Value = "Start";
            dataGridView.Rows[index].Cells[11].Value = "Stop";

            ((DataGridViewDisableButtonCell)dataGridView.Rows[index].Cells[11]).Enabled = false;

            dataGridView.Update();
            dataGridView.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            util.Load_ENV();

            refreshGridView();
        }

        private void delCheckedJobs(List<int> list)
        {
            List<Job> newJobList = new List<Job>();
            for (int i = 0; i < util.g_jobList.Count; i++)
                if (!list.Contains(i + 1))
                    newJobList.Add(util.g_jobList[i]);
            util.g_jobList = newJobList;
            refreshGridView();
        }

        private void delJob_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
            {
                List<int> w_checkedList = new List<int>();
                foreach (DataGridViewRow row in dataGridView.Rows)
                    if ((bool)row.Cells[0].Value)
                        w_checkedList.Add((int)row.Cells[1].Value);

                delCheckedJobs(w_checkedList);
                util.Save_ENV();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 9 &&
                ((DataGridViewDisableButtonCell)dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex]).Enabled)
            {
                if (e.ColumnIndex == 9)
                {
                    Form editForm = new JobForm(e.RowIndex);
                    editForm.ShowDialog();

                    editSpeRowInGridView(e.RowIndex, util.g_jobList[e.RowIndex]);

                    dataGridView.Update();
                    dataGridView.Refresh();
                    return;
                }
                if (e.ColumnIndex == 10)
                {
                    ((DataGridViewDisableButtonCell)dataGridView.Rows[e.RowIndex].Cells[10]).Enabled = false;
                    ((DataGridViewDisableButtonCell)dataGridView.Rows[e.RowIndex].Cells[9]).Enabled = false;
                    ((DataGridViewDisableButtonCell)dataGridView.Rows[e.RowIndex].Cells[11]).Enabled = true;
                    dataGridView.Refresh();
                    start_job(e.RowIndex);
                    return;
                }
                if (e.ColumnIndex == 11)
                {
                    ((DataGridViewDisableButtonCell)dataGridView.Rows[e.RowIndex].Cells[10]).Enabled = true;
                    ((DataGridViewDisableButtonCell)dataGridView.Rows[e.RowIndex].Cells[9]).Enabled = true;
                    ((DataGridViewDisableButtonCell)dataGridView.Rows[e.RowIndex].Cells[11]).Enabled = false;
                    dataGridView.Refresh();
                    stop_job(e.RowIndex);
                    return;
                }
            }
            

        }

        private void updateJobStatus(int index, int status)
        {

            updateStatus(index, status);

            dataGridView.Invoke(new Action(() => { dataGridView.Update(); }));
            dataGridView.Invoke(new Action(() => { dataGridView.Refresh(); }));
        }

        private void updateStatus(int index, int status)
        {
            Color sColor = new Color();
            switch (status)
            {
                case 1:
                    sColor = Color.Green;
                    break;
                case 2:
                    sColor = Color.Yellow;
                    break;
                case 3:
                    sColor = Color.Red;
                    break;
            }
            dataGridView.Rows[index].Cells[8].Style.BackColor = sColor;
        }

        private void start_job(int index)
        {
            Job job = util.g_jobList[index];
            job.index = index;
            job.JobTimer = new System.Threading.Timer(jobCallback, job, 0, job.Sche * 1000);
        }

        private void jobCallback(object state)
        {
            Job job = (Job)state;
            job.work();
            updateJobStatus(job.index, job.Sts);

        }

        private void stop_job(int index)
        {
            Job job = util.g_jobList[index];
            job.Sts = 3;
            updateJobStatus(job.index, job.Sts);
            job.JobTimer.Dispose();
        }

        private void startJob_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.Save_ENV();
        }
    }
}
