//-----------------------------------------------------------------------
// <copyright file="FactorDetial.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class FactorDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private OpFactorCreditLineType opFactorCreditLineType;
        /// <summary>
        /// 
        /// </summary>
        private OpFactorType opFactorType;

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
        /// <param name="opType"></param>
        private FactorDetail(Factor factor, OpFactorType opFactorType, OpFactorCreditLineType opFactorCreditLineType)
        {
            this.InitializeComponent();
            this.dgvFactorCreditLines.AutoGenerateColumns = false;

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
                factorBindingSource.DataSource = new Factor();
            }
            else
            {
                this.factorBindingSource.DataSource = factor;
                this.dgvFactorCreditLines.DataSource = factor.FactorCreditLines.ToList();
                factor.Backup();
            }

            this.UpdateFactorControlStatus();
            this.UpdateFactorCreditLineControlStatus();

            if (opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE)
            {
                this.tabControl.SelectedTab = this.tabItemFactorCreditLine;
                this.factorCreditLineBindingSource.DataSource = new FactorCreditLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorType"></param>
        public FactorDetail(Factor factor, OpFactorType opFactorType)
            : this(factor, opFactorType, OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="opFactorCreditLineType"></param>
        public FactorDetail(Factor factor, OpFactorCreditLineType opFactorCreditLineType)
            : this(factor, OpFactorType.DETAIL_FACTOR, opFactorCreditLineType)
        {
            this.tabControl.SelectedTab = this.tabItemFactorCreditLine;
        }

        #endregion Constructors

        #region Methods (15)

        // Private Methods (15) 

        /// <summary>
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CloseFactor(object sender, System.EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (opFactorType == OpFactorType.UPDATE_FACTOR)
            {
                factor.Restore();
            }

            if (this.opFactorCreditLineType == OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE)
            {
                if (this.factorCreditLineBindingSource.DataSource is FactorCreditLine)
                {
                    FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
                    if (creditLine.FactorCode != null)
                    {
                        creditLine.Restore();
                    }
                }
            }

            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                App.Current.DbContext.FactorCreditLines.DeleteOnSubmit(creditLine);
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show(e1.Message);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvFactorCreditLines.DataSource = factor.FactorCreditLines.ToList();
                this.ResetFactorCreditLine();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FactorDetail_Leave(object sender, EventArgs e)
        {
            this.CloseFactor(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreezeFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (creditLine.CreditLineStatus == "已生效")
            {
                this.freezeReasonTextBox.ReadOnly = false;
                this.freezeDateDateTimePicker.Enabled = true;
                creditLine.Freezer = App.Current.CurUser.Name;
                creditLine.FreezeDate = System.DateTime.Now;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.ResetFactorCreditLine();
            this.factorCreditLineBindingSource.DataSource = new FactorCreditLine();
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
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.dgvFactorCreditLines.DataSource = factor.FactorCreditLines.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ResetFactorCreditLine()
        {
            foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SaveFactor(object sender, System.EventArgs e)
        {

            Factor factor = (Factor)factorBindingSource.DataSource;

            if (this.opFactorType == OpFactorType.NEW_FACTOR)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Factors.InsertOnSubmit(factor);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    factor.Backup();
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
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    factor.Backup();
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
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null)
            {
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(this.factorCreditLineBindingSource.DataSource is FactorCreditLine))
            {
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;

            DateTime today = DateTime.Now;
            if (creditLine.PeriodBegin < today)
            {
                creditLine.CreditLineStatus = "已过期";
            }
            else
            {
                creditLine.CreditLineStatus = "已生效";
            }

            if (this.freezeDateDateTimePicker.Enabled)
            {
                creditLine.CreditLineStatus = "已冻结";
            }

            if (this.unfreezeDateDateTimePicker.Enabled)
            {
                if (creditLine.PeriodBegin < today)
                {
                    creditLine.CreditLineStatus = "已过期";
                }
                else
                {
                    creditLine.CreditLineStatus = "已生效";
                }
            }

            if (creditLine.CreditLineID == 0)
            {
                creditLine.Factor = factor;

                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.FactorCreditLines.InsertOnSubmit(creditLine);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.NewFactorCreditLine(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    creditLine.Backup();
                }
            }
            this.dgvFactorCreditLines.DataSource = factor.FactorCreditLines.ToList();
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

            int cid = (int)dgvFactorCreditLines["colCreditLineID", dgvFactorCreditLines.SelectedRows[0].Index].Value;
            if (cid != 0)
            {
                Factor factor = (Factor)this.factorBindingSource.DataSource;
                FactorCreditLine selectedFactorCreditLine = factor.FactorCreditLines.SingleOrDefault(c => c.CreditLineID == cid);
                if (selectedFactorCreditLine != null && this.factorCreditLineBindingSource.DataSource != selectedFactorCreditLine)
                {
                    this.ResetFactorCreditLine();
                    this.factorCreditLineBindingSource.DataSource = selectedFactorCreditLine;
                    this.btnFactorCreditLineFreeze.Enabled = true;
                    this.btnFactorCreditLineUnfreeze.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnfreezeFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (creditLine.CreditLineStatus == "已冻结")
            {
                this.unfreezeReasonTextBox.ReadOnly = false;
                this.unfreezeDateDateTimePicker.Enabled = true;
                creditLine.Unfreezer = App.Current.CurUser.Name;
                creditLine.UnfreezeDate = System.DateTime.Now;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateFactor(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null || factor.FactorCode == null)
            {
                MessageBox.Show("请首先选定一个机构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
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
