namespace CMBC.EasyFactor.CaseMgr
{
    partial class CDADetail
    {
		#region?Fields?(81)?

        private DevComponents.DotNetBar.Controls.ComboBoxEx assignTypeComboBox;
        private DevComponents.DotNetBar.ButtonX btnCaseSelect;
        private DevComponents.DotNetBar.ButtonX btnCDASave;
        private DevComponents.DotNetBar.ButtonX btnCDAUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerClientEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerClientNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerClientNameENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX caseCodeTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCreditCoverRevolving;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbIsNotice;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsRecoarse;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsSigned;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbNoticeMethodEmail;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbNoticeMethodFax;
        private System.Windows.Forms.BindingSource CDABindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cDAStatusComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx commissionTypeComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX commissionTypeCommentTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX companyNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX companyNameENTextBox;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX contractCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX createUserNameTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditCoverCurrComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput creditCoverPeriodBeginDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput creditCoverPeriodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX creditCoverTextBox;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator10;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator3;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator4;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator5;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator6;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator7;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator8;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator9;
        private DevComponents.DotNetBar.Controls.TextBoxX deductiblesTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diCDASignDate;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX faxTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeGracePeriodTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx financeLineCurrComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financeLinePeriodBeginDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financeLinePeriodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX financeLineTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeProportionTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCase;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditCover;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelOther;
        private DevComponents.DotNetBar.Controls.ComboBoxEx handFeeCurrComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX handFeeTextBox;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX iFPriceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceCurrencyTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX lossThresholdTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX delayDaysTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX noticePersonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX orderNumberTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX paymentTermsTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX priceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX pUGPeriodTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX pUGProportionTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX reassignGracePeriodTextBox;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerClientEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerClientNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerClientNameENTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCasePaymentTerm;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCDACode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbHighestFinance;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRemark;
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (this._context != null)
            {
                this._context.Dispose();
            }

            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDADetail));
            this.caseCodeLabel = new DevComponents.DotNetBar.LabelX();
            this.sellerClientLabel = new DevComponents.DotNetBar.LabelX();
            this.factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            this.buyerClientEDICodeLabel = new DevComponents.DotNetBar.LabelX();
            this.transactionTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.invoiceCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            this.creditCoverCurrLabel = new DevComponents.DotNetBar.LabelX();
            this.pUGProportionLabel = new DevComponents.DotNetBar.LabelX();
            this.creditCoverPeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            this.pUGPeriodLabel = new DevComponents.DotNetBar.LabelX();
            this.reassignGracePeriodLabel = new DevComponents.DotNetBar.LabelX();
            this.financeLineCurrLabel = new DevComponents.DotNetBar.LabelX();
            this.financeLinePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            this.lblHighestFinance = new DevComponents.DotNetBar.LabelX();
            this.financeProportionLabel = new DevComponents.DotNetBar.LabelX();
            this.orderNumberLabel = new DevComponents.DotNetBar.LabelX();
            this.paymentTermsLabel = new DevComponents.DotNetBar.LabelX();
            this.financeGracePeriodLabel = new DevComponents.DotNetBar.LabelX();
            this.deductiblesLabel = new DevComponents.DotNetBar.LabelX();
            this.lossThresholdLabel = new DevComponents.DotNetBar.LabelX();
            this.delayDaysLabel = new DevComponents.DotNetBar.LabelX();
            this.priceLabel = new DevComponents.DotNetBar.LabelX();
            this.iFPriceLabel = new DevComponents.DotNetBar.LabelX();
            this.commissonTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.commissionTypeCommentLabel = new DevComponents.DotNetBar.LabelX();
            this.handFeeLabel = new DevComponents.DotNetBar.LabelX();
            this.noticePersonLabel = new DevComponents.DotNetBar.LabelX();
            this.emailLabel = new DevComponents.DotNetBar.LabelX();
            this.faxLabel = new DevComponents.DotNetBar.LabelX();
            this.commentLabel = new DevComponents.DotNetBar.LabelX();
            this.createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            this.cDAStatusLabel = new DevComponents.DotNetBar.LabelX();
            this.noticeMethodLabel = new DevComponents.DotNetBar.LabelX();
            this.contractCodeLabel = new DevComponents.DotNetBar.LabelX();
            this.lblCDACode = new DevComponents.DotNetBar.LabelX();
            this.assignTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.lblIsNotice = new DevComponents.DotNetBar.LabelX();
            this.lblRemark = new DevComponents.DotNetBar.LabelX();
            this.lblCasePaymentTerm = new DevComponents.DotNetBar.LabelX();
            this.lblCDASignDate = new DevComponents.DotNetBar.LabelX();
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbCasePaymentTerm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceCurrencyTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.transactionTypeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.companyNameENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contractCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCaseSelect = new DevComponents.DotNetBar.ButtonX();
            this.buyerClientNameENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buyerClientNameCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buyerClientEDICodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sellerClientNameENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.companyNameCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sellerClientNameCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sellerClientEDICodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.caseCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelCreditCover = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbIsNotice = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbIsRecoarse = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.assignTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCDACode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbHighestFinance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.handFeeCurrComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbIsCreditCoverRevolving = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.handFeeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lossThresholdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.delayDaysTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commissionTypeCommentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.deductiblesTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commissionTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeGracePeriodTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.paymentTermsTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.iFPriceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.orderNumberTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.priceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeProportionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeLinePeriodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeLinePeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeLineTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeLineCurrComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reassignGracePeriodTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pUGPeriodTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverPeriodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.creditCoverPeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.pUGProportionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverCurrComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanelOther = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.diCDASignDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbIsSigned = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbRemark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbNoticeMethodFax = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbNoticeMethodEmail = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cDAStatusComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.createUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.faxTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.noticePersonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCDAUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCDASave = new DevComponents.DotNetBar.ButtonX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.customValidator8 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator7 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator();
            this.customValidator10 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator9 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.compareValidator2 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.customValidator6 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator4 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator5 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.customValidator3 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDABindingSource)).BeginInit();
            this.groupPanelCreditCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financeLinePeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeLinePeriodBeginDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverPeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverPeriodBeginDateTimePicker)).BeginInit();
            this.groupPanelOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diCDASignDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // caseCodeLabel
            // 
            this.caseCodeLabel.AutoSize = true;
            this.caseCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.caseCodeLabel.BackgroundStyle.Class = "";
            this.caseCodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.caseCodeLabel.Location = new System.Drawing.Point(3, 6);
            this.caseCodeLabel.Name = "caseCodeLabel";
            this.caseCodeLabel.Size = new System.Drawing.Size(59, 16);
            this.caseCodeLabel.TabIndex = 0;
            this.caseCodeLabel.Text = "案件编号:";
            // 
            // sellerClientLabel
            // 
            this.sellerClientLabel.AutoSize = true;
            this.sellerClientLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.sellerClientLabel.BackgroundStyle.Class = "";
            this.sellerClientLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sellerClientLabel.Location = new System.Drawing.Point(15, 26);
            this.sellerClientLabel.Name = "sellerClientLabel";
            this.sellerClientLabel.Size = new System.Drawing.Size(34, 16);
            this.sellerClientLabel.TabIndex = 8;
            this.sellerClientLabel.Text = "卖方:";
            // 
            // factorCodeLabel
            // 
            this.factorCodeLabel.AutoSize = true;
            this.factorCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.factorCodeLabel.BackgroundStyle.Class = "";
            this.factorCodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.factorCodeLabel.Location = new System.Drawing.Point(355, 26);
            this.factorCodeLabel.Name = "factorCodeLabel";
            this.factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            this.factorCodeLabel.TabIndex = 12;
            this.factorCodeLabel.Text = "保理商:";
            // 
            // buyerClientEDICodeLabel
            // 
            this.buyerClientEDICodeLabel.AutoSize = true;
            this.buyerClientEDICodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.buyerClientEDICodeLabel.BackgroundStyle.Class = "";
            this.buyerClientEDICodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.buyerClientEDICodeLabel.Location = new System.Drawing.Point(15, 69);
            this.buyerClientEDICodeLabel.Name = "buyerClientEDICodeLabel";
            this.buyerClientEDICodeLabel.Size = new System.Drawing.Size(34, 16);
            this.buyerClientEDICodeLabel.TabIndex = 16;
            this.buyerClientEDICodeLabel.Text = "买方:";
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.transactionTypeLabel.BackgroundStyle.Class = "";
            this.transactionTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.transactionTypeLabel.Location = new System.Drawing.Point(177, 6);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(59, 16);
            this.transactionTypeLabel.TabIndex = 2;
            this.transactionTypeLabel.Text = "业务类别:";
            // 
            // invoiceCurrencyLabel
            // 
            this.invoiceCurrencyLabel.AutoSize = true;
            this.invoiceCurrencyLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.invoiceCurrencyLabel.BackgroundStyle.Class = "";
            this.invoiceCurrencyLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceCurrencyLabel.Location = new System.Drawing.Point(353, 4);
            this.invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            this.invoiceCurrencyLabel.Size = new System.Drawing.Size(59, 16);
            this.invoiceCurrencyLabel.TabIndex = 4;
            this.invoiceCurrencyLabel.Text = "发票币别:";
            // 
            // creditCoverCurrLabel
            // 
            this.creditCoverCurrLabel.AutoSize = true;
            this.creditCoverCurrLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.creditCoverCurrLabel.BackgroundStyle.Class = "";
            this.creditCoverCurrLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverCurrLabel.Location = new System.Drawing.Point(9, 26);
            this.creditCoverCurrLabel.Name = "creditCoverCurrLabel";
            this.creditCoverCurrLabel.Size = new System.Drawing.Size(84, 16);
            this.creditCoverCurrLabel.TabIndex = 7;
            this.creditCoverCurrLabel.Text = "买方风险额度:";
            // 
            // pUGProportionLabel
            // 
            this.pUGProportionLabel.AutoSize = true;
            this.pUGProportionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.pUGProportionLabel.BackgroundStyle.Class = "";
            this.pUGProportionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pUGProportionLabel.Location = new System.Drawing.Point(32, 48);
            this.pUGProportionLabel.Name = "pUGProportionLabel";
            this.pUGProportionLabel.Size = new System.Drawing.Size(59, 16);
            this.pUGProportionLabel.TabIndex = 14;
            this.pUGProportionLabel.Text = "担保比例:";
            // 
            // creditCoverPeriodBeginLabel
            // 
            this.creditCoverPeriodBeginLabel.AutoSize = true;
            this.creditCoverPeriodBeginLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.creditCoverPeriodBeginLabel.BackgroundStyle.Class = "";
            this.creditCoverPeriodBeginLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodBeginLabel.Location = new System.Drawing.Point(286, 24);
            this.creditCoverPeriodBeginLabel.Name = "creditCoverPeriodBeginLabel";
            this.creditCoverPeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            this.creditCoverPeriodBeginLabel.TabIndex = 10;
            this.creditCoverPeriodBeginLabel.Text = "有效期限:";
            // 
            // pUGPeriodLabel
            // 
            this.pUGPeriodLabel.AutoSize = true;
            this.pUGPeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.pUGPeriodLabel.BackgroundStyle.Class = "";
            this.pUGPeriodLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pUGPeriodLabel.Location = new System.Drawing.Point(241, 48);
            this.pUGPeriodLabel.Name = "pUGPeriodLabel";
            this.pUGPeriodLabel.Size = new System.Drawing.Size(104, 16);
            this.pUGPeriodLabel.TabIndex = 16;
            this.pUGPeriodLabel.Text = "担保付款期限(天):";
            // 
            // reassignGracePeriodLabel
            // 
            this.reassignGracePeriodLabel.AutoSize = true;
            this.reassignGracePeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reassignGracePeriodLabel.BackgroundStyle.Class = "";
            this.reassignGracePeriodLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reassignGracePeriodLabel.Location = new System.Drawing.Point(501, 48);
            this.reassignGracePeriodLabel.Name = "reassignGracePeriodLabel";
            this.reassignGracePeriodLabel.Size = new System.Drawing.Size(92, 16);
            this.reassignGracePeriodLabel.TabIndex = 18;
            this.reassignGracePeriodLabel.Text = "回购宽限期(天):";
            // 
            // financeLineCurrLabel
            // 
            this.financeLineCurrLabel.AutoSize = true;
            this.financeLineCurrLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.financeLineCurrLabel.BackgroundStyle.Class = "";
            this.financeLineCurrLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLineCurrLabel.Location = new System.Drawing.Point(21, 70);
            this.financeLineCurrLabel.Name = "financeLineCurrLabel";
            this.financeLineCurrLabel.Size = new System.Drawing.Size(72, 16);
            this.financeLineCurrLabel.TabIndex = 20;
            this.financeLineCurrLabel.Text = "预付款额度:";
            // 
            // financeLinePeriodBeginLabel
            // 
            this.financeLinePeriodBeginLabel.AutoSize = true;
            this.financeLinePeriodBeginLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.financeLinePeriodBeginLabel.BackgroundStyle.Class = "";
            this.financeLinePeriodBeginLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodBeginLabel.Location = new System.Drawing.Point(286, 69);
            this.financeLinePeriodBeginLabel.Name = "financeLinePeriodBeginLabel";
            this.financeLinePeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            this.financeLinePeriodBeginLabel.TabIndex = 23;
            this.financeLinePeriodBeginLabel.Text = "有效期限:";
            // 
            // lblHighestFinance
            // 
            this.lblHighestFinance.AutoSize = true;
            this.lblHighestFinance.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblHighestFinance.BackgroundStyle.Class = "";
            this.lblHighestFinance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHighestFinance.Location = new System.Drawing.Point(4, 95);
            this.lblHighestFinance.Name = "lblHighestFinance";
            this.lblHighestFinance.Size = new System.Drawing.Size(121, 16);
            this.lblHighestFinance.TabIndex = 26;
            this.lblHighestFinance.Text = "最高保理预付款额度:";
            // 
            // financeProportionLabel
            // 
            this.financeProportionLabel.AutoSize = true;
            this.financeProportionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.financeProportionLabel.BackgroundStyle.Class = "";
            this.financeProportionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeProportionLabel.Location = new System.Drawing.Point(286, 92);
            this.financeProportionLabel.Name = "financeProportionLabel";
            this.financeProportionLabel.Size = new System.Drawing.Size(59, 16);
            this.financeProportionLabel.TabIndex = 28;
            this.financeProportionLabel.Text = "预付比例:";
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.orderNumberLabel.BackgroundStyle.Class = "";
            this.orderNumberLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.orderNumberLabel.Location = new System.Drawing.Point(295, 159);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(47, 16);
            this.orderNumberLabel.TabIndex = 34;
            this.orderNumberLabel.Text = "订单号:";
            // 
            // paymentTermsLabel
            // 
            this.paymentTermsLabel.AutoSize = true;
            this.paymentTermsLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.paymentTermsLabel.BackgroundStyle.Class = "";
            this.paymentTermsLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentTermsLabel.Location = new System.Drawing.Point(28, 117);
            this.paymentTermsLabel.Name = "paymentTermsLabel";
            this.paymentTermsLabel.Size = new System.Drawing.Size(57, 15);
            this.paymentTermsLabel.TabIndex = 32;
            this.paymentTermsLabel.Text = "<font color=\'red\'>*</font>付款条件:";
            // 
            // financeGracePeriodLabel
            // 
            this.financeGracePeriodLabel.AutoSize = true;
            this.financeGracePeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.financeGracePeriodLabel.BackgroundStyle.Class = "";
            this.financeGracePeriodLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeGracePeriodLabel.Location = new System.Drawing.Point(501, 95);
            this.financeGracePeriodLabel.Name = "financeGracePeriodLabel";
            this.financeGracePeriodLabel.Size = new System.Drawing.Size(92, 16);
            this.financeGracePeriodLabel.TabIndex = 30;
            this.financeGracePeriodLabel.Text = "融资宽限期(天):";
            // 
            // deductiblesLabel
            // 
            this.deductiblesLabel.AutoSize = true;
            this.deductiblesLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.deductiblesLabel.BackgroundStyle.Class = "";
            this.deductiblesLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deductiblesLabel.Location = new System.Drawing.Point(42, 182);
            this.deductiblesLabel.Name = "deductiblesLabel";
            this.deductiblesLabel.Size = new System.Drawing.Size(47, 16);
            this.deductiblesLabel.TabIndex = 36;
            this.deductiblesLabel.Text = "自负额:";
            // 
            // lossThresholdLabel
            // 
            this.lossThresholdLabel.AutoSize = true;
            this.lossThresholdLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lossThresholdLabel.BackgroundStyle.Class = "";
            this.lossThresholdLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lossThresholdLabel.Location = new System.Drawing.Point(257, 185);
            this.lossThresholdLabel.Name = "lossThresholdLabel";
            this.lossThresholdLabel.Size = new System.Drawing.Size(84, 16);
            this.lossThresholdLabel.TabIndex = 38;
            this.lossThresholdLabel.Text = "最低损失门槛:";
            // 
            // delayDaysLabel
            // 
            this.delayDaysLabel.AutoSize = true;
            this.delayDaysLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.delayDaysLabel.BackgroundStyle.Class = "";
            this.delayDaysLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.delayDaysLabel.Location = new System.Drawing.Point(455, 185);
            this.delayDaysLabel.Name = "delayDaysLabel";
            this.delayDaysLabel.Size = new System.Drawing.Size(59, 16);
            this.delayDaysLabel.TabIndex = 38;
            this.delayDaysLabel.Text = "逾期天数:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.priceLabel.BackgroundStyle.Class = "";
            this.priceLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.priceLabel.Location = new System.Drawing.Point(15, 205);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(69, 15);
            this.priceLabel.TabIndex = 40;
            this.priceLabel.Text = "<font color=\'red\'>*</font>总手续费率:";
            // 
            // iFPriceLabel
            // 
            this.iFPriceLabel.AutoSize = true;
            this.iFPriceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.iFPriceLabel.BackgroundStyle.Class = "";
            this.iFPriceLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iFPriceLabel.Location = new System.Drawing.Point(272, 207);
            this.iFPriceLabel.Name = "iFPriceLabel";
            this.iFPriceLabel.Size = new System.Drawing.Size(69, 16);
            this.iFPriceLabel.TabIndex = 42;
            this.iFPriceLabel.Text = "IF手续费率:";
            // 
            // commissonTypeLabel
            // 
            this.commissonTypeLabel.AutoSize = true;
            this.commissonTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.commissonTypeLabel.BackgroundStyle.Class = "";
            this.commissonTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissonTypeLabel.Location = new System.Drawing.Point(26, 228);
            this.commissonTypeLabel.Name = "commissonTypeLabel";
            this.commissonTypeLabel.Size = new System.Drawing.Size(57, 15);
            this.commissonTypeLabel.TabIndex = 49;
            this.commissonTypeLabel.Text = "<font color=\'red\'>*</font>计费方式:";
            // 
            // commissionTypeCommentLabel
            // 
            this.commissionTypeCommentLabel.AutoSize = true;
            this.commissionTypeCommentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.commissionTypeCommentLabel.BackgroundStyle.Class = "";
            this.commissionTypeCommentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionTypeCommentLabel.Location = new System.Drawing.Point(242, 229);
            this.commissionTypeCommentLabel.Name = "commissionTypeCommentLabel";
            this.commissionTypeCommentLabel.Size = new System.Drawing.Size(34, 16);
            this.commissionTypeCommentLabel.TabIndex = 51;
            this.commissionTypeCommentLabel.Text = "说明:";
            // 
            // handFeeLabel
            // 
            this.handFeeLabel.AutoSize = true;
            this.handFeeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.handFeeLabel.BackgroundStyle.Class = "";
            this.handFeeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.handFeeLabel.Location = new System.Drawing.Point(455, 208);
            this.handFeeLabel.Name = "handFeeLabel";
            this.handFeeLabel.Size = new System.Drawing.Size(104, 16);
            this.handFeeLabel.TabIndex = 46;
            this.handFeeLabel.Text = "单据处理费(每笔):";
            // 
            // noticePersonLabel
            // 
            this.noticePersonLabel.AutoSize = true;
            this.noticePersonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.noticePersonLabel.BackgroundStyle.Class = "";
            this.noticePersonLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.noticePersonLabel.Location = new System.Drawing.Point(40, 25);
            this.noticePersonLabel.Name = "noticePersonLabel";
            this.noticePersonLabel.Size = new System.Drawing.Size(47, 16);
            this.noticePersonLabel.TabIndex = 7;
            this.noticePersonLabel.Text = "通知人:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.emailLabel.BackgroundStyle.Class = "";
            this.emailLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.emailLabel.Location = new System.Drawing.Point(530, 5);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 16);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email地址:";
            // 
            // faxLabel
            // 
            this.faxLabel.AutoSize = true;
            this.faxLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.faxLabel.BackgroundStyle.Class = "";
            this.faxLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.faxLabel.Location = new System.Drawing.Point(530, 27);
            this.faxLabel.Name = "faxLabel";
            this.faxLabel.Size = new System.Drawing.Size(59, 16);
            this.faxLabel.TabIndex = 11;
            this.faxLabel.Text = "传真号码:";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.commentLabel.BackgroundStyle.Class = "";
            this.commentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commentLabel.Location = new System.Drawing.Point(50, 51);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(34, 16);
            this.commentLabel.TabIndex = 13;
            this.commentLabel.Text = "备注:";
            // 
            // createUserNameLabel
            // 
            this.createUserNameLabel.AutoSize = true;
            this.createUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.createUserNameLabel.BackgroundStyle.Class = "";
            this.createUserNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.createUserNameLabel.Location = new System.Drawing.Point(552, 51);
            this.createUserNameLabel.Name = "createUserNameLabel";
            this.createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            this.createUserNameLabel.TabIndex = 15;
            this.createUserNameLabel.Text = "经办人:";
            // 
            // cDAStatusLabel
            // 
            this.cDAStatusLabel.AutoSize = true;
            this.cDAStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cDAStatusLabel.BackgroundStyle.Class = "";
            this.cDAStatusLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cDAStatusLabel.Location = new System.Drawing.Point(27, 3);
            this.cDAStatusLabel.Name = "cDAStatusLabel";
            this.cDAStatusLabel.Size = new System.Drawing.Size(58, 16);
            this.cDAStatusLabel.TabIndex = 2;
            this.cDAStatusLabel.Text = "CDA状态:";
            // 
            // noticeMethodLabel
            // 
            this.noticeMethodLabel.AutoSize = true;
            this.noticeMethodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.noticeMethodLabel.BackgroundStyle.Class = "";
            this.noticeMethodLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.noticeMethodLabel.Location = new System.Drawing.Point(333, 25);
            this.noticeMethodLabel.Name = "noticeMethodLabel";
            this.noticeMethodLabel.Size = new System.Drawing.Size(59, 16);
            this.noticeMethodLabel.TabIndex = 4;
            this.noticeMethodLabel.Text = "通知方式:";
            // 
            // contractCodeLabel
            // 
            this.contractCodeLabel.AutoSize = true;
            this.contractCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.contractCodeLabel.BackgroundStyle.Class = "";
            this.contractCodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contractCodeLabel.Location = new System.Drawing.Point(367, 67);
            this.contractCodeLabel.Name = "contractCodeLabel";
            this.contractCodeLabel.Size = new System.Drawing.Size(84, 16);
            this.contractCodeLabel.TabIndex = 6;
            this.contractCodeLabel.Text = "保理合同编号:";
            // 
            // lblCDACode
            // 
            this.lblCDACode.AutoSize = true;
            this.lblCDACode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCDACode.BackgroundStyle.Class = "";
            this.lblCDACode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCDACode.Location = new System.Drawing.Point(36, 3);
            this.lblCDACode.Name = "lblCDACode";
            this.lblCDACode.Size = new System.Drawing.Size(58, 16);
            this.lblCDACode.TabIndex = 0;
            this.lblCDACode.Text = "CDA编号:";
            // 
            // assignTypeLabel
            // 
            this.assignTypeLabel.AutoSize = true;
            this.assignTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.assignTypeLabel.BackgroundStyle.Class = "";
            this.assignTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignTypeLabel.Location = new System.Drawing.Point(565, 4);
            this.assignTypeLabel.Name = "assignTypeLabel";
            this.assignTypeLabel.Size = new System.Drawing.Size(57, 15);
            this.assignTypeLabel.TabIndex = 2;
            this.assignTypeLabel.Text = "<font color=\'red\'>*</font>转让方式:";
            // 
            // lblIsNotice
            // 
            this.lblIsNotice.AutoSize = true;
            this.lblIsNotice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblIsNotice.BackgroundStyle.Class = "";
            this.lblIsNotice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblIsNotice.Location = new System.Drawing.Point(283, 3);
            this.lblIsNotice.Name = "lblIsNotice";
            this.lblIsNotice.Size = new System.Drawing.Size(60, 15);
            this.lblIsNotice.TabIndex = 4;
            this.lblIsNotice.Text = "<font color=\'red\'>*</font>明/暗保理:";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblRemark.BackgroundStyle.Class = "";
            this.lblRemark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRemark.Location = new System.Drawing.Point(0, 86);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(84, 16);
            this.lblRemark.TabIndex = 17;
            this.lblRemark.Text = "内部提示信息:";
            // 
            // lblCasePaymentTerm
            // 
            this.lblCasePaymentTerm.AutoSize = true;
            this.lblCasePaymentTerm.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCasePaymentTerm.BackgroundStyle.Class = "";
            this.lblCasePaymentTerm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCasePaymentTerm.Location = new System.Drawing.Point(346, 87);
            this.lblCasePaymentTerm.Name = "lblCasePaymentTerm";
            this.lblCasePaymentTerm.Size = new System.Drawing.Size(104, 16);
            this.lblCasePaymentTerm.TabIndex = 21;
            this.lblCasePaymentTerm.Text = "最长付款期限(天):";
            // 
            // lblCDASignDate
            // 
            this.lblCDASignDate.AutoSize = true;
            this.lblCDASignDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCDASignDate.BackgroundStyle.Class = "";
            this.lblCDASignDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCDASignDate.Location = new System.Drawing.Point(242, 2);
            this.lblCDASignDate.Name = "lblCDASignDate";
            this.lblCDASignDate.Size = new System.Drawing.Size(57, 15);
            this.lblCDASignDate.TabIndex = 35;
            this.lblCDASignDate.Text = "<font color=\'red\'>*</font>签发日期:";
            // 
            // groupPanelCase
            // 
            this.groupPanelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCase.Controls.Add(this.lblCasePaymentTerm);
            this.groupPanelCase.Controls.Add(this.tbCasePaymentTerm);
            this.groupPanelCase.Controls.Add(this.invoiceCurrencyTextBox);
            this.groupPanelCase.Controls.Add(this.transactionTypeTextBox);
            this.groupPanelCase.Controls.Add(this.companyNameENTextBox);
            this.groupPanelCase.Controls.Add(this.contractCodeLabel);
            this.groupPanelCase.Controls.Add(this.contractCodeTextBox);
            this.groupPanelCase.Controls.Add(this.btnCaseSelect);
            this.groupPanelCase.Controls.Add(this.invoiceCurrencyLabel);
            this.groupPanelCase.Controls.Add(this.transactionTypeLabel);
            this.groupPanelCase.Controls.Add(this.buyerClientNameENTextBox);
            this.groupPanelCase.Controls.Add(this.buyerClientNameCNTextBox);
            this.groupPanelCase.Controls.Add(this.buyerClientEDICodeLabel);
            this.groupPanelCase.Controls.Add(this.buyerClientEDICodeTextBox);
            this.groupPanelCase.Controls.Add(this.sellerClientNameENTextBox);
            this.groupPanelCase.Controls.Add(this.companyNameCNTextBox);
            this.groupPanelCase.Controls.Add(this.factorCodeLabel);
            this.groupPanelCase.Controls.Add(this.factorCodeTextBox);
            this.groupPanelCase.Controls.Add(this.sellerClientNameCNTextBox);
            this.groupPanelCase.Controls.Add(this.sellerClientLabel);
            this.groupPanelCase.Controls.Add(this.sellerClientEDICodeTextBox);
            this.groupPanelCase.Controls.Add(this.caseCodeLabel);
            this.groupPanelCase.Controls.Add(this.caseCodeTextBox);
            this.groupPanelCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCase.Location = new System.Drawing.Point(0, 0);
            this.groupPanelCase.Name = "groupPanelCase";
            this.groupPanelCase.Size = new System.Drawing.Size(745, 115);
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
            this.groupPanelCase.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelCase.StyleMouseOver.Class = "";
            this.groupPanelCase.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelCase.TabIndex = 0;
            // 
            // tbCasePaymentTerm
            // 
            // 
            // 
            // 
            this.tbCasePaymentTerm.Border.Class = "TextBoxBorder";
            this.tbCasePaymentTerm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCasePaymentTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.NetPaymentTerm", true));
            this.tbCasePaymentTerm.Location = new System.Drawing.Point(456, 86);
            this.tbCasePaymentTerm.Name = "tbCasePaymentTerm";
            this.tbCasePaymentTerm.Size = new System.Drawing.Size(100, 20);
            this.tbCasePaymentTerm.TabIndex = 22;
            // 
            // CDABindingSource
            // 
            this.CDABindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CDA);
            // 
            // invoiceCurrencyTextBox
            // 
            // 
            // 
            // 
            this.invoiceCurrencyTextBox.Border.Class = "TextBoxBorder";
            this.invoiceCurrencyTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceCurrencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.InvoiceCurrency", true));
            this.invoiceCurrencyTextBox.Location = new System.Drawing.Point(429, 1);
            this.invoiceCurrencyTextBox.Name = "invoiceCurrencyTextBox";
            this.invoiceCurrencyTextBox.Size = new System.Drawing.Size(85, 20);
            this.invoiceCurrencyTextBox.TabIndex = 5;
            // 
            // transactionTypeTextBox
            // 
            // 
            // 
            // 
            this.transactionTypeTextBox.Border.Class = "TextBoxBorder";
            this.transactionTypeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.transactionTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.TransactionType", true));
            this.transactionTypeTextBox.Location = new System.Drawing.Point(242, 2);
            this.transactionTypeTextBox.Name = "transactionTypeTextBox";
            this.transactionTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionTypeTextBox.TabIndex = 3;
            // 
            // companyNameENTextBox
            // 
            // 
            // 
            // 
            this.companyNameENTextBox.Border.Class = "TextBoxBorder";
            this.companyNameENTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.companyNameENTextBox.Location = new System.Drawing.Point(520, 44);
            this.companyNameENTextBox.Name = "companyNameENTextBox";
            this.companyNameENTextBox.Size = new System.Drawing.Size(170, 20);
            this.companyNameENTextBox.TabIndex = 15;
            this.companyNameENTextBox.WatermarkText = "英文名";
            this.companyNameENTextBox.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // contractCodeTextBox
            // 
            // 
            // 
            // 
            this.contractCodeTextBox.Border.Class = "TextBoxBorder";
            this.contractCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contractCodeTextBox.Location = new System.Drawing.Point(456, 66);
            this.contractCodeTextBox.Name = "contractCodeTextBox";
            this.contractCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractCodeTextBox.TabIndex = 7;
            this.contractCodeTextBox.DoubleClick += new System.EventHandler(this.DetailContract);
            // 
            // btnCaseSelect
            // 
            this.btnCaseSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSelect.Location = new System.Drawing.Point(696, 23);
            this.btnCaseSelect.Name = "btnCaseSelect";
            this.btnCaseSelect.Size = new System.Drawing.Size(38, 41);
            this.btnCaseSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSelect.TabIndex = 20;
            this.btnCaseSelect.Text = "...";
            this.btnCaseSelect.Click += new System.EventHandler(this.SelectCase);
            // 
            // buyerClientNameENTextBox
            // 
            // 
            // 
            // 
            this.buyerClientNameENTextBox.Border.Class = "TextBoxBorder";
            this.buyerClientNameENTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.buyerClientNameENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerClient.ClientNameEN", true));
            this.buyerClientNameENTextBox.Location = new System.Drawing.Point(125, 86);
            this.buyerClientNameENTextBox.Name = "buyerClientNameENTextBox";
            this.buyerClientNameENTextBox.Size = new System.Drawing.Size(216, 20);
            this.buyerClientNameENTextBox.TabIndex = 19;
            this.buyerClientNameENTextBox.WatermarkText = "英文名";
            this.buyerClientNameENTextBox.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // buyerClientNameCNTextBox
            // 
            // 
            // 
            // 
            this.buyerClientNameCNTextBox.Border.Class = "TextBoxBorder";
            this.buyerClientNameCNTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.buyerClientNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerClient.ClientNameCN", true));
            this.buyerClientNameCNTextBox.Location = new System.Drawing.Point(125, 65);
            this.buyerClientNameCNTextBox.Name = "buyerClientNameCNTextBox";
            this.buyerClientNameCNTextBox.Size = new System.Drawing.Size(216, 20);
            this.buyerClientNameCNTextBox.TabIndex = 18;
            this.buyerClientNameCNTextBox.WatermarkText = "中文名";
            this.buyerClientNameCNTextBox.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // buyerClientEDICodeTextBox
            // 
            // 
            // 
            // 
            this.buyerClientEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.buyerClientEDICodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.buyerClientEDICodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.BuyerClient.ClientEDICode", true));
            this.buyerClientEDICodeTextBox.Location = new System.Drawing.Point(55, 67);
            this.buyerClientEDICodeTextBox.Name = "buyerClientEDICodeTextBox";
            this.buyerClientEDICodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.buyerClientEDICodeTextBox.TabIndex = 17;
            this.buyerClientEDICodeTextBox.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // sellerClientNameENTextBox
            // 
            // 
            // 
            // 
            this.sellerClientNameENTextBox.Border.Class = "TextBoxBorder";
            this.sellerClientNameENTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sellerClientNameENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerClient.ClientNameEN", true));
            this.sellerClientNameENTextBox.Location = new System.Drawing.Point(125, 44);
            this.sellerClientNameENTextBox.Name = "sellerClientNameENTextBox";
            this.sellerClientNameENTextBox.Size = new System.Drawing.Size(216, 20);
            this.sellerClientNameENTextBox.TabIndex = 11;
            this.sellerClientNameENTextBox.WatermarkText = "英文名";
            this.sellerClientNameENTextBox.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // companyNameCNTextBox
            // 
            // 
            // 
            // 
            this.companyNameCNTextBox.Border.Class = "TextBoxBorder";
            this.companyNameCNTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.companyNameCNTextBox.Location = new System.Drawing.Point(520, 23);
            this.companyNameCNTextBox.Name = "companyNameCNTextBox";
            this.companyNameCNTextBox.Size = new System.Drawing.Size(170, 20);
            this.companyNameCNTextBox.TabIndex = 14;
            this.companyNameCNTextBox.WatermarkText = "中文名";
            this.companyNameCNTextBox.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.factorCodeTextBox.Location = new System.Drawing.Point(429, 23);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.Size = new System.Drawing.Size(85, 20);
            this.factorCodeTextBox.TabIndex = 13;
            this.factorCodeTextBox.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // sellerClientNameCNTextBox
            // 
            // 
            // 
            // 
            this.sellerClientNameCNTextBox.Border.Class = "TextBoxBorder";
            this.sellerClientNameCNTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sellerClientNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerClient.ClientNameCN", true));
            this.sellerClientNameCNTextBox.Location = new System.Drawing.Point(125, 23);
            this.sellerClientNameCNTextBox.Name = "sellerClientNameCNTextBox";
            this.sellerClientNameCNTextBox.Size = new System.Drawing.Size(216, 20);
            this.sellerClientNameCNTextBox.TabIndex = 10;
            this.sellerClientNameCNTextBox.WatermarkText = "中文名";
            this.sellerClientNameCNTextBox.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // sellerClientEDICodeTextBox
            // 
            // 
            // 
            // 
            this.sellerClientEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.sellerClientEDICodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sellerClientEDICodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.SellerClient.ClientEDICode", true));
            this.sellerClientEDICodeTextBox.Location = new System.Drawing.Point(55, 23);
            this.sellerClientEDICodeTextBox.Name = "sellerClientEDICodeTextBox";
            this.sellerClientEDICodeTextBox.Size = new System.Drawing.Size(64, 20);
            this.sellerClientEDICodeTextBox.TabIndex = 9;
            this.sellerClientEDICodeTextBox.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // caseCodeTextBox
            // 
            // 
            // 
            // 
            this.caseCodeTextBox.Border.Class = "TextBoxBorder";
            this.caseCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.caseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.CaseCode", true));
            this.caseCodeTextBox.Location = new System.Drawing.Point(71, 2);
            this.caseCodeTextBox.Name = "caseCodeTextBox";
            this.caseCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.caseCodeTextBox.TabIndex = 1;
            this.caseCodeTextBox.DoubleClick += new System.EventHandler(this.DetailCase);
            // 
            // groupPanelCreditCover
            // 
            this.groupPanelCreditCover.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCreditCover.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCreditCover.Controls.Add(this.lblIsNotice);
            this.groupPanelCreditCover.Controls.Add(this.cbIsNotice);
            this.groupPanelCreditCover.Controls.Add(this.cbIsRecoarse);
            this.groupPanelCreditCover.Controls.Add(this.assignTypeLabel);
            this.groupPanelCreditCover.Controls.Add(this.assignTypeComboBox);
            this.groupPanelCreditCover.Controls.Add(this.lblCDACode);
            this.groupPanelCreditCover.Controls.Add(this.tbCDACode);
            this.groupPanelCreditCover.Controls.Add(this.tbHighestFinance);
            this.groupPanelCreditCover.Controls.Add(this.handFeeCurrComboBox);
            this.groupPanelCreditCover.Controls.Add(this.cbIsCreditCoverRevolving);
            this.groupPanelCreditCover.Controls.Add(this.handFeeLabel);
            this.groupPanelCreditCover.Controls.Add(this.lossThresholdLabel);
            this.groupPanelCreditCover.Controls.Add(this.delayDaysLabel);
            this.groupPanelCreditCover.Controls.Add(this.handFeeTextBox);
            this.groupPanelCreditCover.Controls.Add(this.lossThresholdTextBox);
            this.groupPanelCreditCover.Controls.Add(this.delayDaysTextBox);
            this.groupPanelCreditCover.Controls.Add(this.commissionTypeCommentLabel);
            this.groupPanelCreditCover.Controls.Add(this.deductiblesLabel);
            this.groupPanelCreditCover.Controls.Add(this.commissionTypeCommentTextBox);
            this.groupPanelCreditCover.Controls.Add(this.deductiblesTextBox);
            this.groupPanelCreditCover.Controls.Add(this.commissonTypeLabel);
            this.groupPanelCreditCover.Controls.Add(this.financeGracePeriodLabel);
            this.groupPanelCreditCover.Controls.Add(this.commissionTypeComboBox);
            this.groupPanelCreditCover.Controls.Add(this.financeGracePeriodTextBox);
            this.groupPanelCreditCover.Controls.Add(this.paymentTermsLabel);
            this.groupPanelCreditCover.Controls.Add(this.paymentTermsTextBox);
            this.groupPanelCreditCover.Controls.Add(this.iFPriceLabel);
            this.groupPanelCreditCover.Controls.Add(this.orderNumberLabel);
            this.groupPanelCreditCover.Controls.Add(this.iFPriceTextBox);
            this.groupPanelCreditCover.Controls.Add(this.orderNumberTextBox);
            this.groupPanelCreditCover.Controls.Add(this.priceLabel);
            this.groupPanelCreditCover.Controls.Add(this.priceTextBox);
            this.groupPanelCreditCover.Controls.Add(this.financeProportionLabel);
            this.groupPanelCreditCover.Controls.Add(this.financeProportionTextBox);
            this.groupPanelCreditCover.Controls.Add(this.lblHighestFinance);
            this.groupPanelCreditCover.Controls.Add(this.financeLinePeriodEndDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(this.financeLinePeriodBeginLabel);
            this.groupPanelCreditCover.Controls.Add(this.financeLinePeriodBeginDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(this.financeLineTextBox);
            this.groupPanelCreditCover.Controls.Add(this.financeLineCurrLabel);
            this.groupPanelCreditCover.Controls.Add(this.financeLineCurrComboBox);
            this.groupPanelCreditCover.Controls.Add(this.reassignGracePeriodLabel);
            this.groupPanelCreditCover.Controls.Add(this.reassignGracePeriodTextBox);
            this.groupPanelCreditCover.Controls.Add(this.pUGPeriodLabel);
            this.groupPanelCreditCover.Controls.Add(this.pUGPeriodTextBox);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverPeriodEndDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverPeriodBeginLabel);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverPeriodBeginDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(this.pUGProportionLabel);
            this.groupPanelCreditCover.Controls.Add(this.pUGProportionTextBox);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverTextBox);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverCurrLabel);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverCurrComboBox);
            this.groupPanelCreditCover.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditCover.Location = new System.Drawing.Point(0, 115);
            this.groupPanelCreditCover.Name = "groupPanelCreditCover";
            this.groupPanelCreditCover.Size = new System.Drawing.Size(745, 257);
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
            this.groupPanelCreditCover.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelCreditCover.StyleMouseOver.Class = "";
            this.groupPanelCreditCover.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelCreditCover.TabIndex = 1;
            // 
            // cbIsNotice
            // 
            this.cbIsNotice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "IsNotice", true));
            this.cbIsNotice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsNotice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIsNotice.FormattingEnabled = true;
            this.cbIsNotice.Items.AddRange(new object[] {
            "明保理",
            "暗保理"});
            this.cbIsNotice.Location = new System.Drawing.Point(351, 1);
            this.cbIsNotice.Name = "cbIsNotice";
            this.cbIsNotice.Size = new System.Drawing.Size(101, 21);
            this.cbIsNotice.TabIndex = 5;
            // 
            // cbIsRecoarse
            // 
            this.cbIsRecoarse.AutoSize = true;
            this.cbIsRecoarse.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsRecoarse.BackgroundStyle.Class = "";
            this.cbIsRecoarse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsRecoarse.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CDABindingSource, "IsRecoarse", true));
            this.cbIsRecoarse.Location = new System.Drawing.Point(458, 3);
            this.cbIsRecoarse.Name = "cbIsRecoarse";
            this.cbIsRecoarse.Size = new System.Drawing.Size(101, 16);
            this.cbIsRecoarse.TabIndex = 6;
            this.cbIsRecoarse.Text = "是否有追索权";
            this.cbIsRecoarse.CheckedChanged += new System.EventHandler(this.CbIsRecoarseCheckedChanged);
            // 
            // assignTypeComboBox
            // 
            this.assignTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "AssignType", true));
            this.assignTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.assignTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignTypeComboBox.FormattingEnabled = true;
            this.assignTypeComboBox.Location = new System.Drawing.Point(625, 2);
            this.assignTypeComboBox.Name = "assignTypeComboBox";
            this.assignTypeComboBox.Size = new System.Drawing.Size(74, 21);
            this.assignTypeComboBox.TabIndex = 3;
            // 
            // tbCDACode
            // 
            // 
            // 
            // 
            this.tbCDACode.Border.Class = "TextBoxBorder";
            this.tbCDACode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCDACode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CDACode", true));
            this.tbCDACode.Location = new System.Drawing.Point(101, 2);
            this.tbCDACode.Name = "tbCDACode";
            this.tbCDACode.ReadOnly = true;
            this.tbCDACode.Size = new System.Drawing.Size(154, 20);
            this.tbCDACode.TabIndex = 1;
            // 
            // tbHighestFinance
            // 
            // 
            // 
            // 
            this.tbHighestFinance.Border.Class = "TextBoxBorder";
            this.tbHighestFinance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbHighestFinance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "HighestFinanceLine", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbHighestFinance.Location = new System.Drawing.Point(131, 91);
            this.tbHighestFinance.Name = "tbHighestFinance";
            this.tbHighestFinance.Size = new System.Drawing.Size(100, 20);
            this.tbHighestFinance.TabIndex = 27;
            // 
            // handFeeCurrComboBox
            // 
            this.handFeeCurrComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.handFeeCurrComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.handFeeCurrComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "HandFeeCurr", true));
            this.handFeeCurrComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.handFeeCurrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.handFeeCurrComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.handFeeCurrComboBox.FormattingEnabled = true;
            this.handFeeCurrComboBox.Location = new System.Drawing.Point(560, 206);
            this.handFeeCurrComboBox.Name = "handFeeCurrComboBox";
            this.handFeeCurrComboBox.Size = new System.Drawing.Size(53, 21);
            this.handFeeCurrComboBox.TabIndex = 47;
            this.handFeeCurrComboBox.WatermarkText = "币别";
            // 
            // cbIsCreditCoverRevolving
            // 
            this.cbIsCreditCoverRevolving.AutoSize = true;
            this.cbIsCreditCoverRevolving.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsCreditCoverRevolving.BackgroundStyle.Class = "";
            this.cbIsCreditCoverRevolving.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsCreditCoverRevolving.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CDABindingSource, "IsCreditCoverRevolving", true));
            this.cbIsCreditCoverRevolving.Location = new System.Drawing.Point(101, 162);
            this.cbIsCreditCoverRevolving.Name = "cbIsCreditCoverRevolving";
            this.cbIsCreditCoverRevolving.Size = new System.Drawing.Size(101, 16);
            this.cbIsCreditCoverRevolving.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsCreditCoverRevolving.TabIndex = 13;
            this.cbIsCreditCoverRevolving.Text = "是否循环额度";
            this.cbIsCreditCoverRevolving.CheckedChanged += new System.EventHandler(this.CbIsCreditCoverRevolvingCheckedChanged);
            // 
            // handFeeTextBox
            // 
            // 
            // 
            // 
            this.handFeeTextBox.Border.Class = "TextBoxBorder";
            this.handFeeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.handFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "HandFee", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.handFeeTextBox.Location = new System.Drawing.Point(618, 206);
            this.handFeeTextBox.Name = "handFeeTextBox";
            this.handFeeTextBox.Size = new System.Drawing.Size(81, 20);
            this.handFeeTextBox.TabIndex = 48;
            // 
            // lossThresholdTextBox
            // 
            // 
            // 
            // 
            this.lossThresholdTextBox.Border.Class = "TextBoxBorder";
            this.lossThresholdTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lossThresholdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "LossThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lossThresholdTextBox.Location = new System.Drawing.Point(350, 180);
            this.lossThresholdTextBox.Name = "lossThresholdTextBox";
            this.lossThresholdTextBox.Size = new System.Drawing.Size(100, 20);
            this.lossThresholdTextBox.TabIndex = 39;
            this.superValidator.SetValidator1(this.lossThresholdTextBox, this.customValidator8);
            // 
            // delayDaysTextBox
            // 
            // 
            // 
            // 
            this.delayDaysTextBox.Border.Class = "TextBoxBorder";
            this.delayDaysTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.delayDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "DelayDays", true));
            this.delayDaysTextBox.Location = new System.Drawing.Point(520, 185);
            this.delayDaysTextBox.Name = "delayDaysTextBox";
            this.delayDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.delayDaysTextBox.TabIndex = 39;
            // 
            // commissionTypeCommentTextBox
            // 
            // 
            // 
            // 
            this.commissionTypeCommentTextBox.Border.Class = "TextBoxBorder";
            this.commissionTypeCommentTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionTypeCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CommissionTypeComment", true));
            this.commissionTypeCommentTextBox.Location = new System.Drawing.Point(284, 229);
            this.commissionTypeCommentTextBox.Name = "commissionTypeCommentTextBox";
            this.commissionTypeCommentTextBox.Size = new System.Drawing.Size(415, 20);
            this.commissionTypeCommentTextBox.TabIndex = 52;
            this.superValidator.SetValidator1(this.commissionTypeCommentTextBox, this.customValidator1);
            // 
            // deductiblesTextBox
            // 
            // 
            // 
            // 
            this.deductiblesTextBox.Border.Class = "TextBoxBorder";
            this.deductiblesTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deductiblesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Deductibles", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.deductiblesTextBox.Location = new System.Drawing.Point(101, 181);
            this.deductiblesTextBox.Name = "deductiblesTextBox";
            this.deductiblesTextBox.Size = new System.Drawing.Size(109, 20);
            this.deductiblesTextBox.TabIndex = 37;
            this.superValidator.SetValidator1(this.deductiblesTextBox, this.customValidator7);
            // 
            // commissionTypeComboBox
            // 
            this.commissionTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CommissionType", true));
            this.commissionTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.commissionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commissionTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commissionTypeComboBox.FormattingEnabled = true;
            this.commissionTypeComboBox.Location = new System.Drawing.Point(101, 227);
            this.commissionTypeComboBox.Name = "commissionTypeComboBox";
            this.commissionTypeComboBox.Size = new System.Drawing.Size(109, 21);
            this.commissionTypeComboBox.TabIndex = 50;
            this.superValidator.SetValidator1(this.commissionTypeComboBox, this.requiredFieldValidator2);
            // 
            // financeGracePeriodTextBox
            // 
            // 
            // 
            // 
            this.financeGracePeriodTextBox.Border.Class = "TextBoxBorder";
            this.financeGracePeriodTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeGracePeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "FinanceGracePeriod", true));
            this.financeGracePeriodTextBox.Location = new System.Drawing.Point(599, 91);
            this.financeGracePeriodTextBox.Name = "financeGracePeriodTextBox";
            this.financeGracePeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeGracePeriodTextBox.TabIndex = 31;
            // 
            // paymentTermsTextBox
            // 
            // 
            // 
            // 
            this.paymentTermsTextBox.Border.Class = "TextBoxBorder";
            this.paymentTermsTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentTermsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "PaymentTerms", true));
            this.paymentTermsTextBox.Location = new System.Drawing.Point(101, 113);
            this.paymentTermsTextBox.Multiline = true;
            this.paymentTermsTextBox.Name = "paymentTermsTextBox";
            this.paymentTermsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.paymentTermsTextBox.Size = new System.Drawing.Size(598, 43);
            this.paymentTermsTextBox.TabIndex = 33;
            this.superValidator.SetValidator1(this.paymentTermsTextBox, this.requiredFieldValidator1);
            // 
            // iFPriceTextBox
            // 
            // 
            // 
            // 
            this.iFPriceTextBox.Border.Class = "TextBoxBorder";
            this.iFPriceTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iFPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "IFPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p4"));
            this.iFPriceTextBox.Location = new System.Drawing.Point(350, 205);
            this.iFPriceTextBox.Name = "iFPriceTextBox";
            this.iFPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.iFPriceTextBox.TabIndex = 43;
            this.superValidator.SetValidator1(this.iFPriceTextBox, this.customValidator10);
            // 
            // orderNumberTextBox
            // 
            // 
            // 
            // 
            this.orderNumberTextBox.Border.Class = "TextBoxBorder";
            this.orderNumberTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.orderNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "OrderNumber", true));
            this.orderNumberTextBox.Enabled = false;
            this.orderNumberTextBox.Location = new System.Drawing.Point(350, 158);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderNumberTextBox.TabIndex = 35;
            // 
            // priceTextBox
            // 
            // 
            // 
            // 
            this.priceTextBox.Border.Class = "TextBoxBorder";
            this.priceTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p4"));
            this.priceTextBox.Location = new System.Drawing.Point(101, 203);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(109, 20);
            this.priceTextBox.TabIndex = 41;
            this.superValidator.SetValidator1(this.priceTextBox, this.customValidator9);
            // 
            // financeProportionTextBox
            // 
            // 
            // 
            // 
            this.financeProportionTextBox.Border.Class = "TextBoxBorder";
            this.financeProportionTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeProportionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "FinanceProportion", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p0"));
            this.financeProportionTextBox.Location = new System.Drawing.Point(350, 90);
            this.financeProportionTextBox.Name = "financeProportionTextBox";
            this.financeProportionTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeProportionTextBox.TabIndex = 29;
            // 
            // financeLinePeriodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.financeLinePeriodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financeLinePeriodEndDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.financeLinePeriodEndDateTimePicker.ButtonFreeText.Checked = true;
            this.financeLinePeriodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "FinanceLinePeriodEnd", true));
            this.financeLinePeriodEndDateTimePicker.FreeTextEntryMode = true;
            this.financeLinePeriodEndDateTimePicker.Location = new System.Drawing.Point(468, 68);
            // 
            // 
            // 
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financeLinePeriodEndDateTimePicker.Name = "financeLinePeriodEndDateTimePicker";
            this.financeLinePeriodEndDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.financeLinePeriodEndDateTimePicker.TabIndex = 25;
            this.superValidator.SetValidator1(this.financeLinePeriodEndDateTimePicker, this.compareValidator2);
            this.superValidator.SetValidator2(this.financeLinePeriodEndDateTimePicker, this.customValidator6);
            // 
            // financeLinePeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financeLinePeriodBeginDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financeLinePeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.financeLinePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "FinanceLinePeriodBegin", true));
            this.financeLinePeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.financeLinePeriodBeginDateTimePicker.Location = new System.Drawing.Point(350, 68);
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financeLinePeriodBeginDateTimePicker.Name = "financeLinePeriodBeginDateTimePicker";
            this.financeLinePeriodBeginDateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.financeLinePeriodBeginDateTimePicker.TabIndex = 24;
            // 
            // financeLineTextBox
            // 
            // 
            // 
            // 
            this.financeLineTextBox.Border.Class = "TextBoxBorder";
            this.financeLineTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "FinanceLine", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.financeLineTextBox.Location = new System.Drawing.Point(175, 69);
            this.financeLineTextBox.Name = "financeLineTextBox";
            this.financeLineTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeLineTextBox.TabIndex = 22;
            this.superValidator.SetValidator1(this.financeLineTextBox, this.customValidator4);
            this.superValidator.SetValidator2(this.financeLineTextBox, this.customValidator5);
            // 
            // financeLineCurrComboBox
            // 
            this.financeLineCurrComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.financeLineCurrComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.financeLineCurrComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "FinanceLineCurr", true));
            this.financeLineCurrComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.financeLineCurrComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeLineCurrComboBox.FormattingEnabled = true;
            this.financeLineCurrComboBox.Location = new System.Drawing.Point(101, 68);
            this.financeLineCurrComboBox.Name = "financeLineCurrComboBox";
            this.financeLineCurrComboBox.Size = new System.Drawing.Size(68, 21);
            this.financeLineCurrComboBox.TabIndex = 21;
            this.financeLineCurrComboBox.WatermarkText = "币别";
            // 
            // reassignGracePeriodTextBox
            // 
            // 
            // 
            // 
            this.reassignGracePeriodTextBox.Border.Class = "TextBoxBorder";
            this.reassignGracePeriodTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reassignGracePeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "ReassignGracePeriod", true));
            this.reassignGracePeriodTextBox.Location = new System.Drawing.Point(599, 47);
            this.reassignGracePeriodTextBox.Name = "reassignGracePeriodTextBox";
            this.reassignGracePeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.reassignGracePeriodTextBox.TabIndex = 19;
            // 
            // pUGPeriodTextBox
            // 
            // 
            // 
            // 
            this.pUGPeriodTextBox.Border.Class = "TextBoxBorder";
            this.pUGPeriodTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pUGPeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "PUGPeriod", true));
            this.pUGPeriodTextBox.Location = new System.Drawing.Point(350, 45);
            this.pUGPeriodTextBox.Name = "pUGPeriodTextBox";
            this.pUGPeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.pUGPeriodTextBox.TabIndex = 17;
            // 
            // creditCoverPeriodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.creditCoverPeriodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.creditCoverPeriodEndDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.creditCoverPeriodEndDateTimePicker.ButtonFreeText.Checked = true;
            this.creditCoverPeriodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "CreditCoverPeriodEnd", true));
            this.creditCoverPeriodEndDateTimePicker.FreeTextEntryMode = true;
            this.creditCoverPeriodEndDateTimePicker.Location = new System.Drawing.Point(469, 25);
            // 
            // 
            // 
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.creditCoverPeriodEndDateTimePicker.Name = "creditCoverPeriodEndDateTimePicker";
            this.creditCoverPeriodEndDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.creditCoverPeriodEndDateTimePicker.TabIndex = 12;
            this.superValidator.SetValidator1(this.creditCoverPeriodEndDateTimePicker, this.compareValidator1);
            this.superValidator.SetValidator2(this.creditCoverPeriodEndDateTimePicker, this.customValidator3);
            // 
            // creditCoverPeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.creditCoverPeriodBeginDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.creditCoverPeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.creditCoverPeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "CreditCoverPeriodBegin", true));
            this.creditCoverPeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.creditCoverPeriodBeginDateTimePicker.Location = new System.Drawing.Point(351, 24);
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.creditCoverPeriodBeginDateTimePicker.Name = "creditCoverPeriodBeginDateTimePicker";
            this.creditCoverPeriodBeginDateTimePicker.Size = new System.Drawing.Size(107, 20);
            this.creditCoverPeriodBeginDateTimePicker.TabIndex = 11;
            // 
            // pUGProportionTextBox
            // 
            // 
            // 
            // 
            this.pUGProportionTextBox.Border.Class = "TextBoxBorder";
            this.pUGProportionTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pUGProportionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "PUGProportion", true));
            this.pUGProportionTextBox.Location = new System.Drawing.Point(101, 47);
            this.pUGProportionTextBox.Name = "pUGProportionTextBox";
            this.pUGProportionTextBox.Size = new System.Drawing.Size(104, 20);
            this.pUGProportionTextBox.TabIndex = 15;
            // 
            // creditCoverTextBox
            // 
            // 
            // 
            // 
            this.creditCoverTextBox.Border.Class = "TextBoxBorder";
            this.creditCoverTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.creditCoverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CreditCover", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.creditCoverTextBox.Location = new System.Drawing.Point(175, 24);
            this.creditCoverTextBox.Name = "creditCoverTextBox";
            this.creditCoverTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditCoverTextBox.TabIndex = 9;
            this.superValidator.SetValidator1(this.creditCoverTextBox, this.customValidator2);
            // 
            // creditCoverCurrComboBox
            // 
            this.creditCoverCurrComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.creditCoverCurrComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.creditCoverCurrComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CreditCoverCurr", true));
            this.creditCoverCurrComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creditCoverCurrComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCoverCurrComboBox.FormattingEnabled = true;
            this.creditCoverCurrComboBox.Location = new System.Drawing.Point(101, 24);
            this.creditCoverCurrComboBox.Name = "creditCoverCurrComboBox";
            this.creditCoverCurrComboBox.Size = new System.Drawing.Size(68, 21);
            this.creditCoverCurrComboBox.TabIndex = 8;
            this.creditCoverCurrComboBox.WatermarkText = "币别";
            // 
            // groupPanelOther
            // 
            this.groupPanelOther.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelOther.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelOther.Controls.Add(this.lblCDASignDate);
            this.groupPanelOther.Controls.Add(this.diCDASignDate);
            this.groupPanelOther.Controls.Add(this.cbIsSigned);
            this.groupPanelOther.Controls.Add(this.lblRemark);
            this.groupPanelOther.Controls.Add(this.tbRemark);
            this.groupPanelOther.Controls.Add(this.cbNoticeMethodFax);
            this.groupPanelOther.Controls.Add(this.cbNoticeMethodEmail);
            this.groupPanelOther.Controls.Add(this.noticeMethodLabel);
            this.groupPanelOther.Controls.Add(this.cDAStatusLabel);
            this.groupPanelOther.Controls.Add(this.cDAStatusComboBox);
            this.groupPanelOther.Controls.Add(this.createUserNameLabel);
            this.groupPanelOther.Controls.Add(this.createUserNameTextBox);
            this.groupPanelOther.Controls.Add(this.commentLabel);
            this.groupPanelOther.Controls.Add(this.commentTextBox);
            this.groupPanelOther.Controls.Add(this.faxLabel);
            this.groupPanelOther.Controls.Add(this.faxTextBox);
            this.groupPanelOther.Controls.Add(this.emailLabel);
            this.groupPanelOther.Controls.Add(this.emailTextBox);
            this.groupPanelOther.Controls.Add(this.noticePersonLabel);
            this.groupPanelOther.Controls.Add(this.noticePersonTextBox);
            this.groupPanelOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelOther.Location = new System.Drawing.Point(0, 372);
            this.groupPanelOther.Name = "groupPanelOther";
            this.groupPanelOther.Size = new System.Drawing.Size(745, 131);
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
            this.groupPanelOther.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelOther.StyleMouseOver.Class = "";
            this.groupPanelOther.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelOther.TabIndex = 2;
            // 
            // diCDASignDate
            // 
            // 
            // 
            // 
            this.diCDASignDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diCDASignDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diCDASignDate.ButtonDropDown.Visible = true;
            this.diCDASignDate.ButtonFreeText.Checked = true;
            this.diCDASignDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "CDASignDate", true));
            this.diCDASignDate.FreeTextEntryMode = true;
            this.diCDASignDate.Location = new System.Drawing.Point(310, 1);
            // 
            // 
            // 
            this.diCDASignDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diCDASignDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diCDASignDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diCDASignDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diCDASignDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diCDASignDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diCDASignDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diCDASignDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diCDASignDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diCDASignDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diCDASignDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diCDASignDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diCDASignDate.MonthCalendar.TodayButtonVisible = true;
            this.diCDASignDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diCDASignDate.Name = "diCDASignDate";
            this.diCDASignDate.Size = new System.Drawing.Size(108, 20);
            this.diCDASignDate.TabIndex = 26;
            this.superValidator.SetValidator1(this.diCDASignDate, this.requiredFieldValidator3);
            // 
            // cbIsSigned
            // 
            this.cbIsSigned.AutoSize = true;
            this.cbIsSigned.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsSigned.BackgroundStyle.Class = "";
            this.cbIsSigned.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsSigned.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CDABindingSource, "IsSigned", true));
            this.cbIsSigned.Location = new System.Drawing.Point(429, 3);
            this.cbIsSigned.Name = "cbIsSigned";
            this.cbIsSigned.Size = new System.Drawing.Size(76, 16);
            this.cbIsSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsSigned.TabIndex = 19;
            this.cbIsSigned.Text = "是否签回";
            // 
            // tbRemark
            // 
            // 
            // 
            // 
            this.tbRemark.Border.Class = "TextBoxBorder";
            this.tbRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Remark", true));
            this.tbRemark.Location = new System.Drawing.Point(101, 86);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRemark.Size = new System.Drawing.Size(438, 37);
            this.tbRemark.TabIndex = 18;
            // 
            // cbNoticeMethodFax
            // 
            this.cbNoticeMethodFax.AutoSize = true;
            this.cbNoticeMethodFax.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbNoticeMethodFax.BackgroundStyle.Class = "";
            this.cbNoticeMethodFax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbNoticeMethodFax.Location = new System.Drawing.Point(447, 27);
            this.cbNoticeMethodFax.Name = "cbNoticeMethodFax";
            this.cbNoticeMethodFax.Size = new System.Drawing.Size(51, 16);
            this.cbNoticeMethodFax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNoticeMethodFax.TabIndex = 6;
            this.cbNoticeMethodFax.Text = "传真";
            // 
            // cbNoticeMethodEmail
            // 
            this.cbNoticeMethodEmail.AutoSize = true;
            this.cbNoticeMethodEmail.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbNoticeMethodEmail.BackgroundStyle.Class = "";
            this.cbNoticeMethodEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbNoticeMethodEmail.Location = new System.Drawing.Point(398, 27);
            this.cbNoticeMethodEmail.Name = "cbNoticeMethodEmail";
            this.cbNoticeMethodEmail.Size = new System.Drawing.Size(51, 16);
            this.cbNoticeMethodEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNoticeMethodEmail.TabIndex = 5;
            this.cbNoticeMethodEmail.Text = "电邮";
            // 
            // cDAStatusComboBox
            // 
            this.cDAStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CDAStatus", true));
            this.cDAStatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cDAStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDAStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cDAStatusComboBox.FormattingEnabled = true;
            this.cDAStatusComboBox.Location = new System.Drawing.Point(101, 0);
            this.cDAStatusComboBox.Name = "cDAStatusComboBox";
            this.cDAStatusComboBox.Size = new System.Drawing.Size(109, 21);
            this.cDAStatusComboBox.TabIndex = 3;
            // 
            // createUserNameTextBox
            // 
            // 
            // 
            // 
            this.createUserNameTextBox.Border.Class = "TextBoxBorder";
            this.createUserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(599, 49);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.ReadOnly = true;
            this.createUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.createUserNameTextBox.TabIndex = 16;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(101, 48);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentTextBox.Size = new System.Drawing.Size(438, 37);
            this.commentTextBox.TabIndex = 14;
            // 
            // faxTextBox
            // 
            // 
            // 
            // 
            this.faxTextBox.Border.Class = "TextBoxBorder";
            this.faxTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(599, 25);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(100, 20);
            this.faxTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.Border.Class = "TextBoxBorder";
            this.emailTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(599, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 10;
            this.superValidator.SetValidator1(this.emailTextBox, this.regularExpressionValidator1);
            // 
            // noticePersonTextBox
            // 
            // 
            // 
            // 
            this.noticePersonTextBox.Border.Class = "TextBoxBorder";
            this.noticePersonTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.noticePersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "NoticePerson", true));
            this.noticePersonTextBox.Location = new System.Drawing.Point(101, 23);
            this.noticePersonTextBox.Name = "noticePersonTextBox";
            this.noticePersonTextBox.Size = new System.Drawing.Size(109, 20);
            this.noticePersonTextBox.TabIndex = 8;
            // 
            // btnCDAUpdate
            // 
            this.btnCDAUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDAUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDAUpdate.Location = new System.Drawing.Point(264, 509);
            this.btnCDAUpdate.Name = "btnCDAUpdate";
            this.btnCDAUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCDAUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDAUpdate.TabIndex = 3;
            this.btnCDAUpdate.Text = "编辑";
            this.btnCDAUpdate.Click += new System.EventHandler(this.UpdateCDA);
            // 
            // btnCDASave
            // 
            this.btnCDASave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDASave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDASave.Location = new System.Drawing.Point(345, 509);
            this.btnCDASave.Name = "btnCDASave";
            this.btnCDASave.Size = new System.Drawing.Size(75, 23);
            this.btnCDASave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDASave.TabIndex = 4;
            this.btnCDASave.Text = "保存";
            this.btnCDASave.Click += new System.EventHandler(this.SaveCDA);
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // customValidator8
            // 
            this.customValidator8.ErrorMessage = "最低损失门槛不能大于买方信用风险额度";
            this.customValidator8.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator8.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator8ValidateValue);
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "必填";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator1ValidateValue);
            // 
            // customValidator7
            // 
            this.customValidator7.ErrorMessage = "自负额不能大于买方信用风险额度";
            this.customValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator7.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator7ValidateValue);
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator10
            // 
            this.customValidator10.ErrorMessage = "必填";
            this.customValidator10.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator10.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator10ValidateValue);
            // 
            // customValidator9
            // 
            this.customValidator9.ErrorMessage = "必填";
            this.customValidator9.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator9.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator9ValidateValue);
            // 
            // compareValidator2
            // 
            this.compareValidator2.ControlToCompare = this.financeLinePeriodBeginDateTimePicker;
            this.compareValidator2.ErrorMessage = "终止日期应该大于起始日期";
            this.compareValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator2.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // customValidator6
            // 
            this.customValidator6.ErrorMessage = "预付款额度有效期限不能超出客户融资额度的有效期限";
            this.customValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator6.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator6ValidateValue);
            // 
            // customValidator4
            // 
            this.customValidator4.ErrorMessage = "预付款额度不能大于客户的融资额度上限";
            this.customValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator4.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator4ValidateValue);
            // 
            // customValidator5
            // 
            this.customValidator5.ErrorMessage = "预付款额度不能大于买方风险担保额度";
            this.customValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator5.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator5ValidateValue);
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.creditCoverPeriodBeginDateTimePicker;
            this.compareValidator1.ErrorMessage = "终止日期应该大于起始日期";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // customValidator3
            // 
            this.customValidator3.ErrorMessage = "买方信用风险额度的有效期限不能超出客户买方信用风险额度的有效期限";
            this.customValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator3.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator3ValidateValue);
            // 
            // customValidator2
            // 
            this.customValidator2.ErrorMessage = "额度通知书中买方信用风险额度不能大于案子中买方信用风险额度";
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator2.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator2ValidateValue);
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "需要符合Email地址格式";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
                "})$";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // CDADetail
            // 
            this.AcceptButton = this.btnCDASave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 535);
            this.Controls.Add(this.btnCDASave);
            this.Controls.Add(this.btnCDAUpdate);
            this.Controls.Add(this.groupPanelOther);
            this.Controls.Add(this.groupPanelCreditCover);
            this.Controls.Add(this.groupPanelCase);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CDADetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "额度通知书";
            this.groupPanelCase.ResumeLayout(false);
            this.groupPanelCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDABindingSource)).EndInit();
            this.groupPanelCreditCover.ResumeLayout(false);
            this.groupPanelCreditCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financeLinePeriodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeLinePeriodBeginDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverPeriodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverPeriodBeginDateTimePicker)).EndInit();
            this.groupPanelOther.ResumeLayout(false);
            this.groupPanelOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diCDASignDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX caseCodeLabel;
        private DevComponents.DotNetBar.LabelX sellerClientLabel;
        private DevComponents.DotNetBar.LabelX factorCodeLabel;
        private DevComponents.DotNetBar.LabelX buyerClientEDICodeLabel;
        private DevComponents.DotNetBar.LabelX transactionTypeLabel;
        private DevComponents.DotNetBar.LabelX invoiceCurrencyLabel;
        private DevComponents.DotNetBar.LabelX creditCoverCurrLabel;
        private DevComponents.DotNetBar.LabelX pUGProportionLabel;
        private DevComponents.DotNetBar.LabelX creditCoverPeriodBeginLabel;
        private DevComponents.DotNetBar.LabelX pUGPeriodLabel;
        private DevComponents.DotNetBar.LabelX reassignGracePeriodLabel;
        private DevComponents.DotNetBar.LabelX financeLineCurrLabel;
        private DevComponents.DotNetBar.LabelX financeLinePeriodBeginLabel;
        private DevComponents.DotNetBar.LabelX lblHighestFinance;
        private DevComponents.DotNetBar.LabelX financeProportionLabel;
        private DevComponents.DotNetBar.LabelX orderNumberLabel;
        private DevComponents.DotNetBar.LabelX paymentTermsLabel;
        private DevComponents.DotNetBar.LabelX financeGracePeriodLabel;
        private DevComponents.DotNetBar.LabelX deductiblesLabel;
        private DevComponents.DotNetBar.LabelX lossThresholdLabel;
        private DevComponents.DotNetBar.LabelX delayDaysLabel;
        private DevComponents.DotNetBar.LabelX priceLabel;
        private DevComponents.DotNetBar.LabelX iFPriceLabel;
        private DevComponents.DotNetBar.LabelX commissonTypeLabel;
        private DevComponents.DotNetBar.LabelX commissionTypeCommentLabel;
        private DevComponents.DotNetBar.LabelX handFeeLabel;
        private DevComponents.DotNetBar.LabelX noticePersonLabel;
        private DevComponents.DotNetBar.LabelX emailLabel;
        private DevComponents.DotNetBar.LabelX faxLabel;
        private DevComponents.DotNetBar.LabelX commentLabel;
        private DevComponents.DotNetBar.LabelX createUserNameLabel;
        private DevComponents.DotNetBar.LabelX cDAStatusLabel;
        private DevComponents.DotNetBar.LabelX noticeMethodLabel;
        private DevComponents.DotNetBar.LabelX contractCodeLabel;
        private DevComponents.DotNetBar.LabelX lblCDACode;
        private DevComponents.DotNetBar.LabelX assignTypeLabel;
        private DevComponents.DotNetBar.LabelX lblIsNotice;
        private DevComponents.DotNetBar.LabelX lblRemark;
        private DevComponents.DotNetBar.LabelX lblCasePaymentTerm;
        private DevComponents.DotNetBar.LabelX lblCDASignDate;
    }
}