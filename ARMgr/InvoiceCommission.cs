//-----------------------------------------------------------------------
// <copyright file="InvoiceCommission.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using CMBC.EasyFactor.Controls;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceCommission : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ARCaseBasic _caseBasic;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private Case _case;


        /// <summary>
        /// Initializes a new instance of the InvoiceCommission class
        /// </summary>
        /// <param name="caseBasic"></param>
        public InvoiceCommission(ARCaseBasic caseBasic)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvInvoices.ImeMode = ImeMode.OnHalf;
            _caseBasic = caseBasic;
            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.ReadOnly = true;
            ControlUtil.SetDoubleBuffered(dgvInvoices);

            var checkBoxCell = new DataGridViewCheckboxHeaderCell();
            checkBoxCell.OnCheckBoxClicked += OnCheckBoxClicked;
            var checkBoxCol = dgvInvoices.Columns[0] as DataGridViewCheckBoxColumn;
            if (checkBoxCol != null)
            {
                checkBoxCol.HeaderCell = checkBoxCell;
                checkBoxCol.HeaderCell.Value = string.Empty;
            }

            _context = new DBDataContext();

            foreach (DataGridViewColumn column in dgvInvoices.Columns)
            {
                column.ReadOnly = true;
            }

            colCurCommissionValue.ReadOnly = false;
        }

        private void OnCheckBoxClicked(object sender, DataGridViewCheckboxHeaderEventArgs e)
        {
            IList logList = invoiceBindingSource.List;
            foreach (DataGridViewRow dgvRow in dgvInvoices.Rows)
            {
                if (dgvRow.Index < logList.Count)
                {
                    var invoice = (Invoice)logList[dgvRow.Index];
                    if (e.CheckedState)
                    {
                        dgvRow.Cells[0].Value = true;
                        ClickInvoice(invoice);
                        ResetRow(dgvRow.Index, true);
                    }
                    else
                    {
                        dgvRow.Cells[0].Value = false;
                        ResetRow(dgvRow.Index, false);
                    }
                }
            }

            dgvInvoices.Refresh();
            StatBatch();
        }


        /// <summary>
        /// Gets or Sets
        /// </summary>
        public Case Case
        {
            set
            {
                _case = _context.Cases.SingleOrDefault(c => c.CaseCode == value.CaseCode);
                NewBatch(null, null);
            }
            get { return _case; }
        }


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        public void ResetControlsStatus()
        {
            foreach (Control comp in panelBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            invoiceBindingSource.DataSource = typeof(Invoice);
            batchBindingSource.DataSource = typeof(RevenueBatch);
        }

        /// <summary>
        /// Show detail info of selected inovice
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailInvoice(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoice = (Invoice)invoiceBindingSource.List[dgvInvoices.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colInvoiceDate)
            {
                var date = (DateTime)e.Value;
                e.Value = date == default(DateTime) ? "" : date.ToString("yyyyMMdd");

                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }

            DataGridViewColumn col = dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colInvoiceDate)
            {
                if (e.Value.Equals(string.Empty))
                {
                    e.Value = null;
                    e.ParsingApplied = true;
                    return;
                }

                var str = (string)e.Value;
                e.Value = DateTime.ParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                e.ParsingApplied = true;
            }
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colPaidCommission || col==colUnpaidCommission || col == colCurCommissionValue)
            {
                if (e.Value.Equals(string.Empty))
                {
                    e.Value = default(double);
                    e.ParsingApplied = true;
                    return;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.Equals(string.Empty))
            {
                return;
            }

            DataGridViewColumn col = dgvInvoices.Columns[e.ColumnIndex];
            if (col == colDueDate || col == colInvoiceDate)
            {
                var str = (string)e.FormattedValue;
                DateTime result;
                bool ok = DateTime.TryParseExact(str, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None,
                                                 out result);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colPaidCommission || col==colUnpaidCommission || col==colCurCommissionValue )
            {
                var str = (string)e.FormattedValue;
                double result;
                bool ok = Double.TryParse(str, out result);
                if (!ok)
                {
                    e.Cancel = true;
                }

                if (result < 0)
                {
                    e.Cancel = true;
                }
            }
            else if (col == colInvoiceNo)
            {
                var str = (string)e.FormattedValue;
                Regex regex = Invoice.INVOICE_NO_REGEX;
                bool ok = regex.IsMatch(str);
                if (!ok)
                {
                    e.Cancel = true;
                }
            }
         }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailInvoice(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("没有有效的额度通知书", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            var batch = new RevenueBatch
                            {
                                CreateUserName = App.Current.CurUser.Name,
                                RevenueDate = DateTime.Today
                            };
            //batch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = batch;

            var result = from invoice in _context.Invoices where invoice.InvoiceAssignBatch.CaseCode == _case.CaseCode && invoice.UnpaidCommission >0 && invoice.InvoiceAssignBatch.CommissionType =="按转让金额" select invoice;
            invoiceBindingSource.DataSource = result;
            dgvInvoices.ReadOnly = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAssignBatch(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (_case == null)
            {
                MessageBoxEx.Show("没有有效的额度通知书", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is RevenueBatch))
            {
                return;
            }

            IList invoiceList = invoiceBindingSource.List;
            var batch = (RevenueBatch)batchBindingSource.DataSource;

            if (invoiceList.Count == 0)
            {
                return;
            }

            bool isSaveOK = true;

            try
            {
                foreach (Invoice invoice in invoiceList)
                {
                    if (TypeUtil.GreaterThan(invoice.CurCommissionValue, 0))
                    {
                        RevenueLog commissionLog = new RevenueLog
                        {
                            RevenueValue = invoice.CurCommissionValue.GetValueOrDefault(),
                            RevenueType = "转让手续费",
                            RevenueDate = DateTime.Today,
                            RevenueCurrency = invoice.InvoiceCurrency,
                            Invoice = invoice,
                            RevenueBatch = batch
                        };
                        invoice.PaidCommission = invoice.PaidCommission.GetValueOrDefault() + invoice.CurCommissionValue.GetValueOrDefault();
                        invoice.UnpaidCommission = invoice.UnpaidCommission.GetValueOrDefault() - invoice.CurCommissionValue.GetValueOrDefault();
                    }
                }

                batch.CheckStatus = BATCH.UNCHECK;
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (RevenueLog log in batch.RevenueLog)
                {
                    log.Invoice = null;
                }
                foreach (Invoice invoice in invoiceList)
                {
                    invoice.CaculateCommission();
                }
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("数据保存成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _caseBasic.CaculateOutstanding(_case);
                StatBatch();
             }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList invoiceList = invoiceBindingSource.List;
            decimal totalCommmission = 0;
            foreach (Invoice invoice in invoiceList)
            {
                totalCommmission += invoice.CurCommissionValue.GetValueOrDefault();
            }

            tbTotalCommission.Text = String.Format("{0:N2}", totalCommmission);
        }

        private void dgvCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            IList invoiceList = invoiceBindingSource.List;
            var invoice = (Invoice)invoiceList[e.RowIndex];
            dgvInvoices.EndEdit();

            if (dgvInvoices.Columns[e.ColumnIndex] == colCheckBox)
            {
                var checkBoxCell = (DataGridViewCheckBoxCell)dgvInvoices.Rows[e.RowIndex].Cells[0];

                if (Boolean.Parse(checkBoxCell.EditedFormattedValue.ToString()))
                {
                    
                    ClickInvoice(invoice);
                    ResetRow(e.RowIndex, true);
                }
                else
                {
                    ResetRow(e.RowIndex, false);
                }

                dgvInvoices.Refresh();
            }
            StatBatch();
        }

        private static void ClickInvoice(Invoice invoice)
        {
            invoice.CurCommissionValue = invoice.UnpaidCommission;
        }

        private void ResetRow(int rowIndex, bool editable)
        {
            dgvInvoices.Rows[rowIndex].Cells["colCurCommissionValue"].ReadOnly = !editable;
            if (!editable)
            {
                var invoice = (Invoice)invoiceBindingSource.List[rowIndex];
                invoice.CurCommissionValue = null;
            }
        }
    }
}