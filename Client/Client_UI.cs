using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public partial class Client_UI : Form
    {

        //private string Ipconn = "127.0.0.1";
        public string ipa;
        public string username;
        public Client_UI(string userip, string name)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            ipa = userip;
            username = name;
            lbip.Text = userip;

            connect();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text !="")
            {
                send();
                Addmessage(username + "(" + ipa + ")" + ": " + txtMessage.Text);
            }
        }

        IPEndPoint IP;
        Socket client;

        void connect()
        {
            IP = new IPEndPoint(IPAddress.Parse(ipa), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Khong the ket noi server!", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            client.Close();

        }

        void send()
        {
            if (txtMessage.Text != String.Empty)
                client.Send(Serialize(username +"("+ipa+")" + ": " + txtMessage.Text));
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    Addmessage(message);
                }
            }
            catch
            {
                close();
            }
        }

        void Addmessage(string s)
        {
            ChatBox.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
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

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
    }
}
