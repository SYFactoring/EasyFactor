//-----------------------------------------------------------------------
// <copyright file="ClientMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// Client Management User Interface
    /// </summary>
    public partial class ClientMgr : UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;
        /// <summary>
        /// 
        /// </summary>
        private readonly OpClientMgrType _opClientMgrType;

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



        /// <summary>
        /// Initializes a new instance of the ClientMgr class
        /// </summary>
        /// <param name="clientMgrType"></param>
        public ClientMgr(OpClientMgrType clientMgrType)
            : this()
        {
            _opClientMgrType = clientMgrType;
            if (_opClientMgrType == OpClientMgrType.DOMINATE_CLIENT)
            {
                cbCaseType.Text = @"国内保理";
                QueryClients(null, null);
            }
            else if (_opClientMgrType == OpClientMgrType.EXPORT_CLIENT)
            {
                cbCaseType.Text = @"出口保理";
                QueryClients(null, null);
            }
            else if (_opClientMgrType == OpClientMgrType.IMPORT_CLIENT)
            {
                cbCaseType.Text = @"进口保理";
                QueryClients(null, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isContract"></param>
        public ClientMgr(bool isContract)
            : this()
        {
            cbIsContractSigned.Checked = true;
            cbIsContractSigned.Enabled = false;
            QueryClients(null, null);
        }

        /// <summary>
        /// Initializes a new instance of the ClientMgr class
        /// </summary>
        public ClientMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvClients.AutoGenerateColumns = false;
            dgvClients.DataSource = _bs;
            ControlUtil.SetDoubleBuffered(dgvClients);
            ControlUtil.AddEnterListenersForQuery(pnlQuery.Controls, btnQuery);

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "全部" });
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

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
        public Client Selected { get; set; }




        //?Private?Methods?(12)?
        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailClient(sender, e);
            }
            else
            {
                SelectClient(sender, e);
            }
        }

        /// <summary>
        /// Delete selected Client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteClient(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (dgvClients.CurrentCell == null)
            {
                return;
            }

            var selectedClient = (Client)_bs.List[dgvClients.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("是否打算删除客户: " + selectedClient.ClientNameCN, MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (selectedClient.ClientCreditLines.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此客户,已存在相关额度", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.Contracts.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此客户,已存在相关保理合同", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.SellerCases.Count > 0 || selectedClient.BuyerCases.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此客户,已存在相关案件信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.GroupClients.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此客户,已存在相关子公司信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.ClientAccounts.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此客户,已存在相关账户信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedClient.ClientReviews.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此客户,已存在相关协查意见", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                Context.Clients.DeleteOnSubmit(selectedClient);
                try
                {
                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                dgvClients.Rows.RemoveAt(dgvClients.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// Show detail info of selected client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailClient(object sender, EventArgs e)
        {
            if (dgvClients.CurrentCell == null)
            {
                return;
            }

            var selectedClient = (Client)_bs.List[dgvClients.CurrentCell.RowIndex];
            var clientDetail = new ClientDetail(selectedClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvClientsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvClients.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvClients.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvClients.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportClients(object sender, EventArgs e)
        {
            List<Client> selectedClients = GetSelectedClients();
            var form = new ExportForm(ExportForm.ExportType.EXPORT_CLIENT, selectedClients);
            form.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Client> GetSelectedClients()
        {
            if (dgvClients.CurrentCell == null)
            {
                return null;
            }

            var selectedClients = new List<Client>();

            foreach (DataGridViewCell cell in dgvClients.SelectedCells)
            {
                var batch = (Client)_bs.List[cell.RowIndex];
                if (!selectedClients.Contains(batch))
                {
                    selectedClients.Add(batch);
                }
            }

            return selectedClients;
        }

        /// <summary>
        /// Create a new client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewClient(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var clientDetail = new ClientDetail(null, ClientDetail.OpClientType.NEW_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClientCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (dgvClients.CurrentCell == null)
            {
                return;
            }

            var selectedClient = (Client)_bs.List[dgvClients.CurrentCell.RowIndex];
            var clientDetail = new ClientDetail(selectedClient,
                                                ClientDetail.OpClientCreditLineType.NEW_CLIENT_CREDIT_LINE);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewContract(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (dgvClients.CurrentCell == null)
            {
                return;
            }

            var selectedClient = (Client)_bs.List[dgvClients.CurrentCell.RowIndex];
            var clientDetail = new ClientDetail(selectedClient, ClientDetail.OpContractType.NEW_CONTRACT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// Query client according to condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryClients(object sender, EventArgs e)
        {
            string clientType = cbClientType.Text;
            if (clientType == "全部")
            {
                clientType = string.Empty;
            }

            var location = (string)cbLocation.SelectedValue;

            string caseType = cbCaseType.Text;

            Context = new DBDataContext();

            IQueryable<Client> queryResult = Context.Clients.Where(c =>
                                                                   (location == "00"
                                                                        ? true
                                                                        : c.Department.LocationCode == location)
                                                                   &&
                                                                   ((c.PMName ?? string.Empty).
                                                                       Contains(tbPM.Text))
                                                                   &&
                                                                   ((c.RMName ?? string.Empty).
                                                                       Contains(tbRM.Text))
                                                                   &&
                                                                   (((c.ClientNameCN ?? string.Empty).Contains(tbClientName.Text)) ||
                                                                    ((c.ClientNameEN ?? string.Empty).Contains(tbClientName.Text)))
                                                                   &&
                                                                   ((c.ClientEDICode ?? string.Empty).Contains(
                                                                             tbClientEDICode.Text))
                                                                   &&
                                                                   ((c.ClientType ?? string.Empty)
                                                                       .Contains(clientType))
                                                                   &&
                                                                   (cbIsContractSigned.Checked == false
                                                                        ? true
                                                                        : c.Contracts.Any(
                                                                            con =>
                                                                            con.ContractStatus == CONTRACT.AVAILABILITY))
                                                                   &&
                                                                   (caseType == "出口保理"
                                                                        ? c.SellerCases.Any(
                                                                            ca => ca.TransactionType == "出口保理") ||
                                                                          c.BuyerCases.Any(
                                                                              ca => ca.TransactionType == "出口保理")
                                                                        : true)
                                                                   &&
                                                                   (caseType == "进口保理"
                                                                        ? c.SellerCases.Any(
                                                                            ca => ca.TransactionType == "进口保理") ||
                                                                          c.BuyerCases.Any(
                                                                              ca => ca.TransactionType == "进口保理")
                                                                        : true)
                                                                   &&
                                                                   (caseType == "国内保理"
                                                                        ? c.SellerCases.Any(
                                                                            ca =>
                                                                            ca.TransactionType == "国内卖方保理" ||
                                                                            ca.TransactionType == "国内买方保理") ||
                                                                          c.BuyerCases.Any(
                                                                              ca =>
                                                                              ca.TransactionType == "国内卖方保理" ||
                                                                              ca.TransactionType == "国内买方保理")
                                                                        : true));

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            foreach (Control comp in pnlQuery.Controls)
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
            if (dgvClients.CurrentCell == null)
            {
                return;
            }

            var selectedClient = (Client)_bs.List[dgvClients.CurrentCell.RowIndex];
            Selected = selectedClient;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
            {
                menuItemClientNew.Enabled = true;
                menuItemClientDelete.Enabled = true;
                menuItemClientCreditLineNew.Enabled = true;
                menuItemContractNew.Enabled = true;
                menuItemClientExport.Enabled = true;
            }
            else
            {
                menuItemClientNew.Enabled = false;
                menuItemClientDelete.Enabled = false;
                menuItemClientCreditLineNew.Enabled = false;
                menuItemContractNew.Enabled = false;
                menuItemClientExport.Enabled = false;
            }
        }
    }
}