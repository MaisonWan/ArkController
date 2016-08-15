using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KibotController
{
    public partial class FormLogcat : Form, Command.Callback
    {
        private Thread thread = null;

        public FormLogcat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormLogcat_Load(object sender, EventArgs e)
        {
            this.comboBoxPriority.SelectedIndex = 0;
            switchLogcat(false);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switchLogcat(true);
        }

        public void startLogcat()
        {
            Command cmd = new Command();
            string args = "logcat";
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
            switchLogcat(false);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            switchLogcat(false);
        }

        /// <summary>
        /// 切换状态
        /// </summary>
        /// <param name="state"></param>
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
