using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class InvoicePaymentLog
    {
        #region Properties (1)

        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            switch (action)
            {
                case System.Data.Linq.ChangeAction.Insert:
                    Invoice.PaymentAmount = Invoice.PaymentAmount.GetValueOrDefault() + PaymentAmount;
                    if (this.InvoicePaymentBatch.PaymentDate > Invoice.PaymentDate)
                    {
                        Invoice.PaymentDate = this.InvoicePaymentBatch.PaymentDate;
                    }
                    break;
                case System.Data.Linq.ChangeAction.Update:
                    Invoice.PaymentAmount = Invoice.InvoicePaymentLogs.Sum(log => log.PaymentAmount);
                    Invoice.PaymentDate = Invoice.InvoicePaymentLogs.Max(log => log.InvoicePaymentBatch.PaymentDate);
                    break;
                case System.Data.Linq.ChangeAction.Delete:
                    if(Invoice.InvoicePaymentLogs.Count==1)
                    {
                        Invoice.PaymentAmount=null;
                        Invoice.PaymentDate=null;
                    }
                    else
                    {
                        Invoice.PaymentAmount = Invoice.PaymentAmount.GetValueOrDefault() - PaymentAmount;
                        DateTime maxDate = default(DateTime);
                        foreach (InvoicePaymentLog log in Invoice.InvoicePaymentLogs)
                        {
                            if (log == this)
                            {
                                continue;
                            }
                            if (log.InvoicePaymentBatch.PaymentDate > maxDate)
                            {
                                maxDate = log.InvoicePaymentBatch.PaymentDate;
                            }
                        }
                        Invoice.PaymentDate = maxDate;
                    }
                    break;
                default:
                    break;
            }

        }

        public DateTime CreditNoteDate
        {
            get
            {
                return this.CreditNote.CreditNoteDate;
            }
        }
        public double AssignAmount
        {
            get
            {
                return Invoice.AssignAmount;
            }
        }
        public double AssignOutstanding
        {
            get
            {
                return Invoice.AssignOutstanding;
            }
        }
        public DateTime AssignDate
        {
            get
            {
                return Invoice.AssignDate;
            }
        }
        public DateTime DueDate
        {
            get
            {
                return Invoice.DueDate;
            }
        }
        public double? FinanceAmount
        {
            get
            {
                return this.Invoice.FinanceAmount;
            }
        }
        public DateTime? FinanceDate
        {
            get
            {
                return this.Invoice.FinanceDate;
            }
        }
        public DateTime? FinanceDueDate
        {
            get
            {
                return this.Invoice.FinanceDueDate;
            }
        }
        public double? FinanceOutstanding
        {
            get
            {
                return this.Invoice.FinanceOutstanding;
            }
        }
        #endregion Properties

    }
}
