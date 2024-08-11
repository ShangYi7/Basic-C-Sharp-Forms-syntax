using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 台幣換美金
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
            textBox2.MaxLength = 5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "" || textBox2.Text == "")
                {

                }
                else if (radioButton1.Checked)
                {
                    label3.Text = "台幣" + textBox1.Text + "元可換成美金" + (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString("f0") + "元";
                }
                else
                {
                    label3.Text = "美金" + textBox1.Text + "元可換成台幣" + (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString("f0") + "元";
                }
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
                label3.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {

                }
                else if (radioButton1.Checked)
                {
                    label3.Text = "台幣" + textBox1.Text + "元可換成美金" + (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString("f0") + "元";
                }
                else
                {
                    label3.Text = "美金" + textBox1.Text + "元可換成台幣" + (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString("f0") + "元";
                }
                
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
                label3.Text = "";
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "台幣" + textBox1.Text + "元可換成美金" + (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString("f0") + "元";
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "美金" + textBox1.Text + "元可換成台幣" + (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString("f0") + "元";
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
