using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormApps : Form
    {
        private ConnectTaskThread taskThread = null;
        /// <summary>
        /// 更新显示最近程序
        /// </summary>
        /// <param name="apps"></param>
        private delegate void UpdateRecentApp(string[] apps);

        public FormApps()
        {
            InitializeComponent();
            this.taskThread = ConnectTaskThread.GetInstance();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormApps_Load(object sender, EventArgs e)
        {
            getRecentApp();
        }

        /// <summary>
        /// 得到最近应用
        /// </summary>
        private void getRecentApp()
        {
            string cmd = "shell dumpsys activity r";
            TaskInfo t = TaskInfo.Create(TaskType.ExecuteCommand, cmd);
            t.ResultHandler = new TaskInfo.EventResultHandler(getRecentAppResult);
            this.taskThread.SendTask(t);
        }

        private void getRecentAppResult(object[] result)
        {
            string content = result[0].ToString();
            string[] items = content.Split("  * ".ToCharArray());
            UpdateRecentApp updateApp = new UpdateRecentApp(updateRecentApp);
            this.Invoke(updateApp, new object[] { items });
            
        }

        private void updateRecentApp(string[] apps)
        {
            this.listViewApp.Items.Clear();
            this.listViewApp.BeginUpdate();
            foreach (string item in apps)
            {
                this.listViewApp.Items.Add(item);
            }
            this.listViewApp.EndUpdate();
        }
    }
}
