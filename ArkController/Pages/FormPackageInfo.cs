using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArkController.Kit;
using System.IO;
using ArkController.Task;
using ArkController.Component;

namespace ArkController.Pages
{
    public partial class FormPackageInfo : Form
    {
        private string packageName = null;
        private ConnectTaskThread taskThread = null;

        /// <summary>
        /// 包名，需要获取信息
        /// </summary>
        public string PakcageName
        {
            get { return this.packageName; }
            set 
            { 
                this.packageName = value;
                this.textBoxPackage.Text = value;
            }
        }

        public FormPackageInfo()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void FormPackageInfo_Load(object sender, EventArgs e)
        {
            UpdatePackageInfo(this.textBoxPackage.Text);
        }

        private void buttonGetPackageInfo_Click(object sender, EventArgs e)
        {
            UpdatePackageInfo(this.textBoxPackage.Text);
        }

        /// <summary>
        /// 更新显示包名和信息
        /// </summary>
        /// <param name="package"></param>
        public void UpdatePackageInfo(string package)
        {
            this.Text = package;
            string cmd = "shell dumpsys package " + package;
            TaskInfo tSize = TaskInfo.Create(TaskType.ExecuteCommand, cmd);
            tSize.ResultHandler = new TaskInfo.EventResultHandler(updatePackageInfoResult);
            taskThread.SendTask(tSize);
        }

        private void updatePackageInfoResult(object[] result)
        {
            this.textBoxPackageInfo.Text = (string)result[0];
        }

        private void textBoxPackageInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string content = this.textBoxPackageInfo.Text;
            if (string.IsNullOrEmpty(content))
            {
                return;
            }
            string defaultName = "package_" + this.textBoxPackage.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
            string localFilePath = DialogKit.ShowSaveLogDialog(defaultName);
            if (!string.IsNullOrEmpty(localFilePath))
            {
                FileStream fs = new FileStream(localFilePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(content);
                sw.Close();
                fs.Close();
            }
        }
    }
}
