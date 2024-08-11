using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 圖片大小來源切換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = trackBar1.Value * 340 / 180;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Height = 192 - (trackBar2.Value * 191 / 180);
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar3.Value;
            pictureBox1.Image = Image.FromFile("圖片" + trackBar3.Value + ".jpg");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = (int)numericUpDown1.Value;
        }
    }
}
