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
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private bool isEditable;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public CreditCoverNegMgr(bool isEditable)
        {
            InitializeComponent();
            this.isEditable = isEditable;
            this.dgvCreditCoverNegs.AutoGenerateColumns = false;
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

        #region Methods (8)

        // Private Methods (8) 

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
        /// Delete selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCase(object sender, System.EventArgs e)
        {
            if (this.dgvCreditCoverNegs.CurrentCell == null)
            {
                return;
            }

            CreditCoverNegotiation selectedCreditCoverNeg = (CreditCoverNegotiation)this.bs.List[this.dgvCreditCoverNegs.CurrentCell.RowIndex];

            Case selectedCase = selectedCreditCoverNeg.Case;
            if (MessageBox.Show("此案件是" + selectedCase.CaseMark + "，是否确定删除", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bool isDeleteOK = true;
                foreach (InvoiceAssignBatch assignBatch in selectedCase.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        App.Current.DbContext.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                        App.Current.DbContext.InvoiceRefundLogs.DeleteAllOnSubmit(invoice.InvoiceRefundLogs);
                    }
                    App.Current.DbContext.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                }

                App.Current.DbContext.InvoiceAssignBatches.DeleteAllOnSubmit(selectedCase.InvoiceAssignBatches);
                App.Current.DbContext.InvoiceFinanceBatches.DeleteAllOnSubmit(selectedCase.InvoiceFinanceBatches);
                App.Current.DbContext.InvoicePaymentBatches.DeleteAllOnSubmit(selectedCase.InvoicePaymentBatches);
                App.Current.DbContext.InvoiceRefundBatches.DeleteAllOnSubmit(selectedCase.InvoiceRefundBatches);

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
                    dgvCreditCoverNegs.Rows.RemoveAt(dgvCreditCoverNegs.CurrentCell.RowIndex);
                }
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
        private void Query(object sender, EventArgs e)
        {
            DateTime beginDate = this.diBegin.Text != string.Empty ? this.diBegin.Value : this.diBegin.MinDate;
            DateTime endDate = this.diEnd.Text != string.Empty ? this.diEnd.Value : this.diEnd.MinDate;
            string sellerFactorCode = this.tbSellerFactorCode.Text;
            string buyerFactorCode = this.tbBuyerFactorCode.Text;

            var queryResult = from neg in App.Current.DbContext.CreditCoverNegotiations
                              let c = neg.Case
                              where
                               ((string)this.cbOwnerDepts.SelectedValue == "CN01300" ? true : c.OwnerDepartmentCode.Equals((string)this.cbOwnerDepts.SelectedValue))
                               && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType.Equals(this.cbTransactionType.Text))
                               && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency.Equals((string)this.cbCurrency.SelectedValue))
                               && (beginDate != this.diBegin.MinDate ? c.CaseAppDate >= beginDate : true)
                               && (endDate != this.diEnd.MinDate ? c.CaseAppDate <= endDate : true)
                               && c.CaseCode.Contains(this.tbCaseCode.Text)
                               && (this.cbIsCDA.Checked == false ? true : c.CDAs.Any(cda => cda.CDAStatus == "已签回"))
                               && (this.cbIsContractSigned.Checked == false ? true : c.SellerClient.Contracts.Any(con => con.ContractStatus == ConstStr.CONTRACT.AVAILABILITY))
                               && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN.Contains(this.tbClientName.Text)
                                || c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN.Contains(this.tbClientName.Text)
                               && neg.Case.SellerFactorCode.Contains(sellerFactorCode) && neg.Case.BuyerFactorCode.Contains(buyerFactorCode))
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

        private void dgvCreditCoverNegs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.dgvCreditCoverNegs.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.dgvCreditCoverNegs.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.dgvCreditCoverNegs.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
