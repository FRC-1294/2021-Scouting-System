using System;
using System.Windows.Forms;

namespace _1294_Scouting
{
    public partial class Server : Form
    {
        public Server() => InitializeComponent();

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (sendArm.Checked)
            {
                sendArm.Checked = false;
                //TODO Send next match to clients
            }
        }

        private void sendArm_CheckedChanged(object sender, EventArgs e)
        {
            if (sendArm.Checked)
            {
                sendButton.Enabled = true;
                sendButton.Text = "SEND NEXT MATCH";
                sendArm.Text = "ARMED";
            }
            else
            {
                sendButton.Enabled = false;
                sendButton.Text = "disarmed";
                sendArm.Text = "Check to arm";
            }

        }
    }
}
