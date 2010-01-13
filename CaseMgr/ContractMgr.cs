//-----------------------------------------------------------------------
// <copyright file="ContractMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.Utils;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public partial class ContractMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private bool isEditable;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public ContractMgr(bool isEditable)
        {
            this.InitializeComponent();
            this.isEditable = isEditable;
            this.dgvContracts.AutoGenerateColumns = false;
            this.UpdateEditableStatus();
            ControlUtil.SetDoubleBuffered(this.dgvContracts);
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

        #region Methods (10)

        // Private Methods (10) 

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
            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvContracts["colContractCode", dgvContracts.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Contract contract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == cid);
                if (contract != null)
                {
                    if (MessageBox.Show("是否打算删除保理合同: " + contract.ContractCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        return;
                    }
                    bool isDeleteOK = true;
                    try
                    {
                        var CDAList = App.Current.DbContext.CDAs.Where(c => c.CDACode.StartsWith(contract.ContractCode));
                        foreach (CDA cda in CDAList)
                        {
                            foreach (InvoiceAssignBatch assignBatch in cda.InvoiceAssignBatches)
                            {
                                App.Current.DbContext.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                            }
                            App.Current.DbContext.InvoiceAssignBatches.DeleteAllOnSubmit(cda.InvoiceAssignBatches);
                            App.Current.DbContext.InvoiceFinanceBatches.DeleteAllOnSubmit(cda.InvoiceFinanceBatches);
                            App.Current.DbContext.InvoicePaymentBatches.DeleteAllOnSubmit(cda.InvoicePaymentBatches);
                        }
                        App.Current.DbContext.CDAs.DeleteAllOnSubmit(CDAList);
                        App.Current.DbContext.Contracts.DeleteOnSubmit(contract);
                        App.Current.DbContext.SubmitChanges();
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

            string cid = (string)dgvContracts["colContractCode", dgvContracts.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == cid);
                if (selectedContract != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedContract, ClientDetail.OpContractType.DETAIL_CONTRACT);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportContracts(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(this.ImportContractsImpl);
                t.Start(fileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void ImportContractsImpl(object obj)
        {

        }

        /// <summary>
        /// Create a new Contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewContract(object sender, System.EventArgs e)
        {
            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvContracts["colContractCode", dgvContracts.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == cid);
                if (selectedContract != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedContract.Client, ClientDetail.OpContractType.NEW_CONTRACT);
                    clientDetail.ShowDialog(this);
                }
            }
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

            var queryResult = from contract in App.Current.DbContext.Contracts
                              let client = contract.Client
                              where client.ClientNameCN.Contains(clientName) || client.ClientNameEN_1.Contains(clientName) || client.ClientNameEN_2.Contains(clientName)
                              where contract.ContractCode.Contains(contractCode)
                              && contractStatus == string.Empty ? true : contract.ContractStatus == contractStatus
                              select contract;

            this.bs.DataSource = queryResult;
            this.dgvContracts.DataSource = this.bs;
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

            string cid = (string)dgvContracts["colContractCode", dgvContracts.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == cid);
                if (selectedContract != null)
                {
                    this.Selected = selectedContract;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Update selected contract
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateContract(object sender, System.EventArgs e)
        {
            if (this.dgvContracts.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvContracts["colContractCode", dgvContracts.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == cid);
                if (selectedContract != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedContract.Client, ClientDetail.OpContractType.UPDATE_CONTRACT);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (this.isEditable)
            {
                this.menuItemContractNew.Enabled = true;
                this.menuItemContractUpdate.Enabled = true;
                this.menuItemContractDelete.Enabled = true;
                this.menuItemContractImport.Enabled = true;
            }
            else
            {
                this.menuItemContractNew.Enabled = false;
                this.menuItemContractUpdate.Enabled = false;
                this.menuItemContractDelete.Enabled = false;
                this.menuItemContractImport.Enabled = false;
            }
        }

        #endregion Methods

        private void dgvContracts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.dgvContracts.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvContracts.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvContracts.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
