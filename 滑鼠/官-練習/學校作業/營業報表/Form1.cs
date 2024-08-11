using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 營業報表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] x = new int[4, 3] { { 1000, 1500, 3200 }, { 2000, 2500, 1800 }, { 3000, 3500, 3600 }, { 4000, 4500, 1400 } };
            int y = 0; int[] z = new int[4];
            string a = "營業處\t台北\t台中\t高雄\t合計\t\n\n";
            for (int i = 0; i < x.GetUpperBound(0) + 1; i++)
            {
                a += "第" + (i + 1) + "季\t";
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    a += x[i, j].ToString() + "\t";
                    y += x[i, j];
                    z[j] += x[i, j];
                }
                a += y.ToString() + "\n";
                z[3] += y;
                y = 0;
            }
            a += "合計\t" + z[0] + "\t" + z[1] + "\t" + z[2] + "\t" + z[3] + "\t";
            MessageBox.Show(a); Close();
        }
    }
}
