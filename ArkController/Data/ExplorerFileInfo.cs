using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkController.Data
{
    /// <summary>
    /// 文件浏览器，文件属性
    /// </summary>
    public class ExplorerFileInfo
    {
        private bool isFolder = false;
        /// <summary>
        /// 是否是文件夹
        /// </summary>
        public bool IsFolder
        {
            get { return isFolder; }
            set { this.isFolder = value; }
        }

        private string owner = null;
        /// <summary>
        /// 文件或者文件夹的拥有者
        /// </summary>
        public string Owner
        {
            get { return owner; }
            set { this.owner = value; }
        }

        private string group = null;
        /// <summary>
        /// 所属的组
        /// </summary>
        public string Group
        {
            get { return group; }
            set { this.group = value; }
        }

        private long fileSize = 0;
        /// <summary>
        /// 文件尺寸
        /// </summary>
        public long FileSize
        {
            get { return fileSize; }
            set { this.fileSize = value; }
        }

        private DateTime createDateTime;
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDateTime
        {
            get { return createDateTime; }
            set { this.createDateTime = value; }
        }

        private string fileName = null;
        /// <summary>
        /// 文件或者文件夹名
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set { this.fileName = value; }
        }

        private string fileFullPath = null;
        /// <summary>
        /// 文件或者文件夹的全路径
        /// </summary>
        public string FileFullPath
        {
            get { return fileFullPath; }
            set { this.fileFullPath = value; }
        }
    }
}
