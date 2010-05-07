//-----------------------------------------------------------------------
// <copyright file="CreditCoverNegMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;

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
            this.ImeMode = ImeMode.OnHalf;
            this.dgvCreditCoverNegs.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvCreditCoverNegs.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvCreditCoverNegs);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.cbTransactionType.Items.Insert(0, "全部");
            this.cbTransactionType.Text = "全部";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location() { LocationCode = "00", LocationName = "全部" });
            this.cbLocation.DataSource = allLocations;
            this.cbLocation.DisplayMember = "LocationName";
            this.cbLocation.ValueMember = "LocationCode";
            this.cbLocation.SelectedIndex = 0;

            List<Currency> currencyList = Currency.AllCurrencies;
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
        /// <returns></returns>
        private List<CreditCoverNegotiation> GetSelectedCreditCoverNegs()
        {
            List<CreditCoverNegotiation> selectedCreditCoverNegs = new List<CreditCoverNegotiation>();
            foreach (DataGridViewCell cell in this.dgvCreditCoverNegs.SelectedCells)
            {
                CreditCoverNegotiation creditCoverNeg = (CreditCoverNegotiation)this.bs.List[cell.RowIndex];
                if (!selectedCreditCoverNegs.Contains(creditCoverNeg))
                {
                    selectedCreditCoverNegs.Add(creditCoverNeg);
                }
            }

            return selectedCreditCoverNegs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportCreditCoverNeg(object sender, EventArgs e)
        {
            if (this.dgvCreditCoverNegs.SelectedCells.Count == 0)
            {
                return;
            }

            ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_CREDIT_COVER_NEG, GetSelectedCreditCoverNegs());
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            DateTime beginDate = String.IsNullOrEmpty(this.diBegin.Text) ? this.diBegin.MinDate : this.diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(this.diEnd.Text) ? this.diEnd.MinDate : this.diEnd.Value;
            string sellerFactorCode = this.tbSellerFactorCode.Text;
            string buyerFactorCode = this.tbBuyerFactorCode.Text;
            string createUserName = this.tbCreateUserName.Text;
            string location = this.cbLocation.Text;

            DBDataContext context = new DBDataContext();

            var queryResult = from neg in context.CreditCoverNegotiations
                              let c = neg.Case
                              where
                               (location == "全部" ? true : c.OwnerDepartment.LocationCode == location)
                               && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType == (this.cbTransactionType.Text))
                               && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency == (string)this.cbCurrency.SelectedValue)
                               && (beginDate != this.diBegin.MinDate ? c.CaseAppDate >= beginDate : true)
                               && (endDate != this.diEnd.MinDate ? c.CaseAppDate <= endDate : true)
                               && c.CaseCode.Contains(this.tbCaseCode.Text)
                               && (this.cbIsCDA.Checked == false ? true : c.CDAs.Any(cda => cda.CDAStatus == CDAStr.CHECKED))
                               && (this.cbIsContractSigned.Checked == false ? true : c.SellerClient.Contracts.Any(con => con.ContractStatus == CONTRACT.AVAILABILITY))
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
