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

namespace _007_二次元配列
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
            //二次元配列を使う場合は [,] カンマで区切る
            //配列要素数は1次元目と2次元目をカンマで区切って指定する
            int[ , ] num = new int[32, 32];

            var mainWindow = (MainWindow)App.Current.MainWindow;
            
            for(int i = 1; i <= 30; i++)
            {
                for(int j = 1; j <= 30; j++)
                {
                    num[i, j] = i * j;
                    
                    //文字列の幅を合わせるのに string.Format() を用いる
                    // {0, 4} で４文字区切り
                    mainWindow.view.Text += string.Format("{0,4}", num[i, j].ToString());

                    //VisualStudio のデバッグ
                    Console.Write("{0,4}", num[i, j].ToString());
                }
                mainWindow.view.Text += "\n";
                Console.WriteLine();

            }
        }
    }
}
