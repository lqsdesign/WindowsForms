using System.Drawing;
using System.Windows.Forms;

namespace ButtonsMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            int k = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Button button = new Button();
                    button.Parent = this;
                    button.Left = (i * 100) - 100;
                    button.Top = (j * 100) - 100;
                    button.Width = 100;
                    button.Height = 100;
                    button.Text = k.ToString();
                    
                    if ((i + j) % 2 == 0)
                    {
                        button.BackColor = Color.Black;
                        button.ForeColor = Color.Wheat;
                    }
                    k++;
                }
            }
        }
    }
}
