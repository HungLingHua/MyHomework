using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class FRM_貸款金額計算 : Form
    {
       

        public FRM_貸款金額計算()
        {
            InitializeComponent();
        }
        //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
        // (公式中：月利率 ＝ 年利率／12 ； 月數=貸款年期 ｘ 12)
        //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率
        //＝每月應還本金金額＋每月應付利息金額
        private void BTN_月付_Click(object sender, EventArgs e)
        {

            
            double FirstPay = double.Parse(TXT_to.Text);  // 頭期款
            double MonthRate = (double.Parse(TXT_li.Text) / 12) / 100;  //月利率
            double Year = double.Parse(TXT_qi.Text) * 12; //c=月數
            double Total = double.Parse(TXT_dai.Text); //d=貸款本金

            {
            double money= Math.Pow(( 1+MonthRate), Year) * MonthRate / (Math.Pow((1 + MonthRate), Year) - 1);
            double pay = Math.Round(money * Total);
             MessageBox.Show("月付額：" + pay + "元");
            }
            
        }

        private void BTN_總付款_Click(object sender, EventArgs e)
        {
            double FirstPay = double.Parse(TXT_to.Text);  // 頭期款
            double MonthRate = (double.Parse(TXT_li.Text) / 12) / 100;  //月利率
            double Year = double.Parse(TXT_qi.Text) * 12; //c=月數
            double Total = double.Parse(TXT_dai.Text); //d=貸款本金
            double money = Math.Pow((1 + MonthRate), Year) * MonthRate / (Math.Pow((1 + MonthRate), Year) - 1);
            double pay = Math.Round(money * Total);
            double total = pay * Year;
            MessageBox.Show("總付款：" + total + "元");
        }

        private void BTN_REPORT_Click(object sender, EventArgs e)
        {
            FRM_M02_REPORT frm = new FRM_M02_REPORT();
            double FirstPay = double.Parse(TXT_to.Text);  // 頭期款
            double MonthRate = (double.Parse(TXT_li.Text) / 12) / 100;  //月利率
            double Year = double.Parse(TXT_qi.Text) * 12; //c=月數
            double Total = double.Parse(TXT_dai.Text); //d=貸款本金
            double money = Math.Pow((1 + MonthRate), Year) * MonthRate / (Math.Pow((1 + MonthRate), Year) - 1);
            double pay = Math.Round(money * Total);
            double total = pay * Year;
            frm.LAB_Total = TXT_dai.Text;
            frm.LAB_Year = TXT_li.Text;
            frm.LAB_Monthrate = TXT_qi.Text;
            frm.LAB_pay = Convert.ToString(pay);
            frm.LAB_total=Convert.ToString(total);
            frm.Show();

        }
    }
    }

