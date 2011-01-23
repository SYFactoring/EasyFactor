//-----------------------------------------------------------------------
// <copyright file="CDAMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using Microsoft.Office.Interop.Excel;
using Rectangle = System.Drawing.Rectangle;

namespace CMBC.EasyFactor.CaseMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CDAMgr : UserControl
    {
        #region OpCDAType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpCDAType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            CHECK,

            /// <summary>
            /// 
            /// </summary>
            REPORT,

            /// <summary>
            /// ���֪ͨ�鵽��
            /// </summary>
            DUE,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private readonly OpCDAType _opCDAType;


        /// <summary>
        /// Initializes a new instance of the CDAMgr class.
        /// </summary>
        /// <param name="createUseraName"></param>
        /// <param name="cdaStatus"></param>
        public CDAMgr(string createUseraName, string cdaStatus)
            : this(OpCDAType.QUERY)
        {
            tbCreateUserName.Text = createUseraName;
            cbCheckStatus.Text = cdaStatus;
            QueryCDAs(null, null);
        }

        /// <summary>
        /// Initializes a new instance of the CDAMgr class.
        /// </summary>
        public CDAMgr(OpCDAType opCDAType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvCDAs.AutoGenerateColumns = false;
            _bs = new BindingSource();
            dgvCDAs.DataSource = _bs;
            _opCDAType = opCDAType;
            ControlUtil.SetDoubleBuffered(dgvCDAs);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);

            cbTransactionType.Items.Insert(0, "ȫ��");
            cbTransactionType.Text = @"ȫ��";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "ȫ��" });
            cbLocation.DataSource = allLocations;
            cbLocation.DisplayMember = "LocationName";
            cbLocation.ValueMember = "LocationCode";
            cbLocation.SelectedIndex = 0;

            UpdateContextMenu();

            if (_opCDAType == OpCDAType.CHECK)
            {
                cbCheckStatus.Text = CDAStr.UNCHECK;
                QueryCDAs(null, null);
            }
            else if (_opCDAType == OpCDAType.REPORT)
            {
                cbCheckStatus.Text = CDAStr.CHECKED;
            }
            else if (_opCDAType == OpCDAType.DUE)
            {
                cbCheckStatus.Text = CDAStr.CHECKED;

                Context = new DBDataContext();
                IQueryable<CDA> queryResult = from cda in Context.CDAs
                                              where
                                                  cda.CDAStatus == CDAStr.CHECKED
                                                  &&
                                                  (cda.CreditCoverPeriodEnd < DateTime.Now.Date ||
                                                   cda.FinanceLinePeriodEnd < DateTime.Now.Date)
                                              select cda;

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected CDA
        /// </summary>
        public CDA Selected { get; set; }


        //?Private?Methods?(16)?
        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailCDA(sender, e);
            }
            else
            {
                SelectCDA(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_APPROVE))
            {
                return;
            }

            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            var cda = (CDA)_bs.List[dgvCDAs.CurrentCell.RowIndex];

            if (
                MessageBoxEx.Show("�Ƿ�ȷ�ϸ���ͨ���ö��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cda.CDAStatus = CDAStr.CHECKED;
            cda.CheckUserName = App.Current.CurUser.Name;
            cda.CheckDate = DateTime.Now.Date;

            if (cda.Case.CaseMark == CASE.APPLICATION)
            {
                cda.Case.CaseMark = CASE.ENABLE;
            }

            if (cda.CDAStatus == CDAStr.CHECKED)
            {
                foreach (CDA c in cda.Case.CDAs)
                {
                    if (c != cda && c.CDAStatus == CDAStr.CHECKED)
                    {
                        c.CDAStatus = CDAStr.INVALID;
                    }
                }
            }

            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e2)
            {
                MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Delete selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            var cda = (CDA)_bs.List[dgvCDAs.CurrentCell.RowIndex];

            if (cda.CDAStatus == CDAStr.CHECKED)
            {
                MessageBoxEx.Show("�˶��֪ͨ���Ѿ�����ˣ�����ɾ����", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (
                MessageBoxEx.Show("�Ƿ����ɾ�����֪ͨ��: " + cda.CDACode, MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            Context.CDAs.DeleteOnSubmit(cda);

            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show("����ɾ���˶��֪ͨ��: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("����ɾ���ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCDAs.Rows.RemoveAt(dgvCDAs.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// Show detail info of selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            var selectedCDA = (CDA)_bs.List[dgvCDAs.CurrentCell.RowIndex];
            var cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCDAsCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvCDAs.Columns[e.ColumnIndex];
            if (column == colIsRecoarse || column == colIsSigned)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    var result = (bool)originalData;
                    e.Value = result ? "Y" : "N";
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCDAsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < _bs.List.Count; i++)
            {
                var cda = (CDA)_bs.List[i];
                if (cda.CreditCoverPeriodEnd < DateTime.Now.Date)
                {
                    dgvCDAs["colCreditCoverPeriodEnd", i].Style.BackColor = Color.Red;
                }
                if (cda.FinanceLinePeriodEnd < DateTime.Now.Date)
                {
                    dgvCDAs["colFinanceLinePeriodEnd", i].Style.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCDAsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvCDAs.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCDAs.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvCDAs.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportCDAs(object sender, EventArgs e)
        {
            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            List<CDA> selectedCDAs = GetSelectedCDAs();
            if (selectedCDAs.Count > 0)
            {
                var form = new ExportForm(ExportForm.ExportType.EXPORT_CDAS, selectedCDAs);
                form.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<CDA> GetSelectedCDAs()
        {
            var selectedCDAs = new List<CDA>();
            foreach (DataGridViewCell cell in dgvCDAs.SelectedCells)
            {
                var selectedCDA = (CDA)_bs.List[cell.RowIndex];
                if (!selectedCDAs.Contains(selectedCDA))
                {
                    selectedCDAs.Add(selectedCDA);
                }
            }

            return selectedCDAs;
        }

        /// <summary>
        /// Create a new CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            var cdaDetail = new CDADetail(CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCDAs(object sender, EventArgs e)
        {
            string clientName = tbClientName.Text;
            string factorName = tbFactorName.Text;
            string contractCode = tbContractCode.Text;
            string status = cbCheckStatus.Text;
            string transactionType = cbTransactionType.Text;
            var location = (string)cbLocation.SelectedValue;
            string createUserName = tbCreateUserName.Text;
            bool isCDAChecked = cbIsCDA.CheckState == CheckState.Checked;
            DateTime beginDate = String.IsNullOrEmpty(diBegin.Text) ? diBegin.MinDate : diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(diEnd.Text) ? diEnd.MinDate : diEnd.Value;

            Context = new DBDataContext();

            IQueryable<CDA> queryResult =
                from cda in Context.CDAs
                let curCase = cda.Case
                where
                    (transactionType == "ȫ��" ? true : curCase.TransactionType == transactionType) &&
                    (location == "00" ? true : curCase.OwnerDepartment.LocationCode == location)
                let contracts = cda.Case.SellerClient.Contracts
                where
                    contractCode == string.Empty ? true : contracts.Any(con => con.ContractCode.Contains(contractCode))
                let seller = cda.Case.SellerClient
                let buyer = cda.Case.BuyerClient
                where
                    seller.ClientNameCN.Contains(clientName) || seller.ClientNameEN.Contains(clientName) ||
                    buyer.ClientNameCN.Contains(clientName) || buyer.ClientNameEN.Contains(clientName)
                let sellerfactor = cda.Case.SellerFactor
                let buyerfactor = cda.Case.BuyerFactor
                where sellerfactor.CompanyNameCN.Contains(factorName) || sellerfactor.CompanyNameEN.Contains(factorName)
                  || buyerfactor.CompanyNameCN.Contains(factorName) || buyerfactor.CompanyNameEN.Contains(factorName)
                where
                    (status != string.Empty ? cda.CDAStatus == status : true)
                    && cda.CreateUserName.Contains(createUserName)
                    && (isCDAChecked ? cda.IsSigned == isCDAChecked : true)
                    && (beginDate != diBegin.MinDate ? cda.CDASignDate >= beginDate : true)
                    && (endDate != diEnd.MinDate ? cda.CDASignDate <= endDate : true)
                select cda;

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reject(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_APPROVE))
            {
                return;
            }

            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            var cda = (CDA)_bs.List[dgvCDAs.CurrentCell.RowIndex];

            if (
                MessageBoxEx.Show("�Ƿ�ȷ�ϸ����˻ظö��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cda.CDAStatus = CDAStr.REJECT;
            cda.CheckUserName = App.Current.CurUser.Name;
            cda.CheckDate = DateTime.Now.Date;

            try
            {
                Context.SubmitChanges();
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
        private void ReportCDA(object sender, EventArgs e)
        {
            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            var selectedCDA = (CDA)_bs.List[dgvCDAs.CurrentCell.RowIndex];

            Client seller = selectedCDA.Case.SellerClient;
            if (seller != null)
            {
                if (seller.Contract!=null && seller.Contract.ContractType == "193���ĺ�ͬ")
                {
                    ReportCDA193(selectedCDA);
                }
                else
                {
                    ReportCDAOld(selectedCDA);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCDA"></param>
        private void ReportCDA193(CDA selectedCDA)
        {
            var app = new ApplicationClass { Visible = false };
            var sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                sheet.PageSetup.Zoom = false;
                sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                sheet.PageSetup.FitToPagesWide = 1;
                sheet.PageSetup.FitToPagesTall = false;

                bool isZero = false;
                if (selectedCDA.Case.TransactionType == "�����򷽱���" || selectedCDA.Case.TransactionType == "���ڱ���")
                {
                    isZero = true;
                }

                sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 1]].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sheet.Cells[2, 1] = "�й��������б�����֪ͨ��";

                sheet.Range[sheet.Cells[4, 1], sheet.Cells[4, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[4, 1], sheet.Cells[4, 1]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                sheet.Cells[4, 1] = String.Format("������ţ�{0}", selectedCDA.CaseCode);

                sheet.Cells[5, 1] = String.Format("��˾��{0}��ǰǢ���а�����ҵ��ǩ����������ͬ", selectedCDA.SellerName);
                if (selectedCDA.Case.SellerClient.Contract != null)
                {
                    sheet.Cells[6, 1] = String.Format("(��ͬ���:��[ {0} ]�� ), ������������,�˶��������:",
                                                      selectedCDA.Case.SellerClient.Contract.ContractCode);
                }
                else
                {
                    sheet.Cells[6, 1] = String.Format("(��ͬ���:��[  ]�� ), ������������,�˶��������:");
                }

                int row = 8;
                sheet.Cells[row, 1] = "������";
                sheet.Cells[row++, 2] = selectedCDA.BuyerName;
                sheet.Cells[row, 1] = "�򷽵�ַ";
                sheet.Cells[row++, 2] = String.IsNullOrEmpty(selectedCDA.Case.BuyerClient.AddressCN)
                                            ? selectedCDA.Case.BuyerClient.AddressEN
                                            : selectedCDA.Case.BuyerClient.AddressCN;
                sheet.Cells[row, 1] = "��������";
                sheet.Cells[row++, 2] = selectedCDA.PaymentTerms;

                if (selectedCDA.IsRecoarse.GetValueOrDefault() == false)
                {
                    sheet.Cells[row, 1] = "���÷��յ������";
                    if (selectedCDA.CreditCover.HasValue)
                    {
                        if (isZero)
                        {
                            sheet.Cells[row++, 2] = "0";
                        }
                        else
                        {
                            sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��",
                                                                  TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr),
                                                                  selectedCDA.CreditCover,
                                                                  TypeUtil.ToPrintCurrencyChinese(
                                                                      selectedCDA.CreditCoverCurr),
                                                                  TypeUtil.ConvertToChineseMoney(selectedCDA.CreditCover));
                        }
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = "0";
                    }

                    sheet.Cells[row, 1] = "���÷��ճе�����";
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0%";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:0%}", selectedCDA.PUGProportion.GetValueOrDefault());
                    }

                    sheet.Cells[row, 1] = "���÷��ն����Ч����";
                    if (selectedCDA.CreditCoverPeriodBegin.HasValue)
                    {
                        if (isZero)
                        {
                            sheet.Cells[row++, 2] = "��";
                        }
                        else
                        {
                            sheet.Cells[row++, 2] = String.Format("{0:yyyy}��{0:MM}��{0:dd}�� �� {1:yyyy}��{1:MM}��{1:dd}��",
                                                                  selectedCDA.CreditCoverPeriodBegin,
                                                                  selectedCDA.CreditCoverPeriodEnd);
                        }
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = "��";
                    }
                }

                sheet.Cells[row, 1] = "�������ʶ��";
                if (selectedCDA.FinanceLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��",
                                                              TypeUtil.ToPrintCurrency(selectedCDA.FinanceLineCurr),
                                                              selectedCDA.FinanceLine,
                                                              TypeUtil.ToPrintCurrencyChinese(
                                                                  selectedCDA.FinanceLineCurr),
                                                              TypeUtil.ConvertToChineseMoney(selectedCDA.FinanceLine));
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "�������ʶ����Ч����";
                if (selectedCDA.FinanceLinePeriodBegin.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "��";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}��{0:MM}��{0:dd}�� �� {1:yyyy}��{1:MM}��{1:dd}��",
                                                              selectedCDA.FinanceLinePeriodBegin,
                                                              selectedCDA.FinanceLinePeriodEnd);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "��";
                }

                sheet.Cells[row, 1] = "��߱������ʶ��";

                double? highestCreditLine = selectedCDA.HighestFinanceLine;
                if (highestCreditLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��",
                                                              TypeUtil.ToPrintCurrency(selectedCDA.FinanceLineCurr),
                                                              highestCreditLine,
                                                              TypeUtil.ToPrintCurrencyChinese(
                                                                  selectedCDA.FinanceLineCurr),
                                                              TypeUtil.ConvertToChineseMoney(highestCreditLine));
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "�������ʱ���";
                if (isZero)
                {
                    sheet.Cells[row++, 2] = "��";
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("�������ʲ������ϸ�Ӧ���˿���� {0:p0}", selectedCDA.FinanceProportion);
                }

                sheet.Cells[row, 1] = "�������";
                if (selectedCDA.CommissionType == "����")
                {
                    sheet.Cells[row++, 2] = selectedCDA.CommissionTypeComment;
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("{0}�� {1:p2} {2}",
                                                                selectedCDA.CommissionType,
                                                                selectedCDA.Price.GetValueOrDefault(), isZero ? "�����򷽳е�" : string.Empty);
                }

                sheet.Cells[row, 1] = "���ݴ����";
                if (selectedCDA.HandFee.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} Ԫ ��ÿ�ŷ�Ʊ��",
                                                              TypeUtil.ToPrintCurrencyChinese(selectedCDA.HandFeeCurr),
                                                              selectedCDA.HandFee);
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                int rowEnd = 16;
                if (selectedCDA.Case.TransactionType == "���ڱ���")
                {
                    sheet.Cells[row, 1] = "���ڱ�����";
                    sheet.Cells[row++, 2] = selectedCDA.Case.BuyerFactor.ToString();
                    rowEnd = 17;
                }

                if (selectedCDA.IsRecoarse.GetValueOrDefault() == false)
                {
                    rowEnd += 5;
                    sheet.Cells[row, 1] = "�Ը���";
                    if (selectedCDA.Deductibles.HasValue)
                    {
                        if (isZero)
                        {
                            sheet.Cells[row++, 2] = "0";
                        }
                        else
                        {
                            sheet.Cells[row++, 2] = String.Format("{0} {1:N2}",
                                                                  TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr),
                                                                  selectedCDA.Deductibles);
                        }
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = "0";
                    }

                    sheet.Cells[row, 1] = "�����ʧ�ż�";
                    if (selectedCDA.LossThreshold.HasValue)
                    {
                        if (isZero)
                        {
                            sheet.Cells[row, 2] = "0";
                        }
                        else
                        {
                            sheet.Cells[row, 2] = String.Format("{0} {1:N2}",
                                                                  TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr),
                                                                  selectedCDA.LossThreshold);
                        }
                    }
                    else
                    {
                        sheet.Cells[row, 2] = "0";
                    }

                }

                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 1]].HorizontalAlignment =
                    XlHAlign.xlHAlignDistributed;
                sheet.Range[sheet.Cells[8, 2], sheet.Cells[rowEnd, 2]].HorizontalAlignment = XlHAlign.xlHAlignLeft;

                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 2]].Borders.LineStyle = 1;
                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 2]].WrapText = true;
                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 1]].Font.Bold = true;

                sheet.Range["A1", Type.Missing].ColumnWidth = 30;
                sheet.Range["B1", Type.Missing].ColumnWidth = 60;

                Range contentRange = sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 2]];
                foreach (Range range in contentRange)
                {
                    range.EntireRow.RowHeight = 35;
                }

                row = rowEnd + 2;
                sheet.Cells[row++, 1] = "��ע��";

                bool isSingle = selectedCDA.Case.SellerFactorCode == selectedCDA.Case.BuyerFactorCode;
                string recoarse = selectedCDA.IsRecoarse.GetValueOrDefault() ? "��׷��Ȩ" : "��׷��Ȩ";
                string single = isSingle ? "������" : "˫����";
                string line0 = string.Empty;
                switch (selectedCDA.Case.TransactionType)
                {
                    case "������������":
                        line0 = String.Format("��1����ҵ��Ϊ{0}{1}{2}��{3}��ҵ��", recoarse, "����", single, selectedCDA.IsNotice);
                        break;
                    case "���ڱ���":
                        line0 = String.Format("��1����ҵ��Ϊ{0}{1}{2}��{3}��ҵ��", recoarse, "����", single, selectedCDA.IsNotice);
                        break;
                    case "�����򷽱���":
                        line0 = String.Format("��1����ҵ��Ϊ{0}{1}��{2}��ҵ��", recoarse, "����", selectedCDA.IsNotice);
                        break;
                    case "���ڱ���":
                        line0 = String.Format("��1����ҵ��Ϊ{0}{1}{2}��{3}��ҵ��", recoarse, "����", single, selectedCDA.IsNotice);
                        break;
                    default:
                        break;
                }

                if (selectedCDA.IsNotice == "������")
                {
                    if (selectedCDA.IsRecoarse.GetValueOrDefault())
                    {
                        const string line1 = "��2����Ӧ���˿�ծ����(���¼����)�ڵ�Ӧ���˿���պ�    ���ڣ��������60�죩��δ�����������������Լ�������պ�ĵ�һ��Ӫҵ��֪ͨ�������д��ӳٸ������������������ǰ��֪ͨ��֪ͨ��Ӧ���˿�ת�����˼���δ����������δ��֪ͨ���Σ����������Զ������е������÷��յ������Ρ�";
                        const string line2 = "��3���ٷ��϶��������峥ʱ���������еý���������δ�峥֮Ӧ���˿�ҵ��ת����������������֪ͨ�򷽡�";
                        const string line3 = "��4�������������򷽼�ȫ����Լ֮Ӧ���˿����Ӧ��������֮˳�����С�����Ӧ�����������˵�ע������ά����Ը�Ӧ���˿��Ȩ����������ؼ�¼��";
                        string comment = line0 + "\n\n" + line1 + "\n\n" + line2 + "\n\n" + line3;
                        if (!String.IsNullOrEmpty(selectedCDA.Comment))
                        {
                            comment += "\n\n��5��" + selectedCDA.Comment;
                        }
                        sheet.Cells[row, 1] = comment;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 190;
                        if (!String.IsNullOrEmpty(selectedCDA.Comment))
                        {
                            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 210;
                        }
                        row++;
                    }
                    else
                    {
                        const string line1 = "��2����Ӧ���˿�ծ����(���¼����)�ڵ�Ӧ���˿����պ�    ���ڣ��������60�죩��δ�����������������Լ�������պ�ĵ�һ��Ӫҵ��֪ͨ�������д��ӳٸ������������������ǰ��֪ͨ��֪ͨ��Ӧ���˿�ת�����˼���δ����������δ��֪ͨ���Σ����������Զ������е������÷��յ������Ρ�";
                        const string line2 =
                            "��3����Ա����ĵ������������ɡ�Ӧ���˿���պ�һ�ٶ�ʮ�ա����޸�Ϊ�����յ�Ӧ���˿�ת��֪֮ͨ����һ�ٶ�ʮ�ա���";
                        const string line3 = "��4����׼Ӧ���˿�����ۺ�ͬ�н�ֹת�õ�Լ��ʱ���������о͸�Ӧ���˿�븺�κ����Ρ�";
                        const string line4 = "��5����δ�峥��׼Ӧ���˿��ҹٷ��϶������峥ʱ���������еý���������δ�峥֮Ӧ���˿�ҵ��ת����������������֪ͨ�򷽡�";
                        const string line5 = "��6�������������򷽼�ȫ����Լ֮Ӧ���˿�����Ƿ�Ϊ���÷��յ�����������ǣ�������Ӧ��������֮˳�����С�����Ӧ�����������˵�ע������ά����Ը�Ӧ���˿��Ȩ����������ؼ�¼��";

                        string comment = line0 + "\n\n" + line1 + "\n\n" + line2 + "\n\n" + line3 + "\n\n" + line4 + "\n\n" + line5;
                        if (!String.IsNullOrEmpty(selectedCDA.Comment))
                        {
                            comment += "\n\n��7��" + selectedCDA.Comment;
                        }
                        sheet.Cells[row, 1] = comment;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 250;
                        if (!String.IsNullOrEmpty(selectedCDA.Comment))
                        {
                            sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 270;
                        }
                        row++;
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(selectedCDA.Comment))
                    {
                        sheet.Cells[row, 1] = line0 + "\n\n��2��" + selectedCDA.Comment;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 40;
                        row++;
                    }
                    else
                    {
                        sheet.Cells[row, 1] = line0;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                        sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 20;
                        row++;
                    }
                }

                row++;
                sheet.Cells[row, 1] = "���˾�ڱ��з�����֪ͨ���90����δǩ�ػ��ڱ����յ�ǩ��֪ͨ���30����δ���ö��ʱ�����е�ֹͣ���֮���á���˾�ú��������øö�ȣ�������������롣";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 40;
                row++;
                row++;
                sheet.Cells[row, 1] =
                    "Ϊ���濼�ǣ������ȷ���Ͽ���ϵ��˾Ԥ������֮���󣬱�������֪ͨ��ȡ����ǰͬһ��֮������֪ͨ�鼰��ǰ���й�˾�뱾��ͬ��ر�����֪ͨ����֮��߱������ʶ�ȡ�";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 40;
                row++;
                row++;

                sheet.Cells[row++, 2] = selectedCDA.Case.OwnerDepartment.Location.LocationName == "����"
                                         ? String.Format("�й��������йɷ����޹�˾����Ӫҵ��")
                                         : String.Format("�й��������йɷ����޹�˾{0}����",
                                                         selectedCDA.Case.OwnerDepartment.Location.LocationName);

                sheet.Cells[row++, 2] = String.Format("���ڣ�{0:yyyy}�� {0:MM}�� {0:dd}��", selectedCDA.CDASignDate);
                sheet.Range[sheet.Cells[row - 2, 2], sheet.Cells[row - 1, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                row++;

                sheet.Cells[row++, 1] = "�ҹ�˾֪����ͬ������������֪ͨ�����ݡ�";
                row++;

                sheet.Cells[row++, 2] = selectedCDA.SellerName;
                sheet.Cells[row++, 2] = "��˾ӡ��          ";
                sheet.Cells[row++, 2] = String.Format("����:      ��    ��    ��");
                sheet.Range[sheet.Cells[row - 3, 2], sheet.Cells[row - 1, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;

                sheet.UsedRange.Font.Name = "����_GB2312";
                sheet.UsedRange.Font.Size = 12;

                sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 1]].Font.Size = 16;
                sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 1]].Font.Bold = true;

                app.Visible = true;
            }
            catch (Exception)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
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
                }
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCDA"></param>
        private void ReportCDAOld(CDA selectedCDA)
        {
            var app = new ApplicationClass { Visible = false };
            var sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                sheet.PageSetup.Zoom = false;
                sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                sheet.PageSetup.FitToPagesWide = 1;
                sheet.PageSetup.FitToPagesTall = false;

                bool isZero = false;
                if (selectedCDA.Case.TransactionType == "�����򷽱���" || selectedCDA.Case.TransactionType == "���ڱ���")
                {
                    isZero = true;
                }

                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 1]].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sheet.Cells[1, 1] = "�й��������б�����֪ͨ�� ";

                sheet.Cells[3, 2] = String.Format("������ţ�{0}", selectedCDA.CaseCode);
                sheet.Range[sheet.Cells[3, 2], sheet.Cells[3, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;

                sheet.Cells[5, 1] = String.Format("��{0}��ǰǢ���а�����ҵ��ǩ����������ͬ", selectedCDA.SellerName);
                if (selectedCDA.Case.SellerClient.Contract != null)
                {
                    sheet.Cells[6, 1] = String.Format("(��ͬ���:��[ {0} ]�� ), ������������,�˶��������:",
                                                      selectedCDA.Case.SellerClient.Contract.ContractCode);
                }
                else
                {
                    sheet.Cells[6, 1] = String.Format("(��ͬ���:��[  ]�� ), ������������,�˶��������:");
                }

                int row = 8;
                sheet.Cells[row, 1] = "������";
                sheet.Cells[row++, 2] = selectedCDA.BuyerName;
                sheet.Cells[row, 1] = "�򷽵�ַ";
                sheet.Cells[row++, 2] = String.IsNullOrEmpty(selectedCDA.Case.BuyerClient.AddressCN)
                                            ? selectedCDA.Case.BuyerClient.AddressEN
                                            : selectedCDA.Case.BuyerClient.AddressCN;
                sheet.Cells[row, 1] = "��������";
                sheet.Cells[row++, 2] = selectedCDA.PaymentTerms;
                sheet.Cells[row, 1] = "���÷��ն��";
                if (selectedCDA.CreditCover.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��",
                                                              TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr),
                                                              selectedCDA.CreditCover,
                                                              TypeUtil.ToPrintCurrencyChinese(
                                                                  selectedCDA.CreditCoverCurr),
                                                              TypeUtil.ConvertToChineseMoney(selectedCDA.CreditCover));
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "���÷��ճе�����";
                if (isZero)
                {
                    sheet.Cells[row++, 2] = "0%";
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("{0:0%}", selectedCDA.PUGProportion.GetValueOrDefault());
                }

                sheet.Cells[row, 1] = "���÷��ն����Ч����";
                if (selectedCDA.CreditCoverPeriodBegin.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "��";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}��{0:MM}��{0:dd}�� �� {1:yyyy}��{1:MM}��{1:dd}��",
                                                              selectedCDA.CreditCoverPeriodBegin,
                                                              selectedCDA.CreditCoverPeriodEnd);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "��";
                }
                sheet.Cells[row, 1] = "����Ԥ������";
                if (selectedCDA.FinanceLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��",
                                                              TypeUtil.ToPrintCurrency(selectedCDA.FinanceLineCurr),
                                                              selectedCDA.FinanceLine,
                                                              TypeUtil.ToPrintCurrencyChinese(
                                                                  selectedCDA.FinanceLineCurr),
                                                              TypeUtil.ConvertToChineseMoney(selectedCDA.FinanceLine));
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "Ԥ��������Ч����";
                if (selectedCDA.FinanceLinePeriodBegin.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "��";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}��{0:MM}��{0:dd}�� �� {1:yyyy}��{1:MM}��{1:dd}��",
                                                              selectedCDA.FinanceLinePeriodBegin,
                                                              selectedCDA.FinanceLinePeriodEnd);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "��";
                }

                sheet.Cells[row, 1] = "��߱���Ԥ������";

                double? highestCreditLine = selectedCDA.HighestFinanceLine;
                if (highestCreditLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��",
                                                              TypeUtil.ToPrintCurrency(selectedCDA.FinanceLineCurr),
                                                              highestCreditLine,
                                                              TypeUtil.ToPrintCurrencyChinese(
                                                                  selectedCDA.FinanceLineCurr),
                                                              TypeUtil.ConvertToChineseMoney(highestCreditLine));
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "Ԥ������";
                if (isZero)
                {
                    sheet.Cells[row++, 2] = "��";
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("�������ʲ������ϸ�Ӧ���˿���� {0:p0}", selectedCDA.FinanceProportion);
                }

                sheet.Cells[row, 1] = "�������";
                if (selectedCDA.CommissionType == "����")
                {
                    sheet.Cells[row++, 2] = selectedCDA.CommissionTypeComment;
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("{0}�� {1:p2} {2}",
                                                                selectedCDA.CommissionType,
                                                                selectedCDA.Price.GetValueOrDefault(), isZero ? "�����򷽳е�" : string.Empty);
                }

                sheet.Cells[row, 1] = "���ݴ����";
                if (selectedCDA.HandFee.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} Ԫ ��ÿ�ŷ�Ʊ��",
                                                              TypeUtil.ToPrintCurrencyChinese(selectedCDA.HandFeeCurr),
                                                              selectedCDA.HandFee);
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                int rowEnd = 21;
                if (selectedCDA.Case.TransactionType == "���ڱ���")
                {
                    sheet.Cells[row, 1] = "���ڱ�����";
                    sheet.Cells[row++, 2] = selectedCDA.Case.BuyerFactor.ToString();
                    rowEnd = 22;
                }

                sheet.Cells[row, 1] = "�Ը���";
                if (selectedCDA.Deductibles.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2}",
                                                              TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr),
                                                              selectedCDA.Deductibles);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "�����ʧ�ż�";
                if (selectedCDA.LossThreshold.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row, 2] = String.Format("{0} {1:N2}",
                                                              TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr),
                                                              selectedCDA.LossThreshold);
                    }
                }
                else
                {
                    sheet.Cells[row, 2] = "0";
                }


                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 1]].HorizontalAlignment =
                    XlHAlign.xlHAlignDistributed;
                sheet.Range[sheet.Cells[8, 2], sheet.Cells[rowEnd, 2]].HorizontalAlignment = XlHAlign.xlHAlignLeft;

                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 2]].Borders.LineStyle = 1;
                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 2]].WrapText = true;

                sheet.Cells[23, 1] = "��ע��";

                bool isSingle = selectedCDA.Case.SellerFactorCode == selectedCDA.Case.BuyerFactorCode;
                string recoarse = selectedCDA.IsRecoarse.GetValueOrDefault() ? "��׷��Ȩ" : "��׷��Ȩ";
                string single = isSingle ? "������" : "˫����";
                string line1 = string.Empty;
                switch (selectedCDA.Case.TransactionType)
                {
                    case "������������":
                        line1 = String.Format("��1����ҵ��Ϊ{0}{1}{2}��{3}��ҵ��", recoarse, "����", single, selectedCDA.IsNotice);
                        break;
                    case "���ڱ���":
                        line1 = String.Format("��1����ҵ��Ϊ{0}{1}{2}��{3}��ҵ��", recoarse, "����", single, selectedCDA.IsNotice);
                        break;
                    case "�����򷽱���":
                        line1 = String.Format("��1����ҵ��Ϊ{0}{1}��{2}��ҵ��", recoarse, "����", selectedCDA.IsNotice);
                        break;
                    case "���ڱ���":
                        line1 = String.Format("��1����ҵ��Ϊ{0}{1}{2}��{3}��ҵ��", recoarse, "����", single, selectedCDA.IsNotice);
                        break;
                    default:
                        break;
                }

                const string line2 =
                    "��2����Ӧ���˿�ծ����(���¼����)�ڵ�Ӧ���˿����պ� 60 ���ڣ�������� 60 �죩��δ�����������������Լ�������պ�ĵ�һ��Ӫҵ��֪ͨ�������д��ӳٸ������������������ǰ��֪ͨ��֪ͨ��Ӧ���˿�ת�����˼���δ����������δ��֪ͨ���Σ����������Զ������е������÷��յ������Ρ�";
                const string line3 = "��3����׼Ӧ���˿�����ۺ�ͬ�н�ֹת�õ�Լ��ʱ���������о͸�Ӧ���˿�븺�κ����Ρ�";
                const string line4 = "��4����δ�峥��׼Ӧ���˿��ҹٷ��϶������峥ʱ���������еý���������δ�峥֮Ӧ���˿�ҵ��ת����������������֪ͨ�򷽡�";
                const string line5 = "��5�������������򷽼�ȫ����Լ֮Ӧ���˿�����Ƿ�Ϊ���÷��յ�����������ǣ�������Ӧ��������֮˳�����С�����Ӧ�����������˵�ע������ά����Ը�Ӧ���˿��Ȩ����������ؼ�¼��";

                sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 1]].WrapText = true;
                sheet.Range[sheet.Cells[26, 1], sheet.Cells[26, 1]].WrapText = true;
                sheet.Range[sheet.Cells[28, 1], sheet.Cells[28, 1]].WrapText = true;

                sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[26, 1], sheet.Cells[26, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[28, 1], sheet.Cells[28, 2]].MergeCells = true;

                if (selectedCDA.IsNotice == "������")
                {
                    string comment = line1 + "\n\n" + line2 + "\n\n" + line3 + "\n\n" + line4 + "\n\n" + line5;
                    if (!String.IsNullOrEmpty(selectedCDA.Comment))
                    {
                        comment += "\n\n��6��" + selectedCDA.Comment;
                    }

                    sheet.Cells[24, 1] = comment;
                    sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 1]].RowHeight = 200;
                }
                else
                {
                    string comment = line1;
                    if (!String.IsNullOrEmpty(selectedCDA.Comment))
                    {
                        comment += "\n\n��2��" + selectedCDA.Comment;
                    }

                    sheet.Cells[24, 1] = comment;
                    sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 1]].RowHeight = 45;
                }


                sheet.Cells[26, 1] = "���˾�ڱ��з�����֪ͨ���10����δǩ�ػ��ڱ����յ�ǩ��֪ͨ���30����δ���ö��ʱ�����е�ֹͣ���֮���á���˾�ú��������øö�ȣ�������������롣";
                sheet.Cells[28, 1] =
                    "Ϊ���濼�ǣ������ȷ���Ͽ���ϵ��˾Ԥ������֮���󣬱�������֪ͨ��ȡ����ǰͬһ��֮������֪ͨ�鼰��ǰ���й�˾�뱾��ͬ��ر�����֪ͨ����֮��߱���Ԥ�����ȡ�";


                sheet.Range[sheet.Cells[26, 1], sheet.Cells[26, 2]].RowHeight = 40;
                sheet.Range[sheet.Cells[28, 1], sheet.Cells[28, 2]].RowHeight = 40;

                sheet.Cells[30, 2] = selectedCDA.Case.OwnerDepartment.Location.LocationName == "����"
                                         ? String.Format("�й��������йɷ����޹�˾����Ӫҵ��")
                                         : String.Format("�й��������йɷ����޹�˾{0}����",
                                                         selectedCDA.Case.OwnerDepartment.Location.LocationName);

                sheet.Cells[31, 2] = String.Format("���ڣ�{0:yyyy}�� {0:MM}�� {0:dd}��", selectedCDA.CDASignDate);
                sheet.Range[sheet.Cells[30, 2], sheet.Cells[31, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;

                sheet.Cells[33, 1] = "�ҹ�˾֪����ͬ������������֪ͨ�����ݡ�";

                sheet.Cells[35, 2] = selectedCDA.SellerName;
                sheet.Cells[36, 2] = "��˾ӡ��          ";
                sheet.Cells[37, 2] = String.Format("����:      ��    ��    ��");
                sheet.Range[sheet.Cells[35, 2], sheet.Cells[37, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;


                sheet.UsedRange.Font.Name = "����_GB2312";
                sheet.UsedRange.Font.Size = 12;

                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 1]].Font.Size = 16;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 1]].Font.Bold = true;
                sheet.Range[sheet.Cells[8, 1], sheet.Cells[rowEnd, 1]].Font.Bold = true;

                sheet.Range["A1", Type.Missing].ColumnWidth = 30;
                sheet.Range["B1", Type.Missing].ColumnWidth = 60;

                Range contentRange = sheet.Range[sheet.Cells[8, 1], sheet.Cells[21, 2]];
                foreach (Range range in contentRange)
                {
                    range.EntireRow.RowHeight = 35;
                }

                app.Visible = true;
            }
            catch (Exception)
            {
                if (sheet != null)
                {
                    Marshal.ReleaseComObject(sheet);
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
                }
                throw;
            }
        }

        /// <summary>
        /// Select CDA and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectCDA(object sender, EventArgs e)
        {
            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            Selected = (CDA)_bs.List[dgvCDAs.CurrentCell.RowIndex];

            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCDAStatus(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            if (dgvCDAs.CurrentCell == null)
            {
                return;
            }

            var cda = (CDA)_bs.List[dgvCDAs.CurrentCell.RowIndex];
            cda.AdjustCDAStatus();

            try
            {
                Context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("���¶��֪ͨ��״̬ʧ��: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            MessageBoxEx.Show("���¶��֪ͨ��״̬�ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateContextMenu()
        {
            if (PermUtil.ValidatePermission(Permissions.CDA_UPDATE))
            {
                menuItemCDANew.Enabled = true;
                menuItemCDADelete.Enabled = true;
                menuItemCDAUpdate.Enabled = true;
                menuItemCDAReport.Enabled = true;
                menuItemCDAExport.Enabled = true;
            }
            else
            {
                menuItemCDANew.Enabled = false;
                menuItemCDADelete.Enabled = false;
                menuItemCDAUpdate.Enabled = false;
                menuItemCDAReport.Enabled = false;
                menuItemCDAExport.Enabled = false;
            }

            if (PermUtil.ValidatePermission(Permissions.CDA_APPROVE))
            {
                menuItemCheck.Enabled = true;
                menuItemReject.Enabled = true;
            }
            else
            {
                menuItemCheck.Enabled = false;
                menuItemReject.Enabled = false;
            }
        }

    }
}