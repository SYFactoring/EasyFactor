//-----------------------------------------------------------------------
// <copyright file="ClientCreditLine.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientCreditLine
    {
        private static readonly Regex ApproveNoRegex = new Regex(@"^[a-zA-Z0-9]+$");

        public decimal CreditLineOutstanding
        {
            get
            {
                if(CreditLineType=="保理预付款融资额度")
                {
                    return FinanceCreditLineOutstanding;
                }else if(CreditLineType=="买方信用风险担保额度")
                {
                    return AssignCreditLineOutstanding;
                }else if(CreditLineType=="池融资额度")
                {
                    return CreditLine;
                }else if(CreditLineType=="订单融资额度")
                {
                    return CreditLine;
                }else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public decimal AssignCreditLineOutstanding
        {
            get
            {
                decimal result = CreditLine - Client.GetAssignOutstandingAsBuyer(CreditLineCurrency);
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
        public decimal FinanceCreditLineOutstanding
        {
            get
            {
                decimal result = CreditLine - Client.GetFinanceOutstanding(CreditLineCurrency).GetValueOrDefault();
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
                    throw new Exception("不符合授信编号规则: " + ApproveNo);
                }
            }

            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (CreditLine<0)
                {
                    throw new Exception(String.Format("额度金额{0:N2}不能为负: {1}", CreditLine,
                                 ApproveNo));
                }
            }
        }
    }
}