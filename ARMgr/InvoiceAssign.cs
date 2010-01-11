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
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Collections.Generic;

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
                NewBatch(null, null);
            }
        }

        #endregion Properties

        #region Methods (20)

        // Public Methods (2) 

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
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelAssignBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.invoiceBindingSource.DataSource = typeof(Invoice);
            this.batchBindingSource.DataSource = typeof(InvoiceAssignBatch);
        }
        // Private Methods (18) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedInvoice"></param>
        private void CaculateCommisssion(Invoice selectedInvoice)
        {
            if (this._CDA.CommissionType == "按转让金额")
            {
                selectedInvoice.Commission = selectedInvoice.AssignAmount * this._CDA.Price ?? 0;
                if (selectedInvoice.Commission.GetValueOrDefault() > 0)
                {
                    if (selectedInvoice.InvoiceAssignBatch != null)
                    {
                        selectedInvoice.CommissionDate = selectedInvoice.InvoiceAssignBatch.AssignDate;
                    }
                }
                else
                {
                    selectedInvoice.CommissionDate = null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.CDA.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.CDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

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
                if (!(this.batchBindingSource.DataSource is InvoiceAssignBatch))
                {
                    return;
                }
                Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
                selectedInvoice.InvoiceType = "Invoice";
                InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.batchBindingSource.DataSource;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colInvoiceDate || col == colCommissionDate)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvInvoices_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colInvoiceDate || col == colCommissionDate)
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
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colCommission)
            {
                if (e.Value.Equals(string.Empty))
                {
                    e.Value = default(double);
                    e.ParsingApplied = true;
                    return;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }
            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colInvoiceDate || col == colCommissionDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colCommission)
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
                selectedInvoice.AssignAmount = selectedInvoice.InvoiceAmount;
                CaculateCommisssion(selectedInvoice);
            }
            else if (this.dgvInvoices.Columns[e.ColumnIndex] == colAssignAmount)
            {
                CaculateCommisssion(selectedInvoice);
                StatBatch();
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
            if (!(this.batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            ExportUtil exportUtil = new ExportUtil(ExportUtil.ExportType.EXPORT_INVOICES);
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
            if (!(this.batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_INVOICES_BY_BATCH);
            importForm.ShowDialog(this);
            IList invoiceList = importForm.ImportedList;
            if (invoiceList != null)
            {
                foreach (Invoice invoice in this.invoiceBindingSource.List)
                {
                    invoice.InvoiceAssignBatch = null;
                }
                this.invoiceBindingSource.DataSource = invoiceList;
                foreach (Invoice invoice in invoiceList)
                {
                    if (invoice.Commission.HasValue == false)
                    {
                        CaculateCommisssion(invoice);
                    }
                }
                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InvoiceAssignBatch batch = new InvoiceAssignBatch();
            batch.AssignDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.IsCreateMsg = false;
            batch.BatchCurrency = this._CDA.Case.InvoiceCurrency;
            batch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = batch;
            this.invoiceBindingSource.DataSource = batch.Invoices.ToList();
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
            if (!(this.batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }
            IList invoiceList = this.invoiceBindingSource.List;

            if (!ValidateBatch())
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.batchBindingSource.DataSource;
            batch.CDA = this._CDA;
            if (batch.AssignBatchNo == null)
            {
                batch.AssignBatchNo = GenerateAssignBatchNo(DateTime.Now.Date);
            }
            foreach (Invoice invoice in invoiceList)
            {
                invoice.InvoiceAssignBatch = batch;
            }
            try
            {
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (Invoice invoice in invoiceList)
                {
                    invoice.InvoiceAssignBatch = null;
                }
                batch.CDA = null;
                batch.AssignBatchNo = null;
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
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this._CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AssignBatchMgr batchMgr = new AssignBatchMgr(this._CDA);
            QueryForm queryUI = new QueryForm(batchMgr, "选择转让批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceAssignBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                this.batchBindingSource.DataSource = selectedBatch;
                this.invoiceBindingSource.DataSource = selectedBatch.Invoices.ToList();
                this.StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList invoiceList = this.invoiceBindingSource.List;
            double totalAssign = 0;
            double totalCommmission = 0;
            foreach (Invoice invoice in invoiceList)
            {
                totalAssign += invoice.AssignAmount;
                totalCommmission += invoice.Commission.GetValueOrDefault();
            }
            this.tbTotalAssign.Text = String.Format("{0:N2}", totalAssign);
            this.tbAssignNumber.Text = String.Format("{0}", invoiceList.Count);
            this.tbTotalCommission.Text = String.Format("{0:N2}", totalCommmission);
            this.tbTotalHandfee.Text = String.Format("{0:N2}", invoiceList.Count * this._CDA.HandFee.GetValueOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            foreach (Invoice invoice in this.invoiceBindingSource.List)
            {
                if (invoice.AssignAmount > invoice.InvoiceAmount)
                {
                    MessageBox.Show("转让金额不能大于票面金额: " + invoice.InvoiceNo, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                DateTime date = this.assignDateDateTimePicker.Value.Date;
                if (invoice.InvoiceDate > date)
                {
                    MessageBox.Show("转让日不能早于发票日: " + invoice.InvoiceNo, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                int paymentTermDays = this._CDA.Case.NetPaymentTerm;
                if (paymentTermDays != 0)
                {
                    if (date > invoice.InvoiceDate.AddDays(paymentTermDays))
                    {
                        MessageBox.Show("转让日不能晚于发票日+付款期限: " + invoice.InvoiceNo, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                if (invoice.DueDate < date)
                {
                    invoice.IsDispute = true;
                }
            }
            return true;
        }

        #endregion Methods
    }
}
