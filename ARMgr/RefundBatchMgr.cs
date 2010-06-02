//-----------------------------------------------------------------------
// <copyright file="RefundBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;
    /// <summary>
    /// 
    /// </summary>
    public partial class RefundBatchMgr : UserControl
    {
        #region?Fields?(3)?

        /// <summary>
        /// 
        /// </summary>
        private Case _case;
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        #endregion?Fields?

        #region?Enums?(1)?

        /// <summary>
        /// 
        /// </summary>
        public enum OpBatchType
        {
            /// <summary>
            /// 
            /// </summary>
            //CHECK,

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

            /// <summary>
            /// 
            /// </summary>
            //POOL_CHECK
        }

        #endregion?Enums?

        #region?Constructors?(3)?

        /// <summary>
        /// Initializes a new instance of the RefundBatchMgr class
        /// </summary>
        /// <param name="createUserName"></param>
        /// <param name="batchStatus"></param>
        public RefundBatchMgr(string createUserName, string batchStatus)
            : this(OpBatchType.QUERY)
        {
            this.tbCreateUserName.Text = createUserName;
            this.cbCheckStatus.Text = batchStatus;
            this.QueryBatch(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCDA"></param>
        /// <param name="context"></param>
        public RefundBatchMgr(Case selectedCase, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            this._case = selectedCase;
            this.panelQuery.Visible = false;
            this.bs.DataSource = selectedCase.InvoiceRefundBatches;
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchType"></param>
        public RefundBatchMgr(OpBatchType batchType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvBatches.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvBatches.DataSource = bs;
            this.opBatchType = batchType;
            ControlUtil.SetDoubleBuffered(this.dgvBatches);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location() { LocationCode = "00", LocationName = "ȫ��" });
            this.cbLocation.DataSource = allLocations;
            this.cbLocation.DisplayMember = "LocationName";
            this.cbLocation.ValueMember = "LocationCode";
            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();

            //if (batchType == OpBatchType.CHECK)
            //{
            //    this.cbCheckStatus.Text = BATCH.UNCHECK;
            //    context = new DBDataContext();
            //    var queryResult = context.InvoiceRefundBatches.Where(i => i.Case != null);
            //    this.bs.DataSource = queryResult;
            //    this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
            //}
            //else if (batchType == OpBatchType.POOL_CHECK)
            //{
            //    this.colBuyerName.Visible = false;
            //    this.colBatchCount.Visible = false;
            //    this.colTransactionType.Visible = false;

            //    this.cbCheckStatus.Text = BATCH.UNCHECK;
            //    context = new DBDataContext();
            //    var queryResult = context.InvoiceRefundBatches.Where(i => i.InvoiceFinanceBatch != null);
            //    this.bs.DataSource = queryResult;
            //    this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
            //}
            if (batchType == OpBatchType.POOL_QUERY)
            {
                this.colBuyerName.Visible = false;
                this.colBatchCount.Visible = false;
                this.colTransactionType.Visible = false;
            }
        }

        #endregion?Constructors?

        #region?Properties?(3)?

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
        /// Gets or sets selected RefundBatch
        /// </summary>
        public InvoiceRefundBatch Selected
        {
            get;
            set;
        }

        #endregion?Properties?

        #region?Methods?(9)?

        //?Private?Methods?(9)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        //        MessageBoxEx.Show("�������Ѿ�������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    if (MessageBoxEx.Show("�Ƿ�ȷ�ϸ���ͨ��������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //    {
        //        return;
        //    }

        //    if (App.Current.CurUser.Name == batch.CreateUserName)
        //    {
        //        MessageBoxEx.Show("�����˺͸�������ͬ�����ɽ��и���", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceRefundBatch selectedBatch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            if (MessageBoxEx.Show("�Ƿ����ɾ����" + selectedBatch.BatchCount + "�������¼", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            //if (selectedBatch.CheckStatus == BATCH.CHECK)
            //{
            //    MessageBoxEx.Show("����ɾ���Ѹ�������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            foreach (InvoiceRefundLog log in selectedBatch.InvoiceRefundLogs)
            {
                InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                log.InvoiceFinanceLog = null;
                financeLog.Invoice.CaculateRefund();
                context.InvoiceRefundLogs.DeleteOnSubmit(log);
            }

            context.InvoiceRefundBatches.DeleteOnSubmit(selectedBatch);
            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("ɾ��ʧ��," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dgvBatches.Rows.RemoveAt(this.dgvBatches.CurrentCell.RowIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceRefundBatch selectedBatch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            RefundBatchDetail detail = new RefundBatchDetail(selectedBatch);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailBatch(sender, e);
            }
            else
            {
                this.SelectBatch(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBatches_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvBatches.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvBatches.RowHeadersDefaultCellStyle.Font, rectangle, dgvBatches.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            DateTime beginDate = String.IsNullOrEmpty(this.dateFrom.Text) ? this.dateFrom.MinDate : this.dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(this.dateTo.Text) ? this.dateTo.MinDate : this.dateTo.Value.Date;
            string status = this.cbCheckStatus.Text;
            string createUserName = this.tbCreateUserName.Text;
            string clientName = this.tbClientName.Text;
            string location = (string)this.cbLocation.SelectedValue;
            string transactionType = this.cbTransactionType.Text;
            if (String.IsNullOrEmpty(transactionType))
            {
                transactionType = "ȫ��";
            }

            string refundType = this.cbRefundType.Text;
            if (String.IsNullOrEmpty(refundType))
            {
                refundType = "ȫ��";
            }

            context = new DBDataContext();

            IEnumerable<InvoiceRefundBatch> queryResult = null;
            if (opBatchType != OpBatchType.POOL_QUERY)
            {
                queryResult = context.InvoiceRefundBatches.Where(i =>
                   i.RefundBatchNo.Contains(this.tbRefundBatchNo.Text)
                   && (i.CaseCode != null)
                   && (beginDate != this.dateFrom.MinDate ? i.RefundDate >= beginDate : true)
                   && (endDate != this.dateTo.MinDate ? i.RefundDate <= endDate : true)
                       //&& (status != string.Empty ? i.CheckStatus == status : true)
                   && (refundType == "ȫ��" ? true : i.RefundType == refundType)
                   && (i.CreateUserName.Contains(createUserName))
                   && (transactionType == "ȫ��" ? true : i.Case.TransactionType == transactionType)
                   && (location == "00" ? true : i.Case.OwnerDepartment.LocationCode == location)
                   && (i.Case.SellerClient.ClientNameCN.Contains(clientName) || i.Case.SellerClient.ClientNameEN.Contains(clientName) || i.Case.BuyerClient.ClientNameCN.Contains(clientName) || i.Case.BuyerClient.ClientNameEN.Contains(clientName))
                   );
            }
            else
            {
                queryResult = context.InvoiceRefundBatches.Where(i =>
                   i.RefundBatchNo.Contains(this.tbRefundBatchNo.Text)
                   && (i.FinanceBatchNo != null)
                   && (beginDate != this.dateFrom.MinDate ? i.RefundDate >= beginDate : true)
                   && (endDate != this.dateTo.MinDate ? i.RefundDate <= endDate : true)
                       //&& (status != string.Empty ? i.CheckStatus == status : true)
                   && (refundType == "ȫ��" ? true : i.RefundType == refundType)
                   && (i.CreateUserName.Contains(createUserName))
                   && (location == "00" ? true : i.InvoiceFinanceBatch.Client.Department.LocationCode == location)
                   && (i.InvoiceFinanceBatch.Client.ClientNameCN.Contains(clientName) || i.InvoiceFinanceBatch.Client.ClientNameEN.Contains(clientName) || i.Case.BuyerClient.ClientNameCN.Contains(clientName) || i.Case.BuyerClient.ClientNameEN.Contains(clientName))
                   );
            }
            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        //    //    MessageBoxEx.Show("�������Ѿ�������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    return;
        //    //}

        //    if (MessageBoxEx.Show("�Ƿ�ȷ�ϸ����˻ظ�����", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //    {
        //        return;
        //    }

        //    if (App.Current.CurUser.Name == batch.CreateUserName)
        //    {
        //        MessageBoxEx.Show("�����˺͸�������ͬ�����ɽ��и����˻�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceRefundBatch selectedBatch = (InvoiceRefundBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            this.Selected = selectedBatch;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE))
            {
                this.menuItemBatchDelete.Enabled = true;
            }
            else
            {
                this.menuItemBatchDelete.Enabled = false;
            }

            if (PermUtil.ValidatePermission(Permissions.INVOICE_CHECK))
            {
                this.menuItemCheck.Enabled = true;
                this.menuItemReject.Enabled = true;
            }
            else
            {
                this.menuItemCheck.Enabled = false;
                this.menuItemReject.Enabled = false;
            }
        }

        #endregion?Methods?
    }
}
