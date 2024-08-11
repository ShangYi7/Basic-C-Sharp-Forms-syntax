using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列排大小
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int y;
            int[] x = Microsoft.VisualBasic.Interaction.InputBox("請輸入1~n筆資料並用空格隔開", "陣列排大小").Split(' ').Where(v => v != "").Select(v => int.Parse(v)).ToArray();
            string a = "", b = "";
            Random r = new Random();
            try
            {
                for (int i = 0; i < x.Length; i++)
                    for (int j = 1; j < x.Length; j++)
                        if (x[j] < x[j - 1])
                        {
                            y = x[j];
                            x[j] = x[j - 1];
                            x[j - 1] = y;
                        }
                for (int i = 0; i < x.Length; i++)
                {
                    a += x[i].ToString() + "  ";
                    b += x[x.Length - i - 1].ToString() + "  ";
                }
                MessageBox.Show(a + "\r\n\r\n" + b, "結果");
            }
            catch { }
            System.Environment.Exit(0);
        }
    }
}
