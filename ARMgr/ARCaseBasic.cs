//-----------------------------------------------------------------------
// <copyright file="ARCaseBasic.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpARType
    {
        /// <summary>
        /// ת��
        /// </summary>
        ASSIGN,

        /// <summary>
        /// ����
        /// </summary>
        FINANCE,

        /// <summary>
        /// �򷽸���
        /// </summary>
        BUYER_PAYMENT,

        /// <summary>
        /// ��ֱ�Ӹ���
        /// </summary>
        BUYER_REFUND,

        /// <summary>
        /// ��������
        /// </summary>
        SELLER_REFUND,

        /// <summary>
        /// ��Ӹ���
        /// </summary>
        INDIRECT_PAYMENT,

        /// <summary>
        /// ��������
        /// </summary>
        GUARANTEE_PAYMENT,

        /// <summary>
        /// �����ع�
        /// </summary>
        SELLER_REASSIGN,

        /// <summary>
        /// ����֪ͨ
        /// </summary>
        CREDIT_NOTE,
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class ARCaseBasic : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly OpARType _opARType;

        /// <summary>
        /// 
        /// </summary>
        private Case _case;


        /// <summary>
        /// Initializes a new instance of the ARCaseBasic class
        /// </summary>
        /// <param name="opARType"></param>
        public ARCaseBasic(OpARType opARType)
        {
            InitializeComponent();

            _opARType = opARType;
            switch (opARType)
            {
                case OpARType.ASSIGN:
                    InvoiceControl = new InvoiceAssign(this);
                    break;
                case OpARType.FINANCE:
                    InvoiceControl = new InvoiceFinance(this);
                    break;
                case OpARType.BUYER_PAYMENT:
                    InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.BUYER_PAYMENT);
                    break;
                case OpARType.INDIRECT_PAYMENT:
                    InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.INDIRECT_PAYMENT);
                    break;
                case OpARType.GUARANTEE_PAYMENT:
                    InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.GUARANTEE_PAYMENT);
                    break;
                case OpARType.SELLER_REASSIGN:
                    InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.SELLER_REASSIGN);
                    break;
                case OpARType.CREDIT_NOTE:
                    InvoiceControl = new InvoicePayment(this, InvoicePayment.OpPaymentType.CREDIT_NOTE_PAYMENT);
                    break;
                case OpARType.SELLER_REFUND:
                    InvoiceControl = new InvoiceRefund(this, InvoiceRefund.OpRefundType.SELLER_REFUND);
                    break;
                case OpARType.BUYER_REFUND:
                    InvoiceControl = new InvoiceRefund(this, InvoiceRefund.OpRefundType.BUYER_PAYMENT);
                    break;
                default:
                    InvoiceControl = new UserControl();
                    break;
            }

            InvoiceControl.Dock = DockStyle.Fill;
            panelInvoiceMgr.Controls.Add(InvoiceControl);
        }


        /// <summary>
        /// Gets or sets
        /// </summary>
        public Case Case
        {
            get { return _case; }
            set
            {
                _case = value;
                FillCaseBasic();
            }
        }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public UserControl InvoiceControl { get; set; }


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
                tbCreditCoverOutstanding.Text = String.Format("{0:N2}", cda.CreditCoverOutstanding);
                tbAROutstanding.Text = String.Format("{0:N2}", cda.Case.AssignOutstanding);
                tbFinanceCreditLineOutstanding.Text = String.Format("{0:N2}", cda.FinanceLineOutstanding);
                tbFinanceOutstanding.Text = String.Format("{0:N2}", cda.Case.FinanceOutstanding);
            }
            else
            {
                tbCreditCoverOutstanding.Text = String.Empty;
                tbAROutstanding.Text = String.Empty;
                tbFinanceCreditLineOutstanding.Text = String.Empty;
                tbFinanceOutstanding.Text = String.Empty;
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
            if (Case != null)
            {
                var clientDetail = new ClientDetail(Case.BuyerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
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
            if (Case != null)
            {
                var caseDetail = new CaseDetail(Case, CaseDetail.OpCaseType.DETAIL_CASE);
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
            if (Case != null)
            {
                CDA cda = Case.ActiveCDA;
                if (cda != null)
                {
                    var cdaDetail = new CDADetail(cda, CDADetail.OpCDAType.DETAIL_CDA);
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
            if (Case != null)
            {
                var factorDetail = new FactorDetail(Case.Factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
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
            if (Case != null)
            {
                var clientDetail = new ClientDetail(Case.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
                clientDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillCaseBasic()
        {
            tbCaseCode.Text = Case.CaseCode;
            ownerDepartmentCodeTextBox.Text = Case.OwnerDepartment == null
                                                  ? string.Empty
                                                  : Case.OwnerDepartment.ToString();
            transactionTypeTextBox.Text = Case.TransactionType;
            invoiceCurrencyTextBox.Text = Case.InvoiceCurrency;
            sellerEDICodeTextBox.Text = Case.SellerCode;
            sellerNameTextBox.Text = Case.SellerClient == null ? string.Empty : Case.SellerClient.ToString();
            buyerEDICodeTextBox.Text = Case.BuyerCode;
            tbNetPaymentTerm.Text = String.Format("{0:G}", Case.NetPaymentTerm);
            buyerNameTextBox.Text = Case.BuyerClient == null ? string.Empty : Case.BuyerClient.ToString();
            tbTotalAssignOutstanding.Text = String.Format("{0:N2}", Case.TotalAssignOutstanding);
            tbTotalFinanceOustanding.Text = String.Format("{0:N2}", Case.TotalFinanceOutstanding);

            switch (Case.TransactionType)
            {
                case "������������":
                case "���ڱ���":
                    factorCodeTextBox.Text = Case.BuyerFactor.FactorCode;
                    factorNameTextBox.Text = Case.BuyerFactor.ToString();
                    break;
                case "�����򷽱���":
                case "���ڱ���":
                    factorCodeTextBox.Text = Case.SellerFactor.FactorCode;
                    factorNameTextBox.Text = Case.SellerFactor.ToString();
                    break;
                default:
                    break;
            }


            CDA cda = Case.ActiveCDA;
            if (cda != null)
            {
                tbCDACode.Text = cda.CDACode;
                tbIsNotice.Text = cda.IsNotice;
                if (cda.IsRecoarse != null) isRecoarseCheckBox.Checked = cda.IsRecoarse.Value;
                assignTypeTextBox.Text = cda.AssignType;
                tbPaymentTerms.Text = cda.PaymentTerms;

                priceTextBox.Text = String.Format("{0:P4}", cda.Price);
                eFPriceTextBox.Text = String.Format("{0:P4}", cda.EFPrice);
                iFPriceTextBox.Text = String.Format("{0:P4}", cda.IFPrice);
                handFeeCurrTextBox.Text = cda.HandFeeCurr;
                handFeeTextBox.Text = String.Format("{0:N}", cda.HandFee);
                commissionTypeTextBox.Text = cda.CommissionType;

                creditCoverCurrTextBox.Text = cda.CreditCoverCurr;
                creditCoverTextBox.Text = String.Format("{0:N2}", cda.CreditCover);
                periodEndTextBox.Text = String.Format("{0:d}", cda.CreditCoverPeriodEnd);


                financeProportionTextBox.Text = String.Format("{0:P0}", cda.FinanceProportion);
                tbFinanceLineCurr.Text = cda.FinanceLineCurr;
                tbFinanceLine.Text = String.Format("{0:N2}", cda.FinanceLine);
                tbDueDate.Text = String.Format("{0:d}", cda.FinanceLinePeriodEnd);
                ClientCreditLine creditLine = cda.FinanceCreditLine;
                if (creditLine != null)
                {
                    tbHighestFinance.Text = String.Format("{0:N2}", creditLine.CreditLine);
                }

                CaculateOutstanding(Case);

                if (!cda.FinanceLine.HasValue && _opARType == OpARType.FINANCE)
                {
                    MessageBoxEx.Show("������Ԥ�����ȣ��������ʡ�", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                isRecoarseCheckBox.Checked = false;
                assignTypeTextBox.Text = string.Empty;
            }

            Control control = panelInvoiceMgr.Controls[0];
            if (control is InvoiceAssign)
            {
                (control as InvoiceAssign).Case = Case;
            }
            else if (control is InvoiceFinance)
            {
                (control as InvoiceFinance).Case = Case;
            }
            else if (control is InvoicePayment)
            {
                (control as InvoicePayment).Case = Case;
            }
            else if (control is InvoiceRefund)
            {
                (control as InvoiceRefund).Case = Case;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCase(object sender, EventArgs e)
        {
            var caseMgr = new CaseMgr.CaseMgr(CaseMgr.CaseMgr.OpCaseType.ENABLE_CASE);
            var queryForm = new QueryForm(caseMgr, "ѡ�񰸼�");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;

            if (curCase != null)
            {
                if (curCase.IsPool)
                {
                    MessageBoxEx.Show("����Ϊ������ģʽ�����ڳ�����ģ����в���", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    return;
                }

                if (curCase.ActiveCDA == null)
                {
                    MessageBoxEx.Show("û����Ч�Ķ��֪ͨ�飬���ܽ���Ӧ���˿����", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }
                Case = curCase;
            }
        }
    }
}