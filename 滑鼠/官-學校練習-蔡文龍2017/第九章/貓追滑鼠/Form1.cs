using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 貓追滑鼠
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool b = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Image = imageList1.Images[1];
                b = true;
            }
            else
                pictureBox1.Image = imageList1.Images[r.Next(2, 5)];
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            b = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (b)
            {
                pictureBox1.Left = e.X + 2;
                pictureBox1.Top = e.Y;
            }
        }
    }
}
