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
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class ContractMgr : UserControl
    {
		#region?Fields?(2)?

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpContractType opType;

		#endregion?Fields?

		#region?Enums?(1)?

        /// <summary>
        /// 
        /// </summary>
        public enum OpContractType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            DUE,
        }

		#endregion?Enums?

		#region?Constructors?(2)?

/// <summary>
        /// 
        /// </summary>
        /// <param name="opType"></param>
        public ContractMgr(OpContractType opType)
            : this()
        {
            this.opType = opType;
            if (opType == OpContractType.DUE)
            {
                context = new DBDataContext();
                var queryResult = context.Contracts.Where(c => c.ContractStatus == CONTRACT.AVAILABILITY && c.ContractDueDate < DateTime.Now.Date);

                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ContractMgr()
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvContracts.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvContracts.DataSource = bs;
            ControlUtil.SetDoubleBuffered(this.dgvContracts);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.UpdateContextMenu();
        }

		#endregion?Constructors?

		#region?Properties?(3)?

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

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

		#endregion?Properties?

		#region?Methods?(9)?

		//?Private?Methods?(9)?

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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            Contract selectedContract = (Contract)this.bs.List[this.dgvContracts.SelectedRows[0].Index];
            if (MessageBoxEx.Show("是否打算删除保理合同: " + selectedContract.ContractCode, MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void dgvContracts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvContracts.Columns[e.ColumnIndex];
            if (column == colIsSigned)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    bool result = (bool)originalData;
                    if (result)
                    {
                        e.Value = "Y";
                    }
                    else
                    {
                        e.Value = "N";
                    }
                }
            }
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
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
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

            context = new DBDataContext();
            if (!PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
            {
                context.ObjectTrackingEnabled = false;
            }

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
            if (PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
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

		#endregion?Methods?
    }
}
