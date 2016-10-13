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
    }
}
