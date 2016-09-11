using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ArkController.Component;
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
            this.axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("record", ""); 
            updateRecordList();
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
            currentRecordPath = GetScreemRecordPath() + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".mp4";
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
            updateRecordList();
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
            return appDataPath;
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

        /// <summary>
        /// 更新录制的列表
        /// </summary>
        private void updateRecordList()
        {
            string path = GetScreemRecordPath();
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.mp4");
                this.listViewRecordList.BeginUpdate();
                this.listViewRecordList.Items.Clear();
                this.axWindowsMediaPlayer1.currentPlaylist.clear();
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    this.listViewRecordList.Items.Add(name);
                    this.axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(file));
                }
                this.listViewRecordList.EndUpdate();
            }
        }

        private void listViewRecordList_Resize(object sender, EventArgs e)
        {
            this.listViewRecordList.Columns[0].Width = this.listViewRecordList.ClientSize.Width;
        }

        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemPlay_Click(object sender, EventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewRecordList))
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.stop();
                int index = this.listViewRecordList.SelectedItems[0].Index;
                WMPLib.IWMPMedia media = this.axWindowsMediaPlayer1.currentPlaylist.Item[index];
                this.axWindowsMediaPlayer1.Ctlcontrols.playItem(media);
            }
        }

        /// <summary>
        /// 双击一条项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewRecordList_DoubleClick(object sender, EventArgs e)
        {
            toolStripMenuItemPlay_Click(sender, e);
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemOutput_Click(object sender, EventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewRecordList))
            {
                string fileName = this.listViewRecordList.SelectedItems[0].Text.Trim();
                string saveFilePath = DialogKit.ShowSaveMediaDialog(fileName);
                if (saveFilePath != null)
                {
                    string sourceFilePath = GetScreemRecordPath() + fileName;
                    File.Copy(sourceFilePath, saveFilePath);
                }
            }
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewRecordList))
            {
                string fileName = this.listViewRecordList.SelectedItems[0].Text.Trim();
                string filePath = GetScreemRecordPath() + fileName;
                string msg = string.Format("是否永久删除文件{0}，是否继续？", fileName);
                if (MessageBox.Show(msg, "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int index = this.listViewRecordList.SelectedItems[0].Index;
                    //WMPLib.IWMPMedia media = this.axWindowsMediaPlayer1.currentPlaylist.Item[index];
                    // 如果播放的正是当前文件，停止删除
                    if (index == currentPlayIndex())
                    {
                        this.axWindowsMediaPlayer1.Ctlcontrols.stop();
                    }
                    File.Delete(filePath);
                    updateRecordList();
                }
            }
        }

        /// <summary>
        /// 返回播放的id，-1未没找到
        /// </summary>
        /// <returns></returns>
        private int currentPlayIndex()
        {
            WMPLib.IWMPMedia media = this.axWindowsMediaPlayer1.currentMedia;
            for (int i = 0; i < this.axWindowsMediaPlayer1.currentPlaylist.count; i++)
            {
                if (media.name == this.axWindowsMediaPlayer1.currentPlaylist.Item[i].name)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 打开视频资源文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemOpenFolder_Click(object sender, EventArgs e)
        {
            string path = GetScreemRecordPath();
            Process.Start("explorer.exe", path);
        }
    }
}
