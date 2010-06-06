//-----------------------------------------------------------------------
// <copyright file="CaseMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.CaseMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CaseMgr : UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;
        /// <summary>
        /// 
        /// </summary>
        private readonly OpCaseType _opCaseType;



        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        /// <param name="opCaseType"></param>
        public CaseMgr(OpCaseType opCaseType)
            : this()
        {
            _opCaseType = opCaseType;
            if (opCaseType == OpCaseType.ENABLE_CASE)
            {
                cbCaseMark.Text = @"启动案";
            }
            else if (opCaseType == OpCaseType.APPLICATION_CASE)
            {
                cbCaseMark.Text = @"申请案";
                QueryCase(null, null);
            }
            else if (opCaseType == OpCaseType.STAT)
            {
                colAppDate.Visible = false;
                colOPName.Visible = false;
                colAssignAmount.Visible = true;
                colFinanceAmount.Visible = true;
                colCommissionIncome.Visible = true;
                colNetInterestIncome.Visible = true;
                colMarginIncome.Visible = true;
                colTotalIncome.Visible = true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        public CaseMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvCases.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvCases.DataSource = _bs;
            ControlUtil.SetDoubleBuffered(dgvCases);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            cbTransactionType.Items.Insert(0, "全部");
            cbTransactionType.Text = @"全部";
            cbCaseMark.Text = @"启动案";

            List<Department> deptsList = Department.AllDepartments(new DBDataContext());
            deptsList.Insert(0, new Department { DepartmentCode = "CN01300", DepartmentName = "全部" });
            cbOwnerDepts.DataSource = deptsList;
            cbOwnerDepts.DisplayMembers = "DepartmentName";
            cbOwnerDepts.ValueMember = "DepartmentCode";
            cbOwnerDepts.GroupingMembers = "Domain";

            List<Currency> currencyList = Currency.AllCurrencies;
            currencyList.Insert(0, new Currency { CurrencyCode = "AAA", CurrencyName = "All" });
            cbCurrency.DataSource = currencyList;
            cbCurrency.DisplayMember = "CurrencyFormat";
            cbCurrency.ValueMember = "CurrencyCode";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "全部" });
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            UpdateContextMenu();
        }



        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected Case
        /// </summary>
        public Case Selected { get; set; }




        //?Private?Methods?(14)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaculateInvoices(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                return;
            }

            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            List<Case> selectedCases = GetSelectedCases();
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
                            i.CaculatePayment();
                        }
                    }
                }

                try
                {
                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (OwnerForm == null)
            {
                DetailCase(sender, e);
            }
            else
            {
                SelectCase(sender, e);
            }
        }

        /// <summary>
        /// Delete selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCase(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            var selectedCase = (Case)_bs.List[dgvCases.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("此案件是" + selectedCase.CaseMark + "，是否确定删除", MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (InvoiceAssignBatch assignBatch in selectedCase.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        foreach (InvoiceFinanceLog financeLog in invoice.InvoiceFinanceLogs)
                        {
                            Context.InvoiceRefundLogs.DeleteAllOnSubmit(financeLog.InvoiceRefundLogs);
                        }

                        Context.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                        Context.InvoiceFinanceLogs.DeleteAllOnSubmit(invoice.InvoiceFinanceLogs);
                    }

                    Context.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                }

                Context.InvoiceAssignBatches.DeleteAllOnSubmit(selectedCase.InvoiceAssignBatches);
                Context.InvoiceFinanceBatches.DeleteAllOnSubmit(selectedCase.InvoiceFinanceBatches);
                Context.InvoicePaymentBatches.DeleteAllOnSubmit(selectedCase.InvoicePaymentBatches);
                Context.InvoiceRefundBatches.DeleteAllOnSubmit(selectedCase.InvoiceRefundBatches);

                Context.CDAs.DeleteAllOnSubmit(selectedCase.CDAs);
                Context.Cases.DeleteOnSubmit(selectedCase);
                try
                {
                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show("不能删除此案件: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                dgvCases.Rows.RemoveAt(dgvCases.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// Show detail info of selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            var selectedCase = (Case)_bs.List[dgvCases.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCasesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvCases.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCases.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvCases.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportCases(object sender, EventArgs e)
        {
            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            List<Case> selectedCases = GetSelectedCases();
            if (selectedCases.Count > 0)
            {
                var form = new ExportForm(ExportForm.ExportType.EXPORT_CASES, selectedCases);
                form.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Case> GetSelectedCases()
        {
            var selectedCases = new List<Case>();
            foreach (DataGridViewCell cell in dgvCases.SelectedCells)
            {
                var selectedCase = (Case)_bs.List[cell.RowIndex];
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
        private void NewCase(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            var selectedCase = (Case)_bs.List[dgvCases.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCreditCoverNegType.NEW_CREDIT_COVER_NEG);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            DateTime beginDate = String.IsNullOrEmpty(diBegin.Text) ? diBegin.MinDate : diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(diEnd.Text) ? diEnd.MinDate : diEnd.Value;
            string opName = tbOPName.Text;
            var location = (string)cbLocation.SelectedValue;
            string caseMark = cbCaseMark.Text;

            Context = new DBDataContext();

            IQueryable<Case> queryResult = Context.Cases.Where(c =>
                                                               ((string)cbOwnerDepts.SelectedValue == "CN01300"
                                                                    ? true
                                                                    : c.OwnerDepartmentCode.Equals(
                                                                        (string)cbOwnerDepts.SelectedValue))
                                                               &&
                                                               (cbTransactionType.Text == @"全部"
                                                                    ? true
                                                                    : c.TransactionType == cbTransactionType.Text)
                                                               &&
                                                               ((string)cbCurrency.SelectedValue == "AAA"
                                                                    ? true
                                                                    : c.InvoiceCurrency ==
                                                                      (string)cbCurrency.SelectedValue)
                                                               &&
                                                               (location == "00"
                                                                    ? true
                                                                    : c.OwnerDepartment.LocationCode == location)
                                                               && c.CaseCode.Contains(tbCaseCode.Text)
                                                               &&
                                                               (caseMark == "全部" ? true : c.CaseMark.Contains(caseMark))
                                                               && (c.OPName == null ? true : c.OPName.Contains(opName))
                                                               &&
                                                               (_opCaseType != OpCaseType.STAT &&
                                                                beginDate != diBegin.MinDate
                                                                    ? c.CaseAppDate >= beginDate
                                                                    : true)
                                                               &&
                                                               (_opCaseType != OpCaseType.STAT &&
                                                                endDate != diEnd.MinDate
                                                                    ? c.CaseAppDate <= endDate
                                                                    : true)
                                                               &&
                                                               (cbIsCDAChecked.Checked == false
                                                                    ? true
                                                                    : c.CDAs.Any(cda => cda.CDAStatus == CDAStr.CHECKED))
                                                               &&
                                                               (cbIsContractSigned.Checked == false
                                                                    ? true
                                                                    : c.SellerClient.Contracts.Any(
                                                                        con =>
                                                                        con.ContractStatus ==
                                                                        CLIENT_CREDIT_LINE.AVAILABILITY))
                                                               &&
                                                               (c.BuyerClient.ClientNameCN.Contains(tbClientName.Text) ||
                                                                c.BuyerClient.ClientNameEN.Contains(tbClientName.Text)
                                                                ||
                                                                c.SellerClient.ClientNameCN.Contains(tbClientName.Text) ||
                                                                c.SellerClient.ClientNameEN.Contains(tbClientName.Text))
                );

            if (_opCaseType == OpCaseType.STAT)
            {
                foreach (Case c in queryResult)
                {
                    c.QueryDateFrom = beginDate;
                    c.QueryDateTo = endDate;
                }
            }

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportLegerAll(object sender, EventArgs e)
        {
            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            List<Case> selectedCases = GetSelectedCases();
            if (selectedCases.Count > 0)
            {
                var form = new ExportForm(ExportForm.ExportType.EXPORT_LEGER_ALL, selectedCases);
                form.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportLegerLeft(object sender, EventArgs e)
        {
            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            List<Case> selectedCases = GetSelectedCases();
            if (selectedCases.Count > 0)
            {
                var form = new ExportForm(ExportForm.ExportType.EXPORT_LEGER_LEFT, selectedCases);
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
            cbOwnerDepts.SelectedIndex = 0;
            cbTransactionType.SelectedIndex = 0;
            cbCurrency.SelectedIndex = 0;
            tbCaseCode.Text = string.Empty;
            tbClientName.Text = string.Empty;
            diBegin.Value = default(DateTime);
            diEnd.Value = default(DateTime);
            cbIsContractSigned.Checked = true;
            cbIsCDAChecked.Checked = true;
            tbOPName.Text = string.Empty;
        }

        /// <summary>
        /// Select case and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectCase(object sender, EventArgs e)
        {
            if (dgvCases.CurrentCell == null)
            {
                return;
            }

            var selectedCase = (Case)_bs.List[dgvCases.CurrentCell.RowIndex];
            Selected = selectedCase;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.CASE_UPDATE))
            {
                menuItemCaseNew.Enabled = true;
                menuItemCaseDelete.Enabled = true;
                menuItemCreditCoverNegNew.Enabled = true;
            }
            else
            {
                menuItemCaseNew.Enabled = false;
                menuItemCaseDelete.Enabled = false;
                menuItemCreditCoverNegNew.Enabled = false;
            }

            if (PermUtil.ValidatePermission(Permissions.INVOICE_REPORT))
            {
                menuItemCaseExport.Enabled = true;
                menuItemLegerReport.Enabled = true;
            }
            else
            {
                menuItemCaseExport.Enabled = false;
                menuItemLegerReport.Enabled = false;
            }

            menuItemCaculateInvoices.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE);
        }




        #region OpCaseType enum

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

        #endregion
    }
}