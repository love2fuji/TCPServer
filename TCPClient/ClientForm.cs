using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class TCPclient : Form
    {
        public TCPclient()
        {
            InitializeComponent();
        }

        private void TCPclient_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void ShowMsg(string str)
        {
            rhtServerLog.AppendText(str + "\r\n");
        }




        Socket clientSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

        private void btnConect_Click(object sender, EventArgs e)
        {
            IPAddress serverIP = IPAddress.Parse(tbServerIP.Text.TrimEnd());
            //IPAddress ip = IPAddress.Any;
            IPEndPoint point = new IPEndPoint(serverIP,int.Parse(tbServerPort.Text));

            try
            {
                clientSocket.Connect(point);
                ShowMsg("连接成功...");
                ShowMsg("服务器："+clientSocket.RemoteEndPoint.ToString());


            }
            catch (Exception ex)
            {
            }

        }

       
    }
}
