using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseDrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool drag = false;//紀錄是否可拖曳，預設不可拖曳
        private void Form1_Load(object sender, EventArgs e)
        {
            PicCat.Image = Image.FromFile("cat1.gif");//載入cat1.gif
        }
        //滑鼠游標移入PicCat時
        private void PicCat_MouseEnter(object sender, EventArgs e)
        {
            PicCat.Image = Image.FromFile("cat3.gif");//載入cat3.gif
        }
        //滑鼠游標移出PicCat時
        private void PicCat_MouseLeave(object sender, EventArgs e)
        {
            PicCat.Image = Image.FromFile("cat1.gif");//載入cat1.gif
        }
        //在PicCat內按下滑鼠左鍵時
        private void PicCat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//若是按滑鼠左鍵
            {
                PicCat.Image = Image.FromFile("cat4.gif");//載入cat4.gif
                drag = true;//設drag=true，表可拖曳
            }
        }
        //滑鼠游標在PicCat內移動時
        private void PicCat_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)//若設drag=true
            {   //將目前滑鼠的座標設為picCat的座標
                PicCat.Left += e.X;
                PicCat.Top += e.Y;
            }
        }
        //在PicCat內放開滑鼠左鍵時
        private void PicCat_MouseUp(object sender, MouseEventArgs e)
        {
            PicCat.Image = Image.FromFile("cat1.gif");//載入cat1.gif
            drag = false;//設drag=false，表不可拖曳
        }
    }
}
