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

namespace ArkController.Pages
{
    public partial class FormScreenSize : Form
    {
        private ScreenData screenData = null;
        private Thread thread = null;

        private delegate void UpdateScreenSize(int width, int height);
        private delegate void UpdateScreenDensity(int density);

        public FormScreenSize(ScreenData connect)
        {
            InitializeComponent();
            this.screenData = connect;
        }

        private void FormScreenSize_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(getScreenInfo));
            thread.Start();
        }

        private void FormScreenSize_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }

        private void updateSize(int width, int height)
        {
            this.labelScreenSize.Text = String.Format("{0}x{1}", width, height);
        }

        private void updateDensity(int density)
        {
            this.labelScreenDensity.Text = density.ToString();
        }

        /// <summary>
        /// 多线程获取屏幕信息
        /// </summary>
        private void getScreenInfo()
        {
            // 获取屏幕像素密度和分辨率
            Size size = screenData.GetScreenSize();
            if (this.InvokeRequired)
            {
                UpdateScreenSize uss = new UpdateScreenSize(updateSize);
                this.Invoke(uss, new object[] { size.Width, size.Height });
            }
            else
            {
                updateSize(size.Width, size.Height);
            }
            int density = screenData.GetScreenDensity();
            if (this.InvokeRequired)
            {
                UpdateScreenDensity usd = new UpdateScreenDensity(updateDensity);
                this.Invoke(usd, new object[] { density });
            }
            else
            {
                updateDensity(density);
            }
        }

        private void buttonSizeSet_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(this.maskedTextBoxSizeWidth.Text);
            int height = Convert.ToInt32(this.maskedTextBoxSizeHeight.Text);
            string message = "设置屏幕尺寸失败";
            if (screenData.SetScreenSize(width, height))
            {
                message = "屏幕尺寸设置成功";
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSizeReset_Click(object sender, EventArgs e)
        {
            string message = "重置屏幕尺寸失败";
            if (screenData.ResetScreenSize())
            {
                message = "重置尺寸设置成功";
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDensitySet_Click(object sender, EventArgs e)
        {
            int density = Convert.ToInt32(this.maskedTextBoxDensity.Text);
            string message = "设置屏幕像素密度失败";
            if (screenData.SetScreenDensity(density))
            {
                message = "屏幕尺寸像素密度成功";
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDensityReset_Click(object sender, EventArgs e)
        {
            string message = "重置屏幕像素密度失败";
            if (screenData.ResetScreenDensity())
            {
                message = "重置尺寸像素密度成功";
            }
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
