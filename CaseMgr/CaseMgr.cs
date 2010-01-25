//-----------------------------------------------------------------------
// <copyright file="CaseMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar.Controls;
    using System.Drawing;
    using Microsoft.Office.Interop.Excel;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    public partial class CaseMgr : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        /// <param name="isContract"></param>
        public CaseMgr(bool isContract)
            : this()
        {
            this.cbIsContractSigned.Checked = isContract;
            this.QueryCase(null, null);
        }

        /// <summary>
        /// Initializes a new instance of the CaseMgr class
        /// </summary>
        public CaseMgr()
        {
            this.InitializeComponent();
            this.dgvCases.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvCases.DataSource = this.bs;
            ControlUtil.SetDoubleBuffered(this.dgvCases);

            List<string> transTypes = Case.ConstantTransTypes().ToList();
            transTypes.Insert(0, "全部");
            this.cbTransactionType.DataSource = transTypes;

            List<Department> deptsList = Department.AllDepartments().ToList();
            deptsList.Insert(0, new Department() { DepartmentCode = "CN01300", DepartmentName = "全部" });
            this.cbOwnerDepts.DataSource = deptsList;
            this.cbOwnerDepts.DisplayMembers = "DepartmentName";
            this.cbOwnerDepts.ValueMember = "DepartmentCode";
            this.cbOwnerDepts.GroupingMembers = "Domain";

            List<Currency> currencyList = Currency.AllCurrencies().ToList();
            currencyList.Insert(0, new Currency() { CurrencyCode = "AAA", CurrencyName = "All" });
            this.cbCurrency.DataSource = currencyList;
            this.cbCurrency.DisplayMember = "CurrencyFormat";
            this.cbCurrency.ValueMember = "CurrencyCode";

            this.cbCaseMark.Text = "启动案";
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
        /// Gets or sets selected Case
        /// </summary>
        public Case Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (10)

        // Private Methods (10) 

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
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            if (MessageBox.Show("此案件是" + selectedCase.CaseMark + "，是否确定删除", ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bool isDeleteOK = true;
                foreach (CDA cda in selectedCase.CDAs)
                {
                    foreach (InvoiceAssignBatch assignBatch in cda.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in assignBatch.Invoices)
                        {
                            App.Current.DbContext.InvoicePaymentLogs.DeleteAllOnSubmit(invoice.InvoicePaymentLogs);
                            App.Current.DbContext.InvoiceRefundLogs.DeleteAllOnSubmit(invoice.InvoiceRefundLogs);
                        }
                        App.Current.DbContext.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
                    }
                    App.Current.DbContext.InvoiceAssignBatches.DeleteAllOnSubmit(cda.InvoiceAssignBatches);
                    App.Current.DbContext.InvoiceFinanceBatches.DeleteAllOnSubmit(cda.InvoiceFinanceBatches);
                    App.Current.DbContext.InvoicePaymentBatches.DeleteAllOnSubmit(cda.InvoicePaymentBatches);
                    App.Current.DbContext.InvoiceRefundBatches.DeleteAllOnSubmit(cda.InvoiceRefundBatches);
                }
                App.Current.DbContext.CDAs.DeleteAllOnSubmit(selectedCase.CDAs);
                App.Current.DbContext.Cases.DeleteOnSubmit(selectedCase);
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isDeleteOK = false;
                    MessageBox.Show("不能删除此案件: " + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isDeleteOK)
                {
                    MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            CaseDetail caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
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

            var queryResult = App.Current.DbContext.Cases.Where(c =>
                                   ((string)this.cbOwnerDepts.SelectedValue == "CN01300" ? true : c.OwnerDepartmentCode.Equals((string)this.cbOwnerDepts.SelectedValue))
                                && (this.cbTransactionType.Text == "全部" ? true : c.TransactionType.Equals(this.cbTransactionType.Text))
                                && ((string)this.cbCurrency.SelectedValue == "AAA" ? true : c.InvoiceCurrency.Equals((string)this.cbCurrency.SelectedValue))
                                && (beginDate != this.diBegin.MinDate ? c.CaseAppDate >= beginDate : true)
                                && (endDate != this.diEnd.MinDate ? c.CaseAppDate <= endDate : true)
                                && c.CaseCode.Contains(this.tbCaseCode.Text)
                                && (c.CaseMark == this.cbCaseMark.Text)
                                && (this.cbIsCDA.Checked == false ? true : c.CDAs.Any(cda => cda.CDAStatus == "已签回"))
                                && (this.cbIsContractSigned.Checked == false ? true : c.SellerClient.Contracts.Any(con => con.ContractStatus == ConstStr.CLIENT_CREDIT_LINE.AVAILABILITY))
                                && (c.BuyerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.BuyerClient.ClientNameEN.Contains(this.tbClientName.Text)
                                 || c.SellerClient.ClientNameCN.Contains(this.tbClientName.Text) || c.SellerClient.ClientNameEN.Contains(this.tbClientName.Text))
                                    );

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            CDA cda = selectedCase.ActiveCDA;
            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];
            try
            {

                sheet.get_Range(sheet.Cells[1, "A"], sheet.Cells[1, "R"]).MergeCells = true;
                sheet.get_Range(sheet.Cells[1, "A"], sheet.Cells[1, "A"]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[1, "A"] = "销售分户账台账";
                sheet.Cells[2, "Q"] = String.Format("单位：{0}", selectedCase.InvoiceCurrency);
                sheet.Cells[3, "A"] = "分行/分部";
                sheet.Cells[3, "B"] = selectedCase.OwnerDepartment.DepartmentName;

                sheet.Cells[4, "A"] = "Seller Name";
                sheet.get_Range(sheet.Cells[4, "B"], sheet.Cells[4, "F"]).MergeCells = true;
                sheet.Cells[4, "B"] = selectedCase.SellerClient.ToString();
                sheet.Cells[5, "A"] = "Buyer Name";
                sheet.get_Range(sheet.Cells[5, "B"], sheet.Cells[5, "F"]).MergeCells = true;
                sheet.Cells[5, "B"] = selectedCase.BuyerClient.ToString();

                sheet.get_Range(sheet.Cells[6, "B"], sheet.Cells[6, "F"]).MergeCells = true;
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

                sheet.get_Range(sheet.Cells[4, "M"], sheet.Cells[4, "N"]).MergeCells = true;
                sheet.Cells[4, "M"] = "信用风险担保";
                sheet.Cells[5, "M"] = "核准额度";
                sheet.Cells[5, "N"] = String.Format("{0} {1:N2}", cda.CreditCoverCurr, cda.CreditCover);
                sheet.Cells[6, "M"] = "到期日";
                if (cda.CreditCoverPeriodEnd != null)
                {
                    sheet.Cells[6, "N"] = String.Format("{0:yyyy/MM/dd}", cda.CreditCoverPeriodEnd);
                }
                sheet.Cells[7, "M"] = "剩余额度";
                sheet.Cells[7, "N"] = String.Format("{0} {1:N2}", cda.CreditCoverCurr, cda.CreditCoverOutstanding);
                sheet.Cells[8, "M"] = "应收帐款余额";
                sheet.Cells[8, "N"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, selectedCase.AssignOutstanding);

                sheet.get_Range(sheet.Cells[4, "P"], sheet.Cells[4, "Q"]).MergeCells = true;
                sheet.Cells[4, "P"] = "融资额度";
                sheet.Cells[5, "P"] = "核准额度";
                sheet.Cells[5, "Q"] = String.Format("{0} {1:N2}", cda.FinanceLineCurr, cda.FinanceLine);
                sheet.Cells[6, "P"] = "到期日";
                if (cda.FinanceLinePeriodEnd != null)
                {
                    sheet.Cells[6, "Q"] = String.Format("{0:yyyy/MM/dd}", cda.FinanceLinePeriodEnd);
                }
                sheet.Cells[7, "P"] = "剩余额度";
                sheet.Cells[7, "Q"] = String.Format("{0} {1:N2}", cda.FinanceLineCurr, cda.FinanceLineOutstanding);
                sheet.Cells[8, "P"] = "融资余额";
                sheet.Cells[8, "Q"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, selectedCase.FinanceOutstanding);

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
                sheet.Cells[9, "P"] = "收费日";
                sheet.Cells[9, "Q"] = "利息";
                sheet.Cells[9, "R"] = "备注";

                int row = 10;
                foreach (CDA c in selectedCase.CDAs)
                {
                    foreach (InvoiceAssignBatch batch in c.InvoiceAssignBatches)
                    {
                        foreach (Invoice invoice in batch.Invoices)
                        {
                            sheet.Cells[row, "A"] = "'" + invoice.InvoiceNo;
                            sheet.Cells[row, "B"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, invoice.AssignAmount);
                            sheet.Cells[row, "C"] = String.Format("{0:yyyy/MM/dd}", invoice.InvoiceDate);
                            sheet.Cells[row, "D"] = String.Format("{0:yyyy/MM/dd}", invoice.DueDate);
                            sheet.Cells[row, "E"] = String.Format("{0:yyyy/MM/dd}", batch.AssignDate);
                            sheet.Cells[row, "F"] = TypeUtil.ConvertBoolToStr(invoice.IsFlaw);
                            sheet.Cells[row, "G"] = String.Format("{0} {1:N2}", invoice.FinanceCurrency, invoice.FinanceAmount);
                            sheet.Cells[row, "H"] = String.Format("{0:yyyy/MM/dd}", invoice.FinanceDate);
                            sheet.Cells[row, "I"] = String.Format("{0:yyyy/MM/dd}", invoice.FinanceDueDate);
                            sheet.Cells[row, "J"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, invoice.PaymentAmount);
                            sheet.Cells[row, "K"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, invoice.AssignOutstanding);
                            sheet.Cells[row, "L"] = String.Format("{0:yyyy/MM/dd}", invoice.PaymentDate);
                            sheet.Cells[row, "M"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, invoice.RefundAmount);
                            sheet.Cells[row, "N"] = String.Format("{0:yyyy/MM/dd}", invoice.RefundDate);
                            sheet.Cells[row, "O"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, invoice.Commission);
                            sheet.Cells[row, "P"] = String.Format("{0:yyyy/MM/dd}", invoice.CommissionDate);
                            sheet.Cells[row, "Q"] = String.Format("{0} {1:N2}", selectedCase.InvoiceCurrency, invoice.Interest);
                            sheet.Cells[row, "R"] = invoice.Comment;
                            row++;
                        }
                    }
                }

                sheet.get_Range(sheet.Cells[9, "A"], sheet.Cells[row - 1, "R"]).Borders.LineStyle = 1;

                foreach (Range range in sheet.UsedRange.Rows)
                {
                    range.EntireRow.AutoFit();
                }

                foreach (Range range in sheet.UsedRange.Columns)
                {
                    range.EntireColumn.AutoFit();
                }

                sheet.UsedRange.Font.Name = "仿宋";

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
                throw e1;
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
        /// Update selected case
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateCase(object sender, System.EventArgs e)
        {
            if (this.dgvCases.CurrentCell == null)
            {
                return;
            }

            Case selectedCase = (Case)this.bs.List[this.dgvCases.CurrentCell.RowIndex];
            CaseDetail caseDetail = new CaseDetail(selectedCase, CaseDetail.OpCaseType.UPDATE_CASE);
            caseDetail.ShowDialog(this);
        }

        #endregion Methods
    }
}
