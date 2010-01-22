//-----------------------------------------------------------------------
// <copyright file="AssignBatchMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
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
            QUERY
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

            if (batchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                var queryResult = App.Current.DbContext.InvoiceAssignBatches.Where(i => i.CheckStatus == "未复核");
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
            if (this.opBatchType == OpBatchType.QUERY || this.opBatchType == OpBatchType.CHECK)
            {
                DateTime beginDate = this.dateFrom.Text != string.Empty ? this.dateFrom.Value : this.dateFrom.MinDate;
                DateTime endDate = this.dateTo.Text != string.Empty ? this.dateTo.Value : this.dateTo.MinDate;
                string status = this.cbCheckStatus.Text;
                var queryResult = App.Current.DbContext.InvoiceAssignBatches.Where(i =>
                    i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text)
                    && (beginDate != this.dateFrom.MinDate ? i.AssignDate >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.AssignDate <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true));
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
            else if (this.opBatchType == OpBatchType.DETAIL)
            {
                var queryResult = this.cda.InvoiceAssignBatches.Where(i => i.AssignBatchNo.Contains(this.tbAssignBatchNo.Text));
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
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

        private void ReportAssign(object sender, EventArgs e)
        {
            if (this.dgvBatches.SelectedRows.Count == 0)
            {
                return;
            }
            InvoiceAssignBatch selectedBatch = (InvoiceAssignBatch)this.bs.List[this.dgvBatches.SelectedRows[0].Index];

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            string logoPath = Path.Combine(Environment.CurrentDirectory, "FOMSLOGO.png");
            sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 180, 3, 180, 40);

            Client seller = selectedBatch.CDA.Case.SellerClient;
            Client buyer = selectedBatch.CDA.Case.BuyerClient;
            sheet.Cells[1, 1] = String.Format("致{0}", seller.ToString());
            sheet.Cells[3, 2] = "应收账款转让明细表";
            sheet.get_Range(sheet.Cells[3, 2], sheet.Cells[3, 2]).Font.Size = 24;
            sheet.get_Range(sheet.Cells[2, 1], sheet.Cells[2, 5]).RowHeight = 30;

            Factor factor = null;
            switch (selectedBatch.CDA.Case.TransactionType)
            {
                case "国内卖方保理":
                case "国内信保保理":
                case "国内买方保理":
                case "租赁保理":
                    break;
                case "国际信保保理":
                case "出口保理":
                case "进口保理":
                    factor = selectedBatch.CDA.Case.BuyerFactor;
                    break;
                default:
                    break;
            }

            int row = 5;
            sheet.Cells[row, 1] = "买方：";
            sheet.Cells[row++, 2] = String.Format("{0}（应收账款债务人）", buyer.ToString());
            if (factor != null)
            {
                sheet.Cells[row, 1] = "进口保理商：";
                sheet.Cells[row++, 2] = factor.ToString();
            }
            sheet.Cells[row, 1] = "信用风险额度：";
            sheet.Cells[row++, 2] = String.Format("{0:N2}", selectedBatch.CDA.CreditCover);
            sheet.Cells[row, 1] = "应收账款余额：";
            sheet.Cells[row++, 2] = String.Format("{0:N2}", selectedBatch.CDA.GetAssignOutstanding(selectedBatch.CDA.Case.InvoiceCurrency));

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
            int invoiceEnd = row - 1;
            row++;
            row++;
            sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).NumberFormatLocal = "@";
            sheet.get_Range(sheet.Cells[invoiceStart, 1], sheet.Cells[invoiceEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.get_Range(sheet.Cells[invoiceStart, 2], sheet.Cells[invoiceEnd, 2]).NumberFormatLocal = "0.00";
            sheet.get_Range(sheet.Cells[invoiceStart, 3], sheet.Cells[invoiceEnd, 3]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[invoiceStart, 4], sheet.Cells[invoiceEnd, 4]).NumberFormatLocal = "yyyy/MM/dd";
            sheet.get_Range(sheet.Cells[invoiceStart, 5], sheet.Cells[invoiceEnd, 5]).NumberFormatLocal = "0.00";
            sheet.get_Range(sheet.Cells[invoiceStart - 1, 1], sheet.Cells[invoiceEnd, 5]).Borders.LineStyle = 1;


            row++;
            row++;

            sheet.Cells[row, 1] = "本行已完成上述发票/贷项发票转让，特此通知";
            sheet.Cells[row + 2, 3] = "中国民生银行       （业务章）";
            sheet.Cells[row + 3, 3] = "签字：";
            sheet.Cells[row + 4, 4] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日", DateTime.Now);

            sheet.UsedRange.Font.Name = "楷体";

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("D1", Type.Missing).ColumnWidth = 15;
            sheet.get_Range("E1", Type.Missing).ColumnWidth = 15;
            app.Visible = true;
        }

        private void ReportFinance(object sender, EventArgs e)
        {

        }

        private void ReportCommission(object sender, EventArgs e)
        {

        }
    }
}
