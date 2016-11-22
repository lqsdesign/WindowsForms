using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
            trackBarB.Value = Properties.Settings.Default.B;
            trackBarG.Value = Properties.Settings.Default.G;
            trackBarR.Value = Properties.Settings.Default.R;
            Left = Properties.Settings.Default.L;
            Top = Properties.Settings.Default.T;
            Width = Properties.Settings.Default.W;
            Height = Properties.Settings.Default.H;
            trackBarR_Scroll(null,null);
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(
                trackBarR.Value,
                trackBarG.Value,
                trackBarB.Value);
        }

        private void Colors_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.R = (byte)trackBarR.Value;
            Properties.Settings.Default.G = (byte)trackBarG.Value;
            Properties.Settings.Default.B = (byte)trackBarB.Value;

            Properties.Settings.Default.T = Top;
            Properties.Settings.Default.L = Left;
            Properties.Settings.Default.W = Width;
            Properties.Settings.Default.H = Height;

            Properties.Settings.Default.Save();
        }
    }
}
