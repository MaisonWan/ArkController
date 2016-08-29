namespace ArkController.Pages
{
    partial class FormScreenSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScreenSize));
            this.label1 = new System.Windows.Forms.Label();
            this.labelScreenSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScreenDensity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxSizeWidth = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxSizeHeight = new System.Windows.Forms.MaskedTextBox();
            this.buttonSizeSet = new System.Windows.Forms.Button();
            this.buttonSizeReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDensitySet = new System.Windows.Forms.Button();
            this.buttonDensityReset = new System.Windows.Forms.Button();
            this.maskedTextBoxDensity = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备分辨率：";
            // 
            // labelScreenSize
            // 
            this.labelScreenSize.AutoSize = true;
            this.labelScreenSize.Location = new System.Drawing.Point(96, 13);
            this.labelScreenSize.Name = "labelScreenSize";
            this.labelScreenSize.Size = new System.Drawing.Size(0, 12);
            this.labelScreenSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "像素密度：";
            // 
            // labelScreenDensity
            // 
            this.labelScreenDensity.AutoSize = true;
            this.labelScreenDensity.Location = new System.Drawing.Point(267, 13);
            this.labelScreenDensity.Name = "labelScreenDensity";
            this.labelScreenDensity.Size = new System.Drawing.Size(0, 12);
            this.labelScreenDensity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "设置分辨率：";
            // 
            // maskedTextBoxSizeWidth
            // 
            this.maskedTextBoxSizeWidth.Location = new System.Drawing.Point(86, 55);
            this.maskedTextBoxSizeWidth.Mask = "9999";
            this.maskedTextBoxSizeWidth.Name = "maskedTextBoxSizeWidth";
            this.maskedTextBoxSizeWidth.Size = new System.Drawing.Size(35, 21);
            this.maskedTextBoxSizeWidth.TabIndex = 1;
            this.maskedTextBoxSizeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "x";
            // 
            // maskedTextBoxSizeHeight
            // 
            this.maskedTextBoxSizeHeight.Location = new System.Drawing.Point(145, 55);
            this.maskedTextBoxSizeHeight.Mask = "9999";
            this.maskedTextBoxSizeHeight.Name = "maskedTextBoxSizeHeight";
            this.maskedTextBoxSizeHeight.Size = new System.Drawing.Size(33, 21);
            this.maskedTextBoxSizeHeight.TabIndex = 2;
            this.maskedTextBoxSizeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSizeSet
            // 
            this.buttonSizeSet.Location = new System.Drawing.Point(204, 53);
            this.buttonSizeSet.Name = "buttonSizeSet";
            this.buttonSizeSet.Size = new System.Drawing.Size(63, 23);
            this.buttonSizeSet.TabIndex = 3;
            this.buttonSizeSet.Text = "设置";
            this.buttonSizeSet.UseVisualStyleBackColor = true;
            this.buttonSizeSet.Click += new System.EventHandler(this.buttonSizeSet_Click);
            // 
            // buttonSizeReset
            // 
            this.buttonSizeReset.Location = new System.Drawing.Point(291, 53);
            this.buttonSizeReset.Name = "buttonSizeReset";
            this.buttonSizeReset.Size = new System.Drawing.Size(61, 23);
            this.buttonSizeReset.TabIndex = 4;
            this.buttonSizeReset.Text = "重置";
            this.buttonSizeReset.UseVisualStyleBackColor = true;
            this.buttonSizeReset.Click += new System.EventHandler(this.buttonSizeReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "设置像素密度：";
            // 
            // buttonDensitySet
            // 
            this.buttonDensitySet.Location = new System.Drawing.Point(204, 92);
            this.buttonDensitySet.Name = "buttonDensitySet";
            this.buttonDensitySet.Size = new System.Drawing.Size(63, 23);
            this.buttonDensitySet.TabIndex = 6;
            this.buttonDensitySet.Text = "设置";
            this.buttonDensitySet.UseVisualStyleBackColor = true;
            this.buttonDensitySet.Click += new System.EventHandler(this.buttonDensitySet_Click);
            // 
            // buttonDensityReset
            // 
            this.buttonDensityReset.Location = new System.Drawing.Point(291, 92);
            this.buttonDensityReset.Name = "buttonDensityReset";
            this.buttonDensityReset.Size = new System.Drawing.Size(61, 23);
            this.buttonDensityReset.TabIndex = 7;
            this.buttonDensityReset.Text = "重置";
            this.buttonDensityReset.UseVisualStyleBackColor = true;
            this.buttonDensityReset.Click += new System.EventHandler(this.buttonDensityReset_Click);
            // 
            // maskedTextBoxDensity
            // 
            this.maskedTextBoxDensity.Location = new System.Drawing.Point(108, 94);
            this.maskedTextBoxDensity.Mask = "9999";
            this.maskedTextBoxDensity.Name = "maskedTextBoxDensity";
            this.maskedTextBoxDensity.Size = new System.Drawing.Size(70, 21);
            this.maskedTextBoxDensity.TabIndex = 5;
            this.maskedTextBoxDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormScreenSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 156);
            this.Controls.Add(this.buttonDensityReset);
            this.Controls.Add(this.buttonSizeReset);
            this.Controls.Add(this.buttonDensitySet);
            this.Controls.Add(this.buttonSizeSet);
            this.Controls.Add(this.maskedTextBoxDensity);
            this.Controls.Add(this.maskedTextBoxSizeHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxSizeWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelScreenDensity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelScreenSize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormScreenSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "屏幕尺寸像素密度";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScreenSize_FormClosing);
            this.Load += new System.EventHandler(this.FormScreenSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScreenSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScreenDensity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSizeWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSizeHeight;
        private System.Windows.Forms.Button buttonSizeSet;
        private System.Windows.Forms.Button buttonSizeReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDensitySet;
        private System.Windows.Forms.Button buttonDensityReset;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDensity;
    }
}