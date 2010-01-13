using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMBC.EasyFactor.DB.dbml
{
    public partial class InvoicePaymentLog
    {
        #region Properties (1)
        
        public DateTime CreditNoteDate
        {
            get
            {
                return this.CreditNote.CreditNoteDate;
            }
        }
        public double AssignAmount
        {
            get
            {
                return Invoice.AssignAmount;
            }
        }
        public double AssignOutstanding
        {
            get
            {
                return Invoice.AssignOutstanding;
            }
        }
        public DateTime AssignDate
        {
            get
            {
                return Invoice.AssignDate;
            }
        }
        public DateTime DueDate
        {
            get
            {
                return Invoice.DueDate;
            }
        }
        public double? FinanceAmount
        {
            get
            {
                return this.Invoice.FinanceAmount;
            }
        }
        public DateTime? FinanceDate
        {
            get
            {
                return this.Invoice.FinanceDate;
            }
        }
        public DateTime? FinanceDueDate
        {
            get
            {
                return this.Invoice.FinanceDueDate;
            }
        }
        public double? FinanceOutstanding
        {
            get
            {
                return this.Invoice.FinanceOutstanding;
            }
        }
        #endregion Properties

    }
}
