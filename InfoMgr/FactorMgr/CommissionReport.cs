//-----------------------------------------------------------------------
// <copyright file="CommissionReport.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using DevComponents.DotNetBar;
using CMBC.EasyFactor.Utils;
using System.Globalization;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class CommissionReport : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public CommissionReport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatCommissionReport(object sender, EventArgs e)
        {
            DateTime month = this.diMonth.Value;
            DateTime beginDate = new DateTime(month.Year, month.Month, 1, 0, 0, 0);
            DateTime endDate = new DateTime(month.Year, month.Month + 1, 1, 0, 0, 0);

            DBDataContext context = new DBDataContext();

            List<InvoiceAssignBatch> batches = context.InvoiceAssignBatches.Where(batch => batch.Case.TransactionType == "进口保理" && batch.AssignDate > beginDate && batch.AssignDate < endDate).ToList();

            ReportCommissionApplication(batches, month);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batches"></param>
        /// <param name="month"></param>
        private static void ReportCommissionApplication(List<InvoiceAssignBatch> batches, DateTime month)
        {

            IEnumerable<IGrouping<Factor, InvoiceAssignBatch>> factorGroups =
                batches.GroupBy(b => b.Case.Factor);

            var app = new ApplicationClass { Visible = false };
            var workbook = app.Workbooks.Add(true);

            try
            {
                foreach (var factorGroup in factorGroups)
                {
                    Factor factor = factorGroup.Key;
                    var commissionSheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                    commissionSheet.Name = factor.CompanyNameEN.Substring(0, 15);
                    ReportCommissionSheet(commissionSheet, factorGroup, month);
                }

                string filePath = String.Format("{0}\\{1:yyyyMM}-保理费月份报表.xls", SystemUtil.DesktopPath, month);
                workbook.SaveAs(filePath, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, false, false,
                                XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, false,
                                Type.Missing, Type.Missing, Type.Missing);

                app.Visible = true;
            }
            catch (Exception e1)
            {
                foreach (Workbook wb in app.Workbooks)
                {
                    wb.Close(false, Type.Missing, Type.Missing);
                }

                app.Workbooks.Close();
                app.Quit();
                Marshal.ReleaseComObject(app);

                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="factorGroup"></param>
        /// <param name="month"></param>
        private static void ReportCommissionSheet(Worksheet sheet, IGrouping<Factor, InvoiceAssignBatch> factorGroup, DateTime month)
        {
            sheet.PageSetup.Zoom = false;
            sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            sheet.PageSetup.FitToPagesWide = 1;
            sheet.PageSetup.FitToPagesTall = false;

            Factor factor = factorGroup.Key;
            sheet.Cells[2, 1] = "IPINTBCOM";
            sheet.Cells[3, 1] = String.Format("{0:hh:mm:ss-MM/dd/yy}", DateTime.Now);

            sheet.Range[sheet.Cells[2, 3], sheet.Cells[2, 9]].MergeCells = true;
            sheet.Cells[2, 3] = factor.CompanyNameEN;
            sheet.Range[sheet.Cells[3, 3], sheet.Cells[3, 9]].MergeCells = true;
            sheet.Cells[3, 3] = String.Format("Commission Sales Report For {0:MMMM yyyy}", month, DateTimeFormatInfo.CurrentInfo);

            sheet.Range["A5", "I5"].MergeCells = true;
            sheet.Cells[5, 1] = String.Format("Export Factor: 1207 CHINA MINSHENG BANKING CORP");

            IEnumerable<IGrouping<Client, InvoiceAssignBatch>> clientGroups = factorGroup.GroupBy(batch => batch.Case.SellerClient);

            int row = 7;
            double sellerTotal = 0;
            foreach (var clientGroup in clientGroups)
            {
                Client client = clientGroup.Key;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 9]].MergeCells = true;
                sheet.Cells[row, 1] = String.Format("Seller: {0} {1}", client.ClientEDICode, client.ClientNameEN);
                row++;
                sheet.Cells[row, 1] = "Day";
                sheet.Cells[row, 2] = "Batch";
                sheet.Cells[row, 3] = "Sales";
                sheet.Cells[row, 4] = "Comm Fee";
                sheet.Cells[row, 5] = "Comm Charge";
                sheet.Cells[row, 6] = "Invoices";
                sheet.Cells[row, 7] = "Handling Fee";
                sheet.Cells[row, 8] = "Handling Charge";
                sheet.Cells[row, 9] = "Total Charge";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 9]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 9]].Font.Underline = XlUnderlineStyle.xlUnderlineStyleSingle;

                row++;
                double assignTotal = 0;
                double factorCommissionTotal = 0;
                foreach (InvoiceAssignBatch batch in clientGroup.OrderBy(b => b.AssignDate))
                {
                    sheet.Cells[row, 1] = String.Format("{0:dd}", batch.AssignDate);
                    sheet.Cells[row, 2] = batch.AssignBatchNo;
                    sheet.Cells[row, 3] = batch.AssignAmount;
                    sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 3]].NumberFormatLocal = "#,##0.00";
                    sheet.Cells[row, 4] = batch.FactorCommissionPrice;
                    sheet.Range[sheet.Cells[row, 4], sheet.Cells[row, 4]].NumberFormatLocal = "0.000%";
                    sheet.Cells[row, 5] = batch.FactorCommissionAmount;
                    sheet.Range[sheet.Cells[row, 5], sheet.Cells[row, 5]].NumberFormatLocal = "#,##0.00";
                    sheet.Cells[row, 6] = batch.BatchCount;
                    sheet.Cells[row, 9] = batch.FactorCommissionAmount;
                    sheet.Range[sheet.Cells[row, 9], sheet.Cells[row, 9]].NumberFormatLocal = "#,##0.00";
                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 9]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                    assignTotal += batch.AssignAmount;
                    factorCommissionTotal += batch.FactorCommissionAmount.GetValueOrDefault();
                    row++;
                }
                sheet.Cells[row, 1] = "Seller Totals";
                sheet.Cells[row, 3] = assignTotal;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 3]].NumberFormatLocal = "#,##0.00";
                sheet.Cells[row, 5] = factorCommissionTotal;
                sheet.Range[sheet.Cells[row, 5], sheet.Cells[row, 5]].NumberFormatLocal = "#,##0.00";
                sheet.Cells[row, 9] = factorCommissionTotal;
                sheet.Range[sheet.Cells[row, 9], sheet.Cells[row, 9]].NumberFormatLocal = "#,##0.00";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 9]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                sellerTotal += factorCommissionTotal;
                row++;
                row++;
            }

            sheet.Range[sheet.Cells[row, 6], sheet.Cells[row, 8]].MergeCells = true;
            sheet.Cells[row, 6] = "USD Currency Export Factor Totals";
            sheet.Cells[row, 9] = sellerTotal;
            sheet.Range[sheet.Cells[row, 9], sheet.Cells[row, 9]].NumberFormatLocal = "#,##0.00";

            foreach (Range range in sheet.UsedRange.Columns)
            {
                range.EntireColumn.AutoFit();
            }
        }
    }
}
