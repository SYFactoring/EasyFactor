namespace CMBC.EasyFactor.CaseMgr
{
    partial class CaseDetail
    {
        #region Fields (112)

        private DevComponents.DotNetBar.ButtonX btnCaseBuyerSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseReset;
        private DevComponents.DotNetBar.ButtonX btnCaseSave;
        private DevComponents.DotNetBar.ButtonX btnCaseFactorSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseSellerSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseUpdate;
        private DevComponents.DotNetBar.ButtonX btnCDANew;
        private DevComponents.DotNetBar.ButtonX btnCDARefresh;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegDelete;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegNew;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegRefresh;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegSave;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverNegUpdate;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbApproveType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseCoDepts;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseInvoiceCurrency;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseMark;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseOpType;
        private DevComponents.DotNetBar.Controls.ComboTree cbCaseOwnerDepts;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNegoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource creditCoverNegBindingSource;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCDAs;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCoverNegs;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diApproveDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diCaseAppDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diRequestDate;
        private System.Windows.Forms.ErrorProvider caseErrorProvider;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCase;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCDA;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditCoverNeg;
        private DevComponents.DotNetBar.Validator.Highlighter caseHighlighter;
        private DevComponents.DotNetBar.Validator.SuperValidator caseValidator;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemCase;
        private DevComponents.DotNetBar.TabItem tabItemCDA;
        private DevComponents.DotNetBar.TabItem tabItemCreditCoverNeg;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCase;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCDA;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCreditCoverNeg;
        private DevComponents.DotNetBar.Controls.TextBoxX tbApproveAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCreateUser;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseFactorNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseFactorNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreditCoverComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbIFPrice;
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
            DevComponents.DotNetBar.LabelX requestAmountLabel;
            DevComponents.DotNetBar.LabelX approveAmountLabel;
            DevComponents.DotNetBar.LabelX iFPriceLabel;
            DevComponents.DotNetBar.LabelX approveDateLabel;
            DevComponents.DotNetBar.LabelX requestDateLabel;
            DevComponents.DotNetBar.LabelX approveTypeLabel;
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
            DevComponents.DotNetBar.LabelX lblManagerName;
            DevComponents.DotNetBar.LabelX lblPaymentTerm;
            DevComponents.DotNetBar.LabelX lblReviewNo;
            DevComponents.DotNetBar.LabelX lblComment;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseDetail));
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelCase = new DevComponents.DotNetBar.TabControlPanel();
            this.btnCaseUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseReset = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbReviewNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPaymentTerm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbManagerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCaseFactorNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseCoDepts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbCaseOwnerDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.cbCaseOpType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbCaseBuyerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseCreateUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseMark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
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
            this.colCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanelCreditCoverNeg = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCreditCoverNegDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegNew = new DevComponents.DotNetBar.ButtonX();
            this.btnCreditCoverNegRefresh = new DevComponents.DotNetBar.ButtonX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverNegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCreditCoverComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbApproveType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.diRequestDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diApproveDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbIFPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbApproveAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbRequestAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemCreditCoverNeg = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCDA = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCDAs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCDACode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDACaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDACase = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnCDANew = new DevComponents.DotNetBar.ButtonX();
            this.btnCDARefresh = new DevComponents.DotNetBar.ButtonX();
            this.tabItemCDA = new DevComponents.DotNetBar.TabItem(this.components);
            this.caseValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.caseErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.caseHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.creditCoverValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.creditCoverErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.creditCoverHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnCDADelete = new DevComponents.DotNetBar.ButtonX();
            requestAmountLabel = new DevComponents.DotNetBar.LabelX();
            approveAmountLabel = new DevComponents.DotNetBar.LabelX();
            iFPriceLabel = new DevComponents.DotNetBar.LabelX();
            approveDateLabel = new DevComponents.DotNetBar.LabelX();
            requestDateLabel = new DevComponents.DotNetBar.LabelX();
            approveTypeLabel = new DevComponents.DotNetBar.LabelX();
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
            lblManagerName = new DevComponents.DotNetBar.LabelX();
            lblPaymentTerm = new DevComponents.DotNetBar.LabelX();
            lblReviewNo = new DevComponents.DotNetBar.LabelX();
            lblComment = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelCase.SuspendLayout();
            this.groupPanelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).BeginInit();
            this.tabPanelCreditCoverNeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).BeginInit();
            this.groupPanelCreditCoverNeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRequestDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diApproveDate)).BeginInit();
            this.tabPanelCDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).BeginInit();
            this.groupPanelCDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverErrorProvider)).BeginInit();
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
            requestAmountLabel.Location = new System.Drawing.Point(8, 12);
            requestAmountLabel.Name = "requestAmountLabel";
            requestAmountLabel.Size = new System.Drawing.Size(59, 16);
            requestAmountLabel.TabIndex = 0;
            requestAmountLabel.Text = "申请额度:";
            // 
            // approveAmountLabel
            // 
            approveAmountLabel.AutoSize = true;
            approveAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            approveAmountLabel.BackgroundStyle.Class = "";
            approveAmountLabel.Location = new System.Drawing.Point(8, 36);
            approveAmountLabel.Name = "approveAmountLabel";
            approveAmountLabel.Size = new System.Drawing.Size(59, 16);
            approveAmountLabel.TabIndex = 6;
            approveAmountLabel.Text = "回复额度:";
            // 
            // iFPriceLabel
            // 
            iFPriceLabel.AutoSize = true;
            iFPriceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            iFPriceLabel.BackgroundStyle.Class = "";
            iFPriceLabel.Location = new System.Drawing.Point(180, 36);
            iFPriceLabel.Name = "iFPriceLabel";
            iFPriceLabel.Size = new System.Drawing.Size(44, 16);
            iFPriceLabel.TabIndex = 8;
            iFPriceLabel.Text = "IF报价:";
            // 
            // approveDateLabel
            // 
            approveDateLabel.AutoSize = true;
            approveDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            approveDateLabel.BackgroundStyle.Class = "";
            approveDateLabel.Location = new System.Drawing.Point(336, 36);
            approveDateLabel.Name = "approveDateLabel";
            approveDateLabel.Size = new System.Drawing.Size(59, 16);
            approveDateLabel.TabIndex = 10;
            approveDateLabel.Text = "回复日期:";
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
            requestDateLabel.Location = new System.Drawing.Point(336, 11);
            requestDateLabel.Name = "requestDateLabel";
            requestDateLabel.Size = new System.Drawing.Size(59, 16);
            requestDateLabel.TabIndex = 4;
            requestDateLabel.Text = "申请日期:";
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
            approveTypeLabel.Location = new System.Drawing.Point(177, 11);
            approveTypeLabel.Name = "approveTypeLabel";
            approveTypeLabel.Size = new System.Drawing.Size(53, 16);
            approveTypeLabel.TabIndex = 2;
            approveTypeLabel.Text = "P/C标识:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(33, 62);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 12;
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
            createUserNameLabel.Location = new System.Drawing.Point(20, 107);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            createUserNameLabel.TabIndex = 14;
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
            lblCaseCoDept.Location = new System.Drawing.Point(204, 176);
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
            lblCaseOwnerDept.Location = new System.Drawing.Point(7, 200);
            lblCaseOwnerDept.Name = "lblCaseOwnerDept";
            lblCaseOwnerDept.Size = new System.Drawing.Size(84, 16);
            lblCaseOwnerDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseOwnerDept.TabIndex = 25;
            lblCaseOwnerDept.Text = "业务归属机构:";
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
            lblCaseOpType.Location = new System.Drawing.Point(33, 177);
            lblCaseOpType.Name = "lblCaseOpType";
            lblCaseOpType.Size = new System.Drawing.Size(59, 16);
            lblCaseOpType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseOpType.TabIndex = 21;
            lblCaseOpType.Text = "操作类型:";
            // 
            // lblCaseCreateUser
            // 
            lblCaseCreateUser.AutoSize = true;
            lblCaseCreateUser.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseCreateUser.BackgroundStyle.Class = "";
            lblCaseCreateUser.Location = new System.Drawing.Point(236, 286);
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
            lblCaseMark.Location = new System.Drawing.Point(225, 262);
            lblCaseMark.Name = "lblCaseMark";
            lblCaseMark.Size = new System.Drawing.Size(59, 16);
            lblCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseMark.TabIndex = 31;
            lblCaseMark.Text = "案件状态:";
            // 
            // lblCaseAppDate
            // 
            lblCaseAppDate.AutoSize = true;
            lblCaseAppDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseAppDate.BackgroundStyle.Class = "";
            lblCaseAppDate.Location = new System.Drawing.Point(30, 264);
            lblCaseAppDate.Name = "lblCaseAppDate";
            lblCaseAppDate.Size = new System.Drawing.Size(59, 16);
            lblCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseAppDate.TabIndex = 29;
            lblCaseAppDate.Text = "申请日期:";
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
            lblCaseTransactionType.Location = new System.Drawing.Point(33, 3);
            lblCaseTransactionType.Name = "lblCaseTransactionType";
            lblCaseTransactionType.Size = new System.Drawing.Size(59, 16);
            lblCaseTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseTransactionType.TabIndex = 0;
            lblCaseTransactionType.Text = "业务类别:";
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
            lblCaseInvoiceCurrency.Location = new System.Drawing.Point(33, 155);
            lblCaseInvoiceCurrency.Name = "lblCaseInvoiceCurrency";
            lblCaseInvoiceCurrency.Size = new System.Drawing.Size(59, 16);
            lblCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseInvoiceCurrency.TabIndex = 17;
            lblCaseInvoiceCurrency.Text = "发票币别:";
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
            lblCaseBuyerNo.Location = new System.Drawing.Point(55, 68);
            lblCaseBuyerNo.Name = "lblCaseBuyerNo";
            lblCaseBuyerNo.Size = new System.Drawing.Size(34, 16);
            lblCaseBuyerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseBuyerNo.TabIndex = 7;
            lblCaseBuyerNo.Text = "买方:";
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
            lblCaseSellerNo.Location = new System.Drawing.Point(57, 22);
            lblCaseSellerNo.Name = "lblCaseSellerNo";
            lblCaseSellerNo.Size = new System.Drawing.Size(34, 16);
            lblCaseSellerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseSellerNo.TabIndex = 2;
            lblCaseSellerNo.Text = "卖方:";
            // 
            // lblCaseFactor
            // 
            lblCaseFactor.AutoSize = true;
            lblCaseFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCaseFactor.BackgroundStyle.Class = "";
            lblCaseFactor.Location = new System.Drawing.Point(44, 113);
            lblCaseFactor.Name = "lblCaseFactor";
            lblCaseFactor.Size = new System.Drawing.Size(47, 16);
            lblCaseFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblCaseFactor.TabIndex = 12;
            lblCaseFactor.Text = "保理商:";
            // 
            // lblManagerName
            // 
            lblManagerName.AutoSize = true;
            lblManagerName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblManagerName.BackgroundStyle.Class = "";
            lblManagerName.Location = new System.Drawing.Point(2, 285);
            lblManagerName.Name = "lblManagerName";
            lblManagerName.Size = new System.Drawing.Size(87, 16);
            lblManagerName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblManagerName.TabIndex = 33;
            lblManagerName.Text = "营销/维护经理:";
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
            lblPaymentTerm.Location = new System.Drawing.Point(30, 222);
            lblPaymentTerm.Name = "lblPaymentTerm";
            lblPaymentTerm.Size = new System.Drawing.Size(59, 16);
            lblPaymentTerm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblPaymentTerm.TabIndex = 27;
            lblPaymentTerm.Text = "付款条件:";
            // 
            // lblReviewNo
            // 
            lblReviewNo.AutoSize = true;
            lblReviewNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblReviewNo.BackgroundStyle.Class = "";
            lblReviewNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblReviewNo.Location = new System.Drawing.Point(204, 153);
            lblReviewNo.Name = "lblReviewNo";
            lblReviewNo.Size = new System.Drawing.Size(97, 16);
            lblReviewNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblReviewNo.TabIndex = 19;
            lblReviewNo.Text = "协查意见书编号:";
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
            lblComment.Location = new System.Drawing.Point(55, 307);
            lblComment.Name = "lblComment";
            lblComment.Size = new System.Drawing.Size(34, 16);
            lblComment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblComment.TabIndex = 37;
            lblComment.Text = "备注:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelCDA);
            this.tabControl.Controls.Add(this.tabPanelCase);
            this.tabControl.Controls.Add(this.tabPanelCreditCoverNeg);
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
            this.tabPanelCase.Controls.Add(this.btnCaseReset);
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
            this.btnCaseUpdate.Location = new System.Drawing.Point(148, 363);
            this.btnCaseUpdate.Name = "btnCaseUpdate";
            this.btnCaseUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCaseUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseUpdate.TabIndex = 1;
            this.btnCaseUpdate.Text = "编辑";
            this.btnCaseUpdate.Click += new System.EventHandler(this.UpdateCase);
            // 
            // btnCaseReset
            // 
            this.btnCaseReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseReset.Location = new System.Drawing.Point(310, 363);
            this.btnCaseReset.Name = "btnCaseReset";
            this.btnCaseReset.Size = new System.Drawing.Size(75, 23);
            this.btnCaseReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseReset.TabIndex = 3;
            this.btnCaseReset.Text = "重置";
            this.btnCaseReset.Click += new System.EventHandler(this.ResetClose);
            // 
            // btnCaseSave
            // 
            this.btnCaseSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSave.Location = new System.Drawing.Point(229, 363);
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
            this.groupPanelCase.Controls.Add(this.tbComment);
            this.groupPanelCase.Controls.Add(lblComment);
            this.groupPanelCase.Controls.Add(this.tbReviewNo);
            this.groupPanelCase.Controls.Add(lblReviewNo);
            this.groupPanelCase.Controls.Add(this.tbPaymentTerm);
            this.groupPanelCase.Controls.Add(lblPaymentTerm);
            this.groupPanelCase.Controls.Add(this.tbManagerName);
            this.groupPanelCase.Controls.Add(lblManagerName);
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
            this.groupPanelCase.Controls.Add(this.cbCaseMark);
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
            // tbComment
            // 
            // 
            // 
            // 
            this.tbComment.Border.Class = "TextBoxBorder";
            this.tbComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Comment", true));
            this.tbComment.Location = new System.Drawing.Point(98, 307);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComment.Size = new System.Drawing.Size(375, 35);
            this.tbComment.TabIndex = 38;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Case);
            // 
            // tbReviewNo
            // 
            // 
            // 
            // 
            this.tbReviewNo.Border.Class = "TextBoxBorder";
            this.tbReviewNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "ReviewNo", true));
            this.tbReviewNo.Location = new System.Drawing.Point(307, 152);
            this.tbReviewNo.Name = "tbReviewNo";
            this.tbReviewNo.Size = new System.Drawing.Size(100, 20);
            this.tbReviewNo.TabIndex = 20;
            // 
            // tbPaymentTerm
            // 
            // 
            // 
            // 
            this.tbPaymentTerm.Border.Class = "TextBoxBorder";
            this.tbPaymentTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "PaymentTerm", true));
            this.tbPaymentTerm.Location = new System.Drawing.Point(98, 222);
            this.tbPaymentTerm.Multiline = true;
            this.tbPaymentTerm.Name = "tbPaymentTerm";
            this.tbPaymentTerm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPaymentTerm.Size = new System.Drawing.Size(375, 35);
            this.tbPaymentTerm.TabIndex = 28;
            // 
            // tbManagerName
            // 
            // 
            // 
            // 
            this.tbManagerName.Border.Class = "TextBoxBorder";
            this.tbManagerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "ManagerName", true));
            this.tbManagerName.Location = new System.Drawing.Point(98, 284);
            this.tbManagerName.Name = "tbManagerName";
            this.tbManagerName.Size = new System.Drawing.Size(102, 20);
            this.tbManagerName.TabIndex = 34;
            // 
            // cbCaseTransactionType
            // 
            this.cbCaseTransactionType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "TransactionType", true));
            this.cbCaseTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseTransactionType.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbCaseTransactionType.FormattingEnabled = true;
            this.cbCaseTransactionType.Location = new System.Drawing.Point(100, 0);
            this.cbCaseTransactionType.Name = "cbCaseTransactionType";
            this.cbCaseTransactionType.Size = new System.Drawing.Size(124, 21);
            this.cbCaseTransactionType.TabIndex = 1;
            this.caseValidator.SetValidator1(this.cbCaseTransactionType, this.requiredFieldValidator1);
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
            this.cbCaseCoDepts.Location = new System.Drawing.Point(269, 174);
            this.cbCaseCoDepts.Name = "cbCaseCoDepts";
            this.cbCaseCoDepts.Size = new System.Drawing.Size(176, 21);
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
            "其他"});
            this.cbCaseOpType.Location = new System.Drawing.Point(98, 175);
            this.cbCaseOpType.Name = "cbCaseOpType";
            this.cbCaseOpType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseOpType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.tbCaseBuyerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientNameEN_1", true));
            this.tbCaseBuyerNameEN.Location = new System.Drawing.Point(180, 88);
            this.tbCaseBuyerNameEN.Name = "tbCaseBuyerNameEN";
            this.tbCaseBuyerNameEN.ReadOnly = true;
            this.tbCaseBuyerNameEN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseBuyerNameEN.TabIndex = 10;
            this.tbCaseBuyerNameEN.WatermarkText = "英文名";
            // 
            // tbCaseSellerNameEN
            // 
            // 
            // 
            // 
            this.tbCaseSellerNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientNameEN_1", true));
            this.tbCaseSellerNameEN.Location = new System.Drawing.Point(180, 46);
            this.tbCaseSellerNameEN.Name = "tbCaseSellerNameEN";
            this.tbCaseSellerNameEN.ReadOnly = true;
            this.tbCaseSellerNameEN.Size = new System.Drawing.Size(293, 20);
            this.tbCaseSellerNameEN.TabIndex = 5;
            this.tbCaseSellerNameEN.WatermarkText = "英文名";
            // 
            // tbCaseCreateUser
            // 
            // 
            // 
            // 
            this.tbCaseCreateUser.Border.Class = "TextBoxBorder";
            this.tbCaseCreateUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CreateUserName", true));
            this.tbCaseCreateUser.Location = new System.Drawing.Point(285, 285);
            this.tbCaseCreateUser.Name = "tbCaseCreateUser";
            this.tbCaseCreateUser.ReadOnly = true;
            this.tbCaseCreateUser.Size = new System.Drawing.Size(100, 20);
            this.tbCaseCreateUser.TabIndex = 36;
            // 
            // cbCaseMark
            // 
            this.cbCaseMark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseMark", true));
            this.cbCaseMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseMark.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCaseMark.Items.AddRange(new object[] {
            "申请案",
            "启动案",
            "已结案"});
            this.cbCaseMark.Location = new System.Drawing.Point(285, 263);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(100, 21);
            this.cbCaseMark.TabIndex = 32;
            // 
            // diCaseAppDate
            // 
            // 
            // 
            // 
            this.diCaseAppDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diCaseAppDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diCaseAppDate.ButtonDropDown.Visible = true;
            this.diCaseAppDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseAppDate", true));
            this.diCaseAppDate.FocusHighlightEnabled = true;
            this.diCaseAppDate.Location = new System.Drawing.Point(99, 263);
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
            // 
            // cbCaseInvoiceCurrency
            // 
            this.cbCaseInvoiceCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caseBindingSource, "InvoiceCurrency", true));
            this.cbCaseInvoiceCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseInvoiceCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseInvoiceCurrency.ItemHeight = 14;
            this.cbCaseInvoiceCurrency.Location = new System.Drawing.Point(98, 153);
            this.cbCaseInvoiceCurrency.Name = "cbCaseInvoiceCurrency";
            this.cbCaseInvoiceCurrency.Size = new System.Drawing.Size(100, 20);
            this.cbCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseInvoiceCurrency.TabIndex = 18;
            this.caseValidator.SetValidator1(this.cbCaseInvoiceCurrency, this.requiredFieldValidator2);
            // 
            // btnCaseBuyerSelect
            // 
            this.btnCaseBuyerSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseBuyerSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseBuyerSelect.Location = new System.Drawing.Point(479, 68);
            this.btnCaseBuyerSelect.Name = "btnCaseBuyerSelect";
            this.btnCaseBuyerSelect.Size = new System.Drawing.Size(20, 23);
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
            this.btnCaseSellerSelect.Size = new System.Drawing.Size(20, 23);
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
            this.btnCaseFactorSelect.Size = new System.Drawing.Size(20, 23);
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
            this.tbCaseBuyerNo.WatermarkText = "保理代码";
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
            this.tbCaseFactorCode.WatermarkText = "保理代码";
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
            this.tbCaseSellerNo.WatermarkText = "保理代码";
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
            this.colCase,
            this.colApproveType,
            this.colRequestAmount,
            this.colRequestDate,
            this.colApproveAmount,
            this.colApproveDate,
            this.colIFPrice,
            this.colComment,
            this.colCreateUserName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCoverNegs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCreditCoverNegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditCoverNegs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCreditCoverNegs.Location = new System.Drawing.Point(1, 166);
            this.dgvCreditCoverNegs.Name = "dgvCreditCoverNegs";
            this.dgvCreditCoverNegs.ReadOnly = true;
            this.dgvCreditCoverNegs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditCoverNegs.Size = new System.Drawing.Size(519, 231);
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
            // colCase
            // 
            this.colCase.DataPropertyName = "Case";
            this.colCase.HeaderText = "Case";
            this.colCase.Name = "colCase";
            this.colCase.ReadOnly = true;
            this.colCase.Visible = false;
            // 
            // colApproveType
            // 
            this.colApproveType.DataPropertyName = "ApproveType";
            this.colApproveType.HeaderText = "P/C标志";
            this.colApproveType.Name = "colApproveType";
            this.colApproveType.ReadOnly = true;
            // 
            // colRequestAmount
            // 
            this.colRequestAmount.DataPropertyName = "RequestAmount";
            this.colRequestAmount.HeaderText = "申请额度";
            this.colRequestAmount.Name = "colRequestAmount";
            this.colRequestAmount.ReadOnly = true;
            // 
            // colRequestDate
            // 
            this.colRequestDate.DataPropertyName = "RequestDate";
            this.colRequestDate.HeaderText = "申请日期";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;
            // 
            // colApproveAmount
            // 
            this.colApproveAmount.DataPropertyName = "ApproveAmount";
            this.colApproveAmount.HeaderText = "回复额度";
            this.colApproveAmount.Name = "colApproveAmount";
            this.colApproveAmount.ReadOnly = true;
            // 
            // colApproveDate
            // 
            this.colApproveDate.DataPropertyName = "ApproveDate";
            this.colApproveDate.HeaderText = "回复日期";
            this.colApproveDate.Name = "colApproveDate";
            this.colApproveDate.ReadOnly = true;
            // 
            // colIFPrice
            // 
            this.colIFPrice.DataPropertyName = "IFPrice";
            this.colIFPrice.HeaderText = "IF报价";
            this.colIFPrice.Name = "colIFPrice";
            this.colIFPrice.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // groupPanelCreditCoverNeg
            // 
            this.groupPanelCreditCoverNeg.AutoScroll = true;
            this.groupPanelCreditCoverNeg.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCreditCoverNeg.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegDelete);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegSave);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegUpdate);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegNew);
            this.groupPanelCreditCoverNeg.Controls.Add(this.btnCreditCoverNegRefresh);
            this.groupPanelCreditCoverNeg.Controls.Add(createUserNameLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbCreateUserName);
            this.groupPanelCreditCoverNeg.Controls.Add(commentLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbCreditCoverComment);
            this.groupPanelCreditCoverNeg.Controls.Add(approveTypeLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.cbApproveType);
            this.groupPanelCreditCoverNeg.Controls.Add(requestDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diRequestDate);
            this.groupPanelCreditCoverNeg.Controls.Add(approveDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diApproveDate);
            this.groupPanelCreditCoverNeg.Controls.Add(iFPriceLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbIFPrice);
            this.groupPanelCreditCoverNeg.Controls.Add(approveAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbApproveAmount);
            this.groupPanelCreditCoverNeg.Controls.Add(requestAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbRequestAmount);
            this.groupPanelCreditCoverNeg.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditCoverNeg.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCreditCoverNeg.Name = "groupPanelCreditCoverNeg";
            this.groupPanelCreditCoverNeg.Size = new System.Drawing.Size(519, 165);
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
            // btnCreditCoverNegDelete
            // 
            this.btnCreditCoverNegDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegDelete.Location = new System.Drawing.Point(398, 132);
            this.btnCreditCoverNegDelete.Name = "btnCreditCoverNegDelete";
            this.btnCreditCoverNegDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegDelete.TabIndex = 20;
            this.btnCreditCoverNegDelete.Text = "删除";
            this.btnCreditCoverNegDelete.Click += new System.EventHandler(this.DeleteCreditCoverNeg);
            // 
            // btnCreditCoverNegSave
            // 
            this.btnCreditCoverNegSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegSave.Location = new System.Drawing.Point(317, 132);
            this.btnCreditCoverNegSave.Name = "btnCreditCoverNegSave";
            this.btnCreditCoverNegSave.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegSave.TabIndex = 19;
            this.btnCreditCoverNegSave.Text = "保存";
            this.btnCreditCoverNegSave.Click += new System.EventHandler(this.SaveCreditCoverNeg);
            // 
            // btnCreditCoverNegUpdate
            // 
            this.btnCreditCoverNegUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegUpdate.Location = new System.Drawing.Point(236, 132);
            this.btnCreditCoverNegUpdate.Name = "btnCreditCoverNegUpdate";
            this.btnCreditCoverNegUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegUpdate.TabIndex = 18;
            this.btnCreditCoverNegUpdate.Text = "编辑";
            this.btnCreditCoverNegUpdate.Click += new System.EventHandler(this.UpdateCreditCoverNeg);
            // 
            // btnCreditCoverNegNew
            // 
            this.btnCreditCoverNegNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegNew.Location = new System.Drawing.Point(155, 132);
            this.btnCreditCoverNegNew.Name = "btnCreditCoverNegNew";
            this.btnCreditCoverNegNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegNew.TabIndex = 17;
            this.btnCreditCoverNegNew.Text = "新建";
            this.btnCreditCoverNegNew.Click += new System.EventHandler(this.NewCreditCoverNeg);
            // 
            // btnCreditCoverNegRefresh
            // 
            this.btnCreditCoverNegRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverNegRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverNegRefresh.Location = new System.Drawing.Point(74, 132);
            this.btnCreditCoverNegRefresh.Name = "btnCreditCoverNegRefresh";
            this.btnCreditCoverNegRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCoverNegRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverNegRefresh.TabIndex = 16;
            this.btnCreditCoverNegRefresh.Text = "刷新";
            this.btnCreditCoverNegRefresh.Click += new System.EventHandler(this.RefreshCreditCoverNegList);
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "CreateUserName", true));
            this.tbCreateUserName.Location = new System.Drawing.Point(74, 106);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCreateUserName.TabIndex = 15;
            // 
            // creditCoverNegBindingSource
            // 
            this.creditCoverNegBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CreditCoverNegotiation);
            // 
            // tbCreditCoverComment
            // 
            // 
            // 
            // 
            this.tbCreditCoverComment.Border.Class = "";
            this.tbCreditCoverComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "Comment", true));
            this.tbCreditCoverComment.Location = new System.Drawing.Point(74, 61);
            this.tbCreditCoverComment.Multiline = true;
            this.tbCreditCoverComment.Name = "tbCreditCoverComment";
            this.tbCreditCoverComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCreditCoverComment.Size = new System.Drawing.Size(433, 42);
            this.tbCreditCoverComment.TabIndex = 13;
            // 
            // cbApproveType
            // 
            this.cbApproveType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "ApproveType", true));
            this.cbApproveType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbApproveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApproveType.FormattingEnabled = true;
            this.cbApproveType.Items.AddRange(new object[] {
            "P-预额度",
            "C-正式额度"});
            this.cbApproveType.Location = new System.Drawing.Point(230, 8);
            this.cbApproveType.Name = "cbApproveType";
            this.cbApproveType.Size = new System.Drawing.Size(100, 21);
            this.cbApproveType.TabIndex = 3;
            this.creditCoverValidator.SetValidator1(this.cbApproveType, this.requiredFieldValidator8);
            // 
            // diRequestDate
            // 
            // 
            // 
            // 
            this.diRequestDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diRequestDate.ButtonDropDown.Visible = true;
            this.diRequestDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "RequestDate", true));
            this.diRequestDate.Location = new System.Drawing.Point(404, 9);
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
            this.diRequestDate.TabIndex = 5;
            this.creditCoverValidator.SetValidator1(this.diRequestDate, this.requiredFieldValidator6);
            // 
            // diApproveDate
            // 
            // 
            // 
            // 
            this.diApproveDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diApproveDate.ButtonDropDown.Visible = true;
            this.diApproveDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "ApproveDate", true));
            this.diApproveDate.Location = new System.Drawing.Point(404, 33);
            // 
            // 
            // 
            this.diApproveDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diApproveDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diApproveDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diApproveDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diApproveDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diApproveDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diApproveDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diApproveDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diApproveDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diApproveDate.Name = "diApproveDate";
            this.diApproveDate.Size = new System.Drawing.Size(103, 20);
            this.diApproveDate.TabIndex = 11;
            // 
            // tbIFPrice
            // 
            // 
            // 
            // 
            this.tbIFPrice.Border.Class = "TextBoxBorder";
            this.tbIFPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "IFPrice", true));
            this.tbIFPrice.Location = new System.Drawing.Point(230, 34);
            this.tbIFPrice.Name = "tbIFPrice";
            this.tbIFPrice.Size = new System.Drawing.Size(100, 20);
            this.tbIFPrice.TabIndex = 9;
            // 
            // tbApproveAmount
            // 
            // 
            // 
            // 
            this.tbApproveAmount.Border.Class = "TextBoxBorder";
            this.tbApproveAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "ApproveAmount", true));
            this.tbApproveAmount.Location = new System.Drawing.Point(74, 34);
            this.tbApproveAmount.Name = "tbApproveAmount";
            this.tbApproveAmount.Size = new System.Drawing.Size(100, 20);
            this.tbApproveAmount.TabIndex = 7;
            // 
            // tbRequestAmount
            // 
            // 
            // 
            // 
            this.tbRequestAmount.Border.Class = "TextBoxBorder";
            this.tbRequestAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "RequestAmount", true));
            this.tbRequestAmount.Location = new System.Drawing.Point(74, 9);
            this.tbRequestAmount.Name = "tbRequestAmount";
            this.tbRequestAmount.Size = new System.Drawing.Size(100, 20);
            this.tbRequestAmount.TabIndex = 1;
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
            this.colCDACaseCode,
            this.colCDACase,
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.colCDACode.HeaderText = "CDACode";
            this.colCDACode.Name = "colCDACode";
            this.colCDACode.ReadOnly = true;
            this.colCDACode.Visible = false;
            // 
            // colCDACaseCode
            // 
            this.colCDACaseCode.DataPropertyName = "CaseCode";
            this.colCDACaseCode.HeaderText = "案件编号";
            this.colCDACaseCode.Name = "colCDACaseCode";
            this.colCDACaseCode.ReadOnly = true;
            // 
            // colCDACase
            // 
            this.colCDACase.DataPropertyName = "Case";
            this.colCDACase.HeaderText = "Case";
            this.colCDACase.Name = "colCDACase";
            this.colCDACase.ReadOnly = true;
            this.colCDACase.Visible = false;
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
            this.caseValidator.ErrorProvider = this.caseErrorProvider;
            this.caseValidator.Highlighter = this.caseHighlighter;
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
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // caseErrorProvider
            // 
            this.caseErrorProvider.ContainerControl = this;
            this.caseErrorProvider.DataSource = this.caseBindingSource;
            this.caseErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("caseErrorProvider.Icon")));
            // 
            // caseHighlighter
            // 
            this.caseHighlighter.ContainerControl = this;
            // 
            // creditCoverValidator
            // 
            this.creditCoverValidator.ContainerControl = this;
            this.creditCoverValidator.ErrorProvider = this.creditCoverErrorProvider;
            this.creditCoverValidator.Highlighter = this.creditCoverHighlighter;
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
            // creditCoverErrorProvider
            // 
            this.creditCoverErrorProvider.ContainerControl = this;
            this.creditCoverErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("creditCoverErrorProvider.Icon")));
            // 
            // creditCoverHighlighter
            // 
            this.creditCoverHighlighter.ContainerControl = this;
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
            // CaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 424);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "CaseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "案件";
            this.Leave += new System.EventHandler(this.CaseDetail_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelCase.ResumeLayout(false);
            this.groupPanelCase.ResumeLayout(false);
            this.groupPanelCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).EndInit();
            this.tabPanelCreditCoverNeg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).EndInit();
            this.groupPanelCreditCoverNeg.ResumeLayout(false);
            this.groupPanelCreditCoverNeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRequestDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diApproveDate)).EndInit();
            this.tabPanelCDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.groupPanelCDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caseErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.SuperValidator creditCoverValidator;
        private System.Windows.Forms.ErrorProvider creditCoverErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter creditCoverHighlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator8;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRecoarse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsCreditCoverRevolving;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUGProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPUGPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReassignGracePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLineCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceGracePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeductibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLossThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionTypeComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFeeCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAValueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDADueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticePersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbManagerName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReviewNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentTerm;
        private DevComponents.DotNetBar.Controls.TextBoxX tbComment;
        private DevComponents.DotNetBar.ButtonX btnCDADelete;
    }
}