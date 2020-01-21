using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class Form1 : Form
    {
        TcpListener server;
        Socket socketsforclient;
        static ASCIIEncoding encode = new ASCIIEncoding();
        Thread child;
        public Form1()
        {
            InitializeComponent();
            server = new TcpListener(8888);
            server.Start();
            socketsforclient = server.AcceptSocket();
            child = new Thread(ChildThread);
            child.Start();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            message_box.Text = "Enter message here...";
        }

        private void message_box_Enter(object sender, EventArgs e)
        {
            if (message_box.Text.Equals("Enter message here..."))
            {
                message_box.Text = "";
            }
        }

        private void message_box_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(message_box.Text) || String.IsNullOrWhiteSpace(message_box.Text))
            {
                message_box.Text = "Enter message here...";
            }
        }
        private void send_button_Click(object sender, EventArgs e)
        {
            if(socketsforclient.Connected)
            {
                if (String.IsNullOrWhiteSpace(message_box.Text) || String.IsNullOrEmpty(message_box.Text))
                {
                    // do nothing
                }
                else
                {
                    string temp = message_box.Text;
                    temp = temp.Replace("\r\n", " ");
                    socketsforclient.Send(encode.GetBytes(temp));
                    string s = "\r\nServer >> " + temp;
                    chat_window.Text += s;
                    message_box.Text = "";
                }
            }            
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            child.Abort();
            socketsforclient.Close();
        }

        private void ChildThread()
        {
            while (socketsforclient.Connected)
            {
                try
                {
                    byte[] message = new byte[100];
                    int bytesReceived = socketsforclient.Receive(message);
                    if (bytesReceived != 0)
                    {
                        string s = encode.GetString(message).Substring(0, bytesReceived);
                        s = "\r\nClient >> " + s;
                        //chat_window.Text += s;
                        SetText(chat_window.Text + s);
                    }                    
                }
                catch(Exception e)
                {
                    SetText("Client disconnected..");
                    break;
                }
            }
        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.chat_window.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.chat_window.Text = text;
            }
        }        
    }
}
