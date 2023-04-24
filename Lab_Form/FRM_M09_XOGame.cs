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
    public partial class FRM_M09_XOGame : Form
    {
        //public char
        public FRM_M09_XOGame()
        {
            InitializeComponent();
        }
        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            C1.Text = string.Empty;
            C1.Enabled = true;
            C2.Text = string.Empty;
            C2.Enabled = true;
            C3.Text = string.Empty;
            C3.Enabled = true;
            C4.Text = string.Empty;
            C4.Enabled = true;
            C5.Text = string.Empty;
            C5.Enabled = true;
            C6.Text = string.Empty;
            C6.Enabled = true;
            C7.Text = string.Empty;
            C7.Enabled = true;
            C8.Text = string.Empty;
            C8.Enabled = true;
            C9.Text = string.Empty;
            C9.Enabled = true;
        }
        bool T = false;
        private void C1_Click(object sender, EventArgs e)
        {
            if (T)
                C1.Text = "X";
            else
                C1.Text = "O";
            T = !T;

            C1.Enabled = false;
            judge();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (T)
                C2.Text = "X";
            else
                C2.Text = "O";
            T = !T;

            C2.Enabled = false;
            judge();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (T)
                C3.Text = "X";
            else
                C3.Text = "O";
            T = !T;

            C3.Enabled = false;
            judge();
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (T)
                C4.Text = "X";
            else
                C4.Text = "O";
            T = !T;

            C4.Enabled = false;
            judge();
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (T)
                C5.Text = "X";
            else
                C5.Text = "O";
            T = !T;

            C5.Enabled = false;
            judge();
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (T)
                C6.Text = "X";
            else
                C6.Text = "O";
            T = !T;

            C6.Enabled = false;
            judge();
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (T)
                C7.Text = "X";
            else
                C7.Text = "O";
            T = !T;

            C7.Enabled = false;
            judge();
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (T)
                C8.Text = "X";
            else
                C8.Text = "O";
            T = !T;

            C8.Enabled = false;
            judge();
        }

        private void C9_Click(object sender, EventArgs e)
        {
            if (T)
                C9.Text = "X";
            else
                C9.Text = "O";
            T = !T;

            C9.Enabled = false;
            judge();
        }

        private void judge()
        {
            if(C1.Text==C2.Text && C2.Text==C3.Text && C1.Text == "X")
            {
                MessageBox.Show("X手獲勝!","完局!",MessageBoxButtons.OK);
            }
            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C4.Text == C5.Text && C5.Text == C6.Text && C4.Text == "X")
            {
                MessageBox.Show("X手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C4.Text == C5.Text && C5.Text == C6.Text && C4.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C7.Text == C8.Text && C8.Text == C9.Text && C7.Text == "X")
            {
                MessageBox.Show("X手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C7.Text == C8.Text && C8.Text == C9.Text && C7.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C1.Text == C4.Text && C4.Text == C7.Text && C1.Text == "X")
            {
                MessageBox.Show("X手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C1.Text == C4.Text && C4.Text == C7.Text && C1.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C2.Text == C5.Text && C5.Text == C8.Text && C2.Text == "X")
            {
                MessageBox.Show("X手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C2.Text == C5.Text && C5.Text == C8.Text && C2.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C3.Text == C6.Text && C6.Text == C9.Text && C3.Text == "X")
            {
                MessageBox.Show("X手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C3.Text == C6.Text && C6.Text == C9.Text && C3.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }


            if (C1.Text == C5.Text && C5.Text == C9.Text && C1.Text == "X") //斜的
            {
                MessageBox.Show("X手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C1.Text == C5.Text && C5.Text == C9.Text && C1.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C3.Text == C5.Text && C5.Text == C7.Text && C3.Text == "X")
            {
                MessageBox.Show("X手獲勝!", "完局!", MessageBoxButtons.OK);
            }
            if (C3.Text == C5.Text && C5.Text == C7.Text && C3.Text == "O")
            {
                MessageBox.Show("O手獲勝!", "完局!", MessageBoxButtons.OK);
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
