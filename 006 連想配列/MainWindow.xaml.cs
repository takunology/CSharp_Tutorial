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

namespace _006_連想配列
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

        //連想配列にテキストボックスの情報を書き込む
        static void Array_Write()
        {
            //Textbox は MainWindow に存在するのでインスタンス化する必要がある。
            //インスタンスを取得した上でその中の TextBox を使う
            var mainWindow = (MainWindow)App.Current.MainWindow;

            //連想配列は Dictionary<> を用いる
            //<配列の名前, 配列に入れるデータ>の各型を宣言する
            var array = new Dictionary<string, string>();

            //キーを個別に保管しておくための配列(変換する)
            string[] key = new string[4];

            //値を個別に保管しておくための配列(変換する)
            string[] value = new string[4];

            //foreach を回すための初期値
            int i = 0, j = 0;

            //各要素に配列名とそこに入れるデータを参照する
            array.Add("配列1", mainWindow.Textbox0.ToString());
            array.Add("配列2", mainWindow.Textbox1.ToString());
            array.Add("配列3", mainWindow.Textbox2.ToString());
            array.Add("配列4", mainWindow.Textbox3.ToString());

            //array のキーの数だけ繰り返して、キーを個々に格納
            foreach(string Key in array.Keys)
            {
                key[i] = Key;
                i++;
            }

            //array の値の数だけ繰り返して、値を個々に格納
            foreach (string Value in array.Keys)
            {
                value[j] = Value;
                j++;
            }

            //ウィンドウの配列名のところに設定した配列名が更新される
            mainWindow.Label_array0.Content = key[0];
            mainWindow.Label_array1.Content = key[1];
            mainWindow.Label_array2.Content = key[2];
            mainWindow.Label_array3.Content = key[3];
        }

        private void Button_Write(object sender, RoutedEventArgs e)
        {
            //連想配列へ書き込む
            Array_Write();
            MessageBox.Show("書き込みました");
        }

        private void Button_Show(object sender, RoutedEventArgs e)
        { 
            MessageBox.Show("配列名 " + Label_array0.Content + " には " + Textbox0.Text + " が代入されています。");
            MessageBox.Show("配列名 " + Label_array1.Content + " には " + Textbox1.Text + " が代入されています。");
            MessageBox.Show("配列名 " + Label_array2.Content + " には " + Textbox2.Text + " が代入されています。");
            MessageBox.Show("配列名 " + Label_array3.Content + " には " + Textbox3.Text + " が代入されています。");
        }
    }
}
