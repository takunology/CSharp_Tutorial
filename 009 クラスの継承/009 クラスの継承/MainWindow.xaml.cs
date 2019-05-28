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

namespace _009_クラスの継承
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Show_Student_Data ssd = new Show_Student_Data();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Show(object sender, RoutedEventArgs e)
        {
            ssd.Show();
        }

        private void Button_Write(object sender, RoutedEventArgs e)
        {
            ssd.Write();
        }

        private void Text_NumOnlyInput(object sender, TextCompositionEventArgs e)
        {
            //入力できる値を0～9までにする
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void Text_NumOnlyExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            //貼り付け(ペースト)による数値以外の入力を拒否
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }

    }

    public class Show_Student_Data : Student //Studentを継承
    {
        //親クラスのインスタンス化
        Student student = new Student();

        public void Show()
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;

            //親クラスの表示メソッドを呼び出す
            //ラベルにデータを表示する
            mainWindow.show_data.Content = "=== 開示データ ===\n";
            mainWindow.show_data.Content += student.Student_Show();
        }

        public void Write()
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;

            string name = mainWindow.Name_box.Text;
            int grade = int.Parse(mainWindow.Grade_box.Text);
            int number = int.Parse(mainWindow.Number_box.Text);
            
            //親クラスの書き込みメソッドを呼び出す
            student.Student_Write(grade, number, name);

            MessageBox.Show("書き込みました。");
        }
    }
}
