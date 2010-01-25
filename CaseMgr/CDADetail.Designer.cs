namespace CMBC.EasyFactor.CaseMgr
{
    partial class CDADetail
    {
        #region Fields (72)

        private DevComponents.DotNetBar.ButtonX btnCaseSelect;
        private DevComponents.DotNetBar.ButtonX btnCDAReset;
        private DevComponents.DotNetBar.ButtonX btnCDASave;
        private DevComponents.DotNetBar.ButtonX btnCDAUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerClientEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerClientNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX buyerClientNameENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX caseCodeTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCreditCoverRevolving;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbNoticeMethodEmail;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbNoticeMethodFax;
        private System.Windows.Forms.BindingSource CDABindingSource;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cDASignDateDateTimePicker;
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
        private DevComponents.DotNetBar.Controls.TextBoxX deductiblesTextBox;
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
        private DevComponents.DotNetBar.Controls.TextBoxX sellerClientEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerClientNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX sellerClientNameENTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbHighestFinance;
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



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.LabelX caseCodeLabel;
            DevComponents.DotNetBar.LabelX sellerClientLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX buyerClientEDICodeLabel;
            DevComponents.DotNetBar.LabelX transactionTypeLabel;
            DevComponents.DotNetBar.LabelX invoiceCurrencyLabel;
            DevComponents.DotNetBar.LabelX creditCoverCurrLabel;
            DevComponents.DotNetBar.LabelX pUGProportionLabel;
            DevComponents.DotNetBar.LabelX creditCoverPeriodBeginLabel;
            DevComponents.DotNetBar.LabelX pUGPeriodLabel;
            DevComponents.DotNetBar.LabelX reassignGracePeriodLabel;
            DevComponents.DotNetBar.LabelX financeLineCurrLabel;
            DevComponents.DotNetBar.LabelX financeLinePeriodBeginLabel;
            DevComponents.DotNetBar.LabelX lblHighestFinance;
            DevComponents.DotNetBar.LabelX financeProportionLabel;
            DevComponents.DotNetBar.LabelX orderNumberLabel;
            DevComponents.DotNetBar.LabelX paymentTermsLabel;
            DevComponents.DotNetBar.LabelX financeGracePeriodLabel;
            DevComponents.DotNetBar.LabelX deductiblesLabel;
            DevComponents.DotNetBar.LabelX lossThresholdLabel;
            DevComponents.DotNetBar.LabelX priceLabel;
            DevComponents.DotNetBar.LabelX iFPriceLabel;
            DevComponents.DotNetBar.LabelX commissonTypeLabel;
            DevComponents.DotNetBar.LabelX commissionTypeCommentLabel;
            DevComponents.DotNetBar.LabelX handFeeLabel;
            DevComponents.DotNetBar.LabelX noticePersonLabel;
            DevComponents.DotNetBar.LabelX emailLabel;
            DevComponents.DotNetBar.LabelX faxLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX createUserNameLabel;
            DevComponents.DotNetBar.LabelX cDASignDateLabel;
            DevComponents.DotNetBar.LabelX cDAStatusLabel;
            DevComponents.DotNetBar.LabelX noticeMethodLabel;
            DevComponents.DotNetBar.LabelX contractCodeLabel;
            DevComponents.DotNetBar.LabelX lblCDACode;
            DevComponents.DotNetBar.LabelX assignTypeLabel;
            DevComponents.DotNetBar.LabelX lblIsNotice;
            DevComponents.DotNetBar.LabelX lblRemark;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDADetail));
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.invoiceCurrencyTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CDABindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tbRemark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbNoticeMethodFax = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbNoticeMethodEmail = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cDAStatusComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cDASignDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.createUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.faxTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.noticePersonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCDAUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCDASave = new DevComponents.DotNetBar.ButtonX();
            this.btnCDAReset = new DevComponents.DotNetBar.ButtonX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.compareValidator2 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.customValidator6 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator4 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator5 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.customValidator3 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            caseCodeLabel = new DevComponents.DotNetBar.LabelX();
            sellerClientLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            buyerClientEDICodeLabel = new DevComponents.DotNetBar.LabelX();
            transactionTypeLabel = new DevComponents.DotNetBar.LabelX();
            invoiceCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            creditCoverCurrLabel = new DevComponents.DotNetBar.LabelX();
            pUGProportionLabel = new DevComponents.DotNetBar.LabelX();
            creditCoverPeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            pUGPeriodLabel = new DevComponents.DotNetBar.LabelX();
            reassignGracePeriodLabel = new DevComponents.DotNetBar.LabelX();
            financeLineCurrLabel = new DevComponents.DotNetBar.LabelX();
            financeLinePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            lblHighestFinance = new DevComponents.DotNetBar.LabelX();
            financeProportionLabel = new DevComponents.DotNetBar.LabelX();
            orderNumberLabel = new DevComponents.DotNetBar.LabelX();
            paymentTermsLabel = new DevComponents.DotNetBar.LabelX();
            financeGracePeriodLabel = new DevComponents.DotNetBar.LabelX();
            deductiblesLabel = new DevComponents.DotNetBar.LabelX();
            lossThresholdLabel = new DevComponents.DotNetBar.LabelX();
            priceLabel = new DevComponents.DotNetBar.LabelX();
            iFPriceLabel = new DevComponents.DotNetBar.LabelX();
            commissonTypeLabel = new DevComponents.DotNetBar.LabelX();
            commissionTypeCommentLabel = new DevComponents.DotNetBar.LabelX();
            handFeeLabel = new DevComponents.DotNetBar.LabelX();
            noticePersonLabel = new DevComponents.DotNetBar.LabelX();
            emailLabel = new DevComponents.DotNetBar.LabelX();
            faxLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            cDASignDateLabel = new DevComponents.DotNetBar.LabelX();
            cDAStatusLabel = new DevComponents.DotNetBar.LabelX();
            noticeMethodLabel = new DevComponents.DotNetBar.LabelX();
            contractCodeLabel = new DevComponents.DotNetBar.LabelX();
            lblCDACode = new DevComponents.DotNetBar.LabelX();
            assignTypeLabel = new DevComponents.DotNetBar.LabelX();
            lblIsNotice = new DevComponents.DotNetBar.LabelX();
            lblRemark = new DevComponents.DotNetBar.LabelX();
            this.groupPanelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDABindingSource)).BeginInit();
            this.groupPanelCreditCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financeLinePeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeLinePeriodBeginDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverPeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverPeriodBeginDateTimePicker)).BeginInit();
            this.groupPanelOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDASignDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // caseCodeLabel
            // 
            caseCodeLabel.AutoSize = true;
            caseCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            caseCodeLabel.BackgroundStyle.Class = "";
            caseCodeLabel.Location = new System.Drawing.Point(3, 6);
            caseCodeLabel.Name = "caseCodeLabel";
            caseCodeLabel.Size = new System.Drawing.Size(59, 16);
            caseCodeLabel.TabIndex = 0;
            caseCodeLabel.Text = "案件编号:";
            // 
            // sellerClientLabel
            // 
            sellerClientLabel.AutoSize = true;
            sellerClientLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            sellerClientLabel.BackgroundStyle.Class = "";
            sellerClientLabel.Location = new System.Drawing.Point(15, 26);
            sellerClientLabel.Name = "sellerClientLabel";
            sellerClientLabel.Size = new System.Drawing.Size(34, 16);
            sellerClientLabel.TabIndex = 8;
            sellerClientLabel.Text = "卖方:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            factorCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Location = new System.Drawing.Point(355, 26);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            factorCodeLabel.TabIndex = 12;
            factorCodeLabel.Text = "保理商:";
            // 
            // buyerClientEDICodeLabel
            // 
            buyerClientEDICodeLabel.AutoSize = true;
            buyerClientEDICodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            buyerClientEDICodeLabel.BackgroundStyle.Class = "";
            buyerClientEDICodeLabel.Location = new System.Drawing.Point(15, 69);
            buyerClientEDICodeLabel.Name = "buyerClientEDICodeLabel";
            buyerClientEDICodeLabel.Size = new System.Drawing.Size(34, 16);
            buyerClientEDICodeLabel.TabIndex = 16;
            buyerClientEDICodeLabel.Text = "买方:";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            transactionTypeLabel.BackgroundStyle.Class = "";
            transactionTypeLabel.Location = new System.Drawing.Point(177, 6);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new System.Drawing.Size(59, 16);
            transactionTypeLabel.TabIndex = 2;
            transactionTypeLabel.Text = "业务类别:";
            // 
            // invoiceCurrencyLabel
            // 
            invoiceCurrencyLabel.AutoSize = true;
            invoiceCurrencyLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceCurrencyLabel.BackgroundStyle.Class = "";
            invoiceCurrencyLabel.Location = new System.Drawing.Point(353, 4);
            invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            invoiceCurrencyLabel.Size = new System.Drawing.Size(59, 16);
            invoiceCurrencyLabel.TabIndex = 4;
            invoiceCurrencyLabel.Text = "发票币别:";
            // 
            // creditCoverCurrLabel
            // 
            creditCoverCurrLabel.AutoSize = true;
            creditCoverCurrLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditCoverCurrLabel.BackgroundStyle.Class = "";
            creditCoverCurrLabel.Location = new System.Drawing.Point(9, 26);
            creditCoverCurrLabel.Name = "creditCoverCurrLabel";
            creditCoverCurrLabel.Size = new System.Drawing.Size(84, 16);
            creditCoverCurrLabel.TabIndex = 7;
            creditCoverCurrLabel.Text = "买方风险额度:";
            // 
            // pUGProportionLabel
            // 
            pUGProportionLabel.AutoSize = true;
            pUGProportionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            pUGProportionLabel.BackgroundStyle.Class = "";
            pUGProportionLabel.Location = new System.Drawing.Point(34, 48);
            pUGProportionLabel.Name = "pUGProportionLabel";
            pUGProportionLabel.Size = new System.Drawing.Size(59, 16);
            pUGProportionLabel.TabIndex = 14;
            pUGProportionLabel.Text = "担保比例:";
            // 
            // creditCoverPeriodBeginLabel
            // 
            creditCoverPeriodBeginLabel.AutoSize = true;
            creditCoverPeriodBeginLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditCoverPeriodBeginLabel.BackgroundStyle.Class = "";
            creditCoverPeriodBeginLabel.Location = new System.Drawing.Point(286, 24);
            creditCoverPeriodBeginLabel.Name = "creditCoverPeriodBeginLabel";
            creditCoverPeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            creditCoverPeriodBeginLabel.TabIndex = 10;
            creditCoverPeriodBeginLabel.Text = "有效期限:";
            // 
            // pUGPeriodLabel
            // 
            pUGPeriodLabel.AutoSize = true;
            pUGPeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            pUGPeriodLabel.BackgroundStyle.Class = "";
            pUGPeriodLabel.Location = new System.Drawing.Point(261, 48);
            pUGPeriodLabel.Name = "pUGPeriodLabel";
            pUGPeriodLabel.Size = new System.Drawing.Size(84, 16);
            pUGPeriodLabel.TabIndex = 16;
            pUGPeriodLabel.Text = "担保付款期限:";
            // 
            // reassignGracePeriodLabel
            // 
            reassignGracePeriodLabel.AutoSize = true;
            reassignGracePeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            reassignGracePeriodLabel.BackgroundStyle.Class = "";
            reassignGracePeriodLabel.Location = new System.Drawing.Point(514, 48);
            reassignGracePeriodLabel.Name = "reassignGracePeriodLabel";
            reassignGracePeriodLabel.Size = new System.Drawing.Size(72, 16);
            reassignGracePeriodLabel.TabIndex = 18;
            reassignGracePeriodLabel.Text = "回购宽限期:";
            // 
            // financeLineCurrLabel
            // 
            financeLineCurrLabel.AutoSize = true;
            financeLineCurrLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeLineCurrLabel.BackgroundStyle.Class = "";
            financeLineCurrLabel.Location = new System.Drawing.Point(21, 70);
            financeLineCurrLabel.Name = "financeLineCurrLabel";
            financeLineCurrLabel.Size = new System.Drawing.Size(72, 16);
            financeLineCurrLabel.TabIndex = 20;
            financeLineCurrLabel.Text = "预付款额度:";
            // 
            // financeLinePeriodBeginLabel
            // 
            financeLinePeriodBeginLabel.AutoSize = true;
            financeLinePeriodBeginLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeLinePeriodBeginLabel.BackgroundStyle.Class = "";
            financeLinePeriodBeginLabel.Location = new System.Drawing.Point(286, 69);
            financeLinePeriodBeginLabel.Name = "financeLinePeriodBeginLabel";
            financeLinePeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            financeLinePeriodBeginLabel.TabIndex = 23;
            financeLinePeriodBeginLabel.Text = "有效期限:";
            // 
            // lblHighestFinance
            // 
            lblHighestFinance.AutoSize = true;
            lblHighestFinance.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblHighestFinance.BackgroundStyle.Class = "";
            lblHighestFinance.Location = new System.Drawing.Point(4, 95);
            lblHighestFinance.Name = "lblHighestFinance";
            lblHighestFinance.Size = new System.Drawing.Size(121, 16);
            lblHighestFinance.TabIndex = 26;
            lblHighestFinance.Text = "最高保理预付款额度:";
            // 
            // financeProportionLabel
            // 
            financeProportionLabel.AutoSize = true;
            financeProportionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeProportionLabel.BackgroundStyle.Class = "";
            financeProportionLabel.Location = new System.Drawing.Point(286, 92);
            financeProportionLabel.Name = "financeProportionLabel";
            financeProportionLabel.Size = new System.Drawing.Size(59, 16);
            financeProportionLabel.TabIndex = 28;
            financeProportionLabel.Text = "预付比例:";
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            orderNumberLabel.BackgroundStyle.Class = "";
            orderNumberLabel.Location = new System.Drawing.Point(122, 162);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new System.Drawing.Size(47, 16);
            orderNumberLabel.TabIndex = 34;
            orderNumberLabel.Text = "订单号:";
            // 
            // paymentTermsLabel
            // 
            paymentTermsLabel.AutoSize = true;
            paymentTermsLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentTermsLabel.BackgroundStyle.Class = "";
            paymentTermsLabel.Location = new System.Drawing.Point(28, 117);
            paymentTermsLabel.Name = "paymentTermsLabel";
            paymentTermsLabel.Size = new System.Drawing.Size(59, 16);
            paymentTermsLabel.TabIndex = 32;
            paymentTermsLabel.Text = "付款条件:";
            // 
            // financeGracePeriodLabel
            // 
            financeGracePeriodLabel.AutoSize = true;
            financeGracePeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeGracePeriodLabel.BackgroundStyle.Class = "";
            financeGracePeriodLabel.Location = new System.Drawing.Point(514, 94);
            financeGracePeriodLabel.Name = "financeGracePeriodLabel";
            financeGracePeriodLabel.Size = new System.Drawing.Size(72, 16);
            financeGracePeriodLabel.TabIndex = 30;
            financeGracePeriodLabel.Text = "融资宽限期:";
            // 
            // deductiblesLabel
            // 
            deductiblesLabel.AutoSize = true;
            deductiblesLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            deductiblesLabel.BackgroundStyle.Class = "";
            deductiblesLabel.Location = new System.Drawing.Point(295, 162);
            deductiblesLabel.Name = "deductiblesLabel";
            deductiblesLabel.Size = new System.Drawing.Size(47, 16);
            deductiblesLabel.TabIndex = 36;
            deductiblesLabel.Text = "自负额:";
            // 
            // lossThresholdLabel
            // 
            lossThresholdLabel.AutoSize = true;
            lossThresholdLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lossThresholdLabel.BackgroundStyle.Class = "";
            lossThresholdLabel.Location = new System.Drawing.Point(502, 159);
            lossThresholdLabel.Name = "lossThresholdLabel";
            lossThresholdLabel.Size = new System.Drawing.Size(84, 16);
            lossThresholdLabel.TabIndex = 38;
            lossThresholdLabel.Text = "最低损失门槛:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            priceLabel.BackgroundStyle.Class = "";
            priceLabel.Location = new System.Drawing.Point(15, 183);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(72, 16);
            priceLabel.TabIndex = 40;
            priceLabel.Text = "总手续费率:";
            // 
            // iFPriceLabel
            // 
            iFPriceLabel.AutoSize = true;
            iFPriceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            iFPriceLabel.BackgroundStyle.Class = "";
            iFPriceLabel.Location = new System.Drawing.Point(272, 181);
            iFPriceLabel.Name = "iFPriceLabel";
            iFPriceLabel.Size = new System.Drawing.Size(69, 16);
            iFPriceLabel.TabIndex = 42;
            iFPriceLabel.Text = "IF手续费率:";
            // 
            // commissonTypeLabel
            // 
            commissonTypeLabel.AutoSize = true;
            commissonTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commissonTypeLabel.BackgroundStyle.Class = "";
            commissonTypeLabel.Location = new System.Drawing.Point(28, 202);
            commissonTypeLabel.Name = "commissonTypeLabel";
            commissonTypeLabel.Size = new System.Drawing.Size(59, 16);
            commissonTypeLabel.TabIndex = 49;
            commissonTypeLabel.Text = "计费方式:";
            // 
            // commissionTypeCommentLabel
            // 
            commissionTypeCommentLabel.AutoSize = true;
            commissionTypeCommentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commissionTypeCommentLabel.BackgroundStyle.Class = "";
            commissionTypeCommentLabel.Location = new System.Drawing.Point(242, 203);
            commissionTypeCommentLabel.Name = "commissionTypeCommentLabel";
            commissionTypeCommentLabel.Size = new System.Drawing.Size(34, 16);
            commissionTypeCommentLabel.TabIndex = 51;
            commissionTypeCommentLabel.Text = "说明:";
            // 
            // handFeeLabel
            // 
            handFeeLabel.AutoSize = true;
            handFeeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            handFeeLabel.BackgroundStyle.Class = "";
            handFeeLabel.Location = new System.Drawing.Point(482, 180);
            handFeeLabel.Name = "handFeeLabel";
            handFeeLabel.Size = new System.Drawing.Size(72, 16);
            handFeeLabel.TabIndex = 46;
            handFeeLabel.Text = "单据处理费:";
            // 
            // noticePersonLabel
            // 
            noticePersonLabel.AutoSize = true;
            noticePersonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            noticePersonLabel.BackgroundStyle.Class = "";
            noticePersonLabel.Location = new System.Drawing.Point(40, 25);
            noticePersonLabel.Name = "noticePersonLabel";
            noticePersonLabel.Size = new System.Drawing.Size(47, 16);
            noticePersonLabel.TabIndex = 7;
            noticePersonLabel.Text = "通知人:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            emailLabel.BackgroundStyle.Class = "";
            emailLabel.Location = new System.Drawing.Point(476, 5);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(63, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email地址:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            faxLabel.BackgroundStyle.Class = "";
            faxLabel.Location = new System.Drawing.Point(476, 27);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(59, 16);
            faxLabel.TabIndex = 11;
            faxLabel.Text = "传真号码:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(50, 51);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 13;
            commentLabel.Text = "备注:";
            // 
            // createUserNameLabel
            // 
            createUserNameLabel.AutoSize = true;
            createUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            createUserNameLabel.BackgroundStyle.Class = "";
            createUserNameLabel.Location = new System.Drawing.Point(552, 51);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            createUserNameLabel.TabIndex = 15;
            createUserNameLabel.Text = "经办人:";
            // 
            // cDASignDateLabel
            // 
            cDASignDateLabel.AutoSize = true;
            cDASignDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            cDASignDateLabel.BackgroundStyle.Class = "";
            cDASignDateLabel.Location = new System.Drawing.Point(42, 3);
            cDASignDateLabel.Name = "cDASignDateLabel";
            cDASignDateLabel.Size = new System.Drawing.Size(47, 16);
            cDASignDateLabel.TabIndex = 0;
            cDASignDateLabel.Text = "签发日:";
            // 
            // cDAStatusLabel
            // 
            cDAStatusLabel.AutoSize = true;
            cDAStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            cDAStatusLabel.BackgroundStyle.Class = "";
            cDAStatusLabel.Location = new System.Drawing.Point(259, 5);
            cDAStatusLabel.Name = "cDAStatusLabel";
            cDAStatusLabel.Size = new System.Drawing.Size(59, 16);
            cDAStatusLabel.TabIndex = 2;
            cDAStatusLabel.Text = "合同状态:";
            // 
            // noticeMethodLabel
            // 
            noticeMethodLabel.AutoSize = true;
            noticeMethodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            noticeMethodLabel.BackgroundStyle.Class = "";
            noticeMethodLabel.Location = new System.Drawing.Point(259, 25);
            noticeMethodLabel.Name = "noticeMethodLabel";
            noticeMethodLabel.Size = new System.Drawing.Size(59, 16);
            noticeMethodLabel.TabIndex = 4;
            noticeMethodLabel.Text = "通知方式:";
            // 
            // contractCodeLabel
            // 
            contractCodeLabel.AutoSize = true;
            contractCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            contractCodeLabel.BackgroundStyle.Class = "";
            contractCodeLabel.Location = new System.Drawing.Point(367, 66);
            contractCodeLabel.Name = "contractCodeLabel";
            contractCodeLabel.Size = new System.Drawing.Size(84, 16);
            contractCodeLabel.TabIndex = 6;
            contractCodeLabel.Text = "保理合同编号:";
            // 
            // lblCDACode
            // 
            lblCDACode.AutoSize = true;
            lblCDACode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCDACode.BackgroundStyle.Class = "";
            lblCDACode.Location = new System.Drawing.Point(36, 3);
            lblCDACode.Name = "lblCDACode";
            lblCDACode.Size = new System.Drawing.Size(58, 16);
            lblCDACode.TabIndex = 0;
            lblCDACode.Text = "CDA编号:";
            // 
            // assignTypeLabel
            // 
            assignTypeLabel.AutoSize = true;
            assignTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignTypeLabel.BackgroundStyle.Class = "";
            assignTypeLabel.Location = new System.Drawing.Point(565, 3);
            assignTypeLabel.Name = "assignTypeLabel";
            assignTypeLabel.Size = new System.Drawing.Size(59, 16);
            assignTypeLabel.TabIndex = 2;
            assignTypeLabel.Text = "转让方式:";
            // 
            // lblIsNotice
            // 
            lblIsNotice.AutoSize = true;
            lblIsNotice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblIsNotice.BackgroundStyle.Class = "";
            lblIsNotice.Location = new System.Drawing.Point(286, 3);
            lblIsNotice.Name = "lblIsNotice";
            lblIsNotice.Size = new System.Drawing.Size(62, 16);
            lblIsNotice.TabIndex = 4;
            lblIsNotice.Text = "明/暗保理:";
            // 
            // lblRemark
            // 
            lblRemark.AutoSize = true;
            lblRemark.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRemark.BackgroundStyle.Class = "";
            lblRemark.Location = new System.Drawing.Point(0, 86);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new System.Drawing.Size(84, 16);
            lblRemark.TabIndex = 17;
            lblRemark.Text = "内部提示信息:";
            // 
            // groupPanelCase
            // 
            this.groupPanelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCase.Controls.Add(this.invoiceCurrencyTextBox);
            this.groupPanelCase.Controls.Add(this.transactionTypeTextBox);
            this.groupPanelCase.Controls.Add(this.companyNameENTextBox);
            this.groupPanelCase.Controls.Add(contractCodeLabel);
            this.groupPanelCase.Controls.Add(this.contractCodeTextBox);
            this.groupPanelCase.Controls.Add(this.btnCaseSelect);
            this.groupPanelCase.Controls.Add(invoiceCurrencyLabel);
            this.groupPanelCase.Controls.Add(transactionTypeLabel);
            this.groupPanelCase.Controls.Add(this.buyerClientNameENTextBox);
            this.groupPanelCase.Controls.Add(this.buyerClientNameCNTextBox);
            this.groupPanelCase.Controls.Add(buyerClientEDICodeLabel);
            this.groupPanelCase.Controls.Add(this.buyerClientEDICodeTextBox);
            this.groupPanelCase.Controls.Add(this.sellerClientNameENTextBox);
            this.groupPanelCase.Controls.Add(this.companyNameCNTextBox);
            this.groupPanelCase.Controls.Add(factorCodeLabel);
            this.groupPanelCase.Controls.Add(this.factorCodeTextBox);
            this.groupPanelCase.Controls.Add(this.sellerClientNameCNTextBox);
            this.groupPanelCase.Controls.Add(sellerClientLabel);
            this.groupPanelCase.Controls.Add(this.sellerClientEDICodeTextBox);
            this.groupPanelCase.Controls.Add(caseCodeLabel);
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
            // 
            // 
            // 
            this.groupPanelCase.StyleMouseOver.Class = "";
            this.groupPanelCase.TabIndex = 0;
            // 
            // invoiceCurrencyTextBox
            // 
            // 
            // 
            // 
            this.invoiceCurrencyTextBox.Border.Class = "TextBoxBorder";
            this.invoiceCurrencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Case.InvoiceCurrency", true));
            this.invoiceCurrencyTextBox.Location = new System.Drawing.Point(429, 1);
            this.invoiceCurrencyTextBox.Name = "invoiceCurrencyTextBox";
            this.invoiceCurrencyTextBox.Size = new System.Drawing.Size(85, 20);
            this.invoiceCurrencyTextBox.TabIndex = 5;
            // 
            // CDABindingSource
            // 
            this.CDABindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CDA);
            // 
            // transactionTypeTextBox
            // 
            // 
            // 
            // 
            this.transactionTypeTextBox.Border.Class = "TextBoxBorder";
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
            this.contractCodeTextBox.Location = new System.Drawing.Point(456, 65);
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
            this.groupPanelCreditCover.Controls.Add(lblIsNotice);
            this.groupPanelCreditCover.Controls.Add(this.cbIsNotice);
            this.groupPanelCreditCover.Controls.Add(this.cbIsRecoarse);
            this.groupPanelCreditCover.Controls.Add(assignTypeLabel);
            this.groupPanelCreditCover.Controls.Add(this.assignTypeComboBox);
            this.groupPanelCreditCover.Controls.Add(lblCDACode);
            this.groupPanelCreditCover.Controls.Add(this.tbCDACode);
            this.groupPanelCreditCover.Controls.Add(this.tbHighestFinance);
            this.groupPanelCreditCover.Controls.Add(this.handFeeCurrComboBox);
            this.groupPanelCreditCover.Controls.Add(this.cbIsCreditCoverRevolving);
            this.groupPanelCreditCover.Controls.Add(handFeeLabel);
            this.groupPanelCreditCover.Controls.Add(lossThresholdLabel);
            this.groupPanelCreditCover.Controls.Add(this.handFeeTextBox);
            this.groupPanelCreditCover.Controls.Add(this.lossThresholdTextBox);
            this.groupPanelCreditCover.Controls.Add(commissionTypeCommentLabel);
            this.groupPanelCreditCover.Controls.Add(deductiblesLabel);
            this.groupPanelCreditCover.Controls.Add(this.commissionTypeCommentTextBox);
            this.groupPanelCreditCover.Controls.Add(this.deductiblesTextBox);
            this.groupPanelCreditCover.Controls.Add(commissonTypeLabel);
            this.groupPanelCreditCover.Controls.Add(financeGracePeriodLabel);
            this.groupPanelCreditCover.Controls.Add(this.commissionTypeComboBox);
            this.groupPanelCreditCover.Controls.Add(this.financeGracePeriodTextBox);
            this.groupPanelCreditCover.Controls.Add(paymentTermsLabel);
            this.groupPanelCreditCover.Controls.Add(this.paymentTermsTextBox);
            this.groupPanelCreditCover.Controls.Add(iFPriceLabel);
            this.groupPanelCreditCover.Controls.Add(orderNumberLabel);
            this.groupPanelCreditCover.Controls.Add(this.iFPriceTextBox);
            this.groupPanelCreditCover.Controls.Add(this.orderNumberTextBox);
            this.groupPanelCreditCover.Controls.Add(priceLabel);
            this.groupPanelCreditCover.Controls.Add(this.priceTextBox);
            this.groupPanelCreditCover.Controls.Add(financeProportionLabel);
            this.groupPanelCreditCover.Controls.Add(this.financeProportionTextBox);
            this.groupPanelCreditCover.Controls.Add(lblHighestFinance);
            this.groupPanelCreditCover.Controls.Add(this.financeLinePeriodEndDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(financeLinePeriodBeginLabel);
            this.groupPanelCreditCover.Controls.Add(this.financeLinePeriodBeginDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(this.financeLineTextBox);
            this.groupPanelCreditCover.Controls.Add(financeLineCurrLabel);
            this.groupPanelCreditCover.Controls.Add(this.financeLineCurrComboBox);
            this.groupPanelCreditCover.Controls.Add(reassignGracePeriodLabel);
            this.groupPanelCreditCover.Controls.Add(this.reassignGracePeriodTextBox);
            this.groupPanelCreditCover.Controls.Add(pUGPeriodLabel);
            this.groupPanelCreditCover.Controls.Add(this.pUGPeriodTextBox);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverPeriodEndDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(creditCoverPeriodBeginLabel);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverPeriodBeginDateTimePicker);
            this.groupPanelCreditCover.Controls.Add(pUGProportionLabel);
            this.groupPanelCreditCover.Controls.Add(this.pUGProportionTextBox);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverTextBox);
            this.groupPanelCreditCover.Controls.Add(creditCoverCurrLabel);
            this.groupPanelCreditCover.Controls.Add(this.creditCoverCurrComboBox);
            this.groupPanelCreditCover.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditCover.Location = new System.Drawing.Point(0, 115);
            this.groupPanelCreditCover.Name = "groupPanelCreditCover";
            this.groupPanelCreditCover.Size = new System.Drawing.Size(745, 230);
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
            this.groupPanelCreditCover.TabIndex = 1;
            // 
            // cbIsNotice
            // 
            this.cbIsNotice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "IsNotice", true));
            this.cbIsNotice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsNotice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbIsRecoarse.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CDABindingSource, "IsRecoarse", true));
            this.cbIsRecoarse.Location = new System.Drawing.Point(458, 3);
            this.cbIsRecoarse.Name = "cbIsRecoarse";
            this.cbIsRecoarse.Size = new System.Drawing.Size(101, 16);
            this.cbIsRecoarse.TabIndex = 6;
            this.cbIsRecoarse.Text = "是否有追索权";
            // 
            // assignTypeComboBox
            // 
            this.assignTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "AssignType", true));
            this.assignTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.assignTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.tbCDACode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CDACode", true));
            this.tbCDACode.Location = new System.Drawing.Point(105, 2);
            this.tbCDACode.Name = "tbCDACode";
            this.tbCDACode.ReadOnly = true;
            this.tbCDACode.Size = new System.Drawing.Size(150, 20);
            this.tbCDACode.TabIndex = 1;
            // 
            // tbHighestFinance
            // 
            // 
            // 
            // 
            this.tbHighestFinance.Border.Class = "TextBoxBorder";
            this.tbHighestFinance.Location = new System.Drawing.Point(131, 91);
            this.tbHighestFinance.Name = "tbHighestFinance";
            this.tbHighestFinance.Size = new System.Drawing.Size(100, 20);
            this.tbHighestFinance.TabIndex = 27;
            // 
            // handFeeCurrComboBox
            // 
            this.handFeeCurrComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "HandFeeCurr", true));
            this.handFeeCurrComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.handFeeCurrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.handFeeCurrComboBox.FormattingEnabled = true;
            this.handFeeCurrComboBox.Location = new System.Drawing.Point(560, 180);
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
            this.cbIsCreditCoverRevolving.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CDABindingSource, "IsCreditCoverRevolving", true));
            this.cbIsCreditCoverRevolving.Location = new System.Drawing.Point(9, 162);
            this.cbIsCreditCoverRevolving.Name = "cbIsCreditCoverRevolving";
            this.cbIsCreditCoverRevolving.Size = new System.Drawing.Size(101, 16);
            this.cbIsCreditCoverRevolving.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsCreditCoverRevolving.TabIndex = 13;
            this.cbIsCreditCoverRevolving.Text = "是否循环额度";
            // 
            // handFeeTextBox
            // 
            // 
            // 
            // 
            this.handFeeTextBox.Border.Class = "TextBoxBorder";
            this.handFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "HandFee", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.handFeeTextBox.Location = new System.Drawing.Point(618, 180);
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
            this.lossThresholdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "LossThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lossThresholdTextBox.Location = new System.Drawing.Point(599, 158);
            this.lossThresholdTextBox.Name = "lossThresholdTextBox";
            this.lossThresholdTextBox.Size = new System.Drawing.Size(100, 20);
            this.lossThresholdTextBox.TabIndex = 39;
            // 
            // commissionTypeCommentTextBox
            // 
            // 
            // 
            // 
            this.commissionTypeCommentTextBox.Border.Class = "TextBoxBorder";
            this.commissionTypeCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CommissionTypeComment", true));
            this.commissionTypeCommentTextBox.Location = new System.Drawing.Point(284, 201);
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
            this.deductiblesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Deductibles", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.deductiblesTextBox.Location = new System.Drawing.Point(355, 158);
            this.deductiblesTextBox.Name = "deductiblesTextBox";
            this.deductiblesTextBox.Size = new System.Drawing.Size(100, 20);
            this.deductiblesTextBox.TabIndex = 37;
            // 
            // commissionTypeComboBox
            // 
            this.commissionTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CommissionType", true));
            this.commissionTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.commissionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commissionTypeComboBox.FormattingEnabled = true;
            this.commissionTypeComboBox.Location = new System.Drawing.Point(105, 201);
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
            this.paymentTermsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "PaymentTerms", true));
            this.paymentTermsTextBox.Location = new System.Drawing.Point(105, 113);
            this.paymentTermsTextBox.Multiline = true;
            this.paymentTermsTextBox.Name = "paymentTermsTextBox";
            this.paymentTermsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.paymentTermsTextBox.Size = new System.Drawing.Size(594, 43);
            this.paymentTermsTextBox.TabIndex = 33;
            this.superValidator.SetValidator1(this.paymentTermsTextBox, this.requiredFieldValidator1);
            // 
            // iFPriceTextBox
            // 
            // 
            // 
            // 
            this.iFPriceTextBox.Border.Class = "TextBoxBorder";
            this.iFPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "IFPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p2"));
            this.iFPriceTextBox.Location = new System.Drawing.Point(355, 180);
            this.iFPriceTextBox.Name = "iFPriceTextBox";
            this.iFPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.iFPriceTextBox.TabIndex = 43;
            // 
            // orderNumberTextBox
            // 
            // 
            // 
            // 
            this.orderNumberTextBox.Border.Class = "TextBoxBorder";
            this.orderNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "OrderNumber", true));
            this.orderNumberTextBox.Location = new System.Drawing.Point(175, 158);
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
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p2"));
            this.priceTextBox.Location = new System.Drawing.Point(105, 180);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 41;
            // 
            // financeProportionTextBox
            // 
            // 
            // 
            // 
            this.financeProportionTextBox.Border.Class = "TextBoxBorder";
            this.financeProportionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "FinanceProportion", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p0"));
            this.financeProportionTextBox.Location = new System.Drawing.Point(355, 90);
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
            // 
            // 
            // 
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeLinePeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
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
            this.financeLinePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financeLinePeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.financeLinePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "FinanceLinePeriodBegin", true));
            this.financeLinePeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.financeLinePeriodBeginDateTimePicker.Location = new System.Drawing.Point(355, 68);
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeLinePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
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
            this.financeLineCurrComboBox.FormattingEnabled = true;
            this.financeLineCurrComboBox.Location = new System.Drawing.Point(105, 68);
            this.financeLineCurrComboBox.Name = "financeLineCurrComboBox";
            this.financeLineCurrComboBox.Size = new System.Drawing.Size(64, 21);
            this.financeLineCurrComboBox.TabIndex = 21;
            this.financeLineCurrComboBox.WatermarkText = "币别";
            // 
            // reassignGracePeriodTextBox
            // 
            // 
            // 
            // 
            this.reassignGracePeriodTextBox.Border.Class = "TextBoxBorder";
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
            this.pUGPeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "PUGPeriod", true));
            this.pUGPeriodTextBox.Location = new System.Drawing.Point(355, 47);
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
            // 
            // 
            // 
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.creditCoverPeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
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
            this.creditCoverPeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.creditCoverPeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.creditCoverPeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "CreditCoverPeriodBegin", true));
            this.creditCoverPeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.creditCoverPeriodBeginDateTimePicker.Location = new System.Drawing.Point(356, 25);
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.creditCoverPeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
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
            this.pUGProportionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "PUGProportion", true));
            this.pUGProportionTextBox.Location = new System.Drawing.Point(105, 47);
            this.pUGProportionTextBox.Name = "pUGProportionTextBox";
            this.pUGProportionTextBox.Size = new System.Drawing.Size(100, 20);
            this.pUGProportionTextBox.TabIndex = 15;
            // 
            // creditCoverTextBox
            // 
            // 
            // 
            // 
            this.creditCoverTextBox.Border.Class = "TextBoxBorder";
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
            this.creditCoverCurrComboBox.FormattingEnabled = true;
            this.creditCoverCurrComboBox.Location = new System.Drawing.Point(105, 24);
            this.creditCoverCurrComboBox.Name = "creditCoverCurrComboBox";
            this.creditCoverCurrComboBox.Size = new System.Drawing.Size(64, 21);
            this.creditCoverCurrComboBox.TabIndex = 8;
            this.creditCoverCurrComboBox.WatermarkText = "币别";
            // 
            // groupPanelOther
            // 
            this.groupPanelOther.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelOther.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelOther.Controls.Add(lblRemark);
            this.groupPanelOther.Controls.Add(this.tbRemark);
            this.groupPanelOther.Controls.Add(this.cbNoticeMethodFax);
            this.groupPanelOther.Controls.Add(this.cbNoticeMethodEmail);
            this.groupPanelOther.Controls.Add(noticeMethodLabel);
            this.groupPanelOther.Controls.Add(cDAStatusLabel);
            this.groupPanelOther.Controls.Add(this.cDAStatusComboBox);
            this.groupPanelOther.Controls.Add(cDASignDateLabel);
            this.groupPanelOther.Controls.Add(this.cDASignDateDateTimePicker);
            this.groupPanelOther.Controls.Add(createUserNameLabel);
            this.groupPanelOther.Controls.Add(this.createUserNameTextBox);
            this.groupPanelOther.Controls.Add(commentLabel);
            this.groupPanelOther.Controls.Add(this.commentTextBox);
            this.groupPanelOther.Controls.Add(faxLabel);
            this.groupPanelOther.Controls.Add(this.faxTextBox);
            this.groupPanelOther.Controls.Add(emailLabel);
            this.groupPanelOther.Controls.Add(this.emailTextBox);
            this.groupPanelOther.Controls.Add(noticePersonLabel);
            this.groupPanelOther.Controls.Add(this.noticePersonTextBox);
            this.groupPanelOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelOther.Location = new System.Drawing.Point(0, 345);
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
            // 
            // 
            // 
            this.groupPanelOther.StyleMouseOver.Class = "";
            this.groupPanelOther.TabIndex = 2;
            // 
            // tbRemark
            // 
            // 
            // 
            // 
            this.tbRemark.Border.Class = "TextBoxBorder";
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
            this.cbNoticeMethodFax.Location = new System.Drawing.Point(373, 27);
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
            this.cbNoticeMethodEmail.Location = new System.Drawing.Point(324, 27);
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
            this.cDAStatusComboBox.FormattingEnabled = true;
            this.cDAStatusComboBox.Location = new System.Drawing.Point(324, 3);
            this.cDAStatusComboBox.Name = "cDAStatusComboBox";
            this.cDAStatusComboBox.Size = new System.Drawing.Size(106, 21);
            this.cDAStatusComboBox.TabIndex = 3;
            // 
            // cDASignDateDateTimePicker
            // 
            // 
            // 
            // 
            this.cDASignDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cDASignDateDateTimePicker.ButtonDropDown.Visible = true;
            this.cDASignDateDateTimePicker.ButtonFreeText.Checked = true;
            this.cDASignDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CDABindingSource, "CDASignDate", true));
            this.cDASignDateDateTimePicker.FreeTextEntryMode = true;
            this.cDASignDateDateTimePicker.Location = new System.Drawing.Point(105, 1);
            // 
            // 
            // 
            this.cDASignDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cDASignDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cDASignDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.cDASignDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cDASignDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.cDASignDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cDASignDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cDASignDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cDASignDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cDASignDateDateTimePicker.Name = "cDASignDateDateTimePicker";
            this.cDASignDateDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.cDASignDateDateTimePicker.TabIndex = 1;
            // 
            // createUserNameTextBox
            // 
            // 
            // 
            // 
            this.createUserNameTextBox.Border.Class = "TextBoxBorder";
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(599, 49);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.createUserNameTextBox.TabIndex = 16;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
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
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(545, 25);
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
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(545, 2);
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
            this.noticePersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CDABindingSource, "NoticePerson", true));
            this.noticePersonTextBox.Location = new System.Drawing.Point(105, 23);
            this.noticePersonTextBox.Name = "noticePersonTextBox";
            this.noticePersonTextBox.Size = new System.Drawing.Size(100, 20);
            this.noticePersonTextBox.TabIndex = 8;
            // 
            // btnCDAUpdate
            // 
            this.btnCDAUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDAUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDAUpdate.Location = new System.Drawing.Point(218, 480);
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
            this.btnCDASave.Location = new System.Drawing.Point(299, 480);
            this.btnCDASave.Name = "btnCDASave";
            this.btnCDASave.Size = new System.Drawing.Size(75, 23);
            this.btnCDASave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDASave.TabIndex = 4;
            this.btnCDASave.Text = "保存";
            this.btnCDASave.Click += new System.EventHandler(this.SaveCDA);
            // 
            // btnCDAReset
            // 
            this.btnCDAReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDAReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDAReset.Location = new System.Drawing.Point(383, 480);
            this.btnCDAReset.Name = "btnCDAReset";
            this.btnCDAReset.Size = new System.Drawing.Size(75, 23);
            this.btnCDAReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDAReset.TabIndex = 5;
            this.btnCDAReset.Text = "重置";
            this.btnCDAReset.Click += new System.EventHandler(this.ResetCDA);
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "必填";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator1_ValidateValue);
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
            this.customValidator6.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator6_ValidateValue);
            // 
            // customValidator4
            // 
            this.customValidator4.ErrorMessage = "预付款额度不能大于客户的融资额度上限";
            this.customValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator4.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator4_ValidateValue);
            // 
            // customValidator5
            // 
            this.customValidator5.ErrorMessage = "预付款额度不能大于买方风险担保额度";
            this.customValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator5.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator5_ValidateValue);
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
            this.customValidator3.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator3_ValidateValue);
            // 
            // customValidator2
            // 
            this.customValidator2.ErrorMessage = "额度通知书中买方信用风险额度不能大于案子中买方信用风险额度";
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator2.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator2_ValidateValue);
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
            this.ClientSize = new System.Drawing.Size(745, 509);
            this.Controls.Add(this.btnCDAReset);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CDADetail_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.cDASignDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCDACode;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsRecoarse;
        private DevComponents.DotNetBar.Controls.ComboBoxEx assignTypeComboBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbIsNotice;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRemark;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator3;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator4;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator5;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator6;
    }
}