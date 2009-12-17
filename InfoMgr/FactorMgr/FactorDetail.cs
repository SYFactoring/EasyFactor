//-----------------------------------------------------------------------
// <copyright file="FactorDetial.cs" company="CISL@Fudan">
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
        /// <summary>
        /// 
        /// </summary>
        private OpFactorType opFactorType;

        /// <summary>
        /// 
        /// </summary>
        private OpFactorCreditLineType opFactorCreditLineType;

        public FactorDetail(Factor factor, OpFactorType opFactorType)
            : this(factor, opFactorType, OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE)
        {
        }

        public FactorDetail(Factor factor, OpFactorCreditLineType opFactorCreditLineType)
            : this(factor, OpFactorType.DETAIL_FACTOR, opFactorCreditLineType)
        {
        }
        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor">selected factor</param>
        /// <param name="opType"></param>
        public FactorDetail(Factor factor, OpFactorType opFactorType, OpFactorCreditLineType opFactorCreditLineType)
        {
            this.InitializeComponent();
            this.InitComboBox();
            this.opFactorType = opFactorType;
            this.opFactorCreditLineType = opFactorCreditLineType;
            if (opFactorType == OpFactorType.NEW_FACTOR)
            {
                factorBindingSource.DataSource = new Factor();
            }
            else
            {
                factorBindingSource.DataSource = factor;
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
        private void InitComboBox()
        {
            this.countryNameComboBox.DataSource = App.Current.DbContext.Countries;
            this.countryNameComboBox.DisplayMember = "CountryNameEN";
            this.countryNameComboBox.ValueMember = "CountryNameEN";
            this.countryNameComboBox.SelectedIndex = -1;

            this.creditLineCurrencyComboBox.DataSource = App.Current.DbContext.Currencies;
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";
            this.creditLineCurrencyComboBox.SelectedIndex = -1;
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

            Factor factor = (Factor)factorBindingSource.DataSource;
            if (factor.FactorCode != null)
            {
                foreach (Country country in this.countryNameComboBox.Items)
                {
                    if (country.CountryNameEN.Equals(factor.CountryName))
                    {
                        this.countryNameComboBox.SelectedItem = country;
                        break;
                    }
                }

                this.dgvFactorCreditLines.DataSource = factor.FactorCreditLines.ToList();
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

                this.freezeReasonTextBox.ReadOnly = true;
                this.freezerTextBox.ReadOnly = true;
                this.freezeDateDateTimePicker.Enabled = false;
                this.unfreezeReasonTextBox.ReadOnly = true;
                this.unfreezerTextBox.ReadOnly = true;
                this.unfreezeDateDateTimePicker.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FactorUpdate(object sender, EventArgs e)
        {
            this.opFactorType = OpFactorType.UPDATE_FACTOR;
            this.UpdateFactorControlStatus();
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void FactorSave(object sender, System.EventArgs e)
        {
            factorBindingSource.EndEdit();
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
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void FactorClose(object sender, System.EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (this.opFactorType == OpFactorType.NEW_FACTOR || opFactorType == OpFactorType.UPDATE_FACTOR)
            {
                factor.Restore();
            }

            if (this.opFactorCreditLineType == OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE || opFactorCreditLineType == OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE)
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
        private void RefreshFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor != null)
            {
                this.dgvFactorCreditLines.DataSource = factor.FactorCreditLines.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCreditLine(object sender, EventArgs e)
        {
            this.opFactorCreditLineType = OpFactorCreditLineType.UPDATE_FACTOR_CREDIT_LINE;
            this.UpdateFactorCreditLineControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactorCreditLine(object sender, EventArgs e)
        {
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
        private void SaveFactorCreditLine(object sender, EventArgs e)
        {
            Factor factor = (Factor)this.factorBindingSource.DataSource;
            if (factor == null)
            {
                MessageBox.Show("请首先选定一个机构", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;

            if (!this.freezerTextBox.Text.Equals(string.Empty) && creditLine.Freezer == null)
            {
                creditLine.Freezer = this.freezerTextBox.Text;
                creditLine.FreezeReason = this.freezeReasonTextBox.Text;
                creditLine.FreezeDate = this.freezeDateDateTimePicker.Value;
            }

            if (!this.unfreezerTextBox.Text.Equals(string.Empty) && creditLine.Unfreezer == null)
            {
                creditLine.Unfreezer = this.unfreezerTextBox.Text;
                creditLine.UnfreezeReason = this.unfreezeReasonTextBox.Text;
                creditLine.UnfreezeDate = this.unfreezeDateDateTimePicker.Value;
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
                    this.dgvFactorCreditLines.DataSource = factor.FactorCreditLines.ToList();
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFactorCreditLine(object sender, EventArgs e)
        {
            if (this.factorCreditLineBindingSource.DataSource is FactorCreditLine)
            {
                FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
                Factor factor = (Factor)this.factorCreditLineBindingSource.DataSource;
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
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FreezeFactorCreditLine(object sender, EventArgs e)
        {
            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
            this.freezeReasonTextBox.ReadOnly = false;
            if (creditLine.Freezer == null)
            {
                creditLine.Freezer = App.Current.CurUser.Name;
                creditLine.FreezeDate = System.DateTime.Now;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnfreezeFactorCreditLine(object sender, EventArgs e)
        {
            FactorCreditLine creditLine = (FactorCreditLine)this.factorCreditLineBindingSource.DataSource;
            this.unfreezeReasonTextBox.ReadOnly = false;
            if (creditLine.Unfreezer == null)
            {
                creditLine.Unfreezer = App.Current.CurUser.Name;
                creditLine.UnfreezeDate = System.DateTime.Now;
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

            int cid = (int)dgvFactorCreditLines["creditLineIDColumn", dgvFactorCreditLines.SelectedRows[0].Index].Value;
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
                    foreach (Country country in this.countryNameComboBox.Items)
                    {
                        if (country.CountryNameEN.Equals(factor.CountryName))
                        {
                            this.countryNameComboBox.SelectedItem = country;
                            break;
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
        private void FactorDetail_Leave(object sender, EventArgs e)
        {
            this.FactorClose(sender, e);
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

    }
}
