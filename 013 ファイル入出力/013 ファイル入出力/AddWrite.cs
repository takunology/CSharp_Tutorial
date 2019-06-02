using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _013_ファイル入出力
{
    class AddWrite //追記クラス
    {
        public void Write(string FileName, string gettext)
        {
            string filename = FileName + ".txt";
            string text = gettext;

            if (filename == ".txt")
            {
                MessageBox.Show("ファイル名が空白です", "ファイル保存", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                try
                {
                    //追記するファイルが存在するかを確認
                    //存在すればストリームを閉じて処理を続ける
                    StreamReader streamReader = new StreamReader(filename, Encoding.UTF8);
                    streamReader.Close();
                }
                catch
                {
                    //追記するファイルが存在しなかった場合
                    MessageBox.Show("追記するファイルが見つかりません", "ファイルエラー", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            try
            {
                //書き込みには StreamWriter クラスを使う
                //引数には書き込むファイル名、追記の有無、エンコードを入力
                //true にしておくと追記モードになる
                StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.UTF8);

                //WriteLine メソッドは改行付き書き込み
                streamWriter.WriteLine(text);

                //ファイルを使ったら閉じましょう
                streamWriter.Close();

                MessageBox.Show(filename + " に追記しました", "ファイル追記", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("他のアプリがファイルを開いています", "ファイルエラー", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
