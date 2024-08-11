using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成績輸入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y, X, Y;
        string a = "座號" + "\t" + "計概" + "\t" + "程式設計" + "\t" + "總分" + "\t" + "平均" + "\n", b;
        DialogResult Xx;

        private void Form1_Load(object sender, EventArgs e)
        {            
            for (x = 1;x<=3;x++)
            {
                for (y = 1;y<=2;y++)
                {
                    b = Microsoft.VisualBasic.Interaction.InputBox(y ==1? "計概:": "程式設計:", x.ToString()+ "號");
                    if(y == 1)
                    {
                        try
                        {
                            X = Convert.ToInt32(b);
                        }
                        catch
                        {
                            X = 0;
                        }
                    }
                    else
                    {
                        try
                        {
                            Y = Convert.ToInt32(b);
                        }
                        catch
                        {
                            Y = 0;
                        }
                    }
                }
                a += x.ToString() + "號" + "\t" + X + "\t" + Y + "\t" + (X + Y).ToString() + "\t" + ((X + Y) / 2).ToString() + "\t" + "\n";
                if (x % 3 == 0)
                {
                    MessageBox.Show(a, "結果");
                    Xx = MessageBox.Show("您要離開嗎?", "結束", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    x = Xx == DialogResult.Yes ? 3 : 0;
                }
            }
            Close();
        }
    }
}
