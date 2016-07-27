namespace KibotController
{
    partial class FormScreenShot
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.buttonClip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRefresh.Location = new System.Drawing.Point(44, 27);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "刷新(&R)";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRotate.Location = new System.Drawing.Point(193, 27);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 1;
            this.buttonRotate.Text = "旋转";
            this.buttonRotate.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSave.Location = new System.Drawing.Point(358, 27);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存(&S)";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonQuit.Location = new System.Drawing.Point(681, 27);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "关闭(&Q)";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonClip
            // 
            this.buttonClip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClip.Location = new System.Drawing.Point(514, 27);
            this.buttonClip.Name = "buttonClip";
            this.buttonClip.Size = new System.Drawing.Size(75, 23);
            this.buttonClip.TabIndex = 2;
            this.buttonClip.Text = "复制";
            this.buttonClip.UseVisualStyleBackColor = true;
            this.buttonClip.Click += new System.EventHandler(this.buttonClip_Click);
            // 
            // FormScreenShot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 649);
            this.Controls.Add(this.buttonClip);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormScreenShot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "屏幕截图";
            this.Load += new System.EventHandler(this.FormScreenShot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        private System.Windows.Forms.Button buttonClip;
    }
}