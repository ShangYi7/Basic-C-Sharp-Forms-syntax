using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 年所得稅試算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 15;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    label3.Text = " 級  距 :";
                    label4.Text = " 稅  率 :";
                    label5.Text = "累進差額:";
                    label6.Text = "應繳稅額:";
                    label7.Text = "提示訊息";
                }
                else if (textBox1.Text == "-")
                {

                }
                else
                {
                    decimal x = Convert.ToDecimal(textBox1.Text);
                    if (x < 0)
                    {
                        label7.Text = "不用扣稅";
                    }
                    else
                    {
                        int y = x <= 520000 ? 1 : (x <= 1170000 ? 2 : (x <= 2350000 ? 3 : (x <= 440000 ? 4 : (x <= 10000000 ? 5 : 6))));
                        switch (y)
                        {
                            case 1:
                                label3.Text = " 級  距 : 1";
                                label4.Text = " 稅  率 : 5%";
                                label5.Text = "累進差額: 0元";
                                label6.Text = "應繳稅額: " + (Convert.ToDecimal(textBox1.Text) * 5 / 100 - 0).ToString("c0");
                                break;
                            case 2:
                                label3.Text = " 級  距 : 2";
                                label4.Text = " 稅  率 : 12%";
                                label5.Text = "累進差額: 36400元";
                                label6.Text = "應繳稅額: " + (Convert.ToDecimal(textBox1.Text) * 12 / 100 - 36400).ToString("c0");
                                break;
                            case 3:
                                label3.Text = " 級  距 : 3";
                                label4.Text = " 稅  率 : 20%";
                                label5.Text = "累進差額: 130000元";
                                label6.Text = "應繳稅額: " + (Convert.ToDecimal(textBox1.Text) * 20 / 100 - 130000).ToString("c0");
                                break;
                            case 4:
                                label3.Text = " 級  距 : 4";
                                label4.Text = " 稅  率 : 30%";
                                label5.Text = "累進差額: 365000元";
                                label6.Text = "應繳稅額: " + (Convert.ToDecimal(textBox1.Text) * 30 / 100 - 365000).ToString("c0");
                                break;
                            case 5:
                                label3.Text = " 級  距 : 5";
                                label4.Text = " 稅  率 : 40%";
                                label5.Text = "累進差額: 805000元";
                                label6.Text = "應繳稅額: " + (Convert.ToDecimal(textBox1.Text) * 40 / 100 - 805000).ToString("c0");
                                break;
                            default:
                                label3.Text = " 級  距 : 6";
                                label4.Text = " 稅  率 : 45%";
                                label5.Text = "累進差額: 1305000元";
                                label6.Text = "應繳稅額: " + (Convert.ToDecimal(textBox1.Text) * 45 / 100 - 13050000).ToString("c0");
                                break;
                        }
                        label7.Text = "應繳稅額 = 年所得稅 * 稅率 - 累進差額";
                    }
                }
            }
            catch
            {
                MessageBox.Show("請重新輸入","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
