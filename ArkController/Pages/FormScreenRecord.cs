using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ArkController.Task;

namespace ArkController.Pages
{
    /// <summary>
    /// 录制视频
    /// </summary>
    public partial class FormScreenRecord : Form
    {
        private ConnectTaskThread taskThread = ConnectTaskThread.GetInstance();
        private int[] record_time = new int[]{10, 20, 30, 60, 90, 120, 150, 180};

        private string currentRecordPath = null;

        public FormScreenRecord()
        {
            InitializeComponent();
        }

        private void FormScreenRecord_Load(object sender, EventArgs e)
        {
            this.comboBoxSize.SelectedIndex = 0;
            this.comboBoxTime.SelectedIndex = 0;
        }
        /// <summary>
        /// 开始录制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartRecord_Click(object sender, EventArgs e)
        {
            this.buttonStartRecord.Enabled = false;
            this.buttonStopRecord.Enabled = true;
            TaskInfo t = new TaskInfo(TaskType.ScreenRecord);
            currentRecordPath = GetScreemRecordPath();
            t.Data = currentRecordPath; //存储路径
            t.DataArray = new object[] { this.comboBoxSize.SelectedItem.ToString(), getTimeLimit() };
            t.ResultHandler = new TaskInfo.EventResultHandler(recordResult);
            taskThread.SendTask(t);
        }

        /// <summary>
        /// 录制结果
        /// </summary>
        /// <param name="result"></param>
        private void recordResult(object[] result)
        {
            this.buttonStartRecord.Enabled = true;
            this.buttonStopRecord.Enabled = false;
            this.axWindowsMediaPlayer1.URL = currentRecordPath;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        /// <summary>
        /// 得到限制时长
        /// </summary>
        /// <returns></returns>
        private string getTimeLimit()
        {
            return record_time[this.comboBoxTime.SelectedIndex].ToString();
        }

        /// <summary>
        /// 得到屏幕截图路径
        /// </summary>
        /// <returns></returns>
        private string GetScreemRecordPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appDataPath = path + @"\ArkController\ScreenRecord\";
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            string localPath = appDataPath + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".mp4";
            return localPath;
        }

        /// <summary>
        /// 停止录制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            this.buttonStartRecord.Enabled = true;
            this.buttonStopRecord.Enabled = false;
        }

        private void axWindowsMediaPlayer1_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            this.axWindowsMediaPlayer1.fullScreen = !this.axWindowsMediaPlayer1.fullScreen;
        }
    }
}
