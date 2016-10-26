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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentInputMethod = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSystemDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelScreenSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelScreenDensity = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFocusActivity = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 112);
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
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统";
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
            // labelSystemDate
            // 
            this.labelSystemDate.AutoSize = true;
            this.labelSystemDate.Location = new System.Drawing.Point(81, 17);
            this.labelSystemDate.Name = "labelSystemDate";
            this.labelSystemDate.Size = new System.Drawing.Size(0, 12);
            this.labelSystemDate.TabIndex = 1;
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
            // labelScreenSize
            // 
            this.labelScreenSize.AutoSize = true;
            this.labelScreenSize.Location = new System.Drawing.Point(339, 17);
            this.labelScreenSize.Name = "labelScreenSize";
            this.labelScreenSize.Size = new System.Drawing.Size(0, 12);
            this.labelScreenSize.TabIndex = 3;
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
            // labelScreenDensity
            // 
            this.labelScreenDensity.AutoSize = true;
            this.labelScreenDensity.Location = new System.Drawing.Point(483, 17);
            this.labelScreenDensity.Name = "labelScreenDensity";
            this.labelScreenDensity.Size = new System.Drawing.Size(0, 12);
            this.labelScreenDensity.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelFocusActivity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(16, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 59);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "显示";
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
            // labelFocusActivity
            // 
            this.labelFocusActivity.AutoSize = true;
            this.labelFocusActivity.Location = new System.Drawing.Point(87, 26);
            this.labelFocusActivity.Name = "labelFocusActivity";
            this.labelFocusActivity.Size = new System.Drawing.Size(0, 12);
            this.labelFocusActivity.TabIndex = 1;
            // 
            // DeviceInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviceInfoControl";
            this.Size = new System.Drawing.Size(1000, 523);
            this.Load += new System.EventHandler(this.DeviceInfoInputMethodControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
