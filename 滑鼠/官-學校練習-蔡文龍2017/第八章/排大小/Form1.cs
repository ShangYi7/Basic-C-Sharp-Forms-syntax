using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排大小
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
                int[] a = Array.ConvertAll<string, int>((Microsoft.VisualBasic.Interaction.InputBox("請輸入兩位數或三位數並用空格隔開。", "比大小")).Split(' '), int.Parse);
                string c = "";
                if (a.Length != 2 && a.Length != 3)
                    System.Environment.Exit(0);
                mx(ref a);
                for (int i = 0; i < a.Length; i++)
                    c += a[i].ToString() + "  ";
                MessageBox.Show(c);
            }
            catch { }
            System.Environment.Exit(0);
        }

        void mx(ref int[] b)
        {
            Array.Sort(b);
            Array.Reverse(b);
            return;
        }
    }
}
