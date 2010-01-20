//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignBatch.cs" company="Yiming Liu@Fudan">
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
    public partial class InvoiceAssignBatch
    {
        #region Properties (4)

        /// <summary>
        /// Gets
        /// </summary>
        public double AssignAmount
        {
            get
            {
                double result = 0;
                foreach (Invoice invoice in this.Invoices)
                {
                    result += invoice.AssignAmount;
                }
                return result;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get
            {
                return this.Invoices.Count;
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
