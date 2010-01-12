

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    public partial class CreditNotePayment : UserControl
    {
        #region Fields (1)

        private CDA _CDA;

        #endregion Fields

        #region Constructors (1)

        public CreditNotePayment()
        {
            InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvInvoiceDeduction);
            this.dgvInvoiceDeduction.AutoGenerateColumns = false;
            this.dgvInvoiceDeduction.ReadOnly = true;
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public CDA CDA
        {
            set
            {
                this._CDA = value;
                this.dgvInvoiceDeduction.ReadOnly = false;
            }
        }

        #endregion Properties

        #region Methods (6)

        // Public Methods (1) 

        public void ResetControlsStatus()
        {
            this.invoiceDeductionBindingSource.DataSource = typeof(InvoiceDeduction);
        }
        // Private Methods (5) 

        private void dgvCreditNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (this.dgvInvoiceDeduction.Rows[e.RowIndex].IsNewRow)
            {
                InvoiceDeduction selectedInvoiceDeduction = (InvoiceDeduction)this.invoiceDeductionBindingSource.List[this.dgvInvoiceDeduction.CurrentCell.RowIndex];
                selectedInvoiceDeduction.DeductionDate = DateTime.Now.Date;
            }
        }

        private void dgvCreditNote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            DataGridViewColumn col = this.dgvInvoiceDeduction.Columns[e.ColumnIndex];
            if (col == colCreditNoteDate || col == colDeductionDate)
            {
                DateTime date = (DateTime)e.Value;
                if (date == default(DateTime))
                {
                    e.Value = "";
                }
                else
                {
                    e.Value = date.ToString("yyyyMMdd");
                }
                e.FormattingApplied = true;
            }
        }

        private void dgvCreditNote_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = this.dgvInvoiceDeduction.Columns[e.ColumnIndex];
            if (col == colCreditNoteDate || col == colDeductionDate)
            {
                if (e.Value.Equals(string.Empty))
                {
                    e.Value = null;
                    e.ParsingApplied = true;
                    return;
                }
                string str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
            }
            else if (col == colDeductionAmount)
            {
                if (e.Value.Equals(string.Empty))
                {
                    e.Value = default(double);
                    e.ParsingApplied = true;
                    return;
                }
            }
        }

        private void dgvCreditNote_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }
            DataGridViewColumn col = this.dgvInvoiceDeduction.Columns[e.ColumnIndex];
            if (col == colCreditNoteDate || col == colDeductionDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colDeductionAmount)
            {
                string str = (string)e.FormattedValue;
                double result;
                bool ok = Double.TryParse(str, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
                if (result < 0)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colInvoiceNo || col == colCreditNoteNo)
            {
                string str = (string)e.FormattedValue;
                Regex regex = new Regex(@"^[a-zA-Z0-9-]+$");
                bool ok = regex.IsMatch(str);
                if (!ok)
                {
                    e.Cancel = true;
                }
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
                        MessageBox.Show("发票号码错误: " + decution.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    decution.CreditNote = null;
                }
                isSaveOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Methods
    }
}
