using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 乘法表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, y;
            string a = "";
            for (x = 1; x <= 9; x++)
            {
                for (y = 1; y <= 9; y++)
                {
                    a += x.ToString("D2") + "*" + y.ToString("D2") + "=" + (x * y).ToString("D2") + "  ";
                    //a += string.Format("{0:D2}",x) + "*" + string.Format("{0:D2}", y) + "=" + string.Format("{0:D2}", x*y) + "  ";
                    //兩行功能相同。
                }
                a += "\n" + "\n";
            }
            label1.Text = a;
            a = "";
            for (x = 1; x <= 19; x++)
            {
                for (y = 1; y <= 19; y++)
                {
                    a += string.Format("{0:D2}", x) + "*" + string.Format("{0:D2}", y) + "=" + string.Format("{0:D3}", x * y) + "  ";
                }
                a += "\n" + "\n";
            }
            label2.Text = a;
        }
    }
}
