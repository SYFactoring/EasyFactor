//-----------------------------------------------------------------------
// <copyright file="FactorMgrUI.cs" company="Yiming Liu@Fudan">
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
    using System.Data.SqlClient;
    using CMBC.EasyFactor.Utils;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Factor Management User Interface 
    /// </summary>
    public partial class FactorMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
        /// <summary>
        /// flag indicates if is editable
        /// </summary>
        private readonly bool isEditable;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the FactorMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public FactorMgr(bool isEditable)
        {
            this.InitializeComponent();
            this.isEditable = isEditable;
            this.UpdateEditableStatus();
            ControlUtil.SetDoubleBuffered(this.dgvFactors);

            List<Country> countryList = Country.AllCountries().ToList();
            countryList.Insert(0, new Country() { CountryCode = "AA", CountryNameCN = "全部", CountryNameEN = "All" });
            this.cbCountry.DataSource = countryList;
            this.cbCountry.DisplayMember = "CountryFormatEN";
            this.cbCountry.ValueMember = "CountryNameEN";
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// Gets or sets onwer form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected factor
        /// </summary>
        public Factor Selected
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
                this.DetailFactor(sender, e);
            }
            else
            {
                this.SelectFactor(sender, e);
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
                        App.Current.DbContext.Factors.DeleteOnSubmit(selectedFactor);
                        try
                        {
                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("不能删除此机构,已存在相关额度.", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        dgvFactors.Rows.RemoveAt(dgvFactors.SelectedRows[0].Index);
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
                    FactorDetail factorDetail = new FactorDetail(selectedFactor, FactorDetail.OpFactorType.DETAIL_FACTOR);
                    factorDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Import factor list from selected file
        /// </summary>
        /// <param name="obj">selected file</param>
        private static void ImportFactorsImpl(object obj)
        {
            string fileName = obj as string;

            ApplicationClass app = new ApplicationClass() { Visible = false };
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);

            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);

            if (valueArray != null)
            {
                for (int row = 2; row < range.Rows.Count; row++)
                {
                    Factor factor = null;
                    try
                    {
                        int column = 1;
                        string factorCode = String.Format("{0:G}", valueArray[row, 2]);
                        if (string.Empty.Equals(factorCode))
                        {
                            continue;
                        }
                        bool isNew = false;
                        factor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                        if (factor == null)
                        {
                            isNew = true;
                            factor = new Factor();
                            factor.FactorType = "保理商";
                        }
                        factor.CountryName = String.Format("{0:G}", valueArray[row, column++]);
                        factor.FactorCode = String.Format("{0:G}", valueArray[row, column++]);
                        factor.CompanyNameEN = String.Format("{0:G}", valueArray[row, column++]);
                        factor.ShortName = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Department = String.Format("{0:G}", valueArray[row, column++]);
                        factor.PostalAddress_1 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.PostalAddress_2 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.PostalCodePost = String.Format("{0:G}", valueArray[row, column++]);
                        factor.CityPost = String.Format("{0:G}", valueArray[row, column++]);
                        factor.VisitingAddress_1 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.VisitingAddress_2 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.PostalCodeVisiting = String.Format("{0:G}", valueArray[row, column++]);
                        factor.CityVisiting = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Email = String.Format("{0:G}", valueArray[row, column++]);
                        factor.WebSite = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Telephone_1 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Telephone_2 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Telefax_1 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Telefax_2 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.WorkingHours = String.Format("{0:G}", valueArray[row, column++]);
                        factor.GeneralCorrespondence_1 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.GeneralCorrespondence_2 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Contacts_1 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Contacts_2 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Contacts_3 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Contacts_4 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Management_1 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Management_2 = String.Format("{0:G}", valueArray[row, column++]);
                        factor.Shareholders = String.Format("{0:G}", valueArray[row, column++]);
                        factor.IFISAvailableOnPrivateForum = String.Format("{0:G}", valueArray[row, column++]);
                        factor.MembershipStatus = String.Format("{0:G}", valueArray[row, column++]);
                        factor.MembershipDate = String.Format("{0:G}", valueArray[row, column++]);
                        factor.DateOfLatestRevision = String.Format("{0:G}", valueArray[row, column++]);

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
                MessageBox.Show("导入结束", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(workbook);
        }

        /// <summary>
        /// Popup a openfile dialog and select the import factor file.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ImportFactos(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(ImportFactorsImpl);

                t.Start(fileName);
            }
        }

        /// <summary>
        /// Create a new factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewFactor(object sender, EventArgs e)
        {
            FactorDetail factorDetail = new FactorDetail(null, FactorDetail.OpFactorType.NEW_FACTOR);
            factorDetail.ShowDialog(this);
        }

        private void NewFactorCreditLine(object sender, System.EventArgs e)
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
                    FactorDetail factorDetail = new FactorDetail(selectedFactor, FactorDetail.OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE);
                    factorDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Query according the condition
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryFactors(object sender, EventArgs e)
        {
            string factorType = string.Empty;
            if (cbFactorType.SelectedIndex >= 0)
            {
                factorType = cbFactorType.Items[cbFactorType.SelectedIndex].ToString();
                if ("全部".Equals(factorType))
                {
                    factorType = string.Empty;
                }
            }
            string country = string.Empty;
            if (cbCountry.SelectedIndex >= 0)
            {
                country = (string)cbCountry.SelectedValue;
                if ("All".Equals(country))
                {
                    country = string.Empty;
                }
            }

            var queryResult = App.Current.DbContext.Factors.Where(f =>
                                                   ((f.FactorCode == null ? string.Empty : f.FactorCode).Contains(tbFactorCode.Text))
                                                && ((f.CompanyNameCN == null ? string.Empty : f.CompanyNameCN).Contains(tbFactorName.Text) || (f.CompanyNameEN == null ? string.Empty : f.CompanyNameEN).Contains(tbFactorName.Text))
                                                && (f.FactorType.Contains(cbFactorType.Text))
                                                && ((f.CountryName == null ? string.Empty : f.CountryName).Contains(country)));

            bs.DataSource = queryResult;
            dgvFactors.DataSource = bs;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
        /// update editable status
        /// </summary>
        private void UpdateEditableStatus()
        {
            if (isEditable)
            {
                this.menuItemFactorNew.Enabled = true;
                this.menuItemFactorCreditLineNew.Enabled = true;
                this.menuItemFactorUpdate.Enabled = true;
                this.menuItemFactorDelete.Enabled = true;
                this.menuItemFactorImport.Enabled = true;
            }
            else
            {
                this.menuItemFactorNew.Enabled = false;
                this.menuItemFactorCreditLineNew.Enabled = false;
                this.menuItemFactorUpdate.Enabled = false;
                this.menuItemFactorDelete.Enabled = false;
                this.menuItemFactorImport.Enabled = false;
            }
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
                    FactorDetail factorDetail = new FactorDetail(selectedFactor, FactorDetail.OpFactorType.UPDATE_FACTOR);
                    factorDetail.ShowDialog(this);
                }
            }
        }

        #endregion Methods
    }
}