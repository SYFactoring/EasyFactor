﻿//-----------------------------------------------------------------------
// <copyright file="ClientMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Drawing;
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
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpClientMgrType opClientMgrType;

        private DBDataContext context;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpClientMgrType
        {
            /// <summary>
            /// 
            /// </summary>
            EXPORT_CLIENT,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CLIENT,

            /// <summary>
            /// 
            /// </summary>
            DOMINATE_CLIENT
        }

        #endregion Enums

        #region Constructors (3)

        /// <summary>
        /// Initializes a new instance of the ClientMgr class
        /// </summary>
        /// <param name="clientMgrType"></param>
        public ClientMgr(OpClientMgrType clientMgrType)
            : this(false)
        {
            this.opClientMgrType = clientMgrType;
            if (this.opClientMgrType == OpClientMgrType.DOMINATE_CLIENT)
            {
                this.cbCaseType.Text = "国内保理";
                this.QueryClients(null, null);
            }
            else if (this.opClientMgrType == OpClientMgrType.EXPORT_CLIENT)
            {
                this.cbCaseType.Text = "出口保理";
                this.QueryClients(null, null);
            }
            else if (this.opClientMgrType == OpClientMgrType.IMPORT_CLIENT)
            {
                this.cbCaseType.Text = "进口保理";
                this.QueryClients(null, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isContract"></param>
        public ClientMgr(bool isContract)
            : this()
        {
            this.cbIsContractSigned.Checked = true;
            this.cbIsContractSigned.Enabled = false;
            this.QueryClients(null, null);
        }

        /// <summary>
        /// Initializes a new instance of the ClientMgr class
        /// </summary>
        public ClientMgr()
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvClients);

            List<Department> deptsList = Department.AllDepartments().ToList();
            deptsList.Insert(0, new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" });
            this.cbDepartment.DataSource = deptsList;
            this.cbDepartment.DisplayMembers = "DepartmentName";
            this.cbDepartment.ValueMember = "DepartmentCode";
            this.cbDepartment.GroupingMembers = "Domain";
            this.cbDepartment.SelectedIndex = -1;

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
        public Client Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (11)

        // Private Methods (11) 

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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            Client selectedClient = (Client)this.bs.List[this.dgvClients.SelectedRows[0].Index];
            if (MessageBox.Show("是否打算删除客户: " + selectedClient.ClientNameCN, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (selectedClient.ClientCreditLines.Count > 0)
                {
                    MessageBox.Show("不能删除此客户,已存在相关额度", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.Contracts.Count > 0)
                {
                    MessageBox.Show("不能删除此客户,已存在相关保理合同", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.SellerCases.Count > 0 || selectedClient.BuyerCases.Count > 0)
                {
                    MessageBox.Show("不能删除此客户,已存在相关案件信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.GroupClients.Count > 0)
                {
                    MessageBox.Show("不能删除此客户,已存在相关子公司信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.ClientAccounts.Count > 0)
                {
                    MessageBox.Show("不能删除此客户,已存在相关账户信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                context.Clients.DeleteOnSubmit(selectedClient);
                try
                {
                    context.SubmitChanges();
                }
                catch (SqlException e1)
                {
                    MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.dgvClients.Rows.RemoveAt(dgvClients.SelectedRows[0].Index);
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

            Client selectedClient = (Client)this.bs.List[this.dgvClients.SelectedRows[0].Index];
            ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClients_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvClients.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvClients.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvClients.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewClient(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            Client selectedClient = (Client)this.bs.List[this.dgvClients.SelectedRows[0].Index];
            ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            Client selectedClient = (Client)this.bs.List[this.dgvClients.SelectedRows[0].Index];
            ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpContractType.NEW_CONTRACT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// Query client according to condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryClients(object sender, System.EventArgs e)
        {
            string clientType = this.cbClientType.Text;
            if (clientType == "全部")
            {
                clientType = string.Empty;
            }

            string department = this.cbDepartment.Text;
            if (department == "全部")
            {
                department = string.Empty;
            }

            string caseType = this.cbCaseType.Text;

            var queryResult = context.Clients.Where(c =>
                     ((c.BranchCode == null ? string.Empty : c.Department.DepartmentName).Contains(department))
                  && ((c.PMName == null ? string.Empty : c.PMName).Contains(tbPM.Text))
                  && ((c.RMName == null ? string.Empty : c.RMName).Contains(tbRM.Text))
                  && (((c.ClientNameCN == null ? string.Empty : c.ClientNameCN).Contains(tbClientName.Text)) || ((c.ClientNameEN == null ? string.Empty : c.ClientNameEN).Contains(tbClientName.Text)))
                  && ((c.ClientEDICode == null ? string.Empty : c.ClientEDICode).Contains(tbClientEDICode.Text))
                  && ((c.ClientType == null ? string.Empty : c.ClientType).Contains(clientType))
                  && (this.cbIsContractSigned.Checked == false ? true : c.Contracts.Any(con => con.ContractStatus == ConstStr.CONTRACT.AVAILABILITY))
                  && (caseType == "出口保理" ? c.SellerCases.Any(ca => ca.TransactionType == "出口保理") || c.BuyerCases.Any(ca => ca.TransactionType == "出口保理") : true)
                  && (caseType == "进口保理" ? c.SellerCases.Any(ca => ca.TransactionType == "进口保理") || c.BuyerCases.Any(ca => ca.TransactionType == "进口保理") : true)
                  && (caseType == "国内保理" ? c.SellerCases.Any(ca => ca.TransactionType == "国内卖方保理" || ca.TransactionType == "国内买方保理") || c.BuyerCases.Any(ca => ca.TransactionType == "国内卖方保理" || ca.TransactionType == "国内买方保理") : true));

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            foreach (Control comp in this.pnlQuery.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
        }

        /// <summary>
        /// Select client and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectClient(object sender, EventArgs e)
        {
            if (this.dgvClients.SelectedRows.Count == 0)
            {
                return;
            }

            Client selectedClient = (Client)this.bs.List[this.dgvClients.SelectedRows[0].Index];
            this.Selected = selectedClient;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permission.BASICINFO_UPDATE))
            {
                this.menuItemClientNew.Enabled = true;
                this.menuItemClientDelete.Enabled = true;
                this.menuItemClientCreditLineNew.Enabled = true;
                this.menuItemContractNew.Enabled = true;
            }
            else
            {
                this.menuItemClientNew.Enabled = false;
                this.menuItemClientDelete.Enabled = false;
                this.menuItemClientCreditLineNew.Enabled = false;
                this.menuItemContractNew.Enabled = false;
            }
        }

        #endregion Methods
    }
}
