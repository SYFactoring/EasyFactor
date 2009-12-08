using CMBC.EasyFactor.DB.dbml;
using System.Windows.Forms;
using System.Linq;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using System;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class FactorDetail : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// flag indicates if add 
        /// </summary>
        private readonly bool isAdd;

        /// <summary>
        /// variable save original factor
        /// </summary>
        private readonly Factor originalFactor;

        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the FactorDetail class
        /// </summary>
        /// <param name="factor">selected factor</param>
        /// <param name="isEditable">true if editable</param>
        public FactorDetail(Factor factor, bool isEditable)
        {
            InitializeComponent();
            Factor updateFactor = new Factor();
            if (factor == null)
            {
                this.isAdd = true;
            }
            else
            {
                this.originalFactor = factor;
                updateFactor.Copy(factor);
            }

            factorBindingSource.DataSource = updateFactor;

            this.countryNameComboBox.DataSource = App.Current.DbContext.Countries;
            this.countryNameComboBox.DisplayMember = "CountryNameEN";
            this.countryNameComboBox.ValueMember = "CountryNameEN";

            this.creditLineCurrencyComboBox.DataSource = App.Current.DbContext.Currencies;
            this.creditLineCurrencyComboBox.DisplayMember = "CurrencyFormat";
            this.creditLineCurrencyComboBox.ValueMember = "CurrencyCode";

            string[] factorTypes = { "保理商", "保险公司", "监管机构", "代付行" };
            this.factorTypeComboBox.DataSource = factorTypes;

            this.factorTypeComboBox.SelectedItem = updateFactor.FactorType;
            this.countryNameComboBox.SelectedItem = App.Current.DbContext.Countries.FirstOrDefault(c => c.CountryNameEN == updateFactor.CountryName);
            this.UpdateEditableStatus(isEditable);
        }

        /// <summary>
        /// udpate editable status
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        private void UpdateEditableStatus(bool isEditable)
        {
            if (!isEditable)
            {
                foreach (Control comp in this.groupPanelBasic.Controls)
                {
                    setComponetEditable(comp, isEditable);
                }
                foreach (Control comp in this.groupPanelContacts.Controls)
                {
                    setComponetEditable(comp, isEditable);
                }
                foreach (Control comp in this.groupPanelMembership.Controls)
                {
                    setComponetEditable(comp, isEditable);
                }
                foreach (Control comp in this.groupPanelCreditLineDetail.Controls)
                {
                    setComponetEditable(comp, isEditable);
                }
                setComponetEditable(this.btnFactorSave, isEditable);
                setComponetEditable(this.btnFactorCancel, isEditable);
            }
        }

        private void setComponetEditable(Control comp, bool isEditable)
        {
            if (comp is TextBoxX)
            {
                (comp as TextBoxX).ReadOnly = !isEditable;
            }
            else if (comp is ButtonX)
            {
                (comp as ButtonX).Enabled = isEditable;
            }
            else if (comp is ComboBoxEx)
            {
                (comp as ComboBoxEx).Enabled = isEditable;
            }
            else if (comp is DateTimePicker)
            {
                (comp as DateTimePicker).Enabled = isEditable;
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
            Factor updateFactor = (Factor)factorBindingSource.DataSource;
            if (this.isAdd)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Factors.InsertOnSubmit(updateFactor);
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
                    Close();
                }
            }
            else
            {
                bool isUpdateOK = true;
                Factor tempFactor = new Factor();
                tempFactor.Copy(this.originalFactor);
                this.originalFactor.Copy(updateFactor);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    this.originalFactor.Copy(tempFactor);
                    MessageBox.Show(e2.Message);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

    }
}
