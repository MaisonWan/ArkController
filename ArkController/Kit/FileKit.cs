using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public static string FormatFileSize(Int64 fileSize)
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
            else if (fileSize == 0)
            {
                return "";
            }
            else
            {
                return string.Format("{0} bytes", fileSize);
            }
        }

        /// <summary>
        /// 根据扩展名得到文件图标的名字
        /// </summary>
        /// <param name="fileExp">文件扩展名</param>
        /// <returns></returns>
        public static Image GetFileIconImage(ImageList imageList, string fileExp)
        {
            return imageList.Images[GetFileIconName(imageList, fileExp)];
        }

        /// <summary>
        /// 得到文件图标的key
        /// </summary>
        /// <param name="imageList"></param>
        /// <param name="fileExp"></param>
        /// <returns></returns>
        public static string GetFileIconName(ImageList imageList, string fileExp)
        {
            if (string.IsNullOrEmpty(fileExp))
            {
                return "folder.png";
            }
            foreach (string key in imageList.Images.Keys)
            {
                if (key == fileExp.Substring(1) + ".png")
                {
                    return key;
                }
            }
            return "folder.png";
        }
    }
}
