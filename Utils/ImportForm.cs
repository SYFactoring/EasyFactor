
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
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public partial class ImportForm : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (4)

        private ApplicationClass app;
        private Worksheet datasheet;
        private ImportType importType;
        private Workbook workbook;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum ImportType
        {
            /// <summary>
            /// 
            /// </summary>
            IMPORT_USERS,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CLIENTS,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FACTORS,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_DEPARTMENTS,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CASES,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CREDITCOVER,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_ASSIGN,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FINANCE
        }

        #endregion Enums

        #region Constructors (1)

        public ImportForm(ImportType importType)
        {
            InitializeComponent();
            this.importType = importType;
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
                case ImportType.IMPORT_CREDITCOVER:
                    this.Text = "额度申请信息导入";
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

        #region Methods (16)

        // Private Methods (16) 

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
                case ImportType.IMPORT_CREDITCOVER:
                    e.Result = ImportCreditCover(this.tbFilePath.Text, worker);
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
                this.tbStatus.Text = "发生异常: " + e.Error.Message;
            }
            else if (e.Cancelled)
            {
                this.tbStatus.Text = "导入被取消";
            }
            else
            {
                this.tbStatus.Text = String.Format("导入结束,共导入{0}条记录", e.Result);
            }
            this.btnStart.Enabled = true;
            this.btnCancel.Text = "关闭";
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
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private object[,] GetValueArray(string fileName)
        {
            this.app = new ApplicationClass() { Visible = false };
            if (this.app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            this.workbook = (WorkbookClass)app.Workbooks.Open(
                fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);
            if (workbook.Sheets.Count < 1)
            {
                return null;
            }

            this.datasheet = (Worksheet)workbook.Sheets[1];
            Range range = datasheet.UsedRange;
            return (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportAssignBatch(string fileName, BackgroundWorker worker)
        {
            object[,] valueArray = GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                string lastCDACode = string.Empty;
                string lastAssignBatchNo = string.Empty;
                CDA cda = null;
                InvoiceAssignBatch assignBatch = null;
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
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
                    string isFlawStr = String.Format("{0:G}", valueArray[row, column++]);
                    if (isFlawStr == null || string.Empty.Equals(isFlawStr))
                    {
                        invoice.IsFlaw = false;
                    }
                    else
                    {
                        invoice.IsFlaw = "Y".Equals(isFlawStr);
                    }
                    invoice.FlawReason = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.Comment = invoice.Comment == string.Empty ? String.Format("{0:G}", valueArray[row, column++]) : invoice.Comment + "\t" + String.Format("{0:G}", valueArray[row, column++]);

                    invoice.InvoiceAssignBatch = assignBatch;

                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    string caseCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(caseCode))
                    {
                        continue;
                    }
                    bool isNew = false;
                    Case curCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
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
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private int ImportClients(string fileName, BackgroundWorker worker)
        {
            object[,] valueArray = this.GetValueArray(fileName);

            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    string clientEDICode = String.Format("{0:G}", valueArray[row, 2]);
                    if (string.Empty.Equals(clientEDICode))
                    {
                        continue;
                    }
                    bool isNew = false;
                    Client client = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                    if (client == null)
                    {
                        isNew = true;
                        client = new Client();
                        client.ClientEDICode = clientEDICode;
                    }
                    int column = 1;
                    client.ClientCoreNo = String.Format("{0:G}", valueArray[row, column++]);
                    column++;
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
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportCreditCover(string fileName, BackgroundWorker worker)
        {
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    string caseCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(caseCode))
                    {
                        continue;
                    }
                    Case curCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                    if (curCase == null)
                    {
                        continue;
                    }
                    int column = 2;
                    CreditCoverNegotiation creditCover = new CreditCoverNegotiation();
                    creditCover.ApproveType = String.Format("{0:G}", valueArray[row, column++]);
                    creditCover.RequestAmount = (double)valueArray[row, column++];
                    creditCover.RequestDate = (DateTime)valueArray[row, column++];
                    double approveAmount;
                    if (Double.TryParse(String.Format("{0:G}", valueArray[row, column++]), out approveAmount))
                    {
                        creditCover.ApproveAmount = approveAmount;
                    }
                    DateTime approveDate;
                    if (DateTime.TryParse(String.Format("{0:G}", valueArray[row, column++]), out approveDate))
                    {
                        creditCover.ApproveDate = approveDate;
                    }
                    double IFPrice;
                    if (Double.TryParse(String.Format("{0:G}", valueArray[row, column++]), out IFPrice))
                    {
                        creditCover.IFPrice = IFPrice;
                    }
                    creditCover.Comment = String.Format("{0:G}", valueArray[row, column++]);
                    creditCover.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                    creditCover.Case = curCase;
                    App.Current.DbContext.CreditCoverNegotiations.InsertOnSubmit(creditCover);
                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            this.ReleaseResource();
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
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {

                    string departmentCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(departmentCode))
                    {
                        continue;
                    }
                    bool isNew = false;
                    Department dept = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentCode == departmentCode);
                    if (dept == null)
                    {
                        isNew = true;
                        dept = new Department();
                        dept.DepartmentCode = departmentCode;
                    }

                    int column = 2;
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
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            this.ReleaseResource();
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
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    string factorCode = String.Format("{0:G}", valueArray[row, 2]);
                    if (string.Empty.Equals(factorCode))
                    {
                        continue;
                    }
                    bool isNew = false;
                    Factor factor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                    if (factor == null)
                    {
                        isNew = true;
                        factor = new Factor();
                        factor.FactorCode = factorCode;
                        factor.FactorType = "保理商";
                    }
                    if (factor.FactorType != "保理商")
                    {
                        factor.BeginMonitor();
                    }
                    int column = 1;
                    factor.CountryName = String.Format("{0:G}", valueArray[row, column++]);
                    column++;
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

                    string monitorResult = factor.EndMonitor();
                    if (!string.Empty.Equals(monitorResult))
                    {
                        DialogResult dr = MessageBox.Show(monitorResult, "是否更新", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            factor.LastModifiedDate = DateTime.Now;
                            if (isNew)
                            {
                                App.Current.DbContext.Factors.InsertOnSubmit(factor);
                            }
                        }
                        else
                        {
                            factor.Restore();
                        }
                        App.Current.DbContext.SubmitChanges();
                    }
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            this.ReleaseResource();
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
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                string lastCDACode = string.Empty;
                string lastFinanceBatchNo = string.Empty;
                CDA cda = null;
                InvoiceFinanceBatch financeBatch = null;

                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
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
                    int column = 3;
                    if (!lastFinanceBatchNo.Equals(financeBatchNo))
                    {
                        financeBatch = App.Current.DbContext.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == financeBatchNo);
                        if (financeBatch == null)
                        {
                            financeBatch = new InvoiceFinanceBatch();
                            financeBatch.FinanceBatchNo = financeBatchNo;
                        }
                        financeBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        financeBatch.FinanceType = String.Format("{0:G}", valueArray[row, column++]);
                        financeBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        financeBatch.FinanceAmount = (double)valueArray[row, column++];
                        financeBatch.FinanceRate = (double)valueArray[row, column++];
                        financeBatch.CostRate = (double)valueArray[row, column++];
                        financeBatch.FinancePeriodBegin = (DateTime)valueArray[row, column++];
                        financeBatch.FinnacePeriodEnd = (DateTime)valueArray[row, column++];
                        financeBatch.InterestType = String.Format("{0:G}", valueArray[row, column++]);
                        financeBatch.CDA = cda;
                        lastFinanceBatchNo = financeBatchNo;
                    }
                    column = 12;
                    Invoice invoice = null;
                    string invoiceNo = String.Format("{0:G}", valueArray[row, column++]);
                    invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                    if (invoice == null)
                    {
                        invoice = new Invoice();
                        invoice.InvoiceNo = invoiceNo;
                    }
                    invoice.FinanceAmount = (double)valueArray[row, column++];
                    invoice.FinanceDate = (DateTime)valueArray[row, column++];
                    invoice.FinanceDueDate = (DateTime)valueArray[row, column++];
                    invoice.Comment = invoice.Comment == string.Empty ? String.Format("{0:G}", valueArray[row, column++]) : invoice.Comment + "\t" + String.Format("{0:G}", valueArray[row, column++]);

                    invoice.InvoiceFinanceBatch = financeBatch;

                    App.Current.DbContext.SubmitChanges();
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            this.ReleaseResource();
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
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;
            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    string userId = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(userId))
                    {
                        continue;
                    }
                    bool isNew = false;
                    User user = App.Current.DbContext.Users.SingleOrDefault(c => c.UserID == userId);
                    if (user == null)
                    {
                        isNew = true;
                        user = new User();
                        user.UserID = userId;
                    }
                    int column = 2;
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
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReleaseResource()
        {
            if (this.datasheet != null)
            {
                Marshal.ReleaseComObject(datasheet);
                datasheet = null;
            }
            if (this.workbook != null)
            {
                Marshal.ReleaseComObject(workbook);
                workbook = null;
            }
            if (this.app != null)
            {
                app.Quit();
                Marshal.ReleaseComObject(app);
                app = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbFilePath.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartImport(object sender, EventArgs e)
        {
            string filePath = this.tbFilePath.Text;
            if (filePath.Trim().Equals(string.Empty))
                return;

            this.btnCancel.Text = "取消";
            backgroundWorker.RunWorkerAsync(filePath);

            this.btnStart.Enabled = false;
        }

        #endregion Methods
    }
}
