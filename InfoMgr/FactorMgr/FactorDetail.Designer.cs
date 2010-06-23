//-----------------------------------------------------------------------
// <copyright file="FactorMgr.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FactorDetail
    {
		#region Fields (121) 

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX approveNoTextBox;
        private DevComponents.DotNetBar.ButtonX btnAgreementDelete;
        private DevComponents.DotNetBar.ButtonX btnAgreementNew;
        private DevComponents.DotNetBar.ButtonX btnAgreementRefresh;
        private DevComponents.DotNetBar.ButtonX btnAgreementSave;
        private DevComponents.DotNetBar.ButtonX btnAgreementUpdate;
        private DevComponents.DotNetBar.ButtonX btnFactorCreditLineDelete;
        private DevComponents.DotNetBar.ButtonX btnFactorCreditLineFreeze;
        private DevComponents.DotNetBar.ButtonX btnFactorCreditLineNew;
        private DevComponents.DotNetBar.ButtonX btnFactorCreditLineRefresh;
        private DevComponents.DotNetBar.ButtonX btnFactorCreditLineSave;
        private DevComponents.DotNetBar.ButtonX btnFactorCreditLineUnfreeze;
        private DevComponents.DotNetBar.ButtonX btnFactorCreditLineUpdate;
        private DevComponents.DotNetBar.ButtonX btnFactorSave;
        private DevComponents.DotNetBar.ButtonX btnFactorUpdate;
        private DevComponents.DotNetBar.ButtonX btnGroupSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX cityPostTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX cityVisitingTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgreementComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgreementSignDate;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX companyNameCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX companyNameENTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.ComboBoxEx countryNameComboBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx creditLineCurrencyComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineStatusTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX creditLineTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator creditLineValidator;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.Controls.TextBoxX dateOfLatestRevisionTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX departmentTextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAgreements;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactorCreditLines;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diSignDate;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private System.Windows.Forms.BindingSource agreementBindingSource;
        private System.Windows.Forms.BindingSource factorBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private System.Windows.Forms.BindingSource factorCreditLineBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx factorTypeComboBox;
        private DevComponents.DotNetBar.Validator.SuperValidator factorValidator;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput freezeDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX freezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX freezerTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelAgreementDetail;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelBasic;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelContacts;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditLineDetail;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelMembership;
        private DevComponents.DotNetBar.Controls.TextBoxX iFISAvailableOnPrivateForumTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX membershipDateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX membershipStatusTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodBeginDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput periodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX postalAddress_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX postalAddress_2TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX postalCodePostTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX postalCodeVisitingTextBox;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator7;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator8;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator9;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemAgreement;
        private DevComponents.DotNetBar.TabItem tabItemFactor;
        private DevComponents.DotNetBar.TabItem tabItemFactorCreditLine;
        private DevComponents.DotNetBar.TabControlPanel tabPanelAgreement;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCreditLine;
        private DevComponents.DotNetBar.TabControlPanel tabPanelFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAgreementComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAgreementCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContacts1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContacts2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContacts3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContacts4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditLineCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorGroupName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGeneralCorrespondence1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGeneralCorrespondence2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbGroupFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbManagement1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbManagement2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbShareholders;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWorkingHours;
        private DevComponents.DotNetBar.Controls.TextBoxX telefax_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX telefax_2TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX telephone_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX telephone_2TextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput unfreezeDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezeReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX unfreezerTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX visitingAddress_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX visitingAddress_2TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX webSiteTextBox;

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

            if (this._context != null)
            {
                this._context.Dispose();
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
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.LabelX factorTypeLabel;
            DevComponents.DotNetBar.LabelX countryNameLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX companyNameLabel;
            DevComponents.DotNetBar.LabelX departmentLabel;
            DevComponents.DotNetBar.LabelX postalAddress_1Label;
            DevComponents.DotNetBar.LabelX postalCodePostLabel;
            DevComponents.DotNetBar.LabelX cityPostLabel;
            DevComponents.DotNetBar.LabelX visitingAddress_1Label;
            DevComponents.DotNetBar.LabelX postalCodeVisitingLabel;
            DevComponents.DotNetBar.LabelX cityVisitingLabel;
            DevComponents.DotNetBar.LabelX emailLabel;
            DevComponents.DotNetBar.LabelX webSiteLabel;
            DevComponents.DotNetBar.LabelX telephone_1Label;
            DevComponents.DotNetBar.LabelX telefax_1Label;
            DevComponents.DotNetBar.LabelX iFISAvailableOnPrivateForumLabel;
            DevComponents.DotNetBar.LabelX membershipStatusLabel;
            DevComponents.DotNetBar.LabelX membershipDateLabel;
            DevComponents.DotNetBar.LabelX dateOfLatestRevisionLabel;
            DevComponents.DotNetBar.LabelX llbShareholders;
            DevComponents.DotNetBar.LabelX lblManagement;
            DevComponents.DotNetBar.LabelX lblContacts;
            DevComponents.DotNetBar.LabelX lblGeneralCorrespondence;
            DevComponents.DotNetBar.LabelX lblWorkingHours;
            DevComponents.DotNetBar.LabelX creditLineCurrencyLabel;
            DevComponents.DotNetBar.LabelX creditLineLabel;
            DevComponents.DotNetBar.LabelX periodBeginLabel;
            DevComponents.DotNetBar.LabelX creditLineStatusLabel;
            DevComponents.DotNetBar.LabelX approveNoLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX freezeReasonLabel;
            DevComponents.DotNetBar.LabelX freezerLabel;
            DevComponents.DotNetBar.LabelX freezeDateLabel;
            DevComponents.DotNetBar.LabelX unfreezeReasonLabel;
            DevComponents.DotNetBar.LabelX unfreezerLabel;
            DevComponents.DotNetBar.LabelX unfreezeDateLabel;
            DevComponents.DotNetBar.LabelX lblCreateUserName;
            DevComponents.DotNetBar.LabelX lblCreditLineCreateUserName;
            DevComponents.DotNetBar.LabelX lblFactorGroupCode;
            DevComponents.DotNetBar.LabelX lblAgreementComment;
            DevComponents.DotNetBar.LabelX lblSignDate;
            DevComponents.DotNetBar.LabelX labelX1;
            DevComponents.DotNetBar.LabelX lblRemitCurrency;
            DevComponents.DotNetBar.LabelX lbcRemitAmount;
            DevComponents.DotNetBar.LabelX lblMsgCurrency;
            DevComponents.DotNetBar.LabelX lblMsgType;
            DevComponents.DotNetBar.LabelX lblCommmissionCreateUserName;
            DevComponents.DotNetBar.LabelX lblCommissionComment;
            DevComponents.DotNetBar.LabelX lblMsgDate;
            DevComponents.DotNetBar.LabelX lblRemitDate;
            DevComponents.DotNetBar.LabelX lblMsgAmount;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactorDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelCommissionRemit = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCommissionRemit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanelCommissionRemit = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbRemitCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbRemitAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbMsgCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbMsgType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCommissionRemitDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnCommissionRemitSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCommissionRemitUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCommissionRemitNew = new DevComponents.DotNetBar.ButtonX();
            this.btnCommissionRemitRefresh = new DevComponents.DotNetBar.ButtonX();
            this.tbCommissionCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCommissionComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diMsgDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diRemitDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbMsgAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemCommissionRemit = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelFactor = new DevComponents.DotNetBar.TabControlPanel();
            this.btnFactorUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelMembership = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dateOfLatestRevisionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipDateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.membershipStatusTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.iFISAvailableOnPrivateForumTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelContacts = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbShareholders = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbManagement2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbManagement1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContacts4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContacts3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContacts2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContacts1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbGeneralCorrespondence2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbGeneralCorrespondence1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbWorkingHours = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelBasic = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbFactorGroupName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnGroupSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbGroupFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.companyNameCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telefax_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telefax_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telephone_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telephone_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.webSiteTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cityVisitingTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.postalCodeVisitingTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.visitingAddress_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.visitingAddress_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cityPostTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.postalCodePostTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.postalAddress_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.postalAddress_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.departmentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.companyNameENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.countryNameComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.factorTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabItemFactor = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelAgreement = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvAgreements = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.factorCreditLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanelAgreementDetail = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbAgreementCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.agreementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgreementUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnAgreementRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnAgreementDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAgreementSave = new DevComponents.DotNetBar.ButtonX();
            this.btnAgreementNew = new DevComponents.DotNetBar.ButtonX();
            this.tbAgreementComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diSignDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tabItemAgreement = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCreditLine = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvFactorCreditLines = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanelCreditLineDetail = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbCreditLineCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFactorCreditLineUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorCreditLineRefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorCreditLineUnfreeze = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorCreditLineFreeze = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorCreditLineDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorCreditLineSave = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorCreditLineNew = new DevComponents.DotNetBar.ButtonX();
            this.unfreezeDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.unfreezerTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.unfreezeReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.freezeDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.freezerTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.freezeReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.approveNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditLineStatusTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.periodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.periodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.creditLineTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditLineCurrencyComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabItemFactorCreditLine = new DevComponents.DotNetBar.TabItem(this.components);
            this.factorValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.creditLineValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator9 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.agreementValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.commissionRemitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commissionRemitValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator10 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator11 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
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
            this.colMsgType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMsgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMsgAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgreementSignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgreementComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreezeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreezer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreezeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnfreezeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnfreezer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnfreezeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            factorTypeLabel = new DevComponents.DotNetBar.LabelX();
            countryNameLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            companyNameLabel = new DevComponents.DotNetBar.LabelX();
            departmentLabel = new DevComponents.DotNetBar.LabelX();
            postalAddress_1Label = new DevComponents.DotNetBar.LabelX();
            postalCodePostLabel = new DevComponents.DotNetBar.LabelX();
            cityPostLabel = new DevComponents.DotNetBar.LabelX();
            visitingAddress_1Label = new DevComponents.DotNetBar.LabelX();
            postalCodeVisitingLabel = new DevComponents.DotNetBar.LabelX();
            cityVisitingLabel = new DevComponents.DotNetBar.LabelX();
            emailLabel = new DevComponents.DotNetBar.LabelX();
            webSiteLabel = new DevComponents.DotNetBar.LabelX();
            telephone_1Label = new DevComponents.DotNetBar.LabelX();
            telefax_1Label = new DevComponents.DotNetBar.LabelX();
            iFISAvailableOnPrivateForumLabel = new DevComponents.DotNetBar.LabelX();
            membershipStatusLabel = new DevComponents.DotNetBar.LabelX();
            membershipDateLabel = new DevComponents.DotNetBar.LabelX();
            dateOfLatestRevisionLabel = new DevComponents.DotNetBar.LabelX();
            llbShareholders = new DevComponents.DotNetBar.LabelX();
            lblManagement = new DevComponents.DotNetBar.LabelX();
            lblContacts = new DevComponents.DotNetBar.LabelX();
            lblGeneralCorrespondence = new DevComponents.DotNetBar.LabelX();
            lblWorkingHours = new DevComponents.DotNetBar.LabelX();
            creditLineCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            creditLineLabel = new DevComponents.DotNetBar.LabelX();
            periodBeginLabel = new DevComponents.DotNetBar.LabelX();
            creditLineStatusLabel = new DevComponents.DotNetBar.LabelX();
            approveNoLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            freezeReasonLabel = new DevComponents.DotNetBar.LabelX();
            freezerLabel = new DevComponents.DotNetBar.LabelX();
            freezeDateLabel = new DevComponents.DotNetBar.LabelX();
            unfreezeReasonLabel = new DevComponents.DotNetBar.LabelX();
            unfreezerLabel = new DevComponents.DotNetBar.LabelX();
            unfreezeDateLabel = new DevComponents.DotNetBar.LabelX();
            lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblCreditLineCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblFactorGroupCode = new DevComponents.DotNetBar.LabelX();
            lblAgreementComment = new DevComponents.DotNetBar.LabelX();
            lblSignDate = new DevComponents.DotNetBar.LabelX();
            labelX1 = new DevComponents.DotNetBar.LabelX();
            lblRemitCurrency = new DevComponents.DotNetBar.LabelX();
            lbcRemitAmount = new DevComponents.DotNetBar.LabelX();
            lblMsgCurrency = new DevComponents.DotNetBar.LabelX();
            lblMsgType = new DevComponents.DotNetBar.LabelX();
            lblCommmissionCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblCommissionComment = new DevComponents.DotNetBar.LabelX();
            lblMsgDate = new DevComponents.DotNetBar.LabelX();
            lblRemitDate = new DevComponents.DotNetBar.LabelX();
            lblMsgAmount = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelCommissionRemit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissionRemit)).BeginInit();
            this.groupPanelCommissionRemit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diMsgDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRemitDate)).BeginInit();
            this.tabPanelFactor.SuspendLayout();
            this.groupPanelMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorBindingSource)).BeginInit();
            this.groupPanelContacts.SuspendLayout();
            this.groupPanelBasic.SuspendLayout();
            this.tabPanelAgreement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorCreditLineBindingSource)).BeginInit();
            this.groupPanelAgreementDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diSignDate)).BeginInit();
            this.tabPanelCreditLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorCreditLines)).BeginInit();
            this.groupPanelCreditLineDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unfreezeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBeginDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionRemitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // factorTypeLabel
            // 
            factorTypeLabel.AutoSize = true;
            factorTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            factorTypeLabel.BackgroundStyle.Class = "";
            factorTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            factorTypeLabel.Location = new System.Drawing.Point(17, 8);
            factorTypeLabel.Name = "factorTypeLabel";
            factorTypeLabel.Size = new System.Drawing.Size(57, 15);
            factorTypeLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            factorTypeLabel.TabIndex = 0;
            factorTypeLabel.Text = "<font color=\'red\'>*</font>机构类型:";
            // 
            // countryNameLabel
            // 
            countryNameLabel.AutoSize = true;
            countryNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            countryNameLabel.BackgroundStyle.Class = "";
            countryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            countryNameLabel.Location = new System.Drawing.Point(393, 9);
            countryNameLabel.Name = "countryNameLabel";
            countryNameLabel.Size = new System.Drawing.Size(45, 15);
            countryNameLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            countryNameLabel.TabIndex = 4;
            countryNameLabel.Text = "<font color=\'red\'>*</font>所在国:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            factorCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            factorCodeLabel.Location = new System.Drawing.Point(220, 8);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(57, 15);
            factorCodeLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            factorCodeLabel.TabIndex = 2;
            factorCodeLabel.Text = "<font color=\'red\'>*</font>机构代码:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            companyNameLabel.BackgroundStyle.Class = "";
            companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            companyNameLabel.Location = new System.Drawing.Point(29, 32);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(45, 15);
            companyNameLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            companyNameLabel.TabIndex = 6;
            companyNameLabel.Text = "<font color=\'red\'>*</font>公司名:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            departmentLabel.BackgroundStyle.Class = "";
            departmentLabel.Location = new System.Drawing.Point(397, 30);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(62, 16);
            departmentLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            departmentLabel.TabIndex = 9;
            departmentLabel.Text = "部门/分行:";
            // 
            // postalAddress_1Label
            // 
            postalAddress_1Label.AutoSize = true;
            postalAddress_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            postalAddress_1Label.BackgroundStyle.Class = "";
            postalAddress_1Label.Location = new System.Drawing.Point(17, 51);
            postalAddress_1Label.Name = "postalAddress_1Label";
            postalAddress_1Label.Size = new System.Drawing.Size(59, 16);
            postalAddress_1Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            postalAddress_1Label.TabIndex = 11;
            postalAddress_1Label.Text = "邮寄地址:";
            // 
            // postalCodePostLabel
            // 
            postalCodePostLabel.AutoSize = true;
            postalCodePostLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            postalCodePostLabel.BackgroundStyle.Class = "";
            postalCodePostLabel.Location = new System.Drawing.Point(42, 93);
            postalCodePostLabel.Name = "postalCodePostLabel";
            postalCodePostLabel.Size = new System.Drawing.Size(34, 16);
            postalCodePostLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            postalCodePostLabel.TabIndex = 17;
            postalCodePostLabel.Text = "邮编:";
            // 
            // cityPostLabel
            // 
            cityPostLabel.AutoSize = true;
            cityPostLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            cityPostLabel.BackgroundStyle.Class = "";
            cityPostLabel.Location = new System.Drawing.Point(42, 115);
            cityPostLabel.Name = "cityPostLabel";
            cityPostLabel.Size = new System.Drawing.Size(34, 16);
            cityPostLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            cityPostLabel.TabIndex = 21;
            cityPostLabel.Text = "城市:";
            // 
            // visitingAddress_1Label
            // 
            visitingAddress_1Label.AutoSize = true;
            visitingAddress_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            visitingAddress_1Label.BackgroundStyle.Class = "";
            visitingAddress_1Label.Location = new System.Drawing.Point(311, 51);
            visitingAddress_1Label.Name = "visitingAddress_1Label";
            visitingAddress_1Label.Size = new System.Drawing.Size(91, 16);
            visitingAddress_1Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            visitingAddress_1Label.TabIndex = 14;
            visitingAddress_1Label.Text = "Visiting Address:";
            // 
            // postalCodeVisitingLabel
            // 
            postalCodeVisitingLabel.AutoSize = true;
            postalCodeVisitingLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            postalCodeVisitingLabel.BackgroundStyle.Class = "";
            postalCodeVisitingLabel.Location = new System.Drawing.Point(292, 95);
            postalCodeVisitingLabel.Name = "postalCodeVisitingLabel";
            postalCodeVisitingLabel.Size = new System.Drawing.Size(111, 16);
            postalCodeVisitingLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            postalCodeVisitingLabel.TabIndex = 19;
            postalCodeVisitingLabel.Text = "Postal Code Visiting:";
            // 
            // cityVisitingLabel
            // 
            cityVisitingLabel.AutoSize = true;
            cityVisitingLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            cityVisitingLabel.BackgroundStyle.Class = "";
            cityVisitingLabel.Location = new System.Drawing.Point(333, 116);
            cityVisitingLabel.Name = "cityVisitingLabel";
            cityVisitingLabel.Size = new System.Drawing.Size(69, 16);
            cityVisitingLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            cityVisitingLabel.TabIndex = 23;
            cityVisitingLabel.Text = "City Visiting:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            emailLabel.BackgroundStyle.Class = "";
            emailLabel.Location = new System.Drawing.Point(38, 137);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 16);
            emailLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email:";
            // 
            // webSiteLabel
            // 
            webSiteLabel.AutoSize = true;
            webSiteLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            webSiteLabel.BackgroundStyle.Class = "";
            webSiteLabel.Location = new System.Drawing.Point(344, 136);
            webSiteLabel.Name = "webSiteLabel";
            webSiteLabel.Size = new System.Drawing.Size(59, 16);
            webSiteLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            webSiteLabel.TabIndex = 27;
            webSiteLabel.Text = "公司网址:";
            // 
            // telephone_1Label
            // 
            telephone_1Label.AutoSize = true;
            telephone_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            telephone_1Label.BackgroundStyle.Class = "";
            telephone_1Label.Location = new System.Drawing.Point(17, 158);
            telephone_1Label.Name = "telephone_1Label";
            telephone_1Label.Size = new System.Drawing.Size(59, 16);
            telephone_1Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            telephone_1Label.TabIndex = 29;
            telephone_1Label.Text = "联系电话:";
            // 
            // telefax_1Label
            // 
            telefax_1Label.AutoSize = true;
            telefax_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            telefax_1Label.BackgroundStyle.Class = "";
            telefax_1Label.Location = new System.Drawing.Point(369, 161);
            telefax_1Label.Name = "telefax_1Label";
            telefax_1Label.Size = new System.Drawing.Size(34, 16);
            telefax_1Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            telefax_1Label.TabIndex = 32;
            telefax_1Label.Text = "传真:";
            // 
            // iFISAvailableOnPrivateForumLabel
            // 
            iFISAvailableOnPrivateForumLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            iFISAvailableOnPrivateForumLabel.BackgroundStyle.Class = "";
            iFISAvailableOnPrivateForumLabel.Location = new System.Drawing.Point(9, 3);
            iFISAvailableOnPrivateForumLabel.Name = "iFISAvailableOnPrivateForumLabel";
            iFISAvailableOnPrivateForumLabel.Size = new System.Drawing.Size(88, 31);
            iFISAvailableOnPrivateForumLabel.TabIndex = 0;
            iFISAvailableOnPrivateForumLabel.Text = "IFISAvailable on Private Forum:";
            iFISAvailableOnPrivateForumLabel.WordWrap = true;
            // 
            // membershipStatusLabel
            // 
            membershipStatusLabel.AutoSize = true;
            membershipStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            membershipStatusLabel.BackgroundStyle.Class = "";
            membershipStatusLabel.Location = new System.Drawing.Point(308, 10);
            membershipStatusLabel.Name = "membershipStatusLabel";
            membershipStatusLabel.Size = new System.Drawing.Size(107, 16);
            membershipStatusLabel.TabIndex = 2;
            membershipStatusLabel.Text = "Membership Status:";
            // 
            // membershipDateLabel
            // 
            membershipDateLabel.AutoSize = true;
            membershipDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            membershipDateLabel.BackgroundStyle.Class = "";
            membershipDateLabel.Location = new System.Drawing.Point(9, 35);
            membershipDateLabel.Name = "membershipDateLabel";
            membershipDateLabel.Size = new System.Drawing.Size(99, 16);
            membershipDateLabel.TabIndex = 4;
            membershipDateLabel.Text = "Membership Date:";
            // 
            // dateOfLatestRevisionLabel
            // 
            dateOfLatestRevisionLabel.AutoSize = true;
            dateOfLatestRevisionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            dateOfLatestRevisionLabel.BackgroundStyle.Class = "";
            dateOfLatestRevisionLabel.Location = new System.Drawing.Point(285, 32);
            dateOfLatestRevisionLabel.Name = "dateOfLatestRevisionLabel";
            dateOfLatestRevisionLabel.Size = new System.Drawing.Size(129, 16);
            dateOfLatestRevisionLabel.TabIndex = 6;
            dateOfLatestRevisionLabel.Text = "Date Of Latest Revision:";
            // 
            // llbShareholders
            // 
            llbShareholders.AutoSize = true;
            llbShareholders.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            llbShareholders.BackgroundStyle.Class = "";
            llbShareholders.Location = new System.Drawing.Point(300, 200);
            llbShareholders.Name = "llbShareholders";
            llbShareholders.Size = new System.Drawing.Size(77, 16);
            llbShareholders.TabIndex = 13;
            llbShareholders.Text = "Shareholders:";
            // 
            // lblManagement
            // 
            lblManagement.AutoSize = true;
            lblManagement.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblManagement.BackgroundStyle.Class = "";
            lblManagement.Location = new System.Drawing.Point(17, 114);
            lblManagement.Name = "lblManagement";
            lblManagement.Size = new System.Drawing.Size(75, 16);
            lblManagement.TabIndex = 3;
            lblManagement.Text = "Management:";
            // 
            // lblContacts
            // 
            lblContacts.AutoSize = true;
            lblContacts.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblContacts.BackgroundStyle.Class = "";
            lblContacts.Location = new System.Drawing.Point(300, 9);
            lblContacts.Name = "lblContacts";
            lblContacts.Size = new System.Drawing.Size(54, 16);
            lblContacts.TabIndex = 6;
            lblContacts.Text = "Contacts:";
            // 
            // lblGeneralCorrespondence
            // 
            lblGeneralCorrespondence.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblGeneralCorrespondence.BackgroundStyle.Class = "";
            lblGeneralCorrespondence.Location = new System.Drawing.Point(17, 7);
            lblGeneralCorrespondence.Name = "lblGeneralCorrespondence";
            lblGeneralCorrespondence.Size = new System.Drawing.Size(151, 16);
            lblGeneralCorrespondence.TabIndex = 0;
            lblGeneralCorrespondence.Text = "General Correspondence:";
            lblGeneralCorrespondence.WordWrap = true;
            // 
            // lblWorkingHours
            // 
            lblWorkingHours.AutoSize = true;
            lblWorkingHours.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblWorkingHours.BackgroundStyle.Class = "";
            lblWorkingHours.Location = new System.Drawing.Point(17, 222);
            lblWorkingHours.Name = "lblWorkingHours";
            lblWorkingHours.Size = new System.Drawing.Size(84, 16);
            lblWorkingHours.TabIndex = 11;
            lblWorkingHours.Text = "Working Hours:";
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
            creditLineCurrencyLabel.Location = new System.Drawing.Point(25, 11);
            creditLineCurrencyLabel.Name = "creditLineCurrencyLabel";
            creditLineCurrencyLabel.Size = new System.Drawing.Size(57, 15);
            creditLineCurrencyLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            creditLineCurrencyLabel.TabIndex = 0;
            creditLineCurrencyLabel.Text = "<font color=\'red\'>*</font>额度币别:";
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
            creditLineLabel.Location = new System.Drawing.Point(24, 33);
            creditLineLabel.Name = "creditLineLabel";
            creditLineLabel.Size = new System.Drawing.Size(57, 15);
            creditLineLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            creditLineLabel.TabIndex = 5;
            creditLineLabel.Text = "<font color=\'red\'>*</font>额度上限:";
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
            periodBeginLabel.Location = new System.Drawing.Point(232, 11);
            periodBeginLabel.Name = "periodBeginLabel";
            periodBeginLabel.Size = new System.Drawing.Size(57, 15);
            periodBeginLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            periodBeginLabel.TabIndex = 2;
            periodBeginLabel.Text = "<font color=\'red\'>*</font>有效期限:";
            // 
            // creditLineStatusLabel
            // 
            creditLineStatusLabel.AutoSize = true;
            creditLineStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            creditLineStatusLabel.BackgroundStyle.Class = "";
            creditLineStatusLabel.Location = new System.Drawing.Point(25, 50);
            creditLineStatusLabel.Name = "creditLineStatusLabel";
            creditLineStatusLabel.Size = new System.Drawing.Size(59, 16);
            creditLineStatusLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            creditLineStatusLabel.TabIndex = 9;
            creditLineStatusLabel.Text = "额度状态:";
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
            approveNoLabel.Location = new System.Drawing.Point(232, 32);
            approveNoLabel.Name = "approveNoLabel";
            approveNoLabel.Size = new System.Drawing.Size(57, 15);
            approveNoLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            approveNoLabel.TabIndex = 7;
            approveNoLabel.Text = "<font color=\'red\'>*</font>授信编号:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(49, 73);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            commentLabel.TabIndex = 13;
            commentLabel.Text = "备注:";
            // 
            // freezeReasonLabel
            // 
            freezeReasonLabel.AutoSize = true;
            freezeReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            freezeReasonLabel.BackgroundStyle.Class = "";
            freezeReasonLabel.Location = new System.Drawing.Point(25, 140);
            freezeReasonLabel.Name = "freezeReasonLabel";
            freezeReasonLabel.Size = new System.Drawing.Size(59, 16);
            freezeReasonLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            freezeReasonLabel.TabIndex = 15;
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
            freezerLabel.Location = new System.Drawing.Point(35, 175);
            freezerLabel.Name = "freezerLabel";
            freezerLabel.Size = new System.Drawing.Size(47, 16);
            freezerLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            freezerLabel.TabIndex = 17;
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
            freezeDateLabel.Location = new System.Drawing.Point(232, 175);
            freezeDateLabel.Name = "freezeDateLabel";
            freezeDateLabel.Size = new System.Drawing.Size(59, 16);
            freezeDateLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            freezeDateLabel.TabIndex = 19;
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
            unfreezeReasonLabel.Location = new System.Drawing.Point(23, 197);
            unfreezeReasonLabel.Name = "unfreezeReasonLabel";
            unfreezeReasonLabel.Size = new System.Drawing.Size(59, 16);
            unfreezeReasonLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            unfreezeReasonLabel.TabIndex = 21;
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
            unfreezerLabel.Location = new System.Drawing.Point(35, 236);
            unfreezerLabel.Name = "unfreezerLabel";
            unfreezerLabel.Size = new System.Drawing.Size(47, 16);
            unfreezerLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            unfreezerLabel.TabIndex = 23;
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
            unfreezeDateLabel.Location = new System.Drawing.Point(232, 237);
            unfreezeDateLabel.Name = "unfreezeDateLabel";
            unfreezeDateLabel.Size = new System.Drawing.Size(59, 16);
            unfreezeDateLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            unfreezeDateLabel.TabIndex = 25;
            unfreezeDateLabel.Text = "解冻日期:";
            // 
            // lblCreateUserName
            // 
            lblCreateUserName.AutoSize = true;
            lblCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCreateUserName.BackgroundStyle.Class = "";
            lblCreateUserName.Location = new System.Drawing.Point(30, 201);
            lblCreateUserName.Name = "lblCreateUserName";
            lblCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCreateUserName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCreateUserName.TabIndex = 35;
            lblCreateUserName.Text = "经办人:";
            // 
            // lblCreditLineCreateUserName
            // 
            lblCreditLineCreateUserName.AutoSize = true;
            lblCreditLineCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCreditLineCreateUserName.BackgroundStyle.Class = "";
            lblCreditLineCreateUserName.Location = new System.Drawing.Point(35, 111);
            lblCreditLineCreateUserName.Name = "lblCreditLineCreateUserName";
            lblCreditLineCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCreditLineCreateUserName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCreditLineCreateUserName.TabIndex = 34;
            lblCreditLineCreateUserName.Text = "经办人:";
            // 
            // lblFactorGroupCode
            // 
            lblFactorGroupCode.AutoSize = true;
            lblFactorGroupCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblFactorGroupCode.BackgroundStyle.Class = "";
            lblFactorGroupCode.Location = new System.Drawing.Point(355, 203);
            lblFactorGroupCode.Name = "lblFactorGroupCode";
            lblFactorGroupCode.Size = new System.Drawing.Size(47, 16);
            lblFactorGroupCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblFactorGroupCode.TabIndex = 37;
            lblFactorGroupCode.Text = "集团号:";
            // 
            // lblAgreementComment
            // 
            lblAgreementComment.AutoSize = true;
            lblAgreementComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblAgreementComment.BackgroundStyle.Class = "";
            lblAgreementComment.Location = new System.Drawing.Point(48, 43);
            lblAgreementComment.Name = "lblAgreementComment";
            lblAgreementComment.Size = new System.Drawing.Size(34, 16);
            lblAgreementComment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblAgreementComment.TabIndex = 13;
            lblAgreementComment.Text = "备注:";
            // 
            // lblSignDate
            // 
            lblSignDate.AutoSize = true;
            lblSignDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblSignDate.BackgroundStyle.Class = "";
            lblSignDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblSignDate.Location = new System.Drawing.Point(37, 12);
            lblSignDate.Name = "lblSignDate";
            lblSignDate.Size = new System.Drawing.Size(45, 15);
            lblSignDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblSignDate.TabIndex = 5;
            lblSignDate.Text = "<font color=\'red\'>*</font>签订日:";
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            labelX1.BackgroundStyle.Class = "";
            labelX1.Location = new System.Drawing.Point(249, 13);
            labelX1.Name = "labelX1";
            labelX1.Size = new System.Drawing.Size(47, 16);
            labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            labelX1.TabIndex = 36;
            labelX1.Text = "经办人:";
            // 
            // lblRemitCurrency
            // 
            lblRemitCurrency.AutoSize = true;
            lblRemitCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRemitCurrency.BackgroundStyle.Class = "";
            lblRemitCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblRemitCurrency.Location = new System.Drawing.Point(200, 52);
            lblRemitCurrency.Name = "lblRemitCurrency";
            lblRemitCurrency.Size = new System.Drawing.Size(59, 16);
            lblRemitCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblRemitCurrency.TabIndex = 31;
            lblRemitCurrency.Text = "汇款币别:";
            // 
            // lbcRemitAmount
            // 
            lbcRemitAmount.AutoSize = true;
            lbcRemitAmount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lbcRemitAmount.BackgroundStyle.Class = "";
            lbcRemitAmount.Location = new System.Drawing.Point(356, 51);
            lbcRemitAmount.Name = "lbcRemitAmount";
            lbcRemitAmount.Size = new System.Drawing.Size(59, 16);
            lbcRemitAmount.TabIndex = 29;
            lbcRemitAmount.Text = "汇款金额:";
            // 
            // lblMsgCurrency
            // 
            lblMsgCurrency.AutoSize = true;
            lblMsgCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgCurrency.BackgroundStyle.Class = "";
            lblMsgCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblMsgCurrency.Location = new System.Drawing.Point(200, 28);
            lblMsgCurrency.Name = "lblMsgCurrency";
            lblMsgCurrency.Size = new System.Drawing.Size(57, 15);
            lblMsgCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblMsgCurrency.TabIndex = 27;
            lblMsgCurrency.Text = "<font color=\'red\'>*</font>消息币别:";
            // 
            // lblMsgType
            // 
            lblMsgType.AutoSize = true;
            lblMsgType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgType.BackgroundStyle.Class = "";
            lblMsgType.Location = new System.Drawing.Point(21, 5);
            lblMsgType.Name = "lblMsgType";
            lblMsgType.Size = new System.Drawing.Size(57, 15);
            lblMsgType.TabIndex = 4;
            lblMsgType.Text = "<font color=\'red\'>*</font>消息类型:";
            // 
            // lblCommmissionCreateUserName
            // 
            lblCommmissionCreateUserName.AutoSize = true;
            lblCommmissionCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCommmissionCreateUserName.BackgroundStyle.Class = "";
            lblCommmissionCreateUserName.Location = new System.Drawing.Point(34, 138);
            lblCommmissionCreateUserName.Name = "lblCommmissionCreateUserName";
            lblCommmissionCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCommmissionCreateUserName.TabIndex = 20;
            lblCommmissionCreateUserName.Text = "经办人:";
            // 
            // lblCommissionComment
            // 
            lblCommissionComment.AutoSize = true;
            lblCommissionComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCommissionComment.BackgroundStyle.Class = "";
            lblCommissionComment.Location = new System.Drawing.Point(46, 74);
            lblCommissionComment.Name = "lblCommissionComment";
            lblCommissionComment.Size = new System.Drawing.Size(34, 16);
            lblCommissionComment.TabIndex = 18;
            lblCommissionComment.Text = "备注:";
            // 
            // lblMsgDate
            // 
            lblMsgDate.AutoSize = true;
            lblMsgDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgDate.BackgroundStyle.Class = "";
            lblMsgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblMsgDate.Location = new System.Drawing.Point(21, 28);
            lblMsgDate.Name = "lblMsgDate";
            lblMsgDate.Size = new System.Drawing.Size(57, 15);
            lblMsgDate.TabIndex = 6;
            lblMsgDate.Text = "<font color=\'red\'>*</font>消息日期:";
            // 
            // lblRemitDate
            // 
            lblRemitDate.AutoSize = true;
            lblRemitDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRemitDate.BackgroundStyle.Class = "";
            lblRemitDate.Location = new System.Drawing.Point(22, 51);
            lblRemitDate.Name = "lblRemitDate";
            lblRemitDate.Size = new System.Drawing.Size(59, 16);
            lblRemitDate.TabIndex = 10;
            lblRemitDate.Text = "汇款日期:";
            // 
            // lblMsgAmount
            // 
            lblMsgAmount.AutoSize = true;
            lblMsgAmount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgAmount.BackgroundStyle.Class = "";
            lblMsgAmount.Location = new System.Drawing.Point(354, 28);
            lblMsgAmount.Name = "lblMsgAmount";
            lblMsgAmount.Size = new System.Drawing.Size(57, 15);
            lblMsgAmount.TabIndex = 8;
            lblMsgAmount.Text = "<font color=\'red\'>*</font>消息金额:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelCommissionRemit);
            this.tabControl.Controls.Add(this.tabPanelCreditLine);
            this.tabControl.Controls.Add(this.tabPanelAgreement);
            this.tabControl.Controls.Add(this.tabPanelFactor);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(602, 632);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemFactor);
            this.tabControl.Tabs.Add(this.tabItemFactorCreditLine);
            this.tabControl.Tabs.Add(this.tabItemAgreement);
            this.tabControl.Tabs.Add(this.tabItemCommissionRemit);
            this.tabControl.Text = "tabControl";
            // 
            // tabPanelCommissionRemit
            // 
            this.tabPanelCommissionRemit.Controls.Add(this.dgvCommissionRemit);
            this.tabPanelCommissionRemit.Controls.Add(this.groupPanelCommissionRemit);
            this.tabPanelCommissionRemit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCommissionRemit.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCommissionRemit.Name = "tabPanelCommissionRemit";
            this.tabPanelCommissionRemit.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCommissionRemit.Size = new System.Drawing.Size(602, 606);
            this.tabPanelCommissionRemit.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelCommissionRemit.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelCommissionRemit.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelCommissionRemit.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelCommissionRemit.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelCommissionRemit.Style.GradientAngle = 90;
            this.tabPanelCommissionRemit.TabIndex = 4;
            this.tabPanelCommissionRemit.TabItem = this.tabItemCommissionRemit;
            // 
            // dgvCommissionRemit
            // 
            this.dgvCommissionRemit.AllowUserToAddRows = false;
            this.dgvCommissionRemit.AllowUserToDeleteRows = false;
            this.dgvCommissionRemit.AllowUserToOrderColumns = true;
            this.dgvCommissionRemit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommissionRemit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMsgType,
            this.colMsgDate,
            this.colMsgAmount});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommissionRemit.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvCommissionRemit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommissionRemit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCommissionRemit.Location = new System.Drawing.Point(1, 199);
            this.dgvCommissionRemit.Name = "dgvCommissionRemit";
            this.dgvCommissionRemit.ReadOnly = true;
            this.dgvCommissionRemit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommissionRemit.Size = new System.Drawing.Size(600, 406);
            this.dgvCommissionRemit.TabIndex = 6;
            this.dgvCommissionRemit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCommissionRemit);
            // 
            // groupPanelCommissionRemit
            // 
            this.groupPanelCommissionRemit.AutoScroll = true;
            this.groupPanelCommissionRemit.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCommissionRemit.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCommissionRemit.Controls.Add(this.cbRemitCurrency);
            this.groupPanelCommissionRemit.Controls.Add(lblRemitCurrency);
            this.groupPanelCommissionRemit.Controls.Add(lbcRemitAmount);
            this.groupPanelCommissionRemit.Controls.Add(this.tbRemitAmount);
            this.groupPanelCommissionRemit.Controls.Add(this.cbMsgCurrency);
            this.groupPanelCommissionRemit.Controls.Add(lblMsgCurrency);
            this.groupPanelCommissionRemit.Controls.Add(lblMsgType);
            this.groupPanelCommissionRemit.Controls.Add(this.tbMsgType);
            this.groupPanelCommissionRemit.Controls.Add(this.btnCommissionRemitDelete);
            this.groupPanelCommissionRemit.Controls.Add(this.btnCommissionRemitSave);
            this.groupPanelCommissionRemit.Controls.Add(this.btnCommissionRemitUpdate);
            this.groupPanelCommissionRemit.Controls.Add(this.btnCommissionRemitNew);
            this.groupPanelCommissionRemit.Controls.Add(this.btnCommissionRemitRefresh);
            this.groupPanelCommissionRemit.Controls.Add(lblCommmissionCreateUserName);
            this.groupPanelCommissionRemit.Controls.Add(this.tbCommissionCreateUserName);
            this.groupPanelCommissionRemit.Controls.Add(lblCommissionComment);
            this.groupPanelCommissionRemit.Controls.Add(this.tbCommissionComment);
            this.groupPanelCommissionRemit.Controls.Add(lblMsgDate);
            this.groupPanelCommissionRemit.Controls.Add(this.diMsgDate);
            this.groupPanelCommissionRemit.Controls.Add(lblRemitDate);
            this.groupPanelCommissionRemit.Controls.Add(this.diRemitDate);
            this.groupPanelCommissionRemit.Controls.Add(lblMsgAmount);
            this.groupPanelCommissionRemit.Controls.Add(this.tbMsgAmount);
            this.groupPanelCommissionRemit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCommissionRemit.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCommissionRemit.Name = "groupPanelCommissionRemit";
            this.groupPanelCommissionRemit.Size = new System.Drawing.Size(600, 198);
            // 
            // 
            // 
            this.groupPanelCommissionRemit.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelCommissionRemit.Style.BackColorGradientAngle = 90;
            this.groupPanelCommissionRemit.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelCommissionRemit.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCommissionRemit.Style.BorderBottomWidth = 1;
            this.groupPanelCommissionRemit.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelCommissionRemit.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCommissionRemit.Style.BorderLeftWidth = 1;
            this.groupPanelCommissionRemit.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCommissionRemit.Style.BorderRightWidth = 1;
            this.groupPanelCommissionRemit.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCommissionRemit.Style.BorderTopWidth = 1;
            this.groupPanelCommissionRemit.Style.Class = "";
            this.groupPanelCommissionRemit.Style.CornerDiameter = 4;
            this.groupPanelCommissionRemit.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCommissionRemit.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCommissionRemit.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCommissionRemit.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCommissionRemit.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelCommissionRemit.StyleMouseOver.Class = "";
            this.groupPanelCommissionRemit.TabIndex = 7;
            // 
            // cbRemitCurrency
            // 
            this.cbRemitCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRemitCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRemitCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commissionRemitBindingSource, "RemitCurrency", true));
            this.cbRemitCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRemitCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemitCurrency.ItemHeight = 14;
            this.cbRemitCurrency.Location = new System.Drawing.Point(263, 49);
            this.cbRemitCurrency.Name = "cbRemitCurrency";
            this.cbRemitCurrency.Size = new System.Drawing.Size(85, 20);
            this.cbRemitCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbRemitCurrency.TabIndex = 32;
            // 
            // tbRemitAmount
            // 
            // 
            // 
            // 
            this.tbRemitAmount.Border.Class = "TextBoxBorder";
            this.tbRemitAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "RemitAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbRemitAmount.Location = new System.Drawing.Point(424, 49);
            this.tbRemitAmount.Name = "tbRemitAmount";
            this.tbRemitAmount.Size = new System.Drawing.Size(100, 20);
            this.tbRemitAmount.TabIndex = 30;
            // 
            // cbMsgCurrency
            // 
            this.cbMsgCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMsgCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMsgCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commissionRemitBindingSource, "MsgCurrency", true));
            this.cbMsgCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMsgCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMsgCurrency.ItemHeight = 14;
            this.cbMsgCurrency.Location = new System.Drawing.Point(263, 26);
            this.cbMsgCurrency.Name = "cbMsgCurrency";
            this.cbMsgCurrency.Size = new System.Drawing.Size(85, 20);
            this.cbMsgCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMsgCurrency.TabIndex = 28;
            this.commissionRemitValidator.SetValidator1(this.cbMsgCurrency, this.requiredFieldValidator10);
            // 
            // tbMsgType
            // 
            // 
            // 
            // 
            this.tbMsgType.Border.Class = "TextBoxBorder";
            this.tbMsgType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgType", true));
            this.tbMsgType.Location = new System.Drawing.Point(82, 3);
            this.tbMsgType.Name = "tbMsgType";
            this.tbMsgType.Size = new System.Drawing.Size(100, 20);
            this.tbMsgType.TabIndex = 5;
            this.commissionRemitValidator.SetValidator1(this.tbMsgType, this.requiredFieldValidator2);
            // 
            // btnCommissionRemitDelete
            // 
            this.btnCommissionRemitDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitDelete.Location = new System.Drawing.Point(419, 162);
            this.btnCommissionRemitDelete.Name = "btnCommissionRemitDelete";
            this.btnCommissionRemitDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCommissionRemitDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitDelete.TabIndex = 26;
            this.btnCommissionRemitDelete.Text = "删除";
            this.btnCommissionRemitDelete.Click += new System.EventHandler(this.DeleteCommissionRemit);
            // 
            // btnCommissionRemitSave
            // 
            this.btnCommissionRemitSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitSave.Location = new System.Drawing.Point(338, 162);
            this.btnCommissionRemitSave.Name = "btnCommissionRemitSave";
            this.btnCommissionRemitSave.Size = new System.Drawing.Size(75, 23);
            this.btnCommissionRemitSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitSave.TabIndex = 25;
            this.btnCommissionRemitSave.Text = "保存";
            this.btnCommissionRemitSave.Click += new System.EventHandler(this.SaveCommissionRemit);
            // 
            // btnCommissionRemitUpdate
            // 
            this.btnCommissionRemitUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitUpdate.Location = new System.Drawing.Point(257, 162);
            this.btnCommissionRemitUpdate.Name = "btnCommissionRemitUpdate";
            this.btnCommissionRemitUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCommissionRemitUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitUpdate.TabIndex = 24;
            this.btnCommissionRemitUpdate.Text = "编辑";
            this.btnCommissionRemitUpdate.Click += new System.EventHandler(this.UpdateCommissionRemit);
            // 
            // btnCommissionRemitNew
            // 
            this.btnCommissionRemitNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitNew.Location = new System.Drawing.Point(176, 162);
            this.btnCommissionRemitNew.Name = "btnCommissionRemitNew";
            this.btnCommissionRemitNew.Size = new System.Drawing.Size(75, 23);
            this.btnCommissionRemitNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitNew.TabIndex = 23;
            this.btnCommissionRemitNew.Text = "新建";
            this.btnCommissionRemitNew.Click += new System.EventHandler(this.NewCommissionRemit);
            // 
            // btnCommissionRemitRefresh
            // 
            this.btnCommissionRemitRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommissionRemitRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommissionRemitRefresh.Location = new System.Drawing.Point(95, 162);
            this.btnCommissionRemitRefresh.Name = "btnCommissionRemitRefresh";
            this.btnCommissionRemitRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnCommissionRemitRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommissionRemitRefresh.TabIndex = 22;
            this.btnCommissionRemitRefresh.Text = "刷新";
            this.btnCommissionRemitRefresh.Click += new System.EventHandler(this.RefreshCommissionRemitList);
            // 
            // tbCommissionCreateUserName
            // 
            // 
            // 
            // 
            this.tbCommissionCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCommissionCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "CreateUserName", true));
            this.tbCommissionCreateUserName.Location = new System.Drawing.Point(82, 136);
            this.tbCommissionCreateUserName.Name = "tbCommissionCreateUserName";
            this.tbCommissionCreateUserName.ReadOnly = true;
            this.tbCommissionCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCommissionCreateUserName.TabIndex = 21;
            // 
            // tbCommissionComment
            // 
            // 
            // 
            // 
            this.tbCommissionComment.Border.Class = "";
            this.tbCommissionComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "Comment", true));
            this.tbCommissionComment.Location = new System.Drawing.Point(82, 73);
            this.tbCommissionComment.Multiline = true;
            this.tbCommissionComment.Name = "tbCommissionComment";
            this.tbCommissionComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCommissionComment.Size = new System.Drawing.Size(442, 57);
            this.tbCommissionComment.TabIndex = 19;
            // 
            // diMsgDate
            // 
            // 
            // 
            // 
            this.diMsgDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diMsgDate.ButtonDropDown.Visible = true;
            this.diMsgDate.ButtonFreeText.Checked = true;
            this.diMsgDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgDate", true));
            this.diMsgDate.FreeTextEntryMode = true;
            this.diMsgDate.Location = new System.Drawing.Point(82, 26);
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diMsgDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diMsgDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diMsgDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diMsgDate.Name = "diMsgDate";
            this.diMsgDate.Size = new System.Drawing.Size(103, 20);
            this.diMsgDate.TabIndex = 7;
            this.commissionRemitValidator.SetValidator1(this.diMsgDate, this.requiredFieldValidator3);
            // 
            // diRemitDate
            // 
            // 
            // 
            // 
            this.diRemitDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diRemitDate.ButtonDropDown.Visible = true;
            this.diRemitDate.ButtonFreeText.Checked = true;
            this.diRemitDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "RemitDate", true));
            this.diRemitDate.FreeTextEntryMode = true;
            this.diRemitDate.Location = new System.Drawing.Point(81, 49);
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diRemitDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diRemitDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diRemitDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diRemitDate.Name = "diRemitDate";
            this.diRemitDate.Size = new System.Drawing.Size(103, 20);
            this.diRemitDate.TabIndex = 11;
            // 
            // tbMsgAmount
            // 
            // 
            // 
            // 
            this.tbMsgAmount.Border.Class = "TextBoxBorder";
            this.tbMsgAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbMsgAmount.Location = new System.Drawing.Point(424, 26);
            this.tbMsgAmount.Name = "tbMsgAmount";
            this.tbMsgAmount.Size = new System.Drawing.Size(100, 20);
            this.tbMsgAmount.TabIndex = 9;
            this.commissionRemitValidator.SetValidator1(this.tbMsgAmount, this.requiredFieldValidator11);
            // 
            // tabItemCommissionRemit
            // 
            this.tabItemCommissionRemit.AttachedControl = this.tabPanelCommissionRemit;
            this.tabItemCommissionRemit.Name = "tabItemCommissionRemit";
            this.tabItemCommissionRemit.Text = "保理费收付";
            // 
            // tabPanelFactor
            // 
            this.tabPanelFactor.AutoScroll = true;
            this.tabPanelFactor.Controls.Add(this.btnFactorUpdate);
            this.tabPanelFactor.Controls.Add(this.btnFactorSave);
            this.tabPanelFactor.Controls.Add(this.groupPanelMembership);
            this.tabPanelFactor.Controls.Add(this.groupPanelContacts);
            this.tabPanelFactor.Controls.Add(this.groupPanelBasic);
            this.tabPanelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelFactor.Location = new System.Drawing.Point(0, 26);
            this.tabPanelFactor.Name = "tabPanelFactor";
            this.tabPanelFactor.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelFactor.Size = new System.Drawing.Size(602, 606);
            this.tabPanelFactor.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelFactor.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelFactor.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelFactor.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelFactor.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelFactor.Style.GradientAngle = 90;
            this.tabPanelFactor.TabIndex = 1;
            this.tabPanelFactor.TabItem = this.tabItemFactor;
            // 
            // btnFactorUpdate
            // 
            this.btnFactorUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorUpdate.Location = new System.Drawing.Point(212, 571);
            this.btnFactorUpdate.Name = "btnFactorUpdate";
            this.btnFactorUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnFactorUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorUpdate.TabIndex = 0;
            this.btnFactorUpdate.Text = "编辑";
            this.btnFactorUpdate.Click += new System.EventHandler(this.UpdateFactor);
            // 
            // btnFactorSave
            // 
            this.btnFactorSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorSave.Location = new System.Drawing.Point(293, 571);
            this.btnFactorSave.Name = "btnFactorSave";
            this.btnFactorSave.Size = new System.Drawing.Size(75, 23);
            this.btnFactorSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorSave.TabIndex = 1;
            this.btnFactorSave.Text = "保存";
            this.btnFactorSave.Click += new System.EventHandler(this.SaveFactor);
            // 
            // groupPanelMembership
            // 
            this.groupPanelMembership.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelMembership.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelMembership.Controls.Add(dateOfLatestRevisionLabel);
            this.groupPanelMembership.Controls.Add(this.dateOfLatestRevisionTextBox);
            this.groupPanelMembership.Controls.Add(membershipDateLabel);
            this.groupPanelMembership.Controls.Add(this.membershipDateTextBox);
            this.groupPanelMembership.Controls.Add(membershipStatusLabel);
            this.groupPanelMembership.Controls.Add(this.membershipStatusTextBox);
            this.groupPanelMembership.Controls.Add(iFISAvailableOnPrivateForumLabel);
            this.groupPanelMembership.Controls.Add(this.iFISAvailableOnPrivateForumTextBox);
            this.groupPanelMembership.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelMembership.Location = new System.Drawing.Point(1, 502);
            this.groupPanelMembership.Name = "groupPanelMembership";
            this.groupPanelMembership.Size = new System.Drawing.Size(600, 63);
            // 
            // 
            // 
            this.groupPanelMembership.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelMembership.Style.BackColorGradientAngle = 90;
            this.groupPanelMembership.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelMembership.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelMembership.Style.BorderBottomWidth = 1;
            this.groupPanelMembership.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelMembership.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelMembership.Style.BorderLeftWidth = 1;
            this.groupPanelMembership.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelMembership.Style.BorderRightWidth = 1;
            this.groupPanelMembership.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelMembership.Style.BorderTopWidth = 1;
            this.groupPanelMembership.Style.Class = "";
            this.groupPanelMembership.Style.CornerDiameter = 4;
            this.groupPanelMembership.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelMembership.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelMembership.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelMembership.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelMembership.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelMembership.StyleMouseOver.Class = "";
            this.groupPanelMembership.TabIndex = 2;
            // 
            // dateOfLatestRevisionTextBox
            // 
            // 
            // 
            // 
            this.dateOfLatestRevisionTextBox.Border.Class = "TextBoxBorder";
            this.dateOfLatestRevisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "DateOfLatestRevision", true));
            this.dateOfLatestRevisionTextBox.Location = new System.Drawing.Point(414, 29);
            this.dateOfLatestRevisionTextBox.Name = "dateOfLatestRevisionTextBox";
            this.dateOfLatestRevisionTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateOfLatestRevisionTextBox.TabIndex = 7;
            // 
            // factorBindingSource
            // 
            this.factorBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Factor);
            // 
            // membershipDateTextBox
            // 
            // 
            // 
            // 
            this.membershipDateTextBox.Border.Class = "TextBoxBorder";
            this.membershipDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "MembershipDate", true));
            this.membershipDateTextBox.Location = new System.Drawing.Point(108, 32);
            this.membershipDateTextBox.Name = "membershipDateTextBox";
            this.membershipDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.membershipDateTextBox.TabIndex = 5;
            // 
            // membershipStatusTextBox
            // 
            // 
            // 
            // 
            this.membershipStatusTextBox.Border.Class = "TextBoxBorder";
            this.membershipStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "MembershipStatus", true));
            this.membershipStatusTextBox.Location = new System.Drawing.Point(414, 7);
            this.membershipStatusTextBox.Name = "membershipStatusTextBox";
            this.membershipStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.membershipStatusTextBox.TabIndex = 3;
            // 
            // iFISAvailableOnPrivateForumTextBox
            // 
            // 
            // 
            // 
            this.iFISAvailableOnPrivateForumTextBox.Border.Class = "TextBoxBorder";
            this.iFISAvailableOnPrivateForumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "IFISAvailableOnPrivateForum", true));
            this.iFISAvailableOnPrivateForumTextBox.Location = new System.Drawing.Point(108, 10);
            this.iFISAvailableOnPrivateForumTextBox.Name = "iFISAvailableOnPrivateForumTextBox";
            this.iFISAvailableOnPrivateForumTextBox.Size = new System.Drawing.Size(100, 20);
            this.iFISAvailableOnPrivateForumTextBox.TabIndex = 1;
            // 
            // groupPanelContacts
            // 
            this.groupPanelContacts.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelContacts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelContacts.Controls.Add(llbShareholders);
            this.groupPanelContacts.Controls.Add(this.tbShareholders);
            this.groupPanelContacts.Controls.Add(this.tbManagement2);
            this.groupPanelContacts.Controls.Add(lblManagement);
            this.groupPanelContacts.Controls.Add(this.tbManagement1);
            this.groupPanelContacts.Controls.Add(this.tbContacts4);
            this.groupPanelContacts.Controls.Add(this.tbContacts3);
            this.groupPanelContacts.Controls.Add(this.tbContacts2);
            this.groupPanelContacts.Controls.Add(lblContacts);
            this.groupPanelContacts.Controls.Add(this.tbContacts1);
            this.groupPanelContacts.Controls.Add(this.tbGeneralCorrespondence2);
            this.groupPanelContacts.Controls.Add(lblGeneralCorrespondence);
            this.groupPanelContacts.Controls.Add(this.tbGeneralCorrespondence1);
            this.groupPanelContacts.Controls.Add(lblWorkingHours);
            this.groupPanelContacts.Controls.Add(this.tbWorkingHours);
            this.groupPanelContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelContacts.Location = new System.Drawing.Point(1, 252);
            this.groupPanelContacts.Name = "groupPanelContacts";
            this.groupPanelContacts.Size = new System.Drawing.Size(600, 250);
            // 
            // 
            // 
            this.groupPanelContacts.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelContacts.Style.BackColorGradientAngle = 90;
            this.groupPanelContacts.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelContacts.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContacts.Style.BorderBottomWidth = 1;
            this.groupPanelContacts.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelContacts.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContacts.Style.BorderLeftWidth = 1;
            this.groupPanelContacts.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContacts.Style.BorderRightWidth = 1;
            this.groupPanelContacts.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelContacts.Style.BorderTopWidth = 1;
            this.groupPanelContacts.Style.Class = "";
            this.groupPanelContacts.Style.CornerDiameter = 4;
            this.groupPanelContacts.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelContacts.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelContacts.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelContacts.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelContacts.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelContacts.StyleMouseOver.Class = "";
            this.groupPanelContacts.TabIndex = 1;
            // 
            // tbShareholders
            // 
            // 
            // 
            // 
            this.tbShareholders.Border.Class = "TextBoxBorder";
            this.tbShareholders.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Shareholders", true));
            this.tbShareholders.Location = new System.Drawing.Point(300, 221);
            this.tbShareholders.Name = "tbShareholders";
            this.tbShareholders.Size = new System.Drawing.Size(260, 20);
            this.tbShareholders.TabIndex = 14;
            // 
            // tbManagement2
            // 
            // 
            // 
            // 
            this.tbManagement2.Border.Class = "TextBoxBorder";
            this.tbManagement2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Management_2", true));
            this.tbManagement2.Location = new System.Drawing.Point(17, 176);
            this.tbManagement2.Multiline = true;
            this.tbManagement2.Name = "tbManagement2";
            this.tbManagement2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbManagement2.Size = new System.Drawing.Size(260, 40);
            this.tbManagement2.TabIndex = 5;
            // 
            // tbManagement1
            // 
            // 
            // 
            // 
            this.tbManagement1.Border.Class = "TextBoxBorder";
            this.tbManagement1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Management_1", true));
            this.tbManagement1.Location = new System.Drawing.Point(17, 135);
            this.tbManagement1.Multiline = true;
            this.tbManagement1.Name = "tbManagement1";
            this.tbManagement1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbManagement1.Size = new System.Drawing.Size(260, 40);
            this.tbManagement1.TabIndex = 4;
            // 
            // tbContacts4
            // 
            // 
            // 
            // 
            this.tbContacts4.Border.Class = "TextBoxBorder";
            this.tbContacts4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Contacts_4", true));
            this.tbContacts4.Location = new System.Drawing.Point(300, 148);
            this.tbContacts4.Multiline = true;
            this.tbContacts4.Name = "tbContacts4";
            this.tbContacts4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContacts4.Size = new System.Drawing.Size(260, 40);
            this.tbContacts4.TabIndex = 10;
            // 
            // tbContacts3
            // 
            // 
            // 
            // 
            this.tbContacts3.Border.Class = "TextBoxBorder";
            this.tbContacts3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Contacts_3", true));
            this.tbContacts3.Location = new System.Drawing.Point(300, 107);
            this.tbContacts3.Multiline = true;
            this.tbContacts3.Name = "tbContacts3";
            this.tbContacts3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContacts3.Size = new System.Drawing.Size(260, 40);
            this.tbContacts3.TabIndex = 9;
            // 
            // tbContacts2
            // 
            // 
            // 
            // 
            this.tbContacts2.Border.Class = "TextBoxBorder";
            this.tbContacts2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Contacts_2", true));
            this.tbContacts2.Location = new System.Drawing.Point(300, 66);
            this.tbContacts2.Multiline = true;
            this.tbContacts2.Name = "tbContacts2";
            this.tbContacts2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContacts2.Size = new System.Drawing.Size(260, 40);
            this.tbContacts2.TabIndex = 8;
            // 
            // tbContacts1
            // 
            // 
            // 
            // 
            this.tbContacts1.Border.Class = "TextBoxBorder";
            this.tbContacts1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Contacts_1", true));
            this.tbContacts1.Location = new System.Drawing.Point(300, 25);
            this.tbContacts1.Multiline = true;
            this.tbContacts1.Name = "tbContacts1";
            this.tbContacts1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContacts1.Size = new System.Drawing.Size(260, 40);
            this.tbContacts1.TabIndex = 7;
            // 
            // tbGeneralCorrespondence2
            // 
            // 
            // 
            // 
            this.tbGeneralCorrespondence2.Border.Class = "TextBoxBorder";
            this.tbGeneralCorrespondence2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "GeneralCorrespondence_2", true));
            this.tbGeneralCorrespondence2.Location = new System.Drawing.Point(17, 66);
            this.tbGeneralCorrespondence2.Multiline = true;
            this.tbGeneralCorrespondence2.Name = "tbGeneralCorrespondence2";
            this.tbGeneralCorrespondence2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbGeneralCorrespondence2.Size = new System.Drawing.Size(260, 40);
            this.tbGeneralCorrespondence2.TabIndex = 2;
            // 
            // tbGeneralCorrespondence1
            // 
            // 
            // 
            // 
            this.tbGeneralCorrespondence1.Border.Class = "TextBoxBorder";
            this.tbGeneralCorrespondence1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "GeneralCorrespondence_1", true));
            this.tbGeneralCorrespondence1.Location = new System.Drawing.Point(17, 25);
            this.tbGeneralCorrespondence1.Multiline = true;
            this.tbGeneralCorrespondence1.Name = "tbGeneralCorrespondence1";
            this.tbGeneralCorrespondence1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbGeneralCorrespondence1.Size = new System.Drawing.Size(260, 40);
            this.tbGeneralCorrespondence1.TabIndex = 1;
            // 
            // tbWorkingHours
            // 
            // 
            // 
            // 
            this.tbWorkingHours.Border.Class = "TextBoxBorder";
            this.tbWorkingHours.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "WorkingHours", true));
            this.tbWorkingHours.Location = new System.Drawing.Point(107, 221);
            this.tbWorkingHours.Name = "tbWorkingHours";
            this.tbWorkingHours.Size = new System.Drawing.Size(172, 20);
            this.tbWorkingHours.TabIndex = 12;
            // 
            // groupPanelBasic
            // 
            this.groupPanelBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelBasic.Controls.Add(this.tbFactorGroupName);
            this.groupPanelBasic.Controls.Add(this.btnGroupSelect);
            this.groupPanelBasic.Controls.Add(lblFactorGroupCode);
            this.groupPanelBasic.Controls.Add(this.tbGroupFactorCode);
            this.groupPanelBasic.Controls.Add(lblCreateUserName);
            this.groupPanelBasic.Controls.Add(this.tbCreateUserName);
            this.groupPanelBasic.Controls.Add(this.companyNameCNTextBox);
            this.groupPanelBasic.Controls.Add(this.telefax_2TextBox);
            this.groupPanelBasic.Controls.Add(telefax_1Label);
            this.groupPanelBasic.Controls.Add(this.telefax_1TextBox);
            this.groupPanelBasic.Controls.Add(this.telephone_2TextBox);
            this.groupPanelBasic.Controls.Add(telephone_1Label);
            this.groupPanelBasic.Controls.Add(this.telephone_1TextBox);
            this.groupPanelBasic.Controls.Add(webSiteLabel);
            this.groupPanelBasic.Controls.Add(this.webSiteTextBox);
            this.groupPanelBasic.Controls.Add(emailLabel);
            this.groupPanelBasic.Controls.Add(this.emailTextBox);
            this.groupPanelBasic.Controls.Add(cityVisitingLabel);
            this.groupPanelBasic.Controls.Add(this.cityVisitingTextBox);
            this.groupPanelBasic.Controls.Add(postalCodeVisitingLabel);
            this.groupPanelBasic.Controls.Add(this.postalCodeVisitingTextBox);
            this.groupPanelBasic.Controls.Add(this.visitingAddress_2TextBox);
            this.groupPanelBasic.Controls.Add(visitingAddress_1Label);
            this.groupPanelBasic.Controls.Add(this.visitingAddress_1TextBox);
            this.groupPanelBasic.Controls.Add(cityPostLabel);
            this.groupPanelBasic.Controls.Add(this.cityPostTextBox);
            this.groupPanelBasic.Controls.Add(postalCodePostLabel);
            this.groupPanelBasic.Controls.Add(this.postalCodePostTextBox);
            this.groupPanelBasic.Controls.Add(this.postalAddress_2TextBox);
            this.groupPanelBasic.Controls.Add(postalAddress_1Label);
            this.groupPanelBasic.Controls.Add(this.postalAddress_1TextBox);
            this.groupPanelBasic.Controls.Add(departmentLabel);
            this.groupPanelBasic.Controls.Add(this.departmentTextBox);
            this.groupPanelBasic.Controls.Add(companyNameLabel);
            this.groupPanelBasic.Controls.Add(this.companyNameENTextBox);
            this.groupPanelBasic.Controls.Add(factorCodeLabel);
            this.groupPanelBasic.Controls.Add(this.factorCodeTextBox);
            this.groupPanelBasic.Controls.Add(countryNameLabel);
            this.groupPanelBasic.Controls.Add(this.countryNameComboBox);
            this.groupPanelBasic.Controls.Add(factorTypeLabel);
            this.groupPanelBasic.Controls.Add(this.factorTypeComboBox);
            this.groupPanelBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelBasic.Location = new System.Drawing.Point(1, 1);
            this.groupPanelBasic.Name = "groupPanelBasic";
            this.groupPanelBasic.Size = new System.Drawing.Size(600, 251);
            // 
            // 
            // 
            this.groupPanelBasic.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelBasic.Style.BackColorGradientAngle = 90;
            this.groupPanelBasic.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelBasic.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBasic.Style.BorderBottomWidth = 1;
            this.groupPanelBasic.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelBasic.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBasic.Style.BorderLeftWidth = 1;
            this.groupPanelBasic.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBasic.Style.BorderRightWidth = 1;
            this.groupPanelBasic.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBasic.Style.BorderTopWidth = 1;
            this.groupPanelBasic.Style.Class = "";
            this.groupPanelBasic.Style.CornerDiameter = 4;
            this.groupPanelBasic.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelBasic.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelBasic.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelBasic.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelBasic.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelBasic.StyleMouseOver.Class = "";
            this.groupPanelBasic.TabIndex = 0;
            // 
            // tbFactorGroupName
            // 
            // 
            // 
            // 
            this.tbFactorGroupName.Border.Class = "TextBoxBorder";
            this.tbFactorGroupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "FactorGroup.CompanyNameEN", true));
            this.tbFactorGroupName.Location = new System.Drawing.Point(409, 223);
            this.tbFactorGroupName.Name = "tbFactorGroupName";
            this.tbFactorGroupName.Size = new System.Drawing.Size(175, 20);
            this.tbFactorGroupName.TabIndex = 42;
            // 
            // btnGroupSelect
            // 
            this.btnGroupSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGroupSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGroupSelect.Location = new System.Drawing.Point(560, 199);
            this.btnGroupSelect.Name = "btnGroupSelect";
            this.btnGroupSelect.Size = new System.Drawing.Size(24, 23);
            this.btnGroupSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGroupSelect.TabIndex = 41;
            this.btnGroupSelect.Text = "...";
            this.btnGroupSelect.Click += new System.EventHandler(this.SelectGroup);
            // 
            // tbGroupFactorCode
            // 
            // 
            // 
            // 
            this.tbGroupFactorCode.Border.Class = "TextBoxBorder";
            this.tbGroupFactorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "FactorGroup.FactorCode", true));
            this.tbGroupFactorCode.Location = new System.Drawing.Point(408, 201);
            this.tbGroupFactorCode.Name = "tbGroupFactorCode";
            this.tbGroupFactorCode.Size = new System.Drawing.Size(102, 20);
            this.tbGroupFactorCode.TabIndex = 38;
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "CreateUserName", true));
            this.tbCreateUserName.Location = new System.Drawing.Point(82, 199);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.ReadOnly = true;
            this.tbCreateUserName.Size = new System.Drawing.Size(193, 20);
            this.tbCreateUserName.TabIndex = 36;
            // 
            // companyNameCNTextBox
            // 
            // 
            // 
            // 
            this.companyNameCNTextBox.Border.Class = "TextBoxBorder";
            this.companyNameCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "CompanyNameCN", true));
            this.companyNameCNTextBox.Location = new System.Drawing.Point(82, 29);
            this.companyNameCNTextBox.Name = "companyNameCNTextBox";
            this.companyNameCNTextBox.Size = new System.Drawing.Size(150, 20);
            this.companyNameCNTextBox.TabIndex = 7;
            this.companyNameCNTextBox.WatermarkText = "中文";
            // 
            // telefax_2TextBox
            // 
            // 
            // 
            // 
            this.telefax_2TextBox.Border.Class = "TextBoxBorder";
            this.telefax_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telefax_2", true));
            this.telefax_2TextBox.Location = new System.Drawing.Point(409, 179);
            this.telefax_2TextBox.Name = "telefax_2TextBox";
            this.telefax_2TextBox.Size = new System.Drawing.Size(175, 20);
            this.telefax_2TextBox.TabIndex = 34;
            this.telefax_2TextBox.WatermarkText = "Telefax 2";
            // 
            // telefax_1TextBox
            // 
            // 
            // 
            // 
            this.telefax_1TextBox.Border.Class = "TextBoxBorder";
            this.telefax_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telefax_1", true));
            this.telefax_1TextBox.Location = new System.Drawing.Point(409, 158);
            this.telefax_1TextBox.Name = "telefax_1TextBox";
            this.telefax_1TextBox.Size = new System.Drawing.Size(175, 20);
            this.telefax_1TextBox.TabIndex = 33;
            this.telefax_1TextBox.WatermarkText = "Telefax 1";
            // 
            // telephone_2TextBox
            // 
            // 
            // 
            // 
            this.telephone_2TextBox.Border.Class = "TextBoxBorder";
            this.telephone_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telephone_2", true));
            this.telephone_2TextBox.Location = new System.Drawing.Point(82, 178);
            this.telephone_2TextBox.Name = "telephone_2TextBox";
            this.telephone_2TextBox.Size = new System.Drawing.Size(193, 20);
            this.telephone_2TextBox.TabIndex = 31;
            this.telephone_2TextBox.WatermarkText = "Telephone 2";
            // 
            // telephone_1TextBox
            // 
            // 
            // 
            // 
            this.telephone_1TextBox.Border.Class = "TextBoxBorder";
            this.telephone_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telephone_1", true));
            this.telephone_1TextBox.Location = new System.Drawing.Point(82, 157);
            this.telephone_1TextBox.Name = "telephone_1TextBox";
            this.telephone_1TextBox.Size = new System.Drawing.Size(193, 20);
            this.telephone_1TextBox.TabIndex = 30;
            this.telephone_1TextBox.WatermarkText = "Telephone 1";
            // 
            // webSiteTextBox
            // 
            // 
            // 
            // 
            this.webSiteTextBox.Border.Class = "TextBoxBorder";
            this.webSiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "WebSite", true));
            this.webSiteTextBox.Location = new System.Drawing.Point(409, 136);
            this.webSiteTextBox.Name = "webSiteTextBox";
            this.webSiteTextBox.Size = new System.Drawing.Size(175, 20);
            this.webSiteTextBox.TabIndex = 28;
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.Border.Class = "TextBoxBorder";
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(82, 135);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(193, 20);
            this.emailTextBox.TabIndex = 26;
            // 
            // cityVisitingTextBox
            // 
            // 
            // 
            // 
            this.cityVisitingTextBox.Border.Class = "TextBoxBorder";
            this.cityVisitingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "CityVisiting", true));
            this.cityVisitingTextBox.Location = new System.Drawing.Point(409, 115);
            this.cityVisitingTextBox.Name = "cityVisitingTextBox";
            this.cityVisitingTextBox.Size = new System.Drawing.Size(175, 20);
            this.cityVisitingTextBox.TabIndex = 24;
            // 
            // postalCodeVisitingTextBox
            // 
            // 
            // 
            // 
            this.postalCodeVisitingTextBox.Border.Class = "TextBoxBorder";
            this.postalCodeVisitingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "PostalCodeVisiting", true));
            this.postalCodeVisitingTextBox.Location = new System.Drawing.Point(409, 94);
            this.postalCodeVisitingTextBox.Name = "postalCodeVisitingTextBox";
            this.postalCodeVisitingTextBox.Size = new System.Drawing.Size(175, 20);
            this.postalCodeVisitingTextBox.TabIndex = 20;
            // 
            // visitingAddress_2TextBox
            // 
            // 
            // 
            // 
            this.visitingAddress_2TextBox.Border.Class = "TextBoxBorder";
            this.visitingAddress_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "VisitingAddress_2", true));
            this.visitingAddress_2TextBox.Location = new System.Drawing.Point(409, 72);
            this.visitingAddress_2TextBox.Name = "visitingAddress_2TextBox";
            this.visitingAddress_2TextBox.Size = new System.Drawing.Size(175, 20);
            this.visitingAddress_2TextBox.TabIndex = 16;
            this.visitingAddress_2TextBox.WatermarkText = "Visiting Address, continued";
            // 
            // visitingAddress_1TextBox
            // 
            // 
            // 
            // 
            this.visitingAddress_1TextBox.Border.Class = "TextBoxBorder";
            this.visitingAddress_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "VisitingAddress_1", true));
            this.visitingAddress_1TextBox.Location = new System.Drawing.Point(409, 50);
            this.visitingAddress_1TextBox.Name = "visitingAddress_1TextBox";
            this.visitingAddress_1TextBox.Size = new System.Drawing.Size(175, 20);
            this.visitingAddress_1TextBox.TabIndex = 15;
            this.visitingAddress_1TextBox.WatermarkText = "Visiting Address";
            // 
            // cityPostTextBox
            // 
            // 
            // 
            // 
            this.cityPostTextBox.Border.Class = "TextBoxBorder";
            this.cityPostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "CityPost", true));
            this.cityPostTextBox.Location = new System.Drawing.Point(82, 114);
            this.cityPostTextBox.Name = "cityPostTextBox";
            this.cityPostTextBox.Size = new System.Drawing.Size(193, 20);
            this.cityPostTextBox.TabIndex = 22;
            // 
            // postalCodePostTextBox
            // 
            // 
            // 
            // 
            this.postalCodePostTextBox.Border.Class = "TextBoxBorder";
            this.postalCodePostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "PostalCodePost", true));
            this.postalCodePostTextBox.Location = new System.Drawing.Point(82, 93);
            this.postalCodePostTextBox.Name = "postalCodePostTextBox";
            this.postalCodePostTextBox.Size = new System.Drawing.Size(193, 20);
            this.postalCodePostTextBox.TabIndex = 18;
            // 
            // postalAddress_2TextBox
            // 
            // 
            // 
            // 
            this.postalAddress_2TextBox.Border.Class = "TextBoxBorder";
            this.postalAddress_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "PostalAddress_2", true));
            this.postalAddress_2TextBox.Location = new System.Drawing.Point(82, 72);
            this.postalAddress_2TextBox.Name = "postalAddress_2TextBox";
            this.postalAddress_2TextBox.Size = new System.Drawing.Size(193, 20);
            this.postalAddress_2TextBox.TabIndex = 13;
            this.postalAddress_2TextBox.WatermarkText = "Postal Address, continued";
            // 
            // postalAddress_1TextBox
            // 
            // 
            // 
            // 
            this.postalAddress_1TextBox.Border.Class = "TextBoxBorder";
            this.postalAddress_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "PostalAddress_1", true));
            this.postalAddress_1TextBox.Location = new System.Drawing.Point(82, 50);
            this.postalAddress_1TextBox.Name = "postalAddress_1TextBox";
            this.postalAddress_1TextBox.Size = new System.Drawing.Size(193, 20);
            this.postalAddress_1TextBox.TabIndex = 12;
            this.postalAddress_1TextBox.WatermarkText = "Postal Address";
            // 
            // departmentTextBox
            // 
            // 
            // 
            // 
            this.departmentTextBox.Border.Class = "TextBoxBorder";
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(481, 27);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(103, 20);
            this.departmentTextBox.TabIndex = 10;
            // 
            // companyNameENTextBox
            // 
            // 
            // 
            // 
            this.companyNameENTextBox.Border.Class = "TextBoxBorder";
            this.companyNameENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "CompanyNameEN", true));
            this.companyNameENTextBox.Location = new System.Drawing.Point(241, 29);
            this.companyNameENTextBox.Name = "companyNameENTextBox";
            this.companyNameENTextBox.Size = new System.Drawing.Size(150, 20);
            this.companyNameENTextBox.TabIndex = 8;
            this.companyNameENTextBox.WatermarkText = "英文";
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "FactorCode", true));
            this.factorCodeTextBox.Location = new System.Drawing.Point(285, 6);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.factorCodeTextBox.TabIndex = 3;
            // 
            // countryNameComboBox
            // 
            this.countryNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factorBindingSource, "CountryName", true));
            this.countryNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.countryNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryNameComboBox.FormattingEnabled = true;
            this.countryNameComboBox.Location = new System.Drawing.Point(444, 5);
            this.countryNameComboBox.Name = "countryNameComboBox";
            this.countryNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.countryNameComboBox.TabIndex = 5;
            // 
            // factorTypeComboBox
            // 
            this.factorTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "FactorType", true));
            this.factorTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.factorTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.factorTypeComboBox.FormattingEnabled = true;
            this.factorTypeComboBox.Items.AddRange(new object[] {
            "保理商",
            "保险公司",
            "监管机构",
            "代付行"});
            this.factorTypeComboBox.Location = new System.Drawing.Point(82, 5);
            this.factorTypeComboBox.MaxDropDownItems = 4;
            this.factorTypeComboBox.Name = "factorTypeComboBox";
            this.factorTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.factorTypeComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.factorTypeComboBox.TabIndex = 1;
            // 
            // tabItemFactor
            // 
            this.tabItemFactor.AttachedControl = this.tabPanelFactor;
            this.tabItemFactor.Name = "tabItemFactor";
            this.tabItemFactor.Text = "基本信息";
            // 
            // tabPanelAgreement
            // 
            this.tabPanelAgreement.Controls.Add(this.dgvAgreements);
            this.tabPanelAgreement.Controls.Add(this.groupPanelAgreementDetail);
            this.tabPanelAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelAgreement.Location = new System.Drawing.Point(0, 26);
            this.tabPanelAgreement.Name = "tabPanelAgreement";
            this.tabPanelAgreement.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelAgreement.Size = new System.Drawing.Size(602, 606);
            this.tabPanelAgreement.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelAgreement.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelAgreement.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelAgreement.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelAgreement.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelAgreement.Style.GradientAngle = 90;
            this.tabPanelAgreement.TabIndex = 3;
            this.tabPanelAgreement.TabItem = this.tabItemAgreement;
            // 
            // dgvAgreements
            // 
            this.dgvAgreements.AllowUserToAddRows = false;
            this.dgvAgreements.AllowUserToDeleteRows = false;
            this.dgvAgreements.AllowUserToOrderColumns = true;
            this.dgvAgreements.AutoGenerateColumns = false;
            this.dgvAgreements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgreements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvAgreements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgreements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAgreementSignDate,
            this.colAgreementComment});
            this.dgvAgreements.DataSource = this.factorCreditLineBindingSource;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgreements.DefaultCellStyle = dataGridViewCellStyle37;
            this.dgvAgreements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgreements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAgreements.Location = new System.Drawing.Point(1, 320);
            this.dgvAgreements.Name = "dgvAgreements";
            this.dgvAgreements.ReadOnly = true;
            this.dgvAgreements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgreements.Size = new System.Drawing.Size(600, 285);
            this.dgvAgreements.TabIndex = 2;
            this.dgvAgreements.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectAgreement);
            // 
            // factorCreditLineBindingSource
            // 
            this.factorCreditLineBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.FactorCreditLine);
            // 
            // groupPanelAgreementDetail
            // 
            this.groupPanelAgreementDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelAgreementDetail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelAgreementDetail.Controls.Add(labelX1);
            this.groupPanelAgreementDetail.Controls.Add(this.tbAgreementCreateUserName);
            this.groupPanelAgreementDetail.Controls.Add(this.btnAgreementUpdate);
            this.groupPanelAgreementDetail.Controls.Add(this.btnAgreementRefresh);
            this.groupPanelAgreementDetail.Controls.Add(this.btnAgreementDelete);
            this.groupPanelAgreementDetail.Controls.Add(this.btnAgreementSave);
            this.groupPanelAgreementDetail.Controls.Add(this.btnAgreementNew);
            this.groupPanelAgreementDetail.Controls.Add(lblAgreementComment);
            this.groupPanelAgreementDetail.Controls.Add(this.tbAgreementComment);
            this.groupPanelAgreementDetail.Controls.Add(this.diSignDate);
            this.groupPanelAgreementDetail.Controls.Add(lblSignDate);
            this.groupPanelAgreementDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelAgreementDetail.Location = new System.Drawing.Point(1, 1);
            this.groupPanelAgreementDetail.Name = "groupPanelAgreementDetail";
            this.groupPanelAgreementDetail.Size = new System.Drawing.Size(600, 319);
            // 
            // 
            // 
            this.groupPanelAgreementDetail.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelAgreementDetail.Style.BackColorGradientAngle = 90;
            this.groupPanelAgreementDetail.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelAgreementDetail.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAgreementDetail.Style.BorderBottomWidth = 1;
            this.groupPanelAgreementDetail.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelAgreementDetail.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAgreementDetail.Style.BorderLeftWidth = 1;
            this.groupPanelAgreementDetail.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAgreementDetail.Style.BorderRightWidth = 1;
            this.groupPanelAgreementDetail.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelAgreementDetail.Style.BorderTopWidth = 1;
            this.groupPanelAgreementDetail.Style.Class = "";
            this.groupPanelAgreementDetail.Style.CornerDiameter = 4;
            this.groupPanelAgreementDetail.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelAgreementDetail.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelAgreementDetail.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelAgreementDetail.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelAgreementDetail.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelAgreementDetail.StyleMouseOver.Class = "";
            this.groupPanelAgreementDetail.TabIndex = 1;
            // 
            // tbAgreementCreateUserName
            // 
            // 
            // 
            // 
            this.tbAgreementCreateUserName.Border.Class = "TextBoxBorder";
            this.tbAgreementCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agreementBindingSource, "CreateUserName", true));
            this.tbAgreementCreateUserName.Location = new System.Drawing.Point(304, 12);
            this.tbAgreementCreateUserName.Name = "tbAgreementCreateUserName";
            this.tbAgreementCreateUserName.ReadOnly = true;
            this.tbAgreementCreateUserName.Size = new System.Drawing.Size(120, 20);
            this.tbAgreementCreateUserName.TabIndex = 37;
            // 
            // agreementBindingSource
            // 
            this.agreementBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Agreement);
            // 
            // btnAgreementUpdate
            // 
            this.btnAgreementUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgreementUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgreementUpdate.Location = new System.Drawing.Point(267, 275);
            this.btnAgreementUpdate.Name = "btnAgreementUpdate";
            this.btnAgreementUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAgreementUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgreementUpdate.TabIndex = 29;
            this.btnAgreementUpdate.Text = "编辑";
            this.btnAgreementUpdate.Click += new System.EventHandler(this.UpdateAgreement);
            // 
            // btnAgreementRefresh
            // 
            this.btnAgreementRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgreementRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgreementRefresh.Location = new System.Drawing.Point(105, 275);
            this.btnAgreementRefresh.Name = "btnAgreementRefresh";
            this.btnAgreementRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnAgreementRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgreementRefresh.TabIndex = 27;
            this.btnAgreementRefresh.Text = "刷新";
            this.btnAgreementRefresh.Click += new System.EventHandler(this.RefreshAgreements);
            // 
            // btnAgreementDelete
            // 
            this.btnAgreementDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgreementDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgreementDelete.Location = new System.Drawing.Point(429, 275);
            this.btnAgreementDelete.Name = "btnAgreementDelete";
            this.btnAgreementDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAgreementDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgreementDelete.TabIndex = 31;
            this.btnAgreementDelete.Text = "删除";
            this.btnAgreementDelete.Click += new System.EventHandler(this.DeleteAgreement);
            // 
            // btnAgreementSave
            // 
            this.btnAgreementSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgreementSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgreementSave.Location = new System.Drawing.Point(348, 275);
            this.btnAgreementSave.Name = "btnAgreementSave";
            this.btnAgreementSave.Size = new System.Drawing.Size(75, 23);
            this.btnAgreementSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgreementSave.TabIndex = 30;
            this.btnAgreementSave.Text = "保存";
            this.btnAgreementSave.Click += new System.EventHandler(this.SaveAgreement);
            // 
            // btnAgreementNew
            // 
            this.btnAgreementNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgreementNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgreementNew.Location = new System.Drawing.Point(186, 275);
            this.btnAgreementNew.Name = "btnAgreementNew";
            this.btnAgreementNew.Size = new System.Drawing.Size(75, 23);
            this.btnAgreementNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgreementNew.TabIndex = 28;
            this.btnAgreementNew.Text = "新建";
            this.btnAgreementNew.Click += new System.EventHandler(this.NewAgreement);
            // 
            // tbAgreementComment
            // 
            // 
            // 
            // 
            this.tbAgreementComment.Border.Class = "TextBoxBorder";
            this.tbAgreementComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agreementBindingSource, "Comment", true));
            this.tbAgreementComment.Location = new System.Drawing.Point(88, 43);
            this.tbAgreementComment.Multiline = true;
            this.tbAgreementComment.Name = "tbAgreementComment";
            this.tbAgreementComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAgreementComment.Size = new System.Drawing.Size(458, 208);
            this.tbAgreementComment.TabIndex = 14;
            // 
            // diSignDate
            // 
            // 
            // 
            // 
            this.diSignDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diSignDate.ButtonDropDown.Visible = true;
            this.diSignDate.ButtonFreeText.Checked = true;
            this.diSignDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agreementBindingSource, "SignDate", true));
            this.diSignDate.FreeTextEntryMode = true;
            this.diSignDate.Location = new System.Drawing.Point(90, 12);
            // 
            // 
            // 
            this.diSignDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diSignDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diSignDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diSignDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diSignDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diSignDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diSignDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diSignDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diSignDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diSignDate.Name = "diSignDate";
            this.diSignDate.Size = new System.Drawing.Size(121, 20);
            this.diSignDate.TabIndex = 4;
            this.agreementValidator.SetValidator1(this.diSignDate, this.requiredFieldValidator1);
            // 
            // tabItemAgreement
            // 
            this.tabItemAgreement.AttachedControl = this.tabPanelAgreement;
            this.tabItemAgreement.Name = "tabItemAgreement";
            this.tabItemAgreement.Text = "合同信息";
            // 
            // tabPanelCreditLine
            // 
            this.tabPanelCreditLine.AutoScroll = true;
            this.tabPanelCreditLine.Controls.Add(this.dgvFactorCreditLines);
            this.tabPanelCreditLine.Controls.Add(this.groupPanelCreditLineDetail);
            this.tabPanelCreditLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCreditLine.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCreditLine.Name = "tabPanelCreditLine";
            this.tabPanelCreditLine.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCreditLine.Size = new System.Drawing.Size(602, 606);
            this.tabPanelCreditLine.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelCreditLine.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelCreditLine.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelCreditLine.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelCreditLine.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelCreditLine.Style.GradientAngle = 90;
            this.tabPanelCreditLine.TabIndex = 2;
            this.tabPanelCreditLine.TabItem = this.tabItemFactorCreditLine;
            // 
            // dgvFactorCreditLines
            // 
            this.dgvFactorCreditLines.AllowUserToAddRows = false;
            this.dgvFactorCreditLines.AllowUserToDeleteRows = false;
            this.dgvFactorCreditLines.AllowUserToOrderColumns = true;
            this.dgvFactorCreditLines.AutoGenerateColumns = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactorCreditLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvFactorCreditLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactorCreditLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCreditLineID,
            this.colCreditLineCurrency,
            this.colCreditLine,
            this.colPeriodBegin,
            this.colPeriodEnd,
            this.colApproveNo,
            this.colCreditLineStatus,
            this.colFreezeReason,
            this.colFreezer,
            this.colFreezeDate,
            this.colUnfreezeReason,
            this.colUnfreezer,
            this.colUnfreezeDate,
            this.colComment});
            this.dgvFactorCreditLines.DataSource = this.factorCreditLineBindingSource;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactorCreditLines.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvFactorCreditLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactorCreditLines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFactorCreditLines.Location = new System.Drawing.Point(1, 320);
            this.dgvFactorCreditLines.Name = "dgvFactorCreditLines";
            this.dgvFactorCreditLines.ReadOnly = true;
            this.dgvFactorCreditLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactorCreditLines.Size = new System.Drawing.Size(600, 285);
            this.dgvFactorCreditLines.TabIndex = 0;
            this.dgvFactorCreditLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectFactorCreditLine);
            // 
            // groupPanelCreditLineDetail
            // 
            this.groupPanelCreditLineDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCreditLineDetail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelCreditLineDetail.Controls.Add(lblCreditLineCreateUserName);
            this.groupPanelCreditLineDetail.Controls.Add(this.tbCreditLineCreateUserName);
            this.groupPanelCreditLineDetail.Controls.Add(this.btnFactorCreditLineUpdate);
            this.groupPanelCreditLineDetail.Controls.Add(this.btnFactorCreditLineRefresh);
            this.groupPanelCreditLineDetail.Controls.Add(this.btnFactorCreditLineUnfreeze);
            this.groupPanelCreditLineDetail.Controls.Add(this.btnFactorCreditLineFreeze);
            this.groupPanelCreditLineDetail.Controls.Add(this.btnFactorCreditLineDelete);
            this.groupPanelCreditLineDetail.Controls.Add(this.btnFactorCreditLineSave);
            this.groupPanelCreditLineDetail.Controls.Add(this.btnFactorCreditLineNew);
            this.groupPanelCreditLineDetail.Controls.Add(unfreezeDateLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.unfreezeDateDateTimePicker);
            this.groupPanelCreditLineDetail.Controls.Add(unfreezerLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.unfreezerTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(unfreezeReasonLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.unfreezeReasonTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(freezeDateLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.freezeDateDateTimePicker);
            this.groupPanelCreditLineDetail.Controls.Add(freezerLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.freezerTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(freezeReasonLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.freezeReasonTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(commentLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.commentTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(approveNoLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.approveNoTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(creditLineStatusLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.creditLineStatusTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(this.periodEndDateTimePicker);
            this.groupPanelCreditLineDetail.Controls.Add(periodBeginLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.periodBeginDateTimePicker);
            this.groupPanelCreditLineDetail.Controls.Add(creditLineLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.creditLineTextBox);
            this.groupPanelCreditLineDetail.Controls.Add(creditLineCurrencyLabel);
            this.groupPanelCreditLineDetail.Controls.Add(this.creditLineCurrencyComboBox);
            this.groupPanelCreditLineDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditLineDetail.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCreditLineDetail.Name = "groupPanelCreditLineDetail";
            this.groupPanelCreditLineDetail.Size = new System.Drawing.Size(600, 319);
            // 
            // 
            // 
            this.groupPanelCreditLineDetail.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelCreditLineDetail.Style.BackColorGradientAngle = 90;
            this.groupPanelCreditLineDetail.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelCreditLineDetail.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditLineDetail.Style.BorderBottomWidth = 1;
            this.groupPanelCreditLineDetail.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelCreditLineDetail.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditLineDetail.Style.BorderLeftWidth = 1;
            this.groupPanelCreditLineDetail.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditLineDetail.Style.BorderRightWidth = 1;
            this.groupPanelCreditLineDetail.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditLineDetail.Style.BorderTopWidth = 1;
            this.groupPanelCreditLineDetail.Style.Class = "";
            this.groupPanelCreditLineDetail.Style.CornerDiameter = 4;
            this.groupPanelCreditLineDetail.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCreditLineDetail.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCreditLineDetail.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCreditLineDetail.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCreditLineDetail.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelCreditLineDetail.StyleMouseOver.Class = "";
            this.groupPanelCreditLineDetail.TabIndex = 0;
            // 
            // tbCreditLineCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreditLineCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreditLineCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "CreateUserName", true));
            this.tbCreditLineCreateUserName.Location = new System.Drawing.Point(90, 111);
            this.tbCreditLineCreateUserName.Name = "tbCreditLineCreateUserName";
            this.tbCreditLineCreateUserName.ReadOnly = true;
            this.tbCreditLineCreateUserName.Size = new System.Drawing.Size(120, 20);
            this.tbCreditLineCreateUserName.TabIndex = 35;
            // 
            // btnFactorCreditLineUpdate
            // 
            this.btnFactorCreditLineUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorCreditLineUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorCreditLineUpdate.Location = new System.Drawing.Point(171, 271);
            this.btnFactorCreditLineUpdate.Name = "btnFactorCreditLineUpdate";
            this.btnFactorCreditLineUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnFactorCreditLineUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorCreditLineUpdate.TabIndex = 29;
            this.btnFactorCreditLineUpdate.Text = "编辑";
            this.btnFactorCreditLineUpdate.Click += new System.EventHandler(this.UpdateFactorCreditLine);
            // 
            // btnFactorCreditLineRefresh
            // 
            this.btnFactorCreditLineRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorCreditLineRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorCreditLineRefresh.Location = new System.Drawing.Point(9, 271);
            this.btnFactorCreditLineRefresh.Name = "btnFactorCreditLineRefresh";
            this.btnFactorCreditLineRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnFactorCreditLineRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorCreditLineRefresh.TabIndex = 27;
            this.btnFactorCreditLineRefresh.Text = "刷新";
            this.btnFactorCreditLineRefresh.Click += new System.EventHandler(this.RefreshFactorCreditLine);
            // 
            // btnFactorCreditLineUnfreeze
            // 
            this.btnFactorCreditLineUnfreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorCreditLineUnfreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorCreditLineUnfreeze.Location = new System.Drawing.Point(495, 271);
            this.btnFactorCreditLineUnfreeze.Name = "btnFactorCreditLineUnfreeze";
            this.btnFactorCreditLineUnfreeze.Size = new System.Drawing.Size(75, 23);
            this.btnFactorCreditLineUnfreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorCreditLineUnfreeze.TabIndex = 33;
            this.btnFactorCreditLineUnfreeze.Text = "解冻";
            this.btnFactorCreditLineUnfreeze.Click += new System.EventHandler(this.UnfreezeFactorCreditLine);
            // 
            // btnFactorCreditLineFreeze
            // 
            this.btnFactorCreditLineFreeze.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorCreditLineFreeze.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorCreditLineFreeze.Location = new System.Drawing.Point(414, 271);
            this.btnFactorCreditLineFreeze.Name = "btnFactorCreditLineFreeze";
            this.btnFactorCreditLineFreeze.Size = new System.Drawing.Size(75, 23);
            this.btnFactorCreditLineFreeze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorCreditLineFreeze.TabIndex = 32;
            this.btnFactorCreditLineFreeze.Text = "冻结";
            this.btnFactorCreditLineFreeze.Click += new System.EventHandler(this.FreezeFactorCreditLine);
            // 
            // btnFactorCreditLineDelete
            // 
            this.btnFactorCreditLineDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorCreditLineDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorCreditLineDelete.Location = new System.Drawing.Point(333, 271);
            this.btnFactorCreditLineDelete.Name = "btnFactorCreditLineDelete";
            this.btnFactorCreditLineDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFactorCreditLineDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorCreditLineDelete.TabIndex = 31;
            this.btnFactorCreditLineDelete.Text = "删除";
            this.btnFactorCreditLineDelete.Click += new System.EventHandler(this.DeleteFactorCreditLine);
            // 
            // btnFactorCreditLineSave
            // 
            this.btnFactorCreditLineSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorCreditLineSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorCreditLineSave.Location = new System.Drawing.Point(252, 271);
            this.btnFactorCreditLineSave.Name = "btnFactorCreditLineSave";
            this.btnFactorCreditLineSave.Size = new System.Drawing.Size(75, 23);
            this.btnFactorCreditLineSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorCreditLineSave.TabIndex = 30;
            this.btnFactorCreditLineSave.Text = "保存";
            this.btnFactorCreditLineSave.Click += new System.EventHandler(this.SaveFactorCreditLine);
            // 
            // btnFactorCreditLineNew
            // 
            this.btnFactorCreditLineNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorCreditLineNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorCreditLineNew.Location = new System.Drawing.Point(90, 271);
            this.btnFactorCreditLineNew.Name = "btnFactorCreditLineNew";
            this.btnFactorCreditLineNew.Size = new System.Drawing.Size(75, 23);
            this.btnFactorCreditLineNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorCreditLineNew.TabIndex = 28;
            this.btnFactorCreditLineNew.Text = "新建";
            this.btnFactorCreditLineNew.Click += new System.EventHandler(this.NewFactorCreditLine);
            // 
            // unfreezeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.unfreezeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.unfreezeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.unfreezeDateDateTimePicker.ButtonFreeText.Checked = true;
            this.unfreezeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factorCreditLineBindingSource, "UnfreezeDate", true));
            this.unfreezeDateDateTimePicker.FreeTextEntryMode = true;
            this.unfreezeDateDateTimePicker.Location = new System.Drawing.Point(297, 236);
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
            this.unfreezeDateDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.unfreezeDateDateTimePicker.TabIndex = 26;
            // 
            // unfreezerTextBox
            // 
            // 
            // 
            // 
            this.unfreezerTextBox.Border.Class = "TextBoxBorder";
            this.unfreezerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "Unfreezer", true));
            this.unfreezerTextBox.Location = new System.Drawing.Point(88, 236);
            this.unfreezerTextBox.Name = "unfreezerTextBox";
            this.unfreezerTextBox.ReadOnly = true;
            this.unfreezerTextBox.Size = new System.Drawing.Size(103, 20);
            this.unfreezerTextBox.TabIndex = 24;
            // 
            // unfreezeReasonTextBox
            // 
            // 
            // 
            // 
            this.unfreezeReasonTextBox.Border.Class = "TextBoxBorder";
            this.unfreezeReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "UnfreezeReason", true));
            this.unfreezeReasonTextBox.Location = new System.Drawing.Point(88, 196);
            this.unfreezeReasonTextBox.Multiline = true;
            this.unfreezeReasonTextBox.Name = "unfreezeReasonTextBox";
            this.unfreezeReasonTextBox.ReadOnly = true;
            this.unfreezeReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.unfreezeReasonTextBox.Size = new System.Drawing.Size(460, 38);
            this.unfreezeReasonTextBox.TabIndex = 22;
            this.creditLineValidator.SetValidator1(this.unfreezeReasonTextBox, this.customValidator2);
            // 
            // freezeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.freezeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.freezeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.freezeDateDateTimePicker.ButtonFreeText.Checked = true;
            this.freezeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factorCreditLineBindingSource, "FreezeDate", true));
            this.freezeDateDateTimePicker.FreeTextEntryMode = true;
            this.freezeDateDateTimePicker.Location = new System.Drawing.Point(297, 174);
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
            this.freezeDateDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.freezeDateDateTimePicker.TabIndex = 20;
            // 
            // freezerTextBox
            // 
            // 
            // 
            // 
            this.freezerTextBox.Border.Class = "TextBoxBorder";
            this.freezerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "Freezer", true));
            this.freezerTextBox.Location = new System.Drawing.Point(90, 174);
            this.freezerTextBox.Name = "freezerTextBox";
            this.freezerTextBox.ReadOnly = true;
            this.freezerTextBox.Size = new System.Drawing.Size(100, 20);
            this.freezerTextBox.TabIndex = 18;
            // 
            // freezeReasonTextBox
            // 
            // 
            // 
            // 
            this.freezeReasonTextBox.Border.Class = "TextBoxBorder";
            this.freezeReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "FreezeReason", true));
            this.freezeReasonTextBox.Location = new System.Drawing.Point(90, 135);
            this.freezeReasonTextBox.Multiline = true;
            this.freezeReasonTextBox.Name = "freezeReasonTextBox";
            this.freezeReasonTextBox.ReadOnly = true;
            this.freezeReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.freezeReasonTextBox.Size = new System.Drawing.Size(458, 38);
            this.freezeReasonTextBox.TabIndex = 16;
            this.creditLineValidator.SetValidator1(this.freezeReasonTextBox, this.customValidator1);
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(90, 71);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentTextBox.Size = new System.Drawing.Size(458, 38);
            this.commentTextBox.TabIndex = 14;
            // 
            // approveNoTextBox
            // 
            // 
            // 
            // 
            this.approveNoTextBox.Border.Class = "TextBoxBorder";
            this.approveNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "ApproveNo", true));
            this.approveNoTextBox.Location = new System.Drawing.Point(297, 29);
            this.approveNoTextBox.Name = "approveNoTextBox";
            this.approveNoTextBox.Size = new System.Drawing.Size(124, 20);
            this.approveNoTextBox.TabIndex = 8;
            this.creditLineValidator.SetValidator1(this.approveNoTextBox, this.requiredFieldValidator8);
            // 
            // creditLineStatusTextBox
            // 
            // 
            // 
            // 
            this.creditLineStatusTextBox.Border.Class = "TextBoxBorder";
            this.creditLineStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "CreditLineStatus", true));
            this.creditLineStatusTextBox.Location = new System.Drawing.Point(90, 50);
            this.creditLineStatusTextBox.Name = "creditLineStatusTextBox";
            this.creditLineStatusTextBox.ReadOnly = true;
            this.creditLineStatusTextBox.Size = new System.Drawing.Size(120, 20);
            this.creditLineStatusTextBox.TabIndex = 10;
            // 
            // periodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.periodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.periodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.periodEndDateTimePicker.ButtonFreeText.Checked = true;
            this.periodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factorCreditLineBindingSource, "PeriodEnd", true));
            this.periodEndDateTimePicker.FreeTextEntryMode = true;
            this.periodEndDateTimePicker.Location = new System.Drawing.Point(427, 7);
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
            this.periodEndDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.periodEndDateTimePicker.TabIndex = 4;
            this.creditLineValidator.SetValidator1(this.periodEndDateTimePicker, this.requiredFieldValidator6);
            this.creditLineValidator.SetValidator2(this.periodEndDateTimePicker, this.compareValidator1);
            // 
            // periodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.periodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.periodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.periodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.periodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factorCreditLineBindingSource, "PeriodBegin", true));
            this.periodBeginDateTimePicker.FreeTextEntryMode = true;
            this.periodBeginDateTimePicker.Location = new System.Drawing.Point(297, 7);
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
            this.periodBeginDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.periodBeginDateTimePicker.TabIndex = 3;
            this.creditLineValidator.SetValidator1(this.periodBeginDateTimePicker, this.requiredFieldValidator5);
            // 
            // creditLineTextBox
            // 
            // 
            // 
            // 
            this.creditLineTextBox.Border.Class = "TextBoxBorder";
            this.creditLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorCreditLineBindingSource, "CreditLine", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.creditLineTextBox.Location = new System.Drawing.Point(90, 29);
            this.creditLineTextBox.Name = "creditLineTextBox";
            this.creditLineTextBox.Size = new System.Drawing.Size(120, 20);
            this.creditLineTextBox.TabIndex = 6;
            this.creditLineValidator.SetValidator1(this.creditLineTextBox, this.requiredFieldValidator7);
            // 
            // creditLineCurrencyComboBox
            // 
            this.creditLineCurrencyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.creditLineCurrencyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.creditLineCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factorCreditLineBindingSource, "CreditLineCurrency", true));
            this.creditLineCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creditLineCurrencyComboBox.FormattingEnabled = true;
            this.creditLineCurrencyComboBox.Location = new System.Drawing.Point(90, 7);
            this.creditLineCurrencyComboBox.Name = "creditLineCurrencyComboBox";
            this.creditLineCurrencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.creditLineCurrencyComboBox.TabIndex = 1;
            this.creditLineValidator.SetValidator1(this.creditLineCurrencyComboBox, this.requiredFieldValidator4);
            // 
            // tabItemFactorCreditLine
            // 
            this.tabItemFactorCreditLine.AttachedControl = this.tabPanelCreditLine;
            this.tabItemFactorCreditLine.Name = "tabItemFactorCreditLine";
            this.tabItemFactorCreditLine.Text = "额度信息";
            // 
            // factorValidator
            // 
            this.factorValidator.ContainerControl = this;
            this.factorValidator.ErrorProvider = this.errorProvider;
            this.factorValidator.Highlighter = this.highlighter;
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
            // creditLineValidator
            // 
            this.creditLineValidator.ContainerControl = this;
            this.creditLineValidator.ErrorProvider = this.errorProvider;
            this.creditLineValidator.Highlighter = this.highlighter;
            // 
            // customValidator2
            // 
            this.customValidator2.ErrorMessage = "解冻原因不能为空";
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator2.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator2ValidateValue);
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "冻结原因不能为空";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator1ValidateValue);
            // 
            // requiredFieldValidator8
            // 
            this.requiredFieldValidator8.ErrorMessage = "必填";
            this.requiredFieldValidator8.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "必填";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.periodBeginDateTimePicker;
            this.compareValidator1.ErrorMessage = "终止日期应该大于起始日期";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "必填";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.ErrorMessage = "必填";
            this.requiredFieldValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator9
            // 
            this.requiredFieldValidator9.ErrorMessage = "必填";
            this.requiredFieldValidator9.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // agreementValidator
            // 
            this.agreementValidator.ContainerControl = this;
            this.agreementValidator.ErrorProvider = this.errorProvider;
            this.agreementValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // commissionRemitBindingSource
            // 
            this.commissionRemitBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CommissionRemittance);
            // 
            // commissionRemitValidator
            // 
            this.commissionRemitValidator.ErrorProvider = this.errorProvider;
            this.commissionRemitValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator10
            // 
            this.requiredFieldValidator10.ErrorMessage = "必填";
            this.requiredFieldValidator10.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator11
            // 
            this.requiredFieldValidator11.ErrorMessage = "必填";
            this.requiredFieldValidator11.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MsgType";
            this.dataGridViewTextBoxColumn1.HeaderText = "消息类型";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MsgDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "消息日期";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MsgAmount";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle38.Format = "N2";
            dataGridViewCellStyle38.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewTextBoxColumn3.HeaderText = "消息金额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AssignBatchNo";
            dataGridViewCellStyle39.Format = "d";
            dataGridViewCellStyle39.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewTextBoxColumn4.HeaderText = "业务编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 223;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AssignDate";
            this.dataGridViewTextBoxColumn5.FillWeight = 149.2386F;
            this.dataGridViewTextBoxColumn5.HeaderText = "转让日";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 334;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CommissionAmount";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.Format = "N2";
            dataGridViewCellStyle40.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewTextBoxColumn6.HeaderText = "手续费";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SignDate";
            dataGridViewCellStyle41.Format = "d";
            dataGridViewCellStyle41.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewTextBoxColumn7.HeaderText = "签订日";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 223;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comment";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle42.Format = "N2";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewTextBoxColumn8.FillWeight = 149.2386F;
            this.dataGridViewTextBoxColumn8.HeaderText = "备注";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 334;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CreditLineID";
            dataGridViewCellStyle43.Format = "d";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridViewTextBoxColumn9.HeaderText = "CreditLineID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 86;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CreditLineCurrency";
            dataGridViewCellStyle44.Format = "d";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridViewTextBoxColumn10.HeaderText = "额度币种";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CreditLine";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle45.Format = "N2";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridViewTextBoxColumn11.HeaderText = "额度上限";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PeriodBegin";
            dataGridViewCellStyle46.Format = "d";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridViewTextBoxColumn12.HeaderText = "有效期(始)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 86;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PeriodEnd";
            dataGridViewCellStyle47.Format = "d";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridViewTextBoxColumn13.HeaderText = "有效期(终)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 86;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ApproveNo";
            this.dataGridViewTextBoxColumn14.HeaderText = "授信编号";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CreditLineStatus";
            dataGridViewCellStyle48.Format = "d";
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridViewTextBoxColumn15.HeaderText = "额度状态";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "FreezeReason";
            this.dataGridViewTextBoxColumn16.HeaderText = "冻结原因";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 80;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Freezer";
            this.dataGridViewTextBoxColumn17.HeaderText = "冻结人";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 68;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "FreezeDate";
            dataGridViewCellStyle49.Format = "d";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle49;
            this.dataGridViewTextBoxColumn18.HeaderText = "冻结日期";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 80;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "UnfreezeReason";
            this.dataGridViewTextBoxColumn19.HeaderText = "解冻原因";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 80;
            // 
            // colMsgType
            // 
            this.colMsgType.DataPropertyName = "MsgType";
            this.colMsgType.HeaderText = "消息类型";
            this.colMsgType.Name = "colMsgType";
            this.colMsgType.ReadOnly = true;
            // 
            // colMsgDate
            // 
            this.colMsgDate.DataPropertyName = "MsgDate";
            this.colMsgDate.HeaderText = "消息日期";
            this.colMsgDate.Name = "colMsgDate";
            this.colMsgDate.ReadOnly = true;
            // 
            // colMsgAmount
            // 
            this.colMsgAmount.DataPropertyName = "MsgAmount";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = null;
            this.colMsgAmount.DefaultCellStyle = dataGridViewCellStyle26;
            this.colMsgAmount.HeaderText = "消息金额";
            this.colMsgAmount.Name = "colMsgAmount";
            this.colMsgAmount.ReadOnly = true;
            // 
            // colAgreementSignDate
            // 
            this.colAgreementSignDate.DataPropertyName = "SignDate";
            dataGridViewCellStyle36.Format = "d";
            dataGridViewCellStyle36.NullValue = null;
            this.colAgreementSignDate.DefaultCellStyle = dataGridViewCellStyle36;
            this.colAgreementSignDate.HeaderText = "签订日";
            this.colAgreementSignDate.Name = "colAgreementSignDate";
            this.colAgreementSignDate.ReadOnly = true;
            // 
            // colAgreementComment
            // 
            this.colAgreementComment.DataPropertyName = "Comment";
            this.colAgreementComment.FillWeight = 149.2386F;
            this.colAgreementComment.HeaderText = "备注";
            this.colAgreementComment.Name = "colAgreementComment";
            this.colAgreementComment.ReadOnly = true;
            // 
            // colCreditLineID
            // 
            this.colCreditLineID.DataPropertyName = "CreditLineID";
            this.colCreditLineID.HeaderText = "CreditLineID";
            this.colCreditLineID.Name = "colCreditLineID";
            this.colCreditLineID.ReadOnly = true;
            this.colCreditLineID.Visible = false;
            // 
            // colCreditLineCurrency
            // 
            this.colCreditLineCurrency.DataPropertyName = "CreditLineCurrency";
            this.colCreditLineCurrency.HeaderText = "额度币种";
            this.colCreditLineCurrency.Name = "colCreditLineCurrency";
            this.colCreditLineCurrency.ReadOnly = true;
            this.colCreditLineCurrency.Width = 80;
            // 
            // colCreditLine
            // 
            this.colCreditLine.DataPropertyName = "CreditLine";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "N2";
            this.colCreditLine.DefaultCellStyle = dataGridViewCellStyle29;
            this.colCreditLine.HeaderText = "额度上限";
            this.colCreditLine.Name = "colCreditLine";
            this.colCreditLine.ReadOnly = true;
            this.colCreditLine.Width = 80;
            // 
            // colPeriodBegin
            // 
            this.colPeriodBegin.DataPropertyName = "PeriodBegin";
            dataGridViewCellStyle30.Format = "d";
            this.colPeriodBegin.DefaultCellStyle = dataGridViewCellStyle30;
            this.colPeriodBegin.HeaderText = "有效期(始)";
            this.colPeriodBegin.Name = "colPeriodBegin";
            this.colPeriodBegin.ReadOnly = true;
            this.colPeriodBegin.Width = 86;
            // 
            // colPeriodEnd
            // 
            this.colPeriodEnd.DataPropertyName = "PeriodEnd";
            dataGridViewCellStyle31.Format = "d";
            this.colPeriodEnd.DefaultCellStyle = dataGridViewCellStyle31;
            this.colPeriodEnd.HeaderText = "有效期(终)";
            this.colPeriodEnd.Name = "colPeriodEnd";
            this.colPeriodEnd.ReadOnly = true;
            this.colPeriodEnd.Width = 86;
            // 
            // colApproveNo
            // 
            this.colApproveNo.DataPropertyName = "ApproveNo";
            this.colApproveNo.HeaderText = "授信编号";
            this.colApproveNo.Name = "colApproveNo";
            this.colApproveNo.ReadOnly = true;
            this.colApproveNo.Width = 80;
            // 
            // colCreditLineStatus
            // 
            this.colCreditLineStatus.DataPropertyName = "CreditLineStatus";
            this.colCreditLineStatus.HeaderText = "额度状态";
            this.colCreditLineStatus.Name = "colCreditLineStatus";
            this.colCreditLineStatus.ReadOnly = true;
            this.colCreditLineStatus.Width = 80;
            // 
            // colFreezeReason
            // 
            this.colFreezeReason.DataPropertyName = "FreezeReason";
            this.colFreezeReason.HeaderText = "冻结原因";
            this.colFreezeReason.Name = "colFreezeReason";
            this.colFreezeReason.ReadOnly = true;
            this.colFreezeReason.Width = 80;
            // 
            // colFreezer
            // 
            this.colFreezer.DataPropertyName = "Freezer";
            this.colFreezer.HeaderText = "冻结人";
            this.colFreezer.Name = "colFreezer";
            this.colFreezer.ReadOnly = true;
            this.colFreezer.Width = 68;
            // 
            // colFreezeDate
            // 
            this.colFreezeDate.DataPropertyName = "FreezeDate";
            dataGridViewCellStyle32.Format = "d";
            this.colFreezeDate.DefaultCellStyle = dataGridViewCellStyle32;
            this.colFreezeDate.HeaderText = "冻结日期";
            this.colFreezeDate.Name = "colFreezeDate";
            this.colFreezeDate.ReadOnly = true;
            this.colFreezeDate.Width = 80;
            // 
            // colUnfreezeReason
            // 
            this.colUnfreezeReason.DataPropertyName = "UnfreezeReason";
            this.colUnfreezeReason.HeaderText = "解冻原因";
            this.colUnfreezeReason.Name = "colUnfreezeReason";
            this.colUnfreezeReason.ReadOnly = true;
            this.colUnfreezeReason.Width = 80;
            // 
            // colUnfreezer
            // 
            this.colUnfreezer.DataPropertyName = "Unfreezer";
            this.colUnfreezer.HeaderText = "解冻人";
            this.colUnfreezer.Name = "colUnfreezer";
            this.colUnfreezer.ReadOnly = true;
            this.colUnfreezer.Width = 68;
            // 
            // colUnfreezeDate
            // 
            this.colUnfreezeDate.DataPropertyName = "UnfreezeDate";
            dataGridViewCellStyle33.Format = "d";
            this.colUnfreezeDate.DefaultCellStyle = dataGridViewCellStyle33;
            this.colUnfreezeDate.HeaderText = "解冻日期";
            this.colUnfreezeDate.Name = "colUnfreezeDate";
            this.colUnfreezeDate.ReadOnly = true;
            this.colUnfreezeDate.Width = 80;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            this.colComment.Width = 56;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Unfreezer";
            this.dataGridViewTextBoxColumn20.HeaderText = "解冻人";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 68;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "UnfreezeDate";
            dataGridViewCellStyle50.Format = "d";
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle50;
            this.dataGridViewTextBoxColumn21.HeaderText = "解冻日期";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 80;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn22.HeaderText = "备注";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 56;
            // 
            // FactorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 632);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FactorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合作机构详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelCommissionRemit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissionRemit)).EndInit();
            this.groupPanelCommissionRemit.ResumeLayout(false);
            this.groupPanelCommissionRemit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diMsgDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRemitDate)).EndInit();
            this.tabPanelFactor.ResumeLayout(false);
            this.groupPanelMembership.ResumeLayout(false);
            this.groupPanelMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorBindingSource)).EndInit();
            this.groupPanelContacts.ResumeLayout(false);
            this.groupPanelContacts.PerformLayout();
            this.groupPanelBasic.ResumeLayout(false);
            this.groupPanelBasic.PerformLayout();
            this.tabPanelAgreement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorCreditLineBindingSource)).EndInit();
            this.groupPanelAgreementDetail.ResumeLayout(false);
            this.groupPanelAgreementDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diSignDate)).EndInit();
            this.tabPanelCreditLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorCreditLines)).EndInit();
            this.groupPanelCreditLineDetail.ResumeLayout(false);
            this.groupPanelCreditLineDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unfreezeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freezeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBeginDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionRemitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreezeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnfreezeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.SuperValidator agreementValidator;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCommissionRemit;
        private DevComponents.DotNetBar.TabItem tabItemCommissionRemit;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCommissionRemit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCommissionRemit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRemitCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRemitAmount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMsgCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMsgType;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitDelete;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitSave;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitUpdate;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitNew;
        private DevComponents.DotNetBar.ButtonX btnCommissionRemitRefresh;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCommissionCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCommissionComment;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diMsgDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diRemitDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMsgAmount;
        private System.Windows.Forms.BindingSource commissionRemitBindingSource;
        private DevComponents.DotNetBar.Validator.SuperValidator commissionRemitValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMsgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMsgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMsgAmount;
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
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator10;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator11;
    }
}
