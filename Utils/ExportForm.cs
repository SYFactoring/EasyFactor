//-----------------------------------------------------------------------
// <copyright file="ExportForm.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using DevComponents.DotNetBar;
    using Microsoft.Office.Interop.Excel;

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

            /// <summary>
            /// 
            /// </summary>
            EXPORT_CLIENT,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_CREDIT_COVER_NEG,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_LEGER,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_CASES,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_CDAS
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

            if (this.exportType == ExportType.EXPORT_MSG09 || this.exportType == ExportType.EXPORT_MSG11 || this.exportType == ExportType.EXPORT_MSG12 || this.exportType == ExportType.EXPORT_LEGER)
            {
                this.btnFileSelect.Enabled = true;
            }
        }

        #endregion Constructors

        #region Methods (21)

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
                if (this.exportType == ExportType.EXPORT_MSG09 || this.exportType == ExportType.EXPORT_MSG11 || this.exportType == ExportType.EXPORT_MSG12 || this.exportType == ExportType.EXPORT_LEGER)
                {
                    this.tbStatus.Text = "请先选择保存路径";
                    return;
                }
            }
            else if (this.exportType == ExportType.EXPORT_LEGER)
            {
                DirectoryInfo info = new DirectoryInfo(filePath);
                if (info.Parent == null)
                {
                    this.tbStatus.Text = "不要选择硬盘根目录";
                    return;
                }
            }


            this.btnCancel.Text = "取消";
            this.backgroundWorker.RunWorkerAsync();

            this.btnStart.Enabled = false;
        }
        // Private Methods (20) 

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
                case ExportType.EXPORT_CLIENT:
                    e.Result = this.ExportClients(worker, e);
                    break;
                case ExportType.EXPORT_CREDIT_COVER_NEG:
                    e.Result = this.ExportCreditCoverNegs(worker, e);
                    break;
                case ExportType.EXPORT_LEGER:
                    e.Result = this.ExportLegers(worker, e);
                    break;
                case ExportType.EXPORT_CASES:
                    e.Result = this.ExportCases(worker, e);
                    break;
                case ExportType.EXPORT_CDAS:
                    e.Result = this.ExportCDAs(worker, e);
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
                    datasheet.Cells[row + 2, column++] = invoice.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3 || range.Column == 7)
                    {
                        range.NumberFormatLocal = "#,##0.00";
                    }
                    else if (range.Column == 4 || range.Column == 5)
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
        private object ExportCDAs(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };

            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Workbook workbook = null;

            try
            {
                workbook = app.Workbooks.Add(true);
                Worksheet sheetLocal = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                sheetLocal.Name = "国内";

                Worksheet sheetInternal = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                sheetInternal.Name = "国际";

                if (sheetInternal == null || sheetLocal == null)
                {
                    return -1;
                }

                int column = 1;
                sheetInternal.Cells[1, column++] = "业务类型";
                sheetInternal.Cells[1, column++] = "是否有追索权";
                sheetInternal.Cells[1, column++] = "明/暗保理";
                sheetInternal.Cells[1, column++] = "新旧合同";
                sheetInternal.Cells[1, column++] = "合同编号";
                sheetInternal.Cells[1, column++] = "主合同生效日";
                sheetInternal.Cells[1, column++] = "主合同到期日";
                sheetInternal.Cells[1, column++] = "CDA编号";
                sheetInternal.Cells[1, column++] = "卖方名称";
                sheetInternal.Cells[1, column++] = "买方名称";
                sheetInternal.Cells[1, column++] = "买方地址";
                sheetInternal.Cells[1, column++] = "签发日期";
                sheetInternal.Cells[1, column++] = "付款方式";
                sheetInternal.Cells[1, column++] = "买方信用风险额度币别";
                sheetInternal.Cells[1, column++] = "信用风险额度";
                sheetInternal.Cells[1, column++] = "有效期限(始)";
                sheetInternal.Cells[1, column++] = "有效期限(终)";
                sheetInternal.Cells[1, column++] = "预付款额度币别";
                sheetInternal.Cells[1, column++] = "保理预付款额度";
                sheetInternal.Cells[1, column++] = "有效期限（始）";
                sheetInternal.Cells[1, column++] = "有效期限（终）";
                sheetInternal.Cells[1, column++] = "最高保理预付款额度";
                sheetInternal.Cells[1, column++] = "预付比例";
                sheetInternal.Cells[1, column++] = "保理费率";
                sheetInternal.Cells[1, column++] = "计费方式";
                sheetInternal.Cells[1, column++] = "单据处理费币别";
                sheetInternal.Cells[1, column++] = "单据处理费";
                sheetInternal.Cells[1, column++] = "备注";
                sheetInternal.Cells[1, column++] = "进口保理商";

                column = 1;
                sheetLocal.Cells[1, column++] = "业务类型";
                sheetLocal.Cells[1, column++] = "是否有追索权";
                sheetLocal.Cells[1, column++] = "明/暗保理";
                sheetLocal.Cells[1, column++] = "新旧合同";
                sheetLocal.Cells[1, column++] = "合同编号";
                sheetLocal.Cells[1, column++] = "主合同生效日";
                sheetLocal.Cells[1, column++] = "主合同到期日";
                sheetLocal.Cells[1, column++] = "CDA编号";
                sheetLocal.Cells[1, column++] = "卖方名称";
                sheetLocal.Cells[1, column++] = "买方名称";
                sheetLocal.Cells[1, column++] = "买方地址";
                sheetLocal.Cells[1, column++] = "签发日期";
                sheetLocal.Cells[1, column++] = "付款方式";
                sheetLocal.Cells[1, column++] = "买方信用风险额度币别";
                sheetLocal.Cells[1, column++] = "信用风险额度";
                sheetLocal.Cells[1, column++] = "有效期限(始)";
                sheetLocal.Cells[1, column++] = "有效期限(终)";
                sheetLocal.Cells[1, column++] = "预付款额度币别";
                sheetLocal.Cells[1, column++] = "保理预付款额度";
                sheetLocal.Cells[1, column++] = "有效期限（始）";
                sheetLocal.Cells[1, column++] = "有效期限（终）";
                sheetLocal.Cells[1, column++] = "最高保理预付款额度";
                sheetLocal.Cells[1, column++] = "预付比例";
                sheetLocal.Cells[1, column++] = "保理费率";
                sheetLocal.Cells[1, column++] = "计费方式";
                sheetLocal.Cells[1, column++] = "单据处理费币别";
                sheetLocal.Cells[1, column++] = "单据处理费";
                sheetLocal.Cells[1, column++] = "备注";

                int size = this.exportData.Count;
                int inter = 0;
                int local = 0;
                for (int row = 0; row < size; row++)
                {
                    if (worker.CancellationPending)
                    {
                        if (sheetInternal != null)
                        {
                            Marshal.ReleaseComObject(sheetInternal);
                            sheetInternal = null;
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
                    CDA cda = (CDA)exportData[row];

                    Worksheet sheet = null;
                    int rowID = 0;
                    if (cda.TransactionType == "进口保理" || cda.TransactionType == "出口保理" || cda.TransactionType == "国际信保保理")
                    {
                        rowID = ++inter;
                        sheet = sheetInternal;
                    }
                    else
                    {
                        rowID = ++local;
                        sheet = sheetLocal;
                    }

                    sheet.Cells[rowID + 1, column++] = cda.TransactionType;
                    sheet.Cells[rowID + 1, column++] = TypeUtil.ConvertBoolToStr(cda.IsRecoarse);
                    sheet.Cells[rowID + 1, column++] = cda.IsNotice;
                    Contract contract = cda.Case.SellerClient.Contract;
                    if (contract != null)
                    {
                        sheet.Cells[rowID + 1, column++] = contract.ContractType;
                        sheet.Cells[rowID + 1, column++] = contract.ContractCode;
                        sheet.Cells[rowID + 1, column++] = contract.ContractValueDate;
                        sheet.Cells[rowID + 1, column++] = contract.ContractDueDate;
                    }
                    else
                    {
                        sheet.Cells[rowID + 1, column++] = String.Empty;
                        sheet.Cells[rowID + 1, column++] = String.Empty;
                        sheet.Cells[rowID + 1, column++] = String.Empty;
                        sheet.Cells[rowID + 1, column++] = String.Empty;
                    }

                    sheet.Cells[rowID + 1, column++] = cda.CDACode;
                    sheet.Cells[rowID + 1, column++] = cda.SellerName;
                    sheet.Cells[rowID + 1, column++] = cda.BuyerName;
                    sheet.Cells[rowID + 1, column++] = cda.Case.BuyerClient.Address;
                    sheet.Cells[rowID + 1, column++] = cda.CDASignDate;
                    sheet.Cells[rowID + 1, column++] = cda.PaymentTerms;
                    sheet.Cells[rowID + 1, column++] = cda.CreditCoverCurr;
                    sheet.Cells[rowID + 1, column++] = cda.CreditCover;
                    sheet.Cells[rowID + 1, column++] = cda.CreditCoverPeriodBegin;
                    sheet.Cells[rowID + 1, column++] = cda.CreditCoverPeriodEnd;
                    sheet.Cells[rowID + 1, column++] = cda.FinanceLineCurr;
                    sheet.Cells[rowID + 1, column++] = cda.FinanceLine;
                    sheet.Cells[rowID + 1, column++] = cda.FinanceLinePeriodBegin;
                    sheet.Cells[rowID + 1, column++] = cda.FinanceLinePeriodEnd;
                    sheet.Cells[rowID + 1, column++] = cda.HighestFinanceLine;
                    sheet.Cells[rowID + 1, column++] = cda.PUGProportion;
                    sheet.Cells[rowID + 1, column++] = cda.Price;
                    sheet.Cells[rowID + 1, column++] = cda.CommissionType;
                    sheet.Cells[rowID + 1, column++] = cda.HandFeeCurr;
                    sheet.Cells[rowID + 1, column++] = cda.HandFee;
                    sheet.Cells[rowID + 1, column++] = cda.Comment;

                    if (sheet == sheetInternal)
                    {
                        sheet.Cells[rowID + 1, column++] = cda.Case.BuyerFactor.ToString();
                    }

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in sheetInternal.UsedRange.Columns)
                {
                    if (range.Column == 6 || range.Column == 7 || range.Column == 12 || range.Column == 16 || range.Column == 17 || range.Column == 20 || range.Column == 21)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
                    }
                    else if (range.Column == 15 || range.Column == 19 || range.Column == 22 || range.Column == 27)
                    {
                        range.NumberFormatLocal = "#,##0.00";
                    }
                    else if (range.Column == 23)
                    {
                        range.NumberFormatLocal = "0%";
                    }
                    else if (range.Column == 24)
                    {
                        range.NumberFormatLocal = "0.000%";
                    }

                    range.EntireColumn.AutoFit();

                }

                foreach (Range range in sheetLocal.UsedRange.Columns)
                {
                    if (range.Column == 6 || range.Column == 7 || range.Column == 12 || range.Column == 16 || range.Column == 17 || range.Column == 20 || range.Column == 21)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
                    }
                    else if (range.Column == 15 || range.Column == 19 || range.Column == 22 || range.Column == 27)
                    {
                        range.NumberFormatLocal = "#,##0.00";
                    }
                    else if (range.Column == 23)
                    {
                        range.NumberFormatLocal = "0%";
                    }
                    else if (range.Column == 24)
                    {
                        range.NumberFormatLocal = "0.000%";
                    }

                    range.EntireColumn.AutoFit();
                }

                foreach (Range range in sheetInternal.UsedRange.Rows)
                {
                    range.EntireRow.AutoFit();
                }

                foreach (Range range in sheetLocal.UsedRange.Rows)
                {
                    range.EntireRow.AutoFit();
                }

                app.Visible = true;
            }
            catch (Exception e1)
            {
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
        private object ExportCases(BackgroundWorker worker, DoWorkEventArgs e)
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
                datasheet.Cells[1, column++] = "案件编号";
                datasheet.Cells[1, column++] = "卖方保理代码";
                datasheet.Cells[1, column++] = "卖方名称";
                datasheet.Cells[1, column++] = "卖方保理商代码";
                datasheet.Cells[1, column++] = "卖方保理商";
                datasheet.Cells[1, column++] = "买方保理代码";
                datasheet.Cells[1, column++] = "买方名称";
                datasheet.Cells[1, column++] = "买方保理商代码";
                datasheet.Cells[1, column++] = "买方保理商";
                datasheet.Cells[1, column++] = "发票币别";
                datasheet.Cells[1, column++] = "业务类型";
                datasheet.Cells[1, column++] = "操作类型";
                datasheet.Cells[1, column++] = "业务归属机构";
                datasheet.Cells[1, column++] = "申请日期";
                datasheet.Cells[1, column++] = "案件状态";
                datasheet.Cells[1, column++] = "OP人员";

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
                    Case selectedCase = (Case)exportData[row];
                    datasheet.Cells[row + 2, column++] = selectedCase.CaseCode;
                    datasheet.Cells[row + 2, column++] = selectedCase.SellerCode;
                    datasheet.Cells[row + 2, column++] = selectedCase.SellerClient.ToString();
                    datasheet.Cells[row + 2, column++] = selectedCase.SellerFactorCode;
                    datasheet.Cells[row + 2, column++] = selectedCase.SellerFactor.ToString();
                    datasheet.Cells[row + 2, column++] = selectedCase.BuyerCode;
                    datasheet.Cells[row + 2, column++] = selectedCase.BuyerClient.ToString();
                    datasheet.Cells[row + 2, column++] = selectedCase.BuyerFactorCode;
                    datasheet.Cells[row + 2, column++] = selectedCase.BuyerFactor.ToString();
                    datasheet.Cells[row + 2, column++] = selectedCase.InvoiceCurrency;
                    datasheet.Cells[row + 2, column++] = selectedCase.TransactionType;
                    datasheet.Cells[row + 2, column++] = selectedCase.OperationType;
                    datasheet.Cells[row + 2, column++] = selectedCase.OwnerDepartment.DepartmentName;
                    datasheet.Cells[row + 2, column++] = selectedCase.CaseAppDate;
                    datasheet.Cells[row + 2, column++] = selectedCase.CaseMark;
                    datasheet.Cells[row + 2, column++] = selectedCase.OPName;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 15)
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
                    datasheet.Cells[row + 3, column++] = review.IsLocal ? "国内" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsInternational ? "国际" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsSeller ? "卖方" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsBuyer ? "买方" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsRecoarse ? "有追" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsNonRecoarse ? "无追" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsNotice;
                    string[] financeTypes = review.RequestFinanceType.Split(new char[] { ';' });
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("预付款") ? "预付款" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("代付") ? "代付" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("信用证") ? "信用证" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("银承") ? "银承" : "---";
                    datasheet.Cells[row + 3, column++] = review.RequestFinanceType2;
                    datasheet.Cells[row + 3, column++] = review.Client.Contract != null ? "已启动" : "未启动";
                    datasheet.get_Range(datasheet.Cells[row + 3, column], datasheet.Cells[row + 3, column]).NumberFormatLocal = "0.000%";
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
        private object ExportClients(BackgroundWorker worker, DoWorkEventArgs e)
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
                datasheet.Cells[1, column++] = "客户号";
                datasheet.Cells[1, column++] = "保理代码";
                datasheet.Cells[1, column++] = "客户名称(中)";
                datasheet.Cells[1, column++] = "客户名称(英)";
                datasheet.Cells[1, column++] = "地址(中)";
                datasheet.Cells[1, column++] = "地址(英)";
                datasheet.Cells[1, column++] = "所在城市(中)";
                datasheet.Cells[1, column++] = "所在城市(英)";
                datasheet.Cells[1, column++] = "所在省/州(中)";
                datasheet.Cells[1, column++] = "所在省/州(英)";
                datasheet.Cells[1, column++] = "邮编";
                datasheet.Cells[1, column++] = "所在国";
                datasheet.Cells[1, column++] = "公司法人/责任人";
                datasheet.Cells[1, column++] = "公司网址";
                datasheet.Cells[1, column++] = "联系人";
                datasheet.Cells[1, column++] = "联系电话";
                datasheet.Cells[1, column++] = "E-MAIL";
                datasheet.Cells[1, column++] = "传真号码";
                datasheet.Cells[1, column++] = "手机号码";
                datasheet.Cells[1, column++] = "客户类型";
                datasheet.Cells[1, column++] = "行业类别";
                datasheet.Cells[1, column++] = "经营范围(中)";
                datasheet.Cells[1, column++] = "经营范围(英)";
                datasheet.Cells[1, column++] = "客户级别";
                datasheet.Cells[1, column++] = "所属集团客户保理代码";
                datasheet.Cells[1, column++] = "所属集团客户名称";
                datasheet.Cells[1, column++] = "营业执照号码";
                datasheet.Cells[1, column++] = "组织机构代码";
                datasheet.Cells[1, column++] = "所属机构";
                datasheet.Cells[1, column++] = "产品经理";
                datasheet.Cells[1, column++] = "客户经理";
                datasheet.Cells[1, column++] = "备注";
                datasheet.Cells[1, column++] = "经办人";

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
                    Client client = (Client)exportData[row];
                    datasheet.Cells[row + 2, column++] = client.ClientCoreNo;
                    datasheet.Cells[row + 2, column++] = client.ClientEDICode;
                    datasheet.Cells[row + 2, column++] = client.ClientNameCN;
                    datasheet.Cells[row + 2, column++] = client.ClientNameEN;
                    datasheet.Cells[row + 2, column++] = client.AddressCN;
                    datasheet.Cells[row + 2, column++] = client.AddressEN;
                    datasheet.Cells[row + 2, column++] = client.CityCN;
                    datasheet.Cells[row + 2, column++] = client.CityEN;
                    datasheet.Cells[row + 2, column++] = client.ProvinceCN;
                    datasheet.Cells[row + 2, column++] = client.ProvinceEN;
                    datasheet.Cells[row + 2, column++] = client.PostCode;
                    datasheet.Cells[row + 2, column++] = client.CountryCode;
                    datasheet.Cells[row + 2, column++] = client.Representative;
                    datasheet.Cells[row + 2, column++] = client.Website;
                    datasheet.Cells[row + 2, column++] = client.Contact;
                    datasheet.Cells[row + 2, column++] = client.Telephone;
                    datasheet.Cells[row + 2, column++] = client.Email;
                    datasheet.Cells[row + 2, column++] = client.FaxNumber;
                    datasheet.Cells[row + 2, column++] = client.CellPhone;
                    datasheet.Cells[row + 2, column++] = client.ClientType;
                    datasheet.Cells[row + 2, column++] = client.Industry;
                    datasheet.Cells[row + 2, column++] = client.ProductCN;
                    datasheet.Cells[row + 2, column++] = client.ProductEN;
                    datasheet.Cells[row + 2, column++] = client.ClientLevel;
                    datasheet.Cells[row + 2, column++] = client.ClientGroup == null ? string.Empty : client.ClientGroup.ClientEDICode;
                    datasheet.Cells[row + 2, column++] = client.ClientGroup == null ? string.Empty : client.ClientGroup.ClientNameCN;
                    datasheet.Cells[row + 2, column++] = client.RegistrationNumber;
                    datasheet.Cells[row + 2, column++] = client.CompanyCode;
                    datasheet.Cells[row + 2, column++] = client.Department == null ? string.Empty : client.Department.DepartmentName;
                    datasheet.Cells[row + 2, column++] = client.PMName;
                    datasheet.Cells[row + 2, column++] = client.RMName;
                    datasheet.Cells[row + 2, column++] = client.Comment;
                    datasheet.Cells[row + 2, column++] = client.CreateUserName;

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
        private object ExportCreditCoverNegs(BackgroundWorker worker, DoWorkEventArgs e)
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
                datasheet.Cells[1, column++] = "案件编号";
                datasheet.Cells[1, column++] = "所属地区";
                datasheet.Cells[1, column++] = "卖方名称";
                datasheet.Cells[1, column++] = "买方名称";
                datasheet.Cells[1, column++] = "合作保理商";
                datasheet.Cells[1, column++] = "P/C标志";
                datasheet.Cells[1, column++] = "申请额度";
                datasheet.Cells[1, column++] = "付款条件";
                datasheet.Cells[1, column++] = "申请日期";
                datasheet.Cells[1, column++] = "回复额度";
                datasheet.Cells[1, column++] = "回复日期";
                datasheet.Cells[1, column++] = "IF报价";
                datasheet.Cells[1, column++] = "报价日";
                datasheet.Cells[1, column++] = "额度期限";
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
                    CreditCoverNegotiation creditCoverNeg = (CreditCoverNegotiation)exportData[row];
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.Case.CaseCode;//1
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.Case.OwnerDepartment.Location;//2
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.Case.SellerClient.ToString();//3
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.Case.BuyerClient.ToString();//4
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.Case.Factor.ToString();//5
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.RequestType;//6
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.RequestAmount;//7
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.NetPaymentTerm;//8
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.RequestDate;//9
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.ReplyAmount;//10
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.ReplyDate;//11
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.IFPrice;//12
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.PriceDate;//13
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.DueDate;//14
                    datasheet.Cells[row + 2, column++] = creditCoverNeg.Comment;//15

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 9 || range.Column == 11 || range.Column == 13 || range.Column == 14)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
                    }
                    else if (range.Column == 7 || range.Column == 8 || range.Column == 10)
                    {
                        range.NumberFormatLocal = "#,##0";
                    }
                    else if (range.Column == 12)
                    {
                        range.NumberFormatLocal = "0.000%";
                    }
                }

                datasheet.UsedRange.WrapText = false;
                datasheet.UsedRange.Borders.LineStyle = 1;
                datasheet.UsedRange.Font.Name = "仿宋_GB2312";
                datasheet.UsedRange.Font.Size = 12;

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
                        range.NumberFormatLocal = "#,##0.00";
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
                    datasheet.Cells[row + 2, column++] = log.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3 || range.Column == 4)
                    {
                        range.NumberFormatLocal = "#,##0.00";
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
                //利息
                datasheet.Cells[1, column++] = "利息";
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
                    int recordStep = 0;
                    for (int i = 0; i < invoice.InvoiceFinanceLogs.Count; i++)
                    {
                        column = 15;
                        InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[i];
                        datasheet.Cells[row + recordStep + 2, column++] = financeLog.InvoiceFinanceBatch.FinanceBatchNo;
                        datasheet.Cells[row + recordStep + 2, column++] = financeLog.InvoiceFinanceBatch.FinanceType;
                        if (financeLog.InvoiceFinanceBatch.Factor != null)
                        {
                            datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.FactorCode;
                            datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.Factor.ToString();
                        }

                        column = 19;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.BatchCurrency;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.FinanceRate;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.CostRate;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.FinancePeriodBegin;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.FinancePeriodEnd;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.Comment;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.InvoiceFinanceBatch.CreateUserName;

                        //融资
                        column = 26;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.FinanceAmount;

                        //还款批次
                        for (int j = 0; j < financeLog.InvoiceRefundLogs.Count; j++)
                        {
                            column = 34;
                            InvoiceRefundLog log = financeLog.InvoiceRefundLogs[j];
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.RefundBatchNo;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.RefundType;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.RefundDate;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.Comment;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.CreateUserName;

                            //还款
                            column = 39;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.RefundAmount;
                        }

                        recordStep += financeLog.InvoiceRefundLogs.Count;
                    }


                    //付款批次
                    for (int i = 0; i < invoice.InvoicePaymentLogs.Count; i++)
                    {
                        column = 27;
                        InvoicePaymentLog log = invoice.InvoicePaymentLogs[i];
                        datasheet.Cells[row + 2 + i, column++] = log.InvoicePaymentBatch.PaymentBatchNo;
                        datasheet.Cells[row + 2 + i, column++] = log.InvoicePaymentBatch.PaymentType;
                        datasheet.Cells[row + 2 + i, column++] = log.InvoicePaymentBatch.PaymentDate;
                        datasheet.Cells[row + 2 + i, column++] = TypeUtil.ConvertBoolToStr(log.InvoicePaymentBatch.IsCreateMsg);
                        datasheet.Cells[row + 2 + i, column++] = log.InvoicePaymentBatch.Comment;
                        datasheet.Cells[row + 2 + i, column++] = log.InvoicePaymentBatch.CreateUserName;

                        //付款
                        column = 33;
                        datasheet.Cells[row + 2 + i, column++] = log.PaymentAmount;
                    }

                    column = 40;

                    //手续费
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    //利息
                    datasheet.Cells[row + 2, column++] = invoice.NetInterest;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    if (range.Column == 10 || range.Column == 11 || range.Column == 26 || range.Column == 33 || range.Column == 39 || range.Column == 40 || range.Column == 41)
                    {
                        range.NumberFormatLocal = "#,##0.00";
                    }
                    else if (range.Column == 5 || range.Column == 12 || range.Column == 13 || range.Column == 22 || range.Column == 23 || range.Column == 29 || range.Column == 36)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
                    }
                    else if (range.Column == 20 || range.Column == 21)
                    {
                        range.NumberFormatLocal = "#0.000%";
                    }

                    range.EntireColumn.AutoFit();
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
                        range.NumberFormatLocal = "#,##0.00";
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
        private int ExportLegers(BackgroundWorker worker, DoWorkEventArgs e)
        {
            List<Case> selectedCases = (List<Case>)exportData;

            IEnumerable<IGrouping<string, Case>> caseGroups = selectedCases.GroupBy(c => c.TransactionType);
            int size = this.exportData.Count;
            int result = 0;
            IEnumerable<IGrouping<Client, Case>> groups = null;
            foreach (IGrouping<string, Case> caseGroup in caseGroups)
            {
                string transactionType = caseGroup.Key;
                switch (transactionType)
                {
                    case "国内卖方保理":
                    case "出口保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                        groups = caseGroup.GroupBy(c => c.SellerClient);
                        foreach (IGrouping<Client, Case> group in groups)
                        {
                            ExportReportLegarImpl(group);
                            result += (int)group.LongCount();
                            worker.ReportProgress((int)((float)result * 100 / (float)size));
                        }

                        break;
                    case "国内买方保理":
                    case "进口保理":
                        groups = caseGroup.GroupBy(c => c.BuyerClient);
                        foreach (IGrouping<Client, Case> group in groups)
                        {
                            ExportReportLegarImpl(group);
                            result += (int)group.LongCount();
                            worker.ReportProgress((int)((float)result * 100 / (float)size));
                        }

                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private int ExportMsg09(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (exportData.Count == 0)
            {
                return 0;
            }

            string fileName = String.Format("{0}\\MSG09-{1}-{2:yyyyMMdd}.csv", this.tbFilePath.Text, ((Invoice)exportData[0]).InvoiceAssignBatch.Case.SellerCode, DateTime.Today);
            StreamWriter fileWriter = new StreamWriter(fileName, false, Encoding.ASCII);

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
                //sb.Append(curCase.SellerFactor.CompanyNameEN).Append(',');
                sb.Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                //sb.Append(curCase.BuyerFactor.CompanyNameEN).Append(',');
                sb.Append(',');
                sb.Append(invoice.AssignBatchNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", invoice.InvoiceAssignBatch.AssignDate)).Append(',');
                sb.Append(invoice.InvoiceAssignBatch.BatchCurrency).Append(',');
                sb.Append(invoice.InvoiceAssignBatch.AssignAmount).Append(',');
                sb.Append(',');//CreditNote
                sb.Append(curCase.SellerCode).Append(',');
                //sb.Append(curCase.SellerClient.ClientNameEN).Append(',');
                sb.Append(',');
                sb.Append(curCase.BuyerCode).Append(',');
                //sb.Append(curCase.BuyerClient.ClientNameEN).Append(',');
                sb.Append(',');
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
            if (exportData.Count == 0)
            {
                return 0;
            }

            string fileName = String.Format("{0}\\MSG11-{1}-{2:yyyyMMdd}.csv", this.tbFilePath.Text, ((InvoicePaymentLog)exportData[0]).InvoicePaymentBatch.Case.SellerCode, DateTime.Today);
            StreamWriter fileWriter = new StreamWriter(fileName, false, Encoding.ASCII);

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
                //sb.Append(curCase.SellerFactor.CompanyNameEN).Append(',');
                sb.Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                //sb.Append(curCase.BuyerFactor.CompanyNameEN).Append(',');
                sb.Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentBatchNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(log.Invoice.InvoiceCurrency).Append(',');
                sb.Append(curCase.SellerCode).Append(',');
                //sb.Append(curCase.SellerClient.ClientNameEN).Append(',');
                sb.Append(',');
                sb.Append(curCase.BuyerCode).Append(',');
                //sb.Append(curCase.BuyerClient.ClientNameEN).Append(',');
                sb.Append(',');
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
            if (exportData.Count == 0)
            {
                return 0;
            }

            string fileName = String.Format("{0}\\MSG12-{1}-{2:yyyyMMdd}.csv", this.tbFilePath.Text, ((InvoicePaymentLog)exportData[0]).InvoicePaymentBatch.Case.SellerCode, DateTime.Today);
            StreamWriter fileWriter = new StreamWriter(fileName, false, Encoding.ASCII);

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
                sb.Append("MSG12").Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                sb.Append(User.GetEDIAccount(log.Invoice.InvoiceAssignBatch.CreateUserName)).Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(',');
                sb.Append(curCase.SellerFactorCode).Append(',');
                //sb.Append(curCase.SellerFactor.CompanyNameEN).Append(',');
                sb.Append(',');
                sb.Append(curCase.BuyerFactorCode).Append(',');
                //sb.Append(curCase.BuyerFactor.CompanyNameEN).Append(',');
                sb.Append(',');
                sb.Append(log.InvoicePaymentBatch.PaymentBatchNo).Append(',');
                sb.Append(String.Format("{0:yyyy-MM-dd}", log.InvoicePaymentBatch.PaymentDate)).Append(',');
                sb.Append(log.Invoice.InvoiceCurrency).Append(',');
                sb.Append(curCase.SellerCode).Append(',');
                //sb.Append(curCase.SellerClient.ClientNameEN).Append(',');
                sb.Append(',');
                sb.Append(curCase.BuyerCode).Append(',');
                //sb.Append(curCase.BuyerClient.ClientNameEN).Append(',');
                sb.Append(',');
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
                    datasheet.Cells[row + 2, column++] = "'" + log.InvoiceNo2;
                    datasheet.Cells[row + 2, column++] = log.AssignOutstanding;
                    datasheet.Cells[row + 2, column++] = log.PaymentAmount;
                    datasheet.Cells[row + 2, column++] = log.Comment;
                    if (log.CreditNote != null)
                    {
                        datasheet.Cells[row + 2, column++] = "'" + log.CreditNoteNo;
                        datasheet.Cells[row + 2, column++] = log.CreditNoteDate;
                    }

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3)
                    {
                        range.NumberFormatLocal = "#,##0.00";
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
                datasheet.Cells[1, column++] = "融资编号";
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
                    datasheet.Cells[row + 2, column++] = "'" + log.InvoiceNo2;
                    datasheet.Cells[row + 2, column++] = log.FinanceLogID2;
                    datasheet.Cells[row + 2, column++] = log.FinanceOutstanding;
                    datasheet.Cells[row + 2, column++] = log.RefundAmount;
                    datasheet.Cells[row + 2, column++] = log.Comment;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 3 || range.Column == 4)
                    {
                        range.NumberFormatLocal = "#,##0.00";
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
        /// <param name="sheet"></param>
        /// <param name="caseGroup"></param>
        private void FillLegarTotalSheet(Worksheet sheet, IGrouping<Client, Case> caseGroup)
        {
            sheet.Cells[9, "A"] = "发票号";
            sheet.Cells[9, "B"] = "转让金额";
            sheet.Cells[9, "C"] = "发票日";
            sheet.Cells[9, "D"] = "到期日";
            sheet.Cells[9, "E"] = "转让日";
            sheet.Cells[9, "F"] = "是否瑕疵";
            sheet.Cells[9, "G"] = "融资金额";
            sheet.Cells[9, "H"] = "融资日";
            sheet.Cells[9, "I"] = "融资到期日";
            sheet.Cells[9, "J"] = "付款金额";
            sheet.Cells[9, "K"] = "账款余额";
            sheet.Cells[9, "L"] = "付款日";
            sheet.Cells[9, "M"] = "还款金额";
            sheet.Cells[9, "N"] = "还款日";
            sheet.Cells[9, "O"] = "手续费";
            sheet.Cells[9, "P"] = "利息";
            sheet.Cells[9, "Q"] = "备注";

            List<string> buyerList = new List<string>();
            List<string> factorList = new List<string>();
            List<string> clientReviewList = new List<string>();
            string creditCoverCurr = null;
            string invoiceCurrency = null;
            string financeLineCurr = null;
            double totalCreditCoverOutstanding = 0;
            double totalAssignOutstanding = 0;
            double totalFinanceLine = 0;
            DateTime dueDate = default(DateTime);
            double totalFinanceLineOutstanding = 0;
            double totalFinanceOutstanding = 0;

            int row = 10;
            foreach (Case selectedCase in caseGroup)
            {
                CDA cda = selectedCase.ActiveCDA;
                buyerList.Add(selectedCase.BuyerClient.ToString());
                string factorName = selectedCase.Factor.ToString();
                if (!factorList.Contains(factorName))
                {
                    factorList.Add(factorName);
                }

                foreach (ClientReview review in selectedCase.ClientReviews)
                {
                    if (!clientReviewList.Contains(review.ReviewNo))
                    {
                        clientReviewList.Add(review.ReviewNo);
                    }
                }

                double creditCoverOutstanding = cda.CreditCoverOutstanding.GetValueOrDefault();
                if (creditCoverCurr == null)
                {
                    creditCoverCurr = cda.CreditCoverCurr;
                }
                else if (cda.CreditCoverCurr != creditCoverCurr)
                {
                    double rate = Exchange.GetExchangeRate(cda.CreditCoverCurr, creditCoverCurr);
                    creditCoverOutstanding *= rate;
                }
                totalCreditCoverOutstanding += creditCoverOutstanding;

                double assignOutstanding = selectedCase.AssignOutstanding;
                if (invoiceCurrency == null)
                {
                    invoiceCurrency = selectedCase.InvoiceCurrency;
                }
                else if (selectedCase.InvoiceCurrency != invoiceCurrency)
                {
                    double rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, invoiceCurrency);
                    assignOutstanding *= rate;
                }
                totalAssignOutstanding += assignOutstanding;

                double financeLine = cda.FinanceLine.GetValueOrDefault();
                if (financeLineCurr == null)
                {
                    financeLineCurr = cda.FinanceLineCurr;
                }
                else if (cda.FinanceLineCurr != financeLineCurr)
                {
                    double rate = Exchange.GetExchangeRate(cda.FinanceLineCurr, financeLineCurr);
                    financeLine *= rate;
                }
                totalFinanceLine += financeLine;

                if (dueDate == default(DateTime))
                {
                    dueDate = cda.FinanceLinePeriodEnd.GetValueOrDefault();
                }
                else if (dueDate > cda.FinanceLinePeriodEnd)
                {
                    dueDate = cda.FinanceLinePeriodEnd.GetValueOrDefault();
                }

                double financeLineOutstanding = cda.FinanceLineOutstanding.GetValueOrDefault();
                if (cda.FinanceLineCurr != financeLineCurr)
                {
                    double rate = Exchange.GetExchangeRate(cda.FinanceLineCurr, financeLineCurr);
                    financeLineOutstanding *= rate;
                }
                totalFinanceLineOutstanding += financeLineOutstanding;

                double financeOutstanding = selectedCase.FinanceOutstanding.GetValueOrDefault();
                if (selectedCase.InvoiceCurrency != invoiceCurrency)
                {
                    double rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, invoiceCurrency);
                    financeOutstanding *= rate;
                }
                totalFinanceLineOutstanding += financeOutstanding;

                foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in batch.Invoices)
                    {
                        int step = 1;
                        sheet.Cells[row, "A"] = "'" + invoice.InvoiceNo;
                        sheet.Cells[row, "B"] = invoice.AssignAmount;
                        sheet.Cells[row, "C"] = invoice.InvoiceDate;
                        sheet.Cells[row, "D"] = invoice.DueDate;
                        sheet.Cells[row, "E"] = batch.AssignDate;
                        sheet.Cells[row, "F"] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);

                        int recordStep = 0;
                        for (int i = 0; i < invoice.InvoiceFinanceLogs.Count; i++)
                        {
                            InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[i];
                            sheet.Cells[row + recordStep, "G"] = financeLog.FinanceAmount;
                            sheet.Cells[row + recordStep, "H"] = financeLog.FinanceDate;
                            sheet.Cells[row + recordStep, "I"] = financeLog.FinanceDueDate;

                            for (int j = 0; j < financeLog.InvoiceRefundLogs.Count; j++)
                            {
                                InvoiceRefundLog refundLog = financeLog.InvoiceRefundLogs[j];
                                sheet.Cells[row + recordStep + j, "M"] = refundLog.RefundAmount;
                                sheet.Cells[row + recordStep + j, "N"] = refundLog.RefundDate;
                            }

                            recordStep += financeLog.InvoiceRefundLogs.Count;
                        }

                        step = step < recordStep ? recordStep : step;

                        for (int i = 0; i < invoice.InvoicePaymentLogs.Count; i++)
                        {
                            InvoicePaymentLog paymentLog = invoice.InvoicePaymentLogs[i];
                            sheet.Cells[row + i, "J"] = paymentLog.PaymentAmount;
                            sheet.Cells[row + i, "L"] = paymentLog.PaymentDate;
                        }

                        step = step < invoice.InvoicePaymentLogs.Count ? invoice.InvoicePaymentLogs.Count : step;

                        sheet.Cells[row, "K"] = invoice.AssignOutstanding;

                        sheet.Cells[row, "O"] = invoice.Commission;
                        sheet.Cells[row, "P"] = invoice.NetInterest;
                        sheet.Cells[row, "Q"] = invoice.Comment;

                        row += step;
                    }
                }

                string currencyFormat = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);
                sheet.get_Range(sheet.Cells[9, "A"], sheet.Cells[row - 1, "Q"]).Borders.LineStyle = 1;
                sheet.get_Range(sheet.Cells[10, "B"], sheet.Cells[row - 1, "B"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "C"], sheet.Cells[row - 1, "C"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "D"], sheet.Cells[row - 1, "D"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "E"], sheet.Cells[row - 1, "E"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "G"], sheet.Cells[row - 1, "G"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "H"], sheet.Cells[row - 1, "H"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "I"], sheet.Cells[row - 1, "I"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "J"], sheet.Cells[row - 1, "J"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "K"], sheet.Cells[row - 1, "K"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "L"], sheet.Cells[row - 1, "L"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "M"], sheet.Cells[row - 1, "M"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "N"], sheet.Cells[row - 1, "N"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "O"], sheet.Cells[row - 1, "O"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "P"], sheet.Cells[row - 1, "P"]).NumberFormatLocal = currencyFormat;
            }

            sheet.get_Range("A4", "I7").Borders.LineStyle = 1;
            sheet.get_Range("L4", "M8").Borders.LineStyle = 1;
            sheet.get_Range("O4", "P8").Borders.LineStyle = 1;

            sheet.get_Range("A1", "Q1").MergeCells = true;
            sheet.get_Range("A1", "A1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[1, "A"] = "销售分户账台账";
            sheet.Cells[2, "P"] = String.Format("单位：{0}", invoiceCurrency);
            sheet.Cells[3, "A"] = "分行/分部";
            sheet.Cells[3, "B"] = "";

            sheet.Cells[4, "A"] = "Seller Name";
            sheet.get_Range("B4", "I4").MergeCells = true;
            sheet.Cells[4, "B"] = caseGroup.Key;
            sheet.Cells[5, "A"] = "Buyer Name";
            sheet.get_Range("B5", "I5").MergeCells = true;
            sheet.Cells[5, "B"] = String.Join(";", buyerList.ToArray());

            sheet.get_Range("B6", "I6").MergeCells = true;
            sheet.Cells[6, "A"] = "Factor Name";
            sheet.Cells[6, "B"] = String.Join(";", factorList.ToArray());

            sheet.get_Range("B7", "I7").MergeCells = true;
            sheet.Cells[7, "A"] = "协查意见书编号";
            sheet.Cells[7, "B"] = String.Join(";", clientReviewList.ToArray());

            sheet.get_Range(sheet.Cells[4, "L"], sheet.Cells[4, "M"]).MergeCells = true;
            sheet.Cells[4, "L"] = "信用风险担保";
            sheet.Cells[5, "L"] = "核准额度";
            // sheet.Cells[5, "M"] = String.Format("{0} {1:N2}", cda.CreditCoverCurr, cda.CreditCover);
            sheet.Cells[6, "L"] = "到期日";
            //sheet.Cells[6, "M"] = String.Format("{0:yyyy-MM-dd}", cda.CreditCoverPeriodEnd);
            sheet.Cells[7, "L"] = "总剩余额度";
            sheet.Cells[7, "M"] = totalCreditCoverOutstanding;
            sheet.get_Range(sheet.Cells[7, "M"], sheet.Cells[7, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(creditCoverCurr);
            sheet.Cells[8, "L"] = "总应收帐款余额";
            sheet.Cells[8, "M"] = totalAssignOutstanding;
            sheet.get_Range(sheet.Cells[8, "M"], sheet.Cells[8, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(invoiceCurrency);

            sheet.get_Range(sheet.Cells[4, "O"], sheet.Cells[4, "P"]).MergeCells = true;
            sheet.Cells[4, "O"] = "融资额度";
            sheet.Cells[5, "O"] = "核准总额度";
            sheet.Cells[5, "P"] = totalFinanceLine;
            sheet.get_Range(sheet.Cells[5, "P"], sheet.Cells[5, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(financeLineCurr);
            sheet.Cells[6, "O"] = "到期日";
            sheet.Cells[6, "P"] = dueDate;
            sheet.get_Range(sheet.Cells[6, "P"], sheet.Cells[6, "P"]).NumberFormatLocal = "yyyy-MM-dd";
            sheet.Cells[7, "O"] = "总剩余额度";
            sheet.Cells[7, "P"] = totalFinanceLineOutstanding;
            sheet.get_Range(sheet.Cells[7, "P"], sheet.Cells[7, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(financeLineCurr);
            sheet.Cells[8, "O"] = "总融资余额";
            sheet.Cells[8, "P"] = totalFinanceOutstanding;
            sheet.get_Range(sheet.Cells[8, "P"], sheet.Cells[8, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(invoiceCurrency);

            foreach (Range range in sheet.UsedRange.Rows)
            {
                range.EntireRow.AutoFit();
            }

            foreach (Range range in sheet.UsedRange.Columns)
            {
                range.EntireColumn.AutoFit();
            }

            sheet.UsedRange.Font.Name = "仿宋";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseGroup"></param>
        private void ExportReportLegarImpl(IGrouping<Client, Case> caseGroup)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Workbook workbook = null;
            try
            {
                workbook = app.Workbooks.Add(true);
                Worksheet totalSheet = (Worksheet)workbook.Sheets[1];
                totalSheet.Name = "总台帐";

                Client client = caseGroup.Key;
                foreach (Case selectedCase in caseGroup)
                {
                    CDA cda = selectedCase.ActiveCDA;

                    if (cda == null)
                    {
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

                        MessageBoxEx.Show("案件没有有效的额度通知书，案件编号：" + selectedCase.CaseCode);

                        return;
                    }

                    Worksheet sheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);

                    string name = selectedCase.TargetClient.ToString();
                    if (name.Length > 30)
                    {
                        name = name.Substring(0, 30);
                    }

                    sheet.Name = name;

                    sheet.get_Range("A1", "Q1").MergeCells = true;
                    sheet.get_Range("A1", "A1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, "A"] = "销售分户账台账";
                    sheet.Cells[2, "P"] = String.Format("单位：{0}", selectedCase.InvoiceCurrency);
                    sheet.Cells[3, "A"] = "分行/分部";
                    sheet.Cells[3, "B"] = selectedCase.OwnerDepartment.DepartmentName;

                    sheet.Cells[4, "A"] = "Seller Name";
                    sheet.get_Range("B4", "F4").MergeCells = true;
                    sheet.Cells[4, "B"] = selectedCase.SellerClient.ToString();
                    sheet.Cells[5, "A"] = "Buyer Name";
                    sheet.get_Range("B5", "F5").MergeCells = true;
                    sheet.Cells[5, "B"] = selectedCase.BuyerClient.ToString();

                    sheet.get_Range("B6", "F6").MergeCells = true;
                    if (selectedCase.TransactionType == "进口保理")
                    {
                        sheet.Cells[6, "A"] = "Export Factor";
                        sheet.Cells[6, "B"] = selectedCase.SellerFactor.ToString();
                    }
                    else
                    {
                        sheet.Cells[6, "A"] = "Import Factor";
                        sheet.Cells[6, "B"] = selectedCase.BuyerFactor.ToString();
                    }

                    sheet.get_Range("B7", "F7").MergeCells = true;
                    sheet.Cells[7, "A"] = "协查意见书编号";
                    List<ClientReview> reviewList = selectedCase.ClientReviews;
                    if (reviewList != null)
                    {
                        String reviews = string.Empty;
                        foreach (ClientReview review in reviewList)
                        {
                            reviews += review.ReviewNo + ";";
                        }

                        sheet.Cells[7, "B"] = reviews;
                    }

                    sheet.Cells[4, "G"] = "总手续费率";
                    sheet.get_Range(sheet.Cells[4, "H"], sheet.Cells[4, "I"]).MergeCells = true;
                    if (cda != null)
                    {
                        sheet.Cells[4, "H"] = String.Format("{0:P}", cda.Price);
                    }

                    sheet.get_Range(sheet.Cells[5, "H"], sheet.Cells[5, "I"]).MergeCells = true;
                    if (selectedCase.TransactionType == "进口保理")
                    {
                        sheet.Cells[5, "G"] = "EF手续费率";
                        if (cda != null)
                        {
                            sheet.Cells[5, "H"] = String.Format("{0:P}", cda.EFPrice);
                        }
                    }
                    else
                    {
                        sheet.Cells[5, "G"] = "IF手续费率";
                        if (cda != null)
                        {
                            sheet.Cells[5, "H"] = String.Format("{0:P}", cda.IFPrice);
                        }
                    }

                    sheet.Cells[6, "G"] = "利率";
                    sheet.get_Range(sheet.Cells[6, "H"], sheet.Cells[6, "I"]).MergeCells = true;

                    sheet.Cells[7, "G"] = "单据处理费/笔";
                    sheet.get_Range(sheet.Cells[7, "H"], sheet.Cells[7, "I"]).MergeCells = true;
                    sheet.Cells[7, "H"] = String.Format("{0} {1:N2}", cda.HandFeeCurr, cda.HandFee);

                    sheet.get_Range(sheet.Cells[4, "L"], sheet.Cells[4, "M"]).MergeCells = true;
                    sheet.Cells[4, "L"] = "信用风险担保";
                    sheet.Cells[5, "L"] = "核准额度";
                    sheet.Cells[5, "M"] = cda.CreditCover;
                    sheet.get_Range(sheet.Cells[5, "M"], sheet.Cells[5, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.CreditCoverCurr);
                    sheet.Cells[6, "L"] = "到期日";
                    sheet.Cells[6, "M"] = cda.CreditCoverPeriodEnd;
                    sheet.get_Range(sheet.Cells[6, "M"], sheet.Cells[6, "M"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.Cells[7, "L"] = "剩余额度";
                    sheet.Cells[7, "M"] = cda.CreditCoverOutstanding;
                    sheet.get_Range(sheet.Cells[7, "M"], sheet.Cells[7, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.CreditCoverCurr);
                    sheet.Cells[8, "L"] = "应收帐款余额";
                    sheet.Cells[8, "M"] = selectedCase.AssignOutstanding;
                    sheet.get_Range(sheet.Cells[8, "M"], sheet.Cells[8, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);

                    sheet.get_Range(sheet.Cells[4, "O"], sheet.Cells[4, "P"]).MergeCells = true;
                    sheet.Cells[4, "O"] = "融资额度";
                    sheet.Cells[5, "O"] = "核准额度";
                    sheet.Cells[5, "P"] = cda.FinanceLine;
                    sheet.get_Range(sheet.Cells[5, "P"], sheet.Cells[5, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.FinanceLineCurr);
                    sheet.Cells[6, "O"] = "到期日";
                    sheet.Cells[6, "P"] = cda.FinanceLinePeriodEnd;
                    sheet.get_Range(sheet.Cells[6, "P"], sheet.Cells[6, "P"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.Cells[7, "O"] = "剩余额度";
                    sheet.Cells[7, "P"] = cda.FinanceLineOutstanding;
                    sheet.get_Range(sheet.Cells[7, "P"], sheet.Cells[7, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.FinanceLineCurr);
                    sheet.Cells[8, "O"] = "融资余额";
                    sheet.Cells[8, "P"] = selectedCase.FinanceOutstanding;
                    sheet.get_Range(sheet.Cells[8, "P"], sheet.Cells[8, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);

                    sheet.Cells[9, "A"] = "发票号";
                    sheet.Cells[9, "B"] = "转让金额";
                    sheet.Cells[9, "C"] = "发票日";
                    sheet.Cells[9, "D"] = "到期日";
                    sheet.Cells[9, "E"] = "转让日";
                    sheet.Cells[9, "F"] = "是否瑕疵";
                    sheet.Cells[9, "G"] = "融资金额";
                    sheet.Cells[9, "H"] = "融资日";
                    sheet.Cells[9, "I"] = "融资到期日";
                    sheet.Cells[9, "J"] = "付款金额";
                    sheet.Cells[9, "K"] = "账款余额";
                    sheet.Cells[9, "L"] = "付款日";
                    sheet.Cells[9, "M"] = "还款金额";
                    sheet.Cells[9, "N"] = "还款日";
                    sheet.Cells[9, "O"] = "手续费";
                    sheet.Cells[9, "P"] = "利息";
                    sheet.Cells[9, "Q"] = "备注";

                    sheet.get_Range("A4", "I7").Borders.LineStyle = 1;
                    sheet.get_Range("L4", "M8").Borders.LineStyle = 1;
                    sheet.get_Range("O4", "P8").Borders.LineStyle = 1;

                    int row = 10;
                    foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in batch.Invoices)
                        {
                            int step = 1;
                            sheet.Cells[row, "A"] = "'" + invoice.InvoiceNo;
                            sheet.Cells[row, "B"] = invoice.AssignAmount;
                            sheet.Cells[row, "C"] = invoice.InvoiceDate;
                            sheet.Cells[row, "D"] = invoice.DueDate;
                            sheet.Cells[row, "E"] = batch.AssignDate;
                            sheet.Cells[row, "F"] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);

                            int recordStep = 0;
                            for (int i = 0; i < invoice.InvoiceFinanceLogs.Count; i++)
                            {
                                InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[i];
                                sheet.Cells[row + recordStep, "G"] = financeLog.FinanceAmount;
                                sheet.Cells[row + recordStep, "H"] = financeLog.FinanceDate;
                                sheet.Cells[row + recordStep, "I"] = financeLog.FinanceDueDate;

                                for (int j = 0; j < financeLog.InvoiceRefundLogs.Count; j++)
                                {
                                    InvoiceRefundLog refundLog = financeLog.InvoiceRefundLogs[j];
                                    sheet.Cells[row + recordStep + j, "M"] = refundLog.RefundAmount;
                                    sheet.Cells[row + recordStep + j, "N"] = refundLog.RefundDate;
                                }

                                recordStep += financeLog.InvoiceRefundLogs.Count;
                            }

                            step = step < recordStep ? recordStep : step;

                            for (int i = 0; i < invoice.InvoicePaymentLogs.Count; i++)
                            {
                                InvoicePaymentLog paymentLog = invoice.InvoicePaymentLogs[i];
                                sheet.Cells[row + i, "J"] = paymentLog.PaymentAmount;
                                sheet.Cells[row + i, "L"] = paymentLog.PaymentDate;
                            }

                            step = step < invoice.InvoicePaymentLogs.Count ? invoice.InvoicePaymentLogs.Count : step;

                            sheet.Cells[row, "K"] = invoice.AssignOutstanding;

                            sheet.Cells[row, "O"] = invoice.Commission;
                            sheet.Cells[row, "P"] = invoice.NetInterest;
                            sheet.Cells[row, "Q"] = invoice.Comment;

                            row += step;
                        }
                    }

                    string currencyFormat = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);
                    sheet.get_Range(sheet.Cells[9, "A"], sheet.Cells[row - 1, "Q"]).Borders.LineStyle = 1;
                    sheet.get_Range(sheet.Cells[10, "B"], sheet.Cells[row - 1, "B"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "C"], sheet.Cells[row - 1, "C"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "D"], sheet.Cells[row - 1, "D"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "E"], sheet.Cells[row - 1, "E"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "G"], sheet.Cells[row - 1, "G"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "H"], sheet.Cells[row - 1, "H"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "I"], sheet.Cells[row - 1, "I"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "J"], sheet.Cells[row - 1, "J"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "K"], sheet.Cells[row - 1, "K"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "L"], sheet.Cells[row - 1, "L"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "M"], sheet.Cells[row - 1, "M"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "N"], sheet.Cells[row - 1, "N"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "O"], sheet.Cells[row - 1, "O"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "P"], sheet.Cells[row - 1, "P"]).NumberFormatLocal = currencyFormat;

                    foreach (Range range in sheet.UsedRange.Rows)
                    {
                        range.EntireRow.AutoFit();
                    }

                    foreach (Range range in sheet.UsedRange.Columns)
                    {
                        range.EntireColumn.AutoFit();
                    }

                    sheet.UsedRange.Font.Name = "仿宋";
                }

                this.FillLegarTotalSheet(totalSheet, caseGroup);
                totalSheet.Move(workbook.Sheets[1], Type.Missing);

                if (app != null)
                {
                    app.DisplayAlerts = false;
                    app.AlertBeforeOverwriting = false;
                    if (workbook != null)
                    {
                        string ext = ".xls";
                        if (app.Version.IndexOf("12") != -1)
                        {
                            ext = ".xlsx";
                        }
                        else
                        {
                            ext = ".xls";
                        }

                        string filePath = this.tbFilePath.Text + "\\" + caseGroup.Key.ToString() + ext;
                        workbook.SaveCopyAs(filePath);
                    }
                }
            }
            catch (Exception e1)
            {
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

                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (app != null)
                {
                    app.Quit();
                    app = null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFile(object sender, EventArgs e)
        {
            FolderBrowserDialog dirDialog = new FolderBrowserDialog();
            if (dirDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbFilePath.Text = dirDialog.SelectedPath;
            }
        }

        #endregion Methods
    }
}
