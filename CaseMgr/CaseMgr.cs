//-----------------------------------------------------------------------
// <copyright file="CaseMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpCaseType opCaseType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpCaseType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            ENABLE_CASE,

            /// <summary>
            /// 
            /// </summary>
            APPLICATION_CASE,

            /// <summary>
            /// 
            /// </summary>
            STAT
        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        /// <param name="isContract"></param>
        public CaseMgr(OpCaseType opCaseType)
            : this()
        {
            this.opCaseType = opCaseType;
            if (opCaseType == OpCaseType.ENABLE_CASE)
            {
                this.cbCaseMark.Text = "启动案";
            }
            else if (opCaseType == OpCaseType.APPLICATION_CASE)
            {
                this.cbCaseMark.Text = "申请案";
                this.QueryCase(null, null);
            }
            else if (opCaseType == OpCaseType.STAT)
            {
                this.colAppDate.Visible = false;
                this.colOPName.Visible = false;
                this.colAssignAmount.Visible = true;
                this.colFinanceAmount.Visible = true;
                this.colCommissionIncome.Visible = true;
                this.colNetInterestIncome.Visible = true;
                this.colMarginIncome.Visible = true;
                this.colTotalIncome.Visible = true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        public CaseMgr()
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvCases.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvCases.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvCases);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.cbTransactionType.Items.Insert(0, "全部");
            this.cbTransactionType.Text = "全部";
            this.cbCaseMark.Text = "启动案";

            List<Department> deptsList = Department.AllDepartments(new DBDataContext());
            deptsList.Insert(0, new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" });
            this.cbOwnerDepts.DataSource = deptsList;
            this.cbOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbOwnerDepts.ValueMember = "DepartmentCode";
            this.cbOwnerDepts.GroupingMembers = "Domain";

            List<Currency> currencyList = Currency.AllCurrencies();
            currencyList.Insert(0, new Currency() { CurrencyCode = "AAA", CurrencyName = "All" });
            this.cbCurrency.DataSource = currencyList;
            this.cbCurrency.DisplayMember = "CurrencyFormat";
            this.cbCurrency.ValueMember = "CurrencyCode";

            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();
        }

        #endregion Constructors

        #region Properties (3)

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected Case
        /// </summary>
        public Case Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (13)

        // Private Methods (13) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaculateFinance(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                return;
            }

            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            List<Case> selectedCases = this.GetSelectedCases();
            if (selectedCases.Count > 0)
            {
                foreach (Case c in selectedCases)
                {
                    foreach (InvoiceAssignBatch batch in c.InvoiceAssignBatches)
                    {
                        foreach (Invoice i in batch.Invoices)
                        {
                            i.CaculateRefund();
                            i.CaculateFinance();
                        }
                    }
                }

                try
                {
                    this.context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailCase(sender, e);
            }
            else
            {
                this.SelectCase(sender, e);
            }
        }

        /// <summary>
        /// Delete selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCase(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            if (MessageBoxEx.Show("此案件是" + selectedCase.CaseMark + "，是否确定删除", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool isDeleteOK = true;
                foreach (InvoiceAssignBatch assignBatch in selectedCase.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        foreach (InvoiceFinanceLog financeLog in invoice.InvoiceFinanceLogs)
                        {
                            context.InvoiceRefundLogs.DeleteAllOnSubmit(financeLog.InvoiceRefundLogs);
                        }

                        context.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                        context.InvoiceFinanceLogs.DeleteAllOnSubmit(invoice.InvoiceFinanceLogs);

                    }

                    context.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                }

                context.InvoiceAssignBatches.DeleteAllOnSubmit(selectedCase.InvoiceAssignBatches);
                context.InvoiceFinanceBatches.DeleteAllOnSubmit(selectedCase.InvoiceFinanceBatches);
                context.InvoicePaymentBatches.DeleteAllOnSubmit(selectedCase.InvoicePaymentBatches);
                context.InvoiceRefundBatches.DeleteAllOnSubmit(selectedCase.InvoiceRefundBatches);

                context.CDAs.DeleteAllOnSubmit(selectedCase.CDAs);
                context.Cases.DeleteOnSubmit(selectedCase);
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isDeleteOK = false;
                    MessageBoxEx.Show("不能删除此案件: " + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isDeleteOK)
                {
                    MessageBoxEx.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCases.Rows.RemoveAt(dgvCases.CurrentCell.RowIndex);
                }
            }
        }

        /// <summary>
        /// Show detail info of selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCases_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvCases.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCases.RowHeadersDefaultCellStyle.Font, rectangle, dgvCases.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Case> GetSelectedCases()
        {
            List<Case> selectedCases = new List<Case>();
            foreach (DataGridViewCell cell in this.dgvCases.SelectedCells)
            {
                Case selectedCase = (Case)this.bs.List[cell.RowIndex];
                if (!selectedCases.Contains(selectedCase))
                {
                    selectedCases.Add(selectedCase);
                }
            }

            return selectedCases;
        }

        /// <summary>
        /// Create a new case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewCase(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            CaseDetail caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCreditCoverNegType.NEW_CREDIT_COVER_NEG);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            DateTime beginDate = this.diBegin.Text != string.Empty ? this.diBegin.Value : this.diBegin.MinDate;
            DateTime endDate = this.diEnd.Text != string.Empty ? this.diEnd.Value : this.diEnd.MinDate;
            string opName = this.tbOPName.Text;
            string location = this.cbLocation.Text;
            string caseMark = this.cbCaseMark.Text;

            context = new DBDataContext();

            var queryResult = context.Cases.Where(c =>
                                   ((string)this.cbOwnerDepts.SelectedValue == "CN01300" ? true : c.OwnerDepartmentCode.Equals((string)this.cbOwnerDepts.SelectedValue))
                                && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType == this.cbTransactionType.Text)
                                && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency == (string)this.cbCurrency.SelectedValue)
                                && (location == "全部" ? true : c.OwnerDepartment.Location == location)
                                && c.CaseCode.Contains(this.tbCaseCode.Text)
                                && (caseMark == "全部" ? true : c.CaseMark.Contains(caseMark))
                                && (c.OPName == null ? true : c.OPName.Contains(opName))
                                && (opCaseType != OpCaseType.STAT && beginDate != this.diBegin.MinDate ? c.CaseAppDate >= beginDate : true)
                                && (opCaseType != OpCaseType.STAT && endDate != this.diEnd.MinDate ? c.CaseAppDate <= endDate : true)
                                && (this.cbIsCDA.Checked == false ? true : c.CDAs.Any(cda => cda.IsSigned == true))
                                && (this.cbIsContractSigned.Checked == false ? true : c.SellerClient.Contracts.Any(con => con.ContractStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY))
                                && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN.Contains(this.tbClientName.Text)
                                 || c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN.Contains(this.tbClientName.Text))
                                    );

            if (opCaseType == OpCaseType.STAT)
            {
                foreach (Case c in queryResult)
                {
                    c.QueryDateFrom = beginDate;
                    c.QueryDateTo = endDate;
                }
            }

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportLeger(object sender, EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            List<Case> selectedCases = this.GetSelectedCases();
            if (selectedCases.Count > 0)
            {
                ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_LEGER, selectedCases);
                form.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            this.cbOwnerDepts.SelectedIndex = 0;
            this.cbTransactionType.SelectedIndex = 0;
            this.cbCurrency.SelectedIndex = 0;
            this.tbCaseCode.Text = string.Empty;
            this.tbClientName.Text = string.Empty;
            this.diBegin.Value = default(DateTime);
            this.diEnd.Value = default(DateTime);
            this.cbIsContractSigned.Checked = true;
            this.cbIsCDA.Checked = true;
            this.tbOPName.Text = string.Empty;
        }

        /// <summary>
        /// Select case and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            this.Selected = selectedCase;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permission.CASE_UPDATE))
            {
                this.menuItemCaseNew.Enabled = true;
                this.menuItemCaseDelete.Enabled = true;
                this.menuItemCreditCoverNegNew.Enabled = true;
            }
            else
            {
                this.menuItemCaseNew.Enabled = false;
                this.menuItemCaseDelete.Enabled = false;
                this.menuItemCreditCoverNegNew.Enabled = false;
            }
        }

        #endregion Methods
    }
}
