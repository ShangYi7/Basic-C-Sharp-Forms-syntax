using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 奇數_偶數判斷
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;
            textBox2.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0, z = 0;
            string a = "", b = "";
            try
            {
                for (int x = Convert.ToInt32(textBox1.Text); x <= Convert.ToInt32(textBox2.Text); x++)
                {
                    if (x % 2 == 1)
                    {
                        label6.Text = (++y).ToString();
                        a += "  " + Convert.ToString(x);
                    }
                    else
                    {
                        label7.Text = (++z).ToString();
                        b += "  " + Convert.ToString(x);
                    }
                }
            }
            catch
            {

            }
            label8.Text = a + Environment.NewLine + b;
            MessageBox.Show(a + Environment.NewLine + b, "結果");
        }
    }
}
