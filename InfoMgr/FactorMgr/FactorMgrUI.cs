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
    public partial class FactorMgrUI : UserControl
    {
        /// <summary>
        /// flag indicates if is editable
        /// </summary>
        private readonly bool isEditable;

        /// <summary>
        /// variable indicates current owner form
        /// </summary>
        private readonly Form owner;

        /// <summary>
        /// Initializes a new instance of the FactorMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public FactorMgrUI(bool isEditable)
        {
            this.isEditable = isEditable;
            InitializeComponent();
            this.UpdateEditableStatus();
        }

        /// <summary>
        /// Initializes a new instance of the FactorMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        /// <param name="owner">form owner</param>
        public FactorMgrUI(bool isEditable, Form owner)
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
            
            // TODO 选择第一个Sheet，而不是根据Sheet名
            foreach (Worksheet sheet in sheets)
            {
                if (sheet.Name == "qryMemberExportExcel")
                {
                    datasheet = sheet;
                    break;
                }
            }

            if (datasheet == null)
            {
                MessageBox.Show("未找到指定的Sheet！");
                app.Quit();
                app = null;
                return;
            }

            Range range = datasheet.get_Range("A2", "AG500");

            //App.Current.MainWindow.SetProgressBarVisibility(true);
            string msg = string.Empty;

            Array values = (Array)range.Formula;
            if (values != null)
            {
                IQueryable<Factor> factorList = from factor in App.Current.DbContext.Factors select factor;

                int len1 = values.GetLength(0);
                int len2 = values.GetLength(1);

                //App.Current.MainWindow.SetProgressBarLength(300);

                for (int i = 1; i <= len1; i++)
                {
                    if (!values.GetValue(i, 1).Equals(string.Empty))
                    {
                        bool find = false;

                        Factor factor = new Factor();
                        int j = 1;
                        factor.FactorType = "保理商";
                        factor.CountryName = values.GetValue(i, j++).ToString();
                        factor.FactorCode = values.GetValue(i, j++).ToString();

                        factor.CompanyName
                            = values.GetValue(i, j++).ToString();
                        factor.ShortName = values.GetValue(i, j++).ToString();
                        factor.Department = values.GetValue(i, j++).ToString();
                        factor.PostalAddress_1 = values.GetValue(i, j++).ToString();
                        factor.PostalAddress_2 = values.GetValue(i, j++).ToString();
                        factor.PostalCodePost = values.GetValue(i, j++).ToString();
                        factor.CityPost = values.GetValue(i, j++).ToString();
                        factor.VisitingAddress_1 = values.GetValue(i, j++).ToString();
                        factor.VisitingAddress_2 = values.GetValue(i, j++).ToString();
                        factor.PostalCodeVisiting = values.GetValue(i, j++).ToString();
                        factor.CityVisiting = values.GetValue(i, j++).ToString();
                        factor.Email_1 = values.GetValue(i, j++).ToString();
                        factor.WebSite = values.GetValue(i, j++).ToString();
                        factor.Telephone_1 = values.GetValue(i, j++).ToString();
                        factor.Telephone_2 = values.GetValue(i, j++).ToString();
                        factor.Telefax_1 = values.GetValue(i, j++).ToString();
                        factor.Telefax_2 = values.GetValue(i, j++).ToString();
                        factor.WorkingHours = values.GetValue(i, j++).ToString();
                        factor.GeneralCorrespondence_1 = values.GetValue(i, j++).ToString();
                        factor.GeneralCorrespondence_2 = values.GetValue(i, j++).ToString();
                        factor.Contacts_1 = values.GetValue(i, j++).ToString();
                        factor.Contacts_2 = values.GetValue(i, j++).ToString();
                        factor.Contacts_3 = values.GetValue(i, j++).ToString();
                        factor.Contacts_4 = values.GetValue(i, j++).ToString();
                        factor.Management_1 = values.GetValue(i, j++).ToString();
                        factor.Management_2 = values.GetValue(i, j++).ToString();
                        factor.Shareholders = values.GetValue(i, j++).ToString();
                        factor.IFISAvailableOnPrivateForum = values.GetValue(i, j++).ToString();
                        factor.MembershipStatus = values.GetValue(i, j++).ToString();
                        factor.MembershipDate = values.GetValue(i, j++).ToString();
                        factor.DateOfLatestRevision = values.GetValue(i, j).ToString();
                        factor.Comment = string.Empty;
                        foreach (Factor fa in factorList)
                        {
                            if (fa.FactorCode.Equals(factor.FactorCode))
                            {
                                
                                //this factor exists in the database
                                fa.CityPost = factor.CityPost;
                                fa.CityVisiting = factor.CityVisiting;
                                fa.Comment = factor.Comment;
                                fa.CompanyName = factor.CompanyName;
                                fa.Contacts_1 = factor.Contacts_1;
                                fa.Contacts_2 = factor.Contacts_2;
                                fa.Contacts_3 = factor.Contacts_3;
                                fa.Contacts_4 = factor.Contacts_4;
                                fa.CountryName = factor.CountryName;
                                fa.DateOfLatestRevision = factor.DateOfLatestRevision;
                                fa.Department = factor.Department;
                                fa.Email_1 = factor.Email_1;
                                fa.FactorCode = factor.FactorCode;
                                fa.FactorType = factor.FactorType;
                                fa.GeneralCorrespondence_1 = factor.GeneralCorrespondence_1;
                                fa.GeneralCorrespondence_2 = factor.GeneralCorrespondence_2;
                                fa.IFISAvailableOnPrivateForum = factor.IFISAvailableOnPrivateForum;
                                fa.Management_1 = factor.Management_1;
                                fa.Management_2 = factor.Management_2;
                                fa.MembershipDate = factor.MembershipDate;
                                fa.MembershipStatus = factor.MembershipStatus;
                                fa.PostalAddress_1 = factor.PostalAddress_1;
                                fa.PostalAddress_2 = factor.PostalAddress_2;
                                fa.PostalCodePost = factor.PostalCodePost;
                                fa.PostalCodeVisiting = factor.PostalCodeVisiting;
                                fa.Shareholders = factor.Shareholders;
                                fa.ShortName = factor.ShortName;
                                fa.Telefax_1 = factor.Telefax_1;
                                fa.Telefax_2 = factor.Telefax_2;
                                fa.Telephone_1 = factor.Telephone_1;
                                fa.Telephone_2 = factor.Telephone_2;
                                fa.VisitingAddress_1 = factor.VisitingAddress_1;
                                fa.VisitingAddress_2 = factor.VisitingAddress_2;
                                fa.WebSite = factor.WebSite;
                                fa.WorkingHours = factor.WorkingHours;

                                find = true;
                                break;
                            }
                        }

                        if (!find)
                        {
                            try
                            {
                                App.Current.DbContext.Factors.InsertOnSubmit(factor);
                            }
                            catch (Exception)
                            {
                                msg += "保理商" + factor.FactorCode + "导入失败！" + "\n";
                            }
                        }

                        //App.Current.MainWindow.SetProgressBarIncrease(1);
                    }
                }
            }

            //App.Current.MainWindow.SetProgressBarLength(300);
            Thread.Sleep(100);

            MessageBox.Show(!msg.Equals(string.Empty) ? msg : "Import Successful");
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
                                                   (tbFactorCode.Text == string.Empty || f.FactorCode.Contains(tbFactorCode.Text)) &&
                                                   (tbFactorName.Text == string.Empty || f.CompanyName.Contains(tbFactorName.Text)) &&
                                                   (tbFactorType.Text == string.Empty || f.FactorType.Contains(tbFactorType.Text)));

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
            new FactorDetailUI(null, true).ShowDialog(this);
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
                    new FactorDetailUI(selectedFactor, true).ShowDialog(this);
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
                    new FactorDetailUI(selectedFactor, false).ShowDialog(this);
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
