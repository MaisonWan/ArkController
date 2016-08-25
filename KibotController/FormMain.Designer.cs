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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.textBoxSendText = new System.Windows.Forms.TextBox();
            this.buttonDevices = new System.Windows.Forms.Button();
            this.openFileDialogInstall = new System.Windows.Forms.OpenFileDialog();
            this.listViewPackage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.PToolStripMenuItemPackageInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.PToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUninstall = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPackageList = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlDeviceInfo = new System.Windows.Forms.TabControl();
            this.tabPageDeviceInfo = new System.Windows.Forms.TabPage();
            this.tabPageKeyboard = new System.Windows.Forms.TabPage();
            this.tabPagePackage = new System.Windows.Forms.TabPage();
            this.tabPageControl = new System.Windows.Forms.TabPage();
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设备信息IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonVolumeUp = new System.Windows.Forms.Button();
            this.buttonVolumeDown = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonLogcat = new System.Windows.Forms.Button();
            this.buttonDeveloper = new System.Windows.Forms.Button();
            this.buttonScreen = new System.Windows.Forms.Button();
            this.buttonDeviceDetect = new System.Windows.Forms.Button();
            this.buttonDeviceInfo = new System.Windows.Forms.Button();
            this.buttonSystemSetting = new System.Windows.Forms.Button();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripListview.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControlDeviceInfo.SuspendLayout();
            this.tabPageDeviceInfo.SuspendLayout();
            this.tabPageKeyboard.SuspendLayout();
            this.tabPagePackage.SuspendLayout();
            this.tabPageControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLog);
            this.groupBox2.Location = new System.Drawing.Point(17, 631);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1102, 71);
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
            this.textBoxLog.Size = new System.Drawing.Size(1090, 44);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonSendText
            // 
            this.buttonSendText.Location = new System.Drawing.Point(1008, 477);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(75, 23);
            this.buttonSendText.TabIndex = 7;
            this.buttonSendText.Text = "发送文本";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // textBoxSendText
            // 
            this.textBoxSendText.Location = new System.Drawing.Point(7, 477);
            this.textBoxSendText.Name = "textBoxSendText";
            this.textBoxSendText.Size = new System.Drawing.Size(995, 21);
            this.textBoxSendText.TabIndex = 6;
            this.textBoxSendText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSendText_KeyDown);
            // 
            // buttonDevices
            // 
            this.buttonDevices.Location = new System.Drawing.Point(24, 20);
            this.buttonDevices.Name = "buttonDevices";
            this.buttonDevices.Size = new System.Drawing.Size(60, 60);
            this.buttonDevices.TabIndex = 8;
            this.buttonDevices.Text = "查看设备";
            this.buttonDevices.UseVisualStyleBackColor = true;
            this.buttonDevices.Click += new System.EventHandler(this.buttonDevices_Click);
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
            this.listViewPackage.Location = new System.Drawing.Point(7, 44);
            this.listViewPackage.Name = "listViewPackage";
            this.listViewPackage.Size = new System.Drawing.Size(710, 364);
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
            this.PToolStripMenuItemPackageInfo,
            this.PToolStripMenuItemCopy,
            this.toolStripMenuItemUninstall});
            this.contextMenuStripListview.Name = "contextMenuStripListview";
            this.contextMenuStripListview.Size = new System.Drawing.Size(166, 92);
            this.contextMenuStripListview.Text = "删除";
            // 
            // ToolStripMenuItemDetail
            // 
            this.ToolStripMenuItemDetail.Name = "ToolStripMenuItemDetail";
            this.ToolStripMenuItemDetail.Size = new System.Drawing.Size(165, 22);
            this.ToolStripMenuItemDetail.Text = "打开详细信息(&D)";
            this.ToolStripMenuItemDetail.Click += new System.EventHandler(this.ToolStripMenuItemDetail_Click);
            // 
            // PToolStripMenuItemPackageInfo
            // 
            this.PToolStripMenuItemPackageInfo.Name = "PToolStripMenuItemPackageInfo";
            this.PToolStripMenuItemPackageInfo.Size = new System.Drawing.Size(165, 22);
            this.PToolStripMenuItemPackageInfo.Text = "显示包信息(&P)";
            // 
            // PToolStripMenuItemCopy
            // 
            this.PToolStripMenuItemCopy.Name = "PToolStripMenuItemCopy";
            this.PToolStripMenuItemCopy.Size = new System.Drawing.Size(165, 22);
            this.PToolStripMenuItemCopy.Text = "复制(&C)";
            this.PToolStripMenuItemCopy.Click += new System.EventHandler(this.PToolStripMenuItemCopy_Click);
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
            this.buttonPackageList.Location = new System.Drawing.Point(7, 15);
            this.buttonPackageList.Name = "buttonPackageList";
            this.buttonPackageList.Size = new System.Drawing.Size(77, 23);
            this.buttonPackageList.TabIndex = 15;
            this.buttonPackageList.Text = "程序列表";
            this.buttonPackageList.UseVisualStyleBackColor = true;
            this.buttonPackageList.Click += new System.EventHandler(this.buttonPackageList_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(99, 17);
            this.textBoxFilter.MaxLength = 255;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(182, 21);
            this.textBoxFilter.TabIndex = 17;
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Checked = true;
            this.checkBoxFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFilter.Location = new System.Drawing.Point(290, 19);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(48, 16);
            this.checkBoxFilter.TabIndex = 16;
            this.checkBoxFilter.Text = "过滤";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1131, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControlDeviceInfo
            // 
            this.tabControlDeviceInfo.Controls.Add(this.tabPageDeviceInfo);
            this.tabControlDeviceInfo.Controls.Add(this.tabPageKeyboard);
            this.tabControlDeviceInfo.Controls.Add(this.tabPagePackage);
            this.tabControlDeviceInfo.Controls.Add(this.tabPageControl);
            this.tabControlDeviceInfo.ImageList = this.imageListTabs;
            this.tabControlDeviceInfo.ItemSize = new System.Drawing.Size(60, 40);
            this.tabControlDeviceInfo.Location = new System.Drawing.Point(12, 53);
            this.tabControlDeviceInfo.Name = "tabControlDeviceInfo";
            this.tabControlDeviceInfo.SelectedIndex = 0;
            this.tabControlDeviceInfo.ShowToolTips = true;
            this.tabControlDeviceInfo.Size = new System.Drawing.Size(1107, 562);
            this.tabControlDeviceInfo.TabIndex = 7;
            // 
            // tabPageDeviceInfo
            // 
            this.tabPageDeviceInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageDeviceInfo.Controls.Add(this.buttonDevices);
            this.tabPageDeviceInfo.ImageKey = "info.png";
            this.tabPageDeviceInfo.Location = new System.Drawing.Point(4, 44);
            this.tabPageDeviceInfo.Name = "tabPageDeviceInfo";
            this.tabPageDeviceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceInfo.Size = new System.Drawing.Size(1099, 514);
            this.tabPageDeviceInfo.TabIndex = 0;
            this.tabPageDeviceInfo.Text = "设备信息";
            this.tabPageDeviceInfo.ToolTipText = "显示当前设备的基本信息";
            this.tabPageDeviceInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageKeyboard
            // 
            this.tabPageKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageKeyboard.Controls.Add(this.groupBox4);
            this.tabPageKeyboard.Controls.Add(this.groupBox3);
            this.tabPageKeyboard.Controls.Add(this.groupBox1);
            this.tabPageKeyboard.Controls.Add(this.buttonSendText);
            this.tabPageKeyboard.Controls.Add(this.textBoxSendText);
            this.tabPageKeyboard.Controls.Add(this.buttonBack);
            this.tabPageKeyboard.Controls.Add(this.buttonHome);
            this.tabPageKeyboard.ImageKey = "Keyboard.png";
            this.tabPageKeyboard.Location = new System.Drawing.Point(4, 44);
            this.tabPageKeyboard.Name = "tabPageKeyboard";
            this.tabPageKeyboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyboard.Size = new System.Drawing.Size(1099, 514);
            this.tabPageKeyboard.TabIndex = 1;
            this.tabPageKeyboard.Text = "按键控制";
            this.tabPageKeyboard.UseVisualStyleBackColor = true;
            // 
            // tabPagePackage
            // 
            this.tabPagePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPagePackage.Controls.Add(this.checkBoxFilter);
            this.tabPagePackage.Controls.Add(this.textBoxFilter);
            this.tabPagePackage.Controls.Add(this.listViewPackage);
            this.tabPagePackage.Controls.Add(this.buttonPackageList);
            this.tabPagePackage.ImageKey = "point_list.png";
            this.tabPagePackage.Location = new System.Drawing.Point(4, 44);
            this.tabPagePackage.Name = "tabPagePackage";
            this.tabPagePackage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePackage.Size = new System.Drawing.Size(1099, 514);
            this.tabPagePackage.TabIndex = 2;
            this.tabPagePackage.Text = "安装程序";
            this.tabPagePackage.ToolTipText = "列举出来已经安装程序列表";
            this.tabPagePackage.UseVisualStyleBackColor = true;
            // 
            // tabPageControl
            // 
            this.tabPageControl.Controls.Add(this.button1);
            this.tabPageControl.Controls.Add(this.buttonInstall);
            this.tabPageControl.Controls.Add(this.buttonLogcat);
            this.tabPageControl.Controls.Add(this.buttonDeveloper);
            this.tabPageControl.Controls.Add(this.buttonScreen);
            this.tabPageControl.Controls.Add(this.buttonDeviceDetect);
            this.tabPageControl.Controls.Add(this.buttonDeviceInfo);
            this.tabPageControl.Controls.Add(this.buttonSystemSetting);
            this.tabPageControl.ImageKey = "info.png";
            this.tabPageControl.Location = new System.Drawing.Point(4, 44);
            this.tabPageControl.Name = "tabPageControl";
            this.tabPageControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageControl.Size = new System.Drawing.Size(1099, 514);
            this.tabPageControl.TabIndex = 3;
            this.tabPageControl.Text = "系统控制";
            this.tabPageControl.UseVisualStyleBackColor = true;
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "info.png");
            this.imageListTabs.Images.SetKeyName(1, "Keyboard.png");
            this.imageListTabs.Images.SetKeyName(2, "point_list.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设备信息IToolStripMenuItem,
            this.运行信息ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设备信息IToolStripMenuItem
            // 
            this.设备信息IToolStripMenuItem.Name = "设备信息IToolStripMenuItem";
            this.设备信息IToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.设备信息IToolStripMenuItem.Text = "设备信息(&I)";
            // 
            // 运行信息ToolStripMenuItem
            // 
            this.运行信息ToolStripMenuItem.Name = "运行信息ToolStripMenuItem";
            this.运行信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.运行信息ToolStripMenuItem.Text = "运行信息";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(116, 22);
            this.ToolStripMenuItemAbout.Text = "关于(&A)";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCenter);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Location = new System.Drawing.Point(810, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // buttonCenter
            // 
            this.buttonCenter.BackgroundImage = global::KibotController.Properties.Resources.rounded;
            this.buttonCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCenter.Location = new System.Drawing.Point(100, 94);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(60, 60);
            this.buttonCenter.TabIndex = 2;
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::KibotController.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(100, 23);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 60);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::KibotController.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(100, 168);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 60);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::KibotController.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(171, 94);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(60, 60);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::KibotController.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(30, 94);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(60, 60);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonReboot
            // 
            this.buttonReboot.BackgroundImage = global::KibotController.Properties.Resources.rebot;
            this.buttonReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReboot.Location = new System.Drawing.Point(170, 20);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(60, 60);
            this.buttonReboot.TabIndex = 5;
            this.buttonReboot.UseVisualStyleBackColor = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.BackgroundImage = global::KibotController.Properties.Resources.power;
            this.buttonPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPower.Location = new System.Drawing.Point(29, 20);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(60, 60);
            this.buttonPower.TabIndex = 4;
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::KibotController.Properties.Resources.back;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Location = new System.Drawing.Point(28, 31);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 60);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonVolumeUp
            // 
            this.buttonVolumeUp.BackgroundImage = global::KibotController.Properties.Resources.volume_up;
            this.buttonVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolumeUp.Location = new System.Drawing.Point(170, 20);
            this.buttonVolumeUp.Name = "buttonVolumeUp";
            this.buttonVolumeUp.Size = new System.Drawing.Size(60, 60);
            this.buttonVolumeUp.TabIndex = 2;
            this.buttonVolumeUp.UseVisualStyleBackColor = true;
            this.buttonVolumeUp.Click += new System.EventHandler(this.buttonVolumeUp_Click);
            // 
            // buttonVolumeDown
            // 
            this.buttonVolumeDown.AccessibleDescription = "";
            this.buttonVolumeDown.BackgroundImage = global::KibotController.Properties.Resources.volume_down;
            this.buttonVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolumeDown.Location = new System.Drawing.Point(29, 18);
            this.buttonVolumeDown.Name = "buttonVolumeDown";
            this.buttonVolumeDown.Size = new System.Drawing.Size(60, 60);
            this.buttonVolumeDown.TabIndex = 3;
            this.buttonVolumeDown.UseVisualStyleBackColor = true;
            this.buttonVolumeDown.Click += new System.EventHandler(this.buttonVolumeDown_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Location = new System.Drawing.Point(106, 31);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(60, 60);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KibotController.Properties.Resources.usb;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(522, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonRestartAdb_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.AllowDrop = true;
            this.buttonInstall.BackgroundImage = global::KibotController.Properties.Resources.plus39;
            this.buttonInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInstall.Location = new System.Drawing.Point(611, 32);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(60, 60);
            this.buttonInstall.TabIndex = 14;
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            this.buttonInstall.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonInstall_DragDrop);
            this.buttonInstall.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonInstall_DragEnter);
            // 
            // buttonLogcat
            // 
            this.buttonLogcat.BackgroundImage = global::KibotController.Properties.Resources.cmd;
            this.buttonLogcat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogcat.Location = new System.Drawing.Point(429, 32);
            this.buttonLogcat.Name = "buttonLogcat";
            this.buttonLogcat.Size = new System.Drawing.Size(60, 60);
            this.buttonLogcat.TabIndex = 10;
            this.buttonLogcat.UseVisualStyleBackColor = true;
            this.buttonLogcat.Click += new System.EventHandler(this.buttonLogcat_Click);
            // 
            // buttonDeveloper
            // 
            this.buttonDeveloper.BackgroundImage = global::KibotController.Properties.Resources.control_panel;
            this.buttonDeveloper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeveloper.Location = new System.Drawing.Point(254, 32);
            this.buttonDeveloper.Name = "buttonDeveloper";
            this.buttonDeveloper.Size = new System.Drawing.Size(60, 60);
            this.buttonDeveloper.TabIndex = 16;
            this.buttonDeveloper.UseVisualStyleBackColor = true;
            this.buttonDeveloper.Click += new System.EventHandler(this.buttonDeveloper_Click);
            this.buttonDeveloper.MouseEnter += new System.EventHandler(this.buttonDeveloper_MouseEnter);
            // 
            // buttonScreen
            // 
            this.buttonScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonScreen.BackgroundImage")));
            this.buttonScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonScreen.Location = new System.Drawing.Point(344, 32);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(60, 60);
            this.buttonScreen.TabIndex = 9;
            this.buttonScreen.UseVisualStyleBackColor = true;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // buttonDeviceDetect
            // 
            this.buttonDeviceDetect.BackgroundImage = global::KibotController.Properties.Resources.device_hardware;
            this.buttonDeviceDetect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeviceDetect.Location = new System.Drawing.Point(20, 32);
            this.buttonDeviceDetect.Name = "buttonDeviceDetect";
            this.buttonDeviceDetect.Size = new System.Drawing.Size(60, 60);
            this.buttonDeviceDetect.TabIndex = 12;
            this.buttonDeviceDetect.UseVisualStyleBackColor = true;
            this.buttonDeviceDetect.Click += new System.EventHandler(this.buttonDeviceDetect_Click);
            // 
            // buttonDeviceInfo
            // 
            this.buttonDeviceInfo.BackgroundImage = global::KibotController.Properties.Resources.system_information;
            this.buttonDeviceInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeviceInfo.Location = new System.Drawing.Point(179, 32);
            this.buttonDeviceInfo.Name = "buttonDeviceInfo";
            this.buttonDeviceInfo.Size = new System.Drawing.Size(60, 60);
            this.buttonDeviceInfo.TabIndex = 15;
            this.buttonDeviceInfo.UseVisualStyleBackColor = true;
            this.buttonDeviceInfo.Click += new System.EventHandler(this.buttonDeviceInfo_Click);
            // 
            // buttonSystemSetting
            // 
            this.buttonSystemSetting.BackgroundImage = global::KibotController.Properties.Resources.settings_1;
            this.buttonSystemSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSystemSetting.Location = new System.Drawing.Point(99, 32);
            this.buttonSystemSetting.Name = "buttonSystemSetting";
            this.buttonSystemSetting.Size = new System.Drawing.Size(60, 60);
            this.buttonSystemSetting.TabIndex = 13;
            this.buttonSystemSetting.UseVisualStyleBackColor = true;
            this.buttonSystemSetting.Click += new System.EventHandler(this.buttonSystemSetting_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = global::KibotController.Properties.Resources.about;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAbout.Text = "关于";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonReboot);
            this.groupBox3.Controls.Add(this.buttonPower);
            this.groupBox3.Location = new System.Drawing.Point(810, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 97);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 电源";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonVolumeUp);
            this.groupBox4.Controls.Add(this.buttonVolumeDown);
            this.groupBox4.Location = new System.Drawing.Point(810, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 95);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "声音";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 714);
            this.Controls.Add(this.tabControlDeviceInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kobit控制器";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStripListview.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControlDeviceInfo.ResumeLayout(false);
            this.tabPageDeviceInfo.ResumeLayout(false);
            this.tabPageKeyboard.ResumeLayout(false);
            this.tabPageKeyboard.PerformLayout();
            this.tabPagePackage.ResumeLayout(false);
            this.tabPagePackage.PerformLayout();
            this.tabPageControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonVolumeDown;
        private System.Windows.Forms.Button buttonVolumeUp;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonSendText;
        private System.Windows.Forms.TextBox textBoxSendText;
        private System.Windows.Forms.Button buttonDevices;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.OpenFileDialog openFileDialogInstall;
        private System.Windows.Forms.Button buttonDeviceDetect;
        private System.Windows.Forms.Button buttonSystemSetting;
        private System.Windows.Forms.Button buttonLogcat;
        private System.Windows.Forms.Button buttonPackageList;
        private System.Windows.Forms.ListView listViewPackage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListview;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUninstall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDetail;
        private System.Windows.Forms.Button buttonDeviceInfo;
        private System.Windows.Forms.Button buttonDeveloper;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private System.Windows.Forms.ToolStripMenuItem PToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripMenuItem PToolStripMenuItemPackageInfo;
        private System.Windows.Forms.Button buttonScreen;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.TabControl tabControlDeviceInfo;
        private System.Windows.Forms.TabPage tabPageDeviceInfo;
        private System.Windows.Forms.TabPage tabPageKeyboard;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.TabPage tabPagePackage;
        private System.Windows.Forms.TabPage tabPageControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设备信息IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

