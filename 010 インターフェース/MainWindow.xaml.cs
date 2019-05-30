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

namespace _010_インターフェース
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //山に関するクラスをインターフェースで使う
        Vacation mountain = new Mountain();
        //海に関するクラスをインターフェースで使う
        Vacation sea = new Sea();
        //家に関するクラスをインターフェースで使う
        Vacation house = new House();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_place(object sender, RoutedEventArgs e)
        {
            if (mountain_check.IsChecked == true)
            {
                //Play メソッドに mountain で初期化した Vacation インスタンス mountain  を代入
                Play(mountain);
            }
            else if (sea_check.IsChecked == true)
            {
                Play(sea);
            }
            else
            {
                Play(house);
            }

        }

        //各クラスで初期化されたインスタンスが引数になる
        //このとき、place に代入されたインスタンスを元に Vacation を呼ぶ
        //Vacation は各クラスとつながっているので、place を元にそのクラスを呼ぶ
        public void Play(Vacation place)
        {
            //play_place メソッドは Vacation で共通メソッド
            //指定されたクラスの返り値(string型)が返ってくる
            MessageBox.Show(place.play_place() + " で遊ぶ！");
        }
    }

    //インターフェースはクラスとクラスをつなぐ役割
    //クラスAとクラスBの共通処理(メソッド)をまとめておける
    //変数の値を保持するのでインスタンスを作成できない
    public interface Vacation
    {
        string play_place();
    }

    public class Mountain : Vacation
    {
        public string play_place()
        {
            return "山";
        }
    }

    public class Sea : Vacation
    {
        public string play_place()
        {
            return "海";
        }
    }

    public class House : Vacation
    {
        public string play_place()
        {
            return "家";
        }
    }

}