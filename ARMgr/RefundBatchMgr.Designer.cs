﻿namespace CMBC.EasyFactor.ARMgr
{
    partial class RefundBatchMgr
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.cbRefundType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblRefundType = new DevComponents.DotNetBar.LabelX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.cbCheckStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCheckStatus = new DevComponents.DotNetBar.LabelX();
            this.dateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatePicker = new DevComponents.DotNetBar.LabelX();
            this.dateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBatchQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbRefundBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRefundBatchNo = new DevComponents.DotNetBar.LabelX();
            this.dgvBatches = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuBatchMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemBatchSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBatchDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemBatchDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).BeginInit();
            this.cmuBatchMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.cbRefundType);
            this.panelQuery.Controls.Add(this.lblRefundType);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.cbCheckStatus);
            this.panelQuery.Controls.Add(this.lblCheckStatus);
            this.panelQuery.Controls.Add(this.dateTo);
            this.panelQuery.Controls.Add(this.lblDatePicker);
            this.panelQuery.Controls.Add(this.dateFrom);
            this.panelQuery.Controls.Add(this.btnBatchQuery);
            this.panelQuery.Controls.Add(this.tbRefundBatchNo);
            this.panelQuery.Controls.Add(this.lblRefundBatchNo);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(888, 61);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // cbRefundType
            // 
            this.cbRefundType.DisplayMember = "Text";
            this.cbRefundType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRefundType.FormattingEnabled = true;
            this.cbRefundType.ItemHeight = 14;
            this.cbRefundType.Items.AddRange(new object[] {
            "",
            "买方付款",
            "卖方还款",
            "担保付款",
            "间接付款"});
            this.cbRefundType.Location = new System.Drawing.Point(251, 35);
            this.cbRefundType.Name = "cbRefundType";
            this.cbRefundType.Size = new System.Drawing.Size(101, 20);
            this.cbRefundType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbRefundType.TabIndex = 14;
            // 
            // lblRefundType
            // 
            this.lblRefundType.AutoSize = true;
            // 
            // 
            // 
            this.lblRefundType.BackgroundStyle.Class = "";
            this.lblRefundType.Location = new System.Drawing.Point(186, 36);
            this.lblRefundType.Name = "lblRefundType";
            this.lblRefundType.Size = new System.Drawing.Size(59, 16);
            this.lblRefundType.TabIndex = 13;
            this.lblRefundType.Text = "还款类型:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(559, 37);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 12;
            // 
            // cbCheckStatus
            // 
            this.cbCheckStatus.DisplayMember = "Text";
            this.cbCheckStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCheckStatus.FormattingEnabled = true;
            this.cbCheckStatus.ItemHeight = 14;
            this.cbCheckStatus.Items.AddRange(new object[] {
            "",
            "未复核",
            "已复核",
            "复核未通过"});
            this.cbCheckStatus.Location = new System.Drawing.Point(79, 33);
            this.cbCheckStatus.Name = "cbCheckStatus";
            this.cbCheckStatus.Size = new System.Drawing.Size(101, 20);
            this.cbCheckStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCheckStatus.TabIndex = 11;
            // 
            // lblCheckStatus
            // 
            this.lblCheckStatus.AutoSize = true;
            // 
            // 
            // 
            this.lblCheckStatus.BackgroundStyle.Class = "";
            this.lblCheckStatus.Location = new System.Drawing.Point(14, 34);
            this.lblCheckStatus.Name = "lblCheckStatus";
            this.lblCheckStatus.Size = new System.Drawing.Size(59, 16);
            this.lblCheckStatus.TabIndex = 10;
            this.lblCheckStatus.Text = "复核结果:";
            // 
            // dateTo
            // 
            // 
            // 
            // 
            this.dateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTo.ButtonDropDown.Visible = true;
            this.dateTo.Location = new System.Drawing.Point(357, 10);
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
            this.dateTo.TabIndex = 9;
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            // 
            // 
            // 
            this.lblDatePicker.BackgroundStyle.Class = "";
            this.lblDatePicker.Location = new System.Drawing.Point(198, 14);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(47, 16);
            this.lblDatePicker.TabIndex = 7;
            this.lblDatePicker.Text = "还款日:";
            // 
            // dateFrom
            // 
            // 
            // 
            // 
            this.dateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateFrom.ButtonDropDown.Visible = true;
            this.dateFrom.Location = new System.Drawing.Point(251, 10);
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
            this.dateFrom.TabIndex = 8;
            // 
            // btnBatchQuery
            // 
            this.btnBatchQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatchQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatchQuery.Location = new System.Drawing.Point(463, 7);
            this.btnBatchQuery.Name = "btnBatchQuery";
            this.btnBatchQuery.Size = new System.Drawing.Size(75, 23);
            this.btnBatchQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatchQuery.TabIndex = 5;
            this.btnBatchQuery.Text = "查询";
            this.btnBatchQuery.Click += new System.EventHandler(this.QueryBatch);
            // 
            // tbRefundBatchNo
            // 
            // 
            // 
            // 
            this.tbRefundBatchNo.Border.Class = "TextBoxBorder";
            this.tbRefundBatchNo.Location = new System.Drawing.Point(80, 10);
            this.tbRefundBatchNo.Name = "tbRefundBatchNo";
            this.tbRefundBatchNo.Size = new System.Drawing.Size(100, 20);
            this.tbRefundBatchNo.TabIndex = 4;
            // 
            // lblRefundBatchNo
            // 
            this.lblRefundBatchNo.AutoSize = true;
            // 
            // 
            // 
            this.lblRefundBatchNo.BackgroundStyle.Class = "";
            this.lblRefundBatchNo.Location = new System.Drawing.Point(14, 12);
            this.lblRefundBatchNo.Name = "lblRefundBatchNo";
            this.lblRefundBatchNo.Size = new System.Drawing.Size(59, 16);
            this.lblRefundBatchNo.TabIndex = 3;
            this.lblRefundBatchNo.Text = "还款批号:";
            // 
            // dgvBatches
            // 
            this.dgvBatches.AllowUserToAddRows = false;
            this.dgvBatches.AllowUserToDeleteRows = false;
            this.dgvBatches.AllowUserToOrderColumns = true;
            this.dgvBatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.colRefundBatchNo,
            this.colRefundType,
            this.colRefundDate,
            this.colRefundAmount,
            this.colCreateUserName,
            this.colCheckStatus,
            this.colCheckUserName,
            this.colCheckDate,
            this.colBatchCount});
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
            this.dgvBatches.Location = new System.Drawing.Point(0, 61);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.ReadOnly = true;
            this.dgvBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatches.Size = new System.Drawing.Size(888, 327);
            this.dgvBatches.TabIndex = 1;
            this.dgvBatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatches_CellDoubleClick);
            this.dgvBatches.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBatches_RowPostPaint);
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
            // colRefundBatchNo
            // 
            this.colRefundBatchNo.DataPropertyName = "RefundBatchNo";
            this.colRefundBatchNo.HeaderText = "付款批号";
            this.colRefundBatchNo.Name = "colRefundBatchNo";
            this.colRefundBatchNo.ReadOnly = true;
            // 
            // colRefundType
            // 
            this.colRefundType.DataPropertyName = "RefundType";
            this.colRefundType.HeaderText = "付款类型";
            this.colRefundType.Name = "colRefundType";
            this.colRefundType.ReadOnly = true;
            // 
            // colRefundDate
            // 
            this.colRefundDate.DataPropertyName = "RefundDate";
            this.colRefundDate.HeaderText = "付款日";
            this.colRefundDate.Name = "colRefundDate";
            this.colRefundDate.ReadOnly = true;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRefundAmount.HeaderText = "付款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // colCheckStatus
            // 
            this.colCheckStatus.DataPropertyName = "CheckStatus";
            this.colCheckStatus.HeaderText = "复核结果";
            this.colCheckStatus.Name = "colCheckStatus";
            this.colCheckStatus.ReadOnly = true;
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
            // colBatchCount
            // 
            this.colBatchCount.DataPropertyName = "BatchCount";
            this.colBatchCount.HeaderText = "发票笔数";
            this.colBatchCount.Name = "colBatchCount";
            this.colBatchCount.ReadOnly = true;
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
            this.menuItemBatchDelete});
            this.cmuBatchMgr.Name = "cmuBatchMgr";
            this.cmuBatchMgr.Size = new System.Drawing.Size(153, 148);
            // 
            // menuItemBatchSelect
            // 
            this.menuItemBatchSelect.Name = "menuItemBatchSelect";
            this.menuItemBatchSelect.Size = new System.Drawing.Size(152, 22);
            this.menuItemBatchSelect.Text = "&S选择批次";
            this.menuItemBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // menuItemBatchDetail
            // 
            this.menuItemBatchDetail.Name = "menuItemBatchDetail";
            this.menuItemBatchDetail.Size = new System.Drawing.Size(152, 22);
            this.menuItemBatchDetail.Text = "&M批次详情";
            this.menuItemBatchDetail.Click += new System.EventHandler(this.DetailBatch);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemCheck
            // 
            this.menuItemCheck.Name = "menuItemCheck";
            this.menuItemCheck.Size = new System.Drawing.Size(152, 22);
            this.menuItemCheck.Text = "&P复核通过";
            this.menuItemCheck.Click += new System.EventHandler(this.Check);
            // 
            // menuItemReject
            // 
            this.menuItemReject.Name = "menuItemReject";
            this.menuItemReject.Size = new System.Drawing.Size(152, 22);
            this.menuItemReject.Text = "&R复核拒绝";
            this.menuItemReject.Click += new System.EventHandler(this.Reject);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemBatchDelete
            // 
            this.menuItemBatchDelete.Name = "menuItemBatchDelete";
            this.menuItemBatchDelete.Size = new System.Drawing.Size(152, 22);
            this.menuItemBatchDelete.Text = "&D删除批次";
            this.menuItemBatchDelete.Click += new System.EventHandler(this.DeleteBatch);
            // 
            // RefundBatchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBatches);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "RefundBatchMgr";
            this.Size = new System.Drawing.Size(888, 388);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).EndInit();
            this.cmuBatchMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.ButtonX btnBatchQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRefundBatchNo;
        private DevComponents.DotNetBar.LabelX lblRefundBatchNo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBatches;
        private System.Windows.Forms.ContextMenuStrip cmuBatchMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheck;
        private System.Windows.Forms.ToolStripMenuItem menuItemReject;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCheckStatus;
        private DevComponents.DotNetBar.LabelX lblCheckStatus;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTo;
        private DevComponents.DotNetBar.LabelX lblDatePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFrom;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRefundType;
        private DevComponents.DotNetBar.LabelX lblRefundType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemBatchDelete;
    }
}