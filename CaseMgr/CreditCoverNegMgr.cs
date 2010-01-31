//-----------------------------------------------------------------------
// <copyright file="CreditCoverNegMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Collections.Generic;
    using System.Drawing;

    public partial class CreditCoverNegMgr : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public CreditCoverNegMgr()
        {
            InitializeComponent();
            this.dgvCreditCoverNegs.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvCreditCoverNegs.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvCreditCoverNegs);

            this.cbTransactionType.Items.Insert(0, "全部");
            this.cbTransactionType.Text = "全部";

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
        /// Gets or sets selected Client
        /// </summary>
        public CreditCoverNegotiation Selected
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
                this.DetailCreditCoverNeg(sender, e);
            }
            else
            {
                this.SelectCreditCoverNeg(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCreditCoverNeg(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCreditCoverNegs.CurrentCell == null)
            {
                return;
            }

            CreditCoverNegotiation selectedCreditCoverNeg = (CreditCoverNegotiation)this.bs.List[this.dgvCreditCoverNegs.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCreditCoverNeg, CaseDetail.OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditCoverNegs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvCreditCoverNegs.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvCreditCoverNegs.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvCreditCoverNegs.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            DateTime beginDate = this.diBegin.Text != string.Empty ? this.diBegin.Value : this.diBegin.MinDate;
            DateTime endDate = this.diEnd.Text != string.Empty ? this.diEnd.Value : this.diEnd.MinDate;
            string sellerFactorCode = this.tbSellerFactorCode.Text;
            string buyerFactorCode = this.tbBuyerFactorCode.Text;
            string createUserName = this.tbCreateUserName.Text;

            var queryResult = from neg in App.Current.DbContext.CreditCoverNegotiations
                              let c = neg.Case
                              where
                               ((string)this.cbOwnerDepts.SelectedValue == "CN01300" ? true : c.OwnerDepartmentCode.Equals((string)this.cbOwnerDepts.SelectedValue))
                               && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType.Equals(this.cbTransactionType.Text))
                               && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency.Equals((string)this.cbCurrency.SelectedValue))
                               && (beginDate != this.diBegin.MinDate ? c.CaseAppDate >= beginDate : true)
                               && (endDate != this.diEnd.MinDate ? c.CaseAppDate <= endDate : true)
                               && c.CaseCode.Contains(this.tbCaseCode.Text)
                               && (this.cbIsCDA.Checked == false ? true : c.CDAs.Any(cda => cda.CDAStatus == ConstStr.CDA.SIGNED))
                               && (this.cbIsContractSigned.Checked == false ? true : c.SellerClient.Contracts.Any(con => con.ContractStatus == ConstStr.CONTRACT.AVAILABILITY))
                               && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN.Contains(this.tbClientName.Text)
                                || c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN.Contains(this.tbClientName.Text)
                               && neg.Case.SellerFactorCode.Contains(sellerFactorCode) && neg.Case.BuyerFactorCode.Contains(buyerFactorCode))
                               && neg.CreateUserName.Contains(createUserName)
                              select neg;

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
            this.tbBuyerFactorCode.Text = string.Empty;
            this.tbSellerFactorCode.Text = string.Empty;
            this.tbCreateUserName.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCreditCoverNeg(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCreditCoverNegs.CurrentCell == null)
            {
                return;
            }

            CreditCoverNegotiation selectedCreditCoverNeg = (CreditCoverNegotiation)this.bs.List[this.dgvCreditCoverNegs.CurrentCell.RowIndex];
            this.Selected = selectedCreditCoverNeg;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }

        }

        #endregion Methods
    }
}
