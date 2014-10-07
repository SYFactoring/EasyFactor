//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinanceLog
    {
        public InvoiceFinanceLog(Invoice invoice)
            : this()
        {
            AssignBatchNo2 = invoice.AssignBatchNo;
            InvoiceID2 = invoice.InvoiceID;
            InvoiceNo2 = invoice.InvoiceNo;
            InvoiceAmount2 = invoice.InvoiceAmount;
            AssignAmount2 = invoice.AssignAmount;
            AssignOutstanding2 = invoice.AssignOutstanding;
            InvoiceDate2 = invoice.InvoiceDate;
            DueDate2 = invoice.DueDate;
            AssignDate2 = invoice.AssignDate;
            InvoiceFinanceAmount2 = invoice.FinanceAmount;
            InvoiceFinanceOutstanding2 = invoice.FinanceOutstanding;
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
        public string FinanceCurrency
        {
            get { return InvoiceFinanceBatch.BatchCurrency; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate
        {
            get { return InvoiceFinanceBatch != null ? (DateTime?)InvoiceFinanceBatch.FinancePeriodBegin : null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime FinanceDueDate
        {
            get { return DueDate.GetValueOrDefault(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal FinanceOutstanding
        {
            get { return FinanceAmount.GetValueOrDefault() - RefundAmount.GetValueOrDefault(); }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int? FinanceOverDueDays
        {
            get
            {
                if (FinanceOutstanding>0)
                {
                    if (FinanceDueDate != null)
                    {
                        TimeSpan? duedays = DateTime.Now.Date - FinanceDueDate;
                        return duedays.Value.Days;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceDate
        {
            get { return Invoice != null ? Invoice.InvoiceDate : InvoiceDate2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceDate2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceFinanceAmount
        {
            get { return Invoice != null ? Invoice.FinanceAmount : InvoiceFinanceAmount2; }
        }

        public decimal? InvoiceFinanceAmount2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceFinanceOutstanding
        {
            get { return Invoice != null ? Invoice.FinanceOutstanding : InvoiceFinanceOutstanding2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? InvoiceFinanceOutstanding2 { get; set; }

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
        public decimal? RefundAmount
        {
            get { return InvoiceRefundLogs != null ? InvoiceRefundLogs.Sum(log => log.RefundAmount) : null; }
        }

        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommission()
        {
            InvoiceAssignBatch assingBatch = Invoice.InvoiceAssignBatch;
            CDA cda = assingBatch.Case.ActiveCDA;

            if (assingBatch == null)
            {
                return;
            }

            if (assingBatch.CommissionType == "�����ʽ��")
            {
                if(assingBatch.CommissionPrePost=="����")
                {
                    PaidCommission = Decimal.Round(FinanceAmount.GetValueOrDefault() * (decimal)cda.Price.GetValueOrDefault(), 2);
                }else if(assingBatch.CommissionPrePost=="����")
                {
                    UnpaidCommission = Decimal.Round(FinanceAmount.GetValueOrDefault() * (decimal)cda.Price.GetValueOrDefault(), 2);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert || action == ChangeAction.Update)
            {
                if (FinanceAmount<0)
                {
                    throw new Exception(String.Format("���ʽ��{0:N2}����Ϊ��: {1}", FinanceAmount,
                                 FinanceLogID));
                }
            }
        }

        public decimal InvoiceAmount2 { get; set; }

        public decimal InvoiceAmount
        {
            get
            {
                if (Invoice != null)
                {
                    return Invoice.InvoiceAmount;
                }
                else
                {
                    return InvoiceAmount2;
                }
            }
        }

        public DateTime ReassignDate
        {
            get
            {
                return Invoice.ReassignDate;
            }
        }

    }
}