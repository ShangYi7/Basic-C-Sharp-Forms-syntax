using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 西元轉民國年月日
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
                char b = Convert.ToChar(Microsoft.VisualBasic.Interaction.InputBox("請輸入分割字元:", "西元轉民國年月日"));
                string[] a = Microsoft.VisualBasic.Interaction.InputBox("請輸入西元年月日用 " + b + " 隔開:", "西元轉民國年月日").Split(b);
                if (a.Length != 3) Close();
                MessageBox.Show("民國" + (Convert.ToInt32(a[0]) - 1911).ToString() + "年" + a[1] + "月" + a[2] + "日", "結果");Close();
            }
            catch { Close(); }
        }
    }
}
