namespace ArkController.Pages
{
    partial class FormScreenRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScreenRecord));
            this.tabControlScreenRecord = new System.Windows.Forms.TabControl();
            this.tabPageScreenRecord = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.buttonStartRecord = new System.Windows.Forms.Button();
            this.tabPageRecordList = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.listViewRecordList = new System.Windows.Forms.ListView();
            this.tabControlScreenRecord.SuspendLayout();
            this.tabPageScreenRecord.SuspendLayout();
            this.tabPageRecordList.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlScreenRecord
            // 
            this.tabControlScreenRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlScreenRecord.Controls.Add(this.tabPageScreenRecord);
            this.tabControlScreenRecord.Controls.Add(this.tabPageRecordList);
            this.tabControlScreenRecord.Location = new System.Drawing.Point(3, 3);
            this.tabControlScreenRecord.Name = "tabControlScreenRecord";
            this.tabControlScreenRecord.SelectedIndex = 0;
            this.tabControlScreenRecord.Size = new System.Drawing.Size(194, 507);
            this.tabControlScreenRecord.TabIndex = 1;
            // 
            // tabPageScreenRecord
            // 
            this.tabPageScreenRecord.Controls.Add(this.comboBoxTime);
            this.tabPageScreenRecord.Controls.Add(this.label2);
            this.tabPageScreenRecord.Controls.Add(this.comboBoxSize);
            this.tabPageScreenRecord.Controls.Add(this.label1);
            this.tabPageScreenRecord.Controls.Add(this.buttonStopRecord);
            this.tabPageScreenRecord.Controls.Add(this.buttonStartRecord);
            this.tabPageScreenRecord.Location = new System.Drawing.Point(4, 22);
            this.tabPageScreenRecord.Name = "tabPageScreenRecord";
            this.tabPageScreenRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScreenRecord.Size = new System.Drawing.Size(186, 481);
            this.tabPageScreenRecord.TabIndex = 0;
            this.tabPageScreenRecord.Text = "录屏";
            this.tabPageScreenRecord.ToolTipText = "录制屏幕";
            this.tabPageScreenRecord.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分辨率：";
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.BackgroundImage = global::ArkController.Properties.Resources.stop;
            this.buttonStopRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStopRecord.Enabled = false;
            this.buttonStopRecord.Location = new System.Drawing.Point(107, 18);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(60, 60);
            this.buttonStopRecord.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonStopRecord, "停止录制");
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click);
            // 
            // buttonStartRecord
            // 
            this.buttonStartRecord.BackgroundImage = global::ArkController.Properties.Resources.play;
            this.buttonStartRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartRecord.Location = new System.Drawing.Point(21, 18);
            this.buttonStartRecord.Name = "buttonStartRecord";
            this.buttonStartRecord.Size = new System.Drawing.Size(60, 60);
            this.buttonStartRecord.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonStartRecord, "开始录制");
            this.buttonStartRecord.UseVisualStyleBackColor = true;
            this.buttonStartRecord.Click += new System.EventHandler(this.buttonStartRecord_Click);
            // 
            // tabPageRecordList
            // 
            this.tabPageRecordList.Controls.Add(this.listViewRecordList);
            this.tabPageRecordList.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecordList.Name = "tabPageRecordList";
            this.tabPageRecordList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecordList.Size = new System.Drawing.Size(186, 481);
            this.tabPageRecordList.TabIndex = 1;
            this.tabPageRecordList.Text = "列表";
            this.tabPageRecordList.ToolTipText = "本地已经录制";
            this.tabPageRecordList.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlScreenRecord);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(799, 510);
            this.splitContainer1.SplitterDistance = 595;
            this.splitContainer1.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(592, 504);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "1920x1080",
            "1280x800"});
            this.comboBoxSize.Location = new System.Drawing.Point(78, 97);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(102, 20);
            this.comboBoxSize.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "录制时长：";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "10秒",
            "20秒",
            "30秒",
            "60秒",
            "90秒",
            "120秒",
            "150秒",
            "180秒"});
            this.comboBoxTime.Location = new System.Drawing.Point(77, 131);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(103, 20);
            this.comboBoxTime.TabIndex = 4;
            // 
            // listViewRecordList
            // 
            this.listViewRecordList.Location = new System.Drawing.Point(7, 7);
            this.listViewRecordList.Name = "listViewRecordList";
            this.listViewRecordList.Size = new System.Drawing.Size(173, 466);
            this.listViewRecordList.TabIndex = 0;
            this.listViewRecordList.UseCompatibleStateImageBehavior = false;
            this.listViewRecordList.View = System.Windows.Forms.View.Details;
            // 
            // FormScreenRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 510);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScreenRecord";
            this.Text = "设备屏幕录制";
            this.Load += new System.EventHandler(this.FormScreenRecord_Load);
            this.tabControlScreenRecord.ResumeLayout(false);
            this.tabPageScreenRecord.ResumeLayout(false);
            this.tabPageScreenRecord.PerformLayout();
            this.tabPageRecordList.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlScreenRecord;
        private System.Windows.Forms.TabPage tabPageScreenRecord;
        private System.Windows.Forms.TabPage tabPageRecordList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonStartRecord;
        private System.Windows.Forms.Button buttonStopRecord;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewRecordList;
    }
}