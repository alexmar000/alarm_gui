
namespace Laboration1_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClockGroupBox = new System.Windows.Forms.GroupBox();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClockMinuteTextBox = new System.Windows.Forms.TextBox();
            this.ClockHourTextBox = new System.Windows.Forms.TextBox();
            this.AlarmGroupBox = new System.Windows.Forms.GroupBox();
            this.Alarm1Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AlarmSetHourLabel = new System.Windows.Forms.Label();
            this.AlarmHourTextBox = new System.Windows.Forms.TextBox();
            this.AlarmMinuteTextBox = new System.Windows.Forms.TextBox();
            this.Alarm2GroupBox = new System.Windows.Forms.GroupBox();
            this.Alarm2Btn = new System.Windows.Forms.Button();
            this.Alarm2MinuteTextBox = new System.Windows.Forms.TextBox();
            this.Alarm2HourTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClockGroupBox.SuspendLayout();
            this.AlarmGroupBox.SuspendLayout();
            this.Alarm2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClockGroupBox
            // 
            this.ClockGroupBox.Controls.Add(this.ClockLabel);
            this.ClockGroupBox.Controls.Add(this.ClockBtn);
            this.ClockGroupBox.Controls.Add(this.label2);
            this.ClockGroupBox.Controls.Add(this.label1);
            this.ClockGroupBox.Controls.Add(this.ClockMinuteTextBox);
            this.ClockGroupBox.Controls.Add(this.ClockHourTextBox);
            this.ClockGroupBox.Location = new System.Drawing.Point(50, 73);
            this.ClockGroupBox.Name = "ClockGroupBox";
            this.ClockGroupBox.Size = new System.Drawing.Size(355, 343);
            this.ClockGroupBox.TabIndex = 0;
            this.ClockGroupBox.TabStop = false;
            this.ClockGroupBox.Text = "Clock";
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClockLabel.Location = new System.Drawing.Point(136, 198);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(62, 30);
            this.ClockLabel.TabIndex = 5;
            this.ClockLabel.Text = "00:00";
            // 
            // ClockBtn
            // 
            this.ClockBtn.Location = new System.Drawing.Point(102, 277);
            this.ClockBtn.Name = "ClockBtn";
            this.ClockBtn.Size = new System.Drawing.Size(146, 29);
            this.ClockBtn.TabIndex = 4;
            this.ClockBtn.Text = "Start";
            this.ClockBtn.UseVisualStyleBackColor = true;
            this.ClockBtn.Click += new System.EventHandler(this.ClockBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set minutes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set hour:";
            // 
            // ClockMinuteTextBox
            // 
            this.ClockMinuteTextBox.Location = new System.Drawing.Point(102, 121);
            this.ClockMinuteTextBox.MaxLength = 2;
            this.ClockMinuteTextBox.Name = "ClockMinuteTextBox";
            this.ClockMinuteTextBox.Size = new System.Drawing.Size(111, 23);
            this.ClockMinuteTextBox.TabIndex = 1;
            this.ClockMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClockMinuteTextBox_KeyPress);
            // 
            // ClockHourTextBox
            // 
            this.ClockHourTextBox.Location = new System.Drawing.Point(102, 72);
            this.ClockHourTextBox.MaxLength = 2;
            this.ClockHourTextBox.Name = "ClockHourTextBox";
            this.ClockHourTextBox.Size = new System.Drawing.Size(111, 23);
            this.ClockHourTextBox.TabIndex = 0;
            this.ClockHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClockHourTextBox_KeyPress);
            // 
            // AlarmGroupBox
            // 
            this.AlarmGroupBox.Controls.Add(this.Alarm1Btn);
            this.AlarmGroupBox.Controls.Add(this.label3);
            this.AlarmGroupBox.Controls.Add(this.AlarmSetHourLabel);
            this.AlarmGroupBox.Controls.Add(this.AlarmHourTextBox);
            this.AlarmGroupBox.Controls.Add(this.AlarmMinuteTextBox);
            this.AlarmGroupBox.Location = new System.Drawing.Point(497, 83);
            this.AlarmGroupBox.Name = "AlarmGroupBox";
            this.AlarmGroupBox.Size = new System.Drawing.Size(315, 170);
            this.AlarmGroupBox.TabIndex = 1;
            this.AlarmGroupBox.TabStop = false;
            this.AlarmGroupBox.Text = "Alarm 1";
            // 
            // Alarm1Btn
            // 
            this.Alarm1Btn.Location = new System.Drawing.Point(83, 133);
            this.Alarm1Btn.Name = "Alarm1Btn";
            this.Alarm1Btn.Size = new System.Drawing.Size(146, 29);
            this.Alarm1Btn.TabIndex = 5;
            this.Alarm1Btn.Text = "Set Alarm";
            this.Alarm1Btn.UseVisualStyleBackColor = true;
            this.Alarm1Btn.Click += new System.EventHandler(this.Alarm1Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Set minutes:";
            // 
            // AlarmSetHourLabel
            // 
            this.AlarmSetHourLabel.AutoSize = true;
            this.AlarmSetHourLabel.Location = new System.Drawing.Point(101, 29);
            this.AlarmSetHourLabel.Name = "AlarmSetHourLabel";
            this.AlarmSetHourLabel.Size = new System.Drawing.Size(54, 15);
            this.AlarmSetHourLabel.TabIndex = 3;
            this.AlarmSetHourLabel.Text = "Set hour:";
            // 
            // AlarmHourTextBox
            // 
            this.AlarmHourTextBox.Location = new System.Drawing.Point(101, 51);
            this.AlarmHourTextBox.MaxLength = 2;
            this.AlarmHourTextBox.Name = "AlarmHourTextBox";
            this.AlarmHourTextBox.Size = new System.Drawing.Size(108, 23);
            this.AlarmHourTextBox.TabIndex = 2;
            this.AlarmHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlarmHourTextBox_KeyPress);
            // 
            // AlarmMinuteTextBox
            // 
            this.AlarmMinuteTextBox.Location = new System.Drawing.Point(101, 95);
            this.AlarmMinuteTextBox.MaxLength = 2;
            this.AlarmMinuteTextBox.Name = "AlarmMinuteTextBox";
            this.AlarmMinuteTextBox.Size = new System.Drawing.Size(108, 23);
            this.AlarmMinuteTextBox.TabIndex = 1;
            this.AlarmMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlarmMinuteTextBox_KeyPress);
            // 
            // Alarm2GroupBox
            // 
            this.Alarm2GroupBox.Controls.Add(this.Alarm2Btn);
            this.Alarm2GroupBox.Controls.Add(this.Alarm2MinuteTextBox);
            this.Alarm2GroupBox.Controls.Add(this.Alarm2HourTextBox);
            this.Alarm2GroupBox.Controls.Add(this.label5);
            this.Alarm2GroupBox.Controls.Add(this.label4);
            this.Alarm2GroupBox.Location = new System.Drawing.Point(497, 259);
            this.Alarm2GroupBox.Name = "Alarm2GroupBox";
            this.Alarm2GroupBox.Size = new System.Drawing.Size(315, 157);
            this.Alarm2GroupBox.TabIndex = 2;
            this.Alarm2GroupBox.TabStop = false;
            this.Alarm2GroupBox.Text = "Alarm 2";
            // 
            // Alarm2Btn
            // 
            this.Alarm2Btn.Location = new System.Drawing.Point(83, 124);
            this.Alarm2Btn.Name = "Alarm2Btn";
            this.Alarm2Btn.Size = new System.Drawing.Size(146, 27);
            this.Alarm2Btn.TabIndex = 4;
            this.Alarm2Btn.Text = "Set Alarm";
            this.Alarm2Btn.UseVisualStyleBackColor = true;
            this.Alarm2Btn.Click += new System.EventHandler(this.Alarm2Btn_Click);
            // 
            // Alarm2MinuteTextBox
            // 
            this.Alarm2MinuteTextBox.Location = new System.Drawing.Point(101, 81);
            this.Alarm2MinuteTextBox.MaxLength = 2;
            this.Alarm2MinuteTextBox.Name = "Alarm2MinuteTextBox";
            this.Alarm2MinuteTextBox.Size = new System.Drawing.Size(108, 23);
            this.Alarm2MinuteTextBox.TabIndex = 3;
            this.Alarm2MinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alarm2MinuteTextBox_KeyPress);
            // 
            // Alarm2HourTextBox
            // 
            this.Alarm2HourTextBox.Location = new System.Drawing.Point(101, 37);
            this.Alarm2HourTextBox.MaxLength = 2;
            this.Alarm2HourTextBox.Name = "Alarm2HourTextBox";
            this.Alarm2HourTextBox.Size = new System.Drawing.Size(108, 23);
            this.Alarm2HourTextBox.TabIndex = 2;
            this.Alarm2HourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alarm2HourTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Set minutes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Set hour:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 545);
            this.Controls.Add(this.Alarm2GroupBox);
            this.Controls.Add(this.AlarmGroupBox);
            this.Controls.Add(this.ClockGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ClockGroupBox.ResumeLayout(false);
            this.ClockGroupBox.PerformLayout();
            this.AlarmGroupBox.ResumeLayout(false);
            this.AlarmGroupBox.PerformLayout();
            this.Alarm2GroupBox.ResumeLayout(false);
            this.Alarm2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClockGroupBox;
        private System.Windows.Forms.GroupBox AlarmGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClockMinuteTextBox;
        private System.Windows.Forms.TextBox ClockHourTextBox;
        private System.Windows.Forms.Button ClockBtn;
        private System.Windows.Forms.Label AlarmSetHourLabel;
        private System.Windows.Forms.TextBox AlarmHourTextBox;
        private System.Windows.Forms.TextBox AlarmMinuteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Alarm1Btn;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.GroupBox Alarm2GroupBox;
        private System.Windows.Forms.TextBox Alarm2MinuteTextBox;
        private System.Windows.Forms.TextBox Alarm2HourTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Alarm2Btn;
    }
}

