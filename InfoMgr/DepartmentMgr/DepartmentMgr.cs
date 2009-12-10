using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    public partial class DepartmentMgr : UserControl
    {

        public Form OwnerForm
        {
            get;
            set;
        }

        public Department Selected
        {
            get;
            set;
        }

        public DepartmentMgr(bool isEditable)
        {
            InitializeComponent();
        }

        private void Query(object sender, EventArgs e)
        {
            var queryResult = App.Current.DbContext.Departments.Where( d =>
                             (this.tbDepartmentCode.Text == string.Empty||d.DepartmentCode.Contains(this.tbDepartmentCode.Text))
                          && (this.tbDepartmentName.Text == string.Empty||d.DepartmentName.Contains(this.tbDepartmentName.Text)));
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
            if (this.dgvDepts.SelectedRows.Count == 0 )
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
    }
}
