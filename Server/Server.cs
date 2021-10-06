using System;
using MongoDB.Bson;
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

        private void aggregateButton_Click(object sender, EventArgs e)
        {
            Mongo.Mongo m = new Mongo.Mongo();
            var result = m.getAggreation();
            string outputText = "";
            foreach (BsonDocument doc in result.ToArray())
            {
                outputText += doc.ToString() + "\n";
            }
            aggregationResult.Text = outputText;
        }
    }
}
