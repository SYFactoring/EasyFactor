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
            set
            {
                this.CreditNote.CreditNoteDate = value;
            }
            get
            {
                return this.CreditNote.CreditNoteDate;
            }
        }

        #endregion Properties

        partial void OnCreated()
        {
            this.CreditNote = new CreditNote();
        }
    }
}
