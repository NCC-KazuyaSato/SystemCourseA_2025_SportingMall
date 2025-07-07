using Microsoft.VisualBasic.FileIO;
using System.Text;

namespace SportingMall
{
    public class Stock : BaseMaster
    {
        /// <summary>
        ///    コンストラクタ
        /// </summary>
        public Stock()
        {
            this.MasterName = "在庫マスタ";
            this.FileName = "Stock.csv";
            this.FilePath = Path.Combine(Directory.GetCurrentDirectory(), "csv", FileName);
        }

        /// <summary>
        ///    レコードチェック+読込
        /// </summary>
        /// <param name="argProduct">商品マスタ</param>
        /// <param name="argMessage">エラーメッセージ</param>
        /// <returns>チェック結果(OK:true,NG:false)</returns>
        public bool CheckAndReadRecord(Dictionary<string, string[]> argProduct, ref string argMessage)
        {
            try
            {
                //「Shift-JIS」を利用可に設定
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                //在庫マスタ読み込み
                using (TextFieldParser parser = new TextFieldParser(this.FilePath, Encoding.GetEncoding("Shift_JIS")))
                {
                    //区切り文字設定:カンマ
                    parser.SetDelimiters(",");

                    //データ末尾に到達したら終了
                    while (parser.EndOfData == false)
                    { 
                        //1レコード読込⇒配列取得
                        string[] columns = parser.ReadFields();

                        //データチェック
                        if ((columns.Length.Equals(3) == false)
                           || (columns[0].Length.Equals(4) == false)
                           || (CheckNumeric(columns[0]) == false)
                           || (CheckNumeric(columns[2]) == false)
                           || (argProduct.ContainsKey(columns[1]) == false)
                           || (int.Parse(columns[2]) < 0 == true)
                           || (int.Parse(columns[2]) > 9999 == true))
                        {
                            //エラーメッセージ設定
                            argMessage = string.Format(MessageResource.ERR003, this.MasterName, parser.LineNumber - 1, string.Join(",", columns));

                            //チェック結果:NG
                            return false;
                        }

                        //レコード追加
                        this.Record.Add($"{columns[0]}{columns[1]}", columns);
                    }
                }

                //チェック結果:OK
                return true;
            }
            catch
            {
                // 呼び出し元に例外エラーを渡す
                throw;
            }
        }

        /// <summary>
        ///    マスタファイル書き換え
        /// </summary>
        public void UpdateFile()
        {
            try
            {
                //一時ファイルパス
                string tempPath = Path.Combine(Directory.GetCurrentDirectory(), "csv", "temp.csv");

                //「Shift-JIS」を利用可に設定
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                //一時ファイルに出力
                using (StreamWriter stream = new StreamWriter(tempPath, true, Encoding.GetEncoding("Shift_JIS")))
                {
                    //メモリ上に記憶されてる在庫マスタを1件ずつ出力
                    foreach (string key in this.Record.Keys)
                    {
                        stream.WriteLine(string.Join(",", this.Record[key]));
                    }
                }

                //古いマスタファイル削除
                File.Delete(this.FilePath);

                //一時ファイルをマスタファイルの名前に変更
                File.Move(tempPath, this.FilePath);

                //一時ファイル削除
                File.Delete(tempPath);
            }
            catch
            {
                // 呼び出し元に例外エラーを渡す
                throw;
            }
        }
    }
}
