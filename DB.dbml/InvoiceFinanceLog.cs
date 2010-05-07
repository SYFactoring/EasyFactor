﻿//-----------------------------------------------------------------------
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
        #region Constructors (1)

        public InvoiceFinanceLog(Invoice invoice)
            : this()
        {
            this.InvoiceNo2 = invoice.InvoiceNo;
            this.AssignAmount2 = invoice.AssignAmount;
            this.AssignOutstanding2 = invoice.AssignOutstanding;
            this.InvoiceDate2 = invoice.InvoiceDate;
            this.DueDate2 = invoice.DueDate;
            this.AssignDate2 = invoice.AssignDate;
            this.InvoiceFinanceAmount2 = invoice.FinanceAmount;
            this.InvoiceFinanceOutstanding2 = invoice.FinanceOutstanding;
        }

        #endregion Constructors

        #region Properties (22)

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

        public double AssignAmount2
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

        public DateTime AssignDate2
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

        public double AssignOutstanding2
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

        public DateTime? DueDate2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string FinanceCurrency
        {
            get
            {
                return this.InvoiceFinanceBatch.BatchCurrency;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDate
        {
            get
            {
                if (this.InvoiceFinanceBatch != null)
                {
                    return this.InvoiceFinanceBatch.FinancePeriodBegin;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FinanceDueDate
        {
            get
            {
                if (this.InvoiceFinanceBatch != null)
                {
                    return this.InvoiceFinanceBatch.FinancePeriodEnd;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double FinanceOutstanding
        {
            get
            {
                return this.FinanceAmount.GetValueOrDefault() - RefundAmount.GetValueOrDefault();
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
                    if (InvoiceFinanceBatch.FinanceType == "卖方代付" || InvoiceFinanceBatch.FinanceType == "买方代付")
                    {
                        int period = (InvoiceFinanceBatch.FinancePeriodEnd - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                        interest = this.FinanceAmount.GetValueOrDefault() * InvoiceFinanceBatch.FinanceRate / 360 * period;
                    }
                    else
                    {
                        foreach (InvoiceRefundLog refundLog in InvoiceRefundLogs)
                        {
                            int period = (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            int overduePeriod = refundLog.InvoiceRefundBatch.RefundDate > InvoiceFinanceBatch.FinancePeriodEnd ? (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodEnd).Days : 0;
                            interest += refundLog.RefundAmount.GetValueOrDefault() * InvoiceFinanceBatch.FinanceRate / 360 * (period + overduePeriod);
                        }

                        if (TypeUtil.GreaterZero(FinanceOutstanding) && DateTime.Today > InvoiceFinanceBatch.FinancePeriodBegin)
                        {
                            int period = (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            int overduePeriod = DateTime.Today.Date > InvoiceFinanceBatch.FinancePeriodEnd ? (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodEnd).Days : 0;
                            interest += FinanceAmount.GetValueOrDefault() * InvoiceFinanceBatch.FinanceRate / 360 * (period + overduePeriod);
                        }
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

        public DateTime? InvoiceDate2
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

        public double? InvoiceFinanceAmount2
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

        public double? InvoiceFinanceOutstanding2
        {
            get;
            set;
        }

        public string InvoiceNo2
        {
            get;
            set;
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
                    if (InvoiceFinanceBatch.FinanceType == "卖方代付" || InvoiceFinanceBatch.FinanceType == "买方代付")
                    {
                        int period = (InvoiceFinanceBatch.FinancePeriodEnd - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                        interest = this.FinanceAmount.GetValueOrDefault() * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * period;
                    }
                    else
                    {
                        foreach (InvoiceRefundLog refundLog in InvoiceRefundLogs)
                        {
                            int period = (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            int overduePeriod = refundLog.InvoiceRefundBatch.RefundDate > InvoiceFinanceBatch.FinancePeriodEnd ? (refundLog.InvoiceRefundBatch.RefundDate - InvoiceFinanceBatch.FinancePeriodEnd).Days : 0;
                            interest += refundLog.RefundAmount.GetValueOrDefault() * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * (period + overduePeriod);
                        }

                        if (TypeUtil.GreaterZero(FinanceOutstanding) && DateTime.Today > InvoiceFinanceBatch.FinancePeriodBegin)
                        {
                            int period = (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodBegin).Days;
                            int overduePeriod = DateTime.Today.Date > InvoiceFinanceBatch.FinancePeriodEnd ? (DateTime.Today.Date - InvoiceFinanceBatch.FinancePeriodEnd).Days : 0;
                            interest += FinanceAmount.GetValueOrDefault() * (InvoiceFinanceBatch.FinanceRate - InvoiceFinanceBatch.CostRate.GetValueOrDefault()) / 360 * (period + overduePeriod);
                        }
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
        /// Gets
        /// </summary>
        public System.Nullable<int> FinanceOverDueDays
        {
            get
            {
                if (TypeUtil.GreaterZero(this.FinanceOutstanding))
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

        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        public void CaculateCommission()
        {
            CDA cda = this.Invoice.InvoiceAssignBatch.Case.ActiveCDA;
            if (cda.CommissionType == "按融资金额")
            {
                //if (cda.Case.TransactionType == "进口保理")
                //{
                //    Commission = FinanceAmount * cda.IFPrice;
                //}
                //else
                //{
                    Commission = FinanceAmount * cda.Price;
                //}
            }
        }

        #endregion Methods
    }
}
