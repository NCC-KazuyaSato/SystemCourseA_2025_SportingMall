using Microsoft.VisualBasic.FileIO;
using System.Text;

namespace SportingMall
{
    /// <summary>
    ///    商品マスタクラス
    /// </summary>
    public class Product : BaseMaster
    {
        /// <summary>
        ///    コンストラクタ
        /// </summary>
        public Product()
        {
            this.MasterName = "商品マスタ";
            this.FileName = "Product.csv";
            this.FilePath = Path.Combine(Directory.GetCurrentDirectory(), "csv", FileName);
        }

        /// <summary>
        ///   レコードチェック+読込
        /// </summary>
        /// <param name="argMessage">エラーメッセージ</param>
        /// <returns>チェック結果(OK:true,NG:false)</returns>
        public bool CheckAndReadRecord(ref string argMessage)
        {
            try
            {
                //「Shift-JIS」を利用可に設定
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                //商品マスタ読み込み
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
                           || (columns[0].Length.Equals(5) == false)
                           || (columns[2].Length > 8 == true)
                           || (CheckNumeric(columns[0]) == false)
                           || (CheckNumeric(columns[2]) == false))
                        {
                            //エラーメッセージ設定
                            argMessage = string.Format(MessageResource.ERR003, this.MasterName, parser.LineNumber - 1, string.Join(",", columns));
                            
                            //チェック結果:NG
                            return false;
                        }

                        //レコード追加
                        this.Record.Add(columns[0], columns);
                    }
                }

                //チェック結果:OK
                return true;
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
        }
    }
}
