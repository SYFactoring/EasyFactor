//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinanceLog
    {
        public double? FinanceOutstanding
        {
            get
            {
                return this.FinanceAmount - RefundAmount;
            }
        }

        public double? RefundAmount
        {
            get
            {
                this.InvoiceRefundLogs.Sum(log => log.RefundAmount);
            }
        }
    }
}
