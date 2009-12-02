//-----------------------------------------------------------------------
// <copyright file="FactorDetailUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    
    /// <summary>
    /// Factor Detail User Interface
    /// </summary>
    public partial class FactorDetailUI : Form
    {
        /// <summary>
        /// flag indicates if add 
        /// </summary>
        private readonly bool isAdd;

        /// <summary>
        /// variable save original factor
        /// </summary>
        private readonly Factor originalFactor;

        /// <summary>
        /// Initializes a new instance of the FactorDetailUI class
        /// </summary>
        /// <param name="factor">selected factor</param>
        /// <param name="isEditable">true if editable</param>
        public FactorDetailUI(Factor factor, bool isEditable)
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
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                tbBranchName.ReadOnly = true;
                tbCityVisiting.ReadOnly = true;
                tbCompanyName.ReadOnly = true;
                tbContact1.ReadOnly = true;
                tbContact2.ReadOnly = true;
                cbCountry.Enabled = false;
                tbEmail.ReadOnly = true;
                tbFactorCode.ReadOnly = true;
                cbFactorType.Enabled = false;
                tbPostalCodePost.ReadOnly = true;
                tbTelefax1.ReadOnly = true;
                tbTelefax2.ReadOnly = true;
                tbTelephone1.ReadOnly = true;
                tbTelephone2.ReadOnly = true;
                tbVisitingAddress.ReadOnly = true;
                tbWebSite.ReadOnly = true;
            }
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Save(object sender, EventArgs e)
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

        /// <summary>
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Load related data when form load
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void FactorDetailUI_Load(object sender, EventArgs e)
        {
            cbCountry.DataSource = App.Current.DbContext.Countries;
        }
    }
}
