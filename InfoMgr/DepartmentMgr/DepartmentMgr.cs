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

    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentMgr : UserControl
    {
        #region Constructors (1)

        private BindingSource bs;

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

        #region Methods (7)

        // Private Methods (7) 

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

        #endregion Methods
    }
}
