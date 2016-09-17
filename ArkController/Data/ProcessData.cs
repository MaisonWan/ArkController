using System;
using System.Collections.Generic;
using System.IO;
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
        /// 杀掉进程
        /// </summary>
        /// <param name="pid">进程id</param>
        /// <returns></returns>
        public static string GetKillProcess(string pid)
        {
            return "shell am kill " + pid;
        }

        /// <summary>
        /// 得到存放镜像文件路径
        /// </summary>
        /// <returns></returns>
        public static string GetDumpHeapPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appDataPath = path + @"\ArkController\DumpHeap";
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            return appDataPath;
        }

        /// <summary>
        /// 获取进程占用CPU和内存的排名前几名
        /// </summary>
        /// <param name="num">显示数量</param>
        /// <param name="interval">间隔时间</param>
        /// <param name="sort">按照哪列排序</param>
        /// <param name="showThreadInfo">是否显示线程信息，而非进程信息</param>
        /// <returns></returns>
        public static string GetProcessTopCommand(string num, string interval, string sort, bool showThreadInfo)
        {
            string sortCol = "cpu";
            if (sort == "VSS")
            {
                sortCol = "vss";
            }
            else if (sort == "RSS")
            {
                sortCol = "rss";
            }
            else if (sort == "THREAD")
            {
                sortCol = "thr";
            }
            string cmd = string.Format("shell top -m {0} -d {1} -s {2}", num, interval, sortCol);
            if (showThreadInfo)
            {
                cmd += " -t";
            }
            return cmd;
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
