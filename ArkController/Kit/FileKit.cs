using ArkController.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public static Image GetFileIconImage(ImageList imageList, ExplorerFileInfo fileInfo)
        {
            return imageList.Images[GetFileIconName(imageList, fileInfo)];
        }

        /// <summary>
        /// 得到文件图标的key
        /// </summary>
        /// <param name="imageList"></param>
        /// <param name="fileExp"></param>
        /// <returns></returns>
        public static string GetFileIconName(ImageList imageList, ExplorerFileInfo fileInfo)
        {
            if (fileInfo != null && fileInfo.IsFolder)
            {
                return "folder.png";
            }
            string fileExp = Path.GetExtension(fileInfo.FileName);
            if (string.IsNullOrEmpty(fileExp))
            {
                return "unknown.png"; // 没有扩展名的文件
            }
            foreach (string key in imageList.Images.Keys)
            {
                if (key == fileExp.Substring(1) + ".png")
                {
                    return key;
                }
            }
            return "unknown.png"; // 有扩展名，但是不认识
        }

        /// <summary>
        /// 返回上一层目录
        /// </summary>
        /// <param name="currentFolder"></param>
        /// <returns></returns>
        public static string GetUpFolder(string currentFolder)
        {
            if (currentFolder.EndsWith("/"))
            {
                if (currentFolder.Length == 1)
                {
                    return null;
                }
                currentFolder = currentFolder.Substring(0, currentFolder.Length - 1);
            }
            return currentFolder.Substring(0, currentFolder.LastIndexOf('/') + 1);
        }
    }
}
