using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                label1.Text = openFileDialog1.FileName;
            }
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = (Width > Height) ? true : false;

            e.Graphics.DrawImageUnscaledAndClipped(pictureBox1.Image, 
                new Rectangle(0, 0, e.MarginBounds.Width, e.MarginBounds.Height));
        }

        private void PictureBox_Resize(object sender, EventArgs e)
        {
            label1.MaximumSize = Size;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = "PictureBox_";
                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    printDocument1.DocumentName += openFileDialog1.FileName;
                }
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
