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
        #region Properties (5)

        /// <summary>
        /// 
        /// </summary>
        public double FinanceAmount
        {
            get
            {
                return this.InvoiceFinanceLog.FinanceAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime FinanceDate
        {
            get
            {
                return this.InvoiceFinanceLog.InvoiceFinanceBatch.FinancePeriodBegin;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime FinanceDueDate
        {
            get
            {
                return this.InvoiceFinanceLog.InvoiceFinanceBatch.FinancePeriodEnd;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceOutstanding
        {
            get
            {
                return this.InvoiceFinanceLog.FinanceOutstanding;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? LogRefundAmount
        {
            get
            {
                return this.InvoiceFinanceLog.RefundAmount;
            }
        }

        #endregion Properties
    }
}
