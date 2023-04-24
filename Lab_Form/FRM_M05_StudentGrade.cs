using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class FRM_M05_StudentGrade : Form
    {
        public FRM_M05_StudentGrade()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            string name = TXT_Name.Text;
            int chinese = int.Parse(TXT_Chinese.Text);
            int english = int.Parse(TXT_English.Text);
            int math = int.Parse(TXT_Math.Text);
            int total = chinese + english + math;
            double average = total / 3.0;
            int max = Math.Max(chinese, Math.Max(english, math));
            int min = Math.Min(chinese, Math.Min(english, math));

            // 創建新的 ListViewItem 對象
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(chinese.ToString());
            item.SubItems.Add(english.ToString());
            item.SubItems.Add(math.ToString());
            item.SubItems.Add(total.ToString());
            item.SubItems.Add(average.ToString("F2"));

            string maxSubject = "";
            string minSubject = "";
            if (max == chinese) maxSubject = "國文";
            else if (max == english) maxSubject = "英文";
            else if (max == math) maxSubject = "數學";
            if (min == chinese) minSubject = "國文";
            else if (min == english) minSubject = "英文";
            else if (min == math) minSubject = "數學";

            item.SubItems.Add($"{maxSubject} {max}");
            item.SubItems.Add($"{minSubject} {min}");

            // 將 ListViewItem 對象添加到 ListView 控件中
            LSV_Score.Items.Add(item);
            BTN_Total.Enabled = true;
        }

        private void BTN_Rand_Click(object sender, EventArgs e)
        {
            // 建立隨機數生成器
            Random rand = new Random();

            // 產生隨機資料
            int id = 1;
            int chinese = rand.Next(0, 101);
            int english = rand.Next(0, 101);
            int math = rand.Next(0, 101);
            int total = chinese + english + math;
            double average = total / 3.0;
            int[] scores = new int[] { chinese, english, math };
            int max = scores.Max();
            int min = scores.Min();

            // 新增資料至ListView
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(chinese.ToString());
            item.SubItems.Add(english.ToString());
            item.SubItems.Add(math.ToString());
            item.SubItems.Add(total.ToString());
            item.SubItems.Add(average.ToString("f2"));

            string maxSubject = "";
            string minSubject = "";
            if (max == chinese) maxSubject = "國文";
            else if (max == english) maxSubject = "英文";
            else if (max == math) maxSubject = "數學";
            if (min == chinese) minSubject = "國文";
            else if (min == english) minSubject = "英文";
            else if (min == math) minSubject = "數學";

            item.SubItems.Add($"{maxSubject} {max}");
            item.SubItems.Add($"{minSubject} {min}");
            LSV_Score.Items.Add(item);

            id++;
            BTN_Total.Enabled = true;
        }

        private void BTN_Total_Click(object sender, EventArgs e)
        {
            // 宣告變數
            int chineseTotal = 0, englishTotal = 0, mathTotal = 0;
            int chineseCount = 0, englishCount = 0, mathCount = 0;
            int chineseMax = 0, englishMax = 0, mathMax = 0;
            int chineseMin = 0, englishMin = 0, mathMin = 0;

            // 計算各科總分、各科平均和最高分最低分
            foreach (ListViewItem item in LSV_Score.Items)
            {
                int chinese = int.Parse(item.SubItems[1].Text);
                int english = int.Parse(item.SubItems[2].Text);
                int math = int.Parse(item.SubItems[3].Text);

                // 計算各科總分
                chineseTotal += chinese;
                englishTotal += english;
                mathTotal += math;

                // 計算各科最高分
                if (chinese > chineseMax) chineseMax = chinese;
                if (english > englishMax) englishMax = english;
                if (math > mathMax) mathMax = math;

                // 計算各科最低分
                if (chinese < chineseMin) chineseMin = chinese;
                if (english < englishMin) englishMin = english;
                if (math < mathMin) mathMin = math;

                // 計算各科成績人數
                if (chinese > 0) chineseCount++;
                if (english > 0) englishCount++;
                if (math > 0) mathCount++;
            }

            // 計算各科平均分
            double chineseAverage = chineseTotal / (double)chineseCount;
            double englishAverage = englishTotal / (double)englishCount;
            double mathAverage = mathTotal / (double)mathCount;

            // 將各科總分、各科平均和最高分新增至另一個ListView控制元件中
            ListViewItem totalItem = new ListViewItem("總分");
            totalItem.SubItems.Add(chineseTotal.ToString());
            totalItem.SubItems.Add(englishTotal.ToString());
            totalItem.SubItems.Add(mathTotal.ToString());
            LSV_Est.Items.Add(totalItem);

            ListViewItem averageItem = new ListViewItem("平均");
            averageItem.SubItems.Add(chineseAverage.ToString("f2"));
            averageItem.SubItems.Add(englishAverage.ToString("f2"));
            averageItem.SubItems.Add(mathAverage.ToString("f2"));
            LSV_Est.Items.Add(averageItem);

            ListViewItem maxItem = new ListViewItem("最高分");
            maxItem.SubItems.Add(chineseMax.ToString());
            maxItem.SubItems.Add(englishMax.ToString());
            maxItem.SubItems.Add(mathMax.ToString());
            LSV_Est.Items.Add(maxItem);

            ListViewItem minItem = new ListViewItem("最低分");
            minItem.SubItems.Add(chineseMin.ToString());
            minItem.SubItems.Add(englishMin.ToString());
            minItem.SubItems.Add(mathMin.ToString());
            LSV_Est.Items.Add(minItem);

            BTN_Add.Enabled = false;
            BTN_Rand.Enabled = false;
            BTN_Total.Enabled = false;
            BTN_Rand20.Enabled = false;

        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            // 清空第一個ListView控制元件
            LSV_Score.Items.Clear();

            // 清空第二個ListView控制元件
            LSV_Est.Items.Clear();

            BTN_Add.Enabled = true;
            BTN_Rand.Enabled = true;
            BTN_Rand20.Enabled = true;

        }

        private void BTN_Rand20_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int chineseMax = 0, englishMax = 0, mathMax = 0;
            int chineseMin = 100, englishMin = 100, mathMin = 100;

            // 產生20筆隨機成績資料
            for (int i = 0; i < 20; i++)
            {
                int id = i + 1;
                int chinese = rnd.Next(0, 101);
                int english = rnd.Next(0, 101);
                int math = rnd.Next(0, 101);
                int total = chinese + english + math;
                double average = total / 3.0;

                // 計算各科最高分和最低分
                if (chinese > chineseMax) chineseMax = chinese;
                if (english > englishMax) englishMax = english;
                if (math > mathMax) mathMax = math;
                if (chinese < chineseMin) chineseMin = chinese;
                if (english < englishMin) englishMin = english;
                if (math < mathMin) mathMin = math;

                // 新增成績資料到Listview中
                ListViewItem item = new ListViewItem(new string[] {
            id.ToString(), chinese.ToString(), english.ToString(), math.ToString(),
            total.ToString(), average.ToString("F1"), chineseMax.ToString(), chineseMin.ToString(),
            englishMax.ToString(), englishMin.ToString(), mathMax.ToString(), mathMin.ToString()
        });
                LSV_Score.Items.Add(item);
                BTN_Total.Enabled = true;
            }
        }
    }
}
