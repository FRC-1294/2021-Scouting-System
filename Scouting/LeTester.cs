using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1294_Scouting.Scouting
{
    public partial class LeTester : Form
    {
        public LeTester()
        {
            InitializeComponent();
        }

        private void SendMatch_Click(object sender, EventArgs e)
        {
            Program.START.SCOUTING_WINDOW.nextMatch(int.Parse(Robot.Text), int.Parse( Match.Text));
        }
    }
}
