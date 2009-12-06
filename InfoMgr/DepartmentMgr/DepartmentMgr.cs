using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    public partial class DepartmentMgr : UserControl
    {
        public DepartmentMgr(bool isEditable)
        {
            InitializeComponent();
        }

        private void Query(object sender, EventArgs e)
        {
            var queryResult = App.Current.DbContext.Departments.Where( d =>
                             (this.tbDepartmentCode.Text == string.Empty||d.DepartmentCode.Contains(this.tbDepartmentCode.Text))
                          && (this.tbDepartmentName.Text == string.Empty||d.DepartmentName.Contains(this.tbDepartmentName.Text)));
            this.departmentMgrBindingSource.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }
    }
}
