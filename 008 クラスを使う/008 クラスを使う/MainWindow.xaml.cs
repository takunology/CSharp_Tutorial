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

namespace _008_クラスを使う
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Car_Show_Button(object sender, RoutedEventArgs e)
        {
            //クラスをインスタンス化(実体化)する
            Car car = new Car();
            //Car クラスの Show メソッドを呼び出す
            car.Show();
        }

        private void Human_Show_Button(object sender, RoutedEventArgs e)
        {
            Human human = new Human();
            human.Show();
        }
    }

    //アクセス可能な車クラス
    public class Car
    {
        int[] data = new int[4];

        //データを外部からいじらせないように private をつける
        //データをいじれるのは同じクラス内のみになる
        private void Info()
        {
            data[0] = 100; //馬力
            data[1] = 1200; //排気量
            data[2] = 900; //重量
            data[3] = 180; //最高速度
        }

        public void Show()
        {
            //Info 関数で各データを初期化しておく
            Info();

            var mainWindow = (MainWindow)App.Current.MainWindow;

            mainWindow.data_text.Text = ("=== 車クラスの情報について ===\n");
            mainWindow.data_text.Text += ("馬力 = " + data[0] + " [ps]\n");
            mainWindow.data_text.Text += ("排気量 = " + data[1] + " [cc]\n");
            mainWindow.data_text.Text += ("重量 = " + data[2] + " [kg]\n");
            mainWindow.data_text.Text += ("最高速度 = " + data[3] + " [km/h]\n");
        }
    }

    //アクセス可能な人間クラス
    public class Human
    {
        int[] data = new int[4];
        string name;

        private void Info()
        {
            name = "ほげ";

            data[0] = 20; //年齢
            data[1] = 170; //身長
            data[2] = 55; //体重
        }

        public void Show()
        {
            //Info 関数で各データを初期化しておく
            Info();

            var mainWindow = (MainWindow)App.Current.MainWindow;

            mainWindow.data_text.Text = ("=== 人間クラスの情報について ===\n");
            mainWindow.data_text.Text += ("名前 = " + name + "\n");
            mainWindow.data_text.Text += ("年齢 = " + data[0] + " 歳\n");
            mainWindow.data_text.Text += ("身長 = " + data[1] + " [cm]\n");
            mainWindow.data_text.Text += ("体重 = " + data[2] + " [kg]\n");
        }
    }
}
