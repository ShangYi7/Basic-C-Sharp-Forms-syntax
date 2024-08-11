using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 重量轉換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kg = Convert.ToInt(textBox1.Text);
            int g = kg * 2.2;
            textBox2.Text = Convert.ToString(g);
        }
    }
}
    

