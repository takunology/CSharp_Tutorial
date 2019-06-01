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
        Array a = new Array();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_list(object sender, RoutedEventArgs e)
        {
            //List を使った配列の宣言
            //配列と違って要素数を指定しなくてもよい
            List<string> data = new List<string>();


            
        }

        private void Button_up(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;

            mainWindow.array.Content = "要素数 : " + a.add_count();
        }

        private void Button_down(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;

            mainWindow.array.Content = "要素数 : " + a.sub_count();
        }
    }

    public class Array
    {
        int array = 0;

        public int add_count()
        {
            return array = array + 1;
        }

        public int sub_count()
        {
            if(array <= 0)
            {
                MessageBox.Show("0より小さい値は無効です。");
                return array;
            }
            return array = array - 1;
        }
    }
}
