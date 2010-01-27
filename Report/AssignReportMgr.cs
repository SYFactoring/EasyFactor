//-----------------------------------------------------------------------
// <copyright file="AssignReportMgr.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Report
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.ARMgr;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using Microsoft.Office.Core;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class AssignReportMgr : UserControl
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
            REPORT_ASSIGN,

            /// <summary>
            /// 
            /// </summary>
            REPORT_FINANCE,

            /// <summary>
            /// 
            /// </summary>
            REPORT_FEE
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the AssginReportMgr class.
        /// </summary>
        /// <param name="opReportType"></param>
        public AssignReportMgr(OpReportType opReportType)
        {
            this.InitializeComponent();
            this.opReportType = opReportType;
            this.bs = new BindingSource();
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvInvoices);

            //if (this.opReportType == OpReportType.REPORT_ASSIGN)
            //{
            //    this.diAssignDateBegin.Value = DateTime.Now.Date;
            //    this.diAssignDateEnd.Value = DateTime.Now.Date;
            //    this.QueryInvoices(null, null);
            //}
            if (this.opReportType == OpReportType.REPORT_FINANCE)
            {
                this.cbIsFlaw.Checked = false;
                this.cbIsFlaw.Enabled = false;
                this.diAssignDateEnd.Value = DateTime.Now.Date;
            }
            //else if (this.opReportType == OpReportType.REPORT_FEE)
            //{
            //    this.diAssignDateBegin.Value = DateTime.Now.Date;
            //    this.diAssignDateEnd.Value = DateTime.Now.Date;
            //}
        }

        #endregion Constructors

        #region Methods (12)

        // Private Methods (12) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell == null)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (this.dgvInvoices.CurrentCell.RowIndex == -1)
            {
                return;
            }

            Invoice selectedInvoice = (Invoice)this.bs.List[this.dgvInvoices.CurrentCell.RowIndex];
            InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvInvoices.Columns[e.ColumnIndex];
            if (column == this.colIsFlaw)
            {
                object originalData = e.Value;
                if (originalData != null)
                {
                    bool result = (bool)originalData;
                    if (result)
                    {
                        e.Value = "Y";
                    }
                    else
                    {
                        e.Value = "N";
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        //private void GenerateAssignReport(List<Invoice> invoiceList)
        //{
        //    IEnumerable<IGrouping<Client, Invoice>> groupsBySeller = invoiceList.GroupBy(i => i.InvoiceAssignBatch.CDA.Case.SellerClient);
        //    foreach (IGrouping<Client, Invoice> sellerGroup in groupsBySeller)
        //    {
        //        Client seller = sellerGroup.Key;
        //        ApplicationClass app = new ApplicationClass() { Visible = false };
        //        if (app == null)
        //        {
        //            MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }

        //        Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

        //        string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
        //        sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 180, 40);

        //        sheet.Cells[1, 1] = String.Format("致{0}", seller.ToString());
        //        sheet.Cells[3, 2] = "应收账款转让明细表";
        //        sheet.get_Range(sheet.Cells[3, 2], sheet.Cells[3, 2]).Font.Size = 24;
        //        sheet.get_Range(sheet.Cells[2, 1], sheet.Cells[2, 5]).RowHeight = 30;

        //        IEnumerable<IGrouping<Client, Invoice>> groupsByBuyer = sellerGroup.GroupBy(i => i.InvoiceAssignBatch.CDA.Case.BuyerClient);

        //        int row = 5;
        //        foreach (IGrouping<Client, Invoice> buyerGroup in groupsByBuyer)
        //        {
        //            Client buyer = buyerGroup.Key;
        //            CDA cda = buyerGroup.First().InvoiceAssignBatch.CDA;
        //            Case curCase = cda.Case;
        //            Factor factor = null;
        //            switch (curCase.TransactionType)
        //            {
        //                case "国内卖方保理":
        //                case "国内信保保理":
        //                case "国内买方保理":
        //                case "租赁保理":
        //                    break;
        //                case "国际信保保理":
        //                case "出口保理":
        //                case "进口保理":
        //                    factor = curCase.BuyerFactor;
        //                    break;
        //                default:
        //                    break;
        //            }

        //            sheet.Cells[row, 1] = "买方：";
        //            sheet.Cells[row++, 2] = String.Format("{0}（应收账款债务人）", buyer.ToString());
        //            if (factor != null)
        //            {
        //                sheet.Cells[row, 1] = "进口保理商：";
        //                sheet.Cells[row++, 2] = factor.ToString();
        //            }

        //            sheet.Cells[row, 1] = "信用风险额度：";
        //            sheet.Cells[row++, 2] = String.Format("{0:N2}", cda.CreditCover);
        //            sheet.Cells[row, 1] = "应收账款余额：";
        //            sheet.Cells[row++, 2] = String.Format("{0:N2}", cda.Case.AssignOutstanding);

        //            row++;
        //            sheet.Cells[row, 1] = "发票号";
        //            sheet.Cells[row, 2] = "转让金额";
        //            sheet.Cells[row, 3] = "发票日期";
        //            sheet.Cells[row, 4] = "到期日";
        //            sheet.Cells[row, 5] = "文件瑕疵";

        //            row++;
        //            int invoiceStart = row;
        //            foreach (Invoice invoice in buyerGroup)
        //            {
        //                sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
        //                sheet.Cells[row, 2] = invoice.AssignAmount;
        //                sheet.Cells[row, 3] = invoice.InvoiceDate;
        //                sheet.Cells[row, 4] = invoice.DueDate;
        //                sheet.Cells[row, 5] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
        //                row++;
        //            }

        //            int invoiceEnd = row - 1;
        //            row++;
        //            row++;
        //            sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //            sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = "0.00";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy/MM/dd";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy/MM/dd";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 5], sheet.Cells[invoiceEnd, 5]).NumberFormatLocal = "0.00";
        //            sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]).Borders.LineStyle = 1;
        //        }

        //        row++;
        //        row++;

        //        sheet.Cells[row, 1] = "本行已完成上述发票/贷项发票转让，特此通知";
        //        sheet.Cells[row + 2, 3] = "中国民生银行       （业务章）";
        //        sheet.Cells[row + 3, 3] = "签字：";
        //        sheet.Cells[row + 4, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

        //        sheet.UsedRange.Font.Name = "楷体";

        //        sheet.get_Range("A1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("B1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("D1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("E1", Type.Missing).ColumnWidth = 15;
        //        app.Visible = true;
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        //private void GenerateFeeReport(List<Invoice> invoiceList)
        //{
        //    IEnumerable<IGrouping<Client, Invoice>> groupsBySeller = invoiceList.GroupBy(i => i.InvoiceAssignBatch.CDA.Case.SellerClient);
        //    foreach (IGrouping<Client, Invoice> sellerGroup in groupsBySeller)
        //    {
        //        Client seller = sellerGroup.Key;
        //        ApplicationClass app = new ApplicationClass() { Visible = false };
        //        if (app == null)
        //        {
        //            MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }
        //        Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

        //        string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
        //        sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 180, 40);

        //        sheet.Cells[1, 1] = String.Format("卖方：{0}", seller.ToString());
        //        sheet.Cells[3, 2] = "保理费用明细表";
        //        sheet.get_Range(sheet.Cells[3, 2], sheet.Cells[3, 2]).Font.Size = 24;
        //        sheet.get_Range(sheet.Cells[2, 1], sheet.Cells[2, 5]).RowHeight = 30;

        //        IEnumerable<IGrouping<Client, Invoice>> groupsByBuyer = sellerGroup.GroupBy(i => i.InvoiceAssignBatch.CDA.Case.BuyerClient);

        //        int row = 5;
        //        double totalCommission = 0;
        //        foreach (IGrouping<Client, Invoice> buyerGroup in groupsByBuyer)
        //        {
        //            Client buyer = buyerGroup.Key;
        //            Case curCase = buyerGroup.First().InvoiceAssignBatch.CDA.Case;
        //            Factor factor = null;
        //            switch (curCase.TransactionType)
        //            {
        //                case "国内卖方保理":
        //                case "国内信保保理":
        //                case "国内买方保理":
        //                case "租赁保理":
        //                    break;
        //                case "国际信保保理":
        //                case "出口保理":
        //                case "进口保理":
        //                    factor = curCase.BuyerFactor;
        //                    break;
        //                default:
        //                    break;
        //            }

        //            sheet.Cells[row, 1] = "买方";
        //            sheet.Cells[row++, 2] = String.Format("{0}（应收账款债务人）", buyer.ToString());
        //            if (factor != null)
        //            {
        //                sheet.Cells[row, 1] = "保理商";
        //                sheet.Cells[row, 2] = factor.ToString();
        //            }

        //            sheet.Cells[row, 5] = "币别";
        //            sheet.Cells[row++, 6] = curCase.InvoiceCurrency;
        //            sheet.Cells[row, 1] = "发票号码";
        //            sheet.Cells[row, 2] = "发票金额";
        //            sheet.Cells[row, 3] = "转让日";
        //            sheet.Cells[row, 4] = "保理费率";
        //            sheet.Cells[row, 5] = "单据处理费";
        //            sheet.Cells[row++, 6] = "每笔费用";
        //            int invoiceStart = row;
        //            foreach (Invoice invoice in buyerGroup)
        //            {
        //                sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
        //                sheet.Cells[row, 2] = invoice.AssignAmount;
        //                sheet.Cells[row, 3] = invoice.InvoiceAssignBatch.AssignDate;
        //                sheet.Cells[row, 4] = invoice.InvoiceAssignBatch.CDA.Price;
        //                sheet.Cells[row, 5] = invoice.InvoiceAssignBatch.CDA.HandFee;
        //                sheet.Cells[row, 6] = invoice.Commission;
        //                totalCommission += invoice.Commission.GetValueOrDefault();
        //                totalCommission += invoice.InvoiceAssignBatch.CDA.HandFee.GetValueOrDefault();
        //                row++;
        //            }

        //            int invoiceEnd = row - 1;
        //            row++;
        //            row++;
        //            sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = "0.00";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy/MM/dd";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "0.00%";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 5], sheet.Cells[invoiceEnd, 5]).NumberFormatLocal = "0.00";
        //            sheet.get_Range(sheet.Cells[invoiceStart, 6], sheet.Cells[invoiceEnd, 6]).NumberFormatLocal = "0.00";
        //            sheet.get_Range(sheet.Cells[invoiceStart - 3, 1], sheet.Cells[invoiceEnd, 6]).Borders.LineStyle = 1;
        //        }

        //        row++;
        //        sheet.Cells[row, 4] = "费用总计";
        //        sheet.Cells[row, 5] = String.Format("{0:N2}", totalCommission);
        //        sheet.get_Range(sheet.Cells[row, 4], sheet.Cells[row, 5]).Borders.LineStyle = 1;
        //        row++;
        //        sheet.Cells[row, 1] = "制表：";
        //        sheet.Cells[row, 3] = "复核：";
        //        sheet.Cells[row, 5] = "主管：";
        //        row++;
        //        sheet.Cells[row + 1, 3] = "中国民生银行       （业务章）";
        //        sheet.Cells[row + 2, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

        //        sheet.UsedRange.Font.Name = "楷体";

        //        sheet.get_Range("A1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("B1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("D1", Type.Missing).ColumnWidth = 15;
        //        sheet.get_Range("E1", Type.Missing).ColumnWidth = 15;

        //        app.Visible = true;
        //    }
        //}

        /// <summary>
        /// 可融资账款明细表
        /// </summary>
        /// <param name="invoiceList"></param>
        private void GenerateFinanceReport(List<Invoice> invoiceList)
        {
            IEnumerable<IGrouping<Client, Invoice>> groupsBySeller = invoiceList.GroupBy(i => i.InvoiceAssignBatch.Case.SellerClient);
            foreach (IGrouping<Client, Invoice> sellerGroup in groupsBySeller)
            {
                Client seller = sellerGroup.Key;
                ApplicationClass app = new ApplicationClass() { Visible = false };
                if (app == null)
                {
                    MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

                string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 180, 40);

                sheet.Cells[3, 2] = "可融资账款明细表";
                sheet.get_Range(sheet.Cells[2, 1], sheet.Cells[2, 5]).RowHeight = 30;

                IEnumerable<IGrouping<Client, Invoice>> groupsByBuyer = sellerGroup.GroupBy(i => i.InvoiceAssignBatch.Case.BuyerClient);

                int row = 6;
                foreach (IGrouping<Client, Invoice> buyerGroup in groupsByBuyer)
                {
                    Client buyer = buyerGroup.Key;
                    Case curCase = buyerGroup.First().InvoiceAssignBatch.Case;
                    CDA cda = curCase.ActiveCDA;

                    sheet.Cells[row, 1] = "卖方：";
                    sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).Font.Underline = true;
                    sheet.Cells[row++, 2] = seller.ToString();
                    sheet.Cells[row, 1] = "买方:";
                    sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).Font.Underline = true;
                    sheet.Cells[row++, 2] = String.Format("{0}（应收账款债务人）", buyer.ToString());

                    row++;

                    sheet.Cells[row, 1] = "信用风险额度：";
                    double? creditCoverOutstanding = cda.CreditCover;
                    sheet.Cells[row, 2] = String.Format("{0} {1:N2}", creditCoverOutstanding == null ? "" : cda.CreditCoverCurr, creditCoverOutstanding);
                    sheet.Cells[row, 4] = "最高预付款额度：";
                    ClientCreditLine creditLine = cda.FinanceCreditLine;
                    if (creditLine != null)
                    {
                        sheet.Cells[row, 5] = String.Format("{0} {1:N2}", creditLine.CreditLineCurrency, creditLine.CreditLine);
                    }
                    row++;

                    sheet.Cells[row, 1] = "应收账款余额：";
                    sheet.Cells[row, 2] = String.Format("{0} {1:N2}", cda.Case.InvoiceCurrency, cda.Case.AssignOutstanding);
                    sheet.Cells[row, 4] = "总融资余额：";
                    double? financeOutstanding = null;
                    if (creditLine != null)
                    {
                        financeOutstanding = seller.GetFinanceOutstanding(creditLine.CreditLineCurrency);
                        sheet.Cells[row++, 5] = String.Format("{0} {1:N2}", financeOutstanding == null ? "" : creditLine.CreditLineCurrency, financeOutstanding);
                    }

                    sheet.Cells[row, 1] = "预付款额度：";
                    double? financeLine = cda.FinanceLine;
                    sheet.Cells[row, 2] = String.Format("{0} {1:N2}", financeLine == null ? "" : cda.FinanceLineCurr, financeLine);
                    sheet.Cells[row, 4] = "总剩余额度：";
                    if (creditLine != null)
                    {
                        sheet.Cells[row, 5] = String.Format("{0} {1:N2}", creditLine.CreditLineCurrency, creditLine.CreditLine - financeOutstanding.GetValueOrDefault());
                    }
                    row++;

                    sheet.Cells[row, 1] = "融资余额：";
                    financeOutstanding = cda.Case.FinanceOutstanding;
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", financeOutstanding == null ? "" : cda.FinanceLineCurr, financeOutstanding);

                    //if (creditLine.GroupCreditLine == null)
                    //{
                    //    sheet.Cells[8, 2] = String.Format("{0} {1:N2}", creditLine.CreditLineCurrency, creditLine.CreditLine - financeOutstanding.GetValueOrDefault());
                    //}
                    //else
                    //{
                    //    double groupFinanceLineOutstanding = creditLine.GroupCreditLine.FinanceCreditLineOutstanding;
                    //    if (creditLine.GroupCreditLine.CreditLineCurrency != creditLine.CreditLineCurrency)
                    //    {
                    //        double exchange = Exchange.GetExchangeRate(creditLine.GroupCreditLine.CreditLineCurrency, creditLine.CreditLineCurrency);
                    //        groupFinanceLineOutstanding *= exchange;
                    //    }
                    //    sheet.Cells[8, 2] = String.Format("{0} {1:N2}", creditLine.CreditLineCurrency, Math.Min(groupFinanceLineOutstanding, creditLine.CreditLine - financeOutstanding.GetValueOrDefault()));
                    //}

                    row++;
                    sheet.Cells[row, 1] = "发票号";
                    sheet.Cells[row, 2] = "转让金额";
                    sheet.Cells[row, 3] = "发票日期";
                    sheet.Cells[row, 4] = "到期日";
                    sheet.Cells[row, 5] = "备注";

                    row++;
                    int invoiceStart = row;
                    double total = 0;
                    foreach (Invoice invoice in buyerGroup)
                    {
                        sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
                        sheet.Cells[row, 2] = invoice.AssignAmount;
                        sheet.Cells[row, 3] = invoice.InvoiceDate;
                        sheet.Cells[row, 4] = invoice.DueDate;
                        sheet.Cells[row, 5] = invoice.Comment;
                        total += invoice.AssignAmount;
                        row++;
                    }
                    sheet.Cells[row, 1] = "小计";
                    sheet.Cells[row, 2] = String.Format("{0:N2}", total);

                    int invoiceEnd = row;
                    sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
                    sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = "¥#,##0.00";
                    sheet.get_Range(sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy/MM/dd";
                    sheet.get_Range(sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy/MM/dd";
                    sheet.get_Range(sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.get_Range(sheet.Cells[invoiceStart - 1, 5], sheet.Cells[invoiceEnd, 5]).NumberFormatLocal = "¥#,##0.00";
                    sheet.get_Range(sheet.Cells[invoiceStart, 5], sheet.Cells[invoiceEnd, 5]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]).Borders.LineStyle = 1;
                }

                row++;

                sheet.Cells[row + 1, 3] = "中国民生银行 贸易金融部保理业务部 （业务章）";
                sheet.Cells[row + 2, 4] = "签字：";
                sheet.Cells[row + 3, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

                sheet.UsedRange.Font.Name = "仿宋";
                sheet.UsedRange.Font.Size = 12;
                sheet.get_Range(sheet.Cells[3, 2], sheet.Cells[3, 2]).Font.Size = 24;

                sheet.get_Range("A1", Type.Missing).ColumnWidth = 17;
                sheet.get_Range("B1", Type.Missing).ColumnWidth = 17;
                sheet.get_Range("C1", Type.Missing).ColumnWidth = 17;
                sheet.get_Range("D1", Type.Missing).ColumnWidth = 17;
                sheet.get_Range("E1", Type.Missing).ColumnWidth = 17;
                app.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateReportAll(object sender, EventArgs e)
        {
            List<Invoice> invoiceList = new List<Invoice>();
            foreach (Invoice invoice in this.bs.List)
            {
                invoiceList.Add(invoice);
            }

            this.GenerateReportImpl(invoiceList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        private void GenerateReportImpl(List<Invoice> invoiceList)
        {
            if (invoiceList == null || invoiceList.Count == 0)
            {
                return;
            }

            switch (this.opReportType)
            {
                //case OpReportType.REPORT_ASSIGN:
                //    this.GenerateAssignReport(invoiceList);
                //    break;
                case OpReportType.REPORT_FINANCE:
                    this.GenerateFinanceReport(invoiceList);
                    break;
                //case OpReportType.REPORT_FEE:
                //    this.GenerateFeeReport(invoiceList);
                //    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateReportSelected(object sender, EventArgs e)
        {
            List<Invoice> selectedInvoices = new List<Invoice>();
            foreach (DataGridViewCell cell in this.dgvInvoices.SelectedCells)
            {
                Invoice invoice = (Invoice)this.bs.List[cell.RowIndex];
                if (!selectedInvoices.Contains(invoice))
                {
                    selectedInvoices.Add(invoice);
                }
            }

            this.GenerateReportImpl(selectedInvoices);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoices(object sender, EventArgs e)
        {
            if (!this.superValidator.Validate())
            {
                return;
            }

            string sellerName = this.tbSeller.Text;
            string buyerName = this.tbBuyer.Text;
            string factorName = this.tbFactor.Text;
            string isFlaw = this.cbIsFlaw.CheckValue as string;

            DateTime beginDate = this.diAssignDateBegin.Text != string.Empty ? this.diAssignDateBegin.Value : this.diAssignDateBegin.MinDate;
            DateTime endDate = this.diAssignDateEnd.Text != string.Empty ? this.diAssignDateEnd.Value : this.diAssignDateEnd.MinDate;

            var queryResult = from invoice in App.Current.DbContext.Invoices
                              let seller = invoice.InvoiceAssignBatch.Case.SellerClient
                              where seller.ClientNameCN.Contains(sellerName) || seller.ClientNameEN.Contains(sellerName)
                              let buyer = invoice.InvoiceAssignBatch.Case.BuyerClient
                              where buyer.ClientNameCN.Contains(buyerName) || buyer.ClientNameEN.Contains(buyerName)
                              let sellerFactor = invoice.InvoiceAssignBatch.Case.SellerFactor
                              where sellerFactor.CompanyNameCN.Contains(factorName) || sellerFactor.CompanyNameEN.Contains(factorName)
                              let buyerFactor = invoice.InvoiceAssignBatch.Case.BuyerFactor
                              where buyerFactor.CompanyNameCN.Contains(factorName) || buyerFactor.CompanyNameEN.Contains(factorName)
                              let curCase = invoice.InvoiceAssignBatch.Case
                              where curCase.CaseMark == ConstStr.CASE.ENABLE
                              where
                                    (isFlaw == "A" ? true : invoice.IsFlaw == (isFlaw == "Y" ? true : false))
                                 && (beginDate != this.diAssignDateBegin.MinDate ? invoice.InvoiceAssignBatch.AssignDate >= beginDate : true)
                                 && (endDate != this.diAssignDateEnd.MinDate ? invoice.InvoiceAssignBatch.AssignDate <= endDate : true)
                                 && (this.opReportType == OpReportType.REPORT_ASSIGN ? invoice.AssignAmount > invoice.PaymentAmount.GetValueOrDefault() : true)
                                 && (this.opReportType == OpReportType.REPORT_FINANCE ? invoice.FinanceAmount.HasValue == false || invoice.FinanceAmount.GetValueOrDefault() < 0.00000001 : true)
                              select invoice;

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            this.tbSeller.Text = string.Empty;
            this.tbBuyer.Text = string.Empty;
            this.tbFactor.Text = string.Empty;
            this.diAssignDateBegin.Value = default(DateTime);
            this.diAssignDateEnd.Value = default(DateTime);
        }

        #endregion Methods
    }
}
