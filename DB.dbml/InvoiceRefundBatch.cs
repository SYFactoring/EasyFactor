//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundBatch.cs" company="Yiming Liu@Fudan">
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
    public partial class InvoiceRefundBatch
    {
        #region Properties (4)

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get
            {
                return this.InvoiceRefundLogs.Count;
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
        public double RefundAmount
        {
            get
            {
                double result = 0;
                foreach (InvoiceRefundLog refundLog in this.InvoiceRefundLogs)
                {
                    result += refundLog.RefundAmount;
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
