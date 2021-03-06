﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string currentExplorerPath = "/";
        private List<string> iconList = new List<string>();
        private int willDeleteFileCount = 0; // 计划删除几个文件
        private int hasDeleteFileCount = 0;// 已经删除了几个文件

        public FormFileExplorer()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
            CheckForIllegalCrossThreadCalls = false;
            foreach (string key in this.imageListLargeIcon.Images.Keys)
            {
                iconList.Add(key);
            }
        }

        private void FormFileExplorer_Load(object sender, EventArgs e)
        {
            this.listViewExplorer.ListViewItemSorter = new ListViewColumnSorter();
            if (currentExplorerPath == null)
            {
                this.buttonBackFolder.Enabled = false;
            }
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
            if (e.Node.Tag != null)
            {
                string path = e.Node.Tag.ToString();
                getNodeList(path, false, new TaskInfo.EventResultHandler(getExplorerAndNodeListResult));
                this.currentExplorerPath = path;
            }
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
            item.ImageKey = FileKit.GetFileIconName(this.imageListFile, file);
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
                    this.buttonBackFolder.Enabled = true;
                    this.currentExplorerPath = path;
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
                this.labelFileSize.Text = file.FileSize > 0 ? "文件大小：" + FileKit.FormatFileSize(file.FileSize) : "";
                this.pictureBoxFileIcon.Image = FileKit.GetFileIconImage(this.imageListLargeIcon, file);
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

        private void mToolStripMenuItemExport_Click(object sender, EventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewExplorer))
            {
                ExplorerFileInfo file = (ExplorerFileInfo)this.listViewExplorer.SelectedItems[0].Tag;
                string savePath = null;
                if (file.IsFolder)
                {
                    // 选择文件夹
                    savePath = DialogKit.ShowSaveFolderDialog();
                    savePath = Path.Combine(savePath, Path.GetFileName(file.FileFullPath));
                }
                else
                {
                    // 选择文件存储路径
                    savePath = DialogKit.ShowSaveDialog(file.FileName);
                }
                pullFileFromDevice(file.FileFullPath, savePath);
            }
        }

        private void mToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            int selectFileCount = this.listViewExplorer.SelectedItems.Count;
            if (selectFileCount > 0)
            {
                ExplorerFileInfo file = (ExplorerFileInfo)this.listViewExplorer.SelectedItems[0].Tag;
                string message = "确认删除设备上文件" + file.FileName + "?";
                if (selectFileCount > 1)
                {
                    message = "确认删除选择的文件或者文件夹?";
                }
                else if (file.IsFolder)
                {
                    message = "确认删除设备上文件夹" + file.FileFullPath + ",会删除该文件夹下所有文件";
                }
                if (MessageBox.Show(message, "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    willDeleteFileCount = selectFileCount;
                    hasDeleteFileCount = 0;
                    for (int i = 0; i < selectFileCount; i++)
                    {
                        ExplorerFileInfo f = (ExplorerFileInfo)this.listViewExplorer.SelectedItems[i].Tag;
                        deleteFile(f.FileFullPath);
                    }
                }
            }
        }

        private void deleteFile(string path)
        {
            TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
            t.Data = "shell rm -r " + path;
            t.ResultHandler = new TaskInfo.EventResultHandler(deleteFileResult);
            taskThread.SendTask(t);
        }

        private void deleteFileResult(object[] result)
        {
            hasDeleteFileCount++;
            // 执行删除完文件，刷新列表
            if (hasDeleteFileCount == willDeleteFileCount)
            {
                refreshExplorer();
            }
        }

        private void mToolStripMenuItemRename_Click(object sender, EventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewExplorer))
            {
                this.listViewExplorer.SelectedItems[0].BeginEdit();
            }
        }

        private string currentEditBeforeLabel = null;
        private string currentEditAfterLabel = null;
        private void listViewExplorer_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            currentEditBeforeLabel = e.Label;
        }

        private void listViewExplorer_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == currentEditBeforeLabel)
            {
                e.CancelEdit = true;
            }
            else
            {
                ExplorerFileInfo file = (ExplorerFileInfo)this.listViewExplorer.SelectedItems[0].Tag;
                currentEditAfterLabel = e.Label;
                renameFile(file.FileFullPath, Path.Combine(this.currentExplorerPath, e.Label));
            }
        }

        /// <summary>
        /// 文件或者文件夹重命名
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        private void renameFile(string oldPath, string newPath)
        {
            TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
            t.Data = string.Format("shell rename {0} {1}", oldPath, newPath);
            t.ResultHandler = new TaskInfo.EventResultHandler(renameFileResult);
            taskThread.SendTask(t);
        }

        private void renameFileResult(object[] result)
        {
            ExplorerFileInfo file = (ExplorerFileInfo)this.listViewExplorer.SelectedItems[0].Tag;
            file.FileName = currentEditAfterLabel;
            file.FileFullPath = Path.Combine(FileKit.GetUpFolder(file.FileFullPath), file.FileName);
        }

        private void mToolStripMenuItemExplorerRefresh_Click(object sender, EventArgs e)
        {
            // 刷新当前文件夹
            refreshExplorer();
        }
        #endregion

        private void pullFileFromDevice(string devicePath, string localPath)
        {
            TaskInfo t = new TaskInfo(TaskType.PullFile);
            t.DataArray = new object[] { devicePath, localPath};
            taskThread.SendTask(t);
        }

        #region 工具栏按钮
        private void buttonBackFolder_Click(object sender, EventArgs e)
        {
            string path = FileKit.GetUpFolder(currentExplorerPath);
            if (path != null)
            {
                getNodeList(path, false, new TaskInfo.EventResultHandler(getExplorerListResult));
                this.buttonBackFolder.Enabled = true;
                if (path == "/")
                {
                    this.buttonBackFolder.Enabled = false;
                }
                this.currentExplorerPath = path;
            }
        }

        private void buttonPushFile_Click(object sender, EventArgs e)
        {
            string[] filesPath = DialogKit.OpenFileDialog();
            if (filesPath == null)
            {
                return;
            }
            foreach (string filePath in filesPath)
            {
                TaskInfo t = new TaskInfo(TaskType.PushFile);
                t.DataArray = new object[] { filePath, currentExplorerPath };
                t.ResultHandler = new TaskInfo.EventResultHandler(pushFileResult);
                taskThread.SendTask(t);
            }
        }

        private void pushFileResult(object[] result)
        {
            refreshExplorer();
        }

        private void buttonExplorerRefresh_Click(object sender, EventArgs e)
        {
            refreshExplorer();
        }
        #endregion

        /// <summary>
        /// 刷新文件浏览器
        /// </summary>
        private void refreshExplorer()
        {
            getNodeList(currentExplorerPath, false, new TaskInfo.EventResultHandler(getExplorerListResult));
        }

        private void listViewExplorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (ListViewKit.hasSelectedItem(listViewExplorer))
            {
                ExplorerFileInfo file = (ExplorerFileInfo)listViewExplorer.SelectedItems[0].Tag;
                listViewExplorer.DoDragDrop(new DataObject(DataFormats.FileDrop, @"C:\Users\Maison\Pictures\iikura_04_l.jpg"), DragDropEffects.Copy);
            }
        }

        private void listViewExplorer_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }
            string file = (string)e.Data.GetData(DataFormats.FileDrop);
            if (File.Exists(file))
            {

            }
            //pullFileFromDevice(file.FileFullPath, "");
            
        }

        private void listViewExplorer_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Copy;
        }

        private void listViewExplorer_DragLeave(object sender, EventArgs e)
        {

        }

        private void listViewExplorer_DragEnter(object sender, DragEventArgs e)
        {

        }

    }
}
