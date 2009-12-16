namespace CMBC.EasyFactor.CaseMgr
{
    partial class CaseDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label caseCodeLabel;
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelCase = new DevComponents.DotNetBar.TabControlPanel();
            this.btnCaseUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseClose = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelCase = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbCaseCoDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCaseCoDept = new DevComponents.DotNetBar.LabelX();
            this.cbCaseOwnerDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lblCaseOwnerDept = new DevComponents.DotNetBar.LabelX();
            this.cbCaseOpType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.lblCaseOpType = new DevComponents.DotNetBar.LabelX();
            this.tbCaseBuyerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNameEN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseCreateUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseCreateUser = new DevComponents.DotNetBar.LabelX();
            this.tbCaseMark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseMark = new DevComponents.DotNetBar.LabelX();
            this.diCaseAppDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblCaseAppDate = new DevComponents.DotNetBar.LabelX();
            this.cbCaseTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.lblCaseTransactionType = new DevComponents.DotNetBar.LabelX();
            this.cbCaseInvoiceCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseInvoiceCurrency = new DevComponents.DotNetBar.LabelX();
            this.btnCaseBuyerFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseBuyerSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSellerSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnCaseSellerFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbCaseBuyerFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseBuyerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseBuyerNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseBuyerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseBuyerNo = new DevComponents.DotNetBar.LabelX();
            this.lblCaseBuyerFactor = new DevComponents.DotNetBar.LabelX();
            this.tbCaseSellerFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNameCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCaseSellerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseSellerNo = new DevComponents.DotNetBar.LabelX();
            this.lblCaseSellerFactor = new DevComponents.DotNetBar.LabelX();
            this.tabItemCase = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCreditCoverNeg = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemCreditCoverNeg = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelCDA = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemCDA = new DevComponents.DotNetBar.TabItem(this.components);
            this.groupPanelCreditCoverNeg = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvCreditCoverNegs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.creditCoverNegotiationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseCodeTextBox = new System.Windows.Forms.TextBox();
            caseCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelCase.SuspendLayout();
            this.groupPanelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).BeginInit();
            this.tabPanelCreditCoverNeg.SuspendLayout();
            this.groupPanelCreditCoverNeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegotiationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelCreditCoverNeg);
            this.tabControl.Controls.Add(this.tabPanelCase);
            this.tabControl.Controls.Add(this.tabPanelCDA);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(466, 409);
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
            this.tabPanelCase.Size = new System.Drawing.Size(466, 383);
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
            this.btnCaseUpdate.Location = new System.Drawing.Point(107, 351);
            this.btnCaseUpdate.Name = "btnCaseUpdate";
            this.btnCaseUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCaseUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseUpdate.TabIndex = 9;
            this.btnCaseUpdate.Text = "更新";
            this.btnCaseUpdate.Click += new System.EventHandler(this.CaseUpdate);
            // 
            // btnCaseClose
            // 
            this.btnCaseClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseClose.Location = new System.Drawing.Point(269, 351);
            this.btnCaseClose.Name = "btnCaseClose";
            this.btnCaseClose.Size = new System.Drawing.Size(75, 23);
            this.btnCaseClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseClose.TabIndex = 8;
            this.btnCaseClose.Text = "关闭";
            this.btnCaseClose.Click += new System.EventHandler(this.CaseClose);
            // 
            // btnCaseSave
            // 
            this.btnCaseSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseSave.Location = new System.Drawing.Point(188, 351);
            this.btnCaseSave.Name = "btnCaseSave";
            this.btnCaseSave.Size = new System.Drawing.Size(75, 23);
            this.btnCaseSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSave.TabIndex = 7;
            this.btnCaseSave.Text = "保存";
            this.btnCaseSave.Click += new System.EventHandler(this.CaseSave);
            // 
            // groupPanelCase
            // 
            this.groupPanelCase.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.groupPanelCase.Controls.Add(this.tbCaseMark);
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
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerFactor);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerFactorCode);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseBuyerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseBuyerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseBuyerFactor);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerFactor);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerFactorCode);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNameCN);
            this.groupPanelCase.Controls.Add(this.tbCaseSellerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseSellerNo);
            this.groupPanelCase.Controls.Add(this.lblCaseSellerFactor);
            this.groupPanelCase.Location = new System.Drawing.Point(4, 0);
            this.groupPanelCase.Name = "groupPanelCase";
            this.groupPanelCase.Size = new System.Drawing.Size(456, 345);
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
            // cbCaseCoDepts
            // 
            this.cbCaseCoDepts.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbCaseCoDepts.BackgroundStyle.Class = "TextBoxBorder";
            this.cbCaseCoDepts.ButtonDropDown.Visible = true;
            this.cbCaseCoDepts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CoDepartmentCode", true));
            this.cbCaseCoDepts.Location = new System.Drawing.Point(271, 208);
            this.cbCaseCoDepts.Name = "cbCaseCoDepts";
            this.cbCaseCoDepts.Size = new System.Drawing.Size(176, 23);
            this.cbCaseCoDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseCoDepts.TabIndex = 41;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Case);
            // 
            // lblCaseCoDept
            // 
            this.lblCaseCoDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseCoDept.BackgroundStyle.Class = "";
            this.lblCaseCoDept.Location = new System.Drawing.Point(206, 208);
            this.lblCaseCoDept.Name = "lblCaseCoDept";
            this.lblCaseCoDept.Size = new System.Drawing.Size(99, 23);
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
            this.cbCaseOwnerDepts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "OwnerDepartmentCode", true));
            this.cbCaseOwnerDepts.Location = new System.Drawing.Point(100, 237);
            this.cbCaseOwnerDepts.Name = "cbCaseOwnerDepts";
            this.cbCaseOwnerDepts.Size = new System.Drawing.Size(278, 23);
            this.cbCaseOwnerDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseOwnerDepts.TabIndex = 39;
            // 
            // lblCaseOwnerDept
            // 
            this.lblCaseOwnerDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseOwnerDept.BackgroundStyle.Class = "";
            this.lblCaseOwnerDept.Location = new System.Drawing.Point(7, 237);
            this.lblCaseOwnerDept.Name = "lblCaseOwnerDept";
            this.lblCaseOwnerDept.Size = new System.Drawing.Size(99, 23);
            this.lblCaseOwnerDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseOwnerDept.TabIndex = 38;
            this.lblCaseOwnerDept.Text = "业务归属机构:";
            // 
            // cbCaseOpType
            // 
            this.cbCaseOpType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "OperationType", true));
            this.cbCaseOpType.DisplayMember = "Text";
            this.cbCaseOpType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseOpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseOpType.ItemHeight = 14;
            this.cbCaseOpType.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6,
            this.comboItem7});
            this.cbCaseOpType.Location = new System.Drawing.Point(100, 211);
            this.cbCaseOpType.Name = "cbCaseOpType";
            this.cbCaseOpType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseOpType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseOpType.TabIndex = 37;
            this.cbCaseOpType.SelectedIndexChanged += new System.EventHandler(this.cbCaseOpType_SelectedIndexChanged);
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "自营";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "协销";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "其他";
            // 
            // lblCaseOpType
            // 
            this.lblCaseOpType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseOpType.BackgroundStyle.Class = "";
            this.lblCaseOpType.Location = new System.Drawing.Point(7, 211);
            this.lblCaseOpType.Name = "lblCaseOpType";
            this.lblCaseOpType.Size = new System.Drawing.Size(99, 23);
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
            this.tbCaseBuyerNameEN.Location = new System.Drawing.Point(206, 134);
            this.tbCaseBuyerNameEN.Name = "tbCaseBuyerNameEN";
            this.tbCaseBuyerNameEN.ReadOnly = true;
            this.tbCaseBuyerNameEN.Size = new System.Drawing.Size(213, 20);
            this.tbCaseBuyerNameEN.TabIndex = 35;
            // 
            // tbCaseSellerNameEN
            // 
            // 
            // 
            // 
            this.tbCaseSellerNameEN.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNameEN.Location = new System.Drawing.Point(206, 59);
            this.tbCaseSellerNameEN.Name = "tbCaseSellerNameEN";
            this.tbCaseSellerNameEN.ReadOnly = true;
            this.tbCaseSellerNameEN.Size = new System.Drawing.Size(213, 20);
            this.tbCaseSellerNameEN.TabIndex = 34;
            // 
            // tbCaseCreateUser
            // 
            // 
            // 
            // 
            this.tbCaseCreateUser.Border.Class = "TextBoxBorder";
            this.tbCaseCreateUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CreateUserName", true));
            this.tbCaseCreateUser.Location = new System.Drawing.Point(319, 309);
            this.tbCaseCreateUser.Name = "tbCaseCreateUser";
            this.tbCaseCreateUser.ReadOnly = true;
            this.tbCaseCreateUser.Size = new System.Drawing.Size(100, 20);
            this.tbCaseCreateUser.TabIndex = 33;
            // 
            // lblCaseCreateUser
            // 
            this.lblCaseCreateUser.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseCreateUser.BackgroundStyle.Class = "";
            this.lblCaseCreateUser.Location = new System.Drawing.Point(226, 306);
            this.lblCaseCreateUser.Name = "lblCaseCreateUser";
            this.lblCaseCreateUser.Size = new System.Drawing.Size(99, 23);
            this.lblCaseCreateUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseCreateUser.TabIndex = 32;
            this.lblCaseCreateUser.Text = "经办人:";
            // 
            // tbCaseMark
            // 
            // 
            // 
            // 
            this.tbCaseMark.Border.Class = "TextBoxBorder";
            this.tbCaseMark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseMark", true));
            this.tbCaseMark.Location = new System.Drawing.Point(319, 282);
            this.tbCaseMark.Name = "tbCaseMark";
            this.tbCaseMark.ReadOnly = true;
            this.tbCaseMark.Size = new System.Drawing.Size(100, 20);
            this.tbCaseMark.TabIndex = 31;
            // 
            // lblCaseMark
            // 
            this.lblCaseMark.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseMark.BackgroundStyle.Class = "";
            this.lblCaseMark.Location = new System.Drawing.Point(226, 282);
            this.lblCaseMark.Name = "lblCaseMark";
            this.lblCaseMark.Size = new System.Drawing.Size(99, 23);
            this.lblCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseMark.TabIndex = 30;
            this.lblCaseMark.Text = "案件状态";
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
            this.diCaseAppDate.Location = new System.Drawing.Point(100, 285);
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
            this.lblCaseAppDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseAppDate.BackgroundStyle.Class = "";
            this.lblCaseAppDate.Location = new System.Drawing.Point(7, 285);
            this.lblCaseAppDate.Name = "lblCaseAppDate";
            this.lblCaseAppDate.Size = new System.Drawing.Size(99, 23);
            this.lblCaseAppDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseAppDate.TabIndex = 28;
            this.lblCaseAppDate.Text = "申请日期:";
            // 
            // cbCaseTransactionType
            // 
            this.cbCaseTransactionType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "TransactionType", true));
            this.cbCaseTransactionType.DisplayMember = "Text";
            this.cbCaseTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseTransactionType.ItemHeight = 14;
            this.cbCaseTransactionType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.cbCaseTransactionType.Location = new System.Drawing.Point(100, 4);
            this.cbCaseTransactionType.Name = "cbCaseTransactionType";
            this.cbCaseTransactionType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseTransactionType.TabIndex = 27;
            this.cbCaseTransactionType.SelectedIndexChanged += new System.EventHandler(this.cbCaseTransactionType_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "国内保理";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "出口保理";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "进口保理";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "信保保理";
            // 
            // lblCaseTransactionType
            // 
            this.lblCaseTransactionType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseTransactionType.BackgroundStyle.Class = "";
            this.lblCaseTransactionType.Location = new System.Drawing.Point(7, 4);
            this.lblCaseTransactionType.Name = "lblCaseTransactionType";
            this.lblCaseTransactionType.Size = new System.Drawing.Size(99, 23);
            this.lblCaseTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseTransactionType.TabIndex = 26;
            this.lblCaseTransactionType.Text = "业务类别:";
            // 
            // cbCaseInvoiceCurrency
            // 
            this.cbCaseInvoiceCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "InvoiceCurrency", true));
            this.cbCaseInvoiceCurrency.DisplayMember = "Text";
            this.cbCaseInvoiceCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseInvoiceCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseInvoiceCurrency.ItemHeight = 14;
            this.cbCaseInvoiceCurrency.Location = new System.Drawing.Point(100, 185);
            this.cbCaseInvoiceCurrency.Name = "cbCaseInvoiceCurrency";
            this.cbCaseInvoiceCurrency.Size = new System.Drawing.Size(100, 20);
            this.cbCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseInvoiceCurrency.TabIndex = 25;
            // 
            // lblCaseInvoiceCurrency
            // 
            this.lblCaseInvoiceCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseInvoiceCurrency.BackgroundStyle.Class = "";
            this.lblCaseInvoiceCurrency.Location = new System.Drawing.Point(7, 185);
            this.lblCaseInvoiceCurrency.Name = "lblCaseInvoiceCurrency";
            this.lblCaseInvoiceCurrency.Size = new System.Drawing.Size(99, 23);
            this.lblCaseInvoiceCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseInvoiceCurrency.TabIndex = 24;
            this.lblCaseInvoiceCurrency.Text = "发票币别:";
            // 
            // btnCaseBuyerFactorSelect
            // 
            this.btnCaseBuyerFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaseBuyerFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaseBuyerFactorSelect.Location = new System.Drawing.Point(427, 156);
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
            this.btnCaseBuyerSelect.Location = new System.Drawing.Point(427, 104);
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
            this.btnCaseSellerSelect.Location = new System.Drawing.Point(427, 30);
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
            this.btnCaseSellerFactorSelect.Location = new System.Drawing.Point(427, 80);
            this.btnCaseSellerFactorSelect.Name = "btnCaseSellerFactorSelect";
            this.btnCaseSellerFactorSelect.Size = new System.Drawing.Size(20, 23);
            this.btnCaseSellerFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaseSellerFactorSelect.TabIndex = 16;
            this.btnCaseSellerFactorSelect.Text = "Q";
            this.btnCaseSellerFactorSelect.Click += new System.EventHandler(this.CaseSellerFactorSelect);
            // 
            // tbCaseBuyerFactor
            // 
            // 
            // 
            // 
            this.tbCaseBuyerFactor.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerFactor.Location = new System.Drawing.Point(206, 159);
            this.tbCaseBuyerFactor.Name = "tbCaseBuyerFactor";
            this.tbCaseBuyerFactor.ReadOnly = true;
            this.tbCaseBuyerFactor.Size = new System.Drawing.Size(213, 20);
            this.tbCaseBuyerFactor.TabIndex = 15;
            // 
            // tbCaseBuyerFactorCode
            // 
            // 
            // 
            // 
            this.tbCaseBuyerFactorCode.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerFactorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerFactorCode", true));
            this.tbCaseBuyerFactorCode.Location = new System.Drawing.Point(100, 159);
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
            this.tbCaseBuyerNameCN.Location = new System.Drawing.Point(206, 108);
            this.tbCaseBuyerNameCN.Name = "tbCaseBuyerNameCN";
            this.tbCaseBuyerNameCN.ReadOnly = true;
            this.tbCaseBuyerNameCN.Size = new System.Drawing.Size(213, 20);
            this.tbCaseBuyerNameCN.TabIndex = 13;
            // 
            // tbCaseBuyerNo
            // 
            // 
            // 
            // 
            this.tbCaseBuyerNo.Border.Class = "TextBoxBorder";
            this.tbCaseBuyerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "BuyerCode", true));
            this.tbCaseBuyerNo.Location = new System.Drawing.Point(100, 108);
            this.tbCaseBuyerNo.Name = "tbCaseBuyerNo";
            this.tbCaseBuyerNo.ReadOnly = true;
            this.tbCaseBuyerNo.Size = new System.Drawing.Size(100, 20);
            this.tbCaseBuyerNo.TabIndex = 12;
            // 
            // lblCaseBuyerNo
            // 
            this.lblCaseBuyerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseBuyerNo.BackgroundStyle.Class = "";
            this.lblCaseBuyerNo.Location = new System.Drawing.Point(7, 105);
            this.lblCaseBuyerNo.Name = "lblCaseBuyerNo";
            this.lblCaseBuyerNo.Size = new System.Drawing.Size(87, 23);
            this.lblCaseBuyerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseBuyerNo.TabIndex = 8;
            this.lblCaseBuyerNo.Text = "买方:";
            // 
            // lblCaseBuyerFactor
            // 
            this.lblCaseBuyerFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseBuyerFactor.BackgroundStyle.Class = "";
            this.lblCaseBuyerFactor.Location = new System.Drawing.Point(7, 156);
            this.lblCaseBuyerFactor.Name = "lblCaseBuyerFactor";
            this.lblCaseBuyerFactor.Size = new System.Drawing.Size(80, 23);
            this.lblCaseBuyerFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseBuyerFactor.TabIndex = 11;
            this.lblCaseBuyerFactor.Text = "买方保理商:";
            // 
            // tbCaseSellerFactor
            // 
            // 
            // 
            // 
            this.tbCaseSellerFactor.Border.Class = "TextBoxBorder";
            this.tbCaseSellerFactor.Location = new System.Drawing.Point(206, 82);
            this.tbCaseSellerFactor.Name = "tbCaseSellerFactor";
            this.tbCaseSellerFactor.ReadOnly = true;
            this.tbCaseSellerFactor.Size = new System.Drawing.Size(213, 20);
            this.tbCaseSellerFactor.TabIndex = 7;
            // 
            // tbCaseSellerFactorCode
            // 
            // 
            // 
            // 
            this.tbCaseSellerFactorCode.Border.Class = "TextBoxBorder";
            this.tbCaseSellerFactorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerFactorCode", true));
            this.tbCaseSellerFactorCode.Location = new System.Drawing.Point(100, 82);
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
            this.tbCaseSellerNameCN.Location = new System.Drawing.Point(206, 33);
            this.tbCaseSellerNameCN.Name = "tbCaseSellerNameCN";
            this.tbCaseSellerNameCN.ReadOnly = true;
            this.tbCaseSellerNameCN.Size = new System.Drawing.Size(213, 20);
            this.tbCaseSellerNameCN.TabIndex = 5;
            // 
            // tbCaseSellerNo
            // 
            // 
            // 
            // 
            this.tbCaseSellerNo.Border.Class = "TextBoxBorder";
            this.tbCaseSellerNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "SellerCode", true));
            this.tbCaseSellerNo.Location = new System.Drawing.Point(100, 33);
            this.tbCaseSellerNo.Name = "tbCaseSellerNo";
            this.tbCaseSellerNo.ReadOnly = true;
            this.tbCaseSellerNo.Size = new System.Drawing.Size(100, 20);
            this.tbCaseSellerNo.TabIndex = 4;
            // 
            // lblCaseSellerNo
            // 
            this.lblCaseSellerNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseSellerNo.BackgroundStyle.Class = "";
            this.lblCaseSellerNo.Location = new System.Drawing.Point(7, 33);
            this.lblCaseSellerNo.Name = "lblCaseSellerNo";
            this.lblCaseSellerNo.Size = new System.Drawing.Size(87, 23);
            this.lblCaseSellerNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseSellerNo.TabIndex = 0;
            this.lblCaseSellerNo.Text = "卖方:";
            // 
            // lblCaseSellerFactor
            // 
            this.lblCaseSellerFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCaseSellerFactor.BackgroundStyle.Class = "";
            this.lblCaseSellerFactor.Location = new System.Drawing.Point(7, 82);
            this.lblCaseSellerFactor.Name = "lblCaseSellerFactor";
            this.lblCaseSellerFactor.Size = new System.Drawing.Size(87, 23);
            this.lblCaseSellerFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCaseSellerFactor.TabIndex = 3;
            this.lblCaseSellerFactor.Text = "卖方保理商:";
            // 
            // tabItemCase
            // 
            this.tabItemCase.AttachedControl = this.tabPanelCase;
            this.tabItemCase.Name = "tabItemCase";
            this.tabItemCase.Text = "案件";
            // 
            // tabPanelCreditCoverNeg
            // 
            this.tabPanelCreditCoverNeg.Controls.Add(this.dgvCreditCoverNegs);
            this.tabPanelCreditCoverNeg.Controls.Add(this.groupPanelCreditCoverNeg);
            this.tabPanelCreditCoverNeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCreditCoverNeg.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCreditCoverNeg.Name = "tabPanelCreditCoverNeg";
            this.tabPanelCreditCoverNeg.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCreditCoverNeg.Size = new System.Drawing.Size(466, 383);
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
            // tabItemCreditCoverNeg
            // 
            this.tabItemCreditCoverNeg.AttachedControl = this.tabPanelCreditCoverNeg;
            this.tabItemCreditCoverNeg.Name = "tabItemCreditCoverNeg";
            this.tabItemCreditCoverNeg.Text = "关联额度";
            // 
            // tabPanelCDA
            // 
            this.tabPanelCDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelCDA.Location = new System.Drawing.Point(0, 26);
            this.tabPanelCDA.Name = "tabPanelCDA";
            this.tabPanelCDA.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelCDA.Size = new System.Drawing.Size(466, 383);
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
            // tabItemCDA
            // 
            this.tabItemCDA.AttachedControl = this.tabPanelCDA;
            this.tabItemCDA.Name = "tabItemCDA";
            this.tabItemCDA.Text = "额度通知书";
            // 
            // groupPanelCreditCoverNeg
            // 
            this.groupPanelCreditCoverNeg.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelCreditCoverNeg.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelCreditCoverNeg.Controls.Add(caseCodeLabel);
            this.groupPanelCreditCoverNeg.Controls.Add(this.caseCodeTextBox);
            this.groupPanelCreditCoverNeg.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelCreditCoverNeg.Location = new System.Drawing.Point(1, 1);
            this.groupPanelCreditCoverNeg.Name = "groupPanelCreditCoverNeg";
            this.groupPanelCreditCoverNeg.Size = new System.Drawing.Size(464, 224);
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
            // dgvCreditCoverNegs
            // 
            this.dgvCreditCoverNegs.AllowUserToAddRows = false;
            this.dgvCreditCoverNegs.AllowUserToDeleteRows = false;
            this.dgvCreditCoverNegs.AllowUserToOrderColumns = true;
            this.dgvCreditCoverNegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCoverNegs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreditCoverNegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditCoverNegs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCreditCoverNegs.Location = new System.Drawing.Point(1, 225);
            this.dgvCreditCoverNegs.Name = "dgvCreditCoverNegs";
            this.dgvCreditCoverNegs.ReadOnly = true;
            this.dgvCreditCoverNegs.Size = new System.Drawing.Size(464, 157);
            this.dgvCreditCoverNegs.TabIndex = 1;
            // 
            // creditCoverNegotiationBindingSource
            // 
            this.creditCoverNegotiationBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CreditCoverNegotiation);
            // 
            // caseCodeLabel
            // 
            caseCodeLabel.AutoSize = true;
            caseCodeLabel.Location = new System.Drawing.Point(17, 11);
            caseCodeLabel.Name = "caseCodeLabel";
            caseCodeLabel.Size = new System.Drawing.Size(62, 13);
            caseCodeLabel.TabIndex = 0;
            caseCodeLabel.Text = "Case Code:";
            // 
            // caseCodeTextBox
            // 
            this.caseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditCoverNegotiationBindingSource, "CaseCode", true));
            this.caseCodeTextBox.Location = new System.Drawing.Point(85, 8);
            this.caseCodeTextBox.Name = "caseCodeTextBox";
            this.caseCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.caseCodeTextBox.TabIndex = 1;
            // 
            // CaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 409);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "CaseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CaseDetail";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelCase.ResumeLayout(false);
            this.groupPanelCase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diCaseAppDate)).EndInit();
            this.tabPanelCreditCoverNeg.ResumeLayout(false);
            this.groupPanelCreditCoverNeg.ResumeLayout(false);
            this.groupPanelCreditCoverNeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCoverNegotiationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCase;
        private DevComponents.DotNetBar.TabItem tabItemCase;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCreditCoverNeg;
        private DevComponents.DotNetBar.TabItem tabItemCreditCoverNeg;
        private DevComponents.DotNetBar.TabControlPanel tabPanelCDA;
        private DevComponents.DotNetBar.TabItem tabItemCDA;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCase;
        private DevComponents.DotNetBar.Controls.ComboTree cbCaseCoDepts;
        private DevComponents.DotNetBar.LabelX lblCaseCoDept;
        private DevComponents.DotNetBar.Controls.ComboTree cbCaseOwnerDepts;
        private DevComponents.DotNetBar.LabelX lblCaseOwnerDept;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseOpType;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.DotNetBar.LabelX lblCaseOpType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameEN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCreateUser;
        private DevComponents.DotNetBar.LabelX lblCaseCreateUser;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseMark;
        private DevComponents.DotNetBar.LabelX lblCaseMark;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diCaseAppDate;
        private DevComponents.DotNetBar.LabelX lblCaseAppDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseTransactionType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.LabelX lblCaseTransactionType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseInvoiceCurrency;
        private DevComponents.DotNetBar.LabelX lblCaseInvoiceCurrency;
        private DevComponents.DotNetBar.ButtonX btnCaseBuyerFactorSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseBuyerSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseSellerSelect;
        private DevComponents.DotNetBar.ButtonX btnCaseSellerFactorSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseBuyerNo;
        private DevComponents.DotNetBar.LabelX lblCaseBuyerNo;
        private DevComponents.DotNetBar.LabelX lblCaseBuyerFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNameCN;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseSellerNo;
        private DevComponents.DotNetBar.LabelX lblCaseSellerNo;
        private DevComponents.DotNetBar.LabelX lblCaseSellerFactor;
        private DevComponents.DotNetBar.ButtonX btnCaseUpdate;
        private DevComponents.DotNetBar.ButtonX btnCaseClose;
        private DevComponents.DotNetBar.ButtonX btnCaseSave;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCoverNegs;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelCreditCoverNeg;
        private System.Windows.Forms.TextBox caseCodeTextBox;
        private System.Windows.Forms.BindingSource creditCoverNegotiationBindingSource;
    }
}