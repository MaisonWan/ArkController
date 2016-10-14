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
            currentNode = e.Node;
            string path = e.Node.Tag.ToString();
            getNodeList(path, false, new TaskInfo.EventResultHandler(getNodeListResult));
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
            t.ResultHandler = handler;
            taskThread.SendTask(t);
        }

        private void getNodeListResult(object[] result)
        {
            List<ExplorerFileInfo> files = explorer.ParserFilesInfo(result[0].ToString());
            UpdateNodeList add = new UpdateNodeList(updateNodeList);
            this.treeViewMenu.BeginInvoke(add, new object[] { files });
        }

        private void getExplorerListResult(object[] result)
        {
            List<ExplorerFileInfo> files = explorer.ParserFilesInfo(result[0].ToString());
            UpdateNodeList add = new UpdateNodeList(updateExplorerList);
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
                    string fileName = Encoding.UTF8.GetString(Encoding.Default.GetBytes(file.FileName));
                    rootNode.Nodes.Add(fileName);
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
                ListViewItem item = new ListViewItem(file.FileName);
                item.SubItems.Add(file.FileSize > 0 ? FileKit.FormatFileSize(file.FileSize) : "");
                item.SubItems.Add(file.CreateDateTime.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(file.IsFolder ? "文件夹" : "文件");
                this.listViewExplorer.Items.Add(item);
            }
            this.listViewExplorer.EndUpdate();
        }

        private void treeViewMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            getNodeList(path, false, new TaskInfo.EventResultHandler(getExplorerListResult));
        }

        private void listViewExplorer_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewKit.OnColumnClickSort(sender, e);
        }
    }
}
