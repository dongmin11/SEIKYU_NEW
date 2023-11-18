using BillingSystem.DAL;
using BillingSystem.Models;
using Common;
using Common.BLL;
using System.Collections;
using System.Collections.Generic;


namespace BillingSystem.BLL
{
    public class FileBLL : CommonBLL
    {
        FileDAL dal = new FileDAL();

        #region ファイルを取得
        /// <summary>
        ///ファイル情報を取得
        /// </summary>
        /// <param name="inputData">検索条件</param>
        /// <returns></returns>
        public Dictionary<string, object> GetFileInfo(string fileID)
        {
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            Dictionary<string, object> data = CallHeavyBusinessLogic(() => dal.GetFileInfo(fileID), context);

            return data;
        }
        #endregion

        #region ファイルを取得
        /// <summary>
        ///ファイル情報を取得
        /// </summary>
        /// <param name="inputData">検索条件</param>
        /// <returns></returns>
        public List<Dictionary<string, object>> GetFileInfoList(List<string> fileIDList)
        {
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            var dataList = CallHeavyBusinessLogic(() => dal.GetFileInfoList(fileIDList), context);

            return dataList;
        }
        #endregion
    }
}
