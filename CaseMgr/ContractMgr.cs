//-----------------------------------------------------------------------
// <copyright file="ContractMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.CaseMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContractMgr : UserControl
    {
        #region OpContractType enum

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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private OpContractType _opType;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="opType"></param>
        public ContractMgr(OpContractType opType)
            : this()
        {
            _opType = opType;
            if (opType == OpContractType.DUE)
            {
                Context = new DBDataContext();
                IQueryable<Contract> queryResult =
                    Context.Contracts.Where(
                        c => c.ContractStatus == CONTRACT.AVAILABILITY && c.ContractDueDate < DateTime.Today);

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ContractMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvContracts.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvContracts.DataSource = _bs;
            ControlUtil.SetDoubleBuffered(dgvContracts);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            UpdateContextMenu();
        }


        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected Client
        /// </summary>
        public Contract Selected { get; set; }


        //?Private?Methods?(9)?
        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailContract(sender, e);
            }
            else
            {
                SelectContract(sender, e);
            }
        }

        /// <summary>
        /// Delete selected contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedContract = (Contract) _bs.List[dgvContracts.SelectedRows[0].Index];
            if (
                MessageBoxEx.Show("是否打算删除保理合同: " + selectedContract.ContractCode, MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            try
            {
                Context.Contracts.DeleteOnSubmit(selectedContract);
                Context.SubmitChanges();
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
        private void DetailContract(object sender, EventArgs e)
        {
            if (dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedContract = (Contract) _bs.List[dgvContracts.SelectedRows[0].Index];
            var clientDetail = new ClientDetail(selectedContract, ClientDetail.OpContractType.DETAIL_CONTRACT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvContractsCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvContracts.Columns[e.ColumnIndex];
            if (column == colIsSigned)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    var result = (bool) originalData;
                    e.Value = result ? "Y" : "N";
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvContractsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvContracts.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvContracts.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvContracts.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new Contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedContract = (Contract) _bs.List[dgvContracts.SelectedRows[0].Index];
            var clientDetail = new ClientDetail(selectedContract.Client, ClientDetail.OpContractType.NEW_CONTRACT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContracts(object sender, EventArgs e)
        {
            string contractCode = tbContractCode.Text;
            string clientName = tbClientName.Text;
            string contractStatus = cbContractStatus.Text;
            string createUserName = tbCreateUserName.Text;

            Context = new DBDataContext();
            if (!PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
            {
                Context.ObjectTrackingEnabled = false;
            }

            IQueryable<Contract> queryResult = from contract in Context.Contracts
                                               let client = contract.Client
                                               where
                                                   client.ClientNameCN.Contains(clientName) ||
                                                   client.ClientNameEN.Contains(clientName)
                                               where (contract.ContractCode.Contains(contractCode))
                                                     &&
                                                     (String.IsNullOrEmpty(contractStatus)
                                                          ? true
                                                          : contract.ContractStatus == contractStatus)
                                                     && (contract.CreateUserName.Contains(createUserName))
                                               select contract;

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select contract and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectContract(object sender, EventArgs e)
        {
            if (dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedContract = (Contract) _bs.List[dgvContracts.SelectedRows[0].Index];
            Selected = selectedContract;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
            {
                menuItemContractNew.Enabled = true;
                menuItemContractDelete.Enabled = true;
            }
            else
            {
                menuItemContractNew.Enabled = false;
                menuItemContractDelete.Enabled = false;
            }
        }
    }
}