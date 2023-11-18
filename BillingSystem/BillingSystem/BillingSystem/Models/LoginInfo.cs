﻿namespace BillingSystem.Models
{
    /// <summary>
    /// アカウント保持クラス
    /// </summary>
    public class LoginInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        public static int ID { get; set; }
        /// <summary>
        /// ログインID
        /// </summary>
        public static string LoginID { get; set; }
        /// <summary>
        /// 氏名
        /// </summary>
        public static string UserName { get; set; }
        /// <summary>
        /// パスワード
        /// </summary>
        public static string Password { get; set; }
        /// <summary>
        /// カナ氏名
        /// </summary>
        public static string UserNameKana { get; set; }
        /// <summary>
        /// 略称
        /// </summary>
        public static string UserShortName { get; set; }
        /// <summary>
        /// 部門
        /// </summary>
        public static string Department { get; set; }
        /// <summary>
        /// 権限フラグ（9:管理者  1:一般ユーザー）
        /// </summary>
        public static string AuthorityFlag { get; set; }
        /// <summary>
        /// 備考
        /// </summary>
        public static string Note { get; set; }
        /// <summary>
        /// 削除フラグ
        /// </summary>
        public static int DeleteFlag { get; set; }
        /// <summary>
        /// LockVer
        /// </summary>
        public static int LockVer { get; set; }

        /// <summary>
        /// 捺印ファイルID
        /// </summary>
        public static string SealFileID { get; set; }


        /// <summary>
        /// 捺印ファイル名
        /// </summary>
        public static string SealName { get; set; }

        /// <summary>
        /// 初期化
        /// </summary>
        public static void LoginInfoClear()
        {
            ID = 0;
            LoginID = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
            UserNameKana = string.Empty;
            UserShortName = string.Empty;
            Department = string.Empty;
            AuthorityFlag = "0";
            Note = string.Empty;
            DeleteFlag = 0;
            LockVer = 0;
            SealFileID = string.Empty;
            SealName = string.Empty;
        }
    }
}
