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
    using System.Text;
    using System.IO;
    using DevComponents.DotNetBar;
    using System.Drawing;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class ExportForm : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private IList exportData;
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

            /// <summary>
            /// 
            /// </summary>
            EXPORT_MSG09,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_MSG11,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_MSG12,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_CLIENT_REVIEWS,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the ExportForm class
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="exportData"></param>
        public ExportForm(ExportType exportType, IList exportData)
        {
            this.InitializeComponent();
            this.exportType = exportType;
            this.exportData = exportData;

            if (this.exportType == ExportType.EXPORT_MSG09 || this.exportType == ExportType.EXPORT_MSG11 || this.exportType == ExportType.EXPORT_MSG12)
            {
                this.btnFileSelect.Enabled = true;
            }
        }

        #endregion Constructors

        #region Methods (17)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartExport(object sender, EventArgs e)
        {
            string filePath = this.tbFilePath.Text;
            if (filePath.Trim().Equals(String.Empty))
            {
                if (this.exportType == ExportType.EXPORT_MSG09 || this.exportType == ExportType.EXPORT_MSG11 || this.exportType == ExportType.EXPORT_MSG12)
                {
                    return;
                }
            }

            this.btnCancel.Text = "取消";
            this.backgroundWorker.RunWorkerAsync();

            this.btnStart.Enabled = false;
        }
        // Private Methods (16) 

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
                    e.Result = this.ExportCreditNotes(worker, e);
                    break;
                case ExportType.EXPORT_ASSIGN_BY_BATCH:
                    e.Result = this.ExportAssignByBatch(worker, e);
                    break;
                case ExportType.EXPORT_FINANCE_BY_BATCH:
                    e.Result = this.ExportFinanceByBatch(worker, e);
                    break;
                case ExportType.EXPORT_PAYMENT_BY_BATCH:
                    e.Result = this.ExportPaymentByBatch(worker, e);
                    break;
                case ExportType.EXPORT_REFUND_BY_BATCH:
                    e.Result = this.ExportRefundByBatch(worker, e);
                    break;
                case ExportType.EXPORT_INVOICES_FULL:
                    e.Result = this.ExportInvoicesFull(worker, e);
                    break;
                case ExportType.EXPORT_INVOICES_OVERDUE:
                    e.Result = this.ExportInvoicesOverDue(worker, e);
                    break;
                case ExportType.EXPORT_MSG09:
                    e.Result = this.ExportMsg09(worker, e);
                    break;
                case ExportType.EXPORT_MSG11:
                    e.Result = this.ExportMsg11(worker, e);
                    break;
                case ExportType.EXPORT_MSG12:
                    e.Result = this.ExportMsg12(worker, e);
                    break;
                case ExportType.EXPORT_CLIENT_REVIEWS:
                    e.Result = this.ExportClientReviews(worker, e);
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
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportAssignByBatch(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                int size = this.exportData.Count;
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
                    Invoice invoice = (Invoice)exportData[row];
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
                    else if (range.Column == 4 || range.Column == 5 || range.Column == 8)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private object ExportClientReviews(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };

            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }
            app.Visible = true;
            try
            {
                datasheet.Cells[1, 1] = "协查意见台帐";
                datasheet.get_Range("A1", "S1").MergeCells = true;
                datasheet.get_Range("A1", "S1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                int column = 1;
                datasheet.Cells[2, column++] = "回复时间";
                datasheet.Cells[2, column++] = "协查意见编码";
                datasheet.Cells[2, column++] = "区域负责人";
                datasheet.Cells[2, column++] = "归属事业部/分行";
                datasheet.Cells[2, column++] = "归属分部";
                datasheet.Cells[2, column++] = "产品经理";
                datasheet.Cells[2, column++] = "客户名称";
                datasheet.Cells[2, column++] = "所属行业";
                datasheet.Cells[2, column++] = "授信金额（万）";
                datasheet.Cells[2, column++] = "国内";
                datasheet.Cells[2, column++] = "国际";
                datasheet.Cells[2, column++] = "卖方";
                datasheet.Cells[2, column++] = "买方";
                datasheet.Cells[2, column++] = "有追";
                datasheet.Cells[2, column++] = "无追";
                datasheet.Cells[2, column++] = "明保/暗保";
                datasheet.Cells[2, column++] = "预付款";
                datasheet.Cells[2, column++] = "代付";
                datasheet.Cells[2, column++] = "信用证";
                datasheet.Cells[2, column++] = "银承";
                datasheet.Cells[2, column++] = "融资管理";
                datasheet.Cells[2, column++] = "启用状态";
                datasheet.Cells[2, column++] = "保理费";
                datasheet.Cells[2, column++] = "融资期（月）";
                datasheet.Cells[2, column++] = "备注";

                int size = this.exportData.Count;
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
                    ClientReview review = (ClientReview)exportData[row];
                    datasheet.Cells[row + 3, column++] = review.ReviewDate;
                    datasheet.Cells[row + 3, column++] = review.ReviewNo;
                    Department dept = review.Client.Department;
                    if (dept != null)
                    {
                        datasheet.Cells[row + 3, column++] = dept.MarketManager;
                        datasheet.Cells[row + 3, column++] = dept.Domain;
                        datasheet.Cells[row + 3, column++] = dept.Location;
                    }
                    else
                    {
                        datasheet.Cells[row + 3, column++] = "---";
                        datasheet.Cells[row + 3, column++] = "---";
                        datasheet.Cells[row + 3, column++] = "---";
                    }

                    datasheet.Cells[row + 3, column++] = review.Client.PMName;
                    datasheet.Cells[row + 3, column++] = review.Client.ToString();
                    datasheet.Cells[row + 3, column++] = review.Client.Industry;
                    datasheet.get_Range(datasheet.Cells[row + 3, column], datasheet.Cells[row + 3, column]).NumberFormatLocal = TypeUtil.GetExcelCurr(review.RequestCurrency);
                    datasheet.Cells[row + 3, column++] = review.RequestAmount;
                    datasheet.Cells[row + 3, column++] = review.IsLocal.GetValueOrDefault() ? "国内" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsInternational.GetValueOrDefault() ? "国际" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsSeller.GetValueOrDefault() ? "卖方" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsBuyer.GetValueOrDefault() ? "买方" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsRecoarse.GetValueOrDefault() ? "有追" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsNonRecoarse.GetValueOrDefault() ? "无追" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsNotice;
                    string[] financeTypes = review.RequestFinanceType.Split(new char[] { ';' });
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("预付款") ? "预付款" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("代付") ? "代付" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("信用证") ? "信用证" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("银承") ? "银承" : "---";
                    datasheet.Cells[row + 3, column++] = review.RequestFinanceType2;
                    datasheet.Cells[row + 3, column++] = review.Client.Contract != null ? "已启动" : "未启动";
                    datasheet.get_Range(datasheet.Cells[row + 3, column], datasheet.Cells[row + 3, column]).NumberFormatLocal = "0.00%";
                    datasheet.Cells[row + 3, column++] = review.RequestCommissionRate;
                    datasheet.get_Range(datasheet.Cells[row + 3, column], datasheet.Cells[row + 3, column]).NumberFormatLocal = "##月";
                    datasheet.Cells[row + 3, column++] = review.RequestFinancePeriod;
                    datasheet.Cells[row + 3, column++] = review.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 1)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
                    }
                }


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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportCreditNotes(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //Case
                datasheet.Cells[1, column++] = "案件编号";
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

                int size = exportData.Count;
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
                    CreditNote creditNote = (CreditNote)exportData[row];
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.Case.CaseCode;
                    datasheet.Cells[row + 2, column++] = creditNote.InvoicePaymentLogs[0].InvoicePaymentBatch.Case.BuyerClient.ToString();
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
                    else if (range.Column == 4 || range.Column == 11)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportFinanceByBatch(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "备注";

                int size = exportData.Count;
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
                    InvoiceFinanceLog log = (InvoiceFinanceLog)exportData[row];
                    datasheet.Cells[row + 2, column++] = "'" + log.InvoiceNo2;
                    datasheet.Cells[row + 2, column++] = log.AssignOutstanding;
                    datasheet.Cells[row + 2, column++] = log.FinanceAmount;
                    datasheet.Cells[row + 2, column++] = log.Commission;
                    datasheet.Cells[row + 2, column++] = log.CommissionDate;
                    datasheet.Cells[row + 2, column++] = log.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3 || range.Column == 4)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                    else if (range.Column == 5)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportInvoicesFull(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //Case
                datasheet.Cells[1, column++] = "案件编号";
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

                int size = exportData.Count;
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
                    Invoice invoice = (Invoice)exportData[row];
                    //CDA
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.CaseCode;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.SellerClient.ToString();
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.BuyerClient.ToString();
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
                    if (invoice.InvoiceFinanceLogs.Count >0 )
                    {
                        column = 15;
                        InvoiceFinanceLog log = invoice.InvoiceFinanceLogs[0];
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.FinanceBatchNo;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.FinanceType;
                        if (log.InvoiceFinanceBatch.Factor != null)
                        {
                            datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.FactorCode;
                            datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.Factor.ToString();
                        }

                        column = 19;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.BatchCurrency;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.FinanceRate;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.CostRate;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.FinancePeriodBegin;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.FinancePeriodEnd;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.Comment;
                        datasheet.Cells[row + 2, column++] = log.InvoiceFinanceBatch.CreateUserName;
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
                    if (invoice.InvoiceFinanceLogs.Count > 0)
                    {
                        InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[0];
                        if (financeLog.InvoiceRefundLogs.Count > 0)
                        {
                            column = 35;
                            InvoiceRefundLog log = financeLog.InvoiceRefundLogs[0];
                            datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.RefundBatchNo;
                            datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.RefundType;
                            datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.RefundDate;
                            datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.Comment;
                            datasheet.Cells[row + 2, column++] = log.InvoiceRefundBatch.CreateUserName;
                        }
                    }
                    //还款
                    column = 40;
                    datasheet.Cells[row + 2, column++] = invoice.RefundAmount;
                    //手续费
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    datasheet.Cells[row + 2, column++] = invoice.CommissionDate;
                    //利息
                    datasheet.Cells[row + 2, column++] = invoice.NetInterest;
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
                    else if (range.Column == 5 || range.Column == 12 || range.Column == 13 || range.Column == 23 || range.Column == 24 || range.Column == 30 || range.Column == 37 || range.Column == 42)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportInvoicesOverDue(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "转让余额";
                datasheet.Cells[1, column++] = "发票日";
                datasheet.Cells[1, column++] = "到期日";
                datasheet.Cells[1, column++] = "是否瑕疵";
                datasheet.Cells[1, column++] = "融资金额";
                datasheet.Cells[1, column++] = "融资余额";
                datasheet.Cells[1, column++] = "融资日";
                datasheet.Cells[1, column++] = "融资到期日";
                datasheet.Cells[1, column++] = "备注";
                datasheet.Cells[1, column++] = "应收帐款逾期天数";
                datasheet.Cells[1, column++] = "预付款逾期天数";

                int size = exportData.Count;
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
                    Invoice invoice = (Invoice)exportData[row];
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.SellerClient.ToString();
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.BuyerClient.ToString();
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                    datasheet.Cells[row + 2, column++] = invoice.AssignOutstanding;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                    datasheet.Cells[row + 2, column++] = invoice.DueDate;
                    if (invoice.AssignOverDueDays >= 0)
                    {
                        ((Range)datasheet.Cells[row + 2, column - 1]).Interior.ColorIndex = 6;
                    }
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                    datasheet.Cells[row + 2, column++] = invoice.FinanceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceOutstanding;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDate;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDueDate;
                    if (invoice.FinanceOverDueDays >= 0)
                    {
                        ((Range)datasheet.Cells[row + 2, column - 1]).Interior.ColorIndex = 3;
                    }
                    datasheet.Cells[row + 2, column++] = invoice.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.AssignOverDueDays;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceOverDueDays;
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 4 || range.Column == 5 || range.Column == 9 || range.Column == 10)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                    else if (range.Column == 6 || range.Column == 7 || range.Column == 11 || range.Column == 12)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportMsg09(BackgroundWorker worker, DoWorkEventArgs e)
        {
            string filePath = this.tbFilePath.Text;
            StreamWriter fileWriter = new StreamWriter(filePath, false, Encoding.ASCII);

            int size = exportData.Count;
            for (int row = 0; row < size; row++)
            {
                if (worker.CancellationPending)
                {
                    fileWriter.Close();
                    e.Cancel = true;
                    return -1;
                }

                Invoice invoice = (Invoice)exportData[row];
                StringBuilder sb = new StringBuilder();
                Case curCase = invoice.InvoiceAssignBatch.Case;
                sb.Append(((int)row / 1000 + 1)).Append(',');
                sb.Append("MSG09").Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                sb.Append(User.GetEDIAccount(invoice.InvoiceAssignBatch.CreateUserName)).Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                sb.Append(curCase.SellerFactor.CompanyNameEN).Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                sb.Append(curCase.BuyerFactor.CompanyNameEN).Append(',');
                sb.Append(invoice.AssignBatchNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", invoice.InvoiceAssignBatch.AssignDate)).Append(',');
                sb.Append(invoice.InvoiceAssignBatch.BatchCurrency).Append(',');
                sb.Append(invoice.InvoiceAssignBatch.AssignAmount).Append(',');
                sb.Append(',');//CreditNote
                sb.Append(curCase.SellerCode).Append(',');
                sb.Append(curCase.SellerClient.ClientNameEN).Append(',');
                sb.Append(curCase.BuyerCode).Append(',');
                sb.Append(curCase.BuyerClient.ClientNameEN).Append(',');
                sb.Append(1).Append(',');
                sb.Append(invoice.InvoiceNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", invoice.InvoiceDate)).Append(',');
                sb.Append(invoice.InvoiceAmount).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", invoice.DueDate)).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", invoice.ValueDate)).Append(',');
                sb.Append(curCase.NetPaymentTerm).Append(',');
                sb.Append(invoice.PrimaryDiscountDays).Append(',');
                sb.Append(invoice.PrimaryDiscountRate).Append(',');
                sb.Append(invoice.SecondaryDiscountDays).Append(',');
                sb.Append(invoice.SecondaryDiscountRate).Append(',');
                sb.Append(invoice.PaymentConditions).Append(',');
                sb.Append(invoice.OrderNumberReference).Append(',');
                sb.Append(invoice.InvoiceReferenceNumber).Append(',');
                sb.Append(invoice.InvoiceAssignBatch.BatchCount).Append(',');
                sb.Append(0).Append(',');//Total of CreditNote
                sb.Append(invoice.Comment).Append(' ');

                fileWriter.WriteLine(sb.ToString());

                worker.ReportProgress((int)((float)row * 100 / (float)size));
            }

            fileWriter.Flush();
            fileWriter.Close();
            return this.exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportMsg11(BackgroundWorker worker, DoWorkEventArgs e)
        {
            string filePath = this.tbFilePath.Text;
            StreamWriter fileWriter = new StreamWriter(filePath, false, Encoding.ASCII);

            int size = exportData.Count;
            for (int row = 0; row < size; row++)
            {
                if (worker.CancellationPending)
                {
                    fileWriter.Close();
                    e.Cancel = true;
                    return -1;
                }

                InvoicePaymentLog log = (InvoicePaymentLog)exportData[row];
                StringBuilder sb = new StringBuilder();
                Case curCase = log.Invoice.InvoiceAssignBatch.Case;
                sb.Append(((int)row / 1000 + 1)).Append(',');
                sb.Append("MSG11").Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                sb.Append(User.GetEDIAccount(log.Invoice.InvoiceAssignBatch.CreateUserName)).Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                sb.Append(curCase.SellerFactor.CompanyNameEN).Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                sb.Append(curCase.BuyerFactor.CompanyNameEN).Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentBatchNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(log.Invoice.InvoiceCurrency).Append(',');
                sb.Append(curCase.SellerCode).Append(',');
                sb.Append(curCase.SellerClient.ClientNameEN).Append(',');
                sb.Append(curCase.BuyerCode).Append(',');
                sb.Append(curCase.BuyerClient.ClientNameEN).Append(',');
                sb.Append(1).Append(',');
                sb.Append(log.InvoiceNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.Invoice.InvoiceDate)).Append(',');
                sb.Append(log.Invoice.InvoiceAmount).Append(',');
                sb.Append(log.PaymentAmount).Append(',');
                sb.Append(0).Append(',');
                sb.Append(0).Append(',');
                if (TypeUtil.GreaterZero(log.Invoice.AssignOutstanding))
                {
                    sb.Append(2).Append(',');
                }
                else if (TypeUtil.EqualsZero(log.Invoice.AssignOutstanding) && log.Invoice.InvoicePaymentLogs.Count > 1)
                {
                    sb.Append(2).Append(',');
                }
                else
                {
                    sb.Append(1).Append(',');
                }
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentAmount).Append(',');
                sb.Append(0).Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentAmount).Append(',');
                sb.Append(log.InvoicePaymentBatch.Comment).Append(' ');

                fileWriter.WriteLine(sb.ToString());

                worker.ReportProgress((int)((float)row * 100 / (float)size));
            }

            fileWriter.Flush();
            fileWriter.Close();
            return this.exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportMsg12(BackgroundWorker worker, DoWorkEventArgs e)
        {
            string filePath = this.tbFilePath.Text;
            StreamWriter fileWriter = new StreamWriter(filePath, false, Encoding.ASCII);

            int size = exportData.Count;
            for (int row = 0; row < size; row++)
            {
                if (worker.CancellationPending)
                {
                    fileWriter.Close();
                    e.Cancel = true;
                    return -1;
                }

                InvoicePaymentLog log = (InvoicePaymentLog)exportData[row];
                StringBuilder sb = new StringBuilder();
                Case curCase = log.Invoice.InvoiceAssignBatch.Case;
                sb.Append(((int)row / 1000 + 1)).Append(',');
                sb.Append("MSG11").Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                sb.Append(User.GetEDIAccount(log.Invoice.InvoiceAssignBatch.CreateUserName)).Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                sb.Append(curCase.SellerFactor.CompanyNameEN).Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                sb.Append(curCase.BuyerFactor.CompanyNameEN).Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentBatchNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(log.Invoice.InvoiceCurrency).Append(',');
                sb.Append(curCase.SellerCode).Append(',');
                sb.Append(curCase.SellerClient.ClientNameEN).Append(',');
                sb.Append(curCase.BuyerCode).Append(',');
                sb.Append(curCase.BuyerClient.ClientNameEN).Append(',');
                sb.Append(1).Append(',');
                sb.Append(log.InvoiceNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.Invoice.InvoiceDate)).Append(',');
                sb.Append(log.Invoice.InvoiceAmount).Append(',');
                sb.Append(log.PaymentAmount).Append(',');
                sb.Append(0).Append(',');
                sb.Append(0).Append(',');
                if (TypeUtil.GreaterZero(log.Invoice.AssignOutstanding))
                {
                    sb.Append(2).Append(',');
                }
                else if (TypeUtil.EqualsZero(log.Invoice.AssignOutstanding) && log.Invoice.InvoicePaymentLogs.Count > 1)
                {
                    sb.Append(2).Append(',');
                }
                else
                {
                    sb.Append(1).Append(',');
                }
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentAmount).Append(',');
                sb.Append(0).Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentAmount).Append(',');
                sb.Append(log.InvoicePaymentBatch.Comment).Append(' ');

                fileWriter.WriteLine(sb.ToString());

                worker.ReportProgress((int)((float)row * 100 / (float)size));
            }

            fileWriter.Flush();
            fileWriter.Close();
            return this.exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportPaymentByBatch(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                int size = exportData.Count;
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
                    InvoicePaymentLog log = (InvoicePaymentLog)exportData[row];
                    datasheet.Cells[row + 2, column++] = "'" + log.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = log.AssignOutstanding;
                    datasheet.Cells[row + 2, column++] = log.PaymentAmount;
                    datasheet.Cells[row + 2, column++] = log.Comment;
                    datasheet.Cells[row + 2, column++] = "'" + log.CreditNoteNo2;
                    datasheet.Cells[row + 2, column++] = log.CreditNoteDate2;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3)
                    {
                        range.NumberFormatLocal = "0.00";
                    }
                    else if (range.Column == 6)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportRefundByBatch(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                int size = exportData.Count;
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
                    InvoiceRefundLog log = (InvoiceRefundLog)exportData[row];
                    datasheet.Cells[row + 2, column++] = "'" + log.InvoiceFinanceLog.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = log.FinanceOutstanding;
                    datasheet.Cells[row + 2, column++] = log.RefundAmount;
                    datasheet.Cells[row + 2, column++] = log.Comment;

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

            return exportData.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFile(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbFilePath.Text = fileDialog.FileName;
            }
        }

        #endregion Methods
    }
}
