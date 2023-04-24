using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Form
{
    public partial class FRM_M15_Alarm : Form
    {
        public FRM_M15_Alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LAB_Time.Text = DateTime.Now.ToString();
            Time_Now.Start();
        }

        private void BTN_Set_Click(object sender, EventArgs e)
        {
            int hours = (int)NUD1.Value;
            int minutes = (int)NUD2.Value;
            int seconds = (int)NUD3.Value;

            TimeSpan timeToAlarm = new TimeSpan(hours, minutes, seconds);
            Time_Alarm.Interval = (int)timeToAlarm.TotalMilliseconds;
            Time_Alarm.Enabled = true;
        }

        private void Time_Alarm_Tick(object sender, EventArgs e)
        {
            Time_Alarm.Enabled = false;
            MessageBox.Show("時間到了！", "鬧鐘提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
