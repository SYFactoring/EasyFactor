//-----------------------------------------------------------------------
// <copyright file="ClientDetail.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// Client Detail Designer
    /// </summary>
    public partial class ClientDetail
    {
		#region?Fields?(204)?

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX addressCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX addressENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX approveNoTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx approveTypeComboBox;
        private DevComponents.DotNetBar.ButtonX btnClientCreditLineDelete;
        private DevComponents.DotNetBar.ButtonX btnClientCreditLineFreeze;
        private DevComponents.DotNetBar.ButtonX btnClientCreditLineNew;
        private DevComponents.DotNetBar.ButtonX btnClientCreditLineRefresh;
        private DevComponents.DotNetBar.ButtonX btnClientCreditLineSave;
        private DevComponents.DotNetBar.ButtonX btnClientCreditLineUnfreeze;
        private DevComponents.DotNetBar.ButtonX btnClientCreditLineUpdate;
        private DevComponents.DotNetBar.ButtonX btnClientSave;
        private DevComponents.DotNetBar.ButtonX btnClientUpdate;
        private DevComponents.DotNetBar.ButtonX btnContractDelete;
        private DevComponents.DotNetBar.ButtonX btnContractNew;
        private DevComponents.DotNetBar.ButtonX btnContractRefresh;
        private DevComponents.DotNetBar.ButtonX btnContractSave;
        private DevComponents.DotNetBar.ButtonX btnContractUpdate;
        private DevComponents.DotNetBar.ButtonX btnGDDelete;
        private DevComponents.DotNetBar.ButtonX btnGDNew;
        private DevComponents.DotNetBar.ButtonX btnGDRefresh;
        private DevComponents.DotNetBar.ButtonX btnGDSave;
        private DevComponents.DotNetBar.ButtonX btnGDUpdate;
        private DevComponents.DotNetBar.ButtonX btnGroupCreditLineSelect;
        private DevComponents.DotNetBar.ButtonX btnGroupSelect;
        private DevComponents.DotNetBar.ButtonX btnReviewDelete;
        private DevComponents.DotNetBar.ButtonX btnReviewNew;
        private DevComponents.DotNetBar.ButtonX btnReviewRefresh;
        private DevComponents.DotNetBar.ButtonX btnReviewSave;
        private DevComponents.DotNetBar.ButtonX btnReviewUpdate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbContractType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCountryCode;
        private DevComponents.DotNetBar.Controls.ComboTree cbDepartments;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGDCurr;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbIndustry;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsBuyer;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsInternational;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsLocal;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsNonRecoarse;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbIsNotice;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsRecoarse;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsSeller;
        private DevComponents.DotNetBar.Controls.TextBoxX cellPhoneTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX cityCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX cityENTextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX clientCommentTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientCoreNoTextBox;
        private System.Windows.Forms.BindingSource clientCreditLineBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX clientEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx clientLevelComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameENTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx clientTypeComboBox;
        private DevComponents.DotNetBar.Validator.SuperValidator clientValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractValueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewUser;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX companyCodeTextBox;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator2;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX contactTextBox;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DevComponents.DotNetBar.Validator.SuperValidator contractValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineCommentTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditLineCurrencyComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineStatusTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditLineTypeComboBox;
        private DevComponents.DotNetBar.Validator.SuperValidator creditLineValidator;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator4;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClientCreditLines;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContracts;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGDs;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvReviews;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diContractDueDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diContractValueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX faxNumberTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput freezeDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX freezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX freezerTextBox;
        private System.Windows.Forms.BindingSource gdBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX groupNoTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientBasic;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientContact;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientCreditLine;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientGroup;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientStat;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelContract;
        private DevComponents.DotNetBar.PanelEx groupPanelGuaranteePanel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelReview;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.CheckBoxX isSignedCheckBox;
        private DevComponents.DotNetBar.TabItem itemGuaranteeDeposit;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodBeginDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX pMNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX postCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX productCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX productENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX provinceCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX provinceENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX registrationNumberTextBox;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator10;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator3;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator4;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator5;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator6;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator7;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator8;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator9;
        private DevComponents.DotNetBar.Controls.TextBoxX representativeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX requestAmountTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX requestCommissionRateTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx requestCurrencyComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX requestFinancePeriodTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx requestFinanceType2ComboBox;
        private System.Windows.Forms.CheckedListBox requestFinanceTypeCheckedListBox;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator10;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator11;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator12;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator13;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator14;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator15;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator16;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator17;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator18;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator7;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator8;
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput reviewDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX reviewNoTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx reviewStatusComboBox;
        private DevComponents.DotNetBar.Validator.SuperValidator reviewValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX rMNameTextBox;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemClient;
        private DevComponents.DotNetBar.TabItem tabItemClientCreditLine;
        private DevComponents.DotNetBar.TabItem tabItemContract;
        private DevComponents.DotNetBar.TabItem tabItemReview;
        private DevComponents.DotNetBar.TabControlPanel tabPanelClient;
        private DevComponents.DotNetBar.TabControlPanel tabPanelClientCreditLine;
        private DevComponents.DotNetBar.TabControlPanel tabPanelContract;
        private DevComponents.DotNetBar.TabControlPanel tabPanelGD;
        private DevComponents.DotNetBar.TabControlPanel tabPanelReview;
        private DevComponents.DotNetBar.Controls.TextBoxX tbComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractStatus;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditLineCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGDAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGDComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGDCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupCreditLine;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupCreditLineCurr;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReviewCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX telephoneTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput unfreezeDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezerTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX websiteTextBox;

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
            DevComponents.DotNetBar.LabelX clientNameCNLabel;
            DevComponents.DotNetBar.LabelX addressCNLabel;
            DevComponents.DotNetBar.LabelX cityCNLabel;
            DevComponents.DotNetBar.LabelX provinceCNLabel;
            DevComponents.DotNetBar.LabelX productCNLabel;
            DevComponents.DotNetBar.LabelX postCodeLabel;
            DevComponents.DotNetBar.LabelX countryCodeLabel;
            DevComponents.DotNetBar.LabelX representativeLabel;
            DevComponents.DotNetBar.LabelX contactLabel;
            DevComponents.DotNetBar.LabelX emailLabel;
            DevComponents.DotNetBar.LabelX faxNumberLabel;
            DevComponents.DotNetBar.LabelX cellPhoneLabel;
            DevComponents.DotNetBar.LabelX groupNoLabel;
            DevComponents.DotNetBar.LabelX registrationNumberLabel;
            DevComponents.DotNetBar.LabelX companyCodeLabel;
            DevComponents.DotNetBar.LabelX clientTypeLabel;
            DevComponents.DotNetBar.LabelX clientLevelLabel;
            DevComponents.DotNetBar.LabelX branchCodeLabel;
            DevComponents.DotNetBar.LabelX pMNameLabel;
            DevComponents.DotNetBar.LabelX rMNameLabel;
            DevComponents.DotNetBar.LabelX clientNoLabel;
            DevComponents.DotNetBar.LabelX creditLineCurrencyLabel;
            DevComponents.DotNetBar.LabelX creditLineTypeLabel;
            DevComponents.DotNetBar.LabelX creditLineLabel;
            DevComponents.DotNetBar.LabelX periodBeginLabel;
            DevComponents.DotNetBar.LabelX approveNoLabel;
            DevComponents.DotNetBar.LabelX approveTypeLabel;
            DevComponents.DotNetBar.LabelX creditLineStatusLabel;
            DevComponents.DotNetBar.LabelX freezeReasonLabel;
            DevComponents.DotNetBar.LabelX freezerLabel;
            DevComponents.DotNetBar.LabelX freezeDateLabel;
            DevComponents.DotNetBar.LabelX unfreezeReasonLabel;
            DevComponents.DotNetBar.LabelX unfreezerLabel;
            DevComponents.DotNetBar.LabelX unfreezeDateLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX creditLineCommentLabel;
            DevComponents.DotNetBar.LabelX clientCoreNoLabel;
            DevComponents.DotNetBar.LabelX industryLabel;
            DevComponents.DotNetBar.LabelX lblContractCode;
            DevComponents.DotNetBar.LabelX lblContractCreateUserName;
            DevComponents.DotNetBar.LabelX lblContractStatus;
            DevComponents.DotNetBar.LabelX lblContractValueDate;
            DevComponents.DotNetBar.LabelX lblContractDueDate;
            DevComponents.DotNetBar.LabelX lblGroupNameCN;
            DevComponents.DotNetBar.LabelX websiteLabel;
            DevComponents.DotNetBar.LabelX telephoneLabel;
            DevComponents.DotNetBar.LabelX lblContractType;
            DevComponents.DotNetBar.LabelX lblCreateUserName;
            DevComponents.DotNetBar.LabelX lblGroupCreditLine;
            DevComponents.DotNetBar.LabelX reviewNoLabel;
            DevComponents.DotNetBar.LabelX reviewStatusLabel;
            DevComponents.DotNetBar.LabelX reviewDateLabel;
            DevComponents.DotNetBar.LabelX createUserNameLabel;
            DevComponents.DotNetBar.LabelX commentLabel1;
            DevComponents.DotNetBar.LabelX requestAmountLabel;
            DevComponents.DotNetBar.LabelX requestCommissionRateLabel;
            DevComponents.DotNetBar.LabelX requestFinancePeriodLabel;
            DevComponents.DotNetBar.LabelX requestFinanceType2Label;
            DevComponents.DotNetBar.LabelX requestFinanceTypeLabel;
            DevComponents.DotNetBar.LabelX lblComment;
            DevComponents.DotNetBar.LabelX lblIsNotice;
            DevComponents.DotNetBar.LabelX labelX1;
            DevComponents.DotNetBar.LabelX lblGuaranteeDeposit;
            DevComponents.DotNetBar.LabelX lblGDCreateUserName;
            DevComponents.DotNetBar.LabelX lblGDComment;
            DevComponents.DotNetBar.LabelX lblDepositDate;
            DevComponents.DotNetBar.LabelX lblOldEDICode;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetail));
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelGD = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvGDs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colGDCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGDAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepositDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelGuaranteePanel = new DevComponents.DotNetBar.PanelEx();
            this.diDepositDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.gdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGDComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbGDCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnGDUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnGDRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnGDDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnGDSave = new DevComponents.DotNetBar.ButtonX();
            this.btnGDNew = new DevComponents.DotNetBar.ButtonX();
            this.tbGDAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbGDCurr = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itemGuaranteeDeposit = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelReview = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvReviews = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colReviewNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelReview = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbIsNonRecoarse = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbIsBuyer = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbIsSeller = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbIsInternational = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbIsLocal = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbIsNotice = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbIsRecoarse = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.requestFinanceTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.requestFinanceType2ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.requestFinancePeriodTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requestCommissionRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requestAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requestCurrencyComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnReviewUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnReviewRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnReviewDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnReviewSave = new DevComponents.DotNetBar.ButtonX();
            this.btnReviewNew = new DevComponents.DotNetBar.ButtonX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbReviewCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reviewDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.reviewStatusComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reviewNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemReview = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelContract = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvContracts = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractValueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelContract = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.isSignedCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbContractType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnContractUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnContractRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnContractDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnContractSave = new DevComponents.DotNetBar.ButtonX();
            this.btnContractNew = new DevComponents.DotNetBar.ButtonX();
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContractCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContractStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diContractDueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diContractValueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tabItemContract = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelClientCreditLine = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvClientCreditLines = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCreditLineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreezeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreezer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreezeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnfreezeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnfreezer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnfreezeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelClientCreditLine = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbCreditLineCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientCreditLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGroupCreditLineCurr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnGroupCreditLineSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbGroupCreditLine = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClientCreditLineUpdate = new DevComponents.DotNetBar.ButtonX();
            this.creditLineTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClientCreditLineRefresh = new DevComponents.DotNetBar.ButtonX();
            this.creditLineCommentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.unfreezeDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnClientCreditLineUnfreeze = new DevComponents.DotNetBar.ButtonX();
            this.unfreezerTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.freezeDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnClientCreditLineFreeze = new DevComponents.DotNetBar.ButtonX();
            this.unfreezeReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.freezeReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClientCreditLineDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnClientCreditLineSave = new DevComponents.DotNetBar.ButtonX();
            this.freezerTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClientCreditLineNew = new DevComponents.DotNetBar.ButtonX();
            this.creditLineStatusTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.approveTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.approveNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.periodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.periodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.creditLineTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.creditLineCurrencyComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabItemClientCreditLine = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelClient = new DevComponents.DotNetBar.TabControlPanel();
            this.btnClientUpdate = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelClientContact = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.companyCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationNumberTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cellPhoneTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.faxNumberTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telephoneTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contactTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.websiteTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.representativeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelClientGroup = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnGroupSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbGroupNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbGroupNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClientSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelClientStat = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbIndustry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbDepartments = new DevComponents.DotNetBar.Controls.ComboTree();
            this.rMNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pMNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientLevelComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.clientTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanelClientBasic = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbOldEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientCoreNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientCommentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientEDICodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCountryCode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.postCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.productENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.productCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.provinceENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.provinceCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cityENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cityCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addressENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addressCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientNameENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientNameCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemClient = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItemCommissionRemit = new DevComponents.DotNetBar.TabItem(this.components);
            this.clientValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.regularExpressionValidator8 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator7 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator18 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("������һ����ַ", "Address");
            this.regularExpressionValidator6 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator17 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("������һ����ַ", "Address");
            this.regularExpressionValidator5 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator15 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("������һ���ͻ���", "ClientName");
            this.regularExpressionValidator4 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator14 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("������һ���ͻ���", "ClientName");
            this.regularExpressionValidator3 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator16 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("������һ���ͻ���", "ClientName");
            this.requiredFieldValidator10 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.creditLineValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator5 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator4 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.regularExpressionValidator9 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.compareValidator2 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.contractValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator11 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.regularExpressionValidator10 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator13 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.requiredFieldValidator12 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.reviewValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator19 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.gdValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator21 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator20 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator9 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator24 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator22 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator23 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            this.requiredFieldValidator25 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("����");
            clientNameCNLabel = new DevComponents.DotNetBar.LabelX();
            addressCNLabel = new DevComponents.DotNetBar.LabelX();
            cityCNLabel = new DevComponents.DotNetBar.LabelX();
            provinceCNLabel = new DevComponents.DotNetBar.LabelX();
            productCNLabel = new DevComponents.DotNetBar.LabelX();
            postCodeLabel = new DevComponents.DotNetBar.LabelX();
            countryCodeLabel = new DevComponents.DotNetBar.LabelX();
            representativeLabel = new DevComponents.DotNetBar.LabelX();
            contactLabel = new DevComponents.DotNetBar.LabelX();
            emailLabel = new DevComponents.DotNetBar.LabelX();
            faxNumberLabel = new DevComponents.DotNetBar.LabelX();
            cellPhoneLabel = new DevComponents.DotNetBar.LabelX();
            groupNoLabel = new DevComponents.DotNetBar.LabelX();
            registrationNumberLabel = new DevComponents.DotNetBar.LabelX();
            companyCodeLabel = new DevComponents.DotNetBar.LabelX();
            clientTypeLabel = new DevComponents.DotNetBar.LabelX();
            clientLevelLabel = new DevComponents.DotNetBar.LabelX();
            branchCodeLabel = new DevComponents.DotNetBar.LabelX();
            pMNameLabel = new DevComponents.DotNetBar.LabelX();
            rMNameLabel = new DevComponents.DotNetBar.LabelX();
            clientNoLabel = new DevComponents.DotNetBar.LabelX();
            creditLineCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            creditLineTypeLabel = new DevComponents.DotNetBar.LabelX();
            creditLineLabel = new DevComponents.DotNetBar.LabelX();
            periodBeginLabel = new DevComponents.DotNetBar.LabelX();
            approveNoLabel = new DevComponents.DotNetBar.LabelX();
            approveTypeLabel = new DevComponents.DotNetBar.LabelX();
            creditLineStatusLabel = new DevComponents.DotNetBar.LabelX();
            freezeReasonLabel = new DevComponents.DotNetBar.LabelX();
            freezerLabel = new DevComponents.DotNetBar.LabelX();
            freezeDateLabel = new DevComponents.DotNetBar.LabelX();
            unfreezeReasonLabel = new DevComponents.DotNetBar.LabelX();
            unfreezerLabel = new DevComponents.DotNetBar.LabelX();
            unfreezeDateLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            creditLineCommentLabel = new DevComponents.DotNetBar.LabelX();
            clientCoreNoLabel = new DevComponents.DotNetBar.LabelX();
            industryLabel = new DevComponents.DotNetBar.LabelX();
            lblContractCode = new DevComponents.DotNetBar.LabelX();
            lblContractCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblContractStatus = new DevComponents.DotNetBar.LabelX();
            lblContractValueDate = new DevComponents.DotNetBar.LabelX();
            lblContractDueDate = new DevComponents.DotNetBar.LabelX();
            lblGroupNameCN = new DevComponents.DotNetBar.LabelX();
            websiteLabel = new DevComponents.DotNetBar.LabelX();
            telephoneLabel = new DevComponents.DotNetBar.LabelX();
            lblContractType = new DevComponents.DotNetBar.LabelX();
            lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblGroupCreditLine = new DevComponents.DotNetBar.LabelX();
            reviewNoLabel = new DevComponents.DotNetBar.LabelX();
            reviewStatusLabel = new DevComponents.DotNetBar.LabelX();
            reviewDateLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel1 = new DevComponents.DotNetBar.LabelX();
            requestAmountLabel = new DevComponents.DotNetBar.LabelX();
            requestCommissionRateLabel = new DevComponents.DotNetBar.LabelX();
            requestFinancePeriodLabel = new DevComponents.DotNetBar.LabelX();
            requestFinanceType2Label = new DevComponents.DotNetBar.LabelX();
            requestFinanceTypeLabel = new DevComponents.DotNetBar.LabelX();
            lblComment = new DevComponents.DotNetBar.LabelX();
            lblIsNotice = new DevComponents.DotNetBar.LabelX();
            labelX1 = new DevComponents.DotNetBar.LabelX();
            lblGuaranteeDeposit = new DevComponents.DotNetBar.LabelX();
            lblGDCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblGDComment = new DevComponents.DotNetBar.LabelX();
            lblDepositDate = new DevComponents.DotNetBar.LabelX();
            lblOldEDICode = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGDs)).BeginInit();
            this.groupPanelGuaranteePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diDepositDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdBindingSource)).BeginInit();
            this.tabPanelReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.groupPanelReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDateDateTimePicker)).BeginInit();
            this.tabPanelContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.groupPanelContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractValueDate)).BeginInit();
            this.tabPanelClientCreditLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLines)).BeginInit();
            this.groupPanelClientCreditLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unfreezeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBeginDateTimePicker)).BeginInit();
            this.tabPanelClient.SuspendLayout();
            this.groupPanelClientContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupPanelClientGroup.SuspendLayout();
            this.groupPanelClientStat.SuspendLayout();
            this.groupPanelClientBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // clientNameCNLabel
            // 
            clientNameCNLabel.AutoSize = true;
            clientNameCNLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            clientNameCNLabel.BackgroundStyle.Class = "";
            clientNameCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            clientNameCNLabel.Location = new System.Drawing.Point(41, 31);
            clientNameCNLabel.Name = "clientNameCNLabel";
            clientNameCNLabel.Size = new System.Drawing.Size(33, 15);
            clientNameCNLabel.TabIndex = 4;
            clientNameCNLabel.Text = "<font color=\'red\'>*</font>�ͻ�:";
            clientNameCNLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // addressCNLabel
            // 
            addressCNLabel.AutoSize = true;
            addressCNLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            addressCNLabel.BackgroundStyle.Class = "";
            addressCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            addressCNLabel.Location = new System.Drawing.Point(43, 82);
            addressCNLabel.Name = "addressCNLabel";
            addressCNLabel.Size = new System.Drawing.Size(33, 15);
            addressCNLabel.TabIndex = 8;
            addressCNLabel.Text = "<font color=\'red\'>*</font>��ַ:";
            addressCNLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cityCNLabel
            // 
            cityCNLabel.AutoSize = true;
            cityCNLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            cityCNLabel.BackgroundStyle.Class = "";
            cityCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            cityCNLabel.Location = new System.Drawing.Point(44, 127);
            cityCNLabel.Name = "cityCNLabel";
            cityCNLabel.Size = new System.Drawing.Size(34, 16);
            cityCNLabel.TabIndex = 11;
            cityCNLabel.Text = "����:";
            cityCNLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // provinceCNLabel
            // 
            provinceCNLabel.AutoSize = true;
            provinceCNLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            provinceCNLabel.BackgroundStyle.Class = "";
            provinceCNLabel.Location = new System.Drawing.Point(41, 150);
            provinceCNLabel.Name = "provinceCNLabel";
            provinceCNLabel.Size = new System.Drawing.Size(37, 16);
            provinceCNLabel.TabIndex = 14;
            provinceCNLabel.Text = "ʡ/��:";
            provinceCNLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // productCNLabel
            // 
            productCNLabel.AutoSize = true;
            productCNLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            productCNLabel.BackgroundStyle.Class = "";
            productCNLabel.Location = new System.Drawing.Point(393, 7);
            productCNLabel.Name = "productCNLabel";
            productCNLabel.Size = new System.Drawing.Size(59, 16);
            productCNLabel.TabIndex = 21;
            productCNLabel.Text = "��Ӫ��Χ:";
            productCNLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            postCodeLabel.BackgroundStyle.Class = "";
            postCodeLabel.Location = new System.Drawing.Point(44, 198);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(34, 16);
            postCodeLabel.TabIndex = 19;
            postCodeLabel.Text = "�ʱ�:";
            postCodeLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // countryCodeLabel
            // 
            countryCodeLabel.AutoSize = true;
            countryCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            countryCodeLabel.BackgroundStyle.Class = "";
            countryCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            countryCodeLabel.Location = new System.Drawing.Point(41, 177);
            countryCodeLabel.Name = "countryCodeLabel";
            countryCodeLabel.Size = new System.Drawing.Size(33, 15);
            countryCodeLabel.TabIndex = 17;
            countryCodeLabel.Text = "<font color=\'red\'>*</font>����:";
            countryCodeLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // representativeLabel
            // 
            representativeLabel.AutoSize = true;
            representativeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            representativeLabel.BackgroundStyle.Class = "";
            representativeLabel.Location = new System.Drawing.Point(20, 7);
            representativeLabel.Name = "representativeLabel";
            representativeLabel.Size = new System.Drawing.Size(59, 16);
            representativeLabel.TabIndex = 0;
            representativeLabel.Text = "��˾����:";
            representativeLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            contactLabel.BackgroundStyle.Class = "";
            contactLabel.Location = new System.Drawing.Point(32, 30);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(47, 16);
            contactLabel.TabIndex = 2;
            contactLabel.Text = "��ϵ��:";
            contactLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            emailLabel.BackgroundStyle.Class = "";
            emailLabel.Location = new System.Drawing.Point(38, 54);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 16);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            emailLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // faxNumberLabel
            // 
            faxNumberLabel.AutoSize = true;
            faxNumberLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            faxNumberLabel.BackgroundStyle.Class = "";
            faxNumberLabel.Location = new System.Drawing.Point(205, 54);
            faxNumberLabel.Name = "faxNumberLabel";
            faxNumberLabel.Size = new System.Drawing.Size(59, 16);
            faxNumberLabel.TabIndex = 12;
            faxNumberLabel.Text = "�������:";
            faxNumberLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            cellPhoneLabel.BackgroundStyle.Class = "";
            cellPhoneLabel.Location = new System.Drawing.Point(20, 78);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new System.Drawing.Size(59, 16);
            cellPhoneLabel.TabIndex = 6;
            cellPhoneLabel.Text = "�ֻ�����:";
            cellPhoneLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupNoLabel
            // 
            groupNoLabel.AutoSize = true;
            groupNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            groupNoLabel.BackgroundStyle.Class = "";
            groupNoLabel.Location = new System.Drawing.Point(11, 5);
            groupNoLabel.Name = "groupNoLabel";
            groupNoLabel.Size = new System.Drawing.Size(97, 16);
            groupNoLabel.TabIndex = 0;
            groupNoLabel.Text = "�������ſͻ���:";
            groupNoLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // registrationNumberLabel
            // 
            registrationNumberLabel.AutoSize = true;
            registrationNumberLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            registrationNumberLabel.BackgroundStyle.Class = "";
            registrationNumberLabel.Location = new System.Drawing.Point(380, 7);
            registrationNumberLabel.Name = "registrationNumberLabel";
            registrationNumberLabel.Size = new System.Drawing.Size(84, 16);
            registrationNumberLabel.TabIndex = 14;
            registrationNumberLabel.Text = "Ӫҵִ�պ���:";
            registrationNumberLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // companyCodeLabel
            // 
            companyCodeLabel.AutoSize = true;
            companyCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            companyCodeLabel.BackgroundStyle.Class = "";
            companyCodeLabel.Location = new System.Drawing.Point(380, 30);
            companyCodeLabel.Name = "companyCodeLabel";
            companyCodeLabel.Size = new System.Drawing.Size(84, 16);
            companyCodeLabel.TabIndex = 16;
            companyCodeLabel.Text = "��֯��������:";
            companyCodeLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // clientTypeLabel
            // 
            clientTypeLabel.AutoSize = true;
            clientTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            clientTypeLabel.BackgroundStyle.Class = "";
            clientTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            clientTypeLabel.Location = new System.Drawing.Point(20, 7);
            clientTypeLabel.Name = "clientTypeLabel";
            clientTypeLabel.Size = new System.Drawing.Size(59, 16);
            clientTypeLabel.TabIndex = 0;
            clientTypeLabel.Text = "�ͻ�����:";
            clientTypeLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // clientLevelLabel
            // 
            clientLevelLabel.AutoSize = true;
            clientLevelLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            clientLevelLabel.BackgroundStyle.Class = "";
            clientLevelLabel.Location = new System.Drawing.Point(212, 7);
            clientLevelLabel.Name = "clientLevelLabel";
            clientLevelLabel.Size = new System.Drawing.Size(59, 16);
            clientLevelLabel.TabIndex = 2;
            clientLevelLabel.Text = "�ͻ�����:";
            clientLevelLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // branchCodeLabel
            // 
            branchCodeLabel.AutoSize = true;
            branchCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            branchCodeLabel.BackgroundStyle.Class = "";
            branchCodeLabel.Location = new System.Drawing.Point(20, 30);
            branchCodeLabel.Name = "branchCodeLabel";
            branchCodeLabel.Size = new System.Drawing.Size(59, 16);
            branchCodeLabel.TabIndex = 4;
            branchCodeLabel.Text = "��������:";
            branchCodeLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // pMNameLabel
            // 
            pMNameLabel.AutoSize = true;
            pMNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            pMNameLabel.BackgroundStyle.Class = "";
            pMNameLabel.Location = new System.Drawing.Point(20, 54);
            pMNameLabel.Name = "pMNameLabel";
            pMNameLabel.Size = new System.Drawing.Size(59, 16);
            pMNameLabel.TabIndex = 6;
            pMNameLabel.Text = "��Ʒ����:";
            pMNameLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // rMNameLabel
            // 
            rMNameLabel.AutoSize = true;
            rMNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            rMNameLabel.BackgroundStyle.Class = "";
            rMNameLabel.Location = new System.Drawing.Point(212, 54);
            rMNameLabel.Name = "rMNameLabel";
            rMNameLabel.Size = new System.Drawing.Size(59, 16);
            rMNameLabel.TabIndex = 8;
            rMNameLabel.Text = "�ͻ�����:";
            rMNameLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // clientNoLabel
            // 
            clientNoLabel.AutoSize = true;
            clientNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            clientNoLabel.BackgroundStyle.Class = "";
            clientNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            clientNoLabel.Location = new System.Drawing.Point(19, 7);
            clientNoLabel.Name = "clientNoLabel";
            clientNoLabel.Size = new System.Drawing.Size(57, 15);
            clientNoLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            clientNoLabel.TabIndex = 0;
            clientNoLabel.Text = "<font color=\'red\'>*</font>�������:";
            // 
            // creditLineCurrencyLabel
            // 
            creditLineCurrencyLabel.AutoSize = true;
            creditLineCurrencyLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineCurrencyLabel.BackgroundStyle.Class = "";
            creditLineCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            creditLineCurrencyLabel.Location = new System.Drawing.Point(22, 32);
            creditLineCurrencyLabel.Name = "creditLineCurrencyLabel";
            creditLineCurrencyLabel.Size = new System.Drawing.Size(57, 15);
            creditLineCurrencyLabel.TabIndex = 5;
            creditLineCurrencyLabel.Text = "<font color=\'red\'>*</font>��ȱұ�:";
            // 
            // creditLineTypeLabel
            // 
            creditLineTypeLabel.AutoSize = true;
            creditLineTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineTypeLabel.BackgroundStyle.Class = "";
            creditLineTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            creditLineTypeLabel.Location = new System.Drawing.Point(22, 7);
            creditLineTypeLabel.Name = "creditLineTypeLabel";
            creditLineTypeLabel.Size = new System.Drawing.Size(57, 15);
            creditLineTypeLabel.TabIndex = 0;
            creditLineTypeLabel.Text = "<font color=\'red\'>*</font>�������:";
            // 
            // creditLineLabel
            // 
            creditLineLabel.AutoSize = true;
            creditLineLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineLabel.BackgroundStyle.Class = "";
            creditLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            creditLineLabel.Location = new System.Drawing.Point(22, 54);
            creditLineLabel.Name = "creditLineLabel";
            creditLineLabel.Size = new System.Drawing.Size(57, 15);
            creditLineLabel.TabIndex = 9;
            creditLineLabel.Text = "<font color=\'red\'>*</font>�������:";
            // 
            // periodBeginLabel
            // 
            periodBeginLabel.AutoSize = true;
            periodBeginLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            periodBeginLabel.BackgroundStyle.Class = "";
            periodBeginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            periodBeginLabel.Location = new System.Drawing.Point(252, 8);
            periodBeginLabel.Name = "periodBeginLabel";
            periodBeginLabel.Size = new System.Drawing.Size(57, 15);
            periodBeginLabel.TabIndex = 2;
            periodBeginLabel.Text = "<font color=\'red\'>*</font>��Ч����:";
            // 
            // approveNoLabel
            // 
            approveNoLabel.AutoSize = true;
            approveNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            approveNoLabel.BackgroundStyle.Class = "";
            approveNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            approveNoLabel.Location = new System.Drawing.Point(252, 30);
            approveNoLabel.Name = "approveNoLabel";
            approveNoLabel.Size = new System.Drawing.Size(59, 16);
            approveNoLabel.TabIndex = 7;
            approveNoLabel.Text = "���ű��:";
            // 
            // approveTypeLabel
            // 
            approveTypeLabel.AutoSize = true;
            approveTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            approveTypeLabel.BackgroundStyle.Class = "";
            approveTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            approveTypeLabel.Location = new System.Drawing.Point(253, 52);
            approveTypeLabel.Name = "approveTypeLabel";
            approveTypeLabel.Size = new System.Drawing.Size(59, 16);
            approveTypeLabel.TabIndex = 11;
            approveTypeLabel.Text = "��������:";
            // 
            // creditLineStatusLabel
            // 
            creditLineStatusLabel.AutoSize = true;
            creditLineStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineStatusLabel.BackgroundStyle.Class = "";
            creditLineStatusLabel.Location = new System.Drawing.Point(22, 75);
            creditLineStatusLabel.Name = "creditLineStatusLabel";
            creditLineStatusLabel.Size = new System.Drawing.Size(59, 16);
            creditLineStatusLabel.TabIndex = 13;
            creditLineStatusLabel.Text = "���״̬:";
            // 
            // freezeReasonLabel
            // 
            freezeReasonLabel.AutoSize = true;
            freezeReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            freezeReasonLabel.BackgroundStyle.Class = "";
            freezeReasonLabel.Location = new System.Drawing.Point(26, 187);
            freezeReasonLabel.Name = "freezeReasonLabel";
            freezeReasonLabel.Size = new System.Drawing.Size(59, 16);
            freezeReasonLabel.TabIndex = 21;
            freezeReasonLabel.Text = "����ԭ��:";
            // 
            // freezerLabel
            // 
            freezerLabel.AutoSize = true;
            freezerLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            freezerLabel.BackgroundStyle.Class = "";
            freezerLabel.Location = new System.Drawing.Point(39, 229);
            freezerLabel.Name = "freezerLabel";
            freezerLabel.Size = new System.Drawing.Size(47, 16);
            freezerLabel.TabIndex = 23;
            freezerLabel.Text = "������:";
            // 
            // freezeDateLabel
            // 
            freezeDateLabel.AutoSize = true;
            freezeDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            freezeDateLabel.BackgroundStyle.Class = "";
            freezeDateLabel.Location = new System.Drawing.Point(253, 227);
            freezeDateLabel.Name = "freezeDateLabel";
            freezeDateLabel.Size = new System.Drawing.Size(59, 16);
            freezeDateLabel.TabIndex = 25;
            freezeDateLabel.Text = "��������:";
            // 
            // unfreezeReasonLabel
            // 
            unfreezeReasonLabel.AutoSize = true;
            unfreezeReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            unfreezeReasonLabel.BackgroundStyle.Class = "";
            unfreezeReasonLabel.Location = new System.Drawing.Point(26, 259);
            unfreezeReasonLabel.Name = "unfreezeReasonLabel";
            unfreezeReasonLabel.Size = new System.Drawing.Size(59, 16);
            unfreezeReasonLabel.TabIndex = 27;
            unfreezeReasonLabel.Text = "�ⶳԭ��:";
            // 
            // unfreezerLabel
            // 
            unfreezerLabel.AutoSize = true;
            unfreezerLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            unfreezerLabel.BackgroundStyle.Class = "";
            unfreezerLabel.Location = new System.Drawing.Point(39, 299);
            unfreezerLabel.Name = "unfreezerLabel";
            unfreezerLabel.Size = new System.Drawing.Size(47, 16);
            unfreezerLabel.TabIndex = 29;
            unfreezerLabel.Text = "������:";
            // 
            // unfreezeDateLabel
            // 
            unfreezeDateLabel.AutoSize = true;
            unfreezeDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            unfreezeDateLabel.BackgroundStyle.Class = "";
            unfreezeDateLabel.Location = new System.Drawing.Point(251, 298);
            unfreezeDateLabel.Name = "unfreezeDateLabel";
            unfreezeDateLabel.Size = new System.Drawing.Size(59, 16);
            unfreezeDateLabel.TabIndex = 31;
            unfreezeDateLabel.Text = "�ⶳ����:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(393, 126);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 24;
            commentLabel.Text = "��ע:";
            commentLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // creditLineCommentLabel
            // 
            creditLineCommentLabel.AutoSize = true;
            creditLineCommentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineCommentLabel.BackgroundStyle.Class = "";
            creditLineCommentLabel.Location = new System.Drawing.Point(50, 98);
            creditLineCommentLabel.Name = "creditLineCommentLabel";
            creditLineCommentLabel.Size = new System.Drawing.Size(34, 16);
            creditLineCommentLabel.TabIndex = 19;
            creditLineCommentLabel.Text = "��ע:";
            // 
            // clientCoreNoLabel
            // 
            clientCoreNoLabel.AutoSize = true;
            // 
            // 
            // 
            clientCoreNoLabel.BackgroundStyle.Class = "";
            clientCoreNoLabel.Location = new System.Drawing.Point(227, 7);
            clientCoreNoLabel.Name = "clientCoreNoLabel";
            clientCoreNoLabel.Size = new System.Drawing.Size(47, 16);
            clientCoreNoLabel.TabIndex = 2;
            clientCoreNoLabel.Text = "�ͻ���:";
            clientCoreNoLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // industryLabel
            // 
            industryLabel.AutoSize = true;
            industryLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            industryLabel.BackgroundStyle.Class = "";
            industryLabel.Location = new System.Drawing.Point(400, 7);
            industryLabel.Name = "industryLabel";
            industryLabel.Size = new System.Drawing.Size(59, 16);
            industryLabel.TabIndex = 10;
            industryLabel.Text = "������ҵ:";
            industryLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblContractCode
            // 
            lblContractCode.AutoSize = true;
            lblContractCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractCode.BackgroundStyle.Class = "";
            lblContractCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblContractCode.Location = new System.Drawing.Point(26, 32);
            lblContractCode.Name = "lblContractCode";
            lblContractCode.Size = new System.Drawing.Size(57, 15);
            lblContractCode.TabIndex = 4;
            lblContractCode.Text = "<font color=\'red\'>*</font>��ͬ���:";
            // 
            // lblContractCreateUserName
            // 
            lblContractCreateUserName.AutoSize = true;
            lblContractCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractCreateUserName.BackgroundStyle.Class = "";
            lblContractCreateUserName.Location = new System.Drawing.Point(39, 82);
            lblContractCreateUserName.Name = "lblContractCreateUserName";
            lblContractCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblContractCreateUserName.TabIndex = 10;
            lblContractCreateUserName.Text = "������:";
            // 
            // lblContractStatus
            // 
            lblContractStatus.AutoSize = true;
            lblContractStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractStatus.BackgroundStyle.Class = "";
            lblContractStatus.Location = new System.Drawing.Point(27, 56);
            lblContractStatus.Name = "lblContractStatus";
            lblContractStatus.Size = new System.Drawing.Size(59, 16);
            lblContractStatus.TabIndex = 8;
            lblContractStatus.Text = "��ͬ״̬:";
            // 
            // lblContractValueDate
            // 
            lblContractValueDate.AutoSize = true;
            lblContractValueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractValueDate.BackgroundStyle.Class = "";
            lblContractValueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblContractValueDate.Location = new System.Drawing.Point(305, 9);
            lblContractValueDate.Name = "lblContractValueDate";
            lblContractValueDate.Size = new System.Drawing.Size(45, 15);
            lblContractValueDate.TabIndex = 2;
            lblContractValueDate.Text = "<font color=\'red\'>*</font>��Ч��:";
            // 
            // lblContractDueDate
            // 
            lblContractDueDate.AutoSize = true;
            lblContractDueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractDueDate.BackgroundStyle.Class = "";
            lblContractDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblContractDueDate.Location = new System.Drawing.Point(305, 31);
            lblContractDueDate.Name = "lblContractDueDate";
            lblContractDueDate.Size = new System.Drawing.Size(45, 15);
            lblContractDueDate.TabIndex = 6;
            lblContractDueDate.Text = "<font color=\'red\'>*</font>������:";
            // 
            // lblGroupNameCN
            // 
            lblGroupNameCN.AutoSize = true;
            lblGroupNameCN.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblGroupNameCN.BackgroundStyle.Class = "";
            lblGroupNameCN.Location = new System.Drawing.Point(10, 31);
            lblGroupNameCN.Name = "lblGroupNameCN";
            lblGroupNameCN.Size = new System.Drawing.Size(72, 16);
            lblGroupNameCN.TabIndex = 3;
            lblGroupNameCN.Text = "���ſͻ���:";
            lblGroupNameCN.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            websiteLabel.BackgroundStyle.Class = "";
            websiteLabel.Location = new System.Drawing.Point(205, 7);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(59, 16);
            websiteLabel.TabIndex = 8;
            websiteLabel.Text = "��˾��ַ:";
            websiteLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            telephoneLabel.BackgroundStyle.Class = "";
            telephoneLabel.Location = new System.Drawing.Point(205, 30);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(59, 16);
            telephoneLabel.TabIndex = 10;
            telephoneLabel.Text = "��ϵ�绰:";
            telephoneLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblContractType
            // 
            lblContractType.AutoSize = true;
            lblContractType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractType.BackgroundStyle.Class = "";
            lblContractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblContractType.Location = new System.Drawing.Point(27, 8);
            lblContractType.Name = "lblContractType";
            lblContractType.Size = new System.Drawing.Size(57, 15);
            lblContractType.TabIndex = 0;
            lblContractType.Text = "<font color=\'red\'>*</font>��ͬ����:";
            // 
            // lblCreateUserName
            // 
            lblCreateUserName.AutoSize = true;
            lblCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCreateUserName.BackgroundStyle.Class = "";
            lblCreateUserName.Location = new System.Drawing.Point(412, 55);
            lblCreateUserName.Name = "lblCreateUserName";
            lblCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCreateUserName.TabIndex = 12;
            lblCreateUserName.Text = "������:";
            lblCreateUserName.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblGroupCreditLine
            // 
            lblGroupCreditLine.AutoSize = true;
            lblGroupCreditLine.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblGroupCreditLine.BackgroundStyle.Class = "";
            lblGroupCreditLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblGroupCreditLine.Location = new System.Drawing.Point(253, 75);
            lblGroupCreditLine.Name = "lblGroupCreditLine";
            lblGroupCreditLine.Size = new System.Drawing.Size(84, 16);
            lblGroupCreditLine.TabIndex = 15;
            lblGroupCreditLine.Text = "���Ŷ������:";
            // 
            // reviewNoLabel
            // 
            reviewNoLabel.AutoSize = true;
            reviewNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            reviewNoLabel.BackgroundStyle.Class = "";
            reviewNoLabel.Location = new System.Drawing.Point(22, 9);
            reviewNoLabel.Name = "reviewNoLabel";
            reviewNoLabel.Size = new System.Drawing.Size(81, 15);
            reviewNoLabel.TabIndex = 0;
            reviewNoLabel.Text = "<font color=\'red\'>*</font>Э��������:";
            // 
            // reviewStatusLabel
            // 
            reviewStatusLabel.AutoSize = true;
            reviewStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            reviewStatusLabel.BackgroundStyle.Class = "";
            reviewStatusLabel.Location = new System.Drawing.Point(70, 34);
            reviewStatusLabel.Name = "reviewStatusLabel";
            reviewStatusLabel.Size = new System.Drawing.Size(33, 15);
            reviewStatusLabel.TabIndex = 5;
            reviewStatusLabel.Text = "<font color=\'red\'>*</font>״̬:";
            // 
            // reviewDateLabel
            // 
            reviewDateLabel.AutoSize = true;
            reviewDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            reviewDateLabel.BackgroundStyle.Class = "";
            reviewDateLabel.Location = new System.Drawing.Point(59, 55);
            reviewDateLabel.Name = "reviewDateLabel";
            reviewDateLabel.Size = new System.Drawing.Size(45, 15);
            reviewDateLabel.TabIndex = 7;
            reviewDateLabel.Text = "<font color=\'red\'>*</font>Э����:";
            // 
            // createUserNameLabel
            // 
            createUserNameLabel.AutoSize = true;
            createUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            createUserNameLabel.BackgroundStyle.Class = "";
            createUserNameLabel.Location = new System.Drawing.Point(59, 129);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            createUserNameLabel.TabIndex = 15;
            createUserNameLabel.Text = "������:";
            // 
            // commentLabel1
            // 
            commentLabel1.AutoSize = true;
            commentLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel1.BackgroundStyle.Class = "";
            commentLabel1.Location = new System.Drawing.Point(69, 210);
            commentLabel1.Name = "commentLabel1";
            commentLabel1.Size = new System.Drawing.Size(34, 16);
            commentLabel1.TabIndex = 27;
            commentLabel1.Text = "��ע:";
            // 
            // requestAmountLabel
            // 
            requestAmountLabel.AutoSize = true;
            requestAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestAmountLabel.BackgroundStyle.Class = "";
            requestAmountLabel.Location = new System.Drawing.Point(255, 10);
            requestAmountLabel.Name = "requestAmountLabel";
            requestAmountLabel.Size = new System.Drawing.Size(84, 16);
            requestAmountLabel.TabIndex = 2;
            requestAmountLabel.Text = "�������Ž��:";
            // 
            // requestCommissionRateLabel
            // 
            requestCommissionRateLabel.AutoSize = true;
            requestCommissionRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestCommissionRateLabel.BackgroundStyle.Class = "";
            requestCommissionRateLabel.Location = new System.Drawing.Point(48, 85);
            requestCommissionRateLabel.Name = "requestCommissionRateLabel";
            requestCommissionRateLabel.Size = new System.Drawing.Size(59, 16);
            requestCommissionRateLabel.TabIndex = 9;
            requestCommissionRateLabel.Text = "�������:";
            // 
            // requestFinancePeriodLabel
            // 
            requestFinancePeriodLabel.AutoSize = true;
            requestFinancePeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestFinancePeriodLabel.BackgroundStyle.Class = "";
            requestFinancePeriodLabel.Location = new System.Drawing.Point(27, 109);
            requestFinancePeriodLabel.Name = "requestFinancePeriodLabel";
            requestFinancePeriodLabel.Size = new System.Drawing.Size(79, 16);
            requestFinancePeriodLabel.TabIndex = 13;
            requestFinancePeriodLabel.Text = "��������(��):";
            // 
            // requestFinanceType2Label
            // 
            requestFinanceType2Label.AutoSize = true;
            requestFinanceType2Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestFinanceType2Label.BackgroundStyle.Class = "";
            requestFinanceType2Label.Location = new System.Drawing.Point(279, 109);
            requestFinanceType2Label.Name = "requestFinanceType2Label";
            requestFinanceType2Label.Size = new System.Drawing.Size(59, 16);
            requestFinanceType2Label.TabIndex = 17;
            requestFinanceType2Label.Text = "���ʹ���:";
            // 
            // requestFinanceTypeLabel
            // 
            requestFinanceTypeLabel.AutoSize = true;
            requestFinanceTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestFinanceTypeLabel.BackgroundStyle.Class = "";
            requestFinanceTypeLabel.Location = new System.Drawing.Point(279, 39);
            requestFinanceTypeLabel.Name = "requestFinanceTypeLabel";
            requestFinanceTypeLabel.Size = new System.Drawing.Size(59, 16);
            requestFinanceTypeLabel.TabIndex = 11;
            requestFinanceTypeLabel.Text = "���˷�ʽ:";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblComment.BackgroundStyle.Class = "";
            lblComment.Location = new System.Drawing.Point(50, 110);
            lblComment.Name = "lblComment";
            lblComment.Size = new System.Drawing.Size(34, 16);
            lblComment.TabIndex = 18;
            lblComment.Text = "��ע:";
            // 
            // lblIsNotice
            // 
            lblIsNotice.AutoSize = true;
            lblIsNotice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblIsNotice.BackgroundStyle.Class = "";
            lblIsNotice.Location = new System.Drawing.Point(275, 132);
            lblIsNotice.Name = "lblIsNotice";
            lblIsNotice.Size = new System.Drawing.Size(62, 16);
            lblIsNotice.TabIndex = 19;
            lblIsNotice.Text = "��/������:";
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            labelX1.BackgroundStyle.Class = "";
            labelX1.Location = new System.Drawing.Point(38, 161);
            labelX1.Name = "labelX1";
            labelX1.Size = new System.Drawing.Size(47, 16);
            labelX1.TabIndex = 40;
            labelX1.Text = "������:";
            // 
            // lblGuaranteeDeposit
            // 
            lblGuaranteeDeposit.AutoSize = true;
            lblGuaranteeDeposit.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblGuaranteeDeposit.BackgroundStyle.Class = "";
            lblGuaranteeDeposit.Location = new System.Drawing.Point(29, 17);
            lblGuaranteeDeposit.Name = "lblGuaranteeDeposit";
            lblGuaranteeDeposit.Size = new System.Drawing.Size(45, 15);
            lblGuaranteeDeposit.TabIndex = 0;
            lblGuaranteeDeposit.Text = "<font color=\'red\'>*</font>��֤��:";
            // 
            // lblGDCreateUserName
            // 
            lblGDCreateUserName.AutoSize = true;
            lblGDCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblGDCreateUserName.BackgroundStyle.Class = "";
            lblGDCreateUserName.Location = new System.Drawing.Point(33, 47);
            lblGDCreateUserName.Name = "lblGDCreateUserName";
            lblGDCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblGDCreateUserName.TabIndex = 17;
            lblGDCreateUserName.Text = "������:";
            // 
            // lblGDComment
            // 
            lblGDComment.AutoSize = true;
            lblGDComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblGDComment.BackgroundStyle.Class = "";
            lblGDComment.Location = new System.Drawing.Point(41, 81);
            lblGDComment.Name = "lblGDComment";
            lblGDComment.Size = new System.Drawing.Size(34, 16);
            lblGDComment.TabIndex = 29;
            lblGDComment.Text = "��ע:";
            // 
            // lblDepositDate
            // 
            lblDepositDate.AutoSize = true;
            lblDepositDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblDepositDate.BackgroundStyle.Class = "";
            lblDepositDate.Location = new System.Drawing.Point(334, 14);
            lblDepositDate.Name = "lblDepositDate";
            lblDepositDate.Size = new System.Drawing.Size(57, 15);
            lblDepositDate.TabIndex = 31;
            lblDepositDate.Text = "<font color=\'red\'>*</font>��֤����:";
            // 
            // lblOldEDICode
            // 
            lblOldEDICode.AutoSize = true;
            lblOldEDICode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblOldEDICode.BackgroundStyle.Class = "";
            lblOldEDICode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblOldEDICode.Location = new System.Drawing.Point(191, 200);
            lblOldEDICode.Name = "lblOldEDICode";
            lblOldEDICode.Size = new System.Drawing.Size(84, 16);
            lblOldEDICode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblOldEDICode.TabIndex = 26;
            lblOldEDICode.Text = "���ñ������:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelClient);
            this.tabControl.Controls.Add(this.tabPanelGD);
            this.tabControl.Controls.Add(this.tabPanelReview);
            this.tabControl.Controls.Add(this.tabPanelContract);
            this.tabControl.Controls.Add(this.tabPanelClientCreditLine);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(586, 614);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemClient);
            this.tabControl.Tabs.Add(this.tabItemClientCreditLine);
            this.tabControl.Tabs.Add(this.tabItemContract);
            this.tabControl.Tabs.Add(this.tabItemReview);
            this.tabControl.Tabs.Add(this.itemGuaranteeDeposit);
            this.tabControl.Text = "tabControl1";
            // 
            // tabPanelGD
            // 
            this.tabPanelGD.Controls.Add(this.dgvGDs);
            this.tabPanelGD.Controls.Add(this.groupPanelGuaranteePanel);
            this.tabPanelGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelGD.Location = new System.Drawing.Point(0, 26);
            this.tabPanelGD.Name = "tabPanelGD";
            this.tabPanelGD.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelGD.Size = new System.Drawing.Size(586, 588);
            this.tabPanelGD.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelGD.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelGD.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelGD.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelGD.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelGD.Style.GradientAngle = 90;
            this.tabPanelGD.TabIndex = 6;
            this.tabPanelGD.TabItem = this.itemGuaranteeDeposit;
            // 
            // dgvGDs
            // 
            this.dgvGDs.AllowUserToAddRows = false;
            this.dgvGDs.AllowUserToDeleteRows = false;
            this.dgvGDs.AllowUserToOrderColumns = true;
            this.dgvGDs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGDCurrency,
            this.colGDAmount,
            this.colDepositDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGDs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGDs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvGDs.Location = new System.Drawing.Point(1, 233);
            this.dgvGDs.MultiSelect = false;
            this.dgvGDs.Name = "dgvGDs";
            this.dgvGDs.ReadOnly = true;
            this.dgvGDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGDs.Size = new System.Drawing.Size(584, 354);
            this.dgvGDs.TabIndex = 1;
            this.dgvGDs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectGD);
            // 
            // colGDCurrency
            // 
            this.colGDCurrency.DataPropertyName = "GuaranteeDepositCurrency";
            this.colGDCurrency.HeaderText = "�ұ�";
            this.colGDCurrency.Name = "colGDCurrency";
            this.colGDCurrency.ReadOnly = true;
            // 
            // colGDAmount
            // 
            this.colGDAmount.DataPropertyName = "GuaranteeDepositAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.colGDAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGDAmount.HeaderText = "��֤��";
            this.colGDAmount.Name = "colGDAmount";
            this.colGDAmount.ReadOnly = true;
            // 
            // colDepositDate
            // 
            this.colDepositDate.DataPropertyName = "DepositDate";
            dataGridViewCellStyle2.Format = "d";
            this.colDepositDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDepositDate.HeaderText = "��֤����";
            this.colDepositDate.Name = "colDepositDate";
            this.colDepositDate.ReadOnly = true;
            // 
            // groupPanelGuaranteePanel
            // 
            this.groupPanelGuaranteePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelGuaranteePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelGuaranteePanel.Controls.Add(lblDepositDate);
            this.groupPanelGuaranteePanel.Controls.Add(this.diDepositDate);
            this.groupPanelGuaranteePanel.Controls.Add(lblGDComment);
            this.groupPanelGuaranteePanel.Controls.Add(this.tbGDComment);
            this.groupPanelGuaranteePanel.Controls.Add(lblGDCreateUserName);
            this.groupPanelGuaranteePanel.Controls.Add(this.tbGDCreateUserName);
            this.groupPanelGuaranteePanel.Controls.Add(this.btnGDUpdate);
            this.groupPanelGuaranteePanel.Controls.Add(this.btnGDRefresh);
            this.groupPanelGuaranteePanel.Controls.Add(this.btnGDDelete);
            this.groupPanelGuaranteePanel.Controls.Add(this.btnGDSave);
            this.groupPanelGuaranteePanel.Controls.Add(this.btnGDNew);
            this.groupPanelGuaranteePanel.Controls.Add(lblGuaranteeDeposit);
            this.groupPanelGuaranteePanel.Controls.Add(this.tbGDAmount);
            this.groupPanelGuaranteePanel.Controls.Add(this.cbGDCurr);
            this.groupPanelGuaranteePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelGuaranteePanel.Location = new System.Drawing.Point(1, 1);
            this.groupPanelGuaranteePanel.Name = "groupPanelGuaranteePanel";
            this.groupPanelGuaranteePanel.Size = new System.Drawing.Size(584, 232);
            this.groupPanelGuaranteePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.groupPanelGuaranteePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelGuaranteePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelGuaranteePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.groupPanelGuaranteePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelGuaranteePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelGuaranteePanel.Style.GradientAngle = 90;
            this.groupPanelGuaranteePanel.TabIndex = 0;
            // 
            // diDepositDate
            // 
            // 
            // 
            // 
            this.diDepositDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diDepositDate.ButtonDropDown.Visible = true;
            this.diDepositDate.ButtonFreeText.Checked = true;
            this.diDepositDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gdBindingSource, "DepositDate", true));
            this.diDepositDate.FreeTextEntryMode = true;
            this.diDepositDate.Location = new System.Drawing.Point(398, 12);
            // 
            // 
            // 
            this.diDepositDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diDepositDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diDepositDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diDepositDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diDepositDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diDepositDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.diDepositDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diDepositDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diDepositDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diDepositDate.MonthCalendar.TodayButtonVisible = true;
            this.diDepositDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diDepositDate.Name = "diDepositDate";
            this.diDepositDate.Size = new System.Drawing.Size(121, 20);
            this.diDepositDate.TabIndex = 32;
            this.gdValidator.SetValidator1(this.diDepositDate, this.requiredFieldValidator21);
            // 
            // gdBindingSource
            // 
            this.gdBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.GuaranteeDeposit);
            // 
            // tbGDComment
            // 
            // 
            // 
            // 
            this.tbGDComment.Border.Class = "TextBoxBorder";
            this.tbGDComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gdBindingSource, "Comment", true));
            this.tbGDComment.Location = new System.Drawing.Point(86, 74);
            this.tbGDComment.Multiline = true;
            this.tbGDComment.Name = "tbGDComment";
            this.tbGDComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGDComment.Size = new System.Drawing.Size(433, 102);
            this.tbGDComment.TabIndex = 30;
            // 
            // tbGDCreateUserName
            // 
            // 
            // 
            // 
            this.tbGDCreateUserName.Border.Class = "TextBoxBorder";
            this.tbGDCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gdBindingSource, "CreateUserName", true));
            this.tbGDCreateUserName.Location = new System.Drawing.Point(86, 46);
            this.tbGDCreateUserName.Name = "tbGDCreateUserName";
            this.tbGDCreateUserName.ReadOnly = true;
            this.tbGDCreateUserName.Size = new System.Drawing.Size(121, 20);
            this.tbGDCreateUserName.TabIndex = 18;
            // 
            // btnGDUpdate
            // 
            this.btnGDUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGDUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGDUpdate.Location = new System.Drawing.Point(259, 183);
            this.btnGDUpdate.Name = "btnGDUpdate";
            this.btnGDUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnGDUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGDUpdate.TabIndex = 5;
            this.btnGDUpdate.Text = "�༭";
            this.btnGDUpdate.Click += new System.EventHandler(this.UpdateGD);
            // 
            // btnGDRefresh
            // 
            this.btnGDRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGDRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGDRefresh.Location = new System.Drawing.Point(99, 183);
            this.btnGDRefresh.Name = "btnGDRefresh";
            this.btnGDRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnGDRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGDRefresh.TabIndex = 3;
            this.btnGDRefresh.Text = "ˢ��";
            this.btnGDRefresh.Click += new System.EventHandler(this.RefreshGDs);
            // 
            // btnGDDelete
            // 
            this.btnGDDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGDDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGDDelete.Location = new System.Drawing.Point(421, 183);
            this.btnGDDelete.Name = "btnGDDelete";
            this.btnGDDelete.Size = new System.Drawing.Size(75, 23);
            this.btnGDDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGDDelete.TabIndex = 7;
            this.btnGDDelete.Text = "ɾ��";
            this.btnGDDelete.Click += new System.EventHandler(this.DeleteGD);
            // 
            // btnGDSave
            // 
            this.btnGDSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGDSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGDSave.Location = new System.Drawing.Point(340, 183);
            this.btnGDSave.Name = "btnGDSave";
            this.btnGDSave.Size = new System.Drawing.Size(75, 23);
            this.btnGDSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGDSave.TabIndex = 6;
            this.btnGDSave.Text = "����";
            this.btnGDSave.Click += new System.EventHandler(this.SaveGD);
            // 
            // btnGDNew
            // 
            this.btnGDNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGDNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGDNew.Location = new System.Drawing.Point(178, 183);
            this.btnGDNew.Name = "btnGDNew";
            this.btnGDNew.Size = new System.Drawing.Size(75, 23);
            this.btnGDNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGDNew.TabIndex = 4;
            this.btnGDNew.Text = "�½�";
            this.btnGDNew.Click += new System.EventHandler(this.NewGD);
            // 
            // tbGDAmount
            // 
            // 
            // 
            // 
            this.tbGDAmount.Border.Class = "TextBoxBorder";
            this.tbGDAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gdBindingSource, "GuaranteeDepositAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbGDAmount.Location = new System.Drawing.Point(145, 14);
            this.tbGDAmount.Name = "tbGDAmount";
            this.tbGDAmount.Size = new System.Drawing.Size(100, 20);
            this.tbGDAmount.TabIndex = 2;
            this.gdValidator.SetValidator1(this.tbGDAmount, this.requiredFieldValidator20);
            // 
            // cbGDCurr
            // 
            this.cbGDCurr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGDCurr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGDCurr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gdBindingSource, "GuaranteeDepositCurrency", true));
            this.cbGDCurr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGDCurr.FormattingEnabled = true;
            this.cbGDCurr.Location = new System.Drawing.Point(86, 14);
            this.cbGDCurr.Name = "cbGDCurr";
            this.cbGDCurr.Size = new System.Drawing.Size(53, 21);
            this.cbGDCurr.TabIndex = 1;
            this.gdValidator.SetValidator1(this.cbGDCurr, this.requiredFieldValidator9);
            // 
            // itemGuaranteeDeposit
            // 
            this.itemGuaranteeDeposit.AttachedControl = this.tabPanelGD;
            this.itemGuaranteeDeposit.Name = "itemGuaranteeDeposit";
            this.itemGuaranteeDeposit.Text = "��֤��";
            // 
            // tabPanelReview
            // 
            this.tabPanelReview.Controls.Add(this.dgvReviews);
            this.tabPanelReview.Controls.Add(this.groupPanelReview);
            this.tabPanelReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelReview.Location = new System.Drawing.Point(0, 26);
            this.tabPanelReview.Name = "tabPanelReview";
            this.tabPanelReview.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelReview.Size = new System.Drawing.Size(586, 588);
            this.tabPanelReview.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelReview.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelReview.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelReview.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelReview.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelReview.Style.GradientAngle = 90;
            this.tabPanelReview.TabIndex = 5;
            this.tabPanelReview.TabItem = this.tabItemReview;
            // 
            // dgvReviews
            // 
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.AllowUserToOrderColumns = true;
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReviewNo,
            this.colReviewStatus,
            this.colReviewUser,
            this.colReviewDate,
            this.colReviewComment});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReviews.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReviews.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvReviews.Location = new System.Drawing.Point(1, 368);
            this.dgvReviews.MultiSelect = false;
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReviews.Size = new System.Drawing.Size(584, 219);
            this.dgvReviews.TabIndex = 1;
            this.dgvReviews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectReview);
            // 
            // colReviewNo
            // 
            this.colReviewNo.DataPropertyName = "ReviewNo";
            this.colReviewNo.HeaderText = "Э��������";
            this.colReviewNo.Name = "colReviewNo";
            this.colReviewNo.ReadOnly = true;
            // 
            // colReviewStatus
            // 
            this.colReviewStatus.DataPropertyName = "ReviewStatus";
            this.colReviewStatus.HeaderText = "״̬";
            this.colReviewStatus.Name = "colReviewStatus";
            this.colReviewStatus.ReadOnly = true;
            // 
            // colReviewUser
            // 
            this.colReviewUser.DataPropertyName = "CreateUserName";
            this.colReviewUser.HeaderText = "������";
            this.colReviewUser.Name = "colReviewUser";
            this.colReviewUser.ReadOnly = true;
            // 
            // colReviewDate
            // 
            this.colReviewDate.DataPropertyName = "ReviewDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colReviewDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colReviewDate.HeaderText = "Э����";
            this.colReviewDate.Name = "colReviewDate";
            this.colReviewDate.ReadOnly = true;
            // 
            // colReviewComment
            // 
            this.colReviewComment.DataPropertyName = "Comment";
            this.colReviewComment.HeaderText = "��ע";
            this.colReviewComment.Name = "colReviewComment";
            this.colReviewComment.ReadOnly = true;
            // 
            // groupPanelReview
            // 
            this.groupPanelReview.AutoScroll = true;
            this.groupPanelReview.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelReview.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelReview.Controls.Add(this.cbIsNonRecoarse);
            this.groupPanelReview.Controls.Add(this.cbIsBuyer);
            this.groupPanelReview.Controls.Add(this.cbIsSeller);
            this.groupPanelReview.Controls.Add(this.cbIsInternational);
            this.groupPanelReview.Controls.Add(this.cbIsLocal);
            this.groupPanelReview.Controls.Add(lblIsNotice);
            this.groupPanelReview.Controls.Add(this.cbIsNotice);
            this.groupPanelReview.Controls.Add(this.cbIsRecoarse);
            this.groupPanelReview.Controls.Add(requestFinanceTypeLabel);
            this.groupPanelReview.Controls.Add(this.requestFinanceTypeCheckedListBox);
            this.groupPanelReview.Controls.Add(requestFinanceType2Label);
            this.groupPanelReview.Controls.Add(this.requestFinanceType2ComboBox);
            this.groupPanelReview.Controls.Add(requestFinancePeriodLabel);
            this.groupPanelReview.Controls.Add(this.requestFinancePeriodTextBox);
            this.groupPanelReview.Controls.Add(requestCommissionRateLabel);
            this.groupPanelReview.Controls.Add(this.requestCommissionRateTextBox);
            this.groupPanelReview.Controls.Add(requestAmountLabel);
            this.groupPanelReview.Controls.Add(this.requestAmountTextBox);
            this.groupPanelReview.Controls.Add(this.requestCurrencyComboBox);
            this.groupPanelReview.Controls.Add(this.btnReviewUpdate);
            this.groupPanelReview.Controls.Add(this.btnReviewRefresh);
            this.groupPanelReview.Controls.Add(this.btnReviewDelete);
            this.groupPanelReview.Controls.Add(this.btnReviewSave);
            this.groupPanelReview.Controls.Add(this.btnReviewNew);
            this.groupPanelReview.Controls.Add(commentLabel1);
            this.groupPanelReview.Controls.Add(this.commentTextBox);
            this.groupPanelReview.Controls.Add(createUserNameLabel);
            this.groupPanelReview.Controls.Add(this.tbReviewCreateUserName);
            this.groupPanelReview.Controls.Add(reviewDateLabel);
            this.groupPanelReview.Controls.Add(this.reviewDateDateTimePicker);
            this.groupPanelReview.Controls.Add(reviewStatusLabel);
            this.groupPanelReview.Controls.Add(this.reviewStatusComboBox);
            this.groupPanelReview.Controls.Add(reviewNoLabel);
            this.groupPanelReview.Controls.Add(this.reviewNoTextBox);
            this.groupPanelReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelReview.Location = new System.Drawing.Point(1, 1);
            this.groupPanelReview.Name = "groupPanelReview";
            this.groupPanelReview.Size = new System.Drawing.Size(584, 367);
            // 
            // 
            // 
            this.groupPanelReview.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelReview.Style.BackColorGradientAngle = 90;
            this.groupPanelReview.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelReview.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelReview.Style.BorderBottomWidth = 1;
            this.groupPanelReview.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelReview.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelReview.Style.BorderLeftWidth = 1;
            this.groupPanelReview.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelReview.Style.BorderRightWidth = 1;
            this.groupPanelReview.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelReview.Style.BorderTopWidth = 1;
            this.groupPanelReview.Style.Class = "";
            this.groupPanelReview.Style.CornerDiameter = 4;
            this.groupPanelReview.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelReview.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelReview.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelReview.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelReview.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelReview.StyleMouseOver.Class = "";
            this.groupPanelReview.TabIndex = 0;
            // 
            // cbIsNonRecoarse
            // 
            this.cbIsNonRecoarse.AutoSize = true;
            this.cbIsNonRecoarse.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsNonRecoarse.BackgroundStyle.Class = "";
            this.cbIsNonRecoarse.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reviewBindingSource, "IsNonRecoarse", true));
            this.cbIsNonRecoarse.Location = new System.Drawing.Point(343, 176);
            this.cbIsNonRecoarse.Name = "cbIsNonRecoarse";
            this.cbIsNonRecoarse.Size = new System.Drawing.Size(76, 16);
            this.cbIsNonRecoarse.TabIndex = 26;
            this.cbIsNonRecoarse.Text = "��׷��Ȩ";
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.ClientReview);
            // 
            // cbIsBuyer
            // 
            this.cbIsBuyer.AutoSize = true;
            this.cbIsBuyer.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsBuyer.BackgroundStyle.Class = "";
            this.cbIsBuyer.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reviewBindingSource, "IsBuyer", true));
            this.cbIsBuyer.Location = new System.Drawing.Point(233, 176);
            this.cbIsBuyer.Name = "cbIsBuyer";
            this.cbIsBuyer.Size = new System.Drawing.Size(51, 16);
            this.cbIsBuyer.TabIndex = 24;
            this.cbIsBuyer.Text = "��";
            // 
            // cbIsSeller
            // 
            this.cbIsSeller.AutoSize = true;
            this.cbIsSeller.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsSeller.BackgroundStyle.Class = "";
            this.cbIsSeller.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reviewBindingSource, "IsSeller", true));
            this.cbIsSeller.Location = new System.Drawing.Point(233, 154);
            this.cbIsSeller.Name = "cbIsSeller";
            this.cbIsSeller.Size = new System.Drawing.Size(51, 16);
            this.cbIsSeller.TabIndex = 23;
            this.cbIsSeller.Text = "����";
            // 
            // cbIsInternational
            // 
            this.cbIsInternational.AutoSize = true;
            this.cbIsInternational.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsInternational.BackgroundStyle.Class = "";
            this.cbIsInternational.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reviewBindingSource, "IsInternational", true));
            this.cbIsInternational.Location = new System.Drawing.Point(112, 176);
            this.cbIsInternational.Name = "cbIsInternational";
            this.cbIsInternational.Size = new System.Drawing.Size(51, 16);
            this.cbIsInternational.TabIndex = 22;
            this.cbIsInternational.Text = "����";
            // 
            // cbIsLocal
            // 
            this.cbIsLocal.AutoSize = true;
            this.cbIsLocal.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsLocal.BackgroundStyle.Class = "";
            this.cbIsLocal.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reviewBindingSource, "IsLocal", true));
            this.cbIsLocal.Location = new System.Drawing.Point(112, 154);
            this.cbIsLocal.Name = "cbIsLocal";
            this.cbIsLocal.Size = new System.Drawing.Size(51, 16);
            this.cbIsLocal.TabIndex = 21;
            this.cbIsLocal.Text = "����";
            // 
            // cbIsNotice
            // 
            this.cbIsNotice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "IsNotice", true));
            this.cbIsNotice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsNotice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsNotice.FormattingEnabled = true;
            this.cbIsNotice.Items.AddRange(new object[] {
            "������",
            "������"});
            this.cbIsNotice.Location = new System.Drawing.Point(343, 130);
            this.cbIsNotice.Name = "cbIsNotice";
            this.cbIsNotice.Size = new System.Drawing.Size(159, 21);
            this.cbIsNotice.TabIndex = 20;
            // 
            // cbIsRecoarse
            // 
            this.cbIsRecoarse.AutoSize = true;
            this.cbIsRecoarse.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsRecoarse.BackgroundStyle.Class = "";
            this.cbIsRecoarse.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reviewBindingSource, "IsRecoarse", true));
            this.cbIsRecoarse.Location = new System.Drawing.Point(343, 154);
            this.cbIsRecoarse.Name = "cbIsRecoarse";
            this.cbIsRecoarse.Size = new System.Drawing.Size(76, 16);
            this.cbIsRecoarse.TabIndex = 25;
            this.cbIsRecoarse.Text = "��׷��Ȩ";
            // 
            // requestFinanceTypeCheckedListBox
            // 
            this.requestFinanceTypeCheckedListBox.CheckOnClick = true;
            this.requestFinanceTypeCheckedListBox.FormattingEnabled = true;
            this.requestFinanceTypeCheckedListBox.Items.AddRange(new object[] {
            "Ԥ����",
            "����",
            "����֤",
            "����"});
            this.requestFinanceTypeCheckedListBox.Location = new System.Drawing.Point(343, 37);
            this.requestFinanceTypeCheckedListBox.Name = "requestFinanceTypeCheckedListBox";
            this.requestFinanceTypeCheckedListBox.Size = new System.Drawing.Size(159, 64);
            this.requestFinanceTypeCheckedListBox.TabIndex = 12;
            // 
            // requestFinanceType2ComboBox
            // 
            this.requestFinanceType2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "RequestFinanceType2", true));
            this.requestFinanceType2ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.requestFinanceType2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestFinanceType2ComboBox.FormattingEnabled = true;
            this.requestFinanceType2ComboBox.Items.AddRange(new object[] {
            "������",
            "��������"});
            this.requestFinanceType2ComboBox.Location = new System.Drawing.Point(343, 105);
            this.requestFinanceType2ComboBox.Name = "requestFinanceType2ComboBox";
            this.requestFinanceType2ComboBox.Size = new System.Drawing.Size(159, 21);
            this.requestFinanceType2ComboBox.TabIndex = 18;
            // 
            // requestFinancePeriodTextBox
            // 
            // 
            // 
            // 
            this.requestFinancePeriodTextBox.Border.Class = "TextBoxBorder";
            this.requestFinancePeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "RequestFinancePeriod", true));
            this.requestFinancePeriodTextBox.Location = new System.Drawing.Point(112, 106);
            this.requestFinancePeriodTextBox.Name = "requestFinancePeriodTextBox";
            this.requestFinancePeriodTextBox.Size = new System.Drawing.Size(121, 20);
            this.requestFinancePeriodTextBox.TabIndex = 14;
            // 
            // requestCommissionRateTextBox
            // 
            // 
            // 
            // 
            this.requestCommissionRateTextBox.Border.Class = "TextBoxBorder";
            this.requestCommissionRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "RequestCommissionRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p"));
            this.requestCommissionRateTextBox.Location = new System.Drawing.Point(112, 81);
            this.requestCommissionRateTextBox.Name = "requestCommissionRateTextBox";
            this.requestCommissionRateTextBox.Size = new System.Drawing.Size(121, 20);
            this.requestCommissionRateTextBox.TabIndex = 10;
            // 
            // requestAmountTextBox
            // 
            // 
            // 
            // 
            this.requestAmountTextBox.Border.Class = "TextBoxBorder";
            this.requestAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "RequestAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.requestAmountTextBox.Location = new System.Drawing.Point(402, 7);
            this.requestAmountTextBox.Name = "requestAmountTextBox";
            this.requestAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestAmountTextBox.TabIndex = 4;
            // 
            // requestCurrencyComboBox
            // 
            this.requestCurrencyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.requestCurrencyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.requestCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reviewBindingSource, "RequestCurrency", true));
            this.requestCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.requestCurrencyComboBox.FormattingEnabled = true;
            this.requestCurrencyComboBox.Location = new System.Drawing.Point(343, 7);
            this.requestCurrencyComboBox.Name = "requestCurrencyComboBox";
            this.requestCurrencyComboBox.Size = new System.Drawing.Size(53, 21);
            this.requestCurrencyComboBox.TabIndex = 3;
            // 
            // btnReviewUpdate
            // 
            this.btnReviewUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReviewUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReviewUpdate.Location = new System.Drawing.Point(272, 309);
            this.btnReviewUpdate.Name = "btnReviewUpdate";
            this.btnReviewUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnReviewUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReviewUpdate.TabIndex = 31;
            this.btnReviewUpdate.Text = "�༭";
            this.btnReviewUpdate.Click += new System.EventHandler(this.UpdateReivew);
            // 
            // btnReviewRefresh
            // 
            this.btnReviewRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReviewRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReviewRefresh.Location = new System.Drawing.Point(112, 309);
            this.btnReviewRefresh.Name = "btnReviewRefresh";
            this.btnReviewRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnReviewRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReviewRefresh.TabIndex = 29;
            this.btnReviewRefresh.Text = "ˢ��";
            this.btnReviewRefresh.Click += new System.EventHandler(this.RefreshReviews);
            // 
            // btnReviewDelete
            // 
            this.btnReviewDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReviewDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReviewDelete.Location = new System.Drawing.Point(434, 309);
            this.btnReviewDelete.Name = "btnReviewDelete";
            this.btnReviewDelete.Size = new System.Drawing.Size(75, 23);
            this.btnReviewDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReviewDelete.TabIndex = 33;
            this.btnReviewDelete.Text = "ɾ��";
            this.btnReviewDelete.Click += new System.EventHandler(this.DeleteReview);
            // 
            // btnReviewSave
            // 
            this.btnReviewSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReviewSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReviewSave.Location = new System.Drawing.Point(353, 309);
            this.btnReviewSave.Name = "btnReviewSave";
            this.btnReviewSave.Size = new System.Drawing.Size(75, 23);
            this.btnReviewSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReviewSave.TabIndex = 32;
            this.btnReviewSave.Text = "����";
            this.btnReviewSave.Click += new System.EventHandler(this.SaveReview);
            // 
            // btnReviewNew
            // 
            this.btnReviewNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReviewNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReviewNew.Location = new System.Drawing.Point(191, 309);
            this.btnReviewNew.Name = "btnReviewNew";
            this.btnReviewNew.Size = new System.Drawing.Size(75, 23);
            this.btnReviewNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReviewNew.TabIndex = 30;
            this.btnReviewNew.Text = "�½�";
            this.btnReviewNew.Click += new System.EventHandler(this.NewReview);
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(112, 198);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(390, 102);
            this.commentTextBox.TabIndex = 28;
            // 
            // tbReviewCreateUserName
            // 
            // 
            // 
            // 
            this.tbReviewCreateUserName.Border.Class = "TextBoxBorder";
            this.tbReviewCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "CreateUserName", true));
            this.tbReviewCreateUserName.Location = new System.Drawing.Point(112, 128);
            this.tbReviewCreateUserName.Name = "tbReviewCreateUserName";
            this.tbReviewCreateUserName.ReadOnly = true;
            this.tbReviewCreateUserName.Size = new System.Drawing.Size(121, 20);
            this.tbReviewCreateUserName.TabIndex = 16;
            // 
            // reviewDateDateTimePicker
            // 
            // 
            // 
            // 
            this.reviewDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.reviewDateDateTimePicker.ButtonDropDown.Visible = true;
            this.reviewDateDateTimePicker.ButtonFreeText.Checked = true;
            this.reviewDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "ReviewDate", true));
            this.reviewDateDateTimePicker.FreeTextEntryMode = true;
            this.reviewDateDateTimePicker.Location = new System.Drawing.Point(112, 55);
            // 
            // 
            // 
            this.reviewDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.reviewDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.reviewDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.reviewDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.reviewDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.reviewDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.reviewDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.reviewDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.reviewDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.reviewDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.reviewDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.reviewDateDateTimePicker.Name = "reviewDateDateTimePicker";
            this.reviewDateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.reviewDateDateTimePicker.TabIndex = 8;
            this.reviewValidator.SetValidator1(this.reviewDateDateTimePicker, this.requiredFieldValidator19);
            // 
            // reviewStatusComboBox
            // 
            this.reviewStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "ReviewStatus", true));
            this.reviewStatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reviewStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reviewStatusComboBox.FormattingEnabled = true;
            this.reviewStatusComboBox.Items.AddRange(new object[] {
            "����Ч",
            "��ʧЧ"});
            this.reviewStatusComboBox.Location = new System.Drawing.Point(112, 31);
            this.reviewStatusComboBox.Name = "reviewStatusComboBox";
            this.reviewStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.reviewStatusComboBox.TabIndex = 6;
            this.reviewValidator.SetValidator1(this.reviewStatusComboBox, this.requiredFieldValidator7);
            // 
            // reviewNoTextBox
            // 
            // 
            // 
            // 
            this.reviewNoTextBox.Border.Class = "TextBoxBorder";
            this.reviewNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "ReviewNo", true));
            this.reviewNoTextBox.Location = new System.Drawing.Point(112, 6);
            this.reviewNoTextBox.Name = "reviewNoTextBox";
            this.reviewNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.reviewNoTextBox.TabIndex = 1;
            this.reviewValidator.SetValidator1(this.reviewNoTextBox, this.regularExpressionValidator2);
            // 
            // tabItemReview
            // 
            this.tabItemReview.AttachedControl = this.tabPanelReview;
            this.tabItemReview.Name = "tabItemReview";
            this.tabItemReview.Text = "Э�����";
            // 
            // tabPanelContract
            // 
            this.tabPanelContract.Controls.Add(this.dgvContracts);
            this.tabPanelContract.Controls.Add(this.groupPanelContract);
            this.tabPanelContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelContract.Location = new System.Drawing.Point(0, 26);
            this.tabPanelContract.Name = "tabPanelContract";
            this.tabPanelContract.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelContract.Size = new System.Drawing.Size(586, 588);
            this.tabPanelContract.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelContract.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelContract.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelContract.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelContract.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelContract.Style.GradientAngle = 90;
            this.tabPanelContract.TabIndex = 4;
            this.tabPanelContract.TabItem = this.tabItemContract;
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.AllowUserToOrderColumns = true;
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContractCode,
            this.colContractType,
            this.colContractValueDate,
            this.colContractDueDate,
            this.colContractStatus,
            this.colCreateUserName});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContracts.Location = new System.Drawing.Point(1, 236);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvContracts.RowTemplate.Height = 23;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(584, 351);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectContract);
            // 
            // colContractCode
            // 
            this.colContractCode.DataPropertyName = "ContractCode";
            this.colContractCode.HeaderText = "��ͬ��";
            this.colContractCode.Name = "colContractCode";
            this.colContractCode.ReadOnly = true;
            // 
            // colContractType
            // 
            this.colContractType.DataPropertyName = "ContractType";
            this.colContractType.HeaderText = "��ͬ����";
            this.colContractType.Name = "colContractType";
            this.colContractType.ReadOnly = true;
            // 
            // colContractValueDate
            // 
            this.colContractValueDate.DataPropertyName = "ContractValueDate";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.colContractValueDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colContractValueDate.HeaderText = "��Ч��";
            this.colContractValueDate.Name = "colContractValueDate";
            this.colContractValueDate.ReadOnly = true;
            // 
            // colContractDueDate
            // 
            this.colContractDueDate.DataPropertyName = "ContractDueDate";
            dataGridViewCellStyle9.Format = "d";
            this.colContractDueDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.colContractDueDate.HeaderText = "������";
            this.colContractDueDate.Name = "colContractDueDate";
            this.colContractDueDate.ReadOnly = true;
            // 
            // colContractStatus
            // 
            this.colContractStatus.DataPropertyName = "ContractStatus";
            this.colContractStatus.HeaderText = "��ͬ״̬";
            this.colContractStatus.Name = "colContractStatus";
            this.colContractStatus.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "������";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // groupPanelContract
            // 
            this.groupPanelContract.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelContract.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelContract.Controls.Add(this.isSignedCheckBox);
            this.groupPanelContract.Controls.Add(lblComment);
            this.groupPanelContract.Controls.Add(this.tbComment);
            this.groupPanelContract.Controls.Add(lblContractType);
            this.groupPanelContract.Controls.Add(this.cbContractType);
            this.groupPanelContract.Controls.Add(this.btnContractUpdate);
            this.groupPanelContract.Controls.Add(this.btnContractRefresh);
            this.groupPanelContract.Controls.Add(this.btnContractDelete);
            this.groupPanelContract.Controls.Add(this.btnContractSave);
            this.groupPanelContract.Controls.Add(this.btnContractNew);
            this.groupPanelContract.Controls.Add(lblContractCode);
            this.groupPanelContract.Controls.Add(lblContractCreateUserName);
            this.groupPanelContract.Controls.Add(this.tbContractCode);
            this.groupPanelContract.Controls.Add(this.tbContractCreateUserName);
            this.groupPanelContract.Controls.Add(lblContractStatus);
            this.groupPanelContract.Controls.Add(this.tbContractStatus);
            this.groupPanelContract.Controls.Add(lblContractValueDate);
            this.groupPanelContract.Controls.Add(this.diContractDueDate);
            this.groupPanelContract.Controls.Add(this.diContractValueDate);
            this.groupPanelContract.Controls.Add(lblContractDueDate);
            this.groupPanelContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelContract.Location = new System.Drawing.Point(1, 1);
            this.groupPanelContract.Name = "groupPanelContract";
            this.groupPanelContract.Size = new System.Drawing.Size(584, 235);
            // 
            // 
            // 
            this.groupPanelContract.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelContract.Style.BackColorGradientAngle = 90;
            this.groupPanelContract.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelContract.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderBottomWidth = 1;
            this.groupPanelContract.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelContract.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderLeftWidth = 1;
            this.groupPanelContract.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderRightWidth = 1;
            this.groupPanelContract.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContract.Style.BorderTopWidth = 1;
            this.groupPanelContract.Style.Class = "";
            this.groupPanelContract.Style.CornerDiameter = 4;
            this.groupPanelContract.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelContract.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelContract.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelContract.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelContract.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelContract.StyleMouseOver.Class = "";
            this.groupPanelContract.TabIndex = 14;
            // 
            // isSignedCheckBox
            // 
            this.isSignedCheckBox.AutoSize = true;
            this.isSignedCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isSignedCheckBox.BackgroundStyle.Class = "";
            this.isSignedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contractBindingSource, "IsSigned", true));
            this.isSignedCheckBox.Location = new System.Drawing.Point(312, 59);
            this.isSignedCheckBox.Name = "isSignedCheckBox";
            this.isSignedCheckBox.Size = new System.Drawing.Size(76, 16);
            this.isSignedCheckBox.TabIndex = 20;
            this.isSignedCheckBox.Text = "�Ƿ�ǩ��";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Contract);
            // 
            // tbComment
            // 
            // 
            // 
            // 
            this.tbComment.Border.Class = "TextBoxBorder";
            this.tbComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Comment", true));
            this.tbComment.Location = new System.Drawing.Point(99, 106);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComment.Size = new System.Drawing.Size(399, 54);
            this.tbComment.TabIndex = 17;
            this.tbComment.WatermarkText = "���и�����ͬ���뱸ע�ڴˡ�";
            // 
            // cbContractType
            // 
            this.cbContractType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractType", true));
            this.cbContractType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Items.AddRange(new object[] {
            "�º�ͬ",
            "�ɺ�ͬ"});
            this.cbContractType.Location = new System.Drawing.Point(99, 4);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(143, 21);
            this.cbContractType.TabIndex = 1;
            this.contractValidator.SetValidator1(this.cbContractType, this.requiredFieldValidator3);
            // 
            // btnContractUpdate
            // 
            this.btnContractUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractUpdate.Location = new System.Drawing.Point(259, 183);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContractUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractUpdate.TabIndex = 14;
            this.btnContractUpdate.Text = "�༭";
            this.btnContractUpdate.Click += new System.EventHandler(this.UpdateContract);
            // 
            // btnContractRefresh
            // 
            this.btnContractRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractRefresh.Location = new System.Drawing.Point(99, 183);
            this.btnContractRefresh.Name = "btnContractRefresh";
            this.btnContractRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnContractRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractRefresh.TabIndex = 12;
            this.btnContractRefresh.Text = "ˢ��";
            this.btnContractRefresh.Click += new System.EventHandler(this.RefreshContracts);
            // 
            // btnContractDelete
            // 
            this.btnContractDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractDelete.Location = new System.Drawing.Point(421, 183);
            this.btnContractDelete.Name = "btnContractDelete";
            this.btnContractDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContractDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractDelete.TabIndex = 16;
            this.btnContractDelete.Text = "ɾ��";
            this.btnContractDelete.Click += new System.EventHandler(this.DeleteContract);
            // 
            // btnContractSave
            // 
            this.btnContractSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractSave.Location = new System.Drawing.Point(340, 183);
            this.btnContractSave.Name = "btnContractSave";
            this.btnContractSave.Size = new System.Drawing.Size(75, 23);
            this.btnContractSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractSave.TabIndex = 15;
            this.btnContractSave.Text = "����";
            this.btnContractSave.Click += new System.EventHandler(this.SaveContract);
            // 
            // btnContractNew
            // 
            this.btnContractNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractNew.Location = new System.Drawing.Point(178, 183);
            this.btnContractNew.Name = "btnContractNew";
            this.btnContractNew.Size = new System.Drawing.Size(75, 23);
            this.btnContractNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractNew.TabIndex = 13;
            this.btnContractNew.Text = "�½�";
            this.btnContractNew.Click += new System.EventHandler(this.NewContract);
            // 
            // tbContractCode
            // 
            // 
            // 
            // 
            this.tbContractCode.Border.Class = "TextBoxBorder";
            this.tbContractCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractCode", true));
            this.tbContractCode.Location = new System.Drawing.Point(99, 30);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(143, 20);
            this.tbContractCode.TabIndex = 5;
            this.contractValidator.SetValidator1(this.tbContractCode, this.requiredFieldValidator11);
            this.contractValidator.SetValidator2(this.tbContractCode, this.regularExpressionValidator10);
            // 
            // tbContractCreateUserName
            // 
            // 
            // 
            // 
            this.tbContractCreateUserName.Border.Class = "TextBoxBorder";
            this.tbContractCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CreateUserName", true));
            this.tbContractCreateUserName.Location = new System.Drawing.Point(99, 82);
            this.tbContractCreateUserName.Name = "tbContractCreateUserName";
            this.tbContractCreateUserName.ReadOnly = true;
            this.tbContractCreateUserName.Size = new System.Drawing.Size(143, 20);
            this.tbContractCreateUserName.TabIndex = 11;
            // 
            // tbContractStatus
            // 
            // 
            // 
            // 
            this.tbContractStatus.Border.Class = "TextBoxBorder";
            this.tbContractStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractStatus", true));
            this.tbContractStatus.Location = new System.Drawing.Point(99, 56);
            this.tbContractStatus.Name = "tbContractStatus";
            this.tbContractStatus.ReadOnly = true;
            this.tbContractStatus.Size = new System.Drawing.Size(143, 20);
            this.tbContractStatus.TabIndex = 9;
            // 
            // diContractDueDate
            // 
            // 
            // 
            // 
            this.diContractDueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diContractDueDate.ButtonDropDown.Visible = true;
            this.diContractDueDate.ButtonFreeText.Checked = true;
            this.diContractDueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractDueDate", true));
            this.diContractDueDate.FreeTextEntryMode = true;
            this.diContractDueDate.Location = new System.Drawing.Point(365, 30);
            // 
            // 
            // 
            this.diContractDueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diContractDueDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diContractDueDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diContractDueDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diContractDueDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diContractDueDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diContractDueDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diContractDueDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diContractDueDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diContractDueDate.MonthCalendar.TodayButtonVisible = true;
            this.diContractDueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diContractDueDate.Name = "diContractDueDate";
            this.diContractDueDate.Size = new System.Drawing.Size(133, 20);
            this.diContractDueDate.TabIndex = 7;
            this.contractValidator.SetValidator1(this.diContractDueDate, this.requiredFieldValidator13);
            this.contractValidator.SetValidator2(this.diContractDueDate, this.compareValidator1);
            // 
            // diContractValueDate
            // 
            // 
            // 
            // 
            this.diContractValueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diContractValueDate.ButtonDropDown.Visible = true;
            this.diContractValueDate.ButtonFreeText.Checked = true;
            this.diContractValueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractValueDate", true));
            this.diContractValueDate.FreeTextEntryMode = true;
            this.diContractValueDate.Location = new System.Drawing.Point(365, 4);
            // 
            // 
            // 
            this.diContractValueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diContractValueDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diContractValueDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diContractValueDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diContractValueDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diContractValueDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diContractValueDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diContractValueDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diContractValueDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diContractValueDate.MonthCalendar.TodayButtonVisible = true;
            this.diContractValueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diContractValueDate.Name = "diContractValueDate";
            this.diContractValueDate.Size = new System.Drawing.Size(133, 20);
            this.diContractValueDate.TabIndex = 3;
            this.contractValidator.SetValidator1(this.diContractValueDate, this.requiredFieldValidator12);
            this.diContractValueDate.ValueChanged += new System.EventHandler(this.DiContractValueDateValueChanged);
            // 
            // tabItemContract
            // 
            this.tabItemContract.AttachedControl = this.tabPanelContract;
            this.tabItemContract.Name = "tabItemContract";
            this.tabItemContract.Text = "�����ͬ";
            // 
            // tabPanelClientCreditLine
            // 
            this.tabPanelClientCreditLine.AutoScroll = true;
            this.tabPanelClientCreditLine.Controls.Add(this.dgvClientCreditLines);
            this.tabPanelClientCreditLine.Controls.Add(this.groupPanelClientCreditLine);
            this.tabPanelClientCreditLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelClientCreditLine.Location = new System.Drawing.Point(0, 26);
            this.tabPanelClientCreditLine.Name = "tabPanelClientCreditLine";
            this.tabPanelClientCreditLine.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelClientCreditLine.Size = new System.Drawing.Size(586, 588);
            this.tabPanelClientCreditLine.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelClientCreditLine.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelClientCreditLine.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelClientCreditLine.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelClientCreditLine.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelClientCreditLine.Style.GradientAngle = 90;
            this.tabPanelClientCreditLine.TabIndex = 2;
            this.tabPanelClientCreditLine.TabItem = this.tabItemClientCreditLine;
            // 
            // dgvClientCreditLines
            // 
            this.dgvClientCreditLines.AllowUserToAddRows = false;
            this.dgvClientCreditLines.AllowUserToDeleteRows = false;
            this.dgvClientCreditLines.AllowUserToOrderColumns = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientCreditLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientCreditLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientCreditLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCreditLineType,
            this.colCreditLineCurrency,
            this.colCreditLine,
            this.colPeriodBegin,
            this.colPeriodEnd,
            this.colApproveNo,
            this.colApproveType,
            this.colCreditLineStatus,
            this.colFreezeReason,
            this.colFreezer,
            this.colFreezeDate,
            this.colUnfreezeReason,
            this.colUnfreezer,
            this.colUnfreezeDate,
            this.colComment});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientCreditLines.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvClientCreditLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientCreditLines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClientCreditLines.Location = new System.Drawing.Point(1, 362);
            this.dgvClientCreditLines.MultiSelect = false;
            this.dgvClientCreditLines.Name = "dgvClientCreditLines";
            this.dgvClientCreditLines.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientCreditLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvClientCreditLines.RowTemplate.Height = 23;
            this.dgvClientCreditLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientCreditLines.Size = new System.Drawing.Size(584, 225);
            this.dgvClientCreditLines.TabIndex = 0;
            this.dgvClientCreditLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectClientCreditLine);
            // 
            // colCreditLineType
            // 
            this.colCreditLineType.DataPropertyName = "CreditLineType";
            this.colCreditLineType.HeaderText = "�������";
            this.colCreditLineType.Name = "colCreditLineType";
            this.colCreditLineType.ReadOnly = true;
            // 
            // colCreditLineCurrency
            // 
            this.colCreditLineCurrency.DataPropertyName = "CreditLineCurrency";
            this.colCreditLineCurrency.HeaderText = "��ȱ���";
            this.colCreditLineCurrency.Name = "colCreditLineCurrency";
            this.colCreditLineCurrency.ReadOnly = true;
            // 
            // colCreditLine
            // 
            this.colCreditLine.DataPropertyName = "CreditLine";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.colCreditLine.DefaultCellStyle = dataGridViewCellStyle13;
            this.colCreditLine.HeaderText = "�������";
            this.colCreditLine.Name = "colCreditLine";
            this.colCreditLine.ReadOnly = true;
            // 
            // colPeriodBegin
            // 
            this.colPeriodBegin.DataPropertyName = "PeriodBegin";
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.colPeriodBegin.DefaultCellStyle = dataGridViewCellStyle14;
            this.colPeriodBegin.HeaderText = "��Ч��(ʼ)";
            this.colPeriodBegin.Name = "colPeriodBegin";
            this.colPeriodBegin.ReadOnly = true;
            // 
            // colPeriodEnd
            // 
            this.colPeriodEnd.DataPropertyName = "PeriodEnd";
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.colPeriodEnd.DefaultCellStyle = dataGridViewCellStyle15;
            this.colPeriodEnd.HeaderText = "��Ч��(��)";
            this.colPeriodEnd.Name = "colPeriodEnd";
            this.colPeriodEnd.ReadOnly = true;
            // 
            // colApproveNo
            // 
            this.colApproveNo.DataPropertyName = "ApproveNo";
            this.colApproveNo.HeaderText = "���ű��";
            this.colApproveNo.Name = "colApproveNo";
            this.colApproveNo.ReadOnly = true;
            // 
            // colApproveType
            // 
            this.colApproveType.DataPropertyName = "ApproveType";
            this.colApproveType.HeaderText = "��������";
            this.colApproveType.Name = "colApproveType";
            this.colApproveType.ReadOnly = true;
            // 
            // colCreditLineStatus
            // 
            this.colCreditLineStatus.DataPropertyName = "CreditLineStatus";
            this.colCreditLineStatus.HeaderText = "���״̬";
            this.colCreditLineStatus.Name = "colCreditLineStatus";
            this.colCreditLineStatus.ReadOnly = true;
            // 
            // colFreezeReason
            // 
            this.colFreezeReason.DataPropertyName = "FreezeReason";
            this.colFreezeReason.HeaderText = "����ԭ��";
            this.colFreezeReason.Name = "colFreezeReason";
            this.colFreezeReason.ReadOnly = true;
            // 
            // colFreezer
            // 
            this.colFreezer.DataPropertyName = "Freezer";
            this.colFreezer.HeaderText = "������";
            this.colFreezer.Name = "colFreezer";
            this.colFreezer.ReadOnly = true;
            // 
            // colFreezeDate
            // 
            this.colFreezeDate.DataPropertyName = "FreezeDate";
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.colFreezeDate.DefaultCellStyle = dataGridViewCellStyle16;
            this.colFreezeDate.HeaderText = "��������";
            this.colFreezeDate.Name = "colFreezeDate";
            this.colFreezeDate.ReadOnly = true;
            // 
            // colUnfreezeReason
            // 
            this.colUnfreezeReason.DataPropertyName = "UnfreezeReason";
            this.colUnfreezeReason.HeaderText = "�ⶳԭ��";
            this.colUnfreezeReason.Name = "colUnfreezeReason";
            this.colUnfreezeReason.ReadOnly = true;
            // 
            // colUnfreezer
            // 
            this.colUnfreezer.DataPropertyName = "Unfreezer";
            this.colUnfreezer.HeaderText = "�ⶳ��";
            this.colUnfreezer.Name = "colUnfreezer";
            this.colUnfreezer.ReadOnly = true;
            // 
            // colUnfreezeDate
            // 
            this.colUnfreezeDate.DataPropertyName = "UnfreezeDate";
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.colUnfreezeDate.DefaultCellStyle = dataGridViewCellStyle17;
            this.colUnfreezeDate.HeaderText = "�ⶳ����";
            this.colUnfreezeDate.Name = "colUnfreezeDate";
            this.colUnfreezeDate.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "��ע";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // groupPanelClientCreditLine
            // 
            this.groupPanelClientCreditLine.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientCreditLine.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelClientCreditLine.Controls.Add(labelX1);
            this.groupPanelClientCreditLine.Controls.Add(this.tbCreditLineCreateUserName);
            this.groupPanelClientCreditLine.Controls.Add(this.tbGroupCreditLineCurr);
            this.groupPanelClientCreditLine.Controls.Add(this.btnGroupCreditLineSelect);
            this.groupPanelClientCreditLine.Controls.Add(lblGroupCreditLine);
            this.groupPanelClientCreditLine.Controls.Add(this.tbGroupCreditLine);
            this.groupPanelClientCreditLine.Controls.Add(this.btnClientCreditLineUpdate);
            this.groupPanelClientCreditLine.Controls.Add(this.creditLineTextBox);
            this.groupPanelClientCreditLine.Controls.Add(this.btnClientCreditLineRefresh);
            this.groupPanelClientCreditLine.Controls.Add(creditLineCommentLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.creditLineCommentTextBox);
            this.groupPanelClientCreditLine.Controls.Add(unfreezeDateLabel);
            this.groupPanelClientCreditLine.Controls.Add(freezeDateLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.unfreezeDateDateTimePicker);
            this.groupPanelClientCreditLine.Controls.Add(this.btnClientCreditLineUnfreeze);
            this.groupPanelClientCreditLine.Controls.Add(unfreezerLabel);
            this.groupPanelClientCreditLine.Controls.Add(freezeReasonLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.unfreezerTextBox);
            this.groupPanelClientCreditLine.Controls.Add(this.freezeDateDateTimePicker);
            this.groupPanelClientCreditLine.Controls.Add(unfreezeReasonLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.btnClientCreditLineFreeze);
            this.groupPanelClientCreditLine.Controls.Add(this.unfreezeReasonTextBox);
            this.groupPanelClientCreditLine.Controls.Add(this.freezeReasonTextBox);
            this.groupPanelClientCreditLine.Controls.Add(this.btnClientCreditLineDelete);
            this.groupPanelClientCreditLine.Controls.Add(freezerLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.btnClientCreditLineSave);
            this.groupPanelClientCreditLine.Controls.Add(this.freezerTextBox);
            this.groupPanelClientCreditLine.Controls.Add(this.btnClientCreditLineNew);
            this.groupPanelClientCreditLine.Controls.Add(creditLineStatusLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.creditLineStatusTextBox);
            this.groupPanelClientCreditLine.Controls.Add(approveTypeLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.approveTypeComboBox);
            this.groupPanelClientCreditLine.Controls.Add(approveNoLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.approveNoTextBox);
            this.groupPanelClientCreditLine.Controls.Add(this.periodEndDateTimePicker);
            this.groupPanelClientCreditLine.Controls.Add(periodBeginLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.periodBeginDateTimePicker);
            this.groupPanelClientCreditLine.Controls.Add(creditLineLabel);
            this.groupPanelClientCreditLine.Controls.Add(creditLineTypeLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.creditLineTypeComboBox);
            this.groupPanelClientCreditLine.Controls.Add(creditLineCurrencyLabel);
            this.groupPanelClientCreditLine.Controls.Add(this.creditLineCurrencyComboBox);
            this.groupPanelClientCreditLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientCreditLine.Location = new System.Drawing.Point(1, 1);
            this.groupPanelClientCreditLine.Name = "groupPanelClientCreditLine";
            this.groupPanelClientCreditLine.Size = new System.Drawing.Size(584, 361);
            // 
            // 
            // 
            this.groupPanelClientCreditLine.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelClientCreditLine.Style.BackColorGradientAngle = 90;
            this.groupPanelClientCreditLine.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelClientCreditLine.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientCreditLine.Style.BorderBottomWidth = 1;
            this.groupPanelClientCreditLine.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelClientCreditLine.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientCreditLine.Style.BorderLeftWidth = 1;
            this.groupPanelClientCreditLine.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientCreditLine.Style.BorderRightWidth = 1;
            this.groupPanelClientCreditLine.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientCreditLine.Style.BorderTopWidth = 1;
            this.groupPanelClientCreditLine.Style.Class = "";
            this.groupPanelClientCreditLine.Style.CornerDiameter = 4;
            this.groupPanelClientCreditLine.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelClientCreditLine.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelClientCreditLine.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelClientCreditLine.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelClientCreditLine.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelClientCreditLine.StyleMouseOver.Class = "";
            this.groupPanelClientCreditLine.TabIndex = 0;
            // 
            // tbCreditLineCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreditLineCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreditLineCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreateUserName", true));
            this.tbCreditLineCreateUserName.Location = new System.Drawing.Point(90, 159);
            this.tbCreditLineCreateUserName.Name = "tbCreditLineCreateUserName";
            this.tbCreditLineCreateUserName.ReadOnly = true;
            this.tbCreditLineCreateUserName.Size = new System.Drawing.Size(152, 20);
            this.tbCreditLineCreateUserName.TabIndex = 41;
            // 
            // clientCreditLineBindingSource
            // 
            this.clientCreditLineBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.ClientCreditLine);
            // 
            // tbGroupCreditLineCurr
            // 
            // 
            // 
            // 
            this.tbGroupCreditLineCurr.Border.Class = "TextBoxBorder";
            this.tbGroupCreditLineCurr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "GroupCreditLine.CreditLineCurrency", true));
            this.tbGroupCreditLineCurr.Location = new System.Drawing.Point(343, 71);
            this.tbGroupCreditLineCurr.Name = "tbGroupCreditLineCurr";
            this.tbGroupCreditLineCurr.Size = new System.Drawing.Size(66, 20);
            this.tbGroupCreditLineCurr.TabIndex = 16;
            // 
            // btnGroupCreditLineSelect
            // 
            this.btnGroupCreditLineSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGroupCreditLineSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGroupCreditLineSelect.Enabled = false;
            this.btnGroupCreditLineSelect.Location = new System.Drawing.Point(543, 69);
            this.btnGroupCreditLineSelect.Name = "btnGroupCreditLineSelect";
            this.btnGroupCreditLineSelect.Size = new System.Drawing.Size(27, 23);
            this.btnGroupCreditLineSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGroupCreditLineSelect.TabIndex = 18;
            this.btnGroupCreditLineSelect.Text = "...";
            this.btnGroupCreditLineSelect.Click += new System.EventHandler(this.SelectGroupCreditLine);
            // 
            // tbGroupCreditLine
            // 
            // 
            // 
            // 
            this.tbGroupCreditLine.Border.Class = "TextBoxBorder";
            this.tbGroupCreditLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "GroupCreditLine.CreditLine", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbGroupCreditLine.Location = new System.Drawing.Point(415, 71);
            this.tbGroupCreditLine.Name = "tbGroupCreditLine";
            this.tbGroupCreditLine.Size = new System.Drawing.Size(122, 20);
            this.tbGroupCreditLine.TabIndex = 17;
            // 
            // btnClientCreditLineUpdate
            // 
            this.btnClientCreditLineUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineUpdate.Location = new System.Drawing.Point(171, 323);
            this.btnClientCreditLineUpdate.Name = "btnClientCreditLineUpdate";
            this.btnClientCreditLineUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineUpdate.TabIndex = 35;
            this.btnClientCreditLineUpdate.Text = "�༭";
            this.btnClientCreditLineUpdate.Click += new System.EventHandler(this.UpdateClientCreditLine);
            // 
            // creditLineTextBox
            // 
            // 
            // 
            // 
            this.creditLineTextBox.Border.Class = "TextBoxBorder";
            this.creditLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreditLine", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.creditLineTextBox.Location = new System.Drawing.Point(90, 50);
            this.creditLineTextBox.Name = "creditLineTextBox";
            this.creditLineTextBox.Size = new System.Drawing.Size(152, 20);
            this.creditLineTextBox.TabIndex = 10;
            this.creditLineValidator.SetValidator1(this.creditLineTextBox, this.requiredFieldValidator8);
            this.creditLineValidator.SetValidator2(this.creditLineTextBox, this.customValidator1);
            // 
            // btnClientCreditLineRefresh
            // 
            this.btnClientCreditLineRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineRefresh.Location = new System.Drawing.Point(11, 323);
            this.btnClientCreditLineRefresh.Name = "btnClientCreditLineRefresh";
            this.btnClientCreditLineRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineRefresh.TabIndex = 33;
            this.btnClientCreditLineRefresh.Text = "ˢ��";
            this.btnClientCreditLineRefresh.Click += new System.EventHandler(this.RefreshClientCreditLine);
            // 
            // creditLineCommentTextBox
            // 
            // 
            // 
            // 
            this.creditLineCommentTextBox.Border.Class = "TextBoxBorder";
            this.creditLineCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "Comment", true));
            this.creditLineCommentTextBox.Location = new System.Drawing.Point(90, 97);
            this.creditLineCommentTextBox.Multiline = true;
            this.creditLineCommentTextBox.Name = "creditLineCommentTextBox";
            this.creditLineCommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.creditLineCommentTextBox.Size = new System.Drawing.Size(480, 56);
            this.creditLineCommentTextBox.TabIndex = 20;
            // 
            // unfreezeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.unfreezeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.unfreezeDateDateTimePicker.ButtonFreeText.Checked = true;
            this.unfreezeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "UnfreezeDate", true));
            this.unfreezeDateDateTimePicker.Enabled = false;
            this.unfreezeDateDateTimePicker.FreeTextEntryMode = true;
            this.unfreezeDateDateTimePicker.Location = new System.Drawing.Point(316, 296);
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.unfreezeDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.unfreezeDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.unfreezeDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.unfreezeDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.unfreezeDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.unfreezeDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.unfreezeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.unfreezeDateDateTimePicker.Name = "unfreezeDateDateTimePicker";
            this.unfreezeDateDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.unfreezeDateDateTimePicker.TabIndex = 32;
            // 
            // btnClientCreditLineUnfreeze
            // 
            this.btnClientCreditLineUnfreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineUnfreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineUnfreeze.Location = new System.Drawing.Point(495, 323);
            this.btnClientCreditLineUnfreeze.Name = "btnClientCreditLineUnfreeze";
            this.btnClientCreditLineUnfreeze.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineUnfreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineUnfreeze.TabIndex = 39;
            this.btnClientCreditLineUnfreeze.Text = "�ⶳ";
            this.btnClientCreditLineUnfreeze.Click += new System.EventHandler(this.UnfreezeClientCreditLine);
            // 
            // unfreezerTextBox
            // 
            // 
            // 
            // 
            this.unfreezerTextBox.Border.Class = "TextBoxBorder";
            this.unfreezerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "Unfreezer", true));
            this.unfreezerTextBox.Location = new System.Drawing.Point(90, 297);
            this.unfreezerTextBox.Name = "unfreezerTextBox";
            this.unfreezerTextBox.ReadOnly = true;
            this.unfreezerTextBox.Size = new System.Drawing.Size(152, 20);
            this.unfreezerTextBox.TabIndex = 30;
            // 
            // freezeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.freezeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.freezeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.freezeDateDateTimePicker.ButtonFreeText.Checked = true;
            this.freezeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "FreezeDate", true));
            this.freezeDateDateTimePicker.Enabled = false;
            this.freezeDateDateTimePicker.FreeTextEntryMode = true;
            this.freezeDateDateTimePicker.Location = new System.Drawing.Point(317, 226);
            // 
            // 
            // 
            this.freezeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.freezeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.freezeDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.freezeDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.freezeDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.freezeDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.freezeDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.freezeDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.freezeDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.freezeDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.freezeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.freezeDateDateTimePicker.Name = "freezeDateDateTimePicker";
            this.freezeDateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.freezeDateDateTimePicker.TabIndex = 26;
            // 
            // btnClientCreditLineFreeze
            // 
            this.btnClientCreditLineFreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineFreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineFreeze.Location = new System.Drawing.Point(414, 323);
            this.btnClientCreditLineFreeze.Name = "btnClientCreditLineFreeze";
            this.btnClientCreditLineFreeze.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineFreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineFreeze.TabIndex = 38;
            this.btnClientCreditLineFreeze.Text = "����";
            this.btnClientCreditLineFreeze.Click += new System.EventHandler(this.FreezeClientCreditLine);
            // 
            // unfreezeReasonTextBox
            // 
            // 
            // 
            // 
            this.unfreezeReasonTextBox.Border.Class = "TextBoxBorder";
            this.unfreezeReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "UnfreezeReason", true));
            this.unfreezeReasonTextBox.Location = new System.Drawing.Point(90, 252);
            this.unfreezeReasonTextBox.Multiline = true;
            this.unfreezeReasonTextBox.Name = "unfreezeReasonTextBox";
            this.unfreezeReasonTextBox.ReadOnly = true;
            this.unfreezeReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.unfreezeReasonTextBox.Size = new System.Drawing.Size(480, 38);
            this.unfreezeReasonTextBox.TabIndex = 28;
            this.creditLineValidator.SetValidator1(this.unfreezeReasonTextBox, this.customValidator5);
            // 
            // freezeReasonTextBox
            // 
            // 
            // 
            // 
            this.freezeReasonTextBox.Border.Class = "TextBoxBorder";
            this.freezeReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "FreezeReason", true));
            this.freezeReasonTextBox.Location = new System.Drawing.Point(90, 184);
            this.freezeReasonTextBox.Multiline = true;
            this.freezeReasonTextBox.Name = "freezeReasonTextBox";
            this.freezeReasonTextBox.ReadOnly = true;
            this.freezeReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.freezeReasonTextBox.Size = new System.Drawing.Size(480, 36);
            this.freezeReasonTextBox.TabIndex = 22;
            this.creditLineValidator.SetValidator1(this.freezeReasonTextBox, this.customValidator4);
            // 
            // btnClientCreditLineDelete
            // 
            this.btnClientCreditLineDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineDelete.Location = new System.Drawing.Point(333, 323);
            this.btnClientCreditLineDelete.Name = "btnClientCreditLineDelete";
            this.btnClientCreditLineDelete.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineDelete.TabIndex = 37;
            this.btnClientCreditLineDelete.Text = "ɾ��";
            this.btnClientCreditLineDelete.Click += new System.EventHandler(this.DeleteClientCreditLine);
            // 
            // btnClientCreditLineSave
            // 
            this.btnClientCreditLineSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineSave.Location = new System.Drawing.Point(252, 323);
            this.btnClientCreditLineSave.Name = "btnClientCreditLineSave";
            this.btnClientCreditLineSave.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineSave.TabIndex = 36;
            this.btnClientCreditLineSave.Text = "����";
            this.btnClientCreditLineSave.Click += new System.EventHandler(this.SaveClientCreditLine);
            // 
            // freezerTextBox
            // 
            // 
            // 
            // 
            this.freezerTextBox.Border.Class = "TextBoxBorder";
            this.freezerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "Freezer", true));
            this.freezerTextBox.Location = new System.Drawing.Point(90, 226);
            this.freezerTextBox.Name = "freezerTextBox";
            this.freezerTextBox.ReadOnly = true;
            this.freezerTextBox.Size = new System.Drawing.Size(152, 20);
            this.freezerTextBox.TabIndex = 24;
            // 
            // btnClientCreditLineNew
            // 
            this.btnClientCreditLineNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineNew.Location = new System.Drawing.Point(90, 323);
            this.btnClientCreditLineNew.Name = "btnClientCreditLineNew";
            this.btnClientCreditLineNew.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineNew.TabIndex = 34;
            this.btnClientCreditLineNew.Text = "�½�";
            this.btnClientCreditLineNew.Click += new System.EventHandler(this.NewClientCreditLine);
            // 
            // creditLineStatusTextBox
            // 
            // 
            // 
            // 
            this.creditLineStatusTextBox.Border.Class = "TextBoxBorder";
            this.creditLineStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreditLineStatus", true));
            this.creditLineStatusTextBox.Location = new System.Drawing.Point(90, 72);
            this.creditLineStatusTextBox.Name = "creditLineStatusTextBox";
            this.creditLineStatusTextBox.ReadOnly = true;
            this.creditLineStatusTextBox.Size = new System.Drawing.Size(152, 20);
            this.creditLineStatusTextBox.TabIndex = 14;
            // 
            // approveTypeComboBox
            // 
            this.approveTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "ApproveType", true));
            this.approveTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.approveTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approveTypeComboBox.FormattingEnabled = true;
            this.approveTypeComboBox.Items.AddRange(new object[] {
            "�ۺ�����",
            "����˫����",
            "���ڱ���",
            "��׷��Ȩ����",
            "��׷��Ȩ����"});
            this.approveTypeComboBox.Location = new System.Drawing.Point(317, 49);
            this.approveTypeComboBox.Name = "approveTypeComboBox";
            this.approveTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.approveTypeComboBox.TabIndex = 12;
            // 
            // approveNoTextBox
            // 
            // 
            // 
            // 
            this.approveNoTextBox.Border.Class = "TextBoxBorder";
            this.approveNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "ApproveNo", true));
            this.approveNoTextBox.Location = new System.Drawing.Point(316, 27);
            this.approveNoTextBox.Name = "approveNoTextBox";
            this.approveNoTextBox.Size = new System.Drawing.Size(122, 20);
            this.approveNoTextBox.TabIndex = 8;
            this.creditLineValidator.SetValidator1(this.approveNoTextBox, this.regularExpressionValidator9);
            // 
            // periodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.periodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.periodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.periodEndDateTimePicker.ButtonFreeText.Checked = true;
            this.periodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "PeriodEnd", true));
            this.periodEndDateTimePicker.FreeTextEntryMode = true;
            this.periodEndDateTimePicker.Location = new System.Drawing.Point(444, 6);
            // 
            // 
            // 
            this.periodEndDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.periodEndDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.periodEndDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.periodEndDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.periodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.periodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.periodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.periodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.periodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.periodEndDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.periodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.periodEndDateTimePicker.Name = "periodEndDateTimePicker";
            this.periodEndDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.periodEndDateTimePicker.TabIndex = 4;
            this.creditLineValidator.SetValidator1(this.periodEndDateTimePicker, this.requiredFieldValidator5);
            this.creditLineValidator.SetValidator2(this.periodEndDateTimePicker, this.compareValidator2);
            // 
            // periodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.periodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.periodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.periodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.periodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "PeriodBegin", true));
            this.periodBeginDateTimePicker.FreeTextEntryMode = true;
            this.periodBeginDateTimePicker.Location = new System.Drawing.Point(316, 6);
            // 
            // 
            // 
            this.periodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.periodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.periodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.periodBeginDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.periodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.periodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.periodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.periodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.periodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.periodBeginDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.periodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.periodBeginDateTimePicker.Name = "periodBeginDateTimePicker";
            this.periodBeginDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.periodBeginDateTimePicker.TabIndex = 3;
            this.creditLineValidator.SetValidator1(this.periodBeginDateTimePicker, this.requiredFieldValidator4);
            this.periodBeginDateTimePicker.ValueChanged += new System.EventHandler(this.PeriodBeginDateTimePickerValueChanged);
            // 
            // creditLineTypeComboBox
            // 
            this.creditLineTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreditLineType", true));
            this.creditLineTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creditLineTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditLineTypeComboBox.FormattingEnabled = true;
            this.creditLineTypeComboBox.Items.AddRange(new object[] {
            "����Ԥ�������ʶ��",
            "�����÷��յ������",
            "�����ʶ��"});
            this.creditLineTypeComboBox.Location = new System.Drawing.Point(90, 4);
            this.creditLineTypeComboBox.Name = "creditLineTypeComboBox";
            this.creditLineTypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.creditLineTypeComboBox.TabIndex = 1;
            // 
            // creditLineCurrencyComboBox
            // 
            this.creditLineCurrencyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.creditLineCurrencyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.creditLineCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientCreditLineBindingSource, "CreditLineCurrency", true));
            this.creditLineCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creditLineCurrencyComboBox.Location = new System.Drawing.Point(90, 27);
            this.creditLineCurrencyComboBox.Name = "creditLineCurrencyComboBox";
            this.creditLineCurrencyComboBox.Size = new System.Drawing.Size(152, 21);
            this.creditLineCurrencyComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.creditLineCurrencyComboBox.TabIndex = 6;
            this.creditLineValidator.SetValidator1(this.creditLineCurrencyComboBox, this.requiredFieldValidator6);
            // 
            // tabItemClientCreditLine
            // 
            this.tabItemClientCreditLine.AttachedControl = this.tabPanelClientCreditLine;
            this.tabItemClientCreditLine.Name = "tabItemClientCreditLine";
            this.tabItemClientCreditLine.Text = "�����Ϣ";
            // 
            // tabPanelClient
            // 
            this.tabPanelClient.AutoScroll = true;
            this.tabPanelClient.AutoSize = true;
            this.tabPanelClient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabPanelClient.Controls.Add(this.btnClientUpdate);
            this.tabPanelClient.Controls.Add(this.groupPanelClientContact);
            this.tabPanelClient.Controls.Add(this.groupPanelClientGroup);
            this.tabPanelClient.Controls.Add(this.btnClientSave);
            this.tabPanelClient.Controls.Add(this.groupPanelClientStat);
            this.tabPanelClient.Controls.Add(this.groupPanelClientBasic);
            this.tabPanelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelClient.Location = new System.Drawing.Point(0, 26);
            this.tabPanelClient.Name = "tabPanelClient";
            this.tabPanelClient.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelClient.Size = new System.Drawing.Size(586, 588);
            this.tabPanelClient.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelClient.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelClient.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelClient.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelClient.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelClient.Style.GradientAngle = 90;
            this.tabPanelClient.TabIndex = 1;
            this.tabPanelClient.TabItem = this.tabItemClient;
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientUpdate.Location = new System.Drawing.Point(198, 553);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnClientUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientUpdate.TabIndex = 4;
            this.btnClientUpdate.Text = "�༭";
            this.btnClientUpdate.Click += new System.EventHandler(this.UpdateClient);
            // 
            // groupPanelClientContact
            // 
            this.groupPanelClientContact.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientContact.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelClientContact.Controls.Add(companyCodeLabel);
            this.groupPanelClientContact.Controls.Add(this.companyCodeTextBox);
            this.groupPanelClientContact.Controls.Add(registrationNumberLabel);
            this.groupPanelClientContact.Controls.Add(this.registrationNumberTextBox);
            this.groupPanelClientContact.Controls.Add(cellPhoneLabel);
            this.groupPanelClientContact.Controls.Add(this.cellPhoneTextBox);
            this.groupPanelClientContact.Controls.Add(faxNumberLabel);
            this.groupPanelClientContact.Controls.Add(this.faxNumberTextBox);
            this.groupPanelClientContact.Controls.Add(emailLabel);
            this.groupPanelClientContact.Controls.Add(this.emailTextBox);
            this.groupPanelClientContact.Controls.Add(telephoneLabel);
            this.groupPanelClientContact.Controls.Add(this.telephoneTextBox);
            this.groupPanelClientContact.Controls.Add(contactLabel);
            this.groupPanelClientContact.Controls.Add(this.contactTextBox);
            this.groupPanelClientContact.Controls.Add(websiteLabel);
            this.groupPanelClientContact.Controls.Add(this.websiteTextBox);
            this.groupPanelClientContact.Controls.Add(representativeLabel);
            this.groupPanelClientContact.Controls.Add(this.representativeTextBox);
            this.groupPanelClientContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientContact.Location = new System.Drawing.Point(1, 416);
            this.groupPanelClientContact.Name = "groupPanelClientContact";
            this.groupPanelClientContact.Size = new System.Drawing.Size(584, 114);
            // 
            // 
            // 
            this.groupPanelClientContact.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelClientContact.Style.BackColorGradientAngle = 90;
            this.groupPanelClientContact.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelClientContact.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientContact.Style.BorderBottomWidth = 1;
            this.groupPanelClientContact.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelClientContact.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientContact.Style.BorderLeftWidth = 1;
            this.groupPanelClientContact.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientContact.Style.BorderRightWidth = 1;
            this.groupPanelClientContact.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientContact.Style.BorderTopWidth = 1;
            this.groupPanelClientContact.Style.Class = "";
            this.groupPanelClientContact.Style.CornerDiameter = 4;
            this.groupPanelClientContact.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelClientContact.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelClientContact.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelClientContact.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelClientContact.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelClientContact.StyleMouseOver.Class = "";
            this.groupPanelClientContact.StyleMouseOver.MarginBottom = 10;
            this.groupPanelClientContact.StyleMouseOver.MarginTop = 10;
            this.groupPanelClientContact.TabIndex = 3;
            // 
            // companyCodeTextBox
            // 
            // 
            // 
            // 
            this.companyCodeTextBox.Border.Class = "TextBoxBorder";
            this.companyCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CompanyCode", true));
            this.companyCodeTextBox.Location = new System.Drawing.Point(468, 30);
            this.companyCodeTextBox.Name = "companyCodeTextBox";
            this.companyCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyCodeTextBox.TabIndex = 17;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Client);
            // 
            // registrationNumberTextBox
            // 
            // 
            // 
            // 
            this.registrationNumberTextBox.Border.Class = "TextBoxBorder";
            this.registrationNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "RegistrationNumber", true));
            this.registrationNumberTextBox.Location = new System.Drawing.Point(468, 7);
            this.registrationNumberTextBox.MaxLength = 35;
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.registrationNumberTextBox.TabIndex = 15;
            // 
            // cellPhoneTextBox
            // 
            // 
            // 
            // 
            this.cellPhoneTextBox.Border.Class = "TextBoxBorder";
            this.cellPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CellPhone", true));
            this.cellPhoneTextBox.Location = new System.Drawing.Point(85, 78);
            this.cellPhoneTextBox.Name = "cellPhoneTextBox";
            this.cellPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.cellPhoneTextBox.TabIndex = 7;
            // 
            // faxNumberTextBox
            // 
            // 
            // 
            // 
            this.faxNumberTextBox.Border.Class = "TextBoxBorder";
            this.faxNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FaxNumber", true));
            this.faxNumberTextBox.Location = new System.Drawing.Point(267, 54);
            this.faxNumberTextBox.MaxLength = 25;
            this.faxNumberTextBox.Name = "faxNumberTextBox";
            this.faxNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.faxNumberTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.Border.Class = "TextBoxBorder";
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(85, 54);
            this.emailTextBox.MaxLength = 70;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // telephoneTextBox
            // 
            // 
            // 
            // 
            this.telephoneTextBox.Border.Class = "TextBoxBorder";
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(267, 30);
            this.telephoneTextBox.MaxLength = 25;
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneTextBox.TabIndex = 11;
            // 
            // contactTextBox
            // 
            // 
            // 
            // 
            this.contactTextBox.Border.Class = "TextBoxBorder";
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(85, 30);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox.TabIndex = 3;
            // 
            // websiteTextBox
            // 
            // 
            // 
            // 
            this.websiteTextBox.Border.Class = "TextBoxBorder";
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(267, 7);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.websiteTextBox.TabIndex = 9;
            // 
            // representativeTextBox
            // 
            // 
            // 
            // 
            this.representativeTextBox.Border.Class = "TextBoxBorder";
            this.representativeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Representative", true));
            this.representativeTextBox.Location = new System.Drawing.Point(85, 7);
            this.representativeTextBox.Name = "representativeTextBox";
            this.representativeTextBox.Size = new System.Drawing.Size(100, 20);
            this.representativeTextBox.TabIndex = 1;
            // 
            // groupPanelClientGroup
            // 
            this.groupPanelClientGroup.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientGroup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelClientGroup.Controls.Add(this.btnGroupSelect);
            this.groupPanelClientGroup.Controls.Add(this.tbGroupNameEN);
            this.groupPanelClientGroup.Controls.Add(this.tbGroupNameCN);
            this.groupPanelClientGroup.Controls.Add(lblGroupNameCN);
            this.groupPanelClientGroup.Controls.Add(groupNoLabel);
            this.groupPanelClientGroup.Controls.Add(this.groupNoTextBox);
            this.groupPanelClientGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientGroup.Location = new System.Drawing.Point(1, 327);
            this.groupPanelClientGroup.Name = "groupPanelClientGroup";
            this.groupPanelClientGroup.Size = new System.Drawing.Size(584, 89);
            // 
            // 
            // 
            this.groupPanelClientGroup.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelClientGroup.Style.BackColorGradientAngle = 90;
            this.groupPanelClientGroup.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelClientGroup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientGroup.Style.BorderBottomWidth = 1;
            this.groupPanelClientGroup.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelClientGroup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientGroup.Style.BorderLeftWidth = 1;
            this.groupPanelClientGroup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientGroup.Style.BorderRightWidth = 1;
            this.groupPanelClientGroup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientGroup.Style.BorderTopWidth = 1;
            this.groupPanelClientGroup.Style.Class = "";
            this.groupPanelClientGroup.Style.CornerDiameter = 4;
            this.groupPanelClientGroup.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelClientGroup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelClientGroup.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelClientGroup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelClientGroup.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelClientGroup.StyleMouseOver.Class = "";
            this.groupPanelClientGroup.TabIndex = 2;
            // 
            // btnGroupSelect
            // 
            this.btnGroupSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGroupSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGroupSelect.Location = new System.Drawing.Point(215, 4);
            this.btnGroupSelect.Name = "btnGroupSelect";
            this.btnGroupSelect.Size = new System.Drawing.Size(27, 23);
            this.btnGroupSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGroupSelect.TabIndex = 2;
            this.btnGroupSelect.Text = "...";
            this.btnGroupSelect.Click += new System.EventHandler(this.SelectGroup);
            // 
            // tbGroupNameEN
            // 
            // 
            // 
            // 
            this.tbGroupNameEN.Border.Class = "TextBoxBorder";
            this.tbGroupNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientGroup.ClientNameEN", true));
            this.tbGroupNameEN.Location = new System.Drawing.Point(85, 54);
            this.tbGroupNameEN.Name = "tbGroupNameEN";
            this.tbGroupNameEN.Size = new System.Drawing.Size(295, 20);
            this.tbGroupNameEN.TabIndex = 5;
            this.tbGroupNameEN.WatermarkText = "Ӣ����";
            // 
            // tbGroupNameCN
            // 
            // 
            // 
            // 
            this.tbGroupNameCN.Border.Class = "TextBoxBorder";
            this.tbGroupNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientGroup.ClientNameCN", true));
            this.tbGroupNameCN.Location = new System.Drawing.Point(85, 30);
            this.tbGroupNameCN.Name = "tbGroupNameCN";
            this.tbGroupNameCN.Size = new System.Drawing.Size(295, 20);
            this.tbGroupNameCN.TabIndex = 4;
            this.tbGroupNameCN.WatermarkText = "������";
            // 
            // groupNoTextBox
            // 
            // 
            // 
            // 
            this.groupNoTextBox.Border.Class = "TextBoxBorder";
            this.groupNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientGroup.ClientEDICode", true));
            this.groupNoTextBox.Location = new System.Drawing.Point(109, 6);
            this.groupNoTextBox.Name = "groupNoTextBox";
            this.groupNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupNoTextBox.TabIndex = 1;
            // 
            // btnClientSave
            // 
            this.btnClientSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientSave.Location = new System.Drawing.Point(283, 553);
            this.btnClientSave.Name = "btnClientSave";
            this.btnClientSave.Size = new System.Drawing.Size(75, 23);
            this.btnClientSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientSave.TabIndex = 5;
            this.btnClientSave.Text = "����";
            this.btnClientSave.Click += new System.EventHandler(this.SaveClient);
            // 
            // groupPanelClientStat
            // 
            this.groupPanelClientStat.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientStat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelClientStat.Controls.Add(lblCreateUserName);
            this.groupPanelClientStat.Controls.Add(this.tbCreateUserName);
            this.groupPanelClientStat.Controls.Add(industryLabel);
            this.groupPanelClientStat.Controls.Add(this.cbIndustry);
            this.groupPanelClientStat.Controls.Add(this.cbDepartments);
            this.groupPanelClientStat.Controls.Add(rMNameLabel);
            this.groupPanelClientStat.Controls.Add(this.rMNameTextBox);
            this.groupPanelClientStat.Controls.Add(pMNameLabel);
            this.groupPanelClientStat.Controls.Add(this.pMNameTextBox);
            this.groupPanelClientStat.Controls.Add(branchCodeLabel);
            this.groupPanelClientStat.Controls.Add(clientLevelLabel);
            this.groupPanelClientStat.Controls.Add(this.clientLevelComboBox);
            this.groupPanelClientStat.Controls.Add(clientTypeLabel);
            this.groupPanelClientStat.Controls.Add(this.clientTypeComboBox);
            this.groupPanelClientStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientStat.Location = new System.Drawing.Point(1, 236);
            this.groupPanelClientStat.Name = "groupPanelClientStat";
            this.groupPanelClientStat.Size = new System.Drawing.Size(584, 91);
            // 
            // 
            // 
            this.groupPanelClientStat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelClientStat.Style.BackColorGradientAngle = 90;
            this.groupPanelClientStat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelClientStat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientStat.Style.BorderBottomWidth = 1;
            this.groupPanelClientStat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelClientStat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientStat.Style.BorderLeftWidth = 1;
            this.groupPanelClientStat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientStat.Style.BorderRightWidth = 1;
            this.groupPanelClientStat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientStat.Style.BorderTopWidth = 1;
            this.groupPanelClientStat.Style.Class = "";
            this.groupPanelClientStat.Style.CornerDiameter = 4;
            this.groupPanelClientStat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelClientStat.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelClientStat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelClientStat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelClientStat.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelClientStat.StyleMouseOver.Class = "";
            this.groupPanelClientStat.TabIndex = 1;
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CreateUserName", true));
            this.tbCreateUserName.Location = new System.Drawing.Point(471, 51);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCreateUserName.TabIndex = 13;
            // 
            // cbIndustry
            // 
            this.cbIndustry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Industry", true));
            this.cbIndustry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIndustry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndustry.FormattingEnabled = true;
            this.cbIndustry.Items.AddRange(new object[] {
            "��ѧ��Դ",
            "��ͨ����",
            "ұ��",
            "���ز�",
            "����ͨѶ",
            "����",
            "ҽҩ",
            "����",
            "��ó",
            "����",
            "����"});
            this.cbIndustry.Location = new System.Drawing.Point(471, 7);
            this.cbIndustry.Name = "cbIndustry";
            this.cbIndustry.Size = new System.Drawing.Size(100, 21);
            this.cbIndustry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIndustry.TabIndex = 11;
            // 
            // cbDepartments
            // 
            this.cbDepartments.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbDepartments.BackgroundStyle.Class = "TextBoxBorder";
            this.cbDepartments.ButtonDropDown.Visible = true;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(85, 30);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(292, 23);
            this.cbDepartments.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDepartments.TabIndex = 5;
            this.cbDepartments.SelectionChanged += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.CbDepartmentsSelectionChanged);
            // 
            // rMNameTextBox
            // 
            // 
            // 
            // 
            this.rMNameTextBox.Border.Class = "TextBoxBorder";
            this.rMNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "RMName", true));
            this.rMNameTextBox.Location = new System.Drawing.Point(277, 54);
            this.rMNameTextBox.Name = "rMNameTextBox";
            this.rMNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.rMNameTextBox.TabIndex = 9;
            // 
            // pMNameTextBox
            // 
            // 
            // 
            // 
            this.pMNameTextBox.Border.Class = "TextBoxBorder";
            this.pMNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PMName", true));
            this.pMNameTextBox.Location = new System.Drawing.Point(85, 54);
            this.pMNameTextBox.Name = "pMNameTextBox";
            this.pMNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pMNameTextBox.TabIndex = 7;
            // 
            // clientLevelComboBox
            // 
            this.clientLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientLevel", true));
            this.clientLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clientLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientLevelComboBox.FormattingEnabled = true;
            this.clientLevelComboBox.Items.AddRange(new object[] {
            "NORMAL",
            "VIP"});
            this.clientLevelComboBox.Location = new System.Drawing.Point(277, 7);
            this.clientLevelComboBox.Name = "clientLevelComboBox";
            this.clientLevelComboBox.Size = new System.Drawing.Size(100, 21);
            this.clientLevelComboBox.TabIndex = 3;
            // 
            // clientTypeComboBox
            // 
            this.clientTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientType", true));
            this.clientTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clientTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientTypeComboBox.FormattingEnabled = true;
            this.clientTypeComboBox.Items.AddRange(new object[] {
            "����",
            "��Ӫ",
            "����"});
            this.clientTypeComboBox.Location = new System.Drawing.Point(85, 7);
            this.clientTypeComboBox.Name = "clientTypeComboBox";
            this.clientTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.clientTypeComboBox.TabIndex = 1;
            // 
            // groupPanelClientBasic
            // 
            this.groupPanelClientBasic.BackColor = System.Drawing.Color.Transparent;
            this.groupPanelClientBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelClientBasic.Controls.Add(lblOldEDICode);
            this.groupPanelClientBasic.Controls.Add(this.tbOldEDICode);
            this.groupPanelClientBasic.Controls.Add(clientCoreNoLabel);
            this.groupPanelClientBasic.Controls.Add(this.clientCoreNoTextBox);
            this.groupPanelClientBasic.Controls.Add(commentLabel);
            this.groupPanelClientBasic.Controls.Add(this.clientCommentTextBox);
            this.groupPanelClientBasic.Controls.Add(clientNoLabel);
            this.groupPanelClientBasic.Controls.Add(this.clientEDICodeTextBox);
            this.groupPanelClientBasic.Controls.Add(countryCodeLabel);
            this.groupPanelClientBasic.Controls.Add(this.cbCountryCode);
            this.groupPanelClientBasic.Controls.Add(postCodeLabel);
            this.groupPanelClientBasic.Controls.Add(this.postCodeTextBox);
            this.groupPanelClientBasic.Controls.Add(this.productENTextBox);
            this.groupPanelClientBasic.Controls.Add(productCNLabel);
            this.groupPanelClientBasic.Controls.Add(this.productCNTextBox);
            this.groupPanelClientBasic.Controls.Add(this.provinceENTextBox);
            this.groupPanelClientBasic.Controls.Add(provinceCNLabel);
            this.groupPanelClientBasic.Controls.Add(this.provinceCNTextBox);
            this.groupPanelClientBasic.Controls.Add(this.cityENTextBox);
            this.groupPanelClientBasic.Controls.Add(cityCNLabel);
            this.groupPanelClientBasic.Controls.Add(this.cityCNTextBox);
            this.groupPanelClientBasic.Controls.Add(this.addressENTextBox);
            this.groupPanelClientBasic.Controls.Add(addressCNLabel);
            this.groupPanelClientBasic.Controls.Add(this.addressCNTextBox);
            this.groupPanelClientBasic.Controls.Add(this.clientNameENTextBox);
            this.groupPanelClientBasic.Controls.Add(clientNameCNLabel);
            this.groupPanelClientBasic.Controls.Add(this.clientNameCNTextBox);
            this.groupPanelClientBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientBasic.Location = new System.Drawing.Point(1, 1);
            this.groupPanelClientBasic.Name = "groupPanelClientBasic";
            this.groupPanelClientBasic.Size = new System.Drawing.Size(584, 235);
            // 
            // 
            // 
            this.groupPanelClientBasic.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelClientBasic.Style.BackColorGradientAngle = 90;
            this.groupPanelClientBasic.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelClientBasic.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientBasic.Style.BorderBottomWidth = 1;
            this.groupPanelClientBasic.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelClientBasic.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientBasic.Style.BorderLeftWidth = 1;
            this.groupPanelClientBasic.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientBasic.Style.BorderRightWidth = 1;
            this.groupPanelClientBasic.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelClientBasic.Style.BorderTopWidth = 1;
            this.groupPanelClientBasic.Style.Class = "";
            this.groupPanelClientBasic.Style.CornerDiameter = 4;
            this.groupPanelClientBasic.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelClientBasic.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelClientBasic.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelClientBasic.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelClientBasic.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelClientBasic.StyleMouseOver.Class = "";
            this.groupPanelClientBasic.TabIndex = 0;
            // 
            // tbOldEDICode
            // 
            // 
            // 
            // 
            this.tbOldEDICode.Border.Class = "TextBoxBorder";
            this.tbOldEDICode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "OldEDICode", true));
            this.tbOldEDICode.Location = new System.Drawing.Point(279, 199);
            this.tbOldEDICode.MaxLength = 35;
            this.tbOldEDICode.Name = "tbOldEDICode";
            this.tbOldEDICode.Size = new System.Drawing.Size(100, 20);
            this.tbOldEDICode.TabIndex = 27;
            // 
            // clientCoreNoTextBox
            // 
            // 
            // 
            // 
            this.clientCoreNoTextBox.Border.Class = "TextBoxBorder";
            this.clientCoreNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientCoreNo", true));
            this.clientCoreNoTextBox.Location = new System.Drawing.Point(280, 7);
            this.clientCoreNoTextBox.Name = "clientCoreNoTextBox";
            this.clientCoreNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientCoreNoTextBox.TabIndex = 3;
            // 
            // clientCommentTextBox
            // 
            // 
            // 
            // 
            this.clientCommentTextBox.Border.Class = "TextBoxBorder";
            this.clientCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Comment", true));
            this.clientCommentTextBox.Location = new System.Drawing.Point(393, 145);
            this.clientCommentTextBox.Multiline = true;
            this.clientCommentTextBox.Name = "clientCommentTextBox";
            this.clientCommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientCommentTextBox.Size = new System.Drawing.Size(178, 73);
            this.clientCommentTextBox.TabIndex = 25;
            // 
            // clientEDICodeTextBox
            // 
            // 
            // 
            // 
            this.clientEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.clientEDICodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientEDICode", true));
            this.clientEDICodeTextBox.Location = new System.Drawing.Point(85, 7);
            this.clientEDICodeTextBox.MaxLength = 9;
            this.clientEDICodeTextBox.Name = "clientEDICodeTextBox";
            this.clientEDICodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientEDICodeTextBox.TabIndex = 1;
            this.clientValidator.SetValidator1(this.clientEDICodeTextBox, this.requiredFieldValidator1);
            this.clientValidator.SetValidator2(this.clientEDICodeTextBox, this.regularExpressionValidator1);
            // 
            // cbCountryCode
            // 
            this.cbCountryCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCountryCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountryCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "CountryCode", true));
            this.cbCountryCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountryCode.Location = new System.Drawing.Point(85, 174);
            this.cbCountryCode.Name = "cbCountryCode";
            this.cbCountryCode.Size = new System.Drawing.Size(100, 21);
            this.cbCountryCode.TabIndex = 18;
            this.clientValidator.SetValidator1(this.cbCountryCode, this.requiredFieldValidator2);
            // 
            // postCodeTextBox
            // 
            // 
            // 
            // 
            this.postCodeTextBox.Border.Class = "TextBoxBorder";
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(85, 198);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postCodeTextBox.TabIndex = 20;
            // 
            // productENTextBox
            // 
            // 
            // 
            // 
            this.productENTextBox.Border.Class = "TextBoxBorder";
            this.productENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProductEN", true));
            this.productENTextBox.Location = new System.Drawing.Point(393, 80);
            this.productENTextBox.MaxLength = 70;
            this.productENTextBox.Multiline = true;
            this.productENTextBox.Name = "productENTextBox";
            this.productENTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.productENTextBox.Size = new System.Drawing.Size(178, 43);
            this.productENTextBox.TabIndex = 23;
            this.clientValidator.SetValidator2(this.productENTextBox, this.regularExpressionValidator8);
            this.productENTextBox.WatermarkText = "Ӣ��";
            // 
            // productCNTextBox
            // 
            // 
            // 
            // 
            this.productCNTextBox.Border.Class = "TextBoxBorder";
            this.productCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProductCN", true));
            this.productCNTextBox.Location = new System.Drawing.Point(393, 30);
            this.productCNTextBox.MaxLength = 500;
            this.productCNTextBox.Multiline = true;
            this.productCNTextBox.Name = "productCNTextBox";
            this.productCNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.productCNTextBox.Size = new System.Drawing.Size(178, 46);
            this.productCNTextBox.TabIndex = 22;
            this.clientValidator.SetValidator2(this.productCNTextBox, this.regularExpressionValidator7);
            this.productCNTextBox.WatermarkText = "����";
            // 
            // provinceENTextBox
            // 
            // 
            // 
            // 
            this.provinceENTextBox.Border.Class = "TextBoxBorder";
            this.provinceENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceEN", true));
            this.provinceENTextBox.Location = new System.Drawing.Point(190, 150);
            this.provinceENTextBox.MaxLength = 9;
            this.provinceENTextBox.Name = "provinceENTextBox";
            this.provinceENTextBox.Size = new System.Drawing.Size(100, 20);
            this.provinceENTextBox.TabIndex = 16;
            this.provinceENTextBox.WatermarkText = "Ӣ��";
            // 
            // provinceCNTextBox
            // 
            // 
            // 
            // 
            this.provinceCNTextBox.Border.Class = "TextBoxBorder";
            this.provinceCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceCN", true));
            this.provinceCNTextBox.Location = new System.Drawing.Point(85, 150);
            this.provinceCNTextBox.Name = "provinceCNTextBox";
            this.provinceCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.provinceCNTextBox.TabIndex = 15;
            this.provinceCNTextBox.WatermarkText = "����";
            // 
            // cityENTextBox
            // 
            // 
            // 
            // 
            this.cityENTextBox.Border.Class = "TextBoxBorder";
            this.cityENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityEN", true));
            this.cityENTextBox.Location = new System.Drawing.Point(190, 127);
            this.cityENTextBox.MaxLength = 35;
            this.cityENTextBox.Name = "cityENTextBox";
            this.cityENTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityENTextBox.TabIndex = 13;
            this.cityENTextBox.WatermarkText = "Ӣ��";
            // 
            // cityCNTextBox
            // 
            // 
            // 
            // 
            this.cityCNTextBox.Border.Class = "TextBoxBorder";
            this.cityCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityCN", true));
            this.cityCNTextBox.Location = new System.Drawing.Point(85, 127);
            this.cityCNTextBox.Name = "cityCNTextBox";
            this.cityCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityCNTextBox.TabIndex = 12;
            this.cityCNTextBox.WatermarkText = "����";
            // 
            // addressENTextBox
            // 
            // 
            // 
            // 
            this.addressENTextBox.Border.Class = "TextBoxBorder";
            this.addressENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressEN", true));
            this.addressENTextBox.Location = new System.Drawing.Point(85, 103);
            this.addressENTextBox.Name = "addressENTextBox";
            this.addressENTextBox.Size = new System.Drawing.Size(295, 20);
            this.addressENTextBox.TabIndex = 10;
            this.clientValidator.SetValidator1(this.addressENTextBox, this.requiredFieldValidator18);
            this.clientValidator.SetValidator2(this.addressENTextBox, this.regularExpressionValidator6);
            this.addressENTextBox.WatermarkText = "Ӣ�ĵ�ַ";
            // 
            // addressCNTextBox
            // 
            // 
            // 
            // 
            this.addressCNTextBox.Border.Class = "TextBoxBorder";
            this.addressCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressCN", true));
            this.addressCNTextBox.Location = new System.Drawing.Point(85, 79);
            this.addressCNTextBox.Name = "addressCNTextBox";
            this.addressCNTextBox.Size = new System.Drawing.Size(295, 20);
            this.addressCNTextBox.TabIndex = 9;
            this.clientValidator.SetValidator1(this.addressCNTextBox, this.requiredFieldValidator17);
            this.clientValidator.SetValidator2(this.addressCNTextBox, this.regularExpressionValidator5);
            this.addressCNTextBox.WatermarkText = "���ĵ�ַ";
            // 
            // clientNameENTextBox
            // 
            // 
            // 
            // 
            this.clientNameENTextBox.Border.Class = "TextBoxBorder";
            this.clientNameENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameEN", true));
            this.clientNameENTextBox.Location = new System.Drawing.Point(85, 54);
            this.clientNameENTextBox.Name = "clientNameENTextBox";
            this.clientNameENTextBox.Size = new System.Drawing.Size(295, 20);
            this.clientNameENTextBox.TabIndex = 6;
            this.clientValidator.SetValidator1(this.clientNameENTextBox, this.requiredFieldValidator15);
            this.clientValidator.SetValidator2(this.clientNameENTextBox, this.regularExpressionValidator4);
            this.clientNameENTextBox.WatermarkText = "Ӣ����";
            // 
            // clientNameCNTextBox
            // 
            // 
            // 
            // 
            this.clientNameCNTextBox.Border.Class = "TextBoxBorder";
            this.clientNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameCN", true));
            this.clientNameCNTextBox.Location = new System.Drawing.Point(85, 30);
            this.clientNameCNTextBox.Name = "clientNameCNTextBox";
            this.clientNameCNTextBox.Size = new System.Drawing.Size(295, 20);
            this.clientNameCNTextBox.TabIndex = 5;
            this.clientValidator.SetValidator1(this.clientNameCNTextBox, this.requiredFieldValidator14);
            this.clientValidator.SetValidator2(this.clientNameCNTextBox, this.regularExpressionValidator3);
            this.clientNameCNTextBox.WatermarkText = "������";
            // 
            // tabItemClient
            // 
            this.tabItemClient.AttachedControl = this.tabPanelClient;
            this.tabItemClient.Name = "tabItemClient";
            this.tabItemClient.Text = "������Ϣ";
            // 
            // tabItemCommissionRemit
            // 
            this.tabItemCommissionRemit.Name = "tabItemCommissionRemit";
            this.tabItemCommissionRemit.Text = "������ո�";
            // 
            // clientValidator
            // 
            this.clientValidator.ContainerControl = this;
            this.clientValidator.ErrorProvider = this.errorProvider;
            this.clientValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "����";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "�����ϱ��������ȷʾ��:210HJKN01";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^[a-zA-Z0-9]{2}[a-zA-Z0-9\\\\-]{1}[a-zA-Z0-9]{4}\\d{2}$";
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "����";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator8
            // 
            this.regularExpressionValidator8.EmptyValueIsValid = true;
            this.regularExpressionValidator8.ErrorMessage = "�������������ַ�";
            this.regularExpressionValidator8.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator8.ValidationExpression = "^[^~!@#$%\\\\^&\\\\*\\\\+=\\\\?]+$";
            // 
            // regularExpressionValidator7
            // 
            this.regularExpressionValidator7.EmptyValueIsValid = true;
            this.regularExpressionValidator7.ErrorMessage = "�������������ַ�";
            this.regularExpressionValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator7.ValidationExpression = "^[^~!@#$%\\\\^&\\\\*\\\\+=\\\\?]+$";
            // 
            // requiredFieldValidator18
            // 
            this.requiredFieldValidator18.ErrorMessage = "������һ����ַ";
            this.requiredFieldValidator18.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator18.OptionalValidationGroup = "Address";
            // 
            // regularExpressionValidator6
            // 
            this.regularExpressionValidator6.EmptyValueIsValid = true;
            this.regularExpressionValidator6.ErrorMessage = "�������������ַ�";
            this.regularExpressionValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator6.OptionalValidationGroup = "^[^~!@#$%\\\\^\\\\*\\\\+=\\\\?]+$";
            // 
            // requiredFieldValidator17
            // 
            this.requiredFieldValidator17.ErrorMessage = "������һ����ַ";
            this.requiredFieldValidator17.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator17.OptionalValidationGroup = "Address";
            // 
            // regularExpressionValidator5
            // 
            this.regularExpressionValidator5.EmptyValueIsValid = true;
            this.regularExpressionValidator5.ErrorMessage = "�������������ַ�";
            this.regularExpressionValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator5.ValidationExpression = "^[^~!@#$%\\\\^&\\\\*\\\\+=\\\\?]+$";
            // 
            // requiredFieldValidator15
            // 
            this.requiredFieldValidator15.ErrorMessage = "������һ���ͻ���";
            this.requiredFieldValidator15.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator15.OptionalValidationGroup = "ClientName";
            // 
            // regularExpressionValidator4
            // 
            this.regularExpressionValidator4.EmptyValueIsValid = true;
            this.regularExpressionValidator4.ErrorMessage = "�������������ַ�";
            this.regularExpressionValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator4.ValidationExpression = "^[^~!@#$%\\\\^\\\\*\\\\+=\\\\?]+$";
            // 
            // requiredFieldValidator14
            // 
            this.requiredFieldValidator14.ErrorMessage = "������һ���ͻ���";
            this.requiredFieldValidator14.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator14.OptionalValidationGroup = "ClientName";
            // 
            // regularExpressionValidator3
            // 
            this.regularExpressionValidator3.EmptyValueIsValid = true;
            this.regularExpressionValidator3.ErrorMessage = "�������������ַ�";
            this.regularExpressionValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator3.ValidationExpression = "^[^~!@#$%\\\\^&\\\\*\\\\+=\\\\?]+$";
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
            // requiredFieldValidator16
            // 
            this.requiredFieldValidator16.ErrorMessage = "������һ���ͻ���";
            this.requiredFieldValidator16.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator16.OptionalValidationGroup = "ClientName";
            // 
            // requiredFieldValidator10
            // 
            this.requiredFieldValidator10.ErrorMessage = "����";
            this.requiredFieldValidator10.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // creditLineValidator
            // 
            this.creditLineValidator.ContainerControl = this;
            this.creditLineValidator.ErrorProvider = this.errorProvider;
            this.creditLineValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator8
            // 
            this.requiredFieldValidator8.ErrorMessage = "����";
            this.requiredFieldValidator8.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "������ޱ��������";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator1ValidateValue);
            // 
            // customValidator5
            // 
            this.customValidator5.ErrorMessage = "����";
            this.customValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator5.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator5ValidateValue);
            // 
            // customValidator4
            // 
            this.customValidator4.ErrorMessage = "����";
            this.customValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator4.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator4ValidateValue);
            // 
            // regularExpressionValidator9
            // 
            this.regularExpressionValidator9.EmptyValueIsValid = true;
            this.regularExpressionValidator9.ErrorMessage = "ֻ�������ֺ���ĸ���";
            this.regularExpressionValidator9.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator9.ValidationExpression = "^[a-zA-Z0-9]+$";
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "����";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator2
            // 
            this.compareValidator2.ControlToCompare = this.periodBeginDateTimePicker;
            this.compareValidator2.ErrorMessage = "��ֹ����Ӧ�ô�����ʼ����";
            this.compareValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator2.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "����";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "����";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // contractValidator
            // 
            this.contractValidator.ContainerControl = this;
            this.contractValidator.ErrorProvider = this.errorProvider;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "����";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator11
            // 
            this.requiredFieldValidator11.ErrorMessage = "����";
            this.requiredFieldValidator11.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator10
            // 
            this.regularExpressionValidator10.ErrorMessage = "�������������ַ�";
            this.regularExpressionValidator10.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator10.ValidationExpression = "^[^~!@#$%\\\\^&\\\\*\\\\+=\\\\?]+$";
            // 
            // requiredFieldValidator13
            // 
            this.requiredFieldValidator13.ErrorMessage = "����";
            this.requiredFieldValidator13.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.diContractValueDate;
            this.compareValidator1.ErrorMessage = "������Ӧ�ô�����Ч��";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // requiredFieldValidator12
            // 
            this.requiredFieldValidator12.ErrorMessage = "����";
            this.requiredFieldValidator12.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // reviewValidator
            // 
            this.reviewValidator.ContainerControl = this;
            this.reviewValidator.ErrorProvider = this.errorProvider;
            this.reviewValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator19
            // 
            this.requiredFieldValidator19.ErrorMessage = "����";
            this.requiredFieldValidator19.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.ErrorMessage = "����";
            this.requiredFieldValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.ErrorMessage = "Э��������Ŵ��������磺SH20100101-0001AB-SH";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^[A-Z]{2}\\d{8}-\\d{4}[A-Z]{2,3}(-[A-Z]{2})?$";
            // 
            // gdValidator
            // 
            this.gdValidator.ContainerControl = this;
            this.gdValidator.ErrorProvider = this.errorProvider;
            // 
            // requiredFieldValidator21
            // 
            this.requiredFieldValidator21.ErrorMessage = "����";
            this.requiredFieldValidator21.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator20
            // 
            this.requiredFieldValidator20.ErrorMessage = "����";
            this.requiredFieldValidator20.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator9
            // 
            this.requiredFieldValidator9.ErrorMessage = "����";
            this.requiredFieldValidator9.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator24
            // 
            this.requiredFieldValidator24.ErrorMessage = "����";
            this.requiredFieldValidator24.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator22
            // 
            this.requiredFieldValidator22.ErrorMessage = "����";
            this.requiredFieldValidator22.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator23
            // 
            this.requiredFieldValidator23.ErrorMessage = "����";
            this.requiredFieldValidator23.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator25
            // 
            this.requiredFieldValidator25.ErrorMessage = "����";
            this.requiredFieldValidator25.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // ClientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 614);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ClientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "�ͻ���ϸ��Ϣ";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
            this.tabPanelGD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGDs)).EndInit();
            this.groupPanelGuaranteePanel.ResumeLayout(false);
            this.groupPanelGuaranteePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diDepositDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdBindingSource)).EndInit();
            this.tabPanelReview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.groupPanelReview.ResumeLayout(false);
            this.groupPanelReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDateDateTimePicker)).EndInit();
            this.tabPanelContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.groupPanelContract.ResumeLayout(false);
            this.groupPanelContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractValueDate)).EndInit();
            this.tabPanelClientCreditLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLines)).EndInit();
            this.groupPanelClientCreditLine.ResumeLayout(false);
            this.groupPanelClientCreditLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unfreezeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBeginDateTimePicker)).EndInit();
            this.tabPanelClient.ResumeLayout(false);
            this.groupPanelClientContact.ResumeLayout(false);
            this.groupPanelClientContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupPanelClientGroup.ResumeLayout(false);
            this.groupPanelClientGroup.PerformLayout();
            this.groupPanelClientStat.ResumeLayout(false);
            this.groupPanelClientStat.PerformLayout();
            this.groupPanelClientBasic.ResumeLayout(false);
            this.groupPanelClientBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput diDepositDate;
        private DevComponents.DotNetBar.Validator.SuperValidator gdValidator;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator21;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator20;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator9;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator19;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGDCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGDAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepositDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbOldEDICode;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.TabItem tabItemCommissionRemit;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator24;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator22;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator23;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator25;
    }
}