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
        //private void Check(object sender, EventArgs e)
        //{
        //    if (!PermUtil.CheckPermission(Permissions.INVOICE_CHECK))
        //    {
        //        return;
        //    }
        //    if (this.dgvBatches.CurrentCell == null)
        //    {
        //        return;
        //    }
        //    InvoiceRefundBatch batch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
        //    if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(Permissions.INVOICE_APPROVE))
        //    {
        //        MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (MessageBoxEx.Show("是否确认复核通过该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //    {
        //        return;
        //    }
        //    if (App.Current.CurUser.Name == batch.CreateUserName)
        //    {
        //        MessageBoxEx.Show("经办人和复核人相同，不可进行复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    batch.CheckStatus = BATCH.CHECK;
        //    batch.CheckUserName = App.Current.CurUser.Name;
        //    batch.CheckDate = DateTime.Now.Date;
        //    try
        //    {
        //        context.SubmitChanges();
        //    }
        //    catch (Exception e1)
        //    {
        //        MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
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

            var selectedBatch = (InvoiceRefundBatch) _bs.List[dgvBatches.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("是否打算删除此" + selectedBatch.BatchCount + "条还款记录", MESSAGE.TITLE_INFORMATION,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            foreach (InvoiceRefundLog log in selectedBatch.InvoiceRefundLogs)
            {
                InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                log.InvoiceFinanceLog = null;
                financeLog.Invoice.CaculateRefund();
                Context.InvoiceRefundLogs.DeleteOnSubmit(log);
            }

            Context.InvoiceRefundBatches.DeleteOnSubmit(selectedBatch);
            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            dgvBatches.Rows.RemoveAt(dgvBatches.CurrentCell.RowIndex);
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
            DateTime beginDate = String.IsNullOrEmpty(dateFrom.Text) ? dateFrom.MinDate : dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(dateTo.Text) ? dateTo.MinDate : dateTo.Value.Date;
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
                queryResult = Context.InvoiceRefundBatches.Where(i =>
                                                                 i.RefundBatchNo.Contains(tbRefundBatchNo.Text)
                                                                 && (i.CaseCode != null)
                                                                 &&
                                                                 (beginDate != dateFrom.MinDate
                                                                      ? i.RefundDate >= beginDate
                                                                      : true)
                                                                 &&
                                                                 (endDate != dateTo.MinDate
                                                                      ? i.RefundDate <= endDate
                                                                      : true)
                                                                 //&& (status != string.Empty ? i.CheckStatus == status : true)
                                                                 &&
                                                                 (refundType == "全部" ? true : i.RefundType == refundType)
                                                                 && (i.CreateUserName.Contains(createUserName))
                                                                 &&
                                                                 (transactionType == "全部"
                                                                      ? true
                                                                      : i.Case.TransactionType == transactionType)
                                                                 &&
                                                                 (location == "00"
                                                                      ? true
                                                                      : i.Case.OwnerDepartment.LocationCode == location)
                                                                 &&
                                                                 (i.Case.SellerClient.ClientNameCN.Contains(clientName) ||
                                                                  i.Case.SellerClient.ClientNameEN.Contains(clientName) ||
                                                                  i.Case.BuyerClient.ClientNameCN.Contains(clientName) ||
                                                                  i.Case.BuyerClient.ClientNameEN.Contains(clientName))
                    );
            }
            else
            {
                queryResult = Context.InvoiceRefundBatches.Where(i =>
                                                                 i.RefundBatchNo.Contains(tbRefundBatchNo.Text)
                                                                 && (i.FinanceBatchNo != null)
                                                                 &&
                                                                 (beginDate != dateFrom.MinDate
                                                                      ? i.RefundDate >= beginDate
                                                                      : true)
                                                                 &&
                                                                 (endDate != dateTo.MinDate
                                                                      ? i.RefundDate <= endDate
                                                                      : true)
                                                                 //&& (status != string.Empty ? i.CheckStatus == status : true)
                                                                 &&
                                                                 (refundType == "全部" ? true : i.RefundType == refundType)
                                                                 && (i.CreateUserName.Contains(createUserName))
                                                                 &&
                                                                 (location == "00"
                                                                      ? true
                                                                      : i.InvoiceFinanceBatch.Client.Department.
                                                                            LocationCode == location)
                                                                 &&
                                                                 (i.InvoiceFinanceBatch.Client.ClientNameCN.Contains(
                                                                     clientName) ||
                                                                  i.InvoiceFinanceBatch.Client.ClientNameEN.Contains(
                                                                      clientName) ||
                                                                  i.Case.BuyerClient.ClientNameCN.Contains(clientName) ||
                                                                  i.Case.BuyerClient.ClientNameEN.Contains(clientName))
                    );
            }
            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        //private void Reject(object sender, EventArgs e)
        //{
        //    if (!PermUtil.CheckPermission(Permissions.INVOICE_CHECK))
        //    {
        //        return;
        //    }
        //    if (this.dgvBatches.CurrentCell==null)
        //    {
        //        return;
        //    }
        //    InvoiceRefundBatch batch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
        //    //if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(Permissions.INVOICE_APPROVE))
        //    //{
        //    //    MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    return;
        //    //}
        //    if (MessageBoxEx.Show("是否确认复核退回该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //    {
        //        return;
        //    }
        //    if (App.Current.CurUser.Name == batch.CreateUserName)
        //    {
        //        MessageBoxEx.Show("经办人和复核人相同，不可进行复核退回", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    batch.CheckStatus = BATCH.REJECT;
        //    batch.CheckUserName = App.Current.CurUser.Name;
        //    batch.CheckDate = DateTime.Now.Date;
        //    try
        //    {
        //        context.SubmitChanges();
        //    }
        //    catch (Exception e1)
        //    {
        //        MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
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
        private void UpdateContextMenu()
        {
            menuItemBatchDelete.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE);
        }
    }
}