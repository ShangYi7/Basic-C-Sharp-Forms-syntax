using System.Globalization;
using System.IO;              //�ޥ�System.IO�R�W�Ŷ�
namespace MoveDir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string sourceDir = @"c:\aaa";
            DirectoryInfo sdInfo = new DirectoryInfo(sourceDir);
            string msg;
            if (sdInfo.Exists)               // �Y���w���ӷ��ؿ����|�s�b
                msg = " �ؿ��w�s�b�I";
            else                         // ����w���ӷ��ؿ����|���s�b
            {
                sdInfo.Create();             // �إߨӷ��ؿ����|
                msg = " �ؿ��إߦ��\�I";
            }
            MessageBox.Show($"{sourceDir}{msg}", "CreateDir");
            
            string destDir = @"c:\bbb";
            DirectoryInfo destInfo = new DirectoryInfo(destDir);
            if (destInfo.Exists)             // �Y���w���ت��ؿ����|�s�b
                destInfo.Delete(true);       // �R���ت��ؿ����|
            sdInfo.MoveTo(destDir);
            msg = $"�ӷ��ؿ����e�w���\�h���� {destDir} �ؿ��I";
            MessageBox.Show(msg, "MoveDir");*/
            string sourceDir = @"C:\�����˩w���ɮ�\�D�� 02";
            DirectoryInfo destInfo = new DirectoryInfo(sourceDir);
            if (destInfo.Exists)               // �Y���w���ӷ��ؿ����|�s�b
                destInfo.Delete(true);
        }
    }
}