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
    public partial class FormImagePreview : Form
    {
        private string imagePath = null;

        public FormImagePreview(string imagePath)
        {
            InitializeComponent();
            this.imagePath = imagePath;
        }

        public FormImagePreview()
        {
            InitializeComponent();
        }

        private void FormImagePreview_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                this.pictureBoxPreview.Image = image;
                resizeForm();
            }
        }

        /// <summary>
        /// 根据图片大小变化窗口
        /// </summary>
        private void resizeForm()
        {
            Rectangle r = Screen.GetWorkingArea(this);
            int imageHeight = pictureBoxPreview.Image.Height;
            int imageWidth = pictureBoxPreview.Image.Width;

            // 尺寸超过屏幕，要缩小
            if (imageHeight > r.Height)
            {
                int h = r.Height - 100;
                this.Height = h;
                this.Width = (int)(imageWidth * 1.0 * h / imageHeight);
            }
            else
            {
                this.Width = imageWidth;
                this.Height = imageHeight;
            }
            int x = (r.Width - this.Width) / 2;
            int y = (r.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void FormImagePreview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
