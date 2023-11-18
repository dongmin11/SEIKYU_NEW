﻿namespace Common
{
    public class ConstCommon
    {
        #region INIファイルパス    
        /// <summary>
        /// INIファイルパス(システム)
        /// </summary>
        public const string INI_PATH = "/Ini/Training.ini";
        /// <summary>
        /// INIファイルパス(メッセージ)
        /// </summary>
        public const string INI_PATH_MSG = "/Ini/Message.ini";
        #endregion

        #region DB接続関連       
        /// <summary>
        /// コレクション
        /// </summary>
        public const string CONNECTION = "CONNECTION";
        /// <summary>
        /// DB接続文字列
        /// </summary>
        public const string CONNECTIONSTRING = "CONNECTIONSTRING";
        #endregion

        #region メッセージ関連
        /// <summary>
        /// セクションキー
        /// </summary>
        public const string MESSAGE = "MESSAGE";
        /// <summary>
        /// ユーザーIDまたはパスワードが正しくありません。
        /// </summary>
        public const string IMG0001 = "IMG0001";
        /// <summary>
        /// {0}を入力して下さい。
        /// </summary>
        public const string IMG0002 = "IMG0002";
        /// <summary>
        /// 該当データが存在しません。
        /// </summary>
        public const string IMG0003 = "IMG0003";
        /// <summary>
        /// パスワードが一致しません。
        /// </summary>
        public const string IMG0004 = "IMG0004";
        /// <summary>
        /// このユーザーIDは既に使用されています。 別のユーザーIDを入力してください。
        /// </summary>
        public const string IMG0005 = "IMG0005";
        /// <summary>
        /// 他のユーザによってデータが更新されました。一覧を更新し再度実行してください。
        /// </summary>
        public const string IMG0006 = "IMG0006";

        /// <summary>
        /// システムエラーが発生しました。システム管理者に連絡してください。
        /// </summary>
        public const string IMG9999 = "IMG9999";
        #endregion

        #region コードリスト
        /// <summary>
        /// テスト
        /// </summary>
        public const string CODELIST_KINDID_0000 = "0000";
        #endregion

        #region その他
        /// <summary>
        /// ハッシュテーブルキー
        /// </summary>
        public const string RESULT = "Result";
        /// <summary>
        /// ログインID
        /// </summary>
        public const string LOGINID = "LoginID";
        #endregion
        /// <summary>
        /// 行番号
        /// </summary>
        public const string ROW_NO = "RowNo";

        #region 権限
        /// <summary>
        /// :一般ユーザー
        /// </summary>
        public const string AUTHORITYFLAG_1 = "1";
        /// <summary>
        /// 管理者
        /// </summary>
        public const string AUTHORITYFLAG_9 = "9";
        #endregion

        #region コードリスト
        /// <summary>
        /// 権限コードリストID
        /// </summary>
        public const string KINDID_1000 = "1000";

        /// <summary>
        /// 部署コードリストID
        /// </summary>
        public const string KINDID_1001 = "1001";

        /// <summary>
        /// 端数
        /// </summary>
        public const string KINDID_1002 = "1002";

        /// <summary>
        /// 請求書ステータス
        /// </summary>
        public const string KINDID_2001 = "2001";

        #endregion
    }
}
