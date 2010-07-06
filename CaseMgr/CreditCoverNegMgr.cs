//-----------------------------------------------------------------------
// <copyright file="CreditCoverNegMgr.cs" company="Yiming Liu@Fudan">
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

namespace CMBC.EasyFactor.CaseMgr
{
    public partial class CreditCoverNegMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;


        /// <summary>
        /// 
        /// </summary>
        public CreditCoverNegMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvCreditCoverNegs.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvCreditCoverNegs.DataSource = _bs;
            ControlUtil.SetDoubleBuffered(dgvCreditCoverNegs);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            cbTransactionType.Items.Insert(0, "全部");
            cbTransactionType.Text = @"全部";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "全部" });
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            List<Currency> currencyList = Currency.AllCurrencies;
            currencyList.Insert(0, new Currency { CurrencyCode = "AAA", CurrencyName = "All" });
            cbCurrency.DataSource = currencyList;
            cbCurrency.DisplayMember = "CurrencyFormat";
            cbCurrency.ValueMember = "CurrencyCode";

            UpdateContextMenu();
        }


        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected Client
        /// </summary>
        public CreditCoverNegotiation Selected { get; set; }


        //?Private?Methods?(8)?
        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailCreditCoverNeg(sender, e);
            }
            else
            {
                SelectCreditCoverNeg(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCreditCoverNeg(object sender, EventArgs e)
        {
            if (dgvCreditCoverNegs.CurrentCell == null)
            {
                return;
            }

            var selectedCreditCoverNeg = (CreditCoverNegotiation)_bs.List[dgvCreditCoverNegs.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedCreditCoverNeg,
                                            CaseDetail.OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCreditCoverNegsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvCreditCoverNegs.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                  dgvCreditCoverNegs.RowHeadersDefaultCellStyle.Font, rectangle,
                                  dgvCreditCoverNegs.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportCreditCoverNeg(object sender, EventArgs e)
        {
            if (dgvCreditCoverNegs.SelectedCells.Count == 0)
            {
                return;
            }

            var form = new ExportForm(ExportForm.ExportType.EXPORT_CREDIT_COVER_NEG, GetSelectedCreditCoverNegs());
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<CreditCoverNegotiation> GetSelectedCreditCoverNegs()
        {
            var selectedCreditCoverNegs = new List<CreditCoverNegotiation>();
            foreach (DataGridViewCell cell in dgvCreditCoverNegs.SelectedCells)
            {
                var creditCoverNeg = (CreditCoverNegotiation)_bs.List[cell.RowIndex];
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
        private void Query(object sender, EventArgs e)
        {
            DateTime beginDate = String.IsNullOrEmpty(diBegin.Text) ? diBegin.MinDate : diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(diEnd.Text) ? diEnd.MinDate : diEnd.Value;
            string sellerFactorCode = tbSellerFactorCode.Text;
            string buyerFactorCode = tbBuyerFactorCode.Text;
            string createUserName = tbCreateUserName.Text;
            string location = cbLocation.Text;
            string requestType = cbRequestType.Text;

            var context = new DBDataContext();

            IQueryable<CreditCoverNegotiation> queryResult = from neg in context.CreditCoverNegotiations
                                                             where
                                                                 (beginDate != diBegin.MinDate
                                                                      ? neg.RequestDate >= beginDate
                                                                      : true)
                                                                 &&
                                                                 (endDate != diEnd.MinDate
                                                                      ? neg.RequestDate <= endDate
                                                                      : true)
                                                                 &&
                                                                 (requestType != "" ? neg.RequestType == requestType : true)
                                                             let c = neg.Case
                                                             where
                                                                 (location == "全部"
                                                                      ? true
                                                                      : c.OwnerDepartment.LocationCode == location)
                                                                 &&
                                                                 (cbTransactionType.Text == @"全部"
                                                                      ? true
                                                                      : c.TransactionType == (cbTransactionType.Text))
                                                                 &&
                                                                 ((string)cbCurrency.SelectedValue == "AAA"
                                                                      ? true
                                                                      : c.InvoiceCurrency ==
                                                                        (string)cbCurrency.SelectedValue)
                                                                 && c.CaseCode.Contains(tbCaseCode.Text)
                                                                 &&
                                                                 (cbIsCDA.Checked == false
                                                                      ? true
                                                                      : c.CDAs.Any(
                                                                          cda => cda.CDAStatus == CDAStr.CHECKED))
                                                                 &&
                                                                 (cbIsContractSigned.Checked == false
                                                                      ? true
                                                                      : c.SellerClient.Contracts.Any(
                                                                          con =>
                                                                          con.ContractStatus == CONTRACT.AVAILABILITY))
                                                                 &&
                                                                 (c.BuyerClient.ClientNameCN.Contains(tbClientName.Text) ||
                                                                  c.BuyerClient.ClientNameEN.Contains(tbClientName.Text)
                                                                  ||
                                                                  c.SellerClient.ClientNameCN.Contains(tbClientName.Text) ||
                                                                  c.SellerClient.ClientNameEN.Contains(tbClientName.Text)
                                                                  &&
                                                                  neg.Case.SellerFactorCode.Contains(sellerFactorCode) &&
                                                                  neg.Case.BuyerFactorCode.Contains(buyerFactorCode))
                                                                 && neg.CreateUserName.Contains(createUserName)
                                                             select neg;

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            cbTransactionType.SelectedIndex = 0;
            cbCurrency.SelectedIndex = 0;
            tbCaseCode.Text = string.Empty;
            tbClientName.Text = string.Empty;
            diBegin.Value = default(DateTime);
            diEnd.Value = default(DateTime);
            cbIsContractSigned.Checked = true;
            cbIsCDA.Checked = true;
            tbBuyerFactorCode.Text = string.Empty;
            tbSellerFactorCode.Text = string.Empty;
            tbCreateUserName.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCreditCoverNeg(object sender, EventArgs e)
        {
            if (dgvCreditCoverNegs.CurrentCell == null)
            {
                return;
            }

            var selectedCreditCoverNeg = (CreditCoverNegotiation)_bs.List[dgvCreditCoverNegs.CurrentCell.RowIndex];
            Selected = selectedCreditCoverNeg;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateContextMenu()
        {
            menuItemCreditCoverNegExport.Enabled = PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE);
        }
    }
}