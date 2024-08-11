using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 華氏_f_轉攝氏_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 5;
            textBox2.MaxLength = 5;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            m = 0;
            n++;
        }

        int n, m = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox2.Clear();
                }
                else if(m == 0)
                {
                    double x = (Convert.ToDouble(textBox1.Text) - 32) * 5 / 9;
                    textBox2.Text = x.ToString("F1");
                }
            }
            catch
            {
                MessageBox.Show("請重新輸入");
                textBox1.Clear();
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            n = 0;
            m++;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox1.Clear();
                }
                else if(n == 0)
                {
                    double y = Convert.ToDouble(textBox2.Text) * 9 / 5 + 32;
                    textBox1.Text = y.ToString("F1");
                }
            }
            catch
            {
                MessageBox.Show("請重新輸入");
                textBox2.Clear();
            }
        }
    }
}
