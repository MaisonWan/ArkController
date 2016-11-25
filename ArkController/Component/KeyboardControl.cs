using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ArkController.Task;

namespace ArkController.Component
{
    public partial class KeyboardControl : UserControl
    {
        private ConnectTaskThread taskThread = null;

        public KeyboardControl()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int data = -1;
            try
            {
                data = Convert.ToInt32(((Button)sender).Tag);
            }
            catch
            {

            }
            if (data > -1)
            {
                TaskInfo task = new TaskInfo(TaskType.SendKey);
                task.Data = data;
                taskThread.SendTask(task);
            }
        }
    }
}
