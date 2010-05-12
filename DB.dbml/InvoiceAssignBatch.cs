//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssignBatch
    {
		#region?Fields?(4)?

        private double? _assignAmount;
        private double? _financeAmount;
        private double? _paymentAmount;
        private double? _refundAmount;
        private double? _assignOutstanding;
        private double? _commissionAmount;
        private double? _financeOutstanding;

		#endregion?Fields?

		#region?Properties?(10)?

        /// <summary>
        /// Gets assign amount
        /// </summary>
        public double AssignAmount
        {
            get
            {
                if (_assignAmount.HasValue == false)
                {
                    _assignAmount = this.Invoices.Sum(i => i.AssignAmount);
                }

                return _assignAmount.Value;
            }
        }

        /// <summary>
        /// Gets finance amount
        /// </summary>
        public double FinanceAmount
        {
            get
            {
                if (_financeAmount.HasValue == false)
                {
                    _financeAmount = this.Invoices.Sum(i => i.FinanceAmount);
                }

                return _financeAmount.Value;
            }
        }

        /// <summary>
        /// Gets payment amount
        /// </summary>
        public double PaymentAmount
        {
            get
            {
                if (_paymentAmount.HasValue == false)
                {
                    _paymentAmount = this.Invoices.Sum(i => i.PaymentAmount);
                }

                return _paymentAmount.Value;
            }
        }

        /// <summary>
        /// Gets refund amount
        /// </summary>
        public double RefundAmount
        {
            get
            {
                if (_refundAmount.HasValue == false)
                {
                    _refundAmount = this.Invoices.Sum(i => i.RefundAmount);
                }

                return _refundAmount.Value;
            }
        }
        /// <summary>
        /// Gets
        /// </summary>
        public double AssignOutstanding
        {
            get
            {
                if (_assignOutstanding.HasValue == false)
                {
                    _assignOutstanding = this.Invoices.Sum(i => i.AssignOutstanding);
                }

                return _assignOutstanding.Value;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get
            {
                return this.Invoices.Count;
            }
        }

        /// <summary>
        /// Gets 
        /// </summary>
        public string BatchCurrency
        {
            get
            {
                return this.Case.InvoiceCurrency;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get
            {
                return this.Case.BuyerClient.ToString();
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double? CommissionAmount
        {
            get
            {
                if (_commissionAmount.HasValue == false)
                {
                    double? result = null;
                    foreach (Invoice invoice in this.Invoices)
                    {
                        if (invoice.Commission.HasValue)
                        {
                            if (result.HasValue == false)
                            {
                                result = 0;
                            }
                            result += invoice.Commission;
                        }
                    }

                    _commissionAmount = result;
                }

                return _commissionAmount;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double FinanceOutstanding
        {
            get
            {
                if (_financeOutstanding.HasValue == false)
                {
                    _financeOutstanding = this.Invoices.Sum(i => i.FinanceOutstanding.GetValueOrDefault());
                }

                return _financeOutstanding.Value;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double? HandfeeAmount
        {
            get
            {
                return this.Invoices.Count * this.Case.ActiveCDA.HandFee;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get
            {
                return this.Case.SellerClient.ToString();
            }
        }

        /// <summary>
        /// Gets Transaction Type
        /// </summary>
        public string TransactionType
        {
            get
            {
                return this.Case.TransactionType;
            }
        }

		#endregion?Properties?

		#region?Methods?(2)?

		//?Public?Methods?(2)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(string caseCode, DateTime assignDate)
        {
            int batchCount;
            using (DBDataContext context = new DBDataContext())
            {
                var queryResult = from batch in context.InvoiceAssignBatches where batch.CaseCode == caseCode && batch.AssignDate.Year == assignDate.Year select batch.AssignBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(17)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            string assignNo = String.Format("{0}ASS{1:yy}{2:D3}", caseCode, assignDate, batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseCode"></param>
        /// <param name="batchesInMemory"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(string caseCode, DateTime assignDate, List<InvoiceAssignBatch> batchesInMemory)
        {
            int batchCount;
            using (DBDataContext context = new DBDataContext())
            {
                var queryResult = from batch in context.InvoiceAssignBatches where batch.CaseCode == caseCode && batch.AssignDate.Year == assignDate.Year select batch.AssignBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(17)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            batchCount += batchesInMemory.Count(batch => batch.AssignBatchNo.StartsWith(String.Format("{0}ASS{1:yy}", caseCode, assignDate)));
            string assignNo = String.Format("{0}ASS{1:yy}{2:D3}", caseCode, assignDate, batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
            }
        }

		#endregion?Methods?
    }
}
