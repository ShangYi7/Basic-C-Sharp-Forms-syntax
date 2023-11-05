namespace P4_25_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true; //�w�]�Ŀ�/Default checked
            radioButton6.Checked = true; //�w�]�Ŀ�/Default checked
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int tool;
            string msg;
            tool = radioButton1.Checked ? 150 : radioButton2.Checked ? 120 : 100; // ���p�Ŀ� radioButton1 tool �� 150�_�h�᭱�����/If radioButton1 tool is checked, it will be 150, otherwise it will be compared later.
            msg = radioButton1.Checked ? "�j�J" : radioButton2.Checked ? "���J" : "�p�J"; //
            msg += "����\n\n���Y�@��:";
            msg += radioButton4.Checked ? "�@��" : radioButton6.Checked ? "��" : "�M�H";
            if (checkBox4.Checked == true)
            {
                tool += 20;
                msg += "\n�[�I����";
            }
            if (checkBox5.Checked == true)
            {
                tool += 20;
                msg += "\n�[�I�J";
            }
            if (checkBox6.Checked == true)
            {
                tool += 20;
                msg += "\n�[�I�C��";
            }
            msg += $"\n�`��:{tool}��";
            MessageBox.Show(msg, "�I���", MessageBoxButtons.OK);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}