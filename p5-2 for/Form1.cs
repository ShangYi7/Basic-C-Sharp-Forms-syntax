namespace p5_2_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sum1, sum2;
            string msg = "";
            for (sum1 = 1; sum1 <= 9; sum1++)
            //start  ; end      ; interval
            {
                for (sum2 = 1; sum2 <= 9; sum2++)
                {
                    msg += $"{sum2} * {sum1} = {sum1 * sum2:D2}        ";
                    msg += "   ";
                }
                msg += "\n";
            }
            //9*9
            label1.Text = msg;


        }
    }
}