using System.Windows;

namespace _015_アクセシビリティ
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //クラスをインスタンス化(実体化)
        Human human = new Human();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void 登録(object sender, RoutedEventArgs e)
        {
            // Human クラスの public メソッドへアクセス
            human.身長入力(height.Text);
            human.体重入力(weight.Text);
            human.年齢入力(age.Text);
            human.名前入力(name.Text);

            MessageBox.Show("人間データを登録しました");
        }

        private void 年をとる(object sender, RoutedEventArgs e)
        {
            // Human クラスの年を取るメソッドを実行
            // 引数はテキストボックスから得た値
            human.年を取る();
            MessageBox.Show("あれから1年が経った...");
        }

        private void 情報開示(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(human.表示());
        }
    }
}
