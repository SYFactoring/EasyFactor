
namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.ARMgr;
    using CMBC.EasyFactor.DB.dbml;
    using Microsoft.Office.Interop.Excel;
    using System.Collections;

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
            IMPORT_ASSIGN,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FINANCE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_ASSIGN_FINANCE_PAYMENT
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
                case ImportType.IMPORT_ASSIGN:
                    this.Text = "发票转让导入";
                    break;
                case ImportType.IMPORT_FINANCE:
                    this.Text = "发票融资导入";
                    break;
                case ImportType.IMPORT_ASSIGN_FINANCE_PAYMENT:
                    this.Text = "发票转让、融资、还款导入";
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

        #region Methods (20)

        // Private Methods (20) 

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
                    e.Result = ImportUsers((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_CLIENTS:
                    e.Result = ImportClients((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    e.Result = ImportClientsCreditLine((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_FACTORS:
                    e.Result = ImportFactors((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    e.Result = ImportFactorsCreditLine((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_DEPARTMENTS:
                    e.Result = ImportDepartments((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_CASES:
                    e.Result = ImportCases((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_CONTRACT_CDA:
                    e.Result = ImportContractAndCDA((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_ASSIGN:
                    e.Result = ImportAssignBatch((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_FINANCE:
                    e.Result = ImportFinanceBatch((string)e.Argument, worker);
                    break;
                case ImportType.IMPORT_ASSIGN_FINANCE_PAYMENT:
                    e.Result = ImportAssignFinancePayment((string)e.Argument, worker);
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
            this.ReleaseResource();
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
            List<Invoice> invoiceList = new List<Invoice>();
            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);

                for (int row = 2; row <= size; row++)
                {
                    int column = 8;
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
                        if (old == null)
                        {
                            invoiceList.Add(invoice);
                        }
                        else
                        {
                            throw new Exception("发票号重复: " + old.InvoiceNo);
                        }
                    }
                    invoice.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.InvoiceAmount = (System.Nullable<double>)valueArray[row, column++];
                    invoice.AssignAmount = (System.Nullable<double>)valueArray[row, column++];
                    invoice.InvoiceDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.DueDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.AssignDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.IsFlaw = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                    invoice.FlawReason = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.FlawResolveReason = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.FlawResolveDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.FlawResolveUserName = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.ValueDate = (System.Nullable<DateTime>)valueArray[row, column++];

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
        private int ImportAssignFinancePayment(string fileName, BackgroundWorker worker)
        {
            object[,] valueArray = GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);

                CDA cda = null;
                List<InvoiceAssignBatch> assignBatches = new List<InvoiceAssignBatch>();
                List<InvoiceFinanceBatch> financeBatches = new List<InvoiceFinanceBatch>();
                List<InvoicePaymentBatch> paymentBatches = new List<InvoicePaymentBatch>();
                List<Invoice> invoiceList = new List<Invoice>();
                for (int row = 2; row <= size; row++)
                {
                    string cdaCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (string.Empty.Equals(cdaCode))
                    {
                        throw new Exception("额度通知书编号不能为空");
                    }
                    if (cda == null || cda.CDACode != cdaCode)
                    {
                        cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                        if (cda == null)
                        {
                            throw new Exception("额度通知书编号错误: " + cdaCode);
                        }
                    }
                    int column = 8;
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
                        if (old == null)
                        {
                            invoiceList.Add(invoice);
                        }
                        else
                        {
                            throw new Exception("发票号重复: " + old.InvoiceNo);
                        }
                    }
                    invoice.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.InvoiceAmount = (System.Nullable<double>)valueArray[row, column++];
                    invoice.AssignAmount = (System.Nullable<double>)valueArray[row, column++];
                    invoice.InvoiceDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.DueDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.AssignDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.IsFlaw = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                    invoice.FlawReason = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.FlawResolveReason = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.FlawResolveDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.FlawResolveUserName = String.Format("{0:G}", valueArray[row, column++]);
                    invoice.ValueDate = (System.Nullable<DateTime>)valueArray[row, column++];

                    if (invoice.InvoiceAmount.HasValue)
                    {
                        InvoiceAssignBatch assignBatch = assignBatches.SingleOrDefault(batch => batch.BatchDate.Equals(invoice.AssignDate) && batch.CDACode == cda.CDACode);
                        if (assignBatch == null)
                        {
                            string assignBatchNo = String.Format("{0:G}", valueArray[row, 2]);
                            assignBatch = App.Current.DbContext.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchNo);
                            if (assignBatch == null)
                            {
                                assignBatch = new InvoiceAssignBatch();
                                column = 3;
                                assignBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                                assignBatch.BatchDate = (System.Nullable<DateTime>)valueArray[row, column++];
                                assignBatch.IsCreateMsg = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                                assignBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                                assignBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                                assignBatch.AssignBatchNo = InvoiceAssign.GenerateAssignBatchNo(cda, assignBatch.BatchDate);
                            }
                            assignBatch.CDA = cda;
                            assignBatches.Add(assignBatch);
                        }
                        invoice.InvoiceAssignBatch = assignBatch;
                    }
                    column = 33;
                    invoice.FinanceAmount = (System.Nullable<double>)valueArray[row, column++];
                    if (invoice.FinanceAmount.HasValue && invoice.FinanceAmount.Value > 0)
                    {
                        invoice.FinanceDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        invoice.FinanceDueDate = (System.Nullable<DateTime>)valueArray[row, column++];

                        InvoiceFinanceBatch financeBatch = financeBatches.SingleOrDefault(batch => batch.FinancePeriodBegin.Equals(invoice.FinanceDate) && batch.CDACode == cda.CDACode);
                        if (financeBatch == null)
                        {
                            string financeBatchNo = String.Format("{0:G}", valueArray[row, 21]);
                            financeBatch = App.Current.DbContext.InvoiceFinanceBatches.SingleOrDefault(i => i.FinanceBatchNo == financeBatchNo);
                            if (financeBatch == null)
                            {
                                financeBatch = new InvoiceFinanceBatch();
                                column = 22;
                                financeBatch.FinanceType = String.Format("{0:G}", valueArray[row, column++]);
                                string factorCode = String.Format("{0:G}", valueArray[row, column++]);
                                financeBatch.Factor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                                column++;
                                financeBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                                financeBatch.FinanceRate = (System.Nullable<double>)valueArray[row, column++];
                                financeBatch.CostRate = (System.Nullable<double>)valueArray[row, column++];
                                financeBatch.InterestType = String.Format("{0:G}", valueArray[row, column++]);
                                financeBatch.FinancePeriodBegin = (System.Nullable<DateTime>)valueArray[row, column++];
                                financeBatch.FinnacePeriodEnd = (System.Nullable<DateTime>)valueArray[row, column++];
                                financeBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                                financeBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                                financeBatch.FinanceBatchNo = InvoiceFinance.GenerateFinanceBatchNo(cda, financeBatch.FinancePeriodBegin);
                            }
                            financeBatch.CDA = cda;
                            financeBatches.Add(financeBatch);
                        }
                        if (!financeBatch.Invoices.Contains(invoice))
                        {
                            financeBatch.FinanceAmount = financeBatch.FinanceAmount.GetValueOrDefault() + invoice.FinanceAmount.Value;
                            invoice.InvoiceFinanceBatch = financeBatch;
                        }
                    }

                    column = 42;
                    invoice.PaymentAmount = (System.Nullable<double>)valueArray[row, column++];
                    if (invoice.PaymentAmount.HasValue && invoice.PaymentAmount.Value > 0)
                    {
                        invoice.PaymentDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        invoice.RefundAmount = (System.Nullable<double>)valueArray[row, column++];
                        invoice.RefundDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        invoice.Commission = (System.Nullable<double>)valueArray[row, column++];
                        invoice.CommissionDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        invoice.Interest = (System.Nullable<double>)valueArray[row, column++];
                        invoice.InterestDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        InvoicePaymentBatch paymentBatch = paymentBatches.SingleOrDefault(batch => batch.PaymentDate.Equals(invoice.PaymentDate) && batch.CDACode == cda.CDACode);
                        if (paymentBatch == null)
                        {
                            string paymentBatchNo = String.Format("{0:G}", valueArray[row, 36]);
                            paymentBatch = App.Current.DbContext.InvoicePaymentBatches.SingleOrDefault(i => i.PaymentBatchNo == paymentBatchNo);
                            if (paymentBatch == null)
                            {
                                paymentBatch = new InvoicePaymentBatch();
                                column = 37;
                                paymentBatch.PaymentType = String.Format("{0:G}", valueArray[row, column++]);
                                paymentBatch.PaymentDate = (System.Nullable<DateTime>)valueArray[row, column++];
                                paymentBatch.IsCreateMsg = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                                paymentBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                                paymentBatch.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                                paymentBatch.PaymentBatchNo = InvoicePayment.GeneratePaymentBatchNo(cda, paymentBatch.PaymentDate);
                            }
                            paymentBatch.CDA = cda;
                            paymentBatches.Add(paymentBatch);
                        }
                        invoice.InvoicePaymentBatch = paymentBatch;
                    }

                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
                App.Current.DbContext.SubmitChanges();
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
                    if (String.Empty.Equals(caseCode))
                    {
                        continue;
                    }

                    Case curCase = App.Current.DbContext.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                    if (curCase == null)
                    {
                        curCase = new Case();
                        curCase.CaseCode = caseCode;
                    }
                    int column = 2;
                    curCase.ManagerName = String.Format("{0:G}", valueArray[row, column++]);
                    string ownerDeptName = String.Format("{0:G}", valueArray[row, column++]);
                    if (!String.Empty.Equals(ownerDeptName))
                    {
                        curCase.OwnerDepartment = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName == ownerDeptName);
                    }
                    curCase.TransactionType = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.ReviewNo = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.OperationType = String.Format("{0:G}", valueArray[row, column++]);
                    string coDeptName = String.Format("{0:G}", valueArray[row, column++]);
                    if (!String.Empty.Equals(coDeptName))
                    {
                        curCase.CoDepartment = App.Current.DbContext.Departments.SingleOrDefault(d => d.DepartmentName == coDeptName);
                    }
                    curCase.CaseMark = String.Format("{0:G}", valueArray[row, column++]);
                    string sellerEDICode = String.Format("{0:G}", valueArray[row, column++]);
                    column++;
                    if (!String.Empty.Equals(sellerEDICode))
                    {
                        curCase.SellerClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == sellerEDICode);
                    }
                    string buyerEDICode = String.Format("{0:G}", valueArray[row, column++]);
                    column++;
                    column++;
                    if (!String.Empty.Equals(buyerEDICode))
                    {
                        curCase.BuyerClient = App.Current.DbContext.Clients.SingleOrDefault(c => c.ClientEDICode == buyerEDICode);
                    }
                    string EFCode = String.Format("{0:G}", valueArray[row, column++]);
                    if (!String.Empty.Equals(EFCode))
                    {
                        curCase.SellerFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == EFCode);
                    }
                    string IFCode = String.Format("{0:G}", valueArray[row, column++]);
                    if (!String.Empty.Equals(IFCode))
                    {
                        curCase.BuyerFactor = App.Current.DbContext.Factors.SingleOrDefault(f => f.FactorCode == IFCode);
                    }
                    column++;
                    curCase.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.CaseAppDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    curCase.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                    curCase.Comment = String.Format("{0:G}", valueArray[row, column++]);


                    CreditCoverNegotiation creditCover = new CreditCoverNegotiation();
                    creditCover.ApproveType = String.Format("{0:G}", valueArray[row, column++]);
                    creditCover.RequestAmount = (System.Nullable<double>)valueArray[row, column++];
                    curCase.PaymentTerm = String.Format("{0:G}", valueArray[row, column++]);
                    creditCover.RequestDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    creditCover.ApproveAmount = (System.Nullable<double>)valueArray[row, column++];
                    creditCover.ApproveDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    creditCover.IFPrice = (System.Nullable<double>)valueArray[row, column++];
                    column++;
                    creditCover.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                    creditCover.Comment = String.Format("{0:G}", valueArray[row, column++]);
                    if (creditCover.RequestAmount.HasValue)
                    {
                        creditCover.Case = curCase;
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
                    client.IsGroup = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                    string groupNo = String.Format("{0:G}", valueArray[row, column++]);
                    string groupNameCN = String.Format("{0:G}", valueArray[row, column++]);
                    string groupNameEN = String.Format("{0:G}", valueArray[row, column++]);
                    if (client.IsGroup.GetValueOrDefault())
                    {
                        ClientGroup clientGroup = App.Current.DbContext.ClientGroups.SingleOrDefault(cg => cg.GroupNo == groupNo);
                        if (clientGroup == null)
                        {
                            clientGroup = new ClientGroup();
                            clientGroup.GroupNo = groupNo;
                        }
                        clientGroup.GroupNameCN = groupNameCN;
                        clientGroup.GroupNameEN = groupNameEN;
                    }

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
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        private object ImportClientsCreditLine(string fileName, BackgroundWorker worker)
        {
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
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
                    int column = 2;
                    ClientCreditLine creditLine = new ClientCreditLine();
                    creditLine.CreditLineType = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.CreditLineCurrency = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.CreditLine = (System.Nullable<double>)valueArray[row, column++]; ;
                    creditLine.PeriodBegin = (System.Nullable<DateTime>)valueArray[row, column++]; ;
                    creditLine.PeriodEnd = (System.Nullable<DateTime>)valueArray[row, column++]; ;
                    creditLine.ApproveNo = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.ApproveType = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.CreditLineStatus = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.FreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.Freezer = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.FreezeDate = (System.Nullable<DateTime>)valueArray[row, column++]; ;
                    creditLine.UnfreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.Unfreezer = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.Comment = String.Format("{0:G}", valueArray[row, column++]);
                    creditLine.Client = client;
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
        private int ImportContractAndCDA(string fileName, BackgroundWorker worker)
        {
            object[,] valueArray = this.GetValueArray(fileName);

            int result = 0;

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
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
                    if (String.Empty.Equals(ContractCode) && curCase.TransactionType != "进口保理")
                    {
                        throw new Exception("保理合同号不能为空");
                    }
                    if (!String.Empty.Equals(ContractCode))
                    {
                        Contract contract = App.Current.DbContext.Contracts.SingleOrDefault(c => c.ContractCode == ContractCode);
                        if (contract == null)
                        {
                            contract = new Contract();
                            contract.ContractCode = ContractCode;
                            contract.Client = curCase.SellerClient;
                        }
                        contract.ContractType = String.Format("{0:G}", valueArray[row, column++]);
                        contract.ContractValueDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        contract.ContractDueDate = (System.Nullable<DateTime>)valueArray[row, column++];
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
                        cda = App.Current.DbContext.CDAs.Single(c => c.CDACode == cdaCode);
                        if (cda == null)
                        {
                            cda = new CDA();
                            cda.CDACode = cdaCode;
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

                    string monitorResult = factor.EndMonitor();
                    if (!String.Empty.Equals(monitorResult))
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
        private object ImportFactorsCreditLine(string fileName, BackgroundWorker worker)
        {
            {
                object[,] valueArray = this.GetValueArray(fileName);
                int result = 0;

                if (valueArray != null)
                {
                    int size = valueArray.GetUpperBound(0);
                    for (int row = 2; row <= size; row++)
                    {
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
                        creditLine.CreditLine = (System.Nullable<double>)valueArray[row, column++]; ;
                        creditLine.PeriodBegin = (System.Nullable<DateTime>)valueArray[row, column++]; ;
                        creditLine.PeriodEnd = (System.Nullable<DateTime>)valueArray[row, column++]; ;
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
                    }
                    App.Current.DbContext.SubmitChanges();
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
        private int ImportFinanceBatch(string fileName, BackgroundWorker worker)
        {
            object[,] valueArray = this.GetValueArray(fileName);
            int result = 0;

            if (valueArray != null)
            {
                string lastCDACode = String.Empty;
                string lastFinanceBatchNo = String.Empty;
                CDA cda = null;
                InvoiceFinanceBatch financeBatch = null;

                int size = valueArray.GetUpperBound(0);
                for (int row = 2; row <= size; row++)
                {
                    string cdaCode = String.Format("{0:G}", valueArray[row, 1]);
                    if (String.Empty.Equals(cdaCode))
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
                    if (String.Empty.Equals(financeBatchNo))
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
                        financeBatch.FinanceAmount = (System.Nullable<double>)valueArray[row, column++];
                        financeBatch.FinanceRate = (System.Nullable<double>)valueArray[row, column++];
                        financeBatch.CostRate = (System.Nullable<double>)valueArray[row, column++];
                        financeBatch.FinancePeriodBegin = (System.Nullable<DateTime>)valueArray[row, column++];
                        financeBatch.FinnacePeriodEnd = (System.Nullable<DateTime>)valueArray[row, column++];
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
                    invoice.FinanceAmount = (System.Nullable<double>)valueArray[row, column++];
                    invoice.FinanceDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.FinanceDueDate = (System.Nullable<DateTime>)valueArray[row, column++];
                    invoice.Comment = invoice.Comment == String.Empty ? String.Format("{0:G}", valueArray[row, column++]) : invoice.Comment + "\t" + String.Format("{0:G}", valueArray[row, column++]);

                    invoice.InvoiceFinanceBatch = financeBatch;

                    result++;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }
            }

            App.Current.DbContext.SubmitChanges();
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
            if (filePath.Trim().Equals(String.Empty))
                return;

            this.btnCancel.Text = "取消";
            backgroundWorker.RunWorkerAsync(filePath);

            this.btnStart.Enabled = false;
        }

        #endregion Methods
    }
}
