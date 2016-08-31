using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArkController.Data;
using System.IO;

namespace ArkController.Pages
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
                switchLogcat(true);
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
            if (this.checkBoxTime.Checked)
            {
                args = args + " -v time";
            }
            if (this.comboBoxPriority.SelectedIndex > 0)
            {
                string[] priority = { "V", "D", "I", "W", "E", "F", "S" };
                int index = this.comboBoxPriority.SelectedIndex;
                args = args + " *:" + priority[index - 1];
            }
            //if (!String.IsNullOrEmpty(this.textBoxFilter.Text))
            //{
            //    args = args + " | findstr " + this.textBoxFilter.Text;
            //}
            cmd.ExecuteAdb(args, this);
        }

        /// <summary>
        /// 持续返回的log
        /// </summary>
        /// <param name="line"></param>
        void Command.Callback.onReceive(string line)
        {
            if (line.Contains(this.textBoxFilter.Text))
            {
                this.textBoxContent.AppendText(line);
                this.textBoxContent.AppendText(Environment.NewLine);
            }
        }

        private void FormLogcat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmd != null)
            {
                cmd.ExitExecuteAdb();
            }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string content = this.textBoxContent.Text;
            if (!string.IsNullOrEmpty(content))
            {
                SaveFileDialog sfd = this.saveFileDialogContent;
                //设置文件类型 
                sfd.Filter = "日志文件（*.log）|*.log|文本文件（*.txt）|*.txt";
                //设置默认文件类型显示顺序 
                sfd.FilterIndex = 1;
                sfd.FileName = "logcat_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
                //保存对话框是否记忆上次打开的目录 
                sfd.RestoreDirectory = true;
                //点了保存按钮进入 
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                    FileStream fs = new FileStream(localFilePath, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs,Encoding.Default);
                    sw.Write(content);
                    sw.Close();
                    fs.Close();
                }
            }
        }
    }
}
