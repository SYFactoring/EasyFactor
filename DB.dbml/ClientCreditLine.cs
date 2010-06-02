//-----------------------------------------------------------------------
// <copyright file="ClientCreditLine.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientCreditLine
    {
        private static readonly Regex ApproveNoRegex = new Regex(@"^[a-zA-Z0-9]+$");


        /// <summary>
        /// Gets
        /// </summary>
        public double AssignCreditLineOutstanding
        {
            get
            {
                double result = CreditLine - Client.GetAssignOutstandingAsBuyer(CreditLineCurrency);
                if (ClientCreditLines.Count > 0)
                {
                    result = ClientCreditLines.Aggregate(result, (current, creditLine) => current - creditLine.Client.GetAssignOutstandingAsBuyer(CreditLineCurrency));
                }

                return result;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string ClientNameCN
        {
            get { return Client != null ? Client.ClientNameCN : string.Empty; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string ClientNameEN
        {
            get { return Client != null ? Client.ClientNameEN : string.Empty; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double FinanceCreditLineOutstanding
        {
            get
            {
                double result = CreditLine - Client.GetFinanceOutstanding(CreditLineCurrency).GetValueOrDefault();
                if (ClientCreditLines.Count > 0)
                {
                    result = ClientCreditLines.Aggregate(result, (current, creditLine) => current - creditLine.Client.GetFinanceOutstanding(CreditLineCurrency).GetValueOrDefault());
                }

                return result;
            }
        }


        //?Private?Methods?(1)?
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!String.IsNullOrEmpty(ApproveNo) && !ApproveNoRegex.IsMatch(ApproveNo))
                {
                    throw new ArgumentException("不符合授信编号规则: " + ApproveNo);
                }
            }
        }
    }
}