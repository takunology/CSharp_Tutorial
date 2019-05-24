using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace _004_繰り返し
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

        //テキストボックスのイベントハンドラをそれぞれ追加
        //InputMethod.IsInputMethodEnabled = "false" でIMEを無効にする
        //PreviewTextInput = "メソッド名" 入力による制約をロジック側で設定できる
        //CommandManager.PreviewExecuted = "メソッド名"　コマンド実行(コピペなど)による制約をロジック側で設定できる
        private void Text_NumOnlyInput (object sender, TextCompositionEventArgs e)
        {
            //入力できる値を0～9までにする
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void Text_NumOnlyExecuted (object sender, ExecutedRoutedEventArgs e)
        {
            //貼り付け(ペースト)による数値以外の入力を拒否
            if(e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = int.Parse(textbox.Text);

            for (int i = 1; i <= count; i++)
            {
                MessageBox.Show("現在 " + i.ToString() + " 回目です。");
            }
        }

    }
}
