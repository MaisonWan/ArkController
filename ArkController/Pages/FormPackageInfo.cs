using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArkController.Kit;

namespace ArkController.Pages
{
    public partial class FormPackageInfo : Form
    {
        private string packageName = null;
        private IConnect connect = null;

        /// <summary>
        /// 包名，需要获取信息
        /// </summary>
        public string PakcageName
        {
            get { return this.packageName; }
            set { this.packageName = value; }
        }

        public FormPackageInfo(IConnect connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void FormPackageInfo_Load(object sender, EventArgs e)
        {
            
            UpdatePackageInfo(this.packageName);
        }

        private void buttonGetPackageInfo_Click(object sender, EventArgs e)
        {
            UpdatePackageInfo(this.packageName);
        }

        /// <summary>
        /// 更新显示包名和信息
        /// </summary>
        /// <param name="package"></param>
        public void UpdatePackageInfo(string package)
        {
            this.Text = package;
            this.textBoxPackage.Text = package;
            string cmd = "shell dumpsys package " + package;
            this.textBoxPackageInfo.Text = this.connect.ExecuteAdb(cmd);
        }
    }
}
