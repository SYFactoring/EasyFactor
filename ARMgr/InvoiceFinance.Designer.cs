namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    partial class InvoiceFinance
    {
        #region Fields (66)

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
        private DevComponents.DotNetBar.ButtonX btnFactorSelect;
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
        private DevComponents.DotNetBar.Controls.TextBoxX costRateTextBoxX;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeAmountTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX financeBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodBeginDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX financeRateTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx financeTypeComboBoxEx;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx interestTypeComboBoxEx;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.ToolStripMenuItem menuItemCaseDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDADetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private DevComponents.DotNetBar.PanelEx panelFinanceBatch;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator7;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator8;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator9;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLineBalance;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalInterest;

        #endregion Fields

        #region Methods (1)

        // Protected Methods (1) 

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

        #endregion Methods



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
            DevComponents.DotNetBar.LabelX interestTypeLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX costRateLabel;
            DevComponents.DotNetBar.LabelX financeTypeLabel;
            DevComponents.DotNetBar.LabelX lblTotalInterest;
            DevComponents.DotNetBar.LabelX lblFinanceLineBalance;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceFinance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFinanceBatch = new DevComponents.DotNetBar.PanelEx();
            this.btnFinanceBatchImport = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchExport = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbFinanceLineBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTotalInterest = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFinanceBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.financeTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costRateTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.interestTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financePeriodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financePeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeAmountTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.batchCurrencyComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuInvoiceFinance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCDADetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCaseDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator9 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator8 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            financeBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            financeAmountLabel = new DevComponents.DotNetBar.LabelX();
            financePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            financeRateLabel = new DevComponents.DotNetBar.LabelX();
            interestTypeLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            costRateLabel = new DevComponents.DotNetBar.LabelX();
            financeTypeLabel = new DevComponents.DotNetBar.LabelX();
            lblTotalInterest = new DevComponents.DotNetBar.LabelX();
            lblFinanceLineBalance = new DevComponents.DotNetBar.LabelX();
            this.panelFinanceBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.cmuInvoiceFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
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
            financeBatchNoLabel.BackgroundStyle.Class = "";
            financeBatchNoLabel.Location = new System.Drawing.Point(195, 3);
            financeBatchNoLabel.Name = "financeBatchNoLabel";
            financeBatchNoLabel.Size = new System.Drawing.Size(59, 16);
            financeBatchNoLabel.TabIndex = 2;
            financeBatchNoLabel.Text = "放款编号:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.Class = "";
            financeAmountLabel.Location = new System.Drawing.Point(15, 45);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(59, 16);
            financeAmountLabel.TabIndex = 13;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financePeriodBeginLabel
            // 
            financePeriodBeginLabel.AutoSize = true;
            // 
            // 
            // 
            financePeriodBeginLabel.BackgroundStyle.Class = "";
            financePeriodBeginLabel.Location = new System.Drawing.Point(375, 4);
            financePeriodBeginLabel.Name = "financePeriodBeginLabel";
            financePeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            financePeriodBeginLabel.TabIndex = 4;
            financePeriodBeginLabel.Text = "融资期限:";
            // 
            // financeRateLabel
            // 
            financeRateLabel.AutoSize = true;
            // 
            // 
            // 
            financeRateLabel.BackgroundStyle.Class = "";
            financeRateLabel.Location = new System.Drawing.Point(15, 25);
            financeRateLabel.Name = "financeRateLabel";
            financeRateLabel.Size = new System.Drawing.Size(59, 16);
            financeRateLabel.TabIndex = 7;
            financeRateLabel.Text = "融资利率:";
            // 
            // interestTypeLabel
            // 
            interestTypeLabel.AutoSize = true;
            // 
            // 
            // 
            interestTypeLabel.BackgroundStyle.Class = "";
            interestTypeLabel.Location = new System.Drawing.Point(376, 27);
            interestTypeLabel.Name = "interestTypeLabel";
            interestTypeLabel.Size = new System.Drawing.Size(59, 16);
            interestTypeLabel.TabIndex = 11;
            interestTypeLabel.Text = "收息方式:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Location = new System.Drawing.Point(375, 47);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            factorCodeLabel.TabIndex = 16;
            factorCodeLabel.Text = "代付行:";
            // 
            // costRateLabel
            // 
            costRateLabel.AutoSize = true;
            // 
            // 
            // 
            costRateLabel.BackgroundStyle.Class = "";
            costRateLabel.Location = new System.Drawing.Point(195, 25);
            costRateLabel.Name = "costRateLabel";
            costRateLabel.Size = new System.Drawing.Size(59, 16);
            costRateLabel.TabIndex = 9;
            costRateLabel.Text = "成本利率:";
            // 
            // financeTypeLabel
            // 
            financeTypeLabel.AutoSize = true;
            // 
            // 
            // 
            financeTypeLabel.BackgroundStyle.Class = "";
            financeTypeLabel.Location = new System.Drawing.Point(15, 5);
            financeTypeLabel.Name = "financeTypeLabel";
            financeTypeLabel.Size = new System.Drawing.Size(59, 16);
            financeTypeLabel.TabIndex = 0;
            financeTypeLabel.Text = "融资类型:";
            // 
            // lblTotalInterest
            // 
            lblTotalInterest.AutoSize = true;
            // 
            // 
            // 
            lblTotalInterest.BackgroundStyle.Class = "";
            lblTotalInterest.Location = new System.Drawing.Point(920, 26);
            lblTotalInterest.Name = "lblTotalInterest";
            lblTotalInterest.Size = new System.Drawing.Size(106, 16);
            lblTotalInterest.TabIndex = 23;
            lblTotalInterest.Text = "本次应收利息总额";
            // 
            // lblFinanceLineBalance
            // 
            lblFinanceLineBalance.AutoSize = true;
            // 
            // 
            // 
            lblFinanceLineBalance.BackgroundStyle.Class = "";
            lblFinanceLineBalance.Location = new System.Drawing.Point(945, 5);
            lblFinanceLineBalance.Name = "lblFinanceLineBalance";
            lblFinanceLineBalance.Size = new System.Drawing.Size(81, 16);
            lblFinanceLineBalance.TabIndex = 25;
            lblFinanceLineBalance.Text = "本次融资差额";
            // 
            // panelFinanceBatch
            // 
            this.panelFinanceBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinanceBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchImport);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchExport);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSelect);
            this.panelFinanceBatch.Controls.Add(this.tbFinanceLineBalance);
            this.panelFinanceBatch.Controls.Add(lblFinanceLineBalance);
            this.panelFinanceBatch.Controls.Add(this.tbTotalInterest);
            this.panelFinanceBatch.Controls.Add(lblTotalInterest);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchNew);
            this.panelFinanceBatch.Controls.Add(this.btnFactorSelect);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSave);
            this.panelFinanceBatch.Controls.Add(financeTypeLabel);
            this.panelFinanceBatch.Controls.Add(this.financeTypeComboBoxEx);
            this.panelFinanceBatch.Controls.Add(costRateLabel);
            this.panelFinanceBatch.Controls.Add(this.costRateTextBoxX);
            this.panelFinanceBatch.Controls.Add(factorCodeLabel);
            this.panelFinanceBatch.Controls.Add(this.factorCodeTextBox);
            this.panelFinanceBatch.Controls.Add(interestTypeLabel);
            this.panelFinanceBatch.Controls.Add(this.interestTypeComboBoxEx);
            this.panelFinanceBatch.Controls.Add(financeRateLabel);
            this.panelFinanceBatch.Controls.Add(this.financeRateTextBox);
            this.panelFinanceBatch.Controls.Add(this.financePeriodEndDateTimePicker);
            this.panelFinanceBatch.Controls.Add(financePeriodBeginLabel);
            this.panelFinanceBatch.Controls.Add(this.financePeriodBeginDateTimePicker);
            this.panelFinanceBatch.Controls.Add(financeAmountLabel);
            this.panelFinanceBatch.Controls.Add(this.financeAmountTextBoxX);
            this.panelFinanceBatch.Controls.Add(this.batchCurrencyComboBoxEx);
            this.panelFinanceBatch.Controls.Add(financeBatchNoLabel);
            this.panelFinanceBatch.Controls.Add(this.financeBatchNoTextBox);
            this.panelFinanceBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinanceBatch.Location = new System.Drawing.Point(0, 0);
            this.panelFinanceBatch.Name = "panelFinanceBatch";
            this.panelFinanceBatch.Size = new System.Drawing.Size(1257, 71);
            this.panelFinanceBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinanceBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinanceBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinanceBatch.Style.GradientAngle = 90;
            this.panelFinanceBatch.TabIndex = 0;
            // 
            // btnFinanceBatchImport
            // 
            this.btnFinanceBatchImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchImport.Location = new System.Drawing.Point(767, 35);
            this.btnFinanceBatchImport.Name = "btnFinanceBatchImport";
            this.btnFinanceBatchImport.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchImport.TabIndex = 29;
            this.btnFinanceBatchImport.Text = "导入批次";
            this.btnFinanceBatchImport.Click += new System.EventHandler(this.ImportFinanceBatch);
            // 
            // btnFinanceBatchExport
            // 
            this.btnFinanceBatchExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchExport.Location = new System.Drawing.Point(700, 35);
            this.btnFinanceBatchExport.Name = "btnFinanceBatchExport";
            this.btnFinanceBatchExport.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchExport.TabIndex = 28;
            this.btnFinanceBatchExport.Text = "导出批次";
            this.btnFinanceBatchExport.Click += new System.EventHandler(this.ExportFinanceBatch);
            // 
            // btnFinanceBatchSelect
            // 
            this.btnFinanceBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSelect.Location = new System.Drawing.Point(834, 6);
            this.btnFinanceBatchSelect.Name = "btnFinanceBatchSelect";
            this.btnFinanceBatchSelect.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchSelect.TabIndex = 27;
            this.btnFinanceBatchSelect.Text = "选择批次";
            this.btnFinanceBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // tbFinanceLineBalance
            // 
            // 
            // 
            // 
            this.tbFinanceLineBalance.Border.Class = "TextBoxBorder";
            this.tbFinanceLineBalance.Location = new System.Drawing.Point(1025, 3);
            this.tbFinanceLineBalance.Name = "tbFinanceLineBalance";
            this.tbFinanceLineBalance.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceLineBalance.TabIndex = 26;
            // 
            // tbTotalInterest
            // 
            // 
            // 
            // 
            this.tbTotalInterest.Border.Class = "TextBoxBorder";
            this.tbTotalInterest.Location = new System.Drawing.Point(1025, 24);
            this.tbTotalInterest.Name = "tbTotalInterest";
            this.tbTotalInterest.Size = new System.Drawing.Size(100, 20);
            this.tbTotalInterest.TabIndex = 24;
            // 
            // btnFinanceBatchNew
            // 
            this.btnFinanceBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchNew.Location = new System.Drawing.Point(700, 6);
            this.btnFinanceBatchNew.Name = "btnFinanceBatchNew";
            this.btnFinanceBatchNew.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchNew.TabIndex = 22;
            this.btnFinanceBatchNew.Text = "新建批次";
            this.btnFinanceBatchNew.Click += new System.EventHandler(this.NewFinanceBatch);
            // 
            // btnFactorSelect
            // 
            this.btnFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorSelect.Location = new System.Drawing.Point(546, 44);
            this.btnFactorSelect.Name = "btnFactorSelect";
            this.btnFactorSelect.Size = new System.Drawing.Size(28, 23);
            this.btnFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorSelect.TabIndex = 18;
            this.btnFactorSelect.Text = "...";
            this.btnFactorSelect.Click += new System.EventHandler(this.SelectFactor);
            // 
            // btnFinanceBatchSave
            // 
            this.btnFinanceBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSave.Location = new System.Drawing.Point(767, 6);
            this.btnFinanceBatchSave.Name = "btnFinanceBatchSave";
            this.btnFinanceBatchSave.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            "预付款",
            "卖方代付",
            "买方代付",
            "其他"});
            this.financeTypeComboBoxEx.Location = new System.Drawing.Point(80, 1);
            this.financeTypeComboBoxEx.Name = "financeTypeComboBoxEx";
            this.financeTypeComboBoxEx.Size = new System.Drawing.Size(100, 20);
            this.financeTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.financeTypeComboBoxEx.TabIndex = 1;
            this.superValidator.SetValidator1(this.financeTypeComboBoxEx, this.requiredFieldValidator1);
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceFinanceBatch);
            // 
            // costRateTextBoxX
            // 
            // 
            // 
            // 
            this.costRateTextBoxX.Border.Class = "TextBoxBorder";
            this.costRateTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CostRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "P3"));
            this.costRateTextBoxX.Location = new System.Drawing.Point(260, 24);
            this.costRateTextBoxX.Name = "costRateTextBoxX";
            this.costRateTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.costRateTextBoxX.TabIndex = 10;
            this.superValidator.SetValidator1(this.costRateTextBoxX, this.requiredFieldValidator6);
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FactorCode", true));
            this.factorCodeTextBox.Location = new System.Drawing.Point(440, 46);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.factorCodeTextBox.TabIndex = 17;
            // 
            // interestTypeComboBoxEx
            // 
            this.interestTypeComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "InterestType", true));
            this.interestTypeComboBoxEx.DisplayMember = "Text";
            this.interestTypeComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.interestTypeComboBoxEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interestTypeComboBoxEx.FormattingEnabled = true;
            this.interestTypeComboBoxEx.ItemHeight = 14;
            this.interestTypeComboBoxEx.Location = new System.Drawing.Point(441, 24);
            this.interestTypeComboBoxEx.Name = "interestTypeComboBoxEx";
            this.interestTypeComboBoxEx.Size = new System.Drawing.Size(121, 20);
            this.interestTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.interestTypeComboBoxEx.TabIndex = 12;
            this.superValidator.SetValidator1(this.interestTypeComboBoxEx, this.requiredFieldValidator7);
            // 
            // financeRateTextBox
            // 
            // 
            // 
            // 
            this.financeRateTextBox.Border.Class = "TextBoxBorder";
            this.financeRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "P3"));
            this.financeRateTextBox.Location = new System.Drawing.Point(80, 23);
            this.financeRateTextBox.Name = "financeRateTextBox";
            this.financeRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeRateTextBox.TabIndex = 8;
            this.superValidator.SetValidator1(this.financeRateTextBox, this.requiredFieldValidator3);
            // 
            // financePeriodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "FinancePeriodEnd", true));
            this.financePeriodEndDateTimePicker.Location = new System.Drawing.Point(572, 3);
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
            this.financePeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financePeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financePeriodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodEndDateTimePicker.Name = "financePeriodEndDateTimePicker";
            this.financePeriodEndDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.financePeriodEndDateTimePicker.TabIndex = 6;
            this.superValidator.SetValidator1(this.financePeriodEndDateTimePicker, this.requiredFieldValidator5);
            this.superValidator.SetValidator2(this.financePeriodEndDateTimePicker, this.compareValidator1);
            // 
            // financePeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.batchBindingSource, "FinancePeriodBegin", true));
            this.financePeriodBeginDateTimePicker.Location = new System.Drawing.Point(440, 3);
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
            this.financePeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financePeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financePeriodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodBeginDateTimePicker.Name = "financePeriodBeginDateTimePicker";
            this.financePeriodBeginDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.financePeriodBeginDateTimePicker.TabIndex = 5;
            this.superValidator.SetValidator1(this.financePeriodBeginDateTimePicker, this.requiredFieldValidator4);
            // 
            // financeAmountTextBoxX
            // 
            // 
            // 
            // 
            this.financeAmountTextBoxX.Border.Class = "TextBoxBorder";
            this.financeAmountTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.financeAmountTextBoxX.Location = new System.Drawing.Point(154, 45);
            this.financeAmountTextBoxX.Name = "financeAmountTextBoxX";
            this.financeAmountTextBoxX.Size = new System.Drawing.Size(100, 20);
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
            this.batchCurrencyComboBoxEx.Location = new System.Drawing.Point(80, 44);
            this.batchCurrencyComboBoxEx.Name = "batchCurrencyComboBoxEx";
            this.batchCurrencyComboBoxEx.Size = new System.Drawing.Size(68, 20);
            this.batchCurrencyComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.batchCurrencyComboBoxEx.TabIndex = 14;
            this.superValidator.SetValidator1(this.batchCurrencyComboBoxEx, this.requiredFieldValidator8);
            // 
            // financeBatchNoTextBox
            // 
            // 
            // 
            // 
            this.financeBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.financeBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceBatchNo", true));
            this.financeBatchNoTextBox.Location = new System.Drawing.Point(260, 2);
            this.financeBatchNoTextBox.Name = "financeBatchNoTextBox";
            this.financeBatchNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeBatchNoTextBox.TabIndex = 3;
            this.superValidator.SetValidator1(this.financeBatchNoTextBox, this.requiredFieldValidator2);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colInvoiceNo,
            this.colAssignAmount,
            this.colAssignOutstanding,
            this.colInvoiceDate,
            this.colAssignDate,
            this.colDueDate,
            this.colFinanceAmount,
            this.colFinanceOutstanding,
            this.colInterest,
            this.colInterestDate,
            this.colCommission,
            this.colCommissionDate,
            this.colComment});
            this.dgvInvoices.ContextMenuStrip = this.cmuInvoiceFinance;
            this.dgvInvoices.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 96);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1257, 370);
            this.dgvInvoices.TabIndex = 2;
            this.dgvInvoices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellValueChanged);
            this.dgvInvoices.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvInvoices_CellValidating);
            this.dgvInvoices.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_RowHeaderMouseDoubleClick);
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            // 
            // cmuInvoiceFinance
            // 
            this.cmuInvoiceFinance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.menuItemCDADetail,
            this.menuItemCaseDetail});
            this.cmuInvoiceFinance.Name = "cmuInvoiceFinance";
            this.cmuInvoiceFinance.Size = new System.Drawing.Size(183, 70);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // menuItemCDADetail
            // 
            this.menuItemCDADetail.Name = "menuItemCDADetail";
            this.menuItemCDADetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemCDADetail.Text = "额度通知书详细信息";
            this.menuItemCDADetail.Click += new System.EventHandler(this.DetailCDA);
            // 
            // menuItemCaseDetail
            // 
            this.menuItemCaseDetail.Name = "menuItemCaseDetail";
            this.menuItemCaseDetail.Size = new System.Drawing.Size(182, 22);
            this.menuItemCaseDetail.Text = "案子详细信息";
            this.menuItemCaseDetail.Click += new System.EventHandler(this.DetailCase);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Invoice);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
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
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
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
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "必填";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.ErrorMessage = "必填";
            this.requiredFieldValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // colCheckBox
            // 
            this.colCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCheckBox.Frozen = true;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.ReadOnly = true;
            this.colCheckBox.Width = 5;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.Frozen = true;
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmount";
            dataGridViewCellStyle1.Format = "N2";
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAssignAmount.HeaderText = "转让金额";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle2.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle2;
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
            // colAssignDate
            // 
            this.colAssignDate.DataPropertyName = "AssignDate";
            this.colAssignDate.HeaderText = "转让日";
            this.colAssignDate.Name = "colAssignDate";
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "发票到期日";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle3.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            // 
            // colFinanceOutstanding
            // 
            this.colFinanceOutstanding.DataPropertyName = "FinanceOutstanding";
            dataGridViewCellStyle4.Format = "N2";
            this.colFinanceOutstanding.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFinanceOutstanding.HeaderText = "融资余额";
            this.colFinanceOutstanding.Name = "colFinanceOutstanding";
            this.colFinanceOutstanding.ReadOnly = true;
            // 
            // colInterest
            // 
            this.colInterest.DataPropertyName = "Interest";
            dataGridViewCellStyle5.Format = "N2";
            this.colInterest.DefaultCellStyle = dataGridViewCellStyle5;
            this.colInterest.HeaderText = "利息";
            this.colInterest.Name = "colInterest";
            // 
            // colInterestDate
            // 
            this.colInterestDate.DataPropertyName = "InterestDate";
            this.colInterestDate.HeaderText = "利息日";
            this.colInterestDate.Name = "colInterestDate";
            // 
            // colCommission
            // 
            this.colCommission.DataPropertyName = "Commission";
            dataGridViewCellStyle6.Format = "N2";
            this.colCommission.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCommission.HeaderText = "手续费";
            this.colCommission.Name = "colCommission";
            // 
            // colCommissionDate
            // 
            this.colCommissionDate.DataPropertyName = "CommissionDate";
            this.colCommissionDate.HeaderText = "收费日";
            this.colCommissionDate.Name = "colCommissionDate";
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // InvoiceFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelFinanceBatch);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceFinance";
            this.Size = new System.Drawing.Size(1257, 466);
            this.panelFinanceBatch.ResumeLayout(false);
            this.panelFinanceBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.cmuInvoiceFinance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
    }
}
