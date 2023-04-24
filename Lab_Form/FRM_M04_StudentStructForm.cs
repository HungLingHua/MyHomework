using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class FRM_M04_StudentStructForm : Form
    {
        public FRM_M04_StudentStructForm()
        {
            InitializeComponent();
            BTN_Show.Enabled = false;
        }
        List<string> StudentData = new List<string>();
       public struct Score
        {
            public string Name;
            public int ChineseScore;
            public int EnglishScore;
            public int MathScore;
        }
        Score Scores= new Score();
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            Scores.Name = TXT_Name.Text;
            Scores.ChineseScore = int.Parse(TXT_Chinese.Text);
            Scores.EnglishScore = int.Parse(TXT_English.Text);
            Scores.MathScore = int.Parse(TXT_Math.Text);
            MessageBox.Show("儲存成功!");
            BTN_Show.Enabled = true;

            //string data = string.Format("姓名:{0}\n,國文:{1}\n,英文:{2}\n,數學:{3}", Name, ChineseScore, EnglishScore, MathScore);
            //StudentData.Add(data);

            string data = $" 姓名:{Scores.Name}\n 國文:{Scores.ChineseScore}分\n 英文:{Scores.EnglishScore}分\n 數學:{Scores.MathScore}分";


            //TXT_Name.Clear();
            //TXT_Chinese.Clear();
            //TXT_English.Clear();
            //TXT_Math.Clear();

            //LSB_Score.Items.Add(Item);
            //SaveScore = $" 姓名:{TXT_Name.Text}\n 國文:{TXT_Chinese.Text}分\n 英文:{TXT_English.Text}分\n 數學:{TXT_Math.Text}分";

        }
        private void BTN_Show_Click(object sender, EventArgs e)
        {

            LSB_Score.Items.Clear();
            //foreach (string data in StudentData)
            //{
            //    string[] fields = data.Split(',');
            //    string Name = fields[0];
            //    //int ChineseScore, EnglishScore,MathScore;
            //    int ChineseScore = int.Parse(fields[1]);
            //    int EnglishScore = int.Parse(fields[2]);
            //    int MathScore = int.Parse(fields[3]);



            string item = $" 姓名:{Scores.Name}\r\n 國文:{Scores.ChineseScore}分\r\n 英文:{Scores.EnglishScore}分\r\n 數學:{Scores.MathScore}分";
            LSB_Score.Items.Add(item);
            //string item=string.Format("姓名:{0}\n,國文:{1}\n,英文:{2}\n,數學:{3}", Name, ChineseScore, EnglishScore, MathScore);

        }
        private void BTN_EST_Click(object sender, EventArgs e)
        {
            //LSB_est.Items.Clear();
            //int highest= Math.Max(Math.Max(int.Parse(TXT_Chinese.Text), int.Parse(TXT_English.Text)), int.Parse(TXT_Math.Text));
            //int lowest= Math.Min(Math.Min(int.Parse(TXT_Chinese.Text), int.Parse(TXT_English.Text)), int.Parse(TXT_Math.Text));
            //string item = $" 姓名:{Scores.Name}\n 國文:{Scores.ChineseScore}分\n 英文:{Scores.EnglishScore}分\n 數學:{Scores.MathScore}分";
            //string est =$"最高科目成績為:{ highest}\n最低科目成績為:{ lowest}"; // = "最高科目成績為: 89 \n最低科目成績為:60";
            //LSB_est.Items.Add(est);

            Dictionary<string, int> dic = new Dictionary<string, int>() 
            {
                { "國文", Convert.ToInt32(TXT_Chinese.Text)}, 
                {"英文",Convert.ToInt32(TXT_English.Text)}, 
                {"數學",Convert.ToInt32(TXT_Math.Text)}
            };
            //foreach(KeyValuePair<string, int> item in dic)
            //{
            //    MessageBox.Show("Current Key: " + item.Key + "\r\n" +
            //        "Current Value: " + item.Value);
            //}
            //-->Max
            var maxValueKey = dic.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            var maxValue = dic.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
            //-->Max
            //-->Min
            var minValueKey = dic.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            var minValue = dic.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
            //-->Min

           //MessageBox.Show( "最高科目成績為: " + maxValueKey + maxValue + "分\r\n" +
           //      "最低科目成績為: " + minValueKey + minValue + "分\r\n");
            TXT_Show.Text = "最高科目成績為: " + maxValueKey + maxValue + "分\r\n" +
                 "最低科目成績為: " + minValueKey + minValue + "分\r\n";
        }
    }
    }

