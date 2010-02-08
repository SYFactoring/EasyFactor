//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceBatch.cs" company="Yiming Liu@Fudan">
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
    public partial class InvoiceFinanceBatch
    {
        #region Properties (3)

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
                return this.Case.BuyerClient.ToString();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                return this.Case.SellerClient.ToString();
            }
        }

        /// <summary>
        /// 净利息收入
        /// </summary>
        public double? NetInterestIncome
        {
            get
            {
                double? result = null;
                foreach (Invoice invoice in this.Invoices)
                {
                    double? value = invoice.NetInterest;
                    if (value != null)
                    {
                        if (result == null)
                        {
                            result = 0;
                        }

                        result += value;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 毛利息收入
        /// </summary>
        public double? GrossInterestIncome
        {
            get
            {
                double? result = 0;
                foreach (Invoice invoice in this.Invoices)
                {
                    double? value = invoice.GrossInterest;
                    if (value != null)
                    {
                        if (result == null)
                        {
                            result = 0;
                        }
                    }

                    result += value;
                }

                return result;
            }
        }
        #endregion Properties
    }
}
