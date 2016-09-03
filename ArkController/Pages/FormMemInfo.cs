using ArkController.Kit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormMemInfo : Form
    {
        private ConnectTaskThread taskThread = null;
        private Thread thread = null;
        /// <summary>
        /// 是否自动开始
        /// </summary>
        private bool autoStart = false;
        private string processName = null;
        /// <summary>
        /// 间隔时间，单位秒
        /// </summary>
        private int[] INTERVAL = { 1, 2, 3, 5, 10 };

        public FormMemInfo()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            taskThread = ConnectTaskThread.GetInstance();
            this.comboBoxInterval.SelectedIndex = 0;
        }

        private void FormMemInfo_Load(object sender, EventArgs e)
        {
            if (autoStart)
            {
                this.autoStart = false;
                this.textBoxFilter.Text = processName;
                buttonStart_Click(sender, e);
            }
        }

        /// <summary>
        /// 设置自动开始
        /// </summary>
        /// <param name="pName"></param>
        public void SetAutoStart(string pName)
        {
            autoStart = true;
            processName = pName;
        }

        /// <summary>
        /// 间隔时间发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateMeminfo()
        {
            int index = this.comboBoxInterval.SelectedIndex;
            int interval = INTERVAL[index] * 1000;
            string cmd = "shell dumpsys meminfo " + this.textBoxFilter.Text.Trim();
            while (true)
            {
                TaskInfo tSize = TaskInfo.Create(TaskType.ExecuteCommand, cmd);
                tSize.ResultHandler = new TaskInfo.EventResultHandler(updateMeminfoResult);
                taskThread.SendTask(tSize);
                Thread.Sleep(interval);
            }
        }

        private void updateMeminfoResult(object[] result)
        {
            this.textBoxContent.Text = (string)result[0];
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switchUpdateThread(true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            switchUpdateThread(false);
        }

        /// <summary>
        /// 切换更新线程状态
        /// </summary>
        /// <param name="state"></param>
        private void switchUpdateThread(bool state)
        {
            if (state)
            {
                if (thread == null || thread.ThreadState != ThreadState.Running)
                {
                    thread = new Thread(new ThreadStart(updateMeminfo));
                }
                thread.Start();
                this.buttonStart.Enabled = false;
                this.buttonStop.Enabled = true;
            }
            else
            {
                if (thread != null)
                {
                    thread.Abort();
                    thread = null;
                }
                this.buttonStart.Enabled = true;
                this.buttonStop.Enabled = false;
            }
        }

        private void textBoxContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void FormMemInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            switchUpdateThread(false);
        }

    }
}
