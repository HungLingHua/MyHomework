using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class FRM_M08_ForDoWhile : Form
    {
        public FRM_M08_ForDoWhile()
        {
            InitializeComponent();
        }

        private void BTN_99_Click(object sender, EventArgs e)  //九九乘法表ok
        {
            string result = "";
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    result += $"{i:##}*{j:##}={i * j:##}｜\t";
                }
                result += Environment.NewLine;
            }
            LAB_Result.Text = result;
        }

        private void BTN_RightAngle_Click(object sender, EventArgs e) //直角聖誕樹ok
        {
            if (TXT_Rows.Text != "")
            {
                string result = "";
                int n = Convert.ToInt32(TXT_Rows.Text);  //定義聖誕樹高度
                for (int i = 0; i < n; i++)  //控制聖誕樹高度
                {
                    for (int j = 0; j <= i; j++)  //控制聖誕樹寬度
                    {
                        result += "*";

                    }
                    result += Environment.NewLine;
                }
                LAB_Result.Text = result;
            }

            else
            {
                MessageBox.Show("請輸入數值");
            }

        }

        private void BTN_Binary_Click(object sender, EventArgs e) //100的二進位ok
        {
            int number = 100;
            string binary = Convert.ToString(number, 2);
            LAB_Result.Text = binary;
        }

        private void BTN_Lottery_Click(object sender, EventArgs e) //樂透號碼不重複
        {
            List<int> chosenNumbers = new List<int>();
            Random rand = new Random();

            while (chosenNumbers.Count < 5)
            {
                int randomNumber = rand.Next(1, 50); // 產生1~49之間的隨機數字
                if (!chosenNumbers.Contains(randomNumber)) // 檢查是否已經選擇過該數字
                {
                    chosenNumbers.Add(randomNumber); // 將數字加入清單中
                }
                LAB_Result.Text = randomNumber.ToString();
            }
            foreach (int number in chosenNumbers)
            {
                LAB_Result.Text = (number + " ");
            }
        }

        private void BTN_OddEven_Click(object sender, EventArgs e)  //奇數偶數ok
        {
            //bool click = true;
            //click = LAB_Result.Text != "";
            //if "" messagebox else input 
            if (TXT_Number.Text != "")
            {
                int i = Convert.ToInt32(TXT_Number.Text);
                bool even = true;
                even = i % 2 == 0;
                string result;

                result = even ? "輸入的數" + i + "為偶數" : "輸入的數" + i + "為奇數";

                LAB_Result.Text = result;
            }

            else
            {
                MessageBox.Show("請輸入數值");
            }

            //if (i % 2 == 0)
            //    result = "輸入的數" + i + "為" + "偶數";

            //else
            //    result = "輸入的數" + i + "為" + "奇數";
        }


        private void BTN_CcHowMuch_Click(object sender, EventArgs e)  //陣列arr_str[]"C"Or"c"的字樣有幾個ok
        {
            string arrint = "mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker";
            string result;
            char c = 'c';
            char C = 'C';

            int num1 = Regex.Matches(arrint, c.ToString()).Count;
            int num2 = Regex.Matches(arrint, C.ToString()).Count;
            int num = num1 + num2;
            result = $"arr_str[]陣列：mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker\n\r" +
                $"有C及c的名字共有" + (num.ToString()) + "個";

            LAB_Result.Text = result;
        }

        private void BTN_Clear_Click(object sender, EventArgs e) //清空結果欄ok
        {
            string result = "結果";
            LAB_Result.Text = result;
        }

        private void BTN_MaxMin_Click(object sender, EventArgs e)  //最大最小值ok
        {
            string result;
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int Max = arr.Max();
            int Min = arr.Min();
            result = $"int陣列arr[1,5,6,8,7,97,54,887,65,578]\n\r" +
                $"最大值為:{Max}\n\r最小值為:{Min}";
            LAB_Result.Text = result;
        }

        private void BTN_Arr_Click(object sender, EventArgs e) //陣列arr[]統計奇偶數ok
        {
            string result;
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int evencount = 0;
            int oddcount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    oddcount++;
                else
                    evencount++;
            }
            result = $"int陣列arr[1,5,6,8,7,97,54,887,65,578]\n\r" +
                    $"奇數共{evencount}個\n\r偶數共{oddcount}個";
            LAB_Result.Text = result;

        }

        private void BTN_Longest_Click(object sender, EventArgs e) //陣列arr_str[]最長的名字ok
        {
            string result = "";
            string[] arr = new string[8] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string longestname = "";
            foreach (string name in arr)
            {
                if (name.Length > longestname.Length)
                {
                    longestname = name;
                }
            }
            result = $"arr陣列 [mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]中\n\r" +
                 $"最長的名字為:{longestname}";

            LAB_Result.Text = result;
        }

        private void BTN_Out1In0_Click(object sender, EventArgs e) //[10,10]二維陣列_邊1內0 ok
        {
            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0 || i == 9 || j == 9)
                    {
                        arr[i, j] = 1; //邊緣設為1
                    }
                    else
                    {
                        arr[i, j] = 0; //其餘設為0
                    }
                }
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += arr[i, j] + " ";
                }
                result += "\n"; //換行
            }

            LAB_Result.Text = result;
        }

        private void BTN_Out0In1_Click(object sender, EventArgs e)  //[10,10]二維陣列_邊0內1 ok
        {
            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0 || i == 9 || j == 9)
                    {
                        arr[i, j] = 0; //邊緣設為0
                    }
                    else
                    {
                        arr[i, j] = 1; //其餘設為1
                    }
                }
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += arr[i, j] + " ";
                }
                result += "\n";
            }

            LAB_Result.Text = result;
        }

        private void BTN_1010_Click(object sender, EventArgs e)  //[10,10]二維陣列
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += arr[i, j] + " ";
                }
                result += "\n";
            }

            LAB_Result.Text = result;
        }

        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        private void BTN_Swap_Click(object sender, EventArgs e) //Swap[int,int] ok
        {
            int n1 = 100;
            int n2 = 200;
            string result1 = $"換位前n1={n1}, n2={n2}";
            Swap(ref n1, ref n2);
            string result2 = $"換位後n1={n1}, n2={n2}";

            LAB_Result.Text = result1 + "\n\r" + result2;
        }

        private void BTN_Sum_Click(object sender, EventArgs e) //Sum(陣列arr[]) ok
        {
            string result;
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            result = $"int陣列arr[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n\r加總為:{sum}";
            LAB_Result.Text = result;
        }

        private void BTN_Max_Click(object sender, EventArgs e)  //Max(陣列arr[])
        {
            string result;
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int Max = arr.Max();
            result = $"int陣列arr[1,5,6,8,7,97,54,887,65,578]\n\r最大值為:{Max}";
            LAB_Result.Text = result;
        }


        private void BTN_Min_Click(object sender, EventArgs e)  //Min(陣列arr[])
        {
            string result;
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int Min = arr.Min();
            result = $"int陣列arr[1,5,6,8,7,97,54,887,65,578]\n\r最大值為:{Min}";
            LAB_Result.Text = result;
        }


        private void BTN_For_Click(object sender, EventArgs e) //for迴圈
        {
                string result;
                int From = Convert.ToInt32(TXT_From.Text);
                int To = Convert.ToInt32(TXT_To.Text);
                int Step = Convert.ToInt32(TXT_Step.Text);
                int sum = 0;

                for (int i = From; i < To; Step = i++)
                {
                    sum += i++;
                    result = From + "到" + To + "相隔" + (Step - 1) + "\n\r" + "加總為" + sum;
                    LAB_Result.Text = result;
                }
            }

        private void BTN_While_Click(object sender, EventArgs e)  //while迴圈
        {
            string result;
            int From = Convert.ToInt32(TXT_From.Text);
            int To = Convert.ToInt32(TXT_To.Text);
            int Step = Convert.ToInt32(TXT_Step.Text);
            int sum = 0;
            int i = From;

            while (i<= To)
            {
                sum += i;
                i += Step;
                result = From + "到" + To + "相隔" + (Step - 1) + "\n\r" + "加總為" + sum;
                LAB_Result.Text = result;
            }
        }

        private void BTN_Do_Click(object sender, EventArgs e)  //do迴圈
        {
            string result;
            int From = Convert.ToInt32(TXT_From.Text);
            int To = Convert.ToInt32(TXT_To.Text);
            int Step = Convert.ToInt32(TXT_Step.Text);
            int sum = 0;
            int i = From;

            do
            {
                sum += i;
                i += Step;
            }
            while (i <= To);
            {
                result = From + "到" + To + "相隔" + (Step - 1) + "\n\r" + "加總為" + sum;
                LAB_Result.Text = result;
            }
        }
    }
}

