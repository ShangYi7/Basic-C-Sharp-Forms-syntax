using System;

namespace Bulls_and_Cows
{
    public partial class Form1 : Form
    {
        public static int num; // �����ܼ�

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random myObject = new Random();
            num = myObject.Next(0, 100);
            //label3.Text = $"Ans: {num}"; //�d�ݵ��� ���ݭn�ɵ���
            Console.WriteLine(num); //����x��
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;

            if (int.TryParse(textBox1.Text, out temp))
            {
                if (temp < 101 && temp > -1)
                {
                    if (temp == num)
                    {
                        MessageBox.Show("�A�q��F");
                    }
                    else if (temp < num)
                    {
                        min.Text = $"{temp}";
                    }
                    else
                    {
                        max.Text = $"{temp}";
                    }
                }
                else
                {
                    label3.Text = "��J0~100�ƭ�";
                }
            }
            else
            {
                label3.Text = "Error: ��J�����";
            }
        }
    }
}