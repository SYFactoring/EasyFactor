using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    public partial class DepartmentDetail : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private OpDepartmentType opDepartmentType;
        
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

        public DepartmentDetail(Department department, OpDepartmentType opDepartmentType)
        {
            InitializeComponent();
            this.opDepartmentType = opDepartmentType;

            if (opDepartmentType == OpDepartmentType.NEW_DEPARTMENT)
            {

            }
            else
            {
                this.departmentBindingSource.DataSource = department;
            }

            this.UpdateDepartmentControlStatus();
        }

        private void UpdateDepartmentControlStatus()
        {
            if (opDepartmentType == OpDepartmentType.DETAIL_DEPARTMENT)
            {
                foreach (Control comp in this.groupPanelDepartment.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
            }
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
