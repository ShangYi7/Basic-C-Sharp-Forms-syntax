using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 歌手排序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string A = "排名\t歌手\t歌曲\t\r\n";
        int[] x = new int[10];
        string[] a = "林俊傑 田馥甄 五月天 周杰倫 楊丞琳 李榮浩 林俊傑 林宥嘉 田馥甄 蕭敬騰".Split(), b = "不為誰而作的歌 餘波盪漾 後來的我們 不該 年輪說 滿座 關鍵詞 天真有邪 獨善其身 一次幸福的機會".Split();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                x[i] = i + 1;
            }
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] y = new int[10], z = new int[10]; string[] c = new string[10], d = new string[10];
            x.CopyTo(y, 0); x.CopyTo(z, 0);
            a.CopyTo(c, 0); b.CopyTo(d, 0);
            Array.Sort(y, c);Array.Sort(z, d);
            for (int i = 0; i < 10; i++)
                A += y[i].ToString() + "\t" + c[i] + "\t" + d[i] + "\r\n";
            textBox2.Text = A; 
            A = "排名" + "\t" + "歌手" + "\t" + "歌曲" + "\t" + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] y = new int[10]; string[] c = new string[10], d = new string[10], f = new string[10];
            x.CopyTo(y, 0);
            a.CopyTo(c, 0); b.CopyTo(d, 0); b.CopyTo(f, 0);
            Array.Sort(d, y); Array.Sort(f, c);
            for (int i = 0; i < 10; i++)
                A += y[i].ToString() + "\t" + c[i] + "\t" + d[i] + "\r\n";
            textBox2.Text = A; A = "排名\t歌手\t歌曲\t" + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] y = new int[10]; string[] c = new string[10], d = new string[10], f = new string[10];
            x.CopyTo(y, 0);
            a.CopyTo(c, 0); b.CopyTo(d, 0); a.CopyTo(f, 0);
            Array.Sort(c, y); Array.Sort(f, d);
            for (int i = 0; i < 10; i++)
                A += y[i].ToString() + "\t" + c[i] + "\t" + d[i] + "\r\n";
            textBox2.Text = A; A = "排名\t歌手\t歌曲\t" + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] y = new int[10], z = new int[10]; string[] c = new string[10], d = new string[10];
            x.CopyTo(y, 0); x.CopyTo(z, 0);
            a.CopyTo(c, 0); b.CopyTo(d, 0);
            Array.Sort(y, c); Array.Sort(z, d);
            Array.Reverse(y); Array.Reverse(c); Array.Reverse(d);
            for (int i = 0; i < 10; i++)
                A += y[i].ToString() + "\t" + c[i] + "\t" + d[i] + "\r\n";
            textBox2.Text = A; A = "排名\t歌手\t歌曲\t" + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int y;
            y = Array.IndexOf(a, textBox1.Text, 0);
            if (y == -1) { A = "找不到" + textBox1.Text; textBox2.Text = A; A = "排名\t歌手\t歌曲\t\r\n"; return; }
            A += x[y].ToString() + "\t" + a[y] + "\t" + b[y] + "\t" + "\r\n";
            for (int i = y + 1; y != -1; i++)
            {
                y = Array.IndexOf(a, textBox1.Text, y+1);
                A += y != -1 ? x[y].ToString() + "\t" + a[y] + "\t" + b[y] + "\t" + "\r\n" : "";
            }
            textBox2.Text = A; A = "排名\t歌手\t歌曲\t" + "\r\n";
        }
    }
}
