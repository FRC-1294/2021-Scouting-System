using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace _1294_Scouting
{

    public partial class Scout : Form
    {
        Mongo.Mongo mongoDB;
        private RobotMatchData data;
        public Scout()
        {
            InitializeComponent();
            mongoDB = new Mongo.Mongo();
        }

        public void UpdateData(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
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

            //Power cells
            powerCellsTop.Text = data.powerCellsTop.ToString();
            powerCellsBottom.Text = data.powerCellsBottom.ToString();

            //Debug output
            debugLabel.Text = data.ToString();
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
                    UpdateData();
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
            UpdateData();
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
                UpdateData();
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
                    UpdateData();
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
            UpdateData();
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
                UpdateData();
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
            UpdateData();
        }
    }
}