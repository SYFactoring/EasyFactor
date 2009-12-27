namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoiceFinance
    {
        #region Fields (78)

        private DevComponents.DotNetBar.Controls.ComboBoxEx batchCurrencyComboBoxEx;
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
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX costRateTextBoxX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeAmountTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX financeBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodBeginDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX financeRateTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx financeTypeComboBoxEx;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput finnacePeriodEndDateTimePicker;
        private DevComponents.DotNetBar.Controls.ComboBoxEx interestTypeComboBoxEx;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.BindingSource invoiceFinanceBatchBindingSource;
        private DevComponents.DotNetBar.PanelEx panelFinanceBatch;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceFinance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFinanceBatch = new DevComponents.DotNetBar.PanelEx();
            this.btnFinanceBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.financeTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.invoiceFinanceBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costRateTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.interestTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.finnacePeriodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financePeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeAmountTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.batchCurrencyComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.cmuInvoiceFinance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFinanceBatchImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCDAFinanceBatchImport = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new CMBC.EasyFactor.Utils.CalendarColumn();
            this.colFinanceDueDate = new CMBC.EasyFactor.Utils.CalendarColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            financeBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            financeAmountLabel = new DevComponents.DotNetBar.LabelX();
            financePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            financeRateLabel = new DevComponents.DotNetBar.LabelX();
            interestTypeLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            costRateLabel = new DevComponents.DotNetBar.LabelX();
            financeTypeLabel = new DevComponents.DotNetBar.LabelX();
            this.panelFinanceBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFinanceBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finnacePeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            this.cmuInvoiceFinance.SuspendLayout();
            this.SuspendLayout();
            // 
            // financeBatchNoLabel
            // 
            financeBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            financeBatchNoLabel.BackgroundStyle.Class = "";
            financeBatchNoLabel.Location = new System.Drawing.Point(15, 27);
            financeBatchNoLabel.Name = "financeBatchNoLabel";
            financeBatchNoLabel.Size = new System.Drawing.Size(59, 16);
            financeBatchNoLabel.TabIndex = 0;
            financeBatchNoLabel.Text = "放款编号:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.Class = "";
            financeAmountLabel.Location = new System.Drawing.Point(15, 71);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(59, 16);
            financeAmountLabel.TabIndex = 4;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financePeriodBeginLabel
            // 
            financePeriodBeginLabel.AutoSize = true;
            // 
            // 
            // 
            financePeriodBeginLabel.BackgroundStyle.Class = "";
            financePeriodBeginLabel.Location = new System.Drawing.Point(195, 27);
            financePeriodBeginLabel.Name = "financePeriodBeginLabel";
            financePeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            financePeriodBeginLabel.TabIndex = 6;
            financePeriodBeginLabel.Text = "融资期限:";
            // 
            // financeRateLabel
            // 
            financeRateLabel.AutoSize = true;
            // 
            // 
            // 
            financeRateLabel.BackgroundStyle.Class = "";
            financeRateLabel.Location = new System.Drawing.Point(15, 49);
            financeRateLabel.Name = "financeRateLabel";
            financeRateLabel.Size = new System.Drawing.Size(59, 16);
            financeRateLabel.TabIndex = 9;
            financeRateLabel.Text = "融资利率:";
            // 
            // interestTypeLabel
            // 
            interestTypeLabel.AutoSize = true;
            // 
            // 
            // 
            interestTypeLabel.BackgroundStyle.Class = "";
            interestTypeLabel.Location = new System.Drawing.Point(376, 46);
            interestTypeLabel.Name = "interestTypeLabel";
            interestTypeLabel.Size = new System.Drawing.Size(59, 16);
            interestTypeLabel.TabIndex = 11;
            interestTypeLabel.Text = "计息方式:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Location = new System.Drawing.Point(27, 93);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            factorCodeLabel.TabIndex = 14;
            factorCodeLabel.Text = "代付行:";
            // 
            // costRateLabel
            // 
            costRateLabel.AutoSize = true;
            // 
            // 
            // 
            costRateLabel.BackgroundStyle.Class = "";
            costRateLabel.Location = new System.Drawing.Point(195, 46);
            costRateLabel.Name = "costRateLabel";
            costRateLabel.Size = new System.Drawing.Size(59, 16);
            costRateLabel.TabIndex = 16;
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
            financeTypeLabel.TabIndex = 18;
            financeTypeLabel.Text = "融资类型:";
            // 
            // panelFinanceBatch
            // 
            this.panelFinanceBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinanceBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSelect);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchNew);
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
            this.panelFinanceBatch.Controls.Add(this.finnacePeriodEndDateTimePicker);
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
            this.panelFinanceBatch.Size = new System.Drawing.Size(781, 123);
            this.panelFinanceBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinanceBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinanceBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinanceBatch.Style.GradientAngle = 90;
            this.panelFinanceBatch.TabIndex = 0;
            // 
            // btnFinanceBatchSelect
            // 
            this.btnFinanceBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSelect.Location = new System.Drawing.Point(474, 85);
            this.btnFinanceBatchSelect.Name = "btnFinanceBatchSelect";
            this.btnFinanceBatchSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFinanceBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchSelect.TabIndex = 22;
            this.btnFinanceBatchSelect.Text = "选择批次";
            this.btnFinanceBatchSelect.Click += new System.EventHandler(this.SelectFinanceBatch);
            // 
            // btnFinanceBatchNew
            // 
            this.btnFinanceBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchNew.Location = new System.Drawing.Point(393, 86);
            this.btnFinanceBatchNew.Name = "btnFinanceBatchNew";
            this.btnFinanceBatchNew.Size = new System.Drawing.Size(75, 23);
            this.btnFinanceBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchNew.TabIndex = 21;
            this.btnFinanceBatchNew.Text = "新建批次";
            this.btnFinanceBatchNew.Click += new System.EventHandler(this.NewFinanceBatch);
            // 
            // btnFinanceBatchSave
            // 
            this.btnFinanceBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSave.Location = new System.Drawing.Point(555, 86);
            this.btnFinanceBatchSave.Name = "btnFinanceBatchSave";
            this.btnFinanceBatchSave.Size = new System.Drawing.Size(75, 23);
            this.btnFinanceBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchSave.TabIndex = 20;
            this.btnFinanceBatchSave.Text = "保存";
            this.btnFinanceBatchSave.Click += new System.EventHandler(this.SaveFinanceBatch);
            // 
            // financeTypeComboBoxEx
            // 
            this.financeTypeComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "FinanceType", true));
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
            this.financeTypeComboBoxEx.TabIndex = 19;
            // 
            // invoiceFinanceBatchBindingSource
            // 
            this.invoiceFinanceBatchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceFinanceBatch);
            // 
            // costRateTextBoxX
            // 
            // 
            // 
            // 
            this.costRateTextBoxX.Border.Class = "TextBoxBorder";
            this.costRateTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "CostRate", true));
            this.costRateTextBoxX.Location = new System.Drawing.Point(260, 45);
            this.costRateTextBoxX.Name = "costRateTextBoxX";
            this.costRateTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.costRateTextBoxX.TabIndex = 17;
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "FactorCode", true));
            this.factorCodeTextBox.Location = new System.Drawing.Point(80, 89);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.factorCodeTextBox.TabIndex = 15;
            // 
            // interestTypeComboBoxEx
            // 
            this.interestTypeComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "InterestType", true));
            this.interestTypeComboBoxEx.DisplayMember = "Text";
            this.interestTypeComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.interestTypeComboBoxEx.FormattingEnabled = true;
            this.interestTypeComboBoxEx.ItemHeight = 14;
            this.interestTypeComboBoxEx.Location = new System.Drawing.Point(441, 45);
            this.interestTypeComboBoxEx.Name = "interestTypeComboBoxEx";
            this.interestTypeComboBoxEx.Size = new System.Drawing.Size(121, 20);
            this.interestTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.interestTypeComboBoxEx.TabIndex = 12;
            // 
            // financeRateTextBox
            // 
            // 
            // 
            // 
            this.financeRateTextBox.Border.Class = "TextBoxBorder";
            this.financeRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "FinanceRate", true));
            this.financeRateTextBox.Location = new System.Drawing.Point(80, 45);
            this.financeRateTextBox.Name = "financeRateTextBox";
            this.financeRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeRateTextBox.TabIndex = 10;
            // 
            // finnacePeriodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.finnacePeriodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.finnacePeriodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.finnacePeriodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceFinanceBatchBindingSource, "FinnacePeriodEnd", true));
            this.finnacePeriodEndDateTimePicker.Location = new System.Drawing.Point(376, 23);
            // 
            // 
            // 
            this.finnacePeriodEndDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.finnacePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.finnacePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.finnacePeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.finnacePeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.finnacePeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.finnacePeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.finnacePeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.finnacePeriodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.finnacePeriodEndDateTimePicker.Name = "finnacePeriodEndDateTimePicker";
            this.finnacePeriodEndDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.finnacePeriodEndDateTimePicker.TabIndex = 9;
            // 
            // financePeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceFinanceBatchBindingSource, "FinancePeriodBegin", true));
            this.financePeriodBeginDateTimePicker.Location = new System.Drawing.Point(260, 23);
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
            this.financePeriodBeginDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.financePeriodBeginDateTimePicker.TabIndex = 7;
            // 
            // financeAmountTextBoxX
            // 
            // 
            // 
            // 
            this.financeAmountTextBoxX.Border.Class = "TextBoxBorder";
            this.financeAmountTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "FinanceAmount", true));
            this.financeAmountTextBoxX.Location = new System.Drawing.Point(135, 67);
            this.financeAmountTextBoxX.Name = "financeAmountTextBoxX";
            this.financeAmountTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.financeAmountTextBoxX.TabIndex = 5;
            // 
            // batchCurrencyComboBoxEx
            // 
            this.batchCurrencyComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "BatchCurrency", true));
            this.batchCurrencyComboBoxEx.DisplayMember = "Text";
            this.batchCurrencyComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.batchCurrencyComboBoxEx.FormattingEnabled = true;
            this.batchCurrencyComboBoxEx.ItemHeight = 14;
            this.batchCurrencyComboBoxEx.Location = new System.Drawing.Point(80, 67);
            this.batchCurrencyComboBoxEx.Name = "batchCurrencyComboBoxEx";
            this.batchCurrencyComboBoxEx.Size = new System.Drawing.Size(49, 20);
            this.batchCurrencyComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.batchCurrencyComboBoxEx.TabIndex = 3;
            // 
            // financeBatchNoTextBox
            // 
            // 
            // 
            // 
            this.financeBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.financeBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceFinanceBatchBindingSource, "FinanceBatchNo", true));
            this.financeBatchNoTextBox.Location = new System.Drawing.Point(80, 24);
            this.financeBatchNoTextBox.Name = "financeBatchNoTextBox";
            this.financeBatchNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeBatchNoTextBox.TabIndex = 1;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFinanceAmount,
            this.colFinanceDate,
            this.colFinanceDueDate,
            this.colComment,
            this.colInvoiceNo});
            this.dgvInvoices.DataSource = this.invoiceBindingSource;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInvoices.Location = new System.Drawing.Point(0, 148);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(781, 318);
            this.dgvInvoices.TabIndex = 2;
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
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 123);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(781, 25);
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
            // cmuInvoiceFinance
            // 
            this.cmuInvoiceFinance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInvoiceDetail,
            this.toolStripSeparator1,
            this.menuItemFinanceBatchImport,
            this.toolStripSeparator2,
            this.menuItemCDAFinanceBatchImport});
            this.cmuInvoiceFinance.Name = "cmuInvoiceFinance";
            this.cmuInvoiceFinance.Size = new System.Drawing.Size(135, 82);
            // 
            // menuItemInvoiceDetail
            // 
            this.menuItemInvoiceDetail.Name = "menuItemInvoiceDetail";
            this.menuItemInvoiceDetail.Size = new System.Drawing.Size(134, 22);
            this.menuItemInvoiceDetail.Text = "详细信息";
            this.menuItemInvoiceDetail.Click += new System.EventHandler(this.DetailInvoice);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // menuItemFinanceBatchImport
            // 
            this.menuItemFinanceBatchImport.Name = "menuItemFinanceBatchImport";
            this.menuItemFinanceBatchImport.Size = new System.Drawing.Size(134, 22);
            this.menuItemFinanceBatchImport.Text = "按批次导入";
            this.menuItemFinanceBatchImport.Click += new System.EventHandler(this.ImportFinanceBatch);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // menuItemCDAFinanceBatchImport
            // 
            this.menuItemCDAFinanceBatchImport.Name = "menuItemCDAFinanceBatchImport";
            this.menuItemCDAFinanceBatchImport.Size = new System.Drawing.Size(134, 22);
            this.menuItemCDAFinanceBatchImport.Text = "按CDA导入";
            this.menuItemCDAFinanceBatchImport.Click += new System.EventHandler(this.ImportFinanceBatchByCDA);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            dataGridViewCellStyle4.Format = "N2";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "发票号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FinanceDate";
            dataGridViewCellStyle5.Format = "d";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "融资日";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FinanceDueDate";
            dataGridViewCellStyle6.Format = "d";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "融资到期日";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn4.HeaderText = "备注";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle1.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            // 
            // colFinanceDate
            // 
            this.colFinanceDate.DataPropertyName = "FinanceDate";
            dataGridViewCellStyle2.Format = "d";
            this.colFinanceDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFinanceDate.HeaderText = "融资日";
            this.colFinanceDate.Name = "colFinanceDate";
            this.colFinanceDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFinanceDueDate
            // 
            this.colFinanceDueDate.DataPropertyName = "FinanceDueDate";
            dataGridViewCellStyle3.Format = "d";
            this.colFinanceDueDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFinanceDueDate.HeaderText = "融资到期日";
            this.colFinanceDueDate.Name = "colFinanceDueDate";
            this.colFinanceDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinanceDueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = false;
            // 
            // InvoiceFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.panelFinanceBatch);
            this.Name = "InvoiceFinance";
            this.Size = new System.Drawing.Size(781, 466);
            this.panelFinanceBatch.ResumeLayout(false);
            this.panelFinanceBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFinanceBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finnacePeriodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            this.cmuInvoiceFinance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmuInvoiceFinance;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvoiceDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemCDAFinanceBatchImport;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSelect;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchNew;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemFinanceBatchImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private CMBC.EasyFactor.Utils.CalendarColumn colFinanceDate;
        private CMBC.EasyFactor.Utils.CalendarColumn colFinanceDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
    }
}
