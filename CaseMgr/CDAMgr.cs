//-----------------------------------------------------------------------
// <copyright file="CDAMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using System.Drawing;
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
            ControlUtil.SetDoubleBuffered(this.dgvCDAs);

            this.opCDAType = opCDAType;

            if (this.opCDAType == OpCDAType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                this.QueryCDAs(null, null);
            }
            else if (this.opCDAType == OpCDAType.REPORT)
            {
                var queryResult = from cda in App.Current.DbContext.CDAs
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

        #region Methods (13)

        // Private Methods (13) 

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
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvCDAs.SelectedRows)
            {
                CDA cda = (CDA)this.bs.List[row.Index];
                cda.CheckStatus = "已复核";
                cda.CheckUserName = App.Current.CurUser.Name;
                cda.CheckDate = DateTime.Now.Date;
                cda.CDAStatus = "已审核未下发";
            }
            App.Current.DbContext.SubmitChanges();
        }

        /// <summary>
        /// Delete selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCDA(object sender, System.EventArgs e)
        {
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
            foreach (InvoiceAssignBatch assignBatch in cda.InvoiceAssignBatches)
            {
                App.Current.DbContext.Invoices.DeleteAllOnSubmit(assignBatch.Invoices);
            }
            App.Current.DbContext.InvoiceAssignBatches.DeleteAllOnSubmit(cda.InvoiceAssignBatches);
            App.Current.DbContext.InvoiceFinanceBatches.DeleteAllOnSubmit(cda.InvoiceFinanceBatches);
            foreach (InvoicePaymentBatch paymentBatch in cda.InvoicePaymentBatches)
            {
                foreach (InvoicePaymentLog paymentLog in paymentBatch.InvoicePaymentLogs)
                {
                    if (paymentLog.CreditNote != null)
                    {
                        App.Current.DbContext.CreditNotes.DeleteOnSubmit(paymentLog.CreditNote);
                    }
                }
                App.Current.DbContext.InvoicePaymentLogs.DeleteAllOnSubmit(paymentBatch.InvoicePaymentLogs);
            }
            App.Current.DbContext.InvoicePaymentBatches.DeleteAllOnSubmit(cda.InvoicePaymentBatches);
            foreach (InvoiceRefundBatch refundBatch in cda.InvoiceRefundBatches)
            {
                App.Current.DbContext.InvoiceRefundLogs.DeleteAllOnSubmit(refundBatch.InvoiceRefundLogs);
            }
            App.Current.DbContext.InvoiceRefundBatches.DeleteAllOnSubmit(cda.InvoiceRefundBatches);
            App.Current.DbContext.CDAs.DeleteOnSubmit(cda);
            try
            {
                App.Current.DbContext.SubmitChanges();
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

            var queryResult =
                from cda in App.Current.DbContext.CDAs
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
                 (status != string.Empty ? cda.CheckStatus == status : true)
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
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in this.dgvCDAs.SelectedRows)
            {
                CDA cda = (CDA)this.bs.List[row.Index];
                cda.CheckStatus = "复核未通过";
                cda.CheckUserName = App.Current.CurUser.Name;
                cda.CheckDate = DateTime.Now.Date;
            }
            App.Current.DbContext.SubmitChanges();
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
            sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 2]).MergeCells = true;
            sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells[1, 1] = "中国民生银行保理额度通知书 ";

            sheet.Cells[3, 1] = String.Format("贵公司（{0}公司）前洽本行办理保理业务并签立保理服务合同", selectedCDA.SellerName);
            sheet.Cells[4, 1] = String.Format("(合同编号:第[ {0} ]号 ), 经本行评估后,核定额度如下:", selectedCDA.Case.SellerClient.Contract.ContractCode);

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
                sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ({2})", selectedCDA.CreditCoverCurr, selectedCDA.CreditCover, TypeUtil.ConverToChineseMoney(selectedCDA.CreditCover));
            }
            else
            {
                sheet.Cells[row++, 2] = "0";
            }

            sheet.Cells[row, 1] = "信用风险承担比例";
            sheet.Cells[row++, 2] = String.Format("{0:P}", selectedCDA.PUGProportion.GetValueOrDefault());
            sheet.Cells[row, 1] = "信用风险额度有效期限";
            if (selectedCDA.CreditCoverPeriodBegin.HasValue)
            {
                sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 - {1:yyyy}年{1:MM}月{1:dd}日", selectedCDA.CreditCoverPeriodBegin, selectedCDA.CreditCoverPeriodEnd);
            }
            else
            {
                sheet.Cells[row++, 2] = "无";
            }
            sheet.Cells[row, 1] = "保理预付款额度";
            if (selectedCDA.FinanceLine.HasValue)
            {
                sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ({2})", selectedCDA.FinanceLineCurr, selectedCDA.FinanceLine, TypeUtil.ConverToChineseMoney(selectedCDA.FinanceLine));
            }
            else
            {
                sheet.Cells[row++, 2] = "0";
            }

            sheet.Cells[row, 1] = "预付款额度有效期限";
            if (selectedCDA.FinanceLinePeriodBegin.HasValue)
            {
                sheet.Cells[row++, 2] = String.Format("{0:yyyy}年{0:MM}月{0:dd}日 - {1:yyyy}年{1:MM}月{1:dd}日", selectedCDA.FinanceLinePeriodBegin, selectedCDA.FinanceLinePeriodEnd);
            }
            else
            {
                sheet.Cells[row++, 2] = "无";
            }

            sheet.Cells[row, 1] = "最高保理预付款额度";
            ClientCreditLine creditLine = selectedCDA.Case.SellerClient.FinanceCreditLine;
            if (creditLine != null)
            {
                sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ({2})", creditLine.CreditLineCurrency, creditLine.CreditLine, TypeUtil.ConverToChineseMoney(creditLine.CreditLine));
            }

            sheet.Cells[row, 1] = "预付比例";
            sheet.Cells[row++, 2] = String.Format("{0:P}", selectedCDA.FinanceProportion);
            sheet.Cells[row, 1] = "保理费率";
            sheet.Cells[row++, 2] = String.Format("{0:P}", selectedCDA.Price.GetValueOrDefault());
            sheet.Cells[row, 1] = "单据处理费";
            if (selectedCDA.HandFee.HasValue)
            {
                sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", selectedCDA.HandFeeCurr, selectedCDA.HandFee);
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
                sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", selectedCDA.CreditCoverCurr, selectedCDA.Deductibles);
            }
            else
            {
                sheet.Cells[row++, 2] = "0";
            }

            sheet.Cells[row, 1] = "最低损失门槛";
            if (selectedCDA.LossThreshold.HasValue)
            {
                sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", selectedCDA.CreditCoverCurr, selectedCDA.LossThreshold);
            }
            else
            {
                sheet.Cells[row++, 2] = "0";
            }

            sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[20, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignDistributed;
            sheet.get_Range(sheet.Cells[6, 2], sheet.Cells[20, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[20, 2]).Borders.LineStyle = 1;
            sheet.get_Range(sheet.Cells[6, 1], sheet.Cells[20, 2]).WrapText = true;

            sheet.get_Range(sheet.Cells[22, 1], sheet.Cells[22, 2]).MergeCells = true;
            sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 2]).MergeCells = true;
            sheet.get_Range(sheet.Cells[22, 1], sheet.Cells[22, 1]).WrapText = true;
            sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 1]).WrapText = true;

            sheet.Cells[22, 1] = String.Format("备注：{0}", selectedCDA.Comment);
            sheet.Cells[24, 1] = "如贵公司于本行发出本通知书后10日内未签回或于本行收到签回通知书后30日内未动用额度时，本行得停止额度之动用。贵公司嗣后如欲动用该额度，须重新提出申请。";

            sheet.Cells[26, 1] = "";
            sheet.Cells[26, 2] = "";
            sheet.Cells[27, 1] = "客户经理";
            sheet.Cells[27, 2] = "                        保理部门主管";
            sheet.Cells[28, 1] = "日期： 年   月   日";
            sheet.Cells[28, 2] = "                        日期： 年   月   日";

            sheet.Cells[30, 1] = "同意并签回";

            sheet.Cells[32, 1] = selectedCDA.SellerName;
            sheet.Cells[33, 1] = "客户";
            sheet.Cells[33, 2] = "                        日期： 年   月   日";

            sheet.UsedRange.Font.Name = "仿宋";
            sheet.UsedRange.Font.Size = 12;
            sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).Font.Size = 20;

            sheet.get_Range("A1", Type.Missing).ColumnWidth = 30;
            sheet.get_Range("B1", Type.Missing).ColumnWidth = 60;

            foreach (Range range in sheet.UsedRange.Rows)
            {
                range.EntireRow.AutoFit();
            }

            app.Visible = true;
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
        /// Update selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void UpdateCDA(object sender, System.EventArgs e)
        {
            if (this.dgvCDAs.SelectedRows.Count == 0)
            {
                return;
            }

            CDA selectedCDA = (CDA)this.bs.List[this.dgvCDAs.SelectedRows[0].Index];
            if (selectedCDA != null)
            {
                CDADetail cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.UPDATE_CDA);
                cdaDetail.ShowDialog(this);
            }
        }

        #endregion Methods
    }
}
