using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 找有幾數小於平均值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            {
                double[] x = new double[5]; double y = 0, z = 0;
                string[] a = Microsoft.VisualBasic.Interaction.InputBox("請輸入五個數字用,隔開:", "找有幾數小於平均值").Split(','); string b = "", A = "";
                if (a.Length != 5) Close();
                for (int i = 0; i < 5; i++)
                {
                    x[i] = Convert.ToInt32(a[i]);
                    y += x[i];
                }
                y /= 5;
                Array.Sort(x); Array.Reverse(x);
                for (int j = 0; j < 5; j++)
                {
                    A += x[4 - j].ToString() + " ";
                    b += x[j].ToString() + " ";
                    if (x[j] < y) z++;
                }
                MessageBox.Show("共有" + z.ToString() + "個數字小於平均值" + y.ToString() + "\n" + A + "\n" + b, "結果"); Close();
            }
           // catch { Close(); }
        }
    }
}
