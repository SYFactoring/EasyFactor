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
        /// Gets
        /// </summary>
        public double AssignAmount
        {
            get
            {
                return Invoice.AssignAmount;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                return Invoice.AssignOutstanding;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime AssignDate
        {
            get
            {
                return Invoice.AssignDate;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime DueDate
        {
            get
            {
                return Invoice.DueDate;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double? FinanceAmount
        {
            get
            {
                return this.Invoice.FinanceAmount;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime? FinanceDate
        {
            get
            {
                return this.Invoice.FinanceDate;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime? FinanceDueDate
        {
            get
            {
                return this.Invoice.FinanceDueDate;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double? FinanceOutstanding
        {
            get
            {
                return this.Invoice.FinanceOutstanding;
            }
        }
    }
}
