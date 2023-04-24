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
    public partial class FRM_M07_Clac : Form
    {
        public FRM_M07_Clac()
        {
            InitializeComponent();
            TXT_Answer.Enabled = false;
        }
        public struct Number
        {
            public int Num1;
            public int Num2;
        }
        Number num=new Number();

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            num.Num1 = Convert.ToInt32(TXT_Num1.Text);
            num.Num2= Convert.ToInt32(TXT_Num2.Text);
            TXT_Answer.Text=( num.Num1+ num.Num2).ToString();
        }

        private void BTN_Subtract_Click(object sender, EventArgs e)
        {
            num.Num1 = Convert.ToInt32(TXT_Num1.Text);
            num.Num2 = Convert.ToInt32(TXT_Num2.Text);
            TXT_Answer.Text = (num.Num1 - num.Num2).ToString();
        }

        private void BTN_Multiply_Click(object sender, EventArgs e)
        {
            num.Num1 = Convert.ToInt32(TXT_Num1.Text);
            num.Num2 = Convert.ToInt32(TXT_Num2.Text);
            TXT_Answer.Text = (num.Num1 * num.Num2).ToString();
        }

        private void BTN_Divided_Click(object sender, EventArgs e)
        {
            num.Num1 = Convert.ToInt32(TXT_Num1.Text);
            num.Num2 = Convert.ToInt32(TXT_Num2.Text);
            TXT_Answer.Text = (num.Num1 / num.Num2).ToString();
        }
    }
}
