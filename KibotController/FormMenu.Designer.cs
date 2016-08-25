namespace KibotController
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.tabControlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPageInfo);
            this.tabControlInfo.Controls.Add(this.tabPage2);
            this.tabControlInfo.Controls.Add(this.tabPage3);
            this.tabControlInfo.HotTrack = true;
            this.tabControlInfo.ImageList = this.imageListTabs;
            this.tabControlInfo.ItemSize = new System.Drawing.Size(60, 60);
            this.tabControlInfo.Location = new System.Drawing.Point(3, 34);
            this.tabControlInfo.Multiline = true;
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(969, 716);
            this.tabControlInfo.TabIndex = 0;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.AllowDrop = true;
            this.tabPageInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageInfo.Location = new System.Drawing.Point(4, 64);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(961, 648);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "设备信息";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 64);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 64);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(961, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "1074685.png");
            this.imageListTabs.Images.SetKeyName(1, "1101129.png");
            this.imageListTabs.Images.SetKeyName(2, "1101130.png");
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.tabControlInfo);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.tabControlInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageListTabs;
    }
}