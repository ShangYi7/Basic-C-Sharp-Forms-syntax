using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗撲克牌比大小
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1 = 500, x2, x;
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = textBox2.MaxLength = textBox3.MaxLength = 2;
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[(x2 = r.Next(1, 14)) - 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if(int.TryParse(textBox1.Text, out x) == true && int.TryParse(textBox4.Text, out x) == true)
                {
                    timer1.Enabled = false;
                    if(Convert.ToInt32(textBox1.Text) > x2)
                    {
                        label4.Text = "得到" + x2.ToString() + "點，" + "你賭贏了，得到" + (Convert.ToInt32(textBox4.Text) * (14 - (Convert.ToInt32(textBox1.Text) >= 13 ? 13 : Convert.ToInt32(textBox1.Text)))).ToString() + "點";
                        x1 += Convert.ToInt32(textBox4.Text) * (14 - (Convert.ToInt32(textBox1.Text) >= 13 ? 13 : Convert.ToInt32(textBox1.Text)));
                    }
                    else if (Convert.ToInt32(textBox1.Text) == x2)
                    {
                        label4.Text = "得到" + x2.ToString() + "點，沒輸沒贏";
                    }
                    else
                    {
                        label4.Text = "得到" + x2.ToString() + "點，你賭輸了，輸了" + textBox4.Text.ToString() + "點";
                        x1 -= Convert.ToInt32(textBox4.Text);
                    }
                    label10.Text = "賭金:" + x1.ToString();
                    if (x1 < 0)
                        label10.Text += "，破產";
                }
            }
            else
            {
                if (int.TryParse(textBox2.Text, out x) == true && int.TryParse(textBox3.Text, out x) == true && int.TryParse(textBox4.Text, out x) == true)
                {
                    timer1.Enabled = false;
                    if (Convert.ToInt32(textBox2.Text) <= x2 && Convert.ToInt32(textBox3.Text) >= x2)
                    {
                        label4.Text = "得到" + x2.ToString() + "點，" + "你賭贏了，得到" + (Convert.ToInt32(textBox4.Text) * (13 - (Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox2.Text) >= 12 ? 12 : Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox2.Text)))).ToString() + "點";
                        x1 += Convert.ToInt32(textBox4.Text) * (13 - (Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox2.Text) >= 12 ? 12 : Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox2.Text)));
                    }
                    else
                    {
                        label4.Text = "得到" + x2.ToString() + "點，你賭輸了，輸了" + textBox4.Text.ToString() + "點";
                        x1 -= Convert.ToInt32(textBox4.Text);
                    }
                    label10.Text = "賭金:" + x1.ToString();
                    if (x1 < 0)
                        label10.Text += "，破產";
                }
            }
        }
    }
}
