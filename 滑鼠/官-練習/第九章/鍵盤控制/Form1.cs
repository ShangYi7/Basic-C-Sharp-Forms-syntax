using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鍵盤控制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int y = 0;
        int[] x = new int[130];
        string[] st = new string[130], ascii = new string[130];
        Color c;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "顯示輸入ASCII碼";
            label1.Text = "顯示:";
            label2.Text = "輸入文字:";
            label3.Text = "功能附註:\r\n  1.按 Ctrl + R 鍵時，左方文字方塊背景色變成紅色。\r\n  2.輸入字元鍵時，左方文字方塊會顯示按過的按鈕統計次數的文字。\r\n  3.按 Enter 鍵時，清除全部資料。";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox2.ScrollBars = ScrollBars.Vertical;
            c = textBox1.BackColor;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string a = textBox2.Text;
            if (textBox2.Text != "")
            {
                textBox1.Clear();
                st[y] = a.Substring(a.Length - 1, 1);
                for (int i = 0; i < x.Length; i++)
                    if (x[i] != 0)
                        textBox1.Text += " " + st[i] + " 字元的ASCII碼為: " + ascii[i].PadRight(3) + " ，且一共輸入了: " + x[i].ToString().PadRight(3) + " 次\r\n";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((TextBox)sender == textBox1)
            {
                e.Handled = true;
                return;
            }
            byte key = Convert.ToByte(e.KeyChar);
            y = key;
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox1.Clear();
                textBox2.Clear();
                x = new int[130];
                st = new string[130];
                ascii = new string[130];
                textBox1.BackColor = c;
                e.Handled = true;
            }
            else if (key == 18)
            {
                textBox1.BackColor = Color.Red;
            }
            else if ((key >= 48 && key <= 57) || (key >= 65 && key <= 90) || (key >= 97 && key <= 122))
            {
                x[key]++;
                if (ascii[key] != "")
                {
                    ascii[key] = key.ToString();
                }
            }
            else
                e.Handled = true;
        }
    }
}
