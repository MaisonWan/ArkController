using ArkController.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Pages
{
    public partial class FormSystemProperty : Form
    {
        private ConnectTaskThread taskThread = null;

        public FormSystemProperty()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void FormSystemProperty_Load(object sender, EventArgs e)
        {
            listViewProperties_Resize(sender, e);
            buttonReadSystemProp_Click(sender, e);
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
            string[] lines = content.Split("\n".ToCharArray());
            this.listViewProperties.BeginUpdate();
            this.listViewProperties.Items.Clear();
            foreach (string line in lines)
            {
                string[] keyValue = line.Trim().Split(": ".ToCharArray());
                if (keyValue.Length == 3)
                {
                    ListViewItem item = new ListViewItem(keyValue[0]);
                    item.SubItems.Add(keyValue[2]);
                    this.listViewProperties.Items.Add(item);
                }
            }
            this.listViewProperties.EndUpdate();
        }

        private void listViewProperties_Resize(object sender, EventArgs e)
        {
            int width = this.listViewProperties.Width;
            this.listViewProperties.Columns[0].Width = width / 2;
            this.listViewProperties.Columns[1].Width = width / 2;
        }
    }
}
