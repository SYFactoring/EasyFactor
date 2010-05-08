//-----------------------------------------------------------------------
// <copyright file="DepartmentMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.Controls;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentMgr : UserControl
    {
		#region?Fields?(2)?

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        private OpDepartmentType opDepatmentType;

		#endregion?Fields?

		#region?Enums?(1)?

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

		#endregion?Enums?

		#region?Constructors?(2)?

/// <summary>
        /// 
        /// </summary>
        /// <param name="opDepartmentType"></param>
        public DepartmentMgr(OpDepartmentType opDepartmentType)
            : this()
        {
            this.opDepatmentType = opDepartmentType;
            if (opDepartmentType == OpDepartmentType.DEPARTMENT_STAT)
            {
                this.colAssignAmount.Visible = true;
                this.colFinanceAmount.Visible = true;
                this.colCommissionIncome.Visible = true;
                this.colNetInterestIncome.Visible = true;
                this.colMarginIncome.Visible = true;
                this.colTotalIncome.Visible = true;
            }
            else if (opDepartmentType == OpDepartmentType.LOCATION_STAT)
            {
                this.dgvDepts.ContextMenuStrip = null;
                this.colDepartmentCode.Visible = false;
                this.colDepartmentName.Visible = false;
                this.colDomain.Visible = false;
                this.colManager.Visible = false;
                this.colContact.Visible = false;
                this.colAssignAmount.Visible = true;
                this.colFinanceAmount.Visible = true;
                this.colCommissionIncome.Visible = true;
                this.colNetInterestIncome.Visible = true;
                this.colMarginIncome.Visible = true;
                this.colTotalIncome.Visible = true;
                this.lblDepartmentCode.Visible = false;
                this.lblDepartmentName.Visible = false;
                this.tbDepartmentCode.Visible = false;
                this.tbDepartmentName.Visible = false;
            }
            else
            {
                this.lblDate.Visible = false;
                this.diBegin.Visible = false;
                this.diEnd.Visible = false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the DepartmentMgr class
        /// </summary>
        /// <param name="isEditable"></param>
        public DepartmentMgr()
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.bs = new BindingSource();
            this.dgvDepts.DataSource = this.bs;
            this.dgvDepts.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvDepts);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.UpdateContextMenu();
        }

		#endregion?Constructors?

		#region?Properties?(3)?

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Owner Form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Selected Department
        /// </summary>
        public Department Selected
        {
            get;
            set;
        }

		#endregion?Properties?

		#region?Methods?(9)?

		//?Private?Methods?(9)?

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.Detail(sender, e);
            }
            else
            {
                this.Select(sender, e);
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

            if (this.dgvDepts.SelectedRows.Count == 0)
            {
                return;
            }

            Department selectedDepartment = (Department)this.bs.List[this.dgvDepts.SelectedRows[0].Index];
            if (MessageBoxEx.Show("�Ƿ�ȷ��ɾ���ֲ�: " + selectedDepartment.DepartmentName, MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                context.Departments.DeleteOnSubmit(selectedDepartment);
                bool isDeleteOK = true;
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isDeleteOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (isDeleteOK)
                {
                    this.dgvDepts.Rows.RemoveAt(this.dgvDepts.SelectedRows[0].Index);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Detail(object sender, EventArgs e)
        {
            if (this.dgvDepts.SelectedRows.Count == 0)
            {
                return;
            }

            Department selectedDepartment = (Department)this.bs.List[this.dgvDepts.SelectedRows[0].Index];
            DepartmentDetail detail = new DepartmentDetail(selectedDepartment, DepartmentDetail.OpDepartmentType.DETAIL_DEPARTMENT);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDepts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvDepts.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvDepts.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvDepts.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
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

            DepartmentDetail detail = new DepartmentDetail(null, DepartmentDetail.OpDepartmentType.NEW_DEPARTMENT);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            context = new DBDataContext();

            DateTime beginDate = String.IsNullOrEmpty(this.diBegin.Text) ? this.diBegin.MinDate : this.diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(this.diEnd.Text) ? this.diEnd.MinDate : this.diEnd.Value;
            string pmanager = this.tbPManager.Text;
            string manager = this.tbManager.Text;

            if (opDepatmentType == OpDepartmentType.QUERY || opDepatmentType == OpDepartmentType.DEPARTMENT_STAT)
            {
                var queryResult = context.Departments.Where(d =>
                                 (d.DepartmentCode == null ? string.Empty : d.DepartmentCode).Contains(this.tbDepartmentCode.Text)
                              && (d.DepartmentName == null ? string.Empty : d.DepartmentName).Contains(this.tbDepartmentName.Text)
                              && (d.Location.PManager.Contains(pmanager)||d.Location.Assistant.Contains(pmanager))
                              && (d.Manager.Contains(manager) || d.Contact_1.Contains(manager) || d.Contact_2.Contains(manager))
                              );

                if (opDepatmentType == OpDepartmentType.DEPARTMENT_STAT)
                {
                    foreach (var c in queryResult)
                    {
                        c.QueryDateFrom = beginDate;
                        c.QueryDateTo = endDate;
                    }
                }

                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
            }
            else if (opDepatmentType == OpDepartmentType.LOCATION_STAT)
            {
                var result = from dept in context.Departments
                             group dept by dept.Location into depts
                             select new { Location = depts.Key, Departments = depts };

                SortableBindingCollection<City> locations = new SortableBindingCollection<City>();

                foreach (var loc in result)
                {
                    locations.Add(new City(loc.Location.LocationName, loc.Departments.ToList(), beginDate, endDate));
                }

                this.bs.DataSource = locations;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            this.tbDepartmentCode.Text = string.Empty;
            this.tbDepartmentName.Text = string.Empty;
        }

        /// <summary>
        /// Select department and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Select(object sender, System.EventArgs e)
        {
            if (this.dgvDepts.SelectedRows.Count == 0)
            {
                return;
            }

            Department selectedDepartment = (Department)this.bs.List[this.dgvDepts.SelectedRows[0].Index];
            this.Selected = selectedDepartment;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.SYSTEM_UPDATE))
            {
                this.menuItemDepartmentNew.Enabled = true;
                this.menuItemDepartmentDelete.Enabled = true;
            }
            else
            {
                this.menuItemDepartmentNew.Enabled = false;
                this.menuItemDepartmentDelete.Enabled = false;
            }
        }

		#endregion?Methods?
    }
}
