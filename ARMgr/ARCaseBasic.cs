//-----------------------------------------------------------------------
// <copyright file="ARCaseBasic.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    public enum OpARType
    {
        /// <summary>
        /// 转让
        /// </summary>
        ASSIGN,

        /// <summary>
        /// 融资
        /// </summary>
        FINANCE,

        /// <summary>
        /// 买方付款
        /// </summary>
        BUYER_PAYMENT,

        /// <summary>
        /// 卖方还款
        /// </summary>
        SELLER_REFUND,

        /// <summary>
        /// 间接付款
        /// </summary>
        INDIRECT_PAYMENT,

        /// <summary>
        /// 担保付款
        /// </summary>
        GUARANTEE_PAYMENT,

        /// <summary>
        /// 卖方回购
        /// </summary>
        SELLER_REASSIGN,

        /// <summary>
        /// 贷项通知
        /// </summary>
        CREDIT_NOTE,
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class ARCaseBasic : UserControl
    {


        #region?Fields?(2)?

        /// <summary>
        /// 
        /// </summary>
        private Case _case;
        /// <summary>
        /// 
        /// </summary>
        private OpARType opARType;

        #endregion?Fields?


        #region?Constructors?(1)?

        /// <summary>
        /// Initializes a new instance of the ARCaseBasic class
        /// </summary>
        /// <param name="opARType"></param>
        public ARCaseBasic(OpARType opARType)
        {
            this.InitializeComponent();

            this.opARType = opARType;
            switch (opARType)
            {
                case OpARType.ASSIGN:
                    this.InvoiceControl = new InvoiceAssign(this);
                    break;
                case OpARType.FINANCE:
                    this.InvoiceControl = new InvoiceFinance(this);
                    break;
                case OpARType.BUYER_PAYMENT:
                    this.InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.BUYER_PAYMENT);
                    break;
                case OpARType.INDIRECT_PAYMENT:
                    this.InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.INDIRECT_PAYMENT);
                    break;
                case OpARType.GUARANTEE_PAYMENT:
                    this.InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.GUARANTEE_PAYMENT);
                    break;
                case OpARType.SELLER_REASSIGN:
                    this.InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.SELLER_REASSIGN);
                    break;
                case OpARType.CREDIT_NOTE:
                    this.InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.CREDIT_NOTE_PAYMENT);
                    break;
                case OpARType.SELLER_REFUND:
                    this.InvoiceControl = new InvoiceRefund(this, InvoiceRefund.OpRefundType.SELLER_REFUND);
                    break;
                default:
                    this.InvoiceControl = new UserControl();
                    break;
            }

            this.InvoiceControl.Dock = DockStyle.Fill;
            this.panelInvoiceMgr.Controls.Add(this.InvoiceControl);
        }

        #endregion?Constructors?


        #region?Properties?(2)?

        /// <summary>
        /// Gets or sets
        /// </summary>
        public Case Case
        {
            get
            {
                return this._case;
            }
            set
            {
                this._case = value;
                this.FillCaseBasic();
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public UserControl InvoiceControl
        {
            get;
            set;
        }

        #endregion?Properties?


        #region?Methods?(8)?

        //?Public?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedCase"></param>
        public void CaculateOutstanding(Case selectedCase)
        {
            if (selectedCase == null)
            {
                return;
            }

            CDA cda = selectedCase.ActiveCDA;
            if (cda != null)
            {
                this.tbCreditCoverOutstanding.Text = String.Format("{0:N2}", cda.CreditCoverOutstanding);
                this.tbAROutstanding.Text = String.Format("{0:N2}", cda.Case.AssignOutstanding);
                this.tbFinanceCreditLineOutstanding.Text = String.Format("{0:N2}", cda.FinanceLineOutstanding);
                this.tbFinanceOutstanding.Text = String.Format("{0:N2}", cda.Case.FinanceOutstanding);
            }
            else
            {
                this.tbCreditCoverOutstanding.Text = String.Empty;
                this.tbAROutstanding.Text = String.Empty;
                this.tbFinanceCreditLineOutstanding.Text = String.Empty;
                this.tbFinanceOutstanding.Text = String.Empty;
            }
        }
        //?Private?Methods?(7)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBuyer(object sender, EventArgs e)
        {
            if (this.Case != null)
            {
                ClientDetail clientDetail = new ClientDetail(this.Case.BuyerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
                clientDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            if (this.Case != null)
            {
                CaseDetail caseDetail = new CaseDetail(this.Case, CaseDetail.OpCaseType.DETAIL_CASE);
                caseDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCDA(object sender, EventArgs e)
        {
            if (this.Case != null)
            {
                CDA cda = this.Case.ActiveCDA;
                if (cda != null)
                {
                    CDADetail cdaDetail = new CDADetail(cda, CDADetail.OpCDAType.DETAIL_CDA);
                    cdaDetail.Show();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailFactor(object sender, EventArgs e)
        {
            if (this.Case != null)
            {
                FactorDetail factorDetail = new FactorDetail(this.Case.Factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
                factorDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailSeller(object sender, EventArgs e)
        {
            if (this.Case != null)
            {
                ClientDetail clientDetail = new ClientDetail(this.Case.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
                clientDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillCaseBasic()
        {
            this.tbCaseCode.Text = this.Case.CaseCode;
            this.ownerDepartmentCodeTextBox.Text = this.Case.OwnerDepartment == null ? string.Empty : this.Case.OwnerDepartment.ToString();
            this.transactionTypeTextBox.Text = this.Case.TransactionType;
            this.invoiceCurrencyTextBox.Text = this.Case.InvoiceCurrency;
            this.sellerEDICodeTextBox.Text = this.Case.SellerCode;
            this.sellerNameTextBox.Text = this.Case.SellerClient == null ? string.Empty : this.Case.SellerClient.ToString();
            this.buyerEDICodeTextBox.Text = this.Case.BuyerCode;
            this.tbNetPaymentTerm.Text = String.Format("{0:G}", this.Case.NetPaymentTerm);
            this.buyerNameTextBox.Text = this.Case.BuyerClient == null ? string.Empty : this.Case.BuyerClient.ToString();
            this.tbTotalAssignOutstanding.Text = String.Format("{0:N2}", this.Case.TotalAssignOutstanding);
            this.tbTotalFinanceOustanding.Text = String.Format("{0:N2}", this.Case.TotalFinanceOutstanding);

            switch (this.Case.TransactionType)
            {
                case "国内卖方保理":
                case "出口保理":
                    this.factorCodeTextBox.Text = this.Case.BuyerFactor.FactorCode;
                    this.factorNameTextBox.Text = this.Case.BuyerFactor.ToString();
                    break;
                case "国内买方保理":
                case "进口保理":
                    this.factorCodeTextBox.Text = this.Case.SellerFactor.FactorCode;
                    this.factorNameTextBox.Text = this.Case.SellerFactor.ToString();
                    break;
                default: break;
            }


            CDA cda = this.Case.ActiveCDA;
            if (cda != null)
            {
                this.tbCDACode.Text = cda.CDACode;
                this.tbIsNotice.Text = cda.IsNotice;
                this.isRecoarseCheckBox.Checked = cda.IsRecoarse.Value;
                this.assignTypeTextBox.Text = cda.AssignType;
                this.tbPaymentTerms.Text = cda.PaymentTerms;

                this.priceTextBox.Text = String.Format("{0:P4}", cda.Price);
                this.eFPriceTextBox.Text = String.Format("{0:P4}", cda.EFPrice);
                this.iFPriceTextBox.Text = String.Format("{0:P4}", cda.IFPrice);
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

                this.CaculateOutstanding(this.Case);

                if (!cda.FinanceLine.HasValue && this.opARType == OpARType.FINANCE)
                {
                    MessageBoxEx.Show("本案无预付款额度，不能融资。", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                this.isRecoarseCheckBox.Checked = false;
                this.assignTypeTextBox.Text = string.Empty;
            }

            Control control = this.panelInvoiceMgr.Controls[0];
            if (control is InvoiceAssign)
            {
                (control as InvoiceAssign).Case = this.Case;
            }
            else if (control is InvoiceFinance)
            {
                (control as InvoiceFinance).Case = this.Case;
            }
            else if (control is InvoicePayment)
            {
                (control as InvoicePayment).Case = this.Case;
            }
            else if (control is InvoiceRefund)
            {
                (control as InvoiceRefund).Case = this.Case;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCase(object sender, EventArgs e)
        {
            CaseMgr caseMgr = new CaseMgr(CaseMgr.OpCaseType.ENABLE_CASE);
            QueryForm queryForm = new QueryForm(caseMgr, "选择案件");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;
            if (curCase != null)
            {
                if (curCase.ActiveCDA == null)
                {
                    MessageBoxEx.Show("没有有效的额度通知书，不能进行应收账款管理", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.Case = curCase;
            }
        }

        #endregion?Methods?
    }
}
