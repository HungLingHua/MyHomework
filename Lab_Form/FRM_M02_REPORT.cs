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
    public partial class FRM_M02_REPORT : Form
    {
        public FRM_M02_REPORT()
        {
            InitializeComponent();
        }

        public string LAB_Total;
        public string LAB_Year;
        public string LAB_Monthrate;
        public string LAB_pay;
        public string LAB_total;

        private void FRM_M02_REPORT_Load(object sender, EventArgs e)
        {
            LB_1.Text = LAB_Total;
            LB_2.Text = LAB_Year;
            LB_3.Text = LAB_Monthrate;
            LB_4.Text = LAB_pay;
            LB_5.Text = LAB_total;
        }
    }
}

  
      

