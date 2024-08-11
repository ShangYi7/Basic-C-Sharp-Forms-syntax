using System.IO;              //引用System.IO命名空間

namespace CalAvg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string F = "F:\\code\\Program\\C# Forms\\p11-14 CalAvg\\bin\\Debug\\net6.0-windows\\int1.txt";
            FileInfo OU = new FileInfo("F:\\code\\Program\\C# Forms\\p11-14 CalAvg\\bin\\Debug\\net6.0-windows\\out.txt");
            StreamWriter sw = new StreamWriter("F:\\code\\Program\\C# Forms\\p11-14 CalAvg\\bin\\Debug\\net6.0-windows\\out.txt");
            StreamReader SR = new StreamReader(F);
            string P1 = SR.ReadLine();
            MessageBox.Show("總共" + P1 + "人");

            for(int i = 0;i < int.Parse(P1); i++)
            {
                string PP = SR.ReadLine();
                List<string> L = PP.Split(',').ToList();
                double V = 0;
                for (int j = 2; j < L.Count; j++)
                {
                    V += Convert.ToDouble(L[j]);
                }

                MessageBox.Show($"座號: {L[0]} 名字: {L[1]} 平均成績: {V / (L.Count - 2)}");
                sw.WriteLine($"座號: {L[0]} 名字: {L[1]} 平均成績: {V / (L.Count - 2)}");
            }
            SR.Close();
            sw.Flush();
            sw.Close();
            System.Environment.Exit(0);
        }
    }
}