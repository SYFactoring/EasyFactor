//-----------------------------------------------------------------------
// <copyright file="ImportForm.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using DevComponents.DotNetBar;
using Microsoft.Office.Interop.Excel;

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportForm : Office2007Form
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ImportType _importType;
        /// <summary>
        /// 
        /// </summary>
        private ApplicationClass _app;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext _context;
        /// <summary>
        /// 
        /// </summary>
        private Worksheet _datasheet;
        /// <summary>
        /// 
        /// </summary>
        private Workbook _workbook;
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
            IMPORT_ASSIGN_II,

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
            IMPORT_POOL_REFUND,

            /// <summary>
            /// 
            /// </summary>
            SEND_LEGERS
        }
        /// <summary>
        /// Initializes a new instance of the ImportForm class.
        /// </summary>
        /// <param name="importType"></param>
        public ImportForm(ImportType importType)
        {
            InitializeComponent();
            _importType = importType;
            switch (importType)
            {
                case ImportType.IMPORT_USER:
                    Text = @"用户信息导入";
                    break;
                case ImportType.IMPORT_CLIENT:
                    Text = @"客户信息导入";
                    break;
                case ImportType.IMPORT_CLIENTS_OVERWRITE:
                    Text = @"客户信息导入(覆盖模式)";
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    Text = @"客户额度信息导入";
                    break;
                case ImportType.IMPORT_CLIENTS_REVIEW:
                    Text = @"客户协查意见导入";
                    break;
                case ImportType.IMPORT_FACTOR:
                    Text = @"合作机构信息导入";
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    Text = @"合作机构额度信息导入";
                    break;
                case ImportType.IMPORT_DEPARTMENT:
                    Text = @"部门信息导入";
                    break;
                case ImportType.IMPORT_RATE:
                    Text = @"汇率信息导入";
                    break;
                case ImportType.IMPORT_CASE:
                    Text = @"案件信息导入";
                    break;
                case ImportType.IMPORT_CREDIT_COVER_NEG:
                    Text = @"国际保理案关联额度导入";
                    break;
                case ImportType.IMPORT_CONTRACT:
                    Text = @"保理合同导入";
                    break;
                case ImportType.IMPORT_CDA:
                    Text = @"额度通知书导入";
                    break;
                case ImportType.IMPORT_ASSIGN_BY_BATCH:
                    Text = @"当前转让批次导入";
                    break;
                case ImportType.IMPORT_FINANCE_BY_BATCH:
                    Text = @"当前融资批次导入";
                    break;
                case ImportType.IMPORT_PAYMENT_BY_BATCH:
                    Text = @"当前付款批次导入";
                    break;
                case ImportType.IMPORT_REFUND_BY_BATCH:
                    Text = @"当前还款批次导入";
                    break;
                case ImportType.IMPORT_INVOICE:
                    Text = @"台帐导入";
                    break;
                case ImportType.IMPORT_ASSIGN:
                    Text = @"应收账款转让清单导入";
                    break;
                case ImportType.IMPORT_ASSIGN_II:
                    Text = @"应收账款转让清单导入";
                    break;
                case ImportType.IMPORT_FINANCE:
                    Text = @"放款明细表导入";
                    break;
                case ImportType.IMPORT_PAYMENT:
                    Text = @"冲销账款明细表导入";
                    break;
                case ImportType.IMPORT_REFUND:
                    Text = @"冲销融资明细表导入";
                    break;
                case ImportType.IMPORT_CREDIT_NOTE:
                    Text = @"贷项冲销账款明细表导入";
                    break;
                case ImportType.IMPORT_POOL_FINANCE:
                    Text = @"放款明细表（池融资）导入";
                    break;
                case ImportType.IMPORT_POOL_REFUND:
                    Text = @"冲销融资明细表（池融资）导入";
                    break;
                case ImportType.SEND_LEGERS:
                    Text = @"给分部/分行发送台帐";
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Gets or sets Imported List
        /// </summary>
        public IList ImportedList { get; set; }
        //?Private?Methods?(33)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            switch (_importType)
            {
                case ImportType.IMPORT_USER:
                    e.Result = ImportUser((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENT:
                    e.Result = ImportClient((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS_OVERWRITE:
                    e.Result = ImportClientsOverwrite((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    e.Result = ImportClientsCreditLine((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CLIENTS_REVIEW:
                    e.Result = ImportClientsReivew((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FACTOR:
                    e.Result = ImportFactor((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    e.Result = ImportFactorsCreditLine((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_DEPARTMENT:
                    e.Result = ImportDepartment((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_RATE:
                    e.Result = ImportExchangeRate((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CASE:
                    e.Result = ImportCase((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CREDIT_COVER_NEG:
                    e.Result = ImportCreditCoverNeg((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CONTRACT:
                    e.Result = ImportContract((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CDA:
                    e.Result = ImportCDA((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_ASSIGN_BY_BATCH:
                    e.Result = ImportAssignByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FINANCE_BY_BATCH:
                    e.Result = ImportFinanceByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_PAYMENT_BY_BATCH:
                    e.Result = ImportPaymentByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_REFUND_BY_BATCH:
                    e.Result = ImportRefundByBatch((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_INVOICE:
                    e.Result = ImportInvoice((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_ASSIGN:
                    e.Result = ImportAssign((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_ASSIGN_II:
                    e.Result = ImportAssignII((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_FINANCE:
                    e.Result = ImportFinance((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_PAYMENT:
                    e.Result = ImportPayment((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_REFUND:
                    e.Result = ImportRefund((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_CREDIT_NOTE:
                    e.Result = ImportCreditNote((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_POOL_FINANCE:
                    e.Result = ImportPoolFinance((string)e.Argument, worker, e);
                    break;
                case ImportType.IMPORT_POOL_REFUND:
                    e.Result = ImportPoolRefund((string)e.Argument, worker, e);
                    break;
                case ImportType.SEND_LEGERS:
                    e.Result = SendLegers((string)e.Argument, worker, e);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int SendLegers(string dirPath, BackgroundWorker worker, DoWorkEventArgs e)
        {
            var rootPath = new DirectoryInfo(dirPath);
            if (rootPath.Exists)
            {
                _context = new DBDataContext();

                DirectoryInfo[] subDirs = rootPath.GetDirectories();

                for (int i = 0; i < subDirs.Length; i++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return i;
                    }

                    DirectoryInfo dir = subDirs[i];
                    worker.ReportProgress((int)((float)i * 100 / subDirs.Length), dir.Name);
                    Location location = _context.Locations.SingleOrDefault(loc => loc.LocationName == dir.Name);
                    if (location == null)
                    {
                        throw new Exception(String.Format("部门名称：{0}，异常，不能发送", dir.Name));
                    }

                    if (String.IsNullOrEmpty(location.LegerContactEmail1))
                    {
                        throw new Exception(String.Format("台帐第一接收人不能为空，分部：{0}", dir.Name));
                    }

                    var mail = new SendMail(location.LegerContactEmail1, location.LegerContactEmail2,
                                            App.Current.CurUser.Email,
                                            String.Format("{0}保理台帐{1:yyyyMMdd}", dir.Name, DateTime.Today),
                                            "本邮件由中国民生银行保理运营系统自动生成。");
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        mail.AddAttachment(file.FullName);
                    }

                    mail.Send();
                }

                worker.ReportProgress(100);
                return subDirs.Length;
            }

            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            tbStatus.Text = _importType == ImportType.SEND_LEGERS ? String.Format("正在给{0}发送邮件", e.UserState) : String.Format("导入进度 {0:G}%", e.ProgressPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ReleaseResource();
            if (e.Error != null)
            {
                if (e.Error.Data.Contains("ID"))
                {
                    tbStatus.Text = String.Format("记录: {0} 发生异常: {1}", e.Error.Data["ID"], e.Error.Message);
                }
                else if (e.Error.Data.Contains("column"))
                {
                    tbStatus.Text = String.Format("第{0}条记录第{1}列，发生异常: {2}", e.Error.Data["row"], e.Error.Data["column"],
                                                  e.Error.Message);
                }
                else if (e.Error.Data.Contains("row"))
                {
                    tbStatus.Text = String.Format("第{0}条记录发生异常: {1}", e.Error.Data["row"], e.Error.Message);
                }
                else
                {
                    tbStatus.Text = String.Format("发生异常: {0}", e.Error.Message);
                }
            }
            else if (e.Cancelled)
            {
                tbStatus.Text = _importType == ImportType.SEND_LEGERS ? "发送被取消" : "导入被取消";
                progressBar.Value = 0;
            }
            else
            {
                tbStatus.Text = _importType == ImportType.SEND_LEGERS
                                    ? String.Format("发送邮件结束，共发送{0}封邮件", e.Result)
                                    : String.Format("导入结束, 共导入{0}条记录", e.Result);
            }

            btnStart.Enabled = true;
            btnCancel.Text = @"关闭";
            if (e.Error == null &&
                (_importType == ImportType.IMPORT_ASSIGN_BY_BATCH || _importType == ImportType.IMPORT_FINANCE_BY_BATCH ||
                 _importType == ImportType.IMPORT_PAYMENT_BY_BATCH || _importType == ImportType.IMPORT_REFUND_BY_BATCH))
            {
                Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelImport(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            else
            {
                Close();
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
            _app = new ApplicationClass { Visible = false };

            _workbook = _app.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            if (_workbook.Sheets.Count < sheetIndex)
            {
                return null;
            }

            _datasheet = (Worksheet)_workbook.Sheets[sheetIndex];
            Range range = _datasheet.UsedRange;
            return (object[,])range.Value[XlRangeValueDataType.xlRangeValueDefault];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        /// <returns></returns>
        private int ImportAssign(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            var invoiceList = new List<Invoice>();
            var batchList = new List<InvoiceAssignBatch>();

            _context = new DBDataContext();

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
                            throw new Exception("案件编号不能为空，不能导入：" + invoiceNo);
                        }
                        if (caseCode.Length > 20)
                        {
                            break;
                        }

                        if (String.IsNullOrEmpty(invoiceNo))
                        {
                            throw new Exception("发票编号不能为空，不能导入，案件编号： " + caseCode);
                        }

                        if (curCase == null || curCase.CaseCode != caseCode)
                        {
                            curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);

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
                                batch = new InvoiceAssignBatch
                                            {
                                                AssignDate = DateTime.Today,
                                                Case = curCase,
                                                CreateUserName = App.Current.CurUser.Name,
                                                InputDate = DateTime.Today
                                            };
                                batch.AssignBatchNo = InvoiceAssignBatch.GenerateAssignBatchNo(curCase.CaseCode,
                                                                                               batch.AssignDate,
                                                                                               batchList);
                                //batch.CheckStatus = BATCH.UNCHECK;
                                batch.IsCreateMsg = false;
                                batchList.Add(batch);
                            }
                        }

                        Invoice invoice =
                            _context.Invoices.SingleOrDefault(
                                i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                        if (invoice == null)
                        {
                            invoice = new Invoice { InvoiceNo = invoiceNo };
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
                        if (currency != curCase.InvoiceCurrency)
                        {
                            throw new Exception("发票币别与案件币别不匹配，不能导入：" + invoiceNo);
                        }

                        string invoiceAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(invoiceAmountStr))
                        {
                            throw new Exception("发票金额不能为空，不能导入：" + invoiceNo);
                        }
                        double invoiceAmount;
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
                        double assignAmount;
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
                            DateTime invoiceDate;
                            if (DateTime.TryParse(invoiceDateStr, out invoiceDate))
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
                        DateTime dueDate;
                        if (DateTime.TryParse(dueDateStr, out dueDate))
                        {
                            invoice.DueDate = dueDate;
                        }
                        else
                        {
                            throw new Exception("转让日类型异常，不能导入：" + invoiceNo);
                        }

                        string commissionStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (cda.CommissionType == "其他")
                        {
                            if (String.IsNullOrEmpty(commissionStr))
                            {
                                throw new Exception("手续费不能为空，不能导入：" + invoiceNo);
                            }
                            double commissionAmount;
                            if (Double.TryParse(commissionStr, out commissionAmount))
                            {
                                invoice.Commission = commissionAmount;
                            }
                            else
                            {
                                throw new Exception("手续费类型异常，不能导入：" + invoiceNo);
                            }
                        }
                        else if (cda.CommissionType == "按转让金额")
                        {
                            invoice.Commission = invoice.AssignAmount * cda.Price;
                        }

                        invoice.Comment = String.Format("{0:G}", valueArray[row, column]);
                        invoice.InvoiceAssignBatch = batch;

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ImportAssignII(string fileName, BackgroundWorker worker, DoWorkEventArgs e)
        {
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            var invoiceList = new List<Invoice>();
            var creditNoteList = new List<CreditNote>();
            var paymentLogList = new List<InvoicePaymentLog>();
            var assignBatchList = new List<InvoiceAssignBatch>();
            var paymentBatchList = new List<InvoicePaymentBatch>();

            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                Case curCase = null;
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
                        string caseCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string type = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        string invoiceNo = null;
                        string creditNoteNo = null;
                        if ("发票" == type)
                        {
                            invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                            if (String.IsNullOrEmpty(caseCode))
                            {
                                if (String.IsNullOrEmpty(invoiceNo))
                                {
                                    break;
                                }
                                throw new Exception("案件编号不能为空，不能导入：" + invoiceNo);
                            }
                            if (caseCode.Length > 20)
                            {
                                break;
                            }

                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("发票编号不能为空，不能导入，案件编号： " + caseCode);
                            }

                            column++;
                        }
                        else if ("贷项通知" == type)
                        {
                            creditNoteNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                            if (String.IsNullOrEmpty(caseCode))
                            {
                                if (String.IsNullOrEmpty(creditNoteNo))
                                {
                                    break;
                                }
                                throw new Exception("案件编号不能为空，不能导入：" + creditNoteNo);
                            }
                            if (caseCode.Length > 20)
                            {
                                break;
                            }

                            if (String.IsNullOrEmpty(creditNoteNo))
                            {
                                throw new Exception("贷项通知编号不能为空，不能导入，案件编号： " + caseCode);
                            }
                        }
                        else
                        {
                            continue;
                        }

                        if (curCase == null || curCase.CaseCode != caseCode)
                        {
                            curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);

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

                        if (assignBatch == null || assignBatch.CaseCode != caseCode)
                        {
                            assignBatch = assignBatchList.SingleOrDefault(b => b.CaseCode == caseCode);
                            if (assignBatch == null)
                            {
                                assignBatch = new InvoiceAssignBatch
                                                  {
                                                      AssignDate = DateTime.Today,
                                                      Case = curCase,
                                                      CreateUserName = App.Current.CurUser.Name,
                                                      InputDate = DateTime.Today
                                                  };
                                assignBatch.AssignBatchNo = InvoiceAssignBatch.GenerateAssignBatchNo(curCase.CaseCode,
                                                                                                     assignBatch.
                                                                                                         AssignDate,
                                                                                                     assignBatchList);
                                //assignBatch.CheckStatus = BATCH.UNCHECK;
                                assignBatch.IsCreateMsg = false;
                                assignBatchList.Add(assignBatch);
                            }
                        }

                        if ("发票" == type)
                        {
                            Invoice invoice =
                                _context.Invoices.SingleOrDefault(
                                    i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                            if (invoice == null)
                            {
                                invoice = new Invoice { InvoiceNo = invoiceNo };
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
                            if (currency != curCase.InvoiceCurrency)
                            {
                                throw new Exception("发票币别与案件币别不匹配，不能导入：" + invoiceNo);
                            }

                            string invoiceAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(invoiceAmountStr))
                            {
                                throw new Exception("发票金额不能为空，不能导入：" + invoiceNo);
                            }
                            double invoiceAmount;
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
                            double assignAmount;
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
                                DateTime invoiceDate;
                                if (DateTime.TryParse(invoiceDateStr, out invoiceDate))
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
                            DateTime dueDate;
                            if (DateTime.TryParse(dueDateStr, out dueDate))
                            {
                                invoice.DueDate = dueDate;
                            }
                            else
                            {
                                throw new Exception("转让日类型异常，不能导入：" + invoiceNo);
                            }

                            string commissionStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (cda.CommissionType == "其他")
                            {
                                if (String.IsNullOrEmpty(commissionStr))
                                {
                                    throw new Exception("手续费不能为空，不能导入：" + invoiceNo);
                                }
                                double commissionAmount;
                                if (Double.TryParse(commissionStr, out commissionAmount))
                                {
                                    invoice.Commission = commissionAmount;
                                }
                                else
                                {
                                    throw new Exception("手续费类型异常，不能导入：" + invoiceNo);
                                }
                            }
                            else if (cda.CommissionType == "按转让金额")
                            {
                                invoice.Commission = invoice.AssignAmount * cda.Price;
                            }

                            invoice.Comment = String.Format("{0:G}", valueArray[row, column]);
                            invoice.InvoiceAssignBatch = assignBatch;
                        }
                        else if ("贷项通知" == type)
                        {
                            CreditNote creditNote =
                                _context.CreditNotes.SingleOrDefault(i => i.CreditNoteNo == creditNoteNo);
                            if (creditNote == null)
                            {
                                creditNote = creditNoteList.SingleOrDefault(i => i.CreditNoteNo == creditNoteNo);
                                if (creditNote == null)
                                {
                                    creditNote = new CreditNote { CreditNoteNo = creditNoteNo };
                                    creditNoteList.Add(creditNote);
                                }
                            }
                            else
                            {
                                throw new Exception("贷项通知号已经存在，不能导入： " + creditNoteNo);
                            }

                            String toInvoiceNo = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(toInvoiceNo))
                            {
                                throw new Exception(String.Format("贷项通知{0}对应发票编号不能为空", creditNoteNo));
                            }

                            Invoice toInvoice =
                                _context.Invoices.SingleOrDefault(
                                    i => i.InvoiceNo == toInvoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                            if (toInvoice == null)
                            {
                                toInvoice = invoiceList.SingleOrDefault(i => i.InvoiceNo == toInvoiceNo);
                                if (toInvoice == null)
                                {
                                    throw new Exception(String.Format("贷项通知{0}对应发票编号{1}错误", creditNoteNo, toInvoiceNo));
                                }
                            }

                            string currency = string.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(currency))
                            {
                                throw new Exception("贷项通知币别不能为空，不能导入：" + creditNoteNo);
                            }
                            if (currency != toInvoice.InvoiceCurrency)
                            {
                                throw new Exception("贷项通知币别与发票币别不匹配，不能导入：" + creditNoteNo);
                            }

                            string paymentAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(paymentAmountStr))
                            {
                                throw new Exception("贷项通知金额不能为空，不能导入：" + creditNoteNo);
                            }

                            double paymentAmount;
                            if (!Double.TryParse(paymentAmountStr, out paymentAmount))
                            {
                                throw new Exception("贷项通知金额类型异常，不能导入：" + creditNoteNo);
                            }

                            column++;

                            string creditNoteDateStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(creditNoteDateStr))
                            {
                                throw new Exception("贷项通知日不能为空," + creditNoteNo);
                            }
                            DateTime creditNoteDate;
                            if (DateTime.TryParse(creditNoteDateStr, out creditNoteDate))
                            {
                                creditNote.CreditNoteDate = creditNoteDate;
                            }
                            else
                            {
                                throw new Exception("贷项通知日类型异常，不能导入：" + creditNoteNo);
                            }

                            column++;

                            column++;

                            string comment = String.Format("{0:G}", valueArray[row, column]);

                            InvoicePaymentBatch paymentBatch = paymentBatchList.SingleOrDefault(
                                batch =>
                                batch.CaseCode == caseCode && batch.PaymentType == PAYMENT.CREDIT_NOTE_PAYMENT);
                            if (paymentBatch == null)
                            {
                                paymentBatch = new InvoicePaymentBatch
                                                   {
                                                       Case = curCase,
                                                       InputDate = DateTime.Today,
                                                       IsCreateMsg = false,
                                                       PaymentDate = DateTime.Today,
                                                       PaymentType = PAYMENT.CREDIT_NOTE_PAYMENT,
                                                       CreateUserName = App.Current.CurUser.Name,
                                                       PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(
                                                           DateTime.Today, paymentBatchList)
                                                   };
                                //paymentBatch.CheckStatus = BATCH.UNCHECK;
                                paymentBatchList.Add(paymentBatch);
                            }

                            var paymentLog = new InvoicePaymentLog
                                                 {
                                                     CreditNote = creditNote,
                                                     Invoice = toInvoice,
                                                     PaymentAmount = paymentAmount,
                                                     Comment = comment,
                                                     InvoicePaymentBatch = paymentBatch
                                                 };
                            paymentLogList.Add(paymentLog);

                            creditNote.InvoiceAssignBatch = assignBatch;
                            toInvoice.CaculatePayment();
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    foreach (InvoiceAssignBatch b in assignBatchList)
                    {
                        b.Case = null;
                    }

                    foreach (Invoice i in invoiceList)
                    {
                        i.InvoiceAssignBatch = null;
                    }

                    foreach (InvoicePaymentBatch b in paymentBatchList)
                    {
                        b.Case = null;
                    }

                    foreach (InvoicePaymentLog log in paymentLogList)
                    {
                        log.Invoice = null;
                    }

                    foreach (CreditNote c in creditNoteList)
                    {
                        c.InvoiceAssignBatch = null;
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();
            var invoiceList = new List<Invoice>();

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

                        Invoice invoice =
                            _context.Invoices.SingleOrDefault(
                                i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                        if (invoice == null)
                        {
                            invoice = new Invoice { InvoiceNo = invoiceNo };
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
                        invoice.Commission = (double?)valueArray[row, column++];
                        invoice.Comment = String.Format("{0:G}", valueArray[row, column]);

                        invoiceList.Add(invoice);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
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

            ImportedList = invoiceList;
            worker.ReportProgress(100);
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                var caseList = new List<Case>();
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
                        Department ownerDept =
                            _context.Departments.SingleOrDefault(d => d.DepartmentName == ownerDeptName);
                        if (ownerDept == null)
                        {
                            throw new Exception("所属分部名称错误： " + ownerDeptName);
                        }


                        var appDate = (DateTime)valueArray[row, 19];
                        if (String.IsNullOrEmpty(caseCode) && !String.IsNullOrEmpty(transactionType))
                        {
                            caseCode = Case.GenerateCaseCode(transactionType, ownerDept.LocationCode, appDate, caseList);
                        }

                        Case curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase != null)
                        {
                            throw new Exception("案件已存在，不能导入： " + caseCode);
                        }

                        curCase = caseList.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase != null)
                        {
                            throw new Exception("案件编号重复，不能导入： " + caseCode);
                        }

                        curCase = new Case { CaseCode = caseCode };
                        caseList.Add(curCase);

                        int column = 2;
                        curCase.OPName = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.OwnerDepartment = ownerDept;
                        column++;
                        curCase.TransactionType = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.OperationType = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.CaseMark = String.Format("{0:G}", valueArray[row, column++]);
                        string sellerEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Client sellerClient = _context.Clients.SingleOrDefault(c => c.ClientEDICode == sellerEDICode);
                        if (sellerClient == null)
                        {
                            throw new Exception("卖方保理代码错误： " + sellerEDICode);
                        }

                        curCase.SellerClient = sellerClient;
                        column++;
                        column++;
                        string buyerEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Client buyerClient = _context.Clients.SingleOrDefault(c => c.ClientEDICode == buyerEDICode);
                        if (buyerClient == null)
                        {
                            throw new Exception("买方保理代码错误： " + buyerEDICode);
                        }

                        curCase.BuyerClient = buyerClient;
                        column++;
                        column++;
                        string efCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Factor sellerFactor = _context.Factors.SingleOrDefault(f => f.FactorCode == efCode);
                        if (sellerFactor == null)
                        {
                            throw new Exception("卖方保理商代码错误： " + efCode);
                        }

                        curCase.SellerFactor = sellerFactor;
                        string ifCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Factor buyerFactor = _context.Factors.SingleOrDefault(f => f.FactorCode == ifCode);
                        if (buyerFactor == null)
                        {
                            throw new Exception("买方保理商代码错误： " + ifCode);
                        }

                        curCase.BuyerFactor = buyerFactor;
                        column++;
                        curCase.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        var netPaymentTerm = (double?)valueArray[row, column++];
                        if (netPaymentTerm.HasValue)
                        {
                            curCase.NetPaymentTerm = Convert.ToInt32(netPaymentTerm.Value.ToString());
                        }
                        curCase.CaseAppDate = (DateTime)valueArray[row, column++];
                        curCase.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        curCase.Comment = String.Format("{0:G}", valueArray[row, column]);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

            var cdaList = new List<CDA>();

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

                        curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase == null)
                        {
                            throw new Exception("案件编号错误: " + caseCode);
                        }

                        if (curCase.TransactionType != "进口保理" && curCase.SellerClient.Contract == null)
                        {
                            throw new Exception("缺少主合同：" + caseCode);
                        }

                        column++;
                        string cdaCode = CDA.GenerateCDACode(curCase, cdaList);

                        CDA cda = _context.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                        if (cda != null)
                        {
                            throw new Exception("CDA已存在，不能导入： " + cdaCode);
                        }

                        cda = cdaList.SingleOrDefault(c => c.CDACode == cdaCode);
                        if (cda != null)
                        {
                            throw new Exception("CDA编号重复，不能导入： " + cdaCode);
                        }

                        cda = new CDA { CDACode = cdaCode, CDAStatus = CDAStr.CHECKED };
                        cdaList.Add(cda);
                        cda.Case = curCase;

                        column++; //卖方
                        column++; //买方
                        column++; //保理商
                        column++; //业务类别
                        column++; //发票币别
                        cda.IsRecoarse = "Y".Equals(valueArray[row, column++]);
                        cda.IsNotice = String.Format("{0:G}", valueArray[row, column++]);
                        cda.AssignType = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CreditCoverCurr = String.Format("{0:G}", valueArray[row, column++]);
                        cda.CreditCover = (double?)valueArray[row, column++];
                        cda.CreditCoverPeriodBegin = (DateTime?)valueArray[row, column++];
                        cda.CreditCoverPeriodEnd = (DateTime?)valueArray[row, column++];
                        cda.PUGProportion = (double?)valueArray[row, column++];
                        var pugPeriod = (double?)valueArray[row, column++];
                        if (pugPeriod.HasValue)
                        {
                            cda.PUGPeriod = Convert.ToInt32(pugPeriod.Value);
                        }
                        var reassignPeriod = (double?)valueArray[row, column++];
                        if (reassignPeriod.HasValue)
                        {
                            cda.ReassignGracePeriod = Convert.ToInt32(reassignPeriod.Value);
                        }
                        cda.FinanceLineCurr = String.Format("{0:G}", valueArray[row, column++]);
                        cda.FinanceLine = (double?)valueArray[row, column++];
                        cda.FinanceLinePeriodBegin = (DateTime?)valueArray[row, column++];
                        cda.FinanceLinePeriodEnd = (DateTime?)valueArray[row, column++];
                        cda.HighestFinanceLine = (double?)valueArray[row, column++];
                        cda.FinanceProportion = (double?)valueArray[row, column++];
                        var financePeriod = (double?)valueArray[row, column++];
                        if (financePeriod.HasValue)
                        {
                            cda.FinanceGracePeriod = Convert.ToInt32(financePeriod.Value);
                        }
                        cda.PaymentTerms = String.Format("{0:G}", valueArray[row, column++]);
                        cda.OrderNumber = String.Format("{0:G}", valueArray[row, column++]);
                        cda.Deductibles = (double?)valueArray[row, column++];
                        cda.LossThreshold = (double?)valueArray[row, column++];
                        cda.Price = (double?)valueArray[row, column++];
                        cda.IFPrice = (double?)valueArray[row, column++];
                        cda.EFPrice = (double?)valueArray[row, column++];
                        cda.HandFeeCurr = String.Format("{0:G}", valueArray[row, column++]);
                        cda.HandFee = (double?)valueArray[row, column++];
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
                        cda.Comment = String.Format("{0:G}", valueArray[row, column]);

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
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            var clientList = new List<Client>();
            _context = new DBDataContext();

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

                        Client client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client != null)
                        {
                            throw new Exception("客户已经存在，不能导入： " + clientEDICode);
                        }

                        client = clientList.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client != null)
                        {
                            throw new Exception("客户编号重复，不能导入： " + clientEDICode);
                        }

                        client = new Client { ClientEDICode = clientEDICode };
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
                            Client clientGroup = _context.Clients.SingleOrDefault(c => c.ClientEDICode == groupNo);
                            if (clientGroup == null)
                            {
                                throw new Exception("集团客户号错误： " + groupNo);
                            }
                        }

                        column++;
                        client.RegistrationNumber = String.Format("{0:G}", valueArray[row, column++]);
                        client.CompanyCode = String.Format("{0:G}", valueArray[row, column++]);
                        string departmentName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Department =
                            _context.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));

                        client.PMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.RMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        client.CreateUserName = String.Format("{0:G}", valueArray[row, column]);
                        if (String.IsNullOrEmpty(client.CreateUserName))
                        {
                            client.CreateUserName = App.Current.CurUser.Name;
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }
                }

                _context.Clients.InsertAllOnSubmit(clientList);
                _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                var creditLineList = new List<ClientCreditLine>();
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

                        Client client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户保理代码错误: " + clientEDICode);
                        }

                        int column = 3;
                        var creditLine = new ClientCreditLine
                                             {
                                                 CreditLineType = String.Format("{0:G}", valueArray[row, column++]),
                                                 CreditLineCurrency = String.Format("{0:G}", valueArray[row, column++]),
                                                 CreditLine = (double)valueArray[row, column++],
                                                 PeriodBegin = (DateTime)valueArray[row, column++],
                                                 PeriodEnd = (DateTime)valueArray[row, column++],
                                                 ApproveNo = String.Format("{0:G}", valueArray[row, column++]),
                                                 ApproveType = String.Format("{0:G}", valueArray[row, column++]),
                                                 CreditLineStatus = String.Format("{0:G}", valueArray[row, column++]),
                                                 FreezeReason = String.Format("{0:G}", valueArray[row, column++]),
                                                 Freezer = String.Format("{0:G}", valueArray[row, column++]),
                                                 FreezeDate = (DateTime?)valueArray[row, column++],
                                                 UnfreezeReason = String.Format("{0:G}", valueArray[row, column++]),
                                                 Unfreezer = String.Format("{0:G}", valueArray[row, column++]),
                                                 Comment = String.Format("{0:G}", valueArray[row, column++]),
                                                 CreateUserName = String.Format("{0:G}", valueArray[row, column]),
                                                 Client = client
                                             };
                        creditLineList.Add(creditLine);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            var clientList = new List<Client>();
            _context = new DBDataContext();

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

                        Client client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
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
                            Client clientGroup = _context.Clients.SingleOrDefault(c => c.ClientEDICode == groupNo);
                            if (clientGroup == null)
                            {
                                throw new Exception("集团客户号错误： " + groupNo);
                            }
                        }

                        column++;
                        client.RegistrationNumber = String.Format("{0:G}", valueArray[row, column++]);
                        client.CompanyCode = String.Format("{0:G}", valueArray[row, column++]);
                        string departmentName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Department =
                            _context.Departments.SingleOrDefault(d => d.DepartmentName.Equals(departmentName));

                        client.PMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.RMName = String.Format("{0:G}", valueArray[row, column++]);
                        client.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        client.CreateUserName = String.Format("{0:G}", valueArray[row, column]);
                        if (String.IsNullOrEmpty(client.CreateUserName))
                        {
                            client.CreateUserName = App.Current.CurUser.Name;
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }
                }

                _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            var reviewList = new List<ClientReview>();
            _context = new DBDataContext();

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

                        Client client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
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

                        ClientReview review = _context.ClientReviews.SingleOrDefault(c => c.ReviewNo == reviewNo);
                        if (review != null)
                        {
                            throw new Exception("协查意见已存在，不能导入： " + reviewNo);
                        }

                        review = reviewList.SingleOrDefault(c => c.ReviewNo == reviewNo);
                        if (review != null)
                        {
                            throw new Exception("协查意见编号重复，不能导入： " + reviewNo);
                        }

                        review = new ClientReview
                                     {
                                         ReviewNo = reviewNo,
                                         RequestCurrency = String.Format("{0:G}", valueArray[row, column++]),
                                         RequestAmount = (double?)valueArray[row, column++],
                                         RequestFinanceType = String.Format("{0:G}", valueArray[row, column++]),
                                         RequestFinanceType2 = String.Format("{0:G}", valueArray[row, column++])
                                     };
                        var requestPeriod = (double?)valueArray[row, column++];
                        if (requestPeriod.HasValue)
                        {
                            review.RequestFinancePeriod = Convert.ToInt32(requestPeriod.Value);
                        }
                        review.RequestCommissionRate = (double?)valueArray[row, column++];
                        review.ReviewStatus = String.Format("{0:G}", valueArray[row, column++]);
                        review.ReviewDate = (DateTime)valueArray[row, column++];
                        review.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        review.Comment = String.Format("{0:G}", valueArray[row, column]);
                        review.Client = client;
                        reviewList.Add(review);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                var contractList = new List<Contract>();
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

                        Client client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户编号错误: " + clientEDICode);
                        }

                        string contractCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(contractCode))
                        {
                            throw new Exception("保理合同号不能为空");
                        }

                        Contract contract = _context.Contracts.SingleOrDefault(c => c.ContractCode == contractCode);
                        if (contract != null)
                        {
                            throw new Exception("保理合同已存在，不能导入: " + contractCode);
                        }

                        contract = contractList.SingleOrDefault(c => c.ContractCode == contractCode);
                        if (contract != null)
                        {
                            throw new Exception("保理合同重复，不能导入: " + contractCode);
                        }

                        contract = new Contract { ContractCode = contractCode, Client = client };
                        contractList.Add(contract);
                        contract.ContractType = String.Format("{0:G}", valueArray[row, column++]);
                        contract.ContractValueDate = (DateTime)valueArray[row, column++];
                        contract.ContractDueDate = (DateTime)valueArray[row, column++];
                        contract.ContractStatus = String.Format("{0:G}", valueArray[row, column++]);
                        contract.CreateUserName = String.Format("{0:G}", valueArray[row, column]);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                var creditCoverList = new List<CreditCoverNegotiation>();
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

                        Case curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase == null)
                        {
                            throw new Exception("案件不存在，不能导入关联额度： " + caseCode);
                        }

                        int column = 5;
                        var creditCover = new CreditCoverNegotiation
                                              {
                                                  RequestType = String.Format("{0:G}", valueArray[row, column++]),
                                                  RequestAmount = (double)valueArray[row, column++]
                                              };
                        var netPaymentTerm = (double?)valueArray[row, column++];
                        if (netPaymentTerm.HasValue)
                        {
                            creditCover.NetPaymentTerm = Convert.ToInt32(netPaymentTerm.Value.ToString());
                        }
                        creditCover.RequestDate = (DateTime)valueArray[row, column++];
                        creditCover.ReplyAmount = (double?)valueArray[row, column++];
                        creditCover.ReplyDate = (DateTime?)valueArray[row, column++];
                        creditCover.IFPrice = (double?)valueArray[row, column++];
                        creditCover.PriceDate = (DateTime?)valueArray[row, column++];
                        creditCover.DueDate = (DateTime?)valueArray[row, column++];
                        creditCover.CreateUserName = String.Format("{0:G}", valueArray[row, column++]);
                        creditCover.Comment = String.Format("{0:G}", valueArray[row, column]);

                        creditCover.Case = curCase;
                        creditCoverList.Add(creditCover);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;

            var paymentBatchList = new List<InvoicePaymentBatch>();
            var creditNoteList = new List<CreditNote>();

            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                InvoiceAssignBatch assignBatch = null;
                InvoicePaymentBatch paymentBatch = null;
                Invoice invoice;
                CreditNote creditNote;

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
                            throw new Exception("业务编号不能为空，不能导入");
                        }
                        if (assignBatchCode.Length > 20)
                        {
                            break;
                        }

                        if (assignBatch == null || assignBatch.AssignBatchNo != assignBatchCode)
                        {
                            assignBatch =
                                _context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchCode);

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

                        invoice =
                            _context.Invoices.SingleOrDefault(
                                i => i.InvoiceNo == invoiceNo && i.AssignBatchNo == assignBatchCode);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误，不能导入，发票号：" + invoiceNo);
                        }

                        creditNote = _context.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                        if (creditNote == null)
                        {
                            creditNote = creditNoteList.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                            if (creditNote == null)
                            {
                                creditNote = new CreditNote { CreditNoteNo = creditNoteNo };
                                creditNoteList.Add(creditNote);
                            }
                        }
                        else
                        {
                            throw new Exception("贷项通知号已存在，不能导入：" + creditNoteNo);
                        }

                        var log = new InvoicePaymentLog { CreditNote = creditNote };
                        creditNote.InvoiceAssignBatch = log.Invoice.InvoiceAssignBatch;

                        string creditNoteAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double creditNoteAmount;
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

                        string creditNoteDateStr = String.Format("{0:G}", valueArray[row, column]);
                        if (String.IsNullOrEmpty(creditNoteDateStr))
                        {
                            throw new Exception("贷项通知日不能为空，不能导入：" + creditNoteNo);
                        }

                        DateTime creditNoteDate;
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
                            paymentBatch = new InvoicePaymentBatch
                                               {
                                                   Case = assignBatch.Case,
                                                   Comment = comment,
                                                   InputDate = DateTime.Now,
                                                   IsCreateMsg = false,
                                                   PaymentDate = DateTime.Now,
                                                   PaymentType = "贷项通知",
                                                   CreateUserName = App.Current.CurUser.Name,
                                                   PaymentBatchNo =
                                                       InvoicePaymentBatch.GeneratePaymentBatchNo(DateTime.Now,
                                                                                                  paymentBatchList)
                                               };
                            //paymentBatch.CheckStatus = BATCH.UNCHECK;
                        }

                        if (TypeUtil.GreaterZero(creditNoteAmount - invoice.AssignOutstanding))
                        {
                            throw new Exception("贷项通知金额不能大于转让余额，不能导入：" + creditNoteNo);
                        }

                        log.Invoice = invoice;
                        log.InvoicePaymentBatch = paymentBatch;
                        invoice.CaculatePayment();

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

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
                        Department dept = _context.Departments.SingleOrDefault(d => d.DepartmentCode == departmentCode);
                        if (dept == null)
                        {
                            isNew = true;
                            dept = new Department { DepartmentCode = departmentCode };
                        }

                        int column = 2;
                        dept.DepartmentName = String.Format("{0:G}", valueArray[row, column++]);
                        string locationName = String.Format("{0:G}", valueArray[row, column++]);
                        dept.Location = _context.Locations.SingleOrDefault(l => l.LocationName == locationName);
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
                        dept.Fax_2 = String.Format("{0:G}", valueArray[row, column]);

                        if (isNew)
                        {
                            _context.Departments.InsertOnSubmit(dept);
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
                }

                catch (Exception e1)
                {
                    e1.Data["row"] = result;
                    throw;
                }
            }

            worker.ReportProgress(100);
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

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
                        Exchange exchange =
                            _context.Exchanges.SingleOrDefault(ex => ex.FromCurr == from && ex.ToCurr == to);
                        if (exchange == null)
                        {
                            exchange = new Exchange();
                            _context.Exchanges.InsertOnSubmit(exchange);
                        }
                        exchange.ExchangeRate = (double)valueArray[row, 3];
                        exchange.LastModifiedDate = DateTime.Now;

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
                }
            }
            catch (Exception e1)
            {
                e1.Data["row"] = result;
                throw;
            }

            worker.ReportProgress(100);
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;

            _context = new DBDataContext();

            var factorList = new List<Factor>();

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
                        factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                        if (factor == null)
                        {
                            isNew = true;
                            factor = new Factor { FactorCode = factorCode, FactorType = "保理商" };
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
                        factor.DateOfLatestRevision = String.Format("{0:G}", valueArray[row, column]);
                        factor.CreateUserName = App.Current.CurUser.Name;

                        string monitorResult = factor.EndMonitor();
                        if (!String.IsNullOrEmpty(monitorResult))
                        {
                            DialogResult dr = MessageBoxEx.Show(monitorResult, "是否更新", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Information);
                            if (dr == DialogResult.Yes)
                            {
                                factor.LastModifiedDate = DateTime.Now;
                            }
                            else
                            {
                                var contextNew = new DBDataContext();
                                factor = contextNew.Factors.SingleOrDefault(f => f.FactorCode == factor.FactorCode);
                            }
                        }

                        if (isNew)
                        {
                            factorList.Add(factor);
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.Factors.InsertAllOnSubmit(factorList);
                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                var creditLineList = new List<FactorCreditLine>();
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

                        Factor factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                        if (factor == null)
                        {
                            throw new Exception("合作机构代码错误: " + factorCode);
                        }

                        int column = 2;
                        var creditLine = new FactorCreditLine
                                             {
                                                 CreditLineCurrency = String.Format("{0:G}", valueArray[row, column++]),
                                                 CreditLine = (double)valueArray[row, column++],
                                                 PeriodBegin = (DateTime)valueArray[row, column++],
                                                 PeriodEnd = (DateTime)valueArray[row, column++],
                                                 ApproveNo = String.Format("{0:G}", valueArray[row, column++]),
                                                 ApproveType = String.Format("{0:G}", valueArray[row, column++]),
                                                 CreditLineStatus = String.Format("{0:G}", valueArray[row, column++]),
                                                 FreezeReason = String.Format("{0:G}", valueArray[row, column++]),
                                                 Freezer = String.Format("{0:G}", valueArray[row, column++]),
                                                 FreezeDate = (DateTime?)valueArray[row, column++],
                                                 UnfreezeReason = String.Format("{0:G}", valueArray[row, column++]),
                                                 Unfreezer = String.Format("{0:G}", valueArray[row, column++]),
                                                 Comment = String.Format("{0:G}", valueArray[row, column]),
                                                 Factor = factor
                                             };
                        creditLineList.Add(creditLine);
                        result++;
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;

            var financeBatchList = new List<InvoiceFinanceBatch>();
            var paymentBatchList = new List<InvoicePaymentBatch>();

            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetLength(0);

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

                        assignBatch =
                            _context.InvoiceAssignBatches.SingleOrDefault(c => c.AssignBatchNo == assignBatchCode);
                        if (assignBatch == null)
                        {
                            throw new Exception("业务编号错误：" + assignBatchCode);
                        }

                        //if (assignBatch.CheckStatus != BATCH.CHECK)
                        //{
                        //    throw new Exception("该业务未复核（或复核未通过）：" + assignBatchCode);
                        //}

                        var financeBatch = new InvoiceFinanceBatch();

                        string financeType = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeType))
                        {
                            throw new Exception("出账方式不能为空，不能导入：" + assignBatchCode);
                        }
                        financeBatch.FinanceType = financeType;

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("融资币别不能为空，不能导入：" + assignBatchCode);
                        }
                        financeBatch.BatchCurrency = batchCurrency;

                        string financeAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeAmountStr))
                        {
                            throw new Exception("融资金额不能为空，不能导入：" + assignBatchCode);
                        }
                        double financeAmount;
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
                        DateTime beginDate;
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
                        DateTime endDate;
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
                        double financeRate;
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
                            double costRate;
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
                            Factor factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                throw new Exception("代付行编码错误：" + factorCode);
                            }

                            financeBatch.Factor = factor;
                        }

                        financeBatch.Comment = String.Format("{0:G}", valueArray[row, column]);

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

                        if (activeCDA.FinanceCreditLine == null)
                        {
                            throw new Exception("该案件额度通知书融资额度为空，不能融资：" + assignBatchCode);
                        }

                        if (activeCDA.FinanceCreditLine.PeriodEnd < DateTime.Today)
                        {
                            throw new Exception(String.Format("融资额度已到期{0:d}，不能融资：{1}",
                                                              activeCDA.FinanceCreditLine.PeriodEnd, assignBatchCode));
                        }
                        if (TypeUtil.LessZero(activeCDA.FinanceLineOutstanding - financeAmount + guaranteeDeposit))
                        {
                            throw new Exception(String.Format("该案件的预付款融资额度余额为{0:N2}，欲融资{1:N2}，额度不足，不能融资：{2}",
                                                              (activeCDA.FinanceLineOutstanding + guaranteeDeposit),
                                                              financeAmount, assignBatchCode));
                        }

                        if (
                            TypeUtil.LessZero(activeCDA.HighestFinanceLine - assignBatch.Case.TotalFinanceOutstanding -
                                              financeAmount + guaranteeDeposit))
                        {
                            throw new Exception(String.Format("该案件的最高预付款融资额度余额为{0:N2}，欲融资{1:N2}，额度不足，不能融资：{2}",
                                                              (activeCDA.HighestFinanceLine -
                                                               assignBatch.Case.TotalFinanceOutstanding +
                                                               guaranteeDeposit), financeAmount, assignBatchCode));
                        }

                        //financeBatch.CheckStatus = BATCH.UNCHECK;
                        financeBatch.InputDate = DateTime.Today;
                        financeBatch.CreateUserName = App.Current.CurUser.Name;
                        financeBatch.FinanceBatchNo =
                            InvoiceFinanceBatch.GenerateFinanceBatchNo(financeBatch.FinancePeriodBegin, financeBatchList);
                        financeBatch.Case = assignBatch.Case;

                        financeBatchList.Add(financeBatch);


                        double currentFinanceAmount = 0;
                        IEnumerable<Invoice> invoices;
                        if (assignBatch.Case.TransactionType == "国内买方保理")
                        {
                            invoices =
                                assignBatch.Invoices.Where(
                                    i => (i.IsDispute.HasValue == false || i.IsDispute == false) && i.IsFlaw == false).
                                    OrderBy(i => i.DueDate);
                        }
                        else
                        {
                            invoices =
                                assignBatch.Invoices.Where(
                                    i =>
                                    (i.IsDispute.HasValue == false || i.IsDispute == false) && i.IsFlaw == false &&
                                    i.DueDate > financeBatch.FinancePeriodBegin).OrderBy(i => i.DueDate);
                        }

                        foreach (Invoice invoice in invoices)
                        {
                            double canBeFinanceAmount = invoice.AssignOutstanding *
                                                        activeCDA.FinanceProportion.GetValueOrDefault() -
                                                        invoice.FinanceAmount.GetValueOrDefault();
                            if (TypeUtil.GreaterZero(canBeFinanceAmount))
                            {
                                if (invoice.InvoiceCurrency != financeBatch.BatchCurrency)
                                {
                                    double rate = Exchange.GetExchangeRate(invoice.InvoiceCurrency,
                                                                           financeBatch.BatchCurrency);
                                    canBeFinanceAmount *= rate;
                                }

                                double logFinanceAmount;
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
                                    var log = new InvoiceFinanceLog
                                                  {
                                                      Invoice = invoice,
                                                      InvoiceFinanceBatch = financeBatch,
                                                      FinanceAmount = logFinanceAmount
                                                  };
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
                            throw new Exception(String.Format("本次申请融资金额{0:N2}，大于实际融资金额{1:N2}，业务编号：{2}",
                                                              financeBatch.FinanceAmount, currentFinanceAmount,
                                                              assignBatchCode));
                        }

                        if (assignBatch.Case.TransactionType == "国内买方保理")
                        {
                            if (financeBatch.BatchCurrency != assignBatch.Case.InvoiceCurrency)
                            {
                                throw new Exception(String.Format("国内买方保理，融资币别{0}需要与发票币别{1}相同，业务编号：{2}",
                                                                  financeBatch.BatchCurrency,
                                                                  assignBatch.Case.InvoiceCurrency, assignBatchCode));
                            }

                            var paymentBatch = new InvoicePaymentBatch
                                                   {
                                                       PaymentType = PAYMENT.BUYER_PAYMENT,
                                                       PaymentDate = financeBatch.FinancePeriodBegin,
                                                       CreateUserName = App.Current.CurUser.Name
                                                   };
                            //paymentBatch.CheckStatus = BATCH.UNCHECK;
                            paymentBatch.PaymentBatchNo =
                                InvoicePaymentBatch.GeneratePaymentBatchNo(paymentBatch.PaymentDate, paymentBatchList);
                            paymentBatch.Case = financeBatch.Case;
                            paymentBatch.InputDate = DateTime.Today;
                            paymentBatchList.Add(paymentBatch);

                            foreach (InvoiceFinanceLog financeLog in financeBatch.InvoiceFinanceLogs)
                            {
                                var paymentLog = new InvoicePaymentLog
                                                     {
                                                         InvoicePaymentBatch = paymentBatch,
                                                         PaymentAmount = financeLog.FinanceAmount,
                                                         Invoice = financeLog.Invoice
                                                     };
                                paymentLog.Invoice.CaculatePayment();
                            }
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();
            var logList = new List<InvoiceFinanceLog>();

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

                        Invoice invoice =
                            _context.Invoices.SingleOrDefault(
                                i => i.InvoiceNo == invoiceNo && i.AssignBatchNo == assignBatchNo);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误: " + invoiceNo);
                        }

                        column++;
                        var log = new InvoiceFinanceLog(invoice)
                                      {
                                          FinanceAmount = (double?)valueArray[row, column++],
                                          Commission = (double?)valueArray[row, column++],
                                          Comment = String.Format("{0:G}", valueArray[row, column])
                                      };

                        logList.Add(log);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
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

            ImportedList = logList;
            worker.ReportProgress(100);
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            _context = new DBDataContext();

            int result = 0;
            int column = 0;
            Case curCase = null;
            Invoice invoice = null;
            InvoiceFinanceLog financeLog = null;
            InvoicePaymentLog paymentLog;
            InvoiceRefundLog refundLog;

            InvoiceAssignBatch assignBatch;
            InvoiceFinanceBatch financeBatch = null;
            InvoicePaymentBatch paymentBatch = null;
            InvoiceRefundBatch refundBatch = null;

            var assignBatches = new List<InvoiceAssignBatch>();
            var financeBatches = new List<InvoiceFinanceBatch>();
            var paymentBatches = new List<InvoicePaymentBatch>();
            var refundBatches = new List<InvoiceRefundBatch>();
            var invoiceList = new List<Invoice>();
            var creditNoteList = new List<CreditNote>();

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
                            curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
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

                            invoice =
                                _context.Invoices.SingleOrDefault(
                                    i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                            if (invoice == null)
                            {
                                invoice = new Invoice { InvoiceNo = invoiceNo };
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
                            invoice.InvoiceDate = (DateTime?)valueArray[row, column++];
                            invoice.DueDate = (DateTime)valueArray[row, column++];
                            var assignDate = (DateTime)valueArray[row, column++];
                            invoice.IsFlaw = TypeUtil.ConvertStrToBool(valueArray[row, column++]);

                            //转让批次信息
                            assignBatch =
                                assignBatches.SingleOrDefault(
                                    i => i.Case.CaseCode == caseCode && i.AssignDate == assignDate);
                            if (assignBatch == null)
                            {
                                assignBatch = new InvoiceAssignBatch
                                                  {
                                                      AssignDate = assignDate,
                                                      CreateUserName = createUserName
                                                  };
                                //assignBatch.CheckStatus = BATCH.CHECK;
                                assignBatch.AssignBatchNo = InvoiceAssignBatch.GenerateAssignBatchNo(caseCode,
                                                                                                     assignBatch.
                                                                                                         AssignDate,
                                                                                                     assignBatches);
                                assignBatch.Case = curCase;
                                assignBatches.Add(assignBatch);
                            }

                            invoice.InvoiceAssignBatch = assignBatch;

                            //融资批次信息
                            column = 13;
                            string financeType = String.Format("{0:G}", valueArray[row, column++]);
                            column = 16;
                            var financeDate = (DateTime?)valueArray[row, column++];
                            var financeDueDate = (DateTime?)valueArray[row, column++];

                            if (financeDate != null && financeDueDate != null)
                            {
                                financeBatch =
                                    financeBatches.SingleOrDefault(
                                        i =>
                                        i.Case.CaseCode == caseCode && i.FinanceType == financeType &&
                                        i.FinancePeriodBegin.Date == financeDate &&
                                        i.FinancePeriodEnd.Date == financeDueDate);
                                if (financeBatch == null)
                                {
                                    financeBatch = new InvoiceFinanceBatch { FinanceType = financeType };
                                    column = 14;
                                    financeBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                                    column = 25;
                                    financeBatch.FinanceRate = (double)valueArray[row, column++];
                                    financeBatch.FinancePeriodBegin = financeDate.Value;
                                    financeBatch.FinancePeriodEnd = financeDueDate.Value;
                                    financeBatch.CreateUserName = createUserName;
                                    //financeBatch.CheckStatus = BATCH.CHECK;
                                    financeBatch.FinanceBatchNo =
                                        InvoiceFinanceBatch.GenerateFinanceBatchNo(financeBatch.FinancePeriodBegin,
                                                                                   financeBatches);
                                    financeBatch.Case = curCase;
                                    financeBatches.Add(financeBatch);
                                }
                            }

                            //融资信息
                            column = 15;
                            var financeAmount = (double?)valueArray[row, column++];
                            if (financeAmount.HasValue)
                            {
                                if (financeBatch == null)
                                {
                                    throw new Exception("缺少融资批次信息: " + invoice.InvoiceNo);
                                }

                                financeLog = new InvoiceFinanceLog
                                                 {
                                                     Invoice = invoice,
                                                     FinanceAmount = financeAmount.Value,
                                                     InvoiceFinanceBatch = financeBatch
                                                 };
                                invoice.CaculateFinance();
                                financeBatch.CaculateFinanceAmount();
                            }

                            //付款批次信息
                            column = 18;
                            const string paymentType = PAYMENT.BUYER_PAYMENT;
                            column = 19;
                            var paymentDate = (DateTime?)valueArray[row, column++];
                            if (paymentDate != null)
                            {
                                paymentBatch =
                                    paymentBatches.SingleOrDefault(
                                        i =>
                                        i.Case.CaseCode == caseCode && i.PaymentDate == paymentDate &&
                                        i.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch
                                                       {
                                                           PaymentType = paymentType,
                                                           PaymentDate = paymentDate.Value,
                                                           CreateUserName = createUserName
                                                       };
                                    //paymentBatch.CheckStatus = BATCH.CHECK;
                                    paymentBatch.PaymentBatchNo =
                                        InvoicePaymentBatch.GeneratePaymentBatchNo(paymentBatch.PaymentDate,
                                                                                   paymentBatches);
                                    paymentBatch.Case = curCase;
                                    paymentBatches.Add(paymentBatch);
                                }
                            }

                            //付款信息
                            column = 18;
                            var paymentAmount = (double?)valueArray[row, column++];
                            if (paymentAmount.HasValue)
                            {
                                paymentLog = new InvoicePaymentLog
                                                 {
                                                     PaymentAmount = paymentAmount.Value,
                                                     Invoice = invoice
                                                 };
                                if (paymentBatch == null)
                                {
                                    throw new Exception("缺少付款批次信息: " + invoice.InvoiceNo);
                                }

                                paymentLog.InvoicePaymentBatch = paymentBatch;
                                invoice.CaculatePayment();
                            }

                            //还款批次信息
                            column = 21;
                            const string refundType = REFUND.BUYER_PAYMENT;

                            var refundDate = (DateTime?)valueArray[row, column++];
                            if (refundDate != null)
                            {
                                refundBatch =
                                    refundBatches.SingleOrDefault(
                                        i =>
                                        i.Case.CaseCode == caseCode && i.RefundDate == refundDate &&
                                        i.RefundType == refundType);
                                if (refundBatch == null)
                                {
                                    refundBatch = new InvoiceRefundBatch
                                                      {
                                                          RefundType = refundType,
                                                          RefundDate = refundDate.Value,
                                                          CreateUserName = createUserName
                                                      };
                                    //refundBatch.CheckStatus = BATCH.CHECK;
                                    refundBatch.RefundBatchNo =
                                        InvoiceRefundBatch.GenerateRefundBatchNo(refundBatch.RefundDate, refundBatches);
                                    refundBatch.Case = curCase;
                                    refundBatches.Add(refundBatch);
                                }
                            }

                            //还款信息
                            column = 20;
                            var refundAmount = (double?)valueArray[row, column++];
                            if (refundAmount.HasValue)
                            {
                                refundLog = new InvoiceRefundLog
                                                {
                                                    RefundAmount = refundAmount.Value,
                                                    InvoiceFinanceLog = financeLog
                                                };
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
                            var commission = (double?)valueArray[row, column++];

                            if (commission.HasValue)
                            {
                                if (activeCDA.CommissionType == "按融资金额" && financeLog != null)
                                {
                                    financeLog.Commission = commission;
                                }
                                else
                                {
                                    invoice.Commission = commission;
                                }
                            }

                            invoice.CaculateCommission(false);

                            column = 25;
                            invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);
                        }
                        else if ("贷项通知".Equals(type))
                        {
                            paymentBatch = null;
                            const string paymentType = "贷项通知";
                            var paymentDate = (DateTime?)valueArray[row, 11];
                            if (paymentDate != null)
                            {
                                paymentBatch =
                                    paymentBatches.SingleOrDefault(
                                        i =>
                                        i.Case.CaseCode == caseCode && i.PaymentDate == paymentDate &&
                                        i.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch
                                                       {
                                                           PaymentType = paymentType,
                                                           PaymentDate = paymentDate.Value,
                                                           CreateUserName = createUserName
                                                       };
                                    paymentBatch.PaymentBatchNo =
                                        InvoicePaymentBatch.GeneratePaymentBatchNo(paymentBatch.PaymentDate,
                                                                                   paymentBatches);
                                    //paymentBatch.CheckStatus = BATCH.CHECK;
                                    paymentBatch.Case = curCase;
                                    paymentBatches.Add(paymentBatch);
                                }
                            }

                            string creditNoteNo = String.Format("{0:G}", valueArray[row, 5]);
                            if (String.IsNullOrEmpty(creditNoteNo))
                            {
                                throw new Exception("贷项通知编号不能为空");
                            }

                            CreditNote creditNote =
                                _context.CreditNotes.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                            if (creditNote == null)
                            {
                                creditNote = creditNoteList.SingleOrDefault(c => c.CreditNoteNo == creditNoteNo);
                                if (creditNote == null)
                                {
                                    creditNote = new CreditNote
                                                     {
                                                         CreditNoteNo = creditNoteNo,
                                                         CreditNoteDate = (DateTime) valueArray[row, 9]
                                                     };
                                    creditNoteList.Add(creditNote);
                                }
                            }

                            paymentLog = new InvoicePaymentLog
                                             {
                                                 CreditNote = creditNote,
                                                 PaymentAmount = (double) valueArray[row, 8]
                                             };
                            string invoiceNo = String.Format("{0:G}", valueArray[row, 6]);
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("贷项通知对应发票号不能为空");
                            }

                            invoice =
                                _context.Invoices.SingleOrDefault(
                                    i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
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
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }
                }

                _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;

            var paymentBatchList = new List<InvoicePaymentBatch>();

            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetLength(0);
                InvoiceAssignBatch assignBatch = null;
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
                            throw new Exception("业务编号不能为空，不能导入");
                        }
                        if (assignBatchCode.Length > 20)
                        {
                            break;
                        }

                        assignBatch =
                            _context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchCode);

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
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("本案为国际保理案，发票编号不能为空，不能导入，业务编号： " + assignBatchCode);
                            }
                        }

                        if (!String.IsNullOrEmpty(invoiceNo))
                        {
                            isInInvoice = true;
                            invoice =
                                _context.Invoices.SingleOrDefault(
                                    i => i.InvoiceNo == invoiceNo && i.AssignBatchNo == assignBatchCode);
                            if (invoice == null)
                            {
                                throw new Exception("发票号错误，不能导入，发票号：" + invoiceNo);
                            }
                        }

                        string paymentType = String.Format("{0:G}", valueArray[row, column++]);

                        string paymentCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (paymentCurrency != assignBatch.BatchCurrency)
                        {
                            throw new Exception(String.Format("销帐币种{0}与案件币种{1}不相同，不能导入：{2}", paymentCurrency,
                                                              assignBatch.BatchCurrency, invoiceNo));
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
                                throw new Exception("冲销账款金额类型异常，不能导入：" + assignBatchCode);
                            }
                        }

                        string paymentDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(paymentDateStr))
                        {
                            if (isInInvoice)
                            {
                                throw new Exception("销帐日不能为空，不能导入：" + invoiceNo);
                            }
                            throw new Exception("销帐日不能为空，不能导入：" + assignBatchCode);
                        }

                        DateTime paymentDate;
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

                        string comment = String.Format("{0:G}", valueArray[row, column]);

                        if (TypeUtil.GreaterZero(paymentAmount))
                        {
                            InvoicePaymentBatch paymentBatch;
                            if (isInInvoice)
                            {
                                paymentBatch =
                                    paymentBatchList.SingleOrDefault(
                                        batch =>
                                        batch.CaseCode == assignBatch.CaseCode && batch.PaymentDate == paymentDate &&
                                        batch.PaymentType == paymentType);
                                if (paymentBatch == null)
                                {
                                    paymentBatch = new InvoicePaymentBatch
                                                       {
                                                           Case = assignBatch.Case,
                                                           Comment = comment,
                                                           InputDate = DateTime.Now,
                                                           IsCreateMsg = false,
                                                           PaymentDate = paymentDate,
                                                           PaymentType = paymentType,
                                                           CreateUserName = App.Current.CurUser.Name,
                                                           PaymentBatchNo = InvoicePaymentBatch.GeneratePaymentBatchNo(
                                                               paymentDate, paymentBatchList)
                                                       };
                                    //paymentBatch.CheckStatus = BATCH.UNCHECK;
                                    paymentBatchList.Add(paymentBatch);
                                }

                                if (TypeUtil.GreaterZero(paymentAmount - invoice.AssignOutstanding))
                                {
                                    throw new Exception("冲销账款金额不能大于转让余额，不能导入：" + invoiceNo);
                                }

                                new InvoicePaymentLog
                                    {
                                        Invoice = invoice,
                                        PaymentAmount = paymentAmount,
                                        InvoicePaymentBatch = paymentBatch
                                    };
                                invoice.CaculatePayment();
                            }
                            else
                            {
                                paymentBatch = new InvoicePaymentBatch
                                                   {
                                                       Case = assignBatch.Case,
                                                       Comment = comment,
                                                       InputDate = DateTime.Now,
                                                       IsCreateMsg = false,
                                                       PaymentDate = paymentDate,
                                                       PaymentType = paymentType,
                                                       CreateUserName = App.Current.CurUser.Name,
                                                       PaymentBatchNo =
                                                           InvoicePaymentBatch.GeneratePaymentBatchNo(paymentDate,
                                                                                                      paymentBatchList)
                                                   };
                                //paymentBatch.CheckStatus = BATCH.UNCHECK;
                                paymentBatchList.Add(paymentBatch);

                                if (TypeUtil.GreaterZero(paymentAmount - assignBatch.AssignOutstanding))
                                {
                                    throw new Exception("冲销账款金额不能大于转让余额，不能导入：" + assignBatchCode);
                                }

                                foreach (Invoice inv in assignBatch.Invoices.OrderBy(i => i.DueDate))
                                {
                                    if (TypeUtil.GreaterZero(paymentAmount) &&
                                        TypeUtil.GreaterZero(inv.AssignOutstanding))
                                    {
                                        var log = new InvoicePaymentLog
                                                      {
                                                          PaymentAmount = Math.Min(paymentAmount, inv.AssignOutstanding),
                                                          Invoice = inv,
                                                          InvoicePaymentBatch = paymentBatch
                                                      };
                                        inv.CaculatePayment();
                                        if (log.PaymentAmount != null) paymentAmount -= log.PaymentAmount.Value;
                                    }
                                }
                            }
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();
            var logList = new List<InvoicePaymentLog>();

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

                        Invoice invoice =
                            _context.Invoices.SingleOrDefault(
                                i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.AssignBatchNo == assignBatchNo);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误: " + invoiceNo);
                        }

                        var log = new InvoicePaymentLog(invoice);
                        column++;
                        log.PaymentAmount = (double?)valueArray[row, column++];
                        log.Comment = String.Format("{0:G}", valueArray[row, column++]);

                        if (valueArray.GetUpperBound(1) > 4)
                        {
                            string creditNoteNo = String.Format("{0:G}", valueArray[row, column++]);
                            var creditNoteDate = (DateTime?)valueArray[row, column];
                            if (creditNoteDate.HasValue)
                            {
                                var note = new CreditNote
                                               {
                                                   CreditNoteNo = creditNoteNo,
                                                   CreditNoteDate = creditNoteDate.Value
                                               };
                                log.CreditNote = note;
                            }
                        }

                        logList.Add(log);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
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

            ImportedList = logList;
            worker.ReportProgress(100);
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;

            var batchList = new List<InvoiceFinanceBatch>();

            _context = new DBDataContext();

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

                        client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client == null)
                        {
                            throw new Exception("客户编号错误：" + clientEDICode);
                        }

                        var financeBatch = new InvoiceFinanceBatch();

                        string financeType = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeType))
                        {
                            throw new Exception("出账方式不能为空，不能导入：" + clientEDICode);
                        }
                        financeBatch.FinanceType = financeType;

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("融资币别不能为空，不能导入：" + clientEDICode);
                        }
                        financeBatch.BatchCurrency = batchCurrency;

                        string financeAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeAmountStr))
                        {
                            throw new Exception("融资金额不能为空，不能导入：" + clientEDICode);
                        }
                        double financeAmount;
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
                        DateTime beginDate;
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
                        DateTime endDate;
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
                        double financeRate;
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
                            double costRate;
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
                            Factor factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                throw new Exception("代付行编码错误：" + factorCode);
                            }

                            financeBatch.Factor = factor;
                        }

                        financeBatch.Comment = String.Format("{0:G}", valueArray[row, column]);
                        //financeBatch.CheckStatus = BATCH.UNCHECK;
                        financeBatch.InputDate = DateTime.Today;
                        financeBatch.CreateUserName = App.Current.CurUser.Name;
                        financeBatch.FinanceBatchNo =
                            InvoiceFinanceBatch.GenerateFinanceBatchNo(financeBatch.FinancePeriodBegin, batchList);
                        financeBatch.Client = client;

                        batchList.Add(financeBatch);

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;

            var refundBatchList = new List<InvoiceRefundBatch>();

            _context = new DBDataContext();

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
                            continue;
                        }
                        if (clientEDICode.Length > 20)
                        {
                            break;
                        }

                        client = _context.Clients.SingleOrDefault(c => c.ClientEDICode == clientEDICode);

                        if (client == null)
                        {
                            throw new Exception("客户编号错误，不能导入：" + clientEDICode);
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

                        DateTime refundDate;
                        if (!DateTime.TryParse(refundDateStr, out refundDate))
                        {
                            throw new Exception("销帐日类型异常，不能导入：" + clientEDICode);
                        }

                        string comment = String.Format("{0:G}", valueArray[row, column]);

                        if (TypeUtil.GreaterZero(refundAmount))
                        {
                            foreach (
                                InvoiceFinanceBatch financeBatch in
                                    client.InvoiceFinanceBatches.OrderBy(i => i.FinancePeriodEnd))
                            {
                                if (TypeUtil.GreaterZero(refundAmount) &&
                                    TypeUtil.GreaterZero(financeBatch.PoolFinanceOutstanding))
                                {
                                    if (financeBatch.BatchCurrency != batchCurrency)
                                    {
                                        double rate = Exchange.GetExchangeRate(batchCurrency, financeBatch.BatchCurrency);
                                        refundAmount *= rate;
                                    }

                                    var refundBatch = new InvoiceRefundBatch
                                                          {
                                                              InvoiceFinanceBatch = financeBatch,
                                                              RefundAmount = Math.Min(refundAmount,
                                                                                      financeBatch.
                                                                                          PoolFinanceOutstanding)
                                                          };
                                    refundAmount -= refundBatch.RefundAmount.GetValueOrDefault();
                                    //refundBatch.CheckStatus = BATCH.UNCHECK;
                                    refundBatch.Comment = comment;
                                    refundBatch.InputDate = DateTime.Now;
                                    refundBatch.RefundDate = refundDate;
                                    refundBatch.RefundType = refundType;
                                    refundBatch.CreateUserName = App.Current.CurUser.Name;
                                    refundBatch.RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(refundDate,
                                                                                                         refundBatchList);
                                    refundBatchList.Add(refundBatch);
                                }
                            }
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;

            var refundBatchList = new List<InvoiceRefundBatch>();

            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                InvoiceAssignBatch assignBatch = null;
                InvoiceRefundBatch refundBatch;

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
                        if (assignBatchCode.Length > 20)
                        {
                            break;
                        }

                        assignBatch =
                            _context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchCode);

                        if (assignBatch == null)
                        {
                            throw new Exception("业务编号错误，不能导入：" + assignBatchCode);
                        }

                        CDA cda = assignBatch.Case.ActiveCDA;
                        if (cda == null)
                        {
                            throw new Exception("没有有效的额度通知书: " + assignBatchCode);
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

                        DateTime refundDate;
                        if (!DateTime.TryParse(refundDateStr, out refundDate))
                        {
                            throw new Exception("销帐日类型异常，不能导入：" + assignBatchCode);
                        }

                        string comment = String.Format("{0:G}", valueArray[row, column]);


                        if (TypeUtil.GreaterZero(refundAmount))
                        {
                            refundBatch = new InvoiceRefundBatch
                                              {
                                                  Case = assignBatch.Case,
                                                  Comment = comment,
                                                  InputDate = DateTime.Now,
                                                  RefundDate = refundDate,
                                                  RefundType = refundType,
                                                  CreateUserName = App.Current.CurUser.Name,
                                                  RefundBatchNo = InvoiceRefundBatch.GenerateRefundBatchNo(refundDate,
                                                                                                           refundBatchList)
                                              };
                            //refundBatch.CheckStatus = BATCH.UNCHECK;
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

                            var financeLogs = (from inv in assignBatch.Invoices
                                               from financeLog in inv.InvoiceFinanceLogs
                                               where financeLog.InvoiceFinanceBatch.BatchCurrency == refundCurrency && TypeUtil.GreaterZero(financeLog.FinanceOutstanding)
                                               select financeLog).ToList();

                            foreach (InvoiceFinanceLog financeLog in financeLogs.OrderBy(f => f.FinanceDueDate))
                            {
                                if (TypeUtil.GreaterZero(refundAmount) &&
                                    TypeUtil.GreaterZero(financeLog.FinanceOutstanding))
                                {
                                    var log = new InvoiceRefundLog
                                                  {
                                                      RefundAmount =
                                                          Math.Min(refundAmount, financeLog.FinanceOutstanding),
                                                      InvoiceFinanceLog = financeLog,
                                                      InvoiceRefundBatch = refundBatch
                                                  };
                                    financeLog.Invoice.CaculateRefund();
                                    if (log.RefundAmount != null) refundAmount -= log.RefundAmount.Value;
                                }
                            }

                            refundBatch.CaculateRefundAmount();
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();
            var logList = new List<InvoiceRefundLog>();

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

                        Invoice invoice =
                            _context.Invoices.SingleOrDefault(
                                i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.AssignBatchNo == assignBatchNo);
                        if (invoice == null)
                        {
                            throw new Exception("发票号错误: " + invoiceNo);
                        }

                        int financeLogId = Convert.ToInt32(String.Format("{0:G}", valueArray[row, column++]));
                        InvoiceFinanceLog financeLog =
                            _context.InvoiceFinanceLogs.SingleOrDefault(i => i.FinanceLogID == financeLogId);
                        var log = new InvoiceRefundLog(financeLog);
                        column++;
                        log.RefundAmount = (double)valueArray[row, column++];
                        log.Comment = String.Format("{0:G}", valueArray[row, column]);

                        logList.Add(log);
                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
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

            ImportedList = logList;
            worker.ReportProgress(100);
            _workbook.Close(false, fileName, null);
            ReleaseResource();
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
            object[,] valueArray = GetValueArray(fileName, 1);
            int result = 0;
            _context = new DBDataContext();

            if (valueArray != null)
            {
                int size = valueArray.GetUpperBound(0);
                var userList = new List<User>();

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
                        User user = _context.Users.SingleOrDefault(c => c.UserID == userId);
                        if (user == null)
                        {
                            isNew = true;
                            user = new User { UserID = userId };
                        }

                        int column = 2;
                        user.EDIAccount = String.Format("{0:G}", valueArray[row, column++]);
                        user.Password = String.Format("{0:G}", valueArray[row, column++]);
                        user.Role = String.Format("{0:G}", valueArray[row, column++]);
                        user.Name = String.Format("{0:G}", valueArray[row, column++]);
                        user.Phone = String.Format("{0:G}", valueArray[row, column++]);
                        user.Telphone = String.Format("{0:G}", valueArray[row, column++]);
                        user.Email = String.Format("{0:G}", valueArray[row, column++]);
                        user.MSN = String.Format("{0:G}", valueArray[row, column]);

                        if (isNew)
                        {
                            userList.Add(user);
                        }

                        result++;
                        worker.ReportProgress((int)((float)row * 100 / size));
                    }

                    _context.Users.InsertAllOnSubmit(userList);
                    _context.SubmitChanges();
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
            _workbook.Close(false, fileName, null);
            ReleaseResource();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        private void ReleaseResource()
        {
            if (_context != null)
            {
                _context.Dispose();
            }

            if (_datasheet != null)
            {
                Marshal.ReleaseComObject(_datasheet);
                _datasheet = null;
            }

            if (_workbook != null)
            {
                Marshal.ReleaseComObject(_workbook);
                _workbook = null;
            }

            if (_app != null)
            {
                foreach (Workbook wb in _app.Workbooks)
                {
                    wb.Close(false, Type.Missing, Type.Missing);
                }

                _app.Workbooks.Close();
                _app.Quit();
                Marshal.ReleaseComObject(_app);
                _app = null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFile(object sender, EventArgs e)
        {
            if (_importType == ImportType.SEND_LEGERS)
            {
                var dirDialog = new FolderBrowserDialog();
                if (dirDialog.ShowDialog() == DialogResult.OK)
                {
                    tbFilePath.Text = dirDialog.SelectedPath;
                }
            }
            else
            {
                var fileDialog = new OpenFileDialog
                                     {
                                         Filter = @"Excel files (*.xls;*.xlsx)|*.xls;*.xlsx"
                                     };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbFilePath.Text = fileDialog.FileName;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartImport(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text;
            if (String.IsNullOrEmpty(filePath.Trim()))
            {
                tbStatus.Text = _importType == ImportType.SEND_LEGERS ? "请先选择台帐所在根目录" : "请先选择导入文件路径";
                return;
            }

            btnCancel.Text = @"取消";
            backgroundWorker.RunWorkerAsync(filePath);

            btnStart.Enabled = false;
        }
    }
}