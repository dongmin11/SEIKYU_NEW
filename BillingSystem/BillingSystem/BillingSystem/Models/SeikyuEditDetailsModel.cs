﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models.TableModel
{
    public class SeikyuEditDetailsModel
    {
        /// <summary>
        /// 社員名
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// 労働時間
        /// </summary>
        /// dd
        public string WorkingHours { get; set; }
        /// <summary>
        /// 基本月給
        /// </summary>
        /// 
        public int BasicAmount { get; set; }
        /// <summary>
        /// 過不足清算下限名
        /// </summary>
        /// 
        public string LowerLimitName { get; set; }
        /// <summary>
        /// 過不足清算下限単価
        /// </summary>
        /// 
        public int LowerLimitUnit { get; set; }
        /// <summary>
        /// 過不足清算下限金額
        /// </summary>
        /// 
        public int LowerLimitAmount { get; set; }
        /// <summary>
        /// 過不足清算上限名
        /// </summary>
        public string UpperLimitName { get; set; }
        /// <summary>
        /// 過不足清算上限単価
        /// </summary>
        /// 
        public int UpperLimitUnit { get; set; }
        /// <summary>
        /// 過不足清算上限金額
        /// </summary>
        /// 
        public int UpperLimitAmount { get; set; }
        /// <summary>
        /// 請求金額
        /// </summary>
        /// 
        public int BillingAmount { get; set; }
        /// <summary>
        /// 交通費
        /// </summary>
        public int TransportationAmount { get; set; }

        public string ID { get; set; }
    }
}
