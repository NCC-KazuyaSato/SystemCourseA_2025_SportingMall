
namespace SportingMall
{
    /// <summary>
    ///    商品購入画面クラス
    /// </summary>
    public partial class ORDER : Form
    {
        /// <summary>会員マスタ</summary>
        private Member Member;

        /// <summary>商品マスタ</summary>
        private Product Product;

        /// <summary>在庫マスタ</summary>
        private Stock Stock;

        /// <summary>注文情報リスト</summary>
        private List<OrderInfo> OrderInfoList = new List<OrderInfo>();

        /// <summary>
        ///    コンストラクタ
        /// </summary>
        public ORDER()
        {
            //画面初期化
            InitializeComponent();

            //マスタクラス定義
            this.Member = new Member();
            this.Product = new Product();
            this.Stock = new Stock();

            //注文情報クラス定義⇒リスト追加
            this.OrderInfoList.Add(new OrderInfo(cbxItem1, nudItem1));
            this.OrderInfoList.Add(new OrderInfo(cbxItem2, nudItem2));
            this.OrderInfoList.Add(new OrderInfo(cbxItem3, nudItem3));
            this.OrderInfoList.Add(new OrderInfo(cbxItem4, nudItem4));
            this.OrderInfoList.Add(new OrderInfo(cbxItem5, nudItem5));
            this.OrderInfoList.Add(new OrderInfo(cbxItem6, nudItem6));
            this.OrderInfoList.Add(new OrderInfo(cbxItem7, nudItem7));
            this.OrderInfoList.Add(new OrderInfo(cbxItem8, nudItem8));
            this.OrderInfoList.Add(new OrderInfo(cbxItem9, nudItem9));
            this.OrderInfoList.Add(new OrderInfo(cbxItem10, nudItem10));
        }

        /// <summary>
        ///    商品購入画面起動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ORDER_Load(object sender, EventArgs e)
        {
            try
            {
                //エラーメッセージ
                string errMessage = string.Empty;

                //マスタファイルチェック+読込
                foreach (var master in new BaseMaster[] { this.Product, this.Stock })
                {
                    //ファイルチェック
                    if (master.CheckFile(ref errMessage) == false)
                    {
                        //エラーメッセージを表示
                        ShowError(errMessage);

                        //画面を閉じる
                        this.Close();
                    }
                }

                //商品マスタレコードチェック+読込
                if (this.Product.CheckAndReadRecord(ref errMessage) == false)
                {
                    //エラーメッセージを表示
                    ShowError(errMessage);

                    //画面を閉じる
                    this.Close();
                }

                //在庫マスタレコードチェック+読込
                if (this.Stock.CheckAndReadRecord(this.Product.Record, ref errMessage) == false)
                {
                    //エラーメッセージを表示
                    ShowError(errMessage);

                    //画面を閉じる
                    this.Close();
                }

                //請求先区分の初期値を設定:未選択
                this.cbxBillType.SelectedIndex = 0;

                //希望日時の最小値を設定:現在日付
                this.dtpDeadLine.MinDate = DateTime.Now;

                //希望日時の初期値を設定:現在日付から1週間後
                this.dtpDeadLine.Value = DateTime.Now.AddDays(7);
 
                //商品名コンボックスを順番(1～10)に設定
                foreach (OrderInfo order in this.OrderInfoList)
                {
                    //初期値用の空文字をコンボックスに追加
                    order.CmbName.Items.Add(string.Empty);

                    //商品マスタを全件読み込み
                    foreach (string[] columns in this.Product.Record.Values)
                    {
                        //コンボックスに追加
                        order.CmbName.Items.Add($"{columns[0]} {columns[1]}");
                    }
                }

                //届け先情報にユーザ情報の内容を設定
                txtDeliveryName.Text = this.Member.Name;
                txtDeliveryPostal.Text = this.Member.PostCode;
                txtDeliveryAddress.Text = this.Member.Address;
                txtDeliveryTel.Text = this.Member.Telephone;

                //届け先(宛名)の全選択を外す
                this.txtDeliveryName.SelectionStart = this.txtDeliveryName.Text.Length;
            }
            catch (Exception ex)
            {
                //例外エラー処理
                ExceptionError(ex);
            }
        }

