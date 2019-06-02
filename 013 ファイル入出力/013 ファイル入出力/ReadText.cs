using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _013_ファイル入出力
{
    class ReadText //読み込みクラス
    {
        public void Read(string FileName)
        {
            string filename = FileName + ".txt";

            if (filename == ".txt")
            {
                MessageBox.Show("ファイル名が空白です", "ファイル保存", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                //読み込みは StreamReader クラスを用いる
                //引数には読み込むファイル名とエンコードが必要
                StreamReader streamReader = new StreamReader(filename, Encoding.UTF8);

                var mainWindow = (MainWindow)App.Current.MainWindow;

                //読み込む前に初期化しておく
                mainWindow.readtext.Content = "";
                try
                {
                    while (streamReader.EndOfStream == false)
                    {
                        string text = streamReader.ReadLine();
                        mainWindow.readtext.Content += text + "\n";
                    }

                    MessageBox.Show(filename + " の読み込みが完了しました。", "ファイル読み込み", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("他のアプリがファイルを開いています", "ファイルエラー", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                streamReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ファイルが見つかりませんでした", "ファイルエラー", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
