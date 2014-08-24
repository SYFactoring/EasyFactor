//-----------------------------------------------------------------------
// <copyright file="InvoiceAssign.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssign
    {
		#region?Fields?(48)?

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX assignBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput assignDateDateTimePicker;
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
        private DevComponents.DotNetBar.ButtonX btnAssignBatchExport;
        private DevComponents.DotNetBar.ButtonX btnAssignBatchImport;
        private DevComponents.DotNetBar.ButtonX btnAssignBatchNew;
        private DevComponents.DotNetBar.ButtonX btnAssignBatchSave;
        private DevComponents.DotNetBar.ButtonX btnAssignBatchSelect;
        private System.Windows.Forms.ContextMenuStrip cmuInvoiceAssign;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DevComponents.DotNetBar.Controls.CheckBoxX isRefinanceCheckBox;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemFlaw;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private DevComponents.DotNetBar.PanelEx panelAssignBatch;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalAssign;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalCommission;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalHandfee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

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
            DevComponents.DotNetBar.LabelX assignBatchNoLabel;
            DevComponents.DotNetBar.LabelX assignDateLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX lblTotalAssign;
            DevComponents.DotNetBar.LabelX lblAssignNumber;
            DevComponents.DotNetBar.LabelX lblTotalCommission;
            DevComponents.DotNetBar.LabelX lblTotalHandfee;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceAssign));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            DevComponents.DotNetBar.LabelX lblWhoPayFee;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAssignBatch = new DevComponents.DotNetBar.PanelEx();
            this.tbTotalHandfee = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTotalCommission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbAssignNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTotalAssign = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAssignBatchImport = new DevComponents.DotNetBar.ButtonX();
            this.btnAssignBatchExport = new DevComponents.DotNetBar.ButtonX();
            this.btnAssignBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnAssignBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.btnAssignBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.isRefinanceCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.assignDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.assignBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmuInvoiceAssign = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFlaw = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsFlaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cbWhoPayFee = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            assignBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            assignDateLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            lblTotalAssign = new DevComponents.DotNetBar.LabelX();
            lblAssignNumber = new DevComponents.DotNetBar.LabelX();
            lblTotalCommission = new DevComponents.DotNetBar.LabelX();
            lblTotalHandfee = new DevComponents.DotNetBar.LabelX();
            lblWhoPayFee = new DevComponents.DotNetBar.LabelX();
            this.panelAssignBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateDateTimePicker)).BeginInit();
            this.cmuInvoiceAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignBatchNoLabel
            // 
            assignBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            assignBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignBatchNoLabel.Location = new System.Drawing.Point(13, 9);
            assignBatchNoLabel.Name = "assignBatchNoLabel";
            assignBatchNoLabel.Size = new System.Drawing.Size(62, 18);
            assignBatchNoLabel.TabIndex = 0;
            assignBatchNoLabel.Text = "转让批号:";
            // 
            // assignDateLabel
            // 
            assignDateLabel.AutoSize = true;
            // 
            // 
            // 
            assignDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignDateLabel.Location = new System.Drawing.Point(173, 9);
            assignDateLabel.Name = "assignDateLabel";
            assignDateLabel.Size = new System.Drawing.Size(50, 18);
            assignDateLabel.TabIndex = 2;
            assignDateLabel.Text = "转让日:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            commentLabel.Location = new System.Drawing.Point(38, 33);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(37, 18);
            commentLabel.TabIndex = 5;
            commentLabel.Text = "备注:";
            // 
            // lblTotalAssign
            // 
            lblTotalAssign.AutoSize = true;
            // 
            // 
            // 
            lblTotalAssign.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblTotalAssign.Location = new System.Drawing.Point(811, 3);
            lblTotalAssign.Name = "lblTotalAssign";
            lblTotalAssign.Size = new System.Drawing.Size(93, 18);
            lblTotalAssign.TabIndex = 12;
            lblTotalAssign.Text = "本次转让总金额";
            // 
            // lblAssignNumber
            // 
            lblAssignNumber.AutoSize = true;
            // 
            // 
            // 
            lblAssignNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblAssignNumber.Location = new System.Drawing.Point(811, 20);
            lblAssignNumber.Name = "lblAssignNumber";
            lblAssignNumber.Size = new System.Drawing.Size(93, 18);
            lblAssignNumber.TabIndex = 13;
            lblAssignNumber.Text = "本次转让总笔数";
            // 
            // lblTotalCommission
            // 
            lblTotalCommission.AutoSize = true;
            // 
            // 
            // 
            lblTotalCommission.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblTotalCommission.Location = new System.Drawing.Point(811, 38);
            lblTotalCommission.Name = "lblTotalCommission";
            lblTotalCommission.Size = new System.Drawing.Size(93, 18);
            lblTotalCommission.TabIndex = 14;
            lblTotalCommission.Text = "本次手续费收入";
            // 
            // lblTotalHandfee
            // 
            lblTotalHandfee.AutoSize = true;
            // 
            // 
            // 
            lblTotalHandfee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblTotalHandfee.Location = new System.Drawing.Point(786, 55);
            lblTotalHandfee.Name = "lblTotalHandfee";
            lblTotalHandfee.Size = new System.Drawing.Size(118, 18);
            lblTotalHandfee.TabIndex = 15;
            lblTotalHandfee.Text = "本次单据处理费收入";
            // 
            // panelAssignBatch
            // 
            this.panelAssignBatch.AutoScroll = true;
            this.panelAssignBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelAssignBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelAssignBatch.Controls.Add(lblWhoPayFee);
            this.panelAssignBatch.Controls.Add(this.cbWhoPayFee);
            this.panelAssignBatch.Controls.Add(this.tbTotalHandfee);
            this.panelAssignBatch.Controls.Add(this.tbTotalCommission);
            this.panelAssignBatch.Controls.Add(this.tbAssignNumber);
            this.panelAssignBatch.Controls.Add(this.tbTotalAssign);
            this.panelAssignBatch.Controls.Add(lblTotalHandfee);
            this.panelAssignBatch.Controls.Add(lblTotalCommission);
            this.panelAssignBatch.Controls.Add(lblAssignNumber);
            this.panelAssignBatch.Controls.Add(lblTotalAssign);
            this.panelAssignBatch.Controls.Add(this.btnAssignBatchImport);
            this.panelAssignBatch.Controls.Add(this.btnAssignBatchExport);
            this.panelAssignBatch.Controls.Add(this.btnAssignBatchSelect);
            this.panelAssignBatch.Controls.Add(this.btnAssignBatchNew);
            this.panelAssignBatch.Controls.Add(this.btnAssignBatchSave);
            this.panelAssignBatch.Controls.Add(commentLabel);
            this.panelAssignBatch.Controls.Add(this.commentTextBox);
            this.panelAssignBatch.Controls.Add(this.isRefinanceCheckBox);
            this.panelAssignBatch.Controls.Add(assignDateLabel);
            this.panelAssignBatch.Controls.Add(this.assignDateDateTimePicker);
            this.panelAssignBatch.Controls.Add(assignBatchNoLabel);
            this.panelAssignBatch.Controls.Add(this.assignBatchNoTextBox);
            this.panelAssignBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelAssignBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAssignBatch.Location = new System.Drawing.Point(0, 0);
            this.panelAssignBatch.Name = "panelAssignBatch";
            this.panelAssignBatch.Size = new System.Drawing.Size(1235, 75);
            this.panelAssignBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelAssignBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelAssignBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelAssignBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelAssignBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelAssignBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelAssignBatch.Style.GradientAngle = 90;
            this.panelAssignBatch.TabIndex = 0;
            // 
            // tbTotalHandfee
            // 
            // 
            // 
            // 
            this.tbTotalHandfee.Border.Class = "TextBoxBorder";
            this.tbTotalHandfee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalHandfee.Location = new System.Drawing.Point(910, 54);
            this.tbTotalHandfee.Name = "tbTotalHandfee";
            this.tbTotalHandfee.ReadOnly = true;
            this.tbTotalHandfee.Size = new System.Drawing.Size(89, 21);
            this.tbTotalHandfee.TabIndex = 19;
            // 
            // tbTotalCommission
            // 
            // 
            // 
            // 
            this.tbTotalCommission.Border.Class = "TextBoxBorder";
            this.tbTotalCommission.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalCommission.Location = new System.Drawing.Point(910, 37);
            this.tbTotalCommission.Name = "tbTotalCommission";
            this.tbTotalCommission.ReadOnly = true;
            this.tbTotalCommission.Size = new System.Drawing.Size(89, 21);
            this.tbTotalCommission.TabIndex = 18;
            // 
            // tbAssignNumber
            // 
            // 
            // 
            // 
            this.tbAssignNumber.Border.Class = "TextBoxBorder";
            this.tbAssignNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAssignNumber.Location = new System.Drawing.Point(910, 19);
            this.tbAssignNumber.Name = "tbAssignNumber";
            this.tbAssignNumber.ReadOnly = true;
            this.tbAssignNumber.Size = new System.Drawing.Size(89, 21);
            this.tbAssignNumber.TabIndex = 17;
            // 
            // tbTotalAssign
            // 
            // 
            // 
            // 
            this.tbTotalAssign.Border.Class = "TextBoxBorder";
            this.tbTotalAssign.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalAssign.Location = new System.Drawing.Point(910, 2);
            this.tbTotalAssign.Name = "tbTotalAssign";
            this.tbTotalAssign.ReadOnly = true;
            this.tbTotalAssign.Size = new System.Drawing.Size(89, 21);
            this.tbTotalAssign.TabIndex = 16;
            // 
            // btnAssignBatchImport
            // 
            this.btnAssignBatchImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignBatchImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignBatchImport.Location = new System.Drawing.Point(602, 32);
            this.btnAssignBatchImport.Name = "btnAssignBatchImport";
            this.btnAssignBatchImport.Size = new System.Drawing.Size(75, 21);
            this.btnAssignBatchImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnAssignBatchImport.TabIndex = 11;
            this.btnAssignBatchImport.Text = "导入批次";
            this.btnAssignBatchImport.Click += new System.EventHandler(this.ImportAssignBatch);
            // 
            // btnAssignBatchExport
            // 
            this.btnAssignBatchExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignBatchExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignBatchExport.Location = new System.Drawing.Point(521, 32);
            this.btnAssignBatchExport.Name = "btnAssignBatchExport";
            this.btnAssignBatchExport.Size = new System.Drawing.Size(75, 21);
            this.btnAssignBatchExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnAssignBatchExport.TabIndex = 10;
            this.btnAssignBatchExport.Text = "导出批次";
            this.btnAssignBatchExport.Click += new System.EventHandler(this.ExportAssignBatch);
            // 
            // btnAssignBatchSelect
            // 
            this.btnAssignBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignBatchSelect.Location = new System.Drawing.Point(683, 6);
            this.btnAssignBatchSelect.Name = "btnAssignBatchSelect";
            this.btnAssignBatchSelect.Size = new System.Drawing.Size(75, 21);
            this.btnAssignBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnAssignBatchSelect.TabIndex = 9;
            this.btnAssignBatchSelect.Text = "选择批次";
            this.btnAssignBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // btnAssignBatchNew
            // 
            this.btnAssignBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignBatchNew.Location = new System.Drawing.Point(521, 6);
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
            this.btnAssignBatchSave.Location = new System.Drawing.Point(602, 6);
            this.btnAssignBatchSave.Name = "btnAssignBatchSave";
            this.btnAssignBatchSave.Size = new System.Drawing.Size(75, 21);
            this.btnAssignBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnAssignBatchSave.TabIndex = 8;
            this.btnAssignBatchSave.Text = "保存批次";
            this.btnAssignBatchSave.Click += new System.EventHandler(this.SaveAssignBatch);
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(74, 30);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentTextBox.Size = new System.Drawing.Size(323, 33);
            this.commentTextBox.TabIndex = 6;
            // 
            // isRefinanceCheckBox
            // 
            this.isRefinanceCheckBox.AutoSize = true;
            // 
            // 
            // 
            this.isRefinanceCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.isRefinanceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.batchBindingSource, "IsRefinance", true));
            this.isRefinanceCheckBox.Location = new System.Drawing.Point(403, 33);
            this.isRefinanceCheckBox.Name = "isRefinanceCheckBox";
            this.isRefinanceCheckBox.Size = new System.Drawing.Size(101, 18);
            this.isRefinanceCheckBox.TabIndex = 4;
            this.isRefinanceCheckBox.Text = "可否多次融资";
            // 
            // assignDateDateTimePicker
            // 
            // 
            // 
            // 
            this.assignDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.assignDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateDateTimePicker.ButtonDropDown.Visible = true;
            this.assignDateDateTimePicker.ButtonFreeText.Checked = true;
            this.assignDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "AssignDate", true));
            this.assignDateDateTimePicker.FreeTextEntryMode = true;
            this.assignDateDateTimePicker.IsPopupCalendarOpen = false;
            this.assignDateDateTimePicker.Location = new System.Drawing.Point(217, 6);
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.assignDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.assignDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.assignDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.assignDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.assignDateDateTimePicker.Name = "assignDateDateTimePicker";
            this.assignDateDateTimePicker.Size = new System.Drawing.Size(92, 21);
            this.assignDateDateTimePicker.TabIndex = 3;
            this.superValidator.SetValidator1(this.assignDateDateTimePicker, this.requiredFieldValidator1);
            // 
            // assignBatchNoTextBox
            // 
            // 
            // 
            // 
            this.assignBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.assignBatchNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "AssignBatchNo", true));
            this.assignBatchNoTextBox.Location = new System.Drawing.Point(74, 6);
            this.assignBatchNoTextBox.Name = "assignBatchNoTextBox";
            this.assignBatchNoTextBox.ReadOnly = true;
            this.assignBatchNoTextBox.Size = new System.Drawing.Size(93, 21);
            this.assignBatchNoTextBox.TabIndex = 1;
            // 
            // cmuInvoiceAssign
            // 
            this.cmuInvoiceAssign.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCDADetail,
            this.menuItemCaseDetail,
            this.toolStripSeparator,
            this.menuItemFlaw});
            this.cmuInvoiceAssign.Name = "cmuInvoiceAssign";
            this.cmuInvoiceAssign.Size = new System.Drawing.Size(185, 98);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(184, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(184, 22);
            this.menuItemCDADetail.Text = "额度通知书详细信息";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(184, 22);
            this.menuItemCaseDetail.Text = "案子详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // menuItemFlaw
            // 
            this.menuItemFlaw.Name = "menuItemFlaw";
            this.menuItemFlaw.Size = new System.Drawing.Size(184, 22);
            this.menuItemFlaw.Text = "瑕疵处理";
            this.menuItemFlaw.Click += new System.EventHandler(this.Flaw);
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
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 75);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(1235, 25);
            this.invoiceBindingNavigator.TabIndex = 1;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
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
            // dgvInvoices
            // 
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colInvoiceAmount,
            this.colAssignAmount,
            this.colInvoiceDate,
            this.colDueDate,
            this.colCommission,
            this.colIsFlaw,
            this.colComment});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoiceAssign;
            this.dgvInvoices.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 100);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1235, 449);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoicesCellClick);
            this.dgvInvoices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvInvoicesCellFormatting);
            this.dgvInvoices.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DgvInvoicesCellParsing);
            this.dgvInvoices.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvInvoicesCellValidating);
            this.dgvInvoices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoicesCellValueChanged);
            this.dgvInvoices.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvInvoicesRowHeaderMouseDoubleClick);
            // 
            // colCommission
            // 
            this.colCommission.DataPropertyName = "Commission";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colCommission.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCommission.HeaderText = "手续费";
            this.colCommission.Name = "colCommission";
            // 
            // colIsFlaw
            // 
            this.colIsFlaw.DataPropertyName = "IsFlaw";
            this.colIsFlaw.HeaderText = "是否瑕疵";
            this.colIsFlaw.Name = "colIsFlaw";
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // cbWhoPayFee
            // 
            this.cbWhoPayFee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "WhoPayFee", true));
            this.cbWhoPayFee.DisplayMember = "Text";
            this.cbWhoPayFee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbWhoPayFee.FormattingEnabled = true;
            this.cbWhoPayFee.ItemHeight = 14;
            this.cbWhoPayFee.Location = new System.Drawing.Point(427, 6);
            this.cbWhoPayFee.Name = "cbWhoPayFee";
            this.cbWhoPayFee.Size = new System.Drawing.Size(77, 20);
            this.cbWhoPayFee.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbWhoPayFee.TabIndex = 20;
            // 
            // lblWhoPayFee
            // 
            lblWhoPayFee.AutoSize = true;
            // 
            // 
            // 
            lblWhoPayFee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblWhoPayFee.Location = new System.Drawing.Point(356, 9);
            lblWhoPayFee.Name = "lblWhoPayFee";
            lblWhoPayFee.Size = new System.Drawing.Size(62, 18);
            lblWhoPayFee.TabIndex = 21;
            lblWhoPayFee.Text = "保理费由:";
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Invoice);
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceAssignBatch);
            // 
            // InvoiceAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelAssignBatch);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceAssign";
            this.Size = new System.Drawing.Size(1235, 549);
            this.panelAssignBatch.ResumeLayout(false);
            this.panelAssignBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateDateTimePicker)).EndInit();
            this.cmuInvoiceAssign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsFlaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbWhoPayFee;
    }
}
