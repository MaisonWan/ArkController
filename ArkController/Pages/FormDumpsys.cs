using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArkController.Component;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormDumpsys : Form
    {
        protected ConnectTaskThread taskThread = null;

        public FormDumpsys()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void FormDumpsys_Load(object sender, EventArgs e)
        {
            loadDeviceDumpsysItems();
            ListViewColumnSorter sorter = new ListViewColumnSorter();
            this.listViewItems.ListViewItemSorter = sorter;
        }

        /// <summary>
        /// 加载设备支持的dumpsys类型
        /// </summary>
        private void loadDeviceDumpsysItems()
        {
            string cmd = "shell dumpsys -l";
            TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
            t.Data = cmd;
            t.ResultHandler += new TaskInfo.EventResultHandler(loadDumpsysItemsResult);
            taskThread.SendTask(t);
        }

        private void loadDumpsysItemsResult(object[] result)
        {
            // 转化为items
            string[] items = result[0].ToString().Split("\n".ToCharArray());
            this.listViewItems.Items.Clear();
            this.listViewItems.BeginUpdate();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].StartsWith(" "))
                {
                    this.listViewItems.Items.Add(items[i].Trim());
                }
            }
            this.listViewItems.EndUpdate();
        }

        private void listViewItems_Resize(object sender, EventArgs e)
        {
            this.listViewItems.Columns[0].Width = this.listViewItems.ClientSize.Width;
        }

        private void listViewItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewKit.OnColumnClickSort(sender, e);
        }

        private void listViewItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListViewKit.hasSelectedItem(this.listViewItems))
            {
                string item = this.listViewItems.SelectedItems[0].Text;
                string cmd = "shell dumpsys " + item;
                TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
                t.Data = cmd;
                t.ResultHandler += new TaskInfo.EventResultHandler(loadDumpsysItemContentResult);
                taskThread.SendTask(t);
            }
        }

        private void loadDumpsysItemContentResult(object[] result)
        {
            if (result[0].ToString().Trim() == "")
            {
                this.textBoxContent.Text = "无";
            }
            else
            {
                this.textBoxContent.Text = Encoding.UTF8.GetString(Encoding.Default.GetBytes(result[0].ToString()));
            }
        }

        private void buttonLogSave_Click(object sender, EventArgs e)
        {
            string content = this.textBoxContent.Text;
            if (!string.IsNullOrEmpty(content))
            {
                string defaultName = "dumpsys_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
                string localFilePath = DialogKit.ShowSaveLogDialog(defaultName);
                if (!string.IsNullOrEmpty(localFilePath))
                {
                    FileStream fs = new FileStream(localFilePath, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.Write(content);
                    sw.Close();
                    fs.Close();
                }
            }
        }

        private void buttonLogClear_Click(object sender, EventArgs e)
        {
            this.textBoxContent.Clear();
        }

        private void textBoxContent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
