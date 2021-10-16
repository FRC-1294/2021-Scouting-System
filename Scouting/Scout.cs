using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace _1294_Scouting
{

    public partial class Scout : Form
    {
        private bool allowDataChange = true;
        Mongo.Mongo mongoDB;
        private RobotMatchData data;
        public Scout()
        {
            InitializeComponent();
            //Scouting.LeTester leubertest = new Scouting.LeTester();
            //leubertest.Show();
            LockUI();
            getDataFromServerButton.Enabled = false;
        }

        public void UpdateCheckBoxes(object sender, EventArgs e)
        {
            if(allowDataChange)
            {
                UpdateRobotDataWithCheckBoxes();
            }
        }
        public void UpdateRobotDataWithCheckBoxes()
        {
            //Autonomous
            if (autoNo.Checked)
            {
                data.auto = Auto.None;
            }
            else if (autoMove.Checked)
            {
                data.auto = Auto.Moved;
            }
            else if (autoScore.Checked)
            {
                data.auto = Auto.Scored;
            }
            //Climb
            if (climbNo.Checked)
            {
                data.climb = Climb.No;
            }
            else if (climbYes.Checked)
            {
                data.climb = Climb.Yes;
            } else if (climbPark.Checked)
            {
                data.climb = Climb.Park;
            } else if (climbBalance.Checked)
            {
                data.climb = Climb.Balance;
            }
            //Wheel

            data.wheelMatch = wheelMatch.Checked;
            data.wheelSpin = wheelSpin.Checked;
            data.defense = defenceBox.Checked;
            RefreshScreenWithRobotData();
        }

        public void RefreshScreenWithRobotData()
        {
            allowDataChange = false;
            //Auto
            if(data.auto == Auto.None)
            {
                autoNo.Checked = true;
            } else if (data.auto == Auto.Moved)
            {
                autoMove.Checked = true;
            } else if (data.auto == Auto.Scored)
            {
                autoScore.Checked = true;
            }

            if (data.climb == Climb.No)
            {
                climbNo.Checked = true;
            } else if (data.climb == Climb.Yes)
            {
                climbYes.Checked = true;
            } else if (data.climb == Climb.Park)
            {
                climbPark.Checked = true;
            } else if (data.climb == Climb.Balance)
            {
                climbBalance.Checked = true;
            }

            //Wheel
            wheelSpin.Checked = data.wheelSpin;
            wheelMatch.Checked = data.wheelMatch;

            //Defense
            defenceBox.Checked = data.defense;

            //Power cells
            powerCellsTop.Text = data.powerCellsTop.ToString();
            powerCellsBottom.Text = data.powerCellsBottom.ToString();

            //Robot
            currentRobot.Text = data.number.ToString();

            //Match
            currentMatch.Text = data.match.ToString();

            //Debug output
            allowDataChange = true;
        }

        //POWER CELLS
        #region powerCells

        //Top
        private void PowerCellsTop_TextChanged(object sender, EventArgs e)
        {
            if (powerCellsTop.Text != "")
            {
                try
                {
                    data.powerCellsTop = int.Parse(powerCellsTop.Text);
                    RefreshScreenWithRobotData();
                }
                catch
                {
                    if (powerCellsTop.Text.StartsWith("-"))
                    {
                        MessageBox.Show("A robot can't score a negative number of power cells. Try again!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid number. Please try again");
                    }
                }
            }
        }
        private void PowerCellTopAdd_Click(object sender, EventArgs e)
        {
            data.powerCellsTop++;
            RefreshScreenWithRobotData();
        }
        private void PowerCellsTopSubtract_Click(object sender, EventArgs e)
        {
            if (data.powerCellsTop - 1 < 0)
            {
                MessageBox.Show("A robot can't score a negative number of power cells. Try again!");
            }
            else
            {
                data.powerCellsTop--;
                RefreshScreenWithRobotData();
            }
        }

        //Bottom
        private void PowerCellsBottom_TextChanged(object sender, EventArgs e)
        {
            if (powerCellsBottom.Text != "")
            {
                try
                {
                    data.powerCellsBottom = int.Parse(powerCellsBottom.Text);
                    RefreshScreenWithRobotData();
                }
                catch
                {
                    if (powerCellsBottom.Text.StartsWith("-"))
                    {
                        MessageBox.Show("A robot can't score a negative number of power cells. Try again!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid number. Please try again");
                    }
                }
            }
        }
        private void PowerCellsBottomAdd_Click(object sender, EventArgs e)
        {
            data.powerCellsBottom++;
            RefreshScreenWithRobotData();
        }
        private void PowerCellsBottomSubtract_Click(object sender, EventArgs e)
        {
            if (data.powerCellsBottom - 1 < 0)
            {
                MessageBox.Show("A robot can't score a negative number of power cells. Try again!");
            }
            else
            {
                data.powerCellsBottom--;
                RefreshScreenWithRobotData();
            }
        }
        #endregion

        //Controls
        //These are designed to be run when commands are recieved from the server.
            
        public void SubmitData()
        {
            mongoDB.SendMatchData(data.GetMongoDocument());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            LockUI();
            statusBar.SetState(3);
            submitButton.Text = "Sumbitting data...";
            try
            {
                SubmitData();
                statusBar.SetState(1);
            } catch (TimeoutException)
            {
                statusBar.SetState(2);
                MessageBox.Show("Unable to send data to server.");
            } finally
            {
                submitButton.Text = "Submit Data";
            }
        }

        public void NextMatch(int teamNumber, int match)
        {
            data = new RobotMatchData(teamNumber, match);
            RefreshScreenWithRobotData();
            UnlockUI();
            statusBar.SetState(1);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BsonDocument config = mongoDB.GetConfigFromServer();
            //Check if scout number exists
            if(!config.Contains(scoutNumber.Text))
            {
                MessageBox.Show("Invalid scout number. Try again!");
                return;
            }

            //Get the data
            if(data != null)
            {
                if(data.number == config.GetValue(scoutNumber.Text).AsInt32 && data.match == config.GetValue("match").AsInt32)
                {
                    MessageBox.Show("No new data yet");
                    return;
                }
            }
            NextMatch(config.GetValue(scoutNumber.Text).AsInt32, config.GetValue("match").AsInt32);

        }

        private void OverrideServerBox_CheckedChanged(object sender, EventArgs e)
        {
            if(overrideServerBox.Checked)
            {
                getDataFromServerButton.Enabled = false;
                serverOverridePanel.Visible = true;
            } else
            {
                getDataFromServerButton.Enabled = true;
                serverOverridePanel.Visible = false;
            }
        }

        private void LockUI()
        {
           scoutingControlPanel.Enabled = false;            
        }

        private void UnlockUI()
        {
            scoutingControlPanel.Enabled = true;
        }

        private void OverrideButton_Click(object sender, EventArgs e)
        {
            if(!overrideRobotBox.canValidate())
            {
                MessageBox.Show("Invalid Robot number. Try again!");
                return;
            }
            if(!overrideMatchBox.canValidate())
            {
                MessageBox.Show("Invalid Match number. Try again!");
                return;
            }
            NextMatch(int.Parse(overrideRobotBox.Text), int.Parse(overrideMatchBox.Text));
        }

        private void serverConnect_Click(object sender, EventArgs e)
        {
            mongoDB = new Mongo.Mongo(serverAddress.Text);
            getDataFromServerButton.Enabled = true;
        }
    }
}