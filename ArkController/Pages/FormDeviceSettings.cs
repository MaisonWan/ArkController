using ArkController.Data;
using ArkController.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Pages
{
    public partial class FormDeviceSettings : Form
    {
        private ConnectTaskThread taskThread = null;

        public FormDeviceSettings()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void FormDeviceSettings_Load(object sender, EventArgs e)
        {
            this.comboBoxAction.SelectedIndex = 0;
        }

        private void buttonStartAction_Click(object sender, EventArgs e)
        {
            string action = "-a " + this.comboBoxAction.SelectedItem.ToString();
            taskThread.SendTask(TaskInfo.Create(TaskType.StartAM, action));
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
