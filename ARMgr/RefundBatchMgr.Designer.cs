using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.ARMgr
{
    partial class RefundBatchMgr
    {
		#region?Fields?(42)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRefundType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private System.Windows.Forms.ContextMenuStrip cmuBatchMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateBatchFrom;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateBatchTo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBatches;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblCreateUserName;
        private DevComponents.DotNetBar.LabelX lblDatePicker;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private DevComponents.DotNetBar.LabelX lblRefundBatchNo;
        private DevComponents.DotNetBar.LabelX lblRefundType;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchSelect;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRefundBatchNo;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.dateInputTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblInputDate = new DevComponents.DotNetBar.LabelX();
            this.dateInputFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.cbTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTransactionType = new DevComponents.DotNetBar.LabelX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            this.cbRefundType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblRefundType = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.dateBatchTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatePicker = new DevComponents.DotNetBar.LabelX();
            this.dateBatchFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbRefundBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRefundBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvBatches = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuBatchMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemBatchSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBatchDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemBatchDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemvCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateInputTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInputFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatchTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatchFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).BeginInit();
            this.cmuBatchMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelQuery.Controls.Add(this.dateInputTo);
            this.panelQuery.Controls.Add(this.lblInputDate);
            this.panelQuery.Controls.Add(this.dateInputFrom);
            this.panelQuery.Controls.Add(this.cbLocation);
            this.panelQuery.Controls.Add(this.lblLocation);
            this.panelQuery.Controls.Add(this.cbTransactionType);
            this.panelQuery.Controls.Add(this.lblTransactionType);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClientName);
            this.panelQuery.Controls.Add(this.tbCreateUserName);
            this.panelQuery.Controls.Add(this.lblCreateUserName);
            this.panelQuery.Controls.Add(this.cbRefundType);
            this.panelQuery.Controls.Add(this.lblRefundType);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.dateBatchTo);
            this.panelQuery.Controls.Add(this.lblDatePicker);
            this.panelQuery.Controls.Add(this.dateBatchFrom);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbRefundBatchNo);
            this.panelQuery.Controls.Add(this.lblRefundBatchNo);
            this.panelQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(888, 46);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // dateInputTo
            // 
            // 
            // 
            // 
            this.dateInputTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateInputTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateInputTo.ButtonDropDown.Visible = true;
            this.dateInputTo.IsPopupCalendarOpen = false;
            this.dateInputTo.Location = new System.Drawing.Point(667, 24);
            // 
            // 
            // 
            this.dateInputTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateInputTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputTo.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateInputTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateInputTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputTo.MonthCalendar.TodayButtonVisible = true;
            this.dateInputTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateInputTo.Name = "dateInputTo";
            this.dateInputTo.Size = new System.Drawing.Size(100, 21);
            this.dateInputTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.dateInputTo.TabIndex = 17;
            // 
            // lblInputDate
            // 
            this.lblInputDate.AutoSize = true;
            // 
            // 
            // 
            this.lblInputDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInputDate.Location = new System.Drawing.Point(512, 25);
            this.lblInputDate.Name = "lblInputDate";
            this.lblInputDate.Size = new System.Drawing.Size(44, 18);
            this.lblInputDate.TabIndex = 15;
            this.lblInputDate.Text = "录入日";
            // 
            // dateInputFrom
            // 
            // 
            // 
            // 
            this.dateInputFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateInputFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateInputFrom.ButtonDropDown.Visible = true;
            this.dateInputFrom.IsPopupCalendarOpen = false;
            this.dateInputFrom.Location = new System.Drawing.Point(561, 24);
            // 
            // 
            // 
            this.dateInputFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateInputFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputFrom.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateInputFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateInputFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateInputFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateInputFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateInputFrom.Name = "dateInputFrom";
            this.dateInputFrom.Size = new System.Drawing.Size(100, 21);
            this.dateInputFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.dateInputFrom.TabIndex = 16;
            // 
            // cbLocation
            // 
            this.cbLocation.DisplayMember = "Text";
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(394, 3);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(100, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbLocation.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLocation.Location = new System.Drawing.Point(332, 6);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 18);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "业务地区";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DisplayMember = "Text";
            this.cbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.ItemHeight = 14;
            this.cbTransactionType.Items.AddRange(new object[] {
            "全部",
            "国内卖方保理",
            "国内买方保理",
            "出口保理",
            "进口保理"});
            this.cbTransactionType.Location = new System.Drawing.Point(225, 3);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(101, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbTransactionType.TabIndex = 3;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            // 
            // 
            // 
            this.lblTransactionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTransactionType.Location = new System.Drawing.Point(163, 6);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(56, 18);
            this.lblTransactionType.TabIndex = 2;
            this.lblTransactionType.Text = "业务类别";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientName.Location = new System.Drawing.Point(56, 3);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 21);
            this.tbClientName.TabIndex = 1;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientName.Location = new System.Drawing.Point(3, 6);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 18);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "客户名称";
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCreateUserName.Location = new System.Drawing.Point(719, 4);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 21);
            this.tbCreateUserName.TabIndex = 9;
            // 
            // lblCreateUserName
            // 
            this.lblCreateUserName.AutoSize = true;
            // 
            // 
            // 
            this.lblCreateUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCreateUserName.Location = new System.Drawing.Point(669, 5);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 18);
            this.lblCreateUserName.TabIndex = 8;
            this.lblCreateUserName.Text = "经办人";
            // 
            // cbRefundType
            // 
            this.cbRefundType.DisplayMember = "Text";
            this.cbRefundType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRefundType.FormattingEnabled = true;
            this.cbRefundType.ItemHeight = 14;
            this.cbRefundType.Items.AddRange(new object[] {
            "全部",
            "买方直接付款",
            "卖方还款"});
            this.cbRefundType.Location = new System.Drawing.Point(560, 4);
            this.cbRefundType.Name = "cbRefundType";
            this.cbRefundType.Size = new System.Drawing.Size(101, 20);
            this.cbRefundType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbRefundType.TabIndex = 7;
            // 
            // lblRefundType
            // 
            this.lblRefundType.AutoSize = true;
            // 
            // 
            // 
            this.lblRefundType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRefundType.Location = new System.Drawing.Point(500, 5);
            this.lblRefundType.Name = "lblRefundType";
            this.lblRefundType.Size = new System.Drawing.Size(56, 18);
            this.lblRefundType.TabIndex = 6;
            this.lblRefundType.Text = "还款类型";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(827, 27);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 18);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "获得 条记录";
            // 
            // dateBatchTo
            // 
            // 
            // 
            // 
            this.dateBatchTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateBatchTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateBatchTo.ButtonDropDown.Visible = true;
            this.dateBatchTo.IsPopupCalendarOpen = false;
            this.dateBatchTo.Location = new System.Drawing.Point(332, 24);
            // 
            // 
            // 
            this.dateBatchTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateBatchTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchTo.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateBatchTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateBatchTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchTo.MonthCalendar.TodayButtonVisible = true;
            this.dateBatchTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateBatchTo.Name = "dateBatchTo";
            this.dateBatchTo.Size = new System.Drawing.Size(100, 21);
            this.dateBatchTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.dateBatchTo.TabIndex = 14;
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            // 
            // 
            // 
            this.lblDatePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatePicker.Location = new System.Drawing.Point(175, 26);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(44, 18);
            this.lblDatePicker.TabIndex = 12;
            this.lblDatePicker.Text = "还款日";
            // 
            // dateBatchFrom
            // 
            // 
            // 
            // 
            this.dateBatchFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateBatchFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateBatchFrom.ButtonDropDown.Visible = true;
            this.dateBatchFrom.IsPopupCalendarOpen = false;
            this.dateBatchFrom.Location = new System.Drawing.Point(226, 24);
            // 
            // 
            // 
            this.dateBatchFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateBatchFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchFrom.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateBatchFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateBatchFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateBatchFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateBatchFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateBatchFrom.Name = "dateBatchFrom";
            this.dateBatchFrom.Size = new System.Drawing.Size(100, 21);
            this.dateBatchFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.dateBatchFrom.TabIndex = 13;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(827, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 21);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryBatch);
            // 
            // tbRefundBatchNo
            // 
            // 
            // 
            // 
            this.tbRefundBatchNo.Border.Class = "TextBoxBorder";
            this.tbRefundBatchNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRefundBatchNo.Location = new System.Drawing.Point(56, 24);
            this.tbRefundBatchNo.Name = "tbRefundBatchNo";
            this.tbRefundBatchNo.Size = new System.Drawing.Size(100, 21);
            this.tbRefundBatchNo.TabIndex = 11;
            // 
            // lblRefundBatchNo
            // 
            this.lblRefundBatchNo.AutoSize = true;
            // 
            // 
            // 
            this.lblRefundBatchNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRefundBatchNo.Location = new System.Drawing.Point(3, 27);
            this.lblRefundBatchNo.Name = "lblRefundBatchNo";
            this.lblRefundBatchNo.Size = new System.Drawing.Size(56, 18);
            this.lblRefundBatchNo.TabIndex = 10;
            this.lblRefundBatchNo.Text = "还款批号";
            // 
            // dgvBatches
            // 
            this.dgvBatches.AllowUserToAddRows = false;
            this.dgvBatches.AllowUserToDeleteRows = false;
            this.dgvBatches.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellerName,
            this.colBuyerName,
            this.colTransactionType,
            this.colRefundBatchNo,
            this.colRefundType,
            this.colRefundDate,
            this.colBatchCount,
            this.colRefundAmount,
            this.colInputDate,
            this.colCreateUserName,
            this.colCheckStatus,
            this.colCheckDate,
            this.colCheckUserName});
            this.dgvBatches.ContextMenuStrip = this.cmuBatchMgr;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatches.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBatches.Location = new System.Drawing.Point(0, 46);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.ReadOnly = true;
            this.dgvBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBatches.Size = new System.Drawing.Size(888, 312);
            this.dgvBatches.TabIndex = 1;
            this.dgvBatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBatchesCellDoubleClick);
            this.dgvBatches.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvBatchesRowPostPaint);
            // 
            // cmuBatchMgr
            // 
            this.cmuBatchMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBatchSelect,
            this.menuItemBatchDetail,
            this.toolStripSeparator1,
            this.menuItemvCheck,
            this.menuItemReject,
            this.toolStripSeparator2,
            this.menuItemBatchDelete});
            this.cmuBatchMgr.Name = "cmuBatchMgr";
            this.cmuBatchMgr.Size = new System.Drawing.Size(145, 126);
            // 
            // menuItemBatchSelect
            // 
            this.menuItemBatchSelect.Name = "menuItemBatchSelect";
            this.menuItemBatchSelect.Size = new System.Drawing.Size(144, 22);
            this.menuItemBatchSelect.Text = "选择批次(&S)";
            this.menuItemBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // menuItemBatchDetail
            // 
            this.menuItemBatchDetail.Name = "menuItemBatchDetail";
            this.menuItemBatchDetail.Size = new System.Drawing.Size(144, 22);
            this.menuItemBatchDetail.Text = "批次详情(&M)";
            this.menuItemBatchDetail.Click += new System.EventHandler(this.DetailBatch);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // menuItemBatchDelete
            // 
            this.menuItemBatchDelete.Name = "menuItemBatchDelete";
            this.menuItemBatchDelete.Size = new System.Drawing.Size(144, 22);
            this.menuItemBatchDelete.Text = "删除批次(&D)";
            this.menuItemBatchDelete.Click += new System.EventHandler(this.DeleteBatch);
            // 
            // menuItemvCheck
            // 
            this.menuItemvCheck.Name = "menuItemvCheck";
            this.menuItemvCheck.Size = new System.Drawing.Size(144, 22);
            this.menuItemvCheck.Text = "审核通过";
            this.menuItemvCheck.Click += new System.EventHandler(this.Check);
            // 
            // menuItemReject
            // 
            this.menuItemReject.Name = "menuItemReject";
            this.menuItemReject.Size = new System.Drawing.Size(144, 22);
            this.menuItemReject.Text = "审核拒绝";
            this.menuItemReject.Click += new System.EventHandler(this.Reject);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
            this.colSellerName.HeaderText = "卖方名称";
            this.colSellerName.Name = "colSellerName";
            this.colSellerName.ReadOnly = true;
            this.colSellerName.Width = 120;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "买方名称";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            this.colBuyerName.Width = 120;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类别";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            this.colTransactionType.Width = 80;
            // 
            // colRefundBatchNo
            // 
            this.colRefundBatchNo.DataPropertyName = "RefundBatchNo";
            this.colRefundBatchNo.HeaderText = "还款批号";
            this.colRefundBatchNo.Name = "colRefundBatchNo";
            this.colRefundBatchNo.ReadOnly = true;
            // 
            // colRefundType
            // 
            this.colRefundType.DataPropertyName = "RefundType";
            this.colRefundType.HeaderText = "还款类型";
            this.colRefundType.Name = "colRefundType";
            this.colRefundType.ReadOnly = true;
            this.colRefundType.Width = 80;
            // 
            // colRefundDate
            // 
            this.colRefundDate.DataPropertyName = "RefundDate";
            this.colRefundDate.HeaderText = "还款日";
            this.colRefundDate.Name = "colRefundDate";
            this.colRefundDate.ReadOnly = true;
            this.colRefundDate.Width = 80;
            // 
            // colBatchCount
            // 
            this.colBatchCount.DataPropertyName = "BatchCount";
            this.colBatchCount.HeaderText = "发票笔数";
            this.colBatchCount.Name = "colBatchCount";
            this.colBatchCount.ReadOnly = true;
            this.colBatchCount.Width = 70;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRefundAmount.HeaderText = "还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.ReadOnly = true;
            // 
            // colInputDate
            // 
            this.colInputDate.DataPropertyName = "InputDate";
            this.colInputDate.HeaderText = "录入日";
            this.colInputDate.Name = "colInputDate";
            this.colInputDate.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            this.colCreateUserName.Width = 70;
            // 
            // colCheckStatus
            // 
            this.colCheckStatus.DataPropertyName = "CheckStatus";
            this.colCheckStatus.HeaderText = "审核状态";
            this.colCheckStatus.Name = "colCheckStatus";
            this.colCheckStatus.ReadOnly = true;
            // 
            // colCheckDate
            // 
            this.colCheckDate.DataPropertyName = "CheckDate";
            this.colCheckDate.HeaderText = "审核日";
            this.colCheckDate.Name = "colCheckDate";
            this.colCheckDate.ReadOnly = true;
            // 
            // colCheckUserName
            // 
            this.colCheckUserName.DataPropertyName = "CheckUserName";
            this.colCheckUserName.HeaderText = "审核人";
            this.colCheckUserName.Name = "colCheckUserName";
            this.colCheckUserName.ReadOnly = true;
            // 
            // RefundBatchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBatches);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "RefundBatchMgr";
            this.Size = new System.Drawing.Size(888, 358);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateInputTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInputFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatchTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatchFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).EndInit();
            this.cmuBatchMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateInputTo;
        private DevComponents.DotNetBar.LabelX lblInputDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateInputFrom;
        private System.Windows.Forms.ToolStripMenuItem menuItemvCheck;
        private System.Windows.Forms.ToolStripMenuItem menuItemReject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckUserName;
    }
}
