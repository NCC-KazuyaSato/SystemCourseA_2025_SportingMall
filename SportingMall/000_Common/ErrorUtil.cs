
namespace SportingMall
{
    static class ErrorUtil
    {
        /// <summary>
        ///    エラーメッセージ表示
        /// </summary>
        /// <param name="argMessage">メッセージ内容</param>
        static public void ShowError(string argMessage)
        {
            //エラーメッセージ表示
            MessageBox.Show(argMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///    例外エラー処理
        /// </summary>
        /// <param name="argEX">例外クラス</param>
        static public void ExceptionError(Exception argEX)
        {
            //エラーログ記録
            Log.logger.Error($"{argEX.Message}\t{argEX.StackTrace}");

            //エラーメッセージ表示
            MessageBox.Show($"{argEX.Message}\nエラーログを確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
