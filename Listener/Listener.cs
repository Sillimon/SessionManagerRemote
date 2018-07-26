using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Listener
    {
        private string m_address = "127.0.0.1";
        private string m_hostName = "";
        
        private ArrayList nSockets;

        private string m_data = null;

        #region CONSTRUCTOR
        public Listener()
        {
            m_address = GetIPAddress();
            m_hostName = GetHostName();
            nSockets = new ArrayList();
            
            Listening();
            
            switch (m_data)
            {
                case "0":
                    ManagerLib.Utils.LogService("ret == 0, Do nothing");
                    break;

                case "1":
                    ManagerLib.Utils.LogService("Switch off");
                    break;

                case "2":
                    ManagerLib.Utils.LogService("Sleep");
                    break;

                case "3":
                    ManagerLib.Utils.LogService("Log off");
                    break;

                case "4":
                    ManagerLib.Utils.LogService("Lock");
                    break;

                default:

                    ManagerLib.Utils.LogService("Default case");
                    break;
            }
        }
        #endregion

        public void Listening()
        {
            TcpListener tcpListener = null;

            try
            {
                tcpListener = new TcpListener(IPAddress.Parse(m_address), 8080);
                tcpListener.Start();
                
                Byte[] bytes = new Byte[256];
                
                while (true)
                {
                    ManagerLib.Utils.LogService("Waiting for a connection...");
                    
                    TcpClient client = tcpListener.AcceptTcpClient();

                    ManagerLib.Utils.LogService("Connected");
                    
                    NetworkStream stream = client.GetStream();

                    int i;
                    while((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        m_data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        
                        ManagerLib.Utils.LogService("Received : " + m_data);

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes("Success;" + m_address + ";" + m_hostName);
                        
                        stream.Write(msg, 0, msg.Length);

                        ManagerLib.Utils.LogService("Sent: " + m_data);
                    }

                    client.Close();
                }
            }
            catch(SocketException e)
            {

                ManagerLib.Utils.LogService("SocketException : " + e.Message);
            }
            finally
            {
                tcpListener.Stop();
            }
        }

        public string GetIPAddress()
        {
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            return IPHost.AddressList[0].ToString();
        }
        
        public string GetHostName()
        {
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            return IPHost.HostName;
        }
    }
}
