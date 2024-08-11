using System.Globalization;
using System.IO;              //引用System.IO命名空間
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
            if (sdInfo.Exists)               // 若指定的來源目錄路徑存在
                msg = " 目錄已存在！";
            else                         // 當指定的來源目錄路徑不存在
            {
                sdInfo.Create();             // 建立來源目錄路徑
                msg = " 目錄建立成功！";
            }
            MessageBox.Show($"{sourceDir}{msg}", "CreateDir");
            
            string destDir = @"c:\bbb";
            DirectoryInfo destInfo = new DirectoryInfo(destDir);
            if (destInfo.Exists)             // 若指定的目的目錄路徑存在
                destInfo.Delete(true);       // 刪除目的目錄路徑
            sdInfo.MoveTo(destDir);
            msg = $"來源目錄內容已成功搬移到 {destDir} 目錄！";
            MessageBox.Show(msg, "MoveDir");*/
            string sourceDir = @"C:\丙級檢定用檔案\題組 02";
            DirectoryInfo destInfo = new DirectoryInfo(sourceDir);
            if (destInfo.Exists)               // 若指定的來源目錄路徑存在
                destInfo.Delete(true);
        }
    }
}