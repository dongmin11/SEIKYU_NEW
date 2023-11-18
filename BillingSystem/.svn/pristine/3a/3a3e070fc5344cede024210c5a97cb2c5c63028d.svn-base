using BillingSystem.Models;
using Common;
using Common.DAL;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.IO;

namespace BillingSystem.DAL
{
    public class FileMode
    {
        public byte[] File { get; set; }
    }
public class CompanyDAL : CommonDAL
    {
        
        #region 会社情報を取得
        /// <summary>
        /// 会社情報を取得
        /// </summary>
        /// <param name="inputData">検索条件</param>
        /// <returns></returns>
        public CompanyModel GetCompanyInfo(CompanyModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT TOP 1 ");
            sb.Append("     ID");
            sb.Append("     , [CompanyName]");
            sb.Append("     , [PostNo]");
            sb.Append("     , [Address]");
            sb.Append("     , [Tel]");
            sb.Append("     , [Tax]");
            sb.Append("     , [Fraction]");
            sb.Append("     , [InvoiceNo]");
            sb.Append("     , [CompanySealID]");
            sb.Append("     , [CompanySealName]");
            sb.Append("     , [LockVer] ");
            sb.Append(" FROM");
            sb.Append("     [M_Company]");

            #endregion

            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<CompanyModel>(dt);
            if (result != null && result.Any())
            {
                return result[0];
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 会社情報登録
        /// <summary>
        /// 会社情報登録
        /// </summary>
        /// <param name="inputData">会社情報</param>
        /// <returns></returns>
        public int SaveCompanyInfo(CompanyModel inputData , byte[] file )
        {

            #region SQL文            
            StringBuilder sb = new StringBuilder();

            sb.Append(" INSERT INTO [T_File] ( ");
            sb.Append("     [File]");
            sb.Append("     , [CreatUserID]");
            sb.Append("     , [CreatDateTime]");
            sb.Append("     , [UpdateUserID]");
            sb.Append("     , [UpdateDateTime]");
            sb.Append("     , [LockVer]");
            sb.Append(" ) ");
            sb.Append(" VALUES ( ");
            sb.Append("     @File");
            sb.Append("     ," + LoginInfo.ID);
            sb.Append("     , GETUTCDATE()");
            sb.Append("     ," + LoginInfo.ID);
            sb.Append("     , GETUTCDATE()");
            sb.Append("     , 0");
            sb.Append(" )");


            if (inputData.ID != null)
            {
                //更新
                sb.Append(" UPDATE [M_Company] ");
                sb.Append(" SET");
                sb.Append("     [CompanyName] = @CompanyName");
                sb.Append("     , [PostNo] = @PostNo");
                sb.Append("     , [Address] = @Address");
                sb.Append("     , [Tel] = @Tel");
                sb.Append("     , [Tax] = @Tax");
                sb.Append("     , [Fraction] = @Fraction");
                sb.Append("     , [InvoiceNo] = @InvoiceNo");
                //sb.Append("     , [CompanySealID] = @CompanySealID");
                //sb.Append("     , [CompanySealName] = @CompanySealName");
                sb.Append("     , [UpdateUserID] = " + LoginInfo.ID);
                sb.Append("     , [UpdateDateTime] = GETUTCDATE()");
                sb.Append("     , [LockVer] = " + inputData.LockVer + 1);
                sb.Append(" WHERE");
                sb.Append("     ID = @ID");
                sb.Append("     AND [LockVer] = @LockVer ");
            }
            else
            {
                //登録
            }
            //if (!string.IsNullOrEmpty(inputData.LoginID))
            //{
            //    // アップデート
            //    sb.Append(" UPDATE M_User");
            //    sb.Append("    SET UpdateDateTime = GETDATE()");
            //    sb.Append("       ,UserName = @UserName");
            //    sb.Append("       ,UserNameKana = @UserNameKana");
            //    sb.Append("       ,UserShortName = @UserShortName");
            //    sb.Append("       ,Department = @Department");
            //    sb.Append("       ,AuthorityFlag = @AuthorityFlag");
            //    sb.Append("       ,Note = @Note ");
            //    sb.Append("       ,UpdateUserID = @UpdateUserID");
            //    sb.Append("       ,LockVer = @LockVer + 1");
            //    // アップロードファイルがあれば
            //    if (inputData.SealFile != null && inputData.SealFile.Length > 0)
            //    {
            //        sb.Append("       ,SealFile = @SealFile");
            //        sb.Append("       ,SealName = @SealName");
            //    }
            //    // パスワード初期化があれば
            //    if (!string.IsNullOrEmpty(inputData.Password))
            //    {
            //        sb.Append("       ,Password = @Password");
            //    }
            //    sb.Append(" WHERE LoginID = @LoginID ");
            //    sb.Append(" AND ID = @ID");
            //    sb.Append(" AND LockVer = @LockVer");
            //}
            //else
            //{
            //    // インサート
            //    sb.Append(" INSERT INTO M_User");
            //    sb.Append("            (LoginID");
            //    // パスワード初期化があれば
            //    if (!string.IsNullOrEmpty(inputData.Password))
            //    {
            //        sb.Append("            ,Password");
            //    }
            //    sb.Append("            ,UserName");
            //    sb.Append("            ,UserNameKana");
            //    sb.Append("            ,UserShortName");
            //    sb.Append("            ,Department");
            //    sb.Append("            ,AuthorityFlag");
            //    // アップロードファイルがあれば
            //    if (inputData.SealFile != null && inputData.SealFile.Length > 0)
            //    {
            //        sb.Append("            ,SealFile");
            //        sb.Append("            ,SealName");
            //    }
            //    sb.Append("            ,Note");
            //    sb.Append("            ,DeleteFlag");
            //    sb.Append("            ,CreatUserID");
            //    sb.Append("            ,CreatDateTime");
            //    sb.Append("            ,LockVer)");
            //    sb.Append("      VALUES");
            //    sb.Append("            (@LoginID");
            //    // パスワード初期化があれば
            //    if (!string.IsNullOrEmpty(inputData.Password))
            //    {
            //        sb.Append("            ,@Password");
            //    }
            //    sb.Append("            ,@UserName");
            //    sb.Append("            ,@UserNameKana");
            //    sb.Append("            ,@UserShortName");
            //    sb.Append("            ,@Department");
            //    sb.Append("            ,@AuthorityFlag");
            //    // アップロードファイルがあれば
            //    if (inputData.SealFile != null && inputData.SealFile.Length > 0)
            //    {
            //        sb.Append("            ,@SealFile");
            //        sb.Append("            ,@SealName");
            //    }
            //    sb.Append("            ,@Note");
            //    sb.Append("            ,0");
            //    sb.Append("            ,@CreatUserID");
            //    sb.Append("            ,GETDATE()");
            //    sb.Append("            ,0)");

            //}
            #endregion
            FileMode a = new FileMode();
            a.File = file;
                // パラメータ設定
                SqlParameter[] parms = GetSqlParameters(a);
            // SQL文実行
            int result = RunSqlInt(sb.ToString(), parms);

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
