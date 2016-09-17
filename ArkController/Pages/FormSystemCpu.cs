using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArkController.Data;

namespace ArkController.Pages
{
    public partial class FormSystemCpu : Form, Command.Callback
    {
        private Thread thread = null;
        private Command cmd = null;

        /// <summary>
        /// 是否开始识别进程信息
        /// </summary>
        private bool startProcess = false;
        /// <summary>
        /// 进程显示数量
        /// </summary>
        private int processCount = 0;
        /// <summary>
        /// 临时存储进程信息
        /// </summary>
        private List<string> processList = new List<string>();

        public FormSystemCpu()
        {
            InitializeComponent();
        }

        private void FormSystemCpu_Load(object sender, EventArgs e)
        {
            this.comboBoxNum.SelectedIndex = 4;
            this.comboBoxInterval.SelectedIndex = 0;
            this.comboBoxSort.SelectedIndex = 0;
            this.buttonStop.Enabled = false;
            this.initListviewColume(this.checkBoxThreadInfo.Checked);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startTask();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopTask();
        }

        /// <summary>
        /// 设置控件状态
        /// </summary>
        /// <param name="state">开始之后传递true</param>
        private void setControlEnable(bool state)
        {
            this.comboBoxSort.Enabled = !state;
            this.comboBoxNum.Enabled = !state;
            this.comboBoxInterval.Enabled = !state;
            this.checkBoxThreadInfo.Enabled = !state;
            this.buttonStart.Enabled = !state;
            this.buttonStop.Enabled = state;
        }

        /// <summary>
        /// 开始任务
        /// </summary>
        private void startTask()
        {
            setControlEnable(true);
            processCount = Convert.ToInt32(this.comboBoxNum.SelectedItem.ToString());
            if (thread == null || thread.ThreadState != ThreadState.Running)
            {
                thread = new Thread(new ThreadStart(handleTask));
            }
            thread.Start();
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        private void stopTask()
        {
            if (thread != null)
            {
                thread.Abort();
                thread = null;
            }
            setControlEnable(false);
        }

        private void handleTask()
        {
            if (cmd == null)
            {
                cmd = new Command();
            }
            string num = this.comboBoxNum.SelectedItem.ToString();
            string interval = this.comboBoxInterval.SelectedItem.ToString();
            string sort = this.comboBoxSort.SelectedItem.ToString();
            bool showThreadInfo = this.checkBoxThreadInfo.Checked;
            string top_cmd = ProcessData.GetProcessTopCommand(num, interval, sort, showThreadInfo);
            cmd.ExecuteAdb(top_cmd, this);
        }

        void Command.Callback.onReceive(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return;
            }
            if (line.StartsWith("User"))
            {
                // 总体信息
                if (line.Contains("%"))
                {
                    this.labelUserPercent.Text = line;
                }
                else if (line.Contains("+"))
                {
                    this.labelUserSum.Text = line;
                }
            }
            else
            {
                // 有可能是进程信息或者是空行
                if (startProcess)
                {
                    if (line.Trim().Length > 0 && Char.IsNumber(line.Trim()[0]))
                    {
                        // 录入进程信息
                        processList.Add(line);
                        if (processList.Count == processCount)
                        {
                            startProcess = false;
                            showProcessInfoList();
                        }
                    }
                }
                else if (line.StartsWith("  PID"))
                {
                    // 进程数据的开始
                    startProcess = true;
                }
            }
        }

        /// <summary>
        /// 积攒的进程数据一起显示
        /// </summary>
        private void showProcessInfoList()
        {
            this.listViewProcess.Items.Clear();
            this.listViewProcess.BeginUpdate();
            for (int i = 0; i < processList.Count; i++)
            {
                this.listViewProcess.Items.Add(addListViewItem(processList[i].Trim()));
            }
            this.listViewProcess.EndUpdate();
            this.processList.Clear();
        }

        /// <summary>
        /// 添加一行
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private ListViewItem addListViewItem(string line)
        {
            string[] items = line.Split(" ".ToCharArray());
            ListViewItem item = new ListViewItem(items[0]);
            for (int i = 1; i < items.Length; i++)
            {
                if (!string.IsNullOrEmpty(items[i]))
                {
                    item.SubItems.Add(items[i]);
                }
            }
            return item;
        }

        private void FormSystemCpu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmd != null)
            {
                cmd.ExitExecuteAdb();
            }
            stopTask();
        }

        /// <summary>
        /// 勾选了是否显示线程信息时发生的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxThreadInfo_CheckedChanged(object sender, EventArgs e)
        {
            initListviewColume(this.checkBoxThreadInfo.Checked);
        }

        /// <summary>
        /// 初始化列
        /// </summary>
        private void initListviewColume(bool showThreadInfo)
        {
            int itemWidth = 0;
            int width = this.listViewProcess.ClientSize.Width;
            if (showThreadInfo)
            {
                itemWidth = (int)(width * 0.07f + 0.5);
            }
            else
            {
                itemWidth = (int)(width * 0.08f + 0.5);
            }
            this.listViewProcess.Columns.Clear();
            this.listViewProcess.Columns.Add("PID", itemWidth);
            this.listViewProcess.Columns.Add("PR", itemWidth);
            this.listViewProcess.Columns.Add("CPU%", itemWidth);
            this.listViewProcess.Columns.Add("S", itemWidth);
            this.listViewProcess.Columns.Add("#THR", itemWidth);
            this.listViewProcess.Columns.Add("VSS", itemWidth);
            this.listViewProcess.Columns.Add("RSS", itemWidth);
            this.listViewProcess.Columns.Add("PCY", itemWidth);
            this.listViewProcess.Columns.Add("UID", itemWidth);
            if (showThreadInfo)
            {
                this.listViewProcess.Columns.Add("Thread", (int)(width * 0.15f + 0.5));
                this.listViewProcess.Columns.Add("Process", (int)(width * 0.22f + 0.5));
            }
            else
            {
                this.listViewProcess.Columns.Add("Name", (int)(width * 0.28f + 0.5));
            }
        }

        private void listViewProcess_Resize(object sender, EventArgs e)
        {
            int itemWidth = 0;
            int width = this.listViewProcess.ClientSize.Width;
            if (this.checkBoxThreadInfo.Checked)
            {
                itemWidth = (int)(width * 0.07f + 0.5);
            }
            else
            {
                itemWidth = (int)(width * 0.08f + 0.5);
            }
            for (int i = 0; i < 9; i++)
            {
                this.listViewProcess.Columns[i].Width = itemWidth;
            }
            if (this.checkBoxThreadInfo.Checked)
            {
                this.listViewProcess.Columns[9].Width = (int)(width * 0.15f + 0.5);
                this.listViewProcess.Columns[10].Width = (int)(width * 0.22f + 0.5);
            }
            else
            {
                this.listViewProcess.Columns[9].Width = (int)(width * 0.28f + 0.5);
            }
        }
    }
}
