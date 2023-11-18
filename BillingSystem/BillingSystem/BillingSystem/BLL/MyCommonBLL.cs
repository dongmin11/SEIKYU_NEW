using BillingSystem.DAL;
using BillingSystem.Models;
using Common.BLL;
using System.Collections.Generic;

namespace BillingSystem.BLL
{
    public class MyCommonBLL: CommonBLL
    {
        MyCommonDAL dal = new MyCommonDAL();

        #region ユーザ情報を取得
        /// <summary>
        /// ユーザ情報を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public UserModel GetAccoutInfo(UserModel inputData)
        {
            var selectList = new List<UserModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<UserModel> list = CallHeavyBusinessLogic(() => dal.GetAccoutInfo(inputData), context);

            if (list != null && list.Count == 1)
            {
                return list[0];
            }

            return null;
        }
        #endregion

        #region コードリストを取得
        /// <summary>
        /// コードリストを取得
        /// </summary>
        /// <param name="codeList"></param>
        /// <param name="IsBlank">先頭空欄フラグ</param>
        /// <returns></returns>
        public List<CodeListModel> GetCodeList(CodeListModel codeList, bool IsBlank = false)
        {
            var selectList = new List<CodeListModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<CodeListModel> list = CallHeavyBusinessLogic(() => dal.GetCodeList(codeList), context);
            var item = new CodeListModel();
            // 空白行追加
            if (IsBlank)
            {
                item.Code = "  ";
                item.Name = "";
                IsBlank = false;
                selectList.Add(item);
            }
            // DBからデータ情報を設定する
            foreach (var value in list)
            {
                item = new CodeListModel();
                item.Code = value.Code;
                item.Name = value.Name;
                selectList.Add(item);
            }
            return selectList;
        }
        #endregion
    }
}
