namespace ArkController.Pages
{
    partial class FormPackageInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPackageInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.textBoxPackageInfo = new System.Windows.Forms.TextBox();
            this.buttonGetPackageInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialogLog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "应用包名：";
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackage.Location = new System.Drawing.Point(75, 10);
            this.textBoxPackage.MaxLength = 1024;
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.Size = new System.Drawing.Size(769, 21);
            this.textBoxPackage.TabIndex = 1;
            // 
            // textBoxPackageInfo
            // 
            this.textBoxPackageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackageInfo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPackageInfo.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPackageInfo.Location = new System.Drawing.Point(13, 46);
            this.textBoxPackageInfo.Multiline = true;
            this.textBoxPackageInfo.Name = "textBoxPackageInfo";
            this.textBoxPackageInfo.ReadOnly = true;
            this.textBoxPackageInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPackageInfo.Size = new System.Drawing.Size(1020, 666);
            this.textBoxPackageInfo.TabIndex = 2;
            this.textBoxPackageInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPackageInfo_KeyDown);
            // 
            // buttonGetPackageInfo
            // 
            this.buttonGetPackageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetPackageInfo.Location = new System.Drawing.Point(850, 8);
            this.buttonGetPackageInfo.Name = "buttonGetPackageInfo";
            this.buttonGetPackageInfo.Size = new System.Drawing.Size(102, 23);
            this.buttonGetPackageInfo.TabIndex = 3;
            this.buttonGetPackageInfo.Text = "显示应用信息";
            this.buttonGetPackageInfo.UseVisualStyleBackColor = true;
            this.buttonGetPackageInfo.Click += new System.EventHandler(this.buttonGetPackageInfo_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(958, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormPackageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 714);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGetPackageInfo);
            this.Controls.Add(this.textBoxPackageInfo);
            this.Controls.Add(this.textBoxPackage);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPackageInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "应用信息";
            this.Load += new System.EventHandler(this.FormPackageInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.TextBox textBoxPackageInfo;
        private System.Windows.Forms.Button buttonGetPackageInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogLog;
    }
}