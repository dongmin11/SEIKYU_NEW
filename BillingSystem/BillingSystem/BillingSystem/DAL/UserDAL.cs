using BillingSystem.Models;
using Common;
using Common.DAL;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BillingSystem.DAL
{
    public class UserDAL : CommonDAL
    {
        #region ユーザ情報を取得
        /// <summary>
        /// ユーザ情報を取得
        /// </summary>
        /// <param name="inputData">検索条件</param>
        /// <returns></returns>
        public List<UserModel> GetAccoutInfo(UserModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT U.*");
            sb.Append("    ,T.Name AS AuthorityName");
            sb.Append(" FROM");
            sb.Append("     M_User U");
            sb.Append(" LEFT JOIN (");
            sb.Append("     SELECT *");
            sb.Append("     FROM T_CodeList");
            sb.Append("     WHERE KindID = '1000'");
            sb.Append(" ) T ON U.AuthorityFlag = T.Code");
            sb.Append(" WHERE 1=1");
            sb.Append(" AND DeleteFlag = 0");
            if (!string.IsNullOrEmpty(inputData.LoginID))
            {
                sb.Append("   AND  LoginID like  N'%'+@LoginID+N'%'");
            }

            if (!string.IsNullOrEmpty(inputData.UserName))
            {
                sb.Append("     AND UserName like N'%'+@UserName+N'%'");
            }
            #endregion

            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<UserModel>(dt);

            return result;
        }
        #endregion

        #region ユーザ情報登録
        /// <summary>
        /// ユーザ情報登録
        /// </summary>
        /// <param name="inputData">ユーザー情報</param>
        /// <returns></returns>
        public int SaveUserInfo(UserModel inputData)
        {

            #region SQL文            
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(inputData.LoginID))
            {
                // アップデート
                sb.Append(" UPDATE M_User");
                sb.Append("    SET UpdateDateTime = GETDATE()");
                sb.Append("       ,UserName = @UserName");
                sb.Append("       ,UserNameKana = @UserNameKana");
                sb.Append("       ,UserShortName = @UserShortName");
                sb.Append("       ,Department = @Department");
                sb.Append("       ,AuthorityFlag = @AuthorityFlag");
                sb.Append("       ,Note = @Note ");
                sb.Append("       ,UpdateUserID = @UpdateUserID"); 
                sb.Append("       ,LockVer = @LockVer + 1");
                // アップロードファイルがあれば
                if (inputData.SealFile != null && inputData.SealFile.Length > 0)
                {
                    sb.Append("       ,SealFile = @SealFile");
                    sb.Append("       ,SealName = @SealName");
                }                
                // パスワード初期化があれば
                if (!string.IsNullOrEmpty(inputData.Password))
                {
                    sb.Append("       ,Password = @Password");
                }
                sb.Append(" WHERE LoginID = @LoginID ");
                sb.Append(" AND ID = @ID");
                sb.Append(" AND LockVer = @LockVer");
            }
            else
            {
                // インサート
                sb.Append(" INSERT INTO M_User");
                sb.Append("            (LoginID");
                // パスワード初期化があれば
                if (!string.IsNullOrEmpty(inputData.Password))
                {
                    sb.Append("            ,Password");
                }                
                sb.Append("            ,UserName");
                sb.Append("            ,UserNameKana");
                sb.Append("            ,UserShortName");
                sb.Append("            ,Department");
                sb.Append("            ,AuthorityFlag");
                // アップロードファイルがあれば
                if (inputData.SealFile != null && inputData.SealFile.Length > 0)
                {
                    sb.Append("            ,SealFile");
                    sb.Append("            ,SealName");
                }             
                sb.Append("            ,Note");
                sb.Append("            ,DeleteFlag");
                sb.Append("            ,CreatUserID");
                sb.Append("            ,CreatDateTime");
                sb.Append("            ,LockVer)");
                sb.Append("      VALUES");
                sb.Append("            (@LoginID");
                // パスワード初期化があれば
                if (!string.IsNullOrEmpty(inputData.Password))
                {
                    sb.Append("            ,@Password");
                }                
                sb.Append("            ,@UserName");
                sb.Append("            ,@UserNameKana");
                sb.Append("            ,@UserShortName");
                sb.Append("            ,@Department");
                sb.Append("            ,@AuthorityFlag");
                // アップロードファイルがあれば
                if (inputData.SealFile != null && inputData.SealFile.Length > 0)
                {
                    sb.Append("            ,@SealFile");
                    sb.Append("            ,@SealName");
                }                
                sb.Append("            ,@Note");
                sb.Append("            ,0");
                sb.Append("            ,@CreatUserID");
                sb.Append("            ,GETDATE()");
                sb.Append("            ,0)");

            }
            #endregion

            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            int result = RunSqlInt(sb.ToString(), parms);

            return result;
        }
        #endregion

        #region ログインIDが使用済のチェック
        /// <summary>
        /// ログインIDが使用済のチェック
        /// </summary>
        /// <param name="inputData">ログインID</param>
        /// <param name="outputData">アウトデータ</param>
        public void IsLoginIdExist(Hashtable inputData, out Hashtable outputData)
        {
            outputData = new Hashtable();
            #region SQL文 
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT LoginID");
            sb.Append(" FROM M_User");
            sb.Append(" WHERE");
            sb.Append("     LoginID = @LoginID");
            #endregion

            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);

            if (dt != null && dt.Rows.Count > 0)
            {
                outputData[ConstCommon.RESULT] = dt.Rows.Count;
            }
            else
            {
                outputData[ConstCommon.RESULT] = 0;
            }
            
        }
        #endregion
    }
}
