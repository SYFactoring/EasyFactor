namespace CMBC.EasyFactor.CaseMgr
{
    partial class CreditCoverNegMgr
    {
        #region?Fields?(52)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCurrency;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCDA;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsContractSigned;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private System.Windows.Forms.ContextMenuStrip cmuCreditCoverMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCoverNegs;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diBegin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diEnd;
        private DevComponents.DotNetBar.LabelX lblBuyerFactorCode;
        private DevComponents.DotNetBar.LabelX lblCaseCode;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblCreateUserName;
        private DevComponents.DotNetBar.LabelX lblCurrency;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private DevComponents.DotNetBar.LabelX lblSellerFactorCode;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverNegExport;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverSelect;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuyerFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSellerFactorCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        #endregion?Fields?

        #region?Methods?(1)?

        //?Protected?Methods?(1)?

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

        #endregion?Methods?



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbRequestType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblRequestType = new DevComponents.DotNetBar.LabelX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            this.cbIsContractSigned = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnQueryReset = new DevComponents.DotNetBar.ButtonX();
            this.cbIsCDA = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbCaseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseCode = new DevComponents.DotNetBar.LabelX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCurrency = new DevComponents.DotNetBar.LabelX();
            this.cbTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTransactionType = new DevComponents.DotNetBar.LabelX();
            this.diEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diBegin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.tbBuyerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBuyerFactorCode = new DevComponents.DotNetBar.LabelX();
            this.tbSellerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSellerFactorCode = new DevComponents.DotNetBar.LabelX();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.dgvCreditCoverNegs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuCreditCoverMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCreditCoverSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCreditCoverNegExport = new System.Windows.Forms.ToolStripMenuItem();
            this.colNegoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerFactorCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetPaymentTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).BeginInit();
            this.cmuCreditCoverMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.cbRequestType);
            this.panelQuery.Controls.Add(this.lblRequestType);
            this.panelQuery.Controls.Add(this.cbLocation);
            this.panelQuery.Controls.Add(this.lblLocation);
            this.panelQuery.Controls.Add(this.tbCreateUserName);
            this.panelQuery.Controls.Add(this.lblCreateUserName);
            this.panelQuery.Controls.Add(this.cbIsContractSigned);
            this.panelQuery.Controls.Add(this.btnQueryReset);
            this.panelQuery.Controls.Add(this.cbIsCDA);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClientName);
            this.panelQuery.Controls.Add(this.tbCaseCode);
            this.panelQuery.Controls.Add(this.lblCaseCode);
            this.panelQuery.Controls.Add(this.lblDate);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.cbCurrency);
            this.panelQuery.Controls.Add(this.lblCurrency);
            this.panelQuery.Controls.Add(this.cbTransactionType);
            this.panelQuery.Controls.Add(this.lblTransactionType);
            this.panelQuery.Controls.Add(this.diEnd);
            this.panelQuery.Controls.Add(this.diBegin);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.tbBuyerFactorCode);
            this.panelQuery.Controls.Add(this.lblBuyerFactorCode);
            this.panelQuery.Controls.Add(this.tbSellerFactorCode);
            this.panelQuery.Controls.Add(this.lblSellerFactorCode);
            this.panelQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(920, 69);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // cbRequestType
            // 
            this.cbRequestType.DisplayMember = "Text";
            this.cbRequestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequestType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRequestType.FormattingEnabled = true;
            this.cbRequestType.ItemHeight = 14;
            this.cbRequestType.Items.AddRange(new object[] {
            "",
            "P-预额度",
            "C-正式额度"});
            this.cbRequestType.Location = new System.Drawing.Point(523, 47);
            this.cbRequestType.Name = "cbRequestType";
            this.cbRequestType.Size = new System.Drawing.Size(85, 20);
            this.cbRequestType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbRequestType.TabIndex = 27;
            // 
            // lblRequestType
            // 
            this.lblRequestType.AutoSize = true;
            // 
            // 
            // 
            this.lblRequestType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRequestType.Location = new System.Drawing.Point(467, 48);
            this.lblRequestType.Name = "lblRequestType";
            this.lblRequestType.Size = new System.Drawing.Size(50, 18);
            this.lblRequestType.TabIndex = 26;
            this.lblRequestType.Text = "P/C标志";
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCreateUserName.Location = new System.Drawing.Point(676, 48);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(90, 21);
            this.tbCreateUserName.TabIndex = 18;
            // 
            // lblCreateUserName
            // 
            this.lblCreateUserName.AutoSize = true;
            // 
            // 
            // 
            this.lblCreateUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCreateUserName.Location = new System.Drawing.Point(630, 50);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 18);
            this.lblCreateUserName.TabIndex = 17;
            this.lblCreateUserName.Text = "经办人";
            // 
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsContractSigned.Location = new System.Drawing.Point(590, 6);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(125, 18);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsContractSigned.TabIndex = 19;
            this.cbIsContractSigned.Text = "是否签订保理合同";
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(716, 25);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(48, 19);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 22;
            this.btnQueryReset.Text = "重置";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // cbIsCDA
            // 
            this.cbIsCDA.AutoSize = true;
            // 
            // 
            // 
            this.cbIsCDA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsCDA.Location = new System.Drawing.Point(590, 29);
            this.cbIsCDA.Name = "cbIsCDA";
            this.cbIsCDA.Size = new System.Drawing.Size(94, 18);
            this.cbIsCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsCDA.TabIndex = 20;
            this.cbIsCDA.Text = "CDA是否签回";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientName.Location = new System.Drawing.Point(65, 3);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(133, 21);
            this.tbClientName.TabIndex = 1;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientName.Location = new System.Drawing.Point(9, 3);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 18);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "客户名称";
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCaseCode.Location = new System.Drawing.Point(260, 3);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.Size = new System.Drawing.Size(100, 21);
            this.tbCaseCode.TabIndex = 3;
            // 
            // lblCaseCode
            // 
            this.lblCaseCode.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseCode.Location = new System.Drawing.Point(204, 3);
            this.lblCaseCode.Name = "lblCaseCode";
            this.lblCaseCode.Size = new System.Drawing.Size(56, 18);
            this.lblCaseCode.TabIndex = 2;
            this.lblCaseCode.Text = "案件编号";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(204, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 18);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "申请期限";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(717, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(48, 19);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 21;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.Query);
            // 
            // cbCurrency
            // 
            this.cbCurrency.DisplayMember = "Text";
            this.cbCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.ItemHeight = 14;
            this.cbCurrency.Location = new System.Drawing.Point(260, 24);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(100, 20);
            this.cbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCurrency.TabIndex = 9;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            // 
            // 
            // 
            this.lblCurrency.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCurrency.Location = new System.Drawing.Point(204, 27);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(56, 18);
            this.lblCurrency.TabIndex = 8;
            this.lblCurrency.Text = "发票币别";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DisplayMember = "Text";
            this.cbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransactionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.ItemHeight = 14;
            this.cbTransactionType.Items.AddRange(new object[] {
            "国内卖方保理",
            "国内买方保理",
            "出口保理",
            "进口保理"});
            this.cbTransactionType.Location = new System.Drawing.Point(65, 45);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(133, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTransactionType.TabIndex = 13;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            // 
            // 
            // 
            this.lblTransactionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTransactionType.Location = new System.Drawing.Point(6, 46);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(56, 18);
            this.lblTransactionType.TabIndex = 12;
            this.lblTransactionType.Text = "业务类别";
            // 
            // diEnd
            // 
            // 
            // 
            // 
            this.diEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diEnd.ButtonDropDown.Visible = true;
            this.diEnd.IsPopupCalendarOpen = false;
            this.diEnd.Location = new System.Drawing.Point(364, 46);
            // 
            // 
            // 
            this.diEnd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diEnd.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diEnd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diEnd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diEnd.MonthCalendar.TodayButtonVisible = true;
            this.diEnd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diEnd.Name = "diEnd";
            this.diEnd.Size = new System.Drawing.Size(100, 21);
            this.diEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diEnd.TabIndex = 16;
            // 
            // diBegin
            // 
            // 
            // 
            // 
            this.diBegin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diBegin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diBegin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diBegin.ButtonDropDown.Visible = true;
            this.diBegin.IsPopupCalendarOpen = false;
            this.diBegin.Location = new System.Drawing.Point(260, 46);
            // 
            // 
            // 
            this.diBegin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diBegin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diBegin.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diBegin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diBegin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diBegin.MonthCalendar.TodayButtonVisible = true;
            this.diBegin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diBegin.Name = "diBegin";
            this.diBegin.Size = new System.Drawing.Size(100, 21);
            this.diBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diBegin.TabIndex = 15;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(771, 8);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 18);
            this.lblCount.TabIndex = 23;
            this.lblCount.Text = "获得 条记录";
            // 
            // tbBuyerFactorCode
            // 
            // 
            // 
            // 
            this.tbBuyerFactorCode.Border.Class = "TextBoxBorder";
            this.tbBuyerFactorCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbBuyerFactorCode.Location = new System.Drawing.Point(463, 25);
            this.tbBuyerFactorCode.Name = "tbBuyerFactorCode";
            this.tbBuyerFactorCode.Size = new System.Drawing.Size(100, 21);
            this.tbBuyerFactorCode.TabIndex = 11;
            // 
            // lblBuyerFactorCode
            // 
            this.lblBuyerFactorCode.AutoSize = true;
            // 
            // 
            // 
            this.lblBuyerFactorCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBuyerFactorCode.Location = new System.Drawing.Point(371, 26);
            this.lblBuyerFactorCode.Name = "lblBuyerFactorCode";
            this.lblBuyerFactorCode.Size = new System.Drawing.Size(93, 18);
            this.lblBuyerFactorCode.TabIndex = 10;
            this.lblBuyerFactorCode.Text = "买方保理商代码";
            // 
            // tbSellerFactorCode
            // 
            // 
            // 
            // 
            this.tbSellerFactorCode.Border.Class = "TextBoxBorder";
            this.tbSellerFactorCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSellerFactorCode.Location = new System.Drawing.Point(463, 4);
            this.tbSellerFactorCode.Name = "tbSellerFactorCode";
            this.tbSellerFactorCode.Size = new System.Drawing.Size(100, 21);
            this.tbSellerFactorCode.TabIndex = 5;
            // 
            // lblSellerFactorCode
            // 
            this.lblSellerFactorCode.AutoSize = true;
            // 
            // 
            // 
            this.lblSellerFactorCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSellerFactorCode.Location = new System.Drawing.Point(371, 6);
            this.lblSellerFactorCode.Name = "lblSellerFactorCode";
            this.lblSellerFactorCode.Size = new System.Drawing.Size(93, 18);
            this.lblSellerFactorCode.TabIndex = 4;
            this.lblSellerFactorCode.Text = "卖方保理商代码";
            // 
            // cbLocation
            // 
            this.cbLocation.DisplayMember = "Text";
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(65, 26);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(133, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLocation.TabIndex = 25;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLocation.Location = new System.Drawing.Point(6, 28);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "业务地区";
            // 
            // dgvCreditCoverNegs
            // 
            this.dgvCreditCoverNegs.AllowUserToAddRows = false;
            this.dgvCreditCoverNegs.AllowUserToDeleteRows = false;
            this.dgvCreditCoverNegs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCoverNegs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreditCoverNegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditCoverNegs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNegoID,
            this.colCaseCode,
            this.colSellerName,
            this.colBuyerName,
            this.colBuyerFactorCountry,
            this.colSellerFactorName,
            this.colBuyerFactorName,
            this.colTransactionType,
            this.colCaseCurrency,
            this.colRequestType,
            this.colNetPaymentTerm,
            this.colRequestAmount,
            this.colRequestDate,
            this.colReplyAmount,
            this.colReplyDate,
            this.colIFPrice,
            this.colPriceDate,
            this.colDueDate,
            this.colCreateUserName});
            this.dgvCreditCoverNegs.ContextMenuStrip = this.cmuCreditCoverMgr;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCoverNegs.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCreditCoverNegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditCoverNegs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCreditCoverNegs.Location = new System.Drawing.Point(0, 69);
            this.dgvCreditCoverNegs.Name = "dgvCreditCoverNegs";
            this.dgvCreditCoverNegs.ReadOnly = true;
            this.dgvCreditCoverNegs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCreditCoverNegs.Size = new System.Drawing.Size(920, 249);
            this.dgvCreditCoverNegs.TabIndex = 1;
            this.dgvCreditCoverNegs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvCreditCoverNegs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvCreditCoverNegsRowPostPaint);
            // 
            // cmuCreditCoverMgr
            // 
            this.cmuCreditCoverMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreditCoverSelect,
            this.menuItemCreditCoverDetail,
            this.toolStripSeparator1,
            this.menuItemCreditCoverNegExport});
            this.cmuCreditCoverMgr.Name = "cmuContractMgr";
            this.cmuCreditCoverMgr.Size = new System.Drawing.Size(149, 76);
            // 
            // menuItemCreditCoverSelect
            // 
            this.menuItemCreditCoverSelect.Name = "menuItemCreditCoverSelect";
            this.menuItemCreditCoverSelect.Size = new System.Drawing.Size(148, 22);
            this.menuItemCreditCoverSelect.Text = "选定额度申请";
            this.menuItemCreditCoverSelect.Click += new System.EventHandler(this.SelectCreditCoverNeg);
            // 
            // menuItemCreditCoverDetail
            // 
            this.menuItemCreditCoverDetail.Name = "menuItemCreditCoverDetail";
            this.menuItemCreditCoverDetail.Size = new System.Drawing.Size(148, 22);
            this.menuItemCreditCoverDetail.Text = "详细信息";
            this.menuItemCreditCoverDetail.Click += new System.EventHandler(this.DetailCreditCoverNeg);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuItemCreditCoverNegExport
            // 
            this.menuItemCreditCoverNegExport.Name = "menuItemCreditCoverNegExport";
            this.menuItemCreditCoverNegExport.Size = new System.Drawing.Size(148, 22);
            this.menuItemCreditCoverNegExport.Text = "导出额度申请";
            this.menuItemCreditCoverNegExport.Click += new System.EventHandler(this.ExportCreditCoverNeg);
            // 
            // colNegoID
            // 
            this.colNegoID.DataPropertyName = "NegoID";
            this.colNegoID.Frozen = true;
            this.colNegoID.HeaderText = "NegoID";
            this.colNegoID.Name = "colNegoID";
            this.colNegoID.ReadOnly = true;
            this.colNegoID.Visible = false;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.Frozen = true;
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            this.colCaseCode.Width = 80;
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
            this.colSellerName.Frozen = true;
            this.colSellerName.HeaderText = "卖方";
            this.colSellerName.Name = "colSellerName";
            this.colSellerName.ReadOnly = true;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "买方";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            // 
            // colBuyerFactorCountry
            // 
            this.colBuyerFactorCountry.DataPropertyName = "BuyerCountry";
            this.colBuyerFactorCountry.HeaderText = "国别";
            this.colBuyerFactorCountry.Name = "colBuyerFactorCountry";
            this.colBuyerFactorCountry.ReadOnly = true;
            this.colBuyerFactorCountry.Width = 40;
            // 
            // colSellerFactorName
            // 
            this.colSellerFactorName.DataPropertyName = "SellerFactorName";
            this.colSellerFactorName.HeaderText = "卖方保理商";
            this.colSellerFactorName.Name = "colSellerFactorName";
            this.colSellerFactorName.ReadOnly = true;
            // 
            // colBuyerFactorName
            // 
            this.colBuyerFactorName.DataPropertyName = "BuyerFactorName";
            this.colBuyerFactorName.HeaderText = "买方保理商";
            this.colBuyerFactorName.Name = "colBuyerFactorName";
            this.colBuyerFactorName.ReadOnly = true;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类型";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            // 
            // colCaseCurrency
            // 
            this.colCaseCurrency.DataPropertyName = "CaseCurrency";
            this.colCaseCurrency.HeaderText = "发票币别";
            this.colCaseCurrency.Name = "colCaseCurrency";
            this.colCaseCurrency.ReadOnly = true;
            // 
            // colRequestType
            // 
            this.colRequestType.DataPropertyName = "RequestType";
            this.colRequestType.HeaderText = "P/C标志";
            this.colRequestType.Name = "colRequestType";
            this.colRequestType.ReadOnly = true;
            // 
            // colNetPaymentTerm
            // 
            this.colNetPaymentTerm.DataPropertyName = "NetPaymentTerm";
            this.colNetPaymentTerm.HeaderText = "付款条件";
            this.colNetPaymentTerm.Name = "colNetPaymentTerm";
            this.colNetPaymentTerm.ReadOnly = true;
            this.colNetPaymentTerm.Width = 50;
            // 
            // colRequestAmount
            // 
            this.colRequestAmount.DataPropertyName = "RequestAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colRequestAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRequestAmount.HeaderText = "申请额度";
            this.colRequestAmount.Name = "colRequestAmount";
            this.colRequestAmount.ReadOnly = true;
            // 
            // colRequestDate
            // 
            this.colRequestDate.DataPropertyName = "RequestDate";
            dataGridViewCellStyle3.Format = "d";
            this.colRequestDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRequestDate.HeaderText = "申请日期";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;
            // 
            // colReplyAmount
            // 
            this.colReplyAmount.DataPropertyName = "ReplyAmount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.colReplyAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colReplyAmount.HeaderText = "回复额度";
            this.colReplyAmount.Name = "colReplyAmount";
            this.colReplyAmount.ReadOnly = true;
            // 
            // colReplyDate
            // 
            this.colReplyDate.DataPropertyName = "ReplyDate";
            dataGridViewCellStyle5.Format = "d";
            this.colReplyDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colReplyDate.HeaderText = "回复日期";
            this.colReplyDate.Name = "colReplyDate";
            this.colReplyDate.ReadOnly = true;
            // 
            // colIFPrice
            // 
            this.colIFPrice.DataPropertyName = "IFPrice";
            dataGridViewCellStyle6.Format = "p4";
            dataGridViewCellStyle6.NullValue = null;
            this.colIFPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.colIFPrice.HeaderText = "IF报价";
            this.colIFPrice.Name = "colIFPrice";
            this.colIFPrice.ReadOnly = true;
            this.colIFPrice.Width = 50;
            // 
            // colPriceDate
            // 
            this.colPriceDate.DataPropertyName = "PriceDate";
            dataGridViewCellStyle7.Format = "d";
            this.colPriceDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPriceDate.HeaderText = "报价日";
            this.colPriceDate.Name = "colPriceDate";
            this.colPriceDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle8.Format = "d";
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.colCreateUserName.Width = 50;
            // 
            // CreditCoverNegMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCreditCoverNegs);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CreditCoverNegMgr";
            this.Size = new System.Drawing.Size(920, 318);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).EndInit();
            this.cmuCreditCoverMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRequestType;
        private DevComponents.DotNetBar.LabelX lblRequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNegoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerFactorCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetPaymentTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReplyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
    }
}
