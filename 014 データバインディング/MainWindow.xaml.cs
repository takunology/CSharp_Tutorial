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

namespace _014_データバインディング
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuItems menuItems = new MenuItems();
        bool IsCheck = false;

        public MainWindow()
        {
            InitializeComponent();
            menuItems.Initialize();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Menu.Text)
            {
                case "A定食":
                    menuItems.MenuA();
                    break;

                case "B定食":
                    menuItems.MenuB();
                    break;

                case "C定食":
                    menuItems.MenuC();
                    break;

                case "ラーメンセット":
                    menuItems.Ramen();
                    break;

                case "おにぎりセット":
                    menuItems.RiceBall();
                    break;

                default:
                    break;
            }
            IsCheck = true;
        }

        private void Order_Button(object sender, RoutedEventArgs e)
        {
            if(IsCheck == true)
            {
                MessageBox.Show(Menu.Text + "のご注文ありがとうございます");
            }
            else
            {
                MessageBox.Show("メニューを見ずに注文するんですか？");
            }
        }
    }

}
