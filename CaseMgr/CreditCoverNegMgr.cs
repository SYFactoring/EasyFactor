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

            this.UpdateEditableStatus();
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

        #region Methods (1)

        // Private Methods (1) 

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (this.isEditable)
            {
                this.menuItemCreditCoverNew.Enabled = true;
                this.menuItemCreditCoverUpdate.Enabled = true;
                this.menuItemCreditCoverDelete.Enabled = true;
            }
            else
            {
                this.menuItemCreditCoverNew.Enabled = false;
                this.menuItemCreditCoverUpdate.Enabled = false;
                this.menuItemCreditCoverDelete.Enabled = false;
            }
        }

        #endregion Methods

        private void QueryCreditCoverNeg(object sender, EventArgs e)
        {
            string sellerFactorCode = this.tbSellerFactorCode.Text;
            string buyerFactorCode = this.tbBuyerFactorCode.Text;

            var queryResutl = from neg in App.Current.DbContext.CreditCoverNegotiations
                              where neg.Case.SellerFactorCode.Contains(sellerFactorCode) && neg.Case.BuyerFactorCode.Contains(buyerFactorCode)
                              select neg;

            this.bs.DataSource = queryResutl;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResutl.Count());
        }

        private void SelectCreditCoverNeg(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCreditCoverNegs.SelectedRows.Count == 0)
            {
                return;
            }

            CreditCoverNegotiation selectedCreditCoverNeg = (CreditCoverNegotiation)this.bs.List[this.dgvCreditCoverNegs.SelectedRows[0].Index];
            this.Selected = selectedCreditCoverNeg;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }

        }

        private void DetailCreditCoverNeg(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCreditCoverNegs.SelectedRows.Count == 0)
            {
                return;
            }

            CreditCoverNegotiation selectedCreditCoverNeg = (CreditCoverNegotiation)this.bs.List[this.dgvCreditCoverNegs.SelectedRows[0].Index];
            CaseDetail caseDetail = new CaseDetail(selectedCreditCoverNeg, CaseDetail.OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG);
            caseDetail.ShowDialog(this);
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
                this.DetailCreditCoverNeg(sender, e);
            }
            else
            {
                this.SelectCreditCoverNeg(sender, e);
            }
        }
    }
}
