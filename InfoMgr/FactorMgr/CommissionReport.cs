//-----------------------------------------------------------------------
// <copyright file="CommissionReport.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using Microsoft.Office.Interop.Excel;

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
            List<Location> allLocations = DB.dbml.Location.AllLocations;
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;
            cbTransactionType.SelectedIndex = 0;
            cbYear.Text = DateTime.Today.Year.ToString();
            cbMonth.Text = DateTime.Today.Month.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatCommissionReport(object sender, EventArgs e)
        {
            string yearStr = cbYear.Text;
            string monthStr = cbMonth.Text;
            string transactionType = cbTransactionType.Text;
            string location = (string)cbLocation.SelectedValue;
            if (String.IsNullOrEmpty(yearStr) || String.IsNullOrEmpty(monthStr))
            {
                MessageBoxEx.Show("请首先选择查询年度/月份", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime beginDate = new DateTime(Int32.Parse(yearStr), Int32.Parse(monthStr), 1, 0, 0, 0);
            DateTime endDate = beginDate.AddMonths(1);

            DBDataContext context = new DBDataContext();

            if ("进口保理" == transactionType)
            {
                List<InvoiceAssignBatch> batches = context.InvoiceAssignBatches.Where(batch =>
                    batch.Case.TransactionType == "进口保理"
                    && batch.AssignDate > beginDate
                    && batch.AssignDate < endDate).ToList();

                if (batches.Count == 0)
                {
                    MessageBoxEx.Show("没有符合条件的业务，无需生成报表。");
                    return;
                }

                ReportImportCommissionApplication(batches, beginDate);
            }
            else if ("出口保理" == transactionType)
            {
                //List<InvoiceAssignBatch> batches = context.InvoiceAssignBatches.Where(
                //    batch => batch.Case.TransactionType == "出口保理"
                //    && batch.AssignDate > beginDate
                //    && batch.AssignDate < endDate
                //    && batch.Case.OwnerDepartment.LocationName == location).ToList();
                //ReportExportCommissionApplication(batches, beginDate, location);
                MessageBoxEx.Show("领导说不需要这个功能了。");
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batches"></param>
        /// <param name="month"></param>
        /// <param name="location"></param>
        private static void ReportExportCommissionApplication(List<InvoiceAssignBatch> batches, DateTime month,string location)
        {
            IEnumerable<IGrouping<Factor, InvoiceAssignBatch>> factorGroups = batches.GroupBy(b => b.Case.Factor);

            var app = new ApplicationClass { Visible = false };
            var workbook = app.Workbooks.Add(true);

            try
            {
                foreach (var factorGroup in factorGroups)
                {
                    Factor factor = factorGroup.Key;
                    var commissionSheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                    commissionSheet.Name = factor.CompanyNameEN.Substring(0, 15);
                    ReportImportCommissionSheet(commissionSheet, factorGroup, month);
                }

                string filePath = String.Format("{0}\\{1:yyyyMM}-保理费月报表(出口保理).xls", SystemUtil.DesktopPath, month);
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
        /// <param name="batches"></param>
        /// <param name="month"></param>
        private static void ReportImportCommissionApplication(List<InvoiceAssignBatch> batches, DateTime month)
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
                    ReportImportCommissionSheet(commissionSheet, factorGroup, month);
                }

                string filePath = String.Format("{0}\\{1:yyyyMM}-保理费月报表(进口保理).xls", SystemUtil.DesktopPath, month);
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
        private static void ReportImportCommissionSheet(Worksheet sheet, IGrouping<Factor, InvoiceAssignBatch> factorGroup, DateTime month)
        {
            //sheet.PageSetup.Zoom = false;
            //sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            //sheet.PageSetup.FitToPagesWide = 1;
            //sheet.PageSetup.FitToPagesTall = false;

            sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 11]].MergeCells = true;
            sheet.Cells[2, 1] = "Commission Sales Report For " + month.ToString("MMMM yyyy", new CultureInfo("en-US")) + " - CHINA MINSHENG BANKING CORP.";
            sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 1]].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 1]].Font.Size = 14;
            sheet.Cells[3, 11] = String.Format("{0:yyyy/MM/dd}", DateTime.Today);

            sheet.Range["A5", "I5"].MergeCells = true;
            Factor factor = factorGroup.Key;
            sheet.Cells[5, 1] = String.Format("Export Factor: {0} {1}", factor.FactorCode, factor.CompanyNameEN);

            IEnumerable<IGrouping<Client, InvoiceAssignBatch>> clientGroups = factorGroup.GroupBy(batch => batch.Case.SellerClient);

            int row = 7;
            double sellerTotal = 0;
            foreach (var clientGroup in clientGroups)
            {
                Client client = clientGroup.Key;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 11]].MergeCells = true;
                sheet.Cells[row, 1] = String.Format("Seller: {0} {1}", client.ClientEDICode, client.ClientNameEN);
                row++;
                sheet.Cells[row, 1] = "Buyer";
                sheet.Cells[row, 2] = "Day";
                sheet.Cells[row, 3] = "Batch";
                sheet.Cells[row, 4] = "Currency";
                sheet.Cells[row, 5] = "Sales";
                sheet.Cells[row, 6] = "Comm Fee";
                sheet.Cells[row, 7] = "Comm Charge";
                sheet.Cells[row, 8] = "Invoices";
                sheet.Cells[row, 9] = "Handling Fee";
                sheet.Cells[row, 10] = "Handling Charge";
                sheet.Cells[row, 11] = "Total Charge";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 11]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 11]].Font.Underline = XlUnderlineStyle.xlUnderlineStyleSingle;

                row++;
                double assignTotal = 0;
                double commissionTotal = 0;
                double handfeeTotal = 0;
                foreach (InvoiceAssignBatch batch in clientGroup.OrderBy(b => b.Case.BuyerCode))
                {
                    sheet.Cells[row, 1] = batch.Case.BuyerClient.ClientNameEN;
                    sheet.Cells[row, 2] = String.Format("{0:dd}", batch.AssignDate);
                    sheet.Cells[row, 3] = batch.AssignBatchNo;
                    sheet.Cells[row, 4] = batch.BatchCurrency;
                    sheet.Cells[row, 5] = batch.AssignAmount;
                    sheet.Range[sheet.Cells[row, 5], sheet.Cells[row, 5]].NumberFormatLocal = "#,##0.00";
                    sheet.Cells[row, 6] = batch.IFCommissionPrice;
                    sheet.Range[sheet.Cells[row, 6], sheet.Cells[row, 6]].NumberFormatLocal = "0.000%";
                    sheet.Cells[row, 7] = batch.CommissionAmount;
                    sheet.Range[sheet.Cells[row, 7], sheet.Cells[row, 7]].NumberFormatLocal = "#,##0.00";
                    sheet.Cells[row, 8] = batch.BatchCount;
                    sheet.Cells[row, 9] = batch.HandFee;
                    sheet.Cells[row, 10] = batch.HandfeeAmount;
                    sheet.Range[sheet.Cells[row, 10], sheet.Cells[row, 10]].NumberFormatLocal = "#,##0.00";
                    sheet.Cells[row, 11] = batch.CommissionAmount.GetValueOrDefault() + batch.HandfeeAmount.GetValueOrDefault();
                    sheet.Range[sheet.Cells[row, 11], sheet.Cells[row, 11]].NumberFormatLocal = "#,##0.00";
                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 11]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                    assignTotal += batch.AssignAmount;
                    commissionTotal += batch.CommissionAmount.GetValueOrDefault();
                    handfeeTotal += batch.HandfeeAmount.GetValueOrDefault();
                    row++;
                }

                sheet.Cells[row, 2] = "Seller Totals";
                sheet.Cells[row, 5] = assignTotal;
                sheet.Range[sheet.Cells[row, 5], sheet.Cells[row, 5]].NumberFormatLocal = "#,##0.00";
                sheet.Cells[row, 7] = commissionTotal;
                sheet.Range[sheet.Cells[row, 7], sheet.Cells[row, 7]].NumberFormatLocal = "#,##0.00";
                sheet.Cells[row, 10] = handfeeTotal;
                sheet.Cells[row, 11] = commissionTotal + handfeeTotal;
                sheet.Range[sheet.Cells[row, 11], sheet.Cells[row, 11]].NumberFormatLocal = "#,##0.00";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 11]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                sellerTotal += (commissionTotal + handfeeTotal);
                row++;
                row++;
            }

            foreach (Range range in sheet.UsedRange.Columns)
            {
                range.EntireColumn.AutoFit();
            }
        }
    }
}
