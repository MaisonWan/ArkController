using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
                Match match = Regex.Match(line.Trim(), @"([drwx-]+)\s*(\w+)\s*(\w+)\s*(\w*)\s*(\d{4}-\d{2}-\d{2}\s+\d{2}:\d{2})\s+(\w+).*");
                if (match.Groups.Count > 5)
                {
                    ExplorerFileInfo fileInfo = new ExplorerFileInfo();
                    fileInfo.IsFolder = match.Groups[1].Value.StartsWith("d");
                    fileInfo.Owner = match.Groups[2].Value;
                    fileInfo.Group = match.Groups[3].Value;
                    if (!fileInfo.IsFolder && match.Groups[4].Value != "")
                    {
                        fileInfo.FileSize = Convert.ToInt64(match.Groups[4].Value);
                    }
                    fileInfo.CreateDateTime = DateTime.ParseExact(match.Groups[5].Value, "yyyy-MM-dd HH:mm", CultureInfo.CurrentCulture);
                    fileInfo.FileName = match.Groups[6].Value;
                    list.Add(fileInfo);
                }
            }
            return list;
        }
    }
}
