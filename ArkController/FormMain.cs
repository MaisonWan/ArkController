﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ArkController.Component;
using ArkController.Data;
using ArkController.Kit;
using ArkController.Pages;
using System.IO;
using ArkController.Task;

namespace ArkController
{
    public partial class FormMain : Form
    {
        private Log log = null;
        private ConnectTaskThread taskThread = null;
        private AdbConnect connect = null;
        private DeviceManager manager = null;

        private FormScreenShot screenShot = null;
        private FormLogcat logcat = null;
        private FormScreenSize screenSize = null;
        private FormPackageInfo packageInfo = null;
        private FormMemInfo meminfo = null;

        public FormMain()
        {
            InitializeComponent();
            log = new Log(textBoxLog);
            connect = new AdbConnect();
            connect.Log = log;
            manager = new DeviceManager(connect);
            taskThread = ConnectTaskThread.GetInstance();
            taskThread.Log = log;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 显示名称，带版本号
            this.Text += " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            // 初始化Listview
            listViewPackage_Resize(sender, e);
            listViewProcessList_Resize(sender, e);
            ListViewColumnSorter sorter = new ListViewColumnSorter();
            this.listViewPackage.ListViewItemSorter = sorter;
            this.listViewProcessList.ListViewItemSorter = sorter;
            // 默认选择所有
            this.comboBoxPackageType.SelectedIndex = 0;
            this.comboBoxProcess.SelectedIndex = 1;
            taskThread.Start();
            updateDeviceList();
        }

        /// <summary>
        /// 更新当前连接列表
        /// </summary>
        private void updateDeviceList()
        {
            TaskInfo task = new TaskInfo(TaskType.DeviceList);
            task.ResultHandler = new TaskInfo.EventResultHandler(updateDeviceList);
            taskThread.SendTask(task);
        }

        /// <summary>
        /// 设备列表的返回
        /// </summary>
        /// <param name="result"></param>
        private void updateDeviceList(object result)
        {
            this.toolStripComboBoxDeviceList.Items.Clear();
            this.toolStripComboBoxDeviceList.Items.AddRange((string[])result);
            this.toolStripComboBoxDeviceList.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化工具显示
        /// </summary>
        private void updateBatteryInfo()
        {
            TaskInfo task = new TaskInfo(TaskType.ExecuteCommand);
            task.Data = "shell dumpsys battery";
            task.ResultHandler = new TaskInfo.EventResultHandler(updateBatteryInfoReuslt);
            taskThread.SendTask(task);
        }

        /// <summary>
        /// 电池信息的返回
        /// </summary>
        /// <param name="data"></param>
        private void updateBatteryInfoReuslt(object data)
        {
            string info = (string)data;
            if (!String.IsNullOrEmpty(info))
            {
                manager.BatteryParser = BatteryParser.Parser(info);
                this.pictureBoxBattery.Image = manager.BatteryParser.BatteryImage;
            }
        }

        /// <summary>
        /// 所有按键都统一执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKey_Click(object sender, EventArgs e)
        {
            int data = -1;
            if (sender == this.buttonUp)
            {
                data = 19;
            }
            else if (sender == this.buttonDown)
            {
                data = 20;
            }
            else if (sender == this.buttonLeft)
            {
                data = 21;
            }
            else if (sender == this.buttonRight)
            {
                data = 22;
            }
            else if (sender == this.buttonCenter)
            {
                data = 23;
            }
            else if (sender == this.buttonVolumeUp)
            {
                data = 24;
            }
            else if (sender == this.buttonVolumeDown)
            {
                data = 25;
            }
            else if (sender == this.buttonPower)
            {
                data = 26;
            }
            else if (sender == this.buttonBack)
            {
                data = 4;
            }
            else if (sender == this.buttonHome)
            {
                data = 3;
            }
            else if (sender == this.buttonMenu)
            {
                data = 82;
            }
            if (data > -1)
            {
                TaskInfo task = new TaskInfo(TaskType.SendKey);
                task.Data = data;
                taskThread.SendTask(task);
            }
        }

        /// <summary>
        /// 菜单按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Click(object sender, EventArgs e)
        {
            if (sender == this.toolStripMenuItemDeviceInfo)
            {
                tabControlHomePage.SelectedIndex = 0;
            }
            else if (sender == this.toolStripMenuItemKey)
            {
                tabControlHomePage.SelectedIndex = 1;
            }
            else if (sender == this.toolStripMenuItemPackage)
            {
                tabControlHomePage.SelectedIndex = 2;
            }
            else if (sender == this.toolStripMenuItemProcess)
            {
                tabControlHomePage.SelectedIndex = 3;
            }
            else if (sender == this.toolStripMenuItemSystem)
            {
                tabControlHomePage.SelectedIndex = 4;
            }
            else if (sender == this.toolStripMenuItemDeviceRefreash
                || sender == this.toolStripButtonRefresh)
            {
                updateDeviceList();
            }
        }

        private void buttonReboot_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要重启设备？", "重启确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                connect.InputCommand("reboot");
            }
        }

