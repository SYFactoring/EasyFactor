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
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class FactorDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (3)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bsCreditLines;
        /// <summary>
        /// 
        /// </summary>
        private OpFactorCreditLineType opFactorCreditLineType;
        /// <summary>
        /// 
        /// </summary>
        private OpFactorType opFactorType;

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;

        #endregion Fields

        #region Enums (2)

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

        #endregion Enums

        #region Constructors (3)

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor">selected factor</param>
        /// <param name="opFactorType"></param>
        /// <param name="opFactorCreditLineType"></param>
        private FactorDetail(Factor factor, OpFactorType opFactorType, OpFactorCreditLineType opFactorCreditLineType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.bsCreditLines = new BindingSource();
            this.dgvFactorCreditLines.DataSource = this.bsCreditLines;
            this.dgvFactorCreditLines.AutoGenerateColumns = false;
            this.context = new DBDataContext();

            this.countryNameComboBox.DataSource = Country.AllCountries();
            this.countryNameComboBox.DisplayMember = "CountryNameEN";
            this.countryNameComboBox.ValueMember = "CountryNameEN";
            this.countryNameComboBox.SelectedIndex = -1;

            this.creditLineCurrencyComboBox.DataSource = Currency.AllCurrencies();
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            this.creditLineCurrencyComboBox.SelectedIndex = -1;

            this.opFactorType = opFactorType;
            this.opFactorCreditLineType = opFactorCreditLineType;

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

            if (opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE)
            {
                this.tabControl.SelectedTab = this.tabItemFactorCreditLine;
                this.factorCreditLineBindingSource.DataSource = new FactorCreditLine();
            }


            this.UpdateFactorControlStatus();
            this.UpdateFactorCreditLineControlStatus();
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorType"></param>
        public FactorDetail(Factor factor, OpFactorType opFactorType)
            : this(factor, opFactorType, OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorCreditLineType"></param>
        public FactorDetail(Factor factor, OpFactorCreditLineType opFactorCreditLineType)
            : this(factor, OpFactorType.DETAIL_FACTOR, opFactorCreditLineType)
        {
            this.tabControl.SelectedTab = this.tabItemFactorCreditLine;
        }

        #endregion Constructors

        #region Methods (18)

        // Private Methods (18) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            if (this.freezeDateDateTimePicker.Enabled)
            {
                if (this.freezeReasonTextBox.Text == string.Empty)
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
                if (this.unfreezeReasonTextBox.Text == string.Empty)
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
        private void DeleteFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (creditLine.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY)
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
        private void NewFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void RefreshFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.bsCreditLines.DataSource = typeof(FactorCreditLine);
            this.bsCreditLines.DataSource = factor.FactorCreditLines;
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveFactor(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (!this.factorValidator.Validate())
            {
                return;
            }
            Factor factor = (Factor)factorBindingSource.DataSource;
            if (this.opFactorType == OpFactorType.NEW_FACTOR)
            {
                bool isAddOK = true;
                try
                {
                    factor.LastModifiedDate = DateTime.Now.Date;
                    factor.CreateUserName = App.Current.CurUser.Name;
                    context.Factors.InsertOnSubmit(factor);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
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
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;

            DateTime today = DateTime.Now.Date;
            if (creditLine.PeriodBegin < today)
            {
                creditLine.CreditLineStatus = ConstStr.FACTOR_CREDIT_LINE.EXPIRY;
            }
            else
            {
                creditLine.CreditLineStatus = ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY;
            }

            if (this.freezeDateDateTimePicker.Enabled)
            {
                creditLine.CreditLineStatus = ConstStr.FACTOR_CREDIT_LINE.FREEZE;
            }

            if (this.unfreezeDateDateTimePicker.Enabled)
            {
                if (creditLine.PeriodBegin < today)
                {
                    creditLine.CreditLineStatus = ConstStr.FACTOR_CREDIT_LINE.EXPIRY;
                }
                else
                {
                    creditLine.CreditLineStatus = ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY;
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
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (FactorCreditLine fcl in factor.FactorCreditLines)
                        {
                            if (fcl != creditLine && fcl.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY)
                            {
                                fcl.CreditLineStatus = ConstStr.FACTOR_CREDIT_LINE.EXPIRY;
                            }
                        }

                        context.SubmitChanges();
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
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (creditLine.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY)
                    {
                        foreach (FactorCreditLine fcl in factor.FactorCreditLines)
                        {
                            if (fcl != creditLine && fcl.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.AVAILABILITY)
                            {
                                fcl.CreditLineStatus = ConstStr.FACTOR_CREDIT_LINE.EXPIRY;
                            }
                        }

                        context.SubmitChanges();
                    }
                }
            }
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
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
                factor.FactorGroup = factorMgr.Selected;
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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (creditLine.CreditLineStatus == ConstStr.FACTOR_CREDIT_LINE.FREEZE)
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
        private void UpdateFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBoxEx.Show("请首先选定一个机构", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        #endregion Methods
    }
}
