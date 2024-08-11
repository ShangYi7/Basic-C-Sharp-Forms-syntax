using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 歌手投票
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] x = new int[6], y = new int[6];
        string[] a = new string[] { "曾沛慈", "田馥甄", "A-Lin", "楊丞琳", "蔡依林", "彭佳慧" }, b = new string[] { "我是曾沛慈...福茂", "日常...華研", "罪惡感...索尼", "年輪說...環球", "Play 我呸...華納", "大齡女子...金牌大風" }, c = new string[6];

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(a);
            for (int i = 0; i < 6; i++)
                listBox2.Items.Add(a[i] + "\t" + x[i] + "票");
            listBox1.SelectedIndex = 0;
            //listBox1.SetSelected(0, true);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label3.Text = b[listBox1.SelectedIndex];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            x[listBox1.SelectedIndex]++;
            x.CopyTo(y, 0); a.CopyTo(c, 0);
            Array.Sort(y, c); Array.Reverse(y); Array.Reverse(c);
            for (int i = 0; i < 6; i++)
                listBox2.Items.Add(c[i] + "\t" + y[i] + "票");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            x.CopyTo(y, 0); a.CopyTo(c, 0);
            Array.Sort(c, y);
            for (int i = 0; i < 6; i++)
                listBox2.Items.Add(c[i] + "\t" + y[i] + "票");
        }
    }
}
