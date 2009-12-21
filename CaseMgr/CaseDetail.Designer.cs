namespace CMBC.EasyFactor.CaseMgr
{
    partial class CaseDetail
    {
		#region Fields (79) 

        private DevComponents.DotNetBar.ButtonX btnCaseBuyerFactorSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseBuyerSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseClose;
        private DevComponents.DotNetBar.ButtonX btnCaseSave;
        private DevComponents.DotNetBar.ButtonX btnCaseSellerFactorSelect;
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
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseOpType;
        private DevComponents.DotNetBar.Controls.ComboTree cbCaseOwnerDepts;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNegoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbComment;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX createUserNameTextBox;
        private System.Windows.Forms.BindingSource creditCoverNegBindingSource;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCDAs;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCoverNegs;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diApproveDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diCaseAppDate;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCase;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCDA;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditCoverNeg;
        private DevComponents.DotNetBar.Controls.TextBoxX iFPriceTextBox;
        private DevComponents.DotNetBar.LabelX lblCaseAppDate;
        private DevComponents.DotNetBar.LabelX lblCaseBuyerFactor;
        private DevComponents.DotNetBar.LabelX lblCaseBuyerNo;
        private DevComponents.DotNetBar.LabelX lblCaseCoDept;
        private DevComponents.DotNetBar.LabelX lblCaseCreateUser;
        private DevComponents.DotNetBar.LabelX lblCaseInvoiceCurrency;
        private DevComponents.DotNetBar.LabelX lblCaseMark;
        private DevComponents.DotNetBar.LabelX lblCaseOpType;
        private DevComponents.DotNetBar.LabelX lblCaseOwnerDept;
        private DevComponents.DotNetBar.LabelX lblCaseSellerFactor;
        private DevComponents.DotNetBar.LabelX lblCaseSellerNo;
        private DevComponents.DotNetBar.LabelX lblCaseTransactionType;
        private DevComponents.DotNetBar.Controls.TextBoxX requestAmountTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput requestDateDateTimePicker;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemCase;
        private DevComponents.DotNetBar.TabItem tabItemCDA;
        private DevComponents.DotNetBar.TabItem tabItemCreditCoverNeg;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCase;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCDA;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCreditCoverNeg;
        private DevComponents.DotNetBar.Controls.TextBoxX tbApproveAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerFactorNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerFactorNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCreateUser;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseMark;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerFactorNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerFactorNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNo;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelCase = new DevComponents.DotNetBar.TabControlPanel();
            this.btnCaseUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseClose = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbCaseSellerFactorNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCaseBuyerFactorNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCaseCoDepts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseCoDept = new DevComponents.DotNetBar.LabelX();
            this.cbCaseOwnerDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lblCaseOwnerDept = new DevComponents.DotNetBar.LabelX();
            this.cbCaseOpType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseOpType = new DevComponents.DotNetBar.LabelX();
            this.tbCaseBuyerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseCreateUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseCreateUser = new DevComponents.DotNetBar.LabelX();
            this.cbCaseMark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseMark = new DevComponents.DotNetBar.LabelX();
            this.diCaseAppDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblCaseAppDate = new DevComponents.DotNetBar.LabelX();
            this.cbCaseTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseTransactionType = new DevComponents.DotNetBar.LabelX();
            this.cbCaseInvoiceCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseInvoiceCurrency = new DevComponents.DotNetBar.LabelX();
            this.btnCaseBuyerFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseBuyerSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSellerSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSellerFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbCaseBuyerFactorNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseBuyerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseBuyerNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseBuyerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseBuyerNo = new DevComponents.DotNetBar.LabelX();
            this.lblCaseBuyerFactor = new DevComponents.DotNetBar.LabelX();
            this.tbCaseSellerFactorNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseSellerNo = new DevComponents.DotNetBar.LabelX();
            this.lblCaseSellerFactor = new DevComponents.DotNetBar.LabelX();
            this.tabItemCase = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCreditCoverNeg = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCreditCoverNegs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colNegoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.createUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.creditCoverNegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbApproveType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.requestDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diApproveDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.iFPriceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbApproveAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requestAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemCreditCoverNeg = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCDA = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvCDAs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanelCDA = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCDANew = new DevComponents.DotNetBar.ButtonX();
            this.btnCDARefresh = new DevComponents.DotNetBar.ButtonX();
            this.tabItemCDA = new DevComponents.DotNetBar.TabItem(this.components);
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
            requestAmountLabel = new DevComponents.DotNetBar.LabelX();
            approveAmountLabel = new DevComponents.DotNetBar.LabelX();
            iFPriceLabel = new DevComponents.DotNetBar.LabelX();
            approveDateLabel = new DevComponents.DotNetBar.LabelX();
            requestDateLabel = new DevComponents.DotNetBar.LabelX();
            approveTypeLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
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
            ((System.ComponentModel.ISupportInitialize)(this.requestDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diApproveDate)).BeginInit();
            this.tabPanelCDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).BeginInit();
            this.groupPanelCDA.SuspendLayout();
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
            requestAmountLabel.Location = new System.Drawing.Point(8, 14);
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
            approveAmountLabel.Location = new System.Drawing.Point(8, 38);
            approveAmountLabel.Name = "approveAmountLabel";
            approveAmountLabel.Size = new System.Drawing.Size(59, 16);
            approveAmountLabel.TabIndex = 2;
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
            iFPriceLabel.Location = new System.Drawing.Point(180, 38);
            iFPriceLabel.Name = "iFPriceLabel";
            iFPriceLabel.Size = new System.Drawing.Size(44, 16);
            iFPriceLabel.TabIndex = 4;
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
            approveDateLabel.Location = new System.Drawing.Point(336, 38);
            approveDateLabel.Name = "approveDateLabel";
            approveDateLabel.Size = new System.Drawing.Size(59, 16);
            approveDateLabel.TabIndex = 6;
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
            requestDateLabel.Location = new System.Drawing.Point(336, 13);
            requestDateLabel.Name = "requestDateLabel";
            requestDateLabel.Size = new System.Drawing.Size(59, 16);
            requestDateLabel.TabIndex = 8;
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
            approveTypeLabel.Location = new System.Drawing.Point(177, 14);
            approveTypeLabel.Name = "approveTypeLabel";
            approveTypeLabel.Size = new System.Drawing.Size(53, 16);
            approveTypeLabel.TabIndex = 10;
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
            this.tabControl.Size = new System.Drawing.Size(521, 376);
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
            this.tabPanelCase.Controls.Add(this.btnCaseClose);
            this.tabPanelCase.Controls.Add(this.btnCaseSave);
            this.tabPanelCase.Controls.Add(this.groupPanelCase);
            this.tabPanelCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCase.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCase.Name = "tabPanelCase";
            this.tabPanelCase.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCase.Size = new System.Drawing.Size(521, 350);
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
            this.btnCaseUpdate.Location = new System.Drawing.Point(129, 320);
            this.btnCaseUpdate.Name = "btnCaseUpdate";
            this.btnCaseUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCaseUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseUpdate.TabIndex = 9;
            this.btnCaseUpdate.Text = "更新";
            this.btnCaseUpdate.Click += new System.EventHandler(this.UpdateCase);
            // 
            // btnCaseClose
            // 
            this.btnCaseClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseClose.Location = new System.Drawing.Point(291, 320);
            this.btnCaseClose.Name = "btnCaseClose";
            this.btnCaseClose.Size = new System.Drawing.Size(75, 23);
            this.btnCaseClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseClose.TabIndex = 8;
            this.btnCaseClose.Text = "关闭";
            this.btnCaseClose.Click += new System.EventHandler(this.CloseCase);
            // 
            // btnCaseSave
            // 
            this.btnCaseSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSave.Location = new System.Drawing.Point(210, 320);
            this.btnCaseSave.Name = "btnCaseSave";
            this.btnCaseSave.Size = new System.Drawing.Size(75, 23);
            this.btnCaseSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSave.TabIndex = 7;
            this.btnCaseSave.Text = "保存";
            this.btnCaseSave.Click += new System.EventHandler(this.SaveCase);
            // 
            // groupPanelCase
            // 
            this.groupPanelCase.AutoScroll = true;
            this.groupPanelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanelCase.Controls.Add(this.tbCaseSellerFactorNameEN);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerFactorNameEN);
            this.groupPanelCase.Controls.Add(this.cbCaseCoDepts);
            this.groupPanelCase.Controls.Add(this.lblCaseCoDept);
            this.groupPanelCase.Controls.Add(this.cbCaseOwnerDepts);
            this.groupPanelCase.Controls.Add(this.lblCaseOwnerDept);
            this.groupPanelCase.Controls.Add(this.cbCaseOpType);
            this.groupPanelCase.Controls.Add(this.lblCaseOpType);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNameEN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNameEN);
            this.groupPanelCase.Controls.Add(this.tbCaseCreateUser);
            this.groupPanelCase.Controls.Add(this.lblCaseCreateUser);
            this.groupPanelCase.Controls.Add(this.cbCaseMark);
            this.groupPanelCase.Controls.Add(this.lblCaseMark);
            this.groupPanelCase.Controls.Add(this.diCaseAppDate);
            this.groupPanelCase.Controls.Add(this.lblCaseAppDate);
            this.groupPanelCase.Controls.Add(this.cbCaseTransactionType);
            this.groupPanelCase.Controls.Add(this.lblCaseTransactionType);
            this.groupPanelCase.Controls.Add(this.cbCaseInvoiceCurrency);
            this.groupPanelCase.Controls.Add(this.lblCaseInvoiceCurrency);
            this.groupPanelCase.Controls.Add(this.btnCaseBuyerFactorSelect);
            this.groupPanelCase.Controls.Add(this.btnCaseBuyerSelect);
            this.groupPanelCase.Controls.Add(this.btnCaseSellerSelect);
            this.groupPanelCase.Controls.Add(this.btnCaseSellerFactorSelect);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerFactorNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerFactorCode);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseBuyerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseBuyerFactor);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerFactorNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerFactorCode);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseSellerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseSellerFactor);
            this.groupPanelCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCase.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCase.Name = "groupPanelCase";
            this.groupPanelCase.Size = new System.Drawing.Size(519, 347);
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
            this.groupPanelCase.TabIndex = 5;
            // 
            // tbCaseSellerFactorNameEN
            // 
            // 
            // 
            // 
            this.tbCaseSellerFactorNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerFactorNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerFactor.CompanyNameEN", true));
            this.tbCaseSellerFactorNameEN.Location = new System.Drawing.Point(206, 88);
            this.tbCaseSellerFactorNameEN.Name = "tbCaseSellerFactorNameEN";
            this.tbCaseSellerFactorNameEN.ReadOnly = true;
            this.tbCaseSellerFactorNameEN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseSellerFactorNameEN.TabIndex = 43;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Case);
            // 
            // tbCaseBuyerFactorNameEN
            // 
            // 
            // 
            // 
            this.tbCaseBuyerFactorNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerFactorNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerFactor.CompanyNameEN", true));
            this.tbCaseBuyerFactorNameEN.Location = new System.Drawing.Point(206, 172);
            this.tbCaseBuyerFactorNameEN.Name = "tbCaseBuyerFactorNameEN";
            this.tbCaseBuyerFactorNameEN.ReadOnly = true;
            this.tbCaseBuyerFactorNameEN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseBuyerFactorNameEN.TabIndex = 42;
            // 
            // cbCaseCoDepts
            // 
            this.cbCaseCoDepts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caseBindingSource, "CoDepartmentCode", true));
            this.cbCaseCoDepts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseCoDepts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseCoDepts.FormattingEnabled = true;
            this.cbCaseCoDepts.Location = new System.Drawing.Point(271, 213);
            this.cbCaseCoDepts.Name = "cbCaseCoDepts";
            this.cbCaseCoDepts.Size = new System.Drawing.Size(176, 21);
            this.cbCaseCoDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseCoDepts.TabIndex = 41;
            // 
            // lblCaseCoDept
            // 
            this.lblCaseCoDept.AutoSize = true;
            this.lblCaseCoDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseCoDept.BackgroundStyle.Class = "";
            this.lblCaseCoDept.Location = new System.Drawing.Point(206, 213);
            this.lblCaseCoDept.Name = "lblCaseCoDept";
            this.lblCaseCoDept.Size = new System.Drawing.Size(59, 16);
            this.lblCaseCoDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseCoDept.TabIndex = 40;
            this.lblCaseCoDept.Text = "协销分部:";
            // 
            // cbCaseOwnerDepts
            // 
            this.cbCaseOwnerDepts.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbCaseOwnerDepts.BackgroundStyle.Class = "TextBoxBorder";
            this.cbCaseOwnerDepts.ButtonDropDown.Visible = true;
            this.cbCaseOwnerDepts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caseBindingSource, "OwnerDepartmentCode", true));
            this.cbCaseOwnerDepts.Location = new System.Drawing.Point(100, 238);
            this.cbCaseOwnerDepts.Name = "cbCaseOwnerDepts";
            this.cbCaseOwnerDepts.Size = new System.Drawing.Size(278, 23);
            this.cbCaseOwnerDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseOwnerDepts.TabIndex = 39;
            // 
            // lblCaseOwnerDept
            // 
            this.lblCaseOwnerDept.AutoSize = true;
            this.lblCaseOwnerDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseOwnerDept.BackgroundStyle.Class = "";
            this.lblCaseOwnerDept.Location = new System.Drawing.Point(7, 237);
            this.lblCaseOwnerDept.Name = "lblCaseOwnerDept";
            this.lblCaseOwnerDept.Size = new System.Drawing.Size(84, 16);
            this.lblCaseOwnerDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseOwnerDept.TabIndex = 38;
            this.lblCaseOwnerDept.Text = "业务归属机构:";
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
            this.cbCaseOpType.Location = new System.Drawing.Point(100, 216);
            this.cbCaseOpType.Name = "cbCaseOpType";
            this.cbCaseOpType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseOpType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseOpType.TabIndex = 37;
            this.cbCaseOpType.SelectedIndexChanged += new System.EventHandler(this.CaseOpTypeChanged);
            // 
            // lblCaseOpType
            // 
            this.lblCaseOpType.AutoSize = true;
            this.lblCaseOpType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseOpType.BackgroundStyle.Class = "";
            this.lblCaseOpType.Location = new System.Drawing.Point(35, 213);
            this.lblCaseOpType.Name = "lblCaseOpType";
            this.lblCaseOpType.Size = new System.Drawing.Size(59, 16);
            this.lblCaseOpType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseOpType.TabIndex = 36;
            this.lblCaseOpType.Text = "操作类型:";
            // 
            // tbCaseBuyerNameEN
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientNameEN_1", true));
            this.tbCaseBuyerNameEN.Location = new System.Drawing.Point(206, 130);
            this.tbCaseBuyerNameEN.Name = "tbCaseBuyerNameEN";
            this.tbCaseBuyerNameEN.ReadOnly = true;
            this.tbCaseBuyerNameEN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseBuyerNameEN.TabIndex = 35;
            // 
            // tbCaseSellerNameEN
            // 
            // 
            // 
            // 
            this.tbCaseSellerNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNameEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientNameEN_1", true));
            this.tbCaseSellerNameEN.Location = new System.Drawing.Point(206, 46);
            this.tbCaseSellerNameEN.Name = "tbCaseSellerNameEN";
            this.tbCaseSellerNameEN.ReadOnly = true;
            this.tbCaseSellerNameEN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseSellerNameEN.TabIndex = 34;
            // 
            // tbCaseCreateUser
            // 
            // 
            // 
            // 
            this.tbCaseCreateUser.Border.Class = "TextBoxBorder";
            this.tbCaseCreateUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CreateUserName", true));
            this.tbCaseCreateUser.Location = new System.Drawing.Point(287, 284);
            this.tbCaseCreateUser.Name = "tbCaseCreateUser";
            this.tbCaseCreateUser.ReadOnly = true;
            this.tbCaseCreateUser.Size = new System.Drawing.Size(100, 20);
            this.tbCaseCreateUser.TabIndex = 33;
            // 
            // lblCaseCreateUser
            // 
            this.lblCaseCreateUser.AutoSize = true;
            this.lblCaseCreateUser.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseCreateUser.BackgroundStyle.Class = "";
            this.lblCaseCreateUser.Location = new System.Drawing.Point(227, 281);
            this.lblCaseCreateUser.Name = "lblCaseCreateUser";
            this.lblCaseCreateUser.Size = new System.Drawing.Size(47, 16);
            this.lblCaseCreateUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseCreateUser.TabIndex = 32;
            this.lblCaseCreateUser.Text = "经办人:";
            // 
            // cbCaseMark
            // 
            this.cbCaseMark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseMark", true));
            this.cbCaseMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseMark.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCaseMark.Items.AddRange(new object[] {
            "申请案",
            "交易案"});
            this.cbCaseMark.Location = new System.Drawing.Point(287, 262);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(100, 21);
            this.cbCaseMark.TabIndex = 31;
            // 
            // lblCaseMark
            // 
            this.lblCaseMark.AutoSize = true;
            this.lblCaseMark.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseMark.BackgroundStyle.Class = "";
            this.lblCaseMark.Location = new System.Drawing.Point(227, 261);
            this.lblCaseMark.Name = "lblCaseMark";
            this.lblCaseMark.Size = new System.Drawing.Size(59, 16);
            this.lblCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseMark.TabIndex = 30;
            this.lblCaseMark.Text = "案件状态:";
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
            this.diCaseAppDate.Location = new System.Drawing.Point(101, 262);
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
            this.diCaseAppDate.Size = new System.Drawing.Size(100, 20);
            this.diCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diCaseAppDate.TabIndex = 29;
            // 
            // lblCaseAppDate
            // 
            this.lblCaseAppDate.AutoSize = true;
            this.lblCaseAppDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseAppDate.BackgroundStyle.Class = "";
            this.lblCaseAppDate.Location = new System.Drawing.Point(33, 261);
            this.lblCaseAppDate.Name = "lblCaseAppDate";
            this.lblCaseAppDate.Size = new System.Drawing.Size(59, 16);
            this.lblCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseAppDate.TabIndex = 28;
            this.lblCaseAppDate.Text = "申请日期:";
            // 
            // cbCaseTransactionType
            // 
            this.cbCaseTransactionType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "TransactionType", true));
            this.cbCaseTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseTransactionType.FormattingEnabled = true;
            this.cbCaseTransactionType.ItemHeight = 14;
            this.cbCaseTransactionType.Items.AddRange(new object[] {
            "国内保理",
            "出口保理",
            "进口保理",
            "信保保理"});
            this.cbCaseTransactionType.Location = new System.Drawing.Point(100, 4);
            this.cbCaseTransactionType.Name = "cbCaseTransactionType";
            this.cbCaseTransactionType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseTransactionType.TabIndex = 27;
            this.cbCaseTransactionType.SelectionChangeCommitted += new System.EventHandler(this.CaseTransactionTypeChanged);
            // 
            // lblCaseTransactionType
            // 
            this.lblCaseTransactionType.AutoSize = true;
            this.lblCaseTransactionType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseTransactionType.BackgroundStyle.Class = "";
            this.lblCaseTransactionType.Location = new System.Drawing.Point(33, 3);
            this.lblCaseTransactionType.Name = "lblCaseTransactionType";
            this.lblCaseTransactionType.Size = new System.Drawing.Size(59, 16);
            this.lblCaseTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseTransactionType.TabIndex = 26;
            this.lblCaseTransactionType.Text = "业务类别:";
            // 
            // cbCaseInvoiceCurrency
            // 
            this.cbCaseInvoiceCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caseBindingSource, "InvoiceCurrency", true));
            this.cbCaseInvoiceCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseInvoiceCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseInvoiceCurrency.ItemHeight = 14;
            this.cbCaseInvoiceCurrency.Location = new System.Drawing.Point(100, 194);
            this.cbCaseInvoiceCurrency.Name = "cbCaseInvoiceCurrency";
            this.cbCaseInvoiceCurrency.Size = new System.Drawing.Size(100, 20);
            this.cbCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseInvoiceCurrency.TabIndex = 25;
            // 
            // lblCaseInvoiceCurrency
            // 
            this.lblCaseInvoiceCurrency.AutoSize = true;
            this.lblCaseInvoiceCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseInvoiceCurrency.BackgroundStyle.Class = "";
            this.lblCaseInvoiceCurrency.Location = new System.Drawing.Point(35, 193);
            this.lblCaseInvoiceCurrency.Name = "lblCaseInvoiceCurrency";
            this.lblCaseInvoiceCurrency.Size = new System.Drawing.Size(59, 16);
            this.lblCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseInvoiceCurrency.TabIndex = 24;
            this.lblCaseInvoiceCurrency.Text = "发票币别:";
            // 
            // btnCaseBuyerFactorSelect
            // 
            this.btnCaseBuyerFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseBuyerFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseBuyerFactorSelect.Location = new System.Drawing.Point(484, 148);
            this.btnCaseBuyerFactorSelect.Name = "btnCaseBuyerFactorSelect";
            this.btnCaseBuyerFactorSelect.Size = new System.Drawing.Size(20, 23);
            this.btnCaseBuyerFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseBuyerFactorSelect.TabIndex = 19;
            this.btnCaseBuyerFactorSelect.Text = "Q";
            this.btnCaseBuyerFactorSelect.Click += new System.EventHandler(this.CaseBuyerFactorSelect);
            // 
            // btnCaseBuyerSelect
            // 
            this.btnCaseBuyerSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseBuyerSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseBuyerSelect.Location = new System.Drawing.Point(484, 109);
            this.btnCaseBuyerSelect.Name = "btnCaseBuyerSelect";
            this.btnCaseBuyerSelect.Size = new System.Drawing.Size(20, 23);
            this.btnCaseBuyerSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseBuyerSelect.TabIndex = 18;
            this.btnCaseBuyerSelect.Text = "Q";
            this.btnCaseBuyerSelect.Click += new System.EventHandler(this.CaseBuyerSelect);
            // 
            // btnCaseSellerSelect
            // 
            this.btnCaseSellerSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSellerSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSellerSelect.Location = new System.Drawing.Point(484, 22);
            this.btnCaseSellerSelect.Name = "btnCaseSellerSelect";
            this.btnCaseSellerSelect.Size = new System.Drawing.Size(20, 23);
            this.btnCaseSellerSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSellerSelect.TabIndex = 17;
            this.btnCaseSellerSelect.Text = "Q";
            this.btnCaseSellerSelect.Click += new System.EventHandler(this.CaseSellerSelect);
            // 
            // btnCaseSellerFactorSelect
            // 
            this.btnCaseSellerFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSellerFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSellerFactorSelect.Location = new System.Drawing.Point(484, 66);
            this.btnCaseSellerFactorSelect.Name = "btnCaseSellerFactorSelect";
            this.btnCaseSellerFactorSelect.Size = new System.Drawing.Size(20, 23);
            this.btnCaseSellerFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSellerFactorSelect.TabIndex = 16;
            this.btnCaseSellerFactorSelect.Text = "Q";
            this.btnCaseSellerFactorSelect.Click += new System.EventHandler(this.SelectSellerFactor);
            // 
            // tbCaseBuyerFactorNameCN
            // 
            // 
            // 
            // 
            this.tbCaseBuyerFactorNameCN.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerFactorNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerFactor.CompanyNameCN", true));
            this.tbCaseBuyerFactorNameCN.Location = new System.Drawing.Point(206, 151);
            this.tbCaseBuyerFactorNameCN.Name = "tbCaseBuyerFactorNameCN";
            this.tbCaseBuyerFactorNameCN.ReadOnly = true;
            this.tbCaseBuyerFactorNameCN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseBuyerFactorNameCN.TabIndex = 15;
            // 
            // tbCaseBuyerFactorCode
            // 
            // 
            // 
            // 
            this.tbCaseBuyerFactorCode.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerFactorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerFactor.FactorCode", true));
            this.tbCaseBuyerFactorCode.Location = new System.Drawing.Point(100, 151);
            this.tbCaseBuyerFactorCode.Name = "tbCaseBuyerFactorCode";
            this.tbCaseBuyerFactorCode.ReadOnly = true;
            this.tbCaseBuyerFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbCaseBuyerFactorCode.TabIndex = 14;
            // 
            // tbCaseBuyerNameCN
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNameCN.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientNameCN", true));
            this.tbCaseBuyerNameCN.Location = new System.Drawing.Point(206, 109);
            this.tbCaseBuyerNameCN.Name = "tbCaseBuyerNameCN";
            this.tbCaseBuyerNameCN.ReadOnly = true;
            this.tbCaseBuyerNameCN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseBuyerNameCN.TabIndex = 13;
            // 
            // tbCaseBuyerNo
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNo.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerClient.ClientEDICode", true));
            this.tbCaseBuyerNo.Location = new System.Drawing.Point(100, 109);
            this.tbCaseBuyerNo.Name = "tbCaseBuyerNo";
            this.tbCaseBuyerNo.ReadOnly = true;
            this.tbCaseBuyerNo.Size = new System.Drawing.Size(100, 20);
            this.tbCaseBuyerNo.TabIndex = 12;
            // 
            // lblCaseBuyerNo
            // 
            this.lblCaseBuyerNo.AutoSize = true;
            this.lblCaseBuyerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseBuyerNo.BackgroundStyle.Class = "";
            this.lblCaseBuyerNo.Location = new System.Drawing.Point(57, 106);
            this.lblCaseBuyerNo.Name = "lblCaseBuyerNo";
            this.lblCaseBuyerNo.Size = new System.Drawing.Size(34, 16);
            this.lblCaseBuyerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseBuyerNo.TabIndex = 8;
            this.lblCaseBuyerNo.Text = "买方:";
            // 
            // lblCaseBuyerFactor
            // 
            this.lblCaseBuyerFactor.AutoSize = true;
            this.lblCaseBuyerFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseBuyerFactor.BackgroundStyle.Class = "";
            this.lblCaseBuyerFactor.Location = new System.Drawing.Point(20, 148);
            this.lblCaseBuyerFactor.Name = "lblCaseBuyerFactor";
            this.lblCaseBuyerFactor.Size = new System.Drawing.Size(72, 16);
            this.lblCaseBuyerFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseBuyerFactor.TabIndex = 11;
            this.lblCaseBuyerFactor.Text = "买方保理商:";
            // 
            // tbCaseSellerFactorNameCN
            // 
            // 
            // 
            // 
            this.tbCaseSellerFactorNameCN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerFactorNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerFactor.CompanyNameCN", true));
            this.tbCaseSellerFactorNameCN.Location = new System.Drawing.Point(206, 67);
            this.tbCaseSellerFactorNameCN.Name = "tbCaseSellerFactorNameCN";
            this.tbCaseSellerFactorNameCN.ReadOnly = true;
            this.tbCaseSellerFactorNameCN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseSellerFactorNameCN.TabIndex = 7;
            // 
            // tbCaseSellerFactorCode
            // 
            // 
            // 
            // 
            this.tbCaseSellerFactorCode.Border.Class = "TextBoxBorder";
            this.tbCaseSellerFactorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerFactor.FactorCode", true));
            this.tbCaseSellerFactorCode.Location = new System.Drawing.Point(100, 67);
            this.tbCaseSellerFactorCode.Name = "tbCaseSellerFactorCode";
            this.tbCaseSellerFactorCode.ReadOnly = true;
            this.tbCaseSellerFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbCaseSellerFactorCode.TabIndex = 6;
            // 
            // tbCaseSellerNameCN
            // 
            // 
            // 
            // 
            this.tbCaseSellerNameCN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNameCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerClient.ClientNameCN", true));
            this.tbCaseSellerNameCN.Location = new System.Drawing.Point(206, 25);
            this.tbCaseSellerNameCN.Name = "tbCaseSellerNameCN";
            this.tbCaseSellerNameCN.ReadOnly = true;
            this.tbCaseSellerNameCN.Size = new System.Drawing.Size(241, 20);
            this.tbCaseSellerNameCN.TabIndex = 5;
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
            this.tbCaseSellerNo.Size = new System.Drawing.Size(100, 20);
            this.tbCaseSellerNo.TabIndex = 4;
            // 
            // lblCaseSellerNo
            // 
            this.lblCaseSellerNo.AutoSize = true;
            this.lblCaseSellerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseSellerNo.BackgroundStyle.Class = "";
            this.lblCaseSellerNo.Location = new System.Drawing.Point(57, 22);
            this.lblCaseSellerNo.Name = "lblCaseSellerNo";
            this.lblCaseSellerNo.Size = new System.Drawing.Size(34, 16);
            this.lblCaseSellerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseSellerNo.TabIndex = 0;
            this.lblCaseSellerNo.Text = "卖方:";
            // 
            // lblCaseSellerFactor
            // 
            this.lblCaseSellerFactor.AutoSize = true;
            this.lblCaseSellerFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseSellerFactor.BackgroundStyle.Class = "";
            this.lblCaseSellerFactor.Location = new System.Drawing.Point(20, 64);
            this.lblCaseSellerFactor.Name = "lblCaseSellerFactor";
            this.lblCaseSellerFactor.Size = new System.Drawing.Size(72, 16);
            this.lblCaseSellerFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseSellerFactor.TabIndex = 3;
            this.lblCaseSellerFactor.Text = "卖方保理商:";
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
            this.tabPanelCreditCoverNeg.Size = new System.Drawing.Size(521, 350);
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
            this.dgvCreditCoverNegs.Size = new System.Drawing.Size(519, 183);
            this.dgvCreditCoverNegs.TabIndex = 1;
            // 
            // colNegoID
            // 
            this.colNegoID.DataPropertyName = "NegoID";
            this.colNegoID.HeaderText = "额度申请号";
            this.colNegoID.Name = "colNegoID";
            this.colNegoID.ReadOnly = true;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
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
            this.groupPanelCreditCoverNeg.Controls.Add(this.createUserNameTextBox);
            this.groupPanelCreditCoverNeg.Controls.Add(commentLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbComment);
            this.groupPanelCreditCoverNeg.Controls.Add(approveTypeLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.cbApproveType);
            this.groupPanelCreditCoverNeg.Controls.Add(requestDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.requestDateDateTimePicker);
            this.groupPanelCreditCoverNeg.Controls.Add(approveDateLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.diApproveDate);
            this.groupPanelCreditCoverNeg.Controls.Add(iFPriceLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.iFPriceTextBox);
            this.groupPanelCreditCoverNeg.Controls.Add(approveAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.tbApproveAmount);
            this.groupPanelCreditCoverNeg.Controls.Add(requestAmountLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.requestAmountTextBox);
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
            this.groupPanelCreditCoverNeg.TabIndex = 0;
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
            this.btnCreditCoverNegUpdate.Text = "更新";
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
            this.btnCreditCoverNegRefresh.Click += new System.EventHandler(this.RefreshCreditCoverNeg);
            // 
            // createUserNameTextBox
            // 
            // 
            // 
            // 
            this.createUserNameTextBox.Border.Class = "TextBoxBorder";
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(74, 106);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.createUserNameTextBox.TabIndex = 15;
            // 
            // creditCoverNegBindingSource
            // 
            this.creditCoverNegBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CreditCoverNegotiation);
            // 
            // tbComment
            // 
            // 
            // 
            // 
            this.tbComment.Border.Class = "TextBoxBorder";
            this.tbComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "Comment", true));
            this.tbComment.Location = new System.Drawing.Point(74, 61);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(433, 42);
            this.tbComment.TabIndex = 13;
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
            this.cbApproveType.TabIndex = 11;
            // 
            // requestDateDateTimePicker
            // 
            // 
            // 
            // 
            this.requestDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.requestDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditCoverNegBindingSource, "RequestDate", true));
            this.requestDateDateTimePicker.Location = new System.Drawing.Point(404, 9);
            // 
            // 
            // 
            this.requestDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.requestDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.requestDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.requestDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.requestDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.requestDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.requestDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.requestDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.requestDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.requestDateDateTimePicker.Name = "requestDateDateTimePicker";
            this.requestDateDateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.requestDateDateTimePicker.TabIndex = 9;
            // 
            // diApproveDate
            // 
            // 
            // 
            // 
            this.diApproveDate.BackgroundStyle.Class = "DateTimeInputBackground";
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
            this.diApproveDate.TabIndex = 7;
            // 
            // iFPriceTextBox
            // 
            // 
            // 
            // 
            this.iFPriceTextBox.Border.Class = "TextBoxBorder";
            this.iFPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "IFPrice", true));
            this.iFPriceTextBox.Location = new System.Drawing.Point(230, 34);
            this.iFPriceTextBox.Name = "iFPriceTextBox";
            this.iFPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.iFPriceTextBox.TabIndex = 5;
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
            this.tbApproveAmount.TabIndex = 3;
            // 
            // requestAmountTextBox
            // 
            // 
            // 
            // 
            this.requestAmountTextBox.Border.Class = "TextBoxBorder";
            this.requestAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegBindingSource, "RequestAmount", true));
            this.requestAmountTextBox.Location = new System.Drawing.Point(74, 9);
            this.requestAmountTextBox.Name = "requestAmountTextBox";
            this.requestAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestAmountTextBox.TabIndex = 1;
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
            this.tabPanelCDA.Size = new System.Drawing.Size(521, 350);
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
            this.dgvCDAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCDAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCDAs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCDAs.Location = new System.Drawing.Point(1, 39);
            this.dgvCDAs.Name = "dgvCDAs";
            this.dgvCDAs.ReadOnly = true;
            this.dgvCDAs.Size = new System.Drawing.Size(519, 310);
            this.dgvCDAs.TabIndex = 2;
            // 
            // groupPanelCDA
            // 
            this.groupPanelCDA.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCDA.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
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
            this.groupPanelCDA.TabIndex = 1;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NegoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "额度申请号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ApproveType";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RequestDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "申请日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ApproveAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "回复额度";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ApproveDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "回复日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IFPrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "IF报价";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn9.HeaderText = "备注";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn10.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // CaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 376);
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
            ((System.ComponentModel.ISupportInitialize)(this.requestDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diApproveDate)).EndInit();
            this.tabPanelCDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.groupPanelCDA.ResumeLayout(false);
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
    }
}