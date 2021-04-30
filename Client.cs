using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using MetroFramework.Forms;
using SimpleTcp;

namespace DataTransfer
{
    public partial class Client :MetroForm
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            cbx_Host.SelectedIndex = 0;
            cbx_Port.SelectedIndex = 0;
            //Starting_Connection();
            GetIPAddress();
        }

        private string GetIPAddress()
        {

            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] address = ipHostEntry.AddressList;
            return $"The Local IP Address: {address[3].ToString()}";
        }


    }
}
