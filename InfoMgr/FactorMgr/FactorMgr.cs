//-----------------------------------------------------------------------
// <copyright file="FactorMgrUI.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// Factor Management User Interface 
    /// </summary>
    public partial class FactorMgr : UserControl
    {
        /// <summary>
        /// flag indicates if is editable
        /// </summary>
        private readonly bool isEditable;

        public Form owner
        {
            get;
            set;
        }
        /// <summary>
        /// Initializes a new instance of the FactorMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public FactorMgr(bool isEditable)
        {
            InitializeComponent();
            this.isEditable = isEditable;
            this.UpdateEditableStatus();
        }

        /// <summary>
        /// Initializes a new instance of the FactorMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        /// <param name="owner">form owner</param>
        public FactorMgr(bool isEditable, Form owner)
            : this(isEditable)
        {
            this.owner = owner;
        }

        /// <summary>
        /// Gets or sets selected factor
        /// </summary>
        public Factor Selected
        {
            get;
            set;
        }

        /// <summary>
        /// Import factor list from selected file
        /// </summary>
        /// <param name="obj">selected file</param>
        private static void ImportFactor(object obj)
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

            Range range = datasheet.get_Range("A2", "AG300");
            bool hasError = false;
            //App.Current.MainWindow.SetProgressBarVisibility(true);

            Array values = (Array)range.Formula;
            if (values != null)
            {
                var factorList = App.Current.DbContext.Factors;

                int length = values.GetLength(0);

                //App.Current.MainWindow.SetProgressBarLength(300);

                for (int row = 1; row <= length; row++)
                {
                    if (!values.GetValue(row, 1).Equals(string.Empty))
                    {
                        bool find = false;

                        Factor newFactor = new Factor();
                        int column = 1;
                        newFactor.FactorType = "保理商";
                        newFactor.CountryName = values.GetValue(row, column++).ToString().Trim();
                        newFactor.FactorCode = values.GetValue(row, column++).ToString().Trim();
                        newFactor.CompanyName = values.GetValue(row, column++).ToString().Trim();
                        newFactor.ShortName = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Department = values.GetValue(row, column++).ToString().Trim();
                        newFactor.PostalAddress_1 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.PostalAddress_2 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.PostalCodePost = values.GetValue(row, column++).ToString().Trim();
                        newFactor.CityPost = values.GetValue(row, column++).ToString().Trim();
                        newFactor.VisitingAddress_1 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.VisitingAddress_2 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.PostalCodeVisiting = values.GetValue(row, column++).ToString().Trim();
                        newFactor.CityVisiting = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Email = values.GetValue(row, column++).ToString().Trim();
                        newFactor.WebSite = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Telephone_1 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Telephone_2 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Telefax_1 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Telefax_2 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.WorkingHours = values.GetValue(row, column++).ToString().Trim();
                        newFactor.GeneralCorrespondence_1 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.GeneralCorrespondence_2 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Contacts_1 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Contacts_2 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Contacts_3 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Contacts_4 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Management_1 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Management_2 = values.GetValue(row, column++).ToString().Trim();
                        newFactor.Shareholders = values.GetValue(row, column++).ToString().Trim();
                        newFactor.IFISAvailableOnPrivateForum = values.GetValue(row, column++).ToString().Trim();
                        newFactor.MembershipStatus = values.GetValue(row, column++).ToString().Trim();
                        newFactor.MembershipDate = values.GetValue(row, column++).ToString().Trim();
                        newFactor.DateOfLatestRevision = values.GetValue(row, column).ToString().Trim();
                        newFactor.Comment = string.Empty;

                        foreach (Factor oldFactor in factorList)
                        {
                            if (oldFactor.FactorCode.Equals(newFactor.FactorCode))
                            {
                                oldFactor.Copy(newFactor);
                                find = true;
                                break;
                            }
                        }

                        if (!find)
                        {
                            try
                            {
                                App.Current.DbContext.Factors.InsertOnSubmit(newFactor);
                            }
                            catch (Exception)
                            {
                                hasError = true;
                                MessageBox.Show(newFactor.FactorCode + "导入失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        //App.Current.MainWindow.SetProgressBarIncrease(1);
                    }
                }
                if (hasError)
                {
                    MessageBox.Show("本次导入失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    App.Current.DbContext.SubmitChanges();
                    MessageBox.Show("本次导入成功", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //App.Current.MainWindow.SetProgressBarLength(300);

            app.Quit();

            //App.Current.MainWindow.SetProgressBarVisibility(false);
        }

        /// <summary>
        /// update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (this.isEditable)
            {
                return;
            }

            toolStripSeparator.Visible = false;
            menuItemEdit.Visible = false;
        }

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ItemDetail(sender, e);
        }

        /// <summary>
        /// Query according the condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Query(object sender, EventArgs e)
        {
            var queryResult = App.Current.DbContext.Factors.Where(f =>
                                                   (tbFactorCode.Text == string.Empty || f.FactorCode.Contains(tbFactorCode.Text))
                                                && (tbFactorName.Text == string.Empty || f.CompanyName.Contains(tbFactorName.Text))
                                                && (cbFactorType.Text == string.Empty || f.FactorType.Equals(cbFactorType.Text)));
            factorMgrBindingSource.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Create a new factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemNew(object sender, EventArgs e)
        {
            new FactorDetail(null, true).ShowDialog(this);
        }

        /// <summary>
        /// Update current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemUpdate(object sender, EventArgs e)
        {
            if (this.dgvFactor.SelectedRows.Count == 0 || factorMgrBindingSource == null)
            {
                return;
            }

            string factorCode = (string)this.dgvFactor["factorCodeColumn", dgvFactor.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.FirstOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    new FactorDetail(selectedFactor, true).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Delete current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDelete(object sender, EventArgs e)
        {
            if (this.dgvFactor.SelectedRows.Count == 0 || factorMgrBindingSource == null)
            {
                return;
            }

            string factorCode = (string)dgvFactor["factorCodeColumn", dgvFactor.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.FirstOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    if (MessageBox.Show("是否确定删除保理商: " + selectedFactor.FactorCode, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        factorMgrBindingSource.Remove(selectedFactor);
                        App.Current.DbContext.Factors.DeleteOnSubmit(selectedFactor);
                        App.Current.DbContext.SubmitChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Set current selected factor to be selected
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemSelect(object sender, EventArgs e)
        {
            if (this.dgvFactor.SelectedRows.Count == 0 || factorMgrBindingSource == null)
            {
                return;
            }

            string factorCode = (string)dgvFactor["factorCodeColumn", dgvFactor.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.FirstOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    this.Selected = selectedFactor;
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
        /// Show detail info about current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemDetail(object sender, EventArgs e)
        {
            if (this.dgvFactor.SelectedRows.Count == 0 || factorMgrBindingSource == null)
            {
                return;
            }

            string factorCode = (string)dgvFactor["factorCodeColumn", dgvFactor.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.FirstOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    new FactorDetail(selectedFactor, false).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Popup a openfile dialog and select the import factor file.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ItemImport(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(ImportFactor);

                t.Start(fileName);
            }
        }
    }
}
