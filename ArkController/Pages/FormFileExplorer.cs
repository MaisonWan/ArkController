using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArkController.Component;
using ArkController.Data;
using ArkController.Kit;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormFileExplorer : Form
    {
        protected ConnectTaskThread taskThread = null;
        private ExplorerManager explorer = new ExplorerManager();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        private delegate void UpdateNodeList(List<ExplorerFileInfo> files);
        private TreeNode currentNode = null;

        public FormFileExplorer()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormFileExplorer_Load(object sender, EventArgs e)
        {
            this.listViewExplorer.ListViewItemSorter = new ListViewColumnSorter();
        }

        private void treeViewMenu_AfterExpand(object sender, TreeViewEventArgs e)
        {
            updateNode(e.Node);
        }

        /// <summary>
        /// 更新Node数据
        /// </summary>
        /// <param name="node"></param>
        private void updateNode(TreeNode node)
        {
            currentNode = node;
            string path = node.Tag.ToString();
            getNodeList(path, false, new TaskInfo.EventResultHandler(getNodeListResult));
        }

        private void treeViewMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeViewMenu.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Right)
            {
                return;
            }
            currentNode = e.Node;
            string path = e.Node.Tag.ToString();
            getNodeList(path, false, new TaskInfo.EventResultHandler(getExplorerAndNodeListResult));
        }

        /// <summary>
        /// 得到指定路径下面的文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private void getNodeList(string path, bool includeHideFile, TaskInfo.EventResultHandler handler)
        {
            if (!path.EndsWith("/"))
            {
                path += "/";
            }
            string cmd = string.Format("shell ls -{0}l {1}", includeHideFile ? "a" : "", path);
            TaskInfo t = TaskInfo.Create(TaskType.ExecuteCommand, cmd);
            t.Tag = path;
            t.ResultHandler = handler;
            taskThread.SendTask(t);
        }

        /// <summary>
        /// 树状结构结点上结果
        /// </summary>
        /// <param name="result"></param>
        private void getNodeListResult(object[] result)
        {
            List<ExplorerFileInfo> files = explorer.ParserFilesInfo(result[0].ToString(), result[1].ToString());
            UpdateNodeList add = new UpdateNodeList(updateNodeList);
            this.treeViewMenu.BeginInvoke(add, new object[] { files });
        }

        /// <summary>
        /// 文件浏览器上数据结果
        /// </summary>
        /// <param name="result"></param>
        private void getExplorerListResult(object[] result)
        {
            List<ExplorerFileInfo> files = explorer.ParserFilesInfo(result[0].ToString(), result[1].ToString());
            UpdateNodeList add = new UpdateNodeList(updateExplorerList);
            this.listViewExplorer.BeginInvoke(add, new object[] { files });
        }

        /// <summary>
        /// 更新文件目录树和文件浏览器内容
        /// </summary>
        /// <param name="result"></param>
        private void getExplorerAndNodeListResult(object[] result)
        {
            List<ExplorerFileInfo> files = explorer.ParserFilesInfo(result[0].ToString(), result[1].ToString());
            UpdateNodeList add = new UpdateNodeList(updateExplorerAndNodeList);
            this.listViewExplorer.BeginInvoke(add, new object[] { files });
        }

        /// <summary>
        /// 更新树状结点的列表
        /// </summary>
        /// <param name="files"></param>
        private void updateNodeList(List<ExplorerFileInfo> files)
        {
            TreeNode rootNode = currentNode;
            rootNode.Nodes.Clear();
            foreach (ExplorerFileInfo file in files)
            {
                if (file.IsFolder)
                {
                    TreeNode node = new TreeNode(file.FileName);
                    node.Tag = file.FileFullPath;
                    rootNode.Nodes.Add(node);
                }
            }
        }

        /// <summary>
        /// 更新浏览器界面的列表
        /// </summary>
        /// <param name="files"></param>
        private void updateExplorerList(List<ExplorerFileInfo> files)
        {
            files = explorer.SortByType(files);
            this.listViewExplorer.BeginUpdate();
            this.listViewExplorer.Items.Clear();
            foreach (ExplorerFileInfo file in files)
            {
                this.listViewExplorer.Items.Add(createListViewItem(file));
            }
            this.listViewExplorer.EndUpdate();
        }

        private ListViewItem createListViewItem(ExplorerFileInfo file)
        {
            ListViewItem item = new ListViewItem(file.FileName);
            item.ImageIndex = 1;
            item.SubItems.Add(file.FileSize > 0 ? FileKit.FormatFileSize(file.FileSize) : "");
            item.SubItems.Add(file.CreateDateTime.ToString("yyyy-MM-dd HH:mm"));
            item.SubItems.Add(file.IsFolder ? "文件夹" : "文件");
            item.Tag = file;
            return item;
        }

        /// <summary>
        /// 更新目录树和文件浏览器
        /// </summary>
        /// <param name="files"></param>
        private void updateExplorerAndNodeList(List<ExplorerFileInfo> files)
        {
            updateExplorerList(files);
            updateNodeList(files);
        }

        private void listViewExplorer_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewKit.OnColumnClickSort(sender, e);
        }

        private void listViewExplorer_DoubleClick(object sender, EventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewExplorer))
            {
                ExplorerFileInfo file = (ExplorerFileInfo)this.listViewExplorer.SelectedItems[0].Tag;
                if (file.IsFolder)
                {
                    string path = file.FileFullPath;
                    getNodeList(path, false, new TaskInfo.EventResultHandler(getExplorerListResult));
                }
            }
        }

        private void listViewExplorer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewExplorer))
            {
                ExplorerFileInfo file = (ExplorerFileInfo)this.listViewExplorer.SelectedItems[0].Tag;
                // 预览图上显示
                this.labelFileName.Text = file.FileName;
                this.labelFileDatetime.Text = "创建时间：" + file.CreateDateTime.ToString("yyyy-MM-dd HH:mm");
                this.labelFileSize.Text = "文件大小：" + FileKit.FormatFileSize(file.FileSize);
            }
        }

        #region 目录树的右键菜单
        private void mToolStripMenuItemExpand_Click(object sender, EventArgs e)
        {
            if (this.treeViewMenu.SelectedNode.IsExpanded)
            {
                this.treeViewMenu.SelectedNode.Collapse();
            }
            else
            {
                this.treeViewMenu.SelectedNode.Expand();
            }
        }

        private void contextMenuStripTree_Opening(object sender, CancelEventArgs e)
        {
            if (this.treeViewMenu.SelectedNode.IsExpanded)
            {
                this.mToolStripMenuItemExpand.Text = "折叠(&A)";
            }
            else
            {
                this.mToolStripMenuItemExpand.Text = "展开(&A)";
            }
        }

        private void mToolStripMenuItemRefresh_Click(object sender, EventArgs e)
        {
            updateNode(treeViewMenu.SelectedNode);
        }
        #endregion

        #region 文件浏览器菜单
        private void mToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            listViewExplorer_DoubleClick(sender, e);
        }
        
        #endregion

    }
}
