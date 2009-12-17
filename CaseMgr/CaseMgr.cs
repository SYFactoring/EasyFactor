
namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.DB.dbml;
    using System.Data.SqlClient;
    using DevComponents.DotNetBar.Controls;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();

        /// <summary>
        /// Initializes a new instance of the CaseQuery class.
        /// </summary>
        public CaseMgr(bool isEditable)
        {
            InitializeComponent();
            ControlUtil.SetDoubleBuffered(this.dgvCases);

            List<Department> departmentList = App.Current.DbContext.Departments.ToList();
            departmentList.Insert(0, Department.DefaultDepartment());
            this.cbOwnerDepts.DataSource = departmentList;
            this.cbOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbOwnerDepts.ValueMember = "DepartmentCode";
            this.cbOwnerDepts.GroupingMembers = "Domain";

            List<Currency> currencyList = App.Current.DbContext.Currencies.ToList();
            currencyList.Insert(0, Currency.DefaultCurrency());
            this.cbCurrency.DataSource = currencyList;
            this.cbCurrency.DisplayMember = "CurrencyFormat";
            this.cbCurrency.ValueMember = "CurrencyCode";
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            string ownerDept = string.Empty;
            if (this.cbOwnerDepts.SelectedIndex >= 0)
            {
                ownerDept = cbOwnerDepts.SelectedValue.ToString();
                if (ownerDept == "CN01300")
                {
                    ownerDept = string.Empty;
                }
            }

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

            //var queryResult = App.Current.DbContext.Cases.Where(c =>
            //                    c.OwnerDepartmentCode.Equals(ownerDept)
            //                  && c.TransactionType.Equals(this.cbTransactionType.Text)
            //                  && c.InvoiceCurrency.Equals((string)this.cbCurrency.SelectedValue)
            //                  && (beginDate == this.diBegin.MinDate ? true : c.CaseAppDate > beginDate.AddDays(-1))
            //                  && (endDate == this.diEnd.MaxDate ? true : c.CaseAppDate < endDate.AddDays(1))
            //                  && c.CaseCode.Contains(this.tbCaseCode.Text)
            //                  && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text)||c.BuyerClient.ClientNameEN_1.Contains(this.tbClientName.Text)||c.BuyerClient.ClientNameEN_2.Contains(this.tbClientName.Text)
            //                    ||c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text)||c.SellerClient.ClientNameEN_1.Contains(this.tbClientName.Text)||c.SellerClient.ClientNameEN_2.Contains(this.tbClientName.Text))
            //                  );

            var queryResult = App.Current.DbContext.Cases;
            this.bs.DataSource = queryResult;
            this.dgvCases.DataSource = this.bs;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
    }
}
