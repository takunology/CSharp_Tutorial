using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _012_エラーと例外処理
{
    public class ArrayCount
    {
        int array_count = 0;

        public int Add()
        {
            return array_count += 1;
        }

        public int Sub()
        {
            if (array_count <= 0)
            {
                MessageBox.Show("0 より小さい値にできません。");
                return array_count;
            }

            return array_count -= 1;
        }
    }
}
