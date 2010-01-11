using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Invoice : BaseObject
    {
        #region Properties (11)

        public DateTime AssignDate
        {
            get
            {
                return this.InvoiceAssignBatch.AssignDate;
            }
        }

        public double AssignOutstanding
        {
            get
            {
                return this.AssignAmount - this.PaymentAmount.GetValueOrDefault();
            }
        }

        public System.Nullable<int> AssignOverDueDays
        {
            get
            {
                if (TypeUtil.GreaterZero(AssignOutstanding))
                {
                    return (DateTime.Now.Date - this.DueDate).Days;
                }
                return null;
            }
        }

        public string BuyerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.BuyerClient.ToString();
            }
        }

        public string FactorName
        {
            get
            {
                string transactionType = this.InvoiceAssignBatch.CDA.Case.TransactionType;
                switch (transactionType)
                {
                    case "国内卖方保理":
                    case "国内买方保理":
                    case "租赁保理":
                        return string.Empty;
                    case "国内信保保理":
                    case "国际信保保理":
                    case "出口保理":
                        return this.InvoiceAssignBatch.CDA.Case.BuyerFactor.ToString();
                    case "进口保理":
                        return this.InvoiceAssignBatch.CDA.Case.SellerFactor.ToString();
                    default:
                        return string.Empty;
                }
            }
        }

        public string FinanceCurrency
        {
            get
            {
                if (this.InvoiceFinanceBatch != null)
                {
                    return this.InvoiceFinanceBatch.BatchCurrency;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public System.Nullable<double> FinanceOutstanding
        {
            get
            {
                if (!this.FinanceAmount.HasValue)
                    return null;
                return this.FinanceAmount.Value - this.RefundAmount.GetValueOrDefault();
            }
        }

        public System.Nullable<int> FinanceOverDueDays
        {
            get
            {
                if (TypeUtil.GreaterZero(FinanceOutstanding))
                {
                    TimeSpan duedays = DateTime.Now.Date - this.FinanceDueDate.Value;
                    return duedays.Days;
                }
                else
                {
                    return null;
                }
            }
        }

        public string InvoiceCurrency
        {
            get
            {
                return this.InvoiceAssignBatch.BatchCurrency;
            }
        }

        public string SellerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.SellerClient.ToString();
            }
        }

        public string TransactionType
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.TransactionType;
            }
        }

        #endregion Properties

        #region Methods (2)

        // Public Methods (2) 

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Invoice right = obj as Invoice;
            if (right == null)
            {
                return false;
            }
            return this.GetHashCode() == right.GetHashCode();
        }

        public override int GetHashCode()
        {
            if (this.InvoiceNo == null)
            {
                return 0;
            }
            else
            {
                return this.InvoiceNo.GetHashCode();
            }
        }

        #endregion Methods
    }
}
