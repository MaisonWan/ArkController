namespace ArkController.Pages
{
    partial class FormPackageDump
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPackageDump));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGetPackageDump = new System.Windows.Forms.Button();
            this.textBoxPackageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePackage = new System.Windows.Forms.TabPage();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.tabPageActivity = new System.Windows.Forms.TabPage();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.tabPageMeminfo = new System.Windows.Forms.TabPage();
            this.textBoxMeminfo = new System.Windows.Forms.TextBox();
            this.tabPageProcstats = new System.Windows.Forms.TabPage();
            this.textBoxProcstats = new System.Windows.Forms.TextBox();
            this.tabPageUsagestats = new System.Windows.Forms.TabPage();
            this.textBoxUsagestats = new System.Windows.Forms.TextBox();
            this.tabPageBatterystats = new System.Windows.Forms.TabPage();
            this.textBoxBatterystats = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPagePackage.SuspendLayout();
            this.tabPageActivity.SuspendLayout();
            this.tabPageMeminfo.SuspendLayout();
            this.tabPageProcstats.SuspendLayout();
            this.tabPageUsagestats.SuspendLayout();
            this.tabPageBatterystats.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(967, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存信息";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonGetPackageDump
            // 
            this.buttonGetPackageDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetPackageDump.Location = new System.Drawing.Point(835, 10);
            this.buttonGetPackageDump.Name = "buttonGetPackageDump";
            this.buttonGetPackageDump.Size = new System.Drawing.Size(126, 23);
            this.buttonGetPackageDump.TabIndex = 7;
            this.buttonGetPackageDump.Text = "获取应用系统状态";
            this.buttonGetPackageDump.UseVisualStyleBackColor = true;
            this.buttonGetPackageDump.Click += new System.EventHandler(this.buttonGetPackageDump_Click);
            // 
            // textBoxPackageName
            // 
            this.textBoxPackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackageName.Location = new System.Drawing.Point(75, 12);
            this.textBoxPackageName.MaxLength = 1024;
            this.textBoxPackageName.Name = "textBoxPackageName";
            this.textBoxPackageName.Size = new System.Drawing.Size(754, 21);
            this.textBoxPackageName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "程序包名：";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePackage);
            this.tabControl1.Controls.Add(this.tabPageActivity);
            this.tabControl1.Controls.Add(this.tabPageMeminfo);
            this.tabControl1.Controls.Add(this.tabPageProcstats);
            this.tabControl1.Controls.Add(this.tabPageUsagestats);
            this.tabControl1.Controls.Add(this.tabPageBatterystats);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(14, 48);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 643);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPagePackage
            // 
            this.tabPagePackage.Controls.Add(this.textBoxPackage);
            this.tabPagePackage.Location = new System.Drawing.Point(4, 22);
            this.tabPagePackage.Name = "tabPagePackage";
            this.tabPagePackage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePackage.Size = new System.Drawing.Size(1020, 617);
            this.tabPagePackage.TabIndex = 0;
            this.tabPagePackage.Text = "Package";
            this.tabPagePackage.UseVisualStyleBackColor = true;
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPackage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPackage.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPackage.Location = new System.Drawing.Point(3, 3);
            this.textBoxPackage.Multiline = true;
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.ReadOnly = true;
            this.textBoxPackage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPackage.Size = new System.Drawing.Size(1014, 608);
            this.textBoxPackage.TabIndex = 0;
            // 
            // tabPageActivity
            // 
            this.tabPageActivity.Controls.Add(this.textBoxActivity);
            this.tabPageActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageActivity.Name = "tabPageActivity";
            this.tabPageActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActivity.Size = new System.Drawing.Size(1020, 617);
            this.tabPageActivity.TabIndex = 1;
            this.tabPageActivity.Text = "Activity";
            this.tabPageActivity.UseVisualStyleBackColor = true;
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxActivity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxActivity.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxActivity.Location = new System.Drawing.Point(3, 4);
            this.textBoxActivity.Multiline = true;
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.ReadOnly = true;
            this.textBoxActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxActivity.Size = new System.Drawing.Size(1014, 608);
            this.textBoxActivity.TabIndex = 1;
            // 
            // tabPageMeminfo
            // 
            this.tabPageMeminfo.Controls.Add(this.textBoxMeminfo);
            this.tabPageMeminfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeminfo.Name = "tabPageMeminfo";
            this.tabPageMeminfo.Size = new System.Drawing.Size(1020, 617);
            this.tabPageMeminfo.TabIndex = 2;
            this.tabPageMeminfo.Text = "Meminfo";
            this.tabPageMeminfo.UseVisualStyleBackColor = true;
            // 
            // textBoxMeminfo
            // 
            this.textBoxMeminfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMeminfo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMeminfo.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMeminfo.Location = new System.Drawing.Point(3, 4);
            this.textBoxMeminfo.Multiline = true;
            this.textBoxMeminfo.Name = "textBoxMeminfo";
            this.textBoxMeminfo.ReadOnly = true;
            this.textBoxMeminfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMeminfo.Size = new System.Drawing.Size(1014, 608);
            this.textBoxMeminfo.TabIndex = 1;
            // 
            // tabPageProcstats
            // 
            this.tabPageProcstats.Controls.Add(this.textBoxProcstats);
            this.tabPageProcstats.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcstats.Name = "tabPageProcstats";
            this.tabPageProcstats.Size = new System.Drawing.Size(1020, 617);
            this.tabPageProcstats.TabIndex = 3;
            this.tabPageProcstats.Text = "Procstats";
            this.tabPageProcstats.UseVisualStyleBackColor = true;
            // 
            // textBoxProcstats
            // 
            this.textBoxProcstats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcstats.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxProcstats.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxProcstats.Location = new System.Drawing.Point(3, 3);
            this.textBoxProcstats.Multiline = true;
            this.textBoxProcstats.Name = "textBoxProcstats";
            this.textBoxProcstats.ReadOnly = true;
            this.textBoxProcstats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProcstats.Size = new System.Drawing.Size(1014, 608);
            this.textBoxProcstats.TabIndex = 1;
            // 
            // tabPageUsagestats
            // 
            this.tabPageUsagestats.Controls.Add(this.textBoxUsagestats);
            this.tabPageUsagestats.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsagestats.Name = "tabPageUsagestats";
            this.tabPageUsagestats.Size = new System.Drawing.Size(1020, 617);
            this.tabPageUsagestats.TabIndex = 4;
            this.tabPageUsagestats.Text = "Usagestats";
            this.tabPageUsagestats.UseVisualStyleBackColor = true;
            // 
            // textBoxUsagestats
            // 
            this.textBoxUsagestats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsagestats.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsagestats.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUsagestats.Location = new System.Drawing.Point(3, 4);
            this.textBoxUsagestats.Multiline = true;
            this.textBoxUsagestats.Name = "textBoxUsagestats";
            this.textBoxUsagestats.ReadOnly = true;
            this.textBoxUsagestats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUsagestats.Size = new System.Drawing.Size(1014, 608);
            this.textBoxUsagestats.TabIndex = 1;
            // 
            // tabPageBatterystats
            // 
            this.tabPageBatterystats.Controls.Add(this.textBoxBatterystats);
            this.tabPageBatterystats.Location = new System.Drawing.Point(4, 22);
            this.tabPageBatterystats.Name = "tabPageBatterystats";
            this.tabPageBatterystats.Size = new System.Drawing.Size(1020, 617);
            this.tabPageBatterystats.TabIndex = 5;
            this.tabPageBatterystats.Text = "Batterystats";
            this.tabPageBatterystats.UseVisualStyleBackColor = true;
            // 
            // textBoxBatterystats
            // 
            this.textBoxBatterystats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBatterystats.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBatterystats.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBatterystats.Location = new System.Drawing.Point(3, 4);
            this.textBoxBatterystats.Multiline = true;
            this.textBoxBatterystats.Name = "textBoxBatterystats";
            this.textBoxBatterystats.ReadOnly = true;
            this.textBoxBatterystats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBatterystats.Size = new System.Drawing.Size(1014, 608);
            this.textBoxBatterystats.TabIndex = 1;
            // 
            // FormPackageDump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 712);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGetPackageDump);
            this.Controls.Add(this.textBoxPackageName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPackageDump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "应用系统状态";
            this.Load += new System.EventHandler(this.FormPackageDump_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePackage.ResumeLayout(false);
            this.tabPagePackage.PerformLayout();
            this.tabPageActivity.ResumeLayout(false);
            this.tabPageActivity.PerformLayout();
            this.tabPageMeminfo.ResumeLayout(false);
            this.tabPageMeminfo.PerformLayout();
            this.tabPageProcstats.ResumeLayout(false);
            this.tabPageProcstats.PerformLayout();
            this.tabPageUsagestats.ResumeLayout(false);
            this.tabPageUsagestats.PerformLayout();
            this.tabPageBatterystats.ResumeLayout(false);
            this.tabPageBatterystats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGetPackageDump;
        private System.Windows.Forms.TextBox textBoxPackageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePackage;
        private System.Windows.Forms.TabPage tabPageActivity;
        private System.Windows.Forms.TabPage tabPageMeminfo;
        private System.Windows.Forms.TabPage tabPageProcstats;
        private System.Windows.Forms.TabPage tabPageUsagestats;
        private System.Windows.Forms.TabPage tabPageBatterystats;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.TextBox textBoxMeminfo;
        private System.Windows.Forms.TextBox textBoxProcstats;
        private System.Windows.Forms.TextBox textBoxUsagestats;
        private System.Windows.Forms.TextBox textBoxBatterystats;
    }
}