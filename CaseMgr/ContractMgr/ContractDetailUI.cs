//-----------------------------------------------------------------------
// <copyright file="ContractDetailUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr.ContractMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// Contract Detail User Interface
    /// </summary>
    public partial class ContractDetailUI : Form
    {
        /// <summary>
        /// flag indicates if add
        /// </summary>
        private readonly bool isAdd;

        /// <summary>
        /// origianl contract
        /// </summary>
        private readonly Contract originalContract;

        /// <summary>
        /// Initializes a new instance of the ContractDetailUI class
        /// </summary>
        /// <param name="contract">selected contract</param>
        /// <param name="isEditable">true if editable</param>
        public ContractDetailUI(Contract contract, bool isEditable)
        {
            this.InitializeComponent();
            Contract updateContract = new Contract();
            if (contract == null)
            {
                this.isAdd = true;
            }
            else
            {
                this.originalContract = contract;
                updateContract.Copy(contract);
            }

            this.contractBindingSource.DataSource = updateContract;
            this.UpdateEditableStatus(isEditable);
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        private void UpdateEditableStatus(bool isEditable)
        {
            if (!isEditable)
            {
                
                // TODO fill other fields
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
            }
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Save(object sender, EventArgs e)
        {
            this.contractBindingSource.EndEdit();
            Contract updateContract = (Contract)this.contractBindingSource.DataSource;
            if (this.isAdd)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Contracts.InsertOnSubmit(updateContract);
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
                Contract tempContract = new Contract();
                tempContract.Copy(this.originalContract);
                this.originalContract.Copy(updateContract);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    this.originalContract.Copy(tempContract);
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
        /// Load data when form load
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ContractDetailUI_Load(object sender, EventArgs e)
        {
            this.cbInvoiceCurrency.DataSource = App.Current.DbContext.Currencies;
            this.cbHandFeeCurr.DataSource = App.Current.DbContext.Currencies;
        }
    }
}
