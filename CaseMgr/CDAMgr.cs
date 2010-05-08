//-----------------------------------------------------------------------
// <copyright file="CDAMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;
    using Microsoft.Office.Interop.Excel;

    /// <summary>
    /// 
    /// </summary>
    public partial class CDAMgr : UserControl
    {
		#region?Fields?(2)?

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs;
        /// <summary>
        /// 
        /// </summary>
        private OpCDAType opCDAType;

		#endregion?Fields?

		#region?Enums?(1)?

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

		#endregion?Enums?

		#region?Constructors?(2)?

/// <summary>
        /// Initializes a new instance of the CDAMgr class.
        /// </summary>
        /// <param name="createUseraName"></param>
        /// <param name="CDAStatus"></param>
        public CDAMgr(string createUseraName, string CDAStatus)
            : this(OpCDAType.QUERY)
        {
            this.tbCreateUserName.Text = createUseraName;
            this.cbCheckStatus.Text = CDAStatus;
            this.QueryCDAs(null, null);
        }

        /// <summary>
        /// Initializes a new instance of the CDAMgr class.
        /// </summary>
        public CDAMgr(OpCDAType opCDAType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.dgvCDAs.AutoGenerateColumns = false;
            this.bs = new BindingSource();
            this.dgvCDAs.DataSource = this.bs;
            this.opCDAType = opCDAType;
            ControlUtil.SetDoubleBuffered(this.dgvCDAs);
            ControlUtil.AddEnterListenersForQuery(this.panelQuery.Controls, this.btnQuery);

            this.cbTransactionType.Items.Insert(0, "ȫ��");
            this.cbTransactionType.Text = "ȫ��";

            List<Location> allLocations = DB.dbml.Location.AllLocations;
            allLocations.Insert(0, new Location() { LocationCode = "00", LocationName = "ȫ��" });
            this.cbLocation.DataSource = allLocations;
            this.cbLocation.DisplayMember = "LocationName";
            this.cbLocation.ValueMember = "LocationCode";
            this.cbLocation.SelectedIndex = 0;

            this.UpdateContextMenu();

            if (this.opCDAType == OpCDAType.CHECK)
            {
                this.cbCheckStatus.Text = CDAStr.UNCHECK;
                this.QueryCDAs(null, null);
            }
            else if (this.opCDAType == OpCDAType.REPORT)
            {
                this.cbCheckStatus.Text = CDAStr.CHECKED;
            }
            else if (this.opCDAType == OpCDAType.DUE)
            {
                this.cbCheckStatus.Text = CDAStr.CHECKED;

                context = new DBDataContext();
                var queryResult = from cda in context.CDAs
                                  where
                                      cda.CDAStatus == CDAStr.CHECKED
                                      && (cda.CreditCoverPeriodEnd < DateTime.Now.Date || cda.FinanceLinePeriodEnd < DateTime.Now.Date)
                                  select cda;

                this.bs.DataSource = queryResult;
                this.lblCount.Text = String.Format("���{0}����¼", queryResult.Count());
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
        /// Gets or sets selected CDA
        /// </summary>
        public CDA Selected
        {
            get;
            set;
        }

		#endregion?Properties?

		#region?Methods?(16)?

		//?Private?Methods?(16)?

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
            if (!PermUtil.CheckPermission(Permissions.CDA_APPROVE))
            {
                return;
            }

            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            CDA cda = (CDA)this.bs.List[this.dgvCDAs.CurrentCell.RowIndex];

            if (MessageBoxEx.Show("�Ƿ�ȷ�ϸ���ͨ���ö��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cda.CDAStatus = CDAStr.CHECKED;
            cda.CheckUserName = App.Current.CurUser.Name;
            cda.CheckDate = DateTime.Now.Date;

            if (cda.Case.CaseMark == CASEStr.APPLICATION)
            {
                cda.Case.CaseMark = CASEStr.ENABLE;
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
                context.SubmitChanges();
            }
            catch (Exception e2)
            {
                MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
        /// Delete selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DeleteCDA(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            CDA cda = (CDA)this.bs.List[this.dgvCDAs.CurrentCell.RowIndex];

            if (cda.CDAStatus == CDAStr.CHECKED)
            {
                MessageBoxEx.Show("�˶��֪ͨ���Ѿ�����ˣ�����ɾ����", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBoxEx.Show("�Ƿ����ɾ�����֪ͨ��: " + cda.CDACode, MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            bool isDeleteOK = true;
            this.context.CDAs.DeleteOnSubmit(cda);

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                isDeleteOK = false;
                MessageBoxEx.Show("����ɾ���˶��֪ͨ��: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isDeleteOK)
            {
                MessageBoxEx.Show("����ɾ���ɹ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvCDAs.Rows.RemoveAt(this.dgvCDAs.CurrentCell.RowIndex);
            }
        }

        /// <summary>
        /// Show detail info of selected CDA
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void DetailCDA(object sender, System.EventArgs e)
        {
            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            CDA selectedCDA = (CDA)this.bs.List[this.dgvCDAs.CurrentCell.RowIndex];
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
            if (column == colIsRecoarse || column == colIsSigned)
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportCDAs(object sender, EventArgs e)
        {
            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            List<CDA> selectedCDAs = this.GetSelectedCDAs();
            if (selectedCDAs.Count > 0)
            {
                ExportForm form = new ExportForm(ExportForm.ExportType.EXPORT_CDAS, selectedCDAs);
                form.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<CDA> GetSelectedCDAs()
        {
            List<CDA> selectedCDAs = new List<CDA>();
            foreach (DataGridViewCell cell in this.dgvCDAs.SelectedCells)
            {
                CDA selectedCDA = (CDA)this.bs.List[cell.RowIndex];
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
        private void NewCDA(object sender, System.EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
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
            string clientName = tbClientName.Text;
            string factorName = tbFactorName.Text;
            string contractCode = tbContractCode.Text;
            string status = this.cbCheckStatus.Text;
            string transactionType = this.cbTransactionType.Text;
            string location = (string)this.cbLocation.SelectedValue;
            string createUserName = this.tbCreateUserName.Text;
            bool isCDAChecked = this.cbIsCDA.CheckState == System.Windows.Forms.CheckState.Checked;
            DateTime beginDate = String.IsNullOrEmpty(this.diBegin.Text) ? this.diBegin.MinDate : this.diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(this.diEnd.Text) ? this.diEnd.MinDate : this.diEnd.Value;

            context = new DBDataContext();

            var queryResult =
                from cda in context.CDAs
                let curCase = cda.Case
                where (transactionType == "ȫ��" ? true : curCase.TransactionType == transactionType) && (location == "00" ? true : curCase.OwnerDepartment.LocationCode == location)
                let contracts = cda.Case.SellerClient.Contracts
                where contractCode == string.Empty ? true : contracts.Any(con => con.ContractCode.Contains(contractCode))
                let seller = cda.Case.SellerClient
                let buyer = cda.Case.BuyerClient
                where seller.ClientNameCN.Contains(clientName) || seller.ClientNameEN.Contains(clientName) || buyer.ClientNameCN.Contains(clientName) || buyer.ClientNameEN.Contains(clientName)
                let sellerfactor = cda.Case.SellerFactor
                where sellerfactor.CompanyNameCN.Contains(factorName) || sellerfactor.CompanyNameEN.Contains(factorName)
                let buyerfactor = cda.Case.BuyerFactor
                where buyerfactor.CompanyNameCN.Contains(factorName) || buyerfactor.CompanyNameEN.Contains(factorName)
                where
                 (status != string.Empty ? cda.CDAStatus == status : true)
                 && cda.CreateUserName.Contains(createUserName)
                 && (isCDAChecked == true ? cda.IsSigned == isCDAChecked : true)
                 && (beginDate != this.diBegin.MinDate ? cda.CDASignDate >= beginDate : true)
                 && (endDate != this.diEnd.MinDate ? cda.CDASignDate <= endDate : true)

                select cda;

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
            if (!PermUtil.CheckPermission(Permissions.CDA_APPROVE))
            {
                return;
            }

            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            CDA cda = (CDA)this.bs.List[this.dgvCDAs.CurrentCell.RowIndex];

            if (MessageBoxEx.Show("�Ƿ�ȷ�ϸ����˻ظö��֪ͨ��", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cda.CDAStatus = CDAStr.REJECT;
            cda.CheckUserName = App.Current.CurUser.Name;
            cda.CheckDate = DateTime.Now.Date;

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
        private void ReportCDA(object sender, EventArgs e)
        {
            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            CDA selectedCDA = (CDA)this.bs.List[this.dgvCDAs.CurrentCell.RowIndex];

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

                bool isZero = false;
                if (selectedCDA.Case.TransactionType == "�����򷽱���" || selectedCDA.Case.TransactionType == "���ڱ���")
                {
                    isZero = true;
                }

                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sheet.Cells[1, 1] = "�й��������б�����֪ͨ�� ";

                sheet.Cells[3, 2] = String.Format("������ţ�{0}", selectedCDA.CaseCode);
                sheet.get_Range(sheet.Cells[3, 2], sheet.Cells[3, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

                sheet.Cells[5, 1] = String.Format("��{0}��ǰǢ���а�����ҵ��ǩ����������ͬ", selectedCDA.SellerName);
                if (selectedCDA.Case.SellerClient.Contract != null)
                {
                    sheet.Cells[6, 1] = String.Format("(��ͬ���:��[ {0} ]�� ), ������������,�˶��������:", selectedCDA.Case.SellerClient.Contract.ContractCode);
                }
                else
                {
                    sheet.Cells[6, 1] = String.Format("(��ͬ���:��[  ]�� ), ������������,�˶��������:");
                }

                int row = 8;
                sheet.Cells[row, 1] = "������";
                sheet.Cells[row++, 2] = selectedCDA.BuyerName;
                sheet.Cells[row, 1] = "�򷽵�ַ";
                sheet.Cells[row++, 2] = String.IsNullOrEmpty(selectedCDA.Case.BuyerClient.AddressCN) ? selectedCDA.Case.BuyerClient.AddressEN : selectedCDA.Case.BuyerClient.AddressCN;
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
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��", TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr), selectedCDA.CreditCover, TypeUtil.ToPrintCurrencyChinese(selectedCDA.CreditCoverCurr), TypeUtil.ConvertToChineseMoney(selectedCDA.CreditCover));
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
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}��{0:MM}��{0:dd}�� �� {1:yyyy}��{1:MM}��{1:dd}��", selectedCDA.CreditCoverPeriodBegin, selectedCDA.CreditCoverPeriodEnd);
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
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��", TypeUtil.ToPrintCurrency(selectedCDA.FinanceLineCurr), selectedCDA.FinanceLine, TypeUtil.ToPrintCurrencyChinese(selectedCDA.FinanceLineCurr), TypeUtil.ConvertToChineseMoney(selectedCDA.FinanceLine));
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
                        sheet.Cells[row++, 2] = String.Format("{0:yyyy}��{0:MM}��{0:dd}�� �� {1:yyyy}��{1:MM}��{1:dd}��", selectedCDA.FinanceLinePeriodBegin, selectedCDA.FinanceLinePeriodEnd);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "��";
                }

                sheet.Cells[row, 1] = "��߱���Ԥ������";
                ClientCreditLine creditLine = selectedCDA.Case.SellerClient.FinanceCreditLine;
                if (creditLine != null)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} ��{2}{3}��", TypeUtil.ToPrintCurrency(creditLine.CreditLineCurrency), creditLine.CreditLine, TypeUtil.ToPrintCurrencyChinese(creditLine.CreditLineCurrency), TypeUtil.ConvertToChineseMoney(creditLine.CreditLine));
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
                    sheet.Cells[row++, 2] = String.Format("�������ʲ�������Ʊ���� {0:p0}", selectedCDA.FinanceProportion);
                }

                sheet.Cells[row, 1] = "�������";
                if (isZero)
                {
                    sheet.Cells[row++, 2] = String.Format("{0}�� {1:p4}�����򷽳е�", selectedCDA.CommissionType == "��ת�ý��" ? "����Ʊ���" : "�����ʽ��", selectedCDA.Price.GetValueOrDefault());
                }
                else
                {
                    sheet.Cells[row++, 2] = String.Format("{0}�� {1:p4}", selectedCDA.CommissionType == "��ת�ý��" ? "����Ʊ���" : "�����ʽ��", selectedCDA.Price.GetValueOrDefault());
                }

                sheet.Cells[row, 1] = "���ݴ����";
                if (selectedCDA.HandFee.HasValue)
                {
                    if (isZero)
                    {
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2} Ԫ ��ÿ�ŷ�Ʊ��", TypeUtil.ToPrintCurrencyChinese(selectedCDA.HandFeeCurr), selectedCDA.HandFee);
                    }
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
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr), selectedCDA.Deductibles);
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
                        sheet.Cells[row++, 2] = "0";
                    }
                    else
                    {
                        sheet.Cells[row++, 2] = String.Format("{0} {1:N2}", TypeUtil.ToPrintCurrency(selectedCDA.CreditCoverCurr), selectedCDA.LossThreshold);
                    }
                }
                else
                {
                    sheet.Cells[row++, 2] = "0";
                }


                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[rowEnd, 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignDistributed;
                sheet.get_Range(sheet.Cells[8, 2], sheet.Cells[rowEnd, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[rowEnd, 2]).Borders.LineStyle = 1;
                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[rowEnd, 2]).WrapText = true;

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

                string line2 = "��2����Ӧ���˿�ծ����(���¼����)�ڵ�Ӧ���˿����պ�  ���ڣ��������  �죩��δ�����������������Լ�������պ�ĵ�һ��Ӫҵ��֪ͨ�������д��ӳٸ������������������ǰ��֪ͨ��֪ͨ��Ӧ���˿�ת�����˼���δ����������δ��֪ͨ���Σ����������Զ������е������÷��յ������Ρ�";
                string line3 = "��3����׼Ӧ���˿�����ۺ�ͬ�н�ֹת�õ�Լ��ʱ���������о͸�Ӧ���˿�븺�κ����Ρ�";
                string line4 = "��4����δ�峥��׼Ӧ���˿��ҹٷ��϶������峥ʱ���������еý���������δ�峥֮Ӧ���˿�ҵ��ת����������������֪ͨ�򷽡�";
                string line5 = "��5�������������򷽼�ȫ����Լ֮Ӧ���˿�����Ƿ�Ϊ���÷��յ�����������ǣ�������Ӧ��������֮˳�����С�����Ӧ�����������˵�ע������ά����Ը�Ӧ���˿��Ȩ����������ؼ�¼��";

                sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 1]).WrapText = true;
                sheet.get_Range(sheet.Cells[26, 1], sheet.Cells[26, 1]).WrapText = true;
                sheet.get_Range(sheet.Cells[28, 1], sheet.Cells[28, 1]).WrapText = true;

                sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[26, 1], sheet.Cells[26, 2]).MergeCells = true;
                sheet.get_Range(sheet.Cells[28, 1], sheet.Cells[28, 2]).MergeCells = true;

                if (selectedCDA.IsNotice == "������")
                {
                    string comment = line1 + "\n\n" + line2 + "\n\n" + line3 + "\n\n" + line4 + "\n\n" + line5;
                    if (!String.IsNullOrEmpty(selectedCDA.Comment))
                    {
                        comment += "\n\n��6��" + selectedCDA.Comment;
                    }

                    sheet.Cells[24, 1] = comment;
                    sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 1]).RowHeight = 200;
                }
                else
                {
                    string comment = line1;
                    if (!String.IsNullOrEmpty(selectedCDA.Comment))
                    {
                        comment += "\n\n��2��" + selectedCDA.Comment;
                    }

                    sheet.Cells[24, 1] = comment;
                    sheet.get_Range(sheet.Cells[24, 1], sheet.Cells[24, 1]).RowHeight = 45;
                }


                sheet.Cells[26, 1] = "���˾�ڱ��з�����֪ͨ���10����δǩ�ػ��ڱ����յ�ǩ��֪ͨ���30����δ���ö��ʱ�����е�ֹͣ���֮���á���˾�ú��������øö�ȣ�������������롣";
                sheet.Cells[28, 1] = "Ϊ���濼�ǣ������ȷ���Ͽ���ϵ��˾Ԥ������֮���󣬱�������֪ͨ��ȡ����ǰͬһ��֮������֪ͨ�鼰��ǰ���й�˾�뱾��ͬ��ر�����֪ͨ����֮��߱���Ԥ�����ȡ�";


                sheet.get_Range(sheet.Cells[26, 1], sheet.Cells[26, 2]).RowHeight = 40;
                sheet.get_Range(sheet.Cells[28, 1], sheet.Cells[28, 2]).RowHeight = 40;

                sheet.Cells[30, 2] = String.Format("�й��������йɷ����޹�˾{0}����", selectedCDA.Case.OwnerDepartment.Location.LocationName);
                sheet.Cells[31, 2] = String.Format("���ڣ�{0:yyyy}�� {0:MM}�� {0:dd}��", selectedCDA.CDASignDate);
                sheet.get_Range(sheet.Cells[30, 2], sheet.Cells[31, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

                sheet.Cells[33, 1] = "�ҹ�˾֪����ͬ������������֪ͨ�����ݡ�";

                sheet.Cells[35, 2] = selectedCDA.SellerName;
                sheet.Cells[36, 2] = "��˾ӡ��          ";
                sheet.Cells[37, 2] = String.Format("����:      ��    ��    ��");
                sheet.get_Range(sheet.Cells[35, 2], sheet.Cells[37, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;


                sheet.UsedRange.Font.Name = "����_GB2312";
                sheet.UsedRange.Font.Size = 12;

                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).Font.Size = 16;
                sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, 1]).Font.Bold = true;
                sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[rowEnd, 1]).Font.Bold = true;

                sheet.get_Range("A1", Type.Missing).ColumnWidth = 30;
                sheet.get_Range("B1", Type.Missing).ColumnWidth = 60;

                Range contentRange = sheet.get_Range(sheet.Cells[8, 1], sheet.Cells[21, 2]);
                foreach (Range range in contentRange)
                {
                    range.EntireRow.RowHeight = 35;
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
            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            this.Selected = (CDA)this.bs.List[this.dgvCDAs.CurrentCell.RowIndex]; ;
            if (this.OwnerForm != null)
            {
                this.OwnerForm.DialogResult = DialogResult.Yes;
                this.OwnerForm.Close();
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

            if (this.dgvCDAs.CurrentCell == null)
            {
                return;
            }

            CDA cda = (CDA)this.bs.List[this.dgvCDAs.CurrentCell.RowIndex];
            cda.AdjustCDAStatus();

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("���¶��֪ͨ��״̬ʧ��: " + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.menuItemCDANew.Enabled = true;
                this.menuItemCDADelete.Enabled = true;
            }
            else
            {
                this.menuItemCDANew.Enabled = false;
                this.menuItemCDADelete.Enabled = false;
            }

            if (PermUtil.ValidatePermission(Permissions.CDA_APPROVE))
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
