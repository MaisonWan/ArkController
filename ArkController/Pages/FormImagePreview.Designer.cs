namespace ArkController.Pages
{
    partial class FormImagePreview
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
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.contextMenuStripImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.ContextMenuStrip = this.contextMenuStripImage;
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(710, 507);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemCopy,
            this.mToolStripMenuItemSaveAs});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(153, 70);
            // 
            // mToolStripMenuItemCopy
            // 
            this.mToolStripMenuItemCopy.Name = "mToolStripMenuItemCopy";
            this.mToolStripMenuItemCopy.Size = new System.Drawing.Size(152, 22);
            this.mToolStripMenuItemCopy.Text = "复制(&C)";
            this.mToolStripMenuItemCopy.Click += new System.EventHandler(this.mToolStripMenuItemCopy_Click);
            // 
            // mToolStripMenuItemSaveAs
            // 
            this.mToolStripMenuItemSaveAs.Name = "mToolStripMenuItemSaveAs";
            this.mToolStripMenuItemSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mToolStripMenuItemSaveAs.Text = "另存为(&S)";
            this.mToolStripMenuItemSaveAs.Click += new System.EventHandler(this.mToolStripMenuItemSaveAs_Click);
            // 
            // FormImagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 507);
            this.Controls.Add(this.pictureBoxPreview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImagePreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImagePreview";
            this.Load += new System.EventHandler(this.FormImagePreview_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImagePreview_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.contextMenuStripImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemSaveAs;
    }
}