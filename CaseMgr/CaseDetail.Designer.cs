//-----------------------------------------------------------------------
// <copyright file="CaseDetail.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using CMBC.EasyFactor.Utils;

    /// <summary>
    ///
    /// </summary>
    public partial class CaseDetail
    {
        #region Fields (126)

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.ButtonX btnCaseBuyerSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseFactorSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseSave;
        private DevComponents.DotNetBar.ButtonX btnCaseSellerSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseUpdate;
        private DevComponents.DotNetBar.ButtonX btnCDADelete;
        private DevComponents.DotNetBar.ButtonX btnCDANew;
        private DevComponents.DotNetBar.ButtonX btnCDARefresh;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegDelete;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegNew;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegRefresh;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegSave;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegUpdate;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private DevComponents.DotNetBar.Validator.SuperValidator caseValidator;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseCoDepts;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseInvoiceCurrency;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseMark;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseOpType;
        private DevComponents.DotNetBar.Controls.ComboTree cbCaseOwnerDepts;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseTransactionType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRequestType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDADueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAValueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionTypeComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeductibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceGracePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLineCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFeeCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsCreditCoverRevolving;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRecoarse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLossThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticePersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUGPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUGProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReassignGracePeriod;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource creditCoverNegBindingSource;
        private DevComponents.DotNetBar.Validator.SuperValidator creditCoverValidator;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCDAs;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCoverNegs;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diCaseAppDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diReplyDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diRequestDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCase;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCDA;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditCoverNeg;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator11;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator12;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator13;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator7;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator8;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator9;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemCase;
        private DevComponents.DotNetBar.TabItem tabItemCDA;
        private DevComponents.DotNetBar.TabItem tabItemCreditCoverNeg;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCase;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCDA;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCreditCoverNeg;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCreateUser;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseFactorNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseFactorNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIFPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX tbOPName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentTerm;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReplyAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRequestAmount;

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
            DevComponents.DotNetBar.LabelX requestAmountLabel;
            DevComponents.DotNetBar.LabelX replyAmountLabel;
            DevComponents.DotNetBar.LabelX iFPriceLabel;
            DevComponents.DotNetBar.LabelX replyDateLabel;
            DevComponents.DotNetBar.LabelX requestDateLabel;
            DevComponents.DotNetBar.LabelX requestTypeLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX createUserNameLabel;
            DevComponents.DotNetBar.LabelX lblCaseCoDept;
            DevComponents.DotNetBar.LabelX lblCaseOwnerDept;
            DevComponents.DotNetBar.LabelX lblCaseOpType;
            DevComponents.DotNetBar.LabelX lblCaseCreateUser;
            DevComponents.DotNetBar.LabelX lblCaseMark;
            DevComponents.DotNetBar.LabelX lblCaseAppDate;
            DevComponents.DotNetBar.LabelX lblCaseTransactionType;
            DevComponents.DotNetBar.LabelX lblCaseInvoiceCurrency;
            DevComponents.DotNetBar.LabelX lblCaseBuyerNo;
            DevComponents.DotNetBar.LabelX lblCaseSellerNo;
            DevComponents.DotNetBar.LabelX lblCaseFactor;
            DevComponents.DotNetBar.LabelX lblOPName;
            DevComponents.DotNetBar.LabelX lblPaymentTerm;
            DevComponents.DotNetBar.LabelX lblComment;
            DevComponents.DotNetBar.LabelX lblCaseCode;
            DevComponents.DotNetBar.LabelX lblReview;
            DevComponents.DotNetBar.LabelX lblPriceDate;
            DevComponents.DotNetBar.LabelX lblNetPaymentTerm;
            DevComponents.DotNetBar.LabelX lblDueDate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelCase = new DevComponents.DotNetBar.TabControlPanel();
            this.btnCaseUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbReviews = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCaseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseMark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPaymentTerm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbOPName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCaseFactorNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseCoDepts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbCaseOwnerDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.cbCaseOpType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCaseBuyerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseCreateUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diCaseAppDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbCaseInvoiceCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnCaseBuyerSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSellerSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbCaseBuyerNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseBuyerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseFactorNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemCase = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCreditCoverNeg = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCreditCoverNegs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colNegoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetPaymentTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelCreditCoverNeg = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.diDueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diPriceDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbNetPaymentTerm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCreditCoverNegDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegNew = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegRefresh = new DevComponents.DotNetBar.ButtonX();
            this.tbCreditCoverCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCreditCoverComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbRequestType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.diRequestDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diReplyDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbIFPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbReplyAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbRequestAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemCreditCoverNeg = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCDA = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCDAs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCDACode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDACaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsRecoarse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNotice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsCreditCoverRevolving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUGProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUGPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReassignGracePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLineCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceGracePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeductibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLossThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAIFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionTypeComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFeeCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAValueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDADueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticeMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticePersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDACreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelCDA = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCDADelete = new DevComponents.DotNetBar.ButtonX();
            this.btnCDANew = new DevComponents.DotNetBar.ButtonX();
            this.btnCDARefresh = new DevComponents.DotNetBar.ButtonX();
            this.tabItemCDA = new DevComponents.DotNetBar.TabItem(this.components);
            this.caseValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator12 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator13 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator9 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator11 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.creditCoverValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
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
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIsPool = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditCoverNegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            requestAmountLabel = new DevComponents.DotNetBar.LabelX();
            replyAmountLabel = new DevComponents.DotNetBar.LabelX();
            iFPriceLabel = new DevComponents.DotNetBar.LabelX();
            replyDateLabel = new DevComponents.DotNetBar.LabelX();
            requestDateLabel = new DevComponents.DotNetBar.LabelX();
            requestTypeLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            lblCaseCoDept = new DevComponents.DotNetBar.LabelX();
            lblCaseOwnerDept = new DevComponents.DotNetBar.LabelX();
            lblCaseOpType = new DevComponents.DotNetBar.LabelX();
            lblCaseCreateUser = new DevComponents.DotNetBar.LabelX();
            lblCaseMark = new DevComponents.DotNetBar.LabelX();
            lblCaseAppDate = new DevComponents.DotNetBar.LabelX();
            lblCaseTransactionType = new DevComponents.DotNetBar.LabelX();
            lblCaseInvoiceCurrency = new DevComponents.DotNetBar.LabelX();
            lblCaseBuyerNo = new DevComponents.DotNetBar.LabelX();
            lblCaseSellerNo = new DevComponents.DotNetBar.LabelX();
            lblCaseFactor = new DevComponents.DotNetBar.LabelX();
            lblOPName = new DevComponents.DotNetBar.LabelX();
            lblPaymentTerm = new DevComponents.DotNetBar.LabelX();
            lblComment = new DevComponents.DotNetBar.LabelX();
            lblCaseCode = new DevComponents.DotNetBar.LabelX();
            lblReview = new DevComponents.DotNetBar.LabelX();
            lblPriceDate = new DevComponents.DotNetBar.LabelX();
            lblNetPaymentTerm = new DevComponents.DotNetBar.LabelX();
            lblDueDate = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelCase.SuspendLayout();
            this.groupPanelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).BeginInit();
            this.tabPanelCreditCoverNeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).BeginInit();
            this.groupPanelCreditCoverNeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPriceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRequestDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diReplyDate)).BeginInit();
            this.tabPanelCDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).BeginInit();
            this.groupPanelCDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestAmountLabel
            // 
            requestAmountLabel.AutoSize = true;
            requestAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestAmountLabel.BackgroundStyle.Class = "";
            requestAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            requestAmountLabel.Location = new System.Drawing.Point(167, 9);
            requestAmountLabel.Name = "requestAmountLabel";
            requestAmountLabel.Size = new System.Drawing.Size(57, 15);
            requestAmountLabel.TabIndex = 2;
            requestAmountLabel.Text = "<font color=\'red\'>*</font>申请额度:";
            // 
            // replyAmountLabel
            // 
            replyAmountLabel.AutoSize = true;
            replyAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            replyAmountLabel.BackgroundStyle.Class = "";
            replyAmountLabel.Location = new System.Drawing.Point(167, 34);
            replyAmountLabel.Name = "replyAmountLabel";
            replyAmountLabel.Size = new System.Drawing.Size(59, 16);
            replyAmountLabel.TabIndex = 8;
            replyAmountLabel.Text = "回复额度:";
            // 
            // iFPriceLabel
            // 
            iFPriceLabel.AutoSize = true;
            iFPriceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            iFPriceLabel.BackgroundStyle.Class = "";
            iFPriceLabel.Location = new System.Drawing.Point(13, 61);
            iFPriceLabel.Name = "iFPriceLabel";
            iFPriceLabel.Size = new System.Drawing.Size(44, 16);
            iFPriceLabel.TabIndex = 12;
            iFPriceLabel.Text = "IF报价:";
            // 
            // replyDateLabel
            // 
            replyDateLabel.AutoSize = true;
            replyDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            replyDateLabel.BackgroundStyle.Class = "";
            replyDateLabel.Location = new System.Drawing.Point(338, 34);
            replyDateLabel.Name = "replyDateLabel";
            replyDateLabel.Size = new System.Drawing.Size(59, 16);
            replyDateLabel.TabIndex = 10;
            replyDateLabel.Text = "回复日期:";
            // 
            // requestDateLabel
            // 
            requestDateLabel.AutoSize = true;
            requestDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestDateLabel.BackgroundStyle.Class = "";
            requestDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            requestDateLabel.Location = new System.Drawing.Point(0, 35);
            requestDateLabel.Name = "requestDateLabel";
            requestDateLabel.Size = new System.Drawing.Size(57, 15);
            requestDateLabel.TabIndex = 6;
            requestDateLabel.Text = "<font color=\'red\'>*</font>申请日期:";
            // 
            // requestTypeLabel
            // 
            requestTypeLabel.AutoSize = true;
            requestTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            requestTypeLabel.BackgroundStyle.Class = "";
            requestTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            requestTypeLabel.Location = new System.Drawing.Point(6, 11);
            requestTypeLabel.Name = "requestTypeLabel";
            requestTypeLabel.Size = new System.Drawing.Size(51, 15);
            requestTypeLabel.TabIndex = 0;
            requestTypeLabel.Text = "<font color=\'red\'>*</font>P/C标识:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(23, 83);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 18;
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
            createUserNameLabel.Location = new System.Drawing.Point(10, 140);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            createUserNameLabel.TabIndex = 20;
            createUserNameLabel.Text = "经办人:";
            // 
            // lblCaseCoDept
            // 
            lblCaseCoDept.AutoSize = true;
            lblCaseCoDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseCoDept.BackgroundStyle.Class = "";
            lblCaseCoDept.Location = new System.Drawing.Point(268, 175);
            lblCaseCoDept.Name = "lblCaseCoDept";
            lblCaseCoDept.Size = new System.Drawing.Size(59, 16);
            lblCaseCoDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseCoDept.TabIndex = 23;
            lblCaseCoDept.Text = "协销分部:";
            // 
            // lblCaseOwnerDept
            // 
            lblCaseOwnerDept.AutoSize = true;
            lblCaseOwnerDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseOwnerDept.BackgroundStyle.Class = "";
            lblCaseOwnerDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblCaseOwnerDept.Location = new System.Drawing.Point(5, 200);
            lblCaseOwnerDept.Name = "lblCaseOwnerDept";
            lblCaseOwnerDept.Size = new System.Drawing.Size(81, 15);
            lblCaseOwnerDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseOwnerDept.TabIndex = 25;
            lblCaseOwnerDept.Text = "<font color=\'red\'>*</font>业务归属机构:";
            // 
            // lblCaseOpType
            // 
            lblCaseOpType.AutoSize = true;
            lblCaseOpType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseOpType.BackgroundStyle.Class = "";
            lblCaseOpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblCaseOpType.Location = new System.Drawing.Point(31, 177);
            lblCaseOpType.Name = "lblCaseOpType";
            lblCaseOpType.Size = new System.Drawing.Size(57, 15);
            lblCaseOpType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseOpType.TabIndex = 21;
            lblCaseOpType.Text = "<font color=\'red\'>*</font>操作类型:";
            // 
            // lblCaseCreateUser
            // 
            lblCaseCreateUser.AutoSize = true;
            lblCaseCreateUser.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseCreateUser.BackgroundStyle.Class = "";
            lblCaseCreateUser.Location = new System.Drawing.Point(280, 266);
            lblCaseCreateUser.Name = "lblCaseCreateUser";
            lblCaseCreateUser.Size = new System.Drawing.Size(47, 16);
            lblCaseCreateUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseCreateUser.TabIndex = 35;
            lblCaseCreateUser.Text = "经办人:";
            // 
            // lblCaseMark
            // 
            lblCaseMark.AutoSize = true;
            lblCaseMark.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseMark.BackgroundStyle.Class = "";
            lblCaseMark.Location = new System.Drawing.Point(267, 245);
            lblCaseMark.Name = "lblCaseMark";
            lblCaseMark.Size = new System.Drawing.Size(57, 15);
            lblCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseMark.TabIndex = 31;
            lblCaseMark.Text = "<font color=\'red\'>*</font>案件状态:";
            // 
            // lblCaseAppDate
            // 
            lblCaseAppDate.AutoSize = true;
            lblCaseAppDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseAppDate.BackgroundStyle.Class = "";
            lblCaseAppDate.Location = new System.Drawing.Point(28, 245);
            lblCaseAppDate.Name = "lblCaseAppDate";
            lblCaseAppDate.Size = new System.Drawing.Size(57, 15);
            lblCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseAppDate.TabIndex = 29;
            lblCaseAppDate.Text = "<font color=\'red\'>*</font>申请日期:";
            // 
            // lblCaseTransactionType
            // 
            lblCaseTransactionType.AutoSize = true;
            lblCaseTransactionType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseTransactionType.BackgroundStyle.Class = "";
            lblCaseTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblCaseTransactionType.Location = new System.Drawing.Point(30, 3);
            lblCaseTransactionType.Name = "lblCaseTransactionType";
            lblCaseTransactionType.Size = new System.Drawing.Size(57, 15);
            lblCaseTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseTransactionType.TabIndex = 0;
            lblCaseTransactionType.Text = "<font color=\'red\'>*</font>业务类别:";
            // 
            // lblCaseInvoiceCurrency
            // 
            lblCaseInvoiceCurrency.AutoSize = true;
            lblCaseInvoiceCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseInvoiceCurrency.BackgroundStyle.Class = "";
            lblCaseInvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblCaseInvoiceCurrency.Location = new System.Drawing.Point(31, 155);
            lblCaseInvoiceCurrency.Name = "lblCaseInvoiceCurrency";
            lblCaseInvoiceCurrency.Size = new System.Drawing.Size(57, 15);
            lblCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseInvoiceCurrency.TabIndex = 17;
            lblCaseInvoiceCurrency.Text = "<font color=\'red\'>*</font>发票币别:";
            // 
            // lblCaseBuyerNo
            // 
            lblCaseBuyerNo.AutoSize = true;
            lblCaseBuyerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseBuyerNo.BackgroundStyle.Class = "";
            lblCaseBuyerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblCaseBuyerNo.Location = new System.Drawing.Point(53, 68);
            lblCaseBuyerNo.Name = "lblCaseBuyerNo";
            lblCaseBuyerNo.Size = new System.Drawing.Size(33, 15);
            lblCaseBuyerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseBuyerNo.TabIndex = 7;
            lblCaseBuyerNo.Text = "<font color=\'red\'>*</font>买方:";
            // 
            // lblCaseSellerNo
            // 
            lblCaseSellerNo.AutoSize = true;
            lblCaseSellerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseSellerNo.BackgroundStyle.Class = "";
            lblCaseSellerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblCaseSellerNo.Location = new System.Drawing.Point(54, 26);
            lblCaseSellerNo.Name = "lblCaseSellerNo";
            lblCaseSellerNo.Size = new System.Drawing.Size(33, 15);
            lblCaseSellerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseSellerNo.TabIndex = 2;
            lblCaseSellerNo.Text = "<font color=\'red\'>*</font>卖方:";
            // 
            // lblCaseFactor
            // 
            lblCaseFactor.AutoSize = true;
            lblCaseFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseFactor.BackgroundStyle.Class = "";
            lblCaseFactor.Location = new System.Drawing.Point(44, 110);
            lblCaseFactor.Name = "lblCaseFactor";
            lblCaseFactor.Size = new System.Drawing.Size(47, 16);
            lblCaseFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseFactor.TabIndex = 12;
            lblCaseFactor.Text = "保理商:";
            // 
            // lblOPName
            // 
            lblOPName.AutoSize = true;
            lblOPName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblOPName.BackgroundStyle.Class = "";
            lblOPName.Location = new System.Drawing.Point(37, 267);
            lblOPName.Name = "lblOPName";
            lblOPName.Size = new System.Drawing.Size(51, 16);
            lblOPName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblOPName.TabIndex = 33;
            lblOPName.Text = "OP人员:";
            // 
            // lblPaymentTerm
            // 
            lblPaymentTerm.AutoSize = true;
            lblPaymentTerm.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblPaymentTerm.BackgroundStyle.Class = "";
            lblPaymentTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblPaymentTerm.Location = new System.Drawing.Point(6, 222);
            lblPaymentTerm.Name = "lblPaymentTerm";
            lblPaymentTerm.Size = new System.Drawing.Size(84, 16);
            lblPaymentTerm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblPaymentTerm.TabIndex = 27;
            lblPaymentTerm.Text = "最长付款期限:";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblComment.BackgroundStyle.Class = "";
            lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblComment.Location = new System.Drawing.Point(55, 288);
            lblComment.Name = "lblComment";
            lblComment.Size = new System.Drawing.Size(34, 16);
            lblComment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblComment.TabIndex = 37;
            lblComment.Text = "备注:";
            // 
            // lblCaseCode
            // 
            lblCaseCode.AutoSize = true;
            lblCaseCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseCode.BackgroundStyle.Class = "";
            lblCaseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblCaseCode.Location = new System.Drawing.Point(287, 5);
            lblCaseCode.Name = "lblCaseCode";
            lblCaseCode.Size = new System.Drawing.Size(59, 16);
            lblCaseCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseCode.TabIndex = 40;
            lblCaseCode.Text = "案件编号:";
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblReview.BackgroundStyle.Class = "";
            lblReview.Location = new System.Drawing.Point(268, 224);
            lblReview.Name = "lblReview";
            lblReview.Size = new System.Drawing.Size(59, 16);
            lblReview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblReview.TabIndex = 43;
            lblReview.Text = "协查意见:";
            // 
            // lblPriceDate
            // 
            lblPriceDate.AutoSize = true;
            lblPriceDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblPriceDate.BackgroundStyle.Class = "";
            lblPriceDate.Location = new System.Drawing.Point(177, 61);
            lblPriceDate.Name = "lblPriceDate";
            lblPriceDate.Size = new System.Drawing.Size(47, 16);
            lblPriceDate.TabIndex = 14;
            lblPriceDate.Text = "报价日:";
            // 
            // lblNetPaymentTerm
            // 
            lblNetPaymentTerm.AutoSize = true;
            lblNetPaymentTerm.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblNetPaymentTerm.BackgroundStyle.Class = "";
            lblNetPaymentTerm.Location = new System.Drawing.Point(338, 8);
            lblNetPaymentTerm.Name = "lblNetPaymentTerm";
            lblNetPaymentTerm.Size = new System.Drawing.Size(59, 16);
            lblNetPaymentTerm.TabIndex = 4;
            lblNetPaymentTerm.Text = "付款条件:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblDueDate.BackgroundStyle.Class = "";
            lblDueDate.Location = new System.Drawing.Point(338, 59);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new System.Drawing.Size(59, 16);
            lblDueDate.TabIndex = 16;
            lblDueDate.Text = "额度期限:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelCase);
            this.tabControl.Controls.Add(this.tabPanelCreditCoverNeg);
            this.tabControl.Controls.Add(this.tabPanelCDA);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(521, 424);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemCase);
            this.tabControl.Tabs.Add(this.tabItemCreditCoverNeg);
            this.tabControl.Tabs.Add(this.tabItemCDA);
            this.tabControl.Text = "tabControl1";
            // 
            // tabPanelCase
            // 
            this.tabPanelCase.Controls.Add(this.btnCaseUpdate);
            this.tabPanelCase.Controls.Add(this.btnCaseSave);
            this.tabPanelCase.Controls.Add(this.groupPanelCase);
            this.tabPanelCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCase.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCase.Name = "tabPanelCase";
            this.tabPanelCase.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCase.Size = new System.Drawing.Size(521, 398);
            this.tabPanelCase.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelCase.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelCase.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelCase.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelCase.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelCase.Style.GradientAngle = 90;
            this.tabPanelCase.TabIndex = 1;
            this.tabPanelCase.TabItem = this.tabItemCase;
            // 
            // btnCaseUpdate
            // 
            this.btnCaseUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseUpdate.Location = new System.Drawing.Point(181, 363);
            this.btnCaseUpdate.Name = "btnCaseUpdate";
            this.btnCaseUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCaseUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseUpdate.TabIndex = 1;
            this.btnCaseUpdate.Text = "编辑";
            this.btnCaseUpdate.Click += new System.EventHandler(this.UpdateCase);
            // 
            // btnCaseSave
            // 
            this.btnCaseSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSave.Location = new System.Drawing.Point(262, 363);
            this.btnCaseSave.Name = "btnCaseSave";
            this.btnCaseSave.Size = new System.Drawing.Size(75, 23);
            this.btnCaseSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSave.TabIndex = 2;
            this.btnCaseSave.Text = "保存";
            this.btnCaseSave.Click += new System.EventHandler(this.SaveCase);
            // 
            // groupPanelCase
            // 
            this.groupPanelCase.AutoScroll = true;
            this.groupPanelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelCase.Controls.Add(this.cbIsPool);
            this.groupPanelCase.Controls.Add(lblReview);
            this.groupPanelCase.Controls.Add(this.cbReviews);
            this.groupPanelCase.Controls.Add(this.tbCaseCode);
            this.groupPanelCase.Controls.Add(lblCaseCode);
            this.groupPanelCase.Controls.Add(this.cbCaseMark);
            this.groupPanelCase.Controls.Add(this.tbComment);
            this.groupPanelCase.Controls.Add(lblComment);
            this.groupPanelCase.Controls.Add(this.tbPaymentTerm);
            this.groupPanelCase.Controls.Add(lblPaymentTerm);
            this.groupPanelCase.Controls.Add(this.tbOPName);
            this.groupPanelCase.Controls.Add(lblOPName);
            this.groupPanelCase.Controls.Add(this.cbCaseTransactionType);
            this.groupPanelCase.Controls.Add(this.tbCaseFactorNameEN);
            this.groupPanelCase.Controls.Add(this.cbCaseCoDepts);
            this.groupPanelCase.Controls.Add(lblCaseCoDept);
            this.groupPanelCase.Controls.Add(this.cbCaseOwnerDepts);
            this.groupPanelCase.Controls.Add(lblCaseOwnerDept);
            this.groupPanelCase.Controls.Add(this.cbCaseOpType);
            this.groupPanelCase.Controls.Add(lblCaseOpType);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNameEN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNameEN);
            this.groupPanelCase.Controls.Add(this.tbCaseCreateUser);
            this.groupPanelCase.Controls.Add(lblCaseCreateUser);
            this.groupPanelCase.Controls.Add(lblCaseMark);
            this.groupPanelCase.Controls.Add(this.diCaseAppDate);
            this.groupPanelCase.Controls.Add(lblCaseAppDate);
            this.groupPanelCase.Controls.Add(lblCaseTransactionType);
            this.groupPanelCase.Controls.Add(this.cbCaseInvoiceCurrency);
            this.groupPanelCase.Controls.Add(lblCaseInvoiceCurrency);
            this.groupPanelCase.Controls.Add(this.btnCaseBuyerSelect);
            this.groupPanelCase.Controls.Add(this.btnCaseSellerSelect);
            this.groupPanelCase.Controls.Add(this.btnCaseFactorSelect);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNo);
            this.groupPanelCase.Controls.Add(lblCaseBuyerNo);
            this.groupPanelCase.Controls.Add(this.tbCaseFactorNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseFactorCode);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNo);
            this.groupPanelCase.Controls.Add(lblCaseSellerNo);
            this.groupPanelCase.Controls.Add(lblCaseFactor);
            this.groupPanelCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCase.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCase.Name = "groupPanelCase";
            this.groupPanelCase.Size = new System.Drawing.Size(519, 356);
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
            // cbReviews
            // 
            this.cbReviews.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReviews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReviews.FormattingEnabled = true;
            this.cbReviews.ItemHeight = 14;
            this.cbReviews.Location = new System.Drawing.Point(336, 222);
            this.cbReviews.Name = "cbReviews";
            this.cbReviews.Size = new System.Drawing.Size(137, 20);
            this.cbReviews.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbReviews.TabIndex = 42;
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseCode", true));
            this.tbCaseCode.Location = new System.Drawing.Point(352, 3);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.ReadOnly = true;
            this.tbCaseCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCaseCode.Size = new System.Drawing.Size(121, 20);
            this.tbCaseCode.TabIndex = 41;
            // 
            // cbCaseMark
            // 
            this.cbCaseMark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseMark", true));
            this.cbCaseMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseMark.FormattingEnabled = true;
            this.cbCaseMark.ItemHeight = 14;
            this.cbCaseMark.Items.AddRange(new object[] {
            "申请案",
            "启动案",
            "已结案"});
            this.cbCaseMark.Location = new System.Drawing.Point(336, 244);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(137, 20);
            this.cbCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseMark.TabIndex = 39;
            this.caseValidator.SetValidator1(this.cbCaseMark, this.requiredFieldValidator3);
            // 
            // tbComment
            // 
            // 
            // 
            // 
            this.tbComment.Border.Class = "TextBoxBorder";
            this.tbComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Comment", true));
            this.tbComment.Location = new System.Drawing.Point(98, 288);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbComment.Size = new System.Drawing.Size(375, 59);
            this.tbComment.TabIndex = 38;
            // 
            // tbPaymentTerm
            // 
            // 
            // 
            // 
            this.tbPaymentTerm.Border.Class = "TextBoxBorder";
            this.tbPaymentTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "NetPaymentTerm", true));
            this.tbPaymentTerm.Location = new System.Drawing.Point(98, 222);
            this.tbPaymentTerm.Name = "tbPaymentTerm";
            this.tbPaymentTerm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPaymentTerm.Size = new System.Drawing.Size(121, 20);
            this.tbPaymentTerm.TabIndex = 28;
            // 
            // tbOPName
            // 
            // 
            // 
            // 
            this.tbOPName.Border.Class = "TextBoxBorder";
            this.tbOPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "OPName", true));
            this.tbOPName.Location = new System.Drawing.Point(98, 265);
            this.tbOPName.Name = "tbOPName";
            this.tbOPName.Size = new System.Drawing.Size(121, 20);
            this.tbOPName.TabIndex = 34;
            this.caseValidator.SetValidator1(this.tbOPName, this.regularExpressionValidator2);
            // 
            // cbCaseTransactionType
            // 
            this.cbCaseTransactionType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "TransactionType", true));
            this.cbCaseTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseTransactionType.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbCaseTransactionType.FormattingEnabled = true;
            this.cbCaseTransactionType.Items.AddRange(new object[] {
            "国内卖方保理",
            "国内买方保理",
            "出口保理",
            "进口保理",
            "国内信保保理",
            "国际信保保理",
            "租赁保理"});
            this.cbCaseTransactionType.Location = new System.Drawing.Point(100, 0);
            this.cbCaseTransactionType.Name = "cbCaseTransactionType";
            this.cbCaseTransactionType.Size = new System.Drawing.Size(124, 21);
            this.cbCaseTransactionType.TabIndex = 1;
            this.caseValidator.SetValidator1(this.cbCaseTransactionType, this.requiredFieldValidator1);
            this.cbCaseTransactionType.SelectionChangeCommitted += new System.EventHandler(this.CaseTransactionTypeChanged);
            // 
            // tbCaseFactorNameEN
            // 
            // 
            // 
            // 
            this.tbCaseFactorNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseFactorNameEN.Location = new System.Drawing.Point(180, 131);
            this.tbCaseFactorNameEN.Name = "tbCaseFactorNameEN";
            this.tbCaseFactorNameEN.ReadOnly = true;
            this.tbCaseFactorNameEN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseFactorNameEN.TabIndex = 15;
            this.tbCaseFactorNameEN.WatermarkText = "英文名";
            // 
            // cbCaseCoDepts
            // 
            this.cbCaseCoDepts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.caseBindingSource, "CoDepartment", true));
            this.cbCaseCoDepts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseCoDepts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseCoDepts.FormattingEnabled = true;
            this.cbCaseCoDepts.Location = new System.Drawing.Point(336, 172);
            this.cbCaseCoDepts.Name = "cbCaseCoDepts";
            this.cbCaseCoDepts.Size = new System.Drawing.Size(137, 21);
            this.cbCaseCoDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseCoDepts.TabIndex = 24;
            // 
            // cbCaseOwnerDepts
            // 
            this.cbCaseOwnerDepts.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbCaseOwnerDepts.BackgroundStyle.Class = "TextBoxBorder";
            this.cbCaseOwnerDepts.ButtonDropDown.Visible = true;
            this.cbCaseOwnerDepts.Location = new System.Drawing.Point(98, 197);
            this.cbCaseOwnerDepts.Name = "cbCaseOwnerDepts";
            this.cbCaseOwnerDepts.Size = new System.Drawing.Size(278, 23);
            this.cbCaseOwnerDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseOwnerDepts.TabIndex = 26;
            this.caseValidator.SetValidator1(this.cbCaseOwnerDepts, this.requiredFieldValidator4);
            this.cbCaseOwnerDepts.SelectionChanged += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.CaseOwnerDeptsChanged);
            // 
            // cbCaseOpType
            // 
            this.cbCaseOpType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "OperationType", true));
            this.cbCaseOpType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseOpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseOpType.FormattingEnabled = true;
            this.cbCaseOpType.ItemHeight = 14;
            this.cbCaseOpType.Items.AddRange(new object[] {
            "自营",
            "协销",
            "其他",
            "未知"});
            this.cbCaseOpType.Location = new System.Drawing.Point(98, 175);
            this.cbCaseOpType.Name = "cbCaseOpType";
            this.cbCaseOpType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseOpType.TabIndex = 22;
            this.caseValidator.SetValidator1(this.cbCaseOpType, this.requiredFieldValidator3);
            this.cbCaseOpType.SelectionChangeCommitted += new System.EventHandler(this.CaseOpTypeChanged);
            // 
            // tbCaseBuyerNameEN
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientNameEN", true));
            this.tbCaseBuyerNameEN.Location = new System.Drawing.Point(180, 88);
            this.tbCaseBuyerNameEN.Name = "tbCaseBuyerNameEN";
            this.tbCaseBuyerNameEN.ReadOnly = true;
            this.tbCaseBuyerNameEN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseBuyerNameEN.TabIndex = 10;
            this.tbCaseBuyerNameEN.WatermarkText = "英文名";
            this.tbCaseBuyerNameEN.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // tbCaseSellerNameEN
            // 
            // 
            // 
            // 
            this.tbCaseSellerNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientNameEN", true));
            this.tbCaseSellerNameEN.Location = new System.Drawing.Point(180, 46);
            this.tbCaseSellerNameEN.Name = "tbCaseSellerNameEN";
            this.tbCaseSellerNameEN.ReadOnly = true;
            this.tbCaseSellerNameEN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseSellerNameEN.TabIndex = 5;
            this.tbCaseSellerNameEN.WatermarkText = "英文名";
            this.tbCaseSellerNameEN.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // tbCaseCreateUser
            // 
            // 
            // 
            // 
            this.tbCaseCreateUser.Border.Class = "TextBoxBorder";
            this.tbCaseCreateUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CreateUserName", true));
            this.tbCaseCreateUser.Location = new System.Drawing.Point(336, 265);
            this.tbCaseCreateUser.Name = "tbCaseCreateUser";
            this.tbCaseCreateUser.ReadOnly = true;
            this.tbCaseCreateUser.Size = new System.Drawing.Size(137, 20);
            this.tbCaseCreateUser.TabIndex = 36;
            this.caseValidator.SetValidator1(this.tbCaseCreateUser, this.requiredFieldValidator12);
            // 
            // diCaseAppDate
            // 
            // 
            // 
            // 
            this.diCaseAppDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diCaseAppDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diCaseAppDate.ButtonDropDown.Visible = true;
            this.diCaseAppDate.ButtonFreeText.Checked = true;
            this.diCaseAppDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseAppDate", true));
            this.diCaseAppDate.FocusHighlightEnabled = true;
            this.diCaseAppDate.FreeTextEntryMode = true;
            this.diCaseAppDate.Location = new System.Drawing.Point(99, 244);
            // 
            // 
            // 
            this.diCaseAppDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diCaseAppDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diCaseAppDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diCaseAppDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diCaseAppDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diCaseAppDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diCaseAppDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diCaseAppDate.MonthCalendar.TodayButtonVisible = true;
            this.diCaseAppDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diCaseAppDate.Name = "diCaseAppDate";
            this.diCaseAppDate.Size = new System.Drawing.Size(120, 20);
            this.diCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diCaseAppDate.TabIndex = 30;
            this.caseValidator.SetValidator1(this.diCaseAppDate, this.requiredFieldValidator13);
            // 
            // cbCaseInvoiceCurrency
            // 
            this.cbCaseInvoiceCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCaseInvoiceCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCaseInvoiceCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caseBindingSource, "InvoiceCurrency", true));
            this.cbCaseInvoiceCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseInvoiceCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseInvoiceCurrency.ItemHeight = 14;
            this.cbCaseInvoiceCurrency.Location = new System.Drawing.Point(98, 153);
            this.cbCaseInvoiceCurrency.Name = "cbCaseInvoiceCurrency";
            this.cbCaseInvoiceCurrency.Size = new System.Drawing.Size(100, 20);
            this.cbCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseInvoiceCurrency.TabIndex = 18;
            // 
            // btnCaseBuyerSelect
            // 
            this.btnCaseBuyerSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseBuyerSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseBuyerSelect.Location = new System.Drawing.Point(479, 68);
            this.btnCaseBuyerSelect.Name = "btnCaseBuyerSelect";
            this.btnCaseBuyerSelect.Size = new System.Drawing.Size(20, 19);
            this.btnCaseBuyerSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseBuyerSelect.TabIndex = 11;
            this.btnCaseBuyerSelect.Text = "...";
            this.btnCaseBuyerSelect.Click += new System.EventHandler(this.SelectCaseBuyer);
            // 
            // btnCaseSellerSelect
            // 
            this.btnCaseSellerSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSellerSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSellerSelect.Location = new System.Drawing.Point(479, 25);
            this.btnCaseSellerSelect.Name = "btnCaseSellerSelect";
            this.btnCaseSellerSelect.Size = new System.Drawing.Size(20, 20);
            this.btnCaseSellerSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSellerSelect.TabIndex = 6;
            this.btnCaseSellerSelect.Text = "...";
            this.btnCaseSellerSelect.Click += new System.EventHandler(this.SelectCaseSeller);
            // 
            // btnCaseFactorSelect
            // 
            this.btnCaseFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseFactorSelect.Location = new System.Drawing.Point(479, 109);
            this.btnCaseFactorSelect.Name = "btnCaseFactorSelect";
            this.btnCaseFactorSelect.Size = new System.Drawing.Size(20, 20);
            this.btnCaseFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseFactorSelect.TabIndex = 16;
            this.btnCaseFactorSelect.Text = "...";
            this.btnCaseFactorSelect.Click += new System.EventHandler(this.SelectFactor);
            // 
            // tbCaseBuyerNameCN
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNameCN.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientNameCN", true));
            this.tbCaseBuyerNameCN.Location = new System.Drawing.Point(180, 67);
            this.tbCaseBuyerNameCN.Name = "tbCaseBuyerNameCN";
            this.tbCaseBuyerNameCN.ReadOnly = true;
            this.tbCaseBuyerNameCN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseBuyerNameCN.TabIndex = 9;
            this.tbCaseBuyerNameCN.WatermarkText = "中文名";
            this.tbCaseBuyerNameCN.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // tbCaseBuyerNo
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNo.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientEDICode", true));
            this.tbCaseBuyerNo.Location = new System.Drawing.Point(98, 67);
            this.tbCaseBuyerNo.Name = "tbCaseBuyerNo";
            this.tbCaseBuyerNo.ReadOnly = true;
            this.tbCaseBuyerNo.Size = new System.Drawing.Size(76, 20);
            this.tbCaseBuyerNo.TabIndex = 8;
            this.caseValidator.SetValidator1(this.tbCaseBuyerNo, this.requiredFieldValidator9);
            this.tbCaseBuyerNo.WatermarkText = "保理代码";
            this.tbCaseBuyerNo.DoubleClick += new System.EventHandler(this.DetailBuyer);
            // 
            // tbCaseFactorNameCN
            // 
            // 
            // 
            // 
            this.tbCaseFactorNameCN.Border.Class = "TextBoxBorder";
            this.tbCaseFactorNameCN.Location = new System.Drawing.Point(180, 109);
            this.tbCaseFactorNameCN.Name = "tbCaseFactorNameCN";
            this.tbCaseFactorNameCN.ReadOnly = true;
            this.tbCaseFactorNameCN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseFactorNameCN.TabIndex = 14;
            this.tbCaseFactorNameCN.WatermarkText = "中文名";
            // 
            // tbCaseFactorCode
            // 
            // 
            // 
            // 
            this.tbCaseFactorCode.Border.Class = "TextBoxBorder";
            this.tbCaseFactorCode.Location = new System.Drawing.Point(99, 109);
            this.tbCaseFactorCode.Name = "tbCaseFactorCode";
            this.tbCaseFactorCode.ReadOnly = true;
            this.tbCaseFactorCode.Size = new System.Drawing.Size(75, 20);
            this.tbCaseFactorCode.TabIndex = 13;
            this.caseValidator.SetValidator1(this.tbCaseFactorCode, this.customValidator1);
            this.tbCaseFactorCode.WatermarkText = "保理代码";
            this.tbCaseFactorCode.DoubleClick += new System.EventHandler(this.DetailFactor);
            // 
            // tbCaseSellerNameCN
            // 
            // 
            // 
            // 
            this.tbCaseSellerNameCN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientNameCN", true));
            this.tbCaseSellerNameCN.Location = new System.Drawing.Point(180, 25);
            this.tbCaseSellerNameCN.Name = "tbCaseSellerNameCN";
            this.tbCaseSellerNameCN.ReadOnly = true;
            this.tbCaseSellerNameCN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseSellerNameCN.TabIndex = 4;
            this.tbCaseSellerNameCN.WatermarkText = "中文名";
            this.tbCaseSellerNameCN.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // tbCaseSellerNo
            // 
            // 
            // 
            // 
            this.tbCaseSellerNo.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientEDICode", true));
            this.tbCaseSellerNo.Location = new System.Drawing.Point(100, 25);
            this.tbCaseSellerNo.Name = "tbCaseSellerNo";
            this.tbCaseSellerNo.ReadOnly = true;
            this.tbCaseSellerNo.Size = new System.Drawing.Size(74, 20);
            this.tbCaseSellerNo.TabIndex = 3;
            this.caseValidator.SetValidator1(this.tbCaseSellerNo, this.requiredFieldValidator7);
            this.tbCaseSellerNo.WatermarkText = "保理代码";
            this.tbCaseSellerNo.DoubleClick += new System.EventHandler(this.DetailSeller);
            // 
            // tabItemCase
            // 
            this.tabItemCase.AttachedControl = this.tabPanelCase;
            this.tabItemCase.Name = "tabItemCase";
            this.tabItemCase.Text = "案件信息";
            // 
            // tabPanelCreditCoverNeg
            // 
            this.tabPanelCreditCoverNeg.Controls.Add(this.dgvCreditCoverNegs);
            this.tabPanelCreditCoverNeg.Controls.Add(this.groupPanelCreditCoverNeg);
            this.tabPanelCreditCoverNeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCreditCoverNeg.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCreditCoverNeg.Name = "tabPanelCreditCoverNeg";
            this.tabPanelCreditCoverNeg.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCreditCoverNeg.Size = new System.Drawing.Size(521, 398);
            this.tabPanelCreditCoverNeg.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelCreditCoverNeg.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelCreditCoverNeg.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelCreditCoverNeg.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelCreditCoverNeg.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelCreditCoverNeg.Style.GradientAngle = 90;
            this.tabPanelCreditCoverNeg.TabIndex = 2;
            this.tabPanelCreditCoverNeg.TabItem = this.tabItemCreditCoverNeg;
            // 
            // dgvCreditCoverNegs
            // 
            this.dgvCreditCoverNegs.AllowUserToAddRows = false;
            this.dgvCreditCoverNegs.AllowUserToDeleteRows = false;
            this.dgvCreditCoverNegs.AllowUserToOrderColumns = true;
            this.dgvCreditCoverNegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditCoverNegs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNegoID,
            this.colCaseCode,
            this.colRequestType,
            this.colRequestAmount,
            this.colNetPaymentTerm,
            this.colRequestDate,
            this.colReplyAmount,
            this.colReplyDate,
            this.colIFPrice,
            this.colPriceDate,
            this.colDueDate,
            this.colCreateUserName,
            this.colComment});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCoverNegs.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCreditCoverNegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditCoverNegs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCreditCoverNegs.Location = new System.Drawing.Point(1, 199);
            this.dgvCreditCoverNegs.Name = "dgvCreditCoverNegs";
            this.dgvCreditCoverNegs.ReadOnly = true;
            this.dgvCreditCoverNegs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditCoverNegs.Size = new System.Drawing.Size(519, 198);
            this.dgvCreditCoverNegs.TabIndex = 0;
            this.dgvCreditCoverNegs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCreditCoverNeg);
            // 
            // colNegoID
            // 
            this.colNegoID.DataPropertyName = "NegoID";
            this.colNegoID.HeaderText = "额度申请号";
            this.colNegoID.Name = "colNegoID";
            this.colNegoID.ReadOnly = true;
            this.colNegoID.Visible = false;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            // 
            // colRequestType
            // 
            this.colRequestType.DataPropertyName = "RequestType";
            this.colRequestType.HeaderText = "P/C标志";
            this.colRequestType.Name = "colRequestType";
            this.colRequestType.ReadOnly = true;
            // 
            // colRequestAmount
            // 
            this.colRequestAmount.DataPropertyName = "RequestAmount";
            this.colRequestAmount.HeaderText = "申请额度";
            this.colRequestAmount.Name = "colRequestAmount";
            this.colRequestAmount.ReadOnly = true;
            // 
            // colNetPaymentTerm
            // 
            this.colNetPaymentTerm.DataPropertyName = "NetPaymentTerm";
            this.colNetPaymentTerm.HeaderText = "付款条件";
            this.colNetPaymentTerm.Name = "colNetPaymentTerm";
            this.colNetPaymentTerm.ReadOnly = true;
            // 
            // colRequestDate
            // 
            this.colRequestDate.DataPropertyName = "RequestDate";
            dataGridViewCellStyle12.Format = "d";
            this.colRequestDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.colRequestDate.HeaderText = "申请日期";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;
            // 
            // colReplyAmount
            // 
            this.colReplyAmount.DataPropertyName = "ReplyAmount";
            this.colReplyAmount.HeaderText = "回复额度";
            this.colReplyAmount.Name = "colReplyAmount";
            this.colReplyAmount.ReadOnly = true;
            // 
            // colReplyDate
            // 
            this.colReplyDate.DataPropertyName = "ReplyDate";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.colReplyDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.colReplyDate.HeaderText = "回复日期";
            this.colReplyDate.Name = "colReplyDate";
            this.colReplyDate.ReadOnly = true;
            // 
            // colIFPrice
            // 
            this.colIFPrice.DataPropertyName = "IFPrice";
            this.colIFPrice.HeaderText = "IF报价";
            this.colIFPrice.Name = "colIFPrice";
            this.colIFPrice.ReadOnly = true;
            // 
            // colPriceDate
            // 
            this.colPriceDate.DataPropertyName = "PriceDate";
            dataGridViewCellStyle14.Format = "d";
            this.colPriceDate.DefaultCellStyle = dataGridViewCellStyle14;
            this.colPriceDate.HeaderText = "报价日";
            this.colPriceDate.Name = "colPriceDate";
            this.colPriceDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle15.Format = "d";
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle15;
            this.colDueDate.HeaderText = "额度期限";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // groupPanelCreditCoverNeg
            // 
            this.groupPanelCreditCoverNeg.AutoScroll = true;
            this.groupPanelCreditCoverNeg.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCreditCoverNeg.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCreditCoverNeg.Controls.Add(this.diDueDate);
            this.groupPanelCreditCoverNeg.Controls.Add(lblPriceDate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diPriceDate);
            this.groupPanelCreditCoverNeg.Controls.Add(lblNetPaymentTerm);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbNetPaymentTerm);
            this.groupPanelCreditCoverNeg.Controls.Add(lblDueDate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegDelete);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegSave);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegUpdate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegNew);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegRefresh);
            this.groupPanelCreditCoverNeg.Controls.Add(createUserNameLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbCreditCoverCreateUserName);
            this.groupPanelCreditCoverNeg.Controls.Add(commentLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbCreditCoverComment);
            this.groupPanelCreditCoverNeg.Controls.Add(requestTypeLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.cbRequestType);
            this.groupPanelCreditCoverNeg.Controls.Add(requestDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diRequestDate);
            this.groupPanelCreditCoverNeg.Controls.Add(replyDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diReplyDate);
            this.groupPanelCreditCoverNeg.Controls.Add(iFPriceLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbIFPrice);
            this.groupPanelCreditCoverNeg.Controls.Add(replyAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbReplyAmount);
            this.groupPanelCreditCoverNeg.Controls.Add(requestAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbRequestAmount);
            this.groupPanelCreditCoverNeg.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditCoverNeg.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCreditCoverNeg.Name = "groupPanelCreditCoverNeg";
            this.groupPanelCreditCoverNeg.Size = new System.Drawing.Size(519, 198);
            // 
            // 
            // 
            this.groupPanelCreditCoverNeg.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelCreditCoverNeg.Style.BackColorGradientAngle = 90;
            this.groupPanelCreditCoverNeg.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelCreditCoverNeg.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCoverNeg.Style.BorderBottomWidth = 1;
            this.groupPanelCreditCoverNeg.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelCreditCoverNeg.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCoverNeg.Style.BorderLeftWidth = 1;
            this.groupPanelCreditCoverNeg.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCoverNeg.Style.BorderRightWidth = 1;
            this.groupPanelCreditCoverNeg.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCreditCoverNeg.Style.BorderTopWidth = 1;
            this.groupPanelCreditCoverNeg.Style.Class = "";
            this.groupPanelCreditCoverNeg.Style.CornerDiameter = 4;
            this.groupPanelCreditCoverNeg.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCreditCoverNeg.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCreditCoverNeg.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCreditCoverNeg.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCreditCoverNeg.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelCreditCoverNeg.StyleMouseOver.Class = "";
            this.groupPanelCreditCoverNeg.TabIndex = 1;
            // 
            // diDueDate
            // 
            // 
            // 
            // 
            this.diDueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diDueDate.ButtonDropDown.Visible = true;
            this.diDueDate.ButtonFreeText.Checked = true;
            this.diDueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "DueDate", true));
            this.diDueDate.FreeTextEntryMode = true;
            this.diDueDate.Location = new System.Drawing.Point(404, 58);
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diDueDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diDueDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diDueDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diDueDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diDueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diDueDate.Name = "diDueDate";
            this.diDueDate.Size = new System.Drawing.Size(103, 20);
            this.diDueDate.TabIndex = 17;
            // 
            // diPriceDate
            // 
            // 
            // 
            // 
            this.diPriceDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diPriceDate.ButtonDropDown.Visible = true;
            this.diPriceDate.ButtonFreeText.Checked = true;
            this.diPriceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "PriceDate", true));
            this.diPriceDate.FreeTextEntryMode = true;
            this.diPriceDate.Location = new System.Drawing.Point(230, 57);
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diPriceDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diPriceDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diPriceDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diPriceDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diPriceDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diPriceDate.Name = "diPriceDate";
            this.diPriceDate.Size = new System.Drawing.Size(103, 20);
            this.diPriceDate.TabIndex = 15;
            // 
            // tbNetPaymentTerm
            // 
            // 
            // 
            // 
            this.tbNetPaymentTerm.Border.Class = "TextBoxBorder";
            this.tbNetPaymentTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "NetPaymentTerm", true));
            this.tbNetPaymentTerm.Location = new System.Drawing.Point(403, 6);
            this.tbNetPaymentTerm.Name = "tbNetPaymentTerm";
            this.tbNetPaymentTerm.Size = new System.Drawing.Size(100, 20);
            this.tbNetPaymentTerm.TabIndex = 5;
            // 
            // btnCreditCoverNegDelete
            // 
            this.btnCreditCoverNegDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegDelete.Location = new System.Drawing.Point(398, 162);
            this.btnCreditCoverNegDelete.Name = "btnCreditCoverNegDelete";
            this.btnCreditCoverNegDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegDelete.TabIndex = 26;
            this.btnCreditCoverNegDelete.Text = "删除";
            this.btnCreditCoverNegDelete.Click += new System.EventHandler(this.DeleteCreditCoverNeg);
            // 
            // btnCreditCoverNegSave
            // 
            this.btnCreditCoverNegSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegSave.Location = new System.Drawing.Point(317, 162);
            this.btnCreditCoverNegSave.Name = "btnCreditCoverNegSave";
            this.btnCreditCoverNegSave.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegSave.TabIndex = 25;
            this.btnCreditCoverNegSave.Text = "保存";
            this.btnCreditCoverNegSave.Click += new System.EventHandler(this.SaveCreditCoverNeg);
            // 
            // btnCreditCoverNegUpdate
            // 
            this.btnCreditCoverNegUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegUpdate.Location = new System.Drawing.Point(236, 162);
            this.btnCreditCoverNegUpdate.Name = "btnCreditCoverNegUpdate";
            this.btnCreditCoverNegUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegUpdate.TabIndex = 24;
            this.btnCreditCoverNegUpdate.Text = "编辑";
            this.btnCreditCoverNegUpdate.Click += new System.EventHandler(this.UpdateCreditCoverNeg);
            // 
            // btnCreditCoverNegNew
            // 
            this.btnCreditCoverNegNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegNew.Location = new System.Drawing.Point(155, 162);
            this.btnCreditCoverNegNew.Name = "btnCreditCoverNegNew";
            this.btnCreditCoverNegNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegNew.TabIndex = 23;
            this.btnCreditCoverNegNew.Text = "新建";
            this.btnCreditCoverNegNew.Click += new System.EventHandler(this.NewCreditCoverNeg);
            // 
            // btnCreditCoverNegRefresh
            // 
            this.btnCreditCoverNegRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegRefresh.Location = new System.Drawing.Point(74, 162);
            this.btnCreditCoverNegRefresh.Name = "btnCreditCoverNegRefresh";
            this.btnCreditCoverNegRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegRefresh.TabIndex = 22;
            this.btnCreditCoverNegRefresh.Text = "刷新";
            this.btnCreditCoverNegRefresh.Click += new System.EventHandler(this.RefreshCreditCoverNegList);
            // 
            // tbCreditCoverCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreditCoverCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreditCoverCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "CreateUserName", true));
            this.tbCreditCoverCreateUserName.Location = new System.Drawing.Point(61, 136);
            this.tbCreditCoverCreateUserName.Name = "tbCreditCoverCreateUserName";
            this.tbCreditCoverCreateUserName.ReadOnly = true;
            this.tbCreditCoverCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCreditCoverCreateUserName.TabIndex = 21;
            // 
            // tbCreditCoverComment
            // 
            // 
            // 
            // 
            this.tbCreditCoverComment.Border.Class = "";
            this.tbCreditCoverComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "Comment", true));
            this.tbCreditCoverComment.Location = new System.Drawing.Point(61, 84);
            this.tbCreditCoverComment.Multiline = true;
            this.tbCreditCoverComment.Name = "tbCreditCoverComment";
            this.tbCreditCoverComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCreditCoverComment.Size = new System.Drawing.Size(442, 46);
            this.tbCreditCoverComment.TabIndex = 19;
            // 
            // cbRequestType
            // 
            this.cbRequestType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "RequestType", true));
            this.cbRequestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequestType.FormattingEnabled = true;
            this.cbRequestType.Items.AddRange(new object[] {
            "P-预额度",
            "C-正式额度"});
            this.cbRequestType.Location = new System.Drawing.Point(61, 6);
            this.cbRequestType.Name = "cbRequestType";
            this.cbRequestType.Size = new System.Drawing.Size(100, 21);
            this.cbRequestType.TabIndex = 1;
            this.creditCoverValidator.SetValidator1(this.cbRequestType, this.requiredFieldValidator8);
            // 
            // diRequestDate
            // 
            // 
            // 
            // 
            this.diRequestDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diRequestDate.ButtonDropDown.Visible = true;
            this.diRequestDate.ButtonFreeText.Checked = true;
            this.diRequestDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "RequestDate", true));
            this.diRequestDate.FreeTextEntryMode = true;
            this.diRequestDate.Location = new System.Drawing.Point(61, 33);
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diRequestDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diRequestDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diRequestDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diRequestDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diRequestDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diRequestDate.Name = "diRequestDate";
            this.diRequestDate.Size = new System.Drawing.Size(103, 20);
            this.diRequestDate.TabIndex = 7;
            this.creditCoverValidator.SetValidator1(this.diRequestDate, this.requiredFieldValidator6);
            // 
            // diReplyDate
            // 
            // 
            // 
            // 
            this.diReplyDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diReplyDate.ButtonDropDown.Visible = true;
            this.diReplyDate.ButtonFreeText.Checked = true;
            this.diReplyDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "ReplyDate", true));
            this.diReplyDate.FreeTextEntryMode = true;
            this.diReplyDate.Location = new System.Drawing.Point(404, 31);
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diReplyDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diReplyDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diReplyDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diReplyDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diReplyDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diReplyDate.Name = "diReplyDate";
            this.diReplyDate.Size = new System.Drawing.Size(103, 20);
            this.diReplyDate.TabIndex = 11;
            // 
            // tbIFPrice
            // 
            // 
            // 
            // 
            this.tbIFPrice.Border.Class = "TextBoxBorder";
            this.tbIFPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "IFPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbIFPrice.Location = new System.Drawing.Point(61, 58);
            this.tbIFPrice.Name = "tbIFPrice";
            this.tbIFPrice.Size = new System.Drawing.Size(100, 20);
            this.tbIFPrice.TabIndex = 13;
            // 
            // tbReplyAmount
            // 
            // 
            // 
            // 
            this.tbReplyAmount.Border.Class = "TextBoxBorder";
            this.tbReplyAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "ReplyAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbReplyAmount.Location = new System.Drawing.Point(230, 32);
            this.tbReplyAmount.Name = "tbReplyAmount";
            this.tbReplyAmount.Size = new System.Drawing.Size(100, 20);
            this.tbReplyAmount.TabIndex = 9;
            // 
            // tbRequestAmount
            // 
            // 
            // 
            // 
            this.tbRequestAmount.Border.Class = "TextBoxBorder";
            this.tbRequestAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "RequestAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbRequestAmount.Location = new System.Drawing.Point(230, 7);
            this.tbRequestAmount.Name = "tbRequestAmount";
            this.tbRequestAmount.Size = new System.Drawing.Size(100, 20);
            this.tbRequestAmount.TabIndex = 3;
            this.creditCoverValidator.SetValidator1(this.tbRequestAmount, this.requiredFieldValidator5);
            // 
            // tabItemCreditCoverNeg
            // 
            this.tabItemCreditCoverNeg.AttachedControl = this.tabPanelCreditCoverNeg;
            this.tabItemCreditCoverNeg.Name = "tabItemCreditCoverNeg";
            this.tabItemCreditCoverNeg.Text = "额度申请信息";
            // 
            // tabPanelCDA
            // 
            this.tabPanelCDA.Controls.Add(this.dgvCDAs);
            this.tabPanelCDA.Controls.Add(this.groupPanelCDA);
            this.tabPanelCDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCDA.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCDA.Name = "tabPanelCDA";
            this.tabPanelCDA.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCDA.Size = new System.Drawing.Size(521, 398);
            this.tabPanelCDA.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelCDA.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelCDA.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelCDA.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelCDA.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelCDA.Style.GradientAngle = 90;
            this.tabPanelCDA.TabIndex = 3;
            this.tabPanelCDA.TabItem = this.tabItemCDA;
            // 
            // dgvCDAs
            // 
            this.dgvCDAs.AllowUserToAddRows = false;
            this.dgvCDAs.AllowUserToDeleteRows = false;
            this.dgvCDAs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCDAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCDAs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCDACode,
            this.colCDACaseCode,
            this.colIsRecoarse,
            this.colIsNotice,
            this.colAssignType,
            this.colCreditCoverCurr,
            this.colCreditCover,
            this.colIsCreditCoverRevolving,
            this.colApproveNumber,
            this.colPUGProportion,
            this.colCreditCoverPeriodBegin,
            this.colCreditCoverPeriodEnd,
            this.colPUGPeriod,
            this.colReassignGracePeriod,
            this.colFinanceLineCurr,
            this.colFinanceLine,
            this.colFinanceLinePeriodBegin,
            this.colFinanceLinePeriodEnd,
            this.colFinanceProportion,
            this.colOrderNumber,
            this.colPaymentTerms,
            this.colFinanceGracePeriod,
            this.colDeductibles,
            this.colLossThreshold,
            this.colPrice,
            this.colEFPrice,
            this.colCDAIFPrice,
            this.colCommissionType,
            this.colCommissionTypeComment,
            this.colHandFeeCurr,
            this.colHandFee,
            this.colCDAValueDate,
            this.colCDADueDate,
            this.colCDAStatus,
            this.colNoticeMethod,
            this.colNoticePersion,
            this.colEmail,
            this.colFax,
            this.colCDAComment,
            this.colCDACreateUserName});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCDAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCDAs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCDAs.Location = new System.Drawing.Point(1, 39);
            this.dgvCDAs.Name = "dgvCDAs";
            this.dgvCDAs.ReadOnly = true;
            this.dgvCDAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCDAs.Size = new System.Drawing.Size(519, 358);
            this.dgvCDAs.TabIndex = 1;
            this.dgvCDAs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailCDA);
            // 
            // colCDACode
            // 
            this.colCDACode.DataPropertyName = "CDACode";
            this.colCDACode.HeaderText = "额度通知书编号";
            this.colCDACode.Name = "colCDACode";
            this.colCDACode.ReadOnly = true;
            // 
            // colCDACaseCode
            // 
            this.colCDACaseCode.DataPropertyName = "CaseCode";
            this.colCDACaseCode.HeaderText = "案件编号";
            this.colCDACaseCode.Name = "colCDACaseCode";
            this.colCDACaseCode.ReadOnly = true;
            // 
            // colIsRecoarse
            // 
            this.colIsRecoarse.DataPropertyName = "IsRecoarse";
            this.colIsRecoarse.HeaderText = "是否有追索权";
            this.colIsRecoarse.Name = "colIsRecoarse";
            this.colIsRecoarse.ReadOnly = true;
            this.colIsRecoarse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsRecoarse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colIsNotice
            // 
            this.colIsNotice.DataPropertyName = "IsNotice";
            this.colIsNotice.HeaderText = "是否暗保理";
            this.colIsNotice.Name = "colIsNotice";
            this.colIsNotice.ReadOnly = true;
            this.colIsNotice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsNotice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAssignType
            // 
            this.colAssignType.DataPropertyName = "AssignType";
            this.colAssignType.HeaderText = "转让方式";
            this.colAssignType.Name = "colAssignType";
            this.colAssignType.ReadOnly = true;
            // 
            // colCreditCoverCurr
            // 
            this.colCreditCoverCurr.DataPropertyName = "CreditCoverCurr";
            this.colCreditCoverCurr.HeaderText = "买方风险额度币别";
            this.colCreditCoverCurr.Name = "colCreditCoverCurr";
            this.colCreditCoverCurr.ReadOnly = true;
            // 
            // colCreditCover
            // 
            this.colCreditCover.DataPropertyName = "CreditCover";
            this.colCreditCover.HeaderText = "买方信用风险额度";
            this.colCreditCover.Name = "colCreditCover";
            this.colCreditCover.ReadOnly = true;
            // 
            // colIsCreditCoverRevolving
            // 
            this.colIsCreditCoverRevolving.DataPropertyName = "IsCreditCoverRevolving";
            this.colIsCreditCoverRevolving.HeaderText = "是否可循环";
            this.colIsCreditCoverRevolving.Name = "colIsCreditCoverRevolving";
            this.colIsCreditCoverRevolving.ReadOnly = true;
            this.colIsCreditCoverRevolving.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsCreditCoverRevolving.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colApproveNumber
            // 
            this.colApproveNumber.DataPropertyName = "ApproveNumber";
            this.colApproveNumber.HeaderText = "核准编号";
            this.colApproveNumber.Name = "colApproveNumber";
            this.colApproveNumber.ReadOnly = true;
            this.colApproveNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colApproveNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPUGProportion
            // 
            this.colPUGProportion.DataPropertyName = "PUGProportion";
            this.colPUGProportion.HeaderText = "买方信用风险担保比例";
            this.colPUGProportion.Name = "colPUGProportion";
            this.colPUGProportion.ReadOnly = true;
            this.colPUGProportion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPUGProportion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreditCoverPeriodBegin
            // 
            this.colCreditCoverPeriodBegin.DataPropertyName = "CreditCoverPeriodBegin";
            this.colCreditCoverPeriodBegin.HeaderText = "买方信用风险额度有效期限(始)";
            this.colCreditCoverPeriodBegin.Name = "colCreditCoverPeriodBegin";
            this.colCreditCoverPeriodBegin.ReadOnly = true;
            this.colCreditCoverPeriodBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreditCoverPeriodBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreditCoverPeriodEnd
            // 
            this.colCreditCoverPeriodEnd.DataPropertyName = "CreditCoverPeriodEnd";
            this.colCreditCoverPeriodEnd.HeaderText = "买方信用风险额度有效期限(终)";
            this.colCreditCoverPeriodEnd.Name = "colCreditCoverPeriodEnd";
            this.colCreditCoverPeriodEnd.ReadOnly = true;
            this.colCreditCoverPeriodEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreditCoverPeriodEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPUGPeriod
            // 
            this.colPUGPeriod.DataPropertyName = "PUGPeriod";
            this.colPUGPeriod.HeaderText = "担保付款期限(天)";
            this.colPUGPeriod.Name = "colPUGPeriod";
            this.colPUGPeriod.ReadOnly = true;
            this.colPUGPeriod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPUGPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colReassignGracePeriod
            // 
            this.colReassignGracePeriod.DataPropertyName = "ReassignGracePeriod";
            this.colReassignGracePeriod.HeaderText = "回购宽限期";
            this.colReassignGracePeriod.Name = "colReassignGracePeriod";
            this.colReassignGracePeriod.ReadOnly = true;
            this.colReassignGracePeriod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReassignGracePeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinanceLineCurr
            // 
            this.colFinanceLineCurr.DataPropertyName = "FinanceLineCurr";
            this.colFinanceLineCurr.HeaderText = "预付款额度币别";
            this.colFinanceLineCurr.Name = "colFinanceLineCurr";
            this.colFinanceLineCurr.ReadOnly = true;
            this.colFinanceLineCurr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceLineCurr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinanceLine
            // 
            this.colFinanceLine.DataPropertyName = "FinanceLine";
            this.colFinanceLine.HeaderText = "预付款额度";
            this.colFinanceLine.Name = "colFinanceLine";
            this.colFinanceLine.ReadOnly = true;
            this.colFinanceLine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinanceLinePeriodBegin
            // 
            this.colFinanceLinePeriodBegin.DataPropertyName = "FinanceLinePeriodBegin";
            this.colFinanceLinePeriodBegin.HeaderText = "预付款额度有效期限(始)";
            this.colFinanceLinePeriodBegin.Name = "colFinanceLinePeriodBegin";
            this.colFinanceLinePeriodBegin.ReadOnly = true;
            // 
            // colFinanceLinePeriodEnd
            // 
            this.colFinanceLinePeriodEnd.DataPropertyName = "FinanceLinePeriodEnd";
            this.colFinanceLinePeriodEnd.HeaderText = "预付款额度有效期限(终)";
            this.colFinanceLinePeriodEnd.Name = "colFinanceLinePeriodEnd";
            this.colFinanceLinePeriodEnd.ReadOnly = true;
            // 
            // colFinanceProportion
            // 
            this.colFinanceProportion.DataPropertyName = "FinanceProportion";
            this.colFinanceProportion.HeaderText = "预付比例";
            this.colFinanceProportion.Name = "colFinanceProportion";
            this.colFinanceProportion.ReadOnly = true;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.DataPropertyName = "OrderNumber";
            this.colOrderNumber.HeaderText = "订单号";
            this.colOrderNumber.Name = "colOrderNumber";
            this.colOrderNumber.ReadOnly = true;
            // 
            // colPaymentTerms
            // 
            this.colPaymentTerms.DataPropertyName = "PaymentTerms";
            this.colPaymentTerms.HeaderText = "付款条件";
            this.colPaymentTerms.Name = "colPaymentTerms";
            this.colPaymentTerms.ReadOnly = true;
            // 
            // colFinanceGracePeriod
            // 
            this.colFinanceGracePeriod.DataPropertyName = "FinanceGracePeriod";
            this.colFinanceGracePeriod.HeaderText = "融资宽限期";
            this.colFinanceGracePeriod.Name = "colFinanceGracePeriod";
            this.colFinanceGracePeriod.ReadOnly = true;
            // 
            // colDeductibles
            // 
            this.colDeductibles.DataPropertyName = "Deductibles";
            this.colDeductibles.HeaderText = "自负额";
            this.colDeductibles.Name = "colDeductibles";
            this.colDeductibles.ReadOnly = true;
            // 
            // colLossThreshold
            // 
            this.colLossThreshold.DataPropertyName = "LossThreshold";
            this.colLossThreshold.HeaderText = "最低损失门槛";
            this.colLossThreshold.Name = "colLossThreshold";
            this.colLossThreshold.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "总手续费率";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colEFPrice
            // 
            this.colEFPrice.DataPropertyName = "EFPrice";
            this.colEFPrice.HeaderText = "卖方保理商手续费率";
            this.colEFPrice.Name = "colEFPrice";
            this.colEFPrice.ReadOnly = true;
            // 
            // colCDAIFPrice
            // 
            this.colCDAIFPrice.DataPropertyName = "IFPrice";
            this.colCDAIFPrice.HeaderText = "买方保理商手续费率";
            this.colCDAIFPrice.Name = "colCDAIFPrice";
            this.colCDAIFPrice.ReadOnly = true;
            // 
            // colCommissionType
            // 
            this.colCommissionType.DataPropertyName = "CommissionType";
            this.colCommissionType.HeaderText = "计费方式";
            this.colCommissionType.Name = "colCommissionType";
            this.colCommissionType.ReadOnly = true;
            // 
            // colCommissionTypeComment
            // 
            this.colCommissionTypeComment.DataPropertyName = "CommissionTypeComment";
            this.colCommissionTypeComment.HeaderText = "计费说明";
            this.colCommissionTypeComment.Name = "colCommissionTypeComment";
            this.colCommissionTypeComment.ReadOnly = true;
            // 
            // colHandFeeCurr
            // 
            this.colHandFeeCurr.DataPropertyName = "HandFeeCurr";
            this.colHandFeeCurr.HeaderText = "单据处理费币别";
            this.colHandFeeCurr.Name = "colHandFeeCurr";
            this.colHandFeeCurr.ReadOnly = true;
            // 
            // colHandFee
            // 
            this.colHandFee.DataPropertyName = "HandFee";
            this.colHandFee.HeaderText = "单据处理费(每张)";
            this.colHandFee.Name = "colHandFee";
            this.colHandFee.ReadOnly = true;
            // 
            // colCDAValueDate
            // 
            this.colCDAValueDate.DataPropertyName = "CDAValueDate";
            this.colCDAValueDate.HeaderText = "合同生效日";
            this.colCDAValueDate.Name = "colCDAValueDate";
            this.colCDAValueDate.ReadOnly = true;
            // 
            // colCDADueDate
            // 
            this.colCDADueDate.DataPropertyName = "CDADueDate";
            this.colCDADueDate.HeaderText = "合同到期日";
            this.colCDADueDate.Name = "colCDADueDate";
            this.colCDADueDate.ReadOnly = true;
            // 
            // colCDAStatus
            // 
            this.colCDAStatus.DataPropertyName = "CDAStatus";
            this.colCDAStatus.HeaderText = "合同状态";
            this.colCDAStatus.Name = "colCDAStatus";
            this.colCDAStatus.ReadOnly = true;
            // 
            // colNoticeMethod
            // 
            this.colNoticeMethod.DataPropertyName = "NoticeMethod";
            this.colNoticeMethod.HeaderText = "通知方式";
            this.colNoticeMethod.Name = "colNoticeMethod";
            this.colNoticeMethod.ReadOnly = true;
            // 
            // colNoticePersion
            // 
            this.colNoticePersion.DataPropertyName = "NoticePerson";
            this.colNoticePersion.HeaderText = "通知人";
            this.colNoticePersion.Name = "colNoticePersion";
            this.colNoticePersion.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email地址";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colFax
            // 
            this.colFax.DataPropertyName = "Fax";
            this.colFax.HeaderText = "传真号码";
            this.colFax.Name = "colFax";
            this.colFax.ReadOnly = true;
            // 
            // colCDAComment
            // 
            this.colCDAComment.DataPropertyName = "Comment";
            this.colCDAComment.HeaderText = "备注";
            this.colCDAComment.Name = "colCDAComment";
            this.colCDAComment.ReadOnly = true;
            // 
            // colCDACreateUserName
            // 
            this.colCDACreateUserName.DataPropertyName = "CreateUserName";
            this.colCDACreateUserName.HeaderText = "经办人";
            this.colCDACreateUserName.Name = "colCDACreateUserName";
            this.colCDACreateUserName.ReadOnly = true;
            // 
            // groupPanelCDA
            // 
            this.groupPanelCDA.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCDA.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCDA.Controls.Add(this.btnCDADelete);
            this.groupPanelCDA.Controls.Add(this.btnCDANew);
            this.groupPanelCDA.Controls.Add(this.btnCDARefresh);
            this.groupPanelCDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCDA.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCDA.Name = "groupPanelCDA";
            this.groupPanelCDA.Size = new System.Drawing.Size(519, 38);
            // 
            // 
            // 
            this.groupPanelCDA.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelCDA.Style.BackColorGradientAngle = 90;
            this.groupPanelCDA.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelCDA.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCDA.Style.BorderBottomWidth = 1;
            this.groupPanelCDA.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelCDA.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCDA.Style.BorderLeftWidth = 1;
            this.groupPanelCDA.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCDA.Style.BorderRightWidth = 1;
            this.groupPanelCDA.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelCDA.Style.BorderTopWidth = 1;
            this.groupPanelCDA.Style.Class = "";
            this.groupPanelCDA.Style.CornerDiameter = 4;
            this.groupPanelCDA.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCDA.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCDA.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCDA.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCDA.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelCDA.StyleMouseOver.Class = "";
            this.groupPanelCDA.TabIndex = 0;
            // 
            // btnCDADelete
            // 
            this.btnCDADelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDADelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDADelete.Location = new System.Drawing.Point(170, 6);
            this.btnCDADelete.Name = "btnCDADelete";
            this.btnCDADelete.Size = new System.Drawing.Size(75, 23);
            this.btnCDADelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDADelete.TabIndex = 2;
            this.btnCDADelete.Text = "删除";
            this.btnCDADelete.Click += new System.EventHandler(this.DeleteCDA);
            // 
            // btnCDANew
            // 
            this.btnCDANew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDANew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDANew.Location = new System.Drawing.Point(89, 6);
            this.btnCDANew.Name = "btnCDANew";
            this.btnCDANew.Size = new System.Drawing.Size(75, 23);
            this.btnCDANew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDANew.TabIndex = 1;
            this.btnCDANew.Text = "新建";
            this.btnCDANew.Click += new System.EventHandler(this.NewCDA);
            // 
            // btnCDARefresh
            // 
            this.btnCDARefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDARefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDARefresh.Location = new System.Drawing.Point(8, 6);
            this.btnCDARefresh.Name = "btnCDARefresh";
            this.btnCDARefresh.Size = new System.Drawing.Size(75, 23);
            this.btnCDARefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCDARefresh.TabIndex = 0;
            this.btnCDARefresh.Text = "刷新";
            this.btnCDARefresh.Click += new System.EventHandler(this.RefreshCDAList);
            // 
            // tabItemCDA
            // 
            this.tabItemCDA.AttachedControl = this.tabPanelCDA;
            this.tabItemCDA.Name = "tabItemCDA";
            this.tabItemCDA.Text = "额度通知书";
            // 
            // caseValidator
            // 
            this.caseValidator.ContainerControl = this;
            this.caseValidator.ErrorProvider = this.errorProvider;
            this.caseValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.EmptyValueIsValid = true;
            this.regularExpressionValidator2.ErrorMessage = "不能输入特殊字符";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^[^~!@#$%\\\\^&\\\\*\\\\+=\\\\?]+$";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator12
            // 
            this.requiredFieldValidator12.ErrorMessage = "必填";
            this.requiredFieldValidator12.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator13
            // 
            this.requiredFieldValidator13.ErrorMessage = "必填";
            this.requiredFieldValidator13.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator9
            // 
            this.requiredFieldValidator9.ErrorMessage = "必填";
            this.requiredFieldValidator9.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "必填";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator1_ValidateValue);
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.ErrorMessage = "必填";
            this.requiredFieldValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.caseBindingSource;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.EmptyValueIsValid = true;
            this.regularExpressionValidator1.ErrorMessage = "正确格式如下：FC20100001-0010SH-NY";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^[A-Z]{2}\\d{8}-\\d{4}[A-Z]{2,3}-[A-Z]{2}$";
            // 
            // requiredFieldValidator11
            // 
            this.requiredFieldValidator11.ErrorMessage = "必填";
            this.requiredFieldValidator11.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // creditCoverValidator
            // 
            this.creditCoverValidator.ContainerControl = this;
            this.creditCoverValidator.ErrorProvider = this.errorProvider;
            this.creditCoverValidator.Highlighter = this.highlighter;
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
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "必填";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NegoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "额度申请号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RequestType";
            this.dataGridViewTextBoxColumn3.HeaderText = "P/C标志";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RequestAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "申请额度";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NetPaymentTerm";
            this.dataGridViewTextBoxColumn5.HeaderText = "付款条件";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RequestDate";
            dataGridViewCellStyle19.Format = "d";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn6.HeaderText = "申请日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ReplyAmount";
            this.dataGridViewTextBoxColumn7.HeaderText = "回复额度";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReplyDate";
            dataGridViewCellStyle20.Format = "d";
            dataGridViewCellStyle20.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn8.HeaderText = "回复日期";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IFPrice";
            this.dataGridViewTextBoxColumn9.HeaderText = "IF报价";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PriceDate";
            dataGridViewCellStyle21.Format = "d";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn10.HeaderText = "报价日";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DueDate";
            dataGridViewCellStyle22.Format = "d";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn11.HeaderText = "额度期限";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn12.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn13.HeaderText = "备注";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CDACode";
            this.dataGridViewTextBoxColumn14.HeaderText = "额度通知书编号";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn15.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "IsRecoarse";
            this.dataGridViewTextBoxColumn16.HeaderText = "是否有追索权";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "IsNotice";
            this.dataGridViewTextBoxColumn17.HeaderText = "是否暗保理";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "AssignType";
            this.dataGridViewTextBoxColumn18.HeaderText = "转让方式";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "CreditCoverCurr";
            this.dataGridViewTextBoxColumn19.HeaderText = "买方风险额度币别";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CreditCover";
            this.dataGridViewTextBoxColumn20.HeaderText = "买方信用风险额度";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "IsCreditCoverRevolving";
            this.dataGridViewTextBoxColumn21.HeaderText = "是否可循环";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ApproveNumber";
            this.dataGridViewTextBoxColumn22.HeaderText = "核准编号";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "PUGProportion";
            this.dataGridViewTextBoxColumn23.HeaderText = "买方信用风险担保比例";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "CreditCoverPeriodBegin";
            this.dataGridViewTextBoxColumn24.HeaderText = "买方信用风险额度有效期限(始)";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "CreditCoverPeriodEnd";
            this.dataGridViewTextBoxColumn25.HeaderText = "买方信用风险额度有效期限(终)";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "PUGPeriod";
            this.dataGridViewTextBoxColumn26.HeaderText = "担保付款期限(天)";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ReassignGracePeriod";
            this.dataGridViewTextBoxColumn27.HeaderText = "回购宽限期";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "FinanceLineCurr";
            this.dataGridViewTextBoxColumn28.HeaderText = "预付款额度币别";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "FinanceLine";
            this.dataGridViewTextBoxColumn29.HeaderText = "预付款额度";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "FinanceLinePeriodBegin";
            this.dataGridViewTextBoxColumn30.HeaderText = "预付款额度有效期限(始)";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "FinanceLinePeriodEnd";
            this.dataGridViewTextBoxColumn31.HeaderText = "预付款额度有效期限(终)";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "FinanceProportion";
            this.dataGridViewTextBoxColumn32.HeaderText = "预付比例";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn33.HeaderText = "订单号";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "PaymentTerms";
            this.dataGridViewTextBoxColumn34.HeaderText = "付款条件";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "FinanceGracePeriod";
            this.dataGridViewTextBoxColumn35.HeaderText = "融资宽限期";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Deductibles";
            this.dataGridViewTextBoxColumn36.HeaderText = "自负额";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "LossThreshold";
            this.dataGridViewTextBoxColumn37.HeaderText = "最低损失门槛";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn38.HeaderText = "总手续费率";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "EFPrice";
            this.dataGridViewTextBoxColumn39.HeaderText = "卖方保理商手续费率";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "IFPrice";
            this.dataGridViewTextBoxColumn40.HeaderText = "买方保理商手续费率";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "CommissionType";
            this.dataGridViewTextBoxColumn41.HeaderText = "计费方式";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "CommissionTypeComment";
            this.dataGridViewTextBoxColumn42.HeaderText = "计费说明";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "HandFeeCurr";
            this.dataGridViewTextBoxColumn43.HeaderText = "单据处理费币别";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "HandFee";
            this.dataGridViewTextBoxColumn44.HeaderText = "单据处理费(每张)";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "CDAValueDate";
            this.dataGridViewTextBoxColumn45.HeaderText = "合同生效日";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "CDADueDate";
            this.dataGridViewTextBoxColumn46.HeaderText = "合同到期日";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "CDAStatus";
            this.dataGridViewTextBoxColumn47.HeaderText = "合同状态";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "NoticeMethod";
            this.dataGridViewTextBoxColumn48.HeaderText = "通知方式";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "NoticePerson";
            this.dataGridViewTextBoxColumn49.HeaderText = "通知人";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn50.HeaderText = "Email地址";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Fax";
            this.dataGridViewTextBoxColumn51.HeaderText = "传真号码";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn52.HeaderText = "备注";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn53.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // cbIsPool
            // 
            this.cbIsPool.AutoSize = true;
            this.cbIsPool.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsPool.BackgroundStyle.Class = "";
            this.cbIsPool.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.caseBindingSource, "IsPool", true));
            this.cbIsPool.Location = new System.Drawing.Point(268, 153);
            this.cbIsPool.Name = "cbIsPool";
            this.cbIsPool.Size = new System.Drawing.Size(88, 16);
            this.cbIsPool.TabIndex = 44;
            this.cbIsPool.Text = "是否池融资";
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Case);
            // 
            // creditCoverNegBindingSource
            // 
            this.creditCoverNegBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CreditCoverNegotiation);
            // 
            // CaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 424);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CaseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "案件";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelCase.ResumeLayout(false);
            this.groupPanelCase.ResumeLayout(false);
            this.groupPanelCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).EndInit();
            this.tabPanelCreditCoverNeg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).EndInit();
            this.groupPanelCreditCoverNeg.ResumeLayout(false);
            this.groupPanelCreditCoverNeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPriceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRequestDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diReplyDate)).EndInit();
            this.tabPanelCDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.groupPanelCDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diPriceDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNetPaymentTerm;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNegoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetPaymentTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsPool;

    }
}