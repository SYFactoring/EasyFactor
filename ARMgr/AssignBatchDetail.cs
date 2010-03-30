//-----------------------------------------------------------------------
// <copyright file="AssignBatchDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Data.Linq;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpBatchType
        {
            /// <summary>
            /// 
            /// </summary>
            DETAIL_BATCH,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_BATCH,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the AssignBatchDetail class
        /// </summary>
        /// <param name="batch"></param>
        public AssignBatchDetail(InvoiceAssignBatch batch)
        {
            this.InitializeComponent();
            this.context = new DBDataContext();
            batch = context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == batch.AssignBatchNo);
            this.batchBindingSource.DataSource = batch;
            this.opBatchType = OpBatchType.DETAIL_BATCH;
            this.ImeMode = ImeMode.OnHalf;

            InvoiceMgr invoiceMgr = new InvoiceMgr(batch.Invoices, context);
            invoiceMgr.Dock = DockStyle.Fill;
            this.panelInvoices.Controls.Add(invoiceMgr);

            this.UpdateBatchControlStatus();
        }

        #endregion Constructors

        #region Methods (5)

        // Private Methods (5) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.batchBindingSource.DataSource;
            CaseDetail detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.batchBindingSource.DataSource;

            bool isUpdateOK = true;

            try
            {
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                {
                    foreach (MemberChangeConflict mc in cc.MemberConflicts)
                    {
                        mc.Resolve(RefreshMode.KeepChanges);
                    }
                }

                context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                return;
            }

            this.opBatchType = OpBatchType.UPDATE_BATCH;
            this.UpdateBatchControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBatchControlStatus()
        {
            if (this.opBatchType == OpBatchType.DETAIL_BATCH)
            {
                foreach (Control comp in this.panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opBatchType == OpBatchType.UPDATE_BATCH)
            {
                foreach (Control comp in this.panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.caseCodeTextBox.ReadOnly = true;
                this.assignBatchNoTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(this.createUserNameTextBox, false);
        }

        #endregion Methods
    }
}
