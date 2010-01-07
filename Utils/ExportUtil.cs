
namespace CMBC.EasyFactor.Utils
{
    using System.ComponentModel;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using Microsoft.Office.Interop.Excel;
    using System.Collections.Generic;
    using System.Collections;

    /// <summary>
    /// 
    /// </summary>
    class ExportUtil
    {
        #region Fields (5)

        private System.ComponentModel.BackgroundWorker backgroundWorker;
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
            EXPORT_ASSIGN_FINANCE_PAYMENT,

            /// <summary>
            /// 
            /// </summary>
            EXPORT_ASSIGN,
        }

        #endregion Enums

        #region Constructors (1)

        public ExportUtil(ExportType exportType)
        {
            this.exportType = exportType;

            backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
        }

        #endregion Constructors

        #region Methods (6)

        // Public Methods (1) 

        public void StartExport(IList objArray)
        {
            backgroundWorker.RunWorkerAsync(objArray);
        }
        // Private Methods (5) 

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            switch (exportType)
            {
                case ExportType.EXPORT_ASSIGN_FINANCE_PAYMENT:
                    ExportAssignFinancePayment((IList)e.Argument, worker);
                    break;
                case ExportType.EXPORT_ASSIGN:
                    ExportAssign((IList)e.Argument, worker);
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objArray"></param>
        /// <param name="worker"></param>
        private void ExportAssign(IList objArray, BackgroundWorker worker)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            int column = 1;
            datasheet.Cells[1, column++] = "CDA编号";
            datasheet.Cells[1, column++] = "转让批次号";
            datasheet.Cells[1, column++] = "转让批次币别";
            datasheet.Cells[1, column++] = "转让批次日";
            datasheet.Cells[1, column++] = "是否生成报文";
            datasheet.Cells[1, column++] = "本次转让备注";
            datasheet.Cells[1, column++] = "转让经办人";
            datasheet.Cells[1, column++] = "发票号";
            datasheet.Cells[1, column++] = "发票币别";
            datasheet.Cells[1, column++] = "票面金额";
            datasheet.Cells[1, column++] = "转让金额";
            datasheet.Cells[1, column++] = "发票日期";
            datasheet.Cells[1, column++] = "到期日";
            datasheet.Cells[1, column++] = "转让日";
            datasheet.Cells[1, column++] = "是否瑕疵";
            datasheet.Cells[1, column++] = "瑕疵原因";
            datasheet.Cells[1, column++] = "瑕疵解除原因";
            datasheet.Cells[1, column++] = "瑕疵解除日";
            datasheet.Cells[1, column++] = "瑕疵解除人";

            int size = objArray.Count;
            for (int row = 0; row < size; row++)
            {
                column = 1;
                Invoice invoice = (Invoice)objArray[row];
                if (invoice.InvoiceAssignBatch != null)
                {
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CDA.CDACode;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.AssignBatchNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.BatchCurrency;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.BatchDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.InvoiceAssignBatch.IsCreateMsg);
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CreateUserName;
                }
                column = 8;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceNo;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceCurrency;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceAmount;
                datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                datasheet.Cells[row + 2, column++] = invoice.DueDate;
                datasheet.Cells[row + 2, column++] = invoice.AssignDate;
                datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                datasheet.Cells[row + 2, column++] = invoice.FlawReason;
                datasheet.Cells[row + 2, column++] = invoice.FlawResolveReason;
                datasheet.Cells[row + 2, column++] = invoice.FlawResolveDate;
                datasheet.Cells[row + 2, column++] = invoice.FlawResolveUserName;
            }

            foreach (Range range in datasheet.UsedRange.Columns)
            {
                range.EntireColumn.AutoFit();
                if (range.Column == 10 || range.Column == 11)
                {
                    range.NumberFormatLocal = "0.00";
                }
            }

