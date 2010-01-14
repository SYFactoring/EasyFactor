using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class Invoice : BaseObject
    {
        #region Properties (11)

        public DateTime AssignDate
        {
            get
            {
                return this.InvoiceAssignBatch.AssignDate;
            }
        }

        public double AssignOutstanding
        {
            get
            {
                return this.AssignAmount - this.PaymentAmount.GetValueOrDefault()-this.PaymentAmount2.GetValueOrDefault();
            }
        }

        public System.Nullable<int> AssignOverDueDays
        {
            get
            {
                if (TypeUtil.GreaterZero(AssignOutstanding))
                {
                    return (DateTime.Now.Date - this.DueDate).Days;
                }
                return null;
            }
        }

        public string BuyerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.BuyerClient.ToString();
            }
        }

        public string FactorName
        {
            get
            {
                string transactionType = this.InvoiceAssignBatch.CDA.Case.TransactionType;
                switch (transactionType)
                {
                    case "国内卖方保理":
                    case "国内买方保理":
                    case "租赁保理":
                        return string.Empty;
                    case "国内信保保理":
                    case "国际信保保理":
                    case "出口保理":
                        return this.InvoiceAssignBatch.CDA.Case.BuyerFactor.ToString();
                    case "进口保理":
                        return this.InvoiceAssignBatch.CDA.Case.SellerFactor.ToString();
                    default:
                        return string.Empty;
                }
            }
        }

        public string FinanceCurrency
        {
            get
            {
                if (this.InvoiceFinanceBatch != null)
                {
                    return this.InvoiceFinanceBatch.BatchCurrency;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public System.Nullable<double> FinanceOutstanding
        {
            get
            {
                if (!this.FinanceAmount.HasValue)
                    return null;
                return this.FinanceAmount.Value - this.RefundAmount.GetValueOrDefault()-this.RefundAmount2.GetValueOrDefault();
            }
        }

        public System.Nullable<int> FinanceOverDueDays
        {
            get
            {
                if (TypeUtil.GreaterZero(FinanceOutstanding))
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

        public string InvoiceCurrency
        {
            get
            {
                return this.InvoiceAssignBatch.BatchCurrency;
            }
        }

        public string SellerName
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.SellerClient.ToString();
            }
        }

        public string TransactionType
        {
            get
            {
                return this.InvoiceAssignBatch.CDA.Case.TransactionType;
            }
        }

        private double? _PaymentAmount2;

        public double? PaymentAmount2
        {
            get
            {
                return _PaymentAmount2;
            }
            set
            {
                this.SendPropertyChanging();
                this._PaymentAmount2 = value;
                this.SendPropertyChanged("PaymentAmount2");
            }
        }
        private DateTime? _PaymentDate2;

        public DateTime? PaymentDate2
        {
            get
            {
                return _PaymentDate2;
            }
            set
            {
                this.SendPropertyChanging();
                this._PaymentDate2 = value;
                this.SendPropertyChanged("PaymentDate2");
            }
        }

        private double? _RefundAmount2;

        public double? RefundAmount2
        {
            get
            {
                return _RefundAmount2;
            }
            set
            {
                this.SendPropertyChanging();
                this._RefundAmount2 = value;
                this.SendPropertyChanged("RefundAmount2");
            }
        }

        private DateTime? _RefundDate2;

        public DateTime? RefundDate2
        {
            get
            {
                return _RefundDate2;
            }
            set
            {
                this.SendPropertyChanging();
                this._RefundDate2 = value;
                this.SendPropertyChanged("RefundDate2");
            }
        }
        public int? PaymentLogID2
        {
            set;
            get;
        }

        private string _creditNoteNo2;

        public string CreditNoteNo2
        {
            get { return _creditNoteNo2; }
            set
            {
                this.SendPropertyChanging();
                this._creditNoteNo2 = value;
                this.SendPropertyChanged("CreditNoteNo2");
            }
        }

        private DateTime? _creditNoteDate2;
        public DateTime? CreditNoteDate2
        {
            get { return _creditNoteDate2; }
            set
            {
                this.SendPropertyChanging();
                this._creditNoteDate2 = value;
                this.SendPropertyChanged("CreditNoteDate2");
            }
        }
        #endregion Properties

        #region Methods (8)

        // Public Methods (8) 

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Invoice right = obj as Invoice;
            if (right == null)
            {
                return false;
            }
            return this.GetHashCode() == right.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(DateTime date)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceAssignBatches.Count(batch => batch.AssignDate >= begin && batch.AssignDate < end);
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
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceAssignBatches.Count(batch => batch.AssignDate >= begin && batch.AssignDate < end);
            batchCount += batchesInMemory.Count(batch => batch.AssignDate >= begin && batch.AssignDate < end);
            string assignNo = String.Format("ASS{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(DateTime date)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceFinanceBatches.Count(batch => batch.FinancePeriodBegin >= begin && batch.FinancePeriodBegin < end);
            string financeNo = String.Format("FIN{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return financeNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateFinanceBatchNo(DateTime date, List<InvoiceFinanceBatch> batchesInMemory)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoiceFinanceBatches.Count(batch => batch.FinancePeriodBegin >= begin && batch.FinancePeriodBegin < end);
            batchCount += batchesInMemory.Count(batch => batch.FinancePeriodBegin >= begin && batch.FinancePeriodBegin < end);
            string financeNo = String.Format("FIN{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return financeNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(DateTime date)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoicePaymentBatches.Count(batch => batch.PaymentDate >= begin && batch.PaymentDate < end);
            string paymentNo = String.Format("PAY{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return paymentNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GeneratePaymentBatchNo(DateTime date, List<InvoicePaymentBatch> batchesInMemory)
        {
            DateTime begin = date.Date;
            DateTime end = begin.AddDays(1);
            int batchCount = App.Current.DbContext.InvoicePaymentBatches.Count(batch => batch.PaymentDate >= begin && batch.PaymentDate < end);
            batchCount += batchesInMemory.Count(batch => batch.PaymentDate >= begin && batch.PaymentDate < end);
            string paymentNo = String.Format("PAY{0:yyyyMMdd}-{1:d2}", date, batchCount + 1);
            return paymentNo;
        }

        public override int GetHashCode()
        {
            if (this.InvoiceNo == null)
            {
                return 0;
            }
            else
            {
                return this.InvoiceNo.GetHashCode();
            }
        }

        #endregion Methods
    }
}
