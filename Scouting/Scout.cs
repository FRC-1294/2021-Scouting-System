using MongoDB.Bson;
using MongoDB.Driver;
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
                UpdateCheckBoxes();
            }
        }
        public void UpdateCheckBoxes()
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
            }
            //Wheel

            data.wheelMatch = wheelMatch.Checked;
            data.wheelSpin = wheelSpin.Checked;
            RefreshScreen();
        }

        public void RefreshScreen()
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
            debugLabel.Text = data.ToString();
            allowDataChange = true;
        }

        //POWER CELLS
        #region powerCells

        //Top
        private void powerCellsTop_TextChanged(object sender, EventArgs e)
        {
            if (powerCellsTop.Text != "")
            {
                try
                {
                    data.powerCellsTop = int.Parse(powerCellsTop.Text);
                    RefreshScreen();
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
        private void powerCellTopAdd_Click(object sender, EventArgs e)
        {
            data.powerCellsTop++;
            RefreshScreen();
        }
        private void powerCellsTopSubtract_Click(object sender, EventArgs e)
        {
            if (data.powerCellsTop - 1 < 0)
            {
                MessageBox.Show("A robot can't score a negative number of power cells. Try again!");
            }
            else
            {
                data.powerCellsTop--;
                RefreshScreen();
            }
        }

        //Bottom
        private void powerCellsBottom_TextChanged(object sender, EventArgs e)
        {
            if (powerCellsBottom.Text != "")
            {
                try
                {
                    data.powerCellsBottom = int.Parse(powerCellsBottom.Text);
                    RefreshScreen();
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
        private void powerCellsBottomAdd_Click(object sender, EventArgs e)
        {
            data.powerCellsBottom++;
            RefreshScreen();
        }
        private void powerCellsBottomSubtract_Click(object sender, EventArgs e)
        {
            if (data.powerCellsBottom - 1 < 0)
            {
                MessageBox.Show("A robot can't score a negative number of power cells. Try again!");
            }
            else
            {
                data.powerCellsBottom--;
                RefreshScreen();
            }
        }
        #endregion

        //Controls
        //These are designed to be run when commands are recieved from the server.
            
        public void SubmitData()
        {
            mongoDB.SendData(data.GetMongoDocument(), data.number);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            statusBar.SetState(3);
            SubmitData();
            statusBar.SetState(1);
        }

        public void nextMatch(int teamNumber, int match)
        {
            data = new RobotMatchData(teamNumber, match);
            RefreshScreen();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshScreen();
        }
    }
}