//-----------------------------------------------------------------------
// <copyright file="ContractMgrUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ContractMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// Contract Management User Interface
    /// </summary>
    public partial class ContractMgrUI : UserControl
    {
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private readonly bool isEditable;

        /// <summary>
        /// form owner
        /// </summary>
        private readonly Form owner;

        /// <summary>
        /// Initializes a new instance of the ContractMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public ContractMgrUI(bool isEditable)
        {
            this.isEditable = isEditable;
            this.InitializeComponent();
            this.UpdateEditableStatus();
        }

        /// <summary>
        /// Initializes a new instance of the ContractMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        /// <param name="owner">owner form</param>
        public ContractMgrUI(bool isEditable, Form owner)
            : this(isEditable)
        {
            this.owner = owner;
        }

        /// <summary>
        /// Gets or sets selected contract
        /// </summary>
        public Contract Selected
        {
            get;
            set;
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (this.isEditable)
            {
                return;
            }

            this.toolStripSeparator.Visible = false;
            this.menuItemEdit.Visible = false;
        }

        /// <summary>
        /// Query contracts according condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Query(object sender, EventArgs e)
        {
            string contractNo = this.tbContractNo.Text.Trim();
            
            // TODO checkbox如何返回选择ID？
            var branchID = this.cbBranch.SelectedText;
            string seller = this.tbSeller.Text.Trim();
            string buyer = this.tbBuyer.Text.Trim();

            var queryResult = App.Current.DbContext.Contracts.Where(c =>
                                                 (contractNo == string.Empty || c.ContractNo == contractNo)
                                                   && (seller == string.Empty || c.SellerClient.ClientNameCN.Contains(seller))
                                                   && (buyer == string.Empty || c.BuyerClient.ClientNameCN.Contains(buyer)));
            this.dgvContract.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Show detail info about selected contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDetail(object sender, System.EventArgs e)
        {
            if (this.dgvContract.SelectedRows.Count == 0 || this.contractBindingSource == null)
            {
                return;
            }

            string cNo = (string)this.dgvContract["contractNoColumn", this.dgvContract.SelectedRows[0].Index].Value;
            if (cNo != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.First(c => c.ContractNo == cNo);
                if (selectedContract != null)
                {
                    new ContractDetailUI(selectedContract, false).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Add a new contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemNew(object sender, System.EventArgs e)
        {
            new ContractDetailUI(null, true).ShowDialog(this);
        }

        /// <summary>
        /// Update selected contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemUpdate(object sender, System.EventArgs e)
        {
            if (this.dgvContract.SelectedRows.Count == 0 || this.contractBindingSource == null)
            {
                return;
            }

            string cNo = (string)this.dgvContract["contractNoColumn", this.dgvContract.SelectedRows[0].Index].Value;
            if (cNo != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.First(c => c.ContractNo == cNo);
                if (selectedContract != null)
                {
                    new ContractDetailUI(selectedContract, true).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Delete the selected contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDelete(object sender, System.EventArgs e)
        {
            if (this.dgvContract.SelectedRows.Count == 0 || this.contractBindingSource == null)
            {
                return;
            }

            string cNo = (string)this.dgvContract["contractNoColumn", this.dgvContract.SelectedRows[0].Index].Value;
            if (cNo != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.First(c => c.ContractNo == cNo);
                if (selectedContract != null && MessageBox.Show("是否确定删除合同: " + cNo, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    App.Current.DbContext.Contracts.DeleteOnSubmit(selectedContract);
                    App.Current.DbContext.SubmitChanges();
                    this.contractBindingSource.Remove(selectedContract);
                }
            }
        }

        /// <summary>
        /// Select the current contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemSelect(object sender, EventArgs e)
        {
            if (this.dgvContract.SelectedRows.Count == 0 || this.contractBindingSource == null)
            {
                return;
            }

            string cNo = (string)this.dgvContract["contractNoColumn", this.dgvContract.SelectedRows[0].Index].Value;
            if (cNo != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.First(c => c.ContractNo == cNo);
                if (selectedContract != null)
                {
                    this.Selected = selectedContract;
                    if (this.owner != null)
                    {
                        this.owner.DialogResult = DialogResult.Yes;
                        this.owner.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ItemDetail(sender, e);
        }
    }
}
