namespace TCPServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rhtServerLog = new System.Windows.Forms.RichTextBox();
            this.rhtServerInput = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.btnSerSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rhtServerLog
            // 
            this.rhtServerLog.Location = new System.Drawing.Point(12, 115);
            this.rhtServerLog.Name = "rhtServerLog";
            this.rhtServerLog.Size = new System.Drawing.Size(771, 161);
            this.rhtServerLog.TabIndex = 0;
            this.rhtServerLog.Text = "";
            // 
            // rhtServerInput
            // 
            this.rhtServerInput.Location = new System.Drawing.Point(12, 300);
            this.rhtServerInput.Name = "rhtServerInput";
            this.rhtServerInput.Size = new System.Drawing.Size(771, 161);
            this.rhtServerInput.TabIndex = 0;
            this.rhtServerInput.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbServerPort);
            this.panel1.Controls.Add(this.tbServerIP);
            this.panel1.Controls.Add(this.btnServerStart);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 100);
            this.panel1.TabIndex = 1;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(166, 53);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(64, 21);
            this.tbServerPort.TabIndex = 2;
            this.tbServerPort.Text = "5566";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(20, 53);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(140, 21);
            this.tbServerIP.TabIndex = 2;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(271, 51);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(75, 23);
            this.btnServerStart.TabIndex = 1;
            this.btnServerStart.Text = "开始监听";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(419, 54);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(174, 20);
            this.cbClient.TabIndex = 0;
            // 
            // btnSerSend
            // 
            this.btnSerSend.Location = new System.Drawing.Point(822, 438);
            this.btnSerSend.Name = "btnSerSend";
            this.btnSerSend.Size = new System.Drawing.Size(75, 23);
            this.btnSerSend.TabIndex = 1;
            this.btnSerSend.Text = "发送";
            this.btnSerSend.UseVisualStyleBackColor = true;
            this.btnSerSend.Click += new System.EventHandler(this.btnSerSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rhtServerInput);
            this.Controls.Add(this.btnSerSend);
            this.Controls.Add(this.rhtServerLog);
            this.Name = "Form1";
            this.Text = "TCPSerever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rhtServerLog;
        private System.Windows.Forms.RichTextBox rhtServerInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Button btnSerSend;
    }
}

