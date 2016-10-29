using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Component
{
    /// <summary>
    /// 对话框工具
    /// </summary>
    public class DialogKit
    {
        /// <summary>
        /// 显示保存apk文件的对话框
        /// </summary>
        /// <returns>保存的路径，如果null证明没有保存</returns>
        public static string ShowSavePullApkDialog(string defaultName)
        {
            string filter = "安装文件（*.apk）|*.apk|所有文件（*.*）|*.*";
            return ShowSaveFileDialog(defaultName, filter);
        }

        /// <summary>
        /// 显示保存log文件的对话框
        /// </summary>
        /// <param name="defaultName"></param>
        /// <returns></returns>
        public static string ShowSaveLogDialog(string defaultName)
        {
            string filter = "日志文件（*.log）|*.log|文本文件（*.txt）|*.txt";
            return ShowSaveFileDialog(defaultName, filter);
        }

        /// <summary>
        /// 保存媒体文件
        /// </summary>
        /// <param name="defaultName"></param>
        /// <returns></returns>
        public static string ShowSaveMediaDialog(string defaultName)
        {
            string filter = "MP4（*.mp4）|*.mp4|所有文件（*.*）|*.*";
            return ShowSaveFileDialog(defaultName, filter);
        }

        /// <summary>
        /// 保存内存镜像文件
        /// </summary>
        /// <param name="defaultName">默认文件名</param>
        /// <returns></returns>
        public static string ShowSaveHprofDialog(string defaultName)
        {
            string filter = "hprof（*.hprof）|*.hprof|所有文件（*.*）|*.*";
            return ShowSaveFileDialog(defaultName, filter);
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="defaultName"></param>
        /// <returns></returns>
        public static string ShowSaveDialog(string defaultName)
        {
            string filter = "所有文件(*.*)|*.*";
            return ShowSaveFileDialog(defaultName, filter);
        }

        /// <summary>
        /// 保存文件对话框
        /// </summary>
        /// <param name="defaultName">默认文件名字</param>
        /// <param name="filterName">保存文件类型</param>
        /// <returns></returns>
        public static string ShowSaveFileDialog(string defaultName, string filterName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型
            sfd.Filter = filterName;
            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;
            sfd.FileName = defaultName;
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName.ToString(); //获得文件路径 
            }
            return null;
        }

        /// <summary>
        /// 返回对话框，点击取消返回null
        /// </summary>
        /// <param name="defaultName"></param>
        /// <param name="filterName"></param>
        /// <returns></returns>
        public static SaveFileDialog GetSaveFileDialog(string defaultName, string filterName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型
            sfd.Filter = filterName;
            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;
            sfd.FileName = defaultName;
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd; //获得文件路径 
            }
            return null;
        }

        /// <summary>
        /// 文件夹保存路径
        /// </summary>
        /// <returns></returns>
        public static string ShowSaveFolderDialog()
        {
            return ShowSaveFolderDialog(null);
        }

        /// <summary>
        /// 选择文件夹路劲
        /// </summary>
        /// <param name="defaultPath">默认打开的路径</param>
        /// <returns></returns>
        public static string ShowSaveFolderDialog(string defaultPath)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(defaultPath))
            {
                fbd.SelectedPath = defaultPath;
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return null;
        }

        /// <summary>
        /// 打开文件对话框
        /// </summary>
        /// <returns></returns>
        public static string[] OpenFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有文件(*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileNames;
            }
            return null;
        }
    }
}
