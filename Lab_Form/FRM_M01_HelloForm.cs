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
    public partial class FRM_M01_HelloForm : Form
    {
        public FRM_M01_HelloForm()
        {
            InitializeComponent();
        }

        private void LAB_SIGN_Click(object sender, EventArgs e)
        {

        }

        private void BTN_HELLO_Click(object sender, EventArgs e)
        {
            string Name=TXT_NAME.Text;
            string EnglishName = TXT_ENGNAME.Text;
            string Sex = TXT_SEX.Text;
            string Sign = TXT_SIGN.Text;


            MessageBox.Show("Hello,我是" + Name + Environment.NewLine +
                "英文名字是" + EnglishName + Environment.NewLine + 
                "性別是" + Sex + Environment.NewLine +
                "星座是" + Sign + Environment.NewLine + Environment.NewLine +
            "很高興認識你!");
        }

        private void BTN_HI_Click(object sender, EventArgs e)
        {
            string Name = TXT_NAME.Text;
            string EnglishName = TXT_ENGNAME.Text;
            string Sex = TXT_SEX.Text;
            string Sign = TXT_SIGN.Text;

            MessageBox.Show("HI,我是" + Name + "," + 
                "\n英文名字是" + EnglishName + "," +
                "\n性別是" + Sex + ","+
                "\n星座是" + Sign + "," +
            "\n\n很高興認識你!") ;
        }
    }
}
