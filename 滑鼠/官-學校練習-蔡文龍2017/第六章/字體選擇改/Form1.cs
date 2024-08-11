using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字體選擇
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FontStyle[] x = { checkedListBox1.GetItemChecked(0) == true ? FontStyle.Bold : FontStyle.Regular, checkedListBox1.GetItemChecked(1) == true ? FontStyle.Italic : FontStyle.Regular, checkedListBox1.GetItemChecked(2) == true ? FontStyle.Underline : FontStyle.Regular, checkedListBox1.GetItemChecked(3) == true ? FontStyle.Strikeout : FontStyle.Regular };
            label1.Font = new Font(label1.Font, x[0] | x[1] | x[2] | x[3]);
            //label1.Font = new Font("標楷體", 48, (checkedListBox1.SelectedIndex == 0 ? FontStyle.Bold : checkedListBox1.SelectedIndex == 1 ? FontStyle.Italic : checkedListBox1.SelectedIndex == 2 ? FontStyle.Underline : FontStyle.Strikeout) ^ label1.Font.Style);
        }
    }
}
