using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_クラスの継承
{
    public class Student
    {
        int grade; //学年
        int number; //番号
        string name; //名前

        //書き込み用メソッド
        public void Student_Write(int x, int y, string s)
        {
            grade = x;
            number = y;
            name = s;
        }

        //文字列のかたまりを返り値にする
        public string Student_Show()
        {
            return " 名前 " + name + "\n 学年 " + grade.ToString()
                        + "\n 番号 " + number.ToString();
        }
    }
}
