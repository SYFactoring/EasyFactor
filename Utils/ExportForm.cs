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
    using CMBC.EasyFactor.Utils.ConstStr;

    /// <summary>
    /// 
    /// </summary>
    public partial class ExportForm : DevComponents.DotNetBar.Office2007Form
    {
		#region?Fields?(2)?

        /// <summary>
        /// 
        /// </summary>
        private IList exportData;
        /// <summary>
        /// 
        /// </summary>
        private ExportType exportType;

		#endregion?Fields?

		#region?Enums?(1)?

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

		#endregion?Enums?

		#region?Constructors?(1)?

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

		#endregion?Constructors?

		#region?Methods?(24)?

		//?Public?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartExport(object sender, EventArgs e)
        {
            string filePath = this.tbFilePath.Text;
            if (String.IsNullOrEmpty(filePath.Trim()))
            {
                if (this.exportType == ExportType.EXPORT_MSG09 || this.exportType == ExportType.EXPORT_MSG11 || this.exportType == ExportType.EXPORT_MSG12 || this.exportType == ExportType.EXPORT_LEGER)
                {
                    this.tbStatus.Text = "����ѡ�񱣴�·��";
                    return;
                }
            }
            else if (this.exportType == ExportType.EXPORT_LEGER)
            {
                DirectoryInfo info = new DirectoryInfo(filePath);
                if (info.Parent == null)
                {
                    this.tbStatus.Text = "��Ҫѡ��Ӳ�̸�Ŀ¼";
                    return;
                }
            }


            this.btnCancel.Text = "ȡ��";
            this.backgroundWorker.RunWorkerAsync();

            this.btnStart.Enabled = false;
        }
		//?Private?Methods?(23)?

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
            this.tbStatus.Text = String.Format("�������� {0:G}%", e.ProgressPercentage);
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
                this.tbStatus.Text = "�����쳣: " + e.Error.Message;
            }
            else if (e.Cancelled)
            {
                this.tbStatus.Text = "������ȡ��";
                this.progressBar.Value = 0;
            }
            else
            {
                this.tbStatus.Text = String.Format("��������,������{0}����¼", e.Result);
            }

            this.btnCancel.Text = "�ر�";
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "Ʊ����";
                datasheet.Cells[1, column++] = "ת�ý��";
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "�Ƿ�覴�";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "��ע";

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
        private object ExportCases(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };

            if (app == null)
            {
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "ҵ�����";
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "�����������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "���������̴���";
                datasheet.Cells[1, column++] = "����������";
                datasheet.Cells[1, column++] = "�򷽱������";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "�򷽱����̴���";
                datasheet.Cells[1, column++] = "�򷽱�����";
                datasheet.Cells[1, column++] = "��Ʊ�ұ�";
                datasheet.Cells[1, column++] = "ҵ������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "ҵ���������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "����״̬";
                datasheet.Cells[1, column++] = "OP��Ա";

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
                    datasheet.Cells[row + 2, column++] = selectedCase.OwnerDepartment.Location.LocationName;
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
                    if (range.Column == 16)
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Workbook workbook = null;

            try
            {
                workbook = app.Workbooks.Add(true);
                Worksheet sheetLocal = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                sheetLocal.Name = "����";

                Worksheet sheetInternal = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                sheetInternal.Name = "����";

                if (sheetInternal == null || sheetLocal == null)
                {
                    return -1;
                }

                int column = 1;
                sheetInternal.Cells[1, column++] = "ҵ������";
                sheetInternal.Cells[1, column++] = "�Ƿ���׷��Ȩ";
                sheetInternal.Cells[1, column++] = "��/������";
                sheetInternal.Cells[1, column++] = "�¾ɺ�ͬ";
                sheetInternal.Cells[1, column++] = "��ͬ���";
                sheetInternal.Cells[1, column++] = "����ͬ��Ч��";
                sheetInternal.Cells[1, column++] = "����ͬ������";
                sheetInternal.Cells[1, column++] = "CDA���";
                sheetInternal.Cells[1, column++] = "��������";
                sheetInternal.Cells[1, column++] = "������";
                sheetInternal.Cells[1, column++] = "�򷽵�ַ";
                sheetInternal.Cells[1, column++] = "ǩ������";
                sheetInternal.Cells[1, column++] = "���ʽ";
                sheetInternal.Cells[1, column++] = "�����÷��ն�ȱұ�";
                sheetInternal.Cells[1, column++] = "���÷��ն��";
                sheetInternal.Cells[1, column++] = "��Ч����(ʼ)";
                sheetInternal.Cells[1, column++] = "��Ч����(��)";
                sheetInternal.Cells[1, column++] = "Ԥ�����ȱұ�";
                sheetInternal.Cells[1, column++] = "����Ԥ������";
                sheetInternal.Cells[1, column++] = "��Ч���ޣ�ʼ��";
                sheetInternal.Cells[1, column++] = "��Ч���ޣ��գ�";
                sheetInternal.Cells[1, column++] = "��߱���Ԥ������";
                sheetInternal.Cells[1, column++] = "Ԥ������";
                sheetInternal.Cells[1, column++] = "�������";
                sheetInternal.Cells[1, column++] = "�Ʒѷ�ʽ";
                sheetInternal.Cells[1, column++] = "���ݴ���ѱұ�";
                sheetInternal.Cells[1, column++] = "���ݴ����";
                sheetInternal.Cells[1, column++] = "��ע";
                sheetInternal.Cells[1, column++] = "���ڱ�����";

                column = 1;
                sheetLocal.Cells[1, column++] = "ҵ������";
                sheetLocal.Cells[1, column++] = "�Ƿ���׷��Ȩ";
                sheetLocal.Cells[1, column++] = "��/������";
                sheetLocal.Cells[1, column++] = "�¾ɺ�ͬ";
                sheetLocal.Cells[1, column++] = "��ͬ���";
                sheetLocal.Cells[1, column++] = "����ͬ��Ч��";
                sheetLocal.Cells[1, column++] = "����ͬ������";
                sheetLocal.Cells[1, column++] = "CDA���";
                sheetLocal.Cells[1, column++] = "��������";
                sheetLocal.Cells[1, column++] = "������";
                sheetLocal.Cells[1, column++] = "�򷽵�ַ";
                sheetLocal.Cells[1, column++] = "ǩ������";
                sheetLocal.Cells[1, column++] = "���ʽ";
                sheetLocal.Cells[1, column++] = "�����÷��ն�ȱұ�";
                sheetLocal.Cells[1, column++] = "���÷��ն��";
                sheetLocal.Cells[1, column++] = "��Ч����(ʼ)";
                sheetLocal.Cells[1, column++] = "��Ч����(��)";
                sheetLocal.Cells[1, column++] = "Ԥ�����ȱұ�";
                sheetLocal.Cells[1, column++] = "����Ԥ������";
                sheetLocal.Cells[1, column++] = "��Ч���ޣ�ʼ��";
                sheetLocal.Cells[1, column++] = "��Ч���ޣ��գ�";
                sheetLocal.Cells[1, column++] = "��߱���Ԥ������";
                sheetLocal.Cells[1, column++] = "Ԥ������";
                sheetLocal.Cells[1, column++] = "�������";
                sheetLocal.Cells[1, column++] = "�Ʒѷ�ʽ";
                sheetLocal.Cells[1, column++] = "���ݴ���ѱұ�";
                sheetLocal.Cells[1, column++] = "���ݴ����";
                sheetLocal.Cells[1, column++] = "��ע";

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
                    if (cda.TransactionType == "���ڱ���" || cda.TransactionType == "���ڱ���")
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
        private object ExportClientReviews(BackgroundWorker worker, DoWorkEventArgs e)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };

            if (app == null)
            {
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            if (datasheet == null)
            {
                return -1;
            }

            try
            {
                datasheet.Cells[1, 1] = "Э�����̨��";
                datasheet.get_Range("A1", "S1").MergeCells = true;
                datasheet.get_Range("A1", "S1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                int column = 1;
                datasheet.Cells[2, column++] = "�ظ�ʱ��";
                datasheet.Cells[2, column++] = "Э���������";
                datasheet.Cells[2, column++] = "��������";
                datasheet.Cells[2, column++] = "������ҵ��/����";
                datasheet.Cells[2, column++] = "�����ֲ�";
                datasheet.Cells[2, column++] = "��Ʒ����";
                datasheet.Cells[2, column++] = "�ͻ�����";
                datasheet.Cells[2, column++] = "������ҵ";
                datasheet.Cells[2, column++] = "���Ž���";
                datasheet.Cells[2, column++] = "����";
                datasheet.Cells[2, column++] = "����";
                datasheet.Cells[2, column++] = "����";
                datasheet.Cells[2, column++] = "��";
                datasheet.Cells[2, column++] = "��׷";
                datasheet.Cells[2, column++] = "��׷";
                datasheet.Cells[2, column++] = "����/����";
                datasheet.Cells[2, column++] = "Ԥ����";
                datasheet.Cells[2, column++] = "����";
                datasheet.Cells[2, column++] = "����֤";
                datasheet.Cells[2, column++] = "����";
                datasheet.Cells[2, column++] = "���ʹ���";
                datasheet.Cells[2, column++] = "����״̬";
                datasheet.Cells[2, column++] = "�����";
                datasheet.Cells[2, column++] = "�����ڣ��£�";
                datasheet.Cells[2, column++] = "��ע";

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
                        datasheet.Cells[row + 3, column++] = dept.Location.PManager;
                        datasheet.Cells[row + 3, column++] = dept.Domain;
                        datasheet.Cells[row + 3, column++] = dept.Location.LocationName;
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
                    datasheet.Cells[row + 3, column++] = review.IsLocal ? "����" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsInternational ? "����" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsSeller ? "����" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsBuyer ? "��" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsRecoarse ? "��׷" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsNonRecoarse ? "��׷" : "---";
                    datasheet.Cells[row + 3, column++] = review.IsNotice;
                    string[] financeTypes = review.RequestFinanceType.Split(new char[] { ';' });
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("Ԥ����") ? "Ԥ����" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("����") ? "����" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("����֤") ? "����֤" : "---";
                    datasheet.Cells[row + 3, column++] = financeTypes.Contains("����") ? "����" : "---";
                    datasheet.Cells[row + 3, column++] = review.RequestFinanceType2;
                    datasheet.Cells[row + 3, column++] = review.Client.Contract != null ? "������" : "δ����";
                    datasheet.get_Range(datasheet.Cells[row + 3, column], datasheet.Cells[row + 3, column]).NumberFormatLocal = "0.000%";
                    datasheet.Cells[row + 3, column++] = review.RequestCommissionRate;
                    datasheet.get_Range(datasheet.Cells[row + 3, column], datasheet.Cells[row + 3, column]).NumberFormatLocal = "##��";
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "�ͻ���";
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "�ͻ�����(��)";
                datasheet.Cells[1, column++] = "�ͻ�����(Ӣ)";
                datasheet.Cells[1, column++] = "��ַ(��)";
                datasheet.Cells[1, column++] = "��ַ(Ӣ)";
                datasheet.Cells[1, column++] = "���ڳ���(��)";
                datasheet.Cells[1, column++] = "���ڳ���(Ӣ)";
                datasheet.Cells[1, column++] = "����ʡ/��(��)";
                datasheet.Cells[1, column++] = "����ʡ/��(Ӣ)";
                datasheet.Cells[1, column++] = "�ʱ�";
                datasheet.Cells[1, column++] = "���ڹ�";
                datasheet.Cells[1, column++] = "��˾����/������";
                datasheet.Cells[1, column++] = "��˾��ַ";
                datasheet.Cells[1, column++] = "��ϵ��";
                datasheet.Cells[1, column++] = "��ϵ�绰";
                datasheet.Cells[1, column++] = "E-MAIL";
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "�ֻ�����";
                datasheet.Cells[1, column++] = "�ͻ�����";
                datasheet.Cells[1, column++] = "��ҵ���";
                datasheet.Cells[1, column++] = "��Ӫ��Χ(��)";
                datasheet.Cells[1, column++] = "��Ӫ��Χ(Ӣ)";
                datasheet.Cells[1, column++] = "�ͻ�����";
                datasheet.Cells[1, column++] = "�������ſͻ��������";
                datasheet.Cells[1, column++] = "�������ſͻ�����";
                datasheet.Cells[1, column++] = "Ӫҵִ�պ���";
                datasheet.Cells[1, column++] = "��֯��������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "��Ʒ����";
                datasheet.Cells[1, column++] = "�ͻ�����";
                datasheet.Cells[1, column++] = "��ע";
                datasheet.Cells[1, column++] = "������";

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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "����������";
                datasheet.Cells[1, column++] = "P/C��־";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "�ظ����";
                datasheet.Cells[1, column++] = "�ظ�����";
                datasheet.Cells[1, column++] = "IF����";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "��ע";

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
                datasheet.UsedRange.Font.Name = "����_GB2312";
                datasheet.UsedRange.Font.Size = 12;

                app.Visible = true;
            }
            catch (Exception)
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

                throw;
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "������";
                //��������
                datasheet.Cells[1, column++] = "�������κ�";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "����������";
                datasheet.Cells[1, column++] = "�Ƿ����ɱ���";
                datasheet.Cells[1, column++] = "���θ��ע";
                datasheet.Cells[1, column++] = "�������";
                //����֪ͨ
                datasheet.Cells[1, column++] = "����֪ͨ��";
                datasheet.Cells[1, column++] = "����֪ͨ���";
                datasheet.Cells[1, column++] = "����֪ͨ��";
                datasheet.Cells[1, column++] = "��Ӧ��Ʊ��";
                datasheet.Cells[1, column++] = "��ע";

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
            catch (Exception)
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

                throw;
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "ת�����";
                datasheet.Cells[1, column++] = "���ʽ��";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "��ע";

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
            catch (Exception)
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

                throw;
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "������";
                //ת������
                datasheet.Cells[1, column++] = "ת�����κ�";
                datasheet.Cells[1, column++] = "ת��������";
                datasheet.Cells[1, column++] = "�Ƿ����ɱ���";
                datasheet.Cells[1, column++] = "����ת�ñ�ע";
                datasheet.Cells[1, column++] = "ת�þ�����";
                //ת��
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "Ʊ����";
                datasheet.Cells[1, column++] = "ת�ý��";
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "�Ƿ�覴�";
                //��������
                datasheet.Cells[1, column++] = "���ʱ��";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "�����б���";
                datasheet.Cells[1, column++] = "����������";
                datasheet.Cells[1, column++] = "���ʱұ�";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "�ɱ�����";
                datasheet.Cells[1, column++] = "����������ʼ��";
                datasheet.Cells[1, column++] = "�������ʵ�����";
                datasheet.Cells[1, column++] = "�������ʱ�ע";
                datasheet.Cells[1, column++] = "�������ʾ�����";
                //����
                datasheet.Cells[1, column++] = "���ʽ��";
                //��������
                datasheet.Cells[1, column++] = "�������κ�";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "����������";
                datasheet.Cells[1, column++] = "�Ƿ����ɱ���";
                datasheet.Cells[1, column++] = "���θ��ע";
                datasheet.Cells[1, column++] = "�������";
                //����
                datasheet.Cells[1, column++] = "������";
                //��������
                datasheet.Cells[1, column++] = "�������α��";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "����������";
                datasheet.Cells[1, column++] = "���λ��ע";
                datasheet.Cells[1, column++] = "�������";
                //����
                datasheet.Cells[1, column++] = "������";
                //������
                datasheet.Cells[1, column++] = "������";
                //��Ϣ
                datasheet.Cells[1, column++] = "��Ϣ";
                datasheet.Cells[1, column++] = "��ע";

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
                    //ת������
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.AssignBatchNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.AssignDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.InvoiceAssignBatch.IsCreateMsg);
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CreateUserName;
                    //ת��
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                    datasheet.Cells[row + 2, column++] = invoice.DueDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);

                    //��������
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

                        //����
                        column = 26;
                        datasheet.Cells[row + 2 + recordStep, column++] = financeLog.FinanceAmount;

                        //��������
                        for (int j = 0; j < financeLog.InvoiceRefundLogs.Count; j++)
                        {
                            column = 34;
                            InvoiceRefundLog log = financeLog.InvoiceRefundLogs[j];
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.RefundBatchNo;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.RefundType;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.RefundDate;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.Comment;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.InvoiceRefundBatch.CreateUserName;

                            //����
                            column = 39;
                            datasheet.Cells[row + 2 + j + recordStep, column++] = log.RefundAmount;
                        }

                        recordStep += financeLog.InvoiceRefundLogs.Count;
                    }


                    //��������
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

                        //����
                        column = 33;
                        datasheet.Cells[row + 2 + i, column++] = log.PaymentAmount;
                    }

                    column = 40;

                    //������
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    //��Ϣ
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
            catch (Exception)
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

                throw;
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "��������";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "��Ʊ�ұ�";
                datasheet.Cells[1, column++] = "ת�ý��";
                datasheet.Cells[1, column++] = "ת�����";
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "ת����";
                datasheet.Cells[1, column++] = "���ʱұ�";
                datasheet.Cells[1, column++] = "���ʽ��";
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "���ʵ�����";
                datasheet.Cells[1, column++] = "�˿���������";
                datasheet.Cells[1, column++] = "������������";

                int size = exportData.Count;
                int row = 0;
                foreach (Invoice invoice in exportData)
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
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.OwnerDepartment.Location.LocationName;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.SellerClient.ToString();
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Case.BuyerClient.ToString();
                    datasheet.Cells[row + 2, column++] = "'" + invoice.InvoiceNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceCurrency;
                    datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                    datasheet.Cells[row + 2, column++] = invoice.AssignOutstanding;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                    datasheet.Cells[row + 2, column++] = invoice.DueDate;
                    datasheet.Cells[row + 2, column++] = invoice.AssignDate;
                    if (invoice.AssignOverDueDays >= 0)
                    {
                        ((Range)datasheet.Cells[row + 2, column - 2]).Interior.ColorIndex = 6;
                    }
                    for (int i = 0; i < invoice.InvoiceFinanceLogs.Count; i++)
                    {
                        column = 11;
                        InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[i];
                        datasheet.Cells[row + 2 + i, column++] = financeLog.InvoiceFinanceBatch.BatchCurrency;
                        datasheet.Cells[row + 2 + i, column++] = financeLog.FinanceAmount;
                        datasheet.Cells[row + 2 + i, column++] = financeLog.FinanceOutstanding;
                        datasheet.Cells[row + 2 + i, column++] = financeLog.FinanceDate;
                        datasheet.Cells[row + 2 + i, column++] = financeLog.FinanceDueDate;
                        if (financeLog.FinanceOverDueDays >= 0)
                        {
                            ((Range)datasheet.Cells[row + 2 + i, column - 1]).Interior.ColorIndex = 3;
                        }

                        datasheet.Cells[row + 2, column++] = invoice.AssignOverDueDays;
                        datasheet.Cells[row + 2 + i, column++] = financeLog.FinanceOverDueDays;
                    }

                    int step = invoice.InvoiceFinanceLogs.Count > 1 ? invoice.InvoiceFinanceLogs.Count : 1;
                    row += step;
                    size += (step - 1);
                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 6 || range.Column == 7 || range.Column == 12 || range.Column == 13)
                    {
                        range.NumberFormatLocal = "#,##0.00";
                    }
                    else if (range.Column == 8 || range.Column == 9 || range.Column == 10 || range.Column == 14 || range.Column == 15)
                    {
                        range.NumberFormatLocal = "yyyy-MM-dd";
                    }
                }

                app.Visible = true;
            }
            catch (Exception)
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

                throw;
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
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return -1;
                }

                string transactionType = caseGroup.Key;
                switch (transactionType)
                {
                    case "������������":
                    case "���ڱ���":
                        groups = caseGroup.GroupBy(c => c.SellerClient);
                        break;
                    case "�����򷽱���":
                    case "���ڱ���":
                        groups = caseGroup.GroupBy(c => c.BuyerClient);
                        break;
                    default:
                        break;
                }

                if (groups != null)
                {
                    foreach (IGrouping<Client, Case> group in groups)
                    {
                        ExportReportLegarImpl(group);
                        result += (int)group.LongCount();
                        worker.ReportProgress((int)((float)result * 100 / (float)size));
                    }
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "ת�����";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "��ע";
                datasheet.Cells[1, column++] = "����֪ͨ��";
                datasheet.Cells[1, column++] = "����֪ͨ��";

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
                        datasheet.Cells[row + 2, column++] = log.CreditNote.CreditNoteDate;
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
            catch (Exception)
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

                throw;
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                datasheet.Cells[1, column++] = "��Ʊ��";
                datasheet.Cells[1, column++] = "���ʱ��";
                datasheet.Cells[1, column++] = "�������";
                datasheet.Cells[1, column++] = "������";
                datasheet.Cells[1, column++] = "��ע";

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
            catch (Exception)
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

                throw;
            }

            return exportData.Count;
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
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Workbook workbook = null;
            try
            {
                workbook = app.Workbooks.Add(true);
                Worksheet totalSheet = (Worksheet)workbook.Sheets[1];
                totalSheet.Name = "��̨��";

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

                        MessageBoxEx.Show("����û����Ч�Ķ��֪ͨ�飬������ţ�" + selectedCase.CaseCode);

                        return;
                    }

                    Worksheet sheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);

                    string name = selectedCase.TargetClient.ToString();
                    if (name.Length > 15)
                    {
                        name = name.Substring(0, 15);
                    }

                    sheet.Name = String.Format("{0}-{1}", selectedCase.CaseCode, name);

                    sheet.get_Range("A1", "Q1").MergeCells = true;
                    sheet.get_Range("A1", "A1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, "A"] = "���۷ֻ���̨��";
                    sheet.Cells[2, "P"] = String.Format("��λ��{0}", selectedCase.InvoiceCurrency);
                    sheet.Cells[3, "A"] = "����/�ֲ�";
                    sheet.Cells[3, "B"] = selectedCase.OwnerDepartment.DepartmentName;

                    sheet.Cells[4, "A"] = "Seller Name";
                    sheet.get_Range("B4", "F4").MergeCells = true;
                    sheet.Cells[4, "B"] = selectedCase.SellerClient.ToString();
                    sheet.Cells[5, "A"] = "Buyer Name";
                    sheet.get_Range("B5", "F5").MergeCells = true;
                    sheet.Cells[5, "B"] = selectedCase.BuyerClient.ToString();

                    sheet.get_Range("B6", "F6").MergeCells = true;
                    if (selectedCase.TransactionType == "���ڱ���")
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
                    sheet.Cells[7, "A"] = "Э���������";
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

                    sheet.Cells[4, "G"] = "�������";
                    sheet.get_Range(sheet.Cells[4, "H"], sheet.Cells[4, "I"]).MergeCells = true;
                    sheet.Cells[4, "H"] = selectedCase.CaseCode;

                    sheet.Cells[5, "G"] = "����������";
                    sheet.get_Range(sheet.Cells[5, "H"], sheet.Cells[5, "I"]).MergeCells = true;
                    if (cda != null)
                    {
                        sheet.Cells[5, "H"] = String.Format("{0:P4}", cda.Price);
                    }

                    sheet.get_Range(sheet.Cells[6, "H"], sheet.Cells[6, "I"]).MergeCells = true;
                    sheet.Cells[6, "G"] = "�շѷ�ʽ";
                    if (cda != null)
                    {
                        sheet.Cells[6, "H"] = cda.CommissionType;
                    }


                    sheet.Cells[7, "G"] = "���ݴ����/��";
                    sheet.get_Range(sheet.Cells[7, "H"], sheet.Cells[7, "I"]).MergeCells = true;
                    sheet.Cells[7, "H"] = String.Format("{0} {1:N2}", cda.HandFeeCurr, cda.HandFee);

                    sheet.get_Range(sheet.Cells[4, "L"], sheet.Cells[4, "M"]).MergeCells = true;
                    sheet.Cells[4, "L"] = "���÷��յ���";
                    sheet.Cells[5, "L"] = "��׼���";
                    sheet.Cells[5, "M"] = cda.CreditCover;
                    sheet.get_Range(sheet.Cells[5, "M"], sheet.Cells[5, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.CreditCoverCurr);
                    sheet.Cells[6, "L"] = "������";
                    sheet.Cells[6, "M"] = cda.CreditCoverPeriodEnd;
                    sheet.get_Range(sheet.Cells[6, "M"], sheet.Cells[6, "M"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.Cells[7, "L"] = "ʣ����";
                    sheet.Cells[7, "M"] = cda.CreditCoverOutstanding;
                    sheet.get_Range(sheet.Cells[7, "M"], sheet.Cells[7, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.CreditCoverCurr);
                    sheet.Cells[8, "L"] = "Ӧ���ʿ����";
                    sheet.Cells[8, "M"] = selectedCase.AssignOutstanding;
                    sheet.get_Range(sheet.Cells[8, "M"], sheet.Cells[8, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);

                    sheet.get_Range(sheet.Cells[4, "O"], sheet.Cells[4, "P"]).MergeCells = true;
                    sheet.Cells[4, "O"] = "���ʶ��";
                    sheet.Cells[5, "O"] = "��׼���";
                    sheet.Cells[5, "P"] = cda.FinanceLine;
                    sheet.get_Range(sheet.Cells[5, "P"], sheet.Cells[5, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.FinanceLineCurr);
                    sheet.Cells[6, "O"] = "������";
                    sheet.Cells[6, "P"] = cda.FinanceLinePeriodEnd;
                    sheet.get_Range(sheet.Cells[6, "P"], sheet.Cells[6, "P"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.Cells[7, "O"] = "ʣ����";
                    sheet.Cells[7, "P"] = cda.FinanceLineOutstanding;
                    sheet.get_Range(sheet.Cells[7, "P"], sheet.Cells[7, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(cda.FinanceLineCurr);
                    sheet.Cells[8, "O"] = "�������";
                    sheet.Cells[8, "P"] = selectedCase.FinanceOutstanding;
                    sheet.get_Range(sheet.Cells[8, "P"], sheet.Cells[8, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);

                    sheet.Cells[9, "A"] = "ҵ����";
                    sheet.Cells[9, "B"] = "��Ʊ��";
                    sheet.Cells[9, "C"] = "ת�ý��";
                    sheet.Cells[9, "D"] = "��Ʊ��";
                    sheet.Cells[9, "E"] = "������";
                    sheet.Cells[9, "F"] = "ת����";
                    sheet.Cells[9, "G"] = "���ʽ��";
                    sheet.Cells[9, "H"] = "������";
                    sheet.Cells[9, "I"] = "���ʵ�����";
                    sheet.Cells[9, "J"] = "������";
                    sheet.Cells[9, "K"] = "�˿����";
                    sheet.Cells[9, "L"] = "������";
                    sheet.Cells[9, "M"] = "������";
                    sheet.Cells[9, "N"] = "�������";
                    sheet.Cells[9, "O"] = "������";
                    sheet.Cells[9, "P"] = "������";
                    sheet.Cells[9, "Q"] = "��ע";

                    sheet.get_Range("A4", "I7").Borders.LineStyle = 1;
                    sheet.get_Range("L4", "M8").Borders.LineStyle = 1;
                    sheet.get_Range("O4", "P8").Borders.LineStyle = 1;

                    int row = 10;
                    foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in batch.Invoices)
                        {
                            int step = 1;
                            sheet.Cells[row, "A"] = invoice.InvoiceAssignBatch.AssignBatchNo;
                            sheet.Cells[row, "B"] = "'" + invoice.InvoiceNo;
                            sheet.Cells[row, "C"] = invoice.AssignAmount;
                            sheet.Cells[row, "D"] = invoice.InvoiceDate;
                            sheet.Cells[row, "E"] = invoice.DueDate;
                            sheet.Cells[row, "F"] = batch.AssignDate;

                            int recordStep = 0;
                            for (int i = 0; i < invoice.InvoiceFinanceLogs.Count; i++)
                            {
                                InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[i];
                                sheet.Cells[row + recordStep, "G"] = financeLog.FinanceAmount;
                                sheet.Cells[row + recordStep, "H"] = financeLog.FinanceDate;
                                sheet.Cells[row + recordStep, "I"] = financeLog.FinanceDueDate;
                                sheet.Cells[row + recordStep, "N"] = financeLog.FinanceOutstanding;

                                for (int j = 0; j < financeLog.InvoiceRefundLogs.Count; j++)
                                {
                                    InvoiceRefundLog refundLog = financeLog.InvoiceRefundLogs[j];
                                    sheet.Cells[row + recordStep + j, "M"] = refundLog.RefundAmount;
                                    sheet.Cells[row + recordStep + j, "O"] = refundLog.RefundDate;
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

                            sheet.Cells[row, "P"] = invoice.Commission;
                            sheet.Cells[row, "Q"] = invoice.Comment;

                            row += step;
                        }
                    }

                    string currencyFormat = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);
                    sheet.get_Range(sheet.Cells[9, "A"], sheet.Cells[row - 1, "Q"]).Borders.LineStyle = 1;
                    sheet.get_Range(sheet.Cells[10, "C"], sheet.Cells[row - 1, "C"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "D"], sheet.Cells[row - 1, "D"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "E"], sheet.Cells[row - 1, "E"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "F"], sheet.Cells[row - 1, "F"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "G"], sheet.Cells[row - 1, "G"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "H"], sheet.Cells[row - 1, "H"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "I"], sheet.Cells[row - 1, "I"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "J"], sheet.Cells[row - 1, "J"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "K"], sheet.Cells[row - 1, "K"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "L"], sheet.Cells[row - 1, "L"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "M"], sheet.Cells[row - 1, "M"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "N"], sheet.Cells[row - 1, "N"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "O"], sheet.Cells[row - 1, "O"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "P"], sheet.Cells[row - 1, "P"]).NumberFormatLocal = currencyFormat;

                    foreach (Range range in sheet.UsedRange.Rows)
                    {
                        range.EntireRow.AutoFit();
                    }

                    foreach (Range range in sheet.UsedRange.Columns)
                    {
                        range.EntireColumn.AutoFit();
                    }

                    sheet.UsedRange.Font.Name = "����";
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

                        string location = caseGroup.First().OwnerDepartment.Location.LocationName;
                        if (!System.IO.Directory.Exists(this.tbFilePath.Text + "\\" + location + "\\"))
                        {
                            System.IO.Directory.CreateDirectory(this.tbFilePath.Text + "\\" + location + "\\");
                        }

                        string filePath = this.tbFilePath.Text + "\\" + location + "\\" + caseGroup.Key.ToString() + ext;
                        int count = 1;
                        while (System.IO.File.Exists(filePath))
                        {
                            filePath = this.tbFilePath.Text + "\\" + location + "\\" + caseGroup.Key.ToString() + "_" + count + ext;
                            count++;
                        }

                        workbook.SaveAs(filePath, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, false, Type.Missing, Type.Missing, Type.Missing);
                    }
                }
            }
            catch (Exception)
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

                throw;
            }
            finally
            {
                if (app != null)
                {
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="caseGroup"></param>
        private void FillLegarTotalSheet(Worksheet sheet, IGrouping<Client, Case> caseGroup)
        {
            sheet.Cells[9, "A"] = "ҵ����";
            sheet.Cells[9, "B"] = "��Ʊ��";
            sheet.Cells[9, "C"] = "ת�ý��";
            sheet.Cells[9, "D"] = "��Ʊ��";
            sheet.Cells[9, "E"] = "������";
            sheet.Cells[9, "F"] = "ת����";
            sheet.Cells[9, "G"] = "���ʽ��";
            sheet.Cells[9, "H"] = "������";
            sheet.Cells[9, "I"] = "���ʵ�����";
            sheet.Cells[9, "J"] = "������";
            sheet.Cells[9, "K"] = "�˿����";
            sheet.Cells[9, "L"] = "������";
            sheet.Cells[9, "M"] = "������";
            sheet.Cells[9, "N"] = "�������";
            sheet.Cells[9, "O"] = "������";
            sheet.Cells[9, "P"] = "������";
            sheet.Cells[9, "Q"] = "��ע";

            Client client = caseGroup.Key;
            string transactionType = caseGroup.First().TransactionType;

            List<string> sellerList = new List<string>();
            List<string> buyerList = new List<string>();
            List<string> factorList = new List<string>();
            List<string> clientReviewList = new List<string>();

            string invoiceCurrency = null;
            double totalAssignOutstanding = 0;
            double totalFinanceOutstanding = 0;

            int row = 10;
            foreach (Case selectedCase in caseGroup)
            {
                CDA cda = selectedCase.ActiveCDA;

                string seller = selectedCase.SellerClient.ToString();
                if (!sellerList.Contains(seller))
                {
                    sellerList.Add(seller);
                }

                string buyer = selectedCase.BuyerClient.ToString();
                if (!buyerList.Contains(buyer))
                {
                    buyerList.Add(buyer);
                }

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

                double financeOutstanding = selectedCase.FinanceOutstanding.GetValueOrDefault();
                if (selectedCase.InvoiceCurrency != invoiceCurrency)
                {
                    double rate = Exchange.GetExchangeRate(selectedCase.InvoiceCurrency, invoiceCurrency);
                    financeOutstanding *= rate;
                }
                totalFinanceOutstanding += financeOutstanding;

                foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in batch.Invoices)
                    {
                        int step = 1;
                        sheet.Cells[row, "A"] = invoice.InvoiceAssignBatch.AssignBatchNo;
                        sheet.Cells[row, "B"] = "'" + invoice.InvoiceNo;
                        sheet.Cells[row, "C"] = invoice.AssignAmount;
                        sheet.Cells[row, "D"] = invoice.InvoiceDate;
                        sheet.Cells[row, "E"] = invoice.DueDate;
                        sheet.Cells[row, "F"] = batch.AssignDate;

                        int recordStep = 0;
                        for (int i = 0; i < invoice.InvoiceFinanceLogs.Count; i++)
                        {
                            InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[i];
                            sheet.Cells[row + recordStep, "G"] = financeLog.FinanceAmount;
                            sheet.Cells[row + recordStep, "H"] = financeLog.FinanceDate;
                            sheet.Cells[row + recordStep, "I"] = financeLog.FinanceDueDate;
                            sheet.Cells[row + recordStep, "N"] = financeLog.FinanceOutstanding;

                            for (int j = 0; j < financeLog.InvoiceRefundLogs.Count; j++)
                            {
                                InvoiceRefundLog refundLog = financeLog.InvoiceRefundLogs[j];
                                sheet.Cells[row + recordStep + j, "M"] = refundLog.RefundAmount;
                                sheet.Cells[row + recordStep + j, "O"] = refundLog.RefundDate;
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

                        sheet.Cells[row, "P"] = invoice.Commission;
                        sheet.Cells[row, "Q"] = invoice.Comment;

                        row += step;
                    }
                }

                string currencyFormat = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);
                sheet.get_Range(sheet.Cells[9, "A"], sheet.Cells[row - 1, "Q"]).Borders.LineStyle = 1;
                sheet.get_Range(sheet.Cells[10, "C"], sheet.Cells[row - 1, "C"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "D"], sheet.Cells[row - 1, "D"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "E"], sheet.Cells[row - 1, "E"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "F"], sheet.Cells[row - 1, "F"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "G"], sheet.Cells[row - 1, "G"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "H"], sheet.Cells[row - 1, "H"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "I"], sheet.Cells[row - 1, "I"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "J"], sheet.Cells[row - 1, "J"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "K"], sheet.Cells[row - 1, "K"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "L"], sheet.Cells[row - 1, "L"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "M"], sheet.Cells[row - 1, "M"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "N"], sheet.Cells[row - 1, "N"]).NumberFormatLocal = currencyFormat;
                sheet.get_Range(sheet.Cells[10, "O"], sheet.Cells[row - 1, "O"]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[10, "P"], sheet.Cells[row - 1, "P"]).NumberFormatLocal = currencyFormat;
            }

            sheet.get_Range("A4", "I7").Borders.LineStyle = 1;
            sheet.get_Range("L4", "M8").Borders.LineStyle = 1;
            sheet.get_Range("O4", "P8").Borders.LineStyle = 1;

            sheet.get_Range("A1", "Q1").MergeCells = true;
            sheet.get_Range("A1", "A1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[1, "A"] = "���۷ֻ���̨��";
            sheet.Cells[2, "P"] = String.Format("��λ��{0}", invoiceCurrency);
            sheet.Cells[3, "A"] = "����/�ֲ�";
            sheet.Cells[3, "B"] = caseGroup.First().OwnerDepartment.DepartmentName;

            sheet.Cells[4, "A"] = "Seller Name";
            sheet.get_Range("B4", "I4").MergeCells = true;
            sheet.Cells[4, "B"] = sellerList.Count == 1 ? sellerList[0] : String.Join(";", sellerList.ToArray());
            sheet.Cells[5, "A"] = "Buyer Name";
            sheet.get_Range("B5", "I5").MergeCells = true;
            sheet.Cells[5, "B"] = buyerList.Count == 1 ? buyerList[0] : String.Join(";", buyerList.ToArray());

            sheet.get_Range("B6", "I6").MergeCells = true;
            sheet.Cells[6, "A"] = "Factor Name";
            sheet.Cells[6, "B"] = factorList.Count == 1 ? factorList[0] : String.Join(";", factorList.ToArray());

            sheet.get_Range("B7", "I7").MergeCells = true;
            sheet.Cells[7, "A"] = "Э���������";
            sheet.Cells[7, "B"] = clientReviewList.Count == 1 ? clientReviewList[0] : String.Join(";", clientReviewList.ToArray());

            sheet.get_Range(sheet.Cells[4, "L"], sheet.Cells[4, "M"]).MergeCells = true;
            sheet.Cells[4, "L"] = "���÷��յ���";
            sheet.Cells[5, "L"] = "��׼���";
            sheet.Cells[6, "L"] = "������";
            sheet.Cells[7, "L"] = "��ʣ����";
            if (transactionType == "���ڱ���")
            {
                ClientCreditLine creditLine = client.AssignCreditLine;
                if (creditLine != null)
                {
                    sheet.Cells[5, "M"] = creditLine.CreditLine;
                    sheet.Cells[6, "M"] = creditLine.PeriodEnd;
                    sheet.Cells[7, "M"] = creditLine.CreditLine - totalAssignOutstanding;
                    sheet.get_Range(sheet.Cells[5, "M"], sheet.Cells[5, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(creditLine.CreditLineCurrency);
                    sheet.get_Range(sheet.Cells[6, "M"], sheet.Cells[6, "M"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[7, "M"], sheet.Cells[7, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(creditLine.CreditLineCurrency);
                }
            }


            sheet.Cells[8, "L"] = "���˿����";
            sheet.Cells[8, "M"] = totalAssignOutstanding;
            sheet.get_Range(sheet.Cells[8, "M"], sheet.Cells[8, "M"]).NumberFormatLocal = TypeUtil.GetExcelCurr(invoiceCurrency);

            sheet.get_Range(sheet.Cells[4, "O"], sheet.Cells[4, "P"]).MergeCells = true;
            sheet.Cells[4, "O"] = "���ʶ��";
            sheet.Cells[5, "O"] = "��׼�ܶ��";
            sheet.Cells[6, "O"] = "������";
            sheet.Cells[7, "O"] = "��ʣ����";

            {
                ClientCreditLine creditLine = client.FinanceCreditLine;
                if (creditLine != null)
                {
                    sheet.Cells[5, "P"] = creditLine.CreditLine;
                    sheet.Cells[6, "P"] = creditLine.PeriodEnd;
                    sheet.Cells[7, "P"] = creditLine.CreditLine - totalFinanceOutstanding;
                    sheet.get_Range(sheet.Cells[5, "P"], sheet.Cells[5, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(creditLine.CreditLineCurrency);
                    sheet.get_Range(sheet.Cells[6, "P"], sheet.Cells[6, "P"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[7, "P"], sheet.Cells[7, "P"]).NumberFormatLocal = TypeUtil.GetExcelCurr(creditLine.CreditLineCurrency);
                }
            }

            sheet.Cells[8, "O"] = "���������";
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

            sheet.UsedRange.Font.Name = "����";

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

		#endregion?Methods?
    }
}
