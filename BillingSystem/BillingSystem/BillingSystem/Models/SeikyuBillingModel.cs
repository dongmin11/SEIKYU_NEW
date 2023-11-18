﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class SeikyuBillingModel
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
        /// SQL取得開始位置）
        /// </summary>
        public int StartRow { get; set; }

        /// <summary>
        ///SQL取得終了位置
        /// </summary>
        public int EndRow { get; set; }

        /// <summary>
        ///SQL取得終了位置
        /// </summary>
        public int RowNo { get; set; }



    }
}
