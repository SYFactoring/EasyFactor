//-----------------------------------------------------------------------
// <copyright file="CaseMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        /// <summary>
        /// 
        /// </summary>
        private OpCaseType opCaseType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpCaseType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            ENABLE_CASE,

            /// <summary>
            /// 
            /// </summary>
            APPLICATION_CASE,

            /// <summary>
            /// 
            /// </summary>
            STAT
        }

        #endregion Enums

        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        /// <param name="isContract"></param>
        public CaseMgr(OpCaseType opCaseType)
            : this()
        {
            this.opCaseType = opCaseType;
            if (opCaseType == OpCaseType.ENABLE_CASE)
            {
                this.cbCaseMark.Text = "启动案";
            }
            else if (opCaseType == OpCaseType.APPLICATION_CASE)
            {
                this.cbCaseMark.Text = "申请案";
                this.QueryCase(null, null);
            }
            else if (opCaseType == OpCaseType.STAT)
            {
                this.colAppDate.Visible = false;
                this.colOPName.Visible = false;
                this.colAssignAmount.Visible = true;
                this.colFinanceAmount.Visible = true;
                this.colCommissionIncome.Visible = true;
                this.colNetInterestIncome.Visible = true;
                this.colMarginIncome.Visible = true;
                this.colTotalIncome.Visible = true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        public CaseMgr()
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvCases.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvCases.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvCases);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.cbTransactionType.Items.Insert(0, "全部");
            this.cbTransactionType.Text = "全部";

            List<Department> deptsList = Department.AllDepartments(new DBDataContext());
            deptsList.Insert(0, new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" });
            this.cbOwnerDepts.DataSource = deptsList;
            this.cbOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbOwnerDepts.ValueMember = "DepartmentCode";
            this.cbOwnerDepts.GroupingMembers = "Domain";

            List<Currency> currencyList = Currency.AllCurrencies();
            currencyList.Insert(0, new Currency() { CurrencyCode = "AAA", CurrencyName = "All" });
            this.cbCurrency.DataSource = currencyList;
            this.cbCurrency.DisplayMember = "CurrencyFormat";
            this.cbCurrency.ValueMember = "CurrencyCode";

            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();
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
        /// Gets or sets selected Case
        /// </summary>
        public Case Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (11)

        // Private Methods (11) 

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailCase(sender, e);
            }
            else
            {
                this.SelectCase(sender, e);
            }
        }

        /// <summary>
        /// Delete selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCase(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            if (MessageBoxEx.Show("此案件是" + selectedCase.CaseMark + "，是否确定删除", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool isDeleteOK = true;
                foreach (InvoiceAssignBatch assignBatch in selectedCase.InvoiceAssignBatches)
                {
                    foreach (Invoice invoice in assignBatch.Invoices)
                    {
                        foreach (InvoiceFinanceLog financeLog in invoice.InvoiceFinanceLogs)
                        {
                            context.InvoiceRefundLogs.DeleteAllOnSubmit(financeLog.InvoiceRefundLogs);
                        }

                        context.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                        context.InvoiceFinanceLogs.DeleteAllOnSubmit(invoice.InvoiceFinanceLogs);

                    }

                    context.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                }

                context.InvoiceAssignBatches.DeleteAllOnSubmit(selectedCase.InvoiceAssignBatches);
                context.InvoiceFinanceBatches.DeleteAllOnSubmit(selectedCase.InvoiceFinanceBatches);
                context.InvoicePaymentBatches.DeleteAllOnSubmit(selectedCase.InvoicePaymentBatches);
                context.InvoiceRefundBatches.DeleteAllOnSubmit(selectedCase.InvoiceRefundBatches);

                context.CDAs.DeleteAllOnSubmit(selectedCase.CDAs);
                context.Cases.DeleteOnSubmit(selectedCase);
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isDeleteOK = false;
                    MessageBoxEx.Show("不能删除此案件: " + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isDeleteOK)
                {
                    MessageBoxEx.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCases.Rows.RemoveAt(dgvCases.CurrentCell.RowIndex);
                }
            }
        }

        /// <summary>
        /// Show detail info of selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCases_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvCases.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCases.RowHeadersDefaultCellStyle.Font, rectangle, dgvCases.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewCase(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            CaseDetail caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCreditCoverNeg(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                return;
            }

            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCreditCoverNegType.NEW_CREDIT_COVER_NEG);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            DateTime beginDate = this.diBegin.Text != string.Empty ? this.diBegin.Value : this.diBegin.MinDate;
            DateTime endDate = this.diEnd.Text != string.Empty ? this.diEnd.Value : this.diEnd.MinDate;
            string opName = this.tbOPName.Text;
            string location = this.cbLocation.Text;

            context = new DBDataContext();

            var queryResult = context.Cases.Where(c =>
                                   ((string)this.cbOwnerDepts.SelectedValue == "CN01300" ? true : c.OwnerDepartmentCode.Equals((string)this.cbOwnerDepts.SelectedValue))
                                && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType == this.cbTransactionType.Text)
                                && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency == (string)this.cbCurrency.SelectedValue)
                                && (location == "全部" ? true : c.OwnerDepartment.Location == location)
                                && c.CaseCode.Contains(this.tbCaseCode.Text)
                                && (c.CaseMark.Contains(this.cbCaseMark.Text))
                                && (c.OPName == null ? true : c.OPName.Contains(opName))
                                && (opCaseType != OpCaseType.STAT && beginDate != this.diBegin.MinDate ? c.CaseAppDate >= beginDate : true)
                                && (opCaseType != OpCaseType.STAT && endDate != this.diEnd.MinDate ? c.CaseAppDate <= endDate : true)
                                && (this.cbIsCDA.Checked == false ? true : c.CDAs.Any(cda => cda.IsSigned == true))
                                && (this.cbIsContractSigned.Checked == false ? true : c.SellerClient.Contracts.Any(con => con.ContractStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY))
                                && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN.Contains(this.tbClientName.Text)
                                 || c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN.Contains(this.tbClientName.Text))
                                    );

            if (opCaseType == OpCaseType.STAT)
            {
                foreach (Case c in queryResult)
                {
                    c.QueryDateFrom = beginDate;
                    c.QueryDateTo = endDate;
                }
            }

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseGroup"></param>
        private void ReportLegarImpl(IGrouping<Client, Case> caseGroup)
        {
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Workbook workbook = app.Workbooks.Add(true);

                Client client = caseGroup.Key;
                foreach (Case selectedCase in caseGroup)
                {
                    CDA cda = selectedCase.ActiveCDA;

                    if (cda == null)
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

                        MessageBoxEx.Show("案件没有有效的额度通知书，案件编号：" + selectedCase.CaseCode);

                        return;
                    }

                    Worksheet sheet = (Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                    string name = selectedCase.TargetClient.ToString();
                    if (name.Length > 30)
                    {
                        name = name.Substring(0, 30);
                    }

                    sheet.Name = name;

                    sheet.get_Range("A1", "Q1").MergeCells = true;
                    sheet.get_Range("A1", "A1").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, "A"] = "销售分户账台账";
                    sheet.Cells[2, "P"] = String.Format("单位：{0}", selectedCase.InvoiceCurrency);
                    sheet.Cells[3, "A"] = "分行/分部";
                    sheet.Cells[3, "B"] = selectedCase.OwnerDepartment.DepartmentName;

                    sheet.Cells[4, "A"] = "Seller Name";
                    sheet.get_Range("B4", "F4").MergeCells = true;
                    sheet.Cells[4, "B"] = selectedCase.SellerClient.ToString();
                    sheet.Cells[5, "A"] = "Buyer Name";
                    sheet.get_Range("B5", "F5").MergeCells = true;
                    sheet.Cells[5, "B"] = selectedCase.BuyerClient.ToString();

                    sheet.get_Range("B6", "F6").MergeCells = true;
                    if (selectedCase.TransactionType == "进口保理")
                    {
                        sheet.Cells[6, "A"] = "Export Factor";
                        sheet.Cells[6, "B"] = selectedCase.SellerFactor.ToString();
                    }
                    else
                    {
                        sheet.Cells[6, "A"] = "Import Factor";
                        sheet.Cells[6, "B"] = selectedCase.BuyerFactor.ToString();
                    }

                    sheet.get_Range("B7", "F7").MergeCells = true;
                    sheet.Cells[7, "A"] = "协查意见书编号";
                    List<ClientReview> reviewList = selectedCase.ClientReviews;
                    if (reviewList != null)
                    {
                        String reviews = string.Empty;
                        foreach (ClientReview review in reviewList)
                        {
                            reviews += review.ReviewNo + ";";
                        }

                        sheet.Cells[7, "B"] = reviews;
                    }

                    sheet.Cells[4, "G"] = "总手续费率";
                    sheet.get_Range(sheet.Cells[4, "H"], sheet.Cells[4, "I"]).MergeCells = true;
                    if (cda != null)
                    {
                        sheet.Cells[4, "H"] = String.Format("{0:P}", cda.Price);
                    }

                    sheet.get_Range(sheet.Cells[5, "H"], sheet.Cells[5, "I"]).MergeCells = true;
                    if (selectedCase.TransactionType == "进口保理")
                    {
                        sheet.Cells[5, "G"] = "EF手续费率";
                        if (cda != null)
                        {
                            sheet.Cells[5, "H"] = String.Format("{0:P}", cda.EFPrice);
                        }
                    }
                    else
                    {
                        sheet.Cells[5, "G"] = "IF手续费率";
                        if (cda != null)
                        {
                            sheet.Cells[5, "H"] = String.Format("{0:P}", cda.IFPrice);
                        }
                    }

                    sheet.Cells[6, "G"] = "利率";
                    sheet.get_Range(sheet.Cells[6, "H"], sheet.Cells[6, "I"]).MergeCells = true;

                    sheet.Cells[7, "G"] = "单据处理费/笔";
                    sheet.get_Range(sheet.Cells[7, "H"], sheet.Cells[7, "I"]).MergeCells = true;
                    sheet.Cells[7, "H"] = String.Format("{0} {1:N2}", cda.HandFeeCurr, cda.HandFee);

                    sheet.get_Range(sheet.Cells[4, "L"], sheet.Cells[4, "M"]).MergeCells = true;
                    sheet.Cells[4, "L"] = "信用风险担保";
                    sheet.Cells[5, "L"] = "核准额度";
                    sheet.Cells[5, "M"] = String.Format("{0} {1:N2}", cda.CreditCoverCurr, cda.CreditCover);
                    sheet.Cells[6, "L"] = "到期日";
                    sheet.Cells[6, "M"] = String.Format("{0:yyyy-MM-dd}", cda.CreditCoverPeriodEnd);
                    sheet.Cells[7, "L"] = "剩余额度";
                    sheet.Cells[7, "M"] = String.Format("{0} {1:N2}", cda.CreditCoverCurr, cda.CreditCoverOutstanding);
                    sheet.Cells[8, "L"] = "应收帐款余额";
                    sheet.Cells[8, "M"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, selectedCase.AssignOutstanding);

                    sheet.get_Range(sheet.Cells[4, "O"], sheet.Cells[4, "P"]).MergeCells = true;
                    sheet.Cells[4, "O"] = "融资额度";
                    sheet.Cells[5, "O"] = "核准额度";
                    sheet.Cells[5, "P"] = String.Format("{0} {1:N2}", cda.FinanceLineCurr, cda.FinanceLine);
                    sheet.Cells[6, "O"] = "到期日";
                    sheet.Cells[6, "P"] = String.Format("{0:yyyy-MM-dd}", cda.FinanceLinePeriodEnd);
                    sheet.Cells[7, "O"] = "剩余额度";
                    sheet.Cells[7, "P"] = String.Format("{0} {1:N2}", cda.FinanceLineCurr, cda.FinanceLineOutstanding);
                    sheet.Cells[8, "O"] = "融资余额";
                    sheet.Cells[8, "P"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, selectedCase.FinanceOutstanding);

                    sheet.Cells[9, "A"] = "发票号";
                    sheet.Cells[9, "B"] = "转让金额";
                    sheet.Cells[9, "C"] = "发票日";
                    sheet.Cells[9, "D"] = "到期日";
                    sheet.Cells[9, "E"] = "转让日";
                    sheet.Cells[9, "F"] = "是否瑕疵";
                    sheet.Cells[9, "G"] = "融资金额";
                    sheet.Cells[9, "H"] = "融资日";
                    sheet.Cells[9, "I"] = "融资到期日";
                    sheet.Cells[9, "J"] = "付款金额";
                    sheet.Cells[9, "K"] = "账款余额";
                    sheet.Cells[9, "L"] = "付款日";
                    sheet.Cells[9, "M"] = "还款金额";
                    sheet.Cells[9, "N"] = "还款日";
                    sheet.Cells[9, "O"] = "手续费";
                    sheet.Cells[9, "P"] = "利息";
                    sheet.Cells[9, "Q"] = "备注";

                    sheet.get_Range("A4", "I7").Borders.LineStyle = 1;
                    sheet.get_Range("L4", "M8").Borders.LineStyle = 1;
                    sheet.get_Range("O4", "P8").Borders.LineStyle = 1;

                    int row = 10;
                    foreach (InvoiceAssignBatch batch in selectedCase.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in batch.Invoices)
                        {
                            int step = 1;
                            sheet.Cells[row, "A"] = "'" + invoice.InvoiceNo;
                            sheet.Cells[row, "B"] = invoice.AssignAmount;
                            sheet.Cells[row, "C"] = invoice.InvoiceDate;
                            sheet.Cells[row, "D"] = invoice.DueDate;
                            sheet.Cells[row, "E"] = batch.AssignDate;
                            sheet.Cells[row, "F"] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);

                            int recordStep = 0;
                            for (int i = 0; i < invoice.InvoiceFinanceLogs.Count; i++)
                            {
                                InvoiceFinanceLog financeLog = invoice.InvoiceFinanceLogs[i];
                                sheet.Cells[row + recordStep, "G"] = financeLog.FinanceAmount;
                                sheet.Cells[row + recordStep, "H"] = financeLog.FinanceDate;
                                sheet.Cells[row + recordStep, "I"] = financeLog.FinanceDueDate;

                                for (int j = 0; i < financeLog.InvoiceRefundLogs.Count; i++)
                                {
                                    InvoiceRefundLog refundLog = financeLog.InvoiceRefundLogs[j];
                                    sheet.Cells[row + recordStep + j, "M"] = refundLog.RefundAmount;
                                    sheet.Cells[row + recordStep + j, "N"] = refundLog.RefundDate;
                                }

                                recordStep += financeLog.InvoiceRefundLogs.Count;
                            }

                            step = step < recordStep ? recordStep : step;

                            //sheet.Cells[row, "G"] = invoice.FinanceAmount;
                            //sheet.Cells[row, "H"] = invoice.FinanceDate;
                            //sheet.Cells[row, "I"] = invoice.FinanceDueDate;

                            for (int i = 0; i < invoice.InvoicePaymentLogs.Count; i++)
                            {
                                InvoicePaymentLog paymentLog = invoice.InvoicePaymentLogs[i];
                                sheet.Cells[row + i, "J"] = paymentLog.PaymentAmount;
                                sheet.Cells[row + i, "L"] = paymentLog.PaymentDate;
                            }

                            step = step < invoice.InvoicePaymentLogs.Count ? invoice.InvoicePaymentLogs.Count : step;

                            //sheet.Cells[row, "J"] = invoice.PaymentAmount;
                            sheet.Cells[row, "K"] = invoice.AssignOutstanding;
                            //sheet.Cells[row, "L"] = invoice.PaymentDate;

                            //sheet.Cells[row, "M"] = invoice.RefundAmount;
                            //sheet.Cells[row, "N"] = invoice.RefundDate;
                            sheet.Cells[row, "O"] = invoice.Commission;
                            sheet.Cells[row, "P"] = invoice.NetInterest;
                            sheet.Cells[row, "Q"] = invoice.Comment;

                            row += step;
                        }
                    }

                    string currencyFormat = TypeUtil.GetExcelCurr(selectedCase.InvoiceCurrency);
                    sheet.get_Range(sheet.Cells[9, "A"], sheet.Cells[row - 1, "Q"]).Borders.LineStyle = 1;
                    sheet.get_Range(sheet.Cells[10, "B"], sheet.Cells[row - 1, "B"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "C"], sheet.Cells[row - 1, "C"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "D"], sheet.Cells[row - 1, "D"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "E"], sheet.Cells[row - 1, "E"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "G"], sheet.Cells[row - 1, "G"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "H"], sheet.Cells[row - 1, "H"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "I"], sheet.Cells[row - 1, "I"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "J"], sheet.Cells[row - 1, "J"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "K"], sheet.Cells[row - 1, "K"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "L"], sheet.Cells[row - 1, "L"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "M"], sheet.Cells[row - 1, "M"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "N"], sheet.Cells[row - 1, "N"]).NumberFormatLocal = "yyyy-MM-dd";
                    sheet.get_Range(sheet.Cells[10, "O"], sheet.Cells[row - 1, "O"]).NumberFormatLocal = currencyFormat;
                    sheet.get_Range(sheet.Cells[10, "P"], sheet.Cells[row - 1, "P"]).NumberFormatLocal = currencyFormat;

                    foreach (Range range in sheet.UsedRange.Rows)
                    {
                        range.EntireRow.AutoFit();
                    }

                    foreach (Range range in sheet.UsedRange.Columns)
                    {
                        range.EntireColumn.AutoFit();
                    }

                    sheet.UsedRange.Font.Name = "仿宋";
                }
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

                MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (app != null)
            {
                app.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportLeger(object sender, EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            List<Case> selectedCases = this.GetSelectedCases();
            IEnumerable<IGrouping<string, Case>> caseGroups = selectedCases.GroupBy(c => c.TransactionType);

            IEnumerable<IGrouping<Client, Case>> groups = null;
            foreach (IGrouping<string, Case> caseGroup in caseGroups)
            {
                string transactionType = caseGroup.Key;
                switch (transactionType)
                {
                    case "国内卖方保理":
                    case "出口保理":
                    case "国内信保保理":
                    case "国际信保保理":
                    case "租赁保理":
                        groups = caseGroup.GroupBy(c => c.SellerClient);
                        foreach (IGrouping<Client, Case> group in groups)
                        {
                            ReportLegarImpl(group);
                        }

                        break;
                    case "国内买方保理":
                    case "进口保理":
                        groups = caseGroup.GroupBy(c => c.BuyerClient);
                        foreach (IGrouping<Client, Case> group in groups)
                        {
                            ReportLegarImpl(group);
                        }

                        break;
                    default:
                        break;
                }

            }



        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            this.cbOwnerDepts.SelectedIndex = 0;
            this.cbTransactionType.SelectedIndex = 0;
            this.cbCurrency.SelectedIndex = 0;
            this.tbCaseCode.Text = string.Empty;
            this.tbClientName.Text = string.Empty;
            this.diBegin.Value = default(DateTime);
            this.diEnd.Value = default(DateTime);
            this.cbIsContractSigned.Checked = true;
            this.cbIsCDA.Checked = true;
            this.tbOPName.Text = string.Empty;
        }

        /// <summary>
        /// Select case and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            this.Selected = selectedCase;
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
            if (PermUtil.ValidatePermission(Permission.CASE_UPDATE))
            {
                this.menuItemCaseNew.Enabled = true;
                this.menuItemCaseDelete.Enabled = true;
                this.menuItemCreditCoverNegNew.Enabled = true;
            }
            else
            {
                this.menuItemCaseNew.Enabled = false;
                this.menuItemCaseDelete.Enabled = false;
                this.menuItemCreditCoverNegNew.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Case> GetSelectedCases()
        {
            List<Case> selectedCases = new List<Case>();
            foreach (DataGridViewCell cell in this.dgvCases.SelectedCells)
            {
                Case selectedCase = (Case)this.bs.List[cell.RowIndex];
                if (!selectedCases.Contains(selectedCase))
                {
                    selectedCases.Add(selectedCase);
                }
            }

            return selectedCases;
        }

        #endregion Methods
    }
}
