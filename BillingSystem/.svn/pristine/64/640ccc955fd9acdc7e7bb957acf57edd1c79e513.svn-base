using BillingSystem.Models;
using Common;
using Common.DAL;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;

namespace BillingSystem.DAL
{
    public class FileDAL : CommonDAL
    {
        #region 会社情報を取得
        /// <summary>
        /// 会社情報を取得
        /// </summary>
        /// <param name="inputData">検索条件</param>
        /// <returns></returns>
        public Dictionary<string, object> GetFileInfo(string fileID)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ID, File");
            sb.Append(" FROM");
            sb.Append("     T_File");
            sb.Append(" WHERE ID = ");
            sb.Append(fileID);
            sb.Append("");
            #endregion

            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(new Hashtable());
            // SQL文実行
            List<Dictionary<string, object>> list =  RunSqlDictionaryList(sb.ToString(), parms);
            if(list != null && list.Any())
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 会社情報を取得
        /// <summary>
        /// 会社情報を取得
        /// </summary>
        /// <param name="inputData">検索条件</param>
        /// <returns></returns>
        public List<Dictionary<string, object>> GetFileInfoList(List<string> fileIDList)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ID, [File]");
            sb.Append(" FROM");
            sb.Append("     T_File");
            sb.Append(" WHERE ID IN (");
            for(int i = 0; i< fileIDList.Count; i++)
            {
                if(i >0) sb.Append(", ");
                sb.Append(fileIDList[i]);
            }
            sb.Append(" )");
            #endregion

            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(new Hashtable());
            // SQL文実行
            return RunSqlDictionaryList(sb.ToString(), parms);
        }
        #endregion
    }
}
