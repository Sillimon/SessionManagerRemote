using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteManager
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        public AddContactForm(string IP, string HostName)
        {
            InitializeComponent();

            string[] splitter = HostName.Split('.');

            tbName.Text = splitter[0];

            tbIP.Text = IP;
            tbIP.Enabled = false;

            tbHostName.Text = HostName;
            tbHostName.Enabled = false;
        }
    }
}
