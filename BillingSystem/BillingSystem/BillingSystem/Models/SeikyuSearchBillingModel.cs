﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class SeikyuSearchBillingModel
    {
        /// <summary>
        /// 請求日
        /// </summary>
        public DateTime BillingDate { get; set; }
        /// <summary>
        /// 請求番号
        /// </summary>
        public string BillingNo { get; set; }
        /// <summary>
        /// 顧客番号
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// 顧客番号
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 支払い種別
        /// </summary>
        public string PaymentType { get; set; }
        /// <summary>
        /// 請求額（税抜き）
        /// </summary>
        public int BillingAmount { get; set; }
        /// <summary>
        /// 税金
        /// </summary>
        public int BillingTax { get; set; }
        /// <summary>
        /// 交通費
        /// </summary>
        public int TransportationAmount { get; set; }
        /// <summary>
        /// 請求日（税込み）
        /// </summary>
        public int BillingTotal { get; set; }
        /// <summary>
        ///開始日
        /// </summary>
        public string StartDate { get; set; }
        /// <summary>
        /// 終了日
        /// </summary>
        public string EndDate { get; set; }
        /// <summary>
        /// 削除フラグ
        /// </summary>
        public bool DeleteFlag { get; set; }
        /// <summary>
        /// 取得開始列
        /// </summary>
        public int StartRow { get; set; }
        /// <summary>
        /// 取得終了列
        /// </summary>
        public int EndRow { get; set; }

        /// <summary>
        /// 行数
        /// </summary>
        public int RowNo { get; set; }
        /// <summary>
        ///SQL取得終了位置
        /// </summary>
        public int chkInProgress { get; set; }
        public int chkPendingApproval { get; set; }
        public int chkApproved { get; set; }
        public int chkCompleted { get; set; }
        public int chkSent { get; set; }
        public bool StatusFlg { get; set; }
        public bool StatusFlg2 { get; set; }
        public string CodeName { get; set; }
        public string UserName { get; set; }
        public string UserID { get; set; }
        /// <summary>
        ///ID
        /// </summary>
        public int ID { get; set; }
    }
}
