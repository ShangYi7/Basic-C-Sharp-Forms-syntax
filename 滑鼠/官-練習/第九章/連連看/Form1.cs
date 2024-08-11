using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 連連看
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1, x2, y2;
        int s1 = 0, s2 = 0, s = 0;
        bool b1 = false, b2 = false, b3 = true, b4 = true, b5 = true;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox[] p = { pictureBox1, pictureBox3 };
            if (b3 && b4)
            {
                if ((PictureBox)sender == p[0])
                {
                    b1 = true;
                }
                else if ((PictureBox)sender == p[1])
                {
                    b2 = true;
                }
                b5 = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox[] p = { pictureBox1, pictureBox3 };
            if (b3 && b4)
                if ((PictureBox)sender == p[0] && b1)
                {
                    p[0].Left += e.X;
                    p[0].Top += e.Y;

                }
                else if ((PictureBox)sender == p[1] && b2)
                {
                    p[1].Left += e.X;
                    p[1].Top += e.Y;
                }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox[] p = { pictureBox1, pictureBox3 };
            if (b3 && b4 && b5)
            {
                if ((PictureBox)sender == p[0])
                {
                    b1 = false;
                    if (Math.Abs(p[0].Left - pictureBox4.Left) < 20 && Math.Abs(p[0].Top - pictureBox4.Top) < 20)
                    {
                        s1++;
                        s++;
                        b3 = false;
                        label1.Text = "信息:正確，請快按兩下回原位";
                        label2.Text = "正確:" + s1.ToString() + "次，錯誤:" + s2.ToString() + "次，總次數:" + s + "次";
                        p[0].Left = pictureBox4.Left - 20;
                        p[0].Top = pictureBox4.Top - 20;
                    }
                    else if (Math.Abs(p[0].Left - pictureBox2.Left) < 20 && Math.Abs(p[0].Top - pictureBox2.Top) < 20)
                    {
                        s2++;
                        s++;
                        b3 = false;
                        label1.Text = "信息:錯誤，請快按兩下回原位";
                        label2.Text = "正確:" + s1.ToString() + "次，錯誤:" + s2.ToString() + "次，總次數:" + s + "次";
                        p[0].Left = pictureBox2.Left - 20;
                        p[0].Top = pictureBox2.Top - 20;
                    }
                    else
                    {
                        label1.Text = "請正確滑動游標";
                        p[0].Left = x1;
                        p[0].Top = y1;
                    }
                }
                else if ((PictureBox)sender == p[1])
                {
                    b2 = false;
                    if (Math.Abs(p[1].Left - pictureBox2.Left) < 20 && Math.Abs(p[1].Top - pictureBox2.Top) < 20)
                    {
                        s1++;
                        s++;
                        b4 = false;
                        label1.Text = "信息:正確，請快按兩下回原位";
                        label2.Text = "正確:" + s1.ToString() + "次，錯誤:" + s2.ToString() + "次，總次數:" + s + "次";
                        p[1].Left = pictureBox2.Left - 20;
                        p[1].Top = pictureBox2.Top - 20;
                    }
                    else if (Math.Abs(p[1].Left - pictureBox4.Left) < 20 && Math.Abs(p[1].Top - pictureBox4.Top) < 20)
                    {
                        s2++;
                        s++;
                        b4 = false;
                        label1.Text = "信息:錯誤，請快按兩下回原位";
                        label2.Text = "正確:" + s1.ToString() + "次，錯誤:" + s2.ToString() + "次，總次數:" + s + "次";
                        p[1].Left = pictureBox4.Left - 20;
                        p[1].Top = pictureBox4.Top - 20;
                    }
                    else
                    {
                        label1.Text = "請正確滑動游標";
                        p[1].Left = x2;
                        p[1].Top = y2;
                    }
                }
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox[] p = { pictureBox1, pictureBox3 };
            if ((PictureBox)sender == p[0] && !b3)
            {
                p[0].Left = x1;
                p[0].Top = y1;
                b3 = true;
                b5 = false;
                label1.Text = "信息";
            }
            else if ((PictureBox)sender == p[1] && !b4)
            {
                p[1].Left = x2;
                p[1].Top = y2;
                b4 = true;
                b5 = false;
                label1.Text = "信息";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "圖片連連看";
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[1];
            pictureBox4.Image = imageList1.Images[0];
            x1 = pictureBox1.Left;
            y1 = pictureBox1.Top;
            x2 = pictureBox3.Left;
            y2 = pictureBox3.Top;
            label1.Text = "信息";
            label2.Text = "正確:" + s1.ToString() + "次，錯誤:" + s2.ToString() + "次，總次數:" + s + "次";
        }
    }
}