        /// <summary>
        ///    数値入力制御
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericalInputControl(object sender, KeyPressEventArgs e)
        {
            //バックスペース、Deleteキーが押された時は入力有効
            if (e.KeyChar.Equals('\b') == true)
            {
                return;
            }

            //数値0～9以外が押された時は入力無効
            if (e.KeyChar < '0' == true || '9' < e.KeyChar == true)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        ///    請求先区分コンボックス変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BillTypeChange(object sender, EventArgs e)
        {
            //「指定する」を選択
            if (this.cbxBillType.SelectedIndex.Equals(1) == true)
            {
                //請求先情報エリアを有効化
                this.grbBill.Enabled = true;
            }
            else
            {
                //請求先情報エリアを無効化
                this.grbBill.Enabled = false;
            }
        }

        /// <summary>
        ///    商品名コンボックス変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderItemChange(object sender, EventArgs e)
        {
            //現在選択してる商品名リスト
            List<string> selectedList = new List<string>();

            try
            {
                //商品名コンボックスの入力内容を順番(1～10)にチェック(1回目)
                foreach (OrderInfo order in OrderInfoList)
                {
                    //商品名が選択されている場合はリストに追加
                    if (string.IsNullOrEmpty(order.GetName()) == false)
                    {
                        selectedList.Add(order.GetName());
                    }
                }

                //商品名コンボックスの入力内容を順番(1～10)にチェック(1回目)
                foreach (OrderInfo order in OrderInfoList)
                {
                    //自身のコンボックスが選択してる商品名を取得
                    string nowSelect = order.GetName();

                    //商品名コンボックス内容を全て消す
                    order.CmbName.Items.Clear();

                    //初期値用の空文字をコンボックスに追加
                    order.CmbName.Items.Add(string.Empty);

                    //商品マスタを全件読み込み
                    foreach (string[] value in Product.Record.Values)
                    {
                        //画面表示用に加工
                        string item = $"{value[0]} {value[1]}";

                        //他のコンボックス選択している商品名 かつ 自身が選択している商品名以外
                        if (selectedList.Contains(item) == true && item.Equals(nowSelect) == false)
                        {
                            //次のレコードに進む
                            continue;
                        }

                        //コンボックスに追加
                        order.CmbName.Items.Add(item);
                    }

                    //選択済みの商品名コンボックス
                    if (string.IsNullOrEmpty(nowSelect) == false)
                    {
                        //自身が選択している商品名のインデックスを取得
                        int index = order.CmbName.Items.IndexOf(nowSelect);

                        //商名品コンボックス変更イベントを解除
                        order.CmbName.SelectedIndexChanged -= new EventHandler(OrderItemChange);

                        //コンボックス選択内容を設定
                        order.CmbName.SelectedIndex = index;

                        //商品名コンボックス変更イベントを再設定
                        order.CmbName.SelectedIndexChanged += new EventHandler(OrderItemChange);
                    }
                }
            }
            catch (Exception ex)
            {
                //例外エラー用の処理を実行
                ExceptionError(ex);
            }
        }

        /// <summary>
        ///    注文内容確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOrder(object sender, EventArgs e)
        {
            try
            {
                //エラーメッセージ
                string errMessage = string.Empty;

                //未入力チェック
                if (CheckBlank(ref errMessage) == false)
                {
                    //エラーメッセージを表示
                    ShowError(errMessage);

                    //処理終了
                    return;
                }

                //在庫チェック
                if (CheckStock(ref errMessage) == false)
                {
                    //エラーメッセージを表示
                    ShowError(errMessage);

                    //処理終了
                    return;
                }

                //注文合計額を取得
                int amountSum = GetTotalAmount();

                //割引を適用
                amountSum = ApplyDiscount(amountSum);

                //消費税を適用
                amountSum = (int)(amountSum * 1.1);

                //在庫マスタファイル書き換え
                this.Stock.UpdateFile();

                //注文完了のメッセージを表示
                MessageBox.Show(string.Format(MessageResource.INF001, amountSum), "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //例外エラー用の処理を実行
                ExceptionError(ex);
            }
        }  

        /// <summary>
        ///    未入力チェック
        /// </summary>
        /// <param name="argMessage">エラーメッセージ</param>
        /// <returns>チェック結果(OK:true,NG:false)</returns>
        private bool CheckBlank(ref string argMessage)
        {
            //エラーメッセージリスト
            List<string> errMessage = new List<string>();

            try
            { 
                //届け先情報の各入力項目を順番にチェック
                foreach (TextBox txtDelivery in new TextBox[] { txtDeliveryName, txtDeliveryPostal, txtDeliveryAddress, txtDeliveryTel })
                {
                    //未入力項目あり
                    if (string.IsNullOrEmpty(txtDelivery.Text) == true)
                    {
                        //エラーメッセージ追加
                        errMessage.Add(MessageResource.ERR004);

                        //次のチェックに進む
                        break;
                    }
                }

                //請求先区分が「指定する」
                if (cbxBillType.SelectedIndex.Equals(1) == true)
                {
                    //請求先情報の各入力項目を順番にチェック
                    foreach (TextBox txtBill in new TextBox[] { txtBillName, txtBillPostal, txtBillAddress, txtBillTel })
                    {
                        //未入力項目あり
                        if (string.IsNullOrEmpty(txtBill.Text) == true)
                        {
                            //エラーメッセージ追加
                            errMessage.Add(MessageResource.ERR005);

                            //次のチェックに進む
                            break;
                        }
                    }
                }

                //商品名未入力フラグ
                bool emptyFlg = true;

                //商品1～10の合計注文数
                int orderSum = 0;

                //商品名コンボックスの入力内容を順番(1～10)にチェック
                foreach (OrderInfo order in OrderInfoList)
                {
                    //商品名が選択されている
                    if (string.IsNullOrEmpty(order.GetName()) == false)
                    {
                        emptyFlg = false;
                    }

                    //合計注文数を加算
                    orderSum += order.GetCount();
                }

                //商品1～10が全て未選択
                if (emptyFlg == true)
                {
                    //エラーメッセージ追加
                    errMessage.Add(MessageResource.ERR006);
                }
                //商品1～10の合計注文数が0
                else if (orderSum.Equals(0) == true)
                {
                    //エラーメッセージ追加
                    errMessage.Add(MessageResource.ERR007);
                }

                //チェックの中で追加されたエラーメッセージが1件以上
                if (errMessage.Count.Equals(0) == false)
                {
                    //追加されたエラーメッセージを改行コードで結合
                    argMessage = string.Join("\n", errMessage.ToArray());

                    //チェック結果:NG
                    return false;
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

        /// <summary>
        ///    在庫数チェック
        /// </summary>
        /// <param name="argMessage">エラーメッセージ</param>
        /// <returns>チェック結果(OK:true,NG:false)</returns>
        private bool CheckStock(ref string argMessage)
        {
            try
            {
                //商品名コンボックスで選択している商品の在庫数を順番(1～10)にチェック
                foreach (OrderInfo order in this.OrderInfoList)
                {
                    //商品が未選択 または 注文数:0 はチェック対象外
                    if (string.IsNullOrEmpty(order.GetName()) == false && order.GetCount().Equals(0) == false)
                    {
                        //コンボボックスの値から商品コードと商品名を配列で取得
                        string[] item = order.GetName().Split(' ');

                        //商品の在庫数(全倉庫分の在庫数を計上)
                        int stockSum = 0;

                        //在庫マスタのキー情報(倉庫コード+商品コード)を全件読み込み
                        foreach (string key in this.Stock.Record.Keys)
                        {
                            //在庫マスタの商品コードと選択している商品コードが一致
                            if (key.Substring(key.Length - 5).Equals(item[0]) == true)
                            {
                                //商品の在庫数を加算
                                stockSum += int.Parse(this.Stock.Record[key][2]);
                            }
                        }

                        //入力注文数に対して全倉庫分の在庫数でも足りない場合
                        if (order.GetCount() > stockSum == true)
                        {
                            //エラーメッセージを設定
                            argMessage = string.Format(MessageResource.ERR008, item[1], stockSum);

                            //チェック結果:NG
                            return false;
                        }
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

        /// <summary>
        ///    注文合計額取得
        /// </summary>
        /// <returns>注文合計額</returns>
        private int GetTotalAmount()
        {

            //注文合計額
            int rtnTotalAmount = 0;

            try
            {
                //商品名コンボックスの入力内容を順番(1～10)にチェック
                foreach (OrderInfo order in this.OrderInfoList)
                {
                    //商品が未選択 または 注文数:0 はチェック対象外
                    if (string.IsNullOrEmpty(order.GetName()) == false && order.GetCount().Equals(0) == false)
                    {
                        //コンボボックスの値から商品コードと商品名を配列で取得
                        string[] item = order.GetName().Split(' ');

                        //入力した注文数を取得
                        int orderCnt = order.GetCount();

                        //在庫マスタ全件をキー項目の昇順で処理
                        foreach (var record in this.Stock.Record.OrderBy(x => x.Key))
                        {
                            //在庫マスタの商品コードと選択している商品コードが一致
                            if (record.Key.Substring(record.Key.Length - 5).Equals(item[0]) == true)
                            {
                                //在庫マスタから在庫数を取得
                                int stockCnt = int.Parse(record.Value[2]);

                                //入力した注文数が在庫数と同等または上回る
                                if (orderCnt >= stockCnt)
                                {
                                    //注文数から在庫数分を引く
                                    orderCnt -= stockCnt;

                                    //在庫数を0に設定
                                    stockCnt = 0;  
                                }
                                else
                                {
                                    //在庫数から注文数分を引く
                                    stockCnt -= orderCnt;

                                    //注文数を0に設定
                                    orderCnt = 0;
                                }

                                //在庫マスタの在庫数を書き換え⇒メモリ上に展開している在庫マスタに反映
                                record.Value[2] = stockCnt.ToString();
                                Stock.Record[record.Key] = record.Value;
                            }

                            //未処理の注文数が0
                            if (orderCnt.Equals(0) == true)
                            {
                                //在庫数の更新終了
                                break;
                            }
                        }

                        //商品マスタから単価を取得
                        int unit = int.Parse(this.Product.Record[item[0]][2]);

                        //注文額(単価×注文数)を加算
                        rtnTotalAmount += unit * order.GetCount();
                    }
                }

                return rtnTotalAmount;
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
        }

        /// <summary>
        ///    割引適用
        /// </summary>
        /// <param name="argAmount">適用前の金額</param>
        /// <returns>適用後の金額</returns>
        private int ApplyDiscount(int argBefAmount)
        {
            //適用後の合計注文額
            int rtnAmount = argBefAmount;

            //送料
            int postage = 500;

            try
            {
                //会員情報から累計購入金額を取得
                int memberAmount = int.Parse(Member.Amount);

                //会員情報から会員区分を取得
                string category = Member.Category;

                //会員区分が無料
                if (category.Equals("0") == true)
                {
                    //累計購入金額が10万未満
                    if (memberAmount < 100_000 == true)
                    {
                        //送料加算
                        rtnAmount += postage;
                    }
                    //累計購入金額が10万以上、20万未満
                    else if (memberAmount < 200_000 == true)
                    {
                        //10%割引
                        rtnAmount = (int)(rtnAmount * 0.9);

                        //送料加算
                        rtnAmount += postage;
                    }
                    //累計購入金額が20万以上
                    else
                    {
                        //15%割引
                        rtnAmount = (int)(rtnAmount * 0.85);
                    }
                }
                //会員区分が有料
                else if (category.Equals("1") == true)
                {
                    //累計購入金額が10万未満
                    if (memberAmount < 100_000 == true)
                    {
                        //10%割引
                        rtnAmount = (int)(rtnAmount * 0.9);

                        //送料加算
                        rtnAmount += postage;
                    }
                    //累計購入金額が10万以上、20万未満
                    else if (memberAmount < 200_000 == true)
                    {
                        //15%割引
                        rtnAmount = (int)(rtnAmount * 0.85);

                        //送料加算
                        rtnAmount += postage;
                    }
                    //累計購入金額が20万以上
                    else
                    {
                        //20%割引
                        rtnAmount = (int)(rtnAmount * 0.8);
                    }
                }

                return rtnAmount;
            }
            catch
            {
                //呼び出し元に例外エラーを渡す
                throw;
            }
        }

        /// <summary>
        ///    エラーメッセージ表示
        /// </summary>
        /// <param name="argMessage">メッセージ内容</param>
        private void ShowError(string argMessage)
        {
            //エラーメッセージ表示
            MessageBox.Show(argMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///    例外エラー処理
        /// </summary>
        /// <param name="argEX">例外クラス</param>
        private void ExceptionError(Exception argEX)
        {
            //エラーログ記録
            Log.logger.Error($"{argEX.Message}\t{argEX.StackTrace}");

            //エラーメッセージ表示
            MessageBox.Show($"{argEX.Message}\nエラーログを確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //画面を閉じる
            this.Close();
        }
    }

    /// <summary>
    ///    注文情報クラス
    /// </summary>
    public class OrderInfo
    {
        /// <summary>商品名コンボックス</summary>
        public ComboBox CmbName;

        /// <summary>注文数入力エリア</summary>
        public NumericUpDown NudCount;

        /// <summary>
        ///    コンストラクタ
        /// </summary>
        /// <param name="argCmbItem">商品名コンボックス</param>
        /// <param name="argNudItem">注文数入力エリア</param>
        public OrderInfo(ComboBox argCmbItem, NumericUpDown argNudItem)
        {
            this.CmbName = argCmbItem;
            this.NudCount = argNudItem;
        }

        /// <summary>
        ///    商品名取得
        /// </summary>
        /// <returns>商品名コンボックスで選択されている値</returns>
        public string GetName()
        {
            return this.CmbName.Text;
        }

        /// <summary>
        ///    注文数取得
        /// </summary>
        /// <returns>注文数入力エリアで入力されている値</returns>
        public int GetCount()
        {
            return (int)this.NudCount.Value;
        }
    }
}
