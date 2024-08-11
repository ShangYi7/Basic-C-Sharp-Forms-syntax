using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Student
    {
        public string Name { get; set; }   // Name 屬性採存取子自動實作
        private int _score = 0;            // _score成績欄位宣告為private
        public int Score        // 建立Score屬性，此屬性值限制在0-100
        {
            get { return _score; }
            set
            {
                if (value >= 100) value = 100;
                else if (value >= 60 && value <= 99) value = 60;
                else if (value <= 0) value = 0;
                _score = value;
            }
        }
        public void ShowMsg()
        {
            MessageBox.Show($"{Name} 同學的分數是 {Score}");
        }
    }
}
