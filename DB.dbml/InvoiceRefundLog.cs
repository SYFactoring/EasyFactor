//-----------------------------------------------------------------------
// <copyright file="InvoiceRefundLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Data.Linq;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceRefundLog
    {


        #region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="financeLog"></param>
        public InvoiceRefundLog(InvoiceFinanceLog financeLog)
            : this()
        {
            this.AssignBatchNo2 = financeLog.Invoice.AssignBatchNo;
            this.InvoiceNo2 = financeLog.Invoice.InvoiceNo;
            this.FinanceLogID2 = financeLog.FinanceLogID;
            this.FinanceAmount2 = financeLog.FinanceAmount;
            this.FinanceOutstanding2 = financeLog.FinanceOutstanding;
            this.FinanceDate2 = financeLog.FinanceDate;
            this.FinanceDueDate2 = financeLog.FinanceDueDate;
            this.InvoiceRefundAmount2 = financeLog.RefundAmount;
            this.InvoicePaymentAmount2 = financeLog.Invoice.PaymentAmount;
            this.RefundCurrency2 = financeLog.InvoiceFinanceBatch.BatchCurrency;
        }

        #endregion?Constructors?


        #region?Properties?(18)?

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceAmount
        {
            get
            {
                if (this.InvoiceFinanceLog != null)
                {
                    return this.InvoiceFinanceLog.FinanceAmount;
                }
                else
                {
                    return FinanceAmount2;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceAmount2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate
        {
            get
            {
                if (this.InvoiceFinanceLog != null)
                {
                    return this.InvoiceFinanceLog.FinanceDate;
                }
                else
                {
                    return FinanceDate2;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDueDate
        {
            get
            {
                if (this.InvoiceFinanceLog != null)
                {
                    return this.InvoiceFinanceLog.FinanceDueDate;
                }
                else
                {
                    return this.FinanceDueDate2;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDueDate2
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public int FinanceLogID2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceOutstanding
        {
            get
            {
                if (this.InvoiceFinanceLog != null)
                {
                    return this.InvoiceFinanceLog.FinanceOutstanding;
                }
                else
                {
                    return FinanceOutstanding2;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? FinanceOutstanding2
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo
        {
            get
            {
                return this.InvoiceFinanceLog.Invoice.InvoiceNo;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AssignBatchNo2
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo2
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public double? InvoicePaymentAmount
        {
            get
            {
                if (this.InvoiceFinanceLog != null)
                {
                    return this.InvoiceFinanceLog.Invoice.PaymentAmount;
                }
                else
                {
                    return this.InvoicePaymentAmount2;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? InvoicePaymentAmount2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceRefundAmount
        {
            get
            {
                if (this.InvoiceFinanceLog != null)
                {
                    return this.InvoiceFinanceLog.RefundAmount;
                }
                else
                {
                    return InvoiceRefundAmount2;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceRefundAmount2
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string RefundCurrency
        {
            get
            {
                if (this.InvoiceFinanceLog != null)
                {
                    return this.InvoiceFinanceLog.InvoiceFinanceBatch.BatchCurrency;
                }
                else
                {
                    return RefundCurrency2;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RefundCurrency2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RefundDate
        {
            get
            {
                return this.InvoiceRefundBatch.RefundDate;
            }
        }

        #endregion?Properties?
    }
}
