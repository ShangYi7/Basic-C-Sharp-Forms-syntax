using Microsoft.VisualBasic;

namespace p6_2_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str;
            double num;
            bool pass;
            double[] score = new double[3];
            for (int i = 0; i <= 2; i++)
            {
                str = Interaction.InputBox("輸入數值", "求平均");
                pass = double.TryParse(str, out num);
                if (pass == true)
                {
                    score[i] = num;
                }
                else
                {
                    label1.Text = "輸入正整數";
                }
                label1.Text = ($"{score[0]} {score[1]} {score[2]}    {(score[0] + score[1] + score[2]) / 3}");
            }
        }
    }
}