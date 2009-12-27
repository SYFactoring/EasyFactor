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
        #region Fields (126)

        private DevComponents.DotNetBar.Controls.TextBoxX addressCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX addressENTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproveNoColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX approveNoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproveTypeColumn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx approveTypeComboBox;
        private DevComponents.DotNetBar.ButtonX btnClientClose;
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
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCountryCode;
        private DevComponents.DotNetBar.Controls.ComboTree cbDepartments;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbIndustry;
        private DevComponents.DotNetBar.Controls.TextBoxX cellPhoneTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX cityCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX cityENTextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX clientCommentTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientCoreNoTextBox;
        private System.Windows.Forms.BindingSource clientCreditLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEDICodeColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX clientEDICodeTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx clientLevelComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameEN_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameEN_2TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx clientTypeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientEDICode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractValueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX companyCodeTextBox;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX contactTextBox;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLineColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineCommentTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLineCurrencyColumn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditLineCurrencyComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLineIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLineStatusColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineStatusTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLineTypeColumn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditLineTypeComboBox;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClientCreditLines;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContracts;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diContractDueDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diContractValueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX faxNumberTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreezeDateColumn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput freezeDateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreezerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreezeReasonColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX freezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX freezerTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX groupNoTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientBasic;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientContact;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientCreditLine;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientGroup;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientStat;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelContract;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.CheckBoxX isGroupCheckBox;
        private DevComponents.DotNetBar.LabelX lblGroupNameCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodBeginColumn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodBeginDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodEndColumn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX pMNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX postCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX productCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX productENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX provinceCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX provinceENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX registrationNumberTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX representativeTextBox;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX rMNameTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemClient;
        private DevComponents.DotNetBar.TabItem tabItemClientAccount;
        private DevComponents.DotNetBar.TabItem tabItemClientCreditLine;
        private DevComponents.DotNetBar.TabItem tabItemContract;
        private DevComponents.DotNetBar.TabControlPanel tabPanelClient;
        private DevComponents.DotNetBar.TabControlPanel tabPanelClientAccount;
        private DevComponents.DotNetBar.TabControlPanel tabPanelClientCreditLine;
        private DevComponents.DotNetBar.TabControlPanel tabPanelContract;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractStatus;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupNameEN;
        private DevComponents.DotNetBar.LabelX telephoneLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX telephoneTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnfreezeDateColumn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput unfreezeDateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnfreezerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnfreezeReasonColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezerTextBox;
        private DevComponents.DotNetBar.LabelX websiteLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX websiteTextBox;

        #endregion Fields

        #region Methods (1)

        // Protected Methods (1) 

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

        #endregion Methods



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
            DevComponents.DotNetBar.LabelX lblCreateUserName;
            DevComponents.DotNetBar.LabelX lblContractStatus;
            DevComponents.DotNetBar.LabelX lblContractValueDate;
            DevComponents.DotNetBar.LabelX lblContractDueDate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGroupNameCN = new DevComponents.DotNetBar.LabelX();
            this.websiteLabel = new DevComponents.DotNetBar.LabelX();
            this.telephoneLabel = new DevComponents.DotNetBar.LabelX();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
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
            this.isGroupCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbGroupNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbGroupNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClientClose = new DevComponents.DotNetBar.ButtonX();
            this.btnClientSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelClientStat = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbIndustry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbDepartments = new DevComponents.DotNetBar.Controls.ComboTree();
            this.rMNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pMNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientLevelComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.clientTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanelClientBasic = new DevComponents.DotNetBar.Controls.GroupPanel();
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
            this.clientNameEN_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientNameEN_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientNameCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemClient = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelClientCreditLine = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvClientCreditLines = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.creditLineIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEDICodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLineTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLineCurrencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodBeginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproveNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproveTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLineStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreezeReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreezerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreezeDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnfreezeReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnfreezerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnfreezeDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelClientCreditLine = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClientCreditLineUpdate = new DevComponents.DotNetBar.ButtonX();
            this.creditLineTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clientCreditLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabPanelContract = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvContracts = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractValueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientEDICode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelContract = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnContractUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnContractRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnContractDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnContractSave = new DevComponents.DotNetBar.ButtonX();
            this.btnContractNew = new DevComponents.DotNetBar.ButtonX();
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContractStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diContractDueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diContractValueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tabItemContract = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelClientAccount = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemClientAccount = new DevComponents.DotNetBar.TabItem(this.components);
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.compareValidator2 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblContractStatus = new DevComponents.DotNetBar.LabelX();
            lblContractValueDate = new DevComponents.DotNetBar.LabelX();
            lblContractDueDate = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelClient.SuspendLayout();
            this.groupPanelClientContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupPanelClientGroup.SuspendLayout();
            this.groupPanelClientStat.SuspendLayout();
            this.groupPanelClientBasic.SuspendLayout();
            this.tabPanelClientCreditLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLines)).BeginInit();
            this.groupPanelClientCreditLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unfreezeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBeginDateTimePicker)).BeginInit();
            this.tabPanelContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.groupPanelContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractValueDate)).BeginInit();
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
            clientNameCNLabel.Location = new System.Drawing.Point(44, 30);
            clientNameCNLabel.Name = "clientNameCNLabel";
            clientNameCNLabel.Size = new System.Drawing.Size(37, 18);
            clientNameCNLabel.TabIndex = 2;
            clientNameCNLabel.Text = "客户:";
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
            addressCNLabel.Location = new System.Drawing.Point(44, 94);
            addressCNLabel.Name = "addressCNLabel";
            addressCNLabel.Size = new System.Drawing.Size(37, 18);
            addressCNLabel.TabIndex = 6;
            addressCNLabel.Text = "地址:";
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
            cityCNLabel.Location = new System.Drawing.Point(44, 138);
            cityCNLabel.Name = "cityCNLabel";
            cityCNLabel.Size = new System.Drawing.Size(37, 18);
            cityCNLabel.TabIndex = 12;
            cityCNLabel.Text = "城市:";
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
            provinceCNLabel.Location = new System.Drawing.Point(38, 160);
            provinceCNLabel.Name = "provinceCNLabel";
            provinceCNLabel.Size = new System.Drawing.Size(44, 18);
            provinceCNLabel.TabIndex = 16;
            provinceCNLabel.Text = "省/州:";
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
            productCNLabel.Location = new System.Drawing.Point(393, 6);
            productCNLabel.Name = "productCNLabel";
            productCNLabel.Size = new System.Drawing.Size(62, 18);
            productCNLabel.TabIndex = 9;
            productCNLabel.Text = "经营范围:";
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
            postCodeLabel.Location = new System.Drawing.Point(44, 204);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(37, 18);
            postCodeLabel.TabIndex = 22;
            postCodeLabel.Text = "邮编:";
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
            countryCodeLabel.Location = new System.Drawing.Point(44, 182);
            countryCodeLabel.Name = "countryCodeLabel";
            countryCodeLabel.Size = new System.Drawing.Size(37, 18);
            countryCodeLabel.TabIndex = 20;
            countryCodeLabel.Text = "国家:";
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
            representativeLabel.Location = new System.Drawing.Point(20, 6);
            representativeLabel.Name = "representativeLabel";
            representativeLabel.Size = new System.Drawing.Size(62, 18);
            representativeLabel.TabIndex = 0;
            representativeLabel.Text = "公司法人:";
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
            contactLabel.Location = new System.Drawing.Point(32, 28);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(50, 18);
            contactLabel.TabIndex = 2;
            contactLabel.Text = "联系人:";
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
            emailLabel.Location = new System.Drawing.Point(38, 50);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
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
            faxNumberLabel.Location = new System.Drawing.Point(205, 50);
            faxNumberLabel.Name = "faxNumberLabel";
            faxNumberLabel.Size = new System.Drawing.Size(62, 18);
            faxNumberLabel.TabIndex = 12;
            faxNumberLabel.Text = "传真号码:";
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
            cellPhoneLabel.Location = new System.Drawing.Point(20, 72);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new System.Drawing.Size(62, 18);
            cellPhoneLabel.TabIndex = 6;
            cellPhoneLabel.Text = "手机号码:";
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
            groupNoLabel.Location = new System.Drawing.Point(226, 6);
            groupNoLabel.Name = "groupNoLabel";
            groupNoLabel.Size = new System.Drawing.Size(99, 18);
            groupNoLabel.TabIndex = 2;
            groupNoLabel.Text = "所属集团客户号:";
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
            registrationNumberLabel.Location = new System.Drawing.Point(380, 6);
            registrationNumberLabel.Name = "registrationNumberLabel";
            registrationNumberLabel.Size = new System.Drawing.Size(87, 18);
            registrationNumberLabel.TabIndex = 14;
            registrationNumberLabel.Text = "营业执照号码:";
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
            companyCodeLabel.Location = new System.Drawing.Point(380, 28);
            companyCodeLabel.Name = "companyCodeLabel";
            companyCodeLabel.Size = new System.Drawing.Size(87, 18);
            companyCodeLabel.TabIndex = 16;
            companyCodeLabel.Text = "组织机构代码:";
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
            clientTypeLabel.Location = new System.Drawing.Point(20, 6);
            clientTypeLabel.Name = "clientTypeLabel";
            clientTypeLabel.Size = new System.Drawing.Size(62, 18);
            clientTypeLabel.TabIndex = 0;
            clientTypeLabel.Text = "客户类型:";
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
            clientLevelLabel.Location = new System.Drawing.Point(212, 6);
            clientLevelLabel.Name = "clientLevelLabel";
            clientLevelLabel.Size = new System.Drawing.Size(62, 18);
            clientLevelLabel.TabIndex = 2;
            clientLevelLabel.Text = "客户级别:";
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
            branchCodeLabel.Location = new System.Drawing.Point(20, 28);
            branchCodeLabel.Name = "branchCodeLabel";
            branchCodeLabel.Size = new System.Drawing.Size(62, 18);
            branchCodeLabel.TabIndex = 4;
            branchCodeLabel.Text = "所属机构:";
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
            pMNameLabel.Location = new System.Drawing.Point(20, 50);
            pMNameLabel.Name = "pMNameLabel";
            pMNameLabel.Size = new System.Drawing.Size(62, 18);
            pMNameLabel.TabIndex = 6;
            pMNameLabel.Text = "产品经理:";
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
            rMNameLabel.Location = new System.Drawing.Point(212, 50);
            rMNameLabel.Name = "rMNameLabel";
            rMNameLabel.Size = new System.Drawing.Size(62, 18);
            rMNameLabel.TabIndex = 8;
            rMNameLabel.Text = "客户经理:";
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
            clientNoLabel.Location = new System.Drawing.Point(20, 6);
            clientNoLabel.Name = "clientNoLabel";
            clientNoLabel.Size = new System.Drawing.Size(62, 18);
            clientNoLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            clientNoLabel.TabIndex = 0;
            clientNoLabel.Text = "保理代码:";
            clientNoLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // creditLineCurrencyLabel
            // 
            creditLineCurrencyLabel.AutoSize = true;
            creditLineCurrencyLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineCurrencyLabel.BackgroundStyle.Class = "";
            creditLineCurrencyLabel.Location = new System.Drawing.Point(26, 30);
            creditLineCurrencyLabel.Name = "creditLineCurrencyLabel";
            creditLineCurrencyLabel.Size = new System.Drawing.Size(62, 18);
            creditLineCurrencyLabel.TabIndex = 2;
            creditLineCurrencyLabel.Text = "额度币别:";
            // 
            // creditLineTypeLabel
            // 
            creditLineTypeLabel.AutoSize = true;
            creditLineTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineTypeLabel.BackgroundStyle.Class = "";
            creditLineTypeLabel.Location = new System.Drawing.Point(26, 10);
            creditLineTypeLabel.Name = "creditLineTypeLabel";
            creditLineTypeLabel.Size = new System.Drawing.Size(62, 18);
            creditLineTypeLabel.TabIndex = 3;
            creditLineTypeLabel.Text = "额度种类:";
            // 
            // creditLineLabel
            // 
            creditLineLabel.AutoSize = true;
            creditLineLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineLabel.BackgroundStyle.Class = "";
            creditLineLabel.Location = new System.Drawing.Point(26, 50);
            creditLineLabel.Name = "creditLineLabel";
            creditLineLabel.Size = new System.Drawing.Size(62, 18);
            creditLineLabel.TabIndex = 4;
            creditLineLabel.Text = "额度上限:";
            // 
            // periodBeginLabel
            // 
            periodBeginLabel.AutoSize = true;
            periodBeginLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            periodBeginLabel.BackgroundStyle.Class = "";
            periodBeginLabel.Location = new System.Drawing.Point(227, 9);
            periodBeginLabel.Name = "periodBeginLabel";
            periodBeginLabel.Size = new System.Drawing.Size(62, 18);
            periodBeginLabel.TabIndex = 6;
            periodBeginLabel.Text = "有效期限:";
            // 
            // approveNoLabel
            // 
            approveNoLabel.AutoSize = true;
            approveNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            approveNoLabel.BackgroundStyle.Class = "";
            approveNoLabel.Location = new System.Drawing.Point(227, 30);
            approveNoLabel.Name = "approveNoLabel";
            approveNoLabel.Size = new System.Drawing.Size(62, 18);
            approveNoLabel.TabIndex = 10;
            approveNoLabel.Text = "授信编号:";
            // 
            // approveTypeLabel
            // 
            approveTypeLabel.AutoSize = true;
            approveTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            approveTypeLabel.BackgroundStyle.Class = "";
            approveTypeLabel.Location = new System.Drawing.Point(228, 50);
            approveTypeLabel.Name = "approveTypeLabel";
            approveTypeLabel.Size = new System.Drawing.Size(62, 18);
            approveTypeLabel.TabIndex = 12;
            approveTypeLabel.Text = "授信类型:";
            // 
            // creditLineStatusLabel
            // 
            creditLineStatusLabel.AutoSize = true;
            creditLineStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineStatusLabel.BackgroundStyle.Class = "";
            creditLineStatusLabel.Location = new System.Drawing.Point(26, 69);
            creditLineStatusLabel.Name = "creditLineStatusLabel";
            creditLineStatusLabel.Size = new System.Drawing.Size(62, 18);
            creditLineStatusLabel.TabIndex = 14;
            creditLineStatusLabel.Text = "额度状态:";
            // 
            // freezeReasonLabel
            // 
            freezeReasonLabel.AutoSize = true;
            freezeReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            freezeReasonLabel.BackgroundStyle.Class = "";
            freezeReasonLabel.Location = new System.Drawing.Point(26, 133);
            freezeReasonLabel.Name = "freezeReasonLabel";
            freezeReasonLabel.Size = new System.Drawing.Size(62, 18);
            freezeReasonLabel.TabIndex = 0;
            freezeReasonLabel.Text = "冻结原因:";
            // 
            // freezerLabel
            // 
            freezerLabel.AutoSize = true;
            freezerLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            freezerLabel.BackgroundStyle.Class = "";
            freezerLabel.Location = new System.Drawing.Point(39, 172);
            freezerLabel.Name = "freezerLabel";
            freezerLabel.Size = new System.Drawing.Size(50, 18);
            freezerLabel.TabIndex = 2;
            freezerLabel.Text = "经办人:";
            // 
            // freezeDateLabel
            // 
            freezeDateLabel.AutoSize = true;
            freezeDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            freezeDateLabel.BackgroundStyle.Class = "";
            freezeDateLabel.Location = new System.Drawing.Point(233, 172);
            freezeDateLabel.Name = "freezeDateLabel";
            freezeDateLabel.Size = new System.Drawing.Size(62, 18);
            freezeDateLabel.TabIndex = 4;
            freezeDateLabel.Text = "冻结日期:";
            // 
            // unfreezeReasonLabel
            // 
            unfreezeReasonLabel.AutoSize = true;
            unfreezeReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            unfreezeReasonLabel.BackgroundStyle.Class = "";
            unfreezeReasonLabel.Location = new System.Drawing.Point(26, 199);
            unfreezeReasonLabel.Name = "unfreezeReasonLabel";
            unfreezeReasonLabel.Size = new System.Drawing.Size(62, 18);
            unfreezeReasonLabel.TabIndex = 1;
            unfreezeReasonLabel.Text = "解冻原因:";
            // 
            // unfreezerLabel
            // 
            unfreezerLabel.AutoSize = true;
            unfreezerLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            unfreezerLabel.BackgroundStyle.Class = "";
            unfreezerLabel.Location = new System.Drawing.Point(39, 236);
            unfreezerLabel.Name = "unfreezerLabel";
            unfreezerLabel.Size = new System.Drawing.Size(50, 18);
            unfreezerLabel.TabIndex = 3;
            unfreezerLabel.Text = "经办人:";
            // 
            // unfreezeDateLabel
            // 
            unfreezeDateLabel.AutoSize = true;
            unfreezeDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            unfreezeDateLabel.BackgroundStyle.Class = "";
            unfreezeDateLabel.Location = new System.Drawing.Point(233, 236);
            unfreezeDateLabel.Name = "unfreezeDateLabel";
            unfreezeDateLabel.Size = new System.Drawing.Size(62, 18);
            unfreezeDateLabel.TabIndex = 5;
            unfreezeDateLabel.Text = "解冻日期:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(393, 138);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(37, 18);
            commentLabel.TabIndex = 0;
            commentLabel.Text = "备注:";
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
            creditLineCommentLabel.Location = new System.Drawing.Point(50, 90);
            creditLineCommentLabel.Name = "creditLineCommentLabel";
            creditLineCommentLabel.Size = new System.Drawing.Size(37, 18);
            creditLineCommentLabel.TabIndex = 32;
            creditLineCommentLabel.Text = "备注:";
            // 
            // clientCoreNoLabel
            // 
            clientCoreNoLabel.AutoSize = true;
            // 
            // 
            // 
            clientCoreNoLabel.BackgroundStyle.Class = "";
            clientCoreNoLabel.Location = new System.Drawing.Point(227, 6);
            clientCoreNoLabel.Name = "clientCoreNoLabel";
            clientCoreNoLabel.Size = new System.Drawing.Size(50, 18);
            clientCoreNoLabel.TabIndex = 24;
            clientCoreNoLabel.Text = "客户号:";
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
            industryLabel.Location = new System.Drawing.Point(400, 6);
            industryLabel.Name = "industryLabel";
            industryLabel.Size = new System.Drawing.Size(62, 18);
            industryLabel.TabIndex = 10;
            industryLabel.Text = "所属行业:";
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
            lblContractCode.Location = new System.Drawing.Point(15, 3);
            lblContractCode.Name = "lblContractCode";
            lblContractCode.Size = new System.Drawing.Size(74, 18);
            lblContractCode.TabIndex = 1;
            lblContractCode.Text = "主合同编号:";
            // 
            // lblCreateUserName
            // 
            lblCreateUserName.AutoSize = true;
            lblCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCreateUserName.BackgroundStyle.Class = "";
            lblCreateUserName.Location = new System.Drawing.Point(39, 99);
            lblCreateUserName.Name = "lblCreateUserName";
            lblCreateUserName.Size = new System.Drawing.Size(50, 18);
            lblCreateUserName.TabIndex = 11;
            lblCreateUserName.Text = "经办人:";
            // 
            // lblContractStatus
            // 
            lblContractStatus.AutoSize = true;
            lblContractStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractStatus.BackgroundStyle.Class = "";
            lblContractStatus.Location = new System.Drawing.Point(27, 75);
            lblContractStatus.Name = "lblContractStatus";
            lblContractStatus.Size = new System.Drawing.Size(62, 18);
            lblContractStatus.TabIndex = 9;
            lblContractStatus.Text = "合同状态:";
            // 
            // lblContractValueDate
            // 
            lblContractValueDate.AutoSize = true;
            lblContractValueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractValueDate.BackgroundStyle.Class = "";
            lblContractValueDate.Location = new System.Drawing.Point(3, 27);
            lblContractValueDate.Name = "lblContractValueDate";
            lblContractValueDate.Size = new System.Drawing.Size(87, 18);
            lblContractValueDate.TabIndex = 7;
            lblContractValueDate.Text = "主合同生效日:";
            // 
            // lblContractDueDate
            // 
            lblContractDueDate.AutoSize = true;
            lblContractDueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContractDueDate.BackgroundStyle.Class = "";
            lblContractDueDate.Location = new System.Drawing.Point(3, 51);
            lblContractDueDate.Name = "lblContractDueDate";
            lblContractDueDate.Size = new System.Drawing.Size(87, 18);
            lblContractDueDate.TabIndex = 5;
            lblContractDueDate.Text = "主合同到期日:";
            // 
            // lblGroupNameCN
            // 
            this.lblGroupNameCN.AutoSize = true;
            this.lblGroupNameCN.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblGroupNameCN.BackgroundStyle.Class = "";
            this.lblGroupNameCN.Location = new System.Drawing.Point(10, 29);
            this.lblGroupNameCN.Name = "lblGroupNameCN";
            this.lblGroupNameCN.Size = new System.Drawing.Size(74, 18);
            this.lblGroupNameCN.TabIndex = 4;
            this.lblGroupNameCN.Text = "集团客户名:";
            this.lblGroupNameCN.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.websiteLabel.BackgroundStyle.Class = "";
            this.websiteLabel.Location = new System.Drawing.Point(205, 6);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(62, 18);
            this.websiteLabel.TabIndex = 8;
            this.websiteLabel.Text = "公司网址:";
            this.websiteLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.telephoneLabel.BackgroundStyle.Class = "";
            this.telephoneLabel.Location = new System.Drawing.Point(205, 28);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(62, 18);
            this.telephoneLabel.TabIndex = 10;
            this.telephoneLabel.Text = "联系电话:";
            this.telephoneLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelClient);
            this.tabControl.Controls.Add(this.tabPanelClientCreditLine);
            this.tabControl.Controls.Add(this.tabPanelContract);
            this.tabControl.Controls.Add(this.tabPanelClientAccount);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(614, 567);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemClient);
            this.tabControl.Tabs.Add(this.tabItemClientCreditLine);
            this.tabControl.Tabs.Add(this.tabItemContract);
            this.tabControl.Tabs.Add(this.tabItemClientAccount);
            this.tabControl.Text = "tabControl1";
            // 
            // tabPanelClient
            // 
            this.tabPanelClient.AutoScroll = true;
            this.tabPanelClient.AutoSize = true;
            this.tabPanelClient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabPanelClient.Controls.Add(this.btnClientUpdate);
            this.tabPanelClient.Controls.Add(this.groupPanelClientContact);
            this.tabPanelClient.Controls.Add(this.groupPanelClientGroup);
            this.tabPanelClient.Controls.Add(this.btnClientClose);
            this.tabPanelClient.Controls.Add(this.btnClientSave);
            this.tabPanelClient.Controls.Add(this.groupPanelClientStat);
            this.tabPanelClient.Controls.Add(this.groupPanelClientBasic);
            this.tabPanelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelClient.Location = new System.Drawing.Point(0, 26);
            this.tabPanelClient.Name = "tabPanelClient";
            this.tabPanelClient.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelClient.Size = new System.Drawing.Size(614, 541);
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
            this.btnClientUpdate.Location = new System.Drawing.Point(168, 515);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnClientUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientUpdate.TabIndex = 7;
            this.btnClientUpdate.Text = "更新";
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
            this.groupPanelClientContact.Controls.Add(this.telephoneLabel);
            this.groupPanelClientContact.Controls.Add(this.telephoneTextBox);
            this.groupPanelClientContact.Controls.Add(contactLabel);
            this.groupPanelClientContact.Controls.Add(this.contactTextBox);
            this.groupPanelClientContact.Controls.Add(this.websiteLabel);
            this.groupPanelClientContact.Controls.Add(this.websiteTextBox);
            this.groupPanelClientContact.Controls.Add(representativeLabel);
            this.groupPanelClientContact.Controls.Add(this.representativeTextBox);
            this.groupPanelClientContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientContact.Location = new System.Drawing.Point(1, 401);
            this.groupPanelClientContact.Name = "groupPanelClientContact";
            this.groupPanelClientContact.Size = new System.Drawing.Size(612, 105);
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
            this.groupPanelClientContact.TabIndex = 2;
            // 
            // companyCodeTextBox
            // 
            // 
            // 
            // 
            this.companyCodeTextBox.Border.Class = "TextBoxBorder";
            this.companyCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CompanyCode", true));
            this.companyCodeTextBox.Location = new System.Drawing.Point(468, 28);
            this.companyCodeTextBox.Name = "companyCodeTextBox";
            this.companyCodeTextBox.Size = new System.Drawing.Size(100, 21);
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
            this.registrationNumberTextBox.Location = new System.Drawing.Point(468, 6);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.registrationNumberTextBox.TabIndex = 15;
            // 
            // cellPhoneTextBox
            // 
            // 
            // 
            // 
            this.cellPhoneTextBox.Border.Class = "TextBoxBorder";
            this.cellPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CellPhone", true));
            this.cellPhoneTextBox.Location = new System.Drawing.Point(85, 72);
            this.cellPhoneTextBox.Name = "cellPhoneTextBox";
            this.cellPhoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.cellPhoneTextBox.TabIndex = 7;
            // 
            // faxNumberTextBox
            // 
            // 
            // 
            // 
            this.faxNumberTextBox.Border.Class = "TextBoxBorder";
            this.faxNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FaxNumber", true));
            this.faxNumberTextBox.Location = new System.Drawing.Point(267, 50);
            this.faxNumberTextBox.Name = "faxNumberTextBox";
            this.faxNumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.faxNumberTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.Border.Class = "TextBoxBorder";
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(85, 50);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 21);
            this.emailTextBox.TabIndex = 5;
            // 
            // telephoneTextBox
            // 
            // 
            // 
            // 
            this.telephoneTextBox.Border.Class = "TextBoxBorder";
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(267, 28);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.telephoneTextBox.TabIndex = 11;
            // 
            // contactTextBox
            // 
            // 
            // 
            // 
            this.contactTextBox.Border.Class = "TextBoxBorder";
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(85, 28);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 21);
            this.contactTextBox.TabIndex = 3;
            // 
            // websiteTextBox
            // 
            // 
            // 
            // 
            this.websiteTextBox.Border.Class = "TextBoxBorder";
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(267, 6);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(100, 21);
            this.websiteTextBox.TabIndex = 9;
            // 
            // representativeTextBox
            // 
            // 
            // 
            // 
            this.representativeTextBox.Border.Class = "TextBoxBorder";
            this.representativeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Representative", true));
            this.representativeTextBox.Location = new System.Drawing.Point(85, 6);
            this.representativeTextBox.Name = "representativeTextBox";
            this.representativeTextBox.Size = new System.Drawing.Size(100, 21);
            this.representativeTextBox.TabIndex = 1;
            // 
            // groupPanelClientGroup
            // 
            this.groupPanelClientGroup.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientGroup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelClientGroup.Controls.Add(this.isGroupCheckBox);
            this.groupPanelClientGroup.Controls.Add(this.tbGroupNameEN);
            this.groupPanelClientGroup.Controls.Add(this.tbGroupNameCN);
            this.groupPanelClientGroup.Controls.Add(this.lblGroupNameCN);
            this.groupPanelClientGroup.Controls.Add(groupNoLabel);
            this.groupPanelClientGroup.Controls.Add(this.groupNoTextBox);
            this.groupPanelClientGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientGroup.Location = new System.Drawing.Point(1, 319);
            this.groupPanelClientGroup.Name = "groupPanelClientGroup";
            this.groupPanelClientGroup.Size = new System.Drawing.Size(612, 82);
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
            this.groupPanelClientGroup.TabIndex = 4;
            // 
            // isGroupCheckBox
            // 
            this.isGroupCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isGroupCheckBox.BackgroundStyle.Class = "";
            this.isGroupCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientBindingSource, "IsGroup", true));
            this.isGroupCheckBox.Location = new System.Drawing.Point(85, 6);
            this.isGroupCheckBox.Name = "isGroupCheckBox";
            this.isGroupCheckBox.Size = new System.Drawing.Size(104, 22);
            this.isGroupCheckBox.TabIndex = 7;
            this.isGroupCheckBox.Text = "是否集团客户";
            // 
            // tbGroupNameEN
            // 
            // 
            // 
            // 
            this.tbGroupNameEN.Border.Class = "TextBoxBorder";
            this.tbGroupNameEN.Location = new System.Drawing.Point(85, 50);
            this.tbGroupNameEN.Name = "tbGroupNameEN";
            this.tbGroupNameEN.Size = new System.Drawing.Size(340, 21);
            this.tbGroupNameEN.TabIndex = 6;
            this.tbGroupNameEN.WatermarkText = "英文名";
            // 
            // tbGroupNameCN
            // 
            // 
            // 
            // 
            this.tbGroupNameCN.Border.Class = "TextBoxBorder";
            this.tbGroupNameCN.Location = new System.Drawing.Point(85, 28);
            this.tbGroupNameCN.Name = "tbGroupNameCN";
            this.tbGroupNameCN.Size = new System.Drawing.Size(340, 21);
            this.tbGroupNameCN.TabIndex = 5;
            this.tbGroupNameCN.WatermarkText = "中文名";
            // 
            // groupNoTextBox
            // 
            // 
            // 
            // 
            this.groupNoTextBox.Border.Class = "TextBoxBorder";
            this.groupNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "GroupNo", true));
            this.groupNoTextBox.Location = new System.Drawing.Point(325, 6);
            this.groupNoTextBox.Name = "groupNoTextBox";
            this.groupNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.groupNoTextBox.TabIndex = 3;
            // 
            // btnClientClose
            // 
            this.btnClientClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientClose.Location = new System.Drawing.Point(334, 515);
            this.btnClientClose.Name = "btnClientClose";
            this.btnClientClose.Size = new System.Drawing.Size(75, 21);
            this.btnClientClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientClose.TabIndex = 6;
            this.btnClientClose.Text = "关闭";
            this.btnClientClose.Click += new System.EventHandler(this.CloseClient);
            // 
            // btnClientSave
            // 
            this.btnClientSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientSave.Location = new System.Drawing.Point(253, 515);
            this.btnClientSave.Name = "btnClientSave";
            this.btnClientSave.Size = new System.Drawing.Size(75, 21);
            this.btnClientSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientSave.TabIndex = 5;
            this.btnClientSave.Text = "保存";
            this.btnClientSave.Click += new System.EventHandler(this.SaveClient);
            // 
            // groupPanelClientStat
            // 
            this.groupPanelClientStat.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientStat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.groupPanelClientStat.Location = new System.Drawing.Point(1, 235);
            this.groupPanelClientStat.Name = "groupPanelClientStat";
            this.groupPanelClientStat.Size = new System.Drawing.Size(612, 84);
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
            this.groupPanelClientStat.TabIndex = 3;
            // 
            // cbIndustry
            // 
            this.cbIndustry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Industry", true));
            this.cbIndustry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIndustry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndustry.FormattingEnabled = true;
            this.cbIndustry.Items.AddRange(new object[] {
            "电子",
            "纺织",
            "化工",
            "金属",
            "家电",
            "机械",
            "能源",
            "电力",
            "其他"});
            this.cbIndustry.Location = new System.Drawing.Point(471, 6);
            this.cbIndustry.Name = "cbIndustry";
            this.cbIndustry.Size = new System.Drawing.Size(100, 22);
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
            this.cbDepartments.Location = new System.Drawing.Point(85, 28);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(287, 21);
            this.cbDepartments.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDepartments.TabIndex = 5;
            this.cbDepartments.SelectionChanged += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.cbDepartments_SelectionChanged);
            // 
            // rMNameTextBox
            // 
            // 
            // 
            // 
            this.rMNameTextBox.Border.Class = "TextBoxBorder";
            this.rMNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "RMName", true));
            this.rMNameTextBox.Location = new System.Drawing.Point(277, 50);
            this.rMNameTextBox.Name = "rMNameTextBox";
            this.rMNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.rMNameTextBox.TabIndex = 9;
            // 
            // pMNameTextBox
            // 
            // 
            // 
            // 
            this.pMNameTextBox.Border.Class = "TextBoxBorder";
            this.pMNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PMName", true));
            this.pMNameTextBox.Location = new System.Drawing.Point(85, 50);
            this.pMNameTextBox.Name = "pMNameTextBox";
            this.pMNameTextBox.Size = new System.Drawing.Size(100, 21);
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
            this.clientLevelComboBox.Location = new System.Drawing.Point(277, 6);
            this.clientLevelComboBox.Name = "clientLevelComboBox";
            this.clientLevelComboBox.Size = new System.Drawing.Size(100, 22);
            this.clientLevelComboBox.TabIndex = 3;
            // 
            // clientTypeComboBox
            // 
            this.clientTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientType", true));
            this.clientTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clientTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientTypeComboBox.FormattingEnabled = true;
            this.clientTypeComboBox.Items.AddRange(new object[] {
            "国有",
            "集体",
            "民营",
            "三资",
            "中外合资"});
            this.clientTypeComboBox.Location = new System.Drawing.Point(85, 6);
            this.clientTypeComboBox.Name = "clientTypeComboBox";
            this.clientTypeComboBox.Size = new System.Drawing.Size(100, 22);
            this.clientTypeComboBox.TabIndex = 1;
            // 
            // groupPanelClientBasic
            // 
            this.groupPanelClientBasic.BackColor = System.Drawing.Color.Transparent;
            this.groupPanelClientBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.groupPanelClientBasic.Controls.Add(this.clientNameEN_2TextBox);
            this.groupPanelClientBasic.Controls.Add(this.clientNameEN_1TextBox);
            this.groupPanelClientBasic.Controls.Add(clientNameCNLabel);
            this.groupPanelClientBasic.Controls.Add(this.clientNameCNTextBox);
            this.groupPanelClientBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientBasic.Location = new System.Drawing.Point(1, 1);
            this.groupPanelClientBasic.Name = "groupPanelClientBasic";
            this.groupPanelClientBasic.Size = new System.Drawing.Size(612, 234);
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
            this.groupPanelClientBasic.TabIndex = 1;
            // 
            // clientCoreNoTextBox
            // 
            // 
            // 
            // 
            this.clientCoreNoTextBox.Border.Class = "TextBoxBorder";
            this.clientCoreNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientCoreNo", true));
            this.clientCoreNoTextBox.Location = new System.Drawing.Point(280, 6);
            this.clientCoreNoTextBox.Name = "clientCoreNoTextBox";
            this.clientCoreNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.clientCoreNoTextBox.TabIndex = 25;
            // 
            // clientCommentTextBox
            // 
            // 
            // 
            // 
            this.clientCommentTextBox.Border.Class = "TextBoxBorder";
            this.clientCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Comment", true));
            this.clientCommentTextBox.Location = new System.Drawing.Point(393, 160);
            this.clientCommentTextBox.Multiline = true;
            this.clientCommentTextBox.Name = "clientCommentTextBox";
            this.clientCommentTextBox.Size = new System.Drawing.Size(178, 60);
            this.clientCommentTextBox.TabIndex = 1;
            // 
            // clientEDICodeTextBox
            // 
            // 
            // 
            // 
            this.clientEDICodeTextBox.Border.Class = "TextBoxBorder";
            this.clientEDICodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientEDICode", true));
            this.clientEDICodeTextBox.Location = new System.Drawing.Point(85, 6);
            this.clientEDICodeTextBox.Name = "clientEDICodeTextBox";
            this.clientEDICodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.clientEDICodeTextBox.TabIndex = 1;
            // 
            // cbCountryCode
            // 
            this.cbCountryCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "CountryCode", true));
            this.cbCountryCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountryCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountryCode.Location = new System.Drawing.Point(85, 182);
            this.cbCountryCode.Name = "cbCountryCode";
            this.cbCountryCode.Size = new System.Drawing.Size(100, 22);
            this.cbCountryCode.TabIndex = 21;
            // 
            // postCodeTextBox
            // 
            // 
            // 
            // 
            this.postCodeTextBox.Border.Class = "TextBoxBorder";
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(85, 204);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.postCodeTextBox.TabIndex = 23;
            // 
            // productENTextBox
            // 
            // 
            // 
            // 
            this.productENTextBox.Border.Class = "TextBoxBorder";
            this.productENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProductEN", true));
            this.productENTextBox.Location = new System.Drawing.Point(393, 72);
            this.productENTextBox.Multiline = true;
            this.productENTextBox.Name = "productENTextBox";
            this.productENTextBox.Size = new System.Drawing.Size(178, 42);
            this.productENTextBox.TabIndex = 11;
            this.productENTextBox.WatermarkText = "英文";
            // 
            // productCNTextBox
            // 
            // 
            // 
            // 
            this.productCNTextBox.Border.Class = "TextBoxBorder";
            this.productCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProductCN", true));
            this.productCNTextBox.Location = new System.Drawing.Point(393, 28);
            this.productCNTextBox.Multiline = true;
            this.productCNTextBox.Name = "productCNTextBox";
            this.productCNTextBox.Size = new System.Drawing.Size(178, 42);
            this.productCNTextBox.TabIndex = 10;
            this.productCNTextBox.WatermarkText = "中文";
            // 
            // provinceENTextBox
            // 
            // 
            // 
            // 
            this.provinceENTextBox.Border.Class = "TextBoxBorder";
            this.provinceENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceEN", true));
            this.provinceENTextBox.Location = new System.Drawing.Point(190, 160);
            this.provinceENTextBox.Name = "provinceENTextBox";
            this.provinceENTextBox.Size = new System.Drawing.Size(100, 21);
            this.provinceENTextBox.TabIndex = 19;
            this.provinceENTextBox.WatermarkText = "英文";
            // 
            // provinceCNTextBox
            // 
            // 
            // 
            // 
            this.provinceCNTextBox.Border.Class = "TextBoxBorder";
            this.provinceCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceCN", true));
            this.provinceCNTextBox.Location = new System.Drawing.Point(85, 160);
            this.provinceCNTextBox.Name = "provinceCNTextBox";
            this.provinceCNTextBox.Size = new System.Drawing.Size(100, 21);
            this.provinceCNTextBox.TabIndex = 17;
            this.provinceCNTextBox.WatermarkText = "中文";
            // 
            // cityENTextBox
            // 
            // 
            // 
            // 
            this.cityENTextBox.Border.Class = "TextBoxBorder";
            this.cityENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityEN", true));
            this.cityENTextBox.Location = new System.Drawing.Point(190, 138);
            this.cityENTextBox.Name = "cityENTextBox";
            this.cityENTextBox.Size = new System.Drawing.Size(100, 21);
            this.cityENTextBox.TabIndex = 15;
            this.cityENTextBox.WatermarkText = "英文";
            // 
            // cityCNTextBox
            // 
            // 
            // 
            // 
            this.cityCNTextBox.Border.Class = "TextBoxBorder";
            this.cityCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityCN", true));
            this.cityCNTextBox.Location = new System.Drawing.Point(85, 138);
            this.cityCNTextBox.Name = "cityCNTextBox";
            this.cityCNTextBox.Size = new System.Drawing.Size(100, 21);
            this.cityCNTextBox.TabIndex = 13;
            this.cityCNTextBox.WatermarkText = "中文";
            // 
            // addressENTextBox
            // 
            // 
            // 
            // 
            this.addressENTextBox.Border.Class = "TextBoxBorder";
            this.addressENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressEN", true));
            this.addressENTextBox.Location = new System.Drawing.Point(85, 116);
            this.addressENTextBox.Name = "addressENTextBox";
            this.addressENTextBox.Size = new System.Drawing.Size(295, 21);
            this.addressENTextBox.TabIndex = 8;
            this.addressENTextBox.WatermarkText = "英文地址";
            // 
            // addressCNTextBox
            // 
            // 
            // 
            // 
            this.addressCNTextBox.Border.Class = "TextBoxBorder";
            this.addressCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressCN", true));
            this.addressCNTextBox.Location = new System.Drawing.Point(85, 94);
            this.addressCNTextBox.Name = "addressCNTextBox";
            this.addressCNTextBox.Size = new System.Drawing.Size(295, 21);
            this.addressCNTextBox.TabIndex = 7;
            this.addressCNTextBox.WatermarkText = "中文地址";
            // 
            // clientNameEN_2TextBox
            // 
            // 
            // 
            // 
            this.clientNameEN_2TextBox.Border.Class = "TextBoxBorder";
            this.clientNameEN_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameEN_2", true));
            this.clientNameEN_2TextBox.Location = new System.Drawing.Point(85, 72);
            this.clientNameEN_2TextBox.Name = "clientNameEN_2TextBox";
            this.clientNameEN_2TextBox.Size = new System.Drawing.Size(295, 21);
            this.clientNameEN_2TextBox.TabIndex = 5;
            this.clientNameEN_2TextBox.WatermarkText = "英文名第二行";
            // 
            // clientNameEN_1TextBox
            // 
            // 
            // 
            // 
            this.clientNameEN_1TextBox.Border.Class = "TextBoxBorder";
            this.clientNameEN_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameEN_1", true));
            this.clientNameEN_1TextBox.Location = new System.Drawing.Point(85, 50);
            this.clientNameEN_1TextBox.Name = "clientNameEN_1TextBox";
            this.clientNameEN_1TextBox.Size = new System.Drawing.Size(295, 21);
            this.clientNameEN_1TextBox.TabIndex = 4;
            this.clientNameEN_1TextBox.WatermarkText = "英文名第一行";
            // 
            // clientNameCNTextBox
            // 
            // 
            // 
            // 
            this.clientNameCNTextBox.Border.Class = "TextBoxBorder";
            this.clientNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameCN", true));
            this.clientNameCNTextBox.Location = new System.Drawing.Point(85, 28);
            this.clientNameCNTextBox.Name = "clientNameCNTextBox";
            this.clientNameCNTextBox.Size = new System.Drawing.Size(295, 21);
            this.clientNameCNTextBox.TabIndex = 3;
            this.clientNameCNTextBox.WatermarkText = "中文名";
            // 
            // tabItemClient
            // 
            this.tabItemClient.AttachedControl = this.tabPanelClient;
            this.tabItemClient.Name = "tabItemClient";
            this.tabItemClient.Text = "基本信息";
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
            this.tabPanelClientCreditLine.Size = new System.Drawing.Size(614, 541);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientCreditLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientCreditLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientCreditLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditLineIDColumn,
            this.ClientEDICodeColumn,
            this.CreditLineTypeColumn,
            this.CreditLineCurrencyColumn,
            this.CreditLineColumn,
            this.PeriodBeginColumn,
            this.PeriodEndColumn,
            this.ApproveNoColumn,
            this.ApproveTypeColumn,
            this.CreditLineStatusColumn,
            this.FreezeReasonColumn,
            this.FreezerColumn,
            this.FreezeDateColumn,
            this.UnfreezeReasonColumn,
            this.UnfreezerColumn,
            this.UnfreezeDateColumn,
            this.CommentColumn,
            this.ClientColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientCreditLines.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClientCreditLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientCreditLines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClientCreditLines.Location = new System.Drawing.Point(1, 293);
            this.dgvClientCreditLines.MultiSelect = false;
            this.dgvClientCreditLines.Name = "dgvClientCreditLines";
            this.dgvClientCreditLines.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientCreditLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClientCreditLines.RowTemplate.Height = 23;
            this.dgvClientCreditLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientCreditLines.Size = new System.Drawing.Size(612, 247);
            this.dgvClientCreditLines.TabIndex = 0;
            this.dgvClientCreditLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectClientCreditLine);
            // 
            // creditLineIDColumn
            // 
            this.creditLineIDColumn.DataPropertyName = "CreditLineID";
            this.creditLineIDColumn.HeaderText = "额度编号";
            this.creditLineIDColumn.Name = "creditLineIDColumn";
            this.creditLineIDColumn.ReadOnly = true;
            this.creditLineIDColumn.Visible = false;
            // 
            // ClientEDICodeColumn
            // 
            this.ClientEDICodeColumn.DataPropertyName = "ClientEDICode";
            this.ClientEDICodeColumn.HeaderText = "客户保理代码";
            this.ClientEDICodeColumn.Name = "ClientEDICodeColumn";
            this.ClientEDICodeColumn.ReadOnly = true;
            // 
            // CreditLineTypeColumn
            // 
            this.CreditLineTypeColumn.DataPropertyName = "CreditLineType";
            this.CreditLineTypeColumn.HeaderText = "额度类型";
            this.CreditLineTypeColumn.Name = "CreditLineTypeColumn";
            this.CreditLineTypeColumn.ReadOnly = true;
            // 
            // CreditLineCurrencyColumn
            // 
            this.CreditLineCurrencyColumn.DataPropertyName = "CreditLineCurrency";
            this.CreditLineCurrencyColumn.HeaderText = "额度币种";
            this.CreditLineCurrencyColumn.Name = "CreditLineCurrencyColumn";
            this.CreditLineCurrencyColumn.ReadOnly = true;
            // 
            // CreditLineColumn
            // 
            this.CreditLineColumn.DataPropertyName = "CreditLine";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.CreditLineColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.CreditLineColumn.HeaderText = "额度上限";
            this.CreditLineColumn.Name = "CreditLineColumn";
            this.CreditLineColumn.ReadOnly = true;
            // 
            // PeriodBeginColumn
            // 
            this.PeriodBeginColumn.DataPropertyName = "PeriodBegin";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.PeriodBeginColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.PeriodBeginColumn.HeaderText = "有效期(始)";
            this.PeriodBeginColumn.Name = "PeriodBeginColumn";
            this.PeriodBeginColumn.ReadOnly = true;
            // 
            // PeriodEndColumn
            // 
            this.PeriodEndColumn.DataPropertyName = "PeriodEnd";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.PeriodEndColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.PeriodEndColumn.HeaderText = "有效期(终)";
            this.PeriodEndColumn.Name = "PeriodEndColumn";
            this.PeriodEndColumn.ReadOnly = true;
            // 
            // ApproveNoColumn
            // 
            this.ApproveNoColumn.DataPropertyName = "ApproveNo";
            this.ApproveNoColumn.HeaderText = "授信编号";
            this.ApproveNoColumn.Name = "ApproveNoColumn";
            this.ApproveNoColumn.ReadOnly = true;
            // 
            // ApproveTypeColumn
            // 
            this.ApproveTypeColumn.DataPropertyName = "ApproveType";
            this.ApproveTypeColumn.HeaderText = "授信类型";
            this.ApproveTypeColumn.Name = "ApproveTypeColumn";
            this.ApproveTypeColumn.ReadOnly = true;
            // 
            // CreditLineStatusColumn
            // 
            this.CreditLineStatusColumn.DataPropertyName = "CreditLineStatus";
            this.CreditLineStatusColumn.HeaderText = "额度状态";
            this.CreditLineStatusColumn.Name = "CreditLineStatusColumn";
            this.CreditLineStatusColumn.ReadOnly = true;
            // 
            // FreezeReasonColumn
            // 
            this.FreezeReasonColumn.DataPropertyName = "FreezeReason";
            this.FreezeReasonColumn.HeaderText = "冻结原因";
            this.FreezeReasonColumn.Name = "FreezeReasonColumn";
            this.FreezeReasonColumn.ReadOnly = true;
            // 
            // FreezerColumn
            // 
            this.FreezerColumn.DataPropertyName = "Freezer";
            this.FreezerColumn.HeaderText = "冻结人";
            this.FreezerColumn.Name = "FreezerColumn";
            this.FreezerColumn.ReadOnly = true;
            // 
            // FreezeDateColumn
            // 
            this.FreezeDateColumn.DataPropertyName = "FreezeDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.FreezeDateColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.FreezeDateColumn.HeaderText = "冻结日期";
            this.FreezeDateColumn.Name = "FreezeDateColumn";
            this.FreezeDateColumn.ReadOnly = true;
            // 
            // UnfreezeReasonColumn
            // 
            this.UnfreezeReasonColumn.DataPropertyName = "UnfreezeReason";
            this.UnfreezeReasonColumn.HeaderText = "解冻原因";
            this.UnfreezeReasonColumn.Name = "UnfreezeReasonColumn";
            this.UnfreezeReasonColumn.ReadOnly = true;
            // 
            // UnfreezerColumn
            // 
            this.UnfreezerColumn.DataPropertyName = "Unfreezer";
            this.UnfreezerColumn.HeaderText = "解冻人";
            this.UnfreezerColumn.Name = "UnfreezerColumn";
            this.UnfreezerColumn.ReadOnly = true;
            // 
            // UnfreezeDateColumn
            // 
            this.UnfreezeDateColumn.DataPropertyName = "UnfreezeDate";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.UnfreezeDateColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.UnfreezeDateColumn.HeaderText = "解冻日期";
            this.UnfreezeDateColumn.Name = "UnfreezeDateColumn";
            this.UnfreezeDateColumn.ReadOnly = true;
            // 
            // CommentColumn
            // 
            this.CommentColumn.DataPropertyName = "Comment";
            this.CommentColumn.HeaderText = "备注";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.ReadOnly = true;
            // 
            // ClientColumn
            // 
            this.ClientColumn.DataPropertyName = "Client";
            this.ClientColumn.HeaderText = "Client";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            this.ClientColumn.Visible = false;
            // 
            // groupPanelClientCreditLine
            // 
            this.groupPanelClientCreditLine.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelClientCreditLine.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.groupPanelClientCreditLine.Size = new System.Drawing.Size(612, 292);
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
            // btnClientCreditLineUpdate
            // 
            this.btnClientCreditLineUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineUpdate.Location = new System.Drawing.Point(171, 258);
            this.btnClientCreditLineUpdate.Name = "btnClientCreditLineUpdate";
            this.btnClientCreditLineUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnClientCreditLineUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineUpdate.TabIndex = 36;
            this.btnClientCreditLineUpdate.Text = "更新";
            this.btnClientCreditLineUpdate.Click += new System.EventHandler(this.UpdateClientCreditLine);
            // 
            // creditLineTextBox
            // 
            // 
            // 
            // 
            this.creditLineTextBox.Border.Class = "TextBoxBorder";
            this.creditLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreditLine", true));
            this.creditLineTextBox.Location = new System.Drawing.Point(90, 48);
            this.creditLineTextBox.Name = "creditLineTextBox";
            this.creditLineTextBox.Size = new System.Drawing.Size(121, 21);
            this.creditLineTextBox.TabIndex = 35;
            // 
            // clientCreditLineBindingSource
            // 
            this.clientCreditLineBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.ClientCreditLine);
            // 
            // btnClientCreditLineRefresh
            // 
            this.btnClientCreditLineRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineRefresh.Location = new System.Drawing.Point(11, 258);
            this.btnClientCreditLineRefresh.Name = "btnClientCreditLineRefresh";
            this.btnClientCreditLineRefresh.Size = new System.Drawing.Size(75, 21);
            this.btnClientCreditLineRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineRefresh.TabIndex = 34;
            this.btnClientCreditLineRefresh.Text = "刷新";
            this.btnClientCreditLineRefresh.Click += new System.EventHandler(this.RefreshClientCreditLine);
            // 
            // creditLineCommentTextBox
            // 
            // 
            // 
            // 
            this.creditLineCommentTextBox.Border.Class = "TextBoxBorder";
            this.creditLineCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "Comment", true));
            this.creditLineCommentTextBox.Location = new System.Drawing.Point(90, 87);
            this.creditLineCommentTextBox.Multiline = true;
            this.creditLineCommentTextBox.Name = "creditLineCommentTextBox";
            this.creditLineCommentTextBox.Size = new System.Drawing.Size(451, 39);
            this.creditLineCommentTextBox.TabIndex = 33;
            // 
            // unfreezeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.unfreezeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.unfreezeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "UnfreezeDate", true));
            this.unfreezeDateDateTimePicker.Enabled = false;
            this.unfreezeDateDateTimePicker.Location = new System.Drawing.Point(297, 234);
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.unfreezeDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
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
            this.unfreezeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.unfreezeDateDateTimePicker.Name = "unfreezeDateDateTimePicker";
            this.unfreezeDateDateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.unfreezeDateDateTimePicker.TabIndex = 6;
            // 
            // btnClientCreditLineUnfreeze
            // 
            this.btnClientCreditLineUnfreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineUnfreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineUnfreeze.Location = new System.Drawing.Point(495, 258);
            this.btnClientCreditLineUnfreeze.Name = "btnClientCreditLineUnfreeze";
            this.btnClientCreditLineUnfreeze.Size = new System.Drawing.Size(75, 21);
            this.btnClientCreditLineUnfreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineUnfreeze.TabIndex = 20;
            this.btnClientCreditLineUnfreeze.Text = "解冻";
            this.btnClientCreditLineUnfreeze.Click += new System.EventHandler(this.UnfreezeClientCreditLine);
            // 
            // unfreezerTextBox
            // 
            // 
            // 
            // 
            this.unfreezerTextBox.Border.Class = "TextBoxBorder";
            this.unfreezerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "Unfreezer", true));
            this.unfreezerTextBox.Location = new System.Drawing.Point(90, 234);
            this.unfreezerTextBox.Name = "unfreezerTextBox";
            this.unfreezerTextBox.ReadOnly = true;
            this.unfreezerTextBox.Size = new System.Drawing.Size(100, 21);
            this.unfreezerTextBox.TabIndex = 4;
            // 
            // freezeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.freezeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.freezeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.freezeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "FreezeDate", true));
            this.freezeDateDateTimePicker.Enabled = false;
            this.freezeDateDateTimePicker.Location = new System.Drawing.Point(297, 169);
            // 
            // 
            // 
            this.freezeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.freezeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.freezeDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
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
            this.freezeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.freezeDateDateTimePicker.Name = "freezeDateDateTimePicker";
            this.freezeDateDateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.freezeDateDateTimePicker.TabIndex = 5;
            // 
            // btnClientCreditLineFreeze
            // 
            this.btnClientCreditLineFreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineFreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineFreeze.Location = new System.Drawing.Point(414, 258);
            this.btnClientCreditLineFreeze.Name = "btnClientCreditLineFreeze";
            this.btnClientCreditLineFreeze.Size = new System.Drawing.Size(75, 21);
            this.btnClientCreditLineFreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineFreeze.TabIndex = 19;
            this.btnClientCreditLineFreeze.Text = "冻结";
            this.btnClientCreditLineFreeze.Click += new System.EventHandler(this.FreezeClientCreditLine);
            // 
            // unfreezeReasonTextBox
            // 
            // 
            // 
            // 
            this.unfreezeReasonTextBox.Border.Class = "TextBoxBorder";
            this.unfreezeReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "UnfreezeReason", true));
            this.unfreezeReasonTextBox.Location = new System.Drawing.Point(90, 193);
            this.unfreezeReasonTextBox.Multiline = true;
            this.unfreezeReasonTextBox.Name = "unfreezeReasonTextBox";
            this.unfreezeReasonTextBox.ReadOnly = true;
            this.unfreezeReasonTextBox.Size = new System.Drawing.Size(451, 35);
            this.unfreezeReasonTextBox.TabIndex = 2;
            // 
            // freezeReasonTextBox
            // 
            // 
            // 
            // 
            this.freezeReasonTextBox.Border.Class = "TextBoxBorder";
            this.freezeReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "FreezeReason", true));
            this.freezeReasonTextBox.Location = new System.Drawing.Point(90, 130);
            this.freezeReasonTextBox.Multiline = true;
            this.freezeReasonTextBox.Name = "freezeReasonTextBox";
            this.freezeReasonTextBox.ReadOnly = true;
            this.freezeReasonTextBox.Size = new System.Drawing.Size(451, 33);
            this.freezeReasonTextBox.TabIndex = 1;
            // 
            // btnClientCreditLineDelete
            // 
            this.btnClientCreditLineDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineDelete.Location = new System.Drawing.Point(333, 258);
            this.btnClientCreditLineDelete.Name = "btnClientCreditLineDelete";
            this.btnClientCreditLineDelete.Size = new System.Drawing.Size(75, 21);
            this.btnClientCreditLineDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineDelete.TabIndex = 18;
            this.btnClientCreditLineDelete.Text = "删除";
            this.btnClientCreditLineDelete.Click += new System.EventHandler(this.DeleteClientCreditLine);
            // 
            // btnClientCreditLineSave
            // 
            this.btnClientCreditLineSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineSave.Location = new System.Drawing.Point(252, 258);
            this.btnClientCreditLineSave.Name = "btnClientCreditLineSave";
            this.btnClientCreditLineSave.Size = new System.Drawing.Size(75, 21);
            this.btnClientCreditLineSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineSave.TabIndex = 17;
            this.btnClientCreditLineSave.Text = "保存";
            this.btnClientCreditLineSave.Click += new System.EventHandler(this.SaveClientCreditLine);
            // 
            // freezerTextBox
            // 
            // 
            // 
            // 
            this.freezerTextBox.Border.Class = "TextBoxBorder";
            this.freezerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "Freezer", true));
            this.freezerTextBox.Location = new System.Drawing.Point(90, 169);
            this.freezerTextBox.Name = "freezerTextBox";
            this.freezerTextBox.ReadOnly = true;
            this.freezerTextBox.Size = new System.Drawing.Size(100, 21);
            this.freezerTextBox.TabIndex = 3;
            // 
            // btnClientCreditLineNew
            // 
            this.btnClientCreditLineNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineNew.Location = new System.Drawing.Point(90, 258);
            this.btnClientCreditLineNew.Name = "btnClientCreditLineNew";
            this.btnClientCreditLineNew.Size = new System.Drawing.Size(75, 21);
            this.btnClientCreditLineNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineNew.TabIndex = 16;
            this.btnClientCreditLineNew.Text = "新建";
            this.btnClientCreditLineNew.Click += new System.EventHandler(this.NewClientCreditLine);
            // 
            // creditLineStatusTextBox
            // 
            // 
            // 
            // 
            this.creditLineStatusTextBox.Border.Class = "TextBoxBorder";
            this.creditLineStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreditLineStatus", true));
            this.creditLineStatusTextBox.Location = new System.Drawing.Point(90, 66);
            this.creditLineStatusTextBox.Name = "creditLineStatusTextBox";
            this.creditLineStatusTextBox.ReadOnly = true;
            this.creditLineStatusTextBox.Size = new System.Drawing.Size(121, 21);
            this.creditLineStatusTextBox.TabIndex = 15;
            // 
            // approveTypeComboBox
            // 
            this.approveTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "ApproveType", true));
            this.approveTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.approveTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approveTypeComboBox.FormattingEnabled = true;
            this.approveTypeComboBox.Items.AddRange(new object[] {
            "综合授信",
            "国际双保理",
            "进口保理",
            "有追索权保理",
            "无追索权保理"});
            this.approveTypeComboBox.Location = new System.Drawing.Point(292, 47);
            this.approveTypeComboBox.Name = "approveTypeComboBox";
            this.approveTypeComboBox.Size = new System.Drawing.Size(121, 22);
            this.approveTypeComboBox.TabIndex = 13;
            // 
            // approveNoTextBox
            // 
            // 
            // 
            // 
            this.approveNoTextBox.Border.Class = "TextBoxBorder";
            this.approveNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "ApproveNo", true));
            this.approveNoTextBox.Location = new System.Drawing.Point(291, 27);
            this.approveNoTextBox.Name = "approveNoTextBox";
            this.approveNoTextBox.Size = new System.Drawing.Size(122, 21);
            this.approveNoTextBox.TabIndex = 11;
            // 
            // periodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.periodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.periodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.periodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "PeriodEnd", true));
            this.periodEndDateTimePicker.Location = new System.Drawing.Point(419, 5);
            // 
            // 
            // 
            this.periodEndDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.periodEndDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.periodEndDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
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
            this.periodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.periodEndDateTimePicker.Name = "periodEndDateTimePicker";
            this.periodEndDateTimePicker.Size = new System.Drawing.Size(122, 21);
            this.periodEndDateTimePicker.TabIndex = 9;
            this.superValidator.SetValidator1(this.periodEndDateTimePicker, this.compareValidator2);
            // 
            // periodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.periodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.periodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.periodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "PeriodBegin", true));
            this.periodBeginDateTimePicker.Location = new System.Drawing.Point(291, 5);
            // 
            // 
            // 
            this.periodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.periodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.periodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
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
            this.periodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.periodBeginDateTimePicker.Name = "periodBeginDateTimePicker";
            this.periodBeginDateTimePicker.Size = new System.Drawing.Size(122, 21);
            this.periodBeginDateTimePicker.TabIndex = 7;
            // 
            // creditLineTypeComboBox
            // 
            this.creditLineTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreditLineType", true));
            this.creditLineTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creditLineTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditLineTypeComboBox.FormattingEnabled = true;
            this.creditLineTypeComboBox.Items.AddRange(new object[] {
            "保理预付款融资额度",
            "买方信用风险担保额度"});
            this.creditLineTypeComboBox.Location = new System.Drawing.Point(90, 6);
            this.creditLineTypeComboBox.Name = "creditLineTypeComboBox";
            this.creditLineTypeComboBox.Size = new System.Drawing.Size(121, 22);
            this.creditLineTypeComboBox.TabIndex = 4;
            // 
            // creditLineCurrencyComboBox
            // 
            this.creditLineCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientCreditLineBindingSource, "CreditLineCurrency", true));
            this.creditLineCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creditLineCurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditLineCurrencyComboBox.Location = new System.Drawing.Point(90, 27);
            this.creditLineCurrencyComboBox.Name = "creditLineCurrencyComboBox";
            this.creditLineCurrencyComboBox.Size = new System.Drawing.Size(121, 22);
            this.creditLineCurrencyComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.creditLineCurrencyComboBox.TabIndex = 3;
            // 
            // tabItemClientCreditLine
            // 
            this.tabItemClientCreditLine.AttachedControl = this.tabPanelClientCreditLine;
            this.tabItemClientCreditLine.Name = "tabItemClientCreditLine";
            this.tabItemClientCreditLine.Text = "额度信息";
            // 
            // tabPanelContract
            // 
            this.tabPanelContract.Controls.Add(this.dgvContracts);
            this.tabPanelContract.Controls.Add(this.groupPanelContract);
            this.tabPanelContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelContract.Location = new System.Drawing.Point(0, 26);
            this.tabPanelContract.Name = "tabPanelContract";
            this.tabPanelContract.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelContract.Size = new System.Drawing.Size(614, 541);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContractCode,
            this.colContractValueDate,
            this.colContractDueDate,
            this.colContractStatus,
            this.colCreateUserName,
            this.colClient,
            this.colClientEDICode});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContracts.Location = new System.Drawing.Point(1, 155);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvContracts.RowTemplate.Height = 23;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(612, 385);
            this.dgvContracts.TabIndex = 15;
            this.dgvContracts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectContract);
            // 
            // colContractCode
            // 
            this.colContractCode.DataPropertyName = "ContractCode";
            this.colContractCode.HeaderText = "合同号";
            this.colContractCode.Name = "colContractCode";
            this.colContractCode.ReadOnly = true;
            // 
            // colContractValueDate
            // 
            this.colContractValueDate.DataPropertyName = "ContractValueDate";
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.colContractValueDate.DefaultCellStyle = dataGridViewCellStyle10;
            this.colContractValueDate.HeaderText = "生效日";
            this.colContractValueDate.Name = "colContractValueDate";
            this.colContractValueDate.ReadOnly = true;
            // 
            // colContractDueDate
            // 
            this.colContractDueDate.DataPropertyName = "ContractDueDate";
            dataGridViewCellStyle11.Format = "d";
            this.colContractDueDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.colContractDueDate.HeaderText = "到期日";
            this.colContractDueDate.Name = "colContractDueDate";
            this.colContractDueDate.ReadOnly = true;
            // 
            // colContractStatus
            // 
            this.colContractStatus.DataPropertyName = "ContractStatus";
            this.colContractStatus.HeaderText = "合同状态";
            this.colContractStatus.Name = "colContractStatus";
            this.colContractStatus.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "Client";
            this.colClient.HeaderText = "Client";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Visible = false;
            // 
            // colClientEDICode
            // 
            this.colClientEDICode.DataPropertyName = "ClientEDICode";
            this.colClientEDICode.HeaderText = "ClientEDICode";
            this.colClientEDICode.Name = "colClientEDICode";
            this.colClientEDICode.ReadOnly = true;
            this.colClientEDICode.Visible = false;
            // 
            // groupPanelContract
            // 
            this.groupPanelContract.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelContract.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelContract.Controls.Add(this.btnContractUpdate);
            this.groupPanelContract.Controls.Add(this.btnContractRefresh);
            this.groupPanelContract.Controls.Add(this.btnContractDelete);
            this.groupPanelContract.Controls.Add(this.btnContractSave);
            this.groupPanelContract.Controls.Add(this.btnContractNew);
            this.groupPanelContract.Controls.Add(lblContractCode);
            this.groupPanelContract.Controls.Add(lblCreateUserName);
            this.groupPanelContract.Controls.Add(this.tbContractCode);
            this.groupPanelContract.Controls.Add(this.tbCreateUserName);
            this.groupPanelContract.Controls.Add(lblContractStatus);
            this.groupPanelContract.Controls.Add(this.tbContractStatus);
            this.groupPanelContract.Controls.Add(lblContractValueDate);
            this.groupPanelContract.Controls.Add(this.diContractDueDate);
            this.groupPanelContract.Controls.Add(this.diContractValueDate);
            this.groupPanelContract.Controls.Add(lblContractDueDate);
            this.groupPanelContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelContract.Location = new System.Drawing.Point(1, 1);
            this.groupPanelContract.Name = "groupPanelContract";
            this.groupPanelContract.Size = new System.Drawing.Size(612, 154);
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
            // btnContractUpdate
            // 
            this.btnContractUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractUpdate.Location = new System.Drawing.Point(269, 123);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnContractUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractUpdate.TabIndex = 41;
            this.btnContractUpdate.Text = "更新";
            this.btnContractUpdate.Click += new System.EventHandler(this.UpdateContract);
            // 
            // btnContractRefresh
            // 
            this.btnContractRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractRefresh.Location = new System.Drawing.Point(109, 123);
            this.btnContractRefresh.Name = "btnContractRefresh";
            this.btnContractRefresh.Size = new System.Drawing.Size(75, 21);
            this.btnContractRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractRefresh.TabIndex = 40;
            this.btnContractRefresh.Text = "刷新";
            // 
            // btnContractDelete
            // 
            this.btnContractDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractDelete.Location = new System.Drawing.Point(431, 123);
            this.btnContractDelete.Name = "btnContractDelete";
            this.btnContractDelete.Size = new System.Drawing.Size(75, 21);
            this.btnContractDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractDelete.TabIndex = 39;
            this.btnContractDelete.Text = "删除";
            this.btnContractDelete.Click += new System.EventHandler(this.DeleteContract);
            // 
            // btnContractSave
            // 
            this.btnContractSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractSave.Location = new System.Drawing.Point(350, 123);
            this.btnContractSave.Name = "btnContractSave";
            this.btnContractSave.Size = new System.Drawing.Size(75, 21);
            this.btnContractSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractSave.TabIndex = 38;
            this.btnContractSave.Text = "保存";
            this.btnContractSave.Click += new System.EventHandler(this.SaveContract);
            // 
            // btnContractNew
            // 
            this.btnContractNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractNew.Location = new System.Drawing.Point(188, 123);
            this.btnContractNew.Name = "btnContractNew";
            this.btnContractNew.Size = new System.Drawing.Size(75, 21);
            this.btnContractNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractNew.TabIndex = 37;
            this.btnContractNew.Text = "新建";
            this.btnContractNew.Click += new System.EventHandler(this.NewContract);
            // 
            // tbContractCode
            // 
            // 
            // 
            // 
            this.tbContractCode.Border.Class = "TextBoxBorder";
            this.tbContractCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractCode", true));
            this.tbContractCode.Location = new System.Drawing.Point(99, 3);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(100, 21);
            this.tbContractCode.TabIndex = 2;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Contract);
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CreateUserName", true));
            this.tbCreateUserName.Location = new System.Drawing.Point(99, 99);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 21);
            this.tbCreateUserName.TabIndex = 12;
            // 
            // tbContractStatus
            // 
            // 
            // 
            // 
            this.tbContractStatus.Border.Class = "TextBoxBorder";
            this.tbContractStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractStatus", true));
            this.tbContractStatus.Location = new System.Drawing.Point(99, 75);
            this.tbContractStatus.Name = "tbContractStatus";
            this.tbContractStatus.Size = new System.Drawing.Size(100, 21);
            this.tbContractStatus.TabIndex = 10;
            // 
            // diContractDueDate
            // 
            // 
            // 
            // 
            this.diContractDueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diContractDueDate.ButtonDropDown.Visible = true;
            this.diContractDueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractDueDate", true));
            this.diContractDueDate.Location = new System.Drawing.Point(99, 51);
            // 
            // 
            // 
            this.diContractDueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diContractDueDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diContractDueDate.MonthCalendar.BackgroundStyle.Class = "";
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
            this.diContractDueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diContractDueDate.Name = "diContractDueDate";
            this.diContractDueDate.Size = new System.Drawing.Size(100, 21);
            this.diContractDueDate.TabIndex = 6;
            this.superValidator.SetValidator1(this.diContractDueDate, this.compareValidator1);
            // 
            // diContractValueDate
            // 
            // 
            // 
            // 
            this.diContractValueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diContractValueDate.ButtonDropDown.Visible = true;
            this.diContractValueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractValueDate", true));
            this.diContractValueDate.Location = new System.Drawing.Point(99, 27);
            // 
            // 
            // 
            this.diContractValueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diContractValueDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diContractValueDate.MonthCalendar.BackgroundStyle.Class = "";
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
            this.diContractValueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diContractValueDate.Name = "diContractValueDate";
            this.diContractValueDate.Size = new System.Drawing.Size(100, 21);
            this.diContractValueDate.TabIndex = 8;
            // 
            // tabItemContract
            // 
            this.tabItemContract.AttachedControl = this.tabPanelContract;
            this.tabItemContract.Name = "tabItemContract";
            this.tabItemContract.Text = "主合同";
            // 
            // tabPanelClientAccount
            // 
            this.tabPanelClientAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelClientAccount.Location = new System.Drawing.Point(0, 26);
            this.tabPanelClientAccount.Name = "tabPanelClientAccount";
            this.tabPanelClientAccount.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelClientAccount.Size = new System.Drawing.Size(614, 541);
            this.tabPanelClientAccount.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelClientAccount.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelClientAccount.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelClientAccount.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelClientAccount.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelClientAccount.Style.GradientAngle = 90;
            this.tabPanelClientAccount.TabIndex = 3;
            this.tabPanelClientAccount.TabItem = this.tabItemClientAccount;
            // 
            // tabItemClientAccount
            // 
            this.tabItemClientAccount.AttachedControl = this.tabPanelClientAccount;
            this.tabItemClientAccount.Name = "tabItemClientAccount";
            this.tabItemClientAccount.Text = "账户信息";
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "Your error message here.";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            this.superValidator.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // compareValidator2
            // 
            this.compareValidator2.ControlToCompare = this.periodBeginDateTimePicker;
            this.compareValidator2.ErrorMessage = "到期日应该大于起始日";
            this.compareValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator2.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            this.compareValidator2.ValuePropertyName = "Value";
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.diContractValueDate;
            this.compareValidator1.ErrorMessage = "到期日应该大于生效日";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            this.compareValidator1.ValuePropertyName = "Value";
            this.compareValidator1.ValueToCompare = "";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CreditLineID";
            this.dataGridViewTextBoxColumn1.HeaderText = "额度编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientEDICode";
            this.dataGridViewTextBoxColumn2.HeaderText = "客户保理代码";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreditLineType";
            this.dataGridViewTextBoxColumn3.HeaderText = "额度类型";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreditLineCurrency";
            this.dataGridViewTextBoxColumn4.HeaderText = "额度币种";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreditLine";
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn5.HeaderText = "额度上限";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PeriodBegin";
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn6.HeaderText = "有效期(始)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PeriodEnd";
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn7.HeaderText = "有效期(终)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ApproveNo";
            this.dataGridViewTextBoxColumn8.HeaderText = "授信编号";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ApproveType";
            this.dataGridViewTextBoxColumn9.HeaderText = "授信类型";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CreditLineStatus";
            this.dataGridViewTextBoxColumn10.HeaderText = "额度状态";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FreezeReason";
            this.dataGridViewTextBoxColumn11.HeaderText = "冻结原因";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Freezer";
            this.dataGridViewTextBoxColumn12.HeaderText = "冻结人";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FreezeDate";
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn13.HeaderText = "冻结日期";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UnfreezeReason";
            this.dataGridViewTextBoxColumn14.HeaderText = "解冻原因";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Unfreezer";
            this.dataGridViewTextBoxColumn15.HeaderText = "解冻人";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UnfreezeDate";
            dataGridViewCellStyle18.Format = "d";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn16.HeaderText = "解冻日期";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn17.HeaderText = "备注";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn18.HeaderText = "Client";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ContractCode";
            this.dataGridViewTextBoxColumn19.HeaderText = "合同号";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 110;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ContractValueDate";
            dataGridViewCellStyle19.Format = "d";
            dataGridViewCellStyle19.NullValue = null;
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn20.HeaderText = "生效日";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 111;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ContractDueDate";
            dataGridViewCellStyle20.Format = "d";
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn21.HeaderText = "到期日";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 110;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ContractStatus";
            this.dataGridViewTextBoxColumn22.HeaderText = "合同状态";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 111;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn23.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 110;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn24.HeaderText = "Client";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ClientEDICode";
            this.dataGridViewTextBoxColumn25.HeaderText = "ClientEDICode";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // ClientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 567);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "ClientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "客户详细信息";
            this.Leave += new System.EventHandler(this.ClientDetail_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
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
            this.tabPanelClientCreditLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLines)).EndInit();
            this.groupPanelClientCreditLine.ResumeLayout(false);
            this.groupPanelClientCreditLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unfreezeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBeginDateTimePicker)).EndInit();
            this.tabPanelContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.groupPanelContract.ResumeLayout(false);
            this.groupPanelContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diContractValueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
    }
}