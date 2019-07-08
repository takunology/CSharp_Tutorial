using System.Windows;

namespace _015_アクセシビリティ
{
    class Human
    {
        // 直接ユーザからいじられないように保護する
        private int 身長;
        private int 体重;
        private int 年齢;
        private string 名前;

        public int isInt = 0; //int型かどうかの判定後に代入

        // ここにユーザからのデータを入力してもらう
        // 特に返り値はないので void 
        public void 身長入力(string value)
        {
            bool result = int.TryParse(value, out isInt);
            if (result == true)
            {
                this.身長 = isInt;
            }
            else
            {
                MessageBox.Show("整数を入力してください");
            }
        }

        public void 体重入力(string value)
        {
            bool result = int.TryParse(value, out isInt);
            if (result == true)
            {
                this.体重 = isInt;
            }
            else
            {
                MessageBox.Show("整数を入力してください");
            }
        }

        public void 年齢入力(string value)
        {
            bool result = int.TryParse(value, out isInt);
            if (result == true)
            {
                this.年齢 = isInt;
            }
            else
            {
                MessageBox.Show("整数を入力してください");
            }
        }

        public void 名前入力(string name)
        {
            this.名前 = name;
        }

        public void 年を取る()
        {
            this.年齢 = this.年齢 + 1;
        }

        public string 表示()
        {
            return $"身長：{this.身長} \n体重：{this.体重} \n名前：{this.名前} \n年齢：{this.年齢}";
        }
    }
}
