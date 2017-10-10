namespace CurrentLoggerClient
{
    partial class Setup
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
            this.TB_ListenPort = new System.Windows.Forms.TextBox();
            this.LB_ListenPort = new System.Windows.Forms.Label();
            this.LB_RemotePort = new System.Windows.Forms.Label();
            this.TB_RemotePort = new System.Windows.Forms.TextBox();
            this.LB_RemoteIP = new System.Windows.Forms.Label();
            this.TB_RemoteIP = new System.Windows.Forms.TextBox();
            this.LB_StorageFolder = new System.Windows.Forms.Label();
            this.TB_StorageFolder = new System.Windows.Forms.TextBox();
            this.BT_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_ListenPort
            // 
            this.TB_ListenPort.Location = new System.Drawing.Point(146, 33);
            this.TB_ListenPort.Name = "TB_ListenPort";
            this.TB_ListenPort.Size = new System.Drawing.Size(100, 22);
            this.TB_ListenPort.TabIndex = 0;
            // 
            // LB_ListenPort
            // 
            this.LB_ListenPort.AutoSize = true;
            this.LB_ListenPort.Location = new System.Drawing.Point(32, 36);
            this.LB_ListenPort.Name = "LB_ListenPort";
            this.LB_ListenPort.Size = new System.Drawing.Size(99, 17);
            this.LB_ListenPort.TabIndex = 1;
            this.LB_ListenPort.Text = "Listen on port:";
            // 
            // LB_RemotePort
            // 
            this.LB_RemotePort.AutoSize = true;
            this.LB_RemotePort.Location = new System.Drawing.Point(32, 71);
            this.LB_RemotePort.Name = "LB_RemotePort";
            this.LB_RemotePort.Size = new System.Drawing.Size(90, 17);
            this.LB_RemotePort.TabIndex = 3;
            this.LB_RemotePort.Text = "Remote port:";
            // 
            // TB_RemotePort
            // 
            this.TB_RemotePort.Location = new System.Drawing.Point(146, 68);
            this.TB_RemotePort.Name = "TB_RemotePort";
            this.TB_RemotePort.Size = new System.Drawing.Size(100, 22);
            this.TB_RemotePort.TabIndex = 2;
            // 
            // LB_RemoteIP
            // 
            this.LB_RemoteIP.AutoSize = true;
            this.LB_RemoteIP.Location = new System.Drawing.Point(32, 107);
            this.LB_RemoteIP.Name = "LB_RemoteIP";
            this.LB_RemoteIP.Size = new System.Drawing.Size(73, 17);
            this.LB_RemoteIP.TabIndex = 5;
            this.LB_RemoteIP.Text = "Remote IP";
            // 
            // TB_RemoteIP
            // 
            this.TB_RemoteIP.Location = new System.Drawing.Point(146, 104);
            this.TB_RemoteIP.Name = "TB_RemoteIP";
            this.TB_RemoteIP.Size = new System.Drawing.Size(188, 22);
            this.TB_RemoteIP.TabIndex = 4;
            // 
            // LB_StorageFolder
            // 
            this.LB_StorageFolder.AutoSize = true;
            this.LB_StorageFolder.Location = new System.Drawing.Point(32, 144);
            this.LB_StorageFolder.Name = "LB_StorageFolder";
            this.LB_StorageFolder.Size = new System.Drawing.Size(102, 17);
            this.LB_StorageFolder.TabIndex = 7;
            this.LB_StorageFolder.Text = "Storage Folder";
            // 
            // TB_StorageFolder
            // 
            this.TB_StorageFolder.Location = new System.Drawing.Point(146, 141);
            this.TB_StorageFolder.Name = "TB_StorageFolder";
            this.TB_StorageFolder.Size = new System.Drawing.Size(188, 22);
            this.TB_StorageFolder.TabIndex = 6;
            // 
            // BT_OK
            // 
            this.BT_OK.Location = new System.Drawing.Point(146, 183);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(75, 23);
            this.BT_OK.TabIndex = 8;
            this.BT_OK.Text = "OK";
            this.BT_OK.UseVisualStyleBackColor = true;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 262);
            this.ControlBox = false;
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.LB_StorageFolder);
            this.Controls.Add(this.TB_StorageFolder);
            this.Controls.Add(this.LB_RemoteIP);
            this.Controls.Add(this.TB_RemoteIP);
            this.Controls.Add(this.LB_RemotePort);
            this.Controls.Add(this.TB_RemotePort);
            this.Controls.Add(this.LB_ListenPort);
            this.Controls.Add(this.TB_ListenPort);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_ListenPort;
        private System.Windows.Forms.Label LB_ListenPort;
        private System.Windows.Forms.Label LB_RemotePort;
        private System.Windows.Forms.TextBox TB_RemotePort;
        private System.Windows.Forms.Label LB_RemoteIP;
        private System.Windows.Forms.TextBox TB_RemoteIP;
        private System.Windows.Forms.Label LB_StorageFolder;
        private System.Windows.Forms.TextBox TB_StorageFolder;
        private System.Windows.Forms.Button BT_OK;
    }
}