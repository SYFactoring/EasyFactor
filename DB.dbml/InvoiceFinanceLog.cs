//-----------------------------------------------------------------------
// <copyright file="InvoiceFinanceLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Linq;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinanceLog
    {
        #region Properties (13)

        /// <summary>
        /// 
        /// </summary>
        public DateTime FinanceDate
        {
            get
            {
                return this.InvoiceFinanceBatch.FinancePeriodBegin;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime FinanceDueDate
        {
            get
            {
                return this.InvoiceFinanceBatch.FinancePeriodEnd;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get
            {
                return this.Invoice.AssignAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate
        {
            get
            {
                return this.Invoice.AssignDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                return this.Invoice.AssignOutstanding;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? Commission
        {
            get
            {
                return this.Invoice.Commission;
            }
            set
            {
                this.Invoice.Commission = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CommissionDate
        {
            get
            {
                return this.Invoice.CommissionDate;
            }
            set
            {
                this.Invoice.CommissionDate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DueDate
        {
            get
            {
                return this.Invoice.DueDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FinanceOutstanding
        {
            get
            {
                return this.FinanceAmount - RefundAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double GrossInterest
        {
            get
            {
                double interest = 0;

                foreach (InvoiceRefundLog refundLog in InvoiceRefundLogs)
                {
                    int period = ((refundLog.InvoiceRefundBatch.RefundDate < InvoiceFinanceBatch.FinancePeriodEnd ? refundLog.InvoiceRefundBatch.RefundDate : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                    interest += refundLog.RefundAmount * (InvoiceFinanceBatch.FinanceRate) / 360 * period;
                }

                if (TypeUtil.GreaterZero(FinanceOutstanding))
                {
                    int period = ((DateTime.Today.Date < InvoiceFinanceBatch.FinancePeriodEnd ? DateTime.Today.Date : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                    interest += FinanceAmount * (InvoiceFinanceBatch.FinanceRate) / 360 * period;
                }

                if (InvoiceFinanceBatch.BatchCurrency != "CNY")
                {
                    double rate = Exchange.GetExchangeRate(InvoiceFinanceBatch.BatchCurrency, "CNY");
                    interest *= rate;
                }

                return interest;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceDate
        {
            get
            {
                return this.Invoice.InvoiceDate;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceFinanceAmount
        {
            get
            {
                return this.Invoice.FinanceAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceFinanceOutstanding
        {
            get
            {
                return this.Invoice.FinanceOutstanding;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double NetInterest
        {
            get
            {
                double interest = 0;

                foreach (InvoiceRefundLog refundLog in InvoiceRefundLogs)
                {
                    int period = ((refundLog.InvoiceRefundBatch.RefundDate < InvoiceFinanceBatch.FinancePeriodEnd ? refundLog.InvoiceRefundBatch.RefundDate : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                    interest += refundLog.RefundAmount * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * period;
                }

                if (TypeUtil.GreaterZero(FinanceOutstanding))
                {
                    int period = ((DateTime.Today.Date < InvoiceFinanceBatch.FinancePeriodEnd ? DateTime.Today.Date : InvoiceFinanceBatch.FinancePeriodEnd) - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                    interest += FinanceAmount * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * period;
                }

                if (InvoiceFinanceBatch.BatchCurrency != "CNY")
                {
                    double rate = Exchange.GetExchangeRate(InvoiceFinanceBatch.BatchCurrency, "CNY");
                    interest *= rate;
                }

                return interest;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? RefundAmount
        {
            get
            {
                if (this.InvoiceRefundLogs != null)
                {
                    return this.InvoiceRefundLogs.Sum(log => log.RefundAmount);
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion Properties
    }
}
