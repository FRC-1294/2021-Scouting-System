using System;
using System.Windows.Forms;

namespace _1294_Scouting
{
    public partial class Start : Form
    {
        public Start() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e)
        {
            Scout s = new Scout();
            s.Show();
            Hide();
            s.FormClosed += new FormClosedEventHandler(Close);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            s.Show();
            Hide();
            s.FormClosed += new FormClosedEventHandler(Close);
        }

        private void Close(object sender, EventArgs e) => Close();
    }
}
