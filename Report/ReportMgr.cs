
namespace CMBC.EasyFactor.Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using Microsoft.Office.Interop.Excel;
    using Microsoft.Office.Core;
    using CMBC.EasyFactor.ARMgr;

    /// <summary>
    /// 
    /// </summary>
    public partial class ReportMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpReportType opReportType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpReportType
        {
            /// <summary>
            /// 
            /// </summary>
            REPORT_AR,

            /// <summary>
            /// 
            /// </summary>
            REPORT_FINANCE
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opReportType"></param>
        public ReportMgr(OpReportType opReportType)
        {
            InitializeComponent();
            this.opReportType = opReportType;
            this.bs = new BindingSource();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);
        }

        #endregion Constructors

        #region Methods (5)

        // Private Methods (5) 

        private void GenerateAssignReport(List<Invoice> invoiceList)
        {
            Microsoft.Office.Interop.Excel.Application app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Workbook workbook = app.Workbooks.Add(true);
            Worksheet sheet = workbook.Worksheets[1] as Worksheet;
            if (!(this.bs.DataSource is List<Invoice>))
            {
                return;
            }

            Invoice firstInvoice = invoiceList[0];
            Case selectedCase = firstInvoice.InvoiceAssignBatch.CDA.Case;

            string executablePath = System.Windows.Forms.Application.ExecutablePath;
            string logoPath = executablePath.Substring(0, executablePath.IndexOf("bin")) + "\\Properties\\Resources\\Images\\FOMSLOGO.png";
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 180, 40);

            sheet.Cells[1, 1] = "致";
            sheet.Cells[1, 2] = selectedCase.SellerClient.ToString();
            sheet.Cells[1, 3] = "公司";
            sheet.Cells[3, 2] = "应收账款转让明细表";
            sheet.Cells[5, 1] = "买方:";
            sheet.Cells[5, 2] = selectedCase.BuyerClient.ToString();
            sheet.Cells[5, 3] = "（应收账款债务人）";
            sheet.Cells[6, 1] = "进口保理商：";
            sheet.Cells[6, 2] = selectedCase.BuyerFactor.ToString();
            sheet.Cells[7, 1] = "信用风险额度：";
            sheet.Cells[8, 1] = "应收账款余额：";

            sheet.Cells[10, 1] = "发票号";
            sheet.Cells[10, 2] = "转让金额";
            sheet.Cells[10, 3] = "发票日期";
            sheet.Cells[10, 4] = "到期日";
            sheet.Cells[10, 5] = "文件瑕疵";

            int count = invoiceList.Count;
            for (int row = 0; row < count; row++)
            {
                sheet.Cells[row + 11, 1] = invoiceList[row].InvoiceNo;
                sheet.Cells[row + 11, 2] = invoiceList[row].AssignAmount;
                sheet.Cells[row + 11, 3] = invoiceList[row].InvoiceDate;
                sheet.Cells[row + 11, 4] = invoiceList[row].DueDate;
                sheet.Cells[row + 11, 5] = invoiceList[row].IsFlaw == false ? "否" : "是";
            }

            sheet.Cells[13 + count, 1] = "本行已完成上述发票/贷项发票转让，特此通知";
            sheet.Cells[14 + count, 3] = "中国民生银行____________（业务章）";
            sheet.Cells[15 + count, 3] = "签字：";
            sheet.Cells[16 + count, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "楷体";
            sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            sheet.get_Range(sheet.Cells[1, 2], sheet.Cells[1, 2]).Font.Underline = true;
            sheet.get_Range(sheet.Cells[2, 1], sheet.Cells[2, 5]).RowHeight = 30;
            sheet.get_Range(sheet.Cells[3, 2], sheet.Cells[3, 2]).Font.Size = 24;
            sheet.get_Range(sheet.Cells[5, 2], sheet.Cells[5, 2]).Font.Underline = true;
            sheet.get_Range(sheet.Cells[6, 2], sheet.Cells[6, 2]).Font.Underline = true;
            sheet.get_Range(sheet.Cells[10, 1], sheet.Cells[10 + count, 5]).Borders.LineStyle = 1;
            sheet.get_Range(sheet.Cells[10, 1], sheet.Cells[10, 5]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[16 + count, 1]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 2], sheet.Cells[16 + count, 2]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 3], sheet.Cells[16 + count, 3]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 4], sheet.Cells[16 + count, 4]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 5], sheet.Cells[16 + count, 5]).ColumnWidth = 15;

            sheet.get_Range(sheet.Cells[11, 1], sheet.Cells[16 + count, 1]).NumberFormatLocal = "@";
            sheet.get_Range(sheet.Cells[11, 1], sheet.Cells[16 + count, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[11, 2], sheet.Cells[16 + count, 2]).NumberFormatLocal = "0.00";
            sheet.get_Range(sheet.Cells[11, 3], sheet.Cells[16 + count, 3]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[11, 4], sheet.Cells[16 + count, 4]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[11, 5], sheet.Cells[16 + count, 5]).NumberFormatLocal = "0.00";
            app.Visible = true;
        }

        private void GenerateFinanceReport(List<Invoice> invoiceList)
        {
            Microsoft.Office.Interop.Excel.Application app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Workbook workbook = app.Workbooks.Add(true);
            Worksheet sheet = workbook.Worksheets[1] as Worksheet;
            if (!(this.bs.DataSource is List<Invoice>))
            {
                return;
            }

            Invoice firstInvoice = invoiceList[0];
            Case selectedCase = firstInvoice.InvoiceAssignBatch.CDA.Case;

            string executablePath = System.Windows.Forms.Application.ExecutablePath;
            string logoPath = executablePath.Substring(0, executablePath.IndexOf("bin")) + "\\Properties\\Resources\\Images\\FOMSLOGO.png";
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 180, 40);

            sheet.Cells[2, 2] = "可融资账款明细表";
            sheet.Cells[4, 1] = "卖方";
            sheet.Cells[4, 2] = selectedCase.SellerClient.ToString();
            sheet.Cells[4, 3] = "公司";
            sheet.Cells[5, 1] = "买方:";
            sheet.Cells[5, 2] = selectedCase.BuyerClient.ToString();
            sheet.Cells[5, 3] = "（应收账款债务人）";
            sheet.Cells[6, 1] = "进口保理商：";
            sheet.Cells[6, 2] = selectedCase.BuyerFactor.ToString();
            sheet.Cells[7, 1] = "信用风险额度：";
            sheet.Cells[8, 1] = "应收账款余额：";
            sheet.Cells[9, 1] = "预付款额度：";
            sheet.Cells[10, 1] = "融资余额：";

            sheet.Cells[12, 1] = "发票号";
            sheet.Cells[12, 2] = "转让金额";
            sheet.Cells[12, 3] = "发票日期";
            sheet.Cells[12, 4] = "到期日";
            sheet.Cells[12, 5] = "备注";

            int count = invoiceList.Count;
            for (int row = 0; row < count; row++)
            {
                sheet.Cells[row + 13, 1] = invoiceList[row].InvoiceNo;
                sheet.Cells[row + 13, 2] = invoiceList[row].AssignAmount;
                sheet.Cells[row + 13, 3] = invoiceList[row].InvoiceDate;
                sheet.Cells[row + 13, 4] = invoiceList[row].DueDate;
                sheet.Cells[row + 13, 5] = invoiceList[row].Comment;
            }

            sheet.Cells[16 + count, 3] = "中国民生银行__________（业务章）";
            sheet.Cells[17 + count, 3] = "签字：";
            sheet.Cells[18 + count, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "楷体";
            sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 5]).RowHeight = 30;
            sheet.get_Range(sheet.Cells[2, 2], sheet.Cells[2, 2]).Font.Size = 24;
            sheet.get_Range(sheet.Cells[5, 2], sheet.Cells[5, 2]).Font.Underline = true;
            sheet.get_Range(sheet.Cells[6, 2], sheet.Cells[6, 2]).Font.Underline = true;
            sheet.get_Range(sheet.Cells[12, 1], sheet.Cells[12 + count, 5]).Borders.LineStyle = 1;
            sheet.get_Range(sheet.Cells[12, 1], sheet.Cells[12, 5]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[16 + count, 1]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 2], sheet.Cells[16 + count, 2]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 3], sheet.Cells[16 + count, 3]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 4], sheet.Cells[16 + count, 4]).ColumnWidth = 15;
            sheet.get_Range(sheet.Cells[1, 5], sheet.Cells[16 + count, 5]).ColumnWidth = 15;

            sheet.get_Range(sheet.Cells[11, 1], sheet.Cells[16 + count, 1]).NumberFormatLocal = "@";
            sheet.get_Range(sheet.Cells[11, 1], sheet.Cells[16 + count, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[11, 2], sheet.Cells[16 + count, 2]).NumberFormatLocal = "0.00";
            sheet.get_Range(sheet.Cells[11, 3], sheet.Cells[16 + count, 3]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[11, 4], sheet.Cells[16 + count, 4]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[11, 5], sheet.Cells[16 + count, 5]).NumberFormatLocal = "@";
            sheet.get_Range(sheet.Cells[11, 5], sheet.Cells[16 + count, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            app.Visible = true;
        }

        private void GenerateReport(object sender, EventArgs e)
        {
            List<Invoice> invoiceList = this.bs.DataSource as List<Invoice>;
            if (invoiceList == null || invoiceList.Count == 0)
            {
                return;
            }

            switch (opReportType)
            {
                case OpReportType.REPORT_AR:
                    GenerateAssignReport(invoiceList);
                    break;
                case OpReportType.REPORT_FINANCE:
                    GenerateFinanceReport(invoiceList);
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
        private void QueryInvoices(object sender, EventArgs e)
        {
            string sellerName = this.tbSeller.Text;
            string buyerName = this.tbBuyer.Text;
            string factorName = this.tbFactor.Text;

            DateTime beginDate = this.diAssignDateBegin.MinDate;
            if (this.diAssignDateBegin.Value > this.diAssignDateBegin.MinDate)
            {
                beginDate = this.diAssignDateBegin.Value;
            }

            DateTime endDate = this.diAssignDateEnd.MaxDate;
            if (this.diAssignDateEnd.Value > this.diAssignDateEnd.MinDate && this.diAssignDateEnd.Value < this.diAssignDateEnd.MaxDate)
            {
                endDate = this.diAssignDateEnd.Value;
            }

            var queryResult = from invoice in App.Current.DbContext.Invoices
                              let seller = invoice.InvoiceAssignBatch.CDA.Case.SellerClient
                              where seller.ClientNameCN.Contains(sellerName) || seller.ClientNameEN_1.Contains(sellerName) || seller.ClientNameEN_2.Contains(sellerName)
                              let buyer = invoice.InvoiceAssignBatch.CDA.Case.BuyerClient
                              where buyer.ClientNameCN.Contains(buyerName) || buyer.ClientNameEN_1.Contains(buyerName) || buyer.ClientNameEN_2.Contains(buyerName)
                              let sellerFactor = invoice.InvoiceAssignBatch.CDA.Case.SellerFactor
                              where sellerFactor.CompanyNameCN.Contains(factorName) || sellerFactor.CompanyNameEN.Contains(factorName)
                              let buyerFactor = invoice.InvoiceAssignBatch.CDA.Case.BuyerFactor
                              where buyerFactor.CompanyNameCN.Contains(factorName) || buyerFactor.CompanyNameEN.Contains(factorName)
                              where
                                  invoice.IsFlaw==this.cbIsFlaw.Checked
                                 && (beginDate == this.diAssignDateBegin.MinDate ? true : invoice.AssignDate > beginDate.AddDays(-1))
                                 && (endDate == this.diAssignDateEnd.MaxDate ? true : invoice.AssignDate < endDate.AddDays(1))
                              select invoice;

            this.bs.DataSource = queryResult.ToList();
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        private void Reset(object sender, EventArgs e)
        {
            this.tbSeller.Text = string.Empty;
            this.tbBuyer.Text = string.Empty;
            this.tbFactor.Text = string.Empty;
            this.diAssignDateBegin.Value = default(DateTime);
            this.diAssignDateEnd.Value = default(DateTime);
        }

        #endregion Methods

        private void DetailInvoice(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            string ino = (string)dgvInvoices["colInvoiceNo", dgvInvoices.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                Invoice selectedInvoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
                if (selectedInvoice != null)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
                    invoiceDetail.ShowDialog(this);
                }
            }
        }
    }
}
