//-----------------------------------------------------------------------
// <copyright file="ExportForm.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class ExportForm : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private ExportType exportType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum ExportType
        {
            /// <summary>
            /// 
            /// </summary>
            EXPORT_INVOICES_FULL,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_INVOICES_OVERDUE,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_CREDIT_NOTES,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_ASSIGN_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_FINANCE_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_PAYMENT_BY_BATCH,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_REFUND_BY_BATCH,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the ExportForm class
        /// </summary>
        /// <param name="exportType"></param>
        public ExportForm(ExportType exportType)
        {
            this.InitializeComponent();
            this.exportType = exportType;
        }

        #endregion Constructors

        #region Methods (12)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objArray"></param>
        public void StartExport(IList objArray)
        {
            this.Show();
            this.backgroundWorker.RunWorkerAsync(objArray);
        }
        // Private Methods (11) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            switch (this.exportType)
            {
                case ExportType.EXPORT_CREDIT_NOTES:
                    e.Result = this.ExportCreditNotes((IList)e.Argument, worker, e);
                    break;
                case ExportType.EXPORT_ASSIGN_BY_BATCH:
                    e.Result = this.ExportAssignByBatch((IList)e.Argument, worker, e);
                    break;
                case ExportType.EXPORT_FINANCE_BY_BATCH:
                    e.Result = this.ExportFinanceByBatch((IList)e.Argument, worker, e);
                    break;
                case ExportType.EXPORT_PAYMENT_BY_BATCH:
                    e.Result = this.ExportPaymentByBatch((IList)e.Argument, worker, e);
                    break;
                case ExportType.EXPORT_REFUND_BY_BATCH:
                    e.Result = this.ExportRefundByBatch((IList)e.Argument, worker, e);
                    break;
                case ExportType.EXPORT_INVOICES_FULL:
                    e.Result = this.ExportInvoicesFull((IList)e.Argument, worker, e);
                    break;
                case ExportType.EXPORT_INVOICES_OVERDUE:
                    e.Result = this.ExportInvoicesOverDue((IList)e.Argument, worker, e);
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
            this.tbStatus.Text = String.Format("导出进度 {0:G}%", e.ProgressPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.tbStatus.Text = "发生异常: " + e.Error.Message;
            }
            else if (e.Cancelled)
            {
                this.tbStatus.Text = "导出被取消";
                this.progressBar.Value = 0;
            }
            else
            {
                this.tbStatus.Text = String.Format("导出结束,共导出{0}条记录", e.Result);
            }

            this.btnCancel.Text = "关闭";
            if (e.Error == null)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelExport(object sender, EventArgs e)
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
        /// <param name="invoiceList"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportAssignByBatch(IList invoiceList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                int column = 1;
                datasheet.Cells[1, column++] = "发票号";
                datasheet.Cells[1, column++] = "票面金额";
                datasheet.Cells[1, column++] = "转让金额";
                datasheet.Cells[1, column++] = "发票日";
                datasheet.Cells[1, column++] = "到期日";
                datasheet.Cells[1, column++] = "是否瑕疵";
                datasheet.Cells[1, column++] = "手续费";
                datasheet.Cells[1, column++] = "手续费收取日";
                datasheet.Cells[1, column++] = "备注";

                int size = invoiceList.Count;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (datasheet != null)
                        {
                            Marshal.ReleaseComObject(datasheet);
                            datasheet = null;
                        }

                        if (app != null)
                        {
                            foreach (Workbook wb in app.Workbooks)
                            {
                                wb.Close(false, Type.Missing, Type.Missing);
                            }

                            app.Workbooks.Close();
                            app.Quit();
                            Marshal.ReleaseComObject(app);
                            app = null;
                        }

                        e.Cancel = true;
                        return -1;
                    }

                    column = 1;
                    Invoice invoice = (Invoice)invoiceList[row];
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                    datasheet.Cells[row + 2, column++] = invoice.DueDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    datasheet.Cells[row + 2, column++] = invoice.CommissionDate;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3 || range.Column == 7)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (datasheet != null)
                {
                    Marshal.ReleaseComObject(datasheet);
                    datasheet = null;
                }

                if (app != null)
                {
                    foreach (Workbook wb in app.Workbooks)
                    {
                        wb.Close(false, Type.Missing, Type.Missing);
                    }

                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }

                throw e1;
            }

            return invoiceList.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creditNoteList"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportCreditNotes(IList creditNoteList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[2];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                int column = 1;
                //CDA
                datasheet.Cells[1, column++] = "CDA编号";
                datasheet.Cells[1, column++] = "买方名称";
                //付款批次
                datasheet.Cells[1, column++] = "付款批次号";
                datasheet.Cells[1, column++] = "付款类型";
                datasheet.Cells[1, column++] = "付款批次日";
                datasheet.Cells[1, column++] = "是否生成报文";
                datasheet.Cells[1, column++] = "本次付款备注";
                datasheet.Cells[1, column++] = "付款经办人";
                //贷项通知
                datasheet.Cells[1, column++] = "贷项通知号";
                datasheet.Cells[1, column++] = "贷项通知金额";
                datasheet.Cells[1, column++] = "贷项通知日";
                datasheet.Cells[1, column++] = "对应发票号";
                datasheet.Cells[1, column++] = "备注";

                int size = creditNoteList.Count;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (datasheet != null)
                        {
                            Marshal.ReleaseComObject(datasheet);
                            datasheet = null;
                        }

                        if (app != null)
                        {
                            foreach (Workbook wb in app.Workbooks)
                            {
                                wb.Close(false, Type.Missing, Type.Missing);
                            }

                            app.Workbooks.Close();
                            app.Quit();
                            Marshal.ReleaseComObject(app);
                            app = null;
                        }

                        e.Cancel = true;
                        return -1;
                    }

                    column = 1;
                    CreditNote creditNote = (CreditNote)creditNoteList[row];
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.CDA.CDACode;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.CDA.Case.BuyerClient.ToString();
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.PaymentBatchNo;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.PaymentType;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.PaymentDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.IsCreateMsg);
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.Comment;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.CreateUserName;
                    datasheet.Cells[row + 2, column++] = creditNote.CreditNoteNo;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].PaymentAmount;
                    datasheet.Cells[row + 2, column++] = creditNote.CreditNoteDate;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoiceNo;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 10)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (datasheet != null)
                {
                    Marshal.ReleaseComObject(datasheet);
                    datasheet = null;
                }

                if (app != null)
                {
                    foreach (Workbook wb in app.Workbooks)
                    {
                        wb.Close(false, Type.Missing, Type.Missing);
                    }

                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }

                throw e1;
            }

            return creditNoteList.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportFinanceByBatch(IList invoiceList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                int column = 1;
                datasheet.Cells[1, column++] = "发票号";
                datasheet.Cells[1, column++] = "转让余额";
                datasheet.Cells[1, column++] = "融资金额";
                datasheet.Cells[1, column++] = "手续费";
                datasheet.Cells[1, column++] = "手续费收取日";
                datasheet.Cells[1, column++] = "利息";
                datasheet.Cells[1, column++] = "利息收取日";
                datasheet.Cells[1, column++] = "备注";

                int size = invoiceList.Count;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (datasheet != null)
                        {
                            Marshal.ReleaseComObject(datasheet);
                            datasheet = null;
                        }

                        if (app != null)
                        {
                            foreach (Workbook wb in app.Workbooks)
                            {
                                wb.Close(false, Type.Missing, Type.Missing);
                            }

                            app.Workbooks.Close();
                            app.Quit();
                            Marshal.ReleaseComObject(app);
                            app = null;
                        }

                        e.Cancel = true;
                        return -1;
                    }

                    column = 1;
                    Invoice invoice = (Invoice)invoiceList[row];
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.AssignOutstanding;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    datasheet.Cells[row + 2, column++] = invoice.CommissionDate;
                    datasheet.Cells[row + 2, column++] = invoice.Interest;
                    datasheet.Cells[row + 2, column++] = invoice.InterestDate;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3 || range.Column == 4 || range.Column == 6)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (datasheet != null)
                {
                    Marshal.ReleaseComObject(datasheet);
                    datasheet = null;
                }

                if (app != null)
                {
                    foreach (Workbook wb in app.Workbooks)
                    {
                        wb.Close(false, Type.Missing, Type.Missing);
                    }

                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }

                throw e1;
            }

            return invoiceList.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportInvoicesFull(IList invoiceList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                int column = 1;
                //CDA
                datasheet.Cells[1, column++] = "CDA编号";
                datasheet.Cells[1, column++] = "卖方名称";
                datasheet.Cells[1, column++] = "买方名称";
                //转让批次
                datasheet.Cells[1, column++] = "转让批次号";
                datasheet.Cells[1, column++] = "转让批次日";
                datasheet.Cells[1, column++] = "是否生成报文";
                datasheet.Cells[1, column++] = "本次转让备注";
                datasheet.Cells[1, column++] = "转让经办人";
                //转让
                datasheet.Cells[1, column++] = "发票号";
                datasheet.Cells[1, column++] = "票面金额";
                datasheet.Cells[1, column++] = "转让金额";
                datasheet.Cells[1, column++] = "发票日";
                datasheet.Cells[1, column++] = "到期日";
                datasheet.Cells[1, column++] = "是否瑕疵";
                //融资批号
                datasheet.Cells[1, column++] = "融资编号";
                datasheet.Cells[1, column++] = "融资类型";
                datasheet.Cells[1, column++] = "代付行编码";
                datasheet.Cells[1, column++] = "代付行名称";
                datasheet.Cells[1, column++] = "融资币别";
                datasheet.Cells[1, column++] = "融资利率";
                datasheet.Cells[1, column++] = "成本利率";
                datasheet.Cells[1, column++] = "收息方式";
                datasheet.Cells[1, column++] = "本次融资起始日";
                datasheet.Cells[1, column++] = "本次融资到期日";
                datasheet.Cells[1, column++] = "本次融资备注";
                datasheet.Cells[1, column++] = "本次融资经办人";
                //融资
                datasheet.Cells[1, column++] = "融资金额";
                //付款批次
                datasheet.Cells[1, column++] = "付款批次号";
                datasheet.Cells[1, column++] = "付款类型";
                datasheet.Cells[1, column++] = "付款批次日";
                datasheet.Cells[1, column++] = "是否生成报文";
                datasheet.Cells[1, column++] = "本次付款备注";
                datasheet.Cells[1, column++] = "付款经办人";
                //付款
                datasheet.Cells[1, column++] = "付款金额";
                //还款批次
                datasheet.Cells[1, column++] = "还款批次编号";
                datasheet.Cells[1, column++] = "还款类型";
                datasheet.Cells[1, column++] = "还款批次日";
                datasheet.Cells[1, column++] = "本次还款备注";
                datasheet.Cells[1, column++] = "还款经办人";
                //还款
                datasheet.Cells[1, column++] = "还款金额";
                //手续费
                datasheet.Cells[1, column++] = "手续费";
                datasheet.Cells[1, column++] = "手续费收取日";
                //利息
                datasheet.Cells[1, column++] = "利息";
                datasheet.Cells[1, column++] = "利息收取日";
                datasheet.Cells[1, column++] = "备注";

                int size = invoiceList.Count;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (datasheet != null)
                        {
                            Marshal.ReleaseComObject(datasheet);
                            datasheet = null;
                        }

                        if (app != null)
                        {
                            foreach (Workbook wb in app.Workbooks)
                            {
                                wb.Close(false, Type.Missing, Type.Missing);
                            }

                            app.Workbooks.Close();
                            app.Quit();
                            Marshal.ReleaseComObject(app);
                            app = null;
                        }

                        e.Cancel = true;
                        return -1;
                    }

                    column = 1;
                    Invoice invoice = (Invoice)invoiceList[row];
                    //CDA
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CDA.CDACode;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CDA.Case.SellerClient.ToString();
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CDA.Case.BuyerClient.ToString();
                    //转让批次
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.AssignBatchNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.AssignDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.InvoiceAssignBatch.IsCreateMsg);
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CreateUserName;
                    //转让
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                    datasheet.Cells[row + 2, column++] = invoice.DueDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                    //融资批次
                    if (invoice.InvoiceFinanceBatch != null)
                    {
                        column = 15;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinanceBatchNo;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinanceType;
                        if (invoice.InvoiceFinanceBatch.Factor != null)
                        {
                            datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FactorCode;
                            datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.Factor.ToString();
                        }

                        column = 19;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.BatchCurrency;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinanceRate;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.CostRate;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.InterestType;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinancePeriodBegin;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinancePeriodEnd;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.Comment;
                        datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.CreateUserName;
                    }
                    //融资
                    column = 27;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceAmount;
                    //付款批次
                    if (invoice.InvoicePaymentLogs.Count > 0)
                    {
                        column = 28;
                        InvoicePaymentLog log = invoice.InvoicePaymentLogs[0];
                        datasheet.Cells[row + 2, column++] = log.InvoicePaymentBatch.PaymentBatchNo;
                        datasheet.Cells[row + 2, column++] = log.InvoicePaymentBatch.PaymentType;
                        datasheet.Cells[row + 2, column++] = log.InvoicePaymentBatch.PaymentDate;
                        datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(log.InvoicePaymentBatch.IsCreateMsg);
                        datasheet.Cells[row + 2, column++] = log.InvoicePaymentBatch.Comment;
                        datasheet.Cells[row + 2, column++] = log.InvoicePaymentBatch.CreateUserName;
                    }
                    //付款
                    column = 34;
                    datasheet.Cells[row + 2, column++] = invoice.PaymentAmount;
                    //还款批次
                    if (invoice.InvoiceRefundLogs.Count > 0)
                    {
                        column = 35;
                        InvoiceRefundLog log = invoice.InvoiceRefundLogs[0];
                        datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.RefundBatchNo;
                        datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.RefundType;
                        datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.RefundDate;
                        datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.Comment;
                        datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.CreateUserName;
                    }
                    //还款
                    column = 39;
                    datasheet.Cells[row + 2, column++] = invoice.RefundAmount;
                    //手续费
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    datasheet.Cells[row + 2, column++] = invoice.CommissionDate;
                    //利息
                    datasheet.Cells[row + 2, column++] = invoice.Interest;
                    datasheet.Cells[row + 2, column++] = invoice.InterestDate;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 10 || range.Column == 11 || range.Column == 27 || range.Column == 34 || range.Column == 40 || range.Column == 41 || range.Column == 43)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (datasheet != null)
                {
                    Marshal.ReleaseComObject(datasheet);
                    datasheet = null;
                }

                if (app != null)
                {
                    foreach (Workbook wb in app.Workbooks)
                    {
                        wb.Close(false, Type.Missing, Type.Missing);
                    }

                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }

                throw e1;
            }

            return invoiceList.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportInvoicesOverDue(IList invoiceList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                int column = 1;
                datasheet.Cells[1, column++] = "卖方名称";
                datasheet.Cells[1, column++] = "买方名称";
                datasheet.Cells[1, column++] = "发票号";
                datasheet.Cells[1, column++] = "转让金额";
                datasheet.Cells[1, column++] = "发票日";
                datasheet.Cells[1, column++] = "到期日";
                datasheet.Cells[1, column++] = "是否瑕疵";
                datasheet.Cells[1, column++] = "融资金额";
                datasheet.Cells[1, column++] = "融资日";
                datasheet.Cells[1, column++] = "融资到期日";
                datasheet.Cells[1, column++] = "备注";
                datasheet.Cells[1, column++] = "应收帐款逾期天数";
                datasheet.Cells[1, column++] = "预付款逾期天数";

                int size = invoiceList.Count;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (datasheet != null)
                        {
                            Marshal.ReleaseComObject(datasheet);
                            datasheet = null;
                        }

                        if (app != null)
                        {
                            foreach (Workbook wb in app.Workbooks)
                            {
                                wb.Close(false, Type.Missing, Type.Missing);
                            }

                            app.Workbooks.Close();
                            app.Quit();
                            Marshal.ReleaseComObject(app);
                            app = null;
                        }

                        e.Cancel = true;
                        return -1;
                    }

                    column = 1;
                    Invoice invoice = (Invoice)invoiceList[row];
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CDA.Case.SellerClient.ToString();
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CDA.Case.BuyerClient.ToString();
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                    datasheet.Cells[row + 2, column++] = invoice.DueDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                    datasheet.Cells[row + 2, column++] = invoice.FinanceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDate;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDueDate;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.AssignOverDueDays;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceOverDueDays;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 4 || range.Column == 8)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (datasheet != null)
                {
                    Marshal.ReleaseComObject(datasheet);
                    datasheet = null;
                }

                if (app != null)
                {
                    foreach (Workbook wb in app.Workbooks)
                    {
                        wb.Close(false, Type.Missing, Type.Missing);
                    }

                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }

                throw e1;
            }

            return invoiceList.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportPaymentByBatch(IList invoiceList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                int column = 1;
                datasheet.Cells[1, column++] = "发票号";
                datasheet.Cells[1, column++] = "转让余额";
                datasheet.Cells[1, column++] = "付款金额";
                datasheet.Cells[1, column++] = "备注";
                datasheet.Cells[1, column++] = "贷项通知号";
                datasheet.Cells[1, column++] = "贷项通知日";

                int size = invoiceList.Count;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (datasheet != null)
                        {
                            Marshal.ReleaseComObject(datasheet);
                            datasheet = null;
                        }

                        if (app != null)
                        {
                            foreach (Workbook wb in app.Workbooks)
                            {
                                wb.Close(false, Type.Missing, Type.Missing);
                            }

                            app.Workbooks.Close();
                            app.Quit();
                            Marshal.ReleaseComObject(app);
                            app = null;
                        }

                        e.Cancel = true;
                        return -1;
                    }

                    column = 1;
                    Invoice invoice = (Invoice)invoiceList[row];
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.AssignOutstanding;
                    datasheet.Cells[row + 2, column++] = invoice.PaymentAmount2;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;
                    datasheet.Cells[row + 2, column++] = "'" + invoice.CreditNoteNo2;
                    datasheet.Cells[row + 2, column++] = invoice.CreditNoteDate2;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (datasheet != null)
                {
                    Marshal.ReleaseComObject(datasheet);
                    datasheet = null;
                }

                if (app != null)
                {
                    foreach (Workbook wb in app.Workbooks)
                    {
                        wb.Close(false, Type.Missing, Type.Missing);
                    }

                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }

                throw e1;
            }

            return invoiceList.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportRefundByBatch(IList invoiceList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                int column = 1;
                datasheet.Cells[1, column++] = "发票号";
                datasheet.Cells[1, column++] = "融资余额";
                datasheet.Cells[1, column++] = "还款金额";
                datasheet.Cells[1, column++] = "备注";

                int size = invoiceList.Count;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (datasheet != null)
                        {
                            Marshal.ReleaseComObject(datasheet);
                            datasheet = null;
                        }

                        if (app != null)
                        {
                            foreach (Workbook wb in app.Workbooks)
                            {
                                wb.Close(false, Type.Missing, Type.Missing);
                            }

                            app.Workbooks.Close();
                            app.Quit();
                            Marshal.ReleaseComObject(app);
                            app = null;
                        }

                        e.Cancel = true;
                        return -1;
                    }

                    column = 1;
                    Invoice invoice = (Invoice)invoiceList[row];
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceOutstanding;
                    datasheet.Cells[row + 2, column++] = invoice.RefundAmount2;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (datasheet != null)
                {
                    Marshal.ReleaseComObject(datasheet);
                    datasheet = null;
                }

                if (app != null)
                {
                    foreach (Workbook wb in app.Workbooks)
                    {
                        wb.Close(false, Type.Missing, Type.Missing);
                    }

                    app.Workbooks.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }

                throw e1;
            }

            return invoiceList.Count;
        }

        #endregion Methods
    }
}
