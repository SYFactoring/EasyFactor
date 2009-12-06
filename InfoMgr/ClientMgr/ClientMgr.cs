//-----------------------------------------------------------------------
// <copyright file="ClientMgrUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;

    /// <summary>
    /// Client Management User Interface
    /// </summary>
    public partial class ClientMgr : UserControl
    {
        /// <summary>
        /// flag indicates if editable
        /// </summary>
        private readonly bool isEditable;

        /// <summary>
        /// form owner
        /// </summary>
        private Form owner;

        /// <summary>
        /// Initializes a new instance of the ClientMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public ClientMgr(bool isEditable)
        {
            InitializeComponent();
            this.isEditable = isEditable;
            this.UpdateEditableStatus();
        }

        /// <summary>
        /// Initializes a new instance of the ClientMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        /// <param name="owner">form owner</param>
        public ClientMgr(bool isEditable, Form owner)
            : this(isEditable)
        {
            this.owner = owner;
        }

        /// <summary>
        /// Gets or sets selected Client
        /// </summary>
        public Client Selected
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
        /// Query client according to condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Query(object sender, System.EventArgs e)
        {
            
            // TODO Need fix this
            var queryResult = App.Current.DbContext.Clients.Where(c =>
                 (tbDepartment.Text == string.Empty || c.Department.DepartmentName.Contains(tbDepartment.Text))
              && (tbPM.Text == string.Empty || c.PMName.Contains(tbPM.Text))
              && (tbRM.Text == string.Empty || c.RMName.Contains(tbRM.Text))
              && (tbClientName.Text == string.Empty || c.ClientNameCN.Contains(tbClientName.Text))
              && (tbClientName.Text == string.Empty || c.ClientNameEN_1.Contains(tbClientName.Text))
              && (tbClientName.Text == string.Empty || c.ClientNameEN_2.Contains(tbClientName.Text))
              && (tbClientNo.Text == string.Empty || c.ClientNo.Contains(tbClientNo.Text))
              && (cbClientType.Text == string.Empty || c.ClientType.Equals(cbClientType.Text)));

            clientMgrBindingSource.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Create a new client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemNew(object sender, System.EventArgs e)
        {
            ClientDetail clientDetail = new ClientDetail((Client)null, true);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// Update selected client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemUpdate(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientNoColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientNo == cid);
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, true);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        private void ItemUpdateCreditLine(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientNoColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientNo == cid);
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, true, true);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Delete selected Client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDelete(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || this.clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientNoColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientNo == cid);
                if (selectedClient != null)
                {
                    if (MessageBox.Show("是否打算删除客户: " + selectedClient.ClientNameCN, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        clientMgrBindingSource.Remove(selectedClient);
                        App.Current.DbContext.Clients.DeleteOnSubmit(selectedClient);
                        App.Current.DbContext.SubmitChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Select client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemSelect(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || this.clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientNoColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientNo == cid);
                if (selectedClient != null)
                {
                    this.Selected = selectedClient;
                    if (this.owner == null)
                    {
                        this.owner = (Form)this.Parent.Parent;
                    }
                    if (this.owner != null)
                    {
                        this.owner.DialogResult = DialogResult.Yes;
                        this.owner.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Show detail info of selected client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDetail(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || this.clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientNoColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientNo == cid);
                if (selectedClient != null)
                {
                    new ClientDetail(selectedClient, false).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        //private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    this.ItemDetail(sender, e);
        //}

        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || this.clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientNoColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientNo == cid);
                if (selectedClient != null)
                {
                    new ClientDetail(selectedClient, false).ShowDialog(this);
                }
            }
        }
    }
}
