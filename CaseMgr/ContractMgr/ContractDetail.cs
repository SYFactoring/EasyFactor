
namespace CMBC.EasyFactor.CaseMgr.ContractMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ContractDetail : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private OpContractType opContractType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="opContractType"></param>
        public ContractDetail(Contract contract,OpContractType opContractType)
        {
            this.InitializeComponent();
            this.opContractType = opContractType;
            if (opContractType == OpContractType.NEW_CONTRACT)
            {
                this.contractBindingSource.DataSource = new Contract();
            }
            else
            {
                this.contractBindingSource.DataSource = contract;
                contract.Backup();
            }

            this.UpdateContractControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        public enum OpContractType
        {
            /// <summary>
            /// 
            /// </summary>
            NEW_CONTRACT,

            /// <summary>
            /// 
            /// </summary>
            UPDATE_CONTRACT,

            /// <summary>
            /// 
            /// </summary>
            DETAIL_CONTRACT
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContractControlStatus()
        {
            if (this.opContractType == OpContractType.DETAIL_CONTRACT)
            {
                foreach(Control comp in this.groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                foreach (Control comp in this.groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opContractType == OpContractType.UPDATE_CONTRACT)
            {
                foreach (Control comp in this.groupPanelContract.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                this.tbContractCode.ReadOnly = true;
            }

            Contract contract = (Contract)this.contractBindingSource.DataSource;
            if (contract.ClientEDICode != null)
            {
                this.tbClientName.Text = contract.Client.CityCN;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractUpdate(object sender, EventArgs e)
        {
            this.opContractType = OpContractType.UPDATE_CONTRACT;
            this.UpdateContractControlStatus();
        }

        /// <summary>
        /// Save current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ContractSave(object sender, EventArgs e)
        {
            this.contractBindingSource.EndEdit();
            Contract contract = (Contract)this.contractBindingSource.DataSource;

            if (this.opContractType == OpContractType.NEW_CONTRACT)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Contracts.InsertOnSubmit(contract);
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
                    contract.Backup();
                    this.opContractType = OpContractType.UPDATE_CONTRACT;
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
                    contract.Backup();
                }
            }
        }

        /// <summary>
        /// Cancel current editing
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ContractClose(object sender, EventArgs e)
        {
            Contract contract = (Contract)this.contractBindingSource.DataSource;
            if (this.opContractType == OpContractType.NEW_CONTRACT || this.opContractType == OpContractType.UPDATE_CONTRACT)
            {
                contract.Restore();
            }
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractDetail_Leave(object sender, EventArgs e)
        {
            this.ContractClose(sender, e);
        }
    }
}
