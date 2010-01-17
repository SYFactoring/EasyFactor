﻿//-----------------------------------------------------------------------
// <copyright file="CaseMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar.Controls;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseMgr : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the CaseQuery class.
        /// </summary>
        public CaseMgr(bool isEditable)
        {
            InitializeComponent();
            this.dgvCases.AutoGenerateColumns = false;
            this.dgvCases.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvCases);

            List<string> transTypes = Case.ConstantTransTypes().ToList();
            transTypes.Insert(0, "全部");
            this.cbTransactionType.DataSource = transTypes;

            List<Department> deptsList = Department.AllDepartments().ToList();
            deptsList.Insert(0, new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" });
            this.cbOwnerDepts.DataSource = deptsList;
            this.cbOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbOwnerDepts.ValueMember = "DepartmentCode";
            this.cbOwnerDepts.GroupingMembers = "Domain";

            List<Currency> currencyList = Currency.AllCurrencies().ToList();
            currencyList.Insert(0, new Currency() { CurrencyCode = "AAA", CurrencyName = "All" });
            this.cbCurrency.DataSource = currencyList;
            this.cbCurrency.DisplayMember = "CurrencyFormat";
            this.cbCurrency.ValueMember = "CurrencyCode";
        }

        #endregion Constructors

        #region Properties (2)

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

        #region Methods (9)

        // Private Methods (9) 

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
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            if (MessageBox.Show("此案件是" + selectedCase.CaseMark + "，是否确定删除", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bool isDeleteOK = true;
                foreach (CDA cda in selectedCase.CDAs)
                {
                    foreach (InvoiceAssignBatch assignBatch in cda.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in assignBatch.Invoices)
                        {
                            App.Current.DbContext.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                            App.Current.DbContext.InvoiceRefundLogs.DeleteAllOnSubmit(invoice.InvoiceRefundLogs);
                        }
                        App.Current.DbContext.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                    }
                    App.Current.DbContext.InvoiceAssignBatches.DeleteAllOnSubmit(cda.InvoiceAssignBatches);
                    App.Current.DbContext.InvoiceFinanceBatches.DeleteAllOnSubmit(cda.InvoiceFinanceBatches);
                    App.Current.DbContext.InvoicePaymentBatches.DeleteAllOnSubmit(cda.InvoicePaymentBatches);
                    App.Current.DbContext.InvoiceRefundBatches.DeleteAllOnSubmit(cda.InvoiceRefundBatches);
                }
                App.Current.DbContext.CDAs.DeleteAllOnSubmit(selectedCase.CDAs);
                App.Current.DbContext.Cases.DeleteOnSubmit(selectedCase);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isDeleteOK = false;
                    MessageBox.Show("不能删除此案件: " + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isDeleteOK)
                {
                    MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                 e.RowBounds.Location.Y,
                 this.dgvCases.RowHeadersWidth - 4,
                 e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvCases.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvCases.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewCase(object sender, System.EventArgs e)
        {
            CaseDetail caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
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

            var queryResult = App.Current.DbContext.Cases.Where(c =>
                                   ((string)this.cbOwnerDepts.SelectedValue == "CN01300" ? true : c.OwnerDepartmentCode.Equals((string)this.cbOwnerDepts.SelectedValue))
                                && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType.Equals(this.cbTransactionType.Text))
                                && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency.Equals((string)this.cbCurrency.SelectedValue))
                                && (beginDate != this.diBegin.MinDate ? c.CaseAppDate >= beginDate : true)
                                && (endDate != this.diEnd.MinDate ? c.CaseAppDate <= endDate : true)
                                && c.CaseCode.Contains(this.tbCaseCode.Text)
                                && (this.cbIsCDA.Checked == false ? true : c.CDAs.Any(cda => cda.CDAStatus == "已签回"))
                                && (this.cbIsContractSigned.Checked == false ? true : c.SellerClient.Contracts.Any(con => con.ContractStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY))
                                && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN_1.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN_2.Contains(this.tbClientName.Text)
                                 || c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN_1.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN_2.Contains(this.tbClientName.Text))
                                    );

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
        /// Update selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.UPDATE_CASE);
            caseDetail.ShowDialog(this);
        }

        #endregion Methods
    }
}
