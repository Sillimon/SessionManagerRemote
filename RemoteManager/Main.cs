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

namespace RemoteManager
{
    public partial class Main : Form
    {
        public string url = "";
        public int action = Action.NOTHING;

        public Main()
        {
            InitializeComponent();
        }


        #region EVENTS
        private void btExecute_Click(object sender, EventArgs e)
        {
            try
            {
                string message = action.ToString();

                //Create a TcpClient
                TcpClient client = new TcpClient(url, 8080);

                //Translate the passed message into ASCII and store it as a byte array
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                //Get a client stream for reading and writing
                NetworkStream ns = client.GetStream();

                //Update state
                tbState.Text = "Connected !";

                //Send the message to the connected TcpServer
                ns.Write(data, 0, data.Length);
                
                ManagerLib.Utils.LogService("Sent : " + message);

                //Receive the TcpServer.response//

                //Buffer to store the response bytes
                data = new Byte[256];

                //String to store the response ASCII representation
                string responseData = String.Empty;

                //Read the first batch of the TcpServer response bytes
                Int32 bytes = ns.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                tbState.Text = responseData;

                ManagerLib.Utils.LogService("Received : " + responseData);

                //Close everything
                ns.Close();
                client.Close();
            }
            catch(ArgumentNullException ex)
            {
                ManagerLib.Utils.LogService("ArgumentNullException : " + ex.Message);
            }
            catch(SocketException ex)
            {
                ManagerLib.Utils.LogService("SocketException : " + ex.Message);
            }
        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {
            this.url = tbURL.Text;
        }
        
        private void rbSwitchOff_CheckedChanged(object sender, EventArgs e)
        {
            action = Action.SWITCH_OFF;
        }

        private void rbSleep_CheckedChanged(object sender, EventArgs e)
        {
            action = Action.SLEEP;
        }

        private void rbLogOff_CheckedChanged(object sender, EventArgs e)
        {
            action = Action.LOG_OFF;
        }

        private void rbLock_CheckedChanged(object sender, EventArgs e)
        {
            action = Action.LOCK;
        }
        #endregion
    }
}
