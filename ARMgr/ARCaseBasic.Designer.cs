namespace CMBC.EasyFactor.ARMgr
{
    partial class ARCaseBasic
    {
		#region Fields (37) 

        private DevComponents.DotNetBar.Controls.TextBoxX assignTypeTextBox;
        private DevComponents.DotNetBar.ButtonX btnCaseQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerNameTextBox;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX creditCoverCurrTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditCoverTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX factorNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeProportionTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupCaseBasic;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditCover;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFinanceCreditLine;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX handFeeCurrTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX handFeeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX iFPriceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceCurrencyTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isRecoarseCheckBox;
        private DevComponents.DotNetBar.Controls.TextBoxX ownerDepartmentCodeTextBox;
        private DevComponents.DotNetBar.PanelEx panelCaseBasic;
        private DevComponents.DotNetBar.PanelEx panelInvoiceMgr;
        private DevComponents.DotNetBar.Controls.TextBoxX periodEndTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX PMTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX priceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX RMTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAROutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLine;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLineCurr;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceCreditLineOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX transactionTypeTextBox;

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
            DevComponents.DotNetBar.LabelX ownerDepartmentCodeLabel;
            DevComponents.DotNetBar.LabelX sellerEDICodeLabel;
            DevComponents.DotNetBar.LabelX buyerEDICodeLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX transactionTypeLabel;
            DevComponents.DotNetBar.LabelX invoiceCurrencyLabel;
            DevComponents.DotNetBar.LabelX PMLabel;
            DevComponents.DotNetBar.LabelX RMLabel;
            DevComponents.DotNetBar.LabelX assignTypeLabel;
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
            DevComponents.DotNetBar.LabelX lblIsNotice;
            DevComponents.DotNetBar.LabelX efPriceLbl;
            DevComponents.DotNetBar.LabelX lblCommissionType;
            this.panelCaseBasic = new DevComponents.DotNetBar.PanelEx();
            this.groupPanelFinanceCreditLine = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbFinanceOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceCreditLineOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbDueDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceLine = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceLineCurr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeProportionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelCreditCover = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbAROutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCreditCoverOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.periodEndTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverCurrTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelPrice = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.commissionTypeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.eFPriceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.handFeeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.handFeeCurrTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.iFPriceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.priceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupCaseBasic = new DevComponents.DotNetBar.Controls.GroupPanel();
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
            ownerDepartmentCodeLabel = new DevComponents.DotNetBar.LabelX();
            sellerEDICodeLabel = new DevComponents.DotNetBar.LabelX();
            buyerEDICodeLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            transactionTypeLabel = new DevComponents.DotNetBar.LabelX();
            invoiceCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            PMLabel = new DevComponents.DotNetBar.LabelX();
            RMLabel = new DevComponents.DotNetBar.LabelX();
            assignTypeLabel = new DevComponents.DotNetBar.LabelX();
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
            lblIsNotice = new DevComponents.DotNetBar.LabelX();
            efPriceLbl = new DevComponents.DotNetBar.LabelX();
            lblCommissionType = new DevComponents.DotNetBar.LabelX();
            this.panelCaseBasic.SuspendLayout();
            this.groupPanelFinanceCreditLine.SuspendLayout();
            this.groupPanelCreditCover.SuspendLayout();
            this.groupPanelPrice.SuspendLayout();
            this.groupCaseBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownerDepartmentCodeLabel
            // 
            ownerDepartmentCodeLabel.AutoSize = true;
            // 
            // 
            // 
            ownerDepartmentCodeLabel.BackgroundStyle.Class = "";
            ownerDepartmentCodeLabel.Location = new System.Drawing.Point(-2, 4);
            ownerDepartmentCodeLabel.Name = "ownerDepartmentCodeLabel";
            ownerDepartmentCodeLabel.Size = new System.Drawing.Size(87, 16);
            ownerDepartmentCodeLabel.TabIndex = 1;
            ownerDepartmentCodeLabel.Text = " 业务归属机构:";
            // 
            // sellerEDICodeLabel
            // 
            sellerEDICodeLabel.AutoSize = true;
            // 
            // 
            // 
            sellerEDICodeLabel.BackgroundStyle.Class = "";
            sellerEDICodeLabel.Location = new System.Drawing.Point(48, 23);
            sellerEDICodeLabel.Name = "sellerEDICodeLabel";
            sellerEDICodeLabel.Size = new System.Drawing.Size(34, 16);
            sellerEDICodeLabel.TabIndex = 3;
            sellerEDICodeLabel.Text = "卖方:";
            // 
            // buyerEDICodeLabel
            // 
            buyerEDICodeLabel.AutoSize = true;
            // 
            // 
            // 
            buyerEDICodeLabel.BackgroundStyle.Class = "";
            buyerEDICodeLabel.Location = new System.Drawing.Point(47, 45);
            buyerEDICodeLabel.Name = "buyerEDICodeLabel";
            buyerEDICodeLabel.Size = new System.Drawing.Size(34, 16);
            buyerEDICodeLabel.TabIndex = 6;
            buyerEDICodeLabel.Text = "买方:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Location = new System.Drawing.Point(35, 65);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            factorCodeLabel.TabIndex = 9;
            factorCodeLabel.Text = "保理商:";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            // 
            // 
            // 
            transactionTypeLabel.BackgroundStyle.Class = "";
            transactionTypeLabel.Location = new System.Drawing.Point(23, 88);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new System.Drawing.Size(59, 16);
            transactionTypeLabel.TabIndex = 12;
            transactionTypeLabel.Text = "业务类别:";
            // 
            // invoiceCurrencyLabel
            // 
            invoiceCurrencyLabel.AutoSize = true;
            // 
            // 
            // 
            invoiceCurrencyLabel.BackgroundStyle.Class = "";
            invoiceCurrencyLabel.Location = new System.Drawing.Point(23, 109);
            invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            invoiceCurrencyLabel.Size = new System.Drawing.Size(59, 16);
            invoiceCurrencyLabel.TabIndex = 14;
            invoiceCurrencyLabel.Text = "发票币别:";
            // 
            // PMLabel
            // 
            PMLabel.AutoSize = true;
            // 
            // 
            // 
            PMLabel.BackgroundStyle.Class = "";
            PMLabel.Location = new System.Drawing.Point(301, 23);
            PMLabel.Name = "PMLabel";
            PMLabel.Size = new System.Drawing.Size(59, 16);
            PMLabel.TabIndex = 16;
            PMLabel.Text = "产品经理:";
            // 
            // RMLabel
            // 
            RMLabel.AutoSize = true;
            // 
            // 
            // 
            RMLabel.BackgroundStyle.Class = "";
            RMLabel.Location = new System.Drawing.Point(301, 46);
            RMLabel.Name = "RMLabel";
            RMLabel.Size = new System.Drawing.Size(59, 16);
            RMLabel.TabIndex = 18;
            RMLabel.Text = "客户经理:";
            // 
            // assignTypeLabel
            // 
            assignTypeLabel.AutoSize = true;
            // 
            // 
            // 
            assignTypeLabel.BackgroundStyle.Class = "";
            assignTypeLabel.Location = new System.Drawing.Point(301, 65);
            assignTypeLabel.Name = "assignTypeLabel";
            assignTypeLabel.Size = new System.Drawing.Size(59, 16);
            assignTypeLabel.TabIndex = 20;
            assignTypeLabel.Text = "转让方式:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            // 
            // 
            // 
            priceLabel.BackgroundStyle.Class = "";
            priceLabel.Location = new System.Drawing.Point(5, 8);
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
            iFPriceLabel.Location = new System.Drawing.Point(6, 49);
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
            handFeeCurrLabel.Location = new System.Drawing.Point(5, 71);
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
            financeProportionLabel.Location = new System.Drawing.Point(15, 6);
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
            creditCoverCurrLabel.Location = new System.Drawing.Point(3, 8);
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
            periodEndLabel.Location = new System.Drawing.Point(39, 32);
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
            lblBuyerCreditCoverBalance.Location = new System.Drawing.Point(27, 57);
            lblBuyerCreditCoverBalance.Name = "lblBuyerCreditCoverBalance";
            lblBuyerCreditCoverBalance.Size = new System.Drawing.Size(59, 16);
            lblBuyerCreditCoverBalance.TabIndex = 5;
            lblBuyerCreditCoverBalance.Text = "授信余额:";
            // 
            // lblBuyerARBalance
            // 
            lblBuyerARBalance.AutoSize = true;
            // 
            // 
            // 
            lblBuyerARBalance.BackgroundStyle.Class = "";
            lblBuyerARBalance.Location = new System.Drawing.Point(3, 77);
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
            lblFinanceARBalance.Location = new System.Drawing.Point(13, 92);
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
            lblFinanceCreditCoverBalance.Location = new System.Drawing.Point(14, 72);
            lblFinanceCreditCoverBalance.Name = "lblFinanceCreditCoverBalance";
            lblFinanceCreditCoverBalance.Size = new System.Drawing.Size(59, 16);
            lblFinanceCreditCoverBalance.TabIndex = 7;
            lblFinanceCreditCoverBalance.Text = "授信余额:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            // 
            // 
            // 
            lblDueDate.BackgroundStyle.Class = "";
            lblDueDate.Location = new System.Drawing.Point(27, 52);
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
            lblCreditLine.Location = new System.Drawing.Point(3, 30);
            lblCreditLine.Name = "lblCreditLine";
            lblCreditLine.Size = new System.Drawing.Size(72, 16);
            lblCreditLine.TabIndex = 2;
            lblCreditLine.Text = "预付款额度:";
            // 
            // lblIsNotice
            // 
            lblIsNotice.AutoSize = true;
            // 
            // 
            // 
            lblIsNotice.BackgroundStyle.Class = "";
            lblIsNotice.Location = new System.Drawing.Point(299, 88);
            lblIsNotice.Name = "lblIsNotice";
            lblIsNotice.Size = new System.Drawing.Size(62, 16);
            lblIsNotice.TabIndex = 22;
            lblIsNotice.Text = "明/暗保理:";
            // 
            // efPriceLbl
            // 
            efPriceLbl.AutoSize = true;
            // 
            // 
            // 
            efPriceLbl.BackgroundStyle.Class = "";
            efPriceLbl.Location = new System.Drawing.Point(5, 28);
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
            lblCommissionType.Location = new System.Drawing.Point(15, 91);
            lblCommissionType.Name = "lblCommissionType";
            lblCommissionType.Size = new System.Drawing.Size(59, 16);
            lblCommissionType.TabIndex = 9;
            lblCommissionType.Text = "计费方式:";
            // 
            // panelCaseBasic
            // 
            this.panelCaseBasic.AutoScroll = true;
            this.panelCaseBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCaseBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCaseBasic.Controls.Add(this.groupPanelFinanceCreditLine);
            this.panelCaseBasic.Controls.Add(this.groupPanelCreditCover);
            this.panelCaseBasic.Controls.Add(this.groupPanelPrice);
            this.panelCaseBasic.Controls.Add(this.groupCaseBasic);
            this.panelCaseBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaseBasic.Location = new System.Drawing.Point(0, 0);
            this.panelCaseBasic.Name = "panelCaseBasic";
            this.panelCaseBasic.Size = new System.Drawing.Size(1054, 158);
            this.panelCaseBasic.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCaseBasic.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCaseBasic.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCaseBasic.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCaseBasic.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCaseBasic.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCaseBasic.Style.GradientAngle = 90;
            this.panelCaseBasic.TabIndex = 0;
            // 
            // groupPanelFinanceCreditLine
            // 
            this.groupPanelFinanceCreditLine.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelFinanceCreditLine.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelFinanceCreditLine.Controls.Add(this.tbFinanceOutstanding);
            this.groupPanelFinanceCreditLine.Controls.Add(lblFinanceARBalance);
            this.groupPanelFinanceCreditLine.Controls.Add(this.tbFinanceCreditLineOutstanding);
            this.groupPanelFinanceCreditLine.Controls.Add(lblFinanceCreditCoverBalance);
            this.groupPanelFinanceCreditLine.Controls.Add(lblDueDate);
            this.groupPanelFinanceCreditLine.Controls.Add(this.tbDueDate);
            this.groupPanelFinanceCreditLine.Controls.Add(this.tbFinanceLine);
            this.groupPanelFinanceCreditLine.Controls.Add(lblCreditLine);
            this.groupPanelFinanceCreditLine.Controls.Add(this.tbFinanceLineCurr);
            this.groupPanelFinanceCreditLine.Controls.Add(financeProportionLabel);
            this.groupPanelFinanceCreditLine.Controls.Add(this.financeProportionTextBox);
            this.groupPanelFinanceCreditLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanelFinanceCreditLine.Location = new System.Drawing.Point(860, 0);
            this.groupPanelFinanceCreditLine.Name = "groupPanelFinanceCreditLine";
            this.groupPanelFinanceCreditLine.Size = new System.Drawing.Size(191, 158);
            // 
            // 
            // 
            this.groupPanelFinanceCreditLine.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelFinanceCreditLine.Style.BackColorGradientAngle = 90;
            this.groupPanelFinanceCreditLine.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelFinanceCreditLine.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFinanceCreditLine.Style.BorderBottomWidth = 1;
            this.groupPanelFinanceCreditLine.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelFinanceCreditLine.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFinanceCreditLine.Style.BorderLeftWidth = 1;
            this.groupPanelFinanceCreditLine.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFinanceCreditLine.Style.BorderRightWidth = 1;
            this.groupPanelFinanceCreditLine.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFinanceCreditLine.Style.BorderTopWidth = 1;
            this.groupPanelFinanceCreditLine.Style.Class = "";
            this.groupPanelFinanceCreditLine.Style.CornerDiameter = 4;
            this.groupPanelFinanceCreditLine.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelFinanceCreditLine.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelFinanceCreditLine.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelFinanceCreditLine.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelFinanceCreditLine.StyleMouseOver.Class = "";
            this.groupPanelFinanceCreditLine.TabIndex = 3;
            this.groupPanelFinanceCreditLine.Text = "融资额度信息";
            // 
            // tbFinanceOutstanding
            // 
            // 
            // 
            // 
            this.tbFinanceOutstanding.Border.Class = "TextBoxBorder";
            this.tbFinanceOutstanding.Location = new System.Drawing.Point(80, 90);
            this.tbFinanceOutstanding.Name = "tbFinanceOutstanding";
            this.tbFinanceOutstanding.ReadOnly = true;
            this.tbFinanceOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceOutstanding.TabIndex = 10;
            // 
            // tbFinanceCreditLineOutstanding
            // 
            // 
            // 
            // 
            this.tbFinanceCreditLineOutstanding.Border.Class = "TextBoxBorder";
            this.tbFinanceCreditLineOutstanding.Location = new System.Drawing.Point(80, 69);
            this.tbFinanceCreditLineOutstanding.Name = "tbFinanceCreditLineOutstanding";
            this.tbFinanceCreditLineOutstanding.ReadOnly = true;
            this.tbFinanceCreditLineOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceCreditLineOutstanding.TabIndex = 8;
            // 
            // tbDueDate
            // 
            // 
            // 
            // 
            this.tbDueDate.Border.Class = "TextBoxBorder";
            this.tbDueDate.Location = new System.Drawing.Point(80, 48);
            this.tbDueDate.Name = "tbDueDate";
            this.tbDueDate.ReadOnly = true;
            this.tbDueDate.Size = new System.Drawing.Size(100, 20);
            this.tbDueDate.TabIndex = 6;
            // 
            // tbFinanceLine
            // 
            // 
            // 
            // 
            this.tbFinanceLine.Border.Class = "TextBoxBorder";
            this.tbFinanceLine.Location = new System.Drawing.Point(115, 26);
            this.tbFinanceLine.Name = "tbFinanceLine";
            this.tbFinanceLine.ReadOnly = true;
            this.tbFinanceLine.Size = new System.Drawing.Size(58, 20);
            this.tbFinanceLine.TabIndex = 4;
            // 
            // tbFinanceLineCurr
            // 
            // 
            // 
            // 
            this.tbFinanceLineCurr.Border.Class = "TextBoxBorder";
            this.tbFinanceLineCurr.Location = new System.Drawing.Point(80, 26);
            this.tbFinanceLineCurr.Name = "tbFinanceLineCurr";
            this.tbFinanceLineCurr.ReadOnly = true;
            this.tbFinanceLineCurr.Size = new System.Drawing.Size(28, 20);
            this.tbFinanceLineCurr.TabIndex = 3;
            // 
            // financeProportionTextBox
            // 
            // 
            // 
            // 
            this.financeProportionTextBox.Border.Class = "TextBoxBorder";
            this.financeProportionTextBox.Location = new System.Drawing.Point(80, 4);
            this.financeProportionTextBox.Name = "financeProportionTextBox";
            this.financeProportionTextBox.ReadOnly = true;
            this.financeProportionTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeProportionTextBox.TabIndex = 1;
            // 
            // groupPanelCreditCover
            // 
            this.groupPanelCreditCover.AutoScroll = true;
            this.groupPanelCreditCover.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCreditCover.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCreditCover.Controls.Add(this.tbAROutstanding);
            this.groupPanelCreditCover.Controls.Add(lblBuyerARBalance);
            this.groupPanelCreditCover.Controls.Add(this.tbCreditCoverOutstanding);
            this.groupPanelCreditCover.Controls.Add(lblBuyerCreditCoverBalance);
            this.groupPanelCreditCover.Controls.Add(periodEndLabel);
            this.groupPanelCreditCover.Controls.Add(this.periodEndTextBox);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverTextBox);
            this.groupPanelCreditCover.Controls.Add(creditCoverCurrLabel);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverCurrTextBox);
            this.groupPanelCreditCover.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanelCreditCover.Location = new System.Drawing.Point(654, 0);
            this.groupPanelCreditCover.Name = "groupPanelCreditCover";
            this.groupPanelCreditCover.Size = new System.Drawing.Size(206, 158);
            // 
            // 
            // 
            this.groupPanelCreditCover.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelCreditCover.Style.BackColorGradientAngle = 90;
            this.groupPanelCreditCover.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelCreditCover.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCover.Style.BorderBottomWidth = 1;
            this.groupPanelCreditCover.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelCreditCover.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCover.Style.BorderLeftWidth = 1;
            this.groupPanelCreditCover.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCover.Style.BorderRightWidth = 1;
            this.groupPanelCreditCover.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCover.Style.BorderTopWidth = 1;
            this.groupPanelCreditCover.Style.Class = "";
            this.groupPanelCreditCover.Style.CornerDiameter = 4;
            this.groupPanelCreditCover.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCreditCover.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCreditCover.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCreditCover.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelCreditCover.StyleMouseOver.Class = "";
            this.groupPanelCreditCover.TabIndex = 2;
            this.groupPanelCreditCover.Text = "买方信用担保";
            // 
            // tbAROutstanding
            // 
            // 
            // 
            // 
            this.tbAROutstanding.Border.Class = "TextBoxBorder";
            this.tbAROutstanding.Location = new System.Drawing.Point(89, 75);
            this.tbAROutstanding.Name = "tbAROutstanding";
            this.tbAROutstanding.ReadOnly = true;
            this.tbAROutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbAROutstanding.TabIndex = 8;
            // 
            // tbCreditCoverOutstanding
            // 
            // 
            // 
            // 
            this.tbCreditCoverOutstanding.Border.Class = "TextBoxBorder";
            this.tbCreditCoverOutstanding.Location = new System.Drawing.Point(89, 51);
            this.tbCreditCoverOutstanding.Name = "tbCreditCoverOutstanding";
            this.tbCreditCoverOutstanding.ReadOnly = true;
            this.tbCreditCoverOutstanding.Size = new System.Drawing.Size(100, 20);
            this.tbCreditCoverOutstanding.TabIndex = 6;
            // 
            // periodEndTextBox
            // 
            // 
            // 
            // 
            this.periodEndTextBox.Border.Class = "TextBoxBorder";
            this.periodEndTextBox.Location = new System.Drawing.Point(89, 28);
            this.periodEndTextBox.Name = "periodEndTextBox";
            this.periodEndTextBox.ReadOnly = true;
            this.periodEndTextBox.Size = new System.Drawing.Size(100, 20);
            this.periodEndTextBox.TabIndex = 4;
            // 
            // creditCoverTextBox
            // 
            // 
            // 
            // 
            this.creditCoverTextBox.Border.Class = "TextBoxBorder";
            this.creditCoverTextBox.Location = new System.Drawing.Point(124, 4);
            this.creditCoverTextBox.Name = "creditCoverTextBox";
            this.creditCoverTextBox.ReadOnly = true;
            this.creditCoverTextBox.Size = new System.Drawing.Size(65, 20);
            this.creditCoverTextBox.TabIndex = 2;
            // 
            // creditCoverCurrTextBox
            // 
            // 
            // 
            // 
            this.creditCoverCurrTextBox.Border.Class = "TextBoxBorder";
            this.creditCoverCurrTextBox.Location = new System.Drawing.Point(91, 4);
            this.creditCoverCurrTextBox.Name = "creditCoverCurrTextBox";
            this.creditCoverCurrTextBox.ReadOnly = true;
            this.creditCoverCurrTextBox.Size = new System.Drawing.Size(28, 20);
            this.creditCoverCurrTextBox.TabIndex = 1;
            // 
            // groupPanelPrice
            // 
            this.groupPanelPrice.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelPrice.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelPrice.Controls.Add(this.commissionTypeTextBox);
            this.groupPanelPrice.Controls.Add(lblCommissionType);
            this.groupPanelPrice.Controls.Add(efPriceLbl);
            this.groupPanelPrice.Controls.Add(this.eFPriceTextBox);
            this.groupPanelPrice.Controls.Add(this.handFeeTextBox);
            this.groupPanelPrice.Controls.Add(handFeeCurrLabel);
            this.groupPanelPrice.Controls.Add(this.handFeeCurrTextBox);
            this.groupPanelPrice.Controls.Add(iFPriceLabel);
            this.groupPanelPrice.Controls.Add(this.iFPriceTextBox);
            this.groupPanelPrice.Controls.Add(priceLabel);
            this.groupPanelPrice.Controls.Add(this.priceTextBox);
            this.groupPanelPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanelPrice.Location = new System.Drawing.Point(481, 0);
            this.groupPanelPrice.Name = "groupPanelPrice";
            this.groupPanelPrice.Size = new System.Drawing.Size(173, 158);
            // 
            // 
            // 
            this.groupPanelPrice.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelPrice.Style.BackColorGradientAngle = 90;
            this.groupPanelPrice.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelPrice.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelPrice.Style.BorderBottomWidth = 1;
            this.groupPanelPrice.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelPrice.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelPrice.Style.BorderLeftWidth = 1;
            this.groupPanelPrice.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelPrice.Style.BorderRightWidth = 1;
            this.groupPanelPrice.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelPrice.Style.BorderTopWidth = 1;
            this.groupPanelPrice.Style.Class = "";
            this.groupPanelPrice.Style.CornerDiameter = 4;
            this.groupPanelPrice.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelPrice.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelPrice.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelPrice.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelPrice.StyleMouseOver.Class = "";
            this.groupPanelPrice.TabIndex = 1;
            this.groupPanelPrice.Text = "费率/利率信息";
            // 
            // commissionTypeTextBox
            // 
            // 
            // 
            // 
            this.commissionTypeTextBox.Border.Class = "TextBoxBorder";
            this.commissionTypeTextBox.Location = new System.Drawing.Point(80, 90);
            this.commissionTypeTextBox.Name = "commissionTypeTextBox";
            this.commissionTypeTextBox.ReadOnly = true;
            this.commissionTypeTextBox.Size = new System.Drawing.Size(73, 20);
            this.commissionTypeTextBox.TabIndex = 10;
            // 
            // eFPriceTextBox
            // 
            // 
            // 
            // 
            this.eFPriceTextBox.Border.Class = "TextBoxBorder";
            this.eFPriceTextBox.Location = new System.Drawing.Point(80, 26);
            this.eFPriceTextBox.Name = "eFPriceTextBox";
            this.eFPriceTextBox.ReadOnly = true;
            this.eFPriceTextBox.Size = new System.Drawing.Size(73, 20);
            this.eFPriceTextBox.TabIndex = 8;
            // 
            // handFeeTextBox
            // 
            // 
            // 
            // 
            this.handFeeTextBox.Border.Class = "TextBoxBorder";
            this.handFeeTextBox.Location = new System.Drawing.Point(115, 69);
            this.handFeeTextBox.Name = "handFeeTextBox";
            this.handFeeTextBox.ReadOnly = true;
            this.handFeeTextBox.Size = new System.Drawing.Size(39, 20);
            this.handFeeTextBox.TabIndex = 6;
            // 
            // handFeeCurrTextBox
            // 
            // 
            // 
            // 
            this.handFeeCurrTextBox.Border.Class = "TextBoxBorder";
            this.handFeeCurrTextBox.Location = new System.Drawing.Point(81, 69);
            this.handFeeCurrTextBox.Name = "handFeeCurrTextBox";
            this.handFeeCurrTextBox.ReadOnly = true;
            this.handFeeCurrTextBox.Size = new System.Drawing.Size(28, 20);
            this.handFeeCurrTextBox.TabIndex = 5;
            // 
            // iFPriceTextBox
            // 
            // 
            // 
            // 
            this.iFPriceTextBox.Border.Class = "TextBoxBorder";
            this.iFPriceTextBox.Location = new System.Drawing.Point(81, 47);
            this.iFPriceTextBox.Name = "iFPriceTextBox";
            this.iFPriceTextBox.ReadOnly = true;
            this.iFPriceTextBox.Size = new System.Drawing.Size(73, 20);
            this.iFPriceTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            // 
            // 
            // 
            this.priceTextBox.Border.Class = "TextBoxBorder";
            this.priceTextBox.Location = new System.Drawing.Point(80, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(74, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // groupCaseBasic
            // 
            this.groupCaseBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupCaseBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupCaseBasic.Controls.Add(lblIsNotice);
            this.groupCaseBasic.Controls.Add(this.tbIsNotice);
            this.groupCaseBasic.Controls.Add(ownerDepartmentCodeLabel);
            this.groupCaseBasic.Controls.Add(this.btnCaseQuery);
            this.groupCaseBasic.Controls.Add(assignTypeLabel);
            this.groupCaseBasic.Controls.Add(this.ownerDepartmentCodeTextBox);
            this.groupCaseBasic.Controls.Add(this.assignTypeTextBox);
            this.groupCaseBasic.Controls.Add(this.sellerEDICodeTextBox);
            this.groupCaseBasic.Controls.Add(this.RMTextBox);
            this.groupCaseBasic.Controls.Add(sellerEDICodeLabel);
            this.groupCaseBasic.Controls.Add(RMLabel);
            this.groupCaseBasic.Controls.Add(this.sellerNameTextBox);
            this.groupCaseBasic.Controls.Add(this.PMTextBox);
            this.groupCaseBasic.Controls.Add(this.buyerEDICodeTextBox);
            this.groupCaseBasic.Controls.Add(PMLabel);
            this.groupCaseBasic.Controls.Add(buyerEDICodeLabel);
            this.groupCaseBasic.Controls.Add(this.buyerNameTextBox);
            this.groupCaseBasic.Controls.Add(this.isRecoarseCheckBox);
            this.groupCaseBasic.Controls.Add(this.factorCodeTextBox);
            this.groupCaseBasic.Controls.Add(invoiceCurrencyLabel);
            this.groupCaseBasic.Controls.Add(factorCodeLabel);
            this.groupCaseBasic.Controls.Add(this.invoiceCurrencyTextBox);
            this.groupCaseBasic.Controls.Add(this.factorNameTextBox);
            this.groupCaseBasic.Controls.Add(transactionTypeLabel);
            this.groupCaseBasic.Controls.Add(this.transactionTypeTextBox);
            this.groupCaseBasic.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupCaseBasic.Location = new System.Drawing.Point(0, 0);
            this.groupCaseBasic.Name = "groupCaseBasic";
            this.groupCaseBasic.Size = new System.Drawing.Size(481, 158);
            // 
            // 
            // 
            this.groupCaseBasic.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupCaseBasic.Style.BackColorGradientAngle = 90;
            this.groupCaseBasic.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupCaseBasic.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCaseBasic.Style.BorderBottomWidth = 1;
            this.groupCaseBasic.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupCaseBasic.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCaseBasic.Style.BorderLeftWidth = 1;
            this.groupCaseBasic.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCaseBasic.Style.BorderRightWidth = 1;
            this.groupCaseBasic.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupCaseBasic.Style.BorderTopWidth = 1;
            this.groupCaseBasic.Style.Class = "";
            this.groupCaseBasic.Style.CornerDiameter = 4;
            this.groupCaseBasic.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupCaseBasic.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupCaseBasic.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupCaseBasic.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupCaseBasic.StyleMouseOver.Class = "";
            this.groupCaseBasic.TabIndex = 0;
            this.groupCaseBasic.Text = "基本信息";
            // 
            // tbIsNotice
            // 
            // 
            // 
            // 
            this.tbIsNotice.Border.Class = "TextBoxBorder";
            this.tbIsNotice.Location = new System.Drawing.Point(365, 87);
            this.tbIsNotice.Name = "tbIsNotice";
            this.tbIsNotice.ReadOnly = true;
            this.tbIsNotice.Size = new System.Drawing.Size(100, 20);
            this.tbIsNotice.TabIndex = 23;
            // 
            // btnCaseQuery
            // 
            this.btnCaseQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseQuery.Location = new System.Drawing.Point(3, 25);
            this.btnCaseQuery.Name = "btnCaseQuery";
            this.btnCaseQuery.Size = new System.Drawing.Size(32, 29);
            this.btnCaseQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseQuery.TabIndex = 0;
            this.btnCaseQuery.Text = "...";
            this.btnCaseQuery.Click += new System.EventHandler(this.SelectCase);
            // 
            // ownerDepartmentCodeTextBox
            // 
            // 
            // 
            // 
            this.ownerDepartmentCodeTextBox.Border.Class = "TextBoxBorder";
            this.ownerDepartmentCodeTextBox.Location = new System.Drawing.Point(89, 1);
            this.ownerDepartmentCodeTextBox.Name = "ownerDepartmentCodeTextBox";
            this.ownerDepartmentCodeTextBox.ReadOnly = true;
            this.ownerDepartmentCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerDepartmentCodeTextBox.TabIndex = 2;
            // 
            // assignTypeTextBox
            // 
            // 
            // 
            // 
            this.assignTypeTextBox.Border.Class = "TextBoxBorder";
            this.assignTypeTextBox.Location = new System.Drawing.Point(365, 65);
            this.assignTypeTextBox.Name = "assignTypeTextBox";
            this.assignTypeTextBox.ReadOnly = true;
            this.assignTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.assignTypeTextBox.TabIndex = 21;
            // 
            // sellerEDICodeTextBox
            // 
            // 
            // 
            // 
            this.sellerEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.sellerEDICodeTextBox.Location = new System.Drawing.Point(89, 22);
            this.sellerEDICodeTextBox.Name = "sellerEDICodeTextBox";
            this.sellerEDICodeTextBox.ReadOnly = true;
            this.sellerEDICodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.sellerEDICodeTextBox.TabIndex = 4;
            // 
            // RMTextBox
            // 
            // 
            // 
            // 
            this.RMTextBox.Border.Class = "TextBoxBorder";
            this.RMTextBox.Location = new System.Drawing.Point(365, 43);
            this.RMTextBox.Name = "RMTextBox";
            this.RMTextBox.ReadOnly = true;
            this.RMTextBox.Size = new System.Drawing.Size(100, 20);
            this.RMTextBox.TabIndex = 19;
            // 
            // sellerNameTextBox
            // 
            // 
            // 
            // 
            this.sellerNameTextBox.Border.Class = "TextBoxBorder";
            this.sellerNameTextBox.Location = new System.Drawing.Point(159, 22);
            this.sellerNameTextBox.Name = "sellerNameTextBox";
            this.sellerNameTextBox.ReadOnly = true;
            this.sellerNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.sellerNameTextBox.TabIndex = 5;
            // 
            // PMTextBox
            // 
            // 
            // 
            // 
            this.PMTextBox.Border.Class = "TextBoxBorder";
            this.PMTextBox.Location = new System.Drawing.Point(365, 20);
            this.PMTextBox.Name = "PMTextBox";
            this.PMTextBox.ReadOnly = true;
            this.PMTextBox.Size = new System.Drawing.Size(100, 20);
            this.PMTextBox.TabIndex = 17;
            // 
            // buyerEDICodeTextBox
            // 
            // 
            // 
            // 
            this.buyerEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.buyerEDICodeTextBox.Location = new System.Drawing.Point(89, 43);
            this.buyerEDICodeTextBox.Name = "buyerEDICodeTextBox";
            this.buyerEDICodeTextBox.ReadOnly = true;
            this.buyerEDICodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.buyerEDICodeTextBox.TabIndex = 7;
            // 
            // buyerNameTextBox
            // 
            // 
            // 
            // 
            this.buyerNameTextBox.Border.Class = "TextBoxBorder";
            this.buyerNameTextBox.Location = new System.Drawing.Point(159, 43);
            this.buyerNameTextBox.Name = "buyerNameTextBox";
            this.buyerNameTextBox.ReadOnly = true;
            this.buyerNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.buyerNameTextBox.TabIndex = 8;
            // 
            // isRecoarseCheckBox
            // 
            this.isRecoarseCheckBox.AutoSize = true;
            // 
            // 
            // 
            this.isRecoarseCheckBox.BackgroundStyle.Class = "";
            this.isRecoarseCheckBox.Enabled = false;
            this.isRecoarseCheckBox.Location = new System.Drawing.Point(300, 112);
            this.isRecoarseCheckBox.Name = "isRecoarseCheckBox";
            this.isRecoarseCheckBox.Size = new System.Drawing.Size(101, 16);
            this.isRecoarseCheckBox.TabIndex = 24;
            this.isRecoarseCheckBox.Text = "是否有追索权";
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.Location = new System.Drawing.Point(89, 64);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.ReadOnly = true;
            this.factorCodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.factorCodeTextBox.TabIndex = 10;
            // 
            // invoiceCurrencyTextBox
            // 
            // 
            // 
            // 
            this.invoiceCurrencyTextBox.Border.Class = "TextBoxBorder";
            this.invoiceCurrencyTextBox.Location = new System.Drawing.Point(89, 108);
            this.invoiceCurrencyTextBox.Name = "invoiceCurrencyTextBox";
            this.invoiceCurrencyTextBox.ReadOnly = true;
            this.invoiceCurrencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceCurrencyTextBox.TabIndex = 15;
            // 
            // factorNameTextBox
            // 
            // 
            // 
            // 
            this.factorNameTextBox.Border.Class = "TextBoxBorder";
            this.factorNameTextBox.Location = new System.Drawing.Point(159, 64);
            this.factorNameTextBox.Name = "factorNameTextBox";
            this.factorNameTextBox.ReadOnly = true;
            this.factorNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.factorNameTextBox.TabIndex = 11;
            // 
            // transactionTypeTextBox
            // 
            // 
            // 
            // 
            this.transactionTypeTextBox.Border.Class = "TextBoxBorder";
            this.transactionTypeTextBox.Location = new System.Drawing.Point(89, 86);
            this.transactionTypeTextBox.Name = "transactionTypeTextBox";
            this.transactionTypeTextBox.ReadOnly = true;
            this.transactionTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionTypeTextBox.TabIndex = 13;
            // 
            // panelInvoiceMgr
            // 
            this.panelInvoiceMgr.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelInvoiceMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoiceMgr.Location = new System.Drawing.Point(0, 158);
            this.panelInvoiceMgr.Name = "panelInvoiceMgr";
            this.panelInvoiceMgr.Size = new System.Drawing.Size(1054, 22);
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
            this.Name = "ARCaseBasic";
            this.Size = new System.Drawing.Size(1054, 180);
            this.panelCaseBasic.ResumeLayout(false);
            this.groupPanelFinanceCreditLine.ResumeLayout(false);
            this.groupPanelFinanceCreditLine.PerformLayout();
            this.groupPanelCreditCover.ResumeLayout(false);
            this.groupPanelCreditCover.PerformLayout();
            this.groupPanelPrice.ResumeLayout(false);
            this.groupPanelPrice.PerformLayout();
            this.groupCaseBasic.ResumeLayout(false);
            this.groupCaseBasic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbIsNotice;
        private DevComponents.DotNetBar.Controls.TextBoxX commissionTypeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX eFPriceTextBox;

    }
}
