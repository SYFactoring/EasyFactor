//-----------------------------------------------------------------------
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

            ControlUtil.SetDoubleBuffered(this.dgvCases);
            this.dgvCases.DataSource = this.bs;

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

        #region Methods (7)

        // Private Methods (7) 

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
            if (this.dgvCases.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvCases["CaseCodeColumn", dgvCases.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Case selectedCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == cid);
                if (selectedCase != null)
                {
                    if (MessageBox.Show("是否打算删除案件: " + selectedCase.CaseCode, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        App.Current.DbContext.Cases.DeleteOnSubmit(selectedCase);
                        try
                        {
                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("不能删除此案件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        dgvCases.Rows.RemoveAt(dgvCases.SelectedRows[0].Index);
                    }
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
            if (this.dgvCases.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvCases["CaseCodeColumn", dgvCases.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Case selectedCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == cid);
                if (selectedCase != null)
                {
                    CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.DETAIL_CASE);
                    caseDetail.ShowDialog(this);
                }
            }
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

            DateTime beginDate = this.diBegin.MinDate;
            if (this.diBegin.Value > this.diBegin.MinDate)
            {
                beginDate = this.diBegin.Value;
            }

            DateTime endDate = this.diEnd.MaxDate;
            if (this.diEnd.Value > this.diEnd.MinDate && this.diEnd.Value < this.diEnd.MaxDate)
            {
                endDate = this.diEnd.Value;
            }

            var queryResult = App.Current.DbContext.Cases.Where(c =>
                                   ((string)this.cbOwnerDepts.SelectedValue == "CN01300" ? true : c.OwnerDepartmentCode.Equals((string)this.cbOwnerDepts.SelectedValue))
                                && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType.Equals(this.cbTransactionType.Text))
                                && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency.Equals((string)this.cbCurrency.SelectedValue))
                                && (c.CaseAppDate > beginDate.AddDays(-1))
                                && (c.CaseAppDate < endDate.AddDays(1))
                                && c.CaseCode.Contains(this.tbCaseCode.Text)
                                && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN_1.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN_2.Contains(this.tbClientName.Text)
                                 || c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN_1.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN_2.Contains(this.tbClientName.Text))
                                    );

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select case and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvCases["CaseCodeColumn", dgvCases.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Case selectedCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == cid);
                if (selectedCase != null)
                {
                    this.Selected = selectedCase;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Update selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvCases["CaseCodeColumn", dgvCases.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Case selectedCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == cid);
                if (selectedCase != null)
                {
                    CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.UPDATE_CASE);
                    caseDetail.ShowDialog(this);
                }
            }
        }

        #endregion Methods
    }
}
