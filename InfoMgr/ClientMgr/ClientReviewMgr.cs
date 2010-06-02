//-----------------------------------------------------------------------
// <copyright file="ClientReviewMgr.cs" company="CISL@Fudan">
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
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientReviewMgr : UserControl
    {
        #region OpClientReviewMgrType enum

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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private OpClientReviewMgrType _opType;


        /// <summary>
        /// Initializes a new instance of the ClientCreditLineMgr class.
        /// </summary>
        /// <param name="opType"></param>
        public ClientReviewMgr(OpClientReviewMgrType opType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            _opType = opType;
            dgvClientReviews.DataSource = _bs;
            dgvClientReviews.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvClientReviews);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            List<string> domainList = Department.AllDomains;
            domainList.Insert(0, "ȫ��");
            cbDomains.DataSource = domainList;
        }


        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected ClientReview
        /// </summary>
        public ClientReview Selected { get; set; }


        //?Private?Methods?(8)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailClientReview(sender, e);
            }
            else
            {
                SelectClientReview(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteClientReview(object sender, EventArgs e)
        {
            if (dgvClientReviews.CurrentCell == null)
            {
                return;
            }

            var review = (ClientReview) _bs.List[dgvClientReviews.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("�Ƿ����ɾ��Э�����: " + review.ReviewNo, MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Context.ClientReviews.DeleteOnSubmit(review);
                try
                {
                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show("ɾ��ʧ��," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                dgvClientReviews.Rows.RemoveAt(dgvClientReviews.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailClientReview(object sender, EventArgs e)
        {
            if (dgvClientReviews.CurrentCell == null)
            {
                return;
            }

            var review = (ClientReview) _bs.List[dgvClientReviews.CurrentCell.RowIndex];
            var detail = new ClientDetail(review, ClientDetail.OpReviewType.DETAIL_REVIEW);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvClientCreditLinesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvClientReviews.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                  dgvClientReviews.RowHeadersDefaultCellStyle.Font, rectangle,
                                  dgvClientReviews.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportClientReviews(object sender, EventArgs e)
        {
            if (dgvClientReviews.SelectedCells.Count == 0)
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_CLIENT_REVIEWS, GetSelectedReviews());
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<ClientReview> GetSelectedReviews()
        {
            var selectedReviews = new List<ClientReview>();
            foreach (DataGridViewCell cell in dgvClientReviews.SelectedCells)
            {
                var review = (ClientReview) _bs.List[cell.RowIndex];
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
            string clientReviewNo = tbClientReviewNo.Text;
            string clientName = tbClientName.Text;
            string location = cbLocation.Text;
            if (location == "ȫ��")
            {
                location = string.Empty;
            }
            string domain = cbDomains.Text;
            if (domain == "ȫ��")
            {
                domain = string.Empty;
            }

            DateTime beginDate = String.IsNullOrEmpty(diBegin.Text) ? diBegin.MinDate : diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(diEnd.Text) ? diEnd.MinDate : diEnd.Value;

            Context = new DBDataContext();

            IQueryable<ClientReview> queryResult = Context.ClientReviews.Where(c =>
                                                                               c.ReviewNo.Contains(clientReviewNo)
                                                                               &&
                                                                               (c.Client.BranchCode == null
                                                                                    ? string.Empty
                                                                                    : c.Client.Department.Location.
                                                                                          LocationName).Contains(
                                                                                              location)
                                                                               &&
                                                                               (c.Client.BranchCode == null
                                                                                    ? string.Empty
                                                                                    : c.Client.Department.Domain).
                                                                                   Contains(domain)
                                                                               &&
                                                                               (beginDate != diBegin.MinDate
                                                                                    ? c.ReviewDate >= beginDate
                                                                                    : true)
                                                                               &&
                                                                               (endDate != diEnd.MinDate
                                                                                    ? c.ReviewDate <= endDate
                                                                                    : true)
                                                                               &&
                                                                               (c.Client.ClientNameCN.Contains(
                                                                                   clientName) ||
                                                                                c.Client.ClientNameEN.Contains(
                                                                                    clientName)));

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectClientReview(object sender, EventArgs e)
        {
            if (dgvClientReviews.CurrentCell == null)
            {
                return;
            }

            var review = (ClientReview) _bs.List[dgvClientReviews.CurrentCell.RowIndex];
            Selected = review;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }
    }
}