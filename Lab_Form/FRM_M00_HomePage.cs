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
    public partial class FRM_M00_HomePage : Form
    {
        public FRM_M00_HomePage()
        {
            InitializeComponent();
        }

        private void BTN_HelloForm_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M01_HelloForm HelloForm = new FRM_M01_HelloForm();
            HelloForm.TopLevel = false;
            HelloForm.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(HelloForm);
            HelloForm.Show();
        }

        private void BTN_Loan_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_貸款金額計算 Loan = new FRM_貸款金額計算();
            Loan.TopLevel = false;
            Loan.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(Loan);
            Loan.Show();
        }

        private void BTN_Orders_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M03_Order Order = new FRM_M03_Order();
            Order.TopLevel = false;
            Order.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(Order);
            Order.Show();
        }

        private void BTN_StudentStructForm_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M04_StudentStructForm Struct = new FRM_M04_StudentStructForm();
            Struct.TopLevel = false;
            Struct.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(Struct);
            Struct.Show();
        }

        private void BTN_StudentGrade_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M05_StudentGrade StudentGrade = new FRM_M05_StudentGrade();
            StudentGrade.TopLevel = false;
            StudentGrade.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(StudentGrade);
            StudentGrade.Show();
        }

        private void BTN_StudentGradeList_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M06_StudentGradeList StudentList = new FRM_M06_StudentGradeList();
            StudentList.TopLevel = false;
            StudentList.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(StudentList);
            StudentList.Show();
        }

        private void BTN_MyClac_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M07_Clac Clac = new FRM_M07_Clac();
            Clac.TopLevel = false;
            Clac.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(Clac);
            Clac.Show();
        }

        private void BTN_ForDoWhile_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M08_ForDoWhile ForDoWhile = new FRM_M08_ForDoWhile();
            ForDoWhile.TopLevel = false;
            ForDoWhile.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(ForDoWhile);
            ForDoWhile.Show();
        }

        private void BTN_XOGame_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M09_XOGame XOGame = new FRM_M09_XOGame();
            XOGame.TopLevel = false;
            XOGame.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(XOGame);
            XOGame.Show();
        }

        private void BTN_ScreenSaver_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M10_ScreenSaver ScreenSaver= new FRM_M10_ScreenSaver();
            ScreenSaver.TopLevel = false;
            ScreenSaver.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(ScreenSaver);
            ScreenSaver.Show();
        }

        private void BTN_NotePad_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M11_NotePad NotePad = new FRM_M11_NotePad();
            NotePad.TopLevel = false;
            NotePad.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(NotePad);
            NotePad.Show();
        }

        private void BTN_DrawPaint_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M12_DrawPaint DrawPaint = new FRM_M12_DrawPaint();
            DrawPaint.TopLevel = false;
            DrawPaint.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(DrawPaint);
            DrawPaint.Show();
        }

        private void BTN_PictureViewer_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M13_PictureViewer PictureViewr = new FRM_M13_PictureViewer();
            PictureViewr.TopLevel = false;
            PictureViewr.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(PictureViewr);
            PictureViewr.Show();
        }

        private void BTN_Guess_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M14_Guess Guess = new FRM_M14_Guess();
            Guess.TopLevel = false;
            Guess.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(Guess);
            Guess.Show();
        }

        private void BTN_Alarm_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FRM_M15_Alarm Alarm = new FRM_M15_Alarm();
            Alarm.TopLevel = false;
            Alarm.Dock = DockStyle.None;
            splitContainer1.Panel2.Controls.Add(Alarm);
            Alarm.Show();
        }
    }
}
