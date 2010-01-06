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
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class ARCaseBasic : UserControl
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private Case curCase;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// 
        /// </summary>
        public enum OpARType
        {
            /// <summary>
            /// 
            /// </summary>
            InvoiceAssign,

            /// <summary>
            /// 
            /// </summary>
            InvoiceFinance,

            /// <summary>
            /// 
            /// </summary>
            InvoiceBuyerPayment,

            /// <summary>
            /// 
            /// </summary>
            InvoiceIndirectPayment,

            /// <summary>
            /// 
            /// </summary>
            InvoiceSellerPayment,

            /// <summary>
            /// 
            /// </summary>
            InvoiceGuaranteePayment
        }

        #endregion Enums

        #region Constructors (1)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opARType"></param>
        public ARCaseBasic(OpARType opARType)
        {
            InitializeComponent();
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
                    uc = new InvoicePayment(this, InvoicePayment.PaymentType.BUYER_PAYMENT);
                    break;
                case OpARType.InvoiceIndirectPayment:
                    uc = new InvoicePayment(this, InvoicePayment.PaymentType.INDIRECT_PAYMENT);
                    break;
                case OpARType.InvoiceSellerPayment:
                    uc = new InvoicePayment(this, InvoicePayment.PaymentType.SELLER_PAYMENT);
                    break;
                case OpARType.InvoiceGuaranteePayment:
                    uc = new InvoicePayment(this, InvoicePayment.PaymentType.GUARANTEE_PAYMENT);
                    break;
                default:
                    uc = new UserControl();
                    break;
            }
            uc.Dock = DockStyle.Fill;
            this.panelInvoiceMgr.Controls.Add(uc);
        }

        #endregion Constructors

        #region Methods (3)

        // Public Methods (1) 

        public void CaculateOutstanding(CDA cda)
        {
            this.tbCreditCoverOutstanding.Text = String.Format("{0:N2}", cda.CreditCoverOutstanding);
            this.tbAROutstanding.Text = String.Format("{0:N2}", cda.AROutstanding);
            this.tbFinanceCreditLineOutstanding.Text = String.Format("{0:N2}", cda.CreditLineOutstanding);
            this.tbFinanceOutstanding.Text = String.Format("{0:N2}", cda.FinanceOutstanding);
        }
        // Private Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        private void FillCaseBasic()
        {
            this.ownerDepartmentCodeTextBox.Text = curCase.OwnerDepartment == null ? string.Empty : curCase.OwnerDepartment.ToString();
            this.transactionTypeTextBox.Text = curCase.TransactionType;
            this.invoiceCurrencyTextBox.Text = curCase.InvoiceCurrency;
            this.sellerEDICodeTextBox.Text = curCase.SellerCode;
            this.sellerNameTextBox.Text = curCase.SellerClient == null ? string.Empty : curCase.SellerClient.ToString();
            this.buyerEDICodeTextBox.Text = curCase.BuyerCode;
            this.buyerNameTextBox.Text = curCase.BuyerClient == null ? string.Empty : curCase.BuyerClient.ToString();
            if ("国内卖方保理".Equals(curCase.TransactionType) || "出口保理".Equals(curCase.TransactionType) || "国际信保保理".Equals(curCase.TransactionType) || "国内信保保理".Equals(curCase.TransactionType))
            {
                if (curCase.SellerFactor != null)
                {
                    this.factorCodeTextBox.Text = curCase.SellerFactor.FactorCode;
                    this.factorNameTextBox.Text = curCase.SellerFactor.ToString();
                }
                if (curCase.SellerClient != null)
                {
                    this.PMTextBox.Text = curCase.SellerClient.PMName;
                    this.RMTextBox.Text = curCase.SellerClient.RMName;
                }
            }
            else
            {
                if (curCase.BuyerFactor != null)
                {
                    this.factorCodeTextBox.Text = curCase.BuyerFactor.FactorCode;
                    this.factorNameTextBox.Text = curCase.BuyerFactor.ToString();
                }
                if (curCase.BuyerClient != null)
                {
                    this.PMTextBox.Text = curCase.BuyerClient.PMName;
                    this.RMTextBox.Text = curCase.BuyerClient.RMName;
                }
            }

            CDA cda = curCase.CDAs.SingleOrDefault(c => c.CDAStatus == "已签回");
            if (cda != null)
            {
                this.tbIsNotice.Text = cda.IsNotice;
                this.isRecoarseCheckBox.Checked = cda.IsRecoarse.Value;
                this.assignTypeTextBox.Text = cda.AssignType;

                this.priceTextBox.Text = String.Format("{0:P2}", cda.Price);
                this.iFPriceTextBox.Text = String.Format("{0:P2}", cda.IFPrice);
                this.handFeeCurrTextBox.Text = cda.HandFeeCurr;
                this.handFeeTextBox.Text = String.Format("{0:N}", cda.HandFee);

                this.creditCoverCurrTextBox.Text = cda.CreditCoverCurr;
                this.creditCoverTextBox.Text = String.Format("{0:N2}", cda.CreditCover);
                this.periodEndTextBox.Text = String.Format("{0:d}", cda.CreditCoverPeriodEnd);


                this.financeProportionTextBox.Text = String.Format("{0:P0}", cda.FinanceProportion);
                this.tbFinanceLineCurr.Text = cda.FinanceLineCurr;
                this.tbFinanceLine.Text = String.Format("{0:N2}", cda.FinanceLine);
                this.tbDueDate.Text = String.Format("{0:d}", cda.FinanceLinePeriodEnd);

                CaculateOutstanding(cda);

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
                FillCaseBasic();
            }
        }

        #endregion Methods
    }
}
