﻿//-----------------------------------------------------------------------
// <copyright file="DepartmentDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentDetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private OpDepartmentType opDepartmentType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// Operation Type
        /// </summary>
        public enum OpDepartmentType
        {
            /// <summary>
            /// New Department
            /// </summary>
            NEW_DEPARTMENT,

            /// <summary>
            /// Update Department
            /// </summary>
            UPDATE_DEPARTMENT,

            /// <summary>
            /// Detail Department
            /// </summary>
            DETAIL_DEPARTMENT
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the DepartmentDetail class
        /// </summary>
        /// <param name="department"></param>
        /// <param name="opDepartmentType"></param>
        public DepartmentDetail(Department department, OpDepartmentType opDepartmentType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.opDepartmentType = opDepartmentType;

            if (opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {
                this.departmentBindingSource.DataSource = new Department();
            }
            else
            {
                this.departmentBindingSource.DataSource = department;
                department.Backup();
            }

            this.UpdateDepartmentControlStatus();
        }

        #endregion Constructors

        #region Methods (6)

        // Private Methods (6) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Department dept = (Department)this.departmentBindingSource.DataSource;
            if (opDepartmentType == OpDepartmentType.UPDATE_DEPARTMENT)
            {
                dept.Restore();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetDepartment(object sender, EventArgs e)
        {
            if (opDepartmentType == OpDepartmentType.UPDATE_DEPARTMENT)
            {
                Department dept = this.departmentBindingSource.DataSource as Department;
                dept.Restore();
            }
            else if (opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {
                this.departmentBindingSource.DataSource = new Department();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveDepartment(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                return;
            }

            if (!this.superValidator.Validate())
            {
                return;
            }

            Department dept = (Department)this.departmentBindingSource.DataSource;

            if (opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {
                bool isAddOK = true;
                try
                {
                    App.Current.DbContext.Departments.InsertOnSubmit(dept);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dept.Backup();
                    opDepartmentType = OpDepartmentType.UPDATE_DEPARTMENT;
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dept.Backup();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDepartment(object sender, EventArgs e)
        {
            opDepartmentType = OpDepartmentType.UPDATE_DEPARTMENT;
            UpdateDepartmentControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateDepartmentControlStatus()
        {
            if (this.opDepartmentType == OpDepartmentType.DETAIL_DEPARTMENT)
            {
                foreach (Control comp in this.groupPanelDepartment.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (this.opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {
                foreach (Control comp in this.groupPanelDepartment.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opDepartmentType == OpDepartmentType.UPDATE_DEPARTMENT)
            {
                foreach (Control comp in this.groupPanelDepartment.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                this.departmentCodeTextBox.ReadOnly = true;
            }
        }

        #endregion Methods
    }
}
