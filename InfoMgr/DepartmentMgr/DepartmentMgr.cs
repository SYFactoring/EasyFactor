//-----------------------------------------------------------------------
// <copyright file="DepartmentMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Runtime.InteropServices;

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
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(this.ImportDepartmentsImpl);
                t.Start(fileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void ImportDepartmentsImpl(object obj)
        {
            string fileName = obj as string;
            ApplicationClass app = new ApplicationClass { Visible = false };
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);

            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);

            if (valueArray != null)
            {
                for (int row = 2; row < range.Rows.Count; row++)
                {
                    Department dept = null;
                    try
                    {
                        int column = 1;
                        string departmentCode = String.Format("{0:G}", valueArray[row, 1]);
                        if (string.Empty.Equals(departmentCode))
                        {
                            continue;
                        }
                        bool isNew = false;
                        dept = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentCode == departmentCode);
                        if (dept == null)
                        {
                            isNew = true;
                            dept = new Department();
                        }
                        dept.DepartmentCode = string.Format("{0:G}", valueArray[row, column++]);
                        dept.DepartmentName = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Location = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Domain = string.Format("{0:G}", valueArray[row, column++]);
                        dept.AddressCN = string.Format("{0:G}", valueArray[row, column++]);
                        dept.AddressEN = string.Format("{0:G}", valueArray[row, column++]);
                        dept.PostCode = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Manager = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Contact_1 = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Email_1 = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Phone_1 = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Fax_1 = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Contact_2 = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Email_2 = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Phone_2 = string.Format("{0:G}", valueArray[row, column++]);
                        dept.Fax_2 = string.Format("{0:G}", valueArray[row, column++]);
                        if (isNew)
                        {
                            App.Current.DbContext.Departments.InsertOnSubmit(dept);
                        }

                        App.Current.DbContext.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        DialogResult dr = MessageBox.Show("导入失败: " + e.Message + "\t" + dept.DepartmentCode + "\n" + "是否继续导入？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.No)
                        {
                            break;
                        }
                    }
                }

                MessageBox.Show("导入结束", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(workbook);
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
