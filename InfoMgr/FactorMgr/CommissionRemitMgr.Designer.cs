//-----------------------------------------------------------------------
// <copyright file="CommissionRemitMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    partial class CommissionRemitMgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCommissionRemit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuCommissionRemitMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCommissionRemitSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCommissionRemitDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCommissionRemitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.dateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDatePicker = new DevComponents.DotNetBar.LabelX();
            this.dateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbFactorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorName = new DevComponents.DotNetBar.LabelX();
            this.tbFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorCode = new DevComponents.DotNetBar.LabelX();
            this.factorCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMsgType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMsgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMsgCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMsgAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemitCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissionRemit)).BeginInit();
            this.contextMenuCommissionRemitMgr.SuspendLayout();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommissionRemit
            // 
            this.dgvCommissionRemit.AllowUserToAddRows = false;
            this.dgvCommissionRemit.AllowUserToDeleteRows = false;
            this.dgvCommissionRemit.AllowUserToOrderColumns = true;
            this.dgvCommissionRemit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommissionRemit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommissionRemit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommissionRemit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factorCodeColumn,
            this.CompanyNameColumn,
            this.colBatchCount,
            this.colMsgType,
            this.colMsgDate,
            this.colMsgCurrency,
            this.colMsgAmount,
            this.colRemitDate,
            this.colRemitCurrency,
            this.colRemitAmount});
            this.dgvCommissionRemit.ContextMenuStrip = this.contextMenuCommissionRemitMgr;
            this.dgvCommissionRemit.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommissionRemit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCommissionRemit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommissionRemit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCommissionRemit.Location = new System.Drawing.Point(0, 30);
            this.dgvCommissionRemit.MultiSelect = false;
            this.dgvCommissionRemit.Name = "dgvCommissionRemit";
            this.dgvCommissionRemit.ReadOnly = true;
            this.dgvCommissionRemit.RowTemplate.Height = 23;
            this.dgvCommissionRemit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommissionRemit.Size = new System.Drawing.Size(867, 286);
            this.dgvCommissionRemit.TabIndex = 2;
            this.dgvCommissionRemit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCommissionRemitCellDoubleClick);
            this.dgvCommissionRemit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvCommissionRemitRowPostPaint);
            // 
            // contextMenuCommissionRemitMgr
            // 
            this.contextMenuCommissionRemitMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCommissionRemitSelect,
            this.menuItemCommissionRemitDetail,
            this.toolStripSeparator,
            this.menuItemCommissionRemitDelete});
            this.contextMenuCommissionRemitMgr.Name = "contextMenuFactorMgr";
            this.contextMenuCommissionRemitMgr.Size = new System.Drawing.Size(99, 76);
            // 
            // menuItemCommissionRemitSelect
            // 
            this.menuItemCommissionRemitSelect.Name = "menuItemCommissionRemitSelect";
            this.menuItemCommissionRemitSelect.Size = new System.Drawing.Size(152, 22);
            this.menuItemCommissionRemitSelect.Text = "选定";
            this.menuItemCommissionRemitSelect.Click += new System.EventHandler(this.SelectCommissionRemit);
            // 
            // menuItemCommissionRemitDetail
            // 
            this.menuItemCommissionRemitDetail.Name = "menuItemCommissionRemitDetail";
            this.menuItemCommissionRemitDetail.Size = new System.Drawing.Size(152, 22);
            this.menuItemCommissionRemitDetail.Text = "详细";
            this.menuItemCommissionRemitDetail.Click += new System.EventHandler(this.DetailCommissionRemit);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemCommissionRemitDelete
            // 
            this.menuItemCommissionRemitDelete.Name = "menuItemCommissionRemitDelete";
            this.menuItemCommissionRemitDelete.Size = new System.Drawing.Size(152, 22);
            this.menuItemCommissionRemitDelete.Text = "删除";
            this.menuItemCommissionRemitDelete.Click += new System.EventHandler(this.DeleteCommissionRemit);
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.dateTo);
            this.panelQuery.Controls.Add(this.lblDatePicker);
            this.panelQuery.Controls.Add(this.dateFrom);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbFactorName);
            this.panelQuery.Controls.Add(this.lblFactorName);
            this.panelQuery.Controls.Add(this.tbFactorCode);
            this.panelQuery.Controls.Add(this.lblFactorCode);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(867, 30);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 3;
            // 
            // dateTo
            // 
            // 
            // 
            // 
            this.dateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTo.ButtonDropDown.Visible = true;
            this.dateTo.Location = new System.Drawing.Point(512, 5);
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
            this.dateTo.TabIndex = 17;
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            // 
            // 
            // 
            this.lblDatePicker.BackgroundStyle.Class = "";
            this.lblDatePicker.Location = new System.Drawing.Point(344, 6);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(56, 16);
            this.lblDatePicker.TabIndex = 15;
            this.lblDatePicker.Text = "消息期限";
            // 
            // dateFrom
            // 
            // 
            // 
            // 
            this.dateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateFrom.ButtonDropDown.Visible = true;
            this.dateFrom.Location = new System.Drawing.Point(406, 5);
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
            this.dateFrom.TabIndex = 16;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(665, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(71, 16);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "获得 条记录";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(618, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(41, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryCommissionRemit);
            // 
            // tbFactorName
            // 
            // 
            // 
            // 
            this.tbFactorName.Border.Class = "TextBoxBorder";
            this.tbFactorName.Location = new System.Drawing.Point(224, 5);
            this.tbFactorName.Name = "tbFactorName";
            this.tbFactorName.Size = new System.Drawing.Size(114, 20);
            this.tbFactorName.TabIndex = 7;
            // 
            // lblFactorName
            // 
            this.lblFactorName.AutoSize = true;
            // 
            // 
            // 
            this.lblFactorName.BackgroundStyle.Class = "";
            this.lblFactorName.Location = new System.Drawing.Point(169, 5);
            this.lblFactorName.Name = "lblFactorName";
            this.lblFactorName.Size = new System.Drawing.Size(56, 16);
            this.lblFactorName.TabIndex = 6;
            this.lblFactorName.Text = "机构名称";
            // 
            // tbFactorCode
            // 
            // 
            // 
            // 
            this.tbFactorCode.Border.Class = "TextBoxBorder";
            this.tbFactorCode.Location = new System.Drawing.Point(63, 5);
            this.tbFactorCode.Name = "tbFactorCode";
            this.tbFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbFactorCode.TabIndex = 5;
            // 
            // lblFactorCode
            // 
            this.lblFactorCode.AutoSize = true;
            // 
            // 
            // 
            this.lblFactorCode.BackgroundStyle.Class = "";
            this.lblFactorCode.Location = new System.Drawing.Point(5, 5);
            this.lblFactorCode.Name = "lblFactorCode";
            this.lblFactorCode.Size = new System.Drawing.Size(56, 16);
            this.lblFactorCode.TabIndex = 4;
            this.lblFactorCode.Text = "机构编号";
            // 
            // factorCodeColumn
            // 
            this.factorCodeColumn.DataPropertyName = "FactorCode";
            this.factorCodeColumn.HeaderText = "机构代码";
            this.factorCodeColumn.Name = "factorCodeColumn";
            this.factorCodeColumn.ReadOnly = true;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            this.CompanyNameColumn.HeaderText = "公司名称";
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.ReadOnly = true;
            // 
            // colBatchCount
            // 
            this.colBatchCount.DataPropertyName = "BatchCount";
            this.colBatchCount.HeaderText = "批次数";
            this.colBatchCount.Name = "colBatchCount";
            this.colBatchCount.ReadOnly = true;
            // 
            // colMsgType
            // 
            this.colMsgType.DataPropertyName = "MsgType";
            this.colMsgType.HeaderText = "消息类型";
            this.colMsgType.Name = "colMsgType";
            this.colMsgType.ReadOnly = true;
            // 
            // colMsgDate
            // 
            this.colMsgDate.DataPropertyName = "MsgDate";
            dataGridViewCellStyle2.Format = "d";
            this.colMsgDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMsgDate.HeaderText = "消息日期";
            this.colMsgDate.Name = "colMsgDate";
            this.colMsgDate.ReadOnly = true;
            // 
            // colMsgCurrency
            // 
            this.colMsgCurrency.DataPropertyName = "MsgCurrency";
            this.colMsgCurrency.HeaderText = "消息币别";
            this.colMsgCurrency.Name = "colMsgCurrency";
            this.colMsgCurrency.ReadOnly = true;
            // 
            // colMsgAmount
            // 
            this.colMsgAmount.DataPropertyName = "MsgAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colMsgAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMsgAmount.HeaderText = "消息金额";
            this.colMsgAmount.Name = "colMsgAmount";
            this.colMsgAmount.ReadOnly = true;
            // 
            // colRemitDate
            // 
            this.colRemitDate.DataPropertyName = "RemitDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colRemitDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRemitDate.HeaderText = "汇款日期";
            this.colRemitDate.Name = "colRemitDate";
            this.colRemitDate.ReadOnly = true;
            // 
            // colRemitCurrency
            // 
            this.colRemitCurrency.DataPropertyName = "RemitCurrency";
            this.colRemitCurrency.HeaderText = "汇款币别";
            this.colRemitCurrency.Name = "colRemitCurrency";
            this.colRemitCurrency.ReadOnly = true;
            // 
            // colRemitAmount
            // 
            this.colRemitAmount.DataPropertyName = "RemitAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.colRemitAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRemitAmount.HeaderText = "汇款金额";
            this.colRemitAmount.Name = "colRemitAmount";
            this.colRemitAmount.ReadOnly = true;
            // 
            // CommissionRemitMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCommissionRemit);
            this.Controls.Add(this.panelQuery);
            this.Name = "CommissionRemitMgr";
            this.Size = new System.Drawing.Size(867, 316);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissionRemit)).EndInit();
            this.contextMenuCommissionRemitMgr.ResumeLayout(false);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCommissionRemit;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private DevComponents.DotNetBar.LabelX lblFactorName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorCode;
        private DevComponents.DotNetBar.LabelX lblFactorCode;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTo;
        private DevComponents.DotNetBar.LabelX lblDatePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFrom;
        private System.Windows.Forms.ContextMenuStrip contextMenuCommissionRemitMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemCommissionRemitSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemCommissionRemitDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemCommissionRemitDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMsgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMsgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMsgCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMsgAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemitCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemitAmount;
    }
}
