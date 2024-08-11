namespace RndArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] arrRnd = new int[4];  // �ŧi��ư}�CarrRnd�j�p��4
            SetRndNum(arrRnd, 1, 49);   // �I�sSetRndNum��k����1~49���ü�
            ShowArray(ref arrRnd);      // �I�sShowArray��k����ܰ}�C������
            Application.Exit();
        }
        
        // �ھڰ}�C�j�p����n1��n2�d�򤺪��üƭ�
        private void SetRndNum(int[] arrNum, int n1, int n2)
        {
            Random r = new Random();              // �إ�r�üƪ���
            for (int i = 0; i <= arrNum.Length - 1; i++)      // �v�@���Ͷü�
                arrNum[i] = r.Next(n1, n2 + 1);       // ����n1~n2�ü�
        }
        
        //��ܶǤJ��ư}�C����������
        private void ShowArray(ref int[] arr)
        {
            string msg = "";
            foreach (int a in arr)          // �v�@Ū���}�C������
                msg += a.ToString() + " ,"; // �N�����ȥ[�Jmsg�r�ꤤ
            MessageBox.Show(msg);
            
            msg = "";
            for (int i = 0; i <= 3; i++) 
            {
                msg += Convert.ToString(arr[i] + 10);
                msg += ",";
            }
            MessageBox.Show(msg);
        }
    }
}