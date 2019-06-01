using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _012_エラーと例外処理
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //各クラスをインターフェースでインスタンス化
        ArrayCount arrayCount = new ArrayCount();
        DataCount dataCount = new DataCount();

        //用意する配列要素数
        int array_counter = 0;
        //書き込むデータの数
        int data_counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ArrayUp_Button(object sender, RoutedEventArgs e)
        {
            array_counter = arrayCount.Add();
            array_label.Content = array_counter.ToString();
        }

        private void ArrayDown_Button(object sender, RoutedEventArgs e)
        {
            array_counter = arrayCount.Sub();
            array_label.Content = array_counter.ToString();
        }

        private void DataUp_Button(object sender, RoutedEventArgs e)
        {
            data_counter = dataCount.Add();
            data_label.Content = data_counter.ToString();
        }

        private void DataDown_Button(object sender, RoutedEventArgs e)
        {
            data_counter = dataCount.Sub();
            data_label.Content = data_counter.ToString();
        }

        private void Accept_Button(object sender, RoutedEventArgs e)
        {
            int[] array = new int[array_counter];

            MessageBox.Show("確保された要素数 : " + array_counter + "\n" + "データ数 : " + data_counter);

            for (int i = 0; i < data_counter; i++)
            {
                //tryで実行する内容、catchでエラー、例外時の処理を書く
                //Exeption にしておけばあらゆる場合の例外を想定することができる
                try
                {
                    array[i] += i;

                    MessageBox.Show(i + " 番目の要素には " + array[i] * 10 + " が入っています。");
                }
                catch (Exception)
                {
                    MessageBox.Show("書き込むデータ数が配列の要素数を超えました！", "書き込みエラー", MessageBoxButton.OK, MessageBoxImage.Error);
                    MessageBox.Show("書き込むデータ数を減らすか、\n" +
                        "確保する配列の要素数を増やしてください。", "ヒント", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }
            }
        }
    }
}
