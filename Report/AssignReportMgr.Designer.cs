//-----------------------------------------------------------------------
// <copyright file="AssignReportMgr.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Report
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AssignReportMgr
    {
        #region Fields (35)

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.ButtonX btnAssignQuery;
        private DevComponents.DotNetBar.ButtonX btnAssignReport;
        private DevComponents.DotNetBar.ButtonX btnQueryReset;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsFlaw;
        private System.Windows.Forms.ContextMenuStrip cmuInvoiceMgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsFlaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diAssignDateBegin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diAssignDateEnd;
        private DevComponents.DotNetBar.LabelX lblAssignDate;
        private DevComponents.DotNetBar.LabelX lblBuyer;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblFactor;
        private DevComponents.DotNetBar.LabelX lblSeller;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportSelected;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuyer;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSeller;
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbIsFlaw = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnQueryReset = new DevComponents.DotNetBar.ButtonX();
            this.btnAssignReport = new DevComponents.DotNetBar.ButtonX();
            this.diAssignDateEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactor = new DevComponents.DotNetBar.LabelX();
            this.lblAssignDate = new DevComponents.DotNetBar.LabelX();
            this.diAssignDateBegin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbBuyer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBuyer = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnAssignQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbSeller = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSeller = new DevComponents.DotNetBar.LabelX();
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFlaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoiceMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExportSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diAssignDateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diAssignDateBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.cmuInvoiceMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.cbIsFlaw);
            this.panelQuery.Controls.Add(this.btnQueryReset);
            this.panelQuery.Controls.Add(this.btnAssignReport);
            this.panelQuery.Controls.Add(this.diAssignDateEnd);
            this.panelQuery.Controls.Add(this.tbFactor);
            this.panelQuery.Controls.Add(this.lblFactor);
            this.panelQuery.Controls.Add(this.lblAssignDate);
            this.panelQuery.Controls.Add(this.diAssignDateBegin);
            this.panelQuery.Controls.Add(this.tbBuyer);
            this.panelQuery.Controls.Add(this.lblBuyer);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnAssignQuery);
            this.panelQuery.Controls.Add(this.tbSeller);
            this.panelQuery.Controls.Add(this.lblSeller);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(673, 56);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 1;
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
            this.cbIsFlaw.Location = new System.Drawing.Point(312, 10);
            this.cbIsFlaw.Name = "cbIsFlaw";
            this.cbIsFlaw.Size = new System.Drawing.Size(76, 16);
            this.cbIsFlaw.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsFlaw.TabIndex = 4;
            this.cbIsFlaw.Text = "是否瑕疵";
            this.cbIsFlaw.ThreeState = true;
            // 
            // btnQueryReset
            // 
            this.btnQueryReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQueryReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQueryReset.Location = new System.Drawing.Point(421, 31);
            this.btnQueryReset.Name = "btnQueryReset";
            this.btnQueryReset.Size = new System.Drawing.Size(46, 22);
            this.btnQueryReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQueryReset.TabIndex = 11;
            this.btnQueryReset.Text = "重置";
            this.btnQueryReset.Click += new System.EventHandler(this.Reset);
            // 
            // btnAssignReport
            // 
            this.btnAssignReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignReport.Location = new System.Drawing.Point(595, 25);
            this.btnAssignReport.Name = "btnAssignReport";
            this.btnAssignReport.Size = new System.Drawing.Size(75, 23);
            this.btnAssignReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAssignReport.TabIndex = 13;
            this.btnAssignReport.Text = "生成报表";
            this.btnAssignReport.Click += new System.EventHandler(this.GenerateReportAll);
            // 
            // diAssignDateEnd
            // 
            // 
            // 
            // 
            this.diAssignDateEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diAssignDateEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diAssignDateEnd.ButtonDropDown.Visible = true;
            this.diAssignDateEnd.Location = new System.Drawing.Point(312, 28);
            // 
            // 
            // 
            this.diAssignDateEnd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diAssignDateEnd.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diAssignDateEnd.MonthCalendar.BackgroundStyle.Class = "";
            this.diAssignDateEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diAssignDateEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diAssignDateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diAssignDateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diAssignDateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diAssignDateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diAssignDateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diAssignDateEnd.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diAssignDateEnd.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diAssignDateEnd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diAssignDateEnd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diAssignDateEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diAssignDateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diAssignDateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diAssignDateEnd.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diAssignDateEnd.MonthCalendar.TodayButtonVisible = true;
            this.diAssignDateEnd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diAssignDateEnd.Name = "diAssignDateEnd";
            this.diAssignDateEnd.Size = new System.Drawing.Size(100, 20);
            this.diAssignDateEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diAssignDateEnd.TabIndex = 9;
            // 
            // tbFactor
            // 
            // 
            // 
            // 
            this.tbFactor.Border.Class = "TextBoxBorder";
            this.tbFactor.Location = new System.Drawing.Point(50, 29);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(100, 20);
            this.tbFactor.TabIndex = 6;
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            // 
            // 
            // 
            this.lblFactor.BackgroundStyle.Class = "";
            this.lblFactor.Location = new System.Drawing.Point(3, 32);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(44, 16);
            this.lblFactor.TabIndex = 5;
            this.lblFactor.Text = "保理商";
            // 
            // lblAssignDate
            // 
            this.lblAssignDate.AutoSize = true;
            // 
            // 
            // 
            this.lblAssignDate.BackgroundStyle.Class = "";
            this.lblAssignDate.Location = new System.Drawing.Point(156, 32);
            this.lblAssignDate.Name = "lblAssignDate";
            this.lblAssignDate.Size = new System.Drawing.Size(44, 16);
            this.lblAssignDate.TabIndex = 7;
            this.lblAssignDate.Text = "转让日";
            // 
            // diAssignDateBegin
            // 
            // 
            // 
            // 
            this.diAssignDateBegin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diAssignDateBegin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diAssignDateBegin.ButtonDropDown.Visible = true;
            this.diAssignDateBegin.Location = new System.Drawing.Point(206, 29);
            // 
            // 
            // 
            this.diAssignDateBegin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diAssignDateBegin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diAssignDateBegin.MonthCalendar.BackgroundStyle.Class = "";
            this.diAssignDateBegin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diAssignDateBegin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diAssignDateBegin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diAssignDateBegin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diAssignDateBegin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diAssignDateBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diAssignDateBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diAssignDateBegin.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diAssignDateBegin.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diAssignDateBegin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diAssignDateBegin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diAssignDateBegin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diAssignDateBegin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diAssignDateBegin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diAssignDateBegin.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diAssignDateBegin.MonthCalendar.TodayButtonVisible = true;
            this.diAssignDateBegin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diAssignDateBegin.Name = "diAssignDateBegin";
            this.diAssignDateBegin.Size = new System.Drawing.Size(100, 20);
            this.diAssignDateBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diAssignDateBegin.TabIndex = 8;
            // 
            // tbBuyer
            // 
            // 
            // 
            // 
            this.tbBuyer.Border.Class = "TextBoxBorder";
            this.tbBuyer.Location = new System.Drawing.Point(206, 9);
            this.tbBuyer.Name = "tbBuyer";
            this.tbBuyer.Size = new System.Drawing.Size(100, 20);
            this.tbBuyer.TabIndex = 3;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            // 
            // 
            // 
            this.lblBuyer.BackgroundStyle.Class = "";
            this.lblBuyer.Location = new System.Drawing.Point(169, 10);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(31, 16);
            this.lblBuyer.TabIndex = 2;
            this.lblBuyer.Text = "买方";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(484, 31);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 12;
            // 
            // btnAssignQuery
            // 
            this.btnAssignQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignQuery.Location = new System.Drawing.Point(421, 4);
            this.btnAssignQuery.Name = "btnAssignQuery";
            this.btnAssignQuery.Size = new System.Drawing.Size(46, 22);
            this.btnAssignQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAssignQuery.TabIndex = 10;
            this.btnAssignQuery.Text = "查询";
            this.btnAssignQuery.Click += new System.EventHandler(this.QueryInvoices);
            // 
            // tbSeller
            // 
            // 
            // 
            // 
            this.tbSeller.Border.Class = "TextBoxBorder";
            this.tbSeller.Location = new System.Drawing.Point(50, 9);
            this.tbSeller.Name = "tbSeller";
            this.tbSeller.Size = new System.Drawing.Size(100, 20);
            this.tbSeller.TabIndex = 1;
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            // 
            // 
            // 
            this.lblSeller.BackgroundStyle.Class = "";
            this.lblSeller.Location = new System.Drawing.Point(16, 13);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(31, 16);
            this.lblSeller.TabIndex = 0;
            this.lblSeller.Text = "卖方";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellerName,
            this.colBuyerName,
            this.colFactorName,
            this.colAssignBatchNo,
            this.colInvoiceNo,
            this.colInvoiceCurrency,
            this.colAssignAmount,
            this.colInvoiceDate,
            this.colAssignDate,
            this.colDueDate,
            this.colIsFlaw});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoiceMgr;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 56);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(673, 303);
            this.dgvInvoices.TabIndex = 2;
            this.dgvInvoices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInvoices_CellFormatting);
            // 
            // colSellerName
            // 
            this.colSellerName.DataPropertyName = "SellerName";
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
            // colAssignBatchNo
            // 
            this.colAssignBatchNo.DataPropertyName = "AssignBatchNo";
            this.colAssignBatchNo.HeaderText = "转让批号";
            this.colAssignBatchNo.Name = "colAssignBatchNo";
            this.colAssignBatchNo.ReadOnly = true;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle3.Format = "d";
            this.colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInvoiceDate.HeaderText = "发票日";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            dataGridViewCellStyle4.Format = "d";
            this.colAssignDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            this.colAssignDate.ReadOnly = true;
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
            // 
            // colIsFlaw
            // 
            this.colIsFlaw.DataPropertyName = "IsFlaw";
            this.colIsFlaw.HeaderText = "是否瑕疵";
            this.colIsFlaw.Name = "colIsFlaw";
            this.colIsFlaw.ReadOnly = true;
            this.colIsFlaw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmuInvoiceMgr
            // 
            this.cmuInvoiceMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCDADetail,
            this.menuItemCaseDetail,
            this.toolStripSeparator1,
            this.menuItemExportSelected,
            this.menuItemExportAll});
            this.cmuInvoiceMgr.Name = "cmuContractMgr";
            this.cmuInvoiceMgr.Size = new System.Drawing.Size(183, 142);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDADetail.Text = "额度通知书详细信息";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemCaseDetail.Text = "案子详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // menuItemExportSelected
            // 
            this.menuItemExportSelected.Name = "menuItemExportSelected";
            this.menuItemExportSelected.Size = new System.Drawing.Size(182, 22);
            this.menuItemExportSelected.Text = "所选区域生成报表";
            this.menuItemExportSelected.Click += new System.EventHandler(this.GenerateReportSelected);
            // 
            // menuItemExportAll
            // 
            this.menuItemExportAll.Name = "menuItemExportAll";
            this.menuItemExportAll.Size = new System.Drawing.Size(182, 22);
            this.menuItemExportAll.Text = "生成报表";
            this.menuItemExportAll.Click += new System.EventHandler(this.GenerateReportAll);
            // 
            // AssignReportMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AssignReportMgr";
            this.Size = new System.Drawing.Size(673, 359);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diAssignDateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diAssignDateBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.cmuInvoiceMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
