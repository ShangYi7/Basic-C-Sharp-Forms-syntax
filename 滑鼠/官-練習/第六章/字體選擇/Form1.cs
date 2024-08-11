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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("標楷體", 48, (checkedListBox1.SelectedIndex == 0 ? FontStyle.Bold : checkedListBox1.SelectedIndex == 1 ? FontStyle.Italic : checkedListBox1.SelectedIndex == 2 ? FontStyle.Underline : FontStyle.Strikeout) ^ label1.Font.Style);
        }
    }
}
