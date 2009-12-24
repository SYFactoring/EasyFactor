
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

            this.colInvoiceCurrency.DataSource = Currency.AllCurrencies().ToList();
            this.colInvoiceCurrency.DisplayMember = "CurrencyCode";
            this.colInvoiceCurrency.ValueMember = "CurrencyCode";
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

            Client seller = this.CDA.Case.SellerClient;
            Client buyer = this.CDA.Case.BuyerClient;
            string date = String.Format("{0:yyyy}{0:MM}{0:dd}", DateTime.Today);
            int batchCount = this.CDA.InvoiceAssignBatches.Count;
            string assignNo = seller.ClientEDICode.Substring(0, 5) + buyer.ClientEDICode.Substring(3, 2) + date + "-" + String.Format("{0:D2}", batchCount + 1);
            InvoiceAssignBatch assignBatch = new InvoiceAssignBatch();
            assignBatch.AssignBatchNo = assignNo;
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
                ApplicationClass app = new ApplicationClass { Visible = false };
                WorkbookClass w = (WorkbookClass)app.Workbooks.Open(
                   @fileName,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value,
                   Missing.Value);

                Sheets sheets = w.Worksheets;
                Worksheet datasheet = null;

                foreach (Worksheet sheet in sheets)
                {
                    if (datasheet == null)
                    {
                        datasheet = sheet;
                        break;
                    }
                }

                if (datasheet == null)
                {
                    MessageBox.Show("未找到指定的Sheet！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    app.Quit();
                    return;
                }

                Range range = datasheet.get_Range("A10", "R1000");
                Array values = (Array)range.Formula;
                if (values != null)
                {
                    int length = values.GetLength(0);
                    string title = values.GetValue(1, 1).ToString().Trim();
                    if (title.IndexOf("发票") == -1)
                    {
                        MessageBox.Show("文件格式错误，请检查", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        app.Quit();
                        return;
                    }

                    for (int row = 2; row <= length; row++)
                    {
                        if (!values.GetValue(row, 1).Equals(string.Empty))
                        {
                            Invoice invoice = new Invoice();
                            try
                            {
                                int column = 1;
                                invoice.InvoiceNo = values.GetValue(row, column++).ToString().Trim();
                                invoice.AssignAmount = Double.Parse(values.GetValue(row, column++).ToString().Trim());
                                object invoiceDate = values.GetValue(row, column++);
                                if (invoiceDate is double)
                                {
                                    invoice.InvoiceDate = DateTime.FromOADate((double)invoiceDate);
                                }
                                else
                                {
                                    invoice.InvoiceDate = DateTime.Parse((string)invoiceDate);
                                }
                                invoice.DueDate = DateTime.Parse(values.GetValue(row, column++).ToString().Trim());
                                invoice.AssignDate = DateTime.Parse(values.GetValue(row, column++).ToString().Trim());
                                invoice.IsFlaw = Boolean.Parse(values.GetValue(row, column++).ToString().Trim());

                                invoice.InvoiceAssignBatch = assignBatch;
                                App.Current.DbContext.Invoices.InsertOnSubmit(invoice);

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
                    }
                    MessageBox.Show("导入结束", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                app.Quit();
            }
        }
    }
}
