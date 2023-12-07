using System;

namespace Bulls_and_Cows
{
    public partial class Form1 : Form
    {
        public static int num; // 全域變數

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
            //label3.Text = $"Ans: {num}"; //查看答案 不需要時註解
            Console.WriteLine(num); //控制台中
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
                        MessageBox.Show("你猜對了");
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
                    label3.Text = "輸入0~100數值";
                }
            }
            else
            {
                label3.Text = "Error: 輸入正整數";
            }
        }
    }
}