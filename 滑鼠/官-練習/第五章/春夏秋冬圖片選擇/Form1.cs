using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 春夏秋冬圖片選擇
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                pictureBox1.Image = x <= 0 ? null : (x <= 3 ? imageList1.Images[0] : (x <= 6 ? imageList1.Images[1] : (x <= 9 ? imageList1.Images[2] : (x <= 12 ? imageList1.Images[3] : null))));
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }
    }
}
