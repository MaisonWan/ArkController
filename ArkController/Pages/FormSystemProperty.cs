using ArkController.Component;
using ArkController.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArkController.Data;

namespace ArkController.Pages
{
    public partial class FormSystemProperty : Form
    {
        private ConnectTaskThread taskThread = null;
        /// <summary>
        /// 存储列名的list
        /// </summary>
        private List<string> keyList = new List<string>();

        /// <summary>
        /// 更新自动完成
        /// </summary>
        private delegate void UpdateAutoCompleteSource();

        private UpdateAutoCompleteSource updateSource = null;

        public FormSystemProperty()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.updateSource = new UpdateAutoCompleteSource(updateAutoCompleteSource);
            taskThread = ConnectTaskThread.GetInstance();
            this.listViewProperties.ListViewItemSorter = new ListViewColumnSorter();
        }

        private void FormSystemProperty_Load(object sender, EventArgs e)
        {
            listViewProperties_Resize(sender, e);
            buttonReadSystemProp_Click(sender, e);
            updateAutoCompleteSource();
        }

        /// <summary>
        /// 读取系统属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReadSystemProp_Click(object sender, EventArgs e)
        {
            TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
            t.Data = "shell getprop";
            t.ResultHandler = new TaskInfo.EventResultHandler(readSystemPropResult);
            taskThread.SendTask(t);
        }

        /// <summary>
        /// 读取系统属性结果
        /// </summary>
        /// <param name="result"></param>
        private void readSystemPropResult(object[] result)
        {
            string content = (string)result[0];
            List<KeyValuePair<string, string>> list = SystemProperty.Parser(content);
            this.listViewProperties.BeginUpdate();
            this.listViewProperties.Items.Clear();
            this.keyList.Clear();
            // 是否需要过滤
            bool needFilter = this.checkBoxFilter.Checked && !string.IsNullOrEmpty(this.textBoxFilter.Text);

            foreach (KeyValuePair<string, string> line in list)
            {
                string key = line.Key;
                string value = line.Value;
                this.keyList.Add(key);
                // 需要过滤，并且包含这个关键词
                if (!needFilter || key.Contains(this.textBoxFilter.Text))
                {
                    ListViewItem item = new ListViewItem(key);
                    value = Encoding.UTF8.GetString(Encoding.Default.GetBytes(value));
                    item.SubItems.Add(value);
                    this.listViewProperties.Items.Add(item);
                }
            }
            this.listViewProperties.EndUpdate();
            // 更新自动完成列表
            this.textBoxFilter.Invoke(updateSource);
        }

        /// <summary>
        /// 完成自动完成列表
        /// </summary>
        private void updateAutoCompleteSource()
        {
            this.textBoxFilter.AutoCompleteCustomSource.Clear();
            this.textBoxFilter.AutoCompleteCustomSource.AddRange(keyList.ToArray());
        }

        private void listViewProperties_Resize(object sender, EventArgs e)
        {
            int width = this.listViewProperties.ClientSize.Width;
            this.listViewProperties.Columns[0].Width = width / 2;
            this.listViewProperties.Columns[1].Width = width / 2;
        }

        private void listViewProperties_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewKit.OnColumnClickSort(sender, e);
        }

        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonReadSystemProp_Click(sender, e);
            }
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            if (this.listViewProperties.SelectedItems.Count > 0)
            {
                string key = this.listViewProperties.SelectedItems[0].SubItems[0].Text;
                Clipboard.SetText(key);
            }
        }

        private void mToolStripMenuItemCopyValue_Click(object sender, EventArgs e)
        {
            if (this.listViewProperties.SelectedItems.Count > 0)
            {
                string key = this.listViewProperties.SelectedItems[0].SubItems[1].Text;
                Clipboard.SetText(key);
            }
        }

    }
}
