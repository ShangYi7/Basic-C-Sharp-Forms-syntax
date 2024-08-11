using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 分數輸入
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
        int y = 0, z = 0; int[] x = new int[5];double b;
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out z) == false) return;
            if (z < 0 | z > 100) return;
            string[] a = new string[5] { "丁曉雯 老師給分: ", "羅文聰 老師給分: ", "陳盈潔 老師給分: ", "左安安 老師給分: ", "許景淳 老師給分: " };
            if (y < 5)
            {
                x[y] = int.Parse(textBox1.Text);
                label2.Text += a[y] + x[y] + "\n";
            }
            y++;
            textBox1.Clear();
            if (y == 5)
            {
                 foreach (int j in x)
                 {
                     b += j;
                 }
                label2.Text += "====================\n" + "平均分數: " + (b/5).ToString();
                button1.Enabled = false;
            }
            else
            {
                label1.Text = a[y];
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y = 0;b = 0;
            textBox1.Clear(); textBox1.Focus();
            label2.Text = "";
            button1.Enabled = true;
            for (int i = 0; i < 5; i++) x[i] = 0;
        }
    }
}
