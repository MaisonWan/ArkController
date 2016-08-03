namespace KibotController
{
    partial class FormLogcat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogcat));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "过滤条件";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 21);
            this.textBox1.TabIndex = 1;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "All",
            "Verbose",
            "Debug",
            "Info",
            "Warning",
            "Error",
            "Fatal",
            "Silent"});
            this.comboBoxPriority.Location = new System.Drawing.Point(300, 10);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(97, 20);
            this.comboBoxPriority.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "优先级";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(418, 7);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxContent.Location = new System.Drawing.Point(15, 41);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(1002, 658);
            this.textBoxContent.TabIndex = 5;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(499, 7);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // FormLogcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 711);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logcat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogcat_FormClosing);
            this.Load += new System.EventHandler(this.FormLogcat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonStop;
    }
}