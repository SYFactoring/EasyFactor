using CMBC.EasyFactor.Utils;
namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoiceMgr
    {
		#region?Fields?(72)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseMark;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsDispute;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsFlaw;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTransactionType;
        private System.Windows.Forms.ContextMenuStrip cmuInvoiceMgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOverDueDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOverDueDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrossInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDispute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsFlaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFrom;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private DevComponents.DotNetBar.LabelX lblAssignOutstanding;
        private DevComponents.DotNetBar.LabelX lblAssignOverDueDays;
        private DevComponents.DotNetBar.LabelX lblCaseMark;
        private DevComponents.DotNetBar.LabelX lblClient;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblDatePicker;
        private DevComponents.DotNetBar.LabelX lblFactor;
        private DevComponents.DotNetBar.LabelX lblFinanceOutstanding;
        private DevComponents.DotNetBar.LabelX lblFinanceOverDueDays;
        private DevComponents.DotNetBar.LabelX lblInvoiceNo;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private DevComponents.DotNetBar.LabelX lblTransactionType;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllInvoiceFull;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllInvoiceOverDue;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaculateFinance;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCommission;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportAllInvoices;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportSelectedInvoices;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDispute;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceFlaw;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectedInvoiceFull;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectedInvoiceOverDue;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignOverDueDays;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceOutstanding;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceOverDueDays;
        private DevComponents.DotNetBar.Controls.TextBoxX tbInvoiceNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbTransactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTransactionType = new DevComponents.DotNetBar.LabelX();
            this.tbFinanceOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFinanceOutstanding = new DevComponents.DotNetBar.LabelX();
            this.tbAssignOutstanding = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAssignOutstanding = new DevComponents.DotNetBar.LabelX();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.dateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatePicker = new DevComponents.DotNetBar.LabelX();
            this.dateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblCaseMark = new DevComponents.DotNetBar.LabelX();
            this.cbCaseMark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbFinanceOverDueDays = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFinanceOverDueDays = new DevComponents.DotNetBar.LabelX();
            this.tbAssignOverDueDays = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAssignOverDueDays = new DevComponents.DotNetBar.LabelX();
            this.cbIsDispute = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbIsFlaw = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tbInvoiceNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInvoiceNo = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQueryReset = new DevComponents.DotNetBar.ButtonX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactor = new DevComponents.DotNetBar.LabelX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClient = new DevComponents.DotNetBar.LabelX();
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrossInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFlaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDispute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOverDueDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOverDueDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoiceMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemInvoiceFlaw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInvoiceDispute = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInvoiceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaculateFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCommission = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExportAllInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllInvoiceFull = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllInvoiceOverDue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExportSelectedInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSelectedInvoiceFull = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSelectedInvoiceOverDue = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCaseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCaseCode = new DevComponents.DotNetBar.LabelX();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.cmuInvoiceMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.tbCaseCode);
            this.panelQuery.Controls.Add(this.lblCaseCode);
            this.panelQuery.Controls.Add(this.cbTransactionType);
            this.panelQuery.Controls.Add(this.lblTransactionType);
            this.panelQuery.Controls.Add(this.tbFinanceOutstanding);
            this.panelQuery.Controls.Add(this.lblFinanceOutstanding);
            this.panelQuery.Controls.Add(this.tbAssignOutstanding);
            this.panelQuery.Controls.Add(this.lblAssignOutstanding);
            this.panelQuery.Controls.Add(this.cbLocation);
            this.panelQuery.Controls.Add(this.lblLocation);
            this.panelQuery.Controls.Add(this.dateTo);
            this.panelQuery.Controls.Add(this.lblDatePicker);
            this.panelQuery.Controls.Add(this.dateFrom);
            this.panelQuery.Controls.Add(this.lblCaseMark);
            this.panelQuery.Controls.Add(this.cbCaseMark);
            this.panelQuery.Controls.Add(this.tbFinanceOverDueDays);
            this.panelQuery.Controls.Add(this.lblFinanceOverDueDays);
            this.panelQuery.Controls.Add(this.tbAssignOverDueDays);
            this.panelQuery.Controls.Add(this.lblAssignOverDueDays);
            this.panelQuery.Controls.Add(this.cbIsDispute);
            this.panelQuery.Controls.Add(this.cbIsFlaw);
            this.panelQuery.Controls.Add(this.tbInvoiceNo);
            this.panelQuery.Controls.Add(this.lblInvoiceNo);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQueryReset);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbFactor);
            this.panelQuery.Controls.Add(this.lblFactor);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClient);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(891, 78);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
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
            this.cbTransactionType.Location = new System.Drawing.Point(234, 53);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(101, 20);
            this.cbTransactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTransactionType.TabIndex = 11;
            // 
            // lblTransactionType
            // 
            // 
            // 
            // 
            this.lblTransactionType.BackgroundStyle.Class = "";
            this.lblTransactionType.Location = new System.Drawing.Point(173, 52);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(59, 23);
            this.lblTransactionType.TabIndex = 10;
            this.lblTransactionType.Text = "业务类别";
            // 
            // tbFinanceOutstanding
            // 
            // 
            // 
            // 
            this.tbFinanceOutstanding.Border.Class = "TextBoxBorder";
            this.tbFinanceOutstanding.Location = new System.Drawing.Point(598, 31);
            this.tbFinanceOutstanding.Name = "tbFinanceOutstanding";
            this.tbFinanceOutstanding.Size = new System.Drawing.Size(98, 20);
            this.tbFinanceOutstanding.TabIndex = 21;
            // 
            // lblFinanceOutstanding
            // 
            this.lblFinanceOutstanding.AutoSize = true;
            // 
            // 
            // 
            this.lblFinanceOutstanding.BackgroundStyle.Class = "";
            this.lblFinanceOutstanding.Location = new System.Drawing.Point(536, 32);
            this.lblFinanceOutstanding.Name = "lblFinanceOutstanding";
            this.lblFinanceOutstanding.Size = new System.Drawing.Size(56, 16);
            this.lblFinanceOutstanding.TabIndex = 20;
            this.lblFinanceOutstanding.Text = "融资余额";
            // 
            // tbAssignOutstanding
            // 
            // 
            // 
            // 
            this.tbAssignOutstanding.Border.Class = "TextBoxBorder";
            this.tbAssignOutstanding.Location = new System.Drawing.Point(597, 9);
            this.tbAssignOutstanding.Name = "tbAssignOutstanding";
            this.tbAssignOutstanding.Size = new System.Drawing.Size(98, 20);
            this.tbAssignOutstanding.TabIndex = 19;
            // 
            // lblAssignOutstanding
            // 
            this.lblAssignOutstanding.AutoSize = true;
            // 
            // 
            // 
            this.lblAssignOutstanding.BackgroundStyle.Class = "";
            this.lblAssignOutstanding.Location = new System.Drawing.Point(535, 12);
            this.lblAssignOutstanding.Name = "lblAssignOutstanding";
            this.lblAssignOutstanding.Size = new System.Drawing.Size(56, 16);
            this.lblAssignOutstanding.TabIndex = 18;
            this.lblAssignOutstanding.Text = "转让余额";
            // 
            // cbLocation
            // 
            this.cbLocation.DisplayMember = "Text";
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(432, 53);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(100, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLocation.TabIndex = 17;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.Class = "";
            this.lblLocation.Location = new System.Drawing.Point(373, 55);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 16);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "业务地区";
            // 
            // dateTo
            // 
            // 
            // 
            // 
            this.dateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTo.ButtonDropDown.Visible = true;
            this.dateTo.Location = new System.Drawing.Point(702, 53);
            // 
            // 
            // 
            this.dateTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTo.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.TodayButtonVisible = true;
            this.dateTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(100, 20);
            this.dateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTo.TabIndex = 24;
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            // 
            // 
            // 
            this.lblDatePicker.BackgroundStyle.Class = "";
            this.lblDatePicker.Location = new System.Drawing.Point(548, 55);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(44, 16);
            this.lblDatePicker.TabIndex = 22;
            this.lblDatePicker.Text = "转让日";
            // 
            // dateFrom
            // 
            // 
            // 
            // 
            this.dateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateFrom.ButtonDropDown.Visible = true;
            this.dateFrom.Location = new System.Drawing.Point(598, 53);
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateFrom.MonthCalendar.BackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(100, 20);
            this.dateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateFrom.TabIndex = 23;
            // 
            // lblCaseMark
            // 
            this.lblCaseMark.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseMark.BackgroundStyle.Class = "";
            this.lblCaseMark.Location = new System.Drawing.Point(5, 56);
            this.lblCaseMark.Name = "lblCaseMark";
            this.lblCaseMark.Size = new System.Drawing.Size(56, 16);
            this.lblCaseMark.TabIndex = 4;
            this.lblCaseMark.Text = "案件状态";
            // 
            // cbCaseMark
            // 
            this.cbCaseMark.DisplayMember = "Text";
            this.cbCaseMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseMark.FormattingEnabled = true;
            this.cbCaseMark.ItemHeight = 14;
            this.cbCaseMark.Items.AddRange(new object[] {
            "申请案",
            "启动案",
            "已结案"});
            this.cbCaseMark.Location = new System.Drawing.Point(67, 53);
            this.cbCaseMark.Name = "cbCaseMark";
            this.cbCaseMark.Size = new System.Drawing.Size(100, 20);
            this.cbCaseMark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCaseMark.TabIndex = 5;
            // 
            // tbFinanceOverDueDays
            // 
            // 
            // 
            // 
            this.tbFinanceOverDueDays.Border.Class = "TextBoxBorder";
            this.tbFinanceOverDueDays.Location = new System.Drawing.Point(431, 31);
            this.tbFinanceOverDueDays.Name = "tbFinanceOverDueDays";
            this.tbFinanceOverDueDays.Size = new System.Drawing.Size(98, 20);
            this.tbFinanceOverDueDays.TabIndex = 15;
            // 
            // lblFinanceOverDueDays
            // 
            this.lblFinanceOverDueDays.AutoSize = true;
            // 
            // 
            // 
            this.lblFinanceOverDueDays.BackgroundStyle.Class = "";
            this.lblFinanceOverDueDays.Location = new System.Drawing.Point(352, 33);
            this.lblFinanceOverDueDays.Name = "lblFinanceOverDueDays";
            this.lblFinanceOverDueDays.Size = new System.Drawing.Size(81, 16);
            this.lblFinanceOverDueDays.TabIndex = 14;
            this.lblFinanceOverDueDays.Text = "融资逾期天数";
            // 
            // tbAssignOverDueDays
            // 
            // 
            // 
            // 
            this.tbAssignOverDueDays.Border.Class = "TextBoxBorder";
            this.tbAssignOverDueDays.Location = new System.Drawing.Point(431, 9);
            this.tbAssignOverDueDays.Name = "tbAssignOverDueDays";
            this.tbAssignOverDueDays.Size = new System.Drawing.Size(98, 20);
            this.tbAssignOverDueDays.TabIndex = 13;
            // 
            // lblAssignOverDueDays
            // 
            this.lblAssignOverDueDays.AutoSize = true;
            // 
            // 
            // 
            this.lblAssignOverDueDays.BackgroundStyle.Class = "";
            this.lblAssignOverDueDays.Location = new System.Drawing.Point(352, 11);
            this.lblAssignOverDueDays.Name = "lblAssignOverDueDays";
            this.lblAssignOverDueDays.Size = new System.Drawing.Size(81, 16);
            this.lblAssignOverDueDays.TabIndex = 12;
            this.lblAssignOverDueDays.Text = "账款逾期天数";
            // 
            // cbIsDispute
            // 
            this.cbIsDispute.AutoSize = true;
            // 
            // 
            // 
            this.cbIsDispute.BackgroundStyle.Class = "";
            this.cbIsDispute.Checked = true;
            this.cbIsDispute.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIsDispute.CheckValue = "A";
            this.cbIsDispute.CheckValueIndeterminate = "A";
            this.cbIsDispute.Location = new System.Drawing.Point(721, 34);
            this.cbIsDispute.Name = "cbIsDispute";
            this.cbIsDispute.Size = new System.Drawing.Size(76, 16);
            this.cbIsDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsDispute.TabIndex = 26;
            this.cbIsDispute.Text = "是否商纠";
            this.cbIsDispute.ThreeState = true;
            // 
            // cbIsFlaw
            // 
            this.cbIsFlaw.AutoSize = true;
            // 
            // 
            // 
            this.cbIsFlaw.BackgroundStyle.Class = "";
            this.cbIsFlaw.Checked = true;
            this.cbIsFlaw.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbIsFlaw.CheckValue = "A";
            this.cbIsFlaw.CheckValueIndeterminate = "A";
            this.cbIsFlaw.Location = new System.Drawing.Point(721, 9);
            this.cbIsFlaw.Name = "cbIsFlaw";
            this.cbIsFlaw.Size = new System.Drawing.Size(76, 16);
            this.cbIsFlaw.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsFlaw.TabIndex = 25;
            this.cbIsFlaw.Text = "是否瑕疵";
            this.cbIsFlaw.ThreeState = true;
            // 
            // tbInvoiceNo
            // 
            // 
            // 
            // 
            this.tbInvoiceNo.Border.Class = "TextBoxBorder";
            this.tbInvoiceNo.Location = new System.Drawing.Point(234, 8);
            this.tbInvoiceNo.Name = "tbInvoiceNo";
            this.tbInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.tbInvoiceNo.TabIndex = 7;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            // 
            // 
            // 
            this.lblInvoiceNo.BackgroundStyle.Class = "";
            this.lblInvoiceNo.Location = new System.Drawing.Point(184, 11);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(44, 16);
            this.lblInvoiceNo.TabIndex = 6;
            this.lblInvoiceNo.Text = "发票号";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(803, 55);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(71, 16);
            this.lblCount.TabIndex = 29;
            this.lblCount.Text = "获得 条记录";
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(803, 29);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(46, 22);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 28;
            this.btnQueryReset.Text = "重置";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(803, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(46, 22);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 27;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryInvoices);
            // 
            // tbFactor
            // 
            // 
            // 
            // 
            this.tbFactor.Border.Class = "TextBoxBorder";
            this.tbFactor.Location = new System.Drawing.Point(67, 29);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(100, 20);
            this.tbFactor.TabIndex = 3;
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            // 
            // 
            // 
            this.lblFactor.BackgroundStyle.Class = "";
            this.lblFactor.Location = new System.Drawing.Point(17, 31);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(44, 16);
            this.lblFactor.TabIndex = 2;
            this.lblFactor.Text = "保理商";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(67, 6);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            // 
            // 
            // 
            this.lblClient.BackgroundStyle.Class = "";
            this.lblClient.Location = new System.Drawing.Point(5, 9);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(56, 16);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "客户名称";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellerName,
            this.colBuyerName,
            this.colFactorName,
            this.colInvoiceNo,
            this.colInvoiceCurrency,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colInvoiceDate,
            this.colDueDate,
            this.colAssignDate,
            this.colFinanceAmount,
            this.colFinanceOutstanding,
            this.colFinanceDate,
            this.colFinanceDueDate,
            this.colPaymentAmount,
            this.colPaymentDate,
            this.colRefundAmount,
            this.colRefundDate,
            this.colCommission,
            this.colInterest,
            this.colGrossInterest,
            this.colIsFlaw,
            this.colIsDispute,
            this.colAssignOverDueDays,
            this.colFinanceOverDueDays});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoiceMgr;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 78);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(891, 347);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvInvoices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInvoices_CellFormatting);
            this.dgvInvoices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInvoices_DataBindingComplete);
            this.dgvInvoices.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInvoices_RowPostPaint);
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
            this.colSellerName.HeaderText = "卖方名称";
            this.colSellerName.Name = "colSellerName";
            this.colSellerName.ReadOnly = true;
            this.colSellerName.Width = 80;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "买方名称";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            this.colBuyerName.Width = 80;
            // 
            // colFactorName
            // 
            this.colFactorName.DataPropertyName = "FactorName";
            this.colFactorName.HeaderText = "保理商";
            this.colFactorName.Name = "colFactorName";
            this.colFactorName.ReadOnly = true;
            this.colFactorName.Width = 68;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            this.colInvoiceNo.Width = 68;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            this.colInvoiceCurrency.Width = 80;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            this.colAssignAmount.Width = 80;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle3.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAssignOutstanding.HeaderText = "转让余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            this.colAssignOutstanding.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle4.Format = "d";
            this.colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colInvoiceDate.HeaderText = "发票日";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            this.colInvoiceDate.Width = 68;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDueDate.HeaderText = "到期日";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Width = 68;
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            dataGridViewCellStyle6.Format = "d";
            this.colAssignDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            this.colAssignDate.ReadOnly = true;
            this.colAssignDate.Width = 68;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle7.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            this.colFinanceAmount.Width = 80;
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle8.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle8;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            this.colFinanceOutstanding.ReadOnly = true;
            // 
            // colFinanceDate
            // 
            this.colFinanceDate.DataPropertyName = "FinanceDate";
            this.colFinanceDate.HeaderText = "融资日";
            this.colFinanceDate.Name = "colFinanceDate";
            this.colFinanceDate.ReadOnly = true;
            this.colFinanceDate.Width = 68;
            // 
            // colFinanceDueDate
            // 
            this.colFinanceDueDate.DataPropertyName = "FinanceDueDate";
            this.colFinanceDueDate.HeaderText = "融资到期日";
            this.colFinanceDueDate.Name = "colFinanceDueDate";
            this.colFinanceDueDate.ReadOnly = true;
            this.colFinanceDueDate.Width = 92;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle9.Format = "N2";
            this.colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPaymentAmount.HeaderText = "付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            this.colPaymentAmount.Width = 80;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            this.colPaymentDate.HeaderText = "付款日";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;
            this.colPaymentDate.Width = 68;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle10.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle10;
            this.colRefundAmount.HeaderText = "还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.ReadOnly = true;
            this.colRefundAmount.Width = 80;
            // 
            // colRefundDate
            // 
            this.colRefundDate.DataPropertyName = "RefundDate";
            this.colRefundDate.HeaderText = "还款日";
            this.colRefundDate.Name = "colRefundDate";
            this.colRefundDate.ReadOnly = true;
            this.colRefundDate.Width = 68;
            // 
            // colCommission
            // 
            this.colCommission.DataPropertyName = "Commission";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.colCommission.DefaultCellStyle = dataGridViewCellStyle11;
            this.colCommission.HeaderText = "手续费收入";
            this.colCommission.Name = "colCommission";
            this.colCommission.ReadOnly = true;
            // 
            // colInterest
            // 
            this.colInterest.DataPropertyName = "NetInterest";
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.colInterest.DefaultCellStyle = dataGridViewCellStyle12;
            this.colInterest.HeaderText = "净利息";
            this.colInterest.Name = "colInterest";
            this.colInterest.ReadOnly = true;
            // 
            // colGrossInterest
            // 
            this.colGrossInterest.DataPropertyName = "GrossInterest";
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.colGrossInterest.DefaultCellStyle = dataGridViewCellStyle13;
            this.colGrossInterest.HeaderText = "毛利息";
            this.colGrossInterest.Name = "colGrossInterest";
            this.colGrossInterest.ReadOnly = true;
            // 
            // colIsFlaw
            // 
            this.colIsFlaw.DataPropertyName = "IsFlaw";
            this.colIsFlaw.HeaderText = "是否瑕疵";
            this.colIsFlaw.Name = "colIsFlaw";
            this.colIsFlaw.ReadOnly = true;
            this.colIsFlaw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsFlaw.Width = 80;
            // 
            // colIsDispute
            // 
            this.colIsDispute.DataPropertyName = "IsDispute";
            this.colIsDispute.HeaderText = "是否商纠";
            this.colIsDispute.Name = "colIsDispute";
            this.colIsDispute.ReadOnly = true;
            this.colIsDispute.Width = 80;
            // 
            // colAssignOverDueDays
            // 
            this.colAssignOverDueDays.DataPropertyName = "AssignOverDueDays";
            this.colAssignOverDueDays.HeaderText = "账款逾期天数";
            this.colAssignOverDueDays.Name = "colAssignOverDueDays";
            this.colAssignOverDueDays.ReadOnly = true;
            this.colAssignOverDueDays.Visible = false;
            this.colAssignOverDueDays.Width = 128;
            // 
            // colFinanceOverDueDays
            // 
            this.colFinanceOverDueDays.DataPropertyName = "FinanceOverDueDays";
            this.colFinanceOverDueDays.HeaderText = "融资逾期天数";
            this.colFinanceOverDueDays.Name = "colFinanceOverDueDays";
            this.colFinanceOverDueDays.ReadOnly = true;
            this.colFinanceOverDueDays.Visible = false;
            this.colFinanceOverDueDays.Width = 104;
            // 
            // cmuInvoiceMgr
            // 
            this.cmuInvoiceMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCaseDetail,
            this.toolStripSeparator,
            this.menuItemInvoiceFlaw,
            this.menuItemInvoiceDispute,
            this.menuItemInvoiceDelete,
            this.menuItemCaculateFinance,
            this.menuItemCommission,
            this.toolStripSeparator1,
            this.menuItemExportAllInvoices,
            this.menuItemExportSelectedInvoices});
            this.cmuInvoiceMgr.Name = "cmuContractMgr";
            this.cmuInvoiceMgr.Size = new System.Drawing.Size(159, 214);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(158, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(158, 22);
            this.menuItemCaseDetail.Text = "案子详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(155, 6);
            // 
            // menuItemInvoiceFlaw
            // 
            this.menuItemInvoiceFlaw.Name = "menuItemInvoiceFlaw";
            this.menuItemInvoiceFlaw.Size = new System.Drawing.Size(158, 22);
            this.menuItemInvoiceFlaw.Text = "瑕疵处理";
            this.menuItemInvoiceFlaw.Click += new System.EventHandler(this.InvoiceFlaw);
            // 
            // menuItemInvoiceDispute
            // 
            this.menuItemInvoiceDispute.Name = "menuItemInvoiceDispute";
            this.menuItemInvoiceDispute.Size = new System.Drawing.Size(158, 22);
            this.menuItemInvoiceDispute.Text = "商纠处理";
            this.menuItemInvoiceDispute.Click += new System.EventHandler(this.InvoiceDispute);
            // 
            // menuItemInvoiceDelete
            // 
            this.menuItemInvoiceDelete.Name = "menuItemInvoiceDelete";
            this.menuItemInvoiceDelete.Size = new System.Drawing.Size(158, 22);
            this.menuItemInvoiceDelete.Text = "删除发票";
            this.menuItemInvoiceDelete.Click += new System.EventHandler(this.DeleteInvoice);
            // 
            // menuItemCaculateFinance
            // 
            this.menuItemCaculateFinance.Name = "menuItemCaculateFinance";
            this.menuItemCaculateFinance.Size = new System.Drawing.Size(158, 22);
            this.menuItemCaculateFinance.Text = "修正多币种Bug";
            this.menuItemCaculateFinance.Click += new System.EventHandler(this.CaculateFinance);
            // 
            // menuItemCommission
            // 
            this.menuItemCommission.Name = "menuItemCommission";
            this.menuItemCommission.Size = new System.Drawing.Size(158, 22);
            this.menuItemCommission.Text = "重新计算手续费";
            this.menuItemCommission.Click += new System.EventHandler(this.ComputeCommission);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // menuItemExportAllInvoices
            // 
            this.menuItemExportAllInvoices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAllInvoiceFull,
            this.menuItemAllInvoiceOverDue});
            this.menuItemExportAllInvoices.Name = "menuItemExportAllInvoices";
            this.menuItemExportAllInvoices.Size = new System.Drawing.Size(158, 22);
            this.menuItemExportAllInvoices.Text = "导出全部发票";
            // 
            // menuItemAllInvoiceFull
            // 
            this.menuItemAllInvoiceFull.Name = "menuItemAllInvoiceFull";
            this.menuItemAllInvoiceFull.Size = new System.Drawing.Size(146, 22);
            this.menuItemAllInvoiceFull.Text = "完整格式";
            this.menuItemAllInvoiceFull.Click += new System.EventHandler(this.ExportAllInvoicesFull);
            // 
            // menuItemAllInvoiceOverDue
            // 
            this.menuItemAllInvoiceOverDue.Name = "menuItemAllInvoiceOverDue";
            this.menuItemAllInvoiceOverDue.Size = new System.Drawing.Size(146, 22);
            this.menuItemAllInvoiceOverDue.Text = "逾期台帐格式";
            this.menuItemAllInvoiceOverDue.Click += new System.EventHandler(this.ExportAllInvoiceOverDue);
            // 
            // menuItemExportSelectedInvoices
            // 
            this.menuItemExportSelectedInvoices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectedInvoiceFull,
            this.menuItemSelectedInvoiceOverDue});
            this.menuItemExportSelectedInvoices.Name = "menuItemExportSelectedInvoices";
            this.menuItemExportSelectedInvoices.Size = new System.Drawing.Size(158, 22);
            this.menuItemExportSelectedInvoices.Text = "导出所选发票";
            // 
            // menuItemSelectedInvoiceFull
            // 
            this.menuItemSelectedInvoiceFull.Name = "menuItemSelectedInvoiceFull";
            this.menuItemSelectedInvoiceFull.Size = new System.Drawing.Size(146, 22);
            this.menuItemSelectedInvoiceFull.Text = "完整格式";
            this.menuItemSelectedInvoiceFull.Click += new System.EventHandler(this.ExportSelectedInvoicesFull);
            // 
            // menuItemSelectedInvoiceOverDue
            // 
            this.menuItemSelectedInvoiceOverDue.Name = "menuItemSelectedInvoiceOverDue";
            this.menuItemSelectedInvoiceOverDue.Size = new System.Drawing.Size(146, 22);
            this.menuItemSelectedInvoiceOverDue.Text = "逾期台帐格式";
            this.menuItemSelectedInvoiceOverDue.Click += new System.EventHandler(this.ExportSelectedInvoicesOverDue);
            // 
            // tbCaseCode
            // 
            // 
            // 
            // 
            this.tbCaseCode.Border.Class = "TextBoxBorder";
            this.tbCaseCode.Location = new System.Drawing.Point(234, 31);
            this.tbCaseCode.Name = "tbCaseCode";
            this.tbCaseCode.Size = new System.Drawing.Size(101, 20);
            this.tbCaseCode.TabIndex = 9;
            // 
            // lblCaseCode
            // 
            this.lblCaseCode.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseCode.BackgroundStyle.Class = "";
            this.lblCaseCode.Location = new System.Drawing.Point(172, 33);
            this.lblCaseCode.Name = "lblCaseCode";
            this.lblCaseCode.Size = new System.Drawing.Size(56, 16);
            this.lblCaseCode.TabIndex = 8;
            this.lblCaseCode.Text = "案件编号";
            // 
            // InvoiceMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceMgr";
            this.Size = new System.Drawing.Size(891, 425);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.cmuInvoiceMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbCaseCode;
        private DevComponents.DotNetBar.LabelX lblCaseCode;
    }
}
