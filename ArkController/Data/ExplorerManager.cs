using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkController.Data
{
    /// <summary>
    /// 文件管理器操作
    /// </summary>
    public class ExplorerManager
    {
        /// <summary>
        /// 解析文件属性
        /// </summary>
        /// <param name="logContent"></param>
        /// <returns></returns>
        public List<ExplorerFileInfo> ParserFilesInfo(string logContent)
        {
            string[] lines = logContent.Split("\n".ToCharArray());
            List<ExplorerFileInfo> list = new List<ExplorerFileInfo>(lines.Length);
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                string[] items = line.Split(" ".ToCharArray());
                ExplorerFileInfo fileInfo = new ExplorerFileInfo();
                fileInfo.IsFolder = items[0].StartsWith("d");
                list.Add(fileInfo);
            }
            return list;
        }
    }
}
