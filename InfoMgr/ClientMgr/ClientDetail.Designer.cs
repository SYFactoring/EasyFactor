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
        #region Fields (149)

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
        private DevComponents.DotNetBar.ButtonX btnClientReset;
        private DevComponents.DotNetBar.ButtonX btnClientSave;
        private DevComponents.DotNetBar.ButtonX btnClientUpdate;
        private DevComponents.DotNetBar.ButtonX btnContractDelete;
        private DevComponents.DotNetBar.ButtonX btnContractNew;
        private DevComponents.DotNetBar.ButtonX btnContractRefresh;
        private DevComponents.DotNetBar.ButtonX btnContractSave;
        private DevComponents.DotNetBar.ButtonX btnContractUpdate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbContractType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCountryCode;
        private DevComponents.DotNetBar.Controls.ComboTree cbDepartments;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbIndustry;
        private DevComponents.DotNetBar.Controls.TextBoxX cellPhoneTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX cityCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX cityENTextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX clientCommentTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientCoreNoTextBox;
        private System.Windows.Forms.BindingSource clientCreditLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEDICodeColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX clientEDICodeTextBox;
        private System.Windows.Forms.ErrorProvider clientErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter clientHighlighter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx clientLevelComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameEN_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX clientNameEN_2TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx clientTypeComboBox;
        private DevComponents.DotNetBar.Validator.SuperValidator clientValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractValueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezeReason;
        private DevComponents.DotNetBar.Controls.TextBoxX companyCodeTextBox;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX contactTextBox;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.ErrorProvider contractErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter contractHighlighter;
        private DevComponents.DotNetBar.Validator.SuperValidator contractValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineCommentTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditLineCurrencyComboBox;
        private System.Windows.Forms.ErrorProvider creditLineErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter creditLineHighlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineStatusTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditLineTypeComboBox;
        private DevComponents.DotNetBar.Validator.SuperValidator creditLineValidator;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator3;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator4;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator5;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClientCreditLines;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContracts;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diContractDueDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diContractValueDate;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX faxNumberTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput freezeDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX freezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX freezerTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX groupNoTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientBasic;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientContact;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientCreditLine;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientGroup;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelClientStat;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelContract;
        private DevComponents.DotNetBar.Controls.CheckBoxX isGroupCheckBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodBeginDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX pMNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX postCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX productCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX productENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX provinceCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX provinceENTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX registrationNumberTextBox;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX representativeTextBox;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
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
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator9;
        private DevComponents.DotNetBar.Controls.TextBoxX rMNameTextBox;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemClient;
        private DevComponents.DotNetBar.TabItem tabItemClientCreditLine;
        private DevComponents.DotNetBar.TabItem tabItemContract;
        private DevComponents.DotNetBar.TabControlPanel tabPanelClient;
        private DevComponents.DotNetBar.TabControlPanel tabPanelClientCreditLine;
        private DevComponents.DotNetBar.TabControlPanel tabPanelContract;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractStatus;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX telephoneTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput unfreezeDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezerTextBox;
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
            DevComponents.DotNetBar.LabelX lblGroupNameCN;
            DevComponents.DotNetBar.LabelX websiteLabel;
            DevComponents.DotNetBar.LabelX telephoneLabel;
            DevComponents.DotNetBar.LabelX lblContractType;
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
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelClientCreditLine = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvClientCreditLines = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCreditLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEDICodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractValueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelContract = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbContractType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnContractUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnContractRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnContractDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnContractSave = new DevComponents.DotNetBar.ButtonX();
            this.btnContractNew = new DevComponents.DotNetBar.ButtonX();
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContractStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diContractDueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diContractValueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tabItemContract = new DevComponents.DotNetBar.TabItem(this.components);
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
            this.btnClientReset = new DevComponents.DotNetBar.ButtonX();
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
            this.clientValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.customValidator3 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator18 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("至少有一个地址", "Address");
            this.requiredFieldValidator17 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("至少有一个地址", "Address");
            this.requiredFieldValidator16 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("至少有一个客户名", "ClientName");
            this.requiredFieldValidator15 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("至少有一个客户名", "ClientName");
            this.requiredFieldValidator14 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("至少有一个客户名", "ClientName");
            this.clientErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator10 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.creditLineValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.customValidator5 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator4 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator9 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.compareValidator2 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.creditLineErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.creditLineHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.contractValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator11 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.customValidator6 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator13 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.requiredFieldValidator12 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.contractErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contractHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
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
            lblGroupNameCN = new DevComponents.DotNetBar.LabelX();
            websiteLabel = new DevComponents.DotNetBar.LabelX();
            telephoneLabel = new DevComponents.DotNetBar.LabelX();
            lblContractType = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
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
            this.tabPanelClient.SuspendLayout();
            this.groupPanelClientContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupPanelClientGroup.SuspendLayout();
            this.groupPanelClientStat.SuspendLayout();
            this.groupPanelClientBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditLineErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractErrorProvider)).BeginInit();
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
            clientNameCNLabel.Location = new System.Drawing.Point(44, 33);
            clientNameCNLabel.Name = "clientNameCNLabel";
            clientNameCNLabel.Size = new System.Drawing.Size(34, 16);
            clientNameCNLabel.TabIndex = 4;
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
            addressCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            addressCNLabel.Location = new System.Drawing.Point(44, 102);
            addressCNLabel.Name = "addressCNLabel";
            addressCNLabel.Size = new System.Drawing.Size(34, 16);
            addressCNLabel.TabIndex = 8;
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
            cityCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            cityCNLabel.Location = new System.Drawing.Point(44, 150);
            cityCNLabel.Name = "cityCNLabel";
            cityCNLabel.Size = new System.Drawing.Size(34, 16);
            cityCNLabel.TabIndex = 11;
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
            provinceCNLabel.Location = new System.Drawing.Point(41, 173);
            provinceCNLabel.Name = "provinceCNLabel";
            provinceCNLabel.Size = new System.Drawing.Size(37, 16);
            provinceCNLabel.TabIndex = 14;
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
            productCNLabel.Location = new System.Drawing.Point(393, 7);
            productCNLabel.Name = "productCNLabel";
            productCNLabel.Size = new System.Drawing.Size(59, 16);
            productCNLabel.TabIndex = 21;
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
            postCodeLabel.Location = new System.Drawing.Point(44, 221);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(34, 16);
            postCodeLabel.TabIndex = 19;
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
            countryCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            countryCodeLabel.Location = new System.Drawing.Point(44, 197);
            countryCodeLabel.Name = "countryCodeLabel";
            countryCodeLabel.Size = new System.Drawing.Size(34, 16);
            countryCodeLabel.TabIndex = 17;
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
            representativeLabel.Location = new System.Drawing.Point(20, 7);
            representativeLabel.Name = "representativeLabel";
            representativeLabel.Size = new System.Drawing.Size(59, 16);
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
            contactLabel.Location = new System.Drawing.Point(32, 30);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(47, 16);
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
            cellPhoneLabel.Location = new System.Drawing.Point(20, 78);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new System.Drawing.Size(59, 16);
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
            groupNoLabel.Location = new System.Drawing.Point(226, 7);
            groupNoLabel.Name = "groupNoLabel";
            groupNoLabel.Size = new System.Drawing.Size(97, 16);
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
            registrationNumberLabel.Location = new System.Drawing.Point(380, 7);
            registrationNumberLabel.Name = "registrationNumberLabel";
            registrationNumberLabel.Size = new System.Drawing.Size(84, 16);
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
            companyCodeLabel.Location = new System.Drawing.Point(380, 30);
            companyCodeLabel.Name = "companyCodeLabel";
            companyCodeLabel.Size = new System.Drawing.Size(84, 16);
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
            clientTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            clientTypeLabel.Location = new System.Drawing.Point(20, 7);
            clientTypeLabel.Name = "clientTypeLabel";
            clientTypeLabel.Size = new System.Drawing.Size(59, 16);
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
            clientLevelLabel.Location = new System.Drawing.Point(212, 7);
            clientLevelLabel.Name = "clientLevelLabel";
            clientLevelLabel.Size = new System.Drawing.Size(59, 16);
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
            branchCodeLabel.Location = new System.Drawing.Point(20, 30);
            branchCodeLabel.Name = "branchCodeLabel";
            branchCodeLabel.Size = new System.Drawing.Size(59, 16);
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
            pMNameLabel.Location = new System.Drawing.Point(20, 54);
            pMNameLabel.Name = "pMNameLabel";
            pMNameLabel.Size = new System.Drawing.Size(59, 16);
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
            rMNameLabel.Location = new System.Drawing.Point(212, 54);
            rMNameLabel.Name = "rMNameLabel";
            rMNameLabel.Size = new System.Drawing.Size(59, 16);
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
            clientNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            clientNoLabel.Location = new System.Drawing.Point(20, 7);
            clientNoLabel.Name = "clientNoLabel";
            clientNoLabel.Size = new System.Drawing.Size(59, 16);
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
            creditLineCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            creditLineCurrencyLabel.Location = new System.Drawing.Point(26, 33);
            creditLineCurrencyLabel.Name = "creditLineCurrencyLabel";
            creditLineCurrencyLabel.Size = new System.Drawing.Size(59, 16);
            creditLineCurrencyLabel.TabIndex = 5;
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
            creditLineTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            creditLineTypeLabel.Location = new System.Drawing.Point(26, 11);
            creditLineTypeLabel.Name = "creditLineTypeLabel";
            creditLineTypeLabel.Size = new System.Drawing.Size(59, 16);
            creditLineTypeLabel.TabIndex = 0;
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
            creditLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            creditLineLabel.Location = new System.Drawing.Point(26, 54);
            creditLineLabel.Name = "creditLineLabel";
            creditLineLabel.Size = new System.Drawing.Size(59, 16);
            creditLineLabel.TabIndex = 9;
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
            periodBeginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            periodBeginLabel.Location = new System.Drawing.Point(252, 11);
            periodBeginLabel.Name = "periodBeginLabel";
            periodBeginLabel.Size = new System.Drawing.Size(59, 16);
            periodBeginLabel.TabIndex = 2;
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
            approveNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            approveNoLabel.Location = new System.Drawing.Point(252, 34);
            approveNoLabel.Name = "approveNoLabel";
            approveNoLabel.Size = new System.Drawing.Size(59, 16);
            approveNoLabel.TabIndex = 7;
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
            approveTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            approveTypeLabel.Location = new System.Drawing.Point(253, 55);
            approveTypeLabel.Name = "approveTypeLabel";
            approveTypeLabel.Size = new System.Drawing.Size(59, 16);
            approveTypeLabel.TabIndex = 11;
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
            creditLineStatusLabel.Location = new System.Drawing.Point(26, 75);
            creditLineStatusLabel.Name = "creditLineStatusLabel";
            creditLineStatusLabel.Size = new System.Drawing.Size(59, 16);
            creditLineStatusLabel.TabIndex = 13;
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
            freezeReasonLabel.Location = new System.Drawing.Point(26, 144);
            freezeReasonLabel.Name = "freezeReasonLabel";
            freezeReasonLabel.Size = new System.Drawing.Size(59, 16);
            freezeReasonLabel.TabIndex = 17;
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
            freezerLabel.Location = new System.Drawing.Point(39, 186);
            freezerLabel.Name = "freezerLabel";
            freezerLabel.Size = new System.Drawing.Size(47, 16);
            freezerLabel.TabIndex = 19;
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
            freezeDateLabel.Location = new System.Drawing.Point(233, 186);
            freezeDateLabel.Name = "freezeDateLabel";
            freezeDateLabel.Size = new System.Drawing.Size(59, 16);
            freezeDateLabel.TabIndex = 21;
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
            unfreezeReasonLabel.Location = new System.Drawing.Point(26, 216);
            unfreezeReasonLabel.Name = "unfreezeReasonLabel";
            unfreezeReasonLabel.Size = new System.Drawing.Size(59, 16);
            unfreezeReasonLabel.TabIndex = 23;
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
            unfreezerLabel.Location = new System.Drawing.Point(39, 256);
            unfreezerLabel.Name = "unfreezerLabel";
            unfreezerLabel.Size = new System.Drawing.Size(47, 16);
            unfreezerLabel.TabIndex = 25;
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
            unfreezeDateLabel.Location = new System.Drawing.Point(233, 256);
            unfreezeDateLabel.Name = "unfreezeDateLabel";
            unfreezeDateLabel.Size = new System.Drawing.Size(59, 16);
            unfreezeDateLabel.TabIndex = 27;
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
            commentLabel.Location = new System.Drawing.Point(393, 150);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 24;
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
            creditLineCommentLabel.Location = new System.Drawing.Point(50, 98);
            creditLineCommentLabel.Name = "creditLineCommentLabel";
            creditLineCommentLabel.Size = new System.Drawing.Size(34, 16);
            creditLineCommentLabel.TabIndex = 15;
            creditLineCommentLabel.Text = "备注:";
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
            industryLabel.Location = new System.Drawing.Point(400, 7);
            industryLabel.Name = "industryLabel";
            industryLabel.Size = new System.Drawing.Size(59, 16);
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
            lblContractCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblContractCode.Location = new System.Drawing.Point(-1, 30);
            lblContractCode.Name = "lblContractCode";
            lblContractCode.Size = new System.Drawing.Size(84, 16);
            lblContractCode.TabIndex = 4;
            lblContractCode.Text = "保理合同编号:";
            // 
            // lblCreateUserName
            // 
            lblCreateUserName.AutoSize = true;
            lblCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCreateUserName.BackgroundStyle.Class = "";
            lblCreateUserName.Location = new System.Drawing.Point(39, 82);
            lblCreateUserName.Name = "lblCreateUserName";
            lblCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCreateUserName.TabIndex = 10;
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
            lblContractStatus.Location = new System.Drawing.Point(27, 56);
            lblContractStatus.Name = "lblContractStatus";
            lblContractStatus.Size = new System.Drawing.Size(59, 16);
            lblContractStatus.TabIndex = 8;
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
            lblContractValueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblContractValueDate.Location = new System.Drawing.Point(269, 4);
            lblContractValueDate.Name = "lblContractValueDate";
            lblContractValueDate.Size = new System.Drawing.Size(97, 16);
            lblContractValueDate.TabIndex = 2;
            lblContractValueDate.Text = "保理合同生效日:";
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
            lblContractDueDate.Location = new System.Drawing.Point(269, 30);
            lblContractDueDate.Name = "lblContractDueDate";
            lblContractDueDate.Size = new System.Drawing.Size(97, 16);
            lblContractDueDate.TabIndex = 6;
            lblContractDueDate.Text = "保理合同到期日:";
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
            lblGroupNameCN.TabIndex = 4;
            lblGroupNameCN.Text = "集团客户名:";
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
            websiteLabel.Text = "公司网址:";
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
            telephoneLabel.Text = "联系电话:";
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
            lblContractType.Size = new System.Drawing.Size(59, 16);
            lblContractType.TabIndex = 0;
            lblContractType.Text = "合同类型:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelClientCreditLine);
            this.tabControl.Controls.Add(this.tabPanelClient);
            this.tabControl.Controls.Add(this.tabPanelContract);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(614, 614);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemClient);
            this.tabControl.Tabs.Add(this.tabItemClientCreditLine);
            this.tabControl.Tabs.Add(this.tabItemContract);
            this.tabControl.Text = "tabControl1";
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
            this.tabPanelClientCreditLine.Size = new System.Drawing.Size(614, 588);
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
            this.colCreditLineID,
            this.ClientEDICodeColumn,
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
            this.dgvClientCreditLines.Location = new System.Drawing.Point(1, 317);
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
            this.dgvClientCreditLines.Size = new System.Drawing.Size(612, 270);
            this.dgvClientCreditLines.TabIndex = 0;
            this.dgvClientCreditLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectClientCreditLine);
            // 
            // colCreditLineID
            // 
            this.colCreditLineID.DataPropertyName = "CreditLineID";
            this.colCreditLineID.HeaderText = "额度编号";
            this.colCreditLineID.Name = "colCreditLineID";
            this.colCreditLineID.ReadOnly = true;
            this.colCreditLineID.Visible = false;
            // 
            // ClientEDICodeColumn
            // 
            this.ClientEDICodeColumn.DataPropertyName = "ClientEDICode";
            this.ClientEDICodeColumn.HeaderText = "客户保理代码";
            this.ClientEDICodeColumn.Name = "ClientEDICodeColumn";
            this.ClientEDICodeColumn.ReadOnly = true;
            // 
            // colCreditLineType
            // 
            this.colCreditLineType.DataPropertyName = "CreditLineType";
            this.colCreditLineType.HeaderText = "额度类型";
            this.colCreditLineType.Name = "colCreditLineType";
            this.colCreditLineType.ReadOnly = true;
            // 
            // colCreditLineCurrency
            // 
            this.colCreditLineCurrency.DataPropertyName = "CreditLineCurrency";
            this.colCreditLineCurrency.HeaderText = "额度币种";
            this.colCreditLineCurrency.Name = "colCreditLineCurrency";
            this.colCreditLineCurrency.ReadOnly = true;
            // 
            // colCreditLine
            // 
            this.colCreditLine.DataPropertyName = "CreditLine";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colCreditLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCreditLine.HeaderText = "额度上限";
            this.colCreditLine.Name = "colCreditLine";
            this.colCreditLine.ReadOnly = true;
            // 
            // colPeriodBegin
            // 
            this.colPeriodBegin.DataPropertyName = "PeriodBegin";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colPeriodBegin.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPeriodBegin.HeaderText = "有效期(始)";
            this.colPeriodBegin.Name = "colPeriodBegin";
            this.colPeriodBegin.ReadOnly = true;
            // 
            // colPeriodEnd
            // 
            this.colPeriodEnd.DataPropertyName = "PeriodEnd";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colPeriodEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPeriodEnd.HeaderText = "有效期(终)";
            this.colPeriodEnd.Name = "colPeriodEnd";
            this.colPeriodEnd.ReadOnly = true;
            // 
            // colApproveNo
            // 
            this.colApproveNo.DataPropertyName = "ApproveNo";
            this.colApproveNo.HeaderText = "授信编号";
            this.colApproveNo.Name = "colApproveNo";
            this.colApproveNo.ReadOnly = true;
            // 
            // colApproveType
            // 
            this.colApproveType.DataPropertyName = "ApproveType";
            this.colApproveType.HeaderText = "授信类型";
            this.colApproveType.Name = "colApproveType";
            this.colApproveType.ReadOnly = true;
            // 
            // colCreditLineStatus
            // 
            this.colCreditLineStatus.DataPropertyName = "CreditLineStatus";
            this.colCreditLineStatus.HeaderText = "额度状态";
            this.colCreditLineStatus.Name = "colCreditLineStatus";
            this.colCreditLineStatus.ReadOnly = true;
            // 
            // colFreezeReason
            // 
            this.colFreezeReason.DataPropertyName = "FreezeReason";
            this.colFreezeReason.HeaderText = "冻结原因";
            this.colFreezeReason.Name = "colFreezeReason";
            this.colFreezeReason.ReadOnly = true;
            // 
            // colFreezer
            // 
            this.colFreezer.DataPropertyName = "Freezer";
            this.colFreezer.HeaderText = "冻结人";
            this.colFreezer.Name = "colFreezer";
            this.colFreezer.ReadOnly = true;
            // 
            // colFreezeDate
            // 
            this.colFreezeDate.DataPropertyName = "FreezeDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colFreezeDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFreezeDate.HeaderText = "冻结日期";
            this.colFreezeDate.Name = "colFreezeDate";
            this.colFreezeDate.ReadOnly = true;
            // 
            // colUnfreezeReason
            // 
            this.colUnfreezeReason.DataPropertyName = "UnfreezeReason";
            this.colUnfreezeReason.HeaderText = "解冻原因";
            this.colUnfreezeReason.Name = "colUnfreezeReason";
            this.colUnfreezeReason.ReadOnly = true;
            // 
            // colUnfreezer
            // 
            this.colUnfreezer.DataPropertyName = "Unfreezer";
            this.colUnfreezer.HeaderText = "解冻人";
            this.colUnfreezer.Name = "colUnfreezer";
            this.colUnfreezer.ReadOnly = true;
            // 
            // colUnfreezeDate
            // 
            this.colUnfreezeDate.DataPropertyName = "UnfreezeDate";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.colUnfreezeDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colUnfreezeDate.HeaderText = "解冻日期";
            this.colUnfreezeDate.Name = "colUnfreezeDate";
            this.colUnfreezeDate.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
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
            this.groupPanelClientCreditLine.Size = new System.Drawing.Size(612, 316);
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
            this.btnClientCreditLineUpdate.Location = new System.Drawing.Point(171, 280);
            this.btnClientCreditLineUpdate.Name = "btnClientCreditLineUpdate";
            this.btnClientCreditLineUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineUpdate.TabIndex = 31;
            this.btnClientCreditLineUpdate.Text = "编辑";
            this.btnClientCreditLineUpdate.Click += new System.EventHandler(this.UpdateClientCreditLine);
            // 
            // creditLineTextBox
            // 
            // 
            // 
            // 
            this.creditLineTextBox.Border.Class = "TextBoxBorder";
            this.creditLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "CreditLine", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.creditLineTextBox.Location = new System.Drawing.Point(90, 52);
            this.creditLineTextBox.Name = "creditLineTextBox";
            this.creditLineTextBox.Size = new System.Drawing.Size(152, 20);
            this.creditLineTextBox.TabIndex = 10;
            this.creditLineValidator.SetValidator1(this.creditLineTextBox, this.requiredFieldValidator8);
            // 
            // clientCreditLineBindingSource
            // 
            this.clientCreditLineBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.ClientCreditLine);
            // 
            // btnClientCreditLineRefresh
            // 
            this.btnClientCreditLineRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineRefresh.Location = new System.Drawing.Point(11, 280);
            this.btnClientCreditLineRefresh.Name = "btnClientCreditLineRefresh";
            this.btnClientCreditLineRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineRefresh.TabIndex = 29;
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
            this.creditLineCommentTextBox.Location = new System.Drawing.Point(90, 94);
            this.creditLineCommentTextBox.Multiline = true;
            this.creditLineCommentTextBox.Name = "creditLineCommentTextBox";
            this.creditLineCommentTextBox.Size = new System.Drawing.Size(480, 42);
            this.creditLineCommentTextBox.TabIndex = 16;
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
            this.unfreezeDateDateTimePicker.Location = new System.Drawing.Point(297, 254);
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
            this.unfreezeDateDateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.unfreezeDateDateTimePicker.TabIndex = 28;
            // 
            // btnClientCreditLineUnfreeze
            // 
            this.btnClientCreditLineUnfreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineUnfreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineUnfreeze.Location = new System.Drawing.Point(495, 280);
            this.btnClientCreditLineUnfreeze.Name = "btnClientCreditLineUnfreeze";
            this.btnClientCreditLineUnfreeze.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineUnfreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineUnfreeze.TabIndex = 35;
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
            this.unfreezerTextBox.Location = new System.Drawing.Point(90, 254);
            this.unfreezerTextBox.Name = "unfreezerTextBox";
            this.unfreezerTextBox.ReadOnly = true;
            this.unfreezerTextBox.Size = new System.Drawing.Size(100, 20);
            this.unfreezerTextBox.TabIndex = 26;
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
            this.freezeDateDateTimePicker.Location = new System.Drawing.Point(297, 183);
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
            this.freezeDateDateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.freezeDateDateTimePicker.TabIndex = 22;
            // 
            // btnClientCreditLineFreeze
            // 
            this.btnClientCreditLineFreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineFreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineFreeze.Location = new System.Drawing.Point(414, 280);
            this.btnClientCreditLineFreeze.Name = "btnClientCreditLineFreeze";
            this.btnClientCreditLineFreeze.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineFreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineFreeze.TabIndex = 34;
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
            this.unfreezeReasonTextBox.Location = new System.Drawing.Point(90, 209);
            this.unfreezeReasonTextBox.Multiline = true;
            this.unfreezeReasonTextBox.Name = "unfreezeReasonTextBox";
            this.unfreezeReasonTextBox.ReadOnly = true;
            this.unfreezeReasonTextBox.Size = new System.Drawing.Size(480, 38);
            this.unfreezeReasonTextBox.TabIndex = 24;
            this.creditLineValidator.SetValidator1(this.unfreezeReasonTextBox, this.customValidator5);
            // 
            // freezeReasonTextBox
            // 
            // 
            // 
            // 
            this.freezeReasonTextBox.Border.Class = "TextBoxBorder";
            this.freezeReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "FreezeReason", true));
            this.freezeReasonTextBox.Location = new System.Drawing.Point(90, 141);
            this.freezeReasonTextBox.Multiline = true;
            this.freezeReasonTextBox.Name = "freezeReasonTextBox";
            this.freezeReasonTextBox.ReadOnly = true;
            this.freezeReasonTextBox.Size = new System.Drawing.Size(480, 36);
            this.freezeReasonTextBox.TabIndex = 18;
            this.creditLineValidator.SetValidator1(this.freezeReasonTextBox, this.customValidator4);
            // 
            // btnClientCreditLineDelete
            // 
            this.btnClientCreditLineDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineDelete.Location = new System.Drawing.Point(333, 280);
            this.btnClientCreditLineDelete.Name = "btnClientCreditLineDelete";
            this.btnClientCreditLineDelete.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineDelete.TabIndex = 33;
            this.btnClientCreditLineDelete.Text = "删除";
            this.btnClientCreditLineDelete.Click += new System.EventHandler(this.DeleteClientCreditLine);
            // 
            // btnClientCreditLineSave
            // 
            this.btnClientCreditLineSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineSave.Location = new System.Drawing.Point(252, 280);
            this.btnClientCreditLineSave.Name = "btnClientCreditLineSave";
            this.btnClientCreditLineSave.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineSave.TabIndex = 32;
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
            this.freezerTextBox.Location = new System.Drawing.Point(90, 183);
            this.freezerTextBox.Name = "freezerTextBox";
            this.freezerTextBox.ReadOnly = true;
            this.freezerTextBox.Size = new System.Drawing.Size(100, 20);
            this.freezerTextBox.TabIndex = 20;
            // 
            // btnClientCreditLineNew
            // 
            this.btnClientCreditLineNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientCreditLineNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientCreditLineNew.Location = new System.Drawing.Point(90, 280);
            this.btnClientCreditLineNew.Name = "btnClientCreditLineNew";
            this.btnClientCreditLineNew.Size = new System.Drawing.Size(75, 23);
            this.btnClientCreditLineNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientCreditLineNew.TabIndex = 30;
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
            "综合授信",
            "国际双保理",
            "进口保理",
            "有追索权保理",
            "无追索权保理"});
            this.approveTypeComboBox.Location = new System.Drawing.Point(317, 52);
            this.approveTypeComboBox.Name = "approveTypeComboBox";
            this.approveTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.approveTypeComboBox.TabIndex = 12;
            this.creditLineValidator.SetValidator1(this.approveTypeComboBox, this.requiredFieldValidator9);
            // 
            // approveNoTextBox
            // 
            // 
            // 
            // 
            this.approveNoTextBox.Border.Class = "TextBoxBorder";
            this.approveNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientCreditLineBindingSource, "ApproveNo", true));
            this.approveNoTextBox.Location = new System.Drawing.Point(316, 30);
            this.approveNoTextBox.Name = "approveNoTextBox";
            this.approveNoTextBox.Size = new System.Drawing.Size(122, 20);
            this.approveNoTextBox.TabIndex = 8;
            this.creditLineValidator.SetValidator1(this.approveNoTextBox, this.requiredFieldValidator7);
            // 
            // periodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.periodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.periodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.periodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "PeriodEnd", true));
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
            this.periodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientCreditLineBindingSource, "PeriodBegin", true));
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
            this.periodBeginDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.periodBeginDateTimePicker.TabIndex = 3;
            this.creditLineValidator.SetValidator1(this.periodBeginDateTimePicker, this.requiredFieldValidator4);
            this.periodBeginDateTimePicker.ValueChanged += new System.EventHandler(this.periodBeginDateTimePicker_ValueChanged);
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
            this.creditLineTypeComboBox.Location = new System.Drawing.Point(90, 7);
            this.creditLineTypeComboBox.Name = "creditLineTypeComboBox";
            this.creditLineTypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.creditLineTypeComboBox.TabIndex = 1;
            // 
            // creditLineCurrencyComboBox
            // 
            this.creditLineCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientCreditLineBindingSource, "CreditLineCurrency", true));
            this.creditLineCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creditLineCurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditLineCurrencyComboBox.Location = new System.Drawing.Point(90, 29);
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
            this.tabPanelContract.Size = new System.Drawing.Size(614, 588);
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
            this.colContractType,
            this.colContractValueDate,
            this.colContractDueDate,
            this.colContractStatus,
            this.colCreateUserName});
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
            this.dgvContracts.Location = new System.Drawing.Point(1, 168);
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
            this.dgvContracts.Size = new System.Drawing.Size(612, 419);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectContract);
            // 
            // colContractCode
            // 
            this.colContractCode.DataPropertyName = "ContractCode";
            this.colContractCode.HeaderText = "合同号";
            this.colContractCode.Name = "colContractCode";
            this.colContractCode.ReadOnly = true;
            // 
            // colContractType
            // 
            this.colContractType.DataPropertyName = "ContractType";
            this.colContractType.HeaderText = "合同类型";
            this.colContractType.Name = "colContractType";
            this.colContractType.ReadOnly = true;
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
            // groupPanelContract
            // 
            this.groupPanelContract.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelContract.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelContract.Controls.Add(lblContractType);
            this.groupPanelContract.Controls.Add(this.cbContractType);
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
            this.groupPanelContract.Size = new System.Drawing.Size(612, 167);
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
            // cbContractType
            // 
            this.cbContractType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractType", true));
            this.cbContractType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Items.AddRange(new object[] {
            "新合同",
            "旧合同"});
            this.cbContractType.Location = new System.Drawing.Point(99, 4);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(143, 21);
            this.cbContractType.TabIndex = 1;
            this.contractValidator.SetValidator1(this.cbContractType, this.requiredFieldValidator3);
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Contract);
            // 
            // btnContractUpdate
            // 
            this.btnContractUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractUpdate.Location = new System.Drawing.Point(269, 133);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContractUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractUpdate.TabIndex = 14;
            this.btnContractUpdate.Text = "编辑";
            this.btnContractUpdate.Click += new System.EventHandler(this.UpdateContract);
            // 
            // btnContractRefresh
            // 
            this.btnContractRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractRefresh.Location = new System.Drawing.Point(109, 133);
            this.btnContractRefresh.Name = "btnContractRefresh";
            this.btnContractRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnContractRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractRefresh.TabIndex = 12;
            this.btnContractRefresh.Text = "刷新";
            // 
            // btnContractDelete
            // 
            this.btnContractDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractDelete.Location = new System.Drawing.Point(431, 133);
            this.btnContractDelete.Name = "btnContractDelete";
            this.btnContractDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContractDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractDelete.TabIndex = 16;
            this.btnContractDelete.Text = "删除";
            this.btnContractDelete.Click += new System.EventHandler(this.DeleteContract);
            // 
            // btnContractSave
            // 
            this.btnContractSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractSave.Location = new System.Drawing.Point(350, 133);
            this.btnContractSave.Name = "btnContractSave";
            this.btnContractSave.Size = new System.Drawing.Size(75, 23);
            this.btnContractSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractSave.TabIndex = 15;
            this.btnContractSave.Text = "保存";
            this.btnContractSave.Click += new System.EventHandler(this.SaveContract);
            // 
            // btnContractNew
            // 
            this.btnContractNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractNew.Location = new System.Drawing.Point(188, 133);
            this.btnContractNew.Name = "btnContractNew";
            this.btnContractNew.Size = new System.Drawing.Size(75, 23);
            this.btnContractNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractNew.TabIndex = 13;
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
            this.tbContractCode.Location = new System.Drawing.Point(99, 30);
            this.tbContractCode.MaxLength = 10;
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(143, 20);
            this.tbContractCode.TabIndex = 5;
            this.contractValidator.SetValidator1(this.tbContractCode, this.requiredFieldValidator11);
            this.contractValidator.SetValidator2(this.tbContractCode, this.customValidator6);
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CreateUserName", true));
            this.tbCreateUserName.Location = new System.Drawing.Point(99, 82);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(143, 20);
            this.tbCreateUserName.TabIndex = 11;
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
            this.diContractDueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractDueDate", true));
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
            this.diContractValueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractValueDate", true));
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
            this.diContractValueDate.Size = new System.Drawing.Size(133, 20);
            this.diContractValueDate.TabIndex = 3;
            this.contractValidator.SetValidator1(this.diContractValueDate, this.requiredFieldValidator12);
            this.diContractValueDate.ValueChanged += new System.EventHandler(this.diContractValueDate_ValueChanged);
            // 
            // tabItemContract
            // 
            this.tabItemContract.AttachedControl = this.tabPanelContract;
            this.tabItemContract.Name = "tabItemContract";
            this.tabItemContract.Text = "保理合同";
            // 
            // tabPanelClient
            // 
            this.tabPanelClient.AutoScroll = true;
            this.tabPanelClient.AutoSize = true;
            this.tabPanelClient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabPanelClient.Controls.Add(this.btnClientUpdate);
            this.tabPanelClient.Controls.Add(this.groupPanelClientContact);
            this.tabPanelClient.Controls.Add(this.groupPanelClientGroup);
            this.tabPanelClient.Controls.Add(this.btnClientReset);
            this.tabPanelClient.Controls.Add(this.btnClientSave);
            this.tabPanelClient.Controls.Add(this.groupPanelClientStat);
            this.tabPanelClient.Controls.Add(this.groupPanelClientBasic);
            this.tabPanelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelClient.Location = new System.Drawing.Point(0, 26);
            this.tabPanelClient.Name = "tabPanelClient";
            this.tabPanelClient.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelClient.Size = new System.Drawing.Size(614, 588);
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
            this.btnClientUpdate.Location = new System.Drawing.Point(168, 558);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnClientUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientUpdate.TabIndex = 4;
            this.btnClientUpdate.Text = "编辑";
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
            this.groupPanelClientContact.Location = new System.Drawing.Point(1, 435);
            this.groupPanelClientContact.Name = "groupPanelClientContact";
            this.groupPanelClientContact.Size = new System.Drawing.Size(612, 114);
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
            this.groupPanelClientGroup.Controls.Add(this.isGroupCheckBox);
            this.groupPanelClientGroup.Controls.Add(this.tbGroupNameEN);
            this.groupPanelClientGroup.Controls.Add(this.tbGroupNameCN);
            this.groupPanelClientGroup.Controls.Add(lblGroupNameCN);
            this.groupPanelClientGroup.Controls.Add(groupNoLabel);
            this.groupPanelClientGroup.Controls.Add(this.groupNoTextBox);
            this.groupPanelClientGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelClientGroup.Location = new System.Drawing.Point(1, 346);
            this.groupPanelClientGroup.Name = "groupPanelClientGroup";
            this.groupPanelClientGroup.Size = new System.Drawing.Size(612, 89);
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
            // isGroupCheckBox
            // 
            this.isGroupCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isGroupCheckBox.BackgroundStyle.Class = "";
            this.isGroupCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientBindingSource, "IsGroup", true));
            this.isGroupCheckBox.Location = new System.Drawing.Point(85, 5);
            this.isGroupCheckBox.Name = "isGroupCheckBox";
            this.isGroupCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isGroupCheckBox.TabIndex = 7;
            this.isGroupCheckBox.Text = "是否集团客户";
            this.isGroupCheckBox.CheckedChanged += new System.EventHandler(this.IsGroupChanged);
            // 
            // tbGroupNameEN
            // 
            // 
            // 
            // 
            this.tbGroupNameEN.Border.Class = "TextBoxBorder";
            this.tbGroupNameEN.Location = new System.Drawing.Point(85, 54);
            this.tbGroupNameEN.Name = "tbGroupNameEN";
            this.tbGroupNameEN.Size = new System.Drawing.Size(340, 20);
            this.tbGroupNameEN.TabIndex = 6;
            this.clientValidator.SetValidator1(this.tbGroupNameEN, this.customValidator3);
            this.tbGroupNameEN.WatermarkText = "英文名";
            // 
            // tbGroupNameCN
            // 
            // 
            // 
            // 
            this.tbGroupNameCN.Border.Class = "TextBoxBorder";
            this.tbGroupNameCN.Location = new System.Drawing.Point(85, 30);
            this.tbGroupNameCN.Name = "tbGroupNameCN";
            this.tbGroupNameCN.Size = new System.Drawing.Size(340, 20);
            this.tbGroupNameCN.TabIndex = 5;
            this.clientValidator.SetValidator1(this.tbGroupNameCN, this.customValidator1);
            this.tbGroupNameCN.WatermarkText = "中文名";
            // 
            // groupNoTextBox
            // 
            // 
            // 
            // 
            this.groupNoTextBox.Border.Class = "TextBoxBorder";
            this.groupNoTextBox.Location = new System.Drawing.Point(325, 7);
            this.groupNoTextBox.Name = "groupNoTextBox";
            this.groupNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupNoTextBox.TabIndex = 3;
            this.clientValidator.SetValidator1(this.groupNoTextBox, this.customValidator2);
            // 
            // btnClientReset
            // 
            this.btnClientReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientReset.Location = new System.Drawing.Point(334, 558);
            this.btnClientReset.Name = "btnClientReset";
            this.btnClientReset.Size = new System.Drawing.Size(75, 23);
            this.btnClientReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClientReset.TabIndex = 6;
            this.btnClientReset.Text = "重置";
            this.btnClientReset.Click += new System.EventHandler(this.ResetClient);
            // 
            // btnClientSave
            // 
            this.btnClientSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClientSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClientSave.Location = new System.Drawing.Point(253, 558);
            this.btnClientSave.Name = "btnClientSave";
            this.btnClientSave.Size = new System.Drawing.Size(75, 23);
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
            this.groupPanelClientStat.Location = new System.Drawing.Point(1, 255);
            this.groupPanelClientStat.Name = "groupPanelClientStat";
            this.groupPanelClientStat.Size = new System.Drawing.Size(612, 91);
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
            this.cbDepartments.SelectionChanged += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.cbDepartments_SelectionChanged);
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
            "国有",
            "民营",
            "三资"});
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
            this.groupPanelClientBasic.Size = new System.Drawing.Size(612, 254);
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
            this.clientCommentTextBox.Location = new System.Drawing.Point(393, 173);
            this.clientCommentTextBox.Multiline = true;
            this.clientCommentTextBox.Name = "clientCommentTextBox";
            this.clientCommentTextBox.Size = new System.Drawing.Size(178, 65);
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
            this.clientEDICodeTextBox.MaxLength = 35;
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
            this.cbCountryCode.Location = new System.Drawing.Point(85, 197);
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
            this.postCodeTextBox.Location = new System.Drawing.Point(85, 221);
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
            this.productENTextBox.Location = new System.Drawing.Point(393, 78);
            this.productENTextBox.Multiline = true;
            this.productENTextBox.Name = "productENTextBox";
            this.productENTextBox.Size = new System.Drawing.Size(178, 46);
            this.productENTextBox.TabIndex = 23;
            this.productENTextBox.WatermarkText = "英文";
            // 
            // productCNTextBox
            // 
            // 
            // 
            // 
            this.productCNTextBox.Border.Class = "TextBoxBorder";
            this.productCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProductCN", true));
            this.productCNTextBox.Location = new System.Drawing.Point(393, 30);
            this.productCNTextBox.Multiline = true;
            this.productCNTextBox.Name = "productCNTextBox";
            this.productCNTextBox.Size = new System.Drawing.Size(178, 46);
            this.productCNTextBox.TabIndex = 22;
            this.productCNTextBox.WatermarkText = "中文";
            // 
            // provinceENTextBox
            // 
            // 
            // 
            // 
            this.provinceENTextBox.Border.Class = "TextBoxBorder";
            this.provinceENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceEN", true));
            this.provinceENTextBox.Location = new System.Drawing.Point(190, 173);
            this.provinceENTextBox.Name = "provinceENTextBox";
            this.provinceENTextBox.Size = new System.Drawing.Size(100, 20);
            this.provinceENTextBox.TabIndex = 16;
            this.provinceENTextBox.WatermarkText = "英文";
            // 
            // provinceCNTextBox
            // 
            // 
            // 
            // 
            this.provinceCNTextBox.Border.Class = "TextBoxBorder";
            this.provinceCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceCN", true));
            this.provinceCNTextBox.Location = new System.Drawing.Point(85, 173);
            this.provinceCNTextBox.Name = "provinceCNTextBox";
            this.provinceCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.provinceCNTextBox.TabIndex = 15;
            this.provinceCNTextBox.WatermarkText = "中文";
            // 
            // cityENTextBox
            // 
            // 
            // 
            // 
            this.cityENTextBox.Border.Class = "TextBoxBorder";
            this.cityENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityEN", true));
            this.cityENTextBox.Location = new System.Drawing.Point(190, 150);
            this.cityENTextBox.Name = "cityENTextBox";
            this.cityENTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityENTextBox.TabIndex = 13;
            this.cityENTextBox.WatermarkText = "英文";
            // 
            // cityCNTextBox
            // 
            // 
            // 
            // 
            this.cityCNTextBox.Border.Class = "TextBoxBorder";
            this.cityCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityCN", true));
            this.cityCNTextBox.Location = new System.Drawing.Point(85, 150);
            this.cityCNTextBox.Name = "cityCNTextBox";
            this.cityCNTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityCNTextBox.TabIndex = 12;
            this.cityCNTextBox.WatermarkText = "中文";
            // 
            // addressENTextBox
            // 
            // 
            // 
            // 
            this.addressENTextBox.Border.Class = "TextBoxBorder";
            this.addressENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressEN", true));
            this.addressENTextBox.Location = new System.Drawing.Point(85, 126);
            this.addressENTextBox.Name = "addressENTextBox";
            this.addressENTextBox.Size = new System.Drawing.Size(295, 20);
            this.addressENTextBox.TabIndex = 10;
            this.clientValidator.SetValidator1(this.addressENTextBox, this.requiredFieldValidator18);
            this.addressENTextBox.WatermarkText = "英文地址";
            // 
            // addressCNTextBox
            // 
            // 
            // 
            // 
            this.addressCNTextBox.Border.Class = "TextBoxBorder";
            this.addressCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressCN", true));
            this.addressCNTextBox.Location = new System.Drawing.Point(85, 102);
            this.addressCNTextBox.Name = "addressCNTextBox";
            this.addressCNTextBox.Size = new System.Drawing.Size(295, 20);
            this.addressCNTextBox.TabIndex = 9;
            this.clientValidator.SetValidator1(this.addressCNTextBox, this.requiredFieldValidator17);
            this.addressCNTextBox.WatermarkText = "中文地址";
            // 
            // clientNameEN_2TextBox
            // 
            // 
            // 
            // 
            this.clientNameEN_2TextBox.Border.Class = "TextBoxBorder";
            this.clientNameEN_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameEN_2", true));
            this.clientNameEN_2TextBox.Location = new System.Drawing.Point(85, 78);
            this.clientNameEN_2TextBox.Name = "clientNameEN_2TextBox";
            this.clientNameEN_2TextBox.Size = new System.Drawing.Size(295, 20);
            this.clientNameEN_2TextBox.TabIndex = 7;
            this.clientValidator.SetValidator1(this.clientNameEN_2TextBox, this.requiredFieldValidator16);
            this.clientNameEN_2TextBox.WatermarkText = "英文名第二行";
            // 
            // clientNameEN_1TextBox
            // 
            // 
            // 
            // 
            this.clientNameEN_1TextBox.Border.Class = "TextBoxBorder";
            this.clientNameEN_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameEN_1", true));
            this.clientNameEN_1TextBox.Location = new System.Drawing.Point(85, 54);
            this.clientNameEN_1TextBox.Name = "clientNameEN_1TextBox";
            this.clientNameEN_1TextBox.Size = new System.Drawing.Size(295, 20);
            this.clientNameEN_1TextBox.TabIndex = 6;
            this.clientValidator.SetValidator1(this.clientNameEN_1TextBox, this.requiredFieldValidator15);
            this.clientNameEN_1TextBox.WatermarkText = "英文名第一行";
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
            this.clientNameCNTextBox.WatermarkText = "中文名";
            // 
            // tabItemClient
            // 
            this.tabItemClient.AttachedControl = this.tabPanelClient;
            this.tabItemClient.Name = "tabItemClient";
            this.tabItemClient.Text = "基本信息";
            // 
            // clientValidator
            // 
            this.clientValidator.ContainerControl = this;
            this.clientValidator.ErrorProvider = this.clientErrorProvider;
            this.clientValidator.Highlighter = this.clientHighlighter;
            // 
            // customValidator3
            // 
            this.customValidator3.ErrorMessage = "必填";
            this.customValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator3.OptionalValidationGroup = "GroupName";
            this.customValidator3.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator3_ValidateValue);
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "必填";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.OptionalValidationGroup = "GroupName";
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator1_ValidateValue);
            // 
            // customValidator2
            // 
            this.customValidator2.ErrorMessage = "必填";
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator2.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator2_ValidateValue);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "保理代码不符合规则";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "\\d{3}[A-Z]{4}\\d{2}";
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator18
            // 
            this.requiredFieldValidator18.ErrorMessage = "至少有一个地址";
            this.requiredFieldValidator18.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator18.OptionalValidationGroup = "Address";
            // 
            // requiredFieldValidator17
            // 
            this.requiredFieldValidator17.ErrorMessage = "至少有一个地址";
            this.requiredFieldValidator17.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator17.OptionalValidationGroup = "Address";
            // 
            // requiredFieldValidator16
            // 
            this.requiredFieldValidator16.ErrorMessage = "至少有一个客户名";
            this.requiredFieldValidator16.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator16.OptionalValidationGroup = "ClientName";
            // 
            // requiredFieldValidator15
            // 
            this.requiredFieldValidator15.ErrorMessage = "至少有一个客户名";
            this.requiredFieldValidator15.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator15.OptionalValidationGroup = "ClientName";
            // 
            // requiredFieldValidator14
            // 
            this.requiredFieldValidator14.ErrorMessage = "至少有一个客户名";
            this.requiredFieldValidator14.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.requiredFieldValidator14.OptionalValidationGroup = "ClientName";
            // 
            // clientErrorProvider
            // 
            this.clientErrorProvider.ContainerControl = this;
            this.clientErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("clientErrorProvider.Icon")));
            // 
            // clientHighlighter
            // 
            this.clientHighlighter.ContainerControl = this;
            // 
            // requiredFieldValidator10
            // 
            this.requiredFieldValidator10.ErrorMessage = "必填";
            this.requiredFieldValidator10.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // creditLineValidator
            // 
            this.creditLineValidator.ContainerControl = this;
            this.creditLineValidator.ErrorProvider = this.creditLineErrorProvider;
            this.creditLineValidator.Highlighter = this.creditLineHighlighter;
            // 
            // requiredFieldValidator8
            // 
            this.requiredFieldValidator8.ErrorMessage = "必填";
            this.requiredFieldValidator8.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator5
            // 
            this.customValidator5.ErrorMessage = "必填";
            this.customValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator5.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator5_ValidateValue);
            // 
            // customValidator4
            // 
            this.customValidator4.ErrorMessage = "必填";
            this.customValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator4.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator4_ValidateValue);
            // 
            // requiredFieldValidator9
            // 
            this.requiredFieldValidator9.ErrorMessage = "必填";
            this.requiredFieldValidator9.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.ErrorMessage = "必填";
            this.requiredFieldValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "必填";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator2
            // 
            this.compareValidator2.ControlToCompare = this.periodBeginDateTimePicker;
            this.compareValidator2.ErrorMessage = "终止日期应该大于起始日期";
            this.compareValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator2.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "必填";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // creditLineErrorProvider
            // 
            this.creditLineErrorProvider.ContainerControl = this;
            this.creditLineErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("creditLineErrorProvider.Icon")));
            // 
            // creditLineHighlighter
            // 
            this.creditLineHighlighter.ContainerControl = this;
            // 
            // contractValidator
            // 
            this.contractValidator.ContainerControl = this;
            this.contractValidator.ErrorProvider = this.contractErrorProvider;
            this.contractValidator.Highlighter = this.contractHighlighter;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator11
            // 
            this.requiredFieldValidator11.ErrorMessage = "必填";
            this.requiredFieldValidator11.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator6
            // 
            this.customValidator6.ErrorMessage = "保理合同编号应为10位";
            this.customValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator6.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator6_ValidateValue);
            // 
            // requiredFieldValidator13
            // 
            this.requiredFieldValidator13.ErrorMessage = "必填";
            this.requiredFieldValidator13.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.diContractValueDate;
            this.compareValidator1.ErrorMessage = "到期日应该大于生效日";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // requiredFieldValidator12
            // 
            this.requiredFieldValidator12.ErrorMessage = "必填";
            this.requiredFieldValidator12.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // contractErrorProvider
            // 
            this.contractErrorProvider.ContainerControl = this;
            this.contractErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("contractErrorProvider.Icon")));
            // 
            // contractHighlighter
            // 
            this.contractHighlighter.ContainerControl = this;
            // 
            // ClientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 614);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "ClientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "客户详细信息";
            this.Leave += new System.EventHandler(this.ClientDetail_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.clientErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditLineErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}