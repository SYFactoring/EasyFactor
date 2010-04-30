//-----------------------------------------------------------------------
// <copyright file="FinanceBatchDetail.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FinanceBatchDetail
    {
		#region Fields (32) 
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.BindingSource batchBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx batchCurrencyComboBox;
        private DevComponents.DotNetBar.ButtonX btnBatchSave;
        private DevComponents.DotNetBar.ButtonX btnBatchUpdate;
        private DevComponents.DotNetBar.ButtonX btnFactorSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX caseCodeTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput checkDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.ComboBoxEx checkStatusComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX checkUserNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX costRateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX createUserNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX factorTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeAmountTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodBeginDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX financeRateTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx financeTypeComboBox;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX otherIncomeTextBox;
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
            DevComponents.DotNetBar.LabelX financeBatchNoLabel;
            DevComponents.DotNetBar.LabelX financeAmountLabel;
            DevComponents.DotNetBar.LabelX financePeriodBeginLabel;
            DevComponents.DotNetBar.LabelX otherIncomeLabel;
            DevComponents.DotNetBar.LabelX financeTypeLabel;
            DevComponents.DotNetBar.LabelX batchCurrencyLabel;
            DevComponents.DotNetBar.LabelX financeRateLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX costRateLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX createUserNameLabel;
            DevComponents.DotNetBar.LabelX checkStatusLabel;
            DevComponents.DotNetBar.LabelX rejectReasonLabel;
            DevComponents.DotNetBar.LabelX checkUserNameLabel;
            DevComponents.DotNetBar.LabelX checkDateLabel;
            DevComponents.DotNetBar.LabelX lblClient;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceBatchDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            DevComponents.DotNetBar.LabelX lblInputDate;
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.panelBatch = new DevComponents.DotNetBar.TabControlPanel();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkStatusComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.btnBatchUpdate = new DevComponents.DotNetBar.ButtonX();
            this.factorTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.checkUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rejectReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.createUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.costRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.batchCurrencyComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.otherIncomeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financePeriodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financePeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.caseCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemBatch = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelInvoices = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvFinanceLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuLogMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemLogDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabItemInvoices = new DevComponents.DotNetBar.TabItem(this.components);
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diInputDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            caseCodeLabel = new DevComponents.DotNetBar.LabelX();
            financeBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            financeAmountLabel = new DevComponents.DotNetBar.LabelX();
            financePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            otherIncomeLabel = new DevComponents.DotNetBar.LabelX();
            financeTypeLabel = new DevComponents.DotNetBar.LabelX();
            batchCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            financeRateLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            costRateLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            createUserNameLabel = new DevComponents.DotNetBar.LabelX();
            checkStatusLabel = new DevComponents.DotNetBar.LabelX();
            rejectReasonLabel = new DevComponents.DotNetBar.LabelX();
            checkUserNameLabel = new DevComponents.DotNetBar.LabelX();
            checkDateLabel = new DevComponents.DotNetBar.LabelX();
            lblClient = new DevComponents.DotNetBar.LabelX();
            lblInputDate = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.panelBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).BeginInit();
            this.panelInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceLogs)).BeginInit();
            this.cmuLogMgr.SuspendLayout();
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
            caseCodeLabel.Location = new System.Drawing.Point(48, 5);
            caseCodeLabel.Name = "caseCodeLabel";
            caseCodeLabel.Size = new System.Drawing.Size(59, 16);
            caseCodeLabel.TabIndex = 0;
            caseCodeLabel.Text = "案件编号:";
            // 
            // financeBatchNoLabel
            // 
            financeBatchNoLabel.AutoSize = true;
            financeBatchNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeBatchNoLabel.BackgroundStyle.Class = "";
            financeBatchNoLabel.Location = new System.Drawing.Point(49, 29);
            financeBatchNoLabel.Name = "financeBatchNoLabel";
            financeBatchNoLabel.Size = new System.Drawing.Size(59, 16);
            financeBatchNoLabel.TabIndex = 2;
            financeBatchNoLabel.Text = "融资批号:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            financeAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.Class = "";
            financeAmountLabel.Location = new System.Drawing.Point(49, 52);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(59, 16);
            financeAmountLabel.TabIndex = 4;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financePeriodBeginLabel
            // 
            financePeriodBeginLabel.AutoSize = true;
            financePeriodBeginLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financePeriodBeginLabel.BackgroundStyle.Class = "";
            financePeriodBeginLabel.Location = new System.Drawing.Point(49, 75);
            financePeriodBeginLabel.Name = "financePeriodBeginLabel";
            financePeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            financePeriodBeginLabel.TabIndex = 6;
            financePeriodBeginLabel.Text = "融资期限:";
            // 
            // otherIncomeLabel
            // 
            otherIncomeLabel.AutoSize = true;
            otherIncomeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            otherIncomeLabel.BackgroundStyle.Class = "";
            otherIncomeLabel.Location = new System.Drawing.Point(49, 145);
            otherIncomeLabel.Name = "otherIncomeLabel";
            otherIncomeLabel.Size = new System.Drawing.Size(59, 16);
            otherIncomeLabel.TabIndex = 14;
            otherIncomeLabel.Text = "其他收入:";
            // 
            // financeTypeLabel
            // 
            financeTypeLabel.AutoSize = true;
            financeTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeTypeLabel.BackgroundStyle.Class = "";
            financeTypeLabel.Location = new System.Drawing.Point(277, 28);
            financeTypeLabel.Name = "financeTypeLabel";
            financeTypeLabel.Size = new System.Drawing.Size(59, 16);
            financeTypeLabel.TabIndex = 15;
            financeTypeLabel.Text = "融资类型:";
            // 
            // batchCurrencyLabel
            // 
            batchCurrencyLabel.AutoSize = true;
            batchCurrencyLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            batchCurrencyLabel.BackgroundStyle.Class = "";
            batchCurrencyLabel.Location = new System.Drawing.Point(277, 54);
            batchCurrencyLabel.Name = "batchCurrencyLabel";
            batchCurrencyLabel.Size = new System.Drawing.Size(59, 16);
            batchCurrencyLabel.TabIndex = 16;
            batchCurrencyLabel.Text = "融资币别:";
            // 
            // financeRateLabel
            // 
            financeRateLabel.AutoSize = true;
            financeRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeRateLabel.BackgroundStyle.Class = "";
            financeRateLabel.Location = new System.Drawing.Point(49, 99);
            financeRateLabel.Name = "financeRateLabel";
            financeRateLabel.Size = new System.Drawing.Size(59, 16);
            financeRateLabel.TabIndex = 18;
            financeRateLabel.Text = "融资利率:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            factorCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Location = new System.Drawing.Point(285, 119);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            factorCodeLabel.TabIndex = 20;
            factorCodeLabel.Text = "代付行:";
            // 
            // costRateLabel
            // 
            costRateLabel.AutoSize = true;
            costRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            costRateLabel.BackgroundStyle.Class = "";
            costRateLabel.Location = new System.Drawing.Point(273, 97);
            costRateLabel.Name = "costRateLabel";
            costRateLabel.Size = new System.Drawing.Size(59, 16);
            costRateLabel.TabIndex = 22;
            costRateLabel.Text = "成本利率:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(73, 169);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 24;
            commentLabel.Text = "备注:";
            // 
            // createUserNameLabel
            // 
            createUserNameLabel.AutoSize = true;
            createUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            createUserNameLabel.BackgroundStyle.Class = "";
            createUserNameLabel.Location = new System.Drawing.Point(60, 217);
            createUserNameLabel.Name = "createUserNameLabel";
            createUserNameLabel.Size = new System.Drawing.Size(47, 16);
            createUserNameLabel.TabIndex = 26;
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
            checkStatusLabel.Location = new System.Drawing.Point(48, 243);
            checkStatusLabel.Name = "checkStatusLabel";
            checkStatusLabel.Size = new System.Drawing.Size(59, 16);
            checkStatusLabel.TabIndex = 28;
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
            rejectReasonLabel.Location = new System.Drawing.Point(49, 280);
            rejectReasonLabel.Name = "rejectReasonLabel";
            rejectReasonLabel.Size = new System.Drawing.Size(59, 16);
            rejectReasonLabel.TabIndex = 30;
            rejectReasonLabel.Text = "退回原因:";
            // 
            // checkUserNameLabel
            // 
            checkUserNameLabel.AutoSize = true;
            checkUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkUserNameLabel.BackgroundStyle.Class = "";
            checkUserNameLabel.Location = new System.Drawing.Point(289, 317);
            checkUserNameLabel.Name = "checkUserNameLabel";
            checkUserNameLabel.Size = new System.Drawing.Size(47, 16);
            checkUserNameLabel.TabIndex = 32;
            checkUserNameLabel.Text = "复核人:";
            // 
            // checkDateLabel
            // 
            checkDateLabel.AutoSize = true;
            checkDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            checkDateLabel.BackgroundStyle.Class = "";
            checkDateLabel.Location = new System.Drawing.Point(60, 317);
            checkDateLabel.Name = "checkDateLabel";
            checkDateLabel.Size = new System.Drawing.Size(47, 16);
            checkDateLabel.TabIndex = 34;
            checkDateLabel.Text = "复核日:";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblClient.BackgroundStyle.Class = "";
            lblClient.Location = new System.Drawing.Point(277, 4);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(59, 16);
            lblClient.TabIndex = 42;
            lblClient.Text = "卖方名称:";
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceFinanceBatch);
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
            this.tabControl.Size = new System.Drawing.Size(496, 405);
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
            this.panelBatch.Controls.Add(lblClient);
            this.panelBatch.Controls.Add(this.tbClientName);
            this.panelBatch.Controls.Add(this.checkStatusComboBox);
            this.panelBatch.Controls.Add(this.btnFactorSelect);
            this.panelBatch.Controls.Add(this.btnBatchSave);
            this.panelBatch.Controls.Add(this.btnBatchUpdate);
            this.panelBatch.Controls.Add(this.factorTextBox);
            this.panelBatch.Controls.Add(checkDateLabel);
            this.panelBatch.Controls.Add(this.checkDateDateTimePicker);
            this.panelBatch.Controls.Add(checkUserNameLabel);
            this.panelBatch.Controls.Add(this.checkUserNameTextBox);
            this.panelBatch.Controls.Add(rejectReasonLabel);
            this.panelBatch.Controls.Add(this.rejectReasonTextBox);
            this.panelBatch.Controls.Add(checkStatusLabel);
            this.panelBatch.Controls.Add(createUserNameLabel);
            this.panelBatch.Controls.Add(this.createUserNameTextBox);
            this.panelBatch.Controls.Add(commentLabel);
            this.panelBatch.Controls.Add(this.commentTextBox);
            this.panelBatch.Controls.Add(costRateLabel);
            this.panelBatch.Controls.Add(this.costRateTextBox);
            this.panelBatch.Controls.Add(factorCodeLabel);
            this.panelBatch.Controls.Add(this.factorCodeTextBox);
            this.panelBatch.Controls.Add(financeRateLabel);
            this.panelBatch.Controls.Add(this.financeRateTextBox);
            this.panelBatch.Controls.Add(batchCurrencyLabel);
            this.panelBatch.Controls.Add(this.batchCurrencyComboBox);
            this.panelBatch.Controls.Add(financeTypeLabel);
            this.panelBatch.Controls.Add(this.financeTypeComboBox);
            this.panelBatch.Controls.Add(otherIncomeLabel);
            this.panelBatch.Controls.Add(this.otherIncomeTextBox);
            this.panelBatch.Controls.Add(this.financePeriodEndDateTimePicker);
            this.panelBatch.Controls.Add(financePeriodBeginLabel);
            this.panelBatch.Controls.Add(this.financePeriodBeginDateTimePicker);
            this.panelBatch.Controls.Add(financeAmountLabel);
            this.panelBatch.Controls.Add(this.financeAmountTextBox);
            this.panelBatch.Controls.Add(financeBatchNoLabel);
            this.panelBatch.Controls.Add(this.financeBatchNoTextBox);
            this.panelBatch.Controls.Add(caseCodeLabel);
            this.panelBatch.Controls.Add(this.caseCodeTextBox);
            this.panelBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBatch.Location = new System.Drawing.Point(0, 26);
            this.panelBatch.Name = "panelBatch";
            this.panelBatch.Padding = new System.Windows.Forms.Padding(1);
            this.panelBatch.Size = new System.Drawing.Size(496, 379);
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
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Client", true));
            this.tbClientName.Location = new System.Drawing.Point(342, 1);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(134, 20);
            this.tbClientName.TabIndex = 43;
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
            this.checkStatusComboBox.Location = new System.Drawing.Point(114, 241);
            this.checkStatusComboBox.Name = "checkStatusComboBox";
            this.checkStatusComboBox.Size = new System.Drawing.Size(134, 21);
            this.checkStatusComboBox.TabIndex = 41;
            // 
            // btnFactorSelect
            // 
            this.btnFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorSelect.Location = new System.Drawing.Point(455, 118);
            this.btnFactorSelect.Name = "btnFactorSelect";
            this.btnFactorSelect.Size = new System.Drawing.Size(21, 23);
            this.btnFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorSelect.TabIndex = 40;
            this.btnFactorSelect.Text = "...";
            this.btnFactorSelect.Click += new System.EventHandler(this.SelectFactor);
            // 
            // btnBatchSave
            // 
            this.btnBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatchSave.Location = new System.Drawing.Point(257, 345);
            this.btnBatchSave.Name = "btnBatchSave";
            this.btnBatchSave.Size = new System.Drawing.Size(75, 23);
            this.btnBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatchSave.TabIndex = 39;
            this.btnBatchSave.Text = "保存";
            this.btnBatchSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // btnBatchUpdate
            // 
            this.btnBatchUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatchUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatchUpdate.Location = new System.Drawing.Point(162, 345);
            this.btnBatchUpdate.Name = "btnBatchUpdate";
            this.btnBatchUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBatchUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatchUpdate.TabIndex = 38;
            this.btnBatchUpdate.Text = "编辑";
            this.btnBatchUpdate.Click += new System.EventHandler(this.UpdateBatch);
            // 
            // factorTextBox
            // 
            // 
            // 
            // 
            this.factorTextBox.Border.Class = "TextBoxBorder";
            this.factorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Factor.CompanyNameEN", true));
            this.factorTextBox.Location = new System.Drawing.Point(342, 143);
            this.factorTextBox.Name = "factorTextBox";
            this.factorTextBox.Size = new System.Drawing.Size(134, 20);
            this.factorTextBox.TabIndex = 37;
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
            this.checkDateDateTimePicker.Location = new System.Drawing.Point(113, 314);
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
            this.checkDateDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.checkDateDateTimePicker.TabIndex = 35;
            // 
            // checkUserNameTextBox
            // 
            // 
            // 
            // 
            this.checkUserNameTextBox.Border.Class = "TextBoxBorder";
            this.checkUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CheckUserName", true));
            this.checkUserNameTextBox.Location = new System.Drawing.Point(342, 314);
            this.checkUserNameTextBox.Name = "checkUserNameTextBox";
            this.checkUserNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.checkUserNameTextBox.TabIndex = 33;
            // 
            // rejectReasonTextBox
            // 
            // 
            // 
            // 
            this.rejectReasonTextBox.Border.Class = "TextBoxBorder";
            this.rejectReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "RejectReason", true));
            this.rejectReasonTextBox.Location = new System.Drawing.Point(114, 265);
            this.rejectReasonTextBox.Multiline = true;
            this.rejectReasonTextBox.Name = "rejectReasonTextBox";
            this.rejectReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rejectReasonTextBox.Size = new System.Drawing.Size(362, 45);
            this.rejectReasonTextBox.TabIndex = 31;
            // 
            // createUserNameTextBox
            // 
            // 
            // 
            // 
            this.createUserNameTextBox.Border.Class = "TextBoxBorder";
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(114, 218);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.ReadOnly = true;
            this.createUserNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.createUserNameTextBox.TabIndex = 27;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(114, 168);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(362, 46);
            this.commentTextBox.TabIndex = 25;
            // 
            // costRateTextBox
            // 
            // 
            // 
            // 
            this.costRateTextBox.Border.Class = "TextBoxBorder";
            this.costRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CostRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p4"));
            this.costRateTextBox.Location = new System.Drawing.Point(342, 95);
            this.costRateTextBox.Name = "costRateTextBox";
            this.costRateTextBox.Size = new System.Drawing.Size(134, 20);
            this.costRateTextBox.TabIndex = 23;
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FactorCode", true));
            this.factorCodeTextBox.Location = new System.Drawing.Point(342, 118);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.factorCodeTextBox.TabIndex = 21;
            // 
            // financeRateTextBox
            // 
            // 
            // 
            // 
            this.financeRateTextBox.Border.Class = "TextBoxBorder";
            this.financeRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p4"));
            this.financeRateTextBox.Location = new System.Drawing.Point(114, 96);
            this.financeRateTextBox.Name = "financeRateTextBox";
            this.financeRateTextBox.Size = new System.Drawing.Size(134, 20);
            this.financeRateTextBox.TabIndex = 19;
            // 
            // batchCurrencyComboBox
            // 
            this.batchCurrencyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.batchCurrencyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.batchCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "BatchCurrency", true));
            this.batchCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.batchCurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batchCurrencyComboBox.FormattingEnabled = true;
            this.batchCurrencyComboBox.Location = new System.Drawing.Point(342, 52);
            this.batchCurrencyComboBox.Name = "batchCurrencyComboBox";
            this.batchCurrencyComboBox.Size = new System.Drawing.Size(134, 21);
            this.batchCurrencyComboBox.TabIndex = 17;
            // 
            // financeTypeComboBox
            // 
            this.financeTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceType", true));
            this.financeTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.financeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.financeTypeComboBox.FormattingEnabled = true;
            this.financeTypeComboBox.Items.AddRange(new object[] {
            "保理预付款(表内)",
            "卖方代付",
            "买方代付",
            "银行承兑汇票",
            "商业承兑汇票",
            "国内信用证",
            "国际信用证",
            "其他",
            "未知"});
            this.financeTypeComboBox.Location = new System.Drawing.Point(342, 24);
            this.financeTypeComboBox.Name = "financeTypeComboBox";
            this.financeTypeComboBox.Size = new System.Drawing.Size(134, 21);
            this.financeTypeComboBox.TabIndex = 16;
            // 
            // otherIncomeTextBox
            // 
            // 
            // 
            // 
            this.otherIncomeTextBox.Border.Class = "TextBoxBorder";
            this.otherIncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "OtherIncome", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.otherIncomeTextBox.Location = new System.Drawing.Point(114, 144);
            this.otherIncomeTextBox.Name = "otherIncomeTextBox";
            this.otherIncomeTextBox.Size = new System.Drawing.Size(134, 20);
            this.otherIncomeTextBox.TabIndex = 15;
            // 
            // financePeriodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodEndDateTimePicker.ButtonFreeText.Checked = true;
            this.financePeriodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "FinancePeriodEnd", true));
            this.financePeriodEndDateTimePicker.FreeTextEntryMode = true;
            this.financePeriodEndDateTimePicker.Location = new System.Drawing.Point(277, 74);
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financePeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.financePeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financePeriodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodEndDateTimePicker.Name = "financePeriodEndDateTimePicker";
            this.financePeriodEndDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.financePeriodEndDateTimePicker.TabIndex = 9;
            // 
            // financePeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.financePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "FinancePeriodBegin", true));
            this.financePeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.financePeriodBeginDateTimePicker.Location = new System.Drawing.Point(114, 74);
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financePeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.financePeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financePeriodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodBeginDateTimePicker.Name = "financePeriodBeginDateTimePicker";
            this.financePeriodBeginDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.financePeriodBeginDateTimePicker.TabIndex = 7;
            // 
            // financeAmountTextBox
            // 
            // 
            // 
            // 
            this.financeAmountTextBox.Border.Class = "TextBoxBorder";
            this.financeAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.financeAmountTextBox.Location = new System.Drawing.Point(114, 50);
            this.financeAmountTextBox.Name = "financeAmountTextBox";
            this.financeAmountTextBox.Size = new System.Drawing.Size(134, 20);
            this.financeAmountTextBox.TabIndex = 5;
            // 
            // financeBatchNoTextBox
            // 
            // 
            // 
            // 
            this.financeBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.financeBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceBatchNo", true));
            this.financeBatchNoTextBox.Location = new System.Drawing.Point(114, 27);
            this.financeBatchNoTextBox.Name = "financeBatchNoTextBox";
            this.financeBatchNoTextBox.Size = new System.Drawing.Size(134, 20);
            this.financeBatchNoTextBox.TabIndex = 3;
            // 
            // caseCodeTextBox
            // 
            // 
            // 
            // 
            this.caseCodeTextBox.Border.Class = "TextBoxBorder";
            this.caseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CaseCode", true));
            this.caseCodeTextBox.Location = new System.Drawing.Point(114, 4);
            this.caseCodeTextBox.Name = "caseCodeTextBox";
            this.caseCodeTextBox.Size = new System.Drawing.Size(134, 20);
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
            this.panelInvoices.Controls.Add(this.dgvFinanceLogs);
            this.panelInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoices.Location = new System.Drawing.Point(0, 26);
            this.panelInvoices.Name = "panelInvoices";
            this.panelInvoices.Padding = new System.Windows.Forms.Padding(1);
            this.panelInvoices.Size = new System.Drawing.Size(496, 379);
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
            // dgvFinanceLogs
            // 
            this.dgvFinanceLogs.AllowUserToAddRows = false;
            this.dgvFinanceLogs.AllowUserToDeleteRows = false;
            this.dgvFinanceLogs.AllowUserToOrderColumns = true;
            this.dgvFinanceLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinanceLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinanceLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colFinanceCurrency,
            this.colFinanceAmount,
            this.colCommission,
            this.colComment});
            this.dgvFinanceLogs.ContextMenuStrip = this.cmuLogMgr;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinanceLogs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFinanceLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFinanceLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFinanceLogs.Location = new System.Drawing.Point(1, 1);
            this.dgvFinanceLogs.Name = "dgvFinanceLogs";
            this.dgvFinanceLogs.ReadOnly = true;
            this.dgvFinanceLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanceLogs.Size = new System.Drawing.Size(494, 377);
            this.dgvFinanceLogs.TabIndex = 2;
            this.dgvFinanceLogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailInvoice);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colFinanceCurrency
            // 
            this.colFinanceCurrency.DataPropertyName = "FinanceCurrency";
            this.colFinanceCurrency.HeaderText = "币别";
            this.colFinanceCurrency.Name = "colFinanceCurrency";
            this.colFinanceCurrency.ReadOnly = true;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            // 
            // colCommission
            // 
            this.colCommission.DataPropertyName = "Commission";
            dataGridViewCellStyle3.Format = "N2";
            this.colCommission.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCommission.HeaderText = "手续费";
            this.colCommission.Name = "colCommission";
            this.colCommission.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // cmuLogMgr
            // 
            this.cmuLogMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLogDelete});
            this.cmuLogMgr.Name = "cmuContractMgr";
            this.cmuLogMgr.Size = new System.Drawing.Size(107, 26);
            // 
            // menuItemLogDelete
            // 
            this.menuItemLogDelete.Name = "menuItemLogDelete";
            this.menuItemLogDelete.Size = new System.Drawing.Size(106, 22);
            this.menuItemLogDelete.Text = "&D删除";
            this.menuItemLogDelete.Click += new System.EventHandler(this.DeleteLog);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "发票号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FinanceCurrency";
            this.dataGridViewTextBoxColumn2.HeaderText = "币别";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 111;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle5.Format = "N2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "融资金额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn4.HeaderText = "备注";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // lblInputDate
            // 
            lblInputDate.AutoSize = true;
            lblInputDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblInputDate.BackgroundStyle.Class = "";
            lblInputDate.Location = new System.Drawing.Point(60, 121);
            lblInputDate.Name = "lblInputDate";
            lblInputDate.Size = new System.Drawing.Size(47, 16);
            lblInputDate.TabIndex = 44;
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
            this.diInputDate.Location = new System.Drawing.Point(114, 120);
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
            this.diInputDate.Size = new System.Drawing.Size(134, 20);
            this.diInputDate.TabIndex = 45;
            // 
            // FinanceBatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 405);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "FinanceBatchDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "融资批次信息";
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.panelBatch.ResumeLayout(false);
            this.panelBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).EndInit();
            this.panelInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceLogs)).EndInit();
            this.cmuLogMgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInputDate)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFinanceLogs;
        private System.Windows.Forms.ContextMenuStrip cmuLogMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diInputDate;
    }
}