
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using Microsoft.Office.Interop.Excel;
    using System.Reflection;
    using System.Data;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssign : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private OpAssignType opAssignType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpAssignType
        {
            NEW_ASSIGN,
            UPDATE_ASSIGN
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        public InvoiceAssign()
        {
            this.InitializeComponent();

            this.dataGridViewTextBoxColumn3.DataSource = Currency.AllCurrencies().ToList();
            this.dataGridViewTextBoxColumn3.DisplayMember = "CurrencyCode";
            this.dataGridViewTextBoxColumn3.ValueMember = "CurrencyCode";
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

        #region Methods (6)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in this.panelAssignBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            this.invoiceBindingSource.DataSource = typeof(Invoice);
            this.invoiceAssignBatchBindingSource.DataSource = typeof(InvoiceAssignBatch);
        }
        // Private Methods (5) 

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
                Invoice selectedInvoice = ((InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource).Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
                if (selectedInvoice != null)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
                    invoiceDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Flaw(object sender, System.EventArgs e)
        {
            if (this.dgvInvoices.SelectedRows.Count == 0)
            {
                return;
            }

            string ino = (string)dgvInvoices["InvoiceNoColumn", dgvInvoices.SelectedRows[0].Index].Value;
            if (ino != null)
            {
                Invoice selectedInvoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == ino);
                if (selectedInvoice != null)
                {
                    InvoiceDetail invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.FLAW);
                    invoiceDetail.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewAssignBatch(object sender, EventArgs e)
        {
            if (this.CDA == null)
            {
                MessageBox.Show("没有有效的额度通知书", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InvoiceAssignBatch assignBatch = new InvoiceAssignBatch();
            assignBatch.AssignBatchNo = GenerateAssignBatchNo(this.CDA);
            assignBatch.BatchDate = DateTime.Now;
            assignBatch.CreateUserName = App.Current.CurUser.Name;
            assignBatch.IsCreateMsg = false;
            assignBatch.CDA = this.CDA;
            this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
            this.invoiceBindingSource.DataSource = assignBatch.Invoices;
            this.opAssignType = OpAssignType.NEW_ASSIGN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <returns></returns>
        private string GenerateAssignBatchNo(CDA cda)
        {
            Client seller = cda.Case.SellerClient;
            Client buyer = cda.Case.BuyerClient;
            string date = String.Format("{0:yyyy}{0:MM}{0:dd}", DateTime.Today);
            int batchCount = cda.InvoiceAssignBatches.Count;
            string assignNo = seller.ClientEDICode.Substring(0, 5) + buyer.ClientEDICode.Substring(3, 2) + date + "-" + String.Format("{0:D2}", batchCount + 1);
            return assignNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAssignBatch(object sender, EventArgs e)
        {
            if (this.assignBatchNoTextBox.Text == string.Empty)
            {
                return;
            }

            bool isSaveOK = true;
            InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
            try
            {
                if (opAssignType == OpAssignType.NEW_ASSIGN)
                {
                    App.Current.DbContext.InvoiceAssignBatches.InsertOnSubmit(assignBatch);
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
                opAssignType = OpAssignType.UPDATE_ASSIGN;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAssignBatch(object sender, EventArgs e)
        {
            AssignBatchMgr assignBatchMgr = new AssignBatchMgr(this.CDA);
            QueryForm queryUI = new QueryForm(assignBatchMgr, "选择转让批次");
            assignBatchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceAssignBatch assignBatch = assignBatchMgr.Selected;
            if (assignBatch != null)
            {
                this.invoiceAssignBatchBindingSource.DataSource = assignBatch;
                this.invoiceBindingSource.DataSource = assignBatch.Invoices;
                this.opAssignType = OpAssignType.UPDATE_ASSIGN;
            }
        }

        #endregion Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportAssignBatch(object sender, EventArgs e)
        {
            InvoiceAssignBatch assignBatch = (InvoiceAssignBatch)this.invoiceAssignBatchBindingSource.DataSource;
            if (assignBatch == null || assignBatch.AssignBatchNo == null)
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
                        string invoiceNo = String.Format("{0:G}", valueArray[row, 5]);
                        invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                        if (invoice == null)
                        {
                            invoice = new Invoice();
                            invoice.InvoiceNo = invoiceNo;
                        }
                        try
                        {
                            int column = 6;
                            invoice.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                            invoice.InvoiceAmount = (double)valueArray[row, column++];
                            invoice.AssignAmount = (double)valueArray[row, column++];
                            invoice.InvoiceDate = (DateTime)valueArray[row, column++];
                            invoice.DueDate = (DateTime)valueArray[row, column++];
                            invoice.AssignDate = (DateTime)valueArray[row, column++];
                            invoice.IsFlaw = "Y".Equals(valueArray[row, column++]);
                            invoice.FlawReason = String.Format("{0:G}", valueArray[row, column++]);
                            invoice.Comment = String.Format("{0:G}", valueArray[row, 23]);

                            invoice.InvoiceAssignBatch = assignBatch;

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
        private void ImportAssignBatchByCDA(object sender, EventArgs e)
        {
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
                    string lastCDACode = string.Empty;
                    string lastAssignBatchNo = string.Empty;
                    CDA cda = null;
                    InvoiceAssignBatch assignBatch = null;

                    for (int row = 3; row < range.Rows.Count; row++)
                    {
                        string cdaCode = String.Format("{0:G}", valueArray[row, 1]);
                        if (string.Empty.Equals(cdaCode))
                        {
                            continue;
                        }
                        if (!lastCDACode.Equals(cdaCode))
                        {
                            cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                            lastCDACode = cdaCode;
                        }
                        if (cda == null)
                        {
                            continue;
                        }
                        string assignBatchNo = String.Format("{0:G}", valueArray[row, 2]);
                        if (string.Empty.Equals(assignBatchNo))
                        {
                            continue;
                        }
                        if (!lastAssignBatchNo.Equals(assignBatchNo))
                        {
                            assignBatch = App.Current.DbContext.InvoiceAssignBatches.SingleOrDefault(i => i.AssignBatchNo == assignBatchNo);
                            if (assignBatch == null)
                            {
                                assignBatch = new InvoiceAssignBatch();
                                assignBatch.AssignBatchNo = GenerateAssignBatchNo(cda);
                            }
                            assignBatch.CreateUserName = String.Format("{0:G}", valueArray[row, 3]);
                            assignBatch.BatchCurrency = String.Format("{0:G}", valueArray[row, 4]);
                            assignBatch.CDA = cda;
                            lastAssignBatchNo = assignBatchNo;
                        }

                        Invoice invoice = null;
                        string invoiceNo = String.Format("{0:G}", valueArray[row, 5]);
                        invoice = App.Current.DbContext.Invoices.SingleOrDefault(i => i.InvoiceNo == invoiceNo);
                        if (invoice == null)
                        {
                            invoice = new Invoice();
                            invoice.InvoiceNo = invoiceNo;
                        }
                        try
                        {
                            int column = 6;
                            invoice.InvoiceCurrency = String.Format("{0:G}", valueArray[row, column++]);
                            invoice.InvoiceAmount = (double)valueArray[row, column++];
                            invoice.AssignAmount = (double)valueArray[row, column++];
                            invoice.InvoiceDate = (DateTime)valueArray[row, column++];
                            invoice.DueDate = (DateTime)valueArray[row, column++];
                            invoice.AssignDate = (DateTime)valueArray[row, column++];
                            invoice.IsFlaw = "Y".Equals(valueArray[row, column++]);
                            invoice.FlawReason = String.Format("{0:G}", valueArray[row, column++]);
                            invoice.Comment = String.Format("{0:G}", valueArray[row, 23]);

                            invoice.InvoiceAssignBatch = assignBatch;

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
    }
}
