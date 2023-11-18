using BillingSystem.DAL;
using BillingSystem.Models;
using Common;
using Common.BLL;
using System.Collections;
using System.Collections.Generic;

namespace BillingSystem.BLL
{
    public class UserBLL : CommonBLL
    {
        UserDAL dal = new UserDAL();

        #region ユーザ情報検索        
        /// <summary>
        /// ユーザ情報検索
        /// </summary>
        /// <param name="inputData"></param>    
        /// <returns></returns>
        public List<UserModel> GetAccoutInfo(UserModel inputData)
        {

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<UserModel> list = CallHeavyBusinessLogic(() => dal.GetAccoutInfo(inputData), context);

            return list;
        }
        #endregion

        #region ユーザ情報登録      
        /// <summary>
        /// ユーザ情報検索
        /// </summary>
        /// <param name="inputData"></param>    
        /// <returns></returns>
        public int SaveUserInfo(UserModel inputData)
        {
            Hashtable outputData = new Hashtable();
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            int result = CallHeavyBusinessLogic(() => dal.SaveUserInfo(inputData), context);

            return result;
        }
        #endregion

        #region ログインIDが使用済のチェック      
        /// <summary>
        /// ログインIDが使用済のチェック
        /// </summary>
        /// <param name="inputData"></param>    
        /// <returns></returns>
        public bool IsLoginIdExist(string strLoginID)
        {
            Hashtable inputData = new Hashtable();
            Hashtable outputData = new Hashtable();

            inputData[ConstCommon.LOGINID] = strLoginID;
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            // デリゲートの生成
            CommonDelegate commonDelegate = new CommonDelegate(dal.IsLoginIdExist);
            bool result = CallHeavyBusinessLogic(context, commonDelegate, inputData, out outputData);

            if ((int)outputData[ConstCommon.RESULT] > 0)
            {
                return true;
            }

            return false;
        }
        #endregion

    }
}
