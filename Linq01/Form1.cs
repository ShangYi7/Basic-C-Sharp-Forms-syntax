using System.Windows.Forms;

namespace Linq01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] score = new int[] { 89, 76, 54, 90, 34, 44, 100 };
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = score;
        }

        private void BtnAsc_Click(object sender, EventArgs e)
        {
            var result = score.OrderBy(m => m).ToList();  //���W�Ƨ�
            listBox2.Items.Add(result);

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            var result = score.OrderByDescending(m => m).ToList();  //����Ƨ�
            listBox2.Items.Add(result);
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            var result = score.Where(m => m >= 60).ToList();  //��X�ή檺���Z���
            listBox2.Items.Add(result);
        }

        private void BtnFail_Click(object sender, EventArgs e)
        {
            var result = score.Where(m => m < 60).ToList(); //��X���ή檺���Z���
            listBox2.Items.Add(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(score.Average().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(score.Max().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(score.Min().ToString());
        }
    }
}