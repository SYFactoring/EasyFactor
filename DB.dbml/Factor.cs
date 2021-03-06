//-----------------------------------------------------------------------
// <copyright file="Factor.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Factor
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly string CMBC_CODE = "CN01300";

        public static readonly string DEFAULT_FACTOR_CODE = "0000000";

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, string> _dict;


        /// <summary>
        /// Gets
        /// </summary>
        public FactorCreditLine CreditLine
        {
            get { return FactorCreditLines.SingleOrDefault(f => f.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public decimal CreditLineOutstanding
        {
            get
            {
                FactorCreditLine creditLine = CreditLine;
                if (creditLine == null)
                {
                    return 0;
                }

                return creditLine.CreditLine - GetAssignOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string GroupNameCN
        {
            get { return !String.IsNullOrEmpty(_GroupNo) ? FactorGroup.GroupNameCN : string.Empty; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string GroupNameEN
        {
            get { return !String.IsNullOrEmpty(_GroupNo) ? FactorGroup.GroupNameEN : string.Empty; }
        }


        //?Public?Methods?(4)?
        /// <summary>
        /// 
        /// </summary>
        public void BeginMonitor()
        {
            _dict = new Dictionary<string, string>();
            PropertyChanged += Factor_PropertyChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string EndMonitor()
        {
            if (_dict != null)
            {
                var sb = new StringBuilder();
                foreach (string value in _dict.Values)
                {
                    sb.Append(value).Append(Environment.NewLine);
                }

                PropertyChanged -= Factor_PropertyChanged;
                return sb.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<InvoiceAssignBatch> GetInvoiceAssignBatches(bool isAll)
        {
            var result = new List<InvoiceAssignBatch>();
            if (isAll)
            {
                foreach (Case c in BuyerCases.Where(ca => ca.CaseMark == CASE.ENABLE))
                {
                    result.AddRange(c.InvoiceAssignBatches);
                }

                foreach (Case c in SellerCases.Where(ca => ca.CaseMark == CASE.ENABLE))
                {
                    result.AddRange(c.InvoiceAssignBatches);
                }
            }
            else
            {
                foreach (Case c in BuyerCases.Where(ca => ca.CaseMark == CASE.ENABLE))
                {
                    result.AddRange(c.InvoiceAssignBatches.Where(b => b.CommissionRemittance == null));
                }

                foreach (Case c in SellerCases.Where(ca => ca.CaseMark == CASE.ENABLE))
                {
                    result.AddRange(c.InvoiceAssignBatches.Where(b => b.CommissionRemittance == null));
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public decimal GetAssignOutstanding(string currency)
        {
            decimal result = 0;
            foreach (Case curCase in BuyerCases.Where(c => c.CaseMark == CASE.ENABLE))
            {
                CDA cda = curCase.ActiveCDA;
                if (cda != null && cda.CreditCover.HasValue && cda.CreditCover.Value > 0)
                {
                    decimal assignOutstanding = curCase.AssignOutstanding;
                    if (curCase.InvoiceCurrency != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                        assignOutstanding *= exchange;
                    }

                    result += assignOutstanding;
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public decimal GetTotalCreditCover(string currency)
        {
            decimal result = 0;
            foreach (Case curCase in BuyerCases.Where(c => c.CaseMark == CASE.ENABLE))
            {
                CDA cda = curCase.ActiveCDA;
                if (cda != null && cda.CreditCover.HasValue && cda.CreditCoverPeriodEnd > DateTime.Today.AddDays(1))
                {
                    decimal creditCover = cda.CreditCover.Value;
                    if (cda.CreditCoverCurr != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(cda.CreditCoverCurr, currency);
                        creditCover *= exchange;
                    }

                    result += creditCover;
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return !String.IsNullOrEmpty(_CompanyNameCN) ? _CompanyNameCN : _CompanyNameEN;
        }

        //?Private?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Factor_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _dict[e.PropertyName] = String.Format("{0} : {1}\n", e.PropertyName,
                                                  GetType().GetProperty(e.PropertyName).GetValue(this, null));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (String.IsNullOrEmpty(CompanyNameCN))
                {
                    CompanyNameCN = "";
                }
                if (String.IsNullOrEmpty(CompanyNameEN))
                {
                    CompanyNameEN = "";
                }
            }
        }
    }
}