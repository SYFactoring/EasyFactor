//-----------------------------------------------------------------------
// <copyright file="InvoiceAssign.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssign : UserControl
    {
        #region Fields (2)

        private CDA _CDA;
        private ARCaseBasic caseBasic;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoiceAssign(ARCaseBasic caseBasic)
        {
            this.InitializeComponent();
            this.caseBasic = caseBasic;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            this.dgvInvoices.ReadOnly = true;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.dgvInvoices.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvInvoices_CellFormatting);
            this.dgvInvoices.CellParsing += new DataGridViewCellParsingEventHandler(dgvInvoices_CellParsing);
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
                NewAssignBatch(null, null);
            }
        }

        #endregion Properties

        #region Methods (15)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        public static string GenerateAssignBatchNo(CDA cda, System.Nullable<DateTime> date)
        {
            int batchCount = 0;
            foreach (CDA c in cda.Case.CDAs)
            {
                batchCount += c.InvoiceAssignBatches.Count;
            }
            if (date == null)
            {
                date = DateTime.Now;
            }
            string assignNo = String.Format("ASS{0:G}{1:yyyyMMdd}-{2:d2}", cda.CaseCode, date, batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelAssignBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.invoiceBindingSource.DataSource = typeof(Invoice);
            this.invoiceAssignBatchBindingSource.DataSource = typeof(InvoiceAssignBatch);
        }
        // Private Methods (13) 

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (this.dgvInvoices.Rows[e.RowIndex].IsNewRow)
            {
                if (!(this.invoiceAssignBatchBindingSource.DataSource is InvoiceAssignBatch))
                {
                    return;
                }
                Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
                InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
                selectedInvoice.InvoiceCurrency = assignBatch.BatchCurrency;
                selectedInvoice.AssignDate = DateTime.Now;
            }
        }

        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colAssignDate || col == colDueDate || col == colInvoiceDate || col == colValueDate)
            {
                DateTime date = (DateTime)e.Value;
                e.Value = date.ToString("yyyyMMdd");
                e.FormattingApplied = true;
            }
        }

        void dgvInvoices_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }
            if (e.Value.Equals(string.Empty))
            {
                e.Value = null;
                e.ParsingApplied = true;
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colAssignDate || col == colDueDate || col == colInvoiceDate || col == colValueDate)
            {
                string str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
            }
        }

        private void dgvInvoices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colAssignDate || col == colDueDate || col == colInvoiceDate || col == colValueDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colInvoiceAmount || col == colAssignAmount)
            {
                string str = (string)e.FormattedValue;
                double result;
                bool ok = Double.TryParse(str, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            if (this.dgvInvoices.Columns[e.ColumnIndex] == colInvoiceAmount)
            {
                if (!selectedInvoice.AssignAmount.HasValue)
                {
                    selectedInvoice.AssignAmount = selectedInvoice.InvoiceAmount;
                }
            }
            else if (this.dgvInvoices.Columns[e.ColumnIndex] == colInvoiceDate)
            {
                if (!selectedInvoice.ValueDate.HasValue)
                {
                    selectedInvoice.ValueDate = selectedInvoice.InvoiceDate;
                }
            }
        }

        private void dgvInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailInvoice(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAssignBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(this.invoiceAssignBatchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }
            if (this.invoiceBindingSource.List.Count == 0)
            {
                return;
            }

            ExportUtil exportUtil = new ExportUtil(ExportUtil.ExportType.EXPORT_ASSIGN);
            exportUtil.StartExport(this.invoiceBindingSource.List);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Flaw(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.FLAW);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportAssignBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(this.invoiceAssignBatchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN);
            importForm.ShowDialog(this);
            IList invoiceList = importForm.ImportedList;
            InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
            foreach (Invoice invoice in invoiceList)
            {
                invoice.InvoiceAssignBatch = assignBatch;
            }

            this.invoiceBindingSource.DataSource = invoiceList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAssignBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InvoiceAssignBatch assignBatch = new InvoiceAssignBatch();
            assignBatch.BatchDate = DateTime.Now;
            assignBatch.CreateUserName = App.Current.CurUser.Name;
            assignBatch.IsCreateMsg = false;
            assignBatch.BatchCurrency = this._CDA.Case.InvoiceCurrency;
            this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
            this.invoiceBindingSource.DataSource = assignBatch.Invoices.ToList();
            this.dgvInvoices.ReadOnly = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAssignBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!this.superValidator.Validate())
            {
                return;
            }
            if (!(this.invoiceAssignBatchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }
            IList invoiceList = this.invoiceBindingSource.List;
            if (invoiceList.Count == 0)
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
            assignBatch.CDA = this._CDA;
            if (assignBatch.AssignBatchNo == null)
            {
                assignBatch.AssignBatchNo = GenerateAssignBatchNo(this._CDA, DateTime.Now);
            }
            foreach (Invoice invoice in invoiceList)
            {
                invoice.InvoiceAssignBatch = assignBatch;
            }
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isSaveOK = false;
                MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._CDA);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAssignBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AssignBatchMgr assignBatchMgr = new AssignBatchMgr(this._CDA);
            QueryForm queryUI = new QueryForm(assignBatchMgr, "选择转让批次");
            assignBatchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceAssignBatch assignBatch = assignBatchMgr.Selected;
            if (assignBatch != null)
            {
                this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
                this.invoiceBindingSource.DataSource = assignBatch.Invoices.ToList();
            }
        }

        #endregion Methods
    }
}
