﻿namespace TCPClient
{
    partial class TCPclient
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
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.btnConect = new System.Windows.Forms.Button();
            this.rhtServerInput = new System.Windows.Forms.RichTextBox();
            this.rhtServerLog = new System.Windows.Forms.RichTextBox();
            this.btnClientSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(174, 36);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(64, 21);
            this.tbServerPort.TabIndex = 3;
            this.tbServerPort.Text = "5566";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(28, 36);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(140, 21);
            this.tbServerIP.TabIndex = 4;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(308, 33);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(75, 23);
            this.btnConect.TabIndex = 5;
            this.btnConect.Text = "连接";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // rhtServerInput
            // 
            this.rhtServerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rhtServerInput.Location = new System.Drawing.Point(3, 17);
            this.rhtServerInput.Name = "rhtServerInput";
            this.rhtServerInput.Size = new System.Drawing.Size(765, 169);
            this.rhtServerInput.TabIndex = 6;
            this.rhtServerInput.Text = "";
            // 
            // rhtServerLog
            // 
            this.rhtServerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rhtServerLog.Location = new System.Drawing.Point(3, 17);
            this.rhtServerLog.Name = "rhtServerLog";
            this.rhtServerLog.Size = new System.Drawing.Size(765, 199);
            this.rhtServerLog.TabIndex = 7;
            this.rhtServerLog.Text = "";
            // 
            // btnClientSend
            // 
            this.btnClientSend.Location = new System.Drawing.Point(656, 497);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(75, 23);
            this.btnClientSend.TabIndex = 5;
            this.btnClientSend.Text = "发送";
            this.btnClientSend.UseVisualStyleBackColor = true;
            this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rhtServerLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 219);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行状态";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rhtServerInput);
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 189);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送区";
            // 
            // TCPclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClientSend);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.tbServerPort);
            this.Controls.Add(this.tbServerIP);
            this.Name = "TCPclient";
            this.Text = "TCPclient";
            this.Load += new System.EventHandler(this.TCPclient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.RichTextBox rhtServerInput;
        private System.Windows.Forms.RichTextBox rhtServerLog;
        private System.Windows.Forms.Button btnClientSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

