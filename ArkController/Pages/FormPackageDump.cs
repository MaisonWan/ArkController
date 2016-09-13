using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ArkController.Component;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormPackageDump : Form
    {
        private string packageName = null;
        private ConnectTaskThread taskThread = null;

        private string packageDumpInfo = null;

        /// <summary>
        /// 包名，需要获取信息
        /// </summary>
        public string PakcageName
        {
            get { return this.packageName; }
            set
            {
                this.packageName = value;
                this.textBoxPackageName.Text = value;
            }
        }

        public FormPackageDump()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void FormPackageDump_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxPackageName.Text))
            {
                UpdatePackageDump(this.textBoxPackageName.Text);
            }
        }

        private void buttonGetPackageDump_Click(object sender, EventArgs e)
        {
            UpdatePackageDump(this.textBoxPackageName.Text);
        }

        /// <summary>
        /// 更新显示包名和信息
        /// </summary>
        /// <param name="package"></param>
        public void UpdatePackageDump(string package)
        {
            if (!string.IsNullOrEmpty(package))
            {
                this.Text = package;
            }
            string cmd = "shell pm dump " + package;
            TaskInfo tSize = TaskInfo.Create(TaskType.ExecuteCommand, cmd);
            tSize.ResultHandler = new TaskInfo.EventResultHandler(updatePackageDumpResult);
            taskThread.SendTask(tSize);
        }

        /// <summary>
        /// 获取系统信息结果
        /// </summary>
        /// <param name="result"></param>
        private void updatePackageDumpResult(object[] result)
        {
            this.packageDumpInfo = (string)result[0];
            this.packageDumpInfo = Encoding.UTF8.GetString(Encoding.Default.GetBytes(this.packageDumpInfo));
            this.showDumpDetail(this.packageDumpInfo);
        }

        private void showDumpDetail(string dump)
        {
            int packageIndex = dump.IndexOf("DUMP OF SERVICE package");
            int activityIndex = dump.IndexOf("DUMP OF SERVICE activity");
            int meminfoIndex = dump.IndexOf("DUMP OF SERVICE meminfo");
            int procstatsIndex = dump.IndexOf("DUMP OF SERVICE procstats");
            int usagestatsIndex = dump.IndexOf("DUMP OF SERVICE usagestats");
            int batterystatsIndex = dump.IndexOf("DUMP OF SERVICE batterystats");

            if (packageIndex >= 0)
            {
                this.textBoxPackage.Text = dump.Substring(packageIndex, activityIndex - packageIndex);
                this.textBoxActivity.Text = dump.Substring(activityIndex, meminfoIndex - activityIndex);
                this.textBoxMeminfo.Text = dump.Substring(meminfoIndex, procstatsIndex - meminfoIndex);
                this.textBoxProcstats.Text = dump.Substring(procstatsIndex, usagestatsIndex - procstatsIndex);
                this.textBoxUsagestats.Text = dump.Substring(usagestatsIndex, batterystatsIndex - usagestatsIndex);
                this.textBoxBatterystats.Text = dump.Substring(batterystatsIndex);
            }
            else
            {
                this.textBoxPackage.Text = dump;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(packageDumpInfo))
            {
                return;
            }
            string defaultName = "package_" + this.textBoxPackageName.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
            string localFilePath = DialogKit.ShowSaveLogDialog(defaultName);
            if (!string.IsNullOrEmpty(localFilePath))
            {
                FileStream fs = new FileStream(localFilePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(packageDumpInfo);
                sw.Close();
                fs.Close();
            }
        }
    }
}
