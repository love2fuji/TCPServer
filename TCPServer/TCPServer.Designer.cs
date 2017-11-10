namespace TCPServer
{
    partial class TCPServer
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
            this.btnSerSend = new System.Windows.Forms.Button();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rhtServerLog
            // 
            this.rhtServerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rhtServerLog.Location = new System.Drawing.Point(3, 17);
            this.rhtServerLog.Name = "rhtServerLog";
            this.rhtServerLog.Size = new System.Drawing.Size(777, 159);
            this.rhtServerLog.TabIndex = 0;
            this.rhtServerLog.Text = "";
            // 
            // rhtServerInput
            // 
            this.rhtServerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rhtServerInput.Location = new System.Drawing.Point(3, 17);
            this.rhtServerInput.Name = "rhtServerInput";
            this.rhtServerInput.Size = new System.Drawing.Size(774, 160);
            this.rhtServerInput.TabIndex = 0;
            this.rhtServerInput.Text = "";
            // 
            // btnSerSend
            // 
            this.btnSerSend.Location = new System.Drawing.Point(810, 454);
            this.btnSerSend.Name = "btnSerSend";
            this.btnSerSend.Size = new System.Drawing.Size(75, 23);
            this.btnSerSend.TabIndex = 1;
            this.btnSerSend.Text = "发送";
            this.btnSerSend.UseVisualStyleBackColor = true;
            this.btnSerSend.Click += new System.EventHandler(this.btnSerSend_Click);
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(503, 21);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(174, 20);
            this.cbClient.TabIndex = 0;
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(287, 20);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(75, 23);
            this.btnServerStart.TabIndex = 1;
            this.btnServerStart.Text = "开始监听";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(50, 20);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(140, 21);
            this.tbServerIP.TabIndex = 2;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(196, 20);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(64, 21);
            this.tbServerPort.TabIndex = 2;
            this.tbServerPort.Text = "5566";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbServerPort);
            this.groupBox1.Controls.Add(this.btnServerStart);
            this.groupBox1.Controls.Add(this.cbClient);
            this.groupBox1.Controls.Add(this.tbServerIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rhtServerLog);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 179);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态显示";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rhtServerInput);
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 180);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "客户端IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSerSend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TCPSerever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rhtServerLog;
        private System.Windows.Forms.RichTextBox rhtServerInput;
        private System.Windows.Forms.Button btnSerSend;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}

