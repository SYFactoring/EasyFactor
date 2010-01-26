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
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using Microsoft.Office.Core;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchMgr : UserControl
    {
        #region Fields (3)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        /// <summary>
        /// 
        /// </summary>
        private CDA cda;

        /// <summary>
        /// 
        /// </summary>
        private OpBatchType opBatchType;

        #endregion Fields

        #region Enums (1)

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

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the AssignBatchMgr class
        /// </summary>
        /// <param name="selectedCDA"></param>
        public AssignBatchMgr(CDA selectedCDA)
            : this(OpBatchType.DETAIL)
        {
            this.cda = selectedCDA;
            this.panelQuery.Visible = false;
            this.bs.DataSource = this.cda.InvoiceAssignBatches;
        }

        /// <summary>
        /// Initializes a new instance of the AssignBatchMgr class
        /// </summary>
        /// <param name="batchType"></param>
        public AssignBatchMgr(OpBatchType batchType)
        {
            this.InitializeComponent();
            this.dgvBatches.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvBatches.DataSource = this.bs;
            this.opBatchType = batchType;
            ControlUtil.SetDoubleBuffered(this.dgvBatches);

            if (this.opBatchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                this.QueryBatch(null, null);
            }
            else if (this.opBatchType == OpBatchType.REPORT)
            {
                this.dateFrom.Value = DateTime.Now.Date;
                this.dateTo.Value = DateTime.Now.Date;
                this.cbCheckStatus.Text = "已复核";
                this.QueryBatch(null, null);
            }

            this.UpdateContextMenu();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (App.Current.CurUser.Role == "审核员")
            {
                this.menuItemCheck.Visible = true;
                this.menuItemReject.Visible = true;
                this.toolStripSeparator2.Visible = true;
            }
            else
            {
                this.menuItemCheck.Visible = false;
                this.menuItemReject.Visible = false;
                this.toolStripSeparator2.Visible = false;
            }
        }

        #endregion Constructors

        #region Properties (2)

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

        #endregion Properties

        #region Methods (9)

        // Private Methods (9) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvBatches.SelectedRows)
            {
                InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[row.Index];
                batch.CheckStatus = "已复核";
                batch.CheckUserName = App.Current.CurUser.Name;
                batch.CheckDate = DateTime.Now.Date;
            }
            App.Current.DbContext.SubmitChanges();
        }

        private void DeleteBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBox.Show("是否打算删除此转让批次", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (selectedBatch.Invoices.Count > 0)
                {
                    MessageBox.Show("不能删除此批次，它包含相关发票信息", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                App.Current.DbContext.InvoiceAssignBatches.DeleteOnSubmit(selectedBatch);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.dgvBatches.Rows.RemoveAt(this.dgvBatches.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
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

        private void dgvBatches_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvBatches.Columns[e.ColumnIndex];
            if (column == this.colIsCreateMsg)
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
        private void QueryBatch(object sender, EventArgs e)
        {
            DateTime beginDate = this.dateFrom.Text != string.Empty ? this.dateFrom.Value.Date : this.dateFrom.MinDate;
            DateTime endDate = this.dateTo.Text != string.Empty ? this.dateTo.Value.Date : this.dateTo.MinDate;
            string status = this.cbCheckStatus.Text;

            IEnumerable<InvoiceAssignBatch> queryResult = null;
            if (this.opBatchType == OpBatchType.CHECK || this.opBatchType == OpBatchType.QUERY || this.opBatchType == OpBatchType.REPORT)
            {
                queryResult = App.Current.DbContext.InvoiceAssignBatches.Where(i =>
                    i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text)
                    && (beginDate != this.dateFrom.MinDate ? i.AssignDate >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.AssignDate <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true));
            }
            else if (this.opBatchType == OpBatchType.DETAIL)
            {
                queryResult = this.cda.InvoiceAssignBatches.Where(i =>
                    i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text)
                    && (beginDate != this.dateFrom.MinDate ? i.AssignDate >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.AssignDate <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true));
            }
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
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvBatches.SelectedRows)
            {
                InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[row.Index];
                batch.CheckStatus = "复核未通过";
                batch.CheckUserName = App.Current.CurUser.Name;
                batch.CheckDate = DateTime.Now.Date;
            }
            App.Current.DbContext.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            this.Selected = selectedBatch;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
            }
        }

        #endregion Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportAssign(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (selectedBatch.CheckStatus != "已复核")
            {
                MessageBox.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 170, 30);

            Client seller = selectedBatch.CDA.Case.SellerClient;
            Client buyer = selectedBatch.CDA.Case.BuyerClient;
            sheet.Cells[2, 1] = String.Format("致： {0}", seller.ToString());
            sheet.get_Range("A4", "E4").MergeCells = true;
            sheet.get_Range("A4", "A4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[4, 1] = "应收账款转让明细表";
            sheet.get_Range("A1", "A3").RowHeight = 20;
            sheet.get_Range("A4", "A4").RowHeight = 30;

            Factor factor = null;
            switch (selectedBatch.CDA.Case.TransactionType)
            {
                case "国内卖方保理":
                case "国内信保保理":
                case "国内买方保理":
                case "租赁保理":
                    factor = selectedBatch.CDA.Case.SellerFactor;
                    break;
                case "国际信保保理":
                case "出口保理":
                case "进口保理":
                    factor = selectedBatch.CDA.Case.BuyerFactor;
                    break;
                default:
                    break;
            }

            int row = 6;
            sheet.Cells[row, 1] = "买方：";
            sheet.Cells[row++, 2] = String.Format("{0}（应收账款债务人）", buyer.ToString());
            sheet.get_Range("B6", "B6").Font.Underline = true;
            if (factor != null)
            {
                sheet.Cells[row, 1] = "进口保理商：";
                sheet.Cells[row++, 2] = factor.ToString();
            }
            sheet.Cells[row, 1] = "信用风险额度：";
            sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", selectedBatch.CDA.CreditCoverCurr, selectedBatch.CDA.CreditCover.GetValueOrDefault());
            sheet.Cells[row, 1] = "应收账款余额：";
            sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", selectedBatch.CDA.Case.InvoiceCurrency, selectedBatch.CDA.GetAssignOutstanding(selectedBatch.CDA.Case.InvoiceCurrency));

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
            sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = "¥#,##0.00";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 5], sheet.Cells[invoiceEnd, 5]).NumberFormatLocal = "¥#,##0.00";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 5], sheet.Cells[invoiceEnd, 5]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]).Borders.LineStyle = 1;

            row++;

            sheet.Cells[row, 1] = "本行已完成上述发票/贷项发票转让，特此通知";
            sheet.Cells[row + 2, 3] = "中国民生银行 贸易金融事业部保理业务部 （业务章）";
            sheet.Cells[row + 4, 4] = "签字：";
            sheet.Cells[row + 5, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.get_Range("A4", "A4").Font.Size = 24;

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 17;
            app.Visible = true;
            //System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFinance(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (selectedBatch.CheckStatus != "已复核")
            {
                MessageBox.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 200, 3, 180, 30);

            Client seller = selectedBatch.CDA.Case.SellerClient;
            Client buyer = selectedBatch.CDA.Case.BuyerClient;
            CDA cda = selectedBatch.CDA;

            sheet.get_Range("A3", "E3").MergeCells = true;
            sheet.get_Range("A3", "A3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[3, 1] = "可融资账款明细表";

            int row = 5;
            sheet.Cells[row, 1] = "卖方：";
            sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).Font.Underline = true;
            sheet.Cells[row++, 2] = String.Format("{0}", seller.ToString());
            sheet.Cells[row, 1] = "买方：";
            sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).Font.Underline = true;
            sheet.Cells[row++, 2] = String.Format("{0} （应收账款债务人）", buyer.ToString());
            row++;


            sheet.Cells[row, 1] = "信用风险额度：";
            double? creditCover = cda.CreditCover;
            sheet.Cells[row, 2] = String.Format("{0} {1:N2}", cda.CreditCoverCurr, cda.CreditCover.GetValueOrDefault());
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
                sheet.Cells[row, 5] = String.Format("{0} {1:N2}", creditLine.CreditLineCurrency, financeOutstanding.GetValueOrDefault());
            }

            row++;

            sheet.Cells[row, 1] = "预付款额度：";
            double? financeLine = cda.FinanceLine;
            sheet.Cells[row, 2] = String.Format("{0} {1:N2}", cda.FinanceLineCurr, financeLine.GetValueOrDefault());
            sheet.Cells[row, 4] = "总剩余额度：";
            if (creditLine != null)
            {
                sheet.Cells[row, 5] = String.Format("{0} {1:N2}", creditLine.CreditLineCurrency, creditLine.CreditLine - financeOutstanding.GetValueOrDefault());
            }

            row++;

            sheet.Cells[row, 1] = "融资余额：";
            financeOutstanding = cda.Case.FinanceOutstanding;
            sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", cda.FinanceLineCurr, financeOutstanding.GetValueOrDefault());

            row++;
            sheet.Cells[row, 1] = "发票号";
            sheet.Cells[row, 2] = "转让金额";
            sheet.Cells[row, 3] = "发票日期";
            sheet.Cells[row, 4] = "到期日";
            sheet.Cells[row, 5] = "备注";

            row++;
            int invoiceStart = row;
            foreach (Invoice invoice in selectedBatch.Invoices)
            {
                sheet.Cells[row, 1] = "'" + invoice.InvoiceNo;
                sheet.Cells[row, 2] = invoice.AssignAmount;
                sheet.Cells[row, 3] = invoice.InvoiceDate;
                sheet.Cells[row, 4] = invoice.DueDate;
                sheet.Cells[row, 5] = invoice.Comment;
                row++;
            }

            sheet.Cells[row, 1] = "小计";
            sheet.Cells[row, 2] = selectedBatch.AssignAmount;

            int invoiceEnd = row;


            sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = "¥#,##0.00";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]).Borders.LineStyle = 1;

            row++;
            row++;

            sheet.Cells[row + 1, 3] = "中国民生银行 贸易金融部保理业务部 （业务章）";
            sheet.Cells[row + 2, 4] = "签字：";
            sheet.Cells[row + 3, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.get_Range(sheet.Cells[3, 1], sheet.Cells[3, 1]).Font.Size = 24;
            sheet.get_Range(sheet.Cells[3, 1], sheet.Cells[3, 5]).RowHeight = 30;

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 20;
            app.Visible = true;

            //System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportCommission(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (selectedBatch.CheckStatus != "已复核")
            {
                MessageBox.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 170, 30);

            Client seller = selectedBatch.CDA.Case.SellerClient;
            Client buyer = selectedBatch.CDA.Case.BuyerClient;
            Factor factor = null;
            switch (selectedBatch.CDA.Case.TransactionType)
            {
                case "国内卖方保理":
                case "国内信保保理":
                case "国内买方保理":
                case "租赁保理":
                    factor = selectedBatch.CDA.Case.SellerFactor;
                    break;
                case "国际信保保理":
                case "出口保理":
                case "进口保理":
                    factor = selectedBatch.CDA.Case.BuyerFactor;
                    break;
                default:
                    break;
            }

            sheet.Cells[3, 1] = String.Format("卖方：{0}", seller.ToString());
            sheet.get_Range("A5", "E5").MergeCells = true;
            sheet.get_Range("A5", "A5").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[5, 1] = "保理费用明细表";

            sheet.Cells[7, 1] = "买方";
            sheet.get_Range(sheet.Cells[7, 2], sheet.Cells[7, 5]).MergeCells = true;
            sheet.Cells[7, 2] = String.Format("{0} （应收账款债务人）", buyer.ToString());
            sheet.Cells[8, 1] = "保理商";
            sheet.get_Range(sheet.Cells[8, 2], sheet.Cells[8, 3]).MergeCells = true;
            sheet.Cells[8, 2] = factor.ToString();
            sheet.Cells[8, 4] = "币别";
            sheet.Cells[8, 5] = selectedBatch.BatchCurrency;
            sheet.Cells[9, 1] = "本次转让金额";
            sheet.Cells[9, 2] = "本次转让笔数";
            sheet.Cells[9, 3] = "转让日";
            sheet.Cells[9, 4] = "保理费率";
            sheet.Cells[9, 5] = "单据处理费";
            sheet.Cells[10, 1] = selectedBatch.AssignAmount;
            sheet.Cells[10, 2] = selectedBatch.Invoices.Count;
            sheet.Cells[10, 3] = selectedBatch.AssignDate;
            sheet.Cells[10, 4] = String.Format("{0:0.00%}", selectedBatch.CDA.Price);
            sheet.Cells[10, 5] = selectedBatch.CDA.HandFee;
            sheet.Cells[11, 1] = "小计";
            sheet.get_Range("A11", "A11").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            sheet.Cells[11, 4] = selectedBatch.CommissionAmount;
            sheet.Cells[11, 5] = selectedBatch.HandfeeAmount;

            sheet.Cells[13, 4] = "费用总计";
            sheet.Cells[13, 5] = selectedBatch.CommissionAmount.GetValueOrDefault() + selectedBatch.HandfeeAmount.GetValueOrDefault();

            sheet.Cells[15, 1] = String.Format("制表：{0}", selectedBatch.CreateUserName);
            sheet.Cells[15, 3] = String.Format("复核：{0}", selectedBatch.CheckUserName);
            sheet.Cells[15, 5] = "主管：";
            sheet.Cells[17, 3] = "中国民生银行 贸易金融部保理业务部  （业务章）";
            sheet.Cells[18, 5] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 17;
            sheet.get_Range("A7", "E11").Borders.LineStyle = 1;
            sheet.get_Range("D13", "E13").Borders.LineStyle = 1;

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.UsedRange.Rows.RowHeight = 20;

            sheet.get_Range("A5", "A5").Font.Size = 22;
            sheet.get_Range("A1", "A4").RowHeight = 20;
            sheet.get_Range("A5", "A5").RowHeight = 30;

            sheet.get_Range("A10", "A10").NumberFormatLocal = "¥#,##0.00";
            sheet.get_Range("E10", "E10").NumberFormatLocal = "¥#,##0.00";
            sheet.get_Range("D11", "E11").NumberFormatLocal = "¥#,##0.00";
            sheet.get_Range("E13", "E13").NumberFormatLocal = "¥#,##0.00";

            app.Visible = true;

            //System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFlaw(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (selectedBatch.CheckStatus != "已复核")
            {
                MessageBox.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 170, 30);

            Client seller = selectedBatch.CDA.Case.SellerClient;
            Client buyer = selectedBatch.CDA.Case.BuyerClient;
            Factor factor = null;
            switch (selectedBatch.CDA.Case.TransactionType)
            {
                case "国内卖方保理":
                case "国内信保保理":
                case "国内买方保理":
                case "租赁保理":
                    factor = selectedBatch.CDA.Case.SellerFactor;
                    break;
                case "国际信保保理":
                case "出口保理":
                case "进口保理":
                    factor = selectedBatch.CDA.Case.BuyerFactor;
                    break;
                default:
                    break;
            }

            sheet.get_Range("A3", "G3").MergeCells = true;
            sheet.get_Range("A3", "A3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[3, 1] = "文件瑕疵通知书";

            sheet.get_Range(sheet.Cells[5, 1], sheet.Cells[5, 4]).MergeCells = true;
            sheet.Cells[5, 1] = "卖方（出口商)";
            sheet.get_Range(sheet.Cells[5, 5], sheet.Cells[5, 7]).MergeCells = true;
            sheet.Cells[5, 5] = "买方(应收账款债务人)";
            sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[6, 4]).MergeCells = true;
            sheet.Cells[6, 1] = seller.ToString();
            sheet.get_Range(sheet.Cells[6, 5], sheet.Cells[6, 7]).MergeCells = true;
            sheet.Cells[6, 5] = buyer.ToString();
            sheet.Cells[7, 1] = "保理部作业组";

            int row = 9;
            sheet.Cells[row, 1] = "";
            sheet.Cells[row, 2] = "发票号码";
            sheet.Cells[row, 3] = "发票金额";
            sheet.Cells[row, 4] = "发票日期";
            sheet.Cells[row, 5] = "到期日";
            sheet.Cells[row, 6] = "瑕疵金额";
            sheet.Cells[row, 7] = "原因";
            row++;
            for (int i = 1; i <= selectedBatch.Invoices.Count; i++)
            {
                Invoice invoice = selectedBatch.Invoices[i - 1];
                sheet.Cells[row, 1] = i;
                sheet.Cells[row, 2] = "'" + invoice.InvoiceNo;
                sheet.Cells[row, 3] = invoice.AssignAmount;
                sheet.Cells[row, 4] = invoice.InvoiceDate;
                sheet.Cells[row, 5] = invoice.DueDate;
                sheet.Cells[row, 6] = invoice.InvoiceAmount;
                sheet.Cells[row, 7] = invoice.FlawReason;
                row++;
            }

            sheet.get_Range(sheet.Cells[9, 1], sheet.Cells[row - 1, 7]).Borders.LineStyle = 1;
            sheet.get_Range(sheet.Cells[9, 1], sheet.Cells[row - 1, 6]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[10, 3], sheet.Cells[row - 1, 3]).NumberFormatLocal = "¥#,##0.00";
            sheet.get_Range(sheet.Cells[10, 6], sheet.Cells[row - 1, 6]).NumberFormatLocal = "¥#,##0.00";

            sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 7]).MergeCells = true;
            sheet.Cells[row, 1] = "原因：";
            row++;
            sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 7]).MergeCells = true;
            sheet.Cells[row, 1] = "8个原因";
            row++;

            sheet.UsedRange.Font.Name = "仿宋_GB2312";
            sheet.UsedRange.Font.Size = 12;
            sheet.get_Range("A1", "A2").RowHeight = 20;
            sheet.get_Range("A3", "A3").RowHeight = 30;

            sheet.get_Range("A5", "G6").Borders.LineStyle = 1;
            sheet.get_Range("A1", Type.Missing).ColumnWidth = 2;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("F1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("G1", Type.Missing).ColumnWidth = 17;
            app.Visible = true;

            //System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
        }
    }
}
