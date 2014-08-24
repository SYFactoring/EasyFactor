using CMBC.EasyFactor.Utils;
namespace CMBC.EasyFactor.CaseMgr
{
    partial class CDAMgr
    {
        #region?Fields?(54)?

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCheckStatus;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCDA;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diBegin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diEnd;
        private DevComponents.DotNetBar.LabelX lbcCDACode;
        private DevComponents.DotNetBar.LabelX lblCheckStatus;
        private DevComponents.DotNetBar.LabelX lblCreateUserName;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.LabelX lblFactorName;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDAReport;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDAExport;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheck;
        private System.Windows.Forms.ToolStripMenuItem menuItemReject;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDAUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCDACode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        #endregion?Fields?



        #region Fields (59)

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private System.Windows.Forms.ContextMenuStrip cmuCDAMgr;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCDAs;
        private DevComponents.DotNetBar.LabelX lblContractCode;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDANew;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDASelect;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

        #endregion Fields


        #region Methods (1)

        // Protected Methods (1)

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

        #endregion Methods


        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.tbCDACode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbcCDACode = new DevComponents.DotNetBar.LabelX();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.cbTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTransactionType = new DevComponents.DotNetBar.LabelX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.diEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diBegin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbIsCDA = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            this.cbCheckStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCheckStatus = new DevComponents.DotNetBar.LabelX();
            this.tbFactorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorName = new DevComponents.DotNetBar.LabelX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContractCode = new DevComponents.DotNetBar.LabelX();
            this.dgvCDAs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuCDAMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCDASelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCDANew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDAUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCDAReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDAExport = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colCDACode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsRecoarse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNotice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditCoverPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLineCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceLinePeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHighestFinanceLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIFPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFeeCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceRatioType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDAStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDASignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).BeginInit();
            this.cmuCDAMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelQuery.Controls.Add(this.tbCDACode);
            this.panelQuery.Controls.Add(this.lbcCDACode);
            this.panelQuery.Controls.Add(this.cbLocation);
            this.panelQuery.Controls.Add(this.lblLocation);
            this.panelQuery.Controls.Add(this.cbTransactionType);
            this.panelQuery.Controls.Add(this.lblTransactionType);
            this.panelQuery.Controls.Add(this.lblDate);
            this.panelQuery.Controls.Add(this.diEnd);
            this.panelQuery.Controls.Add(this.diBegin);
            this.panelQuery.Controls.Add(this.cbIsCDA);
            this.panelQuery.Controls.Add(this.tbCreateUserName);
            this.panelQuery.Controls.Add(this.lblCreateUserName);
            this.panelQuery.Controls.Add(this.cbCheckStatus);
            this.panelQuery.Controls.Add(this.lblCheckStatus);
            this.panelQuery.Controls.Add(this.tbFactorName);
            this.panelQuery.Controls.Add(this.lblFactorName);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClientName);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbContractCode);
            this.panelQuery.Controls.Add(this.lblContractCode);
            this.panelQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(978, 45);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // tbCDACode
            // 
            // 
            // 
            // 
            this.tbCDACode.Border.Class = "TextBoxBorder";
            this.tbCDACode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCDACode.Location = new System.Drawing.Point(86, 23);
            this.tbCDACode.Name = "tbCDACode";
            this.tbCDACode.Size = new System.Drawing.Size(100, 21);
            this.tbCDACode.TabIndex = 3;
            // 
            // lbcCDACode
            // 
            this.lbcCDACode.AutoSize = true;
            // 
            // 
            // 
            this.lbcCDACode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbcCDACode.Location = new System.Drawing.Point(25, 25);
            this.lbcCDACode.Name = "lbcCDACode";
            this.lbcCDACode.Size = new System.Drawing.Size(50, 18);
            this.lbcCDACode.TabIndex = 2;
            this.lbcCDACode.Text = "CDA编号";
            // 
            // cbLocation
            // 
            this.cbLocation.DisplayMember = "Text";
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(418, 23);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(113, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbLocation.TabIndex = 11;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLocation.Location = new System.Drawing.Point(362, 24);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 18);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "业务地区";
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
            "进口保理"});
            this.cbTransactionType.Location = new System.Drawing.Point(418, 3);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(113, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbTransactionType.TabIndex = 9;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            // 
            // 
            // 
            this.lblTransactionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTransactionType.Location = new System.Drawing.Point(362, 4);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(56, 18);
            this.lblTransactionType.TabIndex = 8;
            this.lblTransactionType.Text = "业务类别";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(537, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 18);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "查询期限";
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
            this.diEnd.ButtonFreeText.Checked = true;
            this.diEnd.FreeTextEntryMode = true;
            this.diEnd.IsPopupCalendarOpen = false;
            this.diEnd.Location = new System.Drawing.Point(679, 24);
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
            this.diEnd.Size = new System.Drawing.Size(78, 21);
            this.diEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.diBegin.ButtonFreeText.Checked = true;
            this.diBegin.FreeTextEntryMode = true;
            this.diBegin.IsPopupCalendarOpen = false;
            this.diBegin.Location = new System.Drawing.Point(592, 24);
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
            this.diBegin.Size = new System.Drawing.Size(81, 21);
            this.diBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.diBegin.TabIndex = 15;
            // 
            // cbIsCDA
            // 
            this.cbIsCDA.AutoSize = true;
            // 
            // 
            // 
            this.cbIsCDA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsCDA.Checked = true;
            this.cbIsCDA.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIsCDA.CheckValue = null;
            this.cbIsCDA.Location = new System.Drawing.Point(763, 27);
            this.cbIsCDA.Name = "cbIsCDA";
            this.cbIsCDA.Size = new System.Drawing.Size(94, 18);
            this.cbIsCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbIsCDA.TabIndex = 19;
            this.cbIsCDA.Text = "CDA是否签回";
            this.cbIsCDA.ThreeState = true;
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCreateUserName.Location = new System.Drawing.Point(749, 4);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 21);
            this.tbCreateUserName.TabIndex = 18;
            // 
            // lblCreateUserName
            // 
            this.lblCreateUserName.AutoSize = true;
            // 
            // 
            // 
            this.lblCreateUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCreateUserName.Location = new System.Drawing.Point(699, 4);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 18);
            this.lblCreateUserName.TabIndex = 17;
            this.lblCreateUserName.Text = "经办人";
            // 
            // cbCheckStatus
            // 
            this.cbCheckStatus.DisplayMember = "Text";
            this.cbCheckStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCheckStatus.FormattingEnabled = true;
            this.cbCheckStatus.ItemHeight = 14;
            this.cbCheckStatus.Items.AddRange(new object[] {
            "",
            "未审核",
            "已审核",
            "审核未通过",
            "已失效"});
            this.cbCheckStatus.Location = new System.Drawing.Point(592, 3);
            this.cbCheckStatus.Name = "cbCheckStatus";
            this.cbCheckStatus.Size = new System.Drawing.Size(101, 20);
            this.cbCheckStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbCheckStatus.TabIndex = 13;
            // 
            // lblCheckStatus
            // 
            this.lblCheckStatus.AutoSize = true;
            // 
            // 
            // 
            this.lblCheckStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCheckStatus.Location = new System.Drawing.Point(537, 4);
            this.lblCheckStatus.Name = "lblCheckStatus";
            this.lblCheckStatus.Size = new System.Drawing.Size(56, 18);
            this.lblCheckStatus.TabIndex = 12;
            this.lblCheckStatus.Text = "审核状态";
            // 
            // tbFactorName
            // 
            // 
            // 
            // 
            this.tbFactorName.Border.Class = "TextBoxBorder";
            this.tbFactorName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFactorName.Location = new System.Drawing.Point(255, 23);
            this.tbFactorName.Name = "tbFactorName";
            this.tbFactorName.Size = new System.Drawing.Size(100, 21);
            this.tbFactorName.TabIndex = 7;
            // 
            // lblFactorName
            // 
            this.lblFactorName.AutoSize = true;
            // 
            // 
            // 
            this.lblFactorName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFactorName.Location = new System.Drawing.Point(205, 25);
            this.lblFactorName.Name = "lblFactorName";
            this.lblFactorName.Size = new System.Drawing.Size(44, 18);
            this.lblFactorName.TabIndex = 6;
            this.lblFactorName.Text = "保理商";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientName.Location = new System.Drawing.Point(255, 3);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 21);
            this.tbClientName.TabIndex = 5;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientName.Location = new System.Drawing.Point(197, 5);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 18);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "客户名称";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(869, 27);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 18);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "获得 条记录";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(869, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(47, 21);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnQuery.TabIndex = 20;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryCDAs);
            // 
            // tbContractCode
            // 
            // 
            // 
            // 
            this.tbContractCode.Border.Class = "TextBoxBorder";
            this.tbContractCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbContractCode.Location = new System.Drawing.Point(86, 3);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(100, 21);
            this.tbContractCode.TabIndex = 1;
            // 
            // lblContractCode
            // 
            this.lblContractCode.AutoSize = true;
            // 
            // 
            // 
            this.lblContractCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContractCode.Location = new System.Drawing.Point(3, 6);
            this.lblContractCode.Name = "lblContractCode";
            this.lblContractCode.Size = new System.Drawing.Size(81, 18);
            this.lblContractCode.TabIndex = 0;
            this.lblContractCode.Text = "保理合同编号";
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCDAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCDAs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCDACode,
            this.colCaseCode,
            this.colSellerName,
            this.colBuyerName,
            this.colFactorName,
            this.colTransactionType,
            this.colInvoiceCurrency,
            this.colIsRecoarse,
            this.colIsNotice,
            this.colAssignType,
            this.colCreditCoverCurr,
            this.colCreditCover,
            this.colCreditCoverPeriodBegin,
            this.colCreditCoverPeriodEnd,
            this.colFinanceLineCurr,
            this.colFinanceLine,
            this.colFinanceLinePeriodBegin,
            this.colFinanceLinePeriodEnd,
            this.colHighestFinanceLine,
            this.colPaymentTerms,
            this.colPrice,
            this.colIFPrice,
            this.colCommissionType,
            this.colHandFeeCurr,
            this.colHandFee,
            this.colFinanceRatioType,
            this.colCDAStatus,
            this.colIsSigned,
            this.colCDASignDate,
            this.colCreateUserName,
            this.colCheckUserName,
            this.colCheckDate});
            this.dgvCDAs.ContextMenuStrip = this.cmuCDAMgr;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCDAs.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCDAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCDAs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCDAs.Location = new System.Drawing.Point(0, 45);
            this.dgvCDAs.Name = "dgvCDAs";
            this.dgvCDAs.ReadOnly = true;
            this.dgvCDAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCDAs.Size = new System.Drawing.Size(978, 326);
            this.dgvCDAs.TabIndex = 1;
            this.dgvCDAs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvCDAs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCDAsCellFormatting);
            this.dgvCDAs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvCDAsDataBindingComplete);
            this.dgvCDAs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvCDAsRowPostPaint);
            // 
            // cmuCDAMgr
            // 
            this.cmuCDAMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCDASelect,
            this.menuItemCDADetail,
            this.toolStripSeparator,
            this.menuItemCDANew,
            this.menuItemCDADelete,
            this.menuItemCDAUpdate,
            this.toolStripSeparator1,
            this.menuItemCheck,
            this.menuItemReject,
            this.toolStripSeparator2,
            this.menuItemCDAReport,
            this.menuItemCDAExport});
            this.cmuCDAMgr.Name = "cmuContractMgr";
            this.cmuCDAMgr.Size = new System.Drawing.Size(185, 220);
            // 
            // menuItemCDASelect
            // 
            this.menuItemCDASelect.Name = "menuItemCDASelect";
            this.menuItemCDASelect.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDASelect.Text = "选定CDA(&S)";
            this.menuItemCDASelect.Click += new System.EventHandler(this.SelectCDA);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDADetail.Text = "详细信息(&M)";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // menuItemCDANew
            // 
            this.menuItemCDANew.Name = "menuItemCDANew";
            this.menuItemCDANew.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDANew.Text = "新建CDA(&N)";
            this.menuItemCDANew.Click += new System.EventHandler(this.NewCDA);
            // 
            // menuItemCDADelete
            // 
            this.menuItemCDADelete.Name = "menuItemCDADelete";
            this.menuItemCDADelete.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDADelete.Text = "删除CDA(&D)";
            this.menuItemCDADelete.Click += new System.EventHandler(this.DeleteCDA);
            // 
            // menuItemCDAUpdate
            // 
            this.menuItemCDAUpdate.Name = "menuItemCDAUpdate";
            this.menuItemCDAUpdate.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDAUpdate.Text = "更新CDA状态(&U)";
            this.menuItemCDAUpdate.Click += new System.EventHandler(this.UpdateCDAStatus);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // menuItemCheck
            // 
            this.menuItemCheck.Name = "menuItemCheck";
            this.menuItemCheck.Size = new System.Drawing.Size(184, 22);
            this.menuItemCheck.Text = "审核通过(&P)";
            this.menuItemCheck.Click += new System.EventHandler(this.Check);
            // 
            // menuItemReject
            // 
            this.menuItemReject.Name = "menuItemReject";
            this.menuItemReject.Size = new System.Drawing.Size(184, 22);
            this.menuItemReject.Text = "审核拒绝(&R)";
            this.menuItemReject.Click += new System.EventHandler(this.Reject);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // menuItemCDAReport
            // 
            this.menuItemCDAReport.Name = "menuItemCDAReport";
            this.menuItemCDAReport.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDAReport.Text = "生成保理额度通知书";
            this.menuItemCDAReport.Click += new System.EventHandler(this.ReportCDA);
            // 
            // menuItemCDAExport
            // 
            this.menuItemCDAExport.Name = "menuItemCDAExport";
            this.menuItemCDAExport.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDAExport.Text = "导出额度通知书";
            this.menuItemCDAExport.Click += new System.EventHandler(this.ExportCDAs);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CDACode";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "CDA编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SellerName";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "卖方名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BuyerName";
            this.dataGridViewTextBoxColumn4.HeaderText = "买方名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FactorName";
            this.dataGridViewTextBoxColumn5.HeaderText = "保理商";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TransactionType";
            this.dataGridViewTextBoxColumn6.HeaderText = "业务类别";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InvoiceCurrency";
            this.dataGridViewTextBoxColumn7.HeaderText = "发票币别";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IsRecoarse";
            this.dataGridViewTextBoxColumn8.HeaderText = "是否有追";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 61;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IsNotice";
            this.dataGridViewTextBoxColumn9.HeaderText = "明/暗保理";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 66;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AssignType";
            this.dataGridViewTextBoxColumn10.HeaderText = "转让方式";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CreditCoverCurr";
            this.dataGridViewTextBoxColumn11.HeaderText = "额度币别";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CreditCover";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn12.HeaderText = "买方信用风险额度";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 128;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CreditCoverPeriodBegin";
            dataGridViewCellStyle14.Format = "d";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn13.HeaderText = "有效期(始)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CreditCoverPeriodEnd";
            dataGridViewCellStyle15.Format = "d";
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn14.HeaderText = "有效期(终)";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "FinanceLineCurr";
            this.dataGridViewTextBoxColumn15.HeaderText = "额度币别";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 61;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "FinanceLine";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn16.HeaderText = "预付款额度";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn16.Width = 73;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "FinanceLinePeriodBegin";
            dataGridViewCellStyle17.Format = "d";
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn17.HeaderText = "有效期(始)";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 86;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "FinanceLinePeriodEnd";
            dataGridViewCellStyle18.Format = "d";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn18.HeaderText = "有效期(终)";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 86;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "HighestFinanceLine";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn19.HeaderText = "最高保理预付款额度";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "PaymentTerms";
            this.dataGridViewTextBoxColumn20.HeaderText = "付款条件";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Price";
            dataGridViewCellStyle20.Format = "p4";
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn21.HeaderText = "总手续费率";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 92;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "IFPrice";
            dataGridViewCellStyle21.Format = "p4";
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn22.HeaderText = "IF手续费率";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 89;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "CommissionType";
            this.dataGridViewTextBoxColumn23.HeaderText = "收费方式";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "HandFeeCurr";
            this.dataGridViewTextBoxColumn24.HeaderText = "费用币别";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "HandFee";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn25.HeaderText = "单据处理费";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "CDAStatus";
            this.dataGridViewTextBoxColumn26.HeaderText = "合同状态";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IsSigned";
            this.dataGridViewTextBoxColumn27.HeaderText = "是否签回";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "CDASignDate";
            this.dataGridViewTextBoxColumn28.HeaderText = "签发日";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "CreateUserName";
            this.dataGridViewTextBoxColumn29.HeaderText = "经办人";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "CheckUserName";
            this.dataGridViewTextBoxColumn30.HeaderText = "复核人";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "CheckDate";
            this.dataGridViewTextBoxColumn31.HeaderText = "复核日";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "FinanceRatioType";
            this.dataGridViewTextBoxColumn32.HeaderText = "融资利率";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // colCDACode
            // 
            this.colCDACode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCDACode.DataPropertyName = "CDACode";
            this.colCDACode.Frozen = true;
            this.colCDACode.HeaderText = "CDA编号";
            this.colCDACode.Name = "colCDACode";
            this.colCDACode.ReadOnly = true;
            this.colCDACode.Width = 78;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.Frozen = true;
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
            this.colSellerName.Frozen = true;
            this.colSellerName.HeaderText = "卖方名称";
            this.colSellerName.Name = "colSellerName";
            this.colSellerName.ReadOnly = true;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "买方名称";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            // 
            // colFactorName
            // 
            this.colFactorName.DataPropertyName = "FactorName";
            this.colFactorName.HeaderText = "保理商";
            this.colFactorName.Name = "colFactorName";
            this.colFactorName.ReadOnly = true;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类别";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            this.colInvoiceCurrency.Width = 80;
            // 
            // colIsRecoarse
            // 
            this.colIsRecoarse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIsRecoarse.DataPropertyName = "IsRecoarse";
            this.colIsRecoarse.HeaderText = "是否有追";
            this.colIsRecoarse.Name = "colIsRecoarse";
            this.colIsRecoarse.ReadOnly = true;
            this.colIsRecoarse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsRecoarse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIsRecoarse.Width = 61;
            // 
            // colIsNotice
            // 
            this.colIsNotice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIsNotice.DataPropertyName = "IsNotice";
            this.colIsNotice.HeaderText = "明/暗保理";
            this.colIsNotice.Name = "colIsNotice";
            this.colIsNotice.ReadOnly = true;
            this.colIsNotice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsNotice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIsNotice.Width = 66;
            // 
            // colAssignType
            // 
            this.colAssignType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAssignType.DataPropertyName = "AssignType";
            this.colAssignType.HeaderText = "转让方式";
            this.colAssignType.Name = "colAssignType";
            this.colAssignType.ReadOnly = true;
            this.colAssignType.Width = 80;
            // 
            // colCreditCoverCurr
            // 
            this.colCreditCoverCurr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCreditCoverCurr.DataPropertyName = "CreditCoverCurr";
            this.colCreditCoverCurr.HeaderText = "额度币别";
            this.colCreditCoverCurr.Name = "colCreditCoverCurr";
            this.colCreditCoverCurr.ReadOnly = true;
            this.colCreditCoverCurr.Width = 80;
            // 
            // colCreditCover
            // 
            this.colCreditCover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCreditCover.DataPropertyName = "CreditCover";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colCreditCover.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCreditCover.HeaderText = "买方信用风险额度";
            this.colCreditCover.Name = "colCreditCover";
            this.colCreditCover.ReadOnly = true;
            this.colCreditCover.Width = 128;
            // 
            // colCreditCoverPeriodBegin
            // 
            this.colCreditCoverPeriodBegin.DataPropertyName = "CreditCoverPeriodBegin";
            dataGridViewCellStyle3.Format = "d";
            this.colCreditCoverPeriodBegin.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCreditCoverPeriodBegin.HeaderText = "有效期(始)";
            this.colCreditCoverPeriodBegin.Name = "colCreditCoverPeriodBegin";
            this.colCreditCoverPeriodBegin.ReadOnly = true;
            this.colCreditCoverPeriodBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreditCoverPeriodBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreditCoverPeriodEnd
            // 
            this.colCreditCoverPeriodEnd.DataPropertyName = "CreditCoverPeriodEnd";
            dataGridViewCellStyle4.Format = "d";
            this.colCreditCoverPeriodEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCreditCoverPeriodEnd.HeaderText = "有效期(终)";
            this.colCreditCoverPeriodEnd.Name = "colCreditCoverPeriodEnd";
            this.colCreditCoverPeriodEnd.ReadOnly = true;
            this.colCreditCoverPeriodEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreditCoverPeriodEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinanceLineCurr
            // 
            this.colFinanceLineCurr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colFinanceLineCurr.DataPropertyName = "FinanceLineCurr";
            this.colFinanceLineCurr.HeaderText = "额度币别";
            this.colFinanceLineCurr.Name = "colFinanceLineCurr";
            this.colFinanceLineCurr.ReadOnly = true;
            this.colFinanceLineCurr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceLineCurr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFinanceLineCurr.Width = 61;
            // 
            // colFinanceLine
            // 
            this.colFinanceLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFinanceLine.DataPropertyName = "FinanceLine";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.colFinanceLine.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFinanceLine.HeaderText = "预付款额度";
            this.colFinanceLine.Name = "colFinanceLine";
            this.colFinanceLine.ReadOnly = true;
            this.colFinanceLine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFinanceLine.Width = 73;
            // 
            // colFinanceLinePeriodBegin
            // 
            this.colFinanceLinePeriodBegin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colFinanceLinePeriodBegin.DataPropertyName = "FinanceLinePeriodBegin";
            dataGridViewCellStyle6.Format = "d";
            this.colFinanceLinePeriodBegin.DefaultCellStyle = dataGridViewCellStyle6;
            this.colFinanceLinePeriodBegin.HeaderText = "有效期(始)";
            this.colFinanceLinePeriodBegin.Name = "colFinanceLinePeriodBegin";
            this.colFinanceLinePeriodBegin.ReadOnly = true;
            this.colFinanceLinePeriodBegin.Width = 86;
            // 
            // colFinanceLinePeriodEnd
            // 
            this.colFinanceLinePeriodEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colFinanceLinePeriodEnd.DataPropertyName = "FinanceLinePeriodEnd";
            dataGridViewCellStyle7.Format = "d";
            this.colFinanceLinePeriodEnd.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFinanceLinePeriodEnd.HeaderText = "有效期(终)";
            this.colFinanceLinePeriodEnd.Name = "colFinanceLinePeriodEnd";
            this.colFinanceLinePeriodEnd.ReadOnly = true;
            this.colFinanceLinePeriodEnd.Width = 86;
            // 
            // colHighestFinanceLine
            // 
            this.colHighestFinanceLine.DataPropertyName = "HighestFinanceLine";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.colHighestFinanceLine.DefaultCellStyle = dataGridViewCellStyle8;
            this.colHighestFinanceLine.HeaderText = "最高保理预付款额度";
            this.colHighestFinanceLine.Name = "colHighestFinanceLine";
            this.colHighestFinanceLine.ReadOnly = true;
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
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle9.Format = "p4";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPrice.HeaderText = "总手续费率";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 92;
            // 
            // colIFPrice
            // 
            this.colIFPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colIFPrice.DataPropertyName = "IFPrice";
            dataGridViewCellStyle10.Format = "p4";
            this.colIFPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.colIFPrice.HeaderText = "IF手续费率";
            this.colIFPrice.Name = "colIFPrice";
            this.colIFPrice.ReadOnly = true;
            this.colIFPrice.Width = 89;
            // 
            // colCommissionType
            // 
            this.colCommissionType.DataPropertyName = "CommissionType";
            this.colCommissionType.HeaderText = "收费方式";
            this.colCommissionType.Name = "colCommissionType";
            this.colCommissionType.ReadOnly = true;
            // 
            // colHandFeeCurr
            // 
            this.colHandFeeCurr.DataPropertyName = "HandFeeCurr";
            this.colHandFeeCurr.HeaderText = "费用币别";
            this.colHandFeeCurr.Name = "colHandFeeCurr";
            this.colHandFeeCurr.ReadOnly = true;
            // 
            // colHandFee
            // 
            this.colHandFee.DataPropertyName = "HandFee";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.colHandFee.DefaultCellStyle = dataGridViewCellStyle11;
            this.colHandFee.HeaderText = "单据处理费";
            this.colHandFee.Name = "colHandFee";
            this.colHandFee.ReadOnly = true;
            // 
            // colFinanceRatioType
            // 
            this.colFinanceRatioType.DataPropertyName = "FinanceRatioType";
            this.colFinanceRatioType.HeaderText = "融资利率";
            this.colFinanceRatioType.Name = "colFinanceRatioType";
            this.colFinanceRatioType.ReadOnly = true;
            // 
            // colCDAStatus
            // 
            this.colCDAStatus.DataPropertyName = "CDAStatus";
            this.colCDAStatus.HeaderText = "合同状态";
            this.colCDAStatus.Name = "colCDAStatus";
            this.colCDAStatus.ReadOnly = true;
            // 
            // colIsSigned
            // 
            this.colIsSigned.DataPropertyName = "IsSigned";
            this.colIsSigned.HeaderText = "是否签回";
            this.colIsSigned.Name = "colIsSigned";
            this.colIsSigned.ReadOnly = true;
            // 
            // colCDASignDate
            // 
            this.colCDASignDate.DataPropertyName = "CDASignDate";
            this.colCDASignDate.HeaderText = "签发日";
            this.colCDASignDate.Name = "colCDASignDate";
            this.colCDASignDate.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // colCheckUserName
            // 
            this.colCheckUserName.DataPropertyName = "CheckUserName";
            this.colCheckUserName.HeaderText = "复核人";
            this.colCheckUserName.Name = "colCheckUserName";
            this.colCheckUserName.ReadOnly = true;
            // 
            // colCheckDate
            // 
            this.colCheckDate.DataPropertyName = "CheckDate";
            this.colCheckDate.HeaderText = "复核日";
            this.colCheckDate.Name = "colCheckDate";
            this.colCheckDate.ReadOnly = true;
            // 
            // CDAMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCDAs);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CDAMgr";
            this.Size = new System.Drawing.Size(978, 371);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.cmuCDAMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colCDACode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRecoarse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditCoverPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLineCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceLinePeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHighestFinanceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFeeCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceRatioType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDASignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckDate;
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


    }
}