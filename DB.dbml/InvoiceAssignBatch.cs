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

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssignBatch
    {
        #region Properties (7)

        private double? _assignAmount;

        /// <summary>
        /// Gets
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

        private double? _commissionAmount;

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

        #endregion Properties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(DateTime date)
        {
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceAssignBatches
            //                  where batch.AssignDate.Date == date.Date
            //                  select batch.AssignBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceAssignBatches
                              where batch.AssignBatchNo.Contains(dateStr)
                              select batch.AssignBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

            string assignNo = String.Format("ASS{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="batchesInMemory"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(DateTime date, List<InvoiceAssignBatch> batchesInMemory)
        {
            DBDataContext context = new DBDataContext();
            //var queryResult = from batch in context.InvoiceAssignBatches
            //                  where batch.AssignDate.Date == date.Date
            //                  select batch.AssignBatchNo;
            string dateStr = String.Format("{0:yyyMMdd}", date);
            var queryResult = from batch in context.InvoiceAssignBatches
                              where batch.AssignBatchNo.Contains(dateStr)
                              select batch.AssignBatchNo;

            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(12)), out batchCount))
            {
                batchCount = 0;
            }

            batchCount += batchesInMemory.Count(batch => batch.AssignBatchNo.Contains(dateStr));
            string assignNo = String.Format("ASS{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return assignNo;
        }
    }
}
