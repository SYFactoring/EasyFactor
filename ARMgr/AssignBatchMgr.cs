//-----------------------------------------------------------------------
// <copyright file="AssignBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Rectangle = System.Drawing.Rectangle;
using XlHAlign = Microsoft.Office.Interop.Excel.XlHAlign;
using XlVAlign = Microsoft.Office.Interop.Excel.XlVAlign;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;
        /// <summary>
        /// 
        /// </summary>
        private readonly Case _case;
        /// <summary>
        /// 
        /// </summary>
        private readonly OpBatchType _opBatchType;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="commissionRemit"></param>
        /// <param name="context"></param>
        public AssignBatchMgr(CommissionRemittance commissionRemit, DBDataContext context)
            : this(OpBatchType.COMMISSION)
        {
            panelQuery.Visible = false;
            _bs.DataSource = commissionRemit.InvoiceAssignBatches;
            Context = context;
        }
        /// <summary>
        /// Initializes a new instance of the AssignBatchMgr class
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <param name="context"></param>
        public AssignBatchMgr(Case selectedCase, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            _case = selectedCase;
            panelQuery.Visible = false;
            _bs.DataSource = _case.InvoiceAssignBatches;
            Context = context;
        }
        /// <summary>
        /// Initializes a new instance of the AssignBatchMgr class
        /// </summary>
        /// <param name="batchType"></param>
        public AssignBatchMgr(OpBatchType batchType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvBatches.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvBatches.DataSource = _bs;
            _opBatchType = batchType;
            ControlUtil.SetDoubleBuffered(dgvBatches);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "全部" });
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            UpdateContextMenu();

            if (_opBatchType == OpBatchType.REPORT)
            {
                dateBatchFrom.Value = DateTime.Now.Date;
                dateBatchTo.Value = DateTime.Now.Date;
                QueryBatch(null, null);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }
        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }
        /// <summary>
        /// Gets or sets selected AssignBatch
        /// </summary>
        public InvoiceAssignBatch Selected { get; set; }
        //?Private?Methods?(25)?
        //private void Check(object sender, EventArgs e)
        //{
        //    if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_CHECK))
        //    {
        //        return;
        //    }
        //    if (this.dgvBatches.CurrentCell == null)
        //    {
        //        return;
        //    }
        //    InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
        //    //if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_APPROVE))
        //    //{
        //    //    MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    return;
        //    //}
        //    if (MessageBoxEx.Show("是否确认复核通过该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //    {
        //        return;
        //    }
        //    if (App.Current.CurUser.Name == batch.CreateUserName)
        //    {
        //        MessageBoxEx.Show("经办人和复核人相同，不可进行复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    //batch.CheckStatus = BATCH.CHECK;
        //    //batch.CheckUserName = App.Current.CurUser.Name;
        //    //batch.CheckDate = DateTime.Now.Date;
        //    try
        //    {
        //        context.SubmitChanges();
        //    }
        //    catch (Exception e1)
        //    {
        //        MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            var selectedBatch = (InvoiceAssignBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("是否打算删除此转让批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (selectedBatch.Invoices.Count > 0)
            {
                MessageBoxEx.Show("不能删除此批次，它包含相关发票信息", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            Context.InvoiceAssignBatches.DeleteOnSubmit(selectedBatch);
            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            dgvBatches.Rows.RemoveAt(dgvBatches.CurrentCell.RowIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            var selectedBatch = (InvoiceAssignBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("是否打算删除此转让批次的保理费收付记录", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            selectedBatch.CommissionRemittance = null;
            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            if (_opBatchType == OpBatchType.COMMISSION)
            {
                dgvBatches.Rows.RemoveAt(dgvBatches.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBatch(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            var selectedBatch = (InvoiceAssignBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
            var detail = new AssignBatchDetail(selectedBatch);
            detail.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBatchesCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailBatch(sender, e);
            }
            else
            {
                SelectBatch(sender, e);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBatchesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = dgvBatches.Columns[e.ColumnIndex];
            if (col == colIsSendMsg || col == colIsPool)
            {
                var isSend = (bool)e.Value;
                e.Value = isSend ? "Y" : "N";

                e.FormattingApplied = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBatchesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvBatches.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvBatches.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvBatches.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAssignBatch(object sender, EventArgs e)
        {
            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            var form = new ExportForm(ExportForm.ExportType.EXPORT_ASSIGN, selectedBatches);
            form.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportMSG09(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();

            var form = new ExportForm(ExportForm.ExportType.EXPORT_MSG09_INVOICE, selectedBatches);
            form.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<InvoiceAssignBatch> GetSelectedBatches()
        {
            if (dgvBatches.CurrentCell == null)
            {
                return null;
            }

            var selectedBatches = new List<InvoiceAssignBatch>();

            foreach (DataGridViewCell cell in dgvBatches.SelectedCells)
            {
                var batch = (InvoiceAssignBatch)_bs.List[cell.RowIndex];
                if (!selectedBatches.Contains(batch))
                {
                    selectedBatches.Add(batch);
                }
            }

            return selectedBatches;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedBatches"></param>
        /// <param name="makeReport"></param>
        private static void GroupBatchesByTransactionType(IEnumerable<InvoiceAssignBatch> selectedBatches,
                                                          MakeReport makeReport)
        {
            IEnumerable<IGrouping<string, InvoiceAssignBatch>> caseGroups =
                selectedBatches.GroupBy(c => c.Case.TransactionType);

            foreach (var caseGroup in caseGroups)
            {
                string transactionType = caseGroup.Key;
                IEnumerable<IGrouping<Client, InvoiceAssignBatch>> groups;

                if (makeReport.Method.Name == "ReportFinanceApplication")
                {
                    switch (transactionType)
                    {
                        case "国内卖方保理":
                        case "出口保理":
                            groups = caseGroup.GroupBy(c => c.Case.SellerClient);
                            foreach (var group in groups)
                            {
                                makeReport(group, transactionType);
                            }
                            break;
                        case "国内买方保理":
                        case "进口保理":
                            groups = caseGroup.GroupBy(c => c.Case.BuyerClient);
                            foreach (var group in groups)
                            {
                                makeReport(group, transactionType);
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    groups = caseGroup.GroupBy(c => c.Case.SellerClient);
                    foreach (var group in groups)
                    {
                        makeReport(group, transactionType);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBatch(object sender, EventArgs e)
        {
            DateTime beginBatchDate = String.IsNullOrEmpty(dateBatchFrom.Text)
                                          ? dateBatchFrom.MinDate
                                          : dateBatchFrom.Value.Date;
            DateTime endBatchDate = String.IsNullOrEmpty(dateBatchTo.Text)
                                        ? dateBatchTo.MinDate
                                        : dateBatchTo.Value.Date;
            DateTime beginInputDate = String.IsNullOrEmpty(dateInputFrom.Text)
                                          ? dateInputFrom.MinDate
                                          : dateInputFrom.Value.Date;
            DateTime endInputDate = String.IsNullOrEmpty(dateInputTo.Text)
                                        ? dateInputTo.MinDate
                                        : dateInputTo.Value.Date;
            string createUserName = tbCreateUserName.Text;
            string clientName = tbClientName.Text;
            string factorName = tbFactorName.Text;
            string transactionType = cbTransactionType.Text;
            var location = (string)cbLocation.SelectedValue;

            if (String.IsNullOrEmpty(transactionType))
            {
                transactionType = "全部";
            }

            Context = new DBDataContext();

            IEnumerable<InvoiceAssignBatch> queryResult = from batch in Context.InvoiceAssignBatches
                                                          let curCase = batch.Case
                                                          where
                                                              (transactionType == "全部"
                                                                   ? true
                                                                   : curCase.TransactionType == transactionType)
                                                              && (location == "00"
                                                                      ? true
                                                                      : curCase.OwnerDepartment.LocationCode ==
                                                                        location)
                                                              &&
                                                              ((curCase.TransactionType == "国内卖方保理" ||
                                                                curCase.TransactionType == "出口保理") &&
                                                               (curCase.BuyerFactor.CompanyNameCN.Contains(factorName) ||
                                                                curCase.BuyerFactor.CompanyNameEN.Contains(factorName))
                                                               ||
                                                               ((curCase.TransactionType == "国内买方保理" ||
                                                                 curCase.TransactionType == "进口保理") &&
                                                                (curCase.SellerFactor.CompanyNameCN.Contains(factorName) ||
                                                                 curCase.SellerFactor.CompanyNameEN.Contains(factorName))))
                                                          let seller = curCase.SellerClient
                                                          let buyer = curCase.BuyerClient
                                                          where
                                                              seller.ClientNameCN.Contains(clientName) ||
                                                              seller.ClientNameEN.Contains(clientName) ||
                                                              buyer.ClientNameCN.Contains(clientName) ||
                                                              buyer.ClientNameEN.Contains(clientName)
                                                          where batch.AssignBatchNo.Contains(tbAssignBatchNo.Text)
                                                                &&
                                                                (beginBatchDate != dateBatchFrom.MinDate
                                                                     ? batch.AssignDate >= beginBatchDate
                                                                     : true)
                                                                &&
                                                                (endBatchDate != dateBatchTo.MinDate
                                                                     ? batch.AssignDate <= endBatchDate
                                                                     : true)
                                                                &&
                                                                (beginInputDate != dateInputFrom.MinDate
                                                                     ? batch.InputDate >= beginInputDate
                                                                     : true)
                                                                &&
                                                                (endInputDate != dateInputTo.MinDate
                                                                     ? batch.InputDate <= endInputDate
                                                                     : true)
                                                              //&& (status != string.Empty ? batch.CheckStatus == status : true)
                                                                && (batch.CreateUserName.Contains(createUserName))
                                                          select batch;

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }
        //private void Reject(object sender, EventArgs e)
        //{
        //    if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_CHECK))
        //    {
        //        return;
        //    }

        //    if (this.dgvBatches.CurrentCell == null)
        //    {
        //        return;
        //    }

        //    InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];

        //    //if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_APPROVE))
        //    //{
        //    //    MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    return;
        //    //}

        //    if (MessageBoxEx.Show("是否确认复核退回该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //    {
        //        return;
        //    }

        //    if (App.Current.CurUser.Name == batch.CreateUserName)
        //    {
        //        MessageBoxEx.Show("经办人和复核人相同，不可进行复核退回", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    //batch.CheckStatus = BATCH.REJECT;
        //    //batch.CheckUserName = App.Current.CurUser.Name;
        //    //batch.CheckDate = DateTime.Now.Date;

        //    try
        //    {
        //        context.SubmitChanges();
        //    }
        //    catch (Exception e1)
        //    {
        //        MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportAssign(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                return;
            }

            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = ReportAssignApplication;
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private static void ReportAssignApplication(IGrouping<Client, InvoiceAssignBatch> batchGroup,
                                                    string transactionType)
        {
            var app = new ApplicationClass { Visible = false };

            var workbook = app.Workbooks.Add(true);
            var sheet = (Worksheet)workbook.Sheets[1];
            sheet.Name = "应收账款转让明细表";
            try
            {
                ReportAssignSheet(sheet, batchGroup, transactionType);

                string filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}-应收账款转让明细表.xls", SystemUtil.DesktopPath, DateTime.Today,
                batchGroup.Key);

                int n = 1;
                while (File.Exists(filePath))
                {
                    filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}-应收账款转让明细表-{3}.xls", SystemUtil.DesktopPath, DateTime.Today,
                                                batchGroup.Key, n++);
                }

                workbook.SaveAs(filePath, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, false, false,
                                XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, false,
                                Type.Missing, Type.Missing, Type.Missing);

                app.Visible = true;
            }
            catch (Exception e1)
            {
                Marshal.ReleaseComObject(sheet);
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
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private static void ReportAssignSheet(Worksheet sheet, IGrouping<Client, InvoiceAssignBatch> batchGroup,
                                              string transactionType)
        {
            sheet.PageSetup.Zoom = false;
            sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            sheet.PageSetup.FitToPagesWide = 1;
            sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            Client seller = batchGroup.Key;
            sheet.Cells[2, 1] = String.Format("致： {0}", seller);
            sheet.Range["A4", "E4"].MergeCells = true;
            sheet.Range["A4", "A4"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Cells[4, 1] = "应收账款转让明细表";
            sheet.Range["A1", "A3"].RowHeight = 20;
            sheet.Range["A4", "A4"].RowHeight = 30;

            int row = 6;

            foreach (InvoiceAssignBatch selectedBatch in batchGroup)
            {
                Factor factor = null;
                Client buyer = selectedBatch.Case.BuyerClient;

                if (transactionType == "出口保理")
                {
                    factor = selectedBatch.Case.BuyerFactor;
                }

                sheet.Cells[row, 1] = "买方：";
                sheet.Cells[row++, 2] = String.Format("{0}（应收账款债务人）", buyer);
                sheet.Range["B6", "B6"].Font.Underline = true;
                if (factor != null)
                {
                    sheet.Cells[row, 1] = "进口保理商：";
                    sheet.Cells[row++, 2] = factor.ToString();
                }

                CDA cda = selectedBatch.Case.ActiveCDA;
                sheet.Cells[row, 1] = "信用风险额度：";
                sheet.Cells[row, 2] = cda.CreditCover.GetValueOrDefault();
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(cda.CreditCoverCurr);
                row++;
                sheet.Cells[row, 1] = "应收账款余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.AssignOutstanding;
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;

                sheet.Range["C9", "E9"].MergeCells = true;
                sheet.Cells[row, 3] = String.Format("业务编号：{0}", selectedBatch.AssignBatchNo);
                sheet.Range["C9", "C9"].HorizontalAlignment = XlHAlign.xlHAlignRight;

                row++;
                sheet.Cells[row, 1] = "发票号";
                sheet.Cells[row, 2] = "转让金额";
                sheet.Cells[row, 3] = "发票日期";
                sheet.Cells[row, 4] = "到期日";
                sheet.Cells[row, 5] = "文件瑕疵";

                row++;
                int invoiceStart = row;
                foreach (Invoice invoice in selectedBatch.Invoices)
                {
                    sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
                    sheet.Cells[row, 2] = invoice.AssignAmount;
                    sheet.Cells[row, 3] = invoice.InvoiceDate;
                    sheet.Cells[row, 4] = invoice.DueDate;
                    sheet.Cells[row, 5] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                    row++;
                }

                sheet.Cells[row, 1] = "小计";
                sheet.Cells[row, 2] = selectedBatch.AssignAmount;

                int invoiceEnd = row;
                sheet.Range[sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]].NumberFormatLocal = "@";
                sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.Case.InvoiceCurrency);
                sheet.Range[sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]].NumberFormatLocal =
                    "yyyy-MM-dd";
                sheet.Range[sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]].NumberFormatLocal =
                    "yyyy-MM-dd";
                sheet.Range[sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart - 1, 5], sheet.Cells[invoiceEnd, 5]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]].Borders.LineStyle = 1;

                if (selectedBatch.CreditNotes.Count > 0)
                {
                    row++;
                    row++;
                    sheet.Cells[row, 1] = "贷项通知号";
                    sheet.Cells[row, 2] = "贷项通知金额";
                    sheet.Cells[row, 3] = "贷项通知日";
                    sheet.Cells[row, 4] = "对应发票号";
                    row++;

                    foreach (CreditNote creditNote in selectedBatch.CreditNotes)
                    {
                        sheet.Cells[row, 1] = "'" + creditNote.CreditNoteNo;
                        sheet.Cells[row, 2] = creditNote.PaymentAmount;
                        sheet.Cells[row, 3] = creditNote.CreditNoteDate;
                        sheet.Cells[row, 4] = creditNote.InvoiceNos;
                        row++;
                    }

                    sheet.Cells[row, 1] = "小计";
                    sheet.Cells[row, 2] = selectedBatch.CreditNoteAmount;

                    invoiceEnd = row;
                    sheet.Range[sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]].NumberFormatLocal = "@";
                    sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]].NumberFormatLocal =
                        TypeUtil.GetExcelCurr(selectedBatch.Case.InvoiceCurrency);
                    sheet.Range[sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]].NumberFormatLocal =
                        "yyyy-MM-dd";
                    sheet.Range[sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]].NumberFormatLocal =
                        "yyyy-MM-dd";
                    sheet.Range[sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart - 1, 5], sheet.Cells[invoiceEnd, 5]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]].Borders.LineStyle = 1;

                    row++;
                    row++;
                    row++;
                    sheet.Cells[row, 3] = "转让总计";
                    sheet.Range[sheet.Cells[row, "D"], sheet.Cells[row, "E"]].MergeCells = true;
                    sheet.Cells[row, 4] = selectedBatch.AssignAmount - selectedBatch.CreditNoteAmount;
                    sheet.Range[sheet.Cells[row, "D"], sheet.Cells[row, "D"]].NumberFormatLocal =
                        TypeUtil.GetExcelCurr(selectedBatch.Case.InvoiceCurrency);
                    sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "D"]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "E"]].Borders.LineStyle = 1;
                    row++;
                }


                row++;
                row++;
            }

            sheet.Cells[row, 1] = "本行已完成上述发票/贷项发票转让，特此通知";
            row++;
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）        ";
            row++;
            row++;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "D"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "C"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.Range["A4", "A4"].Font.Size = 24;

            sheet.Range["A1", Type.Missing].ColumnWidth = 20;
            sheet.Range["B1", Type.Missing].ColumnWidth = 20;
            sheet.Range["C1", Type.Missing].ColumnWidth = 15;
            sheet.Range["D1", Type.Missing].ColumnWidth = 15;
            sheet.Range["E1", Type.Missing].ColumnWidth = 10;

            var sealRange = ((Range)sheet.Cells[row - 4, 3]);
            string sealPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue,
                                    Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(REPORT.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportCommission(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                return;
            }

            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            foreach (InvoiceAssignBatch batch in selectedBatches)
            {
                if (batch.Case.ActiveCDA.CommissionType != "按转让金额" && batch.Case.ActiveCDA.CommissionType != "其他")
                {
                    MessageBoxEx.Show("所选批次不是按照转让金额（或其他）收取保理费用，批次号：" + batch.AssignBatchNo, MESSAGE.TITLE_INFORMATION,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MakeReport makeReport = ReportCommissionApplication;
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private static void ReportCommissionApplication(IGrouping<Client, InvoiceAssignBatch> batchGroup,
                                                        string transactionType)
        {
            var app = new ApplicationClass { Visible = false };

            var workbook = app.Workbooks.Add(true);
            var sheet = (Worksheet)workbook.Sheets[1];
            sheet.Name = "保理费用明细表";
            try
            {
                ReportCommissionSheet(sheet, batchGroup);

                string filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}-保理费用明细表.xls", SystemUtil.DesktopPath, DateTime.Today,
                batchGroup.Key);

                int n = 1;
                while (File.Exists(filePath))
                {
                    filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}-保理费用明细表-{3}.xls", SystemUtil.DesktopPath, DateTime.Today,
                                                batchGroup.Key, n++);
                }

                workbook.SaveAs(filePath, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, false, false,
                                XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, false,
                                Type.Missing, Type.Missing, Type.Missing);

                app.Visible = true;
            }
            catch (Exception e1)
            {
                Marshal.ReleaseComObject(sheet);
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
        /// <param name="batchGroup"></param>
        private static void ReportCommissionSheet(Worksheet sheet, IGrouping<Client, InvoiceAssignBatch> batchGroup)
        {
            sheet.PageSetup.Zoom = false;
            sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            sheet.PageSetup.FitToPagesWide = 1;
            sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            Client seller = batchGroup.Key;
            sheet.Cells[3, 1] = String.Format("卖方：{0}", seller);
            sheet.Range["A5", "E5"].MergeCells = true;
            sheet.Range["A5", "A5"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Cells[5, 1] = "保理费用明细表";

            int row = 7;
            double totalCommission = 0;
            bool showTotalCommission = true;

            foreach (InvoiceAssignBatch selectedBatch in batchGroup)
            {
                if (selectedBatch.Case.ActiveCDA.CommissionType != "按转让金额" &&
                    selectedBatch.Case.ActiveCDA.CommissionType != "其他")
                {
                    continue;
                }

                Client buyer = selectedBatch.Case.BuyerClient;
                Factor factor = selectedBatch.Case.Factor;

                int beginRow = row;
                sheet.Cells[row, 1] = "买方";
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 5]].MergeCells = true;
                sheet.Cells[row, 2] = String.Format("{0} （应收账款债务人）", buyer);
                row++;
                sheet.Cells[row, 1] = "保理商";
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 3]].MergeCells = true;
                sheet.Cells[row, 2] = factor.ToString();
                sheet.Cells[row, 4] = "币别";
                sheet.Cells[row, 5] = selectedBatch.BatchCurrency;
                row++;
                sheet.Cells[row, 1] = "本次转让金额";
                sheet.Cells[row, 2] = "本次转让笔数";
                sheet.Cells[row, 3] = "转让日";
                sheet.Cells[row, 4] = "保理费率";
                sheet.Cells[row, 5] = "单据处理费";
                row++;
                sheet.Cells[row, 1] = selectedBatch.AssignAmount;
                sheet.Range["A" + row, "A" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.Cells[row, 2] = selectedBatch.Invoices.Count;
                sheet.Cells[row, 3] = selectedBatch.AssignDate;
                sheet.Cells[row, 4] = selectedBatch.Case.ActiveCDA.Price;
                sheet.Range["D" + row, "D" + row].NumberFormatLocal = "0.0000%";
                sheet.Range["E" + row, "E" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.Case.ActiveCDA.HandFeeCurr);
                sheet.Cells[row++, 5] = selectedBatch.Case.ActiveCDA.HandFee;
                sheet.Cells[row, 1] = "小计";
                sheet.Cells[row, 4] = selectedBatch.CommissionAmount;
                sheet.Cells[row, 5] = selectedBatch.HandfeeAmount;
                sheet.Range["D" + row, "D" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.Range["E" + row, "E" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.Case.ActiveCDA.HandFeeCurr);

                int endRow = row;

                if (showTotalCommission &&
                    selectedBatch.Case.ActiveCDA.HandFeeCurr != selectedBatch.Case.InvoiceCurrency)
                {
                    showTotalCommission = false;
                }
                else
                {
                    totalCommission += selectedBatch.CommissionAmount.GetValueOrDefault() +
                                       selectedBatch.HandfeeAmount.GetValueOrDefault();
                }

                sheet.Range["A" + beginRow, "E" + endRow].Borders.LineStyle = 1;

                row += 3;
            }

            if (showTotalCommission)
            {
                sheet.Cells[row, 4] = "费用总计";
                sheet.Cells[row, 5] = totalCommission;
                sheet.Range["E" + row, "E" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(batchGroup.First().BatchCurrency);
                sheet.Range["D" + row, "E" + row].Borders.LineStyle = 1;
                row += 2;
            }

            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）";
            row += 2;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "D"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "C"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.Range["A1", Type.Missing].ColumnWidth = 17;
            sheet.Range["B1", Type.Missing].ColumnWidth = 15;
            sheet.Range["C1", Type.Missing].ColumnWidth = 15;
            sheet.Range["D1", Type.Missing].ColumnWidth = 16;
            sheet.Range["E1", Type.Missing].ColumnWidth = 17;

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.UsedRange.Rows.RowHeight = 20;

            sheet.Range["A5", "A5"].Font.Size = 22;
            sheet.Range["A1", "A4"].RowHeight = 20;
            sheet.Range["A5", "A5"].RowHeight = 30;

            var sealRange = ((Range)sheet.Cells[row - 3, 3]);
            string sealPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue,
                                    Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(REPORT.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFileCheckList(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                return;
            }

            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = ReportFileCheckListImpl;
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private static void ReportFileCheckListImpl(IGrouping<Client, InvoiceAssignBatch> batchGroup,
                                                    string transactionType)
        {
            var app = new ApplicationClass { Visible = false };

            var sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                sheet.PageSetup.Zoom = false;
                sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                sheet.PageSetup.FitToPagesWide = 1;
                sheet.PageSetup.FitToPagesTall = false;

                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

                Client seller = batchGroup.Key;

                sheet.Range["A3", "D3"].MergeCells = true;
                sheet.Range["A3", "A3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sheet.Cells[3, 1] = "文件检查单";

                sheet.Range[sheet.Cells[5, 1], sheet.Cells[5, 2]].MergeCells = true;
                sheet.Cells[5, 1] = String.Format("卖方：{0}", seller);

                int row = 7;
                foreach (InvoiceAssignBatch selectedBatch in batchGroup)
                {
                    Client buyer = selectedBatch.Case.BuyerClient;
                    sheet.Cells[row++, 1] = String.Format("买方：{0}", buyer);
                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                    sheet.Cells[row++, 1] = String.Format("No. of Invoice(s) attached: {0}", selectedBatch.BatchCount);
                    int rowDueDate = row;

                    row++;
                    int rowBegin = row;

                    sheet.Cells[row, 1] = "Inv. No. List:";

                    DateTime dueDate = DateTime.MaxValue;
                    for (int i = 0; i < selectedBatch.Invoices.Count; i++)
                    {
                        if (i != 0 && i % 4 == 0)
                        {
                            row++;
                        }
                        Invoice invoice = selectedBatch.Invoices[i];
                        sheet.Cells[row, i % 4 + 1] = "'" + invoice.InvoiceNo;
                        if (invoice.DueDate < dueDate)
                        {
                            dueDate = invoice.DueDate;
                        }
                    }
                    sheet.Cells[rowDueDate, 1] = String.Format("Earliest due date:   {0:yyyy-MM-dd}", dueDate);

                    int rowEnd = row;

                    sheet.Range[sheet.Cells[rowBegin, 1], sheet.Cells[rowEnd, 4]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[rowBegin, 1], sheet.Cells[rowEnd, 4]].Borders.LineStyle = 1;

                    row += 3;
                }

                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row++, 1] = " □  第一次转让：通知函";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row++, 1] = " □  应收帐款转让通知书(须检附正本)";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row++, 1] = " □  发票复印件(第一联)";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row++, 1] = " □  出货单复印件(或签收单复印件)";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].RowHeight = 30;
                sheet.Cells[row++, 1] = " □  资料一致性：买卖方基本资料，发票上盖转让字句(复印件)，发票号码，发票金额，" + Environment.NewLine +
                                        "发票日，到期日，批复书其它相关条件。";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row++, 1] = " □  保理额度通知书(Sign Back/ Expiry date)";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row++, 1] = " □  合约书(Sign Back/ Expiry date)";
                row++;
                sheet.Cells[row++, 1] = "Discrepancies  □ Yes   □ No";

                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row, 1] = String.Format("运营组： 经办 {0}               复核 {1}              主管{2}",
                                                    batchGroup.First().CreateUserName, "", "");
                sheet.Cells[row + 1, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

                sheet.Range["A1", "A2"].RowHeight = 20;
                sheet.Range["A3", "A3"].RowHeight = 30;
                sheet.Range["A3", "A3"].Font.Size = 22;

                sheet.Range["A1", Type.Missing].ColumnWidth = 20;
                sheet.Range["B1", Type.Missing].ColumnWidth = 20;
                sheet.Range["C1", Type.Missing].ColumnWidth = 20;
                sheet.Range["D1", Type.Missing].ColumnWidth = 20;

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
                }
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFinance(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                return;
            }

            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = ReportFinanceApplication;
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        private static void ReportFinanceApplication(IGrouping<Client, InvoiceAssignBatch> batchGroup,
                                                     string transactionType)
        {
            var app = new ApplicationClass { Visible = false };

            var workbook = app.Workbooks.Add(true);
            var sheet = (Worksheet)workbook.Sheets[1];
            sheet.Name = "可融资账款明细表";
            Worksheet poolsheet = null;

            try
            {
                if (batchGroup.Any(b => b.Case.IsPool == false))
                {
                    if (transactionType == "出口保理" && batchGroup.First().Case.ActiveCDA.RiskType == "低风险")
                    {
                        ReportFinanceSheetOld(sheet, batchGroup, transactionType);
                    }
                    else
                    {
                        ReportFinanceSheet(sheet, batchGroup, transactionType);
                    }
                }
                else
                {
                    poolsheet = sheet;
                }
                if (batchGroup.Any(b => b.Case.IsPool))
                {
                    if (poolsheet == null)
                    {
                        poolsheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                    }
                    poolsheet.Name = "可融资账款明细表(保理池)";
                    if (transactionType == "出口保理" && batchGroup.First().Case.ActiveCDA.RiskType == "低风险")
                    {
                        ReportPoolFinanceSheetOld(poolsheet, batchGroup.Key);
                    }
                    else
                    {
                        ReportPoolFinanceSheet(poolsheet, batchGroup.Key);
                    }
                }

                Case firstCase = batchGroup.First().Case;
                CDA activeCDA = firstCase.ActiveCDA;
                if (activeCDA != null && activeCDA.CommissionType == "按融资金额")
                {
                    MessageBoxEx.Show(String.Format("此业务{0}按照融资金额收取费用，请及时导出《保理费用明细表》", firstCase.CaseCode));
                }

                string filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}-可融资账款明细表.xls", SystemUtil.DesktopPath, DateTime.Today,
                                batchGroup.Key);

                int n = 1;
                while (File.Exists(filePath))
                {
                    filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}-可融资账款明细表-{3}.xls", SystemUtil.DesktopPath, DateTime.Today,
                                                batchGroup.Key, n++);
                }

                workbook.SaveAs(filePath, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, false, false,
                                XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, false,
                                Type.Missing, Type.Missing, Type.Missing);

                app.Visible = true;
            }
            catch (Exception e1)
            {
                Marshal.ReleaseComObject(sheet);
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
        /// <param name="keyClient"></param>
        private static void ReportPoolFinanceSheet(Worksheet sheet, Client keyClient)
        {
            //sheet.PageSetup.Zoom = false;
            //sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            //sheet.PageSetup.FitToPagesWide = 1;
            //sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            sheet.Range["A3", "E3"].MergeCells = true;
            sheet.Range["A3", "A3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Cells[3, 1] = "可融资账款明细表(保理池)";

            int row = 5;
            sheet.Cells[row, 1] = "卖方：";

            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].Font.Underline = true;
            sheet.Cells[row, 2] = String.Format("{0}", keyClient);
            row++;

            DBDataContext context = new DBDataContext();
            IQueryable<Case> caseResult = from c in context.Cases
                                          where c.SellerCode == keyClient.ClientEDICode && c.IsPool && c.CaseMark == "启动案"
                                          select c;

            sheet.Cells[row, 1] = "账款池余额：";
            sheet.Range[sheet.Cells[row, "B"], sheet.Cells[row, "C"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "B"], sheet.Cells[row, "C"]].HorizontalAlignment =
                XlHAlign.xlHAlignLeft;
            if (caseResult.Count() > 0)
            {
                Case curCase = caseResult.First();
                sheet.Cells[row, 2] = keyClient.GetPoolCanBeFinance(curCase.InvoiceCurrency);
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(curCase.InvoiceCurrency);
            }

            row++;
            row++;
            sheet.Cells[row, 1] = "买方";
            sheet.Cells[row, 2] = "账款余额";
            sheet.Cells[row, 3] = "有效账款余额";
            sheet.Cells[row, 4] = "融资比例";
            sheet.Cells[row, 5] = "可融资金额(账款池)";

            row++;

            int invoiceStart = row;
            double totalAssignOutstanding = 0;
            double totalValuedAssignOutstanding = 0;
            double totalCanBeFinanceAmount = 0;
            foreach (Case c in caseResult)
            {
                sheet.Cells[row, 1] = c.BuyerClient.ToString();
                sheet.Cells[row, 2] = c.AssignOutstanding;
                sheet.Cells[row, 3] = c.ValuedAssignOutstanding;
                sheet.Cells[row, 4] = c.FinanceProportion;
                sheet.Cells[row, 5] = c.CanBeFinanceAmount;
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 3]].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(c.InvoiceCurrency);
                sheet.Range[sheet.Cells[row, 4], sheet.Cells[row, 4]].NumberFormatLocal =
    "0%";
                sheet.Range[sheet.Cells[row, 5], sheet.Cells[row, 5]].NumberFormatLocal =
    TypeUtil.GetExcelCurr(c.InvoiceCurrency);
                row++;
                totalAssignOutstanding += c.AssignOutstanding;
                totalValuedAssignOutstanding += c.ValuedAssignOutstanding;
                totalCanBeFinanceAmount += c.CanBeFinanceAmount;
            }

            sheet.Cells[row, 1] = "小计";
            sheet.Cells[row, 2] = totalAssignOutstanding;
            sheet.Cells[row, 3] = totalValuedAssignOutstanding;
            sheet.Cells[row, 5] = totalCanBeFinanceAmount;
            if (caseResult.Count() > 0)
            {
                Case curCase = caseResult.First();
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 5]].NumberFormatLocal = TypeUtil.GetExcelCurr(curCase.InvoiceCurrency);
            }
            int invoiceEnd = row ;

            sheet.Range[sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 5]].HorizontalAlignment =
                XlHAlign.xlHAlignCenter;
            sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]].Borders.LineStyle = 1;

            row++;
            row++;
            sheet.Cells[row, 1] = "以下内容由分部/行负责核定";
            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].Font.Underline = true;
            row++;
            sheet.Cells[row, 1] = "可用保理池融资额度：";
            row++;
            sheet.Cells[row, 1] = "保理融资池余额：";
            row++;
            sheet.Cells[row, 1] = "现金池余额：";
            row += 2;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"备注：";
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"（1）本表当日放款有效，过期请重新向保理部申请出具表单。";
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"（2）进行保理池放款时，分部贸易融资审查岗须审核确认新增融资款满足以下两项条件：①保理项下账款池余额+现金池余额 >= 保理融资池余额；②保理融资池余额+新增融资<=保理池融资额度+现金池余额。";
            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 45;
            row++;

            row += 3;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）        ";
            row++;
            row++;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "D"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "C"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 1]].Font.Size = 24;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 5]].RowHeight = 30;

            sheet.Range["A1", Type.Missing].ColumnWidth = 18;
            sheet.Range["B1", Type.Missing].ColumnWidth = 18;
            sheet.Range["C1", Type.Missing].ColumnWidth = 18;
            sheet.Range["D1", Type.Missing].ColumnWidth = 8;
            sheet.Range["E1", Type.Missing].ColumnWidth = 18;

            var sealRange = ((Range)sheet.Cells[row - 5, 3]);
            string sealPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue,
                                    Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(REPORT.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="keyClient"></param>
        private static void ReportPoolFinanceSheetOld(Worksheet sheet, Client keyClient)
        {
            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            sheet.Range["A3", "E3"].MergeCells = true;
            sheet.Range["A3", "A3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Cells[3, 1] = "可融资账款明细表(保理池)";

            int row = 5;
            sheet.Cells[row, 1] = "卖方：";

            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].Font.Underline = true;
            sheet.Cells[row, 2] = String.Format("{0}", keyClient);
            row++;

            row++;
            sheet.Cells[row, 1] = "池融资额度：";
            ClientCreditLine poolCreditLine = keyClient.PoolFinanceCreditLine;
            if (poolCreditLine != null)
            {
                sheet.Cells[row, 2] = poolCreditLine.CreditLine;
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(poolCreditLine.CreditLineCurrency);
            }

            row++;
            sheet.Cells[row, 1] = "总账款余额：";
            sheet.Cells[row, 2] = keyClient.GetPoolTotalAssignOutstading(poolCreditLine.CreditLineCurrency);
            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                TypeUtil.GetExcelCurrency(poolCreditLine.CreditLineCurrency);

            row++;
            sheet.Cells[row, 1] = "账款池余额：";
            sheet.Cells[row, 2] = keyClient.GetPoolCanBeFinance(poolCreditLine.CreditLineCurrency);
            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                TypeUtil.GetExcelCurrency(poolCreditLine.CreditLineCurrency);

            row++;
            sheet.Cells[row, 1] = "融资池余额：";
            sheet.Cells[row, 2] = keyClient.GetPoolFinanceOutstanding(poolCreditLine.CreditLineCurrency);
            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                TypeUtil.GetExcelCurrency(poolCreditLine.CreditLineCurrency);
            row++;
            row++;
            sheet.Cells[row, 1] = "以下内容由分部/行负责核定";
            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].Font.Underline = true;
            row++;

            sheet.Cells[row, 1] = "现金池余额：";
           // sheet.Cells[row, 2] = keyClient.GetPoolCashOutstanding(poolCreditLine.CreditLineCurrency);
            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                TypeUtil.GetExcelCurrency(poolCreditLine.CreditLineCurrency);

            row++;
            sheet.Cells[row, 1] = "本次可融资金额：";

            row++;
            row++;
            sheet.Cells[row, 1] = "买方";
            sheet.Cells[row, 2] = "账款余额";
            sheet.Cells[row, 3] = "有效账款余额";
            sheet.Cells[row, 4] = "融资比例";
            sheet.Cells[row, 5] = "可融资金额";

            row++;
            DBDataContext context = new DBDataContext();
            IQueryable<Case> caseResult = from c in context.Cases
                                          where c.SellerCode == keyClient.ClientEDICode && c.IsPool
                                          select c;
            int invoiceStart = row;
            foreach (Case c in caseResult)
            {
                sheet.Cells[row, 1] = c.BuyerClient.ToString();
                sheet.Cells[row, 2] = c.AssignOutstanding;
                sheet.Cells[row, 3] = c.ValuedAssignOutstanding;
                sheet.Cells[row, 4] = c.FinanceProportion;
                sheet.Cells[row, 5] = c.CanBeFinanceAmount;
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 3]].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(c.InvoiceCurrency);
                sheet.Range[sheet.Cells[row, 4], sheet.Cells[row, 4]].NumberFormatLocal =
    "0%";
                sheet.Range[sheet.Cells[row, 5], sheet.Cells[row, 5]].NumberFormatLocal =
    TypeUtil.GetExcelCurr(c.InvoiceCurrency);
                row++;
            }
            int invoiceEnd = row - 1;

            sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]].HorizontalAlignment =
                XlHAlign.xlHAlignCenter;
            sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]].Borders.LineStyle = 1;

            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"备注：";
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"（1）本表当日放款有效，过期请重新向保理部申请出具表单。";
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"（2）进行保理池放款时，分部贸易融资审查岗须审核确认新增融资款满足以下两项条件：①保理项下账款池余额+现金池余额 >= 保理融资池余额；②保理融资池余额+新增融资<=保理池融资额度+现金池余额。";
            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 45;

            row += 3;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）        ";
            row++;
            row++;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "D"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "C"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 1]].Font.Size = 24;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 5]].RowHeight = 30;

            sheet.Range["A1", Type.Missing].ColumnWidth = 20;
            sheet.Range["B1", Type.Missing].ColumnWidth = 20;
            sheet.Range["C1", Type.Missing].ColumnWidth = 20;
            sheet.Range["D1", Type.Missing].ColumnWidth = 10;
            sheet.Range["E1", Type.Missing].ColumnWidth = 20;

            var sealRange = ((Range)sheet.Cells[row - 4, 3]);
            string sealPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue,
                                    Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(REPORT.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private static void ReportFinanceSheet(Worksheet sheet, IGrouping<Client, InvoiceAssignBatch> batchGroup,
                                               string transactionType)
        {
            //sheet.PageSetup.Zoom = false;
            //sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            //sheet.PageSetup.FitToPagesWide = 1;
            //sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            sheet.Range["A3", "E3"].MergeCells = true;
            sheet.Range["A3", "A3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Cells[3, 1] = "可融资账款明细表";

            Client keyClient = batchGroup.Key;
            string clientSide;
            int row = 5;
            if (transactionType == "国内卖方保理" || transactionType == "出口保理")
            {
                sheet.Cells[row, 1] = "卖方：";
                clientSide = "买方";
            }
            else
            {
                sheet.Cells[row, 1] = "买方：";
                clientSide = "卖方";
            }

            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].Font.Underline = true;
            sheet.Cells[row, 2] = String.Format("{0}", keyClient);

            //row++;
            //sheet.Cells[row, 1] = "有效账款余额总额：";

            row++;
            row++;
            sheet.Cells[row, 1] = "以下信息由分部/行负责核定";
            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].Font.Underline = true;

            row++;
            sheet.Cells[row, 1] = "可用保理融资额度：";

            row++;
            sheet.Cells[row, 1] = "保理融资余额：";

            row++;
            sheet.Cells[row, 1] = "本次可融资金额：";

            row += 2;

            IEnumerable<IGrouping<Client, InvoiceAssignBatch>> groups;

            if (transactionType == "国内卖方保理" || transactionType == "出口保理")
            {
                groups = batchGroup.GroupBy(c => c.Case.BuyerClient);
            }
            else
            {
                groups = batchGroup.GroupBy(c => c.Case.SellerClient);
            }

            foreach (IGrouping<Client, InvoiceAssignBatch> group in groups)
            {
                Client valueClient = group.Key;
                sheet.Cells[row, 1] = clientSide + "：";

                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].Font.Underline = true;
                if (transactionType == "国内卖方保理" || transactionType == "出口保理")
                {
                    sheet.Cells[row, 2] = String.Format("{0} （应收账款债务人）", valueClient);
                }
                else
                {
                    sheet.Cells[row, 2] = String.Format("{0} ", valueClient);
                }
                row++;

                sheet.Cells[row, 1] = "对此" + clientSide + "的有效账款余额：";
                if (transactionType == "国内买方保理")
                {
                    sheet.Cells[row, 2] = group.First().Case.ValuedAssignOutstanding2;
                }
                else
                {
                    sheet.Cells[row, 2] = group.First().Case.ValuedAssignOutstanding;
                }
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(group.First().Case.InvoiceCurrency);

                row++;
                row++;
                sheet.Cells[row, 1] = "以下信息由分部/行负责核定";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].Font.Underline = true;
                row++;
                sheet.Cells[row, 1] = "此" + clientSide + "可用保理融资额度：";
                row++;
                sheet.Cells[row, 1] = "对此" + clientSide + "保理融资余额：";
                row++;
                sheet.Cells[row, 1] = "对此" + clientSide + "本次可融资金额：";

                row++;
                foreach (InvoiceAssignBatch selectedBatch in group)
                {
                    sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 5]].MergeCells = true;
                    sheet.Cells[row, 3] = "业务编号：" + selectedBatch.AssignBatchNo;
                    row++;
                    sheet.Cells[row, 1] = "发票号";
                    sheet.Cells[row, 2] = "转让余额";
                    sheet.Cells[row, 3] = "发票日期";
                    sheet.Cells[row, 4] = "到期日";
                    sheet.Cells[row, 5] = "备注";

                    row++;
                    int invoiceStart = row;
                    double assignAmount = 0;
                    bool isDueOK = transactionType == "国内买方保理";
                    CDA cda = selectedBatch.Case.ActiveCDA;
                    DateTime earlistDateForBaoxian = DateTime.MaxValue;
                    if (selectedBatch.Case.Factor.FactorType == "保险公司")
                    {
                        foreach (Invoice invoice in selectedBatch.Case.Invoices)
                        {
                            if (invoice.DueDate <= DateTime.Today
                           && (invoice.AssignAmount - invoice.PaymentAmount.GetValueOrDefault() > TypeUtil.PRECISION ))
                            {
                                if (earlistDateForBaoxian >invoice.DueDate)
                                {
                                    earlistDateForBaoxian = invoice.DueDate;
                                }
                            }
                        }
                        if (earlistDateForBaoxian != DateTime.MaxValue)
                        {
                            earlistDateForBaoxian = earlistDateForBaoxian.AddDays(Double.Parse(cda.DelayDays.GetValueOrDefault().ToString()));
                        }
                    }

                    foreach (Invoice invoice in selectedBatch.Invoices)
                    {
                        if (invoice.IsFlaw == false
                            && invoice.IsDispute.GetValueOrDefault() == false
                            && (isDueOK ? true : invoice.DueDate > DateTime.Today)
                            && (invoice.AssignAmount - invoice.PaymentAmount.GetValueOrDefault() > TypeUtil.PRECISION)
                            &&
                            ((invoice.AssignAmount - invoice.PaymentAmount.GetValueOrDefault()) *
                             cda.FinanceProportion.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() >
                             TypeUtil.PRECISION)
                            )
                        {
                            if (selectedBatch.Case.Factor.FactorType == "保险公司")
                            {
                                if (earlistDateForBaoxian != DateTime.MaxValue && invoice.InvoiceDate > earlistDateForBaoxian)
                                {
                                    continue;
                                }
                            }
                            sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
                            sheet.Cells[row, 2] = invoice.AssignOutstanding;
                            sheet.Cells[row, 3] = invoice.InvoiceDate;
                            sheet.Cells[row, 4] = invoice.DueDate;
                            sheet.Cells[row, 5] = invoice.Comment;
                            assignAmount += invoice.AssignOutstanding;
                            row++;
                        }
                    }

                    sheet.Cells[row, 1] = "小计";
                    sheet.Cells[row, 2] = assignAmount;

                    int invoiceEnd = row;

                    sheet.Range[sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]].NumberFormatLocal = "@";
                    sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]].NumberFormatLocal =
                        TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                    sheet.Range[sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]].NumberFormatLocal =
                        "yyyy-MM-dd";
                    sheet.Range[sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]].NumberFormatLocal =
                        "yyyy-MM-dd";
                    sheet.Range[sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]].Borders.LineStyle = 1;

                    row += 2;
                }
                row += 2;
            }

            row -= 2;

            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"备注：";
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"（1）可用保理融资额度，是指剩余的保理融资额度。";
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"（2）可融资金额的参考计算公式：对此" + clientSide + "本次可融资金额=Min{此" + clientSide + "可用保理融资额度，对此" + clientSide + "的有效账款余额×预付比例}。本次可融资金额=Min{可用保理融资额度，所有对此" + clientSide + "可融资金额加总值，客户剩余综合授信额度}。";
            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 45;
            row++;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"（3）若非出表当日放款，请贸易融资审核岗于放款当日审核上述发票的到期日，逾期发票不予融资。";
            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 30;
            row++;

            row += 2;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）        ";
            row++;
            row++;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "D"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "C"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 1]].Font.Size = 24;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 5]].RowHeight = 30;

            sheet.Range["A1", Type.Missing].ColumnWidth = 20;
            sheet.Range["B1", Type.Missing].ColumnWidth = 22;
            sheet.Range["C1", Type.Missing].ColumnWidth = 15;
            sheet.Range["D1", Type.Missing].ColumnWidth = 15;
            sheet.Range["E1", Type.Missing].ColumnWidth = 8;

            var sealRange = ((Range)sheet.Cells[row - 4, 3]);
            string sealPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue,
                                    Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(REPORT.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private static void ReportFinanceSheetOld(Worksheet sheet, IGrouping<Client, InvoiceAssignBatch> batchGroup,
                                               string transactionType)
        {
            //sheet.PageSetup.Zoom = false;
            //sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            //sheet.PageSetup.FitToPagesWide = 1;
            //sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            sheet.Range["A3", "E3"].MergeCells = true;
            sheet.Range["A3", "A3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Cells[3, 1] = "可融资账款明细表";

            Client keyClient = batchGroup.Key;
            int row = 5;
            if (transactionType == "国内卖方保理" || transactionType == "出口保理")
            {
                sheet.Cells[row, 1] = "卖方：";
            }
            else
            {
                sheet.Cells[row, 1] = "买方：";
            }

            sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].Font.Underline = true;
            sheet.Cells[row, 2] = String.Format("{0}", keyClient);
            ClientCreditLine creditLine = null;

            row++;
            sheet.Cells[row, 1] = "最高保理融资额度：";

            Case firstCase = batchGroup.First().Case;
            CDA activeCDA = firstCase.ActiveCDA;

            if (activeCDA != null)
            {
                creditLine = firstCase.HighestFinanceLine;
                if (creditLine != null)
                {
                    sheet.Cells[row, 2] = creditLine.CreditLine;
                    sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                        TypeUtil.GetExcelCurrency(creditLine.CreditLineCurrency);
                }
            }

            row++;
            sheet.Cells[row, 1] = "保理融资余额：";
            if (creditLine != null)
            {
                sheet.Cells[row, 2] = keyClient.GetFinanceOutstanding(creditLine.CreditLineCurrency).GetValueOrDefault();
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(creditLine.CreditLineCurrency);
            }

            row++;
            sheet.Cells[row, 1] = "本次可融资金额：";
            GuaranteeDeposit gd = keyClient.GetGuaranteeDeposit(firstCase.InvoiceCurrency);
            double canBeFinanceAmount = 0;
            if (creditLine != null)
            {
                if (gd != null)
                {
                    canBeFinanceAmount =
                        keyClient.CanBeFinanceAmount(firstCase.TransactionType, firstCase.InvoiceCurrency) +
                        gd.GuaranteeDepositAmount;
                    sheet.Cells[row, 3] = String.Format("（保证金 {0:N2})", gd.GuaranteeDepositAmount);
                }
                else
                {
                    canBeFinanceAmount = keyClient.CanBeFinanceAmount(firstCase.TransactionType,
                                                                       firstCase.InvoiceCurrency);
                }

                if (TypeUtil.LessZero(canBeFinanceAmount))
                {
                    canBeFinanceAmount = 0;
                }

                sheet.Cells[row, 2] = canBeFinanceAmount;
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(firstCase.InvoiceCurrency);
            }

            row += 2;

            foreach (InvoiceAssignBatch selectedBatch in batchGroup)
            {
                Client valueClient;
                string clientSide;
                if (transactionType == "国内卖方保理" || transactionType == "出口保理")
                {
                    valueClient = selectedBatch.Case.BuyerClient;
                    clientSide = "买方";
                }
                else
                {
                    valueClient = selectedBatch.Case.SellerClient;
                    clientSide = "卖方";
                }
                sheet.Cells[row, 1] = clientSide + "：";

                CDA cda = selectedBatch.Case.ActiveCDA;

                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].Font.Underline = true;
                if (transactionType == "国内卖方保理" || transactionType == "出口保理")
                {
                    sheet.Cells[row, 2] = String.Format("{0} （应收账款债务人）", valueClient);
                }
                else
                {
                    sheet.Cells[row, 2] = String.Format("{0} ", valueClient);
                }
                row++;

                Factor factor = null;
                if (transactionType == "出口保理")
                {
                    factor = selectedBatch.Case.BuyerFactor;
                }

                if (factor != null)
                {
                    sheet.Cells[row, 1] = "进口保理商";
                    sheet.Cells[row, 2] = factor.ToString();
                }

                //row++;

                //sheet.Cells[row, 1] = "信用风险额度：";
                //sheet.Cells[row, 2] = cda.CreditCover.GetValueOrDefault();
                //sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                //    TypeUtil.GetExcelCurrency(cda.CreditCoverCurr);

                //row++;
                //sheet.Cells[row, 1] = "应收账款余额：";
                //sheet.Cells[row, 2] = selectedBatch.Case.AssignOutstanding;
                //sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                //    TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;
                sheet.Cells[row, 1] = "对此买方保理融资额度：";
                sheet.Cells[row, 2] = cda.FinanceLine.GetValueOrDefault();
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(cda.FinanceLineCurr);

                row++;
                sheet.Cells[row, 1] = "对此买方保理融资余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.FinanceOutstanding.GetValueOrDefault();
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;
                if (transactionType == "国内卖方保理" || transactionType == "出口保理")
                {
                    sheet.Cells[row, 1] = "对此买方本次可融资金额：";
                }
                else
                {
                    sheet.Cells[row, 1] = "对此卖方本次可融资金额：";
                }

                if (gd != null)
                {
                    sheet.Cells[row, 2] = selectedBatch.Case.CanBeFinanceAmount + gd.GuaranteeDepositAmount;
                    sheet.Cells[row, 3] = String.Format("（保证金 {0:N2})", gd.GuaranteeDepositAmount);
                }
                else
                {
                    sheet.Cells[row, 2] = selectedBatch.Case.CanBeFinanceAmount;
                }

                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;
                row++;
                sheet.Cells[row, 1] = "发票号";
                sheet.Cells[row, 2] = "转让余额";
                sheet.Cells[row, 3] = "发票日期";
                sheet.Cells[row, 4] = "到期日";
                sheet.Cells[row, 5] = "备注";

                row++;
                int invoiceStart = row;
                double assignAmount = 0;
                bool isDueOK = transactionType == "国内买方保理";
                foreach (Invoice invoice in selectedBatch.Invoices)
                {
                    if (invoice.IsFlaw == false
                        && invoice.IsDispute.GetValueOrDefault() == false
                        && (isDueOK ? true : invoice.DueDate > DateTime.Today)
                        && (invoice.AssignAmount - invoice.PaymentAmount.GetValueOrDefault() > TypeUtil.PRECISION)
                        &&
                        ((invoice.AssignAmount - invoice.PaymentAmount.GetValueOrDefault()) *
                         cda.FinanceProportion.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() >
                         TypeUtil.PRECISION)
                        )
                    {
                        sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
                        sheet.Cells[row, 2] = invoice.AssignOutstanding;
                        sheet.Cells[row, 3] = invoice.InvoiceDate;
                        sheet.Cells[row, 4] = invoice.DueDate;
                        sheet.Cells[row, 5] = invoice.Comment;
                        assignAmount += invoice.AssignOutstanding;
                        row++;
                    }
                }

                sheet.Cells[row, 1] = "小计";
                sheet.Cells[row, 2] = assignAmount;

                int invoiceEnd = row;

                sheet.Range[sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]].NumberFormatLocal = "@";
                sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.Range[sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]].NumberFormatLocal =
                    "yyyy-MM-dd";
                sheet.Range[sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]].NumberFormatLocal =
                    "yyyy-MM-dd";
                sheet.Range[sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]].HorizontalAlignment =
                    XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]].Borders.LineStyle = 1;

                row += 3;
            }

            row -= 1;

            if (gd != null)
            {
                sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
                sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment =
                    XlHAlign.xlHAlignLeft;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 5]].RowHeight = 30;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 5]].WrapText = true;
                sheet.Cells[row, 1] =
                    String.Format("注：{0:yyyy}年{0:MM}月{0:dd}日客户回款{1}{2:N2}，因融资未到期，此笔款项暂存入保证金账户。请确保我行融资还款风险无误。",
                                  gd.DepositDate, gd.GuaranteeDepositCurrency, gd.GuaranteeDepositAmount);
                row++;
            }

            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].WrapText = true;
            sheet.Cells[row, 1] = @"备注：本表当日放款有效，过期请重新向保理部申请出具表单。";

            row += 3;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）        ";
            row++;
            row++;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "D"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "C"], sheet.Cells[row, "C"]].HorizontalAlignment = XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 1]].Font.Size = 24;
            sheet.Range[sheet.Cells[3, 1], sheet.Cells[3, 5]].RowHeight = 30;

            sheet.Range["A1", Type.Missing].ColumnWidth = 20;
            sheet.Range["B1", Type.Missing].ColumnWidth = 22;
            sheet.Range["C1", Type.Missing].ColumnWidth = 15;
            sheet.Range["D1", Type.Missing].ColumnWidth = 15;
            sheet.Range["E1", Type.Missing].ColumnWidth = 8;

            var sealRange = ((Range)sheet.Cells[row - 4, 3]);
            string sealPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue,
                                    Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(REPORT.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFlaw(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                return;
            }

            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = ReportFlawImpl;
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private static void ReportFlawImpl(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            var app = new ApplicationClass { Visible = false };

            var sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                sheet.PageSetup.Zoom = false;
                sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                sheet.PageSetup.FitToPagesWide = 1;
                sheet.PageSetup.FitToPagesTall = false;

                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 240, 3, 170, 30);

                Client seller = batchGroup.Key;
                sheet.Range["A3", "G3"].MergeCells = true;
                sheet.Range["A3", "A3"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sheet.Cells[3, 1] = "文件瑕疵通知书";

                sheet.Range[sheet.Cells[5, 1], sheet.Cells[5, 7]].MergeCells = true;
                sheet.Cells[5, 1] = String.Format("卖方（出口商) : {0}", seller);

                int row = 7;
                foreach (InvoiceAssignBatch selectedBatch in batchGroup)
                {
                    Client buyer = selectedBatch.Case.BuyerClient;
                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 7]].MergeCells = true;
                    sheet.Cells[row, 1] = String.Format("买方(应收账款债务人) : {0}", buyer);
                    row++;
                    row++;
                    int rowBegin = row;

                    sheet.Cells[row, 1] = "";
                    sheet.Cells[row, 2] = "发票号码";
                    sheet.Cells[row, 3] = "发票金额";
                    sheet.Cells[row, 4] = "发票日期";
                    sheet.Cells[row, 5] = "到期日";
                    sheet.Cells[row, 6] = "瑕疵金额";
                    sheet.Cells[row, 7] = "原因";

                    row++;

                    string flawOtherReason = string.Empty;
                    for (int i = 1; i <= selectedBatch.Invoices.Count; i++)
                    {
                        Invoice invoice = selectedBatch.Invoices[i - 1];
                        if (invoice.IsFlaw)
                        {
                            sheet.Cells[row, 1] = i;
                            sheet.Cells[row, 2] = "'" + invoice.InvoiceNo;
                            sheet.Cells[row, 3] = invoice.AssignAmount;
                            sheet.Cells[row, 4] = invoice.InvoiceDate;
                            sheet.Cells[row, 5] = invoice.DueDate;
                            sheet.Cells[row, 6] = invoice.InvoiceAmount;
                            sheet.Cells[row, 7] = invoice.FlawReason;
                            if (!String.IsNullOrEmpty(invoice.FlawOtherReason) && String.IsNullOrEmpty(flawOtherReason))
                            {
                                flawOtherReason = invoice.FlawOtherReason;
                            }

                            row++;
                        }
                    }

                    sheet.Range[sheet.Cells[rowBegin, 1], sheet.Cells[row - 1, 6]].HorizontalAlignment =
                        XlHAlign.xlHAlignCenter;
                    sheet.Range[sheet.Cells[rowBegin + 1, 3], sheet.Cells[row - 1, 3]].NumberFormatLocal =
                        TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                    sheet.Range[sheet.Cells[rowBegin + 1, 6], sheet.Cells[row - 1, 6]].NumberFormatLocal =
                        TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);

                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 7]].MergeCells = true;
                    sheet.Cells[row, 1] = "原因：";
                    row++;
                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 7]].MergeCells = true;
                    sheet.Cells[row, 1] =
                        "01-卖方/买方基本资料不符; 02-发票为存根联或副联复印件; 03-发票无转让字据记载或贴错; \n"
                        + "04-账款到期日不符;        05-单据内容不符;             06-额度通知书过期或未签回; \n"
                        + "07-保理合同过期或未签回;  08-交货凭证内容不完整;       09-逾期转让;      10-其他;";
                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 60;
                    row++;
                    sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 7]].MergeCells = true;
                    int rowEnd = row;
                    sheet.Cells[row++, 1] = flawOtherReason;

                    sheet.Range[sheet.Cells[rowBegin, 1], sheet.Cells[rowEnd, 7]].Borders.LineStyle = 1;
                    row++;
                }

                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 3]].MergeCells = true;
                sheet.Cells[row, 1] = String.Format("日期： {0:yyyy-MM-dd}", DateTime.Today);
                sheet.Range[sheet.Cells[row, 4], sheet.Cells[row, 5]].MergeCells = true;
                sheet.Cells[row, 4] = "复核：";
                sheet.Range[sheet.Cells[row, 6], sheet.Cells[row, 7]].MergeCells = true;
                sheet.Cells[row, 6] = "经办：";

                row++;
                row++;
                sheet.Cells[row++, 1] = "瑕疵解除说明：";
                int table2Begin = row;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 120;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].VerticalAlignment = XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "卖方意见";
                sheet.Cells[row, 3] = "                                  签章：                    日期：";
                row++;

                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row + 1, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 120;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].VerticalAlignment = XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "分部意见";
                sheet.Cells[row, 3] = "                                  经办人签名：              日期：";
                row++;

                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 120;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].VerticalAlignment = XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 3] = "                                  有权签字人签名：          日期：";
                row++;

                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 120;
                sheet.Range[sheet.Cells[row, 3], sheet.Cells[row, 7]].VerticalAlignment = XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "保理部意见";
                sheet.Cells[row, 3] = "                                  有权签字人签名：          日期：";
                sheet.Range[sheet.Cells[table2Begin, 1], sheet.Cells[row, 7]].Borders.LineStyle = 1;

                sheet.UsedRange.Font.Name = "仿宋_GB2312";
                sheet.UsedRange.Font.Size = 12;
                sheet.Range["A1", "A2"].RowHeight = 20;
                sheet.Range["A3", "A3"].RowHeight = 30;
                sheet.Range["A3", "A3"].Font.Size = 22;

                sheet.Range["A1", Type.Missing].ColumnWidth = 3;
                sheet.Range["B1", Type.Missing].ColumnWidth = 10;
                sheet.Range["C1", Type.Missing].ColumnWidth = 17;
                sheet.Range["D1", Type.Missing].ColumnWidth = 13;
                sheet.Range["E1", Type.Missing].ColumnWidth = 13;
                sheet.Range["F1", Type.Missing].ColumnWidth = 17;
                sheet.Range["G1", Type.Missing].ColumnWidth = 12;

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
                }
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportThree(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_REPORT))
            {
                return;
            }

            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            foreach (InvoiceAssignBatch batch in selectedBatches)
            {
                if (batch.TransactionType == "国内买方保理" || batch.TransactionType == "进口保理")
                {
                    MessageBoxEx.Show(
                        String.Format("批次：{0}，案件类型为{1}，不能使用直接生成两表功能", batch.AssignBatchNo, batch.TransactionType),
                        MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MakeReport makeReport = ReportThreeImpl;
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }
        /// <summary>
        /// 
        /// </summary>
        private static void ReportThreeImpl(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            var app = new ApplicationClass { Visible = false };

            try
            {
                Workbook workbook = app.Workbooks.Add(true);

                //Boolean hasCommission =
                //    batchGroup.Any(
                //        selectedBatch =>
                //        selectedBatch.Case.ActiveCDA.CommissionType == "按转让金额" ||
                //        selectedBatch.Case.ActiveCDA.CommissionType == "其他");

                //if (hasCommission)
                //{
                //    var commissionSheet = (Worksheet)workbook.Sheets[1];
                //    commissionSheet.Name = "保理费用明细表";
                //    ReportCommissionSheet(commissionSheet, batchGroup);

                //    var financeSheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                //    financeSheet.Name = "可融资账款明细表";
                //    Worksheet poolsheet = null;

                //    if (batchGroup.Any(b => b.Case.IsPool == false))
                //    {
                //        ReportFinanceSheet(financeSheet, batchGroup, transactionType);
                //    }
                //    else
                //    {
                //        poolsheet = financeSheet;
                //    }
                //    if (batchGroup.Any(b => b.Case.IsPool))
                //    {
                //        if (poolsheet == null)
                //        {
                //            poolsheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                //        }
                //        poolsheet.Name = "可融资账款明细表(池融资)";
                //        ReportPoolFinanceSheet(poolsheet, batchGroup.Key);
                //    }
                //}
                //else
                //{
                var financeSheet = (Worksheet)workbook.Sheets[1];
                financeSheet.Name = "可融资账款明细表";
                Worksheet poolsheet = null;

                if (batchGroup.Any(b => b.Case.IsPool == false))
                {
                    ReportFinanceSheet(financeSheet, batchGroup, transactionType);
                }
                else
                {
                    poolsheet = financeSheet;
                }
                if (batchGroup.Any(b => b.Case.IsPool))
                {
                    if (poolsheet == null)
                    {
                        poolsheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                    }
                    poolsheet.Name = "可融资账款明细表(池融资)";
                    ReportPoolFinanceSheet(poolsheet, batchGroup.Key);
                }
                //}

                var assignSheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                assignSheet.Name = "应收账款转让明细表";
                ReportAssignSheet(assignSheet, batchGroup, transactionType);

                string filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}.xls", SystemUtil.DesktopPath, DateTime.Today,
                                                batchGroup.Key);
                int n = 1;
                while (File.Exists(filePath))
                {
                    filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}-{3}.xls", SystemUtil.DesktopPath, DateTime.Today,
                                                batchGroup.Key,n++);
                }
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentCell == null)
            {
                return;
            }

            var selectedBatch = (InvoiceAssignBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
            Selected = selectedBatch;
            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            menuItemBatchDelete.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_UPDATE);
            menuItemAssignReport.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemFinanceReport.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemCommissionReport.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemFileCheckList.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemFlawReport.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemThreeReports.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemMSG09.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
            menuItemBatchExport.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
        }
        /// <summary>
        ///
        /// </summary>
        public enum OpBatchType
        {
            /// <summary>
            /// 
            /// </summary>
            //CHECK,
            /// <summary>
            /// 
            /// </summary>
            DETAIL,

            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            REPORT,

            /// <summary>
            /// 
            /// </summary>
            COMMISSION,
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private delegate void MakeReport(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType);
    }
}