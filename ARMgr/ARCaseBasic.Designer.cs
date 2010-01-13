namespace CMBC.EasyFactor.ARMgr
{
    partial class ARCaseBasic
    {
		#region Fields (41) 

        private DevComponents.DotNetBar.Controls.TextBoxX commissionTypeTextBox;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX creditCoverCurrTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditCoverTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX eFPriceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeProportionTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX handFeeCurrTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX handFeeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX iFPriceTextBox;
        private DevComponents.DotNetBar.ExpandablePanel panelCaseBasic;
        private DevComponents.DotNetBar.PanelEx panelInvoiceMgr;
        private DevComponents.DotNetBar.Controls.TextBoxX periodEndTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX priceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAROutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceCreditLineOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLine;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLineCurr;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceOutstanding;

		#endregion Fields 

		#region Methods (1) 

		// Protected Methods (1) 

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#endregion Methods 



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
            DevComponents.DotNetBar.LabelX RMLabel;
            DevComponents.DotNetBar.LabelX PMLabel;
            DevComponents.DotNetBar.LabelX buyerEDICodeLabel;
            DevComponents.DotNetBar.LabelX invoiceCurrencyLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX transactionTypeLabel;
            DevComponents.DotNetBar.LabelX lblHighestFinance;
            DevComponents.DotNetBar.LabelX lblPaymentTerms;
            this.panelCaseBasic = new DevComponents.DotNetBar.ExpandablePanel();
            this.panelFinanceCreditLine = new DevComponents.DotNetBar.ExpandablePanel();
            this.tbHighestFinance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeProportionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceCreditLineOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceLineCurr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceLine = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbDueDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelBuyer = new DevComponents.DotNetBar.ExpandablePanel();
            this.tbAROutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverCurrTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCreditCoverOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.periodEndTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelFee = new DevComponents.DotNetBar.ExpandablePanel();
            this.commissionTypeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.priceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.RMTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sellerNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PMTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            RMLabel = new DevComponents.DotNetBar.LabelX();
            PMLabel = new DevComponents.DotNetBar.LabelX();
            buyerEDICodeLabel = new DevComponents.DotNetBar.LabelX();
            invoiceCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            transactionTypeLabel = new DevComponents.DotNetBar.LabelX();
            lblHighestFinance = new DevComponents.DotNetBar.LabelX();
            lblPaymentTerms = new DevComponents.DotNetBar.LabelX();
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
            priceLabel.BackgroundStyle.Class = "";
            priceLabel.Location = new System.Drawing.Point(6, 30);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(72, 16);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "总手续费率:";
            // 
            // iFPriceLabel
            // 
            iFPriceLabel.AutoSize = true;
            // 
            // 
            // 
            iFPriceLabel.BackgroundStyle.Class = "";
            iFPriceLabel.Location = new System.Drawing.Point(7, 71);
            iFPriceLabel.Name = "iFPriceLabel";
            iFPriceLabel.Size = new System.Drawing.Size(69, 16);
            iFPriceLabel.TabIndex = 2;
            iFPriceLabel.Text = "IF手续费率:";
            // 
            // handFeeCurrLabel
            // 
            handFeeCurrLabel.AutoSize = true;
            // 
            // 
            // 
            handFeeCurrLabel.BackgroundStyle.Class = "";
            handFeeCurrLabel.Location = new System.Drawing.Point(6, 93);
            handFeeCurrLabel.Name = "handFeeCurrLabel";
            handFeeCurrLabel.Size = new System.Drawing.Size(72, 16);
            handFeeCurrLabel.TabIndex = 4;
            handFeeCurrLabel.Text = "单据处理费:";
            // 
            // financeProportionLabel
            // 
            financeProportionLabel.AutoSize = true;
            // 
            // 
            // 
            financeProportionLabel.BackgroundStyle.Class = "";
            financeProportionLabel.Location = new System.Drawing.Point(17, 27);
            financeProportionLabel.Name = "financeProportionLabel";
            financeProportionLabel.Size = new System.Drawing.Size(59, 16);
            financeProportionLabel.TabIndex = 0;
            financeProportionLabel.Text = "预付比例:";
            // 
            // creditCoverCurrLabel
            // 
            creditCoverCurrLabel.AutoSize = true;
            // 
            // 
            // 
            creditCoverCurrLabel.BackgroundStyle.Class = "";
            creditCoverCurrLabel.Location = new System.Drawing.Point(6, 30);
            creditCoverCurrLabel.Name = "creditCoverCurrLabel";
            creditCoverCurrLabel.Size = new System.Drawing.Size(84, 16);
            creditCoverCurrLabel.TabIndex = 0;
            creditCoverCurrLabel.Text = "信用风险额度:";
            // 
            // periodEndLabel
            // 
            periodEndLabel.AutoSize = true;
            // 
            // 
            // 
            periodEndLabel.BackgroundStyle.Class = "";
            periodEndLabel.Location = new System.Drawing.Point(42, 54);
            periodEndLabel.Name = "periodEndLabel";
            periodEndLabel.Size = new System.Drawing.Size(47, 16);
            periodEndLabel.TabIndex = 3;
            periodEndLabel.Text = "到期日:";
            // 
            // lblBuyerCreditCoverBalance
            // 
            lblBuyerCreditCoverBalance.AutoSize = true;
            // 
            // 
            // 
            lblBuyerCreditCoverBalance.BackgroundStyle.Class = "";
            lblBuyerCreditCoverBalance.Location = new System.Drawing.Point(30, 79);
            lblBuyerCreditCoverBalance.Name = "lblBuyerCreditCoverBalance";
            lblBuyerCreditCoverBalance.Size = new System.Drawing.Size(59, 16);
            lblBuyerCreditCoverBalance.TabIndex = 5;
            lblBuyerCreditCoverBalance.Text = "剩余额度:";
            // 
            // lblBuyerARBalance
            // 
            lblBuyerARBalance.AutoSize = true;
            // 
            // 
            // 
            lblBuyerARBalance.BackgroundStyle.Class = "";
            lblBuyerARBalance.Location = new System.Drawing.Point(6, 99);
            lblBuyerARBalance.Name = "lblBuyerARBalance";
            lblBuyerARBalance.Size = new System.Drawing.Size(84, 16);
            lblBuyerARBalance.TabIndex = 7;
            lblBuyerARBalance.Text = "应收帐款余额:";
            // 
            // lblFinanceARBalance
            // 
            lblFinanceARBalance.AutoSize = true;
            // 
            // 
            // 
            lblFinanceARBalance.BackgroundStyle.Class = "";
            lblFinanceARBalance.Location = new System.Drawing.Point(15, 113);
            lblFinanceARBalance.Name = "lblFinanceARBalance";
            lblFinanceARBalance.Size = new System.Drawing.Size(59, 16);
            lblFinanceARBalance.TabIndex = 9;
            lblFinanceARBalance.Text = "融资余额:";
            // 
            // lblFinanceCreditCoverBalance
            // 
            lblFinanceCreditCoverBalance.AutoSize = true;
            // 
            // 
            // 
            lblFinanceCreditCoverBalance.BackgroundStyle.Class = "";
            lblFinanceCreditCoverBalance.Location = new System.Drawing.Point(16, 93);
            lblFinanceCreditCoverBalance.Name = "lblFinanceCreditCoverBalance";
            lblFinanceCreditCoverBalance.Size = new System.Drawing.Size(59, 16);
            lblFinanceCreditCoverBalance.TabIndex = 7;
            lblFinanceCreditCoverBalance.Text = "剩余额度:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            // 
            // 
            // 
            lblDueDate.BackgroundStyle.Class = "";
            lblDueDate.Location = new System.Drawing.Point(29, 73);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new System.Drawing.Size(47, 16);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "到期日:";
            // 
            // lblCreditLine
            // 
            lblCreditLine.AutoSize = true;
            // 
            // 
            // 
            lblCreditLine.BackgroundStyle.Class = "";
            lblCreditLine.Location = new System.Drawing.Point(5, 51);
            lblCreditLine.Name = "lblCreditLine";
            lblCreditLine.Size = new System.Drawing.Size(72, 16);
            lblCreditLine.TabIndex = 2;
            lblCreditLine.Text = "预付款额度:";
            // 
            // efPriceLbl
            // 
            efPriceLbl.AutoSize = true;
            // 
            // 
            // 
            efPriceLbl.BackgroundStyle.Class = "";
            efPriceLbl.Location = new System.Drawing.Point(6, 50);
            efPriceLbl.Name = "efPriceLbl";
            efPriceLbl.Size = new System.Drawing.Size(74, 16);
            efPriceLbl.TabIndex = 7;
            efPriceLbl.Text = "EF手续费率:";
            // 
            // lblCommissionType
            // 
            lblCommissionType.AutoSize = true;
            // 
            // 
            // 
            lblCommissionType.BackgroundStyle.Class = "";
            lblCommissionType.Location = new System.Drawing.Point(16, 113);
            lblCommissionType.Name = "lblCommissionType";
            lblCommissionType.Size = new System.Drawing.Size(59, 16);
            lblCommissionType.TabIndex = 9;
            lblCommissionType.Text = "计费方式:";
            // 
            // lblCaseCode
            // 
            lblCaseCode.AutoSize = true;
            // 
            // 
            // 
            lblCaseCode.BackgroundStyle.Class = "";
            lblCaseCode.Location = new System.Drawing.Point(307, 48);
            lblCaseCode.Name = "lblCaseCode";
            lblCaseCode.Size = new System.Drawing.Size(59, 16);
            lblCaseCode.TabIndex = 56;
            lblCaseCode.Text = "案件编号:";
            // 
            // lblCDACode
            // 
            lblCDACode.AutoSize = true;
            // 
            // 
            // 
            lblCDACode.BackgroundStyle.Class = "";
            lblCDACode.Location = new System.Drawing.Point(272, 27);
            lblCDACode.Name = "lblCDACode";
            lblCDACode.Size = new System.Drawing.Size(97, 16);
            lblCDACode.TabIndex = 54;
            lblCDACode.Text = "额度通知书编号:";
            // 
            // lblIsNotice
            // 
            lblIsNotice.AutoSize = true;
            // 
            // 
            // 
            lblIsNotice.BackgroundStyle.Class = "";
            lblIsNotice.Location = new System.Drawing.Point(307, 135);
            lblIsNotice.Name = "lblIsNotice";
            lblIsNotice.Size = new System.Drawing.Size(62, 16);
            lblIsNotice.TabIndex = 51;
            lblIsNotice.Text = "明/暗保理:";
            // 
            // ownerDepartmentCodeLabel
            // 
            ownerDepartmentCodeLabel.AutoSize = true;
            // 
            // 
            // 
            ownerDepartmentCodeLabel.BackgroundStyle.Class = "";
            ownerDepartmentCodeLabel.Location = new System.Drawing.Point(6, 30);
            ownerDepartmentCodeLabel.Name = "ownerDepartmentCodeLabel";
            ownerDepartmentCodeLabel.Size = new System.Drawing.Size(87, 16);
            ownerDepartmentCodeLabel.TabIndex = 30;
            ownerDepartmentCodeLabel.Text = " 业务归属机构:";
            // 
            // assignTypeLabel
            // 
            assignTypeLabel.AutoSize = true;
            // 
            // 
            // 
            assignTypeLabel.BackgroundStyle.Class = "";
            assignTypeLabel.Location = new System.Drawing.Point(309, 112);
            assignTypeLabel.Name = "assignTypeLabel";
            assignTypeLabel.Size = new System.Drawing.Size(59, 16);
            assignTypeLabel.TabIndex = 49;
            assignTypeLabel.Text = "转让方式:";
            // 
            // sellerEDICodeLabel
            // 
            sellerEDICodeLabel.AutoSize = true;
            // 
            // 
            // 
            sellerEDICodeLabel.BackgroundStyle.Class = "";
            sellerEDICodeLabel.Location = new System.Drawing.Point(56, 49);
            sellerEDICodeLabel.Name = "sellerEDICodeLabel";
            sellerEDICodeLabel.Size = new System.Drawing.Size(34, 16);
            sellerEDICodeLabel.TabIndex = 32;
            sellerEDICodeLabel.Text = "卖方:";
            // 
            // RMLabel
            // 
            RMLabel.AutoSize = true;
            // 
            // 
            // 
            RMLabel.BackgroundStyle.Class = "";
            RMLabel.Location = new System.Drawing.Point(309, 93);
            RMLabel.Name = "RMLabel";
            RMLabel.Size = new System.Drawing.Size(59, 16);
            RMLabel.TabIndex = 47;
            RMLabel.Text = "客户经理:";
            // 
            // PMLabel
            // 
            PMLabel.AutoSize = true;
            // 
            // 
            // 
            PMLabel.BackgroundStyle.Class = "";
            PMLabel.Location = new System.Drawing.Point(309, 70);
            PMLabel.Name = "PMLabel";
            PMLabel.Size = new System.Drawing.Size(59, 16);
            PMLabel.TabIndex = 45;
            PMLabel.Text = "产品经理:";
            // 
            // buyerEDICodeLabel
            // 
            buyerEDICodeLabel.AutoSize = true;
            // 
            // 
            // 
            buyerEDICodeLabel.BackgroundStyle.Class = "";
            buyerEDICodeLabel.Location = new System.Drawing.Point(55, 71);
            buyerEDICodeLabel.Name = "buyerEDICodeLabel";
            buyerEDICodeLabel.Size = new System.Drawing.Size(34, 16);
            buyerEDICodeLabel.TabIndex = 35;
            buyerEDICodeLabel.Text = "买方:";
            // 
            // invoiceCurrencyLabel
            // 
            invoiceCurrencyLabel.AutoSize = true;
            // 
            // 
            // 
            invoiceCurrencyLabel.BackgroundStyle.Class = "";
            invoiceCurrencyLabel.Location = new System.Drawing.Point(31, 135);
            invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            invoiceCurrencyLabel.Size = new System.Drawing.Size(59, 16);
            invoiceCurrencyLabel.TabIndex = 43;
            invoiceCurrencyLabel.Text = "发票币别:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Location = new System.Drawing.Point(43, 91);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            factorCodeLabel.TabIndex = 38;
            factorCodeLabel.Text = "保理商:";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            // 
            // 
            // 
            transactionTypeLabel.BackgroundStyle.Class = "";
            transactionTypeLabel.Location = new System.Drawing.Point(31, 114);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new System.Drawing.Size(59, 16);
            transactionTypeLabel.TabIndex = 41;
            transactionTypeLabel.Text = "业务类别:";
            // 
            // lblHighestFinance
            // 
            lblHighestFinance.AutoSize = true;
            // 
            // 
            // 
            lblHighestFinance.BackgroundStyle.Class = "";
            lblHighestFinance.Location = new System.Drawing.Point(5, 134);
            lblHighestFinance.Name = "lblHighestFinance";
            lblHighestFinance.Size = new System.Drawing.Size(121, 16);
            lblHighestFinance.TabIndex = 11;
            lblHighestFinance.Text = "最高保理预付款额度:";
            // 
            // lblPaymentTerms
            // 
            lblPaymentTerms.AutoSize = true;
            // 
            // 
            // 
            lblPaymentTerms.BackgroundStyle.Class = "";
            lblPaymentTerms.Location = new System.Drawing.Point(27, 155);
            lblPaymentTerms.Name = "lblPaymentTerms";
            lblPaymentTerms.Size = new System.Drawing.Size(59, 16);
            lblPaymentTerms.TabIndex = 58;
            lblPaymentTerms.Text = "付款条件:";
            // 
            // panelCaseBasic
            // 
            this.panelCaseBasic.AutoScroll = true;
            this.panelCaseBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCaseBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCaseBasic.Controls.Add(this.panelFinanceCreditLine);
            this.panelCaseBasic.Controls.Add(this.panelBuyer);
            this.panelCaseBasic.Controls.Add(this.panelFee);
            this.panelCaseBasic.Controls.Add(this.panelCase);
            this.panelCaseBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaseBasic.ExpandOnTitleClick = true;
            this.panelCaseBasic.Location = new System.Drawing.Point(0, 0);
            this.panelCaseBasic.Margin = new System.Windows.Forms.Padding(0);
            this.panelCaseBasic.Name = "panelCaseBasic";
            this.panelCaseBasic.Size = new System.Drawing.Size(1254, 204);
            this.panelCaseBasic.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCaseBasic.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCaseBasic.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCaseBasic.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCaseBasic.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCaseBasic.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCaseBasic.Style.GradientAngle = 90;
            this.panelCaseBasic.TabIndex = 0;
            this.panelCaseBasic.TitleHeight = 15;
            this.panelCaseBasic.TitleText = "Title Bar";
            // 
            // panelFinanceCreditLine
            // 
            this.panelFinanceCreditLine.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinanceCreditLine.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelFinanceCreditLine.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFinanceCreditLine.Controls.Add(this.tbHighestFinance);
            this.panelFinanceCreditLine.Controls.Add(lblHighestFinance);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceOutstanding);
            this.panelFinanceCreditLine.Controls.Add(financeProportionLabel);
            this.panelFinanceCreditLine.Controls.Add(lblFinanceARBalance);
            this.panelFinanceCreditLine.Controls.Add(this.financeProportionTextBox);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceCreditLineOutstanding);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceLineCurr);
            this.panelFinanceCreditLine.Controls.Add(lblFinanceCreditCoverBalance);
            this.panelFinanceCreditLine.Controls.Add(lblCreditLine);
            this.panelFinanceCreditLine.Controls.Add(lblDueDate);
            this.panelFinanceCreditLine.Controls.Add(this.tbFinanceLine);
            this.panelFinanceCreditLine.Controls.Add(this.tbDueDate);
            this.panelFinanceCreditLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFinanceCreditLine.ExpandOnTitleClick = true;
            this.panelFinanceCreditLine.Location = new System.Drawing.Point(861, 15);
            this.panelFinanceCreditLine.Name = "panelFinanceCreditLine";
            this.panelFinanceCreditLine.Size = new System.Drawing.Size(188, 189);
            this.panelFinanceCreditLine.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceCreditLine.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceCreditLine.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceCreditLine.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinanceCreditLine.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelFinanceCreditLine.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelFinanceCreditLine.Style.GradientAngle = 90;
            this.panelFinanceCreditLine.TabIndex = 5;
            this.panelFinanceCreditLine.TitleHeight = 20;
            this.panelFinanceCreditLine.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceCreditLine.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceCreditLine.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceCreditLine.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFinanceCreditLine.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinanceCreditLine.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinanceCreditLine.TitleStyle.GradientAngle = 90;
            this.panelFinanceCreditLine.TitleText = "融资额度信息";
            // 
            // tbHighestFinance
            // 
            // 
            // 
            // 
            this.tbHighestFinance.Border.Class = "TextBoxBorder";
            this.tbHighestFinance.Location = new System.Drawing.Point(82, 151);
            this.tbHighestFinance.Name = "tbHighestFinance";
            this.tbHighestFinance.ReadOnly = true;
            this.tbHighestFinance.Size = new System.Drawing.Size(100, 20);
            this.tbHighestFinance.TabIndex = 12;
            // 
            // tbFinanceOutstanding
            // 
            // 
            // 
            // 
            this.tbFinanceOutstanding.Border.Class = "TextBoxBorder";
            this.tbFinanceOutstanding.Location = new System.Drawing.Point(82, 111);
            this.tbFinanceOutstanding.Name = "tbFinanceOutstanding";
            this.tbFinanceOutstanding.ReadOnly = true;
            this.tbFinanceOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceOutstanding.TabIndex = 10;
            // 
            // financeProportionTextBox
            // 
            // 
            // 
            // 
            this.financeProportionTextBox.Border.Class = "TextBoxBorder";
            this.financeProportionTextBox.Location = new System.Drawing.Point(82, 25);
            this.financeProportionTextBox.Name = "financeProportionTextBox";
            this.financeProportionTextBox.ReadOnly = true;
            this.financeProportionTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeProportionTextBox.TabIndex = 1;
            // 
            // tbFinanceCreditLineOutstanding
            // 
            // 
            // 
            // 
            this.tbFinanceCreditLineOutstanding.Border.Class = "TextBoxBorder";
            this.tbFinanceCreditLineOutstanding.Location = new System.Drawing.Point(82, 90);
            this.tbFinanceCreditLineOutstanding.Name = "tbFinanceCreditLineOutstanding";
            this.tbFinanceCreditLineOutstanding.ReadOnly = true;
            this.tbFinanceCreditLineOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceCreditLineOutstanding.TabIndex = 8;
            // 
            // tbFinanceLineCurr
            // 
            // 
            // 
            // 
            this.tbFinanceLineCurr.Border.Class = "TextBoxBorder";
            this.tbFinanceLineCurr.Location = new System.Drawing.Point(82, 47);
            this.tbFinanceLineCurr.Name = "tbFinanceLineCurr";
            this.tbFinanceLineCurr.ReadOnly = true;
            this.tbFinanceLineCurr.Size = new System.Drawing.Size(28, 20);
            this.tbFinanceLineCurr.TabIndex = 3;
            // 
            // tbFinanceLine
            // 
            // 
            // 
            // 
            this.tbFinanceLine.Border.Class = "TextBoxBorder";
            this.tbFinanceLine.Location = new System.Drawing.Point(117, 47);
            this.tbFinanceLine.Name = "tbFinanceLine";
            this.tbFinanceLine.ReadOnly = true;
            this.tbFinanceLine.Size = new System.Drawing.Size(65, 20);
            this.tbFinanceLine.TabIndex = 4;
            // 
            // tbDueDate
            // 
            // 
            // 
            // 
            this.tbDueDate.Border.Class = "TextBoxBorder";
            this.tbDueDate.Location = new System.Drawing.Point(82, 69);
            this.tbDueDate.Name = "tbDueDate";
            this.tbDueDate.ReadOnly = true;
            this.tbDueDate.Size = new System.Drawing.Size(100, 20);
            this.tbDueDate.TabIndex = 6;
            // 
            // panelBuyer
            // 
            this.panelBuyer.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBuyer.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelBuyer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBuyer.Controls.Add(this.tbAROutstanding);
            this.panelBuyer.Controls.Add(creditCoverCurrLabel);
            this.panelBuyer.Controls.Add(lblBuyerARBalance);
            this.panelBuyer.Controls.Add(this.creditCoverCurrTextBox);
            this.panelBuyer.Controls.Add(this.tbCreditCoverOutstanding);
            this.panelBuyer.Controls.Add(this.creditCoverTextBox);
            this.panelBuyer.Controls.Add(lblBuyerCreditCoverBalance);
            this.panelBuyer.Controls.Add(this.periodEndTextBox);
            this.panelBuyer.Controls.Add(periodEndLabel);
            this.panelBuyer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuyer.ExpandOnTitleClick = true;
            this.panelBuyer.Location = new System.Drawing.Point(652, 15);
            this.panelBuyer.Name = "panelBuyer";
            this.panelBuyer.Size = new System.Drawing.Size(209, 189);
            this.panelBuyer.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBuyer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBuyer.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBuyer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBuyer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelBuyer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelBuyer.Style.GradientAngle = 90;
            this.panelBuyer.TabIndex = 4;
            this.panelBuyer.TitleHeight = 20;
            this.panelBuyer.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBuyer.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBuyer.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBuyer.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelBuyer.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBuyer.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBuyer.TitleStyle.GradientAngle = 90;
            this.panelBuyer.TitleText = "买方信用担保";
            // 
            // tbAROutstanding
            // 
            // 
            // 
            // 
            this.tbAROutstanding.Border.Class = "TextBoxBorder";
            this.tbAROutstanding.Location = new System.Drawing.Point(92, 97);
            this.tbAROutstanding.Name = "tbAROutstanding";
            this.tbAROutstanding.ReadOnly = true;
            this.tbAROutstanding.Size = new System.Drawing.Size(108, 20);
            this.tbAROutstanding.TabIndex = 8;
            // 
            // creditCoverCurrTextBox
            // 
            // 
            // 
            // 
            this.creditCoverCurrTextBox.Border.Class = "TextBoxBorder";
            this.creditCoverCurrTextBox.Location = new System.Drawing.Point(94, 26);
            this.creditCoverCurrTextBox.Name = "creditCoverCurrTextBox";
            this.creditCoverCurrTextBox.ReadOnly = true;
            this.creditCoverCurrTextBox.Size = new System.Drawing.Size(28, 20);
            this.creditCoverCurrTextBox.TabIndex = 1;
            // 
            // tbCreditCoverOutstanding
            // 
            // 
            // 
            // 
            this.tbCreditCoverOutstanding.Border.Class = "TextBoxBorder";
            this.tbCreditCoverOutstanding.Location = new System.Drawing.Point(92, 73);
            this.tbCreditCoverOutstanding.Name = "tbCreditCoverOutstanding";
            this.tbCreditCoverOutstanding.ReadOnly = true;
            this.tbCreditCoverOutstanding.Size = new System.Drawing.Size(108, 20);
            this.tbCreditCoverOutstanding.TabIndex = 6;
            // 
            // creditCoverTextBox
            // 
            // 
            // 
            // 
            this.creditCoverTextBox.Border.Class = "TextBoxBorder";
            this.creditCoverTextBox.Location = new System.Drawing.Point(127, 26);
            this.creditCoverTextBox.Name = "creditCoverTextBox";
            this.creditCoverTextBox.ReadOnly = true;
            this.creditCoverTextBox.Size = new System.Drawing.Size(73, 20);
            this.creditCoverTextBox.TabIndex = 2;
            // 
            // periodEndTextBox
            // 
            // 
            // 
            // 
            this.periodEndTextBox.Border.Class = "TextBoxBorder";
            this.periodEndTextBox.Location = new System.Drawing.Point(92, 50);
            this.periodEndTextBox.Name = "periodEndTextBox";
            this.periodEndTextBox.ReadOnly = true;
            this.periodEndTextBox.Size = new System.Drawing.Size(108, 20);
            this.periodEndTextBox.TabIndex = 4;
            // 
            // panelFee
            // 
            this.panelFee.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFee.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelFee.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFee.Controls.Add(this.commissionTypeTextBox);
            this.panelFee.Controls.Add(priceLabel);
            this.panelFee.Controls.Add(lblCommissionType);
            this.panelFee.Controls.Add(this.priceTextBox);
            this.panelFee.Controls.Add(efPriceLbl);
            this.panelFee.Controls.Add(this.iFPriceTextBox);
            this.panelFee.Controls.Add(this.eFPriceTextBox);
            this.panelFee.Controls.Add(iFPriceLabel);
            this.panelFee.Controls.Add(this.handFeeTextBox);
            this.panelFee.Controls.Add(this.handFeeCurrTextBox);
            this.panelFee.Controls.Add(handFeeCurrLabel);
            this.panelFee.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFee.ExpandOnTitleClick = true;
            this.panelFee.Location = new System.Drawing.Point(480, 15);
            this.panelFee.Name = "panelFee";
            this.panelFee.Size = new System.Drawing.Size(172, 189);
            this.panelFee.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFee.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFee.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFee.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFee.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelFee.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelFee.Style.GradientAngle = 90;
            this.panelFee.TabIndex = 6;
            this.panelFee.TitleHeight = 20;
            this.panelFee.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFee.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFee.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFee.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelFee.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFee.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFee.TitleStyle.GradientAngle = 90;
            this.panelFee.TitleText = "费率/利率信息";
            // 
            // commissionTypeTextBox
            // 
            // 
            // 
            // 
            this.commissionTypeTextBox.Border.Class = "TextBoxBorder";
            this.commissionTypeTextBox.Location = new System.Drawing.Point(81, 112);
            this.commissionTypeTextBox.Name = "commissionTypeTextBox";
            this.commissionTypeTextBox.ReadOnly = true;
            this.commissionTypeTextBox.Size = new System.Drawing.Size(84, 20);
            this.commissionTypeTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            // 
            // 
            // 
            this.priceTextBox.Border.Class = "TextBoxBorder";
            this.priceTextBox.Location = new System.Drawing.Point(81, 27);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(84, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // iFPriceTextBox
            // 
            // 
            // 
            // 
            this.iFPriceTextBox.Border.Class = "TextBoxBorder";
            this.iFPriceTextBox.Location = new System.Drawing.Point(82, 69);
            this.iFPriceTextBox.Name = "iFPriceTextBox";
            this.iFPriceTextBox.ReadOnly = true;
            this.iFPriceTextBox.Size = new System.Drawing.Size(83, 20);
            this.iFPriceTextBox.TabIndex = 3;
            // 
            // eFPriceTextBox
            // 
            // 
            // 
            // 
            this.eFPriceTextBox.Border.Class = "TextBoxBorder";
            this.eFPriceTextBox.Location = new System.Drawing.Point(81, 48);
            this.eFPriceTextBox.Name = "eFPriceTextBox";
            this.eFPriceTextBox.ReadOnly = true;
            this.eFPriceTextBox.Size = new System.Drawing.Size(84, 20);
            this.eFPriceTextBox.TabIndex = 8;
            // 
            // handFeeTextBox
            // 
            // 
            // 
            // 
            this.handFeeTextBox.Border.Class = "TextBoxBorder";
            this.handFeeTextBox.Location = new System.Drawing.Point(116, 91);
            this.handFeeTextBox.Name = "handFeeTextBox";
            this.handFeeTextBox.ReadOnly = true;
            this.handFeeTextBox.Size = new System.Drawing.Size(49, 20);
            this.handFeeTextBox.TabIndex = 6;
            // 
            // handFeeCurrTextBox
            // 
            // 
            // 
            // 
            this.handFeeCurrTextBox.Border.Class = "TextBoxBorder";
            this.handFeeCurrTextBox.Location = new System.Drawing.Point(82, 91);
            this.handFeeCurrTextBox.Name = "handFeeCurrTextBox";
            this.handFeeCurrTextBox.ReadOnly = true;
            this.handFeeCurrTextBox.Size = new System.Drawing.Size(28, 20);
            this.handFeeCurrTextBox.TabIndex = 5;
            // 
            // panelCase
            // 
            this.panelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCase.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.panelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.panelCase.Controls.Add(this.RMTextBox);
            this.panelCase.Controls.Add(sellerEDICodeLabel);
            this.panelCase.Controls.Add(RMLabel);
            this.panelCase.Controls.Add(this.sellerNameTextBox);
            this.panelCase.Controls.Add(this.PMTextBox);
            this.panelCase.Controls.Add(this.buyerEDICodeTextBox);
            this.panelCase.Controls.Add(PMLabel);
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
            this.panelCase.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCase.ExpandOnTitleClick = true;
            this.panelCase.Location = new System.Drawing.Point(0, 15);
            this.panelCase.Name = "panelCase";
            this.panelCase.Size = new System.Drawing.Size(480, 189);
            this.panelCase.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCase.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCase.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCase.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCase.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelCase.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelCase.Style.GradientAngle = 90;
            this.panelCase.TabIndex = 7;
            this.panelCase.TitleHeight = 20;
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
            this.tbNetPaymentTerm.Location = new System.Drawing.Point(97, 157);
            this.tbNetPaymentTerm.Name = "tbNetPaymentTerm";
            this.tbNetPaymentTerm.ReadOnly = true;
            this.tbNetPaymentTerm.Size = new System.Drawing.Size(64, 20);
            this.tbNetPaymentTerm.TabIndex = 61;
            // 
            // tbPaymentTerms
            // 
            // 
            // 
            // 
            this.tbPaymentTerms.Border.Class = "TextBoxBorder";
            this.tbPaymentTerms.Location = new System.Drawing.Point(167, 158);
            this.tbPaymentTerms.Name = "tbPaymentTerms";
            this.tbPaymentTerms.ReadOnly = true;
            this.tbPaymentTerms.Size = new System.Drawing.Size(306, 20);
            this.tbPaymentTerms.TabIndex = 59;
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.Location = new System.Drawing.Point(373, 47);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.ReadOnly = true;
            this.tbCaseCode.Size = new System.Drawing.Size(100, 20);
            this.tbCaseCode.TabIndex = 57;
            this.tbCaseCode.Click += new System.EventHandler(this.DetailCase);
            // 
            // tbCDACode
            // 
            // 
            // 
            // 
            this.tbCDACode.Border.Class = "TextBoxBorder";
            this.tbCDACode.Location = new System.Drawing.Point(373, 26);
            this.tbCDACode.Name = "tbCDACode";
            this.tbCDACode.ReadOnly = true;
            this.tbCDACode.Size = new System.Drawing.Size(100, 20);
            this.tbCDACode.TabIndex = 55;
            this.tbCDACode.Click += new System.EventHandler(this.DetailCDA);
            // 
            // tbIsNotice
            // 
            // 
            // 
            // 
            this.tbIsNotice.Border.Class = "TextBoxBorder";
            this.tbIsNotice.Location = new System.Drawing.Point(373, 135);
            this.tbIsNotice.Name = "tbIsNotice";
            this.tbIsNotice.ReadOnly = true;
            this.tbIsNotice.Size = new System.Drawing.Size(100, 20);
            this.tbIsNotice.TabIndex = 52;
            // 
            // btnCaseQuery
            // 
            this.btnCaseQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseQuery.Location = new System.Drawing.Point(11, 51);
            this.btnCaseQuery.Name = "btnCaseQuery";
            this.btnCaseQuery.Size = new System.Drawing.Size(32, 29);
            this.btnCaseQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.ownerDepartmentCodeTextBox.Location = new System.Drawing.Point(97, 27);
            this.ownerDepartmentCodeTextBox.Name = "ownerDepartmentCodeTextBox";
            this.ownerDepartmentCodeTextBox.ReadOnly = true;
            this.ownerDepartmentCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerDepartmentCodeTextBox.TabIndex = 31;
            // 
            // assignTypeTextBox
            // 
            // 
            // 
            // 
            this.assignTypeTextBox.Border.Class = "TextBoxBorder";
            this.assignTypeTextBox.Location = new System.Drawing.Point(373, 113);
            this.assignTypeTextBox.Name = "assignTypeTextBox";
            this.assignTypeTextBox.ReadOnly = true;
            this.assignTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.assignTypeTextBox.TabIndex = 50;
            // 
            // sellerEDICodeTextBox
            // 
            // 
            // 
            // 
            this.sellerEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.sellerEDICodeTextBox.Location = new System.Drawing.Point(97, 48);
            this.sellerEDICodeTextBox.Name = "sellerEDICodeTextBox";
            this.sellerEDICodeTextBox.ReadOnly = true;
            this.sellerEDICodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.sellerEDICodeTextBox.TabIndex = 33;
            this.sellerEDICodeTextBox.Click += new System.EventHandler(this.DetailSeller);
            // 
            // RMTextBox
            // 
            // 
            // 
            // 
            this.RMTextBox.Border.Class = "TextBoxBorder";
            this.RMTextBox.Location = new System.Drawing.Point(373, 91);
            this.RMTextBox.Name = "RMTextBox";
            this.RMTextBox.ReadOnly = true;
            this.RMTextBox.Size = new System.Drawing.Size(100, 20);
            this.RMTextBox.TabIndex = 48;
            // 
            // sellerNameTextBox
            // 
            // 
            // 
            // 
            this.sellerNameTextBox.Border.Class = "TextBoxBorder";
            this.sellerNameTextBox.Location = new System.Drawing.Point(167, 48);
            this.sellerNameTextBox.Name = "sellerNameTextBox";
            this.sellerNameTextBox.ReadOnly = true;
            this.sellerNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.sellerNameTextBox.TabIndex = 34;
            this.sellerNameTextBox.Click += new System.EventHandler(this.DetailSeller);
            // 
            // PMTextBox
            // 
            // 
            // 
            // 
            this.PMTextBox.Border.Class = "TextBoxBorder";
            this.PMTextBox.Location = new System.Drawing.Point(373, 69);
            this.PMTextBox.Name = "PMTextBox";
            this.PMTextBox.ReadOnly = true;
            this.PMTextBox.Size = new System.Drawing.Size(100, 20);
            this.PMTextBox.TabIndex = 46;
            // 
            // buyerEDICodeTextBox
            // 
            // 
            // 
            // 
            this.buyerEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.buyerEDICodeTextBox.Location = new System.Drawing.Point(97, 69);
            this.buyerEDICodeTextBox.Name = "buyerEDICodeTextBox";
            this.buyerEDICodeTextBox.ReadOnly = true;
            this.buyerEDICodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.buyerEDICodeTextBox.TabIndex = 36;
            this.buyerEDICodeTextBox.Click += new System.EventHandler(this.DetailBuyer);
            // 
            // buyerNameTextBox
            // 
            // 
            // 
            // 
            this.buyerNameTextBox.Border.Class = "TextBoxBorder";
            this.buyerNameTextBox.Location = new System.Drawing.Point(167, 69);
            this.buyerNameTextBox.Name = "buyerNameTextBox";
            this.buyerNameTextBox.ReadOnly = true;
            this.buyerNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.buyerNameTextBox.TabIndex = 37;
            this.buyerNameTextBox.Click += new System.EventHandler(this.DetailBuyer);
            // 
            // isRecoarseCheckBox
            // 
            this.isRecoarseCheckBox.AutoSize = true;
            // 
            // 
            // 
            this.isRecoarseCheckBox.BackgroundStyle.Class = "";
            this.isRecoarseCheckBox.Enabled = false;
            this.isRecoarseCheckBox.Location = new System.Drawing.Point(198, 138);
            this.isRecoarseCheckBox.Name = "isRecoarseCheckBox";
            this.isRecoarseCheckBox.Size = new System.Drawing.Size(101, 16);
            this.isRecoarseCheckBox.TabIndex = 53;
            this.isRecoarseCheckBox.Text = "是否有追索权";
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.Location = new System.Drawing.Point(97, 90);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.ReadOnly = true;
            this.factorCodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.factorCodeTextBox.TabIndex = 39;
            this.factorCodeTextBox.Click += new System.EventHandler(this.DetailFactor);
            // 
            // invoiceCurrencyTextBox
            // 
            // 
            // 
            // 
            this.invoiceCurrencyTextBox.Border.Class = "TextBoxBorder";
            this.invoiceCurrencyTextBox.Location = new System.Drawing.Point(97, 134);
            this.invoiceCurrencyTextBox.Name = "invoiceCurrencyTextBox";
            this.invoiceCurrencyTextBox.ReadOnly = true;
            this.invoiceCurrencyTextBox.Size = new System.Drawing.Size(64, 20);
            this.invoiceCurrencyTextBox.TabIndex = 44;
            // 
            // factorNameTextBox
            // 
            // 
            // 
            // 
            this.factorNameTextBox.Border.Class = "TextBoxBorder";
            this.factorNameTextBox.Location = new System.Drawing.Point(167, 90);
            this.factorNameTextBox.Name = "factorNameTextBox";
            this.factorNameTextBox.ReadOnly = true;
            this.factorNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.factorNameTextBox.TabIndex = 40;
            this.factorNameTextBox.Click += new System.EventHandler(this.DetailFactor);
            // 
            // transactionTypeTextBox
            // 
            // 
            // 
            // 
            this.transactionTypeTextBox.Border.Class = "TextBoxBorder";
            this.transactionTypeTextBox.Location = new System.Drawing.Point(97, 112);
            this.transactionTypeTextBox.Name = "transactionTypeTextBox";
            this.transactionTypeTextBox.ReadOnly = true;
            this.transactionTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionTypeTextBox.TabIndex = 42;
            // 
            // panelInvoiceMgr
            // 
            this.panelInvoiceMgr.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelInvoiceMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoiceMgr.Location = new System.Drawing.Point(0, 204);
            this.panelInvoiceMgr.Name = "panelInvoiceMgr";
            this.panelInvoiceMgr.Size = new System.Drawing.Size(1254, 72);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInvoiceMgr);
            this.Controls.Add(this.panelCaseBasic);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ARCaseBasic";
            this.Size = new System.Drawing.Size(1254, 276);
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

        private DevComponents.DotNetBar.ExpandablePanel panelBuyer;
        private DevComponents.DotNetBar.ExpandablePanel panelCase;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCDACode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIsNotice;
        private DevComponents.DotNetBar.ButtonX btnCaseQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX ownerDepartmentCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX assignTypeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX RMTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX PMTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerNameTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isRecoarseCheckBox;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceCurrencyTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX factorNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX transactionTypeTextBox;
        private DevComponents.DotNetBar.ExpandablePanel panelFee;
        private DevComponents.DotNetBar.ExpandablePanel panelFinanceCreditLine;
        private DevComponents.DotNetBar.Controls.TextBoxX tbHighestFinance;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentTerms;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNetPaymentTerm;
    }
}
