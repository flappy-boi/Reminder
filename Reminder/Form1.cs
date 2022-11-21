using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Reminder
{
    public partial class Reminder : Form
    {
        bool Pause = false;
        bool MAN = false;
        string csvfile = "";
        public Reminder() { InitializeComponent(); }
        private void Reminder_Load(object sender, EventArgs e) { int y = Screen.PrimaryScreen.Bounds.Bottom - 70; Location = new Point(0, y); Clock.Start(); }
        private void Clock_Tick(object sender, EventArgs e) { Line0.Text = DateTime.Now.ToString("HH:mm:ss"); }
        private void Line0_MouseEnter(object sender, EventArgs e) { Line0.BackColor = SystemColors.Desktop; }
        private void Line0_MouseLeave(object sender, EventArgs e) { Line0.BackColor = Color.Transparent; }
        private void Line1_MouseEnter(object sender, EventArgs e) { Line1.BackColor = Color.Black; if (MAN) { Line1.ForeColor = Color.White; Line1.Text = "Set Auto"; } else { Line1.Text = "Set Manual"; } }
        private void Line1_Click(object sender, EventArgs e)
        {
            if (MAN) { MAN = false; Line1.ForeColor = Color.White; }
            else
            {
                MAN = true;
                Line1.Text = " Function ";
                Line2.Text = " Disabled ";
            }
        }
        private void Line1_MouseLeave(object sender, EventArgs e) { Line1.BackColor = SystemColors.Desktop; Line1.Text = ""; if (MAN) { Line1.Text = " Function "; } }
        private void Line2_MouseEnter(object sender, EventArgs e) { Line2.ForeColor = Color.White; Line2.BackColor = Color.Black; if (Pause) { Line2.Text = "Start/Exit"; } else { Line2.Text = "Pause/Exit"; } }
        private void Line2_Click(object sender, EventArgs e) { if (Pause) { Pause = false; Timer.Start(); } else { Pause = true; Timer.Stop(); Line1.Text = ""; } }
        private void Line2_DoubleClick(object sender, EventArgs e) { Application.Exit(); }
        private void Line2_MouseLeave(object sender, EventArgs e) { Line2.Text = ""; Line2.BackColor = SystemColors.Desktop; if (MAN) { Line2.Text = " Disabled "; } }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (MAN) { }
            else
            {
                var DAY = DateTime.Today.DayOfWeek;
                double NOW = DateTime.Now.TimeOfDay.TotalMinutes;
                if (DAY == DayOfWeek.Monday) { csvfile = @"data\1.csv"; }
                else if (DAY == DayOfWeek.Tuesday) { csvfile = @"data\2.csv"; }
                else if (DAY == DayOfWeek.Wednesday) { csvfile = @"data\3.csv"; }
                else if (DAY == DayOfWeek.Thursday) { csvfile = @"data\4.csv"; }
                else if (DAY == DayOfWeek.Friday) { csvfile = @"data\5.csv"; }
                else if (DAY == DayOfWeek.Saturday) { csvfile = @"data\6.csv"; }
                else { csvfile = @"data\0.csv"; }
                string[] lines = File.ReadAllText(csvfile).Split('\n');
                int i = 0;
                int time = Convert.ToInt32(lines[i].Split(',')[0]);
                while (time < NOW) { i++; time = Convert.ToInt32(lines[i].Split(',')[0]); }
                double remain = NOW - time;
                // Display
                if (remain >= -5) { Line0.ForeColor = Color.Lime; }
                else if (remain >= -6) { Line0.ForeColor = Color.Orange; }
                else { Line0.ForeColor = Color.White; }
                if (Line1.Text != "Set Manual") { Line1.Text = lines[i].Split(',')[1]; }
                if (Line2.Text != "Pause/Exit" && Line2.Text != "Start/Exit")
                {
                    Line2.Text = remain.ToString("0.00");
                    if (time == 1440) { Line2.ForeColor = SystemColors.Desktop; }
                    else { Line2.ForeColor = Color.White; Line2.Text = remain.ToString("0.00"); }
                }
            }
        }
    }
}