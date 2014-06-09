//-----------------------------------------------------------------------
// <copyright file="CDA.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CDA
    {
        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get { return Case != null ? Case.BuyerClient.ToString() : string.Empty; }
        }

        /// <summary>
        /// Gets 关联额度中的买方信用风险担保额度余额
        /// </summary>
        public decimal? CreditCoverOutstanding
        {
            get
            {
                if (!CreditCover.HasValue)
                {
                    return null;
                }

                decimal assignOutstanding = Case.AssignOutstanding;
                if (Case.InvoiceCurrency != this.CreditCoverCurr)
                {
                    decimal rate = Exchange.GetExchangeRate(Case.InvoiceCurrency, CreditCoverCurr);
                    assignOutstanding *= rate;
                }

                return CreditCover - assignOutstanding;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorName
        {
            get
            {
                if (Case != null)
                {
                    switch (Case.TransactionType)
                    {
                        case "国内卖方保理":
                        case "出口保理":
                            return Case.BuyerFactor.ToString();
                        case "国内买方保理":
                        case "进口保理":
                            return Case.SellerFactor.ToString();
                        default:
                            return string.Empty;
                    }
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets 关联额度中预付款融资额度余额
        /// </summary>
        public decimal? FinanceLineOutstanding
        {
            get
            {
                if (!FinanceLine.HasValue)
                {
                    return null;
                }

                decimal financeLine = FinanceLine.GetValueOrDefault();
                decimal financeOutstanding = Case.FinanceOutstanding.GetValueOrDefault();
                if (Case.InvoiceCurrency != FinanceLineCurr)
                {
                    decimal rate = Exchange.GetExchangeRate(Case.InvoiceCurrency, FinanceLineCurr);
                    financeOutstanding *= rate;
                }

                return financeLine - financeOutstanding;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string InvoiceCurrency
        {
            get { return Case != null ? Case.InvoiceCurrency : string.Empty; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get { return Case != null ? Case.SellerClient.ToString() : string.Empty; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string TransactionType
        {
            get { return Case != null ? Case.TransactionType : string.Empty; }
        }


        //?Public?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        public void AdjustCDAStatus()
        {
            if (String.IsNullOrEmpty(CDAStatus))
            {
                return;
            }

            CDA checkCDA = Case.CDAs.OrderByDescending(c => c.CDASignDate).First();
            if (String.IsNullOrEmpty(checkCDA.CDAStatus))
            {
                checkCDA.CDAStatus = CDAStr.CHECKED;
            }

            foreach (CDA c in Case.CDAs)
            {
                if (c != checkCDA && (String.IsNullOrEmpty(c.CDAStatus) || c.CDAStatus == CDAStr.CHECKED))
                {
                    c.CDAStatus = CDAStr.INVALID;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <returns></returns>
        public static string GenerateCDACode(Case selectedCase)
        {
            if (selectedCase == null)
            {
                return string.Empty;
            }

            var context = new DBDataContext();
            Contract contract = selectedCase.SellerClient.Contract;
            if (contract != null)
            {
                //if (contract.ContractType == "新合同")
                //{
                //    IQueryable<string> queryResult = from cda in context.CDAs
                //                                     where cda.CDACode.StartsWith(contract.ContractCode)
                //                                     select cda.CDACode;
                //    int count;
                //    if (
                //        !Int32.TryParse(queryResult.Max(no => no.Substring(contract.ContractCode.Length + 1)), out count))
                //    {
                //        count = 0;
                //    }

                //    return String.Format("{0}-{1:000}", contract.ContractCode, count + 1);
                //}
                //else
                //{
                    IQueryable<string> queryResult = from cda in context.CDAs
                                                     where cda.CDACode.StartsWith(selectedCase.CaseCode)
                                                     select cda.CDACode;

                    int count;
                    if (
                        !Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 4)), out count))
                    {
                        count = 0;
                    }

                    return String.Format("{0}-{1:000}", selectedCase.CaseCode, count + 1);
                //}
            }
            if (selectedCase.TransactionType == "进口保理")
            {
                IQueryable<string> queryResult = from cda in context.CDAs
                                                 where cda.CDACode.StartsWith(selectedCase.CaseCode)
                                                 select cda.CDACode;
                int count;
                if (!Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 1)), out count))
                {
                    count = 0;
                }

                return String.Format("{0}-{1:000}", selectedCase.CaseCode, count + 1);
            }
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <param name="cdaList"></param>
        /// <returns></returns>
        public static string GenerateCDACode(Case selectedCase, List<CDA> cdaList)
        {
            if (selectedCase == null)
            {
                return string.Empty;
            }

            var context = new DBDataContext();
            Contract contract = selectedCase.SellerClient.Contract;
            if (contract != null)
            {
                if (contract.ContractType == "新合同")
                {
                    IQueryable<string> queryResult = from cda in context.CDAs
                                                     where cda.CDACode.StartsWith(contract.ContractCode)
                                                     select cda.CDACode;
                    int count;
                    if (
                        !Int32.TryParse(queryResult.Max(no => no.Substring(contract.ContractCode.Length + 1)), out count))
                    {
                        count = 0;
                    }

                    count += cdaList.Count(cda => cda.CDACode.StartsWith(contract.ContractCode));
                    return String.Format("{0}-{1:000}", contract.ContractCode, count + 1);
                }
                else
                {
                    IQueryable<string> queryResult = from cda in context.CDAs
                                                     where cda.CDACode.StartsWith(selectedCase.CaseCode + "XXX")
                                                     select cda.CDACode;

                    int count;
                    if (
                        !Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 4)), out count))
                    {
                        count = 0;
                    }

                    count += cdaList.Count(cda => cda.CDACode.StartsWith(selectedCase.CaseCode + "XXX"));
                    return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, count + 1);
                }
            }
            if (selectedCase.TransactionType == "进口保理")
            {
                IQueryable<string> queryResult = from cda in context.CDAs
                                                 where cda.CDACode.StartsWith(selectedCase.CaseCode)
                                                 select cda.CDACode;
                int count;
                if (!Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 4)), out count))
                {
                    count = 0;
                }

                count += cdaList.Count(cda => cda.CDACode.StartsWith(selectedCase.CaseCode));
                return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, count + 1);
            }
            return string.Empty;
        }
    }
}