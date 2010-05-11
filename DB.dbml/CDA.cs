//-----------------------------------------------------------------------
// <copyright file="CDA.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CMBC.EasyFactor.Utils.ConstStr;

    /// <summary>
    /// 
    /// </summary>
    public partial class CDA
    {
        #region?Properties?(8)?

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get
            {
                if (this.Case != null)
                {
                    return this.Case.BuyerClient.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets ��������е������÷��յ���������
        /// </summary>
        public System.Nullable<double> CreditCoverOutstanding
        {
            get
            {
                if (!this.CreditCover.HasValue)
                {
                    return null;
                }

                return this.CreditCover - this.Case.AssignOutstanding;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string FactorName
        {
            get
            {
                if (this.Case != null)
                {
                    switch (this.Case.TransactionType)
                    {
                        case "������������":
                        case "���ڱ���":
                            return this.Case.BuyerFactor.ToString();
                        case "�����򷽱���":
                        case "���ڱ���":
                            return this.Case.SellerFactor.ToString();
                        default:
                            return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                if (Case.IsPool)
                {
                    return Case.SellerClient.PoolFinanceCreditLine;
                }
                else
                {
                    if (Case.TransactionType == "�����򷽱���" || Case.TransactionType == "���ڱ���")
                    {
                        return Case.BuyerClient.FinanceCreditLine;
                    }
                    else
                    {
                        return Case.SellerClient.FinanceCreditLine;
                    }
                }
            }
        }

        /// <summary>
        /// Gets ���������Ԥ�������ʶ�����
        /// </summary>
        public System.Nullable<double> FinanceLineOutstanding
        {
            get
            {
                if (!this.FinanceLine.HasValue)
                {
                    return null;
                }

                double financeLine = this.FinanceLine.GetValueOrDefault();
                double financeOutstanding = this.Case.FinanceOutstanding.GetValueOrDefault();
                if (this.Case.InvoiceCurrency != this.FinanceLineCurr)
                {
                    double rate = Exchange.GetExchangeRate(this.Case.InvoiceCurrency, this.FinanceLineCurr);
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
            get
            {
                if (this.Case != null)
                {
                    return this.Case.InvoiceCurrency;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                if (this.Case != null)
                {
                    return this.Case.SellerClient.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string TransactionType
        {
            get
            {
                if (this.Case != null)
                {
                    return this.Case.TransactionType;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        #endregion?Properties?

        #region?Methods?(3)?

        //?Public?Methods?(3)?

        /// <summary>
        /// 
        /// </summary>
        public void AdjustCDAStatus()
        {
            if (String.IsNullOrEmpty(this.CDAStatus))
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

            DBDataContext context = new DBDataContext();
            Contract contract = selectedCase.SellerClient.Contract;
            if (contract != null)
            {
                if (contract.ContractType == "�º�ͬ")
                {
                    var queryResult = from cda in context.CDAs
                                      where cda.CDACode.StartsWith(contract.ContractCode)
                                      select cda.CDACode;
                    int count = 0;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(contract.ContractCode.Length + 1)), out count))
                    {
                        count = 0;
                    }

                    return String.Format("{0}-{1:000}", contract.ContractCode, count + 1);
                }
                else
                {
                    var queryResult = from cda in context.CDAs
                                      where cda.CDACode.StartsWith(selectedCase.CaseCode+"XXX")
                                      select cda.CDACode;

                    int count = 0;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 4)), out count))
                    {
                        count = 0;
                    }

                    return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, count + 1);
                }
            }
            else if (selectedCase.TransactionType == "���ڱ���")
            {
                var queryResult = from cda in context.CDAs
                                  where cda.CDACode.StartsWith(selectedCase.CaseCode)
                                  select cda.CDACode;
                int count = 0;
                if (!Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 4)), out count))
                {
                    count = 0;
                }

                return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, count + 1);
            }
            else
            {
                return string.Empty;
            }
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

            DBDataContext context = new DBDataContext();
            Contract contract = selectedCase.SellerClient.Contract;
            if (contract != null)
            {
                if (contract.ContractType == "�º�ͬ")
                {
                    var queryResult = from cda in context.CDAs
                                      where cda.CDACode.StartsWith(contract.ContractCode)
                                      select cda.CDACode;
                    int count = 0;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(contract.ContractCode.Length + 1)), out count))
                    {
                        count = 0;
                    }

                    count += cdaList.Count(cda => cda.CDACode.StartsWith(contract.ContractCode));
                    return String.Format("{0}-{1:000}", contract.ContractCode, count + 1);
                }
                else
                {
                    var queryResult = from cda in context.CDAs
                                      where cda.CDACode.StartsWith(selectedCase.CaseCode + "XXX")
                                      select cda.CDACode;

                    int count = 0;
                    if (!Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 4)), out count))
                    {
                        count = 0;
                    }

                    count += cdaList.Count(cda => cda.CDACode.StartsWith(selectedCase.CaseCode + "XXX"));
                    return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, count + 1);
                }
            }
            else if (selectedCase.TransactionType == "���ڱ���")
            {
                var queryResult = from cda in context.CDAs
                                  where cda.CDACode.StartsWith(selectedCase.CaseCode)
                                  select cda.CDACode;
                int count = 0;
                if (!Int32.TryParse(queryResult.Max(no => no.Substring(selectedCase.CaseCode.Length + 4)), out count))
                {
                    count = 0;
                }

                count += cdaList.Count(cda => cda.CDACode.StartsWith(selectedCase.CaseCode));
                return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, count + 1);
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion?Methods?
    }
}
