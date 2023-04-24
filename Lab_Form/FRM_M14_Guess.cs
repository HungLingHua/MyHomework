using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class FRM_M14_Guess : Form //2
    {
        public FRM_M14_Guess()
        {
            InitializeComponent();
            //this.answer = answer;
        }

        public int answer;

        public void Show_FRM_M14_GuessShow_data(string data)
        {
            LAB_Answer.Text = data;
        }




        //public void NumGuess(int number)
        //{
        //    LAB_String.Text = "The number to guess is: " + number;
        //}

        //public void ReceiveNumber(int  number)
        //{
        //    LAB_String.Text = $"您猜的數字是:{number},\r\n";
        //string result = "";
        //int Number = Convert.ToInt32(TXT_Number.Text);
        //Number = 0;
        //Random random = new Random();
        //int Guessnum = random.Next(1, 100);


        //    while (Number != Guessnum)
        //    {
        //        Number = Convert.ToInt32(Console.ReadLine());


        //        if (Number < Guessnum)
        //        {
        //        result=$"Too Small！Between {Number} and {Guessnum}";

        //        }
        //        else if (Number > Guessnum)
        //        {
        //        result = $"Too Large！Between {Guessnum} and {Number}";
        //    }
        //        else
        //        {
        //        result = $"恭喜您猜對了！";
        //        }
        //    }
        //}

        private void BTN_Guess_Click(object sender, EventArgs e)  
        {
            FRM_M14_GuessShow frm=new FRM_M14_GuessShow();  //連結guessshow form
            frm.ShowDialog();
        }

        private void BTN_Show_Click(object sender, EventArgs e)  

        {
            List<int>chosnNumber= new List<int>();
            Random rand=new Random();
            while (chosnNumber.Count<1)
            {
                int randomNumber=rand.Next(1,100);
                chosnNumber.Add(randomNumber);
                MessageBox.Show("Answer:"+randomNumber);
            }
        }

        //private void FRM_M14_Guess_Load(object sender, EventArgs e)
        //{
        //    LAB_Answer.Text = "The answer is: " + answer;
        //}
    }
}
