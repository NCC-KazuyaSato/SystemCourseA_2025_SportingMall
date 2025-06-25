
namespace SportingMall
{
    public class Member : BaseMaster
    {
        /// <summary>会員番号</summary>
        public string MemberCode;

        /// <summary>会員名</summary>
        public string Name;

        /// <summary>郵便番号</summary>
        public string PostCode;

        /// <summary>住所</summary>
        public string Address;

        /// <summary>電話番号</summary>
        public string Telephone;

        /// <summary>Eメールアドレス</summary>
        public string Email;

        /// <summary>累計購入金額</summary>
        public string Amount;

        /// <summary>会員区分</summary>
        public string Category;

        /// <summary>
        ///    コンストラクタ
        /// </summary>
        /// <param name="argMasterName">マスタ名</param>
        /// <param name="argFileName">ファイル名</param>
        public Member()
        {
            this.MasterName = "会員マスタ";
            this.FileName = "Member.csv";
            this.FilePath = Path.Combine(Directory.GetCurrentDirectory(), "csv", FileName);

            //固定の会員情報を設定
            this.MemberCode = "00000001";
            this.Name = "田中　太郎";
            this.PostCode = "9500088";
            this.Address = "新潟県新潟市中央区万代1-6-1 万代シティビルボードプレイス";
            this.Telephone = "0252445121";
            this.Email = "tanaka.t@example.com";
            this.Amount = "150000";
            this.Category = "1";
        }
    }
}
