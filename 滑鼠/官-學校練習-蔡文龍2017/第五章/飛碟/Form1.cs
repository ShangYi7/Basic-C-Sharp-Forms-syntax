using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 飛碟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        int x = 0;
        bool[] a = new bool[6];

        private void button1_Click(object sender, EventArgs e)
        {
            a[0] = true;a[1] = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a[0] = false; a[1] = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a[2] = true; a[3] = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a[2] = false; a[3] = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a[4] = true; a[5] = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a[4] = false; a[5] = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x++;
            if (x % 2 == 1)
            {
                button7.Image = imageList1.Images[8];
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            else
            {
                button7.Image = imageList1.Images[7];
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a[0] == true)
            {
                if (pictureBox1.Top >= -20) pictureBox1.Top -= 20;
                else pictureBox1.Top = Size.Height;
            }
            else if (a[1] == true)
            {
                if (pictureBox1.Top <= Size.Height) pictureBox1.Top += 20;
                else pictureBox1.Top = -20;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a[2] == true)
            {
                if (pictureBox1.Left >= -20) pictureBox1.Left -= 20;
                else pictureBox1.Left = Size.Width;
            }
            else if (a[3] == true)
            {
                if (pictureBox1.Left <= Size.Width) pictureBox1.Left += 20;
                else pictureBox1.Left = -20;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (a[4] == true)
            {
                if (pictureBox1.Width < 200 && pictureBox1.Height < 200)
                {
                    pictureBox1.Width += 10;
                    pictureBox1.Height += 10;
                    pictureBox1.Top -= 5;
                    pictureBox1.Left -= 5;
                }
            }
            else if (a[5] == true)
            {
                if (pictureBox1.Width > 15 && pictureBox1.Height > 15)
                {
                    pictureBox1.Width -= 10;
                    pictureBox1.Height -= 10;
                    pictureBox1.Top += 5;
                    pictureBox1.Left += 5;
                }
            }
        }
    }
}
