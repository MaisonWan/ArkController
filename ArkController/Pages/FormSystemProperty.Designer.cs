namespace ArkController.Pages
{
    partial class FormSystemProperty
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
            this.buttonReadSystemProp = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.listViewProperties = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonReadSystemProp
            // 
            this.buttonReadSystemProp.Location = new System.Drawing.Point(13, 13);
            this.buttonReadSystemProp.Name = "buttonReadSystemProp";
            this.buttonReadSystemProp.Size = new System.Drawing.Size(102, 23);
            this.buttonReadSystemProp.TabIndex = 0;
            this.buttonReadSystemProp.Text = "读取系统属性";
            this.buttonReadSystemProp.UseVisualStyleBackColor = true;
            this.buttonReadSystemProp.Click += new System.EventHandler(this.buttonReadSystemProp_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(121, 15);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(177, 21);
            this.textBoxFilter.TabIndex = 1;
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Checked = true;
            this.checkBoxFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFilter.Location = new System.Drawing.Point(304, 17);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(48, 16);
            this.checkBoxFilter.TabIndex = 2;
            this.checkBoxFilter.Text = "过滤";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // listViewProperties
            // 
            this.listViewProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewProperties.FullRowSelect = true;
            this.listViewProperties.GridLines = true;
            this.listViewProperties.Location = new System.Drawing.Point(13, 43);
            this.listViewProperties.Name = "listViewProperties";
            this.listViewProperties.Size = new System.Drawing.Size(657, 607);
            this.listViewProperties.TabIndex = 3;
            this.listViewProperties.UseCompatibleStateImageBehavior = false;
            this.listViewProperties.View = System.Windows.Forms.View.Details;
            this.listViewProperties.Resize += new System.EventHandler(this.listViewProperties_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KEY";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "VALUE";
            // 
            // FormSystemProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 662);
            this.Controls.Add(this.listViewProperties);
            this.Controls.Add(this.checkBoxFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonReadSystemProp);
            this.Name = "FormSystemProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSystemProperty";
            this.Load += new System.EventHandler(this.FormSystemProperty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadSystemProp;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private System.Windows.Forms.ListView listViewProperties;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}