//-----------------------------------------------------------------------
// <copyright file="FactorDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    using System;
    using System.Data.Linq;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class FactorDetail : DevComponents.DotNetBar.Office2007Form
    {
		#region?Fields?(6)?

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsAgreements;
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsCreditLines;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
        /// <summary>
        /// 
        /// </summary>
        private OpAgreementType opAgreementType;
        /// <summary>
        /// 
        /// </summary>
        private OpFactorCreditLineType opFactorCreditLineType;
        /// <summary>
        /// 
        /// </summary>
        private OpFactorType opFactorType;

		#endregion?Fields?

		#region?Enums?(3)?

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

		#endregion?Enums?

		#region?Constructors?(3)?

/// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor">selected factor</param>
        /// <param name="opFactorType"></param>
        /// <param name="opFactorCreditLineType"></param>
        private FactorDetail(Factor factor, OpFactorType opFactorType, OpFactorCreditLineType opFactorCreditLineType, OpAgreementType opAgreementType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;

            this.bsCreditLines = new BindingSource();
            this.dgvFactorCreditLines.DataSource = this.bsCreditLines;
            this.dgvFactorCreditLines.AutoGenerateColumns = false;

            this.bsAgreements = new BindingSource();
            this.dgvAgreements.DataSource = this.bsAgreements;
            this.dgvAgreements.AutoGenerateColumns = false;

            this.context = new DBDataContext();

            this.countryNameComboBox.DataSource = Country.AllCountries();
            this.countryNameComboBox.DisplayMember = "CountryNameEN";
            this.countryNameComboBox.ValueMember = "CountryNameEN";
            this.countryNameComboBox.SelectedIndex = -1;

            this.creditLineCurrencyComboBox.DataSource = Currency.AllCurrencies;
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            this.creditLineCurrencyComboBox.SelectedIndex = -1;

            this.opFactorType = opFactorType;
            this.opFactorCreditLineType = opFactorCreditLineType;
            this.opAgreementType = opAgreementType;

            if (opFactorType == OpFactorType.NEW_FACTOR)
            {
                factor = new Factor();
            }
            else
            {
                factor = context.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
            }

            this.factorBindingSource.DataSource = factor;
            this.bsCreditLines.DataSource = factor.FactorCreditLines;
            this.bsAgreements.DataSource = factor.Agreements;

            if (opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE)
            {
                this.tabControl.SelectedTab = this.tabItemFactorCreditLine;
                this.factorCreditLineBindingSource.DataSource = new FactorCreditLine();
            }

            this.UpdateFactorControlStatus();
            this.UpdateFactorCreditLineControlStatus();
            this.UpdateAgreementControlStatus();
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorType"></param>
        public FactorDetail(Factor factor, OpFactorType opFactorType)
            : this(factor, opFactorType, OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE, OpAgreementType.DETAIL_AGREEMENT)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorCreditLineType"></param>
        public FactorDetail(Factor factor, OpFactorCreditLineType opFactorCreditLineType)
            : this(factor, OpFactorType.DETAIL_FACTOR, opFactorCreditLineType, OpAgreementType.DETAIL_AGREEMENT)
        {
            this.tabControl.SelectedTab = this.tabItemFactorCreditLine;
        }

		#endregion?Constructors?

		#region?Methods?(24)?

		//?Private?Methods?(24)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            if (this.freezeDateDateTimePicker.Enabled)
            {
                if (String.IsNullOrEmpty(this.freezeReasonTextBox.Text))
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                }
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
        private void customValidator2_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            if (this.unfreezeDateDateTimePicker.Enabled)
            {
                if (String.IsNullOrEmpty(this.unfreezeReasonTextBox.Text))
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                }
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorAgreementBindingSource.DataSource is Agreement))
            {
                return;
            }

            Agreement agreement = (Agreement)this.factorAgreementBindingSource.DataSource;
            if (agreement.AgreementID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.Agreements.DeleteOnSubmit(agreement);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bsAgreements.DataSource = typeof(Agreement);
                this.bsAgreements.DataSource = factor.Agreements;
                this.factorAgreementBindingSource.DataSource = typeof(Agreement);
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.FactorCreditLines.DeleteOnSubmit(creditLine);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bsCreditLines.DataSource = typeof(FactorCreditLine);
                this.bsCreditLines.DataSource = factor.FactorCreditLines;
                this.factorCreditLineBindingSource.DataSource = typeof(FactorCreditLine);
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            if (creditLine.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY)
            {
                this.freezeReasonTextBox.ReadOnly = false;
                this.freezeDateDateTimePicker.Enabled = true;
                creditLine.Freezer = App.Current.CurUser.Name;
                creditLine.FreezeDate = System.DateTime.Now.Date;
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Agreement agreement = new Agreement();
            this.factorAgreementBindingSource.DataSource = agreement;
            this.opAgreementType = OpAgreementType.NEW_AGREEMENT;
            this.UpdateAgreementControlStatus();
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FactorCreditLine creditLine = new FactorCreditLine();
            creditLine.CreateUserName = App.Current.CurUser.Name;
            this.factorCreditLineBindingSource.DataSource = creditLine;
            this.opFactorCreditLineType = OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE;
            this.UpdateFactorCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshAgreements(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsAgreements.DataSource = typeof(Agreement);
            this.bsAgreements.DataSource = factor.Agreements;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsCreditLines.DataSource = typeof(FactorCreditLine);
            this.bsCreditLines.DataSource = factor.FactorCreditLines;
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorAgreementBindingSource.DataSource is Agreement))
            {
                return;
            }

            Agreement agreement = (Agreement)this.factorAgreementBindingSource.DataSource;
            agreement.CreateUserName = App.Current.CurUser.Name;

            if (agreement.AgreementID == 0)
            {
                bool isAddOK = true;
                try
                {
                    agreement.Factor = factor;
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    agreement.Factor = null;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.bsAgreements.DataSource = typeof(Agreement);
                    this.bsAgreements.DataSource = factor.Agreements;
                    this.NewAgreement(null, null);
                }
            }
            else
            {
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
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveFactor(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (!this.factorValidator.Validate())
            {
                return;
            }

            Factor factor = (Factor)factorBindingSource.DataSource;
            factor.CreateUserName = App.Current.CurUser.Name;

            if (this.opFactorType == OpFactorType.NEW_FACTOR)
            {
                bool isAddOK = true;
                try
                {
                    factor.LastModifiedDate = DateTime.Now.Date;
                    context.Factors.InsertOnSubmit(factor);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.opFactorType = OpFactorType.UPDATE_FACTOR;
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
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (!this.creditLineValidator.Validate())
            {
                return;
            }

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
            creditLine.CreateUserName = App.Current.CurUser.Name;

            DateTime today = DateTime.Now.Date;
            if (creditLine.PeriodBegin < today)
            {
                creditLine.CreditLineStatus = FACTOR_CREDIT_LINE.EXPIRY;
            }
            else
            {
                creditLine.CreditLineStatus = FACTOR_CREDIT_LINE.AVAILABILITY;
            }

            if (this.freezeDateDateTimePicker.Enabled)
            {
                creditLine.CreditLineStatus = FACTOR_CREDIT_LINE.FREEZE;
            }

            if (this.unfreezeDateDateTimePicker.Enabled)
            {
                if (creditLine.PeriodBegin < today)
                {
                    creditLine.CreditLineStatus = FACTOR_CREDIT_LINE.EXPIRY;
                }
                else
                {
                    creditLine.CreditLineStatus = FACTOR_CREDIT_LINE.AVAILABILITY;
                }
            }
            if (creditLine.CreditLineID == 0)
            {
                bool isAddOK = true;
                try
                {
                    creditLine.Factor = factor;
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    creditLine.Factor = null;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    this.bsCreditLines.DataSource = typeof(FactorCreditLine);
                    this.bsCreditLines.DataSource = factor.FactorCreditLines;
                    this.NewFactorCreditLine(null, null);
                }
            }
            else
            {
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
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (this.dgvAgreements.SelectedRows.Count == 0)
            {
                return;
            }

            Agreement selectedAgreement = (Agreement)this.bsAgreements.List[this.dgvAgreements.SelectedRows[0].Index];
            this.SetAgreementEditable(false);
            this.factorAgreementBindingSource.DataSource = selectedAgreement;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactorCreditLine(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFactorCreditLines.SelectedRows.Count == 0)
            {
                return;
            }

            FactorCreditLine selectedFactorCreditLine = (FactorCreditLine)this.bsCreditLines.List[this.dgvFactorCreditLines.SelectedRows[0].Index];
            this.SetFactorCreditLineEditable(false);
            this.factorCreditLineBindingSource.DataSource = selectedFactorCreditLine;
            this.btnFactorCreditLineFreeze.Enabled = true;
            this.btnFactorCreditLineUnfreeze.Enabled = true;
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            FactorMgr factorMgr = new FactorMgr();
            QueryForm queryUI = new QueryForm(factorMgr, "选择集团");
            factorMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);

            if (factorMgr.Selected != null)
            {
                factor.FactorGroup = this.context.Factors.SingleOrDefault(f => f.FactorCode == factorMgr.Selected.FactorCode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="editable"></param>
        private void SetAgreementEditable(bool editable)
        {
            foreach (Control comp in this.groupPanelAgreementDetail.Controls)
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
            foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
            if (creditLine.CreditLineID == 0)
            {
                return;
            }

            if (creditLine.CreditLineStatus == FACTOR_CREDIT_LINE.FREEZE)
            {
                this.unfreezeReasonTextBox.ReadOnly = false;
                this.unfreezeDateDateTimePicker.Enabled = true;
                creditLine.Unfreezer = App.Current.CurUser.Name;
                creditLine.UnfreezeDate = System.DateTime.Now.Date;
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorAgreementBindingSource.DataSource is Agreement))
            {
                return;
            }

            this.opAgreementType = OpAgreementType.UPDATE_AGREEMENT;
            this.UpdateAgreementControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateAgreementControlStatus()
        {
            if (this.opAgreementType == OpAgreementType.DETAIL_AGREEMENT)
            {
                foreach (Control comp in this.groupPanelAgreementDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opAgreementType == OpAgreementType.NEW_AGREEMENT)
            {
                foreach (Control comp in this.groupPanelAgreementDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opAgreementType == OpAgreementType.UPDATE_AGREEMENT)
            {
                foreach (Control comp in this.groupPanelAgreementDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(this.tbAgreementCreateUserName, false);
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.opFactorType = OpFactorType.UPDATE_FACTOR;
            this.UpdateFactorControlStatus();
        }

        /// <summary>
        /// udpate editable status
        /// </summary>
        private void UpdateFactorControlStatus()
        {
            if (this.opFactorType == OpFactorType.NEW_FACTOR)
            {
                foreach (Control comp in this.groupPanelBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelContacts.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelMembership.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                this.btnGroupSelect.Visible = true;
            }
            else if (this.opFactorType == OpFactorType.UPDATE_FACTOR)
            {
                foreach (Control comp in this.groupPanelBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelContacts.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelMembership.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.factorCodeTextBox.ReadOnly = true;
                this.btnGroupSelect.Visible = true;
            }
            else if (this.opFactorType == OpFactorType.DETAIL_FACTOR)
            {
                foreach (Control comp in this.groupPanelBasic.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelContacts.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelMembership.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                this.btnGroupSelect.Visible = false;
            }

            ControlUtil.SetComponetEditable(this.tbCreateUserName, false);
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

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            this.opFactorCreditLineType = OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE;
            this.UpdateFactorCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateFactorCreditLineControlStatus()
        {
            if (this.opFactorCreditLineType == OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE)
            {
                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE)
            {
                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetDefault(comp);
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.creditLineStatusTextBox.ReadOnly = true;
                this.freezeReasonTextBox.ReadOnly = true;
                this.freezerTextBox.ReadOnly = true;
                this.freezeDateDateTimePicker.Enabled = false;
                this.unfreezeReasonTextBox.ReadOnly = true;
                this.unfreezerTextBox.ReadOnly = true;
                this.unfreezeDateDateTimePicker.Enabled = false;
            }
            else if (this.opFactorCreditLineType == OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE)
            {
                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.creditLineStatusTextBox.ReadOnly = true;
                this.freezeReasonTextBox.ReadOnly = true;
                this.freezerTextBox.ReadOnly = true;
                this.freezeDateDateTimePicker.Enabled = false;
                this.unfreezeReasonTextBox.ReadOnly = true;
                this.unfreezerTextBox.ReadOnly = true;
                this.unfreezeDateDateTimePicker.Enabled = false;
            }

            ControlUtil.SetComponetEditable(this.tbCreditLineCreateUserName, false);
        }

		#endregion?Methods?
    }
}
