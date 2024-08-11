using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 星號連加
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x,y;
            string a = "",b = "";
            for (x = 0;x<=5;x++)
            {
                    for (y = 0; y <= 7; y++)
                    {
                        if (y%2==0)
                        {
                           a += "*";
                        }
                        else
                        {
                           a += "#"; 
                        }
                    }
                a += "\n";
            }
            label1.Text = a;
            for (x = 0; x <= 3; x++)
            {
                for (y = 0; y <= 5; y++)
                {
                    if (y % 3 == 0)
                    {
                        b += "?";
                    }
                    else if(y % 3 == 1)
                    {
                        b += "     ";
                    }
                    else
                    {
                        b += "@";
                    }
                }
                b += "\n";
            }
            label2.Text = b;
        }
    }
}
