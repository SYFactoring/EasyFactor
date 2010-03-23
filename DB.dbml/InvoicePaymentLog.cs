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
        #region Properties (6)

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

        public string InvoiceNo2
        {
            get;
            set;
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
                    return AssignOutstanding2;
                }
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public DateTime CreditNoteDate
        {
            get
            {
                return this.CreditNote.CreditNoteDate;
            }
            set
            {
                this.CreditNote.CreditNoteDate = value;
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
                    return DueDate2;
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

        #endregion Properties
    }
}
