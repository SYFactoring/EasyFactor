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

        public Form OwnerForm
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
            this.OwnerForm = owner;
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
        private static void ImportFactors(object obj)
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

            Array values = (Array)range.Formula;
            if (values != null)
            {
                var factorList = App.Current.DbContext.Factors;

                int length = values.GetLength(0);

                for (int row = 1; row <= length; row++)
                {
                    if (!values.GetValue(row, 2).Equals(string.Empty))
                    {
                        Factor factor = null;
                        try
                        {
                            int column = 1;
                            bool isNew = false;
                            string factorCode = values.GetValue(row, 2).ToString().Trim();
                            factor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                isNew = true;
                                factor = new Factor();
                                factor.FactorType = "保理商";
                            }
                            factor.CountryName = values.GetValue(row, column++).ToString().Trim();
                            factor.FactorCode = values.GetValue(row, column++).ToString().Trim();
                            factor.CompanyName = values.GetValue(row, column++).ToString().Trim();
                            factor.ShortName = values.GetValue(row, column++).ToString().Trim();
                            factor.Department = values.GetValue(row, column++).ToString().Trim();
                            factor.PostalAddress_1 = values.GetValue(row, column++).ToString().Trim();
                            factor.PostalAddress_2 = values.GetValue(row, column++).ToString().Trim();
                            factor.PostalCodePost = values.GetValue(row, column++).ToString().Trim();
                            factor.CityPost = values.GetValue(row, column++).ToString().Trim();
                            factor.VisitingAddress_1 = values.GetValue(row, column++).ToString().Trim();
                            factor.VisitingAddress_2 = values.GetValue(row, column++).ToString().Trim();
                            factor.PostalCodeVisiting = values.GetValue(row, column++).ToString().Trim();
                            factor.CityVisiting = values.GetValue(row, column++).ToString().Trim();
                            factor.Email = values.GetValue(row, column++).ToString().Trim();
                            factor.WebSite = values.GetValue(row, column++).ToString().Trim();
                            factor.Telephone_1 = values.GetValue(row, column++).ToString().Trim();
                            factor.Telephone_2 = values.GetValue(row, column++).ToString().Trim();
                            factor.Telefax_1 = values.GetValue(row, column++).ToString().Trim();
                            factor.Telefax_2 = values.GetValue(row, column++).ToString().Trim();
                            factor.WorkingHours = values.GetValue(row, column++).ToString().Trim();
                            factor.GeneralCorrespondence_1 = values.GetValue(row, column++).ToString().Trim();
                            factor.GeneralCorrespondence_2 = values.GetValue(row, column++).ToString().Trim();
                            factor.Contacts_1 = values.GetValue(row, column++).ToString().Trim();
                            factor.Contacts_2 = values.GetValue(row, column++).ToString().Trim();
                            factor.Contacts_3 = values.GetValue(row, column++).ToString().Trim();
                            factor.Contacts_4 = values.GetValue(row, column++).ToString().Trim();
                            factor.Management_1 = values.GetValue(row, column++).ToString().Trim();
                            factor.Management_2 = values.GetValue(row, column++).ToString().Trim();
                            factor.Shareholders = values.GetValue(row, column++).ToString().Trim();
                            factor.IFISAvailableOnPrivateForum = values.GetValue(row, column++).ToString().Trim();
                            factor.MembershipStatus = values.GetValue(row, column++).ToString().Trim();
                            factor.MembershipDate = values.GetValue(row, column++).ToString().Trim();
                            factor.DateOfLatestRevision = values.GetValue(row, column).ToString().Trim();

                            if (isNew)
                            {
                                App.Current.DbContext.Factors.InsertOnSubmit(factor);
                            }

                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (Exception e)
                        {
                            DialogResult dr = MessageBox.Show("导入失败: " + e.Message + "\t" + factor.FactorCode + "\n" + "是否继续导入？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            if (this.OwnerForm == null)
            {
                this.DetailFactor(sender, e);
            }
            else
            {
                this.SelectFactor(sender, e);
            }
        }

        /// <summary>
        /// Query according the condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryFactors(object sender, EventArgs e)
        {
            var queryResult = App.Current.DbContext.Factors.Where(f =>
                                                   (tbFactorCode.Text == string.Empty || f.FactorCode.Contains(tbFactorCode.Text))
                                                && (tbFactorName.Text == string.Empty || f.CompanyName.Contains(tbFactorName.Text))
                                                && (cbFactorType.Text == string.Empty || f.FactorType.Equals(cbFactorType.Text)));
            dgvFactors.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Create a new factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewFactor(object sender, EventArgs e)
        {
            new FactorDetail(null, FactorDetail.OpType.NEW_FACTOR).ShowDialog(this);
        }

        /// <summary>
        /// Update current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateFactor(object sender, EventArgs e)
        {
            if (this.dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            string factorCode = (string)this.dgvFactors["factorCodeColumn", dgvFactors.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    new FactorDetail(selectedFactor, FactorDetail.OpType.UPDATE_FACTOR).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Delete current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteFactor(object sender, EventArgs e)
        {
            if (this.dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            string factorCode = (string)dgvFactors["factorCodeColumn", dgvFactors.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    if (MessageBox.Show("是否确定删除保理商: " + selectedFactor.FactorCode, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        dgvFactors.Rows.Remove(dgvFactors.SelectedRows[0]);
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
        private void SelectFactor(object sender, EventArgs e)
        {
            if (this.dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            string factorCode = (string)dgvFactors["factorCodeColumn", dgvFactors.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    this.Selected = selectedFactor;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Show detail info about current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailFactor(object sender, EventArgs e)
        {
            if (this.dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            string factorCode = (string)dgvFactors["factorCodeColumn", dgvFactors.SelectedRows[0].Index].Value;
            if (factorCode != null)
            {
                Factor selectedFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                if (selectedFactor != null)
                {
                    new FactorDetail(selectedFactor, FactorDetail.OpType.DETAIL_FACTOR).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Popup a openfile dialog and select the import factor file.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ImportFactosImpl(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(ImportFactors);

                t.Start(fileName);
            }
        }
    }
}