        private void buttonSendText_Click(object sender, EventArgs e)
        {
            string text = this.textBoxSendText.Text;
            connect.InputText(text);
        }

        private void textBoxSendText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = this.textBoxSendText.Text;
                connect.InputText(text);
            }
        }

        private void install(string path)
        {
            if (connect.Install(path))
            {
                MessageBox.Show(path + "安装成功", "安装", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(path + "安装失败", "安装", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        # region 系统控制按钮
        private void buttonDeviceDetect_Click(object sender, EventArgs e)
        {
            const string package = "com.qihoo360.homecamera.devicedetect";
            const string activity = "com.qihoo360.homecamera.devicedetect.MainActivity";
            connect.StartAm(package, activity);
        }

        private void buttonSystemSetting_Click(object sender, EventArgs e)
        {
            const string package = "com.android.settings";
            const string activity = "com.android.settings.Settings";
            connect.StartAm(package, activity);
        }

        private void buttonDeviceInfo_Click(object sender, EventArgs e)
        {
            manager.Package.OpenDeviceInfoSetting();
        }

        private void buttonLogcat_Click(object sender, EventArgs e)
        {
            if (logcat == null || logcat.IsDisposed)
            {
                logcat = new FormLogcat();
            }
            logcat.ShowDialog();
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            FormKit.Show(screenShot, typeof(FormScreenShot), connect);
        }

        private void buttonRestartAdb_Click(object sender, EventArgs e)
        {
            connect.InputCommand("kill-server");
            connect.InputCommand("start-server");
        }

        /// <summary>
        /// 安装程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstall_Click(object sender, EventArgs e)
        {
            this.openFileDialogInstall.Filter = "Android程序(*.apk)|*.apk|所有文件(*.*)|*.*";
            this.openFileDialogInstall.RestoreDirectory = true;
            this.openFileDialogInstall.FileName = "";
            if (this.openFileDialogInstall.ShowDialog() == DialogResult.OK)
            {
                string filePath = this.openFileDialogInstall.FileName;
                install(filePath);
            }
        }

        private void buttonInstall_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonInstall_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i].Trim() != "")
                {
                    install(s[i].Trim());
                }
            }
        }

        private void buttonScreenSize_Click(object sender, EventArgs e)
        {
            FormKit.Show(screenSize, typeof(FormScreenSize), manager.ScreenData);
        }

        private void buttonMemInfo_Click(object sender, EventArgs e)
        {
            FormKit.Show(meminfo, typeof(FormMemInfo), connect);
        }
        #endregion

        #region 包列表
        private void buttonPackageList_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxPackageType.SelectedIndex;
            string args = null;
            if (index == 1)
            {
                args = "-s";
            }
            else if (index == 2)
            {
                args = "-3";
            }
            manager.Package.UpdatePackageList(this.listViewPackage, args, this.textBoxFilter.Text, this.checkBoxFilter.Checked);
        }

        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPackageList_Click(sender, null);
            }
        }

        private void listViewPackage_Resize(object sender, EventArgs e)
        {
            int width = this.listViewPackage.Width;
            this.listViewPackage.Columns[0].Width = (int)(width * 0.25f);
            this.listViewPackage.Columns[1].Width = (int)(width * 0.45f);
            this.listViewPackage.Columns[2].Width = (int)(width * 0.10f);
            this.listViewPackage.Columns[3].Width = (int)(width * 0.20f);
        }

        private void listViewPackage_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView listView = sender as ListView;
            // 检查点击的列是不是现在的排序列.
            if (e.Column == (listView.ListViewItemSorter as ListViewColumnSorter).SortColumn)
            {
                // 重新设置此列的排序方法.
                if ((listView.ListViewItemSorter as ListViewColumnSorter).Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    (listView.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    (listView.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // 设置排序列，默认为正向排序
                (listView.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                (listView.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
            }
            listView.Sort();
        }
        #endregion

        private void ToolStripMenuItemDetail_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                manager.Package.OpenApplicationDetail(packageName);
            }
        }

        private void toolStripMenuItemClearData_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                string msg = "确认清空设备上应用" + packageName + "的数据？";
                if (MessageBox.Show(msg, "清空提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    manager.Package.ClearApplicationData(packageName);
                }
            }
        }

        private void PToolStripMenuItemPackageInfo_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                if (packageInfo == null || packageInfo.IsDisposed)
                {
                    packageInfo = new FormPackageInfo(this.connect);
                }
                packageInfo.PakcageName = packageName;
                if (packageInfo.Visible)
                {
                    packageInfo.UpdatePackageInfo(packageName);
                    packageInfo.Activate();
                }
                else
                {
                    packageInfo.Show();
                }
            }
        }

        private void toolStripMenuItemLogcat_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                if (logcat == null || logcat.IsDisposed)
                {
                    logcat = new FormLogcat();
                }
                logcat.AutoStartLogcat(packageName);
                logcat.ShowDialog();
            }
        }

        private void toolStripMenuItemUninstall_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                string msg = "确认卸载设备上应用" + packageName + "？";
                if (MessageBox.Show(msg, "卸载提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connect.Uninstall(packageName);
                    buttonPackageList_Click(sender, e);
                }
            }
        }

        private void PToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                Clipboard.SetText(packageName);
            }
        }

        private void buttonDeveloper_Click(object sender, EventArgs e)
        {
            manager.Package.OpenDevementSetting();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            AboutBoxKibot aboutBox = new AboutBoxKibot();
            aboutBox.ShowDialog();
        }

        private void pictureBoxBattery_MouseEnter(object sender, EventArgs e)
        {
            if (manager.BatteryParser != null)
            {
                string info = manager.BatteryParser.BatteryFormatInfo;
                if (info != null)
                {
                    this.toolTipBattery.SetToolTip(this.pictureBoxBattery, manager.BatteryParser.BatteryFormatInfo);
                }
            }
        }

        private void toolStripComboBoxDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.toolStripComboBoxDeviceList.SelectedIndex;
            if (index == 0)
            {
                return;
            }
            this.connect.SetDeviceSerial(this.toolStripComboBoxDeviceList.Items[index].ToString());
            string[] values = manager.DeviceLink.GetCurrentDeviceInfo();
            if (values != null && values.Length == 4)
            {
                this.labelDeviceInfo.Text = values[0];
                this.labelProduct.Text = "Product:" + values[1];
                this.labelModel.Text = "Model:" + values[2];
                this.labelDevice.Text = "Device:" + values[3];
            }
            updateBatteryInfo();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //退出时退出adb
            connect.InputCommand("kill-server");
            taskThread.Stop();
            Application.Exit();
        }

        #region 当前进程Tab
        private void buttonProcessList_Click(object sender, EventArgs e)
        {
            List<ProcessData.Data> processList = manager.Process.GetCurrentProcessList();
            this.listViewProcessList.BeginUpdate();
            this.listViewProcessList.Items.Clear();
            bool needFilter = this.checkBoxProcess.Checked && !string.IsNullOrEmpty(this.textBoxProcessFilter.Text);
            foreach (ProcessData.Data data in processList)
            {
                if (needFilter && !data.Name.Contains(this.textBoxProcessFilter.Text))
                {
                    continue;
                }
                int index = this.comboBoxProcess.SelectedIndex;
                if ((index == 1 && !data.User.StartsWith("u0_")) 
                    || (index == 2 && data.User.StartsWith("u0_")))
                {
                    continue;
                }
                ListViewItem item = new ListViewItem(data.User);
                item.SubItems.Add(data.Pid);
                item.SubItems.Add(data.Ppid);
                item.SubItems.Add(data.Vsize);
                item.SubItems.Add(data.Rss);
                item.SubItems.Add(data.Name);
                this.listViewProcessList.Items.Add(item);
            }
            this.listViewProcessList.EndUpdate();
        }

        private void listViewProcessList_Resize(object sender, EventArgs e)
        {
            int width = this.listViewProcessList.Width;
            this.listViewProcessList.Columns[0].Width = (int)(width * 0.1f);
            this.listViewProcessList.Columns[1].Width = (int)(width * 0.1f);
            this.listViewProcessList.Columns[2].Width = (int)(width * 0.1f);
            this.listViewProcessList.Columns[3].Width = (int)(width * 0.1f);
            this.listViewProcessList.Columns[4].Width = (int)(width * 0.1f);
            this.listViewProcessList.Columns[5].Width = (int)(width * 0.50f);
        }
        #endregion

        private void buttonLogClear_Click(object sender, EventArgs e)
        {
            this.textBoxLog.Clear();
        }

        private void buttonLogSave_Click(object sender, EventArgs e)
        {
            string content = this.textBoxLog.Text;
            if (!string.IsNullOrEmpty(content))
            {
                SaveFileDialog sfd = this.saveFileDialogLog;
                //设置文件类型
                sfd.Filter = "日志文件（*.log）|*.log|文本文件（*.txt）|*.txt";
                //设置默认文件类型显示顺序 
                sfd.FilterIndex = 1;
                sfd.FileName = "log_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
                //保存对话框是否记忆上次打开的目录 
                sfd.RestoreDirectory = true;
                //点了保存按钮进入 
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                    FileStream fs = new FileStream(localFilePath, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.Write(content);
                    sw.Close();
                    fs.Close();
                }
            }
        }

        private void toolStripProcessMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewProcessList.SelectedItems.Count == 0)
            {
                return;
            }
            if (sender == this.toolStripMenuItemKillProcess)
            {
                // 结束进程
                string pid = this.listViewProcessList.SelectedItems[0].SubItems[1].Text.Trim();
                string result = manager.Process.KillProcess(pid);
                this.log.Write(result);
            }
            else if (sender == this.toolStripMenuItemMeminfo)
            {
                string pName = this.listViewProcessList.SelectedItems[0].SubItems[5].Text.Trim();
                if (meminfo == null || meminfo.IsDisposed)
                {
                    meminfo = new FormMemInfo(connect);
                }
                meminfo.SetAutoStart(pName);
                meminfo.Show();
            }
        }

    }
}
