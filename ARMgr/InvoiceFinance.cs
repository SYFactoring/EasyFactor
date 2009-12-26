//-----------------------------------------------------------------------
// <copyright file="InvoiceFinance.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFinance : UserControl
    {
        #region Fields (1)

        private OpFinanceType opFinanceType;

        #endregion Fields

        #region Enums (1)

        public enum OpFinanceType
        {
            NEW_FINANCE,
            UPDATE_FINANCE
        }

        #endregion Enums

        #region Constructors (1)

        public InvoiceFinance()
        {
            InitializeComponent();
            this.dgvInvoices.AutoGenerateColumns = false;
        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        public CDA CDA
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (8)

        // Public Methods (1) 

        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelFinanceBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.invoiceBindingSource.DataSource = typeof(Invoice);
            this.invoiceFinanceBatchBindingSource.DataSource = typeof(InvoiceFinanceBatch);
        }
        // Private Methods (7) 

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            string ino = (string)dgvInvoices["InvoiceNoColumn", dgvInvoices.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                Invoice selectedInvoice = ((InvoiceAssignBatch)this.invoiceFinanceBatchBindingSource.DataSource).Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
                if (selectedInvoice != null)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
                    invoiceDetail.ShowDialog(this);
                }
            }
        }

        private string GenerateFinanceBatchNo(CDA cda)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinanceBatch(object sender, EventArgs e)
        {
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
            if (financeBatch == null || financeBatch.FinanceBatchNo == null)
            {
                MessageBox.Show("请首先创建新批次", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                string fileName = fileDialog.FileName;
                ApplicationClass app = new ApplicationClass() { Visible = false };
                WorkbookClass workbook = (WorkbookClass)app.Workbooks.Open(
                   fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                   Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                   Type.Missing, Type.Missing, Type.Missing);
                if (workbook.Sheets.Count < 1)
                {
                    MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    workbook.Close(false, fileName, null);
                    Marshal.ReleaseComObject(workbook);
                    return;
                }

                Worksheet datasheet = (Worksheet)workbook.Sheets[1];

                Range range = datasheet.UsedRange;
                object[,] valueArray = (object[,])range.get_Value(XlRangeValueDataType.xlRangeValueDefault);
                if (valueArray != null)
                {

                    for (int row = 3; row < range.Rows.Count; row++)
                    {

                        Invoice invoice = null;
                        string invoiceNo = String.Format("{0:G}", valueArray[row, 12]);
                        invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                        if (invoice == null)
                        {
                            invoice = new Invoice();
                            invoice.InvoiceNo = invoiceNo;
                        }
                        try
                        {
                            int column = 13;
                            invoice.FinanceAmount = (double)valueArray[row, column++];
                            invoice.FinanceDate = (DateTime)valueArray[row, column++];
                            invoice.FinanceDueDate = (DateTime)valueArray[row, column++];
                            invoice.Comment = String.Format("{0:G}", valueArray[row, column++]);

                            invoice.InvoiceFinanceBatch = financeBatch;

                            App.Current.DbContext.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            DialogResult dr = MessageBox.Show("导入失败: " + e1.Message + "\t" + invoice.InvoiceNo + "\n" + "是否继续导入？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.No)
                            {
                                break;
                            }
                        }
                    }
                    MessageBox.Show("导入结束", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                workbook.Close(false, fileName, null);
                Marshal.ReleaseComObject(workbook);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFinanceBatchByCDA(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FINANCE);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFinanceBatch(object sender, EventArgs e)
        {
            if (this.CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InvoiceFinanceBatch financeBatch = new InvoiceFinanceBatch();
            financeBatch.FinanceBatchNo = GenerateFinanceBatchNo(this.CDA);
            financeBatch.FinancePeriodBegin = DateTime.Now;
            financeBatch.CreateUserName = App.Current.CurUser.Name;
            financeBatch.CDA = this.CDA;
            financeBatch.BatchCurrency = "CNY";

            this.invoiceFinanceBatchBindingSource.DataSource = financeBatch;
            this.invoiceBindingSource.DataSource = financeBatch.Invoices;
            this.opFinanceType = OpFinanceType.NEW_FINANCE;
        }

        private void SaveFinanceBatch(object sender, EventArgs e)
        {
            if (this.financeBatchNoTextBox.Text == string.Empty)
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceFinanceBatch financeBatch = (InvoiceFinanceBatch)this.invoiceFinanceBatchBindingSource.DataSource;
            try
            {
                if (opFinanceType == OpFinanceType.NEW_FINANCE)
                {
                    App.Current.DbContext.InvoiceFinanceBatches.InsertOnSubmit(financeBatch);
                }
                App.Current.DbContext.SubmitChanges();
            }
            catch (Exception e1)
            {
                isSaveOK = false;
                MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (isSaveOK)
            {
                MessageBox.Show("数据保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                opFinanceType = OpFinanceType.UPDATE_FINANCE;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFinanceBatch(object sender, EventArgs e)
        {
            FinanceBatchMgr financeBatchMgr = new FinanceBatchMgr(this.CDA);
            QueryForm queryUI = new QueryForm(financeBatchMgr, "选择融资批次");
            financeBatchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceFinanceBatch financeBatch = financeBatchMgr.Selected;
            if (financeBatch != null)
            {
                this.invoiceFinanceBatchBindingSource.DataSource = financeBatch;
                this.invoiceBindingSource.DataSource = financeBatch.Invoices;
                this.opFinanceType = OpFinanceType.UPDATE_FINANCE;
            }
        }

        #endregion Methods
    }
}
