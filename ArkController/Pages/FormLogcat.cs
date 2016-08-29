using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArkController.Data;

namespace ArkController
{
    /// <summary>
    /// 抓取logcat的界面
    /// </summary>
    public partial class FormLogcat : Form, Command.Callback
    {
        private Thread thread = null;
        private Command cmd = null;
        private bool autoStart = false;
        private string filter = null;

        public FormLogcat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormLogcat_Load(object sender, EventArgs e)
        {
            this.comboBoxPriority.SelectedIndex = 0;
            // 自动启动
            if (autoStart)
            {
                this.textBoxFilter.Text = filter;
                this.buttonStart.PerformClick();
                this.textBoxContent.Focus();
            }
            else
            {
                switchLogcat(false);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switchLogcat(true);
        }

        /// <summary>
        /// 开始抓取logcat
        /// </summary>
        /// <param name="filter"></param>
        public void AutoStartLogcat(string filter)
        {
            this.autoStart = true;
            this.filter = filter;
        }

        private void startLogcat()
        {
            if (cmd == null)
            {
                cmd = new Command();
            }
            string args = "logcat";
            if (!String.IsNullOrEmpty(this.textBoxFilter.Text))
            {
                args = args + " -s " + this.textBoxFilter.Text;
            }
            if (this.comboBoxPriority.SelectedIndex > 0)
            {
                string[] priority = { "V", "D", "I", "W", "E", "F", "S" };
                int index = this.comboBoxPriority.SelectedIndex;
                args = args + " *:" + priority[index - 1];
            }
            cmd.ExecuteAdb(args, this);
        }

        /// <summary>
        /// 持续返回的log
        /// </summary>
        /// <param name="line"></param>
        void Command.Callback.onReceive(string line)
        {
            this.textBoxContent.AppendText(line);
            this.textBoxContent.AppendText(Environment.NewLine);
        }

        private void FormLogcat_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmd.ExitExecuteAdb();
            switchLogcat(false);
            this.autoStart = false;
            this.DialogResult = DialogResult.No;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            switchLogcat(false);
        }

        /// <summary>
        /// 切换状态
        /// </summary>
        /// <param name="state">开始为true，结束为false</param>
        private void switchLogcat(bool state)
        {
            if (state)
            {
                if (thread == null || thread.ThreadState != ThreadState.Running)
                {
                    thread = new Thread(new ThreadStart(startLogcat));
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxContent.Clear();
        }
    }
}
