using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 主機選擇
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        int[] x = new int[5] { 300, 400, 500, 800, 0 };

        private void X()
        {
            label4.Text = "合計:" + ((listBox1.SelectedIndex == 0 ? 20000 : listBox1.SelectedIndex == 1 ? 18000 : listBox1.SelectedIndex == 2 ? 15000 : 12000) + (comboBox1.SelectedIndex == 0 ? 4000 : comboBox1.SelectedIndex == 1 ? 5000 : 6000) + x[4]).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            X();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            X();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            x[4] = (checkedListBox1.GetItemChecked(0) ? 300 : 0) + (checkedListBox1.GetItemChecked(1) ? 400 : 0) + (checkedListBox1.GetItemChecked(2) ? 500 : 0) + (checkedListBox1.GetItemChecked(3) ? 800 : 0);
            X();
        }
    }
}
