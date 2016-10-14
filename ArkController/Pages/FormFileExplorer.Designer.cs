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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("内置存储", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("内置SD卡", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileExplorer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.imageListFile = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewExplorer = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(846, 651);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.ImageKey = "folder.png";
            this.treeViewMenu.ImageList = this.imageListFile;
            this.treeViewMenu.ItemHeight = 22;
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.Name = "节点0";
            treeNode1.Text = "节点0";
            treeNode2.ImageKey = "(默认值)";
            treeNode2.Name = "innerStorage";
            treeNode2.SelectedImageKey = "(默认值)";
            treeNode2.StateImageKey = "folder.png";
            treeNode2.Tag = "/";
            treeNode2.Text = "内置存储";
            treeNode3.Name = "节点2";
            treeNode3.Text = "节点2";
            treeNode4.Name = "innerSDCard";
            treeNode4.SelectedImageKey = "(默认值)";
            treeNode4.StateImageKey = "folder.png";
            treeNode4.Tag = "/sdcard/";
            treeNode4.Text = "内置SD卡";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeViewMenu.SelectedImageKey = "folder.png";
            this.treeViewMenu.Size = new System.Drawing.Size(200, 651);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 27);
            this.panel1.TabIndex = 1;
            // 
            // listViewExplorer
            // 
            this.listViewExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderDatetime,
            this.columnHeaderType});
            this.listViewExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExplorer.FullRowSelect = true;
            this.listViewExplorer.Location = new System.Drawing.Point(0, 0);
            this.listViewExplorer.Name = "listViewExplorer";
            this.listViewExplorer.Size = new System.Drawing.Size(642, 651);
            this.listViewExplorer.SmallImageList = this.imageListFile;
            this.listViewExplorer.TabIndex = 0;
            this.listViewExplorer.UseCompatibleStateImageBehavior = false;
            this.listViewExplorer.View = System.Windows.Forms.View.Details;
            this.listViewExplorer.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewExplorer_ColumnClick);
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
            // FormFileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 689);
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
    }
}