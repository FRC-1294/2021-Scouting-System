using System;
using MongoDB.Bson;
using System.Windows.Forms;

namespace _1294_Scouting
{
    public partial class Server : Form
    {
        public Server() => InitializeComponent();

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (sendArm.Checked)
            {
                sendArm.Checked = false;
                //TODO Send next match to clients
            }
        }

        private void SendArm_CheckedChanged(object sender, EventArgs e)
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

        private void AggregateButton_Click(object sender, EventArgs e)
        {
            Mongo.Mongo m = new Mongo.Mongo();
            System.Collections.Generic.List<BsonDocument> result = m.GetAggreation();
            string outputText = "";
            foreach (BsonDocument doc in result.ToArray())
            {
                outputText += $"Team: {doc.GetValue("_id", "NOT FOUND")}\n" +
                    $"average top powercells: {doc.GetValue("CommitAveragePowerCellsTop", "NOT FOUND").AsDouble : 0.0}\n" +
                    $"Debug: {doc}\n\n";                
            }
            aggregationResult.Text = outputText;
        }
    }
}
