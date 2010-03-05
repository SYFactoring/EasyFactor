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
    using DevComponents.DotNetBar;
    using Microsoft.Office.Core;
    using Microsoft.Office.Interop.Excel;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchMgr : UserControl
    {
        #region Fields (3)

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

        #region Constructors (3)

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
        public AssignBatchMgr(Case selectedCase)
            : this(OpBatchType.DETAIL)
        {
            this._case = selectedCase;
            this.panelQuery.Visible = false;
            this.bs.DataSource = this._case.InvoiceAssignBatches;
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
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.UpdateContextMenu();

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
        }

        #endregion Constructors

        #region Properties (3)

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

        #endregion Properties

        #region Methods (16)

        // Private Methods (16) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permission.INVOICE_CHECK))
            {
                return;
            }

            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];

            if (batch.CheckStatus != "未复核" && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permission.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("此批次已经过复核", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("是否确认复核通过该批次", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("经办人和复核人相同，不可进行复核", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            batch.CheckStatus = "已复核";
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

            context.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permission.INVOICE_UPDATE))
            {
                return;
            }

            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];
            if (MessageBoxEx.Show("是否打算删除此转让批次", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (selectedBatch.Invoices.Count > 0)
            {
                MessageBoxEx.Show("不能删除此批次，它包含相关发票信息", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            context.InvoiceAssignBatches.DeleteOnSubmit(selectedBatch);
            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.dgvBatches.Rows.RemoveAt(this.dgvBatches.SelectedRows[0].Index);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void ExportMSG09(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];

            ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_MSG09, selectedBatch.Invoices);
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileCheckList(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 160, 3, 170, 30);

                Client seller = selectedBatch.Case.SellerClient;
                Client buyer = selectedBatch.Case.BuyerClient;

                sheet.Cells[1, 1] = "文件检查单";
                sheet.get_Range("A3", "D3").MergeCells = true;
                sheet.get_Range("A3", "A3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[3, 1] = "CHECK LIST-- EF";

                sheet.get_Range(sheet.Cells[5, 1], sheet.Cells[5, 2]).MergeCells = true;
                sheet.Cells[5, 1] = String.Format("卖方：{0}", seller.ToString());
                sheet.get_Range(sheet.Cells[5, 3], sheet.Cells[5, 4]).MergeCells = true;
                sheet.Cells[5, 3] = String.Format("No. of Invoice(s) attached: {0}", selectedBatch.BatchCount);

                sheet.Cells[7, 1] = "Inv. No. List:";

                int row = 8;
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
                        dueDate = invoice.DueDate.Value;
                    }
                }

                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[row, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[row, 4]).Borders.LineStyle = 1;

                row++;
                row++;

                sheet.Cells[row++, 1] = String.Format("买方：{0}", buyer.ToString());
                sheet.Cells[row++, 1] = String.Format("No. of Credit Note(s) attached: {0}", 0);
                sheet.Cells[row++, 1] = String.Format("Earliest due date:   {0:yyyy-MM-dd}", dueDate);
                row++;
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

                row += 10;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 4]).MergeCells = true;
                sheet.Cells[row, 1] = String.Format("运营组： 经办 {0}               复核 {1}              主管{2}", selectedBatch.CreateUserName, selectedBatch.CheckUserName, "");

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

                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            string createUserName = this.tbCreateUserName.Text;
            string clientName = this.tbClientName.Text;

            context = new DBDataContext();

            IEnumerable<InvoiceAssignBatch> queryResult = context.InvoiceAssignBatches.Where(i =>
                    (i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text))
                && (beginDate != this.dateFrom.MinDate ? i.AssignDate >= beginDate : true)
                && (endDate != this.dateTo.MinDate ? i.AssignDate <= endDate : true)
                && (status != string.Empty ? i.CheckStatus == status : true)
                && (i.CreateUserName.Contains(createUserName))
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
            if (!PermUtil.CheckPermission(CMBC.EasyFactor.Utils.Permission.INVOICE_CHECK))
            {
                return;
            }

            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }

            InvoiceAssignBatch batch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];

            if (batch.CheckStatus != "未复核" && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permission.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("此批次已经过复核", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("是否确认复核退回该批次", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("经办人和复核人相同，不可进行复核退回", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            batch.CheckStatus = "复核未通过";
            batch.CheckUserName = App.Current.CurUser.Name;
            batch.CheckDate = DateTime.Now.Date;

            context.SubmitChanges();
        }

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
                MessageBoxEx.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 170, 30);

                Client seller = selectedBatch.Case.SellerClient;
                Client buyer = selectedBatch.Case.BuyerClient;
                sheet.Cells[2, 1] = String.Format("致： {0}", seller.ToString());
                sheet.get_Range("A4", "E4").MergeCells = true;
                sheet.get_Range("A4", "A4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[4, 1] = "应收账款转让明细表";
                sheet.get_Range("A1", "A3").RowHeight = 20;
                sheet.get_Range("A4", "A4").RowHeight = 30;

                Factor factor = null;
                switch (selectedBatch.Case.TransactionType)
                {
                    case "国内卖方保理":
                    case "国内信保保理":
                    case "国内买方保理":
                    case "租赁保理":
                    case "进口保理":
                        break;
                    case "出口保理":
                    case "国际信保保理":
                        factor = selectedBatch.Case.SellerFactor;
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

                CDA cda = selectedBatch.Case.ActiveCDA;
                sheet.Cells[row, 1] = "信用风险额度：";
                sheet.Cells[row, 2] = cda.CreditCover.GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(cda.CreditCoverCurr);
                row++;
                sheet.Cells[row, 1] = "应收账款余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.AssignOutstanding;
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);

                row++;

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
                sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.Case.InvoiceCurrency);
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 2], sheet.Cells[invoiceEnd, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 3], sheet.Cells[invoiceEnd, 3]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy-MM-dd";
                sheet.get_Range(sheet.Cells[invoiceStart - 1, 4], sheet.Cells[invoiceEnd, 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
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

                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBoxEx.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];
            try
            {

                string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 170, 30);

                Client seller = selectedBatch.Case.SellerClient;
                Client buyer = selectedBatch.Case.BuyerClient;
                Factor factor = null;
                switch (selectedBatch.Case.TransactionType)
                {
                    case "国内卖方保理":
                    case "国内信保保理":
                    case "出口保理":
                    case "国际信保保理":
                    case "租赁保理":
                        factor = selectedBatch.Case.BuyerFactor;
                        break;
                    case "国内买方保理":
                    case "进口保理":
                        factor = selectedBatch.Case.SellerFactor;
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
                sheet.Cells[10, 4] = String.Format("{0:0.00%}", selectedBatch.Case.ActiveCDA.Price);
                sheet.Cells[10, 5] = selectedBatch.Case.ActiveCDA.HandFee;
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

                sheet.get_Range("A10", "A10").NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.get_Range("E10", "E10").NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.Case.ActiveCDA.HandFeeCurr);
                sheet.get_Range("D11", "E11").NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.get_Range("E13", "E13").NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);

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

                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBoxEx.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 200, 3, 180, 30);

                Client seller = selectedBatch.Case.SellerClient;
                Client buyer = selectedBatch.Case.BuyerClient;
                CDA cda = selectedBatch.Case.ActiveCDA;

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
                sheet.Cells[row, 2] = cda.CreditCover.GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(cda.CreditCoverCurr);
                sheet.Cells[row, 4] = "最高预付款额度：";
                ClientCreditLine creditLine = cda.FinanceCreditLine;
                if (creditLine != null)
                {
                    sheet.Cells[row, 5] = creditLine.CreditLine;
                    sheet.get_Range(sheet.Cells[row, 5], sheet.Cells[row, 5]).NumberFormatLocal = TypeUtil.GetExcelCurrency(creditLine.CreditLineCurrency);
                }

                row++;
                sheet.Cells[row, 1] = "应收账款余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.AssignOutstanding;
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(selectedBatch.Case.InvoiceCurrency);
                sheet.Cells[row, 4] = "总融资余额：";
                if (creditLine != null)
                {
                    sheet.Cells[row, 5] = seller.GetFinanceOutstanding(creditLine.CreditLineCurrency).GetValueOrDefault();
                    sheet.get_Range(sheet.Cells[row, 5], sheet.Cells[row, 5]).NumberFormatLocal = TypeUtil.GetExcelCurrency(creditLine.CreditLineCurrency);
                }

                row++;
                sheet.Cells[row, 1] = "预付款额度：";
                sheet.Cells[row, 2] = cda.FinanceLine.GetValueOrDefault();
                sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 2]).NumberFormatLocal = TypeUtil.GetExcelCurrency(cda.FinanceLineCurr);
                sheet.Cells[row, 4] = "总剩余额度：";
                if (creditLine != null)
                {
                    sheet.Cells[row, 5] = creditLine.CreditLine - seller.GetFinanceOutstanding(creditLine.CreditLineCurrency).GetValueOrDefault();
                    sheet.get_Range(sheet.Cells[row, 5], sheet.Cells[row, 5]).NumberFormatLocal = TypeUtil.GetExcelCurrency(creditLine.CreditLineCurrency);
                }

                row++;
                sheet.Cells[row, 1] = "融资余额：";
                sheet.Cells[row, 2] = selectedBatch.Case.FinanceOutstanding.GetValueOrDefault();
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

                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBoxEx.Show("该批次状态不属于已审核，不能生成报表", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                string logoPath = Path.Combine(Environment.CurrentDirectory, "CMBCExport.png");
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 240, 3, 170, 30);

                Client seller = selectedBatch.Case.SellerClient;
                Client buyer = selectedBatch.Case.BuyerClient;

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

                int row = 8;
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
                        if (invoice.FlawOtherReason != string.Empty && flawOtherReason == string.Empty)
                        {
                            flawOtherReason = invoice.FlawOtherReason;
                        }

                        row++;
                    }
                }

                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[row - 1, 6]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.get_Range(sheet.Cells[9, 3], sheet.Cells[row - 1, 3]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                sheet.get_Range(sheet.Cells[9, 6], sheet.Cells[row - 1, 6]).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);

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
                sheet.Cells[row++, 1] = flawOtherReason;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 3]).MergeCells = true;
                sheet.Cells[row, 1] = String.Format("日期： {0:yyyy-MM-dd}", DateTime.Today);
                sheet.get_Range(sheet.Cells[row, 4], sheet.Cells[row, 5]).MergeCells = true;
                sheet.Cells[row, 4] = "复核：";
                sheet.get_Range(sheet.Cells[row, 6], sheet.Cells[row, 7]).MergeCells = true;
                sheet.Cells[row, 6] = "经办：";
                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[row, 7]).Borders.LineStyle = 1;
                row++;

                row++;
                row++;
                sheet.Cells[row++, 1] = "瑕疵解除说明：";
                int table2Begin = row;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "卖方意见";
                sheet.Cells[row, 3] = "                                                               签章：                    日期：";
                row++;

                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row + 1, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "分部意见";
                sheet.Cells[row, 3] = "                                                               经办人签名：              日期：";
                row++;

                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 3] = "                                                               有权签字人签名：          日期：";
                row++;

                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).MergeCells = true;
                sheet.get_Range(sheet.Cells[row, 1], sheet.Cells[row, 1]).RowHeight = 120;
                sheet.get_Range(sheet.Cells[row, 3], sheet.Cells[row, 7]).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                sheet.Cells[row, 1] = "保理部意见";
                sheet.Cells[row, 3] = "                                                               有权签字人签名：          日期：";
                sheet.get_Range(sheet.Cells[table2Begin, 1], sheet.Cells[row, 7]).Borders.LineStyle = 1;

                sheet.UsedRange.Font.Name = "仿宋_GB2312";
                sheet.UsedRange.Font.Size = 12;
                sheet.get_Range("A1", "A2").RowHeight = 20;
                sheet.get_Range("A3", "A3").RowHeight = 30;
                sheet.get_Range("A3", "A3").Font.Size = 22;

                sheet.get_Range("A5", "G6").Borders.LineStyle = 1;
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

                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permission.INVOICE_UPDATE))
            {
                this.menuItemBatchDelete.Enabled = true;
            }
            else
            {
                this.menuItemBatchDelete.Enabled = false;
            }

            if (PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permission.INVOICE_CHECK))
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

        #endregion Methods
    }
}
