using System.Windows;

namespace _005_一次元配列
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //配列は[]で囲み、newで初期化
            //4は要素の数を指定している
            string[] data = new string[4];
            
            data[0] = msg1.ToString();
            data[1] = msg2.ToString();
            data[2] = msg3.ToString();
            data[3] = "配列データ4つ目はロジック側で設定してみた！";

            //配列名.Length は配列の要素数を返す
            //要素数の数だけ繰り返す
            for(int i = 0; i < data.Length; i++)
            {
                MessageBox.Show(data[i]);
            }

        }
    }
}
