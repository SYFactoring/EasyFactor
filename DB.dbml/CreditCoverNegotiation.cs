//-----------------------------------------------------------------------
// <copyright file="CreditCoverNegotiation.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CreditCoverNegotiation
    {
        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerCountry
        {
            get { return Case.BuyerClient.CountryCode; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerFactorName
        {
            get { return Case.BuyerFactor.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get { return Case.BuyerClient.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string CaseCurrency
        {
            get { return Case.InvoiceCurrency; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string OwnerDept
        {
            get { return Case.OwnerDepartment.DepartmentName; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerFactorName
        {
            get { return Case.SellerFactor.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get { return Case.SellerClient.ToString(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string TransactionType
        {
            get { return Case.TransactionType; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (TypeUtil.LessZero(RequestAmount))
                {
                    throw new Exception(String.Format("申请金额{0:N2}不能为负: {1}", RequestAmount, NegoID));
                }

                if (TypeUtil.LessZero(ReplyAmount))
                {
                    throw new Exception(String.Format("回复金额{0:N2}不能为负: {1}", ReplyAmount, NegoID));
                }
            }
        }
    }
}