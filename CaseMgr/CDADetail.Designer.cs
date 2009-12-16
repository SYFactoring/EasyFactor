namespace CMBC.EasyFactor.CaseMgr
{
    partial class CDADetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label caseCodeLabel;
            System.Windows.Forms.Label sellerClientLabel;
            System.Windows.Forms.Label sellerFactorCodeLabel;
            System.Windows.Forms.Label buyerClientEDICodeLabel;
            System.Windows.Forms.Label buyerFactorCodeLabel;
            System.Windows.Forms.Label transactionTypeLabel;
            System.Windows.Forms.Label invoiceCurrencyLabel;
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanelBusiness = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanelCreditCover = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanelFee = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanelOther = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.CDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseCodeTextBox = new System.Windows.Forms.TextBox();
            this.sellerClientEDICodeTextBox = new System.Windows.Forms.TextBox();
            this.sellerClientNameCNTextBox = new System.Windows.Forms.TextBox();
            this.sellerFactorCodeTextBox = new System.Windows.Forms.TextBox();
            this.sellerCompanyNameCNTextBox = new System.Windows.Forms.TextBox();
            this.sellerClientNameEN_1TextBox = new System.Windows.Forms.TextBox();
            this.buyerClientEDICodeTextBox = new System.Windows.Forms.TextBox();
            this.buyerClientNameCNTextBox = new System.Windows.Forms.TextBox();
            this.buyerClientNameEN_1TextBox = new System.Windows.Forms.TextBox();
            this.buyerFactorCodeTextBox = new System.Windows.Forms.TextBox();
            this.buyerCompanyNameCNTextBox = new System.Windows.Forms.TextBox();
            this.transactionTypeTextBox = new System.Windows.Forms.TextBox();
            this.invoiceCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.btnCaseSelect = new DevComponents.DotNetBar.ButtonX();
            caseCodeLabel = new System.Windows.Forms.Label();
            sellerClientLabel = new System.Windows.Forms.Label();
            sellerFactorCodeLabel = new System.Windows.Forms.Label();
            buyerClientEDICodeLabel = new System.Windows.Forms.Label();
            buyerFactorCodeLabel = new System.Windows.Forms.Label();
            transactionTypeLabel = new System.Windows.Forms.Label();
            invoiceCurrencyLabel = new System.Windows.Forms.Label();
            this.groupPanelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanelCase
            // 
            this.groupPanelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCase.Controls.Add(this.btnCaseSelect);
            this.groupPanelCase.Controls.Add(invoiceCurrencyLabel);
            this.groupPanelCase.Controls.Add(this.invoiceCurrencyTextBox);
            this.groupPanelCase.Controls.Add(transactionTypeLabel);
            this.groupPanelCase.Controls.Add(this.transactionTypeTextBox);
            this.groupPanelCase.Controls.Add(this.buyerCompanyNameCNTextBox);
            this.groupPanelCase.Controls.Add(buyerFactorCodeLabel);
            this.groupPanelCase.Controls.Add(this.buyerFactorCodeTextBox);
            this.groupPanelCase.Controls.Add(this.buyerClientNameEN_1TextBox);
            this.groupPanelCase.Controls.Add(this.buyerClientNameCNTextBox);
            this.groupPanelCase.Controls.Add(buyerClientEDICodeLabel);
            this.groupPanelCase.Controls.Add(this.buyerClientEDICodeTextBox);
            this.groupPanelCase.Controls.Add(this.sellerClientNameEN_1TextBox);
            this.groupPanelCase.Controls.Add(this.sellerCompanyNameCNTextBox);
            this.groupPanelCase.Controls.Add(sellerFactorCodeLabel);
            this.groupPanelCase.Controls.Add(this.sellerFactorCodeTextBox);
            this.groupPanelCase.Controls.Add(this.sellerClientNameCNTextBox);
            this.groupPanelCase.Controls.Add(sellerClientLabel);
            this.groupPanelCase.Controls.Add(this.sellerClientEDICodeTextBox);
            this.groupPanelCase.Controls.Add(caseCodeLabel);
            this.groupPanelCase.Controls.Add(this.caseCodeTextBox);
            this.groupPanelCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCase.Location = new System.Drawing.Point(0, 0);
            this.groupPanelCase.Name = "groupPanelCase";
            this.groupPanelCase.Size = new System.Drawing.Size(722, 74);
            // 
            // 
            // 
            this.groupPanelCase.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelCase.Style.BackColorGradientAngle = 90;
            this.groupPanelCase.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelCase.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCase.Style.BorderBottomWidth = 1;
            this.groupPanelCase.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelCase.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCase.Style.BorderLeftWidth = 1;
            this.groupPanelCase.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCase.Style.BorderRightWidth = 1;
            this.groupPanelCase.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCase.Style.BorderTopWidth = 1;
            this.groupPanelCase.Style.Class = "";
            this.groupPanelCase.Style.CornerDiameter = 4;
            this.groupPanelCase.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCase.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCase.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCase.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCase.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelCase.StyleMouseOver.Class = "";
            this.groupPanelCase.TabIndex = 0;
            // 
            // groupPanelBusiness
            // 
            this.groupPanelBusiness.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelBusiness.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelBusiness.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelBusiness.Location = new System.Drawing.Point(0, 74);
            this.groupPanelBusiness.Name = "groupPanelBusiness";
            this.groupPanelBusiness.Size = new System.Drawing.Size(722, 59);
            // 
            // 
            // 
            this.groupPanelBusiness.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelBusiness.Style.BackColorGradientAngle = 90;
            this.groupPanelBusiness.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelBusiness.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusiness.Style.BorderBottomWidth = 1;
            this.groupPanelBusiness.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelBusiness.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusiness.Style.BorderLeftWidth = 1;
            this.groupPanelBusiness.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusiness.Style.BorderRightWidth = 1;
            this.groupPanelBusiness.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusiness.Style.BorderTopWidth = 1;
            this.groupPanelBusiness.Style.Class = "";
            this.groupPanelBusiness.Style.CornerDiameter = 4;
            this.groupPanelBusiness.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelBusiness.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelBusiness.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelBusiness.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelBusiness.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelBusiness.StyleMouseOver.Class = "";
            this.groupPanelBusiness.TabIndex = 1;
            // 
            // groupPanelCreditCover
            // 
            this.groupPanelCreditCover.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCreditCover.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCreditCover.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditCover.Location = new System.Drawing.Point(0, 133);
            this.groupPanelCreditCover.Name = "groupPanelCreditCover";
            this.groupPanelCreditCover.Size = new System.Drawing.Size(722, 51);
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
            this.groupPanelCreditCover.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
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
            // 
            // groupPanelFee
            // 
            this.groupPanelFee.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelFee.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelFee.Location = new System.Drawing.Point(0, 184);
            this.groupPanelFee.Name = "groupPanelFee";
            this.groupPanelFee.Size = new System.Drawing.Size(722, 59);
            // 
            // 
            // 
            this.groupPanelFee.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelFee.Style.BackColorGradientAngle = 90;
            this.groupPanelFee.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelFee.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFee.Style.BorderBottomWidth = 1;
            this.groupPanelFee.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelFee.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFee.Style.BorderLeftWidth = 1;
            this.groupPanelFee.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFee.Style.BorderRightWidth = 1;
            this.groupPanelFee.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFee.Style.BorderTopWidth = 1;
            this.groupPanelFee.Style.Class = "";
            this.groupPanelFee.Style.CornerDiameter = 4;
            this.groupPanelFee.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelFee.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelFee.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelFee.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelFee.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelFee.StyleMouseOver.Class = "";
            this.groupPanelFee.TabIndex = 3;
            // 
            // groupPanelOther
            // 
            this.groupPanelOther.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelOther.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelOther.Location = new System.Drawing.Point(0, 243);
            this.groupPanelOther.Name = "groupPanelOther";
            this.groupPanelOther.Size = new System.Drawing.Size(722, 100);
            // 
            // 
            // 
            this.groupPanelOther.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelOther.Style.BackColorGradientAngle = 90;
            this.groupPanelOther.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelOther.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelOther.Style.BorderBottomWidth = 1;
            this.groupPanelOther.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelOther.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelOther.Style.BorderLeftWidth = 1;
            this.groupPanelOther.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelOther.Style.BorderRightWidth = 1;
            this.groupPanelOther.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelOther.Style.BorderTopWidth = 1;
            this.groupPanelOther.Style.Class = "";
            this.groupPanelOther.Style.CornerDiameter = 4;
            this.groupPanelOther.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelOther.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelOther.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelOther.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelOther.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelOther.StyleMouseOver.Class = "";
            this.groupPanelOther.TabIndex = 4;
            // 
            // CDABindingSource
            // 
            this.CDABindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CDA);
            // 
            // caseCodeLabel
            // 
            caseCodeLabel.AutoSize = true;
            caseCodeLabel.Location = new System.Drawing.Point(3, 6);
            caseCodeLabel.Name = "caseCodeLabel";
            caseCodeLabel.Size = new System.Drawing.Size(58, 13);
            caseCodeLabel.TabIndex = 0;
            caseCodeLabel.Text = "案件编号:";
            // 
            // caseCodeTextBox
            // 
            this.caseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.CaseCode", true));
            this.caseCodeTextBox.Location = new System.Drawing.Point(71, 3);
            this.caseCodeTextBox.Name = "caseCodeTextBox";
            this.caseCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.caseCodeTextBox.TabIndex = 1;
            // 
            // sellerClientLabel
            // 
            sellerClientLabel.AutoSize = true;
            sellerClientLabel.Location = new System.Drawing.Point(15, 26);
            sellerClientLabel.Name = "sellerClientLabel";
            sellerClientLabel.Size = new System.Drawing.Size(34, 13);
            sellerClientLabel.TabIndex = 2;
            sellerClientLabel.Text = "卖方:";
            // 
            // sellerClientEDICodeTextBox
            // 
            this.sellerClientEDICodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerClient.ClientEDICode", true));
            this.sellerClientEDICodeTextBox.Location = new System.Drawing.Point(55, 23);
            this.sellerClientEDICodeTextBox.Name = "sellerClientEDICodeTextBox";
            this.sellerClientEDICodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellerClientEDICodeTextBox.TabIndex = 3;
            // 
            // sellerClientNameCNTextBox
            // 
            this.sellerClientNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerClient.ClientNameCN", true));
            this.sellerClientNameCNTextBox.Location = new System.Drawing.Point(161, 23);
            this.sellerClientNameCNTextBox.Name = "sellerClientNameCNTextBox";
            this.sellerClientNameCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellerClientNameCNTextBox.TabIndex = 5;
            // 
            // sellerFactorCodeLabel
            // 
            sellerFactorCodeLabel.AutoSize = true;
            sellerFactorCodeLabel.Location = new System.Drawing.Point(373, 26);
            sellerFactorCodeLabel.Name = "sellerFactorCodeLabel";
            sellerFactorCodeLabel.Size = new System.Drawing.Size(70, 13);
            sellerFactorCodeLabel.TabIndex = 6;
            sellerFactorCodeLabel.Text = "卖方保理商:";
            // 
            // sellerFactorCodeTextBox
            // 
            this.sellerFactorCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerFactor.FactorCode", true));
            this.sellerFactorCodeTextBox.Location = new System.Drawing.Point(447, 23);
            this.sellerFactorCodeTextBox.Name = "sellerFactorCodeTextBox";
            this.sellerFactorCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellerFactorCodeTextBox.TabIndex = 7;
            // 
            // sellerCompanyNameCNTextBox
            // 
            this.sellerCompanyNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerFactor.CompanyNameCN", true));
            this.sellerCompanyNameCNTextBox.Location = new System.Drawing.Point(553, 23);
            this.sellerCompanyNameCNTextBox.Name = "sellerCompanyNameCNTextBox";
            this.sellerCompanyNameCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellerCompanyNameCNTextBox.TabIndex = 9;
            // 
            // sellerClientNameEN_1TextBox
            // 
            this.sellerClientNameEN_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerClient.ClientNameEN_1", true));
            this.sellerClientNameEN_1TextBox.Location = new System.Drawing.Point(267, 23);
            this.sellerClientNameEN_1TextBox.Name = "sellerClientNameEN_1TextBox";
            this.sellerClientNameEN_1TextBox.Size = new System.Drawing.Size(100, 20);
            this.sellerClientNameEN_1TextBox.TabIndex = 11;
            // 
            // buyerClientEDICodeLabel
            // 
            buyerClientEDICodeLabel.AutoSize = true;
            buyerClientEDICodeLabel.Location = new System.Drawing.Point(15, 44);
            buyerClientEDICodeLabel.Name = "buyerClientEDICodeLabel";
            buyerClientEDICodeLabel.Size = new System.Drawing.Size(34, 13);
            buyerClientEDICodeLabel.TabIndex = 12;
            buyerClientEDICodeLabel.Text = "买方:";
            // 
            // buyerClientEDICodeTextBox
            // 
            this.buyerClientEDICodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerClient.ClientEDICode", true));
            this.buyerClientEDICodeTextBox.Location = new System.Drawing.Point(55, 41);
            this.buyerClientEDICodeTextBox.Name = "buyerClientEDICodeTextBox";
            this.buyerClientEDICodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerClientEDICodeTextBox.TabIndex = 13;
            // 
            // buyerClientNameCNTextBox
            // 
            this.buyerClientNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerClient.ClientNameCN", true));
            this.buyerClientNameCNTextBox.Location = new System.Drawing.Point(161, 41);
            this.buyerClientNameCNTextBox.Name = "buyerClientNameCNTextBox";
            this.buyerClientNameCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerClientNameCNTextBox.TabIndex = 15;
            // 
            // buyerClientNameEN_1TextBox
            // 
            this.buyerClientNameEN_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerClient.ClientNameEN_1", true));
            this.buyerClientNameEN_1TextBox.Location = new System.Drawing.Point(267, 41);
            this.buyerClientNameEN_1TextBox.Name = "buyerClientNameEN_1TextBox";
            this.buyerClientNameEN_1TextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerClientNameEN_1TextBox.TabIndex = 17;
            // 
            // buyerFactorCodeLabel
            // 
            buyerFactorCodeLabel.AutoSize = true;
            buyerFactorCodeLabel.Location = new System.Drawing.Point(373, 44);
            buyerFactorCodeLabel.Name = "buyerFactorCodeLabel";
            buyerFactorCodeLabel.Size = new System.Drawing.Size(70, 13);
            buyerFactorCodeLabel.TabIndex = 18;
            buyerFactorCodeLabel.Text = "买方保理商:";
            // 
            // buyerFactorCodeTextBox
            // 
            this.buyerFactorCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerFactor.FactorCode", true));
            this.buyerFactorCodeTextBox.Location = new System.Drawing.Point(447, 41);
            this.buyerFactorCodeTextBox.Name = "buyerFactorCodeTextBox";
            this.buyerFactorCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerFactorCodeTextBox.TabIndex = 19;
            // 
            // buyerCompanyNameCNTextBox
            // 
            this.buyerCompanyNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerFactor.CompanyNameCN", true));
            this.buyerCompanyNameCNTextBox.Location = new System.Drawing.Point(553, 41);
            this.buyerCompanyNameCNTextBox.Name = "buyerCompanyNameCNTextBox";
            this.buyerCompanyNameCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerCompanyNameCNTextBox.TabIndex = 21;
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Location = new System.Drawing.Point(383, 3);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new System.Drawing.Size(58, 13);
            transactionTypeLabel.TabIndex = 22;
            transactionTypeLabel.Text = "业务类别:";
            // 
            // transactionTypeTextBox
            // 
            this.transactionTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.TransactionType", true));
            this.transactionTypeTextBox.Location = new System.Drawing.Point(447, 0);
            this.transactionTypeTextBox.Name = "transactionTypeTextBox";
            this.transactionTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionTypeTextBox.TabIndex = 23;
            // 
            // invoiceCurrencyLabel
            // 
            invoiceCurrencyLabel.AutoSize = true;
            invoiceCurrencyLabel.Location = new System.Drawing.Point(197, 3);
            invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            invoiceCurrencyLabel.Size = new System.Drawing.Size(58, 13);
            invoiceCurrencyLabel.TabIndex = 24;
            invoiceCurrencyLabel.Text = "发票币别:";
            // 
            // invoiceCurrencyTextBox
            // 
            this.invoiceCurrencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.InvoiceCurrency", true));
            this.invoiceCurrencyTextBox.Location = new System.Drawing.Point(267, 0);
            this.invoiceCurrencyTextBox.Name = "invoiceCurrencyTextBox";
            this.invoiceCurrencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceCurrencyTextBox.TabIndex = 25;
            // 
            // btnCaseSelect
            // 
            this.btnCaseSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSelect.Location = new System.Drawing.Point(675, 6);
            this.btnCaseSelect.Name = "btnCaseSelect";
            this.btnCaseSelect.Size = new System.Drawing.Size(23, 23);
            this.btnCaseSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSelect.TabIndex = 26;
            this.btnCaseSelect.Text = "Q";
            this.btnCaseSelect.Click += new System.EventHandler(this.SelectCase);
            // 
            // CDADetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 353);
            this.Controls.Add(this.groupPanelOther);
            this.Controls.Add(this.groupPanelFee);
            this.Controls.Add(this.groupPanelCreditCover);
            this.Controls.Add(this.groupPanelBusiness);
            this.Controls.Add(this.groupPanelCase);
            this.DoubleBuffered = true;
            this.Name = "CDADetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "额度通知书";
            this.groupPanelCase.ResumeLayout(false);
            this.groupPanelCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCase;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelBusiness;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditCover;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFee;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelOther;
        private System.Windows.Forms.TextBox caseCodeTextBox;
        private System.Windows.Forms.BindingSource CDABindingSource;
        private System.Windows.Forms.TextBox sellerCompanyNameCNTextBox;
        private System.Windows.Forms.TextBox sellerFactorCodeTextBox;
        private System.Windows.Forms.TextBox sellerClientNameCNTextBox;
        private System.Windows.Forms.TextBox sellerClientEDICodeTextBox;
        private System.Windows.Forms.TextBox buyerCompanyNameCNTextBox;
        private System.Windows.Forms.TextBox buyerFactorCodeTextBox;
        private System.Windows.Forms.TextBox buyerClientNameEN_1TextBox;
        private System.Windows.Forms.TextBox buyerClientNameCNTextBox;
        private System.Windows.Forms.TextBox buyerClientEDICodeTextBox;
        private System.Windows.Forms.TextBox sellerClientNameEN_1TextBox;
        private System.Windows.Forms.TextBox invoiceCurrencyTextBox;
        private System.Windows.Forms.TextBox transactionTypeTextBox;
        private DevComponents.DotNetBar.ButtonX btnCaseSelect;
    }
}