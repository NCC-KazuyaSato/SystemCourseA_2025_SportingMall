using System.Text.RegularExpressions;

namespace SportingMall
{
    /// <summary>
    ///    マスタデータ基底クラス
    /// </summary>
    public class BaseMaster
    {
        /// <summary>マスタ名</summary>
        public string MasterName;

        /// <summary>ファイル名</summary>
        public string FileName;

        /// <summary>ファイルパス</summary>
        public string FilePath;

        /// <summary>レコード</summary>
        public Dictionary<string, string[]> Record = new Dictionary<string, string[]>();

        /// <summary>
        ///    ファイルチェック
        /// </summary>
        /// <param name="argMessage">エラーメッセージ</param>
        /// <returns>チェック結果(OK:true,NG:false)</returns>
        public bool CheckFile(ref string argMessage)
        {
            //ファイル存在チェック
            if (File.Exists(this.FilePath) == false)
            {
                //エラーメッセージを設定
                argMessage = string.Format(MessageResource.ERR001, this.MasterName);

                //チェック結果:NG
                return false;
            }
            //空ファイルチェック
            else if (new FileInfo(this.FilePath).Length == 0)
            {
                //エラーメッセージを設定
                argMessage = string.Format(MessageResource.ERR002, this.MasterName);

                //チェック結果:NG
                return false;
            }

            //チェック結果:OK
            return true;
        }

        /// <summary>
        ///    半角数値チェック
        /// </summary>
        /// <param name="argValue">チェックする値</param>
        /// <returns>チェック結果(OK:true,NG:false)</returns>
        public bool CheckNumeric(string argValue)
        {
            return Regex.IsMatch(argValue, @"^[0-9]+$");
        }
    }
}
