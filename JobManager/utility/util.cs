using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace JobManager.utility
{
    static public class util
    {
        public static List<JobInfo> g_jobInfoList = new List<JobInfo>();
        public static List<Job> g_jobList = new List<Job>();
        private static string PATH_CONFIG = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        private static string jsonEnv = string.Empty;

        public static void Load_ENV()
        {
            if (!File.Exists(PATH_CONFIG))
            {
                return;
            }

            jsonEnv = File.ReadAllText(PATH_CONFIG);
            g_jobInfoList = JsonConvert.DeserializeObject<List<JobInfo>>(jsonEnv);

            foreach(JobInfo jobInfo in g_jobInfoList)
            {
                Job job = new Job(jobInfo);
                g_jobList.Add(job);
            }
        }

        private static void Set_ENV()
        {
            g_jobInfoList = new List<JobInfo>();
            foreach(Job job in g_jobList)
                g_jobInfoList.Add(job);
        }
        public static void Save_ENV()
        {
            Set_ENV();
            jsonEnv = JsonConvert.SerializeObject(g_jobInfoList, Formatting.Indented);
            File.WriteAllText(PATH_CONFIG, jsonEnv);
        }
    }
}
