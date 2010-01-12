using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using System.Collections;

namespace CMBC.EasyFactor.ARMgr
{
    public partial class CreditNotePayment : UserControl
    {
        private CDA _CDA;

        public CreditNotePayment()
        {
            InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvCreditNote);
            this.dgvCreditNote.AutoGenerateColumns = false;
            this.dgvCreditNote.ReadOnly = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public CDA CDA
        {
            set
            {
                this._CDA = value;
                this.dgvCreditNote.ReadOnly = false;
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            IList deductionList = this.invoiceDeductionBindingSource.List;
            bool isSaveOK = true;
            List<CreditNote> creditNoteList = new List<CreditNote>();
            try
            {
                foreach (InvoiceDeduction decution in deductionList)
                {
                    CreditNote cn = App.Current.DbContext.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == decution.CreditNoteNo);
                    if (cn == null)
                    {
                        cn = creditNoteList.SingleOrDefault(c => c.CreditNoteNo == decution.CreditNoteNo);
                        if (cn == null)
                        {
                            cn = new CreditNote() { CreditNoteNo = decution.CreditNoteNo, CreditNoteDate = decution.CreditNoteDate };
                            creditNoteList.Add(cn);
                        }
                    }
                    decution.CreditNote = cn;
                    Invoice invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == decution.InvoiceNo && i.InvoiceAssignBatch.CDACode == this._CDA.CDACode);
                    if (invoice == null)
                    {
                        MessageBox.Show("发票号码错误: "+decution.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    decution.Invoice = invoice;
                    decution.CreateUserName = App.Current.CurUser.Name;
                }
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceDeduction decution in deductionList)
                {
                    decution.Invoice = null;
                }
                isSaveOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ResetControlsStatus()
        {
            this.invoiceDeductionBindingSource.DataSource = typeof(InvoiceDeduction);
        }

        private void dgvCreditNote_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        private void dgvCreditNote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvCreditNote_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dgvCreditNote_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
