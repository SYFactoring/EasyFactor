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

        #region Methods (9)

        // Private Methods (9) 

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
                    if (MessageBox.Show("是否打算删除额度通知书: " + cdaCode, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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
                    App.Current.DbContext.InvoicePaymentBatches.DeleteAllOnSubmit(cda.InvoicePaymentBatches);
                    App.Current.DbContext.CDAs.DeleteOnSubmit(cda);
                    try
                    {
                        App.Current.DbContext.SubmitChanges();
                    }
                    catch (Exception e1)
                    {
                        isDeleteOK = false;
                        MessageBox.Show("不能删除此额度通知书: " + e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (isDeleteOK)
                    {
                        MessageBox.Show("数据删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string factorName = lblFactorName.Text;
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
                where cda.Case.SellerFactor.CompanyNameCN.Contains(factorName) || cda.Case.SellerFactor.CompanyNameEN.Contains(factorName) || cda.Case.BuyerFactor.CompanyNameCN.Contains(factorName) || cda.Case.BuyerFactor.CompanyNameEN.Contains(factorName)
                && (status != string.Empty ? cda.CheckStatus == status : true)
                select cda;

            this.bs.DataSource = queryResult;
            this.dgvCDAs.DataSource = bs;
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
