using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 累加
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text += "1加到10增值為3的總合為 :" + mx(1, 10, 3).ToString() + "\r\n\r\n" + "5加到12增值為3的總合為 :" + mx(5, 12, 3).ToString();
        }

        int mx(int n,int m,int s)
        {
            int sum = 0;
            for (int i = n; i <= m; i += s)
                sum += i;
            return sum;
        }
    }
}
