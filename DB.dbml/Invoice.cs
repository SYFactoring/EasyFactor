﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Invoice
    {
        public string SellerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.SellerClient.ToString();
            }
        }

        public string BuyerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.BuyerClient.ToString();
            }
        }

        public string TransactionType
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.TransactionType;
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

        public double AssignOutstanding
        {
            get
            {
                return this.AssignAmount.GetValueOrDefault() - this.PaymentAmount.GetValueOrDefault();
            }
        }

        public double FinanceOutstanding
        {
            get
            {
                return this.FinanceAmount.GetValueOrDefault() - this.RefundAmount.GetValueOrDefault();
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

        public System.Nullable<double> AROverDueDays
        {
            get
            {
                if (this.DueDate.HasValue)
                {
                    TimeSpan duedays = DateTime.Now - this.DueDate.Value;
                    return duedays.TotalDays;
                }
                else
                {
                    return null;
                }
            }
        }

        public System.Nullable<double> FinanceOverDueDays
        {
            get
            {
                if (this.FinanceDueDate.HasValue)
                {
                    TimeSpan duedays = DateTime.Now - this.FinanceDueDate.Value;
                    return duedays.TotalDays;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}