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
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Data.Linq;
    using DevComponents.DotNetBar;

    /// <summary>
    /// Factor Management User Interface 
    /// </summary>
    public partial class FactorMgr : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the FactorMgrUI class
        /// </summary>
        /// <param name="isEditable">true if editable</param>
        public FactorMgr()
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.dgvFactors.DataSource = this.bs;
            this.dgvFactors.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvFactors);

            List<Country> countryList = Country.AllCountries().ToList();
            countryList.Insert(0, new Country() { CountryCode = "AA", CountryNameCN = "全部", CountryNameEN = "All" });
            this.cbCountry.DataSource = countryList;
            this.cbCountry.DisplayMember = "CountryFormatEN";
            this.cbCountry.ValueMember = "CountryNameEN";

            this.UpdateContextMenu();
        }

        #endregion Constructors

        #region Properties (3)

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

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

        #region Methods (10)

        // Private Methods (10) 

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
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            Factor selectedFactor = (Factor)this.bs.List[this.dgvFactors.SelectedRows[0].Index];
            if (MessageBoxEx.Show("是否确定删除保理商: " + selectedFactor.FactorCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (selectedFactor.FactorCreditLines.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关额度.", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedFactor.SellerCases.Count > 0 || selectedFactor.BuyerCases.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关案件信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedFactor.FactorAccounts.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关账户信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedFactor.GroupFactors.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关子机构信息", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                context.Factors.DeleteOnSubmit(selectedFactor);
                try
                {
                    context.SubmitChanges();
                }
                catch (SqlException e1)
                {
                    MessageBoxEx.Show("删除失败:" + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.dgvFactors.Rows.RemoveAt(this.dgvFactors.SelectedRows[0].Index);
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

            Factor selectedFactor = (Factor)this.bs.List[this.dgvFactors.SelectedRows[0].Index];
            FactorDetail factorDetail = new FactorDetail(selectedFactor, FactorDetail.OpFactorType.DETAIL_FACTOR);
            factorDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFactors_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvFactors.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvFactors.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvFactors.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            FactorDetail factorDetail = new FactorDetail(null, FactorDetail.OpFactorType.NEW_FACTOR);
            factorDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactorCreditLine(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                return;
            }

            if (this.dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            Factor selectedFactor = (Factor)this.bs.List[this.dgvFactors.SelectedRows[0].Index];
            FactorDetail factorDetail = new FactorDetail(selectedFactor, FactorDetail.OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE);
            factorDetail.ShowDialog(this);
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

            context = new DBDataContext();
            if (!PermUtil.ValidatePermission(Permission.BASICINFO_UPDATE))
            {
                context.ObjectTrackingEnabled = false;
            }

            var queryResult = context.Factors.Where(f =>
                                                   ((f.FactorCode == null ? string.Empty : f.FactorCode).Contains(tbFactorCode.Text))
                                                && ((f.CompanyNameCN == null ? string.Empty : f.CompanyNameCN).Contains(tbFactorName.Text) || (f.CompanyNameEN == null ? string.Empty : f.CompanyNameEN).Contains(tbFactorName.Text))
                                                && (f.FactorType.Contains(factorType))
                                                && ((f.CountryName == null ? string.Empty : f.CountryName).Contains(country)));

            bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            Factor selectedFactor = (Factor)this.bs.List[this.dgvFactors.SelectedRows[0].Index];
            this.Selected = selectedFactor;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// update editable status
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permission.BASICINFO_UPDATE))
            {
                this.menuItemFactorNew.Enabled = true;
                this.menuItemFactorCreditLineNew.Enabled = true;
                this.menuItemFactorDelete.Enabled = true;
            }
            else
            {
                this.menuItemFactorNew.Enabled = false;
                this.menuItemFactorCreditLineNew.Enabled = false;
                this.menuItemFactorDelete.Enabled = false;
            }
        }

        #endregion Methods
    }
}