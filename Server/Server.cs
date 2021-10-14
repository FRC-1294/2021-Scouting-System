using System;
using MongoDB.Bson;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _1294_Scouting
{
    public partial class Server : Form
    {
        Mongo.Mongo m;
        public Server() {
            InitializeComponent();
            m = new Mongo.Mongo();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (sendArm.Checked)
            {
                sendArm.Checked = false;
                //TODO Send next match to clients
                try
                {
                    BsonDocument controlData = new BsonDocument {
                        {"match", int.Parse(nextMatchBox.Text) },
                        {"s1", int.Parse(s1Input.Text)},
                        {"s2", int.Parse(s2Input.Text)},
                        {"s3", int.Parse(s3Input.Text)},
                        {"s4", int.Parse(s4Input.Text)},
                        {"s5", int.Parse(s5Input.Text)},
                        {"s6", int.Parse(s6Input.Text)}
                    };
                    currentMatchBox.Text = nextMatchBox.Text;
                    s1Team.Text = s1Input.Text;
                    s2Team.Text = s2Input.Text;
                    s3Team.Text = s3Input.Text;
                    s4Team.Text = s4Input.Text;
                    s5Team.Text = s5Input.Text;
                    s6Team.Text = s6Input.Text;

                }catch (FormatException)
                {
                    MessageBox.Show("Invalid number. Try again!");
                }
                
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
            List<BsonDocument> result = m.GetAggreation();
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
