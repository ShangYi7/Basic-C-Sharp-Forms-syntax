using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 數位相機選購_改
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

        int x, y, X;
        string a, b;
        string[] A = new string[4] { "", "", "", "" };

        private void MX()
        {
            x = radioButton1.Checked ? 5980 : (radioButton2.Checked ? 4980 : 2980);
            a = radioButton1.Checked ? "時尚機" : (radioButton2.Checked ? "功能機" : "可愛機");
            b = radioButton4.Checked ? "清潔組" : (radioButton5.Checked ? "保護貼" : "防潮盒");
            label2.Text = "總價" + Convert.ToString(x + y) + "元，" + "您選了" + a + Convert.ToString(x) + "元，加贈" + b + (X >= 1 ? "，接著您又加購了" : "。") + A[0] + A[1] + A[2] + A[3] + (X >= 1 ? "。" : "");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MX();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MX();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MX();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MX();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MX();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            MX();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { y += 599; A[0] = " 大容量記憶卡599元 "; X++; }
            else { y -= 599; A[0] = ""; X--; }
            MX();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { y += 499; A[1] = " 專用電池499元 "; X++; }
            else { y -= 499; A[1] = ""; X--; }
            MX();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { y += 1000; A[2] = " 大背包1000元 "; X++; }
            else { y -= 1000; A[2] = ""; X--; }
            MX();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { y += 400; A[3] = " 小背包400元 "; X++; }
            else { y -= 400; A[3] = ""; X--; }
            MX();
        }
    }
}
