namespace p4_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double usd, jp, rmb, Yuan;
            bool r1;
            usd = 0.3;
            jp = 0.25;
            rmb = 0.4;

            r1 = double.TryParse(textBox1.Text, out Yuan);
            if (r1)
            {
                if (radiUSD.Checked == true)
                {
                    tool.Text = $"������ {Yuan * usd:f1} ��";
                }
                else if (radiJP.Checked == true)
                {
                    tool.Text = $"����� {Yuan * jp:f1} ��";
                }
                else if (radiRMB.Checked == true)
                {
                    tool.Text = $"�H������ {Yuan * rmb:f1}��";
                }
            }
            else
            {
                tool.Text = "�п�J���ļƭ�";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}