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

namespace _003_条件分岐
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
            //結果保存用変数
            string select;

            //ラジオボタンは x:Name で参照できるようにする。
            //IsChecked プロパティで選択されているかを比較する。
            //選択されている -> true , 選択されていない -> false
            if(Iemon.IsChecked == true)
            {
                select = "伊右衛門";   
            }
            else if(Ayataka.IsChecked == true)
            {
                select = "綾鷹";
            }
            else if(Souken.IsChecked == true)
            {
                select = "爽健美茶";
            }
            else if(Kuro.IsChecked == true)
            {
                select = "黒烏龍茶";
            }
            else
            {
                select = "どれでもない";
            }

            //文字列連結関数にラジオボタンによる条件分岐をなげる
            //連結させた文字列を受け取って表示
            MessageBox.Show(ans(select));
        }

        //文字列を連結する関数
        string ans(string s)
        {
            string select = s;

            return "選ばれたのは " + s + " です。";
        }
    }
}
