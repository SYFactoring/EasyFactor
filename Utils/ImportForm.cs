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
                    Text = @"�û���Ϣ����";
                    break;
                case ImportType.IMPORT_CLIENT:
                    Text = @"�ͻ���Ϣ����";
                    break;
                case ImportType.IMPORT_CLIENTS_OVERWRITE:
                    Text = @"�ͻ���Ϣ����(����ģʽ)";
                    break;
                case ImportType.IMPORT_CLIENTS_CREDITLINE:
                    Text = @"�ͻ������Ϣ����";
                    break;
                case ImportType.IMPORT_CLIENTS_REVIEW:
                    Text = @"�ͻ�Э���������";
                    break;
                case ImportType.IMPORT_FACTOR:
                    Text = @"����������Ϣ����";
                    break;
                case ImportType.IMPORT_FACTORS_CREDITLINE:
                    Text = @"�������������Ϣ����";
                    break;
                case ImportType.IMPORT_DEPARTMENT:
                    Text = @"������Ϣ����";
                    break;
                case ImportType.IMPORT_RATE:
                    Text = @"������Ϣ����";
                    break;
                case ImportType.IMPORT_CASE:
                    Text = @"������Ϣ����";
                    break;
                case ImportType.IMPORT_CREDIT_COVER_NEG:
                    Text = @"���ʱ���������ȵ���";
                    break;
                case ImportType.IMPORT_CONTRACT:
                    Text = @"�����ͬ����";
                    break;
                case ImportType.IMPORT_CDA:
                    Text = @"���֪ͨ�鵼��";
                    break;
                case ImportType.IMPORT_ASSIGN_BY_BATCH:
                    Text = @"��ǰת�����ε���";
                    break;
                case ImportType.IMPORT_FINANCE_BY_BATCH:
                    Text = @"��ǰ�������ε���";
                    break;
                case ImportType.IMPORT_PAYMENT_BY_BATCH:
                    Text = @"��ǰ�������ε���";
                    break;
                case ImportType.IMPORT_REFUND_BY_BATCH:
                    Text = @"��ǰ�������ε���";
                    break;
                case ImportType.IMPORT_INVOICE:
                    Text = @"̨�ʵ���";
                    break;
                case ImportType.IMPORT_ASSIGN:
                    Text = @"Ӧ���˿�ת���嵥����";
                    break;
                case ImportType.IMPORT_ASSIGN_II:
                    Text = @"Ӧ���˿�ת���嵥����";
                    break;
                case ImportType.IMPORT_FINANCE:
                    Text = @"�ſ���ϸ����";
                    break;
                case ImportType.IMPORT_PAYMENT:
                    Text = @"�����˿���ϸ����";
                    break;
                case ImportType.IMPORT_REFUND:
                    Text = @"����������ϸ����";
                    break;
                case ImportType.IMPORT_CREDIT_NOTE:
                    Text = @"��������˿���ϸ����";
                    break;
                case ImportType.IMPORT_POOL_FINANCE:
                    Text = @"�ſ���ϸ�������ʣ�����";
                    break;
                case ImportType.IMPORT_POOL_REFUND:
                    Text = @"����������ϸ�������ʣ�����";
                    break;
                case ImportType.SEND_LEGERS:
                    Text = @"���ֲ�/���з���̨��";
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
                        throw new Exception(String.Format("�������ƣ�{0}���쳣�����ܷ���", dir.Name));
                    }

                    if (String.IsNullOrEmpty(location.LegerContactEmail1))
                    {
                        throw new Exception(String.Format("̨�ʵ�һ�����˲���Ϊ�գ��ֲ���{0}", dir.Name));
                    }

                    var mail = new SendMail(location.LegerContactEmail1, location.LegerContactEmail2,
                                            App.Current.CurUser.Email,
                                            String.Format("{0}����̨��{1:yyyyMMdd}", dir.Name, DateTime.Today),
                                            "���ʼ����й��������б�����Ӫϵͳ�Զ����ɡ�");
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
            tbStatus.Text = _importType == ImportType.SEND_LEGERS ? String.Format("���ڸ�{0}�����ʼ�", e.UserState) : String.Format("������� {0:G}%", e.ProgressPercentage);
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
                    tbStatus.Text = String.Format("��¼: {0} �����쳣: {1}", e.Error.Data["ID"], e.Error.Message);
                }
                else if (e.Error.Data.Contains("column"))
                {
                    tbStatus.Text = String.Format("��{0}����¼��{1}�У������쳣: {2}", e.Error.Data["row"], e.Error.Data["column"],
                                                  e.Error.Message);
                }
                else if (e.Error.Data.Contains("row"))
                {
                    tbStatus.Text = String.Format("��{0}����¼�����쳣: {1}", e.Error.Data["row"], e.Error.Message);
                }
                else
                {
                    tbStatus.Text = String.Format("�����쳣: {0}", e.Error.Message);
                }
            }
            else if (e.Cancelled)
            {
                tbStatus.Text = _importType == ImportType.SEND_LEGERS ? "���ͱ�ȡ��" : "���뱻ȡ��";
                progressBar.Value = 0;
            }
            else
            {
                tbStatus.Text = _importType == ImportType.SEND_LEGERS
                                    ? String.Format("�����ʼ�������������{0}���ʼ�", e.Result)
                                    : String.Format("�������, ������{0}����¼", e.Result);
            }

            btnStart.Enabled = true;
            btnCancel.Text = @"�ر�";
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
                            throw new Exception("������Ų���Ϊ�գ����ܵ��룺" + invoiceNo);
                        }
                        if (caseCode.Length > 20)
                        {
                            break;
                        }

                        if (String.IsNullOrEmpty(invoiceNo))
                        {
                            throw new Exception("��Ʊ��Ų���Ϊ�գ����ܵ��룬������ţ� " + caseCode);
                        }

                        if (curCase == null || curCase.CaseCode != caseCode)
                        {
                            curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);

                            if (curCase == null)
                            {
                                throw new Exception("������Ŵ���: " + caseCode);
                            }
                        }

                        CDA cda = curCase.ActiveCDA;
                        if (cda == null)
                        {
                            throw new Exception("û����Ч�Ķ��֪ͨ��: " + caseCode);
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
                                throw new Exception("��ǰ�����ļ��з�Ʊ���ظ�: " + old.InvoiceNo);
                            }
                        }
                        else
                        {
                            throw new Exception("��Ʊ���Ѿ����ڣ����ܵ��룺 " + invoiceNo);
                        }

                        string currency = string.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(currency))
                        {
                            throw new Exception("��Ʊ�ұ���Ϊ�գ����ܵ��룺" + invoiceNo);
                        }
                        if (currency != curCase.InvoiceCurrency)
                        {
                            throw new Exception("��Ʊ�ұ��밸���ұ�ƥ�䣬���ܵ��룺" + invoiceNo);
                        }

                        string invoiceAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(invoiceAmountStr))
                        {
                            throw new Exception("��Ʊ����Ϊ�գ����ܵ��룺" + invoiceNo);
                        }
                        double invoiceAmount;
                        if (Double.TryParse(invoiceAmountStr, out invoiceAmount))
                        {
                            invoice.InvoiceAmount = invoiceAmount;
                        }
                        else
                        {
                            throw new Exception("��Ʊ��������쳣�����ܵ��룺" + invoiceNo);
                        }

                        string assignAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(assignAmountStr))
                        {
                            throw new Exception("ת�ý���Ϊ�գ����ܵ��룺" + invoiceNo);
                        }
                        double assignAmount;
                        if (Double.TryParse(assignAmountStr, out assignAmount))
                        {
                            invoice.AssignAmount = assignAmount;
                        }
                        else
                        {
                            throw new Exception("ת�ý�������쳣�����ܵ��룺" + invoiceNo);
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
                                throw new Exception("��Ʊ�������쳣�����ܵ��룺" + invoiceNo);
                            }
                        }

                        string dueDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(dueDateStr))
                        {
                            throw new Exception("ת���ղ���Ϊ�գ����ܵ��룺" + invoiceNo);
                        }
                        DateTime dueDate;
                        if (DateTime.TryParse(dueDateStr, out dueDate))
                        {
                            invoice.DueDate = dueDate;
                        }
                        else
                        {
                            throw new Exception("ת���������쳣�����ܵ��룺" + invoiceNo);
                        }

                        string commissionStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (cda.CommissionType == "����")
                        {
                            if (String.IsNullOrEmpty(commissionStr))
                            {
                                throw new Exception("�����Ѳ���Ϊ�գ����ܵ��룺" + invoiceNo);
                            }
                            double commissionAmount;
                            if (Double.TryParse(commissionStr, out commissionAmount))
                            {
                                invoice.Commission = commissionAmount;
                            }
                            else
                            {
                                throw new Exception("�����������쳣�����ܵ��룺" + invoiceNo);
                            }
                        }
                        else if (cda.CommissionType == "��ת�ý��")
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
                        if ("��Ʊ" == type)
                        {
                            invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                            if (String.IsNullOrEmpty(caseCode))
                            {
                                if (String.IsNullOrEmpty(invoiceNo))
                                {
                                    break;
                                }
                                throw new Exception("������Ų���Ϊ�գ����ܵ��룺" + invoiceNo);
                            }
                            if (caseCode.Length > 20)
                            {
                                break;
                            }

                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("��Ʊ��Ų���Ϊ�գ����ܵ��룬������ţ� " + caseCode);
                            }

                            column++;
                        }
                        else if ("����֪ͨ" == type)
                        {
                            creditNoteNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                            if (String.IsNullOrEmpty(caseCode))
                            {
                                if (String.IsNullOrEmpty(creditNoteNo))
                                {
                                    break;
                                }
                                throw new Exception("������Ų���Ϊ�գ����ܵ��룺" + creditNoteNo);
                            }
                            if (caseCode.Length > 20)
                            {
                                break;
                            }

                            if (String.IsNullOrEmpty(creditNoteNo))
                            {
                                throw new Exception("����֪ͨ��Ų���Ϊ�գ����ܵ��룬������ţ� " + caseCode);
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
                                throw new Exception("������Ŵ���: " + caseCode);
                            }
                        }

                        CDA cda = curCase.ActiveCDA;
                        if (cda == null)
                        {
                            throw new Exception("û����Ч�Ķ��֪ͨ��: " + caseCode);
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

                        if ("��Ʊ" == type)
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
                                    throw new Exception("��ǰ�����ļ��з�Ʊ���ظ�: " + old.InvoiceNo);
                                }
                            }
                            else
                            {
                                throw new Exception("��Ʊ���Ѿ����ڣ����ܵ��룺 " + invoiceNo);
                            }

                            string currency = string.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(currency))
                            {
                                throw new Exception("��Ʊ�ұ���Ϊ�գ����ܵ��룺" + invoiceNo);
                            }
                            if (currency != curCase.InvoiceCurrency)
                            {
                                throw new Exception("��Ʊ�ұ��밸���ұ�ƥ�䣬���ܵ��룺" + invoiceNo);
                            }

                            string invoiceAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(invoiceAmountStr))
                            {
                                throw new Exception("��Ʊ����Ϊ�գ����ܵ��룺" + invoiceNo);
                            }
                            double invoiceAmount;
                            if (Double.TryParse(invoiceAmountStr, out invoiceAmount))
                            {
                                invoice.InvoiceAmount = invoiceAmount;
                            }
                            else
                            {
                                throw new Exception("��Ʊ��������쳣�����ܵ��룺" + invoiceNo);
                            }

                            string assignAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(assignAmountStr))
                            {
                                throw new Exception("ת�ý���Ϊ�գ����ܵ��룺" + invoiceNo);
                            }
                            double assignAmount;
                            if (Double.TryParse(assignAmountStr, out assignAmount))
                            {
                                invoice.AssignAmount = assignAmount;
                            }
                            else
                            {
                                throw new Exception("ת�ý�������쳣�����ܵ��룺" + invoiceNo);
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
                                    throw new Exception("��Ʊ�������쳣�����ܵ��룺" + invoiceNo);
                                }
                            }

                            string dueDateStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(dueDateStr))
                            {
                                throw new Exception("ת���ղ���Ϊ�գ����ܵ��룺" + invoiceNo);
                            }
                            DateTime dueDate;
                            if (DateTime.TryParse(dueDateStr, out dueDate))
                            {
                                invoice.DueDate = dueDate;
                            }
                            else
                            {
                                throw new Exception("ת���������쳣�����ܵ��룺" + invoiceNo);
                            }

                            string commissionStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (cda.CommissionType == "����")
                            {
                                if (String.IsNullOrEmpty(commissionStr))
                                {
                                    throw new Exception("�����Ѳ���Ϊ�գ����ܵ��룺" + invoiceNo);
                                }
                                double commissionAmount;
                                if (Double.TryParse(commissionStr, out commissionAmount))
                                {
                                    invoice.Commission = commissionAmount;
                                }
                                else
                                {
                                    throw new Exception("�����������쳣�����ܵ��룺" + invoiceNo);
                                }
                            }
                            else if (cda.CommissionType == "��ת�ý��")
                            {
                                invoice.Commission = invoice.AssignAmount * cda.Price;
                            }

                            invoice.Comment = String.Format("{0:G}", valueArray[row, column]);
                            invoice.InvoiceAssignBatch = assignBatch;
                        }
                        else if ("����֪ͨ" == type)
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
                                throw new Exception("����֪ͨ���Ѿ����ڣ����ܵ��룺 " + creditNoteNo);
                            }

                            String toInvoiceNo = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(toInvoiceNo))
                            {
                                throw new Exception(String.Format("����֪ͨ{0}��Ӧ��Ʊ��Ų���Ϊ��", creditNoteNo));
                            }

                            Invoice toInvoice =
                                _context.Invoices.SingleOrDefault(
                                    i => i.InvoiceNo == toInvoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                            if (toInvoice == null)
                            {
                                toInvoice = invoiceList.SingleOrDefault(i => i.InvoiceNo == toInvoiceNo);
                                if (toInvoice == null)
                                {
                                    throw new Exception(String.Format("����֪ͨ{0}��Ӧ��Ʊ���{1}����", creditNoteNo, toInvoiceNo));
                                }
                            }

                            string currency = string.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(currency))
                            {
                                throw new Exception("����֪ͨ�ұ���Ϊ�գ����ܵ��룺" + creditNoteNo);
                            }
                            if (currency != toInvoice.InvoiceCurrency)
                            {
                                throw new Exception("����֪ͨ�ұ��뷢Ʊ�ұ�ƥ�䣬���ܵ��룺" + creditNoteNo);
                            }

                            string paymentAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(paymentAmountStr))
                            {
                                throw new Exception("����֪ͨ����Ϊ�գ����ܵ��룺" + creditNoteNo);
                            }

                            double paymentAmount;
                            if (!Double.TryParse(paymentAmountStr, out paymentAmount))
                            {
                                throw new Exception("����֪ͨ��������쳣�����ܵ��룺" + creditNoteNo);
                            }

                            column++;

                            string creditNoteDateStr = String.Format("{0:G}", valueArray[row, column++]);
                            if (String.IsNullOrEmpty(creditNoteDateStr))
                            {
                                throw new Exception("����֪ͨ�ղ���Ϊ��," + creditNoteNo);
                            }
                            DateTime creditNoteDate;
                            if (DateTime.TryParse(creditNoteDateStr, out creditNoteDate))
                            {
                                creditNote.CreditNoteDate = creditNoteDate;
                            }
                            else
                            {
                                throw new Exception("����֪ͨ�������쳣�����ܵ��룺" + creditNoteNo);
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
                                throw new Exception("��Ʊ���ظ�: " + old.InvoiceNo);
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
                            throw new Exception("�����ֲ����ƴ��� " + ownerDeptName);
                        }


                        var appDate = (DateTime)valueArray[row, 19];
                        if (String.IsNullOrEmpty(caseCode) && !String.IsNullOrEmpty(transactionType))
                        {
                            caseCode = Case.GenerateCaseCode(transactionType, ownerDept.LocationCode, appDate, caseList);
                        }

                        Case curCase = _context.Cases.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase != null)
                        {
                            throw new Exception("�����Ѵ��ڣ����ܵ��룺 " + caseCode);
                        }

                        curCase = caseList.SingleOrDefault(c => c.CaseCode == caseCode);
                        if (curCase != null)
                        {
                            throw new Exception("��������ظ������ܵ��룺 " + caseCode);
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
                            throw new Exception("�������������� " + sellerEDICode);
                        }

                        curCase.SellerClient = sellerClient;
                        column++;
                        column++;
                        string buyerEDICode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Client buyerClient = _context.Clients.SingleOrDefault(c => c.ClientEDICode == buyerEDICode);
                        if (buyerClient == null)
                        {
                            throw new Exception("�򷽱��������� " + buyerEDICode);
                        }

                        curCase.BuyerClient = buyerClient;
                        column++;
                        column++;
                        string efCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Factor sellerFactor = _context.Factors.SingleOrDefault(f => f.FactorCode == efCode);
                        if (sellerFactor == null)
                        {
                            throw new Exception("���������̴������ " + efCode);
                        }

                        curCase.SellerFactor = sellerFactor;
                        string ifCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        Factor buyerFactor = _context.Factors.SingleOrDefault(f => f.FactorCode == ifCode);
                        if (buyerFactor == null)
                        {
                            throw new Exception("�򷽱����̴������ " + ifCode);
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
                            throw new Exception("������Ŵ���: " + caseCode);
                        }

                        if (curCase.TransactionType != "���ڱ���" && curCase.SellerClient.Contract == null)
                        {
                            throw new Exception("ȱ������ͬ��" + caseCode);
                        }

                        column++;
                        string cdaCode = CDA.GenerateCDACode(curCase, cdaList);

                        CDA cda = _context.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                        if (cda != null)
                        {
                            throw new Exception("CDA�Ѵ��ڣ����ܵ��룺 " + cdaCode);
                        }

                        cda = cdaList.SingleOrDefault(c => c.CDACode == cdaCode);
                        if (cda != null)
                        {
                            throw new Exception("CDA����ظ������ܵ��룺 " + cdaCode);
                        }

                        cda = new CDA { CDACode = cdaCode, CDAStatus = CDAStr.CHECKED };
                        cdaList.Add(cda);
                        cda.Case = curCase;

                        column++; //����
                        column++; //��
                        column++; //������
                        column++; //ҵ�����
                        column++; //��Ʊ�ұ�
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
                            throw new Exception("�ͻ��Ѿ����ڣ����ܵ��룺 " + clientEDICode);
                        }

                        client = clientList.SingleOrDefault(c => c.ClientEDICode == clientEDICode);
                        if (client != null)
                        {
                            throw new Exception("�ͻ�����ظ������ܵ��룺 " + clientEDICode);
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
                                throw new Exception("���ſͻ��Ŵ��� " + groupNo);
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
                            throw new Exception("�ͻ�����������: " + clientEDICode);
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
                            throw new Exception("�ͻ������ڣ����ܵ��룺 " + clientEDICode);
                        }

                        if (clientList.SingleOrDefault(c => c.ClientEDICode == clientEDICode) != null)
                        {
                            throw new Exception("�ͻ�����ظ������ܵ��룺 " + clientEDICode);
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
                                throw new Exception("���ſͻ��Ŵ��� " + groupNo);
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
                            throw new Exception("�ͻ����������󣬲��ܵ���Э������飺 " + clientEDICode);
                        }

                        int column = 3;
                        string reviewNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(reviewNo))
                        {
                            throw new Exception("Э�������Ų���Ϊ��");
                        }

                        ClientReview review = _context.ClientReviews.SingleOrDefault(c => c.ReviewNo == reviewNo);
                        if (review != null)
                        {
                            throw new Exception("Э������Ѵ��ڣ����ܵ��룺 " + reviewNo);
                        }

                        review = reviewList.SingleOrDefault(c => c.ReviewNo == reviewNo);
                        if (review != null)
                        {
                            throw new Exception("Э���������ظ������ܵ��룺 " + reviewNo);
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
                            throw new Exception("�ͻ���Ŵ���: " + clientEDICode);
                        }

                        string contractCode = String.Format("{0:G}", valueArray[row, column++]).Trim();
                        if (String.IsNullOrEmpty(contractCode))
                        {
                            throw new Exception("�����ͬ�Ų���Ϊ��");
                        }

                        Contract contract = _context.Contracts.SingleOrDefault(c => c.ContractCode == contractCode);
                        if (contract != null)
                        {
                            throw new Exception("�����ͬ�Ѵ��ڣ����ܵ���: " + contractCode);
                        }

                        contract = contractList.SingleOrDefault(c => c.ContractCode == contractCode);
                        if (contract != null)
                        {
                            throw new Exception("�����ͬ�ظ������ܵ���: " + contractCode);
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
                            throw new Exception("���������ڣ����ܵ��������ȣ� " + caseCode);
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
                            throw new Exception("ҵ���Ų���Ϊ�գ����ܵ���");
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
                                throw new Exception("ҵ���Ŵ��󣬲��ܵ��룺" + assignBatchCode);
                            }

                            CDA cda = assignBatch.Case.ActiveCDA;
                            if (cda == null)
                            {
                                throw new Exception("û����Ч�Ķ��֪ͨ��: " + assignBatchCode);
                            }
                        }

                        if (String.IsNullOrEmpty(creditNoteNo))
                        {
                            throw new Exception("����֪ͨ�Ų���Ϊ�գ����ܵ��룬ҵ���ţ� " + assignBatchCode);
                        }

                        if (String.IsNullOrEmpty(invoiceNo))
                        {
                            throw new Exception("��Ӧ��Ʊ�Ų���Ϊ�գ����ܵ��룬ҵ���ţ� " + assignBatchCode);
                        }

                        invoice =
                            _context.Invoices.SingleOrDefault(
                                i => i.InvoiceNo == invoiceNo && i.AssignBatchNo == assignBatchCode);
                        if (invoice == null)
                        {
                            throw new Exception("��Ʊ�Ŵ��󣬲��ܵ��룬��Ʊ�ţ�" + invoiceNo);
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
                            throw new Exception("����֪ͨ���Ѵ��ڣ����ܵ��룺" + creditNoteNo);
                        }

                        var log = new InvoicePaymentLog { CreditNote = creditNote };
                        creditNote.InvoiceAssignBatch = log.Invoice.InvoiceAssignBatch;

                        string creditNoteAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double creditNoteAmount;
                        if (String.IsNullOrEmpty(creditNoteAmountStr))
                        {
                            throw new Exception("����֪ͨ����Ϊ�գ����ܵ��룺" + creditNoteNo);
                        }
                        if (Double.TryParse(creditNoteAmountStr, out creditNoteAmount))
                        {
                            log.PaymentAmount = creditNoteAmount;
                        }
                        else
                        {
                            throw new Exception("����֪ͨ��������쳣�����ܵ��룺" + creditNoteNo);
                        }

                        string creditNoteDateStr = String.Format("{0:G}", valueArray[row, column]);
                        if (String.IsNullOrEmpty(creditNoteDateStr))
                        {
                            throw new Exception("����֪ͨ�ղ���Ϊ�գ����ܵ��룺" + creditNoteNo);
                        }

                        DateTime creditNoteDate;
                        if (DateTime.TryParse(creditNoteDateStr, out creditNoteDate))
                        {
                            creditNote.CreditNoteDate = creditNoteDate;
                        }
                        else
                        {
                            throw new Exception("����֪ͨ�������쳣�����ܵ��룺" + creditNoteNo);
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
                                                   PaymentType = "����֪ͨ",
                                                   CreateUserName = App.Current.CurUser.Name,
                                                   PaymentBatchNo =
                                                       InvoicePaymentBatch.GeneratePaymentBatchNo(DateTime.Now,
                                                                                                  paymentBatchList)
                                               };
                            //paymentBatch.CheckStatus = BATCH.UNCHECK;
                        }

                        if (TypeUtil.GreaterZero(creditNoteAmount - invoice.AssignOutstanding))
                        {
                            throw new Exception("����֪ͨ���ܴ���ת�������ܵ��룺" + creditNoteNo);
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
                            factor = new Factor { FactorCode = factorCode, FactorType = "������" };
                        }

                        if (factor.FactorType != "������")
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
                            DialogResult dr = MessageBoxEx.Show(monitorResult, "�Ƿ����", MessageBoxButtons.YesNo,
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
                            throw new Exception("���������������: " + factorCode);
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
                            throw new Exception("ҵ���Ŵ���" + assignBatchCode);
                        }

                        //if (assignBatch.CheckStatus != BATCH.CHECK)
                        //{
                        //    throw new Exception("��ҵ��δ���ˣ��򸴺�δͨ������" + assignBatchCode);
                        //}

                        var financeBatch = new InvoiceFinanceBatch();

                        string financeType = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeType))
                        {
                            throw new Exception("���˷�ʽ����Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }
                        financeBatch.FinanceType = financeType;

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("���ʱұ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }
                        financeBatch.BatchCurrency = batchCurrency;

                        string financeAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeAmountStr))
                        {
                            throw new Exception("���ʽ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }
                        double financeAmount;
                        if (Double.TryParse(financeAmountStr, out financeAmount))
                        {
                            financeBatch.FinanceAmount = financeAmount;
                        }
                        else
                        {
                            throw new Exception("���ʽ�������쳣�����ܵ��룺" + assignBatchCode);
                        }

                        string beginDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(beginDateStr))
                        {
                            throw new Exception("�����ղ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }
                        DateTime beginDate;
                        if (DateTime.TryParse(beginDateStr, out beginDate))
                        {
                            financeBatch.FinancePeriodBegin = beginDate;
                        }
                        else
                        {
                            throw new Exception("�����������쳣�����ܵ��룺" + assignBatchCode);
                        }

                        string endDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(endDateStr))
                        {
                            throw new Exception("���ʵ����ղ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }
                        DateTime endDate;
                        if (DateTime.TryParse(endDateStr, out endDate))
                        {
                            financeBatch.FinancePeriodEnd = endDate;
                        }
                        else
                        {
                            throw new Exception("���ʵ����������쳣�����ܵ��룺" + assignBatchCode);
                        }

                        string financeRateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeRateStr))
                        {
                            throw new Exception("�������ʲ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }
                        double financeRate;
                        if (Double.TryParse(financeRateStr, out financeRate))
                        {
                            financeBatch.FinanceRate = financeRate;
                        }
                        else
                        {
                            throw new Exception("�������������쳣�����ܵ��룺" + assignBatchCode);
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
                                throw new Exception("�ɱ����������쳣�����ܵ��룺" + assignBatchCode);
                            }
                        }

                        string factorCode = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(factorCode))
                        {
                            Factor factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                throw new Exception("�����б������" + factorCode);
                            }

                            financeBatch.Factor = factor;
                        }

                        financeBatch.Comment = String.Format("{0:G}", valueArray[row, column]);

                        CDA activeCDA = assignBatch.Case.ActiveCDA;
                        GuaranteeDeposit gd = assignBatch.Case.GuaranteeDepositClient.GetGuaranteeDeposit(batchCurrency);
                        double guaranteeDeposit = 0;

                        if (activeCDA == null)
                        {
                            throw new Exception("û����Ч�Ķ��֪ͨ�飬ҵ���ţ�" + assignBatchCode);
                        }

                        if (gd != null)
                        {
                            guaranteeDeposit = gd.GuaranteeDepositAmount;
                        }

                        if (activeCDA.HighestFinanceLine.HasValue == false)
                        {
                            throw new Exception("�ð��������Ԥ�������ʶ�����㣬�������ʣ�" + assignBatchCode);
                        }

                        if (activeCDA.FinanceCreditLine == null)
                        {
                            throw new Exception("�ð������֪ͨ�����ʶ��Ϊ�գ��������ʣ�" + assignBatchCode);
                        }

                        if (activeCDA.FinanceCreditLine.PeriodEnd < DateTime.Today)
                        {
                            throw new Exception(String.Format("���ʶ���ѵ���{0:d}���������ʣ�{1}",
                                                              activeCDA.FinanceCreditLine.PeriodEnd, assignBatchCode));
                        }
                        if (TypeUtil.LessZero(activeCDA.FinanceLineOutstanding - financeAmount + guaranteeDeposit))
                        {
                            throw new Exception(String.Format("�ð�����Ԥ�������ʶ�����Ϊ{0:N2}��������{1:N2}����Ȳ��㣬�������ʣ�{2}",
                                                              (activeCDA.FinanceLineOutstanding + guaranteeDeposit),
                                                              financeAmount, assignBatchCode));
                        }

                        if (
                            TypeUtil.LessZero(activeCDA.HighestFinanceLine - assignBatch.Case.TotalFinanceOutstanding -
                                              financeAmount + guaranteeDeposit))
                        {
                            throw new Exception(String.Format("�ð��������Ԥ�������ʶ�����Ϊ{0:N2}��������{1:N2}����Ȳ��㣬�������ʣ�{2}",
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
                        if (assignBatch.Case.TransactionType == "�����򷽱���")
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
                                    if (activeCDA.CommissionType == "�����ʽ��")
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
                            throw new Exception(String.Format("�����������ʽ��{0:N2}������ʵ�����ʽ��{1:N2}��ҵ���ţ�{2}",
                                                              financeBatch.FinanceAmount, currentFinanceAmount,
                                                              assignBatchCode));
                        }

                        if (assignBatch.Case.TransactionType == "�����򷽱���")
                        {
                            if (financeBatch.BatchCurrency != assignBatch.Case.InvoiceCurrency)
                            {
                                throw new Exception(String.Format("�����򷽱������ʱұ�{0}��Ҫ�뷢Ʊ�ұ�{1}��ͬ��ҵ���ţ�{2}",
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
                            throw new Exception("��Ʊ�Ŵ���: " + invoiceNo);
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
                                throw new Exception("������Ŵ���: " + caseCode);
                            }
                        }

                        CDA activeCDA = curCase.ActiveCDA;
                        if (activeCDA == null)
                        {
                            throw new Exception("û����Ч�Ķ��֪ͨ��: " + caseCode);
                        }

                        string type = String.Format("{0:G}", valueArray[row, 4]);
                        if (String.IsNullOrEmpty(type))
                        {
                            throw new Exception("��Ʊ/����֪ͨ��Ҫ����: " + row);
                        }

                        if ("��Ʊ".Equals(type))
                        {
                            //��Ʊ��Ϣ
                            column = 5;
                            string invoiceNo = String.Format("{0:G}", valueArray[row, column++]).Trim();
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("��Ʊ�Ų���Ϊ��");
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
                                    throw new Exception("��ǰ�����ļ��з�Ʊ���ظ�: " + old.InvoiceNo);
                                }
                            }
                            else
                            {
                                throw new Exception("��Ʊ�Ѿ����ڣ����ܵ��룺 " + invoiceNo);
                            }

                            column = 8;
                            invoice.InvoiceAmount = (double)valueArray[row, column++];
                            invoice.AssignAmount = invoice.InvoiceAmount;
                            invoice.InvoiceDate = (DateTime?)valueArray[row, column++];
                            invoice.DueDate = (DateTime)valueArray[row, column++];
                            var assignDate = (DateTime)valueArray[row, column++];
                            invoice.IsFlaw = TypeUtil.ConvertStrToBool(valueArray[row, column++]);

                            //ת��������Ϣ
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

                            //����������Ϣ
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

                            //������Ϣ
                            column = 15;
                            var financeAmount = (double?)valueArray[row, column++];
                            if (financeAmount.HasValue)
                            {
                                if (financeBatch == null)
                                {
                                    throw new Exception("ȱ������������Ϣ: " + invoice.InvoiceNo);
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

                            //����������Ϣ
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

                            //������Ϣ
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
                                    throw new Exception("ȱ�ٸ���������Ϣ: " + invoice.InvoiceNo);
                                }

                                paymentLog.InvoicePaymentBatch = paymentBatch;
                                invoice.CaculatePayment();
                            }

                            //����������Ϣ
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

                            //������Ϣ
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
                                    throw new Exception("ȱ�ٻ���������Ϣ: " + invoice.InvoiceNo);
                                }

                                refundLog.InvoiceRefundBatch = refundBatch;
                                invoice.CaculateRefund();
                                refundBatch.CaculateRefundAmount();
                            }

                            //������
                            column = 22;
                            var commission = (double?)valueArray[row, column++];

                            if (commission.HasValue)
                            {
                                if (activeCDA.CommissionType == "�����ʽ��" && financeLog != null)
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
                        else if ("����֪ͨ".Equals(type))
                        {
                            paymentBatch = null;
                            const string paymentType = "����֪ͨ";
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
                                throw new Exception("����֪ͨ��Ų���Ϊ��");
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
                                throw new Exception("����֪ͨ��Ӧ��Ʊ�Ų���Ϊ��");
                            }

                            invoice =
                                _context.Invoices.SingleOrDefault(
                                    i => i.InvoiceNo == invoiceNo && i.InvoiceAssignBatch.CaseCode == caseCode);
                            if (invoice == null)
                            {
                                invoice = invoiceList.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                                if (invoice == null)
                                {
                                    throw new Exception("����֪ͨ��Ӧ��Ʊ�Ŵ���: " + invoiceNo);
                                }
                            }

                            paymentLog.Invoice = invoice;
                            if (paymentBatch == null)
                            {
                                throw new Exception("ȱ�ٴ���֪ͨ����������Ϣ: " + invoice.InvoiceNo);
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
                            throw new Exception("ҵ���Ų���Ϊ�գ����ܵ���");
                        }
                        if (assignBatchCode.Length > 20)
                        {
                            break;
                        }

                        assignBatch =
                            _context.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchCode);

                        if (assignBatch == null)
                        {
                            throw new Exception("ҵ���Ŵ��󣬲��ܵ��룺" + assignBatchCode);
                        }

                        CDA cda = assignBatch.Case.ActiveCDA;
                        if (cda == null)
                        {
                            throw new Exception("û����Ч�Ķ��֪ͨ��: " + assignBatchCode);
                        }

                        if (assignBatch.Case.TransactionType == "���ڱ���" || assignBatch.Case.TransactionType == "���ڱ���")
                        {
                            if (String.IsNullOrEmpty(invoiceNo))
                            {
                                throw new Exception("����Ϊ���ʱ�������Ʊ��Ų���Ϊ�գ����ܵ��룬ҵ���ţ� " + assignBatchCode);
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
                                throw new Exception("��Ʊ�Ŵ��󣬲��ܵ��룬��Ʊ�ţ�" + invoiceNo);
                            }
                        }

                        string paymentType = String.Format("{0:G}", valueArray[row, column++]);

                        string paymentCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (paymentCurrency != assignBatch.BatchCurrency)
                        {
                            throw new Exception(String.Format("���ʱ���{0}�밸������{1}����ͬ�����ܵ��룺{2}", paymentCurrency,
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
                                    throw new Exception("�����˿��������쳣�����ܵ��룺" + invoiceNo);
                                }
                                throw new Exception("�����˿��������쳣�����ܵ��룺" + assignBatchCode);
                            }
                        }

                        string paymentDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(paymentDateStr))
                        {
                            if (isInInvoice)
                            {
                                throw new Exception("�����ղ���Ϊ�գ����ܵ��룺" + invoiceNo);
                            }
                            throw new Exception("�����ղ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }

                        DateTime paymentDate;
                        if (!DateTime.TryParse(paymentDateStr, out paymentDate))
                        {
                            if (isInInvoice)
                            {
                                throw new Exception("�����������쳣�����ܵ��룺" + invoiceNo);
                            }
                            else
                            {
                                throw new Exception("�����������쳣�����ܵ��룺" + assignBatchCode);
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
                                    throw new Exception("�����˿���ܴ���ת�������ܵ��룺" + invoiceNo);
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
                                    throw new Exception("�����˿���ܴ���ת�������ܵ��룺" + assignBatchCode);
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
                            throw new Exception("��Ʊ�Ŵ���: " + invoiceNo);
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
                            throw new Exception("�ͻ���Ŵ���" + clientEDICode);
                        }

                        var financeBatch = new InvoiceFinanceBatch();

                        string financeType = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeType))
                        {
                            throw new Exception("���˷�ʽ����Ϊ�գ����ܵ��룺" + clientEDICode);
                        }
                        financeBatch.FinanceType = financeType;

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("���ʱұ���Ϊ�գ����ܵ��룺" + clientEDICode);
                        }
                        financeBatch.BatchCurrency = batchCurrency;

                        string financeAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeAmountStr))
                        {
                            throw new Exception("���ʽ���Ϊ�գ����ܵ��룺" + clientEDICode);
                        }
                        double financeAmount;
                        if (Double.TryParse(financeAmountStr, out financeAmount))
                        {
                            financeBatch.FinanceAmount = financeAmount;
                        }
                        else
                        {
                            throw new Exception("���ʽ�������쳣�����ܵ��룺" + clientEDICode);
                        }

                        string beginDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(beginDateStr))
                        {
                            throw new Exception("�����ղ���Ϊ�գ����ܵ��룺" + clientEDICode);
                        }
                        DateTime beginDate;
                        if (DateTime.TryParse(beginDateStr, out beginDate))
                        {
                            financeBatch.FinancePeriodBegin = beginDate;
                        }
                        else
                        {
                            throw new Exception("�����������쳣�����ܵ��룺" + clientEDICode);
                        }

                        string endDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(endDateStr))
                        {
                            throw new Exception("���ʵ����ղ���Ϊ�գ����ܵ��룺" + clientEDICode);
                        }
                        DateTime endDate;
                        if (DateTime.TryParse(endDateStr, out endDate))
                        {
                            financeBatch.FinancePeriodEnd = endDate;
                        }
                        else
                        {
                            throw new Exception("���ʵ����������쳣�����ܵ��룺" + clientEDICode);
                        }

                        string financeRateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(financeRateStr))
                        {
                            throw new Exception("�������ʲ���Ϊ�գ����ܵ��룺" + clientEDICode);
                        }
                        double financeRate;
                        if (Double.TryParse(financeRateStr, out financeRate))
                        {
                            financeBatch.FinanceRate = financeRate;
                        }
                        else
                        {
                            throw new Exception("�������������쳣�����ܵ��룺" + clientEDICode);
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
                                throw new Exception("�ɱ����������쳣�����ܵ��룺" + clientEDICode);
                            }
                        }

                        string factorCode = String.Format("{0:G}", valueArray[row, column++]);
                        if (!String.IsNullOrEmpty(factorCode))
                        {
                            Factor factor = _context.Factors.SingleOrDefault(f => f.FactorCode == factorCode);
                            if (factor == null)
                            {
                                throw new Exception("�����б������" + factorCode);
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
                            throw new Exception("�ͻ���Ŵ��󣬲��ܵ��룺" + clientEDICode);
                        }

                        string refundType = String.Format("{0:G}", valueArray[row, column++]);

                        string batchCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(batchCurrency))
                        {
                            throw new Exception("����ұ���Ϊ�գ����ܵ��룺" + clientEDICode);
                        }

                        string refundAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double refundAmount = 0;
                        if (!String.IsNullOrEmpty(refundAmountStr))
                        {
                            if (!Double.TryParse(refundAmountStr, out refundAmount))
                            {
                                throw new Exception("�������ʽ�������쳣�����ܵ��룺" + clientEDICode);
                            }
                        }

                        string refundDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(refundDateStr))
                        {
                            throw new Exception("�����ղ���Ϊ�գ����ܵ��룺" + clientEDICode);
                        }

                        DateTime refundDate;
                        if (!DateTime.TryParse(refundDateStr, out refundDate))
                        {
                            throw new Exception("�����������쳣�����ܵ��룺" + clientEDICode);
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
                            throw new Exception("ҵ���Ŵ��󣬲��ܵ��룺" + assignBatchCode);
                        }

                        CDA cda = assignBatch.Case.ActiveCDA;
                        if (cda == null)
                        {
                            throw new Exception("û����Ч�Ķ��֪ͨ��: " + assignBatchCode);
                        }

                        string refundType = String.Format("{0:G}", valueArray[row, column++]);

                        string refundCurrency = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(refundCurrency))
                        {
                            throw new Exception("�������ʽ��ұ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }

                        string refundAmountStr = String.Format("{0:G}", valueArray[row, column++]);
                        double refundAmount = 0;
                        if (!String.IsNullOrEmpty(refundAmountStr))
                        {
                            if (!Double.TryParse(refundAmountStr, out refundAmount))
                            {
                                throw new Exception("�������ʽ�������쳣�����ܵ��룺" + assignBatchCode);
                            }
                        }

                        string refundDateStr = String.Format("{0:G}", valueArray[row, column++]);
                        if (String.IsNullOrEmpty(refundDateStr))
                        {
                            throw new Exception("�����ղ���Ϊ�գ����ܵ��룺" + assignBatchCode);
                        }

                        DateTime refundDate;
                        if (!DateTime.TryParse(refundDateStr, out refundDate))
                        {
                            throw new Exception("�����������쳣�����ܵ��룺" + assignBatchCode);
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
                                    throw new Exception("�������ʽ��ܴ������������ܵ��룺" + assignBatchCode);
                                }
                            }
                            else
                            {
                                if (TypeUtil.GreaterZero(refundAmount - assignBatch.FinanceOutstanding))
                                {
                                    throw new Exception("�������ʽ��ܴ������������ܵ��룺" + assignBatchCode);
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
                            throw new Exception("��Ʊ�Ŵ���: " + invoiceNo);
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
                tbStatus.Text = _importType == ImportType.SEND_LEGERS ? "����ѡ��̨�����ڸ�Ŀ¼" : "����ѡ�����ļ�·��";
                return;
            }

            btnCancel.Text = @"ȡ��";
            backgroundWorker.RunWorkerAsync(filePath);

            btnStart.Enabled = false;
        }
    }
}