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
            dns_client.enderenco = texto.Text;
            dns_client dns = new dns_client();
            Socket DNS_RAIZ=  dns.acessar_internet();
            if(DNS_RAIZ.Connected.ToString()!= string.Empty)
            {
                webBrowser1.Navigate(DNS_RAIZ.Connected.ToString());
            }
        }
    }
}
