//-----------------------------------------------------------------------
// <copyright file="InvoicePaymentLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePaymentLog
    {

        public InvoicePaymentLog(Invoice invoice)
            : this()
        {
            AssignBatchNo2 = invoice.AssignBatchNo;
            InvoiceID2 = invoice.InvoiceID;
            InvoiceNo2 = invoice.InvoiceNo;
            AssignAmount2 = invoice.AssignAmount;
            AssignOutstanding2 = invoice.AssignOutstanding;
            DueDate2 = invoice.DueDate;
            AssignDate2 = invoice.AssignDate;
            InvoicePaymentAmount2 = invoice.PaymentAmount;
        }



        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get { return Invoice != null ? Invoice.AssignAmount : AssignAmount2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AssignBatchNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate
        {
            get { return Invoice != null ? Invoice.AssignDate : AssignDate2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding
        {
            get { return Invoice != null ? Invoice.AssignOutstanding : AssignOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreditNoteDate
        {
            get { return CreditNote != null ? (DateTime?) CreditNote.CreditNoteDate : null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreditNoteDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CreditNoteNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DueDate
        {
            get { return Invoice != null ? Invoice.DueDate : DueDate2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DueDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int InvoiceID2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo
        {
            get { return Invoice != null ? Invoice.InvoiceNo : InvoiceNo2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoicePaymentAmount
        {
            get { return Invoice != null ? Invoice.PaymentAmount : InvoicePaymentAmount2; }
        }

        public double? InvoicePaymentAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String PaymentCurrency
        {
            get { return Invoice.InvoiceCurrency; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime PaymentDate
        {
            get { return InvoicePaymentBatch.PaymentDate; }
        }
    }
}