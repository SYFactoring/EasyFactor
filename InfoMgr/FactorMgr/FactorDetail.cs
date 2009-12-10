using CMBC.EasyFactor.DB.dbml;
using System.Windows.Forms;
using System.Linq;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using System;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class FactorDetail : DevComponents.DotNetBar.Office2007Form
    {
        public enum OpType { NEW_FACTOR, UPDATE_FACTOR, DETAIL_FACTOR, UPDATE_FACTOR_CREDIT_COVER };

        private readonly OpType opType;

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor">selected factor</param>
        /// <param name="opType"></param>
        public FactorDetail(Factor factor, OpType opType)
        {
            InitializeComponent();
            InitComboBox();
            this.opType = opType;
            if (opType == OpType.NEW_FACTOR)
            {
                factorBindingSource.DataSource = new Factor();
            }
            else
            {
                factorBindingSource.DataSource = factor;
                this.FillForms(factor);
            }
            this.UpdateEditableStatus();
        }

        private void InitComboBox()
        {
            this.countryNameComboBox.DataSource = App.Current.DbContext.Countries;
            this.countryNameComboBox.DisplayMember = "CountryNameEN";
            this.countryNameComboBox.ValueMember = "CountryNameEN";

            this.creditLineCurrencyComboBox.DataSource = App.Current.DbContext.Currencies;
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";

            string[] factorTypes = { "保理商", "保险公司", "监管机构", "代付行" };
            this.factorTypeComboBox.DataSource = factorTypes;
        }

        private void FillForms(Factor factor)
        {
            this.factorTypeComboBox.SelectedItem = factor.FactorType;
            this.countryNameComboBox.SelectedItem = App.Current.DbContext.Countries.SingleOrDefault(c => c.CountryNameEN == factor.CountryName);
        }
        /// <summary>
        /// udpate editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (opType == OpType.NEW_FACTOR || opType == OpType.UPDATE_FACTOR)
            {
                foreach (Control comp in this.groupPanelBasic.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelContacts.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelMembership.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.setComponetEditable(comp, true);
                }
                ControlUtil.setComponetEditable(this.btnFactorSave, true);
                ControlUtil.setComponetEditable(this.btnFactorCancel, true);
            }
            else if (opType == OpType.DETAIL_FACTOR)
            {
                foreach (Control comp in this.groupPanelBasic.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelContacts.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelMembership.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    ControlUtil.setComponetEditable(comp, false);
                }
                ControlUtil.setComponetEditable(this.btnFactorSave, false);
                ControlUtil.setComponetEditable(this.btnFactorCancel, true);
            }

        }

        /// <summary>
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void FactorCancel(object sender, System.EventArgs e)
        {
            Close();
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
            if (opType == OpType.NEW_FACTOR)
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
                }
            }
        }
    }
}
