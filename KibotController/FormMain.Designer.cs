namespace KibotController
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonVolumeDown = new System.Windows.Forms.Button();
            this.buttonVolumeUp = new System.Windows.Forms.Button();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.textBoxSendText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogcat = new System.Windows.Forms.Button();
            this.buttonScreen = new System.Windows.Forms.Button();
            this.buttonDevices = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDeveloper = new System.Windows.Forms.Button();
            this.buttonDeviceInfo = new System.Windows.Forms.Button();
            this.buttonSystemSetting = new System.Windows.Forms.Button();
            this.buttonDeviceDetect = new System.Windows.Forms.Button();
            this.openFileDialogInstall = new System.Windows.Forms.OpenFileDialog();
            this.listViewPackage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUninstall = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPackageList = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.PToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStripListview.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPower);
            this.groupBox1.Controls.Add(this.buttonVolumeDown);
            this.groupBox1.Controls.Add(this.buttonVolumeUp);
            this.groupBox1.Controls.Add(this.buttonReboot);
            this.groupBox1.Controls.Add(this.buttonHome);
            this.groupBox1.Controls.Add(this.buttonBack);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按键";
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(567, 32);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(75, 23);
            this.buttonPower.TabIndex = 4;
            this.buttonPower.Text = "电源";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // buttonVolumeDown
            // 
            this.buttonVolumeDown.Location = new System.Drawing.Point(471, 32);
            this.buttonVolumeDown.Name = "buttonVolumeDown";
            this.buttonVolumeDown.Size = new System.Drawing.Size(75, 23);
            this.buttonVolumeDown.TabIndex = 3;
            this.buttonVolumeDown.Text = "声音小";
            this.buttonVolumeDown.UseVisualStyleBackColor = true;
            this.buttonVolumeDown.Click += new System.EventHandler(this.buttonVolumeDown_Click);
            // 
            // buttonVolumeUp
            // 
            this.buttonVolumeUp.Location = new System.Drawing.Point(370, 32);
            this.buttonVolumeUp.Name = "buttonVolumeUp";
            this.buttonVolumeUp.Size = new System.Drawing.Size(75, 23);
            this.buttonVolumeUp.TabIndex = 2;
            this.buttonVolumeUp.Text = "声音大";
            this.buttonVolumeUp.UseVisualStyleBackColor = true;
            this.buttonVolumeUp.Click += new System.EventHandler(this.buttonVolumeUp_Click);
            // 
            // buttonReboot
            // 
            this.buttonReboot.Location = new System.Drawing.Point(663, 32);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(75, 23);
            this.buttonReboot.TabIndex = 5;
            this.buttonReboot.Text = "重启";
            this.buttonReboot.UseVisualStyleBackColor = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(136, 32);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "主页";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(24, 32);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "返回";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLog);
            this.groupBox2.Location = new System.Drawing.Point(13, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行日志";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLog.Location = new System.Drawing.Point(6, 20);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(749, 164);
            this.textBoxLog.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSendText);
            this.groupBox3.Controls.Add(this.textBoxSendText);
            this.groupBox3.Location = new System.Drawing.Point(12, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文本";
            // 
            // buttonSendText
            // 
            this.buttonSendText.Location = new System.Drawing.Point(664, 33);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(75, 23);
            this.buttonSendText.TabIndex = 7;
            this.buttonSendText.Text = "发送文本";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // textBoxSendText
            // 
            this.textBoxSendText.Location = new System.Drawing.Point(24, 35);
            this.textBoxSendText.Name = "textBoxSendText";
            this.textBoxSendText.Size = new System.Drawing.Size(618, 21);
            this.textBoxSendText.TabIndex = 6;
            this.textBoxSendText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSendText_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.buttonLogcat);
            this.groupBox4.Controls.Add(this.buttonScreen);
            this.groupBox4.Controls.Add(this.buttonDevices);
            this.groupBox4.Location = new System.Drawing.Point(12, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(762, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "系统";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "重启Adb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonRestartAdb_Click);
            // 
            // buttonLogcat
            // 
            this.buttonLogcat.Location = new System.Drawing.Point(215, 37);
            this.buttonLogcat.Name = "buttonLogcat";
            this.buttonLogcat.Size = new System.Drawing.Size(75, 23);
            this.buttonLogcat.TabIndex = 10;
            this.buttonLogcat.Text = "Logcat";
            this.buttonLogcat.UseVisualStyleBackColor = true;
            this.buttonLogcat.Click += new System.EventHandler(this.buttonLogcat_Click);
            // 
            // buttonScreen
            // 
            this.buttonScreen.Location = new System.Drawing.Point(119, 37);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(75, 23);
            this.buttonScreen.TabIndex = 9;
            this.buttonScreen.Text = "屏幕截图";
            this.buttonScreen.UseVisualStyleBackColor = true;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // buttonDevices
            // 
            this.buttonDevices.Location = new System.Drawing.Point(24, 37);
            this.buttonDevices.Name = "buttonDevices";
            this.buttonDevices.Size = new System.Drawing.Size(75, 23);
            this.buttonDevices.TabIndex = 8;
            this.buttonDevices.Text = "查看设备";
            this.buttonDevices.UseVisualStyleBackColor = true;
            this.buttonDevices.Click += new System.EventHandler(this.buttonDevices_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDeveloper);
            this.groupBox5.Controls.Add(this.buttonDeviceInfo);
            this.groupBox5.Controls.Add(this.buttonSystemSetting);
            this.groupBox5.Controls.Add(this.buttonDeviceDetect);
            this.groupBox5.Controls.Add(this.buttonInstall);
            this.groupBox5.Location = new System.Drawing.Point(13, 294);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(762, 212);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "程序";
            // 
            // buttonDeveloper
            // 
            this.buttonDeveloper.Location = new System.Drawing.Point(313, 20);
            this.buttonDeveloper.Name = "buttonDeveloper";
            this.buttonDeveloper.Size = new System.Drawing.Size(75, 23);
            this.buttonDeveloper.TabIndex = 16;
            this.buttonDeveloper.Text = "开发者选项";
            this.buttonDeveloper.UseVisualStyleBackColor = true;
            this.buttonDeveloper.Click += new System.EventHandler(this.buttonDeveloper_Click);
            // 
            // buttonDeviceInfo
            // 
            this.buttonDeviceInfo.Location = new System.Drawing.Point(214, 21);
            this.buttonDeviceInfo.Name = "buttonDeviceInfo";
            this.buttonDeviceInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonDeviceInfo.TabIndex = 15;
            this.buttonDeviceInfo.Text = "设备信息";
            this.buttonDeviceInfo.UseVisualStyleBackColor = true;
            this.buttonDeviceInfo.Click += new System.EventHandler(this.buttonDeviceInfo_Click);
            // 
            // buttonSystemSetting
            // 
            this.buttonSystemSetting.Location = new System.Drawing.Point(119, 21);
            this.buttonSystemSetting.Name = "buttonSystemSetting";
            this.buttonSystemSetting.Size = new System.Drawing.Size(75, 23);
            this.buttonSystemSetting.TabIndex = 13;
            this.buttonSystemSetting.Text = "系统设置";
            this.buttonSystemSetting.UseVisualStyleBackColor = true;
            this.buttonSystemSetting.Click += new System.EventHandler(this.buttonSystemSetting_Click);
            // 
            // buttonDeviceDetect
            // 
            this.buttonDeviceDetect.Location = new System.Drawing.Point(24, 21);
            this.buttonDeviceDetect.Name = "buttonDeviceDetect";
            this.buttonDeviceDetect.Size = new System.Drawing.Size(75, 23);
            this.buttonDeviceDetect.TabIndex = 12;
            this.buttonDeviceDetect.Text = "硬件检测";
            this.buttonDeviceDetect.UseVisualStyleBackColor = true;
            this.buttonDeviceDetect.Click += new System.EventHandler(this.buttonDeviceDetect_Click);
            // 
            // openFileDialogInstall
            // 
            this.openFileDialogInstall.FileName = "openFileDialog1";
            // 
            // listViewPackage
            // 
            this.listViewPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewPackage.ContextMenuStrip = this.contextMenuStripListview;
            this.listViewPackage.FullRowSelect = true;
            this.listViewPackage.GridLines = true;
            this.listViewPackage.Location = new System.Drawing.Point(12, 55);
            this.listViewPackage.Name = "listViewPackage";
            this.listViewPackage.Size = new System.Drawing.Size(326, 615);
            this.listViewPackage.TabIndex = 2;
            this.listViewPackage.UseCompatibleStateImageBehavior = false;
            this.listViewPackage.View = System.Windows.Forms.View.Details;
            this.listViewPackage.Resize += new System.EventHandler(this.listViewPackage_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "包名";
            this.columnHeader1.Width = 322;
            // 
            // contextMenuStripListview
            // 
            this.contextMenuStripListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDetail,
            this.PToolStripMenuItemCopy,
            this.toolStripMenuItemUninstall});
            this.contextMenuStripListview.Name = "contextMenuStripListview";
            this.contextMenuStripListview.Size = new System.Drawing.Size(166, 70);
            this.contextMenuStripListview.Text = "删除";
            // 
            // ToolStripMenuItemDetail
            // 
            this.ToolStripMenuItemDetail.Name = "ToolStripMenuItemDetail";
            this.ToolStripMenuItemDetail.Size = new System.Drawing.Size(165, 22);
            this.ToolStripMenuItemDetail.Text = "详细程序信息(&D)";
            this.ToolStripMenuItemDetail.Click += new System.EventHandler(this.ToolStripMenuItemDetail_Click);
            // 
            // toolStripMenuItemUninstall
            // 
            this.toolStripMenuItemUninstall.Name = "toolStripMenuItemUninstall";
            this.toolStripMenuItemUninstall.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemUninstall.Text = "卸载(&U)";
            this.toolStripMenuItemUninstall.Click += new System.EventHandler(this.toolStripMenuItemUninstall_Click);
            // 
            // buttonPackageList
            // 
            this.buttonPackageList.Location = new System.Drawing.Point(12, 20);
            this.buttonPackageList.Name = "buttonPackageList";
            this.buttonPackageList.Size = new System.Drawing.Size(77, 23);
            this.buttonPackageList.TabIndex = 15;
            this.buttonPackageList.Text = "程序列表";
            this.buttonPackageList.UseVisualStyleBackColor = true;
            this.buttonPackageList.Click += new System.EventHandler(this.buttonPackageList_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxFilter);
            this.groupBox6.Controls.Add(this.checkBoxFilter);
            this.groupBox6.Controls.Add(this.listViewPackage);
            this.groupBox6.Controls.Add(this.buttonPackageList);
            this.groupBox6.Location = new System.Drawing.Point(781, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(338, 676);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "安装程序";
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Checked = true;
            this.checkBoxFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFilter.Location = new System.Drawing.Point(284, 22);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(48, 16);
            this.checkBoxFilter.TabIndex = 16;
            this.checkBoxFilter.Text = "过滤";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(95, 20);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(182, 21);
            this.textBoxFilter.TabIndex = 17;
            // 
            // PToolStripMenuItemCopy
            // 
            this.PToolStripMenuItemCopy.Name = "PToolStripMenuItemCopy";
            this.PToolStripMenuItemCopy.Size = new System.Drawing.Size(165, 22);
            this.PToolStripMenuItemCopy.Text = "复制(&C)";
            this.PToolStripMenuItemCopy.Click += new System.EventHandler(this.PToolStripMenuItemCopy_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.AllowDrop = true;
            this.buttonInstall.BackgroundImage = global::KibotController.Properties.Resources.plus39;
            this.buttonInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInstall.Location = new System.Drawing.Point(23, 73);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(120, 120);
            this.buttonInstall.TabIndex = 14;
            this.buttonInstall.Text = "button1";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            this.buttonInstall.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonInstall_DragDrop);
            this.buttonInstall.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonInstall_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 714);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kobit控制器";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.contextMenuStripListview.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonVolumeDown;
        private System.Windows.Forms.Button buttonVolumeUp;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSendText;
        private System.Windows.Forms.TextBox textBoxSendText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonDevices;
        private System.Windows.Forms.Button buttonScreen;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.OpenFileDialog openFileDialogInstall;
        private System.Windows.Forms.Button buttonDeviceDetect;
        private System.Windows.Forms.Button buttonSystemSetting;
        private System.Windows.Forms.Button buttonLogcat;
        private System.Windows.Forms.Button buttonPackageList;
        private System.Windows.Forms.ListView listViewPackage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListview;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUninstall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDetail;
        private System.Windows.Forms.Button buttonDeviceInfo;
        private System.Windows.Forms.Button buttonDeveloper;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private System.Windows.Forms.ToolStripMenuItem PToolStripMenuItemCopy;
    }
}

