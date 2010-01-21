//-----------------------------------------------------------------------
// <copyright file="ARCaseBasic.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ARCaseBasic : UserControl
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private Case curCase;
        private OpARType opARType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpARType
        {
            /// <summary>
            /// 转让
            /// </summary>
            InvoiceAssign,

            /// <summary>
            /// 融资
            /// </summary>
            InvoiceFinance,

            /// <summary>
            /// 买方付款
            /// </summary>
            InvoiceBuyerPayment,

            /// <summary>
            /// 卖方付款
            /// </summary>
            InvoiceSellerRefund,

            /// <summary>
            /// 间接付款
            /// </summary>
            InvoiceIndirectPayment,

            /// <summary>
            /// 担保付款
            /// </summary>
            InvoiceGuaranteePayment,

            /// <summary>
            /// 卖方回购
            /// </summary>
            InvoiceSellerReassign,

            /// <summary>
            /// 贷项通知
            /// </summary>
            CreditNotePayment,
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the ARCaseBasic class
        /// </summary>
        /// <param name="opARType"></param>
        public ARCaseBasic(OpARType opARType)
        {
            this.InitializeComponent();
            this.opARType = opARType;
            UserControl uc;
            switch (opARType)
            {
                case OpARType.InvoiceAssign:
                    uc = new InvoiceAssign(this);
                    break;
                case OpARType.InvoiceFinance:
                    uc = new InvoiceFinance(this);
                    break;
                case OpARType.InvoiceBuyerPayment:
                    uc = new InvoicePayment(this, InvoicePayment.OpPaymentType.BUYER_PAYMENT);
                    break;
                case OpARType.InvoiceIndirectPayment:
                    uc = new InvoicePayment(this, InvoicePayment.OpPaymentType.INDIRECT_PAYMENT);
                    break;
                case OpARType.InvoiceSellerRefund:
                    uc = new InvoiceRefund(this, InvoiceRefund.OpRefundType.SELLER_REFUND);
                    break;
                case OpARType.InvoiceGuaranteePayment:
                    uc = new InvoicePayment(this, InvoicePayment.OpPaymentType.GUARANTEE_PAYMENT);
                    break;
                case OpARType.InvoiceSellerReassign:
                    uc = new InvoicePayment(this, InvoicePayment.OpPaymentType.SELLER_REASSIGN);
                    break;
                case OpARType.CreditNotePayment:
                    uc = new InvoicePayment(this, InvoicePayment.OpPaymentType.CREDIT_NOTE_PAYMENT);
                    break;
                default:
                    uc = new UserControl();
                    break;
            }

            uc.Dock = DockStyle.Fill;
            this.panelInvoiceMgr.Controls.Add(uc);
        }

        #endregion Constructors

        #region Methods (8)

        // Public Methods (1) 

        public void CaculateOutstanding(CDA cda)
        {
            this.tbCreditCoverOutstanding.Text = String.Format("{0:N2}", cda.CreditCoverOutstanding);
            this.tbAROutstanding.Text = String.Format("{0:N2}", cda.Case.AssignOutstanding);
            this.tbFinanceCreditLineOutstanding.Text = String.Format("{0:N2}", cda.FinanceLineOutstanding);
            this.tbFinanceOutstanding.Text = String.Format("{0:N2}", cda.Case.FinanceOutstanding);
        }
        // Private Methods (7) 

        private void DetailBuyer(object sender, EventArgs e)
        {
            if (this.curCase != null)
            {
                ClientDetail clientDetail = new ClientDetail(this.curCase.BuyerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
                clientDetail.Show();
            }
        }

        private void DetailCase(object sender, EventArgs e)
        {
            if (this.curCase != null)
            {
                CaseDetail caseDetail = new CaseDetail(this.curCase, CaseDetail.OpCaseType.DETAIL_CASE);
                caseDetail.Show();
            }
        }

        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.curCase != null)
            {
                CDA cda = this.curCase.CDAs.SingleOrDefault(c => c.CDAStatus == "已签回");
                if (cda != null)
                {
                    CDADetail cdaDetail = new CDADetail(cda, CDADetail.OpCDAType.DETAIL_CDA);
                    cdaDetail.Show();
                }
            }
        }

        private void DetailFactor(object sender, EventArgs e)
        {
            if (this.curCase != null)
            {
                Factor factor = null;
                if ("国内卖方保理".Equals(this.curCase.TransactionType) || "出口保理".Equals(this.curCase.TransactionType) || "国际信保保理".Equals(this.curCase.TransactionType) || "国内信保保理".Equals(this.curCase.TransactionType))
                {
                    factor = this.curCase.SellerFactor;
                }
                else
                {
                    factor = this.curCase.BuyerFactor;
                }

                FactorDetail factorDetail = new FactorDetail(factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
                factorDetail.Show();
            }
        }

        private void DetailSeller(object sender, EventArgs e)
        {
            if (this.curCase != null)
            {
                ClientDetail clientDetail = new ClientDetail(this.curCase.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
                clientDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillCaseBasic()
        {
            this.tbCaseCode.Text = this.curCase.CaseCode;
            this.ownerDepartmentCodeTextBox.Text = this.curCase.OwnerDepartment == null ? string.Empty : this.curCase.OwnerDepartment.ToString();
            this.transactionTypeTextBox.Text = this.curCase.TransactionType;
            this.invoiceCurrencyTextBox.Text = this.curCase.InvoiceCurrency;
            this.sellerEDICodeTextBox.Text = this.curCase.SellerCode;
            this.sellerNameTextBox.Text = this.curCase.SellerClient == null ? string.Empty : this.curCase.SellerClient.ToString();
            this.buyerEDICodeTextBox.Text = this.curCase.BuyerCode;
            this.tbNetPaymentTerm.Text = String.Format("{0:G}", this.curCase.NetPaymentTerm);
            this.buyerNameTextBox.Text = this.curCase.BuyerClient == null ? string.Empty : this.curCase.BuyerClient.ToString();
            if ("国内卖方保理".Equals(this.curCase.TransactionType) || "出口保理".Equals(this.curCase.TransactionType) || "国际信保保理".Equals(this.curCase.TransactionType) || "国内信保保理".Equals(this.curCase.TransactionType))
            {
                if (this.curCase.SellerFactor != null)
                {
                    this.factorCodeTextBox.Text = this.curCase.SellerFactor.FactorCode;
                    this.factorNameTextBox.Text = this.curCase.SellerFactor.ToString();
                }

                this.PMTextBox.Text = this.curCase.SellerClient.PMName;
                this.RMTextBox.Text = this.curCase.SellerClient.RMName;
            }
            else
            {
                if (this.curCase.BuyerFactor != null)
                {
                    this.factorCodeTextBox.Text = this.curCase.BuyerFactor.FactorCode;
                    this.factorNameTextBox.Text = this.curCase.BuyerFactor.ToString();
                }

                this.PMTextBox.Text = this.curCase.BuyerClient.PMName;
                this.RMTextBox.Text = this.curCase.BuyerClient.RMName;
            }

            CDA cda = this.curCase.CDAs.SingleOrDefault(c => c.CDAStatus == ConstStr.CDA.SIGNED);
            if (cda != null)
            {
                this.tbCDACode.Text = cda.CDACode;
                this.tbIsNotice.Text = cda.IsNotice;
                this.isRecoarseCheckBox.Checked = cda.IsRecoarse.Value;
                this.assignTypeTextBox.Text = cda.AssignType;
                this.tbPaymentTerms.Text = cda.PaymentTerms;

                this.priceTextBox.Text = String.Format("{0:P2}", cda.Price);
                this.eFPriceTextBox.Text = String.Format("{0:P2}", cda.EFPrice);
                this.iFPriceTextBox.Text = String.Format("{0:P2}", cda.IFPrice);
                this.handFeeCurrTextBox.Text = cda.HandFeeCurr;
                this.handFeeTextBox.Text = String.Format("{0:N}", cda.HandFee);
                this.commissionTypeTextBox.Text = cda.CommissionType;

                this.creditCoverCurrTextBox.Text = cda.CreditCoverCurr;
                this.creditCoverTextBox.Text = String.Format("{0:N2}", cda.CreditCover);
                this.periodEndTextBox.Text = String.Format("{0:d}", cda.CreditCoverPeriodEnd);


                this.financeProportionTextBox.Text = String.Format("{0:P0}", cda.FinanceProportion);
                this.tbFinanceLineCurr.Text = cda.FinanceLineCurr;
                this.tbFinanceLine.Text = String.Format("{0:N2}", cda.FinanceLine);
                this.tbDueDate.Text = String.Format("{0:d}", cda.FinanceLinePeriodEnd);
                ClientCreditLine creditLine = cda.FinanceCreditLine;
                if (creditLine != null)
                {
                    this.tbHighestFinance.Text = String.Format("{0:N2}", creditLine.CreditLine);
                }

                this.CaculateOutstanding(cda);

                if (!cda.FinanceLine.HasValue && this.opARType == OpARType.InvoiceFinance)
                {
                    MessageBox.Show("本案无预付款额度，不能融资。", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Control control = this.panelInvoiceMgr.Controls[0];
                if (control is InvoiceAssign)
                {
                    (control as InvoiceAssign).CDA = cda;
                }
                else if (control is InvoiceFinance)
                {
                    (control as InvoiceFinance).CDA = cda;
                }
                else if (control is InvoicePayment)
                {
                    (control as InvoicePayment).CDA = cda;
                }
                else if (control is InvoiceRefund)
                {
                    (control as InvoiceRefund).CDA = cda;
                }
            }
            else
            {
                this.isRecoarseCheckBox.Checked = false;
                this.assignTypeTextBox.Text = string.Empty;
                Control control = this.panelInvoiceMgr.Controls[0];
                if (control is InvoiceAssign)
                {
                    (control as InvoiceAssign).ResetControlsStatus();
                }
                else if (control is InvoiceFinance)
                {
                    (control as InvoiceFinance).ResetControlsStatus();
                }
                else if (control is InvoicePayment)
                {
                    (control as InvoicePayment).ResetControlsStatus();
                }
                else if (control is InvoiceRefund)
                {
                    (control as InvoiceRefund).ResetControlsStatus();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCase(object sender, EventArgs e)
        {
            CaseMgr caseMgr = new CaseMgr(false);
            QueryForm queryForm = new QueryForm(caseMgr, "选择案件");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;
            if (curCase != null)
            {
                this.curCase = curCase;
                this.FillCaseBasic();
            }
        }

        #endregion Methods
    }
}
