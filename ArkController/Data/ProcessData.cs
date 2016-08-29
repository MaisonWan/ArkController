using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ArkController.Kit;

namespace ArkController.Data
{
    /// <summary>
    /// 运行进程
    /// </summary>
    public class ProcessData
    {
        private IConnect connect = null;

        public ProcessData(IConnect connect)
        {
            this.connect = connect;
        }

        /// <summary>
        /// 获取当前进程列表
        /// </summary>
        /// <returns></returns>
        public List<Data> GetCurrentProcessList()
        {
            string cmd = "shell ps";
            string log = connect.ExecuteAdb(cmd);
            string[] lines = log.Split("\n".ToCharArray());
            List<Data> list = new List<Data>(lines.Length);
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                Match match = Regex.Match(line, @"(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s+(\w+)\s*(\/*\w+.*)");
                if (match.Groups.Count == 10)
                {
                    Data data = new Data();
                    data.User = match.Groups[1].Value;
                    data.Pid = match.Groups[2].Value;
                    data.Ppid = match.Groups[3].Value;
                    data.Vsize = match.Groups[4].Value;
                    data.Rss = match.Groups[5].Value;
                    data.Name = match.Groups[9].Value;
                    list.Add(data);
                }
            }
            return list;
        }

        /// <summary>
        /// 进程数据
        /// </summary>
        public class Data
        {
            public string User;
            public string Pid;
            public string Ppid;
            public string Vsize;
            public string Rss;
            public string Name;
        }
    }
}
