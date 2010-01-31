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
        #region Properties (2)

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
        /// Gets
        /// </summary>
        public DateTime PaymentDate
        {
            get
            {
                return this.InvoicePaymentBatch.PaymentDate;
            }
        }

        #endregion Properties
    }
}
