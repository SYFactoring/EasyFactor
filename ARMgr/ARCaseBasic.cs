﻿

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.InfoMgr;
    using CMBC.EasyFactor.DB.dbml;

    public partial class ARCaseBasic : UserControl
    {

        private Case curCase;

        public ARCaseBasic(OpARType opARType)
        {
            InitializeComponent();
            if (opARType == OpARType.InvoiceAssign)
            {
                UserControl invoiceAssign = new InvoiceAssign();
                invoiceAssign.Dock = DockStyle.Fill;
                this.panelInvoiceMgr.Controls.Add(invoiceAssign);
            }
        }

        public enum OpARType
        {
            InvoiceAssign
        }

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

        private void FillCaseBasic()
        {
            this.ownerDepartmentCodeTextBox.Text = curCase.OwnerDepartment.ToString();
            this.transactionTypeTextBox.Text = curCase.TransactionType;
            this.invoiceCurrencyTextBox.Text = curCase.InvoiceCurrency;
            this.sellerEDICodeTextBox.Text = curCase.SellerCode;
            this.sellerNameTextBox.Text = curCase.SellerClient.ToString();
            this.buyerEDICodeTextBox.Text = curCase.BuyerCode;
            this.buyerNameTextBox.Text = curCase.BuyerClient.ToString();
            if ("国内卖方保理".Equals(curCase.TransactionType) || "出口保理".Equals(curCase.TransactionType) || "国际信保保理".Equals(curCase.TransactionType) || "国内信保保理".Equals(curCase.TransactionType))
            {
                this.factorCodeTextBox.Text = curCase.SellerFactor.FactorCode;
                this.factorNameTextBox.Text = curCase.SellerFactor.ToString();
                this.PMTextBox.Text = curCase.SellerClient.PMName;
                this.RMTextBox.Text = curCase.SellerClient.RMName;
            }
            else
            {
                this.factorCodeTextBox.Text = curCase.BuyerFactor.FactorCode;
                this.factorNameTextBox.Text = curCase.BuyerFactor.ToString();
                this.PMTextBox.Text = curCase.BuyerClient.PMName;
                this.RMTextBox.Text = curCase.BuyerClient.RMName;
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
                ResetInvoiceControlStatus();
            }
        }

        private void ResetInvoiceControlStatus()
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
}