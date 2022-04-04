using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Laboration1_GUI.Parser;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading;
using System.Drawing.Text;

namespace Laboration1_GUI
{
    public partial class Form1 : Form
    {

        public event EventHandler ClockInputCorrect;
        public event EventHandler AlarmTurnedOff;
        public Alarm alarm1 = new Alarm();
        public Alarm alarm2 = new Alarm();
        int[] alarmBtnLocation = new int[] { 0, 0, 152, 130, 26, 92, 83, 133 };
        int hopFirstInit = 0;
        int alarmBtnLocationIndex = 0;
        bool firstTime = true;
        int secondTime;
        public Form1()
        {
            InitializeComponent();
            ClockInputCorrect += Clock.OnClockInputCorrect;
            ClockInputCorrect += OnClockInputCorrect;
            Clock.ClockTicked += OnClockTicked;
            alarm1.AlarmRinged += OnAlarm1Ringed;
            alarm2.AlarmRinged += OnAlarm2Ringed;
            AlarmTurnedOff += OnAlarmTurnedOff;
        }

        public virtual void OnClockInputCorrect()
        {
            ClockInputCorrect?.Invoke(null, EventArgs.Empty);

        }
        public virtual void OnAlarmTurnedOff()
        {
            AlarmTurnedOff?.Invoke(this, EventArgs.Empty);
        }
        public void OnClockTicked(object source, EventArgs e)
        {
            ClockLabel.Text = $"{Clock.GetHours()}:{Clock.GetMinutes()}";
        }
        
        private void Alarm1BtnHop()
        {
            while (hopFirstInit == 0)
            {
                this.Alarm1Btn.MouseEnter += new System.EventHandler(this.Alarm1Btn_MouseEnter);
                this.Alarm1Btn.MouseLeave += new System.EventHandler(this.Alarm1Btn_MouseLeave);
                hopFirstInit++;
            }
        }
        private void OnClockInputCorrect(object sender, EventArgs e)
        {
            ClockBtn.Text = "Stop";
            ClockHourTextBox.ReadOnly = true;
            ClockMinuteTextBox.ReadOnly = true;
            Clock.SetTime(ClockHourTextBox.Text, ClockMinuteTextBox.Text);
            ClockLabel.Text = $"{Clock.GetHours()}:{Clock.GetMinutes()}";
        }
        private void OnClockTurnedOff()
        {
            ClockLabel.Text = "00:00";
            ClockBtn.Text = "Start";
            ClockHourTextBox.ReadOnly = false;
            ClockMinuteTextBox.ReadOnly = false;
        }
        private void ClockBtn_Click(object sender, EventArgs e)
        {
            if (ClockBtn.Text == "Start")
            {
                if (CorrectInputHour(ClockHourTextBox.Text) && CorrectInputMinute(ClockMinuteTextBox.Text))
                {
                    OnClockInputCorrect();
                    return;
                }
            }
            Clock.StopClock();
            OnClockTurnedOff();
        }
        private void OnAlarmTurnedOff(object sender, EventArgs e)
        {
            Alarm1Btn.Text = "Set Alarm";
            AlarmHourTextBox.ReadOnly = false;
            AlarmMinuteTextBox.ReadOnly = false;
            AlarmGroupBox.BackColor = Color.Transparent;
            alarm1.StopAlarm();

        }
        private void OnAlarm1Ringed(object sender, EventArgs e)
        {
            Task.Run(() => AlarmSpeaker());
            Alarm1BtnHop();
            AlarmGroupBoxReaction(AlarmGroupBox);
        }

        private void OnAlarm2Ringed(object source, EventArgs e)
        {
            Task.Run(() => AlarmSpeaker());
            AlarmGroupBoxReaction(Alarm2GroupBox);
        }

        private void AlarmGroupBoxReaction(GroupBox alarmGrpBox)
        {
            if (alarmGrpBox.BackColor != Color.Red)
            {
                alarmGrpBox.BackColor = Color.Red;
                return;
            }
            alarmGrpBox.BackColor = Color.White;
        }
        private void AlarmSpeaker()
        {
            string alarmString = "ALARMA!";
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(alarmString);
            speechSynthesizer.Dispose();

        }
        private void Alarm1Btn_Click(object sender, EventArgs e)
        {
            if (Alarm1Btn.Text == "Set Alarm")
            {
                if (Parser.CorrectInputHour(AlarmHourTextBox.Text) && Parser.CorrectInputMinute(AlarmMinuteTextBox.Text))
                {
                    Alarm1Btn.Text = "Unset Alarm";
                    AlarmHourTextBox.ReadOnly = true;
                    AlarmMinuteTextBox.ReadOnly = true;
                    alarm1.SetAlarm(AlarmHourTextBox.Text, AlarmMinuteTextBox.Text);
                    return;
                }
                MessageBox.Show("      Invalid input!      ");
            }
            Alarm1Btn.Text = "Set Alarm";
            AlarmHourTextBox.ReadOnly = false;
            AlarmMinuteTextBox.ReadOnly = false;
            AlarmGroupBox.BackColor = Color.Transparent;
            alarm1.StopAlarm();
            //OnAlarmTurnedOff();
        }
        private void Alarm2Btn_Click(object sender, EventArgs e)
        {
            if (Alarm2Btn.Text == "Set Alarm")
            {
                if (Parser.CorrectInputHour(Alarm2HourTextBox.Text) && Parser.CorrectInputMinute(Alarm2MinuteTextBox.Text))
                {
                    Alarm2Btn.Text = "Unset Alarm";
                    Alarm2HourTextBox.ReadOnly = true;
                    Alarm2MinuteTextBox.ReadOnly = true;
                    alarm2.SetAlarm(Alarm2HourTextBox.Text, Alarm2MinuteTextBox.Text);
                    return;
                }
                MessageBox.Show("      Invalid input!      ");
            }
            Alarm2Btn.Text = "Set Alarm";
            Alarm2HourTextBox.ReadOnly = false;
            Alarm2MinuteTextBox.ReadOnly = false;
            Alarm2GroupBox.BackColor = Color.Transparent;
            alarm2.StopAlarm();
        }
        private void ClockHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void ClockMinuteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void AlarmHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void AlarmMinuteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void Alarm2HourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void Alarm2MinuteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }
        private void Alarm1Btn_MouseEnter(object sender, EventArgs e)
        {
            if (firstTime)
            {
                if (secondTime < 4)
                {
                    Alarm1Btn.Location = new Point(alarmBtnLocation[alarmBtnLocationIndex], alarmBtnLocation[alarmBtnLocationIndex + 1]);
                    firstTime = false;
                    secondTime++;
                    alarmBtnLocationIndex += 2;
                }
                firstTime = false;
            }
        }

        private void Alarm1Btn_MouseLeave(object sender, EventArgs e)
        {
            firstTime = true;
        }
    }
}

