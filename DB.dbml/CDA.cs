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
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public partial class CDA : BaseObject
    {
        #region Properties (7)

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
        /// Gets 关联额度中的买方信用风险担保额度余额
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
                        case "国内卖方保理":
                        case "出口保理":
                        case "国内信保保理":
                        case "国际信保保理":
                        case "租赁保理":
                            return this.Case.SellerFactor.ToString();
                        case "国内买方保理":
                        case "进口保理":
                            return this.Case.BuyerFactor.ToString();
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
        /// Gets 关联额度中预付款融资额度余额
        /// </summary>
        public System.Nullable<double> FinanceLineOutstanding
        {
            get
            {
                if (!this.FinanceLine.HasValue)
                {
                    return null;
                }

                return this.FinanceLine - this.Case.FinanceOutstanding;
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

        /// <summary>
        /// 
        /// </summary>
        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                Client client;
                if (Case.TransactionType == "国内买方保理" || Case.TransactionType == "进口保理")
                {
                    client = Case.BuyerClient;
                }
                else
                {
                    client = Case.SellerClient;
                }
                return client.FinanceCreditLine;
            }
        }

        #endregion Properties

        #region Methods (3)

        // Public Methods (3) 

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

            Contract contract = selectedCase.SellerClient.Contract;
            if (contract != null)
            {
                if (contract.ContractType == "新合同")
                {
                    CDA formerCDA = App.Current.DbContext.CDAs.OrderByDescending(c => c.CDACode).FirstOrDefault(c => c.CDACode.StartsWith(contract.ContractCode));
                    if (formerCDA == null)
                    {
                        return string.Format("{0}-{1:000}", contract.ContractCode, 1);
                    }
                    else
                    {
                        int index = Int32.Parse(formerCDA.CDACode.Substring(formerCDA.CDACode.LastIndexOf("-") + 1));
                        return String.Format("{0}-{1:000}", contract.ContractCode, index + 1);
                    }
                }
                else
                {
                    return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, selectedCase.CDAs.Count + 1);
                }
            }
            else if (selectedCase.TransactionType == "进口保理")
            {
                return String.Format("{0}XXX-{1:000}", selectedCase.CaseCode, selectedCase.CDAs.Count + 1);
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion Methods
    }
}
