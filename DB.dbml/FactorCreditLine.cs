//-----------------------------------------------------------------------
// <copyright file="FactorCreditLine.cs" company="Yiming Liu@Fudan">
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
    public partial class FactorCreditLine 
    {
        #region Properties (3)

        /// <summary>
        /// Gets
        /// </summary>
        public double CreditLineOutstanding
        {
            get
            {
                return this.CreditLine - this.Factor.GetAssignOutstanding(this.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorName
        {
            get
            {
                return this.Factor.ToString();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorType
        {
            get
            {
                return this.Factor.FactorType;
            }
        }

        #endregion Properties
    }
}
