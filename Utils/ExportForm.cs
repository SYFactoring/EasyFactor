
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
        /// <summary>
        /// 
        /// </summary>
        private ExportType exportType;

        /// <summary>
        /// 
        /// </summary>
        public enum ExportType
        {
            /// <summary>
            /// 
            /// </summary>
            EXPORT_INVOICES,
            /// <summary>
            /// 
            /// </summary>
            EXPORT_INVOICES_BY_BATCH,
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exportType"></param>
        public ExportForm(ExportType exportType)
        {
            this.InitializeComponent();
            this.exportType = exportType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objArray"></param>
        public void StartExport(IList objArray)
        {
            this.Show();
            backgroundWorker.RunWorkerAsync(objArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            switch (exportType)
            {
                case ExportType.EXPORT_INVOICES_BY_BATCH:
                    e.Result = ExportInvoices((IList)e.Argument, worker, e);
                    break;
                case ExportType.EXPORT_INVOICES:
                    e.Result = ExportInvoices((IList)e.Argument, worker, e);
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
            this.tbStatus.Text = String.Format("导出进度 {0:G}%", e.ProgressPercentage);
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
        private int ExportInvoices(IList invoiceList, BackgroundWorker worker, DoWorkEventArgs e)
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
                datasheet.Cells[1, column++] = "发票号/贷项通知";
                datasheet.Cells[1, column++] = "票面金额";
                datasheet.Cells[1, column++] = "转让金额";
                datasheet.Cells[1, column++] = "发票日期";
                datasheet.Cells[1, column++] = "到期日";
                datasheet.Cells[1, column++] = "是否瑕疵";
                datasheet.Cells[1, column++] = "融资金额";
                datasheet.Cells[1, column++] = "融资日";
                datasheet.Cells[1, column++] = "融资到期日";
                datasheet.Cells[1, column++] = "付款金额";
                datasheet.Cells[1, column++] = "付款日";
                datasheet.Cells[1, column++] = "还款金额";
                datasheet.Cells[1, column++] = "还款日";
                datasheet.Cells[1, column++] = "手续费";
                datasheet.Cells[1, column++] = "手续费收取日";
                datasheet.Cells[1, column++] = "利息";
                datasheet.Cells[1, column++] = "利息收取日";
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
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                    datasheet.Cells[row + 2, column++] = invoice.DueDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                    datasheet.Cells[row + 2, column++] = invoice.FinanceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDate;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDueDate;
                    datasheet.Cells[row + 2, column++] = invoice.PaymentAmount2;
                    datasheet.Cells[row + 2, column++] = invoice.RefundAmount2;
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    datasheet.Cells[row + 2, column++] = invoice.CommissionDate;
                    datasheet.Cells[row + 2, column++] = invoice.Interest;
                    datasheet.Cells[row + 2, column++] = invoice.InterestDate;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;
                    datasheet.Cells[row + 2, column++] = "'" + invoice.CreditNoteNo2;
                    datasheet.Cells[row + 2, column++] = invoice.CreditNoteDate2;

                    worker.ReportProgress((int)((float)row * 100 / (float)size));
                }

                foreach (Range range in datasheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                    if (range.Column == 2 || range.Column == 3 || range.Column == 7 || range.Column == 10 || range.Column == 12 || range.Column == 14 || range.Column == 16)
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
                    app.Quit();
                    Marshal.ReleaseComObject(app);
                    app = null;
                }
                throw e1;
            }
            return invoiceList.Count;
        }
    }
}
