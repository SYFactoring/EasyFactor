//-----------------------------------------------------------------------
// <copyright file="ClientReviewMgr.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ClientReviewMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        /// <summary>
        /// 
        /// </summary>
        private OpClientReviewMgrType opType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpClientReviewMgrType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the ClientCreditLineMgr class.
        /// </summary>
        /// <param name="opType"></param>
        public ClientReviewMgr(OpClientReviewMgrType opType)
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.opType = opType;
            this.dgvClientReviews.DataSource = this.bs;
            this.dgvClientReviews.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvClientReviews);
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
        /// Gets or sets selected ClientReview
        /// </summary>
        public ClientReview Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (6)

        // Private Methods (6) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailClientReview(sender, e);
            }
            else
            {
                this.SelectClientReview(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailClientReview(object sender, EventArgs e)
        {
            if (this.dgvClientReviews.CurrentCell == null)
            {
                return;
            }

            ClientReview review = (ClientReview)this.bs.List[this.dgvClientReviews.CurrentCell.RowIndex];
            ClientDetail detail = new ClientDetail(review, ClientDetail.OpReviewType.DETAIL_REVIEW);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientCreditLines_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvClientReviews.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvClientReviews.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvClientReviews.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            string clientEDICode = this.tbClientEDICode.Text;
            string clientName = this.tbClientName.Text;

            DBDataContext context = new DBDataContext();

            var queryResult = context.ClientReviews.Where(c =>
                c.Client.ClientEDICode.Contains(clientEDICode)
             && (c.Client.ClientNameCN.Contains(clientName) || c.Client.ClientNameEN.Contains(clientName)));

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClientReview(object sender, EventArgs e)
        {
            if (this.dgvClientReviews.CurrentCell == null)
            {
                return;
            }

            ClientReview review = (ClientReview)this.bs.List[this.dgvClientReviews.CurrentCell.RowIndex];
            this.Selected = review;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        #endregion Methods
    }
}
