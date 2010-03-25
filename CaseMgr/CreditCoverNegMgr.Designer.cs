namespace CMBC.EasyFactor.CaseMgr
{
    partial class CreditCoverNegMgr
    {
		#region Fields (27) 

        private System.Windows.Forms.ContextMenuStrip cmuCreditCoverMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCoverNegs;
        private DevComponents.DotNetBar.LabelX lblBuyerFactorCode;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblSellerFactorCode;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverSelect;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuyerFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSellerFactorCode;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
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
            this.cbOwnerDepts = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lblOnwerDept = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.tbBuyerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBuyerFactorCode = new DevComponents.DotNetBar.LabelX();
            this.tbSellerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSellerFactorCode = new DevComponents.DotNetBar.LabelX();
            this.dgvCreditCoverNegs = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.colOwnerDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuCreditCoverMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCreditCoverSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverDetail = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCreditCoverNegExport = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panelQuery.Controls.Add(this.cbOwnerDepts);
            this.panelQuery.Controls.Add(this.lblOnwerDept);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.tbBuyerFactorCode);
            this.panelQuery.Controls.Add(this.lblBuyerFactorCode);
            this.panelQuery.Controls.Add(this.tbSellerFactorCode);
            this.panelQuery.Controls.Add(this.lblSellerFactorCode);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(753, 75);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.Location = new System.Drawing.Point(526, 49);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCreateUserName.TabIndex = 18;
            // 
            // lblCreateUserName
            // 
            this.lblCreateUserName.AutoSize = true;
            // 
            // 
            // 
            this.lblCreateUserName.BackgroundStyle.Class = "";
            this.lblCreateUserName.Location = new System.Drawing.Point(478, 53);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 16);
            this.lblCreateUserName.TabIndex = 17;
            this.lblCreateUserName.Text = "经办人";
            // 
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.Class = "";
            this.cbIsContractSigned.Location = new System.Drawing.Point(528, 7);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(126, 16);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsContractSigned.TabIndex = 19;
            this.cbIsContractSigned.Text = "是否签订保理合同";
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(654, 27);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(48, 21);
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
            this.cbIsCDA.BackgroundStyle.Class = "";
            this.cbIsCDA.Location = new System.Drawing.Point(528, 31);
            this.cbIsCDA.Name = "cbIsCDA";
            this.cbIsCDA.Size = new System.Drawing.Size(100, 16);
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
            this.tbClientName.Location = new System.Drawing.Point(65, 3);
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
            this.lblClientName.Location = new System.Drawing.Point(9, 3);
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
            this.tbCaseCode.Location = new System.Drawing.Point(260, 3);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.Size = new System.Drawing.Size(100, 20);
            this.tbCaseCode.TabIndex = 3;
            // 
            // lblCaseCode
            // 
            // 
            // 
            // 
            this.lblCaseCode.BackgroundStyle.Class = "";
            this.lblCaseCode.Location = new System.Drawing.Point(204, 3);
            this.lblCaseCode.Name = "lblCaseCode";
            this.lblCaseCode.Size = new System.Drawing.Size(59, 23);
            this.lblCaseCode.TabIndex = 2;
            this.lblCaseCode.Text = "案件编号";
            // 
            // lblDate
            // 
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.Class = "";
            this.lblDate.Location = new System.Drawing.Point(204, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 23);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "申请期限";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(655, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(48, 21);
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
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.ItemHeight = 14;
            this.cbCurrency.Items.AddRange(new object[] {
            "国内保理",
            "出口保理",
            "进口",
            "信保保理"});
            this.cbCurrency.Location = new System.Drawing.Point(260, 26);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(100, 20);
            this.cbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCurrency.TabIndex = 9;
            // 
            // lblCurrency
            // 
            // 
            // 
            // 
            this.lblCurrency.BackgroundStyle.Class = "";
            this.lblCurrency.Location = new System.Drawing.Point(204, 29);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(59, 23);
            this.lblCurrency.TabIndex = 8;
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
            "国内信保保理",
            "国际信保保理",
            "租赁保理"});
            this.cbTransactionType.Location = new System.Drawing.Point(65, 54);
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
            this.lblTransactionType.Location = new System.Drawing.Point(9, 51);
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
            this.diEnd.Location = new System.Drawing.Point(364, 50);
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
            this.diBegin.Location = new System.Drawing.Point(260, 50);
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
            this.cbOwnerDepts.Location = new System.Drawing.Point(65, 28);
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
            this.lblOnwerDept.Location = new System.Drawing.Point(9, 28);
            this.lblOnwerDept.Name = "lblOnwerDept";
            this.lblOnwerDept.Size = new System.Drawing.Size(59, 23);
            this.lblOnwerDept.TabIndex = 6;
            this.lblOnwerDept.Text = "业务归属";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(650, 50);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 23;
            // 
            // tbBuyerFactorCode
            // 
            // 
            // 
            // 
            this.tbBuyerFactorCode.Border.Class = "TextBoxBorder";
            this.tbBuyerFactorCode.Location = new System.Drawing.Point(456, 27);
            this.tbBuyerFactorCode.Name = "tbBuyerFactorCode";
            this.tbBuyerFactorCode.Size = new System.Drawing.Size(66, 20);
            this.tbBuyerFactorCode.TabIndex = 11;
            // 
            // lblBuyerFactorCode
            // 
            this.lblBuyerFactorCode.AutoSize = true;
            // 
            // 
            // 
            this.lblBuyerFactorCode.BackgroundStyle.Class = "";
            this.lblBuyerFactorCode.Location = new System.Drawing.Point(364, 28);
            this.lblBuyerFactorCode.Name = "lblBuyerFactorCode";
            this.lblBuyerFactorCode.Size = new System.Drawing.Size(93, 16);
            this.lblBuyerFactorCode.TabIndex = 10;
            this.lblBuyerFactorCode.Text = "买方保理商代码";
            // 
            // tbSellerFactorCode
            // 
            // 
            // 
            // 
            this.tbSellerFactorCode.Border.Class = "TextBoxBorder";
            this.tbSellerFactorCode.Location = new System.Drawing.Point(456, 4);
            this.tbSellerFactorCode.Name = "tbSellerFactorCode";
            this.tbSellerFactorCode.Size = new System.Drawing.Size(66, 20);
            this.tbSellerFactorCode.TabIndex = 5;
            // 
            // lblSellerFactorCode
            // 
            this.lblSellerFactorCode.AutoSize = true;
            // 
            // 
            // 
            this.lblSellerFactorCode.BackgroundStyle.Class = "";
            this.lblSellerFactorCode.Location = new System.Drawing.Point(364, 6);
            this.lblSellerFactorCode.Name = "lblSellerFactorCode";
            this.lblSellerFactorCode.Size = new System.Drawing.Size(93, 16);
            this.lblSellerFactorCode.TabIndex = 4;
            this.lblSellerFactorCode.Text = "卖方保理商代码";
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
            this.colOwnerDept,
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
            this.dgvCreditCoverNegs.Location = new System.Drawing.Point(0, 75);
            this.dgvCreditCoverNegs.Name = "dgvCreditCoverNegs";
            this.dgvCreditCoverNegs.ReadOnly = true;
            this.dgvCreditCoverNegs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCreditCoverNegs.Size = new System.Drawing.Size(753, 270);
            this.dgvCreditCoverNegs.TabIndex = 1;
            this.dgvCreditCoverNegs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvCreditCoverNegs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCreditCoverNegs_RowPostPaint);
            // 
            // colNegoID
            // 
            this.colNegoID.DataPropertyName = "NegoID";
            this.colNegoID.HeaderText = "NegoID";
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
            this.colCaseCode.Width = 80;
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
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
            dataGridViewCellStyle6.Format = "p3";
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
            // colOwnerDept
            // 
            this.colOwnerDept.DataPropertyName = "OwnerDept";
            this.colOwnerDept.HeaderText = "业务归属机构";
            this.colOwnerDept.Name = "colOwnerDept";
            this.colOwnerDept.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            this.colCreateUserName.Width = 50;
            // 
            // cmuCreditCoverMgr
            // 
            this.cmuCreditCoverMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreditCoverSelect,
            this.menuItemCreditCoverDetail,
            this.toolStripSeparator1,
            this.menuItemCreditCoverNegExport});
            this.cmuCreditCoverMgr.Name = "cmuContractMgr";
            this.cmuCreditCoverMgr.Size = new System.Drawing.Size(147, 76);
            // 
            // menuItemCreditCoverSelect
            // 
            this.menuItemCreditCoverSelect.Name = "menuItemCreditCoverSelect";
            this.menuItemCreditCoverSelect.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverSelect.Text = "选定额度申请";
            // 
            // menuItemCreditCoverDetail
            // 
            this.menuItemCreditCoverDetail.Name = "menuItemCreditCoverDetail";
            this.menuItemCreditCoverDetail.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverDetail.Text = "详细信息";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NegoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "NegoID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SellerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "卖方";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BuyerName";
            this.dataGridViewTextBoxColumn4.HeaderText = "买方";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BuyerCountry";
            this.dataGridViewTextBoxColumn5.HeaderText = "国别";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SellerFactorName";
            this.dataGridViewTextBoxColumn6.HeaderText = "卖方保理商";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BuyerFactorName";
            this.dataGridViewTextBoxColumn7.HeaderText = "买方保理商";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TransactionType";
            this.dataGridViewTextBoxColumn8.HeaderText = "业务类型";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CaseCurrency";
            this.dataGridViewTextBoxColumn9.HeaderText = "发票币别";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RequestType";
            this.dataGridViewTextBoxColumn10.HeaderText = "P/C标志";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RequestAmount";
            dataGridViewCellStyle10.Format = "N2";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn11.HeaderText = "申请额度";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RequestDate";
            dataGridViewCellStyle11.Format = "d";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn12.HeaderText = "申请日期";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ReplyAmount";
            dataGridViewCellStyle12.Format = "N2";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn13.HeaderText = "回复额度";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ReplyDate";
            dataGridViewCellStyle13.Format = "d";
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn14.HeaderText = "回复日期";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IFPrice";
            dataGridViewCellStyle14.Format = "d";
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn15.HeaderText = "IF报价";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "OwnerDept";
            dataGridViewCellStyle15.Format = "p3";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn16.HeaderText = "业务归属机构";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CreateUserName";
            dataGridViewCellStyle16.Format = "d";
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn17.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 50;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "DueDate";
            dataGridViewCellStyle17.Format = "d";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn18.HeaderText = "额度期限";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "OwnerDept";
            this.dataGridViewTextBoxColumn19.HeaderText = "业务归属机构";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn20.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 50;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemCreditCoverNegExport
            // 
            this.menuItemCreditCoverNegExport.Name = "menuItemCreditCoverNegExport";
            this.menuItemCreditCoverNegExport.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverNegExport.Text = "导出额度申请";
            this.menuItemCreditCoverNegExport.Click += new System.EventHandler(this.ExportCreditCoverNeg);
            // 
            // CreditCoverNegMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCreditCoverNegs);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CreditCoverNegMgr";
            this.Size = new System.Drawing.Size(753, 345);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCoverNegs)).EndInit();
            this.cmuCreditCoverMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsContractSigned;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCDA;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.LabelX lblCaseCode;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCurrency;
        private DevComponents.DotNetBar.LabelX lblCurrency;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diEnd;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diBegin;
        private DevComponents.DotNetBar.Controls.ComboTree cbOwnerDepts;
        private DevComponents.DotNetBar.LabelX lblOnwerDept;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.LabelX lblCreateUserName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverNegExport;








    }
}
