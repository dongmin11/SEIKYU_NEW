using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    /// <summary>
    /// 支払区分
    /// </summary>
    public class PaymentTypeModel
    {
        public string ID { get; set; }

        /// <summary>
        /// 支払区分
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 支払区分名
        /// </summary>
        public string PaymentTypeName { get; set; }

        /// <summary>
        /// 加算日
        /// </summary>
        public int AddDays { get; set; }

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
