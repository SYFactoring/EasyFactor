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
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(string caseCode, DateTime assignDate)
        {
            DBDataContext context = new DBDataContext();
            var queryResult = from batch in context.InvoiceAssignBatches where batch.AssignBatchNo.StartsWith(caseCode) && batch.AssignDate.Year == assignDate.Year select batch.NewAssignBatchNo;
            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(15)), out batchCount))
            {
                batchCount = 0;
            }

            string newCaseCode = context.Cases.SingleOrDefault(c => c.CaseCode == caseCode).NewCaseCode;

            string assignNo = String.Format("{0}ASS{1:yy}{2:D3}", newCaseCode, assignDate, batchCount + 1);
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
            DBDataContext context = new DBDataContext();
            var queryResult = from batch in context.InvoiceAssignBatches where batch.AssignBatchNo.StartsWith(caseCode) && batch.AssignDate.Year == assignDate.Year select batch.NewAssignBatchNo;
            int batchCount;
            if (!Int32.TryParse(queryResult.Max(no => no.Substring(15)), out batchCount))
            {
                batchCount = 0;
            }

            batchCount += batchesInMemory.Count(batch => batch.AssignBatchNo.StartsWith(String.Format("{0}ASS{1:yy}", caseCode, assignDate)));
            string assignNo = String.Format("{0}ASS{1:yy}{2:D3}", caseCode, assignDate, batchCount + 1);
            return assignNo;
        }
    }
}
