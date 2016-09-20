namespace ArkController.Pages
{
    partial class FormApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApps));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRece = new System.Windows.Forms.TabPage();
            this.tabPageCurrentApp = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewApp = new System.Windows.Forms.ListView();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageRece.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageRece);
            this.tabControl1.Controls.Add(this.tabPageCurrentApp);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 724);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRece
            // 
            this.tabPageRece.Controls.Add(this.listViewApp);
            this.tabPageRece.ImageKey = "menu.png";
            this.tabPageRece.Location = new System.Drawing.Point(4, 39);
            this.tabPageRece.Name = "tabPageRece";
            this.tabPageRece.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRece.Size = new System.Drawing.Size(1024, 681);
            this.tabPageRece.TabIndex = 0;
            this.tabPageRece.Text = "最近应用";
            this.tabPageRece.UseVisualStyleBackColor = true;
            // 
            // tabPageCurrentApp
            // 
            this.tabPageCurrentApp.ImageKey = "menu.png";
            this.tabPageCurrentApp.Location = new System.Drawing.Point(4, 39);
            this.tabPageCurrentApp.Name = "tabPageCurrentApp";
            this.tabPageCurrentApp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentApp.Size = new System.Drawing.Size(1024, 681);
            this.tabPageCurrentApp.TabIndex = 1;
            this.tabPageCurrentApp.Text = "当前应用";
            this.tabPageCurrentApp.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "menu.png");
            // 
            // listViewApp
            // 
            this.listViewApp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewApp.Location = new System.Drawing.Point(3, 3);
            this.listViewApp.Name = "listViewApp";
            this.listViewApp.Size = new System.Drawing.Size(1018, 675);
            this.listViewApp.TabIndex = 0;
            this.listViewApp.UseCompatibleStateImageBehavior = false;
            this.listViewApp.View = System.Windows.Forms.View.Details;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(ArkController.Data.Package);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1016;
            // 
            // FormApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 771);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "应用管理";
            this.Load += new System.EventHandler(this.FormApps_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRece.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRece;
        private System.Windows.Forms.TabPage tabPageCurrentApp;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.ListView listViewApp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}