using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 機車移動
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "停止!!";
            label1.AutoSize = false;
            label1.Size = new Size(200, 30);
            label1.Location = new Point(5, 5);
            label1.Font = new Font("標楷體", 12, FontStyle.Regular);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.BackColor = Color.Aqua;
            label2.Text = "未按鍵!!";
            label2.AutoSize = false;
            label2.Size = new Size(200, 30);
            label2.Location = new Point(300, 5);
            label2.Font = new Font("標楷體", 12, FontStyle.Regular);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.BackColor = Color.Aqua;
            label3.Text = "";
            label3.AutoSize = false;
            label3.Size = new Size(2000, 100);
            label3.Location = new Point(0, 300);
            label3.BackColor = Color.Orange;
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.Location = new Point(0, label3.Top - label3.Height);
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Size = new Size(50, 50);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true)
            {
                x = 30;
                label2.Text = "按下Alt鍵，鍵值為" + Convert.ToByte(e.KeyCode);
            }
            else
            {
                x = 5;
            }
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (pictureBox1.Left > this.Width)
                    {
                        pictureBox1.Left = -pictureBox1.Width;
                    }
                    pictureBox1.Left += x;
                    pictureBox1.Image = imageList1.Images[1];
                    label1.Text = "舉孤輪!!";
                    label2.Text = "按下Up鍵，鍵值為" + Convert.ToByte(e.KeyCode);
                    break;
                case Keys.Down:
                    pictureBox1.Image = imageList1.Images[2];
                    label1.Text = "煞車!!";
                    label2.Text = "按下Down鍵，鍵值為" + Convert.ToByte(e.KeyCode);
                    break;
                case Keys.Left:
                    if (pictureBox1.Left < -pictureBox1.Width)
                    {
                        pictureBox1.Left = this.Width;
                    }
                    pictureBox1.Image = imageList1.Images[0];
                    pictureBox1.Left -= x;
                    label1.Text = "後退!!";
                    label2.Text = "按下Left鍵，鍵值為" + Convert.ToByte(e.KeyCode);
                    break;
                case Keys.Right:
                    if (pictureBox1.Left > this.Width)
                    {
                        pictureBox1.Left = -pictureBox1.Width;
                    }
                    pictureBox1.Image = imageList1.Images[0];
                    pictureBox1.Left += x;
                    label1.Text = "前進!!";
                    label2.Text = "按下Right鍵，鍵值為" + Convert.ToByte(e.KeyCode);
                    break;
                case Keys.Space:
                    if (pictureBox1.Left > this.Width)
                    {
                        pictureBox1.Left = -pictureBox1.Width;
                    }
                    pictureBox1.Image = imageList1.Images[0];
                    pictureBox1.Left += x;
                    label1.Text = "前進!!";
                    label2.Text = "按下Space鍵，鍵值為" + Convert.ToByte(e.KeyCode);
                    break;
                case Keys.A:
                    if (pictureBox1.Left > this.Width)
                    {
                        pictureBox1.Left = -pictureBox1.Width;
                    }
                    pictureBox2.Location = new Point(pictureBox1.Left - pictureBox2.Width, pictureBox1.Top + 50);
                    pictureBox2.Image = imageList1.Images[3];
                    pictureBox1.Left += 10;
                    label2.Text = "按下A鍵，鍵值為" + Convert.ToByte(e.KeyCode);
                    break;
                case Keys.S:
                    if (pictureBox1.Left < -pictureBox1.Width)
                    {
                        pictureBox1.Left = this.Width;
                    }
                    pictureBox2.Location = new Point(pictureBox1.Left + pictureBox2.Width + 50, pictureBox1.Top + 50);
                    pictureBox2.Image = imageList1.Images[3];
                    pictureBox1.Left -= 10;
                    label2.Text = "按下S鍵，鍵值為" + Convert.ToByte(e.KeyCode);
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Alt:
                    x = 5;
                    break;
            }
            pictureBox2.Image = null;
            pictureBox2.Top = 100;
        }
    }
}
