using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace dns.dns_part
{
    class dns_client
    {
        public Socket acessar_internet(Uri enderenco)
        {
            try
            {

                
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                var ip = Dns.GetHostByName(enderenco.Host);
                IPAddress iPAddress = ip.AddressList[0];
                IPEndPoint iPEnd = new IPEndPoint(iPAddress, 443);
                s.Connect(iPEnd);
                return s;
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("ArgumentNullException : {0}", ae.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
            return null;
        }
       
    }
}
