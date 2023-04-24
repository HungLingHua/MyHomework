using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class FRM_M13_PictureViewer : Form
    {
        public FRM_M13_PictureViewer()
        {
            InitializeComponent();
        }
        private void FRM_M13_PictureViewer_Load(object sender, EventArgs e)
        {

        }

        private void pc1_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc1.Image);
            frm.Show();
        }

        private void pc2_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc2.Image);
            frm.Show();
        }

        private void pc3_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc3.Image);
            frm.Show();
        }

        private void pc4_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc4.Image);
            frm.Show();
        }

        private void pc5_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc5.Image);
            frm.Show();
        }

        private void pc6_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc6.Image);
            frm.Show();
        }

        private void pc7_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc7.Image);
            frm.Show();
        }

        private void pc8_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc8.Image);
            frm.Show();
        }

        private void pc9_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc9.Image);
            frm.Show();
        }

        private void pc10_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc10.Image);
            frm.Show();
        }

        private void pc11_Click(object sender, EventArgs e)
        {
            FRM_M13_PictureShow frm = new FRM_M13_PictureShow(pc11.Image);
            frm.Show();
        }
    }
        }
