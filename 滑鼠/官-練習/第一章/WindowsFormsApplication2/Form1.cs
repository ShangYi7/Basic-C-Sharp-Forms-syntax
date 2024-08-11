using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			app
            //double kg=0,g=0;
            //textBox1.Text = kg.ToDouble;
            //g = kg * 2.2;
            //textBox2.Text = (string)g;
            //double f = (double)textBox1.Text;
            double f = Convert.ToDouble(textBox1.Text);
            double c = (f - 32) * 5 / 9;
            //textBox2.Text = (String)c;
            textBox2.Text = Convert.ToString(c);
            textBox1.Focus();
        }
    }
}
