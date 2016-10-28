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
using System.IO;
using ArkController.Pages;
using ArkController.Kit;

namespace ArkController.Component
{
    public partial class DeviceInfoControl : UserControl
    {
        private ConnectTaskThread taskThread = null;
        private FormImagePreview imagePreview = null;
        private string batteryFormatInfo = null;
        private string screenShotPath = null;

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
        public void OnConnectDevice(string sn)
        {
            loadDeivceInfo(sn);
            loadBatteryInfo();
            loadSystemDate();
            loadScreenInfo();
            loadFocusActivity();
            loadCurrentInputMethod();
            loadScreenShot();// 屏幕截图最慢，最后做
        }

        private void pictureBoxBattery_MouseEnter(object sender, EventArgs e)
        {
            if (batteryFormatInfo != null)
            {
                this.toolTipBattery.SetToolTip(this.pictureBoxBattery, batteryFormatInfo);
            }
        }

        private void pictureBoxScreenShot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(screenShotPath))
            {
                Image image = pictureBoxScreenShot.Image;
                imagePreview = (FormImagePreview)FormKit.Show(imagePreview, typeof(FormImagePreview), new object[] { image });
            }
        }
        #region 屏幕名称电池
        /// <summary>
        /// 获取设备信息
        /// </summary>
        /// <param name="sn"></param>
        private void loadDeivceInfo(string sn)
        {
            TaskInfo task = new TaskInfo(TaskType.CurrentDeviceInfo);
            task.Data = sn;
            task.ResultHandler = new TaskInfo.EventResultHandler(loadDeivceInfoResult);
            taskThread.SendTask(task);
        }

        private void loadDeivceInfoResult(object result)
        {
            string[] values = (string[])result;
            if (values != null && values.Length == 4)
            {
                this.labelDeviceInfo.Text = values[0];
                this.labelProduct.Text = "Product:" + values[1];
                this.labelModel.Text = "Model:" + values[2];
                this.labelDevice.Text = "Device:" + values[3];
            }
        }

        /// <summary>
        /// 获取电量
        /// </summary>
        private void loadBatteryInfo()
        {
            TaskInfo task = new TaskInfo(TaskType.BatteryInfo);
            task.ResultHandler = new TaskInfo.EventResultHandler(updateBatteryInfoReuslt);
            taskThread.SendTask(task);
        }

        /// <summary>
        /// 电池信息的返回
        /// </summary>
        /// <param name="data"></param>
        private void updateBatteryInfoReuslt(object[] data)
        {
            if (data[0].GetType() == typeof(Bitmap))
            {
                this.pictureBoxBattery.Image = (Image)data[0];
            }
            if (data[1].GetType() == typeof(string))
            {
                batteryFormatInfo = data[1].ToString();
            }
        }

        /// <summary>
        /// 载入屏幕截图
        /// </summary>
        private void loadScreenShot()
        {
            this.screenShotPath = ScreenData.GetScreemShotPath();
            try
            {
                File.Delete(this.screenShotPath);
            }
            catch
            {

            }
            TaskInfo t = TaskInfo.Create(TaskType.ScreenShot, this.screenShotPath);
            t.ResultHandler = new TaskInfo.EventResultHandler(getScreenShotResult);
            taskThread.SendTask(t);
        }

        /// <summary>
        /// 截图返回结果
        /// </summary>
        /// <param name="result"></param>
        private void getScreenShotResult(object[] result)
        {
            if (result != null)
            {
                Image image = (Image)result[0];
                this.pictureBoxScreenShot.Image = image;
                //this.pictureBoxScreenShot.Width = (image.Width * pictureBoxScreenShot.Height / image.Height);
            }
        }
        #endregion

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

        /// <summary>
        /// 刷新屏幕截图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefreshScreen_Click(object sender, EventArgs e)
        {
            loadScreenShot();
        }

    }
}
