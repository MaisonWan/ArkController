using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArkController.Data;
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
        private delegate void UpdateNodeList(string[] files);
        private TreeNode currentNode = null;

        public FormFileExplorer()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormFileExplorer_Load(object sender, EventArgs e)
        {

        }

        private void treeViewMenu_AfterExpand(object sender, TreeViewEventArgs e)
        {
            currentNode = e.Node;
            string path = e.Node.Tag.ToString();
            getNodeList(path, false);
        }

        /// <summary>
        /// 得到指定路径下面的文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private void getNodeList(string path, bool includeHideFile)
        {
            if (!path.EndsWith("/"))
            {
                path += "/";
            }
            string cmd = string.Format("shell ls -{0}l {1}", includeHideFile ? "a" : "", path);
            TaskInfo t = TaskInfo.Create(TaskType.ExecuteCommand, cmd);
            t.ResultHandler = new TaskInfo.EventResultHandler(getNodeListResult);
            taskThread.SendTask(t);
        }

        private void getNodeListResult(object[] result)
        {
            explorer.ParserFilesInfo(result[0].ToString());
            string[] files = result[0].ToString().Split("\n".ToCharArray());
            UpdateNodeList add = new UpdateNodeList(updateNodeList);
            this.treeViewMenu.BeginInvoke(add, new object[] { files });
        }

        private void updateNodeList(string[] files)
        {
            TreeNode rootNode = currentNode;
            rootNode.Nodes.Clear();
            foreach (string file in files)
            {
                string f = file.Trim();
                if (f.Length > 0)
                {
                    string fileName = Encoding.UTF8.GetString(Encoding.Default.GetBytes(f.Trim()));
                    rootNode.Nodes.Add(fileName);
                }
            }
        }
    }
}
