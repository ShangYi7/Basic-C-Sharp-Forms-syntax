using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 輸入八數判斷奇偶
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] a = Microsoft.VisualBasic.Interaction.InputBox("請輸入任意八數用空格分開:", "輸入八數判斷奇偶").Split();int x = 0, y = 0;
                if (a.Length != 8) Close();
                for (int i = 0; i < 8; i++)
                {
                    x += Convert.ToInt32(a[i]) % 2 == 0 ? 0 : 1;
                    y += Convert.ToInt32(a[i]) % 2 == 0 ? 1 : 0;
                }
                MessageBox.Show("共有奇數" + x.ToString() + "個\n共有偶數" + y.ToString() + "個");Close();
            }
            catch { Close(); }
        }
    }
}
