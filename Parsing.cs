using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1294_Scouting
{
    public static class Parsing
    {
        public static bool canValidate(this TextBox boxy)
        {
            return int.TryParse(boxy.Text, out int _);
        }
    }
}
