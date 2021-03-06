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
		#region?Fields?(111)?

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
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseInvoiceCurrency;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseMark;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseOpType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseOwnerDepts;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseTransactionType;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsPool;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRequestType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLineCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFeeCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRecoarse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource creditCoverNegBindingSource;
        private DevComponents.DotNetBar.Validator.SuperValidator creditCoverValidator;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCDAs;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCoverNegs;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diCaseAppDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diDueDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diPriceDate;
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
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIFPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNetPaymentTerm;
        private DevComponents.DotNetBar.Controls.TextBoxX tbOPName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentTerm;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReplyAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRequestAmount;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.requestAmountLabel = new DevComponents.DotNetBar.LabelX();
            this.replyAmountLabel = new DevComponents.DotNetBar.LabelX();
            this.iFPriceLabel = new DevComponents.DotNetBar.LabelX();
            this.replyDateLabel = new DevComponents.DotNetBar.LabelX();
            this.requestDateLabel = new DevComponents.DotNetBar.LabelX();
            this.requestTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.commentLabel = new DevComponents.DotNetBar.LabelX();
            this.createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            this.lblCaseOwnerDept = new DevComponents.DotNetBar.LabelX();
            this.lblCaseOpType = new DevComponents.DotNetBar.LabelX();
            this.lblCaseCreateUser = new DevComponents.DotNetBar.LabelX();
            this.lblCaseMark = new DevComponents.DotNetBar.LabelX();
            this.lblCaseAppDate = new DevComponents.DotNetBar.LabelX();
            this.lblCaseTransactionType = new DevComponents.DotNetBar.LabelX();
            this.lblCaseInvoiceCurrency = new DevComponents.DotNetBar.LabelX();
            this.lblCaseBuyerNo = new DevComponents.DotNetBar.LabelX();
            this.lblCaseSellerNo = new DevComponents.DotNetBar.LabelX();
            this.lblCaseFactor = new DevComponents.DotNetBar.LabelX();
            this.lblOPName = new DevComponents.DotNetBar.LabelX();
            this.lblPaymentTerm = new DevComponents.DotNetBar.LabelX();
            this.lblComment = new DevComponents.DotNetBar.LabelX();
            this.lblCaseCode = new DevComponents.DotNetBar.LabelX();
            this.lblReview = new DevComponents.DotNetBar.LabelX();
            this.lblPriceDate = new DevComponents.DotNetBar.LabelX();
            this.lblNetPaymentTerm = new DevComponents.DotNetBar.LabelX();
            this.lblDueDate = new DevComponents.DotNetBar.LabelX();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelCase = new DevComponents.DotNetBar.TabControlPanel();
            this.btnCaseUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbCollectionOnly = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbIsPool = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbCaseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseMark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPaymentTerm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbOPName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCaseFactorNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseOwnerDepts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
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
            this.tabPanelInvoice = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemInvoice = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCDA = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCDAs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCDACode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsRecoarse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNotice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLineCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFeeCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDACreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelCDA = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCDADelete = new DevComponents.DotNetBar.ButtonX();
            this.btnCDANew = new DevComponents.DotNetBar.ButtonX();
            this.btnCDARefresh = new DevComponents.DotNetBar.ButtonX();
            this.tabItemCDA = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCreditCoverNeg = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCreditCoverNegs = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.creditCoverNegBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.cbReviews = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbCaseOpType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabItemCommissionRemit = new DevComponents.DotNetBar.TabItem(this.components);
            this.caseValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator12 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator13 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator9 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator11 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.creditCoverValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator10 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator15 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator14 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
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
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelCase.SuspendLayout();
            this.groupPanelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).BeginInit();
            this.tabPanelCDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).BeginInit();
            this.groupPanelCDA.SuspendLayout();
            this.tabPanelCreditCoverNeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).BeginInit();
            this.groupPanelCreditCoverNeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPriceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRequestDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diReplyDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // requestAmountLabel
            // 
            this.requestAmountLabel.AutoSize = true;
            this.requestAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.requestAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.requestAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.requestAmountLabel.Location = new System.Drawing.Point(167, 8);
            this.requestAmountLabel.Name = "requestAmountLabel";
            this.requestAmountLabel.Size = new System.Drawing.Size(57, 15);
            this.requestAmountLabel.TabIndex = 2;
            this.requestAmountLabel.Text = "<font color=\'red\'>*</font>申请额度:";
            // 
            // replyAmountLabel
            // 
            this.replyAmountLabel.AutoSize = true;
            this.replyAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.replyAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.replyAmountLabel.Location = new System.Drawing.Point(167, 31);
            this.replyAmountLabel.Name = "replyAmountLabel";
            this.replyAmountLabel.Size = new System.Drawing.Size(62, 18);
            this.replyAmountLabel.TabIndex = 8;
            this.replyAmountLabel.Text = "回复额度:";
            // 
            // iFPriceLabel
            // 
            this.iFPriceLabel.AutoSize = true;
            this.iFPriceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.iFPriceLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iFPriceLabel.Location = new System.Drawing.Point(13, 56);
            this.iFPriceLabel.Name = "iFPriceLabel";
            this.iFPriceLabel.Size = new System.Drawing.Size(50, 18);
            this.iFPriceLabel.TabIndex = 12;
            this.iFPriceLabel.Text = "IF报价:";
            // 
            // replyDateLabel
            // 
            this.replyDateLabel.AutoSize = true;
            this.replyDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.replyDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.replyDateLabel.Location = new System.Drawing.Point(338, 31);
            this.replyDateLabel.Name = "replyDateLabel";
            this.replyDateLabel.Size = new System.Drawing.Size(62, 18);
            this.replyDateLabel.TabIndex = 10;
            this.replyDateLabel.Text = "回复日期:";
            // 
            // requestDateLabel
            // 
            this.requestDateLabel.AutoSize = true;
            this.requestDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.requestDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.requestDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.requestDateLabel.Location = new System.Drawing.Point(0, 32);
            this.requestDateLabel.Name = "requestDateLabel";
            this.requestDateLabel.Size = new System.Drawing.Size(57, 15);
            this.requestDateLabel.TabIndex = 6;
            this.requestDateLabel.Text = "<font color=\'red\'>*</font>申请日期:";
            // 
            // requestTypeLabel
            // 
            this.requestTypeLabel.AutoSize = true;
            this.requestTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.requestTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.requestTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.requestTypeLabel.Location = new System.Drawing.Point(6, 10);
            this.requestTypeLabel.Name = "requestTypeLabel";
            this.requestTypeLabel.Size = new System.Drawing.Size(51, 15);
            this.requestTypeLabel.TabIndex = 0;
            this.requestTypeLabel.Text = "<font color=\'red\'>*</font>P/C标识:";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.commentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commentLabel.Location = new System.Drawing.Point(23, 77);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(37, 18);
            this.commentLabel.TabIndex = 18;
            this.commentLabel.Text = "备注:";
            // 
            // createUserNameLabel
            // 
            this.createUserNameLabel.AutoSize = true;
            this.createUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.createUserNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.createUserNameLabel.Location = new System.Drawing.Point(10, 129);
            this.createUserNameLabel.Name = "createUserNameLabel";
            this.createUserNameLabel.Size = new System.Drawing.Size(50, 18);
            this.createUserNameLabel.TabIndex = 20;
            this.createUserNameLabel.Text = "经办人:";
            // 
            // lblCaseOwnerDept
            // 
            this.lblCaseOwnerDept.AutoSize = true;
            this.lblCaseOwnerDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseOwnerDept.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseOwnerDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseOwnerDept.Location = new System.Drawing.Point(28, 168);
            this.lblCaseOwnerDept.Name = "lblCaseOwnerDept";
            this.lblCaseOwnerDept.Size = new System.Drawing.Size(57, 15);
            this.lblCaseOwnerDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseOwnerDept.TabIndex = 25;
            this.lblCaseOwnerDept.Text = "<font color=\'red\'>*</font>所属公司:";
            // 
            // lblCaseOpType
            // 
            this.lblCaseOpType.AutoSize = true;
            this.lblCaseOpType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseOpType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseOpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseOpType.Location = new System.Drawing.Point(31, 163);
            this.lblCaseOpType.Name = "lblCaseOpType";
            this.lblCaseOpType.Size = new System.Drawing.Size(0, 0);
            this.lblCaseOpType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseOpType.TabIndex = 21;
            this.lblCaseOpType.Text = "<font color=\'red\'>*</font>操作类型:";
            // 
            // lblCaseCreateUser
            // 
            this.lblCaseCreateUser.AutoSize = true;
            this.lblCaseCreateUser.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseCreateUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseCreateUser.Location = new System.Drawing.Point(296, 212);
            this.lblCaseCreateUser.Name = "lblCaseCreateUser";
            this.lblCaseCreateUser.Size = new System.Drawing.Size(50, 18);
            this.lblCaseCreateUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseCreateUser.TabIndex = 35;
            this.lblCaseCreateUser.Text = "经办人:";
            // 
            // lblCaseMark
            // 
            this.lblCaseMark.AutoSize = true;
            this.lblCaseMark.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseMark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseMark.Location = new System.Drawing.Point(279, 193);
            this.lblCaseMark.Name = "lblCaseMark";
            this.lblCaseMark.Size = new System.Drawing.Size(60, 16);
            this.lblCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseMark.TabIndex = 31;
            this.lblCaseMark.Text = "<font color=\'red\'>*</font>案件状态:";
            // 
            // lblCaseAppDate
            // 
            this.lblCaseAppDate.AutoSize = true;
            this.lblCaseAppDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseAppDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseAppDate.Location = new System.Drawing.Point(28, 190);
            this.lblCaseAppDate.Name = "lblCaseAppDate";
            this.lblCaseAppDate.Size = new System.Drawing.Size(60, 16);
            this.lblCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseAppDate.TabIndex = 29;
            this.lblCaseAppDate.Text = "<font color=\'red\'>*</font>申请日期:";
            // 
            // lblCaseTransactionType
            // 
            this.lblCaseTransactionType.AutoSize = true;
            this.lblCaseTransactionType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseTransactionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseTransactionType.Location = new System.Drawing.Point(30, 3);
            this.lblCaseTransactionType.Name = "lblCaseTransactionType";
            this.lblCaseTransactionType.Size = new System.Drawing.Size(57, 15);
            this.lblCaseTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseTransactionType.TabIndex = 0;
            this.lblCaseTransactionType.Text = "<font color=\'red\'>*</font>业务类别:";
            // 
            // lblCaseInvoiceCurrency
            // 
            this.lblCaseInvoiceCurrency.AutoSize = true;
            this.lblCaseInvoiceCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseInvoiceCurrency.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseInvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseInvoiceCurrency.Location = new System.Drawing.Point(31, 145);
            this.lblCaseInvoiceCurrency.Name = "lblCaseInvoiceCurrency";
            this.lblCaseInvoiceCurrency.Size = new System.Drawing.Size(57, 15);
            this.lblCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseInvoiceCurrency.TabIndex = 17;
            this.lblCaseInvoiceCurrency.Text = "<font color=\'red\'>*</font>发票币别:";
            // 
            // lblCaseBuyerNo
            // 
            this.lblCaseBuyerNo.AutoSize = true;
            this.lblCaseBuyerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseBuyerNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseBuyerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseBuyerNo.Location = new System.Drawing.Point(53, 63);
            this.lblCaseBuyerNo.Name = "lblCaseBuyerNo";
            this.lblCaseBuyerNo.Size = new System.Drawing.Size(33, 15);
            this.lblCaseBuyerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseBuyerNo.TabIndex = 7;
            this.lblCaseBuyerNo.Text = "<font color=\'red\'>*</font>买方:";
            // 
            // lblCaseSellerNo
            // 
            this.lblCaseSellerNo.AutoSize = true;
            this.lblCaseSellerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseSellerNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseSellerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseSellerNo.Location = new System.Drawing.Point(54, 24);
            this.lblCaseSellerNo.Name = "lblCaseSellerNo";
            this.lblCaseSellerNo.Size = new System.Drawing.Size(33, 15);
            this.lblCaseSellerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseSellerNo.TabIndex = 2;
            this.lblCaseSellerNo.Text = "<font color=\'red\'>*</font>卖方:";
            // 
            // lblCaseFactor
            // 
            this.lblCaseFactor.AutoSize = true;
            this.lblCaseFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseFactor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseFactor.Location = new System.Drawing.Point(44, 102);
            this.lblCaseFactor.Name = "lblCaseFactor";
            this.lblCaseFactor.Size = new System.Drawing.Size(50, 18);
            this.lblCaseFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseFactor.TabIndex = 12;
            this.lblCaseFactor.Text = "保理商:";
            // 
            // lblOPName
            // 
            this.lblOPName.AutoSize = true;
            this.lblOPName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblOPName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOPName.Location = new System.Drawing.Point(37, 209);
            this.lblOPName.Name = "lblOPName";
            this.lblOPName.Size = new System.Drawing.Size(50, 18);
            this.lblOPName.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblOPName.TabIndex = 33;
            this.lblOPName.Text = "OP人员:";
            // 
            // lblPaymentTerm
            // 
            this.lblPaymentTerm.AutoSize = true;
            this.lblPaymentTerm.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPaymentTerm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPaymentTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPaymentTerm.Location = new System.Drawing.Point(258, 167);
            this.lblPaymentTerm.Name = "lblPaymentTerm";
            this.lblPaymentTerm.Size = new System.Drawing.Size(84, 16);
            this.lblPaymentTerm.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblPaymentTerm.TabIndex = 27;
            this.lblPaymentTerm.Text = "最长付款期限:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblComment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComment.Location = new System.Drawing.Point(55, 232);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(34, 16);
            this.lblComment.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblComment.TabIndex = 37;
            this.lblComment.Text = "备注:";
            // 
            // lblCaseCode
            // 
            this.lblCaseCode.AutoSize = true;
            this.lblCaseCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseCode.Location = new System.Drawing.Point(287, 5);
            this.lblCaseCode.Name = "lblCaseCode";
            this.lblCaseCode.Size = new System.Drawing.Size(59, 16);
            this.lblCaseCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblCaseCode.TabIndex = 40;
            this.lblCaseCode.Text = "案件编号:";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblReview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblReview.Location = new System.Drawing.Point(268, 207);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(0, 0);
            this.lblReview.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblReview.TabIndex = 43;
            this.lblReview.Text = "协查意见:";
            // 
            // lblPriceDate
            // 
            this.lblPriceDate.AutoSize = true;
            this.lblPriceDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPriceDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPriceDate.Location = new System.Drawing.Point(177, 56);
            this.lblPriceDate.Name = "lblPriceDate";
            this.lblPriceDate.Size = new System.Drawing.Size(50, 18);
            this.lblPriceDate.TabIndex = 14;
            this.lblPriceDate.Text = "报价日:";
            // 
            // lblNetPaymentTerm
            // 
            this.lblNetPaymentTerm.AutoSize = true;
            this.lblNetPaymentTerm.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblNetPaymentTerm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNetPaymentTerm.Location = new System.Drawing.Point(338, 7);
            this.lblNetPaymentTerm.Name = "lblNetPaymentTerm";
            this.lblNetPaymentTerm.Size = new System.Drawing.Size(62, 18);
            this.lblNetPaymentTerm.TabIndex = 4;
            this.lblNetPaymentTerm.Text = "付款条件:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDueDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDueDate.Location = new System.Drawing.Point(338, 54);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(62, 18);
            this.lblDueDate.TabIndex = 16;
            this.lblDueDate.Text = "额度期限:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelCase);
            this.tabControl.Controls.Add(this.tabPanelInvoice);
            this.tabControl.Controls.Add(this.tabPanelCDA);
            this.tabControl.Controls.Add(this.tabPanelCreditCoverNeg);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(521, 360);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemCase);
            this.tabControl.Tabs.Add(this.tabItemCreditCoverNeg);
            this.tabControl.Tabs.Add(this.tabItemCDA);
            this.tabControl.Tabs.Add(this.tabItemInvoice);
            this.tabControl.Text = "tabControl1";
            // 
            // tabPanelCase
            // 
            this.tabPanelCase.Controls.Add(this.btnCaseUpdate);
            this.tabPanelCase.Controls.Add(this.btnCaseSave);
            this.tabPanelCase.Controls.Add(this.groupPanelCase);
            this.tabPanelCase.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCase.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCase.Name = "tabPanelCase";
            this.tabPanelCase.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCase.Size = new System.Drawing.Size(521, 334);
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
            this.btnCaseUpdate.Location = new System.Drawing.Point(181, 302);
            this.btnCaseUpdate.Name = "btnCaseUpdate";
            this.btnCaseUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnCaseUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCaseUpdate.TabIndex = 1;
            this.btnCaseUpdate.Text = "编辑";
            this.btnCaseUpdate.Click += new System.EventHandler(this.UpdateCase);
            // 
            // btnCaseSave
            // 
            this.btnCaseSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSave.Location = new System.Drawing.Point(262, 302);
            this.btnCaseSave.Name = "btnCaseSave";
            this.btnCaseSave.Size = new System.Drawing.Size(75, 21);
            this.btnCaseSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCaseSave.TabIndex = 2;
            this.btnCaseSave.Text = "保存";
            this.btnCaseSave.Click += new System.EventHandler(this.SaveCase);
            // 
            // groupPanelCase
            // 
            this.groupPanelCase.AutoScroll = true;
            this.groupPanelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.groupPanelCase.Controls.Add(this.cbCollectionOnly);
            this.groupPanelCase.Controls.Add(this.cbIsPool);
            this.groupPanelCase.Controls.Add(this.tbCaseCode);
            this.groupPanelCase.Controls.Add(this.lblCaseCode);
            this.groupPanelCase.Controls.Add(this.cbCaseMark);
            this.groupPanelCase.Controls.Add(this.tbComment);
            this.groupPanelCase.Controls.Add(this.lblComment);
            this.groupPanelCase.Controls.Add(this.tbPaymentTerm);
            this.groupPanelCase.Controls.Add(this.lblPaymentTerm);
            this.groupPanelCase.Controls.Add(this.tbOPName);
            this.groupPanelCase.Controls.Add(this.lblOPName);
            this.groupPanelCase.Controls.Add(this.cbCaseTransactionType);
            this.groupPanelCase.Controls.Add(this.tbCaseFactorNameEN);
            this.groupPanelCase.Controls.Add(this.cbCaseOwnerDepts);
            this.groupPanelCase.Controls.Add(this.lblCaseOwnerDept);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNameEN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNameEN);
            this.groupPanelCase.Controls.Add(this.tbCaseCreateUser);
            this.groupPanelCase.Controls.Add(this.lblCaseCreateUser);
            this.groupPanelCase.Controls.Add(this.lblCaseMark);
            this.groupPanelCase.Controls.Add(this.diCaseAppDate);
            this.groupPanelCase.Controls.Add(this.lblCaseAppDate);
            this.groupPanelCase.Controls.Add(this.lblCaseTransactionType);
            this.groupPanelCase.Controls.Add(this.cbCaseInvoiceCurrency);
            this.groupPanelCase.Controls.Add(this.lblCaseInvoiceCurrency);
            this.groupPanelCase.Controls.Add(this.btnCaseBuyerSelect);
            this.groupPanelCase.Controls.Add(this.btnCaseSellerSelect);
            this.groupPanelCase.Controls.Add(this.btnCaseFactorSelect);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseBuyerNo);
            this.groupPanelCase.Controls.Add(this.tbCaseFactorNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseFactorCode);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseSellerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseFactor);
            this.groupPanelCase.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCase.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCase.Name = "groupPanelCase";
            this.groupPanelCase.Size = new System.Drawing.Size(519, 296);
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
            this.groupPanelCase.Style.CornerDiameter = 4;
            this.groupPanelCase.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCase.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCase.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCase.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCase.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelCase.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelCase.TabIndex = 0;
            // 
            // cbCollectionOnly
            // 
            this.cbCollectionOnly.AutoSize = true;
            this.cbCollectionOnly.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbCollectionOnly.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbCollectionOnly.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.caseBindingSource, "IsCollectionOnly", true));
            this.cbCollectionOnly.Location = new System.Drawing.Point(397, 144);
            this.cbCollectionOnly.Name = "cbCollectionOnly";
            this.cbCollectionOnly.Size = new System.Drawing.Size(76, 18);
            this.cbCollectionOnly.TabIndex = 45;
            this.cbCollectionOnly.Text = "是否托收";
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Case);
            // 
            // cbIsPool
            // 
            this.cbIsPool.AutoSize = true;
            this.cbIsPool.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbIsPool.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsPool.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.caseBindingSource, "IsPool", true));
            this.cbIsPool.Location = new System.Drawing.Point(258, 145);
            this.cbIsPool.Name = "cbIsPool";
            this.cbIsPool.Size = new System.Drawing.Size(88, 18);
            this.cbIsPool.TabIndex = 44;
            this.cbIsPool.Text = "是否池融资";
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseCode", true));
            this.tbCaseCode.Location = new System.Drawing.Point(352, 1);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.ReadOnly = true;
            this.tbCaseCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCaseCode.Size = new System.Drawing.Size(121, 21);
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
            this.cbCaseMark.Location = new System.Drawing.Point(352, 189);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(121, 20);
            this.cbCaseMark.TabIndex = 39;
            this.caseValidator.SetValidator1(this.cbCaseMark, this.requiredFieldValidator3);
            // 
            // tbComment
            // 
            // 
            // 
            // 
            this.tbComment.Border.Class = "TextBoxBorder";
            this.tbComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Comment", true));
            this.tbComment.Location = new System.Drawing.Point(98, 232);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbComment.Size = new System.Drawing.Size(375, 54);
            this.tbComment.TabIndex = 38;
            // 
            // tbPaymentTerm
            // 
            // 
            // 
            // 
            this.tbPaymentTerm.Border.Class = "TextBoxBorder";
            this.tbPaymentTerm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPaymentTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "NetPaymentTerm", true));
            this.tbPaymentTerm.Location = new System.Drawing.Point(352, 165);
            this.tbPaymentTerm.Name = "tbPaymentTerm";
            this.tbPaymentTerm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPaymentTerm.Size = new System.Drawing.Size(121, 21);
            this.tbPaymentTerm.TabIndex = 28;
            // 
            // tbOPName
            // 
            // 
            // 
            // 
            this.tbOPName.Border.Class = "TextBoxBorder";
            this.tbOPName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbOPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "OPName", true));
            this.tbOPName.Location = new System.Drawing.Point(98, 210);
            this.tbOPName.Name = "tbOPName";
            this.tbOPName.Size = new System.Drawing.Size(121, 21);
            this.tbOPName.TabIndex = 34;
            // 
            // cbCaseTransactionType
            // 
            this.cbCaseTransactionType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "TransactionType", true));
            this.cbCaseTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseTransactionType.FormattingEnabled = true;
            this.cbCaseTransactionType.ItemHeight = 15;
            this.cbCaseTransactionType.Items.AddRange(new object[] {
            "国内卖方保理",
            "国内买方保理",
            "出口保理",
            "进口保理"});
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
            this.tbCaseFactorNameEN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseFactorNameEN.Location = new System.Drawing.Point(180, 121);
            this.tbCaseFactorNameEN.Name = "tbCaseFactorNameEN";
            this.tbCaseFactorNameEN.ReadOnly = true;
            this.tbCaseFactorNameEN.Size = new System.Drawing.Size(293, 21);
            this.tbCaseFactorNameEN.TabIndex = 15;
            this.tbCaseFactorNameEN.WatermarkText = "英文名";
            // 
            // cbCaseOwnerDepts
            // 
            this.cbCaseOwnerDepts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.caseBindingSource, "OwnerDepartment", true));
            this.cbCaseOwnerDepts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseOwnerDepts.ItemHeight = 15;
            this.cbCaseOwnerDepts.Location = new System.Drawing.Point(97, 164);
            this.cbCaseOwnerDepts.Name = "cbCaseOwnerDepts";
            this.cbCaseOwnerDepts.Size = new System.Drawing.Size(121, 21);
            this.cbCaseOwnerDepts.TabIndex = 26;
            // 
            // tbCaseBuyerNameEN
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNameEN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseBuyerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientNameEN", true));
            this.tbCaseBuyerNameEN.Location = new System.Drawing.Point(180, 81);
            this.tbCaseBuyerNameEN.Name = "tbCaseBuyerNameEN";
            this.tbCaseBuyerNameEN.ReadOnly = true;
            this.tbCaseBuyerNameEN.Size = new System.Drawing.Size(293, 21);
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
            this.tbCaseSellerNameEN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseSellerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientNameEN", true));
            this.tbCaseSellerNameEN.Location = new System.Drawing.Point(180, 42);
            this.tbCaseSellerNameEN.Name = "tbCaseSellerNameEN";
            this.tbCaseSellerNameEN.ReadOnly = true;
            this.tbCaseSellerNameEN.Size = new System.Drawing.Size(293, 21);
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
            this.tbCaseCreateUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseCreateUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CreateUserName", true));
            this.tbCaseCreateUser.Location = new System.Drawing.Point(352, 211);
            this.tbCaseCreateUser.Name = "tbCaseCreateUser";
            this.tbCaseCreateUser.ReadOnly = true;
            this.tbCaseCreateUser.Size = new System.Drawing.Size(121, 21);
            this.tbCaseCreateUser.TabIndex = 36;
            this.caseValidator.SetValidator1(this.tbCaseCreateUser, this.requiredFieldValidator12);
            // 
            // diCaseAppDate
            // 
            // 
            // 
            // 
            this.diCaseAppDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diCaseAppDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diCaseAppDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diCaseAppDate.ButtonDropDown.Visible = true;
            this.diCaseAppDate.ButtonFreeText.Checked = true;
            this.diCaseAppDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseAppDate", true));
            this.diCaseAppDate.FocusHighlightEnabled = true;
            this.diCaseAppDate.FreeTextEntryMode = true;
            this.diCaseAppDate.IsPopupCalendarOpen = false;
            this.diCaseAppDate.Location = new System.Drawing.Point(97, 188);
            // 
            // 
            // 
            this.diCaseAppDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diCaseAppDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diCaseAppDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.diCaseAppDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diCaseAppDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diCaseAppDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diCaseAppDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diCaseAppDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diCaseAppDate.MonthCalendar.TodayButtonVisible = true;
            this.diCaseAppDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diCaseAppDate.Name = "diCaseAppDate";
            this.diCaseAppDate.Size = new System.Drawing.Size(120, 21);
            this.diCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.cbCaseInvoiceCurrency.Location = new System.Drawing.Point(98, 142);
            this.cbCaseInvoiceCurrency.Name = "cbCaseInvoiceCurrency";
            this.cbCaseInvoiceCurrency.Size = new System.Drawing.Size(119, 20);
            this.cbCaseInvoiceCurrency.TabIndex = 18;
            // 
            // btnCaseBuyerSelect
            // 
            this.btnCaseBuyerSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseBuyerSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseBuyerSelect.Location = new System.Drawing.Point(479, 63);
            this.btnCaseBuyerSelect.Name = "btnCaseBuyerSelect";
            this.btnCaseBuyerSelect.Size = new System.Drawing.Size(20, 18);
            this.btnCaseBuyerSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCaseBuyerSelect.TabIndex = 11;
            this.btnCaseBuyerSelect.Text = "...";
            this.btnCaseBuyerSelect.Click += new System.EventHandler(this.SelectCaseBuyer);
            // 
            // btnCaseSellerSelect
            // 
            this.btnCaseSellerSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSellerSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSellerSelect.Location = new System.Drawing.Point(479, 23);
            this.btnCaseSellerSelect.Name = "btnCaseSellerSelect";
            this.btnCaseSellerSelect.Size = new System.Drawing.Size(20, 18);
            this.btnCaseSellerSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCaseSellerSelect.TabIndex = 6;
            this.btnCaseSellerSelect.Text = "...";
            this.btnCaseSellerSelect.Click += new System.EventHandler(this.SelectCaseSeller);
            // 
            // btnCaseFactorSelect
            // 
            this.btnCaseFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseFactorSelect.Location = new System.Drawing.Point(479, 101);
            this.btnCaseFactorSelect.Name = "btnCaseFactorSelect";
            this.btnCaseFactorSelect.Size = new System.Drawing.Size(20, 18);
            this.btnCaseFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.tbCaseBuyerNameCN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseBuyerNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientNameCN", true));
            this.tbCaseBuyerNameCN.Location = new System.Drawing.Point(180, 62);
            this.tbCaseBuyerNameCN.Name = "tbCaseBuyerNameCN";
            this.tbCaseBuyerNameCN.ReadOnly = true;
            this.tbCaseBuyerNameCN.Size = new System.Drawing.Size(293, 21);
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
            this.tbCaseBuyerNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseBuyerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientEDICode", true));
            this.tbCaseBuyerNo.Location = new System.Drawing.Point(98, 62);
            this.tbCaseBuyerNo.Name = "tbCaseBuyerNo";
            this.tbCaseBuyerNo.ReadOnly = true;
            this.tbCaseBuyerNo.Size = new System.Drawing.Size(76, 21);
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
            this.tbCaseFactorNameCN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseFactorNameCN.Location = new System.Drawing.Point(180, 101);
            this.tbCaseFactorNameCN.Name = "tbCaseFactorNameCN";
            this.tbCaseFactorNameCN.ReadOnly = true;
            this.tbCaseFactorNameCN.Size = new System.Drawing.Size(293, 21);
            this.tbCaseFactorNameCN.TabIndex = 14;
            this.tbCaseFactorNameCN.WatermarkText = "中文名";
            // 
            // tbCaseFactorCode
            // 
            // 
            // 
            // 
            this.tbCaseFactorCode.Border.Class = "TextBoxBorder";
            this.tbCaseFactorCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseFactorCode.Location = new System.Drawing.Point(99, 101);
            this.tbCaseFactorCode.Name = "tbCaseFactorCode";
            this.tbCaseFactorCode.ReadOnly = true;
            this.tbCaseFactorCode.Size = new System.Drawing.Size(75, 21);
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
            this.tbCaseSellerNameCN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseSellerNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientNameCN", true));
            this.tbCaseSellerNameCN.Location = new System.Drawing.Point(180, 23);
            this.tbCaseSellerNameCN.Name = "tbCaseSellerNameCN";
            this.tbCaseSellerNameCN.ReadOnly = true;
            this.tbCaseSellerNameCN.Size = new System.Drawing.Size(293, 21);
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
            this.tbCaseSellerNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseSellerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientEDICode", true));
            this.tbCaseSellerNo.Location = new System.Drawing.Point(100, 23);
            this.tbCaseSellerNo.Name = "tbCaseSellerNo";
            this.tbCaseSellerNo.ReadOnly = true;
            this.tbCaseSellerNo.Size = new System.Drawing.Size(74, 21);
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
            // tabPanelInvoice
            // 
            this.tabPanelInvoice.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelInvoice.Location = new System.Drawing.Point(0, 26);
            this.tabPanelInvoice.Name = "tabPanelInvoice";
            this.tabPanelInvoice.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelInvoice.Size = new System.Drawing.Size(521, 334);
            this.tabPanelInvoice.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelInvoice.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelInvoice.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelInvoice.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelInvoice.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelInvoice.Style.GradientAngle = 90;
            this.tabPanelInvoice.TabIndex = 4;
            this.tabPanelInvoice.TabItem = this.tabItemInvoice;
            // 
            // tabItemInvoice
            // 
            this.tabItemInvoice.AttachedControl = this.tabPanelInvoice;
            this.tabItemInvoice.Name = "tabItemInvoice";
            this.tabItemInvoice.Text = "发票";
            // 
            // tabPanelCDA
            // 
            this.tabPanelCDA.Controls.Add(this.dgvCDAs);
            this.tabPanelCDA.Controls.Add(this.groupPanelCDA);
            this.tabPanelCDA.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelCDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCDA.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCDA.Name = "tabPanelCDA";
            this.tabPanelCDA.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCDA.Size = new System.Drawing.Size(521, 334);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCDAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCDAs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCDACode,
            this.colCDAStatus,
            this.colIsRecoarse,
            this.colIsNotice,
            this.colCreditCoverCurr,
            this.colCreditCover,
            this.colCreditCoverPeriodBegin,
            this.colCreditCoverPeriodEnd,
            this.colFinanceLineCurr,
            this.colFinanceLine,
            this.colFinanceLinePeriodBegin,
            this.colFinanceLinePeriodEnd,
            this.colFinanceProportion,
            this.colPaymentTerms,
            this.colPrice,
            this.colCommissionType,
            this.colHandFeeCurr,
            this.colHandFee,
            this.colCDACreateUserName});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCDAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCDAs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCDAs.Location = new System.Drawing.Point(1, 36);
            this.dgvCDAs.Name = "dgvCDAs";
            this.dgvCDAs.ReadOnly = true;
            this.dgvCDAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCDAs.Size = new System.Drawing.Size(519, 297);
            this.dgvCDAs.TabIndex = 1;
            this.dgvCDAs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailCDA);
            this.dgvCDAs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCDAsCellFormatting);
            // 
            // colCDACode
            // 
            this.colCDACode.DataPropertyName = "CDACode";
            this.colCDACode.HeaderText = "额度通知书编号";
            this.colCDACode.Name = "colCDACode";
            this.colCDACode.ReadOnly = true;
            // 
            // colCDAStatus
            // 
            this.colCDAStatus.DataPropertyName = "CDAStatus";
            this.colCDAStatus.HeaderText = "合同状态";
            this.colCDAStatus.Name = "colCDAStatus";
            this.colCDAStatus.ReadOnly = true;
            // 
            // colIsRecoarse
            // 
            this.colIsRecoarse.DataPropertyName = "IsRecoarse";
            this.colIsRecoarse.HeaderText = "是否有追索权";
            this.colIsRecoarse.Name = "colIsRecoarse";
            this.colIsRecoarse.ReadOnly = true;
            this.colIsRecoarse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colIsNotice
            // 
            this.colIsNotice.DataPropertyName = "IsNotice";
            this.colIsNotice.HeaderText = "是否暗保理";
            this.colIsNotice.Name = "colIsNotice";
            this.colIsNotice.ReadOnly = true;
            this.colIsNotice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            dataGridViewCellStyle2.Format = "N2";
            this.colCreditCover.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCreditCover.HeaderText = "买方信用风险额度";
            this.colCreditCover.Name = "colCreditCover";
            this.colCreditCover.ReadOnly = true;
            // 
            // colCreditCoverPeriodBegin
            // 
            this.colCreditCoverPeriodBegin.DataPropertyName = "CreditCoverPeriodBegin";
            dataGridViewCellStyle3.Format = "d";
            this.colCreditCoverPeriodBegin.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCreditCoverPeriodBegin.HeaderText = "买方信用风险额度有效期限(始)";
            this.colCreditCoverPeriodBegin.Name = "colCreditCoverPeriodBegin";
            this.colCreditCoverPeriodBegin.ReadOnly = true;
            this.colCreditCoverPeriodBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCreditCoverPeriodEnd
            // 
            this.colCreditCoverPeriodEnd.DataPropertyName = "CreditCoverPeriodEnd";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colCreditCoverPeriodEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCreditCoverPeriodEnd.HeaderText = "买方信用风险额度有效期限(终)";
            this.colCreditCoverPeriodEnd.Name = "colCreditCoverPeriodEnd";
            this.colCreditCoverPeriodEnd.ReadOnly = true;
            this.colCreditCoverPeriodEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFinanceLineCurr
            // 
            this.colFinanceLineCurr.DataPropertyName = "FinanceLineCurr";
            this.colFinanceLineCurr.HeaderText = "预付款额度币别";
            this.colFinanceLineCurr.Name = "colFinanceLineCurr";
            this.colFinanceLineCurr.ReadOnly = true;
            this.colFinanceLineCurr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFinanceLine
            // 
            this.colFinanceLine.DataPropertyName = "FinanceLine";
            dataGridViewCellStyle5.Format = "N2";
            this.colFinanceLine.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFinanceLine.HeaderText = "预付款额度";
            this.colFinanceLine.Name = "colFinanceLine";
            this.colFinanceLine.ReadOnly = true;
            this.colFinanceLine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFinanceLinePeriodBegin
            // 
            this.colFinanceLinePeriodBegin.DataPropertyName = "FinanceLinePeriodBegin";
            dataGridViewCellStyle6.Format = "d";
            this.colFinanceLinePeriodBegin.DefaultCellStyle = dataGridViewCellStyle6;
            this.colFinanceLinePeriodBegin.HeaderText = "预付款额度有效期限(始)";
            this.colFinanceLinePeriodBegin.Name = "colFinanceLinePeriodBegin";
            this.colFinanceLinePeriodBegin.ReadOnly = true;
            // 
            // colFinanceLinePeriodEnd
            // 
            this.colFinanceLinePeriodEnd.DataPropertyName = "FinanceLinePeriodEnd";
            dataGridViewCellStyle7.Format = "d";
            this.colFinanceLinePeriodEnd.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFinanceLinePeriodEnd.HeaderText = "预付款额度有效期限(终)";
            this.colFinanceLinePeriodEnd.Name = "colFinanceLinePeriodEnd";
            this.colFinanceLinePeriodEnd.ReadOnly = true;
            // 
            // colFinanceProportion
            // 
            this.colFinanceProportion.DataPropertyName = "FinanceProportion";
            dataGridViewCellStyle8.Format = "p0";
            this.colFinanceProportion.DefaultCellStyle = dataGridViewCellStyle8;
            this.colFinanceProportion.HeaderText = "预付比例";
            this.colFinanceProportion.Name = "colFinanceProportion";
            this.colFinanceProportion.ReadOnly = true;
            // 
            // colPaymentTerms
            // 
            this.colPaymentTerms.DataPropertyName = "PaymentTerms";
            this.colPaymentTerms.HeaderText = "付款条件";
            this.colPaymentTerms.Name = "colPaymentTerms";
            this.colPaymentTerms.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle9.Format = "p4";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPrice.HeaderText = "总手续费率";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colCommissionType
            // 
            this.colCommissionType.DataPropertyName = "CommissionType";
            this.colCommissionType.HeaderText = "计费方式";
            this.colCommissionType.Name = "colCommissionType";
            this.colCommissionType.ReadOnly = true;
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
            dataGridViewCellStyle10.Format = "N2";
            this.colHandFee.DefaultCellStyle = dataGridViewCellStyle10;
            this.colHandFee.HeaderText = "单据处理费(每张)";
            this.colHandFee.Name = "colHandFee";
            this.colHandFee.ReadOnly = true;
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
            this.groupPanelCDA.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelCDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCDA.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCDA.Name = "groupPanelCDA";
            this.groupPanelCDA.Size = new System.Drawing.Size(519, 35);
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
            this.groupPanelCDA.Style.CornerDiameter = 4;
            this.groupPanelCDA.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCDA.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCDA.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCDA.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCDA.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelCDA.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelCDA.TabIndex = 0;
            // 
            // btnCDADelete
            // 
            this.btnCDADelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCDADelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCDADelete.Location = new System.Drawing.Point(170, 6);
            this.btnCDADelete.Name = "btnCDADelete";
            this.btnCDADelete.Size = new System.Drawing.Size(75, 21);
            this.btnCDADelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnCDANew.Size = new System.Drawing.Size(75, 21);
            this.btnCDANew.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.btnCDARefresh.Size = new System.Drawing.Size(75, 21);
            this.btnCDARefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            // tabPanelCreditCoverNeg
            // 
            this.tabPanelCreditCoverNeg.Controls.Add(this.dgvCreditCoverNegs);
            this.tabPanelCreditCoverNeg.Controls.Add(this.groupPanelCreditCoverNeg);
            this.tabPanelCreditCoverNeg.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelCreditCoverNeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCreditCoverNeg.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCreditCoverNeg.Name = "tabPanelCreditCoverNeg";
            this.tabPanelCreditCoverNeg.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCreditCoverNeg.Size = new System.Drawing.Size(521, 334);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCoverNegs.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCreditCoverNegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditCoverNegs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCreditCoverNegs.Location = new System.Drawing.Point(1, 184);
            this.dgvCreditCoverNegs.Name = "dgvCreditCoverNegs";
            this.dgvCreditCoverNegs.ReadOnly = true;
            this.dgvCreditCoverNegs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditCoverNegs.Size = new System.Drawing.Size(519, 149);
            this.dgvCreditCoverNegs.TabIndex = 0;
            this.dgvCreditCoverNegs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCreditCoverNeg);
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
            dataGridViewCellStyle12.Format = "N2";
            this.colRequestAmount.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Format = "d";
            this.colRequestDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.colRequestDate.HeaderText = "申请日期";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;
            // 
            // colReplyAmount
            // 
            this.colReplyAmount.DataPropertyName = "ReplyAmount";
            dataGridViewCellStyle14.Format = "N2";
            this.colReplyAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.colReplyAmount.HeaderText = "回复额度";
            this.colReplyAmount.Name = "colReplyAmount";
            this.colReplyAmount.ReadOnly = true;
            // 
            // colReplyDate
            // 
            this.colReplyDate.DataPropertyName = "ReplyDate";
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.colReplyDate.DefaultCellStyle = dataGridViewCellStyle15;
            this.colReplyDate.HeaderText = "回复日期";
            this.colReplyDate.Name = "colReplyDate";
            this.colReplyDate.ReadOnly = true;
            // 
            // colIFPrice
            // 
            this.colIFPrice.DataPropertyName = "IFPrice";
            dataGridViewCellStyle16.Format = "p4";
            this.colIFPrice.DefaultCellStyle = dataGridViewCellStyle16;
            this.colIFPrice.HeaderText = "IF报价";
            this.colIFPrice.Name = "colIFPrice";
            this.colIFPrice.ReadOnly = true;
            // 
            // colPriceDate
            // 
            this.colPriceDate.DataPropertyName = "PriceDate";
            dataGridViewCellStyle17.Format = "d";
            this.colPriceDate.DefaultCellStyle = dataGridViewCellStyle17;
            this.colPriceDate.HeaderText = "报价日";
            this.colPriceDate.Name = "colPriceDate";
            this.colPriceDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle18.Format = "d";
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle18;
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
            this.groupPanelCreditCoverNeg.Controls.Add(this.lblPriceDate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diPriceDate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.lblNetPaymentTerm);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbNetPaymentTerm);
            this.groupPanelCreditCoverNeg.Controls.Add(this.lblDueDate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegDelete);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegSave);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegUpdate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegNew);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegRefresh);
            this.groupPanelCreditCoverNeg.Controls.Add(this.createUserNameLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbCreditCoverCreateUserName);
            this.groupPanelCreditCoverNeg.Controls.Add(this.commentLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbCreditCoverComment);
            this.groupPanelCreditCoverNeg.Controls.Add(this.requestTypeLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.cbRequestType);
            this.groupPanelCreditCoverNeg.Controls.Add(this.requestDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diRequestDate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.replyDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diReplyDate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.iFPriceLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbIFPrice);
            this.groupPanelCreditCoverNeg.Controls.Add(this.replyAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbReplyAmount);
            this.groupPanelCreditCoverNeg.Controls.Add(this.requestAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbRequestAmount);
            this.groupPanelCreditCoverNeg.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelCreditCoverNeg.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditCoverNeg.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCreditCoverNeg.Name = "groupPanelCreditCoverNeg";
            this.groupPanelCreditCoverNeg.Size = new System.Drawing.Size(519, 183);
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
            this.groupPanelCreditCoverNeg.Style.CornerDiameter = 4;
            this.groupPanelCreditCoverNeg.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelCreditCoverNeg.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelCreditCoverNeg.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelCreditCoverNeg.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelCreditCoverNeg.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelCreditCoverNeg.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelCreditCoverNeg.TabIndex = 1;
            // 
            // diDueDate
            // 
            // 
            // 
            // 
            this.diDueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diDueDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diDueDate.ButtonDropDown.Visible = true;
            this.diDueDate.ButtonFreeText.Checked = true;
            this.diDueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "DueDate", true));
            this.diDueDate.FreeTextEntryMode = true;
            this.diDueDate.IsPopupCalendarOpen = false;
            this.diDueDate.Location = new System.Drawing.Point(404, 54);
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diDueDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diDueDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diDueDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diDueDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diDueDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diDueDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diDueDate.MonthCalendar.TodayButtonVisible = true;
            this.diDueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diDueDate.Name = "diDueDate";
            this.diDueDate.Size = new System.Drawing.Size(103, 21);
            this.diDueDate.TabIndex = 17;
            // 
            // creditCoverNegBindingSource
            // 
            this.creditCoverNegBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CreditCoverNegotiation);
            // 
            // diPriceDate
            // 
            // 
            // 
            // 
            this.diPriceDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diPriceDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diPriceDate.ButtonDropDown.Visible = true;
            this.diPriceDate.ButtonFreeText.Checked = true;
            this.diPriceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "PriceDate", true));
            this.diPriceDate.FreeTextEntryMode = true;
            this.diPriceDate.IsPopupCalendarOpen = false;
            this.diPriceDate.Location = new System.Drawing.Point(230, 53);
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diPriceDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diPriceDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diPriceDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diPriceDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diPriceDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diPriceDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diPriceDate.MonthCalendar.TodayButtonVisible = true;
            this.diPriceDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diPriceDate.Name = "diPriceDate";
            this.diPriceDate.Size = new System.Drawing.Size(103, 21);
            this.diPriceDate.TabIndex = 15;
            // 
            // tbNetPaymentTerm
            // 
            // 
            // 
            // 
            this.tbNetPaymentTerm.Border.Class = "TextBoxBorder";
            this.tbNetPaymentTerm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNetPaymentTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "NetPaymentTerm", true));
            this.tbNetPaymentTerm.Location = new System.Drawing.Point(403, 6);
            this.tbNetPaymentTerm.Name = "tbNetPaymentTerm";
            this.tbNetPaymentTerm.Size = new System.Drawing.Size(100, 21);
            this.tbNetPaymentTerm.TabIndex = 5;
            // 
            // btnCreditCoverNegDelete
            // 
            this.btnCreditCoverNegDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegDelete.Location = new System.Drawing.Point(398, 150);
            this.btnCreditCoverNegDelete.Name = "btnCreditCoverNegDelete";
            this.btnCreditCoverNegDelete.Size = new System.Drawing.Size(75, 21);
            this.btnCreditCoverNegDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCreditCoverNegDelete.TabIndex = 26;
            this.btnCreditCoverNegDelete.Text = "删除";
            this.btnCreditCoverNegDelete.Click += new System.EventHandler(this.DeleteCreditCoverNeg);
            // 
            // btnCreditCoverNegSave
            // 
            this.btnCreditCoverNegSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegSave.Location = new System.Drawing.Point(317, 150);
            this.btnCreditCoverNegSave.Name = "btnCreditCoverNegSave";
            this.btnCreditCoverNegSave.Size = new System.Drawing.Size(75, 21);
            this.btnCreditCoverNegSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCreditCoverNegSave.TabIndex = 25;
            this.btnCreditCoverNegSave.Text = "保存";
            this.btnCreditCoverNegSave.Click += new System.EventHandler(this.SaveCreditCoverNeg);
            // 
            // btnCreditCoverNegUpdate
            // 
            this.btnCreditCoverNegUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegUpdate.Location = new System.Drawing.Point(236, 150);
            this.btnCreditCoverNegUpdate.Name = "btnCreditCoverNegUpdate";
            this.btnCreditCoverNegUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnCreditCoverNegUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCreditCoverNegUpdate.TabIndex = 24;
            this.btnCreditCoverNegUpdate.Text = "编辑";
            this.btnCreditCoverNegUpdate.Click += new System.EventHandler(this.UpdateCreditCoverNeg);
            // 
            // btnCreditCoverNegNew
            // 
            this.btnCreditCoverNegNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegNew.Location = new System.Drawing.Point(155, 150);
            this.btnCreditCoverNegNew.Name = "btnCreditCoverNegNew";
            this.btnCreditCoverNegNew.Size = new System.Drawing.Size(75, 21);
            this.btnCreditCoverNegNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnCreditCoverNegNew.TabIndex = 23;
            this.btnCreditCoverNegNew.Text = "新建";
            this.btnCreditCoverNegNew.Click += new System.EventHandler(this.NewCreditCoverNeg);
            // 
            // btnCreditCoverNegRefresh
            // 
            this.btnCreditCoverNegRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegRefresh.Location = new System.Drawing.Point(74, 150);
            this.btnCreditCoverNegRefresh.Name = "btnCreditCoverNegRefresh";
            this.btnCreditCoverNegRefresh.Size = new System.Drawing.Size(75, 21);
            this.btnCreditCoverNegRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.tbCreditCoverCreateUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCreditCoverCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "CreateUserName", true));
            this.tbCreditCoverCreateUserName.Location = new System.Drawing.Point(61, 126);
            this.tbCreditCoverCreateUserName.Name = "tbCreditCoverCreateUserName";
            this.tbCreditCoverCreateUserName.ReadOnly = true;
            this.tbCreditCoverCreateUserName.Size = new System.Drawing.Size(100, 21);
            this.tbCreditCoverCreateUserName.TabIndex = 21;
            // 
            // tbCreditCoverComment
            // 
            // 
            // 
            // 
            this.tbCreditCoverComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCreditCoverComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "Comment", true));
            this.tbCreditCoverComment.Location = new System.Drawing.Point(61, 78);
            this.tbCreditCoverComment.Multiline = true;
            this.tbCreditCoverComment.Name = "tbCreditCoverComment";
            this.tbCreditCoverComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCreditCoverComment.Size = new System.Drawing.Size(442, 42);
            this.tbCreditCoverComment.TabIndex = 19;
            // 
            // cbRequestType
            // 
            this.cbRequestType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "RequestType", true));
            this.cbRequestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequestType.FormattingEnabled = true;
            this.cbRequestType.ItemHeight = 15;
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
            this.diRequestDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diRequestDate.ButtonDropDown.Visible = true;
            this.diRequestDate.ButtonFreeText.Checked = true;
            this.diRequestDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "RequestDate", true));
            this.diRequestDate.FreeTextEntryMode = true;
            this.diRequestDate.IsPopupCalendarOpen = false;
            this.diRequestDate.Location = new System.Drawing.Point(61, 30);
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diRequestDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diRequestDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diRequestDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diRequestDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diRequestDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRequestDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diRequestDate.MonthCalendar.TodayButtonVisible = true;
            this.diRequestDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diRequestDate.Name = "diRequestDate";
            this.diRequestDate.Size = new System.Drawing.Size(103, 21);
            this.diRequestDate.TabIndex = 7;
            this.creditCoverValidator.SetValidator1(this.diRequestDate, this.requiredFieldValidator6);
            // 
            // diReplyDate
            // 
            // 
            // 
            // 
            this.diReplyDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diReplyDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diReplyDate.ButtonDropDown.Visible = true;
            this.diReplyDate.ButtonFreeText.Checked = true;
            this.diReplyDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "ReplyDate", true));
            this.diReplyDate.FreeTextEntryMode = true;
            this.diReplyDate.IsPopupCalendarOpen = false;
            this.diReplyDate.Location = new System.Drawing.Point(404, 29);
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diReplyDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diReplyDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diReplyDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diReplyDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diReplyDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diReplyDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diReplyDate.MonthCalendar.TodayButtonVisible = true;
            this.diReplyDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diReplyDate.Name = "diReplyDate";
            this.diReplyDate.Size = new System.Drawing.Size(103, 21);
            this.diReplyDate.TabIndex = 11;
            // 
            // tbIFPrice
            // 
            // 
            // 
            // 
            this.tbIFPrice.Border.Class = "TextBoxBorder";
            this.tbIFPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbIFPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "IFPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbIFPrice.Location = new System.Drawing.Point(61, 54);
            this.tbIFPrice.Name = "tbIFPrice";
            this.tbIFPrice.Size = new System.Drawing.Size(100, 21);
            this.tbIFPrice.TabIndex = 13;
            // 
            // tbReplyAmount
            // 
            // 
            // 
            // 
            this.tbReplyAmount.Border.Class = "TextBoxBorder";
            this.tbReplyAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReplyAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "ReplyAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbReplyAmount.Location = new System.Drawing.Point(230, 30);
            this.tbReplyAmount.Name = "tbReplyAmount";
            this.tbReplyAmount.Size = new System.Drawing.Size(100, 21);
            this.tbReplyAmount.TabIndex = 9;
            // 
            // tbRequestAmount
            // 
            // 
            // 
            // 
            this.tbRequestAmount.Border.Class = "TextBoxBorder";
            this.tbRequestAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRequestAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "RequestAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbRequestAmount.Location = new System.Drawing.Point(230, 6);
            this.tbRequestAmount.Name = "tbRequestAmount";
            this.tbRequestAmount.Size = new System.Drawing.Size(100, 21);
            this.tbRequestAmount.TabIndex = 3;
            this.creditCoverValidator.SetValidator1(this.tbRequestAmount, this.requiredFieldValidator5);
            // 
            // tabItemCreditCoverNeg
            // 
            this.tabItemCreditCoverNeg.AttachedControl = this.tabPanelCreditCoverNeg;
            this.tabItemCreditCoverNeg.Name = "tabItemCreditCoverNeg";
            this.tabItemCreditCoverNeg.Text = "额度申请信息";
            // 
            // cbReviews
            // 
            this.cbReviews.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReviews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReviews.FormattingEnabled = true;
            this.cbReviews.ItemHeight = 14;
            this.cbReviews.Location = new System.Drawing.Point(336, 205);
            this.cbReviews.Name = "cbReviews";
            this.cbReviews.Size = new System.Drawing.Size(137, 20);
            this.cbReviews.TabIndex = 42;
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
            this.cbCaseOpType.Location = new System.Drawing.Point(98, 162);
            this.cbCaseOpType.Name = "cbCaseOpType";
            this.cbCaseOpType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseOpType.TabIndex = 22;
            // 
            // tabItemCommissionRemit
            // 
            this.tabItemCommissionRemit.Name = "tabItemCommissionRemit";
            this.tabItemCommissionRemit.Text = "保理费收付";
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
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator1ValidateValue);
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
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.EmptyValueIsValid = true;
            this.regularExpressionValidator2.ErrorMessage = "不能输入特殊字符";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^[^~!@#$%\\\\^&\\\\*\\\\+=\\\\?]+$";
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // requiredFieldValidator10
            // 
            this.requiredFieldValidator10.ErrorMessage = "必填";
            this.requiredFieldValidator10.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator15
            // 
            this.requiredFieldValidator15.ErrorMessage = "必填";
            this.requiredFieldValidator15.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator14
            // 
            this.requiredFieldValidator14.ErrorMessage = "必填";
            this.requiredFieldValidator14.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CDACode";
            this.dataGridViewTextBoxColumn1.HeaderText = "额度通知书编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CDAStatus";
            this.dataGridViewTextBoxColumn2.HeaderText = "合同状态";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IsRecoarse";
            this.dataGridViewTextBoxColumn3.HeaderText = "是否有追索权";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsNotice";
            this.dataGridViewTextBoxColumn4.HeaderText = "是否暗保理";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreditCoverCurr";
            this.dataGridViewTextBoxColumn5.HeaderText = "买方风险额度币别";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreditCover";
            dataGridViewCellStyle20.Format = "N2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn6.HeaderText = "买方信用风险额度";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreditCoverPeriodBegin";
            dataGridViewCellStyle21.Format = "d";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn7.HeaderText = "买方信用风险额度有效期限(始)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CreditCoverPeriodEnd";
            dataGridViewCellStyle22.Format = "d";
            dataGridViewCellStyle22.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn8.HeaderText = "买方信用风险额度有效期限(终)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FinanceLineCurr";
            this.dataGridViewTextBoxColumn9.HeaderText = "预付款额度币别";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FinanceLine";
            dataGridViewCellStyle23.Format = "N2";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn10.HeaderText = "预付款额度";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FinanceLinePeriodBegin";
            dataGridViewCellStyle24.Format = "d";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn11.HeaderText = "预付款额度有效期限(始)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FinanceLinePeriodEnd";
            dataGridViewCellStyle25.Format = "d";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn12.HeaderText = "预付款额度有效期限(终)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FinanceProportion";
            dataGridViewCellStyle26.Format = "p0";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn13.HeaderText = "预付比例";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PaymentTerms";
            this.dataGridViewTextBoxColumn14.HeaderText = "付款条件";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Price";
            dataGridViewCellStyle27.Format = "p4";
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn15.HeaderText = "总手续费率";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CommissionType";
            this.dataGridViewTextBoxColumn16.HeaderText = "计费方式";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "HandFeeCurr";
            this.dataGridViewTextBoxColumn17.HeaderText = "单据处理费币别";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "HandFee";
            dataGridViewCellStyle28.Format = "N2";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn18.HeaderText = "单据处理费(每张)";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn19.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn20.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RequestType";
            this.dataGridViewTextBoxColumn21.HeaderText = "P/C标志";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "RequestAmount";
            dataGridViewCellStyle29.Format = "N2";
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn22.HeaderText = "申请额度";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "NetPaymentTerm";
            this.dataGridViewTextBoxColumn23.HeaderText = "付款条件";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "RequestDate";
            dataGridViewCellStyle30.Format = "d";
            this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTextBoxColumn24.HeaderText = "申请日期";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ReplyAmount";
            dataGridViewCellStyle31.Format = "N2";
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewTextBoxColumn25.HeaderText = "回复额度";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "ReplyDate";
            dataGridViewCellStyle32.Format = "d";
            dataGridViewCellStyle32.NullValue = null;
            this.dataGridViewTextBoxColumn26.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewTextBoxColumn26.HeaderText = "回复日期";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IFPrice";
            dataGridViewCellStyle33.Format = "p4";
            this.dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewTextBoxColumn27.HeaderText = "IF报价";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "PriceDate";
            dataGridViewCellStyle34.Format = "d";
            this.dataGridViewTextBoxColumn28.DefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewTextBoxColumn28.HeaderText = "报价日";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "DueDate";
            dataGridViewCellStyle35.Format = "d";
            this.dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewTextBoxColumn29.HeaderText = "额度期限";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn30.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn31.HeaderText = "备注";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // CaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 360);
            this.Controls.Add(this.tabControl);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CaseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "案件";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelCase.ResumeLayout(false);
            this.groupPanelCase.ResumeLayout(false);
            this.groupPanelCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).EndInit();
            this.tabPanelCDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.groupPanelCDA.ResumeLayout(false);
            this.tabPanelCreditCoverNeg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).EndInit();
            this.groupPanelCreditCoverNeg.ResumeLayout(false);
            this.groupPanelCreditCoverNeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPriceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRequestDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diReplyDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.DotNetBar.TabControlPanel tabPanelInvoice;
        private DevComponents.DotNetBar.TabItem tabItemInvoice;
        private DevComponents.DotNetBar.TabItem tabItemCommissionRemit;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator10;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator14;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator15;
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
        private DevComponents.DotNetBar.LabelX requestAmountLabel;
        private DevComponents.DotNetBar.LabelX replyAmountLabel;
        private DevComponents.DotNetBar.LabelX iFPriceLabel;
        private DevComponents.DotNetBar.LabelX replyDateLabel;
        private DevComponents.DotNetBar.LabelX requestDateLabel;
        private DevComponents.DotNetBar.LabelX requestTypeLabel;
        private DevComponents.DotNetBar.LabelX commentLabel;
        private DevComponents.DotNetBar.LabelX createUserNameLabel;
        private DevComponents.DotNetBar.LabelX lblCaseOwnerDept;
        private DevComponents.DotNetBar.LabelX lblCaseOpType;
        private DevComponents.DotNetBar.LabelX lblCaseCreateUser;
        private DevComponents.DotNetBar.LabelX lblCaseMark;
        private DevComponents.DotNetBar.LabelX lblCaseAppDate;
        private DevComponents.DotNetBar.LabelX lblCaseTransactionType;
        private DevComponents.DotNetBar.LabelX lblCaseInvoiceCurrency;
        private DevComponents.DotNetBar.LabelX lblCaseBuyerNo;
        private DevComponents.DotNetBar.LabelX lblCaseSellerNo;
        private DevComponents.DotNetBar.LabelX lblCaseFactor;
        private DevComponents.DotNetBar.LabelX lblOPName;
        private DevComponents.DotNetBar.LabelX lblPaymentTerm;
        private DevComponents.DotNetBar.LabelX lblComment;
        private DevComponents.DotNetBar.LabelX lblCaseCode;
        private DevComponents.DotNetBar.LabelX lblReview;
        private DevComponents.DotNetBar.LabelX lblPriceDate;
        private DevComponents.DotNetBar.LabelX lblNetPaymentTerm;
        private DevComponents.DotNetBar.LabelX lblDueDate;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbCollectionOnly;
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
    }
}