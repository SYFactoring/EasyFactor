//-----------------------------------------------------------------------
// <copyright file="InvoicePaymentLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePaymentLog
    {
        #region Properties (6)

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get
            {
                return this.Invoice.AssignAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate
        {
            get
            {
                return this.Invoice.AssignDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                return this.Invoice.AssignOutstanding;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime CreditNoteDate
        {
            get
            {
                return this.CreditNote.CreditNoteDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DueDate
        {
            get
            {
                return this.Invoice.DueDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoicePaymentAmount
        {
            get
            {
                return this.Invoice.PaymentAmount;
            }
        }

        #endregion Properties
    }
}
