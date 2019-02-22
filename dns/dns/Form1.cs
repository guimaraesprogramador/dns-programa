using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dns.dns_part;
namespace dns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dns_client dns = new dns_client();
                Uri uri = new Uri(texto.Text);
                Socket DNS_RAIZ = dns.acessar_internet(uri);
                if (DNS_RAIZ.Connected.ToString() != null)
                {

                    webBrowser1.Url = uri;
                    host.Text = uri.Host;
                   port.Text =  uri.Port.ToString();
                    tcp.Text = DNS_RAIZ.ProtocolType.ToString();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("nao encontrou o enderenço");
            }
          
        }
    }
}
