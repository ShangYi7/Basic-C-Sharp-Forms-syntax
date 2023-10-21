using static System.Formats.Asn1.AsnWriter;

namespace p4_1_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            float score;
            if (!float.TryParse(textBox1.Text, out score))
            {
                label2.Text = ("請輸入有效數值");
                return;
            }



            if (score <= 100 && score >= 90)
            {
                label2.Text = ("甲");
            }
            else if (score <= 90 && score >= 80)
            {
                label2.Text = ("乙");
            }
            else if (score <= 80 && score >= 70)
            {
                label2.Text = ("丙");
            }
            else if (score <= 70 && score >= 60)
            {
                label2.Text = ("丁");
            }
            else if (score < 60 && score >= 0)
            {
                label2.Text = ("補考");
            }
            else
            {
                label2.Text = ("請輸入大於0,小於100的數值");
                return;
            }




        }
    }
}