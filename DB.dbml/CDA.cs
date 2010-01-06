using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class CDA : BaseObject
    {
        #region Properties (11)

        /// <summary>
        /// 转让余额
        /// </summary>
        public System.Nullable<double> AssignOutstanding
        {
            get
            {
                double? total = null;
                foreach (InvoiceAssignBatch assignBatch in this.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        if (invoice.AssignOutstanding.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }
                            total += invoice.AssignOutstanding.Value;
                        }
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// 转让总额
        /// </summary>
        public System.Nullable<double> AssignTotal
        {
            get
            {
                double? total = null;
                foreach (InvoiceAssignBatch batch in this.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in batch.Invoices)
                    {
                        double? temp = invoice.AssignAmount;
                        if (temp.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }
                            total += temp.Value;
                        }
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// 
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
        /// 关联额度中的买方信用风险担保额度余额
        /// </summary>
        public System.Nullable<double> CreditCoverOutstanding
        {
            get
            {
                if (this.CreditCover == null)
                {
                    return null;
                }
                if (this.CreditCover == 0)
                {
                    return 0;
                }
                return this.CreditCover - this.AssignOutstanding;
            }
        }

        /// <summary>
        /// 关联额度中预付款融资额度余额
        /// </summary>
        public System.Nullable<double> FinanceLineOutstanding
        {
            get
            {
                if (this.FinanceLine == null)
                {
                    return null;
                }
                if (this.FinanceLine == 0)
                {
                    return 0;
                }
                return this.FinanceLine - this.FinanceOutstanding;
            }
        }

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
        /// 融资余额
        /// </summary>
        public System.Nullable<double> FinanceOutstanding
        {
            get
            {
                double? total = null;
                foreach (InvoiceAssignBatch assignBatch in this.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        if (invoice.FinanceOutstanding.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }
                            total += invoice.FinanceOutstanding.Value;
                        }
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// 融资总额
        /// </summary>
        public System.Nullable<double> FinanceTotal
        {
            get
            {
                double? total = null;
                foreach (InvoiceAssignBatch batch in this.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in batch.Invoices)
                    {
                        double? temp = invoice.FinanceAmount;
                        if (temp.HasValue)
                        {
                            if (total == null)
                            {
                                total = 0;
                            }
                            total += temp.Value;
                        }
                    }
                }
                return total;
            }
        }

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

        #endregion Properties

        #region Methods (1)

        // Public Methods (1) 

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
            else if (selectedCase.TransactionType == "进口保理")
            {
                return String.Format("{0}000-{1:000}", selectedCase.CaseCode, selectedCase.CDAs.Count + 1);
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion Methods
    }
}