            app.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objArray"></param>
        /// <param name="worker"></param>
        private void ExportAssignFinancePayment(IList objArray, BackgroundWorker worker)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet datasheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            int column = 1;
            datasheet.Cells[1, column++] = "CDA编号";
            datasheet.Cells[1, column++] = "转让批次号";
            datasheet.Cells[1, column++] = "转让批次币别";
            datasheet.Cells[1, column++] = "转让批次日";
            datasheet.Cells[1, column++] = "是否生成报文";
            datasheet.Cells[1, column++] = "本次转让备注";
            datasheet.Cells[1, column++] = "转让经办人";
            datasheet.Cells[1, column++] = "发票号";
            datasheet.Cells[1, column++] = "发票币别";
            datasheet.Cells[1, column++] = "票面金额";
            datasheet.Cells[1, column++] = "转让金额";
            datasheet.Cells[1, column++] = "发票日期";
            datasheet.Cells[1, column++] = "到期日";
            datasheet.Cells[1, column++] = "转让日";
            datasheet.Cells[1, column++] = "是否瑕疵";
            datasheet.Cells[1, column++] = "瑕疵原因";
            datasheet.Cells[1, column++] = "瑕疵解除原因";
            datasheet.Cells[1, column++] = "瑕疵解除日";
            datasheet.Cells[1, column++] = "瑕疵解除人";
            datasheet.Cells[1, column++] = "生效日";
            datasheet.Cells[1, column++] = "融资编号（即放款编号）";
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
            datasheet.Cells[1, column++] = "融资经办人";
            datasheet.Cells[1, column++] = "融资金额";
            datasheet.Cells[1, column++] = "融资日";
            datasheet.Cells[1, column++] = "融资到期日";
            datasheet.Cells[1, column++] = "付款批次号";
            datasheet.Cells[1, column++] = "付款类型";
            datasheet.Cells[1, column++] = "付款批次日";
            datasheet.Cells[1, column++] = "是否生成报文";
            datasheet.Cells[1, column++] = "本次付款备注";
            datasheet.Cells[1, column++] = "销账经办人";
            datasheet.Cells[1, column++] = "付款金额";
            datasheet.Cells[1, column++] = "付款日";
            datasheet.Cells[1, column++] = "还款金额";
            datasheet.Cells[1, column++] = "还款日";
            datasheet.Cells[1, column++] = "手续费";
            datasheet.Cells[1, column++] = "手续费收取日";
            datasheet.Cells[1, column++] = "利息";
            datasheet.Cells[1, column++] = "利息收取日";
            datasheet.Cells[1, column++] = "备注";

            int size = objArray.Count;
            for (int row = 0; row < size; row++)
            {
                column = 1;
                Invoice invoice = (Invoice)objArray[row];
                if (invoice.InvoiceAssignBatch != null)
                {
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CDA.CDACode;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.AssignBatchNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.BatchCurrency;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.BatchDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.InvoiceAssignBatch.IsCreateMsg);
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceAssignBatch.CreateUserName;
                }
                column = 8;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceNo;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceCurrency;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceAmount;
                datasheet.Cells[row + 2, column++] = invoice.AssignAmount;
                datasheet.Cells[row + 2, column++] = invoice.InvoiceDate;
                datasheet.Cells[row + 2, column++] = invoice.DueDate;
                datasheet.Cells[row + 2, column++] = invoice.AssignDate;
                datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                datasheet.Cells[row + 2, column++] = invoice.FlawReason;
                datasheet.Cells[row + 2, column++] = invoice.FlawResolveReason;
                datasheet.Cells[row + 2, column++] = invoice.FlawResolveDate;
                datasheet.Cells[row + 2, column++] = invoice.FlawResolveUserName;
                datasheet.Cells[row + 2, column++] = invoice.ValueDate;
                if (invoice.InvoiceFinanceBatch != null)
                {
                    column = 21;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinanceBatchNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinanceType;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FactorCode;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.Factor == null ? string.Empty : invoice.InvoiceFinanceBatch.Factor.ToString();
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.BatchCurrency;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinanceRate;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.CostRate;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.InterestType;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinancePeriodBegin;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.FinnacePeriodEnd;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.InvoiceFinanceBatch.CreateUserName;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceAmount;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDate;
                    datasheet.Cells[row + 2, column++] = invoice.FinanceDueDate;
                }
                if (invoice.InvoicePaymentBatch != null)
                {
                    column = 36;
                    datasheet.Cells[row + 2, column++] = invoice.InvoicePaymentBatch.PaymentBatchNo;
                    datasheet.Cells[row + 2, column++] = invoice.InvoicePaymentBatch.PaymentType;
                    datasheet.Cells[row + 2, column++] = invoice.InvoicePaymentBatch.PaymentDate;
                    datasheet.Cells[row + 2, column++] = TypeUtil.ConvertBoolToStr(invoice.InvoicePaymentBatch.IsCreateMsg);
                    datasheet.Cells[row + 2, column++] = invoice.InvoicePaymentBatch.Comment;
                    datasheet.Cells[row + 2, column++] = invoice.InvoicePaymentBatch.CreateUserName;
                    datasheet.Cells[row + 2, column++] = invoice.PaymentAmount;
                    datasheet.Cells[row + 2, column++] = invoice.PaymentDate;
                    datasheet.Cells[row + 2, column++] = invoice.RefundAmount;
                    datasheet.Cells[row + 2, column++] = invoice.RefundDate;
                    datasheet.Cells[row + 2, column++] = invoice.Commission;
                    datasheet.Cells[row + 2, column++] = invoice.CommissionDate;
                    datasheet.Cells[row + 2, column++] = invoice.Interest;
                    datasheet.Cells[row + 2, column++] = invoice.InterestDate;
                    datasheet.Cells[row + 2, column++] = invoice.Comment;
                }
            }

            foreach (Range range in datasheet.UsedRange.Columns)
            {
                range.EntireColumn.AutoFit();
                if (range.Column == 10 || range.Column == 11 || range.Column == 33 || range.Column == 42 || range.Column == 44 || range.Column == 46 || range.Column == 48)
                {
                    range.NumberFormatLocal = "0.00";
                }
            }

            app.Visible = true;
        }


        #endregion Methods
    }
}
