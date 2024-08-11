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

namespace 檔案串流
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.MaxDropDownItems = 100;
        }

        string filename = "";
        Encoding[] en = { Encoding.ASCII, Encoding.Default, Encoding.Unicode, Encoding.UTF7, Encoding.UTF8, Encoding.BigEndianUnicode, Encoding.UTF32 };

        private void button1_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                SaveFileDialog sa1 = new SaveFileDialog();
                sa1.Filter = "(*.txt)|*.txt";
                if (sa1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter st1 = new StreamWriter(filename = sa1.FileName, false, en[comboBox2.SelectedIndex]);
                    comboBox1.Items.Add(textBox1.Text);
                    st1.WriteLine(textBox1.Text);
                    st1.Flush();
                    st1.Close();
                }
            }
            else
            {
                StreamWriter st1 = new StreamWriter(filename, true, en[comboBox2.SelectedIndex]);
                comboBox1.Items.Add(textBox1.Text);
                st1.WriteLine(textBox1.Text);
                st1.Flush();
                st1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filename != "")
            {
                StreamReader st1 = new StreamReader(filename, en[comboBox3.SelectedIndex]);
                MessageBox.Show(st1.ReadToEnd());
                st1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            o1.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            if (o1.ShowDialog() == DialogResult.OK)
            {
                StreamReader st1 = new StreamReader(o1.FileName, en[comboBox3.SelectedIndex]);
                MessageBox.Show(st1.ReadToEnd());
                st1.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s1 = "";
            Random R = new Random();
            DirectoryInfo di1 = new DirectoryInfo(@"C:\");
            DirectoryInfo[] dir1 = di1.GetDirectories();
            FileInfo[] fi1 = di1.GetFiles();
            do
            {
                foreach (var item in dir1)
                {
                    if (item.Exists)
                    {
                        if (MessageBox.Show(item.Name.ToString() + "檔案已存在，是否刪除?", "刪除", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.Delete(true);
                            MessageBox.Show(item.Name.ToString() + "刪除成功!", "刪除");
                        }
                        else if (MessageBox.Show(item.Name.ToString() + "檔案已存在，是否搬移?", "搬移", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.MoveTo(@"D:\");
                            MessageBox.Show(item.Name.ToString() + "搬移成功!", "搬移");
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(item.Name.ToString() + "檔案不存在，是否建立?", "建立", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            item.Create();
                            MessageBox.Show(item.Name.ToString() + "建立成功!", "建立");
                        }
                    }
                }
                foreach (var item in fi1)
                {
                    s1 += item.Name + "\r\n";
                }
                MessageBox.Show(s1);
            } while (MessageBox.Show("是否退出?", "退出", MessageBoxButtons.YesNo) == DialogResult.No);
        }
    }
}
