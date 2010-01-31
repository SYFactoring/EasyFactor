//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefundLog
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime RefundDate
        {
            get
            {
                return this.InvoiceRefundBatch.RefundDate;
            }
        }
    }
}
