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
                label3.Text = (score >100  ? "�Фp��100" : (score <= 100 && score >= 90) ? "A" : ((score < 90 && score >= 80) ? "B" : ((score < 80 && score >= 70) ? "C" : (score < 70 && score >= 60) ? "D" : "���ή�"))); //�T���B��l/Ternary Operator                                                                                                                                                                                                                     
                              // score >100  ���߿�X "100" �_�h�B�⩳�U
            }
            else
            {
                MessageBox.Show("�п�J���ļƦr");
            }
        }
    }
}