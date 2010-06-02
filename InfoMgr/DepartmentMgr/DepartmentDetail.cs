//-----------------------------------------------------------------------
// <copyright file="DepartmentDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
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
    public partial class DepartmentDetail : Office2007Form
    {
        #region OpDepartmentType enum

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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private OpDepartmentType _opDepartmentType;


        /// <summary>
        /// Initializes a new instance of the DepartmentDetail class
        /// </summary>
        /// <param name="department"></param>
        /// <param name="opDepartmentType"></param>
        public DepartmentDetail(Department department, OpDepartmentType opDepartmentType)
        {
            _context = new DBDataContext();
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _opDepartmentType = opDepartmentType;

            cbLocation.DataSource = DB.dbml.Location.AllLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";

            if (opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {
                department = new Department();
            }
            else
            {
                department = _context.Departments.SingleOrDefault(d => d.DepartmentCode == department.DepartmentCode);
                tbPManager.Text = department.Location.PManager;
                tbAssistant.Text = department.Location.Assistant;
            }

            departmentBindingSource.DataSource = department;

            UpdateDepartmentControlStatus();
        }


        //?Private?Methods?(3)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveDepartment(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.SYSTEM_UPDATE))
            {
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            var dept = (Department) departmentBindingSource.DataSource;

            if (_opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {
                bool isAddOK = true;
                try
                {
                    _context.Departments.InsertOnSubmit(dept);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _opDepartmentType = OpDepartmentType.UPDATE_DEPARTMENT;
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
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
            _opDepartmentType = OpDepartmentType.UPDATE_DEPARTMENT;
            UpdateDepartmentControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateDepartmentControlStatus()
        {
            if (_opDepartmentType == OpDepartmentType.DETAIL_DEPARTMENT)
            {
                foreach (Control comp in groupPanelDepartment.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
            else if (_opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {
                foreach (Control comp in groupPanelDepartment.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opDepartmentType == OpDepartmentType.UPDATE_DEPARTMENT)
            {
                foreach (Control comp in groupPanelDepartment.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                departmentCodeTextBox.ReadOnly = true;
            }

            ControlUtil.SetComponetEditable(tbPManager, false);
            ControlUtil.SetComponetEditable(tbAssistant, false);
        }
    }
}