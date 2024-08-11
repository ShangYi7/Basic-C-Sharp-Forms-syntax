using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA積點計算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 7;
            textBox2.MaxLength = 3;
            textBox3.MaxLength = 1;
        }

        int x = 0, GPA = 0;
        double sGPA = 0;
        string LV;

        private void button1_Click(object sender, EventArgs e)
        {
            int s;
            try
            {
                if (textBox2.Text == "" | textBox3.Text == "")
                {
                    Convert.ToInt32(textBox2.Text);
                    Convert.ToInt32(textBox3.Text);
                }
                else
                {
                    s = Convert.ToInt32(textBox2.Text);
                    if (s < 0 | s > 100)
                    {
                        MessageBox.Show("請重新輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox2.Text = "";
                    }
                    else
                    {
                        switch (s / 10)
                        {
                            case 10:
                                LV = "AAA";
                                GPA = 4;
                                break;
                            case 9:
                                LV = "AA";
                                GPA = 4;
                                break;
                            case 8:
                                LV = "AA";
                                GPA = 4;
                                break;
                            case 7:
                                LV = "A";
                                GPA = 3;
                                break;
                            case 6:
                                LV = "B";
                                GPA = 2;
                                break;
                            case 5:
                                LV = "C";
                                GPA = 1;
                                break;
                            default:
                                LV = "D";
                                GPA = 0;
                                break;
                        }
                        label7.Text = Convert.ToString(x += Convert.ToInt32(textBox3.Text));
                        label8.Text = Convert.ToString(sGPA += GPA * Convert.ToInt32(textBox3.Text)); 
                        label9.Text = Convert.ToString(sGPA / x);
                        label10.Text += "\n" + " " + textBox1.Text;
                        label11.Text += "\n" + " " + textBox2.Text;
                        label12.Text += "\n" + "  " + textBox3.Text;
                        label13.Text += "\n" + " " + LV;
                        label14.Text += "\n" + "  " + GPA;
                    }
                }
            }
            catch
            {
                MessageBox.Show("請重新輸入","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
