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
    using System.Threading;
    using Microsoft.Office.Interop.Excel;
    using System.Reflection;
    using System.Data.Linq;

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
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the ClientMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public ClientMgr(bool isEditable)
        {
            InitializeComponent();
            this.isEditable = isEditable;
            this.UpdateEditableStatus(isEditable);

            this.comboTreeDepartment.DataSource = App.Current.DbContext.Departments;
            this.comboTreeDepartment.DisplayMembers = "DepartmentName";
            this.comboTreeDepartment.ValueMember = "DepartmentCode";
            this.comboTreeDepartment.GroupingMembers = "Domain";

        }

        /// <summary>
        /// Initializes a new instance of the ClientMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        /// <param name="owner">form owner</param>
        public ClientMgr(bool isEditable, Form owner)
            : this(isEditable)
        {
            this.OwnerForm = owner;
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
        private void UpdateEditableStatus(bool isEditable)
        {
            if (!this.isEditable)
            {
                this.toolStripSeparator.Visible = false;
                this.menuItemEdit.Visible = false;
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
                if (clientType == "全部")
                {
                    clientType = string.Empty;
                }
            }

            string department = string.Empty;
            if (comboTreeDepartment.SelectedIndex >= 0)
            {
                department = comboTreeDepartment.SelectedValue.ToString();
                if (department == "CN01300")
                {
                    department = string.Empty;
                }
            }

            //var queryResult = App.Current.DbContext.Clients.Where(c =>
            //   (c.BranchCode == null || c.BranchCode.Contains(department))
            //&& (c.PMName.Contains(tbPM.Text))
            //&& (c.RMName.Contains(tbRM.Text))
            //&& (c.ClientNameCN.Contains(tbClientName.Text) || c.ClientNameEN_1.Contains(tbClientName.Text) || c.ClientNameEN_2.Contains(tbClientName.Text))
            //&& (c.ClientEDICode.Contains(tbClientEDICode.Text))
            //&& (c.ClientType.Contains(clientType)));
            var queryResult = App.Current.DbContext.Clients;

            clientMgrBindingSource.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Create a new client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewClient(object sender, System.EventArgs e)
        {
            ClientDetail clientDetail = new ClientDetail(null, ClientDetail.OpType.NEW_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// Update selected client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateClient(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientEDICodeColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = (from c in App.Current.DbContext.Clients where (c.ClientEDICode == cid) select c).FirstOrDefault();
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpType.UPDATE_CLIENT);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        private void UpdateClientCreditLine(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientEDICodeColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = (from c in App.Current.DbContext.Clients where (c.ClientEDICode == cid) select c).FirstOrDefault();
                if (selectedClient != null)
                {
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpType.UPDATE_CLIENT_CREDIT_COVER);
                    clientDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Delete selected Client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteClient(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || this.clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientEDICodeColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientEDICode == cid);
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
        /// Select client and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectClient(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || this.clientMgrBindingSource == null)
            {
                return;
            }

            string cid = (string)dgvClient["clientEDICodeColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientEDICode == cid);
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
        /// Show detail info of selected client
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailClient(object sender, System.EventArgs e)
        {
            if (this.dgvClient.SelectedRows.Count == 0 || this.clientMgrBindingSource == null)
            {
                return;
            }
            string cid = (string)dgvClient["clientEDICodeColumn", dgvClient.SelectedRows[0].Index].Value;
            if (cid != null)
            {
                Client selectedClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientEDICode == cid);
                if (selectedClient != null)
                {
                    new ClientDetail(selectedClient, ClientDetail.OpType.DETAIL_CLIENT).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DetailClient(sender, e);
        }

        private void ImportClients(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(ImportClientsImp);
                t.Start(fileName);
            }
        }

        private static void ImportClientsImp(object obj)
        {
            string fileName = obj as string;
            ApplicationClass app = new ApplicationClass { Visible = false };
            WorkbookClass w = (WorkbookClass)app.Workbooks.Open(
               @fileName,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value);

            Sheets sheets = w.Worksheets;
            Worksheet datasheet = null;

            foreach (Worksheet sheet in sheets)
            {
                if (datasheet == null)
                {
                    datasheet = sheet;
                    break;
                }
            }

            if (datasheet == null)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                app.Quit();
                return;
            }

            Range range = datasheet.get_Range("A2", "AJ1000");
            Array values = (Array)range.Formula;
            if (values != null)
            {
                int length = values.GetLength(0);

                for (int row = 1; row <= length; row++)
                {
                    if (!values.GetValue(row, 2).Equals(string.Empty))
                    {
                        Client newClient = new Client();
                        int column = 1;
                        newClient.ClientCoreNo = values.GetValue(row, column++).ToString().Trim();
                        newClient.ClientEDICode = values.GetValue(row, column++).ToString().Trim();
                        newClient.ClientNameCN = values.GetValue(row, column++).ToString().Trim();
                        newClient.ClientNameEN_1 = values.GetValue(row, column++).ToString().Trim();
                        newClient.ClientNameEN_2 = values.GetValue(row, column++).ToString().Trim();
                        newClient.AddressCN = values.GetValue(row, column++).ToString().Trim();
                        newClient.AddressEN = values.GetValue(row, column++).ToString().Trim();
                        newClient.CityCN = values.GetValue(row, column++).ToString().Trim();
                        newClient.CityEN = values.GetValue(row, column++).ToString().Trim();
                        newClient.ProductCN = values.GetValue(row, column++).ToString().Trim();
                        newClient.ProductEN = values.GetValue(row, column++).ToString().Trim();
                        newClient.PostCode = values.GetValue(row, column++).ToString().Trim();
                        newClient.CountryCode = values.GetValue(row, column++).ToString().Trim();
                        newClient.Representative = values.GetValue(row, column++).ToString().Trim();
                        newClient.Wetsite = values.GetValue(row, column++).ToString().Trim();
                        newClient.Contact = values.GetValue(row, column++).ToString().Trim();
                        newClient.Telephone = values.GetValue(row, column++).ToString().Trim();
                        newClient.Email = values.GetValue(row, column++).ToString().Trim();
                        newClient.FaxNumber = values.GetValue(row, column++).ToString().Trim();
                        newClient.CellPhone = values.GetValue(row, column++).ToString().Trim();
                        newClient.ClientType = values.GetValue(row, column++).ToString().Trim();
                        newClient.Industry = values.GetValue(row, column++).ToString().Trim();
                        newClient.ProductCN = values.GetValue(row, column++).ToString().Trim();
                        newClient.ProductEN = values.GetValue(row, column++).ToString().Trim();
                        newClient.ClientLevel = values.GetValue(row, column++).ToString().Trim();
                        newClient.IsGroup = values.GetValue(row, column++).ToString().Trim();
                        string groupNo = values.GetValue(row, column++).ToString().Trim();
                        string groupNameCN = values.GetValue(row, column++).ToString().Trim();
                        string groupNameEN = values.GetValue(row, column++).ToString().Trim();
                        newClient.RegistrationNumber = values.GetValue(row, column++).ToString().Trim();
                        newClient.CompanyCode = values.GetValue(row, column++).ToString().Trim();
                        string departmentName = values.GetValue(row, column++).ToString().Trim();
                        Department dep = App.Current.DbContext.Departments.FirstOrDefault(d => d.DepartmentName.Equals(departmentName));
                        if (dep != null)
                        {
                            newClient.Department = dep;
                        }
                        newClient.PMName = values.GetValue(row, column++).ToString().Trim();
                        newClient.RMName = values.GetValue(row, column++).ToString().Trim();
                        newClient.Comment = values.GetValue(row, column++).ToString().Trim();

                        try
                        {
                            Client oldClient = App.Current.DbContext.Clients.FirstOrDefault(c => c.ClientEDICode.Equals(newClient.ClientEDICode));
                            if (oldClient != null)
                            {
                                // App.Current.DbContext.Clients.Attach(newClient, true);
                                // oldClient.Copy(newClient);
                            }
                            else
                            {
                                App.Current.DbContext.Clients.InsertOnSubmit(newClient);
                            }

                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            DialogResult dr = MessageBox.Show("导入失败: " + e.Message + "\t" + newClient.ClientEDICode + "\n" + "是否继续导入？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.No)
                            {
                                break;
                            }
                        }
                    }
                }
                MessageBox.Show("导入结束", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            app.Quit();
        }

    }
}
