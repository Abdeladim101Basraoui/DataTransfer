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
        string full_ipAdresse ="{ cbx_Host.SelectedItem.ToString() }:{cbx_Port.SelectedItem.ToString()}";
    private void Form1_Load(object sender, EventArgs e)
        {
            Remplir_Combo();
            this.Text = $"Computer : {System.Net.Dns.GetHostName()}";
            statusStrip1.Items[0].Text = $"Computer : {System.Net.Dns.GetHostName()}";
            server = new SimpleTcpServer(full_ipAdresse);
           Starting_Connection();
        }
        //
   
        private void Starting_Connection()
        {
            server.Start();
            statusStrip1.Items[0].Text = "Starting ....";
            server.Events.ClientConnected += delegate (object send, ClientConnectedEventArgs ee) { 
            
            };
            server.Events.ClientDisconnected += delegate (object send, ClientDisconnectedEventArgs ee) {
                statusStrip1.Items[0].Text = $"{full_ipAdresse} Disconnected";
                
            };
            server.Events.DataReceived += delegate (object sernd, DataReceivedEventArgs ee) {
                statusStrip1.Items[0].Text = $"{full_ipAdresse} : {Encoding.UTF8.GetString(ee.Data)}";
            };
        }
        private void Remplir_Combo()
        {
            cbx_Host.Items.Add("127.0.0.1");
            cbx_Port.Items.Add("9000");
            cbx_Host.SelectedIndex = 0;
            cbx_Port.SelectedIndex = 0;
        }
    }
}
