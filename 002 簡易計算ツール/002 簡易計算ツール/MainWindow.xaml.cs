using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _002_簡易計算ツール
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

        int add(int x, int y)
        {
            return x + y;
        }

        int sub(int x, int y)
        {
            return x - y;
        }

        int app(int x, int y)
        {
            return x * y;
        }

        int div(int x, int y)
        {
            return x / y;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            //int型に変換する -> int.Parse() メソッド(関数)
            int x = int.Parse(textbox1.Text);
            int y = int.Parse(textbox2.Text);

            //add関数にtextboxの値を渡す
            //add関数(加算関数)から受け取った値(return)を ans 変数に格納
            int ans = add(x, y);

            //Messagebox は文字列型なので .ToString() メソッドで変換
            MessageBox.Show("答えは " + ans.ToString() + " です。");
            
        }

        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(textbox1.Text);
            int y = int.Parse(textbox2.Text);

            int ans = sub(x, y);

            MessageBox.Show("答えは " + ans.ToString() + " です。");
        }

        private void Button_App(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(textbox1.Text);
            int y = int.Parse(textbox2.Text);

            int ans = app(x, y);

            MessageBox.Show("答えは " + ans.ToString() + " です。");
        }

        private void Button_Div(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(textbox1.Text);
            int y = int.Parse(textbox2.Text);

            int ans = div(x, y);

            MessageBox.Show("答えは " + ans.ToString() + " です。");
        }
    }
}
