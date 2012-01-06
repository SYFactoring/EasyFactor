//-----------------------------------------------------------------------
// <copyright file="InvoicePaymentLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using CMBC.EasyFactor.Utils;

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
        public decimal AssignAmount
        {
            get { return Invoice != null ? Invoice.AssignAmount : AssignAmount2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal AssignAmount2 { get; set; }

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
        public decimal AssignOutstanding
        {
            get { return Invoice != null ? Invoice.AssignOutstanding : AssignOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal AssignOutstanding2 { get; set; }

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
        public decimal? InvoicePaymentAmount
        {
            get { return Invoice != null ? Invoice.PaymentAmount : InvoicePaymentAmount2; }
        }

        public decimal? InvoicePaymentAmount2 { get; set; }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (TypeUtil.LessZero(PaymentAmount))
                {
                    throw new Exception(String.Format("付款金额{0:N2}不能为负: {1}", PaymentAmount,
                                 PaymentLogID));
                }
            }
        }
    }
}