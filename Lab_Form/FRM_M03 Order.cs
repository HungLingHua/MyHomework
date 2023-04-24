using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class FRM_M03_Order : Form
    {
        public FRM_M03_Order()
        {
            InitializeComponent();
        }

         public int Beer_Price = 120;
         public int Tequila_Price = 180;
         public int Whisky_Price = 350;
         public int Wine_Price = 320;

        public int Beer_Count = 0;
        public int Tequila_Count = 0;
        public int Whisky_Count = 0;
        public int Wine_Count = 0;
        private void BTN_Beer_Click(object sender, EventArgs e)
        {
            string Beer = "啤酒Beer";
            
            Beer_Count = Beer_Count+1;

            LAB_List.Text += $"\n{Beer}x{Beer_Count},共NT${Beer_Price*Beer_Count}元";
            LAB_Price.Text = $"NT${Beer_Price * Beer_Count + Tequila_Price * Tequila_Count + Whisky_Price * Whisky_Count + Wine_Price * Wine_Count}元";

        }

        private void BTN_Tequila_Click(object sender, EventArgs e)
        {
            string Tequila = "龍舌蘭Tequila";
           Tequila_Count = Tequila_Count + 1;

            LAB_List.Text += $"\n{Tequila}x{Tequila_Count},共NT${Tequila_Price}元";
            LAB_Price.Text = $"NT${Beer_Price * Beer_Count + Tequila_Price * Tequila_Count + Whisky_Price * Whisky_Count + Wine_Price * Wine_Count}元";

        }

        private void BTN_Whisky_Click(object sender, EventArgs e)
        {
            string Whisky = "威士忌Whisky";
            Whisky_Count = Whisky_Count+1;

            LAB_List.Text += $"\n{Whisky}x{Whisky_Count},共NT${Whisky_Price}元";
            LAB_Price.Text = $"NT${Beer_Price * Beer_Count + Tequila_Price * Tequila_Count + Whisky_Price * Whisky_Count + Wine_Price * Wine_Count}元";

        }

        private void BTN_Wine_Click(object sender, EventArgs e)
        {
            string Wine = "紅酒Wine";
            Wine_Count = Wine_Count+1;

            LAB_List.Text += $"\n{Wine}x{Wine_Count},共NT${Wine_Price}元";
            LAB_Price.Text = $"NT${Beer_Price * Beer_Count + Tequila_Price * Tequila_Count + Whisky_Price * Whisky_Count + Wine_Price * Wine_Count}元";

        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            Beer_Count = 0;
            Tequila_Count = 0;
            Whisky_Count=0;
            Wine_Count=0;
            LAB_Price.Text = $"NT${Beer_Price * Beer_Count*0 + Tequila_Price * Tequila_Count*0 + Whisky_Price * Whisky_Count*0 + Wine_Price * Wine_Count*0}元";
            LAB_List.Text= String.Empty;

        }

        private void BTN_Cash_Click(object sender, EventArgs e)
        {
            LAB_Price.Text = $"NT${Beer_Price * Beer_Count + Tequila_Price * Tequila_Count + Whisky_Price * Whisky_Count + Wine_Price * Wine_Count}元";
            MessageBox.Show("總金額:"+(LAB_Price.Text),"確認付款",MessageBoxButtons.YesNo) ;
        }

        private void BTN_CDC_Click(object sender, EventArgs e)
        {
            LAB_Price.Text = $"NT${Beer_Price * Beer_Count + Tequila_Price * Tequila_Count + Whisky_Price * Whisky_Count + Wine_Price * Wine_Count}元";
            string discount;
            discount= $"NT${Beer_Price * Beer_Count*0.9 + Tequila_Price * Tequila_Count*0.9 + Whisky_Price * Whisky_Count*0.9 + Wine_Price * Wine_Count*0.9}元";

            MessageBox.Show("總金額:" + (LAB_Price.Text)+"\n"+"折扣後金額:"+(discount), "確認付款", MessageBoxButtons.YesNo);
        }
    }
}
