using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormSystemDate : Form
    {
        private ConnectTaskThread taskThread = null;

        public FormSystemDate()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            string datetime = this.dateTimePickerSystem.Value.ToString("yyyyMMdd.HHmmss");
            setSystemDatetime(datetime);
        }

        /// <summary>
        /// 设置系统时间
        /// </summary>
        /// <param name="datetime"></param>
        private void setSystemDatetime(string datetime)
        {
            string cmd = "shell date -s \"" + datetime + "\"";
            TaskInfo task = TaskInfo.Create(TaskType.ExecuteCommand, cmd);
            task.ResultHandler = new TaskInfo.EventResultHandler(setSystemDatetimeResult);
            taskThread.SendTask(task);
        }

        /// <summary>
        /// 设置结果
        /// </summary>
        /// <param name="result"></param>
        private void setSystemDatetimeResult(object[] result)
        {
            if (result.Length > 0)
            {
                string text = "设置成功，系统时间是：" + result[0].ToString().Trim();
                if (MessageBox.Show(text, "设置时间", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
