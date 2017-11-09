using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void ShowMsg(string str)
        {
            rhtServerLog.AppendText(str + "\r\n");
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Any;
            IPEndPoint point=new IPEndPoint(ip,int.Parse(tbServerPort.Text.Trim()));

            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch.Bind(point);

            ShowMsg("启动服务器监听成功！");
            socketWatch.Listen(10);

            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketWatch);

        }


        //将远程连接的客户端的IP地址和Socket存入集合中
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        Socket socketSend;
        void Listen(object obj)
        {
            Socket socketWatch = obj as Socket;
            //等待客户端的连接 并且创建一个负责通信的Socket
            while (true)
            {
                try
                {
                    //负责跟客户端通信的Socket
                    socketSend = socketWatch.Accept();
                    //将远程连接的客户端的IP地址和Socket存入集合中
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //将远程连接的客户端的IP地址和端口号存储下拉框中
                    cbClient.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //192.168.11.78：连接成功
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    //开启 一个新线程不停的接受客户端发送过来的消息
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch
                { }
            }
        }


        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务器应该接受客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                { }
            }
        }


        /// <summary>
        /// 服务端发送数据给客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerSend_Click(object sender, EventArgs e)
        {
            try
            {
                string clientIP = cbClient.Text;

                byte[] buffer = new byte[1024 * 1024 * 5];
                buffer = Encoding.UTF8.GetBytes(rhtServerInput.Text.TrimEnd());
                dicSocket[clientIP].Send(buffer);
            }
            catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
