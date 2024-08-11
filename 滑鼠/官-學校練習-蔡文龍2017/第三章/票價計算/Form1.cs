using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 票價計算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    label8.Text = "0";
                    label11.Text = Convert.ToString(Convert.ToInt32(label8.Text) + Convert.ToInt32(label9.Text));
                }
                else
                {
                    label8.Text = Convert.ToString(Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text));
                    label11.Text = Convert.ToString(Convert.ToInt32(label8.Text) + Convert.ToInt32(label9.Text));
                }
            }
            catch
            {
                MessageBox.Show("請重新輸入");
                textBox1.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    label9.Text = "0";
                    label11.Text = Convert.ToString(Convert.ToInt32(label8.Text) + Convert.ToInt32(label9.Text));
                }
                else
                {
                    label9.Text = Convert.ToString(Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text));
                    label11.Text = Convert.ToString(Convert.ToInt32(label8.Text) + Convert.ToInt32(label9.Text));
                }
            }
            catch
            {
                MessageBox.Show("請重新輸入");
                textBox2.Text = "0";
            }
        }
    }
}
