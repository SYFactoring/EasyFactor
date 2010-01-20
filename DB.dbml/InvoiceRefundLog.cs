//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefundLog
    {
        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get
            {
                return Invoice.AssignAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                return Invoice.AssignOutstanding;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate
        {
            get
            {
                return Invoice.AssignDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DueDate
        {
            get
            {
                return Invoice.DueDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceAmount
        {
            get
            {
                return this.Invoice.FinanceAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate
        {
            get
            {
                return this.Invoice.FinanceDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDueDate
        {
            get
            {
                return this.Invoice.FinanceDueDate;
            }
        }

        /// <summary>
        /// 
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
