namespace CMBC.EasyFactor.CaseMgr
{
    partial class CaseMgr
    {
        #region Fields (55)

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCurrency;
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
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverNegNew;
        private DevComponents.DotNetBar.PanelEx panelCaseQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCaseQuery = new DevComponents.DotNetBar.PanelEx();
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
            this.CaseCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerFactorCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerFactorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerFactorCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerFactorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceCurrencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerDeptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoDeptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseMarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuContractMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCaseSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCaseNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverNegNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemLegerReport = new System.Windows.Forms.ToolStripMenuItem();
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
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.Class = "";
            this.cbIsContractSigned.Location = new System.Drawing.Point(393, 9);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(126, 16);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsContractSigned.TabIndex = 13;
            this.cbIsContractSigned.Text = "是否签订保理合同";
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(524, 33);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(48, 21);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 16;
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
            this.cbIsCDA.Location = new System.Drawing.Point(393, 33);
            this.cbIsCDA.Name = "cbIsCDA";
            this.cbIsCDA.Size = new System.Drawing.Size(100, 16);
            this.cbIsCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsCDA.TabIndex = 14;
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
            // 
            // 
            // 
            this.lblCaseCode.BackgroundStyle.Class = "";
            this.lblCaseCode.Location = new System.Drawing.Point(198, 6);
            this.lblCaseCode.Name = "lblCaseCode";
            this.lblCaseCode.Size = new System.Drawing.Size(59, 23);
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
            this.lblCount.Location = new System.Drawing.Point(595, 60);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 17;
            // 
            // lblDate
            // 
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.Class = "";
            this.lblDate.Location = new System.Drawing.Point(198, 53);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 23);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "申请期限";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(524, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(48, 21);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 15;
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
            this.cbCurrency.Items.AddRange(new object[] {
            "国内保理",
            "出口保理",
            "进口",
            "信保保理"});
            this.cbCurrency.Location = new System.Drawing.Point(254, 31);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(133, 20);
            this.cbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCurrency.TabIndex = 7;
            // 
            // lblCurrency
            // 
            // 
            // 
            // 
            this.lblCurrency.BackgroundStyle.Class = "";
            this.lblCurrency.Location = new System.Drawing.Point(198, 32);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(59, 23);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "发票币别";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DisplayMember = "Text";
            this.cbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.ItemHeight = 14;
            this.cbTransactionType.Location = new System.Drawing.Point(59, 57);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(133, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTransactionType.TabIndex = 9;
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
            this.lblTransactionType.TabIndex = 8;
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
            this.diEnd.Location = new System.Drawing.Point(358, 53);
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
            this.diEnd.TabIndex = 12;
            // 
            // diBegin
            // 
            // 
            // 
            // 
            this.diBegin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diBegin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diBegin.ButtonDropDown.Visible = true;
            this.diBegin.Location = new System.Drawing.Point(254, 53);
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
            this.diBegin.TabIndex = 11;
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
            this.cbOwnerDepts.TabIndex = 5;
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
            this.lblOnwerDept.TabIndex = 4;
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
            this.CaseCodeColumn,
            this.SellerCodeColumn,
            this.SellerClientColumn,
            this.SellerFactorCodeColumn,
            this.SellerFactorColumn,
            this.BuyerCodeColumn,
            this.BuyerClientColumn,
            this.BuyerFactorCodeColumn,
            this.BuyerFactorColumn,
            this.InvoiceCurrencyColumn,
            this.TransactionTypeColumn,
            this.OperationTypeColumn,
            this.OwnerDeptColumn,
            this.CoDeptColumn,
            this.AppDateColumn,
            this.CaseMarkColumn,
            this.CreateUserColumn});
            this.dgvCases.ContextMenuStrip = this.cmuContractMgr;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle3;
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
            // CaseCodeColumn
            // 
            this.CaseCodeColumn.DataPropertyName = "CaseCode";
            this.CaseCodeColumn.HeaderText = "案件编号";
            this.CaseCodeColumn.Name = "CaseCodeColumn";
            this.CaseCodeColumn.ReadOnly = true;
            this.CaseCodeColumn.Width = 80;
            // 
            // SellerCodeColumn
            // 
            this.SellerCodeColumn.DataPropertyName = "SellerCode";
            this.SellerCodeColumn.HeaderText = "卖方保理代码";
            this.SellerCodeColumn.Name = "SellerCodeColumn";
            this.SellerCodeColumn.ReadOnly = true;
            this.SellerCodeColumn.Width = 104;
            // 
            // SellerClientColumn
            // 
            this.SellerClientColumn.DataPropertyName = "SellerClient";
            this.SellerClientColumn.HeaderText = "卖方名称";
            this.SellerClientColumn.Name = "SellerClientColumn";
            this.SellerClientColumn.ReadOnly = true;
            this.SellerClientColumn.Width = 80;
            // 
            // SellerFactorCodeColumn
            // 
            this.SellerFactorCodeColumn.DataPropertyName = "SellerFactorCode";
            this.SellerFactorCodeColumn.HeaderText = "卖方保理商代码";
            this.SellerFactorCodeColumn.Name = "SellerFactorCodeColumn";
            this.SellerFactorCodeColumn.ReadOnly = true;
            this.SellerFactorCodeColumn.Width = 116;
            // 
            // SellerFactorColumn
            // 
            this.SellerFactorColumn.DataPropertyName = "SellerFactor";
            this.SellerFactorColumn.HeaderText = "卖方保理商";
            this.SellerFactorColumn.Name = "SellerFactorColumn";
            this.SellerFactorColumn.ReadOnly = true;
            this.SellerFactorColumn.Width = 92;
            // 
            // BuyerCodeColumn
            // 
            this.BuyerCodeColumn.DataPropertyName = "BuyerCode";
            this.BuyerCodeColumn.HeaderText = "买方保理代码";
            this.BuyerCodeColumn.Name = "BuyerCodeColumn";
            this.BuyerCodeColumn.ReadOnly = true;
            this.BuyerCodeColumn.Width = 104;
            // 
            // BuyerClientColumn
            // 
            this.BuyerClientColumn.DataPropertyName = "BuyerClient";
            this.BuyerClientColumn.HeaderText = "买方名称";
            this.BuyerClientColumn.Name = "BuyerClientColumn";
            this.BuyerClientColumn.ReadOnly = true;
            this.BuyerClientColumn.Width = 80;
            // 
            // BuyerFactorCodeColumn
            // 
            this.BuyerFactorCodeColumn.DataPropertyName = "BuyerFactorCode";
            this.BuyerFactorCodeColumn.HeaderText = "买方保理商代码";
            this.BuyerFactorCodeColumn.Name = "BuyerFactorCodeColumn";
            this.BuyerFactorCodeColumn.ReadOnly = true;
            this.BuyerFactorCodeColumn.Width = 116;
            // 
            // BuyerFactorColumn
            // 
            this.BuyerFactorColumn.DataPropertyName = "BuyerFactor";
            this.BuyerFactorColumn.HeaderText = "买方保理商";
            this.BuyerFactorColumn.Name = "BuyerFactorColumn";
            this.BuyerFactorColumn.ReadOnly = true;
            this.BuyerFactorColumn.Width = 92;
            // 
            // InvoiceCurrencyColumn
            // 
            this.InvoiceCurrencyColumn.DataPropertyName = "InvoiceCurrency";
            this.InvoiceCurrencyColumn.HeaderText = "发票币别";
            this.InvoiceCurrencyColumn.Name = "InvoiceCurrencyColumn";
            this.InvoiceCurrencyColumn.ReadOnly = true;
            this.InvoiceCurrencyColumn.Width = 80;
            // 
            // TransactionTypeColumn
            // 
            this.TransactionTypeColumn.DataPropertyName = "TransactionType";
            this.TransactionTypeColumn.HeaderText = "业务类别";
            this.TransactionTypeColumn.Name = "TransactionTypeColumn";
            this.TransactionTypeColumn.ReadOnly = true;
            this.TransactionTypeColumn.Width = 80;
            // 
            // OperationTypeColumn
            // 
            this.OperationTypeColumn.DataPropertyName = "OperationType";
            this.OperationTypeColumn.HeaderText = "操作类型";
            this.OperationTypeColumn.Name = "OperationTypeColumn";
            this.OperationTypeColumn.ReadOnly = true;
            this.OperationTypeColumn.Width = 80;
            // 
            // OwnerDeptColumn
            // 
            this.OwnerDeptColumn.DataPropertyName = "OwnerDepartment";
            this.OwnerDeptColumn.HeaderText = "业务归属机构";
            this.OwnerDeptColumn.Name = "OwnerDeptColumn";
            this.OwnerDeptColumn.ReadOnly = true;
            this.OwnerDeptColumn.Width = 104;
            // 
            // CoDeptColumn
            // 
            this.CoDeptColumn.DataPropertyName = "CoDepartment";
            this.CoDeptColumn.HeaderText = "业务协作机构";
            this.CoDeptColumn.Name = "CoDeptColumn";
            this.CoDeptColumn.ReadOnly = true;
            this.CoDeptColumn.Width = 104;
            // 
            // AppDateColumn
            // 
            this.AppDateColumn.DataPropertyName = "CaseAppDate";
            dataGridViewCellStyle2.Format = "d";
            this.AppDateColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.AppDateColumn.HeaderText = "申请日期";
            this.AppDateColumn.Name = "AppDateColumn";
            this.AppDateColumn.ReadOnly = true;
            this.AppDateColumn.Width = 80;
            // 
            // CaseMarkColumn
            // 
            this.CaseMarkColumn.DataPropertyName = "CaseMark";
            this.CaseMarkColumn.HeaderText = "案件状态";
            this.CaseMarkColumn.Name = "CaseMarkColumn";
            this.CaseMarkColumn.ReadOnly = true;
            this.CaseMarkColumn.Width = 80;
            // 
            // CreateUserColumn
            // 
            this.CreateUserColumn.DataPropertyName = "CreateUserName";
            this.CreateUserColumn.HeaderText = "经办人";
            this.CreateUserColumn.Name = "CreateUserColumn";
            this.CreateUserColumn.ReadOnly = true;
            this.CreateUserColumn.Width = 68;
            // 
            // cmuContractMgr
            // 
            this.cmuContractMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCaseSelect,
            this.menuItemCaseDetail,
            this.toolStripSeparator,
            this.menuItemCaseNew,
            this.menuItemCaseUpdate,
            this.menuItemCaseDelete,
            this.menuItemCreditCoverNegNew,
            this.toolStripSeparator1,
            this.menuItemLegerReport});
            this.cmuContractMgr.Name = "cmuContractMgr";
            this.cmuContractMgr.Size = new System.Drawing.Size(153, 192);
            // 
            // menuItemCaseSelect
            // 
            this.menuItemCaseSelect.Name = "menuItemCaseSelect";
            this.menuItemCaseSelect.Size = new System.Drawing.Size(152, 22);
            this.menuItemCaseSelect.Text = "选定案件";
            this.menuItemCaseSelect.Click += new System.EventHandler(this.SelectCase);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(152, 22);
            this.menuItemCaseDetail.Text = "详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemCaseNew
            // 
            this.menuItemCaseNew.Name = "menuItemCaseNew";
            this.menuItemCaseNew.Size = new System.Drawing.Size(152, 22);
            this.menuItemCaseNew.Text = "新建案件";
            this.menuItemCaseNew.Click += new System.EventHandler(this.NewCase);
            // 
            // menuItemCaseUpdate
            // 
            this.menuItemCaseUpdate.Name = "menuItemCaseUpdate";
            this.menuItemCaseUpdate.Size = new System.Drawing.Size(152, 22);
            this.menuItemCaseUpdate.Text = "更新案件";
            this.menuItemCaseUpdate.Click += new System.EventHandler(this.UpdateCase);
            // 
            // menuItemCaseDelete
            // 
            this.menuItemCaseDelete.Name = "menuItemCaseDelete";
            this.menuItemCaseDelete.Size = new System.Drawing.Size(152, 22);
            this.menuItemCaseDelete.Text = "删除案件";
            this.menuItemCaseDelete.Click += new System.EventHandler(this.DeleteCase);
            // 
            // menuItemCreditCoverNegNew
            // 
            this.menuItemCreditCoverNegNew.Name = "menuItemCreditCoverNegNew";
            this.menuItemCreditCoverNegNew.Size = new System.Drawing.Size(152, 22);
            this.menuItemCreditCoverNegNew.Text = "新建额度申请";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemLegerReport
            // 
            this.menuItemLegerReport.Name = "menuItemLegerReport";
            this.menuItemLegerReport.Size = new System.Drawing.Size(152, 22);
            this.menuItemLegerReport.Text = "导出台帐";
            this.menuItemLegerReport.Click += new System.EventHandler(this.ReportLeger);
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

        private System.Windows.Forms.DataGridViewTextBoxColumn CaseCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerFactorCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerFactorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerFactorCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerFactorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceCurrencyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerDeptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoDeptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseMarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateUserColumn;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCDA;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsContractSigned;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemLegerReport;

    }
}
