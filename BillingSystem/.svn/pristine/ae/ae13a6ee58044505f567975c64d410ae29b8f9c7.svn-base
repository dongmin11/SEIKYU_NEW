using Common;
using Common.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using BillingSystem.Models;
using static System.Net.Mime.MediaTypeNames;

namespace BillingSystem.DAL
{
    public class SeikyuDAL : CommonDAL
    {
        #region 請求一覧を検索
        /// <summary>
        /// 請求一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuSearchBillingModel> SearchGetBillingInfo(SeikyuSearchBillingModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     b.ID");
            sb.Append("     , b.DeleteFlag");
            sb.Append("     , b.BillingDate");
            sb.Append("     , CONCAT(b.BillingNo, '-', FORMAT(b.BranchNo, '000')) AS BillingNo");
            sb.Append("     , b.BranchNo");
            sb.Append("     , b.CustomerName");
            sb.Append("     , code.Name AS CodeName");
            sb.Append("     , u.UserName");
            sb.Append("     , b.PaymentType");
            sb.Append("     , b.BillingAmount");
            sb.Append("     , b.BillingTax");
            sb.Append("     , b.TransportationAmount");
            sb.Append("     , b.BillingTotal ");
            sb.Append(" FROM");
            sb.Append("     T_Billing b ");
            sb.Append("     LEFT JOIN M_Code code ");
            sb.Append("         ON b.Status = code.Code ");
            sb.Append("         AND code.KindID = 2001");
            sb.Append("     LEFT JOIN M_User u ");
            sb.Append("         ON b.ManagerID = u.ID ");
            sb.Append(" WHERE");
            sb.Append("     BillingDate BETWEEN @StartDate AND @EndDate ");
            if (inputData.DeleteFlag)
            {
                // 削除のみ表示選択時処理
                sb.Append("    AND b.DeleteFlag = 1");
            }

            // "全て" が選択された場合は CustomerName の条件を追加しない
            //キーに変更
            if (inputData.CustomerID != "0")
            {
                sb.Append("    AND b.CustomeID = @CustomerID");
            }

            // "全て" が選択された場合は UserName の条件を追加しない
            if (inputData.UserID != "0")
            {
                sb.Append("    AND b.ManagerID = @UserID");
            }


            //ステータスにチェックがある場合
            //複数選択可能
            // 初期化
            if(inputData.StatusFlg2 == true)
            {
                inputData.StatusFlg = false;

                sb.Append(" AND b.Status IN (");

                if (inputData.chkInProgress != 10)
                {
                    sb.Append("@chkInProgress");
                    inputData.StatusFlg = true;
                }

                if (inputData.chkPendingApproval != 10)
                {
                    if (inputData.StatusFlg)
                    {
                        sb.Append(", ");
                    }

                    sb.Append("@chkPendingApproval");
                    inputData.StatusFlg = true;
                }

                if (inputData.chkApproved != 10)
                {
                    if (inputData.StatusFlg)
                    {
                        sb.Append(", ");
                    }

                    sb.Append("@chkApproved");
                    inputData.StatusFlg = true;
                }

                if (inputData.chkCompleted != 10)
                {
                    if (inputData.StatusFlg)
                    {
                        sb.Append(", ");
                    }

                    sb.Append("@chkCompleted");
                    inputData.StatusFlg = true;
                }

                if (inputData.chkSent != 10)
                {
                    if (inputData.StatusFlg)
                    {
                        sb.Append(", ");
                    }

                    sb.Append("@chkSent");
                    inputData.StatusFlg = true;
                }

                sb.Append(")");
            }

            //sb.Append("    ORDER BY T_Billing.ID");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行

            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<SeikyuSearchBillingModel>(dt);

            return result;
        }
        #endregion


        #region 顧客名一覧取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuCustomerModel> GetCustomerInfo(SeikyuCustomerModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     CustomerName");
            sb.Append("     ,ID");
            sb.Append(" FROM");
            sb.Append("     [dbo].[M_Customer]");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<SeikyuCustomerModel>(dt);

            return result;
        }
        #endregion

        #region ユーザー名一覧取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuUserModel> GetUserName(SeikyuUserModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     UserName");
            sb.Append("     ,ID");
            sb.Append(" FROM");
            sb.Append("     M_User");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<SeikyuUserModel>(dt);

            return result;
        }
        #endregion

    }


}
