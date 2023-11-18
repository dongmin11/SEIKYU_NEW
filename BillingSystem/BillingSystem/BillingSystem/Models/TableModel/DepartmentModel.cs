using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class DepartmentModel
    {

        public string ID { get; set; }

        /// <summary>
        /// 請求先ID
        /// </summary>
        public decimal CustomeID { get; set; }

        /// <summary>
        /// 部署名
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 部署略称
        /// </summary>
        public string DepartmentShortName { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string TelNo { get; set; }

        /// <summary>
        /// 削除フラグ
        /// </summary>
        public int DeleteFlag { get; set; }

        /// <summary>
        /// 表示順
        /// </summary>
        public int DisplayNo { get; set; }

        /// <summary>
        /// LockVer
        /// </summary>
        public int LockVer { get; set; }
    }
}
