using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _012_エラーと例外処理
{
    public class DataCount
    {
        int data_count = 0;

        public int Add()
        {
            return data_count += 1;
        }

        public int Sub()
        {
            if (data_count <= 0)
            {
                MessageBox.Show("0 より小さい値にできません。");
                return data_count;
            }

            return data_count -= 1;
        }
    }
}
