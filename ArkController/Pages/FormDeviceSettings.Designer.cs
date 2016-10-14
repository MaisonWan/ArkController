namespace ArkController.Pages
{
    partial class FormDeviceSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeviceSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.buttonStartAction = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择Action";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAction.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "android.settings.AIRPLANE_MODE_SETTINGS",
            "android.settings.APN_SETTINGS",
            "android.settings.APPLICATION_DEVELOPMENT_SETTINGS",
            "android.settings.APPLICATION_SETTINGS",
            "android.settings.BLUETOOTH_SETTINGS",
            "android.settings.DATA_ROAMING_SETTINGS",
            "android.settings.DATE_SETTINGS",
            "android.settings.DISPLAY_SETTINGS",
            "android.settings.INPUT_METHOD_SETTINGS",
            "android.settings.INTERNAL_STORAGE_SETTINGS",
            "android.settings.LOCALE_SETTINGS",
            "android.settings.LOCATION_SOURCE_SETTINGS",
            "android.settings.MANAGE_APPLICATIONS_SETTINGS",
            "android.settings.MEMORY_CARD_SETTINGS",
            "android.settings.NETWORK_OPERATOR_SETTINGS",
            "android.settings.QUICK_LAUNCH_SETTINGS",
            "android.settings.SECURITY_SETTINGS",
            "android.settings.SETTINGS",
            "android.settings.SOUND_SETTINGS",
            "android.settings.SYNC_SETTINGS",
            "android.settings.USER_DICTIONARY_SETTINGS",
            "android.settings.WIFI_IP_SETTINGS",
            "android.settings.WIFI_SETTINGS",
            "android.settings.WIRELESS_SETTINGS"});
            this.comboBoxAction.Location = new System.Drawing.Point(84, 31);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(375, 21);
            this.comboBoxAction.TabIndex = 1;
            // 
            // buttonStartAction
            // 
            this.buttonStartAction.Location = new System.Drawing.Point(97, 95);
            this.buttonStartAction.Name = "buttonStartAction";
            this.buttonStartAction.Size = new System.Drawing.Size(107, 43);
            this.buttonStartAction.TabIndex = 2;
            this.buttonStartAction.Text = "启动界面";
            this.buttonStartAction.UseVisualStyleBackColor = true;
            this.buttonStartAction.Click += new System.EventHandler(this.buttonStartAction_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.Location = new System.Drawing.Point(302, 95);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(107, 43);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "退出";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // FormDeviceSettings
            // 
            this.AcceptButton = this.buttonStartAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonQuit;
            this.ClientSize = new System.Drawing.Size(484, 167);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStartAction);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeviceSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "启动设置界面";
            this.Load += new System.EventHandler(this.FormDeviceSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Button buttonStartAction;
        private System.Windows.Forms.Button buttonQuit;
    }
}