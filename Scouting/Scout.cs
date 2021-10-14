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
            mongoDB = new Mongo.Mongo();
            Scouting.LeTester leubertest = new Scouting.LeTester();
            leubertest.Show();
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
            mongoDB.SendData(data.GetMongoDocument());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            LockUI();
            statusBar.SetState(3);
            SubmitData();
            statusBar.SetState(1);
        }

        public void NextMatch(int teamNumber, int match)
        {
            data = new RobotMatchData(teamNumber, match);
            RefreshScreenWithRobotData();
            UnlockUI();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //TODO Add logic for overriden server
            if(scoutNumber.canValidate())
            {
                int.Parse(scoutNumber.Text);
                //TODO Get data from server
            } else
            {
                MessageBox.Show("Invalid scout number. Try again!");
            }
        }

        private void overrideServerBox_CheckedChanged(object sender, EventArgs e)
        {
            UnlockUI();
            if(overrideServerBox.Checked)
            {
                currentRobot.ReadOnly = false;
                currentMatch.ReadOnly = false;
                refreshButton.Text = "Setup for next match using above robot and match";
            } else
            {
                currentRobot.ReadOnly = true;
                currentMatch.ReadOnly = true;
                refreshButton.Text = "Get next match and robot from server";
            }
        }

        private void LockUI()
        {
            if(!overrideServerBox.Checked)
            {
                scoutingControlPanel.Enabled = false;
            }
        }

        private void UnlockUI()
        {
            scoutingControlPanel.Enabled = true;
        }
      
    }
}