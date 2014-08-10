using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.ARMgr
{
    partial class PaymentBatchMgr
    {
		#region?Fields?(46)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbPaymentType;
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
        private DevComponents.DotNetBar.LabelX lblPaymentBatchNo;
        private DevComponents.DotNetBar.LabelX lblPaymentType;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemMSG11;
        private System.Windows.Forms.ToolStripMenuItem menuItemMSG12;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentBatchNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

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
            this.cbPaymentType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblPaymentType = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.dateBatchTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatePicker = new DevComponents.DotNetBar.LabelX();
            this.dateBatchFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbPaymentBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPaymentBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvBatches = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuBatchMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemBatchSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBatchDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemBatchDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemMSG09 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMSG11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMSG12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSendMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelQuery.Controls.Add(this.cbPaymentType);
            this.panelQuery.Controls.Add(this.lblPaymentType);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.dateBatchTo);
            this.panelQuery.Controls.Add(this.lblDatePicker);
            this.panelQuery.Controls.Add(this.dateBatchFrom);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbPaymentBatchNo);
            this.panelQuery.Controls.Add(this.lblPaymentBatchNo);
            this.panelQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(888, 45);
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
            this.dateInputTo.Location = new System.Drawing.Point(670, 23);
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
            this.lblInputDate.Location = new System.Drawing.Point(513, 26);
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
            this.dateInputFrom.Location = new System.Drawing.Point(563, 23);
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
            this.cbLocation.Location = new System.Drawing.Point(393, 3);
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
            this.lblLocation.Location = new System.Drawing.Point(331, 6);
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
            this.cbTransactionType.Location = new System.Drawing.Point(224, 3);
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
            this.lblTransactionType.Location = new System.Drawing.Point(162, 6);
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
            this.tbClientName.Location = new System.Drawing.Point(56, 4);
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
            this.tbCreateUserName.Location = new System.Drawing.Point(720, 3);
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
            this.lblCreateUserName.Location = new System.Drawing.Point(670, 4);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 18);
            this.lblCreateUserName.TabIndex = 8;
            this.lblCreateUserName.Text = "经办人";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DisplayMember = "Text";
            this.cbPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.ItemHeight = 14;
            this.cbPaymentType.Items.AddRange(new object[] {
            "全部",
            "买方直接付款",
            "买方间接付款",
            "担保付款",
            "反转让",
            "贷项通知"});
            this.cbPaymentType.Location = new System.Drawing.Point(563, 3);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(101, 20);
            this.cbPaymentType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbPaymentType.TabIndex = 7;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            // 
            // 
            // 
            this.lblPaymentType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPaymentType.Location = new System.Drawing.Point(501, 5);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(56, 18);
            this.lblPaymentType.TabIndex = 6;
            this.lblPaymentType.Text = "付款类型";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(826, 28);
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
            this.dateBatchTo.Location = new System.Drawing.Point(331, 23);
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
            this.lblDatePicker.Location = new System.Drawing.Point(174, 24);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(44, 18);
            this.lblDatePicker.TabIndex = 12;
            this.lblDatePicker.Text = "付款日";
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
            this.dateBatchFrom.Location = new System.Drawing.Point(224, 23);
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
            this.btnQuery.Location = new System.Drawing.Point(826, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 21);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryBatch);
            // 
            // tbPaymentBatchNo
            // 
            // 
            // 
            // 
            this.tbPaymentBatchNo.Border.Class = "TextBoxBorder";
            this.tbPaymentBatchNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPaymentBatchNo.Location = new System.Drawing.Point(56, 23);
            this.tbPaymentBatchNo.Name = "tbPaymentBatchNo";
            this.tbPaymentBatchNo.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentBatchNo.TabIndex = 11;
            // 
            // lblPaymentBatchNo
            // 
            this.lblPaymentBatchNo.AutoSize = true;
            // 
            // 
            // 
            this.lblPaymentBatchNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPaymentBatchNo.Location = new System.Drawing.Point(3, 26);
            this.lblPaymentBatchNo.Name = "lblPaymentBatchNo";
            this.lblPaymentBatchNo.Size = new System.Drawing.Size(56, 18);
            this.lblPaymentBatchNo.TabIndex = 10;
            this.lblPaymentBatchNo.Text = "付款批号";
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
            this.colFactorName,
            this.colTransactionType,
            this.colInvoiceCurrency,
            this.colPaymentBatchNo,
            this.colPaymentType,
            this.colPaymentDate,
            this.colBatchCount,
            this.colPaymentAmount,
            this.colIsSendMsg,
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
            this.dgvBatches.Location = new System.Drawing.Point(0, 45);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.ReadOnly = true;
            this.dgvBatches.RowTemplate.Height = 23;
            this.dgvBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBatches.Size = new System.Drawing.Size(888, 313);
            this.dgvBatches.TabIndex = 1;
            this.dgvBatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBatchesCellDoubleClick);
            this.dgvBatches.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvBatchesCellFormatting);
            this.dgvBatches.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvBatchesRowPostPaint);
            // 
            // cmuBatchMgr
            // 
            this.cmuBatchMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBatchSelect,
            this.menuItemBatchDetail,
            this.toolStripSeparator1,
            this.menuItemCheck,
            this.menuItemReject,
            this.toolStripSeparator2,
            this.menuItemBatchDelete,
            this.toolStripSeparator3,
            this.menuItemMSG09,
            this.menuItemMSG11,
            this.menuItemMSG12});
            this.cmuBatchMgr.Name = "cmuBatchMgr";
            this.cmuBatchMgr.Size = new System.Drawing.Size(145, 198);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // menuItemMSG09
            // 
            this.menuItemMSG09.Name = "menuItemMSG09";
            this.menuItemMSG09.Size = new System.Drawing.Size(144, 22);
            this.menuItemMSG09.Text = "生成MSG09";
            this.menuItemMSG09.Click += new System.EventHandler(this.ExportMSG09);
            // 
            // menuItemMSG11
            // 
            this.menuItemMSG11.Name = "menuItemMSG11";
            this.menuItemMSG11.Size = new System.Drawing.Size(144, 22);
            this.menuItemMSG11.Text = "生成MSG11";
            this.menuItemMSG11.Click += new System.EventHandler(this.ExportMSG11);
            // 
            // menuItemMSG12
            // 
            this.menuItemMSG12.Name = "menuItemMSG12";
            this.menuItemMSG12.Size = new System.Drawing.Size(144, 22);
            this.menuItemMSG12.Text = "生成MSG12";
            this.menuItemMSG12.Click += new System.EventHandler(this.ExportMSG12);
            // 
            // menuItemCheck
            // 
            this.menuItemCheck.Name = "menuItemCheck";
            this.menuItemCheck.Size = new System.Drawing.Size(144, 22);
            this.menuItemCheck.Text = "审核通过";
            this.menuItemCheck.Click += new System.EventHandler(this.Check);
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
            this.colTransactionType.Width = 80;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            // 
            // colPaymentBatchNo
            // 
            this.colPaymentBatchNo.DataPropertyName = "PaymentBatchNo";
            this.colPaymentBatchNo.HeaderText = "付款批号";
            this.colPaymentBatchNo.Name = "colPaymentBatchNo";
            this.colPaymentBatchNo.ReadOnly = true;
            // 
            // colPaymentType
            // 
            this.colPaymentType.DataPropertyName = "PaymentType";
            this.colPaymentType.HeaderText = "付款类型";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.ReadOnly = true;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            this.colPaymentDate.HeaderText = "付款日";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;
            this.colPaymentDate.Width = 80;
            // 
            // colBatchCount
            // 
            this.colBatchCount.DataPropertyName = "BatchCount";
            this.colBatchCount.HeaderText = "发票笔数";
            this.colBatchCount.Name = "colBatchCount";
            this.colBatchCount.ReadOnly = true;
            this.colBatchCount.Width = 65;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPaymentAmount.HeaderText = "付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            // 
            // colIsSendMsg
            // 
            this.colIsSendMsg.DataPropertyName = "IsSendMsg";
            this.colIsSendMsg.HeaderText = "付款报文";
            this.colIsSendMsg.Name = "colIsSendMsg";
            this.colIsSendMsg.ReadOnly = true;
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
            this.colCreateUserName.Width = 65;
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
            // PaymentBatchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBatches);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "PaymentBatchMgr";
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

        private System.Windows.Forms.ToolStripMenuItem menuItemMSG09;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateInputTo;
        private DevComponents.DotNetBar.LabelX lblInputDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateInputFrom;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheck;
        private System.Windows.Forms.ToolStripMenuItem menuItemReject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSendMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckUserName;
    }
}
