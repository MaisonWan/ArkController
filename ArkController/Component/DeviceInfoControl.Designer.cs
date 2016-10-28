namespace ArkController.Component
{
    partial class DeviceInfoControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentInputMethod = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelScreenDensity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelScreenSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSystemDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelFocusActivity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDevice = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelDeviceInfo = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.toolTipBattery = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRefreshScreen = new System.Windows.Forms.Button();
            this.pictureBoxBattery = new System.Windows.Forms.PictureBox();
            this.pictureBoxScreenShot = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前输入法";
            // 
            // labelCurrentInputMethod
            // 
            this.labelCurrentInputMethod.AutoSize = true;
            this.labelCurrentInputMethod.Location = new System.Drawing.Point(87, 26);
            this.labelCurrentInputMethod.Name = "labelCurrentInputMethod";
            this.labelCurrentInputMethod.Size = new System.Drawing.Size(0, 12);
            this.labelCurrentInputMethod.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelCurrentInputMethod);
            this.groupBox1.Location = new System.Drawing.Point(17, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入法";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelScreenDensity);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelScreenSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelSystemDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统";
            // 
            // labelScreenDensity
            // 
            this.labelScreenDensity.AutoSize = true;
            this.labelScreenDensity.Location = new System.Drawing.Point(483, 17);
            this.labelScreenDensity.Name = "labelScreenDensity";
            this.labelScreenDensity.Size = new System.Drawing.Size(0, 12);
            this.labelScreenDensity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "像素密度：";
            // 
            // labelScreenSize
            // 
            this.labelScreenSize.AutoSize = true;
            this.labelScreenSize.Location = new System.Drawing.Point(339, 17);
            this.labelScreenSize.Name = "labelScreenSize";
            this.labelScreenSize.Size = new System.Drawing.Size(0, 12);
            this.labelScreenSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "分辨率：";
            // 
            // labelSystemDate
            // 
            this.labelSystemDate.AutoSize = true;
            this.labelSystemDate.Location = new System.Drawing.Point(81, 17);
            this.labelSystemDate.Name = "labelSystemDate";
            this.labelSystemDate.Size = new System.Drawing.Size(0, 12);
            this.labelSystemDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设备日期：";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelFocusActivity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(17, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 59);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "显示";
            // 
            // labelFocusActivity
            // 
            this.labelFocusActivity.AutoSize = true;
            this.labelFocusActivity.Location = new System.Drawing.Point(87, 26);
            this.labelFocusActivity.Name = "labelFocusActivity";
            this.labelFocusActivity.Size = new System.Drawing.Size(0, 12);
            this.labelFocusActivity.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "顶层Activity：";
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDevice.Location = new System.Drawing.Point(122, 68);
            this.labelDevice.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelDevice.MinimumSize = new System.Drawing.Size(0, 21);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(0, 21);
            this.labelDevice.TabIndex = 11;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelModel.Location = new System.Drawing.Point(122, 50);
            this.labelModel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelModel.MinimumSize = new System.Drawing.Size(0, 21);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(0, 21);
            this.labelModel.TabIndex = 12;
            // 
            // labelDeviceInfo
            // 
            this.labelDeviceInfo.AutoSize = true;
            this.labelDeviceInfo.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDeviceInfo.Location = new System.Drawing.Point(122, 14);
            this.labelDeviceInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelDeviceInfo.MinimumSize = new System.Drawing.Size(0, 21);
            this.labelDeviceInfo.Name = "labelDeviceInfo";
            this.labelDeviceInfo.Size = new System.Drawing.Size(0, 21);
            this.labelDeviceInfo.TabIndex = 13;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProduct.Location = new System.Drawing.Point(122, 32);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelProduct.MinimumSize = new System.Drawing.Size(0, 21);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(0, 21);
            this.labelProduct.TabIndex = 14;
            // 
            // toolTipBattery
            // 
            this.toolTipBattery.AutoPopDelay = 10000;
            this.toolTipBattery.InitialDelay = 500;
            this.toolTipBattery.IsBalloon = true;
            this.toolTipBattery.ReshowDelay = 100;
            // 
            // buttonRefreshScreen
            // 
            this.buttonRefreshScreen.BackgroundImage = global::ArkController.Properties.Resources.refresh1;
            this.buttonRefreshScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefreshScreen.Location = new System.Drawing.Point(17, 3);
            this.buttonRefreshScreen.Name = "buttonRefreshScreen";
            this.buttonRefreshScreen.Size = new System.Drawing.Size(25, 25);
            this.buttonRefreshScreen.TabIndex = 16;
            this.buttonRefreshScreen.UseVisualStyleBackColor = true;
            this.buttonRefreshScreen.Click += new System.EventHandler(this.buttonRefreshScreen_Click);
            // 
            // pictureBoxBattery
            // 
            this.pictureBoxBattery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBattery.Image = global::ArkController.Properties.Resources.battery_5;
            this.pictureBoxBattery.Location = new System.Drawing.Point(884, 21);
            this.pictureBoxBattery.Name = "pictureBoxBattery";
            this.pictureBoxBattery.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBattery.TabIndex = 15;
            this.pictureBoxBattery.TabStop = false;
            // 
            // pictureBoxScreenShot
            // 
            this.pictureBoxScreenShot.Image = global::ArkController.Properties.Resources.phone;
            this.pictureBoxScreenShot.Location = new System.Drawing.Point(35, 3);
            this.pictureBoxScreenShot.Name = "pictureBoxScreenShot";
            this.pictureBoxScreenShot.Size = new System.Drawing.Size(81, 84);
            this.pictureBoxScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenShot.TabIndex = 10;
            this.pictureBoxScreenShot.TabStop = false;
            this.pictureBoxScreenShot.Click += new System.EventHandler(this.pictureBoxScreenShot_Click);
            // 
            // DeviceInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefreshScreen);
            this.Controls.Add(this.pictureBoxBattery);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelDeviceInfo);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.pictureBoxScreenShot);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviceInfoControl";
            this.Size = new System.Drawing.Size(1000, 523);
            this.Load += new System.EventHandler(this.DeviceInfoInputMethodControl_Load);
            this.MouseEnter += new System.EventHandler(this.pictureBoxBattery_MouseEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenShot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentInputMethod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSystemDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelScreenSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelScreenDensity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFocusActivity;
        private System.Windows.Forms.PictureBox pictureBoxScreenShot;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelDeviceInfo;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.PictureBox pictureBoxBattery;
        private System.Windows.Forms.ToolTip toolTipBattery;
        private System.Windows.Forms.Button buttonRefreshScreen;
    }
}
