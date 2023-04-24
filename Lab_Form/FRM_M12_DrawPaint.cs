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
using static System.Windows.Forms.AxHost;

namespace Lab_Form
{
    public partial class FRM_M12_DrawPaint : Form
    {
        public FRM_M12_DrawPaint()
        {
            InitializeComponent();
        }


        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g =Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void FRM_M12_DrawPaint_Load(object sender, EventArgs e)
        {
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            this.Cursor = Cursors.Cross;
        }

        int x0, y0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(penColor,penWidth);
                g.DrawLine(p, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0=e.Y;
                pictureBox1.Refresh();
            }
        }

         Color penColor = Color.Black;
         int penWidth = 3;
        private void BTN_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penColor = colorDialog.Color;
                PC_Color.BackColor = colorDialog.Color;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penWidth = trackBar1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            LAB_Num.Text = ""+0;
            LAB_Num.Text = trackBar1.Value.ToString();
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
            Pen p = new Pen(penColor, penWidth); // 使用設定的顏色和粗細
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.DrawLine(p, x0, y0, x0, y0); // 畫一個點以便後續的畫線可以連接

        }
    }
}
