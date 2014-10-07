//-----------------------------------------------------------------------
// <copyright file="AssignBatchDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchDetail : Office2007Form
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
            DETAIL_BATCH,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_BATCH,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private OpBatchType _opBatchType;


        /// <summary>
        /// Initializes a new instance of the AssignBatchDetail class
        /// </summary>
        /// <param name="batch"></param>
        public AssignBatchDetail(InvoiceAssignBatch batch)
        {
            InitializeComponent();
            _context = new DBDataContext();
            batch = _context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == batch.AssignBatchNo);
            batchBindingSource.DataSource = batch;
            _opBatchType = OpBatchType.DETAIL_BATCH;
            ImeMode = ImeMode.OnHalf;

            var invoiceMgr = new InvoiceMgr(batch.Invoices, _context) {Dock = DockStyle.Fill};
            panelInvoices.Controls.Add(invoiceMgr);

            var creditNoteMgr = new CreditNoteMgr(batch.CreditNotes, _context) {Dock = DockStyle.Fill};
            panelCreditNote.Controls.Add(creditNoteMgr);

            UpdateBatchControlStatus();
        }


        //?Private?Methods?(4)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            var batch = (InvoiceAssignBatch) batchBindingSource.DataSource;
            var detail = new CaseDetail(batch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            detail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            bool isUpdateOK = true;

            try
            {
                _context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                foreach (MemberChangeConflict mc in _context.ChangeConflicts.SelectMany(cc => cc.MemberConflicts))
                {
                    mc.Resolve(RefreshMode.KeepChanges);
                }

                _context.SubmitChanges();
            }
            catch (Exception e2)
            {
                isUpdateOK = false;
                MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isUpdateOK)
            {
                MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            _opBatchType = OpBatchType.UPDATE_BATCH;
            UpdateBatchControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBatchControlStatus()
        {
            if (_opBatchType == OpBatchType.DETAIL_BATCH)
            {
                foreach (Control comp in panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opBatchType == OpBatchType.UPDATE_BATCH)
            {
                foreach (Control comp in panelBatch.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(createUserNameTextBox, false);
            ControlUtil.SetComponetEditable(caseCodeTextBox, false);
            ControlUtil.SetComponetEditable(assignBatchNoTextBox, false);
            ControlUtil.SetComponetEditable(diInputDate, false);
            ControlUtil.SetComponetEditable(tbWhoPayFee, false);
            ControlUtil.SetComponetEditable(tbCheckStatus, false);
        }
    }
}