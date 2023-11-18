using BillingSystem.DAL;
using Common.BLL;
using System.Collections;
using System.Collections.Generic;
using BillingSystem.Models;

namespace BillingSystem.BLL
{
    public class SeikyuBLL : CommonBLL
    {
        SeikyuDAL dal = new SeikyuDAL();

        #region 請求情報を検索

        /// <summary>
        /// 請求一覧情報を検索
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuSearchBillingModel> SearchGetBillingInfo(SeikyuSearchBillingModel inputData)
        {
            var selectList = new List<SeikyuSearchBillingModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<SeikyuSearchBillingModel> list = CallHeavyBusinessLogic(() => dal.SearchGetBillingInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 
        /// <summary>
        ///顧客名取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuCustomerModel> GetCustomerInfo(SeikyuCustomerModel inputData)
        {
            var selectList = new List<SeikyuCustomerModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<SeikyuCustomerModel> list = CallHeavyBusinessLogic(() => dal.GetCustomerInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region ユーザー名取得
        /// <summary>
        ///ユーザー名取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SeikyuUserModel> GetUserName(SeikyuUserModel inputData)
        {
            var selectList = new List<SeikyuCustomerModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<SeikyuUserModel> list = CallHeavyBusinessLogic(() => dal.GetUserName(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

    }
}
