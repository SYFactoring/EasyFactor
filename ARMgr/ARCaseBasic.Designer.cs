//-----------------------------------------------------------------------
// <copyright file="ARCaseBasic.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ARCaseBasic
    {
		#region?Fields?(44)?

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX assignTypeTextBox;
        private DevComponents.DotNetBar.ButtonX btnCaseQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX commissionTypeTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX creditCoverCurrTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditCoverTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX eFPriceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX factorNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeProportionTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX handFeeCurrTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX handFeeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX iFPriceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceCurrencyTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isRecoarseCheckBox;
        private DevComponents.DotNetBar.Controls.TextBoxX ownerDepartmentCodeTextBox;
        private DevComponents.DotNetBar.ExpandablePanel panelBuyer;
        private DevComponents.DotNetBar.ExpandablePanel panelCase;
        private DevComponents.DotNetBar.ExpandablePanel panelCaseBasic;
        private DevComponents.DotNetBar.ExpandablePanel panelFee;
        private DevComponents.DotNetBar.ExpandablePanel panelFinanceCreditLine;
        private DevComponents.DotNetBar.PanelEx panelInvoiceMgr;
        private DevComponents.DotNetBar.Controls.TextBoxX periodEndTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX priceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAROutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCDACode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceCreditLineOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLine;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLineCurr;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbHighestFinance;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIsNotice;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNetPaymentTerm;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentTerms;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalAssignOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalFinanceOustanding;
        private DevComponents.DotNetBar.Controls.TextBoxX transactionTypeTextBox;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevComponents.DotNetBar.LabelX priceLabel;
            DevComponents.DotNetBar.LabelX iFPriceLabel;
            DevComponents.DotNetBar.LabelX handFeeCurrLabel;
            DevComponents.DotNetBar.LabelX financeProportionLabel;
            DevComponents.DotNetBar.LabelX creditCoverCurrLabel;
            DevComponents.DotNetBar.LabelX periodEndLabel;
            DevComponents.DotNetBar.LabelX lblBuyerCreditCoverBalance;
            DevComponents.DotNetBar.LabelX lblBuyerARBalance;
            DevComponents.DotNetBar.LabelX lblFinanceARBalance;
            DevComponents.DotNetBar.LabelX lblFinanceCreditCoverBalance;
            DevComponents.DotNetBar.LabelX lblDueDate;
            DevComponents.DotNetBar.LabelX lblCreditLine;
            DevComponents.DotNetBar.LabelX efPriceLbl;
            DevComponents.DotNetBar.LabelX lblCommissionType;
            DevComponents.DotNetBar.LabelX lblCaseCode;
            DevComponents.DotNetBar.LabelX lblCDACode;
            DevComponents.DotNetBar.LabelX lblIsNotice;
            DevComponents.DotNetBar.LabelX ownerDepartmentCodeLabel;
            DevComponents.DotNetBar.LabelX assignTypeLabel;
            DevComponents.DotNetBar.LabelX sellerEDICodeLabel;
            DevComponents.DotNetBar.LabelX buyerEDICodeLabel;
            DevComponents.DotNetBar.LabelX invoiceCurrencyLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX transactionTypeLabel;
            DevComponents.DotNetBar.LabelX lblHighestFinance;
            DevComponents.DotNetBar.LabelX lblPaymentTerms;
            DevComponents.DotNetBar.LabelX lblSellerAssignOutstanding;
            DevComponents.DotNetBar.LabelX lblTotalFinanceOutstanding;
            this.panelCaseBasic = new DevComponents.DotNetBar.ExpandablePanel();
            this.panelFinanceCreditLine = new DevComponents.DotNetBar.ExpandablePanel();
            this.tbTotalFinanceOustanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbHighestFinance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceCreditLineOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceLineCurr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceLine = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbDueDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelBuyer = new DevComponents.DotNetBar.ExpandablePanel();
            this.tbTotalAssignOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbAROutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverCurrTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCreditCoverOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.periodEndTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelFee = new DevComponents.DotNetBar.ExpandablePanel();
            this.commissionTypeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.priceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeProportionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.iFPriceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.eFPriceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.handFeeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.handFeeCurrTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelCase = new DevComponents.DotNetBar.ExpandablePanel();
            this.tbNetPaymentTerm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPaymentTerms = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCDACode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbIsNotice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCaseQuery = new DevComponents.DotNetBar.ButtonX();
            this.ownerDepartmentCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.assignTypeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sellerEDICodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sellerNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buyerEDICodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buyerNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.isRecoarseCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceCurrencyTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.transactionTypeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelInvoiceMgr = new DevComponents.DotNetBar.PanelEx();
            priceLabel = new DevComponents.DotNetBar.LabelX();
            iFPriceLabel = new DevComponents.DotNetBar.LabelX();
            handFeeCurrLabel = new DevComponents.DotNetBar.LabelX();
            financeProportionLabel = new DevComponents.DotNetBar.LabelX();
            creditCoverCurrLabel = new DevComponents.DotNetBar.LabelX();
            periodEndLabel = new DevComponents.DotNetBar.LabelX();
            lblBuyerCreditCoverBalance = new DevComponents.DotNetBar.LabelX();
            lblBuyerARBalance = new DevComponents.DotNetBar.LabelX();
            lblFinanceARBalance = new DevComponents.DotNetBar.LabelX();
            lblFinanceCreditCoverBalance = new DevComponents.DotNetBar.LabelX();
            lblDueDate = new DevComponents.DotNetBar.LabelX();
            lblCreditLine = new DevComponents.DotNetBar.LabelX();
            efPriceLbl = new DevComponents.DotNetBar.LabelX();
            lblCommissionType = new DevComponents.DotNetBar.LabelX();
            lblCaseCode = new DevComponents.DotNetBar.LabelX();
            lblCDACode = new DevComponents.DotNetBar.LabelX();
            lblIsNotice = new DevComponents.DotNetBar.LabelX();
            ownerDepartmentCodeLabel = new DevComponents.DotNetBar.LabelX();
            assignTypeLabel = new DevComponents.DotNetBar.LabelX();
            sellerEDICodeLabel = new DevComponents.DotNetBar.LabelX();
            buyerEDICodeLabel = new DevComponents.DotNetBar.LabelX();
            invoiceCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            transactionTypeLabel = new DevComponents.DotNetBar.LabelX();
            lblHighestFinance = new DevComponents.DotNetBar.LabelX();
            lblPaymentTerms = new DevComponents.DotNetBar.LabelX();
            lblSellerAssignOutstanding = new DevComponents.DotNetBar.LabelX();
            lblTotalFinanceOutstanding = new DevComponents.DotNetBar.LabelX();
            this.panelCaseBasic.SuspendLayout();
            this.panelFinanceCreditLine.SuspendLayout();
            this.panelBuyer.SuspendLayout();
            this.panelFee.SuspendLayout();
            this.panelCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            // 
            // 
            // 
            priceLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            priceLabel.Location = new System.Drawing.Point(6, 26);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 18);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "总手续费率";
            // 
            // iFPriceLabel
            // 
            iFPriceLabel.AutoSize = true;
            // 
            // 
            // 
            iFPriceLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            iFPriceLabel.Location = new System.Drawing.Point(7, 66);
            iFPriceLabel.Name = "iFPriceLabel";
            iFPriceLabel.Size = new System.Drawing.Size(68, 18);
            iFPriceLabel.TabIndex = 2;
            iFPriceLabel.Text = "IF手续费率";
            // 
            // handFeeCurrLabel
            // 
            handFeeCurrLabel.AutoSize = true;
            // 
            // 
            // 
            handFeeCurrLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            handFeeCurrLabel.Location = new System.Drawing.Point(6, 86);
            handFeeCurrLabel.Name = "handFeeCurrLabel";
            handFeeCurrLabel.Size = new System.Drawing.Size(68, 18);
            handFeeCurrLabel.TabIndex = 4;
            handFeeCurrLabel.Text = "单据处理费";
            // 
            // financeProportionLabel
            // 
            financeProportionLabel.AutoSize = true;
            // 
            // 
            // 
            financeProportionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeProportionLabel.Location = new System.Drawing.Point(16, 126);
            financeProportionLabel.Name = "financeProportionLabel";
            financeProportionLabel.Size = new System.Drawing.Size(56, 18);
            financeProportionLabel.TabIndex = 0;
            financeProportionLabel.Text = "预付比例";
            // 
            // creditCoverCurrLabel
            // 
            creditCoverCurrLabel.AutoSize = true;
            // 
            // 
            // 
            creditCoverCurrLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            creditCoverCurrLabel.Location = new System.Drawing.Point(6, 25);
            creditCoverCurrLabel.Name = "creditCoverCurrLabel";
            creditCoverCurrLabel.Size = new System.Drawing.Size(81, 18);
            creditCoverCurrLabel.TabIndex = 0;
            creditCoverCurrLabel.Text = "信用风险额度";
            // 
            // periodEndLabel
            // 
            periodEndLabel.AutoSize = true;
            // 
            // 
            // 
            periodEndLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            periodEndLabel.Location = new System.Drawing.Point(42, 42);
            periodEndLabel.Name = "periodEndLabel";
            periodEndLabel.Size = new System.Drawing.Size(44, 18);
            periodEndLabel.TabIndex = 3;
            periodEndLabel.Text = "到期日";
            // 
            // lblBuyerCreditCoverBalance
            // 
            lblBuyerCreditCoverBalance.AutoSize = true;
            // 
            // 
            // 
            lblBuyerCreditCoverBalance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblBuyerCreditCoverBalance.Location = new System.Drawing.Point(30, 64);
            lblBuyerCreditCoverBalance.Name = "lblBuyerCreditCoverBalance";
            lblBuyerCreditCoverBalance.Size = new System.Drawing.Size(56, 18);
            lblBuyerCreditCoverBalance.TabIndex = 5;
            lblBuyerCreditCoverBalance.Text = "剩余额度";
            // 
            // lblBuyerARBalance
            // 
            lblBuyerARBalance.AutoSize = true;
            // 
            // 
            // 
            lblBuyerARBalance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblBuyerARBalance.Location = new System.Drawing.Point(6, 85);
            lblBuyerARBalance.Name = "lblBuyerARBalance";
            lblBuyerARBalance.Size = new System.Drawing.Size(81, 18);
            lblBuyerARBalance.TabIndex = 7;
            lblBuyerARBalance.Text = "应收帐款余额";
            // 
            // lblFinanceARBalance
            // 
            lblFinanceARBalance.AutoSize = true;
            // 
            // 
            // 
            lblFinanceARBalance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblFinanceARBalance.Location = new System.Drawing.Point(30, 87);
            lblFinanceARBalance.Name = "lblFinanceARBalance";
            lblFinanceARBalance.Size = new System.Drawing.Size(56, 18);
            lblFinanceARBalance.TabIndex = 9;
            lblFinanceARBalance.Text = "融资余额";
            // 
            // lblFinanceCreditCoverBalance
            // 
            lblFinanceCreditCoverBalance.AutoSize = true;
            // 
            // 
            // 
            lblFinanceCreditCoverBalance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblFinanceCreditCoverBalance.Location = new System.Drawing.Point(30, 67);
            lblFinanceCreditCoverBalance.Name = "lblFinanceCreditCoverBalance";
            lblFinanceCreditCoverBalance.Size = new System.Drawing.Size(56, 18);
            lblFinanceCreditCoverBalance.TabIndex = 7;
            lblFinanceCreditCoverBalance.Text = "剩余额度";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            // 
            // 
            // 
            lblDueDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblDueDate.Location = new System.Drawing.Point(42, 46);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new System.Drawing.Size(44, 18);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "到期日";
            // 
            // lblCreditLine
            // 
            lblCreditLine.AutoSize = true;
            // 
            // 
            // 
            lblCreditLine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblCreditLine.Location = new System.Drawing.Point(18, 23);
            lblCreditLine.Name = "lblCreditLine";
            lblCreditLine.Size = new System.Drawing.Size(68, 18);
            lblCreditLine.TabIndex = 2;
            lblCreditLine.Text = "预付款额度";
            // 
            // efPriceLbl
            // 
            efPriceLbl.AutoSize = true;
            // 
            // 
            // 
            efPriceLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            efPriceLbl.Location = new System.Drawing.Point(6, 46);
            efPriceLbl.Name = "efPriceLbl";
            efPriceLbl.Size = new System.Drawing.Size(68, 18);
            efPriceLbl.TabIndex = 7;
            efPriceLbl.Text = "EF手续费率";
            // 
            // lblCommissionType
            // 
            lblCommissionType.AutoSize = true;
            // 
            // 
            // 
            lblCommissionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblCommissionType.Location = new System.Drawing.Point(16, 104);
            lblCommissionType.Name = "lblCommissionType";
            lblCommissionType.Size = new System.Drawing.Size(56, 18);
            lblCommissionType.TabIndex = 9;
            lblCommissionType.Text = "计费方式";
            // 
            // lblCaseCode
            // 
            lblCaseCode.AutoSize = true;
            // 
            // 
            // 
            lblCaseCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblCaseCode.Location = new System.Drawing.Point(310, 46);
            lblCaseCode.Name = "lblCaseCode";
            lblCaseCode.Size = new System.Drawing.Size(56, 18);
            lblCaseCode.TabIndex = 56;
            lblCaseCode.Text = "案件编号";
            // 
            // lblCDACode
            // 
            lblCDACode.AutoSize = true;
            // 
            // 
            // 
            lblCDACode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblCDACode.Location = new System.Drawing.Point(311, 26);
            lblCDACode.Name = "lblCDACode";
            lblCDACode.Size = new System.Drawing.Size(50, 18);
            lblCDACode.TabIndex = 54;
            lblCDACode.Text = "CDA编号";
            // 
            // lblIsNotice
            // 
            lblIsNotice.AutoSize = true;
            // 
            // 
            // 
            lblIsNotice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblIsNotice.Location = new System.Drawing.Point(307, 84);
            lblIsNotice.Name = "lblIsNotice";
            lblIsNotice.Size = new System.Drawing.Size(62, 18);
            lblIsNotice.TabIndex = 51;
            lblIsNotice.Text = "明/暗保理";
            // 
            // ownerDepartmentCodeLabel
            // 
            ownerDepartmentCodeLabel.AutoSize = true;
            // 
            // 
            // 
            ownerDepartmentCodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ownerDepartmentCodeLabel.Location = new System.Drawing.Point(6, 24);
            ownerDepartmentCodeLabel.Name = "ownerDepartmentCodeLabel";
            ownerDepartmentCodeLabel.Size = new System.Drawing.Size(87, 18);
            ownerDepartmentCodeLabel.TabIndex = 30;
            ownerDepartmentCodeLabel.Text = " 业务归属机构";
            // 
            // assignTypeLabel
            // 
            assignTypeLabel.AutoSize = true;
            // 
            // 
            // 
            assignTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignTypeLabel.Location = new System.Drawing.Point(309, 64);
            assignTypeLabel.Name = "assignTypeLabel";
            assignTypeLabel.Size = new System.Drawing.Size(56, 18);
            assignTypeLabel.TabIndex = 49;
            assignTypeLabel.Text = "转让方式";
            // 
            // sellerEDICodeLabel
            // 
            sellerEDICodeLabel.AutoSize = true;
            // 
            // 
            // 
            sellerEDICodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            sellerEDICodeLabel.Location = new System.Drawing.Point(56, 45);
            sellerEDICodeLabel.Name = "sellerEDICodeLabel";
            sellerEDICodeLabel.Size = new System.Drawing.Size(31, 18);
            sellerEDICodeLabel.TabIndex = 32;
            sellerEDICodeLabel.Text = "卖方";
            // 
            // buyerEDICodeLabel
            // 
            buyerEDICodeLabel.AutoSize = true;
            // 
            // 
            // 
            buyerEDICodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            buyerEDICodeLabel.Location = new System.Drawing.Point(55, 66);
            buyerEDICodeLabel.Name = "buyerEDICodeLabel";
            buyerEDICodeLabel.Size = new System.Drawing.Size(31, 18);
            buyerEDICodeLabel.TabIndex = 35;
            buyerEDICodeLabel.Text = "买方";
            // 
            // invoiceCurrencyLabel
            // 
            invoiceCurrencyLabel.AutoSize = true;
            // 
            // 
            // 
            invoiceCurrencyLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            invoiceCurrencyLabel.Location = new System.Drawing.Point(203, 25);
            invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            invoiceCurrencyLabel.Size = new System.Drawing.Size(31, 18);
            invoiceCurrencyLabel.TabIndex = 43;
            invoiceCurrencyLabel.Text = "币别";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            factorCodeLabel.Location = new System.Drawing.Point(43, 84);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(44, 18);
            factorCodeLabel.TabIndex = 38;
            factorCodeLabel.Text = "保理商";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            // 
            // 
            // 
            transactionTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            transactionTypeLabel.Location = new System.Drawing.Point(31, 105);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new System.Drawing.Size(56, 18);
            transactionTypeLabel.TabIndex = 41;
            transactionTypeLabel.Text = "业务类别";
            // 
            // lblHighestFinance
            // 
            lblHighestFinance.AutoSize = true;
            // 
            // 
            // 
            lblHighestFinance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblHighestFinance.Location = new System.Drawing.Point(0, 106);
            lblHighestFinance.Name = "lblHighestFinance";
            lblHighestFinance.Size = new System.Drawing.Size(93, 18);
            lblHighestFinance.TabIndex = 11;
            lblHighestFinance.Text = "最高预付款额度";
            // 
            // lblPaymentTerms
            // 
            lblPaymentTerms.AutoSize = true;
            // 
            // 
            // 
            lblPaymentTerms.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblPaymentTerms.Location = new System.Drawing.Point(30, 124);
            lblPaymentTerms.Name = "lblPaymentTerms";
            lblPaymentTerms.Size = new System.Drawing.Size(56, 18);
            lblPaymentTerms.TabIndex = 58;
            lblPaymentTerms.Text = "付款条件";
            // 
            // lblSellerAssignOutstanding
            // 
            lblSellerAssignOutstanding.AutoSize = true;
            // 
            // 
            // 
            lblSellerAssignOutstanding.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblSellerAssignOutstanding.Location = new System.Drawing.Point(18, 105);
            lblSellerAssignOutstanding.Name = "lblSellerAssignOutstanding";
            lblSellerAssignOutstanding.Size = new System.Drawing.Size(68, 18);
            lblSellerAssignOutstanding.TabIndex = 9;
            lblSellerAssignOutstanding.Text = "总账款余额";
            // 
            // lblTotalFinanceOutstanding
            // 
            lblTotalFinanceOutstanding.AutoSize = true;
            // 
            // 
            // 
            lblTotalFinanceOutstanding.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblTotalFinanceOutstanding.Location = new System.Drawing.Point(18, 127);
            lblTotalFinanceOutstanding.Name = "lblTotalFinanceOutstanding";
            lblTotalFinanceOutstanding.Size = new System.Drawing.Size(68, 18);
            lblTotalFinanceOutstanding.TabIndex = 13;
            lblTotalFinanceOutstanding.Text = "总融资余额";
            // 
            // panelCaseBasic
            // 
            this.panelCaseBasic.AutoScroll = true;
            this.panelCaseBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCaseBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelCaseBasic.Controls.Add(this.panelFinanceCreditLine);
            this.panelCaseBasic.Controls.Add(this.panelBuyer);
            this.panelCaseBasic.Controls.Add(this.panelFee);
            this.panelCaseBasic.Controls.Add(this.panelCase);
            this.panelCaseBasic.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCaseBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaseBasic.ExpandOnTitleClick = true;
            this.panelCaseBasic.Location = new System.Drawing.Point(0, 0);
            this.panelCaseBasic.Margin = new System.Windows.Forms.Padding(0);
            this.panelCaseBasic.Name = "panelCaseBasic";
            this.panelCaseBasic.Size = new System.Drawing.Size(1254, 162);
            this.panelCaseBasic.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCaseBasic.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCaseBasic.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCaseBasic.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCaseBasic.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCaseBasic.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCaseBasic.Style.GradientAngle = 90;
            this.panelCaseBasic.TabIndex = 0;
            this.panelCaseBasic.TitleHeight = 14;
            // 
            // panelFinanceCreditLine
            // 
            this.panelFinanceCreditLine.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinanceCreditLine.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelFinanceCreditLine.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelFinanceCreditLine.Controls.Add(this.tbTotalFinanceOustanding);
            this.panelFinanceCreditLine.Controls.Add(lblTotalFinanceOutstanding);
            this.panelFinanceCreditLine.Controls.Add(this.tbHighestFinance);
            this.panelFinanceCreditLine.Controls.Add(lblHighestFinance);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceOutstanding);
            this.panelFinanceCreditLine.Controls.Add(lblFinanceARBalance);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceCreditLineOutstanding);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceLineCurr);
            this.panelFinanceCreditLine.Controls.Add(lblFinanceCreditCoverBalance);
            this.panelFinanceCreditLine.Controls.Add(lblCreditLine);
            this.panelFinanceCreditLine.Controls.Add(lblDueDate);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceLine);
            this.panelFinanceCreditLine.Controls.Add(this.tbDueDate);
            this.panelFinanceCreditLine.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelFinanceCreditLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFinanceCreditLine.ExpandOnTitleClick = true;
            this.panelFinanceCreditLine.Location = new System.Drawing.Point(867, 14);
            this.panelFinanceCreditLine.Name = "panelFinanceCreditLine";
            this.panelFinanceCreditLine.Size = new System.Drawing.Size(209, 148);
            this.panelFinanceCreditLine.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceCreditLine.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceCreditLine.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceCreditLine.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinanceCreditLine.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelFinanceCreditLine.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelFinanceCreditLine.Style.GradientAngle = 90;
            this.panelFinanceCreditLine.TabIndex = 5;
            this.panelFinanceCreditLine.TitleHeight = 18;
            this.panelFinanceCreditLine.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceCreditLine.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceCreditLine.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceCreditLine.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFinanceCreditLine.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinanceCreditLine.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinanceCreditLine.TitleStyle.GradientAngle = 90;
            this.panelFinanceCreditLine.TitleText = "融资额度信息";
            // 
            // tbTotalFinanceOustanding
            // 
            // 
            // 
            // 
            this.tbTotalFinanceOustanding.Border.Class = "TextBoxBorder";
            this.tbTotalFinanceOustanding.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalFinanceOustanding.Location = new System.Drawing.Point(92, 126);
            this.tbTotalFinanceOustanding.Name = "tbTotalFinanceOustanding";
            this.tbTotalFinanceOustanding.ReadOnly = true;
            this.tbTotalFinanceOustanding.Size = new System.Drawing.Size(100, 21);
            this.tbTotalFinanceOustanding.TabIndex = 14;
            // 
            // tbHighestFinance
            // 
            // 
            // 
            // 
            this.tbHighestFinance.Border.Class = "TextBoxBorder";
            this.tbHighestFinance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbHighestFinance.Location = new System.Drawing.Point(92, 105);
            this.tbHighestFinance.Name = "tbHighestFinance";
            this.tbHighestFinance.ReadOnly = true;
            this.tbHighestFinance.Size = new System.Drawing.Size(100, 21);
            this.tbHighestFinance.TabIndex = 12;
            // 
            // tbFinanceOutstanding
            // 
            // 
            // 
            // 
            this.tbFinanceOutstanding.Border.Class = "TextBoxBorder";
            this.tbFinanceOutstanding.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFinanceOutstanding.Location = new System.Drawing.Point(92, 84);
            this.tbFinanceOutstanding.Name = "tbFinanceOutstanding";
            this.tbFinanceOutstanding.ReadOnly = true;
            this.tbFinanceOutstanding.Size = new System.Drawing.Size(100, 21);
            this.tbFinanceOutstanding.TabIndex = 10;
            // 
            // tbFinanceCreditLineOutstanding
            // 
            // 
            // 
            // 
            this.tbFinanceCreditLineOutstanding.Border.Class = "TextBoxBorder";
            this.tbFinanceCreditLineOutstanding.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFinanceCreditLineOutstanding.Location = new System.Drawing.Point(92, 64);
            this.tbFinanceCreditLineOutstanding.Name = "tbFinanceCreditLineOutstanding";
            this.tbFinanceCreditLineOutstanding.ReadOnly = true;
            this.tbFinanceCreditLineOutstanding.Size = new System.Drawing.Size(100, 21);
            this.tbFinanceCreditLineOutstanding.TabIndex = 8;
            // 
            // tbFinanceLineCurr
            // 
            // 
            // 
            // 
            this.tbFinanceLineCurr.Border.Class = "TextBoxBorder";
            this.tbFinanceLineCurr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFinanceLineCurr.Location = new System.Drawing.Point(92, 22);
            this.tbFinanceLineCurr.Name = "tbFinanceLineCurr";
            this.tbFinanceLineCurr.ReadOnly = true;
            this.tbFinanceLineCurr.Size = new System.Drawing.Size(28, 21);
            this.tbFinanceLineCurr.TabIndex = 3;
            // 
            // tbFinanceLine
            // 
            // 
            // 
            // 
            this.tbFinanceLine.Border.Class = "TextBoxBorder";
            this.tbFinanceLine.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFinanceLine.Location = new System.Drawing.Point(126, 22);
            this.tbFinanceLine.Name = "tbFinanceLine";
            this.tbFinanceLine.ReadOnly = true;
            this.tbFinanceLine.Size = new System.Drawing.Size(66, 21);
            this.tbFinanceLine.TabIndex = 4;
            // 
            // tbDueDate
            // 
            // 
            // 
            // 
            this.tbDueDate.Border.Class = "TextBoxBorder";
            this.tbDueDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDueDate.Location = new System.Drawing.Point(92, 43);
            this.tbDueDate.Name = "tbDueDate";
            this.tbDueDate.ReadOnly = true;
            this.tbDueDate.Size = new System.Drawing.Size(100, 21);
            this.tbDueDate.TabIndex = 6;
            // 
            // panelBuyer
            // 
            this.panelBuyer.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBuyer.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelBuyer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelBuyer.Controls.Add(this.tbTotalAssignOutstanding);
            this.panelBuyer.Controls.Add(lblSellerAssignOutstanding);
            this.panelBuyer.Controls.Add(this.tbAROutstanding);
            this.panelBuyer.Controls.Add(creditCoverCurrLabel);
            this.panelBuyer.Controls.Add(lblBuyerARBalance);
            this.panelBuyer.Controls.Add(this.creditCoverCurrTextBox);
            this.panelBuyer.Controls.Add(this.tbCreditCoverOutstanding);
            this.panelBuyer.Controls.Add(this.creditCoverTextBox);
            this.panelBuyer.Controls.Add(lblBuyerCreditCoverBalance);
            this.panelBuyer.Controls.Add(this.periodEndTextBox);
            this.panelBuyer.Controls.Add(periodEndLabel);
            this.panelBuyer.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBuyer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuyer.ExpandOnTitleClick = true;
            this.panelBuyer.Location = new System.Drawing.Point(664, 14);
            this.panelBuyer.Name = "panelBuyer";
            this.panelBuyer.Size = new System.Drawing.Size(203, 148);
            this.panelBuyer.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBuyer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBuyer.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBuyer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBuyer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelBuyer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelBuyer.Style.GradientAngle = 90;
            this.panelBuyer.TabIndex = 4;
            this.panelBuyer.TitleHeight = 18;
            this.panelBuyer.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBuyer.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBuyer.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBuyer.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelBuyer.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBuyer.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBuyer.TitleStyle.GradientAngle = 90;
            this.panelBuyer.TitleText = "买方信用担保";
            // 
            // tbTotalAssignOutstanding
            // 
            // 
            // 
            // 
            this.tbTotalAssignOutstanding.Border.Class = "TextBoxBorder";
            this.tbTotalAssignOutstanding.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalAssignOutstanding.Location = new System.Drawing.Point(92, 104);
            this.tbTotalAssignOutstanding.Name = "tbTotalAssignOutstanding";
            this.tbTotalAssignOutstanding.ReadOnly = true;
            this.tbTotalAssignOutstanding.Size = new System.Drawing.Size(100, 21);
            this.tbTotalAssignOutstanding.TabIndex = 10;
            // 
            // tbAROutstanding
            // 
            // 
            // 
            // 
            this.tbAROutstanding.Border.Class = "TextBoxBorder";
            this.tbAROutstanding.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAROutstanding.Location = new System.Drawing.Point(92, 83);
            this.tbAROutstanding.Name = "tbAROutstanding";
            this.tbAROutstanding.ReadOnly = true;
            this.tbAROutstanding.Size = new System.Drawing.Size(100, 21);
            this.tbAROutstanding.TabIndex = 8;
            // 
            // creditCoverCurrTextBox
            // 
            // 
            // 
            // 
            this.creditCoverCurrTextBox.Border.Class = "TextBoxBorder";
            this.creditCoverCurrTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverCurrTextBox.Location = new System.Drawing.Point(92, 21);
            this.creditCoverCurrTextBox.Name = "creditCoverCurrTextBox";
            this.creditCoverCurrTextBox.ReadOnly = true;
            this.creditCoverCurrTextBox.Size = new System.Drawing.Size(30, 21);
            this.creditCoverCurrTextBox.TabIndex = 1;
            // 
            // tbCreditCoverOutstanding
            // 
            // 
            // 
            // 
            this.tbCreditCoverOutstanding.Border.Class = "TextBoxBorder";
            this.tbCreditCoverOutstanding.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCreditCoverOutstanding.Location = new System.Drawing.Point(92, 63);
            this.tbCreditCoverOutstanding.Name = "tbCreditCoverOutstanding";
            this.tbCreditCoverOutstanding.ReadOnly = true;
            this.tbCreditCoverOutstanding.Size = new System.Drawing.Size(100, 21);
            this.tbCreditCoverOutstanding.TabIndex = 6;
            // 
            // creditCoverTextBox
            // 
            // 
            // 
            // 
            this.creditCoverTextBox.Border.Class = "TextBoxBorder";
            this.creditCoverTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverTextBox.Location = new System.Drawing.Point(127, 21);
            this.creditCoverTextBox.Name = "creditCoverTextBox";
            this.creditCoverTextBox.ReadOnly = true;
            this.creditCoverTextBox.Size = new System.Drawing.Size(65, 21);
            this.creditCoverTextBox.TabIndex = 2;
            // 
            // periodEndTextBox
            // 
            // 
            // 
            // 
            this.periodEndTextBox.Border.Class = "TextBoxBorder";
            this.periodEndTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.periodEndTextBox.Location = new System.Drawing.Point(92, 42);
            this.periodEndTextBox.Name = "periodEndTextBox";
            this.periodEndTextBox.ReadOnly = true;
            this.periodEndTextBox.Size = new System.Drawing.Size(100, 21);
            this.periodEndTextBox.TabIndex = 4;
            // 
            // panelFee
            // 
            this.panelFee.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFee.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelFee.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelFee.Controls.Add(this.commissionTypeTextBox);
            this.panelFee.Controls.Add(priceLabel);
            this.panelFee.Controls.Add(lblCommissionType);
            this.panelFee.Controls.Add(financeProportionLabel);
            this.panelFee.Controls.Add(this.priceTextBox);
            this.panelFee.Controls.Add(this.financeProportionTextBox);
            this.panelFee.Controls.Add(efPriceLbl);
            this.panelFee.Controls.Add(this.iFPriceTextBox);
            this.panelFee.Controls.Add(this.eFPriceTextBox);
            this.panelFee.Controls.Add(iFPriceLabel);
            this.panelFee.Controls.Add(this.handFeeTextBox);
            this.panelFee.Controls.Add(this.handFeeCurrTextBox);
            this.panelFee.Controls.Add(handFeeCurrLabel);
            this.panelFee.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelFee.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFee.ExpandOnTitleClick = true;
            this.panelFee.Location = new System.Drawing.Point(480, 14);
            this.panelFee.Name = "panelFee";
            this.panelFee.Size = new System.Drawing.Size(184, 148);
            this.panelFee.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFee.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFee.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFee.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFee.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelFee.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelFee.Style.GradientAngle = 90;
            this.panelFee.TabIndex = 6;
            this.panelFee.TitleHeight = 18;
            this.panelFee.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFee.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFee.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFee.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFee.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFee.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFee.TitleStyle.GradientAngle = 90;
            this.panelFee.TitleText = "费率/其他信息";
            // 
            // commissionTypeTextBox
            // 
            // 
            // 
            // 
            this.commissionTypeTextBox.Border.Class = "TextBoxBorder";
            this.commissionTypeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionTypeTextBox.Location = new System.Drawing.Point(77, 103);
            this.commissionTypeTextBox.Name = "commissionTypeTextBox";
            this.commissionTypeTextBox.ReadOnly = true;
            this.commissionTypeTextBox.Size = new System.Drawing.Size(100, 21);
            this.commissionTypeTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            // 
            // 
            // 
            this.priceTextBox.Border.Class = "TextBoxBorder";
            this.priceTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.priceTextBox.Location = new System.Drawing.Point(77, 22);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 21);
            this.priceTextBox.TabIndex = 1;
            // 
            // financeProportionTextBox
            // 
            // 
            // 
            // 
            this.financeProportionTextBox.Border.Class = "TextBoxBorder";
            this.financeProportionTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeProportionTextBox.Location = new System.Drawing.Point(77, 124);
            this.financeProportionTextBox.Name = "financeProportionTextBox";
            this.financeProportionTextBox.ReadOnly = true;
            this.financeProportionTextBox.Size = new System.Drawing.Size(100, 21);
            this.financeProportionTextBox.TabIndex = 1;
            // 
            // iFPriceTextBox
            // 
            // 
            // 
            // 
            this.iFPriceTextBox.Border.Class = "TextBoxBorder";
            this.iFPriceTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iFPriceTextBox.Location = new System.Drawing.Point(77, 64);
            this.iFPriceTextBox.Name = "iFPriceTextBox";
            this.iFPriceTextBox.ReadOnly = true;
            this.iFPriceTextBox.Size = new System.Drawing.Size(100, 21);
            this.iFPriceTextBox.TabIndex = 3;
            // 
            // eFPriceTextBox
            // 
            // 
            // 
            // 
            this.eFPriceTextBox.Border.Class = "TextBoxBorder";
            this.eFPriceTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.eFPriceTextBox.Location = new System.Drawing.Point(77, 43);
            this.eFPriceTextBox.Name = "eFPriceTextBox";
            this.eFPriceTextBox.ReadOnly = true;
            this.eFPriceTextBox.Size = new System.Drawing.Size(100, 21);
            this.eFPriceTextBox.TabIndex = 8;
            // 
            // handFeeTextBox
            // 
            // 
            // 
            // 
            this.handFeeTextBox.Border.Class = "TextBoxBorder";
            this.handFeeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.handFeeTextBox.Location = new System.Drawing.Point(116, 84);
            this.handFeeTextBox.Name = "handFeeTextBox";
            this.handFeeTextBox.ReadOnly = true;
            this.handFeeTextBox.Size = new System.Drawing.Size(61, 21);
            this.handFeeTextBox.TabIndex = 6;
            // 
            // handFeeCurrTextBox
            // 
            // 
            // 
            // 
            this.handFeeCurrTextBox.Border.Class = "TextBoxBorder";
            this.handFeeCurrTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.handFeeCurrTextBox.Location = new System.Drawing.Point(77, 84);
            this.handFeeCurrTextBox.Name = "handFeeCurrTextBox";
            this.handFeeCurrTextBox.ReadOnly = true;
            this.handFeeCurrTextBox.Size = new System.Drawing.Size(33, 21);
            this.handFeeCurrTextBox.TabIndex = 5;
            // 
            // panelCase
            // 
            this.panelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCase.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelCase.Controls.Add(this.tbNetPaymentTerm);
            this.panelCase.Controls.Add(this.tbPaymentTerms);
            this.panelCase.Controls.Add(lblPaymentTerms);
            this.panelCase.Controls.Add(this.tbCaseCode);
            this.panelCase.Controls.Add(lblCaseCode);
            this.panelCase.Controls.Add(this.tbCDACode);
            this.panelCase.Controls.Add(lblCDACode);
            this.panelCase.Controls.Add(lblIsNotice);
            this.panelCase.Controls.Add(this.tbIsNotice);
            this.panelCase.Controls.Add(ownerDepartmentCodeLabel);
            this.panelCase.Controls.Add(this.btnCaseQuery);
            this.panelCase.Controls.Add(assignTypeLabel);
            this.panelCase.Controls.Add(this.ownerDepartmentCodeTextBox);
            this.panelCase.Controls.Add(this.assignTypeTextBox);
            this.panelCase.Controls.Add(this.sellerEDICodeTextBox);
            this.panelCase.Controls.Add(sellerEDICodeLabel);
            this.panelCase.Controls.Add(this.sellerNameTextBox);
            this.panelCase.Controls.Add(this.buyerEDICodeTextBox);
            this.panelCase.Controls.Add(buyerEDICodeLabel);
            this.panelCase.Controls.Add(this.buyerNameTextBox);
            this.panelCase.Controls.Add(this.isRecoarseCheckBox);
            this.panelCase.Controls.Add(this.factorCodeTextBox);
            this.panelCase.Controls.Add(invoiceCurrencyLabel);
            this.panelCase.Controls.Add(factorCodeLabel);
            this.panelCase.Controls.Add(this.invoiceCurrencyTextBox);
            this.panelCase.Controls.Add(this.factorNameTextBox);
            this.panelCase.Controls.Add(transactionTypeLabel);
            this.panelCase.Controls.Add(this.transactionTypeTextBox);
            this.panelCase.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCase.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCase.ExpandOnTitleClick = true;
            this.panelCase.Location = new System.Drawing.Point(0, 14);
            this.panelCase.Name = "panelCase";
            this.panelCase.Size = new System.Drawing.Size(480, 148);
            this.panelCase.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCase.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCase.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCase.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCase.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCase.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCase.Style.GradientAngle = 90;
            this.panelCase.TabIndex = 7;
            this.panelCase.TitleHeight = 18;
            this.panelCase.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCase.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCase.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCase.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelCase.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCase.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCase.TitleStyle.GradientAngle = 90;
            this.panelCase.TitleText = "基本信息";
            // 
            // tbNetPaymentTerm
            // 
            // 
            // 
            // 
            this.tbNetPaymentTerm.Border.Class = "TextBoxBorder";
            this.tbNetPaymentTerm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNetPaymentTerm.Location = new System.Drawing.Point(97, 124);
            this.tbNetPaymentTerm.Name = "tbNetPaymentTerm";
            this.tbNetPaymentTerm.ReadOnly = true;
            this.tbNetPaymentTerm.Size = new System.Drawing.Size(64, 21);
            this.tbNetPaymentTerm.TabIndex = 61;
            // 
            // tbPaymentTerms
            // 
            // 
            // 
            // 
            this.tbPaymentTerms.Border.Class = "TextBoxBorder";
            this.tbPaymentTerms.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPaymentTerms.Location = new System.Drawing.Point(167, 125);
            this.tbPaymentTerms.Name = "tbPaymentTerms";
            this.tbPaymentTerms.ReadOnly = true;
            this.tbPaymentTerms.Size = new System.Drawing.Size(306, 21);
            this.tbPaymentTerms.TabIndex = 59;
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseCode.Location = new System.Drawing.Point(372, 43);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.ReadOnly = true;
            this.tbCaseCode.Size = new System.Drawing.Size(100, 21);
            this.tbCaseCode.TabIndex = 57;
            this.tbCaseCode.DoubleClick += new System.EventHandler(this.DetailCase);
            // 
            // tbCDACode
            // 
            // 
            // 
            // 
            this.tbCDACode.Border.Class = "TextBoxBorder";
            this.tbCDACode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCDACode.Location = new System.Drawing.Point(372, 24);
            this.tbCDACode.Name = "tbCDACode";
            this.tbCDACode.ReadOnly = true;
            this.tbCDACode.Size = new System.Drawing.Size(100, 21);
            this.tbCDACode.TabIndex = 55;
            this.tbCDACode.DoubleClick += new System.EventHandler(this.DetailCDA);
            // 
            // tbIsNotice
            // 
            // 
            // 
            // 
            this.tbIsNotice.Border.Class = "TextBoxBorder";
            this.tbIsNotice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIsNotice.Location = new System.Drawing.Point(373, 84);
            this.tbIsNotice.Name = "tbIsNotice";
            this.tbIsNotice.ReadOnly = true;
            this.tbIsNotice.Size = new System.Drawing.Size(100, 21);
            this.tbIsNotice.TabIndex = 52;
            // 
            // btnCaseQuery
            // 
            this.btnCaseQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseQuery.Location = new System.Drawing.Point(11, 47);
            this.btnCaseQuery.Name = "btnCaseQuery";
            this.btnCaseQuery.Size = new System.Drawing.Size(32, 27);
            this.btnCaseQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCaseQuery.TabIndex = 29;
            this.btnCaseQuery.Text = "...";
            this.btnCaseQuery.Click += new System.EventHandler(this.SelectCase);
            // 
            // ownerDepartmentCodeTextBox
            // 
            // 
            // 
            // 
            this.ownerDepartmentCodeTextBox.Border.Class = "TextBoxBorder";
            this.ownerDepartmentCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ownerDepartmentCodeTextBox.Location = new System.Drawing.Point(97, 22);
            this.ownerDepartmentCodeTextBox.Name = "ownerDepartmentCodeTextBox";
            this.ownerDepartmentCodeTextBox.ReadOnly = true;
            this.ownerDepartmentCodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.ownerDepartmentCodeTextBox.TabIndex = 31;
            // 
            // assignTypeTextBox
            // 
            // 
            // 
            // 
            this.assignTypeTextBox.Border.Class = "TextBoxBorder";
            this.assignTypeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignTypeTextBox.Location = new System.Drawing.Point(373, 64);
            this.assignTypeTextBox.Name = "assignTypeTextBox";
            this.assignTypeTextBox.ReadOnly = true;
            this.assignTypeTextBox.Size = new System.Drawing.Size(100, 21);
            this.assignTypeTextBox.TabIndex = 50;
            // 
            // sellerEDICodeTextBox
            // 
            // 
            // 
            // 
            this.sellerEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.sellerEDICodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sellerEDICodeTextBox.Location = new System.Drawing.Point(97, 44);
            this.sellerEDICodeTextBox.Name = "sellerEDICodeTextBox";
            this.sellerEDICodeTextBox.ReadOnly = true;
            this.sellerEDICodeTextBox.Size = new System.Drawing.Size(64, 21);
            this.sellerEDICodeTextBox.TabIndex = 33;
            this.sellerEDICodeTextBox.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // sellerNameTextBox
            // 
            // 
            // 
            // 
            this.sellerNameTextBox.Border.Class = "TextBoxBorder";
            this.sellerNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sellerNameTextBox.Location = new System.Drawing.Point(167, 44);
            this.sellerNameTextBox.Name = "sellerNameTextBox";
            this.sellerNameTextBox.ReadOnly = true;
            this.sellerNameTextBox.Size = new System.Drawing.Size(136, 21);
            this.sellerNameTextBox.TabIndex = 34;
            this.sellerNameTextBox.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // buyerEDICodeTextBox
            // 
            // 
            // 
            // 
            this.buyerEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.buyerEDICodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.buyerEDICodeTextBox.Location = new System.Drawing.Point(97, 64);
            this.buyerEDICodeTextBox.Name = "buyerEDICodeTextBox";
            this.buyerEDICodeTextBox.ReadOnly = true;
            this.buyerEDICodeTextBox.Size = new System.Drawing.Size(64, 21);
            this.buyerEDICodeTextBox.TabIndex = 36;
            this.buyerEDICodeTextBox.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // buyerNameTextBox
            // 
            // 
            // 
            // 
            this.buyerNameTextBox.Border.Class = "TextBoxBorder";
            this.buyerNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.buyerNameTextBox.Location = new System.Drawing.Point(167, 64);
            this.buyerNameTextBox.Name = "buyerNameTextBox";
            this.buyerNameTextBox.ReadOnly = true;
            this.buyerNameTextBox.Size = new System.Drawing.Size(136, 21);
            this.buyerNameTextBox.TabIndex = 37;
            this.buyerNameTextBox.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // isRecoarseCheckBox
            // 
            this.isRecoarseCheckBox.AutoSize = true;
            // 
            // 
            // 
            this.isRecoarseCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.isRecoarseCheckBox.Enabled = false;
            this.isRecoarseCheckBox.Location = new System.Drawing.Point(371, 105);
            this.isRecoarseCheckBox.Name = "isRecoarseCheckBox";
            this.isRecoarseCheckBox.Size = new System.Drawing.Size(101, 18);
            this.isRecoarseCheckBox.TabIndex = 53;
            this.isRecoarseCheckBox.Text = "是否有追索权";
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.factorCodeTextBox.Location = new System.Drawing.Point(97, 83);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.ReadOnly = true;
            this.factorCodeTextBox.Size = new System.Drawing.Size(64, 21);
            this.factorCodeTextBox.TabIndex = 39;
            this.factorCodeTextBox.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // invoiceCurrencyTextBox
            // 
            // 
            // 
            // 
            this.invoiceCurrencyTextBox.Border.Class = "TextBoxBorder";
            this.invoiceCurrencyTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceCurrencyTextBox.Location = new System.Drawing.Point(240, 24);
            this.invoiceCurrencyTextBox.Name = "invoiceCurrencyTextBox";
            this.invoiceCurrencyTextBox.ReadOnly = true;
            this.invoiceCurrencyTextBox.Size = new System.Drawing.Size(64, 21);
            this.invoiceCurrencyTextBox.TabIndex = 44;
            // 
            // factorNameTextBox
            // 
            // 
            // 
            // 
            this.factorNameTextBox.Border.Class = "TextBoxBorder";
            this.factorNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.factorNameTextBox.Location = new System.Drawing.Point(167, 83);
            this.factorNameTextBox.Name = "factorNameTextBox";
            this.factorNameTextBox.ReadOnly = true;
            this.factorNameTextBox.Size = new System.Drawing.Size(136, 21);
            this.factorNameTextBox.TabIndex = 40;
            this.factorNameTextBox.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // transactionTypeTextBox
            // 
            // 
            // 
            // 
            this.transactionTypeTextBox.Border.Class = "TextBoxBorder";
            this.transactionTypeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.transactionTypeTextBox.Location = new System.Drawing.Point(97, 103);
            this.transactionTypeTextBox.Name = "transactionTypeTextBox";
            this.transactionTypeTextBox.ReadOnly = true;
            this.transactionTypeTextBox.Size = new System.Drawing.Size(100, 21);
            this.transactionTypeTextBox.TabIndex = 42;
            // 
            // panelInvoiceMgr
            // 
            this.panelInvoiceMgr.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelInvoiceMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelInvoiceMgr.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoiceMgr.Location = new System.Drawing.Point(0, 162);
            this.panelInvoiceMgr.Name = "panelInvoiceMgr";
            this.panelInvoiceMgr.Size = new System.Drawing.Size(1254, 93);
            this.panelInvoiceMgr.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelInvoiceMgr.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelInvoiceMgr.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelInvoiceMgr.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelInvoiceMgr.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelInvoiceMgr.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelInvoiceMgr.Style.GradientAngle = 90;
            this.panelInvoiceMgr.TabIndex = 0;
            // 
            // ARCaseBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInvoiceMgr);
            this.Controls.Add(this.panelCaseBasic);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ARCaseBasic";
            this.Size = new System.Drawing.Size(1254, 255);
            this.panelCaseBasic.ResumeLayout(false);
            this.panelFinanceCreditLine.ResumeLayout(false);
            this.panelFinanceCreditLine.PerformLayout();
            this.panelBuyer.ResumeLayout(false);
            this.panelBuyer.PerformLayout();
            this.panelFee.ResumeLayout(false);
            this.panelFee.PerformLayout();
            this.panelCase.ResumeLayout(false);
            this.panelCase.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
