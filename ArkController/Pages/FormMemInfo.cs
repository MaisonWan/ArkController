using ArkController.Kit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Pages
{
    public partial class FormMemInfo : Form
    {
        private IConnect connect = null;
        /// <summary>
        /// 是否自动开始
        /// </summary>
        private bool autoStart = false;
        private string processName = null;
        /// <summary>
        /// 间隔时间，单位秒
        /// </summary>
        private int[] INTERVAL = { 1, 2, 5, 10 };

        public FormMemInfo(IConnect connect)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.connect = connect;
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
        private void timerMeminfo_Tick(object sender, EventArgs e)
        {
            string cmd = "shell dumpsys meminfo " + this.textBoxFilter.Text;
            this.textBoxContent.Text = this.connect.ExecuteAdb(cmd);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.buttonStart.Enabled = false;
            this.buttonStop.Enabled = true;
            int index = this.comboBoxInterval.SelectedIndex;
            if (index > 0)
            {
                this.timerMeminfo.Interval = INTERVAL[index - 1] * 1000;
            }
            this.timerMeminfo.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.buttonStart.Enabled = true;
            this.buttonStop.Enabled = false;
            this.timerMeminfo.Stop();
        }

    }
}
