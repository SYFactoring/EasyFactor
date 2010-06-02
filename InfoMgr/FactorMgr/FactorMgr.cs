//-----------------------------------------------------------------------
// <copyright file="FactorMgrUI.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// Factor Management User Interface 
    /// </summary>
    public partial class FactorMgr : UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;


        /// <summary>
        /// Initializes a new instance of the FactorMgrUI class
        /// </summary>
        public FactorMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvFactors.DataSource = _bs;
            dgvFactors.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvFactors);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            List<Country> countryList = Country.AllCountries();
            countryList.Insert(0, new Country {CountryCode = "AA", CountryNameCN = "全部", CountryNameEN = "All"});
            cbCountry.DataSource = countryList;
            cbCountry.DisplayMember = "CountryFormatEN";
            cbCountry.ValueMember = "CountryNameEN";

            UpdateContextMenu();
        }



        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// Gets or sets onwer form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected factor
        /// </summary>
        public Factor Selected { get; set; }




        //?Private?Methods?(10)?
        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailFactor(sender, e);
            }
            else
            {
                SelectFactor(sender, e);
            }
        }

        /// <summary>
        /// Delete current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedFactor = (Factor) _bs.List[dgvFactors.SelectedRows[0].Index];
            if (
                MessageBoxEx.Show("是否确定删除保理商: " + selectedFactor.FactorCode, MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (selectedFactor.FactorCreditLines.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关额度.", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedFactor.SellerCases.Count > 0 || selectedFactor.BuyerCases.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关案件信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedFactor.FactorAccounts.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关账户信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                if (selectedFactor.GroupFactors.Count > 0)
                {
                    MessageBoxEx.Show("不能删除此机构,已存在相关子机构信息", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                Context.Factors.DeleteOnSubmit(selectedFactor);
                try
                {
                    Context.SubmitChanges();
                }
                catch (SqlException e1)
                {
                    MessageBoxEx.Show("删除失败:" + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    return;
                }

                dgvFactors.Rows.RemoveAt(dgvFactors.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Show detail info about current selected factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailFactor(object sender, EventArgs e)
        {
            if (dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedFactor = (Factor) _bs.List[dgvFactors.SelectedRows[0].Index];
            var factorDetail = new FactorDetail(selectedFactor, FactorDetail.OpFactorType.DETAIL_FACTOR);
            factorDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvFactorsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvFactors.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvFactors.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvFactors.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new factor
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewFactor(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            var factorDetail = new FactorDetail(null, FactorDetail.OpFactorType.NEW_FACTOR);
            factorDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactorCreditLine(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.BASICINFO_UPDATE))
            {
                return;
            }

            if (dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedFactor = (Factor) _bs.List[dgvFactors.SelectedRows[0].Index];
            var factorDetail = new FactorDetail(selectedFactor,
                                                FactorDetail.OpFactorCreditLineType.NEW_FACTOR_CREDIT_LINE);
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
                country = (string) cbCountry.SelectedValue;
                if ("All".Equals(country))
                {
                    country = string.Empty;
                }
            }

            Context = new DBDataContext();
            if (!PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
            {
                Context.ObjectTrackingEnabled = false;
            }

            IQueryable<Factor> queryResult = Context.Factors.Where(f =>
                                                                   f.FactorCode.Contains(tbFactorCode.Text)
                                                                   &&
                                                                   (f.CompanyNameCN.Contains(tbFactorName.Text) ||
                                                                    f.CompanyNameEN.Contains(tbFactorName.Text))
                                                                   && f.FactorType.Contains(factorType)
                                                                   &&
                                                                   ((f.CountryName ?? string.Empty).Contains(country)));

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
            tbFactorCode.Text = string.Empty;
            tbFactorName.Text = string.Empty;
            cbCountry.SelectedIndex = -1;
            cbFactorType.SelectedIndex = -1;
        }

        /// <summary>
        /// Set current selected factor to be selected
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectFactor(object sender, EventArgs e)
        {
            if (dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedFactor = (Factor) _bs.List[dgvFactors.SelectedRows[0].Index];
            Selected = selectedFactor;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// update editable status
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.BASICINFO_UPDATE))
            {
                menuItemFactorNew.Enabled = true;
                menuItemFactorCreditLineNew.Enabled = true;
                menuItemFactorDelete.Enabled = true;
            }
            else
            {
                menuItemFactorNew.Enabled = false;
                menuItemFactorCreditLineNew.Enabled = false;
                menuItemFactorDelete.Enabled = false;
            }
        }
    }
}