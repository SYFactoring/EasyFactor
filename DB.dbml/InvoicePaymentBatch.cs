//-----------------------------------------------------------------------
// <copyright file="InvoicePaymentBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePaymentBatch : BaseObject
    {
        #region Properties (4)

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get
            {
                return this.InvoicePaymentLogs.Count;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get
            {
                return this.CDA.Case.BuyerClient.ToString();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double PaymentAmount
        {
            get
            {
                double result = 0;
                foreach (InvoicePaymentLog paymentLog in this.InvoicePaymentLogs)
                {
                    result += paymentLog.PaymentAmount;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                return this.CDA.Case.SellerClient.ToString();
            }
        }

        #endregion Properties
    }
}
