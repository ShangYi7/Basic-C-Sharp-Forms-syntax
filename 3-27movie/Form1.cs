namespace _3_27movie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // p3- 30
            string Cola_how_much = Microsoft.VisualBasic.Interaction.InputBox("��J�i�֪��B:", "�i�֪��B", "25"); // "����" "���D" "�w�]��"
            string SARS_how_much = Microsoft.VisualBasic.Interaction.InputBox("��J�F�h���B:", "�F�h���B", "25");
            textBox1.Text = SARS_how_much;
            textBox2.Text = Cola_how_much;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //�p�����h�ֿ�
        {
            try
            {
                int sum3;
                sum3 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox1.Text);
                label9_SARS_Yuan.Text = Convert.ToString(sum3);
            }
            catch
            {
                textBox3.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sum3, sum4;
                sum3 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox1.Text);
                sum4 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text);
                label10_Cola_Yuan.Text = Convert.ToString(sum4);
                total.Text = Convert.ToString(sum3 + sum4);
            }
            catch
            {
                textBox3.Clear();
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            DialogResult dr; //p3-30
            dr = MessageBox.Show("MessageBox.Show ����,�ȿ�X�b output ��", "MessageBox.Show", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            //                   "����"   "���D"  "�ݭn���ǫ��s"                "Icon �Ϥ�"   
            if (dr == DialogResult.Yes) // dr == DialogResult.Yes ��Ĳ�o
            {
                output.Text = "6666666";
            }
            else if (dr == DialogResult.No) // �P�_�y�� �i�H���ܦhelse if
            {
                output.Text = "77777777";
            }
            else // dr == DialogResult.Cancel ��Ĳ�o
            {
                output.Text = "22222";
            }
        }
    }
}