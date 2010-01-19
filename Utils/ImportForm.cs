
namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.ARMgr;
    using CMBC.EasyFactor.DB.dbml;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class ImportForm : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (5)

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
            IMPORT_CLIENTS_CREDITLINE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FACTORS,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FACTORS_CREDITLINE,

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
            IMPORT_CONTRACT_CDA,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_INVOICES_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_INVOICES,

        }

        #endregion Enums

        #region Constructors (1)

        public ImportForm(ImportType importType)
        {
            InitializeComponent();
            this.importType = importType;
            switch (importType)
            {
                case ImportType.IMPORT_USERS:
                    this.Text = "用户信息导入";
                    break;
                case ImportType.IMPORT_CLIENTS:
                    this.Text = "客户信息导入";
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    this.Text = "客户额度信息导入";
                    break;
                case ImportType.IMPORT_FACTORS:
                    this.Text = "合作机构信息导入";
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    this.Text = "合作机构额度信息导入";
                    break;
                case ImportType.IMPORT_DEPARTMENTS:
                    this.Text = "部门信息导入";
                    break;
                case ImportType.IMPORT_CASES:
                    this.Text = "案件信息导入";
                    break;
                case ImportType.IMPORT_CONTRACT_CDA:
                    this.Text = "保理合同及额度通知书导入";
                    break;
                case ImportType.IMPORT_INVOICES_BY_BATCH:
                    this.Text = "当前批次导入";
                    break;
                case ImportType.IMPORT_INVOICES:
                    this.Text = "台帐导入";
                    break;
                default:
                    break;
            }
        }

        #endregion Constructors

        #region Properties (1)

        public IList ImportedList
        {
            set;
            get;
        }

        #endregion Properties

        #region Methods (19)

        // Private Methods (19) 

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
                    e.Result = ImportUsers((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS:
                    e.Result = ImportClients((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    e.Result = ImportClientsCreditLine((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FACTORS:
                    e.Result = ImportFactors((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    e.Result = ImportFactorsCreditLine((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_DEPARTMENTS:
                    e.Result = ImportDepartments((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CASES:
                    e.Result = ImportCases((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CONTRACT_CDA:
                    e.Result = ImportContractAndCDA((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_INVOICES_BY_BATCH:
                    e.Result = ImportInvoicesByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_INVOICES:
                    e.Result = ImportInvoices((string)e.Argument, worker, e);
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
            this.tbStatus.Text = String.Format("导入进度 {0:G}%", e.ProgressPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ReleaseResource();
            if (e.Error != null)
            {
                this.tbStatus.Text = "发生异常: " + e.Error.Message;
            }
            else if (e.Cancelled)
            {
                this.tbStatus.Text = "导入被取消";
                this.progressBar.Value = 0;
            }
            else
            {
                this.tbStatus.Text = String.Format("导入结束,共导入{0}条记录", e.Result);
            }
            this.btnStart.Enabled = true;
            this.btnCancel.Text = "关闭";
            if (e.Error == null && this.importType == ImportType.IMPORT_INVOICES_BY_BATCH)
            {
                this.Close();
            }
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
        /// <param name="sheetIndex"></param>
        /// <returns></returns>
        private object[,] GetValueArray(string fileName, int sheetIndex)
        {
            ReleaseResource();

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            this.app = new ApplicationClass() { Visible = false };
            if (this.app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            this.workbook = (WorkbookClass)app.Workbooks.Open(
                fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);
            if (workbook.Sheets.Count < sheetIndex)
            {
                return null;
            }

            this.datasheet = (Worksheet)workbook.Sheets[sheetIndex];
            Range range = datasheet.UsedRange;
            return (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportCases(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<Case> caseList = new List<Case>();
                List<CreditCoverNegotiation> creditCoverList = new List<CreditCoverNegotiation>();
                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string caseCode = String.Format("{0:G}", valueArray[row, 1]);
                        if (String.Empty.Equals(caseCode))
                        {
                            continue;
                        }

                        Case curCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase == null)
                        {
                            curCase = new Case();
                            curCase.CaseCode = caseCode;
                            caseList.Add(curCase);
                        }
                        int column = 2;
                        curCase.ManagerName = String.Format("{0:G}", valueArray[row, column++]);
                        string ownerDeptName = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.OwnerDepartment = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName == ownerDeptName);
                        curCase.TransactionType = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.ReviewNo = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.OperationType = String.Format("{0:G}", valueArray[row, column++]);
                        string coDeptName = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.CoDepartment = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName == coDeptName);
                        curCase.CaseMark = String.Format("{0:G}", valueArray[row, column++]);
                        string sellerEDICode = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.SellerClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == sellerEDICode);
                        column++;
                        column++;
                        string buyerEDICode = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.BuyerClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == buyerEDICode);
                        column++;
                        column++;
                        string EFCode = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.SellerFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == EFCode);
                        string IFCode = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.BuyerFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == IFCode);
                        column++;
                        curCase.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.NetPaymentTerm = (System.Nullable<int>)valueArray[row, column++];
                        curCase.CaseAppDate = (DateTime)valueArray[row, column++];
                        curCase.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        if (valueArray.GetUpperBound(1) > 30)
                        {
                            CreditCoverNegotiation creditCover = new CreditCoverNegotiation();
                            string requestType = String.Format("{0:G}", valueArray[row, column++]);
                            if ("P".Equals(requestType))
                            {
                                creditCover.RequestType = "P-预额度";
                            }
                            else if ("C".Equals(requestType))
                            {
                                creditCover.RequestType = "C-正式额度";
                            }
                            creditCover.RequestAmount = (double)valueArray[row, column++];
                            curCase.NetPaymentTerm = (int)valueArray[row, column++];
                            creditCover.RequestDate = (DateTime)valueArray[row, column++];
                            creditCover.ReplyAmount = (double)valueArray[row, column++];
                            creditCover.ReplyDate = (System.Nullable<DateTime>)valueArray[row, column++];
                            creditCover.IFPrice = (System.Nullable<double>)valueArray[row, column++];
                            column++;
                            creditCover.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                            creditCover.Comment = String.Format("{0:G}", valueArray[row, column++]);
                            if (creditCover.RequestType != null)
                            {
                                creditCover.Case = curCase;
                                creditCoverList.Add(creditCover);
                            }
                        }
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (Case curCase in caseList)
                    {
                        curCase.BuyerClient = null;
                        curCase.SellerClient = null;
                        curCase.BuyerFactor = null;
                        curCase.SellerFactor = null;
                        curCase.CoDepartment = null;
                        curCase.OwnerDepartment = null;
                    }
                    foreach (CreditCoverNegotiation neg in creditCoverList)
                    {
                        neg.Case = null;
                    }
                    throw e1;
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
        private int ImportClients(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);

            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return -1;
                    }

                    string clientEDICode = String.Format("{0:G}", valueArray[row, 2]);
                    if (String.Empty.Equals(clientEDICode))
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
                    client.ClientNameEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.AddressCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.AddressEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.CityCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.CityEN = String.Format("{0:G}", valueArray[row, column++]);
                    client.ProvinceCN = String.Format("{0:G}", valueArray[row, column++]);
                    client.ProvinceEN = String.Format("{0:G}", valueArray[row, column++]);
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
                    string groupNo = String.Format("{0:G}", valueArray[row, column++]);
                    if (groupNo != string.Empty)
                    {
                        Client clientGroup = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == groupNo);
                        if (clientGroup == null)
                        {
                            throw new Exception("集团客户号错误: " + groupNo);
                        }
                    }
                    column++;
                    client.RegistrationNumber = String.Format("{0:G}", valueArray[row, column++]);
                    client.CompanyCode = String.Format("{0:G}", valueArray[row, column++]);
                    string departmentName = String.Format("{0:G}", valueArray[row, column++]);
                    client.Department = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));

                    client.PMName = String.Format("{0:G}", valueArray[row, column++]);
                    client.RMName = String.Format("{0:G}", valueArray[row, column++]);
                    client.Comment = String.Format("{0:G}", valueArray[row, column++]);
                    client.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                    if (client.CreateUserName == string.Empty)
                    {
                        client.CreateUserName = App.Current.CurUser.Name;
                    }

                    if (isNew)
                    {
                        App.Current.DbContext.Clients.InsertOnSubmit(client);
                    }

                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
                App.Current.DbContext.SubmitChanges();
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
        private object ImportClientsCreditLine(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<ClientCreditLine> creditLineList = new List<ClientCreditLine>();
                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string clientEDICode = String.Format("{0:G}", valueArray[row, 1]);
                        if (String.Empty.Equals(clientEDICode))
                        {
                            continue;
                        }
                        Client client = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户保理代码错误: " + clientEDICode);
                        }
                        int column = 3;
                        ClientCreditLine creditLine = new ClientCreditLine();
                        creditLine.CreditLineType = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLineCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLine = (double)valueArray[row, column++]; ;
                        creditLine.PeriodBegin = (DateTime)valueArray[row, column++]; ;
                        creditLine.PeriodEnd = (DateTime)valueArray[row, column++]; ;
                        creditLine.ApproveNo = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.ApproveType = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLineStatus = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.FreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Freezer = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.FreezeDate = (System.Nullable<DateTime>)valueArray[row, column++]; ;
                        creditLine.UnfreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Unfreezer = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Client = client;
                        creditLineList.Add(creditLine);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (ClientCreditLine creditLine in creditLineList)
                    {
                        creditLine.Client = null;
                    }
                    throw e1;
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
        private int ImportContractAndCDA(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);

            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<Contract> contractList = new List<Contract>();
                List<CDA> cdaList = new List<CDA>();
                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        int column = 1;
                        string caseCode = String.Format("{0:G}", valueArray[row, column++]);
                        if (string.Empty.Equals(caseCode))
                        {
                            continue;
                        }
                        Case curCase = null;
                        curCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase == null)
                        {
                            throw new Exception("案件编号错误: " + caseCode);
                        }

                        string ContractCode = String.Format("{0:G}", valueArray[row, column++]);
                        Contract contract = null;
                        if (String.Empty.Equals(ContractCode) && curCase.TransactionType != "进口保理")
                        {
                            throw new Exception("保理合同号不能为空");
                        }
                        if (!String.Empty.Equals(ContractCode))
                        {
                            contract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == ContractCode);
                            if (contract == null)
                            {
                                contract = contractList.SingleOrDefault(c => c.ContractCode == ContractCode);
                                if (contract == null)
                                {
                                    contract = new Contract();
                                    contract.ContractCode = ContractCode;
                                    contract.Client = curCase.SellerClient;
                                    contractList.Add(contract);
                                }
                            }
                            contract.ContractType = String.Format("{0:G}", valueArray[row, column++]);
                            contract.ContractValueDate = (DateTime)valueArray[row, column++];
                            contract.ContractDueDate = (DateTime)valueArray[row, column++];
                            contract.ContractStatus = String.Format("{0:G}", valueArray[row, column++]);
                            contract.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        }

                        column = 8;
                        string cdaCode = String.Format("{0:G}", valueArray[row, column++]);
                        CDA cda = null;
                        if (String.Empty.Equals(cdaCode))
                        {
                            throw new Exception("CDA编号不能为空");

                        }
                        else
                        {
                            cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                            if (cda == null)
                            {
                                cda = new CDA();
                                cda.CDACode = cdaCode;
                                cda.CheckStatus = "已复核";
                                cdaList.Add(cda);
                            }
                            cda.Case = curCase;
                        }
                        column++;//卖方
                        column++;//买方
                        column++;//保理商
                        column++;//业务类别
                        column++;//发票币别
                        cda.IsRecoarse = "Y".Equals(valueArray[row, column++]);
                        cda.IsNotice = String.Format("{0:G}", valueArray[row, column++]);
                        cda.AssignType = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CreditCoverCurr = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CreditCover = (System.Nullable<double>)valueArray[row, column++];
                        cda.CreditCoverPeriodBegin = (System.Nullable<DateTime>)valueArray[row, column++];
                        cda.CreditCoverPeriodEnd = (System.Nullable<DateTime>)valueArray[row, column++];
                        cda.PUGProportion = (System.Nullable<double>)valueArray[row, column++];
                        cda.PUGPeriod = (System.Nullable<int>)valueArray[row, column++];
                        cda.ReassignGracePeriod = (System.Nullable<int>)valueArray[row, column++];
                        cda.FinanceLineCurr = String.Format("{0:G}", valueArray[row, column++]);
                        cda.FinanceLine = (System.Nullable<double>)valueArray[row, column++];
                        cda.FinanceLinePeriodBegin = (System.Nullable<DateTime>)valueArray[row, column++];
                        cda.FinanceLinePeriodEnd = (System.Nullable<DateTime>)valueArray[row, column++];
                        column++;//最高保理预付款额度
                        cda.FinanceProportion = (System.Nullable<double>)valueArray[row, column++];
                        cda.FinanceGracePeriod = (System.Nullable<int>)valueArray[row, column++];
                        cda.PaymentTerms = String.Format("{0:G}", valueArray[row, column++]);
                        cda.OrderNumber = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Deductibles = (System.Nullable<double>)valueArray[row, column++];
                        cda.LossThreshold = (System.Nullable<double>)valueArray[row, column++];
                        cda.Price = (System.Nullable<double>)valueArray[row, column++];
                        cda.IFPrice = (System.Nullable<double>)valueArray[row, column++];
                        cda.EFPrice = (System.Nullable<double>)valueArray[row, column++];
                        cda.HandFeeCurr = String.Format("{0:G}", valueArray[row, column++]);
                        cda.HandFee = (System.Nullable<double>)valueArray[row, column++];
                        cda.CommissionType = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CommissionTypeComment = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CDASignDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        cda.CDAStatus = String.Format("{0:G}", valueArray[row, column++]);
                        cda.NoticeMethod = String.Format("{0:G}", valueArray[row, column++]);
                        cda.NoticePerson = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Email = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Fax = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (Contract contract in contractList)
                    {
                        contract.Client = null;
                    }
                    foreach (CDA cda in cdaList)
                    {
                        cda.Case = null;
                    }
                    throw e1;
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
        private int ImportDepartments(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return -1;
                    }

                    string departmentCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (String.Empty.Equals(departmentCode))
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
                    dept.DepartmentName = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Location = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Domain = String.Format("{0:G}", valueArray[row, column++]);
                    dept.AddressCN = String.Format("{0:G}", valueArray[row, column++]);
                    dept.AddressEN = String.Format("{0:G}", valueArray[row, column++]);
                    dept.PostCode = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Manager = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Contact_1 = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Email_1 = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Phone_1 = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Fax_1 = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Contact_2 = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Email_2 = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Phone_2 = String.Format("{0:G}", valueArray[row, column++]);
                    dept.Fax_2 = String.Format("{0:G}", valueArray[row, column++]);
                    if (isNew)
                    {
                        App.Current.DbContext.Departments.InsertOnSubmit(dept);
                    }

                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
                App.Current.DbContext.SubmitChanges();
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
        private int ImportFactors(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<Factor> factorList = new List<Factor>();
                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string factorCode = String.Format("{0:G}", valueArray[row, 2]);
                        if (String.Empty.Equals(factorCode))
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
                        factor.CreateUserName = App.Current.CurUser.Name;

                        string monitorResult = factor.EndMonitor();
                        if (!String.Empty.Equals(monitorResult))
                        {
                            DialogResult dr = MessageBox.Show(monitorResult, "是否更新", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dr == DialogResult.Yes)
                            {
                                factor.LastModifiedDate = DateTime.Now;
                            }
                            else
                            {
                                factor.Restore();
                            }
                        }
                        if (isNew)
                        {
                            factorList.Add(factor);
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    App.Current.DbContext.Factors.InsertAllOnSubmit(factorList);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    throw e1;
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
        private object ImportFactorsCreditLine(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            {
                object[,] valueArray = this.GetValueArray(fileName, 1);
                int result = 0;

                if (valueArray != null)
                {
                    int size = valueArray.GetUpperBound(0);
                    List<FactorCreditLine> creditLineList = new List<FactorCreditLine>();
                    try
                    {
                        for (int row = 2; row <= size; row++)
                        {
                            if (worker.CancellationPending)
                            {
                                e.Cancel = true;
                                return -1;
                            }

                            string factorCode = String.Format("{0:G}", valueArray[row, 1]);
                            if (String.Empty.Equals(factorCode))
                            {
                                continue;
                            }
                            Factor factor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                throw new Exception("合作机构代码错误: " + factorCode);
                            }
                            int column = 2;
                            FactorCreditLine creditLine = new FactorCreditLine();
                            creditLine.CreditLineType = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.CreditLineCurrency = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.CreditLine = (double)valueArray[row, column++]; ;
                            creditLine.PeriodBegin = (DateTime)valueArray[row, column++]; ;
                            creditLine.PeriodEnd = (DateTime)valueArray[row, column++]; ;
                            creditLine.ApproveNo = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.ApproveType = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.CreditLineStatus = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.FreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.Freezer = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.FreezeDate = (System.Nullable<DateTime>)valueArray[row, column++]; ;
                            creditLine.UnfreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.Unfreezer = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.Comment = String.Format("{0:G}", valueArray[row, column++]);
                            creditLine.Factor = factor;
                            creditLineList.Add(creditLine);
                        }
                        App.Current.DbContext.FactorCreditLines.InsertAllOnSubmit(creditLineList);
                        App.Current.DbContext.SubmitChanges();
                    }
                    catch (Exception e1)
                    {
                        foreach (FactorCreditLine creditLine in creditLineList)
                        {
                            creditLine.Factor = null;
                        }
                        throw e1;
                    }
                }
                worker.ReportProgress(100);
                workbook.Close(false, fileName, null);
                this.ReleaseResource();
                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportInvoices(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = GetValueArray(fileName, 1);
            object[,] valueArray2 = GetValueArray(fileName, 2);
            int totalSize = 0;
            if (valueArray != null)
            {
                totalSize += valueArray.GetUpperBound(0);
            }
            if (valueArray2 != null)
            {
                totalSize += valueArray2.GetUpperBound(0);
            }

            int result = 0;
            CDA cda = null;
            List<InvoiceAssignBatch> assignBatches = new List<InvoiceAssignBatch>();
            List<InvoiceFinanceBatch> financeBatches = new List<InvoiceFinanceBatch>();
            List<InvoicePaymentBatch> paymentBatches = new List<InvoicePaymentBatch>();
            List<InvoiceRefundBatch> refundBatches = new List<InvoiceRefundBatch>();
            List<Invoice> invoiceList = new List<Invoice>();
            try
            {
                if (valueArray != null)
                {
                    int size = valueArray.GetUpperBound(0);
                    int column;
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        //CDA
                        string cdaCode = String.Format("{0:G}", valueArray[row, 1]);
                        if (string.Empty.Equals(cdaCode))
                        {
                            continue;
                        }
                        if (cda == null || cda.CDACode != cdaCode)
                        {
                            cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                            if (cda == null)
                            {
                                throw new Exception("额度通知书编号错误: " + cdaCode);
                            }
                        }

                        //转让批次信息
                        column = 3;
                        string assignBatchNo = String.Format("{0:G}", valueArray[row, column++]);
                        InvoiceAssignBatch assignBatch = null;
                        if (assignBatchNo != string.Empty)
                        {
                            assignBatch = assignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchNo);
                            if (assignBatch == null)
                            {
                                assignBatch = App.Current.DbContext.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchNo);
                                if (assignBatch == null)
                                {
                                    throw new Exception("转让批号错误: " + assignBatchNo);
                                }
                            }
                        }
                        else
                        {
                            DateTime assignDate = (DateTime)valueArray[row, column++];
                            assignBatch = assignBatches.SingleOrDefault(i => i.CDA.CDACode == cdaCode && i.AssignDate == assignDate);
                            if (assignBatch == null)
                            {
                                assignBatch = new InvoiceAssignBatch();
                                assignBatch.AssignDate = assignDate;
                                assignBatch.IsCreateMsg = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                                assignBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                                assignBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                                assignBatch.CheckStatus = "已复核";
                                assignBatch.AssignBatchNo = Invoice.GenerateAssignBatchNo(assignBatch.AssignDate, assignBatches);
                                assignBatch.CDA = cda;
                                assignBatches.Add(assignBatch);
                            }
                        }

                        //发票信息
                        column = 8;
                        string invoiceNo = String.Format("{0:G}", valueArray[row, column++]);
                        if (invoiceNo == string.Empty)
                        {
                            throw new Exception("发票号不能为空");
                        }
                        Invoice invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                        if (invoice == null)
                        {
                            invoice = new Invoice();
                            invoice.InvoiceNo = invoiceNo;
                            Invoice old = invoiceList.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                            if (old == null)
                            {
                                invoiceList.Add(invoice);
                            }
                            else
                            {
                                throw new Exception("发票号重复: " + old.InvoiceNo);
                            }
                        }
                        invoice.InvoiceAmount = (double)valueArray[row, column++];
                        invoice.AssignAmount = (double)valueArray[row, column++];
                        invoice.InvoiceDate = (DateTime)valueArray[row, column++];
                        invoice.DueDate = (DateTime)valueArray[row, column++];
                        invoice.IsFlaw = TypeUtil.ConvertStrToBool(valueArray[row, column++]);

                        if (assignBatch == null)
                        {
                            throw new Exception("缺少转让批次信息: " + invoice.InvoiceNo);
                        }
                        invoice.InvoiceAssignBatch = assignBatch;

                        //融资批次信息
                        column = 14;
                        string financeBatchNo = String.Format("{0:G}", valueArray[row, column++]);
                        InvoiceFinanceBatch financeBatch = null;
                        if (financeBatchNo != string.Empty)
                        {
                            financeBatch = financeBatches.SingleOrDefault(i => i.FinanceBatchNo == financeBatchNo);
                            if (financeBatch == null)
                            {
                                financeBatch = App.Current.DbContext.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == financeBatchNo);
                                if (financeBatch == null)
                                {
                                    throw new Exception("融资批号错误: " + financeBatchNo);
                                }
                            }
                        }
                        else
                        {
                            DateTime? financeDate = (System.Nullable<DateTime>)valueArray[row, 22];
                            if (financeDate != null)
                            {
                                financeBatch = financeBatches.SingleOrDefault(i => i.CDA.CDACode == cdaCode && i.FinancePeriodBegin == financeDate);
                                if (financeBatch == null)
                                {
                                    financeBatch = new InvoiceFinanceBatch();
                                    column = 15;
                                    financeBatch.FinanceType = String.Format("{0:G}", valueArray[row, column++]);
                                    string factorCode = String.Format("{0:G}", valueArray[row, column++]);
                                    financeBatch.Factor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                                    column++;
                                    financeBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                                    financeBatch.FinanceRate = (System.Nullable<double>)valueArray[row, column++];
                                    financeBatch.CostRate = (System.Nullable<double>)valueArray[row, column++];
                                    financeBatch.InterestType = String.Format("{0:G}", valueArray[row, column++]);
                                    financeBatch.FinancePeriodBegin = (DateTime)valueArray[row, column++];
                                    financeBatch.FinnacePeriodEnd = (DateTime)valueArray[row, column++];
                                    financeBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                                    financeBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                                    financeBatch.CheckStatus = "已复核";
                                    financeBatch.FinanceBatchNo = Invoice.GenerateFinanceBatchNo(financeBatch.FinancePeriodBegin, financeBatches);
                                    financeBatch.CDA = cda;
                                    financeBatches.Add(financeBatch);
                                }
                            }
                        }

                        //融资信息
                        column = 26;
                        invoice.FinanceAmount = (System.Nullable<double>)valueArray[row, column++];
                        if (invoice.FinanceAmount.HasValue)
                        {
                            if (financeBatch == null)
                            {
                                throw new Exception("缺少融资批次信息: " + invoice.InvoiceNo);
                            }
                            financeBatch.FinanceAmount += invoice.FinanceAmount.Value;
                            invoice.InvoiceFinanceBatch = financeBatch;
                            invoice.FinanceDate = financeBatch.FinancePeriodBegin;
                            invoice.FinanceDueDate = financeBatch.FinnacePeriodEnd;
                        }

                        //付款批次信息
                        column = 27;
                        string paymentBatchNo = String.Format("{0:G}", valueArray[row, column++]);
                        InvoicePaymentBatch paymentBatch = null;
                        if (paymentBatchNo != string.Empty)
                        {
                            paymentBatch = paymentBatches.SingleOrDefault(i => i.PaymentBatchNo == paymentBatchNo);
                            if (paymentBatch == null)
                            {
                                paymentBatch = App.Current.DbContext.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == paymentBatchNo);
                                if (paymentBatch == null)
                                {
                                    throw new Exception("付款批号错误: " + paymentBatchNo);
                                }
                            }
                        }
                        else
                        {
                            string paymentType = String.Format("{0:G}", valueArray[row, column++]);
                            DateTime? paymentDate = (System.Nullable<DateTime>)valueArray[row, column++];
                            if (paymentDate != null)
                            {
                                paymentBatch = paymentBatches.SingleOrDefault(i => i.CDA.CDACode == cdaCode && i.PaymentDate == paymentDate && i.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch();
                                    paymentBatch.PaymentType = paymentType;
                                    paymentBatch.PaymentDate = paymentDate.Value;
                                    column = 30;
                                    paymentBatch.IsCreateMsg = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                                    paymentBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                                    paymentBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                                    paymentBatch.CheckStatus = "已复核";
                                    paymentBatch.PaymentBatchNo = Invoice.GeneratePaymentBatchNo(paymentBatch.PaymentDate, paymentBatches);
                                    paymentBatch.CDA = cda;
                                    paymentBatches.Add(paymentBatch);
                                }
                            }
                        }

                        //付款信息
                        column = 33;
                        double? paymentAmount = (System.Nullable<double>)valueArray[row, column++];
                        if (paymentAmount.HasValue)
                        {
                            InvoicePaymentLog paymentLog = new InvoicePaymentLog();
                            paymentLog.PaymentAmount = paymentAmount.Value;
                            paymentLog.Invoice = invoice;
                            if (paymentBatch == null)
                            {
                                throw new Exception("缺少付款批次信息: " + invoice.InvoiceNo);
                            }
                            paymentLog.InvoicePaymentBatch = paymentBatch;
                            invoice.CaculatePayment();
                        }

                        //还款批次信息
                        column = 34;
                        string refundBatchNo = String.Format("{0:G}", valueArray[row, column++]);
                        string refundType = String.Format("{0:G}", valueArray[row, column++]);
                        InvoiceRefundBatch refundBatch = null;
                        if (refundBatchNo != string.Empty)
                        {
                            refundBatch = refundBatches.SingleOrDefault(i => i.RefundBatchNo == refundBatchNo);
                            if (refundBatch == null)
                            {
                                refundBatch = App.Current.DbContext.InvoiceRefundBatches.SingleOrDefault(i => i.RefundBatchNo == refundBatchNo);
                                if (refundBatch == null)
                                {
                                    throw new Exception("还款批号错误: " + refundBatchNo);
                                }
                            }
                        }
                        else
                        {
                            DateTime? refundDate = (System.Nullable<DateTime>)valueArray[row, column++];
                            if (refundDate != null)
                            {
                                refundBatch = refundBatches.SingleOrDefault(i => i.CDA.CDACode == cdaCode && i.RefundDate == refundDate && i.RefundType == refundType);
                                if (refundBatch == null)
                                {
                                    refundBatch = new InvoiceRefundBatch();
                                    refundBatch.RefundType = refundType;
                                    refundBatch.RefundDate = refundDate.Value;
                                    column = 37;
                                    refundBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                                    refundBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                                    refundBatch.CheckStatus = "已复核";
                                    refundBatch.RefundBatchNo = Invoice.GenerateRefundBatchNo(refundBatch.RefundDate, refundBatches);
                                    refundBatch.CDA = cda;
                                    refundBatches.Add(refundBatch);
                                }
                            }
                        }

                        //还款信息
                        column = 39;
                        double? refundAmount = (System.Nullable<double>)valueArray[row, column++];
                        if (refundAmount.HasValue)
                        {
                            InvoiceRefundLog refundLog = new InvoiceRefundLog();
                            refundLog.RefundAmount = refundAmount.Value;
                            refundLog.Invoice = invoice;
                            if (refundBatch == null)
                            {
                                throw new Exception("缺少还款批次信息: " + invoice.InvoiceNo);
                            }
                            refundLog.InvoiceRefundBatch = refundBatch;
                            invoice.CaculateRefund();
                        }

                        //手续费
                        column = 40;
                        invoice.Commission = (System.Nullable<double>)valueArray[row, column++];
                        invoice.CommissionDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        if (!invoice.Commission.HasValue)
                        {
                            switch (cda.CommissionType)
                            {
                                case "按融资金额":
                                    invoice.Commission = invoice.FinanceAmount * cda.Price;
                                    if (invoice.Commission.HasValue)
                                    {
                                        invoice.CommissionDate = invoice.FinanceDate;
                                    }
                                    break;
                                case "按转让金额":
                                    invoice.Commission = invoice.AssignAmount * cda.Price;
                                    if (invoice.Commission.HasValue)
                                    {
                                        invoice.CommissionDate = invoice.InvoiceAssignBatch.AssignDate;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }

                        //利息
                        column = 42;
                        invoice.Interest = (System.Nullable<double>)valueArray[row, column++];
                        invoice.InterestDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)totalSize));
                    }
                }

                //处理Credit Note
                if (valueArray2 != null)
                {
                    int size = valueArray2.GetUpperBound(0);
                    int size1 = totalSize - size;

                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string cdaCode = String.Format("{0:G}", valueArray2[row, 1]);
                        if (string.Empty.Equals(cdaCode))
                        {
                            continue;
                        }
                        if (cda == null || cda.CDACode != cdaCode)
                        {
                            cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                            if (cda == null)
                            {
                                throw new Exception("额度通知书编号错误: " + cdaCode);
                            }
                        }

                        string paymentBatchNo = String.Format("{0:G}", valueArray2[row, 3]);
                        InvoicePaymentBatch paymentBatch = null;
                        if (paymentBatchNo != string.Empty)
                        {
                            paymentBatch = paymentBatches.SingleOrDefault(i => i.PaymentBatchNo == paymentBatchNo);
                            if (paymentBatch == null)
                            {
                                paymentBatch = App.Current.DbContext.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == paymentBatchNo);
                                if (paymentBatch == null)
                                {
                                    throw new Exception("付款批号错误: " + paymentBatchNo);
                                }
                            }
                        }
                        else
                        {
                            string paymentType = String.Format("{0:G}", valueArray2[row, 4]);
                            DateTime? paymentDate = (System.Nullable<DateTime>)valueArray2[row, 5];
                            if (paymentDate != null)
                            {
                                paymentBatch = paymentBatches.SingleOrDefault(i => i.CDA.CDACode == cdaCode && i.PaymentDate == paymentDate && i.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch();
                                    int column = 4;
                                    paymentBatch.PaymentType = String.Format("{0:G}", valueArray2[row, column++]);
                                    paymentBatch.PaymentDate = (DateTime)valueArray2[row, column++];
                                    paymentBatch.IsCreateMsg = TypeUtil.ConvertStrToBool(valueArray2[row, column++]);
                                    paymentBatch.Comment = String.Format("{0:G}", valueArray2[row, column++]);
                                    paymentBatch.CreateUserName = String.Format("{0:G}", valueArray2[row, column++]);
                                    paymentBatch.PaymentBatchNo = Invoice.GeneratePaymentBatchNo(paymentBatch.PaymentDate, paymentBatches);
                                    paymentBatch.CheckStatus = "已复核";
                                    paymentBatch.CDA = cda;
                                    paymentBatches.Add(paymentBatch);
                                }
                            }
                        }

                        string creditNoteNo = String.Format("{0:G}", valueArray2[row, 9]);
                        if (creditNoteNo == string.Empty)
                        {
                            throw new Exception("贷项通知编号不能为空");
                        }
                        CreditNote creditNote = App.Current.DbContext.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                        if (creditNote == null)
                        {
                            creditNote = new CreditNote();
                            creditNote.CreditNoteNo = creditNoteNo;
                            creditNote.CreditNoteDate = (DateTime)valueArray2[row, 11];
                        }
                        InvoicePaymentLog log = new InvoicePaymentLog();
                        log.CreditNote = creditNote;
                        log.PaymentAmount = (double)valueArray2[row, 10];

                        string invoiceNo = String.Format("{0:G}", valueArray2[row, 12]);
                        if (invoiceNo == string.Empty)
                        {
                            throw new Exception("发票号不能为空");
                        }
                        Invoice invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                        if (invoice == null)
                        {
                            invoice = invoiceList.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                            if (invoice == null)
                            {
                                throw new Exception("发票号错误: " + invoiceNo);
                            }
                        }
                        log.Invoice = invoice;
                        log.Comment = String.Format("{0:G}", valueArray2[row, 13]);
                        if (paymentBatch == null)
                        {
                            throw new Exception("缺少贷项通知付款批次信息: " + invoice.InvoiceNo);
                        }
                        log.InvoicePaymentBatch = paymentBatch;
                        invoice.CaculatePayment();

                        result++;
                        worker.ReportProgress((int)((float)(row + size1) * 100 / (float)totalSize));
                    }
                }
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceAssignBatch batch in assignBatches)
                {
                    batch.CDA = null;
                }
                foreach (InvoiceFinanceBatch batch in financeBatches)
                {
                    batch.CDA = null;
                }
                foreach (InvoicePaymentBatch batch in paymentBatches)
                {
                    foreach (InvoicePaymentLog log in batch.InvoicePaymentLogs)
                    {
                        log.Invoice = null;
                        log.CreditNote = null;
                    }
                    batch.CDA = null;
                }
                foreach (InvoiceRefundBatch batch in refundBatches)
                {
                    foreach (InvoiceRefundLog log in batch.InvoiceRefundLogs)
                    {
                        log.Invoice = null;
                    }
                    batch.CDA = null;
                }
                throw e1;
            }
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportInvoicesByBatch(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            List<Invoice> invoiceList = new List<Invoice>();
            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);

                for (int row = 2; row <= size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return -1;
                    }
                    //int column = 12;
                    int column = 1;
                    string invoiceNo = String.Format("{0:G}", valueArray[row, column++]);
                    if (invoiceNo.Equals(string.Empty))
                    {
                        continue;
                    }
                    Invoice invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                    if (invoice == null)
                    {
                        invoice = new Invoice();
                        invoice.InvoiceNo = invoiceNo;
                        Invoice old = invoiceList.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                        if (old != null)
                        {
                            throw new Exception("发票号重复: " + old.InvoiceNo);
                        }
                    }
                    invoice.InvoiceAmount = (double)valueArray[row, column++];
                    invoice.AssignAmount = (double)valueArray[row, column++];
                    invoice.InvoiceDate = (DateTime)valueArray[row, column++];
                    invoice.DueDate = (DateTime)valueArray[row, column++];
                    invoice.IsFlaw = TypeUtil.ConvertStrToBool(valueArray[row, column++]);

                    invoice.FinanceAmount = (System.Nullable<double>)valueArray[row, column++];
                    invoice.FinanceDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.FinanceDueDate = (System.Nullable<DateTime>)valueArray[row, column++];

                    invoice.PaymentAmount2 = (System.Nullable<double>)valueArray[row, column++];

                    invoice.RefundAmount2 = (System.Nullable<double>)valueArray[row, column++];

                    invoice.Commission = (System.Nullable<double>)valueArray[row, column++];
                    invoice.CommissionDate = (System.Nullable<DateTime>)valueArray[row, column++];

                    invoice.Interest = (System.Nullable<double>)valueArray[row, column++];
                    invoice.InterestDate = (System.Nullable<DateTime>)valueArray[row, column++];

                    invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);
                    if (column > 18)
                    {
                        invoice.CreditNoteNo2 = String.Format("{0:G}", valueArray[row, column++]);
                        invoice.CreditNoteDate2 = (System.Nullable<DateTime>)valueArray[row, column++];
                    }

                    invoiceList.Add(invoice);
                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }
            ImportedList = invoiceList;
            worker.ReportProgress(100);
            workbook.Close(false, fileName, null);
            ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private int ImportUsers(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<User> userList = new List<User>();
                for (int row = 2; row <= size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return -1;
                    }

                    string userId = String.Format("{0:G}", valueArray[row, 1]);
                    if (String.Empty.Equals(userId))
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
                        userList.Add(user);
                    }

                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
                try
                {
                    App.Current.DbContext.Users.InsertAllOnSubmit(userList);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    throw e1;
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
            if (filePath.Trim().Equals(String.Empty))
                return;

            this.btnCancel.Text = "取消";
            backgroundWorker.RunWorkerAsync(filePath);

            this.btnStart.Enabled = false;
        }

        #endregion Methods
    }
}
