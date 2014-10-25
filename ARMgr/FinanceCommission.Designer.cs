//-----------------------------------------------------------------------
// <copyright file="FinanceCommission.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceCommission
    {
		#region?Fields?(48)?

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX commissionBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput commissionDateDateTimePicker;
        private System.Windows.Forms.BindingSource batchBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.ButtonX btnAssignBatchNew;
        private DevComponents.DotNetBar.ButtonX btnAssignBatchSave;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFinanceLogs;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DevComponents.DotNetBar.PanelEx panelBatch;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalCommission;

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

            if (this._context != null)
            {
                this._context.Dispose();
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
            DevComponents.DotNetBar.LabelX commissionBatchNoLabel;
            DevComponents.DotNetBar.LabelX lblCommissionDate;
            DevComponents.DotNetBar.LabelX lblTotalCommission;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceCommission));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBatch = new DevComponents.DotNetBar.PanelEx();
            this.tbTotalCommission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAssignBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.btnAssignBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.commissionDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commissionBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvFinanceLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnpaidCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurCommissionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
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
            commissionBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            lblCommissionDate = new DevComponents.DotNetBar.LabelX();
            lblTotalCommission = new DevComponents.DotNetBar.LabelX();
            this.panelBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commissionDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // commissionBatchNoLabel
            // 
            commissionBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            commissionBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            commissionBatchNoLabel.Location = new System.Drawing.Point(6, 9);
            commissionBatchNoLabel.Name = "commissionBatchNoLabel";
            commissionBatchNoLabel.Size = new System.Drawing.Size(62, 18);
            commissionBatchNoLabel.TabIndex = 0;
            commissionBatchNoLabel.Text = "收费批号:";
            // 
            // lblCommissionDate
            // 
            lblCommissionDate.AutoSize = true;
            // 
            // 
            // 
            lblCommissionDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblCommissionDate.Location = new System.Drawing.Point(173, 9);
            lblCommissionDate.Name = "lblCommissionDate";
            lblCommissionDate.Size = new System.Drawing.Size(50, 18);
            lblCommissionDate.TabIndex = 2;
            lblCommissionDate.Text = "收费日:";
            // 
            // lblTotalCommission
            // 
            lblTotalCommission.AutoSize = true;
            // 
            // 
            // 
            lblTotalCommission.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblTotalCommission.Location = new System.Drawing.Point(513, 9);
            lblTotalCommission.Name = "lblTotalCommission";
            lblTotalCommission.Size = new System.Drawing.Size(93, 18);
            lblTotalCommission.TabIndex = 14;
            lblTotalCommission.Text = "本次手续费收入";
            // 
            // panelBatch
            // 
            this.panelBatch.AutoScroll = true;
            this.panelBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelBatch.Controls.Add(this.tbTotalCommission);
            this.panelBatch.Controls.Add(lblTotalCommission);
            this.panelBatch.Controls.Add(this.btnAssignBatchNew);
            this.panelBatch.Controls.Add(this.btnAssignBatchSave);
            this.panelBatch.Controls.Add(lblCommissionDate);
            this.panelBatch.Controls.Add(this.commissionDateDateTimePicker);
            this.panelBatch.Controls.Add(commissionBatchNoLabel);
            this.panelBatch.Controls.Add(this.commissionBatchNoTextBox);
            this.panelBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBatch.Location = new System.Drawing.Point(0, 0);
            this.panelBatch.Name = "panelBatch";
            this.panelBatch.Size = new System.Drawing.Size(1235, 37);
            this.panelBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBatch.Style.GradientAngle = 90;
            this.panelBatch.TabIndex = 0;
            // 
            // tbTotalCommission
            // 
            this.tbTotalCommission.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTotalCommission.Border.Class = "TextBoxBorder";
            this.tbTotalCommission.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalCommission.DisabledBackColor = System.Drawing.Color.White;
            this.tbTotalCommission.ForeColor = System.Drawing.Color.Black;
            this.tbTotalCommission.Location = new System.Drawing.Point(612, 8);
            this.tbTotalCommission.Name = "tbTotalCommission";
            this.tbTotalCommission.ReadOnly = true;
            this.tbTotalCommission.Size = new System.Drawing.Size(89, 21);
            this.tbTotalCommission.TabIndex = 18;
            this.tbTotalCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAssignBatchNew
            // 
            this.btnAssignBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignBatchNew.Location = new System.Drawing.Point(351, 6);
            this.btnAssignBatchNew.Name = "btnAssignBatchNew";
            this.btnAssignBatchNew.Size = new System.Drawing.Size(75, 21);
            this.btnAssignBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnAssignBatchNew.TabIndex = 7;
            this.btnAssignBatchNew.Text = "新建批次";
            this.btnAssignBatchNew.Click += new System.EventHandler(this.NewBatch);
            // 
            // btnAssignBatchSave
            // 
            this.btnAssignBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignBatchSave.Location = new System.Drawing.Point(432, 6);
            this.btnAssignBatchSave.Name = "btnAssignBatchSave";
            this.btnAssignBatchSave.Size = new System.Drawing.Size(75, 21);
            this.btnAssignBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnAssignBatchSave.TabIndex = 8;
            this.btnAssignBatchSave.Text = "保存批次";
            this.btnAssignBatchSave.Click += new System.EventHandler(this.SaveFinanceCommissionBatch);
            // 
            // commissionDateDateTimePicker
            // 
            // 
            // 
            // 
            this.commissionDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.commissionDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionDateDateTimePicker.ButtonDropDown.Visible = true;
            this.commissionDateDateTimePicker.ButtonFreeText.Checked = true;
            this.commissionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "RevenueDate", true));
            this.commissionDateDateTimePicker.FreeTextEntryMode = true;
            this.commissionDateDateTimePicker.IsPopupCalendarOpen = false;
            this.commissionDateDateTimePicker.Location = new System.Drawing.Point(229, 6);
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.commissionDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.commissionDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.commissionDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.commissionDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.commissionDateDateTimePicker.Name = "commissionDateDateTimePicker";
            this.commissionDateDateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.commissionDateDateTimePicker.TabIndex = 3;
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.RevenueBatch);
            // 
            // commissionBatchNoTextBox
            // 
            this.commissionBatchNoTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.commissionBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.commissionBatchNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commissionBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RevenueBatchID", true));
            this.commissionBatchNoTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.commissionBatchNoTextBox.ForeColor = System.Drawing.Color.Black;
            this.commissionBatchNoTextBox.Location = new System.Drawing.Point(74, 6);
            this.commissionBatchNoTextBox.Name = "commissionBatchNoTextBox";
            this.commissionBatchNoTextBox.ReadOnly = true;
            this.commissionBatchNoTextBox.Size = new System.Drawing.Size(93, 21);
            this.commissionBatchNoTextBox.TabIndex = 1;
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 37);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(1235, 25);
            this.invoiceBindingNavigator.TabIndex = 1;
            this.invoiceBindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Invoice);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvFinanceLogs
            // 
            this.dgvFinanceLogs.AutoGenerateColumns = false;
            this.dgvFinanceLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colInvoiceNo,
            this.colInvoiceAmount,
            this.colAssignAmount,
            this.colInvoiceDate,
            this.colDueDate,
            this.colFinanceAmount,
            this.colFinanceDate,
            this.colPaidCommission,
            this.colUnpaidCommission,
            this.colCurCommissionValue});
            this.dgvFinanceLogs.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinanceLogs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFinanceLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinanceLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFinanceLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFinanceLogs.Location = new System.Drawing.Point(0, 62);
            this.dgvFinanceLogs.Name = "dgvFinanceLogs";
            this.dgvFinanceLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFinanceLogs.Size = new System.Drawing.Size(1235, 487);
            this.dgvFinanceLogs.TabIndex = 0;
            this.dgvFinanceLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellContentClick);
            this.dgvFinanceLogs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvInvoicesCellFormatting);
            this.dgvFinanceLogs.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DgvInvoicesCellParsing);
            this.dgvFinanceLogs.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvInvoicesCellValidating);
            this.dgvFinanceLogs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvInvoicesRowHeaderMouseDoubleClick);
            // 
            // colCheckBox
            // 
            this.colCheckBox.Frozen = true;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.Width = 20;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.DataPropertyName = "InvoiceAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.colInvoiceAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colInvoiceAmount.HeaderText = "票面金额";
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            this.colInvoiceDate.HeaderText = "发票日";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "到期日";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            // 
            // colFinanceDate
            // 
            this.colFinanceDate.DataPropertyName = "FinanceDate";
            this.colFinanceDate.HeaderText = "融资日";
            this.colFinanceDate.Name = "colFinanceDate";
            // 
            // colPaidCommission
            // 
            this.colPaidCommission.DataPropertyName = "PaidCommission";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.colPaidCommission.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPaidCommission.HeaderText = "已收手续费";
            this.colPaidCommission.Name = "colPaidCommission";
            // 
            // colUnpaidCommission
            // 
            this.colUnpaidCommission.DataPropertyName = "UnpaidCommission";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.colUnpaidCommission.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUnpaidCommission.HeaderText = "未收手续费";
            this.colUnpaidCommission.Name = "colUnpaidCommission";
            // 
            // colCurCommissionValue
            // 
            this.colCurCommissionValue.DataPropertyName = "CurCommissionValue";
            dataGridViewCellStyle6.Format = "N2";
            this.colCurCommissionValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCurCommissionValue.HeaderText = "本次收费";
            this.colCurCommissionValue.Name = "colCurCommissionValue";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "发票号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceAmount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "票面金额";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.HeaderText = "转让金额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InvoiceDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "发票日";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "到期日";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn6.HeaderText = "融资金额";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FinanceDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "融资日";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PaidCommission";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn8.HeaderText = "已收手续费";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UnpaidCommission";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn9.HeaderText = "未收手续费";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CurCommissionValue";
            dataGridViewCellStyle13.Format = "N2";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn10.HeaderText = "本次收费";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FinanceCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFinanceLogs);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelBatch);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FinanceCommission";
            this.Size = new System.Drawing.Size(1235, 549);
            this.panelBatch.ResumeLayout(false);
            this.panelBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commissionDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnpaidCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurCommissionValue;
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





    }
}
