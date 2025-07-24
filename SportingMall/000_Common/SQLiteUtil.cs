using System.Data.SQLite;
using System.Text;
using System.Data;

namespace SportingMall
{
    internal class SQLiteUtil
    {
        //DBファイルパス
        private string filePath = string.Empty;

        //DB接続用クラス
        SQLiteConnection? connection = null;

        /// <summary>
        ///    コンストラクタ
        /// </summary>
        public SQLiteUtil()
        {
            //DBファイルパスを設定
            this.filePath = Path.Combine(Directory.GetCurrentDirectory(), "DB", "SportingMall.db");

            //接続用文字列を設定
            var sqlConnStr = new SQLiteConnectionStringBuilder { DataSource = $"{this.filePath}" };

            //DB接続用クラスを設定
            connection = new SQLiteConnection(sqlConnStr.ToString());
        }

        /// <summary>
        ///    ログイン認証
        /// </summary>
        /// <param name="argMemberCode">会員番号</param>
        /// <param name="argPassWord">パスワード</param>
        public bool Login(string argMemberCode, string argPassWord)
        {
            try
            {
                //DB接続
                this.connection.Open();

                using (var cmd = new SQLiteCommand(this.connection))
                {
                    //SQL定義
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT ");
                    sql.Append("    COUNT(MemberCode) AS Cnt, ");
                    sql.Append("    printf('%08d', MemberCode) AS MemberCode, ");
                    sql.Append("    Name, ");
                    sql.Append("    PostCode, ");
                    sql.Append("    Address, ");
                    sql.Append("    Telephone, ");
                    sql.Append("    Email, ");
                    sql.Append("    Amount, ");
                    sql.Append("    Category ");
                    sql.Append("FROM ");
                    sql.Append("    Member ");
                    sql.Append("WHERE ");
                    sql.Append("    MemberCode = @code ");
                    sql.Append("AND ");
                    sql.Append("    PassWord = @pass ");
                    cmd.CommandText = sql.ToString();

                    //プレースホルダ設定
                    cmd.Parameters.Add(new SQLiteParameter("@code", argMemberCode));
                    cmd.Parameters.Add(new SQLiteParameter("@pass", argPassWord));

                    //SQL実行
                    using (var reader = cmd.ExecuteReader())
                    {
                        //取得レコード読み込み
                        reader.Read();

                        //該当レコードが存在する場合は会員情報をセット
                        if (reader["Cnt"].ToString().Equals("1") == true)
                        {
                            Member.MemberCode = reader["MemberCode"].ToString();
                            Member.Name = reader["Name"].ToString();
                            Member.PostCode = reader["PostCode"].ToString();
                            Member.Address = reader["Address"].ToString();
                            Member.Telephone = reader["Telephone"].ToString();
                            Member.Amount = reader["Amount"].ToString();
                            Member.Category = reader["Category"].ToString();

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
            finally
            {
                //DB接続中であれば切断
                if (this.connection.State.Equals(ConnectionState.Open) == true)
                {
                    this.connection.Close();
                }
            }
        }

        /// <summary>
        ///    商品コンボックス設定値取得
        /// </summary>
        /// <returns>商品コンボボックスに設定する値リスト</returns>
        public List<string> GetItemList()
        {
            //戻り値格納用
            List<string> rtnItemList = new List<string>();

            try
            {
                //DB接続
                this.connection.Open();

                using (var cmd = new SQLiteCommand(this.connection))
                {
                    //SQL定義
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT ");
                    sql.Append("    ProductCode, ");
                    sql.Append("    ProductName ");
                    sql.Append("FROM ");
                    sql.Append("    Product ");
                    cmd.CommandText = sql.ToString();

                    //SQL実行
                    using (var reader = cmd.ExecuteReader())
                    {
                        //取得レコード全件読み込み
                        while (reader.Read() == true)
                        {
                            //コンボックス表示用に加工しリストに追加
                            rtnItemList.Add($"{reader["ProductCode"]} {reader["ProductName"]}");
                        }  
                    }
                }

                //戻り値を返す
                return rtnItemList;
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
            finally
            {
                //DB接続中であれば切断
                if (this.connection.State.Equals(ConnectionState.Open) == true)
                {
                    this.connection.Close();
                }
            }
        }

        /// <summary>
        ///    商品コンボックス設定値取得<br/>
        ///    (特定の商品を除外する用)
        /// </summary>
        /// <param name="argCodeList">除外対象の商品コード群(カンマ区切り)</param>
        /// <returns>商品コンボボックスに設定する値リスト</returns>
        public List<string> GetItemList(string argCodeList)
        {
            //戻り値格納用
            List<string> rtnItemList = new List<string>();

            try
            {
                //DB接続
                this.connection.Open();

                using (var cmd = new SQLiteCommand(this.connection))
                {
                    //SQL定義
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT ");
                    sql.Append("    ProductCode, ");
                    sql.Append("    ProductName ");
                    sql.Append("FROM ");
                    sql.Append("    Product ");
                    sql.Append("WHERE ");
                    sql.Append("    ProductCode ");
                    sql.Append("    NOT IN ");
                    sql.Append("    ( ");
                    sql.Append($"    {argCodeList} ");
                    sql.Append("    ) ");
                    cmd.CommandText = sql.ToString();

                    //SQL実行
                    using (var reader = cmd.ExecuteReader())
                    {
                        //取得レコード全件読み込み
                        while (reader.Read() == true)
                        {
                            //コンボックス表示用に加工しリストに追加
                            rtnItemList.Add($"{reader["ProductCode"]} {reader["ProductName"]}");
                        }
                    }
                }

                //戻り値を返す
                return rtnItemList;
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
            finally
            {
                //DB接続中であれば切断
                if (this.connection.State.Equals(ConnectionState.Open) == true)
                {
                    this.connection.Close();
                }
            }
        }

        /// <summary>
        ///    商品在庫数取得(一括)<br/>
        /// </summary>
        /// <param name="argProductCode">商品コード</param>
        /// <returns>全倉庫分の在庫数</returns>
        public int GetAllStock(string argProductCode)
        {
            try
            {
                //DB接続
                this.connection.Open();

                using (var cmd = new SQLiteCommand(this.connection))
                {
                    //SQL定義
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT ");
                    sql.Append("    SUM(Count) AS Cnt ");
                    sql.Append("FROM ");
                    sql.Append("    Stock ");
                    sql.Append("WHERE ");
                    sql.Append("    ProductCode = @code ");
                    sql.Append("GROUP BY ");
                    sql.Append("    ProductCode ");
                    cmd.CommandText = sql.ToString();

                    //プレースホルダ設定
                    cmd.Parameters.Add(new SQLiteParameter("@code", argProductCode));

                    //SQL実行
                    using (var reader = cmd.ExecuteReader())
                    {
                        //レコードが取得できた場合
                        if (reader.Read() == true)
                        {
                            return int.Parse(reader["Cnt"].ToString());
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
            finally
            {
                //DB接続中であれば切断
                if (this.connection.State.Equals(ConnectionState.Open) == true)
                {
                    this.connection.Close();
                }
            }
        }

        /// <summary>
        ///    商品在庫数取得(倉庫別)<br/>
        /// </summary>
        /// <param name="argProductCode">商品コード</param>
        /// <returns>各倉庫別の在庫数</returns>
        public Dictionary<string,int> GetStockList(string argProductCode)
        {
            //戻り値
            Dictionary<string, int> rtnStockList = new Dictionary<string, int>();

            try
            {
                //DB接続
                this.connection.Open();

                using (var cmd = new SQLiteCommand(this.connection))
                {
                    //SQL定義
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT ");
                    sql.Append("    StockCode, ");
                    sql.Append("    Count ");
                    sql.Append("FROM ");
                    sql.Append("    Stock ");
                    sql.Append("WHERE ");
                    sql.Append("    ProductCode = @code ");
                    sql.Append("ORDER BY ");
                    sql.Append("    StockCode ");
                    sql.Append("    ASC ");
                    cmd.CommandText = sql.ToString();

                    //プレースホルダ設定
                    cmd.Parameters.Add(new SQLiteParameter("@code", argProductCode));

                    //SQL実行
                    using (var reader = cmd.ExecuteReader())
                    {
                        //レコードが取得できた場合
                        while (reader.Read() == true)
                        {
                            rtnStockList.Add(reader["StockCode"].ToString(),int.Parse(reader["Count"].ToString()));
                        }
                    }
                }

                //戻り値を返す
                return rtnStockList;
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
            finally
            {
                //DB接続中であれば切断
                if (this.connection.State.Equals(ConnectionState.Open) == true)
                {
                    this.connection.Close();
                }
            }
        }

        /// <summary>
        ///    在庫数更新<br/>
        /// </summary>
        /// <param name="argStockCode">倉庫コード</param>
        /// <param name="argProductCode">商品コード</param>
        /// <param name="argAfterCnt">更新後在庫数</param>
        public void UpdateStock(string argStockCode, string argProductCode, int argAfterCnt)
        {
            try
            {
                //DB接続
                this.connection.Open();

                using (var cmd = new SQLiteCommand(this.connection))
                {
                    //SQL定義
                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE ");
                    sql.Append("    Stock ");
                    sql.Append("SET ");
                    sql.Append("    Count = @count ");
                    sql.Append("WHERE ");
                    sql.Append("    StockCode = @code1 ");
                    sql.Append("AND ");
                    sql.Append("    ProductCode = @code2 ");
                    cmd.CommandText = sql.ToString();

                    //プレースホルダ設定
                    cmd.Parameters.Add(new SQLiteParameter("@count", argAfterCnt));
                    cmd.Parameters.Add(new SQLiteParameter("@code1", argStockCode));
                    cmd.Parameters.Add(new SQLiteParameter("@code2", argProductCode));

                    //SQL実行
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
            finally
            {
                //DB接続中であれば切断
                if (this.connection.State.Equals(ConnectionState.Open) == true)
                {
                    this.connection.Close();
                }
            }
        }

        /// <summary>
        ///    商品単価取得<br/>
        /// </summary>
        /// <param name="argProductCode">商品コード</param>
        /// <returns>商品単価</returns>
        public int GetUnitPrice(string argProductCode)
        {
            try
            {
                //DB接続
                this.connection.Open();

                using (var cmd = new SQLiteCommand(this.connection))
                {
                    //SQL定義
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT ");
                    sql.Append("    UnitPrice ");
                    sql.Append("FROM ");
                    sql.Append("    Product ");
                    sql.Append("WHERE ");
                    sql.Append("    ProductCode = @code ");
                    cmd.CommandText = sql.ToString();

                    //プレースホルダ設定
                    cmd.Parameters.Add(new SQLiteParameter("@code", argProductCode));

                    //SQL実行
                    using (var reader = cmd.ExecuteReader())
                    {
                        //レコードが取得できた場合
                        if (reader.Read() == true)
                        {
                            return int.Parse(reader["UnitPrice"].ToString());
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
            finally
            {
                //DB接続中であれば切断
                if (this.connection.State.Equals(ConnectionState.Open) == true)
                {
                    this.connection.Close();
                }
            }
        }
    }
}
