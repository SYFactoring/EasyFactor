using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

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

        private void QueryDepartments(object sender, EventArgs e)
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

        private void ImportDepartments(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Thread t = new Thread(ImportDepartmentsImpl);
                t.Start(fileName);
            }
        }

        private static void ImportDepartmentsImpl(object obj)
        {
            string fileName = obj as string;
            ApplicationClass app = new ApplicationClass { Visible = false };
            WorkbookClass w = (WorkbookClass)app.Workbooks.Open(
               @fileName,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value,
               Missing.Value);

            Sheets sheets = w.Worksheets;
            Worksheet datasheet = null;

            foreach (Worksheet sheet in sheets)
            {
                if (datasheet == null)
                {
                    datasheet = sheet;
                    break;
                }
            }

            if (datasheet == null)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                app.Quit();
                return;
            }

            Range range = datasheet.get_Range("A2", "AJ300");
            Array values = (Array)range.Formula;
            if (values != null)
            {
                int length = values.GetLength(0);

                for (int row = 1; row <= length; row++)
                {
                    if (!values.GetValue(row, 1).Equals(string.Empty))
                    {
                        Department dept = null;
                        try
                        {
                            int column = 1;
                            string departmentCode = values.GetValue(row, 1).ToString().Trim();
                            bool isNew = false;
                            dept = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentCode == departmentCode);
                            if (dept == null)
                            {
                                isNew = true;
                                dept = new Department();
                            }
                            dept.DepartmentCode = values.GetValue(row, column++).ToString().Trim();
                            //client.ClientEDICode = values.GetValue(row, column++).ToString().Trim();
                            //client.ClientNameCN = values.GetValue(row, column++).ToString().Trim();
                            //client.ClientNameEN_1 = values.GetValue(row, column++).ToString().Trim();
                            //client.ClientNameEN_2 = values.GetValue(row, column++).ToString().Trim();
                            //client.AddressCN = values.GetValue(row, column++).ToString().Trim();
                            //client.AddressEN = values.GetValue(row, column++).ToString().Trim();
                            //client.CityCN = values.GetValue(row, column++).ToString().Trim();
                            //client.CityEN = values.GetValue(row, column++).ToString().Trim();
                            //client.ProductCN = values.GetValue(row, column++).ToString().Trim();
                            //client.ProductEN = values.GetValue(row, column++).ToString().Trim();
                            //client.PostCode = values.GetValue(row, column++).ToString().Trim();
                            //client.CountryCode = values.GetValue(row, column++).ToString().Trim();
                            //client.Representative = values.GetValue(row, column++).ToString().Trim();
                            //client.Wetsite = values.GetValue(row, column++).ToString().Trim();
                            //client.Contact = values.GetValue(row, column++).ToString().Trim();
                            //client.Telephone = values.GetValue(row, column++).ToString().Trim();
                            //client.Email = values.GetValue(row, column++).ToString().Trim();
                            //client.FaxNumber = values.GetValue(row, column++).ToString().Trim();
                            //client.CellPhone = values.GetValue(row, column++).ToString().Trim();
                            //client.ClientType = values.GetValue(row, column++).ToString().Trim();
                            //client.Industry = values.GetValue(row, column++).ToString().Trim();
                            //client.ProductCN = values.GetValue(row, column++).ToString().Trim();
                            //client.ProductEN = values.GetValue(row, column++).ToString().Trim();
                            //client.ClientLevel = values.GetValue(row, column++).ToString().Trim();
                            //client.IsGroup = values.GetValue(row, column++).ToString().Trim();
                            //string groupNo = values.GetValue(row, column++).ToString().Trim();
                            //string groupNameCN = values.GetValue(row, column++).ToString().Trim();
                            //string groupNameEN = values.GetValue(row, column++).ToString().Trim();
                            //client.RegistrationNumber = values.GetValue(row, column++).ToString().Trim();
                            //client.CompanyCode = values.GetValue(row, column++).ToString().Trim();
                            //string departmentName = values.GetValue(row, column++).ToString().Trim();
                            //Department dep = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));
                            //if (dep != null)
                            //{
                            //    client.Department = dep;
                            //}
                            //client.PMName = values.GetValue(row, column++).ToString().Trim();
                            //client.RMName = values.GetValue(row, column++).ToString().Trim();
                            //client.Comment = values.GetValue(row, column++).ToString().Trim();

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
                }
                MessageBox.Show("导入结束", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            app.Quit();
        }
    }
}
