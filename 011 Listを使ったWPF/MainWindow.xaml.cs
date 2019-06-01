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

namespace _011_Listを使ったWPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //Array クラスのインスタンス化
        //readonly はクラスに対しての書き換えを禁止
        readonly ArrayConfig ac = new ArrayConfig();

        //設定した要素数
        int count_elements = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_list(object sender, RoutedEventArgs e)
        {
            //List を使った配列の宣言
            //配列と違って要素数を指定しなくてもよい
            List<string> data = new List<string>();

            //設定した要素数の数だけ List にデータを追加
            //データの追加には Add メソッドを用いる
            for (int i = 0; i < count_elements; i++)
            {
                data.Add("データ" + (i + 1).ToString());
            }

            //設定した要素の数だけメッセージボックスに表示回数と要素N番目のデータを表示
            for (int i = 0; i < count_elements; i++)
            {
                MessageBox.Show("表示回数 : " + (i + 1).ToString() + "\n要素 " + i + " = " + data[i].ToString());
            }
        }

        private void Button_up(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;

            count_elements = ac.add_count();
            mainWindow.array.Content = "要素数 : " + count_elements.ToString();
        }

        private void Button_down(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;

            count_elements = ac.sub_count();
            mainWindow.array.Content = "要素数 : " + count_elements.ToString();
        }
    }

    public class ArrayConfig
    {
        int array = 0;

        public int add_count()
        {
            return array += 1;
        }

        public int sub_count()
        {
            if(array <= 0)
            {
                MessageBox.Show("0より小さい値は無効です。");
                return array;
            }
            return array -= 1;
        }
    }
}
