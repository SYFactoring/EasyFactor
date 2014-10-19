//-----------------------------------------------------------------------
// <copyright file="InvoiceAssign.cs" company="Yiming Liu@Fudan">
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
    public partial class InvoiceAssign : UserControl
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
        /// Initializes a new instance of the InvoiceAssign class
        /// </summary>
        /// <param name="caseBasic"></param>
        public InvoiceAssign(ARCaseBasic caseBasic)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvInvoices.ImeMode = ImeMode.OnHalf;
            _caseBasic = caseBasic;
            dgvInvoices.AutoGenerateColumns = false;
            superValidator.Enabled = false;
            dgvInvoices.ReadOnly = true;
            cbWhoPayCommission.Items.AddRange(new object[] { "������", "�򷽸�" });
            cbWhoPayCommission.Text = "������";
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
            foreach (Control comp in panelAssignBatch.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }

            invoiceBindingSource.DataSource = typeof(Invoice);
            batchBindingSource.DataSource = typeof(InvoiceAssignBatch);
        }

        //?Private?Methods?(17)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoice = (Invoice)invoiceBindingSource.List[dgvInvoices.CurrentCell.RowIndex];
            var caseDetail = new CaseDetail(selectedInvoice.InvoiceAssignBatch.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoice = (Invoice)invoiceBindingSource.List[dgvInvoices.CurrentCell.RowIndex];
            var cdaDetail = new CDADetail(selectedInvoice.InvoiceAssignBatch.Case.ActiveCDA,
                                          CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
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
        private void DgvInvoicesCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (dgvInvoices.Rows[e.RowIndex].IsNewRow)
            {
                if (!(batchBindingSource.DataSource is InvoiceAssignBatch))
                {
                    return;
                }

                superValidator.Validate();
            }
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
            else if (col == colIsFlaw)
            {
                var isFlaw = (bool)e.Value;
                e.Value = isFlaw ? "Y" : "N";

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
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colPaidCommission || col==colUnpaidCommission || col==colPaidHandlingFee|| col== colUnpaidHandingFee)
            {
                if (e.Value.Equals(string.Empty))
                {
                    e.Value = default(double);
                    e.ParsingApplied = true;
                    return;
                }
            }
            else if (col == colIsFlaw)
            {
                if (e.Value.Equals("Y"))
                {
                    e.Value = true;
                    e.ParsingApplied = true;
                    return;
                }
                if (e.Value.Equals("N"))
                {
                    e.Value = false;
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
            else if (col == colInvoiceAmount || col == colAssignAmount || col == colPaidCommission || col==colUnpaidCommission || col==colPaidHandlingFee||col==colUnpaidHandingFee)
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
            else if (col == colIsFlaw)
            {
                var str = (string)e.FormattedValue;
                if ("Y".Equals(str) || "N".Equals(str))
                {
                    return;
                }
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvInvoicesCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            var selectedInvoice = (Invoice)invoiceBindingSource.List[dgvInvoices.CurrentCell.RowIndex];

            if (dgvInvoices.Columns[e.ColumnIndex] == colInvoiceAmount)
            {
                selectedInvoice.AssignAmount = selectedInvoice.InvoiceAmount;
                CDA cda = _case.ActiveCDA;
                if (cda.CommissionPrePost == "����")
                {
                    if (cda.CommissionType == "��ת�ý��")
                    {
                        selectedInvoice.PaidCommission = selectedInvoice.AssignAmount * (decimal)cda.Price;
                    }
                    selectedInvoice.PaidHandlingFee = cda.HandFee.GetValueOrDefault();
                }
                else if (cda.CommissionPrePost == "����")
                {
                    if (cda.CommissionType == "��ת�ý��")
                    {
                        selectedInvoice.UnpaidCommission = selectedInvoice.AssignAmount * (decimal)cda.Price;
                    }
                    selectedInvoice.UnpaidHandlingFee = cda.HandFee.GetValueOrDefault();
                }
                StatBatch();
            }
            else if (dgvInvoices.Columns[e.ColumnIndex] == colAssignAmount)
            {
                CDA cda = _case.ActiveCDA;
                if (cda.CommissionPrePost == "����")
                {
                    if (cda.CommissionType == "��ת�ý��")
                    {
                        selectedInvoice.PaidCommission = selectedInvoice.AssignAmount * (decimal)cda.Price;
                    }
                    selectedInvoice.PaidHandlingFee = cda.HandFee.GetValueOrDefault();
                }
                else if (cda.CommissionPrePost == "����")
                {
                    if (cda.CommissionType == "��ת�ý��")
                    {
                        selectedInvoice.UnpaidCommission = selectedInvoice.AssignAmount * (decimal)cda.Price;
                    }
                    selectedInvoice.UnpaidHandlingFee = cda.HandFee.GetValueOrDefault();
                }

                StatBatch();
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
        private void ExportAssignBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("û����Ч�Ķ��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            var exportForm = new ExportForm(ExportForm.ExportType.EXPORT_ASSIGN_BY_BATCH, invoiceBindingSource.List);
            exportForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void Flaw(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentCell == null)
            {
                return;
            }

            var selectedInvoice = (Invoice)invoiceBindingSource.List[dgvInvoices.CurrentCell.RowIndex];
            var invoiceDetail = new InvoiceDetail(selectedInvoice, InvoiceDetail.OpInvoiceType.FLAW);
            invoiceDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportAssignBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("û����Ч�Ķ��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            var importForm = new ImportForm(ImportForm.ImportType.IMPORT_ASSIGN_BY_BATCH);
            importForm.ShowDialog(this);

            if (importForm.ImportedList != null)
            {
                var invoiceList = (List<Invoice>)importForm.ImportedList;
                foreach (Invoice invoice in invoiceBindingSource.List)
                {
                    if (!invoiceList.Contains(invoice))
                    {
                        invoiceList.Add(invoice);
                    }
                }

                try
                {
                    foreach (Invoice invoice in invoiceList)
                    {
                        if (invoice.PaidCommission.HasValue == false)
                        {
                            invoice.CaculateCommission();
                        }
                    }
                }
                catch (Exception e1)
                {
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                invoiceBindingSource.DataSource = invoiceList;
                StatBatch();
            }
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
                MessageBoxEx.Show("û����Ч�Ķ��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (_case.ActiveCDA.CommissionType == "��ת�ý��" || _case.ActiveCDA.CommissionType == "����")
            {
                colPaidCommission.Visible = true;
                colUnpaidCommission.Visible = true;
            }
            else
            {
                colPaidCommission.Visible = false;
                colUnpaidCommission.Visible = false;
            }

            var batch = new InvoiceAssignBatch
                            {
                                AssignDate = DateTime.Now.Date,
                                CreateUserName = App.Current.CurUser.Name,
                                IsRefinance = false,
                                WhoPayCommission = "������",
                                CommissionType = _case.ActiveCDA.CommissionType,
                                CommissionPrePost = _case.ActiveCDA.CommissionPrePost
                            };
            //batch.CheckStatus = BATCH.UNCHECK;
            batchBindingSource.DataSource = batch;
            invoiceBindingSource.DataSource = batch.Invoices;
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
                MessageBoxEx.Show("û����Ч�Ķ��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (!superValidator.Validate())
            {
                return;
            }

            if (!(batchBindingSource.DataSource is InvoiceAssignBatch))
            {
                return;
            }

            IList invoiceList = invoiceBindingSource.List;
            var batch = (InvoiceAssignBatch)batchBindingSource.DataSource;

            if (invoiceList.Count == 0)
            {
                return;
            }

            if (!ValidateBatch())
            {
                return;
            }

            decimal totalAssign = 0;
            var invoiceNoList = new List<string>();
            foreach (Invoice invoice in invoiceList)
            {
                if (!invoiceNoList.Contains(invoice.InvoiceNo))
                {
                    invoiceNoList.Add(invoice.InvoiceNo);
                }
                else
                {
                    MessageBoxEx.Show("��Ʊ���ظ�: " + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }

                if (batch.AssignBatchNo == null &&
                    _context.Invoices.SingleOrDefault(
                        i => i.InvoiceNo == invoice.InvoiceNo && i.InvoiceAssignBatch.CaseCode == _case.CaseCode) !=
                    null)
                {
                    MessageBoxEx.Show("��Ʊ���Ѵ���: " + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }

                totalAssign += invoice.AssignAmount;
            }

            if (_case.ActiveCDA.CreditCoverOutstanding.HasValue &&
                totalAssign > _case.ActiveCDA.CreditCoverOutstanding.Value)
            {
                DialogResult dr = MessageBoxEx.Show("��������������е������÷��յ��������ռ���������ת�ò��ֲ��ٽ��е������Ƿ�ȷ��ת�ã�",
                                                    MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            if (_case.BuyerClient.AssignCreditLineOutstanding.HasValue &&
                totalAssign > _case.BuyerClient.AssignCreditLineOutstanding.Value)
            {
                DialogResult dr = MessageBoxEx.Show("�ͻ������ռ���������ת�ò��ֲ��ٽ��е������Ƿ�ȷ��ת�ã�", MESSAGE.TITLE_INFORMATION,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            if (_case.BuyerClient.GroupAssignCreditLine != null)
            {
                decimal assignCreditLineOutstanding = _case.BuyerClient.GroupAssignCreditLine.AssignCreditLineOutstanding;
                if (_case.BuyerClient.GroupAssignCreditLine.CreditLineCurrency !=
                    _case.BuyerClient.AssignCreditLine.CreditLineCurrency)
                {
                    decimal exchange =
                        Exchange.GetExchangeRate(_case.BuyerClient.GroupAssignCreditLine.CreditLineCurrency,
                                                 _case.BuyerClient.AssignCreditLine.CreditLineCurrency);
                    assignCreditLineOutstanding *= exchange;
                }

                if (totalAssign > assignCreditLineOutstanding)
                {
                    DialogResult dr = MessageBoxEx.Show("���Ŷ����ռ���������ת�ò��ֲ��ٽ��е������Ƿ�ȷ��ת�ã�", MESSAGE.TITLE_INFORMATION,
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            bool isSaveOK = true;

            var flawList = new List<Invoice>();
            try
            {
                batch.Case = _case;
                if (batch.AssignBatchNo == null)
                {
                    batch.AssignBatchNo = InvoiceAssignBatch.GenerateAssignBatchNo(_case.CaseCode, batch.AssignDate);
                    batch.InputDate = DateTime.Today;

                    if (batch.CommissionPrePost == "����")
                    {
                        RevenueBatch commissionBatch = new RevenueBatch
                        {
                            RevenueDate = DateTime.Now,
                            CreateUserName = App.Current.CurUser.Name,
                            CheckStatus = BATCH.UNCHECK,
                            InvoiceAssignBatch = batch
                        };

                        foreach (Invoice invoice in invoiceList)
                        {
                            if(TypeUtil.GreaterThan(invoice.PaidHandlingFee,0)){
                                RevenueLog handFeeLog = new RevenueLog
                                {
                                    RevenueValue = invoice.PaidHandlingFee.GetValueOrDefault(),
                                    RevenueType = "���ݷ�",
                                    RevenueCurrency = batch.BatchCurrency,
                                    RevenueDate = DateTime.Now,
                                    Invoice = invoice,
                                    RevenueBatch = commissionBatch
                                };
                            }
                        }

                        if (batch.CommissionType == "��ת�ý��")
                        {
                            foreach (Invoice invoice in invoiceList)
                            {
                                if (TypeUtil.GreaterThan(invoice.PaidCommission, 0))
                                {
                                    RevenueLog commissionLog = new RevenueLog
                                    {
                                        RevenueValue = invoice.PaidCommission.GetValueOrDefault(),
                                        RevenueType = "ת��������",
                                        RevenueCurrency = batch.BatchCurrency,
                                        RevenueDate = DateTime.Now,
                                        Invoice = invoice,
                                        RevenueBatch = commissionBatch
                                    };
                                }
                            }
                        }
                    }

                }

                foreach (Invoice invoice in invoiceList)
                {
                    invoice.InvoiceAssignBatch = batch;
                    invoice.CaculateCommissionForFirstTime();
                    if (invoice.IsFlaw)
                    {
                        flawList.Add(invoice);
                    }
                }

                batch.CheckStatus = BATCH.UNCHECK;
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                foreach (Invoice invoice in invoiceList)
                {
                    invoice.InvoiceAssignBatch = null;
                    invoice.RevenueLog = null;
                }

                batch.Case = null;
                batch.AssignBatchNo = null;
                batch.RevenueBatch = null;
                isSaveOK = false;
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isSaveOK)
            {
                MessageBoxEx.Show("���ݱ���ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _caseBasic.CaculateOutstanding(_case);
                StatBatch();

                if (flawList.Count > 0)
                {
                    var flawMgr = new InvoiceFlaw(flawList, true);
                    flawMgr.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBatch(object sender, EventArgs e)
        {
            if (_case == null)
            {
                MessageBoxEx.Show("û����Ч�Ķ��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            var batchMgr = new AssignBatchMgr(_case, _context);
            var queryUI = new QueryForm(batchMgr, "ѡ��ת������");
            batchMgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            InvoiceAssignBatch selectedBatch = batchMgr.Selected;
            if (selectedBatch != null)
            {
                if (selectedBatch.Invoices.Any(i => i.FinanceAmount > 0 || i.PaymentAmount > 0))
                {
                    MessageBoxEx.Show("��ת�������ѽ��й����ʻ򸶿�Ⱥ����������������޸�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    return;
                }

                batchBindingSource.DataSource = selectedBatch;
                invoiceBindingSource.DataSource = selectedBatch.Invoices.ToList();
                StatBatch();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatBatch()
        {
            IList invoiceList = invoiceBindingSource.List;
            decimal totalAssign = 0;
            decimal totalCommmission = 0;
            decimal totalHandlingFee = 0;
            foreach (Invoice invoice in invoiceList)
            {
                totalAssign += invoice.AssignAmount;
                totalCommmission += invoice.PaidCommission.GetValueOrDefault();
                totalHandlingFee += invoice.PaidHandlingFee.GetValueOrDefault();
            }

            tbTotalAssign.Text = String.Format("{0:N2}", totalAssign);
            tbAssignNumber.Text = String.Format("{0}", invoiceList.Count);
            tbTotalCommission.Text = String.Format("{0:N2}", totalCommmission);
            tbTotalHandfee.Text = String.Format("{0:N2}", totalHandlingFee);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateBatch()
        {
            CDA cda = _case.ActiveCDA;
            bool isCommissionAlert = true;

            foreach (Invoice invoice in invoiceBindingSource.List)
            {
                if (invoice.InvoiceNo == null)
                {
                    MessageBoxEx.Show("��Ʊ�ű���", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return false;
                }

                if (invoice.InvoiceAmount==0)
                {
                    MessageBoxEx.Show("Ʊ�������", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return false;
                }

                if (invoice.AssignAmount > invoice.InvoiceAmount)
                {
                    MessageBoxEx.Show("ת�ý��ܴ���Ʊ����: " + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (invoice.InvoiceDate != null && invoice.DueDate < invoice.InvoiceDate)
                {
                    MessageBoxEx.Show("�����ղ������ڷ�Ʊ��: " + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                DateTime assignDate = assignDateDateTimePicker.Value.Date;
                if (invoice.InvoiceDate != null && invoice.InvoiceDate > assignDate)
                {
                    DialogResult dr = MessageBoxEx.Show("��Ʊ������ת���գ��Ƿ�ȷ��¼��: " + invoice.InvoiceNo,
                                                        MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information);
                    if (dr == DialogResult.No)
                    {
                        return false;
                    }
                }

                if (_case.NetPaymentTerm.HasValue)
                {
                    if (invoice.InvoiceDate != null &&
                        assignDate > invoice.InvoiceDate.Value.AddDays(_case.NetPaymentTerm.Value))
                    {
                        MessageBoxEx.Show("ת���ղ������ڷ�Ʊ��+��������: " + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION,
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                if (invoice.InvoiceDate != null && cda.CreditCoverPeriodEnd != null)
                {
                    if (invoice.InvoiceDate > cda.CreditCoverPeriodEnd)
                    {
                        MessageBoxEx.Show("��Ʊ�ղ������ڶ��֪ͨ�����ʵ�����: " + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION,
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                if (invoice.DueDate < assignDate)
                {
                    invoice.IsFlaw = true;
                    invoice.FlawReason = "09";
                }

                if (invoice.PaidCommission.HasValue == false && cda.CommissionType == "����")
                {
                    if (isCommissionAlert)
                    {
                        DialogResult dr = MessageBoxEx.Show("�Ƿ�����¼��������: " + invoice.InvoiceNo, MESSAGE.TITLE_INFORMATION,
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            return false;
                        }
                        isCommissionAlert = false;
                    }
                }
            }

            return true;
        }
    }
}