using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Data;

namespace D3_Servercheck
{
    class OpenConnections
    {
        private string serverIP;
        public OpenConnections()
        {
            getActiveTcpConnections();
            
        }

        public void updateConnections()
        {
            getActiveTcpConnections();
        }
        private void getActiveTcpConnections()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tmpConnections = properties.GetActiveTcpConnections();
            foreach (TcpConnectionInformation c in tmpConnections)
            {
                if (c.RemoteEndPoint.Port == 1119 && !c.RemoteEndPoint.Address.ToString().Contains(".193"))
                {
                    serverIP = c.RemoteEndPoint.Address.ToString();
                    return;
                }            }
            serverIP = "No Active D3 RoS Server Connections \n Diablo 3 Not running?";
        }

        public string getServerIP()
        {
            return serverIP;
        }
    }
}
