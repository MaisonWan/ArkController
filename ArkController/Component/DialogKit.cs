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
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型
            sfd.Filter = "安装文件（*.apk）|*.apk|所有文件（*.*）|*.*";
            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;
            sfd.FileName = defaultName;
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName.ToString();
            }
            return null;
        }

        /// <summary>
        /// 显示保存log文件的对话框
        /// </summary>
        /// <param name="defaultName"></param>
        /// <returns></returns>
        public static string ShowSaveLogDialog(string defaultName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型
            sfd.Filter = "日志文件（*.log）|*.log|文本文件（*.txt）|*.txt";
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
    }
}
