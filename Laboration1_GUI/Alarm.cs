using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration1_GUI
{
    public class Alarm
    {
        private int? AlarmHour { get; set; }
        private int? AlarmMinute { get; set; }
        private int AlarmOffIndex { get; set; }
        private Timer alarmTimer = new();

        public event EventHandler AlarmRinged;

        public void SetAlarm(string hour, string minute)
        {
            Clock.ClockTicked += this.CheckAlarm;
            AlarmHour = Int32.Parse(hour);
            AlarmMinute = Int32.Parse(minute);
        }
        public void CheckAlarm(object source, EventArgs e)
        {
            if (TimeToRingAlarm())
            {
                alarmTimer.Start();
                alarmTimer.Interval = 500;
                alarmTimer.Tick += RingAlarm;
            }
        }

        public void RingAlarm(object source, EventArgs e)
        {
            AlarmOffIndex++;

            switch (AlarmOffIndex)
            {
                case 20:
                    StopAlarm();
                    break;
                default:
                    OnAlarmRinged();
                    break;
            }
        }
        public void StopAlarm()
        {
            Clock.ClockTicked -= this.CheckAlarm;
            alarmTimer.Tick -= RingAlarm;
            AlarmOffIndex = 0;
            //Clock.ClockTicked -= RingAlarm;
        }
        private bool TimeToRingAlarm()
        {
            return Hour.HourValue == AlarmHour && Minute.MinuteValue == AlarmMinute;
        }
        protected void OnAlarmRinged()
        {
            AlarmRinged?.Invoke(this, EventArgs.Empty);
        }
    }
}

