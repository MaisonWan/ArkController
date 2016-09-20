using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Component
{
    public partial class ImageButtonControl : UserControl
    {
        public ImageButtonControl()
        {
            InitializeComponent();
        }

        [CategoryAttribute("自定义属性"), DescriptionAttribute("按钮图片")]
        public Image Image
        {
            set
            {
                this.pictureBoxIcon.Image = value;
            }
        }

        [CategoryAttribute("自定义属性"), DescriptionAttribute("按钮名称"), DefaultValue("按钮")]
        public string ButtonName
        {
            set
            {
                this.labelName.Text = value;
            }
            get
            {
                return this.labelName.Text;
            }
        }
    }
}
