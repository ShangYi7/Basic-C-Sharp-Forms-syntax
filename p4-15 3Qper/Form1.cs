using static System.Formats.Asn1.AsnWriter;

namespace p4_15_3Qper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score;
            if (double.TryParse(textBox1.Text, out score))
            {
                label3.Text = (score >100  ? "請小於100" : (score <= 100 && score >= 90) ? "A" : ((score < 90 && score >= 80) ? "B" : ((score < 80 && score >= 70) ? "C" : (score < 70 && score >= 60) ? "D" : "不及格"))); //三元運算子/Ternary Operator                                                                                                                                                                                                                     
                              // score >100  成立輸出 "100" 否則運算底下
            }
            else
            {
                MessageBox.Show("請輸入有效數字");
            }
        }
    }
}