using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SimpleTcp;
using System.Net;
using MetroFramework.Forms;
using System.Windows.Forms;
using MetroFramework;
using System.Threading;

namespace DataTransfer
{
    public partial class Server : MetroForm
    {
        public Server()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        string full_ipAdresse;
        private void Form1_Load(object sender, EventArgs e)
        {
            Remplir_Combo();

            //--- open together
            Client cs = new Client();
            cs.Show();
            this.Location = new Point(0, 0);
            cs.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, 0);
            //

            this.Text = $"Server Name : {System.Net.Dns.GetHostName()}";
            statusStrip1.Items[0].Text = this.Text;
            statusStrip1.Items[1].Text = $"IP :{Client.GetIPAddress()[3].ToString()}";
            Starting_Connection();
        }
        //

        private void Starting_Connection()
        {
            server = new SimpleTcpServer(full_ipAdresse);
            server.Start();
            server.Events.ClientConnected += delegate (object send, ClientConnectedEventArgs ee) 
            {
                this.Invoke((MethodInvoker)delegate
                {
                    statusStrip1.Items[0].Text = $"{ee.IpPort} connected ....\r\n";
                    txt_Msgs.ForeColor = Color.Green;
                    txt_Msgs.Text = $"{ee.IpPort} connected.....";
                    txt_Msgs.ForeColor = Color.Black;
                    //cbx_Host.Items.Add(ee.IpPort);
                    Connected_IPs.Items.Add(ee.IpPort);
                });
            };
            server.Events.ClientDisconnected += delegate (object send, ClientDisconnectedEventArgs ee)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    statusStrip1.Items[0].Text = $"{full_ipAdresse} Disconnected";
                    txt_Msgs.Text = $"{full_ipAdresse} Disconnected.\r\n---------------------------------------\n";
                    Connected_IPs.Items.Remove(ee.IpPort);
                });

            };
            server.Events.DataReceived += delegate (object sernd, DataReceivedEventArgs ee)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    statusStrip1.Items[0].Text = $"{full_ipAdresse} : is Tiping .....";
                    Thread.Sleep(3000);
                    txt_Msgs.Text = $"{ee.IpPort} : {Encoding.UTF8.GetString(ee.Data)} {Environment.NewLine}";
                });
            };
        }
        private void Remplir_Combo()
        {
            cbx_Host.Items.Add("127.0.0.1");
            cbx_Host.Items.Add(Client.GetIPAddress()[3].ToString());
            cbx_Port.Items.Add("9000");
            cbx_Host.SelectedIndex = 0;
            cbx_Port.SelectedIndex = 0;
            full_ipAdresse = $"{cbx_Host.SelectedItem.ToString() }:{cbx_Port.SelectedItem.ToString()}";

        }


        private void btn_Send_Click(object sender, EventArgs e)
        {
            statusStrip1.Items[1].Text = "Starting ....";
            statusStrip1.Items[1].ForeColor = Color.Green;
            btn_Send.Enabled = true;
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txt_Message.Text) && Connected_IPs.SelectedItem != null)
                {
                    server.Send(Connected_IPs.SelectedItem.ToString(), txt_Message.Text) ;
                    txt_Msgs.Text += $"Server : {txt_Message.Text}\r\n";
                    txt_Message.Text = "";
                }
            }
        }

        private void Connected_IPs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Send.Enabled = true;
        }
    }
}
