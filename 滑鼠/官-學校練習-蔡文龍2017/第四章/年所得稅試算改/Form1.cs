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
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    decimal x = Convert.ToDecimal(textBox1.Text);
                    if (x >= 0)
                    {
                        int y = x <= 520000 ? 1 : (x <= 1170000 ? 2 : (x <= 2350000 ? 3 : (x <= 4400000 ? 4 : (x <= 10000000 ? 5 : 6))));
                        switch (y)
                        {
                            case 1:
                                label3.Text = " 級  距 : 1";
                                label4.Text = " 稅  率 : 5%";
                                label5.Text = "累進差額: 0元";
                                label6.Text = "應繳稅額: " + (Convert.ToDouble(textBox1.Text) * 0.05).ToString("f0");
                                break;
                            case 2:
                                label3.Text = " 級  距 : 2";
                                label4.Text = " 稅  率 : 12%";
                                label5.Text = "累進差額: 26000元";
                                label6.Text = "應繳稅額: " + ((Convert.ToDouble(textBox1.Text) - 520000) * 0.12 + 26000).ToString("f0");
                                break;
                            case 3:
                                label3.Text = " 級  距 : 3";
                                label4.Text = " 稅  率 : 20%";
                                label5.Text = "累進差額: 104000元";
                                label6.Text = "應繳稅額: " + ((Convert.ToDouble(textBox1.Text) - 1170000) * 0.2 + 104000).ToString("f0");
                                break;
                            case 4:
                                label3.Text = " 級  距 : 4";
                                label4.Text = " 稅  率 : 30%";
                                label5.Text = "累進差額: 340000元";
                                label6.Text = "應繳稅額: " + ((Convert.ToDouble(textBox1.Text) - 2350000) * 0.3 + 340000).ToString("f0");
                            break;
                            case 5:
                                label3.Text = " 級  距 : 5";
                                label4.Text = " 稅  率 : 40%";
                                label5.Text = "累進差額: 955000元";
                                label6.Text = "應繳稅額: " + ((Convert.ToDouble(textBox1.Text) - 4400000) * 0.4 + 955000).ToString("f0");
                            break;
                            default:
                                label3.Text = " 級  距 : 6";
                                label4.Text = " 稅  率 : 45%";
                                label5.Text = "累進差額: 3195000元";
                                label6.Text = "應繳稅額: " + ((Convert.ToDouble(textBox1.Text) - 10000000) * 0.45 + 3195000).ToString("f0");
                            break;
                        }
                        label7.Text = "應繳稅額 = 年所得稅 * 稅率 + 累進差額";
                    }
                    else
                    {
                    label7.Text = "不用扣稅";
                    }
            }
            catch
            {
                MessageBox.Show("請重新輸入","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox1.Clear();
                label3.Text = " 級  距 :";
                label4.Text = " 稅  率 :";
                label5.Text = "累進差額:";
                label6.Text = "應繳稅額:";
                label7.Text = "提示訊息";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
