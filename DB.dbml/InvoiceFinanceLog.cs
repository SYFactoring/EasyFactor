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
    using System.Data.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinanceLog
    {
        #region Properties (13)

        public InvoiceFinanceLog(Invoice invoice)
        {
            this.InvoiceNo2 = invoice.InvoiceNo;
            this.AssignAmount2 = invoice.AssignAmount;
            this.AssignOutstanding2 = invoice.AssignOutstanding;
            this.InvoiceDate2 = invoice.InvoiceDate;
            this.DueDate2 = invoice.DueDate;
            this.AssignDate2 = invoice.AssignDate;
            this.InvoiceFinanceAmount2 = invoice.FinanceAmount;
            this.InvoiceFinanceOutstanding2 = invoice.FinanceOutstanding;
            this.Commission2 = invoice.Commission;
            this.CommissionDate2 = invoice.CommissionDate;
        }

        public string InvoiceNo2
        {
            get;
            set;
        }

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

        public double AssignAmount2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignAmount
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.AssignAmount;
                }
                else
                {
                    return this.AssignAmount2;
                }
            }
        }

        public DateTime AssignDate2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AssignDate
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.AssignDate;
                }
                else
                {
                    return this.AssignDate2;
                }
            }
        }

        public double AssignOutstanding2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.AssignOutstanding;
                }
                else
                {
                    return this.AssignOutstanding2;
                }
            }
        }

        public double? Commission2
        {
            get;
            set;
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

        public DateTime? CommissionDate2
        {
            get;
            set;
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

        public DateTime? DueDate2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DueDate
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.DueDate;
                }
                else
                {
                    return this.DueDate2;
                }
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

                if (InvoiceFinanceBatch != null)
                {
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
                }

                return interest;
            }
        }

        public DateTime? InvoiceDate2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceDate
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.InvoiceDate;
                }
                else
                {
                    return this.InvoiceDate2;
                }
            }
        }

        public double? InvoiceFinanceAmount2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceFinanceAmount
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.FinanceAmount;
                }
                else
                {
                    return this.InvoiceFinanceAmount2;
                }
            }
        }

        public double? InvoiceFinanceOutstanding2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double? InvoiceFinanceOutstanding
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.FinanceOutstanding;
                }
                else
                {
                    return this.InvoiceFinanceOutstanding2;
                }
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
                if (InvoiceFinanceBatch != null)
                {
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
                }

                return interest;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {

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
