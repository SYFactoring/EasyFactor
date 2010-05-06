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
    using DevComponents.DotNetBar;
    using System.Collections.Generic;

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

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the ClientCreditLineMgr class.
        /// </summary>
        /// <param name="opType"></param>
        public ClientReviewMgr(OpClientReviewMgrType opType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.bs = new BindingSource();
            this.opType = opType;
            this.dgvClientReviews.DataSource = this.bs;
            this.dgvClientReviews.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvClientReviews);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            List<string> domainList = Department.AllDomains();
            domainList.Insert(0, "全部");
            this.cbDomains.DataSource = domainList;
        }

        #endregion Constructors

        #region Properties (3)

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
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
        /// Gets or sets selected ClientReview
        /// </summary>
        public ClientReview Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (9)

        // Private Methods (9) 

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
        private void DeleteClientReview(object sender, EventArgs e)
        {
            if (this.dgvClientReviews.CurrentCell == null)
            {
                return;
            }

            ClientReview review = (ClientReview)this.bs.List[this.dgvClientReviews.CurrentCell.RowIndex];
            if (MessageBoxEx.Show("是否打算删除协查意见: " + review.ReviewNo, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                context.ClientReviews.DeleteOnSubmit(review);
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.dgvClientReviews.Rows.RemoveAt(dgvClientReviews.CurrentCell.RowIndex);
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
        private void ExportClientReviews(object sender, EventArgs e)
        {
            if (this.dgvClientReviews.SelectedCells.Count == 0)
            {
                return;
            }

            ExportForm exportForm = new ExportForm(ExportForm.ExportType.EXPORT_CLIENT_REVIEWS, GetSelectedReviews());
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<ClientReview> GetSelectedReviews()
        {
            List<ClientReview> selectedReviews = new List<ClientReview>();
            foreach (DataGridViewCell cell in this.dgvClientReviews.SelectedCells)
            {
                ClientReview review = (ClientReview)this.bs.List[cell.RowIndex];
                if (!selectedReviews.Contains(review))
                {
                    selectedReviews.Add(review);
                }
            }

            return selectedReviews;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            string clientReviewNo = this.tbClientReviewNo.Text;
            string clientName = this.tbClientName.Text;
            string location = this.cbLocation.Text;
            if (location == "全部")
            {
                location = string.Empty;
            }
            string domain = this.cbDomains.Text;
            if (domain == "全部")
            {
                domain = string.Empty;
            }

            DateTime beginDate = String.IsNullOrEmpty(this.diBegin.Text) ? this.diBegin.MinDate : this.diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(this.diEnd.Text) ? this.diEnd.MinDate : this.diEnd.Value;

            context = new DBDataContext();

            var queryResult = context.ClientReviews.Where(c =>
                c.ReviewNo.Contains(clientReviewNo)
             && (c.Client.BranchCode == null ? string.Empty : c.Client.Department.Location.LocationName).Contains(location)
             && (c.Client.BranchCode == null ? string.Empty : c.Client.Department.Domain).Contains(domain)
             && (beginDate != this.diBegin.MinDate ? c.ReviewDate >= beginDate : true)
             && (endDate != this.diEnd.MinDate ? c.ReviewDate <= endDate : true)
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
