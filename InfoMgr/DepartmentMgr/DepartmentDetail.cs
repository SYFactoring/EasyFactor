//-----------------------------------------------------------------------
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
            this.departmentBindingSource.DataSource = department;
            this.UpdateDepartmentControlStatus();
        }

        #endregion Constructors

        #region Methods (2)

        // Private Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close(object sender, EventArgs e)
        {
            this.Close();
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
        }

        #endregion Methods
    }
}
