using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace JobManager.utility
{
    public class JobInfo
    {
        public JobInfo()
        {

        }

        public JobInfo(Job job)
        {
            this.Name = job.Name;
            this.Source = job.Source;
            this.IsSFTP = job.IsSFTP;
            this.SFTPUserName = job.SFTPUserName;
            this.SFTPPwd = job.SFTPPwd;
            this.Extension = job.Extension;
            this.Destination = job.Destination;
            this.Sche = job.Sche;
            this.IsCopy = job.IsCopy;
            this.Sts = job.Sts;
        }

        public string Name { get; set; }
        public string Source { get; set; }
        public bool IsSFTP { get; set; }
        public string SFTPUserName { get; set; }
        public string SFTPPwd { get; set; }
        public string Extension { get; set; }
        public string Destination { get; set; }
        public int Sche { get; set; }
        public bool IsCopy { get; set; }
        public int Sts { get; set; } //0:initial 1:success 2:failed 3:stopped
       
    }
}
