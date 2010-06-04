//-----------------------------------------------------------------------
// <copyright file="PaymentBatchMgr.cs" company="Yiming Liu@Fudan">
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
    public partial class PaymentBatchMgr : UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;
        /// <summary>
        /// 
        /// </summary>
        private readonly Case _case;
        /// <summary>
        /// 
        /// </summary>
        private OpBatchType _opBatchType;

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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <param name="context"></param>
        public PaymentBatchMgr(Case selectedCase, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            _case = selectedCase;
            panelQuery.Visible = false;
            _bs.DataSource = _case.InvoicePaymentBatches;
            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchType"></param>
        public PaymentBatchMgr(OpBatchType batchType)
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
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "全部" });
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            UpdateContextMenu();
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
        /// Gets or sets selected PaymentBatch
        /// </summary>
        public InvoicePaymentBatch Selected { get; set; }




        //?Private?Methods?(12)?
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
        //    InvoicePaymentBatch batch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
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

            List<InvoicePaymentBatch> batches = GetSelectedBatches();
            if (
                MessageBoxEx.Show("是否打算删除此" + batches.Count() + "条付款批次记录", MESSAGE.TITLE_INFORMATION,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                foreach (InvoicePaymentBatch selectedBatch in batches)
                {
                    foreach (InvoicePaymentLog log in selectedBatch.InvoicePaymentLogs)
                    {
                        Invoice invoice = log.Invoice;
                        log.Invoice = null;
                        invoice.CaculatePayment();
                        Context.InvoicePaymentLogs.DeleteOnSubmit(log);
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

            var selectedBatch = (InvoicePaymentBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
            var detail = new PaymentBatchDetail(selectedBatch);
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
        private void DgvBatchesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = dgvBatches.Columns[e.ColumnIndex];
            if (col == colIsSendMsg)
            {
                var isSend = (bool)e.Value;
                e.Value = isSend ? "Y" : "N";

                e.FormattingApplied = true;
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
        private void ExportMSG09(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            List<InvoicePaymentBatch> selectedBatches = GetSelectedBatches();

            foreach (InvoicePaymentBatch selectedBatch in selectedBatches)
            {
                if (selectedBatch.PaymentType != PAYMENT.CREDIT_NOTE_PAYMENT)
                {
                    MessageBoxEx.Show("只有贷项通知可以生成MSG09，批次号：" + selectedBatch.PaymentBatchNo, MESSAGE.TITLE_INFORMATION,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            var form = new ExportForm(ExportForm.ExportType.EXPORT_MSG09_CREDITNOTE, selectedBatches);
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportMSG11(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            List<InvoicePaymentBatch> selectedBatches = GetSelectedBatches();

            foreach (InvoicePaymentBatch selectedBatch in selectedBatches)
            {
                if (selectedBatch.PaymentType != PAYMENT.BUYER_PAYMENT)
                {
                    MessageBoxEx.Show("只有买方付款可以生成MSG11，批次号：" + selectedBatch.PaymentBatchNo, MESSAGE.TITLE_INFORMATION,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            var form = new ExportForm(ExportForm.ExportType.EXPORT_MSG11, selectedBatches);
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportMSG12(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            List<InvoicePaymentBatch> selectedBatches = GetSelectedBatches();

            foreach (InvoicePaymentBatch selectedBatch in selectedBatches)
            {
                if (selectedBatch.PaymentType != PAYMENT.INDIRECT_PAYMENT)
                {
                    MessageBoxEx.Show("只有买方间接付款可以生成MSG12，：批次号：" + selectedBatch.PaymentBatchNo,
                                      MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            var form = new ExportForm(ExportForm.ExportType.EXPORT_MSG12, selectedBatches);
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<InvoicePaymentBatch> GetSelectedBatches()
        {
            if (dgvBatches.CurrentCell == null)
            {
                return null;
            }

            var selectedBatches = new List<InvoicePaymentBatch>();

            foreach (DataGridViewCell cell in dgvBatches.SelectedCells)
            {
                var batch = (InvoicePaymentBatch)_bs.List[cell.RowIndex];
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            DateTime beginDate = String.IsNullOrEmpty(dateFrom.Text) ? dateFrom.MinDate : dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(dateTo.Text) ? dateTo.MinDate : dateTo.Value.Date;
            string createUserName = tbCreateUserName.Text;
            string clientName = tbClientName.Text;
            var location = (string)cbLocation.SelectedValue;
            string transactionType = cbTransactionType.Text;
            if (String.IsNullOrEmpty(transactionType))
            {
                transactionType = "全部";
            }

            string paymentType = cbPaymentType.Text;
            if (String.IsNullOrEmpty(paymentType))
            {
                paymentType = "全部";
            }
            Context = new DBDataContext();

            IQueryable<InvoicePaymentBatch> queryResult = Context.InvoicePaymentBatches.Where(i =>
                                                                                              i.PaymentBatchNo.Contains(
                                                                                                  tbPaymentBatchNo.Text)
                                                                                              &&
                                                                                              (beginDate !=
                                                                                               dateFrom.MinDate
                                                                                                   ? i.PaymentDate >=
                                                                                                     beginDate
                                                                                                   : true)
                                                                                              &&
                                                                                              (endDate != dateTo.MinDate
                                                                                                   ? i.PaymentDate <=
                                                                                                     endDate
                                                                                                   : true)
                                                                                                  //&& (status != string.Empty ? i.CheckStatus == status : true)
                                                                                              &&
                                                                                              (paymentType == "全部"
                                                                                                   ? true
                                                                                                   : i.PaymentType ==
                                                                                                     paymentType)
                                                                                              &&
                                                                                              (i.CreateUserName.Contains
                                                                                                  (createUserName))
                                                                                              &&
                                                                                              (transactionType == "全部"
                                                                                                   ? true
                                                                                                   : i.Case.
                                                                                                         TransactionType ==
                                                                                                     transactionType)
                                                                                              &&
                                                                                              (location == "00"
                                                                                                   ? true
                                                                                                   : i.Case.
                                                                                                         OwnerDepartment
                                                                                                         .LocationCode ==
                                                                                                     location)
                                                                                              &&
                                                                                              (i.Case.SellerClient.
                                                                                                   ClientNameCN.Contains
                                                                                                   (clientName) ||
                                                                                               i.Case.SellerClient.
                                                                                                   ClientNameEN.Contains
                                                                                                   (clientName) ||
                                                                                               i.Case.BuyerClient.
                                                                                                   ClientNameCN.Contains
                                                                                                   (clientName) ||
                                                                                               i.Case.BuyerClient.
                                                                                                   ClientNameEN.Contains
                                                                                                   (clientName))
                );

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        //private void Reject(object sender, EventArgs e)
        //{
        //    if (!PermUtil.CheckPermission(Permissions.INVOICE_CHECK))
        //    {
        //        return;
        //    }
        //    if (this.dgvBatches.CurrentCell == null)
        //    {
        //        return;
        //    }
        //    InvoicePaymentBatch batch = (InvoicePaymentBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
        //    if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(Permissions.INVOICE_APPROVE))
        //    {
        //        MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
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

            var selectedBatch = (InvoicePaymentBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
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
            menuItemMSG09.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemMSG11.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemMSG12.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
        }
    }
}