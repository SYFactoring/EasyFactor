

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.InfoMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    ///
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
            InvoicePayment
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
            if (opARType == OpARType.InvoiceAssign)
            {
                UserControl invoiceAssign = new InvoiceAssign();
                invoiceAssign.Dock = DockStyle.Fill;
                this.panelInvoiceMgr.Controls.Add(invoiceAssign);
            }
            else if (opARType == OpARType.InvoiceFinance)
            {
                UserControl invoiceFinance = new InvoiceFinance();
                invoiceFinance.Dock = DockStyle.Fill;
                this.panelInvoiceMgr.Controls.Add(invoiceFinance);
            }
            else if (opARType == OpARType.InvoicePayment)
            {
                UserControl invoicePayment = new InvoicePayment();
                invoicePayment.Dock = DockStyle.Fill;
                this.panelInvoiceMgr.Controls.Add(invoicePayment);
            }
        }

        #endregion Constructors

        #region Methods (3)

        // Private Methods (3) 

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

            CDA cda = curCase.CDAs.SingleOrDefault(c => c.CDAStatus == "已生效");
            if (cda != null)
            {
                this.isNoticeCheckBox.Checked = cda.IsNotice.Value;
                this.isRecoarseCheckBox.Checked = cda.IsRecoarse.Value;
                this.assignTypeTextBox.Text = cda.AssignType;
                Control control = this.panelInvoiceMgr.Controls[0];
                if (control is InvoiceAssign)
                {
                    (control as InvoiceAssign).CDA = cda;
                }
            }
            else
            {
                this.isNoticeCheckBox.Checked = false;
                this.isRecoarseCheckBox.Checked = false;
                this.assignTypeTextBox.Text = string.Empty;
                Control control = this.panelInvoiceMgr.Controls[0];
                if (control is InvoiceAssign)
                {
                    (control as InvoiceAssign).ResetControlsStatus();
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
