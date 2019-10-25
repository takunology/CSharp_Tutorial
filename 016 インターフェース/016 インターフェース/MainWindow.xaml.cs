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

        Sea sea = new Sea();
        Mountain mountain = new Mountain();
        House house = new House();
        //Place place = new Place();

        private void Button_Mountain(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Sea(object sender, RoutedEventArgs e)
        {

        }

        private void Button_House(object sender, RoutedEventArgs e)
        {

        }

        public interface Place
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
