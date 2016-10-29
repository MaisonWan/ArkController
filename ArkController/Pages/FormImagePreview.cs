using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArkController.Component;

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

        public FormImagePreview(Image image)
        {
            InitializeComponent();
            this.pictureBoxPreview.Image = image;
            resizeForm();
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

        #region 右键菜单
        /// <summary>
        /// 复制图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.pictureBoxPreview.Image);
        }

        /// <summary>
        /// 另存为图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mToolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog();
        }

        private void ShowSaveFileDialog()
        {
            string filter = "PNG（*.png）|*.png|JPEG（*.jpg）|*.jpg|BMP（*.bmp）|*.bmp|Gif（*.gif）|*.gif|TIFF（*.tiff）|*.tiff|EXIF（*.exif）|*.exif";
            string fileName = "screenshot" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            SaveFileDialog dialog = DialogKit.GetSaveFileDialog(fileName, filter);

            if (dialog != null)
            {
                string path = dialog.FileName.ToString();
                int selectIndex = dialog.FilterIndex;
                ImageFormat format;
                switch (selectIndex)
                {
                    case 1:
                        format = ImageFormat.Png;
                        break;
                    case 2:
                        format = ImageFormat.Jpeg;
                        break;
                    case 3:
                        format = ImageFormat.Bmp;
                        break;
                    case 4:
                        format = ImageFormat.Gif;
                        break;
                    case 5:
                        format = ImageFormat.Tiff;
                        break;
                    case 6:
                        format = ImageFormat.Exif;
                        break;
                    default:
                        format = ImageFormat.Png;
                        break;
                }
                this.pictureBoxPreview.Image.Save(path, format);
            }
        }
        #endregion

    }
}
