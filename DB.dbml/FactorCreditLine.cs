//-----------------------------------------------------------------------
// <copyright file="FactorCreditLine.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FactorCreditLine
    {
        /// <summary>
        /// Gets ’ÀøÓ”‡∂Ó
        /// </summary>
        public double CreditLineAssignOutstanding
        {
            get { return CreditLine - Factor.GetAssignOutstanding(CreditLineCurrency); }
        }

        /// <summary>
        /// Gets  £”‡∂Ó∂»
        /// </summary>
        public double CreditLineOustanding
        {
            get { return CreditLine - Factor.GetTotalCreditCover(CreditLineCurrency); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorName
        {
            get { return Factor.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorType
        {
            get { return Factor.FactorType; }
        }
    }
}