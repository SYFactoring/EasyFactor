﻿//-----------------------------------------------------------------------
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

    /// <summary>
    /// 
    /// </summary>
    public partial class CDAMgr : UserControl
    {
		#region Fields (2) 

        /// <summary>
        /// 
        /// </summary>
        private BindingSource bs = new BindingSource();
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
            CHECK
        }

		#endregion Enums 

		#region Constructors (1) 

/// <summary>
        /// Initializes a new instance of the CDAMgr class.
        /// </summary>
        public CDAMgr(OpCDAType opCDAType)
        {
            InitializeComponent();
            this.dgvCDAs.AutoGenerateColumns = false;
            this.dgvCDAs.DataSource = bs;
            ControlUtil.SetDoubleBuffered(this.dgvCDAs);

            this.opCDAType = opCDAType;

            if (opCDAType == OpCDAType.CHECK)
            {
                this.cbCheckStatus.Text = "未复核";
                this.bs.DataSource = App.Current.DbContext.CDAs.Where(c => c.CheckStatus == "未复核");
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

		#region Methods (11) 

		// Private Methods (11) 

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

            string cdaCode = (String)dgvCDAs["colCDACode", dgvCDAs.SelectedRows[0].Index].Value;
            if (cdaCode != null)
            {
                CDA cda = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                if (cda != null)
                {
                    if (MessageBox.Show("是否打算删除额度通知书: " + cdaCode, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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

            string cdaCode = (String)dgvCDAs["colCDACode", dgvCDAs.SelectedRows[0].Index].Value;
            if (cdaCode != null)
            {
                CDA selectedCDA = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                if (selectedCDA != null)
                {
                    CDADetail cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.DETAIL_CDA);
                    cdaDetail.ShowDialog(this);
                }
            }
        }

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

        private void dgvCDAs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.dgvCDAs.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvCDAs.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvCDAs.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
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
                where seller.ClientNameCN.Contains(sellerName) || seller.ClientNameEN_1.Contains(sellerName) || seller.ClientNameEN_2.Contains(sellerName)
                let buyer = cda.Case.BuyerClient
                where buyer.ClientNameCN.Contains(buyerName) || buyer.ClientNameEN_1.Contains(buyerName) || buyer.ClientNameEN_2.Contains(buyerName)
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

            string cdaCode = (String)dgvCDAs["colCDACode", dgvCDAs.SelectedRows[0].Index].Value;
            if (cdaCode != null)
            {
                CDA selectedCDA = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                if (selectedCDA != null)
                {
                    this.Selected = selectedCDA;
                    if (this.OwnerForm != null)
                    {
                        this.OwnerForm.DialogResult = DialogResult.Yes;
                        this.OwnerForm.Close();
                    }
                }
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

            string cdaCode = (String)dgvCDAs["colCDACode", dgvCDAs.SelectedRows[0].Index].Value;
            if (cdaCode != null)
            {
                CDA selectedCDA = App.Current.DbContext.CDAs.SingleOrDefault(c => c.CDACode == cdaCode);
                if (selectedCDA != null)
                {
                    CDADetail cdaDetail = new CDADetail(selectedCDA, CDADetail.OpCDAType.UPDATE_CDA);
                    cdaDetail.ShowDialog(this);
                }
            }
        }

		#endregion Methods 
    }
}
