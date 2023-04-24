using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class FRM_M10_ScreenSaver : Form
    {
        public FRM_M10_ScreenSaver()
        {
            InitializeComponent();
        }

        private void FRM_M10_ScreenSaver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Random R = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox.Left -= 5;
            if (PictureBox.Right < 0)
            {
                PictureBox.Left = this.ClientSize.Width;
                PictureBox.Top = R.Next(this.Height - PictureBox.Height);
            }
        }

        private void FRM_M10_ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        }
    }
