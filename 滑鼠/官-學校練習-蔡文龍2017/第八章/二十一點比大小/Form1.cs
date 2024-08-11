using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 二十一點比大小
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool b = false, b2 = false;
        int x1, x2 = 0, y, z = 2, i;
        int[] x = new int[7];
        Random r = new Random();
        PictureBox[] p = new PictureBox[7];

        private void Form1_Load(object sender, EventArgs e)
        {
            p[0] = pictureBox1; p[1] = pictureBox2; p[2] = pictureBox3; p[3] = pictureBox4; p[4] = pictureBox5; p[5] = pictureBox6; p[6] = pictureBox7;
            button2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b2 == false && z < 5 && x1 < 22)
            {
                do
                {
                    b = false;
                    y = r.Next(1, 14);
                    foreach (int w in x)
                    {
                        if (y == w)
                            b = true;
                    }
                    if (b == false)
                    {
                        x[z] = y;
                        p[z].Image = imageList1.Images[y - 1];
                        z++;
                        x1 += y > 10 ? 10 : y;
                    }
                } while (b == true);
                label2.Text = "你得到了" + x1.ToString() + "點";
                if (x1 > 21)
                {
                    button1.Enabled = false;
                    button3.Enabled = false;
                    label2.Text += "，爆掉";
                }
                else if (z == 5)
                {
                    button1.Enabled = false;
                    label2.Text += "，過五關";
                }
            }
            else
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            label2.Text = "";
            b = b2 = false;
            x1 = x2 = 0;
            z = 2;
            x = new int[7];
            for (i = 2; i < 7; i++)
            {
                p[i].Image = imageList1.Images[13];
            }
            x[0] = r.Next(1, 14);
            x1 += x[0] > 10 ? 10 : x[0];
            p[0].Image = imageList1.Images[x[0] - 1];
            for (i = 1; i < 2; i++)
            {
                x[1] = r.Next(1, 14);
                if ((x[1] != x[0]))
                {
                    x1 += x[1] > 10 ? 10 : x[1];
                    p[i].Image = imageList1.Images[x[1] - 1];
                }
                else
                    i--;
            }
            label2.Text = "你得到了" + x1.ToString() + "點";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x1 < 22 && b2 == false)
            {
                for (int i = 5; i < 7; i++)
                {
                    y = r.Next(1, 14);
                    b = false;
                    foreach (int w in x)
                    {
                        if (y == w)
                            b = true;
                    }
                    if (b == true)
                    {
                        i--;
                    }
                    else
                    {
                        x[i] = y;
                        p[i].Image = imageList1.Images[y - 1];
                        x2 += y > 10 ? 10 : y;
                    }
                }
                button1.Enabled = false;
                button3.Enabled = false;
                b2 = button4.Enabled = true;
            }
            else
                return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x2 < x1)
                label2.Text += "，你贏";
            else
                label2.Text += "，你輸";
            button4.Enabled = false;
        }
    }
}
