using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Pages
{
    /// <summary>
    /// 录制视频
    /// </summary>
    public partial class FormScreenRecord : Form
    {
        public FormScreenRecord()
        {
            InitializeComponent();
        }

        private void FormScreenRecord_Load(object sender, EventArgs e)
        {
            this.comboBoxSize.SelectedIndex = 0;
            this.comboBoxTime.SelectedIndex = 0;
        }
        /// <summary>
        /// 开始录制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartRecord_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 停止录制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
