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
    public partial class FRM_M14_GuessShow : Form
    {
        public FRM_M14_GuessShow() //1
        {
            InitializeComponent();
        }

        FRM_M14_Guess fr2;
        public int answer;

        

        //class Guess
        //{
        //    public int Num { get; set; }

        //    public delegate void GuessDelegate(Guess number);
        //    public event GuessDelegate NumberSelected;

        //    public Guess (int num)
        //    {
        //        Num = num;
        //    }
        //}

        private void BTN_Enter_Click(object sender, EventArgs e)
        {
            fr2.Show_FRM_M14_GuessShow_data(TXT_Number.Text);

            //FRM_M14_Guess form2 = new FRM_M14_Guess(answer);

            //int num= Convert.ToInt32(TXT_Number.Text);
            //NumberSelected?.Invoke(NumberGuess);
        }

        private void FRM_M14_GuessShow_Load(object sender, EventArgs e)
        {
            fr2=new FRM_M14_Guess();
           fr2.Show();
        }
        //FRM_M14_Guess secondForm = new FRM_M14_Guess();
        //secondForm.ReceiveNumber(NumberGuess);
        //secondForm.Show();


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


    }
}
