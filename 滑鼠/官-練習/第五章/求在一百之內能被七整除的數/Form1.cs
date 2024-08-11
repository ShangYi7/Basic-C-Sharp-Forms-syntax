using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 求在一百之內能被七整除的數
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
                int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("請輸入大於7且小於100的正整數:", "求在一百之內能被七整除的數")), y = 0;
                string a = "";
                if (x <= 7 | x >= 100) Close();
                for (int i = 7; i < x; i++)
                {
                    if (i % 7 == 0)
                    {
                        a += i.ToString() + "\n";
                        y += i;
                    }
                }
                MessageBox.Show("1到" + x.ToString() + "中能被7整除的數:\n" + a + "--------------------------------\n總合為: " + y.ToString());
                Close();
            }
            catch { Close(); }
        }
    }
}
