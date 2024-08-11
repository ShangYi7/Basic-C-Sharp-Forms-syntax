using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Load";
            Width = 500;
            Height = 300;
            BackColor = Color.Yellow;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int f;
            try
            {
                f = Convert.ToInt32(label5.Text) * Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(f);
            }
            catch
            {
                textBox2.Text = "0";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int f;
            try
            {
                f = Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox3.Text);
                textBox4.Text = Convert.ToString(f);
            }
            catch
            {
                textBox4.Text = "0";
            }
        }
    }
}
