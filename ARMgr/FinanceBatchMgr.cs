//-----------------------------------------------------------------------
// <copyright file="FinanceBatchMgr.cs" company="Yiming Liu@Fudan">
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
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Rectangle = System.Drawing.Rectangle;
using XlHAlign = Microsoft.Office.Interop.Excel.XlHAlign;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceBatchMgr : UserControl
    {
        #region OpBatchType enum

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
            POOL_QUERY,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private readonly OpBatchType _opBatchType;


        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="selectedClient"></param>
        /// <param name="context"></param>
        public FinanceBatchMgr(Client selectedClient, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            panelQuery.Visible = false;
            colBuyerName.Visible = false;
            colBatchCount.Visible = false;
            colTransactionType.Visible = false;

            _bs.DataSource = selectedClient.InvoiceFinanceBatches;
            Context = context;
        }

        public FinanceBatchMgr(String username, String checkStatus)
            : this(OpBatchType.QUERY)
        {
            if(username == null)
            {
                Context = new DBDataContext();
                IQueryable<InvoiceFinanceBatch> queryResult = from batch in Context.InvoiceFinanceBatches
                                              where
                                                  batch.CheckStatus == checkStatus
                                              select batch;

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
            else
            {
                Context = new DBDataContext();
                IQueryable<InvoiceFinanceBatch> queryResult = from batch in Context.InvoiceFinanceBatches
                                                             where
                                                                 batch.CheckStatus == BATCH.UNCHECK && batch.CreateUserName == username
                                                             select batch;

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <param name="context"></param>
        public FinanceBatchMgr(Case selectedCase, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            panelQuery.Visible = false;
            _bs.DataSource = selectedCase.InvoiceFinanceBatches;
            Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="batchType"></param>
        public FinanceBatchMgr(OpBatchType batchType)
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

            cbStatus.Items.AddRange(new String[] { BATCH.CHECK, BATCH.UNCHECK, BATCH.REJECT });

            UpdateContextMenu();

            if (batchType == OpBatchType.POOL_QUERY)
            {
                toolStripSeparator3.Visible = false;
                menuItemCommissionReport.Visible = false;
                colBuyerName.Visible = false;
                colBatchCount.Visible = false;
                colTransactionType.Visible = false;
                colAssignDate.Visible = false;
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
        /// Gets or sets selected FinanceBatch
        /// </summary>
        public InvoiceFinanceBatch Selected { get; set; }


        //?Delegates?(1)?


        //?Private?Methods?(13)?
        private void Check(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_APPROVE))
            {
                return;
            }
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)_bs.List[this.dgvBatches.CurrentCell.RowIndex];
            if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("是否确认复核通过该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("经办人和复核人相同，不可进行复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            batch.CheckStatus = BATCH.CHECK;
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now;
            
            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
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

            List<InvoiceFinanceBatch> batches = GetSelectedBatches();

            if (
                MessageBoxEx.Show("是否打算删除此" + batches.Count() + "条融资批次信息", MESSAGE.TITLE_INFORMATION,
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            try
            {
                foreach (InvoiceFinanceBatch selectedBatch in batches)
                {
                    foreach (InvoiceFinanceLog log in selectedBatch.InvoiceFinanceLogs.ToList())
                    {
                        foreach (InvoiceRefundLog refundLog in log.InvoiceRefundLogs.ToList())
                        {
                            Context.InvoiceRefundLogs.DeleteOnSubmit(refundLog);
                        }

                        foreach (InvoiceRefundBatch refundBatch in selectedBatch.InvoiceRefundBatches.ToList())
                        {
                            if (refundBatch.InvoiceRefundLogs.Count == 0)
                            {
                                Context.InvoiceRefundBatches.DeleteOnSubmit(refundBatch);
                            }
                        }

                        Invoice invoice = log.Invoice;
                        log.Invoice = null;
                        invoice.PaidCommission -= log.PaidCommission.GetValueOrDefault();
                        invoice.CaculateFinance();
                        invoice.CaculateRefund();
                        Context.InvoiceFinanceLogs.DeleteOnSubmit(log);
                    }

                    _bs.Remove(selectedBatch);
                }

                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
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

            var selectedBatch = (InvoiceFinanceBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
            var detail = new FinanceBatchDetail(selectedBatch);
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
        /// <returns></returns>
        private List<InvoiceFinanceBatch> GetSelectedBatches()
        {
            if (dgvBatches.CurrentCell == null)
            {
                return null;
            }

            var selectedBatches = new List<InvoiceFinanceBatch>();

            foreach (DataGridViewCell cell in dgvBatches.SelectedCells)
            {
                var batch = (InvoiceFinanceBatch)_bs.List[cell.RowIndex];
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
        private static void GroupBatches(IEnumerable<InvoiceFinanceBatch> selectedBatches, MakeReport makeReport)
        {
            IEnumerable<IGrouping<string, InvoiceFinanceBatch>> caseGroups =
                selectedBatches.GroupBy(c => c.Case.TransactionType);

            foreach (var caseGroup in caseGroups)
            {
                IEnumerable<IGrouping<Client, InvoiceFinanceBatch>> groups = caseGroup.GroupBy(c => c.Case.SellerClient);
                foreach (var group in groups)
                {
                    makeReport(group);
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
            var location = (string)cbLocation.SelectedValue;
            string transactionType = cbTransactionType.Text;
            string status = cbStatus.Text;

            if (String.IsNullOrEmpty(transactionType))
            {
                transactionType = "全部";
            }

            string financeType = cbFinanceType.Text;
            if (String.IsNullOrEmpty(financeType))
            {
                financeType = "全部";
            }

            Context = new DBDataContext();

            IEnumerable<InvoiceFinanceBatch> queryResult;
            if (_opBatchType != OpBatchType.POOL_QUERY)
            {
                queryResult = Context.InvoiceFinanceBatches.Where(batch =>
                                                                  batch.FinanceBatchNo.Contains(tbFinanceBatchNo.Text)
                                                                  && (batch.CaseCode != null)
                                                                  &&
                                                                  (beginBatchDate != dateBatchFrom.MinDate
                                                                       ? batch.FinancePeriodBegin >= beginBatchDate
                                                                       : true)
                                                                  &&
                                                                  (endBatchDate != dateBatchTo.MinDate
                                                                       ? batch.FinancePeriodBegin <= endBatchDate
                                                                       : true)
                                                                  &&
                                                                  (beginInputDate != dateInputFrom.MinDate
                                                                       ? batch.InputDate >= beginInputDate
                                                                       : true)
                                                                  &&
                                                                  (endInputDate != dateInputTo.MinDate
                                                                       ? batch.InputDate <= endInputDate
                                                                       : true)
                                                                  && (status != string.Empty ? batch.CheckStatus == status : true)
                                                                  && (batch.CreateUserName.Contains(createUserName))
                                                                  &&
                                                                  (transactionType == "全部"
                                                                       ? true
                                                                       : batch.Case.TransactionType == transactionType)
                                                                  &&
                                                                  (financeType == "全部"
                                                                       ? true
                                                                       : batch.FinanceType == financeType)
                                                                  &&
                                                                  (location == "00"
                                                                       ? true
                                                                       : batch.Case.OwnerDepartment.LocationCode ==
                                                                         location)
                                                                  &&
                                                                  (batch.Case.SellerClient.ClientNameCN.Contains(
                                                                      clientName) ||
                                                                   batch.Case.SellerClient.ClientNameEN.Contains(
                                                                       clientName) ||
                                                                   batch.Case.BuyerClient.ClientNameCN.Contains(
                                                                       clientName) ||
                                                                   batch.Case.BuyerClient.ClientNameEN.Contains(
                                                                       clientName)));
            }
            else
            {
                queryResult = Context.InvoiceFinanceBatches.Where(batch =>
                                                                  batch.FinanceBatchNo.Contains(tbFinanceBatchNo.Text)
                                                                  && (batch.ClientEDICode != null)
                                                                  &&
                                                                  (beginBatchDate != dateBatchFrom.MinDate
                                                                       ? batch.FinancePeriodBegin >= beginBatchDate
                                                                       : true)
                                                                  &&
                                                                  (endBatchDate != dateBatchTo.MinDate
                                                                       ? batch.FinancePeriodBegin <= endBatchDate
                                                                       : true)
                                                                  &&
                                                                  (beginInputDate != dateInputFrom.MinDate
                                                                       ? batch.InputDate >= beginInputDate
                                                                       : true)
                                                                  &&
                                                                  (endInputDate != dateInputTo.MinDate
                                                                       ? batch.InputDate <= endInputDate
                                                                       : true)
                                                                  && (status != string.Empty ? batch.CheckStatus == status : true)
                                                                  && (batch.CreateUserName.Contains(createUserName))
                                                                  &&
                                                                  (financeType == "全部"
                                                                       ? true
                                                                       : batch.FinanceType == financeType)
                                                                  &&
                                                                  (location == "00"
                                                                       ? true
                                                                       : batch.Client.Department.LocationCode ==
                                                                         location)
                                                                  &&
                                                                  (batch.Client.ClientNameCN.Contains(clientName) ||
                                                                   batch.Client.ClientNameEN.Contains(clientName)));
            }

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        private void Reject(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_APPROVE))
            {
                return;
            }
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)_bs.List[this.dgvBatches.CurrentCell.RowIndex];
            
            if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("此批次已经过复核", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("是否确认复核退回该批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("经办人和复核人相同，不可进行复核退回", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            batch.CheckStatus = BATCH.REJECT;
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now;
            
            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            List<InvoiceFinanceBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            foreach (InvoiceFinanceBatch batch in selectedBatches)
            {
                if (batch.Case != null && batch.Case.ActiveCDA.CommissionType != "按融资金额")
                {
                    MessageBoxEx.Show("所选批次不是按照融资金额收取保理费用，批次号：" + batch.FinanceBatchNo, MESSAGE.TITLE_INFORMATION,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MakeReport makeReport = ReportCommissionApplication;
            GroupBatches(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        private static void ReportCommissionApplication(IGrouping<Client, InvoiceFinanceBatch> batchGroup)
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
        private static void ReportCommissionSheet(Worksheet sheet, IGrouping<Client, InvoiceFinanceBatch> batchGroup)
        {
            sheet.PageSetup.Zoom = false;
            sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            sheet.PageSetup.FitToPagesWide = 1;
            sheet.PageSetup.FitToPagesTall = false;

            //string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            //sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            Client seller = batchGroup.Key;
            sheet.Cells[3, 1] = String.Format("卖方：{0}", seller);
            sheet.Range["A5", "E5"].MergeCells = true;
            sheet.Range["A5", "A5"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            sheet.Cells[5, 1] = "保理费用明细表";

            int row = 7;
            decimal totalCommission = 0;

            foreach (InvoiceFinanceBatch selectedBatch in batchGroup)
            {
                Client buyer = selectedBatch.Case.BuyerClient;
                Factor factor = selectedBatch.Case.Factor;

                int beginRow = row;
                sheet.Cells[row, 1] = "买方";
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 6]].MergeCells = true;
                sheet.Cells[row, 2] = String.Format("{0} （应收账款债务人）", buyer);
                row++;
                sheet.Cells[row, 1] = "保理商";
                sheet.Range[sheet.Cells[row, 2], sheet.Cells[row, 4]].MergeCells = true;
                sheet.Cells[row, 2] = factor.ToString();
                sheet.Cells[row, 5] = "币别";
                sheet.Cells[row, 6] = selectedBatch.BatchCurrency;
                row++;
                sheet.Cells[row, 1] = "本次转让金额";
                sheet.Cells[row, 2] = "本次融资金额";
                sheet.Cells[row, 3] = "本次转让笔数";
                sheet.Cells[row, 4] = "转让日";
                sheet.Cells[row, 5] = "保理费率";
                sheet.Cells[row, 6] = "单据处理费";
                row++;
                sheet.Cells[row, 1] = selectedBatch.AssignAmount;
                sheet.Range["A" + row, "A" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.Case.InvoiceCurrency);
                sheet.Cells[row, 2] = selectedBatch.FinanceAmount;
                sheet.Range["B" + row, "B" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.Cells[row, 3] = selectedBatch.AssignCount;
                sheet.Cells[row, 4] = selectedBatch.AssignDate;
                sheet.Cells[row, 5] = selectedBatch.Case.ActiveCDA.Price;
                sheet.Cells[row, 6] = selectedBatch.Case.ActiveCDA.HandFee;
                sheet.Range["E" + row, "E" + row].NumberFormatLocal = "0.0000%";
                sheet.Range["F" + row, "F" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.Case.ActiveCDA.HandFeeCurr);
                row++;
                sheet.Cells[row, 1] = "小计";
                sheet.Cells[row, 5] = selectedBatch.CommissionAmount;
                sheet.Cells[row, 6] = selectedBatch.HandfeeAmount;
                sheet.Range["E" + row, "F" + row].NumberFormatLocal =
                    TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);

                int endRow = row;

                totalCommission += selectedBatch.CommissionAmount.GetValueOrDefault() +
                                   selectedBatch.HandfeeAmount.GetValueOrDefault();
                sheet.Range["A" + beginRow, "F" + endRow].Borders.LineStyle = 1;

                row += 3;
            }

            sheet.Cells[row - 1, 1] = "注：保理手续费按融资金额收取。";
            sheet.Cells[row, 5] = "费用总计";
            sheet.Cells[row, 6] = totalCommission;
            sheet.Range["F" + row, "F" + row].NumberFormatLocal =
                TypeUtil.GetExcelCurr(batchGroup.First().BatchCurrency);
            sheet.Range["E" + row, "F" + row].Borders.LineStyle = 1;

            row += 2;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "F"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "A"], sheet.Cells[row, "A"]].HorizontalAlignment =
                XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "公司名 （业务章）";
            row += 2;
            sheet.Range[sheet.Cells[row, "D"], sheet.Cells[row, "E"]].MergeCells = true;
            sheet.Range[sheet.Cells[row, "D"], sheet.Cells[row, "D"]].HorizontalAlignment =
                XlHAlign.xlHAlignRight;
            sheet.Cells[row, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Today);

            sheet.Range["A1", Type.Missing].ColumnWidth = 15;
            sheet.Range["B1", Type.Missing].ColumnWidth = 15;
            sheet.Range["C1", Type.Missing].ColumnWidth = 10;
            sheet.Range["D1", Type.Missing].ColumnWidth = 13;
            sheet.Range["E1", Type.Missing].ColumnWidth = 12;
            sheet.Range["F1", Type.Missing].ColumnWidth = 15;

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.UsedRange.Rows.RowHeight = 20;

            sheet.Range["A5", "A5"].Font.Size = 22;
            sheet.Range["A1", "A4"].RowHeight = 20;
            sheet.Range["A5", "A5"].RowHeight = 30;

            //var sealRange = ((Range)sheet.Cells[row - 3, 3]);
            //string sealPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            //sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue,
            //                        Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(Type.Missing, true, true, true, true, true, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          Type.Missing, Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
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

            var selectedBatch = (InvoiceFinanceBatch)_bs.List[dgvBatches.CurrentCell.RowIndex];
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
            menuItemCommissionReport.Enabled = PermUtil.ValidatePermission(Permissions.INVOICE_REPORT);
        }

        #region Nested type: MakeReport

        private delegate void MakeReport(IGrouping<Client, InvoiceFinanceBatch> batchGroup);

        #endregion
    }
}