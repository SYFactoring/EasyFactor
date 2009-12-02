//-----------------------------------------------------------------------
// <copyright file="ClientDetailUI.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// Client Detail User Interface Designer
    /// </summary>
    public partial class ClientDetailUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ToolStrip tsClientDetail;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelPMName;
            System.Windows.Forms.Label labelBranchID;
            System.Windows.Forms.Label labelResponsibleAgency;
            System.Windows.Forms.Label labelTelephone;
            System.Windows.Forms.Label labelWetsite;
            System.Windows.Forms.Label labelAddressCN;
            System.Windows.Forms.Label labelAddressEN;
            System.Windows.Forms.Label labelCellPhone;
            System.Windows.Forms.Label labelCityCN;
            System.Windows.Forms.Label labelCityEN;
            System.Windows.Forms.Label labelClientNameCN;
            System.Windows.Forms.Label labelClientNameEN_1;
            System.Windows.Forms.Label labelClientNameEN_2;
            System.Windows.Forms.Label labelComment;
            System.Windows.Forms.Label labelCompanyCode;
            System.Windows.Forms.Label labelCompanyRegistrationNumber;
            System.Windows.Forms.Label labelContactName;
            System.Windows.Forms.Label labelCountryCN;
            System.Windows.Forms.Label labelEDINo;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelFaxNumber;
            System.Windows.Forms.Label labelPostCode;
            System.Windows.Forms.Label labelProvinceCN;
            System.Windows.Forms.Label labelProvinceEN;
            System.Windows.Forms.Label labelAccountCurrency;
            System.Windows.Forms.Label labelAccountNo;
            System.Windows.Forms.Label labelAccountType;
            System.Windows.Forms.Label labelBank;
            System.Windows.Forms.Label labelBranch;
            System.Windows.Forms.Label labelAccountComment;
            System.Windows.Forms.Label labelAuthorizationNo;
            System.Windows.Forms.Label labelCreditComment;
            System.Windows.Forms.Label labelCreditLineCurrency;
            System.Windows.Forms.Label labelCreditLineLimit;
            System.Windows.Forms.Label labelCreditLineType;
            System.Windows.Forms.Label labelPeriod;
            System.Windows.Forms.Label periodEndLabel;
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsClientDetail = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.tabClient = new System.Windows.Forms.TabControl();
            this.tabPageClientInfo = new System.Windows.Forms.TabPage();
            this.gbStatistic = new System.Windows.Forms.GroupBox();
            this.tbBranchID = new System.Windows.Forms.TextBox();
            this.tbPMName = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbWetsite = new System.Windows.Forms.TextBox();
            this.tbAddressCN = new System.Windows.Forms.TextBox();
            this.tbAddressEN = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.tbCityCN = new System.Windows.Forms.TextBox();
            this.tbCityEN = new System.Windows.Forms.TextBox();
            this.tbClientNameCN = new System.Windows.Forms.TextBox();
            this.tbClientNameEN1 = new System.Windows.Forms.TextBox();
            this.tbClientNameEN2 = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbCompanyCode = new System.Windows.Forms.TextBox();
            this.tbCompanyRegistrationNumber = new System.Windows.Forms.TextBox();
            this.tbContactName = new System.Windows.Forms.TextBox();
            this.tbCountryCode = new System.Windows.Forms.ComboBox();
            this.tbEDINo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFaxNumber = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbProvinceCN = new System.Windows.Forms.TextBox();
            this.tbProvinceEN = new System.Windows.Forms.TextBox();
            this.tbResponsibleAgency = new System.Windows.Forms.TextBox();
            this.tabPageAccountInfo = new System.Windows.Forms.TabPage();
            this.tbAccountCurrency = new System.Windows.Forms.TextBox();
            this.clientAccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.tbAccountType = new System.Windows.Forms.TextBox();
            this.tbBank = new System.Windows.Forms.TextBox();
            this.tbBranch = new System.Windows.Forms.TextBox();
            this.tbAccountComment = new System.Windows.Forms.TextBox();
            this.dgvClientAccount = new System.Windows.Forms.DataGridView();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDINoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDefaultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCreditInfo = new System.Windows.Forms.TabPage();
            this.tbAuthorizationNo = new System.Windows.Forms.TextBox();
            this.creditLineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCreditComment = new System.Windows.Forms.TextBox();
            this.tbCreditLineCurrency = new System.Windows.Forms.TextBox();
            this.tbCreditLineLimit = new System.Windows.Forms.TextBox();
            this.tbCreditLineType = new System.Windows.Forms.TextBox();
            this.tpPeriodBeginDate = new System.Windows.Forms.DateTimePicker();
            this.tpPeriodEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgvClientCreditLine = new System.Windows.Forms.DataGridView();
            this.creditLineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDINoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLineCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLineLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorizationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            labelPMName = new System.Windows.Forms.Label();
            labelBranchID = new System.Windows.Forms.Label();
            labelResponsibleAgency = new System.Windows.Forms.Label();
            labelTelephone = new System.Windows.Forms.Label();
            labelWetsite = new System.Windows.Forms.Label();
            labelAddressCN = new System.Windows.Forms.Label();
            labelAddressEN = new System.Windows.Forms.Label();
            labelCellPhone = new System.Windows.Forms.Label();
            labelCityCN = new System.Windows.Forms.Label();
            labelCityEN = new System.Windows.Forms.Label();
            labelClientNameCN = new System.Windows.Forms.Label();
            labelClientNameEN_1 = new System.Windows.Forms.Label();
            labelClientNameEN_2 = new System.Windows.Forms.Label();
            labelComment = new System.Windows.Forms.Label();
            labelCompanyCode = new System.Windows.Forms.Label();
            labelCompanyRegistrationNumber = new System.Windows.Forms.Label();
            labelContactName = new System.Windows.Forms.Label();
            labelCountryCN = new System.Windows.Forms.Label();
            labelEDINo = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelFaxNumber = new System.Windows.Forms.Label();
            labelPostCode = new System.Windows.Forms.Label();
            labelProvinceCN = new System.Windows.Forms.Label();
            labelProvinceEN = new System.Windows.Forms.Label();
            labelAccountCurrency = new System.Windows.Forms.Label();
            labelAccountNo = new System.Windows.Forms.Label();
            labelAccountType = new System.Windows.Forms.Label();
            labelBank = new System.Windows.Forms.Label();
            labelBranch = new System.Windows.Forms.Label();
            labelAccountComment = new System.Windows.Forms.Label();
            labelAuthorizationNo = new System.Windows.Forms.Label();
            labelCreditComment = new System.Windows.Forms.Label();
            labelCreditLineCurrency = new System.Windows.Forms.Label();
            labelCreditLineLimit = new System.Windows.Forms.Label();
            labelCreditLineType = new System.Windows.Forms.Label();
            labelPeriod = new System.Windows.Forms.Label();
            periodEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.tsClientDetail.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tabPageClientInfo.SuspendLayout();
            this.gbStatistic.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.tabPageAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource)).BeginInit();
            this.tabPageCreditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditLineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPMName
            // 
            labelPMName.AutoSize = true;
            labelPMName.Location = new System.Drawing.Point(16, 26);
            labelPMName.Name = "labelPMName";
            labelPMName.Size = new System.Drawing.Size(101, 12);
            labelPMName.TabIndex = 84;
            labelPMName.Text = "关联客户经理姓名";
            // 
            // labelBranchID
            // 
            labelBranchID.AutoSize = true;
            labelBranchID.Location = new System.Drawing.Point(16, 55);
            labelBranchID.Name = "labelBranchID";
            labelBranchID.Size = new System.Drawing.Size(53, 12);
            labelBranchID.TabIndex = 85;
            labelBranchID.Text = "所属机构";
            // 
            // labelResponsibleAgency
            // 
            labelResponsibleAgency.AutoSize = true;
            labelResponsibleAgency.Location = new System.Drawing.Point(16, 225);
            labelResponsibleAgency.Name = "labelResponsibleAgency";
            labelResponsibleAgency.Size = new System.Drawing.Size(95, 12);
            labelResponsibleAgency.TabIndex = 91;
            labelResponsibleAgency.Text = "公司法人/负责人";
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Location = new System.Drawing.Point(16, 289);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new System.Drawing.Size(53, 12);
            labelTelephone.TabIndex = 92;
            labelTelephone.Text = "联系电话";
            // 
            // labelWetsite
            // 
            labelWetsite.AutoSize = true;
            labelWetsite.Location = new System.Drawing.Point(16, 257);
            labelWetsite.Name = "labelWetsite";
            labelWetsite.Size = new System.Drawing.Size(53, 12);
            labelWetsite.TabIndex = 94;
            labelWetsite.Text = "公司网址";
            // 
            // labelAddressCN
            // 
            labelAddressCN.AutoSize = true;
            labelAddressCN.Location = new System.Drawing.Point(16, 97);
            labelAddressCN.Name = "labelAddressCN";
            labelAddressCN.Size = new System.Drawing.Size(65, 12);
            labelAddressCN.TabIndex = 47;
            labelAddressCN.Text = "地址(中文)";
            // 
            // labelAddressEN
            // 
            labelAddressEN.AutoSize = true;
            labelAddressEN.Location = new System.Drawing.Point(257, 97);
            labelAddressEN.Name = "labelAddressEN";
            labelAddressEN.Size = new System.Drawing.Size(65, 12);
            labelAddressEN.TabIndex = 49;
            labelAddressEN.Text = "地址(英文)";
            // 
            // labelCellPhone
            // 
            labelCellPhone.AutoSize = true;
            labelCellPhone.Location = new System.Drawing.Point(16, 321);
            labelCellPhone.Name = "labelCellPhone";
            labelCellPhone.Size = new System.Drawing.Size(53, 12);
            labelCellPhone.TabIndex = 53;
            labelCellPhone.Text = "手机号码";
            // 
            // labelCityCN
            // 
            labelCityCN.AutoSize = true;
            labelCityCN.Location = new System.Drawing.Point(16, 129);
            labelCityCN.Name = "labelCityCN";
            labelCityCN.Size = new System.Drawing.Size(65, 12);
            labelCityCN.TabIndex = 55;
            labelCityCN.Text = "城市(中文)";
            // 
            // labelCityEN
            // 
            labelCityEN.AutoSize = true;
            labelCityEN.Location = new System.Drawing.Point(257, 129);
            labelCityEN.Name = "labelCityEN";
            labelCityEN.Size = new System.Drawing.Size(65, 12);
            labelCityEN.TabIndex = 57;
            labelCityEN.Text = "城市(英文)";
            // 
            // labelClientNameCN
            // 
            labelClientNameCN.AutoSize = true;
            labelClientNameCN.Location = new System.Drawing.Point(257, 33);
            labelClientNameCN.Name = "labelClientNameCN";
            labelClientNameCN.Size = new System.Drawing.Size(89, 12);
            labelClientNameCN.TabIndex = 59;
            labelClientNameCN.Text = "客户名称(中文)";
            // 
            // labelClientNameEN_1
            // 
            labelClientNameEN_1.AutoSize = true;
            labelClientNameEN_1.Location = new System.Drawing.Point(16, 65);
            labelClientNameEN_1.Name = "labelClientNameEN_1";
            labelClientNameEN_1.Size = new System.Drawing.Size(101, 12);
            labelClientNameEN_1.TabIndex = 61;
            labelClientNameEN_1.Text = "客户名称(英文) 1";
            // 
            // labelClientNameEN_2
            // 
            labelClientNameEN_2.AutoSize = true;
            labelClientNameEN_2.Location = new System.Drawing.Point(257, 65);
            labelClientNameEN_2.Name = "labelClientNameEN_2";
            labelClientNameEN_2.Size = new System.Drawing.Size(101, 12);
            labelClientNameEN_2.TabIndex = 63;
            labelClientNameEN_2.Text = "客户名称(英文) 2";
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new System.Drawing.Point(16, 385);
            labelComment.Name = "labelComment";
            labelComment.Size = new System.Drawing.Size(29, 12);
            labelComment.TabIndex = 65;
            labelComment.Text = "备注";
            // 
            // labelCompanyCode
            // 
            labelCompanyCode.AutoSize = true;
            labelCompanyCode.Location = new System.Drawing.Point(257, 353);
            labelCompanyCode.Name = "labelCompanyCode";
            labelCompanyCode.Size = new System.Drawing.Size(77, 12);
            labelCompanyCode.TabIndex = 67;
            labelCompanyCode.Text = "组织机构号码";
            // 
            // labelCompanyRegistrationNumber
            // 
            labelCompanyRegistrationNumber.AutoSize = true;
            labelCompanyRegistrationNumber.Location = new System.Drawing.Point(16, 353);
            labelCompanyRegistrationNumber.Name = "labelCompanyRegistrationNumber";
            labelCompanyRegistrationNumber.Size = new System.Drawing.Size(77, 12);
            labelCompanyRegistrationNumber.TabIndex = 69;
            labelCompanyRegistrationNumber.Text = "营业执照号码";
            // 
            // labelContactName
            // 
            labelContactName.AutoSize = true;
            labelContactName.Location = new System.Drawing.Point(257, 257);
            labelContactName.Name = "labelContactName";
            labelContactName.Size = new System.Drawing.Size(41, 12);
            labelContactName.TabIndex = 71;
            labelContactName.Text = "联系人";
            // 
            // labelCountryCN
            // 
            labelCountryCN.AutoSize = true;
            labelCountryCN.Location = new System.Drawing.Point(16, 193);
            labelCountryCN.Name = "labelCountryCN";
            labelCountryCN.Size = new System.Drawing.Size(77, 12);
            labelCountryCN.TabIndex = 73;
            labelCountryCN.Text = "所在国(中文)";
            // 
            // labelEDINo
            // 
            labelEDINo.AutoSize = true;
            labelEDINo.Location = new System.Drawing.Point(16, 33);
            labelEDINo.Name = "labelEDINo";
            labelEDINo.Size = new System.Drawing.Size(53, 12);
            labelEDINo.TabIndex = 77;
            labelEDINo.Text = "保理代码";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(257, 289);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(35, 12);
            labelEmail.TabIndex = 79;
            labelEmail.Text = "Email";
            // 
            // labelFaxNumber
            // 
            labelFaxNumber.AutoSize = true;
            labelFaxNumber.Location = new System.Drawing.Point(257, 321);
            labelFaxNumber.Name = "labelFaxNumber";
            labelFaxNumber.Size = new System.Drawing.Size(53, 12);
            labelFaxNumber.TabIndex = 81;
            labelFaxNumber.Text = "传真号码";
            // 
            // labelPostCode
            // 
            labelPostCode.AutoSize = true;
            labelPostCode.Location = new System.Drawing.Point(257, 225);
            labelPostCode.Name = "labelPostCode";
            labelPostCode.Size = new System.Drawing.Size(29, 12);
            labelPostCode.TabIndex = 84;
            labelPostCode.Text = "邮编";
            // 
            // labelProvinceCN
            // 
            labelProvinceCN.AutoSize = true;
            labelProvinceCN.Location = new System.Drawing.Point(16, 163);
            labelProvinceCN.Name = "labelProvinceCN";
            labelProvinceCN.Size = new System.Drawing.Size(95, 12);
            labelProvinceCN.TabIndex = 86;
            labelProvinceCN.Text = "所在省/州(中文)";
            // 
            // labelProvinceEN
            // 
            labelProvinceEN.AutoSize = true;
            labelProvinceEN.Location = new System.Drawing.Point(257, 163);
            labelProvinceEN.Name = "labelProvinceEN";
            labelProvinceEN.Size = new System.Drawing.Size(95, 12);
            labelProvinceEN.TabIndex = 88;
            labelProvinceEN.Text = "所在省/州(英文)";
            // 
            // labelAccountCurrency
            // 
            labelAccountCurrency.AutoSize = true;
            labelAccountCurrency.Location = new System.Drawing.Point(45, 356);
            labelAccountCurrency.Name = "labelAccountCurrency";
            labelAccountCurrency.Size = new System.Drawing.Size(53, 12);
            labelAccountCurrency.TabIndex = 1;
            labelAccountCurrency.Text = "账户币种";
            // 
            // labelAccountNo
            // 
            labelAccountNo.AutoSize = true;
            labelAccountNo.Location = new System.Drawing.Point(45, 321);
            labelAccountNo.Name = "labelAccountNo";
            labelAccountNo.Size = new System.Drawing.Size(29, 12);
            labelAccountNo.TabIndex = 5;
            labelAccountNo.Text = "帐号";
            // 
            // labelAccountType
            // 
            labelAccountType.AutoSize = true;
            labelAccountType.Location = new System.Drawing.Point(45, 391);
            labelAccountType.Name = "labelAccountType";
            labelAccountType.Size = new System.Drawing.Size(53, 12);
            labelAccountType.TabIndex = 7;
            labelAccountType.Text = "帐号类型";
            // 
            // labelBank
            // 
            labelBank.AutoSize = true;
            labelBank.Location = new System.Drawing.Point(45, 426);
            labelBank.Name = "labelBank";
            labelBank.Size = new System.Drawing.Size(53, 12);
            labelBank.TabIndex = 9;
            labelBank.Text = "往来银行";
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new System.Drawing.Point(45, 461);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new System.Drawing.Size(29, 12);
            labelBranch.TabIndex = 11;
            labelBranch.Text = "分行";
            // 
            // labelAccountComment
            // 
            labelAccountComment.AutoSize = true;
            labelAccountComment.Location = new System.Drawing.Point(45, 496);
            labelAccountComment.Name = "labelAccountComment";
            labelAccountComment.Size = new System.Drawing.Size(29, 12);
            labelAccountComment.TabIndex = 15;
            labelAccountComment.Text = "备注";
            // 
            // labelAuthorizationNo
            // 
            labelAuthorizationNo.AutoSize = true;
            labelAuthorizationNo.Location = new System.Drawing.Point(35, 454);
            labelAuthorizationNo.Name = "labelAuthorizationNo";
            labelAuthorizationNo.Size = new System.Drawing.Size(53, 12);
            labelAuthorizationNo.TabIndex = 1;
            labelAuthorizationNo.Text = "核准编号";
            // 
            // labelCreditComment
            // 
            labelCreditComment.AutoSize = true;
            labelCreditComment.Location = new System.Drawing.Point(35, 487);
            labelCreditComment.Name = "labelCreditComment";
            labelCreditComment.Size = new System.Drawing.Size(29, 12);
            labelCreditComment.TabIndex = 5;
            labelCreditComment.Text = "备注";
            // 
            // labelCreditLineCurrency
            // 
            labelCreditLineCurrency.AutoSize = true;
            labelCreditLineCurrency.Location = new System.Drawing.Point(35, 355);
            labelCreditLineCurrency.Name = "labelCreditLineCurrency";
            labelCreditLineCurrency.Size = new System.Drawing.Size(53, 12);
            labelCreditLineCurrency.TabIndex = 7;
            labelCreditLineCurrency.Text = "额度币种";
            // 
            // labelCreditLineLimit
            // 
            labelCreditLineLimit.AutoSize = true;
            labelCreditLineLimit.Location = new System.Drawing.Point(35, 388);
            labelCreditLineLimit.Name = "labelCreditLineLimit";
            labelCreditLineLimit.Size = new System.Drawing.Size(53, 12);
            labelCreditLineLimit.TabIndex = 11;
            labelCreditLineLimit.Text = "额度上限";
            // 
            // labelCreditLineType
            // 
            labelCreditLineType.AutoSize = true;
            labelCreditLineType.Location = new System.Drawing.Point(35, 322);
            labelCreditLineType.Name = "labelCreditLineType";
            labelCreditLineType.Size = new System.Drawing.Size(53, 12);
            labelCreditLineType.TabIndex = 13;
            labelCreditLineType.Text = "额度种类";
            // 
            // labelPeriod
            // 
            labelPeriod.AutoSize = true;
            labelPeriod.Location = new System.Drawing.Point(35, 424);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new System.Drawing.Size(53, 12);
            labelPeriod.TabIndex = 19;
            labelPeriod.Text = "有效期限";
            // 
            // periodEndLabel
            // 
            periodEndLabel.AutoSize = true;
            periodEndLabel.Location = new System.Drawing.Point(294, 424);
            periodEndLabel.Name = "periodEndLabel";
            periodEndLabel.Size = new System.Drawing.Size(11, 12);
            periodEndLabel.TabIndex = 21;
            periodEndLabel.Text = "~";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Client);
            // 
            // tsClientDetail
            // 
            this.tsClientDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel});
            this.tsClientDetail.Location = new System.Drawing.Point(0, 0);
            this.tsClientDetail.Name = "tsClientDetail";
            this.tsClientDetail.Size = new System.Drawing.Size(538, 25);
            this.tsClientDetail.TabIndex = 53;
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 22);
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 22);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.tabPageClientInfo);
            this.tabClient.Controls.Add(this.tabPageAccountInfo);
            this.tabClient.Controls.Add(this.tabPageCreditInfo);
            this.tabClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClient.Location = new System.Drawing.Point(0, 25);
            this.tabClient.Name = "tabClient";
            this.tabClient.SelectedIndex = 0;
            this.tabClient.Size = new System.Drawing.Size(538, 562);
            this.tabClient.TabIndex = 54;
            // 
            // tabPageClientInfo
            // 
            this.tabPageClientInfo.Controls.Add(this.gbStatistic);
            this.tabPageClientInfo.Controls.Add(this.gbInfo);
            this.tabPageClientInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientInfo.Name = "tabPageClientInfo";
            this.tabPageClientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientInfo.Size = new System.Drawing.Size(530, 536);
            this.tabPageClientInfo.TabIndex = 0;
            this.tabPageClientInfo.Text = "客户信息";
            this.tabPageClientInfo.UseVisualStyleBackColor = true;
            // 
            // gbStatistic
            // 
            this.gbStatistic.Controls.Add(labelPMName);
            this.gbStatistic.Controls.Add(labelBranchID);
            this.gbStatistic.Controls.Add(this.tbBranchID);
            this.gbStatistic.Controls.Add(this.tbPMName);
            this.gbStatistic.Location = new System.Drawing.Point(16, 436);
            this.gbStatistic.Name = "gbStatistic";
            this.gbStatistic.Size = new System.Drawing.Size(498, 85);
            this.gbStatistic.TabIndex = 54;
            this.gbStatistic.TabStop = false;
            this.gbStatistic.Text = "统计信息";
            // 
            // tbBranchID
            // 
            this.tbBranchID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "BranchID", true));
            this.tbBranchID.Location = new System.Drawing.Point(131, 52);
            this.tbBranchID.Name = "tbBranchID";
            this.tbBranchID.Size = new System.Drawing.Size(100, 21);
            this.tbBranchID.TabIndex = 1;
            // 
            // tbPMName
            // 
            this.tbPMName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PMName", true));
            this.tbPMName.Location = new System.Drawing.Point(131, 20);
            this.tbPMName.Name = "tbPMName";
            this.tbPMName.Size = new System.Drawing.Size(100, 21);
            this.tbPMName.TabIndex = 0;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(labelResponsibleAgency);
            this.gbInfo.Controls.Add(labelTelephone);
            this.gbInfo.Controls.Add(this.tbTelephone);
            this.gbInfo.Controls.Add(labelWetsite);
            this.gbInfo.Controls.Add(this.tbWetsite);
            this.gbInfo.Controls.Add(labelAddressCN);
            this.gbInfo.Controls.Add(this.tbAddressCN);
            this.gbInfo.Controls.Add(labelAddressEN);
            this.gbInfo.Controls.Add(this.tbAddressEN);
            this.gbInfo.Controls.Add(labelCellPhone);
            this.gbInfo.Controls.Add(this.tbCellPhone);
            this.gbInfo.Controls.Add(labelCityCN);
            this.gbInfo.Controls.Add(this.tbCityCN);
            this.gbInfo.Controls.Add(labelCityEN);
            this.gbInfo.Controls.Add(this.tbCityEN);
            this.gbInfo.Controls.Add(labelClientNameCN);
            this.gbInfo.Controls.Add(this.tbClientNameCN);
            this.gbInfo.Controls.Add(labelClientNameEN_1);
            this.gbInfo.Controls.Add(this.tbClientNameEN1);
            this.gbInfo.Controls.Add(labelClientNameEN_2);
            this.gbInfo.Controls.Add(this.tbClientNameEN2);
            this.gbInfo.Controls.Add(labelComment);
            this.gbInfo.Controls.Add(this.tbComment);
            this.gbInfo.Controls.Add(labelCompanyCode);
            this.gbInfo.Controls.Add(this.tbCompanyCode);
            this.gbInfo.Controls.Add(labelCompanyRegistrationNumber);
            this.gbInfo.Controls.Add(this.tbCompanyRegistrationNumber);
            this.gbInfo.Controls.Add(labelContactName);
            this.gbInfo.Controls.Add(this.tbContactName);
            this.gbInfo.Controls.Add(labelCountryCN);
            this.gbInfo.Controls.Add(this.tbCountryCode);
            this.gbInfo.Controls.Add(labelEDINo);
            this.gbInfo.Controls.Add(this.tbEDINo);
            this.gbInfo.Controls.Add(labelEmail);
            this.gbInfo.Controls.Add(this.tbEmail);
            this.gbInfo.Controls.Add(labelFaxNumber);
            this.gbInfo.Controls.Add(this.tbFaxNumber);
            this.gbInfo.Controls.Add(labelPostCode);
            this.gbInfo.Controls.Add(this.tbPostCode);
            this.gbInfo.Controls.Add(labelProvinceCN);
            this.gbInfo.Controls.Add(this.tbProvinceCN);
            this.gbInfo.Controls.Add(labelProvinceEN);
            this.gbInfo.Controls.Add(this.tbProvinceEN);
            this.gbInfo.Controls.Add(this.tbResponsibleAgency);
            this.gbInfo.Location = new System.Drawing.Point(16, 13);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(498, 417);
            this.gbInfo.TabIndex = 53;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "基本信息";
            // 
            // tbTelephone
            // 
            this.tbTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Telephone", true));
            this.tbTelephone.Location = new System.Drawing.Point(131, 286);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(100, 21);
            this.tbTelephone.TabIndex = 16;
            // 
            // tbWetsite
            // 
            this.tbWetsite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Wetsite", true));
            this.tbWetsite.Location = new System.Drawing.Point(131, 254);
            this.tbWetsite.Name = "tbWetsite";
            this.tbWetsite.Size = new System.Drawing.Size(100, 21);
            this.tbWetsite.TabIndex = 14;
            // 
            // tbAddressCN
            // 
            this.tbAddressCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressCN", true));
            this.tbAddressCN.Location = new System.Drawing.Point(131, 94);
            this.tbAddressCN.Name = "tbAddressCN";
            this.tbAddressCN.Size = new System.Drawing.Size(100, 21);
            this.tbAddressCN.TabIndex = 4;
            // 
            // tbAddressEN
            // 
            this.tbAddressEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "AddressEN", true));
            this.tbAddressEN.Location = new System.Drawing.Point(373, 94);
            this.tbAddressEN.Name = "tbAddressEN";
            this.tbAddressEN.Size = new System.Drawing.Size(100, 21);
            this.tbAddressEN.TabIndex = 5;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CellPhone", true));
            this.tbCellPhone.Location = new System.Drawing.Point(131, 318);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(100, 21);
            this.tbCellPhone.TabIndex = 18;
            // 
            // tbCityCN
            // 
            this.tbCityCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityCN", true));
            this.tbCityCN.Location = new System.Drawing.Point(131, 126);
            this.tbCityCN.Name = "tbCityCN";
            this.tbCityCN.Size = new System.Drawing.Size(100, 21);
            this.tbCityCN.TabIndex = 6;
            // 
            // tbCityEN
            // 
            this.tbCityEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CityEN", true));
            this.tbCityEN.Location = new System.Drawing.Point(373, 126);
            this.tbCityEN.Name = "tbCityEN";
            this.tbCityEN.Size = new System.Drawing.Size(100, 21);
            this.tbCityEN.TabIndex = 7;
            // 
            // tbClientNameCN
            // 
            this.tbClientNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameCN", true));
            this.tbClientNameCN.Location = new System.Drawing.Point(373, 30);
            this.tbClientNameCN.Name = "tbClientNameCN";
            this.tbClientNameCN.Size = new System.Drawing.Size(100, 21);
            this.tbClientNameCN.TabIndex = 1;
            // 
            // tbClientNameEN1
            // 
            this.tbClientNameEN1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameEN_1", true));
            this.tbClientNameEN1.Location = new System.Drawing.Point(131, 62);
            this.tbClientNameEN1.Name = "tbClientNameEN1";
            this.tbClientNameEN1.Size = new System.Drawing.Size(100, 21);
            this.tbClientNameEN1.TabIndex = 2;
            // 
            // tbClientNameEN2
            // 
            this.tbClientNameEN2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNameEN_2", true));
            this.tbClientNameEN2.Location = new System.Drawing.Point(373, 62);
            this.tbClientNameEN2.Name = "tbClientNameEN2";
            this.tbClientNameEN2.Size = new System.Drawing.Size(100, 21);
            this.tbClientNameEN2.TabIndex = 3;
            // 
            // tbComment
            // 
            this.tbComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Comment", true));
            this.tbComment.Location = new System.Drawing.Point(131, 382);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(100, 21);
            this.tbComment.TabIndex = 22;
            // 
            // tbCompanyCode
            // 
            this.tbCompanyCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CompanyCode", true));
            this.tbCompanyCode.Location = new System.Drawing.Point(373, 350);
            this.tbCompanyCode.Name = "tbCompanyCode";
            this.tbCompanyCode.Size = new System.Drawing.Size(100, 21);
            this.tbCompanyCode.TabIndex = 21;
            // 
            // tbCompanyRegistrationNumber
            // 
            this.tbCompanyRegistrationNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CompanyRegistrationNumber", true));
            this.tbCompanyRegistrationNumber.Location = new System.Drawing.Point(131, 350);
            this.tbCompanyRegistrationNumber.Name = "tbCompanyRegistrationNumber";
            this.tbCompanyRegistrationNumber.Size = new System.Drawing.Size(100, 21);
            this.tbCompanyRegistrationNumber.TabIndex = 20;
            // 
            // tbContactName
            // 
            this.tbContactName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ContactName", true));
            this.tbContactName.Location = new System.Drawing.Point(373, 254);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.Size = new System.Drawing.Size(100, 21);
            this.tbContactName.TabIndex = 15;
            // 
            // tbCountryCode
            // 
            this.tbCountryCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CountryCode", true));
            this.tbCountryCode.Location = new System.Drawing.Point(131, 190);
            this.tbCountryCode.Name = "tbCountryCode";
            this.tbCountryCode.Size = new System.Drawing.Size(100, 20);
            this.tbCountryCode.TabIndex = 10;
            // 
            // tbEDINo
            // 
            this.tbEDINo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "EDINo", true));
            this.tbEDINo.Location = new System.Drawing.Point(131, 30);
            this.tbEDINo.Name = "tbEDINo";
            this.tbEDINo.Size = new System.Drawing.Size(100, 21);
            this.tbEDINo.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email", true));
            this.tbEmail.Location = new System.Drawing.Point(373, 286);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 21);
            this.tbEmail.TabIndex = 17;
            // 
            // tbFaxNumber
            // 
            this.tbFaxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FaxNumber", true));
            this.tbFaxNumber.Location = new System.Drawing.Point(373, 318);
            this.tbFaxNumber.Name = "tbFaxNumber";
            this.tbFaxNumber.Size = new System.Drawing.Size(100, 21);
            this.tbFaxNumber.TabIndex = 19;
            // 
            // tbPostCode
            // 
            this.tbPostCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PostCode", true));
            this.tbPostCode.Location = new System.Drawing.Point(373, 222);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(100, 21);
            this.tbPostCode.TabIndex = 13;
            // 
            // tbProvinceCN
            // 
            this.tbProvinceCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceCN", true));
            this.tbProvinceCN.Location = new System.Drawing.Point(131, 158);
            this.tbProvinceCN.Name = "tbProvinceCN";
            this.tbProvinceCN.Size = new System.Drawing.Size(100, 21);
            this.tbProvinceCN.TabIndex = 8;
            // 
            // tbProvinceEN
            // 
            this.tbProvinceEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ProvinceEN", true));
            this.tbProvinceEN.Location = new System.Drawing.Point(373, 158);
            this.tbProvinceEN.Name = "tbProvinceEN";
            this.tbProvinceEN.Size = new System.Drawing.Size(100, 21);
            this.tbProvinceEN.TabIndex = 9;
            // 
            // tbResponsibleAgency
            // 
            this.tbResponsibleAgency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ResponsibleAgency", true));
            this.tbResponsibleAgency.Location = new System.Drawing.Point(131, 222);
            this.tbResponsibleAgency.Name = "tbResponsibleAgency";
            this.tbResponsibleAgency.Size = new System.Drawing.Size(100, 21);
            this.tbResponsibleAgency.TabIndex = 12;
            // 
            // tabPageAccountInfo
            // 
            this.tabPageAccountInfo.AutoScroll = true;
            this.tabPageAccountInfo.Controls.Add(labelAccountCurrency);
            this.tabPageAccountInfo.Controls.Add(this.tbAccountCurrency);
            this.tabPageAccountInfo.Controls.Add(labelAccountNo);
            this.tabPageAccountInfo.Controls.Add(this.tbAccountNo);
            this.tabPageAccountInfo.Controls.Add(labelAccountType);
            this.tabPageAccountInfo.Controls.Add(this.tbAccountType);
            this.tabPageAccountInfo.Controls.Add(labelBank);
            this.tabPageAccountInfo.Controls.Add(this.tbBank);
            this.tabPageAccountInfo.Controls.Add(labelBranch);
            this.tabPageAccountInfo.Controls.Add(this.tbBranch);
            this.tabPageAccountInfo.Controls.Add(labelAccountComment);
            this.tabPageAccountInfo.Controls.Add(this.tbAccountComment);
            this.tabPageAccountInfo.Controls.Add(this.dgvClientAccount);
            this.tabPageAccountInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccountInfo.Name = "tabPageAccountInfo";
            this.tabPageAccountInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccountInfo.Size = new System.Drawing.Size(530, 536);
            this.tabPageAccountInfo.TabIndex = 1;
            this.tabPageAccountInfo.Text = "账户信息";
            this.tabPageAccountInfo.UseVisualStyleBackColor = true;
            // 
            // tbAccountCurrency
            // 
            this.tbAccountCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientAccountBindingSource1, "AccountCurrency", true));
            this.tbAccountCurrency.Location = new System.Drawing.Point(158, 353);
            this.tbAccountCurrency.Name = "tbAccountCurrency";
            this.tbAccountCurrency.Size = new System.Drawing.Size(158, 21);
            this.tbAccountCurrency.TabIndex = 2;
            // 
            // clientAccountBindingSource1
            // 
            this.clientAccountBindingSource1.DataSource = typeof(CMBC.EasyFactor.DB.dbml.ClientAccount);
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientAccountBindingSource1, "AccountNo", true));
            this.tbAccountNo.Location = new System.Drawing.Point(158, 318);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(158, 21);
            this.tbAccountNo.TabIndex = 6;
            // 
            // tbAccountType
            // 
            this.tbAccountType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientAccountBindingSource1, "AccountType", true));
            this.tbAccountType.Location = new System.Drawing.Point(158, 388);
            this.tbAccountType.Name = "tbAccountType";
            this.tbAccountType.Size = new System.Drawing.Size(158, 21);
            this.tbAccountType.TabIndex = 8;
            // 
            // tbBank
            // 
            this.tbBank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientAccountBindingSource1, "Bank", true));
            this.tbBank.Location = new System.Drawing.Point(158, 423);
            this.tbBank.Name = "tbBank";
            this.tbBank.Size = new System.Drawing.Size(158, 21);
            this.tbBank.TabIndex = 10;
            // 
            // tbBranch
            // 
            this.tbBranch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientAccountBindingSource1, "Branch", true));
            this.tbBranch.Location = new System.Drawing.Point(158, 458);
            this.tbBranch.Name = "tbBranch";
            this.tbBranch.Size = new System.Drawing.Size(158, 21);
            this.tbBranch.TabIndex = 12;
            // 
            // tbAccountComment
            // 
            this.tbAccountComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientAccountBindingSource1, "Comment", true));
            this.tbAccountComment.Location = new System.Drawing.Point(158, 493);
            this.tbAccountComment.Name = "tbAccountComment";
            this.tbAccountComment.Size = new System.Drawing.Size(158, 21);
            this.tbAccountComment.TabIndex = 16;
            // 
            // dgvClientAccount
            // 
            this.dgvClientAccount.AllowUserToAddRows = false;
            this.dgvClientAccount.AllowUserToDeleteRows = false;
            this.dgvClientAccount.AllowUserToOrderColumns = true;
            this.dgvClientAccount.AutoGenerateColumns = false;
            this.dgvClientAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.bankDataGridViewTextBoxColumn,
            this.eDINoDataGridViewTextBoxColumn,
            this.isDefaultDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn});
            this.dgvClientAccount.DataSource = this.clientAccountBindingSource;
            this.dgvClientAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClientAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvClientAccount.Name = "dgvClientAccount";
            this.dgvClientAccount.RowTemplate.Height = 23;
            this.dgvClientAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientAccount.Size = new System.Drawing.Size(524, 291);
            this.dgvClientAccount.TabIndex = 0;
            this.dgvClientAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientAccount_CellClick);
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "账户ID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "账号";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "账号类型";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            // 
            // bankDataGridViewTextBoxColumn
            // 
            this.bankDataGridViewTextBoxColumn.DataPropertyName = "Bank";
            this.bankDataGridViewTextBoxColumn.HeaderText = "往来银行";
            this.bankDataGridViewTextBoxColumn.Name = "bankDataGridViewTextBoxColumn";
            // 
            // eDINoDataGridViewTextBoxColumn
            // 
            this.eDINoDataGridViewTextBoxColumn.DataPropertyName = "EDINo";
            this.eDINoDataGridViewTextBoxColumn.HeaderText = "保理代码";
            this.eDINoDataGridViewTextBoxColumn.Name = "eDINoDataGridViewTextBoxColumn";
            // 
            // isDefaultDataGridViewTextBoxColumn
            // 
            this.isDefaultDataGridViewTextBoxColumn.DataPropertyName = "IsDefault";
            this.isDefaultDataGridViewTextBoxColumn.HeaderText = "是否默认";
            this.isDefaultDataGridViewTextBoxColumn.Name = "isDefaultDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // clientAccountBindingSource
            // 
            this.clientAccountBindingSource.DataMember = "ClientAccounts";
            this.clientAccountBindingSource.DataSource = this.clientBindingSource;
            // 
            // tabPageCreditInfo
            // 
            this.tabPageCreditInfo.AutoScroll = true;
            this.tabPageCreditInfo.Controls.Add(labelAuthorizationNo);
            this.tabPageCreditInfo.Controls.Add(this.tbAuthorizationNo);
            this.tabPageCreditInfo.Controls.Add(labelCreditComment);
            this.tabPageCreditInfo.Controls.Add(this.tbCreditComment);
            this.tabPageCreditInfo.Controls.Add(labelCreditLineCurrency);
            this.tabPageCreditInfo.Controls.Add(this.tbCreditLineCurrency);
            this.tabPageCreditInfo.Controls.Add(labelCreditLineLimit);
            this.tabPageCreditInfo.Controls.Add(this.tbCreditLineLimit);
            this.tabPageCreditInfo.Controls.Add(labelCreditLineType);
            this.tabPageCreditInfo.Controls.Add(this.tbCreditLineType);
            this.tabPageCreditInfo.Controls.Add(labelPeriod);
            this.tabPageCreditInfo.Controls.Add(this.tpPeriodBeginDate);
            this.tabPageCreditInfo.Controls.Add(periodEndLabel);
            this.tabPageCreditInfo.Controls.Add(this.tpPeriodEndDate);
            this.tabPageCreditInfo.Controls.Add(this.dgvClientCreditLine);
            this.tabPageCreditInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreditInfo.Name = "tabPageCreditInfo";
            this.tabPageCreditInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreditInfo.Size = new System.Drawing.Size(530, 536);
            this.tabPageCreditInfo.TabIndex = 2;
            this.tabPageCreditInfo.Text = "额度信息";
            this.tabPageCreditInfo.UseVisualStyleBackColor = true;
            // 
            // tbAuthorizationNo
            // 
            this.tbAuthorizationNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditLineBindingSource1, "AuthorizationNo", true));
            this.tbAuthorizationNo.Location = new System.Drawing.Point(130, 451);
            this.tbAuthorizationNo.Name = "tbAuthorizationNo";
            this.tbAuthorizationNo.Size = new System.Drawing.Size(158, 21);
            this.tbAuthorizationNo.TabIndex = 2;
            // 
            // creditLineBindingSource1
            // 
            this.creditLineBindingSource1.DataSource = typeof(CMBC.EasyFactor.DB.dbml.ClientCreditLine);
            // 
            // tbCreditComment
            // 
            this.tbCreditComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditLineBindingSource1, "Comment", true));
            this.tbCreditComment.Location = new System.Drawing.Point(130, 484);
            this.tbCreditComment.Name = "tbCreditComment";
            this.tbCreditComment.Size = new System.Drawing.Size(158, 21);
            this.tbCreditComment.TabIndex = 6;
            // 
            // tbCreditLineCurrency
            // 
            this.tbCreditLineCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditLineBindingSource1, "CreditLineCurrency", true));
            this.tbCreditLineCurrency.Location = new System.Drawing.Point(130, 352);
            this.tbCreditLineCurrency.Name = "tbCreditLineCurrency";
            this.tbCreditLineCurrency.Size = new System.Drawing.Size(158, 21);
            this.tbCreditLineCurrency.TabIndex = 8;
            // 
            // tbCreditLineLimit
            // 
            this.tbCreditLineLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditLineBindingSource1, "CreditLineLimit", true));
            this.tbCreditLineLimit.Location = new System.Drawing.Point(130, 385);
            this.tbCreditLineLimit.Name = "tbCreditLineLimit";
            this.tbCreditLineLimit.Size = new System.Drawing.Size(158, 21);
            this.tbCreditLineLimit.TabIndex = 12;
            // 
            // tbCreditLineType
            // 
            this.tbCreditLineType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditLineBindingSource1, "CreditLineType", true));
            this.tbCreditLineType.Location = new System.Drawing.Point(130, 319);
            this.tbCreditLineType.Name = "tbCreditLineType";
            this.tbCreditLineType.Size = new System.Drawing.Size(158, 21);
            this.tbCreditLineType.TabIndex = 14;
            // 
            // tpPeriodBeginDate
            // 
            this.tpPeriodBeginDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditLineBindingSource1, "PeriodBegin", true));
            this.tpPeriodBeginDate.Location = new System.Drawing.Point(130, 418);
            this.tpPeriodBeginDate.Name = "tpPeriodBeginDate";
            this.tpPeriodBeginDate.Size = new System.Drawing.Size(158, 21);
            this.tpPeriodBeginDate.TabIndex = 20;
            // 
            // tpPeriodEndDate
            // 
            this.tpPeriodEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditLineBindingSource1, "PeriodEnd", true));
            this.tpPeriodEndDate.Location = new System.Drawing.Point(311, 418);
            this.tpPeriodEndDate.Name = "tpPeriodEndDate";
            this.tpPeriodEndDate.Size = new System.Drawing.Size(158, 21);
            this.tpPeriodEndDate.TabIndex = 22;
            // 
            // dgvClientCreditLine
            // 
            this.dgvClientCreditLine.AllowUserToAddRows = false;
            this.dgvClientCreditLine.AllowUserToDeleteRows = false;
            this.dgvClientCreditLine.AllowUserToOrderColumns = true;
            this.dgvClientCreditLine.AutoGenerateColumns = false;
            this.dgvClientCreditLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientCreditLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditLineIDDataGridViewTextBoxColumn,
            this.eDINoDataGridViewTextBoxColumn1,
            this.creditLineTypeDataGridViewTextBoxColumn,
            this.creditLineCurrencyDataGridViewTextBoxColumn,
            this.creditLineLimitDataGridViewTextBoxColumn,
            this.periodBeginDataGridViewTextBoxColumn,
            this.periodEndDataGridViewTextBoxColumn,
            this.authorizationNoDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn1,
            this.clientDataGridViewTextBoxColumn1});
            this.dgvClientCreditLine.DataSource = this.creditLineBindingSource;
            this.dgvClientCreditLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClientCreditLine.Location = new System.Drawing.Point(3, 3);
            this.dgvClientCreditLine.Name = "dgvClientCreditLine";
            this.dgvClientCreditLine.RowTemplate.Height = 23;
            this.dgvClientCreditLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientCreditLine.Size = new System.Drawing.Size(524, 287);
            this.dgvClientCreditLine.TabIndex = 0;
            this.dgvClientCreditLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientCreditLine_CellClick);
            // 
            // creditLineIDDataGridViewTextBoxColumn
            // 
            this.creditLineIDDataGridViewTextBoxColumn.DataPropertyName = "CreditLineID";
            this.creditLineIDDataGridViewTextBoxColumn.HeaderText = "额度ID";
            this.creditLineIDDataGridViewTextBoxColumn.Name = "creditLineIDDataGridViewTextBoxColumn";
            // 
            // eDINoDataGridViewTextBoxColumn1
            // 
            this.eDINoDataGridViewTextBoxColumn1.DataPropertyName = "EDINo";
            this.eDINoDataGridViewTextBoxColumn1.HeaderText = "保理代码";
            this.eDINoDataGridViewTextBoxColumn1.Name = "eDINoDataGridViewTextBoxColumn1";
            // 
            // creditLineTypeDataGridViewTextBoxColumn
            // 
            this.creditLineTypeDataGridViewTextBoxColumn.DataPropertyName = "CreditLineType";
            this.creditLineTypeDataGridViewTextBoxColumn.HeaderText = "额度类型";
            this.creditLineTypeDataGridViewTextBoxColumn.Name = "creditLineTypeDataGridViewTextBoxColumn";
            // 
            // creditLineCurrencyDataGridViewTextBoxColumn
            // 
            this.creditLineCurrencyDataGridViewTextBoxColumn.DataPropertyName = "CreditLineCurrency";
            this.creditLineCurrencyDataGridViewTextBoxColumn.HeaderText = "额度币别";
            this.creditLineCurrencyDataGridViewTextBoxColumn.Name = "creditLineCurrencyDataGridViewTextBoxColumn";
            // 
            // creditLineLimitDataGridViewTextBoxColumn
            // 
            this.creditLineLimitDataGridViewTextBoxColumn.DataPropertyName = "CreditLineLimit";
            this.creditLineLimitDataGridViewTextBoxColumn.HeaderText = "额度上限";
            this.creditLineLimitDataGridViewTextBoxColumn.Name = "creditLineLimitDataGridViewTextBoxColumn";
            // 
            // periodBeginDataGridViewTextBoxColumn
            // 
            this.periodBeginDataGridViewTextBoxColumn.DataPropertyName = "PeriodBegin";
            this.periodBeginDataGridViewTextBoxColumn.HeaderText = "有效期(开始)";
            this.periodBeginDataGridViewTextBoxColumn.Name = "periodBeginDataGridViewTextBoxColumn";
            // 
            // periodEndDataGridViewTextBoxColumn
            // 
            this.periodEndDataGridViewTextBoxColumn.DataPropertyName = "PeriodEnd";
            this.periodEndDataGridViewTextBoxColumn.HeaderText = "有效期(结束)";
            this.periodEndDataGridViewTextBoxColumn.Name = "periodEndDataGridViewTextBoxColumn";
            // 
            // authorizationNoDataGridViewTextBoxColumn
            // 
            this.authorizationNoDataGridViewTextBoxColumn.DataPropertyName = "AuthorizationNo";
            this.authorizationNoDataGridViewTextBoxColumn.HeaderText = "核准编号";
            this.authorizationNoDataGridViewTextBoxColumn.Name = "authorizationNoDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            // 
            // clientDataGridViewTextBoxColumn1
            // 
            this.clientDataGridViewTextBoxColumn1.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn1.HeaderText = "客户名称";
            this.clientDataGridViewTextBoxColumn1.Name = "clientDataGridViewTextBoxColumn1";
            // 
            // creditLineBindingSource
            // 
            this.creditLineBindingSource.DataMember = "ClientCreditLines";
            this.creditLineBindingSource.DataSource = this.clientBindingSource;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Country);
            // 
            // ClientDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 587);
            this.Controls.Add(this.tabClient);
            this.Controls.Add(this.tsClientDetail);
            this.DoubleBuffered = true;
            this.Name = "ClientDetailUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "客户详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.tsClientDetail.ResumeLayout(false);
            this.tsClientDetail.PerformLayout();
            this.tabClient.ResumeLayout(false);
            this.tabPageClientInfo.ResumeLayout(false);
            this.gbStatistic.ResumeLayout(false);
            this.gbStatistic.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tabPageAccountInfo.ResumeLayout(false);
            this.tabPageAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource)).EndInit();
            this.tabPageCreditInfo.ResumeLayout(false);
            this.tabPageCreditInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditLineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabClient;
        private System.Windows.Forms.TabPage tabPageClientInfo;
        private System.Windows.Forms.GroupBox gbStatistic;
        private System.Windows.Forms.TextBox tbBranchID;
        private System.Windows.Forms.TextBox tbPMName;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbWetsite;
        private System.Windows.Forms.TextBox tbAddressCN;
        private System.Windows.Forms.TextBox tbAddressEN;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.TextBox tbCityCN;
        private System.Windows.Forms.TextBox tbCityEN;
        private System.Windows.Forms.TextBox tbClientNameCN;
        private System.Windows.Forms.TextBox tbClientNameEN1;
        private System.Windows.Forms.TextBox tbClientNameEN2;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbCompanyCode;
        private System.Windows.Forms.TextBox tbCompanyRegistrationNumber;
        private System.Windows.Forms.TextBox tbContactName;
        private System.Windows.Forms.ComboBox tbCountryCode;
        //private System.Windows.Forms.TextBox tbCountryEN;
        private System.Windows.Forms.TextBox tbEDINo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFaxNumber;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbProvinceCN;
        private System.Windows.Forms.TextBox tbProvinceEN;
        private System.Windows.Forms.TextBox tbResponsibleAgency;
        private System.Windows.Forms.TabPage tabPageAccountInfo;
        private System.Windows.Forms.DataGridView dgvClientAccount;
        private System.Windows.Forms.BindingSource clientAccountBindingSource;
        private System.Windows.Forms.TabPage tabPageCreditInfo;
        private System.Windows.Forms.DataGridView dgvClientCreditLine;
        private System.Windows.Forms.BindingSource creditLineBindingSource;
        private System.Windows.Forms.TextBox tbAccountCurrency;
        private System.Windows.Forms.BindingSource clientAccountBindingSource1;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.TextBox tbAccountType;
        private System.Windows.Forms.TextBox tbBank;
        private System.Windows.Forms.TextBox tbBranch;
        private System.Windows.Forms.TextBox tbAccountComment;
        private System.Windows.Forms.TextBox tbAuthorizationNo;
        private System.Windows.Forms.BindingSource creditLineBindingSource1;
        private System.Windows.Forms.TextBox tbCreditComment;
        private System.Windows.Forms.TextBox tbCreditLineCurrency;
        private System.Windows.Forms.TextBox tbCreditLineLimit;
        private System.Windows.Forms.TextBox tbCreditLineType;
        private System.Windows.Forms.DateTimePicker tpPeriodBeginDate;
        private System.Windows.Forms.DateTimePicker tpPeriodEndDate;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDINoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDefaultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDINoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLineCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLineLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorizationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn1;
    }
}