using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1_GUI
{
    static class Minute
    {
        public static int MinuteValue { get; set; }

        public static void Tick()
        {
            MinuteValue++;
        }
    }
}
