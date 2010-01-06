using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class CDA : BaseObject
    {
        #region Properties (9)

        /// <summary>
        /// 
        /// </summary>
        public System.Nullable<double> AROutstanding
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

        public string BuyerName
        {
            get
            {
                return this.Case.BuyerClient.ToString();
            }
        }

        /// <summary>
        /// 
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
                return this.CreditCover - total;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Nullable<double> CreditLineOutstanding
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
                return this.FinanceLine - total;
            }
        }

        public string FactorName
        {
            get
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
        }

        /// <summary>
        /// 
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

        public string InvoiceCurrency
        {
            get
            {
                return this.Case.InvoiceCurrency;
            }
        }

        public string SellerName
        {
            get
            {
                return this.Case.SellerClient.ToString();
            }
        }

        public string TransactionType
        {
            get
            {
                return this.Case.TransactionType;
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
