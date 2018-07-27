using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteManager
{
    public partial class Main : Form
    {
        private string m_ID = "";

        private int m_action = Action.NOTHING;

        public Main()
        {
            InitializeComponent();

            ManagerLib.DataBaseHelper db = new ManagerLib.DataBaseHelper();

            db.OpenConnection();

            dgvContact.DataSource = db.ShowDataInGridView("SELECT * FROM Contact");
        }


        #region EVENTS
        private void btExecute_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient(m_ID, 8080);

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(m_action.ToString());

                NetworkStream ns = client.GetStream();

                tbState.Text = "Connected !";

                ns.Write(data, 0, data.Length);

                ManagerLib.Utils.LogService("Sent : " + m_action.ToString());

                //----------------------------Receive the TcpServer.response----------------------------//

                data = new Byte[256];

                string responseData = String.Empty;

                Int32 bytes = ns.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                ManagerLib.Utils.LogService("Received : " + responseData);

                string[] splitter = responseData.Split(';');

                tbState.Text = splitter[0];
                
                if(splitter.Length > 1)
                {
                    DialogResult dr = MessageBox.Show("Add " + m_ID + " to your contacts ?", "Add contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(dr == DialogResult.Yes)
                    {
                        string IP = splitter[1];
                        string HostName = splitter[2];

                        AddContactForm addContact = new AddContactForm(IP, HostName);
                        addContact.ShowDialog();
                    }
                }
                
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
            this.m_ID = tbURL.Text;
        }
        
        private void rbSwitchOff_CheckedChanged(object sender, EventArgs e)
        {
            m_action = Action.SWITCH_OFF;
        }

        private void rbSleep_CheckedChanged(object sender, EventArgs e)
        {
            m_action = Action.SLEEP;
        }

        private void rbLogOff_CheckedChanged(object sender, EventArgs e)
        {
            m_action = Action.LOG_OFF;
        }

        private void rbLock_CheckedChanged(object sender, EventArgs e)
        {
            m_action = Action.LOCK;
        }
        #endregion


        public void test()
        {
            var uri = new Uri("http://randomIP:port/Service");

            var binding =
                new WebHttpBinding(uri.Scheme == Uri.UriSchemeHttp
                ? WebHttpSecurityMode.Transport
                : WebHttpSecurityMode.None);

            var factory = new ChannelFactory<IService1>(binding, new EndpointAddress(uri));

            var client = factory.CreateChannel();

            string s = client.SayHelloWorld();
        }
    }
}
