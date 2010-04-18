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
        #region Fields (22)
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX assignBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput assignDateDateTimePicker;
        private System.Windows.Forms.BindingSource batchBindingSource;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX caseCodeTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput checkDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.ComboBoxEx checkStatusComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX checkUserNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX createUserNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.CheckBoxX isCreateMsgCheckBox;
        private DevComponents.DotNetBar.TabControlPanel panelBatch;
        private DevComponents.DotNetBar.TabControlPanel panelInvoices;
        private DevComponents.DotNetBar.Controls.TextBoxX rejectReasonTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemBatch;
        private DevComponents.DotNetBar.TabItem tabItemInvoices;

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
            DevComponents.DotNetBar.LabelX checkStatusLabel;
            DevComponents.DotNetBar.LabelX rejectReasonLabel;
            DevComponents.DotNetBar.LabelX checkDateLabel;
            DevComponents.DotNetBar.LabelX checkUserNameLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignBatchDetail));
            DevComponents.DotNetBar.LabelX lblInputDate;
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.panelBatch = new DevComponents.DotNetBar.TabControlPanel();
            this.checkStatusComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.rejectReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.createUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.isCreateMsgCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.assignDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.assignBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.caseCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemBatch = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelInvoices = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemInvoices = new DevComponents.DotNetBar.TabItem(this.components);
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.diInputDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            caseCodeLabel = new DevComponents.DotNetBar.LabelX();
            assignBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            assignDateLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            checkStatusLabel = new DevComponents.DotNetBar.LabelX();
            rejectReasonLabel = new DevComponents.DotNetBar.LabelX();
            checkDateLabel = new DevComponents.DotNetBar.LabelX();
            checkUserNameLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            lblInputDate = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.panelBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInputDate)).BeginInit();
            this.SuspendLayout();
            // 
            // caseCodeLabel
            // 
            caseCodeLabel.AutoSize = true;
            caseCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            caseCodeLabel.BackgroundStyle.Class = "";
            caseCodeLabel.Location = new System.Drawing.Point(50, 7);
            caseCodeLabel.Name = "caseCodeLabel";
            caseCodeLabel.Size = new System.Drawing.Size(59, 16);
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
            assignBatchNoLabel.BackgroundStyle.Class = "";
            assignBatchNoLabel.Location = new System.Drawing.Point(50, 32);
            assignBatchNoLabel.Name = "assignBatchNoLabel";
            assignBatchNoLabel.Size = new System.Drawing.Size(59, 16);
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
            assignDateLabel.BackgroundStyle.Class = "";
            assignDateLabel.Location = new System.Drawing.Point(62, 58);
            assignDateLabel.Name = "assignDateLabel";
            assignDateLabel.Size = new System.Drawing.Size(47, 16);
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
            createUserNameLabel.BackgroundStyle.Class = "";
            createUserNameLabel.Location = new System.Drawing.Point(218, 152);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            createUserNameLabel.TabIndex = 8;
            createUserNameLabel.Text = "经办人:";
            // 
            // checkStatusLabel
            // 
            checkStatusLabel.AutoSize = true;
            checkStatusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkStatusLabel.BackgroundStyle.Class = "";
            checkStatusLabel.Location = new System.Drawing.Point(50, 183);
            checkStatusLabel.Name = "checkStatusLabel";
            checkStatusLabel.Size = new System.Drawing.Size(59, 16);
            checkStatusLabel.TabIndex = 10;
            checkStatusLabel.Text = "复核状态:";
            // 
            // rejectReasonLabel
            // 
            rejectReasonLabel.AutoSize = true;
            rejectReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            rejectReasonLabel.BackgroundStyle.Class = "";
            rejectReasonLabel.Location = new System.Drawing.Point(50, 209);
            rejectReasonLabel.Name = "rejectReasonLabel";
            rejectReasonLabel.Size = new System.Drawing.Size(59, 16);
            rejectReasonLabel.TabIndex = 12;
            rejectReasonLabel.Text = "退回原因:";
            // 
            // checkDateLabel
            // 
            checkDateLabel.AutoSize = true;
            checkDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkDateLabel.BackgroundStyle.Class = "";
            checkDateLabel.Location = new System.Drawing.Point(62, 257);
            checkDateLabel.Name = "checkDateLabel";
            checkDateLabel.Size = new System.Drawing.Size(47, 16);
            checkDateLabel.TabIndex = 14;
            checkDateLabel.Text = "复核日:";
            // 
            // checkUserNameLabel
            // 
            checkUserNameLabel.AutoSize = true;
            checkUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkUserNameLabel.BackgroundStyle.Class = "";
            checkUserNameLabel.Location = new System.Drawing.Point(62, 279);
            checkUserNameLabel.Name = "checkUserNameLabel";
            checkUserNameLabel.Size = new System.Drawing.Size(47, 16);
            checkUserNameLabel.TabIndex = 16;
            checkUserNameLabel.Text = "复核人:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(75, 82);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 18;
            commentLabel.Text = "备注:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.panelBatch);
            this.tabControl.Controls.Add(this.panelInvoices);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 370);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemBatch);
            this.tabControl.Tabs.Add(this.tabItemInvoices);
            // 
            // panelBatch
            // 
            this.panelBatch.AutoScroll = true;
            this.panelBatch.Controls.Add(lblInputDate);
            this.panelBatch.Controls.Add(this.diInputDate);
            this.panelBatch.Controls.Add(this.checkStatusComboBox);
            this.panelBatch.Controls.Add(this.btnSave);
            this.panelBatch.Controls.Add(this.btnUpdate);
            this.panelBatch.Controls.Add(commentLabel);
            this.panelBatch.Controls.Add(this.commentTextBox);
            this.panelBatch.Controls.Add(checkUserNameLabel);
            this.panelBatch.Controls.Add(this.checkUserNameTextBox);
            this.panelBatch.Controls.Add(checkDateLabel);
            this.panelBatch.Controls.Add(this.checkDateDateTimePicker);
            this.panelBatch.Controls.Add(rejectReasonLabel);
            this.panelBatch.Controls.Add(this.rejectReasonTextBox);
            this.panelBatch.Controls.Add(checkStatusLabel);
            this.panelBatch.Controls.Add(createUserNameLabel);
            this.panelBatch.Controls.Add(this.createUserNameTextBox);
            this.panelBatch.Controls.Add(this.isCreateMsgCheckBox);
            this.panelBatch.Controls.Add(assignDateLabel);
            this.panelBatch.Controls.Add(this.assignDateDateTimePicker);
            this.panelBatch.Controls.Add(assignBatchNoLabel);
            this.panelBatch.Controls.Add(this.assignBatchNoTextBox);
            this.panelBatch.Controls.Add(caseCodeLabel);
            this.panelBatch.Controls.Add(this.caseCodeTextBox);
            this.panelBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBatch.Location = new System.Drawing.Point(0, 26);
            this.panelBatch.Name = "panelBatch";
            this.panelBatch.Padding = new System.Windows.Forms.Padding(1);
            this.panelBatch.Size = new System.Drawing.Size(384, 344);
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
            // checkStatusComboBox
            // 
            this.checkStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CheckStatus", true));
            this.checkStatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checkStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkStatusComboBox.FormattingEnabled = true;
            this.checkStatusComboBox.Items.AddRange(new object[] {
            "未复核",
            "已复核",
            "复核未通过"});
            this.checkStatusComboBox.Location = new System.Drawing.Point(115, 181);
            this.checkStatusComboBox.Name = "checkStatusComboBox";
            this.checkStatusComboBox.Size = new System.Drawing.Size(162, 21);
            this.checkStatusComboBox.TabIndex = 22;
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceAssignBatch);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(202, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(115, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(115, 81);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(256, 65);
            this.commentTextBox.TabIndex = 19;
            // 
            // checkUserNameTextBox
            // 
            // 
            // 
            // 
            this.checkUserNameTextBox.Border.Class = "TextBoxBorder";
            this.checkUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CheckUserName", true));
            this.checkUserNameTextBox.Location = new System.Drawing.Point(115, 278);
            this.checkUserNameTextBox.Name = "checkUserNameTextBox";
            this.checkUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.checkUserNameTextBox.TabIndex = 17;
            // 
            // checkDateDateTimePicker
            // 
            // 
            // 
            // 
            this.checkDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.checkDateDateTimePicker.ButtonDropDown.Visible = true;
            this.checkDateDateTimePicker.ButtonFreeText.Checked = true;
            this.checkDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "CheckDate", true));
            this.checkDateDateTimePicker.FreeTextEntryMode = true;
            this.checkDateDateTimePicker.Location = new System.Drawing.Point(115, 253);
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.checkDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.checkDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.checkDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.checkDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.checkDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.checkDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.checkDateDateTimePicker.Name = "checkDateDateTimePicker";
            this.checkDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.checkDateDateTimePicker.TabIndex = 15;
            // 
            // rejectReasonTextBox
            // 
            // 
            // 
            // 
            this.rejectReasonTextBox.Border.Class = "TextBoxBorder";
            this.rejectReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RejectReason", true));
            this.rejectReasonTextBox.Location = new System.Drawing.Point(115, 208);
            this.rejectReasonTextBox.Multiline = true;
            this.rejectReasonTextBox.Name = "rejectReasonTextBox";
            this.rejectReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rejectReasonTextBox.Size = new System.Drawing.Size(256, 39);
            this.rejectReasonTextBox.TabIndex = 13;
            // 
            // createUserNameTextBox
            // 
            // 
            // 
            // 
            this.createUserNameTextBox.Border.Class = "TextBoxBorder";
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(271, 149);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.ReadOnly = true;
            this.createUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.createUserNameTextBox.TabIndex = 9;
            // 
            // isCreateMsgCheckBox
            // 
            this.isCreateMsgCheckBox.AutoSize = true;
            this.isCreateMsgCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isCreateMsgCheckBox.BackgroundStyle.Class = "";
            this.isCreateMsgCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.batchBindingSource, "IsCreateMsg", true));
            this.isCreateMsgCheckBox.Location = new System.Drawing.Point(50, 153);
            this.isCreateMsgCheckBox.Name = "isCreateMsgCheckBox";
            this.isCreateMsgCheckBox.Size = new System.Drawing.Size(101, 16);
            this.isCreateMsgCheckBox.TabIndex = 7;
            this.isCreateMsgCheckBox.Text = "是否生成报文";
            // 
            // assignDateDateTimePicker
            // 
            // 
            // 
            // 
            this.assignDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.assignDateDateTimePicker.ButtonDropDown.Visible = true;
            this.assignDateDateTimePicker.ButtonFreeText.Checked = true;
            this.assignDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "AssignDate", true));
            this.assignDateDateTimePicker.FreeTextEntryMode = true;
            this.assignDateDateTimePicker.Location = new System.Drawing.Point(115, 56);
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.assignDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.assignDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.assignDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.assignDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.assignDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.assignDateDateTimePicker.Name = "assignDateDateTimePicker";
            this.assignDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.assignDateDateTimePicker.TabIndex = 5;
            // 
            // assignBatchNoTextBox
            // 
            // 
            // 
            // 
            this.assignBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.assignBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "AssignBatchNo", true));
            this.assignBatchNoTextBox.Location = new System.Drawing.Point(115, 30);
            this.assignBatchNoTextBox.Name = "assignBatchNoTextBox";
            this.assignBatchNoTextBox.Size = new System.Drawing.Size(162, 20);
            this.assignBatchNoTextBox.TabIndex = 3;
            // 
            // caseCodeTextBox
            // 
            // 
            // 
            // 
            this.caseCodeTextBox.Border.Class = "TextBoxBorder";
            this.caseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CaseCode", true));
            this.caseCodeTextBox.Location = new System.Drawing.Point(115, 6);
            this.caseCodeTextBox.Name = "caseCodeTextBox";
            this.caseCodeTextBox.Size = new System.Drawing.Size(162, 20);
            this.caseCodeTextBox.TabIndex = 1;
            this.caseCodeTextBox.DoubleClick += new System.EventHandler(this.DetailCase);
            // 
            // tabItemBatch
            // 
            this.tabItemBatch.AttachedControl = this.panelBatch;
            this.tabItemBatch.Name = "tabItemBatch";
            this.tabItemBatch.Text = "批次";
            // 
            // panelInvoices
            // 
            this.panelInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoices.Location = new System.Drawing.Point(0, 26);
            this.panelInvoices.Name = "panelInvoices";
            this.panelInvoices.Padding = new System.Windows.Forms.Padding(1);
            this.panelInvoices.Size = new System.Drawing.Size(384, 344);
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
            // lblInputDate
            // 
            lblInputDate.AutoSize = true;
            lblInputDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblInputDate.BackgroundStyle.Class = "";
            lblInputDate.Location = new System.Drawing.Point(218, 58);
            lblInputDate.Name = "lblInputDate";
            lblInputDate.Size = new System.Drawing.Size(47, 16);
            lblInputDate.TabIndex = 23;
            lblInputDate.Text = "录入日:";
            // 
            // diInputDate
            // 
            // 
            // 
            // 
            this.diInputDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diInputDate.ButtonDropDown.Visible = true;
            this.diInputDate.ButtonFreeText.Checked = true;
            this.diInputDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "InputDate", true));
            this.diInputDate.FreeTextEntryMode = true;
            this.diInputDate.Location = new System.Drawing.Point(271, 56);
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diInputDate.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diInputDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.diInputDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diInputDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diInputDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diInputDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diInputDate.Name = "diInputDate";
            this.diInputDate.Size = new System.Drawing.Size(100, 20);
            this.diInputDate.TabIndex = 24;
            // 
            // AssignBatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 370);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "AssignBatchDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "转让批次信息";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.panelBatch.ResumeLayout(false);
            this.panelBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInputDate)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput diInputDate;
    }
}