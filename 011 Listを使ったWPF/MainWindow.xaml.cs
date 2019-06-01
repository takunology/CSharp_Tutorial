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
        ArrayConfig ac = new ArrayConfig();

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

            for (int i = 0; i < count_elements; i++)
            {
                data.Add("ほげほげ");
            }

            MessageBox.Show(count_elements + " 回目" + "内容 = " + data.ToString());
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

            mainWindow.array.Content = "要素数 : " + count_elements.ToString();
        }
    }

    public class ArrayConfig
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
