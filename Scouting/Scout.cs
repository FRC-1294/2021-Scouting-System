using System;
using System.Windows.Forms;

namespace _1294_Scouting
{

    public partial class Scout : Form
    {
        private RobotMatchData data;
        public Scout()
        {
            InitializeComponent();
            data = new RobotMatchData();
        }

        public void UpdateData(object sender, EventArgs e)
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
                data.climb = false;
            }
            else if (climbYes.Checked)
            {
                data.climb = true;
            }
            //Wheel

            data.wheelMatch = wheelMatch.Checked;
            data.wheelSpin = wheelSpin.Checked;

            powerCellsTop.Text = data.powerCellsTop.ToString();
            powerCellsBottom.Text = data.powerCellsBottom.ToString();

            debugLabel.Text = data.toString();
        }

        private void powerCellsTop_TextChanged(object sender, EventArgs e)
        {
            if (powerCellsTop.Text != "")
            {
                try
                {
                    data.powerCellsTop = int.Parse(powerCellsTop.Text);
                    UpdateData(sender, e);
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
            UpdateData(sender, e);


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
                UpdateData(sender, e);
            }

        }


        private void powerCellsBottom_TextChanged(object sender, EventArgs e)
        {
            if (powerCellsBottom.Text != "")
            {
                try
                {
                    data.powerCellsBottom = int.Parse(powerCellsBottom.Text);
                    UpdateData(sender, e);
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
            UpdateData(sender, e);
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
                UpdateData(sender, e);
            }

        }
    }
}