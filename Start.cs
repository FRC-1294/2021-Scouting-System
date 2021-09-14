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
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Scout s = new Scout();
			s.Show();
			Hide();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Server s = new Server();
			s.Show();
			Hide();

		}
	}
}
