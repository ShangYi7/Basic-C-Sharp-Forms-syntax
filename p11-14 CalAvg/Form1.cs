using System.IO;              //�ޥ�System.IO�R�W�Ŷ�

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
            MessageBox.Show("�`�@" + P1 + "�H");

            for(int i = 0;i < int.Parse(P1); i++)
            {
                string PP = SR.ReadLine();
                List<string> L = PP.Split(',').ToList();
                double V = 0;
                for (int j = 2; j < L.Count; j++)
                {
                    V += Convert.ToDouble(L[j]);
                }

                MessageBox.Show($"�y��: {L[0]} �W�r: {L[1]} �������Z: {V / (L.Count - 2)}");
                sw.WriteLine($"�y��: {L[0]} �W�r: {L[1]} �������Z: {V / (L.Count - 2)}");
            }
            SR.Close();
            sw.Flush();
            sw.Close();
            System.Environment.Exit(0);
        }
    }
}