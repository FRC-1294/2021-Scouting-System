﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1294_Scouting
{

    public partial class Scout : Form
    {
        RobotMatchData data;
        public Scout()
        {
            InitializeComponent();
            data = new RobotMatchData();
        }

        public void UpdateData(object sender, EventArgs e)
        {
            //Autonomous
            if(autoNo.Checked)
            {
                data.auto = Auto.None;
            } else if (autoMove.Checked)
            {
                data.auto = Auto.Moved;
            } else if (autoScore.Checked)
            {
                data.auto = Auto.Scored;
            }
            //Climb
            if(climbNo.Checked)
            {
                data.climb = false;
            } else if (climbYes.Checked)
            {
                data.climb = true;
            } 
            //Wheel
            
            data.wheelMatch = wheelMatch.Checked;
            data.wheelSpin = wheelSpin.Checked;
            
            debugLabel.Text = data.toString();
        }
    }
}