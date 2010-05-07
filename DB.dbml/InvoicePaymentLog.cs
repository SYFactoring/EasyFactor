//-----------------------------------------------------------------------
// <copyright file="InvoicePaymentLog.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoicePaymentLog
    {
		#region?Constructors?(1)?

        public InvoicePaymentLog(Invoice invoice)
            : this()
        {
            this.InvoiceNo2 = invoice.InvoiceNo;
            this.AssignAmount2 = invoice.AssignAmount;
            this.AssignOutstanding2 = invoice.AssignOutstanding;
            this.DueDate2 = invoice.DueDate;
            this.AssignDate2 = invoice.AssignDate;
            this.InvoicePaymentAmount2 = invoice.PaymentAmount;
        }

		#endregion?Constructors?

		#region?Properties?(16)?

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
                    return AssignOutstanding2;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double AssignOutstanding2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreditNoteDate
        {
            get
            {
                if (this.CreditNote != null)
                {
                    return this.CreditNote.CreditNoteDate;
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
        public DateTime? CreditNoteDate2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string CreditNoteNo2
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
                    return DueDate2;
                }
            }
        }

        public DateTime? DueDate2
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
        public double? InvoicePaymentAmount
        {
            get
            {
                if (this.Invoice != null)
                {
                    return this.Invoice.PaymentAmount;
                }
                else
                {
                    return InvoicePaymentAmount2;
                }
            }
        }

        public double? InvoicePaymentAmount2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public String PaymentCurrency
        {
            get
            {
                return this.Invoice.InvoiceCurrency;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime PaymentDate
        {
            get
            {
                return this.InvoicePaymentBatch.PaymentDate;
            }
        }

		#endregion?Properties?
    }
}
