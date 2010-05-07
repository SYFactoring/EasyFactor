//-----------------------------------------------------------------------
// <copyright file="FinanceBatchMgr.cs" company="Yiming Liu@Fudan">
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
    public partial class FinanceBatchMgr : UserControl
    {
        #region?Fields?(2)?

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
            POOL_QUERY,

            /// <summary>
            /// 
            /// </summary>
            POOL_CHECK,
        }

        #endregion?Enums?

        #region?Constructors?(4)?

        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="selectedClient"></param>
        /// <param name="context"></param>
        public FinanceBatchMgr(Client selectedClient, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            this.panelQuery.Visible = false;
            this.colBuyerName.Visible = false;
            this.colBatchCount.Visible = false;
            this.colTransactionType.Visible = false;

            this.bs.DataSource = selectedClient.InvoiceFinanceBatches;
            this.context = context;
        }

        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="selectedCDA"></param>
        /// <param name="context"></param>
        public FinanceBatchMgr(Case selectedCase, DBDataContext context)
            : this(OpBatchType.DETAIL)
        {
            this.panelQuery.Visible = false;
            this.bs.DataSource = selectedCase.InvoiceFinanceBatches;
            this.context = context;
        }

        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="createUserName"></param>
        /// <param name="batchStatus"></param>
        public FinanceBatchMgr(string createUserName, string batchStatus)
            : this(OpBatchType.QUERY)
        {
            this.tbCreateUserName.Text = createUserName;
            this.cbCheckStatus.Text = batchStatus;
            this.QueryBatch(null, null);
        }

        /// <summary>
        /// Initializes a new instance of the FinanceBatchMgr class
        /// </summary>
        /// <param name="batchType"></param>
        public FinanceBatchMgr(OpBatchType batchType)
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
            allLocations.Insert(0, new Location() { LocationCode = "00", LocationName = "ȫ��" });
            this.cbLocation.DataSource = allLocations;
            this.cbLocation.DisplayMember = "LocationName";
            this.cbLocation.ValueMember = "LocationCode";
            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();

            if (batchType == OpBatchType.CHECK)
            {
                this.cbCheckStatus.Text = BATCH.UNCHECK;
                context = new DBDataContext();
                var queryResult = context.InvoiceFinanceBatches.Where(i => i.CheckStatus == BATCH.UNCHECK && i.CaseCode != null);
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
            }
            else if (batchType == OpBatchType.POOL_CHECK)
            {
                this.colBuyerName.Visible = false;
                this.colBatchCount.Visible = false;
                this.colTransactionType.Visible = false;

                this.cbCheckStatus.Text = BATCH.UNCHECK;
                context = new DBDataContext();
                var queryResult = context.InvoiceFinanceBatches.Where(i => i.CheckStatus == BATCH.UNCHECK && i.ClientEDICode != null);
                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
            }
            else if (batchType == OpBatchType.POOL_QUERY)
            {
                this.colBuyerName.Visible = false;
                this.colBatchCount.Visible = false;
                this.colTransactionType.Visible = false;
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
        /// Gets or sets selected FinanceBatch
        /// </summary>
        public InvoiceFinanceBatch Selected
        {
            get;
            set;
        }

        #endregion?Properties?

        #region?Delegates?and?Events?(1)?

        //?Delegates?(1)?

        private delegate void MakeReport(IGrouping<Client, InvoiceFinanceBatch> batchGroup);

        #endregion?Delegates?and?Events?

        #region?Methods?(13)?

        //?Private?Methods?(13)?

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

            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];

            if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permission.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("�������Ѿ�������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("�Ƿ�ȷ�ϸ���ͨ��������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("�����˺͸�������ͬ�����ɽ��и���", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
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

            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceFinanceBatch selectedBatch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            if (MessageBoxEx.Show("�Ƿ����ɾ������������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (selectedBatch.CheckStatus == BATCH.CHECK)
            {
                MessageBoxEx.Show("����ɾ���Ѹ�������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<InvoiceFinanceLog> logList = selectedBatch.InvoiceFinanceLogs.ToList();
            foreach (InvoiceFinanceLog log in logList)
            {
                Invoice invoice = log.Invoice;
                log.Invoice = null;
                invoice.CaculateFinance();
                context.InvoiceFinanceLogs.DeleteOnSubmit(log);
            }

            //if (selectedBatch.Invoices.Count > 0)
            //{
            //    MessageBoxEx.Show("����ɾ�������Σ���������ط�Ʊ��Ϣ", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            context.InvoiceFinanceBatches.DeleteOnSubmit(selectedBatch);
            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("ɾ��ʧ��," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            InvoiceFinanceBatch selectedBatch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
            FinanceBatchDetail detail = new FinanceBatchDetail(selectedBatch);
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
        /// <returns></returns>
        private List<InvoiceFinanceBatch> GetSelectedBatches()
        {
            if (this.dgvBatches.CurrentCell == null)
            {
                return null;
            }

            List<InvoiceFinanceBatch> selectedBatches = new List<InvoiceFinanceBatch>();

            foreach (DataGridViewCell cell in this.dgvBatches.SelectedCells)
            {
                InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.bs.List[cell.RowIndex];
                if (!selectedBatches.Contains(batch))
                {
                    selectedBatches.Add(batch);

                    if (batch.CheckStatus != BATCH.CHECK)
                    {
                        MessageBoxEx.Show("������״̬����������ˣ��������ɱ������κţ� " + batch.FinanceBatchNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }
                }
            }

            return selectedBatches;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedBatches"></param>
        /// <param name="makeReport"></param>
        private void GroupBatches(List<InvoiceFinanceBatch> selectedBatches, MakeReport makeReport)
        {
            IEnumerable<IGrouping<string, InvoiceFinanceBatch>> caseGroups = selectedBatches.GroupBy(c => c.Case.TransactionType);

            foreach (IGrouping<string, InvoiceFinanceBatch> caseGroup in caseGroups)
            {
                string transactionType = caseGroup.Key;
                IEnumerable<IGrouping<Client, InvoiceFinanceBatch>> groups = caseGroup.GroupBy(c => c.Case.SellerClient);
                foreach (IGrouping<Client, InvoiceFinanceBatch> group in groups)
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
            DateTime beginDate = String.IsNullOrEmpty(this.dateFrom.Text) ? this.dateFrom.MinDate : this.dateFrom.Value.Date;
            DateTime endDate = String.IsNullOrEmpty(this.dateTo.Text) ? this.dateTo.MinDate : this.dateTo.Value.Date;
            string status = this.cbCheckStatus.Text;
            string createUserName = this.tbCreateUserName.Text;
            string clientName = this.tbClientName.Text;
            string location = (string)this.cbLocation.SelectedValue;
            string transactionType = this.cbTransactionType.Text;
            if (String.IsNullOrEmpty(transactionType))
            {
                transactionType = "ȫ��";
            }

            string financeType = this.cbFinanceType.Text;
            if (String.IsNullOrEmpty(financeType))
            {
                financeType = "ȫ��";
            }

            context = new DBDataContext();

            IEnumerable<InvoiceFinanceBatch> queryResult = null;
            if (opBatchType != OpBatchType.POOL_QUERY && opBatchType != OpBatchType.POOL_CHECK)
            {
                queryResult = context.InvoiceFinanceBatches.Where(i =>
                    i.FinanceBatchNo.Contains(this.tbFinanceBatchNo.Text)
                    && (i.CaseCode != null)
                    && (beginDate != this.dateFrom.MinDate ? i.FinancePeriodBegin >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.FinancePeriodBegin <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true)
                    && (i.CreateUserName.Contains(createUserName))
                    && (transactionType == "ȫ��" ? true : i.Case.TransactionType == transactionType)
                    && (financeType == "ȫ��" ? true : i.FinanceType == financeType)
                    && (location == "00" ? true : i.Case.OwnerDepartment.LocationCode == location)
                    && (i.Case.SellerClient.ClientNameCN.Contains(clientName) || i.Case.SellerClient.ClientNameEN.Contains(clientName) || i.Case.BuyerClient.ClientNameCN.Contains(clientName) || i.Case.BuyerClient.ClientNameEN.Contains(clientName)));
            }
            else
            {
                queryResult = context.InvoiceFinanceBatches.Where(i =>
                    i.FinanceBatchNo.Contains(this.tbFinanceBatchNo.Text)
                    && (i.ClientEDICode != null)
                    && (beginDate != this.dateFrom.MinDate ? i.FinancePeriodBegin >= beginDate : true)
                    && (endDate != this.dateTo.MinDate ? i.FinancePeriodBegin <= endDate : true)
                    && (status != string.Empty ? i.CheckStatus == status : true)
                    && (i.CreateUserName.Contains(createUserName))
                    && (financeType == "ȫ��" ? true : i.FinanceType == financeType)
                    && (location == "00" ? true : i.Client.Department.LocationCode == location)
                    && (i.Client.ClientNameCN.Contains(clientName) || i.Client.ClientNameEN.Contains(clientName)));
            }

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
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

            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceFinanceBatch batch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];

            if (batch.CheckStatus != BATCH.UNCHECK && !PermUtil.ValidatePermission(CMBC.EasyFactor.Utils.Permission.INVOICE_APPROVE))
            {
                MessageBoxEx.Show("�������Ѿ�������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("�Ƿ�ȷ�ϸ����˻ظ�����", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (App.Current.CurUser.Name == batch.CreateUserName)
            {
                MessageBoxEx.Show("�����˺͸�������ͬ�����ɽ��и����˻�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void ReportCommission(object sender, EventArgs e)
        {
            List<InvoiceFinanceBatch> selectedBatches = this.GetSelectedBatches();
            if (selectedBatches == null)
            {
                return;
            }

            foreach (InvoiceFinanceBatch batch in selectedBatches)
            {
                if (batch.Case.ActiveCDA.CommissionType != "�����ʽ��")
                {
                    MessageBoxEx.Show("��ѡ���β��ǰ������ʽ����ȡ������ã����κţ�" + batch.FinanceBatchNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MakeReport makeReport = new MakeReport(ReportCommissionImpl);
            GroupBatches(selectedBatches, makeReport);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchGroup"></param>
        private void ReportCommissionImpl(IGrouping<Client, InvoiceFinanceBatch> batchGroup)
        {

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBoxEx.Show("Excel �����޷�����!", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                sheet.Shapes.AddPicture(logoPath, MsoTriState.msoFalse, MsoTriState.msoTrue, 220, 3, 170, 30);

                Client seller = batchGroup.Key;
                sheet.Cells[3, 1] = String.Format("������{0}", seller.ToString());
                sheet.get_Range("A5", "E5").MergeCells = true;
                sheet.get_Range("A5", "A5").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[5, 1] = "���������ϸ��";

                int row = 7;
                double totalCommission = 0;

                foreach (InvoiceFinanceBatch selectedBatch in batchGroup)
                {
                    Client buyer = selectedBatch.Case.BuyerClient;
                    Factor factor = selectedBatch.Case.Factor;

                    CDA cda = selectedBatch.Case.ActiveCDA;

                    int beginRow = row;
                    sheet.Cells[row, 1] = "��";
                    sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 6]).MergeCells = true;
                    sheet.Cells[row, 2] = String.Format("{0} ��Ӧ���˿�ծ���ˣ�", buyer.ToString());
                    row++;
                    sheet.Cells[row, 1] = "������";
                    sheet.get_Range(sheet.Cells[row, 2], sheet.Cells[row, 4]).MergeCells = true;
                    sheet.Cells[row, 2] = factor.ToString();
                    sheet.Cells[row, 5] = "�ұ�";
                    sheet.Cells[row, 6] = selectedBatch.BatchCurrency;
                    row++;
                    sheet.Cells[row, 1] = "����ת�ý��";
                    sheet.Cells[row, 2] = "�������ʽ��";
                    sheet.Cells[row, 3] = "����ת�ñ���";
                    sheet.Cells[row, 4] = "ת����";
                    sheet.Cells[row, 5] = "�������";
                    sheet.Cells[row, 6] = "���ݴ����";
                    row++;
                    sheet.Cells[row, 1] = selectedBatch.AssignAmount;
                    sheet.get_Range("A" + row, "A" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.Case.InvoiceCurrency);
                    sheet.Cells[row, 2] = selectedBatch.FinanceAmount;
                    sheet.get_Range("B" + row, "B" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);
                    sheet.Cells[row, 3] = selectedBatch.AssignCount;
                    sheet.Cells[row, 4] = selectedBatch.AssignDate;
                    sheet.Cells[row, 5] = String.Format("{0:0.000%}", selectedBatch.Case.ActiveCDA.Price);
                    sheet.Cells[row, 6] = selectedBatch.Case.ActiveCDA.HandFee;
                    sheet.get_Range("F" + row, "F" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.Case.ActiveCDA.HandFeeCurr);
                    row++;
                    sheet.Cells[row, 1] = "С��";
                    sheet.Cells[row, 5] = selectedBatch.CommissionAmount;
                    sheet.Cells[row, 6] = selectedBatch.HandfeeAmount;
                    sheet.get_Range("E" + row, "F" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(selectedBatch.BatchCurrency);

                    int endRow = row;

                    totalCommission += selectedBatch.CommissionAmount.GetValueOrDefault() + selectedBatch.HandfeeAmount.GetValueOrDefault();
                    sheet.get_Range("A" + beginRow, "F" + endRow).Borders.LineStyle = 1;

                    row += 3;
                }

                sheet.Cells[row - 1, 1] = "ע�����������Ѱ����ʽ����ȡ��";
                sheet.Cells[row, 5] = "�����ܼ�";
                sheet.Cells[row, 6] = totalCommission;
                sheet.get_Range("F" + row, "F" + row).NumberFormatLocal = TypeUtil.GetExcelCurr(batchGroup.First().BatchCurrency);
                sheet.get_Range("E" + row, "F" + row).Borders.LineStyle = 1;

                row += 2;

                sheet.Cells[row + 1, 4] = "�й���������ó�׽�����ҵ������ҵ�� ��ҵ���£�";
                sheet.Cells[row + 3, 5] = String.Format("{0:yyyy}��{0:MM}��{0:dd}��", DateTime.Now);

                sheet.get_Range("A1", Type.Missing).ColumnWidth = 23;
                sheet.get_Range("B1", Type.Missing).ColumnWidth = 23;
                sheet.get_Range("C1", Type.Missing).ColumnWidth = 15;
                sheet.get_Range("D1", Type.Missing).ColumnWidth = 15;
                sheet.get_Range("E1", Type.Missing).ColumnWidth = 17;
                sheet.get_Range("F1", Type.Missing).ColumnWidth = 17;

                sheet.UsedRange.Font.Name = "����_GB2312";
                sheet.UsedRange.Font.Size = 12;
                sheet.UsedRange.Rows.RowHeight = 20;

                sheet.get_Range("A5", "A5").Font.Size = 22;
                sheet.get_Range("A1", "A4").RowHeight = 20;
                sheet.get_Range("A5", "A5").RowHeight = 30;

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
        private void SelectBatch(object sender, EventArgs e)
        {
            if (this.dgvBatches.CurrentCell == null)
            {
                return;
            }

            InvoiceFinanceBatch selectedBatch = (InvoiceFinanceBatch)this.bs.List[this.dgvBatches.CurrentCell.RowIndex];
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

        #endregion?Methods?
    }
}
