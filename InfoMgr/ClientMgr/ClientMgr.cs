//-----------------------------------------------------------------------
// <copyright file="ClientMgr.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using Microsoft.Office.Interop.Excel;

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
        /// Update editable status
        /// </summary>
        private void UpdateEditableStatus(bool isEditable)
        {
            if (!this.isEditable)
            {
                this.menuItemNewClient.Enabled = false;
                this.menuItemNewClientCreditLine.Enabled = false;
                this.menuItemUpdateClient.Enabled = false;
                this.menuItemDeleteClient.Enabled = false;
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

            var queryResult = App.Current.DbContext.Clients.Where(c =>
                    ((c.BranchCode == null ? "" : c.BranchCode).Contains(department))
                  && ((c.PMName == null ? "" : c.PMName).Contains(tbPM.Text))
                  && ((c.RMName == null ? "" : c.RMName).Contains(tbRM.Text))
                  && (((c.ClientNameCN == null ? "" : c.ClientNameCN).Contains(tbClientName.Text)) || ((c.ClientNameEN_1 == null ? "" : c.ClientNameEN_1).Contains(tbClientName.Text)) || ((c.ClientNameEN_2 == null ? "" : c.ClientNameEN_2).Contains(tbClientName.Text)))
                  && ((c.ClientEDICode == null ? "" : c.ClientEDICode).Contains(tbClientEDICode.Text))
                  && (c.ClientType.Contains(clientType)));

            dgvClients.DataSource = queryResult.ToList();
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
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpType.UPDATE_CLIENT);
                    clientDetail.ShowDialog(this);
                }
            }
        }

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
                    ClientDetail clientDetail = new ClientDetail(selectedClient, ClientDetail.OpType.NEW_CLIENT_CREDIT_COVER);
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
                        dgvClients.Rows.Remove(dgvClients.SelectedRows[0]);
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
                    new ClientDetail(selectedClient, ClientDetail.OpType.DETAIL_CLIENT).ShowDialog(this);
                }
            }
        }

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

        private void ImportClients(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(ImportClientsImpl);
                t.Start(fileName);
            }
        }

        private static void ImportClientsImpl(object obj)
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
                        Client client = null;
                        try
                        {
                            int column = 1;
                            string clientEDICode = values.GetValue(row, 2).ToString().Trim();
                            bool isNew = false;
                            client = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                            if (client == null)
                            {
                                isNew = true;
                                client = new Client();
                            }
                            client.ClientCoreNo = values.GetValue(row, column++).ToString().Trim();
                            client.ClientEDICode = values.GetValue(row, column++).ToString().Trim();
                            client.ClientNameCN = values.GetValue(row, column++).ToString().Trim();
                            client.ClientNameEN_1 = values.GetValue(row, column++).ToString().Trim();
                            client.ClientNameEN_2 = values.GetValue(row, column++).ToString().Trim();
                            client.AddressCN = values.GetValue(row, column++).ToString().Trim();
                            client.AddressEN = values.GetValue(row, column++).ToString().Trim();
                            client.CityCN = values.GetValue(row, column++).ToString().Trim();
                            client.CityEN = values.GetValue(row, column++).ToString().Trim();
                            client.ProductCN = values.GetValue(row, column++).ToString().Trim();
                            client.ProductEN = values.GetValue(row, column++).ToString().Trim();
                            client.PostCode = values.GetValue(row, column++).ToString().Trim();
                            client.CountryCode = values.GetValue(row, column++).ToString().Trim();
                            client.Representative = values.GetValue(row, column++).ToString().Trim();
                            client.Website = values.GetValue(row, column++).ToString().Trim();
                            client.Contact = values.GetValue(row, column++).ToString().Trim();
                            client.Telephone = values.GetValue(row, column++).ToString().Trim();
                            client.Email = values.GetValue(row, column++).ToString().Trim();
                            client.FaxNumber = values.GetValue(row, column++).ToString().Trim();
                            client.CellPhone = values.GetValue(row, column++).ToString().Trim();
                            client.ClientType = values.GetValue(row, column++).ToString().Trim();
                            client.Industry = values.GetValue(row, column++).ToString().Trim();
                            client.ProductCN = values.GetValue(row, column++).ToString().Trim();
                            client.ProductEN = values.GetValue(row, column++).ToString().Trim();
                            client.ClientLevel = values.GetValue(row, column++).ToString().Trim();
                            client.IsGroup = values.GetValue(row, column++).ToString().Trim();
                            string groupNo = values.GetValue(row, column++).ToString().Trim();
                            string groupNameCN = values.GetValue(row, column++).ToString().Trim();
                            string groupNameEN = values.GetValue(row, column++).ToString().Trim();
                            client.RegistrationNumber = values.GetValue(row, column++).ToString().Trim();
                            client.CompanyCode = values.GetValue(row, column++).ToString().Trim();
                            string departmentName = values.GetValue(row, column++).ToString().Trim();
                            Department dep = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));
                            if (dep != null)
                            {
                                client.Department = dep;
                            }
                            client.PMName = values.GetValue(row, column++).ToString().Trim();
                            client.RMName = values.GetValue(row, column++).ToString().Trim();
                            client.Comment = values.GetValue(row, column++).ToString().Trim();

                            if (isNew)
                            {
                                App.Current.DbContext.Clients.InsertOnSubmit(client);
                            }

                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            DialogResult dr = MessageBox.Show("导入失败: " + e.Message + "\t" + client.ClientEDICode + "\n" + "是否继续导入？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
