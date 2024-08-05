using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Server
{
    public partial class Server_UI : Form
    {
        public Server_UI()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            connect();
        }

        private void ServerSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientlist)
            {
                send(item);
            }
            Addmessage("Server: " + ServerMessage.Text);
            ServerMessage.Clear();
        }
        IPEndPoint IP;

        Socket server;
        List<Socket> clientlist;

        void connect()
        {

            clientlist = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientlist.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = false;
            Listen.Start();
        }

        void close()
        {
            server.Close();

        }

        void send(Socket client)
        {
            if (client != null && ServerMessage.Text != String.Empty)
                client.Send(Serialize("Server: " + ServerMessage.Text));
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    foreach (Socket item in clientlist)
                    {
                        if (item != null && item != client)

                            item.Send(Serialize(message));

                    }
                    Addmessage(message);
                }
            }
            catch
            {
                clientlist.Remove(client);
                client.Close();
            }
        }

        void Addmessage(string s)
        {
            ServerChat.Items.Add(new ListViewItem() { Text = s });
        }


        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }


        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }

        private void Server_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            close();
        }
    }
}

