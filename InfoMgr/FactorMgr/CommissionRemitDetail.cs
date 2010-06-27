//-----------------------------------------------------------------------
// <copyright file="CommissionRemitDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.ARMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class CommissionRemitDetail : Office2007Form
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;
        /// <summary>
        /// Operation type of Commission Remit
        /// </summary>
        private OpCommissionRemitType _opCommissionRemitType;

        /// <summary>
        /// 
        /// </summary>
        public enum OpCommissionRemitType
        {
            /// <summary>
            /// 
            /// </summary>
            UPDATE_COMMISSION_REMIT,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_COMMISSION_REMIT
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="commissionRemit"></param>
        public CommissionRemitDetail(CommissionRemittance commissionRemit)
        {
            InitializeComponent();
            _context = new DBDataContext();
            commissionRemit = _context.CommissionRemittances.SingleOrDefault(c => c.MsgID == commissionRemit.MsgID);
            commissionRemitBindingSource.DataSource = commissionRemit;
            _opCommissionRemitType = OpCommissionRemitType.DETAIL_COMMISSION_REMIT;
            ImeMode = ImeMode.OnHalf;

            cbMsgCurrency.DataSource = Currency.AllCurrencies;
            cbMsgCurrency.DisplayMember = "CurrencyFormat";
            cbMsgCurrency.ValueMember = "CurrencyCode";

            cbRemitCurrency.DataSource = Currency.AllCurrencies;
            cbRemitCurrency.DisplayMember = "CurrencyFormat";
            cbRemitCurrency.ValueMember = "CurrencyCode";

            tbFactor.Text = commissionRemit.Factor.ToString();

            var batchMgr = new AssignBatchMgr(commissionRemit, _context) { Dock = DockStyle.Fill };
            panelBatches.Controls.Add(batchMgr);

            UpdateCommissionRemitControlStatus();
        }




        /// <summary>
        /// Save current CommissionRemit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (!commissionRemitValidator.Validate())
            {
                return;
            }

            var commissionRemit = (CommissionRemittance)commissionRemitBindingSource.DataSource;
            commissionRemit.CreateUserName = App.Current.CurUser.Name;

            if (commissionRemit.MsgID == 0)
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
                foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                {
                    foreach (MemberChangeConflict mc in cc.MemberConflicts)
                    {
                        mc.Resolve(RefreshMode.KeepChanges);
                    }
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
        /// Turn CommissionRemit into update status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            _opCommissionRemitType = OpCommissionRemitType.UPDATE_COMMISSION_REMIT;
            UpdateCommissionRemitControlStatus();
        }

        /// <summary>
        /// Update CommissionRemit Control Status
        /// </summary>
        private void UpdateCommissionRemitControlStatus()
        {
            if (_opCommissionRemitType == OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
            {
                foreach (Control comp in panelCommission.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opCommissionRemitType == OpCommissionRemitType.UPDATE_COMMISSION_REMIT)
            {
                foreach (Control comp in panelCommission.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(tbFactor, false);
            ControlUtil.SetComponetEditable(tbCommissionCreateUserName, false);
        }
    }
}