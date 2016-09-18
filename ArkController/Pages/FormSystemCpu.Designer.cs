namespace ArkController.Pages
{
    partial class FormSystemCpu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSystemCpu));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.checkBoxThreadInfo = new System.Windows.Forms.CheckBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listViewProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelUserPercent = new System.Windows.Forms.Label();
            this.labelUserSum = new System.Windows.Forms.Label();
            this.timerTask = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "显示数量";
            // 
            // comboBoxNum
            // 
            this.comboBoxNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNum.FormattingEnabled = true;
            this.comboBoxNum.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxNum.Location = new System.Drawing.Point(72, 10);
            this.comboBoxNum.Name = "comboBoxNum";
            this.comboBoxNum.Size = new System.Drawing.Size(58, 20);
            this.comboBoxNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "刷新时间";
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10"});
            this.comboBoxInterval.Location = new System.Drawing.Point(213, 10);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(58, 20);
            this.comboBoxInterval.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "排序";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "CPU",
            "VSS",
            "RSS",
            "THREAD"});
            this.comboBoxSort.Location = new System.Drawing.Point(340, 10);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(58, 20);
            this.comboBoxSort.TabIndex = 1;
            // 
            // checkBoxThreadInfo
            // 
            this.checkBoxThreadInfo.AutoSize = true;
            this.checkBoxThreadInfo.Location = new System.Drawing.Point(434, 13);
            this.checkBoxThreadInfo.Name = "checkBoxThreadInfo";
            this.checkBoxThreadInfo.Size = new System.Drawing.Size(96, 16);
            this.checkBoxThreadInfo.TabIndex = 2;
            this.checkBoxThreadInfo.Text = "显示线程信息";
            this.checkBoxThreadInfo.UseVisualStyleBackColor = true;
            this.checkBoxThreadInfo.CheckedChanged += new System.EventHandler(this.checkBoxThreadInfo_CheckedChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(616, 8);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(535, 8);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listViewProcess
            // 
            this.listViewProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewProcess.FullRowSelect = true;
            this.listViewProcess.GridLines = true;
            this.listViewProcess.Location = new System.Drawing.Point(13, 80);
            this.listViewProcess.Name = "listViewProcess";
            this.listViewProcess.Size = new System.Drawing.Size(957, 526);
            this.listViewProcess.TabIndex = 9;
            this.listViewProcess.UseCompatibleStateImageBehavior = false;
            this.listViewProcess.View = System.Windows.Forms.View.Details;
            this.listViewProcess.Resize += new System.EventHandler(this.listViewProcess_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 125;
            // 
            // labelUserPercent
            // 
            this.labelUserPercent.AutoSize = true;
            this.labelUserPercent.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserPercent.Location = new System.Drawing.Point(13, 62);
            this.labelUserPercent.Name = "labelUserPercent";
            this.labelUserPercent.Size = new System.Drawing.Size(0, 14);
            this.labelUserPercent.TabIndex = 10;
            // 
            // labelUserSum
            // 
            this.labelUserSum.AutoSize = true;
            this.labelUserSum.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserSum.Location = new System.Drawing.Point(466, 62);
            this.labelUserSum.Name = "labelUserSum";
            this.labelUserSum.Size = new System.Drawing.Size(0, 14);
            this.labelUserSum.TabIndex = 11;
            // 
            // timerTask
            // 
            this.timerTask.Interval = 1000;
            this.timerTask.Tick += new System.EventHandler(this.timerTask_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(13, 612);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 164);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图表";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ArkController.Properties.Resources.timer;
            this.pictureBox1.Location = new System.Drawing.Point(861, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTimer.Location = new System.Drawing.Point(899, 13);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(71, 15);
            this.labelTimer.TabIndex = 15;
            this.labelTimer.Text = "00:00:00";
            // 
            // FormSystemCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 788);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUserSum);
            this.Controls.Add(this.labelUserPercent);
            this.Controls.Add(this.listViewProcess);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxThreadInfo);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.comboBoxInterval);
            this.Controls.Add(this.comboBoxNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSystemCpu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统进程CPU内存占用";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSystemCpu_FormClosing);
            this.Load += new System.EventHandler(this.FormSystemCpu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.CheckBox checkBoxThreadInfo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListView listViewProcess;
        private System.Windows.Forms.Label labelUserPercent;
        private System.Windows.Forms.Label labelUserSum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTimer;
    }
}