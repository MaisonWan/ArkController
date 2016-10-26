using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArkController.Task;

namespace ArkController.Component
{
    public partial class DeviceInfoInputMethodControl : UserControl
    {
        private ConnectTaskThread taskThread = null;

        public DeviceInfoInputMethodControl()
        {
            InitializeComponent();
        }

        private void DeviceInfoInputMethodControl_Load(object sender, EventArgs e)
        {
            taskThread = ConnectTaskThread.GetInstance();
        }

        /// <summary>
        /// 
        /// </summary>
        public void OnConnectDevice()
        {
            loadCurrentInputMethod();
        }

        private void loadCurrentInputMethod()
        {
            TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
            t.Data = "shell ime list -s";
            t.ResultHandler = new TaskInfo.EventResultHandler(loadCurrentInputMethodResult);
            taskThread.SendTask(t);
        }

        private void loadCurrentInputMethodResult(object[] result)
        {
            this.labelCurrentInputMethod.Text = result[0].ToString();
        }
    }
}
