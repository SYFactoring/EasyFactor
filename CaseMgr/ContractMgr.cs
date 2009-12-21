
namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.DB.dbml;
    using System.Data.SqlClient;
    using System.Threading;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;

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

            string cid = (string)dgvContracts["ContractCodeColumn", dgvContracts.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == cid);
                if (selectedContract != null)
                {
                    if (MessageBox.Show("是否打算删除合同: " + selectedContract.ContractCode, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        App.Current.DbContext.Contracts.DeleteOnSubmit(selectedContract);
                        try
                        {
                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("不能删除此合同", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

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

            string cid = (string)dgvContracts["ContractCodeColumn", dgvContracts.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Contract selectedContract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == cid);
                if (selectedContract != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedContract.Client, ClientDetail.OpContractType.DETAIL_CONTRACT);
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

            string cid = (string)dgvContracts["ContractCodeColumn", dgvContracts.SelectedRows[0].Index].Value;
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
            var queryResult = App.Current.DbContext.Contracts.Where(c =>
                c.ContractCode.Contains(this.tbContractCode.Text));

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

            string cid = (string)dgvContracts["ContractCodeColumn", dgvContracts.SelectedRows[0].Index].Value;
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

            string cid = (string)dgvContracts["ContractCodeColumn", dgvContracts.SelectedRows[0].Index].Value;
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
    }
}
