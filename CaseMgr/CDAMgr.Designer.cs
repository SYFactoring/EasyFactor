using CMBC.EasyFactor.Utils;
namespace CMBC.EasyFactor.CaseMgr
{
    partial class CDAMgr
    {
        #region Fields (38)

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCheckStatus;
        private DevComponents.DotNetBar.LabelX lblCheckStatus;
        private DevComponents.DotNetBar.LabelX lblCreateUserName;
        private DevComponents.DotNetBar.LabelX lblFactorName;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDAReport;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheck;
        private System.Windows.Forms.ToolStripMenuItem menuItemReject;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        #endregion Fields



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
            this.colCDAStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDASignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuCDAMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCDASelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCDANew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCDAReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDAsExport = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(773, 54);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.Class = "";
            this.lblDate.Location = new System.Drawing.Point(363, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 16);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "查询期限";
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
            this.diEnd.Location = new System.Drawing.Point(532, 27);
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
            this.diEnd.TabIndex = 19;
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
            this.diBegin.Location = new System.Drawing.Point(426, 27);
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
            this.diBegin.TabIndex = 18;
            // 
            // cbIsCDA
            // 
            this.cbIsCDA.AutoSize = true;
            // 
            // 
            // 
            this.cbIsCDA.BackgroundStyle.Class = "";
            this.cbIsCDA.Checked = true;
            this.cbIsCDA.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIsCDA.CheckValue = null;
            this.cbIsCDA.Location = new System.Drawing.Point(532, 7);
            this.cbIsCDA.Name = "cbIsCDA";
            this.cbIsCDA.Size = new System.Drawing.Size(100, 16);
            this.cbIsCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsCDA.TabIndex = 6;
            this.cbIsCDA.Text = "CDA是否签回";
            this.cbIsCDA.ThreeState = true;
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.Location = new System.Drawing.Point(245, 26);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCreateUserName.TabIndex = 12;
            // 
            // lblCreateUserName
            // 
            this.lblCreateUserName.AutoSize = true;
            // 
            // 
            // 
            this.lblCreateUserName.BackgroundStyle.Class = "";
            this.lblCreateUserName.Location = new System.Drawing.Point(195, 28);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 16);
            this.lblCreateUserName.TabIndex = 11;
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
            this.cbCheckStatus.Location = new System.Drawing.Point(425, 3);
            this.cbCheckStatus.Name = "cbCheckStatus";
            this.cbCheckStatus.Size = new System.Drawing.Size(101, 20);
            this.cbCheckStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCheckStatus.TabIndex = 5;
            // 
            // lblCheckStatus
            // 
            this.lblCheckStatus.AutoSize = true;
            // 
            // 
            // 
            this.lblCheckStatus.BackgroundStyle.Class = "";
            this.lblCheckStatus.Location = new System.Drawing.Point(363, 7);
            this.lblCheckStatus.Name = "lblCheckStatus";
            this.lblCheckStatus.Size = new System.Drawing.Size(56, 16);
            this.lblCheckStatus.TabIndex = 4;
            this.lblCheckStatus.Text = "审核状态";
            // 
            // tbFactorName
            // 
            // 
            // 
            // 
            this.tbFactorName.Border.Class = "TextBoxBorder";
            this.tbFactorName.Location = new System.Drawing.Point(245, 3);
            this.tbFactorName.Name = "tbFactorName";
            this.tbFactorName.Size = new System.Drawing.Size(100, 20);
            this.tbFactorName.TabIndex = 3;
            // 
            // lblFactorName
            // 
            this.lblFactorName.AutoSize = true;
            // 
            // 
            // 
            this.lblFactorName.BackgroundStyle.Class = "";
            this.lblFactorName.Location = new System.Drawing.Point(195, 7);
            this.lblFactorName.Name = "lblFactorName";
            this.lblFactorName.Size = new System.Drawing.Size(44, 16);
            this.lblFactorName.TabIndex = 2;
            this.lblFactorName.Text = "保理商";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(86, 27);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 8;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.Class = "";
            this.lblClientName.Location = new System.Drawing.Point(28, 29);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 16);
            this.lblClientName.TabIndex = 7;
            this.lblClientName.Text = "客户名称";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(638, 29);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 14;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(638, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(47, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 13;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryCDAs);
            // 
            // tbContractCode
            // 
            // 
            // 
            // 
            this.tbContractCode.Border.Class = "TextBoxBorder";
            this.tbContractCode.Location = new System.Drawing.Point(86, 3);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(100, 20);
            this.tbContractCode.TabIndex = 1;
            // 
            // lblContractCode
            // 
            this.lblContractCode.AutoSize = true;
            // 
            // 
            // 
            this.lblContractCode.BackgroundStyle.Class = "";
            this.lblContractCode.Location = new System.Drawing.Point(3, 7);
            this.lblContractCode.Name = "lblContractCode";
            this.lblContractCode.Size = new System.Drawing.Size(81, 16);
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
            this.dgvCDAs.Location = new System.Drawing.Point(0, 54);
            this.dgvCDAs.Name = "dgvCDAs";
            this.dgvCDAs.ReadOnly = true;
            this.dgvCDAs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCDAs.Size = new System.Drawing.Size(773, 348);
            this.dgvCDAs.TabIndex = 1;
            this.dgvCDAs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvCDAs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCDAs_RowPostPaint);
            this.dgvCDAs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCDAs_CellFormatting);
            this.dgvCDAs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCDAs_DataBindingComplete);
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
            dataGridViewCellStyle9.Format = "p3";
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
            dataGridViewCellStyle10.Format = "p3";
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
            dataGridViewCellStyle11.Format = "N2";
            this.colHandFee.DefaultCellStyle = dataGridViewCellStyle11;
            this.colHandFee.HeaderText = "单据处理费";
            this.colHandFee.Name = "colHandFee";
            this.colHandFee.ReadOnly = true;
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
            // cmuCDAMgr
            // 
            this.cmuCDAMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCDASelect,
            this.menuItemCDADetail,
            this.toolStripSeparator,
            this.menuItemCDANew,
            this.menuItemCDADelete,
            this.toolStripSeparator1,
            this.menuItemCheck,
            this.menuItemReject,
            this.toolStripSeparator2,
            this.menuItemCDAReport,
            this.menuItemCDAsExport});
            this.cmuCDAMgr.Name = "cmuContractMgr";
            this.cmuCDAMgr.Size = new System.Drawing.Size(183, 198);
            // 
            // menuItemCDASelect
            // 
            this.menuItemCDASelect.Name = "menuItemCDASelect";
            this.menuItemCDASelect.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDASelect.Text = "选定CDA";
            this.menuItemCDASelect.Click += new System.EventHandler(this.SelectCDA);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDADetail.Text = "详细信息";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(179, 6);
            // 
            // menuItemCDANew
            // 
            this.menuItemCDANew.Name = "menuItemCDANew";
            this.menuItemCDANew.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDANew.Text = "新建CDA";
            this.menuItemCDANew.Click += new System.EventHandler(this.NewCDA);
            // 
            // menuItemCDADelete
            // 
            this.menuItemCDADelete.Name = "menuItemCDADelete";
            this.menuItemCDADelete.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDADelete.Text = "删除CDA";
            this.menuItemCDADelete.Click += new System.EventHandler(this.DeleteCDA);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // menuItemCheck
            // 
            this.menuItemCheck.Name = "menuItemCheck";
            this.menuItemCheck.Size = new System.Drawing.Size(182, 22);
            this.menuItemCheck.Text = "审核通过";
            this.menuItemCheck.Click += new System.EventHandler(this.Check);
            // 
            // menuItemReject
            // 
            this.menuItemReject.Name = "menuItemReject";
            this.menuItemReject.Size = new System.Drawing.Size(182, 22);
            this.menuItemReject.Text = "审核拒绝";
            this.menuItemReject.Click += new System.EventHandler(this.Reject);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // menuItemCDAReport
            // 
            this.menuItemCDAReport.Name = "menuItemCDAReport";
            this.menuItemCDAReport.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDAReport.Text = "生成保理额度通知书";
            this.menuItemCDAReport.Click += new System.EventHandler(this.ReportCDA);
            // 
            // menuItemCDAsExport
            // 
            this.menuItemCDAsExport.Name = "menuItemCDAsExport";
            this.menuItemCDAsExport.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDAsExport.Text = "导出额度通知书";
            this.menuItemCDAsExport.Click += new System.EventHandler(this.ExportCDAs);
            // 
            // CDAMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCDAs);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "CDAMgr";
            this.Size = new System.Drawing.Size(773, 402);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDAs)).EndInit();
            this.cmuCDAMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsCDA;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diEnd;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diBegin;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDAStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDASignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckDate;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDAsExport;

    }
}