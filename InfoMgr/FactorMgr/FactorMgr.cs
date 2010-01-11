//-----------------------------------------------------------------------
// <copyright file="FactorMgrUI.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

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
            this.dgvFactors.AutoGenerateColumns = false;
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
                    if (MessageBox.Show("是否确定删除保理商: " + selectedFactor.FactorCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (selectedFactor.FactorCreditLines.Count > 0)
                        {
                            MessageBox.Show("不能删除此机构,已存在相关额度.", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (selectedFactor.SellerCases.Count > 0 || selectedFactor.BuyerCases.Count > 0)
                        {
                            MessageBox.Show("不能删除此机构,已存在相关案件信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        App.Current.DbContext.Factors.DeleteOnSubmit(selectedFactor);
                        try
                        {
                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (SqlException e1)
                        {
                            MessageBox.Show("删除失败:" + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// <summary>
        /// Popup a openfile dialog and select the import factor file.
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void ImportFactos(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FACTORS);
            importForm.Show();
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
                factorType = cbFactorType.Text;
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
                                                && (f.FactorType.Contains(factorType))
                                                && ((f.CountryName == null ? string.Empty : f.CountryName).Contains(country)));

            bs.DataSource = queryResult;
            dgvFactors.DataSource = bs;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        private void Reset(object sender, EventArgs e)
        {
            this.tbFactorCode.Text = string.Empty;
            this.tbFactorName.Text = string.Empty;
            this.cbCountry.SelectedIndex = -1;
            this.cbFactorType.SelectedIndex = -1;
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