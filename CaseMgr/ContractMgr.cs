//-----------------------------------------------------------------------
// <copyright file="ContractMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ContractMgr : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        private DBDataContext context;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public ContractMgr()
        {
            this.InitializeComponent();
            this.dgvContracts.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvContracts.DataSource = bs;
            ControlUtil.SetDoubleBuffered(this.dgvContracts);

            this.UpdateContextMenu();

            this.context = new DBDataContext();
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected Client
        /// </summary>
        public Contract Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (8)

        // Private Methods (8) 

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailContract(sender, e);
            }
            else
            {
                this.SelectContract(sender, e);
            }
        }

        /// <summary>
        /// Delete selected contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteContract(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            Contract selectedContract = (Contract)this.bs.List[this.dgvContracts.SelectedRows[0].Index];
            if (MessageBox.Show("是否打算删除保理合同: " + selectedContract.ContractCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                context.Contracts.DeleteOnSubmit(selectedContract);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvContracts.Rows.RemoveAt(dgvContracts.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Show detail info of selected contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailContract(object sender, System.EventArgs e)
        {
            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            Contract selectedContract = (Contract)this.bs.List[this.dgvContracts.SelectedRows[0].Index];
            ClientDetail clientDetail = new ClientDetail(selectedContract, ClientDetail.OpContractType.DETAIL_CONTRACT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvContracts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvContracts.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvContracts.RowHeadersDefaultCellStyle.Font, rectangle, dgvContracts.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new Contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewContract(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            Contract selectedContract = (Contract)this.bs.List[this.dgvContracts.SelectedRows[0].Index];
            ClientDetail clientDetail = new ClientDetail(selectedContract.Client, ClientDetail.OpContractType.NEW_CONTRACT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContracts(object sender, EventArgs e)
        {
            string contractCode = this.tbContractCode.Text;
            string clientName = this.tbClientName.Text;
            string contractStatus = this.cbContractStatus.Text;
            string createUserName = this.tbCreateUserName.Text;

            var queryResult = from contract in context.Contracts
                              let client = contract.Client
                              where client.ClientNameCN.Contains(clientName) || client.ClientNameEN.Contains(clientName)
                              where (contract.ContractCode.Contains(contractCode))
                              && (contractStatus == string.Empty ? true : contract.ContractStatus == contractStatus)
                              && (contract.CreateUserName.Contains(createUserName))
                              select contract;

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select contract and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectContract(object sender, System.EventArgs e)
        {
            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            Contract selectedContract = (Contract)this.bs.List[this.dgvContracts.SelectedRows[0].Index];
            this.Selected = selectedContract;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permission.BASICINFO_UPDATE))
            {
                this.menuItemContractNew.Enabled = true;
                this.menuItemContractDelete.Enabled = true;
            }
            else
            {
                this.menuItemContractNew.Enabled = false;
                this.menuItemContractDelete.Enabled = false;
            }
        }

        #endregion Methods
    }
}
