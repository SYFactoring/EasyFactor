//-----------------------------------------------------------------------
// <copyright file="FinanceCommission.cs" company="Yiming Liu@Fudan">
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

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceCommission : UserControl
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
        /// Initializes a new instance of the FinanceCommission class
        /// </summary>
        /// <param name="caseBasic"></param>
        public FinanceCommission(ARCaseBasic caseBasic)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvInvoices.ImeMode = ImeMode.OnHalf;
            _caseBasic = caseBasic;
            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.ReadOnly = true;
            ControlUtil.SetDoubleBuffered(dgvInvoices);

            _context = new DBDataContext();
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

            invoiceBindingSource.DataSource = typeof(InvoiceFinanceLog);
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

            var selectedInvoiceFinanceLog = (InvoiceFinanceLog)invoiceBindingSource.List[dgvInvoices.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedInvoiceFinanceLog.Invoice, InvoiceDetail.OpInvoiceType.DETAIL_INVOICE);
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
            if (col == colDueDate || col == colInvoiceDate || col == colFinanceDate)
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
            if (col == colDueDate || col == colInvoiceDate || col== colFinanceDate)
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
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colFinanceAmount || col == colPaidCommission || col==colUnpaidCommission )
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
            if (col == colDueDate || col == colInvoiceDate || col == colFinanceDate)
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
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colFinanceAmount || col == colPaidCommission || col==colUnpaidCommission )
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
                                RevenueDate = DateTime.Now,
                                CreateUserName = App.Current.CurUser.Name,
                            };
            //batch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = batch;

            var result = from log in _context.InvoiceFinanceLogs where log.Invoice.InvoiceAssignBatch.CaseCode == _case.CaseCode && log.UnpaidCommission > 0 && log.Invoice.InvoiceAssignBatch.CommissionType =="按融资金额" select log;
            invoiceBindingSource.DataSource = result;
            dgvInvoices.ReadOnly = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFinanceCommissionBatch(object sender, EventArgs e)
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

            IList financeLogList = invoiceBindingSource.List;
            var batch = (RevenueBatch)batchBindingSource.DataSource;

            if (financeLogList.Count == 0)
            {
                return;
            }

            bool isSaveOK = true;

            try
            {
                if (batch.RevenueBatchID==0)
                {
                        foreach (InvoiceFinanceLog financeLog in financeLogList)
                        {
                            if (TypeUtil.GreaterThan(financeLog.CurCommissionValue, 0))
                            {
                                RevenueLog commissionLog = new RevenueLog
                                {
                                    RevenueValue = financeLog.CurCommissionValue.GetValueOrDefault(),
                                    RevenueType = "融资手续费",
                                    RevenueDate = DateTime.Now,
                                    RevenueCurrency = financeLog.Invoice.InvoiceCurrency,
                                    Invoice = financeLog.Invoice,
                                    RevenueBatch = batch
                                };
                                financeLog.PaidCommission = financeLog.PaidCommission.GetValueOrDefault() + financeLog.CurCommissionValue.GetValueOrDefault();
                                financeLog.UnpaidCommission = financeLog.UnpaidCommission.GetValueOrDefault() - financeLog.CurCommissionValue.GetValueOrDefault();
                                financeLog.Invoice.CaculateCommission();
                            }
                        }
                    }

                batch.CheckStatus = BATCH.UNCHECK;
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach(RevenueLog log in batch.RevenueLog)
                {
                    log.Invoice = null;
                }
                foreach (InvoiceFinanceLog financeLog in financeLogList)
                {
                    financeLog.Invoice.CaculateCommission();
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
            foreach (InvoiceFinanceLog financeLog in invoiceList)
            {
                totalCommmission += financeLog.CurCommissionValue.GetValueOrDefault();
            }

            tbTotalCommission.Text = String.Format("{0:N2}", totalCommmission);
        }

    }
}