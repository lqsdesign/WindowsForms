using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Random r = new Random();

            for (int y = 0; y < ClientSize.Height; y++)
            {
                for (int x = 0; x < ClientSize.Width; x++)
                {
                    int _r = (int)(127*(Math.Cos(0.1 * (x + y)) + 1));
                    int _g = (int)(127*(Math.Sin(0.2 * (x + y)) + 1));
                    int _b = trackBar1.Value;

                    Pen p = new Pen(Color.FromArgb(_r, _g, _b));
                    g.DrawLine(p, x,y, x+1, y);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
