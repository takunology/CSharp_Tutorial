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

namespace _013_ファイル入出力
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filename;
        string texts;

        public MainWindow()
        {
            InitializeComponent();
        }

        //新規作成
        private void Write_Button(object sender, RoutedEventArgs e)
        { 
            //新規書き込みクラスのインスタンス化
            TextWrite textWrite = new TextWrite();

            filename = WriteFileName.Text.ToString();
            texts = textbox.Text.ToString();

            textWrite.Write(filename, texts);
        }

        //追記
        private void Add_Button(object sender, RoutedEventArgs e)
        {
            //上書きクラスのインスタンス化
            AddWrite addWrite = new AddWrite();

            filename = WriteFileName.Text.ToString();
            texts = textbox.Text.ToString();

            addWrite.Write(filename, texts);
        }

        //読み込み
        private void Read_Button(object sender, RoutedEventArgs e)
        {
            //読み込みクラスのインスタンス化
            ReadText readText = new ReadText();

            filename = ReadFileName.Text.ToString();

            readText.Read(filename);
        }
    }
}
