using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArkController.Data;
using ArkController.Kit;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormScreenSize : Form
    {
        private ConnectTaskThread taskThread = null;

        public FormScreenSize()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void FormScreenSize_Load(object sender, EventArgs e)
        {
            getScreenInfo();
        }

        private void FormScreenSize_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// 多线程获取屏幕信息
        /// </summary>
        private void getScreenInfo()
        {

            TaskInfo tSize = TaskInfo.Create(TaskType.ScreenSizeDensity, new object[] { ScreenData.Action.GetSize.ToString() });
            tSize.ResultHandler = new TaskInfo.EventResultHandler(getScreenSizeResult);
            taskThread.SendTask(tSize);

            TaskInfo tDensity = TaskInfo.Create(TaskType.ScreenSizeDensity, new object[] { ScreenData.Action.GetDensity.ToString() });
            tDensity.ResultHandler = new TaskInfo.EventResultHandler(getScreenDensityResult);
            taskThread.SendTask(tDensity);
        }

        /// <summary>
        /// 获取屏幕尺寸
        /// </summary>
        /// <param name="result"></param>
        private void getScreenSizeResult(object[] result)
        {
            Size size = (Size)result[0];
            this.labelScreenSize.Text = String.Format("{0}x{1}", size.Width, size.Height);
        }

        /// <summary>
        /// 像素密度
        /// </summary>
        /// <param name="result"></param>
        private void getScreenDensityResult(object[] result)
        {
            int density = (int)result[0];
            this.labelScreenDensity.Text = density.ToString();
        }

        /// <summary>
        /// 设置屏幕尺寸
        /// </summary>
        /// <param name="result"></param>
        private void setScreenSizeResult(object[] result)
        {
            string message = "设置屏幕尺寸失败";
            if ((bool)result[0])
            {
                message = "屏幕尺寸设置成功";
                getScreenInfo();
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 设置像素密度
        /// </summary>
        /// <param name="result"></param>
        private void setScreenDensityResult(object[] result)
        {
            string message = "设置屏幕像素密度失败";
            if ((bool)result[0])
            {
                message = "设置屏幕像素密度成功";
                getScreenInfo();
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Reset屏幕尺寸
        /// </summary>
        /// <param name="result"></param>
        private void resetScreenSizeResult(object[] result)
        {
            string message = "重置屏幕尺寸失败";
            if ((bool)result[0])
            {
                message = "重置屏幕尺寸成功";
                getScreenInfo();
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Reset像素密度
        /// </summary>
        /// <param name="result"></param>
        private void resetScreenDensityResult(object[] result)
        {
            string message = "重置屏幕像素密度失败";
            if ((bool)result[0])
            {
                message = "重置屏幕像素密度成功";
                getScreenInfo();
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSizeSet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.maskedTextBoxSizeWidth.Text) ||
                string.IsNullOrEmpty(this.maskedTextBoxSizeHeight.Text))
            {
                return;
            }
            int width = Convert.ToInt32(this.maskedTextBoxSizeWidth.Text);
            int height = Convert.ToInt32(this.maskedTextBoxSizeHeight.Text);
            object[] args = {ScreenData.Action.SetSize.ToString(), width, height};
            TaskInfo tSize = TaskInfo.Create(TaskType.ScreenSizeDensity, args);
            tSize.ResultHandler = new TaskInfo.EventResultHandler(setScreenSizeResult);
            taskThread.SendTask(tSize);
        }

        private void buttonSizeReset_Click(object sender, EventArgs e)
        {
            object[] args = { ScreenData.Action.ResetSize.ToString() };
            TaskInfo tSize = TaskInfo.Create(TaskType.ScreenSizeDensity, args);
            tSize.ResultHandler = new TaskInfo.EventResultHandler(resetScreenSizeResult);
            taskThread.SendTask(tSize);
        }

        private void buttonDensitySet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.maskedTextBoxDensity.Text))
            {
                return;
            }
            int density = Convert.ToInt32(this.maskedTextBoxDensity.Text);
            object[] args = { ScreenData.Action.SetDensity.ToString(), density };
            TaskInfo t = TaskInfo.Create(TaskType.ScreenSizeDensity, args);
            t.ResultHandler = new TaskInfo.EventResultHandler(setScreenDensityResult);
            taskThread.SendTask(t);
        }

        private void buttonDensityReset_Click(object sender, EventArgs e)
        {
            object[] args = { ScreenData.Action.ResetDensity.ToString() };
            TaskInfo tSize = TaskInfo.Create(TaskType.ScreenSizeDensity, args);
            tSize.ResultHandler = new TaskInfo.EventResultHandler(resetScreenDensityResult);
            taskThread.SendTask(tSize);
        }

    }
}
