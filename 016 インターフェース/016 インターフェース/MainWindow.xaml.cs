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

namespace _016_インターフェース
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

        //メソッド1つで3種類のクラスを使うインターフェース
        Place mountain = new Mountain();
        Place sea = new Sea();
        Place house = new House();

        private void Button_Mountain(object sender, RoutedEventArgs e)
        {
            Go(mountain);
        }

        private void Button_Sea(object sender, RoutedEventArgs e)
        {

        }

        private void Button_House(object sender, RoutedEventArgs e)
        {

        }

        public void Go(Place place)
        {
            MessageBox.Show($"{place.Go().ToString()} + へ行った");
        }

        public interface Place //各クラスをくっつける接着剤
        {
            string Go();
        }

        public class Mountain : Place
        {
            public string Go()
            {
                return "山へお出かけ";
            }
        }

        public class Sea : Place
        {
            public string Go()
            {
                return "海へお出かけ";
            }
        }

        public class House : Place
        {
            public string Go()
            {
                return "家でゴロゴロ";
            }
        }
    }
}
