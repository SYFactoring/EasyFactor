//-----------------------------------------------------------------------
// <copyright file="AssignBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;
    using Microsoft.Office.Core;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchMgr : UserControl
    {
        #region Methods (1)

        // Private Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportThree(object sender, EventArgs e)
        {
            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = new MakeReport(ReportThreeImpl);
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }

        #endregion Methods


        #region?Fields?(3)?

        /// <summary>
        /// 
        /// </summary>
        private Case _case;
        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        #endregion?Fields?


        #region?Enums?(1)?

        /// <summary>
        ///
        /// </summary>
        public enum OpBatchType
        {
            /// <summary>
            /// 
            /// </summary>
            CHECK,

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
            REPORT
        }

        #endregion?Enums?


        #region?Constructors?(3)?

        /// <summary>
        /// Initializes a new instance of the AssignBatchMgr class
        /// </summary>
        /// <param name="createUserName"></param>
        /// <param name="batchStatus"></param>
        public AssignBatchMgr(string createUserName, string batchStatus)
            : this(OpBatchType.QUERY)
        {
            this.tbCreateUserName.Text = createUserName;
            this.cbCheckStatus.Text = batchStatus;
            this.QueryBatch(null, null);
        }

        /// <summary>
        /// Initializes a new instance of the AssignBatchMgr class
        /// </summary>
        /// <param name="selectedCDA"></param>
        /// <param name="context"></param>
        public AssignBatchMgr(Case selectedCase, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            this._case = selectedCase;
            this.panelQuery.Visible = false;
            this.bs.DataSource = this._case.InvoiceAssignBatches;
            this.context = context;
        }

        /// <summary>
        /// Initializes a new instance of the AssignBatchMgr class
        /// </summary>
        /// <param name="batchType"></param>
        public AssignBatchMgr(OpBatchType batchType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvBatches.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvBatches.DataSource = this.bs;
            this.opBatchType = batchType;
            ControlUtil.SetDoubleBuffered(this.dgvBatches);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location() { LocationCode = "00", LocationName = "全部" });
            this.cbLocation.DataSource = allLocations;
            this.cbLocation.DisplayMember = "LocationName";
            this.cbLocation.ValueMember = "LocationCode";
            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();

            if (this.opBatchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = BATCH.UNCHECK;
                this.QueryBatch(null, null);
            }
            else if (this.opBatchType == OpBatchType.REPORT)
            {
                this.dateFrom.Value = DateTime.Now.Date;
                this.dateTo.Value = DateTime.Now.Date;
                this.cbCheckStatus.Text = BATCH.CHECK;
                this.QueryBatch(null, null);
            }
        }

        #endregion?Constructors?


        #region?Properties?(3)?

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets selected AssignBatch
        /// </summary>
        public InvoiceAssignBatch Selected
        {
            get;
            set;
        }

        #endregion?Properties?


        #region?Delegates?and?Events?(1)?

        //?Delegates?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        private delegate void MakeReport(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType);

        #endregion?Delegates?and?Events?


        #region?Methods?(25)?

        //?Private?Methods?(25)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_CHECK))
            {
                return;
            }

            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];

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
            batch.CheckDate = DateTime.Now.Date;

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            if (MessageBoxEx.Show("是否打算删除此转让批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (selectedBatch.CheckStatus == BATCH.CHECK)
            {
                MessageBoxEx.Show("不能删除已复核批次", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selectedBatch.Invoices.Count > 0)
            {
                MessageBoxEx.Show("不能删除此批次，它包含相关发票信息", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            context.InvoiceAssignBatches.DeleteOnSubmit(selectedBatch);
            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dgvBatches.Rows.RemoveAt(this.dgvBatches.CurrentCell.RowIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            AssignBatchDetail detail = new AssignBatchDetail(selectedBatch);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailBatch(sender, e);
            }
            else
            {
                this.SelectBatch(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBatches_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvBatches.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dgvBatches.RowHeadersDefaultCellStyle.Font, rectangle, this.dgvBatches.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportMSG09(object sender, EventArgs e)
        {
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];

            ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_MSG09_INVOICE, selectedBatch.Invoices);
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<InvoiceAssignBatch> GetSelectedBatches()
        {
            if (this.dgvBatches.CurrentCell == null)
            {
                return null;
            }

            List<InvoiceAssignBatch> selectedBatches = new List<InvoiceAssignBatch>();

            foreach (DataGridViewCell cell in this.dgvBatches.SelectedCells)
            {
                InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[cell.RowIndex];
                if (!selectedBatches.Contains(batch))
                {
                    selectedBatches.Add(batch);

                    //if (batch.CheckStatus != BATCH.CHECK)
                    //{
                    //    MessageBoxEx.Show("该批次状态不属于已审核，不能生成报表，批次号： " + batch.AssignBatchNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return null;
                    //}
                }
            }

            return selectedBatches;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedBatches"></param>
        /// <param name="makeReport"></param>
        private static void GroupBatchesByTransactionType(List<InvoiceAssignBatch> selectedBatches, MakeReport makeReport)
        {
            IEnumerable<IGrouping<string, InvoiceAssignBatch>> caseGroups = selectedBatches.GroupBy(c => c.Case.TransactionType);

            foreach (IGrouping<string, InvoiceAssignBatch> caseGroup in caseGroups)
            {
                string transactionType = caseGroup.Key;
                IEnumerable<IGrouping<Client, InvoiceAssignBatch>> groups = null;

                if (makeReport.Method.Name == "ReportFinanceApplication")
                {
                    switch (transactionType)
                    {
                        case "国内卖方保理":
                        case "出口保理":
                            groups = caseGroup.GroupBy(c => c.Case.SellerClient);
                            foreach (IGrouping<Client, InvoiceAssignBatch> group in groups)
                            {
                                makeReport(group, transactionType);
                            }
                            break;
                        case "国内买方保理":
                        case "进口保理":
                            groups = caseGroup.GroupBy(c => c.Case.BuyerClient);
                            foreach (IGrouping<Client, InvoiceAssignBatch> group in groups)
                            {
                                makeReport(group, transactionType);
                            }
                            break;
                        default: break;
                    }
                }
                else
                {
                    groups = caseGroup.GroupBy(c => c.Case.SellerClient);
                    foreach (IGrouping<Client, InvoiceAssignBatch> group in groups)
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
            DateTime beginDate = String.IsNullOrEmpty(this.dateFrom.Text) ? this.dateFrom.MinDate : this.dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(this.dateTo.Text) ? this.dateTo.MinDate : this.dateTo.Value.Date;
            string status = this.cbCheckStatus.Text;
            string createUserName = this.tbCreateUserName.Text;
            string clientName = this.tbClientName.Text;
            string transactionType = this.cbTransactionType.Text;
            string location = (string)this.cbLocation.SelectedValue;

            if (String.IsNullOrEmpty(transactionType))
            {
                transactionType = "全部";
            }

            context = new DBDataContext();

            IEnumerable<InvoiceAssignBatch> queryResult = context.InvoiceAssignBatches.Where(i =>
                    (i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text))
                && (beginDate != this.dateFrom.MinDate ? i.AssignDate >= beginDate : true)
                && (endDate != this.dateTo.MinDate ? i.AssignDate <= endDate : true)
                && (status != string.Empty ? i.CheckStatus == status : true)
                && (i.CreateUserName.Contains(createUserName))
                && (transactionType == "全部" ? true : i.Case.TransactionType == transactionType)
                && (location == "00" ? true : i.Case.OwnerDepartment.LocationCode == location)
                && (i.Case.SellerClient.ClientNameCN.Contains(clientName) || i.Case.SellerClient.ClientNameEN.Contains(clientName) || i.Case.BuyerClient.ClientNameCN.Contains(clientName) || i.Case.BuyerClient.ClientNameEN.Contains(clientName)));

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reject(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_CHECK))
            {
                return;
            }

            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];

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
            batch.CheckDate = DateTime.Now.Date;

            try
            {
                context.SubmitChanges();
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
        private void ReportAssign(object sender, EventArgs e)
        {
            List<InvoiceAssignBatch> selectedBatches = this.GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = new MakeReport(ReportAssignApplication);
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private void ReportAssignSheet(Worksheet sheet, IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            sheet.PageSetup.Zoom = false;
            sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            sheet.PageSetup.FitToPagesWide = 1;
            sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            Client seller = batchGroup.Key;
            sheet.Cells[2, 1] = String.Format("致： {0}", seller.ToString());
            sheet.get_Range("A4", "E4").MergeCells = true;
            sheet.get_Range("A4", "A4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[4, 1] = "应收账款转让明细表";
            sheet.get_Range("A1", "A3").RowHeight = 20;
            sheet.get_Range("A4", "A4").RowHeight = 30;

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
                sheet.Cells[row++, 2] = String.Format("{0}（应收账款债务人）", buyer.ToString());
                sheet.get_Range("B6", "B6").Font.Underline = true;
                if (factor != null)
                {
                    sheet.Cells[row, 1] = "进口保理商：";
                    sheet.Cells[row++, 2] = factor.ToString();
                }

                CDA cda = selectedBatch.Case.ActiveCDA;
                sheet.Cells[row, 1] = "信用风险额度：";
                sheet.Cells[row, 2] = cda.CreditCover.GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(cda.CreditCoverCurr);
                row++;
                sheet.Cells[row, 1] = "应收账款余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.AssignOutstanding;
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;

                sheet.get_Range("C9", "E9").MergeCells = true;
                sheet.Cells[row, 3] = String.Format("业务编号：{0}", selectedBatch.AssignBatchNo);
                sheet.get_Range("C9", "C9").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

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

                foreach (CreditNote creditNote in selectedBatch.CreditNotes)
                {
                    sheet.Cells[row, 1] = "'" + creditNote.CreditNoteNo;
                    sheet.Cells[row, 2] = creditNote.PaymentAmount;
                    sheet.Cells[row, 3] = creditNote.CreditNoteDate;
                    row++;
                }

                sheet.Cells[row, 1] = "小计";
                sheet.Cells[row, 2] = selectedBatch.AssignAmount;

                int invoiceEnd = row;
                sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.Case.InvoiceCurrency);
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 5], sheet.Cells[invoiceEnd, 5]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]).Borders.LineStyle = 1;

                row++;
                row++;
            }

            sheet.Cells[row, 1] = "本行已完成上述发票/贷项发票转让，特此通知";
            row++;
            row++;
            sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "E"]).MergeCells = true;
            sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "A"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）        ";
            row++;
            row++;
            sheet.get_Range(sheet.Cells[row, "C"], sheet.Cells[row, "D"]).MergeCells = true;
            sheet.get_Range(sheet.Cells[row, "C"], sheet.Cells[row, "C"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.get_Range("A4", "A4").Font.Size = 24;

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 20;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 20;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 10;

            Range sealRange = ((Range)sheet.Cells[row - 4, 3]);
            string sealPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue, Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(Report.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="group"></param>
        private void ReportAssignApplication(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                this.ReportAssignSheet(sheet, batchGroup, transactionType);
                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
                    sheet = null;
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
            List<InvoiceAssignBatch> selectedBatches = this.GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            foreach (InvoiceAssignBatch batch in selectedBatches)
            {
                if (batch.Case.ActiveCDA.CommissionType != "按转让金额" && batch.Case.ActiveCDA.CommissionType != "其他")
                {
                    MessageBoxEx.Show("所选批次不是按照转让金额（或其他）收取保理费用，批次号：" + batch.AssignBatchNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MakeReport makeReport = new MakeReport(ReportCommissionApplication);
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private void ReportCommissionSheet(Worksheet sheet, IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            sheet.PageSetup.Zoom = false;
            sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            sheet.PageSetup.FitToPagesWide = 1;
            sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            Client seller = batchGroup.Key;
            sheet.Cells[3, 1] = String.Format("卖方：{0}", seller.ToString());
            sheet.get_Range("A5", "E5").MergeCells = true;
            sheet.get_Range("A5", "A5").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[5, 1] = "保理费用明细表";

            int row = 7;
            double totalCommission = 0;
            bool showTotalCommission = true;

            foreach (InvoiceAssignBatch selectedBatch in batchGroup)
            {
                if (selectedBatch.Case.ActiveCDA.CommissionType != "按转让金额" && selectedBatch.Case.ActiveCDA.CommissionType != "其他")
                {
                    continue;
                }

                Client buyer = selectedBatch.Case.BuyerClient;
                Factor factor = selectedBatch.Case.Factor;

                CDA cda = selectedBatch.Case.ActiveCDA;

                int beginRow = row;
                sheet.Cells[row, 1] = "买方";
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 5]).MergeCells = true;
                sheet.Cells[row, 2] = String.Format("{0} （应收账款债务人）", buyer.ToString());
                row++;
                sheet.Cells[row, 1] = "保理商";
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 3]).MergeCells = true;
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
                sheet.get_Range("A" + row, "A" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.Cells[row, 2] = selectedBatch.Invoices.Count;
                sheet.Cells[row, 3] = selectedBatch.AssignDate;
                sheet.Cells[row, 4] = String.Format("{0:0.000%}", selectedBatch.Case.ActiveCDA.Price);
                sheet.get_Range("E" + row, "E" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.Case.ActiveCDA.HandFeeCurr);
                sheet.Cells[row++, 5] = selectedBatch.Case.ActiveCDA.HandFee;
                sheet.Cells[row, 1] = "小计";
                sheet.Cells[row, 4] = selectedBatch.CommissionAmount;
                sheet.Cells[row, 5] = selectedBatch.HandfeeAmount;
                sheet.get_Range("D" + row, "D" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.get_Range("E" + row, "E" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.Case.ActiveCDA.HandFeeCurr);

                int endRow = row;

                if (showTotalCommission && selectedBatch.Case.ActiveCDA.HandFeeCurr != selectedBatch.Case.InvoiceCurrency)
                {
                    showTotalCommission = false;
                }
                else
                {
                    totalCommission += selectedBatch.CommissionAmount.GetValueOrDefault() + selectedBatch.HandfeeAmount.GetValueOrDefault();
                }

                sheet.get_Range("A" + beginRow, "E" + endRow).Borders.LineStyle = 1;

                row += 3;
            }

            if (showTotalCommission)
            {
                sheet.Cells[row, 4] = "费用总计";
                sheet.Cells[row, 5] = totalCommission;
                sheet.get_Range("E" + row, "E" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(batchGroup.First().BatchCurrency);
                sheet.get_Range("D" + row, "E" + row).Borders.LineStyle = 1;
                row += 2;
            }

            sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "E"]).MergeCells = true;
            sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "A"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）";
            row += 2;
            sheet.get_Range(sheet.Cells[row, "C"], sheet.Cells[row, "D"]).MergeCells = true;
            sheet.get_Range(sheet.Cells[row, "C"], sheet.Cells[row, "C"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 16;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 17;

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.UsedRange.Rows.RowHeight = 20;

            sheet.get_Range("A5", "A5").Font.Size = 22;
            sheet.get_Range("A1", "A4").RowHeight = 20;
            sheet.get_Range("A5", "A5").RowHeight = 30;

            Range sealRange = ((Range)sheet.Cells[row - 3, 3]);
            string sealPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue, Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(Report.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        private void ReportCommissionApplication(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];
            try
            {
                ReportCommissionSheet(sheet, batchGroup, transactionType);
                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
                    sheet = null;
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

                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFileCheckList(object sender, EventArgs e)
        {
            List<InvoiceAssignBatch> selectedBatches = this.GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = new MakeReport(ReportFileCheckListImpl);
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        private void ReportFileCheckListImpl(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                sheet.PageSetup.Zoom = false;
                sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                sheet.PageSetup.FitToPagesWide = 1;
                sheet.PageSetup.FitToPagesTall = false;

                string logoPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

                Client seller = batchGroup.Key;

                sheet.get_Range("A3", "D3").MergeCells = true;
                sheet.get_Range("A3", "A3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[3, 1] = "文件检查单";

                sheet.get_Range(sheet.Cells[5, 1], sheet.Cells[5, 2]).MergeCells = true;
                sheet.Cells[5, 1] = String.Format("卖方：{0}", seller.ToString());

                int row = 7;
                foreach (InvoiceAssignBatch selectedBatch in batchGroup)
                {
                    Client buyer = selectedBatch.Case.BuyerClient;
                    sheet.Cells[row++, 1] = String.Format("买方：{0}", buyer.ToString());
                    sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 2]).MergeCells = true;
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
                        if (invoice.DueDate != null && invoice.DueDate < dueDate)
                        {
                            dueDate = invoice.DueDate;
                        }
                    }
                    sheet.Cells[rowDueDate, 1] = String.Format("Earliest due date:   {0:yyyy-MM-dd}", dueDate);

                    int rowEnd = row;

                    sheet.get_Range(sheet.Cells[rowBegin, 1], sheet.Cells[rowEnd, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.get_Range(sheet.Cells[rowBegin, 1], sheet.Cells[rowEnd, 4]).Borders.LineStyle = 1;

                    row += 3;
                }

                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row++, 1] = " □  第一次转让：通知函";
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row++, 1] = " □  应收帐款转让通知书(须检附正本)";
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row++, 1] = " □  发票复印件(第一联)";
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row++, 1] = " □  出货单复印件(或签收单复印件)";
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).RowHeight = 30;
                sheet.Cells[row++, 1] = " □  资料一致性：买卖方基本资料，发票上盖转让字句(复印件)，发票号码，发票金额，" + Environment.NewLine +
                                        "发票日，到期日，批复书其它相关条件。";
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row++, 1] = " □  保理额度通知书(Sign Back/ Expiry date)";
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row++, 1] = " □  合约书(Sign Back/ Expiry date)";
                row++;
                sheet.Cells[row++, 1] = "Discrepancies  □ Yes   □ No";

                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row, 1] = String.Format("运营组： 经办 {0}               复核 {1}              主管{2}", batchGroup.First().CreateUserName, batchGroup.First().CheckUserName, "");
                sheet.Cells[row + 1, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

                sheet.get_Range("A1", "A2").RowHeight = 20;
                sheet.get_Range("A3", "A3").RowHeight = 30;
                sheet.get_Range("A3", "A3").Font.Size = 22;

                sheet.get_Range("A1", Type.Missing).ColumnWidth = 20;
                sheet.get_Range("B1", Type.Missing).ColumnWidth = 20;
                sheet.get_Range("C1", Type.Missing).ColumnWidth = 20;
                sheet.get_Range("D1", Type.Missing).ColumnWidth = 20;

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
                    sheet = null;
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
            List<InvoiceAssignBatch> selectedBatches = this.GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = new MakeReport(ReportFinanceApplication);
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <param name="transactionType"></param>
        private void ReportFinanceSheet(Worksheet sheet, IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            //sheet.PageSetup.Zoom = false;
            //sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            //sheet.PageSetup.FitToPagesWide = 1;
            //sheet.PageSetup.FitToPagesTall = false;

            string logoPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

            sheet.get_Range("A3", "E3").MergeCells = true;
            sheet.get_Range("A3", "A3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
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

            sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).Font.Underline = true;
            sheet.Cells[row, 2] = String.Format("{0}", keyClient.ToString());

            row++;
            sheet.Cells[row, 1] = "最高保理融资额度：";

            Case firstCase = batchGroup.First().Case;
            CDA activeCDA = firstCase.ActiveCDA;
            ClientCreditLine creditLine = null;
            if (activeCDA != null)
            {
                creditLine = activeCDA.FinanceCreditLine;
                if (creditLine != null)
                {
                    sheet.Cells[row, 2] = creditLine.CreditLine;
                    sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(creditLine.CreditLineCurrency);
                }
            }

            row++;
            sheet.Cells[row, 1] = "总融资余额：";
            if (creditLine != null)
            {
                sheet.Cells[row, 2] = keyClient.GetFinanceOutstanding(creditLine.CreditLineCurrency).GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(creditLine.CreditLineCurrency);
            }

            row++;
            sheet.Cells[row, 1] = "最高可融资金额：";
            GuaranteeDeposit gd = keyClient.GetGuaranteeDeposit(firstCase.InvoiceCurrency);
            if (creditLine != null)
            {
                if (gd != null)
                {
                    sheet.Cells[row, 2] = keyClient.CanBeFinanceAmount(firstCase.TransactionType, firstCase.InvoiceCurrency) + gd.GuaranteeDepositAmount;
                    sheet.Cells[row, 3] = String.Format("（保证金 {0:N2})", gd.GuaranteeDepositAmount);
                }
                else
                {
                    sheet.Cells[row, 2] = keyClient.CanBeFinanceAmount(firstCase.TransactionType, firstCase.InvoiceCurrency);
                }
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(firstCase.InvoiceCurrency);
            }

            row += 3;

            foreach (InvoiceAssignBatch selectedBatch in batchGroup)
            {

                Client valueClient = null;
                if (transactionType == "国内卖方保理" || transactionType == "出口保理")
                {
                    valueClient = selectedBatch.Case.BuyerClient;
                    sheet.Cells[row, 1] = "买方：";
                }
                else
                {
                    valueClient = selectedBatch.Case.SellerClient;
                    sheet.Cells[row, 1] = "卖方：";
                }

                CDA cda = selectedBatch.Case.ActiveCDA;

                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).Font.Underline = true;
                if (transactionType == "国内卖方保理" || transactionType == "出口保理")
                {
                    sheet.Cells[row, 2] = String.Format("{0} （应收账款债务人）", valueClient.ToString());
                }
                else
                {
                    sheet.Cells[row, 2] = String.Format("{0} ", valueClient.ToString());
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

                row++;

                sheet.Cells[row, 1] = "信用风险额度：";
                sheet.Cells[row, 2] = cda.CreditCover.GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(cda.CreditCoverCurr);

                row++;
                sheet.Cells[row, 1] = "应收账款余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.AssignOutstanding;
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;
                sheet.Cells[row, 1] = "保理融资额度：";
                sheet.Cells[row, 2] = cda.FinanceLine.GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(cda.FinanceLineCurr);

                row++;
                sheet.Cells[row, 1] = "融资余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.FinanceOutstanding.GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;
                if (transactionType == "国内卖方保理" || transactionType == "出口保理")
                {
                    sheet.Cells[row, 1] = "此买方最高可融资金额：";
                }
                else
                {
                    sheet.Cells[row, 1] = "此卖方最高可融资金额：";
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

                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;
                row++;
                sheet.Cells[row, 1] = "发票号";
                sheet.Cells[row, 2] = "转让金额";
                sheet.Cells[row, 3] = "发票日期";
                sheet.Cells[row, 4] = "到期日";
                sheet.Cells[row, 5] = "备注";

                row++;
                int invoiceStart = row;
                double assignAmount = 0;
                foreach (Invoice invoice in selectedBatch.Invoices)
                {
                    if (invoice.IsFlaw == false)
                    {
                        sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
                        sheet.Cells[row, 2] = invoice.AssignAmount;
                        sheet.Cells[row, 3] = invoice.InvoiceDate;
                        sheet.Cells[row, 4] = invoice.DueDate;
                        sheet.Cells[row, 5] = invoice.Comment;
                        assignAmount += invoice.AssignAmount;
                        row++;
                    }
                }

                sheet.Cells[row, 1] = "小计";
                sheet.Cells[row, 2] = assignAmount;

                int invoiceEnd = row;

                sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]).Borders.LineStyle = 1;

                row += 3;
            }

            row -= 1;

            if (gd != null)
            {
                sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "E"]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "A"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 5]).RowHeight = 30;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 5]).WrapText = true;
                sheet.Cells[row, 1] = String.Format("注：{0:yyyy}年{0:MM}月{0:dd}日客户回款{1}{2:N2}，因融资未到期，此笔款项暂存入保证金账户。请确保我行融资还款风险无误。", gd.DepositDate, gd.GuaranteeDepositCurrency, gd.GuaranteeDepositAmount);
                row++;
            }

            row += 2;
            sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "E"]).MergeCells = true;
            sheet.get_Range(sheet.Cells[row, "A"], sheet.Cells[row, "A"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            sheet.Cells[row, 1] = "中国民生银行贸易金融事业部保理业务部 （业务章）        ";
            row++;
            row++;
            sheet.get_Range(sheet.Cells[row, "C"], sheet.Cells[row, "D"]).MergeCells = true;
            sheet.get_Range(sheet.Cells[row, "C"], sheet.Cells[row, "C"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            sheet.Cells[row, 3] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.get_Range(sheet.Cells[3, 1], sheet.Cells[3, 1]).Font.Size = 24;
            sheet.get_Range(sheet.Cells[3, 1], sheet.Cells[3, 5]).RowHeight = 30;

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 20;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 22;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 8;

            Range sealRange = ((Range)sheet.Cells[row - 4, 3]);
            string sealPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Seal.png");
            sheet.Shapes.AddPicture(sealPath, MsoTriState.msoFalse, MsoTriState.msoTrue, Convert.ToSingle(sealRange.Left) + 30, Convert.ToSingle(sealRange.Top), 120, 120);

            //                ((Worksheet)app.ActiveSheet).ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, Path.GetTempFileName(), XlFixedFormatQuality.xlQualityStandard, true, false, Type.Missing, Type.Missing, true, Type.Missing);

            sheet.Protect(Report.REPORT_PASSWORD, true, true, true, true, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            sheet.EnableSelection = XlEnableSelection.xlUnlockedCells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        /// <returns></returns>
        private void ReportFinanceApplication(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                this.ReportFinanceSheet(sheet, batchGroup, transactionType);
                Case firstCase = batchGroup.First().Case;
                CDA activeCDA = firstCase.ActiveCDA;
                if (activeCDA != null && activeCDA.CommissionType == "按融资金额")
                {
                    MessageBoxEx.Show(String.Format("此业务{0}按照融资金额收取费用，请及时导出《保理费用明细表》", firstCase.CaseCode));
                }
                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
                    sheet = null;
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

                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFlaw(object sender, EventArgs e)
        {
            List<InvoiceAssignBatch> selectedBatches = GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            MakeReport makeReport = new MakeReport(ReportFlawImpl);
            GroupBatchesByTransactionType(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        private void ReportFlawImpl(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                sheet.PageSetup.Zoom = false;
                sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                sheet.PageSetup.FitToPagesWide = 1;
                sheet.PageSetup.FitToPagesTall = false;

                string logoPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 240, 3, 170, 30);

                Client seller = batchGroup.Key;
                sheet.get_Range("A3", "G3").MergeCells = true;
                sheet.get_Range("A3", "A3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[3, 1] = "文件瑕疵通知书";

                sheet.get_Range(sheet.Cells[5, 1], sheet.Cells[5, 7]).MergeCells = true;
                sheet.Cells[5, 1] = String.Format("卖方（出口商) : {0}", seller.ToString());

                int row = 7;
                foreach (InvoiceAssignBatch selectedBatch in batchGroup)
                {
                    Client buyer = selectedBatch.Case.BuyerClient;
                    sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 7]).MergeCells = true;
                    sheet.Cells[row, 1] = String.Format("买方(应收账款债务人) : {0}", buyer.ToString());
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

                    sheet.get_Range(sheet.Cells[rowBegin, 1], sheet.Cells[row - 1, 6]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.get_Range(sheet.Cells[rowBegin + 1, 3], sheet.Cells[row - 1, 3]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                    sheet.get_Range(sheet.Cells[rowBegin + 1, 6], sheet.Cells[row - 1, 6]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);

                    sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 7]).MergeCells = true;
                    sheet.Cells[row, 1] = "原因：";
                    row++;
                    sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 7]).MergeCells = true;
                    sheet.Cells[row, 1] =
                          "01-卖方/买方基本资料不符; 02-发票为存根联或副联复印件; 03-发票无转让字据记载或贴错; \n"
                        + "04-账款到期日不符;        05-单据内容不符;             06-额度通知书过期或未签回; \n"
                        + "07-保理合同过期或未签回;  08-交货凭证内容不完整;       09-逾期转让;      10-其他;";
                    sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 60;
                    row++;
                    sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 7]).MergeCells = true;
                    int rowEnd = row;
                    sheet.Cells[row++, 1] = flawOtherReason;

                    sheet.get_Range(sheet.Cells[rowBegin, 1], sheet.Cells[rowEnd, 7]).Borders.LineStyle = 1;
                    row++;
                }

                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 3]).MergeCells = true;
                sheet.Cells[row, 1] = String.Format("日期： {0:yyyy-MM-dd}", DateTime.Today);
                sheet.get_Range(sheet.Cells[row, 4], sheet.Cells[row, 5]).MergeCells = true;
                sheet.Cells[row, 4] = "复核：";
                sheet.get_Range(sheet.Cells[row, 6], sheet.Cells[row, 7]).MergeCells = true;
                sheet.Cells[row, 6] = "经办：";

                row++;
                row++;
                sheet.Cells[row++, 1] = "瑕疵解除说明：";
                int table2Begin = row;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "卖方意见";
                sheet.Cells[row, 3] = "                                  签章：                    日期：";
                row++;

                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row + 1, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "分部意见";
                sheet.Cells[row, 3] = "                                  经办人签名：              日期：";
                row++;

                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 3] = "                                  有权签字人签名：          日期：";
                row++;

                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "保理部意见";
                sheet.Cells[row, 3] = "                                  有权签字人签名：          日期：";
                sheet.get_Range(sheet.Cells[table2Begin, 1], sheet.Cells[row, 7]).Borders.LineStyle = 1;

                sheet.UsedRange.Font.Name = "仿宋_GB2312";
                sheet.UsedRange.Font.Size = 12;
                sheet.get_Range("A1", "A2").RowHeight = 20;
                sheet.get_Range("A3", "A3").RowHeight = 30;
                sheet.get_Range("A3", "A3").Font.Size = 22;

                sheet.get_Range("A1", Type.Missing).ColumnWidth = 3;
                sheet.get_Range("B1", Type.Missing).ColumnWidth = 10;
                sheet.get_Range("C1", Type.Missing).ColumnWidth = 17;
                sheet.get_Range("D1", Type.Missing).ColumnWidth = 13;
                sheet.get_Range("E1", Type.Missing).ColumnWidth = 13;
                sheet.get_Range("F1", Type.Missing).ColumnWidth = 17;
                sheet.get_Range("G1", Type.Missing).ColumnWidth = 12;

                app.Visible = true;
            }
            catch (Exception e1)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
                    sheet = null;
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

                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batch"></param>
        private void ReportThreeImpl(IGrouping<Client, InvoiceAssignBatch> batchGroup, string transactionType)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Workbook workbook = app.Workbooks.Add(true);

                Boolean hasCommission = false;

                foreach (InvoiceAssignBatch selectedBatch in batchGroup)
                {
                    if (selectedBatch.Case.ActiveCDA.CommissionType == "按转让金额" || selectedBatch.Case.ActiveCDA.CommissionType == "其他")
                    {
                        hasCommission = true;
                        break;
                    }
                }

                if (hasCommission)
                {
                    Worksheet commissionSheet = (Worksheet)workbook.Sheets[1];
                    commissionSheet.Name = "保理费用明细表";
                    this.ReportCommissionSheet(commissionSheet, batchGroup, transactionType);

                    Worksheet financeSheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                    financeSheet.Name = "可融资账款明细表";
                    this.ReportFinanceSheet(financeSheet, batchGroup, transactionType);
                }
                else
                {
                    Worksheet financeSheet = (Worksheet)workbook.Sheets[1];
                    financeSheet.Name = "可融资账款明细表";
                    this.ReportFinanceSheet(financeSheet, batchGroup, transactionType);
                }

                Worksheet assignSheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                assignSheet.Name = "应收账款转让明细表";
                this.ReportAssignSheet(assignSheet, batchGroup, transactionType);

                string filePath = String.Format("{0}\\{1:yyyyMMdd}-{2}.xls", SystemUtil.DesktopPath, DateTime.Today, batchGroup.Key.ToString());
                workbook.SaveAs(filePath, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, false, Type.Missing, Type.Missing, Type.Missing);

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
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            this.Selected = selectedBatch;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_UPDATE))
            {
                this.menuItemBatchDelete.Enabled = true;
            }
            else
            {
                this.menuItemBatchDelete.Enabled = false;
            }

            if (PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permissions.INVOICE_CHECK))
            {
                this.menuItemCheck.Enabled = true;
                this.menuItemReject.Enabled = true;
            }
            else
            {
                this.menuItemCheck.Enabled = false;
                this.menuItemReject.Enabled = false;
            }
        }

        #endregion?Methods?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportAssignBatch(object sender, EventArgs e)
        {
            List<InvoiceAssignBatch> selectedBatches = this.GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_ASSIGN, selectedBatches);
            form.ShowDialog(this);
        }
    }
}
