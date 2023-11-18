using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class SeikyuEditBillingModel
    {
        /// <summary>
        ///ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 請求日
        /// </summary>
        public DateTime BillingDate { get; set; }

        /// <summary>
        /// 請求番号
        /// </summary>
        public string BillingNo { get; set; }
        /// <summary>
        /// 請求枝番
        /// </summary>
        /// 
        public string BranchNo { get; set; }
        /// <summary>
        /// 請求日
        /// </summary>
        public DateTime BillingFromDate { get; set; }

        /// <summary>
        /// 請求日
        /// </summary>
        public DateTime BillingToDate { get; set; }

        /// <summary>
        /// 請求先ID
        /// </summary>
        /// 
        public string CustomeID { get; set; }
        /// <summary>
        /// 請求先名
        /// </summary>
        /// 
        public string CustomerName { get; set; }
        /// <summary>
        /// 部署
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 作業名
        /// </summary>
        public string OrderNo { get; set; }
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
        /// 成果物
        /// </summary>
        public string Deliverables { get; set; }
        /// <summary>
        /// 支払い条件
        /// </summary>
        public string PaymentType { get; set; }
        /// <summary>
        /// 支払い条件
        /// </summary>
        public string PaymentTypeName { get; set; }
        /// <summary>
        /// 支払い条件
        /// </summary>
        public DateTime PaymentDate { get; set; }
        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public int BillingAmount { get; set; }
        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public int Tax { get; set; }
        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public int BillingTax { get; set; }
        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public int TransportationAmount { get; set; }
        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public int BillingTotal { get; set; }
        /// <summary>
        ///振込先口座
        /// </summary>
        public string BankAccountID { get; set; }
        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public string ManagerID { get; set; }
        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public string Status { get; set; }

        /// <summary>
        /// 担当者
        /// </summary>
        /// 
        public string UserName { get; set; }

    }
}
