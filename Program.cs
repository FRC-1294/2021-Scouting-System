using System;
using System.Windows.Forms;

namespace _1294_Scouting
{
    internal static class Program
    {
        public static Start START;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            START = new Start();
            Application.Run(START);
        }
    }
}
