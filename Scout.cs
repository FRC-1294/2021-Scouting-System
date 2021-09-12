using System;
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
        public Scout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            powerCells.Text = "It scored some!";
        }
    }
}
