using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 顯示圖形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i, j, k;
            string a = "";
            for (i = 1; i < 7; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    a += "*  ";
                }
                a += "\n";
            }
            MessageBox.Show(a, "圖形一");a = "";
            for (i = 5; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    a += "　";
                }
                for (k = 1; k < 7-i; k++)
                {
                    a += "＊";
                }
                a += "\n";
            }
            //for (i = 5; i >= 0; i--)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        a += "   ";
            //    }
            //    for (k = 1; k < 7 - i; k++)
            //    {
            //        a += "*  ";
            //    }
            //    a += "\n";
            //}
            MessageBox.Show(a, "圖形二"); a = "";
            for (i = 1; i < 8; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i < 5) a += "*  ";
                }
                for (k = 1; k < 9-i; k++)
                {
                    if (i > 4) a += "*  ";
                }
                a += "\n";
            }
            MessageBox.Show(a, "圖形三");
            Close();
        }
    }
}
