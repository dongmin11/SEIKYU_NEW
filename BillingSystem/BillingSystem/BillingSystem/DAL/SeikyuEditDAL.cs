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
using BillingSystem.Models.TableModel;

namespace BillingSystem.DAL
{
    public class SeikyuEditDAL : CommonDAL
    {
        #region 口座名取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<BankAccountModel> GetBankAccountName(BankAccountModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     BankName");
            sb.Append("     ,ID");
            sb.Append(" FROM");
            sb.Append("     [dbo].[M_BankAccount]");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<BankAccountModel>(dt);

            return result;
        }
        #endregion

        #region 請求先名一覧取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<CustomerModel> GetCustomerInfo(CustomerModel inputData)
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
            var result = ConvertDataTableToListClass<CustomerModel>(dt);

            return result;
        }
        #endregion

        #region 部署名取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<DepartmentModel> GetDepartmentInfo(DepartmentModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     DepartmentName");
            sb.Append("     ,CustomeID");
            sb.Append(" FROM");
            sb.Append("     [dbo].[M_Department]");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<DepartmentModel>(dt);

            return result;
        }
        #endregion


        #region ユーザー名一覧取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<UserModel> GetUserInfo(UserModel inputData)
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
            var result = ConvertDataTableToListClass<UserModel>(dt);

            return result;
        }
        #endregion

        #region 支払い種別一覧取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<PaymentTypeModel> GetPaymentInfo(PaymentTypeModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     PaymentTypeName");
            sb.Append("     ,Type");
            sb.Append(" FROM");
            sb.Append("     M_PaymentType");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<PaymentTypeModel>(dt);

            return result;
        }
        #endregion

        #region プロジェクト一覧取得
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<ProjectModel> GetProjectInfo(ProjectModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     ProjectName");
            sb.Append("     ,OrderNo");
            sb.Append(" FROM");
            sb.Append("     M_Project");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<ProjectModel>(dt);

            return result;
        }
        #endregion


        #region 請求詳細取得
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuEditBillingModel> GetBillingDetail(SeikyuEditBillingModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     ID ");
            sb.Append("     ,BillingDate");
            sb.Append("     ,BillingNo");
            sb.Append("     ,BranchNo");
            sb.Append("     ,OrderNo");
            sb.Append("     ,ManagerID");
            sb.Append("     ,BankAccountID");
            sb.Append("     ,CustomeID");
            sb.Append("     ,ProjectContent");
            sb.Append("     ,ProjectAdd");
            sb.Append("     ,Deliverables");
            sb.Append("     ,PaymentType");
            sb.Append(" FROM");
            sb.Append("     T_Billing");
            sb.Append(" WHERE");
            sb.Append("     T_Billing.ID = @ID");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<SeikyuEditBillingModel>(dt);

            return result;
        }
        #endregion

        #region 請求詳細明細取得
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuEditDetailsModel> GetBillingGdbDetail(SeikyuEditDetailsModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     EmployeeName ");
            sb.Append("     ,WorkingHours");
            sb.Append("     ,BasicAmount");
            sb.Append("     ,LowerLimitName");
            sb.Append("     ,LowerLimitUnit");
            sb.Append("     ,LowerLimitAmount");
            sb.Append("     ,UpperLimitName");
            sb.Append("     ,UpperLimitUnit");
            sb.Append("     ,UpperLimitAmount");
            sb.Append("     ,BillingAmount");
            sb.Append("     ,TransportationAmount");
            sb.Append(" FROM");
            sb.Append("     T_BillingDetail");
            sb.Append(" WHERE");
            sb.Append("     T_BillingDetail.BillingID = @ID");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<SeikyuEditDetailsModel>(dt);

            return result;
        }
        #endregion

        #region 請求レコード更新
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public int BillingUpdate(SeikyuEditBillingModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            // アップデート
            sb.Append(" UPDATE T_Billing");
            sb.Append("    SET UpdateDateTime = GETDATE()");
            sb.Append("       ,BillingDate = @BillingDate");
            sb.Append("       ,BillingNo = @BillingNo");
            sb.Append("       ,BranchNo = @BranchNo");
            sb.Append("       ,ManagerID = @ManagerID");
            sb.Append("       ,CustomeID = @CustomeID");
            sb.Append("       ,OrderNo = @OrderNo ");
            sb.Append("       ,ProjectContent = @ProjectContent");
            sb.Append("       ,ProjectAdd = @ProjectAdd");
            sb.Append("       ,Deliverables = @Deliverables");
            sb.Append("       ,PaymentType = @PaymentType");
            sb.Append("       ,BankAccountID = @BankAccountID");
            sb.Append(" WHERE ID = @ID");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            int result = RunSqlInt(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            return result;
        }
        #endregion

        #region 請求レコード追加
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public int BillingInsert(SeikyuEditBillingModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            // アップデート
            sb.Append(" INSERT INTO T_Billing");
            sb.Append("       (BillingDate");
            sb.Append("       ,BillingFromDate");
            sb.Append("       ,BillingToDate");
            sb.Append("       ,BillingNo");
            sb.Append("       ,BranchNo");
            sb.Append("       ,ManagerID");
            sb.Append("       ,CustomeID");
            sb.Append("       ,OrderNo");
            sb.Append("       ,ProjectContent");
            sb.Append("       ,ProjectAdd");
            sb.Append("       ,Deliverables");
            sb.Append("       ,PaymentType");
            sb.Append("       ,BankAccountID)");
            sb.Append("       VALUES");
            sb.Append("       (@BillingDate");
            sb.Append("       ,@BillingFromDate");
            sb.Append("       ,@BillingToDate");
            sb.Append("       ,@BillingNo");
            sb.Append("       ,@BranchNo");
            sb.Append("       ,@ManagerID");
            sb.Append("       ,@CustomeID");
            sb.Append("       ,@OrderNo");
            sb.Append("       ,@ProjectContent");
            sb.Append("       ,@ProjectAdd");
            sb.Append("       ,@Deliverables");
            sb.Append("       ,@PaymentType");
            sb.Append("       ,@BankAccountID)");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            int result = RunSqlInt(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            return result;
        }
        #endregion


    }
}
