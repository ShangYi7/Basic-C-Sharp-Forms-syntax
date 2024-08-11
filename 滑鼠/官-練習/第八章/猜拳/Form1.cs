using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜拳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] b = { button1, button2, button3 };
            for (int i = 0; i < 3; i++)
            {
                b[i].Image = imageList1.Images[i];
                b[i].Text = i == 0 ? "剪刀" : i == 1 ? "石頭" : "布";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w;
            Random r = new Random();
            Button bu = (Button)sender;
            Button[] b = { button1, button2, button3 };
            pictureBox1.Image = imageList1.Images[w = r.Next(0, 3)];
            if (bu == b[w])
            {
                label1.Text = "平手";
            }
            else if (bu == b[0])
            {
                label1.Text = w == 1 ? "你輸了" : "你贏了";
                s += w == 1 ? -50 : 50;
            }
            else if (bu == b[1])
            {
                label1.Text = w == 2 ? "你輸了" : "你贏了";
                s += w == 2 ? -50 : 50;
            }
            else
            {
                label1.Text = w == 0 ? "你輸了" : "你贏了";
                s += w == 0 ? -50 : 50;
            }
            textBox1.Text = "你現有" + s.ToString() + "元賭金";
        }

        void mx()
        {

        }
    }
}
