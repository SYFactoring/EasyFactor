//-----------------------------------------------------------------------
// <copyright file="InvoiceFinance.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    partial class InvoiceFinance
    {
		#region?Fields?(64)?

        private System.Windows.Forms.BindingSource batchBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx batchCurrencyComboBoxEx;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchExport;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchImport;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchNew;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSave;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSelect;
        private System.Windows.Forms.ContextMenuStrip cmuInvoiceFinance;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator3;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLogs;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX financeAmountTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX financeBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodBeginDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX financeRateTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx financeTypeComboBoxEx;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private DevComponents.DotNetBar.PanelEx panelFinanceBatch;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator7;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator8;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator9;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLineBalance;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalInterest;

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
            DevComponents.DotNetBar.LabelX financeBatchNoLabel;
            DevComponents.DotNetBar.LabelX financeAmountLabel;
            DevComponents.DotNetBar.LabelX financePeriodBeginLabel;
            DevComponents.DotNetBar.LabelX financeRateLabel;
            DevComponents.DotNetBar.LabelX financeTypeLabel;
            DevComponents.DotNetBar.LabelX lblTotalInterest;
            DevComponents.DotNetBar.LabelX lblFinanceLineBalance;
            DevComponents.DotNetBar.LabelX lblFinanceRateType1;
            DevComponents.DotNetBar.LabelX lblFinanceRateType2;
            DevComponents.DotNetBar.LabelX lblWhoPayInterest;
            DevComponents.DotNetBar.LabelX lblTotalCommission;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceFinance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFinanceBatch = new DevComponents.DotNetBar.PanelEx();
            this.tbTotalCommission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbWhoPayInterest = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbFinanceRateType2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbFinanceRateType1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnFinanceBatchImport = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchExport = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbFinanceLineBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTotalInterest = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFinanceBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.financeTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financePeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeAmountTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.batchCurrencyComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnpaidCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuInvoiceFinance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.customValidator3 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator9 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator4 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.reassignGracePeriodLabel = new DevComponents.DotNetBar.LabelX();
            this.reassignGracePeriodTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            financeBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            financeAmountLabel = new DevComponents.DotNetBar.LabelX();
            financePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            financeRateLabel = new DevComponents.DotNetBar.LabelX();
            financeTypeLabel = new DevComponents.DotNetBar.LabelX();
            lblTotalInterest = new DevComponents.DotNetBar.LabelX();
            lblFinanceLineBalance = new DevComponents.DotNetBar.LabelX();
            lblFinanceRateType1 = new DevComponents.DotNetBar.LabelX();
            lblFinanceRateType2 = new DevComponents.DotNetBar.LabelX();
            lblWhoPayInterest = new DevComponents.DotNetBar.LabelX();
            lblTotalCommission = new DevComponents.DotNetBar.LabelX();
            this.panelFinanceBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.cmuInvoiceFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // financeBatchNoLabel
            // 
            financeBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            financeBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeBatchNoLabel.Location = new System.Drawing.Point(15, 5);
            financeBatchNoLabel.Name = "financeBatchNoLabel";
            financeBatchNoLabel.Size = new System.Drawing.Size(62, 18);
            financeBatchNoLabel.TabIndex = 0;
            financeBatchNoLabel.Text = "融资批号:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeAmountLabel.Location = new System.Drawing.Point(15, 48);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(62, 18);
            financeAmountLabel.TabIndex = 13;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financePeriodBeginLabel
            // 
            financePeriodBeginLabel.AutoSize = true;
            // 
            // 
            // 
            financePeriodBeginLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financePeriodBeginLabel.Location = new System.Drawing.Point(416, 27);
            financePeriodBeginLabel.Name = "financePeriodBeginLabel";
            financePeriodBeginLabel.Size = new System.Drawing.Size(50, 18);
            financePeriodBeginLabel.TabIndex = 10;
            financePeriodBeginLabel.Text = "融资日:";
            // 
            // financeRateLabel
            // 
            financeRateLabel.AutoSize = true;
            // 
            // 
            // 
            financeRateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeRateLabel.Location = new System.Drawing.Point(15, 27);
            financeRateLabel.Name = "financeRateLabel";
            financeRateLabel.Size = new System.Drawing.Size(62, 18);
            financeRateLabel.TabIndex = 6;
            financeRateLabel.Text = "融资利率:";
            // 
            // financeTypeLabel
            // 
            financeTypeLabel.AutoSize = true;
            // 
            // 
            // 
            financeTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeTypeLabel.Location = new System.Drawing.Point(192, 6);
            financeTypeLabel.Name = "financeTypeLabel";
            financeTypeLabel.Size = new System.Drawing.Size(62, 18);
            financeTypeLabel.TabIndex = 4;
            financeTypeLabel.Text = "出账方式:";
            // 
            // lblTotalInterest
            // 
            lblTotalInterest.AutoSize = true;
            // 
            // 
            // 
            lblTotalInterest.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblTotalInterest.Location = new System.Drawing.Point(852, 27);
            lblTotalInterest.Name = "lblTotalInterest";
            lblTotalInterest.Size = new System.Drawing.Size(81, 18);
            lblTotalInterest.TabIndex = 23;
            lblTotalInterest.Text = "本次利息收入";
            // 
            // lblFinanceLineBalance
            // 
            lblFinanceLineBalance.AutoSize = true;
            // 
            // 
            // 
            lblFinanceLineBalance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblFinanceLineBalance.Location = new System.Drawing.Point(854, 5);
            lblFinanceLineBalance.Name = "lblFinanceLineBalance";
            lblFinanceLineBalance.Size = new System.Drawing.Size(81, 18);
            lblFinanceLineBalance.TabIndex = 25;
            lblFinanceLineBalance.Text = "本次融资差额";
            // 
            // lblFinanceRateType1
            // 
            lblFinanceRateType1.AutoSize = true;
            // 
            // 
            // 
            lblFinanceRateType1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblFinanceRateType1.Location = new System.Drawing.Point(192, 27);
            lblFinanceRateType1.Name = "lblFinanceRateType1";
            lblFinanceRateType1.Size = new System.Drawing.Size(62, 18);
            lblFinanceRateType1.TabIndex = 30;
            lblFinanceRateType1.Text = "收息方式:";
            // 
            // lblFinanceRateType2
            // 
            lblFinanceRateType2.AutoSize = true;
            // 
            // 
            // 
            lblFinanceRateType2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblFinanceRateType2.Location = new System.Drawing.Point(412, 49);
            lblFinanceRateType2.Name = "lblFinanceRateType2";
            lblFinanceRateType2.Size = new System.Drawing.Size(62, 18);
            lblFinanceRateType2.TabIndex = 32;
            lblFinanceRateType2.Text = "计息方式:";
            // 
            // lblWhoPayInterest
            // 
            lblWhoPayInterest.AutoSize = true;
            // 
            // 
            // 
            lblWhoPayInterest.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblWhoPayInterest.Location = new System.Drawing.Point(260, 50);
            lblWhoPayInterest.Name = "lblWhoPayInterest";
            lblWhoPayInterest.Size = new System.Drawing.Size(50, 18);
            lblWhoPayInterest.TabIndex = 34;
            lblWhoPayInterest.Text = "利息由:";
            // 
            // lblTotalCommission
            // 
            lblTotalCommission.AutoSize = true;
            // 
            // 
            // 
            lblTotalCommission.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblTotalCommission.Location = new System.Drawing.Point(841, 48);
            lblTotalCommission.Name = "lblTotalCommission";
            lblTotalCommission.Size = new System.Drawing.Size(93, 18);
            lblTotalCommission.TabIndex = 36;
            lblTotalCommission.Text = "本次手续费收入";
            // 
            // panelFinanceBatch
            // 
            this.panelFinanceBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinanceBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelFinanceBatch.Controls.Add(this.reassignGracePeriodLabel);
            this.panelFinanceBatch.Controls.Add(this.reassignGracePeriodTextBox);
            this.panelFinanceBatch.Controls.Add(this.tbTotalCommission);
            this.panelFinanceBatch.Controls.Add(lblTotalCommission);
            this.panelFinanceBatch.Controls.Add(this.cbWhoPayInterest);
            this.panelFinanceBatch.Controls.Add(lblWhoPayInterest);
            this.panelFinanceBatch.Controls.Add(this.cbFinanceRateType2);
            this.panelFinanceBatch.Controls.Add(lblFinanceRateType2);
            this.panelFinanceBatch.Controls.Add(this.cbFinanceRateType1);
            this.panelFinanceBatch.Controls.Add(lblFinanceRateType1);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchImport);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchExport);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSelect);
            this.panelFinanceBatch.Controls.Add(this.tbFinanceLineBalance);
            this.panelFinanceBatch.Controls.Add(lblFinanceLineBalance);
            this.panelFinanceBatch.Controls.Add(this.tbTotalInterest);
            this.panelFinanceBatch.Controls.Add(lblTotalInterest);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchNew);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSave);
            this.panelFinanceBatch.Controls.Add(financeTypeLabel);
            this.panelFinanceBatch.Controls.Add(this.financeTypeComboBoxEx);
            this.panelFinanceBatch.Controls.Add(financeRateLabel);
            this.panelFinanceBatch.Controls.Add(this.financeRateTextBox);
            this.panelFinanceBatch.Controls.Add(financePeriodBeginLabel);
            this.panelFinanceBatch.Controls.Add(this.financePeriodBeginDateTimePicker);
            this.panelFinanceBatch.Controls.Add(financeAmountLabel);
            this.panelFinanceBatch.Controls.Add(this.financeAmountTextBoxX);
            this.panelFinanceBatch.Controls.Add(this.batchCurrencyComboBoxEx);
            this.panelFinanceBatch.Controls.Add(financeBatchNoLabel);
            this.panelFinanceBatch.Controls.Add(this.financeBatchNoTextBox);
            this.panelFinanceBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelFinanceBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinanceBatch.Location = new System.Drawing.Point(0, 0);
            this.panelFinanceBatch.Name = "panelFinanceBatch";
            this.panelFinanceBatch.Size = new System.Drawing.Size(1257, 71);
            this.panelFinanceBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinanceBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinanceBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinanceBatch.Style.GradientAngle = 90;
            this.panelFinanceBatch.TabIndex = 0;
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
            this.tbTotalCommission.Location = new System.Drawing.Point(934, 46);
            this.tbTotalCommission.Name = "tbTotalCommission";
            this.tbTotalCommission.ReadOnly = true;
            this.tbTotalCommission.Size = new System.Drawing.Size(100, 21);
            this.tbTotalCommission.TabIndex = 37;
            this.tbTotalCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbWhoPayInterest
            // 
            this.cbWhoPayInterest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "WhoPayInterest", true));
            this.cbWhoPayInterest.DisplayMember = "Text";
            this.cbWhoPayInterest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbWhoPayInterest.FormattingEnabled = true;
            this.cbWhoPayInterest.ItemHeight = 14;
            this.cbWhoPayInterest.Location = new System.Drawing.Point(307, 49);
            this.cbWhoPayInterest.Name = "cbWhoPayInterest";
            this.cbWhoPayInterest.Size = new System.Drawing.Size(99, 20);
            this.cbWhoPayInterest.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbWhoPayInterest.TabIndex = 35;
            this.superValidator.SetValidator1(this.cbWhoPayInterest, this.requiredFieldValidator1);
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceFinanceBatch);
            // 
            // cbFinanceRateType2
            // 
            this.cbFinanceRateType2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceRateType2", true));
            this.cbFinanceRateType2.DisplayMember = "Text";
            this.cbFinanceRateType2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFinanceRateType2.FormattingEnabled = true;
            this.cbFinanceRateType2.ItemHeight = 14;
            this.cbFinanceRateType2.Location = new System.Drawing.Point(469, 48);
            this.cbFinanceRateType2.Name = "cbFinanceRateType2";
            this.cbFinanceRateType2.Size = new System.Drawing.Size(108, 20);
            this.cbFinanceRateType2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbFinanceRateType2.TabIndex = 33;
            this.superValidator.SetValidator1(this.cbFinanceRateType2, this.requiredFieldValidator1);
            // 
            // cbFinanceRateType1
            // 
            this.cbFinanceRateType1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceRateType1", true));
            this.cbFinanceRateType1.DisplayMember = "Text";
            this.cbFinanceRateType1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFinanceRateType1.FormattingEnabled = true;
            this.cbFinanceRateType1.ItemHeight = 14;
            this.cbFinanceRateType1.Location = new System.Drawing.Point(260, 27);
            this.cbFinanceRateType1.Name = "cbFinanceRateType1";
            this.cbFinanceRateType1.Size = new System.Drawing.Size(100, 20);
            this.cbFinanceRateType1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbFinanceRateType1.TabIndex = 31;
            this.superValidator.SetValidator1(this.cbFinanceRateType1, this.requiredFieldValidator1);
            // 
            // btnFinanceBatchImport
            // 
            this.btnFinanceBatchImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchImport.Location = new System.Drawing.Point(676, 32);
            this.btnFinanceBatchImport.Name = "btnFinanceBatchImport";
            this.btnFinanceBatchImport.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchImport.TabIndex = 29;
            this.btnFinanceBatchImport.Text = "导入批次";
            this.btnFinanceBatchImport.Click += new System.EventHandler(this.ImportFinanceBatch);
            // 
            // btnFinanceBatchExport
            // 
            this.btnFinanceBatchExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchExport.Location = new System.Drawing.Point(609, 32);
            this.btnFinanceBatchExport.Name = "btnFinanceBatchExport";
            this.btnFinanceBatchExport.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchExport.TabIndex = 20;
            this.btnFinanceBatchExport.Text = "导出批次";
            this.btnFinanceBatchExport.Click += new System.EventHandler(this.ExportFinanceBatch);
            // 
            // btnFinanceBatchSelect
            // 
            this.btnFinanceBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSelect.Enabled = false;
            this.btnFinanceBatchSelect.Location = new System.Drawing.Point(743, 6);
            this.btnFinanceBatchSelect.Name = "btnFinanceBatchSelect";
            this.btnFinanceBatchSelect.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchSelect.TabIndex = 27;
            this.btnFinanceBatchSelect.Text = "选择批次";
            this.btnFinanceBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // tbFinanceLineBalance
            // 
            this.tbFinanceLineBalance.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbFinanceLineBalance.Border.Class = "TextBoxBorder";
            this.tbFinanceLineBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFinanceLineBalance.DisabledBackColor = System.Drawing.Color.White;
            this.tbFinanceLineBalance.ForeColor = System.Drawing.Color.Black;
            this.tbFinanceLineBalance.Location = new System.Drawing.Point(934, 3);
            this.tbFinanceLineBalance.Name = "tbFinanceLineBalance";
            this.tbFinanceLineBalance.ReadOnly = true;
            this.tbFinanceLineBalance.Size = new System.Drawing.Size(100, 21);
            this.tbFinanceLineBalance.TabIndex = 26;
            this.tbFinanceLineBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalInterest
            // 
            this.tbTotalInterest.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTotalInterest.Border.Class = "TextBoxBorder";
            this.tbTotalInterest.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTotalInterest.DisabledBackColor = System.Drawing.Color.White;
            this.tbTotalInterest.ForeColor = System.Drawing.Color.Black;
            this.tbTotalInterest.Location = new System.Drawing.Point(934, 24);
            this.tbTotalInterest.Name = "tbTotalInterest";
            this.tbTotalInterest.ReadOnly = true;
            this.tbTotalInterest.Size = new System.Drawing.Size(100, 21);
            this.tbTotalInterest.TabIndex = 24;
            this.tbTotalInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFinanceBatchNew
            // 
            this.btnFinanceBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchNew.Location = new System.Drawing.Point(609, 6);
            this.btnFinanceBatchNew.Name = "btnFinanceBatchNew";
            this.btnFinanceBatchNew.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchNew.TabIndex = 19;
            this.btnFinanceBatchNew.Text = "新建批次";
            this.btnFinanceBatchNew.Click += new System.EventHandler(this.NewBatch);
            // 
            // btnFinanceBatchSave
            // 
            this.btnFinanceBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSave.Location = new System.Drawing.Point(676, 6);
            this.btnFinanceBatchSave.Name = "btnFinanceBatchSave";
            this.btnFinanceBatchSave.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchSave.TabIndex = 19;
            this.btnFinanceBatchSave.Text = "保存批次";
            this.btnFinanceBatchSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // financeTypeComboBoxEx
            // 
            this.financeTypeComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceType", true));
            this.financeTypeComboBoxEx.DisplayMember = "Text";
            this.financeTypeComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.financeTypeComboBoxEx.FormattingEnabled = true;
            this.financeTypeComboBoxEx.ItemHeight = 14;
            this.financeTypeComboBoxEx.Items.AddRange(new object[] {
            "全部",
            "保理预付款(表内)",
            "卖方代付",
            "买方代付",
            "银行承兑汇票",
            "商业承兑汇票",
            "国内信用证",
            "国际信用证",
            "其他"});
            this.financeTypeComboBoxEx.Location = new System.Drawing.Point(260, 4);
            this.financeTypeComboBoxEx.Name = "financeTypeComboBoxEx";
            this.financeTypeComboBoxEx.Size = new System.Drawing.Size(100, 20);
            this.financeTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.financeTypeComboBoxEx.TabIndex = 5;
            this.superValidator.SetValidator1(this.financeTypeComboBoxEx, this.requiredFieldValidator1);
            // 
            // financeRateTextBox
            // 
            this.financeRateTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.financeRateTextBox.Border.Class = "TextBoxBorder";
            this.financeRateTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "P4"));
            this.financeRateTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.financeRateTextBox.ForeColor = System.Drawing.Color.Black;
            this.financeRateTextBox.Location = new System.Drawing.Point(80, 25);
            this.financeRateTextBox.Name = "financeRateTextBox";
            this.financeRateTextBox.Size = new System.Drawing.Size(100, 21);
            this.financeRateTextBox.TabIndex = 7;
            this.superValidator.SetValidator1(this.financeRateTextBox, this.requiredFieldValidator3);
            this.superValidator.SetValidator2(this.financeRateTextBox, this.customValidator3);
            // 
            // financePeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodBeginDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.financePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "FinancePeriodBegin", true));
            this.financePeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.financePeriodBeginDateTimePicker.IsPopupCalendarOpen = false;
            this.financePeriodBeginDateTimePicker.Location = new System.Drawing.Point(469, 24);
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financePeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financePeriodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodBeginDateTimePicker.Name = "financePeriodBeginDateTimePicker";
            this.financePeriodBeginDateTimePicker.Size = new System.Drawing.Size(108, 21);
            this.financePeriodBeginDateTimePicker.TabIndex = 11;
            this.superValidator.SetValidator1(this.financePeriodBeginDateTimePicker, this.requiredFieldValidator4);
            this.superValidator.SetValidator2(this.financePeriodBeginDateTimePicker, this.customValidator1);
            // 
            // financeAmountTextBoxX
            // 
            this.financeAmountTextBoxX.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.financeAmountTextBoxX.Border.Class = "TextBoxBorder";
            this.financeAmountTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeAmountTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.financeAmountTextBoxX.DisabledBackColor = System.Drawing.Color.White;
            this.financeAmountTextBoxX.ForeColor = System.Drawing.Color.Black;
            this.financeAmountTextBoxX.Location = new System.Drawing.Point(154, 48);
            this.financeAmountTextBoxX.Name = "financeAmountTextBoxX";
            this.financeAmountTextBoxX.Size = new System.Drawing.Size(100, 21);
            this.financeAmountTextBoxX.TabIndex = 15;
            this.superValidator.SetValidator1(this.financeAmountTextBoxX, this.requiredFieldValidator9);
            // 
            // batchCurrencyComboBoxEx
            // 
            this.batchCurrencyComboBoxEx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.batchCurrencyComboBoxEx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.batchCurrencyComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "BatchCurrency", true));
            this.batchCurrencyComboBoxEx.DisplayMember = "Text";
            this.batchCurrencyComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.batchCurrencyComboBoxEx.FormattingEnabled = true;
            this.batchCurrencyComboBoxEx.ItemHeight = 14;
            this.batchCurrencyComboBoxEx.Location = new System.Drawing.Point(80, 48);
            this.batchCurrencyComboBoxEx.Name = "batchCurrencyComboBoxEx";
            this.batchCurrencyComboBoxEx.Size = new System.Drawing.Size(68, 20);
            this.batchCurrencyComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.batchCurrencyComboBoxEx.TabIndex = 14;
            this.superValidator.SetValidator1(this.batchCurrencyComboBoxEx, this.requiredFieldValidator8);
            // 
            // financeBatchNoTextBox
            // 
            this.financeBatchNoTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.financeBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.financeBatchNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceBatchNo", true));
            this.financeBatchNoTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.financeBatchNoTextBox.ForeColor = System.Drawing.Color.Black;
            this.financeBatchNoTextBox.Location = new System.Drawing.Point(80, 3);
            this.financeBatchNoTextBox.Name = "financeBatchNoTextBox";
            this.financeBatchNoTextBox.ReadOnly = true;
            this.financeBatchNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.financeBatchNoTextBox.TabIndex = 1;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToOrderColumns = true;
            this.dgvLogs.AutoGenerateColumns = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colInvoiceNo,
            this.colInvoiceAmount,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colInvoiceDate,
            this.colDueDate,
            this.colAssignDate,
            this.colInvoiceFinanceOutstanding,
            this.colInvoiceFinanceAmount,
            this.colFinanceAmount,
            this.colPaidCommission,
            this.colUnpaidCommission,
            this.colInterest,
            this.colComment});
            this.dgvLogs.ContextMenuStrip = this.cmuInvoiceFinance;
            this.dgvLogs.DataSource = this.logsBindingSource;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLogs.Location = new System.Drawing.Point(0, 96);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLogs.Size = new System.Drawing.Size(1257, 334);
            this.dgvLogs.TabIndex = 2;
            this.dgvLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoicesCellContentClick);
            this.dgvLogs.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvInvoicesCellValidating);
            this.dgvLogs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoicesCellValueChanged);
            this.dgvLogs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvInvoicesRowHeaderMouseDoubleClick);
            // 
            // colCheckBox
            // 
            this.colCheckBox.Frozen = true;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.ReadOnly = true;
            this.colCheckBox.Width = 20;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo2";
            this.colInvoiceNo.Frozen = true;
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.DataPropertyName = "InvoiceAmount";
            this.colInvoiceAmount.HeaderText = "票面金额";
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle22;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle23;
            this.colAssignOutstanding.HeaderText = "转让余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            this.colAssignOutstanding.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            this.colInvoiceDate.HeaderText = "发票日";
            this.colInvoiceDate.Name = "colInvoiceDate";
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate2";
            this.colDueDate.HeaderText = "发票到期日";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            // 
            // colInvoiceFinanceOutstanding
            // 
            this.colInvoiceFinanceOutstanding.DataPropertyName = "InvoiceFinanceOutstanding";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N2";
            this.colInvoiceFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle24;
            this.colInvoiceFinanceOutstanding.HeaderText = "融资余额";
            this.colInvoiceFinanceOutstanding.Name = "colInvoiceFinanceOutstanding";
            this.colInvoiceFinanceOutstanding.ReadOnly = true;
            // 
            // colInvoiceFinanceAmount
            // 
            this.colInvoiceFinanceAmount.DataPropertyName = "InvoiceFinanceAmount";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            this.colInvoiceFinanceAmount.DefaultCellStyle = dataGridViewCellStyle25;
            this.colInvoiceFinanceAmount.HeaderText = "已融资金额";
            this.colInvoiceFinanceAmount.Name = "colInvoiceFinanceAmount";
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle26;
            this.colFinanceAmount.HeaderText = "本次融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            // 
            // colPaidCommission
            // 
            this.colPaidCommission.DataPropertyName = "PaidCommission";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N2";
            this.colPaidCommission.DefaultCellStyle = dataGridViewCellStyle27;
            this.colPaidCommission.HeaderText = "已收手续费";
            this.colPaidCommission.Name = "colPaidCommission";
            // 
            // colUnpaidCommission
            // 
            this.colUnpaidCommission.DataPropertyName = "UnpaidCommission";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            this.colUnpaidCommission.DefaultCellStyle = dataGridViewCellStyle28;
            this.colUnpaidCommission.HeaderText = "未收手续费";
            this.colUnpaidCommission.Name = "colUnpaidCommission";
            // 
            // colInterest
            // 
            this.colInterest.DataPropertyName = "Interest";
            dataGridViewCellStyle29.Format = "N2";
            dataGridViewCellStyle29.NullValue = null;
            this.colInterest.DefaultCellStyle = dataGridViewCellStyle29;
            this.colInterest.HeaderText = "利息";
            this.colInterest.Name = "colInterest";
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // cmuInvoiceFinance
            // 
            this.cmuInvoiceFinance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCDADetail,
            this.menuItemCaseDetail});
            this.cmuInvoiceFinance.Name = "cmuInvoiceFinance";
            this.cmuInvoiceFinance.Size = new System.Drawing.Size(185, 70);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = null;
            this.invoiceBindingNavigator.BindingSource = this.logsBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = null;
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 71);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(1257, 25);
            this.invoiceBindingNavigator.TabIndex = 1;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
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
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator3
            // 
            this.customValidator3.ErrorMessage = "不能是负值";
            this.customValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator3.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator3ValidateValue);
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "融资期限不能早于转让日";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator1ValidateValue);
            // 
            // requiredFieldValidator9
            // 
            this.requiredFieldValidator9.ErrorMessage = "必填";
            this.requiredFieldValidator9.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator8
            // 
            this.requiredFieldValidator8.ErrorMessage = "必填";
            this.requiredFieldValidator8.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "必填";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.financePeriodBeginDateTimePicker;
            this.compareValidator1.ErrorMessage = "终止日期应该大于起始日期";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // customValidator4
            // 
            this.customValidator4.ErrorMessage = "不能是负值";
            this.customValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator4.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidator4ValidateValue);
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.ErrorMessage = "必填";
            this.requiredFieldValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // reassignGracePeriodLabel
            // 
            this.reassignGracePeriodLabel.AutoSize = true;
            this.reassignGracePeriodLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reassignGracePeriodLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reassignGracePeriodLabel.Location = new System.Drawing.Point(368, 5);
            this.reassignGracePeriodLabel.Name = "reassignGracePeriodLabel";
            this.reassignGracePeriodLabel.Size = new System.Drawing.Size(99, 18);
            this.reassignGracePeriodLabel.TabIndex = 20;
            this.reassignGracePeriodLabel.Text = "回购宽限期(天):";
            // 
            // reassignGracePeriodTextBox
            // 
            // 
            // 
            // 
            this.reassignGracePeriodTextBox.Border.Class = "TextBoxBorder";
            this.reassignGracePeriodTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reassignGracePeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "ReassignGracePeriod", true));
            this.reassignGracePeriodTextBox.Location = new System.Drawing.Point(469, 2);
            this.reassignGracePeriodTextBox.Name = "reassignGracePeriodTextBox";
            this.reassignGracePeriodTextBox.Size = new System.Drawing.Size(108, 21);
            this.reassignGracePeriodTextBox.TabIndex = 21;
            this.superValidator.SetValidator1(this.reassignGracePeriodTextBox, this.requiredFieldValidator2);
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // InvoiceFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelFinanceBatch);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceFinance";
            this.Size = new System.Drawing.Size(1257, 430);
            this.panelFinanceBatch.ResumeLayout(false);
            this.panelFinanceBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.cmuInvoiceFinance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFinanceRateType1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFinanceRateType2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbWhoPayInterest;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalCommission;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnpaidCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private DevComponents.DotNetBar.LabelX reassignGracePeriodLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX reassignGracePeriodTextBox;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
    }
}
