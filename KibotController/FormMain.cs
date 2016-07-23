using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KibotController
{
    public partial class FormMain : Form
    {
        private Log log = null;
        private IConnect connect = null;
        public FormMain()
        {
            InitializeComponent();
            log = new Log(textBoxLog);
            connect = new AdbConnect(log);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            connect.InputKey(4);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            connect.InputKey(3);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            connect.InputKey(65);
        }

        private void buttonVolumeUp_Click(object sender, EventArgs e)
        {
            connect.InputKey(24);
        }

        private void buttonVolumeDown_Click(object sender, EventArgs e)
        {
            connect.InputKey(25);
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            connect.InputKey(26);
        }

        private void buttonSendText_Click(object sender, EventArgs e)
        {
            string text = this.textBoxSendText.Text;
            connect.InputText(text);
        }

        private void textBoxSendText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = this.textBoxSendText.Text;
                connect.InputText(text);
            }
        }

        private void buttonDevices_Click(object sender, EventArgs e)
        {
            connect.InputCommand("devices");
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            string localPath = Environment.CurrentDirectory + "\\screen.png";
            if (connect.GetScreenShot(localPath))
            {
                FormScreenShot screenShot = new FormScreenShot();
                screenShot.ScreenShotPath = localPath;
                screenShot.Connect = connect;
                screenShot.ShowDialog();
            }
        }

        /// <summary>
        /// 安装程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstall_Click(object sender, EventArgs e)
        {
            this.openFileDialogInstall.Filter = "Android程序(*.apk)|*.apk";
            this.openFileDialogInstall.RestoreDirectory = true;
            this.openFileDialogInstall.FileName = "";
            if (this.openFileDialogInstall.ShowDialog() == DialogResult.OK)
            {
                string filePath = this.openFileDialogInstall.FileName;
                install(filePath);
            }
        }

        private void buttonInstall_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonInstall_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i].Trim() != "")
                {
                    install(s[i].Trim());
                }
            }
        }

        private void install(string path)
        {
            string filePath = this.openFileDialogInstall.FileName;
            if (connect.Install(filePath))
            {
                MessageBox.Show(filePath + "安装成功", "安装", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(filePath + "安装失败", "安装", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
