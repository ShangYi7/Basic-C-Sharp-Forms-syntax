using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 資料讀取並計算
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                int x;
                int[] in1;
                string[] s1;
                StreamReader str1 = new StreamReader(op.FileName, Encoding.Default);
                s1 = str1.ReadToEnd().Replace("\r\n", "\n").Replace("\r", "\n").Split('\n');
                str1.Close();
                StreamWriter stw1 = new StreamWriter(@"D:\測試.txt", false, Encoding.Default);
                if (!int.TryParse(s1[0], out x) || s1.Length - 1 != x)
                {
                    MessageBox.Show("資料有誤!", "警告");
                    stw1.Flush();
                    stw1.Close();
                    str1.Close();
                    return;
                }
                in1 = new int[x];
                MessageBox.Show("題目共有 " + x.ToString() + " 題");
                for (int i = 1; i <= x; i++)
                {
                    in1[i - 1] = (int)(s1[i].Split(',', ' ').Where(v => v != "").Skip(2).Select(v => int.Parse(v)).Average());
                    string[] s2 = s1[i].Split(',', ' ');
                    stw1.WriteLine(s2[1] + " 第 " + s2[0] + " 題 答案是 " + in1[i - 1].ToString(), false);
                    MessageBox.Show(s2[1] + " 第 " + s2[0] + " 題 答案是 " + in1[i - 1].ToString());
                }
                x = (int)in1.Average();
                stw1.WriteLine("\r\n總平均: " + x.ToString(), false);
                MessageBox.Show("總平均: " + x.ToString());
                stw1.Flush();
                stw1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamReader str1 = new StreamReader(op.FileName, Encoding.Default);
                MessageBox.Show(str1.ReadToEnd());
                str1.Close();
            }
        }
    }
}
