//-----------------------------------------------------------------------
// <copyright file="CommissionRemitDetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    partial class CommissionRemitDetail
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
            DevComponents.DotNetBar.LabelX lblRemitCurrency;
            DevComponents.DotNetBar.LabelX lbcRemitAmount;
            DevComponents.DotNetBar.LabelX lblMsgCurrency;
            DevComponents.DotNetBar.LabelX lblMsgType;
            DevComponents.DotNetBar.LabelX lblCommmissionCreateUserName;
            DevComponents.DotNetBar.LabelX lblCommissionComment;
            DevComponents.DotNetBar.LabelX lblMsgDate;
            DevComponents.DotNetBar.LabelX lblRemitDate;
            DevComponents.DotNetBar.LabelX lblMsgAmount;
            DevComponents.DotNetBar.LabelX lblFactor;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommissionRemitDetail));
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.panelCommission = new DevComponents.DotNetBar.TabControlPanel();
            this.tbFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commissionRemitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbRemitCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbRemitAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbMsgCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbMsgType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCommissionCreateUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCommissionComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diMsgDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diRemitDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tbMsgAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.btnBatchUpdate = new DevComponents.DotNetBar.ButtonX();
            this.tabItemCommission = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelBatches = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemBatches = new DevComponents.DotNetBar.TabItem(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.commissionRemitValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            lblRemitCurrency = new DevComponents.DotNetBar.LabelX();
            lbcRemitAmount = new DevComponents.DotNetBar.LabelX();
            lblMsgCurrency = new DevComponents.DotNetBar.LabelX();
            lblMsgType = new DevComponents.DotNetBar.LabelX();
            lblCommmissionCreateUserName = new DevComponents.DotNetBar.LabelX();
            lblCommissionComment = new DevComponents.DotNetBar.LabelX();
            lblMsgDate = new DevComponents.DotNetBar.LabelX();
            lblRemitDate = new DevComponents.DotNetBar.LabelX();
            lblMsgAmount = new DevComponents.DotNetBar.LabelX();
            lblFactor = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.panelCommission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commissionRemitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diMsgDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRemitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemitCurrency
            // 
            lblRemitCurrency.AutoSize = true;
            lblRemitCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRemitCurrency.BackgroundStyle.Class = "";
            lblRemitCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblRemitCurrency.Location = new System.Drawing.Point(201, 55);
            lblRemitCurrency.Name = "lblRemitCurrency";
            lblRemitCurrency.Size = new System.Drawing.Size(59, 16);
            lblRemitCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblRemitCurrency.TabIndex = 56;
            lblRemitCurrency.Text = "汇款币别:";
            // 
            // lbcRemitAmount
            // 
            lbcRemitAmount.AutoSize = true;
            lbcRemitAmount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lbcRemitAmount.BackgroundStyle.Class = "";
            lbcRemitAmount.Location = new System.Drawing.Point(201, 77);
            lbcRemitAmount.Name = "lbcRemitAmount";
            lbcRemitAmount.Size = new System.Drawing.Size(59, 16);
            lbcRemitAmount.TabIndex = 54;
            lbcRemitAmount.Text = "汇款金额:";
            // 
            // lblMsgCurrency
            // 
            lblMsgCurrency.AutoSize = true;
            lblMsgCurrency.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgCurrency.BackgroundStyle.Class = "";
            lblMsgCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblMsgCurrency.Location = new System.Drawing.Point(22, 56);
            lblMsgCurrency.Name = "lblMsgCurrency";
            lblMsgCurrency.Size = new System.Drawing.Size(57, 15);
            lblMsgCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            lblMsgCurrency.TabIndex = 52;
            lblMsgCurrency.Text = "<font color=\'red\'>*</font>消息币别:";
            // 
            // lblMsgType
            // 
            lblMsgType.AutoSize = true;
            lblMsgType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgType.BackgroundStyle.Class = "";
            lblMsgType.Location = new System.Drawing.Point(22, 8);
            lblMsgType.Name = "lblMsgType";
            lblMsgType.Size = new System.Drawing.Size(57, 15);
            lblMsgType.TabIndex = 40;
            lblMsgType.Text = "<font color=\'red\'>*</font>消息类型:";
            // 
            // lblCommmissionCreateUserName
            // 
            lblCommmissionCreateUserName.AutoSize = true;
            lblCommmissionCreateUserName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCommmissionCreateUserName.BackgroundStyle.Class = "";
            lblCommmissionCreateUserName.Location = new System.Drawing.Point(32, 179);
            lblCommmissionCreateUserName.Name = "lblCommmissionCreateUserName";
            lblCommmissionCreateUserName.Size = new System.Drawing.Size(47, 16);
            lblCommmissionCreateUserName.TabIndex = 50;
            lblCommmissionCreateUserName.Text = "经办人:";
            // 
            // lblCommissionComment
            // 
            lblCommissionComment.AutoSize = true;
            lblCommissionComment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblCommissionComment.BackgroundStyle.Class = "";
            lblCommissionComment.Location = new System.Drawing.Point(45, 98);
            lblCommissionComment.Name = "lblCommissionComment";
            lblCommissionComment.Size = new System.Drawing.Size(34, 16);
            lblCommissionComment.TabIndex = 48;
            lblCommissionComment.Text = "备注:";
            // 
            // lblMsgDate
            // 
            lblMsgDate.AutoSize = true;
            lblMsgDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgDate.BackgroundStyle.Class = "";
            lblMsgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lblMsgDate.Location = new System.Drawing.Point(22, 31);
            lblMsgDate.Name = "lblMsgDate";
            lblMsgDate.Size = new System.Drawing.Size(57, 15);
            lblMsgDate.TabIndex = 42;
            lblMsgDate.Text = "<font color=\'red\'>*</font>消息日期:";
            // 
            // lblRemitDate
            // 
            lblRemitDate.AutoSize = true;
            lblRemitDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRemitDate.BackgroundStyle.Class = "";
            lblRemitDate.Location = new System.Drawing.Point(201, 31);
            lblRemitDate.Name = "lblRemitDate";
            lblRemitDate.Size = new System.Drawing.Size(59, 16);
            lblRemitDate.TabIndex = 46;
            lblRemitDate.Text = "汇款日期:";
            // 
            // lblMsgAmount
            // 
            lblMsgAmount.AutoSize = true;
            lblMsgAmount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMsgAmount.BackgroundStyle.Class = "";
            lblMsgAmount.Location = new System.Drawing.Point(22, 77);
            lblMsgAmount.Name = "lblMsgAmount";
            lblMsgAmount.Size = new System.Drawing.Size(57, 15);
            lblMsgAmount.TabIndex = 44;
            lblMsgAmount.Text = "<font color=\'red\'>*</font>消息金额:";
            // 
            // lblFactor
            // 
            lblFactor.AutoSize = true;
            lblFactor.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblFactor.BackgroundStyle.Class = "";
            lblFactor.Location = new System.Drawing.Point(213, 9);
            lblFactor.Name = "lblFactor";
            lblFactor.Size = new System.Drawing.Size(47, 16);
            lblFactor.TabIndex = 66;
            lblFactor.Text = "保理商:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.panelCommission);
            this.tabControl.Controls.Add(this.panelBatches);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(388, 272);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemCommission);
            this.tabControl.Tabs.Add(this.tabItemBatches);
            // 
            // panelCommission
            // 
            this.panelCommission.AutoScroll = true;
            this.panelCommission.Controls.Add(this.tbFactor);
            this.panelCommission.Controls.Add(lblFactor);
            this.panelCommission.Controls.Add(this.cbRemitCurrency);
            this.panelCommission.Controls.Add(lblRemitCurrency);
            this.panelCommission.Controls.Add(lbcRemitAmount);
            this.panelCommission.Controls.Add(this.tbRemitAmount);
            this.panelCommission.Controls.Add(this.cbMsgCurrency);
            this.panelCommission.Controls.Add(lblMsgCurrency);
            this.panelCommission.Controls.Add(lblMsgType);
            this.panelCommission.Controls.Add(this.tbMsgType);
            this.panelCommission.Controls.Add(lblCommmissionCreateUserName);
            this.panelCommission.Controls.Add(this.tbCommissionCreateUserName);
            this.panelCommission.Controls.Add(lblCommissionComment);
            this.panelCommission.Controls.Add(this.tbCommissionComment);
            this.panelCommission.Controls.Add(lblMsgDate);
            this.panelCommission.Controls.Add(this.diMsgDate);
            this.panelCommission.Controls.Add(lblRemitDate);
            this.panelCommission.Controls.Add(this.diRemitDate);
            this.panelCommission.Controls.Add(lblMsgAmount);
            this.panelCommission.Controls.Add(this.tbMsgAmount);
            this.panelCommission.Controls.Add(this.btnBatchSave);
            this.panelCommission.Controls.Add(this.btnBatchUpdate);
            this.panelCommission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCommission.Location = new System.Drawing.Point(0, 26);
            this.panelCommission.Name = "panelCommission";
            this.panelCommission.Padding = new System.Windows.Forms.Padding(1);
            this.panelCommission.Size = new System.Drawing.Size(388, 246);
            this.panelCommission.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelCommission.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelCommission.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCommission.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.panelCommission.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.panelCommission.Style.GradientAngle = 90;
            this.panelCommission.TabIndex = 1;
            this.panelCommission.TabItem = this.tabItemCommission;
            // 
            // tbFactor
            // 
            // 
            // 
            // 
            this.tbFactor.Border.Class = "TextBoxBorder";
            this.tbFactor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgType", true));
            this.tbFactor.Location = new System.Drawing.Point(264, 6);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(103, 20);
            this.tbFactor.TabIndex = 67;
            // 
            // commissionRemitBindingSource
            // 
            this.commissionRemitBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.CommissionRemittance);
            // 
            // cbRemitCurrency
            // 
            this.cbRemitCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRemitCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRemitCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commissionRemitBindingSource, "RemitCurrency", true));
            this.cbRemitCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRemitCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemitCurrency.ItemHeight = 14;
            this.cbRemitCurrency.Location = new System.Drawing.Point(264, 52);
            this.cbRemitCurrency.Name = "cbRemitCurrency";
            this.cbRemitCurrency.Size = new System.Drawing.Size(103, 20);
            this.cbRemitCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbRemitCurrency.TabIndex = 57;
            // 
            // tbRemitAmount
            // 
            // 
            // 
            // 
            this.tbRemitAmount.Border.Class = "TextBoxBorder";
            this.tbRemitAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "RemitAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbRemitAmount.Location = new System.Drawing.Point(264, 76);
            this.tbRemitAmount.Name = "tbRemitAmount";
            this.tbRemitAmount.Size = new System.Drawing.Size(103, 20);
            this.tbRemitAmount.TabIndex = 55;
            // 
            // cbMsgCurrency
            // 
            this.cbMsgCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMsgCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMsgCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commissionRemitBindingSource, "MsgCurrency", true));
            this.cbMsgCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMsgCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMsgCurrency.ItemHeight = 14;
            this.cbMsgCurrency.Location = new System.Drawing.Point(83, 52);
            this.cbMsgCurrency.Name = "cbMsgCurrency";
            this.cbMsgCurrency.Size = new System.Drawing.Size(103, 20);
            this.cbMsgCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMsgCurrency.TabIndex = 53;
            // 
            // tbMsgType
            // 
            // 
            // 
            // 
            this.tbMsgType.Border.Class = "TextBoxBorder";
            this.tbMsgType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgType", true));
            this.tbMsgType.Location = new System.Drawing.Point(83, 6);
            this.tbMsgType.Name = "tbMsgType";
            this.tbMsgType.Size = new System.Drawing.Size(103, 20);
            this.tbMsgType.TabIndex = 41;
            // 
            // tbCommissionCreateUserName
            // 
            // 
            // 
            // 
            this.tbCommissionCreateUserName.Border.Class = "TextBoxBorder";
            this.tbCommissionCreateUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "CreateUserName", true));
            this.tbCommissionCreateUserName.Location = new System.Drawing.Point(83, 178);
            this.tbCommissionCreateUserName.Name = "tbCommissionCreateUserName";
            this.tbCommissionCreateUserName.ReadOnly = true;
            this.tbCommissionCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.tbCommissionCreateUserName.TabIndex = 51;
            // 
            // tbCommissionComment
            // 
            // 
            // 
            // 
            this.tbCommissionComment.Border.Class = "";
            this.tbCommissionComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "Comment", true));
            this.tbCommissionComment.Location = new System.Drawing.Point(83, 102);
            this.tbCommissionComment.Multiline = true;
            this.tbCommissionComment.Name = "tbCommissionComment";
            this.tbCommissionComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCommissionComment.Size = new System.Drawing.Size(284, 70);
            this.tbCommissionComment.TabIndex = 49;
            // 
            // diMsgDate
            // 
            // 
            // 
            // 
            this.diMsgDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diMsgDate.ButtonDropDown.Visible = true;
            this.diMsgDate.ButtonFreeText.Checked = true;
            this.diMsgDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgDate", true));
            this.diMsgDate.FreeTextEntryMode = true;
            this.diMsgDate.Location = new System.Drawing.Point(83, 29);
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diMsgDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diMsgDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diMsgDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMsgDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diMsgDate.MonthCalendar.TodayButtonVisible = true;
            this.diMsgDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diMsgDate.Name = "diMsgDate";
            this.diMsgDate.Size = new System.Drawing.Size(103, 20);
            this.diMsgDate.TabIndex = 43;
            // 
            // diRemitDate
            // 
            // 
            // 
            // 
            this.diRemitDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diRemitDate.ButtonDropDown.Visible = true;
            this.diRemitDate.ButtonFreeText.Checked = true;
            this.diRemitDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "RemitDate", true));
            this.diRemitDate.FreeTextEntryMode = true;
            this.diRemitDate.Location = new System.Drawing.Point(264, 28);
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diRemitDate.MonthCalendar.BackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diRemitDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diRemitDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diRemitDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diRemitDate.MonthCalendar.TodayButtonVisible = true;
            this.diRemitDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diRemitDate.Name = "diRemitDate";
            this.diRemitDate.Size = new System.Drawing.Size(103, 20);
            this.diRemitDate.TabIndex = 47;
            // 
            // tbMsgAmount
            // 
            // 
            // 
            // 
            this.tbMsgAmount.Border.Class = "TextBoxBorder";
            this.tbMsgAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionRemitBindingSource, "MsgAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbMsgAmount.Location = new System.Drawing.Point(83, 76);
            this.tbMsgAmount.Name = "tbMsgAmount";
            this.tbMsgAmount.Size = new System.Drawing.Size(103, 20);
            this.tbMsgAmount.TabIndex = 45;
            // 
            // btnBatchSave
            // 
            this.btnBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatchSave.Location = new System.Drawing.Point(201, 204);
            this.btnBatchSave.Name = "btnBatchSave";
            this.btnBatchSave.Size = new System.Drawing.Size(75, 23);
            this.btnBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatchSave.TabIndex = 39;
            this.btnBatchSave.Text = "保存";
            this.btnBatchSave.Click += new System.EventHandler(this.SaveCommissionRemit);
            // 
            // btnBatchUpdate
            // 
            this.btnBatchUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatchUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatchUpdate.Location = new System.Drawing.Point(108, 204);
            this.btnBatchUpdate.Name = "btnBatchUpdate";
            this.btnBatchUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBatchUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatchUpdate.TabIndex = 38;
            this.btnBatchUpdate.Text = "编辑";
            this.btnBatchUpdate.Click += new System.EventHandler(this.UpdateCommissionRemit);
            // 
            // tabItemCommission
            // 
            this.tabItemCommission.AttachedControl = this.panelCommission;
            this.tabItemCommission.Name = "tabItemCommission";
            this.tabItemCommission.Text = "手续费";
            // 
            // panelBatches
            // 
            this.panelBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBatches.Location = new System.Drawing.Point(0, 26);
            this.panelBatches.Name = "panelBatches";
            this.panelBatches.Padding = new System.Windows.Forms.Padding(1);
            this.panelBatches.Size = new System.Drawing.Size(388, 246);
            this.panelBatches.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelBatches.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelBatches.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBatches.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.panelBatches.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.panelBatches.Style.GradientAngle = 90;
            this.panelBatches.TabIndex = 2;
            this.panelBatches.TabItem = this.tabItemBatches;
            // 
            // tabItemBatches
            // 
            this.tabItemBatches.AttachedControl = this.panelBatches;
            this.tabItemBatches.Name = "tabItemBatches";
            this.tabItemBatches.Text = "业务批次";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // commissionRemitValidator
            // 
            this.commissionRemitValidator.ErrorProvider = this.errorProvider;
            this.commissionRemitValidator.Highlighter = this.highlighter;
            // 
            // CommissionRemitDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 272);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "CommissionRemitDetail";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.panelCommission.ResumeLayout(false);
            this.panelCommission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commissionRemitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diMsgDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRemitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel panelCommission;
        private DevComponents.DotNetBar.ButtonX btnBatchSave;
        private DevComponents.DotNetBar.ButtonX btnBatchUpdate;
        private DevComponents.DotNetBar.TabItem tabItemCommission;
        private DevComponents.DotNetBar.TabControlPanel panelBatches;
        private DevComponents.DotNetBar.TabItem tabItemBatches;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRemitCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRemitAmount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMsgCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMsgType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCommissionCreateUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCommissionComment;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diMsgDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diRemitDate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMsgAmount;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource commissionRemitBindingSource;
        private DevComponents.DotNetBar.Validator.SuperValidator commissionRemitValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactor;
    }
}
