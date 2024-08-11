using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicTank.Image = Image.FromFile("tank1.gif");  //載入tank1.gif
            PicTank.Left = 100; PicTank.Top = 90;  //預設PicTank的位置
            PicFire.Image = Image.FromFile("fire.gif");  //載入fire.gif
            PicFire.Visible = false;  //預設PicFire不可見
        }
        //當按下按鍵時
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) //根據e.KeyCode分別執行
            {
                case Keys.W:  //若按W鍵
                    PicTank.Top -= 2;  //上移2點
                    break;
                case Keys.S:  //若按S鍵
                    PicTank.Top += 2;  //上移2點
                    break;
                case Keys.A:  //若按A鍵
                    PicTank.Left -= 2;  //左移2點
                    break;
                case Keys.D:  //若按D鍵
                    PicTank.Left += 2;  //右移2點
                    break;
                case Keys.Up:  //若按向上鍵
                    PicTank.Image = Image.FromFile("tank1.gif");  //載入tank1.gif
                    PicFire.Left = PicTank.Left + 5;  //根據PicTank設picFire的位置
                    PicFire.Top = PicTank.Top - 50;
                    PicFire.Visible = true;  //設PicFire可視
                    break;
                case Keys.Right:  //若按向右鍵
                    PicTank.Image = Image.FromFile("tank2.gif");
                    PicFire.Left = PicTank.Left + 60;
                    PicFire.Top = PicTank.Top + 5;
                    PicFire.Visible = true;
                    break;
                case Keys.Down:  //若按向下鍵
                    PicTank.Image = Image.FromFile("tank3.gif");
                    PicFire.Left = PicTank.Left + 5;
                    PicFire.Top = PicTank.Top + 60;
                    PicFire.Visible = true;
                    break;
                case Keys.Left:  //若按向左鍵
                    PicTank.Image = Image.FromFile("tank4.gif");
                    PicFire.Left = PicTank.Left - 50;
                    PicFire.Top = PicTank.Top + 5;
                    PicFire.Visible = true;
                    break;
            }
        }
        //當放開按鍵時
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            PicFire.Visible = false;  //設PicFire不可見
        }
    }
}
