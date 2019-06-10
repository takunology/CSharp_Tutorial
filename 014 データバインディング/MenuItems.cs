using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace _014_データバインディング
{
    class MenuItems
    {
        //連想配列で要素の型を定義
        public Dictionary<string, string> Item { get; set; }

        public void Initialize()
        {
            var mainwindow = (MainWindow)App.Current.MainWindow;

            Item = new Dictionary<string, string>()
            {
                { "A", "A定食" },
                { "B", "B定食" },
                { "C", "C定食" },
                { "D", "ラーメンセット" },
                { "E", "おにぎりセット"}
            };
            mainwindow.DataContext = this;
        }

        public void MenuA()
        {
            var mainwindow = (MainWindow)App.Current.MainWindow;

            //データバインディングをインスタンス化する
            //XAMLのバインディングターゲット・プロパティに接続するのに必要
            Binding Binding_Staple = new Binding();
            //バインディングのオブジェクトを設定する
            //Sourceはバインディングしたいデータを設定することができる
            Binding_Staple.Source = "ごはん";
            //設定したバインディングデータを適用させる
            //バインディングをセットする -> (バインディングターゲット先, バインディングプロパティ(データ))
            mainwindow.textblock_staple.SetBinding(TextBlock.TextProperty, Binding_Staple);

            Binding Binding_Main = new Binding();
            Binding_Main.Source = "ハンバーグ";
            mainwindow.textblock_main.SetBinding(TextBlock.TextProperty, Binding_Main);

            Binding Binding_Soup = new Binding();
            Binding_Soup.Source = "味噌汁";
            mainwindow.textblock_soup.SetBinding(TextBlock.TextProperty, Binding_Soup);
        }

        public void MenuB()
        {
            var mainwindow = (MainWindow)App.Current.MainWindow;

            Binding Binding_Staple = new Binding();
            Binding_Staple.Source = "ごはん";
            mainwindow.textblock_staple.SetBinding(TextBlock.TextProperty, Binding_Staple);

            Binding Binding_Main = new Binding();
            Binding_Main.Source = "サバの味噌煮";
            mainwindow.textblock_main.SetBinding(TextBlock.TextProperty, Binding_Main);

            Binding Binding_Soup = new Binding();
            Binding_Soup.Source = "味噌汁";
            mainwindow.textblock_soup.SetBinding(TextBlock.TextProperty, Binding_Soup);
        }

        public void MenuC()
        {
            var mainwindow = (MainWindow)App.Current.MainWindow;

            Binding Binding_Staple = new Binding();
            Binding_Staple.Source = "チャーハン";
            mainwindow.textblock_staple.SetBinding(TextBlock.TextProperty, Binding_Staple);

            Binding Binding_Main = new Binding();
            Binding_Main.Source = "餃子";
            mainwindow.textblock_main.SetBinding(TextBlock.TextProperty, Binding_Main);

            Binding Binding_Soup = new Binding();
            Binding_Soup.Source = "中華スープ";
            mainwindow.textblock_soup.SetBinding(TextBlock.TextProperty, Binding_Soup);
        }

        public void Ramen()
        {
            var mainwindow = (MainWindow)App.Current.MainWindow;

            Binding Binding_Staple = new Binding();
            Binding_Staple.Source = "醤油ラーメン";
            mainwindow.textblock_staple.SetBinding(TextBlock.TextProperty, Binding_Staple);

            Binding Binding_Main = new Binding();
            Binding_Main.Source = "春巻き";
            mainwindow.textblock_main.SetBinding(TextBlock.TextProperty, Binding_Main);

            Binding Binding_Soup = new Binding();
            Binding_Soup.Source = "なし";
            mainwindow.textblock_soup.SetBinding(TextBlock.TextProperty, Binding_Soup);
        }

        public void RiceBall()
        {
            var mainwindow = (MainWindow)App.Current.MainWindow;

            Binding Binding_Staple = new Binding();
            Binding_Staple.Source = "鮭おにぎり, 梅おにぎり";
            mainwindow.textblock_staple.SetBinding(TextBlock.TextProperty, Binding_Staple);

            Binding Binding_Main = new Binding();
            Binding_Main.Source = "唐揚げ, 卵焼き";
            mainwindow.textblock_main.SetBinding(TextBlock.TextProperty, Binding_Main);

            Binding Binding_Soup = new Binding();
            Binding_Soup.Source = "豚汁";
            mainwindow.textblock_soup.SetBinding(TextBlock.TextProperty, Binding_Soup);
        }

    }
}
