//-----------------------------------------------------------------------
// <copyright file="ImportForm.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class ImportForm : DevComponents.DotNetBar.Office2007Form
    {
        #region?Fields?(5)?

        /// <summary>
        /// 
        /// </summary>
        private ApplicationClass app;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
        /// <summary>
        /// 
        /// </summary>
        private Worksheet datasheet;
        /// <summary>
        /// 
        /// </summary>
        private ImportType importType;
        /// <summary>
        /// 
        /// </summary>
        private Workbook workbook;

        #endregion?Fields?

        #region?Enums?(1)?

        /// <summary>
        /// 
        /// </summary>
        public enum ImportType
        {
            /// <summary>
            /// 
            /// </summary>
            IMPORT_USER,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CLIENT,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CLIENTS_OVERWRITE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CLIENTS_CREDITLINE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CLIENTS_REVIEW,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FACTOR,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FACTORS_CREDITLINE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_DEPARTMENT,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_RATE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CASE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CREDIT_COVER_NEG,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CONTRACT,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CDA,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_ASSIGN_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_FINANCE_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_PAYMENT_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_REFUND_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_INVOICE,

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
            IMPORT_REFUND,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_CREDIT_NOTE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_POOL_FINANCE,

            /// <summary>
            /// 
            /// </summary>
            IMPORT_POOL_REFUND
        }

        #endregion?Enums?

        #region?Constructors?(2)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="importType"></param>
        /// <param name="context"></param>
        public ImportForm(ImportType importType, DBDataContext context)
            : this(importType)
        {
            this.context = context;
        }

        /// <summary>
        /// Initializes a new instance of the ImportForm class.
        /// </summary>
        /// <param name="importType"></param>
        public ImportForm(ImportType importType)
        {
            this.InitializeComponent();
            this.importType = importType;
            switch (importType)
            {
                case ImportType.IMPORT_USER:
                    this.Text = "用户信息导入";
                    break;
                case ImportType.IMPORT_CLIENT:
                    this.Text = "客户信息导入";
                    break;
                case ImportType.IMPORT_CLIENTS_OVERWRITE:
                    this.Text = "客户信息导入(覆盖模式)";
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    this.Text = "客户额度信息导入";
                    break;
                case ImportType.IMPORT_CLIENTS_REVIEW:
                    this.Text = "客户协查意见导入";
                    break;
                case ImportType.IMPORT_FACTOR:
                    this.Text = "合作机构信息导入";
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    this.Text = "合作机构额度信息导入";
                    break;
                case ImportType.IMPORT_DEPARTMENT:
                    this.Text = "部门信息导入";
                    break;
                case ImportType.IMPORT_RATE:
                    this.Text = "汇率信息导入";
                    break;
                case ImportType.IMPORT_CASE:
                    this.Text = "案件信息导入";
                    break;
                case ImportType.IMPORT_CREDIT_COVER_NEG:
                    this.Text = "国际保理案关联额度导入";
                    break;
                case ImportType.IMPORT_CONTRACT:
                    this.Text = "保理合同导入";
                    break;
                case ImportType.IMPORT_CDA:
                    this.Text = "额度通知书导入";
                    break;
                case ImportType.IMPORT_ASSIGN_BY_BATCH:
                    this.Text = "当前转让批次导入";
                    break;
                case ImportType.IMPORT_FINANCE_BY_BATCH:
                    this.Text = "当前融资批次导入";
                    break;
                case ImportType.IMPORT_PAYMENT_BY_BATCH:
                    this.Text = "当前付款批次导入";
                    break;
                case ImportType.IMPORT_REFUND_BY_BATCH:
                    this.Text = "当前还款批次导入";
                    break;
                case ImportType.IMPORT_INVOICE:
                    this.Text = "台帐导入";
                    break;
                case ImportType.IMPORT_ASSIGN:
                    this.Text = "应收账款转让清单导入";
                    break;
                case ImportType.IMPORT_FINANCE:
                    this.Text = "放款明细表导入";
                    break;
                case ImportType.IMPORT_PAYMENT:
                    this.Text = "冲销账款明细表导入";
                    break;
                case ImportType.IMPORT_REFUND:
                    this.Text = "冲销融资明细表导入";
                    break;
                case ImportType.IMPORT_CREDIT_NOTE:
                    this.Text = "贷项冲销账款明细表导入";
                    break;
                case ImportType.IMPORT_POOL_FINANCE:
                    this.Text = "放款明细表（池融资）导入";
                    break;
                case ImportType.IMPORT_POOL_REFUND:
                    this.Text = "冲销融资明细表（池融资）导入";
                    break;
                default:
                    break;
            }
        }

        #endregion?Constructors?

        #region?Properties?(1)?

        /// <summary>
        /// Gets or sets Imported List
        /// </summary>
        public IList ImportedList
        {
            get;
            set;
        }

        #endregion?Properties?

        #region?Methods?(33)?

        //?Private?Methods?(33)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            switch (this.importType)
            {
                case ImportType.IMPORT_USER:
                    e.Result = this.ImportUser((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENT:
                    e.Result = this.ImportClient((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS_OVERWRITE:
                    e.Result = this.ImportClientsOverwrite((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    e.Result = this.ImportClientsCreditLine((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS_REVIEW:
                    e.Result = this.ImportClientsReivew((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FACTOR:
                    e.Result = this.ImportFactor((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    e.Result = this.ImportFactorsCreditLine((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_DEPARTMENT:
                    e.Result = this.ImportDepartment((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_RATE:
                    e.Result = this.ImportExchangeRate((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CASE:
                    e.Result = this.ImportCase((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CREDIT_COVER_NEG:
                    e.Result = this.ImportCreditCoverNeg((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CONTRACT:
                    e.Result = this.ImportContract((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CDA:
                    e.Result = this.ImportCDA((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_ASSIGN_BY_BATCH:
                    e.Result = this.ImportAssignByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FINANCE_BY_BATCH:
                    e.Result = this.ImportFinanceByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_PAYMENT_BY_BATCH:
                    e.Result = this.ImportPaymentByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_REFUND_BY_BATCH:
                    e.Result = this.ImportRefundByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_INVOICE:
                    e.Result = this.ImportInvoice((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_ASSIGN:
                    e.Result = this.ImportAssign((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FINANCE:
                    e.Result = this.ImportFinance((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_PAYMENT:
                    e.Result = this.ImportPayment((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_REFUND:
                    e.Result = this.ImportRefund((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CREDIT_NOTE:
                    e.Result = this.ImportCreditNote((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_POOL_FINANCE:
                    e.Result = this.ImportPoolFinance((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_POOL_REFUND:
                    e.Result = this.ImportPoolRefund((string)e.Argument, worker, e);
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
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
            this.tbStatus.Text = String.Format("导入进度 {0:G}%", e.ProgressPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ReleaseResource();
            if (e.Error != null)
            {
                if (e.Error.Data.Contains("ID"))
                {
                    this.tbStatus.Text = String.Format("记录: {0} 发生异常: {1}", e.Error.Data["ID"], e.Error.Message);
                }
                else if (e.Error.Data.Contains("column"))
                {
                    this.tbStatus.Text = String.Format("第{0}条记录第{1}列，发生异常: {2}", e.Error.Data["row"], e.Error.Data["column"], e.Error.Message);
                }
                else if (e.Error.Data.Contains("row"))
                {
                    this.tbStatus.Text = String.Format("第{0}条记录发生异常: {1}", e.Error.Data["row"], e.Error.Message);
                }
                else
                {
                    this.tbStatus.Text = String.Format("发生异常: {0}", e.Error.Message);
                }
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
            if (e.Error == null && (this.importType == ImportType.IMPORT_ASSIGN_BY_BATCH || this.importType == ImportType.IMPORT_FINANCE_BY_BATCH || this.importType == ImportType.IMPORT_PAYMENT_BY_BATCH || this.importType == ImportType.IMPORT_REFUND_BY_BATCH))
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
            this.ReleaseResource();
            this.app = new ApplicationClass() { Visible = false };
            if (this.app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            this.workbook = (WorkbookClass)this.app.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            if (this.workbook.Sheets.Count < sheetIndex)
            {
                return null;
            }

            this.datasheet = (Worksheet)this.workbook.Sheets[sheetIndex];
            Range range = this.datasheet.UsedRange;
            return (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportAssign(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<Invoice> invoiceList = new List<Invoice>();
            List<InvoiceAssignBatch> batchList = new List<InvoiceAssignBatch>();

            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                Case curCase = null;
                InvoiceAssignBatch batch = null;

                try
                {
                    for (int row = 3; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string caseCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(caseCode))
                        {
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                break;
                            }
                            else
                            {
                                throw new Exception("案件编号不能为空，不能导入：" + invoiceNo);
                            }
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("发票编号不能为空，不能导入，案件编号： " + caseCode);
                            }
                        }

                        if (caseCode.Length > 20)
                        {
                            break;
                        }

                        if (curCase == null || curCase.CaseCode != caseCode)
                        {
                            curCase = context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);

                            if (curCase == null)
                            {
                                throw new Exception("案件编号错误: " + caseCode);
                            }
                        }

                        CDA cda = curCase.ActiveCDA;
                        if (cda == null)
                        {
                            throw new Exception("没有有效的额度通知书: " + caseCode);
                        }

                        if (batch == null || batch.CaseCode != caseCode)
                        {
                            batch = batchList.SingleOrDefault(b => b.CaseCode == caseCode);
                            if (batch == null)
                            {
                                batch = new InvoiceAssignBatch();
                                batch.AssignDate = DateTime.Today;
                                batch.Case = curCase;
                                batch.CreateUserName = App.Current.CurUser.Name;
                                batch.InputDate = DateTime.Today;
                                batch.AssignBatchNo = InvoiceAssignBatch.GenerateAssignBatchNo(curCase.CaseCode, batch.AssignDate, batchList);
                                batch.CheckStatus = BATCH.UNCHECK;
                                batch.IsCreateMsg = false;
                                batchList.Add(batch);
                            }
                        }

                        Invoice invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
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
                                throw new Exception("当前导入文件中发票号重复: " + old.InvoiceNo);
                            }
                        }
                        else
                        {
                            throw new Exception("发票号已经存在，不能导入： " + invoiceNo);
                        }

                        string currency = string.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(currency))
                        {
                            throw new Exception("发票币别不能为空，不能导入：" + invoiceNo);
                        }
                        else if (currency != curCase.InvoiceCurrency)
                        {
                            throw new Exception("发票币别与案件币别不匹配，不能导入：" + invoiceNo);
                        }

                        string invoiceAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(invoiceAmountStr))
                        {
                            throw new Exception("发票金额不能为空，不能导入：" + invoiceNo);
                        }
                        double invoiceAmount = 0;
                        if (Double.TryParse(invoiceAmountStr, out invoiceAmount))
                        {
                            invoice.InvoiceAmount = invoiceAmount;
                        }
                        else
                        {
                            throw new Exception("发票金额类型异常，不能导入：" + invoiceNo);
                        }

                        string assignAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(assignAmountStr))
                        {
                            throw new Exception("转让金额不能为空，不能导入：" + invoiceNo);
                        }
                        double assignAmount = 0;
                        if (Double.TryParse(assignAmountStr, out assignAmount))
                        {
                            invoice.AssignAmount = assignAmount;
                        }
                        else
                        {
                            throw new Exception("转让金额类型异常，不能导入：" + invoiceNo);
                        }

                        string invoiceDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(invoiceDateStr))
                        {
                            DateTime invoiceDate = default(DateTime);
                            if (DateTime.TryParse(invoiceDateStr, out  invoiceDate))
                            {
                                invoice.InvoiceDate = invoiceDate;
                            }
                            else
                            {
                                throw new Exception("发票日类型异常，不能导入：" + invoiceNo);
                            }
                        }

                        string dueDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(dueDateStr))
                        {
                            throw new Exception("转让日不能为空，不能导入：" + invoiceNo);
                        }
                        DateTime dueDate = default(DateTime);
                        if (DateTime.TryParse(dueDateStr, out dueDate))
                        {
                            invoice.DueDate = dueDate;
                        }
                        else
                        {
                            throw new Exception("转让日类型异常，不能导入：" + invoiceNo);
                        }

                        string commissionStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(commissionStr))
                        {
                            double commissionAmount = 0;
                            if (Double.TryParse(commissionStr, out commissionAmount))
                            {
                                if (cda.CommissionType == "其他")
                                {
                                    invoice.Commission = commissionAmount;
                                }
                            }
                            else
                            {
                                throw new Exception("手续费类型异常，不能导入：" + invoiceNo);
                            }
                        }

                        if (cda.CommissionType == "按转让金额")
                        {
                            invoice.Commission = invoice.AssignAmount * cda.Price;
                        }

                        invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        invoice.InvoiceAssignBatch = batch;

                        invoiceList.Add(invoice);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (InvoiceAssignBatch b in batchList)
                    {
                        b.Case = null;
                    }

                    if (result != invoiceList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    if (curCase != null)
                    {
                        e1.Data["ID"] = curCase.CaseCode;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportAssignByBatch(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<Invoice> invoiceList = new List<Invoice>();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);

                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string caseCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(invoiceNo))
                        {
                            continue;
                        }

                        Invoice invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
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
                        invoice.Commission = (System.Nullable<double>)valueArray[row, column++];
                        invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        invoiceList.Add(invoice);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                }
                catch (Exception e1)
                {
                    if (result != invoiceList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    throw;
                }
            }

            this.ImportedList = invoiceList;
            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportCase(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<Case> caseList = new List<Case>();
                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string caseCode = String.Format("{0:G}", valueArray[row, 1]).Trim();
                        string transactionType = String.Format("{0:G}", valueArray[row, 4]);

                        if (String.IsNullOrEmpty(caseCode) && String.IsNullOrEmpty(transactionType))
                        {
                            continue;
                        }

                        string ownerDeptName = String.Format("{0:G}", valueArray[row, 3]);
                        Department ownerDept = context.Departments.SingleOrDefault(d => d.DepartmentName == ownerDeptName);
                        if (ownerDept == null)
                        {
                            throw new Exception("所属分部名称错误： " + ownerDeptName);
                        }


                        DateTime appDate = (DateTime)valueArray[row, 19];
                        if (String.IsNullOrEmpty(caseCode) && !String.IsNullOrEmpty(transactionType))
                        {
                            caseCode = Case.GenerateCaseCode(transactionType, ownerDept.LocationCode, appDate, caseList);
                        }

                        Case curCase = context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase != null)
                        {
                            throw new Exception("案件已存在，不能导入： " + caseCode);
                        }

                        curCase = caseList.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase != null)
                        {
                            throw new Exception("案件编号重复，不能导入： " + caseCode);
                        }

                        curCase = new Case();
                        curCase.CaseCode = caseCode;
                        caseList.Add(curCase);

                        int column = 2;
                        curCase.OPName = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.OwnerDepartment = ownerDept;
                        column++;
                        curCase.TransactionType = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.OperationType = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.CaseMark = String.Format("{0:G}", valueArray[row, column++]);
                        string sellerEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Client sellerClient = context.Clients.SingleOrDefault(c => c.ClientEDICode == sellerEDICode);
                        if (sellerClient == null)
                        {
                            throw new Exception("卖方保理代码错误： " + sellerEDICode);
                        }

                        curCase.SellerClient = sellerClient;
                        column++;
                        column++;
                        string buyerEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Client buyerClient = context.Clients.SingleOrDefault(c => c.ClientEDICode == buyerEDICode);
                        if (buyerClient == null)
                        {
                            throw new Exception("买方保理代码错误： " + buyerEDICode);
                        }

                        curCase.BuyerClient = buyerClient;
                        column++;
                        column++;
                        string EFCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Factor sellerFactor = context.Factors.SingleOrDefault(f => f.FactorCode == EFCode);
                        if (sellerFactor == null)
                        {
                            throw new Exception("卖方保理商代码错误： " + EFCode);
                        }

                        curCase.SellerFactor = sellerFactor;
                        string IFCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Factor buyerFactor = context.Factors.SingleOrDefault(f => f.FactorCode == IFCode);
                        if (buyerFactor == null)
                        {
                            throw new Exception("买方保理商代码错误： " + IFCode);
                        }

                        curCase.BuyerFactor = buyerFactor;
                        column++;
                        curCase.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        double? netPaymentTerm = (double?)valueArray[row, column++];
                        if (netPaymentTerm.HasValue)
                        {
                            curCase.NetPaymentTerm = Convert.ToInt32(netPaymentTerm.Value.ToString());
                        }
                        curCase.CaseAppDate = (DateTime)valueArray[row, column++];
                        curCase.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (Case curCase in caseList)
                    {
                        curCase.BuyerClient = null;
                        curCase.SellerClient = null;
                        curCase.BuyerFactor = null;
                        curCase.SellerFactor = null;
                        curCase.OwnerDepartment = null;
                    }

                    e1.Data["row"] = result;
                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportCDA(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

            List<CDA> cdaList = new List<CDA>();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                Case curCase = null;

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
                        string caseCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(caseCode))
                        {
                            continue;
                        }

                        curCase = context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase == null)
                        {
                            throw new Exception("案件编号错误: " + caseCode);
                        }

                        if (curCase.TransactionType != "进口保理" && curCase.SellerClient.Contract == null)
                        {
                            throw new Exception("缺少主合同：" + caseCode);
                        }

                        //string cdaCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        CDA cda = null;
                        //if (String.IsNullOrEmpty(cdaCode))
                        //{
                        //    throw new Exception("CDA编号不能为空");
                        //}

                        column++;
                        string cdaCode = CDA.GenerateCDACode(curCase, cdaList);

                        cda = context.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                        if (cda != null)
                        {
                            throw new Exception("CDA已存在，不能导入： " + cdaCode);
                        }

                        cda = cdaList.SingleOrDefault(c => c.CDACode == cdaCode);
                        if (cda != null)
                        {
                            throw new Exception("CDA编号重复，不能导入： " + cdaCode);
                        }

                        cda = new CDA();
                        cda.CDACode = cdaCode;
                        cda.CDAStatus = CDAStr.CHECKED;
                        cdaList.Add(cda);
                        cda.Case = curCase;

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
                        double? pugPeriod = (System.Nullable<double>)valueArray[row, column++];
                        if (pugPeriod.HasValue)
                        {
                            cda.PUGPeriod = Convert.ToInt32(pugPeriod.Value);
                        }
                        double? reassignPeriod = (System.Nullable<double>)valueArray[row, column++];
                        if (reassignPeriod.HasValue)
                        {
                            cda.ReassignGracePeriod = Convert.ToInt32(reassignPeriod.Value);
                        }
                        cda.FinanceLineCurr = String.Format("{0:G}", valueArray[row, column++]);
                        cda.FinanceLine = (System.Nullable<double>)valueArray[row, column++];
                        cda.FinanceLinePeriodBegin = (System.Nullable<DateTime>)valueArray[row, column++];
                        cda.FinanceLinePeriodEnd = (System.Nullable<DateTime>)valueArray[row, column++];
                        cda.HighestFinanceLine = (System.Nullable<double>)valueArray[row, column++];
                        cda.FinanceProportion = (System.Nullable<double>)valueArray[row, column++];
                        double? financePeriod = (System.Nullable<double>)valueArray[row, column++];
                        if (financePeriod.HasValue)
                        {
                            cda.FinanceGracePeriod = Convert.ToInt32(financePeriod.Value);
                        }
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
                        cda.CDASignDate = (DateTime)valueArray[row, column++];
                        cda.CDAStatus = String.Format("{0:G}", valueArray[row, column++]);
                        cda.IsSigned = TypeUtil.ConvertStrToBool(valueArray[row, column++]);
                        cda.NoticeMethod = String.Format("{0:G}", valueArray[row, column++]);
                        cda.NoticePerson = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Email = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Fax = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        if (cda.HandFee.HasValue == false)
                        {
                            cda.HandFeeCurr = null;
                        }

                        if (cda.IFPrice.HasValue == false)
                        {
                            cda.IFPrice = 0;
                        }

                        if (cda.Price.HasValue == false)
                        {
                            cda.Price = cda.IFPrice;
                        }

                        cda.EFPrice = cda.Price - cda.IFPrice;

                        cda.AdjustCDAStatus();

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (CDA cda in cdaList)
                    {
                        cda.Case = null;
                    }

                    if (cdaList.Count != result)
                    {
                        e1.Data["row"] = result;
                    }

                    if (curCase != null)
                    {
                        e1.Data["ID"] = curCase.CaseCode;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportClient(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<Client> clientList = new List<Client>();
            this.context = new DBDataContext();

            try
            {
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

                        string clientEDICode = String.Format("{0:G}", valueArray[row, 2]).Trim();
                        if (String.IsNullOrEmpty(clientEDICode))
                        {
                            continue;
                        }

                        Client client = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client != null)
                        {
                            throw new Exception("客户已经存在，不能导入： " + clientEDICode);
                        }

                        client = clientList.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client != null)
                        {
                            throw new Exception("客户编号重复，不能导入： " + clientEDICode);
                        }

                        client = new Client();
                        client.ClientEDICode = clientEDICode;
                        clientList.Add(client);

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
                        if (!String.IsNullOrEmpty(groupNo))
                        {
                            Client clientGroup = context.Clients.SingleOrDefault(c => c.ClientEDICode == groupNo);
                            if (clientGroup == null)
                            {
                                throw new Exception("集团客户号错误： " + groupNo);
                            }
                        }

                        column++;
                        client.RegistrationNumber = String.Format("{0:G}", valueArray[row, column++]);
                        client.CompanyCode = String.Format("{0:G}", valueArray[row, column++]);
                        string departmentName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Department = context.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));

                        client.PMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.RMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        client.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(client.CreateUserName))
                        {
                            client.CreateUserName = App.Current.CurUser.Name;
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                }

                context.Clients.InsertAllOnSubmit(clientList);
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (Client client in clientList)
                {
                    client.ClientGroup = null;
                    client.Department = null;
                }

                if (result != clientList.Count)
                {
                    e1.Data["row"] = result;
                }

                throw;
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportClientsCreditLine(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

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

                        string clientEDICode = String.Format("{0:G}", valueArray[row, 1]).Trim();
                        if (String.IsNullOrEmpty(clientEDICode))
                        {
                            continue;
                        }

                        Client client = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户保理代码错误: " + clientEDICode);
                        }

                        int column = 3;
                        ClientCreditLine creditLine = new ClientCreditLine();
                        creditLine.CreditLineType = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLineCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLine = (double)valueArray[row, column++];
                        creditLine.PeriodBegin = (DateTime)valueArray[row, column++];
                        creditLine.PeriodEnd = (DateTime)valueArray[row, column++];
                        creditLine.ApproveNo = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.ApproveType = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLineStatus = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.FreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Freezer = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.FreezeDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        creditLine.UnfreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Unfreezer = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Client = client;
                        creditLineList.Add(creditLine);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (ClientCreditLine creditLine in creditLineList)
                    {
                        creditLine.Client = null;
                    }

                    if (result != creditLineList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportClientsOverwrite(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<Client> clientList = new List<Client>();
            this.context = new DBDataContext();

            try
            {
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

                        string clientEDICode = String.Format("{0:G}", valueArray[row, 2]).Trim();
                        if (String.IsNullOrEmpty(clientEDICode))
                        {
                            continue;
                        }

                        Client client = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户不存在，不能导入： " + clientEDICode);
                        }

                        if (clientList.SingleOrDefault(c => c.ClientEDICode == clientEDICode) != null)
                        {
                            throw new Exception("客户编号重复，不能导入： " + clientEDICode);
                        }

                        clientList.Add(client);

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
                        if (!String.IsNullOrEmpty(groupNo))
                        {
                            Client clientGroup = context.Clients.SingleOrDefault(c => c.ClientEDICode == groupNo);
                            if (clientGroup == null)
                            {
                                throw new Exception("集团客户号错误： " + groupNo);
                            }
                        }

                        column++;
                        client.RegistrationNumber = String.Format("{0:G}", valueArray[row, column++]);
                        client.CompanyCode = String.Format("{0:G}", valueArray[row, column++]);
                        string departmentName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Department = context.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));

                        client.PMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.RMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        client.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(client.CreateUserName))
                        {
                            client.CreateUserName = App.Current.CurUser.Name;
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                }

                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                if (result != clientList.Count)
                {
                    e1.Data["row"] = result;
                }

                throw;
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportClientsReivew(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<ClientReview> reviewList = new List<ClientReview>();
            this.context = new DBDataContext();

            try
            {
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

                        string clientEDICode = String.Format("{0:G}", valueArray[row, 1]).Trim();
                        if (String.IsNullOrEmpty(clientEDICode))
                        {
                            continue;
                        }

                        Client client = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户保理代码错误，不能导入协查意见书： " + clientEDICode);
                        }

                        int column = 3;
                        string reviewNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(reviewNo))
                        {
                            throw new Exception("协查意见编号不能为空");
                        }

                        ClientReview review = context.ClientReviews.SingleOrDefault(c => c.ReviewNo == reviewNo);
                        if (review != null)
                        {
                            throw new Exception("协查意见已存在，不能导入： " + reviewNo);
                        }

                        review = reviewList.SingleOrDefault(c => c.ReviewNo == reviewNo);
                        if (review != null)
                        {
                            throw new Exception("协查意见编号重复，不能导入： " + reviewNo);
                        }

                        review = new ClientReview();
                        review.ReviewNo = reviewNo;
                        review.RequestCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        review.RequestAmount = (System.Nullable<double>)valueArray[row, column++];
                        review.RequestFinanceType = String.Format("{0:G}", valueArray[row, column++]);
                        review.RequestFinanceType2 = String.Format("{0:G}", valueArray[row, column++]);
                        double? requestPeriod = (System.Nullable<double>)valueArray[row, column++];
                        if (requestPeriod.HasValue)
                        {
                            review.RequestFinancePeriod = Convert.ToInt32(requestPeriod.Value);
                        }
                        review.RequestCommissionRate = (System.Nullable<double>)valueArray[row, column++];
                        review.ReviewStatus = String.Format("{0:G}", valueArray[row, column++]);
                        review.ReviewDate = (DateTime)valueArray[row, column++];
                        review.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        review.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        review.Client = client;
                        reviewList.Add(review);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
            }
            catch (Exception e1)
            {
                foreach (ClientReview review in reviewList)
                {
                    review.Client = null;
                }

                if (result != reviewList.Count)
                {
                    e1.Data["row"] = result;
                }

                throw;
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportContract(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<Contract> contractList = new List<Contract>();
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
                        string clientEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(clientEDICode))
                        {
                            continue;
                        }

                        column++;

                        Client client = null;
                        client = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户编号错误: " + clientEDICode);
                        }

                        string contractCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Contract contract = null;
                        if (String.IsNullOrEmpty(contractCode))
                        {
                            throw new Exception("保理合同号不能为空");
                        }

                        contract = context.Contracts.SingleOrDefault(c => c.ContractCode == contractCode);
                        if (contract != null)
                        {
                            throw new Exception("保理合同已存在，不能导入: " + contractCode);
                        }

                        contract = contractList.SingleOrDefault(c => c.ContractCode == contractCode);
                        if (contract != null)
                        {
                            throw new Exception("保理合同重复，不能导入: " + contractCode);
                        }

                        contract = new Contract();
                        contract.ContractCode = contractCode;
                        contract.Client = client;
                        contractList.Add(contract);
                        contract.ContractType = String.Format("{0:G}", valueArray[row, column++]);
                        contract.ContractValueDate = (DateTime)valueArray[row, column++];
                        contract.ContractDueDate = (DateTime)valueArray[row, column++];
                        contract.ContractStatus = String.Format("{0:G}", valueArray[row, column++]);
                        contract.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (Contract contract in contractList)
                    {
                        contract.Client = null;
                    }

                    e1.Data["row"] = result;
                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportCreditCoverNeg(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
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

                        string caseCode = String.Format("{0:G}", valueArray[row, 1]).Trim();

                        if (String.IsNullOrEmpty(caseCode))
                        {
                            continue;
                        }

                        Case curCase = context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase == null)
                        {
                            throw new Exception("案件不存在，不能导入关联额度： " + caseCode);
                        }

                        int column = 5;
                        CreditCoverNegotiation creditCover = new CreditCoverNegotiation();
                        creditCover.RequestType = String.Format("{0:G}", valueArray[row, column++]);
                        creditCover.RequestAmount = (double)valueArray[row, column++];
                        double? netPaymentTerm = (double?)valueArray[row, column++];
                        if (netPaymentTerm.HasValue)
                        {
                            creditCover.NetPaymentTerm = Convert.ToInt32(netPaymentTerm.Value.ToString());
                        }
                        creditCover.RequestDate = (DateTime)valueArray[row, column++];
                        creditCover.ReplyAmount = (System.Nullable<double>)valueArray[row, column++];
                        creditCover.ReplyDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        creditCover.IFPrice = (System.Nullable<double>)valueArray[row, column++];
                        creditCover.PriceDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        creditCover.DueDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        creditCover.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        creditCover.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        creditCover.Case = curCase;
                        creditCoverList.Add(creditCover);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (CreditCoverNegotiation neg in creditCoverList)
                    {
                        neg.Case = null;
                    }

                    e1.Data["row"] = result;
                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportCreditNote(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            List<InvoicePaymentBatch> paymentBatchList = new List<InvoicePaymentBatch>();
            List<CreditNote> creditNoteList = new List<CreditNote>();

            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                InvoiceAssignBatch assignBatch = null;
                InvoicePaymentBatch paymentBatch = null;
                Invoice invoice = null;
                InvoicePaymentLog log = null;
                CreditNote creditNote = null;

                try
                {
                    for (int row = 3; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string assignBatchCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string creditNoteNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = String.Format("{0:G}", valueArray[row, 5]).Trim();

                        if (String.IsNullOrEmpty(assignBatchCode))
                        {
                            if (String.IsNullOrEmpty(creditNoteNo))
                            {
                                break;
                            }
                            else
                            {
                                throw new Exception("业务编号不能为空，不能导入");
                            }
                        }
                        else
                        {
                            if (assignBatchCode.Length > 20)
                            {
                                break;
                            }

                            if (assignBatch == null || assignBatch.AssignBatchNo != assignBatchCode)
                            {
                                assignBatch = context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchCode);

                                if (assignBatch == null)
                                {
                                    throw new Exception("业务编号错误，不能导入：" + assignBatchCode);
                                }

                                CDA cda = assignBatch.Case.ActiveCDA;
                                if (cda == null)
                                {
                                    throw new Exception("没有有效的额度通知书: " + assignBatchCode);
                                }
                            }

                            if (String.IsNullOrEmpty(creditNoteNo))
                            {
                                throw new Exception("贷项通知号不能为空，不能导入，业务编号： " + assignBatchCode);
                            }

                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("对应发票号不能为空，不能导入，业务编号： " + assignBatchCode);
                            }
                        }

                        invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.AssignBatchNo == assignBatchCode);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误，不能导入，发票号：" + invoiceNo);
                        }

                        creditNote = context.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                        if (creditNote == null)
                        {
                            creditNote = creditNoteList.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                            if (creditNote == null)
                            {
                                creditNote = new CreditNote();
                                creditNote.CreditNoteNo = creditNoteNo;
                                creditNoteList.Add(creditNote);
                            }
                        }
                        else
                        {
                            throw new Exception("贷项通知号已存在，不能导入：" + creditNoteNo);
                        }

                        log = new InvoicePaymentLog();
                        log.CreditNote = creditNote;

                        string creditNoteAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double creditNoteAmount = 0;
                        if (String.IsNullOrEmpty(creditNoteAmountStr))
                        {
                            throw new Exception("贷项通知金额不能为空，不能导入：" + creditNoteNo);
                        }
                        if (Double.TryParse(creditNoteAmountStr, out creditNoteAmount))
                        {
                            log.PaymentAmount = creditNoteAmount;
                        }
                        else
                        {
                            throw new Exception("贷项通知金额类型异常，不能导入：" + creditNoteNo);
                        }

                        string creditNoteDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(creditNoteDateStr))
                        {
                            throw new Exception("贷项通知日不能为空，不能导入：" + creditNoteNo);
                        }

                        DateTime creditNoteDate = default(DateTime);
                        if (DateTime.TryParse(creditNoteDateStr, out creditNoteDate))
                        {
                            creditNote.CreditNoteDate = creditNoteDate;
                        }
                        else
                        {
                            throw new Exception("贷项通知日类型异常，不能导入：" + creditNoteNo);
                        }

                        string comment = String.Format("{0:G}", valueArray[row, 6]);
                        log.Comment = comment;

                        if (paymentBatch == null || paymentBatch.CaseCode != assignBatch.CaseCode)
                        {
                            paymentBatch = new InvoicePaymentBatch();
                            paymentBatch.Case = assignBatch.Case;
                            paymentBatch.CheckStatus = BATCH.UNCHECK;
                            paymentBatch.Comment = comment;
                            paymentBatch.InputDate = DateTime.Now;
                            paymentBatch.IsCreateMsg = false;
                            paymentBatch.PaymentDate = DateTime.Now;
                            paymentBatch.PaymentType = "贷项通知";
                            paymentBatch.CreateUserName = App.Current.CurUser.Name;
                            paymentBatch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(DateTime.Now, paymentBatchList);
                        }

                        if (TypeUtil.GreaterZero(creditNoteAmount - invoice.AssignOutstanding))
                        {
                            throw new Exception("贷项通知金额不能大于转让余额，不能导入：" + creditNoteNo);
                        }

                        log.Invoice = invoice;
                        log.InvoicePaymentBatch = paymentBatch;
                        invoice.CaculatePayment();

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception)
                {
                    foreach (InvoicePaymentBatch batch in paymentBatchList)
                    {
                        foreach (InvoicePaymentLog l in batch.InvoicePaymentLogs)
                        {
                            Invoice i = l.Invoice;
                            l.Invoice = null;
                            l.CreditNote = null;
                            i.CaculatePayment();
                        }

                        batch.Case = null;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportDepartment(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

            if (valueArray != null)
            {
                try
                {
                    int size = valueArray.GetUpperBound(0);
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string departmentCode = String.Format("{0:G}", valueArray[row, 1]).Trim();
                        if (String.IsNullOrEmpty(departmentCode))
                        {
                            continue;
                        }

                        bool isNew = false;
                        Department dept = context.Departments.SingleOrDefault(d => d.DepartmentCode == departmentCode);
                        if (dept == null)
                        {
                            isNew = true;
                            dept = new Department();
                            dept.DepartmentCode = departmentCode;
                        }

                        int column = 2;
                        dept.DepartmentName = String.Format("{0:G}", valueArray[row, column++]);
                        string locationName = String.Format("{0:G}", valueArray[row, column++]);
                        dept.Location = context.Locations.SingleOrDefault(l => l.LocationName == locationName);
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
                            context.Departments.InsertOnSubmit(dept);
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }

                catch (Exception e1)
                {
                    e1.Data["row"] = result;
                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportExchangeRate(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

            try
            {
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

                        string from = String.Format("{0:G}", valueArray[row, 1]);
                        string to = String.Format("{0:G}", valueArray[row, 2]);
                        Exchange exchange = context.Exchanges.SingleOrDefault(ex => ex.FromCurr == from && ex.ToCurr == to);
                        if (exchange == null)
                        {
                            exchange = new Exchange();
                            context.Exchanges.InsertOnSubmit(exchange);
                        }
                        exchange.ExchangeRate = (double)valueArray[row, 3];
                        exchange.LastModifiedDate = DateTime.Now;

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
            }
            catch (Exception e1)
            {
                e1.Data["row"] = result;
                throw;
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportFactor(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            this.context = new DBDataContext();

            List<Factor> factorList = new List<Factor>();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                Factor factor = null;

                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string factorCode = String.Format("{0:G}", valueArray[row, 2]).Trim();
                        if (String.IsNullOrEmpty(factorCode))
                        {
                            continue;
                        }

                        bool isNew = false;
                        factor = context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
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
                        if (!String.IsNullOrEmpty(monitorResult))
                        {
                            DialogResult dr = MessageBoxEx.Show(monitorResult, "是否更新", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dr == DialogResult.Yes)
                            {
                                factor.LastModifiedDate = DateTime.Now;
                            }
                            else
                            {
                                DBDataContext contextNew = new DBDataContext();
                                factor = contextNew.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
                            }
                        }

                        if (isNew)
                        {
                            factorList.Add(factor);
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.Factors.InsertAllOnSubmit(factorList);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (Factor f in factorList)
                    {
                        f.FactorGroup = null;
                    }

                    if (result != factorList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    if (factor != null)
                    {
                        e1.Data["ID"] = factor.FactorCode;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private object ImportFactorsCreditLine(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

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

                        string factorCode = String.Format("{0:G}", valueArray[row, 1]).Trim();
                        if (String.IsNullOrEmpty(factorCode))
                        {
                            continue;
                        }

                        Factor factor = context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                        if (factor == null)
                        {
                            throw new Exception("合作机构代码错误: " + factorCode);
                        }

                        int column = 2;
                        FactorCreditLine creditLine = new FactorCreditLine();
                        creditLine.CreditLineCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLine = (double)valueArray[row, column++];
                        creditLine.PeriodBegin = (DateTime)valueArray[row, column++];
                        creditLine.PeriodEnd = (DateTime)valueArray[row, column++];
                        creditLine.ApproveNo = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.ApproveType = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.CreditLineStatus = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.FreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Freezer = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.FreezeDate = (System.Nullable<DateTime>)valueArray[row, column++];
                        creditLine.UnfreezeReason = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Unfreezer = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        creditLine.Factor = factor;
                        creditLineList.Add(creditLine);
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (FactorCreditLine creditLine in creditLineList)
                    {
                        creditLine.Factor = null;
                    }

                    if (result != creditLineList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportFinance(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            List<InvoiceFinanceBatch> financeBatchList = new List<InvoiceFinanceBatch>();
            List<InvoicePaymentBatch> paymentBatchList = new List<InvoicePaymentBatch>();

            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                InvoiceAssignBatch assignBatch = null;

                try
                {
                    for (int row = 3; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string assignBatchCode = String.Format("{0:G}", valueArray[row, column++]).Trim();

                        if (String.IsNullOrEmpty(assignBatchCode) || assignBatchCode.Length > 20)
                        {
                            break;
                        }

                        assignBatch = context.InvoiceAssignBatches.SingleOrDefault(c => c.AssignBatchNo == assignBatchCode);
                        if (assignBatch == null)
                        {
                            throw new Exception("业务编号错误：" + assignBatchCode);
                        }

                        if (assignBatch.CheckStatus != BATCH.CHECK)
                        {
                            throw new Exception("该业务未复核（或复核未通过）：" + assignBatchCode);
                        }

                        InvoiceFinanceBatch financeBatch = new InvoiceFinanceBatch();

                        string financeType = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeType))
                        {
                            throw new Exception("出账方式不能为空，不能导入：" + assignBatchCode);
                        }
                        else
                        {
                            financeBatch.FinanceType = financeType;
                        }

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("融资币别不能为空，不能导入：" + assignBatchCode);
                        }
                        else
                        {
                            financeBatch.BatchCurrency = batchCurrency;
                        }

                        string financeAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeAmountStr))
                        {
                            throw new Exception("融资金额不能为空，不能导入：" + assignBatchCode);
                        }
                        double financeAmount = 0;
                        if (Double.TryParse(financeAmountStr, out financeAmount))
                        {
                            financeBatch.FinanceAmount = financeAmount;
                        }
                        else
                        {
                            throw new Exception("融资金额类型异常，不能导入：" + assignBatchCode);
                        }

                        string beginDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(beginDateStr))
                        {
                            throw new Exception("融资日不能为空，不能导入：" + assignBatchCode);
                        }
                        DateTime beginDate = default(DateTime);
                        if (DateTime.TryParse(beginDateStr, out beginDate))
                        {
                            financeBatch.FinancePeriodBegin = beginDate;
                        }
                        else
                        {
                            throw new Exception("融资日类型异常，不能导入：" + assignBatchCode);
                        }

                        string endDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(endDateStr))
                        {
                            throw new Exception("融资到期日不能为空，不能导入：" + assignBatchCode);
                        }
                        DateTime endDate = default(DateTime);
                        if (DateTime.TryParse(endDateStr, out endDate))
                        {
                            financeBatch.FinancePeriodEnd = endDate;
                        }
                        else
                        {
                            throw new Exception("融资到期日类型异常，不能导入：" + assignBatchCode);
                        }

                        string financeRateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeRateStr))
                        {
                            throw new Exception("融资利率不能为空，不能导入：" + assignBatchCode);
                        }
                        double financeRate = 0;
                        if (Double.TryParse(financeRateStr, out financeRate))
                        {
                            financeBatch.FinanceRate = financeRate;
                        }
                        else
                        {
                            throw new Exception("融资利率类型异常，不能导入：" + assignBatchCode);
                        }

                        string costRateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(costRateStr))
                        {
                            double costRate = 0;
                            if (Double.TryParse(costRateStr, out costRate))
                            {
                                financeBatch.CostRate = costRate;
                            }
                            else
                            {
                                throw new Exception("成本利率类型异常，不能导入：" + assignBatchCode);
                            }
                        }

                        string factorCode = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(factorCode))
                        {
                            Factor factor = context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                throw new Exception("代付行编码错误：" + factorCode);
                            }

                            financeBatch.Factor = factor;
                        }

                        CDA activeCDA = assignBatch.Case.ActiveCDA;
                        GuaranteeDeposit gd = assignBatch.Case.GuaranteeDepositClient.GetGuaranteeDeposit(batchCurrency);
                        double guaranteeDeposit = 0;

                        if (activeCDA == null)
                        {
                            throw new Exception("没有有效的额度通知书，业务编号：" + assignBatchCode);
                        }

                        if (gd != null)
                        {
                            guaranteeDeposit = gd.GuaranteeDepositAmount;
                        }

                        if (activeCDA.HighestFinanceLine.HasValue == false)
                        {
                            throw new Exception("该案件的最高预付款融资额度余额不足，不能融资：" + assignBatchCode);
                        }

                        if (activeCDA.FinanceCreditLine.PeriodEnd < DateTime.Today)
                        {
                            throw new Exception(String.Format("融资额度已到期{0:d}，不能融资：{1}", activeCDA.FinanceCreditLine.PeriodEnd, assignBatchCode));
                        }
                        if (TypeUtil.LessZero(activeCDA.FinanceLineOutstanding - financeAmount + guaranteeDeposit))
                        {
                            throw new Exception(String.Format("该案件的预付款融资额度余额为{0:N2}，欲融资{1:N2}，额度不足，不能融资：{2}", (activeCDA.FinanceLineOutstanding + guaranteeDeposit), financeAmount, assignBatchCode));
                        }

                        if (TypeUtil.LessZero(activeCDA.HighestFinanceLine - assignBatch.Case.TotalFinanceOutstanding - financeAmount + guaranteeDeposit))
                        {
                            throw new Exception(String.Format("该案件的最高预付款融资额度余额为{0:N2}，欲融资{1:N2}，额度不足，不能融资：{2}", (activeCDA.HighestFinanceLine - assignBatch.Case.TotalFinanceOutstanding + guaranteeDeposit), financeAmount, assignBatchCode));
                        }

                        financeBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        financeBatch.CheckStatus = BATCH.UNCHECK;
                        financeBatch.InputDate = DateTime.Today;
                        financeBatch.CreateUserName = App.Current.CurUser.Name;
                        financeBatch.FinanceBatchNo = InvoiceFinanceBatch.GenerateFinanceBatchNo(financeBatch.FinancePeriodBegin, financeBatchList);
                        financeBatch.Case = assignBatch.Case;

                        financeBatchList.Add(financeBatch);



                        double currentFinanceAmount = 0;
                        IEnumerable<Invoice> invoices = null;
                        if (assignBatch.Case.TransactionType == "国内买方保理")
                        {
                            invoices = assignBatch.Invoices.Where(i => (i.IsDispute.HasValue == false || i.IsDispute == false) && i.IsFlaw == false && i.InvoiceAssignBatch.CheckStatus == BATCH.CHECK).OrderBy(i => i.DueDate);
                        }
                        else
                        {
                            invoices = assignBatch.Invoices.Where(i => (i.IsDispute.HasValue == false || i.IsDispute == false) && i.IsFlaw == false && i.InvoiceAssignBatch.CheckStatus == BATCH.CHECK && i.DueDate > financeBatch.FinancePeriodBegin).OrderBy(i => i.DueDate);
                        }

                        foreach (Invoice invoice in invoices)
                        {
                            double canBeFinanceAmount = invoice.AssignOutstanding * activeCDA.FinanceProportion.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault();
                            if (TypeUtil.GreaterZero(canBeFinanceAmount))
                            {
                                if (invoice.InvoiceCurrency != financeBatch.BatchCurrency)
                                {
                                    double rate = Exchange.GetExchangeRate(invoice.InvoiceCurrency, financeBatch.BatchCurrency);
                                    canBeFinanceAmount *= rate;
                                }

                                double logFinanceAmount = 0;
                                if (canBeFinanceAmount + currentFinanceAmount > financeBatch.FinanceAmount)
                                {
                                    logFinanceAmount = financeBatch.FinanceAmount - currentFinanceAmount;
                                }
                                else
                                {
                                    logFinanceAmount = canBeFinanceAmount;
                                }

                                if (TypeUtil.GreaterZero(logFinanceAmount))
                                {
                                    InvoiceFinanceLog log = new InvoiceFinanceLog();
                                    log.Invoice = invoice;
                                    log.InvoiceFinanceBatch = financeBatch;
                                    log.FinanceAmount = logFinanceAmount;
                                    currentFinanceAmount += logFinanceAmount;
                                    if (activeCDA.CommissionType == "按融资金额")
                                    {
                                        log.Commission = log.FinanceAmount * activeCDA.Price;
                                    }

                                    log.Invoice.CaculateCommission(true);
                                    log.Invoice.CaculateFinance();
                                }
                            }
                        }

                        if (TypeUtil.GreaterZero(financeBatch.FinanceAmount - currentFinanceAmount))
                        {
                            throw new Exception(String.Format("本次申请融资金额{0:N2}，大于实际融资金额{1:N2}，业务编号：{2}", financeBatch.FinanceAmount, currentFinanceAmount, assignBatchCode));
                        }

                        if (assignBatch.Case.TransactionType == "国内买方保理")
                        {
                            if (financeBatch.BatchCurrency != assignBatch.Case.InvoiceCurrency)
                            {
                                throw new Exception(String.Format("国内买方保理，融资币别{0}需要与发票币别{1}相同，业务编号：{2}", financeBatch.BatchCurrency, assignBatch.Case.InvoiceCurrency, assignBatchCode));
                            }

                            InvoicePaymentBatch paymentBatch = new InvoicePaymentBatch();
                            paymentBatch.PaymentType = Payment.BUYER_PAYMENT;
                            paymentBatch.PaymentDate = financeBatch.FinancePeriodBegin;
                            paymentBatch.CheckStatus = BATCH.UNCHECK;
                            paymentBatch.CreateUserName = App.Current.CurUser.Name;
                            paymentBatch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(paymentBatch.PaymentDate, paymentBatchList);
                            paymentBatch.Case = financeBatch.Case;
                            paymentBatch.InputDate = DateTime.Today;
                            paymentBatchList.Add(paymentBatch);

                            foreach (InvoiceFinanceLog financeLog in financeBatch.InvoiceFinanceLogs)
                            {
                                InvoicePaymentLog paymentLog = new InvoicePaymentLog();
                                paymentLog.InvoicePaymentBatch = paymentBatch;
                                paymentLog.PaymentAmount = financeLog.FinanceAmount;
                                paymentLog.Invoice = financeLog.Invoice;
                                paymentLog.Invoice.CaculatePayment();
                            }
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (InvoiceFinanceBatch batch in financeBatchList)
                    {
                        foreach (InvoiceFinanceLog log in batch.InvoiceFinanceLogs)
                        {
                            Invoice invoice = log.Invoice;
                            log.Invoice = null;
                            invoice.CaculateFinance();
                            invoice.CaculateCommission(true);
                        }

                        batch.Case = null;
                    }

                    if (assignBatch != null)
                    {
                        e1.Data["ID"] = assignBatch.AssignBatchNo;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportFinanceByBatch(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<InvoiceFinanceLog> logList = new List<InvoiceFinanceLog>();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);

                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string assignBatchNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(invoiceNo))
                        {
                            continue;
                        }

                        Invoice invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.AssignBatchNo == assignBatchNo);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误: " + invoiceNo);
                        }

                        column++;
                        InvoiceFinanceLog log = new InvoiceFinanceLog(invoice);
                        log.FinanceAmount = (System.Nullable<double>)valueArray[row, column++];
                        log.Commission = (System.Nullable<double>)valueArray[row, column++];
                        log.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        logList.Add(log);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                }
                catch (Exception e1)
                {
                    if (result != logList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    throw;
                }
            }

            this.ImportedList = logList;
            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportInvoice(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            this.context = new DBDataContext();

            int result = 0;
            int column = 0;
            Case curCase = null;
            Invoice invoice = null;
            InvoiceFinanceLog financeLog = null;
            InvoicePaymentLog paymentLog = null;
            InvoiceRefundLog refundLog = null;

            InvoiceAssignBatch assignBatch = null;
            InvoiceFinanceBatch financeBatch = null;
            InvoicePaymentBatch paymentBatch = null;
            InvoiceRefundBatch refundBatch = null;

            List<InvoiceAssignBatch> assignBatches = new List<InvoiceAssignBatch>();
            List<InvoiceFinanceBatch> financeBatches = new List<InvoiceFinanceBatch>();
            List<InvoicePaymentBatch> paymentBatches = new List<InvoicePaymentBatch>();
            List<InvoiceRefundBatch> refundBatches = new List<InvoiceRefundBatch>();
            List<Invoice> invoiceList = new List<Invoice>();
            List<CreditNote> creditNoteList = new List<CreditNote>();

            try
            {
                if (valueArray != null)
                {
                    int size = valueArray.GetUpperBound(0);
                    for (int row = 11; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string createUserName = String.Format("{0:G}", valueArray[row, 1]);

                        //Case
                        string caseCode = String.Format("{0:G}", valueArray[row, 2]).Trim();
                        if (String.IsNullOrEmpty(caseCode))
                        {
                            continue;
                        }

                        if (curCase == null || curCase.CaseCode != caseCode)
                        {
                            curCase = context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                            if (curCase == null)
                            {
                                throw new Exception("案件编号错误: " + caseCode);
                            }
                        }

                        CDA activeCDA = curCase.ActiveCDA;
                        if (activeCDA == null)
                        {
                            throw new Exception("没有有效的额度通知书: " + caseCode);
                        }

                        string type = String.Format("{0:G}", valueArray[row, 4]);
                        if (String.IsNullOrEmpty(type))
                        {
                            throw new Exception("发票/贷项通知需要声明: " + row);
                        }

                        if ("发票".Equals(type))
                        {
                            //发票信息
                            column = 5;
                            string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("发票号不能为空");
                            }

                            invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
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
                                    throw new Exception("当前导入文件中发票号重复: " + old.InvoiceNo);
                                }
                            }
                            else
                            {
                                throw new Exception("发票已经存在，不能导入： " + invoiceNo);
                            }

                            column = 8;
                            invoice.InvoiceAmount = (double)valueArray[row, column++];
                            invoice.AssignAmount = invoice.InvoiceAmount;
                            invoice.InvoiceDate = (System.Nullable<DateTime>)valueArray[row, column++];
                            invoice.DueDate = (DateTime)valueArray[row, column++];
                            DateTime assignDate = (DateTime)valueArray[row, column++];
                            invoice.IsFlaw = TypeUtil.ConvertStrToBool(valueArray[row, column++]);

                            //转让批次信息
                            assignBatch = assignBatches.SingleOrDefault(i => i.Case.CaseCode == caseCode && i.AssignDate == assignDate);
                            if (assignBatch == null)
                            {
                                assignBatch = new InvoiceAssignBatch();
                                assignBatch.AssignDate = assignDate;
                                assignBatch.CreateUserName = createUserName;
                                assignBatch.CheckStatus = BATCH.CHECK;
                                assignBatch.AssignBatchNo = InvoiceAssignBatch.GenerateAssignBatchNo(caseCode, assignBatch.AssignDate, assignBatches);
                                assignBatch.Case = curCase;
                                assignBatches.Add(assignBatch);
                            }

                            invoice.InvoiceAssignBatch = assignBatch;

                            //融资批次信息
                            column = 13;
                            string financeType = String.Format("{0:G}", valueArray[row, column++]);
                            column = 16;
                            DateTime? financeDate = (System.Nullable<DateTime>)valueArray[row, column++];
                            DateTime? financeDueDate = (System.Nullable<DateTime>)valueArray[row, column++];

                            if (financeDate != null && financeDueDate != null)
                            {
                                financeBatch = financeBatches.SingleOrDefault(i => i.Case.CaseCode == caseCode && i.FinanceType == financeType && i.FinancePeriodBegin.Date == financeDate && i.FinancePeriodEnd.Date == financeDueDate);
                                if (financeBatch == null)
                                {
                                    financeBatch = new InvoiceFinanceBatch();
                                    financeBatch.FinanceType = financeType;
                                    column = 14;
                                    financeBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                                    column = 25;
                                    financeBatch.FinanceRate = (double)valueArray[row, column++];
                                    financeBatch.FinancePeriodBegin = financeDate.Value;
                                    financeBatch.FinancePeriodEnd = financeDueDate.Value;
                                    financeBatch.CreateUserName = createUserName;
                                    financeBatch.CheckStatus = BATCH.CHECK;
                                    financeBatch.FinanceBatchNo = InvoiceFinanceBatch.GenerateFinanceBatchNo(financeBatch.FinancePeriodBegin, financeBatches);
                                    financeBatch.Case = curCase;
                                    financeBatches.Add(financeBatch);
                                }
                            }

                            //融资信息
                            column = 15;
                            double? financeAmount = (System.Nullable<double>)valueArray[row, column++];
                            if (financeAmount.HasValue)
                            {
                                if (financeBatch == null)
                                {
                                    throw new Exception("缺少融资批次信息: " + invoice.InvoiceNo);
                                }

                                financeLog = new InvoiceFinanceLog();
                                financeLog.Invoice = invoice;
                                financeLog.FinanceAmount = financeAmount.Value;
                                financeLog.InvoiceFinanceBatch = financeBatch;
                                invoice.CaculateFinance();
                                financeBatch.CaculateFinanceAmount();
                            }

                            //付款批次信息
                            column = 18;
                            string paymentType = Payment.BUYER_PAYMENT;
                            column = 19;
                            DateTime? paymentDate = (System.Nullable<DateTime>)valueArray[row, column++];
                            if (paymentDate != null)
                            {
                                paymentBatch = paymentBatches.SingleOrDefault(i => i.Case.CaseCode == caseCode && i.PaymentDate == paymentDate && i.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch();
                                    paymentBatch.PaymentType = paymentType;
                                    paymentBatch.PaymentDate = paymentDate.Value;
                                    paymentBatch.CheckStatus = BATCH.CHECK;
                                    paymentBatch.CreateUserName = createUserName;
                                    paymentBatch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(paymentBatch.PaymentDate, paymentBatches);
                                    paymentBatch.Case = curCase;
                                    paymentBatches.Add(paymentBatch);
                                }
                            }

                            //付款信息
                            column = 18;
                            double? paymentAmount = (System.Nullable<double>)valueArray[row, column++];
                            if (paymentAmount.HasValue)
                            {
                                paymentLog = new InvoicePaymentLog();
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
                            column = 21;
                            string refundType = Refund.BUYER_PAYMENT;

                            DateTime? refundDate = (System.Nullable<DateTime>)valueArray[row, column++];
                            if (refundDate != null)
                            {
                                refundBatch = refundBatches.SingleOrDefault(i => i.Case.CaseCode == caseCode && i.RefundDate == refundDate && i.RefundType == refundType);
                                if (refundBatch == null)
                                {
                                    refundBatch = new InvoiceRefundBatch();
                                    refundBatch.RefundType = refundType;
                                    refundBatch.RefundDate = refundDate.Value;
                                    refundBatch.CreateUserName = createUserName;
                                    refundBatch.CheckStatus = BATCH.CHECK;
                                    refundBatch.RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(refundBatch.RefundDate, refundBatches);
                                    refundBatch.Case = curCase;
                                    refundBatches.Add(refundBatch);
                                }
                            }

                            //还款信息
                            column = 20;
                            double? refundAmount = (System.Nullable<double>)valueArray[row, column++];
                            if (refundAmount.HasValue)
                            {
                                refundLog = new InvoiceRefundLog();
                                refundLog.RefundAmount = refundAmount.Value;
                                refundLog.InvoiceFinanceLog = financeLog;
                                if (refundBatch == null)
                                {
                                    throw new Exception("缺少还款批次信息: " + invoice.InvoiceNo);
                                }

                                refundLog.InvoiceRefundBatch = refundBatch;
                                invoice.CaculateRefund();
                                refundBatch.CaculateRefundAmount();
                            }

                            //手续费
                            column = 22;
                            double? Commission = (System.Nullable<double>)valueArray[row, column++];

                            if (Commission.HasValue)
                            {
                                if (activeCDA.CommissionType == "按融资金额" && financeLog != null)
                                {
                                    financeLog.Commission = Commission;
                                }
                                else
                                {
                                    invoice.Commission = Commission;
                                }
                            }

                            invoice.CaculateCommission(false);

                            column = 25;
                            invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        }
                        else if ("贷项通知".Equals(type))
                        {
                            paymentBatch = null;
                            string paymentType = "贷项通知";
                            DateTime? paymentDate = (System.Nullable<DateTime>)valueArray[row, 11];
                            if (paymentDate != null)
                            {
                                paymentBatch = paymentBatches.SingleOrDefault(i => i.Case.CaseCode == caseCode && i.PaymentDate == paymentDate && i.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch();
                                    paymentBatch.PaymentType = paymentType;
                                    paymentBatch.PaymentDate = paymentDate.Value;
                                    paymentBatch.CreateUserName = createUserName;
                                    paymentBatch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(paymentBatch.PaymentDate, paymentBatches);
                                    paymentBatch.CheckStatus = BATCH.CHECK;
                                    paymentBatch.Case = curCase;
                                    paymentBatches.Add(paymentBatch);
                                }
                            }

                            string creditNoteNo = String.Format("{0:G}", valueArray[row, 5]);
                            if (String.IsNullOrEmpty(creditNoteNo))
                            {
                                throw new Exception("贷项通知编号不能为空");
                            }

                            CreditNote creditNote = context.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                            if (creditNote == null)
                            {
                                creditNote = creditNoteList.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                                if (creditNote == null)
                                {
                                    creditNote = new CreditNote();
                                    creditNote.CreditNoteNo = creditNoteNo;
                                    creditNote.CreditNoteDate = (DateTime)valueArray[row, 9];
                                    creditNoteList.Add(creditNote);
                                }
                            }

                            paymentLog = new InvoicePaymentLog();
                            paymentLog.CreditNote = creditNote;
                            paymentLog.PaymentAmount = (double)valueArray[row, 8];
                            string invoiceNo = String.Format("{0:G}", valueArray[row, 6]);
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("贷项通知对应发票号不能为空");
                            }

                            invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                            if (invoice == null)
                            {
                                invoice = invoiceList.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                                if (invoice == null)
                                {
                                    throw new Exception("贷项通知对应发票号错误: " + invoiceNo);
                                }
                            }

                            paymentLog.Invoice = invoice;
                            if (paymentBatch == null)
                            {
                                throw new Exception("缺少贷项通知付款批次信息: " + invoice.InvoiceNo);
                            }

                            paymentLog.InvoicePaymentBatch = paymentBatch;
                            invoice.CaculatePayment();
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                }

                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (InvoiceAssignBatch batch in assignBatches)
                {
                    batch.Case = null;
                }

                foreach (InvoiceFinanceBatch batch in financeBatches)
                {
                    foreach (InvoiceFinanceLog log in batch.InvoiceFinanceLogs)
                    {
                        log.Invoice = null;
                    }

                    batch.Case = null;
                }

                foreach (InvoicePaymentBatch batch in paymentBatches)
                {
                    foreach (InvoicePaymentLog log in batch.InvoicePaymentLogs)
                    {
                        log.Invoice = null;
                        log.CreditNote = null;
                    }

                    batch.Case = null;
                }

                foreach (InvoiceRefundBatch batch in refundBatches)
                {
                    foreach (InvoiceRefundLog log in batch.InvoiceRefundLogs)
                    {
                        log.InvoiceFinanceLog = null;
                    }

                    batch.Case = null;
                }

                if (invoiceList.Count != result)
                {
                    if (invoice != null)
                    {
                        e1.Data["ID"] = invoice.InvoiceNo;
                    }
                    e1.Data["row"] = result + 1;
                    e1.Data["column"] = column - 1;
                }

                throw;
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportPayment(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            List<InvoicePaymentBatch> paymentBatchList = new List<InvoicePaymentBatch>();

            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                InvoiceAssignBatch assignBatch = null;
                InvoicePaymentBatch paymentBatch = null;
                Invoice invoice = null;

                try
                {
                    bool isInInvoice = false;

                    for (int row = 3; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string assignBatchCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();

                        if (String.IsNullOrEmpty(assignBatchCode))
                        {
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                break;
                            }
                            else
                            {
                                throw new Exception("业务编号不能为空，不能导入");
                            }
                        }
                        else
                        {
                            if (assignBatchCode.Length > 20)
                            {
                                break;
                            }

                            assignBatch = context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchCode);

                            if (assignBatch == null)
                            {
                                throw new Exception("业务编号错误，不能导入：" + assignBatchCode);
                            }

                            CDA cda = assignBatch.Case.ActiveCDA;
                            if (cda == null)
                            {
                                throw new Exception("没有有效的额度通知书: " + assignBatchCode);
                            }

                            if (assignBatch.Case.TransactionType == "出口保理" || assignBatch.Case.TransactionType == "进口保理")
                            {
                                isInInvoice = true;
                            }

                            if (isInInvoice && String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("本案为国际保理案，发票编号不能为空，不能导入，业务编号： " + assignBatchCode);
                            }
                        }

                        if (isInInvoice)
                        {
                            invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.AssignBatchNo == assignBatchCode);
                            if (invoice == null)
                            {
                                throw new Exception("发票号错误，不能导入，发票号：" + invoiceNo);
                            }
                        }

                        string paymentType = String.Format("{0:G}", valueArray[row, column++]);

                        string paymentCurrenty = String.Format("{0:G}", valueArray[row, column++]);
                        if (paymentCurrenty != assignBatch.BatchCurrency)
                        {
                            throw new Exception(String.Format("销帐币种{0}与案件币种{1}不相同，不能导入：{2}", paymentCurrenty, assignBatch.BatchCurrency, invoiceNo));
                        }

                        string paymentAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double paymentAmount = 0;
                        if (!String.IsNullOrEmpty(paymentAmountStr))
                        {
                            if (!Double.TryParse(paymentAmountStr, out paymentAmount))
                            {
                                if (isInInvoice)
                                {
                                    throw new Exception("冲销账款金额类型异常，不能导入：" + invoiceNo);
                                }
                                else
                                {
                                    throw new Exception("冲销账款金额类型异常，不能导入：" + assignBatchCode);
                                }
                            }
                        }

                        string paymentDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(paymentDateStr))
                        {
                            if (isInInvoice)
                            {
                                throw new Exception("销帐日不能为空，不能导入：" + invoiceNo);
                            }
                            else
                            {
                                throw new Exception("销帐日不能为空，不能导入：" + assignBatchCode);
                            }
                        }

                        DateTime paymentDate = default(DateTime);
                        if (!DateTime.TryParse(paymentDateStr, out paymentDate))
                        {
                            if (isInInvoice)
                            {
                                throw new Exception("销帐日类型异常，不能导入：" + invoiceNo);
                            }
                            else
                            {
                                throw new Exception("销帐日类型异常，不能导入：" + assignBatchCode);
                            }
                        }

                        string comment = String.Format("{0:G}", valueArray[row, column++]);


                        if (TypeUtil.GreaterZero(paymentAmount))
                        {
                            if (isInInvoice)
                            {
                                paymentBatch = paymentBatchList.SingleOrDefault(batch => batch.CaseCode == assignBatch.CaseCode && batch.PaymentDate == paymentDate && batch.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch();
                                    paymentBatch.Case = assignBatch.Case;
                                    paymentBatch.CheckStatus = BATCH.UNCHECK;
                                    paymentBatch.Comment = comment;
                                    paymentBatch.InputDate = DateTime.Now;
                                    paymentBatch.IsCreateMsg = false;
                                    paymentBatch.PaymentDate = paymentDate;
                                    paymentBatch.PaymentType = paymentType;
                                    paymentBatch.CreateUserName = App.Current.CurUser.Name;
                                    paymentBatch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(paymentDate, paymentBatchList);
                                    paymentBatchList.Add(paymentBatch);
                                }

                                if (TypeUtil.GreaterZero(paymentAmount - invoice.AssignOutstanding))
                                {
                                    throw new Exception("冲销账款金额不能大于转让余额，不能导入：" + invoiceNo);
                                }

                                InvoicePaymentLog log = new InvoicePaymentLog();
                                log.Invoice = invoice;
                                log.PaymentAmount = paymentAmount;
                                log.InvoicePaymentBatch = paymentBatch;
                                invoice.CaculatePayment();
                            }
                            else
                            {
                                paymentBatch = new InvoicePaymentBatch();
                                paymentBatch.Case = assignBatch.Case;
                                paymentBatch.CheckStatus = BATCH.UNCHECK;
                                paymentBatch.Comment = comment;
                                paymentBatch.InputDate = DateTime.Now;
                                paymentBatch.IsCreateMsg = false;
                                paymentBatch.PaymentDate = paymentDate;
                                paymentBatch.PaymentType = paymentType;
                                paymentBatch.CreateUserName = App.Current.CurUser.Name;
                                paymentBatch.PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(paymentDate, paymentBatchList);
                                paymentBatchList.Add(paymentBatch);

                                if (TypeUtil.GreaterZero(paymentAmount - assignBatch.AssignOutstanding))
                                {
                                    throw new Exception("冲销账款金额不能大于转让余额，不能导入：" + assignBatchCode);
                                }

                                foreach (Invoice inv in assignBatch.Invoices.OrderBy(i => i.DueDate))
                                {
                                    if (TypeUtil.GreaterZero(paymentAmount) && TypeUtil.GreaterZero(inv.AssignOutstanding))
                                    {
                                        InvoicePaymentLog log = new InvoicePaymentLog();
                                        log.PaymentAmount = Math.Min(paymentAmount, inv.AssignOutstanding);
                                        log.Invoice = inv;
                                        log.InvoicePaymentBatch = paymentBatch;
                                        inv.CaculatePayment();
                                        paymentAmount -= log.PaymentAmount.Value;
                                    }
                                }
                            }
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (InvoicePaymentBatch batch in paymentBatchList)
                    {
                        foreach (InvoicePaymentLog log in batch.InvoicePaymentLogs)
                        {
                            Invoice i = log.Invoice;
                            log.Invoice = null;
                            i.CaculatePayment();
                        }

                        batch.Case = null;
                    }

                    if (assignBatch != null)
                    {
                        e1.Data["ID"] = assignBatch.AssignBatchNo;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportPaymentByBatch(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<InvoicePaymentLog> logList = new List<InvoicePaymentLog>();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);

                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string assignBatchNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(invoiceNo))
                        {
                            continue;
                        }

                        Invoice invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.AssignBatchNo == assignBatchNo);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误: " + invoiceNo);
                        }

                        InvoicePaymentLog log = new InvoicePaymentLog(invoice);
                        column++;
                        log.PaymentAmount = (double?)valueArray[row, column++];
                        log.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        if (valueArray.GetUpperBound(1) > 4)
                        {
                            string creditNoteNo = String.Format("{0:G}", valueArray[row, column++]);
                            DateTime? creditNoteDate = (DateTime?)valueArray[row, column++];
                            if (creditNoteDate.HasValue)
                            {
                                CreditNote note = new CreditNote();
                                note.CreditNoteNo = creditNoteNo;
                                note.CreditNoteDate = creditNoteDate.Value;
                                log.CreditNote = note;
                            }
                        }

                        logList.Add(log);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                }
                catch (Exception e1)
                {
                    if (result != logList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    throw;
                }
            }

            this.ImportedList = logList;
            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportPoolFinance(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            List<InvoiceFinanceBatch> batchList = new List<InvoiceFinanceBatch>();

            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                Client client = null;

                try
                {
                    for (int row = 3; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string clientEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();

                        if (String.IsNullOrEmpty(clientEDICode) || clientEDICode.Length > 20)
                        {
                            break;
                        }

                        client = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户编号错误：" + clientEDICode);
                        }

                        InvoiceFinanceBatch financeBatch = new InvoiceFinanceBatch();

                        string financeType = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeType))
                        {
                            throw new Exception("出账方式不能为空，不能导入：" + clientEDICode);
                        }
                        else
                        {
                            financeBatch.FinanceType = financeType;
                        }

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("融资币别不能为空，不能导入：" + clientEDICode);
                        }
                        else
                        {
                            financeBatch.BatchCurrency = batchCurrency;
                        }

                        string financeAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeAmountStr))
                        {
                            throw new Exception("融资金额不能为空，不能导入：" + clientEDICode);
                        }
                        double financeAmount = 0;
                        if (Double.TryParse(financeAmountStr, out financeAmount))
                        {
                            financeBatch.FinanceAmount = financeAmount;
                        }
                        else
                        {
                            throw new Exception("融资金额类型异常，不能导入：" + clientEDICode);
                        }

                        string beginDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(beginDateStr))
                        {
                            throw new Exception("融资日不能为空，不能导入：" + clientEDICode);
                        }
                        DateTime beginDate = default(DateTime);
                        if (DateTime.TryParse(beginDateStr, out beginDate))
                        {
                            financeBatch.FinancePeriodBegin = beginDate;
                        }
                        else
                        {
                            throw new Exception("融资日类型异常，不能导入：" + clientEDICode);
                        }

                        string endDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(endDateStr))
                        {
                            throw new Exception("融资到期日不能为空，不能导入：" + clientEDICode);
                        }
                        DateTime endDate = default(DateTime);
                        if (DateTime.TryParse(endDateStr, out endDate))
                        {
                            financeBatch.FinancePeriodEnd = endDate;
                        }
                        else
                        {
                            throw new Exception("融资到期日类型异常，不能导入：" + clientEDICode);
                        }

                        string financeRateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeRateStr))
                        {
                            throw new Exception("融资利率不能为空，不能导入：" + clientEDICode);
                        }
                        double financeRate = 0;
                        if (Double.TryParse(financeRateStr, out financeRate))
                        {
                            financeBatch.FinanceRate = financeRate;
                        }
                        else
                        {
                            throw new Exception("融资利率类型异常，不能导入：" + clientEDICode);
                        }

                        string costRateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(costRateStr))
                        {
                            double costRate = 0;
                            if (Double.TryParse(costRateStr, out costRate))
                            {
                                financeBatch.CostRate = costRate;
                            }
                            else
                            {
                                throw new Exception("成本利率类型异常，不能导入：" + clientEDICode);
                            }
                        }

                        string factorCode = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(factorCode))
                        {
                            Factor factor = context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                throw new Exception("代付行编码错误：" + factorCode);
                            }

                            financeBatch.Factor = factor;
                        }

                        financeBatch.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        financeBatch.CheckStatus = BATCH.UNCHECK;
                        financeBatch.InputDate = DateTime.Today;
                        financeBatch.CreateUserName = App.Current.CurUser.Name;
                        financeBatch.FinanceBatchNo = InvoiceFinanceBatch.GenerateFinanceBatchNo(financeBatch.FinancePeriodBegin, batchList);
                        financeBatch.Client = client;

                        batchList.Add(financeBatch);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (InvoiceFinanceBatch batch in batchList)
                    {
                        batch.Client = null;
                    }

                    if (client != null)
                    {
                        e1.Data["ID"] = client.ClientEDICode;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportPoolRefund(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            List<InvoiceRefundBatch> refundBatchList = new List<InvoiceRefundBatch>();

            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                Client client = null;

                try
                {
                    for (int row = 3; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string clientEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();

                        if (String.IsNullOrEmpty(clientEDICode))
                        {
                            throw new Exception("客户编号不能为空，不能导入");
                        }
                        else
                        {
                            if (clientEDICode.Length > 20)
                            {
                                break;
                            }

                            client = context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);

                            if (client == null)
                            {
                                throw new Exception("客户编号错误，不能导入：" + clientEDICode);
                            }
                        }

                        string refundType = String.Format("{0:G}", valueArray[row, column++]);

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("还款币别不能为空，不能导入：" + clientEDICode);
                        }

                        string refundAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double refundAmount = 0;
                        if (!String.IsNullOrEmpty(refundAmountStr))
                        {
                            if (!Double.TryParse(refundAmountStr, out refundAmount))
                            {
                                throw new Exception("冲销融资金额类型异常，不能导入：" + clientEDICode);
                            }
                        }

                        string refundDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(refundDateStr))
                        {
                            throw new Exception("销帐日不能为空，不能导入：" + clientEDICode);
                        }

                        DateTime refundDate = default(DateTime);
                        if (!DateTime.TryParse(refundDateStr, out refundDate))
                        {
                            throw new Exception("销帐日类型异常，不能导入：" + clientEDICode);
                        }

                        string comment = String.Format("{0:G}", valueArray[row, column++]);

                        if (TypeUtil.GreaterZero(refundAmount))
                        {
                            foreach (InvoiceFinanceBatch financeBatch in client.InvoiceFinanceBatches.OrderBy(i => i.FinancePeriodEnd))
                            {
                                if (TypeUtil.GreaterZero(refundAmount) && TypeUtil.GreaterZero(financeBatch.PoolFinanceOutstanding))
                                {
                                    if (financeBatch.BatchCurrency != batchCurrency)
                                    {
                                        double rate = Exchange.GetExchangeRate(batchCurrency, financeBatch.BatchCurrency);
                                        refundAmount *= rate;
                                    }

                                    InvoiceRefundBatch refundBatch = new InvoiceRefundBatch();
                                    refundBatch.InvoiceFinanceBatch = financeBatch;
                                    refundBatch.RefundAmount = Math.Min(refundAmount, financeBatch.PoolFinanceOutstanding);
                                    refundAmount -= refundBatch.RefundAmount.GetValueOrDefault();
                                    refundBatch.CheckStatus = BATCH.UNCHECK;
                                    refundBatch.Comment = comment;
                                    refundBatch.InputDate = DateTime.Now;
                                    refundBatch.RefundDate = refundDate;
                                    refundBatch.RefundType = refundType;
                                    refundBatch.CreateUserName = App.Current.CurUser.Name;
                                    refundBatch.RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(refundDate, refundBatchList);
                                    refundBatchList.Add(refundBatch);
                                }
                            }
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (InvoiceRefundBatch batch in refundBatchList)
                    {
                        foreach (InvoiceRefundLog log in batch.InvoiceRefundLogs)
                        {
                            InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                            log.InvoiceFinanceLog = null;
                            financeLog.Invoice.CaculateRefund();
                        }

                        batch.Case = null;
                    }

                    if (client != null)
                    {
                        e1.Data["ID"] = client.ClientEDICode;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportRefund(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;

            List<InvoiceRefundBatch> refundBatchList = new List<InvoiceRefundBatch>();

            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                InvoiceAssignBatch assignBatch = null;
                InvoiceRefundBatch refundBatch = null;

                try
                {
                    for (int row = 3; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string assignBatchCode = String.Format("{0:G}", valueArray[row, column++]).Trim();

                        if (String.IsNullOrEmpty(assignBatchCode))
                        {
                            break;
                        }
                        else
                        {
                            if (assignBatchCode.Length > 20)
                            {
                                break;
                            }

                            assignBatch = context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchCode);

                            if (assignBatch == null)
                            {
                                throw new Exception("业务编号错误，不能导入：" + assignBatchCode);
                            }

                            CDA cda = assignBatch.Case.ActiveCDA;
                            if (cda == null)
                            {
                                throw new Exception("没有有效的额度通知书: " + assignBatchCode);
                            }

                        }

                        string refundType = String.Format("{0:G}", valueArray[row, column++]);

                        string refundCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(refundCurrency))
                        {
                            throw new Exception("冲销融资金额币别不能为空，不能导入：" + assignBatchCode);
                        }

                        string refundAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double refundAmount = 0;
                        if (!String.IsNullOrEmpty(refundAmountStr))
                        {
                            if (!Double.TryParse(refundAmountStr, out refundAmount))
                            {
                                throw new Exception("冲销融资金额类型异常，不能导入：" + assignBatchCode);
                            }
                        }

                        string refundDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(refundDateStr))
                        {
                            throw new Exception("销帐日不能为空，不能导入：" + assignBatchCode);
                        }

                        DateTime refundDate = default(DateTime);
                        if (!DateTime.TryParse(refundDateStr, out refundDate))
                        {
                            throw new Exception("销帐日类型异常，不能导入：" + assignBatchCode);
                        }

                        string comment = String.Format("{0:G}", valueArray[row, column++]);


                        if (TypeUtil.GreaterZero(refundAmount))
                        {
                            refundBatch = new InvoiceRefundBatch();
                            refundBatch.Case = assignBatch.Case;
                            refundBatch.CheckStatus = BATCH.UNCHECK;
                            refundBatch.Comment = comment;
                            refundBatch.InputDate = DateTime.Now;
                            refundBatch.RefundDate = refundDate;
                            refundBatch.RefundType = refundType;
                            refundBatch.CreateUserName = App.Current.CurUser.Name;
                            refundBatch.RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(refundDate, refundBatchList);
                            refundBatchList.Add(refundBatch);

                            if (refundCurrency != assignBatch.BatchCurrency)
                            {
                                double rate = Exchange.GetExchangeRate(refundCurrency, assignBatch.BatchCurrency);
                                if (TypeUtil.GreaterZero(refundAmount * rate - assignBatch.FinanceOutstanding))
                                {
                                    throw new Exception("冲销融资金额不能大于融资余额，不能导入：" + assignBatchCode);
                                }
                            }
                            else
                            {
                                if (TypeUtil.GreaterZero(refundAmount - assignBatch.FinanceOutstanding))
                                {
                                    throw new Exception("冲销融资金额不能大于融资余额，不能导入：" + assignBatchCode);
                                }
                            }

                            List<InvoiceFinanceLog> financeLogs = new List<InvoiceFinanceLog>();
                            foreach (Invoice inv in assignBatch.Invoices)
                            {
                                foreach (InvoiceFinanceLog financeLog in inv.InvoiceFinanceLogs)
                                {
                                    if (financeLog.InvoiceFinanceBatch.BatchCurrency == refundCurrency && TypeUtil.GreaterZero(financeLog.FinanceOutstanding))
                                    {
                                        financeLogs.Add(financeLog);
                                    }
                                }
                            }

                            foreach (InvoiceFinanceLog financeLog in financeLogs.OrderBy(f => f.FinanceDueDate))
                            {
                                if (TypeUtil.GreaterZero(refundAmount) && TypeUtil.GreaterZero(financeLog.FinanceOutstanding))
                                {
                                    InvoiceRefundLog log = new InvoiceRefundLog();
                                    log.RefundAmount = Math.Min(refundAmount, financeLog.FinanceOutstanding);
                                    log.InvoiceFinanceLog = financeLog;
                                    log.InvoiceRefundBatch = refundBatch;
                                    financeLog.Invoice.CaculateRefund();
                                    refundAmount -= log.RefundAmount.Value;
                                }
                            }

                            refundBatch.CaculateRefundAmount();
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }

                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (InvoiceRefundBatch batch in refundBatchList)
                    {
                        foreach (InvoiceRefundLog log in batch.InvoiceRefundLogs)
                        {
                            InvoiceFinanceLog financeLog = log.InvoiceFinanceLog;
                            log.InvoiceFinanceLog = null;
                            financeLog.Invoice.CaculateRefund();
                        }

                        batch.Case = null;
                    }

                    if (assignBatch != null)
                    {
                        e1.Data["ID"] = assignBatch.AssignBatchNo;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportRefundByBatch(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            List<InvoiceRefundLog> logList = new List<InvoiceRefundLog>();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);

                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }
                        //int column = 12;
                        int column = 1;
                        string assignBatchNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(invoiceNo))
                        {
                            continue;
                        }

                        Invoice invoice = context.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.AssignBatchNo == assignBatchNo);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误: " + invoiceNo);
                        }

                        int financeLogID = Convert.ToInt32(String.Format("{0:G}", valueArray[row, column++]));
                        InvoiceFinanceLog financeLog = context.InvoiceFinanceLogs.SingleOrDefault(i => i.FinanceLogID == financeLogID);
                        InvoiceRefundLog log = new InvoiceRefundLog(financeLog);
                        column++;
                        log.RefundAmount = (double)valueArray[row, column++];
                        log.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        logList.Add(log);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / (float)size));
                    }
                }
                catch (Exception e1)
                {
                    if (result != logList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    throw;
                }
            }

            this.ImportedList = logList;
            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportUser(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = this.GetValueArray(fileName, 1);
            int result = 0;
            this.context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                List<User> userList = new List<User>();

                try
                {
                    for (int row = 2; row <= size; row++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return -1;
                        }

                        string userId = String.Format("{0:G}", valueArray[row, 1]).Trim();
                        if (String.IsNullOrEmpty(userId))
                        {
                            continue;
                        }

                        bool isNew = false;
                        User user = context.Users.SingleOrDefault(c => c.UserID == userId);
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

                    context.Users.InsertAllOnSubmit(userList);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    if (result != userList.Count)
                    {
                        e1.Data["row"] = result;
                    }

                    throw;
                }
            }

            worker.ReportProgress(100);
            this.workbook.Close(false, fileName, null);
            this.ReleaseResource();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReleaseResource()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }

            if (this.datasheet != null)
            {
                Marshal.ReleaseComObject(this.datasheet);
                this.datasheet = null;
            }

            if (this.workbook != null)
            {
                Marshal.ReleaseComObject(this.workbook);
                this.workbook = null;
            }

            if (this.app != null)
            {
                foreach (Workbook wb in this.app.Workbooks)
                {
                    wb.Close(false, Type.Missing, Type.Missing);
                }

                this.app.Workbooks.Close();
                this.app.Quit();
                Marshal.ReleaseComObject(this.app);
                this.app = null;
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
            if (String.IsNullOrEmpty(filePath.Trim()))
            {
                return;
            }

            this.btnCancel.Text = "取消";
            this.backgroundWorker.RunWorkerAsync(filePath);

            this.btnStart.Enabled = false;
        }

        #endregion?Methods?
    }
}
