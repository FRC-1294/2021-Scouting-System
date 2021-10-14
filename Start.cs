using _1294_Scouting.Pre_Match;
using System;
using System.Windows.Forms;

namespace _1294_Scouting
{
    public partial class Start : Form
    {
        public Scout SCOUTING_WINDOW;
        public Server SERVER_WINDOW;
        public PreMatch PREMATCH_WINDOW;
        public Start() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e)
        {
            SCOUTING_WINDOW = new Scout();
            SCOUTING_WINDOW.Show();
            Hide();
            SCOUTING_WINDOW.FormClosed += new FormClosedEventHandler(Close);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SERVER_WINDOW = new Server();
            SERVER_WINDOW.Show();
            Hide();
            SERVER_WINDOW.FormClosed += new FormClosedEventHandler(Close);
        }

        private void Close(object sender, EventArgs e) => Close();

        private void PreMatchButton_Click(object sender, EventArgs e)
        {
            PREMATCH_WINDOW = new PreMatch();
            PREMATCH_WINDOW.Show();
            Hide();
            PREMATCH_WINDOW.FormClosed += new FormClosedEventHandler(Close);
        }
    }
}
