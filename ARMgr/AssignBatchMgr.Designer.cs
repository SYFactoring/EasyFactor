//-----------------------------------------------------------------------
// <copyright file="AssignBatchMgr.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchMgr
    {
		#region?Fields?(49)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private System.Windows.Forms.ContextMenuStrip cmuBatchMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateBatchFrom;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateBatchTo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBatches;
        private DevComponents.DotNetBar.LabelX lblAssignBatchNo;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblDatePicker;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemAssignReport;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemCommissionReport;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileCheckList;
        private System.Windows.Forms.ToolStripMenuItem menuItemFinanceReport;
        private System.Windows.Forms.ToolStripMenuItem menuItemFlawReport;
        private System.Windows.Forms.ToolStripMenuItem menuItemMSG09;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignBatchNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCreateUserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.dateInputTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblInputDate = new DevComponents.DotNetBar.LabelX();
            this.dateInputFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblCreateUserName = new DevComponents.DotNetBar.LabelX();
            this.tbFactorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorName = new DevComponents.DotNetBar.LabelX();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.cbTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTransactionType = new DevComponents.DotNetBar.LabelX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.dateBatchTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatePicker = new DevComponents.DotNetBar.LabelX();
            this.dateBatchFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbAssignBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAssignBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvBatches = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colFactorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSendMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorCommissionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorCommissionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuBatchMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemBatchSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBatchDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemBatchDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCommissionRemitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAssignReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFinanceReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCommissionReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemThreeReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFlawReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileCheckList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemMSG09 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBatchExport = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.dateInputTo);
            this.panelQuery.Controls.Add(this.lblInputDate);
            this.panelQuery.Controls.Add(this.dateInputFrom);
            this.panelQuery.Controls.Add(this.lblCreateUserName);
            this.panelQuery.Controls.Add(this.tbFactorName);
            this.panelQuery.Controls.Add(this.lblFactorName);
            this.panelQuery.Controls.Add(this.cbLocation);
            this.panelQuery.Controls.Add(this.lblLocation);
            this.panelQuery.Controls.Add(this.cbTransactionType);
            this.panelQuery.Controls.Add(this.lblTransactionType);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClientName);
            this.panelQuery.Controls.Add(this.tbCreateUserName);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.dateBatchTo);
            this.panelQuery.Controls.Add(this.lblDatePicker);
            this.panelQuery.Controls.Add(this.dateBatchFrom);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbAssignBatchNo);
            this.panelQuery.Controls.Add(this.lblAssignBatchNo);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(894, 55);
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
            this.dateInputTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateInputTo.ButtonDropDown.Visible = true;
            this.dateInputTo.Location = new System.Drawing.Point(671, 27);
            // 
            // 
            // 
            this.dateInputTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateInputTo.MonthCalendar.BackgroundStyle.Class = "";
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
            this.dateInputTo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateInputTo.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateInputTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateInputTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateInputTo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateInputTo.MonthCalendar.TodayButtonVisible = true;
            this.dateInputTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateInputTo.Name = "dateInputTo";
            this.dateInputTo.Size = new System.Drawing.Size(100, 20);
            this.dateInputTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateInputTo.TabIndex = 17;
            // 
            // lblInputDate
            // 
            this.lblInputDate.AutoSize = true;
            // 
            // 
            // 
            this.lblInputDate.BackgroundStyle.Class = "";
            this.lblInputDate.Location = new System.Drawing.Point(516, 28);
            this.lblInputDate.Name = "lblInputDate";
            this.lblInputDate.Size = new System.Drawing.Size(44, 16);
            this.lblInputDate.TabIndex = 15;
            this.lblInputDate.Text = "录入日";
            // 
            // dateInputFrom
            // 
            // 
            // 
            // 
            this.dateInputFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateInputFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateInputFrom.ButtonDropDown.Visible = true;
            this.dateInputFrom.Location = new System.Drawing.Point(565, 27);
            // 
            // 
            // 
            this.dateInputFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateInputFrom.MonthCalendar.BackgroundStyle.Class = "";
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
            this.dateInputFrom.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateInputFrom.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateInputFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateInputFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateInputFrom.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateInputFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateInputFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateInputFrom.Name = "dateInputFrom";
            this.dateInputFrom.Size = new System.Drawing.Size(100, 20);
            this.dateInputFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateInputFrom.TabIndex = 16;
            // 
            // lblCreateUserName
            // 
            this.lblCreateUserName.AutoSize = true;
            // 
            // 
            // 
            this.lblCreateUserName.BackgroundStyle.Class = "";
            this.lblCreateUserName.Location = new System.Drawing.Point(671, 6);
            this.lblCreateUserName.Name = "lblCreateUserName";
            this.lblCreateUserName.Size = new System.Drawing.Size(44, 16);
            this.lblCreateUserName.TabIndex = 8;
            this.lblCreateUserName.Text = "经办人";
            // 
            // tbFactorName
            // 
            // 
            // 
            // 
            this.tbFactorName.Border.Class = "TextBoxBorder";
            this.tbFactorName.Location = new System.Drawing.Point(231, 4);
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
            this.lblFactorName.Location = new System.Drawing.Point(181, 6);
            this.lblFactorName.Name = "lblFactorName";
            this.lblFactorName.Size = new System.Drawing.Size(44, 16);
            this.lblFactorName.TabIndex = 2;
            this.lblFactorName.Text = "保理商";
            // 
            // cbLocation
            // 
            this.cbLocation.DisplayMember = "Text";
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(565, 4);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(100, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.Class = "";
            this.lblLocation.Location = new System.Drawing.Point(504, 6);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 16);
            this.lblLocation.TabIndex = 6;
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
            this.cbTransactionType.Location = new System.Drawing.Point(397, 4);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(101, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTransactionType.TabIndex = 5;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            // 
            // 
            // 
            this.lblTransactionType.BackgroundStyle.Class = "";
            this.lblTransactionType.Location = new System.Drawing.Point(343, 6);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(56, 16);
            this.lblTransactionType.TabIndex = 4;
            this.lblTransactionType.Text = "业务类别";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(65, 4);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 1;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.Class = "";
            this.lblClientName.Location = new System.Drawing.Point(3, 6);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 16);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "客户名称";
            // 
            // tbCreateUserName
            // 
            // 
            // 
            // 
            this.tbCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCreateUserName.Location = new System.Drawing.Point(721, 3);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCreateUserName.TabIndex = 9;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(830, 30);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(71, 16);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "获得 条记录";
            // 
            // dateBatchTo
            // 
            // 
            // 
            // 
            this.dateBatchTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateBatchTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateBatchTo.ButtonDropDown.Visible = true;
            this.dateBatchTo.Location = new System.Drawing.Point(335, 27);
            // 
            // 
            // 
            this.dateBatchTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateBatchTo.MonthCalendar.BackgroundStyle.Class = "";
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
            this.dateBatchTo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateBatchTo.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateBatchTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateBatchTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateBatchTo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateBatchTo.MonthCalendar.TodayButtonVisible = true;
            this.dateBatchTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateBatchTo.Name = "dateBatchTo";
            this.dateBatchTo.Size = new System.Drawing.Size(100, 20);
            this.dateBatchTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateBatchTo.TabIndex = 14;
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            // 
            // 
            // 
            this.lblDatePicker.BackgroundStyle.Class = "";
            this.lblDatePicker.Location = new System.Drawing.Point(180, 28);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(44, 16);
            this.lblDatePicker.TabIndex = 12;
            this.lblDatePicker.Text = "转让日";
            // 
            // dateBatchFrom
            // 
            // 
            // 
            // 
            this.dateBatchFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateBatchFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateBatchFrom.ButtonDropDown.Visible = true;
            this.dateBatchFrom.Location = new System.Drawing.Point(229, 27);
            // 
            // 
            // 
            this.dateBatchFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateBatchFrom.MonthCalendar.BackgroundStyle.Class = "";
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
            this.dateBatchFrom.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateBatchFrom.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateBatchFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateBatchFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateBatchFrom.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateBatchFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateBatchFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateBatchFrom.Name = "dateBatchFrom";
            this.dateBatchFrom.Size = new System.Drawing.Size(100, 20);
            this.dateBatchFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateBatchFrom.TabIndex = 13;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(831, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryBatch);
            // 
            // tbAssignBatchNo
            // 
            // 
            // 
            // 
            this.tbAssignBatchNo.Border.Class = "TextBoxBorder";
            this.tbAssignBatchNo.Location = new System.Drawing.Point(65, 27);
            this.tbAssignBatchNo.Name = "tbAssignBatchNo";
            this.tbAssignBatchNo.Size = new System.Drawing.Size(100, 20);
            this.tbAssignBatchNo.TabIndex = 11;
            // 
            // lblAssignBatchNo
            // 
            this.lblAssignBatchNo.AutoSize = true;
            // 
            // 
            // 
            this.lblAssignBatchNo.BackgroundStyle.Class = "";
            this.lblAssignBatchNo.Location = new System.Drawing.Point(3, 28);
            this.lblAssignBatchNo.Name = "lblAssignBatchNo";
            this.lblAssignBatchNo.Size = new System.Drawing.Size(56, 16);
            this.lblAssignBatchNo.TabIndex = 10;
            this.lblAssignBatchNo.Text = "转让批号";
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
            this.colFactorCode,
            this.colFactorName,
            this.colLocation,
            this.colSellerName,
            this.colBuyerName,
            this.colTransactionType,
            this.colIsPool,
            this.colAssignBatchNo,
            this.colAssignDate,
            this.colIsSendMsg,
            this.colBatchCount,
            this.colBatchCurrency,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colFinanceAmount,
            this.colFinanceOutstanding,
            this.colPaymentAmount,
            this.colRefundAmount,
            this.colCommissionPrice,
            this.colCommissionAmount,
            this.colFactorCommissionPrice,
            this.colFactorCommissionAmount,
            this.colInputDate,
            this.colCreateUserName});
            this.dgvBatches.ContextMenuStrip = this.cmuBatchMgr;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatches.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBatches.Location = new System.Drawing.Point(0, 55);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.ReadOnly = true;
            this.dgvBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBatches.Size = new System.Drawing.Size(894, 302);
            this.dgvBatches.TabIndex = 1;
            this.dgvBatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBatchesCellDoubleClick);
            this.dgvBatches.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvBatchesCellFormatting);
            this.dgvBatches.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvBatchesRowPostPaint);
            // 
            // colFactorCode
            // 
            this.colFactorCode.DataPropertyName = "FactorCode";
            this.colFactorCode.HeaderText = "保理商代码";
            this.colFactorCode.Name = "colFactorCode";
            this.colFactorCode.ReadOnly = true;
            // 
            // colFactorName
            // 
            this.colFactorName.DataPropertyName = "FactorName";
            this.colFactorName.HeaderText = "保理商名称";
            this.colFactorName.Name = "colFactorName";
            this.colFactorName.ReadOnly = true;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "业务地区";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 75;
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
            // 
            // colIsPool
            // 
            this.colIsPool.DataPropertyName = "IsPool";
            this.colIsPool.HeaderText = "池融资";
            this.colIsPool.Name = "colIsPool";
            this.colIsPool.ReadOnly = true;
            this.colIsPool.Width = 50;
            // 
            // colAssignBatchNo
            // 
            this.colAssignBatchNo.DataPropertyName = "AssignBatchNo";
            this.colAssignBatchNo.HeaderText = "业务编号";
            this.colAssignBatchNo.Name = "colAssignBatchNo";
            this.colAssignBatchNo.ReadOnly = true;
            this.colAssignBatchNo.Width = 120;
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            dataGridViewCellStyle2.Format = "d";
            this.colAssignDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            this.colAssignDate.ReadOnly = true;
            this.colAssignDate.Width = 80;
            // 
            // colIsSendMsg
            // 
            this.colIsSendMsg.DataPropertyName = "IsSendMsg";
            this.colIsSendMsg.HeaderText = "转让报文";
            this.colIsSendMsg.Name = "colIsSendMsg";
            this.colIsSendMsg.ReadOnly = true;
            // 
            // colBatchCount
            // 
            this.colBatchCount.DataPropertyName = "BatchCount";
            this.colBatchCount.HeaderText = "发票笔数";
            this.colBatchCount.Name = "colBatchCount";
            this.colBatchCount.ReadOnly = true;
            this.colBatchCount.Width = 80;
            // 
            // colBatchCurrency
            // 
            this.colBatchCurrency.DataPropertyName = "BatchCurrency";
            this.colBatchCurrency.HeaderText = "币别";
            this.colBatchCurrency.Name = "colBatchCurrency";
            this.colBatchCurrency.ReadOnly = true;
            this.colBatchCurrency.Width = 50;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAssignOutstanding.HeaderText = "转让余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            this.colAssignOutstanding.ReadOnly = true;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle6;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            this.colFinanceOutstanding.ReadOnly = true;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPaymentAmount.HeaderText = "付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.colRefundAmount.HeaderText = "还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.ReadOnly = true;
            // 
            // colCommissionPrice
            // 
            this.colCommissionPrice.DataPropertyName = "CommissionPrice";
            dataGridViewCellStyle9.Format = "p4";
            this.colCommissionPrice.DefaultCellStyle = dataGridViewCellStyle9;
            this.colCommissionPrice.HeaderText = "总手续费率";
            this.colCommissionPrice.Name = "colCommissionPrice";
            this.colCommissionPrice.ReadOnly = true;
            // 
            // colCommissionAmount
            // 
            this.colCommissionAmount.DataPropertyName = "CommissionAmount";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.colCommissionAmount.DefaultCellStyle = dataGridViewCellStyle10;
            this.colCommissionAmount.HeaderText = "总手续费";
            this.colCommissionAmount.Name = "colCommissionAmount";
            this.colCommissionAmount.ReadOnly = true;
            // 
            // colFactorCommissionPrice
            // 
            this.colFactorCommissionPrice.DataPropertyName = "FactorCommissionPrice";
            dataGridViewCellStyle11.Format = "p4";
            this.colFactorCommissionPrice.DefaultCellStyle = dataGridViewCellStyle11;
            this.colFactorCommissionPrice.HeaderText = "合作保理商报价";
            this.colFactorCommissionPrice.Name = "colFactorCommissionPrice";
            this.colFactorCommissionPrice.ReadOnly = true;
            // 
            // colFactorCommissionAmount
            // 
            this.colFactorCommissionAmount.DataPropertyName = "FactorCommissionAmount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.colFactorCommissionAmount.DefaultCellStyle = dataGridViewCellStyle12;
            this.colFactorCommissionAmount.HeaderText = "合作保理商手续费";
            this.colFactorCommissionAmount.Name = "colFactorCommissionAmount";
            this.colFactorCommissionAmount.ReadOnly = true;
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
            this.colCreateUserName.Width = 80;
            // 
            // cmuBatchMgr
            // 
            this.cmuBatchMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBatchSelect,
            this.menuItemBatchDetail,
            this.toolStripSeparator1,
            this.menuItemBatchDelete,
            this.menuItemCommissionRemitDelete,
            this.toolStripSeparator3,
            this.menuItemAssignReport,
            this.menuItemFinanceReport,
            this.menuItemCommissionReport,
            this.menuItemThreeReports,
            this.menuItemFlawReport,
            this.menuItemFileCheckList,
            this.toolStripSeparator4,
            this.menuItemMSG09,
            this.menuItemBatchExport});
            this.cmuBatchMgr.Name = "cmuBatchMgr";
            this.cmuBatchMgr.Size = new System.Drawing.Size(199, 308);
            // 
            // menuItemBatchSelect
            // 
            this.menuItemBatchSelect.Name = "menuItemBatchSelect";
            this.menuItemBatchSelect.Size = new System.Drawing.Size(198, 22);
            this.menuItemBatchSelect.Text = "选择批次(&S)";
            this.menuItemBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // menuItemBatchDetail
            // 
            this.menuItemBatchDetail.Name = "menuItemBatchDetail";
            this.menuItemBatchDetail.Size = new System.Drawing.Size(198, 22);
            this.menuItemBatchDetail.Text = "批次详情(&M)";
            this.menuItemBatchDetail.Click += new System.EventHandler(this.DetailBatch);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // menuItemBatchDelete
            // 
            this.menuItemBatchDelete.Name = "menuItemBatchDelete";
            this.menuItemBatchDelete.Size = new System.Drawing.Size(198, 22);
            this.menuItemBatchDelete.Text = "删除批次(&D)";
            this.menuItemBatchDelete.Click += new System.EventHandler(this.DeleteBatch);
            // 
            // menuItemCommissionRemitDelete
            // 
            this.menuItemCommissionRemitDelete.Name = "menuItemCommissionRemitDelete";
            this.menuItemCommissionRemitDelete.Size = new System.Drawing.Size(198, 22);
            this.menuItemCommissionRemitDelete.Text = "删除手续费收付记录";
            this.menuItemCommissionRemitDelete.Click += new System.EventHandler(this.DeleteCommissionRemit);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // menuItemAssignReport
            // 
            this.menuItemAssignReport.Name = "menuItemAssignReport";
            this.menuItemAssignReport.Size = new System.Drawing.Size(198, 22);
            this.menuItemAssignReport.Text = "应收账款转让明细表(&A)";
            this.menuItemAssignReport.Click += new System.EventHandler(this.ReportAssign);
            // 
            // menuItemFinanceReport
            // 
            this.menuItemFinanceReport.Name = "menuItemFinanceReport";
            this.menuItemFinanceReport.Size = new System.Drawing.Size(198, 22);
            this.menuItemFinanceReport.Text = "可融资账款明细表(&F)";
            this.menuItemFinanceReport.Click += new System.EventHandler(this.ReportFinance);
            // 
            // menuItemCommissionReport
            // 
            this.menuItemCommissionReport.Name = "menuItemCommissionReport";
            this.menuItemCommissionReport.Size = new System.Drawing.Size(198, 22);
            this.menuItemCommissionReport.Text = "保理费用明细表(&C)";
            this.menuItemCommissionReport.Click += new System.EventHandler(this.ReportCommission);
            // 
            // menuItemThreeReports
            // 
            this.menuItemThreeReports.Name = "menuItemThreeReports";
            this.menuItemThreeReports.Size = new System.Drawing.Size(198, 22);
            this.menuItemThreeReports.Text = "直接生成二表(&T)";
            this.menuItemThreeReports.Click += new System.EventHandler(this.ReportThree);
            // 
            // menuItemFlawReport
            // 
            this.menuItemFlawReport.Name = "menuItemFlawReport";
            this.menuItemFlawReport.Size = new System.Drawing.Size(198, 22);
            this.menuItemFlawReport.Text = "瑕疵通知书";
            this.menuItemFlawReport.Click += new System.EventHandler(this.ReportFlaw);
            // 
            // menuItemFileCheckList
            // 
            this.menuItemFileCheckList.Name = "menuItemFileCheckList";
            this.menuItemFileCheckList.Size = new System.Drawing.Size(198, 22);
            this.menuItemFileCheckList.Text = "文件检查单";
            this.menuItemFileCheckList.Click += new System.EventHandler(this.ReportFileCheckList);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // menuItemMSG09
            // 
            this.menuItemMSG09.Name = "menuItemMSG09";
            this.menuItemMSG09.Size = new System.Drawing.Size(198, 22);
            this.menuItemMSG09.Text = "生成MSG09";
            this.menuItemMSG09.Click += new System.EventHandler(this.ExportMSG09);
            // 
            // menuItemBatchExport
            // 
            this.menuItemBatchExport.Name = "menuItemBatchExport";
            this.menuItemBatchExport.Size = new System.Drawing.Size(198, 22);
            this.menuItemBatchExport.Text = "导出选定批次";
            this.menuItemBatchExport.Click += new System.EventHandler(this.ExportAssignBatch);
            // 
            // AssignBatchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBatches);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AssignBatchMgr";
            this.Size = new System.Drawing.Size(894, 357);
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

        private System.Windows.Forms.ToolStripMenuItem menuItemThreeReports;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchExport;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private DevComponents.DotNetBar.LabelX lblFactorName;
        private DevComponents.DotNetBar.LabelX lblCreateUserName;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateInputTo;
        private DevComponents.DotNetBar.LabelX lblInputDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateInputFrom;
        private System.Windows.Forms.ToolStripMenuItem menuItemCommissionRemitDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsPool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSendMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorCommissionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorCommissionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
    }
}
