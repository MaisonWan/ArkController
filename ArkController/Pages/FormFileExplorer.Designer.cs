namespace ArkController.Pages
{
    partial class FormFileExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("内置存储", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("内置SD卡", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileExplorer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mToolStripMenuItemExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListFile = new System.Windows.Forms.ImageList(this.components);
            this.listViewExplorer = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripExplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemExplorerRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExplorerRefresh = new System.Windows.Forms.Button();
            this.buttonPushFile = new System.Windows.Forms.Button();
            this.buttonBackFolder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.labelFileDatetime = new System.Windows.Forms.Label();
            this.labelFileDesc = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.pictureBoxFileIcon = new System.Windows.Forms.PictureBox();
            this.imageListLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripTree.SuspendLayout();
            this.contextMenuStripExplorer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewMenu);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewExplorer);
            this.splitContainer1.Size = new System.Drawing.Size(846, 632);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.ContextMenuStrip = this.contextMenuStripTree;
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.ImageKey = "folder.png";
            this.treeViewMenu.ImageList = this.imageListFile;
            this.treeViewMenu.ItemHeight = 22;
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode5.Name = "节点0";
            treeNode5.Text = "";
            treeNode6.ImageKey = "(默认值)";
            treeNode6.Name = "innerStorage";
            treeNode6.SelectedImageKey = "(默认值)";
            treeNode6.StateImageKey = "folder.png";
            treeNode6.Tag = "/";
            treeNode6.Text = "内置存储";
            treeNode7.Name = "节点2";
            treeNode7.Text = "";
            treeNode8.Name = "innerSDCard";
            treeNode8.SelectedImageKey = "(默认值)";
            treeNode8.StateImageKey = "folder.png";
            treeNode8.Tag = "/sdcard/";
            treeNode8.Text = "内置SD卡";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode8});
            this.treeViewMenu.SelectedImageKey = "folder.png";
            this.treeViewMenu.Size = new System.Drawing.Size(200, 632);
            this.treeViewMenu.TabIndex = 0;
            this.treeViewMenu.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterExpand);
            this.treeViewMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMenu_NodeMouseClick);
            // 
            // contextMenuStripTree
            // 
            this.contextMenuStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemExpand,
            this.mToolStripMenuItemRefresh});
            this.contextMenuStripTree.Name = "contextMenuStripTree";
            this.contextMenuStripTree.Size = new System.Drawing.Size(120, 48);
            this.contextMenuStripTree.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTree_Opening);
            // 
            // mToolStripMenuItemExpand
            // 
            this.mToolStripMenuItemExpand.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.mToolStripMenuItemExpand.Name = "mToolStripMenuItemExpand";
            this.mToolStripMenuItemExpand.Size = new System.Drawing.Size(119, 22);
            this.mToolStripMenuItemExpand.Text = "展开(&A)";
            this.mToolStripMenuItemExpand.Click += new System.EventHandler(this.mToolStripMenuItemExpand_Click);
            // 
            // mToolStripMenuItemRefresh
            // 
            this.mToolStripMenuItemRefresh.Name = "mToolStripMenuItemRefresh";
            this.mToolStripMenuItemRefresh.Size = new System.Drawing.Size(119, 22);
            this.mToolStripMenuItemRefresh.Text = "刷新(&R)";
            this.mToolStripMenuItemRefresh.Click += new System.EventHandler(this.mToolStripMenuItemRefresh_Click);
            // 
            // imageListFile
            // 
            this.imageListFile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFile.ImageStream")));
            this.imageListFile.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFile.Images.SetKeyName(0, "disk.png");
            this.imageListFile.Images.SetKeyName(1, "folder.png");
            this.imageListFile.Images.SetKeyName(2, "folder_open.png");
            this.imageListFile.Images.SetKeyName(3, "ac3.png");
            this.imageListFile.Images.SetKeyName(4, "ai.png");
            this.imageListFile.Images.SetKeyName(5, "aiff.png");
            this.imageListFile.Images.SetKeyName(6, "ani.png");
            this.imageListFile.Images.SetKeyName(7, "asf.png");
            this.imageListFile.Images.SetKeyName(8, "au.png");
            this.imageListFile.Images.SetKeyName(9, "avi.png");
            this.imageListFile.Images.SetKeyName(10, "bat.png");
            this.imageListFile.Images.SetKeyName(11, "bin.png");
            this.imageListFile.Images.SetKeyName(12, "bmp.png");
            this.imageListFile.Images.SetKeyName(13, "bup.png");
            this.imageListFile.Images.SetKeyName(14, "cab.png");
            this.imageListFile.Images.SetKeyName(15, "cal.png");
            this.imageListFile.Images.SetKeyName(16, "cat.png");
            this.imageListFile.Images.SetKeyName(17, "cur.png");
            this.imageListFile.Images.SetKeyName(18, "dat.png");
            this.imageListFile.Images.SetKeyName(19, "dcr.png");
            this.imageListFile.Images.SetKeyName(20, "der.png");
            this.imageListFile.Images.SetKeyName(21, "dic.png");
            this.imageListFile.Images.SetKeyName(22, "dll.png");
            this.imageListFile.Images.SetKeyName(23, "doc.png");
            this.imageListFile.Images.SetKeyName(24, "docx.png");
            this.imageListFile.Images.SetKeyName(25, "dvd.png");
            this.imageListFile.Images.SetKeyName(26, "dwg.png");
            this.imageListFile.Images.SetKeyName(27, "dwt.png");
            this.imageListFile.Images.SetKeyName(28, "fon.png");
            this.imageListFile.Images.SetKeyName(29, "gif.png");
            this.imageListFile.Images.SetKeyName(30, "hlp.png");
            this.imageListFile.Images.SetKeyName(31, "hst.png");
            this.imageListFile.Images.SetKeyName(32, "html.png");
            this.imageListFile.Images.SetKeyName(33, "ico.png");
            this.imageListFile.Images.SetKeyName(34, "ifo.png");
            this.imageListFile.Images.SetKeyName(35, "inf.png");
            this.imageListFile.Images.SetKeyName(36, "ini.png");
            this.imageListFile.Images.SetKeyName(37, "java.png");
            this.imageListFile.Images.SetKeyName(38, "jif.png");
            this.imageListFile.Images.SetKeyName(39, "jpg.png");
            this.imageListFile.Images.SetKeyName(40, "log.png");
            this.imageListFile.Images.SetKeyName(41, "m4a.png");
            this.imageListFile.Images.SetKeyName(42, "mmf.png");
            this.imageListFile.Images.SetKeyName(43, "mmm.png");
            this.imageListFile.Images.SetKeyName(44, "mov.png");
            this.imageListFile.Images.SetKeyName(45, "mp2.png");
            this.imageListFile.Images.SetKeyName(46, "mp2v.png");
            this.imageListFile.Images.SetKeyName(47, "mp3.png");
            this.imageListFile.Images.SetKeyName(48, "mp4.png");
            this.imageListFile.Images.SetKeyName(49, "mpeg.png");
            this.imageListFile.Images.SetKeyName(50, "msp.png");
            this.imageListFile.Images.SetKeyName(51, "pdf.png");
            this.imageListFile.Images.SetKeyName(52, "png.png");
            this.imageListFile.Images.SetKeyName(53, "ppt.png");
            this.imageListFile.Images.SetKeyName(54, "pptx.png");
            this.imageListFile.Images.SetKeyName(55, "psd.png");
            this.imageListFile.Images.SetKeyName(56, "ra.png");
            this.imageListFile.Images.SetKeyName(57, "rar.png");
            this.imageListFile.Images.SetKeyName(58, "reg.png");
            this.imageListFile.Images.SetKeyName(59, "rtf.png");
            this.imageListFile.Images.SetKeyName(60, "theme.png");
            this.imageListFile.Images.SetKeyName(61, "tiff.png");
            this.imageListFile.Images.SetKeyName(62, "tlb.png");
            this.imageListFile.Images.SetKeyName(63, "ttf.png");
            this.imageListFile.Images.SetKeyName(64, "txt.png");
            this.imageListFile.Images.SetKeyName(65, "vob.png");
            this.imageListFile.Images.SetKeyName(66, "wav.png");
            this.imageListFile.Images.SetKeyName(67, "wma.png");
            this.imageListFile.Images.SetKeyName(68, "wmv.png");
            this.imageListFile.Images.SetKeyName(69, "wpl.png");
            this.imageListFile.Images.SetKeyName(70, "wri.png");
            this.imageListFile.Images.SetKeyName(71, "xls.png");
            this.imageListFile.Images.SetKeyName(72, "xlsx.png");
            this.imageListFile.Images.SetKeyName(73, "xml.png");
            this.imageListFile.Images.SetKeyName(74, "xsl.png");
            this.imageListFile.Images.SetKeyName(75, "zip.png");
            // 
            // listViewExplorer
            // 
            this.listViewExplorer.AllowDrop = true;
            this.listViewExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderDatetime,
            this.columnHeaderType});
            this.listViewExplorer.ContextMenuStrip = this.contextMenuStripExplorer;
            this.listViewExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExplorer.FullRowSelect = true;
            this.listViewExplorer.LabelEdit = true;
            this.listViewExplorer.Location = new System.Drawing.Point(0, 0);
            this.listViewExplorer.Name = "listViewExplorer";
            this.listViewExplorer.Size = new System.Drawing.Size(642, 632);
            this.listViewExplorer.SmallImageList = this.imageListFile;
            this.listViewExplorer.TabIndex = 0;
            this.listViewExplorer.UseCompatibleStateImageBehavior = false;
            this.listViewExplorer.View = System.Windows.Forms.View.Details;
            this.listViewExplorer.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewExplorer_AfterLabelEdit);
            this.listViewExplorer.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewExplorer_BeforeLabelEdit);
            this.listViewExplorer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewExplorer_ColumnClick);
            this.listViewExplorer.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewExplorer_ItemDrag);
            this.listViewExplorer.SelectedIndexChanged += new System.EventHandler(this.listViewExplorer_SelectedIndexChanged);
            this.listViewExplorer.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewExplorer_DragDrop);
            this.listViewExplorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewExplorer_DragEnter);
            this.listViewExplorer.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewExplorer_DragOver);
            this.listViewExplorer.DragLeave += new System.EventHandler(this.listViewExplorer_DragLeave);
            this.listViewExplorer.DoubleClick += new System.EventHandler(this.listViewExplorer_DoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "名称";
            this.columnHeaderName.Width = 256;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "大小";
            this.columnHeaderSize.Width = 127;
            // 
            // columnHeaderDatetime
            // 
            this.columnHeaderDatetime.Text = "日期";
            this.columnHeaderDatetime.Width = 126;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "类型";
            this.columnHeaderType.Width = 125;
            // 
            // contextMenuStripExplorer
            // 
            this.contextMenuStripExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemOpen,
            this.mToolStripMenuItemCopy,
            this.mToolStripMenuItemExport,
            this.mToolStripMenuItemDelete,
            this.mToolStripMenuItemRename,
            this.mToolStripMenuItemExplorerRefresh});
            this.contextMenuStripExplorer.Name = "contextMenuStripExplorer";
            this.contextMenuStripExplorer.Size = new System.Drawing.Size(162, 136);
            // 
            // mToolStripMenuItemOpen
            // 
            this.mToolStripMenuItemOpen.Name = "mToolStripMenuItemOpen";
            this.mToolStripMenuItemOpen.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemOpen.Text = "打开(&O)";
            this.mToolStripMenuItemOpen.Click += new System.EventHandler(this.mToolStripMenuItemOpen_Click);
            // 
            // mToolStripMenuItemCopy
            // 
            this.mToolStripMenuItemCopy.Name = "mToolStripMenuItemCopy";
            this.mToolStripMenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mToolStripMenuItemCopy.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemCopy.Text = "复制(&C)";
            // 
            // mToolStripMenuItemExport
            // 
            this.mToolStripMenuItemExport.Name = "mToolStripMenuItemExport";
            this.mToolStripMenuItemExport.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemExport.Text = "导出(&Z)";
            this.mToolStripMenuItemExport.Click += new System.EventHandler(this.mToolStripMenuItemExport_Click);
            // 
            // mToolStripMenuItemDelete
            // 
            this.mToolStripMenuItemDelete.Name = "mToolStripMenuItemDelete";
            this.mToolStripMenuItemDelete.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemDelete.Text = "删除(&D)";
            this.mToolStripMenuItemDelete.Click += new System.EventHandler(this.mToolStripMenuItemDelete_Click);
            // 
            // mToolStripMenuItemRename
            // 
            this.mToolStripMenuItemRename.Name = "mToolStripMenuItemRename";
            this.mToolStripMenuItemRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mToolStripMenuItemRename.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemRename.Text = "重命名(&W)";
            this.mToolStripMenuItemRename.Click += new System.EventHandler(this.mToolStripMenuItemRename_Click);
            // 
            // mToolStripMenuItemExplorerRefresh
            // 
            this.mToolStripMenuItemExplorerRefresh.Name = "mToolStripMenuItemExplorerRefresh";
            this.mToolStripMenuItemExplorerRefresh.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemExplorerRefresh.Text = "刷新(&R)";
            this.mToolStripMenuItemExplorerRefresh.Click += new System.EventHandler(this.mToolStripMenuItemExplorerRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExplorerRefresh);
            this.panel1.Controls.Add(this.buttonPushFile);
            this.panel1.Controls.Add(this.buttonBackFolder);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 27);
            this.panel1.TabIndex = 1;
            // 
            // buttonExplorerRefresh
            // 
            this.buttonExplorerRefresh.Image = global::ArkController.Properties.Resources.refresh;
            this.buttonExplorerRefresh.Location = new System.Drawing.Point(761, 1);
            this.buttonExplorerRefresh.Name = "buttonExplorerRefresh";
            this.buttonExplorerRefresh.Size = new System.Drawing.Size(82, 26);
            this.buttonExplorerRefresh.TabIndex = 0;
            this.buttonExplorerRefresh.Text = "刷新";
            this.buttonExplorerRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExplorerRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExplorerRefresh.UseVisualStyleBackColor = true;
            this.buttonExplorerRefresh.Click += new System.EventHandler(this.buttonExplorerRefresh_Click);
            // 
            // buttonPushFile
            // 
            this.buttonPushFile.Image = global::ArkController.Properties.Resources.badge_plus;
            this.buttonPushFile.Location = new System.Drawing.Point(204, 0);
            this.buttonPushFile.Name = "buttonPushFile";
            this.buttonPushFile.Size = new System.Drawing.Size(105, 26);
            this.buttonPushFile.TabIndex = 0;
            this.buttonPushFile.Text = "上传到设备";
            this.buttonPushFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPushFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPushFile.UseVisualStyleBackColor = true;
            this.buttonPushFile.Click += new System.EventHandler(this.buttonPushFile_Click);
            // 
            // buttonBackFolder
            // 
            this.buttonBackFolder.Image = global::ArkController.Properties.Resources.arrow_return;
            this.buttonBackFolder.Location = new System.Drawing.Point(9, 0);
            this.buttonBackFolder.Name = "buttonBackFolder";
            this.buttonBackFolder.Size = new System.Drawing.Size(105, 26);
            this.buttonBackFolder.TabIndex = 0;
            this.buttonBackFolder.Text = "返回上一层";
            this.buttonBackFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBackFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBackFolder.UseVisualStyleBackColor = true;
            this.buttonBackFolder.Click += new System.EventHandler(this.buttonBackFolder_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelFileSize);
            this.panel2.Controls.Add(this.labelFileDatetime);
            this.panel2.Controls.Add(this.labelFileDesc);
            this.panel2.Controls.Add(this.labelFileName);
            this.panel2.Controls.Add(this.pictureBoxFileIcon);
            this.panel2.Location = new System.Drawing.Point(3, 673);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 56);
            this.panel2.TabIndex = 4;
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(204, 37);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(0, 12);
            this.labelFileSize.TabIndex = 4;
            // 
            // labelFileDatetime
            // 
            this.labelFileDatetime.AutoSize = true;
            this.labelFileDatetime.Location = new System.Drawing.Point(204, 11);
            this.labelFileDatetime.Name = "labelFileDatetime";
            this.labelFileDatetime.Size = new System.Drawing.Size(0, 12);
            this.labelFileDatetime.TabIndex = 3;
            // 
            // labelFileDesc
            // 
            this.labelFileDesc.AutoSize = true;
            this.labelFileDesc.Location = new System.Drawing.Point(69, 38);
            this.labelFileDesc.Name = "labelFileDesc";
            this.labelFileDesc.Size = new System.Drawing.Size(0, 12);
            this.labelFileDesc.TabIndex = 2;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(69, 12);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 12);
            this.labelFileName.TabIndex = 1;
            // 
            // pictureBoxFileIcon
            // 
            this.pictureBoxFileIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFileIcon.Name = "pictureBoxFileIcon";
            this.pictureBoxFileIcon.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFileIcon.TabIndex = 0;
            this.pictureBoxFileIcon.TabStop = false;
            // 
            // imageListLargeIcon
            // 
            this.imageListLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLargeIcon.ImageStream")));
            this.imageListLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLargeIcon.Images.SetKeyName(0, "folder.png");
            this.imageListLargeIcon.Images.SetKeyName(1, "ac3.png");
            this.imageListLargeIcon.Images.SetKeyName(2, "ai.png");
            this.imageListLargeIcon.Images.SetKeyName(3, "aiff.png");
            this.imageListLargeIcon.Images.SetKeyName(4, "ani.png");
            this.imageListLargeIcon.Images.SetKeyName(5, "asf.png");
            this.imageListLargeIcon.Images.SetKeyName(6, "au.png");
            this.imageListLargeIcon.Images.SetKeyName(7, "avi.png");
            this.imageListLargeIcon.Images.SetKeyName(8, "bat.png");
            this.imageListLargeIcon.Images.SetKeyName(9, "bin.png");
            this.imageListLargeIcon.Images.SetKeyName(10, "bmp.png");
            this.imageListLargeIcon.Images.SetKeyName(11, "bup.png");
            this.imageListLargeIcon.Images.SetKeyName(12, "cab.png");
            this.imageListLargeIcon.Images.SetKeyName(13, "cal.png");
            this.imageListLargeIcon.Images.SetKeyName(14, "cat.png");
            this.imageListLargeIcon.Images.SetKeyName(15, "cur.png");
            this.imageListLargeIcon.Images.SetKeyName(16, "dat.png");
            this.imageListLargeIcon.Images.SetKeyName(17, "dcr.png");
            this.imageListLargeIcon.Images.SetKeyName(18, "der.png");
            this.imageListLargeIcon.Images.SetKeyName(19, "dic.png");
            this.imageListLargeIcon.Images.SetKeyName(20, "dll.png");
            this.imageListLargeIcon.Images.SetKeyName(21, "doc.png");
            this.imageListLargeIcon.Images.SetKeyName(22, "docx.png");
            this.imageListLargeIcon.Images.SetKeyName(23, "dvd.png");
            this.imageListLargeIcon.Images.SetKeyName(24, "dwg.png");
            this.imageListLargeIcon.Images.SetKeyName(25, "dwt.png");
            this.imageListLargeIcon.Images.SetKeyName(26, "fon.png");
            this.imageListLargeIcon.Images.SetKeyName(27, "gif.png");
            this.imageListLargeIcon.Images.SetKeyName(28, "hlp.png");
            this.imageListLargeIcon.Images.SetKeyName(29, "hst.png");
            this.imageListLargeIcon.Images.SetKeyName(30, "html.png");
            this.imageListLargeIcon.Images.SetKeyName(31, "ico.png");
            this.imageListLargeIcon.Images.SetKeyName(32, "ifo.png");
            this.imageListLargeIcon.Images.SetKeyName(33, "inf.png");
            this.imageListLargeIcon.Images.SetKeyName(34, "ini.png");
            this.imageListLargeIcon.Images.SetKeyName(35, "java.png");
            this.imageListLargeIcon.Images.SetKeyName(36, "jif.png");
            this.imageListLargeIcon.Images.SetKeyName(37, "jpg.png");
            this.imageListLargeIcon.Images.SetKeyName(38, "log.png");
            this.imageListLargeIcon.Images.SetKeyName(39, "m4a.png");
            this.imageListLargeIcon.Images.SetKeyName(40, "mmf.png");
            this.imageListLargeIcon.Images.SetKeyName(41, "mmm.png");
            this.imageListLargeIcon.Images.SetKeyName(42, "mov.png");
            this.imageListLargeIcon.Images.SetKeyName(43, "mp2.png");
            this.imageListLargeIcon.Images.SetKeyName(44, "mp2v.png");
            this.imageListLargeIcon.Images.SetKeyName(45, "mp3.png");
            this.imageListLargeIcon.Images.SetKeyName(46, "mp4.png");
            this.imageListLargeIcon.Images.SetKeyName(47, "mpeg.png");
            this.imageListLargeIcon.Images.SetKeyName(48, "msp.png");
            this.imageListLargeIcon.Images.SetKeyName(49, "pdf.png");
            this.imageListLargeIcon.Images.SetKeyName(50, "png.png");
            this.imageListLargeIcon.Images.SetKeyName(51, "ppt.png");
            this.imageListLargeIcon.Images.SetKeyName(52, "pptx.png");
            this.imageListLargeIcon.Images.SetKeyName(53, "psd.png");
            this.imageListLargeIcon.Images.SetKeyName(54, "ra.png");
            this.imageListLargeIcon.Images.SetKeyName(55, "rar.png");
            this.imageListLargeIcon.Images.SetKeyName(56, "reg.png");
            this.imageListLargeIcon.Images.SetKeyName(57, "rtf.png");
            this.imageListLargeIcon.Images.SetKeyName(58, "theme.png");
            this.imageListLargeIcon.Images.SetKeyName(59, "tiff.png");
            this.imageListLargeIcon.Images.SetKeyName(60, "tlb.png");
            this.imageListLargeIcon.Images.SetKeyName(61, "ttf.png");
            this.imageListLargeIcon.Images.SetKeyName(62, "txt.png");
            this.imageListLargeIcon.Images.SetKeyName(63, "vob.png");
            this.imageListLargeIcon.Images.SetKeyName(64, "wav.png");
            this.imageListLargeIcon.Images.SetKeyName(65, "wma.png");
            this.imageListLargeIcon.Images.SetKeyName(66, "wmv.png");
            this.imageListLargeIcon.Images.SetKeyName(67, "wpl.png");
            this.imageListLargeIcon.Images.SetKeyName(68, "wri.png");
            this.imageListLargeIcon.Images.SetKeyName(69, "xls.png");
            this.imageListLargeIcon.Images.SetKeyName(70, "xlsx.png");
            this.imageListLargeIcon.Images.SetKeyName(71, "xml.png");
            this.imageListLargeIcon.Images.SetKeyName(72, "xsl.png");
            this.imageListLargeIcon.Images.SetKeyName(73, "zip.png");
            // 
            // FormFileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFileExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件管理器";
            this.Load += new System.EventHandler(this.FormFileExplorer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripTree.ResumeLayout(false);
            this.contextMenuStripExplorer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.ImageList imageListFile;
        private System.Windows.Forms.ListView listViewExplorer;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderDatetime;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTree;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemExpand;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripExplorer;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemExport;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemRename;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxFileIcon;
        private System.Windows.Forms.Label labelFileDesc;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.Label labelFileDatetime;
        private System.Windows.Forms.ImageList imageListLargeIcon;
        private System.Windows.Forms.Button buttonBackFolder;
        private System.Windows.Forms.Button buttonPushFile;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemExplorerRefresh;
        private System.Windows.Forms.Button buttonExplorerRefresh;
    }
}