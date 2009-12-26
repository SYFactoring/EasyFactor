
namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.ARMgr;
    using CMBC.EasyFactor.DB.dbml;
    using Microsoft.Office.Interop.Excel;

    public partial class ImportForm : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        private ImportType importType;

        private ApplicationClass app;

        #endregion Fields

        #region Enums (1)

        public enum ImportType
        {
            IMPORT_USERS,
            IMPORT_CLIENTS,
            IMPORT_FACTORS,
            IMPORT_DEPARTMENTS,
            IMPORT_CASES,
            IMPORT_ASSIGN,
            IMPORT_FINANCE
        }

        #endregion Enums

        #region Constructors (1)

        public ImportForm(ImportType importType)
        {
            InitializeComponent();
            this.importType = importType;
            this.app = new ApplicationClass() { Visible = false };
            this.btnStart.Enabled = true;
            this.btnCancel.Enabled = false;
            switch (importType)
            {
                case ImportType.IMPORT_USERS:
                    this.Text = "用户信息导入";
                    break;
                case ImportType.IMPORT_CLIENTS:
                    this.Text = "客户信息导入";
                    break;
                case ImportType.IMPORT_FACTORS:
                    this.Text = "合作机构信息导入";
                    break;
                case ImportType.IMPORT_DEPARTMENTS:
                    this.Text = "部门信息导入";
                    break;
                case ImportType.IMPORT_CASES:
                    this.Text = "案件信息导入";
                    break;
                case ImportType.IMPORT_ASSIGN:
                    this.Text = "发票转让导入";
                    break;
                case ImportType.IMPORT_FINANCE:
                    this.Text = "发票融资导入";
                    break;
                default:
                    break;
            }
        }

        #endregion Constructors

        #region Methods (13)

        // Private Methods (13) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            switch (importType)
            {
                case ImportType.IMPORT_USERS:
                    e.Result = ImportUsers(this.tbFilePath.Text, worker);
                    break;
                case ImportType.IMPORT_CLIENTS:
                    e.Result = ImportClients(this.tbFilePath.Text, worker);
                    break;
                case ImportType.IMPORT_FACTORS:
                    e.Result = ImportFactors(this.tbFilePath.Text, worker);
                    break;
                case ImportType.IMPORT_DEPARTMENTS:
                    e.Result = ImportDepartments(this.tbFilePath.Text, worker);
                    break;
                case ImportType.IMPORT_CASES:
                    e.Result = ImportCases(this.tbFilePath.Text, worker);
                    break;
                case ImportType.IMPORT_ASSIGN:
                    e.Result = ImportAssignBatch(this.tbFilePath.Text, worker);
                    break;
                case ImportType.IMPORT_FINANCE:
                    e.Result = ImportFinanceBatch(this.tbFilePath.Text, worker);
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.tbStatus.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message + Environment.NewLine + e.Error.StackTrace, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Cancelled)
            {
                this.tbStatus.Text = "导入被取消";
            }
            else
            {
                this.tbStatus.Text = String.Format("共导入{0}条记录", e.Result);
            }
            this.btnStart.Enabled = true;
            this.btnCancel.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelImport(object sender, EventArgs e)
        {
            if (this.backgroundWorker.IsBusy)
            {
                this.backgroundWorker.CancelAsync();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private int ImportAssignBatch(string fileName, BackgroundWorker worker)
        {
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);
            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return 0;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            int result = 0;

            if (valueArray != null)
            {
                string lastCDACode = string.Empty;
                string lastAssignBatchNo = string.Empty;
                CDA cda = null;
                InvoiceAssignBatch assignBatch = null;

                for (int row = 2; row < range.Rows.Count; row++)
                {
                    string cdaCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(cdaCode))
                    {
                        continue;
                    }
                    if (!lastCDACode.Equals(cdaCode))
                    {
                        cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                        lastCDACode = cdaCode;
                    }
                    if (cda == null)
                    {
                        continue;
                    }
                    string assignBatchNo = String.Format("{0:G}", valueArray[row, 2]);
                    if (string.Empty.Equals(assignBatchNo))
                    {
                        continue;
                    }
                    if (!lastAssignBatchNo.Equals(assignBatchNo))
                    {
                        assignBatch = App.Current.DbContext.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchNo);
                        if (assignBatch == null)
                        {
                            assignBatch = new InvoiceAssignBatch();
                            assignBatch.AssignBatchNo = InvoiceAssign.GenerateAssignBatchNo(cda);
                        }
                        assignBatch.CreateUserName = String.Format("{0:G}", valueArray[row, 3]);
                        assignBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, 4]);
                        assignBatch.CDA = cda;
                        lastAssignBatchNo = assignBatchNo;
                    }

                    Invoice invoice = null;
                    string invoiceNo = String.Format("{0:G}", valueArray[row, 5]);
                    invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                    if (invoice == null)
                    {
                        invoice = new Invoice();
                        invoice.InvoiceNo = invoiceNo;
                    }
                    int column = 6;
                    invoice.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.InvoiceAmount = (double)valueArray[row, column++];
                    invoice.AssignAmount = (double)valueArray[row, column++];
                    invoice.InvoiceDate = (DateTime)valueArray[row, column++];
                    invoice.DueDate = (DateTime)valueArray[row, column++];
                    invoice.AssignDate = (DateTime)valueArray[row, column++];
                    invoice.IsFlaw = "Y".Equals(valueArray[row, column++]);
                    invoice.FlawReason = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.Comment = String.Format("{0:G}", valueArray[row, 23]);

                    invoice.InvoiceAssignBatch = assignBatch;

                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)range.Rows.Count));
                }
            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(datasheet);
            datasheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportCases(string fileName, BackgroundWorker worker)
        {
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);
            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return 0;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            int result = 0;

            if (valueArray != null)
            {
                for (int row = 2; row < range.Rows.Count; row++)
                {
                    Case curCase = null;
                    string caseCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(caseCode))
                    {
                        continue;
                    }
                    bool isNew = false;
                    curCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                    if (curCase == null)
                    {
                        isNew = true;
                        curCase = new Case();
                        curCase.CaseCode = caseCode;
                    }
                    int column = 2;
                    string ownerDeptName = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.OwnerDepartment = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName == ownerDeptName);
                    curCase.TransactionType = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.OperationType = String.Format("{0:G}", valueArray[row, column++]);
                    string coDeptName = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.CoDepartment = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName == coDeptName);
                    curCase.CaseMark = String.Format("{0:G}", valueArray[row, column++]);
                    string sellerEDICode = String.Format("{0:G}", valueArray[row, column++]);
                    column++;
                    curCase.SellerClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == sellerEDICode);
                    string buyerEDICode = String.Format("{0:G}", valueArray[row, column++]);
                    column++;
                    curCase.BuyerClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == buyerEDICode);
                    string EFCode = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.SellerFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == EFCode);
                    string IFCode = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.BuyerFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == IFCode);
                    curCase.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.CaseAppDate = (DateTime)valueArray[row, column++];
                    curCase.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);

                    if (isNew)
                    {
                        App.Current.DbContext.Cases.InsertOnSubmit(curCase);
                    }
                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)range.Rows.Count));
                }
            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(datasheet);
            datasheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private int ImportClients(string fileName, BackgroundWorker worker)
        {
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);

            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return 0;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            int result = 0;

            if (valueArray != null)
            {
                for (int row = 2; row < range.Rows.Count; row++)
                {
                    Client client = null;
                    int column = 1;
                    string clientEDICode = String.Format("{0:G}", valueArray[row, 2]);
                    if (string.Empty.Equals(clientEDICode))
                    {
                        continue;
                    }
                    bool isNew = false;
                    client = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                    if (client == null)
                    {
                        isNew = true;
                        client = new Client();
                    }
                    client.ClientCoreNo = String.Format("{0:G}", valueArray[row, column++]);
                    client.ClientEDICode = String.Format("{0:G}", valueArray[row, column++]);
                    client.ClientNameCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.ClientNameEN_1 = String.Format("{0:G}", valueArray[row, column++]);
                    client.ClientNameEN_2 = String.Format("{0:G}", valueArray[row, column++]);
                    client.AddressCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.AddressEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.CityCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.CityEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.ProductCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.ProductEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.PostCode = String.Format("{0:G}", valueArray[row, column++]);
                    client.CountryCode = String.Format("{0:G}", valueArray[row, column++]);
                    client.Representative = String.Format("{0:G}", valueArray[row, column++]);
                    client.Website = String.Format("{0:G}", valueArray[row, column++]);
                    client.Contact = String.Format("{0:G}", valueArray[row, column++]);
                    client.Telephone = String.Format("{0:G}", valueArray[row, column++]);
                    client.Email = String.Format("{0:G}", valueArray[row, column++]);
                    client.FaxNumber = String.Format("{0:G}", valueArray[row, column++]);
                    client.CellPhone = String.Format("{0:G}", valueArray[row, column++]);
                    client.ClientType = String.Format("{0:G}", valueArray[row, column++]);
                    client.Industry = String.Format("{0:G}", valueArray[row, column++]);
                    client.ProductCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.ProductEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.ClientLevel = String.Format("{0:G}", valueArray[row, column++]);
                    client.IsGroup = "是".Equals(valueArray[row, column++]);
                    string groupNo = String.Format("{0:G}", valueArray[row, column++]);
                    string groupNameCN = String.Format("{0:G}", valueArray[row, column++]);
                    string groupNameEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.RegistrationNumber = String.Format("{0:G}", valueArray[row, column++]);
                    client.CompanyCode = String.Format("{0:G}", valueArray[row, column++]);
                    string departmentName = String.Format("{0:G}", valueArray[row, column++]);
                    client.Department = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));

                    client.PMName = String.Format("{0:G}", valueArray[row, column++]);
                    client.RMName = String.Format("{0:G}", valueArray[row, column++]);
                    client.Comment = String.Format("{0:G}", valueArray[row, column++]);

                    if (isNew)
                    {
                        App.Current.DbContext.Clients.InsertOnSubmit(client);
                    }

                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)range.Rows.Count));
                }
            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(datasheet);
            datasheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportDepartments(string fileName, BackgroundWorker worker)
        {
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);

            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return 0;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            int result = 0;
            if (valueArray != null)
            {
                for (int row = 2; row < range.Rows.Count; row++)
                {
                    Department dept = null;
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
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)range.Rows.Count));
                }
            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(datasheet);
            datasheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportFactors(string fileName, BackgroundWorker worker)
        {
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);

            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return 0;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            int result = 0;
            if (valueArray != null)
            {
                for (int row = 2; row < range.Rows.Count; row++)
                {
                    Factor factor = null;
                    int column = 1;
                    string factorCode = String.Format("{0:G}", valueArray[row, 2]);
                    if (string.Empty.Equals(factorCode))
                    {
                        continue;
                    }
                    bool isNew = false;
                    factor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                    if (factor == null)
                    {
                        isNew = true;
                        factor = new Factor();
                        factor.FactorType = "保理商";
                    }
                    factor.CountryName = String.Format("{0:G}", valueArray[row, column++]);
                    factor.FactorCode = String.Format("{0:G}", valueArray[row, column++]);
                    factor.CompanyNameEN = String.Format("{0:G}", valueArray[row, column++]);
                    factor.ShortName = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Department = String.Format("{0:G}", valueArray[row, column++]);
                    factor.PostalAddress_1 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.PostalAddress_2 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.PostalCodePost = String.Format("{0:G}", valueArray[row, column++]);
                    factor.CityPost = String.Format("{0:G}", valueArray[row, column++]);
                    factor.VisitingAddress_1 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.VisitingAddress_2 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.PostalCodeVisiting = String.Format("{0:G}", valueArray[row, column++]);
                    factor.CityVisiting = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Email = String.Format("{0:G}", valueArray[row, column++]);
                    factor.WebSite = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Telephone_1 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Telephone_2 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Telefax_1 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Telefax_2 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.WorkingHours = String.Format("{0:G}", valueArray[row, column++]);
                    factor.GeneralCorrespondence_1 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.GeneralCorrespondence_2 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Contacts_1 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Contacts_2 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Contacts_3 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Contacts_4 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Management_1 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Management_2 = String.Format("{0:G}", valueArray[row, column++]);
                    factor.Shareholders = String.Format("{0:G}", valueArray[row, column++]);
                    factor.IFISAvailableOnPrivateForum = String.Format("{0:G}", valueArray[row, column++]);
                    factor.MembershipStatus = String.Format("{0:G}", valueArray[row, column++]);
                    factor.MembershipDate = String.Format("{0:G}", valueArray[row, column++]);
                    factor.DateOfLatestRevision = String.Format("{0:G}", valueArray[row, column++]);

                    if (isNew)
                    {
                        App.Current.DbContext.Factors.InsertOnSubmit(factor);
                    }

                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)range.Rows.Count));
                }
            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(datasheet);
            datasheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportFinanceBatch(string fileName, BackgroundWorker worker)
        {
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);
            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return 0;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            int result = 0;
            if (valueArray != null)
            {
                string lastCDACode = string.Empty;
                string lastFinanceBatchNo = string.Empty;
                CDA cda = null;
                InvoiceFinanceBatch financeBatch = null;

                for (int row = 2; row < range.Rows.Count; row++)
                {
                    string cdaCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(cdaCode))
                    {
                        continue;
                    }
                    if (!lastCDACode.Equals(cdaCode))
                    {
                        cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                        lastCDACode = cdaCode;
                    }
                    if (cda == null)
                    {
                        continue;
                    }
                    string financeBatchNo = String.Format("{0:G}", valueArray[row, 2]);
                    if (string.Empty.Equals(financeBatchNo))
                    {
                        continue;
                    }
                    if (!lastFinanceBatchNo.Equals(financeBatchNo))
                    {
                        financeBatch = App.Current.DbContext.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == financeBatchNo);
                        if (financeBatch == null)
                        {
                            financeBatch = new InvoiceFinanceBatch();
                            financeBatch.FinanceBatchNo = String.Format("{0:G}", valueArray[row, 2]);
                        }
                        financeBatch.CreateUserName = String.Format("{0:G}", valueArray[row, 3]);
                        financeBatch.FinanceType = String.Format("{0:G}", valueArray[row, 4]);
                        financeBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, 5]);
                        financeBatch.FinanceAmount = (double)valueArray[row, 6];
                        financeBatch.FinanceRate = (double)valueArray[row, 7];
                        financeBatch.CostRate = (double)valueArray[row, 8];
                        financeBatch.FinancePeriodBegin = (DateTime)valueArray[row, 9];
                        financeBatch.FinnacePeriodEnd = (DateTime)valueArray[row, 10];
                        financeBatch.InterestType = String.Format("{0:G}", valueArray[row, 11]);
                        financeBatch.CDA = cda;
                        lastFinanceBatchNo = financeBatchNo;
                    }

                    Invoice invoice = null;
                    string invoiceNo = String.Format("{0:G}", valueArray[row, 12]);
                    invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                    if (invoice == null)
                    {
                        invoice = new Invoice();
                        invoice.InvoiceNo = invoiceNo;
                    }
                    int column = 13;
                    invoice.FinanceAmount = (double)valueArray[row, column++];
                    invoice.FinanceDate = (DateTime)valueArray[row, column++];
                    invoice.FinanceDueDate = (DateTime)valueArray[row, column++];
                    invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);

                    invoice.InvoiceFinanceBatch = financeBatch;

                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)range.Rows.Count));
                }
            }
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(datasheet);
            datasheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportUsers(string fileName, BackgroundWorker worker)
        {
            WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
               fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing, Type.Missing);

            if (workbook.Sheets.Count < 1)
            {
                MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);
                return 0;
            }

            Worksheet datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
            int result = 0;
            if (valueArray != null)
            {
                for (int row = 2; row < range.Rows.Count; row++)
                {
                    User user = null;
                    int column = 1;
                    string userId = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(userId))
                    {
                        continue;
                    }
                    bool isNew = false;
                    user = App.Current.DbContext.Users.SingleOrDefault(c => c.UserID == userId);
                    if (user == null)
                    {
                        isNew = true;
                        user = new User();
                    }
                    user.UserID = String.Format("{0:G}", valueArray[row, column++]);
                    user.EDIAccount = String.Format("{0:G}", valueArray[row, column++]);
                    user.Password = String.Format("{0:G}", valueArray[row, column++]);
                    user.Role = String.Format("{0:G}", valueArray[row, column++]);
                    user.Name = String.Format("{0:G}", valueArray[row, column++]);
                    user.Phone = String.Format("{0:G}", valueArray[row, column++]);
                    user.Telphone = String.Format("{0:G}", valueArray[row, column++]);
                    user.Email = String.Format("{0:G}", valueArray[row, column++]);
                    user.MSN = String.Format("{0:G}", valueArray[row, column++]);

                    if (isNew)
                    {
                        App.Current.DbContext.Users.InsertOnSubmit(user);
                    }

                    App.Current.DbContext.SubmitChanges();

                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)range.Rows.Count));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            Marshal.ReleaseComObject(datasheet);
            datasheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;
            return result;
        }

        private void SelectFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbFilePath.Text = fileDialog.FileName;
            }
        }

        private void StartImport(object sender, EventArgs e)
        {
            string filePath = this.tbFilePath.Text;
            if (filePath.Trim().Equals(string.Empty))
                return;

            backgroundWorker.RunWorkerAsync(filePath);

            this.btnStart.Enabled = false;
            this.btnCancel.Enabled = true;
        }

        #endregion Methods


        private void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (app != null)
            {
                app.Quit();
            }
            Marshal.ReleaseComObject(app);
            app = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
