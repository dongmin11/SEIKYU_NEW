﻿using BillingSystem.DAL;
using BillingSystem.Models;
using Common;
using Common.BLL;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace BillingSystem.BLL
{
    public class CompanyBLL : CommonBLL
    {
        CompanyDAL dal = new CompanyDAL();

        #region 会社情報検索        
        /// <summary>
        /// 会社情報検索
        /// </summary>
        /// <param name="inputData"></param>    
        /// <returns></returns>
        public CompanyModel GetCompanyInfo(CompanyModel inputData)
        {

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            CompanyModel result = CallHeavyBusinessLogic(() => dal.GetCompanyInfo(inputData), context);
            return result;
        }
        #endregion

        #region 会社情報登録      
        /// <summary>
        /// 会社情報検索
        /// </summary>
        /// <param name="inputData"></param>    
        /// <returns></returns>
        public int SaveCompanyInfo(CompanyModel inputData, byte[] file)
        {
            Hashtable outputData = new Hashtable();
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            int result = CallHeavyBusinessLogic(() => dal.SaveCompanyInfo(inputData, file), context);

            return result;
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

        #region ユーザ情報登録      
        /// <summary>
        /// ユーザ情報検索
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
