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
            /// 额度通知书到期
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

            cbTransactionType.Items.Insert(0, "全部");
            cbTransactionType.Text = @"全部";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location { LocationCode = "00", LocationName = "全部" });
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
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
                MessageBoxEx.Show("是否确认复核通过该额度通知书", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
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
                MessageBoxEx.Show("此额度通知书已经过审核，不能删除。", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            if (
                MessageBoxEx.Show("是否打算删除额度通知书: " + cda.CDACode, MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel,
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
                MessageBoxEx.Show("不能删除此额度通知书: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("数据删除成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    (transactionType == "全部" ? true : curCase.TransactionType == transactionType) &&
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
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
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
                MessageBoxEx.Show("是否确认复核退回该额度通知书", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
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
                if (seller.Contract!=null && seller.Contract.ContractType == "193号文合同")
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
                if (selectedCDA.Case.TransactionType == "国内买方保理" || selectedCDA.Case.TransactionType == "进口保理")
                {
                    isZero = true;
                }

                sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[2, 1], sheet.Cells[2, 1]].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sheet.Cells[2, 1] = "中国民生银行保理额度通知书";

                sheet.Range[sheet.Cells[4, 1], sheet.Cells[4, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[4, 1], sheet.Cells[4, 1]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                sheet.Cells[4, 1] = String.Format("案件编号：{0}", selectedCDA.CaseCode);

                sheet.Cells[5, 1] = String.Format("贵公司（{0}）前洽本行办理保理业务并签立保理服务合同", selectedCDA.SellerName);
                if (selectedCDA.Case.SellerClient.Contract != null)
                {
                    sheet.Cells[6, 1] = String.Format("(合同编号:第[ {0} ]号 ), 经本行评估后,核定额度如下:",
                                                      selectedCDA.Case.SellerClient.Contract.ContractCode);
                }
                else
                {
                    sheet.Cells[6, 1] = String.Format("(合同编号:第[  ]号 ), 经本行评估后,核定额度如下:");
                }

                int row = 8;
                sheet.Cells[row, 1] = "买方名称";
                sheet.Cells[row++, 2] = selectedCDA.BuyerName;
                sheet.Cells[row, 1] = "买方地址";
                sheet.Cells[row++, 2] = String.IsNullOrEmpty(selectedCDA.Case.BuyerClient.AddressCN)
                                            ? selectedCDA.Case.BuyerClient.AddressEN
                                            : selectedCDA.Case.BuyerClient.AddressCN;
                sheet.Cells[row, 1] = "付款条件";
                sheet.Cells[row++, 2] = selectedCDA.PaymentTerms;

                if (selectedCDA.IsRecoarse.GetValueOrDefault() == false)
                {
                    sheet.Cells[row, 1] = "信用风险担保额度";
                    if (selectedCDA.CreditCover.HasValue)
                    {
                        if (isZero)
                        {
                            sheet.Cells[row++, 2] = "0";
                        }
                        else
                        {
                            sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）",
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

                    sheet.Cells[row, 1] = "信用风险承担比例";
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0%";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:0%}", selectedCDA.PUGProportion.GetValueOrDefault());
                    }

                    sheet.Cells[row, 1] = "信用风险额度有效期限";
                    if (selectedCDA.CreditCoverPeriodBegin.HasValue)
                    {
                        if (isZero)
                        {
                            sheet.Cells[row++, 2] = "无";
                        }
                        else
                        {
                            sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 至 {1:yyyy}年{1:MM}月{1:dd}日",
                                                                  selectedCDA.CreditCoverPeriodBegin,
                                                                  selectedCDA.CreditCoverPeriodEnd);
                        }
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = "无";
                    }
                }

                sheet.Cells[row, 1] = "保理融资额度";
                if (selectedCDA.FinanceLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）",
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

                sheet.Cells[row, 1] = "保理融资额度有效期限";
                if (selectedCDA.FinanceLinePeriodBegin.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "无";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 至 {1:yyyy}年{1:MM}月{1:dd}日",
                                                              selectedCDA.FinanceLinePeriodBegin,
                                                              selectedCDA.FinanceLinePeriodEnd);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "无";
                }

                sheet.Cells[row, 1] = "最高保理融资额度";

                double? highestCreditLine = selectedCDA.HighestFinanceLine;
                if (highestCreditLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）",
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

                sheet.Cells[row, 1] = "保理融资比例";
                if (isZero)
                {
                    sheet.Cells[row++, 2] = "无";
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("单笔融资不超过合格应收账款金额的 {0:p0}", selectedCDA.FinanceProportion);
                }

                sheet.Cells[row, 1] = "保理费率";
                if (selectedCDA.CommissionType == "其他")
                {
                    sheet.Cells[row++, 2] = selectedCDA.CommissionTypeComment;
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("{0}的 {1:p2} {2}",
                                                                selectedCDA.CommissionType,
                                                                selectedCDA.Price.GetValueOrDefault(), isZero ? "，由买方承担" : string.Empty);
                }

                sheet.Cells[row, 1] = "单据处理费";
                if (selectedCDA.HandFee.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} 元 （每张发票）",
                                                              TypeUtil.ToPrintCurrencyChinese(selectedCDA.HandFeeCurr),
                                                              selectedCDA.HandFee);
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                int rowEnd = 16;
                if (selectedCDA.Case.TransactionType == "出口保理")
                {
                    sheet.Cells[row, 1] = "进口保理商";
                    sheet.Cells[row++, 2] = selectedCDA.Case.BuyerFactor.ToString();
                    rowEnd = 17;
                }

                if (selectedCDA.IsRecoarse.GetValueOrDefault() == false)
                {
                    rowEnd += 5;
                    sheet.Cells[row, 1] = "自负额";
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

                    sheet.Cells[row, 1] = "最低损失门槛";
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
                sheet.Cells[row++, 1] = "备注：";

                bool isSingle = selectedCDA.Case.SellerFactorCode == selectedCDA.Case.BuyerFactorCode;
                string recoarse = selectedCDA.IsRecoarse.GetValueOrDefault() ? "有追索权" : "无追索权";
                string single = isSingle ? "单保理" : "双保理";
                string line0 = string.Empty;
                switch (selectedCDA.Case.TransactionType)
                {
                    case "国内卖方保理":
                        line0 = String.Format("（1）本业务为{0}{1}{2}（{3}）业务。", recoarse, "国内", single, selectedCDA.IsNotice);
                        break;
                    case "出口保理":
                        line0 = String.Format("（1）本业务为{0}{1}{2}（{3}）业务。", recoarse, "出口", single, selectedCDA.IsNotice);
                        break;
                    case "国内买方保理":
                        line0 = String.Format("（1）本业务为{0}{1}（{2}）业务。", recoarse, "国内", selectedCDA.IsNotice);
                        break;
                    case "进口保理":
                        line0 = String.Format("（1）本业务为{0}{1}{2}（{3}）业务。", recoarse, "进口", single, selectedCDA.IsNotice);
                        break;
                    default:
                        break;
                }

                if (selectedCDA.IsNotice == "暗保理")
                {
                    if (selectedCDA.IsRecoarse.GetValueOrDefault())
                    {
                        const string line1 = "（2）如应收账款债务人(以下简称买方)于到应收账款到期日后    日内（最长不超过60天）仍未付款，卖方至迟于上述约定到期日后的第一个营业日通知民生银行此延迟付款。民生银行依卖方的前述通知，通知买方应收账款转让事宜及其未付余额，如卖方未尽通知责任，民生银行自动免除其承担的信用风险担保责任。";
                        const string line2 = "（3）官方认定买方无力清偿时，民生银行得将所有买方尚未清偿之应收账款业已转让予民生银行事宜通知买方。";
                        const string line3 = "（4）关于卖方与买方间全部契约之应收账款，卖方应按到期日之顺序排列。卖方应尽善良管理人的注意义务维持其对该应收账款的权利并保存相关纪录。";
                        string comment = line0 + "\n\n" + line1 + "\n\n" + line2 + "\n\n" + line3;
                        if (!String.IsNullOrEmpty(selectedCDA.Comment))
                        {
                            comment += "\n\n（5）" + selectedCDA.Comment;
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
                        const string line1 = "（2）如应收账款债务人(以下简称买方)于到应收账款期日后    日内（最长不超过60天）仍未付款，卖方至迟于上述约定到期日后的第一个营业日通知民生银行此延迟付款。民生银行依卖方的前述通知，通知买方应收账款转让事宜及其未付余额，如卖方未尽通知责任，民生银行自动免除其承担的信用风险担保责任。";
                        const string line2 =
                            "（3）针对本案的担保付款期限由「应收账款到期日后一百二十日」，修改为「买方收到应收账款转让通知之日起一百二十日」。";
                        const string line3 = "（4）核准应收账款的销售合同有禁止转让的约定时，民生银行就该应收账款不须负任何责任。";
                        const string line4 = "（5）买方未清偿核准应收账款且官方认定无力清偿时，民生银行得将所有买方尚未清偿之应收账款业已转让予民生银行事宜通知买方。";
                        const string line5 = "（6）关于卖方与买方间全部契约之应收账款（不论是否为信用风险担保金额所涵盖），卖方应按到期日之顺序排列。卖方应尽善良管理人的注意义务维持其对该应收账款的权利并保存相关纪录。";

                        string comment = line0 + "\n\n" + line1 + "\n\n" + line2 + "\n\n" + line3 + "\n\n" + line4 + "\n\n" + line5;
                        if (!String.IsNullOrEmpty(selectedCDA.Comment))
                        {
                            comment += "\n\n（7）" + selectedCDA.Comment;
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
                        sheet.Cells[row, 1] = line0 + "\n\n（2）" + selectedCDA.Comment;
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
                sheet.Cells[row, 1] = "如贵公司于本行发出本通知书后90日内未签回或于本行收到签回通知书后30日内未动用额度时，本行得停止额度之动用。贵公司嗣后如欲动用该额度，须重新提出申请。";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 40;
                row++;
                row++;
                sheet.Cells[row, 1] =
                    "为利益考虑，请务必确认上开买方系贵公司预定交易之对象，本保理额度通知书取代先前同一买方之保理额度通知书及先前所有贵公司与本合同相关保理额度通知书中之最高保理融资额度。";
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].WrapText = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[row, 1], sheet.Cells[row, 1]].RowHeight = 40;
                row++;
                row++;

                sheet.Cells[row++, 2] = selectedCDA.Case.OwnerDepartment.Location.LocationName == "北京"
                                         ? String.Format("中国民生银行股份有限公司总行营业部")
                                         : String.Format("中国民生银行股份有限公司{0}分行",
                                                         selectedCDA.Case.OwnerDepartment.Location.LocationName);

                sheet.Cells[row++, 2] = String.Format("日期：{0:yyyy}年 {0:MM}月 {0:dd}日", selectedCDA.CDASignDate);
                sheet.Range[sheet.Cells[row - 2, 2], sheet.Cells[row - 1, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;
                row++;

                sheet.Cells[row++, 1] = "我公司知晓并同意上述保理额度通知书内容。";
                row++;

                sheet.Cells[row++, 2] = selectedCDA.SellerName;
                sheet.Cells[row++, 2] = "公司印鉴          ";
                sheet.Cells[row++, 2] = String.Format("日期:      年    月    日");
                sheet.Range[sheet.Cells[row - 3, 2], sheet.Cells[row - 1, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;

                sheet.UsedRange.Font.Name = "仿宋_GB2312";
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
                if (selectedCDA.Case.TransactionType == "国内买方保理" || selectedCDA.Case.TransactionType == "进口保理")
                {
                    isZero = true;
                }

                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 1]].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sheet.Cells[1, 1] = "中国民生银行保理额度通知书 ";

                sheet.Cells[3, 2] = String.Format("案件编号：{0}", selectedCDA.CaseCode);
                sheet.Range[sheet.Cells[3, 2], sheet.Cells[3, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;

                sheet.Cells[5, 1] = String.Format("贵（{0}）前洽本行办理保理业务并签立保理服务合同", selectedCDA.SellerName);
                if (selectedCDA.Case.SellerClient.Contract != null)
                {
                    sheet.Cells[6, 1] = String.Format("(合同编号:第[ {0} ]号 ), 经本行评估后,核定额度如下:",
                                                      selectedCDA.Case.SellerClient.Contract.ContractCode);
                }
                else
                {
                    sheet.Cells[6, 1] = String.Format("(合同编号:第[  ]号 ), 经本行评估后,核定额度如下:");
                }

                int row = 8;
                sheet.Cells[row, 1] = "买方名称";
                sheet.Cells[row++, 2] = selectedCDA.BuyerName;
                sheet.Cells[row, 1] = "买方地址";
                sheet.Cells[row++, 2] = String.IsNullOrEmpty(selectedCDA.Case.BuyerClient.AddressCN)
                                            ? selectedCDA.Case.BuyerClient.AddressEN
                                            : selectedCDA.Case.BuyerClient.AddressCN;
                sheet.Cells[row, 1] = "付款条件";
                sheet.Cells[row++, 2] = selectedCDA.PaymentTerms;
                sheet.Cells[row, 1] = "信用风险额度";
                if (selectedCDA.CreditCover.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）",
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

                sheet.Cells[row, 1] = "信用风险承担比例";
                if (isZero)
                {
                    sheet.Cells[row++, 2] = "0%";
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("{0:0%}", selectedCDA.PUGProportion.GetValueOrDefault());
                }

                sheet.Cells[row, 1] = "信用风险额度有效期限";
                if (selectedCDA.CreditCoverPeriodBegin.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "无";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 至 {1:yyyy}年{1:MM}月{1:dd}日",
                                                              selectedCDA.CreditCoverPeriodBegin,
                                                              selectedCDA.CreditCoverPeriodEnd);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "无";
                }
                sheet.Cells[row, 1] = "保理预付款额度";
                if (selectedCDA.FinanceLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）",
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

                sheet.Cells[row, 1] = "预付款额度有效期限";
                if (selectedCDA.FinanceLinePeriodBegin.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "无";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 至 {1:yyyy}年{1:MM}月{1:dd}日",
                                                              selectedCDA.FinanceLinePeriodBegin,
                                                              selectedCDA.FinanceLinePeriodEnd);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "无";
                }

                sheet.Cells[row, 1] = "最高保理预付款额度";

                double? highestCreditLine = selectedCDA.HighestFinanceLine;
                if (highestCreditLine.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）",
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

                sheet.Cells[row, 1] = "预付比例";
                if (isZero)
                {
                    sheet.Cells[row++, 2] = "无";
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("单笔融资不超过合格应收账款金额的 {0:p0}", selectedCDA.FinanceProportion);
                }

                sheet.Cells[row, 1] = "保理费率";
                if (selectedCDA.CommissionType == "其他")
                {
                    sheet.Cells[row++, 2] = selectedCDA.CommissionTypeComment;
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("{0}的 {1:p2} {2}",
                                                                selectedCDA.CommissionType,
                                                                selectedCDA.Price.GetValueOrDefault(), isZero ? "，由买方承担" : string.Empty);
                }

                sheet.Cells[row, 1] = "单据处理费";
                if (selectedCDA.HandFee.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} 元 （每张发票）",
                                                              TypeUtil.ToPrintCurrencyChinese(selectedCDA.HandFeeCurr),
                                                              selectedCDA.HandFee);
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                int rowEnd = 21;
                if (selectedCDA.Case.TransactionType == "出口保理")
                {
                    sheet.Cells[row, 1] = "进口保理商";
                    sheet.Cells[row++, 2] = selectedCDA.Case.BuyerFactor.ToString();
                    rowEnd = 22;
                }

                sheet.Cells[row, 1] = "自负额";
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

                sheet.Cells[row, 1] = "最低损失门槛";
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

                sheet.Cells[23, 1] = "备注：";

                bool isSingle = selectedCDA.Case.SellerFactorCode == selectedCDA.Case.BuyerFactorCode;
                string recoarse = selectedCDA.IsRecoarse.GetValueOrDefault() ? "有追索权" : "无追索权";
                string single = isSingle ? "单保理" : "双保理";
                string line1 = string.Empty;
                switch (selectedCDA.Case.TransactionType)
                {
                    case "国内卖方保理":
                        line1 = String.Format("（1）本业务为{0}{1}{2}（{3}）业务。", recoarse, "国内", single, selectedCDA.IsNotice);
                        break;
                    case "出口保理":
                        line1 = String.Format("（1）本业务为{0}{1}{2}（{3}）业务。", recoarse, "出口", single, selectedCDA.IsNotice);
                        break;
                    case "国内买方保理":
                        line1 = String.Format("（1）本业务为{0}{1}（{2}）业务。", recoarse, "国内", selectedCDA.IsNotice);
                        break;
                    case "进口保理":
                        line1 = String.Format("（1）本业务为{0}{1}{2}（{3}）业务。", recoarse, "进口", single, selectedCDA.IsNotice);
                        break;
                    default:
                        break;
                }

                const string line2 =
                    "（2）如应收账款债务人(以下简称买方)于到应收账款期日后 60 日内（最长不超过 60 天）仍未付款，卖方至迟于上述约定到期日后的第一个营业日通知民生银行此延迟付款。民生银行依卖方的前述通知，通知买方应收账款转让事宜及其未付余额，如卖方未尽通知责任，民生银行自动免除其承担的信用风险担保责任。";
                const string line3 = "（3）核准应收账款的销售合同有禁止转让的约定时，民生银行就该应收账款不须负任何责任。";
                const string line4 = "（4）买方未清偿核准应收账款且官方认定无力清偿时，民生银行得将所有买方尚未清偿之应收账款业已转让予民生银行事宜通知买方。";
                const string line5 = "（5）关于卖方与买方间全部契约之应收账款（不论是否为信用风险担保金额所涵盖），卖方应按到期日之顺序排列。卖方应尽善良管理人的注意义务维持其对该应收账款的权利并保存相关纪录。";

                sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 1]].WrapText = true;
                sheet.Range[sheet.Cells[26, 1], sheet.Cells[26, 1]].WrapText = true;
                sheet.Range[sheet.Cells[28, 1], sheet.Cells[28, 1]].WrapText = true;

                sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[26, 1], sheet.Cells[26, 2]].MergeCells = true;
                sheet.Range[sheet.Cells[28, 1], sheet.Cells[28, 2]].MergeCells = true;

                if (selectedCDA.IsNotice == "暗保理")
                {
                    string comment = line1 + "\n\n" + line2 + "\n\n" + line3 + "\n\n" + line4 + "\n\n" + line5;
                    if (!String.IsNullOrEmpty(selectedCDA.Comment))
                    {
                        comment += "\n\n（6）" + selectedCDA.Comment;
                    }

                    sheet.Cells[24, 1] = comment;
                    sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 1]].RowHeight = 200;
                }
                else
                {
                    string comment = line1;
                    if (!String.IsNullOrEmpty(selectedCDA.Comment))
                    {
                        comment += "\n\n（2）" + selectedCDA.Comment;
                    }

                    sheet.Cells[24, 1] = comment;
                    sheet.Range[sheet.Cells[24, 1], sheet.Cells[24, 1]].RowHeight = 45;
                }


                sheet.Cells[26, 1] = "如贵公司于本行发出本通知书后10日内未签回或于本行收到签回通知书后30日内未动用额度时，本行得停止额度之动用。贵公司嗣后如欲动用该额度，须重新提出申请。";
                sheet.Cells[28, 1] =
                    "为利益考虑，请务必确认上开买方系贵公司预定交易之对象，本保理额度通知书取代先前同一买方之保理额度通知书及先前所有贵公司与本合同相关保理额度通知书中之最高保理预付款额度。";


                sheet.Range[sheet.Cells[26, 1], sheet.Cells[26, 2]].RowHeight = 40;
                sheet.Range[sheet.Cells[28, 1], sheet.Cells[28, 2]].RowHeight = 40;

                sheet.Cells[30, 2] = selectedCDA.Case.OwnerDepartment.Location.LocationName == "北京"
                                         ? String.Format("中国民生银行股份有限公司总行营业部")
                                         : String.Format("中国民生银行股份有限公司{0}分行",
                                                         selectedCDA.Case.OwnerDepartment.Location.LocationName);

                sheet.Cells[31, 2] = String.Format("日期：{0:yyyy}年 {0:MM}月 {0:dd}日", selectedCDA.CDASignDate);
                sheet.Range[sheet.Cells[30, 2], sheet.Cells[31, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;

                sheet.Cells[33, 1] = "我公司知晓并同意上述保理额度通知书内容。";

                sheet.Cells[35, 2] = selectedCDA.SellerName;
                sheet.Cells[36, 2] = "公司印鉴          ";
                sheet.Cells[37, 2] = String.Format("日期:      年    月    日");
                sheet.Range[sheet.Cells[35, 2], sheet.Cells[37, 2]].HorizontalAlignment = XlHAlign.xlHAlignRight;


                sheet.UsedRange.Font.Name = "仿宋_GB2312";
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
                MessageBoxEx.Show("更新额度通知书状态失败: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            MessageBoxEx.Show("更新额度通知书状态成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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