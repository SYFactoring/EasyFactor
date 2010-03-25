//-----------------------------------------------------------------------
// <copyright file="InvoiceAssign.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssign : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private Case _case;

        /// <summary>
        /// 
        /// </summary>
        private ARCaseBasic caseBasic;

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the InvoiceAssign class
        /// </summary>
        /// <param name="caseBasic"></param>
        public InvoiceAssign(ARCaseBasic caseBasic)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvInvoices.ImeMode = ImeMode.OnHalf;
            this.caseBasic = caseBasic;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.superValidator.Enabled = false;
            this.dgvInvoices.ReadOnly = true;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            this.context = new DBDataContext();
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// Sets
        /// </summary>
        public Case Case
        {
            set
            {
                this._case = this.context.Cases.SingleOrDefault(c => c.CaseCode == value.CaseCode);
                this.NewBatch(null, null);
            }
        }

        #endregion Properties

        #region Methods (20)

        // Public Methods (2) 

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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
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
            CDADetail cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.Case.ActiveCDA, CDADetail.OpCDAType.DETAIL_CDA);
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

                this.superValidator.Validate();
                Invoice selectedInvoice = (Invoice)this.invoiceBindingSource.List[this.dgvInvoices.CurrentCell.RowIndex];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == this.colDueDate || col == this.colInvoiceDate)
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
            else if (col == this.colIsFlaw)
            {
                object result = e.Value;
                if (result != null)
                {
                    bool isFlaw = (bool)e.Value;
                    if (isFlaw)
                    {
                        e.Value = "Y";
                    }
                    else
                    {
                        e.Value = "N";
                    }

                    e.FormattingApplied = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = this.dgvInvoices.Columns[e.ColumnIndex];
            if (col == this.colDueDate || col == this.colInvoiceDate)
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
            else if (col == this.colInvoiceAmount || col == this.colAssignAmount || col == this.colCommission)
            {
                if (e.Value.Equals(string.Empty))
                {
                    e.Value = default(double);
                    e.ParsingApplied = true;
                    return;
                }
            }
            else if (col == this.colIsFlaw)
            {
                if (e.Value.Equals("Y"))
                {
                    e.Value = true;
                    e.ParsingApplied = true;
                    return;
                }
                else if (e.Value.Equals("N"))
                {
                    e.Value = false;
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
            if (col == this.colDueDate || col == this.colInvoiceDate)
            {
                string str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == this.colInvoiceAmount || col == this.colAssignAmount || col == this.colCommission)
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
            else if (col == this.colInvoiceNo)
            {
                string str = (string)e.FormattedValue;
                Regex regex = new Regex("^[a-zA-Z0-9]+[a-zA-Z0-9\\-<>]+$");
                bool ok = regex.IsMatch(str);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == this.colIsFlaw)
            {
                string str = (string)e.FormattedValue;
                if ("Y".Equals(str) || "N".Equals(str))
                {
                    return;
                }
                else
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

            if (this.dgvInvoices.Columns[e.ColumnIndex] == this.colInvoiceAmount)
            {
                selectedInvoice.AssignAmount = selectedInvoice.InvoiceAmount;
                this.StatBatch();
            }
            else if (this.dgvInvoices.Columns[e.ColumnIndex] == this.colAssignAmount)
            {
                CDA cda = this._case.ActiveCDA;
                if (cda.CommissionType == "按转让金额")
                {
                    if (this._case.TransactionType == "进口保理")
                    {
                        selectedInvoice.Commission = selectedInvoice.AssignAmount * cda.IFPrice;
                    }
                    else
                    {
                        selectedInvoice.Commission = selectedInvoice.AssignAmount * cda.EFPrice;
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
        private void dgvInvoices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DetailInvoice(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAssignBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_ASSIGN_BY_BATCH, this.invoiceBindingSource.List);
            exportForm.Show();
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
            if (this._case == null)
            {
                MessageBoxEx.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN_BY_BATCH, context);
            importForm.ShowDialog(this);

            if (importForm.ImportedList != null)
            {
                List<Invoice> invoiceList = (List<Invoice>)importForm.ImportedList;
                foreach (Invoice invoice in this.invoiceBindingSource.List)
                {
                    if (!invoiceList.Contains(invoice))
                    {
                        invoiceList.Add(invoice);
                    }
                }

                foreach (Invoice invoice in invoiceList)
                {
                    if (invoice.Commission.HasValue == false)
                    {
                        invoice.CaculateCommission(false);
                    }
                }

                this.invoiceBindingSource.DataSource = invoiceList;
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
            if (this._case == null)
            {
                MessageBoxEx.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this._case.ActiveCDA.CommissionType == "按转让金额" || this._case.ActiveCDA.CommissionType == "其他")
            {
                this.colCommission.Visible = true;
            }
            else
            {
                this.colCommission.Visible = false;
            }

            InvoiceAssignBatch batch = new InvoiceAssignBatch();
            batch.AssignDate = DateTime.Now.Date;
            batch.CreateUserName = App.Current.CurUser.Name;
            batch.IsCreateMsg = false;
            batch.CheckStatus = "未复核";
            this.batchBindingSource.DataSource = batch;
            this.invoiceBindingSource.DataSource = batch.Invoices;
            this.dgvInvoices.ReadOnly = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAssignBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this._case == null)
            {
                MessageBoxEx.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.batchBindingSource.DataSource;

            if (invoiceList.Count == 0)
            {
                return;
            }

            if (!this.ValidateBatch())
            {
                return;
            }

            double totalAssign = 0;
            List<string> invoiceNoList = new List<string>();
            foreach (Invoice invoice in invoiceList)
            {
                if (!invoiceNoList.Contains(invoice.InvoiceNo))
                {
                    invoiceNoList.Add(invoice.InvoiceNo);
                }
                else
                {
                    MessageBoxEx.Show("发票号重复: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (batch.AssignBatchNo == null && context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoice.InvoiceNo) != null)
                {
                    MessageBoxEx.Show("发票号已存在: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                totalAssign += invoice.AssignAmount;
            }

            if (this._case.ActiveCDA.CreditCoverOutstanding.HasValue && totalAssign > this._case.ActiveCDA.CreditCoverOutstanding.Value)
            {
                DialogResult dr = MessageBoxEx.Show("买卖方关联额度中的买方信用风险担保额度已占满，超额度转让部分不再进行担保，是否确认转让？", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            if (this._case.BuyerClient.AssignCreditLineOutstanding.HasValue && totalAssign > this._case.BuyerClient.AssignCreditLineOutstanding.Value)
            {
                DialogResult dr = MessageBoxEx.Show("客户额度已占满，超额度转让部分不再进行担保，是否确认转让？", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            if (this._case.BuyerClient.GroupAssignCreditLine != null)
            {
                double assignCreditLineOutstanding = this._case.BuyerClient.GroupAssignCreditLine.AssignCreditLineOutstanding;
                if (this._case.BuyerClient.GroupAssignCreditLine.CreditLineCurrency != this._case.BuyerClient.AssignCreditLine.CreditLineCurrency)
                {
                    double exchange = Exchange.GetExchangeRate(this._case.BuyerClient.GroupAssignCreditLine.CreditLineCurrency, this._case.BuyerClient.AssignCreditLine.CreditLineCurrency);
                    assignCreditLineOutstanding *= exchange;
                }

                if (totalAssign > assignCreditLineOutstanding)
                {
                    DialogResult dr = MessageBoxEx.Show("集团额度已占满，超额度转让部分不再进行担保，是否确认转让？", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            bool isSaveOK = true;

            List<Invoice> flawList = new List<Invoice>();
            try
            {
                batch.Case = this._case;
                if (batch.AssignBatchNo == null)
                {
                    batch.AssignBatchNo = InvoiceAssignBatch.GenerateAssignBatchNo(batch.AssignDate);
                }

                foreach (Invoice invoice in invoiceList)
                {
                    invoice.InvoiceAssignBatch = batch;
                    invoice.CaculateCommission(false);
                    if (invoice.IsFlaw)
                    {
                        flawList.Add(invoice);
                    }
                }

                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (Invoice invoice in invoiceList)
                {
                    invoice.InvoiceAssignBatch = null;
                }

                batch.Case = null;
                batch.AssignBatchNo = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.caseBasic.CaculateOutstanding(this._case);
                this.StatBatch();

                if (flawList.Count > 0)
                {
                    InvoiceFlaw flawMgr = new InvoiceFlaw(flawList, true);
                    flawMgr.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this._case == null)
            {
                MessageBoxEx.Show("没有有效的额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AssignBatchMgr batchMgr = new AssignBatchMgr(this._case, this.context);
            QueryForm queryUI = new QueryForm(batchMgr, "选择转让批次");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceAssignBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                //    InvoiceAssignBatch batch = this.context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == selectedBatch.AssignBatchNo);
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
            this.tbTotalHandfee.Text = String.Format("{0:N2}", invoiceList.Count * this._case.ActiveCDA.HandFee.GetValueOrDefault());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            CDA cda = this._case.ActiveCDA;


            foreach (Invoice invoice in this.invoiceBindingSource.List)
            {
                if (invoice.InvoiceNo == null)
                {
                    MessageBoxEx.Show("发票号必填", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (TypeUtil.EqualsZero(invoice.InvoiceAmount))
                {
                    MessageBoxEx.Show("票面金额必填", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //if (invoice.InvoiceDate == default(DateTime))
                //{
                //    MessageBoxEx.Show("发票日必填", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return false;
                //}

                //if (invoice.DueDate == default(DateTime))
                //{
                //    MessageBoxEx.Show("到期日必填", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return false;
                //}

                if (invoice.AssignAmount > invoice.InvoiceAmount)
                {
                    MessageBoxEx.Show("转让金额不能大于票面金额: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (invoice.DueDate != null && invoice.InvoiceDate != null && invoice.DueDate < invoice.InvoiceDate)
                {
                    MessageBoxEx.Show("到期日不可早于发票日: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                DateTime assignDate = this.assignDateDateTimePicker.Value.Date;
                if (invoice.InvoiceDate != null && invoice.InvoiceDate > assignDate)
                {
                    MessageBoxEx.Show("转让日不能早于发票日: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (this._case.NetPaymentTerm.HasValue)
                {
                    if (invoice.InvoiceDate != null && assignDate > invoice.InvoiceDate.Value.AddDays(this._case.NetPaymentTerm.Value))
                    {
                        MessageBoxEx.Show("转让日不能晚于发票日+付款期限: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                if (invoice.DueDate != null && invoice.DueDate < assignDate)
                {
                    invoice.IsFlaw = true;
                    invoice.FlawReason = "09";
                }

                if (invoice.Commission.HasValue == false && cda.CommissionType == "其他")
                {
                    DialogResult dr = MessageBoxEx.Show("是否现在录入手续费: " + invoice.InvoiceNo, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion Methods
    }
}
