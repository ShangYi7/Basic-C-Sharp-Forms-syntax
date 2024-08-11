using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 士兵跑步
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

        int x = 0, y = 0, z = 0, X = 20;
        bool a1, a2;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Image = imageList2.Images[(++y) % 2];
            if (y % 2 == 0) timer1.Start();
            else timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Image = imageList2.Images[(++z) % 2];
            if (z % 2 == 0) timer2.Start();
            else timer2.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer2.Interval > 15)
            {
                X += 15;
                timer2.Interval -= 15;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            X -= 15;
            timer2.Interval += 20;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a1 = true;a2 = false;
            button7.Image = imageList2.Images[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a1 = false;a2 = true;
            button7.Image = imageList2.Images[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a1 = a2 = false;
            button7.Image = imageList2.Images[1];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left >= -100 && pictureBox1.Left <= Size.Width) pictureBox1.Left -= X;
            else if (pictureBox1.Left <= -100) pictureBox1.Left = Size.Width;
            else pictureBox1.Left = -100;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[(++x) % 4];
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (a1 == true)
            {
                if (pictureBox1.Top >= -20) pictureBox1.Top -= 20;
                else pictureBox1.Top = Size.Height;
            }
            else if (a2 == true)
            {
                if (pictureBox1.Top <= Size.Height + 20) pictureBox1.Top += 20;
                else pictureBox1.Top = -20;
            }
        }
    }
}
