namespace CMBC.EasyFactor.CaseMgr
{
    partial class CaseMgr
    {
        #region Fields (50)

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseMark;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCurrency;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCDA;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsContractSigned;
        private DevComponents.DotNetBar.Controls.ComboTree cbOwnerDepts;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private System.Windows.Forms.ContextMenuStrip cmuContractMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCases;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diBegin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diEnd;
        private DevComponents.DotNetBar.LabelX lblCaseCode;
        private DevComponents.DotNetBar.LabelX lblCaseMark;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblCurrency;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.LabelX lblOnwerDept;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverNegNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemLegerReport;
        private DevComponents.DotNetBar.PanelEx panelCaseQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

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



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCaseQuery = new DevComponents.DotNetBar.PanelEx();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            this.cbCaseMark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCaseMark = new DevComponents.DotNetBar.LabelX();
            this.cbIsContractSigned = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnQueryReset = new DevComponents.DotNetBar.ButtonX();
            this.cbIsCDA = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbCaseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseCode = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCurrency = new DevComponents.DotNetBar.LabelX();
            this.cbTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTransactionType = new DevComponents.DotNetBar.LabelX();
            this.diEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diBegin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbOwnerDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lblOnwerDept = new DevComponents.DotNetBar.LabelX();
            this.dgvCases = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuContractMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCaseSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCaseNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverNegNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemLegerReport = new System.Windows.Forms.ToolStripMenuItem();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerFactorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerFactorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOwnerDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncomeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCaseQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.cmuContractMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCaseQuery
            // 
            this.panelCaseQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCaseQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCaseQuery.Controls.Add(this.tbCreateUserName);
            this.panelCaseQuery.Controls.Add(this.lblCreateUserName);
            this.panelCaseQuery.Controls.Add(this.cbCaseMark);
            this.panelCaseQuery.Controls.Add(this.lblCaseMark);
            this.panelCaseQuery.Controls.Add(this.cbIsContractSigned);
            this.panelCaseQuery.Controls.Add(this.btnQueryReset);
            this.panelCaseQuery.Controls.Add(this.cbIsCDA);
            this.panelCaseQuery.Controls.Add(this.tbClientName);
            this.panelCaseQuery.Controls.Add(this.lblClientName);
            this.panelCaseQuery.Controls.Add(this.tbCaseCode);
            this.panelCaseQuery.Controls.Add(this.lblCaseCode);
            this.panelCaseQuery.Controls.Add(this.lblCount);
            this.panelCaseQuery.Controls.Add(this.lblDate);
            this.panelCaseQuery.Controls.Add(this.btnQuery);
            this.panelCaseQuery.Controls.Add(this.cbCurrency);
            this.panelCaseQuery.Controls.Add(this.lblCurrency);
            this.panelCaseQuery.Controls.Add(this.cbTransactionType);
            this.panelCaseQuery.Controls.Add(this.lblTransactionType);
            this.panelCaseQuery.Controls.Add(this.diEnd);
            this.panelCaseQuery.Controls.Add(this.diBegin);
            this.panelCaseQuery.Controls.Add(this.cbOwnerDepts);
            this.panelCaseQuery.Controls.Add(this.lblOnwerDept);
            this.panelCaseQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaseQuery.Location = new System.Drawing.Point(0, 0);
            this.panelCaseQuery.Name = "panelCaseQuery";
            this.panelCaseQuery.Size = new System.Drawing.Size(761, 85);
            this.panelCaseQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCaseQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCaseQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCaseQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCaseQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCaseQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCaseQuery.Style.GradientAngle = 90;
            this.panelCaseQuery.TabIndex = 0;
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.Location = new System.Drawing.Point(460, 6);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(133, 20);
            this.tbCreateUserName.TabIndex = 5;
            // 
            // lblCreateUserName
            // 
            this.lblCreateUserName.AutoSize = true;
            // 
            // 
            // 
            this.lblCreateUserName.BackgroundStyle.Class = "";
            this.lblCreateUserName.Location = new System.Drawing.Point(404, 9);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 16);
            this.lblCreateUserName.TabIndex = 4;
            this.lblCreateUserName.Text = "经办人";
            // 
            // cbCaseMark
            // 
            this.cbCaseMark.DisplayMember = "Text";
            this.cbCaseMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseMark.FormattingEnabled = true;
            this.cbCaseMark.ItemHeight = 14;
            this.cbCaseMark.Items.AddRange(new object[] {
            "申请案",
            "启动案",
            "已结案"});
            this.cbCaseMark.Location = new System.Drawing.Point(254, 32);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(100, 20);
            this.cbCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseMark.TabIndex = 9;
            // 
            // lblCaseMark
            // 
            this.lblCaseMark.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseMark.BackgroundStyle.Class = "";
            this.lblCaseMark.Location = new System.Drawing.Point(198, 34);
            this.lblCaseMark.Name = "lblCaseMark";
            this.lblCaseMark.Size = new System.Drawing.Size(56, 16);
            this.lblCaseMark.TabIndex = 8;
            this.lblCaseMark.Text = "案件状态";
            // 
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.Class = "";
            this.cbIsContractSigned.Location = new System.Drawing.Point(376, 34);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(126, 16);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsContractSigned.TabIndex = 10;
            this.cbIsContractSigned.Text = "是否签订保理合同";
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(614, 29);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(48, 21);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 20;
            this.btnQueryReset.Text = "重置";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // cbIsCDA
            // 
            this.cbIsCDA.AutoSize = true;
            // 
            // 
            // 
            this.cbIsCDA.BackgroundStyle.Class = "";
            this.cbIsCDA.Location = new System.Drawing.Point(508, 34);
            this.cbIsCDA.Name = "cbIsCDA";
            this.cbIsCDA.Size = new System.Drawing.Size(100, 16);
            this.cbIsCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsCDA.TabIndex = 11;
            this.cbIsCDA.Text = "CDA是否签回";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(59, 6);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(133, 20);
            this.tbClientName.TabIndex = 1;
            // 
            // lblClientName
            // 
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.Class = "";
            this.lblClientName.Location = new System.Drawing.Point(3, 6);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(59, 23);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "客户名称";
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.Location = new System.Drawing.Point(254, 6);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.Size = new System.Drawing.Size(133, 20);
            this.tbCaseCode.TabIndex = 3;
            // 
            // lblCaseCode
            // 
            this.lblCaseCode.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseCode.BackgroundStyle.Class = "";
            this.lblCaseCode.Location = new System.Drawing.Point(198, 9);
            this.lblCaseCode.Name = "lblCaseCode";
            this.lblCaseCode.Size = new System.Drawing.Size(56, 16);
            this.lblCaseCode.TabIndex = 2;
            this.lblCaseCode.Text = "案件编号";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(614, 62);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 21;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.Class = "";
            this.lblDate.Location = new System.Drawing.Point(198, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 16);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "申请期限";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(614, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(48, 21);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 19;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryCase);
            // 
            // cbCurrency
            // 
            this.cbCurrency.DisplayMember = "Text";
            this.cbCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.ItemHeight = 14;
            this.cbCurrency.Location = new System.Drawing.Point(528, 56);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(80, 20);
            this.cbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCurrency.TabIndex = 18;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            // 
            // 
            // 
            this.lblCurrency.BackgroundStyle.Class = "";
            this.lblCurrency.Location = new System.Drawing.Point(466, 58);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(56, 16);
            this.lblCurrency.TabIndex = 17;
            this.lblCurrency.Text = "发票币别";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DisplayMember = "Text";
            this.cbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.ItemHeight = 14;
            this.cbTransactionType.Items.AddRange(new object[] {
            "国内卖方保理",
            "国内买方保理",
            "出口保理",
            "进口保理",
            "国际信保保理",
            "国内信保保理",
            "租赁保理"});
            this.cbTransactionType.Location = new System.Drawing.Point(59, 57);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(133, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTransactionType.TabIndex = 13;
            // 
            // lblTransactionType
            // 
            // 
            // 
            // 
            this.lblTransactionType.BackgroundStyle.Class = "";
            this.lblTransactionType.Location = new System.Drawing.Point(3, 54);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(59, 23);
            this.lblTransactionType.TabIndex = 12;
            this.lblTransactionType.Text = "业务类别";
            // 
            // diEnd
            // 
            // 
            // 
            // 
            this.diEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diEnd.ButtonDropDown.Visible = true;
            this.diEnd.ButtonFreeText.Checked = true;
            this.diEnd.FreeTextEntryMode = true;
            this.diEnd.Location = new System.Drawing.Point(360, 57);
            // 
            // 
            // 
            this.diEnd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diEnd.MonthCalendar.BackgroundStyle.Class = "";
            this.diEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diEnd.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diEnd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diEnd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diEnd.MonthCalendar.TodayButtonVisible = true;
            this.diEnd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diEnd.Name = "diEnd";
            this.diEnd.Size = new System.Drawing.Size(100, 20);
            this.diEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diEnd.TabIndex = 16;
            // 
            // diBegin
            // 
            // 
            // 
            // 
            this.diBegin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diBegin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diBegin.ButtonDropDown.Visible = true;
            this.diBegin.ButtonFreeText.Checked = true;
            this.diBegin.FreeTextEntryMode = true;
            this.diBegin.Location = new System.Drawing.Point(254, 57);
            // 
            // 
            // 
            this.diBegin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diBegin.MonthCalendar.BackgroundStyle.Class = "";
            this.diBegin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diBegin.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diBegin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diBegin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diBegin.MonthCalendar.TodayButtonVisible = true;
            this.diBegin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diBegin.Name = "diBegin";
            this.diBegin.Size = new System.Drawing.Size(100, 20);
            this.diBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diBegin.TabIndex = 15;
            // 
            // cbOwnerDepts
            // 
            this.cbOwnerDepts.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbOwnerDepts.BackgroundStyle.Class = "TextBoxBorder";
            this.cbOwnerDepts.ButtonDropDown.Visible = true;
            this.cbOwnerDepts.Location = new System.Drawing.Point(59, 31);
            this.cbOwnerDepts.Name = "cbOwnerDepts";
            this.cbOwnerDepts.Size = new System.Drawing.Size(133, 23);
            this.cbOwnerDepts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbOwnerDepts.TabIndex = 7;
            // 
            // lblOnwerDept
            // 
            // 
            // 
            // 
            this.lblOnwerDept.BackgroundStyle.Class = "";
            this.lblOnwerDept.Location = new System.Drawing.Point(3, 31);
            this.lblOnwerDept.Name = "lblOnwerDept";
            this.lblOnwerDept.Size = new System.Drawing.Size(59, 23);
            this.lblOnwerDept.TabIndex = 6;
            this.lblOnwerDept.Text = "业务归属";
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseCode,
            this.colSellerCode,
            this.colSellerClient,
            this.colSellerFactorCode,
            this.colSellerFactor,
            this.colBuyerCode,
            this.colBuyerClient,
            this.colBuyerFactorCode,
            this.colBuyerFactor,
            this.colInvoiceCurrency,
            this.colTransactionType,
            this.colOperationType,
            this.colOwnerDept,
            this.colCoDept,
            this.colAppDate,
            this.colCaseMark,
            this.colCreateUserName,
            this.colAssignAmount,
            this.colFinanceAmount,
            this.colPaymentAmount,
            this.colIncomeAmount});
            this.dgvCases.ContextMenuStrip = this.cmuContractMgr;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCases.Location = new System.Drawing.Point(0, 85);
            this.dgvCases.MultiSelect = false;
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCases.Size = new System.Drawing.Size(761, 300);
            this.dgvCases.TabIndex = 1;
            this.dgvCases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvCases.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCases_RowPostPaint);
            // 
            // cmuContractMgr
            // 
            this.cmuContractMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCaseSelect,
            this.menuItemCaseDetail,
            this.toolStripSeparator,
            this.menuItemCaseNew,
            this.menuItemCreditCoverNegNew,
            this.menuItemCaseDelete,
            this.toolStripSeparator1,
            this.menuItemLegerReport});
            this.cmuContractMgr.Name = "cmuContractMgr";
            this.cmuContractMgr.Size = new System.Drawing.Size(147, 148);
            // 
            // menuItemCaseSelect
            // 
            this.menuItemCaseSelect.Name = "menuItemCaseSelect";
            this.menuItemCaseSelect.Size = new System.Drawing.Size(146, 22);
            this.menuItemCaseSelect.Text = "选定案件";
            this.menuItemCaseSelect.Click += new System.EventHandler(this.SelectCase);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(146, 22);
            this.menuItemCaseDetail.Text = "详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemCaseNew
            // 
            this.menuItemCaseNew.Name = "menuItemCaseNew";
            this.menuItemCaseNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemCaseNew.Text = "新建案件";
            this.menuItemCaseNew.Click += new System.EventHandler(this.NewCase);
            // 
            // menuItemCreditCoverNegNew
            // 
            this.menuItemCreditCoverNegNew.Name = "menuItemCreditCoverNegNew";
            this.menuItemCreditCoverNegNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverNegNew.Text = "新建额度申请";
            this.menuItemCreditCoverNegNew.Click += new System.EventHandler(this.NewCreditCoverNeg);
            // 
            // menuItemCaseDelete
            // 
            this.menuItemCaseDelete.Name = "menuItemCaseDelete";
            this.menuItemCaseDelete.Size = new System.Drawing.Size(146, 22);
            this.menuItemCaseDelete.Text = "删除案件";
            this.menuItemCaseDelete.Click += new System.EventHandler(this.DeleteCase);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemLegerReport
            // 
            this.menuItemLegerReport.Name = "menuItemLegerReport";
            this.menuItemLegerReport.Size = new System.Drawing.Size(146, 22);
            this.menuItemLegerReport.Text = "导出台帐";
            this.menuItemLegerReport.Click += new System.EventHandler(this.ReportLeger);
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            this.colCaseCode.Width = 80;
            // 
            // colSellerCode
            // 
            this.colSellerCode.DataPropertyName = "SellerCode";
            this.colSellerCode.HeaderText = "卖方保理代码";
            this.colSellerCode.Name = "colSellerCode";
            this.colSellerCode.ReadOnly = true;
            this.colSellerCode.Width = 104;
            // 
            // colSellerClient
            // 
            this.colSellerClient.DataPropertyName = "SellerClient";
            this.colSellerClient.HeaderText = "卖方名称";
            this.colSellerClient.Name = "colSellerClient";
            this.colSellerClient.ReadOnly = true;
            this.colSellerClient.Width = 80;
            // 
            // colSellerFactorCode
            // 
            this.colSellerFactorCode.DataPropertyName = "SellerFactorCode";
            this.colSellerFactorCode.HeaderText = "卖方保理商代码";
            this.colSellerFactorCode.Name = "colSellerFactorCode";
            this.colSellerFactorCode.ReadOnly = true;
            this.colSellerFactorCode.Width = 116;
            // 
            // colSellerFactor
            // 
            this.colSellerFactor.DataPropertyName = "SellerFactor";
            this.colSellerFactor.HeaderText = "卖方保理商";
            this.colSellerFactor.Name = "colSellerFactor";
            this.colSellerFactor.ReadOnly = true;
            this.colSellerFactor.Width = 92;
            // 
            // colBuyerCode
            // 
            this.colBuyerCode.DataPropertyName = "BuyerCode";
            this.colBuyerCode.HeaderText = "买方保理代码";
            this.colBuyerCode.Name = "colBuyerCode";
            this.colBuyerCode.ReadOnly = true;
            this.colBuyerCode.Width = 104;
            // 
            // colBuyerClient
            // 
            this.colBuyerClient.DataPropertyName = "BuyerClient";
            this.colBuyerClient.HeaderText = "买方名称";
            this.colBuyerClient.Name = "colBuyerClient";
            this.colBuyerClient.ReadOnly = true;
            this.colBuyerClient.Width = 80;
            // 
            // colBuyerFactorCode
            // 
            this.colBuyerFactorCode.DataPropertyName = "BuyerFactorCode";
            this.colBuyerFactorCode.HeaderText = "买方保理商代码";
            this.colBuyerFactorCode.Name = "colBuyerFactorCode";
            this.colBuyerFactorCode.ReadOnly = true;
            this.colBuyerFactorCode.Width = 116;
            // 
            // colBuyerFactor
            // 
            this.colBuyerFactor.DataPropertyName = "BuyerFactor";
            this.colBuyerFactor.HeaderText = "买方保理商";
            this.colBuyerFactor.Name = "colBuyerFactor";
            this.colBuyerFactor.ReadOnly = true;
            this.colBuyerFactor.Width = 92;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            this.colInvoiceCurrency.Width = 80;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类别";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            this.colTransactionType.Width = 80;
            // 
            // colOperationType
            // 
            this.colOperationType.DataPropertyName = "OperationType";
            this.colOperationType.HeaderText = "操作类型";
            this.colOperationType.Name = "colOperationType";
            this.colOperationType.ReadOnly = true;
            this.colOperationType.Width = 80;
            // 
            // colOwnerDept
            // 
            this.colOwnerDept.DataPropertyName = "OwnerDepartment";
            this.colOwnerDept.HeaderText = "业务归属机构";
            this.colOwnerDept.Name = "colOwnerDept";
            this.colOwnerDept.ReadOnly = true;
            this.colOwnerDept.Width = 104;
            // 
            // colCoDept
            // 
            this.colCoDept.DataPropertyName = "CoDepartment";
            this.colCoDept.HeaderText = "业务协作机构";
            this.colCoDept.Name = "colCoDept";
            this.colCoDept.ReadOnly = true;
            this.colCoDept.Width = 104;
            // 
            // colAppDate
            // 
            this.colAppDate.DataPropertyName = "CaseAppDate";
            dataGridViewCellStyle2.Format = "d";
            this.colAppDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAppDate.HeaderText = "申请日期";
            this.colAppDate.Name = "colAppDate";
            this.colAppDate.ReadOnly = true;
            this.colAppDate.Width = 80;
            // 
            // colCaseMark
            // 
            this.colCaseMark.DataPropertyName = "CaseMark";
            this.colCaseMark.HeaderText = "案件状态";
            this.colCaseMark.Name = "colCaseMark";
            this.colCaseMark.ReadOnly = true;
            this.colCaseMark.Width = 80;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            this.colCreateUserName.Width = 68;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAssignAmount.HeaderText = "转让量";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            this.colAssignAmount.Visible = false;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFinanceAmount.HeaderText = "融资量";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            this.colFinanceAmount.Visible = false;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPaymentAmount.HeaderText = "付款量";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            this.colPaymentAmount.Visible = false;
            // 
            // colIncomeAmount
            // 
            this.colIncomeAmount.DataPropertyName = "IncomeAmount";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colIncomeAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colIncomeAmount.HeaderText = "收入";
            this.colIncomeAmount.Name = "colIncomeAmount";
            this.colIncomeAmount.ReadOnly = true;
            this.colIncomeAmount.Visible = false;
            // 
            // CaseMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCases);
            this.Controls.Add(this.panelCaseQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CaseMgr";
            this.Size = new System.Drawing.Size(761, 385);
            this.panelCaseQuery.ResumeLayout(false);
            this.panelCaseQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.cmuContractMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.LabelX lblCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerFactorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerFactorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncomeAmount;
    }
}
