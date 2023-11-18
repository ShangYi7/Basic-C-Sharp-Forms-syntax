namespace 百元買百雞_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++) // 母雞數量最低 1 價錢 10           
                for (int j = 1; j < 19; j++) // 公雞數量最低 1 價錢 5                
                    for (int k = 1; k < 48; k++) // 小雞數量最低 0 價錢 2
                    {
                        if (i * 10 + j * 5 + k * 2 == 100)
                        {
                            label1.Text += $"母雞買{i}隻, 公雞買{j:D2}隻, 小雞買{k:D2}隻, 剛好等於100\n";
                        }
                    }
                    
                        


        }
    }
}
