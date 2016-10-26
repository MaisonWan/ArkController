using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArkController.Task;
using ArkController.Data;

namespace ArkController.Component
{
    public partial class DeviceInfoControl : UserControl
    {
        private ConnectTaskThread taskThread = null;

        public DeviceInfoControl()
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
            loadSystemDate();
            loadScreenInfo();
            loadFocusActivity();
            loadCurrentInputMethod();
        }

        #region 系统
        /// <summary>
        /// 获取设备系统时间
        /// </summary>
        private void loadSystemDate()
        {
            TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
            t.Data = "shell date";
            t.ResultHandler = new TaskInfo.EventResultHandler(loadSystemDateResult);
            taskThread.SendTask(t);
        }

        private void loadSystemDateResult(object[] result)
        {
            this.labelSystemDate.Text = result[0].ToString();
        }

        /// <summary>
        /// 获取屏幕信息
        /// </summary>
        private void loadScreenInfo()
        {
            TaskInfo tSize = TaskInfo.Create(TaskType.ScreenSizeDensity, new object[] { ScreenData.Action.GetSize.ToString() });
            tSize.ResultHandler = new TaskInfo.EventResultHandler(getScreenSizeResult);
            taskThread.SendTask(tSize);

            TaskInfo tDensity = TaskInfo.Create(TaskType.ScreenSizeDensity, new object[] { ScreenData.Action.GetDensity.ToString() });
            tDensity.ResultHandler = new TaskInfo.EventResultHandler(getScreenDensityResult);
            taskThread.SendTask(tDensity);
        }

        private void getScreenSizeResult(object[] result)
        {
            Size size = (Size)result[0];
            this.labelScreenSize.Text = String.Format("{0}x{1}", size.Width, size.Height);
        }

        private void getScreenDensityResult(object[] result)
        {
            int density = (int)result[0];
            this.labelScreenDensity.Text = density.ToString();
        }
        #endregion

        #region 输入法
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
        #endregion

        #region 显示

        private void loadFocusActivity()
        {
            TaskInfo t = new TaskInfo(TaskType.ExecuteCommand);
            t.Data = "shell dumpsys activity | grep \"mFocusedActivity\"";
            t.ResultHandler = new TaskInfo.EventResultHandler(loadFocusActivityResult);
            taskThread.SendTask(t);
        }

        private void loadFocusActivityResult(object[] result)
        {
            this.labelFocusActivity.Text = result[0].ToString();
        }
        #endregion
    }
}
