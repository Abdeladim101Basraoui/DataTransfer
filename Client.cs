using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using MetroFramework.Forms;
using SimpleTcp;
using System.Threading;
using System.Windows.Forms;

namespace DataTransfer
{
    public partial class Client : MetroForm
    {
        public Client()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        string full_AdresseIPv4;
        private void Client_Load(object sender, EventArgs e)
        {
            this.Text = GetIPAddress();
            Remplir_Combo();
            full_AdresseIPv4 = $"{ cbx_Host.SelectedItem.ToString() }:{cbx_Port.SelectedItem.ToString()}";
            Starting_Connection();
        }

        private string GetIPAddress()
        {

            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] address = ipHostEntry.AddressList;
            return $"The Machine IP Address: {address[3].ToString()}";
        }
        private void Remplir_Combo()
        {
            cbx_Host.Items.Add("127.0.0.1");
            cbx_Port.Items.Add("9000");
            cbx_Host.SelectedIndex = 0;
            cbx_Port.SelectedIndex = 0;
        }
        private void Starting_Connection()
        {
            try
            {
                client = new SimpleTcpClient(full_AdresseIPv4);
                client.Events.Connected += delegate (object sender, ClientConnectedEventArgs e)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        statusStrip1.Items[0].Text = $"connected ....";
                        statusStrip1.Items[0].ForeColor = Color.Green;
                        txt_Msgs.Text += $"Server connected ....{Environment.NewLine}";
                    });
                };
                client.Events.DataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        statusStrip1.Items[0].Text = $"Tiping ....";
                        Thread.Sleep(1000);
                        txt_Msgs.Text += $"Server : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                    });
                };
                client.Events.Disconnected += delegate (object sender, ClientDisconnectedEventArgs e)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        statusStrip1.Items[0].Text = $"Diconnected ....";
                        statusStrip1.Items[0].ForeColor = Color.Red;
                        txt_Msgs.Text += $"Server Disconnected ....{Environment.NewLine}";
                    });
                };

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txt_Message.Text))
                {
                    client.Send(txt_Message.Text);
                    txt_Msgs.Text += $"Me :{txt_Message.Text}{Environment.NewLine}";
                    txt_Message.Text = "";
                }
                else
                {
                    txt_Message.WaterMarkColor = Color.Red;
                    txt_Message.WaterMark = "no msg inserted ....";
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("Veillez reconnected au server");
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (btn_con.Text == "Disconnected")
            {
                btn_con.Text = "Re-Connected";
            }
            else
            {
                metroButton1_Click(sender, e);
            }
        }

        private void txt_Message_Click(object sender, EventArgs e)
        {
            txt_Message.WaterMarkColor = Color.Gray;
            txt_Message.WaterMark = "Tiping ....";

            btn_send.Enabled = true;
            client.Connect();
            statusStrip1.Items[0].Text = "Starting ....";
            statusStrip1.Items[0].ForeColor = Color.Green;
        }
    }


}

