using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Renci.SshNet;
using System.Windows.Forms;

namespace JobManager.utility
{
    public class Job : JobInfo
    {
        public Job()
        {

        }
        public Job(JobInfo jobInfo)
        {
            this.Name = jobInfo.Name;
            this.Source = jobInfo.Source;
            this.IsSFTP = jobInfo.IsSFTP;
            this.SFTPUserName = jobInfo.SFTPUserName;
            this.SFTPPwd = jobInfo.SFTPPwd;
            this.Extension = jobInfo.Extension;
            this.Destination = jobInfo.Destination;
            this.Sche = jobInfo.Sche;
            this.IsCopy = jobInfo.IsCopy;
            this.Sts = jobInfo.Sts;
        }
        public System.Threading.Timer JobTimer { get; set; }
        public int index { get; set; }
        public int work()
        {
            try
            {
                string[] w_list = Directory.GetFiles(this.Source, this.Extension);
                if (this.IsSFTP)
                {
                    var client = new SftpClient(this.Destination.Split('/')[0], 22, this.SFTPUserName, this.SFTPPwd);
                    client.Connect();

                    foreach (string file in w_list)
                    {
                        var s = File.OpenRead(file);
                        client.UploadFile(s, $"/{this.Destination.Split('/')[1]}/{Path.GetFileName(file)}");

                        s.Close();
                        if (!this.IsCopy)
                            File.Delete(file);
                    }
                    client.Disconnect();
                }
                else
                {
                    foreach (string file in w_list)
                    {
                        string desFile = Path.Combine(this.Destination, Path.GetFileName(file));

                        File.Copy(file, desFile, true);

                        if (!this.IsCopy)
                            File.Delete(file);
                    }
                }
                
                this.Sts = 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                this.Sts = 2;
            }


            return this.Sts;
        }
    }
}
