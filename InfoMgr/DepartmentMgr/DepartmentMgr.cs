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
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentMgr : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        #endregion Fields

        #region Enums (1)

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

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opDepartmentType"></param>
        public DepartmentMgr(OpDepartmentType opDepartmentType)
            : this()
        {
            if (opDepartmentType == OpDepartmentType.DEPARTMENT_STAT)
            {
                this.colAssignAmount.Visible = true;
                this.colFinanceAmount.Visible = true;
                this.colPaymentAmount.Visible = true;
                this.colIncomeAmount.Visible = true;
                this.Query(null, null);
            }
            else if (opDepartmentType == OpDepartmentType.LOCATION_STAT)
            {
                this.panelQuery.Visible = false;
                this.colDepartmentCode.Visible = false;
                this.colDepartmentName.Visible = false;
                this.colDomain.Visible = false;
                this.colManager.Visible = false;
                this.colContact.Visible = false;
                this.colAssignAmount.Visible = true;
                this.colFinanceAmount.Visible = true;
                this.colPaymentAmount.Visible = true;
                this.colIncomeAmount.Visible = true;

                var result = from dept in App.Current.DbContext.Departments
                             group dept by dept.Location into depts
                             select new { Location = depts.Key, Departments = depts };

                List<City> locations = new List<City>();
                foreach (var loc in result)
                {
                    locations.Add(new City(loc.Location, loc.Departments.ToList()));
                }

                this.bs.DataSource = locations;
            }
        }

        /// <summary>
        /// Initializes a new instance of the DepartmentMgr class
        /// </summary>
        /// <param name="isEditable"></param>
        public DepartmentMgr()
        {
            this.InitializeComponent();
            this.bs = new BindingSource();
            this.dgvDepts.DataSource = this.bs;
            this.dgvDepts.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvDepts);

            this.UpdateContextMenu();
        }

        #endregion Constructors

        #region Properties (2)

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

        #endregion Properties

        #region Methods (9)

        // Private Methods (9) 

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
            if (!PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                return;
            }

            if (this.dgvDepts.SelectedRows.Count == 0)
            {
                return;
            }

            Department selectedDepartment = (Department)this.bs.List[this.dgvDepts.SelectedRows[0].Index];
            if (MessageBox.Show("是否确定删除分部: " + selectedDepartment.DepartmentName, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                App.Current.DbContext.Departments.DeleteOnSubmit(selectedDepartment);
                bool isDeleteOK = true;
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isDeleteOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
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
            var queryResult = App.Current.DbContext.Departments.Where(d =>
                             (d.DepartmentCode == null ? string.Empty : d.DepartmentCode).Contains(this.tbDepartmentCode.Text)
                          && (d.DepartmentName == null ? string.Empty : d.DepartmentName).Contains(this.tbDepartmentName.Text));

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
            if (PermUtil.ValidatePermission(Permission.SYSTEM_UPDATE))
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

        #endregion Methods
    }
}
