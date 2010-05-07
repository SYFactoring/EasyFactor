//-----------------------------------------------------------------------
// <copyright file="CreditCoverNegotiation.cs" company="Yiming Liu@Fudan">
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
    public partial class CreditCoverNegotiation
    {
		#region?Properties?(8)?

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerCountry
        {
            get
            {
                return this.Case.BuyerClient.CountryCode;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerFactorName
        {
            get
            {
                return this.Case.BuyerFactor.ToString();
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
        public string CaseCurrency
        {
            get
            {
                return this.Case.InvoiceCurrency;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string OwnerDept
        {
            get
            {
                return this.Case.OwnerDepartment.DepartmentName;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerFactorName
        {
            get
            {
                return this.Case.SellerFactor.ToString();
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
        /// Gets
        /// </summary>
        public string TransactionType
        {
            get
            {
                return this.Case.TransactionType;
            }
        }

		#endregion?Properties?
    }
}
