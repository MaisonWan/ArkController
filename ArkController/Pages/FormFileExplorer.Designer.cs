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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("内置存储", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("内置SD卡", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileExplorer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.imageListFile = new System.Windows.Forms.ImageList(this.components);
            this.listViewExplorer = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mToolStripMenuItemExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripExplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFileDesc = new System.Windows.Forms.Label();
            this.labelFileDatetime = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripTree.SuspendLayout();
            this.contextMenuStripExplorer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            treeNode1.Name = "节点0";
            treeNode1.Text = "";
            treeNode2.ImageKey = "(默认值)";
            treeNode2.Name = "innerStorage";
            treeNode2.SelectedImageKey = "(默认值)";
            treeNode2.StateImageKey = "folder.png";
            treeNode2.Tag = "/";
            treeNode2.Text = "内置存储";
            treeNode3.Name = "节点2";
            treeNode3.Text = "";
            treeNode4.Name = "innerSDCard";
            treeNode4.SelectedImageKey = "(默认值)";
            treeNode4.StateImageKey = "folder.png";
            treeNode4.Tag = "/sdcard/";
            treeNode4.Text = "内置SD卡";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeViewMenu.SelectedImageKey = "folder.png";
            this.treeViewMenu.Size = new System.Drawing.Size(200, 632);
            this.treeViewMenu.TabIndex = 0;
            this.treeViewMenu.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterExpand);
            this.treeViewMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMenu_NodeMouseClick);
            // 
            // imageListFile
            // 
            this.imageListFile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFile.ImageStream")));
            this.imageListFile.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFile.Images.SetKeyName(0, "disk.png");
            this.imageListFile.Images.SetKeyName(1, "folder.png");
            this.imageListFile.Images.SetKeyName(2, "folder_open.png");
            // 
            // listViewExplorer
            // 
            this.listViewExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderDatetime,
            this.columnHeaderType});
            this.listViewExplorer.ContextMenuStrip = this.contextMenuStripExplorer;
            this.listViewExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExplorer.FullRowSelect = true;
            this.listViewExplorer.Location = new System.Drawing.Point(0, 0);
            this.listViewExplorer.Name = "listViewExplorer";
            this.listViewExplorer.Size = new System.Drawing.Size(642, 632);
            this.listViewExplorer.SmallImageList = this.imageListFile;
            this.listViewExplorer.TabIndex = 0;
            this.listViewExplorer.UseCompatibleStateImageBehavior = false;
            this.listViewExplorer.View = System.Windows.Forms.View.Details;
            this.listViewExplorer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewExplorer_ColumnClick);
            this.listViewExplorer.SelectedIndexChanged += new System.EventHandler(this.listViewExplorer_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 27);
            this.panel1.TabIndex = 1;
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
            // contextMenuStripExplorer
            // 
            this.contextMenuStripExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemOpen,
            this.mToolStripMenuItemCopy,
            this.mToolStripMenuItemExport,
            this.mToolStripMenuItemDelete,
            this.mToolStripMenuItemRename});
            this.contextMenuStripExplorer.Name = "contextMenuStripExplorer";
            this.contextMenuStripExplorer.Size = new System.Drawing.Size(162, 114);
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
            // 
            // mToolStripMenuItemDelete
            // 
            this.mToolStripMenuItemDelete.Name = "mToolStripMenuItemDelete";
            this.mToolStripMenuItemDelete.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemDelete.Text = "删除(&D)";
            // 
            // mToolStripMenuItemRename
            // 
            this.mToolStripMenuItemRename.Name = "mToolStripMenuItemRename";
            this.mToolStripMenuItemRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mToolStripMenuItemRename.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemRename.Text = "重命名(&W)";
            // 
            // mToolStripMenuItemOpen
            // 
            this.mToolStripMenuItemOpen.Name = "mToolStripMenuItemOpen";
            this.mToolStripMenuItemOpen.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItemOpen.Text = "打开(&O)";
            this.mToolStripMenuItemOpen.Click += new System.EventHandler(this.mToolStripMenuItemOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelFileSize);
            this.panel2.Controls.Add(this.labelFileDatetime);
            this.panel2.Controls.Add(this.labelFileDesc);
            this.panel2.Controls.Add(this.labelFileName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 673);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 56);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArkController.Properties.Resources.volume_up;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(69, 12);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 12);
            this.labelFileName.TabIndex = 1;
            // 
            // labelFileDesc
            // 
            this.labelFileDesc.AutoSize = true;
            this.labelFileDesc.Location = new System.Drawing.Point(69, 38);
            this.labelFileDesc.Name = "labelFileDesc";
            this.labelFileDesc.Size = new System.Drawing.Size(0, 12);
            this.labelFileDesc.TabIndex = 2;
            // 
            // labelFileDatetime
            // 
            this.labelFileDatetime.AutoSize = true;
            this.labelFileDatetime.Location = new System.Drawing.Point(204, 11);
            this.labelFileDatetime.Name = "labelFileDatetime";
            this.labelFileDatetime.Size = new System.Drawing.Size(0, 12);
            this.labelFileDatetime.TabIndex = 3;
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(204, 37);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(0, 12);
            this.labelFileSize.TabIndex = 4;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFileDesc;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.Label labelFileDatetime;
    }
}