//-----------------------------------------------------------------------
// <copyright file="RefundBatchMgr.cs" company="Yiming Liu@Fudan">
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

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RefundBatchMgr : UserControl
    {
        #region OpBatchType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpBatchType
        {
            /// <summary>
            /// 
            /// </summary>
            DETAIL,

            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            POOL_QUERY,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private readonly OpBatchType _opBatchType;

        /// <summary>
        /// 
        /// </summary>
        private Case _case;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <param name="context"></param>
        public RefundBatchMgr(Case selectedCase, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            _case = selectedCase;
            panelQuery.Visible = false;
            _bs.DataSource = selectedCase.InvoiceRefundBatches;
            Context = context;
        }

        public RefundBatchMgr(String username, String checkStatus)
        {
            if(username == null)
            {
                Context = new DBDataContext();
                IQueryable<InvoiceRefundBatch> queryResult = from batch in Context.InvoiceRefundBatches
                                              where
                                                  batch.CheckStatus == checkStatus
                                              select batch;

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
            else
            {
                Context = new DBDataContext();
                IQueryable<InvoiceRefundBatch> queryResult = from batch in Context.InvoiceRefundBatches
                                                             where
                                                                 batch.CheckStatus == BATCH.UNCHECK && batch.CreateUserName == username
                                                             select batch;

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchType"></param>
        public RefundBatchMgr(OpBatchType batchType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvBatches.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvBatches.DataSource = _bs;
            _opBatchType = batchType;
            ControlUtil.SetDoubleBuffered(dgvBatches);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location {LocationCode = "00", LocationName = "全部"});
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            UpdateContextMenu();

            if (batchType == OpBatchType.POOL_QUERY)
            {
                colBuyerName.Visible = false;
                colBatchCount.Visible = false;
                colTransactionType.Visible = false;
            }
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
        /// Gets or sets selected RefundBatch
        /// </summary>
        public InvoiceRefundBatch Selected { get; set; }

        //?Private?Methods?(9)?
        private void Check(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_CHECK))
            {
                return;
            }
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }
            
            InvoiceRefundBatch batch = (InvoiceRefundBatch)_bs.List[this.dgvBatches.CurrentCell.RowIndex];
            if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(Permissions.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("是否确认复核通过该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("经办人和复核人相同，不可进行复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            batch.CheckStatus = BATCH.CHECK;
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            List<InvoiceRefundBatch> batches = GetSelectedBatches();
            if (
                MessageBoxEx.Show("是否打算删除此" + batches.Count() + "条还款批次记录", MESSAGE.TITLE_INFORMATION,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                foreach (InvoiceRefundBatch selectedBatch in batches)
                {
                    foreach (InvoiceRefundLog log in selectedBatch.InvoiceRefundLogs)
                    {
                        InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                        log.InvoiceFinanceLog = null;
                        financeLog.Invoice.CaculateRefund();
                        Context.InvoiceRefundLogs.DeleteOnSubmit(log);
                    }

                    _bs.Remove(selectedBatch);
                }

                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBatch(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            var selectedBatch = (InvoiceRefundBatch) _bs.List[dgvBatches.CurrentCell.RowIndex];
            var detail = new RefundBatchDetail(selectedBatch);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBatchesCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailBatch(sender, e);
            }
            else
            {
                SelectBatch(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBatchesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvBatches.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvBatches.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvBatches.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            DateTime beginBatchDate = String.IsNullOrEmpty(dateBatchFrom.Text)
                                          ? dateBatchFrom.MinDate
                                          : dateBatchFrom.Value.Date;
            DateTime endBatchDate = String.IsNullOrEmpty(dateBatchTo.Text)
                                        ? dateBatchTo.MinDate
                                        : dateBatchTo.Value.Date;
            DateTime beginInputDate = String.IsNullOrEmpty(dateInputFrom.Text)
                                          ? dateInputFrom.MinDate
                                          : dateInputFrom.Value.Date;
            DateTime endInputDate = String.IsNullOrEmpty(dateInputTo.Text)
                                        ? dateInputTo.MinDate
                                        : dateInputTo.Value.Date;
            string createUserName = tbCreateUserName.Text;
            string clientName = tbClientName.Text;
            var location = (string) cbLocation.SelectedValue;
            string transactionType = cbTransactionType.Text;
            if (String.IsNullOrEmpty(transactionType))
            {
                transactionType = "全部";
            }

            string refundType = cbRefundType.Text;
            if (String.IsNullOrEmpty(refundType))
            {
                refundType = "全部";
            }

            Context = new DBDataContext();

            IEnumerable<InvoiceRefundBatch> queryResult;
            if (_opBatchType != OpBatchType.POOL_QUERY)
            {
                queryResult = Context.InvoiceRefundBatches.Where(batch =>
                                                                 batch.RefundBatchNo.Contains(tbRefundBatchNo.Text)
                                                                 && (batch.CaseCode != null)
                                                                 &&
                                                                 (beginBatchDate != dateBatchFrom.MinDate
                                                                      ? batch.RefundDate >= beginBatchDate
                                                                      : true)
                                                                 &&
                                                                 (endBatchDate != dateBatchTo.MinDate
                                                                      ? batch.RefundDate <= endBatchDate
                                                                      : true)
                                                                 &&
                                                                 (beginInputDate != dateInputFrom.MinDate
                                                                      ? batch.InputDate >= beginInputDate
                                                                      : true)
                                                                 &&
                                                                 (endInputDate != dateInputTo.MinDate
                                                                      ? batch.InputDate <= endInputDate
                                                                      : true)
                                                                 //&& (status != string.Empty ? i.CheckStatus == status : true)
                                                                 &&
                                                                 (refundType == "全部"
                                                                      ? true
                                                                      : batch.RefundType == refundType)
                                                                 && (batch.CreateUserName.Contains(createUserName))
                                                                 &&
                                                                 (transactionType == "全部"
                                                                      ? true
                                                                      : batch.Case.TransactionType == transactionType)
                                                                 &&
                                                                 (location == "00"
                                                                      ? true
                                                                      : batch.Case.OwnerDepartment.LocationCode ==
                                                                        location)
                                                                 &&
                                                                 (batch.Case.SellerClient.ClientNameCN.Contains(
                                                                     clientName) ||
                                                                  batch.Case.SellerClient.ClientNameEN.Contains(
                                                                      clientName) ||
                                                                  batch.Case.BuyerClient.ClientNameCN.Contains(
                                                                      clientName) ||
                                                                  batch.Case.BuyerClient.ClientNameEN.Contains(
                                                                      clientName))
                    );
            }
            else
            {
                queryResult = Context.InvoiceRefundBatches.Where(batch =>
                                                                 batch.RefundBatchNo.Contains(tbRefundBatchNo.Text)
                                                                 && (batch.FinanceBatchNo != null)
                                                                 &&
                                                                 (beginBatchDate != dateBatchFrom.MinDate
                                                                      ? batch.RefundDate >= beginBatchDate
                                                                      : true)
                                                                 &&
                                                                 (endBatchDate != dateBatchTo.MinDate
                                                                      ? batch.RefundDate <= endBatchDate
                                                                      : true)
                                                                 &&
                                                                 (beginInputDate != dateInputFrom.MinDate
                                                                      ? batch.InputDate >= beginInputDate
                                                                      : true)
                                                                 &&
                                                                 (endInputDate != dateInputTo.MinDate
                                                                      ? batch.InputDate <= endInputDate
                                                                      : true)
                                                                 //&& (status != string.Empty ? i.CheckStatus == status : true)
                                                                 &&
                                                                 (refundType == "全部"
                                                                      ? true
                                                                      : batch.RefundType == refundType)
                                                                 && (batch.CreateUserName.Contains(createUserName))
                                                                 &&
                                                                 (location == "00"
                                                                      ? true
                                                                      : batch.InvoiceFinanceBatch.Client.Department.
                                                                            LocationCode == location)
                                                                 &&
                                                                 (batch.InvoiceFinanceBatch.Client.ClientNameCN.Contains
                                                                      (
                                                                          clientName) ||
                                                                  batch.InvoiceFinanceBatch.Client.ClientNameEN.Contains
                                                                      (
                                                                          clientName) ||
                                                                  batch.Case.BuyerClient.ClientNameCN.Contains(
                                                                      clientName) ||
                                                                  batch.Case.BuyerClient.ClientNameEN.Contains(
                                                                      clientName))
                    );
            }
            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        private void Reject(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_CHECK))
            {
                return;
            }
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceRefundBatch batch = (InvoiceRefundBatch)_bs.List[this.dgvBatches.CurrentCell.RowIndex];
            if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(Permissions.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("是否确认复核退回该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("经办人和复核人相同，不可进行复核退回", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            batch.CheckStatus = BATCH.REJECT;
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            var selectedBatch = (InvoiceRefundBatch) _bs.List[dgvBatches.CurrentCell.RowIndex];
            Selected = selectedBatch;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<InvoiceRefundBatch> GetSelectedBatches()
        {
            if (dgvBatches.CurrentCell == null)
            {
                return null;
            }

            var selectedBatches = new List<InvoiceRefundBatch>();

            foreach (DataGridViewCell cell in dgvBatches.SelectedCells)
            {
                var batch = (InvoiceRefundBatch) _bs.List[cell.RowIndex];
                if (!selectedBatches.Contains(batch))
                {
                    selectedBatches.Add(batch);
                }
            }

            return selectedBatches;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            menuItemBatchDelete.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE);
        }
    }
}