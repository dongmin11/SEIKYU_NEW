namespace BillingSystem.Models
{
    /// <summary>
    /// ユーザーモデル
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// ログインID
        /// </summary>
        public string LoginID { get; set; }
        /// <summary>
        /// 氏名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// パスワード
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// カナ氏名
        /// </summary>
        public string UserNameKana { get; set; }
        /// <summary>
        /// 略称
        /// </summary>
        public string UserShortName { get; set; }
        /// <summary>
        /// 部門
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 権限フラグ（9:管理者  1:一般ユーザー）
        /// </summary>
        public string AuthorityFlag { get; set; }
        /// <summary>
        /// 権限名称
        /// </summary>
        public string AuthorityName { get; set; }
        /// <summary>
        /// 捺印ファイル
        /// </summary>
        public byte[] SealFile { get; set; }
        /// <summary>
        /// 捺印ファイル名
        /// </summary>
        public string SealName { get; set; }
        /// <summary>
        /// 備考
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 削除フラグ
        /// </summary>
        public int DeleteFlag { get; set; }
        /// <summary>
        /// LockVer
        /// </summary>
        public int LockVer { get; set; }
        /// <summary>
        /// 作成者ID
        /// </summary>
        public int CreatUserID { get; set; }
        /// <summary>
        /// 更新者ID
        /// </summary>
        public int UpdateUserID { get; set; }
    }
}
