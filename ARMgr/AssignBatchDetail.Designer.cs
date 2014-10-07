//-----------------------------------------------------------------------
// <copyright file="AssignBatchDetail.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AssignBatchDetail
    {
		#region?Fields?(23)?

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX assignBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput assignDateDateTimePicker;
        private System.Windows.Forms.BindingSource batchBindingSource;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX caseCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX createUserNameTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diInputDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.CheckBoxX isRefinanceCheckBox;
        private DevComponents.DotNetBar.TabControlPanel panelBatch;
        private DevComponents.DotNetBar.TabControlPanel panelInvoices;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemBatch;
        private DevComponents.DotNetBar.TabItem tabItemInvoices;

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



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.LabelX caseCodeLabel;
            DevComponents.DotNetBar.LabelX assignBatchNoLabel;
            DevComponents.DotNetBar.LabelX assignDateLabel;
            DevComponents.DotNetBar.LabelX createUserNameLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX lblInputDate;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignBatchDetail));
            DevComponents.DotNetBar.LabelX lblWhoPayFee;
            DevComponents.DotNetBar.LabelX lblCheckStatus;
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.panelBatch = new DevComponents.DotNetBar.TabControlPanel();
            this.isSendMsgCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diInputDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.createUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.isRefinanceCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.assignDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.assignBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.caseCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemBatch = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelCreditNote = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemCreditNote = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelInvoices = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemInvoices = new DevComponents.DotNetBar.TabItem(this.components);
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.tbWhoPayFee = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCheckStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            caseCodeLabel = new DevComponents.DotNetBar.LabelX();
            assignBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            assignDateLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            lblInputDate = new DevComponents.DotNetBar.LabelX();
            lblWhoPayFee = new DevComponents.DotNetBar.LabelX();
            lblCheckStatus = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.panelBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInputDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // caseCodeLabel
            // 
            caseCodeLabel.AutoSize = true;
            caseCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            caseCodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            caseCodeLabel.Location = new System.Drawing.Point(50, 6);
            caseCodeLabel.Name = "caseCodeLabel";
            caseCodeLabel.Size = new System.Drawing.Size(62, 18);
            caseCodeLabel.TabIndex = 0;
            caseCodeLabel.Text = "案件编号:";
            // 
            // assignBatchNoLabel
            // 
            assignBatchNoLabel.AutoSize = true;
            assignBatchNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignBatchNoLabel.Location = new System.Drawing.Point(50, 30);
            assignBatchNoLabel.Name = "assignBatchNoLabel";
            assignBatchNoLabel.Size = new System.Drawing.Size(62, 18);
            assignBatchNoLabel.TabIndex = 2;
            assignBatchNoLabel.Text = "转让批号:";
            // 
            // assignDateLabel
            // 
            assignDateLabel.AutoSize = true;
            assignDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignDateLabel.Location = new System.Drawing.Point(62, 52);
            assignDateLabel.Name = "assignDateLabel";
            assignDateLabel.Size = new System.Drawing.Size(50, 18);
            assignDateLabel.TabIndex = 4;
            assignDateLabel.Text = "转让日:";
            // 
            // createUserNameLabel
            // 
            createUserNameLabel.AutoSize = true;
            createUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            createUserNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            createUserNameLabel.Location = new System.Drawing.Point(240, 99);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(50, 18);
            createUserNameLabel.TabIndex = 8;
            createUserNameLabel.Text = "经办人:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            commentLabel.Location = new System.Drawing.Point(74, 146);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(37, 18);
            commentLabel.TabIndex = 18;
            commentLabel.Text = "备注:";
            // 
            // lblInputDate
            // 
            lblInputDate.AutoSize = true;
            lblInputDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblInputDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblInputDate.Location = new System.Drawing.Point(218, 52);
            lblInputDate.Name = "lblInputDate";
            lblInputDate.Size = new System.Drawing.Size(50, 18);
            lblInputDate.TabIndex = 23;
            lblInputDate.Text = "录入日:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.panelBatch);
            this.tabControl.Controls.Add(this.panelCreditNote);
            this.tabControl.Controls.Add(this.panelInvoices);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(394, 269);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemBatch);
            this.tabControl.Tabs.Add(this.tabItemInvoices);
            this.tabControl.Tabs.Add(this.tabItemCreditNote);
            // 
            // panelBatch
            // 
            this.panelBatch.AutoScroll = true;
            this.panelBatch.Controls.Add(this.tbCheckStatus);
            this.panelBatch.Controls.Add(lblCheckStatus);
            this.panelBatch.Controls.Add(this.tbWhoPayFee);
            this.panelBatch.Controls.Add(lblWhoPayFee);
            this.panelBatch.Controls.Add(this.isSendMsgCheckBox);
            this.panelBatch.Controls.Add(lblInputDate);
            this.panelBatch.Controls.Add(this.diInputDate);
            this.panelBatch.Controls.Add(this.btnSave);
            this.panelBatch.Controls.Add(this.btnUpdate);
            this.panelBatch.Controls.Add(commentLabel);
            this.panelBatch.Controls.Add(this.commentTextBox);
            this.panelBatch.Controls.Add(createUserNameLabel);
            this.panelBatch.Controls.Add(this.createUserNameTextBox);
            this.panelBatch.Controls.Add(this.isRefinanceCheckBox);
            this.panelBatch.Controls.Add(assignDateLabel);
            this.panelBatch.Controls.Add(this.assignDateDateTimePicker);
            this.panelBatch.Controls.Add(assignBatchNoLabel);
            this.panelBatch.Controls.Add(this.assignBatchNoTextBox);
            this.panelBatch.Controls.Add(caseCodeLabel);
            this.panelBatch.Controls.Add(this.caseCodeTextBox);
            this.panelBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBatch.Location = new System.Drawing.Point(0, 26);
            this.panelBatch.Name = "panelBatch";
            this.panelBatch.Padding = new System.Windows.Forms.Padding(1);
            this.panelBatch.Size = new System.Drawing.Size(394, 243);
            this.panelBatch.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelBatch.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBatch.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.panelBatch.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.panelBatch.Style.GradientAngle = 90;
            this.panelBatch.TabIndex = 1;
            this.panelBatch.TabItem = this.tabItemBatch;
            // 
            // isSendMsgCheckBox
            // 
            this.isSendMsgCheckBox.AutoSize = true;
            this.isSendMsgCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isSendMsgCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.isSendMsgCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.batchBindingSource, "IsSendMsg", true));
            this.isSendMsgCheckBox.Location = new System.Drawing.Point(270, 78);
            this.isSendMsgCheckBox.Name = "isSendMsgCheckBox";
            this.isSendMsgCheckBox.Size = new System.Drawing.Size(101, 18);
            this.isSendMsgCheckBox.TabIndex = 25;
            this.isSendMsgCheckBox.Text = "是否已发报文";
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceAssignBatch);
            // 
            // diInputDate
            // 
            // 
            // 
            // 
            this.diInputDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diInputDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diInputDate.ButtonDropDown.Visible = true;
            this.diInputDate.ButtonFreeText.Checked = true;
            this.diInputDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "InputDate", true));
            this.diInputDate.FreeTextEntryMode = true;
            this.diInputDate.IsPopupCalendarOpen = false;
            this.diInputDate.Location = new System.Drawing.Point(271, 50);
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diInputDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diInputDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diInputDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.diInputDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diInputDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diInputDate.MonthCalendar.TodayButtonVisible = true;
            this.diInputDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diInputDate.Name = "diInputDate";
            this.diInputDate.Size = new System.Drawing.Size(100, 21);
            this.diInputDate.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(202, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(115, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "编辑";
            this.btnUpdate.Click += new System.EventHandler(this.UpdateBatch);
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(114, 146);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(256, 60);
            this.commentTextBox.TabIndex = 19;
            // 
            // createUserNameTextBox
            // 
            // 
            // 
            // 
            this.createUserNameTextBox.Border.Class = "TextBoxBorder";
            this.createUserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(296, 97);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.ReadOnly = true;
            this.createUserNameTextBox.Size = new System.Drawing.Size(75, 21);
            this.createUserNameTextBox.TabIndex = 9;
            // 
            // isRefinanceCheckBox
            // 
            this.isRefinanceCheckBox.AutoSize = true;
            this.isRefinanceCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isRefinanceCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.isRefinanceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.batchBindingSource, "IsRefinance", true));
            this.isRefinanceCheckBox.Location = new System.Drawing.Point(114, 77);
            this.isRefinanceCheckBox.Name = "isRefinanceCheckBox";
            this.isRefinanceCheckBox.Size = new System.Drawing.Size(101, 18);
            this.isRefinanceCheckBox.TabIndex = 7;
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
            this.assignDateDateTimePicker.Location = new System.Drawing.Point(115, 50);
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
            this.assignDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.assignDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.assignDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.assignDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.assignDateDateTimePicker.Name = "assignDateDateTimePicker";
            this.assignDateDateTimePicker.Size = new System.Drawing.Size(100, 21);
            this.assignDateDateTimePicker.TabIndex = 5;
            // 
            // assignBatchNoTextBox
            // 
            // 
            // 
            // 
            this.assignBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.assignBatchNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "AssignBatchNo", true));
            this.assignBatchNoTextBox.Location = new System.Drawing.Point(115, 28);
            this.assignBatchNoTextBox.Name = "assignBatchNoTextBox";
            this.assignBatchNoTextBox.Size = new System.Drawing.Size(162, 21);
            this.assignBatchNoTextBox.TabIndex = 3;
            // 
            // caseCodeTextBox
            // 
            // 
            // 
            // 
            this.caseCodeTextBox.Border.Class = "TextBoxBorder";
            this.caseCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.caseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CaseCode", true));
            this.caseCodeTextBox.Location = new System.Drawing.Point(115, 6);
            this.caseCodeTextBox.Name = "caseCodeTextBox";
            this.caseCodeTextBox.Size = new System.Drawing.Size(162, 21);
            this.caseCodeTextBox.TabIndex = 1;
            this.caseCodeTextBox.DoubleClick += new System.EventHandler(this.DetailCase);
            // 
            // tabItemBatch
            // 
            this.tabItemBatch.AttachedControl = this.panelBatch;
            this.tabItemBatch.Name = "tabItemBatch";
            this.tabItemBatch.Text = "批次";
            // 
            // panelCreditNote
            // 
            this.panelCreditNote.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelCreditNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreditNote.Location = new System.Drawing.Point(0, 26);
            this.panelCreditNote.Name = "panelCreditNote";
            this.panelCreditNote.Padding = new System.Windows.Forms.Padding(1);
            this.panelCreditNote.Size = new System.Drawing.Size(394, 243);
            this.panelCreditNote.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelCreditNote.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelCreditNote.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCreditNote.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.panelCreditNote.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.panelCreditNote.Style.GradientAngle = 90;
            this.panelCreditNote.TabIndex = 3;
            this.panelCreditNote.TabItem = this.tabItemCreditNote;
            // 
            // tabItemCreditNote
            // 
            this.tabItemCreditNote.AttachedControl = this.panelCreditNote;
            this.tabItemCreditNote.Name = "tabItemCreditNote";
            this.tabItemCreditNote.Text = "贷项通知";
            // 
            // panelInvoices
            // 
            this.panelInvoices.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoices.Location = new System.Drawing.Point(0, 26);
            this.panelInvoices.Name = "panelInvoices";
            this.panelInvoices.Padding = new System.Windows.Forms.Padding(1);
            this.panelInvoices.Size = new System.Drawing.Size(394, 243);
            this.panelInvoices.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelInvoices.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelInvoices.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelInvoices.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.panelInvoices.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.panelInvoices.Style.GradientAngle = 90;
            this.panelInvoices.TabIndex = 2;
            this.panelInvoices.TabItem = this.tabItemInvoices;
            // 
            // tabItemInvoices
            // 
            this.tabItemInvoices.AttachedControl = this.panelInvoices;
            this.tabItemInvoices.Name = "tabItemInvoices";
            this.tabItemInvoices.Text = "发票";
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
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
            // lblWhoPayFee
            // 
            lblWhoPayFee.AutoSize = true;
            lblWhoPayFee.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblWhoPayFee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblWhoPayFee.Location = new System.Drawing.Point(50, 99);
            lblWhoPayFee.Name = "lblWhoPayFee";
            lblWhoPayFee.Size = new System.Drawing.Size(62, 18);
            lblWhoPayFee.TabIndex = 27;
            lblWhoPayFee.Text = "保理费由:";
            // 
            // tbWhoPayFee
            // 
            // 
            // 
            // 
            this.tbWhoPayFee.Border.Class = "TextBoxBorder";
            this.tbWhoPayFee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbWhoPayFee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "WhoPayFee", true));
            this.tbWhoPayFee.Location = new System.Drawing.Point(115, 96);
            this.tbWhoPayFee.Name = "tbWhoPayFee";
            this.tbWhoPayFee.ReadOnly = true;
            this.tbWhoPayFee.Size = new System.Drawing.Size(100, 21);
            this.tbWhoPayFee.TabIndex = 28;
            // 
            // tbCheckStatus
            // 
            // 
            // 
            // 
            this.tbCheckStatus.Border.Class = "TextBoxBorder";
            this.tbCheckStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCheckStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CheckStatus", true));
            this.tbCheckStatus.Location = new System.Drawing.Point(115, 119);
            this.tbCheckStatus.Name = "tbCheckStatus";
            this.tbCheckStatus.ReadOnly = true;
            this.tbCheckStatus.Size = new System.Drawing.Size(100, 21);
            this.tbCheckStatus.TabIndex = 30;
            // 
            // lblCheckStatus
            // 
            lblCheckStatus.AutoSize = true;
            lblCheckStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCheckStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblCheckStatus.Location = new System.Drawing.Point(50, 122);
            lblCheckStatus.Name = "lblCheckStatus";
            lblCheckStatus.Size = new System.Drawing.Size(62, 18);
            lblCheckStatus.TabIndex = 29;
            lblCheckStatus.Text = "审核状态:";
            // 
            // AssignBatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 269);
            this.Controls.Add(this.tabControl);
            this.Name = "AssignBatchDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "转让批次信息";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.panelBatch.ResumeLayout(false);
            this.panelBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInputDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.DotNetBar.TabControlPanel panelCreditNote;
        private DevComponents.DotNetBar.TabItem tabItemCreditNote;
        private DevComponents.DotNetBar.Controls.CheckBoxX isSendMsgCheckBox;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWhoPayFee;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCheckStatus;
    }
}