using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkController.Kit
{
    /// <summary>
    /// 文件工具
    /// </summary>
    public class FileKit
    {
        /// <summary>
        /// 格式化文件尺寸
        /// </summary>
        /// <param name="fileSize"></param>
        /// <returns></returns>
        public static String FormatFileSize(Int64 fileSize)
        {
            if (fileSize < 0)
            {
                throw new ArgumentOutOfRangeException("fileSize");
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                return string.Format("{0:########0.00} GB", ((Double)fileSize) / (1024 * 1024 * 1024));
            }
            else if (fileSize >= 1024 * 1024)
            {
                return string.Format("{0:####0.00} MB", ((Double)fileSize) / (1024 * 1024));
            }
            else if (fileSize >= 1024)
            {
                return string.Format("{0:####0.00} KB", ((Double)fileSize) / 1024);
            }
            else
            {
                return string.Format("{0} bytes", fileSize);
            }
        }
    }
}
