using static System.Formats.Asn1.AsnWriter;

namespace p6_19_Array_IndexOf
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

        private void button1_Click(object sender, EventArgs e)
        {
            int x, index;
            string msg;
            
            string[] stu = new string[] { "��", "e04", "����", "�q", "�K�C" };
            int[] score = new int[] { 95, 100, 100, 92, 100 };

            if (int.TryParse(textBox1.Text, out x))
            {
                index = Array.IndexOf(score, x);
                if(index > -1)
                {
                    msg = $"{x}���ƾǥ�: ";
                    while(index > -1)
                    {
                        msg+=stu[index]+",";
                        index = Array.IndexOf(score,x,index+1);
                    }
                }
                else
                {
                    msg = "�j�M����";
                }
            }
            else
            {
                msg = "��J�����";
            }
            MessageBox.Show(msg);
        }
    }
}