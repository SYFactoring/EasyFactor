//-----------------------------------------------------------------------
// <copyright file="CDAMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class CDAMgr : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpCDAType opCDAType;

        private DBDataContext context;

        #endregion Fields

        #region Enums (1)

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
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the CDAMgr class.
        /// </summary>
        public CDAMgr(OpCDAType opCDAType)
        {
            this.InitializeComponent();
            this.dgvCDAs.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvCDAs.DataSource = this.bs;
            this.opCDAType = opCDAType;
            ControlUtil.SetDoubleBuffered(this.dgvCDAs);

            this.UpdateContextMenu();
            this.context = new DBDataContext();

            if (this.opCDAType == OpCDAType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                this.QueryCDAs(null, null);
            }
            else if (this.opCDAType == OpCDAType.REPORT)
            {
                var queryResult = from cda in context.CDAs
                                  where
                                      cda.CDAStatus == "已审核未下发"
                                      && (cda.Case.TransactionType == "国内卖方保理" || cda.Case.TransactionType == "国内信保保理" || cda.Case.TransactionType == "出口保理" || cda.Case.TransactionType == "国际信保保理")
                                  select cda;

                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
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
        /// Gets or sets selected CDA
        /// </summary>
        public CDA Selected
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods (14)

        // Private Methods (14) 

        /// <summary>
        /// Event handler when cell double clicked
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OwnerForm == null)
            {
                this.DetailCDA(sender, e);
            }
            else
            {
                this.SelectCDA(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CDA_APPROVE))
            {
                return;
            }

            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA cda = (CDA)this.bs.List[this.dgvCDAs.SelectedRows[0].Index];
            if (MessageBox.Show("是否确认复核通过该额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cda.CDAStatus = ConstStr.CDA.CHECKED;
            cda.CheckUserName = App.Current.CurUser.Name;
            cda.CheckDate = DateTime.Now.Date;

            context.CDAs.Attach(cda);
            context.SubmitChanges();
        }

        /// <summary>
        /// Delete selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCDA(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                return;
            }

            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA cda = (CDA)this.bs.List[this.dgvCDAs.SelectedRows[0].Index];

            if (MessageBox.Show("是否打算删除额度通知书: " + cda.CDACode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            context.CDAs.DeleteOnSubmit(cda);
            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBox.Show("不能删除此额度通知书: " + e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBox.Show("数据删除成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCDAs.Rows.RemoveAt(dgvCDAs.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Show detail info of selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailCDA(object sender, System.EventArgs e)
        {
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA selectedCDA = (CDA)this.bs.List[this.dgvCDAs.SelectedRows[0].Index];
            CDADetail cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.DETAIL_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCDAs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = this.dgvCDAs.Columns[e.ColumnIndex];
            if (column == colIsRecoarse)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    bool result = (bool)originalData;
                    if (result)
                    {
                        e.Value = "Y";
                    }
                    else
                    {
                        e.Value = "N";
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCDAs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.bs.List.Count; i++)
            {
                CDA cda = (CDA)this.bs.List[i];
                if (cda.CreditCoverPeriodEnd < DateTime.Now.Date)
                {
                    this.dgvCDAs["colCreditCoverPeriodEnd", i].Style.BackColor = Color.Red;
                }
                if (cda.FinanceLinePeriodEnd < DateTime.Now.Date)
                {
                    this.dgvCDAs["colFinanceLinePeriodEnd", i].Style.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCDAs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.dgvCDAs.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvCDAs.RowHeadersDefaultCellStyle.Font, rectangle, dgvCDAs.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Create a new CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void NewCDA(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                return;
            }

            CDADetail cdaDetail = new CDADetail(CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCDAs(object sender, EventArgs e)
        {
            string buyerName = tbBuyerName.Text;
            string sellerName = tbSellerName.Text;
            string factorName = tbFactorName.Text;
            string contractCode = tbContractCode.Text;
            string status = this.cbCheckStatus.Text;
            string createUserName = this.tbCreateUserName.Text;

            var queryResult =
                from cda in context.CDAs
                let contracts = cda.Case.SellerClient.Contracts
                where contractCode == string.Empty ? true : contracts.Any(con => con.ContractCode.Contains(contractCode))
                let seller = cda.Case.SellerClient
                where seller.ClientNameCN.Contains(sellerName) || seller.ClientNameEN.Contains(sellerName)
                let buyer = cda.Case.BuyerClient
                where buyer.ClientNameCN.Contains(buyerName) || buyer.ClientNameEN.Contains(buyerName)
                let sellerfactor = cda.Case.SellerFactor
                where sellerfactor.CompanyNameCN.Contains(factorName) || sellerfactor.CompanyNameEN.Contains(factorName)
                let buyerfactor = cda.Case.BuyerFactor
                where buyerfactor.CompanyNameCN.Contains(factorName) || buyerfactor.CompanyNameEN.Contains(factorName)
                where
                 (status != string.Empty ? cda.CDAStatus == status : true)
                 && cda.CreateUserName.Contains(createUserName)
                select cda;

            this.bs.DataSource = queryResult;
            this.lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reject(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CDA_APPROVE))
            {
                return;
            }

            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA cda = (CDA)this.bs.List[this.dgvCDAs.SelectedRows[0].Index];
            if (MessageBox.Show("是否确认复核退回该额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cda.CDAStatus = ConstStr.CDA.REJECT;
            cda.CheckUserName = App.Current.CurUser.Name;
            cda.CheckDate = DateTime.Now.Date;

            context.CDAs.Attach(cda);
            context.SubmitChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportCDA(object sender, EventArgs e)
        {
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA selectedCDA = (CDA)this.bs.List[this.dgvCDAs.SelectedRows[0].Index];

            ApplicationClass app = new ApplicationClass() { Visible = false };
            if (app == null)
            {
                MessageBox.Show("Excel 程序无法启动!", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Worksheet sheet = (Worksheet)app.Workbooks.Add(true).Sheets[1];

            try
            {
                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[1, 1] = "中国民生银行保理额度通知书 ";

                sheet.Cells[3, 1] = String.Format("贵公司（{0}公司）前洽本行办理保理业务并签立保理服务合同", selectedCDA.SellerName);
                if (selectedCDA.Case.SellerClient.Contract != null)
                {
                    sheet.Cells[4, 1] = String.Format("(合同编号:第[ {0} ]号 ), 经本行评估后,核定额度如下:", selectedCDA.Case.SellerClient.Contract.ContractCode);
                }
                else
                {
                    sheet.Cells[4, 1] = String.Format("(合同编号:第[  ]号 ), 经本行评估后,核定额度如下:");
                }

                int row = 6;
                sheet.Cells[row, 1] = "买方名称";
                sheet.Cells[row++, 2] = selectedCDA.BuyerName;
                sheet.Cells[row, 1] = "买方地址";
                sheet.Cells[row++, 2] = selectedCDA.Case.BuyerClient.AddressCN == string.Empty ? selectedCDA.Case.BuyerClient.AddressEN : selectedCDA.Case.BuyerClient.AddressCN;
                sheet.Cells[row, 1] = "付款条件";
                sheet.Cells[row++, 2] = selectedCDA.PaymentTerms;
                sheet.Cells[row, 1] = "信用风险额度";
                if (selectedCDA.CreditCover.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）", TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr), selectedCDA.CreditCover, TypeUtil.ToPrintCurrencyWord(selectedCDA.CreditCoverCurr), TypeUtil.ConvertToChineseMoney(selectedCDA.CreditCover));
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "信用风险承担比例";
                sheet.Cells[row++, 2] = String.Format("{0:0%}", selectedCDA.PUGProportion.GetValueOrDefault());
                sheet.Cells[row, 1] = "信用风险额度有效期限";
                if (selectedCDA.CreditCoverPeriodBegin.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 至 {1:yyyy}年{1:MM}月{1:dd}日", selectedCDA.CreditCoverPeriodBegin, selectedCDA.CreditCoverPeriodEnd);
                }
                else
                {
                    sheet.Cells[row++, 2] = "无";
                }
                sheet.Cells[row, 1] = "保理预付款额度";
                if (selectedCDA.FinanceLine.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）", TypeUtil.ToPrintCurrency(selectedCDA.FinanceLineCurr), selectedCDA.FinanceLine, TypeUtil.ToPrintCurrencyWord(selectedCDA.FinanceLineCurr), TypeUtil.ConvertToChineseMoney(selectedCDA.FinanceLine));
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "预付款额度有效期限";
                if (selectedCDA.FinanceLinePeriodBegin.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 至 {1:yyyy}年{1:MM}月{1:dd}日", selectedCDA.FinanceLinePeriodBegin, selectedCDA.FinanceLinePeriodEnd);
                }
                else
                {
                    sheet.Cells[row++, 2] = "无";
                }

                sheet.Cells[row, 1] = "最高保理预付款额度";
                ClientCreditLine creditLine = selectedCDA.Case.SellerClient.FinanceCreditLine;
                if (creditLine != null)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} （{2}{3}）", TypeUtil.ToPrintCurrency(creditLine.CreditLineCurrency), creditLine.CreditLine, TypeUtil.ToPrintCurrencyWord(creditLine.CreditLineCurrency), TypeUtil.ConvertToChineseMoney(creditLine.CreditLine));
                }

                sheet.Cells[row, 1] = "预付比例";
                sheet.Cells[row++, 2] = String.Format("单笔融资不超过发票金额的 {0:0%}", selectedCDA.FinanceProportion);
                sheet.Cells[row, 1] = "保理费率";
                sheet.Cells[row++, 2] = String.Format("{0}的 {1:0.0%}", selectedCDA.CommissionType == "按转让金额" ? "按发票金额" : "按融资金额", selectedCDA.Price.GetValueOrDefault());
                sheet.Cells[row, 1] = "单据处理费";
                if (selectedCDA.HandFee.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2} 元 （每张发票）", TypeUtil.ToPrintCurrencyWord(selectedCDA.HandFeeCurr), selectedCDA.HandFee);
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                if (selectedCDA.Case.TransactionType == "出口保理" || selectedCDA.Case.TransactionType == "国际信保保理")
                {
                    sheet.Cells[row, 1] = "进口保理商";
                    sheet.Cells[row++, 2] = selectedCDA.Case.BuyerFactor.ToString();
                }

                sheet.Cells[row, 1] = "自负额";
                if (selectedCDA.Deductibles.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr), selectedCDA.Deductibles);
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.Cells[row, 1] = "最低损失门槛";
                if (selectedCDA.LossThreshold.HasValue)
                {
                    sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr), selectedCDA.LossThreshold);
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }

                sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[19, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignDistributed;
                sheet.get_Range(sheet.Cells[6, 2], sheet.Cells[19, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[19, 2]).Borders.LineStyle = 1;
                sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[19, 2]).WrapText = true;

                sheet.Cells[21, 1] = "备注：";
                sheet.Cells[22, 1] = selectedCDA.Comment;
                sheet.Cells[24, 1] = "如贵公司于本行发出本通知书后10日内未签回或于本行收到签回通知书后30日内未动用额度时，本行得停止额度之动用。贵公司嗣后如欲动用该额度，须重新提出申请。";
                sheet.Cells[26, 1] = "为利益考虑，请务必确认上开买方系贵公司预定交易之对象，本保理额度通知书取代先前同一买方之保理额度通知书及先前所有贵公司与本合同相关保理额度通知书中之最高保理预付款额度";

                sheet.get_Range(sheet.Cells[22, 1], sheet.Cells[22, 1]).WrapText = true;
                sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 1]).WrapText = true;
                sheet.get_Range(sheet.Cells[26, 1], sheet.Cells[26, 1]).WrapText = true;

                sheet.get_Range(sheet.Cells[22, 1], sheet.Cells[22, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[26, 1], sheet.Cells[26, 2]).MergeCells = true;

                sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 2]).RowHeight = 40;
                sheet.get_Range(sheet.Cells[26, 1], sheet.Cells[26, 2]).RowHeight = 40;

                sheet.get_Range(sheet.Cells[29, 1], sheet.Cells[29, 2]).MergeCells = true;
                sheet.Cells[29, 1] = "客户经理                                                保理部门主管";
                sheet.get_Range(sheet.Cells[30, 1], sheet.Cells[30, 2]).MergeCells = true;
                sheet.Cells[30, 1] = "日期：     年   月   日                             日期：     年   月   日";

                sheet.Cells[32, 1] = "同意并签回";

                sheet.get_Range(sheet.Cells[35, 1], sheet.Cells[35, 2]).MergeCells = true;
                sheet.Cells[35, 1] = String.Format("客户： {0,-20}   {1}", selectedCDA.SellerName, "日期：      年   月   日");

                sheet.UsedRange.Font.Name = "仿宋_GB2312";
                sheet.UsedRange.Font.Size = 12;

                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).Font.Size = 16;
                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).Font.Bold = true;
                sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[19, 1]).Font.Bold = true;

                sheet.get_Range("A1", Type.Missing).ColumnWidth = 30;
                sheet.get_Range("B1", Type.Missing).ColumnWidth = 60;

                Range contentRange = sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[19, 2]);
                foreach (Range range in contentRange)
                {
                    range.EntireRow.RowHeight = 40;
                }

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
        /// Select CDA and close the query form
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void SelectCDA(object sender, System.EventArgs e)
        {
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA selectedCDA = (CDA)this.bs.List[this.dgvCDAs.SelectedRows[0].Index];
            this.Selected = selectedCDA;
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
            if (PermUtil.ValidatePermission(Permission.CDA_UPDATE))
            {
                this.menuItemCDANew.Enabled = true;
                this.menuItemCDADelete.Enabled = true;
            }
            else
            {
                this.menuItemCDANew.Enabled = false;
                this.menuItemCDADelete.Enabled = false;
            }

            if (PermUtil.ValidatePermission(Permission.CDA_APPROVE))
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

        #endregion Methods
    }
}
