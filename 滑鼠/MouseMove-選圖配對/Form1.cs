using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      //  bool move = false;//紀錄圖片是否隨滑鼠移動
        int px, py, px2,py2,rn=0,wn=0,att=0;       
        bool drag = false;

        private void image1_Click(object sender, MouseEventArgs e)
        {

        }

        private void image1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left )
            {
                drag = true;
              
            }
        }

        private void image1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            { image1.Left += e.X;
                image1.Top += e.Y;
            }
        }

        private void image1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            if ( Math.Abs (image1.Left - pic2.Left) <= 10 && Math.Abs(image1.Top - pic2.Top) <= 10)
            { lb1.Text = "答對了！！--選原圖二下回到原點。";
                image1.Top = pic2.Top-15;
                image1.Left = pic2.Left-15;
                rn++;
                att++;
            }
            else if(Math.Abs(image1.Left - pic1.Left) <= 20 && Math.Abs(image1.Top - pic1.Top) <= 20)
            {
                lb1.Text = "答錯了！！--選原圖二下回到原點。";
                image1.Top = pic1.Top - 15;
                image1.Left = pic1.Left - 15;
                wn++;
                att++;
            }

            else
            {
                image1.Top = py;
                image1.Left = px;
                lb1.Text = "請移動滑鼠 做 配對！！";
            }
        }

        private void image1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            image1.Top = py;
            image1.Left = px;
            lb1.Text = "請移動滑鼠 做 配對！！";
        }








        private void p4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;

            }
        }

        private void p4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            p4.Top = py2;
            p4.Left = px2;
            lb1.Text = "請移動滑鼠 做 配對！！";
        }

        private void p4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                p4.Left += e.X;
                p4.Top += e.Y;
            }
        }

        private void p4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            if (Math.Abs(p4.Left - pic2.Left) <= 20 && Math.Abs(p4.Top - pic2.Top) <= 20)
            {
                lb1.Text = "答錯了！！--選原圖二下回到原點。";
                p4.Top = pic2.Top - 15;
                p4.Left = pic2.Left - 15;
                wn++;
                att++;
                lb2.Text = "totol:  " + att;

            }
            else if (Math.Abs(p4.Left - pic1.Left) <= 20 && Math.Abs(p4.Top - pic1.Top) <= 20)
            {
                lb1.Text = "答對了！！--選原圖二下回到原點。";
                p4.Top = pic1.Top - 15;
               p4.Left = pic1.Left - 15;
                rn++;
                att++;
                lb2.Text = "totol:  " + att;
            }

            else
            {
                p4.Top = py2;
                p4.Left = px2;
                lb1.Text = "請移動滑鼠 做 配對！！";
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            image1.Image = Image.FromFile("cat1.gif");//載入cat1.gif
            px2 = p4.Left;
            py2 = p4.Top;
            px = image1.Left;
            py = image1.Top;
            lb1.Text = "請移動滑鼠 做 配對！！";
        }
     
    }
}
