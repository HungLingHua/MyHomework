using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab_Form
{
    public partial class FRM_M11_NotePad : Form
    {
        public FRM_M11_NotePad()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            LB_Time.Text = DateTime.Now.ToString();
            Time.Start();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) { 
            TXT_Note.Text=File.ReadAllText(ofd.FileName,Encoding.Default);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog()== DialogResult.OK){
                File.WriteAllText(sfd.FileName, TXT_Note.Text,Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog sfd = new SaveFileDialog();
            if (ofd.FileName == "")
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName,TXT_Note.Text,Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(ofd.FileName,TXT_Note.Text,Encoding.Default);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            TXT_Note.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TXT_Note.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TXT_Note.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TXT_Note.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TXT_Note.SelectAll();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            TXT_Note.ForeColor = colorDialog1.Color;
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TXT_Note.Font= fontDialog1.Font;
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            TXT_Note.Clear();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TXT_Note.Text = File.ReadAllText(ofd.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog sfd = new SaveFileDialog();
            if (ofd.FileName == "")
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, TXT_Note.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(ofd.FileName, TXT_Note.Text, Encoding.Default);
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            TXT_Note.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            TXT_Note.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            TXT_Note.Paste();
        }
    }
}
