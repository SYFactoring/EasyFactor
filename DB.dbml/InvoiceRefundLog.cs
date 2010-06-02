//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefundLog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="financeLog"></param>
        public InvoiceRefundLog(InvoiceFinanceLog financeLog)
            : this()
        {
            AssignBatchNo2 = financeLog.Invoice.AssignBatchNo;
            InvoiceNo2 = financeLog.Invoice.InvoiceNo;
            FinanceLogID2 = financeLog.FinanceLogID;
            FinanceAmount2 = financeLog.FinanceAmount;
            FinanceOutstanding2 = financeLog.FinanceOutstanding;
            FinanceDate2 = financeLog.FinanceDate;
            FinanceDueDate2 = financeLog.FinanceDueDate;
            InvoiceRefundAmount2 = financeLog.RefundAmount;
            InvoicePaymentAmount2 = financeLog.Invoice.PaymentAmount;
            RefundCurrency2 = financeLog.InvoiceFinanceBatch.BatchCurrency;
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceAmount
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.FinanceAmount;
                }
                return FinanceAmount2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.FinanceDate;
                }
                return FinanceDate2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDueDate
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.FinanceDueDate;
                }
                return FinanceDueDate2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDueDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FinanceLogID2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceOutstanding
        {
            get { return InvoiceFinanceLog != null ? InvoiceFinanceLog.FinanceOutstanding : FinanceOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceOutstanding2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo
        {
            get { return InvoiceFinanceLog.Invoice.InvoiceNo; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AssignBatchNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoicePaymentAmount
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.Invoice.PaymentAmount;
                }
                return InvoicePaymentAmount2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoicePaymentAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceRefundAmount
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.RefundAmount;
                }
                return InvoiceRefundAmount2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceRefundAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RefundCurrency
        {
            get
            {
                if (InvoiceFinanceLog != null)
                {
                    return InvoiceFinanceLog.InvoiceFinanceBatch.BatchCurrency;
                }
                return RefundCurrency2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RefundCurrency2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RefundDate
        {
            get { return InvoiceRefundBatch.RefundDate; }
        }
    }
}