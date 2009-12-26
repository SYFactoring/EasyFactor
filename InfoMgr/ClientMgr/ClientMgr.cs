//-----------------------------------------------------------------------
// <copyright file="ClientMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// Client Management User Interface
    /// </summary>
    public partial class ClientMgr : UserControl
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

        private OpClientMgrType opClientMgrType;

        public enum OpClientMgrType
        {
            NEED_CONTRACT
        }

        public ClientMgr(OpClientMgrType clientMgrType)
            : this(false)
        {
            this.opClientMgrType = clientMgrType;
            if (clientMgrType == OpClientMgrType.NEED_CONTRACT)
            {
                this.cbIsSigned.Checked = true;
                this.cbIsSigned.Enabled = false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ClientMgr class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public ClientMgr(bool isEditable)
        {
            this.InitializeComponent();
            this.isEditable = isEditable;
            this.UpdateEditableStatus();
            ControlUtil.SetDoubleBuffered(this.dgvClients);

            List<Department> deptsList = Department.AllDepartments().ToList();
            deptsList.Insert(0, new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" });
            this.cbDepartment.DataSource = deptsList;
            this.cbDepartment.DisplayMembers = "DepartmentName";
            this.cbDepartment.ValueMember = "DepartmentCode";
            this.cbDepartment.GroupingMembers = "Domain";
            this.cbDepartment.SelectedIndex = -1;
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
        public Client Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (12)

        // Private Methods (12) 

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailClient(sender, e);
            }
            else
            {
                this.SelectClient(sender, e);
            }
        }

        /// <summary>
        /// Delete selected Client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteClient(object sender, System.EventArgs e)
        {
            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvClients["clientEDICodeColumn", dgvClients.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == cid);
                if (selectedClient != null)
                {
                    if (MessageBox.Show("是否打算删除客户: " + selectedClient.ClientNameCN, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        App.Current.DbContext.Clients.DeleteOnSubmit(selectedClient);
                        try
                        {
                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("不能删除此客户,已存在相关额度.", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        dgvClients.Rows.RemoveAt(dgvClients.SelectedRows[0].Index);
                    }
                }
            }
        }

        /// <summary>
        /// Show detail info of selected client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailClient(object sender, System.EventArgs e)
        {
            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvClients["clientEDICodeColumn", dgvClients.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == cid);
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpClientType.DETAIL_CLIENT);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClients(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS);
            importForm.Show();
        }

        /// <summary>
        /// Create a new client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewClient(object sender, System.EventArgs e)
        {
            ClientDetail clientDetail = new ClientDetail(null, ClientDetail.OpClientType.NEW_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClientCreditLine(object sender, System.EventArgs e)
        {
            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvClients["clientEDICodeColumn", dgvClients.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == cid);
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewContract(object sender, EventArgs e)
        {
            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvClients["clientEDICodeColumn", dgvClients.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == cid);
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpContractType.NEW_CONTRACT);
                    clientDetail.ShowDialog(this);
                }
            }

        }

        /// <summary>
        /// Query client according to condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryClients(object sender, System.EventArgs e)
        {
            string clientType = string.Empty;
            if (cbClientType.SelectedIndex >= 0)
            {
                clientType = cbClientType.Items[cbClientType.SelectedIndex].ToString();
                if ("全部".Equals(clientType))
                {
                    clientType = string.Empty;
                }
            }

            string department = string.Empty;
            if (cbDepartment.SelectedIndex >= 0)
            {
                department = cbDepartment.SelectedValue.ToString();
                if (department == "CN01300")
                {
                    department = string.Empty;
                }
            }

            var queryResult = App.Current.DbContext.Clients.Where(c =>
                    ((c.BranchCode == null ? string.Empty : c.BranchCode).Contains(department))
                  && ((c.PMName == null ? string.Empty : c.PMName).Contains(tbPM.Text))
                  && ((c.RMName == null ? string.Empty : c.RMName).Contains(tbRM.Text))
                  && (((c.ClientNameCN == null ? string.Empty : c.ClientNameCN).Contains(tbClientName.Text)) || ((c.ClientNameEN_1 == null ? string.Empty : c.ClientNameEN_1).Contains(tbClientName.Text)) || ((c.ClientNameEN_2 == null ? string.Empty : c.ClientNameEN_2).Contains(tbClientName.Text)))
                  && ((c.ClientEDICode == null ? string.Empty : c.ClientEDICode).Contains(tbClientEDICode.Text))
                  && (c.ClientType.Contains(clientType))
                  && (this.cbIsSigned.Checked == false ? true : c.Contracts.Any(con => con.ContractStatus == "已生效"))
                  );

            this.bs.DataSource = queryResult;
            this.dgvClients.DataSource = bs;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select client and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectClient(object sender, System.EventArgs e)
        {
            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvClients["clientEDICodeColumn", dgvClients.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == cid);
                if (selectedClient != null)
                {
                    this.Selected = selectedClient;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Update selected client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateClient(object sender, System.EventArgs e)
        {
            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            string cid = (string)dgvClients["clientEDICodeColumn", dgvClients.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == cid);
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpClientType.UPDATE_CLIENT);
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
                this.menuItemClientNew.Enabled = true;
                this.menuItemClientCreditLineNew.Enabled = true;
                this.menuItemContractNew.Enabled = true;
                this.menuItemClientUpdate.Enabled = true;
                this.menuItemClientDelete.Enabled = true;
                this.menuItemClientImport.Enabled = true;
            }
            else
            {
                this.menuItemClientNew.Enabled = false;
                this.menuItemClientCreditLineNew.Enabled = false;
                this.menuItemContractNew.Enabled = false;
                this.menuItemClientUpdate.Enabled = false;
                this.menuItemClientDelete.Enabled = false;
                this.menuItemClientImport.Enabled = false;
            }
        }

        #endregion Methods
    }
}
