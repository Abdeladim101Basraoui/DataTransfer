using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SimpleTcp;
using MetroFramework.Forms;
using System.Windows.Forms;
using MetroFramework;

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
            full_ipAdresse = $"{ cbx_Host.SelectedItem.ToString() }:{cbx_Port.SelectedItem.ToString()}";

            //
            Client cs = new Client();
            cs.Show();
            this.Location = new Point(0, 0);
            cs.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, 0);
            //

            this.Text = $"Computer : {System.Net.Dns.GetHostName()}";
            statusStrip1.Items[0].Text = this.Text;
            server = new SimpleTcpServer(full_ipAdresse);
            Starting_Connection();
        }
        //

        private void Starting_Connection()
        {
            //this.Invoke((MethodInvoker));
            server.Events.ClientConnected += delegate (object send, ClientConnectedEventArgs ee)
            {
                statusStrip1.Items[0].Text = $"{full_ipAdresse} Disconnected ....";
                txt_Msgs.Text = $"{full_ipAdresse} Disconnected.....";
                cbx_Host.Items.Add(ee.IpPort);
            };
            server.Events.ClientDisconnected += delegate (object send, ClientDisconnectedEventArgs ee)
            {
                statusStrip1.Items[0].Text = $"{full_ipAdresse} Disconnected";
                txt_Msgs.Text = $"{full_ipAdresse} Disconnected";
                cbx_Host.Items.Remove(ee.IpPort);

            };
            server.Events.DataReceived += delegate (object sernd, DataReceivedEventArgs ee)
            { 
                statusStrip1.Items[0].Text = $"{full_ipAdresse} : is Tiping .....";
              txt_Msgs.Text = $"{full_ipAdresse} : {Encoding.UTF8.GetString(ee.Data)} {Environment.NewLine}";
            };
        }
        private void Remplir_Combo()
        {
            cbx_Host.Items.Add("127.0.0.1");
            cbx_Port.Items.Add("9000");
            cbx_Host.SelectedIndex = 0;
            cbx_Port.SelectedIndex = 0;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            server.Start();
            statusStrip1.Items[1].Text = "Starting ....";
            statusStrip1.Items[1].ForeColor = Color.Green;
            btn_Send.Enabled = true;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_Message.Text) && cbx_Host.SelectedItem!=null )
            {
                server.Send(cbx_Host.SelectedItem.ToString(), txt_Message.Text);
                txt_Msgs.Text += $"Server : {txt_Message.Text}{Environment.NewLine}";
                txt_Message.Text = "";
            }
        }
    }
}
