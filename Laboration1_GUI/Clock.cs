using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Laboration1_GUI
{
    class Clock
    {
        public static event EventHandler ClockTicked;
        private static Timer clockTimer = new();
        private static int firstInit = 0;
        public static void OnClockInputCorrect(object source, EventArgs e)
        {
            StartClock();
        }
        public static void OnTick(object source, EventArgs e)
        {
            if (Minute.MinuteValue < 59)
            {
                Minute.Tick();
            }
            else if (Hour.HourValue != 23)
            {
                Minute.MinuteValue = 0;
                Hour.Tick();
            }
            else
            {
                Hour.HourValue = 0;
                Minute.MinuteValue = 0;
            }
            OnClockTicked();
            
        }
        protected static void OnClockTicked()
        {
            ClockTicked?.Invoke(null, EventArgs.Empty);
        }
        public static void StartClock()
        {
            while (firstInit == 0)
            {
                clockTimer.Tick += OnTick;
                firstInit++;
        }
        clockTimer.Interval = 1000;
            clockTimer.Start();
        }
        public static void StopClock()
        {
            clockTimer.Stop();
            Minute.MinuteValue = 0;
            Hour.HourValue = 0;
        }
        public static string GetMinutes()
        {
            return Minute.MinuteValue.ToString("D2");
        }
        public static string GetHours()
        {
            return Hour.HourValue.ToString("D2");
            
        }
        public static void SetTime(string hour, string minute)
        {
            Hour.HourValue = Int32.Parse(hour);
            Minute.MinuteValue = Int32.Parse(minute);
        }
        
    }
}
