
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
            this.UpdateEditableStatus();
            this.dgvCreditCoverNegs.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvCreditCoverNegs);
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
            var queryResutl = App.Current.DbContext.CreditCoverNegotiations;
            this.bs.DataSource = queryResutl;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResutl.Count());
        }

        private void SelectCreditCoverNeg(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCreditCoverNegs.SelectedRows.Count == 0)
            {
                return;
            }

            int cid = (int)dgvCreditCoverNegs["colNegoID", dgvCreditCoverNegs.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                CreditCoverNegotiation selectedCreditCoverNeg = App.Current.DbContext.CreditCoverNegotiations.SingleOrDefault(c => c.NegoID == cid);
                if (selectedCreditCoverNeg != null)
                {
                    this.Selected = selectedCreditCoverNeg;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }

        private void DetailCreditCoverNeg(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCreditCoverNegs.SelectedRows.Count == 0)
            {
                return;
            }

            int cid = (int)dgvCreditCoverNegs["colNegoID", dgvCreditCoverNegs.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                CreditCoverNegotiation selectedCreditCoverNeg = App.Current.DbContext.CreditCoverNegotiations.SingleOrDefault(c => c.NegoID == cid);
                if (selectedCreditCoverNeg != null)
                {
                    CaseDetail caseDetail = new CaseDetail(selectedCreditCoverNeg.Case, CaseDetail.OpCreditCoverNegType.DETAIL_CREDIT_COVER_NEG);
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
                this.DetailCreditCoverNeg(sender, e);
            }
            else
            {
                this.SelectCreditCoverNeg(sender, e);
            }
        }
    }
}
