//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssignBatch
    {
        #region?Fields?(4)?

        private double? _assignAmount;
        private double? _assignOutstanding;
        private double? _commissionAmount;
        private double? _financeAmount;
        private double? _financeOutstanding;
        private double? _paymentAmount;
        private double? _refundAmount;

        #endregion?Fields?

        #region?Properties?(10)?

        /// <summary>
        /// 
        /// </summary>
        public CommissionRemittance CommissionRemitteance
        {
            get
            {
                return
                    Case.SellerClient.CommissionRemittances.OrderBy(r => r.MsgDate).FirstOrDefault(
                        cr => AssignDate <= cr.MsgDate);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? MsgDate
        {
            get
            {
                CommissionRemittance cr = CommissionRemitteance;
                if (cr != null)
                {
                    return cr.MsgDate;
                }

                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MsgType
        {
            get
            {
                CommissionRemittance cr = CommissionRemitteance;
                if (cr != null)
                {
                    return cr.MsgType;
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? RemitDate
        {
            get
            {
                CommissionRemittance cr = CommissionRemitteance;
                if (cr != null)
                {
                    return cr.RemitDate;
                }

                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? RemitAmount
        {
            get
            {
                CommissionRemittance cr = CommissionRemitteance;
                if (cr != null)
                {
                    return cr.RemitAmount;
                }

                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? MsgAmount
        {
            get
            {
                CommissionRemittance cr = CommissionRemitteance;
                if (cr != null)
                {
                    return cr.MsgAmount;
                }

                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FactorCode
        {
            get { return Case.Factor.FactorCode; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FactorName
        {
            get { return Case.Factor.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? CreditNoteAmount
        {
            get { return CreditNotes.Sum(c => c.PaymentAmount); }
        }

        /// <summary>
        /// Gets assign amount
        /// </summary>
        public double AssignAmount
        {
            get
            {
                if (_assignAmount.HasValue == false)
                {
                    _assignAmount = Invoices.Sum(i => i.AssignAmount);
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
                    _financeAmount = Invoices.Sum(i => i.FinanceAmount);
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
                    _paymentAmount = Invoices.Sum(i => i.PaymentAmount);
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
                    _refundAmount = Invoices.Sum(i => i.RefundAmount);
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
                    _assignOutstanding = Invoices.Sum(i => i.AssignOutstanding);
                }

                return _assignOutstanding.Value;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public int BatchCount
        {
            get { return Invoices.Count; }
        }

        /// <summary>
        /// Gets 
        /// </summary>
        public string BatchCurrency
        {
            get { return Case.InvoiceCurrency; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string BuyerName
        {
            get { return Case.BuyerClient.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FactorCommissionAmount
        {
            get
            {
                CDA activeCDA = Case.ActiveCDA;
                if (activeCDA == null)
                {
                    return null;
                }

                if (activeCDA.CommissionType == "按转让金额")
                {
                    if (TransactionType == "出口保理" || TransactionType == "国内卖方保理")
                    {
                        return AssignAmount*activeCDA.IFPrice;
                    }
                    if (TransactionType == "进口保理" || TransactionType == "国内买方保理")
                    {
                        return AssignAmount*activeCDA.EFPrice;
                    }
                    return null;
                }
                return null;
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
                    foreach (Invoice invoice in Invoices)
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
                    _financeOutstanding = Invoices.Sum(i => i.FinanceOutstanding.GetValueOrDefault());
                }

                return _financeOutstanding.Value;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public double? HandfeeAmount
        {
            get { return Invoices.Count*Case.ActiveCDA.HandFee; }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public string SellerName
        {
            get { return Case.SellerClient.ToString(); }
        }

        /// <summary>
        /// Gets Transaction Type
        /// </summary>
        public string TransactionType
        {
            get { return Case.TransactionType; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Location
        {
            get { return Case.OwnerDepartment.LocationName; }
        }

        #endregion?Properties?

        #region?Methods?(2)?

        //?Public?Methods?(2)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseCode"></param>
        /// <param name="assignDate"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(string caseCode, DateTime assignDate)
        {
            int batchCount;
            using (var context = new DBDataContext())
            {
                IQueryable<string> queryResult = from batch in context.InvoiceAssignBatches
                                                 where
                                                     batch.CaseCode == caseCode &&
                                                     batch.AssignDate.Year == assignDate.Year
                                                 select batch.AssignBatchNo;

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
        /// <param name="assignDate"></param>
        /// <param name="batchesInMemory"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(string caseCode, DateTime assignDate,
                                                   List<InvoiceAssignBatch> batchesInMemory)
        {
            int batchCount;
            using (var context = new DBDataContext())
            {
                IQueryable<string> queryResult = from batch in context.InvoiceAssignBatches
                                                 where
                                                     batch.CaseCode == caseCode &&
                                                     batch.AssignDate.Year == assignDate.Year
                                                 select batch.AssignBatchNo;

                if (!Int32.TryParse(queryResult.Max(no => no.Substring(17)), out batchCount))
                {
                    batchCount = 0;
                }
            }

            batchCount +=
                batchesInMemory.Count(
                    batch => batch.AssignBatchNo.StartsWith(String.Format("{0}ASS{1:yy}", caseCode, assignDate)));
            string assignNo = String.Format("{0}ASS{1:yy}{2:D3}", caseCode, assignDate, batchCount + 1);
            return assignNo;
        }

        #endregion?Methods?
    }
}