using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ArkController.Parser;

namespace ArkController
{
    public partial class FormMain : Form
    {
        private Log log = null;
        private IConnect connect = null;
        private FormScreenShot screenShot = null;
        private FormLogcat logcat = null;
        private FormPackageInfo packageInfo = null;
        private BatteryParser batterParser = null;
        private Device device = null;

        public FormMain()
        {
            InitializeComponent();
            log = new Log(textBoxLog);
            connect = new AdbConnect(log);
            device = new Device(connect);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 显示名称，带版本号
            this.Text += " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            updateDeviceList();
        }

        /// <summary>
        /// 更新当前连接列表
        /// </summary>
        private void updateDeviceList()
        {
            this.toolStripComboBoxDeviceList.Items.Clear();
            this.toolStripComboBoxDeviceList.Items.AddRange(device.DeviceList());
            this.toolStripComboBoxDeviceList.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化工具显示
        /// </summary>
        private void updateBatteryInfo()
        {
            string cmd = "shell dumpsys battery";
            string info = connect.ExecuteAdb(cmd);
            batterParser = BatteryParser.Parser(info);
            this.pictureBoxBattery.Image = batterParser.BatteryImage;
        }

        /// <summary>
        /// 所有按键都统一执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKey_Click(object sender, EventArgs e)
        {
            if (sender == this.buttonLeft)
            {
                connect.InputKey(21);
            }
            else if (sender == this.buttonRight)
            {
                connect.InputKey(22);
            }
            else if (sender == this.buttonUp)
            {
                connect.InputKey(19);
            }
            else if (sender == this.buttonDown)
            {
                connect.InputKey(20);
            }
            else if (sender == this.buttonCenter)
            {
                connect.InputKey(23);
            }
            else if (sender == this.buttonBack)
            {
                connect.InputKey(4);
            }
            else if (sender == this.buttonHome)
            {
                connect.InputKey(3);
            }
            else if (sender == this.buttonMenu)
            {
                connect.InputKey(82);
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

        private void buttonVolumeUp_Click(object sender, EventArgs e)
        {
            connect.InputKey(24);
        }

        private void buttonVolumeDown_Click(object sender, EventArgs e)
        {
            connect.InputKey(25);
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            connect.InputKey(26);
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

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            string localPath = Environment.CurrentDirectory + "\\screen.png";
            if (connect.GetScreenShot(localPath))
            {
                if (screenShot == null || screenShot.IsDisposed)
                {
                    screenShot = new FormScreenShot();
                }
                screenShot.ScreenShotPath = localPath;
                screenShot.Connect = connect;
                if (screenShot.Visible)
                {
                    screenShot.ReloadPicture();
                    screenShot.Activate();
                }
                else
                {
                    screenShot.Show();
                }
            }
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

        private void buttonRestartAdb_Click(object sender, EventArgs e)
        {
            connect.InputCommand("kill-server");
            connect.InputCommand("start-server");
        }

        private void buttonPackageList_Click(object sender, EventArgs e)
        {
            string[] packages = connect.GetPackageList();
            this.listViewPackage.BeginUpdate();
            this.listViewPackage.Items.Clear();
            bool needFilter = this.checkBoxFilter.Checked & this.textBoxFilter.Text.Length > 0;
            string filterName = this.textBoxFilter.Text;
            foreach (string p in packages)
            {
                string pkg = p.Replace("package:", "");
                if (needFilter)
                {
                    if (pkg.Contains(filterName))
                    {
                        this.listViewPackage.Items.Add(pkg);
                    }
                }
                else
                {
                    this.listViewPackage.Items.Add(pkg);
                }
            }
            this.listViewPackage.EndUpdate();
        }

        private void listViewPackage_Resize(object sender, EventArgs e)
        {
            this.listViewPackage.Columns[0].Width = this.listViewPackage.Width;
        }

        private void ToolStripMenuItemDetail_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                const string action = "android.settings.APPLICATION_DETAILS_SETTINGS";
                string param = string.Format("-a {0} -d package:{1}", action, packageName);
                connect.StartAm(param);
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

        private void toolStripMenuItemUninstall_Click(object sender, EventArgs e)
        {
            if (this.listViewPackage.SelectedItems.Count > 0)
            {
                string packageName = this.listViewPackage.SelectedItems[0].Text.Trim();
                connect.Uninstall(packageName);
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

        private void buttonLogcat_Click(object sender, EventArgs e)
        {
            if (logcat == null || logcat.IsDisposed)
            {
                logcat = new FormLogcat();
            }
            logcat.ShowDialog();
        }

        private void buttonDeviceInfo_Click(object sender, EventArgs e)
        {
            const string action = "android.settings.DEVICE_INFO_SETTINGS";
            string param = string.Format("-a {0}", action);
            connect.StartAm(param);
        }

        private void buttonDeveloper_Click(object sender, EventArgs e)
        {
            const string action = "android.settings.APPLICATION_DEVELOPMENT_SETTINGS";
            string param = string.Format("-a {0}", action);
            connect.StartAm(param);
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            AboutBoxKibot aboutBox = new AboutBoxKibot();
            aboutBox.ShowDialog();
        }

        private void pictureBoxBattery_MouseEnter(object sender, EventArgs e)
        {
            if (batterParser != null)
            {
                string info = batterParser.BatteryFormatInfo;
                if (info != null)
                {
                    this.toolTipBattery.SetToolTip(this.pictureBoxBattery, batterParser.BatteryFormatInfo);
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
            string[] values = device.GetCurrentDeviceInfo();
            if (values != null && values.Length == 4)
            {
                this.labelDeviceInfo.Text = values[0];
                this.labelProduct.Text = "Product:" + values[1];
                this.labelModel.Text = "Model:" + values[2];
                this.labelDevice.Text = "Device:" + values[3];
            }
            updateBatteryInfo();
        }

    }
}
