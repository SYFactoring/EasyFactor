//-----------------------------------------------------------------------
// <copyright file="DepartmentMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    using System;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isEditable"></param>
        public DepartmentMgr(bool isEditable)
        {
            InitializeComponent();
            this.dgvDepts.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(this.dgvDepts);
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// 
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public Department Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (5)

        // Private Methods (5) 

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                //this.DetailClient(sender, e);
            }
            else
            {
                this.SelectDepartment(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportDepartments(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_DEPARTMENTS);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryDepartments(object sender, EventArgs e)
        {
            var queryResult = App.Current.DbContext.Departments.Where(d =>
                             (d.DepartmentCode == null ? string.Empty : d.DepartmentCode).Contains(this.tbDepartmentCode.Text)
                          && (d.DepartmentName == null ? string.Empty : d.DepartmentName).Contains(this.tbDepartmentName.Text));

            this.dgvDepts.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select department and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectDepartment(object sender, System.EventArgs e)
        {
            if (this.dgvDepts.SelectedRows.Count == 0)
            {
                return;
            }

            string did = (string)dgvDepts["departmentCodeColumn", dgvDepts.SelectedRows[0].Index].Value;
            if (did != null)
            {
                Department selectedDepartment = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentCode == did);
                if (selectedDepartment != null)
                {
                    this.Selected = selectedDepartment;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
            }
        }

        #endregion Methods
    }
}
