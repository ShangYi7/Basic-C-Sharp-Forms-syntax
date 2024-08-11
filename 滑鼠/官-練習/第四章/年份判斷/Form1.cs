using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 年分判斷
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 7;
            textBox1.Focus();
        }

        int y;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    label2.Text = "";
                }
                else
                {
                    int x = Convert.ToInt32(textBox1.Text);
                    if (x < 0 || x==0)
                    {
                        MessageBox.Show("請重新輸入");
                        textBox1.Text = "";
                        label2.Text = "";
                    }
                    else if (x % 4 != 0)
                    {
                        label2.Text = textBox1.Text + "年是平年";
                    }
                    else if (x % 100 != 0)
                    {
                        label2.Text = textBox1.Text + "年是閏年";
                    }
                    else if (x % 400 == 0)
                    {
                        label2.Text = textBox1.Text + "年是閏年";
                    }
                    else
                    {
                        label2.Text = textBox1.Text + "年是平年";
                    }
                }
            }
            catch
            {
                y++;
                if(y == 5)
                {
                    MessageBox.Show("重新輸入!!!!!!!");
                    textBox1.Text = "";
                    y = 0;
                }
                else
                {
                    MessageBox.Show("請重新輸入");
                    textBox1.Text = "";
                }
            }
        }
    }
}
