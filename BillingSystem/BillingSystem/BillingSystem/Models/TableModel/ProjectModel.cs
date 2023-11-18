using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    /// <summary>
    /// プロジェクトマスタ
    /// </summary>
    public class ProjectModel
    {
        public string ID { get; set; }

        /// <summary>
        /// 請求先ID
        /// </summary>
        public decimal CustomeID { get; set; }

        /// <summary>
        /// 発注書番号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 請求No
        /// </summary>
        public string BillingNo { get; set; }

        /// <summary>
        /// 作業名
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 作業内容
        /// </summary>
        public string ProjectContent { get; set; }

        /// <summary>
        /// 作業場所
        /// </summary>
        public string ProjectAdd { get; set; }

        /// <summary>
        /// 納品成果物
        /// </summary>
        public string Deliverables { get; set; }

        /// <summary>
        /// 支払区分
        /// </summary>
        public decimal PaymentType { get; set; }

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
