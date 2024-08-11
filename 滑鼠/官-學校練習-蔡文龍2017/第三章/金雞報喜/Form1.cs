using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 金雞報喜
{
    public partial class Form1 : Form
    {
        int m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "金雞報喜";
            label1.ForeColor = Color.Green;
            button7.ForeColor = Color.Blue;
            button8.ForeColor = Color.DarkOrange;
            button7.Text = "繁體";
            button8.Text = "清除";
            button9.Text = "結束";
            button7.Enabled = false;
            button8.Enabled = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Enabled = false;
            button9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
            m++;
            if(m == 2)
            {
                button9.Enabled = true;
                button9.Visible = true;
            }
            else if (m == 6)
            {
                button9.ForeColor = Color.BlueViolet;
                button7.Enabled = true;
                button8.Enabled = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
            m++;
            if (m == 2)
            {
                button9.Enabled = true;
                button9.Visible = true;
            }
            else if (m == 6)
            {
                button9.ForeColor = Color.BlueViolet;
                button7.Enabled = true;
                button8.Enabled = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            m++;
            if (m == 2)
            {
                button9.Enabled = true;
                button9.Visible = true;
            }
            else if (m == 6)
            {
                button9.ForeColor = Color.BlueViolet;
                button7.Enabled = true;
                button8.Enabled = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            m++;
            if (m == 2)
            {
                button9.Enabled = true;
                button9.Visible = true;
            }
            else if (m == 6)
            {
                button9.ForeColor = Color.BlueViolet;
                button7.Enabled = true;
                button8.Enabled = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Text,48,FontStyle.Bold);
            m++;
            if(m == 2)
            {
                button9.Enabled = true;
                button9.Visible = true;
            }
            else if (m == 6)
            {
                button9.ForeColor = Color.BlueViolet;
                button7.Enabled = true;
                button8.Enabled = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Text, 48, FontStyle.Italic);
            m++;
            if (m == 2)
            {
                button9.Enabled = true;
                button9.Visible = true;
            }
            else if (m == 6)
            {
                button9.ForeColor = Color.BlueViolet;
                button7.Enabled = true;
                button8.Enabled = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }

        int y = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            ++y;
            if (y == 1)
            {
                label1.Text = "金鸡报喜"; 
                button7.Text = "簡體";
            }
            else if (y == 2)
            {
                label1.Text = "ગોલ્ડન રોસ્ટર જાહેરાત";
                button7.Text = "外語";
            }
            else if (y == 3)
            {
                y = 0;
                label1.Text = "金雞報喜";
                button7.Text = "繁體"; 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Green;
            label1.Font = new Font("標楷體", 48, FontStyle.Regular);
            label1.Text = "金雞報喜";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (m >= 6)
            {
                MessageBox.Show("感謝您使用此程式","結束",MessageBoxButtons.OK);
                Close();
            }
            else
            {
                Close();
            }
        }

    }
}
