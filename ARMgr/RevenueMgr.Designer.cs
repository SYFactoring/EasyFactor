using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
namespace CMBC.EasyFactor.ARMgr
{
    partial class RevenueMgr
    {
		#region?Fields?(27)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRevenueType;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRevenues;
        private DevComponents.DotNetBar.LabelX lblInvoiceNo;
        private DevComponents.DotNetBar.LabelX lblRevenueType;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbInvoiceNo;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.dateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatePicker = new DevComponents.DotNetBar.LabelX();
            this.dateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbRevenueType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblRevenueType = new DevComponents.DotNetBar.LabelX();
            this.tbInvoiceNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInvoiceNo = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.dgvRevenues = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenueValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenues)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelQuery.Controls.Add(this.dateTo);
            this.panelQuery.Controls.Add(this.lblDatePicker);
            this.panelQuery.Controls.Add(this.dateFrom);
            this.panelQuery.Controls.Add(this.cbRevenueType);
            this.panelQuery.Controls.Add(this.lblRevenueType);
            this.panelQuery.Controls.Add(this.tbInvoiceNo);
            this.panelQuery.Controls.Add(this.lblInvoiceNo);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(768, 30);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // dateTo
            // 
            // 
            // 
            // 
            this.dateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTo.ButtonDropDown.Visible = true;
            this.dateTo.IsPopupCalendarOpen = false;
            this.dateTo.Location = new System.Drawing.Point(453, 4);
            // 
            // 
            // 
            this.dateTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.TodayButtonVisible = true;
            this.dateTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(100, 21);
            this.dateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.dateTo.TabIndex = 20;
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            // 
            // 
            // 
            this.lblDatePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatePicker.Location = new System.Drawing.Point(297, 4);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(44, 18);
            this.lblDatePicker.TabIndex = 18;
            this.lblDatePicker.Text = "交易日";
            // 
            // dateFrom
            // 
            // 
            // 
            // 
            this.dateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateFrom.ButtonDropDown.Visible = true;
            this.dateFrom.IsPopupCalendarOpen = false;
            this.dateFrom.Location = new System.Drawing.Point(347, 4);
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(100, 21);
            this.dateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.dateFrom.TabIndex = 19;
            // 
            // cbRevenueType
            // 
            this.cbRevenueType.DisplayMember = "Text";
            this.cbRevenueType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRevenueType.FormattingEnabled = true;
            this.cbRevenueType.ItemHeight = 14;
            this.cbRevenueType.Items.AddRange(new object[] {
            "转让手续费",
            "融资手续费",
            "单据费"});
            this.cbRevenueType.Location = new System.Drawing.Point(193, 4);
            this.cbRevenueType.Name = "cbRevenueType";
            this.cbRevenueType.Size = new System.Drawing.Size(98, 20);
            this.cbRevenueType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbRevenueType.TabIndex = 5;
            // 
            // lblRevenueType
            // 
            // 
            // 
            // 
            this.lblRevenueType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRevenueType.Location = new System.Drawing.Point(162, 5);
            this.lblRevenueType.Name = "lblRevenueType";
            this.lblRevenueType.Size = new System.Drawing.Size(35, 21);
            this.lblRevenueType.TabIndex = 4;
            this.lblRevenueType.Text = "类别";
            // 
            // tbInvoiceNo
            // 
            this.tbInvoiceNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbInvoiceNo.Border.Class = "TextBoxBorder";
            this.tbInvoiceNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbInvoiceNo.DisabledBackColor = System.Drawing.Color.White;
            this.tbInvoiceNo.ForeColor = System.Drawing.Color.Black;
            this.tbInvoiceNo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbInvoiceNo.Location = new System.Drawing.Point(56, 4);
            this.tbInvoiceNo.Name = "tbInvoiceNo";
            this.tbInvoiceNo.Size = new System.Drawing.Size(100, 21);
            this.tbInvoiceNo.TabIndex = 3;
            // 
            // lblInvoiceNo
            // 
            // 
            // 
            // 
            this.lblInvoiceNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInvoiceNo.Location = new System.Drawing.Point(3, 5);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(47, 21);
            this.lblInvoiceNo.TabIndex = 2;
            this.lblInvoiceNo.Text = "发票号";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(721, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 9;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(559, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 21);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryRevenues);
            // 
            // dgvRevenues
            // 
            this.dgvRevenues.AllowUserToAddRows = false;
            this.dgvRevenues.AllowUserToDeleteRows = false;
            this.dgvRevenues.AllowUserToOrderColumns = true;
            this.dgvRevenues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRevenues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRevenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceID,
            this.colRevenueType,
            this.colRevenueDate,
            this.colRevenueCurrency,
            this.colRevenueValue,
            this.colBatchID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRevenues.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRevenues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevenues.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRevenues.Location = new System.Drawing.Point(0, 30);
            this.dgvRevenues.Name = "dgvRevenues";
            this.dgvRevenues.ReadOnly = true;
            this.dgvRevenues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevenues.Size = new System.Drawing.Size(768, 330);
            this.dgvRevenues.TabIndex = 0;
            this.dgvRevenues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRevenues_CellDoubleClick);
            this.dgvRevenues.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvRevenuesRowPostPaint);
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInvoiceID.DataPropertyName = "InvoiceNo";
            this.colInvoiceID.Frozen = true;
            this.colInvoiceID.HeaderText = "发票号";
            this.colInvoiceID.Name = "colInvoiceID";
            this.colInvoiceID.ReadOnly = true;
            this.colInvoiceID.Width = 200;
            // 
            // colRevenueType
            // 
            this.colRevenueType.DataPropertyName = "RevenueType";
            this.colRevenueType.HeaderText = "类别";
            this.colRevenueType.Name = "colRevenueType";
            this.colRevenueType.ReadOnly = true;
            // 
            // colRevenueDate
            // 
            this.colRevenueDate.DataPropertyName = "RevenueDate";
            this.colRevenueDate.HeaderText = "交易日";
            this.colRevenueDate.Name = "colRevenueDate";
            this.colRevenueDate.ReadOnly = true;
            // 
            // colRevenueCurrency
            // 
            this.colRevenueCurrency.DataPropertyName = "RevenueCurrency";
            this.colRevenueCurrency.HeaderText = "币别";
            this.colRevenueCurrency.Name = "colRevenueCurrency";
            this.colRevenueCurrency.ReadOnly = true;
            // 
            // colRevenueValue
            // 
            this.colRevenueValue.DataPropertyName = "RevenueValue";
            this.colRevenueValue.HeaderText = "收入";
            this.colRevenueValue.Name = "colRevenueValue";
            this.colRevenueValue.ReadOnly = true;
            // 
            // colBatchID
            // 
            this.colBatchID.DataPropertyName = "RevenueBatchID";
            this.colBatchID.HeaderText = "批次号";
            this.colBatchID.Name = "colBatchID";
            this.colBatchID.ReadOnly = true;
            // 
            // RevenueMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRevenues);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "RevenueMgr";
            this.Size = new System.Drawing.Size(768, 360);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTo;
        private DevComponents.DotNetBar.LabelX lblDatePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenueValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchID;
    }
}
