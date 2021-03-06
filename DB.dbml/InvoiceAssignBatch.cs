//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignBatch.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssignBatch
    {

        private decimal? _assignAmount;
        private decimal? _assignOutstanding;
        private decimal? _commissionAmount;
        private decimal? _factorCommissionAmount;
        private decimal? _financeAmount;
        private decimal? _financeOutstanding;
        private decimal? _paymentAmount;
        private decimal? _refundAmount;



        /// <summary>
        /// Gets assign amount
        /// </summary>
        public decimal AssignAmount
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
        /// Gets
        /// </summary>
        public decimal AssignOutstanding
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
        /// Gets
        /// </summary>
        public decimal? CommissionAmount
        {
            get
            {
                if (_commissionAmount.HasValue == false)
                {
                    decimal? result = null;
                    foreach (Invoice invoice in Invoices.Where(invoice => invoice.PaidCommission.HasValue))
                    {
                        if (result.HasValue == false)
                        {
                            result = 0;
                        }
                        result += invoice.PaidCommission;
                    }

                    _commissionAmount = result;
                }

                return _commissionAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? CommissionPrice
        {
            get
            {
                CDA cda = Case.ActiveCDA;
                return cda != null ? cda.Price : null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? CreditNoteAmount
        {
            get { return CreditNotes.Sum(c => c.PaymentAmount); }
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
        public decimal? FactorCommissionAmount
        {
            get
            {
                if (_factorCommissionAmount.HasValue == false)
                {
                    decimal? result = null;
                    foreach (Invoice invoice in Invoices.Where(invoice => invoice.FactorCommission.HasValue))
                    {
                        if (result.HasValue == false)
                        {
                            result = 0;
                        }
                        result += invoice.FactorCommission;
                    }

                    _factorCommissionAmount = result;
                }

                return _factorCommissionAmount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? FactorCommissionPrice
        {
            get
            {
                CDA cda = Case.ActiveCDA;
                if (cda != null)
                {
                    if (TransactionType == "出口保理")
                    {
                        return cda.IFPrice;
                    }
                    if (TransactionType == "进口保理")
                    {
                        return cda.EFPrice;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double? IFCommissionPrice
        {
            get
            {
                CDA cda = Case.ActiveCDA;
                if (cda != null)
                {
                    return cda.IFPrice;
                }

                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FactorName
        {
            get { return Case.Factor.ToString(); }
        }

        /// <summary>
        /// Gets finance amount
        /// </summary>
        public decimal FinanceAmount
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
        /// Gets
        /// </summary>
        public decimal FinanceOutstanding
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
        /// 
        /// </summary>
        public decimal? HandFee
        {
            get
            {
                CDA cda = Case.ActiveCDA;
                if (cda != null)
                {
                    decimal? handfee = cda.HandFee;
                    if (cda.HandFeeCurr != Case.InvoiceCurrency)
                    {
                        decimal rate = Exchange.GetExchangeRate(cda.HandFeeCurr, Case.InvoiceCurrency);
                        handfee *= rate;
                    }
                    return handfee;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public decimal? HandfeeAmount
        {
            get { return Invoices.Count * HandFee; }
        }

        /// <summary>
        /// 是否池融资
        /// </summary>
        public bool IsPool
        {
            get { return Case.IsPool; }
        }

        /// <summary>
        /// 是否已发生融资
        /// </summary>
        public bool IsRefinanced
        {
            get { return Invoices.Any(i => i.FinanceAmount > 0); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Location
        {
            get { return Case.OwnerDepartment.LocationName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal? MsgAmount
        {
            get
            {
                CommissionRemittance cr = CommissionRemittance;
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
        public DateTime? MsgDate
        {
            get { return CommissionRemittance != null ? (DateTime?)CommissionRemittance.MsgDate : null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MsgType
        {
            get { return CommissionRemittance != null ? CommissionRemittance.MsgType : string.Empty; }
        }

        /// <summary>
        /// Gets payment amount
        /// </summary>
        public decimal PaymentAmount
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
        public decimal RefundAmount
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
        /// 
        /// </summary>
        public decimal? RemitAmount
        {
            get { return CommissionRemittance != null ? CommissionRemittance.RemitAmount : null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? RemitDate
        {
            get { return CommissionRemittance != null ? CommissionRemittance.RemitDate : null; }
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
        public bool IsClear
        {
            get { return !Invoices.Any(i => i.IsClear == false); }
        }

        //?Public?Methods?(2)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseCode"></param>
        /// <param name="assignDate"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(string caseCode, DateTime assignDate)
        {
            int batchCount = 0;
            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoiceAssignBatches
                                              where
                                                  batch.CaseCode == caseCode &&
                                                  batch.AssignDate.Year == assignDate.Year
                                              select batch.AssignBatchNo.Substring(17);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
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
            int batchCount = 0;
            using (var context = new DBDataContext())
            {
                IQueryable<string> queryStr = from batch in context.InvoiceAssignBatches
                                              where
                                                  batch.CaseCode == caseCode &&
                                                  batch.AssignDate.Year == assignDate.Year
                                              select batch.AssignBatchNo.Substring(17);

                foreach (string value in queryStr)
                {
                    if (batchCount < Convert.ToInt32(value))
                    {
                        batchCount = Convert.ToInt32(value);
                    }
                }
            }

            batchCount +=
                batchesInMemory.Count(
                    batch => batch.AssignBatchNo.StartsWith(String.Format("{0}ASS{1:yy}", caseCode, assignDate)));
            string assignNo = String.Format("{0}ASS{1:yy}{2:D3}", caseCode, assignDate, batchCount + 1);
            return assignNo;
        }
    }
}