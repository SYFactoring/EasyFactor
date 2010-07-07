//-----------------------------------------------------------------------
// <copyright file="DepartmentMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public enum OpDepartmentType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            DEPARTMENT_STAT,

            /// <summary>
            /// 
            /// </summary>
            LOCATION_STAT,
        }
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;
        private readonly OpDepartmentType _opDepatmentType;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="opDepartmentType"></param>
        public DepartmentMgr(OpDepartmentType opDepartmentType)
            : this()
        {
            _opDepatmentType = opDepartmentType;
            if (opDepartmentType == OpDepartmentType.DEPARTMENT_STAT)
            {
                colAssignAmount.Visible = true;
                colFinanceAmount.Visible = true;
                colCommissionIncome.Visible = true;
                colNetInterestIncome.Visible = true;
                colMarginIncome.Visible = true;
                colTotalIncome.Visible = true;
            }
            else if (opDepartmentType == OpDepartmentType.LOCATION_STAT)
            {
                dgvDepts.ContextMenuStrip = null;
                colDepartmentCode.Visible = false;
                colDepartmentName.Visible = false;
                colDomain.Visible = false;
                colManager.Visible = false;
                colContact.Visible = false;
                colAssignAmount.Visible = true;
                colFinanceAmount.Visible = true;
                colCommissionIncome.Visible = true;
                colNetInterestIncome.Visible = true;
                colMarginIncome.Visible = true;
                colTotalIncome.Visible = true;
                lblDepartmentName.Visible = false;
                tbDepartmentName.Visible = false;
                tbManager.Visible = false;
                lblManager.Visible = false;
            }
            else
            {
                lblDate.Visible = false;
                diBegin.Visible = false;
                diEnd.Visible = false;
            }
        }
        /// <summary>
        /// Initializes a new instance of the DepartmentMgr class
        /// </summary>
        public DepartmentMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvDepts.DataSource = _bs;
            dgvDepts.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvDepts);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            UpdateContextMenu();
        }
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }
        /// <summary>
        /// Gets or sets Owner Form
        /// </summary>
        public Form OwnerForm { get; set; }
        /// <summary>
        /// Gets or sets Selected Department
        /// </summary>
        public Department Selected { get; set; }
        //?Private?Methods?(9)?
        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                Detail(sender, e);
            }
            else
            {
                Select(sender, e);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteDepartment(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                return;
            }

            if (dgvDepts.CurrentCell == null)
            {
                return;
            }

            var selectedDepartment = (Department)_bs.List[dgvDepts.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("是否确定删除分部: " + selectedDepartment.DepartmentName, MESSAGE.TITLE_WARNING,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Context.Departments.DeleteOnSubmit(selectedDepartment);
                try
                {
                    Context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }
                dgvDepts.Rows.RemoveAt(dgvDepts.CurrentCell.RowIndex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Detail(object sender, EventArgs e)
        {
            if (dgvDepts.CurrentCell == null)
            {
                return;
            }

            var selectedDepartment = (Department)_bs.List[dgvDepts.CurrentCell.RowIndex];
            var detail = new DepartmentDetail(selectedDepartment, DepartmentDetail.OpDepartmentType.DETAIL_DEPARTMENT);
            detail.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDeptsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvDepts.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvDepts.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvDepts.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewDepartment(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                return;
            }

            var detail = new DepartmentDetail(null, DepartmentDetail.OpDepartmentType.NEW_DEPARTMENT);
            detail.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            Context = new DBDataContext();

            DateTime beginDate = String.IsNullOrEmpty(diBegin.Text) ? diBegin.MinDate : diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(diEnd.Text) ? diEnd.MinDate : diEnd.Value;
            string pmanager = tbPManager.Text;
            string manager = tbManager.Text;

            if (_opDepatmentType == OpDepartmentType.QUERY || _opDepatmentType == OpDepartmentType.DEPARTMENT_STAT)
            {
                IQueryable<Department> queryResult = Context.Departments.Where(d =>
                                                                               (d.DepartmentName).Contains(
                                                                                   tbDepartmentName.Text)
                                                                               &&
                                                                               (d.Location.PManager.Contains(pmanager) ||
                                                                                d.Location.Assistant.Contains(pmanager))
                                                                               &&
                                                                               (d.Manager.Contains(manager) ||
                                                                                d.Contact_1.Contains(manager) ||
                                                                                d.Contact_2.Contains(manager))
                    );

                if (_opDepatmentType == OpDepartmentType.DEPARTMENT_STAT)
                {
                    foreach (Department c in queryResult)
                    {
                        c.QueryDateFrom = beginDate;
                        c.QueryDateTo = endDate;
                    }
                }

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
            else if (_opDepatmentType == OpDepartmentType.LOCATION_STAT)
            {
                IQueryable<Location> queryResult =
                    Context.Locations.Where(loc => loc.PManager.Contains(pmanager) || loc.Assistant.Contains(pmanager));

                foreach (Location c in queryResult)
                {
                    c.QueryDateFrom = beginDate;
                    c.QueryDateTo = endDate;
                }

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            tbManager.Text = string.Empty;
            tbDepartmentName.Text = string.Empty;
            tbPManager.Text = string.Empty;
        }
        /// <summary>
        /// Select department and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Select(object sender, EventArgs e)
        {
            if (dgvDepts.CurrentCell == null)
            {
                return;
            }

            var selectedDepartment = (Department)_bs.List[dgvDepts.CurrentCell.RowIndex];
            Selected = selectedDepartment;
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
            if (PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE))
            {
                menuItemDepartmentNew.Enabled = true;
                menuItemDepartmentDelete.Enabled = true;
            }
            else
            {
                menuItemDepartmentNew.Enabled = false;
                menuItemDepartmentDelete.Enabled = false;
            }
        }
    }
}