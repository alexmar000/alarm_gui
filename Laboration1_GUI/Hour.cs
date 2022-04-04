using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1_GUI
{
    static class Hour
    {
        public static int HourValue { get; set; }

        public static void Tick()
        {
            HourValue++;
        }

    }
}
