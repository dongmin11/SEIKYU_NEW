using BillingSystem.DAL;
using Common.BLL;
using System.Collections;
using System.Collections.Generic;
using BillingSystem.Models;
using BillingSystem.Models.TableModel;

namespace BillingSystem.BLL
{
    public class SeikyuEditBLL : CommonBLL
    {
        SeikyuEditDAL dal = new SeikyuEditDAL();

        #region 口座名一覧を取得

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<BankAccountModel> GetBankAccountName(BankAccountModel inputData)
        {
            var selectList = new List<BankAccountModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<BankAccountModel> list = CallHeavyBusinessLogic(() => dal.GetBankAccountName(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 顧客名一覧を取得

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<CustomerModel> GetCustomerInfo(CustomerModel inputData)
        {
            var selectList = new List<CustomerModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<CustomerModel> list = CallHeavyBusinessLogic(() => dal.GetCustomerInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 部署一覧を取得

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<DepartmentModel> GetDepartmentInfo(DepartmentModel inputData)
        {
            var selectList = new List<DepartmentModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<DepartmentModel> list = CallHeavyBusinessLogic(() => dal.GetDepartmentInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region ユーザー名名一覧を取得

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<UserModel> GetUserInfo(UserModel inputData)
        {
            var selectList = new List<UserModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<UserModel> list = CallHeavyBusinessLogic(() => dal.GetUserInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 支払い種別名を取得

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<PaymentTypeModel> GetPaymentInfo(PaymentTypeModel inputData)
        {
            var selectList = new List<PaymentTypeModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<PaymentTypeModel> list = CallHeavyBusinessLogic(() => dal.GetPaymentInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 作業名を取得

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<ProjectModel> GetProjectInfo(ProjectModel inputData)
        {
            var selectList = new List<ProjectModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<ProjectModel> list = CallHeavyBusinessLogic(() => dal.GetProjectInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 請求詳細のパラメータ



        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuEditBillingModel> GetBillingDetail(SeikyuEditBillingModel inputData)
        {
            var selectList = new List<SeikyuEditBillingModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<SeikyuEditBillingModel> list = CallHeavyBusinessLogic(() => dal.GetBillingDetail(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 請求詳細明細

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>SeikyuEditDetailsModel
        public List<SeikyuEditDetailsModel> GetBillingGdbDetail(SeikyuEditDetailsModel inputData)
        {
            var selectList = new List<SeikyuEditDetailsModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<SeikyuEditDetailsModel> list = CallHeavyBusinessLogic(() => dal.GetBillingGdbDetail(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 請求更新

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public int BillingUpdate(SeikyuEditBillingModel inputData)
        {
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            int result = CallHeavyBusinessLogic(() => dal.BillingUpdate(inputData), context);

            return result;
        }
        #endregion

        #region 請求追加

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public int BillingInsert(SeikyuEditBillingModel inputData)
        {
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            int result = CallHeavyBusinessLogic(() => dal.BillingInsert(inputData), context);

            return result;
        }
        #endregion

        #region 請求追加
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<CustomeModel> ChangeCustomerName(CustomeModel inputData)
        {
            var selectList = new List<CustomeModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<CustomeModel> list = CallHeavyBusinessLogic(() => dal.ChangeCustomeName(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 請求削除
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public int BillingDelete(SeikyuEditBillingModel inputData)
        {
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            int result = CallHeavyBusinessLogic(() => dal.BillingDelete(inputData), context);

            return result;
        }
        #endregion


        #region 請求追加
        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuEditBillingModel> GetLockVer(SeikyuEditBillingModel inputData)
        {
            var selectList = new List<CustomeModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<SeikyuEditBillingModel> list = CallHeavyBusinessLogic(() => dal.GetLockVer(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;

        }
        #endregion

        #region LockVer更新

        /// <summary>
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public int LockVerUpdate(SeikyuEditBillingModel inputData)
        {
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            int result = CallHeavyBusinessLogic(() => dal.LockVerUpdate(inputData), context);

            return result;
        }
        #endregion
    }
}