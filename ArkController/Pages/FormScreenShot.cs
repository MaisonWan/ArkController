using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ArkController.Kit;
using ArkController.Task;

namespace ArkController.Pages
{
    public partial class FormScreenShot : Form
    {
        private string screenShotPath = null;
        private ConnectTaskThread taskThread = null;

        public FormScreenShot()
        {
            InitializeComponent();
            taskThread = ConnectTaskThread.GetInstance();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 截图路径
        /// </summary>
        public string ScreenShotPath
        {
            set { this.screenShotPath = value; }
            get { return this.screenShotPath; }
        }

        private void FormScreenShot_Load(object sender, EventArgs e)
        {
            ReloadPicture();
        }

        public void ReloadPicture()
        {
            buttonRefresh_Click(null, null);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 保存文件到别的目录
            ShowSaveFileDialog();
        }

        #region 保存对话框
        private void ShowSaveFileDialog()
        {
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = this.saveFileDialogImage;
            //设置文件类型 
            sfd.Filter = "图片文件（*.png）|*.png|图片文件（*.jpg）|*.jpg";
            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;
            sfd.FileName = "screenshot" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                this.pictureBox1.Image.Save(localFilePath);
            }
        }
        #endregion

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.screenShotPath = GetScreemShotPath();
            File.Delete(this.screenShotPath);
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
                this.pictureBox1.Image = (Image)result[0];
            }
        }

        /// <summary>
        /// 得到屏幕截图路径
        /// </summary>
        /// <returns></returns>
        private string GetScreemShotPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appDataPath = path + @"\ArkController\Screen";
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            string localPath = appDataPath + @"\screenshot";
            return localPath;
        }

        private void buttonClip_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.pictureBox1.Image);
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.pictureBox1.Image = img;
        }
    }
}
