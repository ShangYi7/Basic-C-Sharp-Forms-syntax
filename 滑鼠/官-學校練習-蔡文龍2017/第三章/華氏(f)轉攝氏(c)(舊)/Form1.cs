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

        private void button1_Click(object sender, EventArgs e)
        {
            int f, c;
            try
            {
                if (textBox2.Text == "")
                {
                    string x = textBox1.Text, y = textBox2.Text;
                    f = Convert.ToInt32(x);
                    c = (f - 32) * 5 / 9;
                    textBox2.Text = Convert.ToString(c) + "度";
                }
                else if (textBox1.Text == "")
                {

                    string x = textBox1.Text, y = textBox2.Text;
                    c = Convert.ToInt32(y);
                    f = c * 9 / 5 + 32;
                    textBox1.Text = Convert.ToString(f) + "度";


                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch
            {
                textBox1.Text = "請重新輸入";
                textBox2.Text = "請重新輸入";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.PasswordChar = '*';
        }
    }
}
