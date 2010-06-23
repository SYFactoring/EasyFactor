//-----------------------------------------------------------------------
// <copyright file="FactorDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FactorDetail : Office2007Form
    {
        #region OpAgreementType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpAgreementType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_AGREEMENT,
            /// <summary>
            /// 
            /// </summary>
            UPDATE_AGREEMENT,
            /// <summary>
            /// 
            /// </summary>
            DETAIL_AGREEMENT
        }

        #endregion

        #region OpCommissionRemitType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpCommissionRemitType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_COMMISSION_REMIT,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_COMMISSION_REMIT,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_COMMISSION_REMIT
        }

        #endregion

        #region OpFactorCreditLineType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpFactorCreditLineType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_FACTOR_CREDIT_LINE,

            /// <summary>
            /// Update Factor Credit Cover
            /// </summary>
            UPDATE_FACTOR_CREDIT_LINE,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_FACTOR_CREDIT_LINE
        }

        #endregion

        #region OpFactorType enum

        /// <summary>
        /// Operation Type
        /// </summary>
        public enum OpFactorType
        {
            /// <summary>
            /// New Factor
            /// </summary>
            NEW_FACTOR,

            /// <summary>
            /// Update Factor
            /// </summary>
            UPDATE_FACTOR,

            /// <summary>
            /// Detail Factor
            /// </summary>
            DETAIL_FACTOR
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsAgreements;

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsCommissionRemit;

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bsCreditLines;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private OpAgreementType _opAgreementType;

        /// <summary>
        /// Operation type of Commission Remit
        /// </summary>
        private OpCommissionRemitType _opCommissionRemitType;

        /// <summary>
        /// 
        /// </summary>
        private OpFactorCreditLineType _opFactorCreditLineType;

        /// <summary>
        /// 
        /// </summary>
        private OpFactorType _opFactorType;


        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor">selected factor</param>
        /// <param name="opFactorType"></param>
        /// <param name="opFactorCreditLineType"></param>
        /// <param name="opAgreementType"></param>
        /// <param name="opCommissionRemitType"></param>
        private FactorDetail(Factor factor, OpFactorType opFactorType, OpFactorCreditLineType opFactorCreditLineType,
                             OpAgreementType opAgreementType, OpCommissionRemitType opCommissionRemitType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;

            _bsCreditLines = new BindingSource();
            dgvFactorCreditLines.DataSource = _bsCreditLines;
            dgvFactorCreditLines.AutoGenerateColumns = false;

            _bsAgreements = new BindingSource();
            dgvAgreements.DataSource = _bsAgreements;
            dgvAgreements.AutoGenerateColumns = false;

            _bsCommissionRemit = new BindingSource();
            dgvCommissionRemit.DataSource = _bsCommissionRemit;
            dgvCommissionRemit.AutoGenerateColumns = false;

            _context = new DBDataContext();

            countryNameComboBox.DataSource = Country.AllCountries();
            countryNameComboBox.DisplayMember = "CountryNameEN";
            countryNameComboBox.ValueMember = "CountryNameEN";
            countryNameComboBox.SelectedIndex = -1;

            creditLineCurrencyComboBox.DataSource = Currency.AllCurrencies;
            creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            creditLineCurrencyComboBox.SelectedIndex = -1;

            cbMsgCurrency.DataSource = Currency.AllCurrencies;
            cbMsgCurrency.DisplayMember = "CurrencyFormat";
            cbMsgCurrency.ValueMember = "CurrencyCode";

            cbRemitCurrency.DataSource = Currency.AllCurrencies;
            cbRemitCurrency.DisplayMember = "CurrencyFormat";
            cbRemitCurrency.ValueMember = "CurrencyCode";

            _opFactorType = opFactorType;
            _opFactorCreditLineType = opFactorCreditLineType;
            _opAgreementType = opAgreementType;
            _opCommissionRemitType = opCommissionRemitType;

            factor = opFactorType == OpFactorType.NEW_FACTOR
                         ? new Factor()
                         : _context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);

            factorBindingSource.DataSource = factor;
            _bsCreditLines.DataSource = factor.FactorCreditLines;
            _bsAgreements.DataSource = factor.Agreements;
            _bsCommissionRemit.DataSource = factor.CommissionRemittances;

            if (opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE)
            {
                factorCreditLineBindingSource.DataSource = new FactorCreditLine();
                tabControl.SelectedTab = tabItemFactorCreditLine;
            }

            if (opAgreementType == OpAgreementType.NEW_AGREEMENT)
            {
                agreementBindingSource.DataSource = new Agreement();
                tabControl.SelectedTab = tabItemAgreement;
            }

            if (opCommissionRemitType == OpCommissionRemitType.NEW_COMMISSION_REMIT)
            {
                commissionRemitBindingSource.DataSource = new CommissionRemittance();
                tabControl.SelectedTab = tabItemCommissionRemit;
            }

            UpdateFactorControlStatus();
            UpdateFactorCreditLineControlStatus();
            UpdateAgreementControlStatus();
            UpdateCommissionRemitControlStatus();
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorType"></param>
        public FactorDetail(Factor factor, OpFactorType opFactorType)
            : this(
                factor, opFactorType, OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE, OpAgreementType.DETAIL_AGREEMENT,
                OpCommissionRemitType.DETAIL_COMMISSION_REMIT
                )
        {
            tabControl.SelectedTab = tabItemFactor;
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorCreditLineType"></param>
        public FactorDetail(Factor factor, OpFactorCreditLineType opFactorCreditLineType)
            : this(
                factor, OpFactorType.DETAIL_FACTOR, opFactorCreditLineType, OpAgreementType.DETAIL_AGREEMENT,
                OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
        {
            tabControl.SelectedTab = tabItemFactorCreditLine;
            if (opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE)
            {
                factorCreditLineBindingSource.DataSource = new FactorCreditLine();
            }
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factorCreditLine"></param>
        /// <param name="opFactorCreditLineType"></param>
        public FactorDetail(FactorCreditLine factorCreditLine, OpFactorCreditLineType opFactorCreditLineType)
            : this(
                factorCreditLine.Factor, OpFactorType.DETAIL_FACTOR, opFactorCreditLineType,
                OpAgreementType.DETAIL_AGREEMENT, OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
        {
            tabControl.SelectedTab = tabItemFactorCreditLine;
            if (opFactorCreditLineType == OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE ||
                opFactorCreditLineType == OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE)
            {
                factorCreditLine =
                    _context.FactorCreditLines.SingleOrDefault(f => f.CreditLineID == factorCreditLine.CreditLineID);
                factorCreditLineBindingSource.DataSource = factorCreditLine;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agreement"></param>
        /// <param name="opAgreementType"></param>
        public FactorDetail(Agreement agreement, OpAgreementType opAgreementType)
            : this(
                agreement.Factor, OpFactorType.DETAIL_FACTOR, OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE,
                opAgreementType, OpCommissionRemitType.DETAIL_COMMISSION_REMIT)
        {
            tabControl.SelectedTab = tabItemAgreement;
            if (opAgreementType == OpAgreementType.DETAIL_AGREEMENT ||
                opAgreementType == OpAgreementType.UPDATE_AGREEMENT)
            {
                agreement = _context.Agreements.SingleOrDefault(a => a.AgreementID == agreement.AgreementID);
                agreementBindingSource.DataSource = agreement;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commissionRemit"></param>
        /// <param name="opCommissionRemitType"></param>
        public FactorDetail(CommissionRemittance commissionRemit, OpCommissionRemitType opCommissionRemitType)
            : this(
                commissionRemit.Factor, OpFactorType.DETAIL_FACTOR, OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE,
                OpAgreementType.DETAIL_AGREEMENT, opCommissionRemitType)
        {
            tabControl.SelectedTab = tabItemCommissionRemit;
            if (_opCommissionRemitType == OpCommissionRemitType.DETAIL_COMMISSION_REMIT ||
                _opCommissionRemitType == OpCommissionRemitType.UPDATE_COMMISSION_REMIT)
            {
                commissionRemit = _context.CommissionRemittances.SingleOrDefault(c => c.MsgID == commissionRemit.MsgID);
                commissionRemitBindingSource.DataSource = commissionRemit;
            }
        }


        //?Private?Methods?(24)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator1ValidateValue(object sender, ValidateValueEventArgs e)
        {
            if (freezeDateDateTimePicker.Enabled)
            {
                e.IsValid = !String.IsNullOrEmpty(freezeReasonTextBox.Text);
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator2ValidateValue(object sender, ValidateValueEventArgs e)
        {
            if (unfreezeDateDateTimePicker.Enabled)
            {
                e.IsValid = !String.IsNullOrEmpty(unfreezeReasonTextBox.Text);
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAgreement(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(agreementBindingSource.DataSource is Agreement))
            {
                return;
            }

            var agreement = (Agreement)agreementBindingSource.DataSource;
            if (agreement.AgreementID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.Agreements.DeleteOnSubmit(agreement);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                agreementBindingSource.DataSource = typeof(Agreement);
                SetAgreementEditable(false);
                _bsAgreements.DataSource = typeof(Agreement);
                _bsAgreements.DataSource = factor.Agreements;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(commissionRemitBindingSource.DataSource is CommissionRemittance))
            {
                return;
            }

            var commissionRemit = (CommissionRemittance)commissionRemitBindingSource.DataSource;
            if (commissionRemit.MsgID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.CommissionRemittances.DeleteOnSubmit(commissionRemit);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                commissionRemitBindingSource.DataSource = typeof(CommissionRemittance);
                SetCommissionRemitEditable(false);
                _bsCommissionRemit.DataSource = typeof(CommissionRemittance);
                _bsCommissionRemit.DataSource = factor.CommissionRemittances;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            var creditLine = (FactorCreditLine)factorCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                _context.FactorCreditLines.DeleteOnSubmit(creditLine);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                factorCreditLineBindingSource.DataSource = typeof(FactorCreditLine);
                SetFactorCreditLineEditable(false);
                _bsCreditLines.DataSource = typeof(FactorCreditLine);
                _bsCreditLines.DataSource = factor.FactorCreditLines;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreezeFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            var creditLine = (FactorCreditLine)factorCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            if (creditLine.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY)
            {
                freezeReasonTextBox.ReadOnly = false;
                freezeDateDateTimePicker.Enabled = true;
                creditLine.Freezer = App.Current.CurUser.Name;
                creditLine.FreezeDate = DateTime.Now.Date;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAgreement(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            var agreement = new Agreement();
            agreementBindingSource.DataSource = agreement;
            _opAgreementType = OpAgreementType.NEW_AGREEMENT;
            UpdateAgreementControlStatus();
        }

        /// <summary>
        /// Create new CommissionRemittance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            commissionRemitBindingSource.DataSource = typeof(CommissionRemittance);
            commissionRemitBindingSource.DataSource = new CommissionRemittance();
            _opCommissionRemitType = OpCommissionRemitType.NEW_COMMISSION_REMIT;
            UpdateCommissionRemitControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            var creditLine = new FactorCreditLine { CreateUserName = App.Current.CurUser.Name };
            factorCreditLineBindingSource.DataSource = creditLine;
            _opFactorCreditLineType = OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE;
            UpdateFactorCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshAgreements(object sender, EventArgs e)
        {
            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsAgreements.DataSource = typeof(Agreement);
            _bsAgreements.DataSource = factor.Agreements;
        }

        /// <summary>
        /// Refresh the CommissionRemit list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshCommissionRemitList(object sender, EventArgs e)
        {
            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsCommissionRemit.DataSource = typeof(CommissionRemittance);
            _bsCommissionRemit.DataSource = factor.CommissionRemittances;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshFactorCreditLine(object sender, EventArgs e)
        {
            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _bsCreditLines.DataSource = typeof(FactorCreditLine);
            _bsCreditLines.DataSource = factor.FactorCreditLines;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAgreement(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!agreementValidator.Validate())
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(agreementBindingSource.DataSource is Agreement))
            {
                return;
            }

            var agreement = (Agreement)agreementBindingSource.DataSource;
            agreement.CreateUserName = App.Current.CurUser.Name;

            if (agreement.AgreementID == 0)
            {
                bool isAddOK = true;
                try
                {
                    agreement.Factor = factor;
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    agreement.Factor = null;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                    _bsAgreements.DataSource = typeof(Agreement);
                    _bsAgreements.DataSource = factor.Agreements;
                    NewAgreement(null, null);
                }
            }
            else
            {
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
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Save current CommissionRemit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!commissionRemitValidator.Validate())
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(commissionRemitBindingSource.DataSource is CommissionRemittance))
            {
                return;
            }

            var commissionRemit = (CommissionRemittance)commissionRemitBindingSource.DataSource;
            commissionRemit.CreateUserName = App.Current.CurUser.Name;

            if (commissionRemit.MsgID == 0)
            {
                bool isAddOK = true;
                try
                {
                    commissionRemit.Factor = factor;
                    _context.CommissionRemittances.InsertOnSubmit(commissionRemit);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    commissionRemit.Factor = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _bsCommissionRemit.DataSource = typeof(CommissionRemittance);
                    _bsCommissionRemit.DataSource = factor.CommissionRemittances;
                    NewCommissionRemit(null, null);
                }
            }
            else
            {
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
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    dgvCommissionRemit.Refresh();
                }
            }
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!factorValidator.Validate())
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            factor.CreateUserName = App.Current.CurUser.Name;

            if (_opFactorType == OpFactorType.NEW_FACTOR)
            {
                bool isAddOK = true;
                try
                {
                    factor.LastModifiedDate = DateTime.Now.Date;
                    _context.Factors.InsertOnSubmit(factor);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _opFactorType = OpFactorType.UPDATE_FACTOR;
                }
            }
            else
            {
                bool isUpdateOK = true;
                if (factor.FactorCode == null)
                {
                    return;
                }

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
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!creditLineValidator.Validate())
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            var creditLine = (FactorCreditLine)factorCreditLineBindingSource.DataSource;
            creditLine.CreateUserName = App.Current.CurUser.Name;

            DateTime today = DateTime.Now.Date;
            creditLine.CreditLineStatus = creditLine.PeriodEnd < today
                                              ? FACTOR_CREDIT_LINE.EXPIRY
                                              : FACTOR_CREDIT_LINE.AVAILABILITY;

            if (freezeDateDateTimePicker.Enabled)
            {
                creditLine.CreditLineStatus = FACTOR_CREDIT_LINE.FREEZE;
            }

            if (creditLine.CreditLineID == 0)
            {
                bool isAddOK = true;
                try
                {
                    creditLine.Factor = factor;
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    creditLine.Factor = null;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (FactorCreditLine fcl in factor.FactorCreditLines)
                        {
                            if (fcl != creditLine && fcl.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY)
                            {
                                fcl.CreditLineStatus = FACTOR_CREDIT_LINE.EXPIRY;
                            }
                        }

                        try
                        {
                            _context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                        }
                    }

                    _bsCreditLines.DataSource = typeof(FactorCreditLine);
                    _bsCreditLines.DataSource = factor.FactorCreditLines;
                    NewFactorCreditLine(null, null);
                }
            }
            else
            {
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
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (FactorCreditLine fcl in factor.FactorCreditLines)
                        {
                            if (fcl != creditLine && fcl.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY)
                            {
                                fcl.CreditLineStatus = FACTOR_CREDIT_LINE.EXPIRY;
                            }
                        }

                        try
                        {
                            _context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAgreement(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgreements.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedAgreement = (Agreement)_bsAgreements.List[dgvAgreements.SelectedRows[0].Index];
            SetAgreementEditable(false);
            agreementBindingSource.DataSource = selectedAgreement;
        }

        /// <summary>
        /// Select CommissionRemit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCommissionRemit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCommissionRemit.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedCommissionRemit =
                (CommissionRemittance)_bsCommissionRemit.List[dgvCommissionRemit.SelectedRows[0].Index];
            if (selectedCommissionRemit != null)
            {
                commissionRemitBindingSource.DataSource = selectedCommissionRemit;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactorCreditLine(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactorCreditLines.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedFactorCreditLine =
                (FactorCreditLine)_bsCreditLines.List[dgvFactorCreditLines.SelectedRows[0].Index];
            SetFactorCreditLineEditable(false);
            factorCreditLineBindingSource.DataSource = selectedFactorCreditLine;
            btnFactorCreditLineFreeze.Enabled = true;
            btnFactorCreditLineUnfreeze.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroup(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            var factorMgr = new FactorMgr();
            var queryUI = new QueryForm(factorMgr, "选择集团");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);

            if (factorMgr.Selected != null)
            {
                factor.FactorGroup = _context.Factors.SingleOrDefault(f => f.FactorCode == factorMgr.Selected.FactorCode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editable"></param>
        private void SetAgreementEditable(bool editable)
        {
            foreach (Control comp in groupPanelAgreementDetail.Controls)
            {
                ControlUtil.SetComponetEditable(comp, editable);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editable"></param>
        private void SetCommissionRemitEditable(bool editable)
        {
            foreach (Control comp in groupPanelCommissionRemit.Controls)
            {
                ControlUtil.SetComponetEditable(comp, editable);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editable"></param>
        private void SetFactorCreditLineEditable(bool editable)
        {
            foreach (Control comp in groupPanelCreditLineDetail.Controls)
            {
                ControlUtil.SetComponetEditable(comp, editable);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnfreezeFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            var creditLine = (FactorCreditLine)factorCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            if (creditLine.CreditLineStatus == FACTOR_CREDIT_LINE.FREEZE)
            {
                unfreezeReasonTextBox.ReadOnly = false;
                unfreezeDateDateTimePicker.Enabled = true;
                creditLine.Unfreezer = App.Current.CurUser.Name;
                creditLine.UnfreezeDate = DateTime.Now.Date;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateAgreement(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(agreementBindingSource.DataSource is Agreement))
            {
                return;
            }

            _opAgreementType = OpAgreementType.UPDATE_AGREEMENT;
            UpdateAgreementControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateAgreementControlStatus()
        {
            if (_opAgreementType == OpAgreementType.DETAIL_AGREEMENT)
            {
                foreach (Control comp in groupPanelAgreementDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opAgreementType == OpAgreementType.NEW_AGREEMENT)
            {
                foreach (Control comp in groupPanelAgreementDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opAgreementType == OpAgreementType.UPDATE_AGREEMENT)
            {
                foreach (Control comp in groupPanelAgreementDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(tbAgreementCreateUserName, false);
        }

        /// <summary>
        /// Turn CommissionRemit into update status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CASE_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(commissionRemitBindingSource.DataSource is CommissionRemittance))
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
                foreach (Control comp in groupPanelCommissionRemit.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opCommissionRemitType == OpCommissionRemitType.NEW_COMMISSION_REMIT)
            {
                foreach (Control comp in groupPanelCommissionRemit.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opCommissionRemitType == OpCommissionRemitType.UPDATE_COMMISSION_REMIT)
            {
                foreach (Control comp in groupPanelCommissionRemit.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(tbCommissionCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _opFactorType = OpFactorType.UPDATE_FACTOR;
            UpdateFactorControlStatus();
        }

        /// <summary>
        /// udpate editable status
        /// </summary>
        private void UpdateFactorControlStatus()
        {
            if (_opFactorType == OpFactorType.NEW_FACTOR)
            {
                foreach (Control comp in groupPanelBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelContacts.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelMembership.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                btnGroupSelect.Visible = true;
            }
            else if (_opFactorType == OpFactorType.UPDATE_FACTOR)
            {
                foreach (Control comp in groupPanelBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelContacts.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelMembership.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                factorCodeTextBox.ReadOnly = true;
                btnGroupSelect.Visible = true;
            }
            else if (_opFactorType == OpFactorType.DETAIL_FACTOR)
            {
                foreach (Control comp in groupPanelBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelContacts.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelMembership.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                btnGroupSelect.Visible = false;
            }

            ControlUtil.SetComponetEditable(tbCreateUserName, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factor = (Factor)factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            _opFactorCreditLineType = OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE;
            UpdateFactorCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateFactorCreditLineControlStatus()
        {
            if (_opFactorCreditLineType == OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE)
            {
                foreach (Control comp in groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE)
            {
                foreach (Control comp in groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }

                creditLineStatusTextBox.ReadOnly = true;
                freezeReasonTextBox.ReadOnly = true;
                freezerTextBox.ReadOnly = true;
                freezeDateDateTimePicker.Enabled = false;
                unfreezeReasonTextBox.ReadOnly = true;
                unfreezerTextBox.ReadOnly = true;
                unfreezeDateDateTimePicker.Enabled = false;
            }
            else if (_opFactorCreditLineType == OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE)
            {
                foreach (Control comp in groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                creditLineStatusTextBox.ReadOnly = true;
                freezeReasonTextBox.ReadOnly = true;
                freezerTextBox.ReadOnly = true;
                freezeDateDateTimePicker.Enabled = false;
                unfreezeReasonTextBox.ReadOnly = true;
                unfreezerTextBox.ReadOnly = true;
                unfreezeDateDateTimePicker.Enabled = false;
            }

            ControlUtil.SetComponetEditable(tbCreditLineCreateUserName, false);
        }
    }
}